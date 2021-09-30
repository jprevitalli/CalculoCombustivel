
namespace CalculoCombustivel
{
    partial class CalculoCombustivel
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKM = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblRendimentoKmLitro = new System.Windows.Forms.Label();
            this.lblRendimento = new System.Windows.Forms.Label();
            this.lblConsumoLitrosKm = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.txtBoxKm = new System.Windows.Forms.TextBox();
            this.txtBoxLitros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKM.Location = new System.Drawing.Point(37, 54);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(35, 17);
            this.lblKM.TabIndex = 0;
            this.lblKM.Text = "&Km:";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitros.Location = new System.Drawing.Point(37, 140);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(54, 17);
            this.lblLitros.TabIndex = 1;
            this.lblLitros.Text = "&Litros:";
            // 
            // lblRendimentoKmLitro
            // 
            this.lblRendimentoKmLitro.AutoSize = true;
            this.lblRendimentoKmLitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRendimentoKmLitro.Location = new System.Drawing.Point(289, 33);
            this.lblRendimentoKmLitro.Name = "lblRendimentoKmLitro";
            this.lblRendimentoKmLitro.Size = new System.Drawing.Size(152, 16);
            this.lblRendimentoKmLitro.TabIndex = 2;
            this.lblRendimentoKmLitro.Text = "Rendimento - Km / Litros";
            // 
            // lblRendimento
            // 
            this.lblRendimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRendimento.Location = new System.Drawing.Point(292, 63);
            this.lblRendimento.Name = "lblRendimento";
            this.lblRendimento.Size = new System.Drawing.Size(149, 27);
            this.lblRendimento.TabIndex = 3;
            this.lblRendimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConsumoLitrosKm
            // 
            this.lblConsumoLitrosKm.AutoSize = true;
            this.lblConsumoLitrosKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumoLitrosKm.Location = new System.Drawing.Point(289, 121);
            this.lblConsumoLitrosKm.Name = "lblConsumoLitrosKm";
            this.lblConsumoLitrosKm.Size = new System.Drawing.Size(136, 16);
            this.lblConsumoLitrosKm.TabIndex = 4;
            this.lblConsumoLitrosKm.Text = "Consumo - Litros / Km";
            // 
            // lblConsumo
            // 
            this.lblConsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumo.Location = new System.Drawing.Point(292, 147);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(149, 27);
            this.lblConsumo.TabIndex = 5;
            this.lblConsumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxKm
            // 
            this.txtBoxKm.BackColor = System.Drawing.Color.White;
            this.txtBoxKm.Location = new System.Drawing.Point(95, 51);
            this.txtBoxKm.Name = "txtBoxKm";
            this.txtBoxKm.Size = new System.Drawing.Size(167, 22);
            this.txtBoxKm.TabIndex = 6;
            this.txtBoxKm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxLitros
            // 
            this.txtBoxLitros.BackColor = System.Drawing.Color.White;
            this.txtBoxLitros.Location = new System.Drawing.Point(95, 137);
            this.txtBoxLitros.Name = "txtBoxLitros";
            this.txtBoxLitros.Size = new System.Drawing.Size(167, 22);
            this.txtBoxLitros.TabIndex = 7;
            this.txtBoxLitros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(40, 204);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(401, 36);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // CalculoCombustivel
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(477, 263);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtBoxLitros);
            this.Controls.Add(this.txtBoxKm);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblConsumoLitrosKm);
            this.Controls.Add(this.lblRendimento);
            this.Controls.Add(this.lblRendimentoKmLitro);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblKM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "CalculoCombustivel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Combustível";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculoCombustivel_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblRendimentoKmLitro;
        private System.Windows.Forms.Label lblRendimento;
        private System.Windows.Forms.Label lblConsumoLitrosKm;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox txtBoxKm;
        private System.Windows.Forms.TextBox txtBoxLitros;
        private System.Windows.Forms.Button btnCalcular;
    }
}

