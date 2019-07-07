using System;
using System.Collections.Generic;

namespace SignalRChat.Models
{
    public partial class Users
    {
        public Users()
        {
            AntiFraudLog = new HashSet<AntiFraudLog>();
            AppLogs = new HashSet<AppLogs>();
            BlackListCustomer = new HashSet<BlackList>();
            BlackListSupplier = new HashSet<BlackList>();
            BlockIdNumber = new HashSet<BlockIdNumber>();
            BlockIp = new HashSet<BlockIp>();
            BlockedUserNum = new HashSet<BlockedUserNum>();
            CardCam = new HashSet<CardCam>();
            CcDetails = new HashSet<CcDetails>();
            Ccdata = new HashSet<Ccdata>();
            ChatTimeUseCustomer = new HashSet<ChatTimeUse>();
            ChatTimeUseSupplier = new HashSet<ChatTimeUse>();
            LogCcFaild = new HashSet<LogCcFaild>();
            LogChatTimeUseCustomer = new HashSet<LogChatTimeUse>();
            LogChatTimeUseSupplier = new HashSet<LogChatTimeUse>();
            LogLastVisit = new HashSet<LogLastVisit>();
            NotsAboutCustomers = new HashSet<NotsAboutCustomers>();
            OnlineUsersCustomer = new HashSet<OnlineUsers>();
            RoomConversationSendUser = new HashSet<RoomConversation>();
            RoomConversationSupplier = new HashSet<RoomConversation>();
            SendUsersWriteAboutGetUsersSendUser = new HashSet<SendUsersWriteAboutGetUsers>();
            SendUsersWriteAboutGetUsersSupplier = new HashSet<SendUsersWriteAboutGetUsers>();
            SupplierToServicePrice = new HashSet<SupplierToServicePrice>();
            SupportNew = new HashSet<SupportNew>();
            UserComputerCustomer = new HashSet<UserComputer>();
            UserComputerGetUser = new HashSet<UserComputer>();
            UsersLoggedIn = new HashSet<UsersLoggedIn>();
            UsersPhotos = new HashSet<UsersPhotos>();
            UsersProperties = new HashSet<UsersProperties>();
            UsersReviewCustomer = new HashSet<UsersReview>();
            UsersReviewSupplier = new HashSet<UsersReview>();
            UsersScoreCustomer = new HashSet<UsersScore>();
            UsersScoreSupplier = new HashSet<UsersScore>();
            UsersToUsersCustomer = new HashSet<UsersToUsers>();
            UsersToUsersServicesPayments = new HashSet<UsersToUsersServicesPayments>();
            UsersToUsersSupplier = new HashSet<UsersToUsers>();
            WindowsServiceLogsCustomer = new HashSet<WindowsServiceLogs>();
            WindowsServiceLogsSupplier = new HashSet<WindowsServiceLogs>();
        }

