using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A57 RID: 2647
[Serializable]
public class MadCarron : MonoBehaviour
{
	// Token: 0x06003A04 RID: 14852 RVA: 0x0079663C File Offset: 0x0079483C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MadCarron()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003A05 RID: 14853 RVA: 0x0079664C File Offset: 0x0079484C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (221031 - 354836 != -133804)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (299279 - 399989 != -100709)
			{
				this.mChar.actionState = "standby";
				if (286863 - 72806 != 214058)
				{
					this.mChar.actionTime = Time.time;
					if (162367 - 105611 == 56756)
					{
						this.mChar.myCommand = "none";
						if (53553 - 475446 == -421893)
						{
							this.mChar.hp = (this.mChar.mhp = 3500);
							if (58026 - 323601 == -265575)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003A06 RID: 14854 RVA: 0x00796770 File Offset: 0x00794970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06003A07 RID: 14855 RVA: 0x0079678C File Offset: 0x0079498C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (172583 - 365849 != -193265)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (130481 - 504561 != -374080)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (255571 - 273363 != -17792)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_2A2;
					}
					if (228148 - 402846 != -174698)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (253761 - 238738 != 15023)
				{
					continue;
				}
			}
			IL_2A2:
			if (this.mChar.hp > 0)
			{
				if (201354 - 87193 != 114161)
				{
					continue;
				}
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (246685 - 555668 != -308983)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (203810 - 280853 != -77042)
			{
				if (this.mChar.isMine)
				{
					if (207827 - 161391 != 46437)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (37076 - 252930 == -215854)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (3421 - 14229 == -10808)
							{
								this.mChar.DeadEvent();
								if (116093 - 138553 != -22459)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.mChar.hp <= 0)
				{
					if (282422 - 47306 == 235116)
					{
						this.mChar.hp = 1;
						if (253298 - 93962 == 159336)
						{
							break;
						}
					}
				}
				else
				{
					if (this.mChar.ko > 0)
					{
						break;
					}
					if (170702 - 284531 != -113828)
					{
						this.mChar.ko = 1;
						if (196897 - 255102 == -58205)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003A08 RID: 14856 RVA: 0x00796A78 File Offset: 0x00794C78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (259385 - 483817 != -224432)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (12984 - 253096 == -240112)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (88414 - 537977 == -449563)
				{
					if (172894 - 177330 != -4435)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (247675 - 27472 != 220203)
							{
								continue;
							}
							v = 1;
							if (163531 - 342280 == -178748)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (203589 - 281570 == -77980)
							{
								continue;
							}
							v = -1;
							if (131228 - 55159 != 76069)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (202002 - 57292 == 144711)
							{
								continue;
							}
							v = 11;
							if (234103 - 250684 == -16580)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack_fire")
						{
							if (35019 - 598722 != -563703)
							{
								continue;
							}
							v = 12;
							if (74237 - 117528 == -43290)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack_hit")
						{
							if (106821 - 408001 == -301179)
							{
								continue;
							}
							v = -11;
							if (10792 - 260043 != -249251)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (31226 - 446101 == -414874)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (191557 - 347405 != -155847)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (127042 - 292637 == -165595)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (120002 - 178744 != -58741)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (42005 - 294570 == -252565)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (10754 - 545715 != -534960)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (281700 - 344238 == -62538)
											{
												Hashtable hashtable = new Hashtable();
												if (273000 - 24104 == 248896)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (168023 - 471885 == -303862)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (205274 - 100567 == 104707)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (98510 - 406710 != -308199)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (236927 - 529472 == -292545)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (271711 - 153498 != 118214)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (111466 - 215437 == -103971)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (148750 - 491667 == -342917)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (22136 - 62838 == -40702)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (56789 - 142648 == -85859)
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

	// Token: 0x06003A09 RID: 14857 RVA: 0x00796FDC File Offset: 0x007951DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (64056 - 64364 != -308)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (132992 - 28483 != 104510)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (164033 - 74542 == 89491)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (298241 - 437964 != -139722)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (282190 - 564658 == -282468)
						{
							int num3 = num;
							if (94790 - 475470 == -380680)
							{
								if (num3 == 1)
								{
									if (270670 - 404133 != -133462)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (262188 - 599158 == -336970)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (141237 - 285609 != -144371)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (164251 - 507139 == -342888)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (217113 - 299920 != -82806)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (266833 - 268989 == -2156)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (71857 - 177490 == -105633)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (41706 - 344436 != -302729)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (254733 - 157734 != 97000)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (21764 - 115936 != -94171)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (144408 - 594575 != -450166)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack_fire(vector, vector2, num2));
											if (127704 - 459788 != -332083)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (141164 - 523930 != -382765)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (71270 - 552149 != -480878)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (23499 - 380405 != -356905)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (259096 - 387246 == -128150)
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

	// Token: 0x06003A0A RID: 14858 RVA: 0x007973DC File Offset: 0x007955DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (141535 - 124253 != 17282)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (213302 - 583166 == -369864)
			{
				float runSpeed = this.mChar.runSpeed;
				if (44528 - 430516 == -385988)
				{
					Vector3 a = default(Vector3);
					if (293028 - 86637 == 206391)
					{
						Vector3 vector = Vector3.zero;
						if (295899 - 258656 == 37243)
						{
							float num2 = (float)0;
							if (150670 - 293872 == -143202)
							{
								if (this.mChar.isMine)
								{
									if (274342 - 596781 != -322439)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (277116 - 489143 != -212027)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (48536 - 31797 == 16740)
										{
											continue;
										}
										a.y = (float)0;
										if (79754 - 137141 == -57386)
										{
											continue;
										}
										a = a.normalized;
										if (121109 - 205579 != -84470)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (7297 - 386779 == -379481)
										{
											continue;
										}
										vector = vector.normalized;
										if (60238 - 538898 == -478659)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (255982 - 496456 == -240473)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (101013 - 34241 == 66773)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (19398 - 490204 == -470805)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (124758 - 51751 == 73008)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (188858 - 289565 != -100707)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (162201 - 262198 != -99997)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (152527 - 161527 == -8999)
														{
															continue;
														}
														this.animation.Play("run");
														if (239380 - 35942 != 203438)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (150537 - 226924 != -76386)
														{
															goto IL_61B;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (47868 - 5039 != 42829)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (91535 - 378628 != -287093)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (180284 - 121975 != 58309)
											{
												continue;
											}
											num = (float)0;
											if (174616 - 418236 != -243620)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (296272 - 234605 != 61667)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (195405 - 503127 == -307721)
										{
											continue;
										}
									}
									IL_61B:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (144198 - 99680 == 44519)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (181807 - 313320 != -131513)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (216950 - 607 != 216343)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (19217 - 388858 != -369641)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (33783 - 144673 != -110890)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (167332 - 118164 != 49168)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (118925 - 432502 != -313577)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (260147 - 238107 != 22040)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (9930 - 138903 != -128973)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (263511 - 82880 != 180631)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (50613 - 107760 == -57146)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (43056 - 325271 != -282215)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (18222 - 461286 == -443063)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (255881 - 414749 == -158867)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (152048 - 324594 != -172546)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (229735 - 432984 != -203249)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (198239 - 135261 != 62978)
												{
													continue;
												}
												num = (float)0;
												if (250462 - 118470 == 131993)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (70982 - 135955 != -64973)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (36644 - 415854 == -379209)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (37799 - 53217 != -15418)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (199996 - 301797 != -101801)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (115060 - 318011 == -202950)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (150729 - 359784 == -209054)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (216601 - 458317 == -241715)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (186119 - 330780 == -144660)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (207619 - 441068 == -233448)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (39906 - 475150 == -435243)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (51927 - 225200 != -173273)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (219836 - 552681 == -332844)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (135374 - 279798 == -144423)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (142262 - 106465 != 35797)
											{
												continue;
											}
											num = (float)0;
											if (144037 - 106250 == 37788)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (2310 - 127238 == -124927)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (122265 - 403498 != -281233)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (190410 - 226811 != -36401)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (26253 - 251867 != -225614)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (249523 - 586856 != -337332)
								{
									this.mChar.moveSpeed = num;
									if (109251 - 525087 != -415835)
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

	// Token: 0x06003A0B RID: 14859 RVA: 0x00797F40 File Offset: 0x00796140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (217859 - 311576 != -93717)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (130011 - 352317 != -222305)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (186349 - 287845 == -101496)
				{
					Vector3 vector = a - this.transform.position;
					if (1234 - 439530 != -438295)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (70958 - 188307 != -117348)
						{
							CharacterControl characterControl = null;
							if (285292 - 391755 == -106463)
							{
								if (95788 - 139692 != -43903)
								{
									if (gameObject)
									{
										if (195029 - 68476 != 126553)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (93256 - 329915 != -236659)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (63951 - 506362 == -442410)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (275401 - 187426 == 87976)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (251835 - 108601 != 143234)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (236433 - 107705 != 128728)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (299256 - 132219 == 167037)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (211424 - 391850 == -180426)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (228518 - 84543 == 143975)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (164521 - 175611 != -11089)
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

	// Token: 0x06003A0C RID: 14860 RVA: 0x00798238 File Offset: 0x00796438
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (257239 - 384588 != -127349)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (148908 - 417479 == -268571)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (171280 - 226246 == -54966)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (262932 - 125916 != 137017)
					{
						Vector3 normalized = vector.normalized;
						if (203524 - 434239 != -230714)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (53872 - 534709 != -480836)
							{
								CharacterControl characterControl = null;
								if (13266 - 531994 != -518727 && 42994 - 447984 != -404989)
								{
									if (gameObject)
									{
										if (142257 - 519612 != -377355)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (298384 - 383343 == -84958)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (236699 - 485404 != -248705)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (24057 - 2256 == 21802)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (23401 - 140774 == -117372)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (190680 - 262627 != -71947)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (264677 - 580824 == -316147)
									{
										this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
										if (241714 - 568509 == -326795)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (281933 - 87043 == 194890)
											{
												this.ActionEvent("RPC_cAttack", this.transform.position, normalized, 0);
												if (211943 - 559491 != -347547)
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

	// Token: 0x06003A0D RID: 14861 RVA: 0x00798558 File Offset: 0x00796758
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003A0E RID: 14862 RVA: 0x0079855C File Offset: 0x0079675C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MadCarron.$RPC_nAttack$30174(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003A0F RID: 14863 RVA: 0x0079856C File Offset: 0x0079676C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (88011 - 83257 != 4754)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (61524 - 406685 != -345160)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (104930 - 255113 == -150183)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (66878 - 118057 == -51179)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003A10 RID: 14864 RVA: 0x00798624 File Offset: 0x00796824
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MadCarron.$RPC_cAttack$30187(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06003A11 RID: 14865 RVA: 0x00798634 File Offset: 0x00796834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		return new MadCarron.$RPC_cAttack_fire$30198(firePos, fireDir, this).GetEnumerator();
	}

	// Token: 0x06003A12 RID: 14866 RVA: 0x00798644 File Offset: 0x00796844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (131280 - 75160 != 56120)
		{
		}
		for (;;)
		{
			if (this.cAttack_hit)
			{
				if (62928 - 265989 == -203061)
				{
					UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (280172 - 178541 == 101631)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find cAttack_hit effect");
				if (30656 - 189467 == -158811)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003A13 RID: 14867 RVA: 0x007986FC File Offset: 0x007968FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new MadCarron.$RPC_dead$30210(nArray, this).GetEnumerator();
	}

	// Token: 0x06003A14 RID: 14868 RVA: 0x0079870C File Offset: 0x0079690C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003A15 RID: 14869 RVA: 0x00798710 File Offset: 0x00796910
	internal static bool DLRiAf522IX2dc2LvUc0()
	{
		return true;
	}

	// Token: 0x06003A16 RID: 14870 RVA: 0x00798714 File Offset: 0x00796914
	internal static bool MBXrcM52869lralX5fLv()
	{
		return false;
	}

	// Token: 0x04004847 RID: 18503
	public CharacterControl mChar;

	// Token: 0x04004848 RID: 18504
	public GameObject nAttack_hit;

	// Token: 0x04004849 RID: 18505
	public AudioClip madCarron_fx;

	// Token: 0x0400484A RID: 18506
	public GameObject cAttack_fire;

	// Token: 0x0400484B RID: 18507
	public GameObject cAttack_hit;

	// Token: 0x02000A58 RID: 2648
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30174 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003A17 RID: 14871 RVA: 0x00798718 File Offset: 0x00796918
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30174(Vector3 mPos, Vector3 tDir, MadCarron self_)
		{
			if (90414 - 550722 != -460307)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (58293 - 167538 != -109244)
				{
					base..ctor();
					if (232449 - 11454 != 220996)
					{
						this.$mPos$30184 = mPos;
						if (76065 - 220176 == -144111)
						{
							this.$tDir$30185 = tDir;
							if (25048 - 42349 != -17300)
							{
								this.$self_$30186 = self_;
								if (176666 - 292282 == -115616)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003A18 RID: 14872 RVA: 0x007987F4 File Offset: 0x007969F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MadCarron.$RPC_nAttack$30174.$(this.$mPos$30184, this.$tDir$30185, this.$self_$30186);
		}

		// Token: 0x06003A19 RID: 14873 RVA: 0x00798810 File Offset: 0x00796A10
		internal static bool RiPboU52ZI47E311iFXc()
		{
			return true;
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x00798814 File Offset: 0x00796A14
		internal static bool Ho975L52Cj5HGFZdorVB()
		{
			return false;
		}

		// Token: 0x0400484C RID: 18508
		internal Vector3 $mPos$30184;

		// Token: 0x0400484D RID: 18509
		internal Vector3 $tDir$30185;

		// Token: 0x0400484E RID: 18510
		internal MadCarron $self_$30186;

		// Token: 0x02000A59 RID: 2649
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003A1B RID: 14875 RVA: 0x00798818 File Offset: 0x00796A18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MadCarron self_)
			{
				if (51322 - 37995 != 13328)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (42022 - 200341 == -158319)
					{
						base..ctor();
						if (202932 - 258176 == -55244)
						{
							this.$mPos$30181 = mPos;
							if (155572 - 266472 == -110900)
							{
								this.$tDir$30182 = tDir;
								if (113864 - 562038 != -448173)
								{
									this.$self_$30183 = self_;
									if (76785 - 266935 != -190149)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003A1C RID: 14876 RVA: 0x007988F4 File Offset: 0x00796AF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (210253 - 198454 != 11799)
				{
				}
				for (;;)
				{
					IL_4D8:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9B8;
					case 2:
						if (this.$self_$30183.mChar.actionState != "attack")
						{
							goto IL_26D;
						}
						if (271293 - 526361 == -255067)
						{
							continue;
						}
						if (this.$self_$30183.mChar.myCommand != "nAttack")
						{
							if (66839 - 510115 != -443275)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$self_$30183.mChar.moveSpeed = (float)6;
							if (126356 - 59680 != 66676)
							{
								continue;
							}
							this.$i$30175 = 0;
							if (238571 - 135214 != 103357)
							{
								continue;
							}
							goto IL_101;
						}
						break;
					case 3:
						if (this.$self_$30183.mChar.actionState != "attack")
						{
							goto IL_1CA;
						}
						if (53673 - 151162 != -97489)
						{
							continue;
						}
						if (this.$self_$30183.mChar.myCommand != "nAttack")
						{
							if (37845 - 237725 != -199880)
							{
								continue;
							}
							goto IL_1CA;
						}
						else
						{
							if (this.$self_$30183.mChar.isMine)
							{
								if (145978 - 17603 != 128375)
								{
									continue;
								}
								this.$hitLayer$30176 = 130816 - (1 << this.$self_$30183.gameObject.layer);
								if (74245 - 469452 == -395206)
								{
									continue;
								}
								this.$hitList$30177 = Damage.FindRecTarget(this.$self_$30183.transform.position, this.$self_$30183.transform.forward, (float)1, (float)1, (float)2, (float)3, this.$hitLayer$30176);
								if (46215 - 452926 != -406711)
								{
									continue;
								}
								this.$$iterator$10603$30180 = UnityRuntimeServices.GetEnumerator(this.$hitList$30177);
								if (12870 - 405687 == -392816)
								{
									continue;
								}
								while (this.$$iterator$10603$30180.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10603$30180.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$30178 = (GameObject)obj2;
									if (292862 - 109588 != 183274)
									{
										goto IL_4D8;
									}
									if (this.$self_$30183.mChar.hit(1, this.$hitObject$30178, (int)(0.5f * (float)this.$self_$30183.mChar.atk), 3, 0, this.$self_$30183.transform.forward) != 0)
									{
										if (149063 - 452528 == -303464)
										{
											goto IL_4D8;
										}
										this.$hitPos$30179 = this.$hitObject$30178.collider.ClosestPointOnBounds(this.$self_$30183.transform.position + this.$self_$30183.transform.TransformDirection((float)1, 1.5f, 2.5f));
										if (171386 - 277951 != -106565)
										{
											goto IL_4D8;
										}
										UnityRuntimeServices.Update(this.$$iterator$10603$30180, this.$hitObject$30178);
										if (151315 - 554436 == -403120)
										{
											goto IL_4D8;
										}
										this.$self_$30183.RPC_nAttack_hit(this.$hitPos$30179, this.$self_$30183.transform.forward, 0);
										if (178609 - 531335 == -352725)
										{
											goto IL_4D8;
										}
										if (PhotonClient.IsInitialized())
										{
											if (283677 - 87283 == 196395)
											{
												goto IL_4D8;
											}
											this.$self_$30183.ActionEvent("RPC_nAttack_hit", this.$hitPos$30179, this.$self_$30183.transform.forward, 0);
											if (277029 - 328285 == -51255)
											{
												goto IL_4D8;
											}
										}
									}
								}
								if (19840 - 494584 == -474743)
								{
									continue;
								}
							}
							this.$i$30175++;
							if (169852 - 565311 != -395459)
							{
								continue;
							}
							goto IL_101;
						}
						break;
					case 4:
						if (this.$self_$30183.mChar.actionState != "attack")
						{
							goto IL_515;
						}
						if (158240 - 66846 == 91395)
						{
							continue;
						}
						if (this.$self_$30183.mChar.myCommand != "nAttack")
						{
							if (285870 - 122127 != 163743)
							{
								continue;
							}
							goto IL_515;
						}
						else
						{
							this.$self_$30183.mChar.moveSpeed = (float)0;
							if (79997 - 144004 != -64006)
							{
								goto Block_38;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$30183.mChar.actionState == "attack")
						{
							if (52729 - 280993 != -228264)
							{
								continue;
							}
							if (this.$self_$30183.mChar.myCommand == "nAttack")
							{
								if (107846 - 318261 != -210415)
								{
									continue;
								}
								this.$self_$30183.mChar.actionState = "standby";
								if (28047 - 280124 != -252077)
								{
									continue;
								}
								this.$self_$30183.mChar.actionTime = Time.time;
								if (200803 - 464032 != -263229)
								{
									continue;
								}
								this.$self_$30183.mChar.myCommand = "none";
								if (253519 - 383595 != -130076)
								{
									continue;
								}
								if (!this.$self_$30183.mChar.isMine)
								{
									if (86214 - 76079 != 10135)
									{
										continue;
									}
									this.$self_$30183.mChar.nPosition = this.$self_$30183.transform.position;
									if (60004 - 574922 != -514918)
									{
										continue;
									}
									this.$self_$30183.mChar.oPosition = this.$self_$30183.transform.position;
									if (176851 - 11525 == 165327)
									{
										continue;
									}
									this.$self_$30183.mChar.nDirection = this.$self_$30183.transform.forward;
									if (171818 - 169050 != 2768)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (74945 - 221445 != -146499)
						{
							goto Block_54;
						}
						continue;
					default:
						if (130115 - 320902 == -190786)
						{
							continue;
						}
						break;
					}
					this.$self_$30183.mChar.actionState = "attack";
					if (69545 - 48022 != 21523)
					{
						continue;
					}
					this.$self_$30183.mChar.actionTime = Time.time;
					if (136365 - 331612 != -195247)
					{
						continue;
					}
					this.$self_$30183.mChar.myCommand = "nAttack";
					if (175200 - 25155 == 150046)
					{
						continue;
					}
					this.$self_$30183.mChar.addTimeOut("nAttack", (float)1);
					if (263375 - 293685 == -30309)
					{
						continue;
					}
					this.$self_$30183.transform.position = this.$mPos$30181;
					if (179189 - 303388 != -124199)
					{
						continue;
					}
					this.$self_$30183.transform.LookAt(this.$mPos$30181 + global::Math.vFlat(this.$tDir$30182));
					if (144181 - 390787 != -246606)
					{
						continue;
					}
					this.$self_$30183.animation.Play("nAttack");
					if (123684 - 199904 != -76220)
					{
						continue;
					}
					this.$self_$30183.animation.wrapMode = WrapMode.Once;
					if (218685 - 320755 == -102069)
					{
						continue;
					}
					this.$self_$30183.mChar.vMovement = this.$self_$30183.transform.forward;
					if (86849 - 47376 != 39473)
					{
						continue;
					}
					this.$self_$30183.mChar.moveSpeed = (float)0;
					if (23888 - 436598 != -412709)
					{
						goto Block_43;
					}
					continue;
					IL_101:
					if (this.$i$30175 < 2)
					{
						goto IL_3C1;
					}
					if (35672 - 22434 != 13239)
					{
						goto Block_9;
					}
				}
				Block_5:
				goto IL_26D;
				Block_9:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_1CA:
				IL_26D:
				goto IL_9B8;
				IL_3C1:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_515:
				goto IL_9B8;
				Block_38:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_43:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_54:
				IL_9B8:
				return false;
			}

			// Token: 0x06003A1D RID: 14877 RVA: 0x007992CC File Offset: 0x007974CC
			internal static bool lIM0tj52LC4syfr50R5S()
			{
				return true;
			}

			// Token: 0x06003A1E RID: 14878 RVA: 0x007992D0 File Offset: 0x007974D0
			internal static bool hX4bg952OkUMjxAVVKBn()
			{
				return false;
			}

			// Token: 0x0400484F RID: 18511
			internal int $i$30175;

			// Token: 0x04004850 RID: 18512
			internal int $hitLayer$30176;

			// Token: 0x04004851 RID: 18513
			internal UnityScript.Lang.Array $hitList$30177;

			// Token: 0x04004852 RID: 18514
			internal GameObject $hitObject$30178;

			// Token: 0x04004853 RID: 18515
			internal Vector3 $hitPos$30179;

			// Token: 0x04004854 RID: 18516
			internal IEnumerator $$iterator$10603$30180;

			// Token: 0x04004855 RID: 18517
			internal Vector3 $mPos$30181;

			// Token: 0x04004856 RID: 18518
			internal Vector3 $tDir$30182;

			// Token: 0x04004857 RID: 18519
			internal MadCarron $self_$30183;
		}
	}

	// Token: 0x02000A5A RID: 2650
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$30187 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003A1F RID: 14879 RVA: 0x007992D4 File Offset: 0x007974D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$30187(Vector3 mPos, Vector3 tDir, int tID, MadCarron self_)
		{
			if (36670 - 354530 != -317860)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (28274 - 187827 == -159553)
				{
					base..ctor();
					if (8409 - 64752 == -56343)
					{
						this.$mPos$30194 = mPos;
						if (140639 - 57962 != 82678)
						{
							this.$tDir$30195 = tDir;
							if (220241 - 513363 != -293121)
							{
								this.$tID$30196 = tID;
								if (24343 - 99473 != -75129)
								{
									this.$self_$30197 = self_;
									if (213974 - 345333 == -131359)
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

		// Token: 0x06003A20 RID: 14880 RVA: 0x007993D4 File Offset: 0x007975D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MadCarron.$RPC_cAttack$30187.$(this.$mPos$30194, this.$tDir$30195, this.$tID$30196, this.$self_$30197);
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x007993F4 File Offset: 0x007975F4
		internal static bool aFXBtO52mXFlCJdyl9PE()
		{
			return true;
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x007993F8 File Offset: 0x007975F8
		internal static bool uDNDbs52FaGkd0joUUuB()
		{
			return false;
		}

		// Token: 0x04004858 RID: 18520
		internal Vector3 $mPos$30194;

		// Token: 0x04004859 RID: 18521
		internal Vector3 $tDir$30195;

		// Token: 0x0400485A RID: 18522
		internal int $tID$30196;

		// Token: 0x0400485B RID: 18523
		internal MadCarron $self_$30197;

		// Token: 0x02000A5B RID: 2651
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003A23 RID: 14883 RVA: 0x007993FC File Offset: 0x007975FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, MadCarron self_)
			{
				if (106072 - 426435 != -320363)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (173923 - 489388 == -315465)
					{
						base..ctor();
						if (95687 - 348236 == -252549)
						{
							this.$mPos$30190 = mPos;
							if (250326 - 441565 != -191238)
							{
								this.$tDir$30191 = tDir;
								if (87549 - 281443 == -193894)
								{
									this.$tID$30192 = tID;
									if (139100 - 355443 == -216343)
									{
										this.$self_$30193 = self_;
										if (197993 - 169197 != 28797)
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

			// Token: 0x06003A24 RID: 14884 RVA: 0x007994FC File Offset: 0x007976FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (37460 - 466632 != -429172)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_90C;
					case 1:
						goto IL_A2B;
					case 2:
						if (this.$self_$30193.mChar.actionState != "attack")
						{
							goto IL_56A;
						}
						if (12281 - 329986 == -317704)
						{
							continue;
						}
						if (this.$self_$30193.mChar.myCommand != "cAttack")
						{
							if (22430 - 484577 != -462146)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30193.mChar.actionState != "attack")
						{
							goto IL_5A6;
						}
						if (198356 - 288237 == -89880)
						{
							continue;
						}
						if (this.$self_$30193.mChar.myCommand != "cAttack")
						{
							if (94970 - 537509 != -442538)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30193.mChar.isMine)
							{
								goto IL_974;
							}
							if (222244 - 435611 == -213366)
							{
								continue;
							}
							this.$tPos$30189 = this.$mPos$30190 + this.$tDir$30191;
							if (431 - 343515 != -343084)
							{
								continue;
							}
							if (this.$tObject$30188)
							{
								if (264618 - 42269 != 222349)
								{
									continue;
								}
								this.$tPos$30189 = this.$tObject$30188.transform.position;
								if (244425 - 164981 == 79445)
								{
									continue;
								}
								this.$tDir$30191 = (this.$tObject$30188.transform.position - this.$self_$30193.transform.position).normalized;
								if (255693 - 352031 == -96337)
								{
									continue;
								}
							}
							this.$self_$30193.StartCoroutine_Auto(this.$self_$30193.RPC_cAttack_fire(this.$tPos$30189, this.$tDir$30191, this.$tID$30192));
							if (15019 - 221973 != -206954)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_974;
							}
							if (12161 - 301771 == -289609)
							{
								continue;
							}
							this.$self_$30193.ActionEvent("RPC_cAttack_fire", this.$tPos$30189, this.$tDir$30191, this.$tID$30192);
							if (282218 - 594980 != -312761)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$30193.mChar.actionState != "attack")
						{
							goto IL_3E9;
						}
						if (126877 - 3434 == 123444)
						{
							continue;
						}
						if (this.$self_$30193.mChar.myCommand != "cAttack")
						{
							if (253211 - 341883 != -88671)
							{
								goto Block_63;
							}
							continue;
						}
						else
						{
							this.$self_$30193.mChar.moveSpeed = (float)0;
							if (199246 - 536646 != -337399)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$30193.mChar.actionState == "attack")
						{
							if (258781 - 166042 != 92739)
							{
								continue;
							}
							if (this.$self_$30193.mChar.myCommand == "cAttack")
							{
								if (95327 - 40219 == 55109)
								{
									continue;
								}
								this.$self_$30193.mChar.actionState = "standby";
								if (9052 - 346805 != -337753)
								{
									continue;
								}
								this.$self_$30193.mChar.actionTime = Time.time;
								if (274325 - 75396 != 198929)
								{
									continue;
								}
								this.$self_$30193.mChar.myCommand = "none";
								if (118197 - 126445 == -8247)
								{
									continue;
								}
								if (!this.$self_$30193.mChar.isMine)
								{
									if (6073 - 309911 == -303837)
									{
										continue;
									}
									this.$self_$30193.mChar.nPosition = this.$self_$30193.transform.position;
									if (274180 - 358996 == -84815)
									{
										continue;
									}
									this.$self_$30193.mChar.oPosition = this.$self_$30193.transform.position;
									if (109142 - 20599 != 88543)
									{
										continue;
									}
									this.$self_$30193.mChar.nDirection = this.$self_$30193.transform.forward;
									if (101274 - 71067 != 30207)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (152082 - 322865 != -170782)
						{
							goto Block_54;
						}
						continue;
					default:
						if (264723 - 162758 != 101966)
						{
							goto IL_90C;
						}
						continue;
					}
					IL_56F:
					if (this.$self_$30193.mChar.actionTime + (float)1 <= Time.time)
					{
						if (70399 - 35813 == 34587)
						{
							continue;
						}
						if (this.$self_$30193.mChar.actionState != "attack")
						{
							goto IL_269;
						}
						if (89003 - 559895 != -470892)
						{
							continue;
						}
						if (this.$self_$30193.mChar.myCommand != "cAttack")
						{
							if (168112 - 217606 != -49494)
							{
								continue;
							}
							goto IL_269;
						}
						else
						{
							this.$self_$30193.mChar.moveSpeed = (float)3;
							if (295778 - 503518 != -207740)
							{
								continue;
							}
							goto IL_41A;
						}
					}
					else
					{
						if (!this.$tObject$30188)
						{
							goto IL_1EB;
						}
						if (291717 - 405966 == -114248)
						{
							continue;
						}
						this.$self_$30193.transform.LookAt(global::Math.cFlat(this.$tObject$30188.transform.position, this.$self_$30193.transform.position.y));
						if (200415 - 87819 != 112596)
						{
							continue;
						}
						goto IL_1EB;
					}
					IL_90C:
					this.$self_$30193.mChar.actionState = "attack";
					if (15575 - 450915 != -435339)
					{
						this.$self_$30193.mChar.actionTime = Time.time;
						if (259773 - 307921 != -48147)
						{
							this.$self_$30193.mChar.myCommand = "cAttack";
							if (286667 - 173601 != 113067)
							{
								this.$self_$30193.mChar.addTimeOut("cAttack", (float)6);
								if (165297 - 306051 == -140754)
								{
									this.$self_$30193.transform.position = this.$mPos$30190;
									if (114790 - 305210 != -190419)
									{
										this.$self_$30193.transform.LookAt(this.$mPos$30190 + global::Math.vFlat(this.$tDir$30191));
										if (167000 - 180679 == -13679)
										{
											this.$self_$30193.animation.Play("cAttack");
											if (142568 - 584133 != -441564)
											{
												this.$self_$30193.animation.wrapMode = WrapMode.Once;
												if (274342 - 490179 != -215836)
												{
													this.$self_$30193.mChar.vMovement = this.$self_$30193.transform.forward;
													if (206719 - 332004 == -125285)
													{
														this.$self_$30193.mChar.moveSpeed = (float)0;
														if (169627 - 49675 != 119953)
														{
															if (this.$self_$30193.madCarron_fx)
															{
																if (140302 - 64757 != 75545)
																{
																	continue;
																}
																this.$self_$30193.audio.PlayOneShot(this.$self_$30193.madCarron_fx);
																if (287172 - 185645 != 101527)
																{
																	continue;
																}
															}
															this.$tObject$30188 = null;
															if (189020 - 138180 != 50841)
															{
																if (this.$tID$30192 != 0)
																{
																	if (209280 - 269803 != -60523)
																	{
																		continue;
																	}
																	object obj2;
																	object obj = obj2 = PhotonClient.ActorNrList[this.$tID$30192];
																	if (!(obj is GameObject))
																	{
																		obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
																	}
																	this.$tObject$30188 = (GameObject)obj2;
																	if (255110 - 512091 != -256981)
																	{
																		continue;
																	}
																}
																goto IL_56F;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_13:
				goto IL_974;
				IL_1EB:
				return this.YieldDefault(2);
				Block_17:
				IL_269:
				IL_3E9:
				goto IL_A2B;
				Block_27:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_41A:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_31:
				IL_56A:
				IL_5A6:
				Block_54:
				Block_63:
				goto IL_3E9;
				IL_974:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_A2B:
				return false;
			}

			// Token: 0x06003A25 RID: 14885 RVA: 0x00799F48 File Offset: 0x00798148
			internal static bool DsaEDk52MIxE7YOrLLJI()
			{
				return true;
			}

			// Token: 0x06003A26 RID: 14886 RVA: 0x00799F4C File Offset: 0x0079814C
			internal static bool p2tLtY52x0wERXYRqilL()
			{
				return false;
			}

			// Token: 0x0400485C RID: 18524
			internal GameObject $tObject$30188;

			// Token: 0x0400485D RID: 18525
			internal Vector3 $tPos$30189;

			// Token: 0x0400485E RID: 18526
			internal Vector3 $mPos$30190;

			// Token: 0x0400485F RID: 18527
			internal Vector3 $tDir$30191;

			// Token: 0x04004860 RID: 18528
			internal int $tID$30192;

			// Token: 0x04004861 RID: 18529
			internal MadCarron $self_$30193;
		}
	}

	// Token: 0x02000A5C RID: 2652
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack_fire$30198 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003A27 RID: 14887 RVA: 0x00799F50 File Offset: 0x00798150
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack_fire$30198(Vector3 firePos, Vector3 fireDir, MadCarron self_)
		{
			if (170197 - 575041 != -404843)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (212376 - 466903 != -254526)
				{
					base..ctor();
					if (50636 - 181467 == -130831)
					{
						this.$firePos$30207 = firePos;
						if (235763 - 183665 != 52099)
						{
							this.$fireDir$30208 = fireDir;
							if (127784 - 520511 != -392726)
							{
								this.$self_$30209 = self_;
								if (129603 - 200844 != -71240)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x0079A02C File Offset: 0x0079822C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MadCarron.$RPC_cAttack_fire$30198.$(this.$firePos$30207, this.$fireDir$30208, this.$self_$30209);
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x0079A048 File Offset: 0x00798248
		internal static bool VhMBf452gJrEeAQlPTFo()
		{
			return true;
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x0079A04C File Offset: 0x0079824C
		internal static bool XNYgHo52foLOt73wNQkl()
		{
			return false;
		}

		// Token: 0x04004862 RID: 18530
		internal Vector3 $firePos$30207;

		// Token: 0x04004863 RID: 18531
		internal Vector3 $fireDir$30208;

		// Token: 0x04004864 RID: 18532
		internal MadCarron $self_$30209;

		// Token: 0x02000A5D RID: 2653
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003A2B RID: 14891 RVA: 0x0079A050 File Offset: 0x00798250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 firePos, Vector3 fireDir, MadCarron self_)
			{
				if (136124 - 814 != 135310)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (106789 - 245995 != -139205)
					{
						base..ctor();
						if (99347 - 31317 == 68030)
						{
							this.$firePos$30204 = firePos;
							if (68348 - 211350 == -143002)
							{
								this.$fireDir$30205 = fireDir;
								if (119954 - 474599 == -354645)
								{
									this.$self_$30206 = self_;
									if (84639 - 480650 == -396011)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003A2C RID: 14892 RVA: 0x0079A12C File Offset: 0x0079832C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (270404 - 451403 != -180998)
				{
				}
				for (;;)
				{
					IL_28B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3F0;
					case 2:
						if (this.$self_$30206.mChar.isMine)
						{
							if (57135 - 90156 != -33021)
							{
								continue;
							}
							this.$hitLayer$30199 = 130816 - (1 << this.$self_$30206.gameObject.layer);
							if (101220 - 256447 != -155227)
							{
								continue;
							}
							this.$hitList$30200 = Damage.FindRecTarget(this.$firePos$30204 - this.$fireDir$30205, this.$fireDir$30205, 0.5f, 0.5f, (float)2, (float)3, this.$hitLayer$30199);
							if (94250 - 17177 != 77073)
							{
								continue;
							}
							this.$$iterator$10604$30203 = UnityRuntimeServices.GetEnumerator(this.$hitList$30200);
							if (57585 - 27756 == 29830)
							{
								continue;
							}
							while (this.$$iterator$10604$30203.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10604$30203.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30201 = (GameObject)obj2;
								if (166887 - 377436 != -210549)
								{
									goto IL_28B;
								}
								if (this.$self_$30206.mChar.hit(1, this.$hitObject$30201, (int)(1.5f * (float)this.$self_$30206.mChar.atk), 3, 0, (float)3 * this.$self_$30206.transform.forward) != 0)
								{
									if (220892 - 289282 == -68389)
									{
										goto IL_28B;
									}
									this.$hitPos$30202 = this.$hitObject$30201.collider.ClosestPointOnBounds(this.$firePos$30204 - this.$fireDir$30205 + Vector3.up);
									if (166650 - 468314 != -301664)
									{
										goto IL_28B;
									}
									UnityRuntimeServices.Update(this.$$iterator$10604$30203, this.$hitObject$30201);
									if (32378 - 149067 != -116689)
									{
										goto IL_28B;
									}
									this.$self_$30206.RPC_cAttack_hit(this.$hitPos$30202, this.$self_$30206.transform.forward, 0);
									if (107504 - 170023 == -62518)
									{
										goto IL_28B;
									}
									if (PhotonClient.IsInitialized())
									{
										if (136261 - 475999 != -339738)
										{
											goto IL_28B;
										}
										this.$self_$30206.ActionEvent("RPC_cAttack_hit", this.$hitPos$30202, this.$self_$30206.transform.forward, 0);
										if (188960 - 532123 != -343163)
										{
											goto IL_28B;
										}
									}
								}
							}
							if (52494 - 274677 != -222183)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (105952 - 102714 != 3238)
						{
							continue;
						}
						goto IL_3F0;
					default:
						if (187323 - 332953 != -145630)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30206.cAttack_fire)
					{
						if (142060 - 103269 == 38791)
						{
							UnityEngine.Object.Instantiate(this.$self_$30206.cAttack_fire, this.$firePos$30204, Quaternion.LookRotation(this.$fireDir$30205));
							if (4437 - 428016 == -423579)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find cAttack_fire effect");
						if (231566 - 329083 == -97517)
						{
							break;
						}
					}
				}
				IL_F5:
				return this.Yield(2, new WaitForSeconds(0.2f));
				goto IL_F5;
				IL_3F0:
				return false;
			}

			// Token: 0x06003A2D RID: 14893 RVA: 0x0079A53C File Offset: 0x0079873C
			internal static bool fWnAKg52nwEtPxxTcVd3()
			{
				return true;
			}

			// Token: 0x06003A2E RID: 14894 RVA: 0x0079A540 File Offset: 0x00798740
			internal static bool DsGh9H5267JtQsSfSr3p()
			{
				return false;
			}

			// Token: 0x04004865 RID: 18533
			internal int $hitLayer$30199;

			// Token: 0x04004866 RID: 18534
			internal UnityScript.Lang.Array $hitList$30200;

			// Token: 0x04004867 RID: 18535
			internal GameObject $hitObject$30201;

			// Token: 0x04004868 RID: 18536
			internal Vector3 $hitPos$30202;

			// Token: 0x04004869 RID: 18537
			internal IEnumerator $$iterator$10604$30203;

			// Token: 0x0400486A RID: 18538
			internal Vector3 $firePos$30204;

			// Token: 0x0400486B RID: 18539
			internal Vector3 $fireDir$30205;

			// Token: 0x0400486C RID: 18540
			internal MadCarron $self_$30206;
		}
	}

	// Token: 0x02000A5E RID: 2654
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30210 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003A2F RID: 14895 RVA: 0x0079A544 File Offset: 0x00798744
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30210(UnityScript.Lang.Array nArray, MadCarron self_)
		{
			if (216578 - 265268 != -48689)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (29299 - 78492 != -49192)
				{
					base..ctor();
					if (55203 - 117670 != -62466)
					{
						this.$nArray$30215 = nArray;
						if (133788 - 316692 == -182904)
						{
							this.$self_$30216 = self_;
							if (39294 - 14246 != 25049)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x0079A600 File Offset: 0x00798800
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MadCarron.$RPC_dead$30210.$(this.$nArray$30215, this.$self_$30216);
		}

		// Token: 0x06003A31 RID: 14897 RVA: 0x0079A614 File Offset: 0x00798814
		internal static bool jndX1Y52i6J1X2EYuLB3()
		{
			return true;
		}

		// Token: 0x06003A32 RID: 14898 RVA: 0x0079A618 File Offset: 0x00798818
		internal static bool siUIbN52KBLXN0Qaebip()
		{
			return false;
		}

		// Token: 0x0400486D RID: 18541
		internal UnityScript.Lang.Array $nArray$30215;

		// Token: 0x0400486E RID: 18542
		internal MadCarron $self_$30216;

		// Token: 0x02000A5F RID: 2655
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003A33 RID: 14899 RVA: 0x0079A61C File Offset: 0x0079881C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MadCarron self_)
			{
				if (191592 - 529109 != -337516)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (108907 - 32950 != 75958)
					{
						base..ctor();
						if (133685 - 202587 == -68902)
						{
							this.$nArray$30213 = nArray;
							if (56342 - 533051 != -476708)
							{
								this.$self_$30214 = self_;
								if (215655 - 103030 == 112625)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003A34 RID: 14900 RVA: 0x0079A6D8 File Offset: 0x007988D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (146764 - 183009 != -36244)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_493;
					case 2:
						if (this.$self_$30214.mChar.actionState != "dead")
						{
							if (102070 - 570191 != -468121)
							{
								continue;
							}
							goto IL_1B6;
						}
						else
						{
							if (!this.$self_$30214.mChar.isPlayer)
							{
								if (290082 - 254703 != 35379)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$30214.gameObject);
								if (204199 - 44949 != 159250)
								{
									continue;
								}
							}
							else if (this.$self_$30214.mChar.isMine)
							{
								if (234475 - 242754 == -8278)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30214.gameObject);
								if (169770 - 547703 == -377932)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (209844 - 496926 != -287081)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					default:
						if (5192 - 339737 != -334545)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30214.mChar.actionState == "dead")
					{
						if (160074 - 595981 != -435906)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30211 = (Vector3)this.$nArray$30213[0];
						if (165640 - 457335 == -291695)
						{
							this.$myDirection$30212 = (Vector3)this.$nArray$30213[1];
							if (218188 - 568950 != -350761)
							{
								this.$self_$30214.transform.position = this.$myPosition$30211;
								if (20499 - 99303 != -78803)
								{
									this.$self_$30214.transform.LookAt(this.$myPosition$30211 + this.$myDirection$30212);
									if (78948 - 380076 == -301128)
									{
										this.$self_$30214.mChar.hp = 0;
										if (128851 - 514073 != -385221)
										{
											this.$self_$30214.mChar.actionState = "dead";
											if (54279 - 517718 != -463438)
											{
												this.$self_$30214.mChar.actionTime = Time.time;
												if (154809 - 90229 == 64580)
												{
													this.$self_$30214.mChar.myCommand = "none";
													if (216847 - 546368 == -329521)
													{
														this.$self_$30214.mChar.vMovement = Vector3.zero;
														if (79796 - 385407 != -305610)
														{
															this.$self_$30214.mChar.moveSpeed = (float)0;
															if (240868 - 126190 == 114678)
															{
																this.$self_$30214.animation.Rewind();
																if (26542 - 336786 != -310243)
																{
																	this.$self_$30214.animation.Play("ko");
																	if (109549 - 283719 != -174169)
																	{
																		this.$self_$30214.animation.wrapMode = WrapMode.Once;
																		if (277940 - 254402 != 23539)
																		{
																			if (!this.$self_$30214.madCarron_fx)
																			{
																				goto IL_77;
																			}
																			if (6122 - 302327 != -296204)
																			{
																				this.$self_$30214.audio.PlayOneShot(this.$self_$30214.madCarron_fx);
																				if (119789 - 393943 == -274154)
																				{
																					goto IL_77;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_493;
				IL_77:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_1B6:
				IL_493:
				return false;
			}

			// Token: 0x06003A35 RID: 14901 RVA: 0x0079AB8C File Offset: 0x00798D8C
			internal static bool GaZk4T52d1s1AYRPLq6e()
			{
				return true;
			}

			// Token: 0x06003A36 RID: 14902 RVA: 0x0079AB90 File Offset: 0x00798D90
			internal static bool Aq8gni52JUuoyqhHMTS7()
			{
				return false;
			}

			// Token: 0x0400486F RID: 18543
			internal Vector3 $myPosition$30211;

			// Token: 0x04004870 RID: 18544
			internal Vector3 $myDirection$30212;

			// Token: 0x04004871 RID: 18545
			internal UnityScript.Lang.Array $nArray$30213;

			// Token: 0x04004872 RID: 18546
			internal MadCarron $self_$30214;
		}
	}
}
