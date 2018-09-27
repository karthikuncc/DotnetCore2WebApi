
using System.Collections.Generic;

namespace EmployeeDetails.API.Interfaces
{
    public interface IRepository<T>
    {

        IEnumerable<T> List ();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);  
    }
}
