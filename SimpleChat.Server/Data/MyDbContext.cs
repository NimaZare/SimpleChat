using Microsoft.EntityFrameworkCore;

namespace SimpleChat.Server.Data;

public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
{
	public DbSet<Model.MessageModel> Messages { get; set; } = default!;
}
