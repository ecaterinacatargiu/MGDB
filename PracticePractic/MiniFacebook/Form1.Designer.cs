namespace MiniFacebook
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.dgvPosts = new System.Windows.Forms.DataGridView();
            this.labelUsers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.postDate = new System.Windows.Forms.TextBox();
            this.postText = new System.Windows.Forms.TextBox();
            this.postShares = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updatePostButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect to DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(26, 97);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(479, 162);
            this.dgvUsers.TabIndex = 1;
            // 
            // dgvPosts
            // 
            this.dgvPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosts.Location = new System.Drawing.Point(564, 97);
            this.dgvPosts.Name = "dgvPosts";
            this.dgvPosts.RowHeadersWidth = 51;
            this.dgvPosts.RowTemplate.Height = 24;
            this.dgvPosts.Size = new System.Drawing.Size(479, 162);
            this.dgvPosts.TabIndex = 2;
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Location = new System.Drawing.Point(218, 60);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(45, 17);
            this.labelUsers.TabIndex = 3;
            this.labelUsers.Text = "Users";
            this.labelUsers.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(783, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Posts";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(893, 27);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(181, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update database";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Text: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Shares: ";
            // 
            // postDate
            // 
            this.postDate.Location = new System.Drawing.Point(112, 285);
            this.postDate.Name = "postDate";
            this.postDate.Size = new System.Drawing.Size(100, 22);
            this.postDate.TabIndex = 9;
            this.postDate.TextChanged += new System.EventHandler(this.postDate_TextChanged);
            // 
            // postText
            // 
            this.postText.Location = new System.Drawing.Point(112, 318);
            this.postText.Name = "postText";
            this.postText.Size = new System.Drawing.Size(100, 22);
            this.postText.TabIndex = 10;
            // 
            // postShares
            // 
            this.postShares.Location = new System.Drawing.Point(112, 352);
            this.postShares.Name = "postShares";
            this.postShares.Size = new System.Drawing.Size(100, 22);
            this.postShares.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "UserID :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // userID
            // 
            this.userID.FormattingEnabled = true;
            this.userID.Location = new System.Drawing.Point(112, 395);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(100, 24);
            this.userID.TabIndex = 13;
            this.userID.SelectedIndexChanged += new System.EventHandler(this.userID_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(271, 281);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 59);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(402, 281);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 59);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updatePostButton
            // 
            this.updatePostButton.Location = new System.Drawing.Point(531, 282);
            this.updatePostButton.Name = "updatePostButton";
            this.updatePostButton.Size = new System.Drawing.Size(98, 56);
            this.updatePostButton.TabIndex = 16;
            this.updatePostButton.Text = "UPDATE";
            this.updatePostButton.UseVisualStyleBackColor = true;
            this.updatePostButton.Click += new System.EventHandler(this.updatePostButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 547);
            this.Controls.Add(this.updatePostButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.postShares);
            this.Controls.Add(this.postText);
            this.Controls.Add(this.postDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.dgvPosts);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvPosts;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox postDate;
        private System.Windows.Forms.TextBox postText;
        private System.Windows.Forms.TextBox postShares;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox userID;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updatePostButton;
    }
}

