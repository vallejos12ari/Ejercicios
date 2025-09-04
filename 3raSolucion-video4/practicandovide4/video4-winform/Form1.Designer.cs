namespace video4_winform
{
    partial class Form1
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lvElements = new System.Windows.Forms.ListView();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.dtFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.chbChocolate = new System.Windows.Forms.CheckBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.rbWizard = new System.Windows.Forms.RadioButton();
            this.rb2muggle = new System.Windows.Forms.RadioButton();
            this.rb3squibs = new System.Windows.Forms.RadioButton();
            this.gbtipo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbcolor = new System.Windows.Forms.ComboBox();
            this.lbnumerofavorito = new System.Windows.Forms.Label();
            this.cajanumfav1 = new System.Windows.Forms.NumericUpDown();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.gbtipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajanumfav1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(202, 48);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(200, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(160, 419);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lvElements
            // 
            this.lvElements.HideSelection = false;
            this.lvElements.Location = new System.Drawing.Point(163, 315);
            this.lvElements.Name = "lvElements";
            this.lvElements.Size = new System.Drawing.Size(260, 98);
            this.lvElements.TabIndex = 2;
            this.lvElements.UseCompatibleStateImageBehavior = false;
            this.lvElements.View = System.Windows.Forms.View.List;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(142, 51);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(73, 79);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(113, 13);
            this.lbl_fecha.TabIndex = 4;
            this.lbl_fecha.Text = "Fecha De Nacimiento:";
            this.lbl_fecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtFechaDeNacimiento
            // 
            this.dtFechaDeNacimiento.Location = new System.Drawing.Point(202, 73);
            this.dtFechaDeNacimiento.Name = "dtFechaDeNacimiento";
            this.dtFechaDeNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtFechaDeNacimiento.TabIndex = 5;
            // 
            // chbChocolate
            // 
            this.chbChocolate.AutoSize = true;
            this.chbChocolate.Location = new System.Drawing.Point(202, 110);
            this.chbChocolate.Name = "chbChocolate";
            this.chbChocolate.Size = new System.Drawing.Size(135, 17);
            this.chbChocolate.TabIndex = 6;
            this.chbChocolate.Text = "Te gusta el chocolate?";
            this.chbChocolate.UseVisualStyleBackColor = true;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(70, 9);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(184, 31);
            this.lb_titulo.TabIndex = 7;
            this.lb_titulo.Text = "Perfil Persona";
            // 
            // rbWizard
            // 
            this.rbWizard.AutoSize = true;
            this.rbWizard.Location = new System.Drawing.Point(6, 19);
            this.rbWizard.Name = "rbWizard";
            this.rbWizard.Size = new System.Drawing.Size(58, 17);
            this.rbWizard.TabIndex = 8;
            this.rbWizard.TabStop = true;
            this.rbWizard.Text = "Wizard";
            this.rbWizard.UseVisualStyleBackColor = true;
            // 
            // rb2muggle
            // 
            this.rb2muggle.AutoSize = true;
            this.rb2muggle.Location = new System.Drawing.Point(122, 19);
            this.rb2muggle.Name = "rb2muggle";
            this.rb2muggle.Size = new System.Drawing.Size(60, 17);
            this.rb2muggle.TabIndex = 9;
            this.rb2muggle.TabStop = true;
            this.rb2muggle.Text = "Muggle";
            this.rb2muggle.UseVisualStyleBackColor = true;
            // 
            // rb3squibs
            // 
            this.rb3squibs.AutoSize = true;
            this.rb3squibs.Location = new System.Drawing.Point(251, 19);
            this.rb3squibs.Name = "rb3squibs";
            this.rb3squibs.Size = new System.Drawing.Size(57, 17);
            this.rb3squibs.TabIndex = 10;
            this.rb3squibs.TabStop = true;
            this.rb3squibs.Text = "Squibs";
            this.rb3squibs.UseVisualStyleBackColor = true;
            // 
            // gbtipo
            // 
            this.gbtipo.Controls.Add(this.rbWizard);
            this.gbtipo.Controls.Add(this.rb3squibs);
            this.gbtipo.Controls.Add(this.rb2muggle);
            this.gbtipo.Location = new System.Drawing.Point(145, 144);
            this.gbtipo.Name = "gbtipo";
            this.gbtipo.Size = new System.Drawing.Size(354, 49);
            this.gbtipo.TabIndex = 11;
            this.gbtipo.TabStop = false;
            this.gbtipo.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Color Favorito:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cbcolor
            // 
            this.cbcolor.FormattingEnabled = true;
            this.cbcolor.Location = new System.Drawing.Point(267, 199);
            this.cbcolor.Name = "cbcolor";
            this.cbcolor.Size = new System.Drawing.Size(171, 21);
            this.cbcolor.TabIndex = 13;
            // 
            // lbnumerofavorito
            // 
            this.lbnumerofavorito.AutoSize = true;
            this.lbnumerofavorito.Location = new System.Drawing.Point(163, 242);
            this.lbnumerofavorito.Name = "lbnumerofavorito";
            this.lbnumerofavorito.Size = new System.Drawing.Size(85, 13);
            this.lbnumerofavorito.TabIndex = 14;
            this.lbnumerofavorito.Text = "Numero Favorito";
            // 
            // cajanumfav1
            // 
            this.cajanumfav1.Location = new System.Drawing.Point(267, 234);
            this.cajanumfav1.Name = "cajanumfav1";
            this.cajanumfav1.Size = new System.Drawing.Size(120, 20);
            this.cajanumfav1.TabIndex = 15;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(166, 273);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnPerfil.TabIndex = 16;
            this.btnPerfil.Text = "Ver Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.cajanumfav1);
            this.Controls.Add(this.lbnumerofavorito);
            this.Controls.Add(this.cbcolor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbtipo);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.chbChocolate);
            this.Controls.Add(this.dtFechaDeNacimiento);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lvElements);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txtnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbtipo.ResumeLayout(false);
            this.gbtipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajanumfav1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ListView lvElements;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.DateTimePicker dtFechaDeNacimiento;
        private System.Windows.Forms.CheckBox chbChocolate;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.RadioButton rbWizard;
        private System.Windows.Forms.RadioButton rb2muggle;
        private System.Windows.Forms.RadioButton rb3squibs;
        private System.Windows.Forms.GroupBox gbtipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbcolor;
        private System.Windows.Forms.Label lbnumerofavorito;
        private System.Windows.Forms.NumericUpDown cajanumfav1;
        private System.Windows.Forms.Button btnPerfil;
    }
}

