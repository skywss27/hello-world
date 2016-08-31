using AutoMapper;
using EHOME.DAL;
using EHOME.DTO;
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
        public List<TeamMemberDTO> GetAllMembers()
        {
            var list = new List<TeamMemberDTO>();

            db.Members.ToList().ForEach(p => 
            {
              TeamMemberDTO dto =  Mapper.Map<TeamMember, TeamMemberDTO>(p);
              list.Add(dto);
            });
           // Mapper.Map<TeamMember, TeamMemberDTO>(new TeamMember());
            return list;
        }

        public TeamMemberDTO GetMemberById(int id)
        {
            TeamMemberDTO dto = Mapper.Map<TeamMember, TeamMemberDTO>(db.Members.Find(id));
            return dto;
        }

        public int UpdateMember(TeamMemberDTO m)
        {
           TeamMember member;
           if (m.ID == 0)
           {
               member = Mapper.Map<TeamMemberDTO, TeamMember>(m);
               member.HeaderImage = "image/default.png";
               member.CreatedTime = DateTime.Now;
               member.EntryDate = DateTime.Now;
               member.LastUpdateTime = DateTime.Now;
               member.version = "1";
               member.Sex = "男";
               member.Transaction = Guid.NewGuid().ToString();
               db.Members.Add(member);
               db.SaveChanges();
               return 1;
           }
           else
               return 0;
        }
    }
}