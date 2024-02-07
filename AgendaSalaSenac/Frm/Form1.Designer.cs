namespace AgendaSalaSenac
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            label10 = new Label();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            cmbTurno = new ComboBox();
            btnCancelar = new Button();
            label12 = new Label();
            ckSab = new CheckBox();
            ckSex = new CheckBox();
            ckQui = new CheckBox();
            ckQua = new CheckBox();
            ckTer = new CheckBox();
            ckSeg = new CheckBox();
            label9 = new Label();
            btnEditar = new Button();
            btnNovo = new Button();
            btnSalvar = new Button();
            txtId = new TextBox();
            label8 = new Label();
            btnEncerrar = new Button();
            btnLocalizar = new Button();
            txtConteudo = new TextBox();
            label7 = new Label();
            txtFinalidade = new TextBox();
            label6 = new Label();
            label5 = new Label();
            dateTimePickerFim = new DateTimePicker();
            label4 = new Label();
            dateTimePickerInicio = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            tabAgendaAtiva = new TabControl();
            tabPage1 = new TabPage();
            dgvDados = new DataGridView();
            tabPage2 = new TabPage();
            dgvHistorico = new DataGridView();
            label11 = new Label();
            lblDados = new Label();
            cmbSala = new ComboBox();
            cmbResponsavel = new ComboBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            tabAgendaAtiva.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 125);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label10);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 771);
            panel2.Name = "panel2";
            panel2.Size = new Size(1284, 36);
            panel2.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(174, 5);
            label10.Name = "label10";
            label10.Size = new Size(977, 30);
            label10.TabIndex = 0;
            label10.Text = "                      Projeto Integrador, Desenvolvido pela Turma Info10, do  Senac Santa Cruz Do Sul RS";
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 646);
            panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbResponsavel);
            groupBox1.Controls.Add(cmbSala);
            groupBox1.Controls.Add(cmbTurno);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(ckSab);
            groupBox1.Controls.Add(ckSex);
            groupBox1.Controls.Add(ckQui);
            groupBox1.Controls.Add(ckQua);
            groupBox1.Controls.Add(ckTer);
            groupBox1.Controls.Add(ckSeg);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnNovo);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnEncerrar);
            groupBox1.Controls.Add(btnLocalizar);
            groupBox1.Controls.Add(txtConteudo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtFinalidade);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePickerFim);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePickerInicio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 585);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agendamento";
            // 
            // cmbTurno
            // 
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Items.AddRange(new object[] { "MANHÃ", "TARDE", "NOITE" });
            cmbTurno.Location = new Point(8, 189);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(325, 23);
            cmbTurno.TabIndex = 31;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(221, 94);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 23);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 324);
            label12.Name = "label12";
            label12.Size = new Size(182, 15);
            label12.TabIndex = 29;
            label12.Text = "SELECIONE OS DIAS DA SEMANA";
            // 
            // ckSab
            // 
            ckSab.AutoSize = true;
            ckSab.Enabled = false;
            ckSab.Location = new Point(275, 344);
            ckSab.Name = "ckSab";
            ckSab.Size = new Size(47, 19);
            ckSab.TabIndex = 28;
            ckSab.Text = "SAB";
            ckSab.UseVisualStyleBackColor = true;
            // 
            // ckSex
            // 
            ckSex.AutoSize = true;
            ckSex.Enabled = false;
            ckSex.Location = new Point(223, 344);
            ckSex.Name = "ckSex";
            ckSex.Size = new Size(45, 19);
            ckSex.TabIndex = 27;
            ckSex.Text = "SEX";
            ckSex.UseVisualStyleBackColor = true;
            // 
            // ckQui
            // 
            ckQui.AutoSize = true;
            ckQui.Enabled = false;
            ckQui.Location = new Point(169, 344);
            ckQui.Name = "ckQui";
            ckQui.Size = new Size(46, 19);
            ckQui.TabIndex = 26;
            ckQui.Text = "QUI";
            ckQui.UseVisualStyleBackColor = true;
            // 
            // ckQua
            // 
            ckQua.AutoSize = true;
            ckQua.Enabled = false;
            ckQua.Location = new Point(117, 344);
            ckQua.Name = "ckQua";
            ckQua.Size = new Size(51, 19);
            ckQua.TabIndex = 25;
            ckQua.Text = "QUA";
            ckQua.UseVisualStyleBackColor = true;
            // 
            // ckTer
            // 
            ckTer.AutoSize = true;
            ckTer.Enabled = false;
            ckTer.Location = new Point(65, 344);
            ckTer.Name = "ckTer";
            ckTer.Size = new Size(45, 19);
            ckTer.TabIndex = 24;
            ckTer.Text = "TER";
            ckTer.UseVisualStyleBackColor = true;
            // 
            // ckSeg
            // 
            ckSeg.AutoSize = true;
            ckSeg.Enabled = false;
            ckSeg.Location = new Point(13, 344);
            ckSeg.Name = "ckSeg";
            ckSeg.Size = new Size(46, 19);
            ckSeg.TabIndex = 23;
            ckSeg.Text = "SEG";
            ckSeg.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(8, 45);
            label9.Name = "label9";
            label9.Size = new Size(165, 21);
            label9.TabIndex = 16;
            label9.Text = "Olá, seja bem vindo!";
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(86, 547);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(72, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(97, 94);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(118, 23);
            btnNovo.TabIndex = 14;
            btnNovo.Text = "NOVO AGENDAMENTO";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Location = new Point(8, 547);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(72, 23);
            btnSalvar.TabIndex = 13;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtId
            // 
            txtId.CharacterCasing = CharacterCasing.Upper;
            txtId.Enabled = false;
            txtId.Location = new Point(8, 94);
            txtId.Name = "txtId";
            txtId.Size = new Size(70, 23);
            txtId.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 76);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 11;
            label8.Text = "ID";
            // 
            // btnEncerrar
            // 
            btnEncerrar.Enabled = false;
            btnEncerrar.Location = new Point(248, 547);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(75, 23);
            btnEncerrar.TabIndex = 12;
            btnEncerrar.Text = "ENCERRAR";
            btnEncerrar.UseVisualStyleBackColor = true;
            btnEncerrar.Click += btnEncerrar_Click;
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(164, 547);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(78, 23);
            btnLocalizar.TabIndex = 11;
            btnLocalizar.Text = "LOCALIZAR";
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click_1;
            // 
            // txtConteudo
            // 
            txtConteudo.CharacterCasing = CharacterCasing.Upper;
            txtConteudo.Enabled = false;
            txtConteudo.Location = new Point(8, 490);
            txtConteudo.Name = "txtConteudo";
            txtConteudo.Size = new Size(325, 23);
            txtConteudo.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 472);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 4;
            label7.Text = "CONTEUDO";
            // 
            // txtFinalidade
            // 
            txtFinalidade.CharacterCasing = CharacterCasing.Upper;
            txtFinalidade.Enabled = false;
            txtFinalidade.Location = new Point(8, 440);
            txtFinalidade.Name = "txtFinalidade";
            txtFinalidade.Size = new Size(325, 23);
            txtFinalidade.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 422);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 4;
            label6.Text = "FINALIDADE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 374);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 4;
            label5.Text = "RESPONSAVEL";
            // 
            // dateTimePickerFim
            // 
            dateTimePickerFim.Enabled = false;
            dateTimePickerFim.Location = new Point(8, 283);
            dateTimePickerFim.Name = "dateTimePickerFim";
            dateTimePickerFim.Size = new Size(325, 23);
            dateTimePickerFim.TabIndex = 5;
            dateTimePickerFim.ValueChanged += dateTimePickerFim_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 265);
            label4.Name = "label4";
            label4.Size = new Size(160, 15);
            label4.TabIndex = 6;
            label4.Text = "DATA FINAL AGENDAMENTO";
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Enabled = false;
            dateTimePickerInicio.Location = new Point(8, 234);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(325, 23);
            dateTimePickerInicio.TabIndex = 4;
            dateTimePickerInicio.ValueChanged += dateTimePickerInicio_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 216);
            label3.Name = "label3";
            label3.Size = new Size(163, 15);
            label3.TabIndex = 4;
            label3.Text = "DATA INICIO AGENDAMENTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 168);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "TURNO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 120);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "SALA";
            // 
            // panel4
            // 
            panel4.Controls.Add(tabAgendaAtiva);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(lblDados);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(395, 125);
            panel4.Name = "panel4";
            panel4.Size = new Size(889, 646);
            panel4.TabIndex = 3;
            // 
            // tabAgendaAtiva
            // 
            tabAgendaAtiva.Controls.Add(tabPage1);
            tabAgendaAtiva.Controls.Add(tabPage2);
            tabAgendaAtiva.Location = new Point(0, 6);
            tabAgendaAtiva.Name = "tabAgendaAtiva";
            tabAgendaAtiva.SelectedIndex = 0;
            tabAgendaAtiva.Size = new Size(858, 609);
            tabAgendaAtiva.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvDados);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(850, 581);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agenda";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Dock = DockStyle.Fill;
            dgvDados.Location = new Point(3, 3);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(844, 575);
            dgvDados.TabIndex = 13;
            dgvDados.CellClick += dgvDados_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvHistorico);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(850, 581);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Histórico";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvHistorico
            // 
            dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Dock = DockStyle.Fill;
            dgvHistorico.Location = new Point(3, 3);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.Size = new Size(844, 575);
            dgvHistorico.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 618);
            label11.Name = "label11";
            label11.Size = new Size(91, 15);
            label11.TabIndex = 14;
            label11.Text = "Local do Banco:";
            // 
            // lblDados
            // 
            lblDados.AutoSize = true;
            lblDados.Location = new Point(105, 618);
            lblDados.Name = "lblDados";
            lblDados.Size = new Size(92, 15);
            lblDados.TabIndex = 1;
            lblDados.Text = "Banco de Dados";
            // 
            // cmbSala
            // 
            cmbSala.FormattingEnabled = true;
            cmbSala.Items.AddRange(new object[] { "101\t", "102", "103" });
            cmbSala.Location = new Point(6, 143);
            cmbSala.Name = "cmbSala";
            cmbSala.Size = new Size(327, 23);
            cmbSala.TabIndex = 32;
            // 
            // cmbResponsavel
            // 
            cmbResponsavel.FormattingEnabled = true;
            cmbResponsavel.Items.AddRange(new object[] { "NAIRO", "RAFAEL", "CLAUDEMIR" });
            cmbResponsavel.Location = new Point(8, 396);
            cmbResponsavel.Name = "cmbResponsavel";
            cmbResponsavel.Size = new Size(327, 23);
            cmbResponsavel.TabIndex = 33;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 807);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Salas";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tabAgendaAtiva.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private GroupBox groupBox1;
        private TextBox txtId;
        private Label label8;
        private Button btnEncerrar;
        private Button btnLocalizar;
        private TextBox txtConteudo;
        private Label label7;
        private TextBox txtFinalidade;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePickerFim;
        private Label label4;
        private DateTimePicker dateTimePickerInicio;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvDados;
        private Label lblDados;
        private Label label10;
        private Label label11;
        private Button btnEditar;
        private Button btnNovo;
        private Button btnSalvar;
        private TabControl tabAgendaAtiva;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvHistorico;
        private Label label9;
        private CheckBox ckSeg;
        private Label label12;
        private CheckBox ckSab;
        private CheckBox ckSex;
        private CheckBox ckQui;
        private CheckBox ckQua;
        private CheckBox ckTer;
        private Button btnCancelar;
        private ComboBox cmbTurno;
        private ComboBox cmbResponsavel;
        private ComboBox cmbSala;
    }
}
