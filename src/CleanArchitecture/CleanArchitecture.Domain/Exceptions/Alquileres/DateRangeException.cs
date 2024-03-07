using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Exceptions.Alquileres;

public class DateRangeException : DomainException
{
    private const string ERROR_MESSAGE = "El rango de fechas es incorrecto.";
    public DateRangeException()
        : base(ERROR_MESSAGE) { }

}
