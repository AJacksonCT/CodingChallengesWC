using WC;

namespace WCTests
{
    public class Tests
    {
        private readonly string _filePath = AppDomain.CurrentDomain.BaseDirectory + "Test.txt";
        private string _stringToTest = "";
        private byte[] _bytesToTest;
        WcImplementation _wcImpl = new WcImplementation();

        [SetUp]
        public void Setup()
        {
            _bytesToTest = File.ReadAllBytes(_filePath);
            _stringToTest = _bytesToTest.ToString()??"";

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
    }
}