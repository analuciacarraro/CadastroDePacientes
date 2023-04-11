using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SystemLogin
{
    public partial class F_SystemLogin : Form
    {


        public F_SystemLogin()
        {
            InitializeComponent();
        }



        private void tb_loginEnter(object sender, EventArgs e)
        {
            if (tb_login.Text.Equals(""))
            {
                tb_login.Text = "Digite seu usuário";
            }
        }

        private void tb_loginExit(object sender, EventArgs e)
        {
            if (tb_login.Text.Equals(""))
            {
                tb_login.Text = "Digite seu usuário";
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            SqlConnection conn = null;
            SqlDataReader reader = null;
            string sql = "SELECT * FROM user_tb where usuario = @usuario";
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=DELLT2CN017\SQLEXPRESS;Integrated Catalog =Registro;Integrated Security=True;Encrypt=False";

                //Abrir banco de dados
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@usuario", tb_login.Text);

                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    if (tb_login.Text.Equals(reader["usuario"].ToString()) && tb_password.Text.Equals(reader["senha"].ToString()))
                    {
                        MessageBox.Show("Login efetuado com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new Form2().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e senha não confere.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_login.Text = "";
                        tb_password.Text = "" ;
                        tb_login.Focus();
                    }
                }
                //Se ele não encontrar o login no BD, ele não retorna linha!
                else
                {
                    MessageBox.Show("Usuário e senha não confere.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                // Fecha o datareader
                if (reader != null)
                {
                    reader.Close();
                }

                // Fecha a conexão
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                tb_password.PasswordChar = '\0';
            }
            else
            {
                tb_password.PasswordChar = '*';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void F_SystemLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
