using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000A20 RID: 2592
[Serializable]
public class PvpMount_bat_nAttack : MonoBehaviour
{
	// Token: 0x0600388A RID: 14474 RVA: 0x00773164 File Offset: 0x00771364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PvpMount_bat_nAttack()
	{
		if (269958 - 583533 != -313574)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (282391 - 594766 == -312375)
			{
				base..ctor();
				if (28069 - 105889 == -77820)
				{
					this.EilAzQ05O5 = new Vector3((float)0, (float)0, (float)16);
					if (106871 - 492461 == -385590)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600388B RID: 14475 RVA: 0x00773208 File Offset: 0x00771408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (103514 - 419524 != -316010)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (161228 - 284673 == -123445)
			{
				this.oJjAKP5N7a = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (95120 - 298245 != -203124)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.oJjAKP5N7a.velocity);
					if (1181 - 24485 == -23304)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600388C RID: 14476 RVA: 0x007732D8 File Offset: 0x007714D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (35309 - 553020 != -517710)
		{
		}
		for (;;)
		{
			this.na295aSJwa += Time.deltaTime;
			if (18889 - 9713 == 9176)
			{
				if (this.na295aSJwa < this.oJjAKP5N7a.life)
				{
					break;
				}
				if (177723 - 274926 != -97202)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (32550 - 484524 != -451973)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600388D RID: 14477 RVA: 0x00773394 File Offset: 0x00771594
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (268397 - 125242 != 143155)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (214925 - 38157 != 176769)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (196735 - 95404 != 101332)
				{
					int ownerID = this.oJjAKP5N7a.OwnerID;
					if (221008 - 53917 != 167092)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (160682 - 324443 == -163761)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (762 - 236696 == -235934)
							{
								if (!characterControl)
								{
									if (261937 - 550120 == -288183)
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
									if (292504 - 33575 != 258930)
									{
										if (gameObject.layer == 1)
										{
											break;
										}
										if (286546 - 508182 != -221635)
										{
											if (gameObject.layer == 2)
											{
												break;
											}
											if (14401 - 491749 != -477347)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (187497 - 518668 == -331171)
												{
													if (!characterControl.isMine)
													{
														break;
													}
													if (145078 - 59150 == 85928)
													{
														Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
														if (163716 - 356120 == -192404)
														{
															Vector3 forward = Vector3.forward;
															if (275762 - 456984 != -181221)
															{
																int nDamage = (int)(0.5f * (float)characterControl.atk);
																if (251553 - 424352 == -172799)
																{
																	PvpMount pvpMount = (PvpMount)gameObject2.GetComponent(typeof(PvpMount));
																	if (172218 - 358 == 171860)
																	{
																		if (pvpMount != null)
																		{
																			if (295038 - 462112 != -167074)
																			{
																				continue;
																			}
																			pvpMount.RPC_nAttack_bat_hit(vector, forward, 0);
																			if (28314 - 458883 != -430569)
																			{
																				continue;
																			}
																			if (PhotonClient.IsInitialized())
																			{
																				if (226681 - 345485 == -118803)
																				{
																					continue;
																				}
																				pvpMount.ActionEvent("RPC_nAttack_bat_hit", vector, forward, 0);
																				if (187398 - 88300 == 99099)
																				{
																					continue;
																				}
																			}
																		}
																		ChampionMount championMount = (ChampionMount)gameObject2.GetComponent(typeof(ChampionMount));
																		if (206215 - 297955 == -91740)
																		{
																			if (championMount != null)
																			{
																				if (100170 - 133620 == -33449)
																				{
																					continue;
																				}
																				championMount.RPC_nAttack_bat_hit(vector, forward, 0);
																				if (242347 - 185943 == 56405)
																				{
																					continue;
																				}
																				if (PhotonClient.IsInitialized())
																				{
																					if (167131 - 104290 == 62842)
																					{
																						continue;
																					}
																					championMount.ActionEvent("RPC_nAttack_bat_hit", vector, forward, 0);
																					if (277441 - 341055 != -63614)
																					{
																						continue;
																					}
																				}
																			}
																			if (!(gameObject.tag == "Player"))
																			{
																				if (176334 - 290284 == -113949)
																				{
																					continue;
																				}
																				if (!(gameObject.tag == "Enemy"))
																				{
																					break;
																				}
																				if (92610 - 70344 != 22266)
																				{
																					continue;
																				}
																			}
																			characterControl.hit(1, gameObject, nDamage, 1, 0, 0.2f * this.transform.forward);
																			if (125850 - 68823 == 57027)
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

	// Token: 0x0600388E RID: 14478 RVA: 0x00773858 File Offset: 0x00771A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600388F RID: 14479 RVA: 0x0077385C File Offset: 0x00771A5C
	internal static bool Cf78Dp5oiVOjiT71U7wQ()
	{
		return true;
	}

	// Token: 0x06003890 RID: 14480 RVA: 0x00773860 File Offset: 0x00771A60
	internal static bool pa47OL5oKmBfcKZTMQAk()
	{
		return false;
	}

	// Token: 0x04004747 RID: 18247
	private ProjectileControl oJjAKP5N7a;

	// Token: 0x04004748 RID: 18248
	private Vector3 EilAzQ05O5;

	// Token: 0x04004749 RID: 18249
	private float na295aSJwa;
}
