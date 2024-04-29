namespace ServerApp.Api.DataTransferObjects.Account;

internal record class UserAccountResponse(
    long Id,
    string Email,
    string Nickname,
    string? FirstName,
    string? LastName,
    string Description);
