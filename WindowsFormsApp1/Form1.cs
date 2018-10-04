using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Cadastro_Click(object sender, EventArgs e)
        {
             public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            // Conectar com o banco de dados
            MySqlConnection db_Con = new MySqlConnection("server=localhost;port=3306;User Id=root;database=bd_Crud;password=9241212818f10");
            private string strSql = string.Empty;

            string strCon;


            private void Form1_Load(object sender, EventArgs e)
            {


                // Habilitar e desabilitar alguns botoes e campos de digitação
                tsbNovo.Enabled = true;
                tsbSave.Enabled = false;
                tsbEdit.Enabled = false;
                tsbCancel.Enabled = false;
                tsbExcluir.Enabled = false;
                tstBuscar.Enabled = true;
                tsbBuscar.Enabled = true;
                txtId.Enabled = false;
                txtNome.Enabled = false;
                txtEnder.Enabled = false;
                mskCep.Enabled = false;
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                txtUF.Enabled = false;
                mskFone.Enabled = false;
            }

            private void toolStripLabel1_Click(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void tsbSave_Click(object sender, EventArgs e)
            {


                // inserir dados na tabela do banco de dados
                strSql = "insert into tb_Crud (Id, Nome, Endereço, CEP, Bairro, Cidade, UF, Telefone) values(@Id, @Nome, @Endereço, @CEP, @Bairro, @Cidade, @UF, @Telefone)";
                MySqlCommand cmd = new MySqlCommand(strSql, db_Con);

                // Parametros comando Sql
                cmd.Parameters.Add("Id", MySqlDbType.Int16).Value = txtId.Text;
                cmd.Parameters.Add("Nome", MySqlDbType.VarChar).Value = txtNome.Text;
                cmd.Parameters.Add("Endereço", MySqlDbType.VarChar).Value = txtEnder.Text;
                cmd.Parameters.Add("CEP", MySqlDbType.VarChar).Value = mskCep.Text;
                cmd.Parameters.Add("Bairro", MySqlDbType.VarChar).Value = txtBairro.Text;
                cmd.Parameters.Add("Cidade", MySqlDbType.VarChar).Value = txtCidade.Text;
                cmd.Parameters.Add("UF", MySqlDbType.VarChar).Value = txtUF.Text;
                cmd.Parameters.Add("Telefone", MySqlDbType.VarChar).Value = mskFone.Text;



                try
                {
                    db_Con.Open();
                    // Execução da Query
                    cmd.ExecuteNonQuery();
                    // mensagem de confirmação de cadastro
                    MessageBox.Show("Cadastro salvo com sucesso !");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO !");
                    db_Con.Close();

                }

                // Habilitar e desabilitar alguns botoes e campos de digitação
                tsbNovo.Enabled = true;
                tsbSave.Enabled = false;
                tsbEdit.Enabled = false;
                tsbCancel.Enabled = false;
                tsbExcluir.Enabled = false;
                tstBuscar.Enabled = true;
                tsbBuscar.Enabled = true;
                txtId.Enabled = false;
                txtNome.Enabled = false;
                txtEnder.Enabled = false;
                mskCep.Enabled = false;
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                txtUF.Enabled = false;
                mskFone.Enabled = false;
                txtId.Text = "";
                tstBuscar.Text = "";
                txtNome.Text = "";
                txtEnder.Text = "";
                mskCep.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtUF.Text = "";


            }

            private void tsbBuscar_Click(object sender, EventArgs e)
            {
                strSql = "select * from tb_crud where Nome=@Nome";

                MySqlCommand cmd = new MySqlCommand(strSql, db_Con);

                cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = tstBuscar.Text;

                try
                {
                    if (tstBuscar.Text == string.Empty)
                    {
                        throw new Exception("Você precida digitar o nome !");
                    }

                    db_Con.Open();

                    // Retornar valores cadastrados no banco de dados
                    MySqlDataReader dr = cmd.ExecuteReader();


                    if (dr.HasRows == false)
                    {
                        throw new Exception("Nenhum cadastro encontrado com esse nome !");
                    }

                    // conversões dos valores
                    txtId.Text = Convert.ToString(dr["Id"]);
                    txtNome.Text = Convert.ToString(dr["Nome"]);
                    txtEnder.Text = Convert.ToString(dr["Endereço"]);
                    mskCep.Text = Convert.ToString(dr["CEP"]);
                    txtBairro.Text = Convert.ToString(dr["Bairro"]);
                    txtCidade.Text = Convert.ToString(dr["Cidade"]);
                    txtUF.Text = Convert.ToString(dr["UF"]);
                    mskFone.Text = Convert.ToString(dr["Telefone"]);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    db_Con.Close();

                }


                // Habilitar e desabilitar alguns botoes e campos de digitação
                tsbNovo.Enabled = false;
                tsbSave.Enabled = false;
                tsbEdit.Enabled = true;
                tsbCancel.Enabled = true;
                tsbExcluir.Enabled = true;
                tstBuscar.Enabled = true;
                tsbBuscar.Enabled = true;
                txtId.Enabled = true;
                txtNome.Enabled = true;
                txtEnder.Enabled = true;
                mskCep.Enabled = true;
                txtBairro.Enabled = true;
                txtCidade.Enabled = true;
                txtUF.Enabled = true;
                mskFone.Enabled = true;
                tsbBuscar.Text = "";
                txtNome.Focus();
            }

            private void tsbEdit_Click(object sender, EventArgs e)
            {
                strSql = "update td_crud set Id=@Id, Nome=@Nome, Endereço=@Endereço, CEP=@CEP, Bairro=@Bairro, Cidade=@Cidade, UF=@UF, Telefone=@Telefone where Nome=@NomeBuscar";
                MySqlCommand cmd = new MySqlCommand(strSql, db_Con);

                cmd.Parameters.Add("@Nome", MySqlDbType.Int16).Value = tstBuscar.Text;

                cmd.Parameters.Add("Id", MySqlDbType.Int16).Value = txtId.Text;
                cmd.Parameters.Add("Nome", MySqlDbType.VarChar).Value = txtNome.Text;
                cmd.Parameters.Add("Endereço", MySqlDbType.VarChar).Value = txtEnder.Text;
                cmd.Parameters.Add("CEP", MySqlDbType.VarChar).Value = mskCep.Text;
                cmd.Parameters.Add("Bairro", MySqlDbType.VarChar).Value = txtBairro.Text;
                cmd.Parameters.Add("Cidade", MySqlDbType.VarChar).Value = txtCidade.Text;
                cmd.Parameters.Add("UF", MySqlDbType.VarChar).Value = txtUF.Text;
                cmd.Parameters.Add("Telefone", MySqlDbType.VarChar).Value = mskFone.Text;

                try
                {
                    db_Con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro alterado !");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    db_Con.Close();
                }


                // Habilitar e desabilitar alguns botoes e campos de digitação
                tsbNovo.Enabled = true;
                tsbSave.Enabled = false;
                tsbEdit.Enabled = false;
                tsbCancel.Enabled = false;
                tsbExcluir.Enabled = false;
                tstBuscar.Enabled = true;
                tsbBuscar.Enabled = true;
                txtId.Enabled = false;
                txtNome.Enabled = false;
                txtEnder.Enabled = false;
                mskCep.Enabled = false;
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                txtUF.Enabled = false;
                mskFone.Enabled = false;
                txtId.Text = "";
                tstBuscar.Text = "";
                txtNome.Text = "";
                txtEnder.Text = "";
                mskCep.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtUF.Text = "";

            }

            private void tsbExcluir_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Deseja mesmo exluir este cadastro ?", "CUIDADO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!");
                }

                else
                {
                    strSql = "delete from td_crud where Nome=@Nome";
                    MySqlCommand cmd = new MySqlCommand(strSql, db_Con);

                    cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = tstBuscar.Text;

                    try
                    {
                        db_Con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cadastro Exluído com Sucesso !");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        db_Con.Close();
                    }
                }


                // Habilitar e desabilitar alguns botoes e campos de digitação
                tsbNovo.Enabled = true;
                tsbSave.Enabled = false;
                tsbEdit.Enabled = false;
                tsbCancel.Enabled = false;
                tsbExcluir.Enabled = false;
                tstBuscar.Enabled = true;
                tsbBuscar.Enabled = true;
                txtId.Enabled = false;
                txtNome.Enabled = false;
                txtEnder.Enabled = false;
                mskCep.Enabled = false;
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                txtUF.Enabled = false;
                mskFone.Enabled = false;
                txtId.Text = "";
                tstBuscar.Text = "";
                txtNome.Text = "";
                txtEnder.Text = "";
                mskCep.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtUF.Text = "";




            }

            private void tsbNovo_Click(object sender, EventArgs e)
            {

                // Habilitar e desabilitar alguns botoes e campos de digitação
                tsbNovo.Enabled = false;
                tsbSave.Enabled = true;
                tsbEdit.Enabled = false;
                tsbCancel.Enabled = true;
                tsbExcluir.Enabled = false;
                tstBuscar.Enabled = false;
                tsbBuscar.Enabled = false;
                txtId.Enabled = true;
                txtNome.Enabled = true;
                txtEnder.Enabled = true;
                mskCep.Enabled = true;
                txtBairro.Enabled = true;
                txtCidade.Enabled = true;
                txtUF.Enabled = true;
                mskFone.Enabled = true;


            }

            private void tsbCancel_Click(object sender, EventArgs e)
            {


                // Habilitar e desabilitar alguns botoes e campos de digitação
                tsbNovo.Enabled = true;
                tsbSave.Enabled = false;
                tsbEdit.Enabled = false;
                tsbCancel.Enabled = false;
                tsbExcluir.Enabled = false;
                tstBuscar.Enabled = true;
                tsbBuscar.Enabled = true;
                txtId.Enabled = false;
                txtNome.Enabled = false;
                txtEnder.Enabled = false;
                mskCep.Enabled = false;
                txtBairro.Enabled = false;
                txtCidade.Enabled = false;
                txtUF.Enabled = false;
                mskFone.Enabled = false;
                txtId.Text = "";
                tstBuscar.Text = "";
                txtNome.Text = "";
                txtEnder.Text = "";
                mskCep.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtUF.Text = "";
                mskFone.Text = "";
            }

            private void tstBuscar_Click(object sender, EventArgs e)
            {

            }
        }
    
    }
}
