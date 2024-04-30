using ServerApp.Api.DataTransferObjects.Note;

internal record WikiResponse(
    long Id,
    string Header,
    string? Description,
    DateTime Date,
    string UserId,
    IReadOnlyList<NoteResponse>? notes);

internal record WikiResponseArray(
    int count,
    IReadOnlyList<WikiResponse> allWiki);
