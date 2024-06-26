﻿using Microsoft.AspNetCore.Authorization;
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
            .WithTags(AUTH_TAG);

        _ = app.MapPost("/auth/logout", [Authorize] () => {
            // чистит куки
        })
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status401Unauthorized)
            .WithTags(AUTH_TAG)
            .WithOpenApi();

        //todo
        _ = app.MapPost("/auth/refresh", () => {
        })
            .WithTags(AUTH_TAG)
            .Produces<RefsreshTokenResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status401Unauthorized)
            .WithDescription("Requred authorization")
            .WithOpenApi();
    }

    private static void UserAuthorize() {

        _ = app.MapGet("/account", [Authorize] () => {
        })
            .WithTags(ACCOUNT_TAG)
            .Produces<UserAccountResponse>(StatusCodes.Status200OK)
            .WithDescription("Requred authorization")
            .WithOpenApi();

        _ = app.MapDelete("/account", [Authorize] () => {
        })
            .WithTags(ACCOUNT_TAG)
            .Produces(StatusCodes.Status204NoContent)
            .WithDescription("Requred authorization")
            .WithOpenApi();

        _ = app.MapPatch("/account", [Authorize] () => {
        })
            .WithTags(ACCOUNT_TAG)
            .Produces(StatusCodes.Status200OK)
            .WithDescription("Requred authorization")
            .WithOpenApi();
    }

    // TODO: dto
    private static void Wikies() {

        _ = app.MapGet("/account/wiki/all", [Authorize] () => { })
            .WithTags(WIKIES_TAG);

        _ = app.MapGet("/account/wiki/{id:long}", [Authorize] () => { })
            .WithTags(WIKIES_TAG);

        _ = app.MapGet("/account/wiki/{name:alpha}", [Authorize] () => { })
            .WithTags(WIKIES_TAG);

        _ = app.MapPost("/account/wiki/{name:alpha}", [Authorize] () => { })
            .WithTags(WIKIES_TAG);

        _ = app.MapDelete("/account/wiki/{id:long}", [Authorize] () => { })
            .WithTags(WIKIES_TAG);

        _ = app.MapDelete("/account/wiki/{name:alpha}", [Authorize] () => { })
            .WithTags(WIKIES_TAG);
    }

    // TODO: dto
    private static void Notes() {
        _ = app.MapGet("/account/wiki/{wikiName:alpha}/notes/all", [Authorize] () => { })
            .WithTags(NOTES_TAG);

        _ = app.MapGet("/account/wiki/{wikiId:long}/notes/all", [Authorize] () => { })
            .WithTags(NOTES_TAG);

        _ = app.MapPost("/account/wiki/{wikiName:alpha}/notes", [Authorize] () => { })
            .WithTags(NOTES_TAG);

        _ = app.MapPost("/account/wiki/{wikiId:long}/notes", [Authorize] (long wikiId) => { })
            .WithTags(NOTES_TAG);

        _ = app.MapDelete("/account/wiki/{wikiName:alpha}/notes/{noteId:long}", [Authorize] () => { })
            .WithTags(NOTES_TAG);

        _ = app.MapDelete("/account/wiki/{wikiId:long}/notes/{noteId:long}", [Authorize] () => { })
            .WithTags(NOTES_TAG);
    }

    private static void Search() {
        _ = app.MapGet("/search/wiki/global", (string? name) => { })
            .WithTags(SEARCH_TAG);

        _ = app.MapGet("/search/wiki/account", (string? name) => { })
            .WithTags(SEARCH_TAG);

        _ = app.MapGet("/search/wiki/account/{id:long}", (string? name) => { })
            .WithTags(SEARCH_TAG);

        _ = app.MapGet("/search/wiki/account/{nickname:alpha}", (string? name) => { })
            .WithTags(SEARCH_TAG);

        _ = app.MapGet("/search/notes/account", () => { })
            .WithTags(SEARCH_TAG);

        _ = app.MapGet("/search/notes/account/{id:long}", () => { })
            .WithTags(SEARCH_TAG);

        _ = app.MapGet("/search/notes/account/{nickname:alpha}", () => { })
            .WithTags(SEARCH_TAG);

        _ = app.MapGet("/search/wiki/{id:long}/notes", () => { })
            .WithTags(SEARCH_TAG);

        _ = app.MapGet("/search/wiki/{name:alpha}/notes", () => { })
            .WithTags(SEARCH_TAG);

        _ = app.MapGet("/search/account", (string? firstName, string? lastName, string? nickname) => { })
            .WithTags(SEARCH_TAG);
    }
}

