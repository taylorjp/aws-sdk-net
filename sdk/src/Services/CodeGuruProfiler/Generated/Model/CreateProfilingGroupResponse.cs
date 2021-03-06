/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Response for CreateProfilingGroup operation.
    /// </summary>
    public partial class CreateProfilingGroupResponse : AmazonWebServiceResponse
    {
        private ProfilingGroupDescription _profilingGroup;

        /// <summary>
        /// Gets and sets the property ProfilingGroup.
        /// </summary>
        [AWSProperty(Required=true)]
        public ProfilingGroupDescription ProfilingGroup
        {
            get { return this._profilingGroup; }
            set { this._profilingGroup = value; }
        }

        // Check to see if ProfilingGroup property is set
        internal bool IsSetProfilingGroup()
        {
            return this._profilingGroup != null;
        }

    }
}