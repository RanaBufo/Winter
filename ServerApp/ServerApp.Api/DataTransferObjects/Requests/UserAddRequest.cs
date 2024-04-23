namespace ServerApp.Api.DataTransferObjects.Requests;

internal record UserRegistrationRequest(string Email, string Password, string? Nickname, string? FirstName, string? LastName, string? Description);
