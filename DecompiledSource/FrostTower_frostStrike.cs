using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000B17 RID: 2839
[Serializable]
public class FrostTower_frostStrike : MonoBehaviour
{
	// Token: 0x06003EE4 RID: 16100 RVA: 0x008135C0 File Offset: 0x008117C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FrostTower_frostStrike()
	{
		if (9289 - 390080 != -380790)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (131345 - 66843 != 64503)
			{
				base..ctor();
				if (249187 - 5853 == 243334)
				{
					this.LJfyxIu7d2 = new Vector3((float)0, (float)0, (float)18);
					if (298178 - 128333 != 169846)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003EE5 RID: 16101 RVA: 0x00813664 File Offset: 0x00811864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (170475 - 25416 != 145060)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (242786 - 351722 == -108936)
			{
				this.UZmyrBLXXC = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (137423 - 505864 != -368440)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.LJfyxIu7d2);
					if (205422 - 598795 == -393373)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003EE6 RID: 16102 RVA: 0x00813730 File Offset: 0x00811930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject tObject)
	{
		if (tObject)
		{
			this.nIRyYmsP3w = tObject;
		}
	}

	// Token: 0x06003EE7 RID: 16103 RVA: 0x00813744 File Offset: 0x00811944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (259174 - 6239 != 252935)
		{
		}
		for (;;)
		{
			this.CD1yTTFJai += Time.deltaTime;
			if (231072 - 193215 == 37857)
			{
				if (this.CD1yTTFJai >= this.UZmyrBLXXC.life)
				{
					if (103788 - 543780 == -439991)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (13546 - 512466 == -498919)
					{
						continue;
					}
				}
				if (!this.nIRyYmsP3w)
				{
					break;
				}
				if (88182 - 136140 != -47957)
				{
					if (this.myZyR2UHGM >= Time.time)
					{
						break;
					}
					if (70727 - 326558 == -255831)
					{
						this.myZyR2UHGM = Time.time + 0.1f;
						if (225437 - 93972 != 131466)
						{
							Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.nIRyYmsP3w.collider.bounds.center - this.transform.position, 0.3f, 1f);
							if (193210 - 360379 != -167168)
							{
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (74840 - 226397 != -151556)
								{
									this.rigidbody.velocity = this.transform.TransformDirection(this.LJfyxIu7d2);
									if (248773 - 7471 == 241302)
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

	// Token: 0x06003EE8 RID: 16104 RVA: 0x0081393C File Offset: 0x00811B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (187225 - 557085 != -369859)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (173462 - 100075 != 73388)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (168343 - 113472 != 54872)
				{
					int ownerID = this.UZmyrBLXXC.OwnerID;
					if (196529 - 40999 == 155530)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (164208 - 336294 != -172085)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (69822 - 170260 != -100437)
							{
								if (!characterControl)
								{
									if (46076 - 436399 != -390322)
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
									if (76068 - 550680 == -474612)
									{
										if (gameObject.layer == 1)
										{
											break;
										}
										if (127071 - 241525 == -114454)
										{
											if (gameObject.layer == 2)
											{
												break;
											}
											if (11844 - 72510 != -60665)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (52681 - 592179 != -539497)
												{
													this.UZmyrBLXXC.isDestroyed = true;
													if (105192 - 502480 != -397287)
													{
														if (!characterControl.isMine)
														{
															break;
														}
														if (284292 - 424309 != -140016)
														{
															Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
															if (274083 - 522986 != -248902)
															{
																Vector3 forward = this.transform.forward;
																if (88809 - 412628 != -323818)
																{
																	FrostTower frostTower = (FrostTower)gameObject2.GetComponent(typeof(FrostTower));
																	if (4143 - 30733 != -26589)
																	{
																		if (frostTower != null)
																		{
																			if (289981 - 449270 != -159289)
																			{
																				continue;
																			}
																			frostTower.RPC_frostStrike_hit(vector, forward, 0);
																			if (33064 - 264463 == -231398)
																			{
																				continue;
																			}
																			if (PhotonClient.IsInitialized())
																			{
																				if (136111 - 523621 == -387509)
																				{
																					continue;
																				}
																				frostTower.ActionEvent("RPC_frostStrike_hit", vector, forward, 0);
																				if (142706 - 84216 == 58491)
																				{
																					continue;
																				}
																			}
																		}
																		if (gameObject.tag != "Player")
																		{
																			if (186309 - 490856 != -304547)
																			{
																				continue;
																			}
																			if (gameObject.tag != "Enemy")
																			{
																				if (280085 - 409321 != -129236)
																				{
																					continue;
																				}
																				goto IL_354;
																			}
																		}
																		CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																		if (120889 - 312261 != -191371)
																		{
																			if (!characterControl2)
																			{
																				break;
																			}
																			if (58993 - 41331 != 17663)
																			{
																				if (characterControl2.hasStatus("insight"))
																				{
																					break;
																				}
																				if (249351 - 219136 != 30216)
																				{
																					if (characterControl.hit(1, gameObject, characterControl.talAdjust(30), 1, 0, 0.3f * this.transform.forward) == 0)
																					{
																						break;
																					}
																					if (119744 - 337298 != -217553)
																					{
																						characterControl2.RPC_AddStatus("ice", 3, Damage.getDebuff((float)6, characterControl.cha, characterControl2.cha), 0, characterControl.ActorNr);
																						if (128935 - 292599 != -163663)
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
		goto IL_4AD;
		IL_354:
		return false;
		IL_4AD:
		return false;
	}

	// Token: 0x06003EE9 RID: 16105 RVA: 0x00813E08 File Offset: 0x00812008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003EEA RID: 16106 RVA: 0x00813E0C File Offset: 0x0081200C
	internal static bool cpibnm5mnHONQY9oioWI()
	{
		return true;
	}

	// Token: 0x06003EEB RID: 16107 RVA: 0x00813E10 File Offset: 0x00812010
	internal static bool oyATSR5m6ltLBCSHlcCr()
	{
		return false;
	}

	// Token: 0x04004BF4 RID: 19444
	private float myZyR2UHGM;

	// Token: 0x04004BF5 RID: 19445
	private ProjectileControl UZmyrBLXXC;

	// Token: 0x04004BF6 RID: 19446
	private Vector3 LJfyxIu7d2;

	// Token: 0x04004BF7 RID: 19447
	private float CD1yTTFJai;

	// Token: 0x04004BF8 RID: 19448
	private GameObject nIRyYmsP3w;
}
