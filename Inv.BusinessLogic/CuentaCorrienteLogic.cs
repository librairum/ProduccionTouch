using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inv.BusinessEntities;
using Inv.DataAccess;
using System.Data;

namespace Inv.BusinessLogic
{
    public class CuentaCorrienteLogic
    {
           #region Singleton
        private static volatile CuentaCorrienteLogic instance;
        private static object syncRoot = new Object();

        private CuentaCorrienteLogic() { }

        public static CuentaCorrienteLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new CuentaCorrienteLogic();
                    }
                }

                return instance;
            }
        }
        #endregion

        #region principalesmetodos
        public List<CuentaCorriente> Glo_Traer_CuentasCorrientes(string @cCodEmp, string @cTipoAnal, string @cOrden)
        {
            return Accessor.Glo_Traer_CuentasCorrientes(@cCodEmp, @cTipoAnal, @cOrden);
        }
        public void CuentaCorrienteInsertar(CuentaCorriente cuentacorriente, out string @cMsgRetorno)
        {
            @cMsgRetorno = string.Empty;
            Accessor.CuentaCorrienteInsertar(cuentacorriente.ccm02emp, cuentacorriente.ccm02tipana, cuentacorriente.ccm02cod, cuentacorriente.ccm02nom, cuentacorriente.ccm02dir, cuentacorriente.ccm02tel, string.Format("{0:yyyyMMdd}",cuentacorriente.ccm02fec ), cuentacorriente.ccm02ruc, cuentacorriente.ccm02ncta, cuentacorriente.ccm02tpag, cuentacorriente.ccm02nctadol,cuentacorriente.ccm02nomabrev, out @cMsgRetorno);
        }

        public void CuentaCorrienteModificar(CuentaCorriente cuentacorriente, out string @cMsgRetorno)
        {
            @cMsgRetorno = string.Empty;

            Accessor.CuentaCorrienteModificar(cuentacorriente.ccm02emp, cuentacorriente.ccm02tipana, cuentacorriente.ccm02cod, cuentacorriente.ccm02nom, cuentacorriente.ccm02dir, cuentacorriente.ccm02tel, string.Format("{0:yyyyMMdd}", cuentacorriente.ccm02fec), cuentacorriente.ccm02ruc, cuentacorriente.ccm02ncta, cuentacorriente.ccm02tpag, cuentacorriente.ccm02nctadol, cuentacorriente.ccm02nomabrev ,out @cMsgRetorno);
        }

        public void CuentaCorrienteEliminar(CuentaCorriente cuentacorriente, out string @cMsgRetorno)
        {
            @cMsgRetorno = string.Empty;

            Accessor.CuentaCorrienteEliminar(cuentacorriente.ccm02emp, cuentacorriente.ccm02tipana,cuentacorriente.ccm02cod, out @cMsgRetorno);
        }

        public List<CuentaCorriente> CuentaCorrienteTraer(string empresa,string codtipana)
        {
            return Accessor.CuentaCorrienteTraer(empresa, codtipana, "ccm02cod");
        }
        public CuentaCorriente CuentaCorrienteTraerRegistro(string empresa, string codigo,string codigo2)
        {
            return Accessor.CuentaCorrienteTraerRegistro(empresa, codigo, codigo2);
        }

        

        #endregion principalesmetodos
        #region "Tipo de Analisis"
       

        #endregion 

        public List<CuentaCorriente> TraeCliente(string @ccm02emp, string @ccm02tipana, string @campo, string @filtro)
        { 
            return Accessor.TraeCliente(@ccm02emp, @ccm02tipana, @campo, @filtro);
        }

        public void InsertarCliente(CuentaCorriente cuenta, out int @flag, out string @cMsgRetorno)
        {
            Accessor.Spu_Fact_Ins_Cliente(cuenta.ccm02emp, cuenta.ccm02tipana, cuenta.ccm02cod, 
            cuenta.ccm02nom, cuenta.ccm02dir, cuenta.ccm02tel, string.Format("{0:yyyyMMdd}", cuenta.ccm02fec), 
            cuenta.ccm02ruc,cuenta.ccm02fax, cuenta.ccm02rubpro, cuenta.ccm02Aten,
            cuenta.ccm02moneda, cuenta.Ccm02Forpag, cuenta.ccm02activo, cuenta.ccm02correo,
            cuenta.ccm02TipoAgenteRetencion, cuenta.ccm02TipoRuc, cuenta.ccm02ApePaterno,
            cuenta.ccm02ApeMaterno,cuenta.ccm02Nombres, cuenta.ccm02EstadoContribuyente, 
            cuenta.ccm02SituacionDomicilio, cuenta.ccm02nroctadetraccion, cuenta.ccm02tipdocidentidad,
            cuenta.ccm02CorreoFacturaElectronica,cuenta.ccm02FEDepartamentoCod,
            cuenta.ccm02FEProvinciaCod, cuenta.ccm02FEDistritoCod, cuenta.ccm02FEUrbanizacion,
            cuenta.ccm02FEPaisCod,cuenta.CCM02TIPOCLIENTECOD, out @flag, out @cMsgRetorno);
        }



        public void ActualizarCliente(CuentaCorriente cuenta, out int @flag, out string @cMsgRetorno)
        {
             Accessor.Spu_Fact_Upd_Cliente(cuenta.ccm02emp, cuenta.ccm02tipana, cuenta.ccm02cod, cuenta.ccm02nom,
             cuenta.ccm02dir, cuenta.ccm02tel, string.Format("{0:yyyyMMdd}", cuenta.ccm02fec), cuenta.ccm02ruc, 
             cuenta.ccm02fax, cuenta.ccm02rubpro, cuenta.ccm02Aten, cuenta.ccm02moneda, 
             cuenta.Ccm02Forpag, cuenta.ccm02activo, cuenta.ccm02correo, cuenta.ccm02TipoAgenteRetencion, 
             cuenta.ccm02TipoRuc,cuenta.ccm02ApePaterno, cuenta.ccm02ApeMaterno, cuenta.ccm02Nombres, 
             cuenta.ccm02EstadoContribuyente,  cuenta.ccm02SituacionDomicilio, cuenta.ccm02nroctadetraccion,  
             cuenta.ccm02tipdocidentidad, cuenta.ccm02CorreoFacturaElectronica, cuenta.ccm02FEDepartamentoCod, 
             cuenta.ccm02FEProvinciaCod, cuenta.ccm02FEDistritoCod, cuenta.ccm02FEUrbanizacion, 
             cuenta.ccm02FEPaisCod,  cuenta.CCM02TIPOCLIENTECOD,out @flag, out @cMsgRetorno);
            
        }


        public void EliminarCliente(string @cCodEmp, string @cTipAna, string @cCodigo,
                                                  out int @flag, out string @cMsgRetorno)
        { 
            Accessor.Spu_Fact_Del_cliente(@cCodEmp, @cTipAna, @cCodigo, out @flag, out @cMsgRetorno);
        }

        #region "::::::::::::::::::::::::::::::::::::::::::::::::: MODULO - FACTURA  :::::::::::::::::::::::::::::::::::::::::::::::::"
        public void Fac_CuentaCorrienteInsertar(CuentaCorriente cuenta, out string @cMsgRetorno)
        {
            Accessor.Spu_Glo_Ins_CuentaCorriente(cuenta.ccm02emp, cuenta.ccm02tipana, cuenta.ccm02cod, cuenta.ccm02nom,
            cuenta.ccm02dir, cuenta.ccm02tel, cuenta.txtfec, cuenta.ccm02ruc, cuenta.ccm02ncta,
            cuenta.ccm02tpag, cuenta.ccm02nctadol, cuenta.ccm02fax, cuenta.ccm02respon,
            cuenta.ccm02rubpro, cuenta.ccm02Aten, cuenta.ccm02moneda, cuenta.Ccm02Forpag,
            cuenta.ccm02activo, cuenta.ccm02correo, cuenta.ccm02tel2, cuenta.txtfecnac,
            cuenta.ccm02tipojuridico, cuenta.ccm02descuento, cuenta.ccm02TipoAgenteRetencion, cuenta.ccm02dni,
            cuenta.ccm02localidad, cuenta.ccm02TipoRuc, cuenta.ccm02ApePaterno, cuenta.ccm02ApeMaterno,
            cuenta.ccm02Nombres, cuenta.ccm02EstadoContribuyente, cuenta.ccm02SituacionDomicilio,
            cuenta.ccm02Brevete, out @cMsgRetorno);
            
        }
        public void Fac_CuentaCorrienteActualizar(CuentaCorriente cuenta, out string @cMsgRetorno)
        {
            Accessor.Spu_Glo_Upd_CuentaCorriente(cuenta.ccm02emp, cuenta.ccm02tipana, cuenta.ccm02cod, cuenta.ccm02nom,
                            cuenta.ccm02dir, cuenta.ccm02tel, cuenta.txtfec, cuenta.ccm02ruc, cuenta.ccm02ncta,
                            cuenta.ccm02tpag, cuenta.ccm02nctadol, cuenta.ccm02fax, cuenta.ccm02respon,
                            cuenta.ccm02rubpro, cuenta.ccm02Aten, cuenta.ccm02moneda, cuenta.Ccm02Forpag,
                            cuenta.ccm02activo, cuenta.ccm02correo, cuenta.ccm02tel2, cuenta.txtfecnac,
                            cuenta.ccm02tipojuridico, cuenta.ccm02descuento, cuenta.ccm02TipoAgenteRetencion, cuenta.ccm02dni,
                            cuenta.ccm02localidad, cuenta.ccm02TipoRuc, cuenta.ccm02ApePaterno, cuenta.ccm02ApeMaterno,
                            cuenta.ccm02Nombres, cuenta.ccm02EstadoContribuyente, cuenta.ccm02SituacionDomicilio,
                            cuenta.ccm02Brevete, out @cMsgRetorno);
        }
        public void Fac_CuentaCorrienteEliminar(CuentaCorriente cuenta, out string @cMsgRetorno) {
            Accessor.Sp_Fac_Del_Cuenta_Corriente(cuenta.ccm02emp, cuenta.ccm02tipana, cuenta.ccm02cod,out  @cMsgRetorno);
        }
        
        #endregion
        #region Accessor

        private static CuentaCorrienteAccesor Accessor
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return CuentaCorrienteAccesor.CreateInstance(); }
        }
        
        #endregion Accessor
    }
}
