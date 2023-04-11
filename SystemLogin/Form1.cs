using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SystemLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = new SqlConnection(@"Data Source=DELLT2CN017\SQLEXPRESS;Integrated Catalog =Registro;Integrated Security=True;Encrypt=False");
        SqlConnection cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        public SqlConnection Cmd { get => cmd; set => cmd = value; }

        private void Form1_Load(object sender, EventArgs e)
        {

    }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_login.Text == "" && tb_password.Text == "")
            {
                MessageBox.Show("Usuario ou senha invalida", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtConSenha.Text == tb_password.Text)
            {
                conn.Open();
                string Registro = "insert into user_tb values('" + tb_login + "','" + tb_password + "')";
                Cmd = new SqlCommand(Registro, conn);
                Cmd.ExecuteNonQuery();
                conn.Close();
                tb_login.Text = "";
                tb_password.Text = "";
                txtConSenha.Text = "";
                MessageBox.Show("Usuario criado com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("As senhas são diferentes", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_password.Text = "";
                txtConSenha.Text = "";
                tb_password.Focus();
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                if (!checkBox1.Checked)
                {
                    tb_password.PasswordChar = '\0';
                    txtConSenha.PasswordChar = '\0';
                }
                else
                {
                    tb_password.PasswordChar = '*';
                    txtConSenha.PasswordChar = '*';
                }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new F_SystemLogin().Show();
            this.Hide();
        }
    }
