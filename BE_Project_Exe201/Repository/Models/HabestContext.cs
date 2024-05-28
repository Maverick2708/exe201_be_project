using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public partial class HabestContext : IdentityDbContext<Person>
    {
        public HabestContext() 
        {
        }
        public HabestContext(DbContextOptions<HabestContext> options) : base(options) { }

        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<Community> Communities { get; set; } = null!;
        public virtual DbSet<GenreCommunity> GenreCommunities { get; set; } = null!;
        public virtual DbSet<Interaction> Interactions { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<Progress> Progresss { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<Reward> Rewards { get; set; } = null!;
        public virtual DbSet<RewardDetail> Rewards_Detail { get; set;} = null!;
        public virtual DbSet<Task> Tasks { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Community>(entity =>
            {
                entity.HasKey(e => e.IdCommunity)
                      .HasName("PK__Community__551479477F27FEF3");
                entity.ToTable("Community");

                entity.Property(e => e.CommunityName)
                      .HasMaxLength(120)
                      .HasColumnName("Community_Name");
                entity.Property(e => e.MemberCount)
                      .HasColumnName("Member_Count");
                entity.Property(e => e.IdGenre)
                      .HasColumnName("Id_Genre");

                entity.HasOne(d => d.GenreCommunity)
                      .WithMany(p=>p.Communities)
                      .HasForeignKey(d=>d.IdGenre)
                      .HasConstraintName("FK__Community__Id_Genre__3A81B327");
            });

            modelBuilder.Entity<GenreCommunity>(entity =>
            {
                entity.HasKey(e => e.IdGenre);
                entity.Property(e => e.GenreName)
                      .HasColumnName("Genre_Name");
                entity.ToTable("GenreCommunity");
            });

            modelBuilder.Entity<Interaction>(entity =>
            {
                entity.HasKey(e => e.IdComment);
                entity.ToTable("Interaction");
                entity.Property(e => e.ContentComment)
                      .HasColumnName("Content_Comment");
                entity.Property(e=> e.DateComment)
                      .HasColumnType("date")
                      .HasColumnName("Date_Comment");
                entity.Property(e=> e.UserId).HasColumnName("User_Id");
                entity.Property(e => e.IdPost).HasColumnName("Id_Post");

                entity.HasOne(d => d.User)
                     .WithMany(p => p.Interactions)
                     .HasForeignKey(d => d.UserId)
                     .HasConstraintName("FK__Interaction__User_Id__5535A963");

                entity.HasOne(d => d.Post)
                   .WithMany(p => p.Interactions)
                   .HasForeignKey(d => d.IdPost)
                   .HasConstraintName("FK__Interaction__Id_Post__5441852A");
             });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasKey(e => e.NotificationId);
                entity.ToTable("Notification");
                entity.Property(e => e.ContentNoti)
                    .HasMaxLength(250)
                    .HasColumnName("Content_Noti");

                entity.Property(e => e.DateNoti)
                    .HasColumnType("date")
                    .HasColumnName("Date_Noti");
                entity.Property(e => e.UserId).HasColumnName("User_ID");
               
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Notification__User_Id___5165187F");

            });
            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasKey(e => e.IdPost);
                entity.ToTable("Post");

                entity.Property(e => e.Title)
                      .HasMaxLength(100);
                entity.Property(e => e.Description)
                      .HasMaxLength(500);
                entity.Property(e => e.DatePost)
                      .HasColumnType("date")
                      .HasColumnName("Date_Post");
                entity.Property(e => e.IdTask).HasColumnName("Id_Task");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.IdTask)
                    .HasConstraintName("FK__Post__Id_Task___44FF419A");

            });
            modelBuilder.Entity<Progress>(entity =>
            {
                entity.HasKey(e=> e.IdProgress);
                entity.ToTable("Progress");
                entity.Property(e=> e.ProgressName)
                      .HasMaxLength(150)
                      .HasColumnName("Progress_Name");
                entity.Property(e => e.CompletedDate)
                      .HasColumnType("date")
                      .HasColumnName("Completed_Date");
                entity.Property(e => e.CreateDate)
                      .HasColumnType("date")
                      .HasColumnName("Create_Date");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.HasKey(e=>e.IdReport);
                entity.ToTable("Report");

                entity.Property(e => e.IdPost).HasColumnName("Id_Post");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.IdPost)
                    .HasConstraintName("FK__Report__Id_Post__05D8E0BE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Report__User_ID__06CD04F7");
            });

            modelBuilder.Entity<Reward>(entity =>
            {
                entity.HasKey(e=> e.id);
                entity.ToTable("Reward");
                entity.Property(e => e.IdReward).HasColumnName("Id_Reward");
                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Rewards)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Reward__User_ID__4E88ABD4");

                entity.HasOne(d => d.RewardDetail)
                    .WithMany(p => p.Rewards)
                    .HasForeignKey(d => d.IdReward)
                    .HasConstraintName("FK__Reward__Id_Reward__08D8E0BE");

            });

            modelBuilder.Entity<RewardDetail>(entity=>
            {
                entity.HasKey(e => e.IdReward);
                entity.ToTable("Reward_Detail");
                entity.Property(e=> e.Type)
                      .HasMaxLength(100);
                entity.Property(e => e.PointTrade).HasColumnName("Point_Trade");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(e => e.IdTask);
                entity.ToTable("Task");

                entity.Property(e => e.UserId).HasColumnName("User_Id");
                entity.Property(e => e.IdCommunity).HasColumnName("Id_Community");
                entity.Property(e => e.TaskName)
                      .HasMaxLength(100)
                      .HasColumnName("Task_Name");
                entity.Property(e => e.TaskDescription)
                      .HasMaxLength(500)
                      .HasColumnName("Task_Description");
                entity.Property(e => e.DateCompleted)
                     .HasColumnType("date")
                     .HasColumnName("Date_Completed");
                entity.Property(e => e.IdProgress).HasColumnName("Id_Progress");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Task__User_ID__08CD02F7");

                entity.HasOne(d => d.Progress)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.IdProgress)
                    .HasConstraintName("FK__Task__Id_Progress__09CD04F7");

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.Tasks)
                    .HasForeignKey(d => d.IdCommunity)
                    .HasConstraintName("FK__Task__Id_Community__07CD01F7");
            });
            
            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(e => e.Address).HasMaxLength(250);
                entity.Property(e => e.FullName).HasMaxLength(150);
            });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
