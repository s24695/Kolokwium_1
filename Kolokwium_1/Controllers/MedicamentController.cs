using Kolokwium_1.DTOs;
using Kolokwium_1.Models;
using Kolokwium_1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium_1.Controllers;

[Route("/api/medicaments")]
[ApiController]
public class MedicamentController : ControllerBase
{
    private IMedicamentService _medicamentService;

    public MedicamentController(IMedicamentService medicamentService)
    {
        _medicamentService = medicamentService;
    }

    [HttpGet]
    public ActionResult<Medicament> GetMedicaments(int id)
    {
        var medicamament = _medicamentService.GetMedicament(id);
        return Ok(medicamament);
    }
}