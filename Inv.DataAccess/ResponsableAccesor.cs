using System.Collections;
using System.Collections.Generic;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Data;
using System;
using Inv.BusinessEntities;

namespace Inv.DataAccess
{
    public abstract class ResponsableAccesor: AccessorBase<ResponsableAccesor>
    {
        [SprocName("sp_Inv_Help_Responsables")]
        public abstract List<Responsable> TraerResponsable(string @cCodEmp, string @cCampo, string @cFiltro, string @flag);
    }
}
