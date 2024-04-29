namespace ServerApp.Api.DataTransferObjects;

internal record class UserLoginRequest(
    string EmailOrNickname,
    string Password);

internal record class UserLoginResponse(
    string UserId,
    string JwtToken,
    bool IsSuccess,
    bool IsUserExists,
    bool IsWrongPassword,
    string? Error);
