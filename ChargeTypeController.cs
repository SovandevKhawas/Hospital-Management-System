using MetaDataLibrary.ChargeType;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryLibrary.Common;
using RepositoryLibrary.ChargeType;

namespace MainProject.Areas.OPD.Controllers
{
    [Area("OPD")]
    public class ChargeTypeController : Controller
    {
        readonly ICommon icommon;
        readonly IChargeType iChargetype;
        public ChargeTypeController(ICommon icommon, IChargeType iChargetype)
        {
            this.icommon = icommon;
            this.iChargetype = iChargetype;
        } // constructor...

        [Route("DisplayChargeType")]
        [Authorize(Policy = "ChargeTypeViewPolicy")]
        public ActionResult DisplayChargeType(int pg = 1, int pageSize = 5, string SearchText = "")
        {
            ViewBag.SearchText = SearchText;
            IQueryable<ChargeTypeViewModel> heads;
            if (string.IsNullOrEmpty(SearchText))
            {
                heads = iChargetype.GetChargeTypes().AsQueryable();
            }
            else
            {
                heads = iChargetype.GetChargeTypes().Where(m => m.ChargeTypeName!.Contains(SearchText)).AsQueryable();
            }
            return View(icommon.GetGenericPaginationModel
                        (heads, heads.Count(), pg, pageSize));
        }//DisplayChargeType...

        [Route("DisplayChargeType")]
        [HttpPost]
        [Authorize(Policy = "ChargeTypeViewPolicy")]
        public ActionResult DisplayChargeType(IFormCollection collection, int pg = 1, int pageSize = 5, string SearchText = "")
        {
            IQueryable<ChargeTypeViewModel> heads;
            if (string.IsNullOrEmpty(collection["SearchText"]))
            {
                heads = iChargetype.GetChargeTypes().AsQueryable();
            }
            else
            {
                heads = heads = iChargetype.GetChargeTypes().Where(m => m.ChargeTypeName!.Contains(SearchText)).AsQueryable();
            }
            return View(icommon.GetGenericPaginationModel
                (heads, heads.Count(), pg, pageSize));
        }//DisplayChargeType...

        [Route("AddEditChargeType")]
        [Authorize(Policy = "ChargeTypeAllPolicy")]
        public IActionResult AddEditChargeType(int id)
        {
            ChargeTypeViewModel model = new ChargeTypeViewModel();
            if (id == 0)
            {
                model.ChargeTypeId = 0;
            }
            else
            {
                model = iChargetype.GetChargeTypes().Where(m => m.ChargeTypeId == id).FirstOrDefault()!;
            }
            return View(model);
        }//AddEditChargeType....

        [Route("AddEditChargeType")]
        [HttpPost]
        [Authorize(Policy = "ChargeTypeAllPolicy")]
        public async Task<IActionResult> AddEditChargeType(IFormCollection collection)
        {
            if (!string.IsNullOrEmpty(collection["Back To List"]))
            {
                return RedirectToAction("DisplayChargeType");
            } // for back button...

            ChargeTypeViewModel model = new ChargeTypeViewModel();
            await TryUpdateModelAsync(model);
            if (ModelState.IsValid)
            {
                bool b = iChargetype.CheckDuplicateChargeType(model);
                if (b == (1 == 2))
                {
                    ModelState.AddModelError(string.Empty, "Duplicate Charge Type found - " + model.ChargeTypeName + "!!");
                    return View(model);
                } // if duplicate ward exists...

                Task<string> tsk = iChargetype.SaveChargeTypes(model);
                string message = tsk.Result;
                if (message == "Success")
                {
                    return RedirectToAction("DisplayChargeType");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, message);
                    return View(model);
                }
            } // if valid...

            ViewBag.Mode = "New";
            return View(model);
        } //AddEditChargeType...
    } // class...
}
