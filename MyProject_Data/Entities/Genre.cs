using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_Data.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; } = Status.Active;




        ////Navigation Prop

        //Kitap-tür ilişkisi n-n ilişki
        public List<int> BookId { get; set; }
        public virtual List<Book> Books { get; set; }

        //Kategori-tür ilişkisi 1-n ilişki
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        //Tür-Yazar ilişkisi n-n ilişki
        public int Author { get; set; }
        public virtual List<Author> Authors { get; set; }

    }
}
