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

    public partial class CatProcesadores : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public CatProcesadores()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue700, Accent.DeepOrange400, TextShade.WHITE);
        }

        /*Va la onda esta en que ya sabras va, 
           se crean las variables de productos, 
           maximo se pueden comprar cuatro
           lo que sucede es que se almacenan
           los valores que hay en cada producto cuando
           se le da comprar, y estos valores serán enviados
           al form principal, para luego ser enviados al form
           de la factura*/

        //Variables de productos
        public int comprados = 0;
        //Producto 1
        public string producto1 = "";
        public double precio1 = 0;
        public int cantidad1 = 0;

        //Producto 2
        public string producto2 = "";
        public double precio2 = 0;
        public int cantidad2 = 0;

        //Producto 3
        public string producto3 = "";
        public double precio3 = 0;
        public int cantidad3 = 0;

        //Producto 4
        public string producto4 = "";
        public double precio4 = 0;
        public int cantidad4 = 0;


        //FIN VARIABLES PRODUCTOS
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Cada vez que se preciona un boton
           de compra, hay un switch como hay una variable
           que controla cuantos items he comprado
           verifica cuantos llevo, segun eso guarda los valores
           de ese producto en el producto 1, 2 o 3, para luego dichos
           valores enviarlos al form principal, guarda lo que es modelo, cantidad, y precio
           ademas de incrementar la variable de comprados, que son los cuandos items llevo */


        //Boton del primer producto
        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            switch (comprados)
            {
                case 0:
                    comprados = comprados + 1;
                    producto1 = gbox_1.Text;
                    precio1 = Convert.ToDouble(lbl_precio1.Text.Remove(0, 9));
                    cantidad1 = Convert.ToInt16(cant_1.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");

                    break;
                case 1:
                    comprados = comprados + 1;
                    producto2 = gbox_1.Text;
                    precio2 = Convert.ToDouble(lbl_precio1.Text.Remove(0, 9));
                    cantidad2 = Convert.ToInt16(cant_1.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");
                    break;

                case 2:
                    comprados = comprados + 1;
                    producto3 = gbox_1.Text;
                    precio3 = Convert.ToDouble(lbl_precio1.Text.Remove(0, 9));
                    cantidad3 = Convert.ToInt16(cant_1.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");
                    break;


                case 3:
                    comprados = comprados + 1;
                    producto4 = gbox_1.Text;
                    precio4 = Convert.ToDouble(lbl_precio1.Text.Remove(0, 9));
                    cantidad4 = Convert.ToInt16(cant_1.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");
                    break;

                case 4:
                    MessageBox.Show("Limite maximo de productos que puede comprar", "Maximo de Productos");
                    break;
            }   
        }

        //Boton del segundo producto
        private void btn_compra2_Click(object sender, EventArgs e)
        {
            switch (comprados)
            {
                case 0:
                    comprados = comprados + 1;
                    producto1 = gbox_2.Text;
                    precio1 = Convert.ToDouble(lbl_precio2.Text.Remove(0, 9));
                    cantidad1 = Convert.ToInt16(cant_2.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");

                    break;
                case 1:
                    comprados = comprados + 1;
                    producto2 = gbox_2.Text;
                    precio2 = Convert.ToDouble(lbl_precio2.Text.Remove(0, 9));
                    cantidad2 = Convert.ToInt16(cant_2.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");

                    break;

                case 2:
                    comprados = comprados + 1;
                    producto3 = gbox_2.Text;
                    precio3 = Convert.ToDouble(lbl_precio2.Text.Remove(0, 9));
                    cantidad3 = Convert.ToInt16(cant_2.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");
                    break;


                case 3:
                    comprados = comprados + 1;
                    producto4 = gbox_2.Text;
                    precio4 = Convert.ToDouble(lbl_precio2.Text.Remove(0, 9));
                    cantidad4 = Convert.ToInt16(cant_2.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");
                    break;

                case 4:
                    MessageBox.Show("Limite maximo de productos que puede comprar", "Maximo de Productos");
                    break;
            }
        }

        //Boton de compra 3
        private void btn_compra3_Click(object sender, EventArgs e)
        {
            switch (comprados)
            {
                case 0:
                    comprados = comprados + 1;
                    producto1 = gbox_3.Text;
                    precio1 = Convert.ToDouble(lbl_precio3.Text.Remove(0, 9));
                    cantidad1 = Convert.ToInt16(cant_3.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");


                    break;
                case 1:
                    comprados = comprados + 1;
                    producto2 = gbox_3.Text;
                    precio2 = Convert.ToDouble(lbl_precio3.Text.Remove(0, 9));
                    cantidad2 = Convert.ToInt16(cant_3.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");

                    break;

                case 2:
                    comprados = comprados + 1;
                    producto3 = gbox_3.Text;
                    precio3 = Convert.ToDouble(lbl_precio3.Text.Remove(0, 9));
                    cantidad3 = Convert.ToInt16(cant_3.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");

                    break;


                case 3:
                    comprados = comprados + 1;
                    producto4 = gbox_3.Text;
                    precio4 = Convert.ToDouble(lbl_precio3.Text.Remove(0, 9));
                    cantidad4 = Convert.ToInt16(cant_3.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");

                    break;

                case 4:
                    MessageBox.Show("Limite maximo de productos que puede comprar", "Maximo de Productos");
                    break;
            }
        }

        private void btn_compra4_Click(object sender, EventArgs e)
        {
            switch (comprados)
            {
                case 0:
                    comprados = comprados + 1;
                    producto1 = gbox_4.Text;
                    precio1 = Convert.ToDouble(lbl_precio4.Text.Remove(0, 9));
                    cantidad1 = Convert.ToInt16(cant_4.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");

                    break;
                case 1:
                    comprados = comprados + 1;
                    producto2 = gbox_4.Text;
                    precio2 = Convert.ToDouble(lbl_precio3.Text.Remove(0, 9));
                    cantidad2 = Convert.ToInt16(cant_4.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");

                    break;

                case 2:
                    comprados = comprados + 1;
                    producto3 = gbox_4.Text;
                    precio3 = Convert.ToDouble(lbl_precio4.Text.Remove(0, 9));
                    cantidad3 = Convert.ToInt16(cant_4.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");

                    break;


                case 3:
                    comprados = comprados + 1;
                    producto4 = gbox_4.Text;
                    precio4 = Convert.ToDouble(lbl_precio4.Text.Remove(0, 9));
                    cantidad4 = Convert.ToInt16(cant_4.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");

                    break;

                case 4:
                    MessageBox.Show("Limite maximo de productos que puede comprar", "Maximo de Productos");
                    break;
            }
        }

        //Boton de compra 5
        private void btn_compra5_Click(object sender, EventArgs e)
        {
            switch (comprados)
            {
                case 0:
                    comprados = comprados + 1;
                    producto1 = gbox_5.Text;
                    precio1 = Convert.ToDouble(lbl_precio5.Text.Remove(0, 9));
                    cantidad1 = Convert.ToInt16(cant_5.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");


                    break;
                case 1:
                    comprados = comprados + 1;
                    producto2 = gbox_5.Text;
                    precio2 = Convert.ToDouble(lbl_precio5.Text.Remove(0, 9));
                    cantidad2 = Convert.ToInt16(cant_5.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");

                    break;

                case 2:
                    comprados = comprados + 1;
                    producto3 = gbox_5.Text;
                    precio3 = Convert.ToDouble(lbl_precio5.Text.Remove(0, 9));
                    cantidad3 = Convert.ToInt16(cant_5.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");

                    break;


                case 3:
                    comprados = comprados + 1;
                    producto4 = gbox_5.Text;
                    precio4 = Convert.ToDouble(lbl_precio5.Text.Remove(0, 9));
                    cantidad4 = Convert.ToInt16(cant_5.Value);
                    MessageBox.Show("Se ha añadido el producto a la carretilla", "Producto Añadido");

                    break;

                case 4:
                    MessageBox.Show("Limite maximo de productos que puede comprar", "Maximo de Productos");
                    break;
            }
        }
    }
}