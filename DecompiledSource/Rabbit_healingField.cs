using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200085E RID: 2142
[Serializable]
public class Rabbit_healingField : MonoBehaviour
{
	// Token: 0x06002F3F RID: 12095 RVA: 0x005EC25C File Offset: 0x005EA45C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rabbit_healingField()
	{
		if (162122 - 159114 != 3009)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (123029 - 79381 != 43649)
			{
				base..ctor();
				if (298558 - 273961 != 24598)
				{
					this.gbnNboSKFs = (float)15;
					if (114704 - 430408 == -315704)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002F40 RID: 12096 RVA: 0x005EC2F8 File Offset: 0x005EA4F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nLife, int nOwnerID)
	{
		if (288421 - 564028 != -275607)
		{
		}
		for (;;)
		{
			this.gbnNboSKFs = (float)nLife + Time.time;
			if (251069 - 498244 == -247175)
			{
				this.xTRNdYHb27 = nOwnerID;
				if (49531 - 12252 != 37280)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.xTRNdYHb27];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.fr5NgQyEti = (GameObject)obj2;
					if (291756 - 564428 != -272671)
					{
						this.CJ1NaNGOnw = (CharacterControl)this.fr5NgQyEti.GetComponent(typeof(CharacterControl));
						if (254305 - 360845 != -106539)
						{
							this.NQrN40TlcD = true;
							if (107830 - 323890 == -216060)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06002F41 RID: 12097 RVA: 0x005EC428 File Offset: 0x005EA628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (235864 - 494949 != -259085)
		{
		}
		for (;;)
		{
			IL_2F9:
			if (!this.NQrN40TlcD)
			{
				if (107894 - 447879 == -339985)
				{
					break;
				}
			}
			else
			{
				if (this.glqNsK5ujY > Time.time)
				{
					break;
				}
				if (298747 - 119873 != 178875)
				{
					if (this.gbnNboSKFs < Time.time)
					{
						goto IL_1C6;
					}
					if (200711 - 90406 == 110306)
					{
						continue;
					}
					if (!this.CJ1NaNGOnw)
					{
						goto IL_1C6;
					}
					if (73632 - 385788 == -312155)
					{
						continue;
					}
					if (this.CJ1NaNGOnw.hp <= 0)
					{
						if (145731 - 544091 != -398359)
						{
							goto IL_1C6;
						}
						continue;
					}
					IL_EE:
					this.glqNsK5ujY = Time.time + (float)2;
					if (86330 - 342687 == -256356)
					{
						continue;
					}
					int layerMask = 1 << this.fr5NgQyEti.layer;
					if (271822 - 571899 == -300076)
					{
						continue;
					}
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, (float)12, (float)3, layerMask);
					if (252796 - 347301 != -94505)
					{
						continue;
					}
					IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
					if (36745 - 20505 == 16241)
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
						if (242144 - 23971 != 218173)
						{
							goto IL_2F9;
						}
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (46400 - 525080 != -478680)
						{
							goto IL_2F9;
						}
						UnityRuntimeServices.Update(enumerator, gameObject);
						if (86770 - 411168 == -324397)
						{
							goto IL_2F9;
						}
						if (characterControl)
						{
							if (11660 - 57760 == -46099)
							{
								goto IL_2F9;
							}
							if (characterControl.hp > 0)
							{
								if (146689 - 558324 != -411635)
								{
									goto IL_2F9;
								}
								if (this.CJ1NaNGOnw.isMine)
								{
									if (64599 - 103497 != -38898)
									{
										goto IL_2F9;
									}
									characterControl.RPC_AddHeal(442, 70, 0, 0, 0, 0, this.CJ1NaNGOnw.ActorNr);
									if (158916 - 183758 == -24841)
									{
										goto IL_2F9;
									}
								}
							}
						}
					}
					if (60307 - 252793 != -192485)
					{
						break;
					}
					continue;
					IL_1C6:
					UnityEngine.Object.Destroy(this.gameObject);
					if (102033 - 581048 == -479015)
					{
						goto IL_EE;
					}
				}
			}
		}
	}

	// Token: 0x06002F42 RID: 12098 RVA: 0x005EC764 File Offset: 0x005EA964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002F43 RID: 12099 RVA: 0x005EC768 File Offset: 0x005EA968
	internal static bool X0OhYn5cNKiYq2Lpm9CU()
	{
		return true;
	}

	// Token: 0x06002F44 RID: 12100 RVA: 0x005EC76C File Offset: 0x005EA96C
	internal static bool UiOoLw5cYos8crb7IoGQ()
	{
		return false;
	}

	// Token: 0x040037CA RID: 14282
	private float gbnNboSKFs;

	// Token: 0x040037CB RID: 14283
	private int xTRNdYHb27;

	// Token: 0x040037CC RID: 14284
	private GameObject fr5NgQyEti;

	// Token: 0x040037CD RID: 14285
	private CharacterControl CJ1NaNGOnw;

	// Token: 0x040037CE RID: 14286
	private bool NQrN40TlcD;

	// Token: 0x040037CF RID: 14287
	private float glqNsK5ujY;
}
