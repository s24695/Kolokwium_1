using System.Data.SqlClient;
using Kolokwium_1.DTOs;
using Kolokwium_1.Models;

namespace Kolokwium_1.Repositories;

public class MedicamentRepository : IMedicamentRepository
{
    private IConfiguration _configuration;

    public MedicamentRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<Medicament> GetMedicament(int id)
    {
        await using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        await con.OpenAsync();

        await using var com = new SqlCommand();
        com.Connection = con;

        com.CommandText = "SELECT * FROM Medicament WHERE IdMedicament = @id";
        com.Parameters.AddWithValue("@id", id);
        
        await using var reader = await com.ExecuteReaderAsync();

        var medicament = new Medicament();

        while (await reader.ReadAsync())
        {
            medicament = new()
            {
                IdMedicament = (int)reader["IdMedicament"],
                Name = reader["Name"].ToString(),
                Description = reader["Description"].ToString(),
                Type = reader["Type"].ToString(),
            };
        }

        com.Parameters.Clear();

        return medicament;
    }
}