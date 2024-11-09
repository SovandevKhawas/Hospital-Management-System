using MetaDataLibrary.PatientRegistration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryLibrary.Department;

namespace MainProject.Areas.OPD.Controllers;
[Area("OPD")]
public class DepartmentController : Controller
{
    private readonly IDepartment _department;

    public DepartmentController(IDepartment department) => _department = department;

    [HttpGet, Route("DisplayDepartment")]
    [Authorize(Policy = "DeptMasterViewPolicy")]
    public IActionResult DisplayDepartment()
    {
        var depts = _department.GetAllDepartments();
        return View(depts);
    }

    [HttpGet, Route("DepartmentMaster")]
    [Authorize(Policy = "DeptMasterAllPolicy")]
    public IActionResult DepartmentMaster(int? Id)
    {
        var department = new MetaDataLibrary.PatientRegistration.DepartmentMaster();
        Id ??= 0;
        var dept = (Id != 0) ? _department.GetDepartmentById((int)Id) : department;
        return View(dept);
    }

    [HttpPost, Route("DepartmentMaster")]
    [Authorize(Policy = "DeptMasterAllPolicy")]
    public IActionResult DepartmentMaster(MetaDataLibrary.PatientRegistration.DepartmentMaster departmentMaster)
    {
        string message;
        if (ModelState.IsValid)
        {
            message = _department.AddEditDepartment(departmentMaster);
            if (message == "Success")
                return RedirectToAction("DisplayDepartment");
            else
            {
                ModelState.AddModelError(string.Empty, message);
                return View(departmentMaster);
            }
        }
        else
        {
            return View(departmentMaster);
        }
    }
}
