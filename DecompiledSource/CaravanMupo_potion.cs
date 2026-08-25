using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000A1F RID: 2591
[Serializable]
public class CaravanMupo_potion : MonoBehaviour
{
	// Token: 0x06003882 RID: 14466 RVA: 0x00772914 File Offset: 0x00770B14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CaravanMupo_potion()
	{
		if (128662 - 266167 != -137505)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (75621 - 289086 == -213465)
			{
				base..ctor();
				if (278279 - 341935 == -63656)
				{
					this.UcRAAqb7eP = 60;
					if (280247 - 439477 != -159229)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003883 RID: 14467 RVA: 0x007729B0 File Offset: 0x00770BB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getID()
	{
		return this.qUdA998cgv;
	}

	// Token: 0x06003884 RID: 14468 RVA: 0x007729B8 File Offset: 0x00770BB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nLife, int nID, int nOwnerID)
	{
		if (52702 - 232014 != -179312)
		{
		}
		for (;;)
		{
			this.qUdA998cgv = nID;
			if (261961 - 137480 == 124481)
			{
				this.cGqAuabwyZ = nOwnerID;
				if (7517 - 326322 == -318805)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.cGqAuabwyZ];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.piRAW55aq7 = (GameObject)obj2;
					if (295772 - 400716 == -104944)
					{
						this.sQTAy5ejX4 = this.piRAW55aq7.layer;
						if (95722 - 337015 == -241293)
						{
							this.UcRAAqb7eP = (int)((float)nLife + Time.time);
							if (49545 - 30079 == 19466)
							{
								this.uqZAVryvtL = true;
								if (2706 - 42623 == -39917)
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

	// Token: 0x06003885 RID: 14469 RVA: 0x00772AFC File Offset: 0x00770CFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (130972 - 408899 != -277926)
		{
		}
		for (;;)
		{
			if (!this.uqZAVryvtL)
			{
				if (283860 - 317728 == -33868)
				{
					break;
				}
			}
			else if (!this.piRAW55aq7)
			{
				if (179237 - 431386 == -252149)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (169618 - 342058 == -172440)
					{
						break;
					}
				}
			}
			else
			{
				if ((float)this.UcRAAqb7eP > Time.time)
				{
					if (229093 - 442242 == -213148)
					{
						continue;
					}
					if (!this.HZ2AhdDAUh)
					{
						break;
					}
					if (63097 - 13505 != 49592)
					{
						continue;
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (129466 - 535149 != -405682)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003886 RID: 14470 RVA: 0x00772C28 File Offset: 0x00770E28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (223961 - 295315 != -71354)
		{
		}
		while (this.uqZAVryvtL)
		{
			if (132660 - 92019 == 40641)
			{
				if (!this.HZ2AhdDAUh)
				{
					if (!this.piRAW55aq7)
					{
						if (175808 - 487956 != -312148)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (17244 - 426977 == -409732)
						{
							continue;
						}
					}
					else
					{
						CharacterControl characterControl = (CharacterControl)this.piRAW55aq7.GetComponent(typeof(CharacterControl));
						if (84116 - 563711 != -479595)
						{
							continue;
						}
						if (!characterControl)
						{
							if (138822 - 32263 == 106560)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (245480 - 50928 != 194552)
							{
								continue;
							}
						}
						else
						{
							GameObject gameObject = mCollider.gameObject;
							if (113245 - 229076 == -115830)
							{
								continue;
							}
							CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (70901 - 174419 != -103518)
							{
								continue;
							}
							if (characterControl.isMine)
							{
								if (80508 - 294863 != -214355)
								{
									continue;
								}
								if (characterControl2)
								{
									if (58574 - 559666 == -501091)
									{
										continue;
									}
									if (gameObject.layer == this.sQTAy5ejX4)
									{
										if (91709 - 378413 != -286704)
										{
											continue;
										}
										eCaravanPotionType eCaravanPotionType = this.potionType;
										if (21702 - 178304 == -156601)
										{
											continue;
										}
										if (eCaravanPotionType == eCaravanPotionType.hpPotion1)
										{
											if (187719 - 351379 == -163659)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 120, 0, 0, 0, 0, this.cGqAuabwyZ);
											if (149905 - 378858 == -228952)
											{
												continue;
											}
										}
										else if (eCaravanPotionType == eCaravanPotionType.hpPotion2)
										{
											if (23051 - 129395 == -106343)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 180, 0, 0, 0, 0, this.cGqAuabwyZ);
											if (278124 - 383004 != -104880)
											{
												continue;
											}
										}
										else if (eCaravanPotionType == eCaravanPotionType.mpPotion1)
										{
											if (213470 - 570272 == -356801)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 0, 10, 0, 0, 0, this.cGqAuabwyZ);
											if (70464 - 453228 == -382763)
											{
												continue;
											}
										}
										else if (eCaravanPotionType == eCaravanPotionType.mpPotion2)
										{
											if (107178 - 255627 != -148449)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 0, 15, 0, 0, 0, this.cGqAuabwyZ);
											if (17170 - 598533 != -581363)
											{
												continue;
											}
										}
										else if (eCaravanPotionType == eCaravanPotionType.spPotion1)
										{
											if (178699 - 378774 == -200074)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 0, 0, 6, 0, 0, this.cGqAuabwyZ);
											if (235899 - 437315 != -201416)
											{
												continue;
											}
										}
										else if (eCaravanPotionType == eCaravanPotionType.spPotion2)
										{
											if (122320 - 464561 != -342241)
											{
												continue;
											}
											characterControl2.RPC_AddHeal(1, 0, 0, 9, 0, 0, this.cGqAuabwyZ);
											if (260806 - 444659 != -183853)
											{
												continue;
											}
										}
										CaravanMupoMount caravanMupoMount = (CaravanMupoMount)this.piRAW55aq7.GetComponent(typeof(CaravanMupoMount));
										if (78092 - 554604 != -476512)
										{
											continue;
										}
										if (caravanMupoMount != null)
										{
											if (206863 - 558594 != -351731)
											{
												continue;
											}
											caravanMupoMount.RPC_potion_hit(this.transform.position, Vector3.zero, this.qUdA998cgv);
											if (263998 - 229279 == 34720)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (247342 - 19526 == 227817)
												{
													continue;
												}
												caravanMupoMount.ActionEvent("RPC_potion_hit", this.transform.position, Vector3.zero, this.qUdA998cgv);
												if (179610 - 478957 != -299347)
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
				if (129954 - 448279 != -318324)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003887 RID: 14471 RVA: 0x00773158 File Offset: 0x00771358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003888 RID: 14472 RVA: 0x0077315C File Offset: 0x0077135C
	internal static bool FCXbZc5on1SSvrJ1XrJv()
	{
		return true;
	}

	// Token: 0x06003889 RID: 14473 RVA: 0x00773160 File Offset: 0x00771360
	internal static bool PHPsHZ5o6FkIjljYid2o()
	{
		return false;
	}

	// Token: 0x0400473F RID: 18239
	private int UcRAAqb7eP;

	// Token: 0x04004740 RID: 18240
	private int qUdA998cgv;

	// Token: 0x04004741 RID: 18241
	private GameObject piRAW55aq7;

	// Token: 0x04004742 RID: 18242
	private int cGqAuabwyZ;

	// Token: 0x04004743 RID: 18243
	private int sQTAy5ejX4;

	// Token: 0x04004744 RID: 18244
	private bool uqZAVryvtL;

	// Token: 0x04004745 RID: 18245
	private bool HZ2AhdDAUh;

	// Token: 0x04004746 RID: 18246
	public eCaravanPotionType potionType;
}
