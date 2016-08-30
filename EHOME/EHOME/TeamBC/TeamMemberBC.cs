using EHOME.DAL;
using EHOME.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EHOME.TeamBC
{
    public class TeamMemberBC
    {
        private TeamContext db = new TeamContext();
        public List<TeamMember> GetAllMembers()
        {
            return db.Members.ToList();
        }

        public TeamMember GetMemberById(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateMember(TeamMember m)
        {
            throw new NotImplementedException();
        }
    }
}