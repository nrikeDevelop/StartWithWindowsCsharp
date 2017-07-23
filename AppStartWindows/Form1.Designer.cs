namespace AppStartWindows
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.path_file = new System.Windows.Forms.TextBox();
            this.metro_button_start = new MetroFramework.Controls.MetroButton();
            this.metro_button_stop = new MetroFramework.Controls.MetroButton();
            this.metro_label = new MetroFramework.Controls.MetroLabel();
            this.start_combo_box = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // path_file
            // 
            this.path_file.CausesValidation = false;
            this.path_file.Location = new System.Drawing.Point(23, 98);
            this.path_file.Name = "path_file";
            this.path_file.Size = new System.Drawing.Size(291, 20);
            this.path_file.TabIndex = 1;
            this.path_file.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // metro_button_start
            // 
            this.metro_button_start.BackColor = System.Drawing.Color.Cornsilk;
            this.metro_button_start.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.metro_button_start.Location = new System.Drawing.Point(23, 134);
            this.metro_button_start.Name = "metro_button_start";
            this.metro_button_start.Size = new System.Drawing.Size(291, 35);
            this.metro_button_start.TabIndex = 4;
            this.metro_button_start.Text = "Iniciar con Windows";
            this.metro_button_start.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metro_button_start.UseSelectable = true;
            this.metro_button_start.Click += new System.EventHandler(this.metro_button_start_Click);
            // 
            // metro_button_stop
            // 
            this.metro_button_stop.Location = new System.Drawing.Point(221, 212);
            this.metro_button_stop.Name = "metro_button_stop";
            this.metro_button_stop.Size = new System.Drawing.Size(93, 29);
            this.metro_button_stop.TabIndex = 5;
            this.metro_button_stop.Text = "Parar";
            this.metro_button_stop.UseSelectable = true;
            this.metro_button_stop.Click += new System.EventHandler(this.metro_button_stop_Click);
            // 
            // metro_label
            // 
            this.metro_label.AutoSize = true;
            this.metro_label.Location = new System.Drawing.Point(23, 262);
            this.metro_label.Name = "metro_label";
            this.metro_label.Size = new System.Drawing.Size(0, 0);
            this.metro_label.TabIndex = 6;
            // 
            // start_combo_box
            // 
            this.start_combo_box.FormattingEnabled = true;
            this.start_combo_box.ItemHeight = 23;
            this.start_combo_box.Location = new System.Drawing.Point(23, 212);
            this.start_combo_box.Name = "start_combo_box";
            this.start_combo_box.Size = new System.Drawing.Size(180, 29);
            this.start_combo_box.TabIndex = 9;
            this.start_combo_box.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Ruta del archivo";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 190);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Archivo a eliminar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 311);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.start_combo_box);
            this.Controls.Add(this.metro_label);
            this.Controls.Add(this.metro_button_stop);
            this.Controls.Add(this.metro_button_start);
            this.Controls.Add(this.path_file);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Init";
            this.TransparencyKey = System.Drawing.SystemColors.GradientActiveCaption;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox path_file;
        private MetroFramework.Controls.MetroButton metro_button_start;
        private MetroFramework.Controls.MetroButton metro_button_stop;
        private MetroFramework.Controls.MetroLabel metro_label;
        private MetroFramework.Controls.MetroComboBox start_combo_box;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

