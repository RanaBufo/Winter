namespace Hikari.Routing;

internal static class Routes {
    private static WebApplication app = null!;

    public static void SetRoutes(WebApplication app) {
        Routes.app = app;

        Test();
    }

    private static void Test() {
        _ = app.MapGet("/test/ping", () => "pong");
    }
}

