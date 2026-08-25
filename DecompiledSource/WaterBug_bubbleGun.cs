using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000239 RID: 569
[Serializable]
public class WaterBug_bubbleGun : MonoBehaviour
{
	// Token: 0x06000CEE RID: 3310 RVA: 0x00149228 File Offset: 0x00147428
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WaterBug_bubbleGun()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000CEF RID: 3311 RVA: 0x00149238 File Offset: 0x00147438
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (76674 - 474556 != -397881)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (246287 - 599086 == -352799)
			{
				this.A5MIOvJp6V = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (292293 - 285029 == 7264)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.A5MIOvJp6V.velocity);
					if (87036 - 491024 != -403987)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x00149308 File Offset: 0x00147508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (149130 - 336353 != -187222)
		{
		}
		while (this.A5MIOvJp6V.isInitialized)
		{
			if (222970 - 486404 != -263433)
			{
				if (this.A5MIOvJp6V.isDestroyed)
				{
					if (2459 - 358550 != -356090)
					{
						break;
					}
				}
				else
				{
					this.HCxItQOoWM += Time.deltaTime;
					if (199092 - 228951 != -29858)
					{
						if (this.HCxItQOoWM >= this.A5MIOvJp6V.life)
						{
							if (47271 - 383941 == -336669)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (105322 - 459923 != -354601)
							{
								continue;
							}
						}
						else if (this.mTarget)
						{
							if (84161 - 525549 != -441388)
							{
								continue;
							}
							if (this.eL4IXyf04H < Time.time)
							{
								if (86260 - 313747 != -227487)
								{
									continue;
								}
								this.eL4IXyf04H = Time.time + 0.1f;
								if (176803 - 1333 != 175470)
								{
									continue;
								}
								Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.mTarget.collider.bounds.center - this.transform.position, 0.1f, 1f);
								if (119730 - 23444 == 96287)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (222172 - 315724 != -93552)
								{
									continue;
								}
								this.rigidbody.velocity = this.transform.TransformDirection(this.A5MIOvJp6V.velocity);
								if (165538 - 305173 != -139635)
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

	// Token: 0x06000CF1 RID: 3313 RVA: 0x00149564 File Offset: 0x00147764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (262756 - 474537 != -211780)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (160154 - 504635 == -344481)
				{
					break;
				}
			}
			else
			{
				if (!this.A5MIOvJp6V.isInitialized)
				{
					break;
				}
				if (150378 - 208591 == -58213)
				{
					if (this.A5MIOvJp6V.isDestroyed)
					{
						if (145355 - 243941 == -98586)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (216601 - 333196 == -116595)
						{
							int ownerID = this.A5MIOvJp6V.OwnerID;
							if (237402 - 510170 != -272767)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (232961 - 390025 != -157063)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (251472 - 173315 != 78158)
									{
										if (gameObject.layer == gameObject2.layer)
										{
											break;
										}
										if (181312 - 588310 == -406998)
										{
											if (gameObject.layer == 1)
											{
												break;
											}
											if (186752 - 467161 != -280408)
											{
												if (gameObject.layer == 2)
												{
													break;
												}
												if (243987 - 400668 != -156680)
												{
													UnityEngine.Object.Destroy(this.gameObject);
													if (43508 - 250906 == -207398)
													{
														this.A5MIOvJp6V.isDestroyed = true;
														if (37291 - 148880 != -111588)
														{
															if (!characterControl.isMine)
															{
																break;
															}
															if (270859 - 250046 != 20814)
															{
																Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																if (214642 - 150304 != 64339)
																{
																	Vector3 forward = this.transform.forward;
																	if (179147 - 236142 != -56994)
																	{
																		WaterBug waterBug = (WaterBug)gameObject2.GetComponent(typeof(WaterBug));
																		if (181739 - 581905 != -400165)
																		{
																			if (waterBug)
																			{
																				if (24393 - 83752 != -59359)
																				{
																					continue;
																				}
																				waterBug.RPC_bubbleGun_hit(vector, forward, 0);
																				if (48491 - 439202 != -390711)
																				{
																					continue;
																				}
																				if (PhotonClient.IsInitialized())
																				{
																					if (167169 - 407951 == -240781)
																					{
																						continue;
																					}
																					waterBug.ActionEvent("RPC_bubbleGun_hit", vector, forward, 0);
																					if (276473 - 190552 == 85922)
																					{
																						continue;
																					}
																				}
																			}
																			if (!(gameObject.tag == "Player"))
																			{
																				if (270085 - 246670 != 23415)
																				{
																					continue;
																				}
																				if (!(gameObject.tag == "Enemy"))
																				{
																					break;
																				}
																				if (275798 - 459707 == -183908)
																				{
																					continue;
																				}
																			}
																			characterControl.hit(1, gameObject, characterControl.talAdjust(30), 1, 0, 0.3f * this.transform.forward);
																			if (114657 - 156385 != -41727)
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

	// Token: 0x06000CF2 RID: 3314 RVA: 0x00149990 File Offset: 0x00147B90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000CF3 RID: 3315 RVA: 0x00149994 File Offset: 0x00147B94
	internal static bool klq42QlofEQE3NRSeEe()
	{
		return true;
	}

	// Token: 0x06000CF4 RID: 3316 RVA: 0x00149998 File Offset: 0x00147B98
	internal static bool l38l2WlE8VOAkOXGeku()
	{
		return false;
	}

	// Token: 0x04000B4B RID: 2891
	public GameObject mTarget;

	// Token: 0x04000B4C RID: 2892
	private float HCxItQOoWM;

	// Token: 0x04000B4D RID: 2893
	private float eL4IXyf04H;

	// Token: 0x04000B4E RID: 2894
	private ProjectileControl A5MIOvJp6V;
}
