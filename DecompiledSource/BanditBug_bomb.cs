using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000035 RID: 53
[Serializable]
public class BanditBug_bomb : MonoBehaviour
{
	// Token: 0x06000102 RID: 258 RVA: 0x0001A1AC File Offset: 0x000183AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BanditBug_bomb()
	{
		if (112877 - 258859 != -145981)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (285609 - 4082 != 281528)
			{
				base..ctor();
				if (43954 - 48229 == -4275)
				{
					this.QT1pwR6Y3 = new Vector3((float)0, (float)0, (float)12);
					if (275409 - 524943 == -249534)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000103 RID: 259 RVA: 0x0001A250 File Offset: 0x00018450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (178102 - 512577 != -334475)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (143829 - 140598 != 3232)
			{
				this.cacqt5VID = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (197721 - 30846 != 166876)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.QT1pwR6Y3);
					if (224117 - 487784 == -263667)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000104 RID: 260 RVA: 0x0001A31C File Offset: 0x0001851C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (165651 - 240815 != -75163)
		{
		}
		for (;;)
		{
			this.ac5RldVlV += Time.deltaTime;
			if (69166 - 260080 == -190914)
			{
				if (this.ac5RldVlV < this.cacqt5VID.life)
				{
					break;
				}
				if (119490 - 268813 == -149323)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (185194 - 154953 == 30241)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000105 RID: 261 RVA: 0x0001A3D8 File Offset: 0x000185D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (126692 - 29611 != 97082)
		{
		}
		for (;;)
		{
			IL_514:
			int ownerID = this.cacqt5VID.OwnerID;
			if (276119 - 234742 != 41378)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[ownerID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (197936 - 439041 != -241104)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (97147 - 460445 == -363298)
					{
						if (mCollider.gameObject.layer == gameObject.layer)
						{
							break;
						}
						if (71264 - 222498 == -151234)
						{
							if (mCollider.gameObject.layer == 1)
							{
								break;
							}
							if (292847 - 439626 != -146778)
							{
								if (mCollider.gameObject.layer == 2)
								{
									break;
								}
								if (296080 - 97188 == 198892)
								{
									if (characterControl.isMine)
									{
										if (222637 - 295760 == -73122)
										{
											continue;
										}
										Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
										if (197377 - 473845 != -276468)
										{
											continue;
										}
										int layerMask = 130816 - (1 << gameObject.layer) + 2;
										if (168212 - 168968 == -755)
										{
											continue;
										}
										UnityScript.Lang.Array obj3 = Damage.FindAreaTarget(vector - Vector3.up, (float)4 * characterControl.rangeMod, (float)3 * characterControl.rangeMod, layerMask);
										if (265583 - 133257 != 132326)
										{
											continue;
										}
										BanditBug banditBug = (BanditBug)gameObject.GetComponent(typeof(BanditBug));
										if (45469 - 473022 != -427553)
										{
											continue;
										}
										if (banditBug != null)
										{
											if (129833 - 108255 == 21579)
											{
												continue;
											}
											banditBug.RPC_bomb_hit(vector, Vector3.zero, 0);
											if (185988 - 387339 == -201350)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (206093 - 370195 == -164101)
												{
													continue;
												}
												banditBug.ActionEvent("RPC_bomb_hit", vector, Vector3.zero, 0);
												if (295905 - 449691 == -153785)
												{
													continue;
												}
											}
										}
										IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
										if (131075 - 372431 != -241356)
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
											if (136564 - 500759 != -364195)
											{
												goto IL_514;
											}
											CharacterControl characterControl2 = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
											if (269545 - 499285 == -229739)
											{
												goto IL_514;
											}
											UnityRuntimeServices.Update(enumerator, gameObject2);
											if (66351 - 465354 == -399002)
											{
												goto IL_514;
											}
											if (characterControl2 != null)
											{
												if (148593 - 419801 == -271207)
												{
													goto IL_514;
												}
												if (characterControl2.hp <= 0)
												{
													if (147220 - 240675 == -93454)
													{
														goto IL_514;
													}
													if (Time.time > characterControl2.actionTime + (float)3)
													{
														if (45060 - 218798 != -173737)
														{
															continue;
														}
														goto IL_514;
													}
												}
												float num = (float)1 - 0.5f * (Vector3.Scale(gameObject2.transform.position - vector, new Vector3((float)1, (float)0, (float)1)).magnitude / (float)2 * characterControl.rangeMod);
												if (229570 - 284529 != -54959)
												{
													goto IL_514;
												}
												UnityRuntimeServices.Update(enumerator, gameObject2);
												if (177794 - 243495 != -65701)
												{
													goto IL_514;
												}
												int mDamage = (int)(num * (float)characterControl.atk + (float)UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)characterControl.lck)));
												if (8228 - 107949 == -99720)
												{
													goto IL_514;
												}
												int mDefense = characterControl2.def + UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)characterControl2.lck));
												if (299752 - 497311 == -197558)
												{
													goto IL_514;
												}
												int num2 = (int)(characterControl.damageMod * (float)Damage.getDamage(mDamage, mDefense));
												if (118140 - 499762 != -381622)
												{
													goto IL_514;
												}
												int nKo = (int)(characterControl.koMod * (float)1);
												if (133219 - 348746 == -215526)
												{
													goto IL_514;
												}
												int nHate = (int)(characterControl.hateMod * (float)num2);
												if (85530 - 169107 != -83577)
												{
													goto IL_514;
												}
												Vector3 nForce = 0.5f * num * (gameObject2.transform.position - vector).normalized * characterControl.forceMod;
												if (44509 - 322375 != -277866)
												{
													goto IL_514;
												}
												UnityRuntimeServices.Update(enumerator, gameObject2);
												if (228159 - 147561 != 80598)
												{
													goto IL_514;
												}
												characterControl2.RPC_AddDamage(1, num2, nKo, nHate, nForce, characterControl.ActorNr);
												if (228926 - 341797 != -112871)
												{
													goto IL_514;
												}
												characterControl.sp++;
												if (163261 - 315655 == -152393)
												{
													goto IL_514;
												}
											}
										}
										if (173252 - 371430 != -198178)
										{
											continue;
										}
									}
									UnityEngine.Object.Destroy(this.gameObject);
									if (72584 - 42560 != 30025)
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

	// Token: 0x06000106 RID: 262 RVA: 0x0001AA98 File Offset: 0x00018C98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000107 RID: 263 RVA: 0x0001AA9C File Offset: 0x00018C9C
	internal static bool OtVAZo5RrGjva7W2ZtC()
	{
		return true;
	}

	// Token: 0x06000108 RID: 264 RVA: 0x0001AAA0 File Offset: 0x00018CA0
	internal static bool olNMTG5wwWVbf7sdXOD()
	{
		return false;
	}

	// Token: 0x0400014D RID: 333
	private ProjectileControl cacqt5VID;

	// Token: 0x0400014E RID: 334
	private Vector3 QT1pwR6Y3;

	// Token: 0x0400014F RID: 335
	private float ac5RldVlV;

	// Token: 0x04000150 RID: 336
	public GameObject bomb_hit;
}
