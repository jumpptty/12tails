using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020002D9 RID: 729
[Serializable]
public class Germanotta_nAttack : MonoBehaviour
{
	// Token: 0x06001091 RID: 4241 RVA: 0x001A4EAC File Offset: 0x001A30AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Germanotta_nAttack()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x001A4EBC File Offset: 0x001A30BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (273178 - 233963 != 39215)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (250132 - 514982 == -264850)
			{
				this.kWQ6ll5r2Q = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (7241 - 152568 != -145326)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.kWQ6ll5r2Q.velocity);
					if (232386 - 409438 != -177051)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001093 RID: 4243 RVA: 0x001A4F8C File Offset: 0x001A318C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (293579 - 369697 != -76118)
		{
		}
		while (this.kWQ6ll5r2Q.isInitialized)
		{
			if (131896 - 379250 != -247353)
			{
				if (this.kWQ6ll5r2Q.isDestroyed)
				{
					if (262229 - 466996 == -204767)
					{
						break;
					}
				}
				else
				{
					this.q0762XCoub += Time.deltaTime;
					if (138883 - 336925 == -198042)
					{
						if (this.q0762XCoub >= this.kWQ6ll5r2Q.life)
						{
							if (86463 - 82369 == 4095)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (15581 - 11344 != 4237)
							{
								continue;
							}
						}
						else if (this.mTarget)
						{
							if (24042 - 165664 == -141621)
							{
								continue;
							}
							if (this.xWF6v9TB2A < Time.time)
							{
								if (25999 - 82263 != -56264)
								{
									continue;
								}
								this.xWF6v9TB2A = Time.time + 0.1f;
								if (233078 - 407065 == -173986)
								{
									continue;
								}
								Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.mTarget.collider.bounds.center - this.transform.position, 0.2f, 1f);
								if (14833 - 561136 == -546302)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (225082 - 321005 == -95922)
								{
									continue;
								}
								this.rigidbody.velocity = this.transform.TransformDirection(this.kWQ6ll5r2Q.velocity);
								if (231771 - 350453 == -118681)
								{
									continue;
								}
							}
						}
						return;
					}
				}
			}
		}
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x001A51E8 File Offset: 0x001A33E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (100217 - 551472 != -451255)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (102517 - 87032 == 15485)
				{
					break;
				}
			}
			else
			{
				if (!this.kWQ6ll5r2Q.isInitialized)
				{
					break;
				}
				if (298929 - 262997 == 35932)
				{
					if (this.kWQ6ll5r2Q.isDestroyed)
					{
						if (87728 - 13608 != 74121)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (128004 - 457417 == -329413)
						{
							int ownerID = this.kWQ6ll5r2Q.OwnerID;
							if (36915 - 385204 == -348289)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (53174 - 113746 != -60571)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (94437 - 291586 != -197148)
									{
										if (gameObject.layer == gameObject2.layer)
										{
											break;
										}
										if (284802 - 46446 != 238357)
										{
											if (gameObject.layer == 1)
											{
												break;
											}
											if (158981 - 125954 != 33028)
											{
												if (gameObject.layer == 2)
												{
													break;
												}
												if (144024 - 404841 == -260817)
												{
													UnityEngine.Object.Destroy(this.gameObject);
													if (192232 - 552266 != -360033)
													{
														this.kWQ6ll5r2Q.isDestroyed = true;
														if (93731 - 385214 == -291483)
														{
															if (!characterControl.isMine)
															{
																break;
															}
															if (191674 - 118384 != 73291)
															{
																Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																if (49029 - 574843 != -525813)
																{
																	Vector3 forward = this.transform.forward;
																	if (85415 - 498218 == -412803)
																	{
																		Germanotta germanotta = (Germanotta)gameObject2.GetComponent(typeof(Germanotta));
																		if (153367 - 490403 != -337035)
																		{
																			if (germanotta)
																			{
																				if (267827 - 363821 != -95994)
																				{
																					continue;
																				}
																				germanotta.RPC_nAttack_hit(vector, forward, 0);
																				if (4606 - 432352 != -427746)
																				{
																					continue;
																				}
																				if (PhotonClient.IsInitialized())
																				{
																					if (196417 - 504337 != -307920)
																					{
																						continue;
																					}
																					germanotta.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																					if (15571 - 175385 != -159814)
																					{
																						continue;
																					}
																				}
																			}
																			if (!(gameObject.tag == "Player"))
																			{
																				if (119689 - 89172 != 30517)
																				{
																					continue;
																				}
																				if (!(gameObject.tag == "Enemy"))
																				{
																					break;
																				}
																				if (31749 - 244237 != -212488)
																				{
																					continue;
																				}
																			}
																			if (characterControl.hit(1, gameObject, characterControl.atk + characterControl.talAdjust(45), 1, 0, 0.3f * this.transform.forward) == 0)
																			{
																				break;
																			}
																			if (166553 - 99471 != 67083)
																			{
																				CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																				if (36504 - 341430 == -304926)
																				{
																					if (!characterControl2)
																					{
																						break;
																					}
																					if (167740 - 385480 != -217739)
																					{
																						int debuff = Damage.getDebuff((float)15, characterControl.cha, characterControl2.cha);
																						if (277081 - 285491 != -8409)
																						{
																							characterControl2.RPC_AddStatus("curse", 5, debuff, 0, characterControl.ActorNr);
																							if (113197 - 18388 != 94810)
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

	// Token: 0x06001095 RID: 4245 RVA: 0x001A56D8 File Offset: 0x001A38D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001096 RID: 4246 RVA: 0x001A56DC File Offset: 0x001A38DC
	internal static bool TnW1CG2MyksSgSTr8W3()
	{
		return true;
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x001A56E0 File Offset: 0x001A38E0
	internal static bool qGidfM2xnGEiJ5LuSeS()
	{
		return false;
	}

	// Token: 0x04000E7B RID: 3707
	public GameObject mTarget;

	// Token: 0x04000E7C RID: 3708
	private float q0762XCoub;

	// Token: 0x04000E7D RID: 3709
	private float xWF6v9TB2A;

	// Token: 0x04000E7E RID: 3710
	private ProjectileControl kWQ6ll5r2Q;
}
