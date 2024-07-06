using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesktop.Entidades
{
    public class Items
    {
        public int id {  get; set; }
        public int icode { get; set; }
        public string iname { get; set; }
        public int icategoria { get; set; }
        public int isubcategoria { get; set;}
        public decimal precio { get; set; }
        public decimal precio2 { get; set; }
        public decimal precio3 { get; set; }
        public decimal costo { get; set; }
        public int marca { get; set; }
        public int modelo { get; set; }
        public int isiva { get; set; }
        public decimal saldoi { get; set; }
        public decimal saldo { get; set; }
        public string fotografia { get; set; }
        public string codbarra { get; set; }
        public string imagen { get; set; }
        public int isactivo { get; set; }
        public int kardex { get; set; }
        public int stockmax { get; set; }
        public int stockmin { get; set; }
        public decimal saldohis { get; set;}
        public DateTime fecsaldo { get; set; }
        public int iscomposition { get; set; }
        public int isprinting { get; set; }
        public string iname2 { get; set; }
        public decimal saldobodega { get; set;}
        public decimal ultcosto { get; set;}
        public decimal procosto { get; set; }
        public string codbarra2 { get; set; }
        public int poriva { get; set; }

    }
}
}
