using System.Collections;
using System.Collections.Generic;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Data;
using System;
using Inv.BusinessEntities;

namespace Inv.DataAccess
{
    public abstract class CentroCostoAccesor : AccessorBase<CentroCostoAccesor>
    {
        [SprocName("sp_Inv_Help_Centro_Costo")]
        public abstract List<CentroCosto> TraerCentroCosto(string @cCodEmp, string @cCampo, string @cFiltro);
    }
}
