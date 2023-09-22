using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoesPizza.Models
{
    [Table("Pizza")]
    public class Pizza
    {
        [Key]
        public string PizzaId { get; set; }
        public string PizzaName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

    }
}
