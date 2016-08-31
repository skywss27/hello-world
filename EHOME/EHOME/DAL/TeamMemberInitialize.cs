using EHOME.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EHOME.DAL
{
    public class TeamMemberInitialize : System.Data.Entity.DropCreateDatabaseIfModelChanges<TeamContext>
    {
        protected override void Seed(TeamContext context)
        {
            var teamMembers = new List<TeamMember>
            {
                new TeamMember{ MemberNum = "31660", HeaderImage="image/3.png", MemberName="王双双", Sex="男", Transaction="kjsifsnifsngoa", CreatedTime=DateTime.Parse("2016-04-18"), LastUpdateTime=DateTime.Parse("2016-04-18"), version="1", EntryDate=DateTime.Parse("2016-04-18")},
                new TeamMember{ MemberNum = "31661", HeaderImage="image/3.png", MemberName="钱丽萍", Sex="男", Transaction="kjsifsnifsngoa", CreatedTime=DateTime.Parse("2016-04-18"), LastUpdateTime=DateTime.Parse("2016-04-18"), version="1", EntryDate=DateTime.Parse("2016-04-18")},
                new TeamMember{ MemberNum = "31662", HeaderImage="image/3.png", MemberName="吴剑波", Sex="男", Transaction="kjsifsnifsngoa", CreatedTime=DateTime.Parse("2016-04-18"), LastUpdateTime=DateTime.Parse("2016-04-18"), version="1", EntryDate=DateTime.Parse("2016-04-18")},
                new TeamMember{ MemberNum = "31663", HeaderImage="image/default.png", MemberName="ACFun", Sex="男", Transaction="kjsifsnifsngoa", CreatedTime=DateTime.Parse("2016-04-18"), LastUpdateTime=DateTime.Parse("2016-04-18"), version="1", EntryDate=DateTime.Parse("2016-04-18")},
                new TeamMember{ MemberNum = "31664", HeaderImage="image/default.png", MemberName="ACFun", Sex="男", Transaction="kjsifsnifsngoa", CreatedTime=DateTime.Parse("2016-04-18"), LastUpdateTime=DateTime.Parse("2016-04-18"), version="1", EntryDate=DateTime.Parse("2016-04-18")},
                new TeamMember{ MemberNum = "31666", HeaderImage="image/default.png", MemberName="Bilibili", Sex="男", Transaction="kjsifsnifsngoa", CreatedTime=DateTime.Parse("2016-04-18"), LastUpdateTime=DateTime.Parse("2016-04-18"), version="1", EntryDate=DateTime.Parse("2016-04-18")},
                new TeamMember{ MemberNum = "31667", HeaderImage="image/default.png", MemberName="Bilibili", Sex="男", Transaction="kjsifsnifsngoa", CreatedTime=DateTime.Parse("2016-04-18"), LastUpdateTime=DateTime.Parse("2016-04-18"), version="1", EntryDate=DateTime.Parse("2016-04-18")},
                new TeamMember{ MemberNum = "31668", HeaderImage="image/default.png", MemberName="Bilibili", Sex="男", Transaction="kjsifsnifsngoa", CreatedTime=DateTime.Parse("2016-04-18"), LastUpdateTime=DateTime.Parse("2016-04-18"), version="1", EntryDate=DateTime.Parse("2016-04-18")},
                new TeamMember{ MemberNum = "31669", HeaderImage="image/default.png", MemberName="Bilibili", Sex="男", Transaction="kjsifsnifsngoa", CreatedTime=DateTime.Parse("2016-04-18"), LastUpdateTime=DateTime.Parse("2016-04-18"), version="1", EntryDate=DateTime.Parse("2016-04-18")},
            };

            teamMembers.ForEach(m => context.Members.Add(m));
            context.SaveChanges();
        }
    }
}