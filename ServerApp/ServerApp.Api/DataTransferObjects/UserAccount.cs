namespace ServerApp.Api.DataTransferObjects;

internal record class UserAccountResponse(long Id, string Email, string? Nickname, string? firstName, string? LastName, string Description);
