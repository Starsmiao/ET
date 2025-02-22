﻿using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using UnityEngine;
using System;
using Vector2 = System.Numerics.Vector2;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace ET
{
#if UNITY_EDITOR
    [InitializeOnLoad]
#endif
    public static class MongoRegister
    {
        static MongoRegister()
        {
            // 自动注册IgnoreExtraElements

            ConventionPack conventionPack = new ConventionPack { new IgnoreExtraElementsConvention(true) };

            ConventionRegistry.Register("IgnoreExtraElements", conventionPack, type => true);

#if SERVER
            BsonSerializer.RegisterSerializer(typeof(Vector2), new StructBsonSerialize<Vector2>());
            BsonSerializer.RegisterSerializer(typeof(Vector3), new StructBsonSerialize<Vector3>());
            BsonSerializer.RegisterSerializer(typeof(Vector4), new StructBsonSerialize<Vector4>());
            BsonSerializer.RegisterSerializer(typeof(Quaternion), new StructBsonSerialize<Quaternion>());
#elif ROBOT
			BsonSerializer.RegisterSerializer(typeof(Quaternion), new StructBsonSerialize<Quaternion>());
            BsonSerializer.RegisterSerializer(typeof(Vector2), new StructBsonSerialize<Vector2>());
            BsonSerializer.RegisterSerializer(typeof(Vector3), new StructBsonSerialize<Vector3>());
            BsonSerializer.RegisterSerializer(typeof(Vector4), new StructBsonSerialize<Vector4>());
#else
            BsonSerializer.RegisterSerializer(typeof(Vector4), new StructBsonSerialize<Vector4>());
            BsonSerializer.RegisterSerializer(typeof(Vector3), new StructBsonSerialize<Vector3>());
            BsonSerializer.RegisterSerializer(typeof(Vector2), new StructBsonSerialize<Vector2>());
#endif

#if UNITY_EDITOR
            UnityEngine.Debug.Log("执行了BsonHelper初始化");
#endif

#if SERVER
            var types = Game.EventSystem.GetTypes();

            foreach (Type type in types.Values)
            {
                if (!type.IsSubclassOf(typeof(Object)))
                {
                    continue;
                }

                if (type.IsGenericType)
                {
                    continue;
                }

                BsonClassMap.LookupClassMap(type);
            }
#endif
        }

        public static void Init()
        {

        }
    }
}