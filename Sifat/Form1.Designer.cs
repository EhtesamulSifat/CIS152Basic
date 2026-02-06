namespace Sifat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDogOwner = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumPerWeek = new System.Windows.Forms.TextBox();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dog Walker Weekly Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dog Owner";
            // 
            // txtDogOwner
            // 
            this.txtDogOwner.Location = new System.Drawing.Point(214, 100);
            this.txtDogOwner.Margin = new System.Windows.Forms.Padding(6);
            this.txtDogOwner.Name = "txtDogOwner";
            this.txtDogOwner.Size = new System.Drawing.Size(604, 31);
            this.txtDogOwner.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(70, 553);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(150, 48);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number Of Walks Per Week";
            // 
            // txtNumPerWeek
            // 
            this.txtNumPerWeek.Location = new System.Drawing.Point(344, 176);
            this.txtNumPerWeek.Name = "txtNumPerWeek";
            this.txtNumPerWeek.Size = new System.Drawing.Size(474, 31);
            this.txtNumPerWeek.TabIndex = 4;
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.ItemHeight = 25;
            this.lstOut.Location = new System.Drawing.Point(70, 255);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(785, 204);
            this.lstOut.TabIndex = 5;
            this.lstOut.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(407, 553);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 44);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(747, 557);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(99, 44);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 651);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.txtNumPerWeek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtDogOwner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Sifat\'s Dog walking Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDogOwner;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumPerWeek;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnQuit;
    }
}

