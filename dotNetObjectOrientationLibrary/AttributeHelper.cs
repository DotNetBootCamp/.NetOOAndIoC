using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace dotNetObjectOrientationLibrary
{
    public static class AttributeHelper
    {
        public static bool CheckForAttribute<TAttribute>(MemberInfo member, bool includeMetadataTypeCheck)
            where TAttribute: Attribute
        {
            return GetAttribute<TAttribute>(member, includeMetadataTypeCheck) != null;
        }

        public static TAttribute GetAttribute<TAttribute>(MemberInfo member, bool includeMetadataTypeCheck)
            where TAttribute: Attribute
        {
            var attribute = Attribute.GetCustomAttribute(member, typeof(TAttribute), true);

            if (attribute == null && includeMetadataTypeCheck)
            {
                var modelType = member.DeclaringType;
                MetadataTypeAttribute metaDataAttribute = null;
                if ((metaDataAttribute = Attribute.GetCustomAttribute(modelType, typeof(MetadataTypeAttribute), true) as MetadataTypeAttribute) != null)
                {
                    var metadataType = metaDataAttribute.MetadataClassType;
                    var metadataPropertyInfo = metadataType.GetProperty(member.Name);
                    if (metadataPropertyInfo != null)
                    {
                        attribute = Attribute.GetCustomAttribute(metadataPropertyInfo, typeof(TAttribute), true);
                    }
                }
            }

            return attribute as TAttribute;
        }
    }
}
