using MetaDataLibrary.CommonTestMaster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryLibrary.CommonTestMaster;

namespace MainProject.Areas.OPD.Controllers
{
    [Authorize, Area("OPD")]
    public class CommonTestMasterController : Controller
    {
        private readonly ICommonTest _commonTest;

        public CommonTestMasterController(ICommonTest commonTest) => _commonTest = commonTest;

        [Route("DisplayCommonTest")]
        public IActionResult DisplayCommonTest()
        {
            var modelList = _commonTest.GetCommonTests();
            return View(modelList);
        }

        [Route("CommonTestMaster")]
        [Filters.CommonTestTypeFilter]
        public IActionResult CommonTestMaster(int Id)
        {
            var model = _commonTest.GetCommonTest(Id);
            return View(model);
        }

        [HttpPost]
        [Route("CommonTestMaster")]
        [Filters.CommonTestTypeFilter]
        public IActionResult CommonTestMaster(CommonTestModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            string msg = _commonTest.SaveCommonTest(model);
            if (msg == "Success")
            {
                return RedirectToAction("DisplayCommonTest");
            }
            ModelState.AddModelError(string.Empty, msg);
            return View(model);
        }
    }
}
