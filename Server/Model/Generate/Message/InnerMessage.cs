using ET;
using ProtoBuf;
using System.Collections.Generic;
namespace ET
{
/// <summary>
/// 传送unit
/// </summary>
	[ResponseType(nameof(M2M_TrasferUnitResponse))]
	[Message(InnerOpcode.M2M_TrasferUnitRequest)]
	[ProtoContract]
	public partial class M2M_TrasferUnitRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public Unit Unit { get; set; }

	}

	[Message(InnerOpcode.M2M_TrasferUnitResponse)]
	[ProtoContract]
	public partial class M2M_TrasferUnitResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public long InstanceId { get; set; }

	}

	[ResponseType(nameof(A2M_Reload))]
	[Message(InnerOpcode.M2A_Reload)]
	[ProtoContract]
	public partial class M2A_Reload: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(InnerOpcode.A2M_Reload)]
	[ProtoContract]
	public partial class A2M_Reload: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(G2G_LockResponse))]
	[Message(InnerOpcode.G2G_LockRequest)]
	[ProtoContract]
	public partial class G2G_LockRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Id { get; set; }

		[ProtoMember(2)]
		public string Address { get; set; }

	}

	[Message(InnerOpcode.G2G_LockResponse)]
	[ProtoContract]
	public partial class G2G_LockResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(G2G_LockReleaseResponse))]
	[Message(InnerOpcode.G2G_LockReleaseRequest)]
	[ProtoContract]
	public partial class G2G_LockReleaseRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Id { get; set; }

		[ProtoMember(2)]
		public string Address { get; set; }

	}

	[Message(InnerOpcode.G2G_LockReleaseResponse)]
	[ProtoContract]
	public partial class G2G_LockReleaseResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(ObjectAddResponse))]
	[Message(InnerOpcode.ObjectAddRequest)]
	[ProtoContract]
	public partial class ObjectAddRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Key { get; set; }

		[ProtoMember(2)]
		public long InstanceId { get; set; }

	}

	[Message(InnerOpcode.ObjectAddResponse)]
	[ProtoContract]
	public partial class ObjectAddResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(ObjectLockResponse))]
	[Message(InnerOpcode.ObjectLockRequest)]
	[ProtoContract]
	public partial class ObjectLockRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Key { get; set; }

		[ProtoMember(2)]
		public long InstanceId { get; set; }

		[ProtoMember(3)]
		public int Time { get; set; }

	}

	[Message(InnerOpcode.ObjectLockResponse)]
	[ProtoContract]
	public partial class ObjectLockResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(ObjectUnLockResponse))]
	[Message(InnerOpcode.ObjectUnLockRequest)]
	[ProtoContract]
	public partial class ObjectUnLockRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Key { get; set; }

		[ProtoMember(2)]
		public long OldInstanceId { get; set; }

		[ProtoMember(3)]
		public long InstanceId { get; set; }

	}

	[Message(InnerOpcode.ObjectUnLockResponse)]
	[ProtoContract]
	public partial class ObjectUnLockResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(ObjectRemoveResponse))]
	[Message(InnerOpcode.ObjectRemoveRequest)]
	[ProtoContract]
	public partial class ObjectRemoveRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Key { get; set; }

	}

	[Message(InnerOpcode.ObjectRemoveResponse)]
	[ProtoContract]
	public partial class ObjectRemoveResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(ObjectGetResponse))]
	[Message(InnerOpcode.ObjectGetRequest)]
	[ProtoContract]
	public partial class ObjectGetRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long Key { get; set; }

	}

	[Message(InnerOpcode.ObjectGetResponse)]
	[ProtoContract]
	public partial class ObjectGetResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public long InstanceId { get; set; }

	}

	[ResponseType(nameof(G2R_GetLoginKey))]
	[Message(InnerOpcode.R2G_GetLoginKey)]
	[ProtoContract]
	public partial class R2G_GetLoginKey: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public string Account { get; set; }

	}

	[Message(InnerOpcode.G2R_GetLoginKey)]
	[ProtoContract]
	public partial class G2R_GetLoginKey: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public long Key { get; set; }

		[ProtoMember(2)]
		public long GateId { get; set; }

	}

	[ResponseType(nameof(M2G_CreateUnit))]
	[Message(InnerOpcode.G2M_CreateUnit)]
	[ProtoContract]
	public partial class G2M_CreateUnit: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

		[ProtoMember(2)]
		public long GateSessionId { get; set; }

	}

	[Message(InnerOpcode.M2G_CreateUnit)]
	[ProtoContract]
	public partial class M2G_CreateUnit: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

