﻿using System;
using ProtoBuf;
using System.Collections.Generic;
using GameFrameX.NetWork.Messages;

namespace GameFrameX.Proto.Proto
{
	/// <summary>
	/// 
	/// </summary>
	public enum BagType
	{
		/// <summary>
		/// 默认
		/// </summary>
		Default = 0, 
		/// <summary>
		/// 宠物
		/// </summary>
		Pet = 1, 
	}

	/// <summary>
	/// 请求背包数据
	/// </summary>
	[ProtoContract]
	[MessageTypeHandler(6553700)]
	public partial class ReqBagInfo : MessageObject, IRequestMessage
	{
		/// <summary>
		/// 背包类型
		/// </summary>
		[ProtoMember(1)]
		public BagType BagType { get; set; }

	}

	/// <summary>
	/// 返回背包数据
	/// </summary>
	[ProtoContract]
	[MessageTypeHandler(6553701)]
	public partial class RespBagInfo : MessageObject, IResponseMessage
	{
		/// <summary>
		/// 
		/// </summary>
		[ProtoMember(1)]
		public Dictionary<int, long> ItemDic { get; set; }

	}

	/// <summary>
	/// 请求合成宠物
	/// </summary>
	[ProtoContract]
	[MessageTypeHandler(6553702)]
	public partial class ReqComposePet : MessageObject, IRequestMessage
	{
		/// <summary>
		/// 碎片id
		/// </summary>
		[ProtoMember(1)]
		public int FragmentId { get; set; }

	}

	/// <summary>
	/// 返回合成宠物
	/// </summary>
	[ProtoContract]
	[MessageTypeHandler(6553703)]
	public partial class RespComposePet : MessageObject, IResponseMessage
	{
		/// <summary>
		/// 合成宠物的Id
		/// </summary>
		[ProtoMember(1)]
		public int PetId { get; set; }

	}

	/// <summary>
	/// 请求使用道具
	/// </summary>
	[ProtoContract]
	[MessageTypeHandler(6553704)]
	public partial class ReqUseItem : MessageObject, IRequestMessage
	{
		/// <summary>
		/// 道具id
		/// </summary>
		[ProtoMember(1)]
		public int ItemId { get; set; }

	}

	/// <summary>
	/// 出售道具
	/// </summary>
	[ProtoContract]
	[MessageTypeHandler(6553705)]
	public partial class ReqSellItem : MessageObject, IRequestMessage
	{
		/// <summary>
		/// 道具id
		/// </summary>
		[ProtoMember(1)]
		public int ItemId { get; set; }

	}

	/// <summary>
	/// 出售道具
	/// </summary>
	[ProtoContract]
	[MessageTypeHandler(6553706)]
	public partial class RespItemChange : MessageObject, IResponseMessage
	{
		/// <summary>
		/// 变化的道具
		/// </summary>
		[ProtoMember(1)]
		public Dictionary<int, long> ItemDic { get; set; }

	}

}
