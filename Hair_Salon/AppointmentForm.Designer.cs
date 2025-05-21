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
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            fromBox = new MaterialSkin.Controls.MaterialTextBox2();
            searchBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            toBox = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
<<<<<<< Updated upstream
            filterButton = new MaterialSkin.Controls.MaterialButton();
            showallButton = new MaterialSkin.Controls.MaterialButton();
=======
>>>>>>> Stashed changes
            Number = new ColumnHeader();
            idColumn = new ColumnHeader();
            Client = new ColumnHeader();
            Hairstyle = new ColumnHeader();
            Date = new ColumnHeader();
            Price = new ColumnHeader();
            Hairdresser = new ColumnHeader();
            appListView = new MaterialSkin.Controls.MaterialListView();
            searchButton = new MaterialSkin.Controls.MaterialButton();
            sortButton = new MaterialSkin.Controls.MaterialButton();
            prevButton = new MaterialSkin.Controls.MaterialButton();
            nextButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            pageNumber = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            countBox = new MaterialSkin.Controls.MaterialTextBox();
            maxBox = new MaterialSkin.Controls.MaterialTextBox();
            loadSource = new MaterialSkin.Controls.MaterialButton();
            openFileDialog1 = new OpenFileDialog();
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
            selectedTextBox.Size = new Size(561, 50);
            selectedTextBox.TabIndex = 2;
            selectedTextBox.Text = "";
            selectedTextBox.TrailingIcon = null;
            selectedTextBox.TextChanged += selectedTextBox_TextChanged;
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
<<<<<<< Updated upstream
            fromBox.Location = new Point(398, 173);
=======
            fromBox.Location = new Point(264, 173);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            materialLabel3.Location = new Point(398, 104);
=======
            materialLabel3.Location = new Point(384, 120);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            toBox.Location = new Point(549, 173);
=======
            toBox.Location = new Point(428, 173);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            materialLabel4.Location = new Point(398, 151);
=======
            materialLabel4.Location = new Point(294, 151);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            materialLabel5.Location = new Point(549, 151);
=======
            materialLabel5.Location = new Point(479, 151);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            materialLabel6.Location = new Point(527, 187);
=======
            materialLabel6.Location = new Point(399, 190);
>>>>>>> Stashed changes
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(5, 19);
            materialLabel6.TabIndex = 13;
            materialLabel6.Text = "-";
            // 
<<<<<<< Updated upstream
            // filterButton
            // 
            filterButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            filterButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            filterButton.Depth = 0;
            filterButton.HighEmphasis = true;
            filterButton.Icon = null;
            filterButton.Location = new Point(673, 185);
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
            // showallButton
            // 
            showallButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            showallButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            showallButton.Depth = 0;
            showallButton.HighEmphasis = true;
            showallButton.Icon = null;
            showallButton.Location = new Point(868, 185);
            showallButton.Margin = new Padding(4, 6, 4, 6);
            showallButton.MouseState = MaterialSkin.MouseState.HOVER;
            showallButton.Name = "showallButton";
            showallButton.NoAccentTextColor = Color.Empty;
            showallButton.Size = new Size(93, 36);
            showallButton.TabIndex = 15;
            showallButton.Text = "Show all";
            showallButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            showallButton.UseAccentColor = false;
            showallButton.UseVisualStyleBackColor = true;
            showallButton.Click += showallButton_Click_1;
            // 
