namespace Winforms
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
            this.Button_SomethingUseful = new System.Windows.Forms.Button();
            this.checkBox_FailSafe = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_doomsDay = new System.Windows.Forms.DateTimePicker();
            this.label_DontTouch = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox_box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_box)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_SomethingUseful
            // 
            this.Button_SomethingUseful.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_SomethingUseful.Location = new System.Drawing.Point(166, 178);
            this.Button_SomethingUseful.Name = "Button_SomethingUseful";
            this.Button_SomethingUseful.Size = new System.Drawing.Size(106, 41);
            this.Button_SomethingUseful.TabIndex = 0;
            this.Button_SomethingUseful.Text = "Something Useful";
            this.Button_SomethingUseful.UseVisualStyleBackColor = true;
            this.Button_SomethingUseful.Click += new System.EventHandler(this.SomethingUseful_Click);
            // 
            // checkBox_FailSafe
            // 
            this.checkBox_FailSafe.AutoSize = true;
            this.checkBox_FailSafe.Location = new System.Drawing.Point(166, 81);
            this.checkBox_FailSafe.Name = "checkBox_FailSafe";
            this.checkBox_FailSafe.Size = new System.Drawing.Size(67, 17);
            this.checkBox_FailSafe.TabIndex = 1;
            this.checkBox_FailSafe.Text = "Fail Safe";
            this.checkBox_FailSafe.UseVisualStyleBackColor = true;
            this.checkBox_FailSafe.CheckedChanged += new System.EventHandler(this.checkBox_FailSafe_CheckedChanged);
            // 
            // dateTimePicker_doomsDay
            // 
            this.dateTimePicker_doomsDay.Location = new System.Drawing.Point(166, 131);
            this.dateTimePicker_doomsDay.Name = "dateTimePicker_doomsDay";
            this.dateTimePicker_doomsDay.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_doomsDay.TabIndex = 2;
            // 
            // label_DontTouch
            // 
            this.label_DontTouch.AutoSize = true;
            this.label_DontTouch.Location = new System.Drawing.Point(167, 41);
            this.label_DontTouch.Name = "label_DontTouch";
            this.label_DontTouch.Size = new System.Drawing.Size(66, 13);
            this.label_DontTouch.TabIndex = 3;
            this.label_DontTouch.Text = "Don\'t Touch";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(430, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox_box
            // 
            this.pictureBox_box.Location = new System.Drawing.Point(430, 178);
            this.pictureBox_box.Name = "pictureBox_box";
            this.pictureBox_box.Size = new System.Drawing.Size(358, 272);
            this.pictureBox_box.TabIndex = 4;
            this.pictureBox_box.TabStop = false;
            this.pictureBox_box.Click += new System.EventHandler(this.pictureBox_box_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox_box);
            this.Controls.Add(this.label_DontTouch);
            this.Controls.Add(this.dateTimePicker_doomsDay);
            this.Controls.Add(this.checkBox_FailSafe);
            this.Controls.Add(this.Button_SomethingUseful);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_SomethingUseful;
        private System.Windows.Forms.CheckBox checkBox_FailSafe;
        private System.Windows.Forms.DateTimePicker dateTimePicker_doomsDay;
        private System.Windows.Forms.Label label_DontTouch;
        private System.Windows.Forms.PictureBox pictureBox_box;
        private System.Windows.Forms.TextBox textBox1;
    }
}

