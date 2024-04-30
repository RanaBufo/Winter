namespace ServerApp.Api.DataTransferObjects.Note;

internal record NoteResponse(
    long Id,
    string Header,
    string? Text,
    DateTime Date,
    string UserId);
