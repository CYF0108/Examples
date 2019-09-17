using System;

namespace Ron.RedPacketTest.Service
{
    public class ChatGroupRedPacket : RedPacket
    {
        public override string Name { get; } = "ChatGroup";
        public override string Put(int org_id, int money, int count, string reason)
        {
            Console.WriteLine("���ȺID��{0},�Ƿ����", org_id);
            return base.Create(reason, money, count);
        }

        public override string Get(int id)
        {
            Console.WriteLine("���ȺID��{0}����ǰ�û��Ƿ�Ⱥ��Ա", id);
            return base.Fighting();
        }
    }
}