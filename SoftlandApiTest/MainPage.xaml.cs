using Newtonsoft.Json;
using RestSharp;
using SoftlandApiTest.ModelTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SoftlandApiTest
{
    
    public  partial class MainPage : ContentPage
    {

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>

        private void ListaView_ListaTareas_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            
        }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        /// 
        //Metodo get para listar las tareas en el listview
        private async Task  peticionGET()
        {
               await Task.Run(() =>
                {
                    try
                    {

                        Device.BeginInvokeOnMainThread(() => {

                            estado.Text = "Por favor espere...";

                            estado.IsVisible = true;

                        });//muestra label de estado 
                       

                        var client = new RestClient("https://softlandapi.herokuapp.com/TodoApi/api/TodoItems/ConsultarItems");

                        var request = new RestRequest(Method.GET);

                        request.AddHeader("cache-control", "no-cache");

                        var respuesta =client.Execute<Tarea>(request);

                       List<Tarea> mistareas = JsonConvert.DeserializeObject<List<Tarea>>(respuesta.Content);

                        if (mistareas.Count>0)//si la lista de tareas contiene datos los agrega al listview
                        {
                            Device.BeginInvokeOnMainThread(() => {

                                ListaView_ListaTareas.ItemsSource = null;

                                ListaView_ListaTareas.ItemsSource = mistareas;

                                estado.IsVisible = false;

                            });//agrega los datos al listview y oculta label de estado
                        }
                       
                       

                    }
                    catch (Exception a)
                    {

                        Device.BeginInvokeOnMainThread(() => {

                            DisplayAlert("No hubo conexión", "La lista de tareas no pudo ser cargada. Intentelo más tarde", "OK");

                        });
                    }

                });
            
           
            
        }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
           

           await peticionGET();
          
        }


        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>



        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                //MetodoPushAsync para abrir el view de Crear Tarea
                await Navigation.PushAsync(new CrearTarea());
            }
            catch (Exception h)
            {
                Device.BeginInvokeOnMainThread(() => {

                    DisplayAlert("No hubo conexión", "No hemos podido abrir la sección solicitada. Intentelo más tarde", "OK");

                });

            }
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>

        private async void ListaView_ListaTareas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            try
            {
                var elem = e.SelectedItem as Tarea;// se captura el item seleccionado en la variable elem

    
                // se abre el view de Modificar tarea y se le envian los datos en el constructor
                await Navigation.PushAsync(new ModificarTarea(elem.id,elem.name,elem.notes,elem.done.ToString()));
            }
            catch (Exception h)
            {
                Device.BeginInvokeOnMainThread(() => {

                    DisplayAlert("No hubo conexión", "No hemos podido abrir la sección solicitada. Intentelo más tarde", "OK");

                });

            }
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>

    }
}
