﻿using GameFrameX.Setting;
using GameFrameX.Utility;
using Newtonsoft.Json;
using ProtoBuf;

namespace GameFrameX.NetWork.Messages
{
    [ProtoContract]
    public abstract class MessageObject : IMessage
    {
        /// <summary>
        /// 消息唯一id
        /// </summary>
        [JsonIgnore]
        public int UniId { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonIgnore]
        [ProtoMember(998)]
        public int MessageId { get; set; }

        public void SetMessageId(int messageId)
        {
            MessageId = messageId;
        }

        /// <summary>
        /// 消息的唯一ID
        /// </summary>
        [ProtoMember(999)]
        public int UniqueId { get; set; }

        protected MessageObject()
        {
            UpdateUniqueId();
        }

        public void UpdateUniqueId()
        {
            UniqueId = UtilityIdGenerator.GetNextUniqueIntId();
        }

        public void SetUniqueId(int uniqueId)
        {
            UniqueId = uniqueId;
        }

        public string ToSendMessageString(ServerType srcServerType, ServerType destServerType)
        {
            return $"---发送[{srcServerType} To {destServerType}] {ToMessageString()}";
        }

        public string ToReceiveMessageString(ServerType srcServerType, ServerType destServerType)
        {
            return $"---收到[{srcServerType} To {destServerType}] {ToMessageString()}";
        }

        public string ToMessageString()
        {
            return $"消息ID:[{MessageId}=MainId: {MessageManager.GetMainId(MessageId)} + SubId: {MessageManager.GetSubId(MessageId)},{GetType().Name}] 消息内容:{JsonHelper.Serialize(this)}";
        }

        public override string ToString()
        {
            return JsonHelper.Serialize(this);
        }
    }
}