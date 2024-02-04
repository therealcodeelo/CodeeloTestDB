namespace CodeeloTestDB
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            enterBtn.Click += (s, e) => 
            {
                var roleID = SQL.Authenticate(loginTB.Text, passwordTB.Text);
                if(roleID == -1)
                {
                    codeeloToolTip1.ShowWarning("Пользователь не найден");
                    return;
                }
                new MainForm(roleID).Show();
                Hide();
            };
        }
    }
}
