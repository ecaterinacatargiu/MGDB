namespace WindowsFormsApp1
{
    partial class dogId
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
            this.label1 = new System.Windows.Forms.Label();
            this.getBreedsButton = new System.Windows.Forms.Button();
            this.breedTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.breedGrid = new System.Windows.Forms.DataGridView();
            this.dogsGrid = new System.Windows.Forms.DataGridView();
            this.allDogsGrid = new System.Windows.Forms.Button();
            this.allDogs = new System.Windows.Forms.DataGridView();
            this.deleteDogButton = new System.Windows.Forms.Button();
            this.idDog = new System.Windows.Forms.Label();
            this.dogName = new System.Windows.Forms.Label();
            this.dogBday = new System.Windows.Forms.Label();
            this.breedId = new System.Windows.Forms.Label();
            this.staffId = new System.Windows.Forms.Label();
            this.addoptionId = new System.Windows.Forms.Label();
            this.years = new System.Windows.Forms.Label();
            this.yearsOfTraining = new System.Windows.Forms.Label();
            this.textBoxDogId = new System.Windows.Forms.TextBox();
            this.textBoxStaffId = new System.Windows.Forms.TextBox();
            this.textBoxbreedId = new System.Windows.Forms.TextBox();
            this.textBoxDogBirthday = new System.Windows.Forms.TextBox();
            this.textBoxDogName = new System.Windows.Forms.TextBox();
            this.textBoxYearsOfTraining = new System.Windows.Forms.TextBox();
            this.textBoxYears = new System.Windows.Forms.TextBox();
            this.textBoxAddoptionId = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.newDogName = new System.Windows.Forms.Label();
            this.newDogNameTextBox = new System.Windows.Forms.TextBox();
            this.breedChangeName = new System.Windows.Forms.Label();
            this.textBoxtBreedChangeName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.breedGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDogs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Breed:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // getBreedsButton
            // 
            this.getBreedsButton.Location = new System.Drawing.Point(132, 32);
            this.getBreedsButton.Name = "getBreedsButton";
            this.getBreedsButton.Size = new System.Drawing.Size(112, 33);
            this.getBreedsButton.TabIndex = 1;
            this.getBreedsButton.Text = "See Breeds";
            this.getBreedsButton.UseVisualStyleBackColor = true;
            this.getBreedsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // breedTextBox
            // 
            this.breedTextBox.Location = new System.Drawing.Point(68, 246);
            this.breedTextBox.Name = "breedTextBox";
            this.breedTextBox.Size = new System.Drawing.Size(59, 22);
            this.breedTextBox.TabIndex = 3;
            this.breedTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "See Dogs";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // breedGrid
            // 
            this.breedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.breedGrid.Location = new System.Drawing.Point(12, 71);
            this.breedGrid.Name = "breedGrid";
            this.breedGrid.RowHeadersWidth = 51;
            this.breedGrid.RowTemplate.Height = 24;
            this.breedGrid.Size = new System.Drawing.Size(361, 159);
            this.breedGrid.TabIndex = 5;
            // 
            // dogsGrid
            // 
            this.dogsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dogsGrid.Location = new System.Drawing.Point(12, 285);
            this.dogsGrid.Name = "dogsGrid";
            this.dogsGrid.RowHeadersWidth = 51;
            this.dogsGrid.RowTemplate.Height = 24;
            this.dogsGrid.Size = new System.Drawing.Size(1135, 146);
            this.dogsGrid.TabIndex = 6;
            this.dogsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // allDogsGrid
            // 
            this.allDogsGrid.Location = new System.Drawing.Point(723, 32);
            this.allDogsGrid.Name = "allDogsGrid";
            this.allDogsGrid.Size = new System.Drawing.Size(128, 33);
            this.allDogsGrid.TabIndex = 7;
            this.allDogsGrid.Text = "See All Dogs";
            this.allDogsGrid.UseVisualStyleBackColor = true;
            this.allDogsGrid.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // allDogs
            // 
            this.allDogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allDogs.Location = new System.Drawing.Point(399, 71);
            this.allDogs.Name = "allDogs";
            this.allDogs.RowHeadersWidth = 51;
            this.allDogs.RowTemplate.Height = 24;
            this.allDogs.Size = new System.Drawing.Size(930, 150);
            this.allDogs.TabIndex = 8;
            // 
            // deleteDogButton
            // 
            this.deleteDogButton.Location = new System.Drawing.Point(327, 243);
            this.deleteDogButton.Name = "deleteDogButton";
            this.deleteDogButton.Size = new System.Drawing.Size(115, 29);
            this.deleteDogButton.TabIndex = 9;
            this.deleteDogButton.Text = "Delete Dog";
            this.deleteDogButton.UseVisualStyleBackColor = true;
            this.deleteDogButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // idDog
            // 
            this.idDog.AutoSize = true;
            this.idDog.Location = new System.Drawing.Point(12, 453);
            this.idDog.Name = "idDog";
            this.idDog.Size = new System.Drawing.Size(55, 17);
            this.idDog.TabIndex = 11;
            this.idDog.Text = "Dog ID:";
            // 
            // dogName
            // 
            this.dogName.AutoSize = true;
            this.dogName.Location = new System.Drawing.Point(12, 487);
            this.dogName.Name = "dogName";
            this.dogName.Size = new System.Drawing.Size(79, 17);
            this.dogName.TabIndex = 12;
            this.dogName.Text = "Dog Name:";
            // 
            // dogBday
            // 
            this.dogBday.AutoSize = true;
            this.dogBday.Location = new System.Drawing.Point(12, 528);
            this.dogBday.Name = "dogBday";
            this.dogBday.Size = new System.Drawing.Size(94, 17);
            this.dogBday.TabIndex = 13;
            this.dogBday.Text = "Dog Birthday:";
            // 
            // breedId
            // 
            this.breedId.AutoSize = true;
            this.breedId.Location = new System.Drawing.Point(12, 561);
            this.breedId.Name = "breedId";
            this.breedId.Size = new System.Drawing.Size(67, 17);
            this.breedId.TabIndex = 14;
            this.breedId.Text = "Breed ID:";
            // 
            // staffId
            // 
            this.staffId.AutoSize = true;
            this.staffId.Location = new System.Drawing.Point(12, 596);
            this.staffId.Name = "staffId";
            this.staffId.Size = new System.Drawing.Size(58, 17);
            this.staffId.TabIndex = 15;
            this.staffId.Text = "Staff ID:";
            // 
            // addoptionId
            // 
            this.addoptionId.AutoSize = true;
            this.addoptionId.Location = new System.Drawing.Point(9, 632);
            this.addoptionId.Name = "addoptionId";
            this.addoptionId.Size = new System.Drawing.Size(93, 17);
            this.addoptionId.TabIndex = 16;
            this.addoptionId.Text = "Addoption ID:";
            // 
            // years
            // 
            this.years.AutoSize = true;
            this.years.Location = new System.Drawing.Point(12, 663);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(49, 17);
            this.years.TabIndex = 17;
            this.years.Text = "Years:";
            // 
            // yearsOfTraining
            // 
            this.yearsOfTraining.AutoSize = true;
            this.yearsOfTraining.Location = new System.Drawing.Point(12, 701);
            this.yearsOfTraining.Name = "yearsOfTraining";
            this.yearsOfTraining.Size = new System.Drawing.Size(121, 17);
            this.yearsOfTraining.TabIndex = 18;
            this.yearsOfTraining.Text = "Years of Training:";
            // 
            // textBoxDogId
            // 
            this.textBoxDogId.Location = new System.Drawing.Point(129, 448);
            this.textBoxDogId.Name = "textBoxDogId";
            this.textBoxDogId.Size = new System.Drawing.Size(100, 22);
            this.textBoxDogId.TabIndex = 19;
            // 
            // textBoxStaffId
            // 
            this.textBoxStaffId.Location = new System.Drawing.Point(129, 596);
            this.textBoxStaffId.Name = "textBoxStaffId";
            this.textBoxStaffId.Size = new System.Drawing.Size(100, 22);
            this.textBoxStaffId.TabIndex = 20;
            // 
            // textBoxbreedId
            // 
            this.textBoxbreedId.Location = new System.Drawing.Point(129, 565);
            this.textBoxbreedId.Name = "textBoxbreedId";
            this.textBoxbreedId.Size = new System.Drawing.Size(100, 22);
            this.textBoxbreedId.TabIndex = 21;
            // 
            // textBoxDogBirthday
            // 
            this.textBoxDogBirthday.Location = new System.Drawing.Point(129, 525);
            this.textBoxDogBirthday.Name = "textBoxDogBirthday";
            this.textBoxDogBirthday.Size = new System.Drawing.Size(100, 22);
            this.textBoxDogBirthday.TabIndex = 22;
            // 
            // textBoxDogName
            // 
            this.textBoxDogName.Location = new System.Drawing.Point(129, 484);
            this.textBoxDogName.Name = "textBoxDogName";
            this.textBoxDogName.Size = new System.Drawing.Size(100, 22);
            this.textBoxDogName.TabIndex = 23;
            // 
            // textBoxYearsOfTraining
            // 
            this.textBoxYearsOfTraining.Location = new System.Drawing.Point(129, 698);
            this.textBoxYearsOfTraining.Name = "textBoxYearsOfTraining";
            this.textBoxYearsOfTraining.Size = new System.Drawing.Size(100, 22);
            this.textBoxYearsOfTraining.TabIndex = 24;
            // 
            // textBoxYears
            // 
            this.textBoxYears.Location = new System.Drawing.Point(129, 663);
            this.textBoxYears.Name = "textBoxYears";
            this.textBoxYears.Size = new System.Drawing.Size(100, 22);
            this.textBoxYears.TabIndex = 25;
            // 
            // textBoxAddoptionId
            // 
            this.textBoxAddoptionId.Location = new System.Drawing.Point(129, 632);
            this.textBoxAddoptionId.Name = "textBoxAddoptionId";
            this.textBoxAddoptionId.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddoptionId.TabIndex = 26;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(271, 523);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(115, 55);
            this.addButton.TabIndex = 27;
            this.addButton.Text = "Add Doggie";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(542, 551);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(115, 51);
            this.updateButton.TabIndex = 28;
            this.updateButton.Text = "Update Doggie";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // newDogName
            // 
            this.newDogName.AutoSize = true;
            this.newDogName.Location = new System.Drawing.Point(476, 465);
            this.newDogName.Name = "newDogName";
            this.newDogName.Size = new System.Drawing.Size(110, 17);
            this.newDogName.TabIndex = 29;
            this.newDogName.Text = "New Dog Name:";
            // 
            // newDogNameTextBox
            // 
            this.newDogNameTextBox.Location = new System.Drawing.Point(592, 462);
            this.newDogNameTextBox.Name = "newDogNameTextBox";
            this.newDogNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.newDogNameTextBox.TabIndex = 30;
            // 
            // breedChangeName
            // 
            this.breedChangeName.AutoSize = true;
            this.breedChangeName.Location = new System.Drawing.Point(476, 507);
            this.breedChangeName.Name = "breedChangeName";
            this.breedChangeName.Size = new System.Drawing.Size(54, 17);
            this.breedChangeName.TabIndex = 31;
            this.breedChangeName.Text = "Breed: ";
            // 
            // textBoxtBreedChangeName
            // 
            this.textBoxtBreedChangeName.Location = new System.Drawing.Point(592, 507);
            this.textBoxtBreedChangeName.Name = "textBoxtBreedChangeName";
            this.textBoxtBreedChangeName.Size = new System.Drawing.Size(100, 22);
            this.textBoxtBreedChangeName.TabIndex = 32;
            // 
            // dogId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 727);
            this.Controls.Add(this.textBoxtBreedChangeName);
            this.Controls.Add(this.breedChangeName);
            this.Controls.Add(this.newDogNameTextBox);
            this.Controls.Add(this.newDogName);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBoxAddoptionId);
            this.Controls.Add(this.textBoxYears);
            this.Controls.Add(this.textBoxYearsOfTraining);
            this.Controls.Add(this.textBoxDogName);
            this.Controls.Add(this.textBoxDogBirthday);
            this.Controls.Add(this.textBoxbreedId);
            this.Controls.Add(this.textBoxStaffId);
            this.Controls.Add(this.textBoxDogId);
            this.Controls.Add(this.yearsOfTraining);
            this.Controls.Add(this.years);
            this.Controls.Add(this.addoptionId);
            this.Controls.Add(this.staffId);
            this.Controls.Add(this.breedId);
            this.Controls.Add(this.dogBday);
            this.Controls.Add(this.dogName);
            this.Controls.Add(this.idDog);
            this.Controls.Add(this.deleteDogButton);
            this.Controls.Add(this.allDogs);
            this.Controls.Add(this.allDogsGrid);
            this.Controls.Add(this.dogsGrid);
            this.Controls.Add(this.breedGrid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.breedTextBox);
            this.Controls.Add(this.getBreedsButton);
            this.Controls.Add(this.label1);
            this.Name = "dogId";
            this.Text = "Dog ID:";
            ((System.ComponentModel.ISupportInitialize)(this.breedGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getBreedsButton;
        private System.Windows.Forms.TextBox breedTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView breedGrid;
        private System.Windows.Forms.DataGridView dogsGrid;
        private System.Windows.Forms.Button allDogsGrid;
        private System.Windows.Forms.DataGridView allDogs;
        private System.Windows.Forms.Button deleteDogButton;
        private System.Windows.Forms.Label idDog;
        private System.Windows.Forms.Label dogName;
        private System.Windows.Forms.Label dogBday;
        private System.Windows.Forms.Label breedId;
        private System.Windows.Forms.Label staffId;
        private System.Windows.Forms.Label addoptionId;
        private System.Windows.Forms.Label years;
        private System.Windows.Forms.Label yearsOfTraining;
        private System.Windows.Forms.TextBox textBoxDogId;
        private System.Windows.Forms.TextBox textBoxStaffId;
        private System.Windows.Forms.TextBox textBoxbreedId;
        private System.Windows.Forms.TextBox textBoxDogBirthday;
        private System.Windows.Forms.TextBox textBoxDogName;
        private System.Windows.Forms.TextBox textBoxYearsOfTraining;
        private System.Windows.Forms.TextBox textBoxYears;
        private System.Windows.Forms.TextBox textBoxAddoptionId;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label newDogName;
        private System.Windows.Forms.TextBox newDogNameTextBox;
        private System.Windows.Forms.Label breedChangeName;
        private System.Windows.Forms.TextBox textBoxtBreedChangeName;
    }
}

