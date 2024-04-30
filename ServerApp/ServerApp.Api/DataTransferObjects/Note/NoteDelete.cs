namespace ServerApp.Api.DataTransferObjects.Note;

internal record NoteIdDeleteRequest(
    long? WikiId,
    long? IdNote);

internal record NoteNameDeleteRequest(
    string? WikiName,
    long? IdNote);
