using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020006D8 RID: 1752
[Serializable]
public class Monkey_earthPulse : MonoBehaviour
{
	// Token: 0x0600273E RID: 10046 RVA: 0x004B6338 File Offset: 0x004B4538
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Monkey_earthPulse()
	{
		if (91939 - 580677 != -488737)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (156818 - 244539 == -87721)
			{
				base..ctor();
				if (147910 - 264923 == -117013)
				{
					this.yGWsOnJekI = new Vector3((float)0, (float)0, (float)15);
					if (272453 - 106262 == 166191)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600273F RID: 10047 RVA: 0x004B63DC File Offset: 0x004B45DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (35392 - 519528 != -484135)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (1942 - 305582 != -303639)
			{
				this.OXMsXkNxll = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (111475 - 67641 != 43835)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.yGWsOnJekI);
					if (212701 - 547712 == -335011)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002740 RID: 10048 RVA: 0x004B64A8 File Offset: 0x004B46A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (188869 - 309232 != -120363)
		{
		}
		for (;;)
		{
			this.sV8s2Tolar += Time.deltaTime;
			if (244993 - 100571 != 144423)
			{
				if (this.sV8s2Tolar < this.OXMsXkNxll.life)
				{
					break;
				}
				if (265286 - 183825 != 81462)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (287921 - 43259 != 244663)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002741 RID: 10049 RVA: 0x004B6564 File Offset: 0x004B4764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (282754 - 471431 != -188677)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (156332 - 112880 == 43452)
				{
					break;
				}
			}
			else
			{
				if (!this.OXMsXkNxll.isInitialized)
				{
					break;
				}
				if (109392 - 531224 == -421832)
				{
					if (this.OXMsXkNxll.isDestroyed)
					{
						if (200693 - 149674 == 51019)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (277101 - 202281 == 74820)
						{
							int ownerID = this.OXMsXkNxll.OwnerID;
							if (63529 - 277861 == -214332)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (265296 - 234747 != 30550)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (85578 - 445021 != -359442)
									{
										if (gameObject.layer == gameObject2.layer)
										{
											break;
										}
										if (185473 - 528448 == -342975)
										{
											if (gameObject.layer == 1)
											{
												break;
											}
											if (203174 - 58428 != 144747)
											{
												if (gameObject.layer == 2)
												{
													break;
												}
												if (99068 - 584159 != -485090)
												{
													UnityEngine.Object.Destroy(this.gameObject);
													if (263085 - 589380 == -326295)
													{
														this.OXMsXkNxll.isDestroyed = true;
														if (122260 - 278587 == -156327)
														{
															if (!characterControl.isMine)
															{
																break;
															}
															if (292662 - 113530 != 179133)
															{
																Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																if (157211 - 351837 == -194626)
																{
																	Vector3 forward = this.transform.forward;
																	if (64503 - 326438 != -261934)
																	{
																		Monkey monkey = (Monkey)gameObject2.GetComponent(typeof(Monkey));
																		if (253139 - 429819 == -176680)
																		{
																			if (!monkey)
																			{
																				break;
																			}
																			if (37805 - 527331 != -489525)
																			{
																				monkey.StartCoroutine_Auto(monkey.RPC_earthPulse_hit(vector, forward, 0));
																				if (275565 - 518696 != -243130)
																				{
																					if (!PhotonClient.IsInitialized())
																					{
																						break;
																					}
																					if (228041 - 56793 == 171248)
																					{
																						monkey.ActionEvent("RPC_earthPulse_hit", vector, forward, 0);
																						if (13128 - 24532 == -11404)
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

	// Token: 0x06002742 RID: 10050 RVA: 0x004B68F8 File Offset: 0x004B4AF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002743 RID: 10051 RVA: 0x004B68FC File Offset: 0x004B4AFC
	internal static bool tiWqKShMU2M2evM2ZwV()
	{
		return true;
	}

	// Token: 0x06002744 RID: 10052 RVA: 0x004B6900 File Offset: 0x004B4B00
	internal static bool zUOlDrhxgq8AXJdyXef()
	{
		return false;
	}

	// Token: 0x04002BDF RID: 11231
	private ProjectileControl OXMsXkNxll;

	// Token: 0x04002BE0 RID: 11232
	private Vector3 yGWsOnJekI;

	// Token: 0x04002BE1 RID: 11233
	private float sV8s2Tolar;
}
