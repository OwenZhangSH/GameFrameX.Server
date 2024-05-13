
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
    public sealed partial class ExcelFromJsonMultiRow : BeanBase
    {
        /*
        public ExcelFromJsonMultiRow(int Id, int X, System.Collections.Generic.List<test.TestRow> Items) 
        {
            this.Id = Id;
            this.X = X;
            this.Items = Items;
            PostInit();
        }        
        */

        public ExcelFromJsonMultiRow(JsonElement _buf) 
        {
            Id = _buf.GetProperty("id").GetInt32();
            X = _buf.GetProperty("x").GetInt32();
            { var __json0 = _buf.GetProperty("items"); Items = new System.Collections.Generic.List<test.TestRow>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { test.TestRow __v0;  __v0 = test.TestRow.DeserializeTestRow(__e0);  Items.Add(__v0); }   }
        }
    
        public static ExcelFromJsonMultiRow DeserializeExcelFromJsonMultiRow(JsonElement _buf)
        {
            return new test.ExcelFromJsonMultiRow(_buf);
        }

        public int Id { private set; get; }
        public int X { private set; get; }
        public System.Collections.Generic.List<test.TestRow> Items { private set; get; }

        private const int __ID__ = 715335694;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            
            foreach (var _e in Items) { _e?.ResolveRef(tables); }
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "x:" + X + ","
            + "items:" + StringUtil.CollectionToString(Items) + ","
            + "}";
        }

        partial void PostInit();
    }
}
