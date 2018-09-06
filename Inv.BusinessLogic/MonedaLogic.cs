using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inv.BusinessEntities;
using Inv.DataAccess;
using System.Data;

namespace Inv.BusinessLogic
{
    public class MonedaLogic
    {
        #region Singleton
        private static volatile MonedaLogic instance;
        private static object syncRoot = new Object();

        private MonedaLogic() { }

        public static MonedaLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new MonedaLogic();
                    }
                }

                return instance;
            }
        }
        #endregion

        public List<ItemsList> ObtenerListItems()
        {
            Moneda moneda = new Moneda();
            List<Moneda> monedas = new List<Moneda>();
            moneda.Codigo = "S"; moneda.Descripcion = "Soles";
            monedas.Add(moneda);

            moneda = new Moneda();
            moneda.Codigo = "D"; moneda.Descripcion = "Dólares";
            monedas.Add(moneda);

            return monedas.Select(x => new ItemsList { Value = x.Codigo, Text = x.Descripcion }).ToList();
        }

        public List<Moneda> TraerMoneda(string @glo01codigotabla)
        {
            return Accessor.TraerMoneda(glo01codigotabla);
        }
        
        public List<Moneda> ListarMonedas(string @campo, string @filtro)
        {
            return Accessor.TraerTodoMonedas(@campo, @filtro);
        }
        public void InsertarMoneda(Moneda pMoneda, out int @flag,
        out string @msgretorno)
        {
            Accessor.Spu_Fact_Ins_FAC54_MONEDA(pMoneda.FAC54CODIGO, 
            pMoneda.FAC54DESCRIPCION, pMoneda.FAC54ABREV, pMoneda.FAC54SIGNO, 
            pMoneda.FAC54FEMONEDACOD, out @flag,
            out @msgretorno);
        }
        public void ActualizarMoneda(Moneda pMoneda, out int @flag,
        out string @msgretorno)
        {
            Accessor.Spu_Fact_Upd_FAC54_MONEDA(pMoneda.FAC54CODIGO,
            pMoneda.FAC54DESCRIPCION, pMoneda.FAC54ABREV, pMoneda.FAC54SIGNO, 
            pMoneda.FAC54FEMONEDACOD, out @flag,
            out @msgretorno);
        }


        public void EliminarMoneda(string @FAC54CODIGO, out int @flag, out string @msgretorno)
        {
            Accessor.Spu_Fact_Del_FAC54_MONEDA(@FAC54CODIGO, out @flag, out @msgretorno);
        }

        #region Accessor

        private static MonedaAccesor Accessor
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return MonedaAccesor.CreateInstance(); }
        }

        #endregion Accessor
    }
}
