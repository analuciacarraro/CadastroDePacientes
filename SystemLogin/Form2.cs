using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;

namespace SystemLogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void desabilitaCampos()
        {
            txtConvenio.Enabled = false;
            txtEmail.Enabled = false;
            txtNome.Enabled = false;
            txtNumCarteirinha.Enabled = false;
            txtSobrenome.Enabled = false;
            txtUF.Enabled = false;
            rdFem.Enabled = false;
            rdMa.Enabled = false;
            dtNascimento.Enabled = false;
            dtVal.Enabled = false;
            mskCPF.Enabled = true;
            mskRG.Enabled = false;
            mskTEL.Enabled = false;
            mskCel.Enabled = false;
            mskCPFEscrever.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnInserir.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSair.Enabled = true;
        }

        public void habilitaCampos()
        {
            txtConvenio.Enabled = true;
            txtEmail.Enabled = true;
            txtNome.Enabled = true;
            txtNumCarteirinha.Enabled = true;
            txtSobrenome.Enabled = true;
            txtUF.Enabled = true;
            rdFem.Enabled = true;
            rdMa.Enabled = true;
            dtNascimento.Enabled = true;
            dtVal.Enabled = true;
            mskCPF.Enabled = false;
            mskRG.Enabled = true;
            mskTEL.Enabled = true;
            mskCel.Enabled = true;
            mskCPFEscrever.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnInserir.Enabled = true;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnSair.Enabled = true;
        }

        public void limparCampos()
        {
            txtConvenio.Text = "";
            txtEmail.Text = "";
            txtNome.Text = "";
            txtNumCarteirinha.Text = "";
            txtSobrenome.Text = "";
            txtUF.Text = "";
            rdFem.Checked = false;
            rdMa.Checked = false;
            dtNascimento.Text = "";
            dtVal.Text = "";
            mskCPF.Text = "";
            mskRG.Text = "";
            mskTEL.Text = "";
            mskCel.Text = "";
            mskCPFEscrever.Text = "";
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DELLT2CN017\SQLEXPRESS;Integrated Catalog = Clinica;Integrated Security=True;Encrypt=False");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;
        

        private void Form2_Load(object sender, EventArgs e)
        {
            desabilitaCampos(); // chamado para desabilitar os campos
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string Genero;
            if (rdMa.Checked)
            {
                Genero = "Masculino";
            }
            else
            {
                Genero = "Feminino";
            }

            try
            {
                conn.Open();
                string strSQL = "Select CPF from user_tb where CPF = " + mskCPF.Text;
                cm.Connection = conn;
                cm.CommandText = strSQL;
                dt = cm.ExecuteReader();
                if(dt.HasRows )
                {
                    MessageBox.Show("CPF Já Cadastrado","Ops",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    mskCPFEscrever.Text = "";
                    conn.Close();
                }
                else
                {
                    //Adicionando dados ao SQL
                    if (!dt.IsClosed) { dt.Close(); }
                    strSQL = "insert into Patient(Name,Surname,DateOfBirth, Gender, CPF, RG, StateOfRG, Email, Cellphone, Landline, HealthInsurance, HealthInsuranceCard, CardValidity)values(@Nome, @Sobrenome, @Nascimento, @Genero, @CPF, @RG, @UFRG, @Email, @Celular, @TelFixo, @Carteirinha, @Convenio, @Validade )";
                    cm.Parameters.Add("@Nome", sqlDbType.Varchar).Value = txtNome.Text;
                    cm.Parameters.Add("@Sobrenome", sqlDbType.Varchar).Value = txtSobrenome.Text;
                    cm.Parameters.Add("@Nascimento", sqlDbType.Date).Value = dtNascimento.Text;
                    cm.Parameters.Add("@CPF", sqlDbType.Varchar).Value = mskCPF.Text;
                    cm.Parameters.Add("@RG", sqlDbType.Varchar).Value = mskRG.Text;
                    cm.Parameters.Add("@UFRG", sqlDbType.Varchar).Value = txtUF.Text;
                    cm.Parameters.Add("@Email", sqlDbType.Varchar).Value = txtEmail.Text;
                    cm.Parameters.Add("@Celular", sqlDbType.Varchar).Value = mskCel.Text;
                    cm.Parameters.Add("@TelFixo", sqlDbType.Varchar).Value = mskTEL.Text;
                    cm.Parameters.Add("@Carteirinha", sqlDbType.Varchar).Value = txtNumCarteirinha.Text;
                    cm.Parameters.Add("@Convenio", sqlDbType.Varchar).Value = txtConvenio.Text;
                    cm.Parameters.Add("@Validade", sqlDbType.Date).Value = dtVal.Text;
                    cm.Parameters.Add("@Genero", sqlDbType.Varchar).Value = txtNome.Text;
                    cm.Connection = conn;
                    cm.CommandText = strSQL;

                    cm.ExecuteNonQuery();
                    //Mensagem Cadastrado com sucesso
                    MessageBox.Show("Dados cadastrados com sucesso!", "Dados cadastrados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos(); // limpar campos
                    desabilitaCampos(); // desabilita campos
                    cm.Parameters.Clear(); // limpar parametros de envio
                    conn.Close(); // fechar conexão
                }
            }
            catch(Exception Erro)
            {
                MessageBox.Show(Erro.Message);
                conn.Close();
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos(); // chamado para habilitar os campos
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitaCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string strSQL = "Select * from user_tb where CPF = " + mskCPFEscrever.Text;
                cm.Connection = conn;
                cm.CommandText = strSQL;
                dt = cm.ExecuteReader();
                if (dt.HasRows)
                {
                    MessageBox.Show("CPF não Cadastrado", "Erro CPF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mskCPFEscrever.Text = "";
                    conn.Close();
                }
                else
                {
                    dt.Read();
                    string Genero = dt["Gender"].ToString();
                    if(Genero == "Masculino")
                    {
                        rdMa.Checked = true;
                    }
                    else
                    {
                        rdFem.Checked = true;
                    }
                    txtNome.Text = dt["Name"].ToString();
                    txtSobrenome.Text = dt["Surname"].ToString();
                    dtNascimento.Text = dt["DateOfBirth"].ToString();
                    mskCPF.Text = dt["CPF"].ToString();
                    mskRG.Text = dt["RG"].ToString();
                    txtUF.Text = dt["StateOfRG"].ToString();
                    txtEmail.Text = dt["Email"].ToString();
                    mskCel.Text = dt["CellPhone"].ToString();
                    mskTEL.Text = dt["Landline"].ToString();
                    txtConvenio.Text = dt["HealthInsurance"].ToString();
                    txtNumCarteirinha.Text = dt["HealthInsuranceCard"].ToString();
                    dtVal.Text = dt["CardValidity"].ToString();
                    habilitaCampos();

                    if(!dt.IsClosed) { dt.Close(); }
                    conn.Close();
                }
                 catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
                conn.Close();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string strSQL = "delete from into Patient where Name and Surname = '"+ txtNome.Text +"', '"+ txtSobrenome.Text +"'
                cm.Connection = conn;
                cm.CommandText = strSQL;
                cm.ExecuteNonQuery();
                MessageBox.Show("Registro excluido com sucesso", "Exclusão de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                desabilitaCampos();
                conn.Close();
            }
            catch(Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
           
        }
    }
}
