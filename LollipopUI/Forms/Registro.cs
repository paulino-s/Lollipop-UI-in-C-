using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CProyect
{
    public partial class Registro : MaterialForm
    {
        public Registro()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue700, Accent.DeepOrange400, TextShade.WHITE);
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBVentasDataSet);

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBVentasDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.dBVentasDataSet.Usuarios);

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            //Codigo incompleto, no verifica si el usuario ya existe
            if (txt_contra.Text == txt_contrarep.Text)
            {
                this.usuariosTableAdapter.Registrarse(txt_user.Text, txt_contra.Text, txt_nombre.Text, txt_apellido.Text, txt_telefono.Text, txt_direccion.Text, txt_pais.Text, txt_ciudad.Text, txt_postal.Text, txt_tarjeta.Text);
                this.usuariosTableAdapter.Fill(this.dBVentasDataSet.Usuarios);
                MessageBox.Show("Usuario registrado correctamente.", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas ingresadas no son iguales.", "Contraseñas Incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
