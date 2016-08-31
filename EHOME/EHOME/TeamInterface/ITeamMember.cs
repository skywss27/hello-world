using EHOME.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHOME.TeamInterface
{
    public interface ITeamMember
    {
        List<TeamMember> GetAllMembers();
        TeamMember GetMemberById(int id);

        int UpdateMember(TeamMember m);
    }
}
