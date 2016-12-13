using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BL
{
    public class BL_MHora
    {
        DA.DAVMHora DaTemp = new DA.DAVMHora();

        #region consulta de las horas creadas
        public DataTable BLPMCHorasTodas(int sCodigoHora)
        {
            DataTable dtTemp = new DataTable();
            dtTemp = DaTemp.PCHora(0);
            return dtTemp;
        }
        #endregion

        #region Cargar una hora
        public BC.VMHora BLPMCHoraSoloUna(int sCodigoHora)
        {
            DataTable dtTemp = new DataTable();
            BC.VMHora Temp = new BC.VMHora();
            dtTemp = DaTemp.PCHora(0);

            if (dtTemp.Rows.Count > 0)
            {
                Temp.CodigoHora = int.Parse(dtTemp.Rows[0]["CodigoHora"].ToString());
                Temp.HoraEntrada = DateTime.Parse(dtTemp.Rows[0]["HoraEntrada"].ToString());
                Temp.HoraSalida = DateTime.Parse(dtTemp.Rows[0]["HoraSalida"].ToString());
                Temp.HorarioNocturno = bool.Parse(dtTemp.Rows[0]["HorarioNocturno"].ToString());
            }

            return Temp;
        }
        #endregion

        #region Insertar Hora
        public bool BLPMIHora(BC.VMHora svmHora)
        {
            return DaTemp.PIHora(svmHora);
        }
        #endregion

        #region Actualizar Hora
        public bool BLPMUHora(BC.VMHora svmHora)
        {
            return DaTemp.PUHora(svmHora);
        }
        #endregion

        #region eliminar hora
        public bool BLPMDHora(int sCodigoHora)
        {
            return DaTemp.PDHora(sCodigoHora);
        }
        #endregion
    }
}
