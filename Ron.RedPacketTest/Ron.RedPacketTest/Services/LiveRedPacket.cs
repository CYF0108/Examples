using System;

namespace Ron.RedPacketTest.Service
{
    public class LiveRedPacket : RedPacket
    {
        public override string Name { get; } = "Live";
        public override string Put(int org_id, int money, int count, string reason)
        {
            Console.WriteLine("���ֱ��ID:{0}�Ƿ����", org_id);
            return base.Create(reason, money, count);
        }

        public override string Get(int id)
        {
            Console.WriteLine("�����ID��{0} �Ƿ�ǰ�������", id);
            return base.Fighting();
        }
    }
}