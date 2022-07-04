using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLabModels.Blog
{
    public class BlogPaging
    {
        public int Page { get; set; } = 1;

        public int PageSize { get; set; } = 6;
    }
}
