using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Comment
{
    public class _CommentListPartial:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var comments = commentManager.TGetByDestinationId(id);
            return View(comments);
        }
    }
}
