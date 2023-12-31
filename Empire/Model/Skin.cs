﻿using System.ComponentModel.DataAnnotations;

/*Credits:
 * Kodet af Nuriye Erdogan */
namespace Empire.Model
{
    public class Skin
    {
        // Vi opretter properties som vi vil have i tabellen.

        // Vi laver ID til en key ved at skrive key:

        [Key]
        public int Id { get; set; }

        // Og laver SkinNavn til required 
        [Required] //argumenter
        public string SkinNavn { get; set; }
        public string Stand { get; set; }
        public string VåbenType { get; set; }
        public double Pris { get; set; }

        public string Beskrivelse { get; set; }

        public Skin()
        {
            SkinNavn = string.Empty;
            Stand = string.Empty;
            VåbenType = string.Empty;
            Beskrivelse = string.Empty;
        }
    }
}
