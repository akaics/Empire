using System.ComponentModel.DataAnnotations;

namespace Empire.Model
{
    public class Salgsopslag
    {
        // Vi opretter properties som vi vil have i tabellen.

        // Vi laver ID til en key ved at skrive [key]:

        [Key]
        public int Id { get; set; }
        public string Skin { get; set; }
        public double Pris { get; set; }
        public DateTime OprettelsesDato { get; set; }
    }
}
