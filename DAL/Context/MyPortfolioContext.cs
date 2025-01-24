using Microsoft.EntityFrameworkCore;
using webprojesi.DAL.Entities;



namespace webprojesi.DAL.Context
{
	public class MyPortfolioContext :DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=LAPTOP-1CHCV4IJ ; initial Catalog= PortfolioDb; integrated Security = true ; TrustServerCertificate=True;");
		}
		public DbSet <Hakkinda> Hakkındakiler{ get; set; }
		public DbSet<Iletisim> Iletisimler { get; set; }

		public DbSet<Deneyim> Deneyimler { get; set; }

		public DbSet<Ozellik> Ozellikler { get; set; }
		public DbSet<Mesaj> Mesajlar { get; set; }
		public DbSet<Portfolio> Portfolios { get; set; }
		public DbSet<Yetenek> Yetenekler { get; set; }
		public DbSet<SosyalMedya> SosyalMedyalar { get; set; }
		public DbSet<Referans> Referanslar { get; set; }


	}
}
