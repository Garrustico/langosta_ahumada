using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIproyecto
{
    internal class calculoPresupuesto : IIproyecto
    {
        //declaración de variables
        int respresupuesto = 0;
        int precioPersona = 95;

        //Realiza el calculo del presupuesto
        public int calculo()
        { 
            //Por medio de manejo de excepciones
            try
            {
                //si son menos de 200 personas el costo es 95 por persona, si es verdadero se ejecuta
                if (_Persona < 200)
                {
                    precioPersona = 95;
                    respresupuesto = _Persona * precioPersona;
                }
                else if (_Persona >= 200 && _Persona <= 300) //si son mayor o igual a 200 y menor o igual a 300 el costo es de 85
                {
                    precioPersona = 85;
                    respresupuesto = _Persona * precioPersona;
                }
                else if (_Persona > 300) //si es mayor de 300 personas el costo es 75 por persona
                {
                    precioPersona = 75;
                    respresupuesto = _Persona * precioPersona;
                }
            }
            catch (Exception ex) //captura alguna excepción que se pueda dar
            { 
                MessageBox.Show("Error: " + ex.Message);
            }

            return respresupuesto; //retorna el resultado del presupuesto 
        }

        //constructor con parametros
        public calculoPresupuesto(int numpersona, int ncotizacion)
        {
            _Persona = numpersona;
            _Ncotizacion = ncotizacion;
        }
    }
}
