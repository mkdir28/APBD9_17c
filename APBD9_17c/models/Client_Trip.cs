namespace APBD9_17c.models;

public class Client_Trip
{
    public int IdClient { get; set; }
    public int Client_Trip_pk { get; set; }
    public int IdTrip { get; set; }
    public int RegisteredAt { get; set; }
    public int? PaymentDate { get; set; }
}