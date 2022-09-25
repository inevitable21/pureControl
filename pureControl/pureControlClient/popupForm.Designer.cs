
namespace pureControlClient
{
    partial class popupForm
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
            this.greetings = new System.Windows.Forms.Label();
            this.LBLsent = new System.Windows.Forms.Label();
            this.DataSent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // greetings
            // 
            this.greetings.AutoSize = true;
            this.greetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.greetings.Location = new System.Drawing.Point(23, 22);
            this.greetings.Name = "greetings";
            this.greetings.Size = new System.Drawing.Size(363, 29);
            this.greetings.TabIndex = 0;
            this.greetings.Text = "You have sent data successfully!!";
            // 
            // LBLsent
            // 
            this.LBLsent.AutoSize = true;
            this.LBLsent.Location = new System.Drawing.Point(52, 92);
            this.LBLsent.Name = "LBLsent";
            this.LBLsent.Size = new System.Drawing.Size(32, 13);
            this.LBLsent.TabIndex = 1;
            this.LBLsent.Text = "Sent:";
            // 
            // DataSent
            // 
            this.DataSent.AutoSize = true;
            this.DataSent.Location = new System.Drawing.Point(90, 92);
            this.DataSent.Name = "DataSent";
            this.DataSent.Size = new System.Drawing.Size(52, 13);
            this.DataSent.TabIndex = 2;
            this.DataSent.Text = "DataSent";
            // 
            // popupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 170);
            this.Controls.Add(this.DataSent);
            this.Controls.Add(this.LBLsent);
            this.Controls.Add(this.greetings);
            this.Name = "popupForm";
            this.Text = "popupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetings;
        private System.Windows.Forms.Label LBLsent;
        private System.Windows.Forms.Label DataSent;
    }
}