using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGallery2.Models
{
    class ComicBooks
    {
        public int Id { get; set; }
        public string SeriesTile { get; set; }
        public int IdIssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

    }
}