// 自己的unit id
		[ProtoMember(1)]
		public long UnitId { get; set; }

// 所有的unit
		[ProtoMember(2)]
		public List<UnitInfo> Units = new List<UnitInfo>();

	}

	[ResponseType(nameof(M2G_SessionDisconnect))]
	[Message(InnerOpcode.G2M_SessionDisconnect)]
	[ProtoContract]
	public partial class G2M_SessionDisconnect: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(InnerOpcode.M2G_SessionDisconnect)]
	[ProtoContract]
	public partial class M2G_SessionDisconnect: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

// ------------------------------------------------------------------------------自定义------------------------------------------------------------------------------
// ------------------------------------------------------------------------------自定义------------------------------------------------------------------------------
// ------------------------------------------------------------------------------自定义------------------------------------------------------------------------------
	[ResponseType(nameof(R2G_KickOutPlayer))]
	[Message(InnerOpcode.G2R_KickOutPlayer)]
	[ProtoContract]
	public partial class G2R_KickOutPlayer: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

		[ProtoMember(2)]
		public int GateAppId { get; set; }

	}

	[Message(InnerOpcode.R2G_KickOutPlayer)]
	[ProtoContract]
	public partial class R2G_KickOutPlayer: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int GateAppId { get; set; }

	}

	[ResponseType(nameof(G2G_KickOutPlayerResponse))]
	[Message(InnerOpcode.G2G_KickOutPlayerRequest)]
	[ProtoContract]
	public partial class G2G_KickOutPlayerRequest: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

	}

	[Message(InnerOpcode.G2G_KickOutPlayerResponse)]
	[ProtoContract]
	public partial class G2G_KickOutPlayerResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(R2G_PlayerOnline))]
	[Message(InnerOpcode.G2R_PlayerOnline)]
	[ProtoContract]
	public partial class G2R_PlayerOnline: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

		[ProtoMember(2)]
		public int GateAppId { get; set; }

	}

	[Message(InnerOpcode.R2G_PlayerOnline)]
	[ProtoContract]
	public partial class R2G_PlayerOnline: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(R2G_PlayerOffline))]
	[Message(InnerOpcode.G2R_PlayerOffline)]
	[ProtoContract]
	public partial class G2R_PlayerOffline: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

	}

	[Message(InnerOpcode.R2G_PlayerOffline)]
	[ProtoContract]
	public partial class R2G_PlayerOffline: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(D2G_QueryPlayerInfo))]
	[Message(InnerOpcode.G2D_QueryPlayerInfo)]
	[ProtoContract]
	public partial class G2D_QueryPlayerInfo: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

	}

	[Message(InnerOpcode.D2G_QueryPlayerInfo)]
	[ProtoContract]
	public partial class D2G_QueryPlayerInfo: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(93)]
		public PlayerInfo PlayerInfo { get; set; }

	}

	[ResponseType(nameof(R2D_Regist))]
	[Message(InnerOpcode.R2D_Login)]
	[ProtoContract]
	public partial class R2D_Login: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public string Account { get; set; }

		[ProtoMember(2)]
		public string Password { get; set; }

	}

	[Message(InnerOpcode.R2D_Regist)]
	[ProtoContract]
	public partial class R2D_Regist: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public string Account { get; set; }

		[ProtoMember(2)]
		public string Password { get; set; }

	}

