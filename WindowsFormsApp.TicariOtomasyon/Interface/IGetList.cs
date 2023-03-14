
using System.Collections.Generic;

namespace WindowsFormsApp.TicariOtomasyon.Interface
{
    public interface IGetList<T> where T : class
    {
        List<T> getList();
    }
}
