namespace Hair_Salon
{
    partial class HairdresserForm
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
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            showButton = new MaterialSkin.Controls.MaterialButton();
            serveButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            fullName = new MaterialSkin.Controls.MaterialTextBox();
            passwordBox = new MaterialSkin.Controls.MaterialTextBox();
            clientsListBox = new MaterialSkin.Controls.MaterialListBox();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(74, 159);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(75, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Full name:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(74, 237);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(75, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "Password:";
            // 
            // showButton
            // 
            showButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            showButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            showButton.Depth = 0;
            showButton.HighEmphasis = true;
            showButton.Icon = null;
            showButton.Location = new Point(128, 362);
            showButton.Margin = new Padding(4, 6, 4, 6);
            showButton.MouseState = MaterialSkin.MouseState.HOVER;
            showButton.Name = "showButton";
            showButton.NoAccentTextColor = Color.Empty;
            showButton.Size = new Size(141, 36);
            showButton.TabIndex = 2;
            showButton.Text = "Show schedule";
            showButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            showButton.UseAccentColor = false;
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // serveButton
            // 
            serveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            serveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            serveButton.Depth = 0;
            serveButton.HighEmphasis = true;
            serveButton.Icon = null;
            serveButton.Location = new Point(139, 436);
            serveButton.Margin = new Padding(4, 6, 4, 6);
            serveButton.MouseState = MaterialSkin.MouseState.HOVER;
            serveButton.Name = "serveButton";
            serveButton.NoAccentTextColor = Color.Empty;
            serveButton.Size = new Size(119, 36);
            serveButton.TabIndex = 3;
            serveButton.Text = "Serve client";
            serveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            serveButton.UseAccentColor = false;
            serveButton.UseVisualStyleBackColor = true;
            serveButton.Click += serveButton_Click;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(568, 96);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(49, 19);
            materialLabel3.TabIndex = 5;
            materialLabel3.Text = "Clients";
            // 
            // fullName
            // 
            fullName.AnimateReadOnly = false;
            fullName.BorderStyle = BorderStyle.None;
            fullName.Depth = 0;
            fullName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            fullName.LeadingIcon = null;
            fullName.Location = new Point(155, 144);
            fullName.MaxLength = 50;
            fullName.MouseState = MaterialSkin.MouseState.OUT;
            fullName.Multiline = false;
            fullName.Name = "fullName";
            fullName.Size = new Size(179, 50);
            fullName.TabIndex = 6;
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
            passwordBox.Location = new Point(155, 223);
            passwordBox.MaxLength = 50;
            passwordBox.MouseState = MaterialSkin.MouseState.OUT;
            passwordBox.Multiline = false;
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(179, 50);
            passwordBox.TabIndex = 7;
            passwordBox.Text = "";
            passwordBox.TrailingIcon = null;
            // 
            // clientsListBox
            // 
            clientsListBox.BackColor = Color.White;
            clientsListBox.BorderColor = Color.LightGray;
            clientsListBox.Depth = 0;
            clientsListBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            clientsListBox.Location = new Point(403, 134);
            clientsListBox.MouseState = MaterialSkin.MouseState.HOVER;
            clientsListBox.Name = "clientsListBox";
            clientsListBox.SelectedIndex = -1;
            clientsListBox.SelectedItem = null;
            clientsListBox.Size = new Size(398, 433);
            clientsListBox.TabIndex = 8;
            // 
            // HairdresserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 629);
            Controls.Add(clientsListBox);
            Controls.Add(passwordBox);
            Controls.Add(fullName);
            Controls.Add(materialLabel3);
            Controls.Add(serveButton);
            Controls.Add(showButton);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Name = "HairdresserForm";
            Text = "HairdresserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton showButton;
        private MaterialSkin.Controls.MaterialButton serveButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox fullName;
        private MaterialSkin.Controls.MaterialTextBox passwordBox;
        private MaterialSkin.Controls.MaterialListBox clientsListBox;
    }
}