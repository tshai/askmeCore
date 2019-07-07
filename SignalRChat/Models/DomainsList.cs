using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class DomainsList
    {
        public int Id { get; set; }
        public string DomainName { get; set; }
        public int DomainTypeId { get; set; }
        public string LogoName { get; set; }
        public string FacebookAppId { get; set; }
        public string FacebookSecret { get; set; }
        public string FacebookButton { get; set; }
        public int CategoryLevel { get; set; }
        public int MainCountryId { get; set; }
        public string Direction { get; set; }
        public string TextAlign { get; set; }
        public string FriendlyName { get; set; }
        public int CustomSearch { get; set; }
        public string Phone { get; set; }
        public string LiveChat { get; set; }
        public byte IsActive { get; set; }
        public byte CustomerDepositePercents { get; set; }
        public string ImageSize { get; set; }
        public int ShowNewsletter { get; set; }
        public int LanguageId { get; set; }
        public double Revenu { get; set; }
        public byte FreeDelivery { get; set; }
        public byte ShowSaleButton { get; set; }
        public byte ShowCountrySelection { get; set; }
        public byte Shop { get; set; }
        public byte SignIn { get; set; }
        public byte ShowPriceMainPage { get; set; }
        public byte ShowSearchBox { get; set; }
        public string MetaDescription { get; set; }
        public string SmssenderId { get; set; }
        public int? DnxCustomerId { get; set; }
        public int TemplateId { get; set; }
        public string Googletagmanager { get; set; }

        public virtual CountryList MainCountry { get; set; }
    }
}
