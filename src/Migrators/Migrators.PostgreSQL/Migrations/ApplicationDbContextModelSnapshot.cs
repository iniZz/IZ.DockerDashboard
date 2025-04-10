﻿// <auto-generated />
using System;
using IZ.DockerDashboard.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Migrators.PostgreSQL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Entities.PicklistSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("created_by");

                    b.Property<string>("Description")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("description");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("last_modified_by");

                    b.Property<int>("Name")
                        .HasColumnType("integer")
                        .HasColumnName("name");

                    b.Property<string>("Text")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("text");

                    b.Property<string>("Value")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("pk_picklist_sets");

                    b.ToTable("picklist_sets", (string)null);
                });

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Identity.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("concurrency_stamp");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("created_by");

                    b.Property<string>("Description")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("description");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("last_modified_by");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("normalized_name");

                    b.Property<string>("TenantId")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("tenant_id");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_roles");

                    b.HasIndex("NormalizedName")
                        .HasDatabaseName("RoleNameIndex");

                    b.HasIndex("TenantId", "Name")
                        .IsUnique()
                        .HasDatabaseName("ix_asp_net_roles_tenant_id_name");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Identity.ApplicationRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("claim_value");

                    b.Property<string>("Description")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("description");

                    b.Property<string>("Group")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("group");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("role_id");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_role_claims");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_asp_net_role_claims_role_id");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("id");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer")
                        .HasColumnName("access_failed_count");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("concurrency_stamp");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("created_by");

                    b.Property<string>("DisplayName")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("display_name");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("email_confirmed");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<bool>("IsLive")
                        .HasColumnType("boolean")
                        .HasColumnName("is_live");

                    b.Property<string>("LanguageCode")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("language_code");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("last_modified");

                    b.Property<string>("LastModifiedBy")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("last_modified_by");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("lockout_enabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lockout_end");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("normalized_email");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("normalized_user_name");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("phone_number");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("phone_number_confirmed");

                    b.Property<string>("ProfilePictureDataUrl")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("profile_picture_data_url");

                    b.Property<string>("Provider")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("provider");

                    b.Property<string>("RefreshToken")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("refresh_token");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("refresh_token_expiry_time");

                    b.Property<string>("SecurityStamp")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("security_stamp");

                    b.Property<string>("SuperiorId")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("superior_id");

                    b.Property<string>("TimeZoneId")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("time_zone_id");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("two_factor_enabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("user_name");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_users");

                    b.HasIndex("CreatedBy")
                        .HasDatabaseName("ix_asp_net_users_created_by");

                    b.HasIndex("LastModifiedBy")
                        .HasDatabaseName("ix_asp_net_users_last_modified_by");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("SuperiorId")
                        .HasDatabaseName("ix_asp_net_users_superior_id");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Identity.ApplicationUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("claim_value");

                    b.Property<string>("Description")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("description");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_user_claims");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_asp_net_user_claims_user_id");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Identity.ApplicationUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("login_provider");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("provider_key");

                    b.Property<string>("ProviderDisplayName")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("provider_display_name");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("user_id");

                    b.HasKey("LoginProvider", "ProviderKey")
                        .HasName("pk_asp_net_user_logins");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_asp_net_user_logins_user_id");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Identity.ApplicationUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("user_id");

                    b.Property<string>("RoleId")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("role_id");

                    b.HasKey("UserId", "RoleId")
                        .HasName("pk_asp_net_user_roles");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_asp_net_user_roles_role_id");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Identity.ApplicationUserToken", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("user_id");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("login_provider");

                    b.Property<string>("Name")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("name");

                    b.Property<string>("Value")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("value");

                    b.HasKey("UserId", "LoginProvider", "Name")
                        .HasName("pk_asp_net_user_tokens");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FriendlyName")
                        .HasMaxLength(450)
                        .HasColumnType("character varying(450)")
                        .HasColumnName("friendly_name");

                    b.Property<string>("Xml")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)")
                        .HasColumnName("xml");

                    b.HasKey("Id")
                        .HasName("pk_data_protection_keys");

                    b.ToTable("data_protection_keys", (string)null);
                });

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Identity.ApplicationRoleClaim", b =>
                {
                    b.HasOne("IZ.DockerDashboard.Domain.Identity.ApplicationRole", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_role_claims_asp_net_roles_role_id");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Identity.ApplicationUser", b =>
                {
                    b.HasOne("IZ.DockerDashboard.Domain.Identity.ApplicationUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("fk_asp_net_users_asp_net_users_created_by");

                    b.HasOne("IZ.DockerDashboard.Domain.Identity.ApplicationUser", "LastModifiedByUser")
                        .WithMany()
                        .HasForeignKey("LastModifiedBy")
                        .HasConstraintName("fk_asp_net_users_asp_net_users_last_modified_by");

                    b.HasOne("IZ.DockerDashboard.Domain.Identity.ApplicationUser", "Superior")
                        .WithMany()
                        .HasForeignKey("SuperiorId")
                        .HasConstraintName("fk_asp_net_users_asp_net_users_superior_id");

                    b.Navigation("CreatedByUser");

                    b.Navigation("LastModifiedByUser");

                    b.Navigation("Superior");
                });

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Identity.ApplicationUserClaim", b =>
                {
                    b.HasOne("IZ.DockerDashboard.Domain.Identity.ApplicationUser", "User")
                        .WithMany("UserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_user_claims_asp_net_users_user_id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Identity.ApplicationUserLogin", b =>
                {
                    b.HasOne("IZ.DockerDashboard.Domain.Identity.ApplicationUser", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_user_logins_asp_net_users_user_id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Identity.ApplicationUserRole", b =>
                {
                    b.HasOne("IZ.DockerDashboard.Domain.Identity.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_user_roles_asp_net_roles_role_id");

                    b.HasOne("IZ.DockerDashboard.Domain.Identity.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_user_roles_asp_net_users_user_id");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Identity.ApplicationUserToken", b =>
                {
                    b.HasOne("IZ.DockerDashboard.Domain.Identity.ApplicationUser", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_asp_net_user_tokens_asp_net_users_user_id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Identity.ApplicationRole", b =>
                {
                    b.Navigation("RoleClaims");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("IZ.DockerDashboard.Domain.Identity.ApplicationUser", b =>
                {
                    b.Navigation("Logins");

                    b.Navigation("Tokens");

                    b.Navigation("UserClaims");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
