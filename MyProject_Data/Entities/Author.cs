using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyProject_Data.Entities
{
    public class Author
    {
        /// <summary>
        /// Yazar Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Yazar Adı
        /// </summary>
        [Display(Name = "Yazar Name")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [Range(3, 50, ErrorMessage = "Min. 3 karakter mak. 50 karakter giriniz.")]
        public string Name { get; set; }

        /// <summary>
        /// Yazar Soyadı
        /// </summary>
        [Display(Name = "Yazar Soyadı")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [Range(2, 100, ErrorMessage = "Min. 2 karakter mak. 100 karakter giriniz.")]
        public string LastName { get; set; }

        /// <summary>
        /// Yazar Tam ad. Zorunlu değil.
        /// </summary>
        public string FullName => (Name + " " + LastName);

        /// <summary>
        /// Yazar Hakkında Özet bilgi.
        /// </summary>
        [MaxLength(500)]
        public string? About { get; set; }

        /// <summary>
        /// Yazarın doğum tarihi.
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:dd.mm.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateBirth { get; set; }


        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; } = Status.Active;



        //Navigation Prop
        public virtual List<Genre> Genres { get; set; }
        public List<Book> Books { get; set; }


    }
}
