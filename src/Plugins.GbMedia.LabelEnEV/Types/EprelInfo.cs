using Newtonsoft.Json;

namespace Compori.Shopware.Plugins.GbMedia.LabelEnEV.Types
{
    public class EprelInfo
    {
        [JsonProperty(PropertyName = "class", NullValueHandling = NullValueHandling.Ignore)]
        public string EegClass { get; set; }

        [JsonProperty(PropertyName = "spectrumFrom", NullValueHandling = NullValueHandling.Ignore)]
        public string SpectrumFrom { get; set; }

        [JsonProperty(PropertyName = "spectrumTo", NullValueHandling = NullValueHandling.Ignore)]
        public string SpectrumTo { get; set; }

        [JsonProperty(PropertyName = "color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "eprelMedia", NullValueHandling = NullValueHandling.Ignore)]
        public string EprelMedia { get; set; }

        [JsonProperty(PropertyName = "eprelDatasheed", NullValueHandling = NullValueHandling.Ignore)]
        public string EprelDatasheed { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            var result = base.ToString();
            if (!string.IsNullOrWhiteSpace(this.EegClass))
            {
                result = this.EegClass;
                
            }
            return result;
        }
    }
}
