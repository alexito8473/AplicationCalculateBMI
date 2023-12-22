using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD4T2.ViewModel {
    /// <summary> Clase modelo del BMI </summary>
    /// <remarks>
    /// Clase donde se realizaran los calculos oportunos sobre la BMI, y almacena los datos necesario para su calculo.
    /// </remarks>
    class BMIViewModel {
        /// <summary> Atributo de la clase BMIViewModel </summary>
        /// <remarks>
        /// El atributo instancia consigo los metodos getter y setter del atributo.
        /// Se establece la clase BMI de la clase
        /// </remarks>
        public BMI BMI { get; set; }
        /// <summary> Constructor de la clase BMIViewModel </summary>
        /// <remarks>
        /// Se instancia el atributo BMI con valor establecidos por la clase Constantes
        /// </remarks>
        public BMIViewModel() {
            BMI = new BMI { Peso = Constantes.NUM_PESO_INICIO, Altura = Constantes.NUM_ALTURA_INICIO };        // Se instancia la variable
        }
    }
}
