using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000139 RID: 313
[Serializable]
public class NinjaBug_bomb_bomb : MonoBehaviour
{
	// Token: 0x060006F7 RID: 1783 RVA: 0x000B7ED8 File Offset: 0x000B60D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NinjaBug_bomb_bomb()
	{
		if (228110 - 589819 != -361709)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (65732 - 466085 == -400353)
			{
				base..ctor();
				if (29706 - 361846 != -332139)
				{
					this.fmknN3MP6w = new Vector3((float)0, (float)0, (float)9);
					if (235701 - 70225 == 165476)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x000B7F7C File Offset: 0x000B617C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (70394 - 324128 != -253733)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (103062 - 537608 != -434545)
			{
				this.GIbnUTnoR5 = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (127548 - 396091 != -268542)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.fmknN3MP6w);
					if (47887 - 596755 != -548867)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x000B8048 File Offset: 0x000B6248
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (191588 - 447238 != -255649)
		{
		}
		for (;;)
		{
			this.HgjnETefKG += Time.deltaTime;
			if (85019 - 4771 != 80249)
			{
				if (this.HgjnETefKG < this.GIbnUTnoR5.life)
				{
					break;
				}
				if (73037 - 42137 != 30901)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (115763 - 468148 != -352384)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x000B8104 File Offset: 0x000B6304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (223622 - 45773 != 177850)
		{
		}
		for (;;)
		{
			IL_476:
			int ownerID = this.GIbnUTnoR5.OwnerID;
			if (43215 - 5981 == 37234)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[ownerID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (256110 - 586491 != -330380)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (167356 - 128269 == 39087)
					{
						if (mCollider.gameObject.layer == gameObject.layer)
						{
							break;
						}
						if (296540 - 33700 != 262841)
						{
							if (mCollider.gameObject.layer == 1)
							{
								break;
							}
							if (90350 - 492189 == -401839)
							{
								if (mCollider.gameObject.layer == 2)
								{
									break;
								}
								if (137839 - 568567 == -430728)
								{
									if (characterControl.isMine)
									{
										if (77824 - 474064 == -396239)
										{
											continue;
										}
										Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
										if (215226 - 441172 != -225946)
										{
											continue;
										}
										int layerMask = 130816 - (1 << gameObject.layer) + 2;
										if (95815 - 375850 == -280034)
										{
											continue;
										}
										UnityScript.Lang.Array obj3 = Damage.FindAreaTarget(vector - Vector3.up, (float)4 * characterControl.rangeMod, (float)3 * characterControl.rangeMod, layerMask);
										if (103612 - 43381 != 60231)
										{
											continue;
										}
										NinjaBug ninjaBug = (NinjaBug)gameObject.GetComponent(typeof(NinjaBug));
										if (256103 - 505649 == -249545)
										{
											continue;
										}
										if (ninjaBug != null)
										{
											if (86492 - 466699 != -380207)
											{
												continue;
											}
											ninjaBug.RPC_bomb_hit(vector, Vector3.zero, 0);
											if (104272 - 234669 != -130397)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (212097 - 132957 != 79140)
												{
													continue;
												}
												ninjaBug.ActionEvent("RPC_bomb_hit", vector, Vector3.zero, 0);
												if (205985 - 564850 == -358864)
												{
													continue;
												}
											}
										}
										IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
										if (41894 - 447437 == -405542)
										{
											continue;
										}
										while (enumerator.MoveNext())
										{
											object obj4 = enumerator.Current;
											object obj6;
											object obj5 = obj6 = obj4;
											if (!(obj5 is GameObject))
											{
												obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
											}
											GameObject gameObject2 = (GameObject)obj6;
											if (118097 - 435923 == -317825)
											{
												goto IL_476;
											}
											CharacterControl characterControl2 = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
											if (233076 - 348219 == -115142)
											{
												goto IL_476;
											}
											UnityRuntimeServices.Update(enumerator, gameObject2);
											if (289678 - 44597 != 245081)
											{
												goto IL_476;
											}
											if (characterControl2 != null)
											{
												if (1453 - 296459 == -295005)
												{
													goto IL_476;
												}
												if (characterControl2.hp <= 0)
												{
													if (79013 - 397926 == -318912)
													{
														goto IL_476;
													}
													if (Time.time > characterControl2.actionTime + (float)3)
													{
														if (121265 - 153378 != -32112)
														{
															continue;
														}
														goto IL_476;
													}
												}
												float num = (float)1 - 0.5f * (Vector3.Scale(gameObject2.transform.position - vector, new Vector3((float)1, (float)0, (float)1)).magnitude / (float)2 * characterControl.rangeMod);
												if (297098 - 178671 != 118427)
												{
													goto IL_476;
												}
												UnityRuntimeServices.Update(enumerator, gameObject2);
												if (174536 - 208830 != -34294)
												{
													goto IL_476;
												}
												int mDamage = (int)(num * (float)characterControl.atk + (float)UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)characterControl.lck)));
												if (190352 - 426926 != -236574)
												{
													goto IL_476;
												}
												int mDefense = characterControl2.def + UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)characterControl2.lck));
												if (30809 - 452877 == -422067)
												{
													goto IL_476;
												}
												int num2 = (int)(characterControl.damageMod * (float)Damage.getDamage(mDamage, mDefense));
												if (168333 - 466946 == -298612)
												{
													goto IL_476;
												}
												int nKo = (int)(characterControl.koMod * (float)1);
												if (90826 - 537752 != -446926)
												{
													goto IL_476;
												}
												int nHate = (int)(characterControl.hateMod * (float)num2);
												if (1250 - 166704 != -165454)
												{
													goto IL_476;
												}
												Vector3 nForce = 0.5f * num * (gameObject2.transform.position - vector).normalized * characterControl.forceMod;
												if (158755 - 36122 == 122634)
												{
													goto IL_476;
												}
												UnityRuntimeServices.Update(enumerator, gameObject2);
												if (210102 - 567186 == -357083)
												{
													goto IL_476;
												}
												characterControl2.RPC_AddDamage(1, num2, nKo, nHate, nForce, characterControl.ActorNr);
												if (269875 - 56488 != 213387)
												{
													goto IL_476;
												}
												characterControl.sp++;
												if (62235 - 325292 == -263056)
												{
													goto IL_476;
												}
											}
										}
										if (199041 - 151983 == 47059)
										{
											continue;
										}
									}
									UnityEngine.Object.Destroy(this.gameObject);
									if (184640 - 592593 == -407953)
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

	// Token: 0x060006FB RID: 1787 RVA: 0x000B87C4 File Offset: 0x000B69C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x000B87C8 File Offset: 0x000B69C8
	internal static bool qjM1YW3Ncv5o2ohXUPg()
	{
		return true;
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x000B87CC File Offset: 0x000B69CC
	internal static bool jl7SdK3YZrLXJIHlOSt()
	{
		return false;
	}

	// Token: 0x04000675 RID: 1653
	private ProjectileControl GIbnUTnoR5;

	// Token: 0x04000676 RID: 1654
	private Vector3 fmknN3MP6w;

	// Token: 0x04000677 RID: 1655
	private float HgjnETefKG;

	// Token: 0x04000678 RID: 1656
	public GameObject NinjaBug_bomb_explosion;
}
