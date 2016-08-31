using EHOME.DTO;
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
        List<TeamMemberDTO> GetAllMembers();
        TeamMemberDTO GetMemberById(int id);

        int UpdateMember(TeamMemberDTO m);
    }
}
