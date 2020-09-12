using Vigenere.Library;
using NUnit.Framework;

namespace Test.Library
{
    public class Vigenere_UpperCaseKey
    {

        private VigenereCode vUpperCase;
        private VigenereCode vSingleLetter;


        [SetUp]
        public void Setup()
        {
            vUpperCase = new VigenereCode("UCU", 0);
            vSingleLetter = new VigenereCode("A", 0);
        }

        [Test]
        public void Decrypt_UpperCaseCode() //Si
        {
            string result = vUpperCase.Decrypt("JTIATUGCWCQHCK");
            Assert.AreEqual("PROGRAMACIONII",result);
        }

        [Test]
        public void Decrypt_UpperCaseCode_SingleLetter() //Si
        {
            string result = vSingleLetter.Decrypt("PROGRAMACIONII");
            Assert.AreEqual("PROGRAMACIONII",result);
        }

        [Test]
        public void Encrypt_UpperCaseCode() // Si
        {
            string result = vUpperCase.Encrypt("PROGRAMACIONII");
            Assert.AreEqual("JTIATUGCWCQHCK",result);
        }
        [Test]
        public void Decrypt_LowerCaseCode() //Si
        {
            string result = vUpperCase.Decrypt("jtiatugcwcqhck");
            Assert.AreEqual("PROGRAMACIONII",result);
        }
        [Test]
        public void Encrypt_LowerCaseCode() //Si
        {
            string result = vUpperCase.Encrypt("programacionii");
            Assert.AreEqual("JTIATUGCWCQHCK",result);
        }
    }
}