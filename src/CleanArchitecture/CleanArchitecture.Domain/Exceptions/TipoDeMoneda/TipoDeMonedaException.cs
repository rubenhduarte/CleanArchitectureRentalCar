using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Exceptions.Users;

public class TipoDeMonedaException : DomainException
{
    private const string ERROR_MESSAGE = "El tipo de moneda es inválido.";
    public TipoDeMonedaException()
        : base(ERROR_MESSAGE) { }
}
