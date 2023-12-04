using Senac.DotNet._6.WF.AgendamentoSalas.Tabelas;

namespace Senac.DotNet._6.WF.AgendamentoSalas
{
    public partial class FrmCalendario : Form
    {
        private TableLayoutPanel? calendarPanel;
        private DateTime mesCorrente;
        private List<Agendamento> compromissos;

        public FrmCalendario()
        {
            InitializeComponent();

            // Configuração inicial
            mesCorrente = DateTime.Now;
            labelMesAno.Text = mesCorrente.Month.ToString() + " / " + mesCorrente.Year.ToString();
            compromissos = new List<Agendamento>
            {
                new Agendamento(DateTime.Now.AddDays(5), "Compromisso 1", "Detalhes do Compromisso 1"),
                new Agendamento(DateTime.Now.AddDays(10), "Compromisso 2", "Detalhes do Compromisso 2"),
                new Agendamento(DateTime.Now.AddDays(15), "Compromisso 3", "Detalhes do Compromisso 3"),
                new Agendamento(DateTime.Now.AddDays(15), "Compromisso 4", "Detalhes do Compromisso 4"),
                new Agendamento(DateTime.Now.AddDays(15), "Compromisso 5", "Detalhes do Compromisso 5"),
                new Agendamento(DateTime.Now.AddDays(15), "Compromisso 6", "Detalhes do Compromisso 6"),
                new Agendamento(DateTime.Now.AddDays(15), "Compromisso 7", "Detalhes do Compromisso 7"),

                new Agendamento(DateTime.Now.AddDays(15), "Compromisso 8", "Detalhes do Compromisso 8"),
            };

            MontarCalendario();
        }

        private void MontarCalendario()
        {
            // Limpa o painel antes de renderizar novamente
            calendarPanel?.Dispose();

            // Cria um novo painel para o calendário
            calendarPanel = new TableLayoutPanel
            {
                // espicha pra largura do panel1
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                RowCount = 6,
                ColumnCount = 7,
                AutoScroll = true
            };


            // Cria sub-painéis para cada dia do mês
            DateTime startDate = new DateTime(mesCorrente.Year, mesCorrente.Month, 1);
            int diasDoMes = DateTime.DaysInMonth(mesCorrente.Year, mesCorrente.Month);
            int currentRow = 0, currentCol = (int)startDate.DayOfWeek;

            for (int dia = 1; dia <= diasDoMes; dia++)
            {
                // Cria sub-painel para o dia
                Panel painelDia = new Panel
                {
                    Dock = DockStyle.Fill,
                    BorderStyle = BorderStyle.FixedSingle,
                    AutoScroll = true
                };

                // Adiciona um TextBox ao sub-painel para exibir o dia do mês
                TextBox dayTextBox = new TextBox
                {
                    Text = dia.ToString(),
                    Dock = DockStyle.Top,
                    TextAlign = HorizontalAlignment.Center,
                    ReadOnly = true,
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.White
                };

                painelDia.Controls.Add(dayTextBox);

                // Adiciona compromissos ao sub-painel
                var compromissosDoDia = compromissos.Where(c => c.Data.Day == dia &&
                                                 c.Data.Month == mesCorrente.Month &&
                                                 c.Data.Year == mesCorrente.Year).ToList();
                foreach (var compromisso in compromissosDoDia)
                {
                    Label compromissoLabel = new Label
                    {
                        Text = compromisso.Titulo,
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Height = 20,
                        ForeColor = Color.Blue
                    };

                    compromissoLabel.Click += (sender, e) => MostrarDetalhesAgendamento(compromisso);

                    painelDia.Controls.Add(compromissoLabel);
                }

                // Adiciona o sub-painel ao painel do calendário
                calendarPanel.Controls.Add(painelDia, currentCol, currentRow);

                // Atualiza as posições da linha e coluna
                currentCol++;
                if (currentCol == 7)
                {
                    currentCol = 0;
                    currentRow++;
                }
            }
            panel1.Controls.Add(calendarPanel);
        }

        private void MostrarDetalhesAgendamento(Agendamento agendamento)
        {
            // Cria e exibe um formulário com detalhes do compromisso
            Form detalhesForm = new Form
            {
                Text = $"Detalhes do Compromisso: {agendamento.Titulo}",
                Size = new Size(300, 200),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label detalhesLabel = new Label
            {
                Text = agendamento.Detalhes,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            detalhesForm.Controls.Add(detalhesLabel);
            detalhesForm.ShowDialog();
        }

        private void btnMesAnterior_Click(object sender, EventArgs e)
        {
            mesCorrente = mesCorrente.AddMonths(-1);
            labelMesAno.Text = mesCorrente.Month.ToString() + " / " + mesCorrente.Year.ToString();
            MontarCalendario();

        }

        private void btnMesAtual_Click(object sender, EventArgs e)
        {
            // Avança para o próximo mês e renderiza o calendário novamente
            mesCorrente = mesCorrente.AddMonths(1);
            labelMesAno.Text = mesCorrente.Month.ToString() + " / " + mesCorrente.Year.ToString();
            MontarCalendario();
        }
    }
}
