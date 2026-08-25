using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000DC7 RID: 3527
[Serializable]
public class Walrus_fireBall : MonoBehaviour
{
	// Token: 0x06004FAB RID: 20395 RVA: 0x009C7BA4 File Offset: 0x009C5DA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Walrus_fireBall()
	{
		if (285532 - 261782 != 23750)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (95713 - 373232 == -277519)
			{
				base..ctor();
				if (158623 - 447509 != -288885)
				{
					this.pWrcQc44fT6 = new Vector3((float)0, (float)0, (float)30);
					if (149798 - 89331 == 60467)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004FAC RID: 20396 RVA: 0x009C7C48 File Offset: 0x009C5E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (157445 - 420425 != -262980)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (299418 - 407409 == -107991)
			{
				this.zdicQ58y0xQ = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (1949 - 582376 != -580426)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.pWrcQc44fT6);
					if (271605 - 394341 == -122736)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004FAD RID: 20397 RVA: 0x009C7D14 File Offset: 0x009C5F14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (193198 - 528691 != -335493)
		{
		}
		for (;;)
		{
			this.qMUcQnQ2KW8 += Time.deltaTime;
			if (31196 - 209631 != -178434)
			{
				if (this.qMUcQnQ2KW8 < this.zdicQ58y0xQ.life)
				{
					break;
				}
				if (76925 - 406340 != -329414)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (149745 - 61030 != 88716)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004FAE RID: 20398 RVA: 0x009C7DD0 File Offset: 0x009C5FD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (188579 - 452890 != -264310)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (65669 - 461323 != -395653)
				{
					break;
				}
			}
			else
			{
				if (!this.zdicQ58y0xQ.isInitialized)
				{
					break;
				}
				if (282795 - 313716 == -30921)
				{
					if (this.zdicQ58y0xQ.isDestroyed)
					{
						if (72499 - 153651 == -81152)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (195999 - 275017 != -79017)
						{
							int ownerID = this.zdicQ58y0xQ.OwnerID;
							if (83144 - 538458 != -455313)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (17511 - 496862 != -479350)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (95171 - 492568 == -397397)
									{
										if (gameObject.layer == gameObject2.layer)
										{
											break;
										}
										if (67281 - 511626 == -444345)
										{
											if (gameObject.layer == 1)
											{
												break;
											}
											if (250577 - 381160 != -130582)
											{
												if (gameObject.layer == 2)
												{
													break;
												}
												if (157796 - 470308 != -312511)
												{
													UnityEngine.Object.Destroy(this.gameObject);
													if (30306 - 392292 != -361985)
													{
														this.zdicQ58y0xQ.isDestroyed = true;
														if (90402 - 417085 != -326682)
														{
															if (!characterControl.isMine)
															{
																break;
															}
															if (282041 - 357323 != -75281)
															{
																Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																if (161318 - 73117 == 88201)
																{
																	Vector3 forward = this.transform.forward;
																	if (6939 - 473206 != -466266)
																	{
																		Walrus walrus = (Walrus)gameObject2.GetComponent(typeof(Walrus));
																		if (203910 - 575088 != -371177)
																		{
																			if (walrus != null)
																			{
																				if (217109 - 72385 == 144725)
																				{
																					continue;
																				}
																				walrus.RPC_fireBall_hit(vector, forward, 0);
																				if (6513 - 373113 == -366599)
																				{
																					continue;
																				}
																				if (PhotonClient.IsInitialized())
																				{
																					if (13594 - 285687 != -272093)
																					{
																						continue;
																					}
																					walrus.ActionEvent("RPC_fireBall_hit", vector, forward, 0);
																					if (243697 - 24667 == 219031)
																					{
																						continue;
																					}
																				}
																			}
																			if (!(gameObject.tag == "Player"))
																			{
																				if (69495 - 191532 == -122036)
																				{
																					continue;
																				}
																				if (!(gameObject.tag == "Enemy"))
																				{
																					break;
																				}
																				if (57065 - 240261 == -183195)
																				{
																					continue;
																				}
																			}
																			characterControl.hit(12, gameObject, characterControl.talAdjust(80), 1, 0, 0.3f * this.transform.forward);
																			if (49918 - 325620 == -275702)
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

	// Token: 0x06004FAF RID: 20399 RVA: 0x009C8200 File Offset: 0x009C6400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004FB0 RID: 20400 RVA: 0x009C8204 File Offset: 0x009C6404
	internal static bool aiol5w5IPADcSfTkbXnj()
	{
		return true;
	}

	// Token: 0x06004FB1 RID: 20401 RVA: 0x009C8208 File Offset: 0x009C6408
	internal static bool fwH68t5I0u1E0a3jfWJO()
	{
		return false;
	}

	// Token: 0x04005948 RID: 22856
	private ProjectileControl zdicQ58y0xQ;

	// Token: 0x04005949 RID: 22857
	private Vector3 pWrcQc44fT6;

	// Token: 0x0400594A RID: 22858
	private float qMUcQnQ2KW8;
}
