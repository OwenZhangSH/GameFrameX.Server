
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Text.Json;
using GameFrameX.Config.Core;

namespace GameFrameX.Config.l10n
{
    public partial class TbPatchDemo : BaseDataTable<l10n.PatchDemo>
    {
        //private readonly System.Collections.Generic.Dictionary<int, l10n.PatchDemo> _dataMap;
        //private readonly System.Collections.Generic.List<l10n.PatchDemo> _dataList;
    
        //public System.Collections.Generic.Dictionary<int, l10n.PatchDemo> DataMap => _dataMap;
        //public System.Collections.Generic.List<l10n.PatchDemo> DataList => _dataList;
        //public l10n.PatchDemo GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
        //public l10n.PatchDemo Get(int key) => _dataMap[key];
        //public l10n.PatchDemo this[int key] => _dataMap[key];
    
        public override async System.Threading.Tasks.Task LoadAsync()
        {
            var jsonElement = await _loadFunc();
            DataList.Clear();
            LongDataMaps.Clear();
            StringDataMaps.Clear();
            foreach(var element in jsonElement.EnumerateArray())
            {
                l10n.PatchDemo _v;
                _v = l10n.PatchDemo.DeserializePatchDemo(element);
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

        public TbPatchDemo(Func<Task<JsonElement>> loadFunc) : base(loadFunc)
        {
        }
    }
}
