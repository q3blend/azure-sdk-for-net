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

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies how the Batch service responds to a particular exit
    /// condition.
    /// </summary>
    public partial class ExitOptions
    {
        /// <summary>
        /// Initializes a new instance of the ExitOptions class.
        /// </summary>
        public ExitOptions() { }

        /// <summary>
        /// Initializes a new instance of the ExitOptions class.
        /// </summary>
        /// <param name="jobAction">An action to take on the job containing the
        /// task, if the task completes with the given exit condition and the
        /// job's onTaskFailed property is
        /// 'performExitOptionsJobAction'.</param>
        /// <param name="dependencyAction">An action that the Batch service
        /// performs on tasks that depend on this task.</param>
        public ExitOptions(JobAction? jobAction = default(JobAction?), DependencyAction? dependencyAction = default(DependencyAction?))
        {
            JobAction = jobAction;
            DependencyAction = dependencyAction;
        }

        /// <summary>
        /// Gets or sets an action to take on the job containing the task, if
        /// the task completes with the given exit condition and the job's
        /// onTaskFailed property is 'performExitOptionsJobAction'.
        /// </summary>
        /// <remarks>
        /// The default is none for exit code 0 and terminate for all other
        /// exit conditions. If the job's onTaskFailed property is noAction,
        /// then specify this property returns an error. The add task request
        /// fails with an invalid property value error;; if you are calling the
        /// REST API directly, the HTTP status code is 400 (Bad Request).
        /// Possible values include: 'none', 'disable', 'terminate'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobAction")]
        public JobAction? JobAction { get; set; }

        /// <summary>
        /// Gets or sets an action that the Batch service performs on tasks
        /// that depend on this task.
        /// </summary>
        /// <remarks>
        /// The default is 'satisfy' for exit code 0, and 'block' for all other
        /// exit conditions. If the job's usesTaskDependencies property is set
        /// to false, then specifying the dependencyAction property returns an
        /// error. The add task request fails with an invalid property value
        /// error; if you are calling the REST API directly, the HTTP status
        /// code is 400  (Bad Request). Possible values include: 'satisfy',
        /// 'block'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dependencyAction")]
        public DependencyAction? DependencyAction { get; set; }

    }
}
