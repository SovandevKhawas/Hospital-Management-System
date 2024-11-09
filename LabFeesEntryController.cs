using MainProject.Filters;
using MetaDataLibrary.LabMaster;
using MetaDataLibrary.PatientRegistration;
using MetaDataLibrary.Prescription;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using RepositoryLibrary.Common;
using RepositoryLibrary.LabFeesEntry;
using RepositoryLibrary.Patients;

namespace MainProject.Areas.OPD.Controllers
{
    [Area("OPD")]
    public class LabFeesEntryController : Controller
    {
        private readonly ICommon icommon;
        private readonly ILabFeesEntry iLabFeesEntry;
        private readonly IPatients iPatients;

        public LabFeesEntryController(ICommon icommon, ILabFeesEntry iLabFeesEntry, IPatients iPatients)
        {
            this.icommon = icommon;
            this.iLabFeesEntry = iLabFeesEntry;
            this.iPatients = iPatients;
        } // constructor...

        [Route("DisplayLabFeesEntry")]
        [Authorize(Policy = "LabFeesEntryViewPolicy")]
        public IActionResult DisplayLabFeesEntry(int pg = 1, int pageSize = 5, string SearchText = "")
        {
            ViewBag.SearchText = SearchText;
            IQueryable<MetaDataLibrary.LabFeesEntry.LabFeesEntryHead> heads;
            if (string.IsNullOrEmpty(SearchText))
            {
                heads = iLabFeesEntry.GetLabFeesEntryHeads().AsQueryable();
            }
            else
            {
                heads = iLabFeesEntry.GetLabFeesEntryHeads()
                    .Where(m => m.DocNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                    m.DocDate!.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                    m.PatientRegNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                    ).AsQueryable();
            }
            return View(icommon.GetGenericPaginationModel<MetaDataLibrary.LabFeesEntry.LabFeesEntryHead>(heads, heads.Count(), pg, pageSize));
        } // DisplayLabFeesEntry...

        [Route("DisplayLabFeesEntry")]
        [HttpPost]
        [Authorize(Policy = "LabFeesEntryViewPolicy")]
        public IActionResult DisplayLabFeesEntry(IFormCollection collection, int pg = 1, int pageSize = 5, string SearchText = "")
        {
            IQueryable<MetaDataLibrary.LabFeesEntry.LabFeesEntryHead> heads;
            if (string.IsNullOrEmpty(collection["SearchText"]))
            {
                heads = iLabFeesEntry.GetLabFeesEntryHeads().AsQueryable();
            }
            else
            {
                ViewBag.SearchText = collection["SearchText"].ToString();
                heads = iLabFeesEntry.GetLabFeesEntryHeads()
                    .Where(m => m.DocNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                    m.DocDate!.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                    m.PatientRegNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                    ).AsQueryable();
            }
            return View(icommon.GetGenericPaginationModel<MetaDataLibrary.LabFeesEntry.LabFeesEntryHead>(heads, heads.Count(), pg, pageSize));
        } // DisplayLabFeesEntry...

        [Route("AddEditLabFeesEntry")]
        [GetLabFeesEntry]
        [Authorize(Policy = "LabFeesEntryAllPolicy")]
        public ActionResult AddEditLabFeesEntry(int id)
        {
            if (id == 0)
            {
                return View(iLabFeesEntry.PopulateDetails());
            }

            var labFeesEntryHead = iLabFeesEntry.PopulateDetails(id);
            ViewBag.PatientRegNo = labFeesEntryHead.PatientRegNo;
            return View(labFeesEntryHead);
        } // AddEditLabFeesEntry...

