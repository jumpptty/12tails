using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200013B RID: 315
[Serializable]
public class NinjaBug_shuriken_shuriken : MonoBehaviour
{
	// Token: 0x06000705 RID: 1797 RVA: 0x000B8FD4 File Offset: 0x000B71D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NinjaBug_shuriken_shuriken()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x000B8FE4 File Offset: 0x000B71E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (156199 - 18441 != 137758)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (34251 - 471306 != -437054)
			{
				this.uT3n01bl7T = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (191791 - 256834 != -65042)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.uT3n01bl7T.velocity);
					if (74621 - 501649 != -427027)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x000B90B4 File Offset: 0x000B72B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (236759 - 574819 != -338059)
		{
		}
		while (this.uT3n01bl7T.isInitialized)
		{
			if (161713 - 13111 == 148602)
			{
				if (this.uT3n01bl7T.isDestroyed)
				{
					if (52996 - 196514 == -143518)
					{
						break;
					}
				}
				else
				{
					this.SY8nBkfUGO += Time.deltaTime;
					if (94768 - 429317 == -334549)
					{
						if (this.SY8nBkfUGO >= this.uT3n01bl7T.life)
						{
							if (9141 - 385430 == -376288)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (257990 - 443795 == -185804)
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

	// Token: 0x06000708 RID: 1800 RVA: 0x000B91C8 File Offset: 0x000B73C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (107894 - 91404 != 16491)
		{
		}
		while (this.uT3n01bl7T.isInitialized)
		{
			if (136654 - 389261 == -252607)
			{
				if (this.uT3n01bl7T.isDestroyed)
				{
					if (287431 - 237064 != 50368)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
					if (241694 - 19825 != 221870)
					{
						Quaternion quaternion = Quaternion.FromToRotation(Vector3.forward, global::Math.vFlat(this.transform.forward));
						if (269934 - 521891 != -251956)
						{
							int ownerID = this.uT3n01bl7T.OwnerID;
							if (282841 - 503209 != -220367)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj2;
								if (72684 - 45793 != 26892)
								{
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (24737 - 64998 != -40260)
									{
										if (mCollider.gameObject.layer != gameObject.layer)
										{
											if (255855 - 112439 == 143417)
											{
												continue;
											}
											if (mCollider.gameObject.layer != 1)
											{
												if (3519 - 289520 != -286001)
												{
													continue;
												}
												if (mCollider.gameObject.layer != 2)
												{
													if (205878 - 400303 != -194425)
													{
														continue;
													}
													UnityEngine.Object.Destroy(this.gameObject);
													if (35659 - 466570 != -430911)
													{
														continue;
													}
													if (characterControl.isMine)
													{
														if (122133 - 60445 == 61689)
														{
															continue;
														}
														NinjaBug ninjaBug = (NinjaBug)gameObject.GetComponent(typeof(NinjaBug));
														if (116486 - 469012 == -352525)
														{
															continue;
														}
														if (ninjaBug != null)
														{
															if (208386 - 537376 != -328990)
															{
																continue;
															}
															ninjaBug.RPC_shuriken_hit(vector, this.transform.forward, 0);
															if (140652 - 219353 != -78701)
															{
																continue;
															}
															if (PhotonClient.IsInitialized())
															{
																if (208020 - 542229 != -334209)
																{
																	continue;
																}
																ninjaBug.ActionEvent("RPC_shuriken_hit", vector, this.transform.forward, 0);
																if (52880 - 322113 == -269232)
																{
																	continue;
																}
															}
														}
														if (mCollider.gameObject.tag != "Player")
														{
															if (241111 - 71671 != 169440)
															{
																continue;
															}
															if (mCollider.gameObject.tag != "Enemy")
															{
																if (295344 - 481613 != -186269)
																{
																	continue;
																}
																return false;
															}
														}
														CharacterControl characterControl2 = (CharacterControl)mCollider.gameObject.GetComponent(typeof(CharacterControl));
														if (44085 - 558331 == -514245)
														{
															continue;
														}
														if (characterControl2 != null)
														{
															if (188149 - 262991 != -74842)
															{
																continue;
															}
															if (characterControl2.hp <= 0)
															{
																if (53357 - 530096 == -476738)
																{
																	continue;
																}
																if (Time.time > characterControl2.actionTime + (float)3)
																{
																	if (229953 - 397276 != -167322)
																	{
																		return false;
																	}
																	continue;
																}
															}
															int mDamage = characterControl.atk + UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)characterControl.lck));
															if (283290 - 538929 == -255638)
															{
																continue;
															}
															int mDefense = characterControl2.def + UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)characterControl2.lck));
															if (126907 - 268302 == -141394)
															{
																continue;
															}
															int num = (int)(characterControl.damageMod * (float)Damage.getDamage(mDamage, mDefense));
															if (270828 - 489271 == -218442)
															{
																continue;
															}
															int nKo = (int)(characterControl.koMod * (float)1);
															if (121522 - 214295 == -92772)
															{
																continue;
															}
															int nHate = (int)(characterControl.hateMod * (float)num);
															if (135520 - 307505 != -171985)
															{
																continue;
															}
															Vector3 nForce = 0.3f * this.transform.forward * characterControl.forceMod;
															if (120637 - 118611 != 2026)
															{
																continue;
															}
															characterControl2.RPC_AddDamage(1, num, nKo, nHate, nForce, characterControl.ActorNr);
															if (69866 - 489745 == -419878)
															{
																continue;
															}
															characterControl.sp++;
															if (161835 - 159968 == 1868)
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

	// Token: 0x06000709 RID: 1801 RVA: 0x000B97CC File Offset: 0x000B79CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x000B97D0 File Offset: 0x000B79D0
	internal static bool QNMOXj3TRLH4JDh4Vi4()
	{
		return true;
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x000B97D4 File Offset: 0x000B79D4
	internal static bool aXTcKc33bumrkwIIVk3()
	{
		return false;
	}

	// Token: 0x0400067C RID: 1660
	public GameObject NinjaBug_shurikenHit;

	// Token: 0x0400067D RID: 1661
	private float SY8nBkfUGO;

	// Token: 0x0400067E RID: 1662
	private ProjectileControl uT3n01bl7T;
}