=======
>>>>>>> Stashed changes
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
            appListView.Size = new Size(930, 334);
            appListView.TabIndex = 0;
            appListView.UseCompatibleStateImageBehavior = false;
            appListView.View = View.Details;
            appListView.SelectedIndexChanged += appListView_SelectedIndexChanged;
            // 
            // searchButton
            // 
            searchButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            searchButton.Depth = 0;
            searchButton.HighEmphasis = true;
            searchButton.Icon = null;
            searchButton.Location = new Point(564, 179);
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
            // sortButton
            // 
            sortButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sortButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            sortButton.Depth = 0;
            sortButton.HighEmphasis = true;
            sortButton.Icon = null;
            sortButton.Location = new Point(671, 179);
            sortButton.Margin = new Padding(4, 6, 4, 6);
            sortButton.MouseState = MaterialSkin.MouseState.HOVER;
            sortButton.Name = "sortButton";
            sortButton.NoAccentTextColor = Color.Empty;
            sortButton.Size = new Size(64, 36);
            sortButton.TabIndex = 15;
            sortButton.Text = "Sort";
            sortButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            sortButton.UseAccentColor = false;
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // prevButton
            // 
            prevButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            prevButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            prevButton.Depth = 0;
            prevButton.HighEmphasis = true;
            prevButton.Icon = null;
            prevButton.Location = new Point(768, 179);
            prevButton.Margin = new Padding(4, 6, 4, 6);
            prevButton.MouseState = MaterialSkin.MouseState.HOVER;
            prevButton.Name = "prevButton";
            prevButton.NoAccentTextColor = Color.Empty;
            prevButton.Size = new Size(64, 36);
            prevButton.TabIndex = 16;
            prevButton.Text = "Prev";
            prevButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            prevButton.UseAccentColor = false;
            prevButton.UseVisualStyleBackColor = true;
            prevButton.Click += prevButton_Click;
            // 
            // nextButton
            // 
            nextButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nextButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            nextButton.Depth = 0;
            nextButton.HighEmphasis = true;
            nextButton.Icon = null;
            nextButton.Location = new Point(893, 179);
            nextButton.Margin = new Padding(4, 6, 4, 6);
            nextButton.MouseState = MaterialSkin.MouseState.HOVER;
            nextButton.Name = "nextButton";
            nextButton.NoAccentTextColor = Color.Empty;
            nextButton.Size = new Size(64, 36);
            nextButton.TabIndex = 17;
            nextButton.Text = "Next";
            nextButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            nextButton.UseAccentColor = false;
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(662, 75);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(1, 0);
            materialLabel7.TabIndex = 18;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(816, 120);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(1, 0);
            materialLabel8.TabIndex = 19;
            // 
            // pageNumber
            // 
            pageNumber.AutoSize = true;
            pageNumber.Depth = 0;
            pageNumber.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            pageNumber.Location = new Point(857, 190);
            pageNumber.MouseState = MaterialSkin.MouseState.HOVER;
            pageNumber.Name = "pageNumber";
            pageNumber.Size = new Size(10, 19);
            pageNumber.TabIndex = 21;
            pageNumber.Text = "1";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(742, 610);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(47, 19);
            materialLabel9.TabIndex = 22;
            materialLabel9.Text = "Count:";
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(844, 610);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(36, 19);
            materialLabel10.TabIndex = 23;
            materialLabel10.Text = "Max:";
            // 
            // countBox
            // 
            countBox.AnimateReadOnly = false;
            countBox.BorderStyle = BorderStyle.None;
            countBox.Depth = 0;
            countBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            countBox.LeadingIcon = null;
            countBox.Location = new Point(742, 632);
            countBox.MaxLength = 50;
            countBox.MouseState = MaterialSkin.MouseState.OUT;
            countBox.Multiline = false;
            countBox.Name = "countBox";
            countBox.Size = new Size(73, 50);
            countBox.TabIndex = 24;
            countBox.Text = "";
            countBox.TrailingIcon = null;
            // 
            // maxBox
            // 
            maxBox.AnimateReadOnly = false;
            maxBox.BorderStyle = BorderStyle.None;
            maxBox.Depth = 0;
            maxBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            maxBox.LeadingIcon = null;
            maxBox.Location = new Point(844, 634);
            maxBox.MaxLength = 50;
            maxBox.MouseState = MaterialSkin.MouseState.OUT;
            maxBox.Multiline = false;
            maxBox.Name = "maxBox";
            maxBox.Size = new Size(102, 50);
            maxBox.TabIndex = 25;
            maxBox.Text = "";
            maxBox.TrailingIcon = null;
            // 
            // loadSource
            // 
            loadSource.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loadSource.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            loadSource.Depth = 0;
            loadSource.HighEmphasis = true;
            loadSource.Icon = null;
            loadSource.Location = new Point(767, 103);
            loadSource.Margin = new Padding(4, 6, 4, 6);
            loadSource.MouseState = MaterialSkin.MouseState.HOVER;
            loadSource.Name = "loadSource";
            loadSource.NoAccentTextColor = Color.Empty;
            loadSource.Size = new Size(190, 36);
            loadSource.TabIndex = 26;
            loadSource.Text = "Load another source";
            loadSource.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            loadSource.UseAccentColor = false;
            loadSource.UseVisualStyleBackColor = true;
            loadSource.Click += loadSource_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 735);
<<<<<<< Updated upstream
            Controls.Add(showallButton);
            Controls.Add(filterButton);
=======
            Controls.Add(loadSource);
            Controls.Add(maxBox);
            Controls.Add(countBox);
            Controls.Add(materialLabel10);
            Controls.Add(materialLabel9);
            Controls.Add(pageNumber);
            Controls.Add(materialLabel8);
            Controls.Add(materialLabel7);
            Controls.Add(nextButton);
            Controls.Add(prevButton);
            Controls.Add(sortButton);
>>>>>>> Stashed changes
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
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 fromBox;
        private MaterialSkin.Controls.MaterialTextBox2 searchBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 toBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
<<<<<<< Updated upstream
        private MaterialSkin.Controls.MaterialButton filterButton;
        private MaterialSkin.Controls.MaterialButton showallButton;
=======
>>>>>>> Stashed changes
        private ColumnHeader Number;
        private ColumnHeader idColumn;
        private ColumnHeader Client;
        private ColumnHeader Hairstyle;
        private ColumnHeader Date;
        private ColumnHeader Price;
        private ColumnHeader Hairdresser;
        private MaterialSkin.Controls.MaterialListView appListView;
        private MaterialSkin.Controls.MaterialButton searchButton;
        private MaterialSkin.Controls.MaterialButton sortButton;
        private MaterialSkin.Controls.MaterialButton prevButton;
        private MaterialSkin.Controls.MaterialButton nextButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel pageNumber;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox countBox;
        private MaterialSkin.Controls.MaterialTextBox maxBox;
        private MaterialSkin.Controls.MaterialButton loadSource;
        private OpenFileDialog openFileDialog1;
    }
}