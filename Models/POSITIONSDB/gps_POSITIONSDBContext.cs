using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PRO_001.Models.POSITIONSDB
{
    public partial class gps_POSITIONSDBContext : DbContext
    {
        public gps_POSITIONSDBContext()
        {
        }

        public gps_POSITIONSDBContext(DbContextOptions<gps_POSITIONSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblLastPosWebApi> TblLastPosWebApi { get; set; }
        public virtual DbSet<TblPositionsLast> TblPositionsLast { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=192.168.33.20\\CENTINELA;Database=gps_POSITIONSDB;Trusted_Connection=False;User ID=sa;Password=ADMINED03");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblLastPosWebApi>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Objectuid })
                    .HasName("PK__tbl__Tom__3213E83F30F848ED_copy1");

                entity.ToTable("tbl__lastPOS__webAPI", "grp__TomTom");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Objectuid)
                    .HasColumnName("objectuid")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CodriverCurrentworkstate).HasColumnName("codriver_currentworkstate");

                entity.Property(e => e.Course).HasColumnName("course");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.DriverCurrentworkstate).HasColumnName("driver_currentworkstate");

                entity.Property(e => e.FechahoraInsert)
                    .HasColumnName("fechahora_insert")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechahoraRecepcion)
                    .HasColumnName("fechahora_recepcion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fuellevel).HasColumnName("fuellevel");

                entity.Property(e => e.Ignition).HasColumnName("ignition");

                entity.Property(e => e.IgnitionTime)
                    .HasColumnName("ignition_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastmsgid)
                    .HasColumnName("lastmsgid")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.LatitudeMdeg)
                    .HasColumnName("latitude_mdeg")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.LongitudeMdeg)
                    .HasColumnName("longitude_mdeg")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.Msgtime)
                    .HasColumnName("msgtime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Objectclassname)
                    .HasColumnName("objectclassname")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Objectname)
                    .HasColumnName("objectname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Objectno)
                    .HasColumnName("objectno")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Objecttype)
                    .HasColumnName("objecttype")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Odometer).HasColumnName("odometer");

                entity.Property(e => e.Pndconn).HasColumnName("pndconn");

                entity.Property(e => e.PosTime)
                    .HasColumnName("pos_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Postext)
                    .HasColumnName("postext")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostextShort)
                    .HasColumnName("postext_short")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.Standstill).HasColumnName("standstill");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StatusGuardian)
                    .HasColumnName("status_Guardian")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tripmode).HasColumnName("tripmode");
            });

            modelBuilder.Entity<TblPositionsLast>(entity =>
            {
                entity.HasKey(e => new { e.DeviceEco, e.DeviceId })
                    .HasName("PK__tbl__POS__3213E83F4CA06362");

                entity.ToTable("tbl__POSITIONS_last");

                entity.Property(e => e.DeviceEco)
                    .HasColumnName("device_ECO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasColumnName("device_ID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceClass)
                    .HasColumnName("device_CLASS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceProveedor)
                    .HasColumnName("device_PROVEEDOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechahoraUpdate)
                    .HasColumnName("fechahora_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.PosAngulo).HasColumnName("pos_ANGULO");

                entity.Property(e => e.PosCombistiblenivel)
                    .HasColumnName("pos_COMBISTIBLENIVEL")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.PosDireccion)
                    .HasColumnName("pos_DIRECCION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PosFechahora)
                    .HasColumnName("pos_FECHAHORA")
                    .HasColumnType("datetime");

                entity.Property(e => e.PosIgnicion).HasColumnName("pos_IGNICION");

                entity.Property(e => e.PosLatitud).HasColumnName("pos_LATITUD");

                entity.Property(e => e.PosLogitud).HasColumnName("pos_LOGITUD");

                entity.Property(e => e.PosOdometro)
                    .HasColumnName("pos_ODOMETRO")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.PosVelocidad)
                    .HasColumnName("pos_VELOCIDAD")
                    .HasColumnType("numeric(38, 0)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
