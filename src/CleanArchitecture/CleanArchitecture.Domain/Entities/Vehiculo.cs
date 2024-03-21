using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.DomainEvents.Vehiculo;
using CleanArchitecture.Domain.ValueObjects.Vehiculo;

namespace CleanArchitecture.Domain.Entities;


// No quiero que esta clase sea heredada por otra, (Principio de responsabilidad unica)
public sealed class Vehiculo : Entity
{

    private Vehiculo(
        Guid id,
        Modelo? modelo,
        Patente? patente,
        Direccion? direccion,
        Moneda? precio,
        Moneda? mantenimiento,
        DateTime? fechaUltimoAlquiler,
        List<Accesorio> accesorios

        ) : base(id)
    {

        Modelo = modelo;
        Patente = patente;
        Direccion = direccion;
        Precio = precio;
        Mantenimiento = mantenimiento;
        FechaUltimoAlquiler = fechaUltimoAlquiler;
        Accesorios = accesorios;

    }

    public Modelo? Modelo { get; private set; }
    // Private Set = Solo es posible a nivel de la entidad modificar el valor de la propiedad
    public Patente? Patente { get; private set; }
    public Direccion? Direccion { get; private set; }
    public Moneda? Precio { get; private set; }
    public Moneda? Mantenimiento { get; private set; }
    public DateTime? FechaUltimoAlquiler { get; private set; }
    public List<Accesorio> Accesorios { get; private set; } = new();

    public static Vehiculo Create(
        Modelo? modelo,
        Patente? patente,
        Direccion? direccion,
        Moneda? precio,
        Moneda? mantenimiento,
        DateTime? fechaUltimoAlquiler,
        List<Accesorio> accesorios
)
    {
        var vehiculo = new Vehiculo(Guid.NewGuid(), modelo, patente, direccion, 
                                    precio, mantenimiento, fechaUltimoAlquiler, 
                                    accesorios);

        vehiculo.RaiseDomainEvents(new VehiculolCreatedDomainEvents(vehiculo.Id!));
        return vehiculo;
    }

    public void SetFechaUltimoAlquier(DateTime fechaUltimoAlquier) 
    {
        FechaUltimoAlquiler = fechaUltimoAlquier;
    }

}
