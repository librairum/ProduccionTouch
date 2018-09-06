using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Collections;
using System.Text;
using System.Web.Services;

namespace Prod.UI.Web
{
    public class Auditoria : System.Web.UI.Page
    {
        public UserLogon Usuario
        {
            get
            {
                UserLogon usuario = (UserLogon)Session[Sesiones.USUARIO];
                return usuario;
            }
        }
    }
}