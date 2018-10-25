using Burgershack.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Burgershack.Data
{
    public static class FakeDb
    {
        public static int NextId = 4;
        public static List<Burger> Burgers = new List<Burger>() {
            new Burger(){
                Id = 1,
                Name = "Plain Jane",
                Price =  7.99m,
                Description = "Delicious yet lacking somehow"
            },
            new Burger(){
                Id = 2,
                Name = "Plain Jane con Queso",
                Price =  8.99m,
                Description = "Delicioso"
            },
            new Burger(){
                Id = 3,
                Name = "Hawaiian",
                Price =  12.99m,
                Description = "Pineapple YUM!!!"
            },
        };
    }
}
