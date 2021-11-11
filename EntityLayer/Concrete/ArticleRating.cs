using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ArticleRating
    {
        public int ArticleRatingID { get; set; }
        public int ArticleID { get; set; }
        public int ArticleTotalScore { get; set; }
        public int ArticleRatingCount { get; set; }
    }
}
