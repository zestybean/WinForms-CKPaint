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
    public static void PrintToZebra(CKPaint.SecondarySchedule secondarySchedule_Part)
    {
        string IPADDRESS = "CKBFLEX1LZEBRA";
        int PORT = 9100;

        string labelPath = @"\\hail\Manufacturing Engineering\Secondary Equipment\CK_Supervisor\Label Formats\ILVS Navistar.txt";

        System.IO.StreamReader fileReader = new System.IO.StreamReader(labelPath);
        string fileContent = fileReader.ReadToEnd().ToString();
        
        fileContent = fileContent.Replace("@JN", secondarySchedule_Part.JobNumber).Replace("@LS", secondarySchedule_Part.SetNumber)
            .Replace("@P", secondarySchedule_Part.PartNumber).Replace("@CC", secondarySchedule_Part.ColorCode)
            .Replace("@DES", secondarySchedule_Part.Description).Replace("@RC", secondarySchedule_Part.RackCode)
            .Replace("@RP", secondarySchedule_Part.RackPosition).Replace("@BLK", secondarySchedule_Part.PaintBlock)
            .Replace("@WOID", secondarySchedule_Part.WOID).Replace("@DT", System.DateTime.Now.ToString())
            .Replace("@REV", "");
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
        }
        catch (Exception err)
        {
            MessageBox.Show(err.ToString(), "Print Label OnClick Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine(err);


        }

        fileReader.Close();
    }

}