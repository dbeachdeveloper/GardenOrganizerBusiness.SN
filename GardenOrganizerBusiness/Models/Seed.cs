using System;
using System.ComponentModel.DataAnnotations;

namespace Business.Models
{
    public class Seed
    {
        public int Id { get; set; } = 0;
        public int UserId { get; set; } = 0;
        [Required]
        public string Manufacturer { get; set; } = string.Empty;
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        [Required]
        public string Type { get; set; } = string.Empty;
        [Required]
        public string Variety { get; set; } = string.Empty;
        public int MinSproutInDays { get; set; } = 0;
        public int MaxSproutInDays { get; set; } = 1;
        public int MinTemperature { get; set; } = 0;
        public int MaxTemperature { get; set; } = 1;
        public string SeedDepth { get; set; } = "1 inch";
        public string PlantSpacing { get; set; } = "12 inches";
        public bool FrostHardy { get; set; } = false;
        public int MinSun { get; set; } = 0;
        public int MaxSun { get; set; } = 1;
        public byte[] ByteImage { get; set; }
        public string ImageUrl
        {
            get
            {
                //string format = "image/png";
                //return $"data:{format};base64,{Convert.ToBase64String(ByteImage)}";
                return string.Empty;
            }
        }
        public string SproutDays
        {
            get
            {
                return $"{MinSproutInDays} - {MinSproutInDays}";
            }
        }
        public string Temperatures
        {
            get
            {
                return $"{MinTemperature} - {MaxTemperature}";
            }
        }
        public string SunLight
        {
            get
            {
                return $"{MinSun} - {MaxSun}";
            }
        }
        public string Frost
        {
            get
            {
                if(FrostHardy)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public string Purchase
        {
            get
            {
                return PurchaseDate.ToString("dddd, dd MMMM yyyy");
            }
        }
    }
}
