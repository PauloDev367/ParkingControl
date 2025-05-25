using Microsoft.EntityFrameworkCore;
using ParkingControl.Domain.Entities;
using ParkingControl.Domain.Enums;

namespace ParkingControl.Infrastructure.Persistence;

public class ParkingDbContext : DbContext
{
    public ParkingRecord ParkingRecords{ get; set; }
    
    public ParkingDbContext(DbContextOptions<ParkingDbContext> options) : base(options)
    {
    }
}