
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
    public sealed partial class IsAtLocation : ai.Decorator
    {
        /*
        public IsAtLocation(int Id, string NodeName, ai.EFlowAbortMode FlowAbortMode, float AcceptableRadius, string KeyboardKey, bool InverseCondition)  : base(Id, NodeName, FlowAbortMode) 
        {
            this.AcceptableRadius = AcceptableRadius;
            this.KeyboardKey = KeyboardKey;
            this.InverseCondition = InverseCondition;
            PostInit();
        }        
        */

        public IsAtLocation(JsonElement _buf)  : base(_buf) 
        {
            AcceptableRadius = _buf.GetProperty("acceptable_radius").GetSingle();
            KeyboardKey = _buf.GetProperty("keyboard_key").GetString();
            InverseCondition = _buf.GetProperty("inverse_condition").GetBoolean();
        }
    
        public static IsAtLocation DeserializeIsAtLocation(JsonElement _buf)
        {
            return new ai.IsAtLocation(_buf);
        }

        public float AcceptableRadius { private set; get; }
        public string KeyboardKey { private set; get; }
        public bool InverseCondition { private set; get; }

        private const int __ID__ = 1255972344;
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
            + "acceptableRadius:" + AcceptableRadius + ","
            + "keyboardKey:" + KeyboardKey + ","
            + "inverseCondition:" + InverseCondition + ","
            + "}";
        }

        partial void PostInit();
    }
}
