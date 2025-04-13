namespace Hair_Salon
{
    partial class AppointmentForm
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
            selectedTextBox = new MaterialSkin.Controls.MaterialTextBox();
            searchButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            fromBox = new MaterialSkin.Controls.MaterialTextBox2();
            searchBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            toBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            filterButton = new MaterialSkin.Controls.MaterialButton();
            Number = new ColumnHeader();
            idColumn = new ColumnHeader();
            Client = new ColumnHeader();
            Hairstyle = new ColumnHeader();
            Date = new ColumnHeader();
            Price = new ColumnHeader();
            Hairdresser = new ColumnHeader();
            appListView = new MaterialSkin.Controls.MaterialListView();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(31, 644);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(65, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Selected:";
            // 
            // selectedTextBox
            // 
            selectedTextBox.AnimateReadOnly = false;
            selectedTextBox.BorderStyle = BorderStyle.None;
            selectedTextBox.Depth = 0;
            selectedTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            selectedTextBox.LeadingIcon = null;
            selectedTextBox.Location = new Point(124, 632);
            selectedTextBox.MaxLength = 50;
            selectedTextBox.MouseState = MaterialSkin.MouseState.OUT;
            selectedTextBox.Multiline = false;
            selectedTextBox.Name = "selectedTextBox";
            selectedTextBox.Size = new Size(837, 50);
            selectedTextBox.TabIndex = 2;
            selectedTextBox.Text = "";
            selectedTextBox.TrailingIcon = null;
            // 
            // searchButton
            // 
            searchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchButton.Depth = 0;
            searchButton.HighEmphasis = true;
            searchButton.Icon = null;
            searchButton.Location = new Point(256, 173);
            searchButton.Margin = new Padding(4, 6, 4, 6);
            searchButton.MouseState = MaterialSkin.MouseState.HOVER;
            searchButton.Name = "searchButton";
            searchButton.NoAccentTextColor = Color.Empty;
            searchButton.Size = new Size(78, 36);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            searchButton.UseAccentColor = false;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click_1;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(69, 151);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(168, 19);
            materialLabel2.TabIndex = 5;
            materialLabel2.Text = "Search for appointment";
            // 
            // fromBox
            // 
            fromBox.AnimateReadOnly = false;
            fromBox.BackgroundImageLayout = ImageLayout.None;
            fromBox.CharacterCasing = CharacterCasing.Normal;
            fromBox.Depth = 0;
            fromBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            fromBox.HideSelection = true;
            fromBox.LeadingIcon = null;
            fromBox.Location = new Point(429, 173);
            fromBox.MaxLength = 32767;
            fromBox.MouseState = MaterialSkin.MouseState.OUT;
            fromBox.Name = "fromBox";
            fromBox.PasswordChar = '\0';
            fromBox.PrefixSuffixText = null;
            fromBox.ReadOnly = false;
            fromBox.RightToLeft = RightToLeft.No;
            fromBox.SelectedText = "";
            fromBox.SelectionLength = 0;
            fromBox.SelectionStart = 0;
            fromBox.ShortcutsEnabled = true;
            fromBox.Size = new Size(110, 48);
            fromBox.TabIndex = 6;
            fromBox.TabStop = false;
            fromBox.TextAlign = HorizontalAlignment.Left;
            fromBox.TrailingIcon = null;
            fromBox.UseSystemPasswordChar = false;
            // 
            // searchBox
            // 
            searchBox.AnimateReadOnly = false;
            searchBox.BackgroundImageLayout = ImageLayout.None;
            searchBox.CharacterCasing = CharacterCasing.Normal;
            searchBox.Depth = 0;
            searchBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            searchBox.HideSelection = true;
            searchBox.LeadingIcon = null;
            searchBox.Location = new Point(69, 173);
            searchBox.MaxLength = 32767;
            searchBox.MouseState = MaterialSkin.MouseState.OUT;
            searchBox.Name = "searchBox";
            searchBox.PasswordChar = '\0';
            searchBox.PrefixSuffixText = null;
            searchBox.ReadOnly = false;
            searchBox.RightToLeft = RightToLeft.No;
            searchBox.SelectedText = "";
            searchBox.SelectionLength = 0;
            searchBox.SelectionStart = 0;
            searchBox.ShortcutsEnabled = true;
            searchBox.Size = new Size(180, 48);
            searchBox.TabIndex = 7;
            searchBox.TabStop = false;
            searchBox.TextAlign = HorizontalAlignment.Left;
            searchBox.TrailingIcon = null;
            searchBox.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(433, 103);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(34, 19);
            materialLabel3.TabIndex = 8;
            materialLabel3.Text = "Date";
            // 
            // toBox
            // 
            toBox.AnimateReadOnly = false;
            toBox.BackgroundImageLayout = ImageLayout.None;
            toBox.CharacterCasing = CharacterCasing.Normal;
            toBox.Depth = 0;
            toBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            toBox.HideSelection = true;
            toBox.LeadingIcon = null;
            toBox.Location = new Point(594, 173);
            toBox.MaxLength = 32767;
            toBox.MouseState = MaterialSkin.MouseState.OUT;
            toBox.Name = "toBox";
            toBox.PasswordChar = '\0';
            toBox.PrefixSuffixText = null;
            toBox.ReadOnly = false;
            toBox.RightToLeft = RightToLeft.No;
            toBox.SelectedText = "";
            toBox.SelectionLength = 0;
            toBox.SelectionStart = 0;
            toBox.ShortcutsEnabled = true;
            toBox.Size = new Size(117, 48);
            toBox.TabIndex = 9;
            toBox.TabStop = false;
            toBox.TextAlign = HorizontalAlignment.Left;
            toBox.TrailingIcon = null;
            toBox.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(429, 151);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(38, 19);
            materialLabel4.TabIndex = 10;
            materialLabel4.Text = "From";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(594, 151);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(20, 19);
            materialLabel5.TabIndex = 11;
            materialLabel5.Text = "To";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(559, 190);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(5, 19);
            materialLabel6.TabIndex = 13;
            materialLabel6.Text = "-";
            // 
            // filterButton
            // 
            filterButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            filterButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            filterButton.Depth = 0;
            filterButton.HighEmphasis = true;
            filterButton.Icon = null;
            filterButton.Location = new Point(741, 185);
            filterButton.Margin = new Padding(4, 6, 4, 6);
            filterButton.MouseState = MaterialSkin.MouseState.HOVER;
            filterButton.Name = "filterButton";
            filterButton.NoAccentTextColor = Color.Empty;
            filterButton.Size = new Size(68, 36);
            filterButton.TabIndex = 14;
            filterButton.Text = "Filter";
            filterButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            filterButton.UseAccentColor = false;
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click_1;
            // 
            // Number
            // 
            Number.Text = "#";
            Number.Width = 150;
            // 
            // idColumn
            // 
            idColumn.Text = "id";
            idColumn.Width = 0;
            // 
            // Client
            // 
            Client.Text = "Client";
            Client.TextAlign = HorizontalAlignment.Right;
            Client.Width = 150;
            // 
            // Hairstyle
            // 
            Hairstyle.Text = "Hairstyle";
            Hairstyle.TextAlign = HorizontalAlignment.Center;
            Hairstyle.Width = 150;
            // 
            // Date
            // 
            Date.Text = "Date";
            Date.Width = 100;
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.Width = 100;
            // 
            // Hairdresser
            // 
            Hairdresser.Text = "Hairdresser";
            Hairdresser.TextAlign = HorizontalAlignment.Right;
            Hairdresser.Width = 200;
            // 
            // appListView
            // 
            appListView.AutoSizeTable = false;
            appListView.BackColor = Color.FromArgb(255, 255, 255);
            appListView.BorderStyle = BorderStyle.None;
            appListView.Columns.AddRange(new ColumnHeader[] { Number, Client, Hairstyle, Date, Price, Hairdresser, idColumn });
            appListView.Depth = 0;
            appListView.FullRowSelect = true;
            appListView.Location = new Point(50, 254);
            appListView.MinimumSize = new Size(200, 100);
            appListView.MouseLocation = new Point(-1, -1);
            appListView.MouseState = MaterialSkin.MouseState.OUT;
            appListView.Name = "appListView";
            appListView.OwnerDraw = true;
            appListView.Size = new Size(930, 347);
            appListView.TabIndex = 0;
            appListView.UseCompatibleStateImageBehavior = false;
            appListView.View = View.Details;
            appListView.SelectedIndexChanged += appListView_SelectedIndexChanged;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 735);
            Controls.Add(filterButton);
            Controls.Add(materialLabel6);
            Controls.Add(materialLabel5);
            Controls.Add(materialLabel4);
            Controls.Add(toBox);
            Controls.Add(materialLabel3);
            Controls.Add(searchBox);
            Controls.Add(fromBox);
            Controls.Add(materialLabel2);
            Controls.Add(searchButton);
            Controls.Add(selectedTextBox);
            Controls.Add(materialLabel1);
            Controls.Add(appListView);
            Name = "AppointmentForm";
            Text = "AppointmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox selectedTextBox;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 fromBox;
        private MaterialSkin.Controls.MaterialTextBox2 searchBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 toBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton filterButton;
        private ColumnHeader Number;
        private ColumnHeader idColumn;
        private ColumnHeader Client;
        private ColumnHeader Hairstyle;
        private ColumnHeader Date;
        private ColumnHeader Price;
        private ColumnHeader Hairdresser;
        private MaterialSkin.Controls.MaterialListView appListView;
    }
}