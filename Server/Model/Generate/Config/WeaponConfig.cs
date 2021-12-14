using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class WeaponConfigCategory : ProtoObject
    {
        public static WeaponConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, WeaponConfig> dict = new Dictionary<int, WeaponConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<WeaponConfig> list = new List<WeaponConfig>();
		
        public WeaponConfigCategory()
        {
            Instance = this;
        }
		
        public override void EndInit()
        {
            foreach (WeaponConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public WeaponConfig Get(int id)
        {
            this.dict.TryGetValue(id, out WeaponConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (WeaponConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, WeaponConfig> GetAll()
        {
            return this.dict;
        }

        public WeaponConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class WeaponConfig: ProtoObject, IConfig
	{
		[ProtoMember(1)]
		public int Id { get; set; }
		[ProtoMember(3)]
		public string Name { get; set; }
		[ProtoMember(4)]
		public string Type { get; set; }
		[ProtoMember(5)]
		public string Description { get; set; }
		[ProtoMember(6)]
		public int Damage { get; set; }
		[ProtoMember(7)]
		public int MagazineSurplus { get; set; }
		[ProtoMember(8)]
		public int MagazineSize { get; set; }
		[ProtoMember(9)]
		public int BulletNum { get; set; }
		[ProtoMember(10)]
		public int Speed { get; set; }
		[ProtoMember(11)]
		public int Range { get; set; }
		[ProtoMember(12)]
		public int MaxFlyTime { get; set; }
		[ProtoMember(13)]
		public int CoolTime { get; set; }
		[ProtoMember(14)]
		public int SwitchTime { get; set; }
		[ProtoMember(15)]
		public int ReloadTime { get; set; }
		[ProtoMember(16)]
		public int Recoil { get; set; }
		[ProtoMember(17)]
		public int Weight { get; set; }
		[ProtoMember(18)]
		public int Price { get; set; }
		[ProtoMember(19)]
		public string FirePointOffset { get; set; }

	}
}
