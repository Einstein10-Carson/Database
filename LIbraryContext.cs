using Microsoft.EntityFrameworkCore;
using System;
namespace mysqlefcore
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options): base(options)
        {
            
        }
        public LibraryContext()
        {
            
        }
        public DbSet<EmpTB> Emptb { get; set;}
        public DbSet<PatientTB> patienttb { get; set;}
        public DbSet<RoomTB> roomtb { get; set;}
        public DbSet<ServiceTB> servicetb { get; set;}
        public DbSet<ServiceTokenStandHistoryTB> servicetokenstandhistorytb { get; set;}
        public DbSet<ServiceTokenTB> servicetokentb { get; set;}
        public DbSet<StatusTB> statustb { get; set;}
    }

    }