using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device
{
    public class Device
    {
            [Required(ErrorMessage = "ID Property Requires Value")]

            public string Id { get; set; }
            [Range(10, 100, ErrorMessage = "Code Value Must Be Within 10-100")]
            public int Code { get; set; }

        [MaxLength(100, ErrorMessage = "Max of 100 Charcters are allowed")]
        public string Description { get; set; }

        public Device(string Id, int Code, string Description)
        {
            this.Id = Id;
            this.Code = Code;
            this.Description = Description;
        }

    }

  

namespace Device
{
    public static class ObjectValidator
    {
        public static bool Validate(Device deviceObject, out List<ValidationResult> errors)
        {
            var context = new ValidationContext(deviceObject, serviceProvider: null, items: null);
            errors = new List<ValidationResult>();

            return Validator.TryValidateObject(deviceObject, context, errors, validateAllProperties: true);
        }
    }

    class Program
    {
        static void Main()
        {
            Device deviceObj = new Device();

            Console.Write("Enter device Description: ");
            deviceObj.Description = Console.ReadLine();

            Console.Write("Enter device ID (1-100): ");
            if (int.TryParse(Console.ReadLine(), out int deviceId))
            {
                deviceObj.Id = Id;
            }
            else
            {
                Console.WriteLine("Invalid input for device ID. Exiting.");
                return;
            }

            List<ValidationResult> errors;
            bool isValid = ObjectValidator.Validate(deviceObj, out errors);

            if (!isValid)
            {
                foreach (ValidationResult error in errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Device is valid.");
            }
        }
    }
}

}
