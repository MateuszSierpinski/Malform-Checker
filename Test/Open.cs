using Malform_Checker;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace Test
{
    public class Open:Form1

    {
        Loading L = new Loading();
        Loading L_c = new Loading();
        public string path { get; set; }
               
        public string OpenWindow()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }
            }
            return path;
        }

        public DataTable OpenFile(DataTable table, bool header, string path, string delimiter)

        {
            int j = 0;
            L.progressBar1.Minimum = 0;
            L.Label_show_inf.Text = "Converting your file to table";

            if (header)
                {
                try
                {
                    L.Show();
                    var fileContents = System.IO.File.ReadAllLines(path);
                    if (fileContents.Count() <= 120000)
                    {
                        var splitFileContents = (from f in fileContents select Regex.Split(f, ($"{delimiter}(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)"))).ToArray();
                        int maxLength = (from s in splitFileContents select s.Count()).Max();
                        for (int i = 0; i < maxLength; i++)
                        {
                            try
                            {
                                table.Columns.Add(splitFileContents[0][i].ToString());
                            }
                            catch
                            {
                                //MessageBox.Show($"You have some malformed records");
                            }
                        }
                        L.progressBar1.Maximum = splitFileContents.Count();
                        foreach (var line in splitFileContents)
                        {
                            if (!Cancel_click.clicked)
                            {
                                DataRow row = table.NewRow();
                                try
                                {
                                    L.progressBar1.Value = j++;
                                    Application.DoEvents();
                                    row.ItemArray = (object[])line;
                                    table.Rows.Add(row);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Exception");
                                }
                            }
                            else
                            {
                                Cancel_click.clicked = false;
                                table.Clear();
                                break;
                            }

                        }
                        table.Rows.Remove(table.Rows[0]);
                        L.Close();
                    }
                    else
                    {
                        L.Close();
                        MessageBox.Show("File is too big to open it in table\nBut you can still check if you have malformed records");
                    }
                }
                catch
                {
                    MessageBox.Show("Your file cannot be open it's too big, or is opened in another program");
                }
                }           
            else
            {
                try
                {
                L.Show();
                var fileContents = System.IO.File.ReadAllLines(path);
                    if (fileContents.Count() <= 120000)
                    {
                        var splitFileContents = (from f in fileContents select Regex.Split(f, ($"{delimiter}(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)"))).ToArray();
                        int maxLength = (from s in splitFileContents select s.Count()).Max();
                        for (int i = 0; i < maxLength; i++)
                        {
                            table.Columns.Add();
                        }

                        L.progressBar1.Maximum = splitFileContents.Count();
                        foreach (var line in splitFileContents)
                        {
                            if (!Cancel_click.clicked)
                            {
                                L.progressBar1.Value = j++;
                                Application.DoEvents();
                                DataRow row = table.NewRow();
                                row.ItemArray = (object[])line;
                                table.Rows.Add(row);
                            }
                            else
                            {
                                Cancel_click.clicked = false;
                                table.Clear();
                                break;
                            }
                        }
                        L.Close();
                    }
                    else
                    {
                        L.Close();
                        MessageBox.Show("File is too big to open it in table\nBut you can still check if you have malformed records");
                    }
                }
                catch
                {
                    MessageBox.Show("Your file cannot be open it's too big, or is opened in another program");
                }
            }
            return table;
        }

        public  void OpenFile_SEQ(string path, RichTextBox rich)
        {
            rich.Clear();
            int p = 0;
            var my_file = System.IO.File.ReadAllLines(path,Encoding.UTF8);
            L.Show();
            L.progressBar1.Minimum = p;
            L.progressBar1.Maximum = my_file.Count();
            L.Label_show_inf.Text = "Creating file preview";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < my_file.Count(); i++)
            {
                if (!Cancel_click.clicked)
                {
                    if (i <= 9998)
                    {
                        string count = i + 1 + ":\t\t";
                        sb.Append(count + my_file[i] + "\n");
                    }
                    if (i >= 9999)
                    {
                        string count = i + 1 + ":\t";
                        sb.Append(count + my_file[i] + "\n");
                    }

                    L.progressBar1.Value = p++;
                    Application.DoEvents();
                }
                else
                {                   
                    Cancel_click.clicked = false;
                    Application.DoEvents();
                    sb.Clear();
                    break;                   
                }
            }
            rich.Text = sb.ToString();
            L.Close();
        }
    }
}







