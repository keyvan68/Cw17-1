using System.ComponentModel.DataAnnotations.Schema;

namespace Cw17_1.Models
{
    public class Adrress
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //[ForeignKey("userId")]
        public User user { get; set; } = null!;
        public int userId { get; set; }
    }
}
