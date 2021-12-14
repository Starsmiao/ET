using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class MapBox2DBodyConfigCategory : ProtoObject
    {
        public static MapBox2DBodyConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, MapBox2DBodyConfig> dict = new Dictionary<int, MapBox2DBodyConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<MapBox2DBodyConfig> list = new List<MapBox2DBodyConfig>();
		
        public MapBox2DBodyConfigCategory()
        {
            Instance = this;
        }
		
        public override void EndInit()
        {
            foreach (MapBox2DBodyConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public MapBox2DBodyConfig Get(int id)
        {
            this.dict.TryGetValue(id, out MapBox2DBodyConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (MapBox2DBodyConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, MapBox2DBodyConfig> GetAll()
        {
            return this.dict;
        }

        public MapBox2DBodyConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class MapBox2DBodyConfig: ProtoObject, IConfig
	{
		[ProtoMember(1)]
		public int Id { get; set; }
		[ProtoMember(2)]
		public string Name { get; set; }
		[ProtoMember(3)]
		public string BodyType { get; set; }
		[ProtoMember(4)]
		public string BodyPosition { get; set; }
		[ProtoMember(5)]
		public bool FixedRotaion { get; set; }

	}
}
