using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FinalProject.Models‏
{
    public partial class FinalProjectContext : DbContext
    {
        public FinalProjectContext()
        {
        }

        public FinalProjectContext(DbContextOptions<FinalProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<BooksCost> BooksCost { get; set; }
        public virtual DbSet<BooksCustomers> BooksCustomers { get; set; }
        public virtual DbSet<BooksCustomersCategories> BooksCustomersCategories { get; set; }
        public virtual DbSet<BooksOrderItem> BooksOrderItem { get; set; }
        public virtual DbSet<BooksOrders> BooksOrders { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Films> Films { get; set; }
        public virtual DbSet<GuidanceAttendance> GuidanceAttendance { get; set; }
        public virtual DbSet<GuidanceGroups> GuidanceGroups { get; set; }
        public virtual DbSet<GuidanceMeetings> GuidanceMeetings { get; set; }
        public virtual DbSet<GuidancePayment> GuidancePayment { get; set; }
        public virtual DbSet<GuidanceRegistrants> GuidanceRegistrants { get; set; }
        public virtual DbSet<MovieAdvertising> MovieAdvertising { get; set; }
        public virtual DbSet<MovieAdvertisingStage> MovieAdvertisingStage { get; set; }
        public virtual DbSet<MovieAdvertisingType> MovieAdvertisingType { get; set; }
        public virtual DbSet<MovieClose> MovieClose { get; set; }
        public virtual DbSet<MovieOpen> MovieOpen { get; set; }
        public virtual DbSet<MoviePayment> MoviePayment { get; set; }
        public virtual DbSet<MoviePeriod> MoviePeriod { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=FinalProject;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.Property(e => e.BookId).HasColumnName("Book_ID");

                entity.Property(e => e.ClassBook)
                    .IsRequired()
                    .HasColumnName("Class_Book")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NameBook)
                    .IsRequired()
                    .HasColumnName("Name_Book")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BooksCost>(entity =>
            {
                entity.HasKey(e => e.CostId);

                entity.Property(e => e.CostId).HasColumnName("Cost_ID");

                entity.Property(e => e.BookId).HasColumnName("Book_ID");

                entity.Property(e => e.CustomerCategoryId).HasColumnName("CustomerCategory_ID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BooksCost)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BooksCost__Book___45F365D3");

                entity.HasOne(d => d.CustomerCategory)
                    .WithMany(p => p.BooksCost)
                    .HasForeignKey(d => d.CustomerCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BooksCost__Custo__46E78A0C");
            });

            modelBuilder.Entity<BooksCustomers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.ContactId).HasColumnName("Contact_ID");

                entity.Property(e => e.CustomerAddress)
                    .IsRequired()
                    .HasColumnName("Customer_Address")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerCategoryId).HasColumnName("CustomerCategory_ID");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.BooksCustomers)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BooksCust__Conta__44FF419A");

                entity.HasOne(d => d.CustomerCategory)
                    .WithMany(p => p.BooksCustomers)
                    .HasForeignKey(d => d.CustomerCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BooksCust__Custo__4222D4EF");
            });

            modelBuilder.Entity<BooksCustomersCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryId).HasColumnName("Category_ID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("Category_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BooksOrderItem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.Property(e => e.ItemId).HasColumnName("Item_ID");

                entity.Property(e => e.BookId).HasColumnName("Book_ID");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.BooksOrderItem)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BooksOrde__Book___48CFD27E");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.BooksOrderItem)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BooksOrde__Order__47DBAE45");
            });

            modelBuilder.Entity<BooksOrders>(entity =>
            {
                entity.Property(e => e.BooksOrdersId).HasColumnName("BooksOrders_ID");

                entity.Property(e => e.AcceptLiscence).HasColumnName("Accept_Liscence‏");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_date")
                    .HasColumnType("date");

                entity.Property(e => e.TotalPrice).HasColumnName("Total_Price");

                entity.Property(e => e.WithReceipt).HasColumnName("With_Receipt");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.BooksOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BooksOrde__Custo__49C3F6B7");
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("City_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.Property(e => e.ContactId).HasColumnName("Contact_ID");

                entity.Property(e => e.ContactAddress)
                    .HasColumnName("Contact_Address")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactEmail)
                    .HasColumnName("Contact_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactFirstName)
                    .IsRequired()
                    .HasColumnName("Contact_First_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactLastName)
                    .IsRequired()
                    .HasColumnName("Contact_Last_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactPhone)
                    .IsRequired()
                    .HasColumnName("Contact_Phone")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Films>(entity =>
            {
                entity.HasKey(e => e.FilmId);

                entity.Property(e => e.FilmId).HasColumnName("Film_ID");

                entity.Property(e => e.FilmName)
                    .IsRequired()
                    .HasColumnName("Film_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GuidanceAttendance>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MeetingId).HasColumnName("Meeting_ID");

                entity.Property(e => e.RegistrantId).HasColumnName("Registrant_ID");

                entity.HasOne(d => d.Meeting)
                    .WithMany()
                    .HasForeignKey(d => d.MeetingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GuidanceA__Meeti__245D67DE");

                entity.HasOne(d => d.Registrant)
                    .WithMany()
                    .HasForeignKey(d => d.RegistrantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GuidanceA__Regis__25518C17");
            });

            modelBuilder.Entity<GuidanceGroups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.MeetingAddress)
                    .IsRequired()
                    .HasColumnName("Meeting_Address")
                    .HasMaxLength(50);

                entity.Property(e => e.MeetingCityId).HasColumnName("Meeting_City_ID");

                entity.Property(e => e.MeetingFirstDate)
                    .HasColumnName("Meeting_First_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MeetingLastDate)
                    .HasColumnName("Meeting_Last_Date")
                    .HasColumnType("date");

                entity.Property(e => e.MeetingNumber).HasColumnName("Meeting_Number");

                entity.Property(e => e.MeetingStatus).HasColumnName("Meeting_Status");

                entity.Property(e => e.ParticipantsNumber).HasColumnName("Participants_Number");

                entity.Property(e => e.PlaceCost).HasColumnName("Place_Cost");

                entity.Property(e => e.PricePerHead).HasColumnName("Price_Per_Head");

                entity.Property(e => e.SecrataryCost).HasColumnName("Secratary_Cost");

                entity.HasOne(d => d.MeetingCity)
                    .WithMany(p => p.GuidanceGroups)
                    .HasForeignKey(d => d.MeetingCityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GuidanceG__Meeti__1EA48E88");
            });

            modelBuilder.Entity<GuidanceMeetings>(entity =>
            {
                entity.HasKey(e => e.MeetingId);

                entity.Property(e => e.MeetingId).HasColumnName("Meeting_ID");

                entity.Property(e => e.FoodCost).HasColumnName("Food_Cost");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.MeetingDate)
                    .HasColumnName("Meeting_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Note).HasMaxLength(50);

                entity.Property(e => e.NumMeeting).HasColumnName("Num_Meeting");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GuidanceMeetings)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GuidanceM__Group__1F98B2C1");
            });

            modelBuilder.Entity<GuidancePayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment_Type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GuidanceRegistrants>(entity =>
            {
                entity.HasKey(e => e.RegistrantId);

                entity.Property(e => e.RegistrantId).HasColumnName("Registrant_ID");

                entity.Property(e => e.ContactId).HasColumnName("Contact_ID");

                entity.Property(e => e.GroupId).HasColumnName("Group_ID");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.GuidanceRegistrants)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GuidanceR__Conta__208CD6FA");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GuidanceRegistrants)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GuidanceR__Group__2180FB33");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.GuidanceRegistrants)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GuidanceR__Payme__22751F6C");
            });

            modelBuilder.Entity<MovieAdvertising>(entity =>
            {
                entity.HasKey(e => e.AdvertisingId);

                entity.Property(e => e.AdvertisingId).HasColumnName("Advertising_ID");

                entity.Property(e => e.AdvertisingContactId).HasColumnName("Advertising_Contact_ID");

                entity.Property(e => e.AdvertisingCost).HasColumnName("Advertising_Cost");

                entity.Property(e => e.AdvertisingDates)
                    .HasColumnName("Advertising_Dates")
                    .HasColumnType("date");

                entity.Property(e => e.AdvertisingSize)
                    .IsRequired()
                    .HasColumnName("Advertising_Size")
                    .HasMaxLength(50);

                entity.Property(e => e.AdvertisingStageId).HasColumnName("Advertising_Stage_ID");

                entity.Property(e => e.AdvertisingTypeId).HasColumnName("Advertising_Type_ID");

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.PeriodId).HasColumnName("Period_ID");

                entity.HasOne(d => d.AdvertisingContact)
                    .WithMany(p => p.MovieAdvertising)
                    .HasForeignKey(d => d.AdvertisingContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieAdve__Adver__70DDC3D8");

                entity.HasOne(d => d.AdvertisingStage)
                    .WithMany(p => p.MovieAdvertising)
                    .HasForeignKey(d => d.AdvertisingStageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieAdve__Adver__236943A5");

                entity.HasOne(d => d.AdvertisingType)
                    .WithMany(p => p.MovieAdvertising)
                    .HasForeignKey(d => d.AdvertisingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieAdve__Adver__6FE99F9F");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.MovieAdvertising)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieAdve__City___6E01572D");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.MovieAdvertising)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieAdve__Perio__6EF57B66");
            });

            modelBuilder.Entity<MovieAdvertisingStage>(entity =>
            {
                entity.HasKey(e => e.AdvertisingStageId);

                entity.Property(e => e.AdvertisingStageId).HasColumnName("Advertising_Stage_ID");

                entity.Property(e => e.AdvertisingStageEmail)
                    .IsRequired()
                    .HasColumnName("Advertising_Stage_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.AdvertisingStageName)
                    .IsRequired()
                    .HasColumnName("Advertising_Stage_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MovieAdvertisingType>(entity =>
            {
                entity.HasKey(e => e.AdvertisingTypeId);

                entity.Property(e => e.AdvertisingTypeId).HasColumnName("Advertising_Type_ID");

                entity.Property(e => e.AdvertisingTypeName)
                    .IsRequired()
                    .HasColumnName("Advertising_Type_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MovieClose>(entity =>
            {
                entity.HasKey(e => e.MovieId);

                entity.Property(e => e.MovieId).HasColumnName("Movie_ID");

                entity.Property(e => e.ContactId).HasColumnName("Contact_ID");

                entity.Property(e => e.FilmId).HasColumnName("Film_ID");

                entity.Property(e => e.GlobalMovie).HasColumnName("Global_Movie");

                entity.Property(e => e.InChargeAmount).HasColumnName("InCharge_Amount");

                entity.Property(e => e.InChargeId).HasColumnName("InCharge_ID");

                entity.Property(e => e.MovieAddress)
                    .IsRequired()
                    .HasColumnName("Movie_Address")
                    .HasMaxLength(50);

                entity.Property(e => e.MovieDate)
                    .HasColumnName("Movie_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.Property(e => e.PeriodId).HasColumnName("Period_ID");

                entity.Property(e => e.PricePerHead).HasColumnName("Price_Per_Head");

                entity.Property(e => e.TotalAmount).HasColumnName("Total_Amount");

                entity.Property(e => e.TotalParticipants).HasColumnName("Total_Participants");

                entity.Property(e => e.WithReceipt).HasColumnName("With_Receipt");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.MovieCloseContact)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieClos__Conta__73BA3083");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.MovieClose)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieClos__Film___75A278F5");

                entity.HasOne(d => d.InCharge)
                    .WithMany(p => p.MovieCloseInCharge)
                    .HasForeignKey(d => d.InChargeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieClos__InCha__72C60C4A");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.MovieCloseOrder)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieClos__Order__71D1E811");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.MovieClose)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieClos__Payme__74AE54BC");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.MovieClose)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieClos__Perio__76969D2E");
            });

            modelBuilder.Entity<MovieOpen>(entity =>
            {
                entity.HasKey(e => e.MovieId);

                entity.Property(e => e.MovieId).HasColumnName("Movie_ID");

                entity.Property(e => e.AuditoriumCost).HasColumnName("Auditorium_Cost");

                entity.Property(e => e.CityAddress)
                    .IsRequired()
                    .HasColumnName("City_Address")
                    .HasMaxLength(50);

                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.ContactCultureId).HasColumnName("Contact_Culture_ID");

                entity.Property(e => e.CountParticipantsAfternoon).HasColumnName("Count_Participants_Afternoon");

                entity.Property(e => e.CountParticipantsEvening).HasColumnName("Count_Participants_Evening");

                entity.Property(e => e.EquipmentCost).HasColumnName("Equipment_Cost");

                entity.Property(e => e.FilmId).HasColumnName("Film_ID");

                entity.Property(e => e.InChargeAmount).HasColumnName("InCharge_Amount");

                entity.Property(e => e.InChargeId).HasColumnName("InCharge_ID");

                entity.Property(e => e.InChargePaid).HasColumnName("InCharge_Paid");

                entity.Property(e => e.MovieDate)
                    .HasColumnName("Movie_Date")
                    .HasColumnType("date");

                entity.Property(e => e.NetProfitForDay).HasColumnName("Net_Profit_ForDay");

                entity.Property(e => e.NumberOfSeatsAuditorium).HasColumnName("NumberOfSeats_Auditorium");

                entity.Property(e => e.PeriodId).HasColumnName("Period_ID");

                entity.Property(e => e.TicketCostAfternoon).HasColumnName("Ticket_Cost_Afternoon");

                entity.Property(e => e.TicketCostEvening).HasColumnName("Ticket_Cost_Evening");

                entity.Property(e => e.WithEquipment).HasColumnName("With_Equipment");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.MovieOpen)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieOpen__City___778AC167");

                entity.HasOne(d => d.ContactCulture)
                    .WithMany(p => p.MovieOpenContactCulture)
                    .HasForeignKey(d => d.ContactCultureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieOpen__Conta__797309D9");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.MovieOpen)
                    .HasForeignKey(d => d.FilmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieOpen__Film___7A672E12");

                entity.HasOne(d => d.InCharge)
                    .WithMany(p => p.MovieOpenInCharge)
                    .HasForeignKey(d => d.InChargeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieOpen__InCha__7B5B524B");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.MovieOpen)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MovieOpen__Perio__787EE5A0");
            });

            modelBuilder.Entity<MoviePayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK_PaymentMovie");

                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasColumnName("Payment_Type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MoviePeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId)
                    .HasName("PK_MovuePeriod");

                entity.Property(e => e.PeriodId).HasColumnName("Period_ID");

                entity.Property(e => e.PeriodDate)
                    .HasColumnName("Period_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PeriodName)
                    .IsRequired()
                    .HasColumnName("Period_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("User_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPassword).HasColumnName("User_Password");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
