namespace WindowsFormsApp.TicariOtomasyon.Interface
{
    public  interface IAdd<T> where T : class
    {
        int Add(T item);
    }
}
