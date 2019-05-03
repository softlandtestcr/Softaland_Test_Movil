using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SoftlandApiTest
{
    public class Miscelanea
    {
       

        public void Limpiar(Entry name,Editor notes)
        {
            name.Text = "";
            notes.Text = "";

        }
    }
}
