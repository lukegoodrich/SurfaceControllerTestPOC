using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace SurfaceControllerTestPOC
{
    public class DemoSurfaceController : SurfaceController
    {
        public DemoSurfaceController(UmbracoContext umbracoContext)
            : base(umbracoContext)
        {
        }

        public PartialViewResult SomeAction()
        {
            return this.PartialView("SomeView");
        }
    } 
}
