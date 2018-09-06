using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using log4net.Config;
using log4net.Repository.Hierarchy;
using ucLogApp;

namespace Prod.UI.Web
{
    public static class Logger
    {
        private static readonly log4net.ILog logM = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void Error(string source, Exception ex)
        {
            /*
            ILog logger = LogManager.GetLogger("Logger"); //"Logger"
            // Cargamos la configuración  
            XmlConfigurator.Configure();
            // Registramos nuestra excepción  
            logger.Error(source, ex);
            */
            try
            {
                ucLog.GrabarLogError("SIM", new Auditoria().Usuario.Codigo, source, ex);
            }
            catch (Exception)
            { }
        }
        public static void Info(string info)
        {
            /*
            ILog logger = LogManager.GetLogger("Logger"); //"Logger"
            // Cargamos la configuración  
            XmlConfigurator.Configure();
            // Registramos nuestra excepción  
            logger.Info(info);
            */
            //ucLog.GrabarLogError("SIM", new Auditoria().Usuario.CodigoUsuario, "", ex);
        }
    }
}