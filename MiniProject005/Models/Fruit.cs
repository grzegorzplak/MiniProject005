using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProject005.Models
{
    [Table("MiniProject005_Fruits")]
    public class Fruit
    {
        public int Id {  get; set; }
        public string Name { get; set; }
    }
}
