using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{



    public partial class Form1 : Form
    {

        
          
        
        
        public  Form1()
        {
            InitializeComponent();

        


          
        }

        private void label1_Click(object sender, EventArgs e )
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num7_Click(object sender, EventArgs e)
        {

        }





        private void num1_Click(object sender, EventArgs e)
        {
         
        }

        private void num3_Click(object sender, EventArgs e)
        {

        }


        private void num8_Click(object sender, EventArgs e)
        {
          
        }

        private void pantalla_Click(object sender, EventArgs e)
        {

        }

        private void num2_Click(object sender, EventArgs e)
        {

        }

        private void num4_Click(object sender, EventArgs e)
        {

        }

        private void num5_Click(object sender, EventArgs e)
        {

        }

        private void num6_Click(object sender, EventArgs e)
        {

        }

        private void num9_Click(object sender, EventArgs e)
        {

        }

        private void num0_Click(object sender, EventArgs e)
        {

        }



        private void numpunto_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {   /*codigo para borrar*/
            if (pantalla.Text.Length > 0)
                pantalla.Text = pantalla.Text.Remove(pantalla.Text.Length - 1, 1);

            if (pantalla2.Text.Length > 0)
                pantalla2.Text = pantalla2.Text.Remove(pantalla2.Text.Length - 1, 1);
        }

        private void clickBotones(object sender, EventArgs e)
        {
            /*codigo para los numeros de los botones*/
            Button num = (Button)sender;
            if (pantalla.Text == "00.00" && pantalla2.Text == "00.00")
            {
                pantalla.Text = num.Text;
                pantalla2.Text = num.Text;
            }
            else
            {
                pantalla.Text = pantalla.Text + num.Text;
                pantalla2.Text = pantalla2.Text + num.Text;

            }




            /*codigo para generar el guion */

            if (pantalla.Text.Length == 1 || pantalla.Text.Length == 3 || pantalla.Text.Length == 5 || pantalla.Text.Length == 7)
            {
                pantalla.Text = pantalla.Text + "-";
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*codigo acciones*/

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            alerta.Text = "Cuanto Desea Retirar?";

            btn200.Visible = true; 
            btn500.Visible = true;
            btn1000.Visible = true;
            btn1500.Visible = true;
            btn2000.Visible = true;
            otros.Visible = true;



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   /*la variable random para la consulta*/
            Random numero = new Random();
            int numero1;
            numero1 = numero.Next();
            
            /*cambiar las pantallas*/
            pantalla.Text = "";
            alerta.Text = "Cantidad disponible";
            cantidad.Text = "" + numero1;

            cantidad.Visible = true;
            pantalla2.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void button11_Click(object sender, EventArgs e)
        { /*para confirmar la entrada si tiene los numeros o pin de la targeta escrita correctamente*/
            if (pantalla.Text.Length == 8)
            {
                alerta.Text = "Selecciona una Cuenta ";
                pantalla.Text = "";
                cuentaDeAhorro.Visible = true;
                cuentaCorriente.Visible = true;



            }
            else {
                MessageBox.Show("INGRESE CORRECTAMENTE SU PIN");
                pantalla.Text = ""; }


        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pantalla_Click_1(object sender, EventArgs e)
        {

        }

        private void centasClick(object sender, EventArgs e)
        {
            transferencia.Visible = true;
            claves.Visible = true;
            otras.Visible = true;
            extraccionRapida.Visible = true;
            adelanto.Visible = true;
            recarga.Visible = true;
            consulta.Visible = true;
            pago.Visible = true;
            pantalla.Visible = false;
            cuentaDeAhorro.Visible = false;
            cuentaCorriente.Visible = false;
            alerta.Text = "Bienvenido Alex \nElige una operacion";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int retiro = Convert.ToInt32(pantalla2.Text);
            alerta.Text = "Cantidad Retirada " + retiro;
            pantalla2.Visible = false;


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form1 formulario = new Form1();

        }


        
     

        private void cantidadARetirar(object sender, EventArgs e)
        {


            Button num = (Button)sender;

            btn200.Visible = false;
            btn500.Visible = false;
            btn1000.Visible = false;
            btn1500.Visible = false;
            btn2000.Visible = false;
            alerta.Visible = false;
            pantalla3.Visible = true;
            pantalla3.Text ="Estas seguro que deseas retirar \n "+ num.Text+" pesos?";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

          alerta.Text = "Digite la cantidad a retirar";

          pantalla2.Text = "";
           btn200.Visible = false;
           btn500.Visible = false;
           btn1000.Visible = false;
           btn1500.Visible = false;
           btn2000.Visible = false;
           alerta.Visible = true;

           pantalla.Visible = false;
           cantidad.Visible = false;
           pantalla2.Visible = true;
           retirar.Visible = true;
        }
    }
}
  
         
            
        
         
