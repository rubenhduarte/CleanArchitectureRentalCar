using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Exceptions.Users;

public class EmptyUserNameException : DomainException
{
    private const string ERROR_MESSAGE = "Nombre de usuario no puede estar vacio.";
    public EmptyUserNameException()
        : base(ERROR_MESSAGE) { }
}
