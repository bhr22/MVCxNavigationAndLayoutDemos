using DevExpress.DemoData.Helpers;
using System.Configuration;

namespace DevExpress.Web.Demos.Models {
    public class NorthwindDataContextExt : NorthwindDataContext {
        static string ConnectionString {
            get {
                string sqlExpressString = ConfigurationManager.ConnectionStrings["NWindConnectionString"].ConnectionString;
                return DbEngineDetector.PatchConnectionString(sqlExpressString);
            }
        }
        public NorthwindDataContextExt() : base(ConnectionString) { }
    }    
}
