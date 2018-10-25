using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace WEBAPI.Models
{
    public class Contexto:DbContext
    {
        public Contexto() : base("APIADS") { }

        public DbSet<Produto> Produtos { get; set; }
        //implementar demais classes
    }
}