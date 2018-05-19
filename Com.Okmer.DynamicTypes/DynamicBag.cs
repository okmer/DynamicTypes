using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Com.Okmer.DynamicTypes
{
    [Serializable]
    public class DynamicBag : Dictionary<string, dynamic>
    {
        public DynamicBag() { }

        public DynamicBag(int capacity) : base(capacity) { }

        public DynamicBag(IDictionary<string, dynamic> dictionary) : base(dictionary) { }

        public DynamicBag(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public void ToBinaryFile(string fileName)
        {
            BinarySerialization.ToFile(this, fileName);
        }

        public static DynamicBag FromBinaryFile(string fileName)
        {
            return BinarySerialization.FromFile<DynamicBag>(fileName);
        }
    }
}
