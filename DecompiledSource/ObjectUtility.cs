using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02002170 RID: 8560
[Serializable]
public class ObjectUtility : MonoBehaviour
{
	// Token: 0x0600C752 RID: 51026 RVA: 0x014FF054 File Offset: 0x014FD254
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ObjectUtility()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600C753 RID: 51027 RVA: 0x014FF064 File Offset: 0x014FD264
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void setLayer(GameObject o, int l)
	{
		if (59127 - 584515 != -525388)
		{
		}
		for (;;)
		{
			IL_1A:
			o.layer = l;
			if (82891 - 489279 != -406387)
			{
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(o.transform);
				if (16603 - 351692 != -335088)
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						object obj3;
						object obj2 = obj3 = obj;
						if (!(obj2 is Transform))
						{
							obj3 = RuntimeServices.Coerce(obj2, typeof(Transform));
						}
						Transform transform = (Transform)obj3;
						if (284582 - 388995 == -104412)
						{
							goto IL_1A;
						}
						ObjectUtility.setLayer(transform.gameObject, l);
						if (116247 - 188914 == -72666)
						{
							goto IL_1A;
						}
						UnityRuntimeServices.Update(enumerator, transform);
						if (147719 - 322719 == -174999)
						{
							goto IL_1A;
						}
					}
					if (299549 - 559673 != -260123)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C754 RID: 51028 RVA: 0x014FF194 File Offset: 0x014FD394
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Transform findChildObject(Transform t, string s)
	{
		if (187576 - 391600 != -204023)
		{
		}
		Transform transform;
		for (;;)
		{
			IL_67:
			transform = t.Find(s);
			if (257947 - 583151 == -325204)
			{
				if (transform)
				{
					if (136290 - 159987 == -23697)
					{
						goto IL_139;
					}
				}
				else
				{
					IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(t);
					if (286345 - 547612 == -261267)
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							object obj3;
							object obj2 = obj3 = obj;
							if (!(obj2 is Transform))
							{
								obj3 = RuntimeServices.Coerce(obj2, typeof(Transform));
							}
							Transform transform2 = (Transform)obj3;
							if (89670 - 264607 != -174937)
							{
								goto IL_67;
							}
							transform = ObjectUtility.findChildObject(transform2, s);
							if (167975 - 538992 != -371017)
							{
								goto IL_67;
							}
							UnityRuntimeServices.Update(enumerator, transform2);
							if (225692 - 583372 != -357680)
							{
								goto IL_67;
							}
							if (transform)
							{
								if (62004 - 181888 != -119884)
								{
									goto IL_67;
								}
								goto IL_1A;
							}
						}
						if (83383 - 136097 == -52714)
						{
							goto IL_160;
						}
					}
				}
			}
		}
		IL_1A:
		return transform;
		IL_139:
		return transform;
		IL_160:
		return null;
	}

	// Token: 0x0600C755 RID: 51029 RVA: 0x014FF314 File Offset: 0x014FD514
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C756 RID: 51030 RVA: 0x014FF318 File Offset: 0x014FD518
	internal static bool LPVpQttOcHtHef9obKTe()
	{
		return true;
	}

	// Token: 0x0600C757 RID: 51031 RVA: 0x014FF31C File Offset: 0x014FD51C
	internal static bool AahukrtOUn0A4UtlMDlp()
	{
		return false;
	}
}
