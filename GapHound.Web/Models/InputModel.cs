using System.ComponentModel.DataAnnotations;

namespace GapHound.Web.Models
{
    public class InputModel
    {
        [Required]
        public int X1 { get; set; }

        [Required]
        public int Y1 { get; set; }

        [Required]
        public int X2 { get; set; }

        [Required]
        public int Y2 { get; set; }
    }
}