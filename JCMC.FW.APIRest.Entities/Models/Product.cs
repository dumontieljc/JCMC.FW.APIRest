namespace JCMC.FW.APIRest.Entities.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Exitence { get; set; }
        public double Price { get; set; }
    }
}
