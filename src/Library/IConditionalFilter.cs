using System;

namespace CompAndDel
{
    /// El filtro se encarga de procesar la imagen segun su nombre y numero en la ruta, para poder devolver si esa imagen tiene cara o no
    /// como booleano
    public interface IConditionalFilter
    {
       
        bool Filter(int numImagen);
    }
}