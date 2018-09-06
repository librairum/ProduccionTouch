using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Inv.BusinessEntities;
using Inv.BusinessLogic;
using Json;
using EasyCallback;
using System.Web.Services;

namespace Prod.UI.Web.Pages
{
    public partial class frmDetalleCorte : System.Web.UI.Page
    {
        Auditoria _auditoria = new Auditoria();
        protected void Page_Load(object sender, EventArgs e)
        {
            //GlobalLogic.Instance.TraeAyudaGlobalTouch("01",
        }
        protected override void OnInit(EventArgs e)
        {
            //base.OnInit(e);
            //CallbackManager.Register(BuscarClientesCallBack);
            //CallbackManager.Register(BuscarAyudaGlobalCallBack);
            //CallbackManager.Register(BuscarMaquinaCallBack);
            //CallbackManager.Register(BuscarColorCallBack);
        }
        private List<Cliente> LeerListaDeCliente()
        {
            List<Cliente> lista = new List<Cliente>();
            Cliente entidadCliente = new Cliente();
            entidadCliente.Codigo = "01";
            entidadCliente.Nombre = "Ivan Atanacio";
            lista.Add(entidadCliente);

            entidadCliente = new Cliente();
            entidadCliente.Codigo = "02";
            entidadCliente.Nombre = "Jose Cardenas";
            lista.Add(entidadCliente);

            entidadCliente = new Cliente();
            entidadCliente.Codigo = "03";
            entidadCliente.Nombre = "Denis Matos";
            lista.Add(entidadCliente);

            entidadCliente = new Cliente();
            entidadCliente.Codigo = "04";
            entidadCliente.Nombre = "Carlos Bernuy";
            lista.Add(entidadCliente);

            entidadCliente = new Cliente();
            entidadCliente.Codigo = "05";
            entidadCliente.Nombre = "Anibal Matos";
            lista.Add(entidadCliente);

            entidadCliente = new Cliente();
            entidadCliente.Codigo = "06";
            entidadCliente.Nombre = "Nirma Atanacio";
            lista.Add(entidadCliente);

            entidadCliente = new Cliente();
            entidadCliente.Codigo = "07";
            entidadCliente.Nombre = "Mariela Matos";
            lista.Add(entidadCliente);

            entidadCliente = new Cliente();
            entidadCliente.Codigo = "08";
            entidadCliente.Nombre = "Edson Matos";
            lista.Add(entidadCliente);

            entidadCliente = new Cliente();
            entidadCliente.Codigo = "09";
            entidadCliente.Nombre = "Carlos Lavandeira";
            lista.Add(entidadCliente);

            entidadCliente = new Cliente();
            entidadCliente.Codigo = "10";
            entidadCliente.Nombre = "Alberto Rodriguez";
            lista.Add(entidadCliente);

            entidadCliente = new Cliente();
            entidadCliente.Codigo = "11";
            entidadCliente.Nombre = "Carlos ALberto Navarro";
            lista.Add(entidadCliente);

            entidadCliente = new Cliente();
            entidadCliente.Codigo = "12";
            entidadCliente.Nombre = "Franco Navarro";
            lista.Add(entidadCliente);

            entidadCliente = new Cliente();
            entidadCliente.Codigo = "13";
            entidadCliente.Nombre = "Raul Ruidiaz";
            lista.Add(entidadCliente);

            entidadCliente = new Cliente();
            entidadCliente.Codigo = "14";
            entidadCliente.Nombre = "Jeferson Flores";
            lista.Add(entidadCliente);

            entidadCliente = new Cliente();
            entidadCliente.Codigo = "15";
            entidadCliente.Nombre = "Andy Polo";
            lista.Add(entidadCliente);

            entidadCliente = new Cliente();
            entidadCliente.Codigo = "16";
            entidadCliente.Nombre = "Jean Rodriguez";
            lista.Add(entidadCliente);

            return lista;
        }
        
        

