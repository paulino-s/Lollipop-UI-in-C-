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
    public partial class Carretilla : MaterialForm
    {
        public Carretilla()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue700, Accent.DeepOrange400, TextShade.WHITE);
        }

        //Variables de productos
        public int comprados;
        //Producto 1
        public string producto1;
        public double precio1;
        public int cantidad1;

        //Producto 2
        public string producto2;
        public double precio2;
        public int cantidad2;

        //Producto 3
        public string producto3;
        public double precio3;
        public int cantidad3;

        //Producto 4
        public string producto4;
        public double precio4;
        public int cantidad4;

        int descuento;
        double totalpagar;
        double Total;
        double IVA;


        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Carretilla_Load(object sender, EventArgs e)
        {
            
            //Primer Producto
            txt_cant1.Text = Convert.ToString(cantidad1);
            txt_prod1.Text = producto1;
            txt_pUnitario1.Text = "$ " + Convert.ToString(precio1);

            //Segundo Producto
            txt_cant2.Text = Convert.ToString(cantidad2);
            txt_prod2.Text = producto2;
            txt_pUnitario2.Text = "$ " + Convert.ToString(precio2);

            //Tercer Producto
            txt_cant3.Text = Convert.ToString(cantidad3);
            txt_prod3.Text = producto3;
            txt_pUnitario3.Text = "$ " + Convert.ToString(precio3);

            //Cuarto Producto
            txt_cant4.Text = Convert.ToString(cantidad4);
            txt_prod4.Text = producto4;
            txt_pUnitario4.Text = "$ " + Convert.ToString(precio4);

            //SubTotales
            double subT1 = cantidad1 * precio1;
            double subT2 = cantidad2 * precio2;
            double subT3 = cantidad3 * precio3;
            double subT4 = cantidad4 * precio4;
            
            txt_subT1.Text = "$ " + Convert.ToString(subT1);
            txt_subT2.Text = "$ " + Convert.ToString(subT2);
            txt_subT3.Text = "$ " + Convert.ToString(subT3);
            txt_subT4.Text = "$ " + Convert.ToString(subT4);

            //Total
            Total = subT1 + subT2 + subT3 + subT4;
            txt_total.Text = "$ " + Convert.ToString(Total);

            switch (comprados)
                {
                case 1:
                    txt_cant2.Text = "";
                    txt_cant3.Text = "";
                    txt_cant4.Text = "";

                    txt_subT2.Text = "";
                    txt_subT3.Text = "";
                    txt_subT4.Text = "";

                    txt_pUnitario2.Text = "";
                    txt_pUnitario3.Text = "";
                    txt_pUnitario4.Text = "";
                    break;

                case 2:
                    
                    txt_cant3.Text = "";
                    txt_cant4.Text = "";
                                        
                    txt_subT3.Text = "";
                    txt_subT4.Text = "";

                    txt_pUnitario3.Text = "";
                    txt_pUnitario4.Text = "";
                    break;

                case 3:
                    
                    txt_cant4.Text = "";
                                       
                    txt_subT4.Text = "";

                    txt_pUnitario4.Text = "";
                    break;

            }

        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            double val_descuento;
            //Descuento
            switch (cBox_tipoPago.Text)
            {
               
                case "Efectivo":
                    
                    try
                    { 
                    if (txt_efectivo.Text == "")
                    {
                        MessageBox.Show("USTED ESTA PEDO DEBE DE INGRESAR SOLO EFECTIVO");
                    }
                    else
                    {
                        descuento = 25;
                        val_descuento = 0.25 * Total;
                        totalpagar = Total - val_descuento;
                        txt_totaltotal.Text = "$ " + Convert.ToString(totalpagar);
                        txt_descuento.Text = Convert.ToString(descuento) + " %";
                        txt_IVA.Text = "$ " + Convert.ToString(totalpagar * 0.14);
                        double efectivo;
                        double vuelto;
                        efectivo = Convert.ToDouble(txt_efectivo.Text);
                        vuelto = efectivo - totalpagar;
                        txt_vuelto.Text = Convert.ToString(vuelto);
                        
                    }
                    }
                    catch
                    {
                        MessageBox.Show("Ingrese unicamente valores numerícos", "Error!", MessageBoxButtons.OK , MessageBoxIcon.Error);

                    }


                    break;

                case "Paypal":
                    descuento = 15;
                    val_descuento = 0.15 * Total;
                    totalpagar = Total - val_descuento;
                    txt_totaltotal.Text = " $" + Convert.ToString(totalpagar);
                    txt_descuento.Text = Convert.ToString(descuento) + " %";
                    txt_IVA.Text = " $" + Convert.ToString(totalpagar * 0.14);

                    break;

                case "Tarjeta de Credito":
                    descuento = 7;
                    val_descuento = 0.07 * Total;
                    totalpagar = Total - val_descuento;
                    txt_totaltotal.Text = " $" + Convert.ToString(totalpagar);
                    txt_descuento.Text = " $" + Convert.ToString(descuento) + " %";
                    txt_IVA.Text = " $" + Convert.ToString(totalpagar * 0.14);
                    break;

                case "Cheque":
                    descuento = 3;
                    val_descuento = 0.03 * Total;
                    totalpagar = Total - val_descuento;
                    txt_totaltotal.Text = " $" + Convert.ToString(totalpagar);
                    txt_descuento.Text = Convert.ToString(descuento) + " %";
                    txt_IVA.Text = " $" + Convert.ToString(totalpagar * 0.14);
                    break;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            //Limpiar los campos
            txt_cant1.Text = "";
            txt_cant2.Text = "";
            txt_cant3.Text = "";
            txt_cant4.Text = "";

            txt_prod1.Text = "";
            txt_prod2.Text = "";
            txt_prod3.Text = "";
            txt_prod4.Text = "";

            txt_pUnitario1.Text = "";
            txt_pUnitario2.Text = "";
            txt_pUnitario3.Text = "";
            txt_pUnitario4.Text = "";

            txt_subT1.Text = "";
            txt_subT2.Text = "";
            txt_subT3.Text = "";
            txt_subT4.Text = "";

            txt_total.Text = "";
            txt_descuento.Text = "";
            txt_totaltotal.Text = "";

            txt_IVA.Text = "";
            txt_efectivo.Text = "";
            txt_vuelto.Text = "";

            //No limpia las variables...


        }
    }
}
