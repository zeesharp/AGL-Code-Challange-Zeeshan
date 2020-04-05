using AGL_Code_Challenge.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AGL_Code_Challenge.BusinessModels.Enum;

namespace AGL_Code_Challenge_UnitTests
{
    public static class MockData
    {
        public static List<People> GetValidPeopleListWithPets()
        {
            var list = new List<People>();
            //  list.Add(new People { Name = "James", Gender = "Male", Age = 30, new List<Pet>().Add(new Pet { Type = "Cat", Name = "Garfield" }) });
            var petList1 = new List<Pet>();
            petList1.Add(new Pet {Name="Garfield",Type="Cat" });
            petList1.Add(new Pet { Name = "Tom", Type = "Cat" });
            petList1.Add(new Pet { Name = "Fido", Type = "Dog" });
            petList1.Add(new Pet { Name = "Tabbo", Type = "Fish" });

            var petList2 = new List<Pet>();
            petList1.Add(new Pet { Name = "Garfield", Type = "Cat" });
            petList1.Add(new Pet { Name = "Tom", Type = "Cat" });
            petList1.Add(new Pet { Name = "Shark", Type = "Fish" });

            var petList3 = new List<Pet>();
            petList3.Add(new Pet { Name = "Garfield", Type = "Cat" });
            petList3.Add(new Pet { Name = "Tabby", Type = "Cat" });
            petList3.Add(new Pet { Name = "Sam", Type = "Dog" });


            list.Add(new People { Name = "James", Gender = "Male",Age=30, Pets = petList1 });

            list.Add(new People { Name = "Steve", Gender = "Male", Age = 30, Pets = petList2 });

            list.Add(new People { Name = "Ria", Gender = "Femalle", Age = 30, Pets = null });

            list.Add(new People { Name = "Samantha", Gender = "Female", Age = 28, Pets = petList3 });


            return list;
        }

        public static List<People> GetInValidPeopleListWithPets()
        {
            var list = new List<People>();
            //  list.Add(new People { Name = "James", Gender = "Male", Age = 30, new List<Pet>().Add(new Pet { Type = "Cat", Name = "Garfield" }) });
            var petList1 = new List<Pet>();
            petList1.Add(new Pet { Name = "Garfield", Type = AnimalEnum.Cat.ToString() });
            petList1.Add(new Pet { Name = "Tom", Type = AnimalEnum.Cat.ToString() });
            petList1.Add(new Pet { Name = "Fido", Type = AnimalEnum.Dog.ToString() });
            petList1.Add(new Pet { Name = "Tabbo", Type = AnimalEnum.Fish.ToString() });

            var petList2 = new List<Pet>();
            petList1.Add(new Pet { Name = "Garfield", Type = AnimalEnum.Cat.ToString() });
            petList1.Add(new Pet { Name = "Tom", Type = AnimalEnum.Cat.ToString() });
            petList1.Add(new Pet { Name = "Shark", Type = AnimalEnum.Fish.ToString() });

            var petList3 = new List<Pet>();
            petList3.Add(new Pet { Name = "Garfield", Type = AnimalEnum.Cat.ToString() });
            petList3.Add(new Pet { Name = "Tabby", Type = AnimalEnum.Cat.ToString() });
            petList3.Add(new Pet { Name = "Sam", Type = AnimalEnum.Dog.ToString() });


            list.Add(new People { Name = "James", Gender = GenderEnum.Male.ToString(), Age = 30, Pets = petList1 });

            list.Add(new People { Name = "Steve", Gender = GenderEnum.Male.ToString(), Age = 30, Pets = petList2 });

            list.Add(new People { Name = "Ria", Gender = GenderEnum.Female.ToString(), Age = 30, Pets = null });

            list.Add(new People { Name = "Samantha", Gender = GenderEnum.Female.ToString(), Age = 28, Pets = petList3 });


            return list;
        }

    }
}
