namespace CleanArchitecture.Domain.ValueObjects.Vehiculo;

public record PrecioDetalle(
    Moneda PrecioPorPeriodo, 
    Moneda Mantenimiento, 
    Moneda Accesorios,
    Moneda PrecioTotal
    );

