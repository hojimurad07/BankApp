using BankApp.Enums;

namespace BankApp.Models
{
    public  class BankCard
    {
        public int Id { get; set; }
        public string OwnerName {  get; set; } =string.Empty;
        public string CardNumber {  get; set; } = string.Empty;
        public string Datetime { get; set; } = string.Empty;
        public int Money { get; set; } = 0;
        public CardType Type { get; set; } = CardType.Unknown;
        public int OwnerId {  get; set; }
        public User Owner { get; set; }   = new User();
    }

    
}
