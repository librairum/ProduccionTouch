using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inv.BusinessEntities;
using Inv.DataAccess;
using System.Data;

namespace Inv.BusinessLogic
{
    public class ResponsableLogic
    {

        #region Singleton
        private static volatile ResponsableLogic instance;
        private static object syncRoot = new Object();

        private ResponsableLogic() { }

        public static ResponsableLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ResponsableLogic();
                    }
                }

                return instance;
            }
        }
        #endregion


        public List<Responsable> TraerResponsable(string codigoEmpresa)
        {
            return Accessor.TraerResponsable(codigoEmpresa, "In23Codigo", "*", "A");
        }


        #region Accessor

        private static ResponsableAccesor Accessor
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return ResponsableAccesor.CreateInstance(); }
        }

        #endregion Accessor
    }
}
