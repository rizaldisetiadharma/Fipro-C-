using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FiPro.Interface
{
    interface intLogin
    {
        Boolean Login(Entity.EntLogin e);
    }
}
