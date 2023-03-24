using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarGrupoUsuario : Form
    {
        public FormBuscarGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionarGrupoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormCadastroGrupoUsuario frm = new FormCadastroGrupoUsuario())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
