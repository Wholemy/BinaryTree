namespace Wholemy {
	public static partial class Map {
		#region #method# Add<T>(Owner, Insrc) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Add<T>(ref Float<T> Owner, float Insrc) {
			return Float<T>.Add(ref Owner, Insrc);
		}
		#endregion
		#region #method# Add<T>(Owner, Insrc, Value) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Add<T>(ref Float<T> Owner, float Insrc, T Value) {
			return Float<T>.Add(ref Owner, Insrc, Value);
		}
		#endregion
		#region #method# Put<T>(Owner, Insrc, Value) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Put<T>(ref Float<T> Owner, float Insrc, T Value) {
			return Float<T>.Put(ref Owner, Insrc, Value);
		}
		#endregion
		#region #method# Set<T>(Owner, Insrc, Value) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Set<T>(ref Float<T> Owner, float Insrc, T Value) {
			return Float<T>.Set(ref Owner, Insrc, Value);
		}
		#endregion
		#region #method# Get<T>(Owner, Insrc, Value) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Get<T>(ref Float<T> Owner, float Insrc, ref T Value) {
			var O = Owner;
			if (O != null) {
				O = O.Get(Insrc);
				if (O != null) {
					Owner = O;
					Value = O.Value;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# Get<T>(Owner, Insrc) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Get<T>(ref Float<T> Owner, float Insrc) {
			var O = Owner;
			if (O != null) {
				O = O.Get(Insrc);
				if (O != null) {
					Owner = O;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# GetValue<T>(Owner, Insrc) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static T GetValue<T>(ref Float<T> Owner, float Insrc) {
			var O = Owner;
			if (O != null) {
				O = O.Get(Insrc);
				if (O != null) {
					Owner = O;
					return O.Value;
				}
			}
			return default(T);
		}
		#endregion
		#region #method# GetA<T>(Owner, Insrc) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool GetA<T>(ref Float<T> Owner, float Insrc) {
			var O = Owner;
			if (O != null) {
				O = O.GetAbove(Insrc);
				if (O != null) {
					Owner = O;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# GetB<T>(Owner, Insrc) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool GetB<T>(ref Float<T> Owner, float Insrc) {
			var O = Owner;
			if (O != null) {
				O = O.GetBelow(Insrc);
				if (O != null) {
					Owner = O;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# GetAE<T>(Owner, Insrc) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool GetAE<T>(ref Float<T> Owner, float Insrc) {
			var O = Owner;
			if (O != null) {
				O = O.GetAbove(Insrc, true);
				if (O != null) {
					Owner = O;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# GetBE<T>(Owner, Insrc) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool GetBE<T>(ref Float<T> Owner, float Insrc) {
			var O = Owner;
			if (O != null) {
				O = O.GetBelow(Insrc, true);
				if (O != null) {
					Owner = O;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# CutA<T>(Owner, Insrc) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool CutA<T>(ref Float<T> Owner, float Insrc) {
			var O = Owner;
			if (O != null) {
				O = O.Get(Insrc);
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
		#region #method# CutB<T>(Owner, Insrc) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool CutB<T>(ref Float<T> Owner, float Insrc) {
			var O = Owner;
			if (O != null) {
				O = O.Get(Insrc);
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
		#region #struct# FloatInt 
		[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit, Pack = 4, Size = 4)]
		private struct FloatInt {
			[System.Runtime.InteropServices.FieldOffset(0)]
			public float Float;
			[System.Runtime.InteropServices.FieldOffset(0)]
			public int Int;
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static implicit operator FloatInt(float Float) { var fi = new FloatInt() { Float = Float }; if (fi.Int < 0) fi.Int = (~fi.Int | (1 << 31)); return fi; }
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static implicit operator FloatInt(int Int) { var fi = new FloatInt() { Int = Int }; if (fi.Int < 0) fi.Int = (~fi.Int | (1 << 31)); return fi; }
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static implicit operator float(FloatInt I) => I.Float;
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static implicit operator int(FloatInt I) => I.Int;
		}
		#endregion
		#region #class# Float<T> 
		/// <summary>Двоичное дерево типовых значений с 32 битным индексом числа с плавающей)</summary>
		/// <typeparam name="T">Тип значения)</typeparam>
		public class Float<T> {
			#region #new# (Index) 
			/// <summary>Инициализация нового элемента)</summary>
			/// <param name="Insrc">Исходный индекс элемента)</param>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public Float(float Insrc) {
				this.Shift = 0;
				this.Index = (FloatInt)Insrc;
				this.Insrc = Insrc;
				this.count = 1;
			}
			#endregion
			#region #new# (Index, Value) 
			/// <summary>Инициализация нового элемента)</summary>
			/// <param name="Insrc">Исходный индекс элемента)</param>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public Float(float Insrc, T Value) {
				this.Shift = 0;
				this.Index = (FloatInt)Insrc;
				this.Insrc = Insrc;
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
			private Float(Float<T> Old, Float<T> New) {
				var OldIndex = Old.Index << Old.Shift;
				var NewIndex = New.Index;
				var Shift = Bound;
				if (OldIndex == NewIndex) {
					Shift = 0;
				} else {
					var Step = Bound >> 1;
					var Mask = -1 << (Bound >> 1);
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
				this.Insrc = (FloatInt)this.Index;
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
				Float<T> Now, Low;
				if (How ^ this.Shift == Bound) {
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
			public readonly int Index;
			#endregion
			#region #readonly# Insrc 
			/// <summary>Индекс в исходном виде)</summary>
			public readonly float Insrc;
			#endregion
			#region #private# below 
			/// <summary>Нижний элемент или ветка при сдвиге больше нуля)</summary>
			#region #invisible# 
#if TRACE
			[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
#endif
			#endregion
			private Float<T> below;
			#endregion
			#region #get# Below 
			/// <summary>Возвращает нижний элемент или ветку при сдвиге больше нуля)</summary>
			public Float<T> Below => below;
			#endregion
			#region #private# above 
			/// <summary>Верхний элемент или ветка при сдвиге больше нуля)</summary>
			#region #invisible# 
#if TRACE
			[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
#endif
			#endregion
			private Float<T> above;
			#endregion
			#region #get# Above 
			/// <summary>Возвращает верхний элемент или ветку при сдвиге больше нуля)</summary>
			public Float<T> Above => above;
			#endregion
			#region #private# owner 
			/// <summary>Ветка владеющая этим элементом)</summary>
			#region #invisible# 
#if TRACE
			[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
#endif
			#endregion
			private Float<T> owner;
			#endregion
			#region #get# Owher 
			/// <summary>Возвращает ветку владеющую этим элементом)</summary>
			public Float<T> Owher => owner;
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
			public Float<T> Root {
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
			public Float<T> Base {
				#region #through# 
#if TRACE
				[System.Diagnostics.DebuggerStepThrough]
#endif
				#endregion
				get {
					var T = this;
					while (T.owner != null) T = T.owner;
					if (T.Shift == Bound) T = T.above;
					while (T.Shift > 0) { T = T.below; }
					return T;
				}
			}
			#endregion
			#region #property# Last 
			public Float<T> Last {
				#region #through# 
#if TRACE
				[System.Diagnostics.DebuggerStepThrough]
#endif
				#endregion
				get {
					var T = this;
					while (T.owner != null) T = T.owner;
					if (T.Shift == Bound) T = T.below;
					while (T.Shift > 0) { T = T.above; }
					return T;
				}
			}
			#endregion
			#region #property# Items 
			public Float<T>[] Items {
				#region #through# 
#if TRACE
				[System.Diagnostics.DebuggerStepThrough]
#endif
				#endregion
				get {
					var T = this;
					while (T.owner != null) T = T.owner;
					var I = T.count;
					var A = new Float<T>[I];
					if (T.Shift == Bound) T = T.below;
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
			#region #method# Add(Owner, Insrc) 
			/// <summary>Добавление элемента в дерево с уникальным индексом без установки значения)</summary>
			/// <param name="Owner">Текущий владелец элемента)</param>
			/// <param name="Insrc">Исходный индекс элемента)</param>
			/// <returns>Результат операции)</returns>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static bool Add(ref Float<T> Owner, float Insrc) {
				var O = Owner;
				int Index = (FloatInt)Insrc;
				if (O == null) { Owner = new Float<T>(Insrc); return true; }
				while (O.owner != null && O.Index != Index >> O.Shift) { O = O.owner; }
				while (O != null) {
					if (O.Shift == 0 && O.Index == Index) {
						return false;
					}
					if (O.Shift == 0 || (O.Shift < Bound && O.Index != Index >> O.Shift)) {
						new Float<T>(O, O = new Float<T>(Insrc)); Owner = O; return true;
					}
					if (((Index >> O.Shift - 1) & 1) != 0) { O = O.above; } else { O = O.below; }
				}
				return false;
			}
			#endregion
			#region #method# Add(Owner, Insrc, Value) 
			/// <summary>Добавление элемента в дерево с уникальным индексом и предустановленным значением)</summary>
			/// <param name="Owner">Текущий владелец элемента)</param>
			/// <param name="Insrc">Исходный индекс элемента)</param>
			/// <param name="Value">Устанавливаемое значение)</param>
			/// <returns>Результат операции)</returns>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static bool Add(ref Float<T> Owner, float Insrc, T Value) {
				var O = Owner;
				int Index = (FloatInt)Insrc;
				if (O == null) { Owner = new Float<T>(Insrc, Value); return true; }
				while (O.owner != null && O.Index != Index >> O.Shift) { O = O.owner; }
				while (O != null) {
					if (O.Shift == 0 && O.Index == Index) {
						return false;
					}
					if (O.Shift == 0 || (O.Shift < Bound && O.Index != Index >> O.Shift)) {
						new Float<T>(O, O = new Float<T>(Insrc, Value)); Owner = O; return true;
					}
					if (((Index >> O.Shift - 1) & 1) != 0) { O = O.above; } else { O = O.below; }
				}
				return false;
			}
			#endregion
			#region #method# Put(Owner, Insrc, Value) 
			/// <summary>Добавление элемента в дерево или установка значения существующего элемента)</summary>
			/// <param name="Owner">Текущий владелец элемента)</param>
			/// <param name="Insrc">Исходный индекс элемента)</param>
			/// <param name="Value">Устанавливаемое значение)</param>
			/// <returns>Результат операции)</returns>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static bool Put(ref Float<T> Owner, float Insrc, T Value) {
				var O = Owner;
				int Index = (FloatInt)Insrc;
				if (O == null) { Owner = new Float<T>(Insrc, Value); return true; }
				while (O.owner != null && O.Index != Index >> O.Shift) { O = O.owner; }
				while (O != null) {
					if (O.Shift == 0 && O.Index == Index) {
						O.value = Value; Owner = O; return true;
					}
					if (O.Shift == 0 || (O.Shift < Bound && O.Index != Index >> O.Shift)) {
						new Float<T>(O, O = new Float<T>(Insrc, Value)); Owner = O; return true;
					}
					if (((Index >> O.Shift - 1) & 1) != 0) { O = O.above; } else { O = O.below; }
				}
				return false;
			}
			#endregion
			#region #method# Set(Owner, Insrc, Value) 
			/// <summary>Установка значения существующего элемента)</summary>
			/// <param name="Owner">Текущий владелец элемента)</param>
			/// <param name="Insrc">Исходный индекс элемента)</param>
			/// <param name="Value">Устанавливаемое значение)</param>
			/// <returns>Результат операции)</returns>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static bool Set(ref Float<T> Owner, float Insrc, T Value) {
				var O = Owner;
				int Index = (FloatInt)Insrc;
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
			#region #method# Get(Insrc) 
			/// <summary>Возвращает элемент дерева по указанному индексу)</summary>
			/// <param name="Insrc">Исходный индекс элемента)</param>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public Float<T> Get(float Insrc) {
				var T = this;
				int Index = (FloatInt)Insrc;
				while (T.owner != null && T.Index != Index >> T.Shift) { T = T.owner; }
				while (T != null) {
					if (T.Shift == 0 && T.Index == Index) return T;
					if (T.Shift == 0 || (T.Shift < Bound && T.Index != Index >> T.Shift)) { return null; }
					if (((Index >> T.Shift - 1) & 1) != 0) { T = T.above; } else { T = T.below; }
				}
				return T;
			}
			#endregion
			#region #method# GetAbove(Insrc, Equal) 
			/// <summary>Возвращает элемент дерева по указанному индексу или выше)</summary>
			/// <param name="Insrc">Исходный индекс элемента)</param>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public Float<T> GetAbove(float Insrc, bool Equal = false) {
				var T = this;
				int Index = (FloatInt)Insrc;
				Float<T> A = null;
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
			#region #method# GetBelow(Insrc, Equal) 
			/// <summary>Возвращает элемент дерева по указанному индексу или ниже)</summary>
			/// <param name="Insrc">Исходный индекс элемента)</param>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public Float<T> GetBelow(float Insrc, bool Equal = false) {
				var T = this;
				int Index = (FloatInt)Insrc;
				Float<T> B = null;
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
			public Float<T> Cut() {
				if (this.Shift != 0) throw new System.InvalidOperationException();
				var T = this;
				var Index = this.Index;
				Float<T> Other, Owner, Cuted = T.owner;
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
				if (V != null) { return $"Index={Index.ToString(I)} Insrc={Insrc.ToString(I)} Value={V.ToString()}"; }
				return $"Index={Index.ToString(I)} Insrc={Insrc.ToString(I)}";
			}
			#endregion
			#region #implicit operator# = 
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static implicit operator Float<T>(float Insrc) {
				return new Float<T>(Insrc);
			}
			#endregion
			#region #operator# + 
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static Float<T> operator +(Float<T> T, float Insrc) {
				int Index = (FloatInt)Insrc;
				if (T == null) return new Float<T>(Index);
				while (T.owner != null && T.Index != Index >> T.Shift) { T = T.owner; }
				while (T != null) {
					if (T.Shift == 0 && T.Index == Index) return T;
					if (T.Shift == 0 || (T.Shift < Bound && T.Index != Index >> T.Shift)) {
						new Float<T>(T, T = new Float<T>(Insrc)); break;
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
			public static Float<T> operator +(Float<T> T, Float<T> I) {
				if (T == null) return I;
				var Index = I.Index;
				while (T.owner != null && T.Index != Index >> T.Shift) { T = T.owner; }
				while (T != null) {
					if (T.Shift == 0 && T.Index == Index) return T;
					if (T.Shift == 0 || (T.Shift < Bound && T.Index != Index >> T.Shift)) {
						new Float<T>(T, I); break;
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
			public static Float<T> operator -(Float<T> T, float Insrc) {
				int Index = (FloatInt)Insrc;
				Float<T> C = T;
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
