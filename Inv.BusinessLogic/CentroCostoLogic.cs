using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inv.BusinessEntities;
using Inv.DataAccess;
using System.Data;

namespace Inv.BusinessLogic
{
    public class CentroCostoLogic
    {

        #region Singleton
        private static volatile CentroCostoLogic instance;
        private static object syncRoot = new Object();

        private CentroCostoLogic() { }

        public static CentroCostoLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new CentroCostoLogic();
                    }
                }

                return instance;
            }
        }
        #endregion


        public List<CentroCosto> TraerCentroCosto(string codigoEmpresa)
        {
            return Accessor.TraerCentroCosto(codigoEmpresa, "", "*");
        }

        public List<ItemsList> ObtenerListItems(string codigoEmpresa)
        {
            var lista = Accessor.TraerCentroCosto(codigoEmpresa, "", "*");
            return lista.Select(x => new ItemsList { Value = x.Codigo, Text = x.Descripcion }).ToList();
        }

        public DataTable ObtenerListDataTable(string codigoEmpresa)
        {
            var lista = Accessor.TraerCentroCosto(codigoEmpresa, "", "*");
            DataTable table = new DataTable("CentroCosto");
            table.Columns.Add("Text", typeof(string));
            table.Columns.Add("Value", typeof(string));

            foreach (var item in lista)
            {
                table.Rows.Add(item.Descripcion, item.Codigo);
            }
            return table;
        }

        #region Accessor

        private static CentroCostoAccesor Accessor
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return CentroCostoAccesor.CreateInstance(); }
        }

        #endregion Accessor
    }
}
