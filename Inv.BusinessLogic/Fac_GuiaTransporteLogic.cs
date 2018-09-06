using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inv.BusinessEntities;
using Inv.DataAccess;
using System.Data;

namespace Inv.BusinessLogic
{
   public class Fac_GuiaTransporteLogic
    {
       #region Singleton
        private static volatile Fac_GuiaTransporteLogic instance;
        private static object syncRoot = new Object();

        private Fac_GuiaTransporteLogic() { }

        public static Fac_GuiaTransporteLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Fac_GuiaTransporteLogic();
                    }
                }

                return instance;
            }
        }
        #endregion

        public List<GuiaTransporte> TraerGuiasTransporte(string codigoEmpresa, string Anio,
            string Mes, string campo, string filtro)
        {
            return Accessor.TraerGuiasTransporte(codigoEmpresa, Anio, Mes, campo, filtro);
        }
        public string Dame_Descripcion(string @cCodigo, string @cFlag, out string @cDescripcion) {
            return Accessor.Spu_Fact_Dame_Descripcion(@cCodigo, @cFlag, out @cDescripcion);
        }
        //string @FAC35CODEMP, string @FAC01COD, string @FAC34NROGUIA
        
        
       /*Funcion para traer ventana de ayuda */


        public DataTable Spu_Fact_Help_FAC03_SUBPLANTILLA(string @FAC03CODEMP, string @FAC01COD, string @campo, string @Filtro) { 
            return Accessor.Spu_Fact_Help_FAC03_SUBPLANTILLA(@FAC03CODEMP, @FAC01COD, @campo, @Filtro);
        }
        //        Set dcHelp.Recordset = CLS_COMANDO.Ejec_Comando_1("Spu_Fact_Help_FAC60_TRANSPORTISTA", gbCodEmpresa, "", "*")

        public DataTable Spu_Fact_Help_FAC60_TRANSPORTISTA(string @FAC60CodEmp, string @campo, string @filtro) {
            return Accessor.Spu_Fact_Help_FAC60_TRANSPORTISTA(@FAC60CodEmp, @campo, @filtro);
        }


        public DataTable Spu_Fact_Help_VehxTranporYchofer(string @FAC69Empresa, string @FAC69CodTransportista, string @FAC69Codchofer) {
            return Accessor.Spu_Fact_Help_VehxTranporYchofer(@FAC69Empresa, @FAC69CodTransportista, @FAC69Codchofer);
        }

        public DataTable Spu_Fact_Help_choferxtransportistas(string @FAC61CodEmp, string @FAC69CodTransportista) {
            return Accessor.Spu_Fact_Help_choferxtransportistas(@FAC61CodEmp, @FAC69CodTransportista);
        }

        public DataTable Spu_Fact_Help_FAC64_DESTINATARIO(string @FAC64CodEmp, string @campo, string @filtro) {
            return Accessor.Spu_Fact_Help_FAC64_DESTINATARIO(@FAC64CodEmp, @campo, @filtro);
        }

        public DataTable Spu_Fact_Help_FAC65_DESTINARIOESTAB(string @FAC65CodEmp, string @FAC64CODIGO, string @campo, string @filtro) { 
        return Accessor.Spu_Fact_Help_FAC65_DESTINARIOESTAB( @FAC65CodEmp,  @FAC64CODIGO,  @campo,  @filtro);
        }

        public DataTable Spu_Fact_Help_FAC66_MOTIVODETRASLADO(string @campo, string @filtro) {
            return Accessor.Spu_Fact_Help_FAC66_MOTIVODETRASLADO(@campo, @filtro);
        }

        public DataTable Spu_Fact_Help_FAC63_ESTABLECIMIENTOS(string @FAC63CODEMP, string @campo, string @filtro) {
            return Accessor.Spu_Fact_Help_FAC63_ESTABLECIMIENTOS(@FAC63CODEMP, @campo, @filtro);
        }

        public DataTable Spu_Fact_Help_empresa(string @Sistema, string @campo, string @filtro) { 
            return Accessor.Spu_Fact_Help_empresa(Sistema, @campo, @filtro);
        }

        public DataTable Spu_Fact_Help_FAC67_ESTADOS(string @campo, string @filtro) {
            return Accessor.Spu_Fact_Help_FAC67_ESTADOS(@campo, @filtro);
        }
        public string DameNroDocumentoGuia(string @FAC34CODEMP, string @FAC01COD, string @FAC34SERIEGUIA, out string @FAC34NROGUIA) 
        {
            return Accessor.Spu_Fact_Trae_NumGuia(@FAC34CODEMP, @FAC01COD, @FAC34SERIEGUIA, out @FAC34NROGUIA);
        }
        public DataTable Spu_Fact_Trae_ArtxTip(string @IN01CODEMP, string @IN01AA, string @IN04CODALM, string @opcion) {
            return Accessor.Spu_Fact_Trae_ArtxTip(@IN01CODEMP, @IN01AA, @IN04CODALM, @opcion);
        }

        public void Spu_Fact_Ins_FAC35_DETGUIA(string @FAC35CODEMP, string @FAC01COD, string @FAC34NROGUIA, 
           out int @FAC35CODGUIADET, string @FAC35CODPROD, string @FAC35DESCPROD, string @FAC35UNIMED, 
            float @FAC35CANTIDAD, float @FA35NROPIEZAS, float @FA35PESO, float @FA35NROCAJAS, string @FAC35CODPROD_PROV,
            string @FAC35DESCPROD_PROV, string @FAC35UNIMED_PROV, 
            out int @flag,out string @msgretorno) 
        { 
            Accessor.Spu_Fact_Ins_FAC35_DETGUIA(@FAC35CODEMP, @FAC01COD, @FAC34NROGUIA, 
            out @FAC35CODGUIADET, @FAC35CODPROD, @FAC35DESCPROD, @FAC35UNIMED, 
            @FAC35CANTIDAD, @FA35NROPIEZAS, @FA35PESO, @FA35NROCAJAS, @FAC35CODPROD_PROV,
            @FAC35DESCPROD_PROV, @FAC35UNIMED_PROV, out@flag, out @msgretorno);
        }
        public void Spu_Fact_Upd_FAC35_DETGUIA(string @FAC35CODEMP, string @FAC01COD, string @FAC34NROGUIA,
            int @FAC35CODGUIADET, string @FAC35CODPROD, string @FAC35DESCPROD, string @FAC35UNIMED,
            float @FAC35CANTIDAD, float @FA35NROPIEZAS, float @FA35PESO, float @FA35NROCAJAS, string @FAC35CODPROD_PROV,
            string @FAC35DESCPROD_PROV, string @FAC35UNIMED_PROV,
            out int @flag, out string @msgretorno) {
                Accessor.Spu_Fact_Upd_FAC35_DETGUIA(@FAC35CODEMP, @FAC01COD, @FAC34NROGUIA,
                @FAC35CODGUIADET, @FAC35CODPROD, @FAC35DESCPROD, @FAC35UNIMED,
                @FAC35CANTIDAD, @FA35NROPIEZAS, @FA35PESO, @FA35NROCAJAS, @FAC35CODPROD_PROV,
                @FAC35DESCPROD_PROV, @FAC35UNIMED_PROV, 
                out @flag, out @msgretorno);
        }
        public void Spu_Fact_Ins_FAC34_GUIAREMISION(GuiaTransporte cabeceraguia, out int flag,out string mensaje) {
            Accessor.Spu_Fact_Ins_FAC34_GUIAREMISION(cabeceraguia.FAC34CODEMP, cabeceraguia.FAC01COD, cabeceraguia.FAC34NROGUIA, cabeceraguia.FAC34SERIEGUIA,
                                                              cabeceraguia.FAC34CORRELATIVOGUIA, cabeceraguia.FAC34AA, cabeceraguia.FAC34MM, cabeceraguia.FAC03COD,
                                                              cabeceraguia.FAC02COD, cabeceraguia.FAC03TIPART,string.Format("{0:yyyyMMdd}", cabeceraguia.FAC34FECHA), cabeceraguia.FAC34ORICODEMP,
                                                              cabeceraguia.FAC34ORICODESTAB, cabeceraguia.FAC34ORIDESESTAB, cabeceraguia.FAC34ORIDOMPARTIDA,
                                                              cabeceraguia.FAC34DESCODEMP, cabeceraguia.FAC34DESDESEMP, cabeceraguia.FAC34DESCODESTAB,
                                                             cabeceraguia.FAC34DESDESESTAB, cabeceraguia.FAC34DESTDIRECCION, cabeceraguia.FAC34CODTRANSPORTISTA,
                                                             cabeceraguia.FAC34DESTRANSPORTISTA, cabeceraguia.FAC34TRAYCODIGO, cabeceraguia.FAC34TRAYMARCA,
                                                             cabeceraguia.FAC34TRAYPLACA, cabeceraguia.FAC34TRAYMARCASR, cabeceraguia.FAC34TRAYPLACASR,
                                                             cabeceraguia.FAC34CHOFCOD, cabeceraguia.FAC34CHOFNOMBRE, cabeceraguia.FAC34CHOFLICCONDUCIR,
                                                             cabeceraguia.FAC34MOTRASLCOD, cabeceraguia.FAC34MOTRASLDESC, cabeceraguia.FAC34MOTRASLDESCEXTRA,
                                                             cabeceraguia.FAC34OBSERVACION, cabeceraguia.FAC34ESTADO, cabeceraguia.FAC34FECHAINITRASLADO,
                                                             cabeceraguia.FAC34REFERENCIA, cabeceraguia.FAC34CONTENEDOR, cabeceraguia.FAC34PRECINTO,
                                                             cabeceraguia.FAC34FLAGORIPROD, cabeceraguia.FAC34CLICOD, cabeceraguia.FAC34OCTIPCOD, 
                                                             cabeceraguia.FAC34OCNRO, cabeceraguia.FAC34ESTADOPROCESOCOD,
                                                             out flag, out  mensaje);

            
        }

        public void Spu_Fact_Upd_FAC34_GUIAREMISION(GuiaTransporte cabeceraguia, out int flag,out string mensaje)
        {
            Accessor.Spu_Fact_Upd_FAC34_GUIAREMISION(cabeceraguia.FAC34CODEMP, cabeceraguia.FAC01COD, cabeceraguia.FAC34NROGUIA, cabeceraguia.FAC34SERIEGUIA,
                                                              cabeceraguia.FAC34CORRELATIVOGUIA, cabeceraguia.FAC34AA, cabeceraguia.FAC34MM, cabeceraguia.FAC03COD,
                                                              cabeceraguia.FAC02COD, cabeceraguia.FAC03TIPART,
                                                              string.Format("{0:yyyyMMdd}",cabeceraguia.FAC34FECHA), cabeceraguia.FAC34ORICODEMP,
                                                              cabeceraguia.FAC34ORICODESTAB, cabeceraguia.FAC34ORIDESESTAB, cabeceraguia.FAC34ORIDOMPARTIDA,
                                                              cabeceraguia.FAC34DESCODEMP, cabeceraguia.FAC34DESDESEMP, cabeceraguia.FAC34DESCODESTAB,
                                                             cabeceraguia.FAC34DESDESESTAB, cabeceraguia.FAC34DESTDIRECCION, cabeceraguia.FAC34CODTRANSPORTISTA,
                                                             cabeceraguia.FAC34DESTRANSPORTISTA, cabeceraguia.FAC34TRAYCODIGO, cabeceraguia.FAC34TRAYMARCA,
                                                             cabeceraguia.FAC34TRAYPLACA, cabeceraguia.FAC34TRAYMARCASR, cabeceraguia.FAC34TRAYPLACASR,
                                                             cabeceraguia.FAC34CHOFCOD, cabeceraguia.FAC34CHOFNOMBRE, cabeceraguia.FAC34CHOFLICCONDUCIR,
                                                             cabeceraguia.FAC34MOTRASLCOD, cabeceraguia.FAC34MOTRASLDESC, cabeceraguia.FAC34MOTRASLDESCEXTRA,
                                                             cabeceraguia.FAC34OBSERVACION, cabeceraguia.FAC34ESTADO, cabeceraguia.FAC34FECHAINITRASLADO,
                                                             cabeceraguia.FAC34REFERENCIA, cabeceraguia.FAC34CONTENEDOR, cabeceraguia.FAC34PRECINTO,
                                                             cabeceraguia.FAC34FLAGORIPROD, cabeceraguia.FAC34CLICOD, cabeceraguia.FAC34OCTIPCOD, 
                                                             cabeceraguia.FAC34OCNRO, cabeceraguia.FAC34ESTADOPROCESOCOD, out flag,out  mensaje);

        }
        public void Spu_Fact_Upd_EstadoGuia(string @FAC34CODEMP, string @FAC01COD, string @FAC34NROGUIA, string @FAC34ESTADONEW,
                                                       out int @flag,out string @msgretorno) {
             Accessor.Spu_Fact_Upd_EstadoGuia(@FAC34CODEMP, @FAC01COD, @FAC34NROGUIA, @FAC34ESTADONEW,out @flag, out @msgretorno);
        }
        public void Spu_Fact_Del_FAC34_GUIAREMISION(string @FAC34CODEMP, string @FAC01COD, string @FAC34NROGUIA, out string @msgretorno) {
            Accessor.Spu_Fact_Del_FAC34_GUIAREMISION(@FAC34CODEMP, @FAC01COD, @FAC34NROGUIA, out @msgretorno);
        }
        public void Spu_Fact_Del_FAC35_DETGUIA(string @FAC35CODEMP, string @FAC01COD, string @FAC34NROGUIA, 
            int @FAC35CODGUIADET, out int @flag, out string @msgretorno) {
                Accessor.Spu_Fact_Del_FAC35_DETGUIA(@FAC35CODEMP, @FAC01COD, @FAC34NROGUIA, @FAC35CODGUIADET, out @flag, out @msgretorno);
        }
        public DataTable Spu_Fact_Rep_Guias(string @FAC35CODEMP, string @XMLrango)
        {
            return Accessor.Spu_Fact_Rep_Guias(@FAC35CODEMP, @XMLrango);
        }
        //public DataTable Spu_Fact_Rep_Guias(string @FAC35CODEMP, string @FAC01COD, string @FAC34NROGUIA)
        //{
        //    return Accessor.Spu_Fact_Rep_Guias(@FAC35CODEMP, @FAC01COD, @FAC34NROGUIA);
        //}
        public List<GuiaTransporte> TraerGuiaPendientePorFacturar(string @FAC35CODEMP, string @FAC01COD)
        { 
            return Accessor.Spu_Fac_Trae_GuiaPendienteDeFactura(@FAC35CODEMP, @FAC01COD);
        }
        public  void ActualizarEstadoProceso(string @XMLdetalle, string @FAC34ESTADOPROCESOCOD,
         string @FlagOperacion, out int @flag, out string @msgretorno)
        {
            Accessor.Spu_Fact_Upd_GUIAREMISIONESTADOPROCESO(@XMLdetalle, @FAC34ESTADOPROCESOCOD,
                     @FlagOperacion, out @flag, out @msgretorno);
        }
        //public void ActualizarEstadoProceso(string @FAC34CODEMP, string @FAC01COD, string @FAC34NROGUIA,
        //    string @FAC34ESTADOPROCESOCOD, out int @flag, out string @msgretorno)
        //{
        //    Accessor.Spu_Fact_Upd_GUIAREMISIONESTADOPROCESO(@FAC34CODEMP, @FAC01COD, @FAC34NROGUIA, @FAC34ESTADOPROCESOCOD, 
        //        out @flag, out @msgretorno);
        //}
        #region Accessor

        private static GuiaTransporteAccesor  Accessor
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return GuiaTransporteAccesor.CreateInstance(); }
        }

        #endregion Accessor
    }
}
