using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using cZRJ81ju0AbIsUerIn;

namespace dLmlgre5Dm3f68FOGa
{
	// Token: 0x0200217C RID: 8572
	internal class cpvWdsMyD2EWLTJL7I
	{
		// Token: 0x0600C76B RID: 51051 RVA: 0x0150314C File Offset: 0x0150134C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static cpvWdsMyD2EWLTJL7I()
		{
		}

		// Token: 0x0600C76C RID: 51052 RVA: 0x015031B0 File Offset: 0x015013B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void vFdlINQQT2d0B()
		{
		}

		// Token: 0x0600C76D RID: 51053 RVA: 0x015031B4 File Offset: 0x015013B4
		[cpvWdsMyD2EWLTJL7I.IfxGe0cx0TJa2hmr6D(typeof(cpvWdsMyD2EWLTJL7I/IfxGe0cx0TJa2hmr6D/lXgLo3CSIJiFNKNS9e<object>[]))]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool PK3gR6H56(int A_0)
		{
			if (cpvWdsMyD2EWLTJL7I.pRDnY7LmbLu.Length == 0)
			{
				BinaryReader binaryReader = new BinaryReader(typeof(cpvWdsMyD2EWLTJL7I).Assembly.GetManifestResourceStream("{11111-22222-20001-00000}"));
				binaryReader.BaseStream.Position = 0L;
				byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
				byte[] rgbKey = new cpvWdsMyD2EWLTJL7I().LhLUo4INj();
				byte[] rgbIV = new cpvWdsMyD2EWLTJL7I().o1FuXZF29();
				AesManaged aesManaged = new AesManaged();
				ICryptoTransform transform = aesManaged.CreateDecryptor(rgbKey, rgbIV);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				cpvWdsMyD2EWLTJL7I.pRDnY7LmbLu = memoryStream.ToArray();
				memoryStream.Close();
				cryptoStream.Close();
				binaryReader.Close();
			}
			if (cpvWdsMyD2EWLTJL7I.ERNnYHDAdRj.Length == 0)
			{
				cpvWdsMyD2EWLTJL7I.ERNnYHDAdRj = cpvWdsMyD2EWLTJL7I.F3XyZoicC(cpvWdsMyD2EWLTJL7I.3CNsaNi53(typeof(cpvWdsMyD2EWLTJL7I).Assembly).ToString());
			}
			int num = 0;
			try
			{
				num = BitConverter.ToInt32(new byte[]
				{
					cpvWdsMyD2EWLTJL7I.pRDnY7LmbLu[A_0],
					cpvWdsMyD2EWLTJL7I.pRDnY7LmbLu[A_0 + 1],
					cpvWdsMyD2EWLTJL7I.pRDnY7LmbLu[A_0 + 2],
					cpvWdsMyD2EWLTJL7I.pRDnY7LmbLu[A_0 + 3]
				}, 0);
			}
			catch
			{
			}
			try
			{
				if (cpvWdsMyD2EWLTJL7I.ERNnYHDAdRj[num] == 128)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600C76E RID: 51054 RVA: 0x01503340 File Offset: 0x01501540
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object 3CNsaNi53(object A_0)
		{
			object result;
			try
			{
				result = typeof(cpvWdsMyD2EWLTJL7I).Assembly.Location;
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600C76F RID: 51055 RVA: 0x01503384 File Offset: 0x01501584
		[cpvWdsMyD2EWLTJL7I.IfxGe0cx0TJa2hmr6D(typeof(cpvWdsMyD2EWLTJL7I/IfxGe0cx0TJa2hmr6D/lXgLo3CSIJiFNKNS9e<object>[]))]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string HKtCN6Zi5(string A_0)
		{
			"{11111-22222-50001-00000}".Trim();
			byte[] array = Convert.FromBase64String(A_0);
			return Encoding.Unicode.GetString(array, 0, array.Length);
		}

		// Token: 0x0600C770 RID: 51056 RVA: 0x015033B4 File Offset: 0x015015B4
		[cpvWdsMyD2EWLTJL7I.IfxGe0cx0TJa2hmr6D(typeof(cpvWdsMyD2EWLTJL7I/IfxGe0cx0TJa2hmr6D/lXgLo3CSIJiFNKNS9e<object>[]))]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static byte[] F3XyZoicC(string A_0)
		{
			byte[] array;
			using (FileStream fileStream = new FileStream(A_0, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				int num = 0;
				long length = fileStream.Length;
				int i = (int)length;
				array = new byte[i];
				while (i > 0)
				{
					int num2 = fileStream.Read(array, num, i);
					num += num2;
					i -= num2;
				}
			}
			return array;
		}

		// Token: 0x0600C771 RID: 51057 RVA: 0x01503428 File Offset: 0x01501628
		[cpvWdsMyD2EWLTJL7I.IfxGe0cx0TJa2hmr6D(typeof(cpvWdsMyD2EWLTJL7I/IfxGe0cx0TJa2hmr6D/lXgLo3CSIJiFNKNS9e<object>[]))]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static byte[] Qnjcqj9po(byte[] A_0)
		{
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, new AesManaged
			{
				Key = new byte[]
				{
					123,
					5,
					74,
					12,
					244,
					156,
					221,
					154,
					121,
					221,
					183,
					41,
					121,
					65,
					9,
					43,
					67,
					81,
					23,
					43,
					74,
					63,
					64,
					23,
					95,
					185,
					226,
					244,
					45,
					194,
					211,
					43
				},
				IV = new byte[]
				{
					117,
					254,
					41,
					121,
					65,
					52,
					9,
					43,
					221,
					154,
					12,
					54,
					68,
					241,
					68,
					66
				}
			}.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(A_0, 0, A_0.Length);
			cryptoStream.Close();
			return memoryStream.ToArray();
		}

		// Token: 0x0600C772 RID: 51058 RVA: 0x01503498 File Offset: 0x01501698
		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] cQaNvgJmO()
		{
			string text = "{11111-22222-10001-00001}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600C773 RID: 51059 RVA: 0x015034D8 File Offset: 0x015016D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] R3JLrH37D()
		{
			string text = "{11111-22222-10001-00002}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600C774 RID: 51060 RVA: 0x01503518 File Offset: 0x01501718
		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] o1FuXZF29()
		{
			string text = "{11111-22222-20001-00001}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600C775 RID: 51061 RVA: 0x01503558 File Offset: 0x01501758
		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] LhLUo4INj()
		{
			string text = "{11111-22222-20001-00002}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600C776 RID: 51062 RVA: 0x01503598 File Offset: 0x01501798
		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] 6FF9fSc4q()
		{
			string text = "{11111-22222-30001-00001}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600C777 RID: 51063 RVA: 0x015035D8 File Offset: 0x015017D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] 9iyRaTtgn()
		{
			string text = "{11111-22222-30001-00002}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600C778 RID: 51064 RVA: 0x01503618 File Offset: 0x01501818
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte[] QYHISCCVD()
		{
			string text = "{11111-22222-40001-00001}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600C779 RID: 51065 RVA: 0x01503658 File Offset: 0x01501858
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte[] qDS6I6mH9()
		{
			string text = "{11111-22222-40001-00002}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600C77A RID: 51066 RVA: 0x01503698 File Offset: 0x01501898
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte[] DaXKRgcX5()
		{
			string text = "{11111-22222-50001-00001}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600C77B RID: 51067 RVA: 0x015036D8 File Offset: 0x015018D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal byte[] 1lBa7nr4B()
		{
			string text = "{11111-22222-50001-00002}";
			if (text.Length > 0)
			{
				return new byte[]
				{
					1,
					2
				};
			}
			return new byte[]
			{
				1,
				2
			};
		}

		// Token: 0x0600C77C RID: 51068 RVA: 0x01503718 File Offset: 0x01501918
		[cpvWdsMyD2EWLTJL7I.IfxGe0cx0TJa2hmr6D(typeof(cpvWdsMyD2EWLTJL7I/IfxGe0cx0TJa2hmr6D/lXgLo3CSIJiFNKNS9e<object>[]))]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ce4DmfsmSrOT856tDgfrkMb()
		{
		}

		// Token: 0x0600C77D RID: 51069 RVA: 0x0150371C File Offset: 0x0150191C
		[cpvWdsMyD2EWLTJL7I.IfxGe0cx0TJa2hmr6D(typeof(cpvWdsMyD2EWLTJL7I/IfxGe0cx0TJa2hmr6D/lXgLo3CSIJiFNKNS9e<object>[]))]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string 0Uq4s5MHt(string A_0, string A_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(A_0);
			byte[] array = bytes;
			byte[] key = new byte[]
			{
				82,
				102,
				104,
				110,
				32,
				77,
				24,
				34,
				118,
				181,
				51,
				17,
				18,
				51,
				12,
				109,
				10,
				32,
				77,
				24,
				34,
				158,
				161,
				41,
				97,
				28,
				118,
				181,
				5,
				25,
				1,
				88
			};
			SHA1Managed sha1Managed = new SHA1Managed();
			byte[] iv = sha1Managed.ComputeHash(Encoding.Unicode.GetBytes(A_1));
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, new AesManaged
			{
				Key = key,
				IV = iv
			}.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		// Token: 0x0600C77E RID: 51070 RVA: 0x015037B4 File Offset: 0x015019B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public cpvWdsMyD2EWLTJL7I()
		{
		}

		// Token: 0x0400A954 RID: 43348
		private static byte[] ERNnYHDAdRj = new byte[0];

		// Token: 0x0400A955 RID: 43349
		private static byte[] pRDnY7LmbLu = new byte[0];

		// Token: 0x0400A956 RID: 43350
		private static byte[] zZonYZiGF2j = new byte[0];

		// Token: 0x0400A957 RID: 43351
		private static byte[] TyBnYCAqa2a = new byte[0];

		// Token: 0x0400A958 RID: 43352
		private static IntPtr z3lnYM4PHl8 = IntPtr.Zero;

		// Token: 0x0400A959 RID: 43353
		private static IntPtr n4UnYfY9T5v = IntPtr.Zero;

		// Token: 0x0400A95A RID: 43354
		private static object PvonYLhqc7T = new string[0];

		// Token: 0x0400A95B RID: 43355
		private static int[] nKPnYw3gxqY = new int[0];

		// Token: 0x0200217D RID: 8573
		internal class IfxGe0cx0TJa2hmr6D : Attribute
		{
			// Token: 0x0600C77F RID: 51071 RVA: 0x015037BC File Offset: 0x015019BC
			[cpvWdsMyD2EWLTJL7I.IfxGe0cx0TJa2hmr6D(typeof(cpvWdsMyD2EWLTJL7I/IfxGe0cx0TJa2hmr6D/lXgLo3CSIJiFNKNS9e<object>[]))]
			[MethodImpl(MethodImplOptions.NoInlining)]
			public IfxGe0cx0TJa2hmr6D(object A_1)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				base..ctor();
			}

			// Token: 0x0200217E RID: 8574
			internal class lXgLo3CSIJiFNKNS9e<T>
			{
				// Token: 0x0600C780 RID: 51072 RVA: 0x015037CC File Offset: 0x015019CC
				[MethodImpl(MethodImplOptions.NoInlining)]
				public lXgLo3CSIJiFNKNS9e()
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					base..ctor();
				}

				// Token: 0x0600C781 RID: 51073 RVA: 0x015037DC File Offset: 0x015019DC
				internal static bool kXxEi2tOnyEtF09pvPL0()
				{
					return true;
				}

				// Token: 0x0600C782 RID: 51074 RVA: 0x015037E0 File Offset: 0x015019E0
				internal static bool S7XeKKtO6aVVLSP0ROqF()
				{
					return false;
				}
			}
		}
	}
}
