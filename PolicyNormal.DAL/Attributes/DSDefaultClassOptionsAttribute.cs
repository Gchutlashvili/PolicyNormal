using System;
// ReSharper disable InconsistentNaming

namespace DAL.BusinessObjects
{
    public class DSAttribute : Attribute { }

    //Created Attributes => DSActionAttribute, DSXafDisplayName;
    public class DSDefaultClassOptionsAttribute : DSAttribute { }
    public class DSტრუხა : DSAttribute { }

    public class DSImmediatePostDataAttribute : DSAttribute { }

    public class DSDataSourcePropertyAttribute : DSAttribute
    {
        public string PropertyName { get; set; }

        public DSDataSourcePropertyAttribute(string propertyName)
        {
            PropertyName = propertyName;
        }
    }

    public class DSXafDisplayNameAttribute : DSAttribute
    {
        public string DisplayName { get; set; }

        public DSXafDisplayNameAttribute(string displayName)
        {
            DisplayName = displayName;
        }
    }

    public class DSActionAttribute : DSAttribute { }
}