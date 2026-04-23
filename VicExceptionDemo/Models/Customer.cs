namespace VicExceptionDemo.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Tier { get; set; } = "";
        public decimal CreditLimit { get; set; }
    }
}
