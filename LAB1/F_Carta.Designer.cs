namespace LAB1
{
    partial class F_Carta
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
            this.btn_Code_Decode = new System.Windows.Forms.Button();
            this.cbCartas = new System.Windows.Forms.ComboBox();
            this.rtxtCarta = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtInfo = new System.Windows.Forms.RichTextBox();
            this.btn_MostrarCarta = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Code_Decode
            // 
            this.btn_Code_Decode.Location = new System.Drawing.Point(296, 579);
            this.btn_Code_Decode.Name = "btn_Code_Decode";
            this.btn_Code_Decode.Size = new System.Drawing.Size(111, 34);
            this.btn_Code_Decode.TabIndex = 12;
            this.btn_Code_Decode.Text = "Codificar";
            this.btn_Code_Decode.UseVisualStyleBackColor = true;
            this.btn_Code_Decode.Click += new System.EventHandler(this.btn_Code_Decode_Click);
            // 
            // cbCartas
            // 
            this.cbCartas.FormattingEnabled = true;
            this.cbCartas.Location = new System.Drawing.Point(576, 211);
            this.cbCartas.Name = "cbCartas";
            this.cbCartas.Size = new System.Drawing.Size(168, 28);
            this.cbCartas.TabIndex = 13;
            this.cbCartas.Text = "Seleccione carta...";
            // 
            // rtxtCarta
            // 
            this.rtxtCarta.Location = new System.Drawing.Point(26, 82);
            this.rtxtCarta.Name = "rtxtCarta";
            this.rtxtCarta.Size = new System.Drawing.Size(540, 453);
            this.rtxtCarta.TabIndex = 14;
            this.rtxtCarta.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 45);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cartas";
            // 
            // rtxtInfo
            // 
            this.rtxtInfo.Location = new System.Drawing.Point(576, 82);
            this.rtxtInfo.Name = "rtxtInfo";
            this.rtxtInfo.Size = new System.Drawing.Size(168, 114);
            this.rtxtInfo.TabIndex = 16;
            this.rtxtInfo.Text = "";
            // 
            // btn_MostrarCarta
            // 
            this.btn_MostrarCarta.Location = new System.Drawing.Point(601, 266);
            this.btn_MostrarCarta.Name = "btn_MostrarCarta";
            this.btn_MostrarCarta.Size = new System.Drawing.Size(111, 34);
            this.btn_MostrarCarta.TabIndex = 17;
            this.btn_MostrarCarta.Text = "Mostrar";
            this.btn_MostrarCarta.UseVisualStyleBackColor = true;
            this.btn_MostrarCarta.Click += new System.EventHandler(this.btn_MostrarCarta_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Location = new System.Drawing.Point(633, 610);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(111, 34);
            this.btn_Regresar.TabIndex = 18;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // F_Carta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LAB1.Properties.Resources.LOGO;
            this.ClientSize = new System.Drawing.Size(756, 656);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_MostrarCarta);
            this.Controls.Add(this.rtxtInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtCarta);
            this.Controls.Add(this.cbCartas);
            this.Controls.Add(this.btn_Code_Decode);
            this.Name = "F_Carta";
            this.Text = "F_Carta";
            this.Load += new System.EventHandler(this.F_Carta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Code_Decode;
        private ComboBox cbCartas;
        private RichTextBox rtxtCarta;
        private Label label1;
        private RichTextBox rtxtInfo;
        private Button btn_MostrarCarta;
        private Button btn_Regresar;
    }
}