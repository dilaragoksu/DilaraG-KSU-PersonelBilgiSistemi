using PersonelBilgiSistemiDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelBilgiSistemiBL
{
    public class Repository<T> : IRepository<T> where T : class
    {
        ProjectContext pc = DBInstance.Instance;

        public T SelectById(int id)
        {
            return pc.Set(typeof(T)).Cast<T>().Find(id);
        }

        public void Güncelle(T item)
        {          
            pc.Entry(item).State = EntityState.Modified;         
            pc.SaveChanges();
        }

        public void Kaydet(T item)
        {
            pc.Set<T>().Add(item);
            pc.SaveChanges();
             
        }

        public List<T> SelectAll()
        {
            return pc.Set(typeof(T)).Cast<T>().ToList();
        }

        public void Sil(int id)
        {           
            pc.Set<T>().Remove(pc.Set<T>().Find(id));
            pc.SaveChanges();
        }
    }
}
