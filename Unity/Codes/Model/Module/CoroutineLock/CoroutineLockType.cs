namespace ET
{
    public static class CoroutineLockType
    {
        public const int None = 0;
        public const int Location = 1;                  // location进程上使用
        public const int ActorLocationSender = 2;       // ActorLocationSender中队列消息 
        public const int Mailbox = 3;                   // Mailbox中队列
        public const int UnitId = 4;                    // Map服务器上线下线时使用
        public const int DB = 5;
        public const int Resources = 6;
        public const int ResourcesLoader = 7;

        // 自定义
        public const int AccountName = 8;               // Realm上验证账号时使用
        public const int AccountId = 9;                 // Gate上登陆账号时使用
        public const int SessionLock = 10;               // 心跳和顶号执行下线逻辑时用

        public const int Max = 100; // 这个必须最大
    }
}