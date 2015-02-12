using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetObjectOrientationLibrary.Unity
{
    public interface IAuthenticationService
    {
        int GetAuthenticatedUserId();
    }
}
