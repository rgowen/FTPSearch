namespace FTPSearch
{
    partial class MainGUI
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textboxAddresses = new System.Windows.Forms.RichTextBox();
            this.labelServers = new System.Windows.Forms.Label();
            this.textboxOutput = new System.Windows.Forms.RichTextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.buttonConnect.Location = new System.Drawing.Point(800, 60);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "search";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // textboxAddresses
            // 
            this.textboxAddresses.BackColor = System.Drawing.Color.White;
            this.textboxAddresses.DetectUrls = false;
            this.textboxAddresses.Location = new System.Drawing.Point(615, 60);
            this.textboxAddresses.Name = "textboxAddresses";
            this.textboxAddresses.Size = new System.Drawing.Size(179, 183);
            this.textboxAddresses.TabIndex = 1;
            this.textboxAddresses.Text = "";
            this.textboxAddresses.TextChanged += new System.EventHandler(this.textboxAddresses_TextChanged);
            // 
            // labelServers
            // 
            this.labelServers.AutoSize = true;
            this.labelServers.Location = new System.Drawing.Point(612, 44);
            this.labelServers.Name = "labelServers";
            this.labelServers.Size = new System.Drawing.Size(43, 13);
            this.labelServers.TabIndex = 2;
            this.labelServers.Text = "Servers";
            // 
            // textboxOutput
            // 
            this.textboxOutput.DetectUrls = false;
            this.textboxOutput.Location = new System.Drawing.Point(12, 60);
            this.textboxOutput.Name = "textboxOutput";
            this.textboxOutput.Size = new System.Drawing.Size(597, 464);
            this.textboxOutput.TabIndex = 3;
            this.textboxOutput.Text = "";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(9, 44);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(39, 13);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Output";
            this.labelOutput.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(297, 24);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(221, 20);
            this.textBoxQuery.TabIndex = 6;
            this.textBoxQuery.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search query:";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuery);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.textboxOutput);
            this.Controls.Add(this.labelServers);
            this.Controls.Add(this.textboxAddresses);
            this.Controls.Add(this.buttonConnect);
            this.Name = "MainGUI";
            this.Text = "ftp";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.RichTextBox textboxAddresses;
        private System.Windows.Forms.Label labelServers;
        private System.Windows.Forms.RichTextBox textboxOutput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Label label1;
    }
}

