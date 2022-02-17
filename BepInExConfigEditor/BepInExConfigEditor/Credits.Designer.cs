
namespace BepInExConfigEditor
{
    partial class Credits
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.CreditsTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.White;
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.BackBtn.Location = new System.Drawing.Point(0, 608);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(1000, 42);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CreditsTextBox
            // 
            this.CreditsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreditsTextBox.Enabled = false;
            this.CreditsTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditsTextBox.ForeColor = System.Drawing.Color.Green;
            this.CreditsTextBox.Location = new System.Drawing.Point(0, 0);
            this.CreditsTextBox.Name = "CreditsTextBox";
            this.CreditsTextBox.Size = new System.Drawing.Size(1000, 608);
            this.CreditsTextBox.TabIndex = 1;
            this.CreditsTextBox.TabStop = false;
            this.CreditsTextBox.Text = "\n    Idea: A Haunted Army#2861 (AHauntedArmy GitHub)\n\n    Developer: JJoe#4865 (j" +
    "ona939s GitHub)\n\n    Contributers: Modders using .cfg files for configuration";
            this.CreditsTextBox.TextChanged += new System.EventHandler(this.CreditsTextBox_TextChanged);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.CreditsTextBox);
            this.Controls.Add(this.BackBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Credits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credits";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.RichTextBox CreditsTextBox;
    }
}