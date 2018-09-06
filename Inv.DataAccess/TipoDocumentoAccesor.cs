using System.Collections;
using System.Collections.Generic;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Data;
using System;
using Inv.BusinessEntities;
using System.Data.SqlClient;
using System.Data;
namespace Inv.DataAccess
{
    public abstract  class TipoDocumentoAccesor: AccessorBase<TipoDocumentoAccesor>
    {
        [SprocName("Spu_Inv_Trae_TipDocxTransaccion")]
        public abstract List<TipoDocumento> TraerTipoDcoumentoxMovimiento(string @in12codemp, string @in12TipMov);

        [SprocName("sp_Inv_Help_Tipo_Documento")]
        public abstract List<TipoDocumento> TraerTipoDocumento(string @cCodEmp, string @cCampo, string @cFiltro);
       
        [SprocName("sp_Inv_Trae_Tipo_Documento")]
        public abstract List<TipoDocumento> TraerTipoDocumento1(string @cCodEmp, string @cOrden, string @cFiltro);

        [SprocName("Spu_Inv_Trae_Tipo_DocumentoRegistro")]
        public abstract TipoDocumento TipoDocumentoTraerRegistro(string @in12codemp, string @in12TipDoc);

        [SprocName("sp_Inv_Ins_Tipo_Documento")]
        public abstract void TipoDocumentoInsertar(string @cCodEmp, string @cTipDoc, string @cTipMov, string @cDesLarga,
            string @cDesCorta, string @cPalabra, string @cSerie, string @cNumerador, string @In12ExigeDevu, string @cNaturaleza,
            out string @cMsgRetorno);

        [SprocName("sp_Inv_Upd_Tipo_Documento")]
        public abstract void TipoDocumentoModificar(string @cCodEmp, string @cTipDoc, string @cTipMov, string @cDesLarga,
            string @cDesCorta, string @cPalabra, string @cSerie, string @cNumerador, string @In12ExigeDevu, string @cNaturaleza,
            out string @cMsgRetorno);

        [SprocName("sp_Inv_Del_Tipo_Documento")]
        public abstract void TipoDocumentoEliminar(string @cCodEmp, string @cCodigo, out string @cMsgRetorno);
        
        [SprocName("sp_Inv_Dame_Variable")]
        public abstract void DameVariable(string @cCodEmp, string @cCodigo, string @cFlag, out string @cVariable);
        
        //procedimineto con ambos filtro de consolidado y detallado 
        [SprocName("Spu_Inv_Rep_Transaccion_Res")]
        public abstract DataTable  Spu_Inv_Rep_Transaccion_Res(string @IN07CODEMP,string @IN07AA,string @fechaIni,string @fechaFin,string @XMLrango,string  @flag);

        [SprocName("Spu_Inv_Rep_Valida")]
        public abstract DataTable Spu_Inv_Rep_Valida(string @IN07CODEMP, string @IN07AA, string @IN07MM);
               

        [SprocName("Spu_Inv_Rep_ProvMatPriSalida")]
        public abstract DataTable Spu_Inv_Rep_ProvMatPriSalida(string @IN07CODEMP, string @IN07AA, string @IN07MMINI, string @IN07MMFIN, string @XMLrango, string @XMLrango2, string @tipoanalisi);

        [SprocName("Spu_Inv_Rep_MovXDocRespaldo")]
        public abstract DataTable Spu_Inv_Rep_MovXDocRespaldo(string @IN07CODEMP, string @IN07AA, string @fechaIni, string @fechaFin, string @flag, string @XMLrango);

        [SprocName("Spu_Inv_Rep_IngProduccion")]
        public abstract DataTable Spu_Inv_Rep_IngProduccion(string @IN07CODEMP, string @IN07AA, string @fechaIni, string @fechaFin, string @flag, string @tipanaliproductor, string @XMLrango);

