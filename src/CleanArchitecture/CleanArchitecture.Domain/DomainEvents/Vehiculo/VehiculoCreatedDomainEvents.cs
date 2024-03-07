using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.DomainEvents.Vehiculo;

public sealed record VehiculolCreatedDomainEvents(Guid userId) : IDomainEvent;
