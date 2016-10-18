// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.ServiceModel
{
    [AttributeUsage(ServiceModelAttributeTargets.MessageMember, Inherited = false)]
    public sealed class MessagePropertyAttribute : Attribute
    {
        private string _name;
        private bool _isNameSetExplicit;

        public MessagePropertyAttribute()
        {
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _isNameSetExplicit = true;
                _name = value;
            }
        }
        internal bool IsNameSetExplicit
        {
            get
            {
                return _isNameSetExplicit;
            }
        }
    }
}


