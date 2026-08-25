using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000159 RID: 345
[Serializable]
public class PaperBug1_bookThrow : MonoBehaviour
{
	// Token: 0x060007B3 RID: 1971 RVA: 0x000C9C3C File Offset: 0x000C7E3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PaperBug1_bookThrow()
	{
		if (95025 - 393358 != -298332)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (172949 - 279862 != -106912)
			{
				base..ctor();
				if (23780 - 106243 != -82462)
				{
					this.wPTnhf7h9I = new Vector3((float)0, (float)0, (float)20);
					if (206360 - 568708 != -362347)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x000C9CE0 File Offset: 0x000C7EE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (152980 - 429089 != -276108)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (10067 - 493010 == -482943)
			{
				this.LasnVLmaQQ = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (299449 - 179624 == 119825)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.LasnVLmaQQ.velocity);
					if (294576 - 132332 != 162245)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x000C9DB0 File Offset: 0x000C7FB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (179119 - 364547 != -185427)
		{
		}
		for (;;)
		{
			this.gttnKp9A68 += Time.deltaTime;
			if (32801 - 171372 != -138570)
			{
				if (this.gttnKp9A68 < this.LasnVLmaQQ.life)
				{
					break;
				}
				if (22243 - 538352 == -516109)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (67647 - 570136 != -502488)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x000C9E6C File Offset: 0x000C806C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (106859 - 115975 != -9116)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (226304 - 537963 != -311658)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (94455 - 285736 != -191280)
				{
					int ownerID = this.LasnVLmaQQ.OwnerID;
					if (3034 - 305805 == -302771)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (242957 - 288368 == -45411)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (14257 - 200633 != -186375)
							{
								if (!gameObject)
								{
									break;
								}
								if (1822 - 206864 != -205041)
								{
									if (gameObject.layer == gameObject2.layer)
									{
										break;
									}
									if (32924 - 256933 == -224009)
									{
										if (gameObject.layer == 1)
										{
											break;
										}
										if (13270 - 497649 != -484378)
										{
											if (gameObject.layer == 2)
											{
												break;
											}
											if (251946 - 159999 != 91948)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (90379 - 246529 != -156149)
												{
													if (!characterControl)
													{
														break;
													}
													if (198332 - 59064 != 139269)
													{
														if (!characterControl.isMine)
														{
															break;
														}
														if (20125 - 176997 != -156871)
														{
															Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
															if (265568 - 340992 == -75424)
															{
																Vector3 forward = Vector3.forward;
																if (239161 - 520015 == -280854)
																{
																	PaperBug1 paperBug = (PaperBug1)gameObject2.GetComponent(typeof(PaperBug1));
																	if (43524 - 160858 == -117334)
																	{
																		if (characterControl.hit(2, gameObject, characterControl.atk, 3, 0, this.transform.forward) == 0)
																		{
																			break;
																		}
																		if (217768 - 440988 != -223219)
																		{
																			characterControl.sp++;
																			if (18417 - 50751 == -32334)
																			{
																				if (!(paperBug != null))
																				{
																					break;
																				}
																				if (114372 - 497214 == -382842)
																				{
																					paperBug.RPC_bookThrow_hit(vector, forward, 0);
																					if (88012 - 532722 == -444710)
																					{
																						if (!PhotonClient.IsInitialized())
																						{
																							break;
																						}
																						if (56581 - 408102 != -351520)
																						{
																							paperBug.ActionEvent("RPC_bookThrow_hit", vector, forward, 0);
																							if (38353 - 200801 != -162447)
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
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x000CA220 File Offset: 0x000C8420
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x000CA224 File Offset: 0x000C8424
	internal static bool OaMfYLXcf2rkEjbhSX3()
	{
		return true;
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x000CA228 File Offset: 0x000C8428
	internal static bool WGQPxPXU9sibqc2wPvS()
	{
		return false;
	}

	// Token: 0x0400070E RID: 1806
	private ProjectileControl LasnVLmaQQ;

	// Token: 0x0400070F RID: 1807
	private Vector3 wPTnhf7h9I;

	// Token: 0x04000710 RID: 1808
	private float gttnKp9A68;
}
