namespace WinFormsAppWeather
{
    partial class Form1
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
            btnRefill = new Button();
            txtInfo = new RichTextBox();
            txtOut = new RichTextBox();
            btnGet = new Button();
            SuspendLayout();
            // 
            // btnRefill
            // 
            btnRefill.Font = new Font("Segoe UI", 12F);
            btnRefill.Location = new Point(13, 12);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(307, 33);
            btnRefill.TabIndex = 0;
            btnRefill.Text = "Перезаполнить";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Font = new Font("Segoe UI", 12F);
            txtInfo.Location = new Point(13, 51);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(276, 46);
            txtInfo.TabIndex = 1;
            txtInfo.Text = "";
            // 
            // txtOut
            // 
            txtOut.Font = new Font("Segoe UI", 12F);
            txtOut.Location = new Point(13, 103);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(226, 118);
            txtOut.TabIndex = 2;
            txtOut.Text = "";
            // 
            // btnGet
            // 
            btnGet.Font = new Font("Segoe UI", 12F);
            btnGet.Location = new Point(245, 103);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(75, 118);
            btnGet.TabIndex = 3;
            btnGet.Text = "Взять";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 233);
            Controls.Add(btnGet);
            Controls.Add(txtOut);
            Controls.Add(txtInfo);
            Controls.Add(btnRefill);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Прогноз погоды";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefill;
        private RichTextBox txtInfo;
        private RichTextBox txtOut;
        private Button btnGet;
    }
}
