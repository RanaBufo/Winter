using Microsoft.AspNetCore.Authorization;
using ServerApp.Api.DataTransferObjects;
using ServerApp.Api.DataTransferObjects.Account;

namespace ServerApp.Api.Routing;

internal static class Routes {
    private static WebApplication app = null!;

    private const string WIKIES_TAG = "Wikies";
    private const string SEARCH_TAG = "Searching";
    private const string AUTH_TAG = "Authentication";
    private const string ACCOUNT_TAG = "Account";
    private const string NOTES_TAG = "Notes";

    public static void SetRoutes(WebApplication app) {
        Routes.app = app;

        Auth();
        UserAuthorize();
        Wikies();
        Notes();
        Search();
    }

    private static void Auth() {
        _ = app.MapPost("/auth/register", (UserRegistrationRequest request) => {
            // akshdlk;asd
        })
            .Produces<UserRegistrationResponse>(StatusCodes.Status201Created)
            .WithTags(AUTH_TAG)
            .WithSummary("Register a user")
            .WithDescription("""
                    Register a user by required email and password and unnecessary nickname and other personal information. 
                    Returns jwt token in body and refresh in 'X-Refresh' http-only cookie.
                    """)
            .WithOpenApi();

        _ = app.MapPost("/auth/login", (UserLoginRequest request) => {
        })
            .Produces<UserLoginResponse>(StatusCodes.Status200OK)
            .WithTags(AUTH_TAG)
            .WithSummary("Login a user")
            .WithDescription("""
                    Login a user by required email or username and password. 
                    Returns jwt token in body and refresh in 'X-Refresh' http-only cookie.
                    """)
            .WithOpenApi();

        _ = app.MapPost("/auth/logout", [Authorize] () => {
            // чистит куки
        })
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status401Unauthorized)
            .WithTags(AUTH_TAG)
            .WithSummary("Logout a user")
            .WithDescription("""
                    Logout a user clearing cookies without accepting any parameters.
                    """)
            .WithOpenApi();

