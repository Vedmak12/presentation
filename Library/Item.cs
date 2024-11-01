using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public virtual string DisplayInfo()
        {
            return $"ID: {Id}, Title: {Title}";
        }
    }

}
