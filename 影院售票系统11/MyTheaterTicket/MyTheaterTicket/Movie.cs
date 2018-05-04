using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTheaterTicket
{
    [Serializable]
    /// <summary>
    /// 电影类
    /// </summary>
   public class Movie
   {
       public Movie() { }
       public Movie(string movieName, string poster, string director, string actor, MovieType movieType, int price)
       {
           this.MovieName = movieName;
           this.Poster = poster;
           this.Director = director;
           this.Actor = actor;
           this.MovieType = movieType;
           this.Price = price;
       }

       //电影名称
       public string MovieName { get; set; }
       //海报片名称
       public string Poster { get; set; }
       //导演名
       public string Director { get; set; }
       //主演
       public string Actor { get; set; }
       //电影类型
       public MovieType MovieType { get; set; }
       //电影定价
       public int Price { get; set; }
       
      
   }
}
