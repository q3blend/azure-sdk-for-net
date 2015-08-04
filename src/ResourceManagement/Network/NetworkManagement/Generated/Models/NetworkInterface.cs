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
using Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Management.Network.Models
{
    /// <summary>
    /// A NetworkInterface in a resource group
    /// </summary>
    public partial class NetworkInterface : TopLevelResource
    {
        private NetworkInterfaceDnsSettings _dnsSettings;
        
        /// <summary>
        /// Optional. Gets or sets DNS Settings in  NetworkInterface
        /// </summary>
        public NetworkInterfaceDnsSettings DnsSettings
        {
            get { return this._dnsSettings; }
            set { this._dnsSettings = value; }
        }
        
        private bool _enableIPForwarding;
        
        /// <summary>
        /// Optional. Gets or sets whether IPForwarding is enabled on the NIC
        /// </summary>
        public bool EnableIPForwarding
        {
            get { return this._enableIPForwarding; }
            set { this._enableIPForwarding = value; }
        }
        
        private IList<NetworkInterfaceIpConfiguration> _ipConfigurations;
        
        /// <summary>
        /// Optional. Gets or sets list of IPConfigurations of the
        /// NetworkInterface
        /// </summary>
        public IList<NetworkInterfaceIpConfiguration> IpConfigurations
        {
            get { return this._ipConfigurations; }
            set { this._ipConfigurations = value; }
        }
        
        private string _macAddress;
        
        /// <summary>
        /// Optional. Gets the MAC Address of the network interface
        /// </summary>
        public string MacAddress
        {
            get { return this._macAddress; }
            set { this._macAddress = value; }
        }
        
        private ResourceId _networkSecurityGroup;
        
        /// <summary>
        /// Optional. Gets or sets the reference of the NetworkSecurityGroup
        /// resource
        /// </summary>
        public ResourceId NetworkSecurityGroup
        {
            get { return this._networkSecurityGroup; }
            set { this._networkSecurityGroup = value; }
        }
        
        private bool? _primary;
        
        /// <summary>
        /// Optional. Gets whether this is a primary NIC on a virtual machine
        /// </summary>
        public bool? Primary
        {
            get { return this._primary; }
            set { this._primary = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets Provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private ResourceId _virtualMachine;
        
        /// <summary>
        /// Optional. Gets or sets the reference of a VirtualMachine
        /// </summary>
        public ResourceId VirtualMachine
        {
            get { return this._virtualMachine; }
            set { this._virtualMachine = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the NetworkInterface class.
        /// </summary>
        public NetworkInterface()
        {
            this.IpConfigurations = new LazyList<NetworkInterfaceIpConfiguration>();
        }
        
        /// <summary>
        /// Initializes a new instance of the NetworkInterface class with
        /// required arguments.
        /// </summary>
        public NetworkInterface(string location)
            : this()
        {
            if (location == null)
            {
                throw new ArgumentNullException("location");
            }
            this.Location = location;
        }
    }
}
