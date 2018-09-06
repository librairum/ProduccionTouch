using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inv.BusinessEntities;
using Inv.DataAccess;
using System.Data;
namespace Inv.BusinessLogic
{
   public  class SubPlantillaLogic
    {
       #region Singleton
      private static volatile SubPlantillaLogic instance;
        private static object syncRoot = new Object();

        private SubPlantillaLogic() { }

        public static SubPlantillaLogic Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SubPlantillaLogic();
                    }
                }

                return instance;
            }
        }
        #endregion

        //[SprocName("Spu_Fact_Ins_FAC03_SUBPLANTILLA")]
        public void InsertarSubPlantilla(SubPlantilla subplantilla, out string @msgretorno) 
        {
            Accessor.InsertarSubPlantilla(subplantilla.FAC03CODEMP, subplantilla.FAC03COD, subplantilla.FAC01COD,
         subplantilla.FAC02COD, subplantilla.FAC03DESC, subplantilla.FAC03FLAGNUMERA, subplantilla.FAC03CANITEMS,
         subplantilla.FAC03SERIEXDEF, subplantilla.FAC03TIPART, out @msgretorno);
        }

        //[SprocName("Spu_Fact_Upd_FAC03_SUBPLANTILLA")]
        public void ActualizarSubPlantilla(SubPlantilla subplantilla, out string @msgretorno) 
        {
            Accessor.ActualizarSubPlantilla(subplantilla.FAC03CODEMP, subplantilla.FAC03COD, subplantilla.FAC01COD,
          subplantilla.FAC02COD, subplantilla.FAC03DESC, subplantilla.FAC03FLAGNUMERA, subplantilla.FAC03CANITEMS,
          subplantilla.FAC03SERIEXDEF, subplantilla.FAC03TIPART, out @msgretorno);
        }


        //[SprocName("Spu_Fact_DEL_FAC03_SUBPLANTILLA")]
        public void EliminarSubPlantilla(SubPlantilla subplantilla, out string @msgretorno)
        {
            Accessor.EliminarSubPlantilla(subplantilla.FAC03CODEMP, subplantilla.FAC03COD, 
                subplantilla.FAC01COD, out @msgretorno);
        }

        //[SprocName("Spu_Fact_Trae_FAC03_SUBPLANTILLA")]
        public List<SubPlantilla> TraeSubPlantilla(SubPlantilla subplantilla, string @campo, string @filro) 
        {
            return Accessor.TraeSubPlantilla(subplantilla.FAC03CODEMP, @campo, @filro);
        }
        public void DameDescripcion(string @cCodigo, string @cFlag, out string @cDescripcion) {
            Accessor.DameDescripcion(@cCodigo, @cFlag, out @cDescripcion);
        }


        public  List<TipoDocumentoVentas> TraeAyudaTipDoc(string @FAC01CODEMP, string @campo, string @filtro){
            return Accessor.TraeAyudaTipDoc(@FAC01CODEMP, @campo, @filtro);
        }

        public List<Plantilla> TraeAyudaPlantilla(string @FAC02CODEMP, string @campo, string @filro) {
            return Accessor.TraeAyudaPlantilla(@FAC02CODEMP, @campo, @filro);
        }
       
       //Traer el codigo y del descripcion del tipo de producto
        public List<Moneda> TraeAyudaProductos(string @glo01codigotabla, string @cCampo, string @cFiltro) { 
            return Accessor.TraeAyudaProductos(@glo01codigotabla, @cCampo, @cFiltro);
        }
        

        #region Accessor

        private static SubPlantillaAccesor Accessor
        {
            [System.Diagnostics.DebuggerStepThrough]
            get { return SubPlantillaAccesor.CreateInstance(); }
        }

        #endregion Accessor
    }
}
