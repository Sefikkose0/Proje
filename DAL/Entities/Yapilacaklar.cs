namespace webprojesi.DAL.Entities
{
	public class Yapilacaklar
	{
		public int YapilacaklarId { get; set; }
		public string Baslik { get; set; }
		public string ResimUrl { get; set; }
		public DateTime Tarih { get; set; }
		public bool Durum { get; set; }

	}
}
