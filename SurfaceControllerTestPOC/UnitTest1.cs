using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Umbraco.Web;

namespace SurfaceControllerTestPOC
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MockRepository mockRepository = new MockRepository(MockBehavior.Strict);
            UmbracoContext umbracoContext = UmbracoContextHelper.CreateContext(mockRepository, new Uri("http://somesite.com/home.aspx"));

            DemoSurfaceController controller = new DemoSurfaceController(umbracoContext);
            PartialViewResult actionResult = controller.SomeAction();

            Assert.AreEqual("SomeView", actionResult.ViewName);
        }
    }
}
