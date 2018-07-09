using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlockchainIn15Minutes.Interfaces
{
    public interface ISerialize
    {
        T Deserialize<T>(byte[] byteArray);

        byte[] Serialize(object obj);
    }
}