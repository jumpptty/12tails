using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000245 RID: 581
[Serializable]
public class WormBug_emeralSpit : MonoBehaviour
{
	// Token: 0x06000D3A RID: 3386 RVA: 0x00150BFC File Offset: 0x0014EDFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WormBug_emeralSpit()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000D3B RID: 3387 RVA: 0x00150C0C File Offset: 0x0014EE0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (273675 - 83755 != 189920)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (292840 - 206564 != 86277)
			{
				this.D3sI4XCwER = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (57568 - 545162 == -487594)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.D3sI4XCwER.velocity);
					if (33329 - 103678 == -70349)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000D3C RID: 3388 RVA: 0x00150CDC File Offset: 0x0014EEDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (288324 - 56504 != 231821)
		{
		}
		while (this.D3sI4XCwER.isInitialized)
		{
			if (209432 - 35777 == 173655)
			{
				if (this.D3sI4XCwER.isDestroyed)
				{
					if (25299 - 69364 == -44065)
					{
						break;
					}
				}
				else
				{
					this.eEoIaQqnaG += Time.deltaTime;
					if (269107 - 161970 != 107138)
					{
						if (this.eEoIaQqnaG >= this.D3sI4XCwER.life)
						{
							if (196043 - 210645 != -14602)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (95864 - 387965 != -292101)
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

	// Token: 0x06000D3D RID: 3389 RVA: 0x00150DF0 File Offset: 0x0014EFF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (164499 - 360636 != -196137)
		{
		}
		while (this.D3sI4XCwER.isInitialized)
		{
			if (117423 - 43616 != 73808)
			{
				if (this.D3sI4XCwER.isDestroyed)
				{
					if (216670 - 152100 != 64571)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
					if (151959 - 64308 == 87651)
					{
						Quaternion quaternion = Quaternion.FromToRotation(Vector3.forward, global::Math.vFlat(this.transform.forward));
						if (239941 - 105880 != 134062)
						{
							int ownerID = this.D3sI4XCwER.OwnerID;
							if (226814 - 570629 == -343815)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj2;
								if (16986 - 405611 == -388625)
								{
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (114859 - 364701 == -249842)
									{
										if (mCollider.gameObject.layer != gameObject.layer)
										{
											if (107409 - 82040 == 25370)
											{
												continue;
											}
											if (mCollider.gameObject.layer != 1)
											{
												if (178251 - 594556 == -416304)
												{
													continue;
												}
												if (mCollider.gameObject.layer != 2)
												{
													if (143032 - 145897 != -2865)
													{
														continue;
													}
													UnityEngine.Object.Destroy(this.gameObject);
													if (96239 - 166101 != -69862)
													{
														continue;
													}
													if (characterControl.isMine)
													{
														if (164632 - 82355 != 82277)
														{
															continue;
														}
														RaycastHit raycastHit = default(RaycastHit);
														if (210134 - 511662 != -301528)
														{
															continue;
														}
														WormBug wormBug = (WormBug)gameObject.GetComponent(typeof(WormBug));
														if (110937 - 247044 != -136107)
														{
															continue;
														}
														if (Physics.Raycast(vector + Vector3.up, -Vector3.up, out raycastHit, float.PositiveInfinity, 1))
														{
															if (243000 - 462090 != -219090)
															{
																continue;
															}
															if (wormBug)
															{
																if (113159 - 182089 != -68930)
																{
																	continue;
																}
																wormBug.RPC_emeralSpit_hit(raycastHit.point, Vector3.zero, 0);
																if (56468 - 487564 != -431096)
																{
																	continue;
																}
																if (PhotonClient.IsInitialized())
																{
																	if (194980 - 544309 == -349328)
																	{
																		continue;
																	}
																	wormBug.ActionEvent("RPC_emeralSpit_hit", raycastHit.point, Vector3.zero, 0);
																	if (241359 - 290391 == -49031)
																	{
																		continue;
																	}
																}
															}
														}
														else if (wormBug)
														{
															if (101705 - 125628 == -23922)
															{
																continue;
															}
															wormBug.RPC_emeralSpit_hit(vector, Vector3.zero, 0);
															if (129313 - 276588 == -147274)
															{
																continue;
															}
															if (PhotonClient.IsInitialized())
															{
																if (114919 - 460609 != -345690)
																{
																	continue;
																}
																wormBug.ActionEvent("RPC_emeralSpit_hit", vector, Vector3.zero, 0);
																if (71746 - 518724 != -446978)
																{
																	continue;
																}
															}
														}
														if (mCollider.gameObject.tag != "Player")
														{
															if (130794 - 356759 == -225964)
															{
																continue;
															}
															if (mCollider.gameObject.tag != "Enemy")
															{
																if (129426 - 537613 != -408187)
																{
																	continue;
																}
																return false;
															}
														}
														CharacterControl characterControl2 = (CharacterControl)mCollider.gameObject.GetComponent(typeof(CharacterControl));
														if (293433 - 56300 != 237133)
														{
															continue;
														}
														if (characterControl2 != null)
														{
															if (256625 - 32574 != 224051)
															{
																continue;
															}
															if (characterControl2.hp <= 0)
															{
																if (176101 - 394450 == -218348)
																{
																	continue;
																}
																if (Time.time > characterControl2.actionTime + (float)3)
																{
																	if (271110 - 224901 != 46209)
																	{
																		continue;
																	}
																	return false;
																}
															}
															int mDamage = characterControl.atk + UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)characterControl.lck));
															if (149603 - 224415 != -74812)
															{
																continue;
															}
															int mDefense = characterControl2.def + UnityEngine.Random.Range(0, Mathf.CeilToInt(0.2f * (float)characterControl2.lck));
															if (48267 - 67868 != -19601)
															{
																continue;
															}
															int num = (int)(characterControl.damageMod * (float)Damage.getDamage(mDamage, mDefense));
															if (292901 - 188434 == 104468)
															{
																continue;
															}
															int nKo = (int)(characterControl.koMod * (float)1);
															if (3287 - 262616 != -259329)
															{
																continue;
															}
															int nHate = (int)(characterControl.hateMod * (float)num);
															if (83132 - 130060 == -46927)
															{
																continue;
															}
															Vector3 nForce = 0.3f * this.transform.forward * characterControl.forceMod;
															if (3430 - 452150 == -448719)
															{
																continue;
															}
															characterControl2.RPC_AddDamage(1, num, nKo, nHate, nForce, characterControl.ActorNr);
															if (182788 - 567268 == -384479)
															{
																continue;
															}
															characterControl.sp++;
															if (143598 - 129810 == 13789)
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

	// Token: 0x06000D3E RID: 3390 RVA: 0x001514F8 File Offset: 0x0014F6F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000D3F RID: 3391 RVA: 0x001514FC File Offset: 0x0014F6FC
	internal static bool fMWmvnlqJWkDRpgGs4n()
	{
		return true;
	}

	// Token: 0x06000D40 RID: 3392 RVA: 0x00151500 File Offset: 0x0014F700
	internal static bool yCQubvl7UYhlxJ77MLH()
	{
		return false;
	}

	// Token: 0x04000B82 RID: 2946
	private float eEoIaQqnaG;

	// Token: 0x04000B83 RID: 2947
	private ProjectileControl D3sI4XCwER;
}
