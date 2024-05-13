
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
    public sealed partial class MoveToLocation : ai.Task
    {
        /*
        public MoveToLocation(int Id, string NodeName, System.Collections.Generic.List<ai.Decorator> Decorators, System.Collections.Generic.List<ai.Service> Services, bool IgnoreRestartSelf, float AcceptableRadius)  : base(Id, NodeName, Decorators, Services, IgnoreRestartSelf) 
        {
            this.AcceptableRadius = AcceptableRadius;
            PostInit();
        }        
        */

        public MoveToLocation(JsonElement _buf)  : base(_buf) 
        {
            AcceptableRadius = _buf.GetProperty("acceptable_radius").GetSingle();
        }
    
        public static MoveToLocation DeserializeMoveToLocation(JsonElement _buf)
        {
            return new ai.MoveToLocation(_buf);
        }

        public float AcceptableRadius { private set; get; }

        private const int __ID__ = -969953113;
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
            + "decorators:" + StringUtil.CollectionToString(Decorators) + ","
            + "services:" + StringUtil.CollectionToString(Services) + ","
            + "ignoreRestartSelf:" + IgnoreRestartSelf + ","
            + "acceptableRadius:" + AcceptableRadius + ","
            + "}";
        }

        partial void PostInit();
    }
}
