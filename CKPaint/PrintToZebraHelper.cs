using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

public static class PrintToZebraHelper
{
    public static void PrintToZebra(Label errLbl)
    {
        string IPADDRESS = "CKBFLEX1LZEBRA";
        int PORT = 9100;

        string labelPath = @"\\hail\Manufacturing Engineering\Secondary Equipment\CK_Supervisor\Label Formats\ILVS Navistar.txt";


        System.IO.StreamReader fileReader = new System.IO.StreamReader(labelPath);
        string fileContent = fileReader.ReadToEnd().ToString();
        fileContent = fileContent.Replace("@P", "100000");
        try
        {
            //Open zebra connection
            System.Net.Sockets.TcpClient printer = new System.Net.Sockets.TcpClient();
            printer.Connect(IPADDRESS, PORT);

            //Write label file
            System.IO.StreamWriter writer = new System.IO.StreamWriter(printer.GetStream());
            writer.Write(fileContent);
            writer.Flush();



            writer.Close();
            printer.Close();

            errLbl.Text = "Print Success!";
        }
        catch (Exception err)
        {
            errLbl.Text = err.ToString();
            Console.WriteLine(err);


        }

        fileReader.Close();
    }

}