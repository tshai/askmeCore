using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SignalRChat.Models
{
    public partial class AskMeContext : DbContext
    {
        public AskMeContext()
        {
        }

        public AskMeContext(DbContextOptions<AskMeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminPages> AdminPages { get; set; }
        public virtual DbSet<AdminToUsersNews> AdminToUsersNews { get; set; }
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<AdminsLogins> AdminsLogins { get; set; }
        public virtual DbSet<AntiFraudLog> AntiFraudLog { get; set; }
        public virtual DbSet<AppLogs> AppLogs { get; set; }
        public virtual DbSet<BlackList> BlackList { get; set; }
        public virtual DbSet<BlockIdNumber> BlockIdNumber { get; set; }
        public virtual DbSet<BlockIp> BlockIp { get; set; }
        public virtual DbSet<BlockedUserNum> BlockedUserNum { get; set; }
        public virtual DbSet<CardCam> CardCam { get; set; }
        public virtual DbSet<CcDetails> CcDetails { get; set; }
        public virtual DbSet<Ccdata> Ccdata { get; set; }
        public virtual DbSet<ChatTimeUse> ChatTimeUse { get; set; }
        public virtual DbSet<CountryList> CountryList { get; set; }
        public virtual DbSet<Currencies> Currencies { get; set; }
        public virtual DbSet<DomainsList> DomainsList { get; set; }
        public virtual DbSet<EmployeeManageLevels> EmployeeManageLevels { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<LogCcFaild> LogCcFaild { get; set; }
        public virtual DbSet<LogChatTimeUse> LogChatTimeUse { get; set; }
        public virtual DbSet<LogLastVisit> LogLastVisit { get; set; }
        public virtual DbSet<LogRtc> LogRtc { get; set; }
        public virtual DbSet<NotsAboutCustomers> NotsAboutCustomers { get; set; }
        public virtual DbSet<OnlineUsers> OnlineUsers { get; set; }
        public virtual DbSet<PaymentStatus> PaymentStatus { get; set; }
        public virtual DbSet<PrepaidBin> PrepaidBin { get; set; }
        public virtual DbSet<Prices> Prices { get; set; }
        public virtual DbSet<RoomConversation> RoomConversation { get; set; }
        public virtual DbSet<SendUsersWriteAboutGetUsers> SendUsersWriteAboutGetUsers { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<SiteMessages> SiteMessages { get; set; }
        public virtual DbSet<SiteMessagesToLanguages> SiteMessagesToLanguages { get; set; }
        public virtual DbSet<Smslogs> Smslogs { get; set; }
        public virtual DbSet<Studios> Studios { get; set; }
        public virtual DbSet<StudiosToGirls> StudiosToGirls { get; set; }
        public virtual DbSet<SupplierToServicePrice> SupplierToServicePrice { get; set; }
        public virtual DbSet<SupportChat> SupportChat { get; set; }
        public virtual DbSet<SupportCorrespondence> SupportCorrespondence { get; set; }
        public virtual DbSet<SupportImages> SupportImages { get; set; }
        public virtual DbSet<SupportNew> SupportNew { get; set; }
        public virtual DbSet<TicketViewDates> TicketViewDates { get; set; }
        public virtual DbSet<UserChangeStatus> UserChangeStatus { get; set; }
        public virtual DbSet<UserComputer> UserComputer { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersLoggedIn> UsersLoggedIn { get; set; }
        public virtual DbSet<UsersPhotos> UsersPhotos { get; set; }
        public virtual DbSet<UsersProperties> UsersProperties { get; set; }
        public virtual DbSet<UsersReview> UsersReview { get; set; }
        public virtual DbSet<UsersScore> UsersScore { get; set; }
        public virtual DbSet<UsersToUsers> UsersToUsers { get; set; }
        public virtual DbSet<UsersToUsersMessages> UsersToUsersMessages { get; set; }
        public virtual DbSet<UsersToUsersServicesPayments> UsersToUsersServicesPayments { get; set; }
        public virtual DbSet<Versions> Versions { get; set; }
        public virtual DbSet<WindowsServiceLogs> WindowsServiceLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(local);Database=AskMe;user id=askMe587z;password=askr8521");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<AdminPages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PageName).IsUnicode(false);
            });

            modelBuilder.Entity<AdminToUsersNews>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackColor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('black')");

                entity.Property(e => e.DateIn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FontSize)
                    .HasColumnName("Font-size")
                    .HasDefaultValueSql("((14))");

                entity.Property(e => e.ForeColor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('white')");

                entity.Property(e => e.FreeText).IsRequired();
            });

            modelBuilder.Entity<Admins>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Passowrd)
                    .HasMaxLength(88)
                    .IsUnicode(false);

                entity.Property(e => e.Permissions).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AdminsLogins>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.AdminsLogins)
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_adminsLogins_admins");
            });

            modelBuilder.Entity<AntiFraudLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CcDetailsId)
                    .HasColumnName("CcDetailsID")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.Cccountry)
                    .HasColumnName("CCCountry")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ccnumber)
                    .HasColumnName("CCNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cvv)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ExpYear)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastDigits)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Priority).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AntiFraudLog)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AntiFraudLog_Users");
            });

            modelBuilder.Entity<AppLogs>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogMessage)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.UserrId).HasColumnName("UserrID");

                entity.HasOne(d => d.Userr)
                    .WithMany(p => p.AppLogs)
                    .HasForeignKey(d => d.UserrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppLogs_MainModels");
            });

            modelBuilder.Entity<BlackList>(entity =>
            {
                entity.HasIndex(e => new { e.SupplierId, e.CustomerId })
                    .HasName("user_girl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.BlackListCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlackList_Users");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.BlackListSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BlackList_Users1");
            });

            modelBuilder.Entity<BlockIdNumber>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataInsertAdminId)
                    .HasColumnName("DataInsertAdminID")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdNumber).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonExplain).IsUnicode(false);

                entity.HasOne(d => d.UserNumNavigation)
                    .WithMany(p => p.BlockIdNumber)
                    .HasForeignKey(d => d.UserNum)
                    .HasConstraintName("FK_BlockIdNumber_Users");
            });

            modelBuilder.Entity<BlockIp>(entity =>
            {
                entity.HasIndex(e => e.IpAddress)
                    .HasName("IpAddress");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BlockStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.CcNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DataInsertAdminId).HasColumnName("DataInsertAdminID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DaysToBlock).HasDefaultValueSql("((1))");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IdNumber).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasesStatus).HasDefaultValueSql("((5))");

                entity.Property(e => e.ReasonExplain)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RemoveFromBlockReason)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BlockIp)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_BlockIp_Users");
            });

            modelBuilder.Entity<BlockedUserNum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataInsertAdminId).HasColumnName("DataInsertAdminID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdNumber).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonExplain).IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((5))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BlockedUserNum)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_BlockedUserNum_Users");
            });

            modelBuilder.Entity<CardCam>(entity =>
            {
                entity.HasIndex(e => e.IpAddress)
                    .HasName("IpAddress");

                entity.HasIndex(e => e.UserId)
                    .HasName("_dta_index_CardCam_23_1048390804__K10");

                entity.HasIndex(e => new { e.UserId, e.Id })
                    .HasName("_dta_index_CardCam_23_1048390804__K10_K3_6");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AffiliateCut).HasDefaultValueSql("((1))");

                entity.Property(e => e.CardCamGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CcDetailsId)
                    .HasColumnName("CcDetailsID")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.CccountryId).HasColumnName("CCCountryID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CustomerCurrencyId).HasColumnName("CustomerCurrencyID");

                entity.Property(e => e.DomainId)
                    .HasColumnName("DomainID")
                    .HasDefaultValueSql("((28))");

                entity.Property(e => e.InatecTransactionId)
                    .IsRequired()
                    .HasColumnName("InatecTransactionID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InatecTransactionStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('none')");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastdigits)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1111))");

                entity.Property(e => e.OrderDay)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferrerId)
                    .HasColumnName("ReferrerID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionProcessor)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('none')");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.CcDetails)
                    .WithMany(p => p.CardCam)
                    .HasForeignKey(d => d.CcDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CardCam_CcDetails");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CardCam)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CardCam_Users");
            });

            modelBuilder.Entity<CcDetails>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("UserNum");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AdminData)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CardToken)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheapOfferUsed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cvv)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateIn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('none')");

                entity.Property(e => e.EncryptCard)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EncryptIdnumber)
                    .HasColumnName("EncryptIDNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EnglishName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.IdNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastDigits)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MonthDate)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionProcessor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.YearDate)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CcDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CcDetails_Users");
            });

            modelBuilder.Entity<Ccdata>(entity =>
            {
                entity.HasKey(e => e.Ccnumber)
                    .HasName("PK_CCData_1");

                entity.ToTable("CCData");

                entity.HasIndex(e => new { e.Ccnumber, e.UserId })
                    .HasName("UserNumAndCCNumber");

                entity.Property(e => e.Ccnumber)
                    .HasColumnName("CCNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DataInsertAdminId)
                    .HasColumnName("DataInsertAdminID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EncryptCard)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IdNumber).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.SuspiciousAmount).HasDefaultValueSql("((400))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Ccdata)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_CCData_Users");
            });

            modelBuilder.Entity<ChatTimeUse>(entity =>
            {
                entity.HasIndex(e => e.CustomerId)
                    .HasName("_dta_index_ChatTimeUse_23_1464392286__K7");

                entity.HasIndex(e => e.DateIn)
                    .HasName("DateIn");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("GirlNum");

                entity.HasIndex(e => e.UserAskToDelete)
                    .HasName("UserAskToDelete");

                entity.HasIndex(e => new { e.DateIn, e.SupplierId })
                    .HasName("admin1");

                entity.HasIndex(e => new { e.TimeUse, e.CustomerId, e.Id })
                    .HasName("_dta_index_ChatTimeUse_23_1464392286__K7_K2_1");

                entity.HasIndex(e => new { e.Id, e.DateIn, e.SupplierId, e.SessionStatus })
                    .HasName("GirlNum-SessionStatus");

                entity.HasIndex(e => new { e.CustomerId, e.SupplierId, e.RndNum, e.SessionStatus, e.Id })
                    .HasName("_dta_index_ChatTimeUse_23_300580159__K7_K5_K6_K9_K2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnswerDateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ChatTimeUseGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dateout)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DomainId)
                    .HasColumnName("DomainID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EndError)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('no')");

                entity.Property(e => e.RndNum).HasDefaultValueSql("(newid())");

                entity.Property(e => e.SupplierDiscount).HasDefaultValueSql("((0))");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.VersionId)
                    .HasColumnName("VersionID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ChatTimeUseCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChatTimeUse_Users1");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ChatTimeUseSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChatTimeUse_Users");
            });

            modelBuilder.Entity<CountryList>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName).IsRequired();

                entity.Property(e => e.CultureInfo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DefaultCountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InphonePrefix)
                    .HasColumnName("INphonePrefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.Lc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteMessageId).HasColumnName("SiteMessageID");

                entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.CountryList)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryList_Currencies");
            });

            modelBuilder.Entity<Currencies>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencySide)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<DomainsList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Direction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DnxCustomerId).HasColumnName("DnxCustomerID");

                entity.Property(e => e.DomainName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DomainTypeId).HasColumnName("DomainTypeID");

                entity.Property(e => e.FacebookAppId)
                    .HasColumnName("FacebookAppID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FacebookButton)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FacebookSecret)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FriendlyName).HasMaxLength(50);

                entity.Property(e => e.Googletagmanager)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageSize)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LiveChat)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LogoName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MainCountryId).HasColumnName("MainCountryID");

                entity.Property(e => e.MetaDescription).HasMaxLength(500);

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SmssenderId)
                    .IsRequired()
                    .HasColumnName("SMSSenderID")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.TextAlign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MainCountry)
                    .WithMany(p => p.DomainsList)
                    .HasForeignKey(d => d.MainCountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomainsList_CountryList");
            });

            modelBuilder.Entity<EmployeeManageLevels>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateIn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManageLevel).HasDefaultValueSql("((1))");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ManageLevelNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ManageLevel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_employees_EmployeeManageLevels");
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrentCulture)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalLanguage)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LogCcFaild>(entity =>
            {
                entity.HasKey(e => e.ColNum);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Cccountry)
                    .HasColumnName("CCCountry")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cvv)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DateIn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorNum).IsUnicode(false);

                entity.Property(e => e.IdNumber).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastDigits)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MonthDate)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransactionProcessor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.YearDate)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LogCcFaild)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_LogCcFaild_Users");
            });

            modelBuilder.Entity<LogChatTimeUse>(entity =>
            {
                entity.HasIndex(e => e.CustomerId)
                    .HasName("_dta_index_LogChatTimeUse_23_635865332__K7");

                entity.HasIndex(e => e.DateIn)
                    .HasName("DateIn");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("GirlNum");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateIn).HasColumnType("datetime");

                entity.Property(e => e.Dateout).HasColumnType("datetime");

                entity.Property(e => e.EndError).IsUnicode(false);

                entity.Property(e => e.FullCharge).HasDefaultValueSql("((0))");

                entity.Property(e => e.MultiplySum).HasColumnType("numeric(4, 2)");

                entity.Property(e => e.SessionStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UserAskToDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserConnectToGirlFms).HasColumnName("UserConnectToGirlFMS");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.LogChatTimeUseCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogChatTimeUse_Users1");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.LogChatTimeUseSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogChatTimeUse_Users");
            });

            modelBuilder.Entity<LogLastVisit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LogLastVisit)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogLastVisit_Users");
            });

            modelBuilder.Entity<LogRtc>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChatTimeUseId).HasColumnName("ChatTimeUseID");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .IsUnicode(false);

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NotsAboutCustomers>(entity =>
            {
                entity.HasIndex(e => e.CustomerId)
                    .HasName("customerID");

                entity.HasIndex(e => e.IdNumber)
                    .HasName("idNumber");

                entity.HasIndex(e => e.Phone)
                    .HasName("phone");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note).IsRequired();

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.NotsAboutCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotsAboutCustomers_Users");
            });

            modelBuilder.Entity<OnlineUsers>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("PK_NewModels");

                entity.HasIndex(e => e.IsQa)
                    .HasName("isQA");

                entity.HasIndex(e => e.Online)
                    .HasName("Online");

                entity.HasIndex(e => new { e.Online, e.IsQa })
                    .HasName("isQA-Online");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CustomerLastVisit)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsQa).HasColumnName("IsQA");

                entity.Property(e => e.LastCustomerId)
                    .HasColumnName("LastCustomerID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastStatusChange)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SupplierGettingCustomer).HasDefaultValueSql("((1))");

                entity.Property(e => e.SupplierLastVisit)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeTheChatStart)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.OnlineUsersCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OnlineUsers_Users1");

                entity.HasOne(d => d.Supplier)
                    .WithOne(p => p.OnlineUsersSupplier)
                    .HasForeignKey<OnlineUsers>(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OnlineUsers_Users");
            });

            modelBuilder.Entity<PaymentStatus>(entity =>
            {
                entity.HasKey(e => e.SaleId)
                    .HasName("PK_paymentStatus");

                entity.Property(e => e.SaleId)
                    .HasColumnName("SaleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateIn).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PriceAmount)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceId)
                    .HasColumnName("ReferenceID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TruncatedPan)
                    .HasColumnName("TruncatedPAN")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrepaidBin>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bin)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Prices>(entity =>
            {
                entity.Property(e => e.DiscountText).HasMaxLength(50);

                entity.Property(e => e.PriceEur).HasColumnName("PriceEUR");

                entity.Property(e => e.PriceIls).HasColumnName("PriceILS");

                entity.Property(e => e.TextHe).HasColumnName("TextHE");
            });

            modelBuilder.Entity<RoomConversation>(entity =>
            {
                entity.HasIndex(e => e.SendUserId)
                    .HasName("UserNum");

                entity.HasIndex(e => e.WhoSend)
                    .HasName("whoSend");

                entity.HasIndex(e => new { e.SendUserId, e.SupplierId })
                    .HasName("UserNum_GirlNum");

                entity.HasIndex(e => new { e.Id, e.SupplierId, e.WhoSend })
                    .HasName("mix1");

                entity.HasIndex(e => new { e.Id, e.SupplierId, e.Conversation, e.DateIn, e.WhoSend, e.GetUserRead, e.SendUserRead, e.SendUserId })
                    .HasName("newIndex");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Conversation)
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SendUserId).HasColumnName("SendUserID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.SendUser)
                    .WithMany(p => p.RoomConversationSendUser)
                    .HasForeignKey(d => d.SendUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoomConversation_Users1");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.RoomConversationSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoomConversation_Users");
            });

            modelBuilder.Entity<SendUsersWriteAboutGetUsers>(entity =>
            {
                entity.HasIndex(e => new { e.SupplierId, e.SendUserId })
                    .HasName("girl_anduser");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FreeText).HasMaxLength(400);

                entity.Property(e => e.IdNumber).HasColumnType("numeric(12, 0)");

                entity.Property(e => e.SendUserId).HasColumnName("SendUserID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.SendUser)
                    .WithMany(p => p.SendUsersWriteAboutGetUsersSendUser)
                    .HasForeignKey(d => d.SendUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SendUsersWriteAboutGetUsers_Users1");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SendUsersWriteAboutGetUsersSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SendUsersWriteAboutGetUsers_Users");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PaySumParam).HasColumnType("numeric(3, 2)");

                entity.Property(e => e.SaveLogForWebRtc).HasColumnName("saveLogForWebRTC");

                entity.Property(e => e.UserAppVersionId).HasColumnName("UserAppVersionID");

                entity.Property(e => e.WindowsServiceLastUpdate).HasColumnType("datetime");

                entity.HasOne(d => d.UserAppVersion)
                    .WithMany(p => p.Setting)
                    .HasForeignKey(d => d.UserAppVersionId)
                    .HasConstraintName("FK_Setting_Versions");
            });

            modelBuilder.Entity<SiteMessages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SiteMessagesToLanguages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.SiteMessageId).HasColumnName("SiteMessageID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.SiteMessagesToLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_SiteMessagesToLanguages_Languages");

                entity.HasOne(d => d.SiteMessage)
                    .WithMany(p => p.SiteMessagesToLanguages)
                    .HasForeignKey(d => d.SiteMessageId)
                    .HasConstraintName("FK_SiteMessagesToLanguages_SiteMessages");
            });

            modelBuilder.Entity<Smslogs>(entity =>
            {
                entity.ToTable("SMSLogs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Processor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Studios>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Iban)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PercentageToModels).HasDefaultValueSql("((85))");

                entity.Property(e => e.RealName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Swift)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudiosToGirls>(entity =>
            {
                entity.HasIndex(e => e.SupplierId)
                    .HasName("onlyOneGirlToStudioOrigin")
                    .IsUnique();

                entity.HasIndex(e => new { e.SupplierId, e.StudioNum })
                    .HasName("onlyOneGirlToStudio")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<SupplierToServicePrice>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SupplierToServicePriceGuid).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.SupplierToServicePrice)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierToMessagePrice_Currencies");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierToServicePrice)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierToMessagePrice_Users");
            });

            modelBuilder.Entity<SupportChat>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChatText)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StudioId).HasColumnName("StudioID");

                entity.HasOne(d => d.Studio)
                    .WithMany(p => p.SupportChat)
                    .HasForeignKey(d => d.StudioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupportChat_studios");
            });

            modelBuilder.Entity<SupportCorrespondence>(entity =>
            {
                entity.Property(e => e.Cmessage)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sguid)
                    .IsRequired()
                    .HasColumnName("SGuid")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Sms)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Support)
                    .WithMany(p => p.SupportCorrespondence)
                    .HasForeignKey(d => d.SupportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_supportCorrespondence_support");
            });

            modelBuilder.Entity<SupportImages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImgName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SupportCorrespondenceId).HasColumnName("SupportCorrespondenceID");
            });

            modelBuilder.Entity<SupportNew>(entity =>
            {
                entity.Property(e => e.Cmessage).HasMaxLength(2000);

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Department).HasDefaultValueSql("((1))");

                entity.Property(e => e.DomainsListId).HasColumnName("DomainsListID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IsReadSupport).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NewId).HasColumnName("NewID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sguid)
                    .IsRequired()
                    .HasColumnName("SGuid")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Topic).HasMaxLength(50);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SupportNew)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SupportNew_Users");
            });

            modelBuilder.Entity<TicketViewDates>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SupportNewId).HasColumnName("SupportNewID");

                entity.HasOne(d => d.SupportNew)
                    .WithMany(p => p.TicketViewDates)
                    .HasForeignKey(d => d.SupportNewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketViewDates_supportNew");
            });

            modelBuilder.Entity<UserChangeStatus>(entity =>
            {
                entity.HasKey(e => e.GirlChangeStatusId)
                    .HasName("PK_GirlChangeStatus");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Qtype).HasColumnName("QType");

                entity.Property(e => e.SpName).IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<UserComputer>(entity =>
            {
                entity.Property(e => e.Browser).IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Domain).IsUnicode(false);

                entity.Property(e => e.GetUserId).HasColumnName("GetUserID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Os)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupportCamera).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserAgent).IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.UserComputerCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_UserComputer_Users1");

                entity.HasOne(d => d.GetUser)
                    .WithMany(p => p.UserComputerGetUser)
                    .HasForeignKey(d => d.GetUserId)
                    .HasConstraintName("FK_UserComputer_Users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.Phone)
                    .HasName("phone")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CommunicationDetails).HasDefaultValueSql("(N'none')");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('none')");

                entity.Property(e => e.CustomerCurrencyId).HasColumnName("CustomerCurrencyID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DemoPerformer).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'none')");

                entity.Property(e => e.ExtraDetails).HasDefaultValueSql("(N'אין פרטים נוספים...')");

                entity.Property(e => e.Ftoken)
                    .HasColumnName("FToken")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('none')");

                entity.Property(e => e.GenerateNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdPhoto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('none')");

                entity.Property(e => e.IsSupplier).HasDefaultValueSql("((2))");

                entity.Property(e => e.LastLogin)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MainModelGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'name')");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PaymentsInformation).HasMaxLength(1000);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pic1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RealName).HasMaxLength(50);

                entity.Property(e => e.Referrer).HasDefaultValueSql("((0))");

                entity.Property(e => e.StudioId).HasDefaultValueSql("((1))");

                entity.Property(e => e.SupplierToServicePriceId).HasColumnName("SupplierToServicePriceID");

                entity.Property(e => e.UsersScore).HasDefaultValueSql("((8))");

                entity.Property(e => e.YearBirth).HasDefaultValueSql("((1980))");

                entity.HasOne(d => d.SupplierToServicePriceNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.SupplierToServicePriceId)
                    .HasConstraintName("FK_Users_SupplierToServicePrice");
            });

            modelBuilder.Entity<UsersLoggedIn>(entity =>
            {
                entity.HasIndex(e => e.IpAddress)
                    .HasName("IpAddress");

                entity.HasIndex(e => e.UserId)
                    .HasName("UserNum");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Password).HasMaxLength(20);

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Success).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersLoggedIn)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersLoggedIn_Users");
            });

            modelBuilder.Entity<UsersPhotos>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("GirlNum");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PhotoGuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersPhotos)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PerformersPhotos_Users");
            });

            modelBuilder.Entity<UsersProperties>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersProperties)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersProperties_Users");
            });

            modelBuilder.Entity<UsersReview>(entity =>
            {
                entity.HasIndex(e => e.SupplierId)
                    .HasName("GirlNum");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FreeText).IsRequired();

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.UsersReviewCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersReview_Users1");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.UsersReviewSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersReview_Users");
            });

            modelBuilder.Entity<UsersScore>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IpAddress).HasMaxLength(15);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.UsersScoreCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersScore_Users1");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.UsersScoreSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersScore_Users");
            });

            modelBuilder.Entity<UsersToUsers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.UsersToUsersCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersToUsers_MainModels1");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.UsersToUsersSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersToUsers_MainModels");
            });

            modelBuilder.Entity<UsersToUsersMessages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MessageGuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MessageText)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.VideoImage)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsersToUsersServicesPayments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChatTimeUseId).HasColumnName("ChatTimeUseID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.SupplierToServicePriceId).HasColumnName("SupplierToServicePriceID");

                entity.Property(e => e.UsersToUsersMessagesId).HasColumnName("UsersToUsersMessagesID");

                entity.HasOne(d => d.ChatTimeUse)
                    .WithMany(p => p.UsersToUsersServicesPayments)
                    .HasForeignKey(d => d.ChatTimeUseId)
                    .HasConstraintName("FK_UsersToUsersServicesPayments_ChatTimeUse");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.UsersToUsersServicesPayments)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_UsersToUsersServicesPayments_Users");

                entity.HasOne(d => d.UsersToUsersMessages)
                    .WithMany(p => p.UsersToUsersServicesPayments)
                    .HasForeignKey(d => d.UsersToUsersMessagesId)
                    .HasConstraintName("FK_UsersToUsersServicesPayments_UsersToUsersMessages");
            });

            modelBuilder.Entity<Versions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VersionNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WindowsServiceLogs>(entity =>
            {
                entity.HasIndex(e => new { e.SupplierId, e.CustomerId, e.IsError })
                    .HasName("main");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EventDesc)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RndNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.WindowsServiceLogsCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WindowsServiceLogs_Users1");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.WindowsServiceLogsSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WindowsServiceLogs_Users");
            });
        }
    }
}
