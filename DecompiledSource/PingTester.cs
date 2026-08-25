using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02002098 RID: 8344
[Serializable]
public class PingTester : MonoBehaviour
{
	// Token: 0x0600C346 RID: 49990 RVA: 0x0147576C File Offset: 0x0147396C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PingTester()
	{
		if (200056 - 71994 != 128063)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (8031 - 49476 == -41445)
			{
				base..ctor();
				if (214882 - 236714 == -21832)
				{
					this.r2DnTZ0etdc = "83.221.146.11";
					if (167893 - 505260 == -337367)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C347 RID: 49991 RVA: 0x01475808 File Offset: 0x01473A08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (188662 - 184717 != 3945)
		{
		}
		for (;;)
		{
			if (Environment.OSVersion.Platform == PlatformID.Unix)
			{
				if (30471 - 199236 == -168765)
				{
					this.LxCnTCaHAQi = this.GetComponent("PingCustom");
					if (29140 - 14978 == 14162)
					{
						break;
					}
				}
			}
			else
			{
				this.LxCnTCaHAQi = this.GetComponent("PingWin");
				if (289553 - 4455 != 285099)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600C348 RID: 49992 RVA: 0x014758C8 File Offset: 0x01473AC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (40713 - 325276 != -284562)
		{
		}
		for (;;)
		{
			this.r2DnTZ0etdc = GUILayout.TextField(this.r2DnTZ0etdc, new GUILayoutOption[]
			{
				GUILayout.Width((float)100)
			});
			if (215560 - 237159 == -21599)
			{
				if (GUILayout.Button("Ping", new GUILayoutOption[0]))
				{
					if (188 - 131527 != -131339)
					{
						continue;
					}
					this.paDnTMk182x = RuntimeServices.UnboxInt32(UnityRuntimeServices.Invoke(this.LxCnTCaHAQi, "Ping", new object[]
					{
						this.r2DnTZ0etdc,
						1000
					}, typeof(MonoBehaviour)));
					if (68923 - 267996 != -199073)
					{
						continue;
					}
					if (this.paDnTMk182x >= 0)
					{
						if (268884 - 213284 != 55600)
						{
							continue;
						}
						if (this.paDnTMk182x <= 1500)
						{
							goto IL_1F4;
						}
						if (23122 - 226874 != -203752)
						{
							continue;
						}
					}
					this.paDnTMk182x = RuntimeServices.UnboxInt32(UnityRuntimeServices.Invoke(this.LxCnTCaHAQi, "Ping", new object[]
					{
						this.r2DnTZ0etdc,
						1000
					}, typeof(MonoBehaviour)));
					if (187828 - 248915 == -61086)
					{
						continue;
					}
				}
				IL_1F4:
				if (this.paDnTMk182x == -1)
				{
					if (181182 - 16160 != 165023)
					{
						GUILayout.Label("Ping NOT supported in current player", new GUILayoutOption[0]);
						if (108361 - 57343 == 51018)
						{
							break;
						}
					}
				}
				else
				{
					GUILayout.Label(this.paDnTMk182x + " ms", new GUILayoutOption[0]);
					if (106176 - 434101 != -327924)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C349 RID: 49993 RVA: 0x01475B00 File Offset: 0x01473D00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C34A RID: 49994 RVA: 0x01475B04 File Offset: 0x01473D04
	internal static bool V1pxnitoTtqWmsBb2x6k()
	{
		return true;
	}

	// Token: 0x0600C34B RID: 49995 RVA: 0x01475B08 File Offset: 0x01473D08
	internal static bool EpBqEdto3LdnnOQmvp1U()
	{
		return false;
	}

	// Token: 0x0400A58E RID: 42382
	private string r2DnTZ0etdc;

	// Token: 0x0400A58F RID: 42383
	private object LxCnTCaHAQi;

	// Token: 0x0400A590 RID: 42384
	private int paDnTMk182x;
}
