﻿namespace BankApp.Models
{
    public  class User
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;    
        public int Age {  get; set; }
        public string Email { get; set; } =string.Empty;
        public string Phone {  get; set; } =  string.Empty ;
        
        public List<BankCard> BankCards { get; set; } = new List<BankCard>();
    }
}
