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
    /// Specifies any dependencies of a task. Any task that is explicitly specified or within a dependency range must complete 
    /// before the dependant task will be scheduled.
    /// </summary>
    public partial class TaskDependencies : ITransportObjectProvider<Models.TaskDependencies>, IPropertyMetadata
    {
        private readonly IReadOnlyList<TaskIdRange> taskIdRanges;
        private readonly IReadOnlyList<string> taskIds;

        #region Constructors

        internal TaskDependencies(Models.TaskDependencies protocolObject)
        {
            this.taskIdRanges = TaskIdRange.ConvertFromProtocolCollectionReadOnly(protocolObject.TaskIdRanges);
            this.taskIds = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.TaskIds, o => o.ToList().AsReadOnly());
        }

        #endregion Constructors

        #region TaskDependencies

        /// <summary>
        /// Gets the list of task IDs that this task depends on. All tasks in this list must complete successfully before 
        /// the dependent task can be scheduled.
        /// </summary>
        public IReadOnlyList<TaskIdRange> TaskIdRanges
        {
            get { return this.taskIdRanges; }
        }

        /// <summary>
        /// Gets the list of task ID ranges that this task depends on. All tasks in all ranges must complete successfully 
        /// before the dependent task can be scheduled.
        /// </summary>
        public IReadOnlyList<string> TaskIds
        {
            get { return this.taskIds; }
        }

        #endregion // TaskDependencies

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
        Models.TaskDependencies ITransportObjectProvider<Models.TaskDependencies>.GetTransportObject()
        {
            Models.TaskDependencies result = new Models.TaskDependencies()
            {
                TaskIdRanges = UtilitiesInternal.ConvertToProtocolCollection(this.TaskIdRanges),
                TaskIds = UtilitiesInternal.CreateObjectWithNullCheck(this.TaskIds, o => o.ToList()),
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}