using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class CcDetails
    {
        public CcDetails()
        {
            CardCam = new HashSet<CardCam>();
        }

        public string CardNumber { get; set; }
        public string IdNumber { get; set; }
        public string YearDate { get; set; }
        public string MonthDate { get; set; }
        public string Cvv { get; set; }
        public int UserId { get; set; }
        public int Id { get; set; }
        public string LastDigits { get; set; }
        public DateTime? DateIn { get; set; }
        public int? Active { get; set; }
        public string CardToken { get; set; }
        public string TransactionProcessor { get; set; }
        public string EnglishName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EncryptCard { get; set; }
        public string Email { get; set; }
        public int? CheapOfferUsed { get; set; }
        public string AdminData { get; set; }
        public byte IsPreAutorize { get; set; }
        public string EncryptIdnumber { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<CardCam> CardCam { get; set; }
    }
}
