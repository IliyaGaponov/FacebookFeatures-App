using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebook
{
    public class ComparerByLikes : Comparer<ActiveLiker>
    {
        public override int Compare(ActiveLiker i_First, ActiveLiker i_Second)
        {
            return i_First.NumOfLikes - i_Second.NumOfLikes;
        }
    }
}
