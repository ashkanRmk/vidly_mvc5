using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customers
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Customer Name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Birth Date")]
        [Min18YearOld]
        public DateTime? Birthday { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}