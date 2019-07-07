using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class CardCam
    {
        public DateTime OrderDay { get; set; }
        public double PriceInDollar { get; set; }
        public int Id { get; set; }
        public int DomainId { get; set; }
        public string IpAddress { get; set; }
        public string Lastdigits { get; set; }
        public int UserId { get; set; }
        public byte UserAskToDelete { get; set; }
        public double? AffiliateCut { get; set; }
        public double? NetPrice { get; set; }
        public int? ReferrerId { get; set; }
        public string TransactionProcessor { get; set; }
        public string OrderId { get; set; }
        public int? CountryId { get; set; }
        public int? CccountryId { get; set; }
        public string InatecTransactionId { get; set; }
        public string InatecTransactionStatus { get; set; }
        public int CcDetailsId { get; set; }
        public byte? PaymentStatus { get; set; }
        public int CustomerCurrencyId { get; set; }
        public Guid CardCamGuid { get; set; }
        public double? CustomerMultipleFromDollar { get; set; }

        public virtual CcDetails CcDetails { get; set; }
        public virtual Users User { get; set; }
    }
}
