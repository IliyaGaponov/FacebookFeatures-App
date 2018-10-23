using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebook
{
    public class ActiveLiker : IActiveUser
    {
        public string UserName { get; set; }
        public string UserId { get; set; }
        public int NumOfLikes { get; set; }

        public ActiveLiker()
        {            
            NumOfLikes = 1;
        }       
    }
}
