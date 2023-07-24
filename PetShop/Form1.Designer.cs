namespace PetShop
{
    partial class Form1
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
            this.PanelTopo = new System.Windows.Forms.Panel();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnRacas = new System.Windows.Forms.Button();
            this.btnAnimais = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnAgendamentos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.PanelTopo.SuspendLayout();
            this.PanelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTopo
            // 
            this.PanelTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PanelTopo.Controls.Add(this.btnSair);
            this.PanelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopo.Location = new System.Drawing.Point(0, 0);
            this.PanelTopo.Name = "PanelTopo";
            this.PanelTopo.Size = new System.Drawing.Size(1442, 45);
            this.PanelTopo.TabIndex = 1;
            // 
            // PanelCentral
            // 
            this.PanelCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelCentral.BackColor = System.Drawing.Color.Blue;
            this.PanelCentral.Location = new System.Drawing.Point(218, 63);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(1212, 429);
            this.PanelCentral.TabIndex = 2;
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PanelLateral.Controls.Add(this.btnAgendamentos);
            this.PanelLateral.Controls.Add(this.btnServicos);
            this.PanelLateral.Controls.Add(this.btnAnimais);
            this.PanelLateral.Controls.Add(this.btnRacas);
            this.PanelLateral.Controls.Add(this.btnClientes);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 45);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(219, 739);
            this.PanelLateral.TabIndex = 3;
            this.PanelLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLateral_Paint);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClientes.Location = new System.Drawing.Point(26, 31);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(165, 54);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnRacas
            // 
            this.btnRacas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRacas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRacas.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRacas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRacas.Location = new System.Drawing.Point(26, 114);
            this.btnRacas.Name = "btnRacas";
            this.btnRacas.Size = new System.Drawing.Size(165, 54);
            this.btnRacas.TabIndex = 1;
            this.btnRacas.Text = "Raças";
            this.btnRacas.UseVisualStyleBackColor = false;
            // 
            // btnAnimais
            // 
            this.btnAnimais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimais.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimais.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAnimais.Location = new System.Drawing.Point(26, 189);
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.Size = new System.Drawing.Size(165, 54);
            this.btnAnimais.TabIndex = 2;
            this.btnAnimais.Text = "Animais";
            this.btnAnimais.UseVisualStyleBackColor = false;
            // 
            // btnServicos
            // 
            this.btnServicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnServicos.Location = new System.Drawing.Point(26, 269);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(165, 54);
            this.btnServicos.TabIndex = 3;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.UseVisualStyleBackColor = false;
            // 
            // btnAgendamentos
            // 
            this.btnAgendamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamentos.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamentos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgendamentos.Location = new System.Drawing.Point(26, 349);
            this.btnAgendamentos.Name = "btnAgendamentos";
            this.btnAgendamentos.Size = new System.Drawing.Size(165, 54);
            this.btnAgendamentos.TabIndex = 4;
            this.btnAgendamentos.Text = "Agendamentos";
            this.btnAgendamentos.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSair.BackgroundImage = global::PetShop.Properties.Resources.vecteezy_x_png_transparent_9344493_556;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(1093, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(51, 39);
            this.btnSair.TabIndex = 0;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 784);
            this.Controls.Add(this.PanelLateral);
            this.Controls.Add(this.PanelTopo);
            this.Controls.Add(this.PanelCentral);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelTopo.ResumeLayout(false);
            this.PanelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelTopo;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnAgendamentos;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnAnimais;
        private System.Windows.Forms.Button btnRacas;
        private System.Windows.Forms.Button btnSair;
    }
}

