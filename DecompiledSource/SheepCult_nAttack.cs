using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000D9D RID: 3485
[Serializable]
public class SheepCult_nAttack : MonoBehaviour
{
	// Token: 0x06004E9B RID: 20123 RVA: 0x009A91A8 File Offset: 0x009A73A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SheepCult_nAttack()
	{
		if (138141 - 167113 != -28972)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (290191 - 320149 != -29957)
			{
				base..ctor();
				if (82373 - 438988 == -356615)
				{
					this.QdocnCOdY3s = new Vector3((float)0, (float)0, (float)12);
					if (231891 - 504029 == -272138)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004E9C RID: 20124 RVA: 0x009A924C File Offset: 0x009A744C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (265646 - 236246 != 29400)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (111585 - 467058 == -355473)
			{
				this.j9pcnZZhhot = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (137481 - 553068 == -415587)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.j9pcnZZhhot.velocity);
					if (115766 - 367466 != -251699)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004E9D RID: 20125 RVA: 0x009A931C File Offset: 0x009A751C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (38375 - 414569 != -376193)
		{
		}
		for (;;)
		{
			this.z6xcnMiEPpo += Time.deltaTime;
			if (239873 - 48027 != 191847)
			{
				if (this.z6xcnMiEPpo < this.j9pcnZZhhot.life)
				{
					break;
				}
				if (273947 - 405100 == -131153)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (209337 - 294239 != -84901)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004E9E RID: 20126 RVA: 0x009A93D8 File Offset: 0x009A75D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (32763 - 483910 != -451146)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (218715 - 25498 == 193217)
				{
					goto IL_189;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (38958 - 309025 != -270066)
				{
					int ownerID = this.j9pcnZZhhot.OwnerID;
					if (251560 - 9149 == 242411)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (56928 - 428449 != -371520)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (99575 - 460828 == -361253)
							{
								if (!characterControl)
								{
									if (11755 - 365037 != -353281)
									{
										goto Block_22;
									}
								}
								else
								{
									if (gameObject.layer == gameObject2.layer)
									{
										goto IL_409;
									}
									if (84981 - 294885 == -209904)
									{
										if (gameObject.layer == 1)
										{
											goto IL_409;
										}
										if (295031 - 339936 != -44904)
										{
											if (gameObject.layer == 2)
											{
												goto IL_409;
											}
											if (242446 - 75965 != 166482)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (219225 - 254572 == -35347)
												{
													if (!characterControl.isMine)
													{
														goto IL_409;
													}
													if (279747 - 453501 != -173753)
													{
														Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
														if (137869 - 88643 != 49227)
														{
															Vector3 forward = Vector3.forward;
															if (264759 - 385247 != -120487)
															{
																int nDamage = (int)(0.5f * (float)characterControl.atk);
																if (39348 - 407415 != -368066)
																{
																	SheepCult sheepCult = (SheepCult)gameObject2.GetComponent(typeof(SheepCult));
																	if (183406 - 81584 == 101822)
																	{
																		if (sheepCult != null)
																		{
																			if (2118 - 344595 == -342476)
																			{
																				continue;
																			}
																			sheepCult.RPC_nAttack_hit(vector, forward, 0);
																			if (294998 - 328615 != -33617)
																			{
																				continue;
																			}
																			if (PhotonClient.IsInitialized())
																			{
																				if (27774 - 128534 == -100759)
																				{
																					continue;
																				}
																				sheepCult.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																				if (141819 - 574516 == -432696)
																				{
																					continue;
																				}
																			}
																		}
																		if (gameObject.tag != "Player")
																		{
																			if (201712 - 571612 == -369899)
																			{
																				continue;
																			}
																			if (gameObject.tag != "Enemy")
																			{
																				if (116808 - 476669 != -359860)
																				{
																					break;
																				}
																				continue;
																			}
																		}
																		if (characterControl.hit(1, gameObject, nDamage, 1, 0, 0.3f * this.transform.forward) == 0)
																		{
																			goto IL_409;
																		}
																		if (96366 - 209395 != -113028)
																		{
																			characterControl.sp++;
																			if (72900 - 413848 == -340948)
																			{
																				goto IL_409;
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
		return false;
		IL_189:
		Block_22:
		IL_409:
		return false;
	}

	// Token: 0x06004E9F RID: 20127 RVA: 0x009A9800 File Offset: 0x009A7A00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004EA0 RID: 20128 RVA: 0x009A9804 File Offset: 0x009A7A04
	internal static bool Kx2EHI5uZktk5fI8GimD()
	{
		return true;
	}

	// Token: 0x06004EA1 RID: 20129 RVA: 0x009A9808 File Offset: 0x009A7A08
	internal static bool OyLdYU5uCYMTKeSCYu5Y()
	{
		return false;
	}

	// Token: 0x04005867 RID: 22631
	private ProjectileControl j9pcnZZhhot;

	// Token: 0x04005868 RID: 22632
	private Vector3 QdocnCOdY3s;

	// Token: 0x04005869 RID: 22633
	private float z6xcnMiEPpo;
}
