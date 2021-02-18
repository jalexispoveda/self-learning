using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Data.Mentoring.Models
{
    public partial class CEA8Context : DbContext
    {
        public CEA8Context()
        {
        }

        public CEA8Context(DbContextOptions<CEA8Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-JD8S44H;Database=CEA8;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Area>(entity =>
            {
                entity.Property(e => e.AreaId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.Name, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => new { e.Email, e.Id }, "IX_Users_Email_Id");

                entity.HasIndex(e => e.FirstName, "IX_Users_FirstName");

                entity.HasIndex(e => e.Email, "UserEmailIndex")
                    .IsUnique();

                entity.HasIndex(e => e.UserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(200);

                entity.Property(e => e.LastName).HasMaxLength(200);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId, "IX_RoleId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AssessmentQuestion>(entity =>
            {
                entity.HasKey(e => new { e.AssessmentTemplateId, e.QuestionView });

                entity.HasIndex(e => e.AssessmentTemplateId, "IX_AssessmentQuestions_AssessmentTemplateId");

                entity.Property(e => e.QuestionView).HasMaxLength(32);

                entity.Property(e => e.QuestionTitle)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.AssessmentTemplate)
                    .WithMany(p => p.AssessmentQuestions)
                    .HasForeignKey(d => d.AssessmentTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssessmentQuestions_AssessmentTemplates");
            });

            modelBuilder.Entity<AssessmentTemplate>(entity =>
            {
                entity.Property(e => e.AssessmentTemplateId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<Buregion>(entity =>
            {
                entity.ToTable("BURegions");

                entity.Property(e => e.BuregionId).HasColumnName("BURegionId");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasIndex(e => e.CountryId, "IX_CountryId");

                entity.HasIndex(e => e.EmployeeRangeId, "IX_EmployeeRangeId");

                entity.HasIndex(e => e.GeographicRegionId, "IX_GeographicRegionId");

                entity.HasIndex(e => e.IndustryId, "IX_IndustryId");

                entity.HasIndex(e => e.AreaId, "IX_RegionId");

                entity.HasIndex(e => e.RevenueRangeId, "IX_RevenueRangeId");

                entity.Property(e => e.CompanyLogoUrl).HasMaxLength(200);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EnableBuregion).HasColumnName("EnableBURegion");

                entity.Property(e => e.RouteValue).HasMaxLength(200);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_dbo.Companies_dbo.Areas_AreaId");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_dbo.Companies_dbo.Countries_CountryId");

                entity.HasOne(d => d.EmployeeRange)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.EmployeeRangeId)
                    .HasConstraintName("FK_dbo.Companies_dbo.EmployeeRanges_EmployeeRangeId");

                entity.HasOne(d => d.GeographicRegion)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.GeographicRegionId)
                    .HasConstraintName("FK_dbo.Companies_dbo.GeographicRegions_GeographicRegionId");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.IndustryId)
                    .HasConstraintName("FK_dbo.Companies_dbo.Industries_IndustryId");

                entity.HasOne(d => d.RevenueRange)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.RevenueRangeId)
                    .HasConstraintName("FK_dbo.Companies_dbo.RevenueRanges_RevenueRangeId");
            });

            modelBuilder.Entity<CompanyDesiredTrait>(entity =>
            {
                entity.HasKey(e => e.DesiredTraitId)
                    .HasName("PK_dbo.CompanyDesiredTraits");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyId");

                entity.Property(e => e.BaselineValue).HasColumnType("numeric(18, 1)");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.DesiredValue).HasColumnType("numeric(18, 1)");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyDesiredTraits)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.CompanyDesiredTraits_dbo.Companies_CompanyId");
            });

            modelBuilder.Entity<CompanyExecutive>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyId");

                entity.HasIndex(e => e.ExecutiveId, "IX_ExecutiveId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyExecutives)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.CompanyExecutives_dbo.Companies_CompanyId");

                entity.HasOne(d => d.Executive)
                    .WithMany(p => p.CompanyExecutives)
                    .HasForeignKey(d => d.ExecutiveId)
                    .HasConstraintName("FK_dbo.CompanyExecutives_dbo.Executives_ExecutiveId");
            });

            modelBuilder.Entity<CompanyFunction>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyId");

                entity.HasIndex(e => e.FunctionId, "IX_FunctionId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyFunctions)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.CompanyFunctions_dbo.Companies_CompanyId");

                entity.HasOne(d => d.Function)
                    .WithMany(p => p.CompanyFunctions)
                    .HasForeignKey(d => d.FunctionId)
                    .HasConstraintName("FK_dbo.CompanyFunctions_dbo.Functions_FunctionId");
            });

            modelBuilder.Entity<CompanyInvitation>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.InvitationMessage).IsRequired();

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyInvitations)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.CompanyInvitations_dbo.Companies_CompanyId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CompanyInvitations)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.CompanyInvitations_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<CompanyLanguage>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.Locale })
                    .HasName("PK_dbo.CompanyLanguages");

                entity.Property(e => e.Locale).HasMaxLength(10);

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyLanguages)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.CompanyLanguages_dbo.Companies_CompanyId");
            });

            modelBuilder.Entity<CompanyLevel>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyId");

                entity.HasIndex(e => e.LevelId, "IX_LevelId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyLevels)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.CompanyLevels_dbo.Companies_CompanyId");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.CompanyLevels)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("FK_dbo.CompanyLevels_dbo.Levels_LevelId");
            });

            modelBuilder.Entity<CompanySubFunction>(entity =>
            {
                entity.HasIndex(e => e.CompanyFunctionId, "IX_CompanyFunctionId");

                entity.HasOne(d => d.CompanyFunction)
                    .WithMany(p => p.CompanySubFunctions)
                    .HasForeignKey(d => d.CompanyFunctionId)
                    .HasConstraintName("FK_dbo.CompanySubFunctions_dbo.CompanyFunctions_CompanyFunctionId");
            });

            modelBuilder.Entity<CompanyTrait>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyId");

                entity.HasIndex(e => new { e.TraitId, e.IsPositive }, "IX_TraitId_IsPositive");

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyTraits)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.CompanyTraits_dbo.Companies_CompanyId");

                entity.HasOne(d => d.Trait)
                    .WithMany(p => p.CompanyTraits)
                    .HasForeignKey(d => new { d.TraitId, d.IsPositive })
                    .HasConstraintName("FK_dbo.CompanyTraits_dbo.Traits_TraitId_IsPositive");
            });

            modelBuilder.Entity<CompanyValue>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyValues)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.CompanyValues_dbo.Companies_CompanyId");
            });

            modelBuilder.Entity<Consultant>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_dbo.Consultants");

                entity.HasIndex(e => e.LevelId, "IX_LevelId");

                entity.HasIndex(e => e.ServiceLineId, "IX_ServiceLineId");

                entity.HasIndex(e => e.SubServiceLineId, "IX_SubServiceLineId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.Consultants)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("FK_dbo.Consultants_dbo.Levels_LevelId");

                entity.HasOne(d => d.ServiceLine)
                    .WithMany(p => p.Consultants)
                    .HasForeignKey(d => d.ServiceLineId)
                    .HasConstraintName("FK_dbo.Consultants_dbo.ServiceLines_ServiceLineId");

                entity.HasOne(d => d.SubServiceLine)
                    .WithMany(p => p.Consultants)
                    .HasForeignKey(d => d.SubServiceLineId)
                    .HasConstraintName("FK_dbo.Consultants_dbo.SubServiceLines_SubServiceLineId");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Consultant)
                    .HasForeignKey<Consultant>(d => d.UserId)
                    .HasConstraintName("FK_dbo.Consultants_dbo.AspNetUsers_User_Id");
            });

            modelBuilder.Entity<ConsultantCompany>(entity =>
            {
                entity.HasKey(e => new { e.ConsultantId, e.CompanyId })
                    .HasName("PK_dbo.ConsultantCompanies");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyId");

                entity.HasIndex(e => e.ConsultantId, "IX_ConsultantId");

                entity.Property(e => e.ConsultantId).HasMaxLength(128);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ConsultantCompanies)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.ConsultantCompanies_dbo.Companies_CompanyId");

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.ConsultantCompanies)
                    .HasForeignKey(d => d.ConsultantId)
                    .HasConstraintName("FK_dbo.ConsultantCompanies_dbo.Consultants_ConsultantId");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasIndex(e => e.AreaId, "IX_RegionId");

                entity.Property(e => e.CountryId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_dbo.Countries_dbo.Areas_AreaId");
            });

            modelBuilder.Entity<ElmahError>(entity =>
            {
                entity.HasKey(e => e.ErrorId);

                entity.ToTable("ELMAH_Error");

                entity.HasIndex(e => new { e.Application, e.TimeUtc, e.Sequence }, "IX_ELMAH_Error_App_Time_Seq");

                entity.Property(e => e.ErrorId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AllXml)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Sequence).ValueGeneratedOnAdd();

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TimeUtc).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeRange>(entity =>
            {
                entity.Property(e => e.EmployeeRangeId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<Function>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasIndex(e => e.GenderGenderId, "IX_Gender_GenderId");

                entity.Property(e => e.GenderId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.GenderGenderId).HasColumnName("Gender_GenderId");

                entity.HasOne(d => d.GenderGender)
                    .WithMany(p => p.InverseGenderGender)
                    .HasForeignKey(d => d.GenderGenderId)
                    .HasConstraintName("FK_dbo.Genders_dbo.Genders_Gender_GenderId");
            });

            modelBuilder.Entity<Generation>(entity =>
            {
                entity.Property(e => e.GenerationId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<Geography>(entity =>
            {
                entity.Property(e => e.GeographyId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<Industry>(entity =>
            {
                entity.Property(e => e.IndustryId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<Locale>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.Property(e => e.Name).HasMaxLength(10);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UrlFlag).HasMaxLength(100);
            });

            modelBuilder.Entity<LocalizedDesiredTrait>(entity =>
            {
                entity.HasKey(e => e.LocalizedDesiredTraitsId)
                    .HasName("PK_dbo.LocalizedDesiredTraits");

                entity.HasIndex(e => new { e.DesiredTraitId, e.Locale }, "IX_DesiredTraitWithLocale")
                    .IsUnique();

                entity.Property(e => e.LocalizedDesiredTraitsId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.DesiredTrait)
                    .WithMany(p => p.LocalizedDesiredTraits)
                    .HasForeignKey(d => d.DesiredTraitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocalizedDesiredTraits_CompanyDesiredTraits_id");
            });

            modelBuilder.Entity<LocalizedQuestion>(entity =>
            {
                entity.HasIndex(e => e.QuestionId, "IX_QuestionId");

                entity.Property(e => e.LocalizedQuestionId).ValueGeneratedNever();

                entity.HasOne(d => d.QuestionNavigation)
                    .WithMany(p => p.LocalizedQuestions)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.LocalizedQuestions_dbo.SurveyQuestions_QuestionId");
            });

            modelBuilder.Entity<LocalizedString>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Locale })
                    .HasName("PK_dbo.LocalizedStrings");

                entity.HasIndex(e => e.Locale, "IX_LocalizedStrings_Locale");

                entity.Property(e => e.Key).HasMaxLength(128);

                entity.Property(e => e.Locale).HasMaxLength(128);

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'App')");
            });

            modelBuilder.Entity<LocalizedTrait>(entity =>
            {
                entity.HasKey(e => e.LocalizedTraitsId)
                    .HasName("PK_dbo.LocalizedTraits");

                entity.HasIndex(e => new { e.CompanyTraitId, e.Locale }, "IX_TraitWithLocale")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Trait)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CompanyTrait)
                    .WithMany(p => p.LocalizedTraits)
                    .HasForeignKey(d => d.CompanyTraitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocalizedTraits_CompanyTraits_id");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.Property(e => e.ModuleId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<Objective>(entity =>
            {
                entity.Property(e => e.ObjectiveId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<Onaemployee>(entity =>
            {
                entity.ToTable("ONAEmployees");

                entity.HasIndex(e => e.WaveId, "IX_ONAEmployees_WaveId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BuregionId).HasColumnName("BURegionId");

                entity.Property(e => e.FirstName).HasMaxLength(64);

                entity.Property(e => e.LastName).HasMaxLength(64);
            });

            modelBuilder.Entity<Password>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Passwords)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Passwords_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<Priority>(entity =>
            {
                entity.Property(e => e.PriorityId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<ReportViewer>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_dbo.ReportViewers");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ReportViewers)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.ReportViewers_dbo.Companies_CompanyId");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.ReportViewer)
                    .HasForeignKey<ReportViewer>(d => d.UserId)
                    .HasConstraintName("FK_dbo.ReportViewers_dbo.AspNetUsers_User_Id");
            });

            modelBuilder.Entity<ReportViewerArea>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.AreaId })
                    .HasName("PK_dbo.ReportViewerAreas");

                entity.HasIndex(e => e.AreaId, "IX_AreaId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.ReportViewerAreas)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_dbo.ReportViewerAreas_dbo.Areas_AreaId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportViewerAreas)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ReportViewerAreas_dbo.ReportViewers_UserId");
            });

            modelBuilder.Entity<ReportViewerBuregion>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.BuregionId })
                    .HasName("PK_dbo.ReportViewerBURegions");

                entity.ToTable("ReportViewerBURegions");

                entity.HasIndex(e => e.BuregionId, "IX_BURegionId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.BuregionId).HasColumnName("BURegionId");

                entity.HasOne(d => d.Buregion)
                    .WithMany(p => p.ReportViewerBuregions)
                    .HasForeignKey(d => d.BuregionId)
                    .HasConstraintName("FK_dbo.ReportViewerBURegions_dbo.BURegions_BURegionId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportViewerBuregions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ReportViewerBURegions_dbo.ReportViewers_UserId");
            });

            modelBuilder.Entity<ReportViewerCountry>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CountryId })
                    .HasName("PK_dbo.ReportViewerCountries");

                entity.HasIndex(e => e.CountryId, "IX_CountryId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ReportViewerCountries)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_dbo.ReportViewerCountries_dbo.Countries_CountryId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportViewerCountries)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ReportViewerCountries_dbo.ReportViewers_UserId");
            });

            modelBuilder.Entity<ReportViewerExecutive>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ExecutiveId })
                    .HasName("PK_dbo.ReportViewerExecutives");

                entity.HasIndex(e => e.ExecutiveId, "IX_ExecutiveId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Executive)
                    .WithMany(p => p.ReportViewerExecutives)
                    .HasForeignKey(d => d.ExecutiveId)
                    .HasConstraintName("FK_dbo.ReportViewerExecutives_dbo.Executives_ExecutiveId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportViewerExecutives)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ReportViewerExecutives_dbo.ReportViewers_UserId");
            });

            modelBuilder.Entity<ReportViewerFunction>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.FunctionId })
                    .HasName("PK_dbo.ReportViewerFunctions");

                entity.HasIndex(e => e.FunctionId, "IX_FunctionId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Function)
                    .WithMany(p => p.ReportViewerFunctions)
                    .HasForeignKey(d => d.FunctionId)
                    .HasConstraintName("FK_dbo.ReportViewerFunctions_dbo.Functions_FunctionId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportViewerFunctions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ReportViewerFunctions_dbo.ReportViewers_UserId");
            });

            modelBuilder.Entity<ReportViewerGender>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.GenderId })
                    .HasName("PK_dbo.ReportViewerGenders");

                entity.HasIndex(e => e.GenderId, "IX_GenderId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.ReportViewerGenders)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_dbo.ReportViewerGenders_dbo.Genders_GenderId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportViewerGenders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ReportViewerGenders_dbo.ReportViewers_UserId");
            });

            modelBuilder.Entity<ReportViewerGeneration>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.GenerationId })
                    .HasName("PK_dbo.ReportViewerGenerations");

                entity.HasIndex(e => e.GenerationId, "IX_GenerationId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.ReportViewerGenerations)
                    .HasForeignKey(d => d.GenerationId)
                    .HasConstraintName("FK_dbo.ReportViewerGenerations_dbo.Generations_GenerationId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportViewerGenerations)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ReportViewerGenerations_dbo.ReportViewers_UserId");
            });

            modelBuilder.Entity<ReportViewerGeographicRegion>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.GeographicRegionId })
                    .HasName("PK_dbo.ReportViewerGeographicRegions");

                entity.HasIndex(e => e.GeographicRegionId, "IX_GeographicRegionId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.GeographicRegion)
                    .WithMany(p => p.ReportViewerGeographicRegions)
                    .HasForeignKey(d => d.GeographicRegionId)
                    .HasConstraintName("FK_dbo.ReportViewerGeographicRegions_dbo.GeographicRegions_GeographicRegionId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportViewerGeographicRegions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ReportViewerGeographicRegions_dbo.ReportViewers_UserId");
            });

            modelBuilder.Entity<ReportViewerJobLevel>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LevelId })
                    .HasName("PK_dbo.ReportViewerJobLevels");

                entity.HasIndex(e => e.LevelId, "IX_LevelId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.ReportViewerJobLevels)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("FK_dbo.ReportViewerJobLevels_dbo.Levels_LevelId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportViewerJobLevels)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ReportViewerJobLevels_dbo.ReportViewers_UserId");
            });

            modelBuilder.Entity<ReportViewerPulseReport>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ReportId })
                    .HasName("PK_dbo.ReportViewerPulseReports");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportViewerPulseReports)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ReportViewerPulseReports_dbo.ReportViewers_UserId");
            });

            modelBuilder.Entity<ReportViewerReport>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ReportId })
                    .HasName("PK_dbo.ReportViewerReports");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportViewerReports)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ReportViewerReports_dbo.ReportViewers_UserId");
            });

            modelBuilder.Entity<ReportViewerSubFunction>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.SubFunctionId })
                    .HasName("PK_dbo.ReportViewerSubFunctions");

                entity.HasIndex(e => e.SubFunctionId, "IX_SubFunctionId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.SubFunction)
                    .WithMany(p => p.ReportViewerSubFunctions)
                    .HasForeignKey(d => d.SubFunctionId)
                    .HasConstraintName("FK_dbo.ReportViewerSubFunctions_dbo.CompanySubFunctions_SubFunctionId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportViewerSubFunctions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ReportViewerSubFunctions_dbo.ReportViewers_UserId");
            });

            modelBuilder.Entity<ReportViewerTenure>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.TenureId })
                    .HasName("PK_dbo.ReportViewerTenures");

                entity.HasIndex(e => e.TenureId, "IX_TenureId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.Tenure)
                    .WithMany(p => p.ReportViewerTenures)
                    .HasForeignKey(d => d.TenureId)
                    .HasConstraintName("FK_dbo.ReportViewerTenures_dbo.Tenures_TenureId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportViewerTenures)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ReportViewerTenures_dbo.ReportViewers_UserId");
            });

            modelBuilder.Entity<ReportViewerWave>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.WaveId })
                    .HasName("PK_dbo.ReportViewerWaves");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.HasIndex(e => e.WaveId, "IX_WaveId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportViewerWaves)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.ReportViewerWaves_dbo.ReportViewers_UserId");

                entity.HasOne(d => d.Wave)
                    .WithMany(p => p.ReportViewerWaves)
                    .HasForeignKey(d => d.WaveId)
                    .HasConstraintName("FK_dbo.ReportViewerWaves_dbo.Waves_WaveId");
            });

            modelBuilder.Entity<Respondent>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_dbo.Respondents");

                entity.HasIndex(e => e.BuregionId, "IX_BURegionId");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyId");

                entity.HasIndex(e => e.CompanySubFunctionId, "IX_CompanySubFunctionId");

                entity.HasIndex(e => e.CountryId, "IX_CountryId");

                entity.HasIndex(e => e.ExecutiveId, "IX_ExecutiveId");

                entity.HasIndex(e => e.FunctionId, "IX_FunctionId");

                entity.HasIndex(e => e.GenderId, "IX_GenderId");

                entity.HasIndex(e => e.GenerationId, "IX_GenerationId");

                entity.HasIndex(e => e.GeographicRegionId, "IX_GeographicRegionId");

                entity.HasIndex(e => e.LevelId, "IX_LevelId");

                entity.HasIndex(e => e.AreaId, "IX_RegionId");

                entity.HasIndex(e => new { e.CompanyId, e.BuregionId }, "IX_Respondents_CompanyId_BURegionId");

                entity.HasIndex(e => new { e.CompanyId, e.CountryId }, "IX_Respondents_CompanyId_CountryId");

                entity.HasIndex(e => new { e.CompanyId, e.ExecutiveId }, "IX_Respondents_CompanyId_ExecutiveId");

                entity.HasIndex(e => new { e.CompanyId, e.ExecutiveId }, "IX_Respondents_CompanyId_ExecutiveId_WithData");

                entity.HasIndex(e => e.CompanyId, "IX_Respondents_CompanyId_Full");

                entity.HasIndex(e => new { e.CompanyId, e.GeographicRegionId }, "IX_Respondents_CompanyId_GeographicRegionId");

                entity.HasIndex(e => new { e.UserId, e.CompanyId }, "IX_Respondents_UserId_CompanyId");

                entity.HasIndex(e => e.TenureId, "IX_TenureId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.BuregionId).HasColumnName("BURegionId");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Respondents)
                    .HasForeignKey(d => d.AreaId)
                    .HasConstraintName("FK_dbo.Respondents_dbo.Areas_AreaId");

                entity.HasOne(d => d.Buregion)
                    .WithMany(p => p.Respondents)
                    .HasForeignKey(d => d.BuregionId)
                    .HasConstraintName("FK_dbo.Respondents_dbo.BURegions_BURegionId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Respondents)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Respondents_dbo.Companies_CompanyId");

                entity.HasOne(d => d.CompanySubFunction)
                    .WithMany(p => p.Respondents)
                    .HasForeignKey(d => d.CompanySubFunctionId)
                    .HasConstraintName("FK_dbo.Respondents_dbo.CompanySubFunctions_CompanySubFunctionId");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Respondents)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_dbo.Respondents_dbo.Countries_CountryId");

                entity.HasOne(d => d.Executive)
                    .WithMany(p => p.Respondents)
                    .HasForeignKey(d => d.ExecutiveId)
                    .HasConstraintName("FK_dbo.Respondents_dbo.Executives_ExecutiveId");

                entity.HasOne(d => d.Function)
                    .WithMany(p => p.Respondents)
                    .HasForeignKey(d => d.FunctionId)
                    .HasConstraintName("FK_dbo.Respondents_dbo.Functions_FunctionId");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Respondents)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_dbo.Respondents_dbo.Genders_GenderId");

                entity.HasOne(d => d.Generation)
                    .WithMany(p => p.Respondents)
                    .HasForeignKey(d => d.GenerationId)
                    .HasConstraintName("FK_dbo.Respondents_dbo.Generations_GenerationId");

                entity.HasOne(d => d.GeographicRegion)
                    .WithMany(p => p.Respondents)
                    .HasForeignKey(d => d.GeographicRegionId)
                    .HasConstraintName("FK_dbo.Respondents_dbo.GeographicRegions_GeographicRegionId");

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.Respondents)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("FK_dbo.Respondents_dbo.Levels_LevelId");

                entity.HasOne(d => d.Tenure)
                    .WithMany(p => p.Respondents)
                    .HasForeignKey(d => d.TenureId)
                    .HasConstraintName("FK_dbo.Respondents_dbo.Tenures_TenureId");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Respondent)
                    .HasForeignKey<Respondent>(d => d.UserId)
                    .HasConstraintName("FK_dbo.Respondents_dbo.AspNetUsers_User_Id");
            });

            modelBuilder.Entity<RevenueRange>(entity =>
            {
                entity.Property(e => e.RevenueRangeId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<ScriptsHistory>(entity =>
            {
                entity.HasKey(e => e.ScriptNameId)
                    .HasName("PK__ScriptsH__7C02A22F383EA6A2");

                entity.ToTable("ScriptsHistory");

                entity.Property(e => e.ScriptNameId).HasMaxLength(255);

                entity.Property(e => e.DatabaseName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ServiceLine>(entity =>
            {
                entity.Property(e => e.ServiceLineId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<SubServiceLine>(entity =>
            {
                entity.HasIndex(e => e.ServiceLineId, "IX_ServiceLineId");

                entity.Property(e => e.SubServiceLineId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.HasOne(d => d.ServiceLine)
                    .WithMany(p => p.SubServiceLines)
                    .HasForeignKey(d => d.ServiceLineId)
                    .HasConstraintName("FK_dbo.SubServiceLines_dbo.ServiceLines_ServiceLineId");
            });

            modelBuilder.Entity<SurveyAnswer>(entity =>
            {
                entity.HasIndex(e => e.QuestionId, "IX_QuestionId");

                entity.HasIndex(e => e.QuestionId, "IX_SurveyAnswers_QuestionId");

                entity.HasIndex(e => e.WaveId, "IX_SurveyAnswers_WaveId");

                entity.HasIndex(e => new { e.WaveId, e.QuestionId }, "IX_SurveyAnswers_WaveId_QuestionId");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.HasIndex(e => e.WaveId, "IX_WaveId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Na).HasColumnName("NA");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.SurveyAnswers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SurveyAnswers_dbo.SurveyQuestions_QuestionId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SurveyAnswers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.SurveyAnswers_dbo.AspNetUsers_UserId");

                entity.HasOne(d => d.Wave)
                    .WithMany(p => p.SurveyAnswers)
                    .HasForeignKey(d => d.WaveId)
                    .HasConstraintName("FK_dbo.SurveyAnswers_dbo.Waves_WaveId");
            });

            modelBuilder.Entity<SurveyData>(entity =>
            {
                entity.HasIndex(e => new { e.IsSurveyComplete, e.CompletionDate }, "IX_SurveyDatas_IsSurveyComplete_CompletionDate");

                entity.HasIndex(e => e.IsSurveyComplete, "IX_SurveyDatas_IsSurveyComplete_Full");

                entity.HasIndex(e => new { e.IsSurveyComplete, e.IsBenchmark }, "IX_SurveyDatas_IsSurveyComplete_IsBenchmark");

                entity.HasIndex(e => e.WaveId, "IX_SurveyDatas_IsSurveyComplete_WaveId");

                entity.HasIndex(e => new { e.IsSurveyComplete, e.WaveId, e.SurveyDataId }, "IX_SurveyDatas_IsSurveyComplete_WaveId_SurveyDataId");

                entity.HasIndex(e => e.IsSurveyComplete, "IX_SurveyDatas_IsSurveyComplete_WithData");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.HasIndex(e => e.WaveId, "IX_WaveId");

                entity.Property(e => e.Q101).HasColumnName("Q10_1");

                entity.Property(e => e.Q102).HasColumnName("Q10_2");

                entity.Property(e => e.Q111).HasColumnName("Q11_1");

                entity.Property(e => e.Q112).HasColumnName("Q11_2");

                entity.Property(e => e.Q121).HasColumnName("Q12_1");

                entity.Property(e => e.Q122).HasColumnName("Q12_2");

                entity.Property(e => e.Q131).HasColumnName("Q13_1");

                entity.Property(e => e.Q132).HasColumnName("Q13_2");

                entity.Property(e => e.Q133).HasColumnName("Q13_3");

                entity.Property(e => e.Q134).HasColumnName("Q13_4");

                entity.Property(e => e.Q135).HasColumnName("Q13_5");

                entity.Property(e => e.Q141).HasColumnName("Q14_1");

                entity.Property(e => e.Q1410).HasColumnName("Q14_10");

                entity.Property(e => e.Q142).HasColumnName("Q14_2");

                entity.Property(e => e.Q143).HasColumnName("Q14_3");

                entity.Property(e => e.Q144).HasColumnName("Q14_4");

                entity.Property(e => e.Q145).HasColumnName("Q14_5");

                entity.Property(e => e.Q146).HasColumnName("Q14_6");

                entity.Property(e => e.Q147).HasColumnName("Q14_7");

                entity.Property(e => e.Q148).HasColumnName("Q14_8");

                entity.Property(e => e.Q149).HasColumnName("Q14_9");

                entity.Property(e => e.Q151).HasColumnName("Q15_1");

                entity.Property(e => e.Q1510).HasColumnName("Q15_10");

                entity.Property(e => e.Q152).HasColumnName("Q15_2");

                entity.Property(e => e.Q153).HasColumnName("Q15_3");

                entity.Property(e => e.Q154).HasColumnName("Q15_4");

                entity.Property(e => e.Q155).HasColumnName("Q15_5");

                entity.Property(e => e.Q156).HasColumnName("Q15_6");

                entity.Property(e => e.Q157).HasColumnName("Q15_7");

                entity.Property(e => e.Q158).HasColumnName("Q15_8");

                entity.Property(e => e.Q159).HasColumnName("Q15_9");

                entity.Property(e => e.Q161).HasColumnName("Q16_1");

                entity.Property(e => e.Q162).HasColumnName("Q16_2");

                entity.Property(e => e.Q163).HasColumnName("Q16_3");

                entity.Property(e => e.Q164).HasColumnName("Q16_4");

                entity.Property(e => e.Q165).HasColumnName("Q16_5");

                entity.Property(e => e.Q181).HasColumnName("Q18_1");

                entity.Property(e => e.Q182).HasColumnName("Q18_2");

                entity.Property(e => e.Q183).HasColumnName("Q18_3");

                entity.Property(e => e.Q184).HasColumnName("Q18_4");

                entity.Property(e => e.Q185).HasColumnName("Q18_5");

                entity.Property(e => e.Q186).HasColumnName("Q18_6");

                entity.Property(e => e.Q187).HasColumnName("Q18_7");

                entity.Property(e => e.Q191).HasColumnName("Q19_1");

                entity.Property(e => e.Q1910).HasColumnName("Q19_10");

                entity.Property(e => e.Q192).HasColumnName("Q19_2");

                entity.Property(e => e.Q193).HasColumnName("Q19_3");

                entity.Property(e => e.Q194).HasColumnName("Q19_4");

                entity.Property(e => e.Q195).HasColumnName("Q19_5");

                entity.Property(e => e.Q196).HasColumnName("Q19_6");

                entity.Property(e => e.Q197).HasColumnName("Q19_7");

                entity.Property(e => e.Q198).HasColumnName("Q19_8");

                entity.Property(e => e.Q199).HasColumnName("Q19_9");

                entity.Property(e => e.Q21).HasColumnName("Q2_1");

                entity.Property(e => e.Q210).HasColumnName("Q2_10");

                entity.Property(e => e.Q211).HasColumnName("Q2_11");

                entity.Property(e => e.Q2111).HasColumnName("Q21_1");

                entity.Property(e => e.Q212).HasColumnName("Q2_12");

                entity.Property(e => e.Q2121).HasColumnName("Q21_2");

                entity.Property(e => e.Q213).HasColumnName("Q21_3");

                entity.Property(e => e.Q214).HasColumnName("Q21_4");

                entity.Property(e => e.Q215).HasColumnName("Q21_5");

                entity.Property(e => e.Q216).HasColumnName("Q21_6");

                entity.Property(e => e.Q217).HasColumnName("Q21_7");

                entity.Property(e => e.Q22).HasColumnName("Q2_2");

                entity.Property(e => e.Q221).HasColumnName("Q22");

                entity.Property(e => e.Q23).HasColumnName("Q2_3");

                entity.Property(e => e.Q231).HasColumnName("Q23_1");

                entity.Property(e => e.Q232).HasColumnName("Q23_2");

                entity.Property(e => e.Q24).HasColumnName("Q2_4");

                entity.Property(e => e.Q25).HasColumnName("Q2_5");

                entity.Property(e => e.Q26).HasColumnName("Q2_6");

                entity.Property(e => e.Q27).HasColumnName("Q2_7");

                entity.Property(e => e.Q28).HasColumnName("Q2_8");

                entity.Property(e => e.Q29).HasColumnName("Q2_9");

                entity.Property(e => e.Q3a1).HasColumnName("Q3A_1");

                entity.Property(e => e.Q3a2).HasColumnName("Q3A_2");

                entity.Property(e => e.Q3a3).HasColumnName("Q3A_3");

                entity.Property(e => e.Q3a4).HasColumnName("Q3A_4");

                entity.Property(e => e.Q3a5).HasColumnName("Q3A_5");

                entity.Property(e => e.Q3b1).HasColumnName("Q3B_1");

                entity.Property(e => e.Q3b2).HasColumnName("Q3B_2");

                entity.Property(e => e.Q3b3).HasColumnName("Q3B_3");

                entity.Property(e => e.Q3b4).HasColumnName("Q3B_4");

                entity.Property(e => e.Q3b5).HasColumnName("Q3B_5");

                entity.Property(e => e.Q41).HasColumnName("Q4_1");

                entity.Property(e => e.Q42).HasColumnName("Q4_2");

                entity.Property(e => e.Q43).HasColumnName("Q4_3");

                entity.Property(e => e.Q44).HasColumnName("Q4_4");

                entity.Property(e => e.Q45).HasColumnName("Q4_5");

                entity.Property(e => e.Q46).HasColumnName("Q4_6");

                entity.Property(e => e.Q51).HasColumnName("Q5_1");

                entity.Property(e => e.Q52).HasColumnName("Q5_2");

                entity.Property(e => e.Q53).HasColumnName("Q5_3");

                entity.Property(e => e.Q54).HasColumnName("Q5_4");

                entity.Property(e => e.Q55).HasColumnName("Q5_5");

                entity.Property(e => e.Q61).HasColumnName("Q6_1");

                entity.Property(e => e.Q62).HasColumnName("Q6_2");

                entity.Property(e => e.Q63).HasColumnName("Q6_3");

                entity.Property(e => e.Q64).HasColumnName("Q6_4");

                entity.Property(e => e.Q65).HasColumnName("Q6_5");

                entity.Property(e => e.Q7a1).HasColumnName("Q7A_1");

                entity.Property(e => e.Q7a2).HasColumnName("Q7A_2");

                entity.Property(e => e.Q7a3).HasColumnName("Q7A_3");

                entity.Property(e => e.Q7a4).HasColumnName("Q7A_4");

                entity.Property(e => e.Q7a5).HasColumnName("Q7A_5");

                entity.Property(e => e.Q7b1).HasColumnName("Q7B_1");

                entity.Property(e => e.Q7b2).HasColumnName("Q7B_2");

                entity.Property(e => e.Q7b3).HasColumnName("Q7B_3");

                entity.Property(e => e.Q7b4).HasColumnName("Q7B_4");

                entity.Property(e => e.Q7b5).HasColumnName("Q7B_5");

                entity.Property(e => e.Q81).HasColumnName("Q8_1");

                entity.Property(e => e.Q82).HasColumnName("Q8_2");

                entity.Property(e => e.Q83).HasColumnName("Q8_3");

                entity.Property(e => e.Q84).HasColumnName("Q8_4");

                entity.Property(e => e.Q85).HasColumnName("Q8_5");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SurveyData)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.SurveyDatas_dbo.AspNetUsers_UserId");

                entity.HasOne(d => d.Wave)
                    .WithMany(p => p.SurveyData)
                    .HasForeignKey(d => d.WaveId)
                    .HasConstraintName("FK_dbo.SurveyDatas_dbo.Waves_WaveId");
            });

            modelBuilder.Entity<SurveyQuestion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.QuestionView)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Tenure>(entity =>
            {
                entity.Property(e => e.TenureId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<Trait>(entity =>
            {
                entity.HasKey(e => new { e.TraitId, e.IsPositive })
                    .HasName("PK_dbo.Traits");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description).HasMaxLength(30);
            });

            modelBuilder.Entity<Wave>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyId");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.WaveTag).HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Waves)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Waves_dbo.Companies_CompanyId");
            });

            modelBuilder.Entity<WaveModule>(entity =>
            {
                entity.HasIndex(e => e.WaveId, "IX_WaveId");
            });

            modelBuilder.Entity<WaveUser>(entity =>
            {
                entity.HasKey(e => new { e.WaveId, e.UserId })
                    .HasName("PK_dbo.WaveUsers");

                entity.HasIndex(e => e.UserId, "IX_UserId");

                entity.HasIndex(e => e.WaveId, "IX_WaveId");

                entity.HasIndex(e => new { e.WaveId, e.IsReportViewer }, "missing_index_49_48");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WaveUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.WaveUsers_dbo.AspNetUsers_UserId");

                entity.HasOne(d => d.Wave)
                    .WithMany(p => p.WaveUsers)
                    .HasForeignKey(d => d.WaveId)
                    .HasConstraintName("FK_dbo.WaveUsers_dbo.Waves_WaveId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
