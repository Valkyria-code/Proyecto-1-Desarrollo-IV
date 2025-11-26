using Proyecto_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2.Services
{
    public interface ICalculoService
    {
        //para obtener todos los cálculos
        Task<List<Calculo>> ObtenerTodosAsync();

        //para los cálculos por tipo de operación
        Task<List<Calculo>> ObtenerSumasAsync();
        Task<List<Calculo>> ObtenerRestasAsync();
        Task<List<Calculo>> ObtenerMultiplicacionesAsync();
        Task<List<Calculo>> ObtenerDivisionesAsync();

        //opcional: obtener los cálculos mayores a cierto valor
        Task<List<Calculo>> ObtenerPorResultadoMayorAsync(double valor);

        //para crear un nuevo cálculo
        Task<bool> CrearCalculoAsync(CalculoRequest calculo);
    }
}
