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
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Parameters for a CloudJobOperations.Update request.
    /// </summary>
    public partial class JobUpdateParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobUpdateParameter class.
        /// </summary>
        public JobUpdateParameter() { }

        /// <summary>
        /// Initializes a new instance of the JobUpdateParameter class.
        /// </summary>
        /// <param name="poolInfo">The pool on which the Batch service runs the job's tasks.</param>
        /// <param name="priority">The priority of the job.</param>
        /// <param name="constraints">The execution constraints for the job.</param>
        /// <param name="metadata">A list of name-value pairs associated with the job as metadata.</param>
        /// <param name="onAllTasksComplete">Specifies an action the Batch service should take when all tasks in the job are in the completed state. Possible values include: 'noAction', 'terminateJob'</param>
        public JobUpdateParameter(PoolInformation poolInfo, int? priority = default(int?), JobConstraints constraints = default(JobConstraints), IList<MetadataItem> metadata = default(IList<MetadataItem>), OnAllTasksComplete? onAllTasksComplete = default(OnAllTasksComplete?))
        {
            Priority = priority;
            Constraints = constraints;
            PoolInfo = poolInfo;
            Metadata = metadata;
            OnAllTasksComplete = onAllTasksComplete;
        }

        /// <summary>
        /// Gets or sets the priority of the job.
        /// </summary>
        /// <remarks>
        /// Priority values can range from -1000 to 1000, with -1000 being the
        /// lowest priority and 1000 being the highest priority. If omitted,
        /// it is set to the default value 0.
        /// </remarks>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints for the job.
        /// </summary>
        /// <remarks>
        /// If omitted, the constraints are cleared.
        /// </remarks>
        [JsonProperty(PropertyName = "constraints")]
        public JobConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets the pool on which the Batch service runs the job's
        /// tasks.
        /// </summary>
        /// <remarks>
        /// You may change the pool for a job only when the job is disabled.
        /// The Update Job call will fail if you include the poolInfo element
        /// and the job is not disabled. If you specify an
        /// autoPoolSpecification specification in the poolInfo, only the
        /// keepAlive property can be updated, and then only if the auto pool
        /// has a poolLifetimeOption of job.
        /// </remarks>
        [JsonProperty(PropertyName = "poolInfo")]
        public PoolInformation PoolInfo { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the job as
        /// metadata.
        /// </summary>
        /// <remarks>
        /// If omitted, it takes the default value of an empty list; in
        /// effect, any existing metadata is deleted.
        /// </remarks>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Gets or sets specifies an action the Batch service should take
        /// when all tasks in the job are in the completed state. Possible
        /// values include: 'noAction', 'terminateJob'
        /// </summary>
        [JsonProperty(PropertyName = "onAllTasksComplete")]
        public OnAllTasksComplete? OnAllTasksComplete { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PoolInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PoolInfo");
            }
            if (this.PoolInfo != null)
            {
                this.PoolInfo.Validate();
            }
            if (this.Metadata != null)
            {
                foreach (var element in this.Metadata)
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
