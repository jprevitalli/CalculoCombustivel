using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoCombustivel
{
    public partial class CalculoCombustivel : Form
    {
        public CalculoCombustivel()
        {
            InitializeComponent();
        }

        private decimal EhDecimal(TextBox txt)
        {
            try
            {
                return Convert.ToDecimal(txt.Text);
            }
            catch
            {
                txt.Focus();
                txt.SelectAll();
                throw new Exception("Preencha o campo " + txt.Name.ToUpper().Replace("TEXTBOX", ""));

            }
        }

            private void LimparTela()
        {
            txtBoxKm.Clear();
            txtBoxLitros.Clear();
            lblRendimento.ResetText();
            txtBoxKm.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblRendimento.ResetText();
            lblConsumo.ResetText();
            try
            {
                decimal km = EhDecimal(txtBoxKm);
                decimal litros = EhDecimal(txtBoxLitros);

                decimal rendimento = km / litros;
                decimal consumo = litros / km;

                lblRendimento.Text = rendimento.ToString("N1");
                lblConsumo.Text = consumo.ToString("N3");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CalculoCombustivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) { LimparTela(); }
        }
    }
    }

