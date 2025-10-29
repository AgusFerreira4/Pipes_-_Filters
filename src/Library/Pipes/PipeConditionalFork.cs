using CompAndDel.Filters;

namespace CompAndDel.Pipes;

public class PipeConditionalFork : IPipe
{
    protected IConditionalFilter filtro;
    protected IPipe nextPipeSC;
    protected IPipe nextPipeCC;
    
    public PipeConditionalFork(IConditionalFilter filtro, IPipe nextPipeCC, IPipe nextPipeSC) //Aca me estoy "casando" con la implementacion de que pipecondtionalfork solo pueda tener IconditionalFilters? 
    {
        this.filtro = filtro;
        this.nextPipeCC = nextPipeCC;
        this.nextPipeSC = nextPipeSC;

    }
    
    public IPipe Next
    {
        get { return this.nextPipeSC; }
    }
    
    public IConditionalFilter Filter
    {
        get { return this.filtro; }
    }
    
    public IPicture Send(IPicture picture)
    {
        bool result = this.filtro.Filter(FilterSave.numImagen); // Esta no creo que sea la solucion correcta, pero no se me oucrrio nada mas, yo cambiara que cada picture conozca su ruta asi es muhco mas sencilla la implementacion de cognitiveApi
        if (result)
        {
            return this.nextPipeCC.Send(picture);
        }
        else
        {
            return this.nextPipeSC.Send(picture);
        }

    }
    
}