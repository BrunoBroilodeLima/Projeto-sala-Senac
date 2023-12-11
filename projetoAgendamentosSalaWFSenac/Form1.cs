using projetoAgendamentosSalaWFSenac.NovaPasta;

namespace projetoAgendamentosSalaWFSenac
{
    public partial class Form1 : Form
    {
        private TableLayoutPanel? calendarPanel;
        private DateTime mesCorrente;
        private string labelMesAno;
        private List<Agendamento> agendamentos;

        public Form1()
        {
            InitializeComponent();
            // Configuração inicial
            mesCorrente = DateTime.Now;
            labelMesAno = $"{mesCorrente.Month.ToString()}   /   {mesCorrente.Year.ToString()}";
            agendamentos = new List<Agendamento>
            {

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
            // obtem da data inicial criando DateTime a partir do dia 1
            DateTime dataInicial = new DateTime(mesCorrente.Year, mesCorrente.Month, 1);
            // obtem is dias no mes corrente
            int diasDoMes = DateTime.DaysInMonth(mesCorrente.Year, mesCorrente.Month);
            int linhaAtual = 0, colunaAtual = (int)dataInicial.DayOfWeek;

            // percorre os dias do mes
            for (int dia = 1; dia <= diasDoMes; dia++)
            {
                // Cria sub-painel para o dia
                Panel painelDia = new Panel
                {
                    Dock = DockStyle.Fill, // estica pra tamanho total do painel
                    BorderStyle = BorderStyle.FixedSingle,
                    AutoScroll = true // cria barra de rolagem
                };

                // Adiciona um TextBox ao sub-painel para exibir o dia do mês
                TextBox dayTextBox = new TextBox
                {
                    Text = dia.ToString(),
                    Dock = DockStyle.Top, // alinha no topo do painel
                    TextAlign = HorizontalAlignment.Center,
                    ReadOnly = true,                 // somente leitura
                    BorderStyle = BorderStyle.None,  // sem borda
                    BackColor = Color.White          // cor de fundo
                };

                painelDia.Controls.Add(dayTextBox);  // adicionar o numero do dia no painel do dia

                // Adiciona agendamento ao sub-painel
                // filtra pelo dia, mes e ano na lista de agendamentos
                var agendamentoDoDia = agendamentos.Where(c => c.Data.Day == dia &&
                                                 c.Data.Month == mesCorrente.Month &&
                                                 c.Data.Year == mesCorrente.Year).ToList();
                foreach (var agendamento in agendamentoDoDia)
                {
                    Label agendamentoLabel = new Label
                    {
                        Text = agendamento.Titulo,
                        Dock = DockStyle.Bottom,   // alinha na base do painel
                        TextAlign = ContentAlignment.MiddleCenter, // alinha texto no meio
                        AutoSize = false,
                        Height = 20,            // altura 20
                        ForeColor = Color.Blue  // cor do texto azul
                    };

                    // adicionar evento de clique no label
                    agendamentoLabel.Click += (sender, e) => MostrarDetalhesAgendamento(agendamento);
                    // adiciona o label no painel do dia
                    painelDia.Controls.Add(agendamentoLabel);
                }

                // Adiciona o sub-painel ao painel do calendário
                calendarPanel.Controls.Add(painelDia, colunaAtual, linhaAtual);

                // Atualiza as posições da linha e coluna
                colunaAtual++;

                // se chegou na ultima coluna(ultimo dia da semanada)
                if (colunaAtual == 7)
                {
                    // zera a coluna 
                    colunaAtual = 0;
                    // incrementa a linha
                    linhaAtual++;
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
            labelMesAno = $"{mesCorrente.Month.ToString()}   /   {mesCorrente.Year.ToString()}";
            MontarCalendario();

        }

        private void btnMesAtual_Click(object sender, EventArgs e)
        {
            // Avança para o próximo mês e renderiza o calendário novamente
            mesCorrente = mesCorrente.AddMonths(1);
            labelMesAno = $"{mesCorrente.Month.ToString()}   /   {mesCorrente.Year.ToString()}";
            MontarCalendario();
        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }



};

