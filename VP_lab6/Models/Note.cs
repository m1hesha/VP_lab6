using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_lab6.Models
{
    public class Note
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Note(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }
    }
}
