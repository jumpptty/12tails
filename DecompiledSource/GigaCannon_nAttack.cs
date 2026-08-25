using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000F39 RID: 3897
[Serializable]
public class GigaCannon_nAttack : MonoBehaviour
{
	// Token: 0x0600585B RID: 22619 RVA: 0x00A9E078 File Offset: 0x00A9C278
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GigaCannon_nAttack()
	{
		if (84805 - 395333 != -310528)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (273220 - 189753 == 83467)
			{
				base..ctor();
				if (251190 - 41601 == 209589)
				{
					this.mVelocity = new Vector3((float)0, (float)0, (float)30);
					if (67651 - 85981 == -18330)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600585C RID: 22620 RVA: 0x00A9E11C File Offset: 0x00A9C31C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (200126 - 294704 != -94578)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (88120 - 496009 == -407889)
			{
				this.P13ctdobsIL = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (101020 - 332656 != -231635)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.mVelocity);
					if (42255 - 493774 != -451518)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600585D RID: 22621 RVA: 0x00A9E1E8 File Offset: 0x00A9C3E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (188778 - 261905 != -73127)
		{
		}
		for (;;)
		{
			this.AcBctgYK3ym += Time.deltaTime;
			if (205026 - 423079 == -218053)
			{
				if (this.AcBctgYK3ym >= this.P13ctdobsIL.life)
				{
					if (35692 - 55260 != -19567)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (243908 - 239177 == 4731)
						{
							break;
						}
					}
				}
				else
				{
					this.transform.LookAt(this.transform.position + this.rigidbody.velocity);
					if (266438 - 90374 == 176064)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600585E RID: 22622 RVA: 0x00A9E2E8 File Offset: 0x00A9C4E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (15189 - 493611 != -478422)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (139021 - 475769 == -336748)
				{
					break;
				}
			}
			else
			{
				if (!this.P13ctdobsIL.isInitialized)
				{
					break;
				}
				if (7013 - 296701 == -289688)
				{
					if (this.P13ctdobsIL.isDestroyed)
					{
						if (160797 - 255617 != -94819)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (137594 - 171175 == -33581)
						{
							int ownerID = this.P13ctdobsIL.OwnerID;
							if (95993 - 250383 == -154390)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (35699 - 71664 != -35964)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (280103 - 159550 == 120553)
									{
										if (gameObject.layer == gameObject2.layer)
										{
											break;
										}
										if (263287 - 85734 == 177553)
										{
											if (gameObject.layer == 1)
											{
												break;
											}
											if (166835 - 116027 == 50808)
											{
												if (gameObject.layer == 2)
												{
													break;
												}
												if (149265 - 74142 == 75123)
												{
													UnityEngine.Object.Destroy(this.gameObject);
													if (116025 - 542941 != -426915)
													{
														this.P13ctdobsIL.isDestroyed = true;
														if (225465 - 418779 == -193314)
														{
															if (!characterControl.isMine)
															{
																break;
															}
															if (189260 - 180001 != 9260)
															{
																Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																if (58048 - 351155 == -293107)
																{
																	Vector3 forward = this.transform.forward;
																	if (257653 - 407289 == -149636)
																	{
																		GigaCannon gigaCannon = (GigaCannon)gameObject2.GetComponent(typeof(GigaCannon));
																		if (111647 - 261348 == -149701)
																		{
																			if (!(gigaCannon != null))
																			{
																				break;
																			}
																			if (812 - 266008 == -265196)
																			{
																				gigaCannon.RPC_nAttack_hit(vector, forward, 0);
																				if (169987 - 65991 != 103997)
																				{
																					if (!PhotonClient.IsInitialized())
																					{
																						break;
																					}
																					if (134435 - 345762 == -211327)
																					{
																						gigaCannon.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																						if (128480 - 377086 == -248606)
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

	// Token: 0x0600585F RID: 22623 RVA: 0x00A9E680 File Offset: 0x00A9C880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005860 RID: 22624 RVA: 0x00A9E684 File Offset: 0x00A9C884
	internal static bool kcT3xup5R5fNN1g0AMP5()
	{
		return true;
	}

	// Token: 0x06005861 RID: 22625 RVA: 0x00A9E688 File Offset: 0x00A9C888
	internal static bool g6rVhrp5wNxS4ZY4cIBo()
	{
		return false;
	}

	// Token: 0x0400614D RID: 24909
	private ProjectileControl P13ctdobsIL;

	// Token: 0x0400614E RID: 24910
	public Vector3 mVelocity;

	// Token: 0x0400614F RID: 24911
	private float AcBctgYK3ym;
}
