using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Data;
using System;

namespace Inv.BusinessEntities
{
            [TableName("come05sedesCliente")]
    public class Sede
    {
                [MapField("come05empresa")]
                public string come05empresa { get; set; }
                [MapField("come05clientetipana")]
                public string come05clientetipana{get;set;}
                [MapField("come05clientecod")]
                public string come05clientecod{get;set;}
                [MapField("come05sedeclientescod")]
                public string come05sedeclientescod{get;set;}
                [MapField("come05sedeclientesdesc")]
                public string come05sedeclientesdesc{get;set;}
                [MapField("come05sedeclientesdireccion")]
                public string come05sedeclientesdireccion{get;set;}
                [MapField("come05sedeclientesreferencia")]
                 public string come05sedeclientesreferencia { get; set; }
                                    
                    
               
    }
}
