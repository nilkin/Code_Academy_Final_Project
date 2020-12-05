using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ZoNaN.Data;
using ZoNaN.Data.Models;
using ZoNaN.Filter;
using static ZoNaN.Services.FileUploader;

namespace ZoNaN.Areas.Manager.Controllers
{
    [Area("Manager")]
    public class CommentsController : Controller
    {
        private readonly ZonanDbContext _context;
        private readonly IFileManager _fileManager;
        public CommentsController(ZonanDbContext context, IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }
        // GET: CommentsController
        public async Task<IActionResult> Index()
        {
            var zonanDbContext = _context.Comments.Include(m => m.Blog);
            return View(await zonanDbContext.ToListAsync());
        }


        // GET: CommentsController/Create
        [TypeFilter(typeof(AdminAuth))]
        public ActionResult Create()
        {
            ViewData["BlogId"] = new SelectList(_context.Blogs, "Id", "Name");
            return View();
        }

        // POST: CommentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [TypeFilter(typeof(AdminAuth))]
        public async Task<IActionResult> Create(Comment comment)
        {
            if (comment.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (comment.Upload.ContentType != "image/jpeg" && comment.Upload.ContentType
                    != "image/png" && comment.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }

                if (comment.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                comment.Photo = _fileManager.Upload(comment.Upload, "wwwroot/uploads");
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BlogId"] =
                new SelectList(_context.Blogs, "Id", "Name",
                comment.BlogId);
            return View(comment);
        }

        // GET: CommentsController/Edit/5
        [TypeFilter(typeof(AdminAuth))]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            ViewData["BlogId"] =
                new SelectList(_context.Blogs, "Id", "Name",
                comment.BlogId);
            return View(comment);
        }

        // POST: CommentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [TypeFilter(typeof(AdminAuth))]
        public async Task<ActionResult> Edit(int id, Comment comment)
        {
            if (id != comment.Id)
            {
                return NotFound();
            }
            if (comment.Upload == null)
            {
                ModelState.AddModelError("Upload", "Photo is required");
            }
            else
            {
                if (comment.Upload.ContentType != "image/jpeg" && comment.Upload.ContentType != "image/png"
                 && comment.Upload.ContentType != "image/gif")
                {
                    ModelState.AddModelError("Upload", "You can only download png, jpg or gif file");
                }
                if (comment.Upload.Length > 1048576)
                {
                    ModelState.AddModelError("Upload", "The file size can be a maximum of 1 MB");
                }
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _fileManager.Delete(comment.Photo);
                    comment.Photo = _fileManager.Upload(comment.Upload);
                    _context.Update(comment).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentsExists(comment.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BlogId"] = new SelectList(_context.Blogs, "Id",
                "Name", comment.BlogId);
            return View(comment);
        }

        private bool CommentsExists(int id)
        {
            return _context.Comments.Any(e => e.Id == id);
        }

        // POST: CommentsController/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            var comment = _context.Comments.Find(Id);

            if (comment == null) return NotFound();

            _fileManager.Delete(comment.Photo);

            _context.Comments.Remove(comment);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
