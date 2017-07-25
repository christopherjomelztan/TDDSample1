using NUnit.Framework;
using Moq;

namespace TDDSample.Tests
{
    [TestFixture]
    public class MyServiceTests
    {

        [Test]
        public void Save_SavesItemToDb()
        {
            var item = new Item();
            // assert/verify that item was saved to db (DbManager.SaveToDb(item) called).
            item.Name = "Just a Name";
            item.Description = "Just a Description";
            Mock<IDbManager> mockDbManager = new Mock<IDbManager>();

            var MyService = new MyService(mockDbManager.Object);


            MyService.Save(item);

            mockDbManager.Verify(x => x.SaveToDb(item), Times.Once);
            
        }
    }
}
