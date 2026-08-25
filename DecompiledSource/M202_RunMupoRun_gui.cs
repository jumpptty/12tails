using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200139B RID: 5019
[Serializable]
public class M202_RunMupoRun_gui : MonoBehaviour
{
	// Token: 0x0600739C RID: 29596 RVA: 0x00FA3834 File Offset: 0x00FA1A34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M202_RunMupoRun_gui()
	{
		if (263271 - 63405 != 199866)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (193369 - 199 == 193170)
			{
				base..ctor();
				if (247275 - 239133 != 8143)
				{
					this.QmbciB6dpoF = 3;
					if (67034 - 589135 == -522101)
					{
						this.pbRciDJMFF3 = Vector3.zero;
						if (132271 - 505924 == -373653)
						{
							this.T0icijoN2oY = Vector3.zero;
							if (111319 - 502700 == -391381)
							{
								this.IHtcDrxQJgk = 0.5f;
								if (273631 - 167044 == 106587)
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

	// Token: 0x0600739D RID: 29597 RVA: 0x00FA393C File Offset: 0x00FA1B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (227476 - 130914 != 96563)
		{
		}
		for (;;)
		{
			this.mCam = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
			if (230881 - 559104 == -328223)
			{
				this.FipcivWhRLF = 1;
				if (175848 - 275386 != -99537)
				{
					this.Xd9cil9WnGp = Time.time;
					if (28288 - 588876 == -560588)
					{
						this.targetObject = null;
						if (171146 - 355822 != -184675)
						{
							this.gjCcidMIVK9 = 0;
							if (144867 - 421749 != -276881)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600739E RID: 29598 RVA: 0x00FA3A34 File Offset: 0x00FA1C34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEnable()
	{
		if (72302 - 152712 != -80410)
		{
		}
		for (;;)
		{
			GUIUtility.hotControl = 0;
			if (232981 - 258767 == -25786)
			{
				if (!this.K3uci28UFNc)
				{
					if (3867 - 434329 == -430461)
					{
						continue;
					}
					this.StartCoroutine_Auto(this.InitMupoRunGui());
					if (253203 - 443854 != -190651)
					{
						continue;
					}
				}
				this.xwucix0BXjA = CharacterData.current;
				if (261699 - 337140 == -75441)
				{
					this.FipcivWhRLF = 1;
					if (209650 - 538649 != -328998)
					{
						this.Xd9cil9WnGp = Time.time;
						if (223798 - 137666 == 86132)
						{
							this.IeqcmaEdRXM = false;
							if (169709 - 532995 != -363285)
							{
								this.targetObject = null;
								if (135457 - 257818 != -122360)
								{
									this.gjCcidMIVK9 = 0;
									if (154920 - 184144 == -29224)
									{
										this.o90ciamtGQU = 0;
										if (192613 - 430160 != -237546)
										{
											this.guPci4YLE4Q = 0;
											if (289574 - 439062 != -149487)
											{
												this.enEcisCfyiD = Time.time;
												if (176247 - 423142 != -246894)
												{
													this.ResetTeamBar();
													if (144402 - 457252 == -312850)
													{
														this.ResetCharacterBar(this.xwucix0BXjA.Type);
														if (285891 - 152157 != 133735)
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

	// Token: 0x0600739F RID: 29599 RVA: 0x00FA3C58 File Offset: 0x00FA1E58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void close()
	{
		if (225307 - 313354 != -88046)
		{
		}
		for (;;)
		{
			if (!this.K3uci28UFNc)
			{
				if (210634 - 251402 == -40768)
				{
					break;
				}
			}
			else
			{
				this.Xd9cil9WnGp = Time.time;
				if (252092 - 324618 != -72525)
				{
					this.FipcivWhRLF = 3;
					if (135195 - 205245 == -70050)
					{
						this.targetObject = null;
						if (27490 - 323937 == -296447)
						{
							this.IeqcmaEdRXM = false;
							if (103087 - 550409 != -447321)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060073A0 RID: 29600 RVA: 0x00FA3D44 File Offset: 0x00FA1F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void disable()
	{
		if (193709 - 112325 != 81385)
		{
		}
		for (;;)
		{
			if (!this.K3uci28UFNc)
			{
				if (233638 - 17965 != 215674)
				{
					break;
				}
			}
			else
			{
				this.Xd9cil9WnGp = Time.time;
				if (77306 - 295899 != -218592)
				{
					this.FipcivWhRLF = 5;
					if (275874 - 50468 != 225407)
					{
						this.targetObject = null;
						if (267735 - 155262 != 112474)
						{
							this.IeqcmaEdRXM = false;
							if (39975 - 290570 != -250594)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060073A1 RID: 29601 RVA: 0x00FA3E30 File Offset: 0x00FA2030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (87660 - 402528 != -314867)
		{
		}
		for (;;)
		{
			if (!this.K3uci28UFNc)
			{
				if (245831 - 579272 != -333440)
				{
					break;
				}
			}
			else if (!this.camera.enabled)
			{
				if (238922 - 110791 == 128131)
				{
					break;
				}
			}
			else
			{
				if (!this.mCam.target)
				{
					if (182679 - 211949 != -29270)
					{
						continue;
					}
					if (this.FipcivWhRLF == 4)
					{
						if (246468 - 190943 == 55526)
						{
							continue;
						}
						if (Game.mPlayer != null)
						{
							if (87627 - 54720 == 32908)
							{
								continue;
							}
							this.mCam.target = Game.mPlayer;
							if (294241 - 309289 != -15048)
							{
								continue;
							}
							goto IL_128;
						}
					}
					this.enabled = false;
					if (164173 - 506649 != -342475)
					{
						break;
					}
					continue;
				}
				IL_128:
				this.guPci4YLE4Q++;
				if (293498 - 423394 == -129896)
				{
					if (this.guPci4YLE4Q > 100)
					{
						if (183087 - 586918 == -403830)
						{
							continue;
						}
						this.o90ciamtGQU = Mathf.CeilToInt((float)this.guPci4YLE4Q / (Time.time - this.enEcisCfyiD));
						if (33830 - 227600 == -193769)
						{
							continue;
						}
						this.guPci4YLE4Q = 0;
						if (282536 - 70989 != 211547)
						{
							continue;
						}
						this.enEcisCfyiD = Time.time;
						if (19732 - 95341 != -75609)
						{
							continue;
						}
					}
					if (!PhotonClient.IsInitialized())
					{
						if (4869 - 375936 == -371066)
						{
							continue;
						}
						if (Application.platform == RuntimePlatform.WindowsPlayer)
						{
							if (299477 - 465666 != -166189)
							{
								continue;
							}
							this.newNoticeBar("Game disconnected");
							if (178204 - 23041 == 155164)
							{
								continue;
							}
						}
					}
					if (Chat.ChatActive)
					{
						break;
					}
					if (52617 - 148442 == -95825)
					{
						this.CaptureInput();
						if (51626 - 118071 == -66445)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060073A2 RID: 29602 RVA: 0x00FA4118 File Offset: 0x00FA2318
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (73126 - 220908 != -147781)
		{
		}
		for (;;)
		{
			if (!this.K3uci28UFNc)
			{
				if (253167 - 490930 == -237763)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 1;
				if (73978 - 411234 == -337256)
				{
					GUI.skin = this.OluciGWsJGq;
					if (58980 - 24761 == 34219)
					{
						if (!this.mCam.target)
						{
							if (49712 - 439304 == -389591)
							{
								continue;
							}
							if (this.FipcivWhRLF == 4)
							{
								if (94456 - 88890 == 5567)
								{
									continue;
								}
								if (Game.mPlayer != null)
								{
									if (122132 - 551070 != -428938)
									{
										continue;
									}
									this.mCam.target = Game.mPlayer;
									if (16403 - 393049 != -376646)
									{
										continue;
									}
									goto IL_349;
								}
							}
							this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
							if (92386 - 431363 != -338977)
							{
								continue;
							}
							this.enabled = false;
							if (219769 - 163766 != 56003)
							{
								continue;
							}
							break;
						}
						else
						{
							this.mPlayer = Game.mPlayer;
							if (208838 - 157914 != 50924)
							{
								continue;
							}
							if (this.mPlayer)
							{
								if (44458 - 141566 != -97108)
								{
									continue;
								}
								this.mChar = (CharacterControl)this.mPlayer.GetComponent(typeof(CharacterControl));
								if (198913 - 32266 == 166648)
								{
									continue;
								}
							}
							this.xwucix0BXjA = CharacterData.current;
							if (13033 - 175966 == -162932)
							{
								continue;
							}
							if (this.FipcivWhRLF == 1)
							{
								if (117989 - 348764 == -230774)
								{
									continue;
								}
								if (this.Xd9cil9WnGp + (float)1 < Time.time)
								{
									if (19608 - 29457 == -9848)
									{
										continue;
									}
									this.FipcivWhRLF = 2;
									if (83022 - 325187 != -242165)
									{
										continue;
									}
								}
							}
							if (this.FipcivWhRLF == 3)
							{
								if (163778 - 18995 == 144784)
								{
									continue;
								}
								if (this.Xd9cil9WnGp + (float)1 < Time.time)
								{
									if (5297 - 300232 == -294934)
									{
										continue;
									}
									this.enabled = false;
									if (270348 - 469350 == -199001)
									{
										continue;
									}
								}
							}
						}
						IL_349:
						if (this.FipcivWhRLF == 2)
						{
							if (284372 - 302549 != -18177)
							{
								continue;
							}
							GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)1, (float)1, (float)1));
							if (143051 - 508460 == -365408)
							{
								continue;
							}
							this.RenderTargetArea();
							if (101471 - 383617 != -282146)
							{
								continue;
							}
						}
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (43121 - 463624 == -420503)
						{
							this.E4Bci1kE8y4 = (float)(1024 * Screen.width / Screen.height);
							if (109696 - 90783 != 18914)
							{
								this.o53ciqnfnhL = (float)Screen.height / 1024f;
								if (137254 - 569512 != -432257)
								{
									this.j5rcirg1OTi.x = Input.mousePosition.x * (float)1024 / (float)Screen.height;
									if (21888 - 362431 != -340542)
									{
										this.j5rcirg1OTi.y = (float)1024 - Input.mousePosition.y * (float)1024 / (float)Screen.height;
										if (33571 - 229894 == -196323)
										{
											this.RenderChatBar();
											if (279048 - 523628 == -244580)
											{
												this.RenderMapBar();
												if (159618 - 372019 != -212400)
												{
													this.RenderScoreBar();
													if (179593 - 435005 != -255411)
													{
														this.RenderTargetBar();
														if (83320 - 509492 == -426172)
														{
															this.RenderTeamBar();
															if (103755 - 493727 == -389972)
															{
																this.RenderCharacterBar();
																if (148436 - 252919 != -104482)
																{
																	this.RenderNoticeBar();
																	if (130762 - 156437 == -25675)
																	{
																		this.RenderGameMessege();
																		if (40316 - 528380 != -488063)
																		{
																			this.RenderOptionMenu();
																			if (137570 - 253445 != -115874)
																			{
																				if (!Chat.ChatActive)
																				{
																					break;
																				}
																				if (11280 - 211359 != -200078)
																				{
																					GUI.FocusControl("MissionChatField");
																					if (76712 - 169524 != -92811)
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

	// Token: 0x060073A3 RID: 29603 RVA: 0x00FA477C File Offset: 0x00FA297C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator InitMupoRunGui()
	{
		return new M202_RunMupoRun_gui.$InitMupoRunGui$37711(this).GetEnumerator();
	}

	// Token: 0x060073A4 RID: 29604 RVA: 0x00FA478C File Offset: 0x00FA298C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitCaptureInput()
	{
		this.ldJciSWc06E = (float)0;
		this.QmbciB6dpoF = PlayerPrefs.GetInt("camRot", 5);
	}

	// Token: 0x060073A5 RID: 29605 RVA: 0x00FA47A8 File Offset: 0x00FA29A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CaptureInput()
	{
		if (68444 - 470238 != -401794)
		{
		}
		for (;;)
		{
			IL_C64:
			if (Input.GetKeyDown("escape"))
			{
				if (205960 - 501313 == -295352)
				{
					continue;
				}
				if (!this.IeqcmaEdRXM)
				{
					if (187537 - 22710 == 164828)
					{
						continue;
					}
					if (this.FipcivWhRLF != 2)
					{
						if (177692 - 279807 != -102115)
						{
							continue;
						}
						if (this.FipcivWhRLF != 4)
						{
							goto IL_1188;
						}
						if (280742 - 271472 != 9270)
						{
							continue;
						}
					}
					if (this.IZ7ciHMjyLk)
					{
						if (203888 - 476482 == -272593)
						{
							continue;
						}
						this.audio.PlayOneShot(this.IZ7ciHMjyLk);
						if (56825 - 293164 == -236338)
						{
							continue;
						}
					}
					this.IeqcmaEdRXM = true;
					if (123712 - 424558 != -300846)
					{
						continue;
					}
					this.pXycm4rLt23 = 0;
					if (1644 - 530605 == -528960)
					{
						continue;
					}
					IL_1188:;
				}
				else
				{
					this.IeqcmaEdRXM = false;
					if (223220 - 315429 == -92208)
					{
						continue;
					}
					if (this.vJNci7xce9X)
					{
						if (288502 - 342771 == -54268)
						{
							continue;
						}
						this.audio.PlayOneShot(this.vJNci7xce9X);
						if (99450 - 79677 != 19773)
						{
							continue;
						}
					}
				}
			}
			if (Input.GetKeyDown(KeyCode.M))
			{
				if (153634 - 141512 == 12123)
				{
					continue;
				}
				if (!this.IeqcmaEdRXM)
				{
					if (67514 - 272511 != -204997)
					{
						continue;
					}
					if (this.FipcivWhRLF == 2)
					{
						goto IL_190D;
					}
					if (106886 - 315758 == -208871)
					{
						continue;
					}
					if (this.FipcivWhRLF == 4)
					{
						if (64979 - 452972 != -387993)
						{
							continue;
						}
						goto IL_190D;
					}
					goto IL_2410;
					IL_190D:
					if (this.zUkciLiv9B7)
					{
						if (256379 - 287018 != -30639)
						{
							continue;
						}
						this.audio.PlayOneShot(this.zUkciLiv9B7);
						if (189736 - 178683 != 11053)
						{
							continue;
						}
					}
					this.IeqcmaEdRXM = true;
					if (242732 - 105340 != 137392)
					{
						continue;
					}
					this.pXycm4rLt23 = 5;
					if (6572 - 462010 != -455438)
					{
						continue;
					}
				}
				else if (this.pXycm4rLt23 == 5)
				{
					if (180838 - 151158 == 29681)
					{
						continue;
					}
					this.IeqcmaEdRXM = false;
					if (145690 - 228204 == -82513)
					{
						continue;
					}
					if (this.zUkciLiv9B7)
					{
						if (109406 - 424063 != -314657)
						{
							continue;
						}
						this.audio.PlayOneShot(this.zUkciLiv9B7);
						if (177933 - 103094 == 74840)
						{
							continue;
						}
					}
				}
			}
			IL_2410:
			if (this.IeqcmaEdRXM)
			{
				if (76887 - 242947 == -166060)
				{
					break;
				}
			}
			else
			{
				if (Input.GetButtonDown("normalAttack"))
				{
					if (182268 - 137043 != 45225)
					{
						continue;
					}
					if (GUIUtility.hotControl == 0)
					{
						if (52248 - 595365 == -543116)
						{
							continue;
						}
						if (Input.GetKeyDown("mouse 0"))
						{
							if (120379 - 538305 == -417925)
							{
								continue;
							}
							if (this.ogYcimbuwmv)
							{
								if (220059 - 49233 == 170827)
								{
									continue;
								}
								this.pbRciDJMFF3 = this.ogYcimbuwmv.collider.bounds.center;
								if (260733 - 84214 != 176519)
								{
									continue;
								}
							}
							else
							{
								this.pbRciDJMFF3 = this.T0icijoN2oY;
								if (185375 - 416593 == -231217)
								{
									continue;
								}
							}
						}
						this.qBociTv3FUi = eMouseState.fire;
						if (276946 - 30268 != 246678)
						{
							continue;
						}
						this.y9PciYyfIZl = Time.time;
						if (61160 - 165899 == -104738)
						{
							continue;
						}
					}
				}
				eMouseState eMouseState = this.qBociTv3FUi;
				if (115649 - 490743 != -375093)
				{
					if (eMouseState == eMouseState.fire)
					{
						if (6013 - 540993 != -534980)
						{
							continue;
						}
						if (!Input.GetButton("normalAttack"))
						{
							if (189068 - 399498 == -210429)
							{
								continue;
							}
							this.qBociTv3FUi = eMouseState.none;
							if (287589 - 526738 != -239149)
							{
								continue;
							}
							if (Input.GetKeyUp("mouse 0"))
							{
								if (169107 - 81920 != 87187)
								{
									continue;
								}
								if (GUIUtility.hotControl == 0)
								{
									if (136842 - 349846 == -213003)
									{
										continue;
									}
									if (Game.mGameState == eGameState.Normal)
									{
										if (24789 - 179207 == -154417)
										{
											continue;
										}
										if (PlayerPrefs.GetInt("autoAim", 1) != 0)
										{
											if (214430 - 359913 != -145483)
											{
												continue;
											}
											if (this.targetObject)
											{
												if (113780 - 37273 == 76508)
												{
													continue;
												}
												if (this.targetObject != this.mPlayer)
												{
													if (130543 - 413981 == -283437)
													{
														continue;
													}
													if (this.targetObject.collider)
													{
														if (65599 - 274774 != -209175)
														{
															continue;
														}
														this.pbRciDJMFF3 = this.targetObject.collider.bounds.center;
														if (27366 - 567259 != -539893)
														{
															continue;
														}
													}
												}
											}
										}
										this.mPlayer.SendMessage("doNormalAttack", new UnityScript.Lang.Array(new object[]
										{
											this.pbRciDJMFF3,
											this.targetObject
										}));
										if (146649 - 432886 == -286236)
										{
											continue;
										}
									}
								}
							}
							else
							{
								if (!this.targetObject)
								{
									goto IL_16C1;
								}
								if (221449 - 526215 == -304765)
								{
									continue;
								}
								if (!(this.targetObject != this.mPlayer))
								{
									goto IL_16C1;
								}
								if (254677 - 392205 != -137528)
								{
									continue;
								}
								this.pbRciDJMFF3 = this.targetObject.collider.bounds.center;
								if (84293 - 16843 == 67451)
								{
									continue;
								}
								IL_4B0:
								this.mPlayer.SendMessage("doNormalAttack", new UnityScript.Lang.Array(new object[]
								{
									this.pbRciDJMFF3,
									this.targetObject
								}));
								if (251041 - 514722 != -263680)
								{
									goto IL_1A33;
								}
								continue;
								IL_16C1:
								this.pbRciDJMFF3 = this.mPlayer.transform.position + (float)10 * this.mPlayer.transform.forward;
								if (47042 - 72662 != -25619)
								{
									goto IL_4B0;
								}
								continue;
							}
							IL_1A33:;
						}
						else if (Time.time >= this.y9PciYyfIZl + 0.3f)
						{
							if (15708 - 68199 != -52491)
							{
								continue;
							}
							this.qBociTv3FUi = eMouseState.charged;
							if (260233 - 558823 == -298589)
							{
								continue;
							}
							if (Input.GetKey("mouse 0"))
							{
								if (172750 - 475395 == -302644)
								{
									continue;
								}
								if (Game.mGameState == eGameState.Normal)
								{
									if (99052 - 321971 == -222918)
									{
										continue;
									}
									this.mPlayer.SendMessage("doBeginCharge", new UnityScript.Lang.Array(new object[]
									{
										this.pbRciDJMFF3,
										this.targetObject
									}));
									if (44032 - 157375 != -113343)
									{
										continue;
									}
								}
							}
							else
							{
								if (this.targetObject)
								{
									if (226566 - 268925 == -42358)
									{
										continue;
									}
									if (this.targetObject != this.mPlayer)
									{
										if (103847 - 95136 == 8712)
										{
											continue;
										}
										this.pbRciDJMFF3 = this.targetObject.collider.bounds.center;
										if (215853 - 35583 != 180270)
										{
											continue;
										}
										goto IL_12CC;
									}
								}
								this.pbRciDJMFF3 = this.mPlayer.transform.position + (float)10 * this.mPlayer.transform.forward;
								if (232456 - 565180 != -332724)
								{
									continue;
								}
							}
						}
						IL_12CC:;
					}
					else if (eMouseState == eMouseState.charged)
					{
						if (294892 - 514097 != -219205)
						{
							continue;
						}
						if (!Input.GetButton("normalAttack"))
						{
							if (278112 - 129769 == 148344)
							{
								continue;
							}
							this.qBociTv3FUi = eMouseState.none;
							if (39384 - 210278 == -170893)
							{
								continue;
							}
							if (Input.GetKeyUp("mouse 0"))
							{
								if (120441 - 364226 != -243785)
								{
									continue;
								}
								if (this.ogYcimbuwmv)
								{
									if (212451 - 537314 == -324862)
									{
										continue;
									}
									this.targetObject = this.ogYcimbuwmv;
									if (222872 - 222501 == 372)
									{
										continue;
									}
									this.pbRciDJMFF3 = this.targetObject.collider.bounds.center;
									if (104848 - 366012 != -261164)
									{
										continue;
									}
								}
								else
								{
									this.pbRciDJMFF3 = this.T0icijoN2oY;
									if (213695 - 101234 != 112461)
									{
										continue;
									}
								}
								if (Game.mGameState == eGameState.Normal)
								{
									if (62639 - 203961 != -141322)
									{
										continue;
									}
									this.mPlayer.SendMessage("doReleaseCharge", new UnityScript.Lang.Array(new object[]
									{
										this.pbRciDJMFF3,
										this.targetObject
									}));
									if (101903 - 592328 != -490425)
									{
										continue;
									}
								}
							}
							else
							{
								if (this.targetObject)
								{
									if (291037 - 18719 != 272318)
									{
										continue;
									}
									if (this.targetObject != this.mPlayer)
									{
										if (262779 - 473414 == -210634)
										{
											continue;
										}
										this.pbRciDJMFF3 = this.targetObject.collider.bounds.center;
										if (18324 - 15678 != 2647)
										{
											goto IL_1844;
										}
										continue;
									}
								}
								this.pbRciDJMFF3 = this.mPlayer.transform.position + (float)10 * this.mPlayer.transform.forward;
								if (24700 - 29291 == -4590)
								{
									continue;
								}
							}
						}
						IL_1844:;
					}
					if (Input.GetButtonDown("selectTarget"))
					{
						if (20115 - 361476 != -341361)
						{
							continue;
						}
						if (Input.GetKeyDown("mouse 1"))
						{
							if (263890 - 382637 == -118746)
							{
								continue;
							}
							if (this.ogYcimbuwmv)
							{
								if (144811 - 542751 != -397940)
								{
									continue;
								}
								this.targetObject = this.ogYcimbuwmv;
								if (68469 - 501178 == -432708)
								{
									continue;
								}
								this.DENcioQfXDq = this.ogYcimbuwmv;
								if (217848 - 545057 != -327209)
								{
									continue;
								}
							}
							else
							{
								this.DENcioQfXDq = null;
								if (227707 - 205589 != 22118)
								{
									continue;
								}
							}
							this.whRci35fPxW = Time.time;
							if (287265 - 177527 != 109738)
							{
								continue;
							}
						}
					}
					if (Input.GetKeyUp("mouse 1"))
					{
						if (294250 - 70837 != 223413)
						{
							continue;
						}
						if (this.DENcioQfXDq == null)
						{
							if (71498 - 285086 != -213588)
							{
								continue;
							}
							if (Time.time < this.whRci35fPxW + 0.1f)
							{
								if (268880 - 451405 != -182525)
								{
									continue;
								}
								this.targetObject = null;
								if (205060 - 463495 != -258435)
								{
									continue;
								}
							}
						}
					}
					if (Input.GetKeyDown(KeyCode.KeypadPlus))
					{
						if (166026 - 456053 != -290027)
						{
							continue;
						}
						if (Input.GetKey(KeyCode.LeftControl))
						{
							if (139543 - 344548 == -205004)
							{
								continue;
							}
							Game.music = Mathf.Clamp(Game.music + 1, 0, 10);
							if (203535 - 164552 != 38983)
							{
								continue;
							}
							PlayerPrefs.SetInt("music", Game.music);
							if (189155 - 272293 != -83138)
							{
								continue;
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (175218 - 282610 != -107392)
							{
								continue;
							}
							this.newGameMessage("Game Music : " + Game.music);
							if (259605 - 228991 == 30615)
							{
								continue;
							}
						}
						else
						{
							Game.volume = Mathf.Clamp(Game.volume + 1, 0, 10);
							if (273834 - 18908 != 254926)
							{
								continue;
							}
							PlayerPrefs.SetInt("volume", Game.volume);
							if (274251 - 217111 != 57140)
							{
								continue;
							}
							AudioListener.volume = Mathf.Clamp01(0.1f * (float)Game.volume);
							if (173339 - 151006 != 22333)
							{
								continue;
							}
							this.newGameMessage("Game Volume : " + Game.volume);
							if (233459 - 1617 == 231843)
							{
								continue;
							}
						}
					}
					if (Input.GetKeyDown(KeyCode.KeypadMinus))
					{
						if (297232 - 310719 == -13486)
						{
							continue;
						}
						if (Input.GetKey(KeyCode.LeftControl))
						{
							if (273058 - 34157 == 238902)
							{
								continue;
							}
							Game.music = Mathf.Clamp(Game.music - 1, 0, 10);
							if (218022 - 166263 == 51760)
							{
								continue;
							}
							PlayerPrefs.SetInt("music", Game.music);
							if (182160 - 299774 != -117614)
							{
								continue;
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (286497 - 538753 != -252256)
							{
								continue;
							}
							this.newGameMessage("Game Music : " + Game.music);
							if (36261 - 134695 != -98434)
							{
								continue;
							}
						}
						else
						{
							Game.volume = Mathf.Clamp(Game.volume - 1, 0, 10);
							if (233042 - 194622 == 38421)
							{
								continue;
							}
							PlayerPrefs.SetInt("volume", Game.volume);
							if (9170 - 92909 != -83739)
							{
								continue;
							}
							AudioListener.volume = Mathf.Clamp01(0.1f * (float)Game.volume);
							if (295147 - 237678 == 57470)
							{
								continue;
							}
							this.newGameMessage("Game Volume : " + Game.volume);
							if (45873 - 142283 == -96409)
							{
								continue;
							}
						}
					}
					if (!Input.GetMouseButton(1))
					{
						goto IL_1A0D;
					}
					if (28450 - 56134 == -27683)
					{
						continue;
					}
					if (this.gjCcidMIVK9 != 0)
					{
						goto IL_1A0D;
					}
					if (143817 - 212716 != -68899)
					{
						continue;
					}
					if (GUIUtility.hotControl != 0)
					{
						goto IL_1A0D;
					}
					if (101719 - 542015 != -440296)
					{
						continue;
					}
					this.mCam.rotation = Mathf.Clamp(0.5f * (float)this.QmbciB6dpoF * Input.GetAxis("Mouse X"), (float)-15, (float)15);
					if (288936 - 471689 != -182753)
					{
						continue;
					}
					this.ldJciSWc06E = (float)0;
					if (81620 - 475733 == -394112)
					{
						continue;
					}
					if (!Screen.lockCursor)
					{
						if (137597 - 4356 == 133242)
						{
							continue;
						}
						this.RH3cigdmkVM = Input.mousePosition;
						if (77776 - 231469 == -153692)
						{
							continue;
						}
						Screen.lockCursor = true;
						if (20802 - 393091 != -372289)
						{
							continue;
						}
					}
					if (this.whRci35fPxW <= Time.time - 0.2f)
					{
						if (59752 - 79412 != -19660)
						{
							continue;
						}
						this.BRjcibdpIVx = Time.time;
						if (213539 - 255220 == -41680)
						{
							continue;
						}
					}
					IL_25AA:
					this.mCam.zoom = Mathf.Clamp(Input.GetAxis("Mouse ScrollWheel"), -0.3f, 0.3f);
					if (284231 - 148777 != 135454)
					{
						continue;
					}
					if (this.mCam.target)
					{
						if (44936 - 333901 == -288964)
						{
							continue;
						}
						if (Input.GetButtonDown("cycleEnemy"))
						{
							if (296497 - 71408 == 225090)
							{
								continue;
							}
							if (!this.targetObject)
							{
								if (114120 - 326368 == -212247)
								{
									continue;
								}
								this.targetObject = this.cycleEnemyTarget((float)0, (float)1296);
								if (24489 - 238540 == -214050)
								{
									continue;
								}
							}
							else
							{
								this.targetObject = this.cycleEnemyTarget((this.mCam.target.transform.position - this.targetObject.transform.position).sqrMagnitude + 0.01f, (float)1296);
								if (102719 - 256558 != -153839)
								{
									continue;
								}
							}
							if (this.targetObject)
							{
								if (96744 - 146857 == -50112)
								{
									continue;
								}
								this.audio.PlayOneShot(this.WtZciCJbEVG);
								if (17487 - 105714 != -88227)
								{
									continue;
								}
							}
						}
					}
					if (this.mCam.target)
					{
						if (189293 - 478294 == -289000)
						{
							continue;
						}
						if (Input.GetButtonDown("cycleAlly"))
						{
							if (290400 - 243944 == 46457)
							{
								continue;
							}
							if (!this.targetObject)
							{
								if (240350 - 155108 == 85243)
								{
									continue;
								}
								this.targetObject = this.mPlayer;
								if (173052 - 349041 != -175989)
								{
									continue;
								}
							}
							else
							{
								this.targetObject = this.cycleAllyTarget((this.mCam.target.transform.position - this.targetObject.transform.position).sqrMagnitude + 0.01f, (float)1296);
								if (191843 - 261824 != -69981)
								{
									continue;
								}
							}
							if (this.targetObject)
							{
								if (156895 - 302212 != -145317)
								{
									continue;
								}
								this.audio.PlayOneShot(this.WtZciCJbEVG);
								if (271221 - 262729 == 8493)
								{
									continue;
								}
							}
						}
					}
					if (!Input.GetKey(KeyCode.LeftControl))
					{
						if (895 - 261058 == -260162)
						{
							continue;
						}
						if (!Input.GetKey(KeyCode.RightControl))
						{
							goto IL_1EC2;
						}
						if (276034 - 578645 != -302611)
						{
							continue;
						}
					}
					if (Input.GetKeyDown(KeyCode.R))
					{
						if (257619 - 200019 != 57600)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("autoAim", 1) != 0)
						{
							if (129030 - 57091 != 71939)
							{
								continue;
							}
							this.newGameMessage("Auto-aim attack off");
							if (206269 - 16967 != 189302)
							{
								continue;
							}
							PlayerPrefs.SetInt("autoAim", 0);
							if (249036 - 164797 != 84239)
							{
								continue;
							}
						}
						else
						{
							this.newGameMessage("Auto-aim attack on");
							if (28966 - 515042 != -486076)
							{
								continue;
							}
							PlayerPrefs.SetInt("autoAim", 1);
							if (29107 - 448247 == -419139)
							{
								continue;
							}
						}
					}
					if (Input.GetKeyDown(KeyCode.F))
					{
						if (257723 - 279811 == -22087)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("autoAimSkill", 1) != 0)
						{
							if (129911 - 489846 != -359935)
							{
								continue;
							}
							this.newGameMessage("Auto-aim skill off");
							if (264159 - 196247 != 67912)
							{
								continue;
							}
							PlayerPrefs.SetInt("autoAimSkill", 0);
							if (158233 - 125000 != 33233)
							{
								continue;
							}
						}
						else
						{
							this.newGameMessage("Auto-aim skill on");
							if (189260 - 45035 != 144225)
							{
								continue;
							}
							PlayerPrefs.SetInt("autoAimSkill", 1);
							if (75558 - 536102 != -460544)
							{
								continue;
							}
						}
					}
					if (Input.GetKeyDown(KeyCode.Z))
					{
						if (24068 - 311844 == -287775)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("display", 1) != 0)
						{
							if (199226 - 566153 != -366927)
							{
								continue;
							}
							this.newGameMessage("Display off");
							if (150866 - 87569 == 63298)
							{
								continue;
							}
							PlayerPrefs.SetInt("display", 0);
							if (240202 - 391210 != -151008)
							{
								continue;
							}
						}
						else
						{
							this.newGameMessage("Display on");
							if (167032 - 313067 == -146034)
							{
								continue;
							}
							PlayerPrefs.SetInt("display", 1);
							if (241990 - 11307 == 230684)
							{
								continue;
							}
						}
					}
					if (Input.GetKeyDown(KeyCode.V))
					{
						if (63441 - 13389 == 50053)
						{
							continue;
						}
						CameraEffect cameraEffect = (CameraEffect)this.GetComponent(typeof(CameraEffect));
						if (6853 - 100566 != -93713)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("vividColor", 1) != 0)
						{
							if (295139 - 126883 != 168256)
							{
								continue;
							}
							this.newGameMessage("Vivid color off");
							if (263145 - 474864 == -211718)
							{
								continue;
							}
							PlayerPrefs.SetInt("vividColor", 0);
							if (248670 - 194161 != 54509)
							{
								continue;
							}
							if (cameraEffect)
							{
								if (186682 - 492769 == -306086)
								{
									continue;
								}
								cameraEffect.useVividColor = false;
								if (215432 - 156860 == 58573)
								{
									continue;
								}
							}
						}
						else
						{
							this.newGameMessage("Vivid color on");
							if (54597 - 96431 == -41833)
							{
								continue;
							}
							PlayerPrefs.SetInt("vividColor", 1);
							if (223440 - 97518 == 125923)
							{
								continue;
							}
							if (cameraEffect)
							{
								if (68634 - 515722 == -447087)
								{
									continue;
								}
								cameraEffect.useVividColor = true;
								if (140008 - 450145 == -310136)
								{
									continue;
								}
							}
						}
					}
					if (Input.GetKeyDown(KeyCode.N))
					{
						if (1624 - 448609 == -446984)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("name", 1) != 0)
						{
							if (248896 - 456339 == -207442)
							{
								continue;
							}
							this.newGameMessage("Name display off");
							if (199744 - 215837 == -16092)
							{
								continue;
							}
							PlayerPrefs.SetInt("name", 0);
							if (75356 - 292464 == -217107)
							{
								continue;
							}
						}
						else
						{
							this.newGameMessage("Name display on");
							if (68763 - 50507 != 18256)
							{
								continue;
							}
							PlayerPrefs.SetInt("name", 1);
							if (6845 - 193604 == -186758)
							{
								continue;
							}
						}
					}
					if (Input.GetKeyDown(KeyCode.P))
					{
						if (244454 - 261521 == -17066)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("pname", 1) != 0)
						{
							if (79448 - 216323 != -136875)
							{
								continue;
							}
							this.newGameMessage("Player name off");
							if (141340 - 235083 != -93743)
							{
								continue;
							}
							PlayerPrefs.SetInt("pname", 0);
							if (7837 - 369604 == -361766)
							{
								continue;
							}
						}
						else
						{
							this.newGameMessage("Player name on");
							if (37393 - 358311 != -320918)
							{
								continue;
							}
							PlayerPrefs.SetInt("pname", 1);
							if (48392 - 270438 != -222046)
							{
								continue;
							}
						}
					}
					if (Input.GetKeyDown(KeyCode.H))
					{
						if (2997 - 279877 != -276880)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("cname", 1) != 0)
						{
							if (144088 - 35974 == 108115)
							{
								continue;
							}
							this.newGameMessage("Character name off");
							if (247951 - 32600 == 215352)
							{
								continue;
							}
							PlayerPrefs.SetInt("cname", 0);
							if (115076 - 73063 != 42013)
							{
								continue;
							}
						}
						else
						{
							this.newGameMessage("Character name on");
							if (192605 - 190790 == 1816)
							{
								continue;
							}
							PlayerPrefs.SetInt("cname", 1);
							if (149165 - 1997 == 147169)
							{
								continue;
							}
						}
					}
					if (Input.GetKeyDown(KeyCode.G))
					{
						if (143283 - 173861 == -30577)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("gname", 1) != 0)
						{
							if (68695 - 240769 != -172074)
							{
								continue;
							}
							this.newGameMessage("Guild name off");
							if (142550 - 423750 == -281199)
							{
								continue;
							}
							PlayerPrefs.SetInt("gname", 0);
							if (123341 - 124846 == -1504)
							{
								continue;
							}
						}
						else
						{
							this.newGameMessage("Guild name on");
							if (44408 - 186631 != -142223)
							{
								continue;
							}
							PlayerPrefs.SetInt("gname", 1);
							if (192516 - 393888 == -201371)
							{
								continue;
							}
						}
					}
					if (Input.GetKeyDown(KeyCode.B))
					{
						if (188726 - 137630 != 51096)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("chatBubble", 1) != 0)
						{
							if (261349 - 78383 != 182966)
							{
								continue;
							}
							this.newGameMessage("Chat bubble off");
							if (149188 - 310569 != -161381)
							{
								continue;
							}
							PlayerPrefs.SetInt("chatBubble", 0);
							if (118889 - 253201 == -134311)
							{
								continue;
							}
						}
						else
						{
							this.newGameMessage("Chat bubble on");
							if (198735 - 194829 != 3906)
							{
								continue;
							}
							PlayerPrefs.SetInt("chatBubble", 1);
							if (83735 - 220265 == -136529)
							{
								continue;
							}
						}
					}
					if (Input.GetKeyDown(KeyCode.L))
					{
						if (243544 - 97271 == 146274)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("menuSlide", 1) != 0)
						{
							if (88217 - 69256 != 18961)
							{
								continue;
							}
							this.newGameMessage("Menu slide off");
							if (52760 - 219887 == -167126)
							{
								continue;
							}
							PlayerPrefs.SetInt("menuSlide", 0);
							if (107990 - 218267 == -110276)
							{
								continue;
							}
						}
						else
						{
							this.newGameMessage("Menu slide on");
							if (273271 - 307942 != -34671)
							{
								continue;
							}
							PlayerPrefs.SetInt("menuSlide", 1);
							if (104164 - 127487 != -23323)
							{
								continue;
							}
						}
					}
					if (Input.GetKeyDown(KeyCode.T))
					{
						if (60372 - 270687 != -210315)
						{
							continue;
						}
						if (PlayerPrefs.GetInt("tutorial", 1) != 0)
						{
							if (124013 - 295426 == -171412)
							{
								continue;
							}
							this.newGameMessage("Tutorial off");
							if (84267 - 430532 != -346265)
							{
								continue;
							}
							PlayerPrefs.SetInt("tutorial", 0);
							if (129657 - 253187 != -123530)
							{
								continue;
							}
						}
						else
						{
							this.newGameMessage("Tutorial on");
							if (124587 - 86093 == 38495)
							{
								continue;
							}
							PlayerPrefs.SetInt("tutorial", 1);
							if (150816 - 247868 == -97051)
							{
								continue;
							}
						}
						GameObject[] array = GameObject.FindGameObjectsWithTag("Icon");
						if (220562 - 410704 != -190142)
						{
							continue;
						}
						int i = 0;
						if (105750 - 193498 != -87748)
						{
							continue;
						}
						GameObject[] array2 = array;
						if (211920 - 6988 == 204933)
						{
							continue;
						}
						int length = array2.Length;
						if (110291 - 224464 == -114172)
						{
							continue;
						}
						while (i < length)
						{
							TutorialIcon tutorialIcon = (TutorialIcon)array2[i].GetComponent(typeof(TutorialIcon));
							if (107300 - 543965 != -436665)
							{
								goto IL_C64;
							}
							if (tutorialIcon)
							{
								if (34508 - 466448 != -431940)
								{
									goto IL_C64;
								}
								tutorialIcon.enabled = (PlayerPrefs.GetInt("tutorial", 1) == 1);
								if (206497 - 145722 != 60775)
								{
									goto IL_C64;
								}
							}
							i++;
							if (129341 - 262463 != -133122)
							{
								goto IL_C64;
							}
						}
						if (177382 - 3642 == 173741)
						{
							continue;
						}
					}
					IL_1EC2:
					if (!Input.GetKeyDown(KeyCode.Return))
					{
						break;
					}
					if (236796 - 414395 != -177599)
					{
						continue;
					}
					if (Chat.ChatTimeOut >= Time.time)
					{
						break;
					}
					if (115668 - 109871 != 5797)
					{
						continue;
					}
					Chat.ChatActive = true;
					if (127927 - 409666 != -281739)
					{
						continue;
					}
					break;
					IL_1A0D:
					if (Input.GetKey(KeyCode.Z))
					{
						if (38989 - 197999 != -159009)
						{
							if (!Input.GetKey(KeyCode.LeftControl))
							{
								if (225015 - 473469 == -248453)
								{
									continue;
								}
								if (!Input.GetKey(KeyCode.RightControl))
								{
									if (196200 - 290670 == -94469)
									{
										continue;
									}
									if (!Input.GetKey(KeyCode.LeftAlt))
									{
										if (55232 - 553876 != -498644)
										{
											continue;
										}
										if (!Input.GetKey(KeyCode.RightAlt))
										{
											if (245080 - 571453 != -326373)
											{
												continue;
											}
											this.ldJciSWc06E = Mathf.Lerp(this.ldJciSWc06E, 1f, Time.deltaTime * (float)3);
											if (294596 - 149444 != 145152)
											{
												continue;
											}
											this.mCam.rotation = this.ldJciSWc06E;
											if (129518 - 335023 == -205504)
											{
												continue;
											}
										}
									}
								}
							}
							goto IL_25AA;
						}
					}
					else if (Input.GetKey(KeyCode.C))
					{
						if (241382 - 332055 == -90673)
						{
							if (!Input.GetKey(KeyCode.LeftControl))
							{
								if (247028 - 472002 != -224974)
								{
									continue;
								}
								if (!Input.GetKey(KeyCode.RightControl))
								{
									if (73487 - 332017 == -258529)
									{
										continue;
									}
									if (!Input.GetKey(KeyCode.LeftAlt))
									{
										if (106004 - 470117 == -364112)
										{
											continue;
										}
										if (!Input.GetKey(KeyCode.RightAlt))
										{
											if (101360 - 386640 == -285279)
											{
												continue;
											}
											this.ldJciSWc06E = Mathf.Lerp(this.ldJciSWc06E, -1f, Time.deltaTime * (float)3);
											if (19613 - 423254 != -403641)
											{
												continue;
											}
											this.mCam.rotation = this.ldJciSWc06E;
											if (144389 - 334992 != -190603)
											{
												continue;
											}
										}
									}
								}
							}
							goto IL_25AA;
						}
					}
					else
					{
						if (Screen.lockCursor)
						{
							if (10936 - 451971 != -441035)
							{
								continue;
							}
							Screen.lockCursor = false;
							if (21397 - 419574 == -398176)
							{
								continue;
							}
							Mousef.SetMousePosition((int)this.RH3cigdmkVM.x, (int)((float)Screen.height - this.RH3cigdmkVM.y));
							if (43212 - 86970 != -43758)
							{
								continue;
							}
						}
						float num = Mathf.Clamp(0.1f * Mathf.Floor(Time.time - this.BRjcibdpIVx - (float)5), (float)0, 1f);
						if (239796 - 53922 == 185874)
						{
							float num2 = (float)2 * Input.GetAxis("Analog X");
							if (192866 - 250158 == -57292)
							{
								if (Input.GetButton("rotateCamLeft"))
								{
									if (181051 - 369044 == -187992)
									{
										continue;
									}
									num2 -= 1.2f * num;
									if (286912 - 350357 == -63444)
									{
										continue;
									}
								}
								if (Input.GetButton("rotateCamRight"))
								{
									if (202665 - 597535 != -394870)
									{
										continue;
									}
									num2 += 1.2f * num;
									if (134945 - 206566 != -71621)
									{
										continue;
									}
								}
								if (Input.GetKeyDown("home"))
								{
									if (99112 - 69128 == 29985)
									{
										continue;
									}
									this.mCam.distance = (float)6;
									if (75074 - 333142 == -258067)
									{
										continue;
									}
								}
								if (Input.GetKeyDown("page up"))
								{
									if (69104 - 589982 == -520877)
									{
										continue;
									}
									this.mCam.distance = this.mCam.distance + (float)1;
									if (90889 - 430295 == -339405)
									{
										continue;
									}
								}
								if (Input.GetKeyDown("page down"))
								{
									if (149098 - 177152 != -28054)
									{
										continue;
									}
									this.mCam.distance = this.mCam.distance - (float)1;
									if (152006 - 92359 == 59648)
									{
										continue;
									}
								}
								if (Input.GetKeyDown("end"))
								{
									if (77317 - 270862 != -193545)
									{
										continue;
									}
									if (PlayerPrefs.GetInt("lowAngle", 0) != 0)
									{
										if (160016 - 59636 == 100381)
										{
											continue;
										}
										if (this.mCam)
										{
											if (44929 - 485050 != -440121)
											{
												continue;
											}
											this.mCam.lowAngle = false;
											if (215899 - 90329 == 125571)
											{
												continue;
											}
										}
										PlayerPrefs.SetInt("lowAngle", 0);
										if (52767 - 174364 == -121596)
										{
											continue;
										}
										this.newGameMessage("Low angle off");
										if (278733 - 583056 == -304322)
										{
											continue;
										}
									}
									else
									{
										if (this.mCam)
										{
											if (119151 - 210942 != -91791)
											{
												continue;
											}
											this.mCam.lowAngle = true;
											if (224551 - 417285 != -192734)
											{
												continue;
											}
										}
										PlayerPrefs.SetInt("lowAngle", 1);
										if (102542 - 57626 != 44916)
										{
											continue;
										}
										this.newGameMessage("Low angle on");
										if (285156 - 380111 != -94955)
										{
											continue;
										}
									}
								}
								this.ldJciSWc06E = Mathf.Lerp(this.ldJciSWc06E, Mathf.Clamp(num2, (float)-96 * Time.deltaTime, (float)96 * Time.deltaTime), Time.deltaTime * (float)3);
								if (8207 - 221861 != -213653)
								{
									this.mCam.rotation = this.ldJciSWc06E;
									if (214816 - 431197 == -216381)
									{
										goto IL_25AA;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060073A6 RID: 29606 RVA: 0x00FA72A4 File Offset: 0x00FA54A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GameObject cycleEnemyTarget(float minRange, float maxRange)
	{
		if (119668 - 505501 != -385833)
		{
		}
		GameObject result;
		for (;;)
		{
			IL_200:
			if (!this.mCam)
			{
				if (224655 - 96752 != 127904)
				{
					break;
				}
			}
			else if (!this.mCam.target)
			{
				if (187264 - 313995 == -126731)
				{
					break;
				}
			}
			else
			{
				GameObject[] array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Player"), GameObject.FindGameObjectsWithTag("Enemy"));
				if (29672 - 538316 == -508644)
				{
					result = null;
					if (235383 - 152377 == 83006)
					{
						int i = 0;
						if (65167 - 66750 == -1583)
						{
							GameObject[] array2 = array;
							if (246856 - 11049 != 235808)
							{
								int length = array2.Length;
								if (204832 - 172646 == 32186)
								{
									while (i < length)
									{
										if (array2[i].layer > 2)
										{
											if (276622 - 41499 != 235123)
											{
												goto IL_200;
											}
											if (array2[i].layer != this.mPlayer.layer)
											{
												if (67191 - 442789 == -375597)
												{
													goto IL_200;
												}
												if (global::Math.isOnScreen(array2[i]))
												{
													if (261896 - 201227 == 60670)
													{
														goto IL_200;
													}
													CharacterControl characterControl = (CharacterControl)array2[i].GetComponent(typeof(CharacterControl));
													if (20985 - 108968 != -87983)
													{
														goto IL_200;
													}
													if (characterControl.recieveTarget)
													{
														if (115120 - 118301 != -3181)
														{
															goto IL_200;
														}
														if (characterControl.getStatus("invisible") == null)
														{
															if (156424 - 14012 != 142412)
															{
																goto IL_200;
															}
															if (characterControl.getStatus("blend") == null)
															{
																if (56593 - 258810 != -202217)
																{
																	goto IL_200;
																}
																if (characterControl.getStatus("hide") == null)
																{
																	if (238965 - 380815 != -141850)
																	{
																		goto IL_200;
																	}
																	Vector3 vector = this.mCam.target.transform.position - array2[i].transform.position;
																	if (231909 - 210275 != 21634)
																	{
																		goto IL_200;
																	}
																	float sqrMagnitude = vector.sqrMagnitude;
																	if (21925 - 594215 == -572289)
																	{
																		goto IL_200;
																	}
																	if (sqrMagnitude > minRange)
																	{
																		if (43893 - 364544 == -320650)
																		{
																			goto IL_200;
																		}
																		if (sqrMagnitude < maxRange)
																		{
																			if (172732 - 39061 == 133672)
																			{
																				goto IL_200;
																			}
																			if (characterControl.hp > 0)
																			{
																				if (75430 - 534297 != -458867)
																				{
																					goto IL_200;
																				}
																				maxRange = sqrMagnitude;
																				if (2108 - 414159 != -412051)
																				{
																					goto IL_200;
																				}
																				result = array2[i];
																				if (112340 - 139223 != -26883)
																				{
																					goto IL_200;
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
										i++;
										if (98862 - 533871 == -435008)
										{
											goto IL_200;
										}
									}
									if (271370 - 197081 == 74289)
									{
										goto IL_3FC;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_402;
		IL_3FC:
		return result;
		IL_402:
		return null;
	}

	// Token: 0x060073A7 RID: 29607 RVA: 0x00FA76C8 File Offset: 0x00FA58C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GameObject cycleAllyTarget(float minRange, float maxRange)
	{
		if (110100 - 496637 != -386537)
		{
		}
		GameObject result;
		for (;;)
		{
			IL_23F:
			if (!this.mCam)
			{
				if (179046 - 214632 != -35585)
				{
					break;
				}
			}
			else if (!this.mCam.target)
			{
				if (66797 - 549515 == -482718)
				{
					break;
				}
			}
			else
			{
				GameObject[] array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Player"), GameObject.FindGameObjectsWithTag("Enemy"));
				if (118166 - 218727 != -100560)
				{
					result = null;
					if (238555 - 81 != 238475)
					{
						int i = 0;
						if (97399 - 46539 == 50860)
						{
							GameObject[] array2 = array;
							if (26178 - 407577 != -381398)
							{
								int length = array2.Length;
								if (288601 - 202533 != 86069)
								{
									while (i < length)
									{
										if (array2[i].layer > 2)
										{
											if (124018 - 410730 != -286712)
											{
												goto IL_23F;
											}
											if (array2[i].layer == this.mPlayer.layer)
											{
												if (156982 - 185595 != -28613)
												{
													goto IL_23F;
												}
												if (global::Math.isOnScreen(array2[i]))
												{
													if (66046 - 52073 == 13974)
													{
														goto IL_23F;
													}
													Vector3 vector = this.mCam.target.transform.position - array2[i].transform.position;
													if (115502 - 437787 == -322284)
													{
														goto IL_23F;
													}
													float sqrMagnitude = vector.sqrMagnitude;
													if (178053 - 327688 == -149634)
													{
														goto IL_23F;
													}
													if (sqrMagnitude > minRange)
													{
														if (221038 - 395939 == -174900)
														{
															goto IL_23F;
														}
														if (sqrMagnitude < maxRange)
														{
															if (183961 - 498792 != -314831)
															{
																goto IL_23F;
															}
															maxRange = sqrMagnitude;
															if (247124 - 354710 == -107585)
															{
																goto IL_23F;
															}
															result = array2[i];
															if (46146 - 595306 != -549160)
															{
																goto IL_23F;
															}
														}
													}
												}
											}
										}
										i++;
										if (29612 - 135375 != -105763)
										{
											goto IL_23F;
										}
									}
									if (180640 - 387327 != -206686)
									{
										goto Block_16;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_2F8;
		Block_16:
		return result;
		IL_2F8:
		return null;
	}

	// Token: 0x060073A8 RID: 29608 RVA: 0x00FA79E0 File Offset: 0x00FA5BE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitTargetArea()
	{
		if (95153 - 386113 != -290959)
		{
		}
		for (;;)
		{
			this.L7jci0JQANr = (Texture)Resources.Load("GameGui/GameWindow/targetArea/target", typeof(Texture));
			if (44949 - 529717 == -484768)
			{
				this.Cctci8eL5Co = (Texture)Resources.Load("GameGui/GameWindow/targetArea/targetAlly", typeof(Texture));
				if (158256 - 290508 == -132252)
				{
					this.U8icii1PLv9 = (Texture)Resources.Load("GameGui/GameWindow/targetArea/targetEnemy", typeof(Texture));
					if (105991 - 303779 == -197788)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060073A9 RID: 29609 RVA: 0x00FA7AC4 File Offset: 0x00FA5CC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderTargetArea()
	{
		if (52701 - 148723 != -96022)
		{
		}
		for (;;)
		{
			Vector3 vector = default(Vector3);
			if (169860 - 289256 == -119396)
			{
				float num = 0f;
				if (166349 - 323177 == -156828)
				{
					if (this.TargetAreaIsActive())
					{
						if (94579 - 152550 != -57971)
						{
							continue;
						}
						RaycastHit raycastHit = default(RaycastHit);
						if (64089 - 486704 != -422615)
						{
							continue;
						}
						Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
						if (222221 - 34259 == 187963)
						{
							continue;
						}
						int num2 = 30;
						if (1672 - 425427 != -423755)
						{
							continue;
						}
						int num3 = 0;
						if (196987 - 458563 == -261575)
						{
							continue;
						}
						if (!Input.GetMouseButtonDown(1))
						{
							if (211508 - 506628 == -295119)
							{
								continue;
							}
							if (!this.mCam.target)
							{
								if (275127 - 435581 == -160453)
								{
									continue;
								}
							}
							else
							{
								num3 = 6 + (1 << this.mCam.target.layer);
								if (246274 - 123570 != 122705)
								{
									goto IL_4A3;
								}
								continue;
							}
						}
						num3 = 6;
						if (138151 - 400510 == -262358)
						{
							continue;
						}
						num2 = 40;
						if (266457 - 327824 != -61367)
						{
							continue;
						}
						IL_4A3:
						num3 = ~num3;
						if (104442 - 428232 == -323789)
						{
							continue;
						}
						if (Physics.Raycast(ray, out raycastHit, (float)num2, num3))
						{
							if (9127 - 380989 == -371861)
							{
								continue;
							}
							this.ogYcimbuwmv = raycastHit.transform.gameObject;
							if (98342 - 62211 != 36131)
							{
								continue;
							}
							this.T0icijoN2oY = raycastHit.point + new Vector3((float)0, raycastHit.normal.y, (float)0);
							if (79326 - 177672 != -98346)
							{
								continue;
							}
							if (this.ogYcimbuwmv == this.mPlayer)
							{
								if (131103 - 388278 == -257174)
								{
									continue;
								}
							}
							else
							{
								if (!(this.ogYcimbuwmv.tag == "Player"))
								{
									if (151730 - 38334 != 113396)
									{
										continue;
									}
									if (this.ogYcimbuwmv.tag == "Enemy")
									{
										if (181974 - 498905 != -316931)
										{
											continue;
										}
									}
									else
									{
										this.ogYcimbuwmv = null;
										if (130203 - 588479 != -458276)
										{
											continue;
										}
										goto IL_3ED;
									}
								}
								if (PlayerPrefs.GetInt("display", 1) != 0)
								{
									if (114682 - 441049 == -326366)
									{
										continue;
									}
									vector = this.camera.WorldToScreenPoint(this.ogYcimbuwmv.collider.bounds.center);
									if (16299 - 326475 != -310176)
									{
										continue;
									}
									num = Mathf.Clamp((float)Screen.height / vector.z, (float)32, (float)128);
									if (150551 - 470842 == -320290)
									{
										continue;
									}
									GUI.DrawTexture(new Rect(vector.x - num, (float)Screen.height - vector.y - num, (float)2 * num, (float)2 * num), this.L7jci0JQANr);
									if (105733 - 59072 == 46662)
									{
										continue;
									}
								}
							}
							IL_3ED:;
						}
						else
						{
							this.T0icijoN2oY = this.mPlayer.transform.position + (float)30 * global::Math.getScreenVector(Input.mousePosition).normalized;
							if (7084 - 419823 == -412738)
							{
								continue;
							}
							this.ogYcimbuwmv = null;
							if (213339 - 553321 != -339982)
							{
								continue;
							}
						}
					}
					else
					{
						this.T0icijoN2oY = this.mPlayer.transform.position + (float)30 * global::Math.getScreenVector(Input.mousePosition).normalized;
						if (168198 - 216644 != -48446)
						{
							continue;
						}
						this.ogYcimbuwmv = null;
						if (95448 - 532617 == -437168)
						{
							continue;
						}
					}
					if (!this.targetObject)
					{
						break;
					}
					if (245756 - 58820 == 186936)
					{
						if (!this.mCam.target)
						{
							break;
						}
						if (135503 - 40968 == 94535)
						{
							Vector3 vector2 = Vector3.Scale(this.mCam.target.transform.position - this.targetObject.transform.position, new Vector3((float)1, (float)0, (float)1));
							if (175466 - 561523 == -386057)
							{
								if (vector2.sqrMagnitude > (float)1600)
								{
									if (189820 - 559264 != -369443)
									{
										this.targetObject = null;
										if (255135 - 375455 == -120320)
										{
											break;
										}
									}
								}
								else if (this.targetObject.layer == 2)
								{
									if (224294 - 522675 == -298381)
									{
										this.targetObject = null;
										if (265337 - 269632 == -4295)
										{
											break;
										}
									}
								}
								else if (global::Math.isOnScreen(this.targetObject))
								{
									if (4783 - 435608 == -430825)
									{
										vector = this.camera.WorldToScreenPoint(this.targetObject.collider.bounds.center);
										if (71908 - 338404 == -266496)
										{
											num = Mathf.Clamp((float)Screen.height / vector.z, (float)32, (float)128);
											if (216264 - 228102 == -11838)
											{
												if (this.targetObject.layer != this.mPlayer.layer)
												{
													if (269313 - 6038 != 263275)
													{
														continue;
													}
													if (this.targetObject.tag != "NPC")
													{
														if (55817 - 173106 != -117289)
														{
															continue;
														}
														if (PlayerPrefs.GetInt("display", 1) == 0)
														{
															break;
														}
														if (153785 - 389289 != -235504)
														{
															continue;
														}
														GUI.DrawTexture(new Rect(vector.x - num, (float)Screen.height - vector.y - num, (float)2 * num, (float)2 * num), this.U8icii1PLv9);
														if (70562 - 246043 != -175480)
														{
															break;
														}
														continue;
													}
												}
												if (PlayerPrefs.GetInt("display", 1) == 0)
												{
													break;
												}
												if (174245 - 67062 != 107184)
												{
													GUI.DrawTexture(new Rect(vector.x - num, (float)Screen.height - vector.y - num, (float)2 * num, (float)2 * num), this.Cctci8eL5Co);
													if (15712 - 61000 == -45288)
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
									this.targetObject = null;
									if (253382 - 354526 == -101144)
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

	// Token: 0x060073AA RID: 29610 RVA: 0x00FA837C File Offset: 0x00FA657C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool TargetAreaIsActive()
	{
		if (18398 - 70495 != -52097)
		{
		}
		bool result;
		for (;;)
		{
			result = true;
			if (59455 - 390368 == -330913)
			{
				if (GUIUtility.hotControl != 0)
				{
					break;
				}
				if (64819 - 541202 != -476382)
				{
					if (Chat.ChatActive)
					{
						if (109761 - 552920 != -443158)
						{
							break;
						}
					}
					else
					{
						Rect rect = new Rect((float)0, (float)30 * this.o53ciqnfnhL, (float)Screen.width, (float)Screen.height - (float)120 * this.o53ciqnfnhL);
						if (185828 - 329805 != -143976)
						{
							if (rect.Contains(Event.current.mousePosition))
							{
								goto IL_FD;
							}
							if (114764 - 245860 != -131095)
							{
								goto Block_5;
							}
						}
					}
				}
			}
		}
		IL_1A:
		return false;
		Block_5:
		return false;
		goto IL_1A;
		IL_FD:
		return result;
	}

	// Token: 0x060073AB RID: 29611 RVA: 0x00FA8498 File Offset: 0x00FA6698
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitMapBar()
	{
		if (18267 - 394476 != -376208)
		{
		}
		for (;;)
		{
			this.IhIcikTnQnQ = (Texture)Resources.Load("GameGui/GameWindow/mapBar/MapBar", typeof(Texture));
			if (236672 - 270382 == -33710)
			{
				this.grWciFd19Xn = (Texture)Resources.Load("GameGui/GameWindow/mapBar/AllyDot", typeof(Texture));
				if (162670 - 555974 == -393304)
				{
					this.z0ZciANDYkj = (Texture)Resources.Load("GameGui/GameWindow/mapBar/EnemyDot", typeof(Texture));
					if (129617 - 364183 != -234565)
					{
						this.VNxci9u3V4N = (Texture)Resources.Load("GameGui/GameWindow/mapBar/NpcDot", typeof(Texture));
						if (221434 - 21404 == 200030)
						{
							this.MShciWVGGOK = (Texture)Resources.Load("GameGui/GameWindow/mapBar/Sun", typeof(Texture));
							if (162497 - 371277 == -208780)
							{
								this.QmRciuWH3Wo = (Texture)Resources.Load("GameGui/GameWindow/mapBar/Moon", typeof(Texture));
								if (284165 - 93959 == 190206)
								{
									if (Game.mGameType < 5)
									{
										break;
									}
									if (19458 - 10701 == 8757)
									{
										this.OtjciyKMLTB = (Texture)Resources.Load("GameGui/Icons/Map/Wolf", typeof(Texture));
										if (90794 - 327343 == -236549)
										{
											this.hYqciV1Ropn = (Texture)Resources.Load("GameGui/Icons/Map/Bison", typeof(Texture));
											if (116898 - 592276 != -475377)
											{
												this.cuocih7lrQu = (Texture)Resources.Load("GameGui/Icons/Map/Panda", typeof(Texture));
												if (248692 - 415774 != -167081)
												{
													this.kSMciKqq746 = (Texture)Resources.Load("GameGui/Icons/Map/Whale", typeof(Texture));
													if (297975 - 353815 == -55840)
													{
														this.IWAcizLGVow = (Texture)Resources.Load("GameGui/Icons/Map/Cat", typeof(Texture));
														if (123049 - 432943 != -309893)
														{
															this.J4mcD57pWrP = (Texture)Resources.Load("GameGui/Icons/Map/Chameleon", typeof(Texture));
															if (108004 - 115543 == -7539)
															{
																this.OEZcDctMh6p = (Texture)Resources.Load("GameGui/Icons/Map/Rabbit", typeof(Texture));
																if (187751 - 406542 != -218790)
																{
																	this.sKGcDnybYa5 = (Texture)Resources.Load("GameGui/Icons/Map/Mole", typeof(Texture));
																	if (178734 - 333291 == -154557)
																	{
																		this.hQucDQJaGoa = (Texture)Resources.Load("GameGui/Icons/Map/Monkey", typeof(Texture));
																		if (54221 - 370607 == -316386)
																		{
																			this.UEHcDecSCvo = (Texture)Resources.Load("GameGui/Icons/Map/Penguin", typeof(Texture));
																			if (109424 - 201352 == -91928)
																			{
																				this.I2XcDIVgPw3 = (Texture)Resources.Load("GameGui/Icons/Map/Sheep", typeof(Texture));
																				if (234522 - 350220 == -115698)
																				{
																					this.fSdcDJSPCXs = (Texture)Resources.Load("GameGui/Icons/Map/Bat", typeof(Texture));
																					if (38550 - 548360 == -509810)
																					{
																						this.yTacD6DV0AH = (Texture)Resources.Load("GameGui/Icons/Map/Wolf_e", typeof(Texture));
																						if (57876 - 140994 != -83117)
																						{
																							this.utucDt6eZDj = (Texture)Resources.Load("GameGui/Icons/Map/Bison_e", typeof(Texture));
																							if (106464 - 264713 != -158248)
																							{
																								this.RDDcDXirMcc = (Texture)Resources.Load("GameGui/Icons/Map/Panda_e", typeof(Texture));
																								if (11799 - 367361 != -355561)
																								{
																									this.yUfcDOBENRv = (Texture)Resources.Load("GameGui/Icons/Map/Whale_e", typeof(Texture));
																									if (26455 - 339700 != -313244)
																									{
																										this.f5tcD2H01ua = (Texture)Resources.Load("GameGui/Icons/Map/Cat_e", typeof(Texture));
																										if (76065 - 485930 == -409865)
																										{
																											this.kU7cDvP3yTO = (Texture)Resources.Load("GameGui/Icons/Map/Chameleon_e", typeof(Texture));
																											if (220273 - 449501 == -229228)
																											{
																												this.u2KcDlZkXWA = (Texture)Resources.Load("GameGui/Icons/Map/Rabbit_e", typeof(Texture));
																												if (151038 - 314673 == -163635)
																												{
																													this.GvScDGgkwQD = (Texture)Resources.Load("GameGui/Icons/Map/Mole_e", typeof(Texture));
																													if (85491 - 524403 != -438911)
																													{
																														this.kdHcD1Ii0sO = (Texture)Resources.Load("GameGui/Icons/Map/Monkey_e", typeof(Texture));
																														if (289367 - 78505 != 210863)
																														{
																															this.n8ucDqESv9E = (Texture)Resources.Load("GameGui/Icons/Map/Penguin_e", typeof(Texture));
																															if (165816 - 43239 != 122578)
																															{
																																this.UHEcDpD0VBN = (Texture)Resources.Load("GameGui/Icons/Map/Sheep_e", typeof(Texture));
																																if (5443 - 266791 == -261348)
																																{
																																	this.DO5cDRc3LLf = (Texture)Resources.Load("GameGui/Icons/Map/Bat_e", typeof(Texture));
																																	if (131903 - 216923 == -85020)
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

	// Token: 0x060073AC RID: 29612 RVA: 0x00FA8BA4 File Offset: 0x00FA6DA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderMapBar()
	{
		if (10689 - 203038 != -192349)
		{
		}
		for (;;)
		{
			IL_340:
			if (Event.current.type != EventType.Repaint)
			{
				if (27815 - 537309 == -509494)
				{
					break;
				}
			}
			else
			{
				int num = 0;
				if (76204 - 424847 == -348643)
				{
					int fipcivWhRLF = this.FipcivWhRLF;
					if (102412 - 108132 != -5719)
					{
						if (fipcivWhRLF == 1)
						{
							if (95947 - 85255 != 10692)
							{
								continue;
							}
							num = (int)Mathf.SmoothStep((float)300, (float)0, (float)2 * (Time.time - this.Xd9cil9WnGp));
							if (86789 - 535821 == -449031)
							{
								continue;
							}
						}
						else if (fipcivWhRLF == 2)
						{
							if (205467 - 371491 != -166024)
							{
								continue;
							}
							num = 0;
							if (279115 - 545607 != -266492)
							{
								continue;
							}
						}
						else if (fipcivWhRLF == 3)
						{
							if (149921 - 591207 == -441285)
							{
								continue;
							}
							num = (int)Mathf.SmoothStep((float)0, (float)300, (float)2 * (Time.time - this.Xd9cil9WnGp));
							if (112560 - 245644 == -133083)
							{
								continue;
							}
						}
						else
						{
							if (fipcivWhRLF != 4)
							{
								break;
							}
							if (143586 - 263876 == -120289)
							{
								continue;
							}
							num = 0;
							if (53636 - 258567 == -204930)
							{
								continue;
							}
						}
						GUI.BeginGroup(new Rect((float)(0 - num), (float)0, (float)265, (float)210));
						if (286038 - 564430 == -278392)
						{
							int mGameCode = Game.mGameCode;
							if (218251 - 596568 != -378316)
							{
								if (mGameCode == 31)
								{
									if (240557 - 358561 != -118004)
									{
										continue;
									}
									goto IL_1EA;
								}
								else if (mGameCode == 501)
								{
									if (271795 - 73524 != 198272)
									{
										goto IL_1EA;
									}
									continue;
								}
								else if (mGameCode == 502)
								{
									if (42728 - 429988 != -387259)
									{
										goto IL_637;
									}
									continue;
								}
								else if (mGameCode == 503)
								{
									if (296839 - 244240 != 52600)
									{
										goto IL_661;
									}
									continue;
								}
								else if (mGameCode == 504)
								{
									if (179956 - 23177 != 156780)
									{
										goto IL_1C0;
									}
									continue;
								}
								else if (mGameCode == 505)
								{
									if (66562 - 78481 != -11919)
									{
										continue;
									}
									goto IL_48F;
								}
								else if (mGameCode == 506)
								{
									if (98315 - 31396 != 66920)
									{
										goto IL_78C;
									}
									continue;
								}
								else if (mGameCode == 507)
								{
									if (90826 - 122322 != -31496)
									{
										continue;
									}
									goto IL_B6F;
								}
								else if (mGameCode == 508)
								{
									if (246496 - 348464 != -101967)
									{
										goto IL_868;
									}
									continue;
								}
								else if (mGameCode == 601)
								{
									if (58371 - 82343 != -23971)
									{
										goto IL_5EA;
									}
									continue;
								}
								else if (mGameCode == 602)
								{
									if (724 - 174251 != -173527)
									{
										continue;
									}
									goto IL_2DC;
								}
								else if (mGameCode == 603)
								{
									if (187616 - 194154 != -6537)
									{
										goto IL_3CC;
									}
									continue;
								}
								else if (mGameCode == 604)
								{
									if (194108 - 485335 != -291227)
									{
										continue;
									}
									goto IL_892;
								}
								else if (mGameCode == 605)
								{
									if (263047 - 209489 != 53559)
									{
										goto IL_ADF;
									}
									continue;
								}
								else if (mGameCode == 606)
								{
									if (78935 - 74826 != 4110)
									{
										goto IL_36A;
									}
									continue;
								}
								else if (mGameCode == 607)
								{
									if (198319 - 125610 != 72710)
									{
										goto IL_4B9;
									}
									continue;
								}
								else if (mGameCode == 608)
								{
									if (274633 - 370873 != -96239)
									{
										goto IL_B99;
									}
									continue;
								}
								else
								{
									GUI.DrawTexture(new Rect((float)2, (float)4, (float)54, (float)54), this.MShciWVGGOK);
									if (6778 - 348662 == -341883)
									{
										continue;
									}
								}
								IL_9E:
								GUI.DrawTexture(new Rect((float)0, (float)0, (float)261, (float)207), this.IhIcikTnQnQ);
								if (71672 - 291092 == -219419)
								{
									continue;
								}
								GameObject[] array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Icon"), GameObject.FindGameObjectsWithTag("Enemy")), GameObject.FindGameObjectsWithTag("NPC"));
								if (118377 - 38169 != 80208)
								{
									continue;
								}
								if (Game.mGameType <= 4)
								{
									if (156448 - 453604 != -297156)
									{
										continue;
									}
									array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), array, GameObject.FindGameObjectsWithTag("Player"));
									if (286582 - 278729 != 7853)
									{
										continue;
									}
								}
								int i = 0;
								if (77490 - 490139 != -412649)
								{
									continue;
								}
								GameObject[] array2 = array;
								if (7896 - 159527 != -151631)
								{
									continue;
								}
								int length = array2.Length;
								if (6697 - 534762 != -528065)
								{
									continue;
								}
								while (i < length)
								{
									if (array2[i])
									{
										if (235359 - 276014 == -40654)
										{
											goto IL_340;
										}
										Vector3 vector = global::Math.vFlat(this.transform.position - array2[i].transform.position);
										if (255720 - 385024 != -129304)
										{
											goto IL_340;
										}
										float magnitude = vector.magnitude;
										if (25964 - 287432 != -261468)
										{
											goto IL_340;
										}
										if (magnitude < this.IHtcDrxQJgk * (float)100)
										{
											if (141097 - 108940 != 32157)
											{
												goto IL_340;
											}
											Vector3 position = this.transform.position;
											if (93575 - 33805 == 59771)
											{
												goto IL_340;
											}
											float y = position.x - array2[i].transform.position.x;
											if (285794 - 269879 != 15915)
											{
												goto IL_340;
											}
											Vector3 position2 = this.transform.position;
											if (56742 - 468288 == -411545)
											{
												goto IL_340;
											}
											float x = position2.z - array2[i].transform.position.z;
											if (201853 - 451426 != -249573)
											{
												goto IL_340;
											}
											float num2 = Mathf.Atan2(y, x) * 57.29578f - (float)270 - this.transform.eulerAngles.y;
											if (217239 - 548000 == -330760)
											{
												goto IL_340;
											}
											float num3 = 0.5f * magnitude * Mathf.Cos(num2 * 0.017453292f) / this.IHtcDrxQJgk;
											if (137728 - 472192 != -334464)
											{
												goto IL_340;
											}
											float num4 = 0.5f * magnitude * Mathf.Sin(num2 * 0.017453292f) / this.IHtcDrxQJgk;
											if (94855 - 72064 != 22791)
											{
												goto IL_340;
											}
											if (array2[i].tag == "Icon")
											{
												if (281809 - 100714 == 181096)
												{
													goto IL_340;
												}
												IconControl iconControl = (IconControl)array2[i].GetComponent(typeof(IconControl));
												if (178888 - 435910 != -257022)
												{
													goto IL_340;
												}
												if (iconControl)
												{
													if (70651 - 343433 == -272781)
													{
														goto IL_340;
													}
													if (iconControl.MapIcon)
													{
														if (146714 - 40978 != 105736)
														{
															goto IL_340;
														}
														GUI.DrawTexture(new Rect((float)122 + num3 - 0.5f * (float)iconControl.MapIcon.width, (float)107 + num4 - 0.5f * (float)iconControl.MapIcon.height, (float)iconControl.MapIcon.width, (float)iconControl.MapIcon.height), iconControl.MapIcon);
														if (27097 - 581522 != -554425)
														{
															goto IL_340;
														}
													}
												}
											}
											else if (array2[i].tag == "NPC")
											{
												if (53405 - 453564 == -400158)
												{
													goto IL_340;
												}
												GUI.DrawTexture(new Rect((float)125 + num3, (float)110 + num4, (float)6, (float)6), this.VNxci9u3V4N);
												if (188023 - 59639 != 128384)
												{
													goto IL_340;
												}
											}
											else
											{
												if (this.mPlayer)
												{
													if (118364 - 204139 != -85775)
													{
														goto IL_340;
													}
													if (this.mPlayer.layer == array2[i].layer)
													{
														if (28552 - 276454 != -247902)
														{
															goto IL_340;
														}
														GUI.DrawTexture(new Rect((float)125 + num3, (float)110 + num4, (float)6, (float)6), this.grWciFd19Xn);
														if (157726 - 272073 != -114347)
														{
															goto IL_340;
														}
														goto IL_214;
													}
												}
												GUI.DrawTexture(new Rect((float)125 + num3, (float)110 + num4, (float)6, (float)6), this.z0ZciANDYkj);
												if (170642 - 397325 != -226683)
												{
													goto IL_340;
												}
											}
										}
									}
									IL_214:
									i++;
									if (260902 - 388201 == -127298)
									{
										goto IL_340;
									}
								}
								if (191975 - 237915 == -45939)
								{
									continue;
								}
								if (Game.mGameType > 4)
								{
									if (170869 - 448764 != -277895)
									{
										continue;
									}
									this.displayPlayerIcon();
									if (11645 - 525435 != -513790)
									{
										continue;
									}
								}
								GUI.EndGroup();
								if (150097 - 577537 != -427440)
								{
									continue;
								}
								break;
								IL_B99:
								GUI.DrawTexture(new Rect((float)2, (float)4, (float)54, (float)54), this.QmRciuWH3Wo);
								if (102360 - 246275 != -143914)
								{
									goto IL_9E;
								}
								continue;
								IL_4B9:
								goto IL_B99;
								IL_36A:
								goto IL_4B9;
								IL_ADF:
								goto IL_36A;
								IL_892:
								goto IL_ADF;
								IL_3CC:
								goto IL_892;
								IL_2DC:
								goto IL_3CC;
								IL_5EA:
								goto IL_2DC;
								IL_868:
								goto IL_5EA;
								IL_B6F:
								goto IL_868;
								IL_78C:
								goto IL_B6F;
								IL_48F:
								goto IL_78C;
								IL_1C0:
								goto IL_48F;
								IL_661:
								goto IL_1C0;
								IL_637:
								goto IL_661;
								IL_1EA:
								goto IL_637;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060073AD RID: 29613 RVA: 0x00FA97D8 File Offset: 0x00FA79D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void displayPlayerIcon()
	{
		if (295474 - 308051 != -12576)
		{
		}
		for (;;)
		{
			IL_456:
			GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
			if (129936 - 322310 != -192373)
			{
				int i = 0;
				if (228636 - 386183 != -157546)
				{
					GameObject[] array2 = array;
					if (8072 - 55225 != -47152)
					{
						int length = array2.Length;
						if (168463 - 347647 == -179184)
						{
							while (i < length)
							{
								if (array2[i])
								{
									if (135067 - 579304 == -444236)
									{
										goto IL_456;
									}
									Vector3 vector = global::Math.vFlat(this.transform.position - array2[i].transform.position);
									if (71004 - 153527 != -82523)
									{
										goto IL_456;
									}
									float magnitude = vector.magnitude;
									if (273733 - 254225 != 19508)
									{
										goto IL_456;
									}
									if (magnitude < this.IHtcDrxQJgk * (float)100)
									{
										if (245849 - 355192 == -109342)
										{
											goto IL_456;
										}
										Vector3 position = this.transform.position;
										if (84656 - 481782 == -397125)
										{
											goto IL_456;
										}
										float y = position.x - array2[i].transform.position.x;
										if (295953 - 221319 == 74635)
										{
											goto IL_456;
										}
										Vector3 position2 = this.transform.position;
										if (178356 - 11973 != 166383)
										{
											goto IL_456;
										}
										float x = position2.z - array2[i].transform.position.z;
										if (295869 - 566746 == -270876)
										{
											goto IL_456;
										}
										float num = Mathf.Atan2(y, x) * 57.29578f - (float)270 - this.transform.eulerAngles.y;
										if (84768 - 286477 == -201708)
										{
											goto IL_456;
										}
										float num2 = 0.5f * magnitude * Mathf.Cos(num * 0.017453292f) / this.IHtcDrxQJgk;
										if (175199 - 257001 != -81802)
										{
											goto IL_456;
										}
										float num3 = 0.5f * magnitude * Mathf.Sin(num * 0.017453292f) / this.IHtcDrxQJgk;
										if (250671 - 166023 != 84648)
										{
											goto IL_456;
										}
										if (this.mPlayer)
										{
											if (225665 - 200470 == 25196)
											{
												goto IL_456;
											}
											if (this.mPlayer.layer == array2[i].layer)
											{
												if (247697 - 358395 != -110698)
												{
													goto IL_456;
												}
												object lhs = Game.mGamePlayerType[array2[i].name];
												if (188457 - 301379 != -112922)
												{
													goto IL_456;
												}
												if (RuntimeServices.EqualityOperator(lhs, "Wolf"))
												{
													if (34603 - 125074 == -90470)
													{
														goto IL_456;
													}
													GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.OtjciyKMLTB);
													if (113535 - 164831 == -51295)
													{
														goto IL_456;
													}
												}
												else if (RuntimeServices.EqualityOperator(lhs, "Bison"))
												{
													if (78925 - 119848 != -40923)
													{
														goto IL_456;
													}
													GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.hYqciV1Ropn);
													if (143331 - 572448 != -429117)
													{
														goto IL_456;
													}
												}
												else if (RuntimeServices.EqualityOperator(lhs, "Panda"))
												{
													if (45778 - 91148 != -45370)
													{
														goto IL_456;
													}
													GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.cuocih7lrQu);
													if (232669 - 231424 == 1246)
													{
														goto IL_456;
													}
												}
												else if (RuntimeServices.EqualityOperator(lhs, "Whale"))
												{
													if (28914 - 309675 == -280760)
													{
														goto IL_456;
													}
													GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.kSMciKqq746);
													if (146992 - 1951 == 145042)
													{
														goto IL_456;
													}
												}
												else if (RuntimeServices.EqualityOperator(lhs, "Cat"))
												{
													if (145413 - 280701 != -135288)
													{
														goto IL_456;
													}
													GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.IWAcizLGVow);
													if (213239 - 282529 != -69290)
													{
														goto IL_456;
													}
												}
												else if (RuntimeServices.EqualityOperator(lhs, "Chameleon"))
												{
													if (290510 - 572171 == -281660)
													{
														goto IL_456;
													}
													GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.J4mcD57pWrP);
													if (125572 - 399419 != -273847)
													{
														goto IL_456;
													}
												}
												else if (RuntimeServices.EqualityOperator(lhs, "Rabbit"))
												{
													if (162585 - 515692 == -353106)
													{
														goto IL_456;
													}
													GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.OEZcDctMh6p);
													if (208232 - 492064 == -283831)
													{
														goto IL_456;
													}
												}
												else if (RuntimeServices.EqualityOperator(lhs, "Mole"))
												{
													if (218383 - 306487 == -88103)
													{
														goto IL_456;
													}
													GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.sKGcDnybYa5);
													if (201763 - 456396 != -254633)
													{
														goto IL_456;
													}
												}
												else if (RuntimeServices.EqualityOperator(lhs, "Monkey"))
												{
													if (112380 - 403863 == -291482)
													{
														goto IL_456;
													}
													GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.hQucDQJaGoa);
													if (289348 - 317638 != -28290)
													{
														goto IL_456;
													}
												}
												else if (RuntimeServices.EqualityOperator(lhs, "Sheep"))
												{
													if (64658 - 321630 != -256972)
													{
														goto IL_456;
													}
													GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.I2XcDIVgPw3);
													if (273212 - 435247 == -162034)
													{
														goto IL_456;
													}
												}
												else if (RuntimeServices.EqualityOperator(lhs, "Penguin"))
												{
													if (116766 - 399976 != -283210)
													{
														goto IL_456;
													}
													GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.UEHcDecSCvo);
													if (117501 - 58615 != 58886)
													{
														goto IL_456;
													}
												}
												else if (RuntimeServices.EqualityOperator(lhs, "Bat"))
												{
													if (563 - 150903 != -150340)
													{
														goto IL_456;
													}
													GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.fSdcDJSPCXs);
													if (249679 - 30117 == 219563)
													{
														goto IL_456;
													}
												}
												else
												{
													GUI.DrawTexture(new Rect((float)125 + num2, (float)110 + num3, (float)6, (float)6), this.grWciFd19Xn);
													if (292118 - 204462 == 87657)
													{
														goto IL_456;
													}
												}
												goto IL_78A;
											}
										}
										object lhs2 = Game.mGamePlayerType[array2[i].name];
										if (232583 - 30883 != 201700)
										{
											goto IL_456;
										}
										if (RuntimeServices.EqualityOperator(lhs2, "Wolf"))
										{
											if (40052 - 78953 != -38901)
											{
												goto IL_456;
											}
											GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.yTacD6DV0AH);
											if (132521 - 147872 == -15350)
											{
												goto IL_456;
											}
										}
										else if (RuntimeServices.EqualityOperator(lhs2, "Bison"))
										{
											if (202916 - 267990 == -65073)
											{
												goto IL_456;
											}
											GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.utucDt6eZDj);
											if (86986 - 510878 != -423892)
											{
												goto IL_456;
											}
										}
										else if (RuntimeServices.EqualityOperator(lhs2, "Panda"))
										{
											if (205679 - 112501 == 93179)
											{
												goto IL_456;
											}
											GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.RDDcDXirMcc);
											if (227275 - 272210 == -44934)
											{
												goto IL_456;
											}
										}
										else if (RuntimeServices.EqualityOperator(lhs2, "Whale"))
										{
											if (233524 - 336072 == -102547)
											{
												goto IL_456;
											}
											GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.yUfcDOBENRv);
											if (62829 - 457157 != -394328)
											{
												goto IL_456;
											}
										}
										else if (RuntimeServices.EqualityOperator(lhs2, "Cat"))
										{
											if (240390 - 43334 == 197057)
											{
												goto IL_456;
											}
											GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.f5tcD2H01ua);
											if (259740 - 3873 != 255867)
											{
												goto IL_456;
											}
										}
										else if (RuntimeServices.EqualityOperator(lhs2, "Chameleon"))
										{
											if (108772 - 396739 != -287967)
											{
												goto IL_456;
											}
											GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.kU7cDvP3yTO);
											if (124792 - 440596 != -315804)
											{
												goto IL_456;
											}
										}
										else if (RuntimeServices.EqualityOperator(lhs2, "Rabbit"))
										{
											if (216480 - 134549 == 81932)
											{
												goto IL_456;
											}
											GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.u2KcDlZkXWA);
											if (135324 - 65861 == 69464)
											{
												goto IL_456;
											}
										}
										else if (RuntimeServices.EqualityOperator(lhs2, "Mole"))
										{
											if (107491 - 585367 == -477875)
											{
												goto IL_456;
											}
											GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.GvScDGgkwQD);
											if (206151 - 136058 == 70094)
											{
												goto IL_456;
											}
										}
										else if (RuntimeServices.EqualityOperator(lhs2, "Monkey"))
										{
											if (278268 - 41898 != 236370)
											{
												goto IL_456;
											}
											GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.kdHcD1Ii0sO);
											if (40701 - 252127 == -211425)
											{
												goto IL_456;
											}
										}
										else if (RuntimeServices.EqualityOperator(lhs2, "Sheep"))
										{
											if (143634 - 305393 == -161758)
											{
												goto IL_456;
											}
											GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.UHEcDpD0VBN);
											if (282203 - 388 == 281816)
											{
												goto IL_456;
											}
										}
										else if (RuntimeServices.EqualityOperator(lhs2, "Penguin"))
										{
											if (210514 - 451033 != -240519)
											{
												goto IL_456;
											}
											GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.n8ucDqESv9E);
											if (217849 - 53725 != 164124)
											{
												goto IL_456;
											}
										}
										else if (RuntimeServices.EqualityOperator(lhs2, "Bat"))
										{
											if (170035 - 15240 == 154796)
											{
												goto IL_456;
											}
											GUI.DrawTexture(new Rect((float)116 + num2, (float)101 + num3, (float)24, (float)24), this.DO5cDRc3LLf);
											if (223622 - 544721 == -321098)
											{
												goto IL_456;
											}
										}
										else
										{
											GUI.DrawTexture(new Rect((float)125 + num2, (float)110 + num3, (float)6, (float)6), this.z0ZciANDYkj);
											if (130927 - 169940 != -39013)
											{
												goto IL_456;
											}
										}
									}
								}
								IL_78A:
								i++;
								if (279458 - 181840 != 97618)
								{
									goto IL_456;
								}
							}
							if (268297 - 487329 != -219031)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060073AE RID: 29614 RVA: 0x00FAA66C File Offset: 0x00FA886C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitScoreBar()
	{
		if (250629 - 185699 != 64931)
		{
		}
		for (;;)
		{
			this.kyBcDxfZTdp = (Texture)Resources.Load("GameGui/GameWindow/scoreBar/Mana", typeof(Texture));
			if (289507 - 498448 == -208941)
			{
				this.fgFcDT8TMIK = (Texture)Resources.Load("GameGui/GameWindow/scoreBar/Score", typeof(Texture));
				if (269360 - 181119 != 88242)
				{
					this.gQucDYrQXIe = (Texture)Resources.Load("GameGui/GameWindow/scoreBar/Time", typeof(Texture));
					if (96723 - 232414 == -135691)
					{
						this.llbcD3F635X = (Texture)Resources.Load("GameGui/GameWindow/scoreBar/AdvanceMode", typeof(Texture));
						if (278411 - 568002 != -289590)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060073AF RID: 29615 RVA: 0x00FAA788 File Offset: 0x00FA8988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderScoreBar()
	{
		if (247863 - 252067 != -4204)
		{
		}
		for (;;)
		{
			int num = 0;
			if (229988 - 5648 != 224341)
			{
				int fipcivWhRLF = this.FipcivWhRLF;
				if (138995 - 449753 != -310757)
				{
					if (fipcivWhRLF == 1)
					{
						if (30569 - 332105 != -301536)
						{
							continue;
						}
						num = (int)Mathf.SmoothStep((float)100, (float)0, (float)2 * (Time.time - this.Xd9cil9WnGp));
						if (231199 - 258538 == -27338)
						{
							continue;
						}
					}
					else if (fipcivWhRLF == 2)
					{
						if (8319 - 345632 == -337312)
						{
							continue;
						}
						num = 0;
						if (31631 - 487702 != -456071)
						{
							continue;
						}
					}
					else if (fipcivWhRLF == 3)
					{
						if (282921 - 10580 != 272341)
						{
							continue;
						}
						num = (int)Mathf.SmoothStep((float)0, (float)100, (float)2 * (Time.time - this.Xd9cil9WnGp));
						if (98025 - 473843 == -375817)
						{
							continue;
						}
					}
					else if (fipcivWhRLF == 4)
					{
						if (11957 - 279525 != -267568)
						{
							continue;
						}
						num = 0;
						if (2079 - 402946 != -400867)
						{
							continue;
						}
					}
					int num2 = 0;
					if (76699 - 268769 == -192070)
					{
						int nNum = 0;
						if (66321 - 532318 == -465997)
						{
							if (Game.mGameTime != (float)0)
							{
								if (172847 - 252183 != -79336)
								{
									continue;
								}
								num2 = Mathf.Abs(Mathf.FloorToInt(Time.time - Game.mGameTime));
								if (165194 - 542978 == -377783)
								{
									continue;
								}
								nNum = global::Math.div((float)num2, (float)60);
								if (85622 - 299317 == -213694)
								{
									continue;
								}
								num2 %= 60;
								if (53738 - 542506 != -488768)
								{
									continue;
								}
							}
							GUI.BeginGroup(new Rect((float)300, (float)(0 - num), (float)640, (float)100));
							if (113068 - 354870 != -241801)
							{
								GUI.DrawTexture(new Rect((float)0, (float)10, (float)57, (float)19), this.kyBcDxfZTdp);
								if (15933 - 330511 == -314578)
								{
									Guix.renderGoldenNumber(115, 8, Game.mGameMana, false);
									if (142220 - 412664 != -270443)
									{
										GUI.DrawTexture(new Rect((float)150, (float)10, (float)56, (float)19), this.fgFcDT8TMIK);
										if (263230 - 290923 != -27692)
										{
											Guix.renderGoldenNumber(270, 8, Game.mGameScore, false);
											if (131637 - 255336 != -123698)
											{
												GUI.DrawTexture(new Rect((float)300, (float)10, (float)128, (float)19), this.gQucDYrQXIe);
												if (151025 - 202596 != -51570)
												{
													Guix.renderGoldenNumber(388, 8, nNum, false);
													if (195085 - 93527 == 101558)
													{
														Guix.renderGoldenNumber(422, 8, num2, false);
														if (23172 - 267487 == -244315)
														{
															if (num2 < 10)
															{
																if (126540 - 171620 == -45079)
																{
																	continue;
																}
																Guix.renderGoldenNumber(410, 8, 0, true);
																if (94892 - 529545 == -434652)
																{
																	continue;
																}
															}
															if (Game.useAdvanceMode)
															{
																if (207696 - 104539 == 103158)
																{
																	continue;
																}
																if (Game.mGameType == 5)
																{
																	if (137010 - 61539 == 75472)
																	{
																		continue;
																	}
																	GUI.DrawTexture(new Rect((float)455, (float)0, (float)180, (float)36), this.llbcD3F635X);
																	if (76409 - 239485 != -163076)
																	{
																		continue;
																	}
																}
															}
															GUI.EndGroup();
															if (163374 - 201289 != -37914)
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

	// Token: 0x060073B0 RID: 29616 RVA: 0x00FAAC80 File Offset: 0x00FA8E80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitTargetBar()
	{
		if (225870 - 80782 != 145089)
		{
		}
		for (;;)
		{
			this.lswcDsnV9L6 = (Texture)Resources.Load("GameGui/Icons/TargetAvatar/Plants/Carron", typeof(Texture));
			if (236908 - 588343 == -351435)
			{
				this.nuscDHQMU6o = (Texture)Resources.Load("GameGui/GameWindow/targetBar/BG", typeof(Texture));
				if (201764 - 105768 != 95997)
				{
					this.eHncD7O4Py4 = (Texture)Resources.Load("GameGui/GameWindow/targetBar/HP1", typeof(Texture));
					if (280480 - 83096 == 197384)
					{
						this.UjqcDZwOoCc = (Texture)Resources.Load("GameGui/GameWindow/targetBar/HP2", typeof(Texture));
						if (49474 - 289805 != -240330)
						{
							this.qoGcDCBm632 = (Texture)Resources.Load("GameGui/GameWindow/targetBar/HP3", typeof(Texture));
							if (18609 - 365107 == -346498)
							{
								this.WuicDMI9PSi = (Texture)Resources.Load("GameGui/GameWindow/targetBar/MHP1", typeof(Texture));
								if (207742 - 423226 == -215484)
								{
									this.okPcDffEos3 = (Texture)Resources.Load("GameGui/GameWindow/targetBar/MHP2", typeof(Texture));
									if (110535 - 450495 != -339959)
									{
										this.jKscDLKvc2B = (Texture)Resources.Load("GameGui/GameWindow/targetBar/MHP3", typeof(Texture));
										if (70054 - 569394 == -499340)
										{
											this.Ii0cDw9Ki6B = (Texture)Resources.Load("GameGui/GameWindow/targetBar/MHP4", typeof(Texture));
											if (80143 - 158234 == -78091)
											{
												this.VlRcDNiguDW = "self";
												if (276280 - 419159 != -142878)
												{
													this.rrMcDESWlC2 = string.Empty;
													if (224053 - 166319 == 57734)
													{
														this.iI3cDPmuoH6 = 0;
														if (21149 - 92510 != -71360)
														{
															this.UiScDSXMANZ = 122;
															if (5456 - 279902 == -274446)
															{
																this.fnvcDB8qRY9 = 122;
																if (166590 - 475905 == -309315)
																{
																	this.QhpcD87DGw5 = new GUIStyle();
																	if (79772 - 321793 == -242021)
																	{
																		this.QhpcD87DGw5.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
																		if (33281 - 479492 != -446210)
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

	// Token: 0x060073B1 RID: 29617 RVA: 0x00FAAFCC File Offset: 0x00FA91CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderTargetBar()
	{
		if (281900 - 231170 != 50731)
		{
		}
		for (;;)
		{
			IL_B32:
			if (!this.targetObject)
			{
				if (20649 - 337794 != -317144)
				{
					break;
				}
			}
			else
			{
				int num = 0;
				if (235625 - 109064 == 126561)
				{
					int fipcivWhRLF = this.FipcivWhRLF;
					if (99242 - 48214 == 51028)
					{
						if (fipcivWhRLF == 1)
						{
							if (298908 - 498652 == -199743)
							{
								continue;
							}
							num = (int)Mathf.SmoothStep((float)300, (float)0, (float)2 * (Time.time - this.Xd9cil9WnGp));
							if (60386 - 151507 == -91120)
							{
								continue;
							}
						}
						else if (fipcivWhRLF == 2)
						{
							if (122840 - 240494 != -117654)
							{
								continue;
							}
							num = 0;
							if (154909 - 287969 == -133059)
							{
								continue;
							}
						}
						else if (fipcivWhRLF == 3)
						{
							if (268002 - 529920 != -261918)
							{
								continue;
							}
							num = (int)Mathf.SmoothStep((float)0, (float)300, (float)2 * (Time.time - this.Xd9cil9WnGp));
							if (275814 - 372342 == -96527)
							{
								continue;
							}
						}
						else
						{
							if (fipcivWhRLF != 4)
							{
								break;
							}
							if (47217 - 91527 != -44310)
							{
								continue;
							}
							num = 0;
							if (84087 - 133420 == -49332)
							{
								continue;
							}
						}
						GUI.BeginGroup(new Rect((float)0, (float)(0 - num), this.E4Bci1kE8y4, (float)300));
						if (156527 - 476143 != -319615)
						{
							CharacterControl characterControl = (CharacterControl)this.targetObject.GetComponent(typeof(CharacterControl));
							if (245966 - 512660 == -266694)
							{
								if (!characterControl)
								{
									if (240373 - 144874 != 95500)
									{
										break;
									}
								}
								else
								{
									int num2 = (int)this.E4Bci1kE8y4;
									if (176449 - 396735 != -220285)
									{
										this.uFgcDUXpACW = this.targetObject;
										if (68085 - 80640 != -12554)
										{
											this.rrMcDESWlC2 = characterControl.Name;
											if (131205 - 358739 == -227534)
											{
												if (Game.mPlayer == this.uFgcDUXpACW)
												{
													if (137286 - 394261 != -256975)
													{
														continue;
													}
													this.VlRcDNiguDW = "Self";
													if (12729 - 174619 == -161889)
													{
														continue;
													}
												}
												else if (this.uFgcDUXpACW.tag == "NPC")
												{
													if (30556 - 580792 == -550235)
													{
														continue;
													}
													this.VlRcDNiguDW = "NPC";
													if (124837 - 546614 != -421777)
													{
														continue;
													}
												}
												else if (this.uFgcDUXpACW.layer == this.mPlayer.layer)
												{
													if (53755 - 297235 == -243479)
													{
														continue;
													}
													this.VlRcDNiguDW = "Ally";
													if (60683 - 543636 == -482952)
													{
														continue;
													}
												}
												else
												{
													this.VlRcDNiguDW = "Enemy";
													if (194288 - 494723 == -300434)
													{
														continue;
													}
												}
												if (this.uFgcDUXpACW.tag == "Player")
												{
													if (121669 - 347672 != -226003)
													{
														continue;
													}
													if (PlayerData.isBuddy(characterControl.ownerID))
													{
														if (90968 - 418708 != -327740)
														{
															continue;
														}
														this.o0pcD0eBA8d = true;
														if (113097 - 107979 != 5118)
														{
															continue;
														}
													}
													else
													{
														this.o0pcD0eBA8d = false;
														if (236224 - 439564 != -203340)
														{
															continue;
														}
													}
												}
												if (characterControl.mTargetAvartar)
												{
													if (224534 - 544221 == -319686)
													{
														continue;
													}
													this.lswcDsnV9L6 = characterControl.mTargetAvartar;
													if (22246 - 295084 == -272837)
													{
														continue;
													}
												}
												if (characterControl.mhp > 99999)
												{
													if (124612 - 390111 == -265498)
													{
														continue;
													}
													this.fnvcDB8qRY9 = 610;
													if (279049 - 122974 != 156075)
													{
														continue;
													}
												}
												else if (characterControl.mhp > 9999)
												{
													if (155934 - 339866 == -183931)
													{
														continue;
													}
													this.fnvcDB8qRY9 = 366 + Mathf.CeilToInt(0.00244f * (float)characterControl.mhp);
													if (116972 - 237418 == -120445)
													{
														continue;
													}
												}
												else if (characterControl.mhp > 999)
												{
													if (123634 - 306688 != -183054)
													{
														continue;
													}
													this.fnvcDB8qRY9 = 244 + Mathf.CeilToInt(0.0122f * (float)characterControl.mhp);
													if (68649 - 190038 != -121389)
													{
														continue;
													}
												}
												else if (characterControl.mhp > 99)
												{
													if (217290 - 92288 == 125003)
													{
														continue;
													}
													this.fnvcDB8qRY9 = 122 + Mathf.CeilToInt(0.122f * (float)characterControl.mhp);
													if (97683 - 429454 != -331771)
													{
														continue;
													}
												}
												else
												{
													this.fnvcDB8qRY9 = 122;
													if (61306 - 441403 != -380097)
													{
														continue;
													}
												}
												GUI.DrawTexture(new Rect((float)(num2 - 137), (float)0, (float)138, (float)128), this.lswcDsnV9L6);
												if (26579 - 393492 == -366913)
												{
													GUI.DrawTexture(new Rect((float)(num2 - 293), (float)0, (float)293, (float)143), this.nuscDHQMU6o);
													if (9554 - 253737 == -244183)
													{
														GUI.DrawTexture(new Rect((float)(num2 - 156 - this.fnvcDB8qRY9), (float)57, (float)13, (float)24), this.WuicDMI9PSi);
														if (12407 - 140076 == -127669)
														{
															GUI.DrawTexture(new Rect((float)(num2 - 143 - this.fnvcDB8qRY9), (float)57, (float)this.fnvcDB8qRY9, (float)24), this.okPcDffEos3);
															if (204508 - 53214 != 151295)
															{
																GUI.DrawTexture(new Rect((float)(num2 - 143), (float)57, (float)13, (float)24), this.jKscDLKvc2B);
																if (167693 - 141662 != 26032)
																{
																	int num3 = 0;
																	if (194529 - 533025 == -338496)
																	{
																		IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(characterControl.mStatusList);
																		if (216560 - 525370 != -308809)
																		{
																			while (enumerator.MoveNext())
																			{
																				object obj = enumerator.Current;
																				object obj3;
																				object obj2 = obj3 = obj;
																				if (!(obj2 is statusClass))
																				{
																					obj3 = RuntimeServices.Coerce(obj2, typeof(statusClass));
																				}
																				statusClass statusClass = (statusClass)obj3;
																				if (98503 - 333086 == -234582)
																				{
																					goto IL_B32;
																				}
																				if (num3 < 12)
																				{
																					if (61734 - 48235 == 13500)
																					{
																						goto IL_B32;
																					}
																					if (statusClass.sIcon)
																					{
																						if (147871 - 140184 == 7688)
																						{
																							goto IL_B32;
																						}
																						GUI.DrawTexture(new Rect((float)(num2 - 180 - 26 * num3), (float)8, (float)24, (float)24), statusClass.sIcon);
																						if (209523 - 423544 != -214021)
																						{
																							goto IL_B32;
																						}
																						UnityRuntimeServices.Update(enumerator, statusClass);
																						if (249750 - 149044 != 100706)
																						{
																							goto IL_B32;
																						}
																						Rect rect = new Rect((float)(num2 - 180 - 26 * num3), (float)8, (float)24, (float)24);
																						if (67155 - 62053 == 5103)
																						{
																							goto IL_B32;
																						}
																						if (rect.Contains(this.j5rcirg1OTi))
																						{
																							if (41309 - 243770 != -202461)
																							{
																								goto IL_B32;
																							}
																							this.csociPaX4Qi.alignment = TextAnchor.MiddleRight;
																							if (72768 - 66874 != 5894)
																							{
																								goto IL_B32;
																							}
																							GUI.Label(new Rect((float)(num2 - 385), (float)80, (float)240, (float)30), statusClass.sType + string.Empty + statusClass.sLv + " / " + Mathf.CeilToInt(statusClass.sTime - Time.time) + "sec", this.csociPaX4Qi);
																							if (37782 - 514577 == -476794)
																							{
																								goto IL_B32;
																							}
																							UnityRuntimeServices.Update(enumerator, statusClass);
																							if (162143 - 168517 != -6374)
																							{
																								goto IL_B32;
																							}
																						}
																						num3++;
																						if (238403 - 388703 != -150300)
																						{
																							goto IL_B32;
																						}
																					}
																				}
																			}
																			if (173054 - 510623 == -337569)
																			{
																				string vlRcDNiguDW = this.VlRcDNiguDW;
																				if (6477 - 573190 == -566713)
																				{
																					if (vlRcDNiguDW == "Self")
																					{
																						if (107303 - 243394 != -136091)
																						{
																							continue;
																						}
																						this.QhpcD87DGw5.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																						if (228909 - 71218 != 157691)
																						{
																							continue;
																						}
																					}
																					else if (vlRcDNiguDW == "Ally")
																					{
																						if (269848 - 325405 != -55557)
																						{
																							continue;
																						}
																						this.QhpcD87DGw5.normal.textColor = new Color(0.96f, 0.85f, 0.5f, (float)1);
																						if (54952 - 530388 != -475436)
																						{
																							continue;
																						}
																					}
																					else if (vlRcDNiguDW == "Enemy")
																					{
																						if (186218 - 349668 != -163450)
																						{
																							continue;
																						}
																						this.QhpcD87DGw5.normal.textColor = new Color(0.87f, 0.4f, 0.4f, (float)1);
																						if (76848 - 373182 == -296333)
																						{
																							continue;
																						}
																					}
																					else if (vlRcDNiguDW == "NPC")
																					{
																						if (181449 - 162980 != 18469)
																						{
																							continue;
																						}
																						this.QhpcD87DGw5.normal.textColor = new Color(0.28f, 0.67f, 0.64f, (float)1);
																						if (46032 - 34358 == 11675)
																						{
																							continue;
																						}
																					}
																					this.QhpcD87DGw5.alignment = TextAnchor.MiddleRight;
																					if (135289 - 249973 != -114683)
																					{
																						Guix.renderTextOutline(new Rect((float)(num2 - 400), (float)25, (float)250, (float)40), this.rrMcDESWlC2, this.QhpcD87DGw5);
																						if (219713 - 217873 != 1841)
																						{
																							this.QhpcD87DGw5.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																							if (8768 - 198805 != -190036)
																							{
																								GUI.Label(new Rect((float)(num2 - 400), (float)25, (float)250, (float)40), this.rrMcDESWlC2, this.QhpcD87DGw5);
																								if (244375 - 26317 == 218058)
																								{
																									if (characterControl.hp > 0)
																									{
																										if (55788 - 438002 != -382214)
																										{
																											continue;
																										}
																										if (this.iI3cDPmuoH6 != characterControl.hp)
																										{
																											if (242743 - 131423 == 111321)
																											{
																												continue;
																											}
																											this.iI3cDPmuoH6 = characterControl.hp;
																											if (216102 - 206132 != 9970)
																											{
																												continue;
																											}
																											this.UiScDSXMANZ = Mathf.RoundToInt((float)(this.fnvcDB8qRY9 * characterControl.hp / characterControl.mhp));
																											if (95650 - 401628 != -305978)
																											{
																												continue;
																											}
																										}
																										if (characterControl.hp == characterControl.mhp)
																										{
																											if (243617 - 242412 == 1206)
																											{
																												continue;
																											}
																											GUI.DrawTexture(new Rect((float)(num2 - 150 - this.fnvcDB8qRY9), (float)62, (float)7, (float)15), this.eHncD7O4Py4);
																											if (168487 - 209046 == -40558)
																											{
																												continue;
																											}
																										}
																										GUI.DrawTexture(new Rect((float)(num2 - 143 - this.UiScDSXMANZ), (float)62, (float)this.UiScDSXMANZ, (float)15), this.UjqcDZwOoCc);
																										if (126334 - 489905 == -363570)
																										{
																											continue;
																										}
																										GUI.DrawTexture(new Rect((float)(num2 - 143), (float)62, (float)7, (float)15), this.qoGcDCBm632);
																										if (275928 - 570931 == -295002)
																										{
																											continue;
																										}
																										GUI.DrawTexture(new Rect((float)(num2 - 150 - this.fnvcDB8qRY9), (float)57, (float)50, (float)26), this.Ii0cDw9Ki6B);
																										if (228423 - 306144 == -77720)
																										{
																											continue;
																										}
																										this.QhpcD87DGw5.alignment = TextAnchor.MiddleLeft;
																										if (285115 - 261625 != 23490)
																										{
																											continue;
																										}
																										this.QhpcD87DGw5.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																										if (204048 - 133373 == 70676)
																										{
																											continue;
																										}
																										Guix.renderTextOutline(new Rect((float)(num2 - 95 - this.fnvcDB8qRY9), (float)50, (float)200, (float)36), characterControl.hp + "/" + characterControl.mhp, this.QhpcD87DGw5);
																										if (176103 - 450314 == -274210)
																										{
																											continue;
																										}
																										this.QhpcD87DGw5.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																										if (288745 - 193579 != 95166)
																										{
																											continue;
																										}
																										GUI.Label(new Rect((float)(num2 - 95 - this.fnvcDB8qRY9), (float)50, (float)200, (float)36), characterControl.hp + "/" + characterControl.mhp, this.QhpcD87DGw5);
																										if (209197 - 260019 != -50822)
																										{
																											continue;
																										}
																									}
																									else
																									{
																										GUI.DrawTexture(new Rect((float)(num2 - 150 - this.fnvcDB8qRY9), (float)55, (float)48, (float)28), this.Ii0cDw9Ki6B);
																										if (185855 - 119681 != 66174)
																										{
																											continue;
																										}
																										this.QhpcD87DGw5.alignment = TextAnchor.MiddleLeft;
																										if (274738 - 420852 != -146114)
																										{
																											continue;
																										}
																										this.QhpcD87DGw5.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																										if (242436 - 394260 == -151823)
																										{
																											continue;
																										}
																										Guix.renderTextOutline(new Rect((float)(num2 - 105 - this.fnvcDB8qRY9), (float)50, (float)200, (float)36), "dead", this.QhpcD87DGw5);
																										if (222145 - 287292 != -65147)
																										{
																											continue;
																										}
																										this.QhpcD87DGw5.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																										if (76339 - 299245 == -222905)
																										{
																											continue;
																										}
																										GUI.Label(new Rect((float)(num2 - 105 - this.fnvcDB8qRY9), (float)50, (float)200, (float)36), "dead", this.QhpcD87DGw5);
																										if (53083 - 171151 != -118068)
																										{
																											continue;
																										}
																									}
																									GUI.EndGroup();
																									if (285662 - 446081 != -160418)
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
		}
	}

	// Token: 0x060073B2 RID: 29618 RVA: 0x00FAC21C File Offset: 0x00FAA41C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitTeamBar()
	{
		if (26075 - 523611 != -497535)
		{
		}
		for (;;)
		{
			if (Game.mGameType <= 4)
			{
				if (33196 - 23016 == 10180)
				{
					break;
				}
			}
			else
			{
				this.dyJcDFkFgYi = new CharacterControl[5];
				if (288253 - 280965 == 7288)
				{
					this.PxXcDAKyQA0 = new Texture[5];
					if (135271 - 169393 == -34122)
					{
						this.PLNcDiDE49N = new GUIStyle();
						if (238273 - 478360 != -240086)
						{
							this.PLNcDiDE49N.font = (Font)Resources.Load("GameGui/Fonts/Berlin18", typeof(Font));
							if (120937 - 114027 == 6910)
							{
								this.PLNcDiDE49N.alignment = TextAnchor.MiddleLeft;
								if (154683 - 292466 != -137782)
								{
									this.nQScDDgECln = new GUIStyle();
									if (40361 - 210429 != -170067)
									{
										this.nQScDDgECln.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/teamBar/TeamBar_Button", typeof(Texture)));
										if (293773 - 190240 != 103534)
										{
											this.o03cDme4W6s = (Texture)Resources.Load("GameGui/GameWindow/teamBar/TeamBar_BG", typeof(Texture));
											if (244999 - 205155 != 39845)
											{
												this.qONcDjp5icx = (Texture)Resources.Load("GameGui/GameWindow/teamBar/TeamBar_HP", typeof(Texture));
												if (134476 - 85349 != 49128)
												{
													this.kLjcDo0vB2H = (Texture)Resources.Load("GameGui/GameWindow/teamBar/TeamBar_Top", typeof(Texture));
													if (64786 - 150027 != -85240)
													{
														this.txccDkYeRlh = (Texture)Resources.Load("GameGui/GameWindow/teamBar/TeamBar_Hit", typeof(Texture));
														if (59810 - 151912 != -92101)
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

	// Token: 0x060073B3 RID: 29619 RVA: 0x00FAC4A4 File Offset: 0x00FAA6A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetTeamBar()
	{
		if (256418 - 161354 != 95064)
		{
		}
		IL_40:
		while (Game.mPlayer)
		{
			if (287472 - 193675 != 93798)
			{
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (280575 - 227491 == 53084)
				{
					if (Game.mGameType == 99)
					{
						if (225821 - 178124 != 47698)
						{
							break;
						}
					}
					else
					{
						this.dyJcDFkFgYi = new CharacterControl[5];
						if (204551 - 576238 == -371687)
						{
							this.PxXcDAKyQA0 = new Texture[5];
							if (168207 - 164242 != 3966)
							{
								GameObject mTransformer = Game.mPlayer;
								if (274477 - 111481 != 162997)
								{
									CharacterControl characterControl = (CharacterControl)mTransformer.GetComponent(typeof(CharacterControl));
									if (237309 - 532540 == -295231)
									{
										if (characterControl.isTransform)
										{
											if (135749 - 413700 == -277950)
											{
												continue;
											}
											if (characterControl.mTransformer != null)
											{
												if (205825 - 250783 != -44958)
												{
													continue;
												}
												mTransformer = characterControl.mTransformer;
												if (119491 - 493176 != -373685)
												{
													continue;
												}
											}
										}
										Transform parent = mTransformer.transform.parent;
										if (109924 - 305189 == -195265)
										{
											MissionClass data = MissionData.getData(Game.mGameCode);
											if (258624 - 552859 != -294234)
											{
												int playerSlot = Game.getPlayerSlot(PlayerData.UID);
												if (1643 - 205912 == -204269)
												{
													int num = 0;
													if (113888 - 205845 == -91957)
													{
														IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(parent);
														if (106021 - 153002 == -46981)
														{
															while (enumerator.MoveNext())
															{
																object obj = enumerator.Current;
																object obj3;
																object obj2 = obj3 = obj;
																if (!(obj2 is Transform))
																{
																	obj3 = RuntimeServices.Coerce(obj2, typeof(Transform));
																}
																Transform transform = (Transform)obj3;
																if (31861 - 314750 != -282889)
																{
																	goto IL_40;
																}
																if (transform.tag == "Player")
																{
																	if (57504 - 397630 != -340126)
																	{
																		goto IL_40;
																	}
																	if (transform != mTransformer.transform)
																	{
																		if (130183 - 484875 == -354691)
																		{
																			goto IL_40;
																		}
																		CharacterControl characterControl2 = (CharacterControl)transform.GetComponent(typeof(CharacterControl));
																		if (173990 - 181621 == -7630)
																		{
																			goto IL_40;
																		}
																		UnityRuntimeServices.Update(enumerator, transform);
																		if (51126 - 282750 != -231624)
																		{
																			goto IL_40;
																		}
																		if (characterControl2)
																		{
																			if (45313 - 26183 != 19130)
																			{
																				goto IL_40;
																			}
																			int playerSlot2 = Game.getPlayerSlot(characterControl2.ownerID);
																			if (169598 - 528174 == -358575)
																			{
																				goto IL_40;
																			}
																			if (playerSlot2 != 0)
																			{
																				if (238821 - 337961 != -99140)
																				{
																					goto IL_40;
																				}
																				if (global::Math.div((float)Mathf.Abs(playerSlot - playerSlot2), (float)data.team) < 6)
																				{
																					if (154520 - 42961 != 111559)
																					{
																						goto IL_40;
																					}
																					if (num < 5)
																					{
																						if (35417 - 151647 == -116229)
																						{
																							goto IL_40;
																						}
																						this.dyJcDFkFgYi[num] = characterControl2;
																						if (78583 - 351295 != -272712)
																						{
																							goto IL_40;
																						}
																						this.PxXcDAKyQA0[num] = (Texture)Resources.Load("GameGui/Icons/Heroes/" + characterControl2.Type + Mathf.FloorToInt((float)(characterControl2.Skin / 100)), typeof(Texture));
																						if (149142 - 174829 == -25686)
																						{
																							goto IL_40;
																						}
																						num++;
																						if (54799 - 277983 != -223184)
																						{
																							goto IL_40;
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
															if (85744 - 297220 == -211476)
															{
																return;
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

	// Token: 0x060073B4 RID: 29620 RVA: 0x00FAC9A0 File Offset: 0x00FAABA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderTeamBar()
	{
		if (273667 - 329085 != -55417)
		{
		}
		IL_95:
		while (this.mPlayer)
		{
			if (218950 - 244667 == -25717)
			{
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (13953 - 9863 == 4090)
				{
					if (Game.mGameType == 99)
					{
						if (93665 - 13201 != 80465)
						{
							break;
						}
					}
					else
					{
						int num = 0;
						if (253748 - 588603 == -334855)
						{
							int fipcivWhRLF = this.FipcivWhRLF;
							if (124095 - 570727 == -446632)
							{
								if (fipcivWhRLF == 1)
								{
									if (24069 - 197422 == -173352)
									{
										continue;
									}
									num = (int)Mathf.SmoothStep((float)350, (float)0, (float)2 * (Time.time - this.Xd9cil9WnGp));
									if (234370 - 305794 != -71424)
									{
										continue;
									}
								}
								else if (fipcivWhRLF == 2)
								{
									if (110251 - 225787 == -115535)
									{
										continue;
									}
									num = 0;
									if (54748 - 503771 == -449022)
									{
										continue;
									}
								}
								else if (fipcivWhRLF == 3)
								{
									if (186652 - 262692 == -76039)
									{
										continue;
									}
									num = (int)Mathf.SmoothStep((float)0, (float)350, (float)2 * (Time.time - this.Xd9cil9WnGp));
									if (63971 - 370353 == -306381)
									{
										continue;
									}
								}
								else
								{
									if (fipcivWhRLF != 4)
									{
										break;
									}
									if (193242 - 86335 == 106908)
									{
										continue;
									}
									num = 0;
									if (289565 - 239608 != 49957)
									{
										continue;
									}
								}
								int num2 = 0;
								if (251323 - 534512 != -283189)
								{
									continue;
								}
								int i = 0;
								if (249169 - 414551 == -165381)
								{
									continue;
								}
								while (i < 5)
								{
									if (this.dyJcDFkFgYi[i])
									{
										if (115307 - 170847 == -55539)
										{
											goto IL_95;
										}
										num2++;
										if (151438 - 469518 != -318080)
										{
											goto IL_95;
										}
										GUI.BeginGroup(new Rect((float)(15 - num), (float)(150 + num2 * 90), (float)180, (float)100));
										if (54483 - 293886 != -239403)
										{
											goto IL_95;
										}
										if (this.PxXcDAKyQA0[i])
										{
											if (109318 - 307346 == -198027)
											{
												goto IL_95;
											}
											GUI.DrawTexture(new Rect((float)5, (float)10, (float)75, (float)75), this.PxXcDAKyQA0[i]);
											if (51208 - 113163 != -61955)
											{
												goto IL_95;
											}
										}
										CharacterControl characterControl = this.dyJcDFkFgYi[i];
										if (78917 - 592549 != -513632)
										{
											goto IL_95;
										}
										if (characterControl.mTransformChar != null)
										{
											if (9083 - 586150 != -577067)
											{
												goto IL_95;
											}
											characterControl = characterControl.mTransformChar;
											if (12312 - 35970 != -23658)
											{
												goto IL_95;
											}
										}
										if (characterControl.myDamage != 0)
										{
											if (249154 - 494848 == -245693)
											{
												goto IL_95;
											}
											GUI.DrawTexture(new Rect((float)5, (float)10, (float)75, (float)75), this.txccDkYeRlh);
											if (175469 - 385895 == -210425)
											{
												goto IL_95;
											}
										}
										GUI.DrawTexture(new Rect((float)0, (float)0, (float)177, (float)89), this.o03cDme4W6s);
										if (220790 - 580182 == -359391)
										{
											goto IL_95;
										}
										if (characterControl.hp > 0)
										{
											if (176649 - 247391 == -70741)
											{
												goto IL_95;
											}
											GUI.DrawTexture(new Rect((float)82, (float)38, (float)Mathf.FloorToInt((float)(92 * characterControl.hp / characterControl.mhp)), (float)12), this.qONcDjp5icx);
											if (199785 - 490964 != -291179)
											{
												goto IL_95;
											}
										}
										GUI.DrawTexture(new Rect((float)79, (float)35, (float)35, (float)20), this.kLjcDo0vB2H);
										if (131246 - 61314 != 69932)
										{
											goto IL_95;
										}
										this.PLNcDiDE49N.normal.textColor = new Color(0.24f, 0.24f, 0.24f, (float)1);
										if (36658 - 322990 == -286331)
										{
											goto IL_95;
										}
										Guix.renderTextOutline(new Rect((float)91, (float)10, (float)100, (float)30), characterControl.Name, this.PLNcDiDE49N);
										if (108099 - 371 != 107728)
										{
											goto IL_95;
										}
										if (characterControl.hp > 0)
										{
											if (263761 - 169314 != 94447)
											{
												goto IL_95;
											}
											Guix.renderTextOutline(new Rect((float)112, (float)35, (float)120, (float)30), characterControl.hp + "/" + characterControl.mhp, this.PLNcDiDE49N);
											if (154064 - 598663 == -444598)
											{
												goto IL_95;
											}
										}
										else
										{
											Guix.renderTextOutline(new Rect((float)112, (float)35, (float)120, (float)30), "dead", this.PLNcDiDE49N);
											if (58787 - 37483 == 21305)
											{
												goto IL_95;
											}
										}
										this.PLNcDiDE49N.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
										if (219802 - 508957 != -289155)
										{
											goto IL_95;
										}
										GUI.Label(new Rect((float)91, (float)10, (float)100, (float)30), characterControl.Name, this.PLNcDiDE49N);
										if (55952 - 37510 == 18443)
										{
											goto IL_95;
										}
										if (characterControl.hp > 0)
										{
											if (3314 - 513344 != -510030)
											{
												goto IL_95;
											}
											GUI.Label(new Rect((float)112, (float)35, (float)120, (float)30), characterControl.hp + "/" + characterControl.mhp, this.PLNcDiDE49N);
											if (223348 - 70108 != 153240)
											{
												goto IL_95;
											}
										}
										else
										{
											GUI.Label(new Rect((float)112, (float)35, (float)120, (float)30), "dead", this.PLNcDiDE49N);
											if (227908 - 460534 != -232626)
											{
												goto IL_95;
											}
										}
										if (GUI.Button(new Rect((float)5, (float)10, (float)75, (float)75), string.Empty, this.nQScDDgECln))
										{
											if (56296 - 98401 != -42105)
											{
												goto IL_95;
											}
											GameObject gameObject = characterControl.gameObject;
											if (296856 - 367283 == -70426)
											{
												goto IL_95;
											}
											if (gameObject)
											{
												if (142868 - 37287 == 105582)
												{
													goto IL_95;
												}
												if (this.FipcivWhRLF == 4)
												{
													if (165550 - 388496 == -222945)
													{
														goto IL_95;
													}
													if (this.mCam)
													{
														if (105283 - 594286 != -489003)
														{
															goto IL_95;
														}
														if (gameObject != this.mCam.target)
														{
															if (100257 - 414039 == -313781)
															{
																goto IL_95;
															}
															this.mCam.target = gameObject;
															if (171921 - 399087 == -227165)
															{
																goto IL_95;
															}
														}
														else if (Game.mPlayer)
														{
															if (171597 - 393402 == -221804)
															{
																goto IL_95;
															}
															this.mCam.target = Game.mPlayer;
															if (201952 - 187694 == 14259)
															{
																goto IL_95;
															}
														}
													}
												}
												else if (global::Math.isOnScreen(gameObject))
												{
													if (218441 - 443457 == -225015)
													{
														goto IL_95;
													}
													Vector3 vector = global::Math.vFlat(this.mPlayer.transform.position - gameObject.transform.position);
													if (179895 - 63723 == 116173)
													{
														goto IL_95;
													}
													float sqrMagnitude = vector.sqrMagnitude;
													if (20311 - 366033 == -345721)
													{
														goto IL_95;
													}
													if (sqrMagnitude < (float)1225)
													{
														if (295537 - 159649 == 135889)
														{
															goto IL_95;
														}
														this.targetObject = gameObject;
														if (48031 - 218787 != -170756)
														{
															goto IL_95;
														}
													}
													else
													{
														this.newGameMessage("Target is too far");
														if (118896 - 396664 != -277768)
														{
															goto IL_95;
														}
													}
												}
												else
												{
													this.newGameMessage("Target is off screen");
													if (2510 - 479035 == -476524)
													{
														goto IL_95;
													}
												}
											}
										}
										GUI.EndGroup();
										if (208765 - 345894 != -137129)
										{
											goto IL_95;
										}
									}
									i++;
									if (34832 - 308986 == -274153)
									{
										goto IL_95;
									}
								}
								if (167754 - 206904 != -39150)
								{
									continue;
								}
								return;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060073B5 RID: 29621 RVA: 0x00FAD43C File Offset: 0x00FAB63C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitCharacterBar()
	{
		if (272017 - 279640 != -7622)
		{
		}
		for (;;)
		{
			this.VkecDWtJtut = new GUIStyle();
			if (8755 - 53822 != -45066)
			{
				this.VkecDWtJtut.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/CharacterBar/avartar_h", typeof(Texture)));
				if (206566 - 270881 == -64315)
				{
					this.v98cDuPOIeq = new GUIStyle();
					if (26817 - 332961 == -306144)
					{
						this.v98cDuPOIeq.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
						if (65734 - 144205 != -78470)
						{
							this.v98cDuPOIeq.alignment = TextAnchor.MiddleLeft;
							if (156266 - 7676 != 148591)
							{
								this.anlcDyqCLQ9 = (Texture)Resources.Load("GameGui/GameWindow/CharacterBar/BG", typeof(Texture));
								if (75053 - 30539 != 44515)
								{
									this.kwGcDVj1ZAb = (Texture)Resources.Load("GameGui/GameWindow/CharacterBar/Box", typeof(Texture));
									if (14858 - 38914 != -24055)
									{
										this.g85cDhuF6DZ = (Texture)Resources.Load("GameGui/GameWindow/CharacterBar/Top", typeof(Texture));
										if (135150 - 40539 != 94612)
										{
											this.QlCcDKMYlBw = (Texture)Resources.Load("GameGui/GameWindow/CharacterBar/HP", typeof(Texture));
											if (13319 - 508937 == -495618)
											{
												this.k5lcDztQHaI = (Texture)Resources.Load("GameGui/GameWindow/CharacterBar/SP", typeof(Texture));
												if (205714 - 173208 == 32506)
												{
													this.dy3cm59VQd5 = (Texture)Resources.Load("GameGui/GameWindow/CharacterBar/MP", typeof(Texture));
													if (185126 - 237726 == -52600)
													{
														this.w2hcmchtYkH = (Texture)Resources.Load("GameGui/GameWindow/CharacterBar/Gem1", typeof(Texture));
														if (271970 - 447998 != -176027)
														{
															this.KC6cmnFGbiY = (Texture)Resources.Load("GameGui/GameWindow/CharacterBar/Gem2", typeof(Texture));
															if (88872 - 11762 == 77110)
															{
																this.KA8cmQ4MO03 = (Texture)Resources.Load("GameGui/GameWindow/CharacterBar/Gem3", typeof(Texture));
																if (72637 - 459137 == -386500)
																{
																	this.xWqcmePKr1Y = (Texture)Resources.Load("GameGui/GameWindow/CharacterBar/Gem4", typeof(Texture));
																	if (247160 - 116899 == 130261)
																	{
																		this.DT8cmIiFSAw = (Texture)Resources.Load("GameGui/GameWindow/CharacterBar/Gem5", typeof(Texture));
																		if (265697 - 280047 == -14350)
																		{
																			this.GJscmJykWxu = (Texture)Resources.Load("GameGui/GameWindow/CharacterBar/Gem6", typeof(Texture));
																			if (126200 - 219291 != -93090)
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

	// Token: 0x060073B6 RID: 29622 RVA: 0x00FAD818 File Offset: 0x00FABA18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetCharacterBar(string cType)
	{
		this.HN2cD9tBaEb = (Texture)Resources.Load("GameGui/Icons/PlayerAvatar/avatar_" + cType, typeof(Texture));
	}

	// Token: 0x060073B7 RID: 29623 RVA: 0x00FAD840 File Offset: 0x00FABA40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderCharacterBar()
	{
		if (98196 - 68083 != 30114)
		{
		}
		for (;;)
		{
			IL_7F4:
			int num = 0;
			if (240434 - 460458 != -220023)
			{
				int fipcivWhRLF = this.FipcivWhRLF;
				if (168015 - 69361 == 98654)
				{
					if (fipcivWhRLF == 1)
					{
						if (38785 - 199086 == -160300)
						{
							continue;
						}
						num = (int)Mathf.SmoothStep((float)300, (float)0, (float)2 * (Time.time - this.Xd9cil9WnGp));
						if (58161 - 503144 != -444983)
						{
							continue;
						}
					}
					else if (fipcivWhRLF == 2)
					{
						if (208034 - 330801 == -122766)
						{
							continue;
						}
						int num2;
						if (Time.time < 0.5f)
						{
							if (263407 - 299466 == -36058)
							{
								continue;
							}
							num2 = (int)Mathf.SmoothStep((float)300, (float)0, (float)2 * Time.time);
						}
						else
						{
							num2 = (int)((float)0);
						}
						num = num2;
						if (147534 - 405699 != -258165)
						{
							continue;
						}
					}
					else if (fipcivWhRLF == 3)
					{
						if (212368 - 532803 != -320435)
						{
							continue;
						}
						num = (int)Mathf.SmoothStep((float)0, (float)300, (float)2 * (Time.time - this.Xd9cil9WnGp));
						if (261520 - 410409 != -148889)
						{
							continue;
						}
					}
					else
					{
						if (fipcivWhRLF != 4)
						{
							break;
						}
						if (71802 - 404205 != -332403)
						{
							continue;
						}
						num = (int)Mathf.SmoothStep((float)0, (float)300, (float)2 * Time.time);
						if (147087 - 255166 != -108079)
						{
							continue;
						}
					}
					GUI.BeginGroup(new Rect((float)0, (float)(724 + num), (float)450, (float)300));
					if (212658 - 501745 != -289086)
					{
						GUI.DrawTexture(new Rect((float)0, (float)29, (float)284, (float)271), this.anlcDyqCLQ9);
						if (210439 - 468316 != -257876)
						{
							if (GUI.Button(new Rect((float)0, (float)98, (float)203, (float)202), string.Empty, this.VkecDWtJtut))
							{
								if (192186 - 322022 != -129836)
								{
									continue;
								}
								if (Game.mPlayer)
								{
									if (172887 - 482711 != -309824)
									{
										continue;
									}
									this.targetObject = Game.mPlayer;
									if (84045 - 550471 == -466425)
									{
										continue;
									}
									this.audio.PlayOneShot(this.WtZciCJbEVG);
									if (288754 - 263830 != 24924)
									{
										continue;
									}
								}
							}
							if (this.mChar.myCommand == "cAttack1")
							{
								if (232445 - 26027 == 206419)
								{
									continue;
								}
								this.gOqcm6GwVHp = (int)global::Math.mod((float)Mathf.RoundToInt((float)10 * (Time.time - this.mChar.actionTime)), (float)7);
								if (252461 - 458282 != -205821)
								{
									continue;
								}
							}
							else
							{
								this.gOqcm6GwVHp = 0;
								if (178424 - 126898 == 51527)
								{
									continue;
								}
							}
							if (this.gOqcm6GwVHp > 0)
							{
								if (295985 - 259869 != 36116)
								{
									continue;
								}
								int num3 = this.gOqcm6GwVHp;
								if (260053 - 433420 == -173366)
								{
									continue;
								}
								if (num3 == 6)
								{
									if (148522 - 559816 != -411294)
									{
										continue;
									}
									GUI.DrawTexture(new Rect((float)177, (float)99, (float)41, (float)41), this.GJscmJykWxu);
									if (213103 - 77256 != 135848)
									{
										goto IL_10AC;
									}
									continue;
								}
								else if (num3 == 5)
								{
									if (195658 - 511867 != -316208)
									{
										goto IL_10AC;
									}
									continue;
								}
								else if (num3 == 4)
								{
									if (114637 - 562107 != -447470)
									{
										continue;
									}
									goto IL_404;
								}
								else if (num3 == 3)
								{
									if (278317 - 501697 != -223380)
									{
										continue;
									}
									goto IL_D19;
								}
								else if (num3 == 2)
								{
									if (16779 - 189989 != -173210)
									{
										continue;
									}
									goto IL_CE3;
								}
								else
								{
									if (num3 != 1)
									{
										goto IL_C8D;
									}
									if (67693 - 288668 == -220974)
									{
										continue;
									}
								}
								IL_530:
								GUI.DrawTexture(new Rect((float)17, (float)60, (float)20, (float)21), this.w2hcmchtYkH);
								if (195200 - 302987 != -107787)
								{
									continue;
								}
								goto IL_C8D;
								IL_CE3:
								GUI.DrawTexture(new Rect((float)42, (float)53, (float)23, (float)24), this.KC6cmnFGbiY);
								if (234304 - 161927 != 72377)
								{
									continue;
								}
								goto IL_530;
								IL_D19:
								GUI.DrawTexture(new Rect((float)74, (float)51, (float)27, (float)29), this.KA8cmQ4MO03);
								if (121615 - 265679 != -144064)
								{
									continue;
								}
								goto IL_CE3;
								IL_404:
								GUI.DrawTexture(new Rect((float)110, (float)56, (float)30, (float)31), this.xWqcmePKr1Y);
								if (95568 - 391373 != -295805)
								{
									continue;
								}
								goto IL_D19;
								IL_10AC:
								GUI.DrawTexture(new Rect((float)145, (float)71, (float)36, (float)36), this.DT8cmIiFSAw);
								if (32604 - 34899 != -2294)
								{
									goto IL_404;
								}
								continue;
							}
							IL_C8D:
							GUI.DrawTexture(new Rect((float)0, (float)(300 - this.HN2cD9tBaEb.height), (float)this.HN2cD9tBaEb.width, (float)this.HN2cD9tBaEb.height), this.HN2cD9tBaEb);
							if (27191 - 81996 == -54805)
							{
								GUI.DrawTexture(new Rect((float)184, (float)218, (float)165, (float)58), this.kwGcDVj1ZAb);
								if (10106 - 302282 == -292176)
								{
									if (this.mChar.hp > 0)
									{
										if (260761 - 96462 == 164300)
										{
											continue;
										}
										GUI.BeginGroup(new Rect((float)197, (float)227, (float)Mathf.FloorToInt((float)(142 * this.mChar.hp / this.mChar.mhp)), (float)15));
										if (238241 - 124684 == 113558)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)0, (float)0, (float)142, (float)15), this.QlCcDKMYlBw);
										if (285599 - 217168 == 68432)
										{
											continue;
										}
										GUI.EndGroup();
										if (105999 - 60549 != 45450)
										{
											continue;
										}
									}
									if (this.mChar.mp > 0)
									{
										if (248617 - 40680 == 207938)
										{
											continue;
										}
										GUI.BeginGroup(new Rect((float)192, (float)252, (float)Mathf.FloorToInt((float)(69 * this.mChar.mp / this.mChar.mmp)), (float)15));
										if (118545 - 328000 != -209455)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)0, (float)0, (float)69, (float)15), this.dy3cm59VQd5);
										if (15374 - 104806 == -89431)
										{
											continue;
										}
										GUI.EndGroup();
										if (39508 - 507085 == -467576)
										{
											continue;
										}
									}
									if (this.mChar.sp > 0)
									{
										if (30770 - 329717 == -298946)
										{
											continue;
										}
										GUI.BeginGroup(new Rect((float)264, (float)252, (float)Mathf.FloorToInt((float)(68 * this.mChar.sp / 100)), (float)15));
										if (72426 - 94428 != -22002)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)0, (float)0, (float)68, (float)15), this.k5lcDztQHaI);
										if (283671 - 376789 != -93118)
										{
											continue;
										}
										GUI.EndGroup();
										if (237128 - 449916 != -212788)
										{
											continue;
										}
									}
									GUI.DrawTexture(new Rect((float)192, (float)221, (float)145, (float)56), this.g85cDhuF6DZ);
									if (262330 - 509483 != -247152)
									{
										this.v98cDuPOIeq.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
										if (78224 - 162196 == -83972)
										{
											GUI.Label(new Rect((float)234, (float)190, (float)200, (float)40), this.mChar.Name, this.v98cDuPOIeq);
											if (70094 - 287726 == -217632)
											{
												GUI.Label(new Rect((float)236, (float)190, (float)200, (float)40), this.mChar.Name, this.v98cDuPOIeq);
												if (172734 - 102392 == 70342)
												{
													GUI.Label(new Rect((float)234, (float)192, (float)200, (float)40), this.mChar.Name, this.v98cDuPOIeq);
													if (121128 - 465473 != -344344)
													{
														GUI.Label(new Rect((float)236, (float)192, (float)200, (float)40), this.mChar.Name, this.v98cDuPOIeq);
														if (178109 - 52758 != 125352)
														{
															GUI.Label(new Rect((float)250, (float)215, (float)200, (float)40), this.mChar.hp + "/" + this.mChar.mhp, this.v98cDuPOIeq);
															if (225198 - 419125 != -193926)
															{
																GUI.Label(new Rect((float)252, (float)215, (float)200, (float)40), this.mChar.hp + "/" + this.mChar.mhp, this.v98cDuPOIeq);
																if (78430 - 509057 == -430627)
																{
																	GUI.Label(new Rect((float)250, (float)217, (float)200, (float)40), this.mChar.hp + "/" + this.mChar.mhp, this.v98cDuPOIeq);
																	if (135492 - 211098 == -75606)
																	{
																		GUI.Label(new Rect((float)252, (float)217, (float)200, (float)40), this.mChar.hp + "/" + this.mChar.mhp, this.v98cDuPOIeq);
																		if (161005 - 30644 != 130362)
																		{
																			GUI.Label(new Rect((float)230, (float)240, (float)100, (float)40), string.Empty + this.mChar.mp, this.v98cDuPOIeq);
																			if (197575 - 4943 == 192632)
																			{
																				GUI.Label(new Rect((float)232, (float)240, (float)100, (float)40), string.Empty + this.mChar.mp, this.v98cDuPOIeq);
																				if (293775 - 362702 == -68927)
																				{
																					GUI.Label(new Rect((float)230, (float)242, (float)100, (float)40), string.Empty + this.mChar.mp, this.v98cDuPOIeq);
																					if (244849 - 401732 != -156882)
																					{
																						GUI.Label(new Rect((float)232, (float)242, (float)100, (float)40), string.Empty + this.mChar.mp, this.v98cDuPOIeq);
																						if (98489 - 10069 != 88421)
																						{
																							GUI.Label(new Rect((float)290, (float)240, (float)100, (float)40), string.Empty + this.mChar.sp, this.v98cDuPOIeq);
																							if (59487 - 144669 == -85182)
																							{
																								GUI.Label(new Rect((float)292, (float)240, (float)100, (float)40), string.Empty + this.mChar.sp, this.v98cDuPOIeq);
																								if (109555 - 280001 != -170445)
																								{
																									GUI.Label(new Rect((float)290, (float)242, (float)100, (float)40), string.Empty + this.mChar.sp, this.v98cDuPOIeq);
																									if (251168 - 258378 == -7210)
																									{
																										GUI.Label(new Rect((float)292, (float)242, (float)100, (float)40), string.Empty + this.mChar.sp, this.v98cDuPOIeq);
																										if (175704 - 542360 == -366656)
																										{
																											this.v98cDuPOIeq.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																											if (111485 - 415022 != -303536)
																											{
																												GUI.Label(new Rect((float)235, (float)191, (float)200, (float)40), this.mChar.Name, this.v98cDuPOIeq);
																												if (112862 - 103788 != 9075)
																												{
																													GUI.Label(new Rect((float)251, (float)216, (float)200, (float)40), this.mChar.hp + "/" + this.mChar.mhp, this.v98cDuPOIeq);
																													if (298514 - 540755 != -242240)
																													{
																														GUI.Label(new Rect((float)231, (float)241, (float)100, (float)40), string.Empty + this.mChar.mp, this.v98cDuPOIeq);
																														if (151670 - 386907 == -235237)
																														{
																															GUI.Label(new Rect((float)291, (float)241, (float)100, (float)40), string.Empty + this.mChar.sp, this.v98cDuPOIeq);
																															if (259884 - 122742 == 137142)
																															{
																																int num4 = 0;
																																if (33172 - 535573 != -502400)
																																{
																																	IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.mChar.mStatusList);
																																	if (211681 - 519924 != -308242)
																																	{
																																		while (enumerator.MoveNext())
																																		{
																																			object obj = enumerator.Current;
																																			object obj3;
																																			object obj2 = obj3 = obj;
																																			if (!(obj2 is statusClass))
																																			{
																																				obj3 = RuntimeServices.Coerce(obj2, typeof(statusClass));
																																			}
																																			statusClass statusClass = (statusClass)obj3;
																																			if (196858 - 3163 == 193696)
																																			{
																																				goto IL_7F4;
																																			}
																																			if (num4 < 12)
																																			{
																																				if (151897 - 460750 == -308852)
																																				{
																																					goto IL_7F4;
																																				}
																																				if (statusClass.sIcon)
																																				{
																																					if (13228 - 283380 == -270151)
																																					{
																																						goto IL_7F4;
																																					}
																																					GUI.DrawTexture(new Rect((float)(250 + 34 * num4), (float)161, (float)32, (float)32), statusClass.sIcon);
																																					if (28834 - 216340 == -187505)
																																					{
																																						goto IL_7F4;
																																					}
																																					UnityRuntimeServices.Update(enumerator, statusClass);
																																					if (168849 - 191103 == -22253)
																																					{
																																						goto IL_7F4;
																																					}
																																					Rect rect = new Rect((float)(250 + 34 * num4), (float)(724 + num + 161), (float)32, (float)32);
																																					if (254055 - 536786 == -282730)
																																					{
																																						goto IL_7F4;
																																					}
																																					if (rect.Contains(this.j5rcirg1OTi))
																																					{
																																						if (230821 - 161864 != 68957)
																																						{
																																							goto IL_7F4;
																																						}
																																						this.csociPaX4Qi.alignment = TextAnchor.MiddleLeft;
																																						if (148866 - 12096 != 136770)
																																						{
																																							goto IL_7F4;
																																						}
																																						GUI.Label(new Rect((float)240, (float)269, (float)240, (float)30), statusClass.sType + string.Empty + statusClass.sLv + " / " + Mathf.CeilToInt(statusClass.sTime - Time.time) + "sec", this.csociPaX4Qi);
																																						if (11860 - 130008 == -118147)
																																						{
																																							goto IL_7F4;
																																						}
																																						UnityRuntimeServices.Update(enumerator, statusClass);
																																						if (51724 - 489898 == -438173)
																																						{
																																							goto IL_7F4;
																																						}
																																					}
																																					num4++;
																																					if (142376 - 186341 == -43964)
																																					{
																																						goto IL_7F4;
																																					}
																																				}
																																			}
																																		}
																																		if (249042 - 206624 == 42418)
																																		{
																																			GUI.EndGroup();
																																			if (196192 - 194191 != 2002)
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

	// Token: 0x060073B8 RID: 29624 RVA: 0x00FAEC30 File Offset: 0x00FACE30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGameMessage()
	{
		if (170101 - 365507 != -195405)
		{
		}
		for (;;)
		{
			this.VvhcmOignPu = new GUIStyle();
			if (268694 - 179556 == 89138)
			{
				this.VvhcmOignPu.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
				if (214923 - 64226 != 150698)
				{
					this.VvhcmOignPu.normal.textColor = new Color(0.8f, 0.2f, 0.1f, 0.8f);
					if (211231 - 127484 == 83747)
					{
						this.VvhcmOignPu.alignment = TextAnchor.MiddleCenter;
						if (172990 - 88910 != 84081)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060073B9 RID: 29625 RVA: 0x00FAED34 File Offset: 0x00FACF34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderGameMessege()
	{
		if (245685 - 246249 != -563)
		{
		}
		for (;;)
		{
			if (this.IeqcmaEdRXM)
			{
				if (156516 - 233361 == -76845)
				{
					break;
				}
			}
			else if (Event.current.type != EventType.Repaint)
			{
				if (270479 - 72039 == 198440)
				{
					break;
				}
			}
			else
			{
				if (this.UNvcmXkrOrB + (float)2 <= Time.time)
				{
					break;
				}
				if (255143 - 167526 == 87617)
				{
					GUI.Label(new Rect(0.5f * (this.E4Bci1kE8y4 - (float)500), (float)260, (float)500, (float)40), this.yYrcmtal1De, this.VvhcmOignPu);
					if (258678 - 480769 == -222091)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060073BA RID: 29626 RVA: 0x00FAEE44 File Offset: 0x00FAD044
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void newGameMessage(string Message)
	{
		if (233946 - 307258 != -73311)
		{
		}
		while (PlayerPrefs.GetInt("smessage", 1) != 0)
		{
			if (78919 - 352810 != -273890)
			{
				this.yYrcmtal1De = Message;
				if (194355 - 87968 == 106387)
				{
					this.UNvcmXkrOrB = Time.time;
					if (201763 - 461073 == -259310)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060073BB RID: 29627 RVA: 0x00FAEEEC File Offset: 0x00FAD0EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNoticeBar()
	{
		if (59468 - 554189 != -494720)
		{
		}
		for (;;)
		{
			this.cqLcmlfHA28 = new GUIStyle();
			if (195597 - 253622 == -58025)
			{
				this.cqLcmlfHA28.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
				if (145681 - 369377 != -223695)
				{
					this.cqLcmlfHA28.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
					if (110684 - 392524 != -281839)
					{
						this.cqLcmlfHA28.alignment = TextAnchor.MiddleCenter;
						if (135508 - 427516 == -292008)
						{
							this.Uo2cmGSwZ7d = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
							if (91170 - 104849 == -13679)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060073BC RID: 29628 RVA: 0x00FAF028 File Offset: 0x00FAD228
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNoticeBar()
	{
		if (183455 - 448222 != -264767)
		{
		}
		for (;;)
		{
			if (this.IeqcmaEdRXM)
			{
				if (19689 - 546618 != -526928)
				{
					break;
				}
			}
			else if (Event.current.type != EventType.Repaint)
			{
				if (149109 - 14393 == 134716)
				{
					break;
				}
			}
			else
			{
				if (this.tT9cmv6DBnA + (float)2 <= Time.time)
				{
					break;
				}
				if (121810 - 571524 != -449713)
				{
					GUI.DrawTexture(new Rect(0.5f * this.E4Bci1kE8y4 - (float)220, (float)540, (float)475, (float)102), this.Uo2cmGSwZ7d);
					if (288247 - 68854 == 219393)
					{
						GUI.Label(new Rect(0.5f * this.E4Bci1kE8y4 - (float)200, (float)570, (float)400, (float)40), this.hQycm2UUMhn, this.cqLcmlfHA28);
						if (219145 - 325094 != -105948)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060073BD RID: 29629 RVA: 0x00FAF184 File Offset: 0x00FAD384
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void newNoticeBar(string Notice)
	{
		this.hQycm2UUMhn = Notice;
		this.tT9cmv6DBnA = Time.time;
	}

	// Token: 0x060073BE RID: 29630 RVA: 0x00FAF198 File Offset: 0x00FAD398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitChatBar()
	{
		if (295594 - 272178 != 23417)
		{
		}
		for (;;)
		{
			this.d2gcm1kx0Ib = string.Empty;
			if (82897 - 205841 == -122944)
			{
				this.oy6cmque6xf = (Texture)Resources.Load("GameGui/Common/TypeField", typeof(Texture));
				if (65300 - 357236 != -291935)
				{
					this.oHgcmp60Qkt = new GUIStyle();
					if (168702 - 264216 != -95513)
					{
						this.oHgcmp60Qkt.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
						if (195810 - 310735 == -114925)
						{
							this.qLrcmRiGnHb = new GUIStyle();
							if (209462 - 410545 != -201082)
							{
								this.qLrcmRiGnHb.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
								if (87083 - 47414 == 39669)
								{
									this.AF0cmrrT8Re = new GUIStyle();
									if (292997 - 480383 == -187386)
									{
										this.AF0cmrrT8Re.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
										if (181853 - 191107 != -9253)
										{
											this.AF0cmrrT8Re.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/chatFontBG", typeof(Texture)));
											if (115304 - 324688 != -209383)
											{
												this.pvacmxomHOD = Chat.TextColor;
												if (163935 - 484789 == -320854)
												{
													this.Cc4cmTBVW6w = Chat.SelfColor;
													if (183813 - 129493 != 54321)
													{
														this.XbycmYUoC3P = Chat.AllyColor;
														if (2879 - 176629 != -173749)
														{
															this.OD4cm3qa3cI = Chat.EnemyColor;
															if (156085 - 78210 != 77876)
															{
																this.MJvcmbTkIE8 = Chat.GuildColor;
																if (28001 - 58634 == -30633)
																{
																	this.C9ocmdiJ1YU = Chat.NPCColor;
																	if (99662 - 248787 == -149125)
																	{
																		this.JIwcmgb9E19 = Chat.SystemColor;
																		if (85287 - 153456 != -68168)
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

	// Token: 0x060073BF RID: 29631 RVA: 0x00FAF4A4 File Offset: 0x00FAD6A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderChatBar()
	{
		if (175434 - 324596 != -149162)
		{
		}
		for (;;)
		{
			IL_1502:
			if (this.FipcivWhRLF != 2)
			{
				if (217591 - 337398 == -119806)
				{
					continue;
				}
				if (this.FipcivWhRLF != 4)
				{
					if (5593 - 488811 != -483218)
					{
						continue;
					}
					break;
				}
			}
			if (!Chat.ChatActive)
			{
				if (18799 - 136400 != -117601)
				{
					continue;
				}
				if (PlayerPrefs.GetInt("display", 1) == 0)
				{
					if (287483 - 418509 != -131026)
					{
						continue;
					}
					break;
				}
			}
			Rect screenRect = new Rect(this.E4Bci1kE8y4 - (float)650, (float)((this.FipcivWhRLF != 2) ? 200 : 300), (float)600, (float)600);
			if (209089 - 475798 != -266708)
			{
				GUILayout.BeginArea(screenRect);
				if (85503 - 365089 == -279586)
				{
					GUILayout.BeginVertical(new GUILayoutOption[0]);
					if (182914 - 228310 != -45395)
					{
						GUILayout.FlexibleSpace();
						if (46716 - 20630 == 26086)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(Chat.ChatDisplay);
							if (185055 - 191922 != -6866)
							{
								while (enumerator.MoveNext())
								{
									object obj = enumerator.Current;
									object obj3;
									object obj2 = obj3 = obj;
									if (!(obj2 is ChatEntry))
									{
										obj3 = RuntimeServices.Coerce(obj2, typeof(ChatEntry));
									}
									ChatEntry chatEntry = (ChatEntry)obj3;
									if (162212 - 168521 == -6308)
									{
										goto IL_1502;
									}
									float num = Mathf.Clamp((float)30 - Time.time + chatEntry.time, (float)0, 1f);
									if (120606 - 419370 == -298763)
									{
										goto IL_1502;
									}
									UnityRuntimeServices.Update(enumerator, chatEntry);
									if (191627 - 342286 != -150659)
									{
										goto IL_1502;
									}
									if (num > (float)0)
									{
										if (179467 - 52439 == 127029)
										{
											goto IL_1502;
										}
										eChatMode mode = chatEntry.mode;
										if (212296 - 16488 != 195808)
										{
											goto IL_1502;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (72324 - 486431 != -414107)
										{
											goto IL_1502;
										}
										if (mode == eChatMode.area)
										{
											if (136592 - 570114 != -433522)
											{
												goto IL_1502;
											}
											if (Chat.showAreaChat)
											{
												if (63280 - 132588 == -69307)
												{
													goto IL_1502;
												}
												GUILayout.BeginHorizontal(new GUILayoutOption[0]);
												if (65364 - 592428 == -527063)
												{
													goto IL_1502;
												}
												GUILayout.FlexibleSpace();
												if (10210 - 16721 == -6510)
												{
													goto IL_1502;
												}
												this.qLrcmRiGnHb.normal.textColor = this.C9ocmdiJ1YU;
												if (148856 - 463166 != -314310)
												{
													goto IL_1502;
												}
												float a = num;
												if (3552 - 186091 != -182539)
												{
													goto IL_1502;
												}
												Color textColor = this.qLrcmRiGnHb.normal.textColor;
												if (88644 - 277678 == -189033)
												{
													goto IL_1502;
												}
												textColor.a = a;
												if (235559 - 391513 == -155953 || 94814 - 334445 == -239630)
												{
													goto IL_1502;
												}
												this.qLrcmRiGnHb.normal.textColor = textColor;
												if (42371 - 116862 == -74490 || 269008 - 306726 == -37717)
												{
													goto IL_1502;
												}
												GUILayout.Label("[ALL]", this.qLrcmRiGnHb, new GUILayoutOption[0]);
												if (87003 - 451122 == -364118)
												{
													goto IL_1502;
												}
												GUILayout.Space((float)5);
												if (174276 - 112055 != 62221)
												{
													goto IL_1502;
												}
												this.qLrcmRiGnHb.normal.textColor = this.Cc4cmTBVW6w;
												if (181545 - 423926 == -242380)
												{
													goto IL_1502;
												}
												float a2 = num;
												if (199360 - 251735 != -52375)
												{
													goto IL_1502;
												}
												Color textColor2 = this.qLrcmRiGnHb.normal.textColor;
												if (234609 - 350058 != -115449)
												{
													goto IL_1502;
												}
												textColor2.a = a2;
												if (138797 - 91482 != 47315)
												{
													goto IL_1502;
												}
												if (117355 - 349188 == -231832)
												{
													goto IL_1502;
												}
												Color color = this.qLrcmRiGnHb.normal.textColor = textColor2;
												if (279803 - 409339 != -129536)
												{
													goto IL_1502;
												}
												if (116676 - 403414 != -286738)
												{
													goto IL_1502;
												}
												GUILayout.Label(chatEntry.name + ":", this.qLrcmRiGnHb, new GUILayoutOption[0]);
												if (113985 - 302439 == -188453)
												{
													goto IL_1502;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (145144 - 134188 != 10956)
												{
													goto IL_1502;
												}
												this.AF0cmrrT8Re.normal.textColor = this.pvacmxomHOD;
												if (207814 - 38583 != 169231)
												{
													goto IL_1502;
												}
												float a3 = num;
												if (282793 - 558602 == -275808)
												{
													goto IL_1502;
												}
												Color textColor3 = this.AF0cmrrT8Re.normal.textColor;
												if (158162 - 597076 == -438913)
												{
													goto IL_1502;
												}
												textColor3.a = a3;
												if (100561 - 250295 != -149734)
												{
													goto IL_1502;
												}
												if (126704 - 165054 != -38350)
												{
													goto IL_1502;
												}
												Color color2 = this.AF0cmrrT8Re.normal.textColor = textColor3;
												if (72788 - 398603 == -325814)
												{
													goto IL_1502;
												}
												if (185683 - 164954 != 20729)
												{
													goto IL_1502;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.AF0cmrrT8Re, new GUILayoutOption[0]);
												if (185798 - 359158 == -173359)
												{
													goto IL_1502;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (30692 - 540824 != -510132)
												{
													goto IL_1502;
												}
												GUILayout.EndHorizontal();
												if (2129 - 369717 != -367588)
												{
													goto IL_1502;
												}
											}
										}
										else if (mode == eChatMode.party)
										{
											if (188410 - 94633 == 93778)
											{
												goto IL_1502;
											}
											if (Chat.showAreaChat)
											{
												if (14735 - 365153 == -350417)
												{
													goto IL_1502;
												}
												GUILayout.BeginHorizontal(new GUILayoutOption[0]);
												if (144778 - 525456 != -380678)
												{
													goto IL_1502;
												}
												GUILayout.FlexibleSpace();
												if (287294 - 499727 == -212432)
												{
													goto IL_1502;
												}
												this.qLrcmRiGnHb.normal.textColor = new Color(0.8f, 0.2f, 0.2f, num);
												if (108816 - 552644 != -443828)
												{
													goto IL_1502;
												}
												GUILayout.Label("[TEAM]", this.qLrcmRiGnHb, new GUILayoutOption[0]);
												if (289856 - 264452 != 25404)
												{
													goto IL_1502;
												}
												GUILayout.Space((float)5);
												if (49518 - 67162 != -17644)
												{
													goto IL_1502;
												}
												this.qLrcmRiGnHb.normal.textColor = this.Cc4cmTBVW6w;
												if (242136 - 548255 != -306119)
												{
													goto IL_1502;
												}
												float a4 = num;
												if (267097 - 503476 != -236379)
												{
													goto IL_1502;
												}
												Color textColor4 = this.qLrcmRiGnHb.normal.textColor;
												if (9388 - 318774 == -309385)
												{
													goto IL_1502;
												}
												float num2 = textColor4.a = a4;
												if (10530 - 58433 != -47903)
												{
													goto IL_1502;
												}
												if (275111 - 933 != 274178)
												{
													goto IL_1502;
												}
												this.qLrcmRiGnHb.normal.textColor = textColor4;
												if (79193 - 448601 == -369407)
												{
													goto IL_1502;
												}
												if (219517 - 207219 != 12298)
												{
													goto IL_1502;
												}
												GUILayout.Label(chatEntry.name + ":", this.qLrcmRiGnHb, new GUILayoutOption[0]);
												if (226533 - 547777 != -321244)
												{
													goto IL_1502;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (299706 - 166504 != 133202)
												{
													goto IL_1502;
												}
												this.AF0cmrrT8Re.normal.textColor = this.pvacmxomHOD;
												if (103938 - 206588 == -102649)
												{
													goto IL_1502;
												}
												float a5 = num;
												if (92436 - 361949 == -269512)
												{
													goto IL_1502;
												}
												Color textColor5 = this.AF0cmrrT8Re.normal.textColor;
												if (272069 - 409093 != -137024)
												{
													goto IL_1502;
												}
												float num3 = textColor5.a = a5;
												if (214698 - 25306 == 189393)
												{
													goto IL_1502;
												}
												if (17563 - 49190 != -31627)
												{
													goto IL_1502;
												}
												Color color3 = this.AF0cmrrT8Re.normal.textColor = textColor5;
												if (258328 - 122272 == 136057)
												{
													goto IL_1502;
												}
												if (191173 - 590596 != -399423)
												{
													goto IL_1502;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.AF0cmrrT8Re, new GUILayoutOption[0]);
												if (154321 - 117598 != 36723)
												{
													goto IL_1502;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (159404 - 273084 == -113679)
												{
													goto IL_1502;
												}
												GUILayout.EndHorizontal();
												if (238053 - 265972 == -27918)
												{
													goto IL_1502;
												}
											}
										}
										else if (mode == eChatMode.guild)
										{
											if (62735 - 533546 == -470810)
											{
												goto IL_1502;
											}
											if (Chat.showGuildChat)
											{
												if (103704 - 99782 == 3923)
												{
													goto IL_1502;
												}
												GUILayout.BeginHorizontal(new GUILayoutOption[0]);
												if (139227 - 520137 != -380910)
												{
													goto IL_1502;
												}
												GUILayout.FlexibleSpace();
												if (65783 - 137873 == -72089)
												{
													goto IL_1502;
												}
												this.qLrcmRiGnHb.normal.textColor = this.MJvcmbTkIE8;
												if (289982 - 513424 != -223442)
												{
													goto IL_1502;
												}
												float a6 = num;
												if (82620 - 106965 == -24344)
												{
													goto IL_1502;
												}
												Color textColor6 = this.qLrcmRiGnHb.normal.textColor;
												if (51721 - 255130 != -203409)
												{
													goto IL_1502;
												}
												textColor6.a = a6;
												if (40175 - 60651 == -20475)
												{
													goto IL_1502;
												}
												if (247990 - 420219 != -172229)
												{
													goto IL_1502;
												}
												Color color4 = this.qLrcmRiGnHb.normal.textColor = textColor6;
												if (10752 - 98034 != -87282)
												{
													goto IL_1502;
												}
												if (71466 - 194209 != -122743)
												{
													goto IL_1502;
												}
												GUILayout.Label("[GLD]", this.qLrcmRiGnHb, new GUILayoutOption[0]);
												if (298164 - 79880 != 218284)
												{
													goto IL_1502;
												}
												GUILayout.Space((float)5);
												if (27127 - 372679 != -345552)
												{
													goto IL_1502;
												}
												this.qLrcmRiGnHb.normal.textColor = this.Cc4cmTBVW6w;
												if (267593 - 517357 == -249763)
												{
													goto IL_1502;
												}
												float a7 = num;
												if (35597 - 149962 == -114364)
												{
													goto IL_1502;
												}
												Color textColor7 = this.qLrcmRiGnHb.normal.textColor;
												if (69723 - 93092 == -23368)
												{
													goto IL_1502;
												}
												float num4 = textColor7.a = a7;
												if (281323 - 114275 != 167048)
												{
													goto IL_1502;
												}
												if (218679 - 125755 != 92924)
												{
													goto IL_1502;
												}
												Color color5 = this.qLrcmRiGnHb.normal.textColor = textColor7;
												if (81570 - 90431 == -8860 || 157147 - 56481 == 100667)
												{
													goto IL_1502;
												}
												GUILayout.Label(chatEntry.name + ":", this.qLrcmRiGnHb, new GUILayoutOption[0]);
												if (42491 - 246595 != -204104)
												{
													goto IL_1502;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (228302 - 572799 != -344497)
												{
													goto IL_1502;
												}
												this.AF0cmrrT8Re.normal.textColor = this.MJvcmbTkIE8;
												if (158236 - 486652 == -328415)
												{
													goto IL_1502;
												}
												float a8 = num;
												if (29407 - 392173 == -362765)
												{
													goto IL_1502;
												}
												Color textColor8 = this.AF0cmrrT8Re.normal.textColor;
												if (296959 - 84869 == 212091)
												{
													goto IL_1502;
												}
												float num5 = textColor8.a = a8;
												if (123727 - 397782 == -274054 || 77960 - 335288 == -257327)
												{
													goto IL_1502;
												}
												Color color6 = this.AF0cmrrT8Re.normal.textColor = textColor8;
												if (126338 - 67104 != 59234)
												{
													goto IL_1502;
												}
												if (149140 - 256285 != -107145)
												{
													goto IL_1502;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.AF0cmrrT8Re, new GUILayoutOption[0]);
												if (802 - 218099 == -217296)
												{
													goto IL_1502;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (4399 - 284543 != -280144)
												{
													goto IL_1502;
												}
												GUILayout.EndHorizontal();
												if (186630 - 348850 == -162219)
												{
													goto IL_1502;
												}
											}
										}
										else if (mode == eChatMode.whisper)
										{
											if (258222 - 196140 != 62082)
											{
												goto IL_1502;
											}
											if (Chat.showPrivateChat)
											{
												if (113050 - 263693 == -150642)
												{
													goto IL_1502;
												}
												GUILayout.BeginHorizontal(new GUILayoutOption[0]);
												if (208401 - 38898 == 169504)
												{
													goto IL_1502;
												}
												GUILayout.FlexibleSpace();
												if (226951 - 521521 == -294569)
												{
													goto IL_1502;
												}
												this.qLrcmRiGnHb.normal.textColor = new Color(0.69f, 0.29f, 0.53f, num);
												if (49850 - 432652 == -382801)
												{
													goto IL_1502;
												}
												GUILayout.Label("[WSP]", this.qLrcmRiGnHb, new GUILayoutOption[0]);
												if (39159 - 211221 == -172061)
												{
													goto IL_1502;
												}
												GUILayout.Space((float)5);
												if (34384 - 247007 == -212622)
												{
													goto IL_1502;
												}
												this.qLrcmRiGnHb.normal.textColor = this.Cc4cmTBVW6w;
												if (104485 - 596134 != -491649)
												{
													goto IL_1502;
												}
												float a9 = num;
												if (44241 - 122193 != -77952)
												{
													goto IL_1502;
												}
												Color textColor9 = this.qLrcmRiGnHb.normal.textColor;
												if (48065 - 19227 == 28839)
												{
													goto IL_1502;
												}
												textColor9.a = a9;
												if (275242 - 531094 == -255851 || 97447 - 161432 == -63984)
												{
													goto IL_1502;
												}
												this.qLrcmRiGnHb.normal.textColor = textColor9;
												if (175188 - 584828 == -409639)
												{
													goto IL_1502;
												}
												if (232784 - 379431 != -146647)
												{
													goto IL_1502;
												}
												GUILayout.Label(chatEntry.name + ":", this.qLrcmRiGnHb, new GUILayoutOption[0]);
												if (215578 - 200843 == 14736)
												{
													goto IL_1502;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (114119 - 282582 != -168463)
												{
													goto IL_1502;
												}
												this.AF0cmrrT8Re.normal.textColor = this.pvacmxomHOD;
												if (177732 - 586941 != -409209)
												{
													goto IL_1502;
												}
												float a10 = num;
												if (181446 - 223072 == -41625)
												{
													goto IL_1502;
												}
												Color textColor10 = this.AF0cmrrT8Re.normal.textColor;
												if (91832 - 282983 != -191151)
												{
													goto IL_1502;
												}
												float num6 = textColor10.a = a10;
												if (211747 - 42846 == 168902)
												{
													goto IL_1502;
												}
												if (269237 - 503575 != -234338)
												{
													goto IL_1502;
												}
												this.AF0cmrrT8Re.normal.textColor = textColor10;
												if (200839 - 416153 != -215314)
												{
													goto IL_1502;
												}
												if (94347 - 551381 != -457034)
												{
													goto IL_1502;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.AF0cmrrT8Re, new GUILayoutOption[0]);
												if (218456 - 582008 == -363551)
												{
													goto IL_1502;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (144129 - 344066 == -199936)
												{
													goto IL_1502;
												}
												GUILayout.EndHorizontal();
												if (220662 - 98805 != 121857)
												{
													goto IL_1502;
												}
											}
										}
										else if (mode == eChatMode.system)
										{
											if (247994 - 31403 != 216591)
											{
												goto IL_1502;
											}
											if (Chat.showSystemChat)
											{
												if (48370 - 6816 == 41555)
												{
													goto IL_1502;
												}
												GUILayout.BeginHorizontal(new GUILayoutOption[0]);
												if (96785 - 185594 == -88808)
												{
													goto IL_1502;
												}
												GUILayout.FlexibleSpace();
												if (59933 - 510476 == -450542)
												{
													goto IL_1502;
												}
												this.AF0cmrrT8Re.normal.textColor = new Color(0.95f, 0.95f, 0.45f, num);
												if (81894 - 195863 != -113969)
												{
													goto IL_1502;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.AF0cmrrT8Re, new GUILayoutOption[0]);
												if (263554 - 425231 != -161677)
												{
													goto IL_1502;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (60158 - 525561 == -465402)
												{
													goto IL_1502;
												}
												GUILayout.EndHorizontal();
												if (264133 - 294776 == -30642)
												{
													goto IL_1502;
												}
											}
										}
										else if (mode == eChatMode.world)
										{
											if (183136 - 213857 == -30720)
											{
												goto IL_1502;
											}
											GUILayout.BeginHorizontal(new GUILayoutOption[0]);
											if (107996 - 578333 == -470336)
											{
												goto IL_1502;
											}
											GUILayout.FlexibleSpace();
											if (161634 - 355809 == -194174)
											{
												goto IL_1502;
											}
											this.AF0cmrrT8Re.normal.textColor = new Color(0.95f, 0.25f, 0.25f, num);
											if (96550 - 431210 == -334659)
											{
												goto IL_1502;
											}
											GUILayout.Label(chatEntry.text, this.AF0cmrrT8Re, new GUILayoutOption[0]);
											if (105196 - 55076 == 50121)
											{
												goto IL_1502;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (208372 - 481827 == -273454)
											{
												goto IL_1502;
											}
											GUILayout.EndHorizontal();
											if (253912 - 47309 == 206604)
											{
												goto IL_1502;
											}
										}
									}
								}
								if (15617 - 327291 != -311673)
								{
									GUILayout.EndVertical();
									if (43791 - 425154 == -381363)
									{
										GUILayout.EndArea();
										if (153204 - 199485 != -46280)
										{
											if (!Chat.ChatActive)
											{
												break;
											}
											if (261830 - 444493 == -182663)
											{
												bool flag = true;
												if (188322 - 40813 != 147510)
												{
													GUI.DrawTexture(new Rect(0.5f * this.E4Bci1kE8y4 - (float)157, (float)700, (float)335, (float)33), this.oy6cmque6xf);
													if (167177 - 412521 == -245344)
													{
														if (Input.GetKeyDown(KeyCode.UpArrow))
														{
															if (99596 - 374549 == -274953)
															{
																this.d2gcm1kx0Ib = Chat.switchChatModeUp(this.d2gcm1kx0Ib);
																if (204374 - 46346 != 158029)
																{
																	break;
																}
															}
														}
														else if (Input.GetKeyDown(KeyCode.DownArrow))
														{
															if (118712 - 584884 == -466172)
															{
																this.d2gcm1kx0Ib = Chat.switchChatModeDown(this.d2gcm1kx0Ib);
																if (84498 - 160080 == -75582)
																{
																	break;
																}
															}
														}
														else
														{
															if (Event.current.type == EventType.KeyDown)
															{
																if (223818 - 108780 != 115038)
																{
																	continue;
																}
																if (Event.current.character == "\n")
																{
																	if (11501 - 207611 == -196109)
																	{
																		continue;
																	}
																	string[] array = (string[])Stringf.splitToArray(this.d2gcm1kx0Ib, " ").ToBuiltin(typeof(string));
																	if (276054 - 243446 == 32609)
																	{
																		continue;
																	}
																	if (Extensions.get_length(array) > 0)
																	{
																		if (12848 - 244418 != -231570)
																		{
																			continue;
																		}
																		string a11 = array[0];
																		if (91208 - 563161 != -471953)
																		{
																			continue;
																		}
																		if (a11 == "/a")
																		{
																			if (62642 - 521216 != -458574)
																			{
																				continue;
																			}
																			Chat.ChatMode = 1;
																			if (69556 - 403085 == -333528)
																			{
																				continue;
																			}
																			this.d2gcm1kx0Ib = Stringf.getString(this.d2gcm1kx0Ib, 2, Extensions.get_length(this.d2gcm1kx0Ib));
																			if (136977 - 359645 == -222667)
																			{
																				continue;
																			}
																		}
																		else if (a11 == "/g")
																		{
																			if (203193 - 458815 != -255622)
																			{
																				continue;
																			}
																			if (!RuntimeServices.EqualityOperator(PlayerData.GID, "none"))
																			{
																				if (17655 - 300539 != -282884)
																				{
																					continue;
																				}
																				Chat.ChatMode = 2;
																				if (244300 - 207088 == 37213)
																				{
																					continue;
																				}
																				this.d2gcm1kx0Ib = Stringf.getString(this.d2gcm1kx0Ib, 2, Extensions.get_length(this.d2gcm1kx0Ib));
																				if (19619 - 1654 == 17966)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				this.newGameMessage("You are not in a guild");
																				if (296393 - 67784 != 228609)
																				{
																					continue;
																				}
																				flag = false;
																				if (262574 - 294462 != -31888)
																				{
																					continue;
																				}
																			}
																		}
																		else if (a11 == "/t")
																		{
																			if (268528 - 310767 == -42238)
																			{
																				continue;
																			}
																			if (Game.mGameType > 4)
																			{
																				if (133098 - 421064 != -287966)
																				{
																					continue;
																				}
																				Chat.ChatMode = 3;
																				if (95070 - 449594 != -354524)
																				{
																					continue;
																				}
																				this.d2gcm1kx0Ib = Stringf.getString(this.d2gcm1kx0Ib, 2, Extensions.get_length(this.d2gcm1kx0Ib));
																				if (166208 - 508323 == -342114)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				this.newGameMessage("Cannot use team chat");
																				if (247536 - 586899 != -339363)
																				{
																					continue;
																				}
																				this.d2gcm1kx0Ib = string.Empty;
																				if (218494 - 416919 == -198424)
																				{
																					continue;
																				}
																			}
																		}
																		else if (a11 == "/w")
																		{
																			if (252114 - 586407 == -334292)
																			{
																				continue;
																			}
																			Chat.ChatMode = 4;
																			if (270102 - 100595 == 169508)
																			{
																				continue;
																			}
																			this.d2gcm1kx0Ib = Stringf.getString(this.d2gcm1kx0Ib, 3, Extensions.get_length(this.d2gcm1kx0Ib));
																			if (195489 - 384608 == -189118)
																			{
																				continue;
																			}
																			if (Extensions.get_length(array) > 1)
																			{
																				if (32251 - 130464 != -98213)
																				{
																					continue;
																				}
																				int buddyID = PlayerData.getBuddyID(array[1]);
																				if (132261 - 167381 == -35119)
																				{
																					continue;
																				}
																				if (buddyID != 0)
																				{
																					if (149440 - 544113 == -394672)
																					{
																						continue;
																					}
																					Chat.TargetID = buddyID;
																					if (126531 - 139101 != -12570)
																					{
																						continue;
																					}
																					this.d2gcm1kx0Ib = Stringf.getString(this.d2gcm1kx0Ib, Extensions.get_length(array[1]) + 1, Extensions.get_length(this.d2gcm1kx0Ib));
																					if (143262 - 507257 != -363995)
																					{
																						continue;
																					}
																				}
																			}
																		}
																	}
																	if (flag)
																	{
																		if (180286 - 533597 == -353310)
																		{
																			continue;
																		}
																		if (this.d2gcm1kx0Ib.Length > 0)
																		{
																			if (121976 - 116538 == 5439)
																			{
																				continue;
																			}
																			if (Chat.ChatMode == 4)
																			{
																				if (214977 - 259886 != -44909)
																				{
																					continue;
																				}
																				if (Chat.TargetID == 0)
																				{
																					if (195264 - 309701 != -114437)
																					{
																						continue;
																					}
																					this.newGameMessage("Whisper target not found!");
																					if (84595 - 559667 != -475072)
																					{
																						continue;
																					}
																					goto IL_1D74;
																				}
																			}
																			Chat.SubmitChat(PlayerData.User, this.d2gcm1kx0Ib, eChatType.self, (eChatMode)Chat.ChatMode);
																			if (247817 - 63807 == 184011)
																			{
																				continue;
																			}
																		}
																	}
																	IL_1D74:
																	this.d2gcm1kx0Ib = string.Empty;
																	if (21936 - 5191 != 16745)
																	{
																		continue;
																	}
																	Chat.ChatTimeOut = Time.time + 0.5f;
																	if (48296 - 586772 != -538476)
																	{
																		continue;
																	}
																	Chat.ChatActive = false;
																	if (51448 - 414768 != -363319)
																	{
																		break;
																	}
																	continue;
																}
															}
															GUI.SetNextControlName("MissionChatField");
															if (29200 - 25547 == 3653)
															{
																this.d2gcm1kx0Ib = GUI.TextField(new Rect(0.5f * this.E4Bci1kE8y4 - (float)150, (float)700, (float)300, (float)30), this.d2gcm1kx0Ib, 36, this.oHgcmp60Qkt);
																if (241488 - 334425 != -92936)
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

	// Token: 0x060073C0 RID: 29632 RVA: 0x00FB1410 File Offset: 0x00FAF610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitOptionMenu()
	{
		if (251776 - 168725 != 83051)
		{
		}
		for (;;)
		{
			this.exVcmsmoBdF = (Texture)Resources.Load("GameGui/GameWindow/optionMenu/optionWindow", typeof(Texture));
			if (159017 - 362291 != -203273)
			{
				this.rS9cmHBxXH0 = (Texture)Resources.Load("GameGui/GameWindow/optionMenu/blankWindow", typeof(Texture));
				if (263461 - 543885 != -280423)
				{
					this.a0bcmUencwX = new GUIStyle();
					if (53330 - 158955 == -105625)
					{
						this.a0bcmUencwX.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/optionMenu/button_close_h", typeof(Texture)));
						if (78547 - 296806 == -218259)
						{
							this.g5lcmfbLiBj = (Texture)Resources.Load("GameGui/Common/check", typeof(Texture));
							if (247399 - 396804 == -149405)
							{
								this.MeLcmwBfXkQ = new GUIStyle();
								if (138236 - 183898 == -45662)
								{
									this.MeLcmwBfXkQ.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/checkBox", typeof(Texture)));
									if (150300 - 161428 == -11128)
									{
										this.MeLcmwBfXkQ.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/checkBox_h", typeof(Texture)));
										if (276276 - 242830 == 33446)
										{
											this.GA5cmLCtkkp = (Texture)Resources.Load("GameGui/Common/numField", typeof(Texture));
											if (142325 - 360848 != -218522)
											{
												this.IRYcm7kZrMA = new GUIStyle();
												if (187806 - 155118 != 32689)
												{
													this.IRYcm7kZrMA.font = (Font)Resources.Load("GameGui/Fonts/Century22", typeof(Font));
													if (212072 - 8947 != 203126)
													{
														this.IRYcm7kZrMA.alignment = TextAnchor.MiddleLeft;
														if (172533 - 359847 != -187313)
														{
															this.IRYcm7kZrMA.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
															if (206212 - 548156 != -341943)
															{
																this.eQKcmZ6ivL7 = new GUIStyle();
																if (196760 - 427909 != -231148)
																{
																	this.eQKcmZ6ivL7.font = (Font)Resources.Load("GameGui/Fonts/MsSansSerif18", typeof(Font));
																	if (28128 - 316463 != -288334)
																	{
																		this.eQKcmZ6ivL7.alignment = TextAnchor.MiddleLeft;
																		if (221230 - 376540 == -155310)
																		{
																			this.eQKcmZ6ivL7.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
																			if (130385 - 338702 != -208316)
																			{
																				this.eVKcmCWQXU4 = new GUIStyle();
																				if (64541 - 152627 != -88085)
																				{
																					this.eVKcmCWQXU4.font = (Font)Resources.Load("GameGui/Fonts/MsSansSerif18", typeof(Font));
																					if (21297 - 448278 == -426981)
																					{
																						this.eVKcmCWQXU4.alignment = TextAnchor.MiddleRight;
																						if (194331 - 500361 != -306029)
																						{
																							this.eVKcmCWQXU4.normal.textColor = new Color(0.23f, 0.5f, 0.14f, (float)1);
																							if (22357 - 47864 != -25506)
																							{
																								this.O9XcmM6eVgX = new GUIStyle();
																								if (207453 - 9268 != 198186)
																								{
																									this.O9XcmM6eVgX.font = (Font)Resources.Load("GameGui/Fonts/Berlin18", typeof(Font));
																									if (230871 - 155482 != 75390)
																									{
																										this.O9XcmM6eVgX.alignment = TextAnchor.MiddleCenter;
																										if (82761 - 355799 == -273038)
																										{
																											this.O9XcmM6eVgX.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
																											if (52139 - 354665 != -302525)
																											{
																												this.UGNcmNpcqQF = new GUIStyle();
																												if (11376 - 500604 != -489227)
																												{
																													this.UGNcmNpcqQF.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/optionMenu/button_main_h", typeof(Texture)));
																													if (111633 - 591078 == -479445)
																													{
																														this.hCicmE954Z3 = new GUIStyle();
																														if (180689 - 493188 == -312499)
																														{
																															this.hCicmE954Z3.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/optionMenu/button_back_h", typeof(Texture)));
																															if (201557 - 419084 == -217527)
																															{
																																this.v7xcmPN2twG = new GUIStyle();
																																if (150217 - 517550 != -367332)
																																{
																																	this.v7xcmPN2twG.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/optionMenu/button_up_h", typeof(Texture)));
																																	if (120470 - 363036 != -242565)
																																	{
																																		this.xgCcmSVAwpW = new GUIStyle();
																																		if (127939 - 232407 == -104468)
																																		{
																																			this.xgCcmSVAwpW.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/optionMenu/button_down_h", typeof(Texture)));
																																			if (224504 - 423934 == -199430)
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

	// Token: 0x060073C1 RID: 29633 RVA: 0x00FB1B28 File Offset: 0x00FAFD28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderOptionMenu()
	{
		if (162819 - 517957 != -355138)
		{
		}
		for (;;)
		{
			if (!this.IeqcmaEdRXM)
			{
				if (32722 - 44028 == -11306)
				{
					break;
				}
			}
			else
			{
				int num = this.pXycm4rLt23;
				if (106113 - 82973 != 23141)
				{
					if (num == 1)
					{
						if (238317 - 581157 != -342839)
						{
							this.RenderGameOption();
							if (200734 - 324293 == -123559)
							{
								break;
							}
						}
					}
					else if (num == 2)
					{
						if (9885 - 590423 == -580538)
						{
							this.RenderVideoOption();
							if (18534 - 290035 == -271501)
							{
								break;
							}
						}
					}
					else if (num == 3)
					{
						if (245600 - 208159 == 37441)
						{
							this.RenderSoundOption();
							if (112368 - 104213 == 8155)
							{
								break;
							}
						}
					}
					else if (num == 4)
					{
						if (154268 - 460470 == -306202)
						{
							this.RenderInterfaceOption();
							if (156367 - 86236 != 70132)
							{
								break;
							}
						}
					}
					else if (num == 5)
					{
						if (154895 - 280295 != -125399)
						{
							this.RenderWorldMapOption();
							if (164711 - 231764 != -67052)
							{
								break;
							}
						}
					}
					else if (num == 6)
					{
						if (238683 - 98172 == 140511)
						{
							this.RenderAboutOption();
							if (99921 - 577154 != -477232)
							{
								break;
							}
						}
					}
					else
					{
						this.RenderMainOption();
						if (27726 - 231905 == -204179)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060073C2 RID: 29634 RVA: 0x00FB1D74 File Offset: 0x00FAFF74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderMainOption()
	{
		if (36443 - 296199 != -259755)
		{
		}
		for (;;)
		{
			GUI.BeginGroup(new Rect(0.5f * this.E4Bci1kE8y4 - (float)236, (float)200, (float)472, (float)561));
			if (155896 - 188943 != -33046)
			{
				GUI.DrawTexture(new Rect((float)0, (float)0, (float)472, (float)561), this.exVcmsmoBdF);
				if (60036 - 580482 != -520445)
				{
					if (GUI.Button(new Rect((float)330, (float)31, (float)57, (float)52), string.Empty, this.a0bcmUencwX))
					{
						if (182618 - 265955 == -83336)
						{
							continue;
						}
						this.IeqcmaEdRXM = false;
						if (240797 - 588145 != -347348)
						{
							continue;
						}
						this.audio.PlayOneShot(this.WXJcif9Qnej);
						if (150722 - 362611 == -211888)
						{
							continue;
						}
					}
					if (GUI.Button(new Rect((float)107, (float)125, (float)255, (float)47), string.Empty, this.UGNcmNpcqQF))
					{
						if (265883 - 330930 != -65047)
						{
							continue;
						}
						this.pXycm4rLt23 = 1;
						if (235288 - 120686 != 114602)
						{
							continue;
						}
						this.audio.PlayOneShot(this.zUkciLiv9B7);
						if (242760 - 139630 == 103131)
						{
							continue;
						}
					}
					if (GUI.Button(new Rect((float)107, (float)171, (float)255, (float)47), string.Empty, this.UGNcmNpcqQF))
					{
						if (285824 - 5012 != 280812)
						{
							continue;
						}
						this.pXycm4rLt23 = 2;
						if (275349 - 82446 != 192903)
						{
							continue;
						}
						this.audio.PlayOneShot(this.zUkciLiv9B7);
						if (289136 - 385772 == -96635)
						{
							continue;
						}
					}
					if (GUI.Button(new Rect((float)107, (float)216, (float)255, (float)47), string.Empty, this.UGNcmNpcqQF))
					{
						if (228902 - 534145 != -305243)
						{
							continue;
						}
						this.pXycm4rLt23 = 3;
						if (180041 - 583455 != -403414)
						{
							continue;
						}
						this.audio.PlayOneShot(this.zUkciLiv9B7);
						if (178167 - 47901 == 130267)
						{
							continue;
						}
					}
					if (GUI.Button(new Rect((float)107, (float)262, (float)255, (float)47), string.Empty, this.UGNcmNpcqQF))
					{
						if (296816 - 105509 == 191308)
						{
							continue;
						}
						this.pXycm4rLt23 = 4;
						if (297798 - 165454 != 132344)
						{
							continue;
						}
						this.audio.PlayOneShot(this.zUkciLiv9B7);
						if (100055 - 217093 == -117037)
						{
							continue;
						}
					}
					if (GUI.Button(new Rect((float)107, (float)308, (float)255, (float)47), string.Empty, this.UGNcmNpcqQF))
					{
						if (188746 - 581674 != -392928)
						{
							continue;
						}
						this.pXycm4rLt23 = 5;
						if (152197 - 382014 != -229817)
						{
							continue;
						}
						this.audio.PlayOneShot(this.zUkciLiv9B7);
						if (47871 - 203607 == -155735)
						{
							continue;
						}
					}
					if (GUI.Button(new Rect((float)107, (float)351, (float)255, (float)47), string.Empty, this.UGNcmNpcqQF))
					{
						if (159429 - 261118 == -101688)
						{
							continue;
						}
						this.pXycm4rLt23 = 6;
						if (75435 - 353187 != -277752)
						{
							continue;
						}
						this.audio.PlayOneShot(this.zUkciLiv9B7);
						if (1090 - 435266 != -434176)
						{
							continue;
						}
					}
					if (GUI.Button(new Rect((float)107, (float)396, (float)255, (float)47), string.Empty, this.UGNcmNpcqQF))
					{
						if (233157 - 428115 != -194958)
						{
							continue;
						}
						this.audio.PlayOneShot(this.zUkciLiv9B7);
						if (298775 - 353472 != -54697)
						{
							continue;
						}
						Application.Quit();
						if (210000 - 548013 == -338012)
						{
							continue;
						}
					}
					GUI.EndGroup();
					if (58819 - 63304 == -4485)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060073C3 RID: 29635 RVA: 0x00FB22D8 File Offset: 0x00FB04D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderGameOption()
	{
		if (181343 - 111428 != 69915)
		{
		}
		for (;;)
		{
			IL_CAF:
			GUI.BeginGroup(new Rect(0.5f * this.E4Bci1kE8y4 - (float)236, (float)200, (float)472, (float)561));
			if (218854 - 509024 != -290169)
			{
				GUI.DrawTexture(new Rect((float)0, (float)0, (float)472, (float)561), this.exVcmsmoBdF);
				if (156736 - 119502 == 37234)
				{
					if (GUI.Button(new Rect((float)330, (float)31, (float)57, (float)52), string.Empty, this.a0bcmUencwX))
					{
						if (35664 - 240828 != -205164)
						{
							continue;
						}
						this.IeqcmaEdRXM = false;
						if (36727 - 285095 != -248368)
						{
							continue;
						}
						if (this.vJNci7xce9X)
						{
							if (83930 - 531470 == -447539)
							{
								continue;
							}
							this.audio.PlayOneShot(this.vJNci7xce9X);
							if (113049 - 487920 != -374871)
							{
								continue;
							}
						}
					}
					GUI.DrawTexture(new Rect((float)80, (float)108, (float)310, (float)376), this.rS9cmHBxXH0);
					if (93331 - 559225 != -465893)
					{
						GUI.Label(new Rect((float)108, (float)124, (float)300, (float)30), "Game Option", this.IRYcm7kZrMA);
						if (85181 - 84168 != 1014)
						{
							int num = 170;
							if (188454 - 246853 != -58398)
							{
								GUI.Label(new Rect((float)152, (float)num, (float)300, (float)20), "auto-aim attack <ctrl-r>", this.eQKcmZ6ivL7);
								if (2988 - 89842 != -86853)
								{
									if (GUI.Button(new Rect((float)120, (float)(num + 4), (float)22, (float)21), string.Empty, this.MeLcmwBfXkQ))
									{
										if (291906 - 366235 != -74329)
										{
											continue;
										}
										if (PlayerPrefs.GetInt("autoAim", 1) != 0)
										{
											if (144434 - 143817 == 618)
											{
												continue;
											}
											PlayerPrefs.SetInt("autoAim", 0);
											if (224911 - 459576 != -234665)
											{
												continue;
											}
										}
										else
										{
											PlayerPrefs.SetInt("autoAim", 1);
											if (8968 - 518517 == -509548)
											{
												continue;
											}
										}
										this.audio.PlayOneShot(this.zUkciLiv9B7);
										if (50856 - 53484 != -2628)
										{
											continue;
										}
									}
									if (PlayerPrefs.GetInt("autoAim", 1) != 0)
									{
										if (261590 - 510515 == -248924)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)122, (float)(num + 6), (float)16, (float)16), this.g5lcmfbLiBj);
										if (224898 - 402150 == -177251)
										{
											continue;
										}
									}
									num += 30;
									if (146870 - 334005 == -187135)
									{
										GUI.Label(new Rect((float)152, (float)num, (float)300, (float)30), "auto-aim skill <ctrl-f>", this.eQKcmZ6ivL7);
										if (94688 - 334723 == -240035)
										{
											if (GUI.Button(new Rect((float)120, (float)(num + 4), (float)22, (float)21), string.Empty, this.MeLcmwBfXkQ))
											{
												if (106003 - 257587 == -151583)
												{
													continue;
												}
												if (PlayerPrefs.GetInt("autoAimSkill", 1) != 0)
												{
													if (58075 - 479689 == -421613)
													{
														continue;
													}
													PlayerPrefs.SetInt("autoAimSkill", 0);
													if (237069 - 328644 != -91575)
													{
														continue;
													}
												}
												else
												{
													PlayerPrefs.SetInt("autoAimSkill", 1);
													if (194112 - 25728 == 168385)
													{
														continue;
													}
												}
												this.audio.PlayOneShot(this.zUkciLiv9B7);
												if (46946 - 410132 == -363185)
												{
													continue;
												}
											}
											if (PlayerPrefs.GetInt("autoAimSkill", 1) != 0)
											{
												if (294861 - 408872 == -114010)
												{
													continue;
												}
												GUI.DrawTexture(new Rect((float)122, (float)(num + 6), (float)16, (float)16), this.g5lcmfbLiBj);
												if (27534 - 16397 != 11137)
												{
													continue;
												}
											}
											num += 30;
											if (231447 - 84852 != 146596)
											{
												GUI.Label(new Rect((float)152, (float)num, (float)300, (float)30), "show message", this.eQKcmZ6ivL7);
												if (169071 - 203914 == -34843)
												{
													if (GUI.Button(new Rect((float)120, (float)(num + 4), (float)22, (float)21), string.Empty, this.MeLcmwBfXkQ))
													{
														if (139073 - 503502 != -364429)
														{
															continue;
														}
														if (PlayerPrefs.GetInt("smessage", 1) != 0)
														{
															if (199908 - 422957 != -223049)
															{
																continue;
															}
															PlayerPrefs.SetInt("smessage", 0);
															if (57590 - 107123 != -49533)
															{
																continue;
															}
														}
														else
														{
															PlayerPrefs.SetInt("smessage", 1);
															if (175869 - 301898 == -126028)
															{
																continue;
															}
														}
														this.audio.PlayOneShot(this.zUkciLiv9B7);
														if (151441 - 328478 == -177036)
														{
															continue;
														}
													}
													if (PlayerPrefs.GetInt("smessage", 1) != 0)
													{
														if (292174 - 410487 == -118312)
														{
															continue;
														}
														GUI.DrawTexture(new Rect((float)122, (float)(num + 6), (float)16, (float)16), this.g5lcmfbLiBj);
														if (262153 - 426542 == -164388)
														{
															continue;
														}
													}
													num += 30;
													if (119228 - 57717 != 61512)
													{
														GUI.Label(new Rect((float)152, (float)num, (float)300, (float)30), "show tutorial <ctrl-t>", this.eQKcmZ6ivL7);
														if (88770 - 450069 != -361298)
														{
															if (GUI.Button(new Rect((float)120, (float)(num + 4), (float)22, (float)21), string.Empty, this.MeLcmwBfXkQ))
															{
																if (184274 - 502101 != -317827)
																{
																	continue;
																}
																if (PlayerPrefs.GetInt("tutorial", 1) != 0)
																{
																	if (53962 - 171287 == -117324)
																	{
																		continue;
																	}
																	PlayerPrefs.SetInt("tutorial", 0);
																	if (286098 - 434718 == -148619)
																	{
																		continue;
																	}
																}
																else
																{
																	PlayerPrefs.SetInt("tutorial", 1);
																	if (17586 - 530183 == -512596)
																	{
																		continue;
																	}
																}
																this.audio.PlayOneShot(this.zUkciLiv9B7);
																if (172391 - 345677 != -173286)
																{
																	continue;
																}
																GameObject[] array = GameObject.FindGameObjectsWithTag("Icon");
																if (150125 - 483194 != -333069)
																{
																	continue;
																}
																int i = 0;
																if (208116 - 550444 != -342328)
																{
																	continue;
																}
																GameObject[] array2 = array;
																if (239933 - 450542 == -210608)
																{
																	continue;
																}
																int length = array2.Length;
																if (47924 - 53984 != -6060)
																{
																	continue;
																}
																while (i < length)
																{
																	TutorialIcon tutorialIcon = (TutorialIcon)array2[i].GetComponent(typeof(TutorialIcon));
																	if (178221 - 361107 == -182885)
																	{
																		goto IL_CAF;
																	}
																	if (tutorialIcon)
																	{
																		if (19271 - 78638 != -59367)
																		{
																			goto IL_CAF;
																		}
																		tutorialIcon.enabled = (PlayerPrefs.GetInt("tutorial", 1) == 1);
																		if (92594 - 490547 == -397952)
																		{
																			goto IL_CAF;
																		}
																	}
																	i++;
																	if (107863 - 35899 != 71964)
																	{
																		goto IL_CAF;
																	}
																}
																if (55506 - 103084 != -47578)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("tutorial", 1) != 0)
															{
																if (75608 - 307247 != -231639)
																{
																	continue;
																}
																GUI.DrawTexture(new Rect((float)122, (float)(num + 6), (float)16, (float)16), this.g5lcmfbLiBj);
																if (13311 - 255508 == -242196)
																{
																	continue;
																}
															}
															num += 30;
															if (4424 - 505794 != -501369)
															{
																GUI.Label(new Rect((float)152, (float)num, (float)300, (float)30), "use low angle <end>", this.eQKcmZ6ivL7);
																if (118114 - 196049 == -77935)
																{
																	if (GUI.Button(new Rect((float)120, (float)(num + 4), (float)22, (float)21), string.Empty, this.MeLcmwBfXkQ))
																	{
																		if (198088 - 357586 != -159498)
																		{
																			continue;
																		}
																		if (PlayerPrefs.GetInt("lowAngle", 0) != 0)
																		{
																			if (211230 - 201477 != 9753)
																			{
																				continue;
																			}
																			if (this.mCam)
																			{
																				if (72828 - 275422 == -202593)
																				{
																					continue;
																				}
																				this.mCam.lowAngle = false;
																				if (18172 - 68607 != -50435)
																				{
																					continue;
																				}
																			}
																			PlayerPrefs.SetInt("lowAngle", 0);
																			if (114663 - 229369 == -114705)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			if (this.mCam)
																			{
																				if (244558 - 272041 == -27482)
																				{
																					continue;
																				}
																				this.mCam.lowAngle = true;
																				if (156661 - 488181 != -331520)
																				{
																					continue;
																				}
																			}
																			PlayerPrefs.SetInt("lowAngle", 1);
																			if (15517 - 563104 == -547586)
																			{
																				continue;
																			}
																		}
																		this.audio.PlayOneShot(this.zUkciLiv9B7);
																		if (72265 - 523943 == -451677)
																		{
																			continue;
																		}
																	}
																	if (PlayerPrefs.GetInt("lowAngle", 0) != 0)
																	{
																		if (149033 - 55981 == 93053)
																		{
																			continue;
																		}
																		GUI.DrawTexture(new Rect((float)122, (float)(num + 6), (float)16, (float)16), this.g5lcmfbLiBj);
																		if (270122 - 597103 != -326981)
																		{
																			continue;
																		}
																	}
																	num += 34;
																	if (227371 - 106670 == 120701)
																	{
																		GUI.Label(new Rect((float)152, (float)num, (float)300, (float)30), "town channel:", this.eQKcmZ6ivL7);
																		if (213923 - 163376 == 50547)
																		{
																			GUI.DrawTexture(new Rect((float)300, (float)(num + 0), (float)54, (float)31), this.GA5cmLCtkkp);
																			if (232935 - 43655 != 189281)
																			{
																				string nString = GUI.TextField(new Rect((float)280, (float)num, (float)64, (float)32), string.Empty + PlayerPrefs.GetInt("channel", 0), 5, this.eVKcmCWQXU4);
																				if (127560 - 315728 == -188168)
																				{
																					int num2 = Mathf.Clamp(Stringf.getInteger(nString), 0, 99);
																					if (142364 - 463910 == -321546)
																					{
																						if (num2 != PlayerPrefs.GetInt("channel", 0))
																						{
																							if (246426 - 275490 != -29064)
																							{
																								continue;
																							}
																							PlayerPrefs.SetInt("channel", num2);
																							if (27178 - 300408 != -273230)
																							{
																								continue;
																							}
																						}
																						num += 30;
																						if (68913 - 386810 == -317897)
																						{
																							if (GUI.Button(new Rect((float)189, (float)425, (float)99, (float)40), string.Empty, this.hCicmE954Z3))
																							{
																								if (221573 - 572531 == -350957)
																								{
																									continue;
																								}
																								this.pXycm4rLt23 = 0;
																								if (149895 - 224764 == -74868)
																								{
																									continue;
																								}
																								this.audio.PlayOneShot(this.zUkciLiv9B7);
																								if (245277 - 540081 != -294804)
																								{
																									continue;
																								}
																							}
																							GUI.EndGroup();
																							if (156721 - 132262 == 24459)
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

	// Token: 0x060073C4 RID: 29636 RVA: 0x00FB312C File Offset: 0x00FB132C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderVideoOption()
	{
		if (72068 - 92679 != -20610)
		{
		}
		for (;;)
		{
			GUI.BeginGroup(new Rect(0.5f * this.E4Bci1kE8y4 - (float)236, (float)200, (float)472, (float)561));
			if (112321 - 371590 != -259268)
			{
				GUI.DrawTexture(new Rect((float)0, (float)0, (float)472, (float)561), this.exVcmsmoBdF);
				if (30231 - 304098 == -273867)
				{
					if (GUI.Button(new Rect((float)330, (float)31, (float)57, (float)52), string.Empty, this.a0bcmUencwX))
					{
						if (104679 - 78726 == 25954)
						{
							continue;
						}
						this.IeqcmaEdRXM = false;
						if (32814 - 510257 == -477442)
						{
							continue;
						}
						if (this.vJNci7xce9X)
						{
							if (217159 - 391152 == -173992)
							{
								continue;
							}
							this.audio.PlayOneShot(this.vJNci7xce9X);
							if (29411 - 514593 != -485182)
							{
								continue;
							}
						}
					}
					GUI.DrawTexture(new Rect((float)80, (float)108, (float)310, (float)376), this.rS9cmHBxXH0);
					if (246245 - 28297 != 217949)
					{
						GUI.Label(new Rect((float)108, (float)124, (float)300, (float)30), "Video Settings", this.IRYcm7kZrMA);
						if (32880 - 464061 == -431181)
						{
							string rhs = "fastest";
							if (169299 - 588949 != -419649)
							{
								string rhs2 = "none";
								if (6775 - 99023 == -92248)
								{
									string rhs3 = "off";
									if (7135 - 156726 == -149591)
									{
										int qualityLevel = QualitySettings.GetQualityLevel();
										if (170924 - 83212 != 87713)
										{
											if (qualityLevel == 1)
											{
												if (66578 - 263901 != -197323)
												{
													continue;
												}
												rhs = "fast";
												if (9799 - 414108 == -404308)
												{
													continue;
												}
												rhs2 = "none";
												if (34552 - 568265 == -533712)
												{
													continue;
												}
												rhs3 = "off";
												if (164773 - 264868 == -100094)
												{
													continue;
												}
											}
											else if (qualityLevel == 2)
											{
												if (121517 - 113659 == 7859)
												{
													continue;
												}
												rhs = "simple";
												if (28243 - 566585 == -538341)
												{
													continue;
												}
												rhs2 = "none";
												if (131438 - 390892 == -259453)
												{
													continue;
												}
												rhs3 = "simple";
												if (37415 - 91269 != -53854)
												{
													continue;
												}
											}
											else if (qualityLevel == 3)
											{
												if (77294 - 120936 != -43642)
												{
													continue;
												}
												rhs = "good";
												if (237553 - 75107 != 162446)
												{
													continue;
												}
												rhs2 = "none";
												if (19026 - 245149 != -226123)
												{
													continue;
												}
												rhs3 = "full";
												if (248309 - 77935 == 170375)
												{
													continue;
												}
											}
											else if (qualityLevel == 4)
											{
												if (96456 - 374264 != -277808)
												{
													continue;
												}
												rhs = "beautiful";
												if (43235 - 28245 != 14990)
												{
													continue;
												}
												rhs2 = "2x";
												if (232609 - 461645 != -229036)
												{
													continue;
												}
												rhs3 = "fullx2";
												if (265202 - 504510 != -239308)
												{
													continue;
												}
											}
											else if (qualityLevel == 5)
											{
												if (171257 - 5741 != 165516)
												{
													continue;
												}
												rhs = "fantastic";
												if (295350 - 267442 != 27908)
												{
													continue;
												}
												rhs2 = "4x";
												if (242120 - 266602 != -24482)
												{
													continue;
												}
												rhs3 = "fullx4";
												if (194048 - 328109 != -134061)
												{
													continue;
												}
											}
											GUI.Label(new Rect((float)120, (float)170, (float)240, (float)30), "Resolution :", this.eQKcmZ6ivL7);
											if (262440 - 473175 == -210735)
											{
												GUI.Label(new Rect((float)105, (float)170, (float)240, (float)30), string.Empty + Screen.width + "x" + Screen.height, this.eVKcmCWQXU4);
												if (145459 - 139149 == 6310)
												{
													if (GUI.Button(new Rect((float)120, (float)204, (float)22, (float)21), string.Empty, this.MeLcmwBfXkQ))
													{
														if (178880 - 538195 != -359315)
														{
															continue;
														}
														Screen.fullScreen = !Screen.fullScreen;
														if (4610 - 441271 == -436660)
														{
															continue;
														}
														this.audio.PlayOneShot(this.zUkciLiv9B7);
														if (274301 - 340126 == -65824)
														{
															continue;
														}
													}
													if (Screen.fullScreen)
													{
														if (281223 - 347577 == -66353)
														{
															continue;
														}
														GUI.DrawTexture(new Rect((float)122, (float)206, (float)16, (float)16), this.g5lcmfbLiBj);
														if (152774 - 446955 != -294181)
														{
															continue;
														}
													}
													GUI.Label(new Rect((float)152, (float)200, (float)300, (float)30), "full screen", this.eQKcmZ6ivL7);
													if (260193 - 419031 != -158837)
													{
														GUI.Label(new Rect((float)120, (float)230, (float)240, (float)30), "Graphic Quality :", this.eQKcmZ6ivL7);
														if (119767 - 585887 == -466120)
														{
															GUI.Label(new Rect((float)105, (float)230, (float)240, (float)30), string.Empty + rhs, this.eVKcmCWQXU4);
															if (119921 - 368516 != -248594)
															{
																GUI.Label(new Rect((float)120, (float)260, (float)240, (float)30), "Anti-alias :", this.eQKcmZ6ivL7);
																if (109284 - 345529 == -236245)
																{
																	GUI.Label(new Rect((float)105, (float)260, (float)240, (float)30), string.Empty + rhs2, this.eVKcmCWQXU4);
																	if (49662 - 288893 == -239231)
																	{
																		GUI.Label(new Rect((float)120, (float)290, (float)240, (float)30), "Shadow :", this.eQKcmZ6ivL7);
																		if (32155 - 130889 == -98734)
																		{
																			GUI.Label(new Rect((float)105, (float)290, (float)240, (float)30), string.Empty + rhs3, this.eVKcmCWQXU4);
																			if (124319 - 573152 != -448832)
																			{
																				GUI.Label(new Rect((float)120, (float)320, (float)240, (float)30), "Frame rate :", this.eQKcmZ6ivL7);
																				if (244476 - 25276 != 219201)
																				{
																					GUI.Label(new Rect((float)105, (float)320, (float)240, (float)30), string.Empty + this.o90ciamtGQU + " fps", this.eVKcmCWQXU4);
																					if (272398 - 484756 == -212358)
																					{
																						int num = 350;
																						if (240327 - 426788 == -186461)
																						{
																							GUI.Label(new Rect((float)152, (float)num, (float)300, (float)30), "vivid color <ctrl-v>", this.eQKcmZ6ivL7);
																							if (109505 - 118011 == -8506)
																							{
																								if (GUI.Button(new Rect((float)120, (float)(num + 4), (float)22, (float)21), string.Empty, this.MeLcmwBfXkQ))
																								{
																									if (50808 - 584940 == -534131)
																									{
																										continue;
																									}
																									CameraEffect cameraEffect = (CameraEffect)this.GetComponent(typeof(CameraEffect));
																									if (188823 - 191447 == -2623)
																									{
																										continue;
																									}
																									if (PlayerPrefs.GetInt("vividColor", 1) != 0)
																									{
																										if (140489 - 522300 == -381810)
																										{
																											continue;
																										}
																										PlayerPrefs.SetInt("vividColor", 0);
																										if (247997 - 430048 != -182051)
																										{
																											continue;
																										}
																										if (cameraEffect)
																										{
																											if (162064 - 393128 != -231064)
																											{
																												continue;
																											}
																											cameraEffect.useVividColor = false;
																											if (71341 - 548938 != -477597)
																											{
																												continue;
																											}
																										}
																									}
																									else
																									{
																										PlayerPrefs.SetInt("vividColor", 1);
																										if (194410 - 371979 != -177569)
																										{
																											continue;
																										}
																										if (cameraEffect)
																										{
																											if (297489 - 273327 != 24162)
																											{
																												continue;
																											}
																											cameraEffect.useVividColor = true;
																											if (162071 - 403016 == -240944)
																											{
																												continue;
																											}
																										}
																									}
																									this.audio.PlayOneShot(this.zUkciLiv9B7);
																									if (30766 - 585764 == -554997)
																									{
																										continue;
																									}
																								}
																								if (PlayerPrefs.GetInt("vividColor", 1) != 0)
																								{
																									if (12721 - 58462 != -45741)
																									{
																										continue;
																									}
																									GUI.DrawTexture(new Rect((float)122, (float)(num + 6), (float)16, (float)16), this.g5lcmfbLiBj);
																									if (252755 - 12183 != 240572)
																									{
																										continue;
																									}
																								}
																								num += 30;
																								if (206018 - 2547 == 203471)
																								{
																									if (GUI.Button(new Rect((float)189, (float)425, (float)99, (float)40), string.Empty, this.hCicmE954Z3))
																									{
																										if (197226 - 254668 != -57442)
																										{
																											continue;
																										}
																										this.pXycm4rLt23 = 0;
																										if (257355 - 47124 != 210231)
																										{
																											continue;
																										}
																										this.audio.PlayOneShot(this.zUkciLiv9B7);
																										if (26918 - 105406 == -78487)
																										{
																											continue;
																										}
																									}
																									GUI.EndGroup();
																									if (100229 - 303027 == -202798)
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
		}
	}

	// Token: 0x060073C5 RID: 29637 RVA: 0x00FB3D8C File Offset: 0x00FB1F8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderSoundOption()
	{
		if (294720 - 399282 != -104561)
		{
		}
		for (;;)
		{
			GUI.BeginGroup(new Rect(0.5f * this.E4Bci1kE8y4 - (float)236, (float)200, (float)472, (float)561));
			if (78900 - 181622 != -102721)
			{
				GUI.DrawTexture(new Rect((float)0, (float)0, (float)472, (float)561), this.exVcmsmoBdF);
				if (118483 - 316195 != -197711)
				{
					if (GUI.Button(new Rect((float)330, (float)31, (float)57, (float)52), string.Empty, this.a0bcmUencwX))
					{
						if (183565 - 76004 == 107562)
						{
							continue;
						}
						this.IeqcmaEdRXM = false;
						if (131260 - 472121 != -340861)
						{
							continue;
						}
						if (this.vJNci7xce9X)
						{
							if (86358 - 102773 != -16415)
							{
								continue;
							}
							this.audio.PlayOneShot(this.vJNci7xce9X);
							if (185826 - 218691 == -32864)
							{
								continue;
							}
						}
					}
					GUI.DrawTexture(new Rect((float)80, (float)108, (float)310, (float)376), this.rS9cmHBxXH0);
					if (235901 - 462166 == -226265)
					{
						GUI.Label(new Rect((float)108, (float)124, (float)300, (float)30), "Sound Settings", this.IRYcm7kZrMA);
						if (22922 - 428806 == -405884)
						{
							int num = 170;
							if (229875 - 403021 == -173146)
							{
								GUI.Label(new Rect((float)120, (float)num, (float)240, (float)30), "Sound Volume:", this.eQKcmZ6ivL7);
								if (214316 - 136768 == 77548)
								{
									GUI.Label(new Rect((float)300, (float)num, (float)30, (float)30), string.Empty + PlayerPrefs.GetInt("volume", Game.volume), this.eVKcmCWQXU4);
									if (87841 - 556126 != -468284)
									{
										if (GUI.Button(new Rect((float)340, (float)num, (float)20, (float)17), string.Empty, this.v7xcmPN2twG))
										{
											if (180450 - 286122 == -105671)
											{
												continue;
											}
											Game.volume = Mathf.Clamp(Game.volume + 1, 0, 10);
											if (294446 - 305843 != -11397)
											{
												continue;
											}
											PlayerPrefs.SetInt("volume", Game.volume);
											if (187328 - 267285 == -79956)
											{
												continue;
											}
											AudioListener.volume = Mathf.Clamp01(0.1f * (float)Game.volume);
											if (263513 - 404411 == -140897)
											{
												continue;
											}
											if (this.QdyciMZNMSM)
											{
												if (62120 - 148290 != -86170)
												{
													continue;
												}
												this.audio.PlayOneShot(this.QdyciMZNMSM);
												if (63102 - 42768 != 20334)
												{
													continue;
												}
											}
										}
										if (GUI.Button(new Rect((float)340, (float)(num + 17), (float)20, (float)17), string.Empty, this.xgCcmSVAwpW))
										{
											if (68509 - 469536 == -401026)
											{
												continue;
											}
											Game.volume = Mathf.Clamp(Game.volume - 1, 0, 10);
											if (141419 - 570162 == -428742)
											{
												continue;
											}
											PlayerPrefs.SetInt("volume", Game.volume);
											if (86123 - 219945 != -133822)
											{
												continue;
											}
											AudioListener.volume = Mathf.Clamp01(0.1f * (float)Game.volume);
											if (261690 - 281628 != -19938)
											{
												continue;
											}
											if (this.QdyciMZNMSM)
											{
												if (102633 - 564658 != -462025)
												{
													continue;
												}
												this.audio.PlayOneShot(this.QdyciMZNMSM);
												if (116394 - 341751 != -225357)
												{
													continue;
												}
											}
										}
										num += 34;
										if (290185 - 6434 != 283752)
										{
											GUI.Label(new Rect((float)120, (float)num, (float)240, (float)30), "Music Volume:", this.eQKcmZ6ivL7);
											if (166047 - 310622 != -144574)
											{
												GUI.Label(new Rect((float)300, (float)num, (float)30, (float)30), string.Empty + PlayerPrefs.GetInt("music", Game.music), this.eVKcmCWQXU4);
												if (215977 - 431728 != -215750)
												{
													if (GUI.Button(new Rect((float)340, (float)num, (float)20, (float)17), string.Empty, this.v7xcmPN2twG))
													{
														if (250398 - 12452 == 237947)
														{
															continue;
														}
														Game.music = Mathf.Clamp(Game.music + 1, 0, 10);
														if (172665 - 86009 == 86657)
														{
															continue;
														}
														PlayerPrefs.SetInt("music", Game.music);
														if (160331 - 375298 != -214967)
														{
															continue;
														}
														this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
														if (240776 - 454907 == -214130)
														{
															continue;
														}
														if (this.QdyciMZNMSM)
														{
															if (258994 - 384067 == -125072)
															{
																continue;
															}
															this.audio.PlayOneShot(this.QdyciMZNMSM);
															if (230985 - 24684 != 206301)
															{
																continue;
															}
														}
													}
													if (GUI.Button(new Rect((float)340, (float)(num + 17), (float)20, (float)17), string.Empty, this.xgCcmSVAwpW))
													{
														if (196673 - 431613 == -234939)
														{
															continue;
														}
														Game.music = Mathf.Clamp(Game.music - 1, 0, 10);
														if (241367 - 574694 != -333327)
														{
															continue;
														}
														PlayerPrefs.SetInt("music", Game.music);
														if (292800 - 319911 == -27110)
														{
															continue;
														}
														this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
														if (147071 - 216502 != -69431)
														{
															continue;
														}
														if (this.QdyciMZNMSM)
														{
															if (245147 - 409377 == -164229)
															{
																continue;
															}
															this.audio.PlayOneShot(this.QdyciMZNMSM);
															if (129479 - 128129 == 1351)
															{
																continue;
															}
														}
													}
													num += 30;
													if (88250 - 478814 == -390564)
													{
														GUI.Label(new Rect((float)152, (float)num, (float)300, (float)30), "player voice <ctrl-v>", this.eQKcmZ6ivL7);
														if (294854 - 462121 == -167267)
														{
															if (GUI.Button(new Rect((float)120, (float)(num + 4), (float)22, (float)21), string.Empty, this.MeLcmwBfXkQ))
															{
																if (108049 - 282716 == -174666)
																{
																	continue;
																}
																if (PlayerPrefs.GetInt("pvoice", 1) != 0)
																{
																	if (135488 - 418371 != -282883)
																	{
																		continue;
																	}
																	PlayerPrefs.SetInt("pvoice", 0);
																	if (216231 - 137183 != 79048)
																	{
																		continue;
																	}
																}
																else
																{
																	PlayerPrefs.SetInt("pvoice", 1);
																	if (189053 - 145046 != 44007)
																	{
																		continue;
																	}
																}
																this.audio.PlayOneShot(this.zUkciLiv9B7);
																if (181193 - 378544 == -197350)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (159833 - 526639 != -366806)
																{
																	continue;
																}
																GUI.DrawTexture(new Rect((float)122, (float)(num + 6), (float)16, (float)16), this.g5lcmfbLiBj);
																if (6607 - 403147 == -396539)
																{
																	continue;
																}
															}
															num += 30;
															if (46482 - 131466 == -84984)
															{
																GUI.Label(new Rect((float)152, (float)num, (float)300, (float)30), "narrator voice <ctrl-v>", this.eQKcmZ6ivL7);
																if (178479 - 554870 == -376391)
																{
																	if (GUI.Button(new Rect((float)120, (float)(num + 4), (float)22, (float)21), string.Empty, this.MeLcmwBfXkQ))
																	{
																		if (224970 - 178570 == 46401)
																		{
																			continue;
																		}
																		if (PlayerPrefs.GetInt("nvoice", 1) != 0)
																		{
																			if (244793 - 388445 == -143651)
																			{
																				continue;
																			}
																			PlayerPrefs.SetInt("nvoice", 0);
																			if (15289 - 458870 == -443580)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			PlayerPrefs.SetInt("nvoice", 1);
																			if (198154 - 460590 != -262436)
																			{
																				continue;
																			}
																		}
																		this.audio.PlayOneShot(this.zUkciLiv9B7);
																		if (263078 - 569116 == -306037)
																		{
																			continue;
																		}
																	}
																	if (PlayerPrefs.GetInt("nvoice", 1) != 0)
																	{
																		if (29255 - 24522 == 4734)
																		{
																			continue;
																		}
																		GUI.DrawTexture(new Rect((float)122, (float)(num + 6), (float)16, (float)16), this.g5lcmfbLiBj);
																		if (261407 - 263192 == -1784)
																		{
																			continue;
																		}
																	}
																	num += 30;
																	if (13087 - 221843 == -208756)
																	{
																		if (GUI.Button(new Rect((float)189, (float)425, (float)99, (float)40), string.Empty, this.hCicmE954Z3))
																		{
																			if (199132 - 588774 == -389641)
																			{
																				continue;
																			}
																			this.pXycm4rLt23 = 0;
																			if (6788 - 461934 != -455146)
																			{
																				continue;
																			}
																			this.audio.PlayOneShot(this.zUkciLiv9B7);
																			if (225503 - 370045 != -144542)
																			{
																				continue;
																			}
																		}
																		GUI.EndGroup();
																		if (260976 - 260787 == 189)
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

	// Token: 0x060073C6 RID: 29638 RVA: 0x00FB4984 File Offset: 0x00FB2B84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderInterfaceOption()
	{
		if (140124 - 408628 != -268503)
		{
		}
		for (;;)
		{
			GUI.BeginGroup(new Rect(0.5f * this.E4Bci1kE8y4 - (float)236, (float)200, (float)472, (float)561));
			if (58560 - 496369 == -437809)
			{
				GUI.DrawTexture(new Rect((float)0, (float)0, (float)472, (float)561), this.exVcmsmoBdF);
				if (81806 - 421048 == -339242)
				{
					if (GUI.Button(new Rect((float)330, (float)31, (float)57, (float)52), string.Empty, this.a0bcmUencwX))
					{
						if (266120 - 491691 == -225570)
						{
							continue;
						}
						this.IeqcmaEdRXM = false;
						if (215175 - 530189 == -315013)
						{
							continue;
						}
						if (this.vJNci7xce9X)
						{
							if (159036 - 521089 == -362052)
							{
								continue;
							}
							this.audio.PlayOneShot(this.vJNci7xce9X);
							if (227957 - 552085 != -324128)
							{
								continue;
							}
						}
					}
					GUI.DrawTexture(new Rect((float)80, (float)108, (float)310, (float)376), this.rS9cmHBxXH0);
					if (154998 - 277133 == -122135)
					{
						GUI.Label(new Rect((float)108, (float)124, (float)300, (float)30), "Game Display", this.IRYcm7kZrMA);
						if (222971 - 85366 == 137605)
						{
							int num = 170;
							if (276957 - 272859 == 4098)
							{
								GUI.Label(new Rect((float)152, (float)num, (float)300, (float)30), "player name <ctrl-p>", this.eQKcmZ6ivL7);
								if (17403 - 188125 != -170721)
								{
									if (GUI.Button(new Rect((float)120, (float)(num + 4), (float)22, (float)21), string.Empty, this.MeLcmwBfXkQ))
									{
										if (281738 - 115400 == 166339)
										{
											continue;
										}
										if (PlayerPrefs.GetInt("pname", 1) != 0)
										{
											if (181355 - 147737 == 33619)
											{
												continue;
											}
											PlayerPrefs.SetInt("pname", 0);
											if (152236 - 53504 != 98732)
											{
												continue;
											}
										}
										else
										{
											PlayerPrefs.SetInt("pname", 1);
											if (265940 - 93354 == 172587)
											{
												continue;
											}
										}
										this.audio.PlayOneShot(this.zUkciLiv9B7);
										if (115477 - 592884 != -477407)
										{
											continue;
										}
									}
									if (PlayerPrefs.GetInt("pname", 1) != 0)
									{
										if (141462 - 172479 == -31016)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)122, (float)(num + 6), (float)16, (float)16), this.g5lcmfbLiBj);
										if (85187 - 319950 == -234762)
										{
											continue;
										}
									}
									num += 30;
									if (112397 - 361473 != -249075)
									{
										GUI.Label(new Rect((float)152, (float)num, (float)300, (float)30), "character name <ctrl-c>", this.eQKcmZ6ivL7);
										if (43587 - 128964 != -85376)
										{
											if (GUI.Button(new Rect((float)120, (float)(num + 4), (float)22, (float)21), string.Empty, this.MeLcmwBfXkQ))
											{
												if (293699 - 189357 == 104343)
												{
													continue;
												}
												if (PlayerPrefs.GetInt("cname", 1) != 0)
												{
													if (255118 - 520788 == -265669)
													{
														continue;
													}
													PlayerPrefs.SetInt("cname", 0);
													if (250501 - 340818 != -90317)
													{
														continue;
													}
												}
												else
												{
													PlayerPrefs.SetInt("cname", 1);
													if (5052 - 465935 != -460883)
													{
														continue;
													}
												}
												this.audio.PlayOneShot(this.zUkciLiv9B7);
												if (49334 - 190098 == -140763)
												{
													continue;
												}
											}
											if (PlayerPrefs.GetInt("cname", 1) != 0)
											{
												if (229861 - 86723 != 143138)
												{
													continue;
												}
												GUI.DrawTexture(new Rect((float)122, (float)(num + 6), (float)16, (float)16), this.g5lcmfbLiBj);
												if (131900 - 310130 != -178230)
												{
													continue;
												}
											}
											num += 30;
											if (164191 - 330226 == -166035)
											{
												GUI.Label(new Rect((float)152, (float)num, (float)300, (float)30), "guild name <ctrl-g>", this.eQKcmZ6ivL7);
												if (173331 - 595512 == -422181)
												{
													if (GUI.Button(new Rect((float)120, (float)(num + 4), (float)22, (float)21), string.Empty, this.MeLcmwBfXkQ))
													{
														if (179643 - 181319 == -1675)
														{
															continue;
														}
														if (PlayerPrefs.GetInt("gname", 1) != 0)
														{
															if (55979 - 544110 == -488130)
															{
																continue;
															}
															PlayerPrefs.SetInt("gname", 0);
															if (34533 - 47941 == -13407)
															{
																continue;
															}
														}
														else
														{
															PlayerPrefs.SetInt("gname", 1);
															if (99703 - 577019 != -477316)
															{
																continue;
															}
														}
														this.audio.PlayOneShot(this.zUkciLiv9B7);
														if (262039 - 95517 == 166523)
														{
															continue;
														}
													}
													if (PlayerPrefs.GetInt("gname", 1) != 0)
													{
														if (137692 - 265355 == -127662)
														{
															continue;
														}
														GUI.DrawTexture(new Rect((float)122, (float)(num + 6), (float)16, (float)16), this.g5lcmfbLiBj);
														if (125840 - 535469 == -409628)
														{
															continue;
														}
													}
													num += 30;
													if (146220 - 17595 != 128626)
													{
														GUI.Label(new Rect((float)152, (float)num, (float)300, (float)30), "chat bubble <ctrl-b>", this.eQKcmZ6ivL7);
														if (6019 - 176337 != -170317)
														{
															if (GUI.Button(new Rect((float)120, (float)(num + 4), (float)22, (float)21), string.Empty, this.MeLcmwBfXkQ))
															{
																if (45186 - 124838 == -79651)
																{
																	continue;
																}
																if (PlayerPrefs.GetInt("chatBubble", 1) != 0)
																{
																	if (213646 - 547146 != -333500)
																	{
																		continue;
																	}
																	PlayerPrefs.SetInt("chatBubble", 0);
																	if (278964 - 93242 != 185722)
																	{
																		continue;
																	}
																}
																else
																{
																	PlayerPrefs.SetInt("chatBubble", 1);
																	if (61101 - 448348 == -387246)
																	{
																		continue;
																	}
																}
																this.audio.PlayOneShot(this.zUkciLiv9B7);
																if (218063 - 338285 != -120222)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("chatBubble", 1) != 0)
															{
																if (211200 - 394489 == -183288)
																{
																	continue;
																}
																GUI.DrawTexture(new Rect((float)122, (float)(num + 6), (float)16, (float)16), this.g5lcmfbLiBj);
																if (134875 - 26905 != 107970)
																{
																	continue;
																}
															}
															if (GUI.Button(new Rect((float)189, (float)425, (float)99, (float)40), string.Empty, this.hCicmE954Z3))
															{
																if (53257 - 374046 == -320788)
																{
																	continue;
																}
																this.pXycm4rLt23 = 0;
																if (210500 - 35084 == 175417)
																{
																	continue;
																}
																this.audio.PlayOneShot(this.zUkciLiv9B7);
																if (196808 - 55324 == 141485)
																{
																	continue;
																}
															}
															num += 30;
															if (158827 - 405019 == -246192)
															{
																GUI.Label(new Rect((float)152, (float)num, (float)300, (float)30), "menu slide <ctrl-l>", this.eQKcmZ6ivL7);
																if (15608 - 470323 != -454714)
																{
																	if (GUI.Button(new Rect((float)120, (float)(num + 4), (float)22, (float)21), string.Empty, this.MeLcmwBfXkQ))
																	{
																		if (74550 - 448303 == -373752)
																		{
																			continue;
																		}
																		if (PlayerPrefs.GetInt("menuSlide", 0) != 0)
																		{
																			if (245620 - 7733 == 237888)
																			{
																				continue;
																			}
																			PlayerPrefs.SetInt("menuSlide", 0);
																			if (118264 - 267032 != -148768)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			PlayerPrefs.SetInt("menuSlide", 1);
																			if (66792 - 17324 == 49469)
																			{
																				continue;
																			}
																		}
																		this.audio.PlayOneShot(this.zUkciLiv9B7);
																		if (201474 - 237217 == -35742)
																		{
																			continue;
																		}
																	}
																	if (PlayerPrefs.GetInt("menuSlide", 0) != 0)
																	{
																		if (100294 - 359333 == -259038)
																		{
																			continue;
																		}
																		GUI.DrawTexture(new Rect((float)122, (float)(num + 6), (float)16, (float)16), this.g5lcmfbLiBj);
																		if (96652 - 401856 == -305203)
																		{
																			continue;
																		}
																	}
																	num += 30;
																	if (65419 - 425316 == -359897)
																	{
																		GUI.Label(new Rect((float)152, (float)num, (float)300, (float)30), "hide all <ctrl-z>", this.eQKcmZ6ivL7);
																		if (110114 - 569059 == -458945)
																		{
																			if (GUI.Button(new Rect((float)120, (float)(num + 4), (float)22, (float)21), string.Empty, this.MeLcmwBfXkQ))
																			{
																				if (246157 - 135858 != 110299)
																				{
																					continue;
																				}
																				if (PlayerPrefs.GetInt("display", 1) != 0)
																				{
																					if (15389 - 414921 != -399532)
																					{
																						continue;
																					}
																					PlayerPrefs.SetInt("display", 0);
																					if (38603 - 83170 == -44566)
																					{
																						continue;
																					}
																				}
																				else
																				{
																					PlayerPrefs.SetInt("display", 1);
																					if (10165 - 376878 != -366713)
																					{
																						continue;
																					}
																				}
																				this.audio.PlayOneShot(this.zUkciLiv9B7);
																				if (20282 - 291264 == -270981)
																				{
																					continue;
																				}
																			}
																			if (PlayerPrefs.GetInt("display", 1) == 0)
																			{
																				if (96226 - 124306 != -28080)
																				{
																					continue;
																				}
																				GUI.DrawTexture(new Rect((float)122, (float)(num + 6), (float)16, (float)16), this.g5lcmfbLiBj);
																				if (110681 - 553037 == -442355)
																				{
																					continue;
																				}
																			}
																			if (GUI.Button(new Rect((float)189, (float)425, (float)99, (float)40), string.Empty, this.hCicmE954Z3))
																			{
																				if (279579 - 86789 != 192790)
																				{
																					continue;
																				}
																				this.pXycm4rLt23 = 0;
																				if (75213 - 127160 == -51946)
																				{
																					continue;
																				}
																				this.audio.PlayOneShot(this.zUkciLiv9B7);
																				if (183212 - 397616 == -214403)
																				{
																					continue;
																				}
																			}
																			num += 30;
																			if (291590 - 523777 == -232187)
																			{
																				GUI.Label(new Rect((float)152, (float)num, (float)240, (float)30), "camera speed:", this.eQKcmZ6ivL7);
																				if (147025 - 67589 != 79437)
																				{
																					GUI.Label(new Rect((float)300, (float)num, (float)30, (float)30), string.Empty + PlayerPrefs.GetInt("camRot", 5), this.eVKcmCWQXU4);
																					if (54449 - 526908 != -472458)
																					{
																						if (GUI.Button(new Rect((float)340, (float)num, (float)20, (float)17), string.Empty, this.v7xcmPN2twG))
																						{
																							if (145102 - 527202 == -382099)
																							{
																								continue;
																							}
																							this.QmbciB6dpoF = Mathf.Clamp(this.QmbciB6dpoF + 1, 1, 10);
																							if (60968 - 523316 != -462348)
																							{
																								continue;
																							}
																							PlayerPrefs.SetInt("camRot", this.QmbciB6dpoF);
																							if (211972 - 424749 != -212777)
																							{
																								continue;
																							}
																							if (this.QdyciMZNMSM)
																							{
																								if (54145 - 327889 == -273743)
																								{
																									continue;
																								}
																								this.audio.PlayOneShot(this.QdyciMZNMSM);
																								if (110031 - 490647 != -380616)
																								{
																									continue;
																								}
																							}
																						}
																						if (GUI.Button(new Rect((float)340, (float)(num + 17), (float)20, (float)17), string.Empty, this.xgCcmSVAwpW))
																						{
																							if (246316 - 397855 == -151538)
																							{
																								continue;
																							}
																							this.QmbciB6dpoF = Mathf.Clamp(this.QmbciB6dpoF - 1, 1, 10);
																							if (215888 - 559028 != -343140)
																							{
																								continue;
																							}
																							PlayerPrefs.SetInt("camRot", this.QmbciB6dpoF);
																							if (88511 - 134525 == -46013)
																							{
																								continue;
																							}
																							if (this.QdyciMZNMSM)
																							{
																								if (55195 - 206720 != -151525)
																								{
																									continue;
																								}
																								this.audio.PlayOneShot(this.QdyciMZNMSM);
																								if (60131 - 487861 == -427729)
																								{
																									continue;
																								}
																							}
																						}
																						GUI.EndGroup();
																						if (264992 - 409580 != -144587)
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

	// Token: 0x060073C7 RID: 29639 RVA: 0x00FB592C File Offset: 0x00FB3B2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitWorldMapOption()
	{
		if (4727 - 437619 != -432892)
		{
		}
		for (;;)
		{
			this.CdLcm0eUUXo = (Texture)Resources.Load("GameGui/GameWindow/optionMenu/worldMap", typeof(Texture));
			if (288083 - 425473 == -137390)
			{
				this.T6Ycm853p8e = (Texture)Resources.Load("GameGui/GameWindow/optionMenu/mapWindow", typeof(Texture));
				if (253966 - 327018 == -73052)
				{
					this.NLYcmitZHTU = (Texture)Resources.Load("GameGui/GameWindow/optionMenu/mapPointer", typeof(Texture));
					if (221757 - 514716 != -292958)
					{
						this.CAbcmDp5QWm = new GUIStyle();
						if (1716 - 229394 != -227677)
						{
							this.CAbcmDp5QWm.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/optionMenu/mapExit", typeof(Texture)));
							if (102726 - 528845 != -426118)
							{
								MissionClass data = MissionData.getData(Game.mGameCode);
								if (238699 - 514957 == -276258)
								{
									if (data != null)
									{
										if (70571 - 267631 == -197059)
										{
											continue;
										}
										this.fuRcmj0eGPk = data.mapName;
										if (51857 - 497755 == -445897)
										{
											continue;
										}
										this.SArcmmSI1OY = data.mapCordinate;
										if (205358 - 317382 == -112023)
										{
											continue;
										}
									}
									this.qjEcmBa2WuQ = true;
									if (163765 - 479205 != -315439)
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

	// Token: 0x060073C8 RID: 29640 RVA: 0x00FB5B30 File Offset: 0x00FB3D30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderWorldMapOption()
	{
		if (79948 - 400304 != -320355)
		{
		}
		for (;;)
		{
			if (!this.qjEcmBa2WuQ)
			{
				if (122349 - 551640 == -429291)
				{
					this.InitWorldMapOption();
					if (294601 - 408831 != -114229)
					{
						break;
					}
				}
			}
			else
			{
				int num = Mathf.FloorToInt((float)-284 * this.SArcmmSI1OY.x / (float)1024);
				if (274108 - 128780 == 145328)
				{
					int num2 = Mathf.FloorToInt((float)-564 * this.SArcmmSI1OY.y / (float)1024);
					if (10704 - 521020 == -510316)
					{
						int num3 = Mathf.FloorToInt((float)740 * this.SArcmmSI1OY.x / (float)1024);
						if (22501 - 22883 != -381)
						{
							int num4 = Mathf.FloorToInt((float)460 * this.SArcmmSI1OY.y / (float)1024);
							if (6205 - 323542 == -317337)
							{
								GUI.BeginGroup(new Rect(0.5f * this.E4Bci1kE8y4 - (float)370, (float)220, (float)740, (float)460));
								if (131152 - 126578 == 4574)
								{
									GUI.DrawTexture(new Rect((float)num, (float)num2, (float)1024, (float)1024), this.CdLcm0eUUXo);
									if (97109 - 247107 == -149998)
									{
										GUI.DrawTexture(new Rect((float)num3, (float)(num4 + 3), (float)170, (float)62), this.NLYcmitZHTU);
										if (192026 - 71097 != 120930)
										{
											GUI.Label(new Rect((float)num3, (float)(num4 + 31), (float)170, (float)20), this.fuRcmj0eGPk, this.O9XcmM6eVgX);
											if (283586 - 425046 != -141459)
											{
												GUI.EndGroup();
												if (153296 - 304293 != -150996)
												{
													GUI.DrawTexture(new Rect(0.5f * this.E4Bci1kE8y4 - (float)400, (float)200, (float)800, (float)500), this.T6Ycm853p8e);
													if (279681 - 553760 == -274079)
													{
														if (!GUI.Button(new Rect(0.5f * this.E4Bci1kE8y4 - (float)360, (float)666, (float)74, (float)19), string.Empty, this.CAbcmDp5QWm))
														{
															break;
														}
														if (208191 - 50433 == 157758)
														{
															this.IeqcmaEdRXM = false;
															if (58657 - 455326 == -396669)
															{
																this.pXycm4rLt23 = 0;
																if (122070 - 122219 == -149)
																{
																	if (!this.vJNci7xce9X)
																	{
																		break;
																	}
																	if (197926 - 349506 == -151580)
																	{
																		this.audio.PlayOneShot(this.vJNci7xce9X);
																		if (281307 - 275413 == 5894)
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

	// Token: 0x060073C9 RID: 29641 RVA: 0x00FB5EEC File Offset: 0x00FB40EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderAboutOption()
	{
		if (79283 - 69792 != 9492)
		{
		}
		for (;;)
		{
			GUI.BeginGroup(new Rect(0.5f * this.E4Bci1kE8y4 - (float)236, (float)200, (float)472, (float)561));
			if (136207 - 19765 == 116442)
			{
				GUI.DrawTexture(new Rect((float)0, (float)0, (float)472, (float)561), this.exVcmsmoBdF);
				if (218560 - 56876 != 161685)
				{
					if (GUI.Button(new Rect((float)330, (float)31, (float)57, (float)52), string.Empty, this.a0bcmUencwX))
					{
						if (100998 - 540252 == -439253)
						{
							continue;
						}
						this.IeqcmaEdRXM = false;
						if (126571 - 153702 != -27131)
						{
							continue;
						}
						this.audio.PlayOneShot(this.WXJcif9Qnej);
						if (227829 - 379002 != -151173)
						{
							continue;
						}
					}
					GUI.DrawTexture(new Rect((float)80, (float)108, (float)310, (float)376), this.rS9cmHBxXH0);
					if (85852 - 515420 != -429567)
					{
						GUI.Label(new Rect((float)108, (float)124, (float)300, (float)30), "About 12 Tails Online", this.IRYcm7kZrMA);
						if (214785 - 550387 == -335602)
						{
							if (GUI.Button(new Rect((float)189, (float)425, (float)99, (float)40), string.Empty, this.hCicmE954Z3))
							{
								if (90224 - 447180 == -356955)
								{
									continue;
								}
								this.pXycm4rLt23 = 0;
								if (26347 - 425527 != -399180)
								{
									continue;
								}
								this.audio.PlayOneShot(this.zUkciLiv9B7);
								if (263030 - 98951 == 164080)
								{
									continue;
								}
							}
							GUI.EndGroup();
							if (151415 - 598530 == -447115)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060073CA RID: 29642 RVA: 0x00FB6164 File Offset: 0x00FB4364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060073CB RID: 29643 RVA: 0x00FB6168 File Offset: 0x00FB4368
	internal static bool YCyQoopijR9Gn4yBEpB5()
	{
		return true;
	}

	// Token: 0x060073CC RID: 29644 RVA: 0x00FB616C File Offset: 0x00FB436C
	internal static bool G0pZnSpiht8AQjvlq8Dx()
	{
		return false;
	}

	// Token: 0x040078A8 RID: 30888
	public int posx;

	// Token: 0x040078A9 RID: 30889
	public int posy;

	// Token: 0x040078AA RID: 30890
	public int divx;

	// Token: 0x040078AB RID: 30891
	public int divy;

	// Token: 0x040078AC RID: 30892
	public int posa;

	// Token: 0x040078AD RID: 30893
	public int posb;

	// Token: 0x040078AE RID: 30894
	public int diva;

	// Token: 0x040078AF RID: 30895
	public int divb;

	// Token: 0x040078B0 RID: 30896
	private bool K3uci28UFNc;

	// Token: 0x040078B1 RID: 30897
	private int FipcivWhRLF;

	// Token: 0x040078B2 RID: 30898
	private float Xd9cil9WnGp;

	// Token: 0x040078B3 RID: 30899
	private GUISkin OluciGWsJGq;

	// Token: 0x040078B4 RID: 30900
	private float E4Bci1kE8y4;

	// Token: 0x040078B5 RID: 30901
	private float o53ciqnfnhL;

	// Token: 0x040078B6 RID: 30902
	private float fZOcipTgxHT;

	// Token: 0x040078B7 RID: 30903
	private float FWOciR6Dvap;

	// Token: 0x040078B8 RID: 30904
	private Vector2 j5rcirg1OTi;

	// Token: 0x040078B9 RID: 30905
	public GameObject mPlayer;

	// Token: 0x040078BA RID: 30906
	public PlayerCameraControl mCam;

	// Token: 0x040078BB RID: 30907
	public CharacterControl mChar;

	// Token: 0x040078BC RID: 30908
	private CharacterDataClass xwucix0BXjA;

	// Token: 0x040078BD RID: 30909
	private eMouseState qBociTv3FUi;

	// Token: 0x040078BE RID: 30910
	private float y9PciYyfIZl;

	// Token: 0x040078BF RID: 30911
	private float whRci35fPxW;

	// Token: 0x040078C0 RID: 30912
	private float BRjcibdpIVx;

	// Token: 0x040078C1 RID: 30913
	private int gjCcidMIVK9;

	// Token: 0x040078C2 RID: 30914
	private Vector2 RH3cigdmkVM;

	// Token: 0x040078C3 RID: 30915
	private int o90ciamtGQU;

	// Token: 0x040078C4 RID: 30916
	private int guPci4YLE4Q;

	// Token: 0x040078C5 RID: 30917
	private float enEcisCfyiD;

	// Token: 0x040078C6 RID: 30918
	private AudioClip IZ7ciHMjyLk;

	// Token: 0x040078C7 RID: 30919
	private AudioClip vJNci7xce9X;

	// Token: 0x040078C8 RID: 30920
	private AudioClip EmkciZmuTFP;

	// Token: 0x040078C9 RID: 30921
	private AudioClip WtZciCJbEVG;

	// Token: 0x040078CA RID: 30922
	private AudioClip QdyciMZNMSM;

	// Token: 0x040078CB RID: 30923
	private AudioClip WXJcif9Qnej;

	// Token: 0x040078CC RID: 30924
	private AudioClip zUkciLiv9B7;

	// Token: 0x040078CD RID: 30925
	private GUIStyle O3Pciwb1VqM;

	// Token: 0x040078CE RID: 30926
	private GUIStyle evOciUtwKoa;

	// Token: 0x040078CF RID: 30927
	private GUIStyle HimciN5gy2M;

	// Token: 0x040078D0 RID: 30928
	private GUIStyle xvYciEy7SXb;

	// Token: 0x040078D1 RID: 30929
	private GUIStyle csociPaX4Qi;

	// Token: 0x040078D2 RID: 30930
	private float ldJciSWc06E;

	// Token: 0x040078D3 RID: 30931
	private int QmbciB6dpoF;

	// Token: 0x040078D4 RID: 30932
	public GameObject targetObject;

	// Token: 0x040078D5 RID: 30933
	private Texture L7jci0JQANr;

	// Token: 0x040078D6 RID: 30934
	private Texture Cctci8eL5Co;

	// Token: 0x040078D7 RID: 30935
	private Texture U8icii1PLv9;

	// Token: 0x040078D8 RID: 30936
	private Vector3 pbRciDJMFF3;

	// Token: 0x040078D9 RID: 30937
	private GameObject ogYcimbuwmv;

	// Token: 0x040078DA RID: 30938
	private Vector3 T0icijoN2oY;

	// Token: 0x040078DB RID: 30939
	private GameObject DENcioQfXDq;

	// Token: 0x040078DC RID: 30940
	private Texture IhIcikTnQnQ;

	// Token: 0x040078DD RID: 30941
	private Texture grWciFd19Xn;

	// Token: 0x040078DE RID: 30942
	private Texture z0ZciANDYkj;

	// Token: 0x040078DF RID: 30943
	private Texture VNxci9u3V4N;

	// Token: 0x040078E0 RID: 30944
	private Texture MShciWVGGOK;

	// Token: 0x040078E1 RID: 30945
	private Texture QmRciuWH3Wo;

	// Token: 0x040078E2 RID: 30946
	private Texture OtjciyKMLTB;

	// Token: 0x040078E3 RID: 30947
	private Texture hYqciV1Ropn;

	// Token: 0x040078E4 RID: 30948
	private Texture cuocih7lrQu;

	// Token: 0x040078E5 RID: 30949
	private Texture kSMciKqq746;

	// Token: 0x040078E6 RID: 30950
	private Texture IWAcizLGVow;

	// Token: 0x040078E7 RID: 30951
	private Texture J4mcD57pWrP;

	// Token: 0x040078E8 RID: 30952
	private Texture OEZcDctMh6p;

	// Token: 0x040078E9 RID: 30953
	private Texture sKGcDnybYa5;

	// Token: 0x040078EA RID: 30954
	private Texture hQucDQJaGoa;

	// Token: 0x040078EB RID: 30955
	private Texture UEHcDecSCvo;

	// Token: 0x040078EC RID: 30956
	private Texture I2XcDIVgPw3;

	// Token: 0x040078ED RID: 30957
	private Texture fSdcDJSPCXs;

	// Token: 0x040078EE RID: 30958
	private Texture yTacD6DV0AH;

	// Token: 0x040078EF RID: 30959
	private Texture utucDt6eZDj;

	// Token: 0x040078F0 RID: 30960
	private Texture RDDcDXirMcc;

	// Token: 0x040078F1 RID: 30961
	private Texture yUfcDOBENRv;

	// Token: 0x040078F2 RID: 30962
	private Texture f5tcD2H01ua;

	// Token: 0x040078F3 RID: 30963
	private Texture kU7cDvP3yTO;

	// Token: 0x040078F4 RID: 30964
	private Texture u2KcDlZkXWA;

	// Token: 0x040078F5 RID: 30965
	private Texture GvScDGgkwQD;

	// Token: 0x040078F6 RID: 30966
	private Texture kdHcD1Ii0sO;

	// Token: 0x040078F7 RID: 30967
	private Texture n8ucDqESv9E;

	// Token: 0x040078F8 RID: 30968
	private Texture UHEcDpD0VBN;

	// Token: 0x040078F9 RID: 30969
	private Texture DO5cDRc3LLf;

	// Token: 0x040078FA RID: 30970
	private float IHtcDrxQJgk;

	// Token: 0x040078FB RID: 30971
	private Texture kyBcDxfZTdp;

	// Token: 0x040078FC RID: 30972
	private Texture fgFcDT8TMIK;

	// Token: 0x040078FD RID: 30973
	private Texture gQucDYrQXIe;

	// Token: 0x040078FE RID: 30974
	private Texture llbcD3F635X;

	// Token: 0x040078FF RID: 30975
	private Texture d0JcDbDC8w6;

	// Token: 0x04007900 RID: 30976
	private Texture oUfcDdUI8d2;

	// Token: 0x04007901 RID: 30977
	private Texture iqrcDgmc6GV;

	// Token: 0x04007902 RID: 30978
	private Texture IQYcDaJVjXW;

	// Token: 0x04007903 RID: 30979
	private Texture CMOcD48odwi;

	// Token: 0x04007904 RID: 30980
	private Texture lswcDsnV9L6;

	// Token: 0x04007905 RID: 30981
	private Texture nuscDHQMU6o;

	// Token: 0x04007906 RID: 30982
	private Texture eHncD7O4Py4;

	// Token: 0x04007907 RID: 30983
	private Texture UjqcDZwOoCc;

	// Token: 0x04007908 RID: 30984
	private Texture qoGcDCBm632;

	// Token: 0x04007909 RID: 30985
	private Texture WuicDMI9PSi;

	// Token: 0x0400790A RID: 30986
	private Texture okPcDffEos3;

	// Token: 0x0400790B RID: 30987
	private Texture jKscDLKvc2B;

	// Token: 0x0400790C RID: 30988
	private Texture Ii0cDw9Ki6B;

	// Token: 0x0400790D RID: 30989
	private GameObject uFgcDUXpACW;

	// Token: 0x0400790E RID: 30990
	private string VlRcDNiguDW;

	// Token: 0x0400790F RID: 30991
	private string rrMcDESWlC2;

	// Token: 0x04007910 RID: 30992
	private int iI3cDPmuoH6;

	// Token: 0x04007911 RID: 30993
	private int UiScDSXMANZ;

	// Token: 0x04007912 RID: 30994
	private int fnvcDB8qRY9;

	// Token: 0x04007913 RID: 30995
	private bool o0pcD0eBA8d;

	// Token: 0x04007914 RID: 30996
	private GUIStyle QhpcD87DGw5;

	// Token: 0x04007915 RID: 30997
	private GUIStyle PLNcDiDE49N;

	// Token: 0x04007916 RID: 30998
	private GUIStyle nQScDDgECln;

	// Token: 0x04007917 RID: 30999
	private Texture o03cDme4W6s;

	// Token: 0x04007918 RID: 31000
	private Texture qONcDjp5icx;

	// Token: 0x04007919 RID: 31001
	private Texture kLjcDo0vB2H;

	// Token: 0x0400791A RID: 31002
	private Texture txccDkYeRlh;

	// Token: 0x0400791B RID: 31003
	private CharacterControl[] dyJcDFkFgYi;

	// Token: 0x0400791C RID: 31004
	private Texture[] PxXcDAKyQA0;

	// Token: 0x0400791D RID: 31005
	private Texture HN2cD9tBaEb;

	// Token: 0x0400791E RID: 31006
	private GUIStyle VkecDWtJtut;

	// Token: 0x0400791F RID: 31007
	private GUIStyle v98cDuPOIeq;

	// Token: 0x04007920 RID: 31008
	private Texture anlcDyqCLQ9;

	// Token: 0x04007921 RID: 31009
	private Texture kwGcDVj1ZAb;

	// Token: 0x04007922 RID: 31010
	private Texture g85cDhuF6DZ;

	// Token: 0x04007923 RID: 31011
	private Texture QlCcDKMYlBw;

	// Token: 0x04007924 RID: 31012
	private Texture k5lcDztQHaI;

	// Token: 0x04007925 RID: 31013
	private Texture dy3cm59VQd5;

	// Token: 0x04007926 RID: 31014
	private Texture w2hcmchtYkH;

	// Token: 0x04007927 RID: 31015
	private Texture KC6cmnFGbiY;

	// Token: 0x04007928 RID: 31016
	private Texture KA8cmQ4MO03;

	// Token: 0x04007929 RID: 31017
	private Texture xWqcmePKr1Y;

	// Token: 0x0400792A RID: 31018
	private Texture DT8cmIiFSAw;

	// Token: 0x0400792B RID: 31019
	private Texture GJscmJykWxu;

	// Token: 0x0400792C RID: 31020
	private int gOqcm6GwVHp;

	// Token: 0x0400792D RID: 31021
	private string yYrcmtal1De;

	// Token: 0x0400792E RID: 31022
	private float UNvcmXkrOrB;

	// Token: 0x0400792F RID: 31023
	private GUIStyle VvhcmOignPu;

	// Token: 0x04007930 RID: 31024
	private string hQycm2UUMhn;

	// Token: 0x04007931 RID: 31025
	private float tT9cmv6DBnA;

	// Token: 0x04007932 RID: 31026
	private GUIStyle cqLcmlfHA28;

	// Token: 0x04007933 RID: 31027
	private Texture Uo2cmGSwZ7d;

	// Token: 0x04007934 RID: 31028
	private string d2gcm1kx0Ib;

	// Token: 0x04007935 RID: 31029
	private Texture oy6cmque6xf;

	// Token: 0x04007936 RID: 31030
	private GUIStyle oHgcmp60Qkt;

	// Token: 0x04007937 RID: 31031
	private GUIStyle qLrcmRiGnHb;

	// Token: 0x04007938 RID: 31032
	private GUIStyle AF0cmrrT8Re;

	// Token: 0x04007939 RID: 31033
	private Color pvacmxomHOD;

	// Token: 0x0400793A RID: 31034
	private Color Cc4cmTBVW6w;

	// Token: 0x0400793B RID: 31035
	private Color XbycmYUoC3P;

	// Token: 0x0400793C RID: 31036
	private Color OD4cm3qa3cI;

	// Token: 0x0400793D RID: 31037
	private Color MJvcmbTkIE8;

	// Token: 0x0400793E RID: 31038
	private Color C9ocmdiJ1YU;

	// Token: 0x0400793F RID: 31039
	private Color JIwcmgb9E19;

	// Token: 0x04007940 RID: 31040
	private bool IeqcmaEdRXM;

	// Token: 0x04007941 RID: 31041
	private int pXycm4rLt23;

	// Token: 0x04007942 RID: 31042
	private Texture exVcmsmoBdF;

	// Token: 0x04007943 RID: 31043
	private Texture rS9cmHBxXH0;

	// Token: 0x04007944 RID: 31044
	private GUIStyle IRYcm7kZrMA;

	// Token: 0x04007945 RID: 31045
	private GUIStyle eQKcmZ6ivL7;

	// Token: 0x04007946 RID: 31046
	private GUIStyle eVKcmCWQXU4;

	// Token: 0x04007947 RID: 31047
	private GUIStyle O9XcmM6eVgX;

	// Token: 0x04007948 RID: 31048
	private Texture g5lcmfbLiBj;

	// Token: 0x04007949 RID: 31049
	private Texture GA5cmLCtkkp;

	// Token: 0x0400794A RID: 31050
	private GUIStyle MeLcmwBfXkQ;

	// Token: 0x0400794B RID: 31051
	private GUIStyle a0bcmUencwX;

	// Token: 0x0400794C RID: 31052
	private GUIStyle UGNcmNpcqQF;

	// Token: 0x0400794D RID: 31053
	private GUIStyle hCicmE954Z3;

	// Token: 0x0400794E RID: 31054
	private GUIStyle v7xcmPN2twG;

	// Token: 0x0400794F RID: 31055
	private GUIStyle xgCcmSVAwpW;

	// Token: 0x04007950 RID: 31056
	private bool qjEcmBa2WuQ;

	// Token: 0x04007951 RID: 31057
	private Texture CdLcm0eUUXo;

	// Token: 0x04007952 RID: 31058
	private Texture T6Ycm853p8e;

	// Token: 0x04007953 RID: 31059
	private Texture NLYcmitZHTU;

	// Token: 0x04007954 RID: 31060
	private GUIStyle CAbcmDp5QWm;

	// Token: 0x04007955 RID: 31061
	private Vector2 SArcmmSI1OY;

	// Token: 0x04007956 RID: 31062
	private string fuRcmj0eGPk;

	// Token: 0x0200139C RID: 5020
	[CompilerGenerated]
	[Serializable]
	internal sealed class $InitMupoRunGui$37711 : GenericGenerator<object>
	{
		// Token: 0x060073CD RID: 29645 RVA: 0x00FB6170 File Offset: 0x00FB4370
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $InitMupoRunGui$37711(M202_RunMupoRun_gui self_)
		{
			if (239329 - 277376 != -38046)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (221910 - 382237 != -160326)
				{
					base..ctor();
					if (230033 - 338598 != -108564)
					{
						this.$self_$37713 = self_;
						if (116046 - 587180 == -471134)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060073CE RID: 29646 RVA: 0x00FB6208 File Offset: 0x00FB4408
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new M202_RunMupoRun_gui.$InitMupoRunGui$37711.$(this.$self_$37713);
		}

		// Token: 0x060073CF RID: 29647 RVA: 0x00FB6218 File Offset: 0x00FB4418
		internal static bool kX1WyPpisWtECZ7fA5jI()
		{
			return true;
		}

		// Token: 0x060073D0 RID: 29648 RVA: 0x00FB621C File Offset: 0x00FB441C
		internal static bool j8DTi6pi9hxdyLOTaH0a()
		{
			return false;
		}

		// Token: 0x04007957 RID: 31063
		internal M202_RunMupoRun_gui $self_$37713;

		// Token: 0x0200139D RID: 5021
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x060073D1 RID: 29649 RVA: 0x00FB6220 File Offset: 0x00FB4420
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M202_RunMupoRun_gui self_)
			{
				if (116603 - 531142 != -414538)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (134675 - 44344 == 90331)
					{
						base..ctor();
						if (74803 - 112059 != -37255)
						{
							this.$self_$37712 = self_;
							if (54988 - 435049 != -380060)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060073D2 RID: 29650 RVA: 0x00FB62B8 File Offset: 0x00FB44B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223045 - 257764 != -34719)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9AB;
					case 2:
						this.$self_$37712.K3uci28UFNc = true;
						if (201694 - 233985 != -32291)
						{
							continue;
						}
						if (!Screen.fullScreen)
						{
							if (232421 - 331035 != -98614)
							{
								continue;
							}
							Mousef.ClipMousePosition();
							if (95302 - 140834 == -45531)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (1232 - 472622 != -471389)
						{
							goto Block_31;
						}
						continue;
					default:
						if (142880 - 228354 != -85474)
						{
							continue;
						}
						break;
					}
					this.$self_$37712.FipcivWhRLF = 0;
					if (144225 - 241481 == -97256)
					{
						this.$self_$37712.E4Bci1kE8y4 = (float)0;
						if (124580 - 312317 != -187736)
						{
							this.$self_$37712.o53ciqnfnhL = (float)1;
							if (93577 - 217423 == -123846)
							{
								this.$self_$37712.qBociTv3FUi = eMouseState.none;
								if (215617 - 94718 == 120899)
								{
									this.$self_$37712.y9PciYyfIZl = (float)0;
									if (119554 - 82347 != 37208)
									{
										this.$self_$37712.whRci35fPxW = (float)0;
										if (120946 - 93897 != 27050)
										{
											this.$self_$37712.BRjcibdpIVx = -10f;
											if (186806 - 191573 != -4766)
											{
												this.$self_$37712.OluciGWsJGq = (GUISkin)Resources.Load("GameGui/Skins/GameGui", typeof(GUISkin));
												if (257883 - 4626 == 253257)
												{
													this.$self_$37712.O3Pciwb1VqM = new GUIStyle();
													if (158182 - 77360 == 80822)
													{
														this.$self_$37712.O3Pciwb1VqM.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
														if (282479 - 404126 == -121647)
														{
															this.$self_$37712.O3Pciwb1VqM.alignment = TextAnchor.MiddleLeft;
															if (23308 - 318313 == -295005)
															{
																this.$self_$37712.O3Pciwb1VqM.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
																if (61553 - 131604 != -70050)
																{
																	this.$self_$37712.evOciUtwKoa = new GUIStyle();
																	if (134131 - 271619 != -137487)
																	{
																		this.$self_$37712.evOciUtwKoa.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
																		if (274955 - 123183 != 151773)
																		{
																			this.$self_$37712.evOciUtwKoa.alignment = TextAnchor.UpperLeft;
																			if (130278 - 306211 != -175932)
																			{
																				this.$self_$37712.evOciUtwKoa.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
																				if (122967 - 212447 == -89480)
																				{
																					this.$self_$37712.evOciUtwKoa.wordWrap = true;
																					if (60578 - 111535 == -50957)
																					{
																						this.$self_$37712.HimciN5gy2M = new GUIStyle();
																						if (206126 - 53944 != 152183)
																						{
																							this.$self_$37712.HimciN5gy2M.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																							if (247148 - 197310 == 49838)
																							{
																								this.$self_$37712.HimciN5gy2M.alignment = TextAnchor.MiddleCenter;
																								if (114810 - 300379 != -185568)
																								{
																									this.$self_$37712.HimciN5gy2M.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																									if (32561 - 442607 == -410046)
																									{
																										this.$self_$37712.xvYciEy7SXb = new GUIStyle();
																										if (147876 - 103722 != 44155)
																										{
																											this.$self_$37712.xvYciEy7SXb.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																											if (110811 - 378878 != -268066)
																											{
																												this.$self_$37712.xvYciEy7SXb.alignment = TextAnchor.MiddleCenter;
																												if (188770 - 316190 == -127420)
																												{
																													this.$self_$37712.xvYciEy7SXb.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
																													if (250950 - 511582 != -260631)
																													{
																														this.$self_$37712.csociPaX4Qi = new GUIStyle();
																														if (127156 - 345521 != -218364)
																														{
																															this.$self_$37712.csociPaX4Qi.font = (Font)Resources.Load("GameGui/Fonts/Berlin18", typeof(Font));
																															if (166936 - 556979 != -390042)
																															{
																																this.$self_$37712.csociPaX4Qi.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																																if (40126 - 117570 != -77443)
																																{
																																	this.$self_$37712.IZ7ciHMjyLk = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
																																	if (212954 - 283473 == -70519)
																																	{
																																		this.$self_$37712.vJNci7xce9X = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
																																		if (239318 - 443496 != -204177)
																																		{
																																			this.$self_$37712.EmkciZmuTFP = (AudioClip)Resources.Load("Sound/GUI/click", typeof(AudioClip));
																																			if (99077 - 90757 != 8321)
																																			{
																																				this.$self_$37712.WtZciCJbEVG = (AudioClip)Resources.Load("Sound/GUI/select", typeof(AudioClip));
																																				if (257244 - 492121 != -234876)
																																				{
																																					this.$self_$37712.QdyciMZNMSM = (AudioClip)Resources.Load("Sound/GUI/tick", typeof(AudioClip));
																																					if (236015 - 28359 != 207657)
																																					{
																																						this.$self_$37712.WXJcif9Qnej = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
																																						if (291810 - 7182 != 284629)
																																						{
																																							this.$self_$37712.zUkciLiv9B7 = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																																							if (294552 - 63545 == 231007)
																																							{
																																								this.$self_$37712.InitCaptureInput();
																																								if (62120 - 73732 == -11612)
																																								{
																																									this.$self_$37712.InitMapBar();
																																									if (204229 - 319476 == -115247)
																																									{
																																										this.$self_$37712.InitScoreBar();
																																										if (113831 - 586893 != -473061)
																																										{
																																											this.$self_$37712.InitTargetBar();
																																											if (189317 - 503100 != -313782)
																																											{
																																												this.$self_$37712.InitTargetArea();
																																												if (176966 - 189290 != -12323)
																																												{
																																													this.$self_$37712.InitTeamBar();
																																													if (73471 - 449147 == -375676)
																																													{
																																														this.$self_$37712.InitCharacterBar();
																																														if (185288 - 115839 == 69449)
																																														{
																																															this.$self_$37712.InitGameMessage();
																																															if (204448 - 505140 == -300692)
																																															{
																																																this.$self_$37712.InitNoticeBar();
																																																if (146921 - 239305 == -92384)
																																																{
																																																	this.$self_$37712.InitOptionMenu();
																																																	if (117309 - 538822 == -421513)
																																																	{
																																																		this.$self_$37712.InitChatBar();
																																																		if (174661 - 87810 != 86852)
																																																		{
																																																			goto Block_41;
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
				}
				Block_31:
				goto IL_9AB;
				Block_41:
				return this.YieldDefault(2);
				IL_9AB:
				return false;
			}

			// Token: 0x060073D3 RID: 29651 RVA: 0x00FB6C84 File Offset: 0x00FB4E84
			internal static bool NapOfKpi1xarJi1EIjHP()
			{
				return true;
			}

			// Token: 0x060073D4 RID: 29652 RVA: 0x00FB6C88 File Offset: 0x00FB4E88
			internal static bool xq28n4pi4XP3L4khMssi()
			{
				return false;
			}

			// Token: 0x04007958 RID: 31064
			internal M202_RunMupoRun_gui $self_$37712;
		}
	}
}
