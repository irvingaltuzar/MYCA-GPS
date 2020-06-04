using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PRO_001.Models
{
    public partial class erp_MYCADBContext : DbContext
    {
        public erp_MYCADBContext()
        {
        }

        public erp_MYCADBContext(DbContextOptions<erp_MYCADBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdmonDepartamentos> AdmonDepartamentos { get; set; }
        public virtual DbSet<AdmonPerfiles> AdmonPerfiles { get; set; }
        public virtual DbSet<AdmonTelFijos> AdmonTelFijos { get; set; }
        public virtual DbSet<AdmonTelMoviles> AdmonTelMoviles { get; set; }
        public virtual DbSet<GeneralEntidades> GeneralEntidades { get; set; }
        public virtual DbSet<GeneralLocalidades> GeneralLocalidades { get; set; }
        public virtual DbSet<GeneralMunicipios> GeneralMunicipios { get; set; }
        public virtual DbSet<MonConsolaUsuariosWeb> MonConsolaUsuariosWeb { get; set; }
        public virtual DbSet<RhCategoria> RhCategoria { get; set; }
        public virtual DbSet<RhContratos> RhContratos { get; set; }
        public virtual DbSet<RhCuentasBancos> RhCuentasBancos { get; set; }
        public virtual DbSet<RhPensionAlimenticia> RhPensionAlimenticia { get; set; }
        public virtual DbSet<RhPersonalAdmon> RhPersonalAdmon { get; set; }
        public virtual DbSet<RhSeguroPersonal> RhSeguroPersonal { get; set; }
        public virtual DbSet<SaludImssAdmon> SaludImssAdmon { get; set; }
        public virtual DbSet<TblCasetas> TblCasetas { get; set; }
        public virtual DbSet<TblCasetasTarifas> TblCasetasTarifas { get; set; }
        public virtual DbSet<TblClientes> TblClientes { get; set; }
        public virtual DbSet<TblConvenios> TblConvenios { get; set; }
        public virtual DbSet<TblConveniosConceptos> TblConveniosConceptos { get; set; }
        public virtual DbSet<TblConveniosProductos> TblConveniosProductos { get; set; }
        public virtual DbSet<TblFlotillas> TblFlotillas { get; set; }
        public virtual DbSet<TblGpsAsignacion> TblGpsAsignacion { get; set; }
        public virtual DbSet<TblGpsLocalizadores> TblGpsLocalizadores { get; set; }
        public virtual DbSet<TblGpsMantenimiento> TblGpsMantenimiento { get; set; }
        public virtual DbSet<TblIncidenciaPerfil> TblIncidenciaPerfil { get; set; }
        public virtual DbSet<TblMovilesAsignacionCelulares> TblMovilesAsignacionCelulares { get; set; }
        public virtual DbSet<TblMovilesCuentasPadre> TblMovilesCuentasPadre { get; set; }
        public virtual DbSet<TblMovilesEquipos> TblMovilesEquipos { get; set; }
        public virtual DbSet<TblMovilesLineasTiusa> TblMovilesLineasTiusa { get; set; }
        public virtual DbSet<TblMovilesPlanes> TblMovilesPlanes { get; set; }
        public virtual DbSet<TblMovilesSims> TblMovilesSims { get; set; }
        public virtual DbSet<TblNotasCargoPerfil> TblNotasCargoPerfil { get; set; }
        public virtual DbSet<TblPerfiles> TblPerfiles { get; set; }
        public virtual DbSet<TblPlazas> TblPlazas { get; set; }
        public virtual DbSet<TblPlazasGeoreferencia> TblPlazasGeoreferencia { get; set; }
        public virtual DbSet<TblRutas> TblRutas { get; set; }
        public virtual DbSet<TblRutasCasetas> TblRutasCasetas { get; set; }
        public virtual DbSet<TblRutasDestinos> TblRutasDestinos { get; set; }
        public virtual DbSet<TblUniAsignacionIave> TblUniAsignacionIave { get; set; }
        public virtual DbSet<TblUniFotografia> TblUniFotografia { get; set; }
        public virtual DbSet<TblUniGestoria> TblUniGestoria { get; set; }
        public virtual DbSet<TblUniIaves> TblUniIaves { get; set; }
        public virtual DbSet<TblUniImagenes> TblUniImagenes { get; set; }
        public virtual DbSet<TblUniMttoOdometro> TblUniMttoOdometro { get; set; }
        public virtual DbSet<TblUniMttoTractores> TblUniMttoTractores { get; set; }
        public virtual DbSet<TblUniTipoUnidad> TblUniTipoUnidad { get; set; }
        public virtual DbSet<TblUnidades> TblUnidades { get; set; }
        public virtual DbSet<TblZonas> TblZonas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=192.168.33.12\\CENTINELA;Initial Catalog=erp_MYCADB;User ID=sa;Password=ADMINED03");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdmonDepartamentos>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento)
                    .HasName("PK__ADMON_DE__64F37A162E70E1FD");

                entity.ToTable("ADMON_DEPARTAMENTOS", "grp__ADMINISTRACION");

                entity.Property(e => e.IdDepartamento).HasColumnName("id_departamento");

                entity.Property(e => e.NombreDepto)
                    .IsRequired()
                    .HasColumnName("nombre_depto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdmonPerfiles>(entity =>
            {
                entity.HasKey(e => e.IdPerfil)
                    .HasName("PK__ADMON_PE__1D1C8768324172E1");

                entity.ToTable("ADMON_PERFILES", "grp__ADMINISTRACION");

                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");

                entity.Property(e => e.IdDepartamento).HasColumnName("id_departamento");

                entity.Property(e => e.NombrePerfil)
                    .HasColumnName("nombre_perfil")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.AdmonPerfiles)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKADMON_PERF523630");
            });

            modelBuilder.Entity<AdmonTelFijos>(entity =>
            {
                entity.HasKey(e => e.IdTelefonoPersonal)
                    .HasName("PK__ADMON_TE__030F0053477199F1");

                entity.ToTable("ADMON_TEL_FIJOS", "grp__ADMINISTRACION");

                entity.Property(e => e.IdTelefonoPersonal).HasColumnName("id_telefono_personal");

                entity.Property(e => e.IdPersonalAdmon).HasColumnName("id_personal_admon");

                entity.Property(e => e.NoTelefono)
                    .IsRequired()
                    .HasColumnName("no_telefono")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPersonalAdmonNavigation)
                    .WithMany(p => p.AdmonTelFijos)
                    .HasForeignKey(d => d.IdPersonalAdmon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKADMON_TEL_88241");
            });

            modelBuilder.Entity<AdmonTelMoviles>(entity =>
            {
                entity.HasKey(e => e.IdTelMovil)
                    .HasName("PK__ADMON_TE__39AFC6214B422AD5");

                entity.ToTable("ADMON_TEL_MOVILES", "grp__ADMINISTRACION");

                entity.Property(e => e.IdTelMovil).HasColumnName("id_tel_movil");

                entity.Property(e => e.IdPersonalAdmon).HasColumnName("id_personal_admon");

                entity.Property(e => e.NoMovil)
                    .IsRequired()
                    .HasColumnName("no_movil")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPersonalAdmonNavigation)
                    .WithMany(p => p.AdmonTelMoviles)
                    .HasForeignKey(d => d.IdPersonalAdmon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKADMON_TEL_595508");
            });

            modelBuilder.Entity<GeneralEntidades>(entity =>
            {
                entity.HasKey(e => e.CveEnt)
                    .HasName("pk_cve_ent");

                entity.ToTable("general_ENTIDADES", "grp__OPERACIONES_TRAFICO");

                entity.Property(e => e.CveEnt)
                    .HasColumnName("CVE_ENT")
                    .ValueGeneratedNever();

                entity.Property(e => e.NomAbr)
                    .HasColumnName("NOM_ABR")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomAbrLis)
                    .HasColumnName("NOM_ABR_LIS")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NomEnt)
                    .HasColumnName("NOM_ENT")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GeneralLocalidades>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("general_LOCALIDADES", "grp__OPERACIONES_TRAFICO");

                entity.Property(e => e.Altitud)
                    .HasColumnName("ALTITUD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ambito)
                    .HasColumnName("AMBITO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CveEnt).HasColumnName("CVE_ENT");

                entity.Property(e => e.CveLoc).HasColumnName("CVE_LOC");

                entity.Property(e => e.CveMun).HasColumnName("CVE_MUN");

                entity.Property(e => e.LatDec)
                    .HasColumnName("LAT_DEC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LonDec)
                    .HasColumnName("LON_DEC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomLoc)
                    .HasColumnName("NOM_LOC")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GeneralMunicipios>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("general_MUNICIPIOS", "grp__OPERACIONES_TRAFICO");

                entity.Property(e => e.CveEnt).HasColumnName("CVE_ENT");

                entity.Property(e => e.CveMun).HasColumnName("CVE_MUN");

                entity.Property(e => e.NomMun)
                    .HasColumnName("NOM_MUN")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MonConsolaUsuariosWeb>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK_ACORP_USUARIOS_WEB_1");

                entity.ToTable("mon__CONSOLA_USUARIOS_WEB", "grp__CORE");

                entity.HasIndex(e => e.IdUser)
                    .HasName("IX_ACORP_USUARIOS_WEB");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Cliente)
                    .HasColumnName("cliente")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasColumnName("correo")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExtLogo)
                    .HasColumnName("ext_logo")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifica)
                    .HasColumnName("fecha_modifica")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUltimoAcceso)
                    .HasColumnName("fecha_ultimo_acceso")
                    .HasColumnType("datetime");

                entity.Property(e => e.Logo).HasColumnName("logo");

                entity.Property(e => e.NombreCompleto)
                    .HasColumnName("nombre_completo")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Pass)
                    .HasColumnName("pass")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RhCategoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__RH_CATEG__CD54BC5A370627FE");

                entity.ToTable("RH_CATEGORIA", "grp__RECURSOSHUMANOS");

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasColumnName("categoria")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RhContratos>(entity =>
            {
                entity.HasKey(e => e.IdRec)
                    .HasName("PK__RH_CONTR__6ABE6F084F12BBB9");

                entity.ToTable("RH_CONTRATOS", "grp__RECURSOSHUMANOS");

                entity.Property(e => e.IdRec).HasColumnName("id_rec");

                entity.Property(e => e.Antiguedad).HasColumnName("antiguedad");

                entity.Property(e => e.CausaAlta)
                    .IsRequired()
                    .HasColumnName("causa_alta")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CausaBaja)
                    .IsRequired()
                    .HasColumnName("causa_baja")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DiasVacaciones).HasColumnName("dias_vacaciones");

                entity.Property(e => e.EstadoFechaMantemiento)
                    .HasColumnName("estado_fecha_mantemiento")
                    .HasColumnType("date");

                entity.Property(e => e.EstadoFechaMonitoreo)
                    .HasColumnName("estado_fecha_monitoreo")
                    .HasColumnType("date");

                entity.Property(e => e.EstadoFechaOperaciones)
                    .HasColumnName("estado_fecha_operaciones")
                    .HasColumnType("date");

                entity.Property(e => e.EstadoFechaRecHum)
                    .HasColumnName("estado_fecha_rec_hum")
                    .HasColumnType("date");

                entity.Property(e => e.EstadoFechaSeguridad)
                    .HasColumnName("estado_fecha_seguridad")
                    .HasColumnType("date");

                entity.Property(e => e.EstadoFechaSistemas)
                    .HasColumnName("estado_fecha_sistemas")
                    .HasColumnType("date");

                entity.Property(e => e.EstadoFechaTrafico)
                    .HasColumnName("estado_fecha_trafico")
                    .HasColumnType("date");

                entity.Property(e => e.EstadoMantenimiento)
                    .IsRequired()
                    .HasColumnName("estado_mantenimiento")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoMonitoreo)
                    .IsRequired()
                    .HasColumnName("estado_monitoreo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoOperaciones)
                    .IsRequired()
                    .HasColumnName("estado_operaciones")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoRecHum)
                    .IsRequired()
                    .HasColumnName("estado_rec_hum")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoSeguridad)
                    .IsRequired()
                    .HasColumnName("estado_seguridad")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoSistemas)
                    .IsRequired()
                    .HasColumnName("estado_sistemas")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoTrafico)
                    .IsRequired()
                    .HasColumnName("estado_trafico")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja)
                    .HasColumnName("fecha_baja")
                    .HasColumnType("date");

                entity.Property(e => e.FechaIniVacaciones)
                    .HasColumnName("fecha_ini_vacaciones")
                    .HasColumnType("date");

                entity.Property(e => e.FechaVenceLic)
                    .HasColumnName("fecha_vence_lic")
                    .HasColumnType("date");

                entity.Property(e => e.FechaVenceMedPreven)
                    .HasColumnName("fecha_vence_med_preven")
                    .HasColumnType("date");

                entity.Property(e => e.IdPersonalAdmon).HasColumnName("id_personal_admon");

                entity.Property(e => e.LicCategoria)
                    .IsRequired()
                    .HasColumnName("lic_categoria")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicTipoCarga)
                    .IsRequired()
                    .HasColumnName("lic_tipo_carga")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoLicencia)
                    .IsRequired()
                    .HasColumnName("no_licencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoMedicinaPreventiva)
                    .IsRequired()
                    .HasColumnName("no_medicina_preventiva")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoRecConfiable)
                    .IsRequired()
                    .HasColumnName("no_rec_confiable")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionAlta)
                    .IsRequired()
                    .HasColumnName("observacion_alta")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionesBaja)
                    .IsRequired()
                    .HasColumnName("observaciones_baja")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RecConfiable)
                    .IsRequired()
                    .HasColumnName("rec_confiable")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusGral)
                    .IsRequired()
                    .HasColumnName("status_gral")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TallaCamisa)
                    .IsRequired()
                    .HasColumnName("talla_camisa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TallaPantalon)
                    .IsRequired()
                    .HasColumnName("talla_pantalon")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TallaZapatos)
                    .IsRequired()
                    .HasColumnName("talla_zapatos")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoContrato)
                    .IsRequired()
                    .HasColumnName("tipo_contrato")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPersonalAdmonNavigation)
                    .WithMany(p => p.RhContratos)
                    .HasForeignKey(d => d.IdPersonalAdmon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKRH_CONTRAT50201");
            });

            modelBuilder.Entity<RhCuentasBancos>(entity =>
            {
                entity.HasKey(e => e.IdCuentaBanco)
                    .HasName("PK__RH_CUENT__DACCCEB57BE56230");

                entity.ToTable("RH_CUENTAS_BANCOS", "grp__RECURSOSHUMANOS");

                entity.Property(e => e.IdCuentaBanco).HasColumnName("id_cuenta_banco");

                entity.Property(e => e.AdmonCuentaBancos)
                    .IsRequired()
                    .HasColumnName("admon_cuenta_bancos")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApeMaternoTitular)
                    .IsRequired()
                    .HasColumnName("ape_materno_titular")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApePaternoTitular)
                    .IsRequired()
                    .HasColumnName("ape_paterno_titular")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPersonalAdmon).HasColumnName("id_personal_admon");

                entity.Property(e => e.NombreTitular)
                    .IsRequired()
                    .HasColumnName("nombre_titular")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCuenta)
                    .IsRequired()
                    .HasColumnName("status_cuenta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCuenta)
                    .IsRequired()
                    .HasColumnName("tipo_cuenta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitularCuenta)
                    .IsRequired()
                    .HasColumnName("titular_cuenta")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RhPensionAlimenticia>(entity =>
            {
                entity.HasKey(e => e.IdPensionPersonal)
                    .HasName("PK__RH_PENSI__093F068968D28DBC");

                entity.ToTable("RH_PENSION_ALIMENTICIA", "grp__RECURSOSHUMANOS");

                entity.Property(e => e.IdPensionPersonal).HasColumnName("id_pension_personal");

                entity.Property(e => e.IdPersonalAdmon).HasColumnName("id_personal_admon");

                entity.Property(e => e.NoCuenta)
                    .HasColumnName("no_cuenta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PensionAlimApeMaterno)
                    .HasColumnName("pension_alim_ape_materno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PensionAlimApePaterno)
                    .HasColumnName("pension_alim_ape_paterno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PensionAlimNombre)
                    .HasColumnName("pension_alim_nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PensionPorcentaje).HasColumnName("pension_porcentaje");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPersonalAdmonNavigation)
                    .WithMany(p => p.RhPensionAlimenticia)
                    .HasForeignKey(d => d.IdPersonalAdmon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKRH_PENSION298583");
            });

            modelBuilder.Entity<RhPersonalAdmon>(entity =>
            {
                entity.HasKey(e => e.IdPersonalAdmon)
                    .HasName("PK__RH_PERSO__3F7B9ABE52E34C9D");

                entity.ToTable("RH_PERSONAL_ADMON", "grp__RECURSOSHUMANOS");

                entity.Property(e => e.IdPersonalAdmon).HasColumnName("id_personal_admon");

                entity.Property(e => e.AdmonImagen)
                    .IsRequired()
                    .HasColumnName("admon_imagen")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApeMaterno)
                    .IsRequired()
                    .HasColumnName("ape_materno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApePaterno)
                    .IsRequired()
                    .HasColumnName("ape_paterno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasColumnName("calle")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col)
                    .IsRequired()
                    .HasColumnName("col")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cp)
                    .IsRequired()
                    .HasColumnName("cp")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasColumnName("curp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DescFonacot).HasColumnName("desc_fonacot");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoCivil)
                    .IsRequired()
                    .HasColumnName("estado_civil")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNac)
                    .HasColumnName("fecha_nac")
                    .HasColumnType("date");

                entity.Property(e => e.FechaUsuarioIngresa)
                    .HasColumnName("fecha_usuario_ingresa")
                    .HasColumnType("date");

                entity.Property(e => e.FechaUsuarioModifica)
                    .HasColumnName("fecha_usuario_modifica")
                    .HasColumnType("date");

                entity.Property(e => e.Fonacot)
                    .IsRequired()
                    .HasColumnName("fonacot")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");

                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");

                entity.Property(e => e.InfoDescFijo).HasColumnName("info_desc_fijo");

                entity.Property(e => e.InfoDescPorcentaje).HasColumnName("info_desc_porcentaje");

                entity.Property(e => e.InfoDescVsm).HasColumnName("info_desc_vsm");

                entity.Property(e => e.Infonavit)
                    .IsRequired()
                    .HasColumnName("infonavit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LugarNacimiento)
                    .IsRequired()
                    .HasColumnName("lugar_nacimiento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasColumnName("municipio")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nip)
                    .IsRequired()
                    .HasColumnName("nip")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NivelEscolar)
                    .IsRequired()
                    .HasColumnName("nivel_escolar")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoExt)
                    .IsRequired()
                    .HasColumnName("no_ext")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoHijos).HasColumnName("no_hijos");

                entity.Property(e => e.NoInt)
                    .IsRequired()
                    .HasColumnName("no_int")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomConyuge)
                    .IsRequired()
                    .HasColumnName("nom_conyuge")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreMadre)
                    .IsRequired()
                    .HasColumnName("nombre_madre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePadre)
                    .IsRequired()
                    .HasColumnName("nombre_padre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasColumnName("pais")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasColumnName("referencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasColumnName("rfc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasColumnName("sexo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIngresa)
                    .IsRequired()
                    .HasColumnName("usuario_ingresa")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModifica)
                    .HasColumnName("usuario_modifica")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Visa)
                    .IsRequired()
                    .HasColumnName("visa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.RhPersonalAdmon)
                    .HasForeignKey(d => d.IdPerfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKRH_PERSONA178831");
            });

            modelBuilder.Entity<RhSeguroPersonal>(entity =>
            {
                entity.HasKey(e => e.IdSeguroPersonal)
                    .HasName("PK__RH_SEGUR__0C1669E17814D14C");

                entity.ToTable("RH_SEGURO_PERSONAL", "grp__RECURSOSHUMANOS");

                entity.Property(e => e.IdSeguroPersonal).HasColumnName("id_seguro_personal");

                entity.Property(e => e.BeneficiarioApeMaterno)
                    .HasColumnName("beneficiario_ape_materno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioApePaterno)
                    .HasColumnName("beneficiario_ape_paterno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioNombre)
                    .HasColumnName("beneficiario_nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPersonalAdmon).HasColumnName("id_personal_admon");

                entity.Property(e => e.NoInciso)
                    .HasColumnName("no_inciso")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoSeguro)
                    .HasColumnName("no_seguro")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Parentesco)
                    .HasColumnName("parentesco")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeguroPorcentaje).HasColumnName("seguro_porcentaje");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SaludImssAdmon>(entity =>
            {
                entity.HasKey(e => e.IdImssPersonal)
                    .HasName("PK__SALUD_IM__63B6EA767FB5F314");

                entity.ToTable("SALUD_IMSS_ADMON", "grp__RECURSOSHUMANOS");

                entity.Property(e => e.IdImssPersonal).HasColumnName("id_imss_personal");

                entity.Property(e => e.Alergias)
                    .HasColumnName("alergias")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionClinica)
                    .HasColumnName("direccion_clinica")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Enfermedades)
                    .HasColumnName("enfermedades")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoSalud)
                    .HasColumnName("estado_salud")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPersonalAdmon).HasColumnName("id_personal_admon");

                entity.Property(e => e.NoClinica)
                    .HasColumnName("no_clinica")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoImss)
                    .HasColumnName("no_imss")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Psicofisica)
                    .HasColumnName("psicofisica")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSangre)
                    .HasColumnName("tipo_sangre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCasetas>(entity =>
            {
                entity.HasKey(e => e.IdCaseta)
                    .HasName("PK__trfco__C__6AD3C5E70E04126B");

                entity.ToTable("tbl__CASETAS", "grp__OPERACIONES_TRAFICO");

                entity.Property(e => e.IdCaseta).HasColumnName("id_caseta");

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVO')");

                entity.Property(e => e.FechaActualizado)
                    .HasColumnName("fecha_actualizado")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifico)
                    .HasColumnName("fecha_modifico")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iave)
                    .HasColumnName("IAVE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IdCasetaLis).HasColumnName("id_caseta_lis");

                entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");

                entity.Property(e => e.Latitud)
                    .HasColumnName("latitud")
                    .HasColumnType("decimal(18, 12)");

                entity.Property(e => e.Longitud)
                    .HasColumnName("longitud")
                    .HasColumnType("decimal(18, 12)");

                entity.Property(e => e.MontoFijo)
                    .HasColumnName("monto_fijo")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIngreso)
                    .HasColumnName("usuario_ingreso")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModifico)
                    .HasColumnName("usuario_modifico")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCasetasTarifas>(entity =>
            {
                entity.HasKey(e => e.IdTarifa)
                    .HasName("PK__trfco__C__747D038914B10FFA");

                entity.ToTable("tbl__CASETAS_TARIFAS", "grp__OPERACIONES_TRAFICO");

                entity.Property(e => e.IdTarifa).HasColumnName("id_tarifa");

                entity.Property(e => e.IdCaseta).HasColumnName("id_caseta");

                entity.Property(e => e.IdTarifaLis).HasColumnName("id_tarifa_lis");

                entity.Property(e => e.MontoIave)
                    .HasColumnName("monto_IAVE")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.MontoTarifa)
                    .HasColumnName("monto_tarifa")
                    .HasColumnType("decimal(10, 6)");

                entity.Property(e => e.NoEjes).HasColumnName("no_ejes");
            });

            modelBuilder.Entity<TblClientes>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__trfco__C__677F38F55C6CB6D7");

                entity.ToTable("tbl__CLIENTES", "grp__OPERACIONES_TRAFICO");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("id_cliente")
                    .ValueGeneratedNever();

                entity.Property(e => e.Alias)
                    .HasColumnName("alias")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AreaCobranza).HasColumnName("area_cobranza");

                entity.Property(e => e.AuxContable)
                    .HasColumnName("aux_contable")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteFact).HasColumnName("cliente_fact");

                entity.Property(e => e.ClienteQuePaga).HasColumnName("cliente_que_paga");

                entity.Property(e => e.CodPostal)
                    .HasColumnName("cod_postal")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConsecCobranza).HasColumnName("consec_cobranza");

                entity.Property(e => e.CuentaCliente)
                    .HasColumnName("cuenta_cliente")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaSbcliente)
                    .HasColumnName("cuenta_sbcliente")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CveUsoCfdi)
                    .HasColumnName("cve_uso_cfdi")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .HasColumnName("domicilio")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EmailContact1)
                    .HasColumnName("email_contact1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailContact2)
                    .HasColumnName("email_contact2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVO')");

                entity.Property(e => e.FactorIva)
                    .HasColumnName("factor_iva")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifico)
                    .HasColumnName("fecha_modifico")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdClienteLis).HasColumnName("id_cliente_lis");

                entity.Property(e => e.IdIngreso)
                    .HasColumnName("id_ingreso")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdIva).HasColumnName("id_iva");

                entity.Property(e => e.IdModifico)
                    .HasColumnName("id_modifico")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdPlaza).HasColumnName("id_plaza");

                entity.Property(e => e.IdTipoMoneda).HasColumnName("id_tipo_moneda");

                entity.Property(e => e.Localidad)
                    .HasColumnName("localidad")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Matriz)
                    .HasColumnName("matriz")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NomContact1)
                    .HasColumnName("nom_contact1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomContact2)
                    .HasColumnName("nom_contact2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PersonaFisica).HasColumnName("persona_fisica");

                entity.Property(e => e.Rfc)
                    .HasColumnName("rfc")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TelContact1)
                    .HasColumnName("tel_contact1")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TelContact2)
                    .HasColumnName("tel_contact2")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TipoRetencion).HasColumnName("tipo_retencion");
            });

            modelBuilder.Entity<TblConvenios>(entity =>
            {
                entity.HasKey(e => new { e.IdConvenio, e.IdCliente })
                    .HasName("PK__trfco__C__510C27B1725BF7F6");

                entity.ToTable("tbl__CONVENIOS", "grp__OPERACIONES_TRAFICO");

                entity.Property(e => e.IdConvenio).HasColumnName("id_convenio");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.AreaCobranza).HasColumnName("area_cobranza");

                entity.Property(e => e.ConvOperador)
                    .HasColumnName("conv_operador")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ConvPermisionario)
                    .HasColumnName("conv_permisionario")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EntregarEn)
                    .HasColumnName("entregar_en")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVO')");

                entity.Property(e => e.FactorIva)
                    .HasColumnName("factor_iva")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifico)
                    .HasColumnName("fecha_modifico")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdConvenioLis).HasColumnName("id_convenio_lis");

                entity.Property(e => e.IdDestinatario).HasColumnName("id_destinatario");

                entity.Property(e => e.IdDestino).HasColumnName("id_destino");

                entity.Property(e => e.IdIngreso)
                    .HasColumnName("id_ingreso")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdIva).HasColumnName("id_iva");

                entity.Property(e => e.IdModifico)
                    .HasColumnName("id_modifico")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdOrigen).HasColumnName("id_origen");

                entity.Property(e => e.IdRemitente).HasColumnName("id_remitente");

                entity.Property(e => e.IdRuta).HasColumnName("id_ruta");

                entity.Property(e => e.IdTipoMoneda).HasColumnName("id_tipo_moneda");

                entity.Property(e => e.IdTipoOperacion).HasColumnName("id_tipo_operacion");

                entity.Property(e => e.KmsConvenio)
                    .HasColumnName("kms_convenio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoAutopistas)
                    .HasColumnName("monto_autopistas")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoFlete)
                    .HasColumnName("monto_flete")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoIva)
                    .HasColumnName("monto_iva")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoManiobras)
                    .HasColumnName("monto_maniobras")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoOtros)
                    .HasColumnName("monto_otros")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoSeguro)
                    .HasColumnName("monto_seguro")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoSubtotal)
                    .HasColumnName("monto_subtotal")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoTotal)
                    .HasColumnName("monto_total")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RecogerEn)
                    .HasColumnName("recoger_en")
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambioConvenio)
                    .HasColumnName("tipo_cambio_convenio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoCobro)
                    .HasColumnName("tipo_cobro")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .HasColumnName("tipo_pago")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoServ)
                    .HasColumnName("tipo_serv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValorDeclarado)
                    .HasColumnName("valor_declarado")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ValorKms)
                    .HasColumnName("valor_kms")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ValorTonelada)
                    .HasColumnName("valor_tonelada")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ValorUnitario)
                    .HasColumnName("valor_unitario")
                    .HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TblConveniosConceptos>(entity =>
            {
                entity.HasKey(e => new { e.IdConvenio, e.IdCliente, e.Orden })
                    .HasName("PK__trfco__C__632D7F5C7CD98669");

                entity.ToTable("tbl__CONVENIOS_CONCEPTOS", "grp__OPERACIONES_TRAFICO");

                entity.Property(e => e.IdConvenio).HasColumnName("id_convenio");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.DescripcionConcepto)
                    .HasColumnName("descripcion_concepto")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdConceptoLis).HasColumnName("id_concepto_lis");

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoIva)
                    .HasColumnName("monto_iva")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoRetencion)
                    .HasColumnName("monto_retencion")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.MontoTotal)
                    .HasColumnName("monto_total")
                    .HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TblConveniosProductos>(entity =>
            {
                entity.HasKey(e => new { e.IdConvenio, e.IdCliente, e.Orden })
                    .HasName("PK__trfco__C__632D7F5C019E3B86");

                entity.ToTable("tbl__CONVENIOS_PRODUCTOS", "grp__OPERACIONES_TRAFICO");

                entity.Property(e => e.IdConvenio).HasColumnName("id_convenio");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.Cantidad)
                    .HasColumnName("cantidad")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DescripcionProducto)
                    .HasColumnName("descripcion_producto")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmbalajeProd)
                    .HasColumnName("embalaje_prod")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FraccionProd)
                    .HasColumnName("fraccion_prod")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmbalaje).HasColumnName("id_embalaje");

                entity.Property(e => e.IdFraccion).HasColumnName("id_fraccion");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ImporteTotal)
                    .HasColumnName("importe_total")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Peso)
                    .HasColumnName("peso")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PesoEstimado)
                    .HasColumnName("peso_estimado")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Volumen)
                    .HasColumnName("volumen")
                    .HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TblFlotillas>(entity =>
            {
                entity.HasKey(e => e.IdFlotilla)
                    .HasName("PK__tbl_flot__AE44B97D113584D1");

                entity.ToTable("tbl_FLOTILLAS", "grp__ADMINISTRACION");

                entity.Property(e => e.IdFlotilla).HasColumnName("id_flotilla");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Flotilla)
                    .IsRequired()
                    .HasColumnName("flotilla")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGpsAsignacion>(entity =>
            {
                entity.HasKey(e => e.IdAsignaLocalizador)
                    .HasName("PK__tbl_GPS___76E6036A48BAC3E5");

                entity.ToTable("tbl_GPS_ASIGNACION", "grp__TELEMETRIA");

                entity.Property(e => e.IdAsignaLocalizador).HasColumnName("id_asigna_localizador");

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAsignacion)
                    .HasColumnName("fecha_asignacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdLocalizador).HasColumnName("Id_Localizador");

                entity.Property(e => e.IdSim).HasColumnName("id_Sim");

                entity.Property(e => e.UniNumEco)
                    .IsRequired()
                    .HasColumnName("uni_num_eco")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdLocalizadorNavigation)
                    .WithMany(p => p.TblGpsAsignacion)
                    .HasForeignKey(d => d.IdLocalizador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_GPS_AS986913");

                entity.HasOne(d => d.IdSimNavigation)
                    .WithMany(p => p.TblGpsAsignacion)
                    .HasForeignKey(d => d.IdSim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_GPS_AS913998");

                entity.HasOne(d => d.UniNumEcoNavigation)
                    .WithMany(p => p.TblGpsAsignacion)
                    .HasForeignKey(d => d.UniNumEco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_GPS_AS979273");
            });

            modelBuilder.Entity<TblGpsLocalizadores>(entity =>
            {
                entity.HasKey(e => e.IdLocalizador)
                    .HasName("PK__tbl_GPS___18C707394C8B54C9");

                entity.ToTable("tbl_GPS_LOCALIZADORES", "grp__TELEMETRIA");

                entity.Property(e => e.IdLocalizador).HasColumnName("Id_Localizador");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Imei)
                    .HasColumnName("IMEI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nuid)
                    .HasColumnName("NUID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblGpsMantenimiento>(entity =>
            {
                entity.HasKey(e => e.IdMtto)
                    .HasName("PK__tbl_GPS___9427D6D0505BE5AD");

                entity.ToTable("tbl_GPS_MANTENIMIENTO", "grp__TELEMETRIA");

                entity.Property(e => e.IdMtto).HasColumnName("id_mtto");

                entity.Property(e => e.FechaIns)
                    .HasColumnName("fecha_ins")
                    .HasColumnType("date");

                entity.Property(e => e.IdAsignaLocalizador).HasColumnName("id_asigna_localizador");

                entity.Property(e => e.KmsInicio).HasColumnName("kms_inicio");

                entity.Property(e => e.NomInst)
                    .HasColumnName("nom_inst")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion)
                    .HasColumnName("observacion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEvento)
                    .HasColumnName("tipo_evento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAsignaLocalizadorNavigation)
                    .WithMany(p => p.TblGpsMantenimiento)
                    .HasForeignKey(d => d.IdAsignaLocalizador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_GPS_MA518487");
            });

            modelBuilder.Entity<TblIncidenciaPerfil>(entity =>
            {
                entity.HasKey(e => e.IdIncidencia)
                    .HasName("PK__ACORP_IN__D7757E7630F848ED");

                entity.ToTable("tbl__INCIDENCIA_PERFIL", "grp__SEGURIDAD");

                entity.Property(e => e.IdIncidencia).HasColumnName("id_incidencia");

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasColumnName("departamento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.Incidencia)
                    .IsRequired()
                    .HasColumnName("incidencia")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Perfil)
                    .IsRequired()
                    .HasColumnName("perfil")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ValorIncidencia).HasColumnName("valor_incidencia");
            });

            modelBuilder.Entity<TblMovilesAsignacionCelulares>(entity =>
            {
                entity.HasKey(e => e.IdAsignacion)
                    .HasName("PK__tbl_MOVI__C3F7F96668336F3E");

                entity.ToTable("tbl_MOVILES_ASIGNACION_CELULARES", "grp__ADMINISTRACION");

                entity.Property(e => e.IdAsignacion).HasColumnName("id_asignacion");

                entity.Property(e => e.Comentarios)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaGmail)
                    .IsRequired()
                    .HasColumnName("Cuenta_gmail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("Fecha_actualizacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaAsignacion)
                    .HasColumnName("Fecha_Asignacion")
                    .HasColumnType("date");

                entity.Property(e => e.IdEquipo).HasColumnName("Id_Equipo");

                entity.Property(e => e.IdPersonalAdmon).HasColumnName("id_personal_admon");

                entity.Property(e => e.IdSim).HasColumnName("id_Sim");

                entity.Property(e => e.NipSeguridad).HasColumnName("NIP_seguridad");

                entity.Property(e => e.PrecioResguardo).HasColumnName("Precio_Resguardo");

                entity.HasOne(d => d.IdEquipoNavigation)
                    .WithMany(p => p.TblMovilesAsignacionCelulares)
                    .HasForeignKey(d => d.IdEquipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_MOVILE926214");

                entity.HasOne(d => d.IdPersonalAdmonNavigation)
                    .WithMany(p => p.TblMovilesAsignacionCelulares)
                    .HasForeignKey(d => d.IdPersonalAdmon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_MOVILES_ASIGNACION_CELULARES_RH_PERSONAL_ADMON");

                entity.HasOne(d => d.IdSimNavigation)
                    .WithMany(p => p.TblMovilesAsignacionCelulares)
                    .HasForeignKey(d => d.IdSim)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_MOVILE497772");
            });

            modelBuilder.Entity<TblMovilesCuentasPadre>(entity =>
            {
                entity.HasKey(e => e.IdCuentaPadre)
                    .HasName("PK__ADMON_Cu__550BF6EC3FD07829");

                entity.ToTable("tbl_MOVILES_CUENTAS_PADRE", "grp__ADMINISTRACION");

                entity.Property(e => e.IdCuentaPadre).HasColumnName("id_cuenta_padre");

                entity.Property(e => e.CpNombre)
                    .IsRequired()
                    .HasColumnName("Cp_nombre")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaPadre).HasColumnName("Cuenta_Padre");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("fecha_alta")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<TblMovilesEquipos>(entity =>
            {
                entity.HasKey(e => e.IdEquipo)
                    .HasName("PK__tbl_MOVI__4B9119C06FD49106");

                entity.ToTable("tbl_MOVILES_EQUIPOS", "grp__ADMINISTRACION");

                entity.Property(e => e.IdEquipo).HasColumnName("Id_Equipo");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("fecha_alta")
                    .HasColumnType("date");

                entity.Property(e => e.Imei)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatusEquipo)
                    .IsRequired()
                    .HasColumnName("status_equipo")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMovilesLineasTiusa>(entity =>
            {
                entity.HasKey(e => e.IdLinea)
                    .HasName("PK__MOVILES___CF744F1B6462DE5A");

                entity.ToTable("tbl_MOVILES_LINEAS_TIUSA", "grp__ADMINISTRACION");

                entity.Property(e => e.IdLinea).HasColumnName("Id_linea");

                entity.Property(e => e.CuentaHija)
                    .IsRequired()
                    .HasColumnName("Cuenta_Hija")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("Fecha_alta")
                    .HasColumnType("date");

                entity.Property(e => e.IdCuentaPadre).HasColumnName("id_cuenta_padre");

                entity.Property(e => e.IdPlan).HasColumnName("Id_Plan");

                entity.Property(e => e.NoTelefono)
                    .IsRequired()
                    .HasColumnName("No_telefono")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCuentaPadreNavigation)
                    .WithMany(p => p.TblMovilesLineasTiusa)
                    .HasForeignKey(d => d.IdCuentaPadre)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMOVILES_LI491819");

                entity.HasOne(d => d.IdPlanNavigation)
                    .WithMany(p => p.TblMovilesLineasTiusa)
                    .HasForeignKey(d => d.IdPlan)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMOVILES_LI453633");
            });

            modelBuilder.Entity<TblMovilesPlanes>(entity =>
            {
                entity.HasKey(e => e.IdPlan)
                    .HasName("PK__tbl_MOVI__3BD89AB65B0E7E4A");

                entity.ToTable("tbl_MOVILES_PLANES", "grp__ADMINISTRACION");

                entity.Property(e => e.IdPlan).HasColumnName("Id_Plan");

                entity.Property(e => e.CostoAnualidad).HasColumnName("Costo_Anualidad");

                entity.Property(e => e.CostoPlanSinIva).HasColumnName("Costo_Plan_Sin_Iva");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("fecha_alta")
                    .HasColumnType("date");

                entity.Property(e => e.NomPlan)
                    .IsRequired()
                    .HasColumnName("Nom_Plan")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPlan)
                    .IsRequired()
                    .HasColumnName("Tipo_Plan")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMovilesSims>(entity =>
            {
                entity.HasKey(e => e.IdSim)
                    .HasName("PK__tbl_MOVI__757E72E07775B2CE");

                entity.ToTable("tbl_MOVILES_SIMS", "grp__ADMINISTRACION");

                entity.Property(e => e.IdSim).HasColumnName("id_Sim");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("fecha_alta")
                    .HasColumnType("date");

                entity.Property(e => e.IdLinea).HasColumnName("Id_linea");

                entity.Property(e => e.NoSim)
                    .IsRequired()
                    .HasColumnName("No_Sim")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoVersion)
                    .IsRequired()
                    .HasColumnName("No_Version")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblNotasCargoPerfil>(entity =>
            {
                entity.HasKey(e => e.IdConcepto)
                    .HasName("PK__admon__N__4B70853E3DB3258D");

                entity.ToTable("tbl__NOTAS_CARGO_PERFIL", "grp__ADMINISTRACION");

                entity.Property(e => e.IdConcepto)
                    .HasColumnName("id_concepto")
                    .ValueGeneratedNever();

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasColumnName("concepto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.NombreDepto)
                    .IsRequired()
                    .HasColumnName("nombre_depto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Perfil)
                    .IsRequired()
                    .HasColumnName("perfil")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPerfiles>(entity =>
            {
                entity.HasKey(e => e.Perfil)
                    .HasName("PK_ACORP_PERFILES");

                entity.ToTable("tbl__PERFILES", "grp__RECURSOSHUMANOS");

                entity.Property(e => e.Perfil)
                    .HasColumnName("perfil")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Clasificacion)
                    .HasColumnName("clasificacion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifico)
                    .HasColumnName("fecha_modifico")
                    .HasColumnType("datetime");

                entity.Property(e => e.NombreDepto)
                    .HasColumnName("nombre_depto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPlazas>(entity =>
            {
                entity.HasKey(e => e.IdPlaza)
                    .HasName("PK__trfco__P__04D4A233373B3228");

                entity.ToTable("tbl__PLAZAS", "grp__OPERACIONES_TRAFICO");

                entity.Property(e => e.IdPlaza).HasColumnName("id_plaza");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVO')");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifico)
                    .HasColumnName("fecha_modifico")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdGeoreferencia).HasColumnName("id_georeferencia");

                entity.Property(e => e.IdPlazaLis).HasColumnName("id_plaza_lis");

                entity.Property(e => e.IdZona).HasColumnName("id_zona");

                entity.Property(e => e.Matriz)
                    .HasColumnName("matriz")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIngreso)
                    .HasColumnName("usuario_ingreso")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModifico)
                    .HasColumnName("usuario_modifico")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPlazasGeoreferencia>(entity =>
            {
                entity.HasKey(e => e.IdGeoreferencia)
                    .HasName("PK__trfco__P__39BFCE6332767D0B");

                entity.ToTable("tbl__PLAZAS_GEOREFERENCIA", "grp__OPERACIONES_TRAFICO");

                entity.Property(e => e.IdGeoreferencia)
                    .HasColumnName("id_georeferencia")
                    .ValueGeneratedNever();

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVO')");

                entity.Property(e => e.Etiqueta)
                    .IsRequired()
                    .HasColumnName("etiqueta")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InegiRoutingNet)
                    .HasColumnName("inegi_routing_net")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InegiSource)
                    .HasColumnName("inegi_source")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InegiTarget)
                    .HasColumnName("inegi_target")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Latitud)
                    .HasColumnName("latitud")
                    .HasColumnType("decimal(18, 12)");

                entity.Property(e => e.Longitud)
                    .HasColumnName("longitud")
                    .HasColumnType("decimal(18, 12)");
            });

            modelBuilder.Entity<TblRutas>(entity =>
            {
                entity.HasKey(e => e.IdRuta)
                    .HasName("PK__trfco__R__33C9344F3FD07829");

                entity.ToTable("tbl__RUTAS", "grp__OPERACIONES_TRAFICO");

                entity.Property(e => e.IdRuta)
                    .HasColumnName("id_ruta")
                    .ValueGeneratedNever();

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVO')");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifico)
                    .HasColumnName("fecha_modifico")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdDestino).HasColumnName("id_destino");

                entity.Property(e => e.IdOrigen).HasColumnName("id_origen");

                entity.Property(e => e.IdRutaLis).HasColumnName("id_ruta_lis");

                entity.Property(e => e.KmLts)
                    .HasColumnName("km_lts")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.KmRuta)
                    .HasColumnName("km_ruta")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PathRuta).HasColumnName("path_ruta");

                entity.Property(e => e.TiempoEstimado).HasColumnName("tiempo_estimado");

                entity.Property(e => e.UsuarioIngreso)
                    .HasColumnName("usuario_ingreso")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModifico)
                    .HasColumnName("usuario_modifico")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblRutasCasetas>(entity =>
            {
                entity.HasKey(e => new { e.IdRuta, e.Orden })
                    .HasName("PK__trfco__R__11DCBA9C1975C517");

                entity.ToTable("tbl__RUTAS_CASETAS", "grp__OPERACIONES_TRAFICO");

                entity.Property(e => e.IdRuta).HasColumnName("id_ruta");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.IdCaseta).HasColumnName("id_caseta");
            });

            modelBuilder.Entity<TblRutasDestinos>(entity =>
            {
                entity.HasKey(e => new { e.IdRuta, e.Orden })
                    .HasName("PK__trfco__R__11DCBA9C467D75B8");

                entity.ToTable("tbl__RUTAS_DESTINOS", "grp__OPERACIONES_TRAFICO");

                entity.Property(e => e.IdRuta).HasColumnName("id_ruta");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Latitud)
                    .HasColumnName("latitud")
                    .HasColumnType("decimal(18, 12)");

                entity.Property(e => e.Longitud)
                    .HasColumnName("longitud")
                    .HasColumnType("decimal(18, 12)");
            });

            modelBuilder.Entity<TblUniAsignacionIave>(entity =>
            {
                entity.HasKey(e => e.IdAsignacionIave)
                    .HasName("PK__tbl_UNI___F57A3DCD420DC656");

                entity.ToTable("tbl_UNI_ASIGNACION_IAVE", "grp__ADMINISTRACION");

                entity.Property(e => e.IdAsignacionIave).HasColumnName("id_asignacion_iave");

                entity.Property(e => e.FechaAsignacion)
                    .HasColumnName("fecha_asignacion")
                    .HasColumnType("date");

                entity.Property(e => e.IdIave).HasColumnName("id_iave");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnName("observaciones")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StatusAsignacion)
                    .HasColumnName("status_asignacion")
                    .HasColumnType("date");

                entity.Property(e => e.UniNumEco)
                    .IsRequired()
                    .HasColumnName("uni_num_eco")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdIaveNavigation)
                    .WithMany(p => p.TblUniAsignacionIave)
                    .HasForeignKey(d => d.IdIave)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_UNI_AS216811");

                entity.HasOne(d => d.UniNumEcoNavigation)
                    .WithMany(p => p.TblUniAsignacionIave)
                    .HasForeignKey(d => d.UniNumEco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_UNI_AS338483");
            });

            modelBuilder.Entity<TblUniFotografia>(entity =>
            {
                entity.HasKey(e => e.IdFotografia)
                    .HasName("PK__tbl_UNI___93DD1FB258F12BAE");

                entity.ToTable("tbl_UNI_FOTOGRAFIA", "grp__MONITOREO");

                entity.Property(e => e.IdFotografia).HasColumnName("Id_fotografia");

                entity.Property(e => e.UniCliEstado)
                    .HasColumnName("uni_cli_estado")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniCliId).HasColumnName("uni_cli_id");

                entity.Property(e => e.UniCliNombre)
                    .HasColumnName("uni_cli_nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniEstadoFechaMantenimiento)
                    .HasColumnName("uni_estado_fecha_mantenimiento")
                    .HasColumnType("datetime");

                entity.Property(e => e.UniEstadoFechaMonitoreo)
                    .HasColumnName("uni_estado_fecha_monitoreo")
                    .HasColumnType("datetime");

                entity.Property(e => e.UniEstadoFechaOperaciones)
                    .HasColumnName("uni_estado_fecha_operaciones")
                    .HasColumnType("datetime");

                entity.Property(e => e.UniEstadoFechaRechumanos)
                    .HasColumnName("uni_estado_fecha_rechumanos")
                    .HasColumnType("datetime");

                entity.Property(e => e.UniEstadoFechaSistemas)
                    .HasColumnName("uni_estado_fecha_sistemas")
                    .HasColumnType("datetime");

                entity.Property(e => e.UniEstadoFechaTrafico)
                    .HasColumnName("uni_estado_fecha_trafico")
                    .HasColumnType("datetime");

                entity.Property(e => e.UniEstadoMantenimiento)
                    .HasColumnName("uni_estado_mantenimiento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniEstadoMonitoreo)
                    .HasColumnName("uni_estado_monitoreo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniEstadoOperaciones)
                    .HasColumnName("uni_estado_operaciones")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniEstadoRechumanos)
                    .HasColumnName("uni_estado_rechumanos")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniEstadoSistemas)
                    .HasColumnName("uni_estado_sistemas")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniEstadoTrafico)
                    .HasColumnName("uni_estado_trafico")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UniFechaClieUpdate)
                    .HasColumnName("uni_fecha_clie_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UniNumEco)
                    .IsRequired()
                    .HasColumnName("uni_num_eco")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UniUserCliUpdater)
                    .HasColumnName("uni_user_cli_updater")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.UniNumEcoNavigation)
                    .WithMany(p => p.TblUniFotografia)
                    .HasForeignKey(d => d.UniNumEco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_UNI_FO199598");
            });

            modelBuilder.Entity<TblUniGestoria>(entity =>
            {
                entity.HasKey(e => e.UniNumEco)
                    .HasName("PK__tbl_UNI___8061B44A38845C1C");

                entity.ToTable("tbl_UNI_GESTORIA", "grp__ADMINISTRACION");

                entity.Property(e => e.UniNumEco)
                    .HasColumnName("uni_num_eco")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FechaVenSeguro)
                    .HasColumnName("fecha_ven_seguro")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileAutorizacionPCirculacion)
                    .HasColumnName("file_autorizacion_p_circulacion")
                    .IsUnicode(false);

                entity.Property(e => e.FileBajaContaminantes)
                    .HasColumnName("file_baja_contaminantes")
                    .IsUnicode(false);

                entity.Property(e => e.FileCerFumigacion)
                    .HasColumnName("file_cer_fumigacion")
                    .IsUnicode(false);

                entity.Property(e => e.FileFisicoMecanica)
                    .HasColumnName("file_fisico_mecanica")
                    .IsUnicode(false);

                entity.Property(e => e.FileNoSerie)
                    .HasColumnName("file_no_serie")
                    .IsUnicode(false);

                entity.Property(e => e.FilePolizaSeguro)
                    .HasColumnName("file_poliza_seguro")
                    .IsUnicode(false);

                entity.Property(e => e.FileTarjetaCirculacion)
                    .HasColumnName("file_tarjeta_circulacion")
                    .IsUnicode(false);

                entity.Property(e => e.FileTarjetaIave)
                    .HasColumnName("file_tarjeta_iave")
                    .IsUnicode(false);

                entity.Property(e => e.VehFechaRemplacamiento)
                    .HasColumnName("veh_fecha_remplacamiento")
                    .HasColumnType("datetime");

                entity.Property(e => e.VehObservaciones)
                    .HasColumnName("veh_observaciones")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VehPlacas)
                    .HasColumnName("veh_placas")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VehPolizaSeg)
                    .HasColumnName("veh_poliza_seg")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VehRemplacamiento)
                    .HasColumnName("veh_remplacamiento")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VehSeguroInciso)
                    .HasColumnName("veh_seguro_inciso")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VehTarjCirculacion)
                    .HasColumnName("veh_tarj_circulacion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.UniNumEcoNavigation)
                    .WithOne(p => p.TblUniGestoria)
                    .HasForeignKey<TblUniGestoria>(d => d.UniNumEco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_UNI_GE645789");
            });

            modelBuilder.Entity<TblUniIaves>(entity =>
            {
                entity.HasKey(e => e.IdIave)
                    .HasName("PK__tbl_UNI___9B2A41523C54ED00");

                entity.ToTable("tbl_UNI_IAVES", "grp__ADMINISTRACION");

                entity.Property(e => e.IdIave).HasColumnName("id_iave");

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("fecha_alta")
                    .HasColumnType("date");

                entity.Property(e => e.StatusIave)
                    .IsRequired()
                    .HasColumnName("status_iave")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnName("tag")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUniImagenes>(entity =>
            {
                entity.HasKey(e => e.IdImagen)
                    .HasName("PK__tbl_UNI___27CC26895EAA0504");

                entity.ToTable("tbl_UNI_IMAGENES", "grp__MANTENIMIENTO");

                entity.Property(e => e.IdImagen).HasColumnName("id_imagen");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Imagen)
                    .IsRequired()
                    .HasColumnName("imagen")
                    .IsUnicode(false);

                entity.Property(e => e.UniNumEco)
                    .IsRequired()
                    .HasColumnName("uni_num_eco")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.UniNumEcoNavigation)
                    .WithMany(p => p.TblUniImagenes)
                    .HasForeignKey(d => d.UniNumEco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_UNI_IM730432");
            });

            modelBuilder.Entity<TblUniMttoOdometro>(entity =>
            {
                entity.HasKey(e => e.IdUniOdometro)
                    .HasName("PK__tbl_UNI___57C569CB2942188C");

                entity.ToTable("tbl_UNI_MTTO_ODOMETRO", "grp__MANTENIMIENTO");

                entity.Property(e => e.IdUniOdometro).HasColumnName("id_uni_odometro");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaOdometro)
                    .HasColumnName("fecha_odometro")
                    .HasColumnType("datetime");

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasColumnName("observacion")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Odometro).HasColumnName("odometro");

                entity.Property(e => e.UniNumEco)
                    .IsRequired()
                    .HasColumnName("uni_num_eco")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.UniNumEcoNavigation)
                    .WithMany(p => p.TblUniMttoOdometro)
                    .HasForeignKey(d => d.UniNumEco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_UNI_MT772430");
            });

            modelBuilder.Entity<TblUniMttoTractores>(entity =>
            {
                entity.HasKey(e => e.UniNumEco)
                    .HasName("PK__tbl_UNI___8061B44A2D12A970");

                entity.ToTable("tbl_UNI_MTTO_TRACTORES", "grp__MANTENIMIENTO");

                entity.Property(e => e.UniNumEco)
                    .HasColumnName("uni_num_eco")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CapAceiteDiferencialD).HasColumnName("cap_aceite_diferencial_D");

                entity.Property(e => e.CapAceiteDiferencialT).HasColumnName("cap_aceite_diferencial_T");

                entity.Property(e => e.CapAceiteMotor).HasColumnName("cap_aceite_motor");

                entity.Property(e => e.CapAceiteTransmicion).HasColumnName("cap_aceite_transmicion");

                entity.Property(e => e.CapacidadCombustible).HasColumnName("capacidad_combustible");

                entity.Property(e => e.MarcaMotor)
                    .HasColumnName("marca_motor")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModelMotor)
                    .HasColumnName("model_motor")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NoCilindros).HasColumnName("no_cilindros");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PotenciaMotor)
                    .HasColumnName("potencia_motor")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PulgCubMotor)
                    .HasColumnName("pulg_cub_motor")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RendAceiteDiferencialD).HasColumnName("rend_aceite_diferencial_D");

                entity.Property(e => e.RendAceiteDiferencialT).HasColumnName("rend_aceite_diferencial_T");

                entity.Property(e => e.RendAceiteTransmicion).HasColumnName("rend_aceite_transmicion");

                entity.Property(e => e.RendiAceiteMotor).HasColumnName("rendi_aceite_motor");

                entity.Property(e => e.RendiEsperado).HasColumnName("rendi_esperado");

                entity.Property(e => e.TipoCombustible)
                    .HasColumnName("tipo_combustible")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Transmision)
                    .HasColumnName("transmision")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.UniNumEcoNavigation)
                    .WithOne(p => p.TblUniMttoTractores)
                    .HasForeignKey<TblUniMttoTractores>(d => d.UniNumEco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_UNI_MT697244");
            });

            modelBuilder.Entity<TblUniTipoUnidad>(entity =>
            {
                entity.HasKey(e => e.IdTipoUnidad)
                    .HasName("PK__tbl_UNI___CD54BC5A31D75E8D");

                entity.ToTable("tbl_UNI_TIPO_UNIDAD", "grp__MANTENIMIENTO");

                entity.Property(e => e.IdTipoUnidad).HasColumnName("id_tipo_unidad");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualiza)
                    .HasColumnName("fecha_actualiza")
                    .HasColumnType("datetime");

                entity.Property(e => e.TipoUnidad)
                    .HasColumnName("tipo_unidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUnidades>(entity =>
            {
                entity.HasKey(e => e.UniNumEco)
                    .HasName("PK__tbl_UNID__8061B44A257187A8");

                entity.ToTable("tbl_UNIDADES", "grp__MANTENIMIENTO");

                entity.Property(e => e.UniNumEco)
                    .HasColumnName("uni_num_eco")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AnioUnidad)
                    .IsRequired()
                    .HasColumnName("anio_unidad")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BajaCausas)
                    .HasColumnName("baja_causas")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BajaFecha)
                    .HasColumnName("baja_fecha")
                    .HasColumnType("date");

                entity.Property(e => e.BajaObservacion)
                    .HasColumnName("baja_observacion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CentroCosto)
                    .IsRequired()
                    .HasColumnName("centro_costo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveVehiculo)
                    .IsRequired()
                    .HasColumnName("clave_vehiculo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CostoUnidad).HasColumnName("costo_unidad");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FactCompra)
                    .IsRequired()
                    .HasColumnName("fact_compra")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAlta)
                    .HasColumnName("fecha_alta")
                    .HasColumnType("date");

                entity.Property(e => e.FechaFact)
                    .HasColumnName("fecha_fact")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifica)
                    .HasColumnName("fecha_modifica")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdFlotilla).HasColumnName("id_flotilla");

                entity.Property(e => e.IdTipoUnidad).HasColumnName("id_tipo_unidad");

                entity.Property(e => e.LlantaExtra)
                    .IsRequired()
                    .HasColumnName("llanta_extra")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .IsRequired()
                    .HasColumnName("marca")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Modelo)
                    .IsRequired()
                    .HasColumnName("modelo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NoInventario)
                    .IsRequired()
                    .HasColumnName("no_inventario")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ObservacionGral)
                    .IsRequired()
                    .HasColumnName("observacion_gral")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PesoUnidad)
                    .IsRequired()
                    .HasColumnName("peso_unidad")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SerieChasis)
                    .IsRequired()
                    .HasColumnName("serie_chasis")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SerieMotor)
                    .IsRequired()
                    .HasColumnName("serie_motor")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLlantas).HasColumnName("total_llantas");

                entity.Property(e => e.UsuarioModifica)
                    .HasColumnName("usuario_modifica")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioRegistra)
                    .IsRequired()
                    .HasColumnName("usuario_registra")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehNoNiv)
                    .IsRequired()
                    .HasColumnName("veh_no_niv")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoUnidadNavigation)
                    .WithMany(p => p.TblUnidades)
                    .HasForeignKey(d => d.IdTipoUnidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtbl_UNIDAD953205");
            });

            modelBuilder.Entity<TblZonas>(entity =>
            {
                entity.HasKey(e => e.IdZona)
                    .HasName("PK__trfco__Z__67C936117E02B4CC");

                entity.ToTable("tbl__ZONAS", "grp__OPERACIONES_TRAFICO");

                entity.Property(e => e.IdZona).HasColumnName("id_zona");

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVO')");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaModifico)
                    .HasColumnName("fecha_modifico")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdZonaLis).HasColumnName("id_zona_lis");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioIngreso)
                    .HasColumnName("usuario_ingreso")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModifico)
                    .HasColumnName("usuario_modifico")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