        //Reporte de Transaccion de Materia Prima
        [SprocName("Spu_Inv_Rep_TranSalMPaProd")]
        public abstract DataTable Spu_Inv_Rep_TranSalMPaProd( string @IN07CODEMP, string @IN07AA, string @fechaIni, string @fechaFin, 
                                                                string @flag, string @IN06PRODNATURALEZA, 
                                                                string @IN07CODALM, string @XMLrango);
        [SprocName("Spu_Inv_Rep_TransIngXCompra")]
        public abstract DataTable Spu_Inv_Rep_TransIngXCompra(string @IN07CODEMP, string @IN07AA, string @fechaIni, 
                                                              string @fechaFin, string @flag,  string @IN06PRODNATURALEZA, 
                                                              string @IN07CODALM, string @XMLrango);
        [SprocName("Spu_Inv_Rep_TransaccionMP")]
        public abstract DataTable Spu_Inv_Rep_TransaccionMP(string @IN07CODEMP, string @IN07AA, string @fechaIni, 
                                                            string @fechaFin,  string @flag, string @IN06PRODNATURALEZA,  
                                                            string @IN07CODALM, string @XMLrango);

        [SprocName("Spu_Pro_Rep_TransaccionPP")]
        public abstract DataTable Spu_Pro_Rep_TransaccionPP(string @IN07CODEMP, string @IN07AA, string @fechaIni,
                                                            string @fechaFin, string @flag, string @IN06PRODNATURALEZA,
                                                            string @IN07CODALM, string @XMLrango);


        [SprocName("Spu_Pro_Rep_prodxoperador")]
        public abstract DataTable Spu_Pro_Rep_prodxoperador(string @IN07CODEMP, string @IN07AA, string @fechaIni, string 
                                                            @fechaFin,string @flag,string @IN06PRODNATURALEZA, string @XMLrango);
        //[SprocName("Spu_Pro_Rep_RendimientoBloque")]
        //public abstract DataTable Spu_Pro_Rep_RendimientoBloque(string @IN07CODEMP, string @IN07AA, string @fechaIni, string 
        //                                                    @fechaFin,string @flag,string @IN06PRODNATURALEZA, string @XMLrango);

        //[SprocName("Spu_Pro_Rep_RendixProducto")]
        //public abstract DataTable Spu_Pro_Rep_RendixProducto(string @IN07CODEMP, string @IN07AA, string @fechaIni, string
        //                                                    @fechaFin, string @flag, string @IN06PRODNATURALEZA, string @XMLrango);
        [SprocName("Spu_Pro_Rep_Rendimiento")]
        public abstract DataTable Spu_Pro_Rep_Rendimiento(string @IN07CODEMP, string @IN07AA,  string @fechaIni, string @fechaFin, 
                                                        string @flag, string @XMLrango, string @Linea);

        [SprocName("Spu_Pro_Trae_Prodxdia")]
        public abstract DataTable Spu_Pro_Trae_Prodxdia(string @empresa, string @anio,string @linea, string @fechaIni, string @fechaFin,
                                                        string @flag, string @XMLrango);

        [SprocName("Spu_Pro_Trae_ProdDiaria")]
        public abstract DataTable Spu_Pro_Trae_ProdDiaria(string @empresa, string @anio, string @linea, string @fechaIni, 
                                                          string @fechaFin, string @flag, string @XMLrango);

        [SprocName("Spu_Pro_Rep_Validaciones")]
        public abstract DataTable Spu_Pro_Rep_Validaciones(string @empresa);

        [SprocName("Spu_Fact_Trae_FAC01_TIPDOC")]
        public abstract List<TipoDocumentoVentas> Spu_Fact_Trae_FAC01_TIPDOC(string @FAC01CODEMP, string @campo, string @filtro);

        [SprocName("Spu_Fact_Trae_Por_Periodo")]
        public abstract List<Spu_Fact_Trae_Por_Periodo> Spu_Fact_Trae_Por_Periodo(string @FAC04CODEMP, string @FAC01COD,
            string @FAC04AA, string @FAC04MM, string @campo, string @filro);

        [SprocName("Spu_Fact_Trae_NumDocFact")]
        public abstract void Spu_Fact_Trae_NumDocFact(string @FAC04CODEMP, string @FAC01COD, string @FAC04SERIEDOC,out string @FAC04NRODOC);
}
}