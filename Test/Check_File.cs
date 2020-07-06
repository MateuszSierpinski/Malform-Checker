using Malform_Checker;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class Check_File : Open
    {
        int count;
        int count2;
        public static bool clicked = false;
        private System.ComponentModel.BackgroundWorker BCK_WRK_SHOW_DEL;
        private System.ComponentModel.BackgroundWorker BCK_WRK_SHOW_SEQ;
        Malform_Checker.Loading L = new Malform_Checker.Loading();

        public void Check_DEL(String path, string delimiter, out List<int> malf1, out List<string> malf1_comu, bool header)
        {
            L.Show();
            List<int> malf = new List<int>();
            List<string> malf_comu = new List<string>();
            var fileContents = System.IO.File.ReadAllLines(path);
            int j = 0;
            L.progressBar1.Minimum = 0;
            L.progressBar1.Maximum = fileContents.Length;
            L.Label_show_inf.Text = "Your file is being checked";
            for (int i = 0; i < fileContents.Length; i++)
            {
                if (!Cancel_click.clicked)
                {
                    var pattern = @"""[^""]*""";
                    //var after = Regex.Replace(fileContents[0], pattern, match => match.Value.Replace(delimiter, ""));
                    //var after1 = Regex.Replace(fileContents[i], pattern, match => match.Value.Replace(delimiter, ""));
                    count = Regex.Matches(fileContents[0], delimiter).Count;
                    count2 = Regex.Matches(fileContents[i], delimiter).Count;
                    L.progressBar1.Value = j++;
                    Application.DoEvents();
                    if (header)
                    {
                        if (count < count2)
                        {
                            int m = i - 1;
                            malf.Add(m);
                            string m_c = $"You have more delimiters on record: {m + 1}";
                            malf_comu.Add(m_c);
                        }
                        if (count > count2)
                        {
                            int m = i - 1;
                            malf.Add(m);
                            string m_c = $"You have less delimiters or some EOL on record: {m + 1}";
                            malf_comu.Add(m_c);
                        }
                        if (Regex.Matches(fileContents[i], "\"").Count % 2 != 0)
                        {
                            int m = i - 1;
                            malf.Add(m);
                            string m_c = $"You have single double quote on record: {m + 1} ";
                            malf_comu.Add(m_c);
                        }
                    }
                    else
                    {
                        if (count < count2)
                        {
                            malf.Add(i);
                            string m_c = $"You have more delimiters on record: {i + 1}";
                            malf_comu.Add(m_c);
                        }
                        if (count > count2)
                        {
                            malf.Add(i);
                            string m_c = $"You have less delimiters or some EOL on record: {i + 1} ";
                            malf_comu.Add(m_c);
                        }
                        if (Regex.Matches(fileContents[i], "\"").Count % 2 != 0)
                        {
                            malf.Add(i);
                            string m_c = $"You have single double quote on record: {i + 1}";
                            malf_comu.Add(m_c);
                        }
                    }
                }
                else
                {
                    Cancel_click.clicked = false;
                    break;
                    
                }
            }
            L.Close();
            malf1 = malf;
            malf1_comu = malf_comu;
            if (!malf.Any() || !malf_comu.Any())
            {
                MessageBox.Show("Your file was scanned,\nit is OK!");
            }

        }
        public string CreateLOG(List<string> statement, string path, out string log_file)
        {
            FileStream log;
            string new_directory = null;
            string new_file = null;
            string filePath = System.IO.Path.GetFileNameWithoutExtension(path);
            if (!Directory.Exists("Logs"))
            {
                Directory.CreateDirectory("Logs");
            }
            if (statement.Any())
            {
                new_directory = "Logs" + "\\";
                new_file = $"List_of_malformed_{filePath}.txt";
                log = File.Create(new_directory + new_file);
                TextWriter writer = new StreamWriter(log);
                for (int i = 0; i < statement.Count; i++)
                {
                    Application.DoEvents();
                    writer.Write(statement[i]);
                    writer.Write("\n");
                }
                writer.Close();
            }
            return log_file = new_directory + new_file;
        }
        public string CreateLOG(List<string> statement, string path, out string log_file, bool header)
        {
            if (header)
            {
                FileStream log;
                string new_directory = null;
                string new_file = null;
                string filePath = System.IO.Path.GetFileNameWithoutExtension(path);
                if (!Directory.Exists("Logs"))
                {
                    Directory.CreateDirectory("Logs");
                }
                if (statement.Any())
                {
                    new_directory = "Logs" + "\\";
                    new_file = $"List_of_malformed_{filePath}.txt";
                    log = File.Create(new_directory + new_file);
                    TextWriter writer = new StreamWriter(log);
                    writer.Write("You have selected first row as header then:\n");
                    for (int i = 0; i < statement.Count; i++)
                    {
                        Application.DoEvents();
                        writer.Write(statement[i]);
                        writer.Write("\n");
                    }
                    writer.Close();
                }
                return log_file = new_directory + new_file;
            }
            else
            {
                FileStream log;
                string new_directory = null;
                string new_file = null;
                string filePath = System.IO.Path.GetFileNameWithoutExtension(path);
                if (!Directory.Exists("Logs"))
                {
                    Directory.CreateDirectory("Logs");
                }
                if (statement.Any())
                {
                    new_directory = "Logs" + "\\";
                    new_file = $"List_of_malformed_{filePath}.txt";
                    log = File.Create(new_directory + new_file);
                    TextWriter writer = new StreamWriter(log);
                    for (int i = 0; i < statement.Count; i++)
                    {
                        Application.DoEvents();
                        writer.Write(statement[i]);
                        writer.Write("\n");
                    }
                    writer.Close();
                }
                return log_file = new_directory + new_file;
            }
        }

        public void Check_SEQ(String path, int Rec_Len, out List<int> malf1, out List<string> malf1_comu, ProgressBar progressBar)
        {
            
            int count1 = 0;
            int count3 = 0;
            bool triger = true;
            List<int> malf = new List<int>();
            List<string> malf_comu = new List<string>();
            var fileContents = System.IO.File.ReadAllLines(path);
            int j = 0;
            progressBar.Minimum = 0;
            progressBar.Maximum = fileContents.Length;
            count1 = Regex.Matches(fileContents[0], ".").Count;

            if (Rec_Len != count1)
            {
                var db = MessageBox.Show($"Are you sure that your length is {Rec_Len}", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                for (int i = 0; i < fileContents.Length - 1; i++)
                {
                    count3 = Regex.Matches(fileContents[i], ".").Count;

                    if (!Cancel_click.clicked)
                    {
                        if (db == DialogResult.Yes)
                        {
                            if (count3 > Rec_Len)
                            {
                                malf.Add(i);
                                string m_c = $"You have too long record on line: {i + 1}";
                                malf_comu.Add(m_c);
                            }

                            if (count3 < Rec_Len)
                            {
                                malf.Add(i);
                                string m_c = $"You have too short record on line: {i + 1}";
                                malf_comu.Add(m_c);
                            }
                            progressBar.Value = j++;
                            Application.DoEvents();
                        }
                        if (db == DialogResult.No)
                        {
                            triger = false;
                            break;
                        }
                    }
                    else
                    {
                        Cancel_click.clicked = false;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < fileContents.Length - 1; i++)
                {

                    count3 = Regex.Matches(fileContents[i], ".").Count;
                    if (!Cancel_click.clicked)
                    {
                        if (Rec_Len == count1)
                        {

                            if (count3 > Rec_Len)
                            {
                                malf.Add(i);
                                string m_c = $"You have to long record on line: {i + 1}";
                                malf_comu.Add(m_c);
                            }

                            if (count3 < Rec_Len)
                            {
                                malf.Add(i);
                                string m_c = $"You have to short record on line: {i + 1}";
                                malf_comu.Add(m_c);
                            }
                            progressBar.Value = j++;
                            Application.DoEvents();
                        }
                    }
                    else
                        {
                        Cancel_click.clicked = false;
                        break;
                    }
                }
            }
            malf1 = malf;
            malf1_comu = malf_comu;
            if (!malf.Any() && triger)
            {
                MessageBox.Show("Your file was scanned,\nit is OK!");
            }
        }

        private void InitializeComponent()
        {
            this.BCK_WRK_SHOW_DEL = new System.ComponentModel.BackgroundWorker();
            this.BCK_WRK_SHOW_SEQ = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Check_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1068, 597);
            this.Name = "Check_File";
            this.ResumeLayout(false);

        }
    }
}
