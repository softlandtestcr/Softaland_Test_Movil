using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SoftlandApiTest
{
    public class Limpieza
    {
        //sobrecarga demetodo limpiar para limpiar datos una vez actualizado o eliminado alguna tarea
        public void limpiar(Entry id,Entry name,Editor notes)
        {
            id.Text = "";
            name.Text = "";
            notes.Text = "";
        }

        public void limpiar(Entry name, Editor notes)
        {
          
            name.Text = "";
            notes.Text = "";
        }
    }
}
