using ZiurBlazorTest.Models;

namespace ZiurBlazorTest.Services;

public class ControlfinancieroService
{
    public async Task<List<Controlfinanciero>> ObtenerAsync()
    {
        // DATOS DE PRUBA
        return await Task.FromResult(new List<Controlfinanciero>
        {
            new Controlfinanciero { Codigo = 29, Descripcion = "Ajuste al Inventario", VActiva = false },
            new Controlfinanciero { Codigo = 51, Descripcion = "Avance Producción", VActiva = false },
            new Controlfinanciero { Codigo = 17, Descripcion = "Balance Inicial", VActiva = false }
        });
    }
}
