using System.Threading.Tasks;
using Xunit;

namespace Compori.Shopware.Plugins.GbMedia.LabelEnEV.Repositories
{
    public class LabelRepositoryTests : BaseTest
    {
        protected LabelRepository Repository { get; set; }

        protected override void Setup()
        {
            base.Setup();
            this.Repository = new LabelRepository(this.TestContext.CreateClient());
        }

        [Fact()]
        public async Task TestReadAsync()
        {
            this.Setup();
            try
            {
                var items = await this.Repository.Read(new Shopware.Types.Search { Limit = 25 }).ConfigureAwait(false);
                Assert.NotNull(items);
            }
            finally
            {
                this.Cleanup();
            }
        }
    }
}
