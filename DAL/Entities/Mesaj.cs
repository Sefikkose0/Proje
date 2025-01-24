namespace webprojesi.DAL.Entities
{
	public class Mesaj
	{
		public int MesajId { get; set; }
		public string  AdSoyad { get; set; }
		public string Konu { get; set; }
		public string Eposta { get; set; }
		public string MesajDetay { get; set; }
		public DateTime  GonderimTarihi { get; set; }
		public bool Okundumu { get; set; }




	}
}
