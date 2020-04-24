using Formmsture101.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formmsture101
{
    public partial class frm_CadastroProfessor : Form
    {
        //Thread comando;
        //Bitmap btmp;
        const string ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DB_Formmsture101;Integrated Security=True";
        //const string ConnectionString = @"Data Source=SNPRT02LABF07\SQLEXPRESS;Initial Catalog=DB_Formmsture101;Integrated Security=True";
        SqlConnection _connect = new SqlConnection(ConnectionString);

        private void Voltar()
        {
            Application.Run(new frm_TelaInicio());
        }

        private void Cadastrado()
        {
            Application.Run(new frm_TelaProfessor());
        }

        private void picLogoff_Click(object sender, EventArgs e)
        {
            //this.Close();
            //comando = new Thread(Voltar);
            //comando.SetApartmentState(ApartmentState.STA);
            //comando.Start();
        }

        private void lblLogoff__Click(object sender, EventArgs e)
        {
            //this.Close();
            //comando = new Thread(Voltar);
            //comando.SetApartmentState(ApartmentState.STA);
            //comando.Start();
        }

        public frm_CadastroProfessor()
        {
            InitializeComponent();
        }

        private void frm_CadastroProfessor_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //SqlCommand _CMD = new SqlCommand("INSERT INTO tb_Professor (NomeProf, SenhaProf, MateriaProf, ProfImagem) VALUES (@NomeProf, @SenhaProf, @MateriaProf, @ImgProf)", _connect); // ProfImagem , @ImgProf

            //_CMD.Parameters.Add("@NomeProf", SqlDbType.VarChar).Value = txtProfessor.Text;
            //_CMD.Parameters.Add("@SenhaProf", SqlDbType.VarChar).Value = txtSenha.Text = txtSenhaRepeat.Text;
            //_CMD.Parameters.Add("@MateriaProf", SqlDbType.VarChar).Value = txtMateria.Text;
            //_CMD.Parameters.Add("@ProfImagem", SqlDbType.Binary).Value = picProfessor;

            //MemoryStream memory_px = new MemoryStream();
            //btmp.Save(memory_px, ImageFormat.Bmp);
            //byte[] img = memory_px.ToArray();

            //try
            //{
            //    _connect.Open();
            //    _CMD.ExecuteNonQuery();
            //    SqlDataReader data_readp = _CMD.ExecuteReader();
            //    data_readp.Read();

            //    if (data_readp.HasRows == true)
            //    {
            //        MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Close();
            //        comando = new Thread(Cadastrado);
            //        comando.SetApartmentState(ApartmentState.STA);
            //        comando.Start();
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Insira as informações corretamente!", "Cadastro Não Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //finally
            //{
            //    _connect.Close();
            //}
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picEditPerson_Click(object sender, EventArgs e)
        {
            //if (openFileDialogIMG.ShowDialog() == DialogResult.OK)
            //{
            //    string arquivo_img = openFileDialogIMG.FileName;
            //    btmp = new Bitmap(arquivo_img);
            //    picProfessor.Image = btmp;
            //}
        }

        private void lblInserirImagem__Click(object sender, EventArgs e)
        {
            //if (openFileDialogIMG.ShowDialog() == DialogResult.OK)
            //{
            //    string arquivo_img = openFileDialogIMG.FileName;
            //    btmp = new Bitmap(arquivo_img);
            //    picProfessor.Image = btmp;
            //}
        }

        private void picProfessor_Click(object sender, EventArgs e)
        {

        }
    }
}
