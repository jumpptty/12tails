using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D24 RID: 3364
[Serializable]
public class Owl2 : MonoBehaviour
{
	// Token: 0x06004BA2 RID: 19362 RVA: 0x00959B24 File Offset: 0x00957D24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Owl2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004BA3 RID: 19363 RVA: 0x00959B34 File Offset: 0x00957D34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (149485 - 235067 != -85582)
		{
		}
		for (;;)
		{
			this.VB3cc6bxnQW = this.transform;
			if (63217 - 131097 != -67879)
			{
				this.OYfcctLT9RY = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (216734 - 8139 != 208596)
				{
					this.OYfcctLT9RY.actionState = "standby";
					if (106419 - 262724 != -156304)
					{
						this.OYfcctLT9RY.actionTime = Time.time;
						if (144278 - 221763 == -77485)
						{
							this.OYfcctLT9RY.myCommand = "none";
							if (269311 - 260249 == 9062)
							{
								if (Game.mGameType == 99)
								{
									if (121078 - 593302 != -472224)
									{
										continue;
									}
									this.OYfcctLT9RY.isMine = true;
									if (285054 - 10474 != 274580)
									{
										continue;
									}
								}
								if (PlayerPrefs.GetInt("pvoice", 1) == 0)
								{
									break;
								}
								if (168153 - 312590 == -144437)
								{
									if (!this.OYfcctLT9RY.isSummon)
									{
										break;
									}
									if (181686 - 585739 != -404052)
									{
										if (this.awake_vc)
										{
											if (239289 - 57908 == 181381)
											{
												this.audio.PlayOneShot(this.awake_vc);
												if (61472 - 272896 == -211424)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Missing awake_vc audio");
											if (122800 - 590494 == -467694)
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

	// Token: 0x06004BA4 RID: 19364 RVA: 0x00959D64 File Offset: 0x00957F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (280456 - 457168 != -176712)
		{
		}
		for (;;)
		{
			if (this.OYfcctLT9RY.isControlled)
			{
				if (275886 - 341068 == -65181)
				{
					continue;
				}
				if (!(this.OYfcctLT9RY.actionState == "standby"))
				{
					if (73291 - 427658 == -354366)
					{
						continue;
					}
					if (!(this.OYfcctLT9RY.actionState == "run"))
					{
						goto IL_93;
					}
					if (181866 - 565205 == -383338)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (159854 - 356553 != -196699)
				{
					continue;
				}
			}
			IL_93:
			if (this.OYfcctLT9RY.hp <= 0)
			{
				if (193936 - 252303 == -58366)
				{
					continue;
				}
				if (this.OYfcctLT9RY.actionState != "dead")
				{
					if (209542 - 542607 != -333065)
					{
						continue;
					}
					if (this.OYfcctLT9RY.isMine)
					{
						if (55442 - 536436 != -480994)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.VB3cc6bxnQW.position,
							this.VB3cc6bxnQW.forward
						})));
						if (64347 - 236358 == -172010)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (152118 - 598506 != -446388)
						{
							continue;
						}
						this.OYfcctLT9RY.DeadEvent();
						if (87554 - 448371 != -360816)
						{
							break;
						}
						continue;
					}
					else
					{
						this.OYfcctLT9RY.hp = 1;
						if (184433 - 232075 != -47642)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.OYfcctLT9RY.hp <= 0)
			{
				break;
			}
			if (89250 - 453771 == -364521)
			{
				if (this.OYfcctLT9RY.ko > 0)
				{
					break;
				}
				if (35481 - 63238 == -27757)
				{
					if (!(this.OYfcctLT9RY.actionState != "ko"))
					{
						break;
					}
					if (68059 - 69349 != -1289)
					{
						if (!(this.OYfcctLT9RY.actionState != "dead"))
						{
							break;
						}
						if (245969 - 271938 == -25969)
						{
							if (this.OYfcctLT9RY.isMine)
							{
								if (1036 - 576777 == -575741)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.VB3cc6bxnQW.position,
										this.VB3cc6bxnQW.forward
									})));
									if (16005 - 74174 == -58169)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (299186 - 416361 != -117174)
										{
											this.OYfcctLT9RY.KoEvent();
											if (139162 - 582468 == -443306)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.OYfcctLT9RY.ko = 1;
								if (120817 - 50705 != 70113)
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

	// Token: 0x06004BA5 RID: 19365 RVA: 0x0095A15C File Offset: 0x0095835C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void helpEvent()
	{
		if (297500 - 352924 != -55424)
		{
		}
		while (Time.time > this.sE9ccXX6dTv)
		{
			if (172953 - 371161 != -198207)
			{
				this.sE9ccXX6dTv = Time.time + (float)9;
				if (229209 - 529442 == -300233)
				{
					if (PlayerPrefs.GetInt("pvoice", 1) == 0)
					{
						break;
					}
					if (274757 - 348388 == -73631)
					{
						if (this.help_vc)
						{
							if (112797 - 90518 != 22280)
							{
								this.audio.PlayOneShot(this.help_vc);
								if (108624 - 137895 == -29271)
								{
									break;
								}
							}
						}
						else
						{
							Debug.LogError("Missing help voice");
							if (133747 - 384577 == -250830)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004BA6 RID: 19366 RVA: 0x0095A290 File Offset: 0x00958490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (208551 - 461501 != -252950)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (185983 - 362480 == -176497)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (57899 - 26211 != 31689)
				{
					if (80778 - 129826 == -49048)
					{
						if (ActionName == "RPC_potion")
						{
							if (168971 - 387213 == -218241)
							{
								continue;
							}
							v = 11;
							if (135603 - 225670 != -90067)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_potion_hit")
						{
							if (247930 - 60397 == 187534)
							{
								continue;
							}
							v = -11;
							if (81730 - 71598 == 10133)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (74491 - 326826 == -252334)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (203139 - 50493 == 152646)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (75458 - 95685 != -20226)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (208482 - 494427 != -285944)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (257425 - 201831 != 55595)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (229697 - 161226 != 68472)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (211912 - 227108 == -15196)
											{
												Hashtable hashtable = new Hashtable();
												if (69539 - 94360 != -24820)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (225430 - 154744 != 70687)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (57856 - 1704 != 56153)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (85342 - 336541 != -251198)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (175256 - 165791 != 9466)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (290655 - 15097 != 275559)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (191054 - 257359 == -66305)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (224367 - 208955 == 15412)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (279830 - 599971 != -320140)
																				{
																					PhotonClient.SendEvent(this.OYfcctLT9RY.ActorNr, 74, hashtable, true, true);
																					if (247443 - 270594 == -23151)
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

	// Token: 0x06004BA7 RID: 19367 RVA: 0x0095A710 File Offset: 0x00958910
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (19177 - 309488 != -290310)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (80532 - 446052 != -365519)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (280764 - 258943 != 21822)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (142959 - 134594 != 8366)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (137801 - 595040 == -457239)
						{
							int num3 = num;
							if (147307 - 415626 == -268319)
							{
								if (num3 == 11)
								{
									if (35006 - 593989 != -558982)
									{
										if (this.OYfcctLT9RY.isMine)
										{
											break;
										}
										if (11459 - 556396 == -544937)
										{
											this.StartCoroutine_Auto(this.RPC_potion(vector, vector2, num2));
											if (45234 - 48095 != -2860)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (265078 - 21673 == 243405)
									{
										if (this.OYfcctLT9RY.isMine)
										{
											break;
										}
										if (150527 - 582330 != -431802)
										{
											this.RPC_potion_hit(vector, vector2, num2);
											if (115483 - 289906 != -174422)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (255946 - 541396 != -285449)
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

	// Token: 0x06004BA8 RID: 19368 RVA: 0x0095A9A8 File Offset: 0x00958BA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (287107 - 531054 != -243947)
		{
		}
		for (;;)
		{
			float num = this.OYfcctLT9RY.moveSpeed;
			if (212434 - 445146 != -232711)
			{
				float runSpeed = this.OYfcctLT9RY.runSpeed;
				if (249387 - 209431 == 39956)
				{
					Vector3 a = default(Vector3);
					if (235773 - 225754 == 10019)
					{
						Vector3 vector = Vector3.zero;
						if (124205 - 98532 == 25673)
						{
							float num2 = (float)0;
							if (128437 - 556604 == -428167)
							{
								if (this.OYfcctLT9RY.isMine)
								{
									if (262640 - 154427 != 108213)
									{
										continue;
									}
									if ((this.OYfcctLT9RY.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (147375 - 249698 == -102322)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (26785 - 295740 == -268954)
										{
											continue;
										}
										a.y = (float)0;
										if (273932 - 86052 == 187881)
										{
											continue;
										}
										a = a.normalized;
										if (50265 - 486733 == -436467)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (299378 - 564211 == -264832)
										{
											continue;
										}
										vector = vector.normalized;
										if (180079 - 389890 == -209810)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (40922 - 530925 != -490003)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (119103 - 62945 != 56158)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (217137 - 469651 != -252514)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (298422 - 48637 == 249786)
														{
															continue;
														}
														this.OYfcctLT9RY.actionState = "run";
														if (53116 - 546454 != -493338)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (161762 - 142571 != 19191)
														{
															continue;
														}
														this.VB3cc6bxnQW.rotation = Quaternion.LookRotation(vector);
														if (226728 - 1085 != 225643)
														{
															continue;
														}
														this.animation.Play("run");
														if (16958 - 7486 != 9472)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (208774 - 284065 != -75291)
														{
															continue;
														}
														goto IL_20A;
													}
												}
											}
										}
										this.OYfcctLT9RY.actionState = "standby";
										if (222543 - 122423 != 100120)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (282544 - 277672 != 4872)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (176176 - 412932 != -236756)
											{
												continue;
											}
											num = (float)0;
											if (231104 - 525662 == -294557)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (186325 - 577912 == -391586)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (119001 - 2903 == 116099)
										{
											continue;
										}
									}
									IL_20A:;
								}
								else
								{
									vector = global::Math.vFlat(this.OYfcctLT9RY.nPosition - this.VB3cc6bxnQW.position);
									if (76283 - 164558 == -88274)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (211879 - 127569 != 84310)
									{
										continue;
									}
									if (this.OYfcctLT9RY.nSpeed != (float)0)
									{
										if (7424 - 519467 != -512043)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (160684 - 79029 != 81655)
											{
												continue;
											}
											this.VB3cc6bxnQW.position = this.OYfcctLT9RY.nPosition;
											if (54219 - 202402 != -148183)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (139304 - 288587 != -149283)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (227072 - 173660 != 53412)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (271748 - 1749 == 270000)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.OYfcctLT9RY.nSpeed, (float)10 * Time.deltaTime);
												if (138660 - 420292 != -281632)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.VB3cc6bxnQW.forward, vector) > 0.5f)
											{
												if (165887 - 257057 == -91169)
												{
													continue;
												}
												this.VB3cc6bxnQW.rotation = Quaternion.LookRotation(Vector3.Slerp(this.VB3cc6bxnQW.forward, vector, (float)10 * Time.deltaTime));
												if (127012 - 348968 == -221955)
												{
													continue;
												}
											}
											else
											{
												this.VB3cc6bxnQW.rotation = Quaternion.LookRotation(vector);
												if (14092 - 269336 != -255244)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (162750 - 418282 != -255532)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (120038 - 540846 != -420808)
											{
												continue;
											}
										}
										else if (Time.time > this.OYfcctLT9RY.nSpeed + 0.3f)
										{
											if (190007 - 418453 != -228446)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (178627 - 87721 == 90907)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (193444 - 187663 != 5781)
												{
													continue;
												}
												num = (float)0;
												if (294430 - 476176 == -181745)
												{
													continue;
												}
											}
											this.VB3cc6bxnQW.rotation = Quaternion.LookRotation(this.OYfcctLT9RY.nDirection);
											if (127019 - 253816 == -126796)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (50263 - 206409 != -156146)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (237622 - 452832 == -215209)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (162485 - 249323 == -86837)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (257400 - 248970 == 8431)
											{
												continue;
											}
											this.VB3cc6bxnQW.position = this.OYfcctLT9RY.nPosition;
											if (206506 - 213660 == -7153)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (199068 - 389599 != -190531)
											{
												continue;
											}
											this.VB3cc6bxnQW.rotation = Quaternion.LookRotation(Vector3.Slerp(this.VB3cc6bxnQW.forward, vector, (float)10 * Time.deltaTime));
											if (93186 - 72226 != 20960)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (118204 - 30049 == 88156)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (253038 - 155752 != 97286)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (66340 - 317169 != -250829)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (235765 - 44805 == 190961)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (164570 - 139022 == 25549)
											{
												continue;
											}
										}
										else
										{
											this.VB3cc6bxnQW.rotation = Quaternion.LookRotation(this.OYfcctLT9RY.nDirection);
											if (229677 - 134216 != 95461)
											{
												continue;
											}
											num = (float)0;
											if (52173 - 8214 != 43959)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (164107 - 324207 == -160099)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (997 - 458009 != -457012)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (43591 - 552191 != -508600)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (225411 - 262510 == -37098)
										{
											continue;
										}
									}
								}
								this.OYfcctLT9RY.vMovement = vector;
								if (143761 - 275831 != -132069)
								{
									this.OYfcctLT9RY.moveSpeed = num;
									if (281268 - 531317 != -250048)
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

	// Token: 0x06004BA9 RID: 19369 RVA: 0x0095B50C File Offset: 0x0095970C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (296900 - 575387 != -278487)
		{
		}
		for (;;)
		{
			if (!this.OYfcctLT9RY.isMine)
			{
				if (197827 - 305100 != -107272)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (96522 - 312998 == -216476)
				{
					Vector3 vector = a - this.VB3cc6bxnQW.position;
					if (115673 - 517228 != -401554)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (191981 - 250609 != -58627)
						{
							CharacterControl characterControl = null;
							if (77807 - 281923 == -204116)
							{
								if (59923 - 212122 != -152198)
								{
									if (gameObject)
									{
										if (211008 - 349904 == -138895)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (295877 - 125585 != 170292)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (231484 - 532061 != -300577)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (299323 - 296014 == 3310)
										{
											continue;
										}
									}
									if (!(this.OYfcctLT9RY.actionState == "standby"))
									{
										if (38395 - 447501 != -409106)
										{
											continue;
										}
										if (!(this.OYfcctLT9RY.actionState == "run"))
										{
											break;
										}
										if (94158 - 257161 != -163003)
										{
											continue;
										}
									}
									if (this.OYfcctLT9RY.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (232714 - 218107 == 14607)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
										if (20199 - 290827 == -270628)
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

	// Token: 0x06004BAA RID: 19370 RVA: 0x0095B7B0 File Offset: 0x009599B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (266363 - 245111 != 21253)
		{
		}
		for (;;)
		{
			if (!this.OYfcctLT9RY.isMine)
			{
				if (251462 - 249577 != 1886)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (18108 - 299104 == -280996)
				{
					Vector3 vector = global::Math.vFlat(a - this.VB3cc6bxnQW.position);
					if (204585 - 145340 == 59245)
					{
						Vector3 normalized = vector.normalized;
						if (43715 - 94938 == -51223)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (268746 - 407842 != -139095)
							{
								CharacterControl characterControl = null;
								if (87433 - 28883 == 58550)
								{
									int num = 0;
									if (125742 - 454454 == -328712)
									{
										if (gameObject)
										{
											if (156794 - 319432 == -162637)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (32867 - 588682 == -555814)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (81951 - 131827 == -49875)
											{
												continue;
											}
											num = characterControl.ActorNr;
											if (213189 - 312573 != -99384)
											{
												continue;
											}
										}
										if (!(this.OYfcctLT9RY.actionState == "standby"))
										{
											if (180352 - 179875 == 478)
											{
												continue;
											}
											if (!(this.OYfcctLT9RY.actionState == "run"))
											{
												break;
											}
											if (125994 - 465522 == -339527)
											{
												continue;
											}
										}
										if (this.OYfcctLT9RY.isTimeOut("potion") != (float)0)
										{
											break;
										}
										if (256630 - 412376 != -155745)
										{
											if (num == 0)
											{
												break;
											}
											if (56418 - 16652 == 39766)
											{
												this.StartCoroutine_Auto(this.RPC_potion(this.VB3cc6bxnQW.position, this.VB3cc6bxnQW.forward, num));
												if (11426 - 70373 != -58946)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (92196 - 164546 == -72350)
													{
														this.ActionEvent("RPC_potion", this.VB3cc6bxnQW.position, this.VB3cc6bxnQW.forward, num);
														if (16108 - 89420 != -73311)
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

	// Token: 0x06004BAB RID: 19371 RVA: 0x0095BB08 File Offset: 0x00959D08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004BAC RID: 19372 RVA: 0x0095BB0C File Offset: 0x00959D0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_potion(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Owl2.$RPC_potion$32961(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004BAD RID: 19373 RVA: 0x0095BB1C File Offset: 0x00959D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_potion_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (254545 - 361998 != -107452)
		{
		}
		while (hitID != 0)
		{
			if (137985 - 74429 != 63557)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[hitID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (277178 - 231980 != 45199)
				{
					if (!gameObject)
					{
						break;
					}
					if (123332 - 414092 != -290759)
					{
						if (this.potion_hit)
						{
							if (260289 - 163909 == 96381)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.potion_hit, gameObject.transform.position, this.VB3cc6bxnQW.rotation);
							if (9584 - 147243 != -137659)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find potion_hit effect");
							if (19058 - 276585 == -257526)
							{
								continue;
							}
						}
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (41224 - 95747 == -54523)
						{
							if (!characterControl)
							{
								break;
							}
							if (184223 - 493373 != -309149)
							{
								if (this.OYfcctLT9RY.isMine)
								{
									if (115696 - 215807 == -100110)
									{
										continue;
									}
									if (!this.OYfcctLT9RY.isSummon)
									{
										if (214840 - 15728 != 199112)
										{
											continue;
										}
										characterControl.RPC_AddHeal(11, 500, 50, 5, 0, 0, this.OYfcctLT9RY.ActorNr);
										if (271985 - 589045 != -317060)
										{
											continue;
										}
									}
									else
									{
										characterControl.RPC_AddHeal(11, 250, 25, 3, 0, 0, this.OYfcctLT9RY.ActorNr);
										if (126395 - 158798 == -32402)
										{
											continue;
										}
									}
								}
								if (this.potion_hit)
								{
									if (238208 - 287358 != -49149)
									{
										characterControl.createEffect(this.potion_hit, gameObject.transform.position, this.VB3cc6bxnQW.rotation);
										if (219368 - 219726 != -357)
										{
											break;
										}
									}
								}
								else
								{
									Debug.LogError("Cannot find potion_hit effect");
									if (60174 - 14591 == 45583)
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

	// Token: 0x06004BAE RID: 19374 RVA: 0x0095BE20 File Offset: 0x0095A020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Owl2.$RPC_ko$32971(nArray, this).GetEnumerator();
	}

	// Token: 0x06004BAF RID: 19375 RVA: 0x0095BE30 File Offset: 0x0095A030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Owl2.$RPC_dead$32978(nArray, this).GetEnumerator();
	}

	// Token: 0x06004BB0 RID: 19376 RVA: 0x0095BE40 File Offset: 0x0095A040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004BB1 RID: 19377 RVA: 0x0095BE44 File Offset: 0x0095A044
	internal static bool OqFG4V57MIQE9Sa9SN6w()
	{
		return true;
	}

	// Token: 0x06004BB2 RID: 19378 RVA: 0x0095BE48 File Offset: 0x0095A048
	internal static bool av59na57xt626HgxKkxO()
	{
		return false;
	}

	// Token: 0x0400561A RID: 22042
	private Transform VB3cc6bxnQW;

	// Token: 0x0400561B RID: 22043
	private CharacterControl OYfcctLT9RY;

	// Token: 0x0400561C RID: 22044
	public AudioClip awake_vc;

	// Token: 0x0400561D RID: 22045
	public AudioClip help_vc;

	// Token: 0x0400561E RID: 22046
	private float sE9ccXX6dTv;

	// Token: 0x0400561F RID: 22047
	public AudioClip potion1_vc;

	// Token: 0x04005620 RID: 22048
	public AudioClip potion2_vc;

	// Token: 0x04005621 RID: 22049
	public GameObject potion_hit;

	// Token: 0x04005622 RID: 22050
	public AudioClip ko_vc;

	// Token: 0x04005623 RID: 22051
	public AudioClip dead_vc;

	// Token: 0x02000D25 RID: 3365
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_potion$32961 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004BB3 RID: 19379 RVA: 0x0095BE4C File Offset: 0x0095A04C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_potion$32961(Vector3 mPos, Vector3 tDir, int tID, Owl2 self_)
		{
			if (226859 - 357404 != -130544)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (74033 - 179355 != -105321)
				{
					base..ctor();
					if (155614 - 518003 != -362388)
					{
						this.$mPos$32967 = mPos;
						if (183371 - 175790 == 7581)
						{
							this.$tDir$32968 = tDir;
							if (232773 - 327595 == -94822)
							{
								this.$tID$32969 = tID;
								if (287790 - 83853 == 203937)
								{
									this.$self_$32970 = self_;
									if (36529 - 181770 == -145241)
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

		// Token: 0x06004BB4 RID: 19380 RVA: 0x0095BF4C File Offset: 0x0095A14C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Owl2.$RPC_potion$32961.$(this.$mPos$32967, this.$tDir$32968, this.$tID$32969, this.$self_$32970);
		}

		// Token: 0x06004BB5 RID: 19381 RVA: 0x0095BF6C File Offset: 0x0095A16C
		internal static bool vTqRdE57gWxnS9C9sCuC()
		{
			return true;
		}

		// Token: 0x06004BB6 RID: 19382 RVA: 0x0095BF70 File Offset: 0x0095A170
		internal static bool iiqsvs57fLH0q9N1Xous()
		{
			return false;
		}

		// Token: 0x04005624 RID: 22052
		internal Vector3 $mPos$32967;

		// Token: 0x04005625 RID: 22053
		internal Vector3 $tDir$32968;

		// Token: 0x04005626 RID: 22054
		internal int $tID$32969;

		// Token: 0x04005627 RID: 22055
		internal Owl2 $self_$32970;

		// Token: 0x02000D26 RID: 3366
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004BB7 RID: 19383 RVA: 0x0095BF74 File Offset: 0x0095A174
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Owl2 self_)
			{
				if (192866 - 591849 != -398982)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (49076 - 108286 == -59210)
					{
						base..ctor();
						if (38380 - 35177 == 3203)
						{
							this.$mPos$32963 = mPos;
							if (207713 - 345353 == -137640)
							{
								this.$tDir$32964 = tDir;
								if (113649 - 104084 == 9565)
								{
									this.$tID$32965 = tID;
									if (208109 - 19131 != 188979)
									{
										this.$self_$32966 = self_;
										if (249848 - 499994 != -250145)
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

			// Token: 0x06004BB8 RID: 19384 RVA: 0x0095C074 File Offset: 0x0095A274
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (214691 - 39812 != 174879)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_97C;
					case 2:
						if (this.$self_$32966.OYfcctLT9RY.actionState != "attack")
						{
							goto IL_375;
						}
						if (188193 - 271983 == -83789)
						{
							continue;
						}
						if (this.$self_$32966.OYfcctLT9RY.myCommand != "potion")
						{
							if (200470 - 427139 != -226669)
							{
								continue;
							}
							goto IL_375;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_326;
							}
							if (188140 - 303848 != -115708)
							{
								continue;
							}
							if (UnityEngine.Random.Range(0, 2) == 0)
							{
								if (254658 - 90979 != 163679)
								{
									continue;
								}
								if (this.$self_$32966.potion1_vc)
								{
									if (292510 - 209404 != 83106)
									{
										continue;
									}
									this.$self_$32966.audio.PlayOneShot(this.$self_$32966.potion1_vc);
									if (151536 - 389080 != -237544)
									{
										continue;
									}
									goto IL_2D1;
								}
								else
								{
									Debug.LogError("Cannot find potion1 voice");
									if (35038 - 532768 != -497729)
									{
										goto Block_21;
									}
									continue;
								}
							}
							else if (this.$self_$32966.potion2_vc)
							{
								if (272192 - 465225 == -193032)
								{
									continue;
								}
								this.$self_$32966.audio.PlayOneShot(this.$self_$32966.potion2_vc);
								if (256421 - 60354 != 196067)
								{
									continue;
								}
								goto IL_23E;
							}
							else
							{
								Debug.LogError("Cannot find potion2 voice");
								if (264150 - 437287 != -173136)
								{
									goto Block_18;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$32966.OYfcctLT9RY.actionState != "attack")
						{
							goto IL_43;
						}
						if (211552 - 40010 != 171542)
						{
							continue;
						}
						if (this.$self_$32966.OYfcctLT9RY.myCommand != "potion")
						{
							if (183633 - 61653 != 121981)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32966.OYfcctLT9RY.isMine)
							{
								goto IL_7A3;
							}
							if (222395 - 438256 != -215861)
							{
								continue;
							}
							if (this.$tID$32965 == 0)
							{
								goto IL_7A3;
							}
							if (149324 - 575941 != -426617)
							{
								continue;
							}
							this.$self_$32966.RPC_potion_hit(this.$self_$32966.VB3cc6bxnQW.position, this.$self_$32966.VB3cc6bxnQW.forward, this.$tID$32965);
							if (4206 - 60286 != -56080)
							{
								continue;
							}
							this.$self_$32966.ActionEvent("RPC_potion_hit", this.$self_$32966.VB3cc6bxnQW.position, this.$self_$32966.VB3cc6bxnQW.forward, this.$tID$32965);
							if (135589 - 464187 != -328597)
							{
								goto Block_48;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$32966.OYfcctLT9RY.actionState == "attack")
						{
							if (298258 - 104716 == 193543)
							{
								continue;
							}
							if (this.$self_$32966.OYfcctLT9RY.myCommand == "potion")
							{
								if (162495 - 245118 != -82623)
								{
									continue;
								}
								this.$self_$32966.OYfcctLT9RY.actionState = "standby";
								if (177405 - 188848 == -11442)
								{
									continue;
								}
								this.$self_$32966.OYfcctLT9RY.actionTime = Time.time;
								if (101692 - 505017 != -403325)
								{
									continue;
								}
								this.$self_$32966.OYfcctLT9RY.myCommand = "none";
								if (120869 - 21131 == 99739)
								{
									continue;
								}
								if (!this.$self_$32966.OYfcctLT9RY.isMine)
								{
									if (79155 - 15729 == 63427)
									{
										continue;
									}
									this.$self_$32966.OYfcctLT9RY.nPosition = this.$self_$32966.VB3cc6bxnQW.position;
									if (217557 - 393052 == -175494)
									{
										continue;
									}
									this.$self_$32966.OYfcctLT9RY.oPosition = this.$self_$32966.VB3cc6bxnQW.position;
									if (283000 - 284608 == -1607)
									{
										continue;
									}
									this.$self_$32966.OYfcctLT9RY.nDirection = this.$self_$32966.VB3cc6bxnQW.forward;
									if (85901 - 178070 == -92168)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (272440 - 473934 != -201493)
						{
							goto Block_43;
						}
						continue;
					default:
						if (231387 - 495642 != -264255)
						{
							continue;
						}
						break;
					}
					this.$self_$32966.OYfcctLT9RY.actionState = "attack";
					if (10686 - 204495 != -193808)
					{
						this.$self_$32966.OYfcctLT9RY.actionTime = Time.time;
						if (254655 - 80838 != 173818)
						{
							this.$self_$32966.OYfcctLT9RY.myCommand = "potion";
							if (226312 - 249731 != -23418)
							{
								if (!this.$self_$32966.OYfcctLT9RY.isSummon)
								{
									if (210704 - 317728 != -107024)
									{
										continue;
									}
									this.$self_$32966.OYfcctLT9RY.addTimeOut("potion", (float)6);
									if (102419 - 332433 != -230014)
									{
										continue;
									}
								}
								else
								{
									this.$self_$32966.OYfcctLT9RY.addTimeOut("potion", (float)24);
									if (244123 - 394762 != -150639)
									{
										continue;
									}
								}
								this.$self_$32966.VB3cc6bxnQW.position = this.$mPos$32963;
								if (87686 - 52267 == 35419)
								{
									this.$self_$32966.VB3cc6bxnQW.LookAt(this.$mPos$32963 + global::Math.vFlat(this.$tDir$32964));
									if (257760 - 24701 == 233059)
									{
										this.$self_$32966.animation.CrossFade("potion");
										if (171197 - 553905 != -382707)
										{
											this.$self_$32966.animation.wrapMode = WrapMode.Once;
											if (152479 - 384402 == -231923)
											{
												this.$self_$32966.OYfcctLT9RY.vMovement = this.$self_$32966.VB3cc6bxnQW.forward;
												if (229930 - 398635 == -168705)
												{
													this.$self_$32966.OYfcctLT9RY.moveSpeed = (float)0;
													if (205421 - 457755 != -252333)
													{
														if (this.$self_$32966.OYfcctLT9RY.isPlayer)
														{
															goto IL_77;
														}
														if (23472 - 530191 == -506719)
														{
															if (Game.mGameCode != 914)
															{
																goto IL_77;
															}
															if (260564 - 578092 != -317527)
															{
																if (UnityEngine.Random.Range(0, 100) >= 30)
																{
																	goto IL_77;
																}
																if (17985 - 59047 == -41062)
																{
																	this.$m$32962 = Language.getMessage("M914_GuildUnderAttack", UnityEngine.Random.Range(31, 40));
																	if (220475 - 274352 == -53877)
																	{
																		if (!(this.$m$32962 != string.Empty))
																		{
																			goto IL_77;
																		}
																		if (89359 - 554202 == -464843)
																		{
																			Chat.SubmitChat("Lin Lin", "Lin Lin: " + this.$m$32962, eChatType.npc, eChatMode.system);
																			if (145451 - 129273 == 16178)
																			{
																				this.$self_$32966.OYfcctLT9RY.doChatBubble(this.$m$32962);
																				if (150341 - 34805 != 115537)
																				{
																					goto Block_20;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_43:
				goto IL_97C;
				IL_77:
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_23E:
				Block_18:
				goto IL_326;
				Block_20:
				goto IL_77;
				IL_2D1:
				Block_21:
				IL_326:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_375:
				Block_38:
				Block_43:
				goto IL_97C;
				Block_48:
				goto IL_7A3;
				goto IL_326;
				IL_7A3:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_97C:
				return false;
			}

			// Token: 0x06004BB9 RID: 19385 RVA: 0x0095CA10 File Offset: 0x0095AC10
			internal static bool ugkTNy57nfDL3IeP9Hvv()
			{
				return true;
			}

			// Token: 0x06004BBA RID: 19386 RVA: 0x0095CA14 File Offset: 0x0095AC14
			internal static bool m50R13576onlfI1bJdKD()
			{
				return false;
			}

			// Token: 0x04005628 RID: 22056
			internal string $m$32962;

			// Token: 0x04005629 RID: 22057
			internal Vector3 $mPos$32963;

			// Token: 0x0400562A RID: 22058
			internal Vector3 $tDir$32964;

			// Token: 0x0400562B RID: 22059
			internal int $tID$32965;

			// Token: 0x0400562C RID: 22060
			internal Owl2 $self_$32966;
		}
	}

	// Token: 0x02000D27 RID: 3367
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32971 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004BBB RID: 19387 RVA: 0x0095CA18 File Offset: 0x0095AC18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32971(UnityScript.Lang.Array nArray, Owl2 self_)
		{
			if (221000 - 532901 != -311901)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (80243 - 169725 != -89481)
				{
					base..ctor();
					if (183194 - 44143 != 139052)
					{
						this.$nArray$32976 = nArray;
						if (144264 - 294086 != -149821)
						{
							this.$self_$32977 = self_;
							if (160415 - 102541 == 57874)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x0095CAD4 File Offset: 0x0095ACD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Owl2.$RPC_ko$32971.$(this.$nArray$32976, this.$self_$32977);
		}

		// Token: 0x06004BBD RID: 19389 RVA: 0x0095CAE8 File Offset: 0x0095ACE8
		internal static bool wA5YNI57iYOgwJSMFNXV()
		{
			return true;
		}

		// Token: 0x06004BBE RID: 19390 RVA: 0x0095CAEC File Offset: 0x0095ACEC
		internal static bool HUeWSJ57KCJVllPj6sHA()
		{
			return false;
		}

		// Token: 0x0400562D RID: 22061
		internal UnityScript.Lang.Array $nArray$32976;

		// Token: 0x0400562E RID: 22062
		internal Owl2 $self_$32977;

		// Token: 0x02000D28 RID: 3368
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004BBF RID: 19391 RVA: 0x0095CAF0 File Offset: 0x0095ACF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Owl2 self_)
			{
				if (178072 - 310054 != -131981)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (43621 - 54120 != -10498)
					{
						base..ctor();
						if (55009 - 458068 == -403059)
						{
							this.$nArray$32974 = nArray;
							if (110748 - 584813 != -474064)
							{
								this.$self_$32975 = self_;
								if (24895 - 150883 == -125988)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004BC0 RID: 19392 RVA: 0x0095CBAC File Offset: 0x0095ADAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (244323 - 157573 != 86750)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_543;
					case 2:
						if (this.$self_$32975.OYfcctLT9RY.actionState != "ko")
						{
							if (106428 - 98792 != 7637)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$self_$32975.animation.Play("getUp");
							if (90630 - 359459 != -268829)
							{
								continue;
							}
							this.$self_$32975.animation.wrapMode = WrapMode.Once;
							if (72648 - 458981 != -386333)
							{
								continue;
							}
							goto IL_4F4;
						}
						break;
					case 3:
						if (this.$self_$32975.OYfcctLT9RY.actionState != "ko")
						{
							if (206902 - 298262 != -91360)
							{
								continue;
							}
							goto IL_37B;
						}
						else
						{
							this.$self_$32975.OYfcctLT9RY.actionState = "standby";
							if (186553 - 212625 == -26071)
							{
								continue;
							}
							this.$self_$32975.OYfcctLT9RY.actionTime = Time.time;
							if (208959 - 384516 == -175556)
							{
								continue;
							}
							this.$self_$32975.OYfcctLT9RY.myCommand = "none";
							if (71925 - 563424 == -491498)
							{
								continue;
							}
							this.$self_$32975.OYfcctLT9RY.ko = this.$self_$32975.OYfcctLT9RY.mko;
							if (282695 - 486095 == -203399)
							{
								continue;
							}
							this.YieldDefault(1);
							if (214324 - 357531 != -143206)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					default:
						if (115913 - 210635 != -94722)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32975.OYfcctLT9RY.actionState == "ko")
					{
						break;
					}
					if (27834 - 133322 == -105488)
					{
						if (this.$self_$32975.OYfcctLT9RY.actionState == "dead")
						{
							if (70061 - 112468 == -42407)
							{
								break;
							}
						}
						else
						{
							this.$mPos$32972 = (Vector3)this.$nArray$32974[0];
							if (276075 - 363616 != -87540)
							{
								this.$mDir$32973 = (Vector3)this.$nArray$32974[1];
								if (119790 - 78966 != 40825)
								{
									this.$self_$32975.OYfcctLT9RY.ko = 0;
									if (223901 - 66183 == 157718)
									{
										this.$self_$32975.OYfcctLT9RY.actionState = "ko";
										if (166156 - 179464 == -13308)
										{
											this.$self_$32975.OYfcctLT9RY.actionTime = Time.time;
											if (109557 - 361470 == -251913)
											{
												this.$self_$32975.OYfcctLT9RY.myCommand = "none";
												if (120605 - 494895 != -374289)
												{
													this.$self_$32975.OYfcctLT9RY.vMovement = Vector3.zero;
													if (1016 - 120230 == -119214)
													{
														this.$self_$32975.OYfcctLT9RY.moveSpeed = (float)0;
														if (36881 - 558416 == -521535)
														{
															this.$self_$32975.animation.Play("ko");
															if (102825 - 336553 == -233728)
															{
																this.$self_$32975.animation.wrapMode = WrapMode.Once;
																if (203008 - 34891 != 168118)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		goto IL_7F;
																	}
																	if (197027 - 512507 != -315479)
																	{
																		if (this.$self_$32975.ko_vc)
																		{
																			if (36798 - 445219 == -408421)
																			{
																				this.$self_$32975.audio.PlayOneShot(this.$self_$32975.ko_vc);
																				if (206823 - 363032 != -156208)
																				{
																					goto Block_32;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Missing ko voice");
																			if (206231 - 576877 == -370646)
																			{
																				goto IL_7F;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_543;
				IL_7F:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_6:
				IL_37B:
				Block_25:
				goto IL_543;
				Block_32:
				goto IL_7F;
				IL_4F4:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_543:
				return false;
			}

			// Token: 0x06004BC1 RID: 19393 RVA: 0x0095D110 File Offset: 0x0095B310
			internal static bool G2fGMR57dWZVpZ4aQ772()
			{
				return true;
			}

			// Token: 0x06004BC2 RID: 19394 RVA: 0x0095D114 File Offset: 0x0095B314
			internal static bool PhToF857JuZ1Ud0WEcoi()
			{
				return false;
			}

			// Token: 0x0400562F RID: 22063
			internal Vector3 $mPos$32972;

			// Token: 0x04005630 RID: 22064
			internal Vector3 $mDir$32973;

			// Token: 0x04005631 RID: 22065
			internal UnityScript.Lang.Array $nArray$32974;

			// Token: 0x04005632 RID: 22066
			internal Owl2 $self_$32975;
		}
	}

	// Token: 0x02000D29 RID: 3369
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32978 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004BC3 RID: 19395 RVA: 0x0095D118 File Offset: 0x0095B318
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32978(UnityScript.Lang.Array nArray, Owl2 self_)
		{
			if (277369 - 595414 != -318045)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (271766 - 325536 != -53769)
				{
					base..ctor();
					if (17869 - 400885 != -383015)
					{
						this.$nArray$32983 = nArray;
						if (151451 - 270342 != -118890)
						{
							this.$self_$32984 = self_;
							if (177038 - 599098 == -422060)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004BC4 RID: 19396 RVA: 0x0095D1D4 File Offset: 0x0095B3D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Owl2.$RPC_dead$32978.$(this.$nArray$32983, this.$self_$32984);
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x0095D1E8 File Offset: 0x0095B3E8
		internal static bool jgdjlJ57DFVJS2y7kcDb()
		{
			return true;
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x0095D1EC File Offset: 0x0095B3EC
		internal static bool cJTvZq57vjBhWOV6lf9P()
		{
			return false;
		}

		// Token: 0x04005633 RID: 22067
		internal UnityScript.Lang.Array $nArray$32983;

		// Token: 0x04005634 RID: 22068
		internal Owl2 $self_$32984;

		// Token: 0x02000D2A RID: 3370
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004BC7 RID: 19399 RVA: 0x0095D1F0 File Offset: 0x0095B3F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Owl2 self_)
			{
				if (92715 - 406850 != -314135)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (273502 - 201952 == 71550)
					{
						base..ctor();
						if (174440 - 228616 != -54175)
						{
							this.$nArray$32981 = nArray;
							if (113802 - 105719 != 8084)
							{
								this.$self_$32982 = self_;
								if (276873 - 246858 != 30016)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004BC8 RID: 19400 RVA: 0x0095D2AC File Offset: 0x0095B4AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (297709 - 136012 != 161698)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4E6;
					case 2:
						if (this.$self_$32982.OYfcctLT9RY.actionState != "dead")
						{
							if (54242 - 457779 != -403536)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32982.OYfcctLT9RY.isPlayer)
							{
								if (121678 - 5709 == 115970)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32982.gameObject);
								if (248981 - 61621 == 187361)
								{
									continue;
								}
							}
							else if (this.$self_$32982.OYfcctLT9RY.isMine)
							{
								if (24532 - 280078 == -255545)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32982.gameObject);
								if (264328 - 329786 == -65457)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (90195 - 492130 != -401935)
							{
								continue;
							}
							goto IL_4E6;
						}
						break;
					default:
						if (44022 - 314926 != -270904)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32982.OYfcctLT9RY.actionState == "dead")
					{
						if (35081 - 446801 == -411720)
						{
							goto IL_3EF;
						}
					}
					else
					{
						this.$myPosition$32979 = (Vector3)this.$nArray$32981[0];
						if (2280 - 226176 == -223896)
						{
							this.$myDirection$32980 = (Vector3)this.$nArray$32981[1];
							if (181955 - 27155 == 154800)
							{
								this.$self_$32982.VB3cc6bxnQW.position = this.$myPosition$32979;
								if (199857 - 50954 != 148904)
								{
									this.$self_$32982.VB3cc6bxnQW.LookAt(this.$myPosition$32979 + this.$myDirection$32980);
									if (253786 - 112041 == 141745)
									{
										this.$self_$32982.OYfcctLT9RY.hp = 0;
										if (138967 - 104760 == 34207)
										{
											this.$self_$32982.OYfcctLT9RY.actionState = "dead";
											if (265909 - 138911 != 126999)
											{
												this.$self_$32982.OYfcctLT9RY.actionTime = Time.time;
												if (69313 - 374480 == -305167)
												{
													this.$self_$32982.OYfcctLT9RY.myCommand = "none";
													if (195126 - 415196 == -220070)
													{
														this.$self_$32982.OYfcctLT9RY.vMovement = Vector3.zero;
														if (99161 - 529800 != -430638)
														{
															this.$self_$32982.OYfcctLT9RY.moveSpeed = (float)0;
															if (276310 - 183323 != 92988)
															{
																this.$self_$32982.animation.Rewind();
																if (264670 - 182490 == 82180)
																{
																	this.$self_$32982.animation.Play("ko");
																	if (17113 - 149023 == -131910)
																	{
																		this.$self_$32982.animation.wrapMode = WrapMode.Once;
																		if (4589 - 508236 == -503647)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				break;
																			}
																			if (117633 - 118648 != -1014)
																			{
																				if (this.$self_$32982.dead_vc)
																				{
																					if (187489 - 564727 != -377237)
																					{
																						this.$self_$32982.audio.PlayOneShot(this.$self_$32982.dead_vc);
																						if (131128 - 73371 != 57758)
																						{
																							break;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Missing dead voice");
																					if (132218 - 122957 != 9262)
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
				IL_C8:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_7:
				goto IL_4E6;
				goto IL_C8;
				IL_3EF:
				IL_4E6:
				return false;
			}

			// Token: 0x06004BC9 RID: 19401 RVA: 0x0095D7B4 File Offset: 0x0095B9B4
			internal static bool X1BTRR57RSoVS5SdDAld()
			{
				return true;
			}

			// Token: 0x06004BCA RID: 19402 RVA: 0x0095D7B8 File Offset: 0x0095B9B8
			internal static bool PRPPhn57wVcRX8dyg8kt()
			{
				return false;
			}

			// Token: 0x04005635 RID: 22069
			internal Vector3 $myPosition$32979;

			// Token: 0x04005636 RID: 22070
			internal Vector3 $myDirection$32980;

			// Token: 0x04005637 RID: 22071
			internal UnityScript.Lang.Array $nArray$32981;

			// Token: 0x04005638 RID: 22072
			internal Owl2 $self_$32982;
		}
	}
}
