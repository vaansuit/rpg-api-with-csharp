using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataRPG.Context;
using DataRPG.Model;

namespace DataRPG.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();
            using (RPGContext warrenContext = new RPGContext()) //o using faz a conexão com o banco de dados ser fechada, para gerar mais segurança
            {
                list = warrenContext.Set<T>().ToList(); //transformando a classe em genérica
            }
            return list;
        }

        public virtual string Create(T model)
        {
            using (RPGContext warrenContext = new RPGContext())
            {
                warrenContext.Set<T>().Add(model);
                //adiciona a info em baixo sempre que faz uma alteração no banco
                warrenContext.SaveChanges();
            }

            return "Created";
        }


        public virtual string Delete(int id)
        {
            using (RPGContext rpgContext = new RPGContext())
            {
                rpgContext.Entry<T>(this.GetById(id)).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                rpgContext.SaveChanges();
            }
            return "Deletado pourran";
        }



        public virtual T GetById(int id)
        {
            T model = null;

            using (RPGContext rpgContext = new RPGContext()) //o using faz a conexão com o banco de dados ser fechada, para gerar mais segurança
            {
                model = rpgContext.Set<T>().Find(id); //transformando a classe em genérica
            }
            return model;
        }

        public virtual string Update(T model)
        {
            using (RPGContext rpgContext = new RPGContext())
            {
                rpgContext.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                rpgContext.SaveChanges();
            }

            return "Alterado";
        }
    }
}
