﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Models;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(HabestContext))]
    partial class HabestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Community", b =>
                {
                    b.Property<int>("IdCommunity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCommunity"), 1L, 1);

                    b.Property<string>("AvatarCommunity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BackgroundCommunity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommunityName")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasColumnName("Community_Name");

                    b.Property<int>("IdGenre")
                        .HasColumnType("int")
                        .HasColumnName("Id_Genre");

                    b.Property<int>("MemberCount")
                        .HasColumnType("int")
                        .HasColumnName("Member_Count");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("IdCommunity")
                        .HasName("PK__Community__551479477F27FEF3");

                    b.HasIndex("IdGenre");

                    b.ToTable("Community", (string)null);
                });

            modelBuilder.Entity("Repository.Models.GenreCommunity", b =>
                {
                    b.Property<int>("IdGenre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGenre"), 1L, 1);

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Genre_Name");

                    b.HasKey("IdGenre");

                    b.ToTable("GenreCommunity", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Interaction", b =>
                {
                    b.Property<int>("IdComment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdComment"), 1L, 1);

                    b.Property<string>("ContentComment")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Content_Comment");

                    b.Property<DateTime?>("DateComment")
                        .HasColumnType("date")
                        .HasColumnName("Date_Comment");

                    b.Property<int>("IdPost")
                        .HasColumnType("int")
                        .HasColumnName("Id_Post");

                    b.Property<bool?>("IsLikePost")
                        .HasColumnType("bit");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("User_Id");

                    b.HasKey("IdComment");

                    b.HasIndex("IdPost");

                    b.HasIndex("UserId");

                    b.ToTable("Interaction", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationId"), 1L, 1);

                    b.Property<string>("ContentNoti")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Content_Noti");

                    b.Property<DateTime?>("DateNoti")
                        .HasColumnType("date")
                        .HasColumnName("Date_Noti");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("User_ID");

                    b.Property<string>("UserIdReceive")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotificationId");

                    b.HasIndex("UserId");

                    b.ToTable("Notification", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Person", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BackgroundImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateUserRe")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsConfirm")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsVerifiedPage")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("TotalPoint")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Person", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Post", b =>
                {
                    b.Property<int>("IdPost")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPost"), 1L, 1);

                    b.Property<DateTime?>("DatePost")
                        .HasColumnType("date")
                        .HasColumnName("Date_Post");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("IdTask")
                        .HasColumnType("int")
                        .HasColumnName("Id_Task");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdPost");

                    b.HasIndex("IdTask");

                    b.ToTable("Post", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Progress", b =>
                {
                    b.Property<int>("IdProgress")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProgress"), 1L, 1);

                    b.Property<DateTime?>("CompletedDate")
                        .HasColumnType("date")
                        .HasColumnName("Completed_Date");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("date")
                        .HasColumnName("Create_Date");

                    b.Property<int>("Precent")
                        .HasColumnType("int");

                    b.Property<string>("ProgressName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Progress_Name");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("IdProgress");

                    b.ToTable("Progress", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Report", b =>
                {
                    b.Property<int>("IdReport")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReport"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("IdPost")
                        .HasColumnType("int")
                        .HasColumnName("Id_Post");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("User_ID");

                    b.HasKey("IdReport");

                    b.HasIndex("IdPost");

                    b.HasIndex("UserId");

                    b.ToTable("Report", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Reward", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("IdReward")
                        .HasColumnType("int")
                        .HasColumnName("Id_Reward");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("User_Id");

                    b.HasKey("id");

                    b.HasIndex("IdReward");

                    b.HasIndex("UserId");

                    b.ToTable("Reward", (string)null);
                });

            modelBuilder.Entity("Repository.Models.RewardDetail", b =>
                {
                    b.Property<int>("IdReward")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReward"), 1L, 1);

                    b.Property<int>("PointTrade")
                        .HasColumnType("int")
                        .HasColumnName("Point_Trade");

                    b.Property<int>("Tier")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdReward");

                    b.ToTable("Reward_Detail", (string)null);
                });

            modelBuilder.Entity("Repository.Models.Task", b =>
                {
                    b.Property<int>("IdTask")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTask"), 1L, 1);

                    b.Property<DateTime?>("DateCompleted")
                        .HasColumnType("date")
                        .HasColumnName("Date_Completed");

                    b.Property<int>("IdCommunity")
                        .HasColumnType("int")
                        .HasColumnName("Id_Community");

                    b.Property<int>("IdProgress")
                        .HasColumnType("int")
                        .HasColumnName("Id_Progress");

                    b.Property<int>("IsVerified")
                        .HasColumnType("int");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TaskDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("Task_Description");

                    b.Property<string>("TaskName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Task_Name");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("User_Id");

                    b.HasKey("IdTask");

                    b.HasIndex("IdCommunity");

                    b.HasIndex("IdProgress");

                    b.HasIndex("UserId");

                    b.ToTable("Task", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Repository.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Repository.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repository.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Repository.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Repository.Models.Community", b =>
                {
                    b.HasOne("Repository.Models.GenreCommunity", "GenreCommunity")
                        .WithMany("Communities")
                        .HasForeignKey("IdGenre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Community__Id_Genre__3A81B327");

                    b.Navigation("GenreCommunity");
                });

            modelBuilder.Entity("Repository.Models.Interaction", b =>
                {
                    b.HasOne("Repository.Models.Post", "Post")
                        .WithMany("Interactions")
                        .HasForeignKey("IdPost")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Interaction__Id_Post__5441852A");

                    b.HasOne("Repository.Models.Person", "User")
                        .WithMany("Interactions")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Interaction__User_Id__5535A963");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repository.Models.Notification", b =>
                {
                    b.HasOne("Repository.Models.Person", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Notification__User_Id___5165187F");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repository.Models.Post", b =>
                {
                    b.HasOne("Repository.Models.Task", "Task")
                        .WithMany("Posts")
                        .HasForeignKey("IdTask")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Post__Id_Task___44FF419A");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Repository.Models.Report", b =>
                {
                    b.HasOne("Repository.Models.Post", "Post")
                        .WithMany("Reports")
                        .HasForeignKey("IdPost")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Report__Id_Post__05D8E0BE");

                    b.HasOne("Repository.Models.Person", "User")
                        .WithMany("Reports")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Report__User_ID__06CD04F7");

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repository.Models.Reward", b =>
                {
                    b.HasOne("Repository.Models.RewardDetail", "RewardDetail")
                        .WithMany("Rewards")
                        .HasForeignKey("IdReward")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Reward__Id_Reward__08D8E0BE");

                    b.HasOne("Repository.Models.Person", "User")
                        .WithMany("Rewards")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Reward__User_ID__4E88ABD4");

                    b.Navigation("RewardDetail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repository.Models.Task", b =>
                {
                    b.HasOne("Repository.Models.Community", "Community")
                        .WithMany("Tasks")
                        .HasForeignKey("IdCommunity")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Task__Id_Community__07CD01F7");

                    b.HasOne("Repository.Models.Progress", "Progress")
                        .WithMany("Tasks")
                        .HasForeignKey("IdProgress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Task__Id_Progress__09CD04F7");

                    b.HasOne("Repository.Models.Person", "User")
                        .WithMany("Tasks")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Task__User_ID__08CD02F7");

                    b.Navigation("Community");

                    b.Navigation("Progress");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repository.Models.Community", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("Repository.Models.GenreCommunity", b =>
                {
                    b.Navigation("Communities");
                });

            modelBuilder.Entity("Repository.Models.Person", b =>
                {
                    b.Navigation("Interactions");

                    b.Navigation("Notifications");

                    b.Navigation("Reports");

                    b.Navigation("Rewards");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("Repository.Models.Post", b =>
                {
                    b.Navigation("Interactions");

                    b.Navigation("Reports");
                });

            modelBuilder.Entity("Repository.Models.Progress", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("Repository.Models.RewardDetail", b =>
                {
                    b.Navigation("Rewards");
                });

            modelBuilder.Entity("Repository.Models.Task", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
