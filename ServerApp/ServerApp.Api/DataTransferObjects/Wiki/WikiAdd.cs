namespace ServerApp.Api.DataTransferObjects.Wiki;

internal record WikiAddRequest(
    string Header,
    string? Description,
    DateTime Date,
    string UserId);

internal record WikiAddRespose(
    string Id,
    bool IsSuccess,
    string? Error,
    bool IsHeaderValid,
    bool IsDatelValid);
