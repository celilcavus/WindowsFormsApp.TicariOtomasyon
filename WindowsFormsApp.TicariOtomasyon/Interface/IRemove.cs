namespace WindowsFormsApp.TicariOtomasyon.Interface
{
    public interface IRemove<T> where T : class
    {
        int Remove(T item);
    }
}
