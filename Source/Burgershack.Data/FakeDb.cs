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

        public static List<Side> Sides = new List<Side>() {
            new Side(){
                Id = 1,
                Name = "Franch Frys",
                Price =  7.99m,
                Description = "Delicious yet lacking somehow"
            },
            new Side(){
                Id = 2,
                Name = "Halloumi Cheese",
                Price =  8.99m,
                Description = "Delicioso"
            },
            new Side(){
                Id = 3,
                Name = "Sweet Potatoes Fries",
                Price =  12.99m,
                Description = "The most delicious thing you will ever eat"
            },
        };

        public static List<Drink> Drinks = new List<Drink>() {
            new Drink(){
                Id = 1,
                Name = "Banana Milkshake",
                Price =  7.99m,
                Description = "Delicious and not lacking somehow"
            },
            new Drink(){
                Id = 2,
                Name = "Beer",
                Price =  8.99m,
                Description = "Delicioso"
            },
            new Drink(){
                Id = 3,
                Name = "Tequila",
                Price =  12.99m,
                Description = "The most delicious thing you will ever drink"
            },
        };
    }
}
