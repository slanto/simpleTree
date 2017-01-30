namespace SimpleTree.Tests
{
    using Core;

    using Xunit;

    public class TreeTests
    {
        [Fact]
        public void CreateNotNullTree()
        {
            Node<string> root = new Node<string>("Root node");
            var sut = new Tree<string>(root);
            Assert.NotNull(sut);
        }

        
    }
}
