﻿// <auto-generated />
using DziennikSportowca.Data;
using DziennikSportowca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DziennikSportowca.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20171115181458_ExerciseWeight_Entity_Updated")]
    partial class ExerciseWeight_Entity_Updated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DziennikSportowca.Models.ActivityType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("ActivityType");
                });

            modelBuilder.Entity("DziennikSportowca.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int>("Gender");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<byte[]>("ProfilePicture");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Surname");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DziennikSportowca.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Dish");
                });

            modelBuilder.Entity("DziennikSportowca.Models.DishFoodProduct", b =>
                {
                    b.Property<int>("DishId");

                    b.Property<int>("FoodProductId");

                    b.Property<double>("FoodProductWeight");

                    b.HasKey("DishId", "FoodProductId");

                    b.HasIndex("FoodProductId");

                    b.ToTable("DishFoodProduct");
                });

            modelBuilder.Entity("DziennikSportowca.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActivityTypeId");

                    b.Property<int?>("ExerciseInstructionId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ActivityTypeId");

                    b.HasIndex("ExerciseInstructionId");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("DziennikSportowca.Models.ExerciseInstruction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ExerciseId");

                    b.Property<string>("Instructions");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.ToTable("ExerciseInstruction");
                });

            modelBuilder.Entity("DziennikSportowca.Models.ExerciseInstructionPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Content");

                    b.Property<int?>("ExerciseInstructionId");

                    b.Property<string>("PhotoTitle");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseInstructionId");

                    b.ToTable("ExerciseInstructionPhoto");
                });

            modelBuilder.Entity("DziennikSportowca.Models.ExerciseWeight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Result");

                    b.Property<int>("UserTrainingExerciseResultId");

                    b.HasKey("Id");

                    b.HasIndex("UserTrainingExerciseResultId");

                    b.ToTable("ExerciseWeight");
                });

            modelBuilder.Entity("DziennikSportowca.Models.FoodProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Carbohydrate");

                    b.Property<string>("Description");

                    b.Property<double>("Energy");

                    b.Property<double>("Fat");

                    b.Property<int>("Measurement");

                    b.Property<double>("Protein");

                    b.Property<int?>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("FoodProduct");
                });

            modelBuilder.Entity("DziennikSportowca.Models.FoodProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("FoodProductType");
                });

            modelBuilder.Entity("DziennikSportowca.Models.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CompletionDate");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<bool>("Result");

                    b.Property<string>("Scope");

                    b.Property<double>("Target");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Goal");
                });

            modelBuilder.Entity("DziennikSportowca.Models.MusclePart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("MusclePart");
                });

            modelBuilder.Entity("DziennikSportowca.Models.MusclePartExercise", b =>
                {
                    b.Property<int>("ExerciseId");

                    b.Property<int>("MuscePartId");

                    b.HasKey("ExerciseId", "MuscePartId");

                    b.HasIndex("MuscePartId");

                    b.ToTable("MusclePartExercise");
                });

            modelBuilder.Entity("DziennikSportowca.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("PhotoContent");

                    b.Property<int>("UserFigureId");

                    b.HasKey("Id");

                    b.HasIndex("UserFigureId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("DziennikSportowca.Models.TrainingPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("TrainingPlan");
                });

            modelBuilder.Entity("DziennikSportowca.Models.TrainingPlanExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ExerciseId");

                    b.Property<int?>("ExerciseLength");

                    b.Property<int>("Index");

                    b.Property<int?>("RepsNo");

                    b.Property<int?>("SeriesNo");

                    b.Property<int>("TrainingPlanId");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("TrainingPlanId");

                    b.ToTable("TrainingPlanExercise");
                });

            modelBuilder.Entity("DziennikSportowca.Models.UserFigure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BicepsCircumference");

                    b.Property<double>("BodyFat");

                    b.Property<double>("ChestCircumference");

                    b.Property<DateTime>("Date");

                    b.Property<double>("HipCircumference");

                    b.Property<double>("ShouldersCircumference");

                    b.Property<double>("ThighCircumference");

                    b.Property<double>("TricepsCircumference");

                    b.Property<string>("UserId");

                    b.Property<double>("WaistCircumference");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserFigure");
                });

            modelBuilder.Entity("DziennikSportowca.Models.UserFriend", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("FriendId");

                    b.Property<int>("FriendshipStatus");

                    b.HasKey("UserId", "FriendId");

                    b.HasIndex("FriendId");

                    b.ToTable("UserFriend");
                });

            modelBuilder.Entity("DziennikSportowca.Models.UserTraining", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndDateTime");

                    b.Property<DateTime>("StartDateTime");

                    b.Property<int>("TrainingId");

                    b.HasKey("Id");

                    b.HasIndex("TrainingId");

                    b.ToTable("UserTraining");
                });

            modelBuilder.Entity("DziennikSportowca.Models.UserTrainingExerciseResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ExerciseLength");

                    b.Property<int?>("RepsNo");

                    b.Property<int?>("SeriesNo");

                    b.Property<int>("TrainingPlanExerciseId");

                    b.Property<int>("UserTrainingId");

                    b.HasKey("Id");

                    b.HasIndex("TrainingPlanExerciseId");

                    b.HasIndex("UserTrainingId");

                    b.ToTable("UserTrainingExerciseResult");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DziennikSportowca.Models.Dish", b =>
                {
                    b.HasOne("DziennikSportowca.Models.ApplicationUser", "User")
                        .WithMany("Dishes")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DziennikSportowca.Models.DishFoodProduct", b =>
                {
                    b.HasOne("DziennikSportowca.Models.Dish", "Dish")
                        .WithMany("FoodProducts")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DziennikSportowca.Models.FoodProduct", "FoodProduct")
                        .WithMany("Dishes")
                        .HasForeignKey("FoodProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DziennikSportowca.Models.Exercise", b =>
                {
                    b.HasOne("DziennikSportowca.Models.ActivityType", "ActivityType")
                        .WithMany("Exercises")
                        .HasForeignKey("ActivityTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DziennikSportowca.Models.ExerciseInstruction", "ExerciseInstruction")
                        .WithMany()
                        .HasForeignKey("ExerciseInstructionId");
                });

            modelBuilder.Entity("DziennikSportowca.Models.ExerciseInstruction", b =>
                {
                    b.HasOne("DziennikSportowca.Models.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DziennikSportowca.Models.ExerciseInstructionPhoto", b =>
                {
                    b.HasOne("DziennikSportowca.Models.ExerciseInstruction", "ExerciseInstruction")
                        .WithMany("Photos")
                        .HasForeignKey("ExerciseInstructionId");
                });

            modelBuilder.Entity("DziennikSportowca.Models.ExerciseWeight", b =>
                {
                    b.HasOne("DziennikSportowca.Models.UserTrainingExerciseResult", "UserTrainingExerciseResult")
                        .WithMany("Weights")
                        .HasForeignKey("UserTrainingExerciseResultId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DziennikSportowca.Models.FoodProduct", b =>
                {
                    b.HasOne("DziennikSportowca.Models.FoodProductType", "Type")
                        .WithMany("FoodProducts")
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("DziennikSportowca.Models.Goal", b =>
                {
                    b.HasOne("DziennikSportowca.Models.ApplicationUser", "User")
                        .WithMany("Goals")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DziennikSportowca.Models.MusclePartExercise", b =>
                {
                    b.HasOne("DziennikSportowca.Models.Exercise", "Exercise")
                        .WithMany("MuscleParts")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DziennikSportowca.Models.MusclePart", "MusclePart")
                        .WithMany("Exercises")
                        .HasForeignKey("MuscePartId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DziennikSportowca.Models.Photo", b =>
                {
                    b.HasOne("DziennikSportowca.Models.UserFigure", "UserFigure")
                        .WithMany("Photos")
                        .HasForeignKey("UserFigureId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DziennikSportowca.Models.TrainingPlan", b =>
                {
                    b.HasOne("DziennikSportowca.Models.ApplicationUser", "User")
                        .WithMany("TrainingPlans")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DziennikSportowca.Models.TrainingPlanExercise", b =>
                {
                    b.HasOne("DziennikSportowca.Models.Exercise", "Exercise")
                        .WithMany("TrainingPlans")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DziennikSportowca.Models.TrainingPlan", "TrainingPlan")
                        .WithMany("Exercises")
                        .HasForeignKey("TrainingPlanId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DziennikSportowca.Models.UserFigure", b =>
                {
                    b.HasOne("DziennikSportowca.Models.ApplicationUser", "User")
                        .WithMany("UserCircumferences")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DziennikSportowca.Models.UserFriend", b =>
                {
                    b.HasOne("DziennikSportowca.Models.ApplicationUser", "Friend")
                        .WithMany("Users")
                        .HasForeignKey("FriendId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DziennikSportowca.Models.ApplicationUser", "User")
                        .WithMany("UserFriends")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DziennikSportowca.Models.UserTraining", b =>
                {
                    b.HasOne("DziennikSportowca.Models.TrainingPlan", "Training")
                        .WithMany("UserTrainings")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DziennikSportowca.Models.UserTrainingExerciseResult", b =>
                {
                    b.HasOne("DziennikSportowca.Models.TrainingPlanExercise", "TrainingPlanExercise")
                        .WithMany("Results")
                        .HasForeignKey("TrainingPlanExerciseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DziennikSportowca.Models.UserTraining", "UserTraining")
                        .WithMany("UserTrainingsExercisesResults")
                        .HasForeignKey("UserTrainingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DziennikSportowca.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DziennikSportowca.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DziennikSportowca.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DziennikSportowca.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
