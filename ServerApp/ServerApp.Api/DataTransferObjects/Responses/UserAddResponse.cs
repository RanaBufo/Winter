namespace ServerApp.Api.DataTransferObjects.Responses;

internal record UserAddResponse(string Id, string JwtToken, bool IsSuccess, bool IsAlreadyExist, string? Error, bool IsPasswordValid, PasswordProblems? PasswordProblems, bool IsEmailValid, bool? IsNicknameValid, bool? IsFirstNameValid, bool? IsLastNameValid, bool? IsDescriptionValid);

internal enum PasswordProblems {
    TooShort,
    NoDigits,
    NoLetters,
    NoUppercase,
    NoLowercase,
    NoSymbols,
}
