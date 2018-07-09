namespace BlockchainIn15Minutes.Models
{
    public class Transaction
    {
        public string AddressTo { get; set; }
        public string AddressFrom { get; set; }
        public decimal Amount { get; set; }
    }
}