using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.DomainEvents.Alquiler;
using CleanArchitecture.Domain.ValueObjects.Alquiler;
using CleanArchitecture.Domain.ValueObjects.Vehiculo;

namespace CleanArchitecture.Domain.Entities;
public sealed class Alquiler : Entity
{
    private Alquiler(
        Guid id,
        Guid vehiculoId,
        Guid userId,
        Moneda precioPorPeriodo,
        Moneda precioPorMantenimiento,
        Moneda accesorios,
        Moneda precioTotal,
        AlquilerStatus alquilerStatus, 
        DateTime fechaCreacion,
        DateRange duracion
        ) : base(id)
    {
        
        VehiculoId = vehiculoId;
        UserId = userId;
        PrecioPorPeriodo = precioPorPeriodo;
        PrecioPorMantenimiento = precioPorMantenimiento;
        PrecioTotal = precioTotal;
        Accesorios = accesorios;
        Status = alquilerStatus;
        FechaCreacion = fechaCreacion;
        Duracion = duracion;
    }

    public Guid VehiculoId { get; private set; }
    public Guid UserId { get; private set; }
    public Moneda? PrecioPorPeriodo { get; private set; }
    public Moneda? PrecioPorMantenimiento { get; private set; }
    public Moneda? Accesorios { get; private set; }
    public Moneda? PrecioTotal { get; private set; }
    public AlquilerStatus Status { get; private set; }
    public DateRange? Duracion { get; private set; }
    public DateTime? FechaCreacion { get; private set; }
    public DateTime? FechaConfirmacion { get; private set; }
    public DateTime? FechaDenegacion { get; private set; }
    public DateTime? FechaCompletado { get; private set; }
    public DateTime? FechaCancelacion { get; private set; }

    public static Alquiler Reservar(
        Guid vehiculoId, 
        Guid userId, 
        DateRange duracion, 
        DateTime fechaCreacion, 
        PrecioDetalle precioDetalle
        )
    {

        var alquiler = new Alquiler(Guid.NewGuid(),
            vehiculoId, userId, precioDetalle.PrecioPorPeriodo,
            precioDetalle.Mantenimiento,
            precioDetalle.Accesorios,
            precioDetalle.PrecioTotal, AlquilerStatus.Reservado,
            fechaCreacion, duracion);

        alquiler.RaiseDomainEvents(new AlquilerReservadoDomainEvent(alquiler.Id!));

        return alquiler;

    }
}
