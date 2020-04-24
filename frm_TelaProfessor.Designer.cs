namespace Formmsture101
{
    partial class frm_TelaProfessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TelaProfessor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNomePrograma_ = new System.Windows.Forms.Label();
            this.picPrograma = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picGray = new System.Windows.Forms.PictureBox();
            this.lblSair = new System.Windows.Forms.Label();
            this.dgvAlunosFormCad = new System.Windows.Forms.DataGridView();
            this.lblAreaProf_ = new System.Windows.Forms.Label();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.picPerson = new System.Windows.Forms.PictureBox();
            this.picProfessor = new System.Windows.Forms.PictureBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnEditForms = new System.Windows.Forms.Button();
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.lblAlunosCad_ = new System.Windows.Forms.Label();
            this.lblListaAlunos = new System.Windows.Forms.Label();
            this.lblLogoff_ = new System.Windows.Forms.Label();
            this.picLogoff = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPrograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosFormCad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomePrograma_
            // 
            this.lblNomePrograma_.AutoSize = true;
            this.lblNomePrograma_.BackColor = System.Drawing.Color.Gray;
            this.lblNomePrograma_.Font = new System.Drawing.Font("Rockwell", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePrograma_.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNomePrograma_.Location = new System.Drawing.Point(89, 21);
            this.lblNomePrograma_.Name = "lblNomePrograma_";
            this.lblNomePrograma_.Size = new System.Drawing.Size(345, 50);
            this.lblNomePrograma_.TabIndex = 76;
            this.lblNomePrograma_.Text = "Formmsture 101";
            // 
            // picPrograma
            // 
            this.picPrograma.BackColor = System.Drawing.Color.Gray;
            this.picPrograma.Image = ((System.Drawing.Image)(resources.GetObject("picPrograma.Image")));
            this.picPrograma.Location = new System.Drawing.Point(13, 12);
            this.picPrograma.Name = "picPrograma";
            this.picPrograma.Size = new System.Drawing.Size(70, 66);
            this.picPrograma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPrograma.TabIndex = 75;
            this.picPrograma.TabStop = false;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Gray;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(1839, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(70, 66);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 74;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // picGray
            // 
            this.picGray.BackColor = System.Drawing.Color.Gray;
            this.picGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGray.Location = new System.Drawing.Point(0, 0);
            this.picGray.Name = "picGray";
            this.picGray.Size = new System.Drawing.Size(1921, 93);
            this.picGray.TabIndex = 73;
            this.picGray.TabStop = false;
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.BackColor = System.Drawing.Color.Gray;
            this.lblSair.Font = new System.Drawing.Font("Rockwell", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.Location = new System.Drawing.Point(1742, 23);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(91, 46);
            this.lblSair.TabIndex = 77;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // dgvAlunosFormCad
            // 
            this.dgvAlunosFormCad.AllowUserToAddRows = false;
            this.dgvAlunosFormCad.AllowUserToDeleteRows = false;
            this.dgvAlunosFormCad.AllowUserToResizeColumns = false;
            this.dgvAlunosFormCad.AllowUserToResizeRows = false;
            this.dgvAlunosFormCad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlunosFormCad.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlunosFormCad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlunosFormCad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunosFormCad.Location = new System.Drawing.Point(599, 250);
            this.dgvAlunosFormCad.Name = "dgvAlunosFormCad";
            this.dgvAlunosFormCad.ReadOnly = true;
            this.dgvAlunosFormCad.Size = new System.Drawing.Size(1192, 723);
            this.dgvAlunosFormCad.TabIndex = 83;
            // 
            // lblAreaProf_
            // 
            this.lblAreaProf_.AutoSize = true;
            this.lblAreaProf_.BackColor = System.Drawing.Color.White;
            this.lblAreaProf_.Font = new System.Drawing.Font("Rockwell", 22.25F);
            this.lblAreaProf_.Location = new System.Drawing.Point(148, 212);
            this.lblAreaProf_.Name = "lblAreaProf_";
            this.lblAreaProf_.Size = new System.Drawing.Size(265, 70);
            this.lblAreaProf_.TabIndex = 82;
            this.lblAreaProf_.Text = "Você está na \r\nÁrea do Professor";
            this.lblAreaProf_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox1
            // 
            this.picBox1.BackColor = System.Drawing.Color.White;
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox1.Location = new System.Drawing.Point(98, 190);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(366, 783);
            this.picBox1.TabIndex = 81;
            this.picBox1.TabStop = false;
            // 
            // txtProfessor
            // 
            this.txtProfessor.AcceptsTab = true;
            this.txtProfessor.BackColor = System.Drawing.Color.White;
            this.txtProfessor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfessor.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfessor.Location = new System.Drawing.Point(196, 541);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.ReadOnly = true;
            this.txtProfessor.Size = new System.Drawing.Size(219, 32);
            this.txtProfessor.TabIndex = 78;
            this.txtProfessor.Tag = "";
            // 
            // picPerson
            // 
            this.picPerson.BackColor = System.Drawing.Color.White;
            this.picPerson.Image = ((System.Drawing.Image)(resources.GetObject("picPerson.Image")));
            this.picPerson.Location = new System.Drawing.Point(149, 537);
            this.picPerson.Name = "picPerson";
            this.picPerson.Size = new System.Drawing.Size(40, 39);
            this.picPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerson.TabIndex = 80;
            this.picPerson.TabStop = false;
            // 
            // picProfessor
            // 
            this.picProfessor.BackColor = System.Drawing.Color.Gainsboro;
            this.picProfessor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfessor.Image = ((System.Drawing.Image)(resources.GetObject("picProfessor.Image")));
            this.picProfessor.Location = new System.Drawing.Point(149, 314);
            this.picProfessor.Name = "picProfessor";
            this.picProfessor.Size = new System.Drawing.Size(266, 200);
            this.picProfessor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picProfessor.TabIndex = 79;
            this.picProfessor.TabStop = false;
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriar.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.Color.White;
            this.btnCriar.Location = new System.Drawing.Point(119, 612);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(324, 45);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "Criar ou Editar Formulários";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManual.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.ForeColor = System.Drawing.Color.White;
            this.btnManual.Location = new System.Drawing.Point(118, 691);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(324, 45);
            this.btnManual.TabIndex = 1;
            this.btnManual.Text = "Manual de Instruções de Uso";
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnEditForms
            // 
            this.btnEditForms.BackColor = System.Drawing.Color.Gold;
            this.btnEditForms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditForms.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditForms.ForeColor = System.Drawing.Color.White;
            this.btnEditForms.Location = new System.Drawing.Point(119, 769);
            this.btnEditForms.Name = "btnEditForms";
            this.btnEditForms.Size = new System.Drawing.Size(324, 45);
            this.btnEditForms.TabIndex = 2;
            this.btnEditForms.UseVisualStyleBackColor = false;
            this.btnEditForms.Click += new System.EventHandler(this.btnEditForms_Click);
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.BackColor = System.Drawing.Color.Teal;
            this.btnEditInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditInfo.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInfo.ForeColor = System.Drawing.Color.White;
            this.btnEditInfo.Location = new System.Drawing.Point(119, 845);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(324, 45);
            this.btnEditInfo.TabIndex = 3;
            this.btnEditInfo.Text = "Editar Informações";
            this.btnEditInfo.UseVisualStyleBackColor = false;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInfo.Location = new System.Drawing.Point(132, 926);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(298, 34);
            this.lblInfo.TabIndex = 88;
            this.lblInfo.Text = "Para editar suas informações será necessário \r\nlogar como Administrador.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox2
            // 
            this.picBox2.BackColor = System.Drawing.Color.White;
            this.picBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox2.Location = new System.Drawing.Point(534, 163);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(1324, 867);
            this.picBox2.TabIndex = 89;
            this.picBox2.TabStop = false;
            // 
            // lblAlunosCad_
            // 
            this.lblAlunosCad_.AutoSize = true;
            this.lblAlunosCad_.BackColor = System.Drawing.Color.White;
            this.lblAlunosCad_.Font = new System.Drawing.Font("Rockwell", 22.25F);
            this.lblAlunosCad_.Location = new System.Drawing.Point(930, 190);
            this.lblAlunosCad_.Name = "lblAlunosCad_";
            this.lblAlunosCad_.Size = new System.Drawing.Size(524, 35);
            this.lblAlunosCad_.TabIndex = 90;
            this.lblAlunosCad_.Text = "Turmas que realizaram as atividades";
            this.lblAlunosCad_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListaAlunos
            // 
            this.lblListaAlunos.AutoSize = true;
            this.lblListaAlunos.BackColor = System.Drawing.Color.White;
            this.lblListaAlunos.Font = new System.Drawing.Font("Rockwell", 10.25F);
            this.lblListaAlunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListaAlunos.Location = new System.Drawing.Point(968, 992);
            this.lblListaAlunos.Name = "lblListaAlunos";
            this.lblListaAlunos.Size = new System.Drawing.Size(430, 17);
            this.lblListaAlunos.TabIndex = 91;
            this.lblListaAlunos.Text = "Aqui se encontra a lista de equipes que já realizaram suas tarefas.";
            this.lblListaAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogoff_
            // 
            this.lblLogoff_.AutoSize = true;
            this.lblLogoff_.BackColor = System.Drawing.SystemColors.Control;
            this.lblLogoff_.Font = new System.Drawing.Font("Rockwell", 20.25F);
            this.lblLogoff_.Location = new System.Drawing.Point(73, 1030);
            this.lblLogoff_.Name = "lblLogoff_";
            this.lblLogoff_.Size = new System.Drawing.Size(172, 31);
            this.lblLogoff_.TabIndex = 92;
            this.lblLogoff_.Text = "Sair da conta";
            this.lblLogoff_.Click += new System.EventHandler(this.lblLogoff__Click);
            // 
            // picLogoff
            // 
            this.picLogoff.BackColor = System.Drawing.SystemColors.Control;
            this.picLogoff.Image = ((System.Drawing.Image)(resources.GetObject("picLogoff.Image")));
            this.picLogoff.Location = new System.Drawing.Point(12, 1019);
            this.picLogoff.Name = "picLogoff";
            this.picLogoff.Size = new System.Drawing.Size(55, 49);
            this.picLogoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoff.TabIndex = 93;
            this.picLogoff.TabStop = false;
            this.picLogoff.Click += new System.EventHandler(this.picLogoff_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1794, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // frm_TelaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLogoff_);
            this.Controls.Add(this.picLogoff);
            this.Controls.Add(this.lblListaAlunos);
            this.Controls.Add(this.lblAlunosCad_);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnEditInfo);
            this.Controls.Add(this.btnEditForms);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.dgvAlunosFormCad);
            this.Controls.Add(this.lblAreaProf_);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.picPerson);
            this.Controls.Add(this.picProfessor);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lblNomePrograma_);
            this.Controls.Add(this.picPrograma);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picGray);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.picBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_TelaProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TelaProfessor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_TelaProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPrograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosFormCad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomePrograma_;
        private System.Windows.Forms.PictureBox picPrograma;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox picGray;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.DataGridView dgvAlunosFormCad;
        private System.Windows.Forms.Label lblAreaProf_;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.PictureBox picPerson;
        private System.Windows.Forms.PictureBox picProfessor;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnEditForms;
        private System.Windows.Forms.Button btnEditInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Label lblAlunosCad_;
        private System.Windows.Forms.Label lblListaAlunos;
        private System.Windows.Forms.Label lblLogoff_;
        private System.Windows.Forms.PictureBox picLogoff;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}