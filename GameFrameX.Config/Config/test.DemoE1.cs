
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;
using GameFrameX.Config.Core;

namespace GameFrameX.Config.test
{
    public sealed partial class DemoE1 : test.DemoD3
    {
        /*
        public DemoE1(int X1, int X3, int X4)  : base(X1, X3) 
        {
            this.X4 = X4;
            PostInit();
        }        
        */

        public DemoE1(JsonElement _buf)  : base(_buf) 
        {
            X4 = _buf.GetProperty("x4").GetInt32();
        }
    
        public static DemoE1 DeserializeDemoE1(JsonElement _buf)
        {
            return new test.DemoE1(_buf);
        }

        public int X4 { private set; get; }

        private const int __ID__ = -2138341717;
        public override int GetTypeId() => __ID__;

        public override void ResolveRef(TablesComponent tables)
        {
            base.ResolveRef(tables);
            
        }

        public override string ToString()
        {
            return "{ "
            + "x1:" + X1 + ","
            + "x3:" + X3 + ","
            + "x4:" + X4 + ","
            + "}";
        }

        partial void PostInit();
    }
}
