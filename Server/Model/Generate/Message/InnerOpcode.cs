namespace ET
{
	public static partial class InnerOpcode
	{
		 public const ushort M2M_TrasferUnitRequest = 10001;
		 public const ushort M2M_TrasferUnitResponse = 10002;
		 public const ushort M2A_Reload = 10003;
		 public const ushort A2M_Reload = 10004;
		 public const ushort G2G_LockRequest = 10005;
		 public const ushort G2G_LockResponse = 10006;
		 public const ushort G2G_LockReleaseRequest = 10007;
		 public const ushort G2G_LockReleaseResponse = 10008;
		 public const ushort ObjectAddRequest = 10009;
		 public const ushort ObjectAddResponse = 10010;
		 public const ushort ObjectLockRequest = 10011;
		 public const ushort ObjectLockResponse = 10012;
		 public const ushort ObjectUnLockRequest = 10013;
		 public const ushort ObjectUnLockResponse = 10014;
		 public const ushort ObjectRemoveRequest = 10015;
		 public const ushort ObjectRemoveResponse = 10016;
		 public const ushort ObjectGetRequest = 10017;
		 public const ushort ObjectGetResponse = 10018;
		 public const ushort R2G_GetLoginKey = 10019;
		 public const ushort G2R_GetLoginKey = 10020;
		 public const ushort G2M_CreateUnit = 10021;
		 public const ushort M2G_CreateUnit = 10022;
		 public const ushort G2M_SessionDisconnect = 10023;
		 public const ushort M2G_SessionDisconnect = 10024;
		 public const ushort G2R_KickOutPlayer = 10025;
		 public const ushort R2G_KickOutPlayer = 10026;
		 public const ushort G2G_KickOutPlayerRequest = 10027;
		 public const ushort G2G_KickOutPlayerResponse = 10028;
		 public const ushort G2R_PlayerOnline = 10029;
		 public const ushort R2G_PlayerOnline = 10030;
		 public const ushort G2R_PlayerOffline = 10031;
		 public const ushort R2G_PlayerOffline = 10032;
		 public const ushort G2D_QueryPlayerInfo = 10033;
		 public const ushort D2G_QueryPlayerInfo = 10034;
		 public const ushort R2D_Login = 10035;
		 public const ushort R2D_Regist = 10036;
		 public const ushort G2M_PlayerEnterMatch = 10037;
		 public const ushort G2M_PlayerExitMatch = 10038;
		 public const ushort M2G_PlayerExitMatch = 10039;
		 public const ushort G2C_PlayerExitMatch = 10040;
		 public const ushort G2M_PlayerCancelMatch = 10041;
		 public const ushort MH2MP_CreateRoom = 10042;
		 public const ushort MP2MH_CreateRoom = 10043;
		 public const ushort MP2MH_PlayerExitRoom = 10044;
		 public const ushort MP2MH_SyncRoomState = 10045;
		 public const ushort MH2MP_PlayerEnterRoom = 10046;
		 public const ushort G2M_PlayerExitRoom = 10047;
		 public const ushort M2G_PlayerExitRoom = 10048;
		 public const ushort M2G_MatchSucess = 10049;
		 public const ushort G2M_PUBG = 10050;
	}
}
