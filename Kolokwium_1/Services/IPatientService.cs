namespace Kolokwium_1.Services;

public interface IPatientService
{
    Task<int> DeletePatient(int id);
}