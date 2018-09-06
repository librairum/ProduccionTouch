﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inv.BusinessEntities;
using Inv.DataAccess;
using System.Data;

namespace Inv.BusinessLogic
{
  public  class SeriesLogic
    {
       #region Singleton
      private static volatile SeriesLogic instance;
        private static object syncRoot = new Object();

        private SeriesLogic() { }

        public static SeriesLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SeriesLogic();
                    }
                }

                return instance;
            }
        }
        #endregion


        public List<Series> TraeSeries(Series serie,
            string @campo, string @filro) 
        {
            return Accessor.TraeSeries(serie.FAC07CODEMP, serie.FAC01COD,
                @campo, @filro);
            //  Set RS = CLS_COMANDO.Ejec_Comando_1("Spu_Fact_Trae_FAC01_TIPDOC", gbCodEmpresa, "FAC01COD", "*")
        }


        public void InsertarSerie(Series serie, out string @msgretorno) 
        {
            Accessor.InsertarSerie(serie.FAC07CODEMP, serie.FAC01COD, serie.FAC07SERIE, serie.FAC07DESC,
                serie.FAC07ABREVIA, serie.FAC07NUMERO, out @msgretorno);        
        }


        public void ActualizarSerie(Series serie, out string @msgretorno) 
        {
            Accessor.ActualizarSerie(serie.FAC07CODEMP, serie.FAC01COD, serie.FAC07SERIE,
            serie.FAC07DESC, serie.FAC07ABREVIA, serie.FAC07NUMERO,out @msgretorno);
        }


        public void EliminarSerie(Series serie, out string @msgretorno) 
        {
            Accessor.EliminarSerie(serie.FAC07CODEMP, serie.FAC01COD, serie.FAC07SERIE, out @msgretorno);

        }

        #region Accessor

        private static SeriesAccesor Accessor
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return SeriesAccesor.CreateInstance(); }
        }

        #endregion Accessor
    }
}
