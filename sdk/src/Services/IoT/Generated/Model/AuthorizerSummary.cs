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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The authorizer summary.
    /// </summary>
    public partial class AuthorizerSummary
    {
        private string _authorizerArn;
        private string _authorizerName;

        /// <summary>
        /// Gets and sets the property AuthorizerArn. 
        /// <para>
        /// The authorizer ARN.
        /// </para>
        /// </summary>
        public string AuthorizerArn
        {
            get { return this._authorizerArn; }
            set { this._authorizerArn = value; }
        }

        // Check to see if AuthorizerArn property is set
        internal bool IsSetAuthorizerArn()
        {
            return this._authorizerArn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerName. 
        /// <para>
        /// The authorizer name.
        /// </para>
        /// </summary>
        public string AuthorizerName
        {
            get { return this._authorizerName; }
            set { this._authorizerName = value; }
        }

        // Check to see if AuthorizerName property is set
        internal bool IsSetAuthorizerName()
        {
            return this._authorizerName != null;
        }

    }
}