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
    public partial class frm_EditInfoLogADM : Form
    {
        Thread comando;
        const string ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DB_Formmsture101;Integrated Security=True";
        //const string ConnectionString = @"Data Source=SNPRT02LABF07\SQLEXPRESS;Initial Catalog=DB_Formmsture101;Integrated Security=True";
        SqlConnection _connect = new SqlConnection(ConnectionString);

        public frm_EditInfoLogADM()
        {
            InitializeComponent();
        }

        private void Voltar()
        {
            Application.Run(new frm_TelaProfessor());
        }

        private void WrongLogin()
        {
            const string message = "Usuário ou Senha incorretos!";
            const string caption = "Digite novamente";
            var result = MessageBox.Show(message, caption);

            if (result == DialogResult.OK)
            {
                picAdmin.Refresh();
                txtAdmin.Clear();
                txtSenha.Clear();
            }
        }

        private void Admin()
        {
            Application.Run(new frm_AreaAdmin());
        }

        private void frm_EditInfoLogADM_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            SqlCommand _CMD = new SqlCommand("SELECT * FROM tb_Admin WHERE NomeAdmin=@Admin AND SenhaAdmin=@SenhaAdm", _connect);
            _CMD.Parameters.Add("@Admin", SqlDbType.VarChar).Value = txtAdmin.Text;
            _CMD.Parameters.Add("@SenhaAdm", SqlDbType.VarChar).Value = txtSenha.Text;

            try
            {
                _connect.Open();
                SqlDataReader data_read = _CMD.ExecuteReader();

                if (data_read.HasRows == false)
                {
                    WrongLogin();
                }
                data_read.Read();

                if (data_read.HasRows == true)
                {
                    this.Close();
                    comando = new Thread(Admin);
                    comando.SetApartmentState(ApartmentState.MTA);
                    comando.Start();
                }
            }

            catch (Exception)
            {
                WrongLogin();
            }

            finally
            {
                _connect.Close();
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
            comando = new Thread(Voltar);
            comando.SetApartmentState(ApartmentState.STA);
            comando.Start();
        }

        private void lblLogoff__Click(object sender, EventArgs e)
        {
            this.Close();
            comando = new Thread(Voltar);
            comando.SetApartmentState(ApartmentState.STA);
            comando.Start();
        }

        private void txtAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
