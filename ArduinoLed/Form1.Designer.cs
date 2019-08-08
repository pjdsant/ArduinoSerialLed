namespace ArduinoLed
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
            this.btnLedOn = new System.Windows.Forms.Button();
            this.btnLedOff = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.bntConverter = new System.Windows.Forms.Button();
            this.txtConverter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLedOn
            // 
            this.btnLedOn.Location = new System.Drawing.Point(52, 35);
            this.btnLedOn.Name = "btnLedOn";
            this.btnLedOn.Size = new System.Drawing.Size(171, 89);
            this.btnLedOn.TabIndex = 0;
            this.btnLedOn.Text = "LED On";
            this.btnLedOn.UseVisualStyleBackColor = true;
            this.btnLedOn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLedOff
            // 
            this.btnLedOff.Location = new System.Drawing.Point(305, 35);
            this.btnLedOff.Name = "btnLedOff";
            this.btnLedOff.Size = new System.Drawing.Size(171, 88);
            this.btnLedOff.TabIndex = 1;
            this.btnLedOff.Text = "LED Off";
            this.btnLedOff.UseVisualStyleBackColor = true;
            this.btnLedOff.Click += new System.EventHandler(this.btnLedOff_Click);
            // 
            // bntConverter
            // 
            this.bntConverter.Location = new System.Drawing.Point(52, 278);
            this.bntConverter.Name = "bntConverter";
            this.bntConverter.Size = new System.Drawing.Size(117, 31);
            this.bntConverter.TabIndex = 2;
            this.bntConverter.Text = "UnicodeToAscII";
            this.bntConverter.UseVisualStyleBackColor = true;
            // 
            // txtConverter
            // 
            this.txtConverter.Location = new System.Drawing.Point(52, 238);
            this.txtConverter.Name = "txtConverter";
            this.txtConverter.Size = new System.Drawing.Size(423, 20);
            this.txtConverter.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 445);
            this.Controls.Add(this.txtConverter);
            this.Controls.Add(this.bntConverter);
            this.Controls.Add(this.btnLedOff);
            this.Controls.Add(this.btnLedOn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLedOn;
        private System.Windows.Forms.Button btnLedOff;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button bntConverter;
        private System.Windows.Forms.TextBox txtConverter;
    }
}

