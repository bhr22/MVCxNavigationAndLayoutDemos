using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.Web.Demos {
    public partial class RibbonController: DemoController {
        public override string Name { get { return "Ribbon"; } }

        public ActionResult Index() {
            return RedirectToAction("Features");
        }
    }

    public class RibbonFeaturesDemoOptions {
        public RibbonFeaturesDemoOptions() {
            AllowMinimize = true;
            ShowFileTab = true;
            ShowTabs = true;
            ShowGroupNames = true;
        }
        [Display(Name = "Allow Minimize")]
        public bool AllowMinimize { get; set; }
        [Display(Name = "Show File Tab")]
        public bool ShowFileTab { get; set; }
        [Display(Name = "Show Tabs")]
        public bool ShowTabs { get; set; }
        [Display(Name = "Show Group Names")]
        public bool ShowGroupNames { get; set; }
    }
}
