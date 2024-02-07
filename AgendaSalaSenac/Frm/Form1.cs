using System.Data;
using System.Windows.Forms;
using AgendaSalaSenac.DAL;
using AgendaSalaSenac.Models;

namespace AgendaSalaSenac
{
    public partial class Form1 : Form
    {
        bool ehNovo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DALAgenda.CriarBancoSQLite();
            DALAgenda.CriarTabelaSQLite();
            ExibirDados();
            lblDados.Text = DALAgenda.path;
        }
        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DALAgenda.GetReservas();
                dgvDados.DataSource = dt;

                DataTable dtH = new DataTable();
                dtH = DALAgenda.GetHistorico();
                dgvHistorico.DataSource = dtH;

            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
            }
        }

       
        private void LimparDados()
        {
            txtId.Clear();
            //cmbSala.Clear();
            //cmbTurno.Clear();
            //dateTimePickerInicio = new DateTimePicker();
            //dateTimePickerFim = new DateTimePicker();
            //cmbResponsavel.Clear();
            txtFinalidade.Clear();
            txtConteudo.Clear();
            ckSeg.Checked = false;
            ckTer.Checked = false;
            ckQua.Checked = false;
            ckQui.Checked = false;
            ckSex.Checked = false;
            ckSab.Checked = false;

            cmbSala.Focus();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                DALAgenda.Encerrar(id);
                ExibirDados();
                LimparDados();
                btnEncerrar.Enabled = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        private void btnLocalizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (txtId.Text != "")
                {

                    int id = Convert.ToInt32(txtId.Text);
                    dt = DALAgenda.GetReseva(id);

                }
                else
                {
                    string usuario = cmbSala.Text;
                    dt = DALAgenda.GetReservas(usuario);
                }
                dgvDados.DataSource = dt;
                LimparDados();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linhaSelecionada = dgvDados.Rows[e.RowIndex];

                foreach (DataGridViewCell cell in linhaSelecionada.Cells)
                {
                    string valorDaCelula = cell.Value.ToString();
                }
                txtId.Text = linhaSelecionada.Cells[0].Value.ToString();
                if (txtId.Text == "")
                {
                    return;
                }
                cmbSala.Text = linhaSelecionada.Cells[1].Value.ToString();
                cmbTurno.Text = linhaSelecionada.Cells[2].Value.ToString();
                dateTimePickerInicio.Value = Convert.ToDateTime(linhaSelecionada.Cells[3].Value.ToString());
                dateTimePickerFim.Value = Convert.ToDateTime(linhaSelecionada.Cells[4].Value.ToString());
                cmbResponsavel.Text = linhaSelecionada.Cells[5].Value.ToString();
                txtFinalidade.Text = linhaSelecionada.Cells[6].Value.ToString();
                txtConteudo.Text = linhaSelecionada.Cells[7].Value.ToString();
                ckSeg.Checked = (bool)linhaSelecionada.Cells[9].Value;
                ckTer.Checked = (bool)linhaSelecionada.Cells[10].Value;
                ckQua.Checked = (bool)linhaSelecionada.Cells[11].Value;
                ckQui.Checked = (bool)linhaSelecionada.Cells[12].Value;
                ckSex.Checked = (bool)linhaSelecionada.Cells[13].Value;
                ckSab.Checked = (bool)linhaSelecionada.Cells[14].Value;

                btnEditar.Enabled = true;
                btnEncerrar.Enabled = true;

            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ehNovo = true;
            LimparDados();
            habilitarCampos();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ehNovo)
            {
                if (!ValidarDisponibilidade())
                {
                    MessageBox.Show("Sala/Turno ocupados");
                    return;
                }

                Inserir();
                ehNovo = false;
            }
            else
            {
                Atualizar();
            }
            deshabilitarCampos();
            btnEditar.Enabled = false;
        }

        void Inserir()
        {
            try
            {
                Reserva reserva = new Reserva();
                reserva.Sala = cmbSala.Text;
                reserva.Turno = cmbTurno.Text;
                reserva.DataInicioAgendamento = dateTimePickerInicio.Value;
                reserva.DataFinalAgendamento = dateTimePickerFim.Value;
                reserva.Responsavel = cmbResponsavel.Text;
                reserva.Finalidade = txtFinalidade.Text;
                reserva.Conteudo = txtConteudo.Text;
                reserva.ckSeg = ckSeg.Checked;
                reserva.ckTer = ckTer.Checked;
                reserva.ckQua = ckQua.Checked;
                reserva.ckQui = ckQui.Checked;
                reserva.ckSex = ckSex.Checked;
                reserva.ckSab = ckSab.Checked;

                DALAgenda.Add(reserva);
                ExibirDados();
                LimparDados();


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        void Atualizar()
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                var reserva = DALAgenda.GetReserva(id);
                reserva.Sala = cmbSala.Text;
                reserva.Turno = cmbTurno.Text;
                reserva.DataInicioAgendamento = dateTimePickerInicio.Value;
                reserva.DataFinalAgendamento = dateTimePickerFim.Value;
                reserva.Responsavel = cmbResponsavel.Text;
                reserva.Finalidade = txtFinalidade.Text;
                reserva.Conteudo = txtConteudo.Text;
                reserva.ckSeg = ckSeg.Checked;
                reserva.ckTer = ckTer.Checked;
                reserva.ckQua = ckQua.Checked;
                reserva.ckQui = ckQui.Checked;
                reserva.ckSex = ckSex.Checked;
                reserva.ckSab = ckSab.Checked;




                DALAgenda.Update(reserva);
                ExibirDados();
                LimparDados();



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ehNovo = false;
            habilitarCampos();
            //ExibirDados();
        }

        private void habilitarCampos()
        {
            cmbSala.Enabled = true;
            cmbTurno.Enabled = true;
            dateTimePickerInicio.Enabled = true;
            dateTimePickerFim.Enabled = true;
            ckSeg.Enabled = true;
            ckTer.Enabled = true;
            ckQua.Enabled = true;
            ckQui.Enabled = true;
            ckSex.Enabled = true;
            ckSab.Enabled = true;
            cmbResponsavel.Enabled = true;
            txtFinalidade.Enabled = true;
            txtConteudo.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            cmbSala.Focus();

        }
        private void deshabilitarCampos()
        {
            cmbSala.Enabled = !true;
            cmbTurno.Enabled = !true;
            dateTimePickerInicio.Enabled = false;
            dateTimePickerFim.Enabled = !true;
            ckSeg.Enabled = !true;
            ckTer.Enabled = !true;
            ckQua.Enabled = !true;
            ckQui.Enabled = !true;
            ckSex.Enabled = !true;
            ckSab.Enabled = !true;
            cmbResponsavel.Enabled = !true;
            txtFinalidade.Enabled = !true;
            txtConteudo.Enabled = !true;
            btnSalvar.Enabled = !true;
            btnCancelar.Enabled = !true;


        }


        bool ValidarDisponibilidade()
        {
            Reserva reserva = new Reserva();
            reserva.Sala = cmbSala.Text;
            reserva.Turno = cmbTurno.Text;
            reserva.DataInicioAgendamento = dateTimePickerInicio.Value;
            reserva.DataFinalAgendamento = dateTimePickerFim.Value;
            reserva.Responsavel = cmbResponsavel.Text;
            reserva.Finalidade = txtFinalidade.Text;
            reserva.Conteudo = txtConteudo.Text;
            reserva.ckSeg = ckSeg.Checked;
            reserva.ckTer = ckTer.Checked;
            reserva.ckQua = ckQua.Checked;
            reserva.ckQui = ckQui.Checked;
            reserva.ckSex = ckSex.Checked;
            reserva.ckSab = ckSab.Checked;


            bool disponivel = DALAgenda.ConsultarDisponibilidade(reserva);

            if (disponivel)
            {
                return true;
            }

            LimparDados();
            return false;
        }

        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitarCampos();
            LimparDados();
            ehNovo = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente fechar o programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
            
        }
    }
}
