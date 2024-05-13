using Kolokwium_1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium_1.Controllers;
[Route("/api/patients")]
[ApiController]
public class PatientController : ControllerBase
{
    private IPatientService _patientService;

    public PatientController(IPatientService patientService)
    {
        _patientService = patientService;
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeletePatient(int id)
    {
        var res =  _patientService.DeletePatient(id);
        return NoContent();
    }
}