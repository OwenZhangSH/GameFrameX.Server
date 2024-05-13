
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
    public partial class TbNotIndexList : BaseDataTable<test.NotIndexList>
    {
        //private readonly System.Collections.Generic.List<test.NotIndexList> _dataList;
    
        //public System.Collections.Generic.List<test.NotIndexList> DataList => _dataList;
    

        public override async System.Threading.Tasks.Task LoadAsync()
        {
            var jsonElement = await _loadFunc();
            DataList.Clear();
            LongDataMaps.Clear();
            StringDataMaps.Clear();
            foreach(var element in jsonElement.EnumerateArray())
            {
                test.NotIndexList _v;
                _v = test.NotIndexList.DeserializeNotIndexList(element);
                DataList.Add(_v);
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

        public TbNotIndexList(Func<Task<JsonElement>> loadFunc) : base(loadFunc)
        {
        }
    }
}
