﻿using System;
using System.Globalization;

namespace ET
{
    public static class TimeHelper
    {
        public const long OneDay = 86400000;
        public const long Hour = 3600000;
        public const long Minute = 60000;

        /// <summary>
        /// FixedUpdate增量时间, 60帧
        /// </summary>
        public const float FixedDeltaTimeHigh = 1 / 60f;

        /// <summary>
        /// FixedUpdate增量时间, 15帧
        /// </summary>
        public const float FixedDeltaTimeLow = 1 / 15f;

        /// <summary>
        /// 客户端时间
        /// </summary>
        /// <returns></returns>
        public static long ClientNow()
        {
            return TimeInfo.Instance.ClientNow();
        }

        public static long ClientNowSeconds()
        {
            return ClientNow() / 1000;
        }

        public static DateTime DateTimeNow()
        {
            return DateTime.Now;
        }

        public static long ServerNow()
        {
            return TimeInfo.Instance.ServerNow();
        }

        public static long ClientFrameTime()
        {
            return TimeInfo.Instance.ClientFrameTime();
        }
        
        public static long ServerFrameTime()
        {
            return TimeInfo.Instance.ServerFrameTime();
        }
    }
}