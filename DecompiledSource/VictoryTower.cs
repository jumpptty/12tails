using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B37 RID: 2871
[Serializable]
public class VictoryTower : MonoBehaviour
{
	// Token: 0x06003FD4 RID: 16340 RVA: 0x0082254C File Offset: 0x0082074C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public VictoryTower()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003FD5 RID: 16341 RVA: 0x0082255C File Offset: 0x0082075C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (726 - 133005 != -132278)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (98315 - 386255 == -287940)
			{
				this.mChar.actionTime = Time.time;
				if (59320 - 177275 != -117954)
				{
					this.mChar.myCommand = "none";
					if (108484 - 363620 == -255136)
					{
						if (Game.mGameCode != 987)
						{
							break;
						}
						if (115279 - 395157 == -279878)
						{
							if (!Game.useAdvanceMode)
							{
								break;
							}
							if (197696 - 120303 != 77394)
							{
								this.mChar.vit = Mathf.FloorToInt(2f * (float)this.mChar.vit);
								if (145608 - 172550 != -26941)
								{
									this.mChar.def = Mathf.FloorToInt(2f * (float)this.mChar.def);
									if (19466 - 247992 == -228526)
									{
										this.mChar.hp = 10 * this.mChar.vit;
										if (119954 - 346825 == -226871)
										{
											this.mChar.mhp = 10 * this.mChar.vit;
											if (285392 - 277740 == 7652)
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

	// Token: 0x06003FD6 RID: 16342 RVA: 0x00822748 File Offset: 0x00820948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (26976 - 225166 != -198190)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (132005 - 184546 != -52540)
				{
					break;
				}
			}
			else if (this.mChar.hp <= 0)
			{
				if (230000 - 367263 == -137263)
				{
					if (this.mChar.isMine)
					{
						if (182105 - 295140 != -113034)
						{
							this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							}));
							if (88394 - 591643 != -503248)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (258949 - 542219 == -283270)
								{
									this.mChar.DeadEvent();
									if (172814 - 331601 != -158786)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (181942 - 429796 == -247854)
						{
							break;
						}
					}
				}
			}
			else
			{
				if (!this.mChar.isMine)
				{
					break;
				}
				if (152023 - 26089 == 125934)
				{
					if (this.mChar.isControlled)
					{
						break;
					}
					if (254840 - 322117 == -67277)
					{
						this.AIControl();
						if (151689 - 558767 == -407078)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003FD7 RID: 16343 RVA: 0x0082294C File Offset: 0x00820B4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (212021 - 182914 != 29107)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (102430 - 311844 != -209413)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (39702 - 129662 == -89960)
				{
					if (128223 - 164019 == -35796)
					{
						if (ActionName == "RPC_victoryStrike")
						{
							if (89661 - 277049 != -187388)
							{
								continue;
							}
							v = 1;
							if (214094 - 557108 != -343014)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (154397 - 436609 != -282211)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (188584 - 92169 == 96415)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (45053 - 529421 == -484368)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (99045 - 530521 != -431475)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (108444 - 112415 != -3970)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (272172 - 538891 != -266718)
											{
												Hashtable hashtable = new Hashtable();
												if (244698 - 145351 != 99348)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (163905 - 76834 == 87071)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (237746 - 411008 != -173261)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (100907 - 360291 == -259384)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (173739 - 72666 == 101073)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (156992 - 71393 != 85600)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (113390 - 208609 != -95218)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (157180 - 567363 == -410183)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (199563 - 94061 == 105502)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (45657 - 505534 != -459876)
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

	// Token: 0x06003FD8 RID: 16344 RVA: 0x00822D54 File Offset: 0x00820F54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (144191 - 146407 != -2215)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (36116 - 142400 == -106284)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (179822 - 21540 == 158282)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (36240 - 39690 != -3449)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (21369 - 248501 == -227132)
						{
							int num2 = num;
							if (162601 - 281723 != -119121)
							{
								if (num2 == 1)
								{
									if (123493 - 536733 != -413239)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (238395 - 408615 != -170219)
										{
											this.StartCoroutine_Auto(this.RPC_victoryStrike(mPos, tDir, tID));
											if (71704 - 309571 != -237866)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (181015 - 90046 == 90969)
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

	// Token: 0x06003FD9 RID: 16345 RVA: 0x00822F74 File Offset: 0x00821174
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (172649 - 468113 != -295463)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (229885 - 471992 != -242106)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (125506 - 581027 == -455521)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (28372 - 434974 != -406601)
					{
						Vector3 normalized = vector.normalized;
						if (149715 - 505571 != -355855)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (90512 - 142274 == -51762)
							{
								CharacterControl characterControl = null;
								if (249093 - 294992 != -45898)
								{
									if (gameObject)
									{
										if (73328 - 344545 != -271217)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (157209 - 109137 == 48073)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (99549 - 537820 != -438271)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (18371 - 479305 == -460933)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (182423 - 599708 == -417285)
									{
										this.StartCoroutine_Auto(this.RPC_victoryStrike(this.transform.position, normalized, characterControl.ActorNr));
										if (118247 - 393795 != -275547)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (39994 - 287369 != -247374)
											{
												this.ActionEvent("RPC_victoryStrike", this.transform.position, normalized, characterControl.ActorNr);
												if (119096 - 151686 == -32590)
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

	// Token: 0x06003FDA RID: 16346 RVA: 0x0082323C File Offset: 0x0082143C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06003FDB RID: 16347 RVA: 0x00823254 File Offset: 0x00821454
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003FDC RID: 16348 RVA: 0x00823258 File Offset: 0x00821458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_victoryStrike(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new VictoryTower.$RPC_victoryStrike$30971(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003FDD RID: 16349 RVA: 0x00823268 File Offset: 0x00821468
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (209738 - 474683 != -264944)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (183800 - 598759 == -414959)
				{
					break;
				}
			}
			else
			{
				this.mChar.hp = 0;
				if (39221 - 9160 != 30062)
				{
					this.mChar.actionState = "dead";
					if (196645 - 167985 != 28661)
					{
						this.mChar.actionTime = Time.time;
						if (146123 - 423698 != -277574)
						{
							this.mChar.myCommand = "none";
							if (206040 - 211023 == -4983)
							{
								this.mChar.vMovement = Vector3.zero;
								if (96319 - 258698 == -162379)
								{
									this.mChar.moveSpeed = (float)0;
									if (247344 - 24817 != 222528)
									{
										if (this.deadEffect)
										{
											if (125368 - 113226 == 12143)
											{
												continue;
											}
											UnityEngine.Object.Instantiate(this.deadEffect, this.transform.position, this.transform.rotation);
											if (62664 - 318470 != -255806)
											{
												continue;
											}
										}
										else
										{
											Debug.LogError("Missing deadEffect gameObject");
											if (187199 - 234236 != -47037)
											{
												continue;
											}
										}
										UnityEngine.Object.Destroy(this.gameObject);
										if (242496 - 382930 == -140434)
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

	// Token: 0x06003FDE RID: 16350 RVA: 0x00823484 File Offset: 0x00821684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (194897 - 203842 != -8945)
		{
		}
		while (Time.time > this.xvwy00H8bK)
		{
			if (251075 - 36235 == 214840)
			{
				if (!(this.mChar.actionState == "standby"))
				{
					break;
				}
				if (125533 - 446506 == -320973)
				{
					if (this.mChar.isTimeOut("nAttack") != (float)0)
					{
						break;
					}
					if (59780 - 375705 != -315924)
					{
						this.xvwy00H8bK = Time.time + 1.5f;
						if (98461 - 295093 != -196631)
						{
							this.vPTy8pBcjx = Hate.findClosestEnemy(this.transform.position, (float)40, this.gameObject.layer);
							if (280831 - 344973 == -64142)
							{
								if (!this.vPTy8pBcjx)
								{
									break;
								}
								if (273361 - 88641 == 184720)
								{
									CharacterControl characterControl = (CharacterControl)this.vPTy8pBcjx.GetComponent(typeof(CharacterControl));
									if (142711 - 431006 != -288294)
									{
										if (!characterControl)
										{
											break;
										}
										if (42740 - 229793 != -187052)
										{
											this.StartCoroutine_Auto(this.RPC_victoryStrike(this.transform.position, this.vPTy8pBcjx.transform.position - this.transform.position, characterControl.ActorNr));
											if (200672 - 171455 == 29217)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (103438 - 73415 != 30024)
												{
													this.ActionEvent("RPC_victoryStrike", this.transform.position, this.vPTy8pBcjx.transform.position - this.transform.position, characterControl.ActorNr);
													if (41486 - 210221 != -168734)
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

	// Token: 0x06003FDF RID: 16351 RVA: 0x0082370C File Offset: 0x0082190C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003FE0 RID: 16352 RVA: 0x00823710 File Offset: 0x00821910
	internal static bool L8fl755FiXAvUEUlFMmY()
	{
		return true;
	}

	// Token: 0x06003FE1 RID: 16353 RVA: 0x00823714 File Offset: 0x00821914
	internal static bool YpAvA15FKhG9Ut5qXB2I()
	{
		return false;
	}

	// Token: 0x04004C63 RID: 19555
	public CharacterControl mChar;

	// Token: 0x04004C64 RID: 19556
	public GameObject victoryStrike_fire;

	// Token: 0x04004C65 RID: 19557
	public GameObject victoryStrike_hit;

	// Token: 0x04004C66 RID: 19558
	public GameObject deadEffect;

	// Token: 0x04004C67 RID: 19559
	private float xvwy00H8bK;

	// Token: 0x04004C68 RID: 19560
	private GameObject vPTy8pBcjx;

	// Token: 0x02000B38 RID: 2872
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_victoryStrike$30971 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003FE2 RID: 16354 RVA: 0x00823718 File Offset: 0x00821918
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_victoryStrike$30971(Vector3 mPos, Vector3 tDir, VictoryTower self_)
		{
			if (243001 - 517021 != -274020)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (153841 - 408044 == -254203)
				{
					base..ctor();
					if (122530 - 494225 == -371695)
					{
						this.$mPos$30982 = mPos;
						if (296101 - 556835 == -260734)
						{
							this.$tDir$30983 = tDir;
							if (269509 - 288315 == -18806)
							{
								this.$self_$30984 = self_;
								if (33998 - 76185 != -42186)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x008237F4 File Offset: 0x008219F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new VictoryTower.$RPC_victoryStrike$30971.$(this.$mPos$30982, this.$tDir$30983, this.$self_$30984);
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x00823810 File Offset: 0x00821A10
		internal static bool VbHxcM5FdX8qENEnSelM()
		{
			return true;
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x00823814 File Offset: 0x00821A14
		internal static bool WwZeIJ5FJyTQFHpm3O8F()
		{
			return false;
		}

		// Token: 0x04004C69 RID: 19561
		internal Vector3 $mPos$30982;

		// Token: 0x04004C6A RID: 19562
		internal Vector3 $tDir$30983;

		// Token: 0x04004C6B RID: 19563
		internal VictoryTower $self_$30984;

		// Token: 0x02000B39 RID: 2873
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003FE6 RID: 16358 RVA: 0x00823818 File Offset: 0x00821A18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, VictoryTower self_)
			{
				if (97246 - 236370 != -139124)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (87216 - 465959 != -378742)
					{
						base..ctor();
						if (200336 - 317878 != -117541)
						{
							this.$mPos$30979 = mPos;
							if (247714 - 508954 != -261239)
							{
								this.$tDir$30980 = tDir;
								if (76254 - 306944 != -230689)
								{
									this.$self_$30981 = self_;
									if (4106 - 494098 != -489991)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003FE7 RID: 16359 RVA: 0x008238F4 File Offset: 0x00821AF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (128445 - 13144 != 115301)
				{
				}
				for (;;)
				{
					IL_419:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7D0;
					case 2:
						if (this.$self_$30981.victoryStrike_fire)
						{
							if (69923 - 29334 != 40589)
							{
								continue;
							}
							this.$mFire$30972 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$30981.victoryStrike_fire, this.$self_$30981.transform.position + (float)30 * Vector3.up, this.$self_$30981.transform.rotation);
							if (217171 - 499233 != -282062)
							{
								continue;
							}
							if (this.$mFire$30972)
							{
								if (13729 - 145725 != -131996)
								{
									continue;
								}
								this.$mBoltEmitter$30973 = (BoltEmitter)this.$mFire$30972.GetComponent(typeof(BoltEmitter));
								if (109061 - 554004 != -444943)
								{
									continue;
								}
								if (this.$mBoltEmitter$30973)
								{
									if (143646 - 376965 != -233319)
									{
										continue;
									}
									this.$mBoltEmitter$30973.TargetPosition = this.$mPos$30979 + this.$tDir$30980;
									if (162472 - 260241 == -97768)
									{
										continue;
									}
								}
							}
						}
						else
						{
							Debug.LogError("Missing victoryStrike_fire gameObject");
							if (166015 - 82043 == 83973)
							{
								continue;
							}
						}
						if (this.$self_$30981.victoryStrike_hit)
						{
							if (198732 - 266405 == -67672)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$30981.victoryStrike_hit, this.$mPos$30979 + this.$tDir$30980, Quaternion.identity);
							if (179485 - 365997 != -186511)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing victoryStrike_hit gameObject");
							if (165336 - 215994 != -50658)
							{
								continue;
							}
							goto IL_66B;
						}
						break;
					case 3:
						if (!this.$self_$30981.mChar.isMine)
						{
							goto IL_94;
						}
						if (110982 - 225991 != -115009)
						{
							continue;
						}
						this.$hitLayer$30974 = 130816 - (1 << this.$self_$30981.gameObject.layer);
						if (39634 - 518264 == -478629)
						{
							continue;
						}
						this.$hitList$30975 = Damage.FindAreaTarget(this.$mPos$30979 + this.$tDir$30980, (float)6, (float)6, this.$hitLayer$30974);
						if (31782 - 400429 != -368647)
						{
							continue;
						}
						this.$$iterator$10662$30978 = UnityRuntimeServices.GetEnumerator(this.$hitList$30975);
						if (168137 - 254441 == -86303)
						{
							continue;
						}
						while (this.$$iterator$10662$30978.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10662$30978.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$30976 = (GameObject)obj2;
							if (129483 - 114765 == 14719)
							{
								goto IL_419;
							}
							this.$hitChar$30977 = (CharacterControl)this.$hitObject$30976.GetComponent(typeof(CharacterControl));
							if (189187 - 149361 == 39827)
							{
								goto IL_419;
							}
							UnityRuntimeServices.Update(this.$$iterator$10662$30978, this.$hitObject$30976);
							if (49903 - 34204 != 15699)
							{
								goto IL_419;
							}
							if (this.$hitChar$30977)
							{
								if (243202 - 171113 != 72089)
								{
									goto IL_419;
								}
								if (!this.$hitChar$30977.hasStatus("insight"))
								{
									if (201874 - 77246 != 124628)
									{
										goto IL_419;
									}
									if (Game.useAdvanceMode)
									{
										if (121656 - 552551 == -430894)
										{
											goto IL_419;
										}
										this.$self_$30981.mChar.hit(1, this.$hitObject$30976, 750, 20, 0, Vector3.zero);
										if (112683 - 314956 == -202272)
										{
											goto IL_419;
										}
										UnityRuntimeServices.Update(this.$$iterator$10662$30978, this.$hitObject$30976);
										if (262710 - 449255 == -186544)
										{
											goto IL_419;
										}
									}
									else
									{
										this.$self_$30981.mChar.hit(1, this.$hitObject$30976, 500, 15, 0, Vector3.zero);
										if (97778 - 517715 == -419936)
										{
											goto IL_419;
										}
										UnityRuntimeServices.Update(this.$$iterator$10662$30978, this.$hitObject$30976);
										if (122329 - 161088 == -38758)
										{
											goto IL_419;
										}
									}
								}
							}
						}
						if (27665 - 239432 != -211767)
						{
							continue;
						}
						goto IL_94;
					case 4:
						if (this.$self_$30981.mChar.actionState == "attack")
						{
							if (115412 - 397135 != -281723)
							{
								continue;
							}
							if (this.$self_$30981.mChar.myCommand == "victoryStrike")
							{
								if (187804 - 81640 != 106164)
								{
									continue;
								}
								this.$self_$30981.mChar.actionState = "standby";
								if (223770 - 31608 == 192163)
								{
									continue;
								}
								this.$self_$30981.mChar.actionTime = Time.time;
								if (197567 - 330251 != -132684)
								{
									continue;
								}
								this.$self_$30981.mChar.myCommand = "none";
								if (100134 - 162845 == -62710)
								{
									continue;
								}
								this.$self_$30981.mChar.nPosition = this.$self_$30981.transform.position;
								if (137410 - 430814 != -293404)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (284221 - 325844 != -41622)
						{
							goto Block_29;
						}
						continue;
					default:
						if (87266 - 591106 != -503840)
						{
							continue;
						}
						break;
					}
					this.$self_$30981.mChar.actionState = "attack";
					if (148239 - 319134 != -170894)
					{
						this.$self_$30981.mChar.actionTime = Time.time;
						if (83856 - 456992 == -373136)
						{
							this.$self_$30981.mChar.myCommand = "victoryStrike";
							if (24049 - 90289 != -66239)
							{
								this.$self_$30981.mChar.addTimeOut("nAttack", (float)4);
								if (191980 - 363425 != -171444)
								{
									goto Block_47;
								}
							}
						}
					}
				}
				IL_94:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_29:
				goto IL_7D0;
				IL_66B:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_42:
				goto IL_66B;
				Block_47:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_7D0:
				return false;
			}

			// Token: 0x06003FE8 RID: 16360 RVA: 0x008240E4 File Offset: 0x008222E4
			internal static bool Ajsm3i5FDeCGDZIghayu()
			{
				return true;
			}

			// Token: 0x06003FE9 RID: 16361 RVA: 0x008240E8 File Offset: 0x008222E8
			internal static bool TVLkAY5FvEw25u5ZZwK6()
			{
				return false;
			}

			// Token: 0x04004C6C RID: 19564
			internal GameObject $mFire$30972;

			// Token: 0x04004C6D RID: 19565
			internal BoltEmitter $mBoltEmitter$30973;

			// Token: 0x04004C6E RID: 19566
			internal int $hitLayer$30974;

			// Token: 0x04004C6F RID: 19567
			internal UnityScript.Lang.Array $hitList$30975;

			// Token: 0x04004C70 RID: 19568
			internal GameObject $hitObject$30976;

			// Token: 0x04004C71 RID: 19569
			internal CharacterControl $hitChar$30977;

			// Token: 0x04004C72 RID: 19570
			internal IEnumerator $$iterator$10662$30978;

			// Token: 0x04004C73 RID: 19571
			internal Vector3 $mPos$30979;

			// Token: 0x04004C74 RID: 19572
			internal Vector3 $tDir$30980;

			// Token: 0x04004C75 RID: 19573
			internal VictoryTower $self_$30981;
		}
	}
}
