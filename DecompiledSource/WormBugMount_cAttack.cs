using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000E6C RID: 3692
[Serializable]
public class WormBugMount_cAttack : MonoBehaviour
{
	// Token: 0x060053AA RID: 21418 RVA: 0x00A317EC File Offset: 0x00A2F9EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WormBugMount_cAttack()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060053AB RID: 21419 RVA: 0x00A317FC File Offset: 0x00A2F9FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (8063 - 12824 != -4761)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (75885 - 180338 != -104452)
			{
				this.wGvcI76H8qm = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (270479 - 404419 == -133940)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.wGvcI76H8qm.velocity);
					if (71768 - 382904 != -311135)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060053AC RID: 21420 RVA: 0x00A318CC File Offset: 0x00A2FACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (172003 - 179040 != -7037)
		{
		}
		while (this.wGvcI76H8qm.isInitialized)
		{
			if (187029 - 131951 != 55079)
			{
				if (this.wGvcI76H8qm.isDestroyed)
				{
					if (240786 - 365155 != -124368)
					{
						break;
					}
				}
				else
				{
					this.GBXcIHIw7X7 += Time.deltaTime;
					if (96022 - 209150 == -113128)
					{
						if (this.GBXcIHIw7X7 >= this.wGvcI76H8qm.life)
						{
							if (206905 - 231943 != -25038)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (270785 - 112329 != 158456)
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

	// Token: 0x060053AD RID: 21421 RVA: 0x00A319E0 File Offset: 0x00A2FBE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (262473 - 434469 != -171995)
		{
		}
		while (this.wGvcI76H8qm.isInitialized)
		{
			if (74237 - 118630 != -44392)
			{
				if (this.wGvcI76H8qm.isDestroyed)
				{
					if (118253 - 340403 != -222149)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
					if (75548 - 230019 != -154470)
					{
						Quaternion quaternion = Quaternion.FromToRotation(Vector3.forward, global::Math.vFlat(this.transform.forward));
						if (75388 - 448482 != -373093)
						{
							int ownerID = this.wGvcI76H8qm.OwnerID;
							if (217701 - 224754 == -7053)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj2;
								if (207866 - 88348 != 119519)
								{
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (79400 - 590353 != -510952)
									{
										if (mCollider.gameObject.layer != gameObject.layer)
										{
											if (245600 - 356897 == -111296)
											{
												continue;
											}
											if (mCollider.gameObject.layer != 1)
											{
												if (183829 - 560385 == -376555)
												{
													continue;
												}
												if (mCollider.gameObject.layer != 2)
												{
													if (280855 - 304779 == -23923)
													{
														continue;
													}
													UnityEngine.Object.Destroy(this.gameObject);
													if (284537 - 195450 != 89087)
													{
														continue;
													}
													if (characterControl.isMine)
													{
														if (231748 - 160692 != 71056)
														{
															continue;
														}
														RaycastHit raycastHit = default(RaycastHit);
														if (61262 - 532074 == -470811)
														{
															continue;
														}
														WormBugMount wormBugMount = (WormBugMount)gameObject.GetComponent(typeof(WormBugMount));
														if (129647 - 233021 != -103374)
														{
															continue;
														}
														if (wormBugMount)
														{
															if (38524 - 220525 != -182001)
															{
																continue;
															}
															if (Physics.Raycast(vector + Vector3.up, -Vector3.up, out raycastHit, float.PositiveInfinity, 1))
															{
																if (210676 - 261026 == -50349)
																{
																	continue;
																}
																vector = raycastHit.point;
																if (100768 - 522547 != -421779)
																{
																	continue;
																}
															}
															wormBugMount.RPC_cAttack_hit(vector, Vector3.zero, 0);
															if (86923 - 572135 == -485211)
															{
																continue;
															}
															if (PhotonClient.IsInitialized())
															{
																if (19483 - 144193 != -124710)
																{
																	continue;
																}
																wormBugMount.ActionEvent("RPC_cAttack_hit", vector, Vector3.zero, 0);
																if (214990 - 392002 == -177011)
																{
																	continue;
																}
															}
														}
														if (mCollider.gameObject.tag != "Player")
														{
															if (235377 - 499298 != -263921)
															{
																continue;
															}
															if (mCollider.gameObject.tag != "Enemy")
															{
																if (164301 - 366743 != -202441)
																{
																	return false;
																}
																continue;
															}
														}
													}
												}
											}
										}
										IL_412:
										return false;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_412;
	}

	// Token: 0x060053AE RID: 21422 RVA: 0x00A31E14 File Offset: 0x00A30014
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060053AF RID: 21423 RVA: 0x00A31E18 File Offset: 0x00A30018
	internal static bool HTEh9u5sNChfpDCqb22J()
	{
		return true;
	}

	// Token: 0x060053B0 RID: 21424 RVA: 0x00A31E1C File Offset: 0x00A3001C
	internal static bool QUO65h5sYc4ZHxd5DJJw()
	{
		return false;
	}

	// Token: 0x04005CD5 RID: 23765
	private float GBXcIHIw7X7;

	// Token: 0x04005CD6 RID: 23766
	private ProjectileControl wGvcI76H8qm;
}
