// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by the Game Data Editor.
//
//      Changes to this file will be lost if the code is regenerated.
//
//      This file was generated from this data file:
//      /Users/EthanW/Documents/UnityProjects/EPoker/Assets/GameDataEditor/Resources/gde_data.txt
//  </autogenerated>
// ------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections.Generic;

using GameDataEditor;

namespace GameDataEditor
{
    public class GDETestSchemaData : IGDEData
    {
        static string TestIntKey = "TestInt";
		int _TestInt;
        public int TestInt
        {
            get { return _TestInt; }
            set {
                if (_TestInt != value)
                {
                    _TestInt = value;
					GDEDataManager.SetInt(_key, TestIntKey, _TestInt);
                }
            }
        }

        static string TestStringKey = "TestString";
		string _TestString;
        public string TestString
        {
            get { return _TestString; }
            set {
                if (_TestString != value)
                {
                    _TestString = value;
					GDEDataManager.SetString(_key, TestStringKey, _TestString);
                }
            }
        }

        static string TestSchemaKey = "TestSchema";
		GDETest2SchemaData _TestSchema;
        public GDETest2SchemaData TestSchema
        {
            get { return _TestSchema; }
            set {
                if (_TestSchema != value)
                {
                    _TestSchema = value;
					GDEDataManager.SetCustom(_key, TestSchemaKey, _TestSchema);
                }
            }
        }

        static string TestListKey = "TestList";
		public List<string>      TestList;
		public void Set_TestList()
        {
	        GDEDataManager.SetStringList(_key, TestListKey, TestList);
		}
		

        public GDETestSchemaData(string key) : base(key)
        {
            GDEDataManager.RegisterItem(this.SchemaName(), key);
        }
        public override Dictionary<string, object> SaveToDict()
		{
			var dict = new Dictionary<string, object>();
			dict.Add(GDMConstants.SchemaKey, "TestSchema");
			
            dict.Merge(true, TestInt.ToGDEDict(TestIntKey));
            dict.Merge(true, TestString.ToGDEDict(TestStringKey));

            dict.Merge(true, TestList.ToGDEDict(TestListKey));

            dict.Merge(true, TestSchema.ToGDEDict(TestSchemaKey));
            return dict;
		}

        public override void UpdateCustomItems(bool rebuildKeyList)
        {
            GDEDataManager.UpdateItem(TestSchema, rebuildKeyList);
            TestSchema.UpdateCustomItems(rebuildKeyList);
        }

        public override void LoadFromDict(string dataKey, Dictionary<string, object> dict)
        {
            _key = dataKey;

			if (dict == null)
				LoadFromSavedData(dataKey);
			else
			{
                dict.TryGetInt(TestIntKey, out _TestInt);
                dict.TryGetString(TestStringKey, out _TestString);

                string customDataKey;
                dict.TryGetString(TestSchemaKey, out customDataKey);
				_TestSchema = new GDETest2SchemaData(customDataKey);

                dict.TryGetStringList(TestListKey, out TestList);
                LoadFromSavedData(dataKey);
			}
		}

        public override void LoadFromSavedData(string dataKey)
		{
			_key = dataKey;
			
            _TestInt = GDEDataManager.GetInt(_key, TestIntKey, _TestInt);
            _TestString = GDEDataManager.GetString(_key, TestStringKey, _TestString);

            _TestSchema = GDEDataManager.GetCustom(_key, TestSchemaKey, _TestSchema);

            TestList = GDEDataManager.GetStringList(_key, TestListKey, TestList);
        }

        public GDETestSchemaData ShallowClone()
		{
			string newKey = Guid.NewGuid().ToString();
			GDETestSchemaData newClone = new GDETestSchemaData(newKey);

            newClone.TestInt = TestInt;
            newClone.TestString = TestString;

            newClone.TestSchema = TestSchema;

            newClone.TestList = new List<string>(TestList);
			newClone.Set_TestList();

            return newClone;
		}

        public GDETestSchemaData DeepClone()
		{
			GDETestSchemaData newClone = ShallowClone();
            newClone.TestSchema = TestSchema.DeepClone();
            return newClone;
		}

        public void Reset_TestInt()
        {
            GDEDataManager.ResetToDefault(_key, TestIntKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetInt(TestIntKey, out _TestInt);
        }

        public void Reset_TestString()
        {
            GDEDataManager.ResetToDefault(_key, TestStringKey);

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            dict.TryGetString(TestStringKey, out _TestString);
        }

        public void Reset_TestList()
        {
	        GDEDataManager.ResetToDefault(_key, TestListKey);

	        Dictionary<string, object> dict;
	        GDEDataManager.Get(_key, out dict);
	        dict.TryGetStringList(TestListKey, out TestList);
        }
		

        public void Reset_TestSchema()
		{
			GDEDataManager.ResetToDefault(_key, TestSchemaKey);

			Dictionary<string, object> dict;
	        GDEDataManager.Get(_key, out dict);

			string customDataKey;
            dict.TryGetString(TestSchemaKey, out customDataKey);
			_TestSchema = new GDETest2SchemaData(customDataKey);

			TestSchema.ResetAll();
		}

        public void ResetAll()
        {
            GDEDataManager.ResetToDefault(_key, TestIntKey);
            GDEDataManager.ResetToDefault(_key, TestStringKey);
            GDEDataManager.ResetToDefault(_key, TestListKey);
            GDEDataManager.ResetToDefault(_key, TestSchemaKey);

            Reset_TestSchema();

            Dictionary<string, object> dict;
            GDEDataManager.Get(_key, out dict);
            LoadFromDict(_key, dict);
        }
    }
}