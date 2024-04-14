using WebApplication1.Models;

public class Appointment
{
    public int id { get; set; }

    public double data { get; set; }
    public Zwierze zwierze { get; set; }
    public string opis { get; set; }
    public int ocena { get; set; }
    
    
}