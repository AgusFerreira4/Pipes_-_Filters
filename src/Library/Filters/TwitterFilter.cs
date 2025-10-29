using System;

namespace CompAndDel.Filters;
using Ucu.Poo.Twitter;

public class TwitterFilter : IFilter
{
    public IPicture Filter(IPicture image)
    {
        IPicture result = image.Clone();
        
        var twitter = new TwitterImage();
        Console.WriteLine(twitter.PublishToTwitter("prueba1", $@"C:\Users\ezefe\RiderProjects\Repo_PipesFilters\Pipes_-_Filters\src\Program\FiltroIntermedio{FilterSave.numImagen}.jpg"));

        return result;
    }
}