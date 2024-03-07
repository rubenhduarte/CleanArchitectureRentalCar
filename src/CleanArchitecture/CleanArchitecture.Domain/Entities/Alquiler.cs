using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.ValueObjects.Alquiler;
using CleanArchitecture.Domain.ValueObjects.Vehiculo;

namespace CleanArchitecture.Domain.Entities;
public sealed class Alquiler : Entity
{
    public Alquiler(Guid id) : base(id)
    {
        
    }

    public Guid VehiculoId { get; private set; }
    public Guid UserId { get; private set; }
    public Moneda? PrecioPorPeriodo { get; private set; }
    public Moneda? PrecioPorMantenimiento { get; private set; }
    public Moneda? Accesorios { get; private set; }
    public Moneda? PrecioTotal { get; private set; }
    public AlquilerStatus Status { get; private set; }
    public DateRange? DateRange { get; private set; }
    public DateTime FechaCreacion { get; private set; }
    public DateTime FechaConfirmacion { get; private set; }
    public DateTime FechaDenegacion { get; private set; }


}
