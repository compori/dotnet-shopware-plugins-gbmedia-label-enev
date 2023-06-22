using Compori.Shopware.Factories;
using Compori.Shopware.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Compori.Shopware.Plugins.GbMedia.LabelEnEV
{
    public class TestContext
    {
        private Client client = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestContext"/> class.
        /// </summary>
        public TestContext()
        {
        }

        /// <summary>
        /// Creates the settings factory.
        /// </summary>
        /// <returns>ISettingsFactory.</returns>
        public ISettingsFactory CreateSettingsFactory()
        {
            var factory = new SettingsFactory();
            factory.ReadFromJsonFile("testing-shop.ignore.json");
            return factory;
        }

        /// <summary>
        /// Liefert die Testeinstellungen zurück.
        /// </summary>
        /// <returns>Settings.</returns>
        public Settings GetSettings()
        {
            var factory = this.CreateSettingsFactory();
            return factory.Create();
        }

        /// <summary>
        /// Creates the client.
        /// </summary>
        /// <returns>Client.</returns>
        public Client CreateClient()
        {
            if (this.client == null)
            {
                var settingsFactory = this.CreateSettingsFactory();
                var restClientFactory = new RestClientFactory();
                this.client = new Client(settingsFactory, restClientFactory);
            }
            return this.client;
        }
    }
}
