using System;


namespace EjemplosInterfaces
{
    abstract class LineaBlanca // creamos las clase generadora de otras clases
    {
        #region Atributos
        private string marca;
        private string modelo;
        #endregion

        #region Propiedades
        public string Marca { 
            get => marca;
            set
            {
                if( value == "")
                {
                    marca = "LG";
                }
                else
                {
                    marca = value;
                }                
            }
        }
        public string Modelo { get => modelo;
            set
            {
                if( value == "")
                {
                    modelo = "2022";
                }
                else
                {

                    modelo = value;
                }
                
            }
        }
        #endregion
    }
}
