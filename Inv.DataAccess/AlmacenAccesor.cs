using System.Collections;
using System.Collections.Generic;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Data;
using System;
using Inv.BusinessEntities;

namespace Inv.DataAccess
{
    public abstract class AlmacenAccesor: AccessorBase<AlmacenAccesor>
    {
        [SprocName("sp_Inv_Help_Almacen")]
        public abstract List<Almacen> TraerAlmacen(string @cCodEmp, string @cCampo, string @cFiltro);
   
        [SprocName("sp_Inv_Trae_Almacen")]
        public abstract List<Almacen> AlmacenTraer(string @cCodEmp,string @cOrden,string @cFiltro);

        [SprocName("Spu_Inv_Trae_AlmacenesMasTodos")]
        public abstract List<Almacen> AlmacenesMasTodos(string @in09codemp, string @cCampo, string @Filtro);
       
        [SprocName("Spu_Inv_Trae_AlmacenRegistro")]
        public abstract Almacen AlmacenTraerRegistro(string @in09codemp, string @in09codigo);

        [SprocName("sp_Inv_Ins_Almacen")]
        public abstract void AlmacenInsertar(string @cCodEmp,string @cCodigo,string @cDescripcion,string @cUbicacion,string @cCuenta,string @cDebhab,
                                             string @in09PRODNATURALEZA, string @in09flagmaterecuperacion,string @in09flagMatRechazado,
 											 string @In09FlagConsiderarProduccion,string @in09flagProductoBueno, string @in09lineacod, 
                                             string @in09actividadnivel1cod, string @in09FlagCostear, 
                                             out string @cMsgRetorno);

        [SprocName("sp_Inv_Upd_Almacen")]
        public abstract void AlmacenModificar(string @cCodEmp,string @cCodigo,string @cDescripcion,string @cUbicacion,string @cCuenta,string @cDebhab,
                                              string @in09PRODNATURALEZA, string @in09flagmaterecuperacion, string @in09flagMatRechazado,
											  string @In09FlagConsiderarProduccion,
                                              string @in09flagProductoBueno, 
                                              string @in09lineacod,
                                              string @in09actividadnivel1cod,
                                              string @in09FlagCostear,
                                              out string @cMsgRetorno);
        
        [SprocName("sp_Inv_Del_Almacen")]
        public abstract void AlmacenEliminar(string @cCodEmp ,string @cCodigo ,out string @cMsgRetorno);
        

    }

}
