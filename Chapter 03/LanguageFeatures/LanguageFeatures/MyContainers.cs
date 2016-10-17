using System;

namespace LanguageFeatures {

    public class ValueContainer<T> {
        public T Value { get; set; }

        public bool HasValue {
            get { return Value != null; }
        }
    }
}