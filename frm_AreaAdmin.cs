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
    public partial class frm_AreaAdmin : Form
    {
        //Thread comando;
        const string ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DB_Formmsture101;Integrated Security=True";
        //const string ConnectionString = @"Data Source=SNPRT02LABF07\SQLEXPRESS;Initial Catalog=DB_Formmsture101;Integrated Security=True";
        SqlConnection _connect = new SqlConnection(ConnectionString);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                      // Métodos //
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void frm_AreaAdmin_Load(object sender, EventArgs e)
        {
            //LoadDGV();
        }

        public frm_AreaAdmin()
        {
            InitializeComponent();
        }

        private void Logoff()
        {
            Application.Run(new frm_TelaInicio());
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLogoff__Click(object sender, EventArgs e)
        {
            ExitForms();
        }

        private void picLogoff_Click(object sender, EventArgs e)
        {
            ExitForms();
        }

        //private void LoadDGV()
        //{
        //    using (_connect)
        //    {
        //        try
        //        {
        //            _connect.Open();
        //            SqlDataAdapter _CMDP = new SqlDataAdapter("SELECT ID_Prof [CÓDIGO], NomeProf [NOME DO PROFESSOR], SenhaProf [SENHA DO PROFESSOR], MateriaProf [MATÉRIA], FK_ID_Img [IMAGEM DE PERFIL] FROM tb_Professor", _connect);
        //            DataTable _dt = new DataTable();
        //            _CMDP.Fill(_dt);
        //            //_CMDP.Parameters.Add("@Prof", SqlDbType.VarChar).Value = dgvProfessoresCad;
        //            //_CMDP.Parameters.Add("@SenhaProf", SqlDbType.VarChar).Value = dgvProfessoresCad;
        //            //_CMDP.Parameters.Add("@Materia", SqlDbType.VarChar).Value = dgvProfessoresCad;

        //            // Método 1 - Método Direto
        //            dgvProfessoresCad.DataSource = _dt;
        //        }
        //        catch (Exception)
        //        {
        //            ErrorLoaded();
        //        }
        //        finally
        //        {
        //            _connect.Close();
        //        }
        //        //_CMDP.Parameters.Add("@ProfImagem", SqlDbType.VarChar).Value = dgvProfessoresCad;
        //        //var sqlDA = new SqlDataAdapter("SELECT * FROM tb_Professor WHERE NomeProf=@Prof, SenhaProf=@SenhaProf, MateriaProf=@Materia", _connect);
        //        //var sqlCB = new SqlCommandBuilder(sqlDA);
        //        //var _dt = new DataTable();
        //        //sqlDA.Fill(_dt);
        //        //var freioa_bs = new BindingSource();
        //        //freioa_bs.DataSource = _dt;
        //        //dgvProfessoresCad.DataSource = freioa_bs;
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

        // ctor
        public void _true()
        {
            txtMateria.ReadOnly = true;
            txtProfessor.ReadOnly = true;
            txtSenha.ReadOnly = true;
            txtSenhaNova.ReadOnly = true;
            txtSenhaNovaRepeat.ReadOnly = true;
        }

        // ctor
        public void _false()
        {
            txtMateria.ReadOnly = false;
            txtProfessor.ReadOnly = false;
            txtSenha.ReadOnly = false;
            txtSenhaNova.ReadOnly = false;
            txtSenhaNovaRepeat.ReadOnly = false;
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                      // RESTRIÇÃO ÚNICA //
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //_true();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //_false();
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                      // SEM USO //
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picProfessor_Click(object sender, EventArgs e)
        {

        }

        private void txtMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInserirImagem__Click(object sender, EventArgs e)
        {

        }

        private void picEditPerson_Click(object sender, EventArgs e)
        {

        }

        private void picLetter_Click(object sender, EventArgs e)
        {

        }

        private void picPerson_Click(object sender, EventArgs e)
        {

        }

        private void txtProfessor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void picSenha_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtSenhaNova_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaNovaRepeat_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
