using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.DomainEvents.User;
using CleanArchitecture.Domain.ValueObjects.User;

namespace CleanArchitecture.Domain.Entities;

public sealed class User : Entity
{
    private User(
        Guid id,
        Nombre nombre,
        Apellido apellido,
        Email email
        ) : base(id) { }
        
    public Nombre? Nombre { get; private set; }
    public Apellido? Apellido { get; private set; }
    public Email? Email { get; private set; }

    public static User Create(
        Nombre nombre,
        Apellido apellido,
        Email email)
    { 
    
        var user = new User(Guid.NewGuid(), nombre, apellido, email);
        user.RaiseDomainEvents(new UserCreatedDomainEvents(user.Id));
        return user;
    }


}
