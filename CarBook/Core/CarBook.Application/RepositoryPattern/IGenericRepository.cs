using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.RepositoryPattern
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        void Create(T entity);
        T GetById(int id);
        void Remove(Comment entity);
        void Update(T entity);
        //List<T> GetCommentsByBlogId(int id);

    }
}
