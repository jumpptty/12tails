using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000861 RID: 2145
[Serializable]
public class Rabbit_potion : MonoBehaviour
{
	// Token: 0x06002F4B RID: 12107 RVA: 0x005ED098 File Offset: 0x005EB298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rabbit_potion()
	{
		if (107270 - 102765 != 4506)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (282919 - 539432 != -256512)
			{
				base..ctor();
				if (57967 - 390598 != -332630)
				{
					this.AEGNULYSjg = 60;
					if (39802 - 401164 != -361361)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002F4C RID: 12108 RVA: 0x005ED134 File Offset: 0x005EB334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getID()
	{
		return this.GArNNbXrGY;
	}

	// Token: 0x06002F4D RID: 12109 RVA: 0x005ED13C File Offset: 0x005EB33C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nLife, int nID, int nOwnerID)
	{
		if (111593 - 338139 != -226545)
		{
		}
		for (;;)
		{
			this.GArNNbXrGY = nID;
			if (64971 - 432942 == -367971)
			{
				this.gbbNPxW0WH = nOwnerID;
				if (239313 - 271344 != -32030)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.gbbNPxW0WH];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.XUZNE3aBGK = (GameObject)obj2;
					if (286887 - 336540 != -49652)
					{
						this.XHfNSc7jfr = this.XUZNE3aBGK.layer;
						if (235175 - 153131 == 82044)
						{
							this.AEGNULYSjg = (int)((float)nLife + Time.time);
							if (222670 - 191 != 222480)
							{
								this.irLNBqOb8i = true;
								if (68483 - 369123 == -300640)
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

	// Token: 0x06002F4E RID: 12110 RVA: 0x005ED280 File Offset: 0x005EB480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (138464 - 17911 != 120553)
		{
		}
		for (;;)
		{
			if (!this.irLNBqOb8i)
			{
				if (18158 - 165819 == -147661)
				{
					break;
				}
			}
			else if (!this.XUZNE3aBGK)
			{
				if (270005 - 73942 != 196064)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (175527 - 183469 == -7942)
					{
						break;
					}
				}
			}
			else
			{
				if ((float)this.AEGNULYSjg > Time.time)
				{
					if (155473 - 195553 == -40079)
					{
						continue;
					}
					if (!this.fRiN0Squkp)
					{
						break;
					}
					if (255819 - 8226 == 247594)
					{
						continue;
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (35265 - 375728 != -340462)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06002F4F RID: 12111 RVA: 0x005ED3AC File Offset: 0x005EB5AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (185688 - 310121 != -124432)
		{
		}
		while (this.irLNBqOb8i)
		{
			if (288973 - 468965 != -179991)
			{
				if (!this.fRiN0Squkp)
				{
					if (!this.XUZNE3aBGK)
					{
						if (293470 - 16357 != 277113)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (92139 - 509524 == -417384)
						{
							continue;
						}
					}
					else
					{
						CharacterControl characterControl = (CharacterControl)this.XUZNE3aBGK.GetComponent(typeof(CharacterControl));
						if (116349 - 106380 == 9970)
						{
							continue;
						}
						if (!characterControl)
						{
							if (9206 - 81431 != -72225)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (82422 - 360339 == -277916)
							{
								continue;
							}
						}
						else
						{
							GameObject gameObject = mCollider.gameObject;
							if (76162 - 407495 == -331332)
							{
								continue;
							}
							CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (87233 - 536616 != -449383)
							{
								continue;
							}
							if (characterControl.isMine)
							{
								if (270128 - 110489 != 159639)
								{
									continue;
								}
								if (characterControl2)
								{
									if (175967 - 234011 == -58043)
									{
										continue;
									}
									if (gameObject.layer == this.XHfNSc7jfr)
									{
										if (113176 - 421354 == -308177)
										{
											continue;
										}
										int num = 0;
										if (248904 - 94798 == 154107)
										{
											continue;
										}
										int num2 = 0;
										if (231552 - 146259 != 85293)
										{
											continue;
										}
										if (characterControl.hasSkill(231))
										{
											if (190850 - 519214 != -328364)
											{
												continue;
											}
											num = 1;
											if (192363 - 506503 != -314140)
											{
												continue;
											}
										}
										if (characterControl.hasSkill(232))
										{
											if (153556 - 50120 == 103437)
											{
												continue;
											}
											num = 2;
											if (16814 - 477643 == -460828)
											{
												continue;
											}
										}
										if (characterControl.hasSkill(233))
										{
											if (69065 - 596001 != -526936)
											{
												continue;
											}
											num = 3;
											if (220707 - 593278 == -372570)
											{
												continue;
											}
										}
										if (characterControl.hasSkill(234))
										{
											if (116144 - 255844 == -139699)
											{
												continue;
											}
											num = 4;
											if (149118 - 590703 != -441585)
											{
												continue;
											}
										}
										if (characterControl.hasSkill(412))
										{
											if (145148 - 599961 != -454813)
											{
												continue;
											}
											num2 = 1;
											if (80827 - 521108 == -440280)
											{
												continue;
											}
										}
										eRabbitPotionType eRabbitPotionType = this.potionType;
										if (274670 - 241866 != 32804)
										{
											continue;
										}
										if (eRabbitPotionType == eRabbitPotionType.hpPot1)
										{
											if (59290 - 482377 == -423086)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 20 + Mathf.FloorToInt(0.3f * (float)num2 * (float)characterControl.Lv), 0, 0, 0, 0, this.gbbNPxW0WH);
											if (117984 - 354156 == -236171)
											{
												continue;
											}
										}
										else if (eRabbitPotionType == eRabbitPotionType.hpPot2)
										{
											if (231238 - 491926 != -260688)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 40 + Mathf.FloorToInt(0.3f * (float)num2 * (float)characterControl.Lv), 0, 0, 0, 0, this.gbbNPxW0WH);
											if (110556 - 34889 != 75667)
											{
												continue;
											}
										}
										else if (eRabbitPotionType == eRabbitPotionType.hpPot3)
										{
											if (286858 - 40130 != 246728)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 60 + Mathf.FloorToInt(0.3f * (float)num2 * (float)characterControl.Lv), 0, 0, 0, 0, this.gbbNPxW0WH);
											if (3088 - 445868 == -442779)
											{
												continue;
											}
										}
										else if (eRabbitPotionType == eRabbitPotionType.hpPot4)
										{
											if (88537 - 217733 == -129195)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 80 + Mathf.FloorToInt(0.3f * (float)num2 * (float)characterControl.Lv), 0, 0, 0, 0, this.gbbNPxW0WH);
											if (35292 - 147085 == -111792)
											{
												continue;
											}
										}
										else if (eRabbitPotionType == eRabbitPotionType.spPot1)
										{
											if (53307 - 520613 == -467305)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 0, 0, 4, 0, 0, this.gbbNPxW0WH);
											if (239695 - 24546 != 215149)
											{
												continue;
											}
										}
										else if (eRabbitPotionType == eRabbitPotionType.spPot2)
										{
											if (66178 - 386857 != -320679)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 0, 0, 8, 0, 0, this.gbbNPxW0WH);
											if (168664 - 262668 == -94003)
											{
												continue;
											}
										}
										else if (eRabbitPotionType == eRabbitPotionType.spPot3)
										{
											if (83038 - 382569 != -299531)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 0, 0, 12, 0, 0, this.gbbNPxW0WH);
											if (124999 - 567932 == -442932)
											{
												continue;
											}
										}
										else if (eRabbitPotionType == eRabbitPotionType.rdPot1)
										{
											if (40985 - 69159 != -28174)
											{
												continue;
											}
											characterControl2.RPC_AddStatus("invisible", Mathf.Clamp(num, 1, 4), characterControl.chaAdjust(4 + 2 * num), 0, this.gbbNPxW0WH);
											if (195590 - 185142 == 10449)
											{
												continue;
											}
										}
										else if (eRabbitPotionType == eRabbitPotionType.rdPot2)
										{
											if (56804 - 404997 == -348192)
											{
												continue;
											}
											characterControl2.RPC_AddStatus("reduce", Mathf.Clamp(num, 1, 4), characterControl.chaAdjust(4 + 2 * num), 0, this.gbbNPxW0WH);
											if (210275 - 176295 == 33981)
											{
												continue;
											}
										}
										else if (eRabbitPotionType == eRabbitPotionType.rdPot3)
										{
											if (245522 - 60437 != 185085)
											{
												continue;
											}
											characterControl2.RPC_AddStatus("enlarge", Mathf.Clamp(num, 1, 4), characterControl.chaAdjust(4 + 2 * num), 0, this.gbbNPxW0WH);
											if (173485 - 221372 != -47887)
											{
												continue;
											}
										}
										else if (eRabbitPotionType == eRabbitPotionType.rdPot4)
										{
											if (223830 - 284865 == -61034)
											{
												continue;
											}
											characterControl2.RPC_AddStatus("poison", Mathf.Clamp(num, 1, 4), characterControl.chaAdjust(4 + 2 * num), 0, this.gbbNPxW0WH);
											if (67430 - 307767 != -240337)
											{
												continue;
											}
										}
										else if (eRabbitPotionType == eRabbitPotionType.rdPot5)
										{
											if (80106 - 109642 != -29536)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 0, Mathf.Clamp(10 * num, 10, 40), 0, 0, 0, this.gbbNPxW0WH);
											if (199479 - 119809 == 79671)
											{
												continue;
											}
										}
										else if (eRabbitPotionType == eRabbitPotionType.rdPot6)
										{
											if (230726 - 392904 == -162177)
											{
												continue;
											}
											characterControl2.RPC_AddStatus("miracleDrop", Mathf.Clamp(num, 1, 4), characterControl.chaAdjust(4 + 2 * num), 50, this.gbbNPxW0WH);
											if (2158 - 516778 == -514619)
											{
												continue;
											}
										}
										Rabbit rabbit = (Rabbit)this.XUZNE3aBGK.GetComponent(typeof(Rabbit));
										if (209499 - 20617 == 188883)
										{
											continue;
										}
										if (rabbit != null)
										{
											if (165685 - 39457 == 126229)
											{
												continue;
											}
											rabbit.RPC_potion_hit(this.transform.position, Vector3.zero, this.GArNNbXrGY);
											if (102814 - 484934 == -382119)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (200423 - 65826 == 134598)
												{
													continue;
												}
												rabbit.ActionEvent("RPC_potion_hit", this.transform.position, Vector3.zero, this.GArNNbXrGY);
												if (59733 - 378625 != -318892)
												{
													continue;
												}
											}
										}
									}
								}
							}
						}
					}
					return;
				}
				if (187846 - 558285 == -370439)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06002F50 RID: 12112 RVA: 0x005EDD88 File Offset: 0x005EBF88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002F51 RID: 12113 RVA: 0x005EDD8C File Offset: 0x005EBF8C
	internal static bool tbqNpl5cXiLGsAWXAgcQ()
	{
		return true;
	}

	// Token: 0x06002F52 RID: 12114 RVA: 0x005EDD90 File Offset: 0x005EBF90
	internal static bool rRubKL5cQy1kTaHSOhLk()
	{
		return false;
	}

	// Token: 0x040037E6 RID: 14310
	private int AEGNULYSjg;

	// Token: 0x040037E7 RID: 14311
	private int GArNNbXrGY;

	// Token: 0x040037E8 RID: 14312
	private GameObject XUZNE3aBGK;

	// Token: 0x040037E9 RID: 14313
	private int gbbNPxW0WH;

	// Token: 0x040037EA RID: 14314
	private int XHfNSc7jfr;

	// Token: 0x040037EB RID: 14315
	private bool irLNBqOb8i;

	// Token: 0x040037EC RID: 14316
	private bool fRiN0Squkp;

	// Token: 0x040037ED RID: 14317
	public eRabbitPotionType potionType;
}
