using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Po_Assignment.Models
{
    public class Po_header
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
      
        public int OrderNumber { get; set; }

        [Required(ErrorMessage = "Order Date is required.")]
        [Display(Name = "OrderDate")]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "This field is requred")]
        [StringLength(255, ErrorMessage = "This field is requred")]
        public string Notes { get; set; }

        [Required(ErrorMessage = "OrderValue is required.")]
        public int OrderValue { get; set; }

        [Required(ErrorMessage = "Order Status is required.")]
        [StringLength(5, ErrorMessage = "Code must be 5 characters long.")]
        public string? OrderStatus { get; set; }

        // Define foreign key property
        [Required(ErrorMessage ="This field is required")]
        [Column("VendorID")]
        public int VendorMasterId { get; set; }

        // Define navigation property to represent the relationship
        [Required(ErrorMessage ="please select vendor")]
        [ForeignKey("VendorMasterId")]
        [ScaffoldColumn(false)]
        public VendorMaster VendorMaster { get; set; }




    }
}
