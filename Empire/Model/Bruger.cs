using System.ComponentModel.DataAnnotations;

namespace Empire.Model
{
    public class Bruger
    {
        // Vi opretter properties som vi vil have i tabellen.

        // Vi laver ID til en key ved at skrive key:
        [Key]
        public int Id { get; set; }

        // Og laver BrugerNavn og AdgangsKode til required 
        [Required]
        public string BrugerNavn { get; set; }

        [Required]
        public string AdgangsKode { get; set; }
        public string Email { get; set; }

        // Der mangler en property for ProfilBillede

    }
}
