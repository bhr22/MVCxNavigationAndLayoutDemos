using System.Web.Mvc;
using System.Linq;
using System.Collections;

namespace DevExpress.Web.Demos {
    public partial class FormLayoutController: DemoController {
        public ActionResult DataBinding() {
            return DemoView("DataBinding", NorthwindDataProvider.GetEditableEmployees().First());
        }
        [HttpPost]
        public ActionResult DataBindingApplyChanges(EditableEmployee employee) {
            NorthwindDataProvider.UpdateEditableEmployee(employee);
            return DemoView("DataBinding", NorthwindDataProvider.GetEditableEmployeeByID(employee.EmployeeID));
        }
        public ActionResult DataBindingPartial(int employeeID) {
            return PartialView("DataBindingPartial", NorthwindDataProvider.GetEditableEmployeeByID(employeeID));
        }
    }
}
