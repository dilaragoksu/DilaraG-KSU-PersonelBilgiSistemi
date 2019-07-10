using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelBilgiSistemiBL
{    
        public interface IRepository<T> where T : class
        {
            void Kaydet(T item);
            void Güncelle(T item);
            void Sil(int id);
            T SelectById(int id);
            List<T> SelectAll();
        }
   
}
