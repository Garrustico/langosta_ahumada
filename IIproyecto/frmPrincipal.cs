using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Para poder realizar manejo de archivos

namespace IIproyecto
{
    public partial class frmPrincipal : Form
    {
        //Ruta directa al documento txt
        public string filePath = @"C:\langosta_ahumada\cotizaciones.txt";

        public frmPrincipal()
        {
            InitializeComponent();
            cargaListView();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Salir de la aplicación pormedio del menuStrip
        }

        public void limpiar() //Limpia los textbox
        {
            txtPersonas.Clear();
            txtNumCotizacion.Clear();
            txtConsulta.Clear();
        }

        public void cargaListView() //Muestra la barra de elementos del ListView
        {
            lsvResultados.Clear();
            lsvResultados.Columns.Add("N° cotización").Width = 125;
            lsvResultados.Columns.Add("N° personas").Width = 125;
            lsvResultados.Columns.Add("Presupuesto").Width = 130;
        }

        //Se valida que el usuario no ingrese un valor que no sea números
        private void txtPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            IIproyecto validar = new IIproyecto();
            validar.validarNumeros(e);
        }

        private void txtConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            IIproyecto validar = new IIproyecto();
            validar.validarNumeros(e);
        }

        private void txtNumCotizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            IIproyecto validar = new IIproyecto();
            validar.validarNumeros(e);
        }

        //Llama los métodos que se van a ejecutar al darle al botón calcular
        private void btnCalcular_Click(object sender, EventArgs e) 
        {
            resultado();
            guardar();
        }


        public void resultado()
        {
            //Se convierte a Entero los textbox
            int numpersona = Convert.ToInt16(txtPersonas.Text);
            int ncotizacion = Convert.ToInt16(txtNumCotizacion.Text);

            //Se crea una instancia en la variable calcular de la clase hija calculoPresupuesto y pasa dos argumentos
            calculoPresupuesto calcular = new calculoPresupuesto(numpersona, ncotizacion);

            //Se llama el método calculo() de la clase hija
            int resultadoPresupuesto = calcular.calculo();

            //Se muestra el MessageBox con el resultado del presupuesto
            MessageBox.Show("El presupuesto de su coticación número: " + ncotizacion + " con: " + numpersona + " personas" + " es de: $" + resultadoPresupuesto.ToString(), "Resultado del presupuesto:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //Se añaden los datos de cotización, personas y presupuesto al ListView
            ListViewItem item = new ListViewItem(txtNumCotizacion.Text);
            item.SubItems.Add(txtPersonas.Text);
            item.SubItems.Add(resultadoPresupuesto.ToString());
            lsvResultados.Items.Add(item);
        }

        //Al presionar Limpiar del menuStrip llama al método limpiar y limpia el listview
        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
            cargaListView();
        }

        //Este método escribe datos en el archivo cotizaciones.txt y finaliza leyendo el archivo actualizado
        public void guardar()
        {
            //Abre el archivo de texto en modo escritura
            using (StreamWriter escribir = new StreamWriter(filePath, true))
            {
                //Verifica si numcotizacion y personas estan vacíos
                if (txtNumCotizacion.Text.Equals("") || txtPersonas.Text.Equals(""))
                {
                    //Muestra un Messagebox si el usuario deja un textbox en blanco
                    MessageBox.Show("Debe ingresar datos en ambas cajas de texto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPersonas.Focus();
                }
                else
                {
                    //Escribe una línea en el archivo de texto utilizado y separa el contenido por comas
                    escribir.WriteLine($"{txtNumCotizacion.Text},{txtPersonas.Text},{'$' + calcularPresupuesto()}");
                }
            }
            leerArchivo();
        }

        //Lee el archivo de texto y carga los datos en el listview
        public void leerArchivo()
        {
            cargaListView();

            //Abre y lee el archivo
            using (StreamReader leer = new StreamReader(filePath))
            {
                //lee linea por linea hasta su fin
                while (!leer.EndOfStream)
                {
                    //Lee una línea del archivo y la almacena en la variable linea
                    string linea = leer.ReadLine();
                    //Divide la linea en elemtos separados por comas y los alamcena en la variable linea
                    string[] separador = linea.Split(',');

                    //Verifica si hay mas de 3 elemetos
                    if (separador.Length >= 3)
                    {
                        //Agrega los elementos en el archivo
                        ListViewItem item = new ListViewItem(separador[0]);
                        item.SubItems.Add(separador[1]);
                        item.SubItems.Add(separador[2]);
                        lsvResultados.Items.Add(item);
                    }
                }
            }
        }

        //LLama al calculo del presupuesto para escribir el resultado del presupuesto en el método guardar()
        private string calcularPresupuesto()
        {
            //convierte los números en enteros
            int numpersona = Convert.ToInt16(txtPersonas.Text);
            int ncotizacion = Convert.ToInt16(txtNumCotizacion.Text);

            //son los constructores donde la clase CalculoPresupuesto realiza el cálculo
            calculoPresupuesto calcular = new calculoPresupuesto(numpersona, ncotizacion);

            //devuelve el resultado númerico y lo convierte en string y se devuelve como el resultado del metodo calcularPresupuesto()
            return calcular.calculo().ToString();
        }

        //busca el n° de cotización y lo muestra en el listview
        public void buscar()
        {
            //Se declara la variable para almacenar cada línea del archivo txt
            string linea;

            //Se declara la variable encontrado como falsa
            bool encontrado = false;

            //limpia el listview para que muestre solo el dato buscado
            lsvResultados.Items.Clear();

            //abre y lee el archivo
            using (StreamReader leer = new StreamReader(filePath))
            {
                //lee linea por linea hasta su fin
                while ((linea = leer.ReadLine()) != null)
                {
                    //separa los elementos por comas
                    string[] separador = linea.Split(',');

                    /* Si el separador posee mas de 3 elementos y el separador 0 es igual al número de cotización consultado
                    los muestra en un listview */
                    if (separador.Length >= 3 && separador[0].Trim() == txtConsulta.Text.Trim())
                    {
                        ListViewItem item = new ListViewItem(separador[0]);
                        item.SubItems.Add(separador[1]);
                        item.SubItems.Add(separador[2]);
                        lsvResultados.Items.Add(item);
                        encontrado = true;
                        break;
                    }
                }
                //Si el dato no fue encontrado se muestra un messagebox diciendo que no se encontró
                if (encontrado == false)
                {
                    MessageBox.Show("No se encontró el número de cotización ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtConsulta.Focus();
                }
            }
        }  

        //Se llama el método buscar al presionar el botón buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
    }
}
