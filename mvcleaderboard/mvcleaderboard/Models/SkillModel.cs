using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcleaderboard.Models
{
    public class SkillModel
    {
        LeaderboardModelDataContext dc = new LeaderboardModelDataContext();
        public List<Skill> selectAll()
        {
            var result = from s in dc.Skills
                         select s;
            return result.ToList():
        }
    }
}