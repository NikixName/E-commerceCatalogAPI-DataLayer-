namespace E_commerceCatalogAPI_Data_Layer_.Entities
{
    public class Reviews
    {
        public string Text { get; set; } = string.Empty;
        public string ProductID { get; set; }
        public Products ProductReview {  get; set; }
        public DateOnly Date {  get; set; }
    }
}
