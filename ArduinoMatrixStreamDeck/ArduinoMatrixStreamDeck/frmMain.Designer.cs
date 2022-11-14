namespace ArduinoMatrixStreamDeck
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.chkAsterisco = new System.Windows.Forms.CheckBox();
            this.chkNumeral = new System.Windows.Forms.CheckBox();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.tmrClearScreen = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox1.FlatAppearance.BorderSize = 3;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(13, 13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 59);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "1";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkAsterisco, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkNumeral, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxA, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxB, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxC, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxD, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 281);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox2.FlatAppearance.BorderSize = 3;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(77, 13);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 59);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "2";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox3.FlatAppearance.BorderSize = 3;
            this.checkBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(141, 13);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(58, 59);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "3";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox4.FlatAppearance.BorderSize = 3;
            this.checkBox4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(13, 78);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(58, 59);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "4";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox5.FlatAppearance.BorderSize = 3;
            this.checkBox5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.Location = new System.Drawing.Point(77, 78);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(58, 59);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "5";
            this.checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox6.FlatAppearance.BorderSize = 3;
            this.checkBox6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.White;
            this.checkBox6.Location = new System.Drawing.Point(141, 78);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(58, 59);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "6";
            this.checkBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox6.UseVisualStyleBackColor = false;
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox7.FlatAppearance.BorderSize = 3;
            this.checkBox7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.Color.White;
            this.checkBox7.Location = new System.Drawing.Point(13, 143);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(58, 59);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Text = "7";
            this.checkBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox7.UseVisualStyleBackColor = false;
            // 
            // checkBox8
            // 
            this.checkBox8.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox8.FlatAppearance.BorderSize = 3;
            this.checkBox8.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.ForeColor = System.Drawing.Color.White;
            this.checkBox8.Location = new System.Drawing.Point(77, 143);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(58, 59);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "8";
            this.checkBox8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox8.UseVisualStyleBackColor = false;
            // 
            // checkBox9
            // 
            this.checkBox9.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox9.FlatAppearance.BorderSize = 3;
            this.checkBox9.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.ForeColor = System.Drawing.Color.White;
            this.checkBox9.Location = new System.Drawing.Point(141, 143);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(58, 59);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Text = "9";
            this.checkBox9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox9.UseVisualStyleBackColor = false;
            // 
            // checkBox0
            // 
            this.checkBox0.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox0.FlatAppearance.BorderSize = 3;
            this.checkBox0.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBox0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox0.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox0.ForeColor = System.Drawing.Color.White;
            this.checkBox0.Location = new System.Drawing.Point(77, 208);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(58, 60);
            this.checkBox0.TabIndex = 0;
            this.checkBox0.Text = "0";
            this.checkBox0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox0.UseVisualStyleBackColor = false;
            // 
            // chkAsterisco
            // 
            this.chkAsterisco.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAsterisco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkAsterisco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAsterisco.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkAsterisco.FlatAppearance.BorderSize = 3;
            this.chkAsterisco.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkAsterisco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAsterisco.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAsterisco.ForeColor = System.Drawing.Color.White;
            this.chkAsterisco.Location = new System.Drawing.Point(13, 208);
            this.chkAsterisco.Name = "chkAsterisco";
            this.chkAsterisco.Size = new System.Drawing.Size(58, 60);
            this.chkAsterisco.TabIndex = 0;
            this.chkAsterisco.Text = "*";
            this.chkAsterisco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAsterisco.UseVisualStyleBackColor = false;
            // 
            // chkNumeral
            // 
            this.chkNumeral.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNumeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkNumeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkNumeral.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkNumeral.FlatAppearance.BorderSize = 3;
            this.chkNumeral.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.chkNumeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNumeral.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumeral.ForeColor = System.Drawing.Color.White;
            this.chkNumeral.Location = new System.Drawing.Point(141, 208);
            this.chkNumeral.Name = "chkNumeral";
            this.chkNumeral.Size = new System.Drawing.Size(58, 60);
            this.chkNumeral.TabIndex = 0;
            this.chkNumeral.Text = "#";
            this.chkNumeral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNumeral.UseVisualStyleBackColor = false;
            // 
            // checkBoxA
            // 
            this.checkBoxA.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBoxA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBoxA.FlatAppearance.BorderSize = 3;
            this.checkBoxA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.checkBoxA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxA.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxA.ForeColor = System.Drawing.Color.White;
            this.checkBoxA.Location = new System.Drawing.Point(205, 13);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(58, 59);
            this.checkBoxA.TabIndex = 0;
            this.checkBoxA.Text = "A";
            this.checkBoxA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxA.UseVisualStyleBackColor = false;
            // 
            // checkBoxB
            // 
            this.checkBoxB.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBoxB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBoxB.FlatAppearance.BorderSize = 3;
            this.checkBoxB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.checkBoxB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxB.ForeColor = System.Drawing.Color.White;
            this.checkBoxB.Location = new System.Drawing.Point(205, 78);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(58, 59);
            this.checkBoxB.TabIndex = 0;
            this.checkBoxB.Text = "B";
            this.checkBoxB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxB.UseVisualStyleBackColor = false;
            // 
            // checkBoxC
            // 
            this.checkBoxC.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBoxC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBoxC.FlatAppearance.BorderSize = 3;
            this.checkBoxC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.checkBoxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxC.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxC.ForeColor = System.Drawing.Color.White;
            this.checkBoxC.Location = new System.Drawing.Point(205, 143);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(58, 59);
            this.checkBoxC.TabIndex = 0;
            this.checkBoxC.Text = "C";
            this.checkBoxC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxC.UseVisualStyleBackColor = false;
            // 
            // checkBoxD
            // 
            this.checkBoxD.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBoxD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBoxD.FlatAppearance.BorderSize = 3;
            this.checkBoxD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.checkBoxD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxD.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxD.ForeColor = System.Drawing.Color.White;
            this.checkBoxD.Location = new System.Drawing.Point(205, 208);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(58, 60);
            this.checkBoxD.TabIndex = 0;
            this.checkBoxD.Text = "D";
            this.checkBoxD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxD.UseVisualStyleBackColor = false;
            // 
            // tmrClearScreen
            // 
            this.tmrClearScreen.Interval = 1000;
            this.tmrClearScreen.Tick += new System.EventHandler(this.tmrClearScreen_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(129)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(276, 281);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Arduino StreamDeck";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox0;
        private System.Windows.Forms.CheckBox chkAsterisco;
        private System.Windows.Forms.CheckBox chkNumeral;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.Timer tmrClearScreen;
    }
}

