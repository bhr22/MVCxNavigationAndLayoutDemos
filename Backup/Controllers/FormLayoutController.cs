using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DevExpress.Web.Demos {
    public partial class FormLayoutController : DemoController {
        public override string Name { get { return "FormLayout"; } }

        public ActionResult Index() {
            return RedirectToAction("Features");
        }
    }

    public class FormLayoutFeaturesModel {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
    public class FormLayoutOverviewModel {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Other Notes")]
        public string Note { get; set; }

        public static FormLayoutOverviewModel CreateDefaultModel() {
            FormLayoutOverviewModel model = new FormLayoutOverviewModel();
            model.FirstName = "Nancy";
            model.LastName = "Davolio";
            model.Note = "Education includes a BA in psychology from Colorado State University in 1970. She also completed 'The Art of the Cold Call.' Nancy is a member of Toastmasters International.";
            return model;
        }
    }

    public class FormLayoutFeaturesDemoOptions {
        public FormLayoutFeaturesDemoOptions() {
            GroupSettingsGroupBoxDecoration = GroupBoxDecoration.Box;
            GroupSettingsShowCaption = true;

            ItemCaptionSettingsShowCaption = true;
            ItemCaptionSettingsLocation = LayoutItemCaptionLocation.Left;
            ItemCaptionSettingsHorizontalAlign = FormLayoutHorizontalAlign.Left;
            ItemCaptionSettingsVerticalAlign = FormLayoutVerticalAlign.Top;

            ItemHelpTextSettingsShowHelpText = true;
        }

        public GroupBoxDecoration GroupSettingsGroupBoxDecoration { get; set; }
        public bool GroupSettingsShowCaption { get; set; }

        public bool ItemCaptionSettingsShowCaption { get; set; }
        public LayoutItemCaptionLocation ItemCaptionSettingsLocation { get; set; }
        public FormLayoutHorizontalAlign ItemCaptionSettingsHorizontalAlign { get; set; }
        public FormLayoutVerticalAlign ItemCaptionSettingsVerticalAlign { get; set; }

        public bool ItemHelpTextSettingsShowHelpText { get; set; }
        public HelpTextPosition ItemHelpTextSettingsPosition { get; set; }
        public HelpTextHorizontalAlign ItemHelpTextSettingsHorizontalAlign { get; set; }
        public HelpTextVerticalAlign ItemHelpTextSettingsVerticalAlign { get; set; }
    }
}
