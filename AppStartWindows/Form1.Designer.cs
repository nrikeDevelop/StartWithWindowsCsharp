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
            this.SuspendLayout();
            // 
            // path_file
            // 
            this.path_file.Location = new System.Drawing.Point(23, 63);
            this.path_file.Name = "path_file";
            this.path_file.Size = new System.Drawing.Size(258, 20);
            this.path_file.TabIndex = 1;
            this.path_file.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // metro_button_start
            // 
            this.metro_button_start.BackColor = System.Drawing.Color.Cornsilk;
            this.metro_button_start.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.metro_button_start.Location = new System.Drawing.Point(23, 96);
            this.metro_button_start.Name = "metro_button_start";
            this.metro_button_start.Size = new System.Drawing.Size(162, 35);
            this.metro_button_start.TabIndex = 4;
            this.metro_button_start.Text = "Iniciar con Windows";
            this.metro_button_start.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metro_button_start.UseSelectable = true;
            this.metro_button_start.Click += new System.EventHandler(this.metro_button_start_Click);
            // 
            // metro_button_stop
            // 
            this.metro_button_stop.Location = new System.Drawing.Point(191, 96);
            this.metro_button_stop.Name = "metro_button_stop";
            this.metro_button_stop.Size = new System.Drawing.Size(90, 35);
            this.metro_button_stop.TabIndex = 5;
            this.metro_button_stop.Text = "Parar";
            this.metro_button_stop.UseSelectable = true;
            this.metro_button_stop.Click += new System.EventHandler(this.metro_button_stop_Click);
            // 
            // metro_label
            // 
            this.metro_label.AutoSize = true;
            this.metro_label.Location = new System.Drawing.Point(23, 144);
            this.metro_label.Name = "metro_label";
            this.metro_label.Size = new System.Drawing.Size(0, 0);
            this.metro_label.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 174);
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
    }
}

