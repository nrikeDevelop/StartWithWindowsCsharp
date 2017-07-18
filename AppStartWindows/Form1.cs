using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppStartWindows
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        String regeditInit = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        String pathInit = "" ;
        string nameRegedit = "";

        private void textBox1_Click(object sender, EventArgs e)
        {
            /*
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                pathInit = fdb.SelectedPath;
                path_file.Text = pathInit;
            }
            */

            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog () == DialogResult.OK)
            {
                pathInit = ofd.FileName;
                path_file.Text = pathInit;

                nameRegedit = getFileName(pathInit);
              //  MessageBox.Show(nameRegedit);           
            }
        }

        private string getFileName(String dir)
        {
            string[] nameSeparator = dir.Split('\\');
            string FileName = nameSeparator[nameSeparator.Length - 1];
            string[] name = FileName.Split('.');

            return name[0];
        }

        private void init_with_windows_Click(object sender, EventArgs e)
        {
         
        }

        private void stop_windows_Click(object sender, EventArgs e)
        {
        
        }

        public void regeditStart()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                rk.SetValue(nameRegedit, pathInit);
                rk.Close();

                metro_label.Text = "Se iniciara con Windows";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }

        public void regeditStop()
        {
            try
            {

                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                rk.DeleteValue(nameRegedit);

                metro_label.Text = "Registro eliminado";

            }
            catch (Exception ex)
            {
                metro_label.Text = "No existe registro";

                //MessageBox.Show(ex.Message);

            }
        }

        private void metro_button_start_Click(object sender, EventArgs e)
        {
            if (pathInit.Equals(""))
            {
                metro_label.Text = "Seleccina la ruta del archivo";
            }
            else
            {
                regeditStart();
            }
        }

        private void metro_button_stop_Click(object sender, EventArgs e)
        {
            if (pathInit.Equals(""))
            {
                metro_label.Text = "Seleccina la ruta del archivo";
            }
            else
            {
                regeditStop();
            }
        }
    }
}
