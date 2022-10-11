// <copyright file="Default.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace YouTubeSearch.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using YouTubeSearch.Standard;
    using YouTubeSearch.Standard.Utilities;

    /// <summary>
    /// Default.
    /// </summary>
    public class Default
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Default"/> class.
        /// </summary>
        public Default()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Default"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="width">width.</param>
        /// <param name="height">height.</param>
        public Default(
            string url,
            int width,
            int height)
        {
            this.Url = url;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets Width.
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets Height.
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Default : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is Default other &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                this.Width.Equals(other.Width) &&
                this.Height.Equals(other.Height);
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url == string.Empty ? "" : this.Url)}");
            toStringOutput.Add($"this.Width = {this.Width}");
            toStringOutput.Add($"this.Height = {this.Height}");
        }
    }
}