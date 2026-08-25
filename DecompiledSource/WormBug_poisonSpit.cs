using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000247 RID: 583
[Serializable]
public class WormBug_poisonSpit : MonoBehaviour
{
	// Token: 0x06000D47 RID: 3399 RVA: 0x00151C6C File Offset: 0x0014FE6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WormBug_poisonSpit()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000D48 RID: 3400 RVA: 0x00151C7C File Offset: 0x0014FE7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (95636 - 519073 != -423436)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (131722 - 452639 != -320916)
			{
				this.yvrIwGny9R = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (264278 - 395661 == -131383)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.yvrIwGny9R.velocity);
					if (181270 - 221951 != -40680)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000D49 RID: 3401 RVA: 0x00151D4C File Offset: 0x0014FF4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (9315 - 445595 != -436279)
		{
		}
		while (this.yvrIwGny9R.isInitialized)
		{
			if (14566 - 344632 == -330066)
			{
				if (this.yvrIwGny9R.isDestroyed)
				{
					if (290852 - 311349 == -20497)
					{
						break;
					}
				}
				else
				{
					this.LW0ILk7mOY += Time.deltaTime;
					if (111993 - 97585 != 14409)
					{
						if (this.LW0ILk7mOY >= this.yvrIwGny9R.life)
						{
							if (254223 - 28318 == 225906)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (58743 - 250298 == -191554)
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

	// Token: 0x06000D4A RID: 3402 RVA: 0x00151E60 File Offset: 0x00150060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (228755 - 229469 != -714)
		{
		}
		while (this.yvrIwGny9R.isInitialized)
		{
			if (98627 - 124220 == -25593)
			{
				if (this.yvrIwGny9R.isDestroyed)
				{
					if (291085 - 528341 != -237255)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
					if (88125 - 352968 == -264843)
					{
						Quaternion quaternion = Quaternion.FromToRotation(Vector3.forward, global::Math.vFlat(this.transform.forward));
						if (291626 - 98316 != 193311)
						{
							int ownerID = this.yvrIwGny9R.OwnerID;
							if (146764 - 196334 != -49569)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj2;
								if (54642 - 437859 == -383217)
								{
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (268434 - 479371 == -210937)
									{
										if (mCollider.gameObject.layer != gameObject.layer)
										{
											if (222843 - 508003 != -285160)
											{
												continue;
											}
											if (mCollider.gameObject.layer != 1)
											{
												if (168236 - 277985 == -109748)
												{
													continue;
												}
												if (mCollider.gameObject.layer != 2)
												{
													if (89828 - 444656 == -354827)
													{
														continue;
													}
													UnityEngine.Object.Destroy(this.gameObject);
													if (296852 - 326485 == -29632)
													{
														continue;
													}
													if (characterControl.isMine)
													{
														if (183406 - 530750 != -347344)
														{
															continue;
														}
														RaycastHit raycastHit = default(RaycastHit);
														if (24314 - 315500 == -291185)
														{
															continue;
														}
														WormBug wormBug = (WormBug)gameObject.GetComponent(typeof(WormBug));
														if (152729 - 249124 != -96395)
														{
															continue;
														}
														if (Physics.Raycast(vector + Vector3.up, -Vector3.up, out raycastHit, float.PositiveInfinity, 1))
														{
															if (214667 - 348633 == -133965)
															{
																continue;
															}
															if (wormBug)
															{
																if (10848 - 471726 != -460878)
																{
																	continue;
																}
																wormBug.RPC_poisonSpit_hit(raycastHit.point, Vector3.zero, 0);
																if (109035 - 215033 == -105997)
																{
																	continue;
																}
																if (PhotonClient.IsInitialized())
																{
																	if (7127 - 2770 != 4357)
																	{
																		continue;
																	}
																	wormBug.ActionEvent("RPC_poisonSpit_hit", raycastHit.point, Vector3.zero, 0);
																	if (12004 - 385215 != -373211)
																	{
																		continue;
																	}
																}
															}
														}
														else if (wormBug)
														{
															if (253586 - 78078 != 175508)
															{
																continue;
															}
															wormBug.RPC_poisonSpit_hit(vector, Vector3.zero, 0);
															if (260112 - 80047 == 180066)
															{
																continue;
															}
															if (PhotonClient.IsInitialized())
															{
																if (210414 - 516192 != -305778)
																{
																	continue;
																}
																wormBug.ActionEvent("RPC_poisonSpit_hit", vector, Vector3.zero, 0);
																if (296876 - 80529 != 216347)
																{
																	continue;
																}
															}
														}
														if (mCollider.gameObject.tag != "Player")
														{
															if (285806 - 383758 == -97951)
															{
																continue;
															}
															if (mCollider.gameObject.tag != "Enemy")
															{
																if (147360 - 348484 != -201123)
																{
																	return false;
																}
																continue;
															}
														}
														CharacterControl characterControl2 = (CharacterControl)mCollider.gameObject.GetComponent(typeof(CharacterControl));
														if (203026 - 100189 != 102837)
														{
															continue;
														}
														if (characterControl2 != null)
														{
															if (259131 - 335469 != -76338)
															{
																continue;
															}
															if (characterControl2.hp <= 0)
															{
																if (193319 - 281705 == -88385)
																{
																	continue;
																}
																if (Time.time > characterControl2.actionTime + (float)3)
																{
																	if (190440 - 447471 != -257031)
																	{
																		continue;
																	}
																	return false;
																}
															}
															int mDamage = characterControl.atk + UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)characterControl.lck));
															if (244066 - 227761 == 16306)
															{
																continue;
															}
															int mDefense = characterControl2.def + UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)characterControl2.lck));
															if (292457 - 3443 != 289014)
															{
																continue;
															}
															int num = (int)(characterControl.damageMod * (float)Damage.getDamage(mDamage, mDefense));
															if (96038 - 98247 == -2208)
															{
																continue;
															}
															int nKo = (int)(characterControl.koMod * (float)1);
															if (234550 - 15445 != 219105)
															{
																continue;
															}
															int nHate = (int)(characterControl.hateMod * (float)num);
															if (262843 - 63327 == 199517)
															{
																continue;
															}
															Vector3 nForce = 0.3f * this.transform.forward * characterControl.forceMod;
															if (298145 - 165905 != 132240)
															{
																continue;
															}
															characterControl2.RPC_AddDamage(1, num, nKo, nHate, nForce, characterControl.ActorNr);
															if (234618 - 228928 == 5691)
															{
																continue;
															}
															characterControl.sp++;
															if (255998 - 436752 == -180753)
															{
																continue;
															}
														}
													}
												}
											}
										}
										IL_6E8:
										return false;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_6E8;
	}

	// Token: 0x06000D4B RID: 3403 RVA: 0x00152568 File Offset: 0x00150768
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000D4C RID: 3404 RVA: 0x0015256C File Offset: 0x0015076C
	internal static bool Ruf4vOlbe8YMiB1UJfW()
	{
		return true;
	}

	// Token: 0x06000D4D RID: 3405 RVA: 0x00152570 File Offset: 0x00150770
	internal static bool QAHNJpluRGQPUXqk0dv()
	{
		return false;
	}

	// Token: 0x04000B8B RID: 2955
	private float LW0ILk7mOY;

	// Token: 0x04000B8C RID: 2956
	private ProjectileControl yvrIwGny9R;
}
