
namespace unique_id_gui
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.AvailablePortsBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectToPort = new System.Windows.Forms.Button();
            this.ReceivedDataBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SendSerialButton = new System.Windows.Forms.Button();
            this.SenderTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AvailablePortsBox
            // 
            this.AvailablePortsBox.FormattingEnabled = true;
            this.AvailablePortsBox.Location = new System.Drawing.Point(12, 25);
            this.AvailablePortsBox.Name = "AvailablePortsBox";
            this.AvailablePortsBox.Size = new System.Drawing.Size(121, 21);
            this.AvailablePortsBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Port";
            // 
            // ConnectToPort
            // 
            this.ConnectToPort.Location = new System.Drawing.Point(12, 52);
            this.ConnectToPort.Name = "ConnectToPort";
            this.ConnectToPort.Size = new System.Drawing.Size(121, 23);
            this.ConnectToPort.TabIndex = 2;
            this.ConnectToPort.Text = "Connect";
            this.ConnectToPort.UseVisualStyleBackColor = true;
            this.ConnectToPort.Click += new System.EventHandler(this.ConnectToPort_Click);
            // 
            // ReceivedDataBox
            // 
            this.ReceivedDataBox.Location = new System.Drawing.Point(139, 25);
            this.ReceivedDataBox.Multiline = true;
            this.ReceivedDataBox.Name = "ReceivedDataBox";
            this.ReceivedDataBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReceivedDataBox.Size = new System.Drawing.Size(184, 159);
            this.ReceivedDataBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Received Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Command";
            // 
            // SendSerialButton
            // 
            this.SendSerialButton.Location = new System.Drawing.Point(12, 239);
            this.SendSerialButton.Name = "SendSerialButton";
            this.SendSerialButton.Size = new System.Drawing.Size(121, 23);
            this.SendSerialButton.TabIndex = 7;
            this.SendSerialButton.Text = "Send";
            this.SendSerialButton.UseVisualStyleBackColor = true;
            this.SendSerialButton.Click += new System.EventHandler(this.SendSerialButton_Click);
            // 
            // SenderTextBox
            // 
            this.SenderTextBox.Location = new System.Drawing.Point(12, 213);
            this.SenderTextBox.Name = "SenderTextBox";
            this.SenderTextBox.Size = new System.Drawing.Size(121, 20);
            this.SenderTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 271);
            this.Controls.Add(this.SenderTextBox);
            this.Controls.Add(this.SendSerialButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReceivedDataBox);
            this.Controls.Add(this.ConnectToPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AvailablePortsBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox AvailablePortsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnectToPort;
        private System.Windows.Forms.TextBox ReceivedDataBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SendSerialButton;
        private System.Windows.Forms.TextBox SenderTextBox;
    }
}

