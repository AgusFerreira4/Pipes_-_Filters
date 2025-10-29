using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using SixLabors.ImageSharp.Formats.Jpeg;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PipeNull pipeNull = new PipeNull();
            PipeSerial pipeSerial5 = new PipeSerial(new FilterSave(), pipeNull);
            PipeSerial pipeSerial4 = new PipeSerial(new FilterNegative(), pipeSerial5);
            PipeSerial pipeSerial3 = new PipeSerial(new TwitterFilter(), pipeNull);
            PipeConditionalFork pipeconditional = new PipeConditionalFork(new FilterConditional(), pipeSerial3, pipeSerial4);
            PipeSerial pipeSerial2 = new PipeSerial(new FilterSave(), pipeconditional);
            PipeSerial pipeSerial1 = new PipeSerial(new FilterGreyscale(), pipeSerial2);
            

            PictureProvider provider = new PictureProvider();
            PictureProvider provider2 = new PictureProvider();
            IPicture picture = provider.GetPicture(@"..\\..\\..\\luke.jpg");
            IPicture picture2 = provider2.GetPicture(@"..\\..\\..\\beer.jpg");

            pipeSerial1.Send(picture);
            pipeSerial1.Send(picture2);
           
        }
    }
}

