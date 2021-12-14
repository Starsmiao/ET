using ET;
using ProtoBuf;
using System.Collections.Generic;
namespace ET
{
	[ResponseType(nameof(Actor_TransferResponse))]
	[Message(OuterOpcode.Actor_TransferRequest)]
	[ProtoContract]
	public partial class Actor_TransferRequest: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int MapIndex { get; set; }

	}

	[Message(OuterOpcode.Actor_TransferResponse)]
	[ProtoContract]
	public partial class Actor_TransferResponse: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(G2C_Ping))]
	[Message(OuterOpcode.C2G_Ping)]
	[ProtoContract]
	public partial class C2G_Ping: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.G2C_Ping)]
	[ProtoContract]
	public partial class G2C_Ping: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public long Time { get; set; }

	}

	[ResponseType(nameof(M2C_Reload))]
	[Message(OuterOpcode.C2M_Reload)]
	[ProtoContract]
	public partial class C2M_Reload: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string Account { get; set; }

		[ProtoMember(2)]
		public string Password { get; set; }

	}

	[Message(OuterOpcode.M2C_Reload)]
	[ProtoContract]
	public partial class M2C_Reload: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[ResponseType(nameof(M2C_TestRobotCase))]
	[Message(OuterOpcode.C2M_TestRobotCase)]
	[ProtoContract]
	public partial class C2M_TestRobotCase: Object, IActorLocationRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int N { get; set; }

	}

	[Message(OuterOpcode.M2C_TestRobotCase)]
	[ProtoContract]
	public partial class M2C_TestRobotCase: Object, IActorLocationResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public int N { get; set; }

	}

// ------------------------------------------------------------------------------自定义------------------------------------------------------------------------------
// ------------------------------------------------------------------------------自定义------------------------------------------------------------------------------
// ------------------------------------------------------------------------------自定义------------------------------------------------------------------------------
	[ResponseType(nameof(R2C_Login))]
	[Message(OuterOpcode.C2R_Login)]
	[ProtoContract]
	public partial class C2R_Login: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string Account { get; set; }

		[ProtoMember(2)]
		public string Password { get; set; }

	}

	[Message(OuterOpcode.R2C_Login)]
	[ProtoContract]
	public partial class R2C_Login: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public string Address { get; set; }

		[ProtoMember(2)]
		public long Key { get; set; }

		[ProtoMember(3)]
		public long GateId { get; set; }

	}

	[ResponseType(nameof(G2C_LoginGate))]
	[Message(OuterOpcode.C2G_LoginGate)]
	[ProtoContract]
	public partial class C2G_LoginGate: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long Key { get; set; }

	}

	[Message(OuterOpcode.G2C_LoginGate)]
	[ProtoContract]
	public partial class G2C_LoginGate: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

		[ProtoMember(2)]
		public long PlayerInstanceId { get; set; }

	}

	[ResponseType(nameof(R2C_Register))]
	[Message(OuterOpcode.C2R_Register)]
	[ProtoContract]
	public partial class C2R_Register: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public string Account { get; set; }

		[ProtoMember(2)]
		public string Password { get; set; }

	}

	[Message(OuterOpcode.R2C_Register)]
	[ProtoContract]
	public partial class R2C_Register: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.G2C_PlayerOffline)]
	[ProtoContract]
	public partial class G2C_PlayerOffline: Object, IMessage
	{
		[ProtoMember(1)]
		public int PlayerOfflineType { get; set; }

	}

	[ResponseType(nameof(G2C_GetPlayerInfo))]
	[Message(OuterOpcode.C2G_GetPlayerInfo)]
	[ProtoContract]
	public partial class C2G_GetPlayerInfo: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

	}

	[Message(OuterOpcode.G2C_GetPlayerInfo)]
	[ProtoContract]
	public partial class G2C_GetPlayerInfo: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(2)]
		public string NickName { get; set; }

		[ProtoMember(3)]
		public int Wins { get; set; }

		[ProtoMember(4)]
		public int Loses { get; set; }

		[ProtoMember(5)]
		public long Money { get; set; }

	}

// 以下是匹配消息和房间消息
	[ResponseType(nameof(G2C_StartMatch))]
	[Message(OuterOpcode.C2G_StartMatch)]
	[ProtoContract]
	public partial class C2G_StartMatch: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public CharacterType CharacterType { get; set; }

		[ProtoMember(2)]
		public int PlayerNumLimit { get; set; }

		[ProtoMember(3)]
		public RoomType RoomType { get; set; }

		[ProtoMember(4)]
		public int MapId { get; set; }

	}

	[Message(OuterOpcode.G2C_StartMatch)]
	[ProtoContract]
	public partial class G2C_StartMatch: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.M2C_PlayerEnterRoom)]
	[ProtoContract]
	public partial class M2C_PlayerEnterRoom: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(94)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public List<UnitInfo> Units = new List<UnitInfo>();

	}

	[Message(OuterOpcode.M2C_PlayerExitRoom)]
	[ProtoContract]
	public partial class M2C_PlayerExitRoom: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(94)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

		[ProtoMember(2)]
		public int SeatIndex { get; set; }

	}

	[Message(OuterOpcode.UnitInfo)]
	[ProtoContract]
	public partial class UnitInfo: Object
	{
		[ProtoMember(1)]
		public long PlayerId { get; set; }

		[ProtoMember(2)]
		public long UnitId { get; set; }

		[ProtoMember(3)]
		public int SeatIndex { get; set; }

		[ProtoMember(4)]
		public string NickName { get; set; }

		[ProtoMember(5)]
		public bool IsReady { get; set; }

		[ProtoMember(6)]
		public float X { get; set; }

		[ProtoMember(7)]
		public float Y { get; set; }

		[ProtoMember(8)]
		public float Z { get; set; }

		[ProtoMember(9)]
		public CharacterType CharacterType { get; set; }

		[ProtoMember(10)]
		public CampType CampType { get; set; }

	}

	[Message(OuterOpcode.C2M_PlayerReady)]
	[ProtoContract]
	public partial class C2M_PlayerReady: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_PlayerReady)]
	[ProtoContract]
	public partial class M2C_PlayerReady: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(94)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

		[ProtoMember(2)]
		public int SeatIndex { get; set; }

	}

	[Message(OuterOpcode.M2C_GameStart)]
	[ProtoContract]
	public partial class M2C_GameStart: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(94)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_PlayerReconnect)]
	[ProtoContract]
	public partial class M2C_PlayerReconnect: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(94)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long PlayerId { get; set; }

	}

// 客户端加载资源完毕, 向服务端发送开始消息
	[Message(OuterOpcode.C2M_FightBegin)]
	[ProtoContract]
	public partial class C2M_FightBegin: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

// 心跳消息
	[ResponseType(nameof(G2C_HeartBeat))]
	[Message(OuterOpcode.C2G_HeartBeat)]
	[ProtoContract]
	public partial class C2G_HeartBeat: Object, IRequest
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

	}

	[Message(OuterOpcode.G2C_HeartBeat)]
	[ProtoContract]
	public partial class G2C_HeartBeat: Object, IResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

	}

// 返回游戏大厅
	[Message(OuterOpcode.C2G_ReturnLobby)]
	[ProtoContract]
	public partial class C2G_ReturnLobby: Object, IMessage
	{
	}

// 删除Unit消息
	[Message(OuterOpcode.M2C_RemoveUnits)]
	[ProtoContract]
	public partial class M2C_RemoveUnits: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(94)]
		public long UnitId { get; set; }

	}

// 以下是战斗消息
// 开枪消息
	[Message(OuterOpcode.C2M_Shoot)]
	[ProtoContract]
	public partial class C2M_Shoot: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

// 服务端验证过的开火消息
	[Message(OuterOpcode.M2C_Shoot)]
	[ProtoContract]
	public partial class M2C_Shoot: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public float FirePointX { get; set; }

		[ProtoMember(3)]
		public float FirePointY { get; set; }

		[ProtoMember(4)]
		public float AimDegree { get; set; }

		[ProtoMember(5)]
		public float AimRadian { get; set; }

	}

// 停止射击消息
	[Message(OuterOpcode.C2M_StopShoot)]
	[ProtoContract]
	public partial class C2M_StopShoot: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_StopShoot)]
	[ProtoContract]
	public partial class M2C_StopShoot: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

// 右摇杆瞄准消息
	[Message(OuterOpcode.C2M_JoystickAim)]
	[ProtoContract]
	public partial class C2M_JoystickAim: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public float AimX { get; set; }

		[ProtoMember(2)]
		public float AimY { get; set; }

	}

// 右表盘瞄准消息
	[Message(OuterOpcode.C2M_ClockAim)]
	[ProtoContract]
	public partial class C2M_ClockAim: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public float AimDegree { get; set; }

	}

	[Message(OuterOpcode.M2C_Aim)]
	[ProtoContract]
	public partial class M2C_Aim: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public float FirePointX { get; set; }

		[ProtoMember(3)]
		public float FirePointY { get; set; }

		[ProtoMember(4)]
		public float FireDirectionX { get; set; }

		[ProtoMember(5)]
		public float FireDirectionY { get; set; }

		[ProtoMember(6)]
		public float AimDegree { get; set; }

		[ProtoMember(7)]
		public float AimRadian { get; set; }

		[ProtoMember(8)]
		public TargetQuaternion TargetQuaternion { get; set; }

	}

// 服务端通知客户端角色朝向更改
	[Message(OuterOpcode.M2C_CharacterFlip)]
	[ProtoContract]
	public partial class M2C_CharacterFlip: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public bool IsFlipped { get; set; }

	}

// 摇杆移动
	[Message(OuterOpcode.C2M_Move)]
	[ProtoContract]
	public partial class C2M_Move: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public MoveDirection MoveDirection { get; set; }

	}

	[Message(OuterOpcode.M2C_Move)]
	[ProtoContract]
	public partial class M2C_Move: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public MoveDirection MoveDirection { get; set; }

	}

// 摇杆抬起停止移动
	[Message(OuterOpcode.C2M_StopMove)]
	[ProtoContract]
	public partial class C2M_StopMove: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_StopMove)]
	[ProtoContract]
	public partial class M2C_StopMove: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public float X { get; set; }

		[ProtoMember(3)]
		public float Y { get; set; }

		[ProtoMember(4)]
		public MoveState MoveState { get; set; }

	}

	[Message(OuterOpcode.M2C_Stand)]
	[ProtoContract]
	public partial class M2C_Stand: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public bool Recreate { get; set; }

	}

// 切换到走路模式
	[Message(OuterOpcode.C2M_Walk)]
	[ProtoContract]
	public partial class C2M_Walk: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_Walk)]
	[ProtoContract]
	public partial class M2C_Walk: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public bool Recreate { get; set; }

	}

// 切换到跑步模式
	[Message(OuterOpcode.C2M_Run)]
	[ProtoContract]
	public partial class C2M_Run: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_Run)]
	[ProtoContract]
	public partial class M2C_Run: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public bool IsFlipped { get; set; }

		[ProtoMember(3)]
		public bool Recreate { get; set; }

	}

// 向前滚
	[Message(OuterOpcode.C2M_RollFront)]
	[ProtoContract]
	public partial class C2M_RollFront: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_RollFront)]
	[ProtoContract]
	public partial class M2C_RollFront: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public float Speed { get; set; }

	}

// 向后滚
	[Message(OuterOpcode.C2M_RollBack)]
	[ProtoContract]
	public partial class C2M_RollBack: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_RollBack)]
	[ProtoContract]
	public partial class M2C_RollBack: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public float Speed { get; set; }

	}

// 切换到蹲下模式
	[Message(OuterOpcode.C2M_Squat)]
	[ProtoContract]
	public partial class C2M_Squat: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_Squat)]
	[ProtoContract]
	public partial class M2C_Squat: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

	[Message(OuterOpcode.M2C_SquatWalk)]
	[ProtoContract]
	public partial class M2C_SquatWalk: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

// 切换到趴下模式
	[Message(OuterOpcode.C2M_Lie)]
	[ProtoContract]
	public partial class C2M_Lie: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_Lie)]
	[ProtoContract]
	public partial class M2C_Lie: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

	[Message(OuterOpcode.M2C_Crawl)]
	[ProtoContract]
	public partial class M2C_Crawl: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

// 向上跳跃
	[Message(OuterOpcode.C2M_JumpUp)]
	[ProtoContract]
	public partial class C2M_JumpUp: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_Jump)]
	[ProtoContract]
	public partial class M2C_Jump: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

// 向下跳跃
	[Message(OuterOpcode.C2M_JumpDown)]
	[ProtoContract]
	public partial class C2M_JumpDown: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_JumpDown)]
	[ProtoContract]
	public partial class M2C_JumpDown: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

	[Message(OuterOpcode.M2C_Fall)]
	[ProtoContract]
	public partial class M2C_Fall: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

// 切换到攀爬模式
	[Message(OuterOpcode.C2M_Hang)]
	[ProtoContract]
	public partial class C2M_Hang: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_Hang)]
	[ProtoContract]
	public partial class M2C_Hang: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

	[Message(OuterOpcode.M2C_Descend)]
	[ProtoContract]
	public partial class M2C_Descend: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

	[Message(OuterOpcode.M2C_Climb)]
	[ProtoContract]
	public partial class M2C_Climb: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

