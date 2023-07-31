using WC;

namespace WCTests
{
    public class Tests
    {
        private readonly string _filePath = AppDomain.CurrentDomain.BaseDirectory + "Test.txt";
        private string _stringToTest = "";
        WcImplementation _wcImpl = new WcImplementation();

        [SetUp]
        public void Setup()
        {
            _stringToTest = File.ReadAllText(_filePath);
            
        }

        [Test]
        public void TestStep1_CharacterCount()
        {
            var characterCount = _wcImpl.GetCharacterCount(_stringToTest);
            Assert.That(characterCount, Is.EqualTo(341836));
        }
    }
}