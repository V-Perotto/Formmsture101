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
    public partial class frm_FormularioProfessor : Form
    {
        int addnvl, addfase, point1, point2, point3, point4, nvl1, nvl2, nvl3, nvl4, fase1, fase2, fase3, fase4, LoadFase, LoadNvl;
        Thread comando;
        Bitmap btmp;
        TimeSpan tempo = new TimeSpan(0, 00, 00);
        const string ConnectionString = @"Data Source=(localdb)\mssqllocaldb\SQLEXPRESS;Initial Catalog=DB_Formmsture101;Integrated Security=True";
        //const string ConnectionString = @"Data Source=SNPRT02LABF07\SQLEXPRESS;Initial Catalog=DB_Formmsture101;Integrated Security=True";
        SqlConnection _connect = new SqlConnection(ConnectionString);

        private void WrongLoad()
        {
            const string message = "Não foi possível carregar a Fase e Nível";
            const string caption = "Erro";
            var result = MessageBox.Show(message, caption);

            if (result == DialogResult.OK)
            {
                txtLoadFase.Text = "0";
                txt_Texto.Refresh();
                pic_Image.Refresh();
                txtLoadNivel.Text = "0";
                txtNextFase1.Text = "0";
                txtNextFase2.Text = "0";
                txtNextFase3.Text = "0";
                txtNextFase4.Text = "0";
                txtNextNivel1.Text = "0";
                txtNextNivel2.Text = "0";
                txtNextNivel3.Text = "0";
                txtNextNivel4.Text = "0";
                txtPontuacao1.Text = "0";
                txtPontuacao2.Text = "0";
                txtPontuacao3.Text = "0";
                txtPontuacao4.Text = "0";
                txtAlternativa1.Refresh();
                txtAlternativa2.Refresh();
                txtAlternativa3.Refresh();
                txtAlternativa4.Refresh();
                txtPergunta.Refresh();
                lblTIMER.Text = "00:00";
            }
        }

        private void frm_FormADDTexto_Load(object sender, EventArgs e)
        {

        }

        public frm_FormularioProfessor()
        {
            InitializeComponent();
        }

        private void Back()
        {
            Application.Run(new frm_ADDFormulario());
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            comando = new Thread(Back);
            comando.SetApartmentState(ApartmentState.STA);
            comando.Start();
        }

        private void lblVoltar__Click(object sender, EventArgs e)
        {
            this.Close();
            comando = new Thread(Back);
            comando.SetApartmentState(ApartmentState.STA);
            comando.Start();
        }

        private void tab_Texto_Click(object sender, EventArgs e)
        {

        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_Image_Click(object sender, EventArgs e)
        {
            if (openFileDialogIMG.ShowDialog() == DialogResult.OK)
            {
                string arquivo_img = openFileDialogIMG.FileName;
                btmp = new Bitmap(arquivo_img);
                pic_Image.Image = btmp;
            }
        }

        private void picUP_Click(object sender, EventArgs e)
        {
            //var timespan = tempo;
            //lblTIMER.Text = $"{timespan.Minutes.ToString("01")}:{timespan.Seconds.ToString("00")}";
            if (lblTIMER.Text == "00:00")
            {
                lblTIMER.Text = "00:30";
            }
            else if (lblTIMER.Text == "00:30")
            {
                lblTIMER.Text = "01:00";
            }
            else if (lblTIMER.Text == "01:00")
            {
                lblTIMER.Text = "01:30";
            }
            else if (lblTIMER.Text == "01:30")
            {
                lblTIMER.Text = "02:00";
            }
            else if (lblTIMER.Text == "02:00")
            {
                lblTIMER.Text = "02:30";
            }
            else if (lblTIMER.Text == "02:30")
            {
                lblTIMER.Text = "03:00";
            }
            /*
                                                                                                                                                                           .-.
                                                                                                                                                                          (o.o)
                                                                                                                                                                           |=|
                                                                                                                                                                          __|__
                                                                                                                                                                        //.=|=.\\
                                                                                                                                                                       // .=|=. \\
                                                                                                                                                                       \\ .=|=. //
                                                                                                                                                                        \\(_=_)//
                                                                                                                                                                         (:| |:)
                                                                                                                                                                          || ||
                                                                                                                                                                          () ()
                                                                                                                                                                          || ||
                                                                                                                                                                          || ||
                                                                                                                                                                         ==' '==
              */
        }

        private void picDOWN_Click(object sender, EventArgs e)
        {
            //var timespan = tempo;
            //lblTIMER.Text = $"{timespan.Minutes.ToString("00")}:{timespan.Seconds.ToString("30")}";
            if (lblTIMER.Text == "03:00")
            {
                lblTIMER.Text = "02:30";
            }
            else if (lblTIMER.Text == "02:30")
            {
                lblTIMER.Text = "02:00";
            }
            else if (lblTIMER.Text == "02:00")
            {
                lblTIMER.Text = "01:30";
            }
            else if (lblTIMER.Text == "01:30")
            {
                lblTIMER.Text = "01:00";
            }
            else if (lblTIMER.Text == "01:00")
            {
                lblTIMER.Text = "00:30";
            }
            else if (lblTIMER.Text == "00:30")
            {
                lblTIMER.Text = "00:00";
            }
        }

        private void btnADD_Fase_Click(object sender, EventArgs e)
        {
            addfase = 1 + addfase;
            txtFASE.Text = Convert.ToString(1);
            txtFASE.Text = Convert.ToString(addfase);
        }

        private void btnDelete_Fase_Click(object sender, EventArgs e)
        {
            addfase = addfase - 1;
            txtFASE.Text = Convert.ToString(addfase);
        }

        private void btnADD_Nivel_Click(object sender, EventArgs e)
        {
            addnvl = 1 + addnvl;
            txtNIVEL.Text = Convert.ToString(1);
            txtNIVEL.Text = Convert.ToString(addnvl);
        }

        private void btnDelete_Nivel_Click(object sender, EventArgs e)
        {
            addnvl = addnvl - 1;
            txtNIVEL.Text = Convert.ToString(addnvl);
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnLoadFaseNvl_Click(object sender, EventArgs e)
        {
            //SqlCommand _CMDP = new SqlCommand("SELECT autor.autor_nome, frase.frase_frases FROM autor INNER JOIN frase ON autor.autor_id = frase.autor_id WHERE autor.autor_nome = ", _connect);
            //_CMDP.Parameters.Add("@ID_Fase", SqlDbType.VarChar).Value = txtLoadFase.Text;
            //_CMDP.Parameters.Add("@ID_Nivel", SqlDbType.VarChar).Value = txtLoadNivel.Text;
            //_CMDP.Parameters.Add("@Texto", SqlDbType.VarChar).Value = txt_Texto.Text;
            //_CMDP.Parameters.Add("@Pergunta", SqlDbType.VarChar).Value = txtPergunta.Text;
            //_CMDP.Parameters.Add("@Alternativa1", SqlDbType.VarChar).Value = txtAlternativa1.Text;
            //_CMDP.Parameters.Add("@Alternativa2", SqlDbType.VarChar).Value = txtAlternativa2.Text;
            //_CMDP.Parameters.Add("@Alternativa3", SqlDbType.VarChar).Value = txtAlternativa3.Text;
            //_CMDP.Parameters.Add("@Alternativa4", SqlDbType.VarChar).Value = txtAlternativa4.Text;
            //_CMDP.Parameters.Add("@NextFase1", SqlDbType.VarChar).Value = txtNextFase1.Text;
            //_CMDP.Parameters.Add("@NextFase2", SqlDbType.VarChar).Value = txtNextFase2.Text;
            //_CMDP.Parameters.Add("@NextFase3", SqlDbType.VarChar).Value = txtNextFase3.Text;
            //_CMDP.Parameters.Add("@NextFase4", SqlDbType.VarChar).Value = txtNextFase4.Text;
            //_CMDP.Parameters.Add("@NextNivel1", SqlDbType.VarChar).Value = txtNextNivel1.Text;
            //_CMDP.Parameters.Add("@NextNivel2", SqlDbType.VarChar).Value = txtNextNivel2.Text;
            //_CMDP.Parameters.Add("@NextNivel3", SqlDbType.VarChar).Value = txtNextNivel3.Text;
            //_CMDP.Parameters.Add("@NextNivel4", SqlDbType.VarChar).Value = txtNextNivel4.Text;
            //_CMDP.Parameters.Add("@AlternativaPontuacao1", SqlDbType.VarChar).Value = txtPontuacao1.Text;
            //_CMDP.Parameters.Add("@AlternativaPontuacao2", SqlDbType.VarChar).Value = txtPontuacao2.Text;
            //_CMDP.Parameters.Add("@AlternativaPontuacao3", SqlDbType.VarChar).Value = txtPontuacao3.Text;
            //_CMDP.Parameters.Add("@AlternativaPontuacao4", SqlDbType.VarChar).Value = txtPontuacao4.Text;
            //_CMDP.Parameters.Add("@Tempo", SqlDbType.VarChar).Value = lblTIMER.Text;

            //try
            //{
            //    _connect.Open();
            //    SqlDataReader data_readp = _CMDP.ExecuteReader();

            //    if (data_readp.HasRows == false)
            //    {
            //        WrongLoad();
            //    }
            //    data_readp.Read();

            //    //if (data_readp.HasRows == true)
            //    //{
            //    //    MessageBox.Show("Login efetuado com sucesso!", "Formmsture 101 - Professor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //}
            //}

            //catch (Exception)
            //{
            //    WrongLoad();
            //}

            //finally
            //{
            //    _connect.Close();
            //}
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void picLowPontuacao1_Click(object sender, EventArgs e)
        {
            point1 = point1 - 1;
            txtPontuacao1.Text = Convert.ToString(point1);
        }

        private void picLowPontuacao2_Click(object sender, EventArgs e)
        {
            point2 = point2 - 1;
            txtPontuacao2.Text = Convert.ToString(point2);
        }

        private void picLowPontuacao3_Click(object sender, EventArgs e)
        {
            point3 = point3 - 1;
            txtPontuacao3.Text = Convert.ToString(point3);
        }

        private void picLowPontuacao4_Click(object sender, EventArgs e)
        {
            point4 = point4 - 1;
            txtPontuacao4.Text = Convert.ToString(point4);
        }

        private void picLowNivel1_Click(object sender, EventArgs e)
        {
            nvl1 = nvl1 - 1;
            txtNextNivel1.Text = Convert.ToString(nvl1);
        }

        private void picLowNivel2_Click(object sender, EventArgs e)
        {
            nvl2 = nvl2 - 1;
            txtNextNivel2.Text = Convert.ToString(nvl2);
        }

        private void picLowNivel3_Click(object sender, EventArgs e)
        {
            nvl3 = nvl3 - 1;
            txtNextNivel3.Text = Convert.ToString(nvl3);
        }

        private void picLowNivel4_Click(object sender, EventArgs e)
        {
            nvl4 = nvl4 - 1;
            txtNextNivel4.Text = Convert.ToString(nvl4);
        }

        private void picUpFase_Click(object sender, EventArgs e)
        {
            LoadFase = 1 + LoadFase;
            txtLoadFase.Text = Convert.ToString(1);
            txtLoadFase.Text = Convert.ToString(LoadFase);
        }

        private void picLowFase1_Click(object sender, EventArgs e)
        {
            fase1 = fase1 - 1;
            
            txtNextFase1.Text = Convert.ToString(fase1);
        }

        private void picLowFase2_Click(object sender, EventArgs e)
        {
            fase2 = fase2 - 1;
            txtNextFase2.Text = Convert.ToString(fase2);
        }

        private void picLowFase3_Click(object sender, EventArgs e)
        {
            fase3 = fase3 - 1;
            txtNextFase3.Text = Convert.ToString(fase3);
        }

        private void picLowFase4_Click(object sender, EventArgs e)
        {
            fase4 = fase4 - 1;
            txtNextFase4.Text = Convert.ToString(fase4);
        }

        private void tab_Alternativa_Click(object sender, EventArgs e)
        {

        }

        private void picLowFase_Click(object sender, EventArgs e)
        {
            LoadFase = LoadFase - 1;
            txtLoadFase.Text = Convert.ToString(LoadFase);
        }

        private void picUpNivel_Click(object sender, EventArgs e)
        {
            LoadNvl = 1 + LoadNvl;
            txtLoadNivel.Text = Convert.ToString(1);
            txtLoadNivel.Text = Convert.ToString(LoadNvl);
        }

        private void picLowNivel_Click(object sender, EventArgs e)
        {
            LoadNvl = LoadNvl - 1;
            txtLoadNivel.Text = Convert.ToString(LoadNvl);
        }

        private void picPontos1_Click(object sender, EventArgs e)
        {
            point1 = 1 + point1;
            txtPontuacao1.Text = Convert.ToString(1);
            txtPontuacao1.Text = Convert.ToString(point1);
        }

        private void picPontos2_Click(object sender, EventArgs e)
        {
            point2 = 1 + point2;
            txtPontuacao2.Text = Convert.ToString(1);
            txtPontuacao2.Text = Convert.ToString(point2);
        }

        private void picPontos3_Click(object sender, EventArgs e)
        {
            point3 = 1 + point3;
            txtPontuacao3.Text = Convert.ToString(1);
            txtPontuacao3.Text = Convert.ToString(point3);
        }

        private void picPontos4_Click(object sender, EventArgs e)
        {
            point4 = 1 + point4;
            txtPontuacao4.Text = Convert.ToString(1);
            txtPontuacao4.Text = Convert.ToString(point4);
        }

        private void picUpNivel1_Click(object sender, EventArgs e)
        {
            nvl1 = 1 + nvl1;
            txtNextNivel1.Text = Convert.ToString(1);
            txtNextNivel1.Text = Convert.ToString(nvl1);
        }

        private void picUpNivel2_Click(object sender, EventArgs e)
        {
            nvl2 = 1 + nvl2;
            txtNextNivel2.Text = Convert.ToString(1);
            txtNextNivel2.Text = Convert.ToString(nvl2);
        }

        private void picUpNivel3_Click(object sender, EventArgs e)
        {
            nvl3 = 1 + nvl3;
            txtNextNivel3.Text = Convert.ToString(1);
            txtNextNivel3.Text = Convert.ToString(nvl3);
        }

        private void picUpNivel4_Click(object sender, EventArgs e)
        {
            nvl4 = 1 + nvl4;
            txtNextNivel4.Text = Convert.ToString(1);
            txtNextNivel4.Text = Convert.ToString(nvl4);
        }

        private void picUpFase1_Click(object sender, EventArgs e)
        {
            fase1 = 1 + fase1;
            txtNextFase1.Text = Convert.ToString(1);
            txtNextFase1.Text = Convert.ToString(fase1);
        }

        private void picUpFase2_Click(object sender, EventArgs e)
        {
            fase2 = 1 + fase2;
            txtNextFase2.Text = Convert.ToString(1);
            txtNextFase2.Text = Convert.ToString(fase2);
        }

        private void picUpFase3_Click(object sender, EventArgs e)
        {
            fase3 = 1 + fase3;
            txtNextFase3.Text = Convert.ToString(1);
            txtNextFase3.Text = Convert.ToString(fase3);
        }

        private void picUpFase4_Click(object sender, EventArgs e)
        {
            fase4 = 1 + fase4;
            txtNextFase4.Text = Convert.ToString(1);
            txtNextFase4.Text = Convert.ToString(fase4);
        }
    }
}
