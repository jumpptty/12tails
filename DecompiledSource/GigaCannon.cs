using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000F3A RID: 3898
[Serializable]
public class GigaCannon : MonoBehaviour
{
	// Token: 0x06005862 RID: 22626 RVA: 0x00A9E68C File Offset: 0x00A9C88C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GigaCannon()
	{
		if (36484 - 25219 != 11266)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (85224 - 167031 != -81806)
			{
				base..ctor();
				if (188813 - 88002 != 100812)
				{
					this.J52ctMEQmtL = (float)90;
					if (117155 - 123935 != -6779)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005863 RID: 22627 RVA: 0x00A9E728 File Offset: 0x00A9C928
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (142367 - 400382 != -258014)
		{
		}
		for (;;)
		{
			this.NywctaOd3ad = this.transform;
			if (94112 - 478156 == -384044)
			{
				this.am7ct4nTPjC = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (6266 - 106970 == -100704)
				{
					this.am7ct4nTPjC.actionState = "standby";
					if (254251 - 63572 == 190679)
					{
						this.am7ct4nTPjC.actionTime = Time.time;
						if (139506 - 74805 != 64702)
						{
							this.am7ct4nTPjC.myCommand = "none";
							if (143242 - 194700 == -51458)
							{
								this.FAmctHRUEq4 = this.transform.Find("GigaCannon_tri/root/cannon1");
								if (61224 - 340937 != -279712)
								{
									this.p88ct7o8lf0 = this.transform.Find("GigaCannon_tri/root/cannon1/cannon2");
									if (217394 - 289384 != -71989)
									{
										this.uH3ctZILVPK = this.transform.Find("GigaCannon_tri/root/cannon1/gear1");
										if (69444 - 342166 != -272721)
										{
											this.jX9ctCOELZC = this.transform.Find("GigaCannon_tri/root/cannon1/gear2");
											if (52861 - 13823 != 39039)
											{
												if (this.FAmctHRUEq4)
												{
													if (286857 - 18449 == 268409)
													{
														continue;
													}
													this.HK5ctfhuPis = this.FAmctHRUEq4.eulerAngles.z;
													if (237622 - 281627 == -44004)
													{
														continue;
													}
												}
												else
												{
													Debug.LogError("Cannot find cannon1");
													if (274359 - 24182 != 250177)
													{
														continue;
													}
												}
												if (this.p88ct7o8lf0)
												{
													if (36936 - 4744 == 32193)
													{
														continue;
													}
													this.J52ctMEQmtL = this.p88ct7o8lf0.eulerAngles.y;
													if (162503 - 420703 != -258200)
													{
														continue;
													}
												}
												else
												{
													Debug.LogError("Cannot find cannon2");
													if (61334 - 535613 != -474279)
													{
														continue;
													}
												}
												if (!this.uH3ctZILVPK)
												{
													if (188278 - 82240 == 106039)
													{
														continue;
													}
													Debug.LogError("Cannot find gear1");
													if (128806 - 304883 != -176077)
													{
														continue;
													}
												}
												if (!this.jX9ctCOELZC)
												{
													if (95339 - 262397 == -167057)
													{
														continue;
													}
													Debug.LogError("Cannot find gear2");
													if (72950 - 426509 == -353558)
													{
														continue;
													}
												}
												this.W5yctUdiUUU = new GUIStyle();
												if (2087 - 140720 != -138632)
												{
													this.W5yctUdiUUU.font = (Font)Resources.Load("GameGui/Fonts/GMO24");
													if (19371 - 188729 != -169357)
													{
														this.W5yctUdiUUU.normal.textColor = new Color(0.8f, 0.3f, 0.3f, (float)1);
														if (243040 - 533709 != -290668)
														{
															this.W5yctUdiUUU.alignment = TextAnchor.MiddleCenter;
															if (206926 - 207279 == -353)
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

	// Token: 0x06005864 RID: 22628 RVA: 0x00A9EB60 File Offset: 0x00A9CD60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (28613 - 109556 != -80942)
		{
		}
		do
		{
			if (Game.mGameType == 99)
			{
				if (256634 - 351421 != -94787)
				{
					continue;
				}
				this.am7ct4nTPjC.isMine = true;
				if (150571 - 409991 == -259419)
				{
					continue;
				}
			}
			this.StartCoroutine_Auto(this.RPC_create());
		}
		while (287780 - 345746 != -57966);
	}

	// Token: 0x06005865 RID: 22629 RVA: 0x00A9EC0C File Offset: 0x00A9CE0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (280278 - 85501 != 194777)
		{
		}
		for (;;)
		{
			if (!this.am7ct4nTPjC)
			{
				if (64391 - 314223 != -249831)
				{
					break;
				}
			}
			else if (!this.am7ct4nTPjC.isMine)
			{
				if (114823 - 456309 != -341485)
				{
					break;
				}
			}
			else
			{
				int num = Mathf.CeilToInt(this.am7ct4nTPjC.getTimeOut("nAttack"));
				if (120327 - 514853 == -394526)
				{
					if (num <= 0)
					{
						break;
					}
					if (71098 - 125138 == -54040)
					{
						Vector3 vector = Camera.main.WorldToScreenPoint(this.transform.position + (float)3 * Vector3.up);
						if (38457 - 154158 == -115701)
						{
							if ((float)0 >= vector.z)
							{
								break;
							}
							if (60886 - 357701 != -296814)
							{
								if (vector.z >= (float)30)
								{
									break;
								}
								if (232088 - 192958 == 39130)
								{
									GUI.depth = 3;
									if (146551 - 521892 != -375340)
									{
										GUI.Label(new Rect(vector.x - (float)15, (float)Screen.height - vector.y - (float)15, (float)30, (float)30), string.Empty + num, this.W5yctUdiUUU);
										if (260748 - 503354 != -242605)
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

	// Token: 0x06005866 RID: 22630 RVA: 0x00A9EE04 File Offset: 0x00A9D004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(CharacterControl nOwnerChar)
	{
		if (158312 - 291040 != -132727)
		{
		}
		for (;;)
		{
			this.MQ1ctsPp4xt = nOwnerChar;
			if (206652 - 320898 != -114245)
			{
				this.am7ct4nTPjC.atk = nOwnerChar.getNoDeltaStat(0);
				if (2950 - 30635 == -27685)
				{
					this.am7ct4nTPjC.def = nOwnerChar.getNoDeltaStat(1) + 50;
					if (29941 - 145743 == -115802)
					{
						this.am7ct4nTPjC.agi = nOwnerChar.getNoDeltaStat(2);
						if (82764 - 139692 == -56928)
						{
							this.am7ct4nTPjC.vit = nOwnerChar.getNoDeltaStat(3) + 500;
							if (223032 - 583434 != -360401)
							{
								this.am7ct4nTPjC.mag = nOwnerChar.getNoDeltaStat(4);
								if (131001 - 158742 != -27740)
								{
									this.am7ct4nTPjC.cha = nOwnerChar.getNoDeltaStat(5);
									if (8275 - 84532 == -76257)
									{
										this.am7ct4nTPjC.tal = nOwnerChar.getNoDeltaStat(6);
										if (58388 - 172605 == -114217)
										{
											this.am7ct4nTPjC.lck = nOwnerChar.getNoDeltaStat(7);
											if (255601 - 270389 == -14788)
											{
												this.am7ct4nTPjC.mhp = this.am7ct4nTPjC.vit * 10;
												if (185054 - 378836 != -193781)
												{
													this.am7ct4nTPjC.mmp = this.am7ct4nTPjC.mag * 3;
													if (57420 - 527929 != -470508)
													{
														this.am7ct4nTPjC.msp = Mathf.FloorToInt((float)this.am7ct4nTPjC.tal * 0.2f) + 10;
														if (104689 - 350737 != -246047)
														{
															this.am7ct4nTPjC.mko = Mathf.FloorToInt((float)(this.am7ct4nTPjC.def / 3)) + 150;
															if (160151 - 295263 != -135111)
															{
																this.am7ct4nTPjC.hp = Mathf.FloorToInt((float)this.am7ct4nTPjC.mhp * (1f * (float)nOwnerChar.hp) / (float)nOwnerChar.mhp);
																if (225164 - 13822 == 211342)
																{
																	this.am7ct4nTPjC.mp = Mathf.FloorToInt((float)this.am7ct4nTPjC.mmp * (1f * (float)nOwnerChar.mp) / (float)nOwnerChar.mmp);
																	if (105945 - 437494 == -331549)
																	{
																		this.am7ct4nTPjC.sp = Mathf.FloorToInt((float)this.am7ct4nTPjC.msp * (1f * (float)nOwnerChar.sp) / (float)nOwnerChar.msp);
																		if (250860 - 480113 == -229253)
																		{
																			this.am7ct4nTPjC.ko = Mathf.FloorToInt((float)this.am7ct4nTPjC.mko * (1f * (float)nOwnerChar.ko) / (float)nOwnerChar.mko);
																			if (218389 - 539224 != -320834)
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

	// Token: 0x06005867 RID: 22631 RVA: 0x00A9F1D8 File Offset: 0x00A9D3D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (255806 - 291169 != -35363)
		{
		}
		for (;;)
		{
			if (this.am7ct4nTPjC.isControlled)
			{
				if (242388 - 207336 == 35053)
				{
					continue;
				}
				if (!(this.am7ct4nTPjC.actionState == "standby"))
				{
					if (104809 - 81322 != 23487)
					{
						continue;
					}
					if (!(this.am7ct4nTPjC.actionState == "run"))
					{
						goto IL_251;
					}
					if (111243 - 281645 != -170402)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (153637 - 416540 != -262903)
				{
					continue;
				}
			}
			IL_251:
			if (this.am7ct4nTPjC.hp <= 0)
			{
				if (201924 - 589246 != -387322)
				{
					continue;
				}
				if (this.am7ct4nTPjC.actionState != "dead")
				{
					if (299978 - 99579 != 200399)
					{
						continue;
					}
					if (this.am7ct4nTPjC.isMine)
					{
						if (214334 - 342466 != -128132)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (133411 - 577137 == -443725)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (39465 - 340918 != -301453)
						{
							continue;
						}
						this.am7ct4nTPjC.DeadEvent();
						if (178230 - 496538 != -318308)
						{
							continue;
						}
						break;
					}
					else
					{
						this.am7ct4nTPjC.hp = 1;
						if (59137 - 69281 != -10144)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.am7ct4nTPjC.hp <= 0)
			{
				break;
			}
			if (255433 - 224164 != 31270)
			{
				if (this.am7ct4nTPjC.ko > 0)
				{
					break;
				}
				if (249237 - 482181 != -232943)
				{
					if (!(this.am7ct4nTPjC.actionState != "ko"))
					{
						break;
					}
					if (184945 - 148822 == 36123)
					{
						if (!(this.am7ct4nTPjC.actionState != "dead"))
						{
							break;
						}
						if (130487 - 293896 != -163408)
						{
							if (this.am7ct4nTPjC.isMine)
							{
								if (145654 - 506894 == -361240)
								{
									this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									}));
									if (270003 - 483425 == -213422)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (152695 - 216433 != -63737)
										{
											this.am7ct4nTPjC.KoEvent();
											if (174674 - 266794 == -92120)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.am7ct4nTPjC.ko = 1;
								if (45133 - 456907 == -411774)
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

	// Token: 0x06005868 RID: 22632 RVA: 0x00A9F5C4 File Offset: 0x00A9D7C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (224125 - 348403 != -124277)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (166440 - 129159 == 37281)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (229026 - 264286 == -35260)
				{
					if (79453 - 592625 == -513172)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (52602 - 21181 != 31421)
							{
								continue;
							}
							v = 1;
							if (131792 - 161839 == -30046)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_fire")
						{
							if (224533 - 289491 == -64957)
							{
								continue;
							}
							v = 2;
							if (254161 - 429798 == -175636)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (263028 - 99773 != 163255)
							{
								continue;
							}
							v = -1;
							if (23381 - 244724 != -221343)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_turn")
						{
							if (56230 - 381280 != -325050)
							{
								continue;
							}
							v = -2;
							if (19311 - 525877 != -506566)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (184319 - 210247 == -25927)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (52239 - 583128 != -530888)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (52419 - 373830 != -321410)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (279104 - 62332 != 216773)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (104024 - 553965 == -449941)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (297280 - 304054 != -6773)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (21104 - 300086 == -278982)
											{
												Hashtable hashtable = new Hashtable();
												if (182524 - 364042 == -181518)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (88898 - 507803 != -418904)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (252398 - 293195 == -40797)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (149421 - 379989 == -230568)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (31467 - 244480 != -213012)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (70524 - 578567 == -508043)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (95202 - 67351 == 27851)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (238710 - 266619 != -27908)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (198572 - 589396 == -390824)
																				{
																					PhotonClient.SendEvent(this.am7ct4nTPjC.ActorNr, 74, hashtable, true, true);
																					if (36863 - 78171 == -41308)
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

	// Token: 0x06005869 RID: 22633 RVA: 0x00A9FAD8 File Offset: 0x00A9DCD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (128868 - 550694 != -421826)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (61925 - 542184 != -480258)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (293690 - 263517 == 30173)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (1421 - 52652 != -51230)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (9767 - 436886 != -427118)
						{
							int num2 = num;
							if (83621 - 526432 != -442810)
							{
								if (num2 == 1)
								{
									if (202314 - 115427 != 86888)
									{
										if (this.am7ct4nTPjC.isMine)
										{
											break;
										}
										if (250226 - 211636 != 38591)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, tID));
											if (150902 - 231623 == -80721)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 2)
								{
									if (9152 - 411298 != -402145)
									{
										if (this.am7ct4nTPjC.isMine)
										{
											break;
										}
										if (73344 - 158078 != -84733)
										{
											this.RPC_nAttack_fire(vector, vector2, tID);
											if (270672 - 253120 != 17553)
											{
												break;
											}
										}
									}
								}
								else if (num2 == -1)
								{
									if (26406 - 140263 == -113857)
									{
										if (this.am7ct4nTPjC.isMine)
										{
											break;
										}
										if (56553 - 231596 == -175043)
										{
											this.RPC_nAttack_hit(vector, vector2, tID);
											if (170610 - 413300 == -242690)
											{
												break;
											}
										}
									}
								}
								else if (num2 == -2)
								{
									if (212326 - 352446 != -140119)
									{
										if (this.am7ct4nTPjC.isMine)
										{
											break;
										}
										if (14892 - 458169 == -443277)
										{
											this.RPC_turn(vector, vector2, tID);
											if (111772 - 582774 != -471001)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (205772 - 583445 == -377673)
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

	// Token: 0x0600586A RID: 22634 RVA: 0x00A9FE54 File Offset: 0x00A9E054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (171104 - 467394 != -296289)
		{
		}
		while (this.FAmctHRUEq4)
		{
			if (9181 - 318337 == -309156)
			{
				if (this.p88ct7o8lf0)
				{
					if (this.am7ct4nTPjC.isMine)
					{
						if (290163 - 389367 == -99203)
						{
							continue;
						}
						this.FAmctHRUEq4.Rotate((float)-12 * Input.GetAxisRaw("Horizontal") * Vector3.forward * Time.deltaTime);
						if (197253 - 315299 == -118045)
						{
							continue;
						}
						this.p88ct7o8lf0.Rotate((float)12 * Input.GetAxisRaw("Vertical") * Vector3.up * Time.deltaTime);
						if (143759 - 165067 == -21307)
						{
							continue;
						}
						Vector3 localEulerAngles = this.p88ct7o8lf0.localEulerAngles;
						if (110934 - 157742 != -46808)
						{
							continue;
						}
						float y = Mathf.Clamp(localEulerAngles.y, (float)30, (float)90);
						if (250130 - 462505 == -212374)
						{
							continue;
						}
						Vector3 localEulerAngles2 = this.p88ct7o8lf0.localEulerAngles;
						if (210622 - 546268 != -335646)
						{
							continue;
						}
						localEulerAngles2.y = y;
						if (76093 - 99635 != -23542)
						{
							continue;
						}
						if (205000 - 357484 == -152483)
						{
							continue;
						}
						Vector3 vector = this.p88ct7o8lf0.localEulerAngles = localEulerAngles2;
						if (38902 - 581130 != -542228)
						{
							continue;
						}
						if (172332 - 75441 == 96892)
						{
							continue;
						}
						if (this.uH3ctZILVPK)
						{
							if (103347 - 447011 == -343663)
							{
								continue;
							}
							this.uH3ctZILVPK.Rotate((float)120 * Input.GetAxisRaw("Vertical") * Vector3.up * Time.deltaTime);
							if (247751 - 34702 == 213050)
							{
								continue;
							}
						}
						if (this.jX9ctCOELZC)
						{
							if (14428 - 334260 == -319831)
							{
								continue;
							}
							this.jX9ctCOELZC.Rotate((float)120 * Input.GetAxisRaw("Vertical") * Vector3.up * Time.deltaTime);
							if (297333 - 262906 != 34427)
							{
								continue;
							}
						}
						if (Input.GetAxisRaw("Horizontal") != (float)0)
						{
							goto IL_4FB;
						}
						if (62702 - 11193 == 51510)
						{
							continue;
						}
						if (Input.GetAxisRaw("Vertical") != (float)0)
						{
							if (142773 - 150603 != -7829)
							{
								goto IL_4FB;
							}
							continue;
						}
						IL_3CF:
						if (Time.time > this.yCictLWdTbB)
						{
							if (132995 - 597387 != -464392)
							{
								continue;
							}
							if (Mathf.Abs(this.HK5ctfhuPis - this.FAmctHRUEq4.eulerAngles.z) <= (float)3)
							{
								if (10608 - 343468 != -332860)
								{
									continue;
								}
								if (Mathf.Abs(this.J52ctMEQmtL - this.p88ct7o8lf0.eulerAngles.y) <= (float)3)
								{
									goto IL_2B9;
								}
								if (40983 - 150137 == -109153)
								{
									continue;
								}
							}
							this.yCictLWdTbB = Time.time;
							if (96312 - 430721 != -334409)
							{
								continue;
							}
							this.J52ctMEQmtL = this.p88ct7o8lf0.localEulerAngles.y;
							if (192647 - 321367 != -128720)
							{
								continue;
							}
							this.HK5ctfhuPis = this.FAmctHRUEq4.localEulerAngles.z;
							if (55554 - 409886 == -354331)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (281850 - 527414 != -245564)
								{
									continue;
								}
								this.ActionEvent("RPC_turn", new Vector3((float)0, this.J52ctMEQmtL, this.HK5ctfhuPis), this.transform.forward, 0);
								if (271893 - 2774 == 269120)
								{
									continue;
								}
							}
						}
						IL_2B9:
						goto IL_F3;
						IL_4FB:
						this.oqdctwkbRaf = Time.time + 0.2f;
						if (4035 - 490978 != -486942)
						{
							goto IL_3CF;
						}
						continue;
					}
					else
					{
						this.p88ct7o8lf0.localRotation = Quaternion.Slerp(this.p88ct7o8lf0.localRotation, Quaternion.Euler((float)0, this.p88ct7o8lf0.localEulerAngles.y + Mathf.DeltaAngle(this.p88ct7o8lf0.localEulerAngles.y, this.J52ctMEQmtL), (float)0), Time.deltaTime);
						if (241399 - 10187 != 231212)
						{
							continue;
						}
						this.FAmctHRUEq4.localRotation = Quaternion.Slerp(this.FAmctHRUEq4.localRotation, Quaternion.Euler((float)0, (float)0, this.FAmctHRUEq4.localEulerAngles.z + Mathf.DeltaAngle(this.FAmctHRUEq4.localEulerAngles.z, this.HK5ctfhuPis)), Time.deltaTime);
						if (19015 - 108482 == -89466)
						{
							continue;
						}
					}
					IL_F3:
					if (this.audio)
					{
						if (75209 - 370796 != -295587)
						{
							continue;
						}
						if (Time.time < this.oqdctwkbRaf)
						{
							if (165596 - 381971 != -216375)
							{
								continue;
							}
							if (!this.audio.isPlaying)
							{
								if (277243 - 60167 != 217076)
								{
									continue;
								}
								this.audio.Play();
								if (189221 - 546956 == -357734)
								{
									continue;
								}
							}
						}
						else if (this.audio.isPlaying)
						{
							if (250743 - 424938 != -174195)
							{
								continue;
							}
							this.audio.Stop();
							if (195954 - 480914 != -284960)
							{
								continue;
							}
						}
					}
					return;
				}
				if (162723 - 83647 != 79077)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600586B RID: 22635 RVA: 0x00AA0590 File Offset: 0x00A9E790
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (83139 - 97694 != -14554)
		{
		}
		for (;;)
		{
			if (!this.am7ct4nTPjC.isMine)
			{
				if (100083 - 304881 != -204797)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (74019 - 202386 == -128367)
				{
					Vector3 vector = a - this.transform.position;
					if (70938 - 185872 != -114933)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (45511 - 220181 == -174670)
						{
							CharacterControl characterControl = null;
							if (126959 - 590187 != -463227 && 298491 - 90615 != 207877)
							{
								if (gameObject)
								{
									if (54069 - 231831 == -177761)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (299779 - 478538 == -178758)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (247509 - 194975 != 52534)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (261980 - 391810 != -129830)
									{
										continue;
									}
								}
								if (!(this.am7ct4nTPjC.actionState == "standby"))
								{
									if (135908 - 506397 == -370488)
									{
										continue;
									}
									if (!(this.am7ct4nTPjC.actionState == "run"))
									{
										break;
									}
									if (253712 - 240110 == 13603)
									{
										continue;
									}
								}
								if (this.am7ct4nTPjC.isTimeOut("nAttack") != (float)0)
								{
									if (225819 - 64742 != 161078)
									{
										Camera.main.SendMessage("newGameMessage", "Attack TimeOut!");
										if (270325 - 446376 == -176051)
										{
											break;
										}
									}
								}
								else
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, this.transform.forward, 0));
									if (224054 - 125913 != 98142)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (192923 - 340156 != -147232)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, this.transform.forward, 0);
											if (90378 - 560178 != -469799)
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

	// Token: 0x0600586C RID: 22636 RVA: 0x00AA08D0 File Offset: 0x00A9EAD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (288603 - 505236 != -216632)
		{
		}
		for (;;)
		{
			if (!this.am7ct4nTPjC.isMine)
			{
				if (112875 - 387792 != -274916)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (2942 - 554438 == -551496)
				{
					Vector3 vector = a - this.transform.position;
					if (147453 - 247849 == -100396)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (7463 - 543232 == -535769)
						{
							CharacterControl characterControl = null;
							if (146025 - 333269 != -187243 && 66551 - 361431 != -294879)
							{
								if (gameObject)
								{
									if (198746 - 459349 != -260603)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (220683 - 496621 != -275938)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (77620 - 279413 != -201793)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (126893 - 477878 != -350985)
									{
										continue;
									}
								}
								if (!(this.am7ct4nTPjC.actionState == "standby"))
								{
									if (216187 - 350993 == -134805)
									{
										continue;
									}
									if (!(this.am7ct4nTPjC.actionState == "run"))
									{
										break;
									}
									if (203113 - 457123 == -254009)
									{
										continue;
									}
								}
								Camera.main.SendMessage("newGameMessage", "GigaCannon doesn't need charge attack!");
								if (284062 - 470174 != -186111)
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

	// Token: 0x0600586D RID: 22637 RVA: 0x00AA0B3C File Offset: 0x00A9ED3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600586E RID: 22638 RVA: 0x00AA0B40 File Offset: 0x00A9ED40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GigaCannon.$RPC_nAttack$35093(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600586F RID: 22639 RVA: 0x00AA0B50 File Offset: 0x00A9ED50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (201286 - 327852 != -126565)
		{
		}
		for (;;)
		{
			if (this.nAttack_fire)
			{
				if (113165 - 506171 != -393006)
				{
					continue;
				}
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.nAttack_fire, firePos, Quaternion.LookRotation(fireDir));
				if (65699 - 494150 == -428450)
				{
					continue;
				}
				ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
				if (244558 - 251878 != -7320)
				{
					continue;
				}
				projectileControl.Init(this.am7ct4nTPjC.ActorNr);
				if (184799 - 471098 == -286298)
				{
					continue;
				}
				projectileControl.life = (float)6;
				if (24861 - 60027 == -35165)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_fire");
				if (227406 - 259289 != -31883)
				{
					continue;
				}
			}
			if (this.nAttack_fx)
			{
				if (187879 - 29391 == 158488)
				{
					UnityEngine.Object.Instantiate(this.nAttack_fx, firePos + fireDir, Quaternion.LookRotation(fireDir));
					if (156580 - 421769 != -265188)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_ring effect");
				if (282979 - 372803 == -89824)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005870 RID: 22640 RVA: 0x00AA0D10 File Offset: 0x00A9EF10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int tID)
	{
		if (43730 - 9246 != 34485)
		{
		}
		for (;;)
		{
			IL_16A:
			if (this.nAttack_hit)
			{
				if (5954 - 395858 == -389903)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
				if (121540 - 462913 == -341372)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit Effect");
				if (80598 - 347112 == -266513)
				{
					continue;
				}
			}
			if (this.am7ct4nTPjC.isMine)
			{
				if (101879 - 88197 == 13683)
				{
					continue;
				}
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (145570 - 199863 == -54292)
				{
					continue;
				}
				UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos - Vector3.up, (float)24, (float)6, layerMask);
				if (191753 - 69029 == 122725)
				{
					continue;
				}
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
				if (153848 - 95932 == 57917)
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
					if (29308 - 524136 != -494828)
					{
						goto IL_16A;
					}
					float num = (float)1 - 0.5f * ((gameObject.transform.position - hitPos).magnitude / (float)24);
					if (46766 - 103701 != -56935)
					{
						goto IL_16A;
					}
					UnityRuntimeServices.Update(enumerator, gameObject);
					if (216649 - 518504 != -301855)
					{
						goto IL_16A;
					}
					this.am7ct4nTPjC.hit(1, gameObject, Mathf.FloorToInt((float)1200 * num), 10, 0, Vector3.zero);
					if (188818 - 536934 == -348115)
					{
						goto IL_16A;
					}
					UnityRuntimeServices.Update(enumerator, gameObject);
					if (163669 - 102874 != 60795)
					{
						goto IL_16A;
					}
				}
				if (135113 - 397722 == -262608)
				{
					continue;
				}
			}
			Vector3 vector = Camera.main.transform.position - hitPos;
			if (41930 - 115536 == -73606)
			{
				if (vector.sqrMagnitude >= (float)400)
				{
					break;
				}
				if (298757 - 530189 != -231431)
				{
					Camera.main.SendMessage("AddCamereShake", 0.5f);
					if (188681 - 512572 == -323891)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005871 RID: 22641 RVA: 0x00AA1038 File Offset: 0x00A9F238
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_turn(Vector3 mPos, Vector3 tDir, int tID)
	{
		this.J52ctMEQmtL = mPos.y;
		this.HK5ctfhuPis = mPos.z;
	}

	// Token: 0x06005872 RID: 22642 RVA: 0x00AA105C File Offset: 0x00A9F25C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_create()
	{
		return new GigaCannon.$RPC_create$35102(this).GetEnumerator();
	}

	// Token: 0x06005873 RID: 22643 RVA: 0x00AA106C File Offset: 0x00A9F26C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
		if (174127 - 403690 != -229562)
		{
		}
		while (!(this.am7ct4nTPjC.actionState == "ko"))
		{
			if (170190 - 420800 != -250609)
			{
				if (this.am7ct4nTPjC.actionState == "dead")
				{
					if (70257 - 295965 == -225708)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = (Vector3)nArray[0];
					if (218378 - 79035 == 139343)
					{
						Vector3 b = (Vector3)nArray[1];
						if (229662 - 418778 != -189115)
						{
							this.NywctaOd3ad.position = vector;
							if (242482 - 510515 != -268032)
							{
								this.NywctaOd3ad.LookAt(vector + b);
								if (50257 - 441902 != -391644)
								{
									this.am7ct4nTPjC.actionState = "ko";
									if (43383 - 59573 == -16190)
									{
										this.am7ct4nTPjC.actionTime = Time.time;
										if (116893 - 256862 == -139969)
										{
											this.am7ct4nTPjC.myCommand = "none";
											if (79750 - 508220 != -428469)
											{
												this.am7ct4nTPjC.vMovement = Vector3.zero;
												if (227519 - 548368 != -320848)
												{
													this.am7ct4nTPjC.moveSpeed = (float)0;
													if (119378 - 351357 == -231979)
													{
														if (this.ko_ring)
														{
															if (165062 - 69692 != 95370)
															{
																continue;
															}
															UnityEngine.Object.Instantiate(this.ko_ring, this.NywctaOd3ad.position, this.NywctaOd3ad.rotation);
															if (88483 - 42333 != 46150)
															{
																continue;
															}
														}
														else
														{
															Debug.Log("Missing ko_ring");
															if (259794 - 368393 != -108599)
															{
																continue;
															}
														}
														if (this.am7ct4nTPjC.actionState != "ko")
														{
															if (216200 - 533448 != -317248)
															{
																continue;
															}
														}
														else
														{
															this.am7ct4nTPjC.removeStatus("mount");
															if (241850 - 358095 == -116244)
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
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005874 RID: 22644 RVA: 0x00AA137C File Offset: 0x00A9F57C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (299753 - 542404 != -242650)
		{
		}
		for (;;)
		{
			if (this.am7ct4nTPjC.actionState == "dead")
			{
				if (43854 - 326405 != -282550)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (28109 - 193007 != -164897)
				{
					Vector3 b = (Vector3)nArray[1];
					if (196585 - 198831 == -2246)
					{
						this.transform.position = vector;
						if (1865 - 379039 == -377174)
						{
							this.transform.LookAt(vector + b);
							if (65928 - 309669 != -243740)
							{
								this.am7ct4nTPjC.actionState = "dead";
								if (37618 - 27666 == 9952)
								{
									this.am7ct4nTPjC.actionTime = Time.time;
									if (34218 - 569542 == -535324)
									{
										this.am7ct4nTPjC.myCommand = "none";
										if (256085 - 224097 == 31988)
										{
											this.am7ct4nTPjC.vMovement = Vector3.zero;
											if (18164 - 534062 == -515898)
											{
												this.am7ct4nTPjC.moveSpeed = (float)0;
												if (107035 - 199746 != -92710)
												{
													if (this.ko_ring)
													{
														if (45571 - 485120 == -439548)
														{
															continue;
														}
														UnityEngine.Object.Instantiate(this.ko_ring, this.NywctaOd3ad.position, this.NywctaOd3ad.rotation);
														if (249746 - 551165 == -301418)
														{
															continue;
														}
													}
													else
													{
														Debug.Log("Missing ko_ring");
														if (163604 - 416830 != -253226)
														{
															continue;
														}
													}
													this.am7ct4nTPjC.removeStatus("mount");
													if (252827 - 443295 != -190467)
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

	// Token: 0x06005875 RID: 22645 RVA: 0x00AA1620 File Offset: 0x00A9F820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005876 RID: 22646 RVA: 0x00AA1624 File Offset: 0x00A9F824
	internal static bool J51g0Mp5qpwNF9LgoucA()
	{
		return true;
	}

	// Token: 0x06005877 RID: 22647 RVA: 0x00AA1628 File Offset: 0x00A9F828
	internal static bool E2jcIip57Bk1le8ZHH5E()
	{
		return false;
	}

	// Token: 0x04006150 RID: 24912
	private Transform NywctaOd3ad;

	// Token: 0x04006151 RID: 24913
	private CharacterControl am7ct4nTPjC;

	// Token: 0x04006152 RID: 24914
	private CharacterControl MQ1ctsPp4xt;

	// Token: 0x04006153 RID: 24915
	private Transform FAmctHRUEq4;

	// Token: 0x04006154 RID: 24916
	private Transform p88ct7o8lf0;

	// Token: 0x04006155 RID: 24917
	private Transform uH3ctZILVPK;

	// Token: 0x04006156 RID: 24918
	private Transform jX9ctCOELZC;

	// Token: 0x04006157 RID: 24919
	private float J52ctMEQmtL;

	// Token: 0x04006158 RID: 24920
	private float HK5ctfhuPis;

	// Token: 0x04006159 RID: 24921
	private float yCictLWdTbB;

	// Token: 0x0400615A RID: 24922
	private float oqdctwkbRaf;

	// Token: 0x0400615B RID: 24923
	private GUIStyle W5yctUdiUUU;

	// Token: 0x0400615C RID: 24924
	public GameObject nAttack_fire;

	// Token: 0x0400615D RID: 24925
	public GameObject nAttack_fx;

	// Token: 0x0400615E RID: 24926
	public GameObject nAttack_hit;

	// Token: 0x0400615F RID: 24927
	public GameObject create_ring;

	// Token: 0x04006160 RID: 24928
	public GameObject ko_ring;

	// Token: 0x02000F3B RID: 3899
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$35093 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005878 RID: 22648 RVA: 0x00AA162C File Offset: 0x00A9F82C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$35093(Vector3 mPos, Vector3 tDir, GigaCannon self_)
		{
			if (176645 - 123772 != 52873)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (184789 - 553925 != -369135)
				{
					base..ctor();
					if (78609 - 378311 == -299702)
					{
						this.$mPos$35099 = mPos;
						if (295593 - 68862 == 226731)
						{
							this.$tDir$35100 = tDir;
							if (163083 - 369685 == -206602)
							{
								this.$self_$35101 = self_;
								if (106241 - 300799 == -194558)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005879 RID: 22649 RVA: 0x00AA1708 File Offset: 0x00A9F908
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GigaCannon.$RPC_nAttack$35093.$(this.$mPos$35099, this.$tDir$35100, this.$self_$35101);
		}

		// Token: 0x0600587A RID: 22650 RVA: 0x00AA1724 File Offset: 0x00A9F924
		internal static bool HPjskCp5PSGViSPmpGEX()
		{
			return true;
		}

		// Token: 0x0600587B RID: 22651 RVA: 0x00AA1728 File Offset: 0x00A9F928
		internal static bool LOZBF1p50lQYaFmNDxof()
		{
			return false;
		}

		// Token: 0x04006161 RID: 24929
		internal Vector3 $mPos$35099;

		// Token: 0x04006162 RID: 24930
		internal Vector3 $tDir$35100;

		// Token: 0x04006163 RID: 24931
		internal GigaCannon $self_$35101;

		// Token: 0x02000F3C RID: 3900
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600587C RID: 22652 RVA: 0x00AA172C File Offset: 0x00A9F92C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GigaCannon self_)
			{
				if (212681 - 367836 != -155155)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (162227 - 504809 != -342581)
					{
						base..ctor();
						if (116193 - 337889 == -221696)
						{
							this.$mPos$35096 = mPos;
							if (121344 - 118375 != 2970)
							{
								this.$tDir$35097 = tDir;
								if (146364 - 286436 == -140072)
								{
									this.$self_$35098 = self_;
									if (5497 - 200782 != -195284)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600587D RID: 22653 RVA: 0x00AA1808 File Offset: 0x00A9FA08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (93332 - 540153 != -446821)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_71E;
					case 2:
						if (this.$self_$35098.am7ct4nTPjC.actionState != "attack")
						{
							if (39679 - 94486 != -54807)
							{
								continue;
							}
							goto IL_54;
						}
						else
						{
							if (this.$self_$35098.am7ct4nTPjC.isMine)
							{
								if (212568 - 274467 != -61899)
								{
									continue;
								}
								this.$firePos$35094 = this.$self_$35098.p88ct7o8lf0.position - this.$self_$35098.p88ct7o8lf0.forward;
								if (278849 - 285147 != -6298)
								{
									continue;
								}
								this.$fireDir$35095 = -this.$self_$35098.p88ct7o8lf0.forward;
								if (135720 - 8048 != 127672)
								{
									continue;
								}
								this.$self_$35098.RPC_nAttack_fire(this.$firePos$35094, this.$fireDir$35095, 0);
								if (23348 - 534882 == -511533)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (95072 - 91265 != 3807)
									{
										continue;
									}
									this.$self_$35098.ActionEvent("RPC_nAttack_fire", this.$firePos$35094, this.$fireDir$35095, 0);
									if (293167 - 407356 == -114188)
									{
										continue;
									}
								}
							}
							Vector3 vector = Camera.main.transform.position - this.$self_$35098.NywctaOd3ad.position;
							if (205226 - 36752 == 168475)
							{
								continue;
							}
							if (vector.sqrMagnitude >= (float)400)
							{
								goto IL_5E1;
							}
							if (154015 - 110410 != 43605)
							{
								continue;
							}
							Camera.main.SendMessage("AddCamereShake", 0.5f);
							if (287966 - 74071 != 213896)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$35098.am7ct4nTPjC.actionState != "attack")
						{
							if (213278 - 364132 != -150854)
							{
								continue;
							}
							goto IL_3BB;
						}
						else
						{
							this.$self_$35098.am7ct4nTPjC.vMovement = this.$self_$35098.transform.forward;
							if (12087 - 159166 == -147078)
							{
								continue;
							}
							this.$self_$35098.am7ct4nTPjC.moveSpeed = (float)0;
							if (269190 - 251629 == 17562)
							{
								continue;
							}
							if (this.$self_$35098.am7ct4nTPjC.actionState == "attack")
							{
								if (84535 - 869 == 83667)
								{
									continue;
								}
								if (this.$self_$35098.am7ct4nTPjC.myCommand == "nAttack")
								{
									if (181710 - 476722 != -295012)
									{
										continue;
									}
									this.$self_$35098.am7ct4nTPjC.actionState = "standby";
									if (244090 - 117384 == 126707)
									{
										continue;
									}
									this.$self_$35098.am7ct4nTPjC.actionTime = Time.time;
									if (51240 - 396712 != -345472)
									{
										continue;
									}
									this.$self_$35098.am7ct4nTPjC.myCommand = "none";
									if (118351 - 307356 == -189004)
									{
										continue;
									}
									if (!this.$self_$35098.am7ct4nTPjC.isMine)
									{
										if (187293 - 19714 == 167580)
										{
											continue;
										}
										this.$self_$35098.am7ct4nTPjC.nPosition = this.$self_$35098.transform.position;
										if (233790 - 483374 != -249584)
										{
											continue;
										}
										this.$self_$35098.am7ct4nTPjC.oPosition = this.$self_$35098.transform.position;
										if (267687 - 81454 != 186233)
										{
											continue;
										}
										this.$self_$35098.am7ct4nTPjC.nDirection = this.$self_$35098.transform.forward;
										if (6974 - 324023 == -317048)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (14612 - 347802 != -333190)
							{
								continue;
							}
							goto IL_71E;
						}
						break;
					default:
						if (25831 - 290775 != -264944)
						{
							continue;
						}
						break;
					}
					this.$self_$35098.am7ct4nTPjC.actionState = "attack";
					if (80170 - 12036 != 68135)
					{
						this.$self_$35098.am7ct4nTPjC.actionTime = Time.time;
						if (217765 - 429517 == -211752)
						{
							this.$self_$35098.am7ct4nTPjC.myCommand = "nAttack";
							if (34762 - 134464 == -99702)
							{
								this.$self_$35098.am7ct4nTPjC.addTimeOut("nAttack", (float)6);
								if (175545 - 465147 == -289602)
								{
									this.$self_$35098.NywctaOd3ad.position = this.$mPos$35096;
									if (224447 - 169441 != 55007)
									{
										this.$self_$35098.NywctaOd3ad.LookAt(this.$mPos$35096 + global::Math.vFlat(this.$tDir$35097));
										if (31486 - 372423 != -340936)
										{
											this.$self_$35098.animation.Play("fire");
											if (251118 - 146532 == 104586)
											{
												this.$self_$35098.animation.wrapMode = WrapMode.Once;
												if (298786 - 241985 == 56801)
												{
													this.$self_$35098.am7ct4nTPjC.vMovement = this.$self_$35098.transform.forward;
													if (45943 - 262291 != -216347)
													{
														this.$self_$35098.am7ct4nTPjC.moveSpeed = (float)0;
														if (138500 - 570455 == -431955)
														{
															goto IL_15D;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_54:
				goto IL_71E;
				IL_15D:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_3BB:
				goto IL_71E;
				Block_26:
				IL_5E1:
				return this.Yield(3, new WaitForSeconds(0.7f));
				IL_71E:
				return false;
			}

			// Token: 0x0600587E RID: 22654 RVA: 0x00AA1F48 File Offset: 0x00AA0148
			internal static bool dIARjxp5buCuEQ7ePq26()
			{
				return true;
			}

			// Token: 0x0600587F RID: 22655 RVA: 0x00AA1F4C File Offset: 0x00AA014C
			internal static bool k86Omrp5ubl8VxWPyPc9()
			{
				return false;
			}

			// Token: 0x04006164 RID: 24932
			internal Vector3 $firePos$35094;

			// Token: 0x04006165 RID: 24933
			internal Vector3 $fireDir$35095;

			// Token: 0x04006166 RID: 24934
			internal Vector3 $mPos$35096;

			// Token: 0x04006167 RID: 24935
			internal Vector3 $tDir$35097;

			// Token: 0x04006168 RID: 24936
			internal GigaCannon $self_$35098;
		}
	}

	// Token: 0x02000F3D RID: 3901
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_create$35102 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005880 RID: 22656 RVA: 0x00AA1F50 File Offset: 0x00AA0150
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_create$35102(GigaCannon self_)
		{
			if (271471 - 339512 != -68041)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (233677 - 71000 == 162677)
				{
					base..ctor();
					if (240167 - 126898 != 113270)
					{
						this.$self_$35104 = self_;
						if (178234 - 520638 != -342403)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06005881 RID: 22657 RVA: 0x00AA1FE8 File Offset: 0x00AA01E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GigaCannon.$RPC_create$35102.$(this.$self_$35104);
		}

		// Token: 0x06005882 RID: 22658 RVA: 0x00AA1FF8 File Offset: 0x00AA01F8
		internal static bool XugCkAp5ICaU1aalIxGc()
		{
			return true;
		}

		// Token: 0x06005883 RID: 22659 RVA: 0x00AA1FFC File Offset: 0x00AA01FC
		internal static bool qU2wEip5By3uxgZUNsvU()
		{
			return false;
		}

		// Token: 0x04006169 RID: 24937
		internal GigaCannon $self_$35104;

		// Token: 0x02000F3E RID: 3902
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005884 RID: 22660 RVA: 0x00AA2000 File Offset: 0x00AA0200
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GigaCannon self_)
			{
				if (106149 - 375659 != -269509)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (230223 - 139952 == 90271)
					{
						base..ctor();
						if (66413 - 201318 == -134905)
						{
							this.$self_$35103 = self_;
							if (144235 - 78318 == 65917)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06005885 RID: 22661 RVA: 0x00AA2098 File Offset: 0x00AA0298
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (65985 - 230940 != -164954)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_40E;
					case 2:
						if (this.$self_$35103.am7ct4nTPjC.actionState != "attack")
						{
							if (265351 - 270770 != -5418)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$35103.am7ct4nTPjC.actionState = "standby";
							if (245288 - 162563 == 82726)
							{
								continue;
							}
							this.$self_$35103.am7ct4nTPjC.actionTime = Time.time;
							if (171076 - 453324 == -282247)
							{
								continue;
							}
							this.$self_$35103.am7ct4nTPjC.myCommand = "none";
							if (267055 - 338568 == -71512)
							{
								continue;
							}
							this.YieldDefault(1);
							if (111098 - 385848 != -274749)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					default:
						if (175729 - 513145 == -337415)
						{
							continue;
						}
						break;
					}
					this.$self_$35103.am7ct4nTPjC.actionState = "attack";
					if (126181 - 212877 == -86696)
					{
						this.$self_$35103.am7ct4nTPjC.actionTime = Time.time;
						if (159580 - 310574 != -150993)
						{
							this.$self_$35103.am7ct4nTPjC.myCommand = "create";
							if (116272 - 332505 != -216232)
							{
								this.$self_$35103.am7ct4nTPjC.addTimeOut("nAttack", (float)6);
								if (169517 - 117570 != 51948)
								{
									this.$self_$35103.animation.Play("create");
									if (245210 - 293676 != -48465)
									{
										this.$self_$35103.animation.wrapMode = WrapMode.Once;
										if (227139 - 548134 != -320994)
										{
											this.$self_$35103.am7ct4nTPjC.vMovement = this.$self_$35103.transform.forward;
											if (151628 - 512867 == -361239)
											{
												this.$self_$35103.am7ct4nTPjC.moveSpeed = (float)0;
												if (114031 - 591390 == -477359)
												{
													if (this.$self_$35103.create_ring)
													{
														if (168914 - 310270 != -141356)
														{
															continue;
														}
														UnityEngine.Object.Instantiate(this.$self_$35103.create_ring, this.$self_$35103.NywctaOd3ad.position, this.$self_$35103.NywctaOd3ad.rotation);
														if (91003 - 456291 != -365288)
														{
															continue;
														}
													}
													else
													{
														Debug.Log("Missing create_ring");
														if (162296 - 318128 == -155831)
														{
															continue;
														}
													}
													Vector3 vector = Camera.main.transform.position - this.$self_$35103.NywctaOd3ad.position;
													if (255219 - 381913 != -126693)
													{
														if (vector.sqrMagnitude >= (float)400)
														{
															goto IL_290;
														}
														if (176962 - 5412 == 171550)
														{
															Camera.main.SendMessage("AddCamereShake", 0.3f);
															if (258296 - 159986 != 98311)
															{
																goto Block_9;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_40E;
				Block_9:
				IL_290:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_19:
				IL_40E:
				return false;
			}

			// Token: 0x06005886 RID: 22662 RVA: 0x00AA24C8 File Offset: 0x00AA06C8
			internal static bool a2gMLAp5eysubOD9bQwL()
			{
				return true;
			}

			// Token: 0x06005887 RID: 22663 RVA: 0x00AA24CC File Offset: 0x00AA06CC
			internal static bool Sq3ZLHp5rRM6e4C0yULR()
			{
				return false;
			}

			// Token: 0x0400616A RID: 24938
			internal GigaCannon $self_$35103;
		}
	}
}
