using System;
using ArcheAge.ArcheAge.Network.Connections;
using LocalCommons.Network;

namespace ArcheAge.ArcheAge.Network.Packets.Server
{
    public sealed class NP_DetailedTimeOfDayPacket_0x00EA : NetPacket
    {
        public NP_DetailedTimeOfDayPacket_0x00EA(ClientConnection net) : base(01, 0x00EA)
        {
            //1.0.1406
            //DetailedTimeOfDayPacket
            //1400 DD01 EA00 4871B241 D171DA3A 00000000 0000C041
            ns.Write((float)DateTime.Now.Hour); //DateTime.UtcNow.Hour); //time f (����� ����� �� �������)(Environment.TickCount & Int32.MaxValue)
            ns.Write((float)0.001666600001044571399688720703125f); //speed f 
            ns.Write((float) 0.0f);  //start f
            ns.Write((float) 24.0f); //end f
        }
    }
}