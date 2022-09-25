
namespace pureControlClient
{
    partial class mainScreen
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
            this.TBDataToSend = new System.Windows.Forms.TextBox();
            this.BTNSendData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBDataToSend
            // 
            this.TBDataToSend.Location = new System.Drawing.Point(81, 32);
            this.TBDataToSend.Name = "TBDataToSend";
            this.TBDataToSend.Size = new System.Drawing.Size(187, 20);
            this.TBDataToSend.TabIndex = 0;
            this.TBDataToSend.Text = "Default text";
            // 
            // BTNSendData
            // 
            this.BTNSendData.Location = new System.Drawing.Point(314, 28);
            this.BTNSendData.Name = "BTNSendData";
            this.BTNSendData.Size = new System.Drawing.Size(75, 23);
            this.BTNSendData.TabIndex = 1;
            this.BTNSendData.Text = "Send";
            this.BTNSendData.UseVisualStyleBackColor = true;
            this.BTNSendData.Click += new System.EventHandler(this.BTNSendData_Click);
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNSendData);
            this.Controls.Add(this.TBDataToSend);
            this.Name = "mainScreen";
            this.Text = "mainScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBDataToSend;
        private System.Windows.Forms.Button BTNSendData;
    }
}

