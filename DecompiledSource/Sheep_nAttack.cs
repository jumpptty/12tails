using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020008D4 RID: 2260
[Serializable]
public class Sheep_nAttack : MonoBehaviour
{
	// Token: 0x060031BB RID: 12731 RVA: 0x00652B14 File Offset: 0x00650D14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sheep_nAttack()
	{
		if (152968 - 258426 != -105458)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (112042 - 358188 == -246146)
			{
				base..ctor();
				if (228460 - 291754 == -63294)
				{
					this.FhfBNgB2lM = new Vector3((float)0, (float)0, (float)12);
					if (20585 - 180301 != -159715)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060031BC RID: 12732 RVA: 0x00652BB8 File Offset: 0x00650DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (192606 - 561038 != -368432)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (62653 - 177043 == -114390)
			{
				this.Af7BUjwpID = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (199519 - 94853 == 104666)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.Af7BUjwpID.velocity);
					if (58870 - 349572 != -290701)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060031BD RID: 12733 RVA: 0x00652C88 File Offset: 0x00650E88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (72431 - 124476 != -52044)
		{
		}
		for (;;)
		{
			this.yoVBEbl8Dk += Time.deltaTime;
			if (144492 - 114522 == 29970)
			{
				if (this.yoVBEbl8Dk < this.Af7BUjwpID.life)
				{
					break;
				}
				if (194062 - 432312 == -238250)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (220291 - 494059 != -273767)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060031BE RID: 12734 RVA: 0x00652D44 File Offset: 0x00650F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (129625 - 451085 != -321460)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (289986 - 263999 == 25987)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (30905 - 171898 != -140992)
				{
					int ownerID = this.Af7BUjwpID.OwnerID;
					if (89021 - 401664 != -312642)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (80269 - 429797 != -349527)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (93956 - 555447 != -461490)
							{
								if (!characterControl)
								{
									if (77851 - 286933 != -209081)
									{
										break;
									}
								}
								else
								{
									Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
									if (128976 - 214503 != -85526)
									{
										Vector3 forward = Vector3.forward;
										if (130120 - 286999 != -156878)
										{
											int num = (int)(0.5f * (float)characterControl.atk);
											if (82196 - 228642 != -146445)
											{
												if (characterControl.weapon == "w_shp59")
												{
													if (275753 - 331832 != -56079)
													{
														continue;
													}
													num = Mathf.FloorToInt(0.75f * (float)num);
													if (70511 - 404033 != -333522)
													{
														continue;
													}
												}
												if (characterControl.weapon == "w_shp59")
												{
													if (189383 - 451870 != -262487)
													{
														continue;
													}
													if (gameObject != gameObject2)
													{
														if (57826 - 181878 == -124051)
														{
															continue;
														}
														if (gameObject.layer == gameObject2.layer)
														{
															if (195202 - 199998 != -4796)
															{
																continue;
															}
															UnityEngine.Object.Destroy(this.gameObject);
															if (187826 - 344759 != -156933)
															{
																continue;
															}
															if (!characterControl.isMine)
															{
																break;
															}
															if (27853 - 331815 == -303961)
															{
																continue;
															}
															CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
															if (287357 - 466694 != -179337)
															{
																continue;
															}
															characterControl2.RPC_AddHeal(1, (int)(0.35f * (float)characterControl.atk), 0, 0, 0, 0, characterControl.ActorNr);
															if (55864 - 248865 != -193001)
															{
																continue;
															}
															Sheep sheep = (Sheep)gameObject2.GetComponent(typeof(Sheep));
															if (18547 - 297354 == -278806)
															{
																continue;
															}
															sheep.RPC_nAttack_hit(vector, forward, 0);
															if (56022 - 445921 == -389898)
															{
																continue;
															}
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (61462 - 247065 == -185602)
															{
																continue;
															}
															sheep.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
															if (295036 - 212710 != 82326)
															{
																continue;
															}
															break;
														}
													}
												}
												if (gameObject.layer == gameObject2.layer)
												{
													break;
												}
												if (177798 - 271251 != -93452)
												{
													if (gameObject.layer == 1)
													{
														break;
													}
													if (256966 - 319861 != -62894)
													{
														if (gameObject.layer == 2)
														{
															break;
														}
														if (193898 - 164630 != 29269)
														{
															UnityEngine.Object.Destroy(this.gameObject);
															if (226642 - 472553 != -245910)
															{
																if (!characterControl.isMine)
																{
																	break;
																}
																if (36619 - 547271 != -510651)
																{
																	Sheep sheep2 = (Sheep)gameObject2.GetComponent(typeof(Sheep));
																	if (47766 - 475060 == -427294)
																	{
																		if (sheep2 != null)
																		{
																			if (175568 - 398006 == -222437)
																			{
																				continue;
																			}
																			num = sheep2.getCritPlus(num);
																			if (151100 - 356638 != -205538)
																			{
																				continue;
																			}
																			sheep2.RPC_nAttack_hit(vector, forward, 0);
																			if (163134 - 319705 != -156571)
																			{
																				continue;
																			}
																			if (PhotonClient.IsInitialized())
																			{
																				if (157426 - 391712 == -234285)
																				{
																					continue;
																				}
																				sheep2.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																				if (145163 - 184271 == -39107)
																				{
																					continue;
																				}
																			}
																		}
																		if (gameObject.tag != "Player")
																		{
																			if (71532 - 444312 != -372780)
																			{
																				continue;
																			}
																			if (gameObject.tag != "Enemy")
																			{
																				if (254440 - 415175 != -160734)
																				{
																					goto Block_17;
																				}
																				continue;
																			}
																		}
																		if (characterControl.hit(1, gameObject, num, 1, 0, 0.3f * this.transform.forward) == 0)
																		{
																			break;
																		}
																		if (295509 - 520461 == -224952)
																		{
																			if (sheep2)
																			{
																				if (146986 - 504129 == -357142)
																				{
																					continue;
																				}
																				sheep2.StartCoroutine_Auto(sheep2.onNormalAttackHit(gameObject));
																				if (100762 - 167884 != -67122)
																				{
																					continue;
																				}
																			}
																			characterControl.sp++;
																			if (52759 - 389535 != -336775)
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
		goto IL_6B7;
		Block_17:
		return false;
		IL_6B7:
		return false;
	}

	// Token: 0x060031BF RID: 12735 RVA: 0x0065341C File Offset: 0x0065161C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060031C0 RID: 12736 RVA: 0x00653420 File Offset: 0x00651620
	internal static bool j7JTZE53j0p4Dp3H8pol()
	{
		return true;
	}

	// Token: 0x060031C1 RID: 12737 RVA: 0x00653424 File Offset: 0x00651624
	internal static bool A4Qx5753heSH3WKLqiMh()
	{
		return false;
	}

	// Token: 0x04003C18 RID: 15384
	private ProjectileControl Af7BUjwpID;

	// Token: 0x04003C19 RID: 15385
	private Vector3 FhfBNgB2lM;

	// Token: 0x04003C1A RID: 15386
	private float yoVBEbl8Dk;
}
