using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FormLayoutController: DemoController {
        public ActionResult Features() {
            ViewBag.FeaturesDemoOptions = new FormLayoutFeaturesDemoOptions();
            return DemoView("Features", new FormLayoutFeaturesModel());
        }
        [HttpPost]
        public ActionResult Features(FormLayoutFeaturesModel model, FormLayoutFeaturesDemoOptions options) {
            ViewBag.FeaturesDemoOptions = options;
            return DemoView("Features", model);
        }
    }
}
