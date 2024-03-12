using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.ValueObjects.Alquiler;
using CleanArchitecture.Domain.ValueObjects.Vehiculo;

namespace CleanArchitecture.Domain.DomainServices.Alquiler;

public class PrecioService
{

    public PrecioDetalle CalcularPrecio(Vehiculo vehiculo, DateRange periodo)
    {

        var tipoMoneda = vehiculo.Precio!.tipoMoneda;
        var precioPorPeriodo = new Moneda(
            periodo.CantidadDias * vehiculo.Precio.monto,
            tipoMoneda);

        decimal percentageChange = 0;

        foreach (var accesorio in vehiculo.Accesorios)
        {

            percentageChange += accesorio switch
            {
                Accesorio.AppleCar or Accesorio.AndriodCar => 0.5m,
                Accesorio.AireAcondicionado => 0.1m,
                Accesorio.Mapas => 0.01m,
                _ => 0
            };
        }

        var accesorioCharges = Moneda.Zero(tipoMoneda);

        if (percentageChange > 0)
        {

            accesorioCharges = new Moneda(
                precioPorPeriodo.monto * percentageChange,
                tipoMoneda
                );
        }

        var precioTotal = Moneda.Zero(tipoMoneda);
        precioTotal += precioPorPeriodo;

        if (!vehiculo!.Mantenimiento!.isZero())
        {
            precioTotal += vehiculo.Mantenimiento;
        }

        precioTotal += accesorioCharges;
        
        return new PrecioDetalle(
            precioPorPeriodo, 
            vehiculo.Mantenimiento, 
            accesorioCharges, 
            precioTotal);
    }
}
