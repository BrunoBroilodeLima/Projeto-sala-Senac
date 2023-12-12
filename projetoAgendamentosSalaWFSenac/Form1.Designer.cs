namespace projetoAgendamentosSalaWFSenac
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
            gbxAgendamento = new GroupBox();
            btnIncluirNaAgenda = new Button();
            cmbConteudo = new ComboBox();
            label6 = new Label();
            dateTimeFinal = new DateTimePicker();
            dateTimeInicio = new DateTimePicker();
            btnLimparDados = new Button();
            lblStatus = new Label();
            cmbFinalidade = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmbResponsavel = new ComboBox();
            label2 = new Label();
            cmbTurno = new ComboBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnMesAnterior = new Button();
            btnMesAtual = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            cmbSelecaoSala = new ComboBox();
            label7 = new Label();
            gbxAgendamento.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // gbxAgendamento
            // 
            gbxAgendamento.BackColor = Color.White;
            gbxAgendamento.Controls.Add(btnIncluirNaAgenda);
            gbxAgendamento.Controls.Add(cmbConteudo);
            gbxAgendamento.Controls.Add(label6);
            gbxAgendamento.Controls.Add(dateTimeFinal);
            gbxAgendamento.Controls.Add(dateTimeInicio);
            gbxAgendamento.Controls.Add(btnLimparDados);
            gbxAgendamento.Controls.Add(lblStatus);
            gbxAgendamento.Controls.Add(cmbFinalidade);
            gbxAgendamento.Controls.Add(label5);
            gbxAgendamento.Controls.Add(label4);
            gbxAgendamento.Controls.Add(label3);
            gbxAgendamento.Controls.Add(cmbResponsavel);
            gbxAgendamento.Controls.Add(label2);
            gbxAgendamento.Controls.Add(cmbTurno);
            gbxAgendamento.Controls.Add(label1);
            gbxAgendamento.Location = new Point(21, 189);
            gbxAgendamento.Name = "gbxAgendamento";
            gbxAgendamento.Size = new Size(267, 599);
            gbxAgendamento.TabIndex = 0;
            gbxAgendamento.TabStop = false;
            gbxAgendamento.Text = "AGENDAMENTO";
            // 
            // btnIncluirNaAgenda
            // 
            btnIncluirNaAgenda.Location = new Point(120, 533);
            btnIncluirNaAgenda.Name = "btnIncluirNaAgenda";
            btnIncluirNaAgenda.Size = new Size(141, 26);
            btnIncluirNaAgenda.TabIndex = 16;
            btnIncluirNaAgenda.Text = "INCLUIR NA AGENDA";
            btnIncluirNaAgenda.UseVisualStyleBackColor = true;
            // 
            // cmbConteudo
            // 
            cmbConteudo.FormattingEnabled = true;
            cmbConteudo.Items.AddRange(new object[] { "AULA" });
            cmbConteudo.Location = new Point(19, 424);
            cmbConteudo.Name = "cmbConteudo";
            cmbConteudo.Size = new Size(200, 23);
            cmbConteudo.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 397);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 14;
            label6.Text = "CONTEUDO";
            // 
            // dateTimeFinal
            // 
            dateTimeFinal.Location = new Point(19, 296);
            dateTimeFinal.Name = "dateTimeFinal";
            dateTimeFinal.Size = new Size(200, 23);
            dateTimeFinal.TabIndex = 13;
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.Location = new Point(19, 220);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(200, 23);
            dateTimeInicio.TabIndex = 12;
            // 
            // btnLimparDados
            // 
            btnLimparDados.Location = new Point(6, 533);
            btnLimparDados.Name = "btnLimparDados";
            btnLimparDados.Size = new Size(108, 26);
            btnLimparDados.TabIndex = 11;
            btnLimparDados.Text = "LIMPAR DADOS";
            btnLimparDados.UseVisualStyleBackColor = true;
            btnLimparDados.Click += btnLimparDados_Click;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.BorderStyle = BorderStyle.Fixed3D;
            lblStatus.ForeColor = Color.Gray;
            lblStatus.Location = new Point(19, 466);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(200, 23);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbFinalidade
            // 
            cmbFinalidade.FormattingEnabled = true;
            cmbFinalidade.Items.AddRange(new object[] { "ENSINO MÉDIO", "TECNOLOGO", "PALESTRA" });
            cmbFinalidade.Location = new Point(19, 360);
            cmbFinalidade.Name = "cmbFinalidade";
            cmbFinalidade.Size = new Size(200, 23);
            cmbFinalidade.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 333);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 8;
            label5.Text = "FINALIDADE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 262);
            label4.Name = "label4";
            label4.Size = new Size(148, 15);
            label4.TabIndex = 6;
            label4.Text = "DATA FIM AGENDAMENTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 186);
            label3.Name = "label3";
            label3.Size = new Size(163, 15);
            label3.TabIndex = 4;
            label3.Text = "DATA INICIO AGENDAMENTO";
            // 
            // cmbResponsavel
            // 
            cmbResponsavel.FormattingEnabled = true;
            cmbResponsavel.Items.AddRange(new object[] { "NAIRO", "RAFAEL" });
            cmbResponsavel.Location = new Point(19, 143);
            cmbResponsavel.Name = "cmbResponsavel";
            cmbResponsavel.Size = new Size(200, 23);
            cmbResponsavel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 110);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "RESPONSÁVEL";
            // 
            // cmbTurno
            // 
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Items.AddRange(new object[] { "MANHÃ", "TARDE", "NOITE" });
            cmbTurno.Location = new Point(19, 70);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(200, 23);
            cmbTurno.TabIndex = 1;
            cmbTurno.SelectedIndexChanged += cmbTurno_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "TURNO";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Location = new Point(300, 189);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(840, 63);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnMesAnterior);
            flowLayoutPanel1.Controls.Add(btnMesAtual);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(369, 57);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnMesAnterior
            // 
            btnMesAnterior.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMesAnterior.Location = new Point(3, 3);
            btnMesAnterior.Name = "btnMesAnterior";
            btnMesAnterior.Size = new Size(75, 53);
            btnMesAnterior.TabIndex = 0;
            btnMesAnterior.Text = "<";
            btnMesAnterior.UseVisualStyleBackColor = true;
            // 
            // btnMesAtual
            // 
            btnMesAtual.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMesAtual.Location = new Point(84, 3);
            btnMesAtual.Name = "btnMesAtual";
            btnMesAtual.Size = new Size(75, 53);
            btnMesAtual.TabIndex = 1;
            btnMesAtual.Text = ">";
            btnMesAtual.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(303, 274);
            panel1.Name = "panel1";
            panel1.Size = new Size(1275, 514);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.senac_santacruz;
            pictureBox2.Location = new Point(337, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(682, 171);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // cmbSelecaoSala
            // 
            cmbSelecaoSala.FormattingEnabled = true;
            cmbSelecaoSala.Items.AddRange(new object[] { "SALA 101", "SALA 102", "SALA 103", "SALA 201", "SALA 202", "SALA 203" });
            cmbSelecaoSala.Location = new Point(27, 104);
            cmbSelecaoSala.Name = "cmbSelecaoSala";
            cmbSelecaoSala.Size = new Size(121, 23);
            cmbSelecaoSala.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 69);
            label7.Name = "label7";
            label7.Size = new Size(108, 15);
            label7.TabIndex = 5;
            label7.Text = "SELECIONE A SALA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1604, 824);
            Controls.Add(label7);
            Controls.Add(cmbSelecaoSala);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(gbxAgendamento);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendamento de Salas";
            gbxAgendamento.ResumeLayout(false);
            gbxAgendamento.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private GroupBox gbxAgendamento;
        private Label label1;
        private ComboBox cmbFinalidade;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cmbResponsavel;
        private Label label2;
        private ComboBox cmbTurno;
        private Label lblStatus;
        private ComboBox cmbConteudo;
        private Label label6;
        private DateTimePicker dateTimeFinal;
        private DateTimePicker dateTimeInicio;
        private Button btnLimparDados;
        private Button btnIncluirNaAgenda;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Button btnMesAnterior;
        private Button btnMesAtual;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ComboBox cmbSelecaoSala;
        private Label label7;
    }
}
