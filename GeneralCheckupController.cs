using MetaDataLibrary.GeneralCheckup;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nancy.Json;
using RepositoryLibrary.Common;
using RepositoryLibrary.GeneralCheckup;
using RepositoryLibrary.Prescription;

namespace MainProject.Areas.OPD.Controllers;
[Area("OPD")]
public class GeneralCheckupController : Controller
{
    private readonly IGeneralCheckup _checkup;
    private readonly ICommon icommon;
    private readonly IPrescription prescription;

    public GeneralCheckupController(IGeneralCheckup checkup, ICommon icommon, IPrescription prescription)
    {
        _checkup = checkup;
        this.icommon = icommon;
        this.prescription = prescription;
    }

    [HttpGet, Route("DisplayGC")]
    [Authorize(Policy = "GeneralCheckUpViewPolicy")]
    public IActionResult DisplayCheckup(int pg = 1, int pageSize = 5, string SearchText = "")
    {
        ViewBag.SearchText = SearchText;
        IQueryable<GeneralCheckupModel> heads;
        if (string.IsNullOrEmpty(SearchText))
        {
            heads = _checkup.GetAllGeneralCheckup().AsQueryable();
        }
        else
        {
            heads = _checkup.GetAllGeneralCheckup()
                .Where(m => m.RegNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase)).AsQueryable();
        }
        return View(icommon.GetGenericPaginationModel<GeneralCheckupModel>(heads, heads.Count(), pg, pageSize));
    } // DisplayCheckup...

    [HttpPost, Route("DisplayGC")]
    [Authorize(Policy = "GeneralCheckUpViewPolicy")]
    public ActionResult DisplayCheckup(IFormCollection collection, int pg = 1, int pageSize = 5, string SearchText = "")
    {
        IQueryable<GeneralCheckupModel> heads;
        if (string.IsNullOrEmpty(collection["SearchText"]))
        {
            heads = _checkup.GetAllGeneralCheckup().AsQueryable();
        }
        else
        {
            ViewBag.SearchText = collection["SearchText"].ToString();
            heads = _checkup.GetAllGeneralCheckup()
                .Where(m => m.RegNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase))
                .AsQueryable();
        }
        return View(icommon.GetGenericPaginationModel<GeneralCheckupModel>(heads, heads.Count(), pg, pageSize));
    } // DisplayRegistrationPatient...

    [HttpGet, Route("CheckupMaster")]
    [Authorize(Policy = "GeneralCheckUpAllPolicy")]
    public IActionResult CheckupMaster(int? Id)
    {
        ViewBag.DocMaster = DoctorMastersSelectList();
        ViewBag.UnitMaster = DoctorUnitsSelectList();
        Id ??= 0;
        GeneralCheckupModel model = new GeneralCheckupModel();
        model.CheckupDate = string.Format(DateTime.Now.ToString("dd/MM/yyyy"), "{0:d}", new System.Globalization.CultureInfo("en-GB"));
        var generalCheckup = (Id != 0) ? _checkup.GetGeneralCheckupById((int)Id) : model;
        var PatientDetails = prescription.PatientDetails(generalCheckup.RegNo);
        generalCheckup.registration = PatientDetails.registration;
        return View(generalCheckup);
    }//CheckupMaster...

    [HttpPost, Route("CheckupMaster")]
    [Authorize(Policy = "GeneralCheckUpAllPolicy")]
    public IActionResult CheckupMaster(GeneralCheckupModel checkup, IFormCollection collection)
    {
        ViewBag.DocMaster = DoctorMastersSelectList();
        ViewBag.UnitMaster = DoctorUnitsSelectList();
        checkup.UserName = HttpContext.User.Claims.FirstOrDefault()!.Value;
        string message;
        if (ModelState.IsValid)
        {
            AntenatalCheckUp antenatalCheckUp;
            JavaScriptSerializer js = new JavaScriptSerializer();
            antenatalCheckUp = js.Deserialize<AntenatalCheckUp>(collection["JsonText"].ToString());
            if (antenatalCheckUp == null)
            {
                antenatalCheckUp = new AntenatalCheckUp();
            }
            checkup.antenatalCheckUp = antenatalCheckUp;

            GynoCheckUp gynoCheckUp;
            JavaScriptSerializer jsG = new JavaScriptSerializer();
            gynoCheckUp = jsG.Deserialize<GynoCheckUp>(collection["JsonTextGyno"].ToString());
            if (gynoCheckUp == null)
            {
                gynoCheckUp = new GynoCheckUp();
            }
            checkup.gynoCheckUp = gynoCheckUp;

            message = _checkup.AddEditGeneralCheckup(checkup);
            if (message == "Success")
            {
                return RedirectToAction("DisplayCheckup");
            }
            else
            {
                ModelState.AddModelError(string.Empty, message);
                return View(checkup);
            }
        }
        else
        {
            var messagetext = string.Join(" | ", ModelState.Values
        .SelectMany(v => v.Errors)
        .Select(e => e.ErrorMessage));
        }
        //Response.WriteAsync("--------------------\r\n");
        //Response.WriteAsync(checkup.antenatalCheckUp.Allergy + "   " + checkup.antenatalCheckUp.GraviraExistsNotexists);
        return View(checkup);
    } // CheckupMaster...

    [HttpPost, Route("GetRegNo")]
    public JsonResult GetRegNo(string search)
    {
        IQueryable<string> regList = _checkup.GetRegistrationNo()
            .Where(m => m.Contains(search, StringComparison.OrdinalIgnoreCase));
        return Json(regList);
    }//GetRegNo...

    [HttpPost, Route("GetPatientDetailsByRegNo")]
    public JsonResult GetPatientDetailsByRegNo(string Regno)
    {
        var PatientDetails = prescription.PatientDetails(Regno);
        var registerModel = PatientDetails.registration;
        return Json(registerModel);
    }//GetPatientDetailsByRegNo...
    public List<SelectListItem> DoctorMastersSelectList()
    {
        var responce = _checkup.DoctorMastersList();
        var items = new List<SelectListItem>();
        foreach (var item in responce)
        {
            items.Add(new SelectListItem()
            {
                Text = item.DoctorName,
                Value = item.DoctorId.ToString()
            });
        }
        return items;
    }//DoctorMastersSelectList...
    public List<SelectListItem> DoctorUnitsSelectList()
    {
        var responce = _checkup.DoctorUnitslist();
        var items = new List<SelectListItem>();
        foreach (var item in responce)
        {
            items.Add(new SelectListItem()
            {
                Text = item.DoctorUnitName,
                Value = item.DoctorUnitId.ToString()
            });
        }
        return items;
    }//DoctorUnitsSelectList...
    public string CalculateAgeForPatientReg(string Dob)
    {
        DateTime dateTime = DateTime.ParseExact(Dob, "dd/MM/yyyy", null);
        string dob = icommon.CalculateAge(dateTime);
        return dob;
    }//CalculateAgeForPatientReg...
}
