using System.Collections;
using System.Collections.Generic;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Data;
using System;
using Inv.BusinessEntities;
namespace Inv.DataAccess
{
    public abstract class ResumenBoletaAccessor : AccessorBase<ResumenBoletaAccessor>
    {
        

        [SprocName("Spu_Fact_Trae_ResumenBoletaDetalle")]
        public abstract List<ResumenDeBoleta> Spu_Fact_Trae_ResumenBoletaDetalle(string  @tipoDocumentoEmisor, 
                                                                string @numeroDocumentoEmisor, string @resumenId );

        [SprocName("Spu_Fact_Trae_ResumendeBoletas")]
        public abstract List<ResumenDeBoleta> Spu_Fact_Trae_ResumendeBoletas(string @Empresa);

        [SprocName("Spu_Fact_Trae_FacturasxFECabResumen")]
        public abstract List<ResumenDeBoleta> Spu_Fact_Trae_FacturasxFECabResumen(string @FAC04CODEMP,    
        string @FAC04FERESUMENCODIGO);

        [SprocName("Spu_Fac_Ins_FEResumenComprobantes")]
        public abstract void Spu_Fac_Ins_FEResumenComprobantes(string @FAC04CODEMP, string @FAC01COD, 
        string @FechaDocumento, string @FechaResumen, out int @flag, out string @msgretorno);
    

    }
}
