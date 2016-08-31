using EHOME.DTO;
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
        public List<TeamMemberDTO> GetAllMembers()
        {
           return teamMemberBC.GetAllMembers();
        }

        public TeamMemberDTO GetMemberById(int id)
        {
            return teamMemberBC.GetMemberById(id);
        }

        public int UpdateMember(TeamMemberDTO m)
        {
            return teamMemberBC.UpdateMember(m);
        }
    }
}