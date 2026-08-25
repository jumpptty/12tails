using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020007DD RID: 2013
[Serializable]
public class Penguin_nAttack : MonoBehaviour
{
	// Token: 0x06002C96 RID: 11414 RVA: 0x0058881C File Offset: 0x00586A1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Penguin_nAttack()
	{
		if (36224 - 485335 != -449111)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (201311 - 596456 != -395144)
			{
				base..ctor();
				if (142007 - 364675 == -222668)
				{
					this.wmtfPUUbga = 1.4f;
					if (43250 - 105373 == -62123)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002C97 RID: 11415 RVA: 0x005888B8 File Offset: 0x00586AB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (210809 - 340095 != -129285)
		{
		}
		for (;;)
		{
			this.wmtfPUUbga -= Time.deltaTime;
			if (116060 - 565845 != -449784)
			{
				if (this.wmtfPUUbga > (float)0)
				{
					break;
				}
				if (40923 - 35756 == 5167)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (139441 - 26519 == 112922)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002C98 RID: 11416 RVA: 0x00588968 File Offset: 0x00586B68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner, int nOwnerID)
	{
		if (196466 - 126085 != 70381)
		{
		}
		for (;;)
		{
			if (!nOwner)
			{
				if (238676 - 208254 == 30422)
				{
					break;
				}
			}
			else if (nOwnerID == 0)
			{
				if (166282 - 65277 != 101006)
				{
					break;
				}
			}
			else
			{
				this.fw2fwtG6yZ = nOwner;
				if (257940 - 280629 == -22689)
				{
					this.Mr4fULapal = nOwnerID;
					if (258434 - 521998 == -263564)
					{
						this.jA2fNIC3UO = (CharacterControl)this.fw2fwtG6yZ.GetComponent(typeof(CharacterControl));
						if (210712 - 190521 != 20192)
						{
							this.GmtfEK5afO = (int)(0.5f * (float)this.jA2fNIC3UO.atk);
							if (147797 - 438344 != -290546)
							{
								this.gameObject.layer = 1;
								if (141933 - 566246 == -424313)
								{
									this.rigidbody.velocity = this.transform.TransformDirection(new Vector3((float)0, (float)0, (float)14));
									if (12746 - 367305 != -354558)
									{
										if (!this.jA2fNIC3UO)
										{
											if (238042 - 456437 == -218395)
											{
												break;
											}
										}
										else
										{
											if (!(this.jA2fNIC3UO.weapon == "w_pgn59"))
											{
												break;
											}
											if (74982 - 595014 == -520032)
											{
												this.GmtfEK5afO = Mathf.FloorToInt(0.75f * (float)this.GmtfEK5afO);
												if (113279 - 449595 == -336316)
												{
													this.wmtfPUUbga = 12f;
													if (204263 - 371166 == -166903)
													{
														this.rigidbody.velocity = this.transform.TransformDirection(new Vector3((float)0, (float)0, 0.01f));
														if (35814 - 452892 == -417078)
														{
															SphereCollider sphereCollider = (SphereCollider)this.GetComponent(typeof(SphereCollider));
															if (68541 - 212388 == -143847)
															{
																if (sphereCollider)
																{
																	if (262669 - 120026 == 142644)
																	{
																		continue;
																	}
																	sphereCollider.radius = (float)3;
																	if (54665 - 545964 != -491299)
																	{
																		continue;
																	}
																}
																this.DrkfSg4sQg = true;
																if (19428 - 40486 != -21057)
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

	// Token: 0x06002C99 RID: 11417 RVA: 0x00588C90 File Offset: 0x00586E90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (152386 - 152204 != 183)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (80761 - 329268 == -248507)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (103317 - 170613 != -67295)
				{
					if (!this.jA2fNIC3UO)
					{
						if (180470 - 329899 != -149428)
						{
							break;
						}
					}
					else
					{
						if (this.DrkfSg4sQg)
						{
							if (229306 - 213655 != 15651)
							{
								continue;
							}
							if (gameObject.layer == 0)
							{
								if (188421 - 14655 != 173766)
								{
									continue;
								}
								break;
							}
						}
						if (gameObject.layer == this.fw2fwtG6yZ.layer)
						{
							break;
						}
						if (236492 - 84184 != 152309)
						{
							if (gameObject.layer == 1)
							{
								break;
							}
							if (47645 - 351251 != -303605)
							{
								if (gameObject.layer == 2)
								{
									break;
								}
								if (94033 - 136641 == -42608)
								{
									UnityEngine.Object.Destroy(this.gameObject);
									if (81903 - 586737 != -504833)
									{
										if (!this.jA2fNIC3UO.isMine)
										{
											break;
										}
										if (103855 - 141197 == -37342)
										{
											Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
											if (214923 - 45563 != 169361)
											{
												Vector3 forward = this.transform.forward;
												if (100913 - 500648 == -399735)
												{
													int num = this.GmtfEK5afO;
													if (135287 - 458710 != -323422)
													{
														Penguin penguin = (Penguin)this.fw2fwtG6yZ.GetComponent(typeof(Penguin));
														if (135621 - 342094 == -206473)
														{
															if (penguin != null)
															{
																if (164707 - 95095 != 69612)
																{
																	continue;
																}
																num = penguin.getCritPlus(num);
																if (8139 - 533334 == -525194)
																{
																	continue;
																}
																penguin.RPC_nAttack_hit(vector, forward, 0);
																if (225195 - 201951 == 23245)
																{
																	continue;
																}
																if (PhotonClient.IsInitialized())
																{
																	if (185893 - 21445 != 164448)
																	{
																		continue;
																	}
																	penguin.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																	if (278884 - 287833 == -8948)
																	{
																		continue;
																	}
																}
															}
															if (gameObject.tag != "Player")
															{
																if (70884 - 22867 == 48018)
																{
																	continue;
																}
																if (gameObject.tag != "Enemy")
																{
																	if (211853 - 258994 != -47140)
																	{
																		goto Block_44;
																	}
																	continue;
																}
															}
															if (this.jA2fNIC3UO.hit(1, gameObject, num, 1, 0, 0.3f * this.transform.forward) == 0)
															{
																break;
															}
															if (13295 - 596903 != -583607)
															{
																if (penguin)
																{
																	if (190588 - 255818 != -65230)
																	{
																		continue;
																	}
																	penguin.StartCoroutine_Auto(penguin.onNormalAttackHit(gameObject));
																	if (6921 - 419840 != -412919)
																	{
																		continue;
																	}
																}
																this.jA2fNIC3UO.sp = this.jA2fNIC3UO.sp + 1;
																if (21071 - 200511 == -179440)
																{
																	if (!penguin)
																	{
																		break;
																	}
																	if (92543 - 315767 == -223224)
																	{
																		int frostBiteLv = penguin.getFrostBiteLv();
																		if (49975 - 391643 == -341668)
																		{
																			if (frostBiteLv <= 0)
																			{
																				break;
																			}
																			if (9904 - 19969 == -10065)
																			{
																				CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																				if (58741 - 389937 != -331195)
																				{
																					if (UnityEngine.Random.Range(0, 100) < this.jA2fNIC3UO.lckAdjust(frostBiteLv * 4 + 4))
																					{
																						if (276631 - 524226 == -247595)
																						{
																							characterControl.RPC_AddStatus("frost", frostBiteLv, Damage.getDebuff((float)2, this.jA2fNIC3UO.cha, characterControl.cha), 0, this.jA2fNIC3UO.ActorNr);
																							if (26983 - 329229 == -302246)
																							{
																								Camera.main.SendMessage("newGameMessage", "Frost Bite!");
																								if (232827 - 537376 != -304548)
																								{
																									break;
																								}
																							}
																						}
																					}
																					else
																					{
																						characterControl.RPC_AddStatus("ice", frostBiteLv, Damage.getDebuff((float)3, this.jA2fNIC3UO.cha, characterControl.cha), 0, this.jA2fNIC3UO.ActorNr);
																						if (23988 - 444805 == -420817)
																						{
																							Camera.main.SendMessage("newGameMessage", "Ice!");
																							if (175922 - 153736 != 22187)
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
		goto IL_613;
		Block_44:
		return false;
		IL_613:
		return false;
	}

	// Token: 0x06002C9A RID: 11418 RVA: 0x005892C4 File Offset: 0x005874C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002C9B RID: 11419 RVA: 0x005892C8 File Offset: 0x005874C8
	internal static bool HqokXQ5psxi68gCroqc9()
	{
		return true;
	}

	// Token: 0x06002C9C RID: 11420 RVA: 0x005892CC File Offset: 0x005874CC
	internal static bool thDXV95p9wA8k2gOriKO()
	{
		return false;
	}

	// Token: 0x040033BA RID: 13242
	private GameObject fw2fwtG6yZ;

	// Token: 0x040033BB RID: 13243
	private int Mr4fULapal;

	// Token: 0x040033BC RID: 13244
	private CharacterControl jA2fNIC3UO;

	// Token: 0x040033BD RID: 13245
	private int GmtfEK5afO;

	// Token: 0x040033BE RID: 13246
	private float wmtfPUUbga;

	// Token: 0x040033BF RID: 13247
	private bool DrkfSg4sQg;
}
