using DataAccess;
using Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class NegTVacunas
    {
        public string Actualizar(TVacunasBO dto)
        {
            daoTVacunas dao = new daoTVacunas();
            return dao.Actualizar(dto);
        }

        public string Eliminar(string dto)
        {
            daoTVacunas dao = new daoTVacunas();
            return dao.Eliminar(dto);
        }

        public string Insertar(TVacunasBO dto)
        {
            daoTVacunas dao = new daoTVacunas();
            return dao.Insertar(dto);
        }

        public List<TVacunasBO> Listar()
        {
            daoTVacunas dao = new daoTVacunas();
            return dao.Listar()
;        }
    }
}
