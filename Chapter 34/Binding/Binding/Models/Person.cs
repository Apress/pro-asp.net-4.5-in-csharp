using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Binding.Models {

    public class Person : IValidatableObject {
        [Required(ErrorMessage = "You must enter your name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Names are 3-20 characters")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Names are alpha characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must enter your age")]
        [Range(5, 100, ErrorMessage = "Ages are 5-100")]
        public int Age { get; set; }

        public string Cell { get; set; }

        [CustomValidation(typeof(Binding.CustomChecks), "CheckZip")]
        public string Zip { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext
                validationContext) {
            List<ValidationResult> errors = new List<ValidationResult>();
            if (Name == "Bob" && Age < 20) {
                errors.Add(
                    new ValidationResult("People called Bob under 20 are not allowed"));
            }
            return errors;
        }
    }
}