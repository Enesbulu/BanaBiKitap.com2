using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_Data.Entities
{
    public class Book
    {
        /// <summary>
        /// Kitap Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Kitap Adı
        /// </summary>
        [Display(Name = "Book Name")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [Range(2, 100, ErrorMessage = "Min. 2 karakter mak. 100 karakter giriniz.")]
        //[MaxLength(100,ErrorMessage ="Maks. 100 karakter giriniz."),MinLength(2,ErrorMessage ="Min. 2 karakter giriniz.")]
        public string BookName { get; set; }

        /// <summary>
        /// Yazar adı
        /// </summary>
        [Display(Name = "Author Name")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [Range(3, 60, ErrorMessage = "Min. 3 karakter mak. 60 karakter giriniz.")]
        public string Author { get; set; }

        /// <summary>
        /// Yayın Evi
        /// </summary>

        [Display(Name = "Book Publisher")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [Range(5, 100, ErrorMessage = "Min. 5 karakter mak. 100 karakter giriniz.")]
        //[MaxLength(60, ErrorMessage = "Maks. 60 karakter giriniz."), MinLength(6, ErrorMessage = "Min. 6 karakter giriniz.")]
        public string Publisher { get; set; }

        /// <summary>
        /// Basım Yılı
        /// </summary>
        [Display(Name = "Publication Year")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [DisplayFormat(DataFormatString = "{0:dd.mm.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PublicationYear { get; set; } = DateTime.Now;

        /// <summary>
        /// Kitap ISBN No
        /// </summary>
        [Display(Name = "ISBN No")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [DisplayFormat(DataFormatString = "{0:###-##-####-#}")]
        public string ISBN_No { get; set; }

        /// <summary>
        /// Kitap Türü
        /// </summary>
        [Display(Name = "Kitap Türü")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string BookCenre { get; set; }

        /// <summary>
        /// Kitap Kategorisi
        /// </summary>
        [Display(Name = "Kategori")]
        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        public string BookCategory { get; set; }

        public Status Status { get; set; } = Status.Active;


        [DisplayFormat(DataFormatString = "{0:dd.mm.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }


        /////Navigation Prop

        //Yazar-Kitap ilişkisi n-n ilişki
        public List<Author> AuthorId { get; set; }
        public virtual List<Author> Authors { get; set; }

        //Tür-Kitap ilişkisi n-n ilişki
        public int GenreId { get; set; }
        public virtual List<Genre> Genres { get; set; }

        //Yayınevi-Kitap ilişkisi n-n ilişki
        public int PublisherId { get; set; }
        public virtual Publisher Publishers { get; set; }


    }

}
