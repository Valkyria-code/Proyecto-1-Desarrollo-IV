using Proyecto_2.Models;
using Proyecto_2.Services;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace Proyecto_2.Controllers
{
    [RoutePrefix("api/calculos")]

    public class CalculosController : ApiController
    {
        private readonly ICalculoService _calculoService;

        public CalculosController()
        {
            _calculoService = new CalculoService();
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> ObtenerTodos()
        {
            try
            {
                var calculos = await _calculoService.ObtenerTodosAsync();
                return Ok(calculos);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("sumas")]
        public async Task<IHttpActionResult> ObtenerSumas()
        {
            try
            {
                var sumas = await _calculoService.ObtenerSumasAsync();
                return Ok(sumas);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("restas")]
        public async Task<IHttpActionResult> ObtenerRestas()
        {
            try
            {
                var restas = await _calculoService.ObtenerRestasAsync();
                return Ok(restas);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("multiplicaciones")]
        public async Task<IHttpActionResult> ObtenerMultiplicaciones()
        {
            try
            {
                var multiplicaciones = await _calculoService.ObtenerMultiplicacionesAsync();
                return Ok(multiplicaciones);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("divisiones")]
        public async Task<IHttpActionResult> ObtenerDivisiones()
        {
            try
            {
                var divisiones = await _calculoService.ObtenerDivisionesAsync();
                return Ok(divisiones);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("mayores/{valor}")]
        public async Task<IHttpActionResult> ObtenerMayoresA(double valor)
        {
            try
            {
                var calculos = await _calculoService.ObtenerPorResultadoMayorAsync(valor);
                return Ok(calculos);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> CrearCalculo([FromBody] CalculoRequest calculo)
        {
            try
            {
                if (calculo == null || string.IsNullOrEmpty(calculo.Operacion) || string.IsNullOrEmpty(calculo.Resultado))
                {
                    return BadRequest("Operación y Resultado son obligatorios.");
                }

                bool exito = await _calculoService.CrearCalculoAsync(calculo);

                if (exito)
                {
                    return Created("api/calculos", calculo);
                }
                else
                {
                    return InternalServerError(new Exception("No se pudo crear el cálculo"));
                }
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}