using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CheckInWebApp.Models
{
    public partial class checkinappContext : DbContext
    {
        public checkinappContext()
        {
        }

        public checkinappContext(DbContextOptions<checkinappContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountInfor> AccountInfor { get; set; }
        public virtual DbSet<AnswerInfor> AnswerInfor { get; set; }
        public virtual DbSet<AnswerRecord> AnswerRecord { get; set; }
        public virtual DbSet<AreaInfor> AreaInfor { get; set; }
        public virtual DbSet<CatInfor> CatInfor { get; set; }
        public virtual DbSet<ChannelInfor> ChannelInfor { get; set; }
        public virtual DbSet<CheckinImageRecord> CheckinImageRecord { get; set; }
        public virtual DbSet<CheckinInfor> CheckinInfor { get; set; }
        public virtual DbSet<CityRuralInfor> CityRuralInfor { get; set; }
        public virtual DbSet<ContentCourseRecord> ContentCourseRecord { get; set; }
        public virtual DbSet<ContentInfor> ContentInfor { get; set; }
        public virtual DbSet<ContentModelRecord> ContentModelRecord { get; set; }
        public virtual DbSet<CourseInfor> CourseInfor { get; set; }
        public virtual DbSet<CourseTestRecord> CourseTestRecord { get; set; }
        public virtual DbSet<DistrictInfor> DistrictInfor { get; set; }
        public virtual DbSet<GiftCourseRecord> GiftCourseRecord { get; set; }
        public virtual DbSet<GiftInfor> GiftInfor { get; set; }
        public virtual DbSet<GiftType> GiftType { get; set; }
        public virtual DbSet<ImageInfor> ImageInfor { get; set; }
        public virtual DbSet<LevelInfor> LevelInfor { get; set; }
        public virtual DbSet<LoginInfor> LoginInfor { get; set; }
        public virtual DbSet<ModelInfor> ModelInfor { get; set; }
        public virtual DbSet<PermissionInfor> PermissionInfor { get; set; }
        public virtual DbSet<PlatformInfor> PlatformInfor { get; set; }
        public virtual DbSet<PositionInfor> PositionInfor { get; set; }
        public virtual DbSet<ProvinceInfor> ProvinceInfor { get; set; }
        public virtual DbSet<QuestionInfor> QuestionInfor { get; set; }
        public virtual DbSet<RegionInfor> RegionInfor { get; set; }
        public virtual DbSet<RoomInfor> RoomInfor { get; set; }
        public virtual DbSet<StoreInfor> StoreInfor { get; set; }
        public virtual DbSet<TestInfor> TestInfor { get; set; }
        public virtual DbSet<TestQuestionRecord> TestQuestionRecord { get; set; }
        public virtual DbSet<UserInfor> UserInfor { get; set; }
        public virtual DbSet<UserPermissionRecord> UserPermissionRecord { get; set; }
        public virtual DbSet<VenueInfor> VenueInfor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=checkinapp.database.windows.net;Database=checkinapp;User ID = checkinapp;password=SavinaNo1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChannelId).HasColumnName("ChannelID");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.AccountInfor)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountInfor_ChannelInfor");
            });

            modelBuilder.Entity<AnswerInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckinInforId).HasColumnName("CheckinInforID");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.Score).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.CheckinInfor)
                    .WithMany(p => p.AnswerInfor)
                    .HasForeignKey(d => d.CheckinInforId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnswerInfor_CheckinInfor");
            });

            modelBuilder.Entity<AnswerRecord>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.AnswerOption)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.QuesionId).HasColumnName("QuesionID");

                entity.HasOne(d => d.Answer)
                    .WithMany(p => p.AnswerRecord)
                    .HasForeignKey(d => d.AnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnswerRecord_AnswerInfor");

                entity.HasOne(d => d.Quesion)
                    .WithMany(p => p.AnswerRecord)
                    .HasForeignKey(d => d.QuesionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnswerRecord_QuestionInfor");
            });

            modelBuilder.Entity<AreaInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NameEn).HasColumnName("NameEN");

                entity.Property(e => e.NameVn).HasColumnName("NameVN");
            });

            modelBuilder.Entity<CatInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ChannelInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<CheckinImageRecord>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckinId).HasColumnName("CheckinID");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.HasOne(d => d.Checkin)
                    .WithMany(p => p.CheckinImageRecord)
                    .HasForeignKey(d => d.CheckinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckinImageRecord_CheckinInfor");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.CheckinImageRecord)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("FK_CheckinImageRecord_ImageInfor");
            });

            modelBuilder.Entity<CheckinInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.Property(e => e.Signature).HasColumnType("image");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.CheckinInfor)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckinInfor_RoomInfor");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CheckinInfor)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckinInfor_UserInfor");
            });

            modelBuilder.Entity<CityRuralInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ContentCourseRecord>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.ContentCourseRecord)
                    .HasForeignKey(d => d.ContentId)
                    .HasConstraintName("FK_ContentCourseRecord_ContentInfor");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.ContentCourseRecord)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_ContentCourseRecord_CourseInfor");
            });

            modelBuilder.Entity<ContentInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datetime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ContentModelRecord>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.ContentModelRecord)
                    .HasForeignKey(d => d.ContentId)
                    .HasConstraintName("FK_ContentModelRecord_ContentInfor");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.ContentModelRecord)
                    .HasForeignKey(d => d.ModelId)
                    .HasConstraintName("FK_ContentModelRecord_ModelInfor");
            });

            modelBuilder.Entity<CourseInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<CourseTestRecord>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseTestRecord)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseTestRecord_CourseInfor");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.CourseTestRecord)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseTestRecord_TestInfor");
            });

            modelBuilder.Entity<DistrictInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.DistrictInfor)
                    .HasForeignKey(d => d.ProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DistrictInfor_ProvinceInfor");
            });

            modelBuilder.Entity<GiftCourseRecord>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.GiftInforId).HasColumnName("GiftInforID");

                entity.Property(e => e.GiftTypeId).HasColumnName("GiftTypeID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.GiftCourseRecord)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_GiftCourseRecord_CourseInfor");

                entity.HasOne(d => d.GiftInfor)
                    .WithMany(p => p.GiftCourseRecord)
                    .HasForeignKey(d => d.GiftInforId)
                    .HasConstraintName("FK_GiftCourseRecord_GiftInfor");

                entity.HasOne(d => d.GiftType)
                    .WithMany(p => p.GiftCourseRecord)
                    .HasForeignKey(d => d.GiftTypeId)
                    .HasConstraintName("FK_GiftCourseRecord_GiftType");
            });

            modelBuilder.Entity<GiftInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.GiftInfor)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GiftInfor_ImageInfor");
            });

            modelBuilder.Entity<GiftType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ImageInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datetime).HasColumnType("datetime");
            });

            modelBuilder.Entity<LevelInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LoginInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Timestamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LoginInfor)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LoginInfor_UserInfor");
            });

            modelBuilder.Entity<ModelInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.ModelInfor)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModelInfor_CatInfor");
            });

            modelBuilder.Entity<PermissionInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<PlatformInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PositionInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ProvinceInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityRuralId).HasColumnName("CityRuralID");

                entity.Property(e => e.NameEn).HasColumnName("NameEN");

                entity.Property(e => e.NameVn).HasColumnName("NameVN");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.HasOne(d => d.CityRural)
                    .WithMany(p => p.ProvinceInfor)
                    .HasForeignKey(d => d.CityRuralId)
                    .HasConstraintName("FK_ProvinceInfor_CityRuralInfor");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.ProvinceInfor)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProvinceInfor_RegionInfor");
            });

            modelBuilder.Entity<QuestionInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.TrueChoose)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.QuestionInfor)
                    .HasForeignKey(d => d.CatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionInfor_CatInfor");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.QuestionInfor)
                    .HasForeignKey(d => d.LevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionInfor_LevelInfor");
            });

            modelBuilder.Entity<RegionInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.NameEn).HasColumnName("NameEN");

                entity.Property(e => e.NameVn).HasColumnName("NameVN");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.RegionInfor)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegionInfor_AreaInfor");
            });

            modelBuilder.Entity<RoomInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.PlatformId).HasColumnName("PlatformID");

                entity.Property(e => e.QrcodeImage)
                    .IsRequired()
                    .HasColumnName("QRCodeImage")
                    .HasColumnType("image");

                entity.Property(e => e.RoomFee).HasColumnType("money");

                entity.Property(e => e.RoomUrl).IsRequired();

                entity.Property(e => e.TeabreakFee).HasColumnType("money");

                entity.Property(e => e.TrainerId).HasColumnName("TrainerID");

                entity.Property(e => e.VenueId).HasColumnName("VenueID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.RoomInfor)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoomInfor_CourseInfor");

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.RoomInfor)
                    .HasForeignKey(d => d.PlatformId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoomInfor_PlatformInfor");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.RoomInfor)
                    .HasForeignKey(d => d.VenueId)
                    .HasConstraintName("FK_RoomInfor_VenueInfor");
            });

            modelBuilder.Entity<StoreInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.DealeCode).HasMaxLength(50);

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.Mcscode)
                    .HasColumnName("MCScode")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.StoreInfor)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreInfor_AccountInfor");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.StoreInfor)
                    .HasForeignKey(d => d.DistrictId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreInfor_DistrictInfor");
            });

            modelBuilder.Entity<TestInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TestQuestionRecord>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.TestQuestionRecord)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestQuestionRecord_QuestionInfor");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.TestQuestionRecord)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestQuestionRecord_TestInfor");
            });

            modelBuilder.Entity<UserInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Fullname).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(500);

                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.Tel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.UserInfor)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserInfor_PositionInfor");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.UserInfor)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserInfor_StoreInfor");
            });

            modelBuilder.Entity<UserPermissionRecord>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.UserPermissionRecord)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPermissionRecord_PermissionInfor");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPermissionRecord)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPermissionRecord_UserInfor");
            });

            modelBuilder.Entity<VenueInfor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.ReceptionId).HasColumnName("ReceptionID");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.VenueInfor)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_VenueInfor_ProvinceInfor");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
