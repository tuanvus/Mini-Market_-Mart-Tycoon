using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace com.adjust.sdk
{
	[DefaultMember("Item")]
	public class JSONNode
	{
		[CompilerGenerated]
		private sealed class _003Cget_Childs_003Ed__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private JSONNode _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_Childs_003Ed__17(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_DeepChilds_003Ed__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private JSONNode _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public JSONNode _003C_003E4__this;

			private IEnumerator<JSONNode> _003C_003E7__wrap1;

			private IEnumerator<JSONNode> _003C_003E7__wrap2;

			private JSONNode System_002ECollections_002EGeneric_002EIEnumerator_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_DeepChilds_003Ed__19(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[DebuggerHidden]
			private IEnumerator<JSONNode> System_002ECollections_002EGeneric_002EIEnumerable_003Ccom_002Eadjust_002Esdk_002EJSONNode_003E_002EGetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		public virtual JSONNode Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual JSONNode Item
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual int Count => 0;

		public virtual IEnumerable<JSONNode> Childs
		{
			[IteratorStateMachine(typeof(_003Cget_Childs_003Ed__17))]
			get
			{
				return null;
			}
		}

		public IEnumerable<JSONNode> DeepChilds
		{
			[IteratorStateMachine(typeof(_003Cget_DeepChilds_003Ed__19))]
			get
			{
				return null;
			}
		}

		public virtual int AsInt
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual float AsFloat
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual double AsDouble
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public virtual bool AsBool
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual JSONArray AsArray => null;

		public virtual JSONClass AsObject => null;

		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		public virtual void Add(JSONNode aItem)
		{
		}

		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		public static bool operator ==(JSONNode a, object b)
		{
			return false;
		}

		public static bool operator !=(JSONNode a, object b)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal static string Escape(string aText)
		{
			return null;
		}

		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		public void SaveToStream(Stream aData)
		{
		}

		public void SaveToCompressedStream(Stream aData)
		{
		}

		public void SaveToCompressedFile(string aFileName)
		{
		}

		public string SaveToCompressedBase64()
		{
			return null;
		}

		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}
	}
}
