using System;

namespace Business.DatabaseModels
{
    public class DbSeed : DbModel
    {
        public DbSeed()
        {

        }

        public int Id { get; set; } = 0;
        public int UserId { get; set; } = 0;
        public string Manufacturer { get; set; } = string.Empty;
        public DateTime PurchaseDate { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Variety { get; set; } = string.Empty;
        public int MinSproutInDays { get; set; } = 0;
        public int MaxSproutInDays { get; set; } = 0;
        public int MinTemperature { get; set; } = 0;
        public int MaxTemperature { get; set; } = 0;
        public string SeedDepth { get; set; } = string.Empty;
        public string PlantSpacing { get; set; } = string.Empty;
        public bool FrostHardy { get; set; } = false;
        public int MinSun { get; set; } = 0;
        public int MaxSun { get; set; } = 0;
        public byte[] ByteImage { get; set; }
    }
}
