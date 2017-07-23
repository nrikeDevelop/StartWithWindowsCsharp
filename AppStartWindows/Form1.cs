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
            refreshComboBox();
           
        }

        String regeditInit = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        String pathInit = "" ;

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

        public void refreshComboBox()
        {
            start_combo_box.Items.Clear();

            String[] ListKeys = Tools.getListKeys();

            if (ListKeys != null)
            {
                for (int i = 0; i < ListKeys.Length; i++)
                {
                    start_combo_box.Items.Add(ListKeys[i]);
                }
            }
            else
            {
                start_combo_box.Items.Add("No hay datos");
            }
        }
   
        private void metro_button_start_Click(object sender, EventArgs e)
        {
             String nameRegedit = getFileName(pathInit);


            if (pathInit.Equals(""))
            {
                metro_label.Text = "Seleccina la ruta del archivo";
            }
            else
            {

                if(Tools.regeditStart(nameRegedit, pathInit))
                {
                    metro_label.Text = "Se iniciara con Windows";
                    refreshComboBox();
                }
                else
                {
                    metro_label.Text = "Error de registro";

                }

            }
        }

        private void metro_button_stop_Click(object sender, EventArgs e)
        {

            try
            {
      
                String nameRegedit = start_combo_box.SelectedItem.ToString();

                if (nameRegedit != null)
                {
                    if (Tools.regeditStop(nameRegedit))
                    {
                        metro_label.Text = "Registro eliminado";
                        refreshComboBox();
                    }
                    else
                    {
                        metro_label.Text = "No existe registro";
                    }
                }
            }
            catch
            {
                metro_label.Text = "Selecciona el registro a eliminar";

            }


            /*

            if (pathInit.Equals(""))
            {
                metro_label.Text = "Seleccina la ruta del archivo";
            }
            else
            {
                if (Tools.regeditStop(nameRegedit))
                {
                    metro_label.Text = "Registro eliminado";
                }
                else
                {
                    metro_label.Text = "No existe registro";
                }
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tools.getListKeys();
        }

  


    }
}
