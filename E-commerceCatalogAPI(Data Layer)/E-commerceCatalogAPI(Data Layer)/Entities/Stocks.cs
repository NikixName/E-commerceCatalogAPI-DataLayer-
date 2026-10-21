namespace E_commerceCatalogAPI_Data_Layer_.Entities
{
    public class Stocks
    {
        public string Name {  get; set; }
        public int Nums {  get; set; }
        public string CategoryID {  get; set; }
        public Categories StockCategory {  get; set; }
    }
}
