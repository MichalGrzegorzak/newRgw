using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Kanc.UI.Tests.Core
{
    public static class CloneHelper
    {
        public static T CloneObject<T>(T item)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                //instancja BinaryFormattera - informujemy go,
                //ze bedzie uzyty w celu klonowania
                BinaryFormatter bf = new BinaryFormatter(null, new StreamingContext(StreamingContextStates.Clone));

                //serializacja
                bf.Serialize(ms, item);

                //przewijamy memoryStream do poczatku
                ms.Seek(0, SeekOrigin.Begin);

                //deserializacja
                return (T)bf.Deserialize(ms);
            }
        }

    }
}
