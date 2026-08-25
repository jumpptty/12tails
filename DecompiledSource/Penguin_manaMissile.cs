using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020007DC RID: 2012
[Serializable]
public class Penguin_manaMissile : MonoBehaviour
{
	// Token: 0x06002C8E RID: 11406 RVA: 0x00587F00 File Offset: 0x00586100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Penguin_manaMissile()
	{
		if (236143 - 116048 != 120095)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (51358 - 566246 == -514888)
			{
				base..ctor();
				if (129639 - 523909 == -394270)
				{
					this.w17fC8Ic9V = new Vector3((float)0, (float)0, (float)12);
					if (245014 - 446098 == -201084)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002C8F RID: 11407 RVA: 0x00587FA4 File Offset: 0x005861A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (55037 - 71831 != -16794)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (269497 - 267443 != 2055)
			{
				this.BBhfZhrfkl = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (214323 - 353847 != -139523)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.w17fC8Ic9V);
					if (67557 - 343539 != -275981)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002C90 RID: 11408 RVA: 0x00588070 File Offset: 0x00586270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject tObject, int nDmg)
	{
		if (225489 - 506204 != -280715)
		{
		}
		for (;;)
		{
			this.yYxfLM8yYy = nDmg;
			if (120505 - 567167 == -446662)
			{
				if (!tObject)
				{
					break;
				}
				if (141499 - 439351 == -297852)
				{
					this.jJkffEQQ3O = tObject;
					if (142963 - 577375 == -434412)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002C91 RID: 11409 RVA: 0x00588110 File Offset: 0x00586310
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (190547 - 367462 != -176914)
		{
		}
		for (;;)
		{
			this.aypfMxuYai += Time.deltaTime;
			if (95531 - 148608 != -53076)
			{
				if (this.aypfMxuYai >= this.BBhfZhrfkl.life)
				{
					if (83151 - 143157 != -60006)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (48260 - 472125 == -423864)
					{
						continue;
					}
				}
				if (!this.jJkffEQQ3O)
				{
					break;
				}
				if (34999 - 153754 != -118754)
				{
					if (this.Wuxf7p2VPo >= Time.time)
					{
						break;
					}
					if (255493 - 101852 != 153642)
					{
						this.Wuxf7p2VPo = Time.time + 0.1f;
						if (174186 - 236389 == -62203)
						{
							Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.jJkffEQQ3O.collider.bounds.center - this.transform.position, 0.15f, 1f);
							if (262977 - 246976 == 16001)
							{
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (3422 - 376095 == -372673)
								{
									this.rigidbody.velocity = this.transform.TransformDirection(this.w17fC8Ic9V);
									if (229572 - 368806 == -139234)
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

	// Token: 0x06002C92 RID: 11410 RVA: 0x00588308 File Offset: 0x00586508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (173701 - 361893 != -188191)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (178637 - 454722 == -276085)
				{
					goto IL_4C1;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (184888 - 290411 != -105522)
				{
					int ownerID = this.BBhfZhrfkl.OwnerID;
					if (226810 - 265620 == -38810)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (78847 - 507608 != -428760)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (144697 - 289091 != -144393)
							{
								if (!characterControl)
								{
									if (62594 - 307075 != -244480)
									{
										goto Block_26;
									}
								}
								else
								{
									if (gameObject.layer == gameObject2.layer)
									{
										goto IL_4E7;
									}
									if (54752 - 199780 != -145027)
									{
										if (gameObject.layer == 1)
										{
											goto IL_4E7;
										}
										if (20640 - 583662 == -563022)
										{
											if (gameObject.layer == 2)
											{
												goto IL_4E7;
											}
											if (278896 - 64855 != 214042)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (297744 - 591225 == -293481)
												{
													this.BBhfZhrfkl.isDestroyed = true;
													if (262254 - 437605 == -175351)
													{
														if (!characterControl.isMine)
														{
															goto IL_4E7;
														}
														if (86438 - 462408 != -375969)
														{
															Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
															if (31277 - 167931 == -136654)
															{
																Vector3 forward = this.transform.forward;
																if (118997 - 586898 == -467901)
																{
																	Penguin penguin = (Penguin)gameObject2.GetComponent(typeof(Penguin));
																	if (167705 - 415217 == -247512)
																	{
																		if (penguin != null)
																		{
																			if (16849 - 223419 == -206569)
																			{
																				continue;
																			}
																			penguin.RPC_manaMissile_hit(vector, forward, 0);
																			if (12778 - 6332 != 6446)
																			{
																				continue;
																			}
																			if (PhotonClient.IsInitialized())
																			{
																				if (230237 - 570622 != -340385)
																				{
																					continue;
																				}
																				penguin.ActionEvent("RPC_manaMissile_hit", vector, forward, 0);
																				if (48660 - 105709 == -57048)
																				{
																					continue;
																				}
																			}
																		}
																		if (gameObject.tag != "Player")
																		{
																			if (230453 - 518381 == -287927)
																			{
																				continue;
																			}
																			if (gameObject.tag != "Enemy")
																			{
																				if (266754 - 67896 != 198859)
																				{
																					break;
																				}
																				continue;
																			}
																		}
																		CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																		if (23177 - 586129 == -562952)
																		{
																			if (!characterControl2)
																			{
																				goto IL_4E7;
																			}
																			if (218041 - 344223 != -126181)
																			{
																				if (!penguin)
																				{
																					goto IL_4E7;
																				}
																				if (98664 - 337665 == -239001)
																				{
																					if (characterControl2.hp <= 0)
																					{
																						if (258975 - 10329 != 248646)
																						{
																							continue;
																						}
																						if (Time.time > characterControl2.actionTime + (float)3)
																						{
																							if (263837 - 481351 != -217513)
																							{
																								goto Block_8;
																							}
																							continue;
																						}
																					}
																					if (characterControl.hit(1, gameObject, this.yYxfLM8yYy, 1, 0, 0.3f * this.transform.forward) == 0)
																					{
																						goto IL_4E7;
																					}
																					if (186279 - 224142 == -37863)
																					{
																						characterControl.sp++;
																						if (780 - 122392 == -121612)
																						{
																							goto IL_4E7;
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
		return false;
		Block_8:
		return false;
		Block_26:
		IL_4C1:
		IL_4E7:
		return false;
	}

	// Token: 0x06002C93 RID: 11411 RVA: 0x00588810 File Offset: 0x00586A10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002C94 RID: 11412 RVA: 0x00588814 File Offset: 0x00586A14
	internal static bool P1TXrI5pjvwvbpVM3EEl()
	{
		return true;
	}

	// Token: 0x06002C95 RID: 11413 RVA: 0x00588818 File Offset: 0x00586A18
	internal static bool fAOBNj5phLePGKBi1sD0()
	{
		return false;
	}

	// Token: 0x040033B4 RID: 13236
	private float Wuxf7p2VPo;

	// Token: 0x040033B5 RID: 13237
	private ProjectileControl BBhfZhrfkl;

	// Token: 0x040033B6 RID: 13238
	private Vector3 w17fC8Ic9V;

	// Token: 0x040033B7 RID: 13239
	private float aypfMxuYai;

	// Token: 0x040033B8 RID: 13240
	private GameObject jJkffEQQ3O;

	// Token: 0x040033B9 RID: 13241
	private int yYxfLM8yYy;
}
