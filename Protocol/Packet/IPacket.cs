using AlphaSound.Protocol.Stream;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaSound.Protocol.Packet
{
    public interface IPacket
    {
        void Encode(BinaryStream stream);

        void Decode(BinaryStream stream);
    }
}
