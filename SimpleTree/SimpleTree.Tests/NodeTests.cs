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
            var sut = new Node<string>(Data);
            Assert.NotNull(sut);
        }

        [Fact]
        public void CreatedNodeHasAGivenPropertyData()
        {
            var sut = new Node<string>("New node");
            Assert.NotNull(sut);
            Assert.Equal("New node", sut.GetData());
        }

        [Fact]
        public void NodeHasChildren()
        {
            var sut = new Node<string>(Data);
            Assert.NotNull(sut);
            Assert.NotNull(sut.Children);
        }

        [Fact]
        public void RootNodeDoesNotHaveAParent()
        {
            var sut = new Node<string>(Data);
            Assert.NotNull(sut);
            Assert.Null(sut.GetParent());
        }

        [Fact]
        public void ChildNodeHasAParent()
        {
            var root = new Node<string>("root");
            Node<string> sut = new Node<string>("data", root);
            Assert.NotNull(sut);
            Assert.NotNull(sut.GetParent());
        }

        [Fact]
        public void GetParent_ReturnsParentForGivenChildNode()
        {
            var parent = new Node<string>("parent");
            Node<string> sut = new Node<string>("data", parent);
            var actual = sut.GetParent();
            Assert.Equal(parent, actual);
        }

        [Fact]
        public void SetParent_SetsParentForGivenChildNode()
        {            
            var sut = new Node<string>("data");
            var parent = new Node<string>("parent");
            sut.SetParent(parent);

            var actual = sut.GetParent();
            Assert.Equal(parent, actual);
        }

        [Fact]
        public void GetData_ReturnsDataForGivenChildNode()
        {            
            var sut = new Node<string>("data");
            var actual = sut.GetData();
            Assert.Equal("data", actual);
        }

        [Fact]
        public void SetData_SetsDataForGivenChildNode()
        {
            var sut = new Node<string>();
            var data = "New data";
            sut.SetData(data);

            var actual = sut.GetData();
            Assert.Equal(data, actual);
        }

        [Fact]
        public void AddChild_AddsNodeForGivenNode()
        {            
            var sut = new Node<string>("root");

            var child = new Node<string>("child");
            var actual = sut.AddChild(child);

            Assert.Equal(child, actual);
            Assert.Equal(child.GetData(), actual.GetData());
            Assert.Equal(child.GetParent(), sut);
        }

        [Fact]
        public void AddChild_AddsChildForGivenNode()
        {
            var sut = new Node<string>("root");
            
            var actual = sut.AddChild("child");
                        
            Assert.Equal("child", actual.GetData());
            Assert.Equal("root", actual.GetParent().GetData());
        }           
    }
}
