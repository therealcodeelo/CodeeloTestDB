namespace CodeeloTestDB
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            codeeloGradientPanel1 = new CodeeloUI.Controls.CodeeloGradientPanel();
            passwordTB = new CodeeloUI.Controls.CodeeloTextBox();
            loginTB = new CodeeloUI.Controls.CodeeloTextBox();
            enterBtn = new CodeeloUI.Controls.CodeeloButton();
            codeeloFormDrag1 = new CodeeloUI.Components.CodeeloFormDrag(components);
            codeeloToolTip1 = new CodeeloUI.Components.CodeeloToolTip(components);
            codeeloGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // codeeloGradientPanel1
            // 
            codeeloGradientPanel1.AccessibleRole = null;
            codeeloGradientPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            codeeloGradientPanel1.BackColor = Color.Transparent;
            codeeloGradientPanel1.CausesValidation = false;
            codeeloGradientPanel1.ColorFillFirst = Color.FromArgb(128, 35, 35, 35);
            codeeloGradientPanel1.ColorFillSecond = Color.FromArgb(128, 53, 53, 53);
            codeeloGradientPanel1.Controls.Add(passwordTB);
            codeeloGradientPanel1.Controls.Add(loginTB);
            codeeloGradientPanel1.Controls.Add(enterBtn);
            codeeloGradientPanel1.Dock = DockStyle.Fill;
            codeeloGradientPanel1.DrawGradient = true;
            codeeloGradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            codeeloGradientPanel1.Location = new Point(0, 0);
            codeeloGradientPanel1.Name = "codeeloGradientPanel1";
            codeeloGradientPanel1.Size = new Size(800, 450);
            codeeloGradientPanel1.TabIndex = 0;
            // 
            // passwordTB
            // 
            passwordTB.BackColor = Color.FromArgb(53, 53, 53);
            passwordTB.BorderColor = Color.FromArgb(55, 55, 174);
            passwordTB.BorderFocusColor = Color.FromArgb(55, 174, 55);
            passwordTB.BorderSize = 2;
            passwordTB.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordTB.ForeColor = Color.White;
            passwordTB.Location = new Point(537, 328);
            passwordTB.Margin = new Padding(4);
            passwordTB.Multiline = false;
            passwordTB.Name = "passwordTB";
            passwordTB.Padding = new Padding(7);
            passwordTB.PlaceholderColor = Color.DarkGray;
            passwordTB.PlaceholderText = "Пароль";
            passwordTB.Size = new Size(250, 38);
            passwordTB.TabIndex = 2;
            passwordTB.UnderlinedStyle = true;
            passwordTB.UsePasswordChar = true;
            // 
            // loginTB
            // 
            loginTB.BackColor = Color.FromArgb(53, 53, 53);
            loginTB.BorderColor = Color.FromArgb(55, 55, 174);
            loginTB.BorderFocusColor = Color.FromArgb(55, 174, 55);
            loginTB.BorderSize = 2;
            loginTB.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginTB.ForeColor = Color.White;
            loginTB.Location = new Point(537, 272);
            loginTB.Margin = new Padding(4);
            loginTB.Multiline = false;
            loginTB.Name = "loginTB";
            loginTB.Padding = new Padding(7);
            loginTB.PlaceholderColor = Color.DarkGray;
            loginTB.PlaceholderText = "Имя пользователя";
            loginTB.Size = new Size(250, 38);
            loginTB.TabIndex = 1;
            loginTB.UnderlinedStyle = true;
            loginTB.UsePasswordChar = false;
            // 
            // enterBtn
            // 
            enterBtn.AccessibleRole = null;
            enterBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            enterBtn.BackColor = Color.Transparent;
            enterBtn.BorderColor_1 = Color.Transparent;
            enterBtn.BorderColor_2 = Color.Transparent;
            enterBtn.BorderRadius = 8;
            enterBtn.BorderSize = 3;
            enterBtn.CausesValidation = false;
            enterBtn.ColorFill_1 = Color.FromArgb(55, 174, 55);
            enterBtn.ColorFill_2 = Color.FromArgb(55, 55, 174);
            enterBtn.DialogResult = false;
            enterBtn.FlatAppearance.BorderSize = 0;
            enterBtn.FlatStyle = FlatStyle.Flat;
            enterBtn.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            enterBtn.ForeColor = Color.WhiteSmoke;
            enterBtn.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            enterBtn.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            enterBtn.Location = new Point(646, 386);
            enterBtn.Name = "enterBtn";
            enterBtn.OnClick_BorderColor_1 = Color.Transparent;
            enterBtn.OnClick_BorderColor_2 = Color.Transparent;
            enterBtn.OnClick_FillColor_1 = Color.FromArgb(128, 55, 174, 55);
            enterBtn.OnClick_FillColor_2 = Color.FromArgb(128, 55, 55, 174);
            enterBtn.OnOver_BorderColor_1 = Color.Transparent;
            enterBtn.OnOver_BorderColor_2 = Color.Transparent;
            enterBtn.OnOver_FillColor_1 = Color.FromArgb(178, 55, 174, 55);
            enterBtn.OnOver_FillColor_2 = Color.FromArgb(178, 55, 55, 174);
            enterBtn.Size = new Size(141, 43);
            enterBtn.TabIndex = 0;
            enterBtn.TabStop = false;
            enterBtn.Text = "Вход";
            enterBtn.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            enterBtn.UseGradient = true;
            enterBtn.UseMnemonic = false;
            enterBtn.UseVisualStyleBackColor = false;
            // 
            // codeeloFormDrag1
            // 
            codeeloFormDrag1.SourceControl = codeeloGradientPanel1;
            // 
            // codeeloToolTip1
            // 
            codeeloToolTip1.Bitmap24 = null;
            codeeloToolTip1.Delay = 600;
            codeeloToolTip1.Fade = 100;
            codeeloToolTip1.Floating = true;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.loginBack;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(codeeloGradientPanel1);
            DoubleBuffered = true;
            Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            codeeloGradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel1;
        private CodeeloUI.Controls.CodeeloTextBox passwordTB;
        private CodeeloUI.Controls.CodeeloTextBox loginTB;
        private CodeeloUI.Controls.CodeeloButton enterBtn;
        private CodeeloUI.Components.CodeeloFormDrag codeeloFormDrag1;
        private CodeeloUI.Components.CodeeloToolTip codeeloToolTip1;
    }
}