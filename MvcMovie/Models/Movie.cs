using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Display(Name = "电影名称")]
        public string Title { get; set; }
        [Display(Name = "发布日期"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "地区")]
        public string Genre { get; set; }
        [Display(Name = "评分"), Range(1, 100)]
        public decimal Price { get; set; }
    }
}
