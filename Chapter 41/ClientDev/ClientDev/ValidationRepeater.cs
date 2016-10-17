using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientDev {

    public class ValidationRepeater : DataBoundControl, INamingContainer {

        [TemplateContainer(typeof(ValidationRepeaterTemplateItem))]
        public ITemplate PropertyTemplate { get; set; }

        public string Properties { get; set; }
        public string ModelType { get; set; }

        private bool IsAttrDefined(Type attrType, Type targetType, string propName) {
            return Attribute.IsDefined(targetType.GetProperty(propName), attrType);
        }

        protected override void RenderContents(HtmlTextWriter writer) {
            Type targetType = Type.GetType(ModelType);
            string[] propertyNames = Properties.Split(',');
            foreach (string propRaw in propertyNames) {
                string property = propRaw.Trim();
                Dictionary<string, object> valAttribs = new Dictionary<string, object>();
                valAttribs.Add("data-val", "true");

                if (Context.Request.Form[property] != null) {
                    valAttribs.Add("value", Context.Request.Form[property]);
                }

                if (IsAttrDefined(typeof(RequiredAttribute), targetType, property)) {
                    valAttribs.Add("data-val-required",
                        string.Format("Provide a value for {0}", property));
                }

                if (IsAttrDefined(typeof(StringLengthAttribute), targetType, property)) {
                    object[] attrs = targetType.GetProperty(property)
                        .GetCustomAttributes(typeof(StringLengthAttribute), false);
                    if (attrs.Length > 0) {
                        StringLengthAttribute attr = (StringLengthAttribute)attrs[0];
                        valAttribs.Add("data-val-length", attr.ErrorMessage ??
                                string.Format("{0} must be {1}-{2} characters",
                                property, attr.MinimumLength, attr.MaximumLength));
                        valAttribs.Add("data-val-length-min", attr.MinimumLength);
                        valAttribs.Add("data-val-length-max", attr.MaximumLength);
                    }
                }

                if (IsAttrDefined(typeof(RangeAttribute), targetType, property)) {
                    object[] attrs = targetType.GetProperty(property)
                        .GetCustomAttributes(typeof(RangeAttribute), false);
                    if (attrs.Length > 0) {
                        RangeAttribute attr = (RangeAttribute)attrs[0];
                        valAttribs.Add("data-val-range", attr.ErrorMessage ??
                            string.Format("{0} must be {1}-{2} ",
                                property, attr.Minimum, attr.Maximum));
                        valAttribs.Add("data-val-range-min", attr.Minimum);
                        valAttribs.Add("data-val-range-max", attr.Maximum);
                    }
                }

                List<string> attrList = new List<string>();
                foreach (string key in valAttribs.Keys) {
                    attrList.Add(string.Format("{0}='{1}'", key, valAttribs[key]));
                }

                ValidationRepeaterTemplateItem elem
                    = new ValidationRepeaterTemplateItem {
                        DataItem = new ValidationRepeaterDataItem {
                            PropertyName = property,
                            ValidationAttributes = string.Join(" ", attrList.ToArray())
                        }
                    };
                PropertyTemplate.InstantiateIn(elem);
                elem.DataBind();
                elem.RenderControl(writer);
            }
        }
    }

    public class ValidationRepeaterDataItem {
        public string PropertyName { get; set; }
        public string ValidationAttributes { get; set; }
    }

    public class ValidationRepeaterTemplateItem : Control, IDataItemContainer {
        public object DataItem { get; set; }
        public int DataItemIndex { get; set; }
        public int DisplayIndex { get; set; }
    }
}
