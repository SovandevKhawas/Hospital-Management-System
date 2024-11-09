using MetaDataLibrary.DoctorCheckUpReport;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryLibrary.DoctorCheckUpReport;

namespace MainProject.Areas.OPD.Controllers;
[Area("OPD")]

public class DoctorCheckUpReportController : Controller
{
    private readonly IDoctorCheckUpReport _doctorCheck;

    public DoctorCheckUpReportController(IDoctorCheckUpReport doctorCheck) => _doctorCheck = doctorCheck;

    [Route("DisplayDoctorCheckUpSummary")]
    [HttpGet]
    [Authorize(Policy = "DoctorWisePatientsAllPolicy")]
    public IActionResult DisplayDoctorCheckUpSummary()
    {
        var modelList = new List<DoctorCheckUpReportSummaryModel>();
        ViewBag.fromDate = null;
        ViewBag.toDate = null;
        return View(modelList);
    }

    [Route("DisplayDoctorCheckUpSummary")]
    [HttpPost]
    [Authorize(Policy = "DoctorWisePatientsAllPolicy")]
    public IActionResult DisplayDoctorCheckUpSummary(IFormCollection keyValues)
    {
        var fromDate = (!string.IsNullOrEmpty(keyValues["fromDate"])) ? keyValues["fromDate"].ToString() : null;
        var toDate = (!string.IsNullOrEmpty(keyValues["toDate"])) ? keyValues["toDate"].ToString() : null;

        ViewBag.fromDate = fromDate;
        ViewBag.toDate = toDate;

        var response = _doctorCheck.SummaryReport(fromDate, toDate);
        return View(response);
    }


    [Route("DisplayDetails")]
    [Authorize(Policy = "DoctorWisePatientsAllPolicy")]
    public IActionResult DisplayDetails(int DoctorId, string FromDate, string ToDate)
    {
        ViewBag.fromDate = FromDate;
        ViewBag.toDate = ToDate;
        var response = _doctorCheck.DetailsReport(DoctorId, FromDate, ToDate);
        return View(response);
    }
}
