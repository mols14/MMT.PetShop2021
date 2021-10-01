namespace PetShop.EFSql.Entities
{
    public class PetColorEntity
    {
        public int PetId { get; set; }
        public int ColorId { get; set; }
        public PetEntity Pet { get; set; }
        public ColorEntity Color { get; set; }
    }
}