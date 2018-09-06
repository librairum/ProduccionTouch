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
    //Espacio de clase temporal para cargar Pedido de corte.
    public  class PedidoCorte
    {
        internal PedidoCorte(string parCodigoPedido, string parFechaPedido, 
            string parNumeroBloque, string parNombreOperario, string parNumeroOrdenDeTrabajo)
        {
            this.codigoPedido = parCodigoPedido;
            this.fechaPedido = parFechaPedido;
            this.numeroBloque = parNumeroBloque;
            this.nombreOperario = parNombreOperario;
            this.numeroOrdenDeTrabajo = parNumeroOrdenDeTrabajo;
        }
        internal PedidoCorte()
        {
        }

        private string codigoPedido;
        public string CodigoPedido
        {
            get { return codigoPedido; }
            set { codigoPedido = value; }
        }

        private string fechaPedido;
        public string FechaPedido
        {
            get { return fechaPedido; }
            set { fechaPedido = value; }
        }

        private string numeroBloque;
        public string NumeroBloque 
        {
            get { return numeroBloque; }
            set { numeroBloque = value; }
        }

        private string nombreOperario;
        public string NombreOperario
        {
            get { return nombreOperario; }
            set { nombreOperario = value; } 
        }

        private string numeroOrdenDeTrabajo;
        public string NumeroOrdenDeTrabajo
        {
            get { return numeroOrdenDeTrabajo; }
            set { numeroOrdenDeTrabajo = value; }
        }
    }
    public partial class WebForm1 : PageBase
    {

        PedidoCorte _pedidoCorte = new PedidoCorte();
        protected void Page_Load(object sender, EventArgs e)
        {
            base.OnInit(e);
            //CallbackManager.Register(ListarCortesDePedido);
        }

        public string ListarCortesDePedido(string args)
        {
            try
            {
                List<PedidoCorte> listaPedidoCorte = new List<PedidoCorte>();
                _pedidoCorte = new PedidoCorte("001", "14/08/2018", "3456", "Casas", "7254");
                listaPedidoCorte.Add(_pedidoCorte);

                _pedidoCorte = new PedidoCorte("002", "14/08/2018", "5578", "Medrano", "7255");
                listaPedidoCorte.Add(_pedidoCorte);

                _pedidoCorte = new PedidoCorte("003", "14/08/2018", "1634", "Palomino", "7256");
                listaPedidoCorte.Add(_pedidoCorte);

                _pedidoCorte = new PedidoCorte("004", "14/08/2018", "543", "Chavez", "7257");
                listaPedidoCorte.Add(_pedidoCorte);


                return Json.JsonSerializer.ToJson(new { data = listaPedidoCorte, result = "1", message = "OK" });
            }
            catch (Exception ex) {
                Logger.Error("Listar", ex);
                return JsonSerializer.ToJson(new { data = string.Empty, result = 0, message = "OK" });
            }
        }
    }
}