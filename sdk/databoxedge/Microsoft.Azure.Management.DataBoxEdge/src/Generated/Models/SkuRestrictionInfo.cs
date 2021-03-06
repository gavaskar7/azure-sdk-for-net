// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The restriction info with locations and zones.
    /// </summary>
    public partial class SkuRestrictionInfo
    {
        /// <summary>
        /// Initializes a new instance of the SkuRestrictionInfo class.
        /// </summary>
        public SkuRestrictionInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkuRestrictionInfo class.
        /// </summary>
        /// <param name="locations">The locations.</param>
        /// <param name="zones">The zones.</param>
        public SkuRestrictionInfo(IList<string> locations = default(IList<string>), IList<string> zones = default(IList<string>))
        {
            Locations = locations;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the locations.
        /// </summary>
        [JsonProperty(PropertyName = "locations")]
        public IList<string> Locations { get; private set; }

        /// <summary>
        /// Gets the zones.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; private set; }

    }
}
