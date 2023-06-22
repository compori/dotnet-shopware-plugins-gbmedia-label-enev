using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Compori.Shopware.Plugins.GbMedia.LabelEnEV.Services
{
    public class EprelInfoServiceTests : BaseTest
    {
        protected EprelInfoService Service { get; set; }

        protected override void Setup()
        {
            base.Setup();
            this.Service = new EprelInfoService(this.TestContext.CreateClient());
        }

        [Fact()]
        public async Task TestGetEprelInfo()
        {
            this.Setup();
            try
            {
                var info = await this.Service.GetEprelInfo("lightsources", 766858).ConfigureAwait(false);
                Assert.NotNull(info);
            }
            finally
            {
                this.Cleanup();
            }
        }
    }
}
