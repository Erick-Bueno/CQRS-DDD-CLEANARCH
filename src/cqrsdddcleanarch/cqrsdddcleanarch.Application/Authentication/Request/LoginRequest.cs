namespace cqrsdddcleanarch.Application.Authentication

public record LoginRequest(
    string Email,
    string Password
    )