using Microsoft.AspNetCore.Authorization;
using ServerApp.Api.DataTransferObjects;

namespace ServerApp.Api.Routing;

internal static class Routes {
    private static WebApplication app = null!;

    public static void SetRoutes(WebApplication app) {
        Routes.app = app;

        Auth();
    }

    private static void Auth() {
        const string TAG = "Authentication";

        _ = app.MapPost("/auth/register", (UserRegistrationRequest request) => {
        })
            .Produces<UserAddResponse>(StatusCodes.Status201Created)
            .WithTags(TAG)
            .WithSummary("Register a user")
            .WithDescription("""
                    Register a user by required email and password and unnecessary nickname and other personal information. 
                    Returns jwt token in body and refresh in 'X-Refresh' http-only cookie.
                    """)
            .WithOpenApi();

        _ = app.MapPost("/auth/login", (UserLoginRequest request) => {
        })
            .Produces<UserLoginResponse>(StatusCodes.Status200OK)
            .WithTags(TAG);

        _ = app.MapPost("/auth/logout", [Authorize] () => {
        })
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status401Unauthorized)
            .WithTags(TAG)
            .WithOpenApi();

        //todo
        _ = app.MapPost("/auth/refresh", () => {
        })
            .WithTags(TAG)
            .Produces<RefsreshTokenResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status401Unauthorized);
    }

    private static void UserAuthorize() {
        const string TAG = "User";

        _ = app.MapGet("/account", [Authorize] () => {
        })
            .WithTags(TAG)
            .Produces<UserAccountResponse>(StatusCodes.Status200OK);

        _ = app.MapDelete("/account", [Authorize] () => {
        })
            .WithTags(TAG)
            .Produces(StatusCodes.Status204NoContent);

        _ = app.MapPatch("/account", [Authorize] () => {
        })
            .WithTags(TAG)
            .Produces(StatusCodes.Status200OK);
    }
}
