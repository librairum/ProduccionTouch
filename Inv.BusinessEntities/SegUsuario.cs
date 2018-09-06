using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLToolkit.Data;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;

namespace Inv.BusinessEntities
{
    [TableName("SegUsuario")]
   public class SegUsuario
    {
        [MapField("Codigo")]
        public string Codigo { get; set; }
        [MapField("NombreUsuario")]
        public string NombreUsuario { get; set; }
        [MapField("ClaveUsuario")]
        public string ClaveUsuario { get; set; }
        [MapField("CodigoPerfil")]
        public string  CodigoPerfil { get; set; }
        [MapField("CodigoEmpresa")]
        public string CodigoEmpresa { get; set; }
        public string NomApe { get; set; }
        public string NomPerfil { get; set; }
        public string NomEmpresa { get; set; }

    }
}
