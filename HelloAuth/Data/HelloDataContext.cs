namespace HelloAuth.Data;

public class HelloDataContext: IdentityDbContext<IdentityUser>
{
    public HelloDataContext(DbContextOptions<HelloDataContext> options)
        : base(options)
    {
        
    }
}
