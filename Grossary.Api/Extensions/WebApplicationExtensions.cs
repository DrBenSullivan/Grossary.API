using Grossary.Infrastructure.Extensions;
using Grossary.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Grossary.Api.Extensions
{
	internal static class WebApplicationExtensions
	{
		internal static async Task<WebApplication> ConfigureDatabase(this WebApplication app) 
		{
			using var scope = app.Services.CreateScope();
			var db = scope.ServiceProvider.GetRequiredService<GrossaryDbContext>();
			db.Database.Migrate();
			await db.SeedAsync();
			return app;
		}

		internal static WebApplication ConfigureSwagger(this WebApplication app)
		{
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI(c =>
				{
					c.SwaggerEndpoint("/swagger/v1/swagger.json", "Grossary API V1");
					c.RoutePrefix = string.Empty;
				});
			}
			return app;
		}
	}
}
