using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace DownlFrIntertFileInCurDirCatcAllExcpt
{
    class DownlFrIntertFileInCurDirCatcAllExcpt
    {
        static void Main(string[] args)
        {
        //Write a program that downloads a file from Internet 
       //(e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory.
      //Find in Google how to download files in C#. Be sure to catch all exceptions and to 
      //free any used resources in the finally block.
            try
            {
                WebClient Client = new WebClient();
                string toDownloadPath = Console.ReadLine();
                string fileName = String.Format(@"{0}\picture.jpg", Environment.CurrentDirectory);
                Client.DownloadFile(toDownloadPath, fileName);
            }
            catch (WebException e)
            {
                MessageBox.Show(e.Message);
            } 
        }
    }
}