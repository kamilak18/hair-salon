namespace Hair_Salon
{
    partial class HairSalon
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ClientRole = new MaterialSkin.Controls.MaterialRadioButton();
            HairdresserRole = new MaterialSkin.Controls.MaterialRadioButton();
            ManagerRole = new MaterialSkin.Controls.MaterialRadioButton();
            nextButton = new Button();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(231, 116);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(119, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Choose your role";
            // 
            // ClientRole
            // 
            ClientRole.AutoSize = true;
            ClientRole.Depth = 0;
            ClientRole.Location = new Point(243, 181);
            ClientRole.Margin = new Padding(0);
            ClientRole.MouseLocation = new Point(-1, -1);
            ClientRole.MouseState = MaterialSkin.MouseState.HOVER;
            ClientRole.Name = "ClientRole";
            ClientRole.Ripple = true;
            ClientRole.Size = new Size(75, 37);
            ClientRole.TabIndex = 1;
            ClientRole.TabStop = true;
            ClientRole.Text = "Client";
            ClientRole.UseVisualStyleBackColor = true;
            // 
            // HairdresserRole
            // 
            HairdresserRole.AutoSize = true;
            HairdresserRole.Depth = 0;
            HairdresserRole.Location = new Point(243, 254);
            HairdresserRole.Margin = new Padding(0);
            HairdresserRole.MouseLocation = new Point(-1, -1);
            HairdresserRole.MouseState = MaterialSkin.MouseState.HOVER;
            HairdresserRole.Name = "HairdresserRole";
            HairdresserRole.Ripple = true;
            HairdresserRole.Size = new Size(115, 37);
            HairdresserRole.TabIndex = 2;
            HairdresserRole.TabStop = true;
            HairdresserRole.Text = "Hairdresser";
            HairdresserRole.UseVisualStyleBackColor = true;
            // 
            // ManagerRole
            // 
            ManagerRole.AutoSize = true;
            ManagerRole.Depth = 0;
            ManagerRole.Location = new Point(243, 333);
            ManagerRole.Margin = new Padding(0);
            ManagerRole.MouseLocation = new Point(-1, -1);
            ManagerRole.MouseState = MaterialSkin.MouseState.HOVER;
            ManagerRole.Name = "ManagerRole";
            ManagerRole.Ripple = true;
            ManagerRole.Size = new Size(98, 37);
            ManagerRole.TabIndex = 3;
            ManagerRole.TabStop = true;
            ManagerRole.Text = "Manager";
            ManagerRole.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(247, 413);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(94, 29);
            nextButton.TabIndex = 4;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // HairSalon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 506);
            Controls.Add(nextButton);
            Controls.Add(ManagerRole);
            Controls.Add(HairdresserRole);
            Controls.Add(ClientRole);
            Controls.Add(materialLabel1);
            Name = "HairSalon";
            Text = "HairSalon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton ClientRole;
        private MaterialSkin.Controls.MaterialRadioButton HairdresserRole;
        private MaterialSkin.Controls.MaterialRadioButton ManagerRole;
        private Button nextButton;
    }
}
