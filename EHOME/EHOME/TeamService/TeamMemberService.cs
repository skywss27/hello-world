using EHOME.Models;
using EHOME.TeamBC;
using EHOME.TeamInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EHOME.TeamService
{
    public class TeamMemberService : ITeamMember
    {
        private TeamMemberBC teamMemberBC; 
        public TeamMemberService() 
        {
            teamMemberBC = new TeamMemberBC();
        }
        public List<TeamMember> GetAllMembers()
        {
           return teamMemberBC.GetAllMembers();
        }

        public TeamMember GetMemberById(int id)
        {
            return teamMemberBC.GetMemberById(id);
        }

        public int UpdateMember(TeamMember m)
        {
            return teamMemberBC.UpdateMember(m);
        }
    }
}