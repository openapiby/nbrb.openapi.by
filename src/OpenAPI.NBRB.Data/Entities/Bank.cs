namespace OpenAPI.NBRB.Data.Entities
{
    public class Bank
    {
        public string BIC { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
