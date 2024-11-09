using MetaDataLibrary.DoctorUnit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryLibrary.DoctorUnit;

namespace MainProject.Areas.OPD.Controllers;
[Area("OPD")]
public class DoctorUnitController : Controller
{
    private readonly IDoctorUnit _unit;
    public DoctorUnitController(IDoctorUnit unit) => _unit = unit;

    [Route("DisplayDoctorUnit")]
    [Authorize(Policy = "DoctorUnitViewPolicy")]
    public IActionResult DisplayDoctorUnit() => View(_unit.GetAllDoctorUnit());

    [Route("DoctorUnitMaster")]
    [Authorize(Policy = "DoctorUnitAllPolicy")]
    public IActionResult DoctorUnitMaster(int? Id)
    {
        Id ??= 0;
        var DocUnit = (Id != 0) ? _unit.GetDoctorUnitById((int)Id) : new DoctorUnitModel();
        return View(DocUnit);
    }

    [HttpPost, Route("DoctorUnitMaster")]
    [Authorize(Policy = "DoctorUnitAllPolicy")]
    public IActionResult DoctorUnitMaster(DoctorUnitModel model)
    {
        string message;
        if (ModelState.IsValid)
        {
            message = _unit.AddEditDoctorUnit(model);
            if (message == "Success")
                return RedirectToAction("DisplayDoctorUnit");
            else
            {
                ModelState.AddModelError(string.Empty, message);
                return View(model);
            }
        }
        else
        {
            return View(model);
        }
    }
}
