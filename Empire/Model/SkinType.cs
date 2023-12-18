using System.ComponentModel.DataAnnotations;

namespace Empire.Model
{
    public class SkinType
    {
        // Vi opretter properties som vi vil have i tabellen.

        // Vi laver ID til en key ved at skrive [key]:

        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
