using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebook
{
    public class ComparerByComments : Comparer<ActiveCommentator>
    {
        public override int Compare(ActiveCommentator i_First, ActiveCommentator i_Second)
        {
            return i_First.NumOfComments - i_Second.NumOfComments;
        }
    }
}
