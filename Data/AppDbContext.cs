using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAPI.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(u => u.name).HasMaxLength(20);
            modelBuilder.Entity<User>().Property(u => u.telephone).HasMaxLength(20);
            modelBuilder.Entity<User>().Property(u => u.login).HasMaxLength(20);
            modelBuilder.Entity<User>().Property(u => u.mother_name).HasMaxLength(20);
            modelBuilder.Entity<User>().Property(u => u.birth_date).HasColumnType("datetime(6)");
            modelBuilder.Entity<User>().Property(u => u.created_at).HasColumnType("datetime(6)");
            modelBuilder.Entity<User>().Property(u => u.updated_at).HasColumnType("datetime(6)");
            modelBuilder.Entity<User>().HasIndex(u => u.email).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.login).IsUnique();
            modelBuilder.Entity<User>()
            .HasData(
                new User { id = 1, name = "Leonor", login = "Theired1995", password = "Eipai7Da6ut", email = "LeonorSantosFernandes@teleworm.us", telephone = "(11) 8703-2327", birth_date = DateTime.Parse("2003-11-21"), mother_name = "Dias", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 2, name = "Melissa", login = "Whords", password = "AhFeesha8", email = "MelissaCavalcantiPereira@armyspy.com", telephone = "(11) 8591-3354", birth_date = DateTime.Parse("2001-11-21"), mother_name = "Cardoso", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 3, name = "Brenda", login = "Sirsomand", password = "ohCaoha1Oo", email = "BrendaAlmeidaCardoso@jourrapide.com", telephone = "(12) 3650-4890", birth_date = DateTime.Parse("1999-11-21"), mother_name = "Cunha", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 4, name = "Luiz", login = "Youria", password = "wee2mo8Ohj", email = "LuizPereiraAlves@armyspy.com", telephone = "(16) 4636-2302", birth_date = DateTime.Parse("1998-11-21"), mother_name = "Carvalho", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 5, name = "Julian", login = "Hingere", password = "eWae2oos", email = "JulianFerreiraOliveira@dayrep.com", telephone = "(31) 5173-6191", birth_date = DateTime.Parse("1996-11-21"), mother_name = "Rodrigues", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 6, name = "Thaís", login = "Adlial", password = "Bahxe1ku8koi", email = "ThaisDiasPinto@teleworm.us", telephone = "(67) 6101-5582", birth_date = DateTime.Parse("1994-11-21"), mother_name = "Oliveira", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 7, name = "Douglas", login = "Marknow", password = "Aiv6Iquohcae", email = "DouglasOliveiraRocha@jourrapide.com", telephone = "(61) 3118-6336", birth_date = DateTime.Parse("1992-11-21"), mother_name = "Azevedo", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 8, name = "Rafael", login = "Curtand", password = "auJich6yutie", email = "RafaelSouzaAzevedo@teleworm.us", telephone = "(11) 2485-5791", birth_date = DateTime.Parse("1990-11-21"), mother_name = "Ferreira", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 9, name = "Enzo", login = "Kelin2001", password = "EaVohth5", email = "EnzoSouzaOliveira@dayrep.com", telephone = "(12) 6637-3409", birth_date = DateTime.Parse("1988-11-21"), mother_name = "Oliveira", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 10, name = "Kauê", login = "Artagglacte", password = "Reew7eisu8", email = "KaueCardosoSouza@dayrep.com", telephone = "11111111111", birth_date = DateTime.Parse("1986-11-21"), mother_name = "Almeida", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 11, name = "Giovanna", login = "Magur2002", password = "ieW2eZii", email = "GiovannaLimaGoncalves@dayrep.com", telephone = "(61) 9269-9311", birth_date = DateTime.Parse("1984-11-21"), mother_name = "Cavalcanti", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 12, name = "Carolina", login = "Hadeard", password = "Dewea3ooxai", email = "CarolinaGoncalvesLima@dayrep.com", telephone = "(67) 7410-5849", birth_date = DateTime.Parse("1982-11-21"), mother_name = "Costa", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 13, name = "Rafaela", login = "Hicarrim", password = "aehieQu5sh", email = "RafaelaCarvalhoGoncalves@dayrep.com", telephone = "(43) 3801-6229", birth_date = DateTime.Parse("1980-11-21"), mother_name = "Fernandes", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 14, name = "Davi", login = "Plicaut", password = "yaX8Geen8ae", email = "DaviMeloPinto@jourrapide.com", telephone = "(28) 5722-9255", birth_date = DateTime.Parse("1978-11-21"), mother_name = "Lima", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 15, name = "Luiz", login = "Fourpried2001", password = "Lae8je7zi", email = "LuizFerreiraAlmeida@rhyta.com", telephone = "(46) 5457-2796", birth_date = DateTime.Parse("1976-11-21"), mother_name = "Santos", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 16, name = "Daniel", login = "Magere01", password = "ahki3rouP", email = "DanielSantosRodrigues@rhyta.com", telephone = "(48) 8394-9490", birth_date = DateTime.Parse("1974-11-21"), mother_name = "Almeida", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 17, name = "Rebeca", login = "Therintord", password = "Iema8air9Ei", email = "RebecaBarbosaRodrigues@dayrep.com", telephone = "(18) 8674-7184", birth_date = DateTime.Parse("1972-11-21"), mother_name = "Melo", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 18, name = "Emily", login = "Awass2000", password = "aV4zooShoo", email = "EmilySousaFernandes@jourrapide.com", telephone = "(16) 7499-9561", birth_date = DateTime.Parse("1970-11-21"), mother_name = "Pereira", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 19, name = "Antônio", login = "Drefoldn", password = "hee7Aibuo", email = "AntonioPereiraOliveira@dayrep.com", telephone = "(82) 8720-7834", birth_date = DateTime.Parse("1968-11-21"), mother_name = "Barros", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow },
                new User { id = 20, name = "Douglas", login = "Opith1999", password = "aiyaegh7Oh", email = "DouglasLimaCastro@teleworm.us", telephone = "(16) 7499-9561", birth_date = DateTime.Parse("1966-11-21"), mother_name = "Cunha", status = true, created_at = DateTime.UtcNow, updated_at = DateTime.UtcNow }
            );
        }
    }
}