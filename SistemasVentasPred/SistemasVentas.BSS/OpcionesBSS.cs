using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class OpcionesBSS
    {
        OpcionesDAL dal = new OpcionesDAL();
        public DataTable MostrarOpcion1Bss()
        {
            return dal.opcion1dal();
        }
    
        }
