using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contract
{
    public interface IOperacionesCrud<T>
    {
        string Insertar(T dto);
        string Actualizar(T dto);
        string Eliminar(string dto);
        List<T> Listar();
    }
}
