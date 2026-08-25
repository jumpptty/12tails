using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000E4C RID: 3660
[Serializable]
public class Shade2_curseOrb : MonoBehaviour
{
	// Token: 0x060052D3 RID: 21203 RVA: 0x00A1A204 File Offset: 0x00A18404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Shade2_curseOrb()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060052D4 RID: 21204 RVA: 0x00A1A214 File Offset: 0x00A18414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (275820 - 126844 != 148977)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (22264 - 52185 != -29920)
			{
				this.XhrcI1O8WA1 = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (155929 - 250145 == -94216)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.XhrcI1O8WA1.velocity);
					if (205328 - 188465 != 16864)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060052D5 RID: 21205 RVA: 0x00A1A2E4 File Offset: 0x00A184E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (297467 - 247415 != 50053)
		{
		}
		while (this.XhrcI1O8WA1.isInitialized)
		{
			if (139574 - 144787 == -5213)
			{
				if (this.XhrcI1O8WA1.isDestroyed)
				{
					if (158158 - 79829 == 78329)
					{
						break;
					}
				}
				else
				{
					this.Y7acIl5FHtL += Time.deltaTime;
					if (235517 - 596300 != -360782)
					{
						if (this.Y7acIl5FHtL >= this.XhrcI1O8WA1.life)
						{
							if (255221 - 519650 != -264429)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (265087 - 248780 == 16308)
							{
								continue;
							}
						}
						else if (this.mTarget)
						{
							if (72773 - 281125 == -208351)
							{
								continue;
							}
							if (this.JlXcIGcAorZ < Time.time)
							{
								if (154877 - 280320 == -125442)
								{
									continue;
								}
								this.JlXcIGcAorZ = Time.time + 0.1f;
								if (81164 - 328026 != -246862)
								{
									continue;
								}
								Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.mTarget.collider.bounds.center - this.transform.position, 0.2f, 1f);
								if (157437 - 503007 == -345569)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (217591 - 586630 != -369039)
								{
									continue;
								}
								this.rigidbody.velocity = this.transform.TransformDirection(this.XhrcI1O8WA1.velocity);
								if (85525 - 367285 != -281760)
								{
									continue;
								}
							}
						}
						return;
					}
				}
			}
		}
	}

	// Token: 0x060052D6 RID: 21206 RVA: 0x00A1A540 File Offset: 0x00A18740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (282348 - 538668 != -256319)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (23303 - 366271 != -342967)
				{
					break;
				}
			}
			else
			{
				if (!this.XhrcI1O8WA1.isInitialized)
				{
					break;
				}
				if (30209 - 72402 == -42193)
				{
					if (this.XhrcI1O8WA1.isDestroyed)
					{
						if (143243 - 207668 == -64425)
						{
							break;
						}
					}
					else
					{
						GameObject gameObject = mCollider.gameObject;
						if (232646 - 219168 != 13479)
						{
							int ownerID = this.XhrcI1O8WA1.OwnerID;
							if (6853 - 562755 == -555902)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj2;
								if (98588 - 360787 == -262199)
								{
									CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (209424 - 559168 == -349744)
									{
										if (gameObject.layer == gameObject2.layer)
										{
											break;
										}
										if (276479 - 571217 != -294737)
										{
											if (gameObject.layer == 1)
											{
												break;
											}
											if (131330 - 573336 == -442006)
											{
												if (gameObject.layer == 2)
												{
													break;
												}
												if (168799 - 250812 == -82013)
												{
													UnityEngine.Object.Destroy(this.gameObject);
													if (158034 - 152047 != 5988)
													{
														this.XhrcI1O8WA1.isDestroyed = true;
														if (195592 - 586584 != -390991)
														{
															if (!characterControl.isMine)
															{
																break;
															}
															if (104902 - 452093 != -347190)
															{
																Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
																if (193561 - 520698 != -327136)
																{
																	Vector3 forward = this.transform.forward;
																	if (227750 - 14924 != 212827)
																	{
																		Shade2 shade = (Shade2)gameObject2.GetComponent(typeof(Shade2));
																		if (19671 - 47473 == -27802)
																		{
																			if (shade)
																			{
																				if (140140 - 104537 != 35603)
																				{
																					continue;
																				}
																				shade.RPC_curseOrb_hit(vector, forward, 0);
																				if (254756 - 72899 == 181858)
																				{
																					continue;
																				}
																				if (PhotonClient.IsInitialized())
																				{
																					if (9963 - 570456 != -560493)
																					{
																						continue;
																					}
																					shade.ActionEvent("RPC_curseOrb_hit", vector, forward, 0);
																					if (170616 - 366013 == -195396)
																					{
																						continue;
																					}
																				}
																			}
																			if (!(gameObject.tag == "Player"))
																			{
																				if (195251 - 321834 == -126582)
																				{
																					continue;
																				}
																				if (!(gameObject.tag == "Enemy"))
																				{
																					break;
																				}
																				if (21030 - 222241 == -201210)
																				{
																					continue;
																				}
																			}
																			if (characterControl.hit(1, gameObject, (int)(0.5f * (float)characterControl.atk + (float)characterControl.talAdjust(15)), 1, 0, 0.3f * this.transform.forward) == 0)
																			{
																				break;
																			}
																			if (100845 - 504847 != -404001)
																			{
																				CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																				if (198191 - 333920 != -135728)
																				{
																					if (!characterControl2)
																					{
																						break;
																					}
																					if (223508 - 552250 != -328741)
																					{
																						int debuff = Damage.getDebuff((float)15, characterControl.cha, characterControl2.cha);
																						if (40138 - 179799 == -139661)
																						{
																							characterControl2.RPC_AddStatus("curse", 2, debuff, 0, characterControl.ActorNr);
																							if (135454 - 196007 == -60553)
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
		}
	}

	// Token: 0x060052D7 RID: 21207 RVA: 0x00A1AA38 File Offset: 0x00A18C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060052D8 RID: 21208 RVA: 0x00A1AA3C File Offset: 0x00A18C3C
	internal static bool QvqAKG5hV7GufcjOURQH()
	{
		return true;
	}

	// Token: 0x060052D9 RID: 21209 RVA: 0x00A1AA40 File Offset: 0x00A18C40
	internal static bool Kuhn555ht0GHUp6udPFE()
	{
		return false;
	}

	// Token: 0x04005C2D RID: 23597
	public GameObject mTarget;

	// Token: 0x04005C2E RID: 23598
	private float Y7acIl5FHtL;

	// Token: 0x04005C2F RID: 23599
	private float JlXcIGcAorZ;

	// Token: 0x04005C30 RID: 23600
	private ProjectileControl XhrcI1O8WA1;
}
