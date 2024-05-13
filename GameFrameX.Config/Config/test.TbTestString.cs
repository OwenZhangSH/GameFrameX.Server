
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
    public partial class TbTestString : BaseDataTable<test.TestString>
    {
        //private readonly System.Collections.Generic.Dictionary<string, test.TestString> _dataMap;
        //private readonly System.Collections.Generic.List<test.TestString> _dataList;
    
        //public System.Collections.Generic.Dictionary<string, test.TestString> DataMap => _dataMap;
        //public System.Collections.Generic.List<test.TestString> DataList => _dataList;
        //public test.TestString GetOrDefault(string key) => _dataMap.TryGetValue(key, out var v) ? v : null;
        //public test.TestString Get(string key) => _dataMap[key];
        //public test.TestString this[string key] => _dataMap[key];
    
        public override async System.Threading.Tasks.Task LoadAsync()
        {
            var jsonElement = await _loadFunc();
            DataList.Clear();
            LongDataMaps.Clear();
            StringDataMaps.Clear();
            foreach(var element in jsonElement.EnumerateArray())
            {
                test.TestString _v;
                _v = test.TestString.DeserializeTestString(element);
                DataList.Add(_v);
                StringDataMaps.Add(_v.Id.ToString(), _v);
            }
            PostInit();
        }

        public void ResolveRef(TablesComponent tables)
        {
            foreach(var element in DataList)
            {
                element.ResolveRef(tables);
            }
        }
    
    
        partial void PostInit();

        public TbTestString(Func<Task<JsonElement>> loadFunc) : base(loadFunc)
        {
        }
    }
}
