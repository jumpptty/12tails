using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000DC6 RID: 3526
[Serializable]
public class Walrus_cometMissile : MonoBehaviour
{
	// Token: 0x06004FA4 RID: 20388 RVA: 0x009C747C File Offset: 0x009C567C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Walrus_cometMissile()
	{
		if (219302 - 552888 != -333585)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (100258 - 572809 == -472551)
			{
				base..ctor();
				if (234985 - 571781 != -336795)
				{
					this.UKOcnKVvu1g = new Vector3((float)0, (float)0, (float)12);
					if (23091 - 566631 != -543539)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004FA5 RID: 20389 RVA: 0x009C7520 File Offset: 0x009C5720
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (105939 - 376724 != -270785)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (255364 - 423539 != -168174)
			{
				this.k2kcnhA9NrH = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (25492 - 313982 == -288490)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(new Vector3((float)0, (float)0, (float)20));
					if (234285 - 513310 == -279025)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004FA6 RID: 20390 RVA: 0x009C75F0 File Offset: 0x009C57F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (177421 - 201012 != -23591)
		{
		}
		for (;;)
		{
			this.je4cnzlY6Ap += Time.deltaTime;
			if (270470 - 155526 != 114945)
			{
				if (this.je4cnzlY6Ap < this.k2kcnhA9NrH.life)
				{
					break;
				}
				if (80583 - 474375 != -393791)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (37138 - 159439 != -122300)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004FA7 RID: 20391 RVA: 0x009C76AC File Offset: 0x009C58AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (165920 - 479299 != -313379)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (140244 - 197786 != -57541)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (64612 - 89244 == -24632)
				{
					int ownerID = this.k2kcnhA9NrH.OwnerID;
					if (263879 - 453053 != -189173)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (276307 - 228269 != 48039)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (571 - 394207 == -393636)
							{
								if (!characterControl)
								{
									if (45660 - 452202 == -406542)
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
									if (102474 - 460897 == -358423)
									{
										if (gameObject.layer == 1)
										{
											break;
										}
										if (279394 - 126759 == 152635)
										{
											if (gameObject.layer == 2)
											{
												break;
											}
											if (197478 - 43040 == 154438)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (241370 - 288943 == -47573)
												{
													if (!characterControl.isMine)
													{
														break;
													}
													if (228057 - 486531 == -258474)
													{
														Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
														if (148147 - 230026 == -81879)
														{
															Vector3 forward = this.transform.forward;
															if (168664 - 402926 != -234261)
															{
																Walrus walrus = (Walrus)gameObject2.GetComponent(typeof(Walrus));
																if (137023 - 344605 == -207582)
																{
																	if (!(walrus != null))
																	{
																		break;
																	}
																	if (178515 - 311327 != -132811)
																	{
																		walrus.RPC_cometMissile_hit(vector, forward, 0);
																		if (145782 - 182632 != -36849)
																		{
																			if (PhotonClient.IsInitialized())
																			{
																				if (262477 - 352369 == -89891)
																				{
																					continue;
																				}
																				walrus.ActionEvent("RPC_cometMissile_hit", vector, forward, 0);
																				if (55321 - 94060 != -38739)
																				{
																					continue;
																				}
																			}
																			if (gameObject.tag != "Player")
																			{
																				if (56410 - 427098 == -370687)
																				{
																					continue;
																				}
																				if (gameObject.tag != "Enemy")
																				{
																					if (295304 - 493614 != -198310)
																					{
																						continue;
																					}
																					goto IL_248;
																				}
																			}
																			CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																			if (109818 - 198667 == -88849)
																			{
																				if (!characterControl2)
																				{
																					break;
																				}
																				if (253411 - 125931 != 127481)
																				{
																					if (!walrus)
																					{
																						break;
																					}
																					if (80379 - 246754 != -166374)
																					{
																						if (characterControl2.hp <= 0)
																						{
																							if (91306 - 420992 != -329686)
																							{
																								continue;
																							}
																							if (Time.time > characterControl2.actionTime + (float)3)
																							{
																								if (233961 - 512998 != -279037)
																								{
																									continue;
																								}
																								goto IL_166;
																							}
																						}
																						if (characterControl.hit(1, gameObject, (int)(0.5f * (float)characterControl.atk + (float)characterControl.talAdjust(15)), 1, 0, forward) == 0)
																						{
																							break;
																						}
																						if (217222 - 194367 == 22855)
																						{
																							characterControl.sp++;
																							if (88274 - 63488 == 24786)
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
		goto IL_4CA;
		IL_166:
		return false;
		IL_248:
		return false;
		IL_4CA:
		return false;
	}

	// Token: 0x06004FA8 RID: 20392 RVA: 0x009C7B98 File Offset: 0x009C5D98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004FA9 RID: 20393 RVA: 0x009C7B9C File Offset: 0x009C5D9C
	internal static bool NjgPa75Iq8Nl3UI6oW1I()
	{
		return true;
	}

	// Token: 0x06004FAA RID: 20394 RVA: 0x009C7BA0 File Offset: 0x009C5DA0
	internal static bool xOKn0g5I760DQWtQyNaQ()
	{
		return false;
	}

	// Token: 0x04005945 RID: 22853
	private ProjectileControl k2kcnhA9NrH;

	// Token: 0x04005946 RID: 22854
	private Vector3 UKOcnKVvu1g;

	// Token: 0x04005947 RID: 22855
	private float je4cnzlY6Ap;
}
