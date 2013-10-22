using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcleaderboard.Models
{
    public class UserModel
    {

        private LeaderboardModelDataContext dc = new LeaderboardModelDataContext();


        public List<User> selectAll()
        {
            var result = (from u in dc.Users
                         select u).ToList();
            return result;
        }

    }
}