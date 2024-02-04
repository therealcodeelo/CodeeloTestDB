namespace CodeeloTestDB
{
    public partial class MainForm : Form
    {
        public MainForm(int roleID)
        {
            InitializeComponent();
            deleteBtn.Visible = roleID == 1 ? true : false;
            SQL.GetDataForCombobox("SELECT [ID],CONCAT([ID],' - ',[Title]) as NewRole FROM [CodeeloTestDB].[dbo].[Role]", roleCB, "NewRole", "ID");
            SQL.FillDgvByQuery("SELECT A.[ID],A.[Login],A.[Password],B.Title FROM [CodeeloTestDB].[dbo].[User] as A inner join [CodeeloTestDB].[dbo].[Role] as B on A.RoleID=B.ID", dataGridView1);

            addBtn.Click += (s, e) => 
            {
                SQL.ExecuteQuery($"insert into [User](Login,Password,RoleID) values('{loginTB.Text}','{passwordTB.Text}',{roleCB.SelectedValue})");
                loginTB.Text = passwordTB.Text = string.Empty;
                SQL.FillDgvByQuery("SELECT A.[ID],A.[Login],A.[Password],B.Title FROM [CodeeloTestDB].[dbo].[User] as A inner join [CodeeloTestDB].[dbo].[Role] as B on A.RoleID=B.ID", dataGridView1);
                codeeloToolTip1.ShowOk("Пользователь добавлен");
            };

            deleteBtn.Click += (s, e) => 
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                int id = (int)dataGridView1[0, rowIndex].Value;
                SQL.ExecuteQuery($"delete from [User] where ID = {id}");
                codeeloToolTip1.ShowOk("Пользователь удален");
                SQL.FillDgvByQuery("SELECT A.[ID],A.[Login],A.[Password],B.Title FROM [CodeeloTestDB].[dbo].[User] as A inner join [CodeeloTestDB].[dbo].[Role] as B on A.RoleID=B.ID", dataGridView1);
            };
        }
    }
}
