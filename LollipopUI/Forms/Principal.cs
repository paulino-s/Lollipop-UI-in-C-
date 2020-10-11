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

namespace CProyect.Forms
{

    public partial class Principal : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Principal()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue700, Accent.DeepOrange400, TextShade.WHITE);
        }
        //
        public bool logeado = false;
        //Variables de productos
        int comprados;
        //Producto 1
        string producto1;
        double precio1;
        int cantidad1;

        //Producto 2
        string producto2;
        double precio2;
        int cantidad2;

        //Producto 3
        string producto3;
        double precio3;
        int cantidad3;

        //Producto 4
        string producto4;
        double precio4;
        int cantidad4;

        //FIN VARIABLES PRODUCTOS

        //Codigo para la primera categoría (Escritorio)
        private void btn_CEscritorio_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatEscritorio testDialog = new CatEscritorio();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;
                
                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;

                
                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void btn_carrito_Click(object sender, EventArgs e)
        {
            if (logeado == false)
            {
                //Abre el Login
                Login testDialog = new Login();
                //Cuando loguee correctamente cambia el resultado de Login a OK
                if (testDialog.ShowDialog(this) == DialogResult.OK)
                {
                    this.logeado = testDialog.logeado;
                }

                else
                {
                    MessageBox.Show("Tiene que iniciar sesión para pagar los productos", "Inicie Sesión");
                }
                testDialog.Dispose();

                //Descarga de TeamSpeak3: http://dl.4players.de/ts/releases/3.0.19.4/TeamSpeak3-Client-win64-3.0.19.4.exe


                if (logeado == true)
                {
                    //Abre el nuevo cuestionario
                    Carretilla testDialog2 = new Carretilla();

                    //Pasar los datos de las variables a la factura

                    //Productos comprados
                    testDialog2.comprados = this.comprados;

                    //Productos Global
                    testDialog2.producto1 = this.producto1;
                    testDialog2.producto2 = this.producto2;
                    testDialog2.producto3 = this.producto3;
                    testDialog2.producto4 = this.producto4;


                    //Precios Global
                    testDialog2.precio1 = this.precio1;
                    testDialog2.precio2 = this.precio2;
                    testDialog2.precio3 = this.precio3;
                    testDialog2.precio4 = this.precio4;

                    //Cantidad global
                    testDialog2.cantidad1 = this.cantidad1;
                    testDialog2.cantidad2 = this.cantidad2;
                    testDialog2.cantidad3 = this.cantidad3;
                    testDialog2.cantidad4 = this.cantidad4;

                    //Cuando finalice correctamente el cuestionario extrae la puntuacion
                    if (testDialog2.ShowDialog(this) == DialogResult.OK)
                    {
                        //this.txt_test1.Text = testDialog.txt_puntuacion1.Text;
                    }
                    //Si finaliza de manera inesperada muestra un error
                    else
                    {
                        //this.txt_test1.Text = "Cancelado";
                    }
                    testDialog2.Dispose();
                }
            }
            else
            {
                //Abre el nuevo cuestionario
                Carretilla testDialog2 = new Carretilla();

                //Pasar los datos de las variables a la factura

                //Productos comprados
                testDialog2.comprados = this.comprados;

                //Productos Global
                testDialog2.producto1 = this.producto1;
                testDialog2.producto2 = this.producto2;
                testDialog2.producto3 = this.producto3;
                testDialog2.producto4 = this.producto4;


                //Precios Global
                testDialog2.precio1 = this.precio1;
                testDialog2.precio2 = this.precio2;
                testDialog2.precio3 = this.precio3;
                testDialog2.precio4 = this.precio4;

                //Cantidad global
                testDialog2.cantidad1 = this.cantidad1;
                testDialog2.cantidad2 = this.cantidad2;
                testDialog2.cantidad3 = this.cantidad3;
                testDialog2.cantidad4 = this.cantidad4;

                //Cuando finalice correctamente el cuestionario extrae la puntuacion
                if (testDialog2.ShowDialog(this) == DialogResult.OK)
                {
                    //this.txt_test1.Text = testDialog.txt_puntuacion1.Text;
                }
                //Si finaliza de manera inesperada muestra un error
                else
                {
                    //this.txt_test1.Text = "Cancelado";
                }
                testDialog2.Dispose();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatGaming testDialog = new CatGaming();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatServer testDialog = new CatServer();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatLaptops testDialog = new CatLaptops();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void btn_tablets_Click_1(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatTablets testDialog = new CatTablets();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void btn_GLaptop_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatGamingLaptops testDialog = new CatGamingLaptops();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void btn_procesador_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatProcesadores testDialog = new CatProcesadores();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void btn_ram_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatRAM testDialog = new CatRAM();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void btn_mother_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatMotherboard testDialog = new CatMotherboard();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void btn_tarjeta_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatTarjetasVideo testDialog = new CatTarjetasVideo();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void btn_disco_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatDiscoDuro testDialog = new CatDiscoDuro();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void btn_ssd_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatSSD testDialog = new CatSSD();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void btn_dvd_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatDVD testDialog = new CatDVD();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void btn_usb_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatUSB testDialog = new CatUSB();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void btn_monitor_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatMonitor testDialog = new CatMonitor();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void btn_teclado_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatTeclado testDialog = new CatTeclado();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void btn_mouse_Click(object sender, EventArgs e)
        {
            //Abre el nuevo cuestionario
            CatMouse testDialog = new CatMouse();
            //Cuando finalice correctamente el cuestionario extrae los productos comprados
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Comprados gobal
                this.comprados = testDialog.comprados;

                //Productos Global
                this.producto1 = testDialog.producto1;
                this.producto2 = testDialog.producto2;
                this.producto3 = testDialog.producto3;
                this.producto4 = testDialog.producto4;

                //Precios Global
                this.precio1 = testDialog.precio1;
                this.precio2 = testDialog.precio2;
                this.precio3 = testDialog.precio3;
                this.precio4 = testDialog.precio4;


                //Cantidad global
                this.cantidad1 = testDialog.cantidad1;
                this.cantidad2 = testDialog.cantidad2;
                this.cantidad3 = testDialog.cantidad3;
                this.cantidad4 = testDialog.cantidad4;


                lbl_carrito.Text = Convert.ToString(comprados);

            }
            //Si finaliza de manera inesperada muestra un error
            else
            {
                //this.txt_test1.Text = "Cancelado";
            }
            testDialog.Dispose();
        }

        private void lollipopButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}