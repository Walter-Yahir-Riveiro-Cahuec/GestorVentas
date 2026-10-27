using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GestorVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento Load del formulario. Inicializa el formato de la columna Monto,
        /// carga los datos desde la base de datos y calcula el promedio general.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Aplica formato de moneda ($) a la columna "Monto" del DataGridView en la Pestaña 2
            AplicarFormatoMoneda();

            // Carga inicial de datos de la tabla Ventas
            CargarVentas();

            // Calcula el promedio general y lo asigna al label lblPromedioGeneral
            CalcularPromedioGeneral();
        }

        /// <summary>
        /// Aplica el formato de moneda ($) a la columna "Monto" en el DataGridView de la Pestaña 2.
        /// </summary>
        public void AplicarFormatoMoneda()
        {
            if (dgvVentas.Columns["Monto"] is DataGridViewColumn colMonto)
            {
                colMonto.DefaultCellStyle.Format = "C2";
                colMonto.DefaultCellStyle.FormatProvider = new CultureInfo("en-US");
            }
        }

        /// <summary>
        /// Carga los registros de la tabla Ventas en el DataGridView de la Pestaña 2 usando ADO.NET.
        /// </summary>
        public void CargarVentas()
        {
            try
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    string sql = "SELECT Id, Cliente, Fecha, Monto FROM Ventas";
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvVentas.AutoGenerateColumns = false;
                        dgvVentas.DataSource = dt;
                    }
                }

                // Reasegurar el formato de moneda tras enlazar datos
                AplicarFormatoMoneda();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al cargar ventas: {ex.Message}");
            }
        }

        /// <summary>
        /// Calcula el promedio matemático general del campo "Monto" en la tabla "Ventas"
        /// utilizando ADO.NET (SqlCommand.ExecuteScalar) y asigna el resultado formateado
        /// al texto del Label "lblPromedioGeneral".
        /// </summary>
        /// <returns>El valor decimal del promedio calculado.</returns>
        public decimal CalcularPromedioGeneral()
        {
            decimal promedio = 0m;
            string query = "SELECT AVG(Monto) FROM Ventas";

            try
            {
                using (SqlConnection conn = Conexion.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        object resultado = cmd.ExecuteScalar();

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            promedio = Convert.ToDecimal(resultado);
                        }
                    }
                }

                // Asignar el resultado con formato de moneda al Label lblPromedioGeneral
                lblPromedioGeneral.Text = promedio.ToString("C2", new CultureInfo("en-US"));
            }
            catch (Exception ex)
            {
                lblPromedioGeneral.Text = "$0.00";
                System.Diagnostics.Debug.WriteLine($"Error al calcular promedio general: {ex.Message}");
            }

            return promedio;
        }

        /// <summary>
        /// Evento de recarga de datos y recálculo del promedio.
        /// </summary>
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarVentas();
            CalcularPromedioGeneral();
        }
    }
}
