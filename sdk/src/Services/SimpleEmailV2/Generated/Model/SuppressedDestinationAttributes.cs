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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object containing additional attributes related to a suppressed destination.
    /// </summary>
    public partial class SuppressedDestinationAttributes
    {
        private string _feedbackId;
        private string _messageId;

        /// <summary>
        /// Gets and sets the property FeedbackId. 
        /// <para>
        /// A unique identifier of the suppression cause.
        /// </para>
        /// </summary>
        public string FeedbackId
        {
            get { return this._feedbackId; }
            set { this._feedbackId = value; }
        }

        // Check to see if FeedbackId property is set
        internal bool IsSetFeedbackId()
        {
            return this._feedbackId != null;
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// A unique identifier of the message that caused the suppression of the email destination.
        /// </para>
        /// </summary>
        public string MessageId
        {
            get { return this._messageId; }
            set { this._messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this._messageId != null;
        }

    }
}