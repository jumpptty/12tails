using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000E31 RID: 3633
[Serializable]
public class Menalisa_nAttack : MonoBehaviour
{
	// Token: 0x0600522C RID: 21036 RVA: 0x00A08DD8 File Offset: 0x00A06FD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Menalisa_nAttack()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600522D RID: 21037 RVA: 0x00A08DE8 File Offset: 0x00A06FE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (116222 - 207179 != -90957)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (296246 - 580272 != -284025)
			{
				this.aSUce9Tpa4T = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (61372 - 353635 == -292263)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.aSUce9Tpa4T.velocity);
					if (189633 - 256843 == -67210)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600522E RID: 21038 RVA: 0x00A08EB8 File Offset: 0x00A070B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (251296 - 58779 != 192517)
		{
		}
		while (this.aSUce9Tpa4T.isInitialized)
		{
			if (39053 - 269905 == -230852)
			{
				if (this.aSUce9Tpa4T.isDestroyed)
				{
					if (210626 - 21450 == 189176)
					{
						break;
					}
				}
				else
				{
					this.HorceFCWdyf += Time.deltaTime;
					if (189978 - 566556 != -376577)
					{
						if (this.HorceFCWdyf >= this.aSUce9Tpa4T.life)
						{
							if (32486 - 195166 != -162680)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (262033 - 842 == 261192)
							{
								continue;
							}
						}
						else if (this.mTarget)
						{
							if (155242 - 327375 == -172132)
							{
								continue;
							}
							if (this.rfKceATFVIE < Time.time)
							{
								if (269113 - 394377 == -125263)
								{
									continue;
								}
								this.rfKceATFVIE = Time.time + 0.1f;
								if (132313 - 416734 == -284420)
								{
									continue;
								}
								Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.mTarget.collider.bounds.center - this.transform.position, 0.2f, 1f);
								if (11805 - 135326 == -123520)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (18383 - 342232 != -323849)
								{
									continue;
								}
								this.rigidbody.velocity = this.transform.TransformDirection(this.aSUce9Tpa4T.velocity);
								if (220175 - 477198 == -257022)
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

	// Token: 0x0600522F RID: 21039 RVA: 0x00A09114 File Offset: 0x00A07314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (194296 - 570751 != -376455)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (125472 - 400028 == -274556)
				{
					break;
				}
			}
			else
			{
				if (!this.aSUce9Tpa4T.isInitialized)
				{
					break;
				}
				if (198588 - 181106 != 17483)
				{
					if (this.aSUce9Tpa4T.isDestroyed)
					{
						if (218137 - 375798 == -157661)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (260214 - 155196 == 105018)
						{
							int ownerID = this.aSUce9Tpa4T.OwnerID;
							if (17370 - 431186 != -413815)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (161304 - 42271 != 119034)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (15812 - 394232 != -378419)
									{
										if (gameObject.layer == gameObject2.layer)
										{
											break;
										}
										if (153105 - 298518 == -145413)
										{
											if (gameObject.layer == 1)
											{
												break;
											}
											if (44124 - 349768 != -305643)
											{
												if (gameObject.layer == 2)
												{
													break;
												}
												if (116729 - 297682 != -180952)
												{
													UnityEngine.Object.Destroy(this.gameObject);
													if (234048 - 161565 != 72484)
													{
														this.aSUce9Tpa4T.isDestroyed = true;
														if (177567 - 348736 != -171168)
														{
															if (!characterControl.isMine)
															{
																break;
															}
															if (81796 - 526585 == -444789)
															{
																Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																if (175358 - 422396 != -247037)
																{
																	Vector3 forward = this.transform.forward;
																	if (254750 - 192123 != 62628)
																	{
																		Menalisa menalisa = (Menalisa)gameObject2.GetComponent(typeof(Menalisa));
																		if (129125 - 412187 != -283061)
																		{
																			if (menalisa)
																			{
																				if (263478 - 566906 == -303427)
																				{
																					continue;
																				}
																				menalisa.RPC_nAttack_hit(vector, forward, 0);
																				if (49182 - 241227 != -192045)
																				{
																					continue;
																				}
																				if (PhotonClient.IsInitialized())
																				{
																					if (266336 - 24194 != 242142)
																					{
																						continue;
																					}
																					menalisa.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																					if (127212 - 446388 == -319175)
																					{
																						continue;
																					}
																				}
																			}
																			if (!(gameObject.tag == "Player"))
																			{
																				if (115696 - 226141 == -110444)
																				{
																					continue;
																				}
																				if (!(gameObject.tag == "Enemy"))
																				{
																					break;
																				}
																				if (245991 - 228382 == 17610)
																				{
																					continue;
																				}
																			}
																			if (characterControl.hit(1, gameObject, characterControl.atk, 1, 0, 0.3f * this.transform.forward) == 0)
																			{
																				break;
																			}
																			if (178068 - 23776 == 154292)
																			{
																				CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																				if (226261 - 477958 == -251697)
																				{
																					if (!characterControl2)
																					{
																						break;
																					}
																					if (243466 - 343356 == -99890)
																					{
																						int debuff = Damage.getDebuff((float)15, characterControl.cha, characterControl2.cha);
																						if (203902 - 255668 != -51765)
																						{
																							characterControl2.RPC_AddStatus("amplifyDamage", 5, debuff, 0, characterControl.ActorNr);
																							if (24318 - 151495 != -127176)
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

	// Token: 0x06005230 RID: 21040 RVA: 0x00A095FC File Offset: 0x00A077FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005231 RID: 21041 RVA: 0x00A09600 File Offset: 0x00A07800
	internal static bool rUxuaW5jXm6kFuoqeEtR()
	{
		return true;
	}

	// Token: 0x06005232 RID: 21042 RVA: 0x00A09604 File Offset: 0x00A07804
	internal static bool D1FhXy5jQnEKpSvdX1mx()
	{
		return false;
	}

	// Token: 0x04005B95 RID: 23445
	public GameObject mTarget;

	// Token: 0x04005B96 RID: 23446
	private float HorceFCWdyf;

	// Token: 0x04005B97 RID: 23447
	private float rfKceATFVIE;

	// Token: 0x04005B98 RID: 23448
	private ProjectileControl aSUce9Tpa4T;
}
