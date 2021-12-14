using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class CharacterBox2DConfigCategory : ProtoObject
    {
        public static CharacterBox2DConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, CharacterBox2DConfig> dict = new Dictionary<int, CharacterBox2DConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<CharacterBox2DConfig> list = new List<CharacterBox2DConfig>();
		
        public CharacterBox2DConfigCategory()
        {
            Instance = this;
        }
		
        public override void EndInit()
        {
            foreach (CharacterBox2DConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public CharacterBox2DConfig Get(int id)
        {
            this.dict.TryGetValue(id, out CharacterBox2DConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (CharacterBox2DConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, CharacterBox2DConfig> GetAll()
        {
            return this.dict;
        }

        public CharacterBox2DConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class CharacterBox2DConfig: ProtoObject, IConfig
	{
		[ProtoMember(1)]
		public int Id { get; set; }
		[ProtoMember(2)]
		public string Name { get; set; }
		[ProtoMember(3)]
		public double HeadCircleRadius { get; set; }
		[ProtoMember(4)]
		public double ChestCircleRadius { get; set; }
		[ProtoMember(5)]
		public double FootCircleRadius { get; set; }
		[ProtoMember(6)]
		public string StandChestBodyPosition { get; set; }
		[ProtoMember(7)]
		public string StandWaistBodyPosition { get; set; }
		[ProtoMember(8)]
		public string StandFootBodyPosition { get; set; }
		[ProtoMember(9)]
		public double StandChestBoxHX { get; set; }
		[ProtoMember(10)]
		public double StandChestBoxHY { get; set; }
		[ProtoMember(11)]
		public double StandWaistBoxHX { get; set; }
		[ProtoMember(12)]
		public double StandWaistBoxHY { get; set; }
		[ProtoMember(13)]
		public string StandHeadCirclePosition { get; set; }
		[ProtoMember(14)]
		public string StandChestBoxPosition { get; set; }
		[ProtoMember(15)]
		public string StandWaistBoxPosition { get; set; }
		[ProtoMember(16)]
		public string StandFootAxis { get; set; }
		[ProtoMember(17)]
		public string SquatChestBodyPosition { get; set; }
		[ProtoMember(18)]
		public double SquatChestBoxHX { get; set; }
		[ProtoMember(19)]
		public double SquatChestBoxHY { get; set; }
		[ProtoMember(20)]
		public double SquatWaistBoxHX { get; set; }
		[ProtoMember(21)]
		public double SquatWaistBoxHY { get; set; }
		[ProtoMember(22)]
		public string SquatHeadCirclePosition { get; set; }
		[ProtoMember(23)]
		public string SquatChestBoxPosition { get; set; }
		[ProtoMember(24)]
		public string SquatWaistBoxPosition { get; set; }
		[ProtoMember(25)]
		public string LieChestBodyPosition { get; set; }
		[ProtoMember(26)]
		public double LieChestBoxHX { get; set; }
		[ProtoMember(27)]
		public double LieChestBoxHY { get; set; }
		[ProtoMember(28)]
		public double LieWaistBoxHX { get; set; }
		[ProtoMember(29)]
		public double LieWaistBoxHY { get; set; }
		[ProtoMember(30)]
		public double LieWaistTempBoxHX { get; set; }
		[ProtoMember(31)]
		public double LieWaistTempBoxHY { get; set; }
		[ProtoMember(32)]
		public string LieHeadCirclePosition { get; set; }
		[ProtoMember(33)]
		public string LieChestBoxPosition { get; set; }
		[ProtoMember(34)]
		public string LieWaistBoxPosition { get; set; }
		[ProtoMember(35)]
		public string LieWaistTempBoxPosition { get; set; }
		[ProtoMember(36)]
		public string LieFootTempCirclePosition { get; set; }

	}
}
