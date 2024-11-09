using MetaDataLibrary.OpdIpdFeesMaster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryLibrary.Common;
using RepositoryLibrary.OpdIpdFeesMaster;

namespace MainProject.Areas.OPD.Controllers
{
    [Area("OPD")]
    public class OpdIpdFeesMasterController : Controller
    {
        private readonly ICommon _ic;
        private readonly IOpdIpdFeesMaster _Iopf;

        public OpdIpdFeesMasterController(IOpdIpdFeesMaster ipof, ICommon ic)
        {
            _Iopf = ipof;
            _ic = ic;
        }

        [Route("DisplayOpdIpdFees")]
        [Authorize(Policy = "OPDIPDFeesMasterViewPolicy")]
        public ActionResult DisplayOpdIpdFees(int pg = 1, int pageSize = 5, string SearchText = "")
        {
            ViewBag.SearchText = SearchText;
            IQueryable<OpdIpdFeesModel> heads;
            if (string.IsNullOrEmpty(SearchText))
            {
                heads = _Iopf.DisplayValue().AsQueryable();
            }
            else
            {
                heads = _Iopf.DisplayValue()
                    .Where(m => m.FeesName!.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                    m.AcName!.Contains(SearchText, StringComparison.OrdinalIgnoreCase)).AsQueryable();
            }
            return View(_ic.GetGenericPaginationModel<OpdIpdFeesModel>(heads.AsQueryable(), heads.Count(), pg, pageSize));
        } // DisplayOpdIpdFees...

        [Route("DisplayOpdIpdFees")]
        [Authorize(Policy = "OPDIPDFeesMasterViewPolicy")]
        [HttpPost]
        public ActionResult DisplayOpdIpdFees(IFormCollection collection, int pg = 1, int pageSize = 5, string SearchText = "")
        {
            IQueryable<OpdIpdFeesModel> heads;
            if (string.IsNullOrEmpty(collection["SearchText"]))
            {
                heads = _Iopf.DisplayValue().AsQueryable();
            }
            else
            {
                ViewBag.SearchText = collection["SearchText"].ToString();
                heads = _Iopf.DisplayValue().Where(m => m.FeesName!.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                m.AcName!.Contains(SearchText, StringComparison.OrdinalIgnoreCase)).AsQueryable();
            }
            return View(_ic.GetGenericPaginationModel<OpdIpdFeesModel>(heads.AsQueryable(), heads.Count(), pg, pageSize));
        } // DisplayOpdIpdFees...

        [Route("AddEditOpdIpdFeesMaster")]
        [Authorize(Policy = "OPDIPDFeesMasterAllPolicy")]
        [Filters.GetLedgerforIpdOpdFeesMaster]
        public IActionResult AddEditOpdIpdFeesMaster(int? Id)
        {
            Id ??= 0;
            OpdIpdFeesModel _opdipdfees = new OpdIpdFeesModel(0, null, string.Empty, string.Empty, 0, string.Empty, 0.00m, 0, string.Empty, 0, 0);
            var editModel = (Id == 0) ? _opdipdfees : _Iopf.GetOpdIpdFeesById((int)Id);
            return View(editModel);
        } // OpdIpdFeesMaster..

        [Route("AddEditOpdIpdFeesMaster")]
        [Authorize(Policy = "OPDIPDFeesMasterAllPolicy")]
        [Filters.GetLedgerforIpdOpdFeesMaster]
        [HttpPost]
        public IActionResult AddEditOpdIpdFeesMaster(IFormCollection collection,
                                                     int id,
                                                     int? chargeTypeId,
                                                     string? chargeTypeName,
                                                     string feesName,
                                                     int acCode,
                                                     string? acName,
                                                     decimal amount,
                                                     int? deptId,
                                                     string? feeType)
        {
            if (!string.IsNullOrEmpty(collection["Back"]))
            {
                return RedirectToAction("DisplayOpdIpdFees");
            }
            OpdIpdFeesModel feesModel = new(id, chargeTypeId, string.Empty, feesName, acCode, acName, amount, deptId, feeType!,0,0);

            if (feeType is null)
            {
                ModelState.AddModelError("", "Fees Type Can't be blank");
                return View(feesModel);
            }

            string msg;
            string message = this.Validate(feesModel);
            if (string.IsNullOrEmpty(message))
            {
                msg = _Iopf.SaveOpdIpdFees(feesModel);
                if (msg == "Insert" || msg == "Update")
                {
                    return RedirectToAction("DisplayOpdIpdFees");
                }
            }
            ViewBag.CheckMessage = message;
            return View(feesModel);
        }//OpdIpdFeesMaster...

        string Validate(OpdIpdFeesModel OpdIpd)
        {
            string message = string.Empty;
            bool isDuplicate = _Iopf.CheckDuplicateFeesName(OpdIpd);
            if (isDuplicate)
            {
                message = "Duplicate Record Found";
            }
            return message;
        } // Validate...
    }//OpdIpdFeesMasterController....
}
