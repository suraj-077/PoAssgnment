using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Po_Assignment.Models
{
    public class VendorMaster
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ScaffoldColumn(false)]
        [Key]

        public int Id { get; set; }
 
        public string? Code { get; set; }

        [Required(ErrorMessage = "Please fill this field")]
        [StringLength(150)]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Only letters and spaces are allowed")]
        public string? Name { get; set; }

       
        [Required(ErrorMessage = "Please fill this field")]
        [StringLength(255)]
        [RegularExpression(@"^[a-zA-Z0-9\s,'-]*$", ErrorMessage = "Invalid address format")]
        public string? AddressLine1 { get; set; }


        [Required(ErrorMessage = "Please fill this field")]
        [StringLength(255)]
        [RegularExpression(@"^[a-zA-Z0-9\s,'-]*$", ErrorMessage = "Invalid address format")]
        public string? AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please fill this field")]
        [StringLength(150)]
        [RegularExpression(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,3}$", ErrorMessage = "Invalid email format")]

        public string? ContactEmail { get; set; }

        [Required(ErrorMessage = "Please fill this field")]
        [StringLength(10)] 
        public string? ContactNo { get; set; }

        [Required(ErrorMessage = "Please fill this field")]
        [DataType(DataType.Date)]
        public string? ValidTillDate { get; set; }

        public bool IsActive { get; set; }
    }
}