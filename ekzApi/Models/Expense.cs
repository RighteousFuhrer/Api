using ekzApi.Enums;
using System.ComponentModel.DataAnnotations;

namespace ekzApi.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [MaxLength(60)]
        [Required]
        public string Name { get; set; }
        [Required]
        public double Cost { get; set; }
        public DateTime Time { get; set; }
        [Required]
        public Category Category { get; set; }
    }
}
