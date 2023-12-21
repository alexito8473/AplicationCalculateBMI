namespace UD4T2;

using Microsoft.Maui.Controls;
using Syncfusion.Maui.Core.Carousel;
using Syncfusion.Maui.Gauges;
using System.ComponentModel;
using UD4T2.ViewModel;
///////////////////////////////////////////
// Tarea: UD4T2
// Alumno/a: Aguilar Alba Alejandro
// Curso: 2023/2024
///////////////////////////////////////////
/// <summary> Clase donde se realizan las opeaciones necesarias para el control de la página principal </summary>
/// <remarks>
/// En esta clase posee y hace los controles necesarios para el uso correcto de la pagina en cuestión. 
/// </remarks>  
public partial class BMIView : INotifyPropertyChanged {
    /// <summary> Propiedad de la clase  BMIView  </summary>
    /// <remarks>
    /// Atributo de tipo BMIViewModel, usado para la contrucción de los datos en la página, además de poder almacenar nuevos datos.
    /// </remarks>
    private BMIViewModel view;
    /// <summary> Constructor de la clase BMIView </summary>
    /// <remarks> Constructor que nos inializa los componentes del programa, además instanciar el atributo view </remarks>
    public BMIView()
    {
		InitializeComponent();
        view = new BMIViewModel();                                      // Instancio la clase BMIViewModel.
        BindingContext = view;
    }
    /// <summary> Método de detección de detección del SfLinearGauge de la Altura.</summary>
    /// <remarks> 
    /// Método que al detectar un cambio en los valores del SfLinearGauge, cambia automaticamente el valor 
    /// del SfLinearGauge.
    /// </remarks>
    /// <param name="sender"> Objeto de la acción</param>
    /// <param name=" e"> Tipo del evento</param>
    private void FunCambioAltura(object sender, EventArgs e) {
        if (ptrAltura!=null) {                                          // Compruebo que este instanciado la altura, para poder hacer uso de él.
            view.BMI.Altura = float.Parse(ptrAltura.Value.ToString());  // Parseo el valor recibio de la altura a float.
            cambioResultado();                                          // LLamo al método  cambioResultado() para que cambie a tiempo real la aguja.
        }
    }
    /// <summary> Método de detección de detección del SfLinearGauge del peso.</summary>
    /// <remarks> 
    /// Método que al detectar un cambio en los valores del SfLinearGauge, cambia automaticamente el valor 
    /// del SfLinearGauge.
    /// </remarks>
    /// <param name="sender"> Objeto de la acción</param>
    /// <param name=" e"> Tipo del evento</param>
    private void FunCambioPeso(object sender, EventArgs e) {
        if (ptrPeso != null) {                                          // Compruebo que este instanciado el peso, para poder hacer uso de él.
            view.BMI.Peso = float.Parse(ptrPeso.Value.ToString());      // Parseo el valor recibio del peso a float.
            cambioResultado();                                          // LLamo al método  cambioResultado() para que cambie a tiempo
        }
    }
    /// <summary> Método para cambiar los valores de la aguja y el título del BMI.</summary>
    /// <remarks> 
    /// Método que nos cambia los valores establecidos de la aguja y el título del BMI.
    /// </remarks>
    private void cambioResultado() {
        if (ptrAguja != null && textBMI!=null) {                        // Compruebo que este instanciado la aguja y el peso, para poder hacer uso de él.
            ptrAguja.Value = view.BMI.Resultado;                        // Cambio el valor de la aguja y del texto acorde a los valores del atributo global BMI.
            textBMI.Text = view.BMI.ResultadoBMI;
        }
    }
}