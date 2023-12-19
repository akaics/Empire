using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/*Credits:
 * Kodet af Gülsüm Erdogan */
namespace Empire.Model
{
    public class SkinItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Navn { get; set; }
        public string Beskrivelse { get; set; } 
        public string Billede { get; set; }
        [Range(1,1000000,ErrorMessage = "Prisen skal være over 1,-.")]
        public double Pris { get; set; }
        public int SkinTypeId { get; set; }

        //Foreign key
        [ForeignKey("SkinTypeId")]
        public SkinType SkinType { get; set; }
        public int SkinId { get; set; }
        public Skin Skin { get; set; }




    }
}
