//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vendas.Dados
{
    using System;
    using System.Collections.Generic;
    
    public partial class VendasServicos
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> CodProdServ { get; set; }
        public Nullable<System.DateTime> DataTransacao { get; set; }
        public string Tipo { get; set; }
        public Nullable<double> Quantidade { get; set; }
        public Nullable<double> ValorTotal { get; set; }
        public Nullable<int> CodCli { get; set; }
        public Nullable<int> CodOp { get; set; }
    }
}
