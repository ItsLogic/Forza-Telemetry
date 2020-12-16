
namespace Forza_Telemetry
{
    partial class ForzaTelemetry
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Test1 = new System.Windows.Forms.Button();
            this.TextBox_UDPOutput = new System.Windows.Forms.RichTextBox();
            this.TextBox_UDPOutput2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BTN_Test1
            // 
            this.BTN_Test1.Location = new System.Drawing.Point(12, 891);
            this.BTN_Test1.Name = "BTN_Test1";
            this.BTN_Test1.Size = new System.Drawing.Size(1122, 41);
            this.BTN_Test1.TabIndex = 0;
            this.BTN_Test1.Text = "Start";
            this.BTN_Test1.UseVisualStyleBackColor = true;
            this.BTN_Test1.Click += new System.EventHandler(this.BTN_Test1_Click);
            // 
            // TextBox_UDPOutput
            // 
            this.TextBox_UDPOutput.Location = new System.Drawing.Point(12, 12);
            this.TextBox_UDPOutput.Name = "TextBox_UDPOutput";
            this.TextBox_UDPOutput.Size = new System.Drawing.Size(550, 873);
            this.TextBox_UDPOutput.TabIndex = 1;
            this.TextBox_UDPOutput.Text = "";
            // 
            // TextBox_UDPOutput2
            // 
            this.TextBox_UDPOutput2.Location = new System.Drawing.Point(584, 12);
            this.TextBox_UDPOutput2.Name = "TextBox_UDPOutput2";
            this.TextBox_UDPOutput2.Size = new System.Drawing.Size(550, 873);
            this.TextBox_UDPOutput2.TabIndex = 2;
            this.TextBox_UDPOutput2.Text = "";
            // 
            // ForzaTelemetry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 944);
            this.Controls.Add(this.TextBox_UDPOutput2);
            this.Controls.Add(this.TextBox_UDPOutput);
            this.Controls.Add(this.BTN_Test1);
            this.Name = "ForzaTelemetry";
            this.Text = "Forza Telemetry";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Test1;
        private System.Windows.Forms.RichTextBox TextBox_UDPOutput;
        private System.Windows.Forms.RichTextBox TextBox_UDPOutput2;
    }
}

