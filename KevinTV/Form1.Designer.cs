namespace KevinTV
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
            this.ofdHTML = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenHTML = new System.Windows.Forms.Button();
            this.lblChannelCount = new System.Windows.Forms.Label();
            this.btnOpenPython = new System.Windows.Forms.Button();
            this.ofdPython = new System.Windows.Forms.OpenFileDialog();
            this.lblDone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ofdHTML
            // 
            this.ofdHTML.Filter = "HTML-files|*.htm;*.html|All files|*.*";
            this.ofdHTML.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdHTML_FileOk);
            // 
            // btnOpenHTML
            // 
            this.btnOpenHTML.Location = new System.Drawing.Point(12, 12);
            this.btnOpenHTML.Name = "btnOpenHTML";
            this.btnOpenHTML.Size = new System.Drawing.Size(91, 23);
            this.btnOpenHTML.TabIndex = 0;
            this.btnOpenHTML.Text = "Åben HTML";
            this.btnOpenHTML.UseVisualStyleBackColor = true;
            this.btnOpenHTML.Click += new System.EventHandler(this.btnOpenHTML_Click);
            // 
            // lblChannelCount
            // 
            this.lblChannelCount.AutoSize = true;
            this.lblChannelCount.Location = new System.Drawing.Point(109, 17);
            this.lblChannelCount.Name = "lblChannelCount";
            this.lblChannelCount.Size = new System.Drawing.Size(84, 13);
            this.lblChannelCount.TabIndex = 2;
            this.lblChannelCount.Text = "lblChannelCount";
            // 
            // btnOpenPython
            // 
            this.btnOpenPython.Enabled = false;
            this.btnOpenPython.Location = new System.Drawing.Point(12, 41);
            this.btnOpenPython.Name = "btnOpenPython";
            this.btnOpenPython.Size = new System.Drawing.Size(91, 23);
            this.btnOpenPython.TabIndex = 3;
            this.btnOpenPython.Text = "Åben Python";
            this.btnOpenPython.UseVisualStyleBackColor = true;
            this.btnOpenPython.Click += new System.EventHandler(this.btnOpenPython_Click);
            // 
            // ofdPython
            // 
            this.ofdPython.Filter = "Python-files|*.py|All files|*.*";
            this.ofdPython.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdPython_FileOk);
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Location = new System.Drawing.Point(109, 46);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(43, 13);
            this.lblDone.TabIndex = 4;
            this.lblDone.Text = "lblDone";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 77);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.btnOpenPython);
            this.Controls.Add(this.lblChannelCount);
            this.Controls.Add(this.btnOpenHTML);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "KevinTV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdHTML;
        private System.Windows.Forms.Button btnOpenHTML;
        private System.Windows.Forms.Label lblChannelCount;
        private System.Windows.Forms.Button btnOpenPython;
        private System.Windows.Forms.OpenFileDialog ofdPython;
        private System.Windows.Forms.Label lblDone;

    }
}

