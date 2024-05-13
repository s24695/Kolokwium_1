using Kolokwium_1.DTOs;
using Kolokwium_1.Models;
using Kolokwium_1.Repositories;

namespace Kolokwium_1.Services;

public class MedicamentService : IMedicamentService
{
    private IMedicamentRepository _medicamentRepository;

    public MedicamentService(IMedicamentRepository medicamentRepository)
    {
        _medicamentRepository = medicamentRepository;
    }

    public Task<Medicament> GetMedicament(int id)
    {
        return _medicamentRepository.GetMedicament(id);
    }
}