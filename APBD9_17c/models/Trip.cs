namespace APBD9_17c.models;

public class Trip
{
    public int IdTrip { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateForm { get; set; }
    public DateTime DateTo { get; set; }
    public int MaxPeople { get; set; }
}