using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class OpcionesDAL
    {
        public DataTable opcion1dal()
        {
            string consulta = "SELECT (NOMBRE+' '+APELLIDO)Nombre FROM CLIENTE C INNER JOIN PERSONA P ON P.IDPERSONA=C.IDPERSONA";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
