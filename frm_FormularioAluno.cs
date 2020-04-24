using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formmsture101
{
    public partial class frm_FormularioAluno : Form
    {
        //Thread comando;
        const string ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DB_Formmsture101;Integrated Security=True";
        //const string ConnectionString = @"Data Source=SNPRT02LABF07\SQLEXPRESS;Initial Catalog=DB_Formmsture101;Integrated Security=True";
        SqlConnection _connect = new SqlConnection(ConnectionString);
        TimeSpan final = new TimeSpan(0, 3, 00);
        DateTime? time = null;

        public frm_FormularioAluno()
        {
            InitializeComponent();
            //LoadDGV();
        }

        private void OnTabChanged(object sender, EventArgs e)
        {
            if (tab_TextoAlternativa.SelectedIndex == 1 && time == null)
            {
                time = DateTime.Now;
                TimerBomb.Start();
            }
        }

        private void TimerBomb_Tick(object sender, EventArgs e)
        {
            var timespan = final - (DateTime.Now - time).Value;
            lblTIMER.Text = $"{timespan.Minutes.ToString("03")}:{timespan.Seconds.ToString("00")}";
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            TimerBomb.Stop();
            time = null;

        }

        //private void LoadDGV()
        //{
        //    using (_connect)
        //    {
        //        try
        //        {
        //            _connect.Open();
        //            SqlDataAdapter _CMDP = new SqlDataAdapter("SELECT ID_Aluno [CÓDIGO DE REALIZAÇÃO]," +
        //                                                                       " FK_ID_Prof [MATÉRIA]," +
        //                                                                      " FK_ID_Equipe [EQUIPE]," +
        //                                                                          " FK_ID_Sala [SALA]," +
        //                                                                        " FK_ID_Turno [TURNO]," +
        //                                                                     " ResFormEqp [RESULTADO]," +
        //                                                         " DataRes [ENTREGUE EM:] FROM tb_Aluno", _connect);
        //            DataTable _dt = new DataTable();
        //            _CMDP.Fill(_dt);
        //        }
        //        catch (Exception)
        //        {
        //            ErrorLoaded();
        //        }
        //        finally
        //        {
        //            _connect.Close();
        //        }
        //    }
        //}

        private void ErrorLoaded()
        {
            const string message = "As informações não puderam ser carregadas, tente novamente mais tarde!";
            const string caption = "Erro no Banco de Dados!";
            var result = MessageBox.Show(message, caption);

            if (result == DialogResult.OK)
            {

            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void tab_Texto_Click(object sender, EventArgs e)
        {

        }

        private void btnADD_Nivel_Click(object sender, EventArgs e)
        {

        }
    }
}
