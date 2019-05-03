using RestSharp;
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
	public partial class ModificarTarea : ContentPage
    { /// <summary>
      /// ///////////////////////////////////////////////////////////////////////////////////////////////
      /// </summary>
      /// <returns></returns>
      /// 
        Limpieza limpiar = new Limpieza();//instancia de la clase limpiar para llamar metodo limpiar 


        string idrecibido,namerecibido,notesrecibido,donerecibido;
		public ModificarTarea (string id,string name,string notes,string done)
		{
			InitializeComponent ();

            //agregar los datos al menu del picker y seleccionar posicion 0=false
            pickertext.Items.Add("false");

            pickertext.Items.Add("true");

            pickertext.SelectedIndex = 0;

            //recibo los parametros dados de mainpage para llenar los datos del id, nombre, etc para modificar o eliminar
            idrecibido = id;

            namerecibido = name;

            notesrecibido = notes;

            donerecibido = done;

        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        //Metodo put para modificar un Tarea
        private async Task PUT()
        {

            if (!string.IsNullOrEmpty(idtext.Text)&&

                !string.IsNullOrEmpty(nametext.Text) &&

                !string.IsNullOrEmpty(notestext.Text) &&

                !string.IsNullOrEmpty((pickertext.SelectedItem.ToString())))
            {

               await Task.Run(()=> {    
                    try
                    {
                       var client = new RestClient("https://softlandapi.herokuapp.com/TodoApi/api/TodoItems/ModificarItem/"+idtext.Text+"");

                       var request = new RestRequest(Method.PUT);

                       request.AddHeader("cache-control", "no-cache");

                       request.AddHeader("Content-Type", "application/json");

                       request.AddParameter("undefined", "{\n\t\"name\":\""+nametext.Text+"\",\n\t\"notes\":\""+notestext.Text+"\",\n\t\"done\":\""+pickertext.SelectedItem.ToString()+"\"\n}", ParameterType.RequestBody);

                       IRestResponse response = client.Execute(request);


                       ///si larespuesta fue correcta muestra mensaje confirmacion sino ....
                       Device.BeginInvokeOnMainThread(() => {

                           DisplayAlert("No hubo conexión", "Tarea modificada correctamente", "OK");

                           limpiar.limpiar(idtext,nametext,notestext);//metodo limpiar de la clase limpieza

                       });


                   }
                    catch (Exception l)
                    {
                       Device.BeginInvokeOnMainThread(() => {

                           DisplayAlert("No hubo conexión", "No hubo conexión con el servidor.Intente más tarde", "OK");

                       });

                   }

                });
               
            }
            else
            {
                Device.BeginInvokeOnMainThread(() => {

                    DisplayAlert("No hubo conexión", "Faltan datos", "OK");

                });
            }
           
        
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>

        //Metodo delete para eliminar una Tarea

        private async Task DELETE()
        {
            if (!string.IsNullOrEmpty(idtext.Text))
            {
                await Task.Run(() => {
                    try
                    {
                        var client = new RestClient("https://softlandapi.herokuapp.com/TodoApi/api/TodoItems/EliminarItem/"+idtext.Text+"");

                        var request = new RestRequest(Method.DELETE);

                        request.AddHeader("cache-control", "no-cache");

                        IRestResponse response = client.Execute(request);
                        // si la respuesta recibida al hacer la peticion delete fue correcta muestra mensaje sino ...
                        if (response.StatusCode.ToString()=="OK")
                        {

                            Device.BeginInvokeOnMainThread(() => {

                                DisplayAlert("Proceso correcto", "Tarea eliminada correctamente", "OK");

                                limpiar.limpiar(idtext, nametext, notestext);//metodo limpiar de la clase limpieza

                            });
                        }
                        else
                        {
                            Device.BeginInvokeOnMainThread(() => {

                                DisplayAlert("No hubo conexión", "No hubo conexión con el servidor.Intente más tarde", "OK");

                            });
                        }
                       

                    }
                    catch (Exception o)
                    {

                        Device.BeginInvokeOnMainThread(() => {

                            DisplayAlert("No hubo conexión", "No hubo conexión con el servidor.Intente más tarde", "OK");

                        });
                    }


                });
            }
            else
            {
                Device.BeginInvokeOnMainThread(() => {

                    DisplayAlert("No hubo conexión", "No hay suficientes datos para realizar la operación", "OK");

                });
            }
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>

        private async void Buttontext_Clicked(object sender, EventArgs e)
        {
            await PUT();
        }


        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        private async void Buttontexteliminar_Clicked(object sender, EventArgs e)
        {
            await DELETE();
        }


        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        /// 
         //Metodo appearing se ejecuta al cargar la ventana o view  actual
        private void ContentPage_Appearing(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrEmpty(idrecibido)&&
                
                !string.IsNullOrEmpty(namerecibido)&&

                !string.IsNullOrEmpty(notesrecibido) &&

                !string.IsNullOrEmpty(donerecibido))//si los datos recibidos  son diferente de null....
            {
                idtext.Text = idrecibido;

                nametext.Text = namerecibido;

                notestext.Text = notesrecibido;

                if (donerecibido.ToLowerInvariant()=="false")
                {
                   
                    pickertext.SelectedIndex = 0;
                }
                else
                {
                    pickertext.SelectedIndex = 1;
                }
            }       
         
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
    }
}