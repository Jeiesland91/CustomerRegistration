using System.ComponentModel.DataAnnotations;

namespace CustomerRegistration.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Please enter a Name.")]
        [RegularExpression("(?i)^[a-z0-9 ]+$",
            ErrorMessage = "Customer name may not contain special characters.")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Please enter an Address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a Phone Number.")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
            ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter an Email Address.")]
        [RegularExpression(
            @"^([A-Za-z0-9][^'!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ][a-zA-z0-9-._][^!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ]*\@[a-zA-Z0-9][^!&@\\#*$%^?<>()+=':;~`.\[\]{}|/,₹€ ]*\.[a-zA-Z]{2,6})$",
            ErrorMessage = "Please enter a valid Email")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter age of Customer.")]
        [MinimumAge(18, ErrorMessage = "You must be at least 18 years old.")]
        public int? Age { get; set; }
    }
}