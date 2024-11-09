using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryLibrary.RegistrationReport;

namespace MainProject.Areas.OPD.Controllers
{
    [Area("OPD")]

    public class OPDRegFeesReportController : Controller
    {
        private readonly IRegistrationReport _registrationReport;

        public OPDRegFeesReportController(IRegistrationReport registrationReport)
        {
            _registrationReport = registrationReport;
        }

        [Route("DisplayRegistrationFeesReport")]
        [Authorize(Policy = "PatientRegFeesReportAllPolicy")]
        public IActionResult DisplayRegistrationFeesReport()
        {
            string FromDate = string.Format(DateTime.Now.ToString("dd/MM/yyyy"), "0:d", new System.Globalization.CultureInfo("en-GB"));
            string ToDate = string.Format(DateTime.Now.ToString("dd/MM/yyyy"), "0:d", new System.Globalization.CultureInfo("en-GB"));

            var modelList = _registrationReport.GatRegistrationFeesReport(FromDate, ToDate);
            return View(modelList);
        }

        [HttpPost, Route("DisplayRegistrationFeesReport")]
        [Authorize(Policy = "PatientRegFeesReportAllPolicy")]
        public IActionResult DisplayRegistrationFeesReport(string FromDate, string ToDate, string FilterString)
        {
            var modelList = _registrationReport.GatRegistrationFeesReport(FromDate, ToDate, FilterString);
            return View(modelList);
        }
    }
}
