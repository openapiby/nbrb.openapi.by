namespace OpenAPI.NBRB.Domain.Contracts.ViewModels
{
    public class BankViewModel
    {
        public string BIC { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
