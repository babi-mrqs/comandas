using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmUsuarios : Form
    {
        private bool ehNovo;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            ehNovo = true;


        }

        private void UpdateUser()
        {
            using (var banco = new AppDbContext())
            {
                var usuario = banco
                    .Usuarios
                    .Where(e => e.id == int.Parse(txtId.TextButton)) 
                    .FirstOrDefault();
                usuario.name = 'Natasha';
                usuario.email = 'nat@gmail.com';
                banco.SaveChanges();
            }
        }

        private void CreateUser()
        {
            // acessar banco
            using (var banco = new AppDbContext())
            {
                // criar novo usuario
                var newUser = new Usuario();
                // atribuimos as propriedades do usuário
                newUser.name = txtNome.TextButton;
                newUser.email = txtEmail.TextButton;
                newUser.senha = txtSenha.TextButton'';

                // salvar as alterações (INSERT INTO usuarios)
                banco.Usuarios.Add(newUser);
                banco.SaveChanges();
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ehNovo)
                //criar usuario
                CreateUser();
            else
                //atualizar usuario
                UpdateUser();

        }
    }
}
