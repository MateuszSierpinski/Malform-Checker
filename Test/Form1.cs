using Malform_Checker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;


namespace Test
{
    public partial class Form1 : Form
    {
        #region VARIABLES
        bool header;
        string path_DEL;
        string path_SEQ;
        string log_path;
        string delimiter;
        List<int> malf1;
        List<string> malf1_comu;
        List<int> malf2 = new List<int>();
        List<string> malf2_comu = new List<string>();
        DataTable table = new DataTable();
        int X_MOUSE = 0;
        int Y_MOUSE = 0;
        About a = null;
        int _Counter_DEL = 0;
        int _Counter_SEQ = 0;

        #endregion

        #region FUNCTIONS DEL
        public void loadTable(DataTable table)
        {
            if (table.Rows.Count < 1200000 && table.Rows.Count > 0)
            {
                DataView dataView = new DataView(table);
                this.dataGridView1.DataSource = dataView;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    Application.DoEvents();
                }
            }
            else
            {
                this.Width = 400;
                this.Height = 600;
                dataGridView1.Visible = false;
            }
        }
        public void Open_File_DEL()
        {
            Open open = new Open();
            var selected_path = textBox1.Text;
            path_DEL = open.OpenWindow();
            textBox1.Text = path_DEL;
            Btn_CnvToTbl.Enabled = true;
            if (path_DEL != null)
            {
                Show_Buttons_Open_DEL();

            }
            else
            {
                path_DEL = selected_path;
                textBox1.Text = path_DEL;
            }
        }
        public void Show_Buttons_Open_DEL()
        {
            this.Width = 1100;
            this.Height = 650;
            Btn_Open_Log_DEL.Visible = false;
            Btn_Open_Log_DEL.Enabled = false;
            dataGridView1.Visible = true;
            Btn_CnvToTbl.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            Btn_Check_Malf_DEL.Enabled = true;
            Btn_Check_Malf_DEL.Visible = true;
            Btn_Open_File_DEL.Visible = true;
            Btn_Open_File_DEL.Enabled = true;
        }
        public void Show_Buttons_Check_DEL()
        {
            if (dataGridView1.Visible == true && dataGridView1.Rows.Count != 0 && dataGridView1.Rows != null)
            {
                label3.Visible = true;
                textBox2.Visible = true;
                textBox2.Enabled = true;
            }
            Btn_Check_Malf_DEL.Enabled = true;
            Btn_Skip_Malf_DEL.Enabled = false;
            Btn_Open_Log_DEL.Enabled = false;
        }
        public void Show_Buttons_Malf_DEL()
        {
            if (dataGridView1.Visible == true && dataGridView1.Rows.Count != 0 && dataGridView1.Rows != null)
            {
                Btn_Skip_Malf_DEL.Visible = true;
                Btn_Skip_Malf_DEL.Enabled = true;
            }
            Btn_Open_Log_DEL.Visible = true;
            Btn_Open_Log_DEL.Enabled = true;
        }
        public void RowShower(DataGridView input)
        {
            if (dataGridView1.Rows.Count < 1200000)
            {
                Loading L = new Loading();
                L.progressBar1.Minimum = 0;
                L.progressBar1.Maximum = dataGridView1.Rows.Count;
                int j = 0;
                L.Show();
                L.Label_show_inf.Text = "Adding number of rows to your table";
                for (Int64 i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    L.progressBar1.Value = j++;
                    Application.DoEvents();
                    dataGridView1.RowHeadersWidth = 70;
                    dataGridView1.Rows[Convert.ToInt32(i)].HeaderCell.Value = (i + 1).ToString();
                    if (Cancel_click.clicked)
                    {
                        Btn_CnvToTbl.Enabled = true;
                        Cancel_click.clicked = false;
                        break;
                    }
                }
                L.Close();
            }
        }
        public void Clearing()
        {
            table.Clear();
            table.Columns.Clear();
        }
        public void Nonsort()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public string Delimited_Char()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    delimiter = " ";
                    break;
                case 1:
                    delimiter = "\t";
                    break;
                case 2:
                    delimiter = ",";
                    break;
                case 3:
                    delimiter = ".";
                    break;
                case 4:
                    delimiter = ";";
                    break;
                case 5:
                    delimiter = "\\|";
                    break;
                case 6:
                    delimiter = "\"";
                    break;
                case 7:
                    delimiter = "~";
                    break;
                default:
                    delimiter = "\t";
                    break;
            }
            return delimiter;
        }
        public bool Header_set()
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    header = false;
                    break;

                case 1:
                    header = true;
                    break;

                default:
                    header = false;
                    break;

            }
            return header;
        }
        public void malform_shower_DEL()
        {
            var boldStyle = new Font("Curier New", 9.75F, System.Drawing.FontStyle.Bold);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int j = 0; j < malf1.Count(); j++)
                {
                    if (row.Index == malf1[j])
                    {
                        row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ff4d4d");
                        row.DefaultCellStyle.Font = boldStyle;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }

            for (int i = 0; i < malf1.Count(); i++)
            {
                if (malf1.Count <= 3)
                {
                    MessageBox.Show(malf1_comu[i]);
                }
            }

            if (malf1.Count > 3) MessageBox.Show("Please check list of malformed records.\nYou have more then 3 ");

            if (malf1.Count >= 1)
            {
                Show_Buttons_Malf_DEL();
            }
        }
        #endregion

        #region FUNCTIONS SEQ     
        public enum ScrollBarType : int
        {
            SbHorz = 0,
            SbVert = 1,
            SbCtl = 2,
            SbBoth = 3
        }
        public enum Message : uint
        {
            WM_VSCROLL = 0x0115,
            WM_HSCROLL = 0x0114,
            WM_MOUSEWHEEL = 0x020A,
            EM_SETZOOM = 0x04E1,
            WM_USER = 0x0400,

        }
        public enum RICHEDITMSG : uint
        {
            EM_GETSCROLLPOS = Message.WM_USER + 221,
            EM_SETSCROLLPOS = Message.WM_USER + 222
        }
        public enum ScrollBarCommands : uint
        {
            SB_THUMBPOSITION = 4
        }

        [DllImport("User32.dll")]
        public extern static int GetScrollPos(IntPtr hWnd, int nBar);
        [DllImport("User32.dll")]
        public extern static int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        public void Line_painter(MouseEventArgs e)
        {
            X_MOUSE = e.X;
            Y_MOUSE = e.Y;
            var myPen = new Pen(Color.LightSeaGreen, 2);
            var formGraphics = richTextBox1.CreateGraphics();
            formGraphics.DrawLine(myPen, X_MOUSE, 0, X_MOUSE, MousePosition.Y);
            formGraphics.Dispose();
            myPen.Dispose();
        }
        public void malform_shower_SEQ()
        {
            Loading L = new Loading();
            L.Show();
            L.progressBar1.Minimum = 0;
            L.progressBar1.Maximum = malf2.Count();
            L.Label_show_inf.Text = "Marking malformed records in your view";
            richTextBox1.BackColor = Color.White;

            for (int j = 0; j < malf2.Count(); j++)
            {
                if (!Cancel_click.clicked)
                {
                    Application.DoEvents();
                    HighlightLine(richTextBox1, malf2[j], ColorTranslator.FromHtml("#ff4d4d"));
                    L.progressBar1.Value = j;
                }
                else
                {
                    Cancel_click.clicked = false;
                    break;
                }
            }
            L.Close();


            for (int i = 0; i < malf2.Count(); i++)
            {
                if (malf2.Count <= 3)
                {
                    MessageBox.Show(malf2_comu[i]);
                }
            }

            if (malf2.Count > 3) MessageBox.Show("Please check list of malformed records.\nYou have more then 3 ");

            if (malf2.Count >= 1)
            {
                Show_Buttons_Malf_SEQ();
            }


        }
        public void Show_Buttons_Malf_SEQ()
        {
            if (richTextBox1.Text != String.Empty)
            {
                //Btn_Show_Malf_SEQ.Visible = true;
                //Btn_Show_Malf_SEQ.Enabled = true;
                Btn_Skip_Malf_SEQ.Visible = true;
                Btn_Skip_Malf_SEQ.Enabled = true;
            }
            Btn_Open_Log_SEQ.Visible = true;
            Btn_Open_Log_SEQ.Enabled = true;
        }
        public void Show_Buttons_Check_SEQ()
        {
            label5.Visible = true;
            Txt_Row_SEQ.Visible = true;
            Txt_Row_SEQ.Enabled = true;
            Btn_Check_Malf_SEQ.Enabled = true;
            //Btn_Show_Malf_SEQ.Enabled = false;
            Btn_Skip_Malf_SEQ.Enabled = false;
            Btn_Open_Log_SEQ.Enabled = false;
            BTN_Generate_Ruler.Enabled = true;
            BTN_Generate_Ruler.Visible = true;
        }
        public void Show_Buttons_Open_SEQ()
        {
            this.Width = 1100;
            this.Height = 650;
            Btn_Open_Log_SEQ.Visible = false;
            Btn_Open_Log_SEQ.Enabled = false;
            label4.Visible = true;
            txtLineLong.Visible = true;
            Btn_CnvToTxt.Visible = true;
            Btn_Check_Malf_SEQ.Enabled = true;
            Btn_Check_Malf_SEQ.Visible = true;
            Btn_Open_File_SEQ.Visible = true;
            Btn_Open_File_SEQ.Enabled = true;
        }
        public void Open_File_SEQ()
        {
            Open open = new Open();
            var selected_path = txtPathLine.Text;
            path_SEQ = open.OpenWindow();
            txtPathLine.Text = path_SEQ;
            richTextBox1.Visible = true;
            RTB_Count_Char.Visible = true;

            if (path_SEQ != null)
            {
                Show_Buttons_Open_SEQ();
                Btn_Check_Malf_SEQ.Visible = true;
                Btn_Check_Malf_SEQ.Enabled = true;
                var my_file = File.ReadAllLines(path_SEQ);
                var pierwszy = my_file.ElementAt(0).Count();
                txtLineLong.Text = pierwszy.ToString();
                Btn_CnvToTxt.Enabled = true;
            }
            else
            {
                path_SEQ = selected_path;
                txtPathLine.Text = path_SEQ;
            }
        }
        public void HighlightLine(RichTextBox richTextBox, int index, Color color)
        {
            var lines = richTextBox.Lines;
            if (index < 0 || index >= lines.Length) return;
            var start = richTextBox.GetFirstCharIndexFromLine(index);
            var length = lines[index].Length;
            richTextBox.Select(start, length);
            richTextBox.SelectionBackColor = color;
            richTextBox.SelectionColor = Color.White;
        }
        public void Load_Txt()
        {
            Loading L = new Loading();
            richTextBox1.Clear();
            int i = 1;
            int p = 0;
            var my_file = File.ReadAllLines(path_SEQ);

            if (my_file.Count() < 507000)
            {
                L.Show();
                L.progressBar1.Minimum = p;
                L.progressBar1.Visible = true;
                L.progressBar1.Maximum = my_file.Count();
                foreach (string line in my_file)
                {
                    if (i < 1000)
                    {
                        string count = i++ + ": \t\t";
                        richTextBox1.AppendText(count + line + "\n");
                    }
                    if (i >= 1000)
                    {
                        string count = i++ + ": \t";
                        richTextBox1.AppendText(count + line + "\n");
                    }

                    L.progressBar1.Value = p++;
                }
                L.Close();
            }

            else
            {
                Invoke(new Action(() => this.Width = 400));
                Invoke(new Action(() => this.Height = 600));
                richTextBox1.Visible = false;
                RTB_Count_Char.Visible = false;
                BTN_Generate_Ruler.Visible = false;
                MessageBox.Show("File is too big to open it in txt editor\nBut you can still check if you have malformed records ");
            }

        }
        public void Create_Ruler()
        {
            if (!RTB_Count_Char.Text.Any())

            {
                int z = -10;
                RTB_Count_Char.AppendText(" \t\t");
                for (int i = 0; i < 600; i++)
                {
                    if (z < 99) RTB_Count_Char.AppendText($"    {z += 10}    ");
                    if (z == 100) RTB_Count_Char.AppendText($"  {z += 10}    ");
                    if (z > 100 && z < 1000) RTB_Count_Char.AppendText($"    {z += 10}   ");
                    if (z == 1000) RTB_Count_Char.AppendText($"  {z += 10}   ");
                    if (z > 1000) RTB_Count_Char.AppendText($"   {z += 10}   ");
                }
                RTB_Count_Char.AppendText("\n");
                RTB_Count_Char.AppendText(" \t\t");
                for (int i = 0; i < 604; i++)
                {
                    for (int j = 1; j <= 9; j++)
                    {
                        RTB_Count_Char.AppendText($"{j}");
                    }
                    RTB_Count_Char.AppendText("|");
                }
            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        #region EVENTS_DEL

        private void Btn_Check_Malf_DEL_Click(object sender, EventArgs e)
        {
            if (!BCK_WRK_CHCK_DEL.IsBusy)
            {
                BCK_WRK_CHCK_DEL.RunWorkerAsync();
                Btn_CnvToTbl.Enabled = false;
                //Btn_Check_Malf_DEL.Enabled = false;
            }

            Btn_Check_Malf_DEL.Enabled = false;

        }
        private void Btn_Open_Delimited_Click(object sender, EventArgs e)
        {
            Open_File_DEL();
        }
        private void Btn_CnvToTbl_Click(object sender, EventArgs e)
        {
            if (!BCK_WRK_CNV_DEL.IsBusy)
            {
                BCK_WRK_CNV_DEL.RunWorkerAsync();
                Btn_Check_Malf_DEL.Enabled = false;
              
            }

            _Counter_DEL = 0;
        }
        private void Btn_Skip_Malf_DEL_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[malf1[_Counter_DEL]].Cells[0];
            _Counter_DEL++;
            if (_Counter_DEL == malf1.Count()) _Counter_DEL = 0;
        }
        private void Btn_Open_File_DEL_Click(object sender, EventArgs e)
        {
            Process.Start(path_DEL);
        }
        private void Btn_Open_Log_DEL_Click(object sender, EventArgs e)
        {
            Process.Start(log_path);
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var index = Convert.ToInt32(textBox2.Text);
                    dataGridView1.CurrentCell = dataGridView1.Rows[index - 1].Cells[0];
                }
            }
            catch
            {
                MessageBox.Show("This row not exist");
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    path_DEL = textBox1.Text;

                    if (path_DEL != null && path_DEL != "File Path")
                    {
                        Show_Buttons_Open_DEL();
                        if (path_DEL.Contains("/data/files/"))
                        {
                            path_DEL = (path_DEL.Replace("/data/files/", @"\\waifs2\pitneyfiles\")).Replace("/", @"\");
                        }
                    }
                }
            }
            catch
            {

            }
        }
        private void BCK_WRK_CNV_DEL_DoWork(object sender, DoWorkEventArgs e)
        {
            Loading L = new Loading();
            Open open = new Open();
            Invoke(new Action(() => Clearing()));
            Invoke(new Action(() => this.Hide()));
            Invoke(new Action(() => open.OpenFile(table, Header_set(), path_DEL, Delimited_Char())));
            Invoke(new Action(() => loadTable(table)));
            Invoke(new Action(() => RowShower(dataGridView1)));
            Invoke(new Action(() => this.Show()));
            Invoke(new Action(() => Nonsort()));
            Invoke(new Action(() => Show_Buttons_Check_DEL()));
        }
        private void BCK_WRK_CHCK_DEL_DoWork(object sender, DoWorkEventArgs e)
        {
            Check_File ch = new Check_File();
            Invoke(new Action(() => ch.Check_DEL(path_DEL, Delimited_Char(), out malf1, out malf1_comu, Header_set())));
            Invoke(new Action(() => ch.CreateLOG(malf1_comu, path_DEL, out log_path, Header_set())));
            Invoke(new Action(() => malform_shower_DEL()));
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_Check_Malf_DEL.Enabled = true;
            Btn_CnvToTbl.Enabled = true;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_Check_Malf_DEL.Enabled = true;
            Btn_CnvToTbl.Enabled = true;
        }
        #endregion

        #region EVENTS_SEQ
        public void Btn_Check_Malf_SEQ_Click(object sender, EventArgs e)
        {
            if (!BCK_WRK_CHCK_TXT.IsBusy)
            {
                BCK_WRK_CHCK_TXT.RunWorkerAsync();
                Btn_Check_Malf_SEQ.Enabled = false;
                Btn_CnvToTxt.Enabled = false;
            }
            Btn_Check_Malf_SEQ.Enabled = false;
        }
        private void Btn_Open_Line_Click(object sender, EventArgs e)
        {
            Open_File_SEQ();
        }
        private void Btn_CnvToTxt_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
            richTextBox1.WordWrap = false;
            if (!BCK_WRK_CNV_TXT.IsBusy)
            {
                BCK_WRK_CNV_TXT.RunWorkerAsync();
                Btn_Check_Malf_SEQ.Enabled = false;
                Btn_CnvToTxt.Enabled = false;
            }
            Show_Buttons_Check_SEQ();
        }
        private void Btn_Skip_Malf_SEQ_Click(object sender, EventArgs e)
        {
            int index = richTextBox1.GetFirstCharIndexFromLine(malf2[_Counter_SEQ]);
            richTextBox1.Select(index, 0);
            richTextBox1.ScrollToCaret();
            _Counter_SEQ++;
            if (_Counter_SEQ == malf2.Count()) _Counter_SEQ = 0;
        }
        private void Btn_Open_File_SEQ_Click(object sender, EventArgs e)
        {
            Process.Start(path_SEQ);
        }
        private void Btn_Open_Log_SEQ_Click(object sender, EventArgs e)
        {
            Process.Start(log_path);
        }
        private void Txt_Row_SEQ_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!Int32.TryParse(Txt_Row_SEQ.Text, out int line))
                    {
                        MessageBox.Show("Please enter number");
                    }
                    else
                    {
                        richTextBox1.DeselectAll();
                        int index = richTextBox1.GetFirstCharIndexFromLine(line - 1);
                        richTextBox1.Select(index, 0);
                        richTextBox1.ScrollToCaret();
                        RTB_Count_Char.DeselectAll();
                    }
                }
            }
            catch
            {
                MessageBox.Show("This row not exist");
            }

        }
        private void richTextBox1_VScroll(object sender, EventArgs e)
        {
            if (X_MOUSE != 0 && Y_MOUSE != 0)
            {
                var myPen = new Pen(Color.LightSeaGreen, 2);
                var formGraphics = richTextBox1.CreateGraphics();
                formGraphics.DrawLine(myPen, X_MOUSE, 0, X_MOUSE, richTextBox1.Height);
                formGraphics.Dispose();
                myPen.Dispose();
            }

        }
        private void richTextBox1_HScroll(object sender, EventArgs e)
        {
            int nPos = GetScrollPos(richTextBox1.Handle, (int)ScrollBarType.SbHorz);
            nPos <<= 16;
            int wParam = (int)ScrollBarCommands.SB_THUMBPOSITION | (int)nPos;
            SendMessage(RTB_Count_Char.Handle, (int)Message.WM_HSCROLL, wParam, 0);
        }
        private void richTextBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Line_painter(e);
        }
        private void txtPathLine_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    path_SEQ = txtPathLine.Text;

                    if (path_SEQ != null && path_SEQ != "File Path")
                    {
                        Show_Buttons_Open_SEQ();
                        if (path_SEQ.Contains("/data/files/"))
                        {
                            path_SEQ = (path_SEQ.Replace("/data/files/", @"\\waifs2\pitneyfiles\")).Replace("/", @"\");
                        }
                    }
                }
            }
            catch
            {

            }
        }
        private void txtLineLong_TextChanged(object sender, EventArgs e)
        {
            Btn_Check_Malf_SEQ.Enabled = true;
        }
        private void BTN_Generate_Ruler_Click(object sender, EventArgs e)
        {
            Create_Ruler();
        }
        private void BCK_WRK_CNV_TXT_DoWork(object sender, DoWorkEventArgs e)
        {
            Open open = new Open();
            var my_file = File.ReadAllLines(path_SEQ);

            if (my_file.Count() < 1200000)
            {
                Invoke(new Action(() => this.Hide()));
                Invoke(new Action(() => open.OpenFile_SEQ(path_SEQ, richTextBox1)));
                Invoke(new Action(() => this.Show()));
            }
            else
            {
                Invoke(new Action(() => this.Width = 400));
                Invoke(new Action(() => this.Height = 600));
                richTextBox1.Visible = false;
                RTB_Count_Char.Visible = false;
                BTN_Generate_Ruler.Visible = false;
                MessageBox.Show("File is too big to open it in txt editor\nBut you can still check if you have malformed records ");
            }
        }
        private void BCK_WRK_CHCK_TXT_DoWork(object sender, DoWorkEventArgs e)
        {
            Loading L = new Loading();
            Check_File ch = new Check_File();
            if (!Int32.TryParse(txtLineLong.Text, out int cos))
            {
                MessageBox.Show("Please enter Record Length");
            }
            else
            {
                Invoke(new Action(() => this.Hide()));
                Invoke(new Action(() => L.Show()));
                Invoke(new Action(() => L.Label_show_inf.Text = "Your file is being checked"));
                Invoke(new Action(() => ch.Check_SEQ(path_SEQ, cos, out malf2, out malf2_comu, L.progressBar1)));
                Invoke(new Action(() => ch.CreateLOG(malf2_comu, path_SEQ, out log_path)));
                Invoke(new Action(() => L.Close()));
                Invoke(new Action(() => malform_shower_SEQ()));
                Invoke(new Action(() => this.Show()));
                Invoke(new Action(() => Btn_Check_Malf_SEQ.Enabled = false));
            }
        }
        #endregion


        private void About_Button_Click(object sender, EventArgs e)
        {
            if (a == null)
            {
                a = new About();
                a.Show();
            }
            else
            {
                a.Close();
                a = null;
            }
        }

        private void Delimited_Label_Click(object sender, EventArgs e)
        {
            Delimited_Label.ForeColor = Color.White;
            Line_Seq_Label.ForeColor = Color.DimGray;
            Panel_Line_Seq.Visible = false;
            Panel_Delimited.Visible = true;
            Delimited_Hi_Panel.Visible = true;
            Line_Seq_Hi_Panel.Visible = false;
        }

        private void Line_Seq_Label_Click(object sender, EventArgs e)
        {
            Delimited_Label.ForeColor = Color.DimGray;
            Line_Seq_Label.ForeColor = Color.White;
            Panel_Delimited.Visible = false;
            Panel_Line_Seq.Visible = true;
            Delimited_Hi_Panel.Visible = false;
            Line_Seq_Hi_Panel.Visible = true;
        }

        private void Delimited_Label_MouseEnter(object sender, EventArgs e)
        {
            Delimited_Hi_Panel.Visible = true;
            Delimited_Label.ForeColor = Color.White;
        }

        private void Delimited_Label_MouseLeave(object sender, EventArgs e)
        {
            if (Panel_Delimited.Visible)
            {
                Delimited_Hi_Panel.Visible = true;
                Delimited_Label.ForeColor = Color.White;
            }
            else
            {
                Delimited_Hi_Panel.Visible = false;
                Delimited_Label.ForeColor = Color.DimGray;
            }
        }

        private void Line_Seq_Label_MouseEnter(object sender, EventArgs e)
        {
            Line_Seq_Hi_Panel.Visible = true;
            Line_Seq_Label.ForeColor = Color.White;
        }

        private void Line_Seq_Label_MouseLeave(object sender, EventArgs e)
        {
            if (Panel_Line_Seq.Visible)
            {
                Line_Seq_Hi_Panel.Visible = true;
                Line_Seq_Label.ForeColor = Color.White;
            }
            else
            {
                Line_Seq_Hi_Panel.Visible = false;
                Line_Seq_Label.ForeColor = Color.DimGray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Delimited_Label.ForeColor = Color.White;
            Line_Seq_Label.ForeColor = Color.DimGray;
            Panel_Line_Seq.Visible = false;
            Panel_Delimited.Visible = true;
            Delimited_Hi_Panel.Visible = true;
            Line_Seq_Hi_Panel.Visible = false;
        }

        private void About_label_Click(object sender, EventArgs e)
        {
            if (a == null)
            {
                About_Label.ForeColor = Color.White;
                About_Hi_Panel.Visible = true;
                a = new About();
                a.Show();
            }
            else
            {
                About_Label.ForeColor = Color.DimGray;
                About_Hi_Panel.Visible = false;
                a.Close();
                a = null;
            }
        }

        private void About_Label_MouseEnter(object sender, EventArgs e)
        {
            About_Label.ForeColor = Color.White;
            About_Hi_Panel.Visible = true;
        }

        private void About_Label_MouseLeave(object sender, EventArgs e)
        {
            if (a == null)
            {
                About_Label.ForeColor = Color.DimGray;
                About_Hi_Panel.Visible = false;
            }
            else
            {
                About_Label.ForeColor = Color.White;
                About_Hi_Panel.Visible = true;
            }
        }
    }


}
