using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000E4D RID: 3661
[Serializable]
public class XunWu_fireBall : MonoBehaviour
{
	// Token: 0x060052DA RID: 21210 RVA: 0x00A1AA44 File Offset: 0x00A18C44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public XunWu_fireBall()
	{
		if (195798 - 543422 != -347624)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (185227 - 370696 != -185468)
			{
				base..ctor();
				if (81229 - 390368 == -309139)
				{
					this.wMmcIpwKFtE = new Vector3((float)0, (float)0, (float)30);
					if (199200 - 249002 != -49801)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060052DB RID: 21211 RVA: 0x00A1AAE8 File Offset: 0x00A18CE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (233585 - 217334 != 16252)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (22076 - 173041 != -150964)
			{
				this.ChXcIqT20aV = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (245409 - 272741 == -27332)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.wMmcIpwKFtE);
					if (184446 - 73476 == 110970)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060052DC RID: 21212 RVA: 0x00A1ABB4 File Offset: 0x00A18DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (75355 - 102451 != -27095)
		{
		}
		for (;;)
		{
			this.GI5cIRIfeBe += Time.deltaTime;
			if (109022 - 265350 == -156328)
			{
				if (this.GI5cIRIfeBe < this.ChXcIqT20aV.life)
				{
					break;
				}
				if (30301 - 15331 == 14970)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (99655 - 355390 == -255735)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060052DD RID: 21213 RVA: 0x00A1AC70 File Offset: 0x00A18E70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (110413 - 275696 != -165282)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (73146 - 375410 != -302263)
				{
					break;
				}
			}
			else
			{
				if (!this.ChXcIqT20aV.isInitialized)
				{
					break;
				}
				if (101553 - 116850 == -15297)
				{
					if (this.ChXcIqT20aV.isDestroyed)
					{
						if (243383 - 517930 == -274547)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (17967 - 447206 != -429238)
						{
							int ownerID = this.ChXcIqT20aV.OwnerID;
							if (251412 - 265122 == -13710)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (77677 - 513036 == -435359)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (202262 - 396627 != -194364)
									{
										if (gameObject.layer == gameObject2.layer)
										{
											break;
										}
										if (175094 - 598307 != -423212)
										{
											if (gameObject.layer == 1)
											{
												break;
											}
											if (90293 - 323257 == -232964)
											{
												if (gameObject.layer == 2)
												{
													break;
												}
												if (250708 - 597765 != -347056)
												{
													UnityEngine.Object.Destroy(this.gameObject);
													if (233750 - 346318 != -112567)
													{
														this.ChXcIqT20aV.isDestroyed = true;
														if (255512 - 375409 != -119896)
														{
															if (!characterControl.isMine)
															{
																break;
															}
															if (251025 - 153677 != 97349)
															{
																Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																if (117348 - 58481 == 58867)
																{
																	Vector3 forward = this.transform.forward;
																	if (81677 - 137922 == -56245)
																	{
																		XunWu xunWu = (XunWu)gameObject2.GetComponent(typeof(XunWu));
																		if (12555 - 513573 == -501018)
																		{
																			if (!(xunWu != null))
																			{
																				break;
																			}
																			if (268934 - 207383 != 61552)
																			{
																				xunWu.RPC_fireBall_hit(vector, forward, 0);
																				if (102681 - 221440 != -118758)
																				{
																					if (!PhotonClient.IsInitialized())
																					{
																						break;
																					}
																					if (170050 - 149150 == 20900)
																					{
																						xunWu.ActionEvent("RPC_fireBall_hit", vector, forward, 0);
																						if (122115 - 56616 == 65499)
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

	// Token: 0x060052DE RID: 21214 RVA: 0x00A1AFFC File Offset: 0x00A191FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060052DF RID: 21215 RVA: 0x00A1B000 File Offset: 0x00A19200
	internal static bool e7cJJK5hN3ZKWxyIXbmZ()
	{
		return true;
	}

	// Token: 0x060052E0 RID: 21216 RVA: 0x00A1B004 File Offset: 0x00A19204
	internal static bool pGDiqe5hYaRESlOB6qjP()
	{
		return false;
	}

	// Token: 0x04005C31 RID: 23601
	private ProjectileControl ChXcIqT20aV;

	// Token: 0x04005C32 RID: 23602
	private Vector3 wMmcIpwKFtE;

	// Token: 0x04005C33 RID: 23603
	private float GI5cIRIfeBe;
}
