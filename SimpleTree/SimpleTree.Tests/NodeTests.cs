namespace SimpleTree.Tests
{
    using Core;

    using Xunit;

    public class NodeTests
    {
        private const string Data = "Node data";
        [Fact]
        public void CreateNotNullNode()
        {
            Node sut = new Node(Data);
            Assert.NotNull(sut);
        }

        [Fact]
        public void CreatedNodeHasAGivenPropertyData()
        {
            Node sut = new Node("New node");
            Assert.NotNull(sut);
            Assert.Equal("New node", sut.GetData());
        }

        [Fact]
        public void NodeHasChildren()
        {
            Node sut = new Node(Data);
            Assert.NotNull(sut);
            Assert.NotNull(sut.Children);
        }

        [Fact]
        public void RootNodeDoesNotHaveAParent()
        {
            Node sut = new Node(Data);
            Assert.NotNull(sut);
            Assert.Null(sut.GetParent());
        }

        [Fact]
        public void ChildNodeHasAParent()
        {
            var root = new Node("root");
            Node sut = new Node("data", root);
            Assert.NotNull(sut);
            Assert.NotNull(sut.GetParent());
        }

        [Fact]
        public void GetParent_ReturnsParentForGivenChildNode()
        {
            var parent = new Node("parent");
            Node sut = new Node("data", parent);
            var actual = sut.GetParent();
            Assert.Equal(parent, actual);
        }

        [Fact]
        public void SetParent_SetsParentForGivenChildNode()
        {            
            Node sut = new Node("data");
            var parent = new Node("parent");
            sut.SetParent(parent);

            var actual = sut.GetParent();
            Assert.Equal(parent, actual);
        }

        [Fact]
        public void GetData_ReturnsDataForGivenChildNode()
        {            
            Node sut = new Node("data");
            var actual = sut.GetData();
            Assert.Equal("data", actual);
        }

        [Fact]
        public void SetData_SetsDataForGivenChildNode()
        {
            Node sut = new Node();
            var data = "New data";
            sut.SetData(data);

            var actual = sut.GetData();
            Assert.Equal(data, actual);
        }
    }
}
