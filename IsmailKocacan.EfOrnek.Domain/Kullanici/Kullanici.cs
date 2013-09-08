using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsmailKocacan.EfOrnek.Domain
{
    public interface IKullanici
    {
        int Id { get; set; }
        string Ad { get; set; }
        string Soyad { get; set; }
        string EMailAdres { get; set; }
    }

    [Table("Kullanici")]
    public class Kullanici : IKullanici
    {
        [Key]
        public int Id { get; set; }

        [StringLength(25)]
        public string Ad { get; set; }


        [StringLength(25)]
        public string Soyad { get; set; }


        [StringLength(50)]
        public string EMailAdres { get; set; }


        public static Kullanici create()
        {
            return new Kullanici();
        }
    }
}
