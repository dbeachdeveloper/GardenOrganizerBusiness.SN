
namespace Business.DatabaseModels
{
    public class DbVariety : DbModel
    {
        public int Id { get; set; } = 0;
        public int VegetableTypeId { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
    }
}
