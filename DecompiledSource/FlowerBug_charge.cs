using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000066 RID: 102
[Serializable]
public class FlowerBug_charge : MonoBehaviour
{
	// Token: 0x06000218 RID: 536 RVA: 0x00036654 File Offset: 0x00034854
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FlowerBug_charge()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000219 RID: 537 RVA: 0x00036664 File Offset: 0x00034864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (254136 - 243332 != 10804)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (204906 - 341712 == -136806)
			{
				this.GejigdYiA = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (151878 - 589541 != -437662)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.GejigdYiA.velocity);
					if (103036 - 11880 != 91157)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600021A RID: 538 RVA: 0x00036734 File Offset: 0x00034934
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (262831 - 487515 != -224684)
		{
		}
		while (this.GejigdYiA.isInitialized)
		{
			if (69813 - 360771 == -290958)
			{
				if (this.GejigdYiA.isDestroyed)
				{
					if (154952 - 94103 != 60850)
					{
						break;
					}
				}
				else
				{
					this.xMR0pQ40o += Time.deltaTime;
					if (197259 - 531942 == -334683)
					{
						if (this.xMR0pQ40o >= this.GejigdYiA.life)
						{
							if (229129 - 477365 != -248236)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (111400 - 406708 != -295308)
							{
								continue;
							}
						}
						else if (this.mTarget)
						{
							if (258098 - 593635 == -335536)
							{
								continue;
							}
							if (this.xGh8h3tKI < Time.time)
							{
								if (189068 - 319073 == -130004)
								{
									continue;
								}
								this.xGh8h3tKI = Time.time + 0.1f;
								if (214348 - 381874 == -167525)
								{
									continue;
								}
								Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.mTarget.collider.bounds.center - this.transform.position, 0.1f, 1f);
								if (144688 - 313672 == -168983)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (239957 - 25463 == 214495)
								{
									continue;
								}
								this.rigidbody.velocity = this.transform.TransformDirection(this.GejigdYiA.velocity);
								if (227452 - 43767 == 183686)
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

	// Token: 0x0600021B RID: 539 RVA: 0x00036990 File Offset: 0x00034B90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (223700 - 256321 != -32620)
		{
		}
		for (;;)
		{
			IL_6A8:
			if (!PhotonClient.IsInitialized())
			{
				if (65132 - 395298 == -330166)
				{
					break;
				}
			}
			else
			{
				if (!this.GejigdYiA.isInitialized)
				{
					break;
				}
				if (102668 - 454718 != -352049)
				{
					if (this.GejigdYiA.isDestroyed)
					{
						if (295145 - 185960 != 109186)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (54191 - 33483 == 20708)
						{
							int ownerID = this.GejigdYiA.OwnerID;
							if (197174 - 274372 == -77198)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (80615 - 540966 != -460350)
								{
									if (!gameObject2)
									{
										if (169704 - 305461 != -135756)
										{
											UnityEngine.Object.Destroy(this.gameObject);
											if (236424 - 519847 != -283422)
											{
												this.GejigdYiA.isDestroyed = true;
												if (206001 - 364008 == -158007)
												{
													break;
												}
											}
										}
									}
									else
									{
										if (gameObject.layer == gameObject2.layer)
										{
											break;
										}
										if (105427 - 439267 != -333839)
										{
											if (gameObject.layer == 1)
											{
												break;
											}
											if (270834 - 15599 != 255236)
											{
												if (gameObject.layer == 2)
												{
													break;
												}
												if (198435 - 399183 == -200748)
												{
													UnityEngine.Object.Destroy(this.gameObject);
													if (157668 - 322643 == -164975)
													{
														this.GejigdYiA.isDestroyed = true;
														if (79578 - 373831 == -294253)
														{
															CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
															if (165600 - 332741 != -167140)
															{
																if (!characterControl)
																{
																	if (96477 - 221601 != -125123)
																	{
																		break;
																	}
																}
																else
																{
																	if (!characterControl.isMine)
																	{
																		break;
																	}
																	if (278199 - 76163 != 202037)
																	{
																		Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																		if (244514 - 41029 != 203486)
																		{
																			Vector3 forward = this.transform.forward;
																			if (180370 - 265094 == -84724)
																			{
																				FlowerBug flowerBug = (FlowerBug)gameObject2.GetComponent(typeof(FlowerBug));
																				if (98090 - 370526 != -272435)
																				{
																					if (flowerBug)
																					{
																						if (181881 - 247420 == -65538)
																						{
																							continue;
																						}
																						if (characterControl.Type == "FlowerBug_f")
																						{
																							if (40169 - 66660 == -26490)
																							{
																								continue;
																							}
																							flowerBug.RPC_whiteBurst_hit(vector, forward, 0);
																							if (164246 - 355147 != -190901)
																							{
																								continue;
																							}
																							if (PhotonClient.IsInitialized())
																							{
																								if (129421 - 381213 == -251791)
																								{
																									continue;
																								}
																								flowerBug.ActionEvent("RPC_whiteBurst_hit", vector, forward, 0);
																								if (64355 - 517937 == -453581)
																								{
																									continue;
																								}
																							}
																						}
																						else
																						{
																							flowerBug.RPC_charge_hit(vector, forward, 0);
																							if (138294 - 49144 == 89151)
																							{
																								continue;
																							}
																							if (PhotonClient.IsInitialized())
																							{
																								if (79329 - 82766 == -3436)
																								{
																									continue;
																								}
																								flowerBug.ActionEvent("RPC_charge_hit", vector, forward, 0);
																								if (66773 - 576879 != -510106)
																								{
																									continue;
																								}
																							}
																						}
																					}
																					if (characterControl.Type == "FlowerBug_f")
																					{
																						if (106832 - 425756 != -318923)
																						{
																							int layerMask = 130816 - (1 << gameObject2.layer);
																							if (285974 - 527008 != -241033)
																							{
																								UnityScript.Lang.Array obj3 = Damage.FindAreaTarget(vector - Vector3.up, (float)6, (float)3, layerMask);
																								if (209566 - 16815 != 192752)
																								{
																									IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
																									if (155541 - 345320 != -189778)
																									{
																										while (enumerator.MoveNext())
																										{
																											object obj4 = enumerator.Current;
																											object obj6;
																											object obj5 = obj6 = obj4;
																											if (!(obj5 is GameObject))
																											{
																												obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
																											}
																											GameObject gameObject3 = (GameObject)obj6;
																											if (281670 - 378568 != -96898)
																											{
																												goto IL_6A8;
																											}
																											characterControl.hit(1, gameObject3, characterControl.talAdjust(60), 1, 0, Vector3.zero);
																											if (116214 - 181349 != -65135)
																											{
																												goto IL_6A8;
																											}
																											UnityRuntimeServices.Update(enumerator, gameObject3);
																											if (192809 - 369863 != -177054)
																											{
																												goto IL_6A8;
																											}
																										}
																										if (142361 - 529828 == -387467)
																										{
																											break;
																										}
																									}
																								}
																							}
																						}
																					}
																					else
																					{
																						if (!(gameObject.tag == "Player"))
																						{
																							if (212792 - 55794 == 156999)
																							{
																								continue;
																							}
																							if (!(gameObject.tag == "Enemy"))
																							{
																								break;
																							}
																							if (63047 - 98276 != -35229)
																							{
																								continue;
																							}
																						}
																						characterControl.hit(1, gameObject, characterControl.talAdjust(30), 1, 0, 0.3f * this.transform.forward);
																						if (48912 - 288190 != -239277)
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

	// Token: 0x0600021C RID: 540 RVA: 0x0003707C File Offset: 0x0003527C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600021D RID: 541 RVA: 0x00037080 File Offset: 0x00035280
	internal static bool QS45kaVAbMXByseiluo()
	{
		return true;
	}

	// Token: 0x0600021E RID: 542 RVA: 0x00037084 File Offset: 0x00035284
	internal static bool KMWAfRVldBcK78SYOFx()
	{
		return false;
	}

	// Token: 0x04000251 RID: 593
	public GameObject mTarget;

	// Token: 0x04000252 RID: 594
	private float xMR0pQ40o;

	// Token: 0x04000253 RID: 595
	private float xGh8h3tKI;

	// Token: 0x04000254 RID: 596
	private ProjectileControl GejigdYiA;
}
