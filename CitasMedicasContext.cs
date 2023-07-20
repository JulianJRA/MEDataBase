using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class CitasMedicasContext : DbContext
    {
        public CitasMedicasContext(DbContextOptions<CitasMedicasContext> options) : base(options) 
        { 
                
        }
    }
}