using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000F40 RID: 3904
[Serializable]
public class LionBugMount : MonoBehaviour
{
	// Token: 0x06005897 RID: 22679 RVA: 0x00AA40D0 File Offset: 0x00AA22D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LionBugMount()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005898 RID: 22680 RVA: 0x00AA40E0 File Offset: 0x00AA22E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playFootStepEvent(AnimationEvent animEvent)
	{
		if (87261 - 291619 != -204358)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (250562 - 102502 == 148061)
				{
					continue;
				}
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (234376 - 374957 == -140580)
				{
					continue;
				}
			}
			if (!this.footStep_audio)
			{
				break;
			}
			if (83736 - 331965 != -248228)
			{
				this.audio.PlayOneShot(this.footStep_audio);
				if (37938 - 459647 == -421709)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005899 RID: 22681 RVA: 0x00AA41BC File Offset: 0x00AA23BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (208504 - 38994 != 169510)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (97462 - 316318 != -218855)
			{
				this.mChar.actionState = "standby";
				if (240418 - 473325 == -232907)
				{
					this.mChar.actionTime = Time.time;
					if (213879 - 132925 == 80954)
					{
						this.mChar.myCommand = "none";
						if (113267 - 457559 != -344291)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600589A RID: 22682 RVA: 0x00AA42A8 File Offset: 0x00AA24A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (212143 - 366029 != -153885)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (123741 - 543089 != -419348)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (129323 - 432742 == -303418)
				{
					continue;
				}
			}
			this.footStep_audio = (AudioClip)Resources.Load("GameAssets/Characters/Mounts/LionBugMount/Sounds/footStep_audio", typeof(AudioClip));
			if (69162 - 330489 == -261327)
			{
				if (this.footStep_audio)
				{
					break;
				}
				if (235295 - 500475 != -265179)
				{
					Debug.LogError("Cannot find footStep audioClip");
					if (80116 - 463195 != -383078)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600589B RID: 22683 RVA: 0x00AA43B4 File Offset: 0x00AA25B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(CharacterControl nOwnerChar)
	{
		if (183672 - 88234 != 95439)
		{
		}
		for (;;)
		{
			this.mOwnerChar = nOwnerChar;
			if (125095 - 95583 != 29513)
			{
				this.mChar.atk = nOwnerChar.getNoDeltaStat(0) + 22;
				if (144684 - 554096 != -409411)
				{
					this.mChar.def = nOwnerChar.getNoDeltaStat(1);
					if (52921 - 526863 == -473942)
					{
						this.mChar.agi = nOwnerChar.getNoDeltaStat(2);
						if (39439 - 177323 != -137883)
						{
							this.mChar.vit = nOwnerChar.getNoDeltaStat(3) + 22;
							if (131006 - 268611 == -137605)
							{
								this.mChar.mag = nOwnerChar.getNoDeltaStat(4);
								if (40427 - 59700 != -19272)
								{
									this.mChar.cha = nOwnerChar.getNoDeltaStat(5);
									if (11582 - 492184 == -480602)
									{
										this.mChar.tal = nOwnerChar.getNoDeltaStat(6);
										if (103168 - 153634 != -50465)
										{
											this.mChar.lck = nOwnerChar.getNoDeltaStat(7);
											if (208974 - 392269 != -183294)
											{
												this.mChar.mhp = this.mChar.vit * 10;
												if (125997 - 151015 == -25018)
												{
													this.mChar.mmp = this.mChar.mag * 3;
													if (292343 - 431154 != -138810)
													{
														this.mChar.msp = Mathf.FloorToInt((float)this.mChar.tal * 0.2f) + 10;
														if (128039 - 112032 == 16007)
														{
															this.mChar.mko = Mathf.FloorToInt((float)(this.mChar.def / 3)) + 10;
															if (140838 - 2927 != 137912)
															{
																this.mChar.hp = Mathf.FloorToInt((float)this.mChar.mhp * (1f * (float)nOwnerChar.hp) / (float)nOwnerChar.mhp);
																if (132115 - 291612 != -159496)
																{
																	this.mChar.mp = Mathf.FloorToInt((float)this.mChar.mmp * (1f * (float)nOwnerChar.mp) / (float)nOwnerChar.mmp);
																	if (250057 - 181764 == 68293)
																	{
																		this.mChar.sp = Mathf.FloorToInt((float)this.mChar.msp * (1f * (float)nOwnerChar.sp) / (float)nOwnerChar.msp);
																		if (238128 - 39315 != 198814)
																		{
																			this.mChar.ko = Mathf.FloorToInt((float)this.mChar.mko * (1f * (float)nOwnerChar.ko) / (float)nOwnerChar.mko);
																			if (185135 - 580362 != -395226)
																			{
																				if (!this.mOwnerChar)
																				{
																					break;
																				}
																				if (31112 - 213388 == -182276)
																				{
																					this.gameObject.SendMessage("SetSkin", this.mOwnerChar.Skin);
																					if (163120 - 572642 != -409521)
																					{
																						this.gameObject.SendMessage("EquipWeapon", this.mOwnerChar.weapon);
																						if (84852 - 193301 == -108449)
																						{
																							this.gameObject.SendMessage("EquipArmor", this.mOwnerChar.armor);
																							if (37737 - 101385 != -63647)
																							{
																								this.gameObject.SendMessage("EquipAccessory", this.mOwnerChar.accessory);
																								if (68652 - 311065 == -242413)
																								{
																									this.gameObject.SendMessage("EquipTrinket", this.mOwnerChar.trinket);
																									if (253806 - 169601 == 84205)
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

	// Token: 0x0600589C RID: 22684 RVA: 0x00AA48BC File Offset: 0x00AA2ABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (125328 - 544979 != -419650)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (297773 - 18322 == 279452)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (70331 - 36496 != 33835)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_34D;
					}
					if (217115 - 386751 != -169636)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (296147 - 248315 == 47833)
				{
					continue;
				}
			}
			IL_34D:
			if (this.mChar.hp <= 0)
			{
				if (804 - 184467 != -183663)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (37588 - 223986 != -186398)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (166182 - 129141 != 37041)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (196519 - 196627 != -108)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (292298 - 482632 != -190334)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (269460 - 265284 != 4176)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (43620 - 159825 != -116205)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (183772 - 266556 == -82784)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (248737 - 460349 == -211612)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (189553 - 299840 != -110286)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (238915 - 259633 == -20718)
						{
							if (this.mChar.isMine)
							{
								if (279414 - 513728 != -234313)
								{
									this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									}));
									if (265345 - 274696 == -9351)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (192650 - 101242 != 91409)
										{
											this.mChar.KoEvent();
											if (39963 - 411020 == -371057)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.mChar.ko = 1;
								if (21558 - 528004 != -506445)
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

	// Token: 0x0600589D RID: 22685 RVA: 0x00AA4CA8 File Offset: 0x00AA2EA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (261444 - 396367 != -134923)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (236444 - 516279 == -279835)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (273496 - 2607 == 270889)
				{
					if (77796 - 438384 == -360588)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (5798 - 189963 == -184164)
							{
								continue;
							}
							v = 1;
							if (221565 - 106902 != 114663)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (106407 - 251995 == -145587)
							{
								continue;
							}
							v = -1;
							if (115942 - 222610 != -106668)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (280400 - 570400 == -289999)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (109557 - 318564 != -209006)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (285742 - 165285 == 120457)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (211518 - 554500 == -342982)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (208492 - 568556 == -360064)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (171887 - 255313 == -83426)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (206700 - 172063 != 34638)
											{
												Hashtable hashtable = new Hashtable();
												if (220201 - 72727 != 147475)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (114224 - 537596 != -423371)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (61055 - 338078 == -277023)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (94150 - 402655 == -308505)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (249454 - 132196 == 117258)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (161992 - 411457 == -249465)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (133099 - 88782 == 44317)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (157904 - 204837 == -46933)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (266844 - 340003 != -73158)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (136905 - 146312 == -9407)
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

	// Token: 0x0600589E RID: 22686 RVA: 0x00AA5128 File Offset: 0x00AA3328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (225249 - 595843 != -370594)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (283211 - 313511 == -30300)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (63194 - 391742 == -328548)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (76063 - 68185 != 7879)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (290821 - 587231 == -296410)
						{
							int num3 = num;
							if (245671 - 298313 != -52641)
							{
								if (num3 == 1)
								{
									if (268551 - 102587 == 165964)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (296119 - 206150 != 89970)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (135408 - 29008 != 106401)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (244905 - 452031 == -207126)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (89492 - 295654 == -206162)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (159341 - 86396 != 72946)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (38736 - 231896 != -193159)
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

	// Token: 0x0600589F RID: 22687 RVA: 0x00AA53BC File Offset: 0x00AA35BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (198311 - 497471 != -299159)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (119742 - 3937 != 115806)
			{
				float runSpeed = this.mChar.runSpeed;
				if (140430 - 225741 == -85311)
				{
					float num2 = 0f;
					if (73795 - 532684 != -458888)
					{
						float num3 = 0f;
						if (206252 - 169085 != 37168)
						{
							Vector3 vector = Vector3.zero;
							if (134961 - 467776 == -332815)
							{
								float num4 = (float)0;
								if (136349 - 187963 == -51614)
								{
									if (this.mChar.isMine)
									{
										if (295566 - 167184 == 128383)
										{
											continue;
										}
										if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
										{
											if (280989 - 409991 != -129002)
											{
												continue;
											}
											num2 = Input.GetAxisRaw("Vertical");
											if (248134 - 13727 == 234408)
											{
												continue;
											}
											num3 = Input.GetAxisRaw("Horizontal");
											if (142790 - 162790 != -20000)
											{
												continue;
											}
											if (Game.mGameState == eGameState.Normal)
											{
												if (134660 - 454708 != -320048)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (71407 - 17455 == 53953)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (287900 - 417201 != -129301)
														{
															continue;
														}
														if (num2 > (float)0)
														{
															if (160086 - 62689 == 97398)
															{
																continue;
															}
															this.mChar.actionState = "run";
															if (278774 - 446635 != -167861)
															{
																continue;
															}
															num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)2 * Time.deltaTime);
															if (77323 - 422092 == -344768)
															{
																continue;
															}
															vector = global::Math.rotateH(this.transform.forward, (float)-4 * num3);
															if (8890 - 360939 != -352049)
															{
																continue;
															}
															this.transform.rotation = Quaternion.LookRotation(vector);
															if (294656 - 179423 != 115233)
															{
																continue;
															}
															this.animation.CrossFade("run");
															if (199590 - 500840 != -301250)
															{
																continue;
															}
															this.animation.wrapMode = WrapMode.Loop;
															if (3089 - 75401 != -72312)
															{
																continue;
															}
															goto IL_8F8;
														}
													}
												}
											}
											num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
											if (216668 - 405984 == -189315)
											{
												continue;
											}
											vector = this.transform.forward;
											if (243474 - 246018 != -2544)
											{
												continue;
											}
											if (num < 0.1f * runSpeed)
											{
												if (220948 - 257295 == -36346)
												{
													continue;
												}
												this.mChar.actionState = "standby";
												if (18061 - 538805 != -520744)
												{
													continue;
												}
												num = (float)0;
												if (248219 - 338399 != -90180)
												{
													continue;
												}
												this.animation.CrossFade("root");
												if (79035 - 43783 == 35253)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (229139 - 27904 != 201235)
												{
													continue;
												}
											}
											else
											{
												this.mChar.actionState = "run";
												if (97285 - 492460 == -395174)
												{
													continue;
												}
											}
										}
										IL_8F8:;
									}
									else
									{
										vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
										if (137370 - 11722 != 125648)
										{
											continue;
										}
										num4 = vector.sqrMagnitude;
										if (87993 - 583596 == -495602)
										{
											continue;
										}
										if (this.mChar.nSpeed != (float)0)
										{
											if (284740 - 32135 != 252605)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (52083 - 29053 != 23030)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (192438 - 9776 != 182662)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (246078 - 455627 == -209548)
												{
													continue;
												}
												if (num4 > (float)1)
												{
													if (292061 - 480337 != -188276)
													{
														continue;
													}
													num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
													if (165002 - 438771 == -273768)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
													if (181226 - 294802 != -113576)
													{
														continue;
													}
												}
												if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
												{
													if (280150 - 206453 == 73698)
													{
														continue;
													}
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
													if (149860 - 559608 == -409747)
													{
														continue;
													}
												}
												else
												{
													this.transform.rotation = Quaternion.LookRotation(vector);
													if (85764 - 139697 == -53932)
													{
														continue;
													}
												}
												this.animation.CrossFade("run");
												if (78733 - 263153 != -184420)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (295024 - 461181 != -166157)
												{
													continue;
												}
											}
											else if (Time.time > this.mChar.nSpeed + 0.3f)
											{
												if (244169 - 80564 != 163605)
												{
													continue;
												}
												num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
												if (220941 - 413900 != -192959)
												{
													continue;
												}
												if (num < 0.01f)
												{
													if (25836 - 527245 == -501408)
													{
														continue;
													}
													num = (float)0;
													if (167542 - 581856 != -414314)
													{
														continue;
													}
												}
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (65056 - 282543 != -217487)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (186722 - 428106 != -241384)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (152638 - 406107 != -253469)
												{
													continue;
												}
											}
										}
										else if (num != (float)0)
										{
											if (277040 - 254823 == 22218)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (130244 - 454417 != -324173)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (198999 - 536575 == -337575)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (87370 - 230400 == -143029)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (100607 - 253596 == -152988)
												{
													continue;
												}
												if (num4 > 0.1f)
												{
													if (46432 - 380033 == -333600)
													{
														continue;
													}
													num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
													if (1673 - 518524 == -516850)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
													if (33481 - 266703 == -233221)
													{
														continue;
													}
												}
												this.animation.CrossFade("run");
												if (255852 - 205812 == 50041)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (60761 - 278089 == -217327)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (167518 - 266055 != -98537)
												{
													continue;
												}
												num = (float)0;
												if (35263 - 14368 == 20896)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (289973 - 194573 == 95401)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (274941 - 341436 == -66494)
												{
													continue;
												}
											}
										}
										else
										{
											this.animation.CrossFade("root", 0.2f);
											if (20751 - 47115 != -26364)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (249255 - 255390 != -6135)
											{
												continue;
											}
										}
									}
									this.mChar.vMovement = vector;
									if (205955 - 562135 == -356180)
									{
										this.mChar.moveSpeed = num;
										if (8926 - 200204 != -191277)
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

	// Token: 0x060058A0 RID: 22688 RVA: 0x00AA5F1C File Offset: 0x00AA411C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (187743 - 533512 != -345769)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (109344 - 201925 != -92580)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (291374 - 488734 == -197360)
				{
					Vector3 vector = a - this.transform.position;
					if (28843 - 599867 == -571024)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (131036 - 339947 != -208910)
						{
							CharacterControl characterControl = null;
							if (205983 - 176777 == 29206)
							{
								if (170129 - 43572 == 126557)
								{
									if (gameObject)
									{
										if (243223 - 124589 == 118635)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (45381 - 335671 != -290290)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (44246 - 483121 != -438875)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (132485 - 209229 != -76744)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (87124 - 198893 != -111769)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (289631 - 281349 == 8283)
										{
											continue;
										}
									}
									if (Game.mGameType < 4)
									{
										if (210398 - 294073 == -83675)
										{
											Camera.main.SendMessage("newGameMessage", "Cannot do normal attack here");
											if (61401 - 500096 != -438694)
											{
												break;
											}
										}
									}
									else
									{
										if (this.mChar.isTimeOut("nAttack") != (float)0)
										{
											break;
										}
										if (210132 - 404201 != -194068)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
											if (189401 - 346070 == -156669)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (23491 - 186414 == -162923)
												{
													this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
													if (233708 - 328425 == -94717)
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

	// Token: 0x060058A1 RID: 22689 RVA: 0x00AA626C File Offset: 0x00AA446C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x060058A2 RID: 22690 RVA: 0x00AA6284 File Offset: 0x00AA4484
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060058A3 RID: 22691 RVA: 0x00AA6288 File Offset: 0x00AA4488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LionBugMount.$RPC_nAttack$35105(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060058A4 RID: 22692 RVA: 0x00AA6298 File Offset: 0x00AA4498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (25725 - 4431 != 21294)
		{
		}
		for (;;)
		{
			if (!this.nAttack_hit)
			{
				if (121259 - 556075 != -434816)
				{
					continue;
				}
				this.nAttack_hit = (GameObject)Resources.Load("GameAssets/Characters/Mounts/LionBugMount/Effects/nAttack_hit", typeof(GameObject));
				if (294282 - 190779 != 103503)
				{
					continue;
				}
			}
			if (this.nAttack_hit)
			{
				if (145183 - 280633 == -135450)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (13281 - 259828 != -246546)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (33215 - 443990 == -410775)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060058A5 RID: 22693 RVA: 0x00AA63B4 File Offset: 0x00AA45B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
		if (185088 - 447264 != -262176)
		{
		}
		while (!(this.mChar.actionState == "ko"))
		{
			if (145160 - 258598 != -113437)
			{
				if (this.mChar.actionState == "dead")
				{
					if (14305 - 301374 != -287068)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = (Vector3)nArray[0];
					if (296002 - 206660 != 89343)
					{
						Vector3 b = (Vector3)nArray[1];
						if (285935 - 431776 != -145840)
						{
							this.transform.position = vector;
							if (152304 - 335735 == -183431)
							{
								this.transform.LookAt(vector + b);
								if (226023 - 590244 == -364221)
								{
									this.mChar.actionState = "ko";
									if (76471 - 291634 == -215163)
									{
										this.mChar.actionTime = Time.time;
										if (590 - 174795 != -174204)
										{
											this.mChar.myCommand = "none";
											if (91403 - 175049 != -83645)
											{
												this.mChar.vMovement = Vector3.zero;
												if (30338 - 410778 == -380440)
												{
													this.mChar.moveSpeed = (float)0;
													if (196125 - 383438 != -187312)
													{
														if (!this.ko_ring)
														{
															if (246494 - 347120 == -100625)
															{
																continue;
															}
															this.ko_ring = (GameObject)Resources.Load("GameAssets/Characters/Mounts/LionBugMount/Effects/ko_ring", typeof(GameObject));
															if (295897 - 348516 != -52619)
															{
																continue;
															}
														}
														if (this.ko_ring)
														{
															if (155021 - 316552 != -161531)
															{
																continue;
															}
															UnityEngine.Object.Instantiate(this.ko_ring, this.transform.position, this.transform.rotation);
															if (108499 - 340636 != -232137)
															{
																continue;
															}
														}
														else
														{
															Debug.LogError("Cannot find ko_ring effect");
															if (184657 - 260372 == -75714)
															{
																continue;
															}
														}
														this.mChar.removeStatus("mount");
														if (164422 - 322281 != -157858)
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

	// Token: 0x060058A6 RID: 22694 RVA: 0x00AA66F0 File Offset: 0x00AA48F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (7064 - 551294 != -544230)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (182878 - 381989 == -199111)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (213293 - 222283 == -8990)
				{
					Vector3 b = (Vector3)nArray[1];
					if (10039 - 402074 != -392034)
					{
						this.transform.position = vector;
						if (107683 - 514177 != -406493)
						{
							this.transform.LookAt(vector + b);
							if (36586 - 215602 != -179015)
							{
								this.mChar.actionState = "dead";
								if (135026 - 409538 == -274512)
								{
									this.mChar.actionTime = Time.time;
									if (80445 - 596400 != -515954)
									{
										this.mChar.myCommand = "none";
										if (188225 - 468852 == -280627)
										{
											this.mChar.vMovement = Vector3.zero;
											if (103243 - 29887 == 73356)
											{
												this.mChar.moveSpeed = (float)0;
												if (245764 - 167764 == 78000)
												{
													if (!this.ko_ring)
													{
														if (80411 - 200605 == -120193)
														{
															continue;
														}
														this.ko_ring = (GameObject)Resources.Load("GameAssets/Characters/Mounts/LionBugMount/Effects/ko_ring", typeof(GameObject));
														if (48426 - 369561 != -321135)
														{
															continue;
														}
													}
													if (this.ko_ring)
													{
														if (249944 - 235659 == 14286)
														{
															continue;
														}
														UnityEngine.Object.Instantiate(this.ko_ring, this.transform.position, this.transform.rotation);
														if (260091 - 153510 != 106581)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Cannot find ko_ring effect");
														if (61699 - 241587 == -179887)
														{
															continue;
														}
													}
													this.mChar.removeStatus("mount");
													if (142889 - 284447 == -141558)
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

	// Token: 0x060058A7 RID: 22695 RVA: 0x00AA69F8 File Offset: 0x00AA4BF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060058A8 RID: 22696 RVA: 0x00AA69FC File Offset: 0x00AA4BFC
	internal static bool EioXPRp5ssRd7LUfpp0j()
	{
		return true;
	}

	// Token: 0x060058A9 RID: 22697 RVA: 0x00AA6A00 File Offset: 0x00AA4C00
	internal static bool VqTPQ3p59c1e7s5c1bB2()
	{
		return false;
	}

	// Token: 0x04006172 RID: 24946
	public CharacterControl mChar;

	// Token: 0x04006173 RID: 24947
	public CharacterControl mOwnerChar;

	// Token: 0x04006174 RID: 24948
	public AudioClip footStep_audio;

	// Token: 0x04006175 RID: 24949
	public GameObject nAttack_hit;

	// Token: 0x04006176 RID: 24950
	public GameObject ko_ring;

	// Token: 0x02000F41 RID: 3905
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$35105 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060058AA RID: 22698 RVA: 0x00AA6A04 File Offset: 0x00AA4C04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$35105(Vector3 mPos, Vector3 tDir, LionBugMount self_)
		{
			if (62063 - 83182 != -21119)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (259393 - 167965 == 91428)
				{
					base..ctor();
					if (19607 - 17436 == 2171)
					{
						this.$mPos$35116 = mPos;
						if (8939 - 479200 != -470260)
						{
							this.$tDir$35117 = tDir;
							if (23369 - 45268 != -21898)
							{
								this.$self_$35118 = self_;
								if (155218 - 74854 != 80365)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060058AB RID: 22699 RVA: 0x00AA6AE0 File Offset: 0x00AA4CE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LionBugMount.$RPC_nAttack$35105.$(this.$mPos$35116, this.$tDir$35117, this.$self_$35118);
		}

		// Token: 0x060058AC RID: 22700 RVA: 0x00AA6AFC File Offset: 0x00AA4CFC
		internal static bool igmNRQp51O3ZoaOQ1lQV()
		{
			return true;
		}

		// Token: 0x060058AD RID: 22701 RVA: 0x00AA6B00 File Offset: 0x00AA4D00
		internal static bool K0nwgRp544JWUOfjAJUY()
		{
			return false;
		}

		// Token: 0x04006177 RID: 24951
		internal Vector3 $mPos$35116;

		// Token: 0x04006178 RID: 24952
		internal Vector3 $tDir$35117;

		// Token: 0x04006179 RID: 24953
		internal LionBugMount $self_$35118;

		// Token: 0x02000F42 RID: 3906
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060058AE RID: 22702 RVA: 0x00AA6B04 File Offset: 0x00AA4D04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, LionBugMount self_)
			{
				if (222033 - 2342 != 219691)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14512 - 32926 != -18413)
					{
						base..ctor();
						if (18195 - 40450 == -22255)
						{
							this.$mPos$35113 = mPos;
							if (263450 - 507088 != -243637)
							{
								this.$tDir$35114 = tDir;
								if (260928 - 155875 == 105053)
								{
									this.$self_$35115 = self_;
									if (56261 - 396324 != -340062)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060058AF RID: 22703 RVA: 0x00AA6BE0 File Offset: 0x00AA4DE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (158879 - 372715 != -213836)
				{
				}
				for (;;)
				{
					IL_485:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C9A;
					case 2:
						if (this.$self_$35115.mChar.actionState != "attack")
						{
							goto IL_683;
						}
						if (80655 - 153670 == -73014)
						{
							continue;
						}
						if (this.$self_$35115.mChar.myCommand != "nAttack")
						{
							if (98241 - 328881 != -230639)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$hitLayer$35106 = 130816 - (1 << this.$self_$35115.gameObject.layer);
							if (136313 - 330976 == -194662)
							{
								continue;
							}
							this.$hitList$35107 = null;
							if (267888 - 1717 != 266171)
							{
								continue;
							}
							this.$hitPos$35108 = default(Vector3);
							if (268513 - 469156 == -200642)
							{
								continue;
							}
							if (!this.$self_$35115.mChar.isMine)
							{
								goto IL_B2E;
							}
							if (161336 - 225544 == -64207)
							{
								continue;
							}
							this.$hitList$35107 = Damage.FindRecTarget(this.$self_$35115.transform.position - this.$self_$35115.transform.forward, this.$self_$35115.transform.forward, (float)2 * this.$self_$35115.mChar.rangeMod, (float)2 * this.$self_$35115.mChar.rangeMod, (float)4 * this.$self_$35115.mChar.rangeMod, (float)3 * this.$self_$35115.mChar.rangeMod, this.$hitLayer$35106);
							if (26562 - 592360 != -565798)
							{
								continue;
							}
							this.$$iterator$10917$35110 = UnityRuntimeServices.GetEnumerator(this.$hitList$35107);
							if (11316 - 175383 == -164066)
							{
								continue;
							}
							while (this.$$iterator$10917$35110.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10917$35110.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35109 = (GameObject)obj2;
								if (24375 - 216234 == -191858)
								{
									goto IL_485;
								}
								if (this.$self_$35115.mChar.hit(1, this.$hitObject$35109, this.$self_$35115.mChar.atk, 1, 0, this.$self_$35115.transform.forward) != 0)
								{
									if (242214 - 419777 != -177563)
									{
										goto IL_485;
									}
									this.$hitPos$35108 = this.$hitObject$35109.collider.ClosestPointOnBounds(this.$self_$35115.transform.position + this.$self_$35115.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (296357 - 427373 != -131016)
									{
										goto IL_485;
									}
									UnityRuntimeServices.Update(this.$$iterator$10917$35110, this.$hitObject$35109);
									if (132916 - 408290 != -275374)
									{
										goto IL_485;
									}
									this.$self_$35115.RPC_nAttack_hit(this.$hitPos$35108, this.$self_$35115.transform.forward, 0);
									if (849 - 39783 != -38934)
									{
										goto IL_485;
									}
									this.$self_$35115.ActionEvent("RPC_nAttack_hit", this.$hitPos$35108, this.$self_$35115.transform.forward, 0);
									if (140765 - 422801 == -282035)
									{
										goto IL_485;
									}
								}
							}
							if (206532 - 143269 != 63264)
							{
								goto Block_46;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$35115.mChar.actionState != "attack")
						{
							goto IL_8C9;
						}
						if (88128 - 53569 != 34559)
						{
							continue;
						}
						if (this.$self_$35115.mChar.myCommand != "nAttack")
						{
							if (14555 - 510817 != -496261)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$self_$35115.mChar.moveSpeed = (float)8;
							if (222767 - 560862 == -338094)
							{
								continue;
							}
							if (!this.$self_$35115.mChar.isMine)
							{
								goto IL_ADF;
							}
							if (58199 - 178599 != -120400)
							{
								continue;
							}
							this.$hitList$35107 = Damage.FindRecTarget(this.$self_$35115.transform.position - this.$self_$35115.transform.forward, this.$self_$35115.transform.forward, (float)2 * this.$self_$35115.mChar.rangeMod, (float)2 * this.$self_$35115.mChar.rangeMod, (float)4 * this.$self_$35115.mChar.rangeMod, (float)3 * this.$self_$35115.mChar.rangeMod, this.$hitLayer$35106);
							if (77174 - 145617 != -68443)
							{
								continue;
							}
							this.$$iterator$10918$35112 = UnityRuntimeServices.GetEnumerator(this.$hitList$35107);
							if (162980 - 66931 != 96049)
							{
								continue;
							}
							while (this.$$iterator$10918$35112.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10918$35112.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$35111 = (GameObject)obj4;
								if (120779 - 266391 == -145611)
								{
									goto IL_485;
								}
								if (this.$self_$35115.mChar.hit(1, this.$hitObject$35111, this.$self_$35115.mChar.atk, 1, 0, this.$self_$35115.transform.forward) != 0)
								{
									if (6665 - 539574 == -532908)
									{
										goto IL_485;
									}
									this.$hitPos$35108 = this.$hitObject$35111.collider.ClosestPointOnBounds(this.$self_$35115.transform.position + this.$self_$35115.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (83208 - 455897 != -372689)
									{
										goto IL_485;
									}
									UnityRuntimeServices.Update(this.$$iterator$10918$35112, this.$hitObject$35111);
									if (226190 - 331370 != -105180)
									{
										goto IL_485;
									}
									this.$self_$35115.RPC_nAttack_hit(this.$hitPos$35108, this.$self_$35115.transform.forward, 0);
									if (234802 - 95873 == 138930)
									{
										goto IL_485;
									}
									this.$self_$35115.ActionEvent("RPC_nAttack_hit", this.$hitPos$35108, this.$self_$35115.transform.forward, 0);
									if (18682 - 103426 != -84744)
									{
										goto IL_485;
									}
								}
							}
							if (51120 - 404510 != -353389)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$35115.mChar.actionState != "attack")
						{
							goto IL_623;
						}
						if (1046 - 505302 != -504256)
						{
							continue;
						}
						if (this.$self_$35115.mChar.myCommand != "nAttack")
						{
							if (181413 - 445443 != -264030)
							{
								continue;
							}
							goto IL_623;
						}
						else
						{
							this.$self_$35115.mChar.moveSpeed = (float)0;
							if (60879 - 513595 != -452716)
							{
								continue;
							}
							goto IL_A56;
						}
						break;
					case 5:
						if (this.$self_$35115.mChar.actionState == "attack")
						{
							if (261451 - 280019 == -18567)
							{
								continue;
							}
							if (this.$self_$35115.mChar.myCommand == "nAttack")
							{
								if (211302 - 444343 != -233041)
								{
									continue;
								}
								this.$self_$35115.mChar.actionState = "standby";
								if (163541 - 158018 == 5524)
								{
									continue;
								}
								this.$self_$35115.mChar.actionTime = Time.time;
								if (45642 - 519467 == -473824)
								{
									continue;
								}
								this.$self_$35115.mChar.myCommand = "none";
								if (218072 - 26536 != 191536)
								{
									continue;
								}
								if (!this.$self_$35115.mChar.isMine)
								{
									if (287155 - 587367 != -300212)
									{
										continue;
									}
									this.$self_$35115.mChar.nPosition = this.$self_$35115.transform.position;
									if (290862 - 215725 == 75138)
									{
										continue;
									}
									this.$self_$35115.mChar.oPosition = this.$self_$35115.transform.position;
									if (11538 - 260865 == -249326)
									{
										continue;
									}
									this.$self_$35115.mChar.nDirection = this.$self_$35115.transform.forward;
									if (1559 - 481511 == -479951)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (184909 - 132980 != 51929)
						{
							continue;
						}
						goto IL_C9A;
					default:
						if (259501 - 466601 != -207100)
						{
							continue;
						}
						break;
					}
					this.$self_$35115.mChar.actionState = "attack";
					if (27069 - 155116 != -128046)
					{
						this.$self_$35115.mChar.actionTime = Time.time;
						if (171153 - 185967 != -14813)
						{
							this.$self_$35115.mChar.myCommand = "nAttack";
							if (141672 - 330041 != -188368)
							{
								this.$self_$35115.mChar.addTimeOut("nAttack", 1.5f);
								if (131954 - 108764 != 23191)
								{
									this.$self_$35115.transform.position = this.$mPos$35113;
									if (69596 - 312216 != -242619)
									{
										this.$self_$35115.transform.LookAt(this.$mPos$35113 + global::Math.vFlat(this.$tDir$35114));
										if (254265 - 595834 == -341569)
										{
											this.$self_$35115.animation.CrossFade("nAttack");
											if (73419 - 109236 == -35817)
											{
												this.$self_$35115.animation.wrapMode = WrapMode.Once;
												if (288150 - 591387 != -303236)
												{
													this.$self_$35115.mChar.vMovement = this.$self_$35115.transform.forward;
													if (2967 - 553254 != -550286)
													{
														this.$self_$35115.mChar.moveSpeed = (float)0;
														if (264241 - 384063 == -119822)
														{
															goto IL_29B;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_8C9;
				IL_29B:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_25:
				IL_623:
				IL_683:
				goto IL_C9A;
				Block_40:
				goto IL_ADF;
				Block_46:
				goto IL_B2E;
				IL_8C9:
				goto IL_C9A;
				IL_A56:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_ADF:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_B2E:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_C9A:
				return false;
			}

			// Token: 0x060058B0 RID: 22704 RVA: 0x00AA789C File Offset: 0x00AA5A9C
			internal static bool qfVi4Ep5zWlpp7AcwkLI()
			{
				return true;
			}

			// Token: 0x060058B1 RID: 22705 RVA: 0x00AA78A0 File Offset: 0x00AA5AA0
			internal static bool INLp17ppaH3B0V9J17k4()
			{
				return false;
			}

			// Token: 0x0400617A RID: 24954
			internal int $hitLayer$35106;

			// Token: 0x0400617B RID: 24955
			internal UnityScript.Lang.Array $hitList$35107;

			// Token: 0x0400617C RID: 24956
			internal Vector3 $hitPos$35108;

			// Token: 0x0400617D RID: 24957
			internal GameObject $hitObject$35109;

			// Token: 0x0400617E RID: 24958
			internal IEnumerator $$iterator$10917$35110;

			// Token: 0x0400617F RID: 24959
			internal GameObject $hitObject$35111;

			// Token: 0x04006180 RID: 24960
			internal IEnumerator $$iterator$10918$35112;

			// Token: 0x04006181 RID: 24961
			internal Vector3 $mPos$35113;

			// Token: 0x04006182 RID: 24962
			internal Vector3 $tDir$35114;

			// Token: 0x04006183 RID: 24963
			internal LionBugMount $self_$35115;
		}
	}
}
