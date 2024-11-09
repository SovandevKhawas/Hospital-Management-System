using MetaDataLibrary.DoctorMaster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryLibrary.Common;
using RepositoryLibrary.DoctorMaster;

namespace MainProject.Areas.OPD.Controllers;
[Area("OPD")]

public class DoctorMasterController : Controller
{
    private readonly IDoctorMaster _master;
    private readonly IWebHostEnvironment _environment;
    private readonly ICommon _ic;

    public DoctorMasterController(IDoctorMaster master, IWebHostEnvironment environment, ICommon ic)
    {
        _master = master;
        _environment = environment;
        _ic = ic;
    }

    [Route("DisplayDoctorMaster")]
    [Authorize(Policy = "DoctorMasterViewPolicy")]
    public ActionResult DisplayDoctorMaster(int pg = 1, int pageSize = 5, string SearchText = "")
    {
        ViewBag.SearchText = SearchText;
        IQueryable<DoctorMasterModel> heads;
        if (string.IsNullOrEmpty(SearchText))
        {
            heads = _master.GetAllDoctorMaster().AsQueryable();
        }
        else
        {
            heads = _master.GetAllDoctorMaster().Where(m => m.DoctorName!.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                m.RegistrationNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                m.MobileNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                ).AsQueryable();
        }
        return View(_ic.GetGenericPaginationModel<DoctorMasterModel>(heads, heads.Count(), pg, pageSize));
    } // DisplayDoctorMaster...

    [Route("DisplayDoctorMaster")]
    [Authorize(Policy = "DoctorMasterViewPolicy")]
    [HttpPost]
    public ActionResult DisplayDoctorMaster(IFormCollection collection, int pg = 1, int pageSize = 5, string SearchText = "")
    {
        IQueryable<DoctorMasterModel> heads;
        if (string.IsNullOrEmpty(collection["SearchText"]))
        {
            heads = _master.GetAllDoctorMaster().AsQueryable();
        }
        else
        {
            ViewBag.SearchText = collection["SearchText"].ToString();
            heads = _master.GetAllDoctorMaster().Where(m => m.DoctorName!.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                m.RegistrationNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
                m.MobileNo!.Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                ).AsQueryable();
        }
        return View(_ic.GetGenericPaginationModel<DoctorMasterModel>(heads, heads.Count(), pg, pageSize));
    } // DisplayDoctorMaster...

    [Route("DMmaster")]
    [Authorize(Policy = "DoctorMasterAllPolicy")]
    public IActionResult DMmaster(int? Id)
    {
        Id ??= 0;
        var docMaster = (Id != 0) ? _master.GetDoctorMasterById((int)Id) : new DoctorMasterModel();
        return View(docMaster);
    } // DMmaster...

    [HttpPost, Route("DMmaster")]
    [Authorize(Policy = "DoctorMasterAllPolicy")]
    public IActionResult DMmaster(DoctorMasterModel model, IFormCollection collection)
    {
        string message = string.Empty;
        if (ModelState.IsValid)
        {
            if (model.File != null)
            {
                const string foldername = "Signature";
                var guidno = new Guid(Guid.NewGuid().ToString());
                var extention = Path.GetExtension(model.File.FileName);
                var filename = model.DoctorName + guidno + DateTime.Now.ToString("dd_MM_yyyy") + "." + extention;
                string WebPath = Path.Combine(_environment.WebRootPath, foldername);
                if (!System.IO.File.Exists(WebPath))
                {
                    Directory.CreateDirectory(WebPath);
                }

                var path = Path.Combine(WebPath, filename);
                var stream = new FileStream(path, FileMode.Create);
                model.File.CopyToAsync(stream);

                var savePath = Path.Combine(foldername, filename);

                model.FilePath = savePath;
            }
            else
            {
                if (!string.IsNullOrEmpty(collection["TXTFilePath"]))
                {
                    model.FilePath = collection["TXTFilePath"].ToString();
                }
            }

            message = _master.AddEditDoctorMaster(model);
            if (message == "Success")
                return RedirectToAction("DisplayDoctorMaster");
            else
            {
                ModelState.AddModelError(string.Empty, message);
                return View(model);
            }
        } // if valid...

        if (!string.IsNullOrEmpty(collection["TXTFilePath"]))
        {
            model.FilePath = collection["TXTFilePath"].ToString();
        }
        return View(model);
    } // DMmaster...
} // class...
