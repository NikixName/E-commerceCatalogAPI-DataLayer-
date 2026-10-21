namespace E_commerceCatalogAPI_Data_Layer_.Entities
{
    public class Products
    {
        public string ID {  get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string CategoryID {  get; set; }
        public Categories ProductCategory { get; set; }
    }
}
