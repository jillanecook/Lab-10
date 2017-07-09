using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10
{
    class Movie
    {
        private String title;
        private String category;
        

        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
            
        }
        public string getCategory()
        {
            return category;
        }

        public string getTitle()
        {
            return title;
        }

        

        class Program
        {

        }
    }
}


