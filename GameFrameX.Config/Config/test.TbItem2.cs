
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
    public partial class TbItem2 : BaseDataTable<test.ItemBase>
    {
        //private readonly System.Collections.Generic.Dictionary<int, test.ItemBase> _dataMap;
        //private readonly System.Collections.Generic.List<test.ItemBase> _dataList;
    
        //public System.Collections.Generic.Dictionary<int, test.ItemBase> DataMap => _dataMap;
        //public System.Collections.Generic.List<test.ItemBase> DataList => _dataList;
        //public T GetOrDefaultAs<T>(int key) where T : test.ItemBase => _dataMap.TryGetValue(key, out var v) ? (T)v : null;
        //public T GetAs<T>(int key) where T : test.ItemBase => (T)_dataMap[key];
        //public test.ItemBase GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
        //public test.ItemBase Get(int key) => _dataMap[key];
        //public test.ItemBase this[int key] => _dataMap[key];
    
        public override async System.Threading.Tasks.Task LoadAsync()
        {
            var jsonElement = await _loadFunc();
            DataList.Clear();
            LongDataMaps.Clear();
            StringDataMaps.Clear();
            foreach(var element in jsonElement.EnumerateArray())
            {
                test.ItemBase _v;
                _v = test.ItemBase.DeserializeItemBase(element);
                DataList.Add(_v);
                LongDataMaps.Add(_v.Id, _v);
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

        public TbItem2(Func<Task<JsonElement>> loadFunc) : base(loadFunc)
        {
        }
    }
}
