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
    public partial class frm_TelaInicio : Form
    {
        Thread comando;
        //const string ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DB_Formmsture101;Integrated Security=True";
        //const string ConnectionString = @"Data Source=SNPRT02LABF07\SQLEXPRESS;Initial Catalog=DB_Formmsture101;Integrated Security=True";
        //SqlConnection _connect = new SqlConnection(ConnectionString);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                            // Métodos //
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void WrongLogin()
        {
            const string message = "Usuário ou Senha incorretos!";
            const string caption = "Digite novamente";
            var result = MessageBox.Show(message, caption);

            if (result == DialogResult.OK)
            {
                picTeacher.Refresh();
                txtProfessor.Clear();
                txtSenha.Clear();
            }
        }

        private void WrongBob()
        {
            const string message = "Alguns dados estão incorretos, insira novamente!";
            const string caption = "Digite novamente";
            var result = MessageBox.Show(message, caption);

            if (result == DialogResult.OK)
            {
                boxMateria.Refresh();
                boxEquipe.Refresh();
                boxSala.Refresh();
                boxTurno.Refresh();
            }
        }

        public void AbreFecha()
        {
            picBox1.Visible = false;
            txtADMINname.Visible = false;
            txtADMINpass.Visible = false;
            picADMINpass.Visible = false;
            picADMINprsn.Visible = false;
            lblADM.Visible = false;
            btnADMIN.Visible = false;
            picClose.Visible = false;
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                             // Telas //
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public frm_TelaInicio()
        {
            InitializeComponent();
        }

        private void Admin()
        {
            Application.Run(new frm_AreaAdmin());
        }

        private void Aluno()
        {
            Application.Run(new frm_Formularios());
        }

        private void Prof()
        {
            Application.Run(new frm_TelaProfessor());
        }

        private void Cadastro()
        {
            Application.Run(new frm_CadProfLogADM());
        }

        private void frm_TelaCadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dB_Formmsture101DataSet11.tb_Aluno'. Você pode movê-la ou removê-la conforme necessário.
            //this.tb_AlunoTableAdapter.Fill(this.dB_Formmsture101DataSet11.tb_Aluno);
            // TODO: esta linha de código carrega dados na tabela 'dB_Formmsture101DataSet11.tb_Professor'. Você pode movê-la ou removê-la conforme necessário.
            //this.tb_ProfessorTableAdapter.Fill(this.dB_Formmsture101DataSet11.tb_Professor);
            // TODO: esta linha de código carrega dados na tabela 'dB_Formmsture101DataSet11.tb_Equipe'. Você pode movê-la ou removê-la conforme necessário.
            //this.tb_EquipeTableAdapter.Fill(this.dB_Formmsture101DataSet11.tb_Equipe);
            // TODO: esta linha de código carrega dados na tabela 'dB_Formmsture101DataSet11.tb_Sala'. Você pode movê-la ou removê-la conforme necessário.
            //this.tb_SalaTableAdapter.Fill(this.dB_Formmsture101DataSet11.tb_Sala);
            // TODO: esta linha de código carrega dados na tabela 'dB_Formmsture101DataSet11.tb_Turno'. Você pode movê-la ou removê-la conforme necessário.
            //this.tb_TurnoTableAdapter.Fill(this.dB_Formmsture101DataSet11.tb_Turno);
            //AbreFecha();
            //Refresh();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Ações //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // ADMIN - Professor
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            //SqlCommand _CMDP = new SqlCommand("SELECT * FROM tb_Professor WHERE NomeProf=@Prof AND SenhaProf=@SenhaProf", _connect);
            //_CMDP.Parameters.Add("@Prof", SqlDbType.VarChar).Value = txtProfessor.Text;
            //_CMDP.Parameters.Add("@SenhaProf", SqlDbType.VarChar).Value = txtSenha.Text;

            //try
            //{
            //    _connect.Open();
            //    SqlDataReader data_readp = _CMDP.ExecuteReader();

            //    if (data_readp.HasRows == false)
            //    {
            //        WrongLogin();
            //    }
            //    data_readp.Read();

            //    if (data_readp.HasRows == true)
            //    {
            //        MessageBox.Show("Login efetuado com sucesso!", "Formmsture 101 - Professor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Close();
            //        comando = new Thread(Prof);
            //        comando.SetApartmentState(ApartmentState.MTA);
            //        comando.Start();
            //    }
            //}

            //catch (Exception)
            //{
            //    WrongLogin();
            //}

            //finally
            //{
            //    _connect.Close();
            //}
        }

        // Cadastro Professor
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            comando = new Thread(Cadastro);
            comando.SetApartmentState(ApartmentState.MTA);
            comando.Start();
        }

        // Alunos - Equipe
        private void btnComecar_Click(object sender, EventArgs e)
        {
            //SqlCommand _CMD = new SqlCommand("SELECT P.FK_ID_Prof, E.FK_ID_Equipe, S.FK_ID_Sala, T.FK_ID_Turno, FROM tb_Aluno AS A FULL JOIN tb_Professor AS P, tb_Equipe AS E, tb_Sala AS S, tb_Turno AS T ON P.FK_ID_Prof = P.MateriaProf, E.FK_ID_Equipe = E.NumEqp, S.FK_ID_Sala = S.Sala, T.FK_ID_Turno = T.Turno, WHERE P.MateriaProf = @Materia, E.NumEqp = @Equipe, S.Sala = @Sala, T.Turno = @Turno", _connect);

            //_CMD.Parameters.Add("@Materia", SqlDbType.VarChar).Value = boxMateria.Text;
            //_CMD.Parameters.Add("@Equipe", SqlDbType.VarChar).Value = boxEquipe.Text;
            //_CMD.Parameters.Add("@Sala", SqlDbType.VarChar).Value = boxSala.Text;
            //_CMD.Parameters.Add("@Turno", SqlDbType.VarChar).Value = boxTurno.Text;

            //try
            //{
            //    _connect.Open();
            //    SqlDataReader data_read = _CMD.ExecuteReader();

            //    if (data_read.HasRows == false)
            //    {
            //        WrongBob();
            //    }
            //    data_read.Read();

            //    if (data_read.HasRows == true)
            //    {
            //        MessageBox.Show("Login efetuado com sucesso!", "Formmsture 101 - Login de Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Close();
            //        comando = new Thread(Aluno);
            //        comando.SetApartmentState(ApartmentState.MTA);
            //        comando.Start();
            //    }
            //}
            //catch (Exception)
            //{
            //    WrongBob();
            //}
            //finally
            //{
            //    _connect.Close();
            //}
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // RESTRIÇÃO ÚNICA //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void picPrograma_Click(object sender, EventArgs e)
        {
            picBox1.Visible = true;
            txtADMINname.Visible = true;
            txtADMINpass.Visible = true;
            picADMINpass.Visible = true;
            picADMINprsn.Visible = true;
            lblADM.Visible = true;
            btnADMIN.Visible = true;
            picClose.Visible = true;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            AbreFecha();
        }

        private void btnADMIN_Click(object sender, EventArgs e)
        {
            //SqlCommand _CMD = new SqlCommand("SELECT * FROM tb_Admin WHERE NomeAdmin=@Admin AND SenhaAdmin=@SenhaAdm", _connect);
            //_CMD.Parameters.Add("@Admin", SqlDbType.VarChar).Value = txtADMINname.Text;
            //_CMD.Parameters.Add("@SenhaAdm", SqlDbType.VarChar).Value = txtADMINpass.Text;

            //try
            //{
            //    _connect.Open();
            //    SqlDataReader data_read = _CMD.ExecuteReader();

            //    if (data_read.HasRows == false)
            //    {
            //        WrongLogin();
            //    }
            //    data_read.Read();

            //    if (data_read.HasRows == true)
            //    {
            //        MessageBox.Show("Login efetuado com sucesso!", "Formmsture 101 - Login de Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Close();
            //        comando = new Thread(Admin);
            //        comando.SetApartmentState(ApartmentState.MTA);
            //        comando.Start();
            //    }
            //}

            //catch (Exception)
            //{
            //    WrongLogin();
            //}

            //finally
            //{
            //    _connect.Close();
            //}
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                            // SEM USO //
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void lblAjuda__Click(object sender, EventArgs e)
        {

        }

        private void picInterrogative_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
