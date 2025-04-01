namespace Hair_Salon
{
    partial class ClientForm
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            bookApp = new MaterialSkin.Controls.MaterialButton();
            comboBox = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            fullNameTextBox = new MaterialSkin.Controls.MaterialTextBox();
            dateBox = new MaterialSkin.Controls.MaterialTextBox();
            labelPrice = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(122, 126);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(75, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Full name:";
            // 
            // bookApp
            // 
            bookApp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bookApp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            bookApp.Depth = 0;
            bookApp.HighEmphasis = true;
            bookApp.Icon = null;
            bookApp.Location = new Point(231, 431);
            bookApp.Margin = new Padding(4, 6, 4, 6);
            bookApp.MouseState = MaterialSkin.MouseState.HOVER;
            bookApp.Name = "bookApp";
            bookApp.NoAccentTextColor = Color.Empty;
            bookApp.Size = new Size(167, 36);
            bookApp.TabIndex = 1;
            bookApp.Text = "Book appointment";
            bookApp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            bookApp.UseAccentColor = false;
            bookApp.UseVisualStyleBackColor = true;
            bookApp.Click += bookApp_Click;
            // 
            // comboBox
            // 
            comboBox.AutoResize = false;
            comboBox.BackColor = Color.FromArgb(255, 255, 255);
            comboBox.Depth = 0;
            comboBox.DrawMode = DrawMode.OwnerDrawVariable;
            comboBox.DropDownHeight = 174;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.DropDownWidth = 121;
            comboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboBox.FormattingEnabled = true;
            comboBox.IntegralHeight = false;
            comboBox.ItemHeight = 43;
            comboBox.Items.AddRange(new object[] { "Bob", "Crop", "Fade", "Curls", "Soft waves" });
            comboBox.Location = new Point(231, 233);
            comboBox.MaxDropDownItems = 4;
            comboBox.MouseState = MaterialSkin.MouseState.OUT;
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(177, 49);
            comboBox.StartIndex = 0;
            comboBox.TabIndex = 2;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(159, 181);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(38, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Date:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(157, 326);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(40, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Price:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(130, 245);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(67, 19);
            materialLabel4.TabIndex = 5;
            materialLabel4.Text = "Hairstyle:";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.AnimateReadOnly = false;
            fullNameTextBox.BorderStyle = BorderStyle.None;
            fullNameTextBox.Depth = 0;
            fullNameTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            fullNameTextBox.LeadingIcon = null;
            fullNameTextBox.Location = new Point(231, 111);
            fullNameTextBox.MaxLength = 50;
            fullNameTextBox.MouseState = MaterialSkin.MouseState.OUT;
            fullNameTextBox.Multiline = false;
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(177, 50);
            fullNameTextBox.TabIndex = 6;
            fullNameTextBox.Text = "";
            fullNameTextBox.TrailingIcon = null;
            // 
            // dateBox
            // 
            dateBox.AnimateReadOnly = false;
            dateBox.BorderStyle = BorderStyle.None;
            dateBox.Depth = 0;
            dateBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateBox.LeadingIcon = null;
            dateBox.Location = new Point(231, 167);
            dateBox.MaxLength = 50;
            dateBox.MouseState = MaterialSkin.MouseState.OUT;
            dateBox.Multiline = false;
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(177, 50);
            dateBox.TabIndex = 7;
            dateBox.Text = "";
            dateBox.TrailingIcon = null;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Depth = 0;
            labelPrice.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelPrice.Location = new Point(245, 326);
            labelPrice.MouseState = MaterialSkin.MouseState.HOVER;
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(1, 0);
            labelPrice.TabIndex = 8;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 576);
            Controls.Add(labelPrice);
            Controls.Add(dateBox);
            Controls.Add(fullNameTextBox);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(comboBox);
            Controls.Add(bookApp);
            Controls.Add(materialLabel1);
            Name = "ClientForm";
            Text = "ClientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton bookApp;
        private MaterialSkin.Controls.MaterialComboBox comboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox fullNameTextBox;
        private MaterialSkin.Controls.MaterialTextBox dateBox;
        private MaterialSkin.Controls.MaterialLabel labelPrice;
    }
}