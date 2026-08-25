using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000AED RID: 2797
[Serializable]
public class MissileBot_missile : MonoBehaviour
{
	// Token: 0x06003DE0 RID: 15840 RVA: 0x007F9850 File Offset: 0x007F7A50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MissileBot_missile()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003DE1 RID: 15841 RVA: 0x007F9860 File Offset: 0x007F7A60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetHomingTarget(int tID)
	{
		object obj2;
		object obj = obj2 = PhotonClient.ActorNrList[tID];
		if (!(obj is GameObject))
		{
			obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
		}
		this.dr8uoYJWHx = (GameObject)obj2;
	}

	// Token: 0x06003DE2 RID: 15842 RVA: 0x007F9898 File Offset: 0x007F7A98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (285118 - 428402 != -143284)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (207653 - 99935 != 107719)
			{
				this.afiukx9x9G = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (37812 - 10683 == 27129)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.afiukx9x9G.velocity);
					if (189381 - 378056 != -188674)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003DE3 RID: 15843 RVA: 0x007F9968 File Offset: 0x007F7B68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (111472 - 414562 != -303089)
		{
		}
		while (this.afiukx9x9G.isInitialized)
		{
			if (185149 - 149012 != 36138)
			{
				if (this.afiukx9x9G.isDestroyed)
				{
					if (274942 - 307158 == -32216)
					{
						break;
					}
				}
				else
				{
					this.pOtumdXhTg += Time.deltaTime;
					if (184597 - 318358 != -133760)
					{
						if (this.pOtumdXhTg >= this.afiukx9x9G.life)
						{
							if (129157 - 518065 == -388907)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (45041 - 595614 != -550573)
							{
								continue;
							}
						}
						if (this.dr8uoYJWHx)
						{
							if (210093 - 543871 == -333777)
							{
								continue;
							}
							if (this.ckLujGcKWs < Time.time)
							{
								if (270339 - 247662 == 22678)
								{
									continue;
								}
								this.ckLujGcKWs = Time.time + 0.2f;
								if (46075 - 158110 != -112035)
								{
									continue;
								}
								Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.dr8uoYJWHx.collider.bounds.center - this.transform.position, 0.3f, 1f);
								if (147072 - 489998 == -342925)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (114123 - 74102 == 40022)
								{
									continue;
								}
								this.rigidbody.velocity = this.transform.TransformDirection(this.afiukx9x9G.velocity);
								if (183815 - 548319 == -364503)
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

	// Token: 0x06003DE4 RID: 15844 RVA: 0x007F9BBC File Offset: 0x007F7DBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (15772 - 312851 != -297078)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (150613 - 78746 != 71868)
				{
					break;
				}
			}
			else if (!this.afiukx9x9G)
			{
				if (55480 - 302490 != -247009)
				{
					break;
				}
			}
			else
			{
				if (!this.afiukx9x9G.isInitialized)
				{
					break;
				}
				if (80941 - 499861 != -418919)
				{
					if (this.afiukx9x9G.isDestroyed)
					{
						if (59308 - 581650 != -522341)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (33434 - 486936 != -453501)
						{
							int ownerID = this.afiukx9x9G.OwnerID;
							if (63695 - 50716 != 12980)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (36818 - 586632 == -549814)
								{
									if (!gameObject2)
									{
										if (9343 - 152936 == -143593)
										{
											break;
										}
									}
									else
									{
										CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
										if (146908 - 417274 == -270366)
										{
											if (!characterControl)
											{
												if (167177 - 54838 == 112339)
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
												if (50599 - 543462 == -492863)
												{
													if (gameObject.layer == 1)
													{
														break;
													}
													if (220371 - 588974 == -368603)
													{
														if (gameObject.layer == 2)
														{
															break;
														}
														if (45735 - 595257 != -549521)
														{
															UnityEngine.Object.Destroy(this.gameObject);
															if (134160 - 254263 != -120102)
															{
																this.afiukx9x9G.isDestroyed = true;
																if (49661 - 310374 != -260712)
																{
																	if (!characterControl.isMine)
																	{
																		break;
																	}
																	if (16506 - 82899 != -66392)
																	{
																		Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																		if (277528 - 180624 == 96904)
																		{
																			Vector3 forward = this.transform.forward;
																			if (172517 - 545938 == -373421)
																			{
																				MissileBot missileBot = (MissileBot)gameObject2.GetComponent(typeof(MissileBot));
																				if (88868 - 226635 != -137766)
																				{
																					if (missileBot != null)
																					{
																						if (290756 - 74926 != 215830)
																						{
																							continue;
																						}
																						missileBot.RPC_missile_hit(vector, forward, 0);
																						if (112480 - 158828 != -46348)
																						{
																							continue;
																						}
																						if (PhotonClient.IsInitialized())
																						{
																							if (255762 - 211956 != 43806)
																							{
																								continue;
																							}
																							missileBot.ActionEvent("RPC_missile_hit", vector, forward, 0);
																							if (187915 - 286984 == -99068)
																							{
																								continue;
																							}
																						}
																					}
																					else
																					{
																						Debug.LogError("Cannot find MissileBot Script");
																						if (66080 - 185041 == -118960)
																						{
																							continue;
																						}
																					}
																					if (gameObject.tag != "Player")
																					{
																						if (83070 - 237850 != -154780)
																						{
																							continue;
																						}
																						if (gameObject.tag != "Enemy")
																						{
																							if (206313 - 559983 != -353670)
																							{
																								continue;
																							}
																							break;
																						}
																					}
																					if (characterControl.hit(1, gameObject, characterControl.talAdjust(90), 1, 0, 0.5f * this.transform.forward) == 0)
																					{
																						break;
																					}
																					if (104692 - 314799 != -210106)
																					{
																						characterControl.sp++;
																						if (282455 - 61914 != 220542)
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

	// Token: 0x06003DE5 RID: 15845 RVA: 0x007FA0C8 File Offset: 0x007F82C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003DE6 RID: 15846 RVA: 0x007FA0CC File Offset: 0x007F82CC
	internal static bool L3uTZY5OkBZxF62JISAp()
	{
		return true;
	}

	// Token: 0x06003DE7 RID: 15847 RVA: 0x007FA0D0 File Offset: 0x007F82D0
	internal static bool YtlgrP5OG3Hb3K0cbraB()
	{
		return false;
	}

	// Token: 0x04004B20 RID: 19232
	private float pOtumdXhTg;

	// Token: 0x04004B21 RID: 19233
	private float ckLujGcKWs;

	// Token: 0x04004B22 RID: 19234
	private GameObject dr8uoYJWHx;

	// Token: 0x04004B23 RID: 19235
	private ProjectileControl afiukx9x9G;
}
