using Burgershack.Data;
using Burgershack.Entities;
using System;
using System.Collections.Generic;

namespace Burgershack.Business
{
    public class SidesService
    {
        private readonly ISidesRepo _repo;

        public SidesService(ISidesRepo repo)
        {
            _repo = repo;
        }

        public Side GetById(int id)
        {
            //authenticate here maybe
            return _repo.GetById(id);
        }

        public List<Side> GetAll()
        {
            return _repo.GetAll();
        }

        public Side UpdateSide(Side b)
        {
            //do some work
            return _repo.Update(b);
        }

        public Side Create(Side side)
        {
            return _repo.Create(side);
        }
    }
}
