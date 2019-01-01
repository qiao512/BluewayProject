
using Desay.DataManager;
using Desay.DataReader;
using Desay.WinService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;
            now = AssemblyMachineDataReader.RoundTime(now, 10);
            MessageBox.Show(now.ToString("yyyy-MM-dd HH:mm:ss"));
            return;

            Desay.WinService.MachineMonitor monitor = new Desay.WinService.MachineMonitor();
            monitor.CreateMonitors();
            /*
            string path22 = @"D:\项目\蓝微\FUJI FILES\NXT01\bak\2";
            string[] dddddd = Directory.GetDirectories(path22,"*",SearchOption.TopDirectoryOnly);
            StringBuilder sbb = new StringBuilder();
            foreach (string dd in dddddd)
                sbb.AppendLine(dd);
            MessageBox.Show(sbb.ToString());
            return;

            string path = @"D:\项目\蓝微\FUJI FILES\NXT01\bak\2\8095\BPRODUCT_2010.dbl";
            path = this.textBox1.Text;

            string fileName = System.IO.Path.GetFileNameWithoutExtension(path);
            fileName = fileName.ToUpper();

            string machineName = "NXT001";

            bool isForBack = this.ckIsForBack.Checked;

            if (fileName.StartsWith(FLEXSA_DATA_TYPE.BPRODUCT.ToString()))
            {
                BPRODUCTDataReader reader = new BPRODUCTDataReader(machineName, path);
                reader.IsForBak = isForBack;
                reader.LoadData();
                reader.SaveData();
            }
            else if (fileName.StartsWith(FLEXSA_DATA_TYPE.CYC_TIME.ToString()))
            {
                CYC_TIMEDataReader reader = new CYC_TIMEDataReader(machineName, path);
                reader.IsForBak = isForBack;
                reader.LoadData();
                reader.SaveData();
            }
            else if (fileName.StartsWith(FLEXSA_DATA_TYPE.FD_COUNT.ToString()))
            {
                FD_COUNTDataReader reader = new FD_COUNTDataReader(machineName, path);
                reader.IsForBak = isForBack;
                reader.LoadData();
                reader.SaveData();
            }
            else if (fileName.StartsWith(FLEXSA_DATA_TYPE.FD_ERROR.ToString()))
            {
                FD_ERRORDataReader reader = new FD_ERRORDataReader(machineName, path);
                reader.IsForBak = isForBack;
                reader.LoadData();
                reader.SaveData();
            }
            else if (fileName.StartsWith(FLEXSA_DATA_TYPE.FDRARR_L.ToString()))
            {
                if (isForBack)
                {
                    FDRARR_LDataReader reader = new FDRARR_LDataReader(machineName, path);
                    reader.IsForBak = isForBack;
                    reader.LoadData();
                    reader.SaveData();
                }
                else
                {
                    FDRARR_LRunningDataReader reader = new FDRARR_LRunningDataReader(machineName, path);
                    reader.IsForBak = isForBack;
                    reader.LoadData();
                    reader.SaveData();
                }
            }
            else if (fileName.StartsWith(FLEXSA_DATA_TYPE.MAC_UTIL.ToString()))
            {
                MAC_UTILDataReader reader = new MAC_UTILDataReader(machineName, path);
                reader.IsForBak = isForBack;
                reader.LoadData();
                reader.SaveData();
            }
            else if (fileName.StartsWith(FLEXSA_DATA_TYPE.MACERROR.ToString()))
            {
                MACERRORDataReader reader = new MACERRORDataReader(machineName, path);
                reader.IsForBak = isForBack;
                reader.LoadData();
                reader.SaveData();
            }
            else if (fileName.StartsWith(FLEXSA_DATA_TYPE.NZLERROR.ToString()))
            {
                NZLERRORDataReader reader = new NZLERRORDataReader(machineName, path);
                reader.IsForBak = isForBack;
                reader.LoadData();
                reader.SaveData();

            }
            else if (fileName.StartsWith(FLEXSA_DATA_TYPE.NZLPOS_L.ToString()))
            {
                NZLPOS_LDataReader reader = new NZLPOS_LDataReader(machineName, path);
                reader.IsForBak = isForBack;
                reader.LoadData();
                reader.SaveData();
            }
            else if (fileName.StartsWith(FLEXSA_DATA_TYPE.NZLUSAGE.ToString()))
            {
                NZLUSAGEDataReader reader = new NZLUSAGEDataReader(machineName, path);
                reader.IsForBak = isForBack;
                reader.LoadData();
                reader.SaveData();
            }
            else if (fileName.StartsWith(FLEXSA_DATA_TYPE.PD_ERRINF.ToString()))
            {
                PD_ERRINFDataReader reader = new PD_ERRINFDataReader(machineName, path);
                reader.IsForBak = isForBack;
                reader.LoadData();
                reader.SaveData();
            }
            else if (fileName.StartsWith(FLEXSA_DATA_TYPE.PD_ERROR.ToString()))
            {
                PD_ERRORDataReader reader = new PD_ERRORDataReader(machineName, path);
                reader.IsForBak = isForBack;
                reader.LoadData();
                reader.SaveData(); 
            }
            else if (fileName.StartsWith(FLEXSA_DATA_TYPE.PPRODUCT.ToString()))
            {
                PPRODUCTDataReader reader = new PPRODUCTDataReader(machineName, path);
                reader.IsForBak = isForBack;
                reader.LoadData();
                reader.SaveData();
            }
            else if (fileName.StartsWith(FLEXSA_DATA_TYPE.RECIPE_L.ToString()))
            {
                RECIPEDataReader reader = new RECIPEDataReader(machineName, path);
                reader.IsForBak = isForBack;
                reader.LoadData();
                reader.SaveData();
            }
            */
          
        }

        private void btSelectAFile_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog()==DialogResult.OK)
            {
                this.textBox1.Text = this.openFileDialog.FileName;
            }
        }

        private void btTestBlueWayITF_Click(object sender, EventArgs e)
        {
            //string ss = Desay.DataReader.ServerLoader.ItfDataService.GetAdsMesFeedInfo("SMT2018");
            //object oo = JsonConvert.DeserializeObject<ITF_FEEDER_JSON>(ss);
            //string dd = "";

            // Desay.WinService.InterfaceMonitor monitor = new Desay.WinService.InterfaceMonitor();
            // monitor.CreateMonitors();

            AOISPIInterface itf = new AOISPIInterface();
            string line_no = "SMT-26";
            itf.GetData(line_no);
        }

        private void buttonTestAssembly_Click(object sender, EventArgs e)
        {
            AssemblyMonitor mm = new AssemblyMonitor();
            mm.CreateMonitors();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "txt|*.txt";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                string ff = dlg.FileName;
                MessageBox.Show(ff);
            }
        }
    }
}
