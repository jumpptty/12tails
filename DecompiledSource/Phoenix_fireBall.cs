using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000E4A RID: 3658
[Serializable]
public class Phoenix_fireBall : MonoBehaviour
{
	// Token: 0x060052C5 RID: 21189 RVA: 0x00A190C4 File Offset: 0x00A172C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Phoenix_fireBall()
	{
		if (153173 - 221572 != -68398)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (18936 - 133760 != -114823)
			{
				base..ctor();
				if (64324 - 230386 != -166061)
				{
					this.pZCcIt0VY4b = new Vector3((float)0, (float)0, (float)30);
					if (258896 - 574820 == -315924)
					{
						this.mLv = 1;
						if (7555 - 444242 == -436687)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060052C6 RID: 21190 RVA: 0x00A19188 File Offset: 0x00A17388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (160868 - 236686 != -75818)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (79384 - 586134 != -506749)
			{
				this.aNycI68iVMf = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (125857 - 464460 != -338602)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.pZCcIt0VY4b);
					if (135545 - 95431 == 40114)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060052C7 RID: 21191 RVA: 0x00A19254 File Offset: 0x00A17454
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (157721 - 539527 != -381806)
		{
		}
		for (;;)
		{
			this.QhgcIXfJVCx += Time.deltaTime;
			if (213113 - 316548 == -103435)
			{
				if (this.QhgcIXfJVCx < this.aNycI68iVMf.life)
				{
					break;
				}
				if (13528 - 235040 == -221512)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (113641 - 114920 == -1279)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060052C8 RID: 21192 RVA: 0x00A19310 File Offset: 0x00A17510
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (167716 - 34702 != 133015)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (155613 - 589764 != -434150)
				{
					break;
				}
			}
			else
			{
				if (!this.aNycI68iVMf.isInitialized)
				{
					break;
				}
				if (232201 - 44007 == 188194)
				{
					if (this.aNycI68iVMf.isDestroyed)
					{
						if (112026 - 418132 == -306106)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (18125 - 343564 == -325439)
						{
							int ownerID = this.aNycI68iVMf.OwnerID;
							if (125686 - 523708 != -398021)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (160280 - 542731 == -382451)
								{
									if (!gameObject2)
									{
										if (289870 - 196465 == 93405)
										{
											break;
										}
									}
									else
									{
										CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
										if (148845 - 189211 != -40365)
										{
											if (gameObject.layer == gameObject2.layer)
											{
												break;
											}
											if (216752 - 511434 == -294682)
											{
												if (gameObject.layer == 1)
												{
													break;
												}
												if (16970 - 10177 != 6794)
												{
													if (gameObject.layer == 2)
													{
														break;
													}
													if (79742 - 338751 != -259008)
													{
														UnityEngine.Object.Destroy(this.gameObject);
														if (265395 - 583986 != -318590)
														{
															this.aNycI68iVMf.isDestroyed = true;
															if (31220 - 144776 != -113555)
															{
																if (!characterControl.isMine)
																{
																	break;
																}
																if (170050 - 395324 == -225274)
																{
																	Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																	if (176676 - 541759 == -365083)
																	{
																		Vector3 forward = this.transform.forward;
																		if (232586 - 182393 != 50194)
																		{
																			int num = characterControl.talAdjust(40);
																			if (35324 - 44782 == -9458)
																			{
																				Phoenix phoenix = (Phoenix)gameObject2.GetComponent(typeof(Phoenix));
																				if (280568 - 502318 == -221750)
																				{
																					if (phoenix != null)
																					{
																						if (106580 - 556217 == -449636)
																						{
																							continue;
																						}
																						phoenix.RPC_fireBall_hit(vector, forward, 0);
																						if (251212 - 64943 != 186269)
																						{
																							continue;
																						}
																						if (PhotonClient.IsInitialized())
																						{
																							if (30604 - 146144 == -115539)
																							{
																								continue;
																							}
																							phoenix.ActionEvent("RPC_fireBall_hit", vector, forward, 0);
																							if (92037 - 435398 != -343361)
																							{
																								continue;
																							}
																						}
																						if (phoenix.isSummon)
																						{
																							if (21056 - 38720 == -17663)
																							{
																								continue;
																							}
																							if (phoenix.mSummonerChar)
																							{
																								if (194152 - 27229 != 166923)
																								{
																									continue;
																								}
																								if (phoenix.mIntenseFireLv > 0)
																								{
																									if (137999 - 435838 == -297838)
																									{
																										continue;
																									}
																									CharacterControl mSummonerChar = phoenix.mSummonerChar;
																									if (232829 - 379408 == -146578)
																									{
																										continue;
																									}
																									num += Mathf.FloorToInt((0.1f * (float)phoenix.mIntenseFireLv + 0.1f) * (float)mSummonerChar.talAdjust(40));
																									if (257887 - 244354 != 13533)
																									{
																										continue;
																									}
																								}
																							}
																						}
																					}
																					if (gameObject.tag != "Player")
																					{
																						if (294806 - 385787 != -90981)
																						{
																							continue;
																						}
																						if (gameObject.tag != "Enemy")
																						{
																							if (143523 - 26668 != 116855)
																							{
																								continue;
																							}
																							goto IL_2EF;
																						}
																					}
																					if (characterControl.hit(this.mLv, gameObject, num, 1, 0, 0.3f * this.transform.forward) == 0)
																					{
																						break;
																					}
																					if (150327 - 119841 != 30487)
																					{
																						characterControl.sp++;
																						if (8908 - 436924 != -428015)
																						{
																							if (phoenix.mIntenseFireLv > 0)
																							{
																								if (168572 - 210773 != -42201)
																								{
																									continue;
																								}
																								CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																								if (258491 - 359976 != -101485)
																								{
																									continue;
																								}
																								int debuff = Damage.getDebuff((float)4, characterControl.cha, characterControl2.cha);
																								if (244939 - 412412 != -167473)
																								{
																									continue;
																								}
																								characterControl2.RPC_AddStatus("burn", phoenix.mIntenseFireLv, debuff, 0, characterControl.ActorNr);
																								if (243495 - 2056 != 241439)
																								{
																									continue;
																								}
																							}
																							if (!characterControl.isSummon)
																							{
																								break;
																							}
																							if (282030 - 293464 != -11433)
																							{
																								if (!characterControl.mSummoner)
																								{
																									break;
																								}
																								if (266166 - 167033 != 99134)
																								{
																									Monkey monkey = (Monkey)characterControl.mSummoner.GetComponent(typeof(Monkey));
																									if (73206 - 512530 == -439324)
																									{
																										if (!monkey)
																										{
																											break;
																										}
																										if (221772 - 155093 == 66679)
																										{
																											monkey.FireRune();
																											if (291395 - 418109 == -126714)
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
		goto IL_6F5;
		IL_2EF:
		return false;
		IL_6F5:
		return false;
	}

	// Token: 0x060052C9 RID: 21193 RVA: 0x00A19A24 File Offset: 0x00A17C24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060052CA RID: 21194 RVA: 0x00A19A28 File Offset: 0x00A17C28
	internal static bool KLmxtj5jzuH7korEBGNh()
	{
		return true;
	}

	// Token: 0x060052CB RID: 21195 RVA: 0x00A19A2C File Offset: 0x00A17C2C
	internal static bool TPxPhl5haxEbGnLZ7pDY()
	{
		return false;
	}

	// Token: 0x04005C26 RID: 23590
	private ProjectileControl aNycI68iVMf;

	// Token: 0x04005C27 RID: 23591
	private Vector3 pZCcIt0VY4b;

	// Token: 0x04005C28 RID: 23592
	private float QhgcIXfJVCx;

	// Token: 0x04005C29 RID: 23593
	public int mLv;
}
