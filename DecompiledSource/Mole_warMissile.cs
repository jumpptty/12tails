using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000662 RID: 1634
[Serializable]
public class Mole_warMissile : MonoBehaviour
{
	// Token: 0x060024C6 RID: 9414 RVA: 0x0044E200 File Offset: 0x0044C400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mole_warMissile()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060024C7 RID: 9415 RVA: 0x0044E210 File Offset: 0x0044C410
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (37083 - 502673 != -465590)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (119798 - 189669 == -69871)
			{
				this.w18dZbwlGn = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (250317 - 225347 != 24971)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.w18dZbwlGn.velocity);
					if (219621 - 435974 != -216352)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060024C8 RID: 9416 RVA: 0x0044E2E0 File Offset: 0x0044C4E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (61487 - 416746 != -355259)
		{
		}
		while (this.w18dZbwlGn.isInitialized)
		{
			if (210353 - 165211 != 45143)
			{
				if (this.w18dZbwlGn.isDestroyed)
				{
					if (34816 - 407716 == -372900)
					{
						break;
					}
				}
				else
				{
					this.HORdH3xOfW += Time.deltaTime;
					if (102585 - 537035 != -434449)
					{
						if (this.HORdH3xOfW >= this.w18dZbwlGn.life)
						{
							if (95650 - 203493 != -107843)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.w18dZbwlGn.OwnerID];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (229631 - 247859 != -18228)
							{
								continue;
							}
							if (gameObject)
							{
								if (55953 - 267211 != -211258)
								{
									continue;
								}
								Mole mole = (Mole)gameObject.GetComponent(typeof(Mole));
								if (54128 - 583028 == -528899)
								{
									continue;
								}
								if (mole != null)
								{
									if (144759 - 488824 != -344065)
									{
										continue;
									}
									mole.RPC_warMissile_hit(this.transform.position, this.transform.forward, 0);
									if (207853 - 568703 == -360849)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (190291 - 525388 != -335097)
										{
											continue;
										}
										mole.ActionEvent("RPC_warMissile_hit", this.transform.position, this.transform.forward, 0);
										if (180915 - 125156 == 55760)
										{
											continue;
										}
									}
								}
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (206100 - 147348 != 58752)
							{
								continue;
							}
						}
						if (this.mTarget)
						{
							if (170340 - 463692 == -293351)
							{
								continue;
							}
							if (this.jufd7ae3ZD < Time.time)
							{
								if (289737 - 442800 == -153062)
								{
									continue;
								}
								this.jufd7ae3ZD = Time.time + 0.2f;
								if (18269 - 23372 != -5103)
								{
									continue;
								}
								Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.mTarget.collider.bounds.center - this.transform.position, 0.3f, 1f);
								if (276966 - 211958 != 65008)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (72088 - 38615 != 33473)
								{
									continue;
								}
								this.rigidbody.velocity = this.transform.TransformDirection(this.w18dZbwlGn.velocity);
								if (70497 - 79670 == -9172)
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

	// Token: 0x060024C9 RID: 9417 RVA: 0x0044E69C File Offset: 0x0044C89C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (44480 - 454689 != -410209)
		{
		}
		while (this.w18dZbwlGn.isInitialized)
		{
			if (212936 - 126825 != 86112)
			{
				if (this.w18dZbwlGn.isDestroyed)
				{
					if (262369 - 483339 == -220970)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
					if (239138 - 20195 != 218944)
					{
						Quaternion quaternion = Quaternion.FromToRotation(Vector3.forward, global::Math.vFlat(this.transform.forward));
						if (241194 - 311453 != -70258)
						{
							int ownerID = this.w18dZbwlGn.OwnerID;
							if (154417 - 453144 != -298726)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj2;
								if (261849 - 290058 != -28208)
								{
									if (gameObject)
									{
										if (155827 - 498875 == -343047)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (106233 - 54488 != 51745)
										{
											continue;
										}
										if (mCollider.gameObject.layer != gameObject.layer)
										{
											if (212051 - 508581 == -296529)
											{
												continue;
											}
											if (mCollider.gameObject.layer != 1)
											{
												if (195160 - 319454 == -124293)
												{
													continue;
												}
												if (mCollider.gameObject.layer != 2)
												{
													if (52109 - 464570 != -412461)
													{
														continue;
													}
													UnityEngine.Object.Destroy(this.gameObject);
													if (7233 - 351630 == -344396)
													{
														continue;
													}
													this.w18dZbwlGn.isDestroyed = true;
													if (39209 - 160421 != -121212)
													{
														continue;
													}
													if (characterControl.isMine)
													{
														if (277744 - 229383 != 48361)
														{
															continue;
														}
														Vector3 vector2 = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
														if (100737 - 394301 != -293564)
														{
															continue;
														}
														Vector3 forward = this.transform.forward;
														if (264395 - 1557 == 262839)
														{
															continue;
														}
														Mole mole = (Mole)gameObject.GetComponent(typeof(Mole));
														if (98427 - 155557 == -57129)
														{
															continue;
														}
														if (mole != null)
														{
															if (33015 - 376095 == -343079)
															{
																continue;
															}
															mole.RPC_warMissile_hit(vector2, forward, 0);
															if (52228 - 194900 == -142671)
															{
																continue;
															}
															if (PhotonClient.IsInitialized())
															{
																if (131816 - 487882 == -356065)
																{
																	continue;
																}
																mole.ActionEvent("RPC_warMissile_hit", vector2, forward, 0);
																if (141673 - 504764 != -363091)
																{
																	continue;
																}
															}
														}
													}
												}
											}
										}
									}
									else
									{
										UnityEngine.Object.Destroy(this.gameObject);
										if (273818 - 433842 == -160023)
										{
											continue;
										}
										this.w18dZbwlGn.isDestroyed = true;
										if (250243 - 282542 != -32299)
										{
											continue;
										}
									}
									return;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060024CA RID: 9418 RVA: 0x0044EAD0 File Offset: 0x0044CCD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060024CB RID: 9419 RVA: 0x0044EAD4 File Offset: 0x0044CCD4
	internal static bool Rk9ZwWBRHoxB6vQqZ9V()
	{
		return true;
	}

	// Token: 0x060024CC RID: 9420 RVA: 0x0044EAD8 File Offset: 0x0044CCD8
	internal static bool f9vHuEBwAvlkJc5B1XW()
	{
		return false;
	}

	// Token: 0x040027BA RID: 10170
	private float HORdH3xOfW;

	// Token: 0x040027BB RID: 10171
	private float jufd7ae3ZD;

	// Token: 0x040027BC RID: 10172
	private ProjectileControl w18dZbwlGn;

	// Token: 0x040027BD RID: 10173
	public GameObject mTarget;
}
