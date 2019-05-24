using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectHammer.Service.Interfaces
{
    /// <summary>
    ///Generic service interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IService<T> where T : class
    {

        /// <summary>
        /// Adds entity
        /// </summary>
        /// <param name="entity">entity</param>
         Task Add(T entity) ;

        /// <summary>
        /// Deletes entity
        /// </summary>
        /// <param name="entity">entity</param>
        Task Delete(T entity);

        /// <summary>
        /// Updates entity
        /// </summary>
        /// <param name="entity">entity</param>
       Task Update(T entity);
    }
}
