using Microsoft.EntityFrameworkCore;

namespace LAb5.Models
{
    public class EmergencyContext : DbContext
    {
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Lab> Labs { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public EmergencyContext(DbContextOptions<EmergencyContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
