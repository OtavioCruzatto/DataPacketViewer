using DataPacketViewer.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPacketViewer
{
    public partial class CodeDecodeForm : Form
    {
        private List<byte> dataPacketBytes;
        private List<byte> payloadDataBytes;
        private String codedDataPackets;

        public CodeDecodeForm()
        {
            InitializeComponent();

            payloadDataBytes = new List<byte>();
            dataPacketBytes = new List<byte>();

            codedDataPacketsTextBox.ScrollBars = ScrollBars.Both;

            decodedDataPacketsListView.Columns.Add("", 0, HorizontalAlignment.Center);
            decodedDataPacketsListView.Columns.Add("Starter byte 1", 100, HorizontalAlignment.Center);
            decodedDataPacketsListView.Columns.Add("Starter byte 2", 100, HorizontalAlignment.Center);
            decodedDataPacketsListView.Columns.Add("Command byte", 100, HorizontalAlignment.Center);
            decodedDataPacketsListView.Columns.Add("Payload Data Bytes", 335, HorizontalAlignment.Center);
            decodedDataPacketsListView.Columns.Add("CRC Byte", 100, HorizontalAlignment.Center);
            decodedDataPacketsListView.Scrollable = true;
            decodedDataPacketsListView.View = View.Details;
            decodedDataPacketsListView.GridLines = true;
            decodedDataPacketsListView.FullRowSelect = true;
        }

        private void codeButton_Click(object sender, EventArgs e)
        {
            DataPacket dataPacket = new DataPacket();
            String starter1Str = starterByte1TextBox.Text.Trim();
            String starter2Str = starterByte2TextBox.Text.Trim();
            String commandStr = commandByteTextBox.Text.Trim();
            String payloadDataStr = payloadDataBytesTextBox.Text.Trim();
            String[] payloadDataStrArray = new String[0];
            payloadDataBytes.Clear();

            if (payloadDataStr.Length > 0)
            {
                payloadDataStrArray = payloadDataStr.Split(' ');
            }

            try
            {
                Byte starter1Byte = Convert.ToByte(starter1Str, 16);
                Byte starter2Byte = Convert.ToByte(starter2Str, 16);
                Byte commandByte = Convert.ToByte(commandStr, 16);

                if (payloadDataStrArray.Length > 0)
                {
                    foreach (String str in payloadDataStrArray)
                    {
                        if (str != "")
                        {
                            payloadDataBytes.Add(Convert.ToByte(str, 16));
                        }
                    }
                }
                
                dataPacket.Mount(starter1Byte, starter2Byte, commandByte, payloadDataBytes);

                if (dataPacket.isValid())
                {
                    foreach (Byte b in dataPacket.GetDataPacket())
                    {
                        this.codedDataPackets += "0x" + b.ToString("X2") + " ";
                    }
                    this.codedDataPackets += System.Environment.NewLine;
                    codedDataPacketsTextBox.Text = this.codedDataPackets;
                    codedDataPacketsTextBox.SelectionStart = codedDataPacketsTextBox.Text.Length;
                    codedDataPacketsTextBox.ScrollToCaret();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            DataPacket dataPacket = new DataPacket();
            String dataPacketStr = dataPacketTextBox.Text.Trim();
            String[] dataPacketStrArray = new String[0];
            dataPacketBytes.Clear();

            if (dataPacketStr.Length > 0)
            {
                dataPacketStrArray = dataPacketStr.Split(' ');
            }

            try
            {
                if (dataPacketStrArray.Length > 0)
                {
                    foreach (String str in dataPacketStrArray)
                    {
                        if (str != "")
                        {
                            dataPacketBytes.Add(Convert.ToByte(str, 16));
                        }
                    }
                }

                dataPacket.Decode(dataPacketBytes);

                if (dataPacket.isValid())
                {
                    string[] str = new string[6];
                    str[0] = "";
                    str[1] = "0x" + dataPacket.GetStarter1().ToString("X2");
                    str[2] = "0x" + dataPacket.GetStarter2().ToString("X2");
                    str[3] = "0x" + dataPacket.GetCommand().ToString("X2");

                    String payloadDataBytesStr = "";
                    foreach (Byte b in dataPacket.GetPayloadData())
                    {
                        payloadDataBytesStr += "0x" + b.ToString("X2") + " ";
                    }

                    str[4] = payloadDataBytesStr.Trim();
                    str[5] = "0x" + dataPacket.GetCrc8().ToString("X2");

                    ListViewItem item = new ListViewItem(str);
                    decodedDataPacketsListView.Items.Add(item);
                    decodedDataPacketsListView.Items[decodedDataPacketsListView.Items.Count - 1].EnsureVisible();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
