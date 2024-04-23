using ServerApp.Api.DataTransferObjects.Requests;
using ServerApp.Api.DataTransferObjects.Responses;

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

        _ = app.MapPost("/bebra", () => {

        })
            .WithTags(TAG);
    }
}

