using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStartWindows
{
    class Tools
    {

        public static Boolean regeditStart(String nameRegedit, String pathInit)
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                rk.SetValue(nameRegedit, pathInit);
                rk.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static Boolean regeditStop(String nameRegedit)
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                rk.DeleteValue(nameRegedit);
                return true;
            }
            catch (Exception ex)
            {
                return false;
                Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message);

            }
        }

        public static String[] getListKeys()
        {
            String [] array  ;

            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            try
            {
                array = rk.GetValueNames();            
                return array;
            }
            catch
            {
                Console.WriteLine(">>Error");
                return null;
            }




        }
    }
}
