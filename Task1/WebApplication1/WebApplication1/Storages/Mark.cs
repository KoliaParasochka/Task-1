using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Storages
{
    public class Mark
    {
        public string Author { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public Mark()
        {
            Author = "";
            Text = "";
            Date = DateTime.Now;
        }

        public Mark(string author, string text, DateTime date)
        {
            Author = author;
            Text = text;
            Date = date;
        }
    }
}