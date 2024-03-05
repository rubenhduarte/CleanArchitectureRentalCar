using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Vehiculos;


// No quiero que esta clase sea heredada por otra, (Principio de responsabilidad unica)
public sealed class Vehiculo : Entity
{

    public Vehiculo(
        Guid id,
        Modelo? modelo,
        Vin? vin,
        Direccion? direccion, 
        Moneda? precio,
        Moneda? mantenimiento,
        DateTime? fechaUltimoAlquiler,
        List<Accesorio> accesorios        
        
        ) : base(id)
    {
        
        Modelo = modelo;
        Vin = vin;
        Direccion = direccion;
        Precio = precio;
        Mantenimiento = mantenimiento;
        FechaUltimoAlquiler = fechaUltimoAlquiler;
        Accesorios = accesorios;

    }

    public Modelo? Modelo { get; private set; }
    // Private Set = Solo es posible a nivel de la entidad modificar el valor de la propiedad
    public Vin? Vin { get; private set; } // Like serial number
    public Direccion? Direccion { get; private set; }
    public Moneda? Precio { get; private set; }
    public Moneda? Mantenimiento { get; private set; }
    public DateTime? FechaUltimoAlquiler { get; private set; }
    public List<Accesorio> Accesorios { get; private set; } = new();


}
