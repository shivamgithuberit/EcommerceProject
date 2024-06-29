namespace EcommerceProject.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Adress1 { get; set; }

        public string? Adress2 { get; set; }

        public string? EmailAdress { get; set; }

        public string? PostalCode { get; set; }

        public DateTime? EnteredDate {  get; set; }

         public virtual ICollection<Order> Orders { get; set; } =new HashSet<Order>();

        public virtual ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();


    }

}