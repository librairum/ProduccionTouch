using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inv.BusinessEntities;
using Inv.DataAccess;

namespace Inv.BusinessLogic
{
    public class ResumenBoletaLogic
    {

        #region Singleton
        private static volatile ResumenBoletaLogic instance;
        private static object syncRoot = new Object();

        private ResumenBoletaLogic() { }

        public static ResumenBoletaLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ResumenBoletaLogic();
                    }
                }

                return instance;
            }
        }
        #endregion
        //-- Tabla Resumen de detalle x Cab.Boleta --------------
        public  List<ResumenDeBoleta> TraeResumenDetxCabBoleta(string @tipoDocumentoEmisor,
                                                                string @numeroDocumentoEmisor, string @resumenId)
        { 
            return Accessor.Spu_Fact_Trae_ResumenBoletaDetalle(@tipoDocumentoEmisor,
                                                                @numeroDocumentoEmisor, @resumenId);
        }
        public  List<ResumenDeBoleta> TraeResumendeBoletas(string @Empresa)
        {
            return Accessor.Spu_Fact_Trae_ResumendeBoletas(@Empresa);
        }
        public List<ResumenDeBoleta> TraeFacturasxFECabResumen(string @FAC04CODEMP, string @FAC04FERESUMENCODIGO)
        { 
            return Accessor.Spu_Fact_Trae_FacturasxFECabResumen(@FAC04CODEMP, @FAC04FERESUMENCODIGO);
        }
        public void GenerarResumenComprobante(string @FAC04CODEMP, string @FAC01COD, 
        string @FechaDocumento, string @FechaResumen, out int @flag, out string @msgretorno)
        {
            Accessor.Spu_Fac_Ins_FEResumenComprobantes(@FAC04CODEMP, @FAC01COD, 
            @FechaDocumento, @FechaResumen, out @flag, out @msgretorno);
        }
            
        #region Accessor
        private static ResumenBoletaAccessor Accessor
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return ResumenBoletaAccessor.CreateInstance(); }
        }
        #endregion Accessor
    }
}