        //[WebMethod()]
        //public string BuscarAyudaGlobalCallBack(string args)
        //{
        //    try
        //    {
        //        string[] parametros = args.Split(',');
        //        List<TablaGlobal> TablaGlobal = new List<TablaGlobal>();
        //        TablaGlobal = GlobalLogic.Instance.TraeAyudaGlobalTouch(_auditoria.Usuario.CodigoEmpresa, parametros[0], parametros[1]);
        //        List<ItemsList> lista = new List<ItemsList>();
        //        lista = TablaGlobal.Select(x => new ItemsList { Value = x.glo01codigo, Text = x.glo01descripcion }).ToList();
        //        return Json.JsonSerializer.ToJson(new { data = lista, result = "1", message = "OK" });
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.Error("BuscarAyudaGlobal", ex);
        //        return Json.JsonSerializer.ToJson(new { data = string.Empty, result = "0", message = "Ocurrio error en ayuda global." });
        //    }
        //}
        //[WebMethod()]
        //public string BuscarMaquinaCallBack(string args)
        //{
        //    try
        //    {
        //        string[] parametros = args.Split(',');
        //        List<TablaGlobal> TablaGlobal = new List<TablaGlobal>();
        //        TablaGlobal = GlobalLogic.Instance.TraeAyudaGlobalTouch(_auditoria.Usuario.CodigoEmpresa, "MAQUINA", "0101");
        //        List<ItemsList> lista = new List<ItemsList>();
        //        lista = TablaGlobal.Select(x => new ItemsList { Value = x.glo01codigo, Text = x.glo01descripcion }).ToList();
        //        return Json.JsonSerializer.ToJson(new { data = lista, result = "1", message = "OK" });
                
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.Error("BuscarAyudaGlobal", ex);
        //        return Json.JsonSerializer.ToJson(new { data = string.Empty, result = "0", message = "Ocurrio error en ayuda global. Ver detalle:" + ex.Message });
        //    }

        ////}
        //[WebMethod()]
        //public string BuscarColorCallBack(string args)
        //{
        //    try
        //    {
        //        List<TablaGlobal> TablaGlobal = new List<TablaGlobal>();
        //        TablaGlobal = GlobalLogic.Instance.TraeAyudaGlobalTouch("01", "COLOR", "");
        //        List<ItemsList> lista = new List<ItemsList>();
        //        lista = TablaGlobal.Select(x => new ItemsList { Value = x.glo01codigo, Text = x.glo01descripcion }).ToList();
        //        return Json.JsonSerializer.ToJson(new { data = lista, result = "1", message = "OK" });
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.Error("BuscarAyudaGlobal", ex);
        //        return Json.JsonSerializer.ToJson(new { data = string.Empty, result = "0", message = "Ocurrio error en ayuda global.Ver detalle:" + ex.Message });
        //    }
        //}

        //public string BuscarClientesCallBack(string args)
        //{
        //    try
        //    {
                
        //        List<Cliente> listaCliente = LeerListaDeCliente();
        //        List<ItemsList> lista = new List<ItemsList>();
        //        lista = listaCliente.Select(x => new ItemsList { Value = x.Codigo, Text = x.Nombre }).ToList();
        //        return Json.JsonSerializer.ToJson(new { data = lista, result = "1", message = "OK" });
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger.Error("BuscarClientesCallBack", ex);
        //        return Json.JsonSerializer.ToJson(new { data = string.Empty, result = "0", message = "Ocurrió error inesperado." });
        //    }
        //}

        //Cargar datos en tabla de detalle de corte
        //private List<MovimientoResponse> LeerDetalleCorte()
        //{
        //    //Operario	H.Inicio	H.Fin	Cant.	Almacen	Producto	UM	Largo	Ancho	Espesor	MT2	MT3	Canastilla	H.Salida	Motivo
        //    MovimientoResponse mov = new MovimientoResponse();
        //    //mov.Operador
        //}
        /*
         Operario	H.Inicio	H.Fin	Cant.	Almacen	Producto	UM	Largo	Ancho	Espesor	MT2	MT3	Canastilla	H.Salida	Motivo	Acciones
         PALOMINO VELIZ JOEL	06:35	05:00	30	CORTE ALMACEN	FILAÑA Laguna ESPECIAL X ESPECIAL X ESPECIAL	pza	1.3	13	50	12.8778	0.64389	3456	00:00	Motivo
         */
    }
}