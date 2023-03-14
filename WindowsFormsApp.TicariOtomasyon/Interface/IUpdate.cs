
namespace WindowsFormsApp.TicariOtomasyon.Interface
{
    public interface IUpdate<T> where T : class
    {
        int Update(T item);
    }
}
