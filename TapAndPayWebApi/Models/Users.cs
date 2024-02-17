namespace TapAndPayWebApi.Models;

public class User
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string RFID_UID { get; set; }
    public double Balance { get; set; }
}