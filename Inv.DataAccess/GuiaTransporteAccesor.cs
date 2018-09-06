using System.Collections;
using System.Collections.Generic;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Data;
using System;
using Inv.BusinessEntities;
using System.Data;
namespace Inv.DataAccess
{
    public abstract class GuiaTransporteAccesor : AccessorBase<GuiaTransporteAccesor>
    {
        
        [SprocName("Spu_Fact_Trae_FAC34_GUIAREMISION")]
        public abstract List<GuiaTransporte> TraerGuiasTransporte(string @FAC34CODEMP, string @FAC34AA,string @FAC34MM, string @campo, string @filtro);
       
        [SprocName("Spu_Fact_Dame_Descripcion")]
        public abstract string Spu_Fact_Dame_Descripcion(string @cCodigo, string @cFlag, out string @cDescripcion);

        

        [SprocName("Spu_Fact_Help_FAC03_SUBPLANTILLA")]
        public abstract DataTable Spu_Fact_Help_FAC03_SUBPLANTILLA(string @FAC03CODEMP, string @FAC01COD, string @campo, string @Filtro);
        //        Set dcHelp.Recordset = CLS_COMANDO.Ejec_Comando_1("Spu_Fact_Help_FAC60_TRANSPORTISTA", gbCodEmpresa, "", "*")
        [SprocName("Spu_Fact_Help_FAC60_TRANSPORTISTA")]
        public abstract DataTable Spu_Fact_Help_FAC60_TRANSPORTISTA(string @FAC60CodEmp, string @campo, string @filtro);

        [SprocName("Spu_Fact_Help_VehxTranporYchofer")]
        public abstract DataTable Spu_Fact_Help_VehxTranporYchofer(string @FAC69Empresa,string @FAC69CodTransportista,string @FAC69Codchofer);  
        [SprocName("Spu_Fact_Help_choferxtransportistas")]
        public abstract DataTable Spu_Fact_Help_choferxtransportistas(string   @FAC61CodEmp  ,  string @FAC69CodTransportista );
        [SprocName("Spu_Fact_Help_FAC64_DESTINATARIO")]
        public abstract DataTable Spu_Fact_Help_FAC64_DESTINATARIO(string @FAC64CodEmp,string @campo,string @filtro);
        [SprocName("Spu_Fact_Help_FAC65_DESTINARIOESTAB")]
        public abstract DataTable Spu_Fact_Help_FAC65_DESTINARIOESTAB(string @FAC65CodEmp, string @FAC64CODIGO, string @campo, string @filtro);
        [SprocName("Spu_Fact_Help_FAC66_MOTIVODETRASLADO")]
        public abstract DataTable Spu_Fact_Help_FAC66_MOTIVODETRASLADO(string @campo,string @filtro);
        [SprocName("Spu_Fact_Help_FAC63_ESTABLECIMIENTOS")]
        public abstract DataTable Spu_Fact_Help_FAC63_ESTABLECIMIENTOS(string @FAC63CODEMP, string @campo, string @filtro);
        [SprocName("Spu_Fact_Help_empresa")]
        public abstract DataTable Spu_Fact_Help_empresa(string @Sistema, string @campo, string @filtro);
        [SprocName("Spu_Fact_Help_FAC67_ESTADOS")]
        public abstract DataTable Spu_Fact_Help_FAC67_ESTADOS(string @campo, string @filtro);

        [SprocName("Spu_Fact_Trae_NumGuia")]
        public abstract string Spu_Fact_Trae_NumGuia(string @FAC34CODEMP, string @FAC01COD, string @FAC34SERIEGUIA, out string @FAC34NROGUIA);

        [SprocName("Spu_Fact_Trae_ArtxTip")]
        public abstract DataTable Spu_Fact_Trae_ArtxTip(string @IN01CODEMP, string @IN01AA, string @IN04CODALM, string @opcion);
       
        [SprocName("Spu_Fact_Ins_FAC35_DETGUIA")]
        public abstract void Spu_Fact_Ins_FAC35_DETGUIA( string @FAC35CODEMP, string @FAC01COD, string @FAC34NROGUIA, out int @FAC35CODGUIADET, 
                                                         string @FAC35CODPROD, string @FAC35DESCPROD, string @FAC35UNIMED, float @FAC35CANTIDAD, 
                                                         float @FA35NROPIEZAS, float @FA35PESO, float @FA35NROCAJAS, string @FAC35CODPROD_PROV, 
                                                         string @FAC35DESCPROD_PROV, string @FAC35UNIMED_PROV, 
                                                         out int @flag, out string @msgretorno);
        [SprocName("Spu_Fact_Upd_FAC35_DETGUIA")]
        public abstract void Spu_Fact_Upd_FAC35_DETGUIA(string @FAC35CODEMP, string @FAC01COD, string @FAC34NROGUIA, int @FAC35CODGUIADET,
                                                         string @FAC35CODPROD, string @FAC35DESCPROD, string @FAC35UNIMED, float @FAC35CANTIDAD,
                                                         float @FA35NROPIEZAS, float @FA35PESO, float @FA35NROCAJAS, string @FAC35CODPROD_PROV,
                                                         string @FAC35DESCPROD_PROV, string @FAC35UNIMED_PROV,
                                                         out int @flag, out string @msgretorno);