        public string Name { get; set; }
        public DateTime DateIn { get; set; }
        public string Password { get; set; }
        public int Active { get; set; }
        public int Id { get; set; }
        public string IdPhoto { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Pic1 { get; set; }
        public string AdminDetails { get; set; }
        public string ExtraDetails { get; set; }
        public int? YearBirth { get; set; }
        public int Gender { get; set; }
        public int? Referrer { get; set; }
        public double? UsersScore { get; set; }
        public DateTime? LastLogin { get; set; }
        public byte? DemoPerformer { get; set; }
        public int? StudioId { get; set; }
        public string IpAddress { get; set; }
        public string CommunicationDetails { get; set; }
        public byte? AdminApprovedCard { get; set; }
        public byte SmsActivation { get; set; }
        public int SmsCode { get; set; }
        public string CountryCode { get; set; }
        public Guid MainModelGuid { get; set; }
        public string Ftoken { get; set; }
        public string RealName { get; set; }
        public string PaymentsInformation { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string City { get; set; }
        public byte IsSupplier { get; set; }
        public string GenerateNumber { get; set; }
        public byte NeedUpdate { get; set; }
        public Guid UserChatGuid { get; set; }
        public byte IsPublicUser { get; set; }
        public int CustomerCurrencyId { get; set; }
        public byte SubscriptionIsActive { get; set; }
        public byte SubscriptionType { get; set; }
        public int? SupplierToServicePriceId { get; set; }

        public virtual SupplierToServicePrice SupplierToServicePriceNavigation { get; set; }
        public virtual OnlineUsers OnlineUsersSupplier { get; set; }
        public virtual ICollection<AntiFraudLog> AntiFraudLog { get; set; }
        public virtual ICollection<AppLogs> AppLogs { get; set; }
        public virtual ICollection<BlackList> BlackListCustomer { get; set; }
        public virtual ICollection<BlackList> BlackListSupplier { get; set; }
        public virtual ICollection<BlockIdNumber> BlockIdNumber { get; set; }
        public virtual ICollection<BlockIp> BlockIp { get; set; }
        public virtual ICollection<BlockedUserNum> BlockedUserNum { get; set; }
        public virtual ICollection<CardCam> CardCam { get; set; }
        public virtual ICollection<CcDetails> CcDetails { get; set; }
        public virtual ICollection<Ccdata> Ccdata { get; set; }
        public virtual ICollection<ChatTimeUse> ChatTimeUseCustomer { get; set; }
        public virtual ICollection<ChatTimeUse> ChatTimeUseSupplier { get; set; }
        public virtual ICollection<LogCcFaild> LogCcFaild { get; set; }
        public virtual ICollection<LogChatTimeUse> LogChatTimeUseCustomer { get; set; }
        public virtual ICollection<LogChatTimeUse> LogChatTimeUseSupplier { get; set; }
        public virtual ICollection<LogLastVisit> LogLastVisit { get; set; }
        public virtual ICollection<NotsAboutCustomers> NotsAboutCustomers { get; set; }
        public virtual ICollection<OnlineUsers> OnlineUsersCustomer { get; set; }
        public virtual ICollection<RoomConversation> RoomConversationSendUser { get; set; }
        public virtual ICollection<RoomConversation> RoomConversationSupplier { get; set; }
        public virtual ICollection<SendUsersWriteAboutGetUsers> SendUsersWriteAboutGetUsersSendUser { get; set; }
        public virtual ICollection<SendUsersWriteAboutGetUsers> SendUsersWriteAboutGetUsersSupplier { get; set; }
        public virtual ICollection<SupplierToServicePrice> SupplierToServicePrice { get; set; }
        public virtual ICollection<SupportNew> SupportNew { get; set; }
        public virtual ICollection<UserComputer> UserComputerCustomer { get; set; }
        public virtual ICollection<UserComputer> UserComputerGetUser { get; set; }
        public virtual ICollection<UsersLoggedIn> UsersLoggedIn { get; set; }
        public virtual ICollection<UsersPhotos> UsersPhotos { get; set; }
        public virtual ICollection<UsersProperties> UsersProperties { get; set; }
        public virtual ICollection<UsersReview> UsersReviewCustomer { get; set; }
        public virtual ICollection<UsersReview> UsersReviewSupplier { get; set; }
        public virtual ICollection<UsersScore> UsersScoreCustomer { get; set; }
        public virtual ICollection<UsersScore> UsersScoreSupplier { get; set; }
        public virtual ICollection<UsersToUsers> UsersToUsersCustomer { get; set; }
        public virtual ICollection<UsersToUsersServicesPayments> UsersToUsersServicesPayments { get; set; }
        public virtual ICollection<UsersToUsers> UsersToUsersSupplier { get; set; }
        public virtual ICollection<WindowsServiceLogs> WindowsServiceLogsCustomer { get; set; }
        public virtual ICollection<WindowsServiceLogs> WindowsServiceLogsSupplier { get; set; }
    }
}
