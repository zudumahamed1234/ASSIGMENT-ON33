namespace assigment11
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
            this.components = new System.ComponentModel.Container();
            this.txtdayofthemonth = new System.Windows.Forms.TextBox();
            this.txtdayoftheWeek = new System.Windows.Forms.TextBox();
            this.txtdayofthenumeric = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtyear = new System.Windows.Forms.TextBox();
            this.dayoftheweek = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.dayofthemonth = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.lbldatoutput = new System.Windows.Forms.Label();
            this.showDate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdayofthemonth
            // 
            this.txtdayofthemonth.Location = new System.Drawing.Point(482, 96);
            this.txtdayofthemonth.Name = "txtdayofthemonth";
            this.txtdayofthemonth.Size = new System.Drawing.Size(186, 22);
            this.txtdayofthemonth.TabIndex = 0;
            // 
            // txtdayoftheWeek
            // 
            this.txtdayoftheWeek.Location = new System.Drawing.Point(482, 68);
            this.txtdayoftheWeek.Name = "txtdayoftheWeek";
            this.txtdayoftheWeek.Size = new System.Drawing.Size(186, 22);
            this.txtdayoftheWeek.TabIndex = 1;
            this.txtdayoftheWeek.TextChanged += new System.EventHandler(this.txtdayoftheWee_TextChanged);
            // 
            // txtdayofthenumeric
            // 
            this.txtdayofthenumeric.Location = new System.Drawing.Point(482, 124);
            this.txtdayofthenumeric.Name = "txtdayofthenumeric";
            this.txtdayofthenumeric.Size = new System.Drawing.Size(186, 22);
            this.txtdayofthenumeric.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(482, 152);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(186, 22);
            this.txtyear.TabIndex = 4;
            // 
            // dayoftheweek
            // 
            this.dayoftheweek.AutoSize = true;
            this.dayoftheweek.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayoftheweek.Location = new System.Drawing.Point(165, 65);
            this.dayoftheweek.Name = "dayoftheweek";
            this.dayoftheweek.Size = new System.Drawing.Size(311, 31);
            this.dayoftheweek.TabIndex = 5;
            this.dayoftheweek.Text = "Enter the day of the week";
            this.dayoftheweek.Click += new System.EventHandler(this.label1_Click);
            // 
            // month
            // 
            this.month.AutoSize = true;
            this.month.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month.Location = new System.Drawing.Point(137, 95);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(339, 29);
            this.month.TabIndex = 6;
            this.month.Text = "Enter the name of the month";
            // 
            // dayofthemonth
            // 
            this.dayofthemonth.AutoSize = true;
            this.dayofthemonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayofthemonth.Location = new System.Drawing.Point(60, 123);
            this.dayofthemonth.Name = "dayofthemonth";
            this.dayofthemonth.Size = new System.Drawing.Size(416, 29);
            this.dayofthemonth.TabIndex = 7;
            this.dayofthemonth.Text = "Enter the numeric day of the month";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(301, 152);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(175, 29);
            this.year.TabIndex = 8;
            this.year.Text = "Enter the year";
            // 
            // lbldatoutput
            // 
            this.lbldatoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldatoutput.Location = new System.Drawing.Point(187, 217);
            this.lbldatoutput.Name = "lbldatoutput";
            this.lbldatoutput.Size = new System.Drawing.Size(408, 42);
            this.lbldatoutput.TabIndex = 9;
            this.lbldatoutput.Click += new System.EventHandler(this.dateOutput_Click);
            // 
            // showDate
            // 
            this.showDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDate.Location = new System.Drawing.Point(199, 317);
            this.showDate.Name = "showDate";
            this.showDate.Size = new System.Drawing.Size(96, 23);
            this.showDate.TabIndex = 10;
            this.showDate.Text = "showDate";
            this.showDate.UseVisualStyleBackColor = true;
            this.showDate.Click += new System.EventHandler(this.showDate_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(411, 317);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(566, 317);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 12;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.showDate);
            this.Controls.Add(this.lbldatoutput);
            this.Controls.Add(this.year);
            this.Controls.Add(this.dayofthemonth);
            this.Controls.Add(this.month);
            this.Controls.Add(this.dayoftheweek);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtdayofthenumeric);
            this.Controls.Add(this.txtdayoftheWeek);
            this.Controls.Add(this.txtdayofthemonth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdayofthemonth;
        private System.Windows.Forms.TextBox txtdayoftheWeek;
        private System.Windows.Forms.TextBox txtdayofthenumeric;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label dayoftheweek;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.Label dayofthemonth;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label lbldatoutput;
        private System.Windows.Forms.Button showDate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
    }
}

