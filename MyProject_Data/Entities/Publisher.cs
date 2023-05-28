using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_Data.Entities
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        public Status Status { get; set; } = Status.Active;


        ////Navigation Prop
        //Yayınevi-Kitap ilişkisi n-n ilişki
        public virtual List<Book> Books { get; set; }

    }
}
