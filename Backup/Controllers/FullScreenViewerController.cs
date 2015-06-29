using System.Web.Mvc;

namespace DevExpress.Web.Demos.Controllers {
    public class FullScreenViewerController : Controller {
        public ActionResult Index(int? height, int? width, string url) {
            return PartialView("FullScreenViewer",  new FullScreenViewerModel(url, height ?? 0, width ?? 0));
        }
    }
}
