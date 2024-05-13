
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
    public abstract partial class ComposeNode : ai.FlowNode
    {
        /*
        public ComposeNode(int Id, string NodeName, System.Collections.Generic.List<ai.Decorator> Decorators, System.Collections.Generic.List<ai.Service> Services)  : base(Id, NodeName, Decorators, Services) 
        {
            PostInit();
        }        
        */

        public ComposeNode(JsonElement _buf)  : base(_buf) 
        {
        }
    
        public static ComposeNode DeserializeComposeNode(JsonElement _buf)
        {
            switch (_buf.GetProperty("$type").GetString())
            {
                case "Sequence": return new ai.Sequence(_buf);
                case "Selector": return new ai.Selector(_buf);
                case "SimpleParallel": return new ai.SimpleParallel(_buf);
                default: throw new SerializationException();
            }
        }



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
            + "}";
        }

        partial void PostInit();
    }
}
