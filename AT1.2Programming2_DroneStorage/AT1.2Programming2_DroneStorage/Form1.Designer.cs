namespace AT1._2Programming2_DroneStorage
{
    partial class MyDronesForm
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
            this.engineLabel = new System.Windows.Forms.Label();
            this.rangeLable = new System.Windows.Forms.Label();
            this.accessoriesLabel = new System.Windows.Forms.Label();
            this.priceLable = new System.Windows.Forms.Label();
            this.engineTextBox = new System.Windows.Forms.TextBox();
            this.rangeTextBox = new System.Windows.Forms.TextBox();
            this.accessoriesTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.droneDisplayBox = new System.Windows.Forms.ListBox();
            this.droneArrayTextBox = new System.Windows.Forms.TextBox();
            this.droneArrayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // engineLabel
            // 
            this.engineLabel.AutoSize = true;
            this.engineLabel.Location = new System.Drawing.Point(138, 32);
            this.engineLabel.Name = "engineLabel";
            this.engineLabel.Size = new System.Drawing.Size(206, 25);
            this.engineLabel.TabIndex = 0;
            this.engineLabel.Text = "Engine Configuation";
            // 
            // rangeLable
            // 
            this.rangeLable.AutoSize = true;
            this.rangeLable.Location = new System.Drawing.Point(269, 97);
            this.rangeLable.Name = "rangeLable";
            this.rangeLable.Size = new System.Drawing.Size(75, 25);
            this.rangeLable.TabIndex = 1;
            this.rangeLable.Text = "Range";
            // 
            // accessoriesLabel
            // 
            this.accessoriesLabel.AutoSize = true;
            this.accessoriesLabel.Location = new System.Drawing.Point(209, 169);
            this.accessoriesLabel.Name = "accessoriesLabel";
            this.accessoriesLabel.Size = new System.Drawing.Size(135, 25);
            this.accessoriesLabel.TabIndex = 2;
            this.accessoriesLabel.Text = "Accessories ";
            // 
            // priceLable
            // 
            this.priceLable.AutoSize = true;
            this.priceLable.Location = new System.Drawing.Point(280, 250);
            this.priceLable.Name = "priceLable";
            this.priceLable.Size = new System.Drawing.Size(61, 25);
            this.priceLable.TabIndex = 3;
            this.priceLable.Text = "Price";
            // 
            // engineTextBox
            // 
            this.engineTextBox.Location = new System.Drawing.Point(364, 29);
            this.engineTextBox.Multiline = true;
            this.engineTextBox.Name = "engineTextBox";
            this.engineTextBox.Size = new System.Drawing.Size(182, 46);
            this.engineTextBox.TabIndex = 4;
            // 
            // rangeTextBox
            // 
            this.rangeTextBox.Location = new System.Drawing.Point(364, 94);
            this.rangeTextBox.Multiline = true;
            this.rangeTextBox.Name = "rangeTextBox";
            this.rangeTextBox.Size = new System.Drawing.Size(182, 51);
            this.rangeTextBox.TabIndex = 5;
            // 
            // accessoriesTextBox
            // 
            this.accessoriesTextBox.Location = new System.Drawing.Point(364, 166);
            this.accessoriesTextBox.Multiline = true;
            this.accessoriesTextBox.Name = "accessoriesTextBox";
            this.accessoriesTextBox.Size = new System.Drawing.Size(182, 51);
            this.accessoriesTextBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(364, 250);
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(182, 53);
            this.priceTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(285, 353);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(261, 74);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add Button";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // droneDisplayBox
            // 
            this.droneDisplayBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.droneDisplayBox.FormattingEnabled = true;
            this.droneDisplayBox.ItemHeight = 25;
            this.droneDisplayBox.Location = new System.Drawing.Point(583, 23);
            this.droneDisplayBox.Name = "droneDisplayBox";
            this.droneDisplayBox.Size = new System.Drawing.Size(679, 404);
            this.droneDisplayBox.TabIndex = 9;
            this.droneDisplayBox.SelectedIndexChanged += new System.EventHandler(this.droneDisplayBox_SelectedIndexChanged);
            // 
            // droneArrayTextBox
            // 
            this.droneArrayTextBox.Location = new System.Drawing.Point(38, 519);
            this.droneArrayTextBox.Multiline = true;
            this.droneArrayTextBox.Name = "droneArrayTextBox";
            this.droneArrayTextBox.Size = new System.Drawing.Size(508, 58);
            this.droneArrayTextBox.TabIndex = 10;
            // 
            // droneArrayLabel
            // 
            this.droneArrayLabel.AutoSize = true;
            this.droneArrayLabel.Location = new System.Drawing.Point(169, 480);
            this.droneArrayLabel.Name = "droneArrayLabel";
            this.droneArrayLabel.Size = new System.Drawing.Size(218, 25);
            this.droneArrayLabel.TabIndex = 11;
            this.droneArrayLabel.Text = "Drone Array Text Box";
            // 
            // MyDronesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 673);
            this.Controls.Add(this.droneArrayLabel);
            this.Controls.Add(this.droneArrayTextBox);
            this.Controls.Add(this.droneDisplayBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.accessoriesTextBox);
            this.Controls.Add(this.rangeTextBox);
            this.Controls.Add(this.engineTextBox);
            this.Controls.Add(this.priceLable);
            this.Controls.Add(this.accessoriesLabel);
            this.Controls.Add(this.rangeLable);
            this.Controls.Add(this.engineLabel);
            this.Name = "MyDronesForm";
            this.Text = "My Drone Collection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label engineLabel;
        private System.Windows.Forms.Label rangeLable;
        private System.Windows.Forms.Label accessoriesLabel;
        private System.Windows.Forms.Label priceLable;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label droneArrayLabel;
        public System.Windows.Forms.ListBox droneDisplayBox;
        public System.Windows.Forms.TextBox engineTextBox;
        public System.Windows.Forms.TextBox rangeTextBox;
        public System.Windows.Forms.TextBox accessoriesTextBox;
        public System.Windows.Forms.TextBox priceTextBox;
        public System.Windows.Forms.TextBox droneArrayTextBox;
    }
}

