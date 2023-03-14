namespace WindowsFormsApp.TicariOtomasyon.Interface.BaseInterface
{
    public  interface IRepository<T> : IAdd<T>,IUpdate<T>,IRemove<T>,IGetList<T> where T : class
    {

    }
}
