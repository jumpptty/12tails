using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200027C RID: 636
[Serializable]
public class ChromeKnight : MonoBehaviour
{
	// Token: 0x06000E8A RID: 3722 RVA: 0x00171490 File Offset: 0x0016F690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChromeKnight()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x001714A0 File Offset: 0x0016F6A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (76865 - 247215 != -170349)
		{
		}
		for (;;)
		{
			this.kx6JGE7U9E = this.transform;
			if (78616 - 446632 == -368016)
			{
				this.a3kJ1JYlbn = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (246800 - 75846 != 170955)
				{
					this.a3kJ1JYlbn.actionState = "standby";
					if (296833 - 591701 != -294867)
					{
						this.a3kJ1JYlbn.actionTime = Time.time;
						if (14917 - 338999 != -324081)
						{
							this.a3kJ1JYlbn.myCommand = "none";
							if (73382 - 538648 == -465266)
							{
								if (Game.mGameType == 99)
								{
									if (81108 - 334201 == -253092)
									{
										continue;
									}
									this.a3kJ1JYlbn.isMine = true;
									if (78107 - 425805 != -347698)
									{
										continue;
									}
								}
								this.a3kJ1JYlbn.hp = (this.a3kJ1JYlbn.mhp = 50000);
								if (76670 - 125645 == -48975)
								{
									this.a3kJ1JYlbn.ko = (this.a3kJ1JYlbn.mko = 999);
									if (103279 - 297569 == -194290)
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

	// Token: 0x06000E8C RID: 3724 RVA: 0x00171670 File Offset: 0x0016F870
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playLeftFootEvent(AnimationEvent animEvent)
	{
		this.audio.PlayOneShot(this.footStep_left);
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x00171684 File Offset: 0x0016F884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRightFootEvent(AnimationEvent animEvent)
	{
		this.audio.PlayOneShot(this.footStep_right);
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x00171698 File Offset: 0x0016F898
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (239152 - 45760 != 193393)
		{
		}
		for (;;)
		{
			if (this.a3kJ1JYlbn.isControlled)
			{
				if (155224 - 499879 != -344655)
				{
					continue;
				}
				if (!(this.a3kJ1JYlbn.actionState == "standby"))
				{
					if (48082 - 11494 != 36588)
					{
						continue;
					}
					if (!(this.a3kJ1JYlbn.actionState == "run"))
					{
						goto IL_F1;
					}
					if (151933 - 355030 != -203097)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (192282 - 52114 != 140168)
				{
					continue;
				}
			}
			IL_F1:
			if (this.a3kJ1JYlbn.hp > 0)
			{
				break;
			}
			if (101034 - 205063 != -104028)
			{
				if (!(this.a3kJ1JYlbn.actionState != "dead"))
				{
					break;
				}
				if (184704 - 264686 == -79982)
				{
					if (this.a3kJ1JYlbn.isMine)
					{
						if (56416 - 166805 == -110389)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (68010 - 97839 != -29828)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (49951 - 208219 != -158267)
								{
									this.a3kJ1JYlbn.DeadEvent();
									if (75630 - 250189 == -174559)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.a3kJ1JYlbn.hp = 1;
						if (34849 - 43417 == -8568)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x001718D8 File Offset: 0x0016FAD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (170110 - 154646 != 15465)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (48215 - 565841 == -517626)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (87310 - 161060 != -73749)
				{
					if (186754 - 517707 == -330953)
					{
						if (ActionName == "RPC_nAttack1")
						{
							if (189827 - 505905 == -316077)
							{
								continue;
							}
							v = 1;
							if (22940 - 189031 == -166090)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack2")
						{
							if (199901 - 85932 == 113970)
							{
								continue;
							}
							v = 2;
							if (284817 - 563056 == -278238)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (152847 - 101349 != 51498)
							{
								continue;
							}
							v = -1;
							if (241738 - 142466 == 99273)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (94240 - 511931 != -417691)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (60599 - 136087 == -75488)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (277924 - 255996 == 21928)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (151890 - 77758 == 74132)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (297754 - 353356 == -55602)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (411 - 199124 == -198713)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (205160 - 227386 == -22226)
											{
												Hashtable hashtable = new Hashtable();
												if (292818 - 464837 == -172019)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (110202 - 220762 == -110560)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (15624 - 9005 != 6620)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (6748 - 383732 == -376984)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (44806 - 115928 != -71121)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (164019 - 181113 != -17093)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (15971 - 119408 == -103437)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (229532 - 470309 != -240776)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (89280 - 298359 != -209078)
																				{
																					PhotonClient.SendEvent(this.a3kJ1JYlbn.ActorNr, 74, hashtable, true, true);
																					if (58338 - 1850 == 56488)
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

	// Token: 0x06000E90 RID: 3728 RVA: 0x00171DA0 File Offset: 0x0016FFA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (234702 - 217553 != 17150)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (72656 - 474184 == -401528)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (143531 - 163239 != -19707)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (145895 - 524347 != -378451)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (180572 - 67191 == 113381)
						{
							int num3 = num;
							if (65587 - 59876 != 5712)
							{
								if (num3 == 1)
								{
									if (88447 - 456715 != -368267)
									{
										if (this.a3kJ1JYlbn.isMine)
										{
											break;
										}
										if (286231 - 270175 == 16056)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (286816 - 808 != 286009)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (212110 - 150599 != 61512)
									{
										if (this.a3kJ1JYlbn.isMine)
										{
											break;
										}
										if (16443 - 440063 == -423620)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (167938 - 453063 == -285125)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (104783 - 376094 != -271310)
									{
										if (this.a3kJ1JYlbn.isMine)
										{
											break;
										}
										if (120121 - 255630 != -135508)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (245296 - 449349 != -204052)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (279806 - 416962 != -137155)
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

	// Token: 0x06000E91 RID: 3729 RVA: 0x001720B0 File Offset: 0x001702B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (66030 - 548114 != -482083)
		{
		}
		for (;;)
		{
			float num = this.a3kJ1JYlbn.moveSpeed;
			if (92522 - 418100 == -325578)
			{
				float runSpeed = this.a3kJ1JYlbn.runSpeed;
				if (147216 - 406888 == -259672)
				{
					Vector3 a = default(Vector3);
					if (82135 - 459743 != -377607)
					{
						Vector3 vector = Vector3.zero;
						if (201003 - 212559 == -11556)
						{
							float num2 = (float)0;
							if (246408 - 205733 == 40675)
							{
								if (this.a3kJ1JYlbn.isMine)
								{
									if (30593 - 560992 != -530399)
									{
										continue;
									}
									if ((this.a3kJ1JYlbn.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (290201 - 122632 != 167569)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (200592 - 164599 == 35994)
										{
											continue;
										}
										a.y = (float)0;
										if (49774 - 527181 != -477407)
										{
											continue;
										}
										a = a.normalized;
										if (111810 - 448406 == -336595)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (264979 - 580017 == -315037)
										{
											continue;
										}
										vector = vector.normalized;
										if (87592 - 160487 != -72895)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (30304 - 386771 == -356466)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (275804 - 45021 == 230784)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (112114 - 239273 != -127159)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (288008 - 576761 != -288753)
														{
															continue;
														}
														this.a3kJ1JYlbn.actionState = "run";
														if (135046 - 388220 == -253173)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (284988 - 251614 != 33374)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (167189 - 582884 != -415695)
														{
															continue;
														}
														this.animation.Play("run");
														if (72259 - 549589 == -477329)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (176055 - 527624 != -351569)
														{
															continue;
														}
														goto IL_3F4;
													}
												}
											}
										}
										this.a3kJ1JYlbn.actionState = "standby";
										if (89238 - 11077 != 78161)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (94943 - 111759 == -16815)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (271386 - 342770 != -71384)
											{
												continue;
											}
											num = (float)0;
											if (158746 - 474046 != -315300)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.3f);
										if (240553 - 598421 != -357868)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (21529 - 567820 == -546290)
										{
											continue;
										}
									}
									IL_3F4:;
								}
								else
								{
									vector = global::Math.vFlat(this.a3kJ1JYlbn.nPosition - this.transform.position);
									if (109023 - 427595 != -318572)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (98740 - 177178 == -78437)
									{
										continue;
									}
									if (this.a3kJ1JYlbn.nSpeed != (float)0)
									{
										if (256920 - 373280 == -116359)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (238476 - 582905 == -344428)
											{
												continue;
											}
											this.transform.position = this.a3kJ1JYlbn.nPosition;
											if (278654 - 507673 == -229018)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (211897 - 72991 != 138906)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (261012 - 541943 == -280930)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (229275 - 462232 != -232957)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.a3kJ1JYlbn.nSpeed, (float)10 * Time.deltaTime);
												if (166003 - 226489 != -60486)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (203075 - 72300 == 130776)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (33613 - 538566 == -504952)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (149842 - 48105 == 101738)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (54528 - 442030 != -387502)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (19478 - 146 != 19332)
											{
												continue;
											}
										}
										else if (Time.time > this.a3kJ1JYlbn.nSpeed + 0.3f)
										{
											if (179338 - 267166 == -87827)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (291065 - 95342 == 195724)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (47091 - 492019 != -444928)
												{
													continue;
												}
												num = (float)0;
												if (101796 - 10774 != 91022)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.a3kJ1JYlbn.nDirection);
											if (180320 - 78320 != 102000)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.3f);
											if (213139 - 490627 != -277488)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (285279 - 152123 != 133156)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (220878 - 485381 == -264502)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (128768 - 30893 != 97875)
											{
												continue;
											}
											this.transform.position = this.a3kJ1JYlbn.nPosition;
											if (137085 - 55950 == 81136)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (150705 - 80881 == 69825)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (272209 - 434806 != -162597)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (204597 - 4086 != 200511)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (46937 - 116724 != -69787)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (36449 - 215006 != -178557)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (145506 - 415275 == -269768)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (98330 - 291541 == -193210)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.a3kJ1JYlbn.nDirection);
											if (202 - 52360 != -52158)
											{
												continue;
											}
											num = (float)0;
											if (223566 - 517175 == -293608)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.3f);
											if (137930 - 593255 == -455324)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (292883 - 55874 == 237010)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.3f);
										if (281483 - 233201 == 48283)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (44298 - 182055 != -137757)
										{
											continue;
										}
									}
								}
								this.a3kJ1JYlbn.vMovement = vector;
								if (114965 - 108239 == 6726)
								{
									this.a3kJ1JYlbn.moveSpeed = num;
									if (196233 - 38689 != 157545)
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

	// Token: 0x06000E92 RID: 3730 RVA: 0x00172C14 File Offset: 0x00170E14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (185794 - 371409 != -185615)
		{
		}
		for (;;)
		{
			if (!this.a3kJ1JYlbn.isMine)
			{
				if (226335 - 10599 == 215736)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (258467 - 8091 != 250377)
				{
					Vector3 vector = a - this.transform.position;
					if (186346 - 139166 != 47181)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (224041 - 560 == 223481)
						{
							CharacterControl characterControl = null;
							if (154229 - 170159 != -15929)
							{
								if (21134 - 182821 == -161687)
								{
									if (gameObject)
									{
										if (164321 - 508241 != -343920)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (157856 - 484958 != -327102)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (262490 - 590043 != -327553)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (97787 - 232450 == -134662)
										{
											continue;
										}
									}
									if (!(this.a3kJ1JYlbn.actionState == "standby"))
									{
										if (272254 - 122812 != 149442)
										{
											continue;
										}
										if (!(this.a3kJ1JYlbn.actionState == "run"))
										{
											break;
										}
										if (131282 - 37375 == 93908)
										{
											continue;
										}
									}
									if (this.a3kJ1JYlbn.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (161728 - 482112 != -320383)
									{
										if (UnityEngine.Random.Range(0, 2) == 0)
										{
											if (179165 - 5204 != 173962)
											{
												this.StartCoroutine_Auto(this.RPC_nAttack1(this.transform.position, vector, 0));
												if (271748 - 234910 != 36839)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (142398 - 440730 == -298332)
													{
														this.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
														if (155116 - 526312 != -371195)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(this.transform.position, vector, 0));
											if (187539 - 468750 != -281210)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (18668 - 550176 != -531507)
												{
													this.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
													if (113264 - 72696 != 40569)
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

	// Token: 0x06000E93 RID: 3731 RVA: 0x00172FC4 File Offset: 0x001711C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (121557 - 449975 != -328417)
		{
		}
		for (;;)
		{
			if (!this.a3kJ1JYlbn.isMine)
			{
				if (203975 - 70133 != 133843)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (217125 - 260463 != -43337)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (12216 - 329740 != -317523)
					{
						Vector3 normalized = vector.normalized;
						if (282160 - 366882 == -84722)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (82873 - 303255 == -220382)
							{
								CharacterControl characterControl = null;
								if (89315 - 473656 != -384340 && 52941 - 513781 != -460839)
								{
									if (gameObject)
									{
										if (163432 - 484288 != -320856)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (113383 - 207049 != -93666)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (266452 - 326958 != -60506)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (271613 - 596811 == -325197)
										{
											continue;
										}
									}
									if (!(this.a3kJ1JYlbn.actionState == "standby"))
									{
										if (64363 - 542515 == -478151)
										{
											continue;
										}
										if (!(this.a3kJ1JYlbn.actionState == "run"))
										{
											break;
										}
										if (134171 - 89862 == 44310)
										{
											continue;
										}
									}
									if (this.a3kJ1JYlbn.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (208111 - 117295 != 90817)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
										if (225764 - 462856 == -237092)
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

	// Token: 0x06000E94 RID: 3732 RVA: 0x00173290 File Offset: 0x00171490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x00173294 File Offset: 0x00171494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChromeKnight.$RPC_nAttack1$17717(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x001732A4 File Offset: 0x001714A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ChromeKnight.$RPC_nAttack2$17730(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x001732B4 File Offset: 0x001714B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (207258 - 147714 != 59544)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (46287 - 273391 != -227104)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.identity);
				if (178909 - 156852 == 22058)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing nAttack hit effect");
				if (244282 - 45993 == 198290)
				{
					continue;
				}
			}
			if (Time.time > this.rfcJqXYn7F)
			{
				if (13162 - 287926 == -274763)
				{
					continue;
				}
				this.rfcJqXYn7F = Time.time + 0.1f;
				if (172467 - 159097 != 13370)
				{
					continue;
				}
				if (this.nAttack_hitFX)
				{
					if (193300 - 203205 != -9905)
					{
						continue;
					}
					this.audio.PlayOneShot(this.nAttack_hitFX);
					if (35384 - 81708 == -46323)
					{
						continue;
					}
				}
			}
			object obj2;
			object obj = obj2 = PhotonClient.ActorNrList[hitID];
			if (!(obj is GameObject))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
			}
			GameObject y = (GameObject)obj2;
			if (44672 - 428549 == -383877)
			{
				if (!(Game.mPlayer == y))
				{
					break;
				}
				if (296619 - 107417 != 189203)
				{
					CameraEffect cameraEffect = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
					if (228637 - 498406 != -269768)
					{
						cameraEffect.AddColorRamp("whiteRamp", "burstMask", (float)1, new Vector4((float)0, (float)0, 0.2f, 0.2f));
						if (1348 - 53269 != -51920)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x00173504 File Offset: 0x00171704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new ChromeKnight.$RPC_ko$17743(nArray, this).GetEnumerator();
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x00173514 File Offset: 0x00171714
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new ChromeKnight.$RPC_dead$17750(nArray, this).GetEnumerator();
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x00173524 File Offset: 0x00171724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000E9B RID: 3739 RVA: 0x00173528 File Offset: 0x00171728
	internal static bool SuLxZASMXh2FufqgkFC()
	{
		return true;
	}

	// Token: 0x06000E9C RID: 3740 RVA: 0x0017352C File Offset: 0x0017172C
	internal static bool lsenjQSxpBJqEag4LQk()
	{
		return false;
	}

	// Token: 0x04000C8B RID: 3211
	private Transform kx6JGE7U9E;

	// Token: 0x04000C8C RID: 3212
	private CharacterControl a3kJ1JYlbn;

	// Token: 0x04000C8D RID: 3213
	public AudioClip footStep_left;

	// Token: 0x04000C8E RID: 3214
	public AudioClip footStep_right;

	// Token: 0x04000C8F RID: 3215
	public GameObject nAttack1_ring;

	// Token: 0x04000C90 RID: 3216
	public GameObject nAttack2_ring;

	// Token: 0x04000C91 RID: 3217
	public GameObject nAttack_hit;

	// Token: 0x04000C92 RID: 3218
	public AudioClip nAttack_hitFX;

	// Token: 0x04000C93 RID: 3219
	private float rfcJqXYn7F;

	// Token: 0x04000C94 RID: 3220
	public GameObject deadEffect;

	// Token: 0x0200027D RID: 637
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$17717 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000E9D RID: 3741 RVA: 0x00173530 File Offset: 0x00171730
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$17717(Vector3 mPos, Vector3 tDir, ChromeKnight self_)
		{
			if (271507 - 236395 != 35113)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (166168 - 54297 != 111872)
				{
					base..ctor();
					if (240067 - 78188 == 161879)
					{
						this.$mPos$17727 = mPos;
						if (199916 - 438354 != -238437)
						{
							this.$tDir$17728 = tDir;
							if (86158 - 76200 != 9959)
							{
								this.$self_$17729 = self_;
								if (88465 - 109367 == -20902)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0017360C File Offset: 0x0017180C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChromeKnight.$RPC_nAttack1$17717.$(this.$mPos$17727, this.$tDir$17728, this.$self_$17729);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00173628 File Offset: 0x00171828
		internal static bool mcxXabSgq2d3ot2bZFr()
		{
			return true;
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0017362C File Offset: 0x0017182C
		internal static bool hSJ7ERSfoOVSwq8tNRj()
		{
			return false;
		}

		// Token: 0x04000C95 RID: 3221
		internal Vector3 $mPos$17727;

		// Token: 0x04000C96 RID: 3222
		internal Vector3 $tDir$17728;

		// Token: 0x04000C97 RID: 3223
		internal ChromeKnight $self_$17729;

		// Token: 0x0200027E RID: 638
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000EA1 RID: 3745 RVA: 0x00173630 File Offset: 0x00171830
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ChromeKnight self_)
			{
				if (59849 - 509570 != -449721)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (68547 - 364060 != -295512)
					{
						base..ctor();
						if (219957 - 272199 != -52241)
						{
							this.$mPos$17724 = mPos;
							if (154918 - 400655 != -245736)
							{
								this.$tDir$17725 = tDir;
								if (57138 - 76595 == -19457)
								{
									this.$self_$17726 = self_;
									if (295750 - 519106 != -223355)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000EA2 RID: 3746 RVA: 0x0017370C File Offset: 0x0017190C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148237 - 6531 != 141706)
				{
				}
				for (;;)
				{
					IL_2D6:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_928;
					case 2:
						if (this.$self_$17726.a3kJ1JYlbn.actionState != "attack")
						{
							goto IL_185;
						}
						if (235375 - 114971 != 120404)
						{
							continue;
						}
						if (this.$self_$17726.a3kJ1JYlbn.myCommand != "nAttack1")
						{
							if (125430 - 264953 != -139522)
							{
								goto Block_54;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17726.a3kJ1JYlbn.isMine)
							{
								goto IL_76D;
							}
							if (26556 - 133690 == -107133)
							{
								continue;
							}
							this.$hitLayer$17718 = 130816 - (1 << this.$self_$17726.gameObject.layer);
							if (64466 - 252272 == -187805)
							{
								continue;
							}
							this.$hitList$17719 = Damage.FindRecTarget(this.$self_$17726.kx6JGE7U9E.position, this.$self_$17726.kx6JGE7U9E.forward, (float)2, (float)2, (float)6, (float)3, this.$hitLayer$17718);
							if (23905 - 125917 == -102011)
							{
								continue;
							}
							this.$$iterator$10056$17723 = UnityRuntimeServices.GetEnumerator(this.$hitList$17719);
							if (3738 - 92032 == -88293)
							{
								continue;
							}
							while (this.$$iterator$10056$17723.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10056$17723.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17720 = (GameObject)obj2;
								if (47121 - 412153 != -365032)
								{
									goto IL_2D6;
								}
								this.$hitChar$17721 = (CharacterControl)this.$hitObject$17720.GetComponent(typeof(CharacterControl));
								if (135414 - 571875 != -436461)
								{
									goto IL_2D6;
								}
								UnityRuntimeServices.Update(this.$$iterator$10056$17723, this.$hitObject$17720);
								if (293879 - 540061 != -246182)
								{
									goto IL_2D6;
								}
								if (this.$hitChar$17721)
								{
									if (202974 - 258475 == -55500)
									{
										goto IL_2D6;
									}
									this.$hitChar$17721.RPC_AddStatus("cut", 5, 1, 0, this.$self_$17726.a3kJ1JYlbn.ActorNr);
									if (61569 - 136959 != -75390)
									{
										goto IL_2D6;
									}
									if (this.$self_$17726.a3kJ1JYlbn.hit(1, this.$hitObject$17720, 5 * this.$self_$17726.a3kJ1JYlbn.atk, 99, 0, 0.5f * this.$self_$17726.kx6JGE7U9E.forward) != 0)
									{
										if (157152 - 532095 == -374942)
										{
											goto IL_2D6;
										}
										this.$hitPoint$17722 = this.$hitObject$17720.collider.ClosestPointOnBounds(this.$self_$17726.kx6JGE7U9E.position + (float)2 * Vector3.up);
										if (36988 - 177744 != -140756)
										{
											goto IL_2D6;
										}
										UnityRuntimeServices.Update(this.$$iterator$10056$17723, this.$hitObject$17720);
										if (108321 - 452866 != -344545)
										{
											goto IL_2D6;
										}
										this.$self_$17726.RPC_nAttack_hit(this.$hitPoint$17722, this.$self_$17726.kx6JGE7U9E.forward, this.$hitChar$17721.ActorNr);
										if (108180 - 282721 == -174540)
										{
											goto IL_2D6;
										}
										this.$self_$17726.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17722, this.$self_$17726.kx6JGE7U9E.forward, this.$hitChar$17721.ActorNr);
										if (95448 - 333609 == -238160)
										{
											goto IL_2D6;
										}
									}
								}
							}
							if (24431 - 496557 != -472126)
							{
								continue;
							}
							goto IL_76D;
						}
						break;
					case 3:
						if (this.$self_$17726.a3kJ1JYlbn.actionState == "attack")
						{
							if (127850 - 412760 != -284910)
							{
								continue;
							}
							if (this.$self_$17726.a3kJ1JYlbn.myCommand == "nAttack1")
							{
								if (35368 - 434833 != -399465)
								{
									continue;
								}
								this.$self_$17726.a3kJ1JYlbn.actionState = "standby";
								if (46462 - 175570 != -129108)
								{
									continue;
								}
								this.$self_$17726.a3kJ1JYlbn.actionTime = Time.time;
								if (163843 - 308937 != -145094)
								{
									continue;
								}
								this.$self_$17726.a3kJ1JYlbn.myCommand = "none";
								if (257262 - 491235 != -233973)
								{
									continue;
								}
								if (!this.$self_$17726.a3kJ1JYlbn.isMine)
								{
									if (260029 - 131586 != 128443)
									{
										continue;
									}
									this.$self_$17726.a3kJ1JYlbn.nPosition = this.$self_$17726.kx6JGE7U9E.position;
									if (216990 - 168041 == 48950)
									{
										continue;
									}
									this.$self_$17726.a3kJ1JYlbn.oPosition = this.$self_$17726.kx6JGE7U9E.position;
									if (231004 - 110386 == 120619)
									{
										continue;
									}
									this.$self_$17726.a3kJ1JYlbn.nDirection = this.$self_$17726.kx6JGE7U9E.forward;
									if (128950 - 202119 != -73169)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (160817 - 399730 != -238913)
						{
							continue;
						}
						goto IL_928;
					default:
						if (78272 - 476699 == -398426)
						{
							continue;
						}
						break;
					}
					this.$self_$17726.a3kJ1JYlbn.actionState = "attack";
					if (246710 - 465343 == -218633)
					{
						this.$self_$17726.a3kJ1JYlbn.actionTime = Time.time;
						if (297392 - 63468 != 233925)
						{
							this.$self_$17726.a3kJ1JYlbn.myCommand = "nAttack1";
							if (73233 - 565142 == -491909)
							{
								this.$self_$17726.a3kJ1JYlbn.addTimeOut("nAttack", (float)3);
								if (144077 - 424639 != -280561)
								{
									this.$self_$17726.kx6JGE7U9E.position = this.$mPos$17724;
									if (270158 - 32468 != 237691)
									{
										this.$self_$17726.kx6JGE7U9E.LookAt(this.$mPos$17724 + global::Math.vFlat(this.$tDir$17725));
										if (42699 - 311042 == -268343)
										{
											this.$self_$17726.animation.CrossFade("nAttack1");
											if (127446 - 127919 != -472)
											{
												this.$self_$17726.animation.wrapMode = WrapMode.Once;
												if (118619 - 4607 != 114013)
												{
													this.$self_$17726.a3kJ1JYlbn.vMovement = this.$self_$17726.kx6JGE7U9E.forward;
													if (200215 - 19920 == 180295)
													{
														this.$self_$17726.a3kJ1JYlbn.moveSpeed = (float)0;
														if (68346 - 217500 == -149154)
														{
															if (this.$self_$17726.nAttack1_ring)
															{
																if (183341 - 120288 == 63053)
																{
																	this.$self_$17726.a3kJ1JYlbn.createEffect(this.$self_$17726.nAttack1_ring, this.$self_$17726.kx6JGE7U9E.position, this.$self_$17726.kx6JGE7U9E.rotation);
																	if (54833 - 109977 != -55143)
																	{
																		goto Block_36;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack1 ring effect");
																if (298539 - 306063 == -7524)
																{
																	goto IL_83A;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_185:
				goto IL_928;
				Block_36:
				goto IL_83A;
				IL_76D:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_83A:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_54:
				IL_928:
				return false;
			}

			// Token: 0x06000EA3 RID: 3747 RVA: 0x00174054 File Offset: 0x00172254
			internal static bool aiXVl9SncfbEYMtRHQ9()
			{
				return true;
			}

			// Token: 0x06000EA4 RID: 3748 RVA: 0x00174058 File Offset: 0x00172258
			internal static bool a35CWdS6KxXdbcrexM1()
			{
				return false;
			}

			// Token: 0x04000C98 RID: 3224
			internal int $hitLayer$17718;

			// Token: 0x04000C99 RID: 3225
			internal UnityScript.Lang.Array $hitList$17719;

			// Token: 0x04000C9A RID: 3226
			internal GameObject $hitObject$17720;

			// Token: 0x04000C9B RID: 3227
			internal CharacterControl $hitChar$17721;

			// Token: 0x04000C9C RID: 3228
			internal Vector3 $hitPoint$17722;

			// Token: 0x04000C9D RID: 3229
			internal IEnumerator $$iterator$10056$17723;

			// Token: 0x04000C9E RID: 3230
			internal Vector3 $mPos$17724;

			// Token: 0x04000C9F RID: 3231
			internal Vector3 $tDir$17725;

			// Token: 0x04000CA0 RID: 3232
			internal ChromeKnight $self_$17726;
		}
	}

	// Token: 0x0200027F RID: 639
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$17730 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000EA5 RID: 3749 RVA: 0x0017405C File Offset: 0x0017225C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$17730(Vector3 mPos, Vector3 tDir, ChromeKnight self_)
		{
			if (292022 - 78429 != 213593)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (288185 - 317420 != -29234)
				{
					base..ctor();
					if (166374 - 75966 != 90409)
					{
						this.$mPos$17740 = mPos;
						if (239888 - 318719 == -78831)
						{
							this.$tDir$17741 = tDir;
							if (38352 - 171994 == -133642)
							{
								this.$self_$17742 = self_;
								if (33881 - 553756 != -519874)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00174138 File Offset: 0x00172338
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChromeKnight.$RPC_nAttack2$17730.$(this.$mPos$17740, this.$tDir$17741, this.$self_$17742);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00174154 File Offset: 0x00172354
		internal static bool Xbfp3VSicVukqxOqsQO()
		{
			return true;
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00174158 File Offset: 0x00172358
		internal static bool LKlDlYSKlmGnGdgl1Vb()
		{
			return false;
		}

		// Token: 0x04000CA1 RID: 3233
		internal Vector3 $mPos$17740;

		// Token: 0x04000CA2 RID: 3234
		internal Vector3 $tDir$17741;

		// Token: 0x04000CA3 RID: 3235
		internal ChromeKnight $self_$17742;

		// Token: 0x02000280 RID: 640
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000EA9 RID: 3753 RVA: 0x0017415C File Offset: 0x0017235C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ChromeKnight self_)
			{
				if (265876 - 344528 != -78651)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (145274 - 349937 != -204662)
					{
						base..ctor();
						if (209636 - 272034 == -62398)
						{
							this.$mPos$17737 = mPos;
							if (137697 - 511444 == -373747)
							{
								this.$tDir$17738 = tDir;
								if (188356 - 504475 != -316118)
								{
									this.$self_$17739 = self_;
									if (136568 - 28867 == 107701)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000EAA RID: 3754 RVA: 0x00174238 File Offset: 0x00172438
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (147286 - 585051 != -437765)
				{
				}
				for (;;)
				{
					IL_7FF:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_925;
					case 2:
						if (this.$self_$17739.a3kJ1JYlbn.actionState != "attack")
						{
							goto IL_372;
						}
						if (219123 - 375030 != -155907)
						{
							continue;
						}
						if (this.$self_$17739.a3kJ1JYlbn.myCommand != "nAttack2")
						{
							if (123826 - 119331 != 4496)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17739.a3kJ1JYlbn.isMine)
							{
								goto IL_52;
							}
							if (77175 - 285846 != -208671)
							{
								continue;
							}
							this.$hitLayer$17731 = 130816 - (1 << this.$self_$17739.gameObject.layer);
							if (176452 - 34871 == 141582)
							{
								continue;
							}
							this.$hitList$17732 = Damage.FindRecTarget(this.$self_$17739.kx6JGE7U9E.position, this.$self_$17739.kx6JGE7U9E.forward, (float)5, (float)5, (float)5, (float)3, this.$hitLayer$17731);
							if (121211 - 235939 != -114728)
							{
								continue;
							}
							this.$$iterator$10057$17736 = UnityRuntimeServices.GetEnumerator(this.$hitList$17732);
							if (120824 - 284128 == -163303)
							{
								continue;
							}
							while (this.$$iterator$10057$17736.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10057$17736.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17733 = (GameObject)obj2;
								if (519 - 422971 == -422451)
								{
									goto IL_7FF;
								}
								if (this.$self_$17739.a3kJ1JYlbn.hit(1, this.$hitObject$17733, 5 * this.$self_$17739.a3kJ1JYlbn.atk, 99, 0, (float)2 * this.$self_$17739.kx6JGE7U9E.forward) != 0)
								{
									if (171363 - 60871 == 110493)
									{
										goto IL_7FF;
									}
									this.$hitChar$17734 = (CharacterControl)this.$hitObject$17733.GetComponent(typeof(CharacterControl));
									if (3118 - 167717 == -164598)
									{
										goto IL_7FF;
									}
									UnityRuntimeServices.Update(this.$$iterator$10057$17736, this.$hitObject$17733);
									if (203556 - 541430 != -337874)
									{
										goto IL_7FF;
									}
									if (this.$hitChar$17734)
									{
										if (235854 - 581522 != -345668)
										{
											goto IL_7FF;
										}
										this.$hitChar$17734.RPC_AddStatus("cut", 5, 1, 0, this.$self_$17739.a3kJ1JYlbn.ActorNr);
										if (251393 - 12484 == 238910)
										{
											goto IL_7FF;
										}
										this.$hitPoint$17735 = this.$hitObject$17733.collider.ClosestPointOnBounds(this.$self_$17739.kx6JGE7U9E.position + (float)2 * Vector3.up);
										if (260406 - 91963 == 168444)
										{
											goto IL_7FF;
										}
										UnityRuntimeServices.Update(this.$$iterator$10057$17736, this.$hitObject$17733);
										if (9470 - 234049 != -224579)
										{
											goto IL_7FF;
										}
										this.$self_$17739.RPC_nAttack_hit(this.$hitPoint$17735, this.$self_$17739.kx6JGE7U9E.forward, this.$hitChar$17734.ActorNr);
										if (243629 - 229676 != 13953)
										{
											goto IL_7FF;
										}
										this.$self_$17739.ActionEvent("RPC_nAttack_hit", this.$hitPoint$17735, this.$self_$17739.kx6JGE7U9E.forward, this.$hitChar$17734.ActorNr);
										if (7186 - 538951 != -531765)
										{
											goto IL_7FF;
										}
									}
								}
							}
							if (198968 - 378186 != -179217)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17739.a3kJ1JYlbn.actionState == "attack")
						{
							if (179285 - 289661 != -110376)
							{
								continue;
							}
							if (this.$self_$17739.a3kJ1JYlbn.myCommand == "nAttack2")
							{
								if (62770 - 166307 == -103536)
								{
									continue;
								}
								this.$self_$17739.a3kJ1JYlbn.actionState = "standby";
								if (141622 - 483159 != -341537)
								{
									continue;
								}
								this.$self_$17739.a3kJ1JYlbn.actionTime = Time.time;
								if (5983 - 418778 == -412794)
								{
									continue;
								}
								this.$self_$17739.a3kJ1JYlbn.myCommand = "none";
								if (62025 - 547429 == -485403)
								{
									continue;
								}
								if (!this.$self_$17739.a3kJ1JYlbn.isMine)
								{
									if (42237 - 293865 == -251627)
									{
										continue;
									}
									this.$self_$17739.a3kJ1JYlbn.nPosition = this.$self_$17739.kx6JGE7U9E.position;
									if (115282 - 40268 == 75015)
									{
										continue;
									}
									this.$self_$17739.a3kJ1JYlbn.oPosition = this.$self_$17739.kx6JGE7U9E.position;
									if (64991 - 398534 == -333542)
									{
										continue;
									}
									this.$self_$17739.a3kJ1JYlbn.nDirection = this.$self_$17739.kx6JGE7U9E.forward;
									if (101853 - 478247 != -376394)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (256762 - 517980 != -261217)
						{
							goto Block_13;
						}
						continue;
					default:
						if (231736 - 457097 == -225360)
						{
							continue;
						}
						break;
					}
					this.$self_$17739.a3kJ1JYlbn.actionState = "attack";
					if (45638 - 73580 == -27942)
					{
						this.$self_$17739.a3kJ1JYlbn.actionTime = Time.time;
						if (220571 - 48914 == 171657)
						{
							this.$self_$17739.a3kJ1JYlbn.myCommand = "nAttack2";
							if (281922 - 323002 != -41079)
							{
								this.$self_$17739.a3kJ1JYlbn.addTimeOut("nAttack", (float)3);
								if (113545 - 17574 != 95972)
								{
									this.$self_$17739.kx6JGE7U9E.position = this.$mPos$17737;
									if (158353 - 462152 != -303798)
									{
										this.$self_$17739.kx6JGE7U9E.LookAt(this.$mPos$17737 + global::Math.vFlat(this.$tDir$17738));
										if (31827 - 364780 != -332952)
										{
											this.$self_$17739.animation.CrossFade("nAttack2");
											if (135670 - 109281 != 26390)
											{
												this.$self_$17739.animation.wrapMode = WrapMode.Once;
												if (8697 - 207467 == -198770)
												{
													this.$self_$17739.a3kJ1JYlbn.vMovement = this.$self_$17739.kx6JGE7U9E.forward;
													if (49984 - 270218 != -220233)
													{
														this.$self_$17739.a3kJ1JYlbn.moveSpeed = (float)0;
														if (299836 - 557653 != -257816)
														{
															if (this.$self_$17739.nAttack2_ring)
															{
																if (90956 - 189616 == -98660)
																{
																	this.$self_$17739.a3kJ1JYlbn.createEffect(this.$self_$17739.nAttack2_ring, this.$self_$17739.kx6JGE7U9E.position, this.$self_$17739.kx6JGE7U9E.rotation);
																	if (225704 - 225854 == -150)
																	{
																		goto IL_535;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack2 ring effect");
																if (53498 - 83651 != -30152)
																{
																	goto Block_33;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_52:
				return this.Yield(3, new WaitForSeconds(0.8f));
				Block_13:
				Block_17:
				IL_372:
				goto IL_925;
				Block_29:
				goto IL_52;
				IL_535:
				Block_33:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_925:
				return false;
			}

			// Token: 0x06000EAB RID: 3755 RVA: 0x00174B7C File Offset: 0x00172D7C
			internal static bool UHF3d0SdhUAMXN6kfy7()
			{
				return true;
			}

			// Token: 0x06000EAC RID: 3756 RVA: 0x00174B80 File Offset: 0x00172D80
			internal static bool g5NeN4SJtGxIhArUD08()
			{
				return false;
			}

			// Token: 0x04000CA4 RID: 3236
			internal int $hitLayer$17731;

			// Token: 0x04000CA5 RID: 3237
			internal UnityScript.Lang.Array $hitList$17732;

			// Token: 0x04000CA6 RID: 3238
			internal GameObject $hitObject$17733;

			// Token: 0x04000CA7 RID: 3239
			internal CharacterControl $hitChar$17734;

			// Token: 0x04000CA8 RID: 3240
			internal Vector3 $hitPoint$17735;

			// Token: 0x04000CA9 RID: 3241
			internal IEnumerator $$iterator$10057$17736;

			// Token: 0x04000CAA RID: 3242
			internal Vector3 $mPos$17737;

			// Token: 0x04000CAB RID: 3243
			internal Vector3 $tDir$17738;

			// Token: 0x04000CAC RID: 3244
			internal ChromeKnight $self_$17739;
		}
	}

	// Token: 0x02000281 RID: 641
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17743 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000EAD RID: 3757 RVA: 0x00174B84 File Offset: 0x00172D84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17743(UnityScript.Lang.Array nArray, ChromeKnight self_)
		{
			if (195091 - 177953 != 17139)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (233789 - 417723 != -183933)
				{
					base..ctor();
					if (149193 - 433884 == -284691)
					{
						this.$nArray$17748 = nArray;
						if (39041 - 77456 == -38415)
						{
							this.$self_$17749 = self_;
							if (34270 - 434167 != -399896)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00174C40 File Offset: 0x00172E40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChromeKnight.$RPC_ko$17743.$(this.$nArray$17748, this.$self_$17749);
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00174C54 File Offset: 0x00172E54
		internal static bool G3Dx4mSDPFGOpsmII7u()
		{
			return true;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00174C58 File Offset: 0x00172E58
		internal static bool coXoRwSvE6DJUqTbHrZ()
		{
			return false;
		}

		// Token: 0x04000CAD RID: 3245
		internal UnityScript.Lang.Array $nArray$17748;

		// Token: 0x04000CAE RID: 3246
		internal ChromeKnight $self_$17749;

		// Token: 0x02000282 RID: 642
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000EB1 RID: 3761 RVA: 0x00174C5C File Offset: 0x00172E5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ChromeKnight self_)
			{
				if (45119 - 261799 != -216679)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (130955 - 182331 == -51376)
					{
						base..ctor();
						if (250382 - 162917 == 87465)
						{
							this.$nArray$17746 = nArray;
							if (88905 - 509375 != -420469)
							{
								this.$self_$17747 = self_;
								if (139251 - 489898 == -350647)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000EB2 RID: 3762 RVA: 0x00174D18 File Offset: 0x00172F18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (16404 - 339968 != -323564)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_48C;
					case 2:
						if (this.$self_$17747.a3kJ1JYlbn.actionState != "ko")
						{
							if (256784 - 165399 != 91385)
							{
								continue;
							}
							goto IL_182;
						}
						else
						{
							this.$self_$17747.animation.Play("getUp");
							if (244110 - 564338 != -320228)
							{
								continue;
							}
							this.$self_$17747.animation.wrapMode = WrapMode.Once;
							if (48446 - 329993 != -281546)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17747.a3kJ1JYlbn.actionState != "ko")
						{
							if (240961 - 219720 != 21242)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$self_$17747.a3kJ1JYlbn.actionState = "standby";
							if (119276 - 221293 != -102017)
							{
								continue;
							}
							this.$self_$17747.a3kJ1JYlbn.actionTime = Time.time;
							if (238009 - 555117 != -317108)
							{
								continue;
							}
							this.$self_$17747.a3kJ1JYlbn.myCommand = "none";
							if (199811 - 413774 != -213963)
							{
								continue;
							}
							this.$self_$17747.a3kJ1JYlbn.ko = this.$self_$17747.a3kJ1JYlbn.mko;
							if (177773 - 112641 != 65132)
							{
								continue;
							}
							this.YieldDefault(1);
							if (198538 - 389673 != -191135)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (16362 - 592521 == -576158)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17747.a3kJ1JYlbn.actionState == "ko")
					{
						goto IL_3BD;
					}
					if (149464 - 465906 != -316441)
					{
						if (this.$self_$17747.a3kJ1JYlbn.actionState == "dead")
						{
							if (59581 - 62828 != -3246)
							{
								goto Block_15;
							}
						}
						else
						{
							this.$mPos$17744 = (Vector3)this.$nArray$17746[0];
							if (127623 - 528689 == -401066)
							{
								this.$mDir$17745 = (Vector3)this.$nArray$17746[1];
								if (176567 - 459726 == -283159)
								{
									this.$self_$17747.a3kJ1JYlbn.ko = 0;
									if (236718 - 7376 == 229342)
									{
										this.$self_$17747.a3kJ1JYlbn.actionState = "ko";
										if (287984 - 458350 == -170366)
										{
											this.$self_$17747.a3kJ1JYlbn.actionTime = Time.time;
											if (258466 - 492319 == -233853)
											{
												this.$self_$17747.a3kJ1JYlbn.myCommand = "none";
												if (95637 - 590160 == -494523)
												{
													this.$self_$17747.a3kJ1JYlbn.vMovement = Vector3.zero;
													if (130157 - 518199 != -388041)
													{
														this.$self_$17747.a3kJ1JYlbn.moveSpeed = (float)0;
														if (6915 - 525795 != -518879)
														{
															this.$self_$17747.animation.Play("ko");
															if (135164 - 156059 == -20895)
															{
																this.$self_$17747.animation.wrapMode = WrapMode.Once;
																if (280437 - 88358 != 192080)
																{
																	goto Block_23;
																}
															}
														}
													}
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
				return this.Yield(3, new WaitForSeconds(1f));
				IL_182:
				Block_15:
				Block_17:
				goto IL_48C;
				Block_23:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_3BD:
				IL_48C:
				return false;
			}

			// Token: 0x06000EB3 RID: 3763 RVA: 0x001751C4 File Offset: 0x001733C4
			internal static bool Cm90SnSRb5yT7nusoWQ()
			{
				return true;
			}

			// Token: 0x06000EB4 RID: 3764 RVA: 0x001751C8 File Offset: 0x001733C8
			internal static bool OKrSQZSw83e4fs7dvAq()
			{
				return false;
			}

			// Token: 0x04000CAF RID: 3247
			internal Vector3 $mPos$17744;

			// Token: 0x04000CB0 RID: 3248
			internal Vector3 $mDir$17745;

			// Token: 0x04000CB1 RID: 3249
			internal UnityScript.Lang.Array $nArray$17746;

			// Token: 0x04000CB2 RID: 3250
			internal ChromeKnight $self_$17747;
		}
	}

	// Token: 0x02000283 RID: 643
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17750 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000EB5 RID: 3765 RVA: 0x001751CC File Offset: 0x001733CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17750(UnityScript.Lang.Array nArray, ChromeKnight self_)
		{
			if (200555 - 24369 != 176186)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (113453 - 551035 == -437582)
				{
					base..ctor();
					if (299628 - 69806 == 229822)
					{
						this.$nArray$17755 = nArray;
						if (214334 - 145676 != 68659)
						{
							this.$self_$17756 = self_;
							if (237999 - 182221 != 55779)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00175288 File Offset: 0x00173488
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ChromeKnight.$RPC_dead$17750.$(this.$nArray$17755, this.$self_$17756);
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0017529C File Offset: 0x0017349C
		internal static bool MnejTLSqX310LNyX70J()
		{
			return true;
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x001752A0 File Offset: 0x001734A0
		internal static bool Q1Plj4S7sRnyKbVvsYG()
		{
			return false;
		}

		// Token: 0x04000CB3 RID: 3251
		internal UnityScript.Lang.Array $nArray$17755;

		// Token: 0x04000CB4 RID: 3252
		internal ChromeKnight $self_$17756;

		// Token: 0x02000284 RID: 644
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000EB9 RID: 3769 RVA: 0x001752A4 File Offset: 0x001734A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ChromeKnight self_)
			{
				if (292060 - 26445 != 265615)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (275798 - 522127 != -246328)
					{
						base..ctor();
						if (218547 - 357279 == -138732)
						{
							this.$nArray$17753 = nArray;
							if (55216 - 227742 != -172525)
							{
								this.$self_$17754 = self_;
								if (87950 - 350211 != -262260)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000EBA RID: 3770 RVA: 0x00175360 File Offset: 0x00173560
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (35778 - 396627 != -360848)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4D2;
					case 2:
						if (this.$self_$17754.a3kJ1JYlbn.actionState != "dead")
						{
							if (167405 - 370300 != -202894)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							if (this.$self_$17754.deadEffect)
							{
								if (158276 - 515171 != -356895)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$17754.deadEffect, this.$self_$17754.transform.position, this.$self_$17754.transform.rotation);
								if (233483 - 452700 != -219217)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing deadEffect effect");
								if (94054 - 295377 == -201322)
								{
									continue;
								}
							}
							if (!this.$self_$17754.a3kJ1JYlbn.isPlayer)
							{
								if (240570 - 320094 != -79524)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$17754.gameObject);
								if (50941 - 405384 != -354443)
								{
									continue;
								}
							}
							else if (this.$self_$17754.a3kJ1JYlbn.isMine)
							{
								if (239358 - 84548 != 154810)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17754.gameObject);
								if (22103 - 514528 == -492424)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (240303 - 138593 != 101711)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					default:
						if (71329 - 232591 != -161262)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17754.a3kJ1JYlbn.actionState == "dead")
					{
						if (15527 - 450269 != -434741)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$17751 = (Vector3)this.$nArray$17753[0];
						if (157167 - 325245 != -168077)
						{
							this.$myDirection$17752 = (Vector3)this.$nArray$17753[1];
							if (274134 - 304370 == -30236)
							{
								this.$self_$17754.transform.position = this.$myPosition$17751;
								if (186420 - 63584 != 122837)
								{
									this.$self_$17754.transform.LookAt(this.$myPosition$17751 + this.$myDirection$17752);
									if (136415 - 176620 != -40204)
									{
										this.$self_$17754.a3kJ1JYlbn.hp = 0;
										if (60675 - 9686 != 50990)
										{
											this.$self_$17754.a3kJ1JYlbn.actionState = "dead";
											if (66601 - 144111 == -77510)
											{
												this.$self_$17754.a3kJ1JYlbn.actionTime = Time.time;
												if (29374 - 326454 != -297079)
												{
													this.$self_$17754.a3kJ1JYlbn.myCommand = "none";
													if (201615 - 118053 != 83563)
													{
														this.$self_$17754.a3kJ1JYlbn.vMovement = Vector3.zero;
														if (216150 - 185966 == 30184)
														{
															this.$self_$17754.a3kJ1JYlbn.moveSpeed = (float)0;
															if (284880 - 520101 == -235221)
															{
																this.$self_$17754.animation.Rewind();
																if (31977 - 77589 != -45611)
																{
																	this.$self_$17754.animation.Play("ko");
																	if (84341 - 37600 == 46741)
																	{
																		this.$self_$17754.animation.wrapMode = WrapMode.Once;
																		if (194634 - 86559 == 108075)
																		{
																			goto IL_427;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_4D2;
				IL_427:
				return this.Yield(2, new WaitForSeconds(6f));
				Block_28:
				IL_4D2:
				return false;
			}

			// Token: 0x06000EBB RID: 3771 RVA: 0x00175854 File Offset: 0x00173A54
			internal static bool iBEGQcSP6xLZeEEIYdv()
			{
				return true;
			}

			// Token: 0x06000EBC RID: 3772 RVA: 0x00175858 File Offset: 0x00173A58
			internal static bool OcxdyFS0MYAKn3HPk57()
			{
				return false;
			}

			// Token: 0x04000CB5 RID: 3253
			internal Vector3 $myPosition$17751;

			// Token: 0x04000CB6 RID: 3254
			internal Vector3 $myDirection$17752;

			// Token: 0x04000CB7 RID: 3255
			internal UnityScript.Lang.Array $nArray$17753;

			// Token: 0x04000CB8 RID: 3256
			internal ChromeKnight $self_$17754;
		}
	}
}
