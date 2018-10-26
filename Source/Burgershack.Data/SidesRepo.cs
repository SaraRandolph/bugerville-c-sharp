using Burgershack.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace Burgershack.Data
{
    public interface ISidesRepo
    {
        //crud
        Side GetById(int id);
        Side Update(Side side);
        List<Side> GetAll();
        Side Create(Side burger);
    }

    public class SidesRepo : ISidesRepo
    {
        private readonly IDbConnection _db;

        public List<Side> GetAll()
        {
            return FakeDb.Sides;
        }

        public Side GetById(int id)
        {
            return FakeDb.Sides.Find(b => b.Id == id);
        }

        public Side Update(Side burger)
        {
            var b = GetById(burger.Id);
            if (b == null) { throw new Exception("Side not found, Bad ID"); }
            b.Name = burger.Name;
            b.Description = burger.Description;
            b.Price = burger.Price;
            return b;
        }

        public Side Create(Side burger)
        {
            burger.Id = FakeDb.NextId;
            FakeDb.NextId += 1;
            FakeDb.Sides.Add(burger);
            return burger;
        }

        public SidesRepo(IDbConnection db)
        {
            _db = db;
        }

    }
}
