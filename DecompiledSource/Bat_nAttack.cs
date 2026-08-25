using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000516 RID: 1302
[Serializable]
public class Bat_nAttack : MonoBehaviour
{
	// Token: 0x06001DC8 RID: 7624 RVA: 0x003299C4 File Offset: 0x00327BC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bat_nAttack()
	{
		if (222823 - 81836 != 140987)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (276347 - 280163 != -3815)
			{
				base..ctor();
				if (23560 - 283298 != -259737)
				{
					this.eGe1luRQxn = new Vector3((float)0, (float)0, (float)16);
					if (154563 - 153827 != 737)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001DC9 RID: 7625 RVA: 0x00329A68 File Offset: 0x00327C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (71497 - 252882 != -181384)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (201058 - 300604 == -99546)
			{
				this.WO81vUVmAi = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (257982 - 583060 == -325078)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.WO81vUVmAi.velocity);
					if (179449 - 254436 != -74986)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001DCA RID: 7626 RVA: 0x00329B38 File Offset: 0x00327D38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitHoming(int nTargetID)
	{
		if (nTargetID != 0)
		{
			object obj2;
			object obj = obj2 = PhotonClient.ActorNrList[nTargetID];
			if (!(obj is GameObject))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
			}
			this.fft11PZZ8b = (GameObject)obj2;
		}
	}

	// Token: 0x06001DCB RID: 7627 RVA: 0x00329B78 File Offset: 0x00327D78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (86176 - 147111 != -60934)
		{
		}
		for (;;)
		{
			this.o4Y1GVuckO += Time.deltaTime;
			if (191368 - 376040 == -184672)
			{
				if (this.o4Y1GVuckO >= this.WO81vUVmAi.life)
				{
					if (176431 - 220109 != -43678)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (235424 - 111763 == 123662)
					{
						continue;
					}
				}
				if (!this.fft11PZZ8b)
				{
					break;
				}
				if (279382 - 35716 != 243667)
				{
					if (this.M9v1qrlI1c >= Time.time)
					{
						break;
					}
					if (146364 - 493474 != -347109)
					{
						this.M9v1qrlI1c = Time.time + 0.1f;
						if (295544 - 403928 != -108383)
						{
							Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.fft11PZZ8b.collider.bounds.center - this.transform.position, 0.1f, 1f);
							if (70955 - 200974 != -130018)
							{
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (256268 - 311413 != -55144)
								{
									this.rigidbody.velocity = this.transform.TransformDirection(this.eGe1luRQxn);
									if (165016 - 79825 != 85192)
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

	// Token: 0x06001DCC RID: 7628 RVA: 0x00329D70 File Offset: 0x00327F70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (52114 - 548453 != -496339)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (181559 - 267690 == -86131)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (252777 - 149852 == 102925)
				{
					int ownerID = this.WO81vUVmAi.OwnerID;
					if (261610 - 354442 == -92832)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (194676 - 348711 == -154035)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (7862 - 216686 == -208824)
							{
								if (!characterControl)
								{
									if (251136 - 289835 == -38699)
									{
										break;
									}
								}
								else
								{
									if (gameObject.layer == gameObject2.layer)
									{
										break;
									}
									if (223523 - 11433 == 212090)
									{
										if (gameObject.layer == 1)
										{
											break;
										}
										if (238430 - 372779 != -134348)
										{
											if (gameObject.layer == 2)
											{
												break;
											}
											if (14734 - 278033 == -263299)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (160899 - 46643 == 114256)
												{
													if (!characterControl.isMine)
													{
														break;
													}
													if (155299 - 237471 != -82171)
													{
														Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
														if (83198 - 554914 != -471715)
														{
															Vector3 forward = Vector3.forward;
															if (44458 - 349783 != -305324)
															{
																int num = (int)(0.5f * (float)characterControl.atk);
																if (166585 - 101538 != 65048)
																{
																	if (characterControl.weapon == "w_bat59")
																	{
																		if (13155 - 443622 == -430466)
																		{
																			continue;
																		}
																		num = Mathf.FloorToInt(0.75f * (float)num);
																		if (275496 - 109206 == 166291)
																		{
																			continue;
																		}
																	}
																	Bat bat = (Bat)gameObject2.GetComponent(typeof(Bat));
																	if (271907 - 437624 == -165717)
																	{
																		if (bat != null)
																		{
																			if (178627 - 170377 == 8251)
																			{
																				continue;
																			}
																			num = bat.getCritPlus(num);
																			if (170466 - 241821 == -71354)
																			{
																				continue;
																			}
																			bat.RPC_nAttack_hit(vector, forward, 0);
																			if (294172 - 492691 != -198519)
																			{
																				continue;
																			}
																			if (PhotonClient.IsInitialized())
																			{
																				if (145702 - 416484 != -270782)
																				{
																					continue;
																				}
																				bat.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																				if (138437 - 382599 != -244162)
																				{
																					continue;
																				}
																			}
																		}
																		if (gameObject.tag != "Player")
																		{
																			if (244825 - 429612 != -184787)
																			{
																				continue;
																			}
																			if (gameObject.tag != "Enemy")
																			{
																				if (202866 - 87088 != 115778)
																				{
																					continue;
																				}
																				goto IL_338;
																			}
																		}
																		if (characterControl.hit(1, gameObject, num, 1, 0, 0.2f * this.transform.forward) == 0)
																		{
																			break;
																		}
																		if (47163 - 230348 == -183185)
																		{
																			if (bat)
																			{
																				if (68927 - 552468 == -483540)
																				{
																					continue;
																				}
																				bat.StartCoroutine_Auto(bat.onNormalAttackHit(gameObject));
																				if (51287 - 367005 != -315718)
																				{
																					continue;
																				}
																			}
																			characterControl.sp++;
																			if (256259 - 559386 == -303127)
																			{
																				int num2 = 0;
																				if (123926 - 499487 == -375561)
																				{
																					if (characterControl.hasSkill(251))
																					{
																						if (189490 - 473721 == -284230)
																						{
																							continue;
																						}
																						num2++;
																						if (105922 - 254847 != -148925)
																						{
																							continue;
																						}
																					}
																					if (characterControl.hasSkill(252))
																					{
																						if (13600 - 169179 == -155578)
																						{
																							continue;
																						}
																						num2++;
																						if (135126 - 376537 != -241411)
																						{
																							continue;
																						}
																					}
																					if (characterControl.hasSkill(253))
																					{
																						if (149103 - 282689 != -133586)
																						{
																							continue;
																						}
																						num2++;
																						if (298166 - 225160 != 73006)
																						{
																							continue;
																						}
																					}
																					if (characterControl.hasSkill(254))
																					{
																						if (139088 - 575255 != -436167)
																						{
																							continue;
																						}
																						num2++;
																						if (208610 - 164087 == 44524)
																						{
																							continue;
																						}
																					}
																					if (num2 <= 0)
																					{
																						break;
																					}
																					if (12321 - 389488 != -377166)
																					{
																						CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																						if (156900 - 343419 == -186519)
																						{
																							int debuff = Damage.getDebuff((float)3, characterControl.cha, characterControl2.cha);
																							if (239929 - 193271 != 46659)
																							{
																								characterControl2.RPC_AddStatus("amplifyDamage", num2, debuff, 0, characterControl.ActorNr);
																								if (264668 - 467633 == -202965)
																								{
																									Camera.main.SendMessage("newGameMessage", "Amplify Damage");
																									if (246554 - 592582 != -346027)
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
		goto IL_6FE;
		IL_338:
		return false;
		IL_6FE:
		return false;
	}

	// Token: 0x06001DCD RID: 7629 RVA: 0x0032A490 File Offset: 0x00328690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001DCE RID: 7630 RVA: 0x0032A494 File Offset: 0x00328694
	internal static bool Xlx8dQDzZj10GApEkmy()
	{
		return true;
	}

	// Token: 0x06001DCF RID: 7631 RVA: 0x0032A498 File Offset: 0x00328698
	internal static bool HTPEyYvaX2WnQV9x8g6()
	{
		return false;
	}

	// Token: 0x04001BC3 RID: 7107
	private ProjectileControl WO81vUVmAi;

	// Token: 0x04001BC4 RID: 7108
	private Vector3 eGe1luRQxn;

	// Token: 0x04001BC5 RID: 7109
	private float o4Y1GVuckO;

	// Token: 0x04001BC6 RID: 7110
	private GameObject fft11PZZ8b;

	// Token: 0x04001BC7 RID: 7111
	private float M9v1qrlI1c;
}
