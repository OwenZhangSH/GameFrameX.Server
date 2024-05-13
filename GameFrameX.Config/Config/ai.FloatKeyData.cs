
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
    public sealed partial class FloatKeyData : ai.KeyData
    {
        /*
        public FloatKeyData(float Value)  : base() 
        {
            this.Value = Value;
            PostInit();
        }        
        */

        public FloatKeyData(JsonElement _buf)  : base(_buf) 
        {
            Value = _buf.GetProperty("value").GetSingle();
        }
    
        public static FloatKeyData DeserializeFloatKeyData(JsonElement _buf)
        {
            return new ai.FloatKeyData(_buf);
        }

        public float Value { private set; get; }

        private const int __ID__ = -719747885;
        public override int GetTypeId() => __ID__;

        public override void ResolveRef(TablesComponent tables)
        {
            base.ResolveRef(tables);
            
        }

        public override string ToString()
        {
            return "{ "
            + "value:" + Value + ","
            + "}";
        }

        partial void PostInit();
    }
}
