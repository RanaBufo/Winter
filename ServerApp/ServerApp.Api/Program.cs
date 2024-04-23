using ServerApp.Api.Routing;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
    options.SupportNonNullableReferenceTypes();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //   _ = app.UseHsts();
    _ = app.UseSwagger();
    _ = app.UseSwaggerUI();
}

// app.UseHttpsRedirection;
app.UseStaticFiles();
app.UseRouting();

Routes.SetRoutes(app);

app.Run();
