
namespace BepInExConfigEditor
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
            this.Browse = new System.Windows.Forms.Button();
            this.ConfigFilePath = new System.Windows.Forms.TextBox();
            this.ConfigBox = new System.Windows.Forms.ListBox();
            this.ReloadBtn = new System.Windows.Forms.Button();
            this.TextEditor = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CreditBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.White;
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Browse.Location = new System.Drawing.Point(909, 1);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 20);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConfigFilePath
            // 
            this.ConfigFilePath.BackColor = System.Drawing.Color.DarkGray;
            this.ConfigFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfigFilePath.Location = new System.Drawing.Point(1, 1);
            this.ConfigFilePath.Name = "ConfigFilePath";
            this.ConfigFilePath.ReadOnly = true;
            this.ConfigFilePath.Size = new System.Drawing.Size(902, 20);
            this.ConfigFilePath.TabIndex = 1;
            // 
            // ConfigBox
            // 
            this.ConfigBox.FormattingEnabled = true;
            this.ConfigBox.Location = new System.Drawing.Point(12, 40);
            this.ConfigBox.Name = "ConfigBox";
            this.ConfigBox.Size = new System.Drawing.Size(280, 563);
            this.ConfigBox.TabIndex = 2;
            this.ConfigBox.SelectedIndexChanged += new System.EventHandler(this.ConfigBox_SelectedIndexChanged);
            // 
            // ReloadBtn
            // 
            this.ReloadBtn.BackColor = System.Drawing.Color.White;
            this.ReloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReloadBtn.Location = new System.Drawing.Point(298, 580);
            this.ReloadBtn.Name = "ReloadBtn";
            this.ReloadBtn.Size = new System.Drawing.Size(75, 23);
            this.ReloadBtn.TabIndex = 3;
            this.ReloadBtn.Text = "Reload";
            this.ReloadBtn.UseVisualStyleBackColor = false;
            this.ReloadBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
            // 
            // TextEditor
            // 
            this.TextEditor.AcceptsTab = true;
            this.TextEditor.AutoWordSelection = true;
            this.TextEditor.Location = new System.Drawing.Point(379, 40);
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.Size = new System.Drawing.Size(593, 563);
            this.TextEditor.TabIndex = 4;
            this.TextEditor.Text = "Press reload to load all config files in.\n\nAfter that press a config file and edi" +
    "t its values over here\n";
            this.TextEditor.TextChanged += new System.EventHandler(this.TextEditor_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(298, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save edits";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CreditBtn
            // 
            this.CreditBtn.BackColor = System.Drawing.Color.White;
            this.CreditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreditBtn.Location = new System.Drawing.Point(298, 40);
            this.CreditBtn.Name = "CreditBtn";
            this.CreditBtn.Size = new System.Drawing.Size(75, 23);
            this.CreditBtn.TabIndex = 6;
            this.CreditBtn.Text = "Credit";
            this.CreditBtn.UseVisualStyleBackColor = false;
            this.CreditBtn.Click += new System.EventHandler(this.CreditBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.CreditBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextEditor);
            this.Controls.Add(this.ReloadBtn);
            this.Controls.Add(this.ConfigBox);
            this.Controls.Add(this.ConfigFilePath);
            this.Controls.Add(this.Browse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BepInExConfigManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox ConfigFilePath;
        private System.Windows.Forms.ListBox ConfigBox;
        private System.Windows.Forms.Button ReloadBtn;
        private System.Windows.Forms.RichTextBox TextEditor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CreditBtn;
    }
}

