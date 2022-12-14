namespace PuTTyAutomation_2
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.runHT = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.COM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(74, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 27);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(74, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "Router Password Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(74, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 71);
            this.button3.TabIndex = 3;
            this.button3.Text = "Switch Password Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // runHT
            // 
            this.runHT.BackColor = System.Drawing.Color.PowderBlue;
            this.runHT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runHT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runHT.Location = new System.Drawing.Point(9, 282);
            this.runHT.Name = "runHT";
            this.runHT.Size = new System.Drawing.Size(133, 74);
            this.runHT.TabIndex = 4;
            this.runHT.Text = "Run HyperTerminal";
            this.runHT.UseVisualStyleBackColor = false;
            this.runHT.Click += new System.EventHandler(this.runHT_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PowderBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(148, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 74);
            this.button4.TabIndex = 5;
            this.button4.Text = "Run PuTTy";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.runPutty_click);
            // 
            // COM
            // 
            this.COM.AutoSize = true;
            this.COM.BackColor = System.Drawing.Color.Transparent;
            this.COM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.COM.Location = new System.Drawing.Point(90, 27);
            this.COM.Name = "COM";
            this.COM.Size = new System.Drawing.Size(104, 20);
            this.COM.TabIndex = 6;
            this.COM.Text = "COM PORT:";
            this.COM.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(288, 391);
            this.Controls.Add(this.COM);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.runHT);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Text = "ResetRoutersSwitches";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button runHT;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label COM;
    }
}

