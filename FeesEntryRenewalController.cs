using MainProject.Filters;
using MetaDataLibrary.OPDIPDFeesEntry;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using RepositoryLibrary.Common;
using RepositoryLibrary.OPDIPDFeesEntryRenewal;
using RepositoryLibrary.Patients;

namespace MainProject.Areas.OPD.Controllers
{
    [Area("OPD")]

    public class FeesEntryRenewalController : Controller
    {
        private readonly ICommon icommon;
        private readonly IOPDIPDFeesEntryRenewal iOPDIPDFeesEntry;
        private readonly IPatients iPatients;

        public FeesEntryRenewalController(ICommon icommon, IOPDIPDFeesEntryRenewal iOpdIpd, IPatients iPatients)
        {
            this.icommon = icommon;
            iOPDIPDFeesEntry = iOpdIpd;
            this.iPatients = iPatients;
        } // constructor...

        [Route("DisplayFeesEntryRenewal")]
        [Authorize(Policy = "OPDIPDFeesEntryRenewalViewPolicy")]
        public IActionResult DisplayFeesEntryRenewal(int pg = 1, int pageSize = 5, string SearchText = "")
        {
            ViewBag.SearchText = SearchText;
            IQueryable<OPDIPDFeesEntryHead> heads;
            if (string.IsNullOrEmpty(SearchText))
            {
                heads = iOPDIPDFeesEntry.GetOPDIPDFeesEntryHeads().AsQueryable();
            }
            else
            {
                heads = iOPDIPDFeesEntry.GetOPDIPDFeesEntryHeads()
                    .Where(m => m.DocNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                    m.DocDate!.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                    m.PatientRegNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                    ).AsQueryable();
            }
            return View(icommon.GetGenericPaginationModel<OPDIPDFeesEntryHead>(heads, heads.Count(), pg, pageSize));
        } // DisplayFeesEntry...

        [Route("DisplayFeesEntryRenewal")]
        [Authorize(Policy = "OPDIPDFeesEntryRenewalViewPolicy")]
        [HttpPost]
        public IActionResult DisplayFeesEntryRenewal(IFormCollection collection, int pg = 1, int pageSize = 5, string SearchText = "")
        {
            IQueryable<OPDIPDFeesEntryHead> heads;
            if (string.IsNullOrEmpty(collection["SearchText"]))
            {
                heads = iOPDIPDFeesEntry.GetOPDIPDFeesEntryHeads().AsQueryable();
            }
            else
            {
                ViewBag.SearchText = collection["SearchText"].ToString();
                heads = iOPDIPDFeesEntry.GetOPDIPDFeesEntryHeads()
                    .Where(m => m.DocNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                    m.DocDate!.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                    m.PatientRegNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                    ).AsQueryable();
            }
            return View(icommon.GetGenericPaginationModel<OPDIPDFeesEntryHead>(heads, heads.Count(), pg, pageSize));
        } // DisplayFeesEntryRenewal...

        [Route("AddEditRenewalFees")]
        [Authorize(Policy = "OPDIPDFeesEntryRenewalAllPolicy")]
        [GetFeesEntry]
        public ActionResult AddEditRenewalFees(int id)
        {
            if (id == 0)
            {
                return View(iOPDIPDFeesEntry.PopulateDetails());
            }

            var OPDIPDFeesEntryHead = iOPDIPDFeesEntry.PopulateDetails(id);
            return View(OPDIPDFeesEntryHead);
        } // AddEditRenewalFees...

        [Route("AddEditRenewalFees")]
        [GetFeesEntry]
        [Authorize(Policy = "OPDIPDFeesEntryRenewalAllPolicy")]
        [HttpPost]
        public async Task<IActionResult> AddEditRenewalFees(IFormCollection collection, int IdNo, string DocNo, string DocDate, int AcCode, string PatientRegNo,
                    string PatientType, string PatientName)
        {
            string PaymentStatus = string.Empty;
            decimal ConcessionPerc = 0.00m;

            if (!string.IsNullOrEmpty(collection["Back"]))
            {
                return RedirectToAction("DisplayFeesEntryRenewal");
            }

            List<OPDIPDFeesEntryDtl> dtls = new List<OPDIPDFeesEntryDtl>();
            if (collection["JsonText"].ToString() != "-1")
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                dtls = js.Deserialize<List<OPDIPDFeesEntryDtl>>(collection["JsonText"].ToString());
            }

            ConcessionPerc = Convert.ToDecimal(collection["ConcessionPerc"]);
            PaymentStatus = Convert.ToDecimal(collection["ConcessionPerc"]) == 100 ? "Free" : "UnPaid";

            string docNo = string.Empty;
            docNo = IdNo == 0 ? iOPDIPDFeesEntry.GenerateDocNo(HttpContext.Session.GetString("FinYear")!, PatientRegNo) : DocNo;

            OPDIPDFeesEntryHead head = new OPDIPDFeesEntryHead(IdNo, docNo, DocDate, AcCode, string.Empty, PatientRegNo, PatientType,
                        PatientName, PaymentStatus, ConcessionPerc, string.Empty, string.Empty, dtls);
            await TryUpdateModelAsync(head);

            if (ModelState.IsValid)
            {
                if (dtls.Count > 1)
                {
                    ModelState.AddModelError(string.Empty, "Multiple fees entry not allowed!!");
                    return View(head);
                }

                string message = string.Empty;
                Task<string> tsk = iOPDIPDFeesEntry.SaveOPDIPDFeesEntryRenewal(head, User!.Claims.FirstOrDefault()!.Value.ToString());
                await tsk;
                message = tsk.Result;
                if (message.Contains("Success"))
                {
                    return RedirectToAction("DisplayFeesEntryRenewal");
                } // if success...

                ModelState.AddModelError(string.Empty, message);
                return View(head);
            } // if valid...

            return View(head);
        } // AddEditRenewalFees...

        [Route("GetOPDFeesEntryDtlByDeptIdFeeType")]
        public JsonResult GetOPDFeesEntryDtlByDeptIdFeeType(int deptId)
        {
            var result = iOPDIPDFeesEntry.GetDtlByDeptIdFeeType(deptId, "Subsequent");
            return Json(result);
        } // GetOPDFeesEntryDtlByDeptIdFeeType...
    } // class...
}
