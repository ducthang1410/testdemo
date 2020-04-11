using System.Collections.Generic;
using Animal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InvokingMethodWithoutKnowingAboutObject()
        {
            IAnimal Tiger = new Tiger();
            IAnimal Lion = new Lion();

            List<IAnimal> animalList = new List<IAnimal>();
            animalList.Add(Tiger);
            animalList.Add(Lion);


            foreach (var animal in animalList) 
            {
                animal.Breathe();
            }

        }
    }
}
