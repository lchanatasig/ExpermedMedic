using Microsoft.AspNetCore.Mvc;
using MedicExpermed.Models;
using MedicExpermed.Services;

namespace medic_system.Controllers
{
    public class BillingController : Controller
    {
        private readonly BillingService _facturacion;

        public IActionResult Billing()
        {
            var model = new Facturacion
            {
                FechaFacturacion = DateTime.Now,
            };

            return View();
        }

        public async Task<IActionResult> InsertarFactura([FromBody] Facturacion facturaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                bool isInserted = await _facturacion.InsertarFacturaAsync(
                    facturaDto.CitaId ?? 0 ,
                    facturaDto.FechaFacturacion,
                    facturaDto.TotalFactura,
                    facturaDto.MetodoPago,
                    facturaDto.EstadoFactura,
                    facturaDto.Banco,
                    facturaDto.ComprobantePago
                );

                if (isInserted)
                {
                    return Ok(new { message = "Factura insertada correctamente." });
                }
                else
                {
                    return StatusCode(500, "Error al insertar la factura.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Ocurrió un error: {ex.Message}");
            }
        }
    }


}
