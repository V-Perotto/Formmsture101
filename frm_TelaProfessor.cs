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
    public partial class frm_TelaProfessor : Form
    {
        //Thread comando;
        const string ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DB_Formmsture101;Integrated Security=True"; 
        //const string ConnectionString = @"Data Source=SNPRT02LABF07\SQLEXPRESS;Initial Catalog=DB_Formmsture101;Integrated Security=True";
        SqlConnection _connect = new SqlConnection(ConnectionString);

        private void EditInfo()
        {
            Application.Run(new frm_EditInfoLogADM());
        }

        private void AddForms()
        {
            Application.Run(new frm_ADDFormulario());
        }

        private void ExitForms()
        {
            //const string message = "Deseja Sair?";
            //const string caption = "Logoff";
            //var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result == DialogResult.Yes)
            //{
            //    this.Close();
            //    comando = new Thread(Logoff);
            //    comando.SetApartmentState(ApartmentState.STA);
            //    comando.Start();
            //}
        }

        private void Logoff()
        {
            Application.Run(new frm_TelaInicio());
        }

        public frm_TelaProfessor()
        {
            InitializeComponent();
        }

        public string Professor { get; set; }

        public frm_TelaProfessor(string professor)
        {
            InitializeComponent();
            Professor = txtProfessor.Text;
        }
      
        private void btnCriar_Click(object sender, EventArgs e)
        {
            //this.Close();
            //comando = new Thread(AddForms);
            //comando.SetApartmentState(ApartmentState.MTA);
            //comando.Start();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {

        }

        private void btnEditForms_Click(object sender, EventArgs e)
        {

        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            //this.Close();
            //comando = new Thread(EditInfo);
            //comando.SetApartmentState(ApartmentState.MTA);
            //comando.Start();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picLogoff_Click(object sender, EventArgs e)
        {
            ExitForms();
        }

        private void lblLogoff__Click(object sender, EventArgs e)
        {
            ExitForms();
        }

        private void frm_TelaProfessor_Load(object sender, EventArgs e)
        {
            //LoadDGV();
            //if (this.Professor.Equals(""))
            //    txtProfessor.Text = this.Professor;
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

        //            // Método 1 - Método Direto
        //            dgvAlunosFormCad.DataSource = _dt;
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
            const string message = "O Banco de Dados não pode ser carregado, tente novamente mais tarde!";
            const string caption = "Erro no Banco de Dados";
            var result = MessageBox.Show(message, caption);

            if (result == DialogResult.OK)
            {

            }
        }
    }
}
