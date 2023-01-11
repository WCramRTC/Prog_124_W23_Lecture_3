using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_3.Class_Examples
{
    public class MovieTitle
    {
        public string? Rank { get; set; }
        public string? Name { get; set; }
        public string? Year { get; set; }
        public string? Certificate { get; set; }
        public string? Runtime { get; set; }
        public string? Genre { get; set; }
        public string? Metascore { get; set; }
        public string? Gross { get; set; }
        public string? Rating { get; set; }

        public override string ToString()
        {
            return $"{Rank} {Name} {Year} {Certificate} {Runtime} {Genre} {Metascore} {Gross} {Rating}";
        }

    }
}
