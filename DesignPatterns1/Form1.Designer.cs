namespace DesignPatterns1
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
            this.connectButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.buttonAdvancedFriendSearch = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(31, 25);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(69, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(31, 79);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 95);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(279, 79);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(120, 95);
            this.listBoxFriends.TabIndex = 2;
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Location = new System.Drawing.Point(279, 25);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(120, 23);
            this.buttonFetchFriends.TabIndex = 3;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(31, 211);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(107, 23);
            this.buttonPostStatus.TabIndex = 4;
            this.buttonPostStatus.Text = "Post Status";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(31, 240);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(178, 20);
            this.textBoxStatus.TabIndex = 5;
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(31, 54);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(102, 17);
            this.checkBoxRememberUser.TabIndex = 6;
            this.checkBoxRememberUser.Text = "Remember User";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // buttonAdvancedFriendSearch
            // 
            this.buttonAdvancedFriendSearch.Location = new System.Drawing.Point(423, 25);
            this.buttonAdvancedFriendSearch.Name = "buttonAdvancedFriendSearch";
            this.buttonAdvancedFriendSearch.Size = new System.Drawing.Size(220, 23);
            this.buttonAdvancedFriendSearch.TabIndex = 7;
            this.buttonAdvancedFriendSearch.Text = "Perform Advanced Friend Search";
            this.buttonAdvancedFriendSearch.UseVisualStyleBackColor = true;
            this.buttonAdvancedFriendSearch.Click += new System.EventHandler(this.buttonAdvancedFriendSearch_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(106, 25);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 8;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDisconnect_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 378);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonAdvancedFriendSearch);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.buttonFetchFriends);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.Button buttonAdvancedFriendSearch;
        private System.Windows.Forms.Button buttonDisconnect;
    }
}

