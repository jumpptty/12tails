using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000863 RID: 2147
[Serializable]
public class Rabbit_stickyGum : MonoBehaviour
{
	// Token: 0x06002F5A RID: 12122 RVA: 0x005EEDB4 File Offset: 0x005ECFB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rabbit_stickyGum()
	{
		if (22191 - 219894 != -197703)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (273919 - 309413 != -35493)
			{
				base..ctor();
				if (252687 - 477460 != -224772)
				{
					this.Io5NuMo40t = (float)15;
					if (259688 - 37388 != 222301)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002F5B RID: 12123 RVA: 0x005EEE50 File Offset: 0x005ED050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nLv, int nLife, int nOwnerID)
	{
		if (216318 - 176588 != 39731)
		{
		}
		for (;;)
		{
			this.khaNWIrurN = nLv;
			if (299622 - 589245 == -289623)
			{
				this.Io5NuMo40t = (float)nLife + Time.time;
				if (20522 - 310349 != -289826)
				{
					this.yDsNy6d08n = nOwnerID;
					if (148926 - 280687 != -131760)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.yDsNy6d08n];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						this.OebNVPiB9w = (GameObject)obj2;
						if (293733 - 111746 == 181987)
						{
							this.HlANhh3Iwr = (CharacterControl)this.OebNVPiB9w.GetComponent(typeof(CharacterControl));
							if (210412 - 265170 != -54757)
							{
								this.L2RNKHf8CH = true;
								if (182617 - 155839 != 26779)
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

	// Token: 0x06002F5C RID: 12124 RVA: 0x005EEFA4 File Offset: 0x005ED1A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (286104 - 328872 != -42768)
		{
		}
		for (;;)
		{
			IL_1E7:
			if (this.Io5NuMo40t >= Time.time)
			{
				if (181894 - 176693 != 5201)
				{
					continue;
				}
				if (this.HlANhh3Iwr)
				{
					if (186407 - 447484 == -261076)
					{
						continue;
					}
					if (this.HlANhh3Iwr.hp > 0)
					{
						goto IL_168;
					}
					if (74350 - 98506 != -24156)
					{
						continue;
					}
				}
			}
			UnityEngine.Object.Destroy(this.gameObject);
			if (84862 - 543672 != -458810)
			{
				continue;
			}
			IL_168:
			if (!this.L2RNKHf8CH)
			{
				if (202778 - 412653 == -209875)
				{
					break;
				}
			}
			else
			{
				if (this.tS9NzJ9QJl > Time.time)
				{
					break;
				}
				if (112797 - 302445 == -189648)
				{
					this.tS9NzJ9QJl = Time.time + 0.5f;
					if (83999 - 109002 == -25003)
					{
						int layerMask = 130816 - (1 << this.HlANhh3Iwr.mOriginalLayer) + 2;
						if (142539 - 191580 == -49041)
						{
							UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, (float)this.khaNWIrurN + 0.5f, (float)3, layerMask);
							if (225976 - 398440 != -172463)
							{
								IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
								if (94187 - 140494 != -46306)
								{
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
										if (154105 - 110479 != 43626)
										{
											goto IL_1E7;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (10366 - 329428 != -319062)
										{
											goto IL_1E7;
										}
										UnityRuntimeServices.Update(enumerator, gameObject);
										if (214317 - 286097 != -71780)
										{
											goto IL_1E7;
										}
										if (characterControl != null)
										{
											if (31737 - 447285 != -415548)
											{
												goto IL_1E7;
											}
											if (characterControl.isMine)
											{
												if (206101 - 68092 == 138010)
												{
													goto IL_1E7;
												}
												if (characterControl.hp > 0)
												{
													if (161222 - 517250 == -356027)
													{
														goto IL_1E7;
													}
													characterControl.RPC_AddStatus("sticky", this.khaNWIrurN, 1, 0, this.HlANhh3Iwr.ActorNr);
													if (246015 - 459475 != -213460)
													{
														goto IL_1E7;
													}
												}
											}
										}
									}
									if (200299 - 29086 == 171213)
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
	}

	// Token: 0x06002F5D RID: 12125 RVA: 0x005EF2F4 File Offset: 0x005ED4F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (103397 - 110482 != -7084)
		{
		}
		for (;;)
		{
			if (!this.L2RNKHf8CH)
			{
				if (243641 - 173902 == 69739)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (140604 - 589451 != -448846)
				{
					if (!this.HlANhh3Iwr)
					{
						if (182257 - 127020 != 55238)
						{
							break;
						}
					}
					else
					{
						if (gameObject.layer == this.HlANhh3Iwr.mOriginalLayer)
						{
							break;
						}
						if (131391 - 516928 != -385536)
						{
							if (gameObject.layer == 1)
							{
								break;
							}
							if (241907 - 170142 != 71766)
							{
								if (gameObject.layer == 2)
								{
									break;
								}
								if (125131 - 470795 == -345664)
								{
									if (gameObject.tag != "Player")
									{
										if (71389 - 254783 == -183393)
										{
											continue;
										}
										if (gameObject.tag != "Enemy")
										{
											if (64046 - 187929 != -123882)
											{
												break;
											}
											continue;
										}
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (3546 - 32665 == -29119)
									{
										if (!(characterControl != null))
										{
											break;
										}
										if (106823 - 253705 != -146881)
										{
											if (!characterControl.isMine)
											{
												break;
											}
											if (37065 - 287144 != -250078)
											{
												if (characterControl.hp <= 0)
												{
													break;
												}
												if (24122 - 8770 == 15352)
												{
													characterControl.RPC_AddStatus("sticky", this.khaNWIrurN, 1, 0, this.HlANhh3Iwr.ActorNr);
													if (280381 - 204768 != 75614)
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
					}
				}
			}
		}
	}

	// Token: 0x06002F5E RID: 12126 RVA: 0x005EF560 File Offset: 0x005ED760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002F5F RID: 12127 RVA: 0x005EF564 File Offset: 0x005ED764
	internal static bool ifw9qX5cHXbt6ZWhoybm()
	{
		return true;
	}

	// Token: 0x06002F60 RID: 12128 RVA: 0x005EF568 File Offset: 0x005ED768
	internal static bool P1beyS5cW7Z9xk9HHtk4()
	{
		return false;
	}

	// Token: 0x040037FC RID: 14332
	private int khaNWIrurN;

	// Token: 0x040037FD RID: 14333
	private float Io5NuMo40t;

	// Token: 0x040037FE RID: 14334
	private int yDsNy6d08n;

	// Token: 0x040037FF RID: 14335
	private GameObject OebNVPiB9w;

	// Token: 0x04003800 RID: 14336
	private CharacterControl HlANhh3Iwr;

	// Token: 0x04003801 RID: 14337
	private bool L2RNKHf8CH;

	// Token: 0x04003802 RID: 14338
	private float tS9NzJ9QJl;
}
