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
    public partial class frm_Formularios : Form
    {
        Thread comando;
        const string ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DB_Formmsture101;Integrated Security=True";
        //const string ConnectionString = @"Data Source=SNPRT02LABF07\SQLEXPRESS;Initial Catalog=DB_Formmsture101;Integrated Security=True";
        SqlConnection _connect = new SqlConnection(ConnectionString);

        private void Voltar()
        {
            Application.Run(new frm_TelaInicio());
        }

        //private void S1()
        //{
        //    Application.Run(new frm_S1());
        //}

        //private void S2()
        //{
        //    Application.Run(new frm_S1());
        //}

        //private void S3()
        //{
        //    Application.Run(new frm_S1());
        //}

        //private void S4()
        //{
        //    Application.Run(new frm_S1());
        //}

        //private void S5()
        //{
        //    Application.Run(new frm_S1());
        //}

        //private void S6()
        //{
        //    Application.Run(new frm_S1());
        //}

        //private void S7()
        //{
        //    Application.Run(new frm_S1());
        //}

        //private void S8()
        //{
        //    Application.Run(new frm_S1());
        //}

        //private void S9()
        //{
        //    Application.Run(new frm_S1());
        //}

        public frm_Formularios()
        {
            InitializeComponent();
        }

        private void frm_Formularios_Load(object sender, EventArgs e)
        {
            Refresh();
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

        private void picSegmento1_Click(object sender, EventArgs e)
        {
            //this.Close();
            //comando = new Thread(Voltar);
            //comando.SetApartmentState(ApartmentState.STA);
            //comando.Start();
        }

        private void picSegmento2_Click(object sender, EventArgs e)
        {
            //this.Close();
            //comando = new Thread(Voltar);
            //comando.SetApartmentState(ApartmentState.STA);
            //comando.Start();
        }

        private void picSegmento3_Click(object sender, EventArgs e)
        {
            //this.Close();
            //comando = new Thread(Voltar);
            //comando.SetApartmentState(ApartmentState.STA);
            //comando.Start();
        }

        private void picSegmento4_Click(object sender, EventArgs e)
        {
            //this.Close();
            //comando = new Thread(Voltar);
            //comando.SetApartmentState(ApartmentState.STA);
            //comando.Start();
        }

        private void picSegmento5_Click(object sender, EventArgs e)
        {
            //this.Close();
            //comando = new Thread(Voltar);
            //comando.SetApartmentState(ApartmentState.STA);
            //comando.Start();
        }

        private void picSegmento6_Click(object sender, EventArgs e)
        {
            //this.Close();
            //comando = new Thread(Voltar);
            //comando.SetApartmentState(ApartmentState.STA);
            //comando.Start();
        }

        private void picSegmento7_Click(object sender, EventArgs e)
        {
            //this.Close();
            //comando = new Thread(Voltar);
            //comando.SetApartmentState(ApartmentState.STA);
            //comando.Start();
        }

        private void picSegmento8_Click(object sender, EventArgs e)
        {
            //this.Close();
            //comando = new Thread(Voltar);
            //comando.SetApartmentState(ApartmentState.STA);
            //comando.Start();
        }

        private void picSegmento9_Click(object sender, EventArgs e)
        {
            //this.Close();
            //comando = new Thread(Voltar);
            //comando.SetApartmentState(ApartmentState.STA);
            //comando.Start();
        }
    }
}