// 切换到驾驶模式
	[Message(OuterOpcode.C2M_Drive)]
	[ProtoContract]
	public partial class C2M_Drive: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_Drive)]
	[ProtoContract]
	public partial class M2C_Drive: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

// 切换到游泳模式
	[Message(OuterOpcode.C2M_Soak)]
	[ProtoContract]
	public partial class C2M_Soak: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

	[Message(OuterOpcode.M2C_Soak)]
	[ProtoContract]
	public partial class M2C_Soak: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

	[Message(OuterOpcode.M2C_Swim)]
	[ProtoContract]
	public partial class M2C_Swim: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

// 战斗消息
	[Message(OuterOpcode.M2C_Fight)]
	[ProtoContract]
	public partial class M2C_Fight: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public float X { get; set; }

		[ProtoMember(3)]
		public float Y { get; set; }

		[ProtoMember(4)]
		public TargetQuaternion TargetQuaternion { get; set; }

		[ProtoMember(5)]
		public float FirePointPositionX { get; set; }

		[ProtoMember(6)]
		public float FirePointPositionY { get; set; }

		[ProtoMember(7)]
		public string FootState { get; set; }

		[ProtoMember(8)]
		public string FilterState { get; set; }

	}

// 换弹消息
	[Message(OuterOpcode.C2M_ReloadBullet)]
	[ProtoContract]
	public partial class C2M_ReloadBullet: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

	}

// 开始换弹
	[Message(OuterOpcode.M2C_BeginReloadBullet)]
	[ProtoContract]
	public partial class M2C_BeginReloadBullet: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

// 换弹完成
	[Message(OuterOpcode.M2C_CompleteReloadBullet)]
	[ProtoContract]
	public partial class M2C_CompleteReloadBullet: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public int MagazineSurplus { get; set; }

		[ProtoMember(3)]
		public int BulletNum { get; set; }

	}

// 切换武器
	[Message(OuterOpcode.C2M_SwitchWeapon)]
	[ProtoContract]
	public partial class C2M_SwitchWeapon: Object, IActorLocationMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public int WeaponId { get; set; }

	}

// 开始切枪
	[Message(OuterOpcode.M2C_BeginSwitchWeapon)]
	[ProtoContract]
	public partial class M2C_BeginSwitchWeapon: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

	}

// 切枪完成
	[Message(OuterOpcode.M2C_CompleteSwitchWeapon)]
	[ProtoContract]
	public partial class M2C_CompleteSwitchWeapon: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public int WeaponId { get; set; }

	}

	[Message(OuterOpcode.M2C_BulletHit)]
	[ProtoContract]
	public partial class M2C_BulletHit: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public long UnitId { get; set; }

		[ProtoMember(2)]
		public long ShotUnitId { get; set; }

		[ProtoMember(3)]
		public bool IsHeadShot { get; set; }

	}

	[Message(OuterOpcode.M2C_Debug)]
	[ProtoContract]
	public partial class M2C_Debug: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public MoveDirection MoveDirection { get; set; }

		[ProtoMember(2)]
		public string Message { get; set; }

	}

	[Message(OuterOpcode.C2G_PUBG)]
	[ProtoContract]
	public partial class C2G_PUBG: Object, IMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public CharacterType CharacterType { get; set; }

		[ProtoMember(2)]
		public int MapId { get; set; }

	}

	[Message(OuterOpcode.M2C_PUBG)]
	[ProtoContract]
	public partial class M2C_PUBG: Object, IActorMessage
	{
		[ProtoMember(93)]
		public long ActorId { get; set; }

		[ProtoMember(1)]
		public UnitInfo UnitInfo { get; set; }

	}

// 目标四元组
	[Message(OuterOpcode.TargetQuaternion)]
	[ProtoContract]
	public partial class TargetQuaternion: Object
	{
		[ProtoMember(1)]
		public float W { get; set; }

		[ProtoMember(2)]
		public float X { get; set; }

		[ProtoMember(3)]
		public float Y { get; set; }

		[ProtoMember(4)]
		public float Z { get; set; }

	}

/// <summary>
/// 移动方向
/// </summary>
// 动作状态
// 射击状态
// 角色类型
// 阵营类型
// 武器类型
/// <summary>
/// 房间类型
/// </summary>
/// <summary>
/// 回合制, 5分钟一把, 可以中途加入, 房间人数限制在2-10
/// </summary>
/// <summary>
/// 复活制, 30分钟一把, 不可以中途加入, 房间人数限制在20
/// </summary>
}
