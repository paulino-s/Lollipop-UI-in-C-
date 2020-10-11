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
using System.Threading;

namespace CProyect
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey500, Primary.Grey700, Primary.Blue700, Accent.DeepOrange400, TextShade.WHITE);
        }

        //Se inicializa el Thread ventana para luego poder abrir el Form Principal
        Thread ventana;
        //Declaracion de contadores para los intentos fallidos
        int intentos = 0;
        int restantes = 3;
        public bool logeado;

        private void AbrirVentana(Object obj)
        {
            Application.Run(new Forms.Principal());
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            intentos = intentos + 1;
            restantes = restantes - 1;
            lbl_rest.Text = "SOLO USUARIOS REGISTRADOS: " + Convert.ToString(restantes);
            //Comprueba si el usuario y la contraseña estan correctos
            //Si lo estan abre el siguiente Form Principal
            if (Convert.ToBoolean(usuariosTableAdapter.FillBy(this.dBVentasDataSet.Usuarios, txt_user.Text,txt_contra.Text)))
            {
                logeado = true;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                //ventana = new Thread(AbrirVentana);
                //ventana.SetApartmentState(ApartmentState.STA);
                //ventana.Start();
            }
            //Si no estan correctos los datos, muestra un MessageBox mostrando el error
            else
            {
                txt_contra.Text = "Paolo";
                txt_user.Text = "0000";
                lbl_rest.Visible = true;
                MessageBox.Show("Usuario o Contraseña Incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                //Si el contador de intentos llega a 3, muestra que se agotaron los intentos, y que en 15Seg se podrá reintentar
                if (intentos == 3)
                {
                    MessageBox.Show("Ha agotado el numero de intentos, por favor, espere 15 segundos y vuelva a intentarlo.", "Maximo de Intentos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                    //Reinicia contadores
                    intentos = 0;
                    restantes = 3;
                    lbl_rest.Text = "Intentos restantes: 3";
                    btn_aceptar.Enabled = false;

                    //Inicia un contador para los 15 seg
                    timer1.Start();
                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            btn_aceptar.Enabled = true;
            timer1.Stop();
        }

        private void txt_contra_Enter(object sender, EventArgs e)
        {
            if (txt_contra.Text == "Contraseña")
            {
                txt_contra.Text = "";
                txt_contra.UseSystemPasswordChar = true;
            }
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "Usuario")
            {
                txt_user.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro frm = new Registro();
            frm.Show();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBVentasDataSet);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBVentasDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.dBVentasDataSet.Usuarios);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
