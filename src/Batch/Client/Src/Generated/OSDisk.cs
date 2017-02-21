// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A reference to an OS disk image.
    /// </summary>
    public partial class OSDisk : ITransportObjectProvider<Models.OSDisk>, IPropertyMetadata
    {
        private readonly Common.CachingType? caching;
        private readonly IEnumerable<string> imageUris;

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="OSDisk"/> class.
        /// </summary>
        /// <param name='imageUris'>The collection of Virtual Hard Disk (VHD) URIs.</param>
        /// <param name='caching'>The type of caching to enable for the OS disk.</param>
        public OSDisk(
            IEnumerable<string> imageUris,
            Common.CachingType? caching = default(Common.CachingType?))
        {
            this.imageUris = imageUris;
            this.caching = caching;
        }

        internal OSDisk(Models.OSDisk protocolObject)
        {
            this.caching = UtilitiesInternal.MapNullableEnum<Models.CachingType, Common.CachingType>(protocolObject.Caching);
            this.imageUris = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ImageUris, o => o.ToList().AsReadOnly());
        }

        #endregion Constructors

        #region OSDisk

        /// <summary>
        /// Gets the type of caching to enable for the OS disk.
        /// </summary>
        public Common.CachingType? Caching
        {
            get { return this.caching; }
        }

        /// <summary>
        /// Gets the collection of Virtual Hard Disk (VHD) URIs.
        /// </summary>
        /// <remarks>
        /// All the VHDs must be identical and must reside in an Azure Storage account within the same subscription and same 
        /// region as the Batch account. For best performance, it is recommended that each VHD resides in a separate Azure 
        /// Storage account. Each VHD can serve upto 20 Windows compute nodes or 40 Linux compute nodes. You must supply 
        /// enough VHD URIs to satisfy the 'targetDedicated' property of the pool. If you do not supply enough VHD URIs, 
        /// the pool will partially allocate compute nodes, and a resize error will occur.
        /// </remarks>
        public IEnumerable<string> ImageUris
        {
            get { return this.imageUris; }
        }

        #endregion // OSDisk

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods

        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.OSDisk ITransportObjectProvider<Models.OSDisk>.GetTransportObject()
        {
            Models.OSDisk result = new Models.OSDisk()
            {
                Caching = UtilitiesInternal.MapNullableEnum<Common.CachingType, Models.CachingType>(this.Caching),
                ImageUris = UtilitiesInternal.CreateObjectWithNullCheck(this.ImageUris, o => o.ToList()),
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}