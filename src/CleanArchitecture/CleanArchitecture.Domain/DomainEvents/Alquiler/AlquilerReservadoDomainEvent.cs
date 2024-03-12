using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.DomainEvents.Alquiler;

public sealed record AlquilerReservadoDomainEvent(Guid alquilerId) : IDomainEvent;
