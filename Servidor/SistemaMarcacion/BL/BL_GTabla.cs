using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class BL_GTabla
    {
        //bl de mantenimiento de sgmTabla

        DA.DAGTabla DaTemp = new DA.DAGTabla();

        public bool BLPMIGTabla(string sTabla,string sCadena)
        {
            return DaTemp.PIGTabla(sTabla, sCadena);
        }

        public bool BLPMUGTabla(string sTabla,string sCodigo,string sCadena)
        {
            return DaTemp.PUGTabla(sTabla, sCodigo, sCadena);
        }
    }
}
