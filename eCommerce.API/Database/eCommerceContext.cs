using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database
{
    public class eCommerceContext : DbContext
    {
       eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options) { }
    }
}
