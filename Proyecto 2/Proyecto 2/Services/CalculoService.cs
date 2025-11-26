using Proyecto_2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Proyecto_2.Services
{
    public class CalculoService : ICalculoService
    {
        private readonly string connectionString;

        public CalculoService()
        {
            connectionString = ConfigurationManager.ConnectionStrings["CalculadoraDB"].ConnectionString;
        }

        public async Task<List<Calculo>> ObtenerTodosAsync()
        {
            var calculos = new List<Calculo>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "select Id, Operacion, Resultado, Fecha from Historial order by Fecha desc";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        calculos.Add(new Calculo
                        {
                            Id = reader.GetInt32(0),
                            Operacion = reader.GetString(1),
                            Resultado = reader.GetString(2),
                            Fecha = reader.GetDateTime(3)
                        });
                    }
                }
            }

            return calculos;
        }

        public async Task<List<Calculo>> ObtenerSumasAsync()
        {
            return await ObtenerPorOperadorAsync("+");
        }

        public async Task<List<Calculo>> ObtenerRestasAsync()
        {
            return await ObtenerPorOperadorAsync("-");
        }

        public async Task<List<Calculo>> ObtenerMultiplicacionesAsync()
        {
            return await ObtenerPorOperadorAsync("*");
        }

        public async Task<List<Calculo>> ObtenerDivisionesAsync()
        {
            return await ObtenerPorOperadorAsync("/");
        }

        private async Task<List<Calculo>> ObtenerPorOperadorAsync(string operador)
        {
            var calculos = new List<Calculo>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "select Id, Operacion, Resultado, Fecha from Historial where Operacion like @Operador order by Fecha desc";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Operador", $"%{operador}%");

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            calculos.Add(new Calculo
                            {
                                Id = reader.GetInt32(0),
                                Operacion = reader.GetString(1),
                                Resultado = reader.GetString(2),
                                Fecha = reader.GetDateTime(3)
                            });
                        }
                    }
                }
            }

            return calculos;
        }

        public async Task<List<Calculo>> ObtenerPorResultadoMayorAsync(double valor)
        {
            var calculos = new List<Calculo>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = @"select Id, Operacion, Resultado, Fecha from Historial where TRY_Cast(Resultado as float) > @Valor order by TRY_CAST(Resultado as float) desc";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Valor", valor);

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            calculos.Add(new Calculo
                            {
                                Id = reader.GetInt32(0),
                                Operacion = reader.GetString(1),
                                Resultado = reader.GetString(2),
                                Fecha = reader.GetDateTime(3)
                            });
                        }
                    }
                }
            }

            return calculos;
        }

        public async Task<bool> CrearCalculoAsync(CalculoRequest calculo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string query = "insert into Historial (Operacion, Resultado, Fecha) values (@Operacion, @Resultado, getdate())";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Operacion", calculo.Operacion);
                        command.Parameters.AddWithValue("@Resultado", calculo.Resultado);

                        int rowsAffected = await command.ExecuteNonQueryAsync();
                        return rowsAffected > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}