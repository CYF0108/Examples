using System;

namespace Ron.RedPacketTest.Service
{
    public abstract class RedPacket : IRedPacket
    {
        public abstract string Name { get; }

        public abstract string Put(int org_id, int money, int count, string reason);

        public abstract string Get(int id);

        protected string Create(string reason, int money, int count)
        {
            Console.WriteLine("������ͣ�{0}�������˺��:{1},��Money:{2},����:{3}", this.Name, reason, money, count);
            return "�ɹ�";
        }

        protected string Fighting()
        {
            Console.WriteLine("������ͣ�{0}�����������������:{0}", this.Name, nameof(Fighting));
            return "�ɹ�";
        }
    }
}