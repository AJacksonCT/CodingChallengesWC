using WC;

namespace WCTests
{
    public class Tests
    {
        private readonly string _filePath = AppDomain.CurrentDomain.BaseDirectory + "Test.txt";
        private string _stringToTest = "";
        private string[] _linesToTest;
        private byte[] _bytesToTest;
        WcImplementation _wcImpl = new WcImplementation();

        [SetUp]
        public void Setup()
        {
            _bytesToTest = File.ReadAllBytes(_filePath);
            _stringToTest = File.ReadAllText(_filePath);
            _linesToTest = File.ReadAllLines(_filePath);

        }

        [Test]
        public void TestStep1_ByteCountFromArray()
        {
            var byteCount = _wcImpl.GetByteCount(_bytesToTest);
            Assert.That(byteCount, Is.EqualTo(341836));
        }
        [Test]
        public void TestStep1_ByteCountFromFile()
        {
            var byteCount = _wcImpl.GetByteCount(_filePath);
            Assert.That(byteCount, Is.EqualTo(341836));
        }

        [Test]
        public void TestStep2_LinesCountFromArray()
        {
            var lineCount = _wcImpl.GetLineCount(_linesToTest);
            Assert.That(lineCount, Is.EqualTo(7137));
        }
        [Test]
        public void TestStep2_LinesCountFromFile()
        {
            var lineCount = _wcImpl.GetLineCount(_filePath);
            Assert.That(lineCount,Is.EqualTo(7137));
        }
        [Test]
        public void TestStep2_WordCountFromArray()
        {
            var wordCount = _wcImpl.GetWordCount(_stringToTest);
            Assert.That(wordCount, Is.EqualTo(58143));
        }
        [Test]
        public void TestStep2_WordCountFromFile()
        {
            var wordCount = _wcImpl.GetWordCountFromFile(_filePath);
            Assert.That(wordCount, Is.EqualTo(58143));
        }
        [Test]
        public void TestStep2_CharacterCountFromArray()
        {
            var characterCount = _wcImpl.GetCharacterCount(_stringToTest);
            Assert.That(characterCount, Is.EqualTo(339120));
        }
        [Test]
        public void TestStep2_CharacterCountFromFile()
        {
            var characterCount = _wcImpl.GetCharacterCountFromFile(_filePath);
            Assert.That(characterCount, Is.EqualTo(339120));
        }
    }
}
