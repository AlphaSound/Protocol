using AlphaSound.Protocol.Stream;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaSound.Protocol.Packet.RakNet
{
    public class ConnectedPing : Packet<ConnectedPing>
    {
        public long PingTimestamp { get; set; }

        public override void Encode(BinaryStream stream)
        {
            stream.WriteInt64(PingTimestamp);
        }

        public override void Decode(BinaryStream stream)
        {
            PingTimestamp = stream.ReadInt64();
        }
    }
}
