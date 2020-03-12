using AlphaSound.Protocol.Stream;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaSound.Protocol.Packet
{
    public abstract class Packet<T> : IPacket where T : new()
    {
        public abstract void Encode(BinaryStream stream);

        public abstract void Decode(BinaryStream stream);
    }
}
