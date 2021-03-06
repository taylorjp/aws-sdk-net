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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
    /// 2019. For information, including how to migrate your AWS WAF resources from the prior
    /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// In a <a>GetSampledRequests</a> request, the <code>StartTime</code> and <code>EndTime</code>
    /// objects specify the time range for which you want AWS WAF to return a sample of web
    /// requests.
    /// </para>
    ///  
    /// <para>
    /// In a <a>GetSampledRequests</a> response, the <code>StartTime</code> and <code>EndTime</code>
    /// objects specify the time range for which AWS WAF actually returned a sample of web
    /// requests. AWS WAF gets the specified number of requests from among the first 5,000
    /// requests that your AWS resource receives during the specified time period. If your
    /// resource receives more than 5,000 requests during that period, AWS WAF stops sampling
    /// after the 5,000th request. In that case, <code>EndTime</code> is the time that AWS
    /// WAF received the 5,000th request. 
    /// </para>
    /// </summary>
    public partial class TimeWindow
    {
        private DateTime? _endTime;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time range from which you want <code>GetSampledRequests</code> to return
        /// a sample of the requests that your AWS resource received. Specify the date and time
        /// in the following format: <code>"2016-09-27T14:50Z"</code>. You can specify any time
        /// range in the previous three hours.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The beginning of the time range from which you want <code>GetSampledRequests</code>
        /// to return a sample of the requests that your AWS resource received. Specify the date
        /// and time in the following format: <code>"2016-09-27T14:50Z"</code>. You can specify
        /// any time range in the previous three hours.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}