using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniQueCharsTest;
using UniqueChars;


namespace UniQueCharsTest
{
    [TestFixture]
    class UniQUeCharsTestClass
    {
        public UniqueCharsClass myOriginal = new UniqueCharsClass();

        static void Main(string[] args)
        {
        }

        [Test]
        public void EmptyString()
        {
            string input = "";
            bool result = false;
            Assert.AreEqual(result, myOriginal.UniqueCharacters(input));
        }

        [Test]
        public void NotEmptyString()
        {
            string input = "cactus";
            bool result = true;
            Assert.AreEqual(result, myOriginal.UniqueCharacters(input));
        }
        
        [Test]
        public void UpperOrSmaller()
        {
            string input = "SuccuLents";
            bool result = true;
            Assert.AreEqual(result, myOriginal.UniqueCharacters(input));
        }

        [Test]
        public void StringWithSpaces()
        {
            string input = "su ccu le nts";
            bool result = true;
            Assert.AreEqual(result, myOriginal.UniqueCharacters(input));
        }
    }
}
