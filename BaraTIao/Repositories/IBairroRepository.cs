using ModelBaraTIao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaraTIao.Repositories
{
    public interface IBairroRepository
    {

        IEnumerable<Bairro> GetBairros();
        Bairro GetBairroById(int id);
        void CreateBairro(Bairro cupcake);
        void DeleteBairro(int id);
        void SaveChanges();


    }
}
