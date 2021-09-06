using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Model
{
    public class PageParameters
    {
        const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;

        //private int _pageSize = 10;
        private int _pageSize = 50;

        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }   
    }
}
