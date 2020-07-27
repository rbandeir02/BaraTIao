using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using BaraTIao.Data;
using BaraTIao.Models;
using Microsoft.EntityFrameworkCore;
using ModelBaraTIao;

namespace BaraTIao.Repositories
{
    public class BairroRepository : IBairroRepository
    {
   
        private BaratiaoContext _context;

        public BairroRepository(BaratiaoContext context)
        {
            _context = context;
        }

        public IEnumerable<Bairro> GetBairros()
        {
            return _context.Bairros.ToList();
        }

        public Bairro GetBairroById(int id)
        {
            return _context.Bairros.SingleOrDefault(c => c.Id == id);
        }

        public void CreateBairro(Bairro cupcake)
        {
            _context.Add(cupcake);
            _context.SaveChanges();
        }

        public void DeleteBairro(int id)
        {
            var bairro = _context.Bairros.SingleOrDefault(c => c.Id == id);
            _context.Bairros.Remove(bairro);
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}

