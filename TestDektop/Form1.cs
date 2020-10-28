using Microsoft.Office.Interop.Excel;
using Microsoft.Win32;
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

namespace XLSXtoPDF
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Çevrilecek Klasör Seçin";

            DialogResult openFileDialog1Result = 0;
            DialogResult folderBrowserDialog1Result = 0;

            if (snglCB.Checked)
            {
                openFileDialog1Result = openFileDialog1.ShowDialog();
                fldrTB.Text = openFileDialog1.FileName;

                if (openFileDialog1Result == DialogResult.OK || openFileDialog1Result == DialogResult.Yes)
                {

                }
            }
            else
            {
                folderBrowserDialog1Result = folderBrowserDialog1.ShowDialog();
            }

            if (Helper.isRoot(folderBrowserDialog1))
            {
                DialogResult msgBox = MessageBox.Show(folderBrowserDialog1.SelectedPath, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (folderBrowserDialog1Result == DialogResult.OK || folderBrowserDialog1Result == DialogResult.Yes)
                {

                    var root = folderBrowserDialog1.SelectedPath;

                    fldrTB.Text = folderBrowserDialog1.SelectedPath;

                    DirectoryInfo d = new DirectoryInfo(root);

                    var totalFiles = 0;
                    var totalXLSX = 0;
                    var totalSubdirectory = 0;

                    foreach (var sub in d.GetDirectories("*", SearchOption.AllDirectories))
                    {
                        Directory.SetCurrentDirectory(sub.FullName);

                        totalSubdirectory++;

                        foreach (var file in sub.GetFiles())
                        {

                            totalFiles++;

                            if (file.Extension == ".xlsx" || file.Extension == ".xls")
                            {
                                totalXLSX++;
                            }
                        }
                    }
                    consoleTB.Text = "";
                    consoleTB.AppendText("Toplam Alt Klasör: " + totalSubdirectory + " adet" + Environment.NewLine);
                    consoleTB.AppendText("Toplam Dosya: " + totalFiles + " adet" + Environment.NewLine);
                    consoleTB.AppendText("Toplam Excel Dosyası: " + totalXLSX + " adet" + Environment.NewLine);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (snglCB.Checked)
            {
                var root = openFileDialog1.FileName;

                try
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();

                    app.Visible = false;

                    int fileCount = 0;

                    Workbook wkb = app.Workbooks.Open(root);

                    wkb.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, root.Replace(".xlsx", ""));

                    object misValue = System.Reflection.Missing.Value;

                    wkb.Close(false, misValue, misValue);

                    consoleTB.Text += root + " pdf'e çevrildi" + Environment.NewLine;

                    fileCount++;
                    statusLbl.Text = "";
                    statusLbl.Text = fileCount + " adet dosya çevrildi.";

                    app.Quit();

                }
                catch (Exception ex)
                {

                    consoleTB.Text += ex.Message;

                }
                finally
                {
                    progressBar.Value = 100;
                }
            }
            else
            {

                consoleTB.Text = "";

                if (String.IsNullOrEmpty(folderBrowserDialog1.SelectedPath) && String.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    DialogResult msgBox = MessageBox.Show("Lütfen bir klasör seçin", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    var root = folderBrowserDialog1.SelectedPath;

                    DirectoryInfo d = new DirectoryInfo(root);


                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();

                    app.Visible = false;

                    var fileCount = 0;

                    var maxFiles = 0;

                    foreach (var sub in d.GetDirectories("*", SearchOption.AllDirectories))
                    {
                        Directory.SetCurrentDirectory(sub.FullName);

                        foreach (var file in sub.GetFiles())
                        {
                            if (file.Extension == ".xlsx" || file.Extension == ".xls")
                            {
                                maxFiles++;
                            }
                        }
                    }

                    progressBar.Maximum = maxFiles;

                    foreach (var sub in d.GetDirectories())
                    {
                        Directory.SetCurrentDirectory(root + "\\" + sub);


                        foreach (var file in sub.GetFiles())
                        {

                            if (file.Extension == ".xlsx" || file.Extension == ".xls")
                            {

                                try
                                {


                                    Workbook wkb = app.Workbooks.Open(file.FullName);

                                    wkb.ExportAsFixedFormat(XlFixedFormatType.xlTypePDF, file.FullName.Replace(".xlsx", ""));

                                    object misValue = System.Reflection.Missing.Value;

                                    wkb.Close(false, misValue, misValue);

                                    consoleTB.Text += file.ToString() + " pdf'e çevrildi" + Environment.NewLine;

                                    fileCount++;
                                    statusLbl.Text = "";
                                    statusLbl.Text = fileCount + " adet dosya çevrildi.";

                                }
                                catch (Exception ex)
                                {

                                    consoleTB.Text += ex.Message;

                                }
                                finally
                                {
                                    progressBar.Value++;
                                }

                                consoleTB.SelectionStart = consoleTB.TextLength;
                                consoleTB.ScrollToCaret();

                            }




                        }
                    }

                    app.Quit();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\Winword.exe");
            if (key != null)
            {
                mOfficeInstallation.ForeColor = System.Drawing.Color.Green;
                mOfficeInstallation.Text = "Microsoft Office yüklü";
            }
            else
            {

                DialogResult msgBox = MessageBox.Show("Uygulamanın çalışması için Microsoft Office zorunludur. Lütfen bu uygulamayı kullanmak için Microsoft Office yükleyin.\r\n\r\nOK'a bastığınızda uygulama kapanacaktır.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (msgBox == DialogResult.OK)
                {
                    System.Windows.Forms.Application.Exit();
                }

            }
        }

        private void snglCB_CheckedChanged(object sender, EventArgs e)
        {
            if (snglCB.Checked)
            {
                fldrBtn.Text = "Dosya Seç";
                consoleTB.Text = "";
            }
            else
            {
                fldrBtn.Text = "Klasör Seç";
            }
        }
    }
}
