namespace CRMAppAPI.Models
{
    public class SecondaryBusinessField
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PrimaryBusinessField PrimaryBusinessField { get; set; }
    }
}