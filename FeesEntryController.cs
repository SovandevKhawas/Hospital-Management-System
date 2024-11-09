using MainProject.Filters;
using MetaDataLibrary.OPDIPDFeesEntry;
using MetaDataLibrary.OpdIpdFeesMaster;
using MetaDataLibrary.PatientRegistration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using RepositoryLibrary.Common;
using RepositoryLibrary.OPDIPDFeesEntry;
using RepositoryLibrary.Patients;

namespace MainProject.Areas.OPD.Controllers
{
    [Area("OPD")]
    public class FeesEntryController : Controller
    {
        private readonly ICommon icommon;
        private readonly IOPDIPDFeesEntry iOPDIPDFeesEntry;
        private readonly IPatients iPatients;

        public FeesEntryController(ICommon icommon, IOPDIPDFeesEntry iOpdIpd, IPatients iPatients)
        {
            this.icommon = icommon;
            iOPDIPDFeesEntry = iOpdIpd;
            this.iPatients = iPatients;
        } // constructor...

        [Route("DisplayFeesEntry")]
        [Authorize(Policy = "OPDIPDFeesEntryViewPolicy")]
        public IActionResult DisplayFeesEntry(int pg = 1, int pageSize = 5, string SearchText = "")
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

        [Route("DisplayFeesEntry")]
        [Authorize(Policy = "OPDIPDFeesEntryViewPolicy")]
        [HttpPost]
        public IActionResult DisplayFeesEntry(IFormCollection collection, int pg = 1, int pageSize = 5, string SearchText = "")
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
        } // DisplayFeesEntry...

        [Route("AddEditOpdIpdFees")]
        [Authorize(Policy = "OPDIPDFeesEntryAllPolicy")]
        [GetFeesEntry]
        public ActionResult AddEditFees(int id)
        {
            if (id == 0)
            {
                return View(iOPDIPDFeesEntry.PopulateDetails());
            }

            var OPDIPDFeesEntryHead = iOPDIPDFeesEntry.PopulateDetails(id);
            return View(OPDIPDFeesEntryHead);
        } // AddEditFees...

        [Route("AddEditOpdIpdFees")]
        [GetFeesEntry]
        [Authorize(Policy = "OPDIPDFeesEntryAllPolicy")]
        [HttpPost]
        public async Task<IActionResult> AddEditFees(IFormCollection collection, int IdNo, string DocNo, string DocDate, int AcCode, string PatientRegNo,
                    string PatientType, string PatientName)
        {
            string PaymentStatus = string.Empty;
            decimal ConcessionPerc = 0.00m;

            if (!string.IsNullOrEmpty(collection["Back"]))
            {
                return RedirectToAction("DisplayFeesEntry");
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
                Task<string> tsk = iOPDIPDFeesEntry.SaveOPDIPDFeesEntry(head, User!.Claims.FirstOrDefault()!.Value.ToString());
                await tsk;
                message = tsk.Result;
                if (message.Contains("Success"))
                {
                    if (!string.IsNullOrEmpty(collection["Save And Print"]))
                    {
                        int HeadIdNo = 0;
                        HeadIdNo = Convert.ToInt32(message.Substring(8));
                        return RedirectToAction("OPDIPDFeesPrintPreview", new { id = HeadIdNo });
                    }
                    else
                    {
                        return RedirectToAction("DisplayFeesEntry");
                    } // end of inner if...
                } // if success...

                ModelState.AddModelError(string.Empty, message);
                return View(head);
            } // if valid...

            return View(head);
        } // AddEditFees...

        [Route("GetPatientsByRegNoFeesEntry")]
        public JsonResult GetPatientsByRegNoFeesEntry(string reg_no)
        {
            PatientRegistrationMaster master = iPatients.GetAllPatients().Where(m => m.MainRegNo == reg_no).FirstOrDefault()!;
            return Json(master);
        } // GetPatientsByRegNoFeesEntry...

        [Route("GetOPDIPDFeesMasterFeesEntry")]
        public JsonResult GetOPDIPDFeesMasterFeesEntry(int fees_id, string reg_no)
        {
            OpdIpdFeesModel model = iOPDIPDFeesEntry.GetOPDIPDFeesMaster().Where(m => m.Id == fees_id).FirstOrDefault()!;
            decimal concessionPercentage = iOPDIPDFeesEntry.GetPercentageOfARegistration(reg_no);
            decimal amount = 0.0m;
            decimal rate = model.Amount;

            if (concessionPercentage > 0)
            {
                amount = model.Amount - ((model.Amount * concessionPercentage) / 100);
            }
            else
            {
                amount = model.Amount;
            }

            var response = new OpdIpdFeesModel(model.Id,
                     model.ChargeTypeId,
                      model.ChargeTypeName,
                      model.FeesName,
                      model.AcCode,
                      model.AcName,
                      amount,
                      model.DeptId, model.FeeType,
                      rate,
                      concessionPercentage);

            return Json(response);
        } // GetOPDIPDFeesMasterFeesEntry...

        [Route("GenerateDocNoFeesEntry")]
        public string GenerateDocNoFeesEntry(string patient_reg_no)
        {
            return iOPDIPDFeesEntry.GenerateDocNo(HttpContext.Session.GetString("FinYear")!, patient_reg_no);
        } // GenerateDocNo...
    } // class...
}