        [Route("AddEditLabFeesEntry")]
        [GetLabFeesEntry]
        [HttpPost]
        [Authorize(Policy = "LabFeesEntryAllPolicy")]
        public async Task<IActionResult> AddEditLabFeesEntry(IFormCollection collection, int IdNo, string DocNo, string DocDate, int AcCode, string PatientRegNo,
                    string PatientType, string PatientName, int PrescriptionIdNo)
        {
            if (!string.IsNullOrEmpty(collection["Back"]))
            {
                return RedirectToAction("DisplayLabFeesEntry");
            }

            MetaDataLibrary.LabFeesEntry.LabFeesEntryHead head = null!;
            if (!string.IsNullOrEmpty(collection["Display"]))
            {
                ViewBag.PatientRegNo = PatientRegNo;

                var prescriptionModel = iLabFeesEntry.Getprescriptions().FirstOrDefault(m => m.Id == PrescriptionIdNo);
                string PrescriptionNo = prescriptionModel.PrescriptionNo!;
                List<MetaDataLibrary.LabFeesEntry.LabFeesEntryDtl> getDtls = iLabFeesEntry.GetDtlsFromSummarizedTestResults(PatientRegNo, PrescriptionNo);
                head = new MetaDataLibrary.LabFeesEntry.LabFeesEntryHead(IdNo, DocNo, DocDate, AcCode, string.Empty, PatientRegNo, PatientType, PatientName,
                        string.Empty, string.Empty, PrescriptionIdNo, string.Empty, string.Empty, getDtls);

                return View(head);
                //return RedirectToAction("AddEditLabFeesEntry", IdNo);
            } // if display button is clicked...

            List<MetaDataLibrary.LabFeesEntry.LabFeesEntryDtl> dtls = new List<MetaDataLibrary.LabFeesEntry.LabFeesEntryDtl>();
            if (collection["JsonText"].ToString() != "-1")
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                dtls = js.Deserialize<List<MetaDataLibrary.LabFeesEntry.LabFeesEntryDtl>>(collection["JsonText"].ToString());
            }

            string docNo = string.Empty;
            docNo = IdNo == 0 ? iLabFeesEntry.GenerateDocNo(HttpContext.Session.GetString("FinYear")!, PatientRegNo) : DocNo;

            head = new MetaDataLibrary.LabFeesEntry.LabFeesEntryHead(IdNo, docNo, DocDate, AcCode, string.Empty, PatientRegNo, PatientType, PatientName,
                        string.Empty, string.Empty, PrescriptionIdNo, string.Empty, string.Empty, dtls);
            await TryUpdateModelAsync(head);

            if (ModelState.IsValid)
            {
                string message = string.Empty;
                Task<string> tsk = iLabFeesEntry.SaveLabFeesEntry(head, User!.Claims.FirstOrDefault()!.Value.ToString());
                await tsk;
                message = tsk.Result;
                if (message.Contains("Success"))
                {
                    return RedirectToAction("DisplayLabFeesEntry");
                } // if success...

                ModelState.AddModelError(string.Empty, message);
                return View(head);
            } // if valid...

            return View(head);
        } // AddEditLabFeesEntry...

        [Route("GetPatientsByRegNoLabFeesEntry")]
        public JsonResult GetPatientsByRegNoLabFeesEntry(string reg_no)
        {
            PatientRegistrationMaster master = iPatients.GetAllPatients().FirstOrDefault(m => m.MainRegNo == reg_no)!;
            return Json(master);
        } // GetPatientsByRegNoLabFeesEntry...

        [Route("GetLabMasterFeesEntryLab")]
        public JsonResult GetLabMasterFeesEntryLab(int fees_id)
        {
            LabmasterModel model = iLabFeesEntry.GetLabMaster().Where(m => m.id_no == fees_id).FirstOrDefault()!;
            return Json(model);
        } // GetLabMasterFeesEntryLab...

        [Route("GenerateDocNoLabFeesEntry")]
        public string GenerateDocNoLabFeesEntry(string patient_reg_no)
        {
            return iLabFeesEntry.GenerateDocNo(HttpContext.Session.GetString("FinYear")!, patient_reg_no);
        } // GenerateDocNoLabFeesEntry...

        [Route("GetPrescriptionsByRegNoLab")]
        public JsonResult GetPrescriptionsByRegNoLab(string patient_reg_no)
        {
            List<PrescriptionModel> models = iLabFeesEntry.Getprescriptions().Where(m => m.RegNo == patient_reg_no).ToList();
            return Json(models);
        } // GetPrescriptionsByRegNoLab...

        //[Route("GetAutocompleteRegNoSB")]
        //public JsonResult GetAutocompleteRegNoSB(string search)
        //{
        //    IQueryable<string> strs = iPatients.GetAllPatients().Where(m => m.MainRegNo.Contains(search, StringComparison.OrdinalIgnoreCase))
        //        .Select(m => new string(m.MainRegNo)).AsQueryable();
        //    return Json("strs");
        //}

    } // class...
}
