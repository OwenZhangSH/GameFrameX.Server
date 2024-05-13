
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
    public sealed partial class TestRef : BeanBase
    {
        /*
        public TestRef(int Id, int X1, int X12, int X2, int X3, int X4, int[] A1, int[] A2, System.Collections.Generic.List<int> B1, System.Collections.Generic.List<int> B2, System.Collections.Generic.HashSet<int> C1, System.Collections.Generic.HashSet<int> C2, System.Collections.Generic.Dictionary<int, int> D1, System.Collections.Generic.Dictionary<int, int> D2, int E1, long E2, string E3, int F1, long F2, string F3, test.RefDynamicBase S1) 
        {
            this.Id = Id;
            this.X1 = X1;
            this.X1_Ref = null;
            this.X12 = X12;
            this.X12_Ref = null;
            this.X2 = X2;
            this.X3 = X3;
            this.X4 = X4;
            this.X4_Ref = null;
            this.A1 = A1;
            this.A2 = A2;
            this.B1 = B1;
            this.B2 = B2;
            this.C1 = C1;
            this.C2 = C2;
            this.D1 = D1;
            this.D2 = D2;
            this.E1 = E1;
            this.E2 = E2;
            this.E3 = E3;
            this.F1 = F1;
            this.F2 = F2;
            this.F3 = F3;
            this.S1 = S1;
            PostInit();
        }        
        */

        public TestRef(JsonElement _buf) 
        {
            Id = _buf.GetProperty("id").GetInt32();
            X1 = _buf.GetProperty("x1").GetInt32();
            X1_Ref = null;
            X12 = _buf.GetProperty("x1_2").GetInt32();
            X12_Ref = null;
            X2 = _buf.GetProperty("x2").GetInt32();
            X3 = _buf.GetProperty("x3").GetInt32();
            X4 = _buf.GetProperty("x4").GetInt32();
            X4_Ref = null;
            { var __json0 = _buf.GetProperty("a1"); int _n0 = __json0.GetArrayLength(); A1 = new int[_n0]; int __index0=0; foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  A1[__index0++] = __v0; }   }
            { var __json0 = _buf.GetProperty("a2"); int _n0 = __json0.GetArrayLength(); A2 = new int[_n0]; int __index0=0; foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  A2[__index0++] = __v0; }   }
            { var __json0 = _buf.GetProperty("b1"); B1 = new System.Collections.Generic.List<int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  B1.Add(__v0); }   }
            { var __json0 = _buf.GetProperty("b2"); B2 = new System.Collections.Generic.List<int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  B2.Add(__v0); }   }
            { var __json0 = _buf.GetProperty("c1"); C1 = new System.Collections.Generic.HashSet<int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  C1.Add(__v0); }   }
            { var __json0 = _buf.GetProperty("c2"); C2 = new System.Collections.Generic.HashSet<int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int __v0;  __v0 = __e0.GetInt32();  C2.Add(__v0); }   }
            { var __json0 = _buf.GetProperty("d1"); D1 = new System.Collections.Generic.Dictionary<int, int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int _k0;  _k0 = __e0[0].GetInt32(); int _v0;  _v0 = __e0[1].GetInt32();  D1.Add(_k0, _v0); }   }
            { var __json0 = _buf.GetProperty("d2"); D2 = new System.Collections.Generic.Dictionary<int, int>(__json0.GetArrayLength()); foreach(JsonElement __e0 in __json0.EnumerateArray()) { int _k0;  _k0 = __e0[0].GetInt32(); int _v0;  _v0 = __e0[1].GetInt32();  D2.Add(_k0, _v0); }   }
            E1 = _buf.GetProperty("e1").GetInt32();
            E2 = _buf.GetProperty("e2").GetInt64();
            E3 = _buf.GetProperty("e3").GetString();
            F1 = _buf.GetProperty("f1").GetInt32();
            F2 = _buf.GetProperty("f2").GetInt64();
            F3 = _buf.GetProperty("f3").GetString();
            S1 = test.RefDynamicBase.DeserializeRefDynamicBase(_buf.GetProperty("s1"));
        }
    
        public static TestRef DeserializeTestRef(JsonElement _buf)
        {
            return new test.TestRef(_buf);
        }

        public int Id { private set; get; }
        public int X1 { private set; get; }
        public test.TestBeRef X1_Ref { private set; get; }
        public int X12 { private set; get; }
        public test.TestBeRef X12_Ref { private set; get; }
        public int X2 { private set; get; }
        public int X3 { private set; get; }
        public int X4 { private set; get; }
        public tag.TestTag X4_Ref { private set; get; }
        public int[] A1 { private set; get; }
        public test.TestBeRef[] A1_Ref { private set; get; }
        public int[] A2 { private set; get; }
        public test.TestBeRef[] A2_Ref { private set; get; }
        public System.Collections.Generic.List<int> B1 { private set; get; }
        public System.Collections.Generic.List<test.TestBeRef> B1_Ref { private set; get; }
        public System.Collections.Generic.List<int> B2 { private set; get; }
        public System.Collections.Generic.List<test.TestBeRef> B2_Ref { private set; get; }
        public System.Collections.Generic.HashSet<int> C1 { private set; get; }
        public System.Collections.Generic.HashSet<test.TestBeRef> C1_Ref { private set; get; }
        public System.Collections.Generic.HashSet<int> C2 { private set; get; }
        public System.Collections.Generic.HashSet<test.TestBeRef> C2_Ref { private set; get; }
        public System.Collections.Generic.Dictionary<int, int> D1 { private set; get; }
        public System.Collections.Generic.Dictionary<int, test.TestBeRef> D1_Ref { private set; get; }
        public System.Collections.Generic.Dictionary<int, int> D2 { private set; get; }
        public System.Collections.Generic.Dictionary<int, test.TestBeRef> D2_Ref { private set; get; }
        public int E1 { private set; get; }
        public long E2 { private set; get; }
        public string E3 { private set; get; }
        public int F1 { private set; get; }
        public long F2 { private set; get; }
        public string F3 { private set; get; }
        public test.RefDynamicBase S1 { private set; get; }

        private const int __ID__ = -543222491;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            X1_Ref = tables.TbTestBeRef.Get(X1);
            X12_Ref = tables.TbTestBeRef.Get(X12);
            
            
            X4_Ref = tables.TbTestTag.Get(X4);
            A1_Ref = new test.TestBeRef[A1.Length];
            for (int _i = 0; _i < A1.Length; _i++) { A1_Ref[_i] = tables.TbTestBeRef.Get(A1[_i]); }

            A2_Ref = new test.TestBeRef[A2.Length];
            for (int _i = 0; _i < A2.Length; _i++) { A2_Ref[_i] = tables.TbTestBeRef.Get(A2[_i]); }

            B1_Ref = new System.Collections.Generic.List<test.TestBeRef>();
            foreach (var _v in B1) { B1_Ref.Add(tables.TbTestBeRef.Get(_v)); }

            B2_Ref = new System.Collections.Generic.List<test.TestBeRef>();
            foreach (var _v in B2) { B2_Ref.Add(tables.TbTestBeRef.Get(_v)); }

            C1_Ref = new System.Collections.Generic.HashSet<test.TestBeRef>();
            foreach (var _v in C1) { C1_Ref.Add(tables.TbTestBeRef.Get(_v)); }

            C2_Ref = new System.Collections.Generic.HashSet<test.TestBeRef>();
            foreach (var _v in C2) { C2_Ref.Add(tables.TbTestBeRef.Get(_v)); }

            D1_Ref = new System.Collections.Generic.Dictionary<int, test.TestBeRef>();
            foreach (var (_k,_v) in D1) { D1_Ref.Add(_k, tables.TbTestBeRef.Get(_v)); }

            D2_Ref = new System.Collections.Generic.Dictionary<int, test.TestBeRef>();
            foreach (var (_k,_v) in D2) { D2_Ref.Add(_k, tables.TbTestBeRef.Get(_v)); }

            
            
            
            
            
            
            S1?.ResolveRef(tables);
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "x1:" + X1 + ","
            + "x12:" + X12 + ","
            + "x2:" + X2 + ","
            + "x3:" + X3 + ","
            + "x4:" + X4 + ","
            + "a1:" + StringUtil.CollectionToString(A1) + ","
            + "a2:" + StringUtil.CollectionToString(A2) + ","
            + "b1:" + StringUtil.CollectionToString(B1) + ","
            + "b2:" + StringUtil.CollectionToString(B2) + ","
            + "c1:" + StringUtil.CollectionToString(C1) + ","
            + "c2:" + StringUtil.CollectionToString(C2) + ","
            + "d1:" + StringUtil.CollectionToString(D1) + ","
            + "d2:" + StringUtil.CollectionToString(D2) + ","
            + "e1:" + E1 + ","
            + "e2:" + E2 + ","
            + "e3:" + E3 + ","
            + "f1:" + F1 + ","
            + "f2:" + F2 + ","
            + "f3:" + F3 + ","
            + "s1:" + S1 + ","
            + "}";
        }

        partial void PostInit();
    }
}
