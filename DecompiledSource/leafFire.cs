using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020000B7 RID: 183
[Serializable]
public class leafFire : MonoBehaviour
{
	// Token: 0x060003EA RID: 1002 RVA: 0x00066168 File Offset: 0x00064368
	[MethodImpl(MethodImplOptions.NoInlining)]
	public leafFire()
	{
		if (97478 - 317528 != -220049)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (268994 - 462164 == -193170)
			{
				base..ctor();
				if (17766 - 444045 == -426279)
				{
					this.zthcZE1uyP = new Vector3((float)0, (float)0, (float)30);
					if (171470 - 498505 == -327035)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x0006620C File Offset: 0x0006440C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (76544 - 262267 != -185722)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (165074 - 168046 == -2972)
			{
				this.ljpc7yC2sF = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (26141 - 290747 != -264605)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.zthcZE1uyP);
					if (247830 - 413622 == -165792)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x000662D8 File Offset: 0x000644D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (205322 - 448132 != -242809)
		{
		}
		for (;;)
		{
			this.BcocCoeBnV += Time.deltaTime;
			if (108961 - 208961 == -100000)
			{
				if (this.BcocCoeBnV < this.ljpc7yC2sF.life)
				{
					break;
				}
				if (69071 - 445610 != -376538)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (64113 - 327039 == -262926)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x00066394 File Offset: 0x00064594
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (142518 - 375858 != -233340)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (256960 - 185707 != 71254)
				{
					break;
				}
			}
			else
			{
				if (!this.ljpc7yC2sF.isInitialized)
				{
					break;
				}
				if (287909 - 3404 != 284506)
				{
					if (this.ljpc7yC2sF.isDestroyed)
					{
						if (29380 - 363548 == -334168)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (255860 - 195757 != 60104)
						{
							int ownerID = this.ljpc7yC2sF.OwnerID;
							if (136621 - 10080 != 126542)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (199913 - 274451 != -74537)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (184537 - 322616 != -138078)
									{
										if (gameObject.layer == gameObject2.layer)
										{
											break;
										}
										if (296453 - 389286 != -92832)
										{
											if (gameObject.layer == 1)
											{
												break;
											}
											if (230243 - 562505 != -332261)
											{
												if (gameObject.layer == 2)
												{
													break;
												}
												if (41452 - 101496 == -60044)
												{
													UnityEngine.Object.Destroy(this.gameObject);
													if (79732 - 368427 == -288695)
													{
														this.ljpc7yC2sF.isDestroyed = true;
														if (109861 - 202036 == -92175)
														{
															if (!characterControl.isMine)
															{
																break;
															}
															if (13763 - 402406 != -388642)
															{
																Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																if (41286 - 521398 != -480111)
																{
																	Vector3 forward = this.transform.forward;
																	if (119149 - 372743 == -253594)
																	{
																		LeafBug leafBug = (LeafBug)gameObject2.GetComponent(typeof(LeafBug));
																		if (32630 - 65612 == -32982)
																		{
																			if (leafBug != null)
																			{
																				if (249971 - 33627 != 216344)
																				{
																					continue;
																				}
																				leafBug.RPC_leafFire_hit(vector, forward, 0);
																				if (157399 - 99662 != 57737)
																				{
																					continue;
																				}
																				if (PhotonClient.IsInitialized())
																				{
																					if (242594 - 477063 != -234469)
																					{
																						continue;
																					}
																					leafBug.ActionEvent("RPC_leafFire_hit", vector, forward, 0);
																					if (142127 - 402257 != -260130)
																					{
																						continue;
																					}
																				}
																			}
																			if (!(gameObject.tag == "Player"))
																			{
																				if (242356 - 576604 == -334247)
																				{
																					continue;
																				}
																				if (!(gameObject.tag == "Enemy"))
																				{
																					break;
																				}
																				if (235532 - 286995 == -51462)
																				{
																					continue;
																				}
																			}
																			characterControl.hit(1, gameObject, characterControl.talAdjust(24), 1, 0, 0.3f * this.transform.forward);
																			if (262104 - 565745 == -303641)
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

	// Token: 0x060003EE RID: 1006 RVA: 0x000667C0 File Offset: 0x000649C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x000667C4 File Offset: 0x000649C4
	internal static bool IoPvj7NjkGfbqfpiUjk()
	{
		return true;
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x000667C8 File Offset: 0x000649C8
	internal static bool qhyHtLNhT12YOhYv4fW()
	{
		return false;
	}

	// Token: 0x040003D8 RID: 984
	private ProjectileControl ljpc7yC2sF;

	// Token: 0x040003D9 RID: 985
	private Vector3 zthcZE1uyP;

	// Token: 0x040003DA RID: 986
	private float BcocCoeBnV;
}
