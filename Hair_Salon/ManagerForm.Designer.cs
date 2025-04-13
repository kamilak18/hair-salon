namespace Hair_Salon
{
    partial class ManagerForm
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
            takeOrderButton = new MaterialSkin.Controls.MaterialButton();
            scheduleButton = new MaterialSkin.Controls.MaterialButton();
            showAppButton = new MaterialSkin.Controls.MaterialButton();
            clientsListBox = new MaterialSkin.Controls.MaterialListBox();
            hairdresserListBox = new MaterialSkin.Controls.MaterialListBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            fullName = new MaterialSkin.Controls.MaterialTextBox();
            passwordBox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // takeOrderButton
            // 
            takeOrderButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            takeOrderButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            takeOrderButton.Depth = 0;
            takeOrderButton.HighEmphasis = true;
            takeOrderButton.Icon = null;
            takeOrderButton.Location = new Point(139, 342);
            takeOrderButton.Margin = new Padding(4, 6, 4, 6);
            takeOrderButton.MouseState = MaterialSkin.MouseState.HOVER;
            takeOrderButton.Name = "takeOrderButton";
            takeOrderButton.NoAccentTextColor = Color.Empty;
            takeOrderButton.Size = new Size(108, 36);
            takeOrderButton.TabIndex = 0;
            takeOrderButton.Text = "Take order";
            takeOrderButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            takeOrderButton.UseAccentColor = false;
            takeOrderButton.UseVisualStyleBackColor = true;
            takeOrderButton.Click += takeOrderButton_Click;
            // 
            // scheduleButton
            // 
            scheduleButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            scheduleButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            scheduleButton.Depth = 0;
            scheduleButton.HighEmphasis = true;
            scheduleButton.Icon = null;
            scheduleButton.Location = new Point(139, 417);
            scheduleButton.Margin = new Padding(4, 6, 4, 6);
            scheduleButton.MouseState = MaterialSkin.MouseState.HOVER;
            scheduleButton.Name = "scheduleButton";
            scheduleButton.NoAccentTextColor = Color.Empty;
            scheduleButton.Size = new Size(95, 36);
            scheduleButton.TabIndex = 1;
            scheduleButton.Text = "Schedule";
            scheduleButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            scheduleButton.UseAccentColor = false;
            scheduleButton.UseVisualStyleBackColor = true;
            scheduleButton.Click += scheduleButton_Click;
            // 
            // showAppButton
            // 
            showAppButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            showAppButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            showAppButton.Depth = 0;
            showAppButton.HighEmphasis = true;
            showAppButton.Icon = null;
            showAppButton.Location = new Point(112, 486);
            showAppButton.Margin = new Padding(4, 6, 4, 6);
            showAppButton.MouseState = MaterialSkin.MouseState.HOVER;
            showAppButton.Name = "showAppButton";
            showAppButton.NoAccentTextColor = Color.Empty;
            showAppButton.Size = new Size(179, 36);
            showAppButton.TabIndex = 2;
            showAppButton.Text = "Show appointments";
            showAppButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            showAppButton.UseAccentColor = false;
            showAppButton.UseVisualStyleBackColor = true;
            showAppButton.Click += showAppButton_Click;
            // 
            // clientsListBox
            // 
            clientsListBox.BackColor = Color.White;
            clientsListBox.BorderColor = Color.LightGray;
            clientsListBox.Depth = 0;
            clientsListBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            clientsListBox.Location = new Point(425, 158);
            clientsListBox.MouseState = MaterialSkin.MouseState.HOVER;
            clientsListBox.Name = "clientsListBox";
            clientsListBox.SelectedIndex = -1;
            clientsListBox.SelectedItem = null;
            clientsListBox.Size = new Size(369, 415);
            clientsListBox.TabIndex = 3;
            // 
            // hairdresserListBox
            // 
            hairdresserListBox.BackColor = Color.White;
            hairdresserListBox.BorderColor = Color.LightGray;
            hairdresserListBox.Depth = 0;
            hairdresserListBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            hairdresserListBox.Location = new Point(848, 158);
            hairdresserListBox.MouseState = MaterialSkin.MouseState.HOVER;
            hairdresserListBox.Name = "hairdresserListBox";
            hairdresserListBox.SelectedIndex = -1;
            hairdresserListBox.SelectedItem = null;
            hairdresserListBox.Size = new Size(234, 415);
            hairdresserListBox.TabIndex = 4;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(57, 126);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(75, 19);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Full name:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(57, 208);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(75, 19);
            materialLabel2.TabIndex = 6;
            materialLabel2.Text = "Password:";
            // 
            // fullName
            // 
            fullName.AnimateReadOnly = false;
            fullName.BorderStyle = BorderStyle.None;
            fullName.Depth = 0;
            fullName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            fullName.LeadingIcon = null;
            fullName.Location = new Point(161, 109);
            fullName.MaxLength = 50;
            fullName.MouseState = MaterialSkin.MouseState.OUT;
            fullName.Multiline = false;
            fullName.Name = "fullName";
            fullName.Size = new Size(200, 50);
            fullName.TabIndex = 7;
            fullName.Text = "";
            fullName.TrailingIcon = null;
            // 
            // passwordBox
            // 
            passwordBox.AnimateReadOnly = false;
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Depth = 0;
            passwordBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordBox.LeadingIcon = null;
            passwordBox.Location = new Point(161, 194);
            passwordBox.MaxLength = 50;
            passwordBox.MouseState = MaterialSkin.MouseState.OUT;
            passwordBox.Multiline = false;
            passwordBox.Name = "passwordBox";
            passwordBox.Password = true;
            passwordBox.Size = new Size(200, 50);
            passwordBox.TabIndex = 8;
            passwordBox.Text = "";
            passwordBox.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(579, 111);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(49, 19);
            materialLabel3.TabIndex = 9;
            materialLabel3.Text = "Clients";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(923, 109);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(89, 19);
            materialLabel4.TabIndex = 10;
            materialLabel4.Text = "Hairdressers";
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 632);
            Controls.Add(materialLabel4);
            Controls.Add(materialLabel3);
            Controls.Add(passwordBox);
            Controls.Add(fullName);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(hairdresserListBox);
            Controls.Add(clientsListBox);
            Controls.Add(showAppButton);
            Controls.Add(scheduleButton);
            Controls.Add(takeOrderButton);
            Name = "ManagerForm";
            Text = "ManagerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton takeOrderButton;
        private MaterialSkin.Controls.MaterialButton scheduleButton;
        private MaterialSkin.Controls.MaterialButton showAppButton;
        private MaterialSkin.Controls.MaterialListBox clientsListBox;
        private MaterialSkin.Controls.MaterialListBox hairdresserListBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox fullName;
        private MaterialSkin.Controls.MaterialTextBox passwordBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}