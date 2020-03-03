public class MinhaClasseGenerica<T>
{
    private T Field;

    public void Add(T arg)
    {
        Field = arg;
    }

    public T Get(){
        return Field;
    }
}