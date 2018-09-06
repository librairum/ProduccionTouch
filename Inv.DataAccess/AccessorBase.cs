using BLToolkit.Aspects;
using BLToolkit.DataAccess;
using BLToolkit.Data;
using BLToolkit.Reflection;
using System.Configuration;
//using EtnaEncryptor;
//using Oracle.DataAccess.Client;

namespace Inv.DataAccess
{
    [Log, Counter]
    public abstract class AccessorBase<T> : DataAccessor where T : AccessorBase<T>
    {
        
        #region Overrides

        [NoInterception]
        protected override DbManager CreateDbManager()
        {
            try
            {
                //var conexion = new DbManager("cnnInventario");

                BLToolkit.Data.DataProvider.DataProviderBase SqlProv = new BLToolkit.Data.DataProvider.SqlDataProvider();
                string cadenaencriptado = ConfigurationManager.ConnectionStrings["cnnInventario"].ConnectionString;
                //string cadenaconexion = Rijndael.Desencriptar(cadenaencriptado);
                string cadenaconexion = "";
                DbManager conexion = new DbManager(SqlProv, cadenaconexion);
                                                
                conexion.Command.CommandTimeout = 0;
                
                return conexion;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        //protected override DbManager CreateDbManager()
        //{
        //    try
        //    {
        //        DbManager conector = new DbManager( 
        //    }
        //    catch (System.Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        #endregion
        #region CreateInstance

        public static T CreateInstance()
        {
            return TypeAccessor<T>.CreateInstance();
        }

        #endregion
        #region Query

        [Log, Counter]
        public abstract class CoreQuery : SqlQuery
        {
            [NoInterception]
            protected override DbManager CreateDbManager()
            {
                return new DbManager("cnnInventario");
            }
        }
        public CoreQuery Query
        {
            get { return TypeAccessor<CoreQuery>.CreateInstance(); }
        }

        #endregion
    }
}
