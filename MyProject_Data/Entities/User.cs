using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_Data.Entities
{
    public class User
    {

        [Required(ErrorMessage = "Bu alan Boş bırakılamaz."), MaxLength(50, ErrorMessage = "Maks. 50 karakter giriniz.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Bu alan Boş bırakılamaz."), MaxLength(50, ErrorMessage = "Maks. 50 karakter giriniz.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        public Status Status { get; set; } = Status.Active;

    }
}
