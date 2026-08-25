using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000A24 RID: 2596
[Serializable]
public class PvpMount_sheep_nAttack : MonoBehaviour
{
	// Token: 0x060038A7 RID: 14503 RVA: 0x00775258 File Offset: 0x00773458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PvpMount_sheep_nAttack()
	{
		if (135343 - 524046 != -388702)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (260265 - 224580 == 35685)
			{
				base..ctor();
				if (36428 - 295729 != -259300)
				{
					this.zYR91g075S = new Vector3((float)0, (float)0, (float)8);
					if (100638 - 538748 == -438110)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060038A8 RID: 14504 RVA: 0x007752FC File Offset: 0x007734FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (169760 - 118432 != 51329)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (132368 - 18749 == 113619)
			{
				this.sOA9GvF4OP = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (217098 - 251445 != -34346)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.zYR91g075S);
					if (179444 - 109644 == 69800)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060038A9 RID: 14505 RVA: 0x007753C8 File Offset: 0x007735C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject tObject)
	{
		if (tObject)
		{
			this.y2G9pAFhFb = tObject;
		}
	}

	// Token: 0x060038AA RID: 14506 RVA: 0x007753DC File Offset: 0x007735DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (127843 - 455471 != -327627)
		{
		}
		for (;;)
		{
			this.Gha9qAeOYk += Time.deltaTime;
			if (147118 - 408577 != -261458)
			{
				if (this.Gha9qAeOYk >= this.sOA9GvF4OP.life)
				{
					if (121645 - 183098 != -61453)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (30020 - 41762 == -11741)
					{
						continue;
					}
				}
				if (!this.y2G9pAFhFb)
				{
					break;
				}
				if (124624 - 307321 == -182697)
				{
					if (this.v9D9lgfVEa >= Time.time)
					{
						break;
					}
					if (99839 - 587490 != -487650)
					{
						this.v9D9lgfVEa = Time.time + 0.1f;
						if (202221 - 251928 == -49707)
						{
							Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.y2G9pAFhFb.collider.bounds.center - this.transform.position, 0.1f, 1f);
							if (93650 - 230628 == -136978)
							{
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (19448 - 30574 == -11126)
								{
									this.rigidbody.velocity = this.transform.TransformDirection(this.zYR91g075S);
									if (260290 - 25132 != 235159)
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

	// Token: 0x060038AB RID: 14507 RVA: 0x007755D4 File Offset: 0x007737D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (27923 - 227620 != -199696)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (212606 - 144265 == 68341)
				{
					break;
				}
			}
			else
			{
				if (!this.sOA9GvF4OP.isInitialized)
				{
					break;
				}
				if (178109 - 164376 == 13733)
				{
					if (this.sOA9GvF4OP.isDestroyed)
					{
						if (15259 - 299860 != -284600)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (286221 - 493361 != -207139)
						{
							int ownerID = this.sOA9GvF4OP.OwnerID;
							if (284042 - 579556 != -295513)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (245698 - 119983 != 125716)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (268206 - 284951 == -16745)
									{
										if (!characterControl)
										{
											if (97140 - 156144 == -59004)
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
											if (279019 - 359396 == -80377)
											{
												if (gameObject.layer == 1)
												{
													break;
												}
												if (154508 - 399038 != -244529)
												{
													if (gameObject.layer == 2)
													{
														break;
													}
													if (29388 - 216881 == -187493)
													{
														UnityEngine.Object.Destroy(this.gameObject);
														if (42559 - 367686 == -325127)
														{
															this.sOA9GvF4OP.isDestroyed = true;
															if (37828 - 334803 == -296975)
															{
																if (!characterControl.isMine)
																{
																	break;
																}
																if (38651 - 149208 != -110556)
																{
																	Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																	if (172178 - 246181 != -74002)
																	{
																		Vector3 forward = this.transform.forward;
																		if (210674 - 166280 != 44395)
																		{
																			PvpMount pvpMount = (PvpMount)gameObject2.GetComponent(typeof(PvpMount));
																			if (212305 - 120334 != 91972)
																			{
																				if (pvpMount != null)
																				{
																					if (57076 - 494427 != -437351)
																					{
																						continue;
																					}
																					pvpMount.RPC_nAttack_sheep_hit(vector, forward, 0);
																					if (119615 - 567928 == -448312)
																					{
																						continue;
																					}
																					if (PhotonClient.IsInitialized())
																					{
																						if (112067 - 403837 != -291770)
																						{
																							continue;
																						}
																						pvpMount.ActionEvent("RPC_nAttack_sheep_hit", vector, forward, 0);
																						if (287064 - 392487 != -105423)
																						{
																							continue;
																						}
																					}
																				}
																				ChampionMount championMount = (ChampionMount)gameObject2.GetComponent(typeof(ChampionMount));
																				if (35321 - 213347 != -178025)
																				{
																					if (championMount != null)
																					{
																						if (135919 - 181715 == -45795)
																						{
																							continue;
																						}
																						championMount.RPC_nAttack_sheep_hit(vector, forward, 0);
																						if (20611 - 306264 == -285652)
																						{
																							continue;
																						}
																						if (PhotonClient.IsInitialized())
																						{
																							if (107160 - 598898 != -491738)
																							{
																								continue;
																							}
																							championMount.ActionEvent("RPC_nAttack_sheep_hit", vector, forward, 0);
																							if (79583 - 343623 == -264039)
																							{
																								continue;
																							}
																						}
																					}
																					if (gameObject.tag != "Player")
																					{
																						if (17909 - 15927 == 1983)
																						{
																							continue;
																						}
																						if (gameObject.tag != "Enemy")
																						{
																							if (24371 - 208300 != -183928)
																							{
																								goto Block_42;
																							}
																							continue;
																						}
																					}
																					if (characterControl.hit(1, gameObject, (int)(1.5f * (float)characterControl.atk), 1, 0, 0.3f * this.transform.forward) == 0)
																					{
																						break;
																					}
																					if (163346 - 597989 != -434642)
																					{
																						characterControl.sp++;
																						if (122369 - 599787 != -477417)
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
		goto IL_53D;
		Block_42:
		return false;
		IL_53D:
		return false;
	}

	// Token: 0x060038AC RID: 14508 RVA: 0x00775B30 File Offset: 0x00773D30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060038AD RID: 14509 RVA: 0x00775B34 File Offset: 0x00773D34
	internal static bool Oiq6Zh5oq142GOf4Q8Ij()
	{
		return true;
	}

	// Token: 0x060038AE RID: 14510 RVA: 0x00775B38 File Offset: 0x00773D38
	internal static bool rBXOa65o7usT1aWFFle0()
	{
		return false;
	}

	// Token: 0x04004756 RID: 18262
	private float v9D9lgfVEa;

	// Token: 0x04004757 RID: 18263
	private ProjectileControl sOA9GvF4OP;

	// Token: 0x04004758 RID: 18264
	private Vector3 zYR91g075S;

	// Token: 0x04004759 RID: 18265
	private float Gha9qAeOYk;

	// Token: 0x0400475A RID: 18266
	private GameObject y2G9pAFhFb;
}
