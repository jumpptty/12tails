using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200013A RID: 314
[Serializable]
public class NinjaBug_knife_knife : MonoBehaviour
{
	// Token: 0x060006FE RID: 1790 RVA: 0x000B87D0 File Offset: 0x000B69D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NinjaBug_knife_knife()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x000B87E0 File Offset: 0x000B69E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (71018 - 181772 != -110754)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (38990 - 484453 == -445463)
			{
				this.SeVnS9KKEx = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (63360 - 138669 == -75309)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.SeVnS9KKEx.velocity);
					if (54042 - 337766 != -283723)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x000B88B0 File Offset: 0x000B6AB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (236785 - 277581 != -40796)
		{
		}
		while (this.SeVnS9KKEx.isInitialized)
		{
			if (117509 - 518118 == -400609)
			{
				if (this.SeVnS9KKEx.isDestroyed)
				{
					if (202496 - 586235 == -383739)
					{
						break;
					}
				}
				else
				{
					this.CUhnPHDkRg += Time.deltaTime;
					if (34499 - 488414 == -453915)
					{
						if (this.CUhnPHDkRg >= this.SeVnS9KKEx.life)
						{
							if (233736 - 220375 == 13362)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (243199 - 406180 != -162981)
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

	// Token: 0x06000701 RID: 1793 RVA: 0x000B89C4 File Offset: 0x000B6BC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (221104 - 331496 != -110392)
		{
		}
		while (this.SeVnS9KKEx.isInitialized)
		{
			if (26357 - 480360 != -454002)
			{
				if (this.SeVnS9KKEx.isDestroyed)
				{
					if (45554 - 524083 == -478529)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
					if (276402 - 114272 == 162130)
					{
						Quaternion quaternion = Quaternion.FromToRotation(Vector3.forward, global::Math.vFlat(this.transform.forward));
						if (141805 - 271967 != -130161)
						{
							int ownerID = this.SeVnS9KKEx.OwnerID;
							if (55225 - 210134 != -154908)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj2;
								if (114836 - 182510 != -67673)
								{
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (4882 - 351825 != -346942)
									{
										if (mCollider.gameObject.layer != gameObject.layer)
										{
											if (4834 - 197209 == -192374)
											{
												continue;
											}
											if (mCollider.gameObject.layer != 1)
											{
												if (33695 - 60239 == -26543)
												{
													continue;
												}
												if (mCollider.gameObject.layer != 2)
												{
													if (57310 - 102189 == -44878)
													{
														continue;
													}
													UnityEngine.Object.Destroy(this.gameObject);
													if (262667 - 553308 != -290641)
													{
														continue;
													}
													if (characterControl.isMine)
													{
														if (40665 - 541808 == -501142)
														{
															continue;
														}
														NinjaBug ninjaBug = (NinjaBug)gameObject.GetComponent(typeof(NinjaBug));
														if (252488 - 246000 != 6488)
														{
															continue;
														}
														if (ninjaBug != null)
														{
															if (247151 - 379962 != -132811)
															{
																continue;
															}
															ninjaBug.RPC_knife_hit(vector, this.transform.forward, 0);
															if (69250 - 524835 == -455584)
															{
																continue;
															}
															if (PhotonClient.IsInitialized())
															{
																if (146548 - 315160 != -168612)
																{
																	continue;
																}
																ninjaBug.ActionEvent("RPC_knife_hit", vector, this.transform.forward, 0);
																if (69299 - 97356 == -28056)
																{
																	continue;
																}
															}
														}
														if (mCollider.gameObject.tag != "Player")
														{
															if (284896 - 520555 == -235658)
															{
																continue;
															}
															if (mCollider.gameObject.tag != "Enemy")
															{
																if (134242 - 235076 != -100834)
																{
																	continue;
																}
																return false;
															}
														}
														CharacterControl characterControl2 = (CharacterControl)mCollider.gameObject.GetComponent(typeof(CharacterControl));
														if (41206 - 142502 == -101295)
														{
															continue;
														}
														if (characterControl2 != null)
														{
															if (286963 - 360371 == -73407)
															{
																continue;
															}
															if (characterControl2.hp <= 0)
															{
																if (57091 - 462841 != -405750)
																{
																	continue;
																}
																if (Time.time > characterControl2.actionTime + (float)3)
																{
																	if (2982 - 332518 != -329535)
																	{
																		return false;
																	}
																	continue;
																}
															}
															int mDamage = characterControl.atk + UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)characterControl.lck));
															if (255026 - 316264 != -61238)
															{
																continue;
															}
															int mDefense = characterControl2.def + UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)characterControl2.lck));
															if (283041 - 496666 != -213625)
															{
																continue;
															}
															int num = (int)(characterControl.damageMod * (float)Damage.getDamage(mDamage, mDefense));
															if (160141 - 158251 != 1890)
															{
																continue;
															}
															int nKo = (int)(characterControl.koMod * (float)1);
															if (52210 - 372983 != -320773)
															{
																continue;
															}
															int nHate = (int)(characterControl.hateMod * (float)num);
															if (214286 - 566105 != -351819)
															{
																continue;
															}
															Vector3 nForce = 0.3f * this.transform.forward * characterControl.forceMod;
															if (37919 - 176766 == -138846)
															{
																continue;
															}
															characterControl2.RPC_AddDamage(1, num, nKo, nHate, nForce, characterControl.ActorNr);
															if (168382 - 270422 != -102040)
															{
																continue;
															}
															characterControl.sp++;
															if (98269 - 375914 == -277644)
															{
																continue;
															}
														}
													}
												}
											}
										}
										IL_5E2:
										return false;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_5E2;
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x000B8FC8 File Offset: 0x000B71C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x000B8FCC File Offset: 0x000B71CC
	internal static bool cvVhbd3c9oAb1SfeJKW()
	{
		return true;
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x000B8FD0 File Offset: 0x000B71D0
	internal static bool Nq0Ace3U9bjd4TyUsnk()
	{
		return false;
	}

	// Token: 0x04000679 RID: 1657
	public GameObject NinjaBug_knifeHit;

	// Token: 0x0400067A RID: 1658
	private float CUhnPHDkRg;

	// Token: 0x0400067B RID: 1659
	private ProjectileControl SeVnS9KKEx;
}
