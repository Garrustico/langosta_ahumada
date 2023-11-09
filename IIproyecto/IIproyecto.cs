using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIproyecto
{
    internal class IIproyecto
    {
        //declaración de campos privados 
        private int persona;
        private int ncotizacion;
        private int presupuesto;

        //declaración de propiedades protegidas 
        protected int _Persona { get => persona; set => persona = value; }
        protected int _Ncotizacion { get => ncotizacion; set => ncotizacion = value; }
        protected int _Presupuesto { get => presupuesto; set => presupuesto = value; }

        //Se valida que el usuario no ingrese datos que no sean números
        public KeyPressEventArgs validarNumeros(KeyPressEventArgs e)
        {
            //Permite digitos
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else //Todos los demas no se permiten
            {
                e.Handled = true;
            }

            //devuelve el caracter permitido
            return e;
        }

        //constructor con parametros
        public IIproyecto(int numpersonas, int numcotizacion, int represupuesto)
        {
            //tres argumentos
            this.persona = numpersonas;
            this.ncotizacion = numcotizacion;
            this.presupuesto = represupuesto;
        }

        //constructor sin parametros
        public IIproyecto()
        {

        }
    }
}
