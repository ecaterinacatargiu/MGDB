namespace Practic
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
            this.dvgCards = new System.Windows.Forms.DataGridView();
            this.dvgTransactions = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tR = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.atm = new System.Windows.Forms.TextBox();
            this.card = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect to db";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dvgCards
            // 
            this.dvgCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCards.Location = new System.Drawing.Point(40, 76);
            this.dvgCards.Name = "dvgCards";
            this.dvgCards.RowHeadersWidth = 51;
            this.dvgCards.RowTemplate.Height = 24;
            this.dvgCards.Size = new System.Drawing.Size(462, 166);
            this.dvgCards.TabIndex = 1;
            // 
            // dvgTransactions
            // 
            this.dvgTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTransactions.Location = new System.Drawing.Point(594, 76);
            this.dvgTransactions.Name = "dvgTransactions";
            this.dvgTransactions.RowHeadersWidth = 51;
            this.dvgTransactions.RowTemplate.Height = 24;
            this.dvgTransactions.Size = new System.Drawing.Size(470, 166);
            this.dvgTransactions.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(379, 298);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 64);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(566, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 66);
            this.button3.TabIndex = 4;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(771, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 62);
            this.button4.TabIndex = 5;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(130, 292);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(187, 22);
            this.amount.TabIndex = 6;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(130, 340);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(187, 22);
            this.type.TabIndex = 7;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(130, 409);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(187, 22);
            this.date.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 9;
            // 
            // tR
            // 
            this.tR.AutoSize = true;
            this.tR.Location = new System.Drawing.Point(809, 40);
            this.tR.Name = "tR";
            this.tR.Size = new System.Drawing.Size(90, 17);
            this.tR.TabIndex = 10;
            this.tR.Text = "Transactions";
            this.tR.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Amount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date";
            // 
            // atm
            // 
            this.atm.Location = new System.Drawing.Point(161, 457);
            this.atm.Name = "atm";
            this.atm.Size = new System.Drawing.Size(100, 22);
            this.atm.TabIndex = 14;
            // 
            // card
            // 
            this.card.Location = new System.Drawing.Point(379, 457);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(100, 22);
            this.card.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 576);
            this.Controls.Add(this.card);
            this.Controls.Add(this.atm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.type);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dvgTransactions);
            this.Controls.Add(this.dvgCards);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dvgCards;
        private System.Windows.Forms.DataGridView dvgTransactions;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox atm;
        private System.Windows.Forms.TextBox card;
    }
}

