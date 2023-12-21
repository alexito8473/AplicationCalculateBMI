using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD4T2.ViewModel{
    /// <summary> Clase de las variables constantes del proyecto </summary>
    /// <remarks>
    /// Clase donde almacenan las distintas clases que van a ser utilizadas alrededor de la aplicación.
    /// </remarks>
    class Constantes{
        /*
         * Los atributos son readonly para que no se puedan modificar en el resto del proyecto.
         * Los atributos son estáticos para que no haga falta instanciar la clase para hacer uso de ellos.
         * Los atributos son públicos para que cualquier usuario pueda hacer uso de ellos.
         */
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo string pertenecientes al objeto,donde se almacena un titular. </remarks>
        public readonly static string RESULT_DEL_SEV = "BMI: Delgado Severo";
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo string pertenecientes al objeto,donde se almacena un titular. </remarks>
        public readonly static string RESULT_DEL_MOD = "BMI: Delgado Moderado";
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo string pertenecientes al objeto,donde se almacena un titular. </remarks>
        public readonly static string RESULT_DEL_MED = "BMI: Delgado Medio";
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo string pertenecientes al objeto,donde se almacena un titular. </remarks>
        public readonly static string RESULT_NOR = "BMI: Normal";
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo string pertenecientes al objeto,donde se almacena un titular. </remarks>
        public readonly static string RESULT_SOB = "BMI: Sobrepeso";
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo string pertenecientes al objeto,donde se almacena un titular. </remarks>
        public readonly static string RESULT_OBE_1 = "BMI: Obesidad Clase I";
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo string pertenecientes al objeto,donde se almacena un titular. </remarks>
        public readonly static string RESULT_OBE_2 = "BMI: Obesidad Clase II";
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo string pertenecientes al objeto,donde se almacena un titular. </remarks>
        public readonly static string RESULT_OBE_3 = "BMI: Obesidad Clase III";
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo int pertenecientes al objeto,donde se almacena un número. </remarks>
        public readonly static int NUM_TOPE_DEL_SEV = 16;
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo int pertenecientes al objeto,donde se almacena un número. </remarks>
        public readonly static int NUM_TOPE_DEL_MOD = 17;
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo float pertenecientes al objeto,donde se almacena un decimal. </remarks>
        public readonly static float NUM_TOPE_DEL_MED = 18.5f;
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo int pertenecientes al objeto,donde se almacena un número. </remarks>
        public readonly static int NUM_TOPE_NOR = 25;
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo int pertenecientes al objeto,donde se almacena un número. </remarks>
        public readonly static int NUM_TOPE_SOB = 30;
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo int pertenecientes al objeto,donde se almacena un número. </remarks>
        public readonly static int NUM_TOPE_OBE_1 = 35;
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo int pertenecientes al objeto,donde se almacena un número. </remarks>
        public readonly static int NUM_TOPE_OBE_2 = 40;
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo int pertenecientes al objeto,donde se almacena un número. </remarks>
        public readonly static int NUM_ALTURA_INICIO = 25;
        /// <summary> Atributo de la clase Constantes </summary>
        /// <remarks> Atributo de tipo int pertenecientes al objeto,donde se almacena un número. </remarks>
        public readonly static int NUM_PESO_INICIO = 50;
    }
}
