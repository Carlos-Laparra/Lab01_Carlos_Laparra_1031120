namespace LAB1
{
    partial class Menu_Principal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rtxtNombres = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OFD_CARGAR = new System.Windows.Forms.OpenFileDialog();
            this.cbElegirUser = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnVerCompanies = new System.Windows.Forms.Button();
            this.btn_Code_Decode = new System.Windows.Forms.Button();
            this.btn_Cartas = new System.Windows.Forms.Button();
            this.btn_VerCartas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(263, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(256, 43);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "TALENT HUB";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(619, 103);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(111, 40);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIngresar.Location = new System.Drawing.Point(63, 119);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(144, 24);
            this.lblIngresar.TabIndex = 2;
            this.lblIngresar.Text = "Ingresar CSV";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscar.Location = new System.Drawing.Point(63, 332);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(160, 24);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Buscar usuario";
            this.lblBuscar.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(619, 320);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 40);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(284, 333);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(249, 27);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.Visible = false;
            // 
            // rtxtNombres
            // 
            this.rtxtNombres.Location = new System.Drawing.Point(40, 403);
            this.rtxtNombres.Name = "rtxtNombres";
            this.rtxtNombres.Size = new System.Drawing.Size(515, 133);
            this.rtxtNombres.TabIndex = 6;
            this.rtxtNombres.Text = "";
            this.rtxtNombres.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 7;
            this.label1.Visible = false;
            // 
            // OFD_CARGAR
            // 
            this.OFD_CARGAR.FileName = "OFD_Cargar";
            this.OFD_CARGAR.Filter = "Archivos CSV|*.csv";
            // 
            // cbElegirUser
            // 
            this.cbElegirUser.FormattingEnabled = true;
            this.cbElegirUser.Location = new System.Drawing.Point(561, 403);
            this.cbElegirUser.Name = "cbElegirUser";
            this.cbElegirUser.Size = new System.Drawing.Size(188, 28);
            this.cbElegirUser.TabIndex = 8;
            this.cbElegirUser.Text = "Ver compañías...";
            this.cbElegirUser.Visible = false;
            // 
            // btnVerCompanies
            // 
            this.btnVerCompanies.Location = new System.Drawing.Point(609, 446);
            this.btnVerCompanies.Name = "btnVerCompanies";
            this.btnVerCompanies.Size = new System.Drawing.Size(111, 34);
            this.btnVerCompanies.TabIndex = 9;
            this.btnVerCompanies.Text = "Ver";
            this.btnVerCompanies.UseVisualStyleBackColor = true;
            this.btnVerCompanies.Visible = false;
            this.btnVerCompanies.Click += new System.EventHandler(this.btnVerCompanies_Click);
            // 
            // btn_Code_Decode
            // 
            this.btn_Code_Decode.Location = new System.Drawing.Point(609, 502);
            this.btn_Code_Decode.Name = "btn_Code_Decode";
            this.btn_Code_Decode.Size = new System.Drawing.Size(111, 34);
            this.btn_Code_Decode.TabIndex = 11;
            this.btn_Code_Decode.Text = "Codificar";
            this.btn_Code_Decode.UseVisualStyleBackColor = true;
            this.btn_Code_Decode.Visible = false;
            this.btn_Code_Decode.Click += new System.EventHandler(this.btn_Code_Decode_Click);
            // 
            // btn_Cartas
            // 
            this.btn_Cartas.Location = new System.Drawing.Point(334, 597);
            this.btn_Cartas.Name = "btn_Cartas";
            this.btn_Cartas.Size = new System.Drawing.Size(111, 34);
            this.btn_Cartas.TabIndex = 12;
            this.btn_Cartas.Text = "Cargar cartas";
            this.btn_Cartas.UseVisualStyleBackColor = true;
            this.btn_Cartas.Visible = false;
            this.btn_Cartas.Click += new System.EventHandler(this.btn_Cartas_Click);
            // 
            // btn_VerCartas
            // 
            this.btn_VerCartas.Location = new System.Drawing.Point(609, 597);
            this.btn_VerCartas.Name = "btn_VerCartas";
            this.btn_VerCartas.Size = new System.Drawing.Size(111, 34);
            this.btn_VerCartas.TabIndex = 13;
            this.btn_VerCartas.Text = "Ver cartas";
            this.btn_VerCartas.UseVisualStyleBackColor = true;
            this.btn_VerCartas.Visible = false;
            this.btn_VerCartas.Click += new System.EventHandler(this.btn_VerCartas_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LAB1.Properties.Resources.LOGO;
            this.ClientSize = new System.Drawing.Size(767, 668);
            this.Controls.Add(this.btn_VerCartas);
            this.Controls.Add(this.btn_Cartas);
            this.Controls.Add(this.btn_Code_Decode);
            this.Controls.Add(this.btnVerCompanies);
            this.Controls.Add(this.cbElegirUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtNombres);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Menu_Principal";
            this.Text = "TALENT HUB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private Button btnIngresar;
        private Label lblIngresar;
        private Label lblBuscar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private RichTextBox rtxtNombres;
        private Label label1;
        private OpenFileDialog OFD_CARGAR;
        private ComboBox cbElegirUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnVerCompanies;
        private Button btn_Code_Decode;
        private Button btn_Cartas;
        private Button btn_VerCartas;
    }
}