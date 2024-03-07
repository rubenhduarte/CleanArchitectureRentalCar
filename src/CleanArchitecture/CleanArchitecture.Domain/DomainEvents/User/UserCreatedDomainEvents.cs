using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.DomainEvents.User;

public sealed record UserCreatedDomainEvents(Guid userId) : IDomainEvent;
