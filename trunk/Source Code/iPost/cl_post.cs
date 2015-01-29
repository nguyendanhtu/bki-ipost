using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    public class cl_post
    {
        public string fuid { get; set; }
        public string fgid { get; set; }
        public string fpid { get; set; }
        public string content { get; set; }
        public DateTime create_time { get; set; }
        public decimal like_count { get; set; }
        public decimal comment_count { get; set; }
    }
}
