namespace Kolokwium_1.Repositories;

public interface IPatientRepository
{
    Task<int> DeletePatient(int id);
}