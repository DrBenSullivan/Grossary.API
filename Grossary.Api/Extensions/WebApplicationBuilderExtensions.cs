using Grossary.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Grossary.Api.Extensions
{
	internal static class WebApplicationBuilderExtensions
	{
		internal static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
		{
			builder.Services.AddControllers();
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
			builder.Services.AddDbContext<GrossaryDbContext>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
			});
			return builder;
		}
	}
}
