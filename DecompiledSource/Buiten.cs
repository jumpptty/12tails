using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000275 RID: 629
[Serializable]
public class Buiten : MonoBehaviour
{
	// Token: 0x06000E63 RID: 3683 RVA: 0x0016F6A8 File Offset: 0x0016D8A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Buiten()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x0016F6B8 File Offset: 0x0016D8B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (34995 - 524940 != -489945)
		{
		}
		for (;;)
		{
			this.eJMJ2G541u = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (251160 - 107231 == 143929)
			{
				this.eJMJ2G541u.actionState = "standby";
				if (255889 - 364191 != -108301)
				{
					this.eJMJ2G541u.actionTime = Time.time;
					if (197647 - 403944 == -206297)
					{
						this.eJMJ2G541u.myCommand = "none";
						if (159126 - 251750 != -92623)
						{
							this.eJMJ2G541u.mImmuneList = new UnityScript.Lang.Array("petrify");
							if (145460 - 427525 != -282064)
							{
								eBuitenType buitenType = this.BuitenType;
								if (139280 - 19915 == 119365)
								{
									if (buitenType == eBuitenType.Buiten1)
									{
										if (80914 - 528687 == -447773)
										{
											this.N9eJv3Bshk = 1;
											if (63934 - 46097 != 17838)
											{
												break;
											}
										}
									}
									else if (buitenType == eBuitenType.Buiten2)
									{
										if (23614 - 202044 != -178429)
										{
											this.N9eJv3Bshk = 2;
											if (298292 - 521477 != -223184)
											{
												break;
											}
										}
									}
									else if (buitenType == eBuitenType.Buiten3)
									{
										if (170933 - 132868 != 38066)
										{
											this.N9eJv3Bshk = 3;
											if (43663 - 217944 != -174280)
											{
												break;
											}
										}
									}
									else
									{
										if (buitenType != eBuitenType.Buiten4)
										{
											break;
										}
										if (202854 - 365101 == -162247)
										{
											this.N9eJv3Bshk = 4;
											if (137537 - 26239 != 111299)
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

	// Token: 0x06000E65 RID: 3685 RVA: 0x0016F910 File Offset: 0x0016DB10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.eJMJ2G541u.isMine = true;
		}
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x0016F92C File Offset: 0x0016DB2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (202937 - 592869 != -389931)
		{
		}
		for (;;)
		{
			IL_6E1:
			if (this.eJMJ2G541u.isControlled)
			{
				if (46987 - 542900 != -495913)
				{
					continue;
				}
				if (!(this.eJMJ2G541u.actionState == "standby"))
				{
					if (158781 - 250575 != -91794)
					{
						continue;
					}
					if (!(this.eJMJ2G541u.actionState == "run"))
					{
						goto IL_491;
					}
					if (88263 - 145712 != -57449)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (241494 - 36125 == 205370)
				{
					continue;
				}
			}
			IL_491:
			if (this.eJMJ2G541u.hp > 0)
			{
				if (99073 - 5020 == 94054)
				{
					continue;
				}
				if (this.eJMJ2G541u.actionState == "standby")
				{
					if (109098 - 188866 == -79767)
					{
						continue;
					}
					if (Time.time > this.nreJlfkkVx)
					{
						if (288799 - 253947 == 34853)
						{
							continue;
						}
						this.nreJlfkkVx = Time.time + (float)4;
						if (263286 - 369356 != -106070)
						{
							continue;
						}
						int layerMask = 1 << this.gameObject.layer;
						if (218135 - 13594 == 204542)
						{
							continue;
						}
						UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, (float)(20 + 5 * this.N9eJv3Bshk), (float)9 * this.eJMJ2G541u.rangeMod, layerMask);
						if (186459 - 17675 == 168785)
						{
							continue;
						}
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (282500 - 327115 == -44614)
						{
							continue;
						}
						while (enumerator.MoveNext())
						{
							object obj2 = enumerator.Current;
							object obj4;
							object obj3 = obj4 = obj2;
							if (!(obj3 is GameObject))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj4;
							if (87026 - 121765 != -34739)
							{
								goto IL_6E1;
							}
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (297561 - 408454 == -110892)
							{
								goto IL_6E1;
							}
							UnityRuntimeServices.Update(enumerator, gameObject);
							if (216016 - 70154 == 145863)
							{
								goto IL_6E1;
							}
							if (characterControl)
							{
								if (67180 - 100411 != -33231)
								{
									goto IL_6E1;
								}
								if (gameObject.tag == "Player")
								{
									if (121847 - 452465 == -330617)
									{
										goto IL_6E1;
									}
									if (characterControl.isMine)
									{
										if (36958 - 427922 == -390963)
										{
											goto IL_6E1;
										}
										statusClass status = characterControl.getStatus("buiten");
										if (232 - 192647 == -192414)
										{
											goto IL_6E1;
										}
										int sValue = 0;
										if (40814 - 425175 == -384360)
										{
											goto IL_6E1;
										}
										if (characterControl == this.mSummonerChar)
										{
											if (217667 - 137380 == 80288)
											{
												goto IL_6E1;
											}
											sValue = this.N9eJv3Bshk * 10;
											if (162422 - 454904 != -292482)
											{
												goto IL_6E1;
											}
										}
										if (status != null)
										{
											if (46816 - 228087 == -181270)
											{
												goto IL_6E1;
											}
											if (status.sLv < this.N9eJv3Bshk)
											{
												goto IL_626;
											}
											if (3162 - 443186 == -440023)
											{
												goto IL_6E1;
											}
											if (status.sID == this.eJMJ2G541u.ActorNr)
											{
												if (88587 - 522964 != -434376)
												{
													goto IL_626;
												}
												goto IL_6E1;
											}
											continue;
											IL_626:
											characterControl.RPC_AddStatus("buiten", this.N9eJv3Bshk, 5, sValue, this.eJMJ2G541u.ActorNr);
											if (34679 - 348472 != -313793)
											{
												goto IL_6E1;
											}
										}
										else
										{
											characterControl.RPC_AddStatus("buiten", this.N9eJv3Bshk, 5, sValue, this.eJMJ2G541u.ActorNr);
											if (111910 - 594457 == -482546)
											{
												goto IL_6E1;
											}
										}
									}
								}
							}
						}
						if (124818 - 485491 == -360672)
						{
							continue;
						}
					}
					if (!this.isSummon)
					{
						break;
					}
					if (167505 - 593485 == -425979)
					{
						continue;
					}
					if (!this.eJMJ2G541u.isMine)
					{
						break;
					}
					if (211015 - 439647 == -228631)
					{
						continue;
					}
					if (this.mSummonerChar)
					{
						if (285426 - 485965 != -200539)
						{
							continue;
						}
						if (this.mSummonerChar.hp > 0)
						{
							break;
						}
						if (27754 - 243440 != -215686)
						{
							continue;
						}
					}
					if (!(this.eJMJ2G541u.actionState != "dead"))
					{
						break;
					}
					if (284850 - 369451 == -84600)
					{
						continue;
					}
					this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
					{
						this.transform.position,
						this.transform.forward
					})));
					if (73818 - 209983 == -136164)
					{
						continue;
					}
					if (!PhotonClient.IsInitialized())
					{
						break;
					}
					if (38530 - 565616 != -527086)
					{
						continue;
					}
					this.eJMJ2G541u.DeadEvent();
					if (48921 - 1104 != 47818)
					{
						break;
					}
					continue;
				}
			}
			if (this.eJMJ2G541u.hp > 0)
			{
				break;
			}
			if (271454 - 128569 != 142886)
			{
				if (!(this.eJMJ2G541u.actionState != "dead"))
				{
					break;
				}
				if (269665 - 78954 == 190711)
				{
					if (this.eJMJ2G541u.isMine)
					{
						if (49555 - 90122 == -40567)
						{
							statusClass status2 = this.eJMJ2G541u.getStatus("autoLife");
							if (294676 - 366715 != -72038)
							{
								if (status2 != null)
								{
									if (257877 - 301283 != -43405)
									{
										this.eJMJ2G541u.hp = 1;
										if (181809 - 129676 == 52133)
										{
											this.eJMJ2G541u.RPC_RemoveStatus("autoLife");
											if (9989 - 423231 == -413242)
											{
												this.eJMJ2G541u.RPC_createEffect("autoLife");
												if (204054 - 353588 != -149533)
												{
													this.eJMJ2G541u.RPC_AddHeal(254, status2.sLv * 100, 0, 0, 0, 0, status2.sID);
													if (92061 - 532679 == -440618)
													{
														break;
													}
												}
											}
										}
									}
								}
								else
								{
									this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (107119 - 257722 == -150603)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (125588 - 274771 == -149183)
										{
											this.eJMJ2G541u.DeadEvent();
											if (137972 - 166472 == -28500)
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
						this.eJMJ2G541u.hp = 1;
						if (125252 - 590364 == -465112)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x001701F8 File Offset: 0x0016E3F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x001701FC File Offset: 0x0016E3FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x06000E69 RID: 3689 RVA: 0x00170214 File Offset: 0x0016E414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x0017022C File Offset: 0x0016E42C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000E6B RID: 3691 RVA: 0x00170230 File Offset: 0x0016E430
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator summon(int nSummonerID)
	{
		return new Buiten.$summon$17702(nSummonerID, this).GetEnumerator();
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x00170240 File Offset: 0x0016E440
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator unsummon()
	{
		return new Buiten.$unsummon$17707(this).GetEnumerator();
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x00170250 File Offset: 0x0016E450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
		this.eJMJ2G541u.ko = this.eJMJ2G541u.mko;
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x00170268 File Offset: 0x0016E468
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Buiten.$RPC_dead$17710(nArray, this).GetEnumerator();
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x00170278 File Offset: 0x0016E478
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x0017027C File Offset: 0x0016E47C
	internal static bool QuaHtjSA6yhsDxyWLLX()
	{
		return true;
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x00170280 File Offset: 0x0016E480
	internal static bool Y887Y0Sl1He1IaWvR2s()
	{
		return false;
	}

	// Token: 0x04000C74 RID: 3188
	public eBuitenType BuitenType;

	// Token: 0x04000C75 RID: 3189
	private CharacterControl eJMJ2G541u;

	// Token: 0x04000C76 RID: 3190
	private int N9eJv3Bshk;

	// Token: 0x04000C77 RID: 3191
	private float nreJlfkkVx;

	// Token: 0x04000C78 RID: 3192
	public GameObject mSummoner;

	// Token: 0x04000C79 RID: 3193
	public bool isSummon;

	// Token: 0x04000C7A RID: 3194
	public float followDistance;

	// Token: 0x04000C7B RID: 3195
	public CharacterControl mSummonerChar;

	// Token: 0x04000C7C RID: 3196
	public GameObject summonEffect;

	// Token: 0x04000C7D RID: 3197
	public AudioClip buiten_summonFX;

	// Token: 0x04000C7E RID: 3198
	public AudioClip buiten_unsummonFX;

	// Token: 0x02000276 RID: 630
	[CompilerGenerated]
	[Serializable]
	internal sealed class $summon$17702 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000E72 RID: 3698 RVA: 0x00170284 File Offset: 0x0016E484
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $summon$17702(int nSummonerID, Buiten self_)
		{
			if (236379 - 499620 != -263241)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (299189 - 356412 != -57222)
				{
					base..ctor();
					if (159061 - 36595 != 122467)
					{
						this.$nSummonerID$17705 = nSummonerID;
						if (62682 - 259942 != -197259)
						{
							this.$self_$17706 = self_;
							if (248171 - 33424 == 214747)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00170340 File Offset: 0x0016E540
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Buiten.$summon$17702.$(this.$nSummonerID$17705, this.$self_$17706);
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00170354 File Offset: 0x0016E554
		internal static bool A2HMJaSy01NZqSABYbn()
		{
			return true;
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00170358 File Offset: 0x0016E558
		internal static bool RHKIiaSSihqXhyO9A72()
		{
			return false;
		}

		// Token: 0x04000C7F RID: 3199
		internal int $nSummonerID$17705;

		// Token: 0x04000C80 RID: 3200
		internal Buiten $self_$17706;

		// Token: 0x02000277 RID: 631
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000E76 RID: 3702 RVA: 0x0017035C File Offset: 0x0016E55C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nSummonerID, Buiten self_)
			{
				if (237904 - 402462 != -164557)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (52610 - 598722 == -546112)
					{
						base..ctor();
						if (250708 - 522217 == -271509)
						{
							this.$nSummonerID$17703 = nSummonerID;
							if (215194 - 531041 == -315847)
							{
								this.$self_$17704 = self_;
								if (36761 - 392857 == -356096)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000E77 RID: 3703 RVA: 0x00170418 File Offset: 0x0016E618
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (201851 - 79825 != 122027)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5F7;
					case 2:
						if (this.$self_$17704.eJMJ2G541u.actionState == "attack")
						{
							if (10174 - 479223 != -469049)
							{
								continue;
							}
							if (this.$self_$17704.eJMJ2G541u.myCommand == "summon")
							{
								if (124536 - 55548 == 68989)
								{
									continue;
								}
								this.$self_$17704.eJMJ2G541u.actionState = "standby";
								if (91061 - 30856 == 60206)
								{
									continue;
								}
								this.$self_$17704.eJMJ2G541u.actionTime = Time.time;
								if (124986 - 307238 != -182252)
								{
									continue;
								}
								this.$self_$17704.eJMJ2G541u.myCommand = "none";
								if (212464 - 528928 != -316464)
								{
									continue;
								}
								if (!this.$self_$17704.eJMJ2G541u.isMine)
								{
									if (6426 - 519990 != -513564)
									{
										continue;
									}
									this.$self_$17704.eJMJ2G541u.nPosition = this.$self_$17704.transform.position;
									if (80365 - 371824 == -291458)
									{
										continue;
									}
									this.$self_$17704.eJMJ2G541u.oPosition = this.$self_$17704.transform.position;
									if (170051 - 274406 != -104355)
									{
										continue;
									}
									this.$self_$17704.eJMJ2G541u.nDirection = this.$self_$17704.transform.forward;
									if (179367 - 550135 != -370768)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (19168 - 573461 != -554292)
						{
							goto Block_8;
						}
						continue;
					default:
						if (110306 - 23897 == 86410)
						{
							continue;
						}
						break;
					}
					this.$self_$17704.isSummon = true;
					if (299788 - 391169 != -91380)
					{
						Buiten buiten = this.$self_$17704;
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.$nSummonerID$17703];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						buiten.mSummoner = (GameObject)obj2;
						if (198302 - 506368 != -308065)
						{
							this.$self_$17704.mSummonerChar = (CharacterControl)this.$self_$17704.mSummoner.GetComponent(typeof(CharacterControl));
							if (195531 - 416835 != -221303)
							{
								this.$self_$17704.gameObject.layer = this.$self_$17704.mSummoner.layer;
								if (103542 - 107124 != -3581)
								{
									this.$self_$17704.eJMJ2G541u.mOriginalLayer = this.$self_$17704.mSummoner.layer;
									if (35699 - 372390 != -336690)
									{
										Camera.main.SendMessage("onSummon", this.$self_$17704.gameObject, SendMessageOptions.DontRequireReceiver);
										if (184548 - 127388 != 57161)
										{
											this.$self_$17704.eJMJ2G541u.actionState = "attack";
											if (113858 - 85738 == 28120)
											{
												this.$self_$17704.eJMJ2G541u.actionTime = Time.time;
												if (232080 - 533300 == -301220)
												{
													this.$self_$17704.eJMJ2G541u.myCommand = "summon";
													if (23199 - 309154 != -285954)
													{
														this.$self_$17704.animation.Play("create");
														if (267228 - 394655 != -127426)
														{
															this.$self_$17704.animation.wrapMode = WrapMode.Once;
															if (52570 - 300273 != -247702)
															{
																this.$self_$17704.eJMJ2G541u.vMovement = this.$self_$17704.transform.forward;
																if (152001 - 178724 != -26722)
																{
																	this.$self_$17704.eJMJ2G541u.moveSpeed = (float)0;
																	if (167995 - 389471 != -221475)
																	{
																		if (this.$self_$17704.buiten_summonFX)
																		{
																			if (105523 - 31037 != 74486)
																			{
																				continue;
																			}
																			this.$self_$17704.audio.PlayOneShot(this.$self_$17704.buiten_summonFX);
																			if (102418 - 196166 != -93748)
																			{
																				continue;
																			}
																		}
																		if (!this.$self_$17704.summonEffect)
																		{
																			break;
																		}
																		if (298877 - 313470 == -14593)
																		{
																			UnityEngine.Object.Instantiate(this.$self_$17704.summonEffect, this.$self_$17704.transform.position, this.$self_$17704.transform.rotation);
																			if (94567 - 587519 != -492951)
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
				IL_1A:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_8:
				goto IL_5F7;
				goto IL_1A;
				IL_5F7:
				return false;
			}

			// Token: 0x06000E78 RID: 3704 RVA: 0x00170A30 File Offset: 0x0016EC30
			internal static bool agLR7xSoI54v4QacY2F()
			{
				return true;
			}

			// Token: 0x06000E79 RID: 3705 RVA: 0x00170A34 File Offset: 0x0016EC34
			internal static bool Ai62aPSEEDrHrqN5B64()
			{
				return false;
			}

			// Token: 0x04000C81 RID: 3201
			internal int $nSummonerID$17703;

			// Token: 0x04000C82 RID: 3202
			internal Buiten $self_$17704;
		}
	}

	// Token: 0x02000278 RID: 632
	[CompilerGenerated]
	[Serializable]
	internal sealed class $unsummon$17707 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000E7A RID: 3706 RVA: 0x00170A38 File Offset: 0x0016EC38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $unsummon$17707(Buiten self_)
		{
			if (219630 - 309493 != -89863)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (88514 - 390904 != -302389)
				{
					base..ctor();
					if (144608 - 269351 != -124742)
					{
						this.$self_$17709 = self_;
						if (63119 - 297943 == -234824)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00170AD0 File Offset: 0x0016ECD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Buiten.$unsummon$17707.$(this.$self_$17709);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00170AE0 File Offset: 0x0016ECE0
		internal static bool FujSpDS2ZExx5J9gAmu()
		{
			return true;
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00170AE4 File Offset: 0x0016ECE4
		internal static bool BEOAkJS8NrRD5HS0Pyr()
		{
			return false;
		}

		// Token: 0x04000C83 RID: 3203
		internal Buiten $self_$17709;

		// Token: 0x02000279 RID: 633
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000E7E RID: 3710 RVA: 0x00170AE8 File Offset: 0x0016ECE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Buiten self_)
			{
				if (241677 - 579435 != -337758)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (68759 - 106379 != -37619)
					{
						base..ctor();
						if (25231 - 171306 != -146074)
						{
							this.$self_$17708 = self_;
							if (189608 - 571978 != -382369)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000E7F RID: 3711 RVA: 0x00170B80 File Offset: 0x0016ED80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (87527 - 258296 != -170769)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2FD;
					case 2:
						UnityEngine.Object.Destroy(this.$self_$17708.gameObject);
						if (202656 - 308650 != -105994)
						{
							continue;
						}
						this.YieldDefault(1);
						if (7581 - 519601 != -512019)
						{
							goto Block_5;
						}
						continue;
					default:
						if (102921 - 358214 != -255293)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17708.eJMJ2G541u.actionState == "dead")
					{
						if (77091 - 324327 != -247235)
						{
							goto Block_9;
						}
					}
					else
					{
						this.$self_$17708.eJMJ2G541u.actionState = "dead";
						if (53949 - 96847 == -42898)
						{
							this.$self_$17708.eJMJ2G541u.actionTime = Time.time;
							if (158124 - 530232 == -372108)
							{
								this.$self_$17708.eJMJ2G541u.myCommand = "unSummon";
								if (290543 - 16748 != 273796)
								{
									this.$self_$17708.animation.Play("unSummon");
									if (283364 - 278060 != 5305)
									{
										this.$self_$17708.animation.wrapMode = WrapMode.Once;
										if (88848 - 500756 != -411907)
										{
											this.$self_$17708.eJMJ2G541u.hp = 0;
											if (89165 - 333746 == -244581)
											{
												this.$self_$17708.eJMJ2G541u.vMovement = Vector3.zero;
												if (34923 - 536947 != -502023)
												{
													this.$self_$17708.eJMJ2G541u.moveSpeed = (float)0;
													if (7504 - 267390 != -259885)
													{
														if (this.$self_$17708.buiten_unsummonFX)
														{
															if (41489 - 71399 == -29909)
															{
																continue;
															}
															this.$self_$17708.audio.PlayOneShot(this.$self_$17708.buiten_unsummonFX);
															if (264302 - 581371 != -317069)
															{
																continue;
															}
														}
														UnityEngine.Object.Instantiate(this.$self_$17708.summonEffect, this.$self_$17708.transform.position, Quaternion.identity);
														if (269061 - 177476 != 91586)
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
				return this.Yield(2, new WaitForSeconds(1f));
				Block_5:
				Block_9:
				IL_2FD:
				return false;
			}

			// Token: 0x06000E80 RID: 3712 RVA: 0x00170E9C File Offset: 0x0016F09C
			internal static bool u571s1SZwTZuRwPDX0C()
			{
				return true;
			}

			// Token: 0x06000E81 RID: 3713 RVA: 0x00170EA0 File Offset: 0x0016F0A0
			internal static bool CX2iuMSCSlZd7YWQvc7()
			{
				return false;
			}

			// Token: 0x04000C84 RID: 3204
			internal Buiten $self_$17708;
		}
	}

	// Token: 0x0200027A RID: 634
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17710 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000E82 RID: 3714 RVA: 0x00170EA4 File Offset: 0x0016F0A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17710(UnityScript.Lang.Array nArray, Buiten self_)
		{
			if (254593 - 220454 != 34140)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (185232 - 151650 != 33583)
				{
					base..ctor();
					if (44219 - 144460 != -100240)
					{
						this.$nArray$17715 = nArray;
						if (63861 - 482268 == -418407)
						{
							this.$self_$17716 = self_;
							if (230692 - 18496 == 212196)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00170F60 File Offset: 0x0016F160
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Buiten.$RPC_dead$17710.$(this.$nArray$17715, this.$self_$17716);
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00170F74 File Offset: 0x0016F174
		internal static bool hG3yY1SLS9qhkF9xiQr()
		{
			return true;
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00170F78 File Offset: 0x0016F178
		internal static bool RY5isASOXL3Ymra8MqR()
		{
			return false;
		}

		// Token: 0x04000C85 RID: 3205
		internal UnityScript.Lang.Array $nArray$17715;

		// Token: 0x04000C86 RID: 3206
		internal Buiten $self_$17716;

		// Token: 0x0200027B RID: 635
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000E86 RID: 3718 RVA: 0x00170F7C File Offset: 0x0016F17C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Buiten self_)
			{
				if (18954 - 212050 != -193095)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (292906 - 332115 == -39209)
					{
						base..ctor();
						if (120286 - 26273 != 94014)
						{
							this.$nArray$17713 = nArray;
							if (236065 - 318412 != -82346)
							{
								this.$self_$17714 = self_;
								if (281781 - 413748 != -131966)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000E87 RID: 3719 RVA: 0x00171038 File Offset: 0x0016F238
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (255962 - 373269 != -117306)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_42F;
					case 2:
						if (this.$self_$17714.eJMJ2G541u.actionState != "dead")
						{
							if (110368 - 476460 != -366091)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17714.eJMJ2G541u.isPlayer)
							{
								if (86959 - 240039 != -153080)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$17714.gameObject);
								if (291213 - 52517 != 238696)
								{
									continue;
								}
							}
							else if (this.$self_$17714.eJMJ2G541u.isMine)
							{
								if (230956 - 134503 == 96454)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17714.gameObject);
								if (66797 - 204824 == -138026)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (30562 - 84159 != -53596)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					default:
						if (35374 - 361963 == -326588)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17714.eJMJ2G541u.actionState == "dead")
					{
						if (52520 - 184292 != -131771)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$17711 = (Vector3)this.$nArray$17713[0];
						if (50068 - 329608 != -279539)
						{
							this.$myDirection$17712 = (Vector3)this.$nArray$17713[1];
							if (164415 - 252614 == -88199)
							{
								this.$self_$17714.transform.position = this.$myPosition$17711;
								if (38062 - 462519 == -424457)
								{
									this.$self_$17714.transform.LookAt(this.$myPosition$17711 + this.$myDirection$17712);
									if (16374 - 588515 == -572141)
									{
										this.$self_$17714.eJMJ2G541u.hp = 0;
										if (232348 - 5395 == 226953)
										{
											this.$self_$17714.eJMJ2G541u.actionState = "dead";
											if (37700 - 480066 != -442365)
											{
												this.$self_$17714.eJMJ2G541u.actionTime = Time.time;
												if (152276 - 596717 == -444441)
												{
													this.$self_$17714.eJMJ2G541u.myCommand = "none";
													if (272888 - 529658 == -256770)
													{
														this.$self_$17714.eJMJ2G541u.vMovement = Vector3.zero;
														if (269786 - 535513 == -265727)
														{
															this.$self_$17714.eJMJ2G541u.moveSpeed = (float)0;
															if (9006 - 223423 == -214417)
															{
																this.$self_$17714.animation.Rewind();
																if (234311 - 437804 != -203492)
																{
																	this.$self_$17714.animation.Play("destroy");
																	if (101748 - 2961 != 98788)
																	{
																		this.$self_$17714.animation.wrapMode = WrapMode.Once;
																		if (194707 - 252674 == -57967)
																		{
																			goto IL_3B5;
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
				Block_24:
				goto IL_42F;
				IL_3B5:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_26:
				IL_42F:
				return false;
			}

			// Token: 0x06000E88 RID: 3720 RVA: 0x00171488 File Offset: 0x0016F688
			internal static bool gEb5kZSmS4UVnZancCx()
			{
				return true;
			}

			// Token: 0x06000E89 RID: 3721 RVA: 0x0017148C File Offset: 0x0016F68C
			internal static bool ApcO7eSFITXhI8pAJGx()
			{
				return false;
			}

			// Token: 0x04000C87 RID: 3207
			internal Vector3 $myPosition$17711;

			// Token: 0x04000C88 RID: 3208
			internal Vector3 $myDirection$17712;

			// Token: 0x04000C89 RID: 3209
			internal UnityScript.Lang.Array $nArray$17713;

			// Token: 0x04000C8A RID: 3210
			internal Buiten $self_$17714;
		}
	}
}
