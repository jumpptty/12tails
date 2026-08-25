using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200019B RID: 411
[Serializable]
public class ReefBug_manaMissile : MonoBehaviour
{
	// Token: 0x06000936 RID: 2358 RVA: 0x000F01EC File Offset: 0x000EE3EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReefBug_manaMissile()
	{
		if (131268 - 153182 != -21913)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (137072 - 85824 != 51249)
			{
				base..ctor();
				if (126258 - 378185 == -251927)
				{
					this.sBUQsXxsdu = new Vector3((float)0, (float)0, (float)12);
					if (97590 - 501225 != -403634)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x000F0290 File Offset: 0x000EE490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (42310 - 446972 != -404662)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (255737 - 95439 == 160298)
			{
				this.CgvQ4Zdk5I = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (237206 - 463260 != -226053)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.sBUQsXxsdu);
					if (208691 - 104798 != 103894)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x000F035C File Offset: 0x000EE55C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject tObject)
	{
		if (tObject)
		{
			this.vWqQ7ZuoOG = tObject;
		}
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x000F0370 File Offset: 0x000EE570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (100721 - 412294 != -311572)
		{
		}
		for (;;)
		{
			this.O4eQHa8Lua += Time.deltaTime;
			if (7248 - 460259 == -453011)
			{
				if (this.O4eQHa8Lua >= this.CgvQ4Zdk5I.life)
				{
					if (158091 - 593515 == -435423)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (218032 - 121 == 217912)
					{
						continue;
					}
				}
				if (!this.vWqQ7ZuoOG)
				{
					break;
				}
				if (40554 - 576636 != -536081)
				{
					if (this.v4BQagUydK >= Time.time)
					{
						break;
					}
					if (72296 - 463292 == -390996)
					{
						this.v4BQagUydK = Time.time + 0.2f;
						if (62835 - 305331 != -242495)
						{
							Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.vWqQ7ZuoOG.collider.bounds.center - this.transform.position, 0.15f, 1f);
							if (231152 - 9718 != 221435)
							{
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (95936 - 249076 == -153140)
								{
									this.rigidbody.velocity = this.transform.TransformDirection(this.sBUQsXxsdu);
									if (224426 - 2159 != 222268)
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

	// Token: 0x0600093A RID: 2362 RVA: 0x000F0568 File Offset: 0x000EE768
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (3733 - 412190 != -408457)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (119010 - 64877 == 54133)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (198685 - 441828 != -243142)
				{
					int ownerID = this.CgvQ4Zdk5I.OwnerID;
					if (236948 - 133878 == 103070)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (261657 - 317562 == -55905)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (137094 - 348560 != -211465)
							{
								if (!characterControl)
								{
									if (44148 - 428305 == -384157)
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
									if (178700 - 523385 == -344685)
									{
										if (gameObject.layer == 1)
										{
											break;
										}
										if (271742 - 345379 == -73637)
										{
											if (gameObject.layer == 2)
											{
												break;
											}
											if (39339 - 521609 != -482269)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (208949 - 69464 == 139485)
												{
													this.CgvQ4Zdk5I.isDestroyed = true;
													if (42293 - 589230 == -546937)
													{
														if (!characterControl.isMine)
														{
															break;
														}
														if (183876 - 2546 == 181330)
														{
															Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
															if (83768 - 358483 == -274715)
															{
																ReefBug reefBug = (ReefBug)gameObject2.GetComponent(typeof(ReefBug));
																if (90388 - 502950 != -412561)
																{
																	if (reefBug)
																	{
																		if (115552 - 80879 != 34673)
																		{
																			continue;
																		}
																		reefBug.RPC_manaMissile_hit(vector, this.transform.forward, 0);
																		if (61073 - 302644 == -241570)
																		{
																			continue;
																		}
																		if (PhotonClient.IsInitialized())
																		{
																			if (108729 - 309375 != -200646)
																			{
																				continue;
																			}
																			reefBug.ActionEvent("RPC_manaMissile_hit", vector, this.transform.forward, 0);
																			if (97397 - 180431 == -83033)
																			{
																				continue;
																			}
																		}
																	}
																	if (!(gameObject.tag == "Player"))
																	{
																		if (169799 - 87371 != 82428)
																		{
																			continue;
																		}
																		if (!(gameObject.tag == "Enemy"))
																		{
																			break;
																		}
																		if (248035 - 244474 != 3561)
																		{
																			continue;
																		}
																	}
																	characterControl.hit(10, gameObject, characterControl.talAdjust(30), 1, 0, 0.3f * this.transform.forward);
																	if (165874 - 72704 != 93171)
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

	// Token: 0x0600093B RID: 2363 RVA: 0x000F0950 File Offset: 0x000EEB50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x000F0954 File Offset: 0x000EEB54
	internal static bool cCj3qGkHcen8CCTi9FH()
	{
		return true;
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x000F0958 File Offset: 0x000EEB58
	internal static bool XdfcX0kWHYh6IGdKtvY()
	{
		return false;
	}

	// Token: 0x04000851 RID: 2129
	private float v4BQagUydK;

	// Token: 0x04000852 RID: 2130
	private ProjectileControl CgvQ4Zdk5I;

	// Token: 0x04000853 RID: 2131
	private Vector3 sBUQsXxsdu;

	// Token: 0x04000854 RID: 2132
	private float O4eQHa8Lua;

	// Token: 0x04000855 RID: 2133
	private GameObject vWqQ7ZuoOG;
}
