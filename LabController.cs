using MetaDataLibrary.Prescription;
using MetaDataLibrary.TestResult;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryLibrary.Common;
using RepositoryLibrary.Prescription;
using RepositoryLibrary.TestResult;

namespace MainProject.Areas.OPD.Controllers;

[Area("OPD")]
public class LabController : Controller
{
    private readonly IPrescription _prescription;
    private readonly ITestResult _test;
    private readonly ICommon _common;

    public LabController(IPrescription prescription, ITestResult test, ICommon common)
    {
        _prescription = prescription;
        _test = test;
        _common = common;
    }

    [Route("Prescription")]
    [Authorize(Policy = "labAndPrescriptionAllPolicy")]
    public IActionResult DisplayPrescription(int pg = 1, int pageSize = 5, string SearchText = "")
    {
        ViewBag.SearchText = SearchText;
        var heads = _prescription.GetAllPrescription().AsQueryable();

        return View(_common.GetGenericPaginationModel<PrescriptionModel>(heads, heads.Count(), pg, pageSize));
    }

    [HttpPost, Route("Prescription")]
    [Authorize(Policy = "labAndPrescriptionAllPolicy")]
    public IActionResult DisplayPrescription(IFormCollection collection, int pg = 1, int pageSize = 5, string SearchText = "")
    {
        IQueryable<PrescriptionModel> heads;
        if (string.IsNullOrEmpty(collection["SearchText"]))
        {
            heads = _prescription.GetAllPrescription().AsQueryable();
        }
        else
        {
            ViewBag.SearchText = collection["SearchText"].ToString();
            heads = _prescription.GetAllPrescription()
                .Where(m => m.RegNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                    || m.PatientName!.Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                    || m.PrescriptionNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase))
                .AsQueryable();
        }

