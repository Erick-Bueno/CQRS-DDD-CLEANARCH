namespace cqrsdddcleanarch.Application.Authentication;

public record LoginResponse(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string AccessToken,
    string RefreshToken,
    );