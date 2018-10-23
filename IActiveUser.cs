using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopFacebook
{
    public interface IActiveUser
    {
        string UserName { get; set; }
        string UserId { get; set; }
    }
}
