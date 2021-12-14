using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class MapBox2DFixtureConfigCategory : ProtoObject
    {
        public static MapBox2DFixtureConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, MapBox2DFixtureConfig> dict = new Dictionary<int, MapBox2DFixtureConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<MapBox2DFixtureConfig> list = new List<MapBox2DFixtureConfig>();
		
        public MapBox2DFixtureConfigCategory()
        {
            Instance = this;
        }
		
        public override void EndInit()
        {
            foreach (MapBox2DFixtureConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public MapBox2DFixtureConfig Get(int id)
        {
            this.dict.TryGetValue(id, out MapBox2DFixtureConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (MapBox2DFixtureConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, MapBox2DFixtureConfig> GetAll()
        {
            return this.dict;
        }

        public MapBox2DFixtureConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class MapBox2DFixtureConfig: ProtoObject, IConfig
	{
		[ProtoMember(1)]
		public int Id { get; set; }
		[ProtoMember(2)]
		public string Name { get; set; }
		[ProtoMember(3)]
		public long BodyId { get; set; }
		[ProtoMember(4)]
		public int DataId { get; set; }
		[ProtoMember(5)]
		public string FixtureType { get; set; }
		[ProtoMember(6)]
		public string FixturePosition { get; set; }
		[ProtoMember(7)]
		public bool IsTrigger { get; set; }
		[ProtoMember(8)]
		public string MapObjectType { get; set; }
		[ProtoMember(9)]
		public long MapObjectBodyId { get; set; }
		[ProtoMember(10)]
		public string MapObjectPosition1 { get; set; }
		[ProtoMember(11)]
		public string MapObjectPosition2 { get; set; }

	}
}
