﻿using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class TreeViewController: DemoController {     
        public ActionResult Overview() {
            return DemoView("Overview");
        }
    }
}