        return View(_common.GetGenericPaginationModel<PrescriptionModel>(heads, heads.Count(), pg, pageSize));
    }

    [Route("PrescriptionDetails")]
    [Authorize(Policy = "labAndPrescriptionAllPolicy")]
    public IActionResult PrescriptionDetails(int ID)
    {
        var testPrescriptionDetails = _prescription.GetPrescriptionForTestAction(ID);
        var totalAmount = 0m;
        foreach (var labmodel in testPrescriptionDetails.LabmasterModels!)
        {
            totalAmount += labmodel.Amount;
        }
        ViewBag.TotalAmount = totalAmount;
        return View(testPrescriptionDetails);
    }

    [Route("DisplayPDF")]
    public IActionResult DisplayPDF(int ID) => View(_prescription.GetPrescriptionForTestAction(ID));


    //-----------------------------------------------------------------------------//

    [Route("GetTestDetails")]
    [Authorize(Policy = "labAndPrescriptionTestDetailsAllPolicy")]
    public IActionResult GetTestDetails(int Id,
                                        int TestId,
                                        int DocId,
                                        string RegNo,
                                        string PresNo)
    {
        ViewBag.Id = Id;
        var model = new TestResultModel()
        {
            UserName = HttpContext.User.Claims.FirstOrDefault()!.Value,
            RegNo = RegNo,
            PrescriptionNo = PresNo,
            TestId = TestId,
            DoctorId = DocId
        };

        int id = _test.DoubleCheck(model);

        if (id > 0)
        {
            var testModel = _test.GetTestResultById(id);
            return View(testModel);
        }
        else
        {
            //string? message = _test.SaveTestData(model);
            //if (message != "Success")
            //{
            //    return RedirectToAction("PrescriptionDetails", new { ID = Id });
            //}
            //return View(model);
            return RedirectToAction("PrescriptionDetails", new { ID = Id });
        }
    } // GetTestDetails...

    [HttpPost, Route("GetTestDetails")]
    [Authorize(Policy = "labAndPrescriptionTestDetailsAllPolicy")]
    public IActionResult GetTestDetails(TestResultModel model, IFormCollection collection)
    {
        model.UserName = HttpContext.User.Claims.FirstOrDefault()!.Value;
        if(!string.IsNullOrEmpty(collection["BackBtn"]))
        {
            return RedirectToAction("PrescriptionDetails", new { ID = model.PrescriptionID });
        }
        if(!string.IsNullOrEmpty(collection["SubmitBtn"]))
        {
            if (model.SampleDate == null || model.DeliveryDate == null)
            {
                model.Status = "Pending";
            }
            else
            {
                model.Status = "Complete";
            }
        }
        string result = _test.UpdateTestData(model);
        if (result != "Success")
        {
            ModelState.AddModelError("", result);
            return View(model);
        }
        return RedirectToAction("PrescriptionDetails", new { ID = model.PrescriptionID });
    }

    [Route("DisplayTestResult")]
    public IActionResult DisplayTestResult()
    {
        var modelList = new List<TestResultModel>();
        return View(modelList);
    }

    [HttpPost, Route("DisplayTestResult")]
    public IActionResult DisplayTestResult(string RegNo)
    {
        var modelList = _test.GetTestResult().Where(x => x.RegNo == RegNo);
        return View(modelList);
    }

    [Route("TestInstructionPrint")]
    public IActionResult TestInstructionPrint(int ID)
    {
        var model = _test.GetTestResult()
            .FirstOrDefault(x => x.Id == ID);
        return View(model);
    }

    [Route("GetMedicineDetails")]
    [Authorize(Policy = "labAndPrescriptionMedicalDetailsAllPolicy")]
    public IActionResult GetMedicineDetails(int Id,
                                            int DocId,
                                            string RegNo,
                                            string PresNo,
                                            string? prescribeMedicine)
    {
        ViewBag.Id = Id;
        //var advices = new List<MedicineAdviceModel>();

        var model = new MedicineModel()
        {
            RegNo = RegNo,
            PrescriptionNo = PresNo,
            DoctorId = DocId,
            PrescribedMedicine = prescribeMedicine,
            UserName = HttpContext.User.Claims.FirstOrDefault()!.Value
        };

        int id = _prescription.GetDoctorPrescriptionHeadIdByRegNoPrescriptionNo(RegNo, PresNo);
        var advices = _prescription.GetMedicineAdviceList(id);
        model.medicineAdviceModel = advices;

        var i = _test.MedicineDublicateCheck(model);
        if (i > 0)
        {
            var medmodel = _test.GetMedicineDataById(i);
            medmodel.medicineAdviceModel = advices;
            return View(medmodel);
        }
        else
        {
            string? message = _test.GetMedicineData(model);
            if (message != "Success")
            {
                return RedirectToAction("PrescriptionDetails", new { ID = Id });
            }
            return View(model);
        }
    } // GetMedicineDetails...

    [HttpPost, Route("GetMedicineDetails")]
    [Authorize(Policy = "labAndPrescriptionMedicalDetailsAllPolicy")]
    public IActionResult GetMedicineDetails(MedicineModel model)
    {
        model.UserName = HttpContext.User.Claims.FirstOrDefault()!.Value;
        var result = _test.SaveMedicineData(model);
        if (result != "Success")
        {
            var advices = new List<MedicineAdviceModel>();
            int id = _prescription.GetDoctorPrescriptionHeadIdByRegNoPrescriptionNo(model.RegNo!, model.PrescriptionNo!);
            advices = _prescription.GetMedicineAdviceList(id);
            model.medicineAdviceModel = advices;

            return View(model);
        }
        return RedirectToAction("PrescriptionDetails", new { ID = model.PrescriptionID });
    } // GetMedicineDetails...

    [Route("GetTestDetailsByPrescriptionId")]
    public IActionResult GetTestDetailsByPrescriptionId(int Id, string RegNo, string PresNo)
    {
        ViewBag.Id = Id;
        ViewBag.RegNo = RegNo;
        ViewBag.PresNo = PresNo;
        var modelList = _test.GetTestResult()
           .Where(x => x.RegNo == RegNo && x.PrescriptionNo == PresNo).ToList();

        if (!modelList.Any())
        {
            return RedirectToAction("PrescriptionDetails", new { ID = Id });
        }

        ViewBag.SampleDate = modelList.FirstOrDefault().SampleDate;
        ViewBag.DeliveryDate = modelList.FirstOrDefault().DeliveryDate;

        return View();
    }

    [Route("GetTestDetailsByPrescriptionId")]
    [HttpPost]
    public IActionResult GetTestDetailsByPrescriptionId(IFormCollection key)
    {
        var ID = Convert.ToInt32(key["ID"]);
        var RegNo = key["RegNo"];
        var PresNo = key["PresNo"];
        ViewBag.Id = ID;
        ViewBag.RegNo = RegNo;
        ViewBag.PresNo = PresNo;

        var SampleDate = key["sampleDate"].ToString();
        var DeliveryDate = key["deliveryDate"].ToString();

        ViewBag.SampleDate = SampleDate;
        ViewBag.DeliveryDate = DeliveryDate;

        if (string.IsNullOrEmpty(SampleDate))
        {
            ModelState.AddModelError("", "Please select sample date");
        }

        if (!ModelState.IsValid)
        {
            return View();
        }

        var response = _test.UpdateTestDetailsByPrescriptionId(ID, RegNo, PresNo, SampleDate, DeliveryDate);

        return response == "Success" ? RedirectToAction("PrescriptionDetails", new { ID = ID }) : View();
    }


}