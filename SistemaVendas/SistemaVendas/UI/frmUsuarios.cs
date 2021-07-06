using SistemaVendas.BLL;
using SistemaVendas.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas.UI
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

            u.nome = txtnome.Text;
            u.s_nome = txtsnome.Text;
            u.email = txtemail.Text;
            u.usuario = txtusuario.Text;
            u.senha = txtsenha.Text;
            u.contato = txtcontato.Text;
            u.endereco = txtendereco.Text;
            u.sexo = cmbsexo.Text;
            u.usuario_tipo = cmbtipousuario.Text;
            u.add_data = DateTime.Now;
            u.add_por = 1;

            bool success = dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("CADASTRO REALIZADO COM SUCESSO");
            }
            else
            {
                MessageBox.Show("NAO FOI POSSIVEL REALIZAR ESTE CADASTRO");
            }

        }
    }
}
