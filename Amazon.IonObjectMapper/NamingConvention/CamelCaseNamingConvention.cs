﻿/*
 * Copyright (c) Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use this file except in compliance with
 * the License. A copy of the License is located at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions
 * and limitations under the License.
 */

namespace Amazon.IonObjectMapper
{
    /// <summary>
    /// Camel case naming convention for property names.
    /// </summary>
    public class CamelCaseNamingConvention : IIonPropertyNamingConvention
    {
        /// <summary>
        /// Convert camel case name back to original .NET property name.
        /// </summary>
        ///
        /// <param name="s">Camel case version of the .NET property name.</param>
        ///
        /// <returns>The original .NET property name.</returns>
        public string ToProperty(string s)
        {
            return s.Substring(0, 1).ToUpperInvariant() + s[1..];
        }

        /// <summary>
        /// Convert .NET property name to camel case.
        /// </summary>
        ///
        /// <param name="s">The original .NET property name.</param>
        ///
        /// <returns>Camel case version of the .NET property name.</returns>
        public string FromProperty(string s)
        {
            return s.Substring(0, 1).ToLowerInvariant() + s[1..];
        }
    }
}
