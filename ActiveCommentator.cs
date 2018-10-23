using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebook
{
    public class ActiveCommentator : IActiveUser
    {
        public string UserName { get; set; }
        public string UserId { get; set; }
        public int NumOfComments { get; set; }

        public ActiveCommentator()
        {            
            NumOfComments = 1;
        }        
    }
}
