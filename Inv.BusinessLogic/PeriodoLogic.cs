using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inv.BusinessEntities;
using Inv.DataAccess;


namespace Inv.BusinessLogic
{
    public class PeriodoLogic
    {
        #region Singleton
        private static volatile PeriodoLogic instance;
        private static object syncRoot = new Object();

        private PeriodoLogic() { }

        public static PeriodoLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new PeriodoLogic();
                    }
                }

                return instance;
            }
        }
        #endregion
        #region Accessor

        private static PeriodoAccesor Accesor
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return PeriodoAccesor.CreateInstance(); }
        }

        #endregion Accessor

        public List<Periodo> PeriodoTraer(string codigoEmpresa,string anio)
        {
            return Accesor.PeriodoTraer(codigoEmpresa, anio);
        }
        public List<Periodo> PeriodoTraerTodos(string codigoEmpresa)
        {
            return Accesor.PeriodoTraerTodos(codigoEmpresa);
        }
        public List<Periodo> MesesxAnio(string @cEmpresa, string @cAno)
        {
            return Accesor.MesesxAnio(@cEmpresa, @cAno);
        }

        public void PeriodoModificarEstado(Periodo periodo, out int @flagok, out string @cMsgRetorno)
        {
            @cMsgRetorno = string.Empty;

            Accesor.PeriodoModificarEstado(periodo.ccb03emp, periodo.ccb03cod, periodo.ccb03proc, out @flagok, out @cMsgRetorno);
         }
               
        public List<ItemsList> PeriodosObtenerListItems(string codigoEmpresa,string anio)
        {
            var lista = Accesor.PeriodoTraer(codigoEmpresa, anio);
            return lista.Select(x => new ItemsList { Value = x.ccb03cod, Text = x.ccb03des }).ToList();
            
        }
        public void GeneraPeriodoCierre(string @cCodEmp, string @cAnnoOrigen, string @cAnnoDestino, out float @nRetornar) {
            @nRetornar = 0;
            Accesor.GeneraPeriodoCierre(@cCodEmp, @cAnnoOrigen, @cAnnoDestino, out @nRetornar);
        }
        public void GeneraPeriodoApertura(string @cCodEmp, string @cAnno, string @cAnnoDestino, string @cMes, out float @nRetornar) 
        {
            @nRetornar = 0;
            Accesor.GeneraPeriodoApertura(@cCodEmp, @cAnno, @cAnnoDestino, @cMes, out @nRetornar);
        }

            }
}
