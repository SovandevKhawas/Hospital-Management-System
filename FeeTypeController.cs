using MetaDataLibrary.FeeType;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryLibrary.Common;
using RepositoryLibrary.FeeType;

namespace MainProject.Areas.OPD.Controllers
{
    [Area("OPD")]
    public class FeeTypeController : Controller
    {
        readonly ICommon icommon;
        readonly IFeeType ifeetype;
        public FeeTypeController(ICommon icommon, IFeeType ifeetype)
        {
            this.icommon = icommon;
            this.ifeetype = ifeetype;
        } // constructor...

        [Route("DisplayFeeType")]
        [Authorize(Policy = "FeeTypeViewPolicy")]
        public ActionResult DisplayFeeType(int pg = 1, int pageSize = 5, string SearchText = "")
        {
            ViewBag.SearchText = SearchText;
            IQueryable<MetaDataLibrary.FeeType.FeeTypeViewModel> heads;
            if (string.IsNullOrEmpty(SearchText))
            {
                heads = ifeetype.GetFeeTypes().AsQueryable();
            }
            else
            {
                heads = ifeetype.GetFeeTypes().Where(m => m.FeeTypeName!.Contains(SearchText)).AsQueryable();
            }
            return View(icommon.GetGenericPaginationModel<MetaDataLibrary.FeeType.FeeTypeViewModel>
                        (heads, heads.Count(), pg, pageSize));
        }//DisplayFeeType...

        [Route("DisplayFeeType")]
        [HttpPost]
        [Authorize(Policy = "FeeTypeViewPolicy")]
        public ActionResult DisplayFeeType(IFormCollection collection, int pg = 1, int pageSize = 5, string SearchText = "")
        {
            IQueryable<MetaDataLibrary.FeeType.FeeTypeViewModel> heads;
            if (string.IsNullOrEmpty(collection["SearchText"]))
            {
                heads = ifeetype.GetFeeTypes().AsQueryable();
            }
            else
            {
                heads = heads = ifeetype.GetFeeTypes().Where(m => m.FeeTypeName!.Contains(SearchText)).AsQueryable();
            }
            return View(icommon.GetGenericPaginationModel<MetaDataLibrary.FeeType.FeeTypeViewModel>
                (heads, heads.Count(), pg, pageSize));
        }//DisplayFeeType...

        [Route("AddEditFeeType")]
        [Authorize(Policy = "FeeTypeAllPolicy")]
        public IActionResult AddEditFeeType(int id)
        {
            FeeTypeViewModel model = new FeeTypeViewModel();
            if (id == 0)
            {
                model.FeeTypeId = 0;
            }
            else
            {
                model = ((IQueryable<FeeTypeViewModel>)ifeetype.GetFeeTypes()).Where(m => m.FeeTypeId == id).FirstOrDefault()!;
            }
            return View(model);
        }//AddEditFeeType....

        [Route("AddEditFeeType")]
        [HttpPost]
        [Authorize(Policy = "FeeTypeAllPolicy")]
        public async Task<IActionResult> AddEditFeeType(IFormCollection collection)
        {
            if (!string.IsNullOrEmpty(collection["Back To List"]))
            {
                return RedirectToAction("DisplayFeeType");
            } // for back button...

            FeeTypeViewModel model = new FeeTypeViewModel();
            await TryUpdateModelAsync(model);
            if (ModelState.IsValid)
            {
                bool b = ifeetype.CheckDuplicateFeeType(model);
                if (b == (1 == 2))
                {
                    ModelState.AddModelError(string.Empty, "Duplicate Ward Name found - " + model.FeeTypeName + "!!");
                    return View(model);
                } // if duplicate ward exists...

                Task<string> tsk = ifeetype.SaveFeeTypes(model);
                string message = tsk.Result;
                if (message == "Success")
                {
                    return RedirectToAction("DisplayFeeType");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, message);
                    return View(model);
                }
            } // if valid...

            ViewBag.Mode = "New";
            return View(model);
        }//AddEditFeeType...
    } // class...
}
