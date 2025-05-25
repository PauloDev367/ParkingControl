using ParkingControl.Domain.Enums;

namespace ParkingControl.Domain.Entities;

public class ParkingRecord
{
    public Guid Id { get; set; }
    public string Plate { get; set; }
    public DateTime EntryTime { get; set; }
    public DateTime? ExitTime { get; set; }
    public decimal TotalValue { get; set; }
    public ParkingStatus Status { get; set; }
}