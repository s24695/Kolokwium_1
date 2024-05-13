using Kolokwium_1.DTOs;
using Kolokwium_1.Models;

namespace Kolokwium_1.Services;

public interface IMedicamentService
{
    Task<Medicament> GetMedicament(int id);
}