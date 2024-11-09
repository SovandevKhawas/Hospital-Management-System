using MetaDataLibrary.PatientRegistration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RepositoryLibrary.CardMaster;

namespace MainProject.Areas.OPD.Controllers;
[Authorize, Area("OPD")]
public class CardMasterController : Controller
{
    private readonly ICardMaster _cardMaster;
    public CardMasterController(ICardMaster cardMaster) => _cardMaster = cardMaster;

    [HttpGet, Route("DisplayCardMaster")]
    public IActionResult DisplayCardMaster()
    {
        var cardTypes = _cardMaster.GetAllCardMaster();
        return View(cardTypes);
    }

    [HttpGet, Route("PatientCardMaster")]
    public IActionResult PatientCardMaster(int? Id)
    {
        MetaDataLibrary.PatientRegistration.PatientCardType card = new();
        Id ??= 0;
        var cardType = (Id != 0) ? _cardMaster.GetCardMasterById((int)Id) : card;
        return View(cardType);
    }

    [HttpPost, Route("PatientCardMaster")]
    public IActionResult PatientCardMaster(MetaDataLibrary.PatientRegistration.PatientCardType patientCard)
    {
        string message;
        if (ModelState.IsValid)
        {
            message = _cardMaster.AddEditCardMaster(patientCard);
            if (message == "Success")
                return RedirectToAction("DisplayCardMaster");
            else
            {
                ModelState.AddModelError(string.Empty, message);
                return View(patientCard);
            }
        }
        else
        {
            return View(patientCard);
        }
    }
}
