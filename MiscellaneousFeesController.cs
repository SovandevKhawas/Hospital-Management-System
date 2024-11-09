using MetaDataLibrary.MiscellaneousFees;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using RepositoryLibrary.GeneralCheckup;
using RepositoryLibrary.IndoorCheckup;
using RepositoryLibrary.MiscellaneousFees;
using RepositoryLibrary.Utility;
using System.Globalization;

namespace MainProject.Areas.OPD.Controllers;

[Area("OPD")]
public class MiscellaneousFeesController : Controller
{
    private readonly IMiscellaneousFees _miscellaneousFees;
    private readonly ICheckupParameter _checkupParameter;
    private readonly IGeneralCheckup _checkup;
    private readonly IUtility _utility;

    public MiscellaneousFeesController(IMiscellaneousFees miscellaneousFees, ICheckupParameter checkupParameter, IGeneralCheckup checkup, IUtility utility)
    {
        _miscellaneousFees = miscellaneousFees;
        _checkupParameter = checkupParameter;
        _checkup = checkup;
        _utility = utility;
    }

    [Route("DisplayMiscellaneousFees")]
    public async Task<IActionResult> DisplayMiscellaneousFees()
    {
        var miscellaneousFees = await _miscellaneousFees.GetMiscellaneousFees();
        return View(miscellaneousFees);
    }

    [Route("AddEditMiscellaneousFees")]
    public async Task<IActionResult> AddEditMiscellaneousFees(int Id)
    {
        ViewBag.CheckupParameterList = await CheckupParameterList();
        ViewBag.Ledger = await GetAccountsExpenses();
        ViewBag.CashBank = await GetAccountsCashBank();
        var viewModel = Id == 0 ?
                    new MiscellaneousFeesHeadResponse() :
                    await _miscellaneousFees.GetMiscellaneousFeesById(Id);

        return View(viewModel);
    }

    [HttpPost, Route("AddEditMiscellaneousFees")]
    public async Task<IActionResult> AddEditMiscellaneousFees(MiscellaneousFeesHeadResponse response, IFormCollection key)
    {
        ViewBag.CheckupParameterList = await CheckupParameterList();
        ViewBag.Ledger = await GetAccountsExpenses();
        ViewBag.CashBank = await GetAccountsCashBank();
        var detailJsonString = key["miscellaneousFeesJson"].ToString();
        if (detailJsonString != "-1")
        {
            try
            {
                var detail = JsonConvert.DeserializeObject<List<MiscellaneousFeesDetailsResponse>>(detailJsonString);
                response.MiscellaneousFeesDetailsResponses = detail!;
            }
            catch
            {
                ModelState.AddModelError("", "Invalid Json");
            }
        }
        if (response.MiscellaneousFeesDetailsResponses.Count == 0)
        {
            ModelState.AddModelError("", "Miscellaneous Fees Details is required,at least one");
            return View(response);
        }

        if (!ModelState.IsValid)
        {
            return View(response);
        }
        response.DocDate = DateTime.ParseExact(response.DocDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        var request = MiscellaneousFeesHeadRequest.SetData(response);

        var result = await _miscellaneousFees.AddEditMiscellaneousFees(request);

        if (result != "Success")
        {
            ModelState.AddModelError("", result);
        }

        return result == "Success" ? RedirectToAction("DisplayMiscellaneousFees") : View(response);
    }

    [Route("PrintMiscellaneousFees")]
    public async Task<IActionResult> PrintMiscellaneousFees(int Id)
    {
        var miscellaneousFees = await _miscellaneousFees.GetMiscellaneousFeesById(Id);
        decimal TotalAmount = 0.0m;
        decimal DiscountAmount = 0;
        foreach (var micDtl in miscellaneousFees.MiscellaneousFeesDetailsResponses)
        {
            TotalAmount += micDtl.Amount;
            DiscountAmount += micDtl.DiscountAmount;

        }
        ViewBag.TotalAmount = TotalAmount;
        ViewBag.DiscountAmount = DiscountAmount;
        ViewBag.NetAmountToString = _utility.num_to_word(miscellaneousFees.NetAmount.ToString());
        return View(miscellaneousFees);
    }

    private async Task<List<SelectListItem>> CheckupParameterList()
    {
        var checkupParameters = await _checkupParameter.GetParameterModelsAsync();
        return checkupParameters.Select(x => new SelectListItem
        {
            Text = x.ParameterName,
            Value = x.IdNo.ToString()
        }).ToList();
    }

    [Route("GetRegistrationNoForMiscellaneousFees")]
    public JsonResult GetRegistrationNoForMiscellaneousFees(string search)
    {
        IQueryable<string> regList = _checkup.GetRegistrationNo()
                .Where(m => m.Contains(search, StringComparison.OrdinalIgnoreCase));
        return Json(regList);
    }

    [Route("GetMiscellaneousItemCharge")]
    public async Task<JsonResult> GetMiscellaneousItemCharge(int idNo)
    {
        var miscellaneousItem = await _checkupParameter.GetParameterModelAsync(idNo);

        var response = new
        {
            miscellaneousItem.Amount,
            miscellaneousItem.AcCode
        };

        return Json(response);
    }

    private async Task<List<SelectListItem>> GetAccountsCashBank()
    {
        var accounts = await _miscellaneousFees.GetAccountsCashBank();

        var list = new List<SelectListItem>();
        foreach (var account in accounts)
        {
            list.Add(new SelectListItem { Text = account.AccName, Value = account.AccId.ToString() });
        }
        return list;
    } // GetAccountsCashBank...

    private async Task<List<SelectListItem>> GetAccountsExpenses()
    {
        var accounts = await _miscellaneousFees.GetAccountsExpenses();

        var list = new List<SelectListItem>();
        foreach (var account in accounts)
        {
            list.Add(new SelectListItem { Text = account.AccName, Value = account.AccId.ToString() });
        }
        return list;
    } // GetAccountsExpenses...
}