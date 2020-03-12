using AlphaSound.Protocol.Stream;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlphaSound.Protocol.Packet.RakNet
{
    public class ConnectionRequest : Packet<ConnectionRequest>
    {
        public ulong ClientId { get; set; }

        public long PingTimestamp { get; set; }

        public bool UseSecurity { get; set; }

        public override void Encode(BinaryStream stream)
        {
            stream.WriteUInt64(ClientId);
            stream.WriteInt64(PingTimestamp);
            stream.WriteBoolean(UseSecurity);
        }

        public override void Decode(BinaryStream stream)
        {
            ClientId = stream.ReadUInt64();
            PingTimestamp = stream.ReadInt64();
            UseSecurity = stream.ReadBoolean();
        }
    }
}
