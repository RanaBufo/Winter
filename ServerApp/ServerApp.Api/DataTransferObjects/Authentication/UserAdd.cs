namespace ServerApp.Api.DataTransferObjects;

internal record UserRegistrationRequest(
    string Email,
    string Password,
    string Nickname,
    string? FirstName,
    string? LastName,
    string? Description);

internal record UserRegistrationResponse(
    string Id,
    string JwtToken,
    bool IsSuccess,
    bool IsAlreadyExist,
    string? Error,
    bool IsPasswordValid,
    PasswordProblems[]? PasswordProblems,
    bool IsEmailValid,
    bool? IsNicknameValid,
    bool? IsFirstNameValid,
    bool? IsLastNameValid,
    bool? IsDescriptionValid);

//
internal enum PasswordProblems {
    TooShort,
    NoDigits,
    NoLetters,
    NoUppercase,
    NoLowercase,
    NoSymbols,
}
