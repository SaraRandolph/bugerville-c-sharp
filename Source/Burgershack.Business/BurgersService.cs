﻿using Burgershack.Data;
using Burgershack.Entities;
using System;
using System.Collections.Generic;

namespace Burgershack.Business
{
    public class DrinksService
    {
        private readonly IDrinksRepo _repo;

        public DrinksService(IDrinksRepo repo)
        {
            _repo = repo;
        }

        public Drink GetById(int id)
        {
            //authenticate here maybe
            return _repo.GetById(id);
        }

        public List<Drink> GetAll()
        {
            return _repo.GetAll();
        }

        public Drink UpdateDrink(Drink b)
        {
            //do some work
            return _repo.Update(b);
        }

        public Drink Create(Drink drink)
        {
            return _repo.Create(drink);
        }
    }
}
