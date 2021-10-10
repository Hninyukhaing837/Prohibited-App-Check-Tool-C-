using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prohibited_App_Check_Tool
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //端末名と実施日
            lblMachineName.Text = "MachineName:" + Environment.MachineName;
            lblTime.Text = "Time:" + DateTime.Now.ToString();
        }



        private void rdEng_CheckedChanged(object sender, EventArgs e)
        {
            //ラジオENを押す場合、言語は英語に変更する
            if (rdEng.Checked == true)
            {
                lblMachineName.Text = "MachineName:" + Environment.MachineName;
                lblTime.Text = "Time:" + DateTime.Now.ToString();
                lblApp.Text = "Prohibited App:";
                lblOutput.Text = "Output Destination:";
                btnInputFileSelect.Text = "Select";
                btnOutputSelect.Text = "Select";
                rdPartial.Text = "Partial Match       (xxxappnamexxx)";
                rdBeginning.Text = "Beginning Match (appnamexxx)";
                rdPerfect.Text = "Perfect Match     (appname)";
                btnStart.Text = "Start";
            }
        }

        private void rdJp_CheckedChanged(object sender, EventArgs e)
        {
            //ラジオJPを押す場合、言語は日本語に変更する
            if (rdJp.Checked == true)
            {
                lblMachineName.Text = "端末目:" + Environment.MachineName;
                lblTime.Text = "実施日:" + DateTime.Now.ToString();
                lblApp.Text = "使用禁止アプリ:";
                lblOutput.Text = "出力先:";
                btnInputFileSelect.Text = "参照";
                btnOutputSelect.Text = "参照";
                rdPartial.Text = "部分一致      (xxxappnamexxx)";
                rdBeginning.Text = "先頭一致     (appnamexxx)";
                rdPerfect.Text = "完全一致     (appname)";
                btnStart.Text = "スタート";
            }
        }

        private void txtApp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInputFileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtApp.Text = fileDialog.FileName;
            }
            else
            {
                MessageBox.Show("Please choose prohibited app input file!");
            }
        }

        private void btnOutputSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtOutput.Text = folderDlg.SelectedPath;
            }
            else
            {
                MessageBox.Show("Please choose output destination!");
            }
        }

        private void rdPartial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdBeginning_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdPerfect_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //パソコンの中のドライブ全部を取得
            String[] strDirectoryArr = new string[24];
            Int32 intarrIndex;
            Int32 intIndex;
            intarrIndex = 0;
            String[] strExeFileArr = new string[500];
            String[] TempArr = new string[500];
            int intfileIndex;
            intfileIndex = 0;
            bool blnHasFolder = false;
            String[] strInputfileArr = new string[300];

            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {
                if (Directory.Exists(drive.Name))
                {
                    strDirectoryArr[intarrIndex] = drive.Name;
                    intarrIndex = intarrIndex + 1;
                }
                else
                {
                    //Nothing
                }
            }

            //ドライブの中のファイルを取得            
            for (intIndex = 0; intIndex < strDirectoryArr.Length; intIndex++)
            {
                if (strDirectoryArr[intIndex] != null)
                {
                    String strPath = @"d:\Drives";
                    //String strPath = strDirectoryArr[intIndex];
                    //MessageBox.Show(strDirectoryArr[intIndex]);
                    //ReadSoftware(@strDirectoryArr[intIndex]);
                    //Get file
                    string[] fileEntries = Directory.GetFiles(strPath);
                    foreach (string fileName in fileEntries)
                    {
                        string filepath = Path.GetFileName(fileName);
                        string strExtension = Path.GetExtension(filepath);
                        if (strExtension == ".exe")
                        {
                            strExeFileArr[intfileIndex] = filepath;
                            //MessageBox.Show(strExeFileArr[intfileIndex]);
                            intfileIndex = intfileIndex + 1;
                        }
                    }
                    //MessageBox.Show(string.Join(",", strExeFileArr));

                    //GetFolder                    
                    string[] subdirectoryEntries = Directory.GetDirectories(strPath);
                    if (subdirectoryEntries.Length != 0)
                    {
                        blnHasFolder = true;
                    }
                    else
                    {
                        blnHasFolder = false;
                    }

                    while (blnHasFolder == true)
                    {
                        foreach (string subdirectory in subdirectoryEntries)
                        {
                            if (subdirectory != null)
                            {
                                //GetFile in subfolder
                                try
                                {
                                    string[] file = Directory.GetFiles(subdirectory);
                                    foreach (string fileName in file)
                                    {
                                        string filepath = Path.GetFileName(fileName);
                                        string strExtension = Path.GetExtension(filepath);
                                        if (strExtension == ".exe")
                                        {
                                            strExeFileArr[intfileIndex] = filepath;
                                            //strPath[intfileIndex] = subdirectory +"\\"+ filepath;
                                            //MessageBox.Show(strExeFileArr[intfileIndex]);
                                            intfileIndex = intfileIndex + 1;
                                            //blnHasFolder = true;
                                        }

                                    }//foreach filename
                                }//try
                                catch
                                {
                                    //error message
                                }//catch
                            }
                            else
                            {
                                //If null,do Nothing
                            }

                        }//foreach subdirectory
                        //MessageBox.Show(string.Join(",", strExeFileArr));

                        //Find subfolder from subfolder
                        int folderindex = 0;
                        foreach (string subdirectory in subdirectoryEntries)
                        {
                            if (subdirectory != null)
                            {
                                try
                                {
                                    string[] subfolderArr = Directory.GetDirectories(subdirectory);
                                    blnHasFolder = true;
                                    foreach (string subfolder in subfolderArr)
                                    {
                                        TempArr[folderindex] = subfolder;
                                        folderindex = folderindex + 1;
                                    }
                                }
                                catch
                                {
                                    //errorMessage
                                }
                            }
                            else
                            {
                                //If null,do Nothing
                            }
                        }//foreach subdirectory
                        //MessageBox.Show(string.Join(",", strExeFileArr));

                        if (folderindex == 0)
                        {
                            blnHasFolder = false;
                        }
                        else
                        {
                            blnHasFolder = true;
                            int TempArrLength = TempArr.Length;
                            //Array.Clear(subdirectoryEntries, 0, subdirectoryEntries.Length);
                            subdirectoryEntries = new string[500];
                            //subdirectoryEntries = (string[])TempArr.Clone();
                            //TempArr.CopyTo(subdirectoryEntries, TempArrLength);
                            Array.Clear(subdirectoryEntries, 0, 500);
                            //MessageBox.Show(string.Join(",", subdirectoryEntries));
                            Array.Copy(TempArr, subdirectoryEntries, TempArrLength);
                            //MessageBox.Show(string.Join(",", subdirectoryEntries));
                        }
                    }//while
                    MessageBox.Show(string.Join(",", strExeFileArr));
                    //MessageBox.Show("Hello");
                }
                else
                {
                    //Nothing
                }
            }
            //MessageBox.Show(string.Join(",", strExeFileArr));

            //Read Input file
            ReadInputFile(strInputfileArr);
            if (rdPartial.Checked == true)
            {
                PartialMatch(strExeFileArr, strInputfileArr);
            }
            else if (rdBeginning.Checked == true)
            {
                BeginningMatch(strExeFileArr, strInputfileArr);
            }
            else if (rdPerfect.Checked == true)
            {
                PerfectMatch(strExeFileArr, strInputfileArr);
            }
            else
            {
                //Nothing
            }
        }

        public void ReadInputFile(String[] strLineArr)
        {
            MessageBox.Show("start");
            string strInputFilePath;
            string line;
            //String[] strLineArr = new string[500];
            int lineIndex = 0;
            //Get the Input file path
            strInputFilePath = txtApp.Text;
            System.IO.StreamReader file = new System.IO.StreamReader(@strInputFilePath);
            while ((line = file.ReadLine()) != null)
            {
                strLineArr[lineIndex] = line;
                lineIndex = lineIndex + 1;
            }
            file.Close();
        }

        //分部一致
        public void PartialMatch(String[] strExeFileArr, String[] strInputfileArr)
        {
            foreach (string strInputName in strInputfileArr)
            {
                strInputName.Replace(" ", "_");
                strInputName.Replace("-", "_");
                string strDotPosition = strInputName.Replace(".", string.Empty);

                if (strDotPosition != null)
                {
                    int intDotPosition = Int32.Parse(strDotPosition);
                    strInputName.Substring(0, intDotPosition - 1);
                    strInputName.ToLower();
                }
            }
            for (int softwareName = 0; softwareName <= strExeFileArr.Length; softwareName++)
            {
                string strSoftwareName = softwareName.ToString();
                strSoftwareName.Replace(" ", "_");
                strSoftwareName.Replace("-", "_");
                string strDotPosition = strSoftwareName.Replace(".", string.Empty);
                if (strDotPosition != null)
                {
                    int intDotPosition = Int32.Parse(strDotPosition);
                    strSoftwareName.Substring(0, intDotPosition - 1);
                    strSoftwareName.ToLower();
                }
            }
        }

        //先頭一致
        public void BeginningMatch(String[] strExeFileArr, String[] strInputfileArr)
        {

        }

        //完全一致
        public void PerfectMatch(String[] strExeFileArr, String[] strInputfileArr)
        {

        }
        public int intfileIndex = 0;
        /*public static void ReadSoftware(string workingDirectory)
        {
            String[] strExeFileArr = new string[500];
            int intfileIndex;
            
            try
            {
                foreach (string d in Directory.GetDirectories(workingDirectory))
                {
                    ReadSoftware(d);
                }

                foreach (string f in Directory.GetFiles(workingDirectory))
                {
                    string filepath = Path.GetFileName(f);
                    string strExtension = Path.GetExtension(filepath);
                    if (strExtension == ".exe")
                    {
                        strExeFileArr[intfileIndex] = filepath;
                        intfileIndex = intfileIndex + 1;
                    }
                }

            }
            catch (System.Exception)
            {
                //MessageBox.Show(ex.Message);  
            }
            MessageBox.Show("Finish");
        }
        */

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    [Serializable]
    internal class AnotherTypeOfException : Exception
    {
        public AnotherTypeOfException()
        {
        }

        public AnotherTypeOfException(string message) : base(message)
        {
        }

        public AnotherTypeOfException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AnotherTypeOfException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
