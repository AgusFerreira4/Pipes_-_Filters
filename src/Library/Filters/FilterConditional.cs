using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using Ucu.Poo.Cognitive;

//Aca no supe como aplicar que sea IFilter y que retorne bool y no IPicture, porque en el diagrama se necesita que se retorne un bool simplemente
namespace CompAndDel.Filters;

public class FilterConditional : IConditionalFilter
{
    

    public bool Filter(int numImagen)
    {
        
        
        CognitiveFace cog = new CognitiveFace(true, Color.GreenYellow);
        cog.Recognize($@"C:\Users\ezefe\RiderProjects\Repo_PipesFilters\Pipes_-_Filters\src\Program\FiltroIntermedio{numImagen}.jpg");

        return cog.FaceFound;
    }
}