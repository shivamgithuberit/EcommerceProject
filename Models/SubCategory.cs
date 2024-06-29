namespace EcommerceProject.Models
{
    public class SubCategory
    {
        public int Id { get; set; }

        public string? SubCategoryName { get; set; }

        public virtual Category?   Catogery { get; set; }
    }
}