        [SprocName("Spu_Fact_Ins_FAC34_GUIAREMISION")]
        public abstract void Spu_Fact_Ins_FAC34_GUIAREMISION(string @FAC34CODEMP,string @FAC01COD,string @FAC34NROGUIA,string @FAC34SERIEGUIA,
                                                             string @FAC34CORRELATIVOGUIA,string @FAC34AA,string @FAC34MM,string @FAC03COD,
                                                             string @FAC02COD,string @FAC03TIPART,string @FAC34FECHA,string @FAC34ORICODEMP,
                                                             string @FAC34ORICODESTAB,string @FAC34ORIDESESTAB,string @FAC34ORIDOMPARTIDA,
                                                             string @FAC34DESCODEMP,string @FAC34DESDESEMP,string @FAC34DESCODESTAB,
                                                            string @FAC34DESDESESTAB,string @FAC34DESTDIRECCION,string @FAC34CODTRANSPORTISTA,
                                                            string @FAC34DESTRANSPORTISTA,string @FAC34TRAYCODIGO,string @FAC34TRAYMARCA,
                                                            string @FAC34TRAYPLACA,string @FAC34TRAYMARCASR,string @FAC34TRAYPLACASR,
                                                            string @FAC34CHOFCOD,string @FAC34CHOFNOMBRE,string @FAC34CHOFLICCONDUCIR,
                                                            string @FAC34MOTRASLCOD,string @FAC34MOTRASLDESC,string @FAC34MOTRASLDESCEXTRA,
                                                            string @FAC34OBSERVACION,string @FAC34ESTADO,string @FAC34FECHAINITRASLADO,
                                                            string @FAC34REFERENCIA,string @FAC34CONTENEDOR,string @FAC34PRECINTO,
                                                            string @FAC34FLAGORIPROD, string @FAC34CLICOD, string @FAC34OCTIPCOD, 
                                                            string @FAC34OCNRO, string @FAC34ESTADOPROCESOCOD, 
                                                            out int @flag,out string @msgretorno);

        [SprocName("Spu_Fact_Upd_FAC34_GUIAREMISION")]
        public abstract void Spu_Fact_Upd_FAC34_GUIAREMISION(string @FAC34CODEMP,string @FAC01COD,string @FAC34NROGUIA,string @FAC34SERIEGUIA,
                                                             string @FAC34CORRELATIVOGUIA,string @FAC34AA,string @FAC34MM,string @FAC03COD,
                                                             string @FAC02COD,string @FAC03TIPART,string @FAC34FECHA,string @FAC34ORICODEMP,
                                                             string @FAC34ORICODESTAB,string @FAC34ORIDESESTAB,string @FAC34ORIDOMPARTIDA,
                                                             string @FAC34DESCODEMP,string @FAC34DESDESEMP,string @FAC34DESCODESTAB,
                                                            string @FAC34DESDESESTAB,string @FAC34DESTDIRECCION,string @FAC34CODTRANSPORTISTA,
                                                            string @FAC34DESTRANSPORTISTA,string @FAC34TRAYCODIGO,string @FAC34TRAYMARCA,
                                                            string @FAC34TRAYPLACA,string @FAC34TRAYMARCASR,string @FAC34TRAYPLACASR,
                                                            string @FAC34CHOFCOD,string @FAC34CHOFNOMBRE,string @FAC34CHOFLICCONDUCIR,
                                                            string @FAC34MOTRASLCOD,string @FAC34MOTRASLDESC,string @FAC34MOTRASLDESCEXTRA,
                                                            string @FAC34OBSERVACION,string @FAC34ESTADO,string @FAC34FECHAINITRASLADO,
                                                            string @FAC34REFERENCIA,string @FAC34CONTENEDOR,string @FAC34PRECINTO,
                                                            string @FAC34FLAGORIPROD, string @FAC34CLICOD, string @FAC34OCTIPCOD,
                                                            string @FAC34OCNRO, string @FAC34ESTADOPROCESOCOD,
                                                            out int @flag ,out string @msgretorno);

        [SprocName("Spu_Fact_Upd_EstadoGuia")]
        public abstract void Spu_Fact_Upd_EstadoGuia(string @FAC34CODEMP, string @FAC01COD, string @FAC34NROGUIA, string @FAC34ESTADONEW,
                                                      out int @flag, out string @msgretorno);
       
        [SprocName("Spu_Fact_Del_FAC34_GUIAREMISION")]
        public abstract void Spu_Fact_Del_FAC34_GUIAREMISION(string @FAC34CODEMP, string @FAC01COD, string @FAC34NROGUIA, out string @msgretorno);
        
        [SprocName("Spu_Fact_Del_FAC35_DETGUIA")]
        public abstract void Spu_Fact_Del_FAC35_DETGUIA( string @FAC35CODEMP, string @FAC01COD, string @FAC34NROGUIA, 
        int @FAC35CODGUIADET, out int @flag, out string @msgretorno);
        [SprocName("Spu_Fact_Rep_Guias")]
        public abstract DataTable Spu_Fact_Rep_Guias(string @FAC35CODEMP, string @XMLrango);
        //public abstract DataTable Spu_Fact_Rep_Guias(string @FAC35CODEMP, string @FAC01COD, string @FAC34NROGUIA);
        [SprocName("Spu_Fac_Trae_GuiaPendienteDeFactura")]
        public abstract List<GuiaTransporte> Spu_Fac_Trae_GuiaPendienteDeFactura(string @FAC35CODEMP,string @FAC01COD);

        [SprocName("Spu_Fact_Upd_GUIAREMISIONESTADOPROCESO")]
        public abstract void Spu_Fact_Upd_GUIAREMISIONESTADOPROCESO(string @XMLdetalle, string @FAC34ESTADOPROCESOCOD, 
        string @FlagOperacion, out int @flag, out string @msgretorno);
        
    }
}
