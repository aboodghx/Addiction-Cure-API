using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Addiction_Cure.core.Data
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aboutusac> Aboutusacs { get; set; }
        public virtual DbSet<Bankac> Bankacs { get; set; }
        public virtual DbSet<Categoryac> Categoryacs { get; set; }
        public virtual DbSet<Contactusac> Contactusacs { get; set; }
        public virtual DbSet<Dictorac> Dictoracs { get; set; }
        public virtual DbSet<Homepageac> Homepageacs { get; set; }
        public virtual DbSet<Loginac> Loginacs { get; set; }
        public virtual DbSet<Patientac> Patientacs { get; set; }
        public virtual DbSet<Paymentac> Paymentacs { get; set; }
        public virtual DbSet<Quastionsac> Quastionsacs { get; set; }
        public virtual DbSet<Req> Reqs { get; set; }
        public virtual DbSet<Resulttsetac> Resulttsetacs { get; set; }
        public virtual DbSet<Roleac> Roleacs { get; set; }
        public virtual DbSet<Testac> Testacs { get; set; }
        public virtual DbSet<Testemonialac> Testemonialacs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("USER ID=JOR15_User69;PASSWORD=Test321;DATA SOURCE=94.56.229.181:3488/traindb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("JOR15_USER69")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<Aboutusac>(entity =>
            {
                entity.ToTable("ABOUTUSAC");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Image)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE");

                entity.Property(e => e.Paragraph1)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH1");

                entity.Property(e => e.Paragraph2)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH2");

                entity.Property(e => e.Paragraph3)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH3");
            });

            modelBuilder.Entity<Bankac>(entity =>
            {
                entity.HasKey(e => e.Bankid)
                    .HasName("SYS_C00325198");

                entity.ToTable("BANKAC");

                entity.HasIndex(e => e.Cardnumper, "SYS_C00325199")
                    .IsUnique();

                entity.Property(e => e.Bankid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BANKID");

                entity.Property(e => e.Amount)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Cardnumper)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CARDNUMPER");

                entity.Property(e => e.Cvv)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CVV");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<Categoryac>(entity =>
            {
                entity.HasKey(e => e.Categoryid)
                    .HasName("SYS_C00325167");

                entity.ToTable("CATEGORYAC");

                entity.Property(e => e.Categoryid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CATEGORYID");

                entity.Property(e => e.Abouttext)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("ABOUTTEXT");

                entity.Property(e => e.Categoryname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORYNAME");

                entity.Property(e => e.Image)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE");
            });

            modelBuilder.Entity<Contactusac>(entity =>
            {
                entity.HasKey(e => e.Contactid)
                    .HasName("SYS_C00325194");

                entity.ToTable("CONTACTUSAC");

                entity.Property(e => e.Contactid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CONTACTID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Mesg)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("MESG");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phone)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PHONE");

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SUBJECT");
            });

            modelBuilder.Entity<Dictorac>(entity =>
            {
                entity.HasKey(e => e.Doctodid)
                    .HasName("SYS_C00326668");

                entity.ToTable("DICTORAC");

                entity.Property(e => e.Doctodid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DOCTODID");

                entity.Property(e => e.Categoryid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CATEGORYID");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Imagename)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IMAGENAME");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Level1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LEVEL1");

                entity.Property(e => e.Loginid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOGINID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Dictoracs)
                    .HasForeignKey(d => d.Categoryid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("CAT_FK");

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.Dictoracs)
                    .HasForeignKey(d => d.Loginid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("LG_FK");
            });

            modelBuilder.Entity<Homepageac>(entity =>
            {
                entity.HasKey(e => e.Homeid)
                    .HasName("SYS_C00325211");

                entity.ToTable("HOMEPAGEAC");

                entity.Property(e => e.Homeid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HOMEID");

                entity.Property(e => e.Address)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Image1)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE1");

                entity.Property(e => e.Image2)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE2");

                entity.Property(e => e.Logo)
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasColumnName("LOGO");

                entity.Property(e => e.Paragraph)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH");

                entity.Property(e => e.Phone)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PHONE");

                entity.Property(e => e.Text1)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("TEXT1");
            });

            modelBuilder.Entity<Loginac>(entity =>
            {
                entity.HasKey(e => e.Loginid)
                    .HasName("SYS_C00325172");

                entity.ToTable("LOGINAC");

                entity.HasIndex(e => e.Username, "SYS_C00325173")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "SYS_C00325174")
                    .IsUnique();

                entity.Property(e => e.Loginid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LOGINID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Loginacs)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("R1_FK");
            });

            modelBuilder.Entity<Patientac>(entity =>
            {
                entity.HasKey(e => e.Patientid)
                    .HasName("SYS_C00326680");

                entity.ToTable("PATIENTAC");

                entity.Property(e => e.Patientid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PATIENTID");

                entity.Property(e => e.Categoryid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CATEGORYID");

                entity.Property(e => e.Doctodid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DOCTODID");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FIRSTNAME");

                entity.Property(e => e.Imagename)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IMAGENAME");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Level1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LEVEL1");

                entity.Property(e => e.Loginid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("LOGINID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Patientacs)
                    .HasForeignKey(d => d.Categoryid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("CAT1_FK");

                entity.HasOne(d => d.Doctod)
                    .WithMany(p => p.Patientacs)
                    .HasForeignKey(d => d.Doctodid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("D_FK");

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.Patientacs)
                    .HasForeignKey(d => d.Loginid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("LP1_FK");
            });

            modelBuilder.Entity<Paymentac>(entity =>
            {
                entity.HasKey(e => e.Paymentid)
                    .HasName("SYS_C00326747");

                entity.ToTable("PAYMENTAC");

                entity.Property(e => e.Paymentid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PAYMENTID");

                entity.Property(e => e.Amount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.Patientid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PATIENTID");

                entity.Property(e => e.Paydate)
                    .HasColumnType("DATE")
                    .HasColumnName("PAYDATE");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Paymentacs)
                    .HasForeignKey(d => d.Patientid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("PPAY_FK");
            });

            modelBuilder.Entity<Quastionsac>(entity =>
            {
                entity.HasKey(e => e.Quastionid)
                    .HasName("SYS_C00326685");

                entity.ToTable("QUASTIONSAC");

                entity.Property(e => e.Quastionid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("QUASTIONID");

                entity.Property(e => e.Categoryid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CATEGORYID");

                entity.Property(e => e.Quastion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("QUASTION");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Quastionsacs)
                    .HasForeignKey(d => d.Categoryid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("CAT2_FK");
            });

            modelBuilder.Entity<Req>(entity =>
            {
                entity.ToTable("REQ");

                entity.Property(e => e.Reqid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REQID");

                entity.Property(e => e.Doctorid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DOCTORID");

                entity.Property(e => e.Patientid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PATIENTID");

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<Resulttsetac>(entity =>
            {
                entity.HasKey(e => e.Resulttestid)
                    .HasName("SYS_C00326743");

                entity.ToTable("RESULTTSETAC");

                entity.Property(e => e.Resulttestid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RESULTTESTID");

                entity.Property(e => e.Datetest)
                    .HasColumnType("DATE")
                    .HasColumnName("DATETEST");

                entity.Property(e => e.Description)
                    .HasMaxLength(700)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Numberoftest)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMBEROFTEST");

                entity.Property(e => e.Patientid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PATIENTID");

                entity.Property(e => e.Perioddate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PERIODDATE");

                entity.Property(e => e.Resulttest)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RESULTTEST");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Resulttsetacs)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("PAT2_FK");
            });

            modelBuilder.Entity<Roleac>(entity =>
            {
                entity.HasKey(e => e.Roleid)
                    .HasName("SYS_C00325165");

                entity.ToTable("ROLEAC");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Rolename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<Testac>(entity =>
            {
                entity.HasKey(e => e.Testid)
                    .HasName("SYS_C00326688");

                entity.ToTable("TESTAC");

                entity.Property(e => e.Testid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TESTID");

                entity.Property(e => e.Patientid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PATIENTID");

                entity.Property(e => e.Quastionid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("QUASTIONID");

                entity.Property(e => e.Status)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("STATUS");

                entity.Property(e => e.TestNumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TESTNUMBER");

                entity.Property(e => e.Testdate)
                    .HasColumnType("DATE")
                    .HasColumnName("TESTDATE");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Testacs)
                    .HasForeignKey(d => d.Patientid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("PAT_FK");

                entity.HasOne(d => d.Quastion)
                    .WithMany(p => p.Testacs)
                    .HasForeignKey(d => d.Quastionid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("QUA_FK");
            });

            modelBuilder.Entity<Testemonialac>(entity =>
            {
                entity.HasKey(e => e.Tesemonialid)
                    .HasName("SYS_C00326735");

                entity.ToTable("TESTEMONIALAC");

                entity.Property(e => e.Tesemonialid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TESEMONIALID");

                entity.Property(e => e.Messageuser)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGEUSER");

                entity.Property(e => e.Patientid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PATIENTID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Testemonialacs)
                    .HasForeignKey(d => d.Patientid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("PP_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
