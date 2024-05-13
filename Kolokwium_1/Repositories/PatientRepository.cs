using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium_1.Repositories;

public class PatientRepository
{
    private IConfiguration _configuration;

    public PatientRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<int> DeletePatient(int id)
    {
        await using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();

        await using var com = new SqlCommand();
        com.Connection = con;
        
        var transaction = (SqlTransaction)await con.BeginTransactionAsync();
        com.Transaction = transaction;

        try
        {
            com.CommandText = "DELETE * FROM Patient WHERE IdPatient = @id";
            com.Parameters.AddWithValue("@id", id);
            
            
            
            await transaction.CommitAsync();
        }
        catch (Exception e)
        {
            await transaction.RollbackAsync();
            throw new Exception("not deleted");
        }
        
        return 0;
    }
}