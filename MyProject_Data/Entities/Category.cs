using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz."), MaxLength(70, ErrorMessage = "Maks. 70 karakter giriniz.")]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        [Display(Name = "Category Description")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz."), MaxLength(250, ErrorMessage = "Maks. 250 karakter giriniz.")]
        public string Description { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        public Status Status { get; set; } = Status.Active;



        ////Navigation Prop

        //Kategory-Tür ilişkisi 1-n ilişki
        public List<Genre> Genres { get; set; }
    }
}
