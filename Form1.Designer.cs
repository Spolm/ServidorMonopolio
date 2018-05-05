namespace ServidorMonopolio
{
    partial class ServerForm
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
            this.tLogs = new System.Windows.Forms.TextBox();
            this.tLista_Jugadores = new System.Windows.Forms.TextBox();
            this.bApagar = new System.Windows.Forms.Button();
            this.bIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tIP = new System.Windows.Forms.TextBox();
            this.tPuerto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tLogs
            // 
            this.tLogs.BackColor = System.Drawing.Color.White;
            this.tLogs.Location = new System.Drawing.Point(12, 40);
            this.tLogs.Multiline = true;
            this.tLogs.Name = "tLogs";
            this.tLogs.ReadOnly = true;
            this.tLogs.Size = new System.Drawing.Size(558, 467);
            this.tLogs.TabIndex = 0;
            this.tLogs.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tLista_Jugadores
            // 
            this.tLista_Jugadores.BackColor = System.Drawing.Color.White;
            this.tLista_Jugadores.Location = new System.Drawing.Point(586, 40);
            this.tLista_Jugadores.Multiline = true;
            this.tLista_Jugadores.Name = "tLista_Jugadores";
            this.tLista_Jugadores.ReadOnly = true;
            this.tLista_Jugadores.Size = new System.Drawing.Size(315, 307);
            this.tLista_Jugadores.TabIndex = 1;
            // 
            // bApagar
            // 
            this.bApagar.Location = new System.Drawing.Point(586, 476);
            this.bApagar.Name = "bApagar";
            this.bApagar.Size = new System.Drawing.Size(315, 31);
            this.bApagar.TabIndex = 4;
            this.bApagar.Text = "Cerrar Conexión";
            this.bApagar.UseVisualStyleBackColor = true;
            this.bApagar.Click += new System.EventHandler(this.bApagar_Click);
            // 
            // bIniciar
            // 
            this.bIniciar.Location = new System.Drawing.Point(586, 425);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(315, 34);
            this.bIniciar.TabIndex = 3;
            this.bIniciar.Text = "Iniciar Conexión";
            this.bIniciar.UseVisualStyleBackColor = true;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(583, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dirección IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Puerto:";
            // 
            // tIP
            // 
            this.tIP.Location = new System.Drawing.Point(673, 359);
            this.tIP.Name = "tIP";
            this.tIP.Size = new System.Drawing.Size(228, 20);
            this.tIP.TabIndex = 1;
            // 
            // tPuerto
            // 
            this.tPuerto.Location = new System.Drawing.Point(672, 391);
            this.tPuerto.Name = "tPuerto";
            this.tPuerto.Size = new System.Drawing.Size(95, 20);
            this.tPuerto.TabIndex = 2;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 519);
            this.Controls.Add(this.tPuerto);
            this.Controls.Add(this.tIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bIniciar);
            this.Controls.Add(this.bApagar);
            this.Controls.Add(this.tLista_Jugadores);
            this.Controls.Add(this.tLogs);
            this.Name = "ServerForm";
            this.Text = "Servidor - Monopolio";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tLogs;
        private System.Windows.Forms.TextBox tLista_Jugadores;
        private System.Windows.Forms.Button bApagar;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tIP;
        private System.Windows.Forms.TextBox tPuerto;
    }
}

