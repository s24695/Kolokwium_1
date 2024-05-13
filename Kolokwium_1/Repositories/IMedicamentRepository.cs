using Kolokwium_1.DTOs;
using Kolokwium_1.Models;

namespace Kolokwium_1.Repositories;

public interface IMedicamentRepository
{
    Task<Medicament> GetMedicament(int id);
}