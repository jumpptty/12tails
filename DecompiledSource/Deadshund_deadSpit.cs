using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000C13 RID: 3091
[Serializable]
public class Deadshund_deadSpit : MonoBehaviour
{
	// Token: 0x06004518 RID: 17688 RVA: 0x008A9AE4 File Offset: 0x008A7CE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Deadshund_deadSpit()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004519 RID: 17689 RVA: 0x008A9AF4 File Offset: 0x008A7CF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (149477 - 285067 != -135589)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (131330 - 228722 != -97391)
			{
				this.EEfhiLnJ51 = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (197805 - 199838 != -2032)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.EEfhiLnJ51.velocity);
					if (96044 - 381453 == -285409)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600451A RID: 17690 RVA: 0x008A9BC4 File Offset: 0x008A7DC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (6707 - 82379 != -75671)
		{
		}
		while (this.EEfhiLnJ51.isInitialized)
		{
			if (138801 - 431401 != -292599)
			{
				if (this.EEfhiLnJ51.isDestroyed)
				{
					if (90920 - 427604 == -336684)
					{
						break;
					}
				}
				else
				{
					this.Nc6h8dk9yH += Time.deltaTime;
					if (278259 - 35274 == 242985)
					{
						if (this.Nc6h8dk9yH >= this.EEfhiLnJ51.life)
						{
							if (155611 - 592283 == -436671)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (24658 - 524262 != -499604)
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

	// Token: 0x0600451B RID: 17691 RVA: 0x008A9CD8 File Offset: 0x008A7ED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (254361 - 449591 != -195229)
		{
		}
		while (this.EEfhiLnJ51.isInitialized)
		{
			if (222736 - 54990 != 167747)
			{
				if (this.EEfhiLnJ51.isDestroyed)
				{
					if (194914 - 346053 != -151138)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
					if (156784 - 446859 != -290074)
					{
						Quaternion quaternion = Quaternion.FromToRotation(Vector3.forward, global::Math.vFlat(this.transform.forward));
						if (15143 - 510121 != -494977)
						{
							int ownerID = this.EEfhiLnJ51.OwnerID;
							if (188294 - 482489 != -294194)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj2;
								if (4565 - 484490 != -479924)
								{
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (297271 - 496893 == -199622)
									{
										if (mCollider.gameObject.layer != gameObject.layer)
										{
											if (3286 - 378631 != -375345)
											{
												continue;
											}
											if (mCollider.gameObject.layer != 1)
											{
												if (225928 - 420540 == -194611)
												{
													continue;
												}
												if (mCollider.gameObject.layer != 2)
												{
													if (162810 - 69900 == 92911)
													{
														continue;
													}
													UnityEngine.Object.Destroy(this.gameObject);
													if (9703 - 567169 != -557466)
													{
														continue;
													}
													if (characterControl.isMine)
													{
														if (22872 - 90790 == -67917)
														{
															continue;
														}
														RaycastHit raycastHit = default(RaycastHit);
														if (248793 - 534109 == -285315)
														{
															continue;
														}
														Deadshund deadshund = (Deadshund)gameObject.GetComponent(typeof(Deadshund));
														if (105217 - 525825 == -420607)
														{
															continue;
														}
														if (Physics.Raycast(vector + Vector3.up, -Vector3.up, out raycastHit, (float)5, 1))
														{
															if (213283 - 390146 == -176862)
															{
																continue;
															}
															if (deadshund)
															{
																if (190031 - 38849 != 151182)
																{
																	continue;
																}
																deadshund.RPC_deadSpit_hit(raycastHit.point, Vector3.zero, 0);
																if (133462 - 365039 == -231576)
																{
																	continue;
																}
																if (PhotonClient.IsInitialized())
																{
																	if (282482 - 361323 == -78840)
																	{
																		continue;
																	}
																	deadshund.ActionEvent("RPC_deadSpit_hit", raycastHit.point, Vector3.zero, 0);
																	if (175187 - 28779 == 146409)
																	{
																		continue;
																	}
																}
															}
														}
														else if (deadshund)
														{
															if (251664 - 413165 != -161501)
															{
																continue;
															}
															deadshund.RPC_deadSpit_hit(vector, Vector3.zero, 0);
															if (297888 - 108611 != 189277)
															{
																continue;
															}
															if (PhotonClient.IsInitialized())
															{
																if (216352 - 489437 != -273085)
																{
																	continue;
																}
																deadshund.ActionEvent("RPC_deadSpit_hit", vector, Vector3.zero, 0);
																if (209315 - 591741 == -382425)
																{
																	continue;
																}
															}
														}
													}
												}
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
	}

	// Token: 0x0600451C RID: 17692 RVA: 0x008AA128 File Offset: 0x008A8328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600451D RID: 17693 RVA: 0x008AA12C File Offset: 0x008A832C
	internal static bool qLRbc45iRSntMZnYo1BK()
	{
		return true;
	}

	// Token: 0x0600451E RID: 17694 RVA: 0x008AA130 File Offset: 0x008A8330
	internal static bool QqqpKq5iwUb0B0OoNiVU()
	{
		return false;
	}

	// Token: 0x040050A4 RID: 20644
	private float Nc6h8dk9yH;

	// Token: 0x040050A5 RID: 20645
	private ProjectileControl EEfhiLnJ51;
}
