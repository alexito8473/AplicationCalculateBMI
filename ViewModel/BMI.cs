using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UD4T2.ViewModel{
    /// <summary> Clase sobre el indice masa corpotal </summary>
    /// <remarks>
    /// Clase donde se realizaran los calculos oportunos sobre la BMI, y almacena los datos necesario para su calculo.
    /// </remarks>  
    class BMI : INotifyPropertyChanged {
        /// <summary> Propiedad de la clase BMI </summary>
        /// <remarks> Se establece la altura del usuario </remarks>
        private float altura;
        /// <summary> Atributo de la clase BMI. </summary>
        /// <remarks> Se establece el peso del usuario. </remarks>
        private float peso;
        /// <summary> Propiedad de la clase BMI </summary>
        /// <remarks>
        /// El método instancia consigo los metodos getter y setter del atributo.
        /// Se establece la altura del usuario
        /// </remarks>
        public float Altura { get => altura;  set { altura = value; OnPropertyChanged(); }  }
        /// <summary> Método de la clase BMI </summary>
        /// <remarks>
        /// El método instancia consigo los metodos getter y setter del atributo.
        /// Se establece el peso del usuario
        /// </remarks>
        public float Peso { get => peso; set { peso = value; OnPropertyChanged(); } }
        /// <summary> Propiedad de la clase BMI </summary>
        /// <remarks>
        /// La propiedad instancia consigo el metodo getter del atributo.
        /// Se establece el indice de la masa corportal del usuario.
        /// </remarks>
        public float Resultado { get => (Peso / (Altura * Altura)) * Constantes.MULTIPLICADOR_BMI; }
        /// <summary> Propiedad de la clase BMI </summary>
        /// <remarks>
        /// La propiedad instancia consigo el metodo getter del atributo.
        /// Se establece un titulo correspondiente a la BMI del usuario. 
        /// </remarks>
        public string ResultadoBMI { 
            get{
                return Resultado switch {                                                                   // Utilizo un switch de expresiones para poder realizar 
                    _ when Resultado <= Constantes.NUM_TOPE_DEL_SEV => Constantes.RESULT_DEL_SEV,           // más facil y comoda la selección de los valores.
                    _ when Resultado <= Constantes.NUM_TOPE_DEL_MOD => Constantes.RESULT_DEL_MOD,
                    _ when Resultado <= Constantes.NUM_TOPE_DEL_MED => Constantes.RESULT_DEL_MED,           // Uso constantes debido que es mas facil trabajar con ellos
                    _ when Resultado <= Constantes.NUM_TOPE_NOR => Constantes.RESULT_NOR,        
                    _ when Resultado <= Constantes.NUM_TOPE_SOB => Constantes.RESULT_SOB,
                    _ when Resultado <= Constantes.NUM_TOPE_OBE_1 => Constantes.RESULT_OBE_1,
                    _ when Resultado <= Constantes.NUM_TOPE_OBE_2 => Constantes.RESULT_OBE_2,
                    _ => Constantes.RESULT_OBE_3
                } ; 
            } }
        /// <summary> Propiedad de la clase BMI, heredado de la interfaz INotifyPropertyChanged. </summary>
        /// <remarks> La propiedad se trata de un controlador de evento. </remarks>
        public event PropertyChangedEventHandler? PropertyChanged;
        /// <summary> Método de la clase BMI </summary>
        /// <remarks>
        /// Se utiliza para hacer una llamada de evento.
        /// </remarks>
        protected void OnPropertyChanged([CallerMemberName] string name = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
