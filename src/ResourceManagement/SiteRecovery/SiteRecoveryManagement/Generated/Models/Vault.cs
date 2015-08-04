// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.RecoveryServices.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    /// <summary>
    /// The response model for the Vm group object.
    /// </summary>
    public partial class Vault
    {
        private string _eTag;
        
        /// <summary>
        /// Optional. ETag of the Vault.
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. Gets or sets the ID of the resource.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Optional. Gets or sets the location of the resource.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Gets or sets the name of the resource.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private VaultProperties _properties;
        
        /// <summary>
        /// Optional. Properties of the vault.
        /// </summary>
        public VaultProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private IDictionary<string, string> _tags;
        
        /// <summary>
        /// Optional. Gets or sets the tags attached to the resource.
        /// </summary>
        public IDictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Optional. Gets or sets the type of the resource.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Vault class.
        /// </summary>
        public Vault()
        {
            this.Tags = new LazyDictionary<string, string>();
        }
    }
}
