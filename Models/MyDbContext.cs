using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RTMilenial.Models
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnggotaKeluarga> AnggotaKeluarga { get; set; }
        public virtual DbSet<KepalaKeluarga> KepalaKeluarga { get; set; }
        public virtual DbSet<MasterAgama> MasterAgama { get;set; }
        public virtual DbSet<MasterHubunganDalamKeluarga> MasterHubunganDalamKeluarga {get;set;}
        public virtual DbSet<MasterPendidikan> MasterPendidikan {get;set;}
        public virtual DbSet<MasterJenisPekerjaan> MasterJenisPekerjaan {get;set;}
        public virtual DbSet<MasterStatusPerkawinan> MasterStatusPerkawinan {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;port=3306;user=UserApps;password=R4h4s14y4h;database=rtmilenialdb", x => x.ServerVersion("10.4.11-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnggotaKeluarga>(entity =>
            {
                entity.HasKey(e => new { e.NoKk, e.NoUrut })
                    .HasName("PRIMARY");

                entity.Property(e => e.NoKk)
                    .HasColumnName("NoKK")
                    .HasColumnType("char(16)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NoUrut).HasColumnType("int(11)");

                entity.Property(e => e.Agama)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AuditActivity)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'I'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AuditTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.AuditUserName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Ayah)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HubunganDalamKeluarga)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Ibu)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.JenisKelamin)
                    .IsRequired()
                    .HasColumnType("char(9)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.JenisPekerjaan)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Kawarganegaraan)
                    .IsRequired()
                    .HasColumnType("char(3)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NamaLengkap)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Nik)
                    .IsRequired()
                    .HasColumnName("NIK")
                    .HasColumnType("char(16)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NoKitas)
                    .HasColumnType("char(16)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NoPaspor)
                    .HasColumnType("char(16)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Pendidikan)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StatusPerkawinan)
                    .IsRequired()
                    .HasColumnType("varchar(12)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TanggalLahir)
                    .IsRequired()
                    .HasColumnType("datetime")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TempatLahir)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasOne(d => d.NoKkNavigation)
                    .WithMany(p => p.AnggotaKeluarga)
                    .HasForeignKey(d => d.NoKk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("NoKK_KepalaKeluarga");
            });

            modelBuilder.Entity<KepalaKeluarga>(entity =>
            {
                entity.HasKey(e => e.NoKk)
                    .HasName("PRIMARY");

                entity.Property(e => e.NIK)
                    .HasColumnName("NIK")
                    .HasColumnType("char(16)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NoKk)
                    .HasColumnName("NoKK")
                    .HasColumnType("char(16)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Alamat)
                    .IsRequired()
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AuditActivity)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'I'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AuditTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.AuditUserName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DesaKelurahan)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.KabupatenKota)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Kecamatan)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.KodePos)
                    .IsRequired()
                    .HasColumnType("char(6)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.NamaKk)
                    .IsRequired()
                    .HasColumnName("NamaKK")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Provinsi)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Rtrw)
                    .IsRequired()
                    .HasColumnName("RTRW")
                    .HasColumnType("char(12)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<MasterAgama>(entity => 
            {
                entity.HasKey(e => e.Agama)
                    .HasName("PRIMARY");

                entity.Property(e => e.Agama)
                    .HasColumnName("Agama")
                    .HasColumnType("char(14)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AgamaDescription)
                    .HasColumnName("AgamaDescription")
                    .HasColumnType("char(16)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("OrderNo")
                    .HasColumnType("int")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AuditActivity)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'I'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AuditTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.AuditUserName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<MasterHubunganDalamKeluarga>(entity =>
            {
                entity.HasKey(e => e.HubunganDalamKeluarga)
                .HasName("PRIMARY");

                entity.Property(e => e.HubunganDalamKeluarga)
                    .HasColumnName("HubunganDalamKeluarga")
                    .HasColumnType("char(30)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HubunganDalamKeluargaDescription)
                    .HasColumnName("HubunganDalamKeluargaDescription")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("OrderNo")
                    .HasColumnType("int")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AuditActivity)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'I'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AuditTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.AuditUserName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<MasterPendidikan>(entity =>
            {
                entity.HasKey(e => e.Pendidikan)
                .HasName("PRIMARY");

                entity.Property(e => e.Pendidikan)
                    .HasColumnName("Pendidikan")
                    .HasColumnType("char(50)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PendidikanDescription)
                    .HasColumnName("PendidikanDescription")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("OrderNo")
                    .HasColumnType("int")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AuditActivity)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'I'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AuditTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.AuditUserName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<MasterJenisPekerjaan>(entity =>
            {
                entity.HasKey(e => e.JenisPekerjaan)
                .HasName("PRIMARY");

                entity.Property(e => e.JenisPekerjaan)
                    .HasColumnName("JenisPekerjaan")
                    .HasColumnType("char(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.JenisPekerjaanDescription)
                    .HasColumnName("JenisPekerjaanDescription")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("OrderNo")
                    .HasColumnType("int")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AuditActivity)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'I'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AuditTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.AuditUserName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<MasterStatusPerkawinan>(entity =>
            {
                entity.HasKey(e => e.StatusPerkawinan)
                .HasName("PRIMARY");

                entity.Property(e => e.StatusPerkawinan)
                    .HasColumnName("StatusPerkawinan")
                    .HasColumnType("char(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StatusPerkawinanDescription)
                    .HasColumnName("StatusPerkawinanDescription")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OrderNo)
                    .HasColumnName("OrderNo")
                    .HasColumnType("int")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AuditActivity)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'I'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AuditTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.AuditUserName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
