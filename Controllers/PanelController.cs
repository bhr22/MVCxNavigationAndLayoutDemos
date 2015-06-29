using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class PanelController : DemoController {
        public override string Name { get { return "Panel"; } }

        public ActionResult Index() {
            return FixedPosition();
        }
        protected override void OnActionExecuted(ActionExecutedContext filterContext) {
            base.OnActionExecuted(filterContext);
            if((Utils.CurrentDemo == null || Utils.IsBogusDemo) && filterContext.ActionDescriptor.ActionName.StartsWith("ResponsiveLayout"))
                DevExpressHelper.Theme = "Moderno";
        }
    }
}
