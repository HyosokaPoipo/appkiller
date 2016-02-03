namespace KillerApps
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
            this.listBoxApps = new System.Windows.Forms.ListBox();
            this.killerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxApps
            // 
            this.listBoxApps.FormattingEnabled = true;
            this.listBoxApps.HorizontalScrollbar = true;
            this.listBoxApps.Location = new System.Drawing.Point(23, 34);
            this.listBoxApps.Name = "listBoxApps";
            this.listBoxApps.ScrollAlwaysVisible = true;
            this.listBoxApps.Size = new System.Drawing.Size(373, 342);
            this.listBoxApps.Sorted = true;
            this.listBoxApps.TabIndex = 0;
            // 
            // killerButton
            // 
            this.killerButton.Location = new System.Drawing.Point(469, 194);
            this.killerButton.Name = "killerButton";
            this.killerButton.Size = new System.Drawing.Size(88, 23);
            this.killerButton.TabIndex = 1;
            this.killerButton.Text = "Kill Process";
            this.killerButton.UseVisualStyleBackColor = true;
            this.killerButton.Click += new System.EventHandler(this.killerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 403);
            this.Controls.Add(this.killerButton);
            this.Controls.Add(this.listBoxApps);
            this.Name = "Form1";
            this.Text = "AppKiller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxApps;
        private System.Windows.Forms.Button killerButton;
    }
}

