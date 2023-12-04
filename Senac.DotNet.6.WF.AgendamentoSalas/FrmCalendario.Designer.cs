namespace Senac.DotNet._6.WF.AgendamentoSalas
{
    partial class FrmCalendario
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnMesAnterior = new Button();
            btnMesAtual = new Button();
            labelMesAno = new Label();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8183079F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.181694F));
            tableLayoutPanel1.Size = new Size(1498, 750);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnMesAnterior);
            flowLayoutPanel1.Controls.Add(btnMesAtual);
            flowLayoutPanel1.Controls.Add(labelMesAno);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(678, 72);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnMesAnterior
            // 
            btnMesAnterior.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMesAnterior.Location = new Point(3, 3);
            btnMesAnterior.Name = "btnMesAnterior";
            btnMesAnterior.Size = new Size(191, 69);
            btnMesAnterior.TabIndex = 0;
            btnMesAnterior.Text = "<";
            btnMesAnterior.UseVisualStyleBackColor = true;
            btnMesAnterior.Click += btnMesAnterior_Click;
            // 
            // btnMesAtual
            // 
            btnMesAtual.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMesAtual.Location = new Point(200, 3);
            btnMesAtual.Name = "btnMesAtual";
            btnMesAtual.Size = new Size(191, 69);
            btnMesAtual.TabIndex = 1;
            btnMesAtual.Text = ">";
            btnMesAtual.UseVisualStyleBackColor = true;
            btnMesAtual.Click += btnMesAtual_Click;
            // 
            // labelMesAno
            // 
            labelMesAno.AutoSize = true;
            labelMesAno.Dock = DockStyle.Left;
            labelMesAno.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMesAno.Location = new Point(397, 0);
            labelMesAno.Name = "labelMesAno";
            labelMesAno.Size = new Size(0, 75);
            labelMesAno.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(1492, 663);
            panel1.TabIndex = 1;
            // 
            // FrmCalendario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1498, 750);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmCalendario";
            Text = "Calendário";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnMesAnterior;
        private Button btnMesAtual;
        private Label labelMesAno;
        private Panel panel1;
    }
}
