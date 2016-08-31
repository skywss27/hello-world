using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EHOME.DTO
{
    public class TeamMemberDTO
    {
        public int ID { get; set; }
        public string MemberNum { set; get; }
        public string MemberName { get; set; }
        public string Sex { set; get; }
        public string HeaderImage { set; get; }

        public DateTime EntryDate { get; set; }
        public string Transaction { set; get; }
        public string version { set; get; }
        public DateTime CreatedTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
    }
}