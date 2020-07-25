namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_Skip_Malf_SEQ = new System.Windows.Forms.Button();
            this.BTN_Generate_Ruler = new System.Windows.Forms.Button();
            this.RTB_Count_Char = new System.Windows.Forms.RichTextBox();
            this.Txt_Row_SEQ = new System.Windows.Forms.TextBox();
            this.txtLineLong = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtPathLine = new System.Windows.Forms.TextBox();
            this.Btn_Open_File_SEQ = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Open_Log_SEQ = new System.Windows.Forms.Button();
            this.Btn_Check_Malf_SEQ = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_CnvToTxt = new System.Windows.Forms.Button();
            this.Btn_Open_Line = new System.Windows.Forms.Button();
            this.Btn_Skip_Malf_DEL = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Open_Delimited = new System.Windows.Forms.Button();
            this.Btn_Open_File_DEL = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_Open_Log_DEL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_CnvToTbl = new System.Windows.Forms.Button();
            this.Btn_Check_Malf_DEL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BCK_WRK_CNV_TXT = new System.ComponentModel.BackgroundWorker();
            this.BCK_WRK_CHCK_TXT = new System.ComponentModel.BackgroundWorker();
            this.BCK_WRK_CNV_DEL = new System.ComponentModel.BackgroundWorker();
            this.BCK_WRK_CHCK_DEL = new System.ComponentModel.BackgroundWorker();
            this.Panel_Line_Seq = new System.Windows.Forms.Panel();
            this.Panel_Delimited = new System.Windows.Forms.Panel();
            this.Delimited_Label = new System.Windows.Forms.Label();
            this.Line_Seq_Label = new System.Windows.Forms.Label();
            this.Delimited_Hi_Panel = new System.Windows.Forms.Panel();
            this.Line_Seq_Hi_Panel = new System.Windows.Forms.Panel();
            this.About_Label = new System.Windows.Forms.Label();
            this.About_Hi_Panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel_Line_Seq.SuspendLayout();
            this.Panel_Delimited.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Skip_Malf_SEQ
            // 
            this.Btn_Skip_Malf_SEQ.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_Skip_Malf_SEQ.Enabled = false;
            this.Btn_Skip_Malf_SEQ.FlatAppearance.BorderSize = 0;
            this.Btn_Skip_Malf_SEQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Skip_Malf_SEQ.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Skip_Malf_SEQ.ForeColor = System.Drawing.Color.White;
            this.Btn_Skip_Malf_SEQ.Location = new System.Drawing.Point(10, 320);
            this.Btn_Skip_Malf_SEQ.Name = "Btn_Skip_Malf_SEQ";
            this.Btn_Skip_Malf_SEQ.Size = new System.Drawing.Size(220, 40);
            this.Btn_Skip_Malf_SEQ.TabIndex = 32;
            this.Btn_Skip_Malf_SEQ.Text = "Skip to Malform";
            this.Btn_Skip_Malf_SEQ.UseVisualStyleBackColor = false;
            this.Btn_Skip_Malf_SEQ.Visible = false;
            this.Btn_Skip_Malf_SEQ.Click += new System.EventHandler(this.Btn_Skip_Malf_SEQ_Click);
            // 
            // BTN_Generate_Ruler
            // 
            this.BTN_Generate_Ruler.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTN_Generate_Ruler.FlatAppearance.BorderSize = 0;
            this.BTN_Generate_Ruler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Generate_Ruler.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold);
            this.BTN_Generate_Ruler.ForeColor = System.Drawing.Color.White;
            this.BTN_Generate_Ruler.Location = new System.Drawing.Point(315, 36);
            this.BTN_Generate_Ruler.Name = "BTN_Generate_Ruler";
            this.BTN_Generate_Ruler.Size = new System.Drawing.Size(59, 31);
            this.BTN_Generate_Ruler.TabIndex = 31;
            this.BTN_Generate_Ruler.Text = "Ruler";
            this.BTN_Generate_Ruler.UseVisualStyleBackColor = false;
            this.BTN_Generate_Ruler.Visible = false;
            this.BTN_Generate_Ruler.Click += new System.EventHandler(this.BTN_Generate_Ruler_Click);
            // 
            // RTB_Count_Char
            // 
            this.RTB_Count_Char.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Count_Char.BackColor = System.Drawing.SystemColors.Control;
            this.RTB_Count_Char.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Count_Char.Enabled = false;
            this.RTB_Count_Char.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB_Count_Char.Location = new System.Drawing.Point(380, 35);
            this.RTB_Count_Char.Name = "RTB_Count_Char";
            this.RTB_Count_Char.ReadOnly = true;
            this.RTB_Count_Char.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RTB_Count_Char.ShortcutsEnabled = false;
            this.RTB_Count_Char.Size = new System.Drawing.Size(700, 35);
            this.RTB_Count_Char.TabIndex = 30;
            this.RTB_Count_Char.Text = "";
            this.RTB_Count_Char.WordWrap = false;
            // 
            // Txt_Row_SEQ
            // 
            this.Txt_Row_SEQ.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_Row_SEQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_Row_SEQ.Enabled = false;
            this.Txt_Row_SEQ.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.Txt_Row_SEQ.ForeColor = System.Drawing.Color.White;
            this.Txt_Row_SEQ.Location = new System.Drawing.Point(251, 409);
            this.Txt_Row_SEQ.Name = "Txt_Row_SEQ";
            this.Txt_Row_SEQ.Size = new System.Drawing.Size(100, 27);
            this.Txt_Row_SEQ.TabIndex = 25;
            this.Txt_Row_SEQ.Visible = false;
            this.Txt_Row_SEQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Row_SEQ_KeyDown);
            // 
            // txtLineLong
            // 
            this.txtLineLong.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLineLong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLineLong.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.txtLineLong.ForeColor = System.Drawing.Color.White;
            this.txtLineLong.Location = new System.Drawing.Point(148, 100);
            this.txtLineLong.Name = "txtLineLong";
            this.txtLineLong.Size = new System.Drawing.Size(159, 29);
            this.txtLineLong.TabIndex = 21;
            this.txtLineLong.Visible = false;
            this.txtLineLong.TextChanged += new System.EventHandler(this.txtLineLong_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(380, 73);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(700, 492);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.HScroll += new System.EventHandler(this.richTextBox1_HScroll);
            this.richTextBox1.VScroll += new System.EventHandler(this.richTextBox1_VScroll);
            this.richTextBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDoubleClick);
            // 
            // txtPathLine
            // 
            this.txtPathLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathLine.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPathLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPathLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathLine.ForeColor = System.Drawing.Color.White;
            this.txtPathLine.Location = new System.Drawing.Point(66, 6);
            this.txtPathLine.Name = "txtPathLine";
            this.txtPathLine.Size = new System.Drawing.Size(1015, 24);
            this.txtPathLine.TabIndex = 17;
            this.txtPathLine.Text = "File Path";
            this.txtPathLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPathLine_KeyDown);
            // 
            // Btn_Open_File_SEQ
            // 
            this.Btn_Open_File_SEQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Open_File_SEQ.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_Open_File_SEQ.Enabled = false;
            this.Btn_Open_File_SEQ.FlatAppearance.BorderSize = 0;
            this.Btn_Open_File_SEQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Open_File_SEQ.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold);
            this.Btn_Open_File_SEQ.ForeColor = System.Drawing.Color.White;
            this.Btn_Open_File_SEQ.Location = new System.Drawing.Point(10, 526);
            this.Btn_Open_File_SEQ.Name = "Btn_Open_File_SEQ";
            this.Btn_Open_File_SEQ.Size = new System.Drawing.Size(355, 40);
            this.Btn_Open_File_SEQ.TabIndex = 27;
            this.Btn_Open_File_SEQ.Text = "Open File in default program";
            this.Btn_Open_File_SEQ.UseVisualStyleBackColor = false;
            this.Btn_Open_File_SEQ.Visible = false;
            this.Btn_Open_File_SEQ.Click += new System.EventHandler(this.Btn_Open_File_SEQ_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(161, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Go to row:";
            this.label5.Visible = false;
            // 
            // Btn_Open_Log_SEQ
            // 
            this.Btn_Open_Log_SEQ.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_Open_Log_SEQ.Enabled = false;
            this.Btn_Open_Log_SEQ.FlatAppearance.BorderSize = 0;
            this.Btn_Open_Log_SEQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Open_Log_SEQ.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold);
            this.Btn_Open_Log_SEQ.ForeColor = System.Drawing.Color.White;
            this.Btn_Open_Log_SEQ.Location = new System.Drawing.Point(10, 400);
            this.Btn_Open_Log_SEQ.Name = "Btn_Open_Log_SEQ";
            this.Btn_Open_Log_SEQ.Size = new System.Drawing.Size(110, 40);
            this.Btn_Open_Log_SEQ.TabIndex = 24;
            this.Btn_Open_Log_SEQ.Text = "Open Log";
            this.Btn_Open_Log_SEQ.UseVisualStyleBackColor = false;
            this.Btn_Open_Log_SEQ.Visible = false;
            this.Btn_Open_Log_SEQ.Click += new System.EventHandler(this.Btn_Open_Log_SEQ_Click);
            // 
            // Btn_Check_Malf_SEQ
            // 
            this.Btn_Check_Malf_SEQ.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_Check_Malf_SEQ.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Check_Malf_SEQ.Enabled = false;
            this.Btn_Check_Malf_SEQ.FlatAppearance.BorderSize = 0;
            this.Btn_Check_Malf_SEQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Check_Malf_SEQ.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Check_Malf_SEQ.ForeColor = System.Drawing.Color.White;
            this.Btn_Check_Malf_SEQ.Location = new System.Drawing.Point(10, 250);
            this.Btn_Check_Malf_SEQ.Name = "Btn_Check_Malf_SEQ";
            this.Btn_Check_Malf_SEQ.Size = new System.Drawing.Size(220, 40);
            this.Btn_Check_Malf_SEQ.TabIndex = 23;
            this.Btn_Check_Malf_SEQ.Text = "Check Malforms";
            this.Btn_Check_Malf_SEQ.UseVisualStyleBackColor = false;
            this.Btn_Check_Malf_SEQ.Visible = false;
            this.Btn_Check_Malf_SEQ.Click += new System.EventHandler(this.Btn_Check_Malf_SEQ_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.ForeColor = System.Drawing.Color.White;
            this.numberLabel.Location = new System.Drawing.Point(351, 52);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(0, 13);
            this.numberLabel.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Record Length";
            this.label4.Visible = false;
            // 
            // Btn_CnvToTxt
            // 
            this.Btn_CnvToTxt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_CnvToTxt.FlatAppearance.BorderSize = 0;
            this.Btn_CnvToTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CnvToTxt.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_CnvToTxt.ForeColor = System.Drawing.Color.White;
            this.Btn_CnvToTxt.Location = new System.Drawing.Point(10, 180);
            this.Btn_CnvToTxt.Name = "Btn_CnvToTxt";
            this.Btn_CnvToTxt.Size = new System.Drawing.Size(220, 40);
            this.Btn_CnvToTxt.TabIndex = 19;
            this.Btn_CnvToTxt.Text = "Convert to Viewer";
            this.Btn_CnvToTxt.UseVisualStyleBackColor = false;
            this.Btn_CnvToTxt.Visible = false;
            this.Btn_CnvToTxt.Click += new System.EventHandler(this.Btn_CnvToTxt_Click);
            // 
            // Btn_Open_Line
            // 
            this.Btn_Open_Line.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_Open_Line.FlatAppearance.BorderSize = 0;
            this.Btn_Open_Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Open_Line.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold);
            this.Btn_Open_Line.ForeColor = System.Drawing.Color.White;
            this.Btn_Open_Line.Location = new System.Drawing.Point(10, 5);
            this.Btn_Open_Line.Name = "Btn_Open_Line";
            this.Btn_Open_Line.Size = new System.Drawing.Size(50, 25);
            this.Btn_Open_Line.TabIndex = 16;
            this.Btn_Open_Line.Text = "...";
            this.Btn_Open_Line.UseVisualStyleBackColor = false;
            this.Btn_Open_Line.Click += new System.EventHandler(this.Btn_Open_Line_Click);
            // 
            // Btn_Skip_Malf_DEL
            // 
            this.Btn_Skip_Malf_DEL.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_Skip_Malf_DEL.Enabled = false;
            this.Btn_Skip_Malf_DEL.FlatAppearance.BorderSize = 0;
            this.Btn_Skip_Malf_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Skip_Malf_DEL.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Skip_Malf_DEL.ForeColor = System.Drawing.Color.White;
            this.Btn_Skip_Malf_DEL.Location = new System.Drawing.Point(10, 320);
            this.Btn_Skip_Malf_DEL.Name = "Btn_Skip_Malf_DEL";
            this.Btn_Skip_Malf_DEL.Size = new System.Drawing.Size(220, 40);
            this.Btn_Skip_Malf_DEL.TabIndex = 20;
            this.Btn_Skip_Malf_DEL.Text = "Skip to Malform";
            this.Btn_Skip_Malf_DEL.UseVisualStyleBackColor = false;
            this.Btn_Skip_Malf_DEL.Visible = false;
            this.Btn_Skip_Malf_DEL.Click += new System.EventHandler(this.Btn_Skip_Malf_DEL_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboBox2.Location = new System.Drawing.Point(141, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(179, 28);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.Text = "No";
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(700, 530);
            this.dataGridView1.TabIndex = 4;
            // 
            // Btn_Open_Delimited
            // 
            this.Btn_Open_Delimited.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_Open_Delimited.FlatAppearance.BorderSize = 0;
            this.Btn_Open_Delimited.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Open_Delimited.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold);
            this.Btn_Open_Delimited.ForeColor = System.Drawing.Color.White;
            this.Btn_Open_Delimited.Location = new System.Drawing.Point(10, 5);
            this.Btn_Open_Delimited.Name = "Btn_Open_Delimited";
            this.Btn_Open_Delimited.Size = new System.Drawing.Size(50, 25);
            this.Btn_Open_Delimited.TabIndex = 15;
            this.Btn_Open_Delimited.Text = "...";
            this.Btn_Open_Delimited.UseVisualStyleBackColor = false;
            this.Btn_Open_Delimited.Click += new System.EventHandler(this.Btn_Open_Delimited_Click);
            // 
            // Btn_Open_File_DEL
            // 
            this.Btn_Open_File_DEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Open_File_DEL.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_Open_File_DEL.Enabled = false;
            this.Btn_Open_File_DEL.FlatAppearance.BorderSize = 0;
            this.Btn_Open_File_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Open_File_DEL.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Open_File_DEL.ForeColor = System.Drawing.Color.White;
            this.Btn_Open_File_DEL.Location = new System.Drawing.Point(10, 526);
            this.Btn_Open_File_DEL.Name = "Btn_Open_File_DEL";
            this.Btn_Open_File_DEL.Size = new System.Drawing.Size(355, 40);
            this.Btn_Open_File_DEL.TabIndex = 19;
            this.Btn_Open_File_DEL.Text = "Open File in default program";
            this.Btn_Open_File_DEL.UseVisualStyleBackColor = false;
            this.Btn_Open_File_DEL.Visible = false;
            this.Btn_Open_File_DEL.Click += new System.EventHandler(this.Btn_Open_File_DEL_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(66, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1015, 24);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "File Path";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(251, 409);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 11;
            this.textBox2.Visible = false;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // Btn_Open_Log_DEL
            // 
            this.Btn_Open_Log_DEL.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_Open_Log_DEL.Enabled = false;
            this.Btn_Open_Log_DEL.FlatAppearance.BorderSize = 0;
            this.Btn_Open_Log_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Open_Log_DEL.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Open_Log_DEL.ForeColor = System.Drawing.Color.White;
            this.Btn_Open_Log_DEL.Location = new System.Drawing.Point(10, 400);
            this.Btn_Open_Log_DEL.Name = "Btn_Open_Log_DEL";
            this.Btn_Open_Log_DEL.Size = new System.Drawing.Size(110, 40);
            this.Btn_Open_Log_DEL.TabIndex = 18;
            this.Btn_Open_Log_DEL.Text = "Open Log";
            this.Btn_Open_Log_DEL.UseVisualStyleBackColor = false;
            this.Btn_Open_Log_DEL.Visible = false;
            this.Btn_Open_Log_DEL.Click += new System.EventHandler(this.Btn_Open_Log_DEL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Header:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(161, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Go to row:";
            this.label3.Visible = false;
            // 
            // Btn_CnvToTbl
            // 
            this.Btn_CnvToTbl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_CnvToTbl.FlatAppearance.BorderSize = 0;
            this.Btn_CnvToTbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CnvToTbl.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_CnvToTbl.ForeColor = System.Drawing.Color.White;
            this.Btn_CnvToTbl.Location = new System.Drawing.Point(10, 180);
            this.Btn_CnvToTbl.Name = "Btn_CnvToTbl";
            this.Btn_CnvToTbl.Size = new System.Drawing.Size(220, 40);
            this.Btn_CnvToTbl.TabIndex = 16;
            this.Btn_CnvToTbl.Text = "Convert to Table";
            this.Btn_CnvToTbl.UseVisualStyleBackColor = false;
            this.Btn_CnvToTbl.Visible = false;
            this.Btn_CnvToTbl.Click += new System.EventHandler(this.Btn_CnvToTbl_Click);
            // 
            // Btn_Check_Malf_DEL
            // 
            this.Btn_Check_Malf_DEL.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_Check_Malf_DEL.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Check_Malf_DEL.Enabled = false;
            this.Btn_Check_Malf_DEL.FlatAppearance.BorderSize = 0;
            this.Btn_Check_Malf_DEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Check_Malf_DEL.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Check_Malf_DEL.ForeColor = System.Drawing.Color.White;
            this.Btn_Check_Malf_DEL.Location = new System.Drawing.Point(10, 250);
            this.Btn_Check_Malf_DEL.Name = "Btn_Check_Malf_DEL";
            this.Btn_Check_Malf_DEL.Size = new System.Drawing.Size(220, 40);
            this.Btn_Check_Malf_DEL.TabIndex = 5;
            this.Btn_Check_Malf_DEL.Text = "Check Malforms";
            this.Btn_Check_Malf_DEL.UseVisualStyleBackColor = false;
            this.Btn_Check_Malf_DEL.Visible = false;
            this.Btn_Check_Malf_DEL.Click += new System.EventHandler(this.Btn_Check_Malf_DEL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.CausesValidation = false;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Field Separator:";
            this.label1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Space (   )",
            "Tab (  U+0009  )",
            "Comma (  ,  )",
            "Period (  .  )",
            "Semicolon (   ;  )",
            "Pipe (  |  )",
            "Double Quotes  (  \"  )",
            "Tilde (  ~  )"});
            this.comboBox1.Location = new System.Drawing.Point(141, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Defult set up is (TAB)";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BCK_WRK_CNV_TXT
            // 
            this.BCK_WRK_CNV_TXT.WorkerSupportsCancellation = true;
            this.BCK_WRK_CNV_TXT.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BCK_WRK_CNV_TXT_DoWork);
            // 
            // BCK_WRK_CHCK_TXT
            // 
            this.BCK_WRK_CHCK_TXT.WorkerSupportsCancellation = true;
            this.BCK_WRK_CHCK_TXT.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BCK_WRK_CHCK_TXT_DoWork);
            // 
            // BCK_WRK_CNV_DEL
            // 
            this.BCK_WRK_CNV_DEL.WorkerSupportsCancellation = true;
            this.BCK_WRK_CNV_DEL.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BCK_WRK_CNV_DEL_DoWork);
            // 
            // BCK_WRK_CHCK_DEL
            // 
            this.BCK_WRK_CHCK_DEL.WorkerSupportsCancellation = true;
            this.BCK_WRK_CHCK_DEL.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BCK_WRK_CHCK_DEL_DoWork);
            // 
            // Panel_Line_Seq
            // 
            this.Panel_Line_Seq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Line_Seq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Panel_Line_Seq.Controls.Add(this.Btn_Open_File_SEQ);
            this.Panel_Line_Seq.Controls.Add(this.Btn_Skip_Malf_SEQ);
            this.Panel_Line_Seq.Controls.Add(this.BTN_Generate_Ruler);
            this.Panel_Line_Seq.Controls.Add(this.Btn_Open_Line);
            this.Panel_Line_Seq.Controls.Add(this.RTB_Count_Char);
            this.Panel_Line_Seq.Controls.Add(this.Btn_CnvToTxt);
            this.Panel_Line_Seq.Controls.Add(this.Txt_Row_SEQ);
            this.Panel_Line_Seq.Controls.Add(this.label4);
            this.Panel_Line_Seq.Controls.Add(this.txtLineLong);
            this.Panel_Line_Seq.Controls.Add(this.numberLabel);
            this.Panel_Line_Seq.Controls.Add(this.richTextBox1);
            this.Panel_Line_Seq.Controls.Add(this.Btn_Check_Malf_SEQ);
            this.Panel_Line_Seq.Controls.Add(this.txtPathLine);
            this.Panel_Line_Seq.Controls.Add(this.Btn_Open_Log_SEQ);
            this.Panel_Line_Seq.Controls.Add(this.label5);
            this.Panel_Line_Seq.Location = new System.Drawing.Point(0, 40);
            this.Panel_Line_Seq.Name = "Panel_Line_Seq";
            this.Panel_Line_Seq.Size = new System.Drawing.Size(1083, 580);
            this.Panel_Line_Seq.TabIndex = 24;
            this.Panel_Line_Seq.Visible = false;
            // 
            // Panel_Delimited
            // 
            this.Panel_Delimited.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Delimited.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Panel_Delimited.Controls.Add(this.Btn_Skip_Malf_DEL);
            this.Panel_Delimited.Controls.Add(this.Btn_Check_Malf_DEL);
            this.Panel_Delimited.Controls.Add(this.comboBox2);
            this.Panel_Delimited.Controls.Add(this.comboBox1);
            this.Panel_Delimited.Controls.Add(this.dataGridView1);
            this.Panel_Delimited.Controls.Add(this.label1);
            this.Panel_Delimited.Controls.Add(this.Btn_Open_Delimited);
            this.Panel_Delimited.Controls.Add(this.Btn_CnvToTbl);
            this.Panel_Delimited.Controls.Add(this.Btn_Open_File_DEL);
            this.Panel_Delimited.Controls.Add(this.label3);
            this.Panel_Delimited.Controls.Add(this.textBox1);
            this.Panel_Delimited.Controls.Add(this.label2);
            this.Panel_Delimited.Controls.Add(this.textBox2);
            this.Panel_Delimited.Controls.Add(this.Btn_Open_Log_DEL);
            this.Panel_Delimited.Location = new System.Drawing.Point(0, 40);
            this.Panel_Delimited.Name = "Panel_Delimited";
            this.Panel_Delimited.Size = new System.Drawing.Size(1083, 580);
            this.Panel_Delimited.TabIndex = 25;
            // 
            // Delimited_Label
            // 
            this.Delimited_Label.Font = new System.Drawing.Font("Yu Gothic UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.Delimited_Label.ForeColor = System.Drawing.Color.DimGray;
            this.Delimited_Label.Location = new System.Drawing.Point(0, 0);
            this.Delimited_Label.Name = "Delimited_Label";
            this.Delimited_Label.Size = new System.Drawing.Size(150, 40);
            this.Delimited_Label.TabIndex = 209;
            this.Delimited_Label.Text = "Delimited";
            this.Delimited_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Delimited_Label.Click += new System.EventHandler(this.Delimited_Label_Click);
            this.Delimited_Label.MouseEnter += new System.EventHandler(this.Delimited_Label_MouseEnter);
            this.Delimited_Label.MouseLeave += new System.EventHandler(this.Delimited_Label_MouseLeave);
            // 
            // Line_Seq_Label
            // 
            this.Line_Seq_Label.Font = new System.Drawing.Font("Yu Gothic UI", 13.5F, System.Drawing.FontStyle.Bold);
            this.Line_Seq_Label.ForeColor = System.Drawing.Color.DimGray;
            this.Line_Seq_Label.Location = new System.Drawing.Point(150, 0);
            this.Line_Seq_Label.Name = "Line_Seq_Label";
            this.Line_Seq_Label.Size = new System.Drawing.Size(150, 40);
            this.Line_Seq_Label.TabIndex = 210;
            this.Line_Seq_Label.Text = "Line Sequential";
            this.Line_Seq_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Line_Seq_Label.Click += new System.EventHandler(this.Line_Seq_Label_Click);
            this.Line_Seq_Label.MouseEnter += new System.EventHandler(this.Line_Seq_Label_MouseEnter);
            this.Line_Seq_Label.MouseLeave += new System.EventHandler(this.Line_Seq_Label_MouseLeave);
            // 
            // Delimited_Hi_Panel
            // 
            this.Delimited_Hi_Panel.BackColor = System.Drawing.Color.White;
            this.Delimited_Hi_Panel.Location = new System.Drawing.Point(0, 35);
            this.Delimited_Hi_Panel.Name = "Delimited_Hi_Panel";
            this.Delimited_Hi_Panel.Size = new System.Drawing.Size(150, 3);
            this.Delimited_Hi_Panel.TabIndex = 211;
            this.Delimited_Hi_Panel.Visible = false;
            // 
            // Line_Seq_Hi_Panel
            // 
            this.Line_Seq_Hi_Panel.BackColor = System.Drawing.Color.White;
            this.Line_Seq_Hi_Panel.Location = new System.Drawing.Point(150, 35);
            this.Line_Seq_Hi_Panel.Name = "Line_Seq_Hi_Panel";
            this.Line_Seq_Hi_Panel.Size = new System.Drawing.Size(150, 3);
            this.Line_Seq_Hi_Panel.TabIndex = 212;
            this.Line_Seq_Hi_Panel.Visible = false;
            // 
            // About_Label
            // 
            this.About_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.About_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold);
            this.About_Label.ForeColor = System.Drawing.Color.DimGray;
            this.About_Label.Location = new System.Drawing.Point(932, 0);
            this.About_Label.Name = "About_Label";
            this.About_Label.Size = new System.Drawing.Size(150, 40);
            this.About_Label.TabIndex = 213;
            this.About_Label.Text = "About";
            this.About_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.About_Label.Visible = false;
            this.About_Label.Click += new System.EventHandler(this.About_label_Click);
            this.About_Label.MouseEnter += new System.EventHandler(this.About_Label_MouseEnter);
            this.About_Label.MouseLeave += new System.EventHandler(this.About_Label_MouseLeave);
            // 
            // About_Hi_Panel
            // 
            this.About_Hi_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.About_Hi_Panel.BackColor = System.Drawing.Color.White;
            this.About_Hi_Panel.Location = new System.Drawing.Point(932, 35);
            this.About_Hi_Panel.Name = "About_Hi_Panel";
            this.About_Hi_Panel.Size = new System.Drawing.Size(150, 3);
            this.About_Hi_Panel.TabIndex = 213;
            this.About_Hi_Panel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.About_Hi_Panel);
            this.Controls.Add(this.About_Label);
            this.Controls.Add(this.Line_Seq_Hi_Panel);
            this.Controls.Add(this.Delimited_Hi_Panel);
            this.Controls.Add(this.Line_Seq_Label);
            this.Controls.Add(this.Delimited_Label);
            this.Controls.Add(this.Panel_Delimited);
            this.Controls.Add(this.Panel_Line_Seq);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Malform Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel_Line_Seq.ResumeLayout(false);
            this.Panel_Line_Seq.PerformLayout();
            this.Panel_Delimited.ResumeLayout(false);
            this.Panel_Delimited.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox RTB_Count_Char;
        private System.Windows.Forms.TextBox Txt_Row_SEQ;
        private System.Windows.Forms.TextBox txtLineLong;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtPathLine;
        private System.Windows.Forms.Button Btn_Open_File_SEQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Open_Log_SEQ;
        private System.Windows.Forms.Button Btn_Check_Malf_SEQ;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_CnvToTxt;
        private System.Windows.Forms.Button Btn_Open_Line;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Open_Delimited;
        private System.Windows.Forms.Button Btn_Open_File_DEL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btn_Open_Log_DEL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_CnvToTbl;
        private System.Windows.Forms.Button Btn_Check_Malf_DEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.ComponentModel.BackgroundWorker BCK_WRK_CNV_TXT;
        private System.Windows.Forms.Button BTN_Generate_Ruler;
        public System.ComponentModel.BackgroundWorker BCK_WRK_CHCK_TXT;
        public System.ComponentModel.BackgroundWorker BCK_WRK_CNV_DEL;
        public System.ComponentModel.BackgroundWorker BCK_WRK_CHCK_DEL;
        private System.Windows.Forms.Button Btn_Skip_Malf_DEL;
        private System.Windows.Forms.Button Btn_Skip_Malf_SEQ;
        private System.Windows.Forms.Panel Panel_Line_Seq;
        private System.Windows.Forms.Panel Panel_Delimited;
        private System.Windows.Forms.Label Delimited_Label;
        private System.Windows.Forms.Label Line_Seq_Label;
        private System.Windows.Forms.Panel Delimited_Hi_Panel;
        private System.Windows.Forms.Panel Line_Seq_Hi_Panel;
        private System.Windows.Forms.Label About_Label;
        private System.Windows.Forms.Panel About_Hi_Panel;
    }
}

