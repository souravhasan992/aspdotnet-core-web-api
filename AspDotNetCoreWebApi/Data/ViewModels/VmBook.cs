using System;

namespace AspDotNetCoreWebApi.Data.ViewModels
{
    public class VmBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