// 以下是匹配消息和房间消息
	[Message(InnerOpcode.G2M_PlayerEnterMatch)]
	[ProtoContract]
	public partial class G2M_PlayerEnterMatch: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerInstanceId { get; set; }

		[ProtoMember(2)]
		public long PlayerId { get; set; }

		[ProtoMember(3)]
		public long SessionInstanceId { get; set; }

		[ProtoMember(4)]
		public int PlayerNumLimit { get; set; }

		[ProtoMember(5)]
		public RoomType RoomType { get; set; }

		[ProtoMember(6)]
		public int MapId { get; set; }

		[ProtoMember(7)]
		public CharacterType CharacterType { get; set; }

	}

	[ResponseType(nameof(M2G_PlayerExitMatch))]
	[Message(InnerOpcode.G2M_PlayerExitMatch)]
	[ProtoContract]
	public partial class G2M_PlayerExitMatch: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

	}

	[Message(InnerOpcode.M2G_PlayerExitMatch)]
	[ProtoContract]
	public partial class M2G_PlayerExitMatch: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(InnerOpcode.G2C_PlayerExitMatch)]
	[ProtoContract]
	public partial class G2C_PlayerExitMatch: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

	}

	[Message(InnerOpcode.G2M_PlayerCancelMatch)]
	[ProtoContract]
	public partial class G2M_PlayerCancelMatch: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

	}

	[ResponseType(nameof(MP2MH_CreateRoom))]
	[Message(InnerOpcode.MH2MP_CreateRoom)]
	[ProtoContract]
	public partial class MH2MP_CreateRoom: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int PlayerNumLimit { get; set; }

		[ProtoMember(2)]
		public RoomType RoomType { get; set; }

		[ProtoMember(3)]
		public int MapId { get; set; }

	}

	[Message(InnerOpcode.MP2MH_CreateRoom)]
	[ProtoContract]
	public partial class MP2MH_CreateRoom: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public long RoomInstanceId { get; set; }

		[ProtoMember(2)]
		public long RoomId { get; set; }

	}

	[Message(InnerOpcode.MP2MH_PlayerExitRoom)]
	[ProtoContract]
	public partial class MP2MH_PlayerExitRoom: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long RoomInstanceId { get; set; }

		[ProtoMember(2)]
		public long PlayerId { get; set; }

	}

	[Message(InnerOpcode.MP2MH_SyncRoomState)]
	[ProtoContract]
	public partial class MP2MH_SyncRoomState: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long RoomInstanceId { get; set; }

		[ProtoMember(2)]
		public RoomState State { get; set; }

	}

	[Message(InnerOpcode.MH2MP_PlayerEnterRoom)]
	[ProtoContract]
	public partial class MH2MP_PlayerEnterRoom: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerInstanceId { get; set; }

		[ProtoMember(2)]
		public long PlayerId { get; set; }

		[ProtoMember(3)]
		public long SessionInstanceId { get; set; }

		[ProtoMember(4)]
		public CharacterType CharacterType { get; set; }

	}

	[ResponseType(nameof(M2G_PlayerExitRoom))]
	[Message(InnerOpcode.G2M_PlayerExitRoom)]
	[ProtoContract]
	public partial class G2M_PlayerExitRoom: Object, IActorRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

	}

	[Message(InnerOpcode.M2G_PlayerExitRoom)]
	[ProtoContract]
	public partial class M2G_PlayerExitRoom: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(InnerOpcode.M2G_MatchSucess)]
	[ProtoContract]
	public partial class M2G_MatchSucess: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public long UnitInstanceId { get; set; }

	}

	[Message(InnerOpcode.G2M_PUBG)]
	[ProtoContract]
	public partial class G2M_PUBG: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerInstanceId { get; set; }

		[ProtoMember(2)]
		public long PlayerId { get; set; }

		[ProtoMember(3)]
		public long SessionInstanceId { get; set; }

		[ProtoMember(4)]
		public int MapId { get; set; }

		[ProtoMember(5)]
		public CharacterType CharacterType { get; set; }

	}

}
