namespace cqrsdddcleanarch.Application.Authentication;

public record RegisterResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string Email
    );