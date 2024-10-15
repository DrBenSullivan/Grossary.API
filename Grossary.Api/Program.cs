using Grossary.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureServices();

var app = builder.Build();

await app.ConfigureDatabase();

app.ConfigureSwagger();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapGet("/", context =>
{
	context.Response.Redirect("/swagger/index.html");
	return Task.CompletedTask;
});

app.MapControllers();

app.Run();
