namespace DesignPatterns1
{
    partial class AdvancedFriendSearchForm
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
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.groupBoxContext = new System.Windows.Forms.GroupBox();
            this.groupBoxAge = new System.Windows.Forms.GroupBox();
            this.checkBoxStatuses = new System.Windows.Forms.CheckBox();
            this.checkBoxGroups = new System.Windows.Forms.CheckBox();
            this.checkBoxEvents = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxSex.SuspendLayout();
            this.groupBoxContext.SuspendLayout();
            this.groupBoxAge.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Location = new System.Drawing.Point(20, 19);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(49, 17);
            this.checkBoxMale.TabIndex = 0;
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Location = new System.Drawing.Point(20, 42);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(60, 17);
            this.checkBoxFemale.TabIndex = 1;
            this.checkBoxFemale.Text = "Female";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(627, 408);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(535, 408);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.Controls.Add(this.checkBoxMale);
            this.groupBoxSex.Controls.Add(this.checkBoxFemale);
            this.groupBoxSex.Location = new System.Drawing.Point(21, 21);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Size = new System.Drawing.Size(260, 73);
            this.groupBoxSex.TabIndex = 13;
            this.groupBoxSex.TabStop = false;
            this.groupBoxSex.Text = "Select Sex";
            // 
            // groupBoxContext
            // 
            this.groupBoxContext.Controls.Add(this.checkBoxEvents);
            this.groupBoxContext.Controls.Add(this.checkBoxGroups);
            this.groupBoxContext.Controls.Add(this.checkBoxStatuses);
            this.groupBoxContext.Location = new System.Drawing.Point(21, 108);
            this.groupBoxContext.Name = "groupBoxContext";
            this.groupBoxContext.Size = new System.Drawing.Size(305, 100);
            this.groupBoxContext.TabIndex = 14;
            this.groupBoxContext.TabStop = false;
            this.groupBoxContext.Text = "Search Context";
            // 
            // groupBoxAge
            // 
            this.groupBoxAge.Controls.Add(this.label4);
            this.groupBoxAge.Controls.Add(this.label3);
            this.groupBoxAge.Controls.Add(this.textBox3);
            this.groupBoxAge.Controls.Add(this.textBox2);
            this.groupBoxAge.Location = new System.Drawing.Point(21, 214);
            this.groupBoxAge.Name = "groupBoxAge";
            this.groupBoxAge.Size = new System.Drawing.Size(322, 84);
            this.groupBoxAge.TabIndex = 15;
            this.groupBoxAge.TabStop = false;
            this.groupBoxAge.Text = "Age";
            // 
            // checkBoxStatuses
            // 
            this.checkBoxStatuses.AutoSize = true;
            this.checkBoxStatuses.Location = new System.Drawing.Point(20, 19);
            this.checkBoxStatuses.Name = "checkBoxStatuses";
            this.checkBoxStatuses.Size = new System.Drawing.Size(67, 17);
            this.checkBoxStatuses.TabIndex = 0;
            this.checkBoxStatuses.Text = "Statuses";
            this.checkBoxStatuses.UseVisualStyleBackColor = true;
            // 
            // checkBoxGroups
            // 
            this.checkBoxGroups.AutoSize = true;
            this.checkBoxGroups.Location = new System.Drawing.Point(20, 42);
            this.checkBoxGroups.Name = "checkBoxGroups";
            this.checkBoxGroups.Size = new System.Drawing.Size(60, 17);
            this.checkBoxGroups.TabIndex = 1;
            this.checkBoxGroups.Text = "Groups";
            this.checkBoxGroups.UseVisualStyleBackColor = true;
            // 
            // checkBoxEvents
            // 
            this.checkBoxEvents.AutoSize = true;
            this.checkBoxEvents.Location = new System.Drawing.Point(20, 65);
            this.checkBoxEvents.Name = "checkBoxEvents";
            this.checkBoxEvents.Size = new System.Drawing.Size(59, 17);
            this.checkBoxEvents.TabIndex = 2;
            this.checkBoxEvents.Text = "Events";
            this.checkBoxEvents.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(21, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Free Text";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(74, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "from";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "to";
            // 
            // AdvancedFriendSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 458);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxAge);
            this.Controls.Add(this.groupBoxContext);
            this.Controls.Add(this.groupBoxSex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonCancel);
            this.Name = "AdvancedFriendSearchForm";
            this.Text = "AdvancedFriendSearchForm";
            this.Load += new System.EventHandler(this.AdvancedFriendSearchForm_Load);
            this.groupBoxSex.ResumeLayout(false);
            this.groupBoxSex.PerformLayout();
            this.groupBoxContext.ResumeLayout(false);
            this.groupBoxContext.PerformLayout();
            this.groupBoxAge.ResumeLayout(false);
            this.groupBoxAge.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxSex;
        private System.Windows.Forms.GroupBox groupBoxContext;
        private System.Windows.Forms.GroupBox groupBoxAge;
        private System.Windows.Forms.CheckBox checkBoxEvents;
        private System.Windows.Forms.CheckBox checkBoxGroups;
        private System.Windows.Forms.CheckBox checkBoxStatuses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}