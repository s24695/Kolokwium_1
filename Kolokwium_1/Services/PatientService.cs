using Kolokwium_1.Repositories;

namespace Kolokwium_1.Services;

public class PatientService : IPatientService
{
    private IPatientRepository _patientRepository;

    public PatientService(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }

    public Task<int> DeletePatient(int id)
    {
        return _patientRepository.DeletePatient(id);
    }
}