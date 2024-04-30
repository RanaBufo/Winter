namespace ServerApp.Api.DataTransferObjects.Note;
internal record NoteAddRequest(
    string Header, 
    string? Text, 
    DateTime? Date, 
    string UserId);

internal record NoteAddResponse(
    string Id,
    bool IsSuccess,
    string? Error,
    bool IsHeaderValid,
    bool IsDatelValid);