        //todo
        _ = app.MapPost("/auth/refresh", () => {
        })
            .WithTags(AUTH_TAG)
            .Produces<RefsreshTokenResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status401Unauthorized)
            .WithSummary("Refresh JWT")
            .WithDescription("""
                    Refreshes a JWT token. Returns jwt token in body.
                    """)
            .WithOpenApi();
    }

    private static void UserAuthorize() {

        _ = app.MapGet("/account", [Authorize] () => {
        })
            .WithTags(ACCOUNT_TAG)
            .Produces<UserAccountResponse>(StatusCodes.Status200OK)
            .WithSummary("Returns account data")
            .WithDescription("""
                    Returns the user's ID, nickname, first name, last name, and description.
                    """)
            .WithOpenApi();

        _ = app.MapDelete("/account", [Authorize] () => {
        })
            .WithTags(ACCOUNT_TAG)
            .Produces(StatusCodes.Status204NoContent)
            .WithSummary("Deletes the user")
            .WithDescription("""
                    Deletes the user data from the database.
                    """)
            .WithOpenApi();

        _ = app.MapPatch("/account", [Authorize] () => {
        })
            .WithTags(ACCOUNT_TAG)
            .Produces(StatusCodes.Status200OK)
            .WithSummary("Patch in user data")
            .WithDescription("""
                    Patch in email, password, nickname or other personal information
                    """)
            .WithOpenApi();
    }

    // TODO: dto
    private static void Wikies() {

        _ = app.MapGet("/account/wiki/all", [Authorize] () => { })
            .WithTags(WIKIES_TAG)
            .WithSummary("Get all wikies")
            .WithDescription("""
                    Returns a list of all available wikies
                    """)
            .WithOpenApi();

        _ = app.MapGet("/account/wiki/{id:long}", [Authorize] () => { })
            .WithTags(WIKIES_TAG)
            .WithSummary("Get a wiki by id")
            .WithDescription("""
                    Reterns wiki of a user by its id
                    """)
            .WithOpenApi();

        _ = app.MapGet("/account/wiki/{name:alpha}", [Authorize] () => { })
            .WithTags(WIKIES_TAG)
            .WithSummary("Get a wiki by name")
            .WithDescription("""
                    Reterns wiki of a user by its name
                    """)
            .WithOpenApi();

        _ = app.MapPost("/account/wiki/{name:alpha}", [Authorize] () => { })
            .WithTags(WIKIES_TAG)
            .WithSummary("Post a wiki with name")
            .WithDescription("""
                    Sends user's wiki with its name
                    """)
            .WithOpenApi();

        _ = app.MapDelete("/account/wiki/{id:long}", [Authorize] () => { })
            .WithTags(WIKIES_TAG)
             .WithSummary("Post a wiki with id")
            .WithDescription("""
                    Sends user's wiki with its id
                    """)
            .WithOpenApi();

        _ = app.MapDelete("/account/wiki/{name:alpha}", [Authorize] () => { })
            .WithTags(WIKIES_TAG)
            .WithSummary("Delete a wiki by name")
            .WithDescription("""
                    Deletes user's wiki by its name
                    """)
            .WithOpenApi();
    }

    // TODO: dto
    private static void Notes() {
        _ = app.MapGet("/account/wiki/{wikiName:alpha}/notes/all", [Authorize] () => { })
            .WithTags(NOTES_TAG)
            .WithSummary("Get all notes in a wiki by its name")
            .WithDescription("""
                    Returnes a list of all available notes in the wiki using name of the wiki
                    """)
            .WithOpenApi();

        _ = app.MapGet("/account/wiki/{wikiId:long}/notes/all", [Authorize] () => { })
            .WithTags(NOTES_TAG)
            .WithSummary("Get all notes in a wiki by its id")
            .WithDescription("""
                    Returnes a list of all available notes in the wiki using id of wiki
                    """)
            .WithOpenApi();

        _ = app.MapPost("/account/wiki/{wikiName:alpha}/notes", [Authorize] () => { })
            .WithTags(NOTES_TAG)
            .WithSummary("Post a note in a wiki by its name")
            .WithDescription("""
                    Sends note from the wiki using name of wiki
                    """)
            .WithOpenApi();

        _ = app.MapPost("/account/wiki/{wikiId:long}/notes", [Authorize] (long wikiId) => { })
            .WithTags(NOTES_TAG)
            .WithSummary("Post a note in a wiki by its name")
            .WithDescription("""
                    Returnes note from the wiki using id of wiki
                    """)
            .WithOpenApi();

        _ = app.MapDelete("/account/wiki/{wikiName:alpha}/notes/{noteId:long}", [Authorize] () => { })
            .WithTags(NOTES_TAG)
            .WithSummary("Delete a note by wiki name")
            .WithDescription("""
                    Deletes a note by id using name of wiki
                    """)
            .WithOpenApi();

        _ = app.MapDelete("/account/wiki/{wikiId:long}/notes/{noteId:long}", [Authorize] () => { })
            .WithTags(NOTES_TAG)
            .WithSummary("Delete a note by wiki id")
            .WithDescription("""
                    Deletes a note by id using id of wiki
                    """)
            .WithOpenApi();
    }

    private static void Search() {
        _ = app.MapGet("/search/wiki/global", (string? name) => { })
            .WithTags(SEARCH_TAG)
            .WithSummary("Search wiki in global")
            .WithDescription("""
                    Searches a wiki from the entire pool by required name of the wiki
                    """)
            .WithOpenApi();

        _ = app.MapGet("/search/wiki/account", (string? name) => { })
            .WithTags(SEARCH_TAG)
            .WithSummary("Search wiki of a user")
            .WithDescription("""
                    Searches a wiki among user's wikies by required name of the wiki
                    """)
            .WithOpenApi();

        _ = app.MapGet("/search/wiki/account/{id:long}", (string? name) => { })
            .WithTags(SEARCH_TAG)
            .WithSummary("Search wiki by id of a user")
            .WithDescription("""
                    Searches a wiki among user's wikies by required id of the user
                    """)
            .WithOpenApi();

        _ = app.MapGet("/search/wiki/account/{nickname:alpha}", (string? name) => { })
            .WithTags(SEARCH_TAG)
            .WithSummary("Search wiki by nickname of a user")
            .WithDescription("""
                    Searches a wiki among user's wikies by required name of the user
                    """)
            .WithOpenApi();

        _ = app.MapGet("/search/notes/account", () => { })
            .WithTags(SEARCH_TAG)
            .WithSummary("Search note")
            .WithDescription("""
                    Searches user's note
                    """)
            .WithOpenApi();

        _ = app.MapGet("/search/notes/account/{id:long}", () => { })
            .WithTags(SEARCH_TAG)
            .WithSummary("Search note by its id")
            .WithDescription("""
                    Searches user's note using id of user
                    """)
            .WithOpenApi();

        _ = app.MapGet("/search/notes/account/{nickname:alpha}", () => { })
            .WithTags(SEARCH_TAG)
            .WithSummary("Search note by its name")
            .WithDescription("""
                    Searches user's note using name of user
                    """)
            .WithOpenApi();

        _ = app.MapGet("/search/wiki/{id:long}/notes", () => { })
            .WithTags(SEARCH_TAG)
            .WithSummary("Search note in wiki by its id")
            .WithDescription("""
                    Searches note among notes in wiki by required id of wiki
                    """)
            .WithOpenApi();

        _ = app.MapGet("/search/wiki/{name:alpha}/notes", () => { })
            .WithTags(SEARCH_TAG)
            .WithSummary("Search note in wiki by its name")
            .WithDescription("""
                    Searches note among notes in wiki by required name of wiki
                    """)
            .WithOpenApi();

        _ = app.MapGet("/search/account", (string? firstName, string? lastName, string? nickname) => { })
            .WithTags(SEARCH_TAG)
            .WithSummary("Search an account")
            .WithDescription("""
                    Searches user's account by required first name, last name or nickname
                    """)
            .WithOpenApi();
    }
}

