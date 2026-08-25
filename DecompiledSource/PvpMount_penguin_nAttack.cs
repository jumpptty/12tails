using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000A23 RID: 2595
[Serializable]
public class PvpMount_penguin_nAttack : MonoBehaviour
{
	// Token: 0x060038A0 RID: 14496 RVA: 0x00774A44 File Offset: 0x00772C44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PvpMount_penguin_nAttack()
	{
		if (276709 - 524655 != -247946)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (96895 - 449523 == -352628)
			{
				base..ctor();
				if (17626 - 86709 == -69083)
				{
					this.Muu92RMqGD = new Vector3((float)0, (float)0, (float)14);
					if (160491 - 495772 == -335281)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060038A1 RID: 14497 RVA: 0x00774AE8 File Offset: 0x00772CE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (192991 - 519031 != -326040)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (156262 - 216518 != -60255)
			{
				this.wE89Ooif8V = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (205621 - 551083 != -345461)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.Muu92RMqGD);
					if (104179 - 157871 == -53692)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060038A2 RID: 14498 RVA: 0x00774BB4 File Offset: 0x00772DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (274909 - 563289 != -288380)
		{
		}
		for (;;)
		{
			this.a7Q9vi0kR0 += Time.deltaTime;
			if (245732 - 332303 != -86570)
			{
				if (this.a7Q9vi0kR0 < this.wE89Ooif8V.life)
				{
					break;
				}
				if (106737 - 6979 == 99758)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (153733 - 265079 == -111346)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060038A3 RID: 14499 RVA: 0x00774C70 File Offset: 0x00772E70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (298896 - 51139 != 247757)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (140883 - 599271 != -458387)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (25496 - 396799 != -371302)
				{
					int ownerID = this.wE89Ooif8V.OwnerID;
					if (204773 - 424350 == -219577)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (257750 - 370501 != -112750)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (194403 - 556117 != -361713)
							{
								if (!characterControl)
								{
									if (152226 - 12603 == 139623)
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
									if (140982 - 476591 == -335609)
									{
										if (gameObject.layer == 1)
										{
											break;
										}
										if (196625 - 412012 == -215387)
										{
											if (gameObject.layer == 2)
											{
												break;
											}
											if (135271 - 372938 == -237667)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (175990 - 353441 != -177450)
												{
													if (!characterControl.isMine)
													{
														break;
													}
													if (187834 - 211567 == -23733)
													{
														Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
														if (240264 - 101816 == 138448)
														{
															Vector3 forward = this.transform.forward;
															if (79241 - 440157 != -360915)
															{
																int nDamage = (int)(0.5f * (float)characterControl.atk);
																if (191915 - 51322 != 140594)
																{
																	PvpMount pvpMount = (PvpMount)gameObject2.GetComponent(typeof(PvpMount));
																	if (280889 - 245709 == 35180)
																	{
																		if (pvpMount != null)
																		{
																			if (282899 - 347805 == -64905)
																			{
																				continue;
																			}
																			pvpMount.RPC_nAttack_penguin_hit(vector, forward, 0);
																			if (246324 - 226113 == 20212)
																			{
																				continue;
																			}
																			if (PhotonClient.IsInitialized())
																			{
																				if (62081 - 275023 != -212942)
																				{
																					continue;
																				}
																				pvpMount.ActionEvent("RPC_nAttack_penguin_hit", vector, forward, 0);
																				if (239168 - 127908 != 111260)
																				{
																					continue;
																				}
																			}
																		}
																		ChampionMount championMount = (ChampionMount)gameObject2.GetComponent(typeof(ChampionMount));
																		if (230232 - 416535 == -186303)
																		{
																			if (championMount != null)
																			{
																				if (27019 - 249526 == -222506)
																				{
																					continue;
																				}
																				championMount.RPC_nAttack_penguin_hit(vector, forward, 0);
																				if (227495 - 390715 == -163219)
																				{
																					continue;
																				}
																				if (PhotonClient.IsInitialized())
																				{
																					if (269355 - 112180 == 157176)
																					{
																						continue;
																					}
																					championMount.ActionEvent("RPC_nAttack_penguin_hit", vector, forward, 0);
																					if (98887 - 293627 == -194739)
																					{
																						continue;
																					}
																				}
																			}
																			if (!(gameObject.tag == "Player"))
																			{
																				if (9722 - 186809 != -177087)
																				{
																					continue;
																				}
																				if (!(gameObject.tag == "Enemy"))
																				{
																					break;
																				}
																				if (56469 - 240513 == -184043)
																				{
																					continue;
																				}
																			}
																			if (characterControl.hit(1, gameObject, nDamage, 1, 0, 0.3f * this.transform.forward) == 0)
																			{
																				break;
																			}
																			if (281844 - 448648 == -166804)
																			{
																				CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																				if (44420 - 512425 != -468004)
																				{
																					if (!characterControl2)
																					{
																						break;
																					}
																					if (7816 - 70082 != -62265)
																					{
																						int num = Mathf.Clamp(characterControl2.getStatusLv("ice") + 1, 1, 4);
																						if (286751 - 397770 == -111019)
																						{
																							characterControl2.RPC_AddStatus("ice", num, Damage.getDebuff((float)3, characterControl.cha, characterControl2.cha), 0, characterControl.ActorNr);
																							if (154092 - 581675 == -427583)
																							{
																								Camera.main.SendMessage("newGameMessage", "Ice" + num + "!");
																								if (60008 - 152865 == -92857)
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
	}

	// Token: 0x060038A4 RID: 14500 RVA: 0x0077524C File Offset: 0x0077344C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060038A5 RID: 14501 RVA: 0x00775250 File Offset: 0x00773450
	internal static bool hMdwmq5oRXpvZ21eSCao()
	{
		return true;
	}

	// Token: 0x060038A6 RID: 14502 RVA: 0x00775254 File Offset: 0x00773454
	internal static bool Aolo2q5owYILm5fs2GdT()
	{
		return false;
	}

	// Token: 0x04004753 RID: 18259
	private ProjectileControl wE89Ooif8V;

	// Token: 0x04004754 RID: 18260
	private Vector3 Muu92RMqGD;

	// Token: 0x04004755 RID: 18261
	private float a7Q9vi0kR0;
}
