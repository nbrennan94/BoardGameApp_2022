namespace API_with_EF.Models
{
    public class Fish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Classification { get; set; }
        public bool FreshWater { get; set; }
        public bool SaltWalter { get; set; }
    }
}
