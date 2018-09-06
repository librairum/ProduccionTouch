using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inv.BusinessEntities;
using Inv.DataAccess;
using System.Data.SqlClient;
using System.Data;
namespace Inv.BusinessLogic
{
    public class TipoDocumentoLogic
    {
        #region Singleton
        private static volatile TipoDocumentoLogic instance;
        private static object syncRoot = new Object();

        private TipoDocumentoLogic() { }

        public static TipoDocumentoLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new TipoDocumentoLogic();
                    }
                }

                return instance;
            }
        }
        #endregion
        public List<TipoDocumento> TraerTipoDcoumentoxMovimiento(string @in12codemp, string @in12TipMov) {
            return Accessor.TraerTipoDcoumentoxMovimiento(@in12codemp, @in12TipMov);
        }
        public TipoDocumento TraerTipoDocumentoRegistro(string codigo, string tipodoc)
        {
            return Accessor.TipoDocumentoTraerRegistro(codigo, tipodoc);
        }
        public List<TipoDocumento> TraerTipoDocumento1(string codigoEmpresa)
        {
            return Accessor.TraerTipoDocumento1(codigoEmpresa, "In12tipDoc", "*");
        }
        public List<TipoDocumento> TraerTipoDocumentoxNaturaleza(string codigoEmpresa, string naturaleza) {
            return Accessor.TraerTipoDocumento1(codigoEmpresa, "In12tipDoc", "in12naturaleza = '"+ naturaleza +"'");
            //exec sp_Inv_Trae_Tipo_Documento '01', 'in12TipDoc', ' in12naturaleza = ''02'' '
        }
        /// <summary>
        /// Traer ayuda por tipo de documento E -> Entrdad : S -> Salida.
        /// </summary>
        /// <param name="codigoEmpresa"></param>
        /// <param name="tipoMovimiento"></param>
        /// <returns></returns>
        public List<TipoDocumento> TraerTipoDocumento2(string codigoEmpresa,string tipoMovimiento) {
            return Accessor.TraerTipoDocumento1(codigoEmpresa, "In12tipDoc", " In12TipMov = '" + tipoMovimiento + "'");
        }
        
        //Se creo este metodo con el parametro tipoNatulera para filtrar los documento por movimiento y tipo de de naturaleza del mismo
        public List<TipoDocumento> TraerTipoDocumento2(string codigoEmpresa, string tipoMovimiento, string tipoNaturaleraza) {
            return Accessor.TraerTipoDocumento1(codigoEmpresa, "In12tipDoc"," In12TipMov = '" + tipoMovimiento + "'" + " And in12naturaleza = '" + tipoNaturaleraza + "'");
        }
        public void TipoDocumentoInsertar(TipoDocumento tipodocumento, out string @cMsgRetorno)
        {
            @cMsgRetorno = string.Empty;
            Accessor.TipoDocumentoInsertar(tipodocumento.in12codemp,tipodocumento.In12tipDoc,tipodocumento.in12TipMov,
                tipodocumento.In12DesLar,tipodocumento.in12DesCor,tipodocumento.in12WorStr,tipodocumento.in12Serie,
                tipodocumento.In12NumCon, tipodocumento.In12ExigeDevu,tipodocumento.in12naturaleza,out @cMsgRetorno);
        }
        public void TipoDocumentoModificar(TipoDocumento tipodocumento, out string @cMsgRetorno)
        {
            @cMsgRetorno = string.Empty;

            Accessor.TipoDocumentoModificar(tipodocumento.in12codemp, tipodocumento.In12tipDoc, tipodocumento.in12TipMov, 
                tipodocumento.In12DesLar, tipodocumento.in12DesCor, tipodocumento.in12WorStr, tipodocumento.in12Serie, 
                tipodocumento.In12NumCon,tipodocumento.In12ExigeDevu,tipodocumento.in12naturaleza, out @cMsgRetorno);
        }
        public void TipoDocumentoEliminar(TipoDocumento tipodocumento, out string @cMsgRetorno)
        {
            @cMsgRetorno = string.Empty;

            Accessor.TipoDocumentoEliminar(tipodocumento.in12codemp,tipodocumento.In12tipDoc, out @cMsgRetorno);
        }



        public List<ItemsList> ObtenerListItems(string codigoEmpresa)
        {
            var lista = Accessor.TraerTipoDocumento(codigoEmpresa, "*", "*");
            return lista.Select(x => new ItemsList { Value = x.In12tipDoc, Text = x.In12DesLar }).ToList();
        }
        public string DameVariable(string @cCodEmp, string @cCodigo)
        {
            string variable = string.Empty;
            Accessor.DameVariable(cCodEmp, cCodigo, "TIPODOCUMENTO", out variable);
            return variable;
        }
        public List<TipoDocumento> TraerTipoDocumento(string codigoEmpresa)
        {
            return Accessor.TraerTipoDocumento(codigoEmpresa, "in12DesLar", "*");
        }
        public DataTable Spu_Inv_Rep_Transaccion_Res(string IN07CODEMP, string IN07AA, string fechaIni, string fechaFin,
            string XMLrango,string bandera) {
            return Accessor.Spu_Inv_Rep_Transaccion_Res(IN07CODEMP, IN07AA, fechaIni, fechaFin, XMLrango,bandera);
        }
        
        public DataTable Spu_Pro_Rep_prodxoperador(string IN07CODEMP, string IN07AA, string fechaIni, string 
                                                            fechaFin,string flag,string IN06PRODNATURALEZA, string XMLrango)
        {
            return Accessor.Spu_Pro_Rep_prodxoperador(IN07CODEMP, IN07AA, fechaIni,fechaFin,flag,IN06PRODNATURALEZA,XMLrango);
        }

        //public DataTable Spu_Pro_Rep_RendimientoBloque(string IN07CODEMP, string IN07AA, string fechaIni, string
        //                                                    fechaFin, string flag, string IN06PRODNATURALEZA, string XMLrango)
        //{
        //    return Accessor.Spu_Pro_Rep_RendimientoBloque(IN07CODEMP, IN07AA, fechaIni, fechaFin, flag, IN06PRODNATURALEZA, XMLrango);
        //}

        //public DataTable Spu_Pro_Rep_RendixProducto(string IN07CODEMP, string IN07AA, string fechaIni, string
        //                                                    fechaFin, string flag, string IN06PRODNATURALEZA, string XMLrango)
        //{
        //    return Accessor.Spu_Pro_Rep_RendixProducto(IN07CODEMP, IN07AA, fechaIni, fechaFin, flag, IN06PRODNATURALEZA, XMLrango);
        //}

        public DataTable Spu_Pro_Rep_Rendimiento(string @IN07CODEMP, string @IN07AA,  string @fechaIni, string @fechaFin, 
                                                        string @flag, string @XMLrango, string @Linea) {
            return Accessor.Spu_Pro_Rep_Rendimiento(@IN07CODEMP, @IN07AA, @fechaIni, @fechaFin, @flag, @XMLrango, @Linea);
        }

        public DataTable Spu_Pro_Trae_Prodxdia(string @empresa, string @anio, string @linea, string @fechaIni, string @fechaFin,
                                                        string @flag, string @XMLrango)
        {
            return Accessor.Spu_Pro_Trae_Prodxdia(@empresa, @anio, @linea, @fechaIni, @fechaFin, @flag, @XMLrango);
        }

        public DataTable Spu_Pro_Trae_ProdDiaria(string @empresa, string @anio, string @linea, string @fechaIni, string @fechaFin,
                                                        string @flag, string @XMLrango)
        {
            return Accessor.Spu_Pro_Trae_ProdDiaria(@empresa, @anio, @linea, @fechaIni, @fechaFin, @flag, @XMLrango);
        }

        public DataTable Spu_Pro_Rep_Validaciones(string @empresa)
        {
            return Accessor.Spu_Pro_Rep_Validaciones(@empresa);
        }

        

        public DataTable Spu_Inv_Rep_Valida(string IN07CODEMP, string IN07AA, string @IN07MM)
        {
            return Accessor.Spu_Inv_Rep_Valida(IN07CODEMP, IN07AA, @IN07MM);
        }

        public DataTable Spu_Inv_Rep_ProvMatPriSalida(string @IN07CODEMP, string @IN07AA, string @IN07MMINI, string @IN07MMFIN, string @XMLrango, string @XMLrango2, string @tipoanalisi)
        {
            return Accessor.Spu_Inv_Rep_ProvMatPriSalida(@IN07CODEMP, @IN07AA, @IN07MMINI, @IN07MMFIN, 
                                                         @XMLrango, @XMLrango2, @tipoanalisi);
        }

        public DataTable Spu_Inv_Rep_MovXDocRespaldo(string IN07CODEMP, string IN07AA, string fechaIni, string fechaFin,
            string bandera, string XMLrango)
        {
            return Accessor.Spu_Inv_Rep_MovXDocRespaldo(IN07CODEMP, IN07AA, fechaIni, fechaFin, bandera, XMLrango);
        }

        public DataTable Spu_Inv_Rep_IngProduccion(string IN07CODEMP, string IN07AA, string fechaIni, string fechaFin,
            string bandera, string tipanaliproductor, string XMLrango)
        {
            return Accessor.Spu_Inv_Rep_IngProduccion(IN07CODEMP, IN07AA, fechaIni, fechaFin, bandera, tipanaliproductor, XMLrango);
        }

        public List<TipoDocumentoVentas> TraerTipoDocumentoFA(string @FAC01CODEMP, string @campo, string @filtro)
        { 
            return Accessor.Spu_Fact_Trae_FAC01_TIPDOC(@FAC01CODEMP, @campo, @filtro);
        }

        public List<Spu_Fact_Trae_Por_Periodo> TraerDocumentoxPeriodoFA(string @FAC04CODEMP, string @FAC01COD,
            string @FAC04AA, string @FAC04MM, string @campo, string @filro)
        {
            return Accessor.Spu_Fact_Trae_Por_Periodo(@FAC04CODEMP, @FAC01COD,
                                            @FAC04AA, @FAC04MM, @campo, @filro);
        }
        public void Spu_Fact_Trae_NumDocFact(string @FAC04CODEMP, string @FAC01COD, string @FAC04SERIEDOC, out string @FAC04NRODOC)
        { 
            Accessor.Spu_Fact_Trae_NumDocFact(@FAC04CODEMP, @FAC01COD, @FAC04SERIEDOC, out @FAC04NRODOC);
        }
        #region "Reportes - Transacciones de Materia Prima"

        public DataTable Spu_Inv_Rep_TranSalMPaProd(string @IN07CODEMP, string @IN07AA, string @fechaIni, string @fechaFin,
                                                            string @flag, string @IN06PRODNATURALEZA,
                                                            string @IN07CODALM, string @XMLrango)
        { 
            return Accessor.Spu_Inv_Rep_TranSalMPaProd(@IN07CODEMP, @IN07AA, @fechaIni, @fechaFin,
                                                            @flag, @IN06PRODNATURALEZA,
                                                            @IN07CODALM, @XMLrango);
        }

        public DataTable Spu_Inv_Rep_TransIngXCompra(string @IN07CODEMP, string @IN07AA, string @fechaIni,
                                                              string @fechaFin, string @flag, string @IN06PRODNATURALEZA,
                                                              string @IN07CODALM, string @XMLrango)
        { 
            return Accessor.Spu_Inv_Rep_TransIngXCompra(@IN07CODEMP, @IN07AA, @fechaIni,
                                                              @fechaFin, @flag, @IN06PRODNATURALEZA,
                                                              @IN07CODALM, @XMLrango);
        }

        public DataTable Spu_Inv_Rep_TransaccionMP(string @IN07CODEMP, string @IN07AA, string @fechaIni,
                                                            string @fechaFin, string @flag, string @IN06PRODNATURALEZA,
                                                            string @IN07CODALM, string @XMLrango) 
        {
            return Accessor.Spu_Inv_Rep_TransaccionMP(@IN07CODEMP, @IN07AA, @fechaIni,
                                                            @fechaFin, @flag, @IN06PRODNATURALEZA,
                                                            @IN07CODALM, @XMLrango);
        }
        public DataTable Spu_Pro_Rep_TransaccionPP(string @IN07CODEMP, string @IN07AA, string @fechaIni,
                                                           string @fechaFin, string @flag, string @IN06PRODNATURALEZA,
                                                           string @IN07CODALM, string @XMLrango)
        {
            return Accessor.Spu_Pro_Rep_TransaccionPP(@IN07CODEMP, @IN07AA, @fechaIni,
                                                            @fechaFin, @flag, @IN06PRODNATURALEZA,
                                                            @IN07CODALM, @XMLrango);
        }




        #endregion

        //        public DataTable Spu_Inv_Rep_Transaccion_Consolidado(string IN07CODEMP,string In07Aa,
//string fechaIni,
//string fechaFin,
//string XMLrango,string bandera) {
//    return Accessor.Spu_Inv_Rep_Transaccion_Consolidado(IN07CODEMP, In07Aa,fechaIni, fechaFin, XMLrango,bandera);
//        }
        #region Accessor

        private static TipoDocumentoAccesor Accessor
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return TipoDocumentoAccesor.CreateInstance(); }
        }

        #endregion Accessor
    }
}
