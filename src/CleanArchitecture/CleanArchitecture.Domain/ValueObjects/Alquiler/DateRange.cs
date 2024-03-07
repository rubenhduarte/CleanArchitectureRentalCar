using CleanArchitecture.Domain.Exceptions.Alquileres;

namespace CleanArchitecture.Domain.ValueObjects.Alquiler;

public sealed record DateRange
{

    private DateRange()
    {
        
    }

    public DateOnly Inicio { get; init; }
    public DateOnly Fin {  get; init; }

    public int CantidadDias => Fin.DayNumber - Inicio.DayNumber;

    public static DateRange Create(DateOnly inicio, DateOnly fin)
    {

        if (inicio > fin)
            throw new DateRangeException();


        return new DateRange
        {
            Inicio = inicio,
            Fin = fin
        };

    }

}
