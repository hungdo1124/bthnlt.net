using System;
using System.Windows.Forms;

namespace LoginFormExample
{
    public class Form1 : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private Label lblUsername;
        private Label lblPassword;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtUsername.Location = new System.Drawing.Point(150, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(200, 22);
            txtPassword = new TextBox();
            txtPassword.Location = new System.Drawing.Point(150, 70);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(200, 22);
            txtPassword.PasswordChar = '*';
            btnLogin = new Button();
            btnLogin.Location = new System.Drawing.Point(150, 110);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(100, 30);
            btnLogin.Text = "Đăng nhập";
            btnLogin.Click += new EventHandler(this.btnLogin_Click);
            btnExit = new Button();
            btnExit.Location = new System.Drawing.Point(250, 110);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(100, 30);
            btnExit.Text = "Thoát";
            btnExit.Click += new EventHandler(this.btnExit_Click);
            lblUsername = new Label();
            lblUsername.Location = new System.Drawing.Point(50, 30);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(100, 22);
            lblUsername.Text = "Tên đăng nhập:";
            lblPassword = new Label();
            lblPassword.Location = new System.Drawing.Point(50, 70);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(100, 22);
            lblPassword.Text = "Mật khẩu:";
            this.Controls.Add(txtUsername);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnLogin);
            this.Controls.Add(btnExit);
            this.Controls.Add(lblUsername);
            this.Controls.Add(lblPassword);
            this.Text = "Form Đăng Nhập";
            this.ClientSize = new System.Drawing.Size(400, 200);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
