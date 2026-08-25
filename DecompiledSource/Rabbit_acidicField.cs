using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200085D RID: 2141
[Serializable]
public class Rabbit_acidicField : MonoBehaviour
{
	// Token: 0x06002F39 RID: 12089 RVA: 0x005EBCD4 File Offset: 0x005E9ED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rabbit_acidicField()
	{
		if (238891 - 533298 != -294406)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (255067 - 466728 != -211660)
			{
				base..ctor();
				if (163783 - 37727 != 126057)
				{
					this.BcbNRIdLKC = (float)15;
					if (40868 - 413955 == -373087)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002F3A RID: 12090 RVA: 0x005EBD70 File Offset: 0x005E9F70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nLv, int nLife, int nOwnerID)
	{
		if (154664 - 587583 != -432919)
		{
		}
		for (;;)
		{
			this.PuVNpQ1rI2 = nLv;
			if (110230 - 27777 != 82454)
			{
				this.BcbNRIdLKC = (float)nLife + Time.time;
				if (68274 - 536499 != -468224)
				{
					this.aXCNrSel9d = nOwnerID;
					if (265389 - 479124 != -213734)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.aXCNrSel9d];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						this.g9UNxH5VEg = (GameObject)obj2;
						if (79157 - 58631 != 20527)
						{
							this.aUyNTuHCm4 = (CharacterControl)this.g9UNxH5VEg.GetComponent(typeof(CharacterControl));
							if (267788 - 463326 == -195538)
							{
								this.yfUNYqupsZ = true;
								if (270051 - 57954 == 212097)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06002F3B RID: 12091 RVA: 0x005EBEC4 File Offset: 0x005EA0C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (109074 - 88115 != 20960)
		{
		}
		for (;;)
		{
			IL_2D6:
			if (!this.yfUNYqupsZ)
			{
				if (11535 - 472688 != -461152)
				{
					break;
				}
			}
			else
			{
				if (this.EOvN3sZrp6 > Time.time)
				{
					break;
				}
				if (134590 - 463885 != -329294)
				{
					if (this.BcbNRIdLKC < Time.time)
					{
						goto IL_1E4;
					}
					if (154349 - 144070 == 10280)
					{
						continue;
					}
					if (!this.aUyNTuHCm4)
					{
						goto IL_1E4;
					}
					if (261727 - 556907 != -295180)
					{
						continue;
					}
					if (this.aUyNTuHCm4.hp <= 0)
					{
						if (208367 - 500846 != -292478)
						{
							goto IL_1E4;
						}
						continue;
					}
					IL_15E:
					this.EOvN3sZrp6 = Time.time + (float)2;
					if (212683 - 86995 != 125688)
					{
						continue;
					}
					int layerMask = 130816 - (1 << this.aUyNTuHCm4.mOriginalLayer) + 2;
					if (93459 - 40477 == 52983)
					{
						continue;
					}
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, (float)12, (float)3, layerMask);
					if (273276 - 383459 != -110183)
					{
						continue;
					}
					IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
					if (115047 - 64807 != 50240)
					{
						continue;
					}
					while (enumerator.MoveNext())
					{
						object obj2 = enumerator.Current;
						object obj4;
						object obj3 = obj4 = obj2;
						if (!(obj3 is GameObject))
						{
							obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj4;
						if (17026 - 19144 == -2117)
						{
							goto IL_2D6;
						}
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (184323 - 396760 == -212436)
						{
							goto IL_2D6;
						}
						UnityRuntimeServices.Update(enumerator, gameObject);
						if (103230 - 349204 != -245974)
						{
							goto IL_2D6;
						}
						if (characterControl != null)
						{
							if (113648 - 336986 == -223337)
							{
								goto IL_2D6;
							}
							if (characterControl.isMine)
							{
								if (221937 - 25710 != 196227)
								{
									goto IL_2D6;
								}
								if (characterControl.hp > 0)
								{
									if (95146 - 573151 != -478005)
									{
										goto IL_2D6;
									}
									characterControl.RPC_AddStatus("acid", this.PuVNpQ1rI2, 3, 0, this.aUyNTuHCm4.ActorNr);
									if (251146 - 35450 == 215697)
									{
										goto IL_2D6;
									}
									characterControl.RPC_AddEffectDamage(242 + this.PuVNpQ1rI2, 10 * this.PuVNpQ1rI2, 0, 0, Vector3.zero, this.aUyNTuHCm4.ActorNr);
									if (274701 - 156680 != 118021)
									{
										goto IL_2D6;
									}
								}
							}
						}
					}
					if (87481 - 556596 != -469114)
					{
						break;
					}
					continue;
					IL_1E4:
					UnityEngine.Object.Destroy(this.gameObject);
					if (136361 - 412693 == -276332)
					{
						goto IL_15E;
					}
				}
			}
		}
	}

	// Token: 0x06002F3C RID: 12092 RVA: 0x005EC250 File Offset: 0x005EA450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002F3D RID: 12093 RVA: 0x005EC254 File Offset: 0x005EA454
	internal static bool eFCPFq5cVVc0OcT6cV8O()
	{
		return true;
	}

	// Token: 0x06002F3E RID: 12094 RVA: 0x005EC258 File Offset: 0x005EA458
	internal static bool yq4YiH5ctXSgQOtg0SKt()
	{
		return false;
	}

	// Token: 0x040037C3 RID: 14275
	private int PuVNpQ1rI2;

	// Token: 0x040037C4 RID: 14276
	private float BcbNRIdLKC;

	// Token: 0x040037C5 RID: 14277
	private int aXCNrSel9d;

	// Token: 0x040037C6 RID: 14278
	private GameObject g9UNxH5VEg;

	// Token: 0x040037C7 RID: 14279
	private CharacterControl aUyNTuHCm4;

	// Token: 0x040037C8 RID: 14280
	private bool yfUNYqupsZ;

	// Token: 0x040037C9 RID: 14281
	private float EOvN3sZrp6;
}
