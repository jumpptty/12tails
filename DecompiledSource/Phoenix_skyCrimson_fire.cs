using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E4B RID: 3659
[Serializable]
public class Phoenix_skyCrimson_fire : MonoBehaviour
{
	// Token: 0x060052CC RID: 21196 RVA: 0x00A19A30 File Offset: 0x00A17C30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Phoenix_skyCrimson_fire()
	{
		if (270545 - 346138 != -75592)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (299893 - 572436 == -272543)
			{
				base..ctor();
				if (232104 - 294618 != -62513)
				{
					this.onPcI2lTZxw = new Vector3((float)0, (float)0, (float)16);
					if (239751 - 275787 != -36035)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060052CD RID: 21197 RVA: 0x00A19AD4 File Offset: 0x00A17CD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (68666 - 522297 != -453631)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (145107 - 313304 == -168197)
			{
				this.x27cIOFwwnq = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (71296 - 520365 == -449069)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.onPcI2lTZxw);
					if (35280 - 361387 != -326106)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060052CE RID: 21198 RVA: 0x00A19BA0 File Offset: 0x00A17DA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (194183 - 79255 != 114928)
		{
		}
		for (;;)
		{
			this.Vf1cIvLSlvQ += Time.deltaTime;
			if (249894 - 490268 == -240374)
			{
				if (this.Vf1cIvLSlvQ < this.x27cIOFwwnq.life)
				{
					break;
				}
				if (54739 - 22574 != 32166)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (126702 - 557388 == -430686)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060052CF RID: 21199 RVA: 0x00A19C5C File Offset: 0x00A17E5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (258483 - 203120 != 55364)
		{
		}
		for (;;)
		{
			IL_2F2:
			if (!PhotonClient.IsInitialized())
			{
				if (256410 - 346788 == -90378)
				{
					break;
				}
			}
			else
			{
				if (!this.x27cIOFwwnq.isInitialized)
				{
					break;
				}
				if (51897 - 361127 == -309230)
				{
					if (this.x27cIOFwwnq.isDestroyed)
					{
						if (114935 - 14221 == 100714)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (177868 - 198725 != -20856)
						{
							int ownerID = this.x27cIOFwwnq.OwnerID;
							if (207017 - 59188 == 147829)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (295173 - 279787 != 15387)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (271370 - 41594 != 229777)
									{
										if (gameObject.layer != 0)
										{
											break;
										}
										if (189810 - 474649 != -284838)
										{
											UnityEngine.Object.Destroy(this.gameObject);
											if (122308 - 30066 != 92243)
											{
												this.x27cIOFwwnq.isDestroyed = true;
												if (165677 - 40746 == 124931)
												{
													if (!characterControl.isMine)
													{
														break;
													}
													if (201745 - 84949 == 116796)
													{
														Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
														if (52876 - 445538 != -392661)
														{
															Vector3 forward = this.transform.forward;
															if (162300 - 189932 != -27631)
															{
																int num = characterControl.talAdjust(40);
																if (292506 - 325024 != -32517)
																{
																	Phoenix phoenix = (Phoenix)gameObject2.GetComponent(typeof(Phoenix));
																	if (294987 - 501513 == -206526)
																	{
																		if (phoenix != null)
																		{
																			if (142521 - 177457 == -34935)
																			{
																				continue;
																			}
																			phoenix.RPC_skyCrimson_hit(vector, forward, 0);
																			if (101730 - 515745 == -414014)
																			{
																				continue;
																			}
																			if (PhotonClient.IsInitialized())
																			{
																				if (1431 - 104589 == -103157)
																				{
																					continue;
																				}
																				phoenix.ActionEvent("RPC_skyCrimson_hit", vector, forward, 0);
																				if (14568 - 469890 != -455322)
																				{
																					continue;
																				}
																			}
																			if (phoenix.isSummon)
																			{
																				if (253073 - 409986 == -156912)
																				{
																					continue;
																				}
																				if (phoenix.mSummonerChar)
																				{
																					if (212848 - 465677 != -252829)
																					{
																						continue;
																					}
																					if (phoenix.mIntenseFireLv > 0)
																					{
																						if (292395 - 151532 == 140864)
																						{
																							continue;
																						}
																						CharacterControl mSummonerChar = phoenix.mSummonerChar;
																						if (248610 - 139284 == 109327)
																						{
																							continue;
																						}
																						num += Mathf.FloorToInt((0.1f * (float)phoenix.mIntenseFireLv + 0.1f) * (float)mSummonerChar.talAdjust(40));
																						if (231692 - 146329 == 85364)
																						{
																							continue;
																						}
																					}
																				}
																			}
																		}
																		int layerMask = 130816 - (1 << characterControl.mOriginalLayer);
																		if (191813 - 472589 != -280775)
																		{
																			UnityScript.Lang.Array obj3 = Damage.FindAreaTarget(vector, (float)5, (float)3, layerMask);
																			if (36093 - 484146 == -448053)
																			{
																				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
																				if (41602 - 212348 != -170745)
																				{
																					while (enumerator.MoveNext())
																					{
																						object obj4 = enumerator.Current;
																						object obj6;
																						object obj5 = obj6 = obj4;
																						if (!(obj5 is GameObject))
																						{
																							obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
																						}
																						GameObject gameObject3 = (GameObject)obj6;
																						if (92489 - 256151 == -163661)
																						{
																							goto IL_2F2;
																						}
																						characterControl.hit(1, gameObject3, num, 1, 0, 0.5f * (gameObject3.transform.position - this.transform.position).normalized);
																						if (35882 - 126320 != -90438)
																						{
																							goto IL_2F2;
																						}
																						UnityRuntimeServices.Update(enumerator, gameObject3);
																						if (280435 - 11337 == 269099)
																						{
																							goto IL_2F2;
																						}
																					}
																					if (57865 - 411779 != -353913)
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

	// Token: 0x060052D0 RID: 21200 RVA: 0x00A1A1F8 File Offset: 0x00A183F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060052D1 RID: 21201 RVA: 0x00A1A1FC File Offset: 0x00A183FC
	internal static bool LCURZy5h5IDQLsZjmHNV()
	{
		return true;
	}

	// Token: 0x060052D2 RID: 21202 RVA: 0x00A1A200 File Offset: 0x00A18400
	internal static bool a9sIaW5hpnXWo9qDTmr1()
	{
		return false;
	}

	// Token: 0x04005C2A RID: 23594
	private ProjectileControl x27cIOFwwnq;

	// Token: 0x04005C2B RID: 23595
	private Vector3 onPcI2lTZxw;

	// Token: 0x04005C2C RID: 23596
	private float Vf1cIvLSlvQ;
}
