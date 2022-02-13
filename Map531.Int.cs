namespace Wholemy {
	public static partial class Map531 {
		#region #method# Add(#ref# Owner, Index) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Add(ref Int Owner, int Index) {
			return Int.Add(ref Owner, Index);
		}
		#endregion
		#region #method# Add<T>(#ref# Owner, Index, Value) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Add<T>(ref Int Owner, int Index, T Value) {
			return Int.Add(ref Owner, new Int<T>(Index, Value));
		}
		#endregion
		#region #method# Put<T>(#ref# Owner, Index, Value) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Put<T>(ref Int Owner, int Index, T Value) {
			return Int.Put(ref Owner, new Int<T>(Index, Value));
		}
		#endregion
		#region #method# Set<T>(#ref# Owner, Index, Value) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Set<T>(ref Int Owner, int Index, T Value) {
			return Int.Set(ref Owner, new Int<T>(Index, Value));
		}
		#endregion
		#region #method# Get<T>(#ref# Owner, Index, #ref# Value) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool Get<T>(ref Int<T> Owner, int Index, ref T Value) {
			var O = Owner;
			if(O != null) {
				O = O.Get(Index) as Int<T>;
				if(O != null) {
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
		public static bool Get<T>(ref Int<T> Owner, int Index) {
			var O = Owner;
			if(O != null) {
				O = O.Get(Index) as Int<T>;
				if(O != null) {
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
		public static bool GetA<T>(ref Int<T> Owner, int Index) {
			var O = Owner;
			if(O != null) {
				O = O.GetAbove(Index) as Int<T>;
				if(O != null) {
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
		public static bool GetA<T>(ref Int<T> Owner, int Index, int Limit) {
			var O = Owner;
			if(O != null) {
				O = O.GetAbove(Index) as Int<T>;
				if(O != null && O.Index <= Limit) {
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
		public static bool GetAE<T>(ref Int<T> Owner, int Index) {
			var O = Owner;
			if(O != null) {
				O = O.GetAbove(Index, true) as Int<T>;
				if(O != null) {
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
		public static bool GetAE<T>(ref Int<T> Owner, int Index, int Limit) {
			var O = Owner;
			if(O != null) {
				O = O.GetAbove(Index, true) as Int<T>;
				if(O != null && O.Index <= Limit) {
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
		public static bool GetB<T>(ref Int<T> Owner, int Index) {
			var O = Owner;
			if(O != null) {
				O = O.GetBelow(Index) as Int<T>;
				if(O != null) {
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
		public static bool GetB<T>(ref Int<T> Owner, int Index, int Limit) {
			var O = Owner;
			if(O != null) {
				O = O.GetBelow(Index) as Int<T>;
				if(O != null && O.Index >= Limit) {
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
		public static bool GetBE<T>(ref Int<T> Owner, int Index) {
			var O = Owner;
			if(O != null) {
				O = O.GetBelow(Index, true) as Int<T>;
				if(O != null) {
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
		public static bool GetBE<T>(ref Int<T> Owner, int Index, int Limit) {
			var O = Owner;
			if(O != null) {
				O = O.GetBelow(Index, true) as Int<T>;
				if(O != null && O.Index >= Limit) {
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
		public static T GetV<T>(ref Int<T> Owner, int Index) {
			var O = Owner;
			if(O != null) {
				O = O.Get(Index) as Int<T>;
				if(O != null) {
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
		public static T GetVA<T>(ref Int<T> Owner, int Index) {
			var O = Owner;
			if(O != null) {
				O = O.GetAbove(Index) as Int<T>;
				if(O != null) {
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
		public static T GetVA<T>(ref Int<T> Owner, ref int Index) {
			var O = Owner;
			if(O != null) {
				O = O.GetAbove(Index) as Int<T>;
				if(O != null) {
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
		public static T GetVA<T>(ref Int<T> Owner, int Index, int Limit) {
			var O = Owner;
			if(O != null) {
				O = O.GetAbove(Index) as Int<T>;
				if(O != null && O.Index <= Limit) {
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
		public static T GetVA<T>(ref Int<T> Owner, ref int Index, int Limit) {
			var O = Owner;
			if(O != null) {
				O = O.GetAbove(Index) as Int<T>;
				if(O != null && O.Index <= Limit) {
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
		public static T GetVAE<T>(ref Int<T> Owner, int Index) {
			var O = Owner;
			if(O != null) {
				O = O.GetAbove(Index, true) as Int<T>;
				if(O != null) {
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
		public static T GetVAE<T>(ref Int<T> Owner, ref int Index) {
			var O = Owner;
			if(O != null) {
				O = O.GetAbove(Index, true) as Int<T>;
				if(O != null) {
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
		public static T GetVAE<T>(ref Int<T> Owner, int Index, int Limit) {
			var O = Owner;
			if(O != null) {
				O = O.GetAbove(Index, true) as Int<T>;
				if(O != null && O.Index <= Limit) {
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
		public static T GetVAE<T>(ref Int<T> Owner, ref int Index, int Limit) {
			var O = Owner;
			if(O != null) {
				O = O.GetAbove(Index, true) as Int<T>;
				if(O != null && O.Index <= Limit) {
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
		public static T GetVB<T>(ref Int<T> Owner, int Index) {
			var O = Owner;
			if(O != null) {
				O = O.GetBelow(Index) as Int<T>;
				if(O != null) {
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
		public static T GetVB<T>(ref Int<T> Owner, ref int Index) {
			var O = Owner;
			if(O != null) {
				O = O.GetBelow(Index) as Int<T>;
				if(O != null) {
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
		public static T GetVB<T>(ref Int<T> Owner, int Index, int Limit) {
			var O = Owner;
			if(O != null) {
				O = O.GetBelow(Index) as Int<T>;
				if(O != null && O.Index >= Limit) {
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
		public static T GetVB<T>(ref Int<T> Owner, ref int Index, int Limit) {
			var O = Owner;
			if(O != null) {
				O = O.GetBelow(Index) as Int<T>;
				if(O != null && O.Index >= Limit) {
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
		public static T GetVBE<T>(ref Int<T> Owner, int Index) {
			var O = Owner;
			if(O != null) {
				O = O.GetBelow(Index, true) as Int<T>;
				if(O != null) {
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
		public static T GetVBE<T>(ref Int<T> Owner, ref int Index) {
			var O = Owner;
			if(O != null) {
				O = O.GetBelow(Index, true) as Int<T>;
				if(O != null) {
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
		public static T GetVBE<T>(ref Int<T> Owner, int Index, int Limit) {
			var O = Owner;
			if(O != null) {
				O = O.GetBelow(Index, true) as Int<T>;
				if(O != null && O.Index >= Limit) {
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
		public static T GetVBE<T>(ref Int<T> Owner, ref int Index, int Limit) {
			var O = Owner;
			if(O != null) {
				O = O.GetBelow(Index, true) as Int<T>;
				if(O != null && O.Index >= Limit) {
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
		public static bool CutA<T>(ref Int<T> Owner, int Index) {
			var O = Owner;
			if(O != null) {
				O = O.Get(Index) as Int<T>;
				if(O != null) {
					var A = O.Above;
					if(A == null) A = O.Below;
					O.Cut();
					Owner = A;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# CutA<T>(#ref# Owner, Index, Limit) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool CutA<T>(ref Int<T> Owner, int Index, int Limit) {
			var O = Owner;
			if(O != null) {
				var A = O.GetAbove(Index, true) as Int<T>;
				if(A != null) {
					while(A != null && A.Index <= Limit) {
						var AA = A.Above;
						if(AA == null) { Owner = A.Below; A.Cut(); return true; }
						A.Cut();
						A = AA;
					}
					Owner = A;
					return true;
				}
				Owner = O.GetBelow(Index) as Int<T>;
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
		public static bool CutB<T>(ref Int<T> Owner, int Index) {
			var O = Owner;
			if(O != null) {
				O = O.Get(Index) as Int<T>;
				if(O != null) {
					var A = O.Below;
					if(A == null) A = O.Above;
					O.Cut();
					Owner = A;
					return true;
				}
			}
			return false;
		}
		#endregion
		#region #method# CutB<T>(#ref# Owner, Index, Limit) 
		#region #through# 
#if TRACE
		[System.Diagnostics.DebuggerStepThrough]
#endif
		#endregion
		public static bool CutB<T>(ref Int<T> Owner, int Index, int Limit) {
			var O = Owner;
			if(O != null) {
				var B = O.GetBelow(Index, true) as Int<T>;
				if(B != null) {
					while(B != null && B.Index >= Limit) {
						var BB = B.Below;
						if(BB == null) { Owner = B.Above; B.Cut(); return true; }
						B.Cut();
						B = BB;
					}
					Owner = B;
					return true;
				}
				Owner = O.GetAbove(Index) as Int<T>;
			}
			return false;
		}
		#endregion
		#region #class# Int<T> 
		/// <summary>Двоичное дерево типовых значений с 32 битным индексом целого числа со знаком)</summary>
		/// <typeparam name="T">Тип значения)</typeparam>
		public class Int<T>: Int {
			#region #new# (Index, Value) 
			/// <summary>Инициализация нового элемента)</summary>
			/// <param name="Index">Предустановленный индекс)</param>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public Int(int Index, T Value) : base(Index) {
				this.Value = Value;
			}
			#endregion
			public T Value;
			#region #get# Below 
			/// <summary>Возвращает нижний элемент или ветку при сдвиге больше нуля)</summary>
			public Int<T> Below {
				get {
					return base.below as Int<T>;
				}
			}
			#endregion
			#region #get# Above 
			/// <summary>Возвращает верхний элемент или ветку при сдвиге больше нуля)</summary>
			public Int<T> Above {
				get {
					return base.above as Int<T>;
				}
			}
			#endregion
			public Int<T> Base {
				get {
					return base.Base as Int<T>;
				}
			}
			public Int<T> Last {
				get {
					return base.Last as Int<T>;
				}
			}
		}
		/// <summary>Двоичное дерево без значений с 32 битным индексом целого числа со знаком)</summary>
		public class Int {
			#region #new# (Index) 
			/// <summary>Инициализация нового элемента)</summary>
			/// <param name="Index">Предустановленный индекс)</param>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public Int(int Index) {
				this.Shift = 0;
				this.Index = Index;
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
			private Int(Int Old, Int New) {
				var OldIndex = Old.Index << Old.Shift;
				var NewIndex = New.Index;
				var Shift = Bound;
				if(OldIndex == NewIndex) {
					Shift = 0;
				} else {
					var Step = Bound >> 1;
					var Mask = -1 << (Bound >> 1);
					while(Step > 0) {
						if((OldIndex & Mask) == (NewIndex & Mask)) {
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
				bool How;
				if(((New.Index >> (Shift - 1)) & 1) != 0) {
					this.below = Old;
					this.above = New;
					How = true;
				} else {
					this.below = New;
					this.above = Old;
					How = false;
				}
				Int Now, Low;
				if(How ^ this.Shift == Bound) {
					Now = Old; while(Now.Shift > 0) { Now = Now.above; }
					Low = Now.above;
					Now.above = New;
					New.below = Now;
					New.above = Low;
					if(Low != null) Low.below = New;
				} else {
					Now = Old; while(Now.Shift > 0) { Now = Now.below; }
					Low = Now.below;
					New.above = Now;
					Now.below = New;
					New.below = Low;
					if(Low != null) Low.above = New;
				}
				var Parent = Old.owner;
				if(Parent != null) {
					this.owner = Parent;
					if(((New.Index >> Parent.Shift - 1) & 1) != 0) {
						if(Parent.above != Old) throw new System.InvalidOperationException();
						Parent.above = this;
					} else {
						if(Parent.below != Old) throw new System.InvalidOperationException();
						Parent.below = this;
					}
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
			#region #protected# below 
			/// <summary>Нижний элемент или ветка при сдвиге больше нуля)</summary>
			#region #invisible# 
#if TRACE
			[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
#endif
			#endregion
			protected Int below;
			#endregion
			#region #get# Below 
			/// <summary>Возвращает нижний элемент или ветку при сдвиге больше нуля)</summary>
			public Int Below => below;
			#endregion
			#region #protected# above 
			/// <summary>Верхний элемент или ветка при сдвиге больше нуля)</summary>
			#region #invisible# 
#if TRACE
			[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
#endif
			#endregion
			protected Int above;
			#endregion
			#region #get# Above 
			/// <summary>Возвращает верхний элемент или ветку при сдвиге больше нуля)</summary>
			public Int Above => above;
			#endregion
			#region #protected# owner 
			/// <summary>Ветка владеющая этим элементом)</summary>
			#region #invisible# 
#if TRACE
			[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
#endif
			#endregion
			protected Int owner;
			#endregion
			#region #get# Owner 
			/// <summary>Возвращает ветку владеющую этим элементом)</summary>
			public Int Owner => owner;
			#endregion
			#region #property# Root 
			public Int Root {
				#region #through# 
#if TRACE
				[System.Diagnostics.DebuggerStepThrough]
#endif
				#endregion
				get {
					var R = this;
					var P = this.owner;
					while(P != null) {
						R = P;
						P = P.owner;
					}
					return R;
				}
			}
			#endregion
			#region #property# Base 
			public Int Base {
				#region #through# 
#if TRACE
				[System.Diagnostics.DebuggerStepThrough]
#endif
				#endregion
				get {
					var T = this;
					while(T.owner != null) T = T.owner;
					if(T.Shift == Bound) T = T.above;
					while(T.Shift > 0) { T = T.below; }
					return T;
				}
			}
			#endregion
			#region #property# Last 
			public Int Last {
				#region #through# 
#if TRACE
				[System.Diagnostics.DebuggerStepThrough]
#endif
				#endregion
				get {
					var T = this;
					while(T.owner != null) T = T.owner;
					if(T.Shift == Bound) T = T.below;
					while(T.Shift > 0) { T = T.above; }
					return T;
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
			public static bool Add(ref Int Owner, int Index) {
				var O = Owner;
				if(O == null) { Owner = new Int(Index); return true; }
				while(O.owner != null && O.Index != Index >> O.Shift) { O = O.owner; }
				while(O != null) {
					if(O.Shift == 0 && O.Index == Index) {
						return false;
					}
					if(O.Shift == 0 || (O.Shift < Bound && O.Index != Index >> O.Shift)) {
						new Int(O, O = new Int(Index)); Owner = O; return true;
					}
					if(((Index >> O.Shift - 1) & 1) != 0) { O = O.above; } else { O = O.below; }
				}
				return false;
			}
			#endregion
			#region #method# Add(Owner, Value) 
			/// <summary>Добавление элемента в дерево с уникальным индексом и предустановленным значением)</summary>
			/// <param name="Owner">Текущий владелец элемента)</param>
			/// <param name="Value">Устанавливаемое значение)</param>
			/// <returns>Результат операции)</returns>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static bool Add(ref Int Owner, Int Value) {
				var Index = Value.Index;
				var O = Owner;
				if(O == null) { Owner = Value; return true; }
				while(O.owner != null && O.Index != Index >> O.Shift) { O = O.owner; }
				while(O != null) {
					if(O.Shift == 0 && O.Index == Index) {
						return false;
					}
					if(O.Shift == 0 || (O.Shift < Bound && O.Index != Index >> O.Shift)) {
						new Int(O, O = Value); Owner = O; return true;
					}
					if(((Index >> O.Shift - 1) & 1) != 0) { O = O.above; } else { O = O.below; }
				}
				return false;
			}
			#endregion
			#region #method# Put(Owner, Index, Value) 
			/// <summary>Добавление элемента в дерево или установка значения существующего элемента)</summary>
			/// <param name="Owner">Текущий владелец элемента)</param>
			/// <param name="Value">Устанавливаемое значение)</param>
			/// <returns>Результат операции)</returns>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static bool Put(ref Int Owner, Int Value) {
				var Index = Value.Index;
				var O = Owner;
				if(O == null) { Owner = Value; return true; }
				while(O.owner != null && O.Index != Index >> O.Shift) { O = O.owner; }
				while(O != null) {
					if(O.Shift == 0 && O.Index == Index) {
						var R = O.owner;
						if(R != null) {
							if(R.above == O) { R.above = Value; }
							if(R.below == O) { R.below = Value; }
							R = O.below;
							if(R != null) R.above = Value;
							R = O.above;
							if(R != null) R.below = Value;
						}
						Value.above = O.above;
						Value.owner = O.owner;
						Value.below = O.below;
						Owner = O; return true;
					}
					if(O.Shift == 0 || (O.Shift < Bound && O.Index != Index >> O.Shift)) {
						new Int(O, O = Value); Owner = O; return true;
					}
					if(((Index >> O.Shift - 1) & 1) != 0) { O = O.above; } else { O = O.below; }
				}
				return false;
			}
			#endregion
			#region #method# Set(Owner, Value) 
			/// <summary>Установка значения существующего элемента)</summary>
			/// <param name="Owner">Текущий владелец элемента)</param>
			/// <param name="Value">Устанавливаемое значение)</param>
			/// <returns>Результат операции)</returns>
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static bool Set(ref Int Owner, Int Value) {
				var Index = Value.Index;
				var O = Owner;
				if(O == null) { return false; }
				while(O.owner != null && O.Index != Index >> O.Shift) { O = O.owner; }
				while(O != null) {
					if(O.Shift == 0 && O.Index == Index) {
						var R = O.owner;
						if(R != null) {
							if(R.above == O) { R.above = Value; }
							if(R.below == O) { R.below = Value; }
							R = O.below;
							if(R != null) R.above = Value;
							R = O.above;
							if(R != null) R.below = Value;
						}
						Value.above = O.above;
						Value.owner = O.owner;
						Value.below = O.below;
						Owner = O; return true;
					}
					if(O.Shift == 0 || (O.Shift < Bound && O.Index != Index >> O.Shift)) {
						return false;
					}
					if(((Index >> O.Shift - 1) & 1) != 0) { O = O.above; } else { O = O.below; }
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
			public Int Get(int Index) {
				var T = this;
				while(T.owner != null && T.Index != Index >> T.Shift) { T = T.owner; }
				while(T != null) {
					if(T.Shift == 0 && T.Index == Index) return T;
					if(T.Shift == 0 || (T.Shift < Bound && T.Index != Index >> T.Shift)) { return null; }
					if(((Index >> T.Shift - 1) & 1) != 0) { T = T.above; } else { T = T.below; }
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
			public Int GetAbove(int Index, bool Equal = false) {
				var T = this;
				Int A = null;
				while(T.owner != null && T.Index != Index >> T.Shift) { T = T.owner; }
				while(T != null) {
					if(T.Shift == 0 && T.Index == Index) { if(Equal) return T; return T.above; }
					if(T.Shift == 0 || (T.Shift < Bound && T.Index != Index >> T.Shift)) { A = T; break; }
					if(((Index >> T.Shift - 1) & 1) != 0) { T = T.above; } else { T = T.below; }
				}
				while(A != null && A.Shift > 0) {
					if(A.Index <= Index >> A.Shift) { A = A.above; } else { A = A.below; }
				}
				while(A != null && A.Index <= Index) { A = A.above; }
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
			public Int GetBelow(int Index, bool Equal = false) {
				var T = this;
				Int B = null;
				while(T.owner != null && T.Index != Index >> T.Shift) { T = T.owner; }
				while(T != null) {
					if(T.Shift == 0 && T.Index == Index) { if(Equal) return T; return T.below; }
					if(T.Shift == 0 || (T.Shift < Bound && T.Index != Index >> T.Shift)) { B = T; break; }
					if(((Index >> T.Shift - 1) & 1) != 0) { T = T.above; } else { T = T.below; }
				}
				while(B != null && B.Shift > 0) {
					if(B.Index >= Index >> B.Shift) { B = B.below; } else { B = B.above; }
				}
				while(B != null && B.Index >= Index) { B = B.below; }
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
			public Int Cut() {
				if(this.Shift != 0) throw new System.InvalidOperationException();
				var T = this;
				var Index = this.Index;
				Int Other, Owner, Cuted = T.owner;
				if(Cuted != null) {
					var Below = T.below;
					var Above = T.above;
					if(Below != null) Below.above = Above;
					if(Above != null) Above.below = Below;
					T.below = null;
					T.above = null;
					T.owner = null;
					if(((Index >> Cuted.Shift - 1) & 1) != 0) {
						#region #debug# 
#if DEBUG
						if(Cuted.above != T) throw new System.InvalidOperationException();
#endif
						#endregion
						Other = Cuted.below;
					} else {
						#region #debug# 
#if DEBUG
						if(Cuted.below != T) throw new System.InvalidOperationException();
#endif
						#endregion
						Other = Cuted.above;
					}
					Cuted.above = null;
					Cuted.below = null;
					Owner = Cuted.owner;
					if(Owner != null) {
						if(((Index >> Owner.Shift - 1) & 1) != 0) {
#if DEBUG
							if(Owner.above != Cuted) throw new System.InvalidOperationException();
#endif
							Owner.above = Other;
						} else {
#if DEBUG
							if(Owner.below != Cuted) throw new System.InvalidOperationException();
#endif
							Owner.below = Other;
						}
						Other.owner = Owner;
						Cuted.owner = null;
						Cuted = T;
						T = Owner;
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
				if(Shift > 0) { return $"Shift={Shift.ToString(I)} Index={Index.ToString(I)}"; }
				return $"Index={Index.ToString(I)}";
			}
			#endregion
			#region #implicit operator# = 
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static implicit operator Int(int Index) {
				return new Int(Index);
			}
			#endregion
			#region #operator# + 
			#region #through# 
#if TRACE
			[System.Diagnostics.DebuggerStepThrough]
#endif
			#endregion
			public static Int operator +(Int T, int Index) {
				if(T == null) return new Int(Index);
				while(T.owner != null && T.Index != Index >> T.Shift) { T = T.owner; }
				while(T != null) {
					if(T.Shift == 0 && T.Index == Index) return T;
					if(T.Shift == 0 || (T.Shift < Bound && T.Index != Index >> T.Shift)) {
						new Int(T, T = new Int(Index)); break;
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
			public static Int operator +(Int T, Int I) {
				if(T == null) return I;
				var Index = I.Index;
				while(T.owner != null && T.Index != Index >> T.Shift) { T = T.owner; }
				while(T != null) {
					if(T.Shift == 0 && T.Index == Index) return T;
					if(T.Shift == 0 || (T.Shift < Bound && T.Index != Index >> T.Shift)) {
						new Int(T, I); break;
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
			public static Int operator -(Int T, int Index) {
				Int C = T;
				if(T != null) {
					while(T.owner != null && T.Index != Index >> T.Shift) { T = T.owner; }
					while(T != null) {
						if(T.Shift == 0 && T.Index == Index) {
							C = T.above;
							if(C == null) C = T.below;
							T.Cut();
							return C;
						}
						if(T.Shift == 0 || (T.Shift < Bound && T.Index != Index >> T.Shift)) { return C; }
						if(((Index >> T.Shift - 1) & 1) != 0) { T = T.above; } else { T = T.below; }
					}
				}
				return C;
			}
			#endregion
		}
		#endregion
	}
}
