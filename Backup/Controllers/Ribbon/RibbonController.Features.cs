using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class RibbonController: DemoController {
        public ActionResult Features() {
            return DemoView("Features", new RibbonFeaturesDemoOptions());
        }
        [HttpPost]
        public ActionResult Features(RibbonFeaturesDemoOptions options) {
            return DemoView("Features", options);
        }
    }
}
