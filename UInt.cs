namespace Wholemy {
	public static partial class Map {
		#region #method# Add<T>(#ref# Owner, Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Add<T>(ref UInt<T> Owner, uint Index) {
			return UInt<T>.Add(ref Owner, Index);
		}
		#endregion
		#region #method# Add<T>(#ref# Owner, Index, Value) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Add<T>(ref UInt<T> Owner, uint Index, T Value) {
			return UInt<T>.Add(ref Owner, Index, Value);
		}
		#endregion
		#region #method# Put<T>(#ref# Owner, Index, Value) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Put<T>(ref UInt<T> Owner, uint Index, T Value) {
			return UInt<T>.Put(ref Owner, Index, Value);
		}
		#endregion
		#region #method# Set<T>(#ref# Owner, Index, Value) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Set<T>(ref UInt<T> Owner, uint Index, T Value) {
			return UInt<T>.Set(ref Owner, Index, Value);
		}
		#endregion
		#region #method# Get<T>(#ref# Owner, Index, #ref# Value) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Get<T>(ref UInt<T> Owner, uint Index, ref T Value) {
			var O = Owner;
			if (O != null) {
				O = O.Get(Index);
				if (O != null) {
					Owner = O;
					Value = O.Value;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# Get<T>(#ref# Owner, Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Get<T>(ref UInt<T> Owner, uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.Get(Index);
				if (O != null) {
					Owner = O;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# GetA<T>(#ref# Owner, Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool GetA<T>(ref UInt<T> Owner, uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.GetAbove(Index);
				if (O != null) {
					Owner = O;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# GetA<T>(#ref# Owner, Index, Limit) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool GetA<T>(ref UInt<T> Owner, uint Index, uint Limit) {
			var O = Owner;
			if (O != null) {
				O = O.GetAbove(Index);
				if (O != null && O.Index <= Limit) {
					Owner = O;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# GetAE<T>(#ref# Owner, Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool GetAE<T>(ref UInt<T> Owner, uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.GetAbove(Index, true);
				if (O != null) {
					Owner = O;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# GetAE<T>(#ref# Owner, Index, Limit) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool GetAE<T>(ref UInt<T> Owner, uint Index, uint Limit) {
			var O = Owner;
			if (O != null) {
				O = O.GetAbove(Index, true);
				if (O != null && O.Index <= Limit) {
					Owner = O;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# GetB<T>(#ref# Owner, Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool GetB<T>(ref UInt<T> Owner, uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.GetBelow(Index);
				if (O != null) {
					Owner = O;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# GetB<T>(#ref# Owner, Index, Limit) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool GetB<T>(ref UInt<T> Owner, uint Index, uint Limit) {
			var O = Owner;
			if (O != null) {
				O = O.GetBelow(Index);
				if (O != null && O.Index >= Limit) {
					Owner = O;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# GetBE<T>(#ref# Owner, Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool GetBE<T>(ref UInt<T> Owner, uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.GetBelow(Index, true);
				if (O != null) {
					Owner = O;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# GetBE<T>(#ref# Owner, Index, Limit) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool GetBE<T>(ref UInt<T> Owner, uint Index, uint Limit) {
			var O = Owner;
			if (O != null) {
				O = O.GetBelow(Index, true);
				if (O != null && O.Index >= Limit) {
					Owner = O;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# GetV<T>(#ref# Owner, Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetV<T>(ref UInt<T> Owner, uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.Get(Index);
				if (O != null) {
					Owner = O;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVA<T>(#ref# Owner, Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVA<T>(ref UInt<T> Owner, uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.GetAbove(Index);
				if (O != null) {
					Owner = O;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVA<T>(#ref# Owner, #ref# Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVA<T>(ref UInt<T> Owner, ref uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.GetAbove(Index);
				if (O != null) {
					Owner = O;
					Index = O.Index;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVA<T>(#ref# Owner, Index, Limit) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVA<T>(ref UInt<T> Owner, uint Index, uint Limit) {
			var O = Owner;
			if (O != null) {
				O = O.GetAbove(Index);
				if (O != null && O.Index <= Limit) {
					Owner = O;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVA<T>(#ref# Owner, #ref# Index, Limit) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVA<T>(ref UInt<T> Owner, ref uint Index, uint Limit) {
			var O = Owner;
			if (O != null) {
				O = O.GetAbove(Index);
				if (O != null && O.Index <= Limit) {
					Owner = O;
					Index = O.Index;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVAE<T>(#ref# Owner, Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVAE<T>(ref UInt<T> Owner, uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.GetAbove(Index, true);
				if (O != null) {
					Owner = O;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVAE<T>(#ref# Owner, #ref# Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVAE<T>(ref UInt<T> Owner, ref uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.GetAbove(Index, true);
				if (O != null) {
					Owner = O;
					Index = O.Index;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVAE<T>(#ref# Owner, Index, Limit) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVAE<T>(ref UInt<T> Owner, uint Index, uint Limit) {
			var O = Owner;
			if (O != null) {
				O = O.GetAbove(Index, true);
				if (O != null && O.Index <= Limit) {
					Owner = O;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVAE<T>(#ref# Owner, #ref# Index, Limit) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVAE<T>(ref UInt<T> Owner, ref uint Index, uint Limit) {
			var O = Owner;
			if (O != null) {
				O = O.GetAbove(Index, true);
				if (O != null && O.Index <= Limit) {
					Owner = O;
					Index = O.Index;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVB<T>(#ref# Owner, Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVB<T>(ref UInt<T> Owner, uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.GetBelow(Index);
				if (O != null) {
					Owner = O;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVB<T>(#ref# Owner, #ref# Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVB<T>(ref UInt<T> Owner, ref uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.GetBelow(Index);
				if (O != null) {
					Owner = O;
					Index = O.Index;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVB<T>(#ref# Owner, Index, Limit) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVB<T>(ref UInt<T> Owner, uint Index, uint Limit) {
			var O = Owner;
			if (O != null) {
				O = O.GetBelow(Index);
				if (O != null && O.Index >= Limit) {
					Owner = O;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVB<T>(#ref# Owner, #ref# Index, Limit) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVB<T>(ref UInt<T> Owner, ref uint Index, uint Limit) {
			var O = Owner;
			if (O != null) {
				O = O.GetBelow(Index);
				if (O != null && O.Index >= Limit) {
					Owner = O;
					Index = O.Index;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVBE<T>(#ref# Owner, Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVBE<T>(ref UInt<T> Owner, uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.GetBelow(Index, true);
				if (O != null) {
					Owner = O;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVBE<T>(#ref# Owner, #ref# Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVBE<T>(ref UInt<T> Owner, ref uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.GetBelow(Index, true);
				if (O != null) {
					Owner = O;
					Index = O.Index;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVBE<T>(#ref# Owner, Index, Limit) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVBE<T>(ref UInt<T> Owner, uint Index, uint Limit) {
			var O = Owner;
			if (O != null) {
				O = O.GetBelow(Index, true);
				if (O != null && O.Index >= Limit) {
					Owner = O;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetVBE<T>(#ref# Owner, #ref# Index, Limit) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetVBE<T>(ref UInt<T> Owner, ref uint Index, uint Limit) {
			var O = Owner;
			if (O != null) {
				O = O.GetBelow(Index, true);
				if (O != null && O.Index >= Limit) {
					Owner = O;
					Index = O.Index;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# CutA<T>(#ref# Owner, Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool CutA<T>(ref UInt<T> Owner, uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.Get(Index);
				if (O != null) {
					var A = O.Above;
					if (A == null) A = O.Below;
					O.Cut();
					Owner = A;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# CutB<T>(#ref# Owner, Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool CutB<T>(ref UInt<T> Owner, uint Index) {
			var O = Owner;
			if (O != null) {
				O = O.Get(Index);
				if (O != null) {
					var A = O.Below;
					if (A == null) A = O.Above;
					O.Cut();
					Owner = A;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #class# UInt<T> 
		/// <summary>Двоичное дерево типовых значений с 32 битным индексом целого числа без знака)</summary>
		/// <typeparam name="T">Тип значения)</typeparam>
		public class UInt<T> {
			#region #new# (Index) 
			/// <summary>Инициализация нового элемента)</summary>
			/// <param name="Index">Предустановленный индекс)</param>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public UInt(uint Index) {
				this.Shift = 0;
				this.Index = Index;
				this.count = 1;
			}
			#endregion
			#region #new# (Index, Value) 
			/// <summary>Инициализация нового элемента)</summary>
			/// <param name="Index">Предустановленный индекс)</param>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public UInt(uint Index, T Value) {
				this.Shift = 0;
				this.Index = Index;
				this.count = 1;
				this.value = Value;
			}
			#endregion
			#region #new# (Old, New) 
			/// <summary>Инициализация связующего элемента)</summary>
			/// <param name="Old">Существующий элемент)</param>
			/// <param name="New">Добавляемый элемент)</param>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			private UInt(UInt<T> Old, UInt<T> New) {
				var OldIndex = Old.Index << Old.Shift;
				var NewIndex = New.Index;
				var Shift = Bound;
				if (OldIndex == NewIndex) {
					Shift = 0;
				} else {
					var Step = Bound >> 1;
					var Mask = uint.MaxValue << (Bound >> 1);
					while (Step > 0) {
						if ((OldIndex & Mask) == (NewIndex & Mask)) {
							Shift -= Step;
							OldIndex <<= Step;
							NewIndex <<= Step;
						}
						Step >>= 1;
						Mask <<= Step;
					}
				}
				this.Shift = Shift;
				this.Index = New.Index >> Shift;
				this.count = Old.count + New.count;
				bool How;
				if (((New.Index >> (Shift - 1)) & 1) != 0) {
					this.below = Old;
					this.above = New;
					How = true;
				} else {
					this.below = New;
					this.above = Old;
					How = false;
				}
				UInt<T> Now, Low;
				if (How/* ^ this.Shift == Bound*/) {
					Now = Old; while (Now.Shift > 0) { Now = Now.above; }
					Low = Now.above;
					Now.above = New;
					New.below = Now;
					New.above = Low;
					if (Low != null) Low.below = New;
				} else {
					Now = Old; while (Now.Shift > 0) { Now = Now.below; }
					Low = Now.below;
					New.above = Now;
					Now.below = New;
					New.below = Low;
					if (Low != null) Low.above = New;
				}
				var Parent = Old.owner;
				if (Parent != null) {
					this.owner = Parent;
					if (((New.Index >> Parent.Shift - 1) & 1) != 0) {
						if (Parent.above != Old) throw new System.InvalidOperationException();
						Parent.above = this;
					} else {
						if (Parent.below != Old) throw new System.InvalidOperationException();
						Parent.below = this;
					}
					do { Parent.count += New.count; } while ((Parent = Parent.owner) != null);
				}
				Old.owner = this;
				New.owner = this;
			}
			#endregion
			#region #const# Bound 
			/// <summary>Количество бит)</summary>
			public const int Bound = 32;
			#endregion
			#region #readonly# Shift 
			/// <summary>Сдвиг ветки, если больше нуля)</summary>
			public readonly int Shift;
			#endregion
			#region #readonly# Index 
			/// <summary>Индекс ветки, зависимый от сдвига)</summary>
			public readonly uint Index;
			#endregion
			#region #private# below 
			/// <summary>Нижний элемент или ветка при сдвиге больше нуля)</summary>
			#region #invisible# 
#if TRACE
			[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
#endif
			#endregion
			private UInt<T> below;
			#endregion
			#region #get# Below 
			/// <summary>Возвращает нижний элемент или ветку при сдвиге больше нуля)</summary>
			public UInt<T> Below => below;
			#endregion
			#region #private# above 
			/// <summary>Верхний элемент или ветка при сдвиге больше нуля)</summary>
			#region #invisible# 
#if TRACE
			[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
#endif
			#endregion
			private UInt<T> above;
			#endregion
			#region #get# Above 
			/// <summary>Возвращает верхний элемент или ветку при сдвиге больше нуля)</summary>
			public UInt<T> Above => above;
			#endregion
			#region #private# owner 
			/// <summary>Ветка владеющая этим элементом)</summary>
			#region #invisible# 
#if TRACE
			[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
#endif
			#endregion
			private UInt<T> owner;
			#endregion
			#region #get# Owher 
			/// <summary>Возвращает ветку владеющую этим элементом)</summary>
			public UInt<T> Owher => owner;
			#endregion
			#region #private# count 
			/// <summary>Количество элементов в ветке)</summary>
			#region #invisible# 
#if TRACE
			[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
#endif
			#endregion
			private int count;
			#endregion
			#region #get# Count 
			/// <summary>Возвращает количество элементов в ветке)</summary>
			public int Count => count;
			#endregion
			#region #private# value 
			/// <summary>Значение ветки)</summary>
			#region #invisible# 
#if TRACE
			[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
#endif
			#endregion
			private object value;
			#endregion
			#region #property# Value 
			/// <summary>Возвращает или устанавливает значение ветки)</summary>
			public T Value {
				#region #through# 
#if TRACE
				[System.Diagnostics.DebuggerStepThrough]
#endif
				#endregion
				get => this.value != null ? (T)this.value : default(T);
				#region #through# 
#if TRACE
				[System.Diagnostics.DebuggerStepThrough]
#endif
				#endregion
				set { this.value = value; }
			}
			#endregion
			#region #get# RootCount 
			public int RootCount {
				#region #through# 
#if TRACE
				[System.Diagnostics.DebuggerStepThrough]
#endif
				#endregion
				get {
					var A = this.count;
					var P = this.owner;
					while (P != null) {
						A = P.count;
						P = P.owner;
					}
					return A;
				}
			}
			#endregion
			#region #property# Root 
			public UInt<T> Root {
				#region #through# 
#if TRACE
				[System.Diagnostics.DebuggerStepThrough]
#endif
				#endregion
				get {
					var R = this;
					var P = this.owner;
					while (P != null) {
						R = P;
						P = P.owner;
					}
					return R;
				}
			}
			#endregion
			#region #property# Base 
			public UInt<T> Base {
				#region #through# 
#if TRACE
				[System.Diagnostics.DebuggerStepThrough]
#endif
				#endregion
				get {
					var T = this;
					while (T.owner != null) T = T.owner;
					//if (T.Shift == Bound) T = T.above;
					while (T.Shift > 0) { T = T.below; }
					return T;
				}
			}
			#endregion
			#region #property# Last 
			public UInt<T> Last {
				#region #through# 
#if TRACE
				[System.Diagnostics.DebuggerStepThrough]
#endif
				#endregion
				get {
					var T = this;
					while (T.owner != null) T = T.owner;
					//if (T.Shift == Bound) T = T.below;
					while (T.Shift > 0) { T = T.above; }
					return T;
				}
			}
			#endregion
			#region #property# Items 
			public UInt<T>[] Items {
				#region #through# 
#if TRACE
				[System.Diagnostics.DebuggerStepThrough]
#endif
				#endregion
				get {
					var T = this;
					while (T.owner != null) T = T.owner;
					var I = T.count;
					var A = new UInt<T>[I];
					//if (T.Shift == Bound) T = T.below;
					while (T.Shift > 0) { T = T.above; }
					while (T != null) {
						if (T.Shift > 0) throw new System.InvalidOperationException();
						A[--I] = T;
						T = T.below;
					}
					return A;
				}
			}
			#endregion
			#region #method# Add(Owner, Index) 
			/// <summary>Добавление элемента в дерево с уникальным индексом без установки значения)</summary>
			/// <param name="Owner">Текущий владелец элемента)</param>
			/// <param name="Index">Порядковый индекс элемента)</param>
			/// <returns>Результат операции)</returns>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static bool Add(ref UInt<T> Owner, uint Index) {
				var O = Owner;
				if (O == null) { Owner = new UInt<T>(Index); return true; }
				while (O.owner != null && O.Index != Index >> O.Shift) { O = O.owner; }
				while (O != null) {
					if (O.Shift == 0 && O.Index == Index) {
						return false;
					}
					if (O.Shift == 0 || (O.Shift < Bound && O.Index != Index >> O.Shift)) {
						new UInt<T>(O, O = new UInt<T>(Index)); Owner = O; return true;
					}
					if (((Index >> O.Shift - 1) & 1) != 0) { O = O.above; } else { O = O.below; }
				}
				return false;
			}
			#endregion
			#region #method# Add(Owner, Index, Value) 
			/// <summary>Добавление элемента в дерево с уникальным индексом и предустановленным значением)</summary>
			/// <param name="Owner">Текущий владелец элемента)</param>
			/// <param name="Index">Порядковый индекс элемента)</param>
			/// <param name="Value">Устанавливаемое значение)</param>
			/// <returns>Результат операции)</returns>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static bool Add(ref UInt<T> Owner, uint Index, T Value) {
				var O = Owner;
				if (O == null) { Owner = new UInt<T>(Index, Value); return true; }
				while (O.owner != null && O.Index != Index >> O.Shift) { O = O.owner; }
				while (O != null) {
					if (O.Shift == 0 && O.Index == Index) {
						return false;
					}
					if (O.Shift == 0 || (O.Shift < Bound && O.Index != Index >> O.Shift)) {
						new UInt<T>(O, O = new UInt<T>(Index, Value)); Owner = O; return true;
					}
					if (((Index >> O.Shift - 1) & 1) != 0) { O = O.above; } else { O = O.below; }
				}
				return false;
			}
			#endregion
			#region #method# Put(Owner, Index, Value) 
			/// <summary>Добавление элемента в дерево или установка значения существующего элемента)</summary>
			/// <param name="Owner">Текущий владелец элемента)</param>
			/// <param name="Index">Порядковый индекс элемента)</param>
			/// <param name="Value">Устанавливаемое значение)</param>
			/// <returns>Результат операции)</returns>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static bool Put(ref UInt<T> Owner, uint Index, T Value) {
				var O = Owner;
				if (O == null) { Owner = new UInt<T>(Index, Value); return true; }
				while (O.owner != null && O.Index != Index >> O.Shift) { O = O.owner; }
				while (O != null) {
					if (O.Shift == 0 && O.Index == Index) {
						O.value = Value; Owner = O; return true;
					}
					if (O.Shift == 0 || (O.Shift < Bound && O.Index != Index >> O.Shift)) {
						new UInt<T>(O, O = new UInt<T>(Index, Value)); Owner = O; return true;
					}
					if (((Index >> O.Shift - 1) & 1) != 0) { O = O.above; } else { O = O.below; }
				}
				return false;
			}
			#endregion
			#region #method# Set(Owner, Index, Value) 
			/// <summary>Установка значения существующего элемента)</summary>
			/// <param name="Owner">Текущий владелец элемента)</param>
			/// <param name="Index">Порядковый индекс элемента)</param>
			/// <param name="Value">Устанавливаемое значение)</param>
			/// <returns>Результат операции)</returns>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static bool Set(ref UInt<T> Owner, uint Index, T Value) {
				var O = Owner;
				if (O == null) { return false; }
				while (O.owner != null && O.Index != Index >> O.Shift) { O = O.owner; }
				while (O != null) {
					if (O.Shift == 0 && O.Index == Index) {
						O.value = Value; Owner = O; return true;
					}
					if (O.Shift == 0 || (O.Shift < Bound && O.Index != Index >> O.Shift)) {
						return false;
					}
					if (((Index >> O.Shift - 1) & 1) != 0) { O = O.above; } else { O = O.below; }
				}
				return false;
			}
			#endregion
			#region #method# Get(Index) 
			/// <summary>Возвращает элемент дерева по указанному индексу)</summary>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public UInt<T> Get(uint Index) {
				var T = this;
				while (T.owner != null && T.Index != Index >> T.Shift) { T = T.owner; }
				while (T != null) {
					if (T.Shift == 0 && T.Index == Index) return T;
					if (T.Shift == 0 || (T.Shift < Bound && T.Index != Index >> T.Shift)) { return null; }
					if (((Index >> T.Shift - 1) & 1) != 0) { T = T.above; } else { T = T.below; }
				}
				return T;
			}
			#endregion
			#region #method# GetAbove(Index, Equal) 
			/// <summary>Возвращает элемент дерева по указанному индексу или выше)</summary>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public UInt<T> GetAbove(uint Index, bool Equal = false) {
				var T = this;
				UInt<T> A = null;
				while (T.owner != null && T.Index != Index >> T.Shift) { T = T.owner; }
				while (T != null) {
					if (T.Shift == 0 && T.Index == Index) { if (Equal) return T; return T.above; }
					if (T.Shift == 0 || (T.Shift < Bound && T.Index != Index >> T.Shift)) { A = T; break; }
					if (((Index >> T.Shift - 1) & 1) != 0) { T = T.above; } else { T = T.below; }
				}
				while (A != null && A.Shift > 0) {
					if (A.Index <= Index >> A.Shift) { A = A.above; } else { A = A.below; }
				}
				while (A != null && A.Index <= Index) { A = A.above; }
				return A;
			}
			#endregion
			#region #method# GetBelow(Index, Equal) 
			/// <summary>Возвращает элемент дерева по указанному индексу или ниже)</summary>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public UInt<T> GetBelow(uint Index, bool Equal = false) {
				var T = this;
				UInt<T> B = null;
				while (T.owner != null && T.Index != Index >> T.Shift) { T = T.owner; }
				while (T != null) {
					if (T.Shift == 0 && T.Index == Index) { if (Equal) return T; return T.below; }
					if (T.Shift == 0 || (T.Shift < Bound && T.Index != Index >> T.Shift)) { B = T; break; }
					if (((Index >> T.Shift - 1) & 1) != 0) { T = T.above; } else { T = T.below; }
				}
				while (B != null && B.Shift > 0) {
					if (B.Index >= Index >> B.Shift) { B = B.below; } else { B = B.above; }
				}
				while (B != null && B.Index >= Index) { B = B.below; }
				return B;
			}
			#endregion
			#region #method# Cut() 
			/// <summary>Удаляет этот элемент)</summary>
			/// <returns>Возвращает этот элемент)</returns>
			/// <exception cref="System.InvalidOperationException">Если связующий элемент)</exception>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public UInt<T> Cut() {
				if (this.Shift != 0) throw new System.InvalidOperationException();
				var T = this;
				var Index = this.Index;
				UInt<T> Other, Owner, Cuted = T.owner;
				if (Cuted != null) {
					var Below = T.below;
					var Above = T.above;
					if (Below != null) Below.above = Above;
					if (Above != null) Above.below = Below;
					T.below = null;
					T.above = null;
					T.owner = null;
					if (((Index >> Cuted.Shift - 1) & 1) != 0) {
						#region #debug# 
#if DEBUG
						if (Cuted.above != T) throw new System.InvalidOperationException();
#endif
						#endregion
						Other = Cuted.below;
					} else {
						#region #debug# 
#if DEBUG
						if (Cuted.below != T) throw new System.InvalidOperationException();
#endif
						#endregion
						Other = Cuted.above;
					}
					Cuted.above = null;
					Cuted.below = null;
					Cuted.count = 0;
					Owner = Cuted.owner;
					if (Owner != null) {
						if (((Index >> Owner.Shift - 1) & 1) != 0) {
#if DEBUG
							if (Owner.above != Cuted) throw new System.InvalidOperationException();
#endif
							Owner.above = Other;
						} else {
#if DEBUG
							if (Owner.below != Cuted) throw new System.InvalidOperationException();
#endif
							Owner.below = Other;
						}
						Other.owner = Owner;
						Cuted.owner = null;
						Cuted = T;
						T = Owner;
						do { Owner.count -= Cuted.count; } while ((Owner = Owner.owner) != null);
					} else {
						Other.owner = null;
						T = Other;
					}
				} else {
					T = null;
				}
				return T;
			}
			#endregion
			#region #method# ToString 
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public override string ToString() {
				var I = System.Globalization.CultureInfo.InvariantCulture;
				if (Shift > 0) { return $"Shift={Shift.ToString(I)} Index={Index.ToString(I)} Count={count.ToString(I)}"; }
				var V = value;
				if (V != null) { return $"Index={Index.ToString(I)} Value={V.ToString()}"; }
				return $"Index={Index.ToString(I)}";
			}
			#endregion
			#region #implicit operator# = 
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static implicit operator UInt<T>(uint Index) {
				return new UInt<T>(Index);
			}
			#endregion
			#region #operator# + 
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static UInt<T> operator +(UInt<T> T, uint Index) {
				if (T == null) return new UInt<T>(Index);
				while (T.owner != null && T.Index != Index >> T.Shift) { T = T.owner; }
				while (T != null) {
					if (T.Shift == 0 && T.Index == Index) return T;
					if (T.Shift == 0 || (T.Shift < Bound && T.Index != Index >> T.Shift)) {
						new UInt<T>(T, T = new UInt<T>(Index)); break;
					}
					T = (((Index >> T.Shift - 1) & 1) != 0) ? T.above : T.below;
				}
				return T;
			}
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static UInt<T> operator +(UInt<T> T, UInt<T> I) {
				if (T == null) return I;
				var Index = I.Index;
				while (T.owner != null && T.Index != Index >> T.Shift) { T = T.owner; }
				while (T != null) {
					if (T.Shift == 0 && T.Index == Index) return T;
					if (T.Shift == 0 || (T.Shift < Bound && T.Index != Index >> T.Shift)) {
						new UInt<T>(T, I); break;
					}
					T = (((Index >> T.Shift - 1) & 1) != 0) ? T.above : T.below;
				}
				return I;
			}
			#endregion
			#region #operator# - 
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static UInt<T> operator -(UInt<T> T, uint Index) {
				UInt<T> C = T;
				if (T != null) {
					while (T.owner != null && T.Index != Index >> T.Shift) { T = T.owner; }
					while (T != null) {
						if (T.Shift == 0 && T.Index == Index) {
							C = T.above;
							if (C == null) C = T.below;
							T.Cut();
							return C;
						}
						if (T.Shift == 0 || (T.Shift < Bound && T.Index != Index >> T.Shift)) { return C; }
						if (((Index >> T.Shift - 1) & 1) != 0) { T = T.above; } else { T = T.below; }
					}
				}
				return C;
			}
			#endregion
		}
		#endregion
	}
}
