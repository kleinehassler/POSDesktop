using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSDesktop.Entidades.Entidades
{
    public class Sujetos
    {
        public int id { get; set; }
        public int scode { get; set; }
        public string sname { get; set; }
        public int iscliente { get; set; }
        public int isproveedor { get; set; }
        public string numtribu { get; set; }
        public string direccion { get; set; }
        public int ciudad { get; set; }
        public int parroquia { get; set; }
        public string telefono { get; set; }
        public string telefono2 { get; set; }
        public string smail { get; set; }
        public decimal saldoxc { get; set; }
        public decimal saldoxp { get; set; }
        public int isactivo { get; set; }
        public int empresa { get; set; }
        public int fechacorte { get; set; }
        public int issuspendido { get; set; }
        public DateTime fecsuspe { get; set; }
        public DateTime fecreact { get; set; }
        public string maplati { get; set; }
        public string maplong { get; set; }
        public string mapurl { get; set; }
        public string mapgeocode { get; set; }
        public int radio { get; set; }
        public int anticipo { get; set; }
        public int rubrofac { get; set; }
        public int isdeuda { get; set; }
        public DateTime fecdocdeuda { get; set; }
        public int seleccionado { get; set; }
        public decimal cupo { get; set; }
        public int tiplispre { get; set; }
        
    }
}
