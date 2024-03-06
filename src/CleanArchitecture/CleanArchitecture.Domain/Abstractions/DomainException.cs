namespace CleanArchitecture.Domain.Abstractions;

public abstract class DomainException : Exception
{
    public string? Code { get; }

    public string? Property { get; }

    protected DomainException(string message)
        : base(message)
    {
    }

    protected DomainException(string message, string? code)
        : this(message)
    {
        Code = code;
    }

    protected DomainException(string message, string? code, string? property)
        : this(message, code)
    {
        Property = property;
    }
}