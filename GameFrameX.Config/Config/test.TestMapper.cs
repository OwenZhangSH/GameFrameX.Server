
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
    public sealed partial class TestMapper : BeanBase
    {
        /*
        public TestMapper(int Id, CustomAudioType AudioType, System.Numerics.Vector2 V2) 
        {
            this.Id = Id;
            this.AudioType = AudioType;
            this.V2 = V2;
            PostInit();
        }        
        */

        public TestMapper(JsonElement _buf) 
        {
            Id = _buf.GetProperty("id").GetInt32();
            AudioType = (CustomAudioType)_buf.GetProperty("audio_type").GetInt32();
            V2 = ExternalTypeUtil.NewVector2(vec2.Deserializevec2(_buf.GetProperty("v2")));
        }
    
        public static TestMapper DeserializeTestMapper(JsonElement _buf)
        {
            return new test.TestMapper(_buf);
        }

        public int Id { private set; get; }
        public CustomAudioType AudioType { private set; get; }
        public System.Numerics.Vector2 V2 { private set; get; }

        private const int __ID__ = 149110895;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "audioType:" + AudioType + ","
            + "v2:" + V2 + ","
            + "}";
        }

        partial void PostInit();
    }
}
