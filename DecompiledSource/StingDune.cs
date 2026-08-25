using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000223 RID: 547
[Serializable]
public class StingDune : MonoBehaviour
{
	// Token: 0x06000C6A RID: 3178 RVA: 0x0013E3B4 File Offset: 0x0013C5B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StingDune()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x0013E3C4 File Offset: 0x0013C5C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (175084 - 364452 != -189367)
		{
		}
		for (;;)
		{
			this.jdDeKLeaTI = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (279350 - 161204 != 118147)
			{
				this.jdDeKLeaTI.actionState = "standby";
				if (131238 - 322539 != -191300)
				{
					this.jdDeKLeaTI.actionTime = Time.time;
					if (151774 - 13639 == 138135)
					{
						this.jdDeKLeaTI.myCommand = "none";
						if (288574 - 251658 != 36917)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (80236 - 419444 == -339208)
							{
								this.jdDeKLeaTI.isMine = true;
								if (34069 - 539297 != -505227)
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

	// Token: 0x06000C6C RID: 3180 RVA: 0x0013E4FC File Offset: 0x0013C6FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (73679 - 410069 != -336390)
		{
		}
		for (;;)
		{
			if (this.jdDeKLeaTI.isControlled)
			{
				if (179748 - 211270 == -31521)
				{
					continue;
				}
				if (!(this.jdDeKLeaTI.actionState == "standby"))
				{
					if (263658 - 253703 == 9956)
					{
						continue;
					}
					if (!(this.jdDeKLeaTI.actionState == "run"))
					{
						goto IL_13E;
					}
					if (187477 - 354338 == -166860)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (125596 - 106096 == 19501)
				{
					continue;
				}
			}
			IL_13E:
			if (this.jdDeKLeaTI.hp <= 0)
			{
				if (31959 - 59565 != -27606)
				{
					continue;
				}
				if (this.jdDeKLeaTI.actionState != "dead")
				{
					if (252085 - 526029 == -273943)
					{
						continue;
					}
					if (this.jdDeKLeaTI.isMine)
					{
						if (251828 - 539350 != -287522)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (209005 - 159243 != 49762)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (282982 - 329513 == -46530)
						{
							continue;
						}
						this.jdDeKLeaTI.DeadEvent();
						if (214620 - 345219 != -130598)
						{
							break;
						}
						continue;
					}
					else
					{
						this.jdDeKLeaTI.hp = 1;
						if (175515 - 17798 != 157717)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.jdDeKLeaTI.hp <= 0)
			{
				break;
			}
			if (45212 - 369316 == -324104)
			{
				if (!(this.jdDeKLeaTI.actionState != "dead"))
				{
					break;
				}
				if (163539 - 26405 != 137135)
				{
					if (this.jdDeKLeaTI.myDamage != -1)
					{
						break;
					}
					if (163456 - 262004 != -98547)
					{
						if (!this.jdDeKLeaTI.isMine)
						{
							break;
						}
						if (185094 - 478095 != -293000)
						{
							if (this.jdDeKLeaTI.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (171109 - 366524 == -195415)
							{
								this.StartCoroutine_Auto(this.RPC_getHit());
								if (192085 - 102163 == 89922)
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

	// Token: 0x06000C6D RID: 3181 RVA: 0x0013E848 File Offset: 0x0013CA48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x0013E84C File Offset: 0x0013CA4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x06000C6F RID: 3183 RVA: 0x0013E864 File Offset: 0x0013CA64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x0013E868 File Offset: 0x0013CA68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000C71 RID: 3185 RVA: 0x0013E86C File Offset: 0x0013CA6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_getHit()
	{
		return new StingDune.$RPC_getHit$17417(this).GetEnumerator();
	}

	// Token: 0x06000C72 RID: 3186 RVA: 0x0013E87C File Offset: 0x0013CA7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_createBug(string nType, Vector3 nPos, Vector3 nDir)
	{
		if (165432 - 234208 != -68776)
		{
		}
		while (PhotonClient.IsInitialized())
		{
			if (128665 - 435492 != -306826)
			{
				Hashtable hashtable = new Hashtable();
				if (164304 - 438631 == -274327)
				{
					hashtable.Add(43, PlayerData.UID);
					if (212226 - 373593 != -161366)
					{
						hashtable.Add(73, nType);
						if (241437 - 430048 != -188610)
						{
							hashtable.Add(75, PhotonClient.cInt16(6));
							if (73305 - 467284 != -393978)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (46741 - 279566 == -232825)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (80161 - 272584 != -192422)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (249184 - 404898 != -155713)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (280377 - 83017 == 197360)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
												if (110489 - 439606 == -329117)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
													if (252509 - 482861 == -230352)
													{
														PhotonClient.Connection.OpCustom(63, hashtable, true);
														if (126131 - 279213 == -153082)
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

	// Token: 0x06000C73 RID: 3187 RVA: 0x0013EB58 File Offset: 0x0013CD58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (139630 - 370898 != -231268)
		{
		}
		for (;;)
		{
			if (this.jdDeKLeaTI.actionState == "dead")
			{
				if (28711 - 212947 == -184236)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (7687 - 71874 == -64187)
				{
					Vector3 b = (Vector3)nArray[1];
					if (53625 - 190404 == -136779)
					{
						this.transform.position = vector;
						if (155624 - 447926 != -292301)
						{
							this.transform.LookAt(vector + b);
							if (143801 - 361550 != -217748)
							{
								this.jdDeKLeaTI.hp = 0;
								if (185274 - 177816 == 7458)
								{
									this.jdDeKLeaTI.actionState = "dead";
									if (121585 - 129704 == -8119)
									{
										this.jdDeKLeaTI.actionTime = Time.time;
										if (149054 - 67229 == 81825)
										{
											this.jdDeKLeaTI.myCommand = "none";
											if (85601 - 445136 == -359535)
											{
												this.jdDeKLeaTI.vMovement = Vector3.zero;
												if (13850 - 67193 == -53343)
												{
													this.jdDeKLeaTI.moveSpeed = (float)0;
													if (1228 - 315478 == -314250)
													{
														this.animation.Rewind();
														if (76985 - 84125 == -7140)
														{
															this.animation.Play("destroy");
															if (85527 - 317845 != -232317)
															{
																this.animation.wrapMode = WrapMode.Once;
																if (143221 - 559368 == -416147)
																{
																	if (!this.deadEffect)
																	{
																		break;
																	}
																	if (149977 - 441068 == -291091)
																	{
																		UnityEngine.Object.Instantiate(this.deadEffect, this.transform.position, this.transform.rotation);
																		if (3153 - 400793 != -397639)
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

	// Token: 0x06000C74 RID: 3188 RVA: 0x0013EE44 File Offset: 0x0013D044
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x0013EE48 File Offset: 0x0013D048
	internal static bool hNuE5fAdFNMAc8GAgCM()
	{
		return true;
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x0013EE4C File Offset: 0x0013D04C
	internal static bool o7ke6qAJY4Y4YKHF1mR()
	{
		return false;
	}

	// Token: 0x04000AF3 RID: 2803
	private CharacterControl jdDeKLeaTI;

	// Token: 0x04000AF4 RID: 2804
	private int fXKezPSJYJ;

	// Token: 0x04000AF5 RID: 2805
	public GameObject deadEffect;

	// Token: 0x02000224 RID: 548
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_getHit$17417 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000C77 RID: 3191 RVA: 0x0013EE50 File Offset: 0x0013D050
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_getHit$17417(StingDune self_)
		{
			if (48894 - 579787 != -530892)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (270385 - 17878 != 252508)
				{
					base..ctor();
					if (258199 - 560901 == -302702)
					{
						this.$self_$17423 = self_;
						if (108529 - 88320 == 20209)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0013EEE8 File Offset: 0x0013D0E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingDune.$RPC_getHit$17417.$(this.$self_$17423);
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0013EEF8 File Offset: 0x0013D0F8
		internal static bool M3KhI2ADIf7R71CKE2V()
		{
			return true;
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0013EEFC File Offset: 0x0013D0FC
		internal static bool kTPyi4AvUFI3REdpjX3()
		{
			return false;
		}

		// Token: 0x04000AF6 RID: 2806
		internal StingDune $self_$17423;

		// Token: 0x02000225 RID: 549
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000C7B RID: 3195 RVA: 0x0013EF00 File Offset: 0x0013D100
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(StingDune self_)
			{
				if (33089 - 495031 != -461942)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (40379 - 517663 != -477283)
					{
						base..ctor();
						if (146494 - 576898 == -430404)
						{
							this.$self_$17422 = self_;
							if (101941 - 136455 == -34514)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000C7C RID: 3196 RVA: 0x0013EF98 File Offset: 0x0013D198
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (19050 - 385474 != -366424)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_813;
					case 2:
						if (this.$self_$17422.jdDeKLeaTI.actionState == "attack")
						{
							if (263056 - 442426 != -179370)
							{
								continue;
							}
							if (this.$self_$17422.jdDeKLeaTI.myCommand == "sting")
							{
								if (185429 - 419636 != -234207)
								{
									continue;
								}
								this.$self_$17422.jdDeKLeaTI.moveSpeed = (float)0;
								if (133942 - 114980 == 18963)
								{
									continue;
								}
								this.$self_$17422.jdDeKLeaTI.actionState = "standby";
								if (73462 - 104273 != -30811)
								{
									continue;
								}
								this.$self_$17422.jdDeKLeaTI.actionTime = Time.time;
								if (190128 - 68005 == 122124)
								{
									continue;
								}
								this.$self_$17422.jdDeKLeaTI.myCommand = "none";
								if (214539 - 534877 != -320338)
								{
									continue;
								}
								if (!this.$self_$17422.jdDeKLeaTI.isMine)
								{
									if (204413 - 333134 != -128721)
									{
										continue;
									}
									this.$self_$17422.jdDeKLeaTI.nPosition = this.$self_$17422.transform.position;
									if (248819 - 28183 != 220636)
									{
										continue;
									}
									this.$self_$17422.jdDeKLeaTI.oPosition = this.$self_$17422.transform.position;
									if (190036 - 556648 != -366612)
									{
										continue;
									}
									this.$self_$17422.jdDeKLeaTI.nDirection = this.$self_$17422.transform.forward;
									if (38179 - 496783 != -458604)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (90713 - 471578 != -380864)
						{
							goto Block_40;
						}
						continue;
					default:
						if (9785 - 48430 == -38644)
						{
							continue;
						}
						break;
					}
					this.$self_$17422.jdDeKLeaTI.actionState = "attack";
					if (283033 - 129360 != 153674)
					{
						this.$self_$17422.jdDeKLeaTI.actionTime = Time.time;
						if (282403 - 103537 != 178867)
						{
							this.$self_$17422.jdDeKLeaTI.myCommand = "gotHit";
							if (275248 - 464009 == -188761)
							{
								this.$self_$17422.jdDeKLeaTI.addTimeOut("nAttack", (float)3);
								if (36002 - 567549 == -531547)
								{
									this.$self_$17422.animation.CrossFade("getHit");
									if (162803 - 192917 == -30114)
									{
										this.$self_$17422.animation.wrapMode = WrapMode.Once;
										if (297034 - 38852 == 258182)
										{
											if (!this.$self_$17422.jdDeKLeaTI.isMine)
											{
												break;
											}
											if (117866 - 209200 != -91333)
											{
												if (this.$self_$17422.fXKezPSJYJ * 200 >= this.$self_$17422.jdDeKLeaTI.mhp - this.$self_$17422.jdDeKLeaTI.hp)
												{
													break;
												}
												if (278182 - 100673 == 177509)
												{
													this.$self_$17422.fXKezPSJYJ = this.$self_$17422.fXKezPSJYJ + 1;
													if (182566 - 285037 != -102470)
													{
														if ((float)UnityEngine.Random.Range(0, 100) < (float)20 + 0.03f * (float)this.$self_$17422.jdDeKLeaTI.hp)
														{
															if (13697 - 454174 == -440477)
															{
																this.$nPosition1$17418 = global::Math.getSpawnPos(this.$self_$17422.transform.position + this.$self_$17422.transform.TransformDirection((float)0, (float)0, 7.5f));
																if (191688 - 99577 != 92112)
																{
																	this.$nPosition2$17419 = global::Math.getSpawnPos(this.$self_$17422.transform.position + this.$self_$17422.transform.TransformDirection(2.5f, (float)0, (float)-5));
																	if (62697 - 36057 == 26640)
																	{
																		this.$nPosition3$17420 = global::Math.getSpawnPos(this.$self_$17422.transform.position + this.$self_$17422.transform.TransformDirection(-2.5f, (float)0, (float)-5));
																		if (38082 - 40697 == -2615)
																		{
																			if (this.$nPosition1$17418 != Vector3.zero)
																			{
																				if (8610 - 521032 == -512421)
																				{
																					continue;
																				}
																				this.$self_$17422.RPC_createBug("StingBug2_y", this.$nPosition1$17418 + 0.1f * Vector3.up, this.$self_$17422.transform.forward);
																				if (32641 - 515586 == -482944)
																				{
																					continue;
																				}
																			}
																			if (this.$nPosition2$17419 != Vector3.zero)
																			{
																				if (254460 - 54478 == 199983)
																				{
																					continue;
																				}
																				this.$self_$17422.RPC_createBug("StingBug2_y", this.$nPosition2$17419 + 0.1f * Vector3.up, this.$self_$17422.transform.forward);
																				if (2282 - 467955 == -465672)
																				{
																					continue;
																				}
																			}
																			if (!(this.$nPosition3$17420 != Vector3.zero))
																			{
																				break;
																			}
																			if (9879 - 366546 != -356666)
																			{
																				this.$self_$17422.RPC_createBug("StingBug2_y", this.$nPosition3$17420 + 0.1f * Vector3.up, this.$self_$17422.transform.forward);
																				if (15505 - 273948 != -258442)
																				{
																					break;
																				}
																			}
																		}
																	}
																}
															}
														}
														else
														{
															this.$nPosition$17421 = global::Math.getSpawnPos(this.$self_$17422.transform.position + global::Math.rotateH((float)5 * Vector3.forward, (float)UnityEngine.Random.Range(0, 360)));
															if (100956 - 305916 == -204960)
															{
																if (!(this.$nPosition$17421 != Vector3.zero))
																{
																	break;
																}
																if (88913 - 106374 == -17461)
																{
																	this.$self_$17422.RPC_createBug("StingQueen", this.$nPosition$17421 + 0.1f * Vector3.up, global::Math.vFlat(this.$self_$17422.transform.position - this.$nPosition$17421).normalized);
																	if (146503 - 480076 == -333573)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_40:
				IL_813:
				return false;
			}

			// Token: 0x06000C7D RID: 3197 RVA: 0x0013F7CC File Offset: 0x0013D9CC
			internal static bool DgHUvyARgfBMSeIVZLC()
			{
				return true;
			}

			// Token: 0x06000C7E RID: 3198 RVA: 0x0013F7D0 File Offset: 0x0013D9D0
			internal static bool N8NPZFAwo2bGGgjl3ii()
			{
				return false;
			}

			// Token: 0x04000AF7 RID: 2807
			internal Vector3 $nPosition1$17418;

			// Token: 0x04000AF8 RID: 2808
			internal Vector3 $nPosition2$17419;

			// Token: 0x04000AF9 RID: 2809
			internal Vector3 $nPosition3$17420;

			// Token: 0x04000AFA RID: 2810
			internal Vector3 $nPosition$17421;

			// Token: 0x04000AFB RID: 2811
			internal StingDune $self_$17422;
		}
	}
}
