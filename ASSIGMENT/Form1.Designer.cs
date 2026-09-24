namespace ASSIGMENT
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
            this.txtdayoftheWeek = new System.Windows.Forms.TextBox();
            this.txtdayofthemonth = new System.Windows.Forms.TextBox();
            this.txtdayofthenumeric = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.dayOfWeekTextBox = new System.Windows.Forms.Label();
            this.monthTextBox = new System.Windows.Forms.Label();
            this.dayOfMonthTextBox = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.Label();
            this.lbldatoutput = new System.Windows.Forms.Label();
            this.showdatebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdayoftheWeek
            // 
            this.txtdayoftheWeek.Location = new System.Drawing.Point(474, 43);
            this.txtdayoftheWeek.Name = "txtdayoftheWeek";
            this.txtdayoftheWeek.Size = new System.Drawing.Size(228, 22);
            this.txtdayoftheWeek.TabIndex = 0;
            this.txtdayoftheWeek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtdayofthemonth
            // 
            this.txtdayofthemonth.Location = new System.Drawing.Point(474, 71);
            this.txtdayofthemonth.Name = "txtdayofthemonth";
            this.txtdayofthemonth.Size = new System.Drawing.Size(228, 22);
            this.txtdayofthemonth.TabIndex = 1;
            this.txtdayofthemonth.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtdayofthenumeric
            // 
            this.txtdayofthenumeric.Location = new System.Drawing.Point(474, 104);
            this.txtdayofthenumeric.Name = "txtdayofthenumeric";
            this.txtdayofthenumeric.Size = new System.Drawing.Size(228, 22);
            this.txtdayofthenumeric.TabIndex = 2;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(474, 132);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(228, 22);
            this.txtyear.TabIndex = 3;
            // 
            // dayOfWeekTextBox
            // 
            this.dayOfWeekTextBox.AutoSize = true;
            this.dayOfWeekTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOfWeekTextBox.Location = new System.Drawing.Point(137, 33);
            this.dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            this.dayOfWeekTextBox.Size = new System.Drawing.Size(311, 31);
            this.dayOfWeekTextBox.TabIndex = 4;
            this.dayOfWeekTextBox.Text = "Enter the day of the week";
            // 
            // monthTextBox
            // 
            this.monthTextBox.AutoSize = true;
            this.monthTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthTextBox.Location = new System.Drawing.Point(96, 68);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(352, 31);
            this.monthTextBox.TabIndex = 5;
            this.monthTextBox.Text = "Enter the name of the month";
            // 
            // dayOfMonthTextBox
            // 
            this.dayOfMonthTextBox.AutoSize = true;
            this.dayOfMonthTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOfMonthTextBox.Location = new System.Drawing.Point(17, 101);
            this.dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            this.dayOfMonthTextBox.Size = new System.Drawing.Size(431, 31);
            this.dayOfMonthTextBox.TabIndex = 6;
            this.dayOfMonthTextBox.Text = "Enter the numeric day of the month";
            // 
            // yearTextBox
            // 
            this.yearTextBox.AutoSize = true;
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextBox.Location = new System.Drawing.Point(272, 132);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(176, 31);
            this.yearTextBox.TabIndex = 7;
            this.yearTextBox.Text = "Enter the year";
            // 
            // lbldatoutput
            // 
            this.lbldatoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldatoutput.Location = new System.Drawing.Point(158, 200);
            this.lbldatoutput.Name = "lbldatoutput";
            this.lbldatoutput.Size = new System.Drawing.Size(476, 50);
            this.lbldatoutput.TabIndex = 8;
            // 
            // showdatebutton
            // 
            this.showdatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showdatebutton.Location = new System.Drawing.Point(135, 319);
            this.showdatebutton.Name = "showdatebutton";
            this.showdatebutton.Size = new System.Drawing.Size(108, 30);
            this.showdatebutton.TabIndex = 9;
            this.showdatebutton.Text = "Show date";
            this.showdatebutton.UseVisualStyleBackColor = true;
            this.showdatebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.Location = new System.Drawing.Point(327, 319);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(108, 30);
            this.clearbutton.TabIndex = 10;
            this.clearbutton.Text = "clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.Location = new System.Drawing.Point(526, 319);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(108, 30);
            this.exitbutton.TabIndex = 11;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.showdatebutton);
            this.Controls.Add(this.lbldatoutput);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayOfMonthTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.dayOfWeekTextBox);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtdayofthenumeric);
            this.Controls.Add(this.txtdayofthemonth);
            this.Controls.Add(this.txtdayoftheWeek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdayoftheWeek;
        private System.Windows.Forms.TextBox txtdayofthemonth;
        private System.Windows.Forms.TextBox txtdayofthenumeric;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label dayOfWeekTextBox;
        private System.Windows.Forms.Label monthTextBox;
        private System.Windows.Forms.Label dayOfMonthTextBox;
        private System.Windows.Forms.Label yearTextBox;
        private System.Windows.Forms.Label lbldatoutput;
        private System.Windows.Forms.Button showdatebutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}

