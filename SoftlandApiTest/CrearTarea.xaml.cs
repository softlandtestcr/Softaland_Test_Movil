using Newtonsoft.Json;
using RestSharp;
using SoftlandApiTest.ModelTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoftlandApiTest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CrearTarea : ContentPage
	{
        Limpieza limpiar = new Limpieza();//instancia de la clase limpiar para llamar metodo limpiar 

		public CrearTarea ()
		{
			InitializeComponent ();
		}


        private async Task Post()
        {

            if (!string.IsNullOrEmpty(nametext.Text)&&

                !string.IsNullOrEmpty(notestext.Text)&&

                !string.IsNullOrEmpty(pickertext.SelectedItem.ToString()))
            {
                try
                {
                    var client = new RestClient("https://softlandapi.herokuapp.com/TodoApi/api/TodoItems/IngresarItem");

                    var request = new RestRequest(Method.POST);

                    request.AddHeader("cache-control", "no-cache");

                    request.AddHeader("Content-Type", "application/json");

                    request.AddParameter("undefined", "{\n\t\"name\":\""+nametext.Text+"\",\n\t\"notes\":\""+notestext.Text+"\",\n\t\"done\":\""+pickertext.SelectedItem.ToString()+"\"\n}", ParameterType.RequestBody);

                    IRestResponse response = client.Execute(request);

                    if (response.StatusCode.ToString()=="Created")
                    {
                        Device.BeginInvokeOnMainThread(() => {

                            DisplayAlert("Tarea Guardada", "La tarea se guardó correctamente", "OK");

                            limpiar.limpiar(nametext,notestext);//metdo limpiar de la clase limpieza

                        });
                    }
                    else
                    {
                        Device.BeginInvokeOnMainThread(() => {

                            DisplayAlert("No hubo conexión", "No hubo conexión con el servidor. Intente más tarde", "OK");

                        });
                    }




                }
                catch (Exception t)
                {

                    Device.BeginInvokeOnMainThread(() => {

                        DisplayAlert("No hubo conexión", "No hubo conexión con el servidor. Intente más tarde", "OK");

                    });
                }
            }
            else
            {
                Device.BeginInvokeOnMainThread(() => {

                    DisplayAlert("No hubo conexión", "Por favor ingrese todos los datos", "OK");

                });
            }
           
        }

        private async void Butontext_Clicked(object sender, EventArgs e)
        {
            await Post();
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            //agregar los datos al menu del picker y seleccionar posicion 0=false
            pickertext.Items.Add("false");

            pickertext.Items.Add("true");

            pickertext.SelectedIndex = 0;
        }
    }
}