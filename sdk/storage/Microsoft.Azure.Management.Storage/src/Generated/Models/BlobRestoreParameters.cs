// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Blob restore parameters
    /// </summary>
    public partial class BlobRestoreParameters
    {
        /// <summary>
        /// Initializes a new instance of the BlobRestoreParameters class.
        /// </summary>
        public BlobRestoreParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobRestoreParameters class.
        /// </summary>
        /// <param name="timeToRestore">Restore blob to the specified
        /// time.</param>
        /// <param name="blobRanges">Blob ranges to restore.</param>
        public BlobRestoreParameters(System.DateTime timeToRestore, IList<BlobRestoreRange> blobRanges)
        {
            TimeToRestore = timeToRestore;
            BlobRanges = blobRanges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets restore blob to the specified time.
        /// </summary>
        [JsonProperty(PropertyName = "timeToRestore")]
        public System.DateTime TimeToRestore { get; set; }

        /// <summary>
        /// Gets or sets blob ranges to restore.
        /// </summary>
        [JsonProperty(PropertyName = "blobRanges")]
        public IList<BlobRestoreRange> BlobRanges { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BlobRanges == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BlobRanges");
            }
            if (BlobRanges != null)
            {
                foreach (var element in BlobRanges)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
