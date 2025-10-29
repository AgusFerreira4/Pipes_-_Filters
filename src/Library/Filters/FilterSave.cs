using System;

namespace CompAndDel.Filters;

public class FilterSave : IFilter
{
    public static int numImagen { get; private set; } //Numero global que ayuda a identificar la imagen con el filtro de greyscale aplicado para que la cogitiveapi tenga la ruta correcta
    public IPicture Filter(IPicture image)
    {
        
        IPicture result = image.Clone();
        PictureProvider provider = new PictureProvider();

        numImagen ++;
        provider.SavePicture(result, $@"C:\Users\ezefe\RiderProjects\Repo_PipesFilters\Pipes_-_Filters\src\Program\FiltroIntermedio{numImagen}.jpg");
        
        return result;
    }

}