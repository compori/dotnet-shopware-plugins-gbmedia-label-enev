using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Compori.Shopware.Plugins.GbMedia.LabelEnEV.Services
{
    public class EprelInfoService
    {
        /// <summary>
        /// Liefert den Shopware Client.
        /// </summary>
        /// <value>The client.</value>
        protected Client Client { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EprelInfoService"/> class.
        /// </summary>
        /// <param name="client">The client.</param>
        public EprelInfoService(Client client)
        {
            this.Client = client;
        }

        /// <summary>
        /// Get version as an asynchronous operation.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>A Task&lt;Version&gt; representing the asynchronous operation.</returns>
        public async Task<Types.EprelInfo> GetEprelInfo(string group, long productId, CancellationToken cancellationToken = default)
        {
            return await this.Client.Post<Types.EprelInfo>("/_action/gbmed-enev/eprel/" + group + "/" + productId, cancellationToken).ConfigureAwait(false);
        }
    }
}
