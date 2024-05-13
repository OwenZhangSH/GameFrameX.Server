
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;
using GameFrameX.Config.Core;

namespace GameFrameX.Config.ai
{
    public sealed partial class DistanceLessThan : ai.Decorator
    {
        /*
        public DistanceLessThan(int Id, string NodeName, ai.EFlowAbortMode FlowAbortMode, string Actor1Key, string Actor2Key, float Distance, bool ReverseResult)  : base(Id, NodeName, FlowAbortMode) 
        {
            this.Actor1Key = Actor1Key;
            this.Actor2Key = Actor2Key;
            this.Distance = Distance;
            this.ReverseResult = ReverseResult;
            PostInit();
        }        
        */

        public DistanceLessThan(JsonElement _buf)  : base(_buf) 
        {
            Actor1Key = _buf.GetProperty("actor1_key").GetString();
            Actor2Key = _buf.GetProperty("actor2_key").GetString();
            Distance = _buf.GetProperty("distance").GetSingle();
            ReverseResult = _buf.GetProperty("reverse_result").GetBoolean();
        }
    
        public static DistanceLessThan DeserializeDistanceLessThan(JsonElement _buf)
        {
            return new ai.DistanceLessThan(_buf);
        }

        public string Actor1Key { private set; get; }
        public string Actor2Key { private set; get; }
        public float Distance { private set; get; }
        public bool ReverseResult { private set; get; }

        private const int __ID__ = -1207170283;
        public override int GetTypeId() => __ID__;

        public override void ResolveRef(TablesComponent tables)
        {
            base.ResolveRef(tables);
            
            
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "nodeName:" + NodeName + ","
            + "flowAbortMode:" + FlowAbortMode + ","
            + "actor1Key:" + Actor1Key + ","
            + "actor2Key:" + Actor2Key + ","
            + "distance:" + Distance + ","
            + "reverseResult:" + ReverseResult + ","
            + "}";
        }

        partial void PostInit();
    }
}
