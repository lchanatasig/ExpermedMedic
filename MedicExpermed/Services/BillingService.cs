using MedicExpermed.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace MedicExpermed.Services
{

    public class BillingService
    {
        private readonly medicossystembdIContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<PatientService> _logger;

        public BillingService(medicossystembdIContext context, IHttpContextAccessor httpContextAccessor, ILogger<PatientService> logger)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;


        }


        public async Task<bool> InsertarFacturaAsync(int citaId, DateTime fechaFacturacion, decimal totalFactura,
                string metodoPago, string estadoFactura, string banco, byte[] comprobantePago)
        {
            using (SqlConnection connection = new SqlConnection(_context.Database.GetConnectionString()))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand("sp_InsertarFactura", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CitaId", citaId);
                        command.Parameters.AddWithValue("@FechaFacturacion", fechaFacturacion);
                        command.Parameters.AddWithValue("@TotalFactura", totalFactura);
                        command.Parameters.AddWithValue("@MetodoPago", metodoPago);
                        command.Parameters.AddWithValue("@EstadoFactura", estadoFactura);
                        command.Parameters.AddWithValue("@Banco", banco);
                        command.Parameters.AddWithValue("@ComprobantePago", comprobantePago);

                        int rowsAffected = await command.ExecuteNonQueryAsync();
                        return rowsAffected > 0;  // True si se insertó correctamente
                    }
                }
                catch (Exception ex)
                {
                    // Manejo del error
                    Console.WriteLine($"Error al insertar la factura: {ex.Message}");
                    throw;
                }
            }
        }

    }

}

