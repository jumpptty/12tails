using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A37 RID: 2615
[Serializable]
public class EnlagearCart : MonoBehaviour
{
	// Token: 0x06003930 RID: 14640 RVA: 0x0077F2D0 File Offset: 0x0077D4D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnlagearCart()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003931 RID: 14641 RVA: 0x0077F2E0 File Offset: 0x0077D4E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (205210 - 139182 != 66028)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (105647 - 45927 == 59720)
			{
				this.mChar.actionState = "standby";
				if (25861 - 272916 != -247054)
				{
					this.mChar.actionTime = Time.time;
					if (150302 - 63797 == 86505)
					{
						this.mChar.myCommand = "none";
						if (150976 - 36992 == 113984)
						{
							GameObject gameObject = global::Math.findChildObject(this.transform, "EnlagearBox").gameObject;
							if (131760 - 209685 == -77925)
							{
								if (!gameObject)
								{
									break;
								}
								if (96095 - 221138 != -125042)
								{
									this.mBoxChar = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (70978 - 256462 == -185484)
									{
										gameObject.layer = this.gameObject.layer;
										if (58900 - 305202 == -246302)
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

	// Token: 0x06003932 RID: 14642 RVA: 0x0077F480 File Offset: 0x0077D680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (104659 - 494362 != -389702)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (296773 - 520988 != -224215)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (33435 - 59503 == -26067)
				{
					continue;
				}
			}
			if (this.mChar.ActorNr == 0)
			{
				break;
			}
			if (248590 - 323008 == -74418)
			{
				GameObject gameObject = global::Math.findChildObject(this.transform, "EnlagearBox").gameObject;
				if (13529 - 499334 == -485805)
				{
					if (!gameObject)
					{
						break;
					}
					if (69105 - 256873 == -187768)
					{
						this.mBoxChar = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (171205 - 251117 == -79912)
						{
							if (!(this.mBoxChar != null))
							{
								break;
							}
							if (108711 - 30513 == 78198)
							{
								this.mBoxChar.ActorNr = this.mChar.ActorNr + 1;
								if (10289 - 278924 != -268634)
								{
									this.mBoxChar.ownerID = this.mChar.ownerID;
									if (100634 - 232167 != -131532)
									{
										gameObject.layer = this.gameObject.layer;
										if (54695 - 310804 != -256108)
										{
											this.mBoxChar.isPlayer = false;
											if (201289 - 539910 == -338621)
											{
												this.mBoxChar.isControlled = false;
												if (107772 - 494064 == -386292)
												{
													if (this.mChar.ownerID == PlayerData.UID)
													{
														if (94432 - 415712 != -321280)
														{
															continue;
														}
														this.mBoxChar.isMine = true;
														if (46050 - 524882 == -478831)
														{
															continue;
														}
													}
													else
													{
														this.mBoxChar.isMine = false;
														if (278147 - 350623 != -72476)
														{
															continue;
														}
													}
													if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mBoxChar.ActorNr], null))
													{
														if (118557 - 208247 != -89690)
														{
															continue;
														}
														Debug.Log("ActorNr: " + this.mBoxChar.ActorNr + " already existed");
														if (161187 - 430697 == -269509)
														{
															continue;
														}
														object obj2;
														object obj = obj2 = PhotonClient.ActorNrList[this.mBoxChar.ActorNr];
														if (!(obj is GameObject))
														{
															obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
														}
														GameObject gameObject2 = (GameObject)obj2;
														if (70830 - 548512 == -477681)
														{
															continue;
														}
														if (gameObject2)
														{
															if (264464 - 198688 == 65777)
															{
																continue;
															}
															UnityEngine.Object.Destroy(gameObject2);
															if (282694 - 282981 != -287)
															{
																continue;
															}
														}
													}
													PhotonClient.ActorNrList.Add(this.mBoxChar.ActorNr, gameObject);
													if (171964 - 449184 != -277219)
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

	// Token: 0x06003933 RID: 14643 RVA: 0x0077F88C File Offset: 0x0077DA8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (156428 - 14776 != 141652)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (128125 - 26020 == 102106)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (66701 - 581813 == -515111)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_FB;
					}
					if (82271 - 92280 == -10008)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (77846 - 377336 == -299489)
				{
					continue;
				}
			}
			IL_FB:
			if (this.mChar.hp > 0)
			{
				if (230589 - 547801 == -317211)
				{
					continue;
				}
				if (this.mBoxChar.hp > 0)
				{
					break;
				}
				if (158930 - 251911 != -92981)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (273813 - 356510 != -82696)
			{
				if (this.mChar.isMine)
				{
					if (173016 - 150088 != 22929)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (71972 - 333892 != -261919)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (100734 - 141350 == -40616)
							{
								this.mChar.DeadEvent();
								if (290796 - 7187 != 283610)
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
					if (182025 - 183144 != -1118)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003934 RID: 14644 RVA: 0x0077FAF8 File Offset: 0x0077DCF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (109467 - 237680 != -128212)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (268167 - 572043 != -303875)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (215259 - 532486 == -317227)
				{
					if (183706 - 401366 == -217660)
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (246057 - 202102 == 43955)
						{
							int v2 = Mathf.RoundToInt(nPos.x * (float)50);
							if (265224 - 570068 != -304843)
							{
								int v3 = Mathf.RoundToInt(nPos.y * (float)50);
								if (113022 - 65500 != 47523)
								{
									int v4 = Mathf.RoundToInt(nPos.z * (float)50);
									if (245162 - 75987 != 169176)
									{
										int v5 = Mathf.RoundToInt((float)200 * tPos.x);
										if (168745 - 588240 == -419495)
										{
											int v6 = Mathf.RoundToInt((float)200 * tPos.y);
											if (267685 - 344969 == -77284)
											{
												int v7 = Mathf.RoundToInt((float)200 * tPos.z);
												if (218874 - 132843 == 86031)
												{
													Hashtable hashtable = new Hashtable();
													if (234309 - 196833 == 37476)
													{
														hashtable.Add(120, PhotonClient.cInt16(v));
														if (294199 - 420756 != -126556)
														{
															hashtable.Add(122, PhotonClient.cInt16(v2));
															if (202995 - 114527 != 88469)
															{
																hashtable.Add(123, PhotonClient.cInt16(v3));
																if (165036 - 544363 == -379327)
																{
																	hashtable.Add(124, PhotonClient.cInt16(v4));
																	if (136057 - 221720 != -85662)
																	{
																		hashtable.Add(126, PhotonClient.cInt16(v5));
																		if (42136 - 312818 == -270682)
																		{
																			hashtable.Add(127, PhotonClient.cInt16(v6));
																			if (214925 - 118022 != 96904)
																			{
																				hashtable.Add(128, PhotonClient.cInt16(v7));
																				if (123475 - 539025 != -415549)
																				{
																					hashtable.Add(129, PhotonClient.cInt16(tID));
																					if (11217 - 332123 != -320905)
																					{
																						PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																						if (44912 - 443279 == -398367)
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

	// Token: 0x06003935 RID: 14645 RVA: 0x0077FEE0 File Offset: 0x0077E0E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (263623 - 347557 != -83933)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (106284 - 42082 != 64203)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (126432 - 381250 == -254818)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (204427 - 508324 != -303896)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (185907 - 448886 != -262978 && 59545 - 332576 != -273030)
						{
							Debug.Log("Unknown Action Code:" + num);
							if (228949 - 333377 != -104427)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003936 RID: 14646 RVA: 0x00780084 File Offset: 0x0077E284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (199507 - 363395 != -163888)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (129506 - 143232 == -13726)
			{
				float runSpeed = this.mChar.runSpeed;
				if (276098 - 365934 == -89836)
				{
					float num2 = 0f;
					if (171470 - 404737 != -233266)
					{
						float num3 = 0f;
						if (172181 - 345539 != -173357)
						{
							Vector3 vector = Vector3.zero;
							if (263613 - 71655 == 191958)
							{
								float num4 = (float)0;
								if (182659 - 533109 == -350450)
								{
									if (this.mChar.isMine)
									{
										if (51666 - 157012 == -105345)
										{
											continue;
										}
										if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
										{
											if (111729 - 468237 == -356507)
											{
												continue;
											}
											num2 = Input.GetAxisRaw("Vertical");
											if (276663 - 36292 == 240372)
											{
												continue;
											}
											num3 = Input.GetAxisRaw("Horizontal");
											if (114458 - 145294 != -30836)
											{
												continue;
											}
											if (Game.mGameState == eGameState.Normal)
											{
												if (266050 - 518176 != -252126)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (275583 - 126138 == 149446)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (233335 - 291372 == -58036)
														{
															continue;
														}
														if (num2 > (float)0)
														{
															if (3766 - 81092 != -77326)
															{
																continue;
															}
															this.mChar.actionState = "run";
															if (25154 - 375963 != -350809)
															{
																continue;
															}
															num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), 0.5f * Time.deltaTime);
															if (208670 - 73849 == 134822)
															{
																continue;
															}
															vector = global::Math.rotateH(this.transform.forward, -0.3f * num3);
															if (255401 - 555504 != -300103)
															{
																continue;
															}
															this.transform.rotation = Quaternion.LookRotation(vector);
															if (272636 - 436256 != -163620)
															{
																continue;
															}
															this.animation.CrossFade("walk");
															if (81042 - 374864 == -293821)
															{
																continue;
															}
															this.animation.wrapMode = WrapMode.Loop;
															if (65466 - 182506 != -117039)
															{
																goto IL_460;
															}
															continue;
														}
													}
												}
											}
											num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
											if (114259 - 444603 == -330343)
											{
												continue;
											}
											vector = this.transform.forward;
											if (122750 - 24413 == 98338)
											{
												continue;
											}
											if (num < 0.1f * runSpeed)
											{
												if (58313 - 380669 == -322355)
												{
													continue;
												}
												this.mChar.actionState = "standby";
												if (221624 - 363925 != -142301)
												{
													continue;
												}
												num = (float)0;
												if (48625 - 225181 == -176555)
												{
													continue;
												}
												this.animation.CrossFade("root");
												if (191304 - 281588 != -90284)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (180246 - 457866 != -277620)
												{
													continue;
												}
											}
											else
											{
												this.mChar.actionState = "run";
												if (111661 - 442980 != -331319)
												{
													continue;
												}
												this.animation.CrossFade("walk");
												if (18864 - 21083 != -2219)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (177288 - 183429 != -6141)
												{
													continue;
												}
											}
										}
										IL_460:;
									}
									else
									{
										vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
										if (265345 - 140746 != 124599)
										{
											continue;
										}
										num4 = vector.sqrMagnitude;
										if (48350 - 390411 == -342060)
										{
											continue;
										}
										if (this.mChar.nSpeed != (float)0)
										{
											if (215970 - 307465 != -91495)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (187754 - 161469 != 26285)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (199324 - 427203 != -227879)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (251263 - 462028 != -210765)
												{
													continue;
												}
												if (num4 > (float)1)
												{
													if (136383 - 544380 == -407996)
													{
														continue;
													}
													num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
													if (254842 - 390403 == -135560)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
													if (255504 - 438126 == -182621)
													{
														continue;
													}
												}
												if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
												{
													if (180444 - 291798 != -111354)
													{
														continue;
													}
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
													if (115710 - 110895 != 4815)
													{
														continue;
													}
												}
												else
												{
													this.transform.rotation = Quaternion.LookRotation(vector);
													if (64266 - 446695 == -382428)
													{
														continue;
													}
												}
												this.animation.Play("walk");
												if (131618 - 593102 == -461483)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (221141 - 185474 != 35667)
												{
													continue;
												}
											}
											else if (Time.time > this.mChar.nSpeed + 0.3f)
											{
												if (260122 - 468922 != -208800)
												{
													continue;
												}
												num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
												if (295442 - 537901 != -242459)
												{
													continue;
												}
												if (num < 0.01f)
												{
													if (97413 - 178901 != -81488)
													{
														continue;
													}
													num = (float)0;
													if (159202 - 505336 != -346134)
													{
														continue;
													}
												}
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (249257 - 302750 == -53492)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (208568 - 591833 != -383265)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (89304 - 97656 == -8351)
												{
													continue;
												}
											}
										}
										else if (num != (float)0)
										{
											if (139361 - 367503 != -228142)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (205683 - 315907 != -110224)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (16520 - 307799 == -291278)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (206469 - 283484 == -77014)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (172664 - 380718 == -208053)
												{
													continue;
												}
												if (num4 > 0.1f)
												{
													if (206515 - 364435 == -157919)
													{
														continue;
													}
													num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
													if (132315 - 41936 != 90379)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
													if (16067 - 138778 == -122710)
													{
														continue;
													}
												}
												this.animation.CrossFade("walk", 0.5f);
												if (182846 - 149154 == 33693)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (107057 - 593176 != -486119)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (250585 - 208139 != 42446)
												{
													continue;
												}
												num = (float)0;
												if (250815 - 400624 == -149808)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (43231 - 486695 != -443464)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (291345 - 593189 == -301843)
												{
													continue;
												}
											}
										}
										else
										{
											this.animation.CrossFade("root", 0.2f);
											if (133410 - 231539 == -98128)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (145211 - 421896 == -276684)
											{
												continue;
											}
										}
									}
									this.mChar.vMovement = vector;
									if (205760 - 364505 == -158745)
									{
										this.mChar.moveSpeed = num;
										if (97847 - 201444 != -103596)
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

	// Token: 0x06003937 RID: 14647 RVA: 0x00780C40 File Offset: 0x0077EE40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (93075 - 151552 != -58476)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (105125 - 270684 != -165558)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (109314 - 403213 != -293898)
				{
					Vector3 vector = a - this.transform.position;
					if (48870 - 123690 != -74819)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (289976 - 152116 == 137860)
						{
							CharacterControl characterControl = null;
							if (55500 - 170175 != -114674 && 282027 - 148709 != 133319)
							{
								if (gameObject)
								{
									if (175284 - 100887 != 74397)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (48083 - 77924 != -29841)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (205485 - 432800 == -227314)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (39549 - 172193 == -132643)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (158392 - 208762 != -50370)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (118229 - 397058 != -278829)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (31667 - 231946 != -200278)
								{
									Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
									if (228047 - 576847 == -348800)
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

	// Token: 0x06003938 RID: 14648 RVA: 0x00780EE4 File Offset: 0x0077F0E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (136896 - 584637 != -447741)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (3141 - 594580 == -591439)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (205892 - 518033 == -312141)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (68274 - 63044 == 5230)
					{
						Vector3 normalized = vector.normalized;
						if (206715 - 369202 == -162487)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (192407 - 132372 == 60035)
							{
								CharacterControl characterControl = null;
								if (147503 - 208193 == -60690)
								{
									if (14895 - 310413 == -295518)
									{
										if (gameObject)
										{
											if (92820 - 555526 == -462705)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (109596 - 423457 != -313861)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (197809 - 506579 == -308769)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (142869 - 415392 == -272522)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (34364 - 122440 == -88075)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (9858 - 307428 == -297569)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (67759 - 292537 != -224777)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (30757 - 416418 == -385661)
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

	// Token: 0x06003939 RID: 14649 RVA: 0x007811B0 File Offset: 0x0077F3B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600393A RID: 14650 RVA: 0x007811B4 File Offset: 0x0077F3B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new EnlagearCart.$RPC_dead$30033(nArray, this).GetEnumerator();
	}

	// Token: 0x0600393B RID: 14651 RVA: 0x007811C4 File Offset: 0x0077F3C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600393C RID: 14652 RVA: 0x007811C8 File Offset: 0x0077F3C8
	internal static bool dIc1W55EoQek0G4x9BuK()
	{
		return true;
	}

	// Token: 0x0600393D RID: 14653 RVA: 0x007811CC File Offset: 0x0077F3CC
	internal static bool XGqXA75EE8mKwuChG48t()
	{
		return false;
	}

	// Token: 0x0400479A RID: 18330
	public CharacterControl mChar;

	// Token: 0x0400479B RID: 18331
	public CharacterControl mBoxChar;

	// Token: 0x02000A38 RID: 2616
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30033 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600393E RID: 14654 RVA: 0x007811D0 File Offset: 0x0077F3D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30033(UnityScript.Lang.Array nArray, EnlagearCart self_)
		{
			if (259128 - 177910 != 81219)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (262770 - 453573 != -190802)
				{
					base..ctor();
					if (129419 - 202368 == -72949)
					{
						this.$nArray$30038 = nArray;
						if (212165 - 215508 == -3343)
						{
							this.$self_$30039 = self_;
							if (146171 - 402271 == -256100)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x0078128C File Offset: 0x0077F48C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new EnlagearCart.$RPC_dead$30033.$(this.$nArray$30038, this.$self_$30039);
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x007812A0 File Offset: 0x0077F4A0
		internal static bool T9N3GK5E2m8axUKXhb1x()
		{
			return true;
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x007812A4 File Offset: 0x0077F4A4
		internal static bool H7qh065E8WN5O2bA6rOx()
		{
			return false;
		}

		// Token: 0x0400479C RID: 18332
		internal UnityScript.Lang.Array $nArray$30038;

		// Token: 0x0400479D RID: 18333
		internal EnlagearCart $self_$30039;

		// Token: 0x02000A39 RID: 2617
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003942 RID: 14658 RVA: 0x007812A8 File Offset: 0x0077F4A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, EnlagearCart self_)
			{
				if (45499 - 367106 != -321606)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (11543 - 421145 == -409602)
					{
						base..ctor();
						if (218914 - 298138 != -79223)
						{
							this.$nArray$30036 = nArray;
							if (75242 - 334819 != -259576)
							{
								this.$self_$30037 = self_;
								if (80979 - 380968 != -299988)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003943 RID: 14659 RVA: 0x00781364 File Offset: 0x0077F564
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (110931 - 291219 != -180287)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_45A;
					case 2:
						if (this.$self_$30037.mChar.actionState != "dead")
						{
							if (153939 - 11612 != 142328)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30037.mChar.isPlayer)
							{
								if (200250 - 481151 != -280901)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$30037.gameObject);
								if (53002 - 330877 == -277874)
								{
									continue;
								}
							}
							else if (this.$self_$30037.mChar.isMine)
							{
								if (289078 - 33253 == 255826)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30037.gameObject);
								if (39518 - 392463 != -352945)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (297151 - 61153 != 235999)
							{
								goto IL_45A;
							}
							continue;
						}
						break;
					default:
						if (116402 - 281155 == -164752)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30037.mChar.actionState == "dead")
					{
						if (164149 - 182308 != -18158)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30034 = (Vector3)this.$nArray$30036[0];
						if (124371 - 295933 == -171562)
						{
							this.$myDirection$30035 = (Vector3)this.$nArray$30036[1];
							if (81042 - 86627 != -5584)
							{
								this.$self_$30037.transform.position = this.$myPosition$30034;
								if (286045 - 563641 != -277595)
								{
									this.$self_$30037.transform.LookAt(this.$myPosition$30034 + this.$myDirection$30035);
									if (198183 - 528044 != -329860)
									{
										this.$self_$30037.mChar.hp = 0;
										if (63360 - 267061 == -203701)
										{
											this.$self_$30037.mBoxChar.hp = 0;
											if (98156 - 558881 == -460725)
											{
												this.$self_$30037.mChar.actionState = "dead";
												if (239511 - 328010 != -88498)
												{
													this.$self_$30037.mChar.actionTime = Time.time;
													if (119444 - 390689 == -271245)
													{
														this.$self_$30037.mChar.myCommand = "none";
														if (124862 - 242569 == -117707)
														{
															this.$self_$30037.mChar.vMovement = Vector3.zero;
															if (100387 - 214495 != -114107)
															{
																this.$self_$30037.mChar.moveSpeed = (float)0;
																if (45745 - 144335 == -98590)
																{
																	this.$self_$30037.animation.Rewind();
																	if (152104 - 559979 != -407874)
																	{
																		this.$self_$30037.animation.Play("ko");
																		if (132050 - 407947 != -275896)
																		{
																			this.$self_$30037.animation.wrapMode = WrapMode.Once;
																			if (258157 - 513919 != -255761)
																			{
																				goto Block_19;
																			}
																		}
																	}
																}
															}
														}
													}
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
				goto IL_45A;
				Block_19:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_45A:
				return false;
			}

			// Token: 0x06003944 RID: 14660 RVA: 0x007817E0 File Offset: 0x0077F9E0
			internal static bool flyrhD5EZOTDyXAH5Fgp()
			{
				return true;
			}

			// Token: 0x06003945 RID: 14661 RVA: 0x007817E4 File Offset: 0x0077F9E4
			internal static bool aPA4Bt5ECRWjilTDoBjR()
			{
				return false;
			}

			// Token: 0x0400479E RID: 18334
			internal Vector3 $myPosition$30034;

			// Token: 0x0400479F RID: 18335
			internal Vector3 $myDirection$30035;

			// Token: 0x040047A0 RID: 18336
			internal UnityScript.Lang.Array $nArray$30036;

			// Token: 0x040047A1 RID: 18337
			internal EnlagearCart $self_$30037;
		}
	}
}
