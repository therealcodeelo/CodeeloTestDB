namespace CodeeloTestDB
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            codeeloFormDrag1 = new CodeeloUI.Components.CodeeloFormDrag(components);
            codeeloGradientPanel1 = new CodeeloUI.Controls.CodeeloGradientPanel();
            deleteBtn = new CodeeloUI.Controls.CodeeloButton();
            roleCB = new CodeeloUI.Controls.CodeeloComboBox();
            passwordTB = new CodeeloUI.Controls.CodeeloTextBox();
            loginTB = new CodeeloUI.Controls.CodeeloTextBox();
            addBtn = new CodeeloUI.Controls.CodeeloButton();
            codeeloToolTip1 = new CodeeloUI.Components.CodeeloToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            codeeloGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.FromArgb(53, 53, 53);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(32, 32, 32);
            dataGridViewCellStyle1.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(53, 53, 53);
            dataGridViewCellStyle2.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(88, 88, 88);
            dataGridViewCellStyle2.SelectionForeColor = Color.SkyBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(448, 463);
            dataGridView1.TabIndex = 0;
            // 
            // codeeloFormDrag1
            // 
            codeeloFormDrag1.SourceControl = codeeloGradientPanel1;
            // 
            // codeeloGradientPanel1
            // 
            codeeloGradientPanel1.AccessibleRole = null;
            codeeloGradientPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            codeeloGradientPanel1.BackColor = Color.Transparent;
            codeeloGradientPanel1.CausesValidation = false;
            codeeloGradientPanel1.ColorFillFirst = Color.FromArgb(128, 35, 35, 35);
            codeeloGradientPanel1.ColorFillSecond = Color.FromArgb(128, 53, 53, 53);
            codeeloGradientPanel1.Controls.Add(deleteBtn);
            codeeloGradientPanel1.Controls.Add(roleCB);
            codeeloGradientPanel1.Controls.Add(passwordTB);
            codeeloGradientPanel1.Controls.Add(dataGridView1);
            codeeloGradientPanel1.Controls.Add(loginTB);
            codeeloGradientPanel1.Controls.Add(addBtn);
            codeeloGradientPanel1.Dock = DockStyle.Fill;
            codeeloGradientPanel1.DrawGradient = true;
            codeeloGradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            codeeloGradientPanel1.Location = new Point(0, 0);
            codeeloGradientPanel1.Name = "codeeloGradientPanel1";
            codeeloGradientPanel1.Size = new Size(782, 487);
            codeeloGradientPanel1.TabIndex = 1;
            // 
            // deleteBtn
            // 
            deleteBtn.AccessibleRole = null;
            deleteBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteBtn.BackColor = Color.Transparent;
            deleteBtn.BorderColor_1 = Color.Transparent;
            deleteBtn.BorderColor_2 = Color.Transparent;
            deleteBtn.BorderRadius = 8;
            deleteBtn.BorderSize = 3;
            deleteBtn.CausesValidation = false;
            deleteBtn.ColorFill_1 = Color.FromArgb(174, 55, 55);
            deleteBtn.ColorFill_2 = Color.FromArgb(55, 55, 174);
            deleteBtn.DialogResult = false;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteBtn.ForeColor = Color.WhiteSmoke;
            deleteBtn.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            deleteBtn.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            deleteBtn.Location = new Point(481, 210);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.OnClick_BorderColor_1 = Color.Transparent;
            deleteBtn.OnClick_BorderColor_2 = Color.Transparent;
            deleteBtn.OnClick_FillColor_1 = Color.FromArgb(128, 174, 55, 55);
            deleteBtn.OnClick_FillColor_2 = Color.FromArgb(128, 55, 55, 174);
            deleteBtn.OnOver_BorderColor_1 = Color.Transparent;
            deleteBtn.OnOver_BorderColor_2 = Color.Transparent;
            deleteBtn.OnOver_FillColor_1 = Color.FromArgb(178, 174, 55, 55);
            deleteBtn.OnOver_FillColor_2 = Color.FromArgb(178, 55, 55, 174);
            deleteBtn.Size = new Size(141, 43);
            deleteBtn.TabIndex = 4;
            deleteBtn.TabStop = false;
            deleteBtn.Text = "Удалить";
            deleteBtn.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            deleteBtn.UseGradient = true;
            deleteBtn.UseMnemonic = false;
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Visible = false;
            // 
            // roleCB
            // 
            roleCB.ArrowColor = Color.FromArgb(55, 55, 174);
            roleCB.BackColor = Color.MediumSlateBlue;
            roleCB.BorderColor = Color.MediumSlateBlue;
            roleCB.BorderSize = 1;
            roleCB.DropDownStyle = ComboBoxStyle.DropDown;
            roleCB.DropDownWidth = 288;
            roleCB.DroppedDown = false;
            roleCB.FillColor = Color.FromArgb(53, 53, 53);
            roleCB.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            roleCB.ForeColor = Color.White;
            roleCB.ListBackColor = Color.FromArgb(53, 53, 53);
            roleCB.ListTextColor = Color.White;
            roleCB.Location = new Point(481, 42);
            roleCB.Name = "roleCB";
            roleCB.Padding = new Padding(1);
            roleCB.SelectedIndex = -1;
            roleCB.SelectedItem = null;
            roleCB.SelectedText = "";
            roleCB.SelectedValue = null;
            roleCB.Size = new Size(288, 46);
            roleCB.TabIndex = 3;
            roleCB.Text = "codeeloComboBox1";
            // 
            // passwordTB
            // 
            passwordTB.BackColor = Color.FromArgb(53, 53, 53);
            passwordTB.BorderColor = Color.FromArgb(55, 55, 174);
            passwordTB.BorderFocusColor = Color.FromArgb(55, 174, 55);
            passwordTB.BorderSize = 2;
            passwordTB.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordTB.ForeColor = Color.White;
            passwordTB.Location = new Point(481, 156);
            passwordTB.Margin = new Padding(4);
            passwordTB.Multiline = false;
            passwordTB.Name = "passwordTB";
            passwordTB.Padding = new Padding(7);
            passwordTB.PlaceholderColor = Color.DarkGray;
            passwordTB.PlaceholderText = "Пароль";
            passwordTB.Size = new Size(288, 38);
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
            loginTB.Location = new Point(481, 100);
            loginTB.Margin = new Padding(4);
            loginTB.Multiline = false;
            loginTB.Name = "loginTB";
            loginTB.Padding = new Padding(7);
            loginTB.PlaceholderColor = Color.DarkGray;
            loginTB.PlaceholderText = "Имя пользователя";
            loginTB.Size = new Size(288, 38);
            loginTB.TabIndex = 1;
            loginTB.UnderlinedStyle = true;
            loginTB.UsePasswordChar = false;
            // 
            // addBtn
            // 
            addBtn.AccessibleRole = null;
            addBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            addBtn.BackColor = Color.Transparent;
            addBtn.BorderColor_1 = Color.Transparent;
            addBtn.BorderColor_2 = Color.Transparent;
            addBtn.BorderRadius = 8;
            addBtn.BorderSize = 3;
            addBtn.CausesValidation = false;
            addBtn.ColorFill_1 = Color.FromArgb(55, 174, 55);
            addBtn.ColorFill_2 = Color.FromArgb(55, 55, 174);
            addBtn.DialogResult = false;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addBtn.ForeColor = Color.WhiteSmoke;
            addBtn.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            addBtn.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            addBtn.Location = new Point(628, 210);
            addBtn.Name = "addBtn";
            addBtn.OnClick_BorderColor_1 = Color.Transparent;
            addBtn.OnClick_BorderColor_2 = Color.Transparent;
            addBtn.OnClick_FillColor_1 = Color.FromArgb(128, 55, 174, 55);
            addBtn.OnClick_FillColor_2 = Color.FromArgb(128, 55, 55, 174);
            addBtn.OnOver_BorderColor_1 = Color.Transparent;
            addBtn.OnOver_BorderColor_2 = Color.Transparent;
            addBtn.OnOver_FillColor_1 = Color.FromArgb(178, 55, 174, 55);
            addBtn.OnOver_FillColor_2 = Color.FromArgb(178, 55, 55, 174);
            addBtn.Size = new Size(141, 43);
            addBtn.TabIndex = 0;
            addBtn.TabStop = false;
            addBtn.Text = "Добавить";
            addBtn.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            addBtn.UseGradient = true;
            addBtn.UseMnemonic = false;
            addBtn.UseVisualStyleBackColor = false;
            // 
            // codeeloToolTip1
            // 
            codeeloToolTip1.Bitmap24 = null;
            codeeloToolTip1.Delay = 600;
            codeeloToolTip1.Fade = 100;
            codeeloToolTip1.Floating = true;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.mainBack;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 487);
            Controls.Add(codeeloGradientPanel1);
            DoubleBuffered = true;
            Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            codeeloGradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private CodeeloUI.Components.CodeeloFormDrag codeeloFormDrag1;
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel1;
        private CodeeloUI.Controls.CodeeloTextBox passwordTB;
        private CodeeloUI.Controls.CodeeloTextBox loginTB;
        private CodeeloUI.Controls.CodeeloButton addBtn;
        private CodeeloUI.Controls.CodeeloComboBox roleCB;
        private CodeeloUI.Controls.CodeeloButton deleteBtn;
        private CodeeloUI.Components.CodeeloToolTip codeeloToolTip1;
    }
}
