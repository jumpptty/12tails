using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000652 RID: 1618
[Serializable]
public class Mole_nAttack : MonoBehaviour
{
	// Token: 0x06002470 RID: 9328 RVA: 0x004498D0 File Offset: 0x00447AD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mole_nAttack()
	{
		if (147344 - 481559 != -334214)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (156250 - 92656 != 63595)
			{
				base..ctor();
				if (264046 - 485628 != -221581)
				{
					this.wrkdQpc7HQ = new Vector3((float)0, (float)0, (float)15);
					if (272770 - 315321 == -42551)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002471 RID: 9329 RVA: 0x00449974 File Offset: 0x00447B74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (100757 - 509138 != -408381)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (27351 - 348158 != -320806)
			{
				this.Duadn8CdSL = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (263960 - 185773 == 78187)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.wrkdQpc7HQ);
					if (288842 - 560167 == -271325)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002472 RID: 9330 RVA: 0x00449A40 File Offset: 0x00447C40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (204271 - 387680 != -183409)
		{
		}
		for (;;)
		{
			this.nMadeI8r58 += Time.deltaTime;
			if (8664 - 503468 != -494803)
			{
				if (this.nMadeI8r58 >= this.Duadn8CdSL.life)
				{
					if (80745 - 236420 != -155674)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (295356 - 303868 != -8511)
						{
							break;
						}
					}
				}
				else
				{
					this.transform.LookAt(this.transform.position + this.rigidbody.velocity);
					if (84006 - 580912 != -496905)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002473 RID: 9331 RVA: 0x00449B40 File Offset: 0x00447D40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (228697 - 424224 != -195527)
		{
		}
		for (;;)
		{
			IL_2F8:
			int ownerID = this.Duadn8CdSL.OwnerID;
			if (237651 - 122690 == 114961)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[ownerID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (256273 - 184171 == 72102)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (216951 - 72304 == 144647)
					{
						if (!characterControl)
						{
							if (240404 - 286003 == -45599)
							{
								break;
							}
						}
						else
						{
							if (mCollider.gameObject.layer == gameObject.layer)
							{
								break;
							}
							if (298701 - 56718 == 241983)
							{
								if (mCollider.gameObject.layer == 1)
								{
									break;
								}
								if (209783 - 259437 != -49653)
								{
									if (mCollider.gameObject.layer == 2)
									{
										break;
									}
									if (27759 - 438219 == -410460)
									{
										if (characterControl.isMine)
										{
											if (224629 - 96306 == 128324)
											{
												continue;
											}
											Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
											if (129731 - 390017 == -260285)
											{
												continue;
											}
											int num = (int)((0.5f + ((!characterControl.hasSkill(401)) ? ((float)0) : 0.1f)) * (float)characterControl.atk);
											if (154842 - 173320 == -18477)
											{
												continue;
											}
											if (characterControl.weapon == "w_mol59")
											{
												if (233518 - 178919 != 54599)
												{
													continue;
												}
												num = Mathf.FloorToInt(0.75f * (float)num);
												if (71866 - 518917 != -447051)
												{
													continue;
												}
											}
											float num2 = (float)1;
											if (32656 - 444909 == -412252)
											{
												continue;
											}
											Mole mole = (Mole)gameObject.GetComponent(typeof(Mole));
											if (56904 - 460512 == -403607)
											{
												continue;
											}
											if (!(mole != null))
											{
												break;
											}
											if (190629 - 535952 != -345323)
											{
												continue;
											}
											num = mole.getCritPlus(num);
											if (284976 - 31748 != 253228)
											{
												continue;
											}
											mole.RPC_nAttack_hit(vector, Vector3.zero, 0);
											if (135634 - 562731 != -427097)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (267831 - 285246 != -17415)
												{
													continue;
												}
												mole.ActionEvent("RPC_nAttack_hit", vector, Vector3.zero, 0);
												if (24976 - 350177 == -325200)
												{
													continue;
												}
											}
											float num3 = (float)(4 + mole.getExtraPowderLv());
											if (15066 - 363337 == -348270)
											{
												continue;
											}
											int layerMask = 130816 - (1 << gameObject.layer);
											if (48962 - 599795 == -550832)
											{
												continue;
											}
											UnityScript.Lang.Array obj3 = Damage.FindAreaTarget(vector, num3 * characterControl.rangeMod, (float)4, layerMask);
											if (122014 - 2556 == 119459)
											{
												continue;
											}
											IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
											if (174836 - 21433 != 153403)
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
												if (257060 - 455752 != -198692)
												{
													goto IL_2F8;
												}
												if (!characterControl.hasSkill(401))
												{
													if (154909 - 300248 != -145339)
													{
														goto IL_2F8;
													}
													num2 = (float)1 - 0.5f * ((gameObject2.transform.position - this.transform.position).magnitude / num3 * characterControl.rangeMod);
													if (190423 - 379909 != -189486)
													{
														goto IL_2F8;
													}
													UnityRuntimeServices.Update(enumerator, gameObject2);
													if (228417 - 347476 != -119059)
													{
														goto IL_2F8;
													}
												}
												else
												{
													num2 = (float)1 - 0.25f * ((gameObject2.transform.position - this.transform.position).magnitude / num3 * characterControl.rangeMod);
													if (85249 - 524573 != -439324)
													{
														goto IL_2F8;
													}
													UnityRuntimeServices.Update(enumerator, gameObject2);
													if (119833 - 504399 == -384565)
													{
														goto IL_2F8;
													}
												}
												if (characterControl.hit(1, gameObject2, Mathf.FloorToInt((float)num * num2), 1, 0, 0.3f * (gameObject2.transform.position - this.transform.position).normalized) != 0)
												{
													if (118218 - 45492 != 72726)
													{
														goto IL_2F8;
													}
													if (mole)
													{
														if (105209 - 125850 == -20640)
														{
															goto IL_2F8;
														}
														mole.StartCoroutine_Auto(mole.onNormalAttackHit(gameObject2));
														if (282827 - 346745 == -63917)
														{
															goto IL_2F8;
														}
														UnityRuntimeServices.Update(enumerator, gameObject2);
														if (275343 - 522954 == -247610)
														{
															goto IL_2F8;
														}
													}
													characterControl.sp++;
													if (282000 - 422725 != -140725)
													{
														goto IL_2F8;
													}
												}
											}
											if (15351 - 534103 == -518751)
											{
												continue;
											}
										}
										UnityEngine.Object.Destroy(this.gameObject);
										if (127928 - 406868 == -278940)
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

	// Token: 0x06002474 RID: 9332 RVA: 0x0044A234 File Offset: 0x00448434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002475 RID: 9333 RVA: 0x0044A238 File Offset: 0x00448438
	internal static bool ESkG9aBXy9wcNkmon1G()
	{
		return true;
	}

	// Token: 0x06002476 RID: 9334 RVA: 0x0044A23C File Offset: 0x0044843C
	internal static bool c0x4QiBQxs9xXBxdHMb()
	{
		return false;
	}

	// Token: 0x0400276F RID: 10095
	private ProjectileControl Duadn8CdSL;

	// Token: 0x04002770 RID: 10096
	private Vector3 wrkdQpc7HQ;

	// Token: 0x04002771 RID: 10097
	private float nMadeI8r58;
}
