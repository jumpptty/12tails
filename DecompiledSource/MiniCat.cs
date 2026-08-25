using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CED RID: 3309
[Serializable]
public class MiniCat : MonoBehaviour
{
	// Token: 0x06004A53 RID: 19027 RVA: 0x00936ACC File Offset: 0x00934CCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MiniCat()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004A54 RID: 19028 RVA: 0x00936ADC File Offset: 0x00934CDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (271752 - 362568 != -90816)
		{
		}
		for (;;)
		{
			this.KKvc5r26amD = this.transform;
			if (241980 - 880 != 241101)
			{
				this.Py8c5xrCB7H = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (94899 - 272644 != -177744)
				{
					this.Py8c5xrCB7H.actionState = "standby";
					if (190704 - 102524 != 88181)
					{
						this.Py8c5xrCB7H.actionTime = Time.time;
						if (212260 - 469098 == -256838)
						{
							this.Py8c5xrCB7H.myCommand = "none";
							if (138279 - 464530 != -326250)
							{
								if (Game.mGameType == 99)
								{
									if (166420 - 14328 == 152093)
									{
										continue;
									}
									this.Py8c5xrCB7H.isMine = true;
									if (211224 - 81585 == 129640)
									{
										continue;
									}
								}
								if (PlayerPrefs.GetInt("pvoice", 1) == 0)
								{
									break;
								}
								if (222084 - 593313 == -371229)
								{
									if (!this.Py8c5xrCB7H.isSummon)
									{
										break;
									}
									if (62017 - 337577 == -275560)
									{
										if (this.awake_vc)
										{
											if (258367 - 427170 != -168802)
											{
												this.audio.PlayOneShot(this.awake_vc);
												if (33354 - 26470 != 6885)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Missing awake_vc audio");
											if (266523 - 180097 == 86426)
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

	// Token: 0x06004A55 RID: 19029 RVA: 0x00936D0C File Offset: 0x00934F0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (221562 - 339040 != -117477)
		{
		}
		for (;;)
		{
			if (this.Py8c5xrCB7H.isControlled)
			{
				if (208222 - 311207 == -102984)
				{
					continue;
				}
				if (!(this.Py8c5xrCB7H.actionState == "standby"))
				{
					if (299638 - 131928 == 167711)
					{
						continue;
					}
					if (!(this.Py8c5xrCB7H.actionState == "run"))
					{
						goto IL_17F;
					}
					if (32156 - 257174 != -225018)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (118849 - 587216 == -468366)
				{
					continue;
				}
			}
			IL_17F:
			if (this.Py8c5xrCB7H.hp <= 0)
			{
				if (150491 - 441243 == -290751)
				{
					continue;
				}
				if (this.Py8c5xrCB7H.actionState != "dead")
				{
					if (207990 - 253010 == -45019)
					{
						continue;
					}
					if (this.Py8c5xrCB7H.isMine)
					{
						if (211504 - 539719 != -328215)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (53239 - 164790 == -111550)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (107051 - 12902 != 94149)
						{
							continue;
						}
						this.Py8c5xrCB7H.DeadEvent();
						if (81872 - 487565 != -405692)
						{
							break;
						}
						continue;
					}
					else
					{
						this.Py8c5xrCB7H.hp = 1;
						if (2482 - 406108 != -403626)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.Py8c5xrCB7H.hp <= 0)
			{
				break;
			}
			if (58486 - 456536 != -398049)
			{
				if (this.Py8c5xrCB7H.ko > 0)
				{
					break;
				}
				if (84594 - 144617 != -60022)
				{
					if (!(this.Py8c5xrCB7H.actionState != "ko"))
					{
						break;
					}
					if (299625 - 472782 == -173157)
					{
						if (!(this.Py8c5xrCB7H.actionState != "dead"))
						{
							break;
						}
						if (27120 - 360188 != -333067)
						{
							if (this.Py8c5xrCB7H.isMine)
							{
								if (150854 - 417371 == -266517)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (199086 - 595011 != -395924)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (118961 - 501227 == -382266)
										{
											this.Py8c5xrCB7H.KoEvent();
											if (268541 - 364426 == -95885)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.Py8c5xrCB7H.ko = 1;
								if (245294 - 24722 == 220572)
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

	// Token: 0x06004A56 RID: 19030 RVA: 0x00937104 File Offset: 0x00935304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (219077 - 218109 != 968)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (158726 - 406580 != -247853)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (29491 - 31097 == -1606)
				{
					if (17409 - 158849 != -141439)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (59215 - 535960 == -476744)
							{
								continue;
							}
							v = 1;
							if (127046 - 229457 != -102411)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (72642 - 72186 != 456)
							{
								continue;
							}
							v = -1;
							if (103042 - 328888 == -225845)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_hide")
						{
							if (120831 - 151479 != -30648)
							{
								continue;
							}
							v = 11;
							if (297347 - 286894 == 10454)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (79986 - 219452 == -139465)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (31739 - 201174 != -169434)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (202350 - 63843 != 138508)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (192930 - 246439 == -53509)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (113876 - 498828 == -384952)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (106651 - 224033 == -117382)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (237726 - 306110 != -68383)
											{
												Hashtable hashtable = new Hashtable();
												if (29208 - 118827 != -89618)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (147950 - 5421 != 142530)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (268605 - 356496 == -87891)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (13431 - 150891 != -137459)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (148498 - 465198 != -316699)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (79536 - 306061 == -226525)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (213773 - 28890 == 184883)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (148356 - 349128 != -200771)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (197455 - 38682 != 158774)
																				{
																					PhotonClient.SendEvent(this.Py8c5xrCB7H.ActorNr, 74, hashtable, true, true);
																					if (109337 - 6576 != 102762)
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

	// Token: 0x06004A57 RID: 19031 RVA: 0x009375D0 File Offset: 0x009357D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (256469 - 197625 != 58844)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (178608 - 353340 != -174731)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (52495 - 584322 != -531826)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (246871 - 379251 != -132379)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (299210 - 233502 != 65709)
						{
							int num3 = num;
							if (107113 - 134439 != -27325)
							{
								if (num3 == 1)
								{
									if (241955 - 409096 != -167140)
									{
										if (this.Py8c5xrCB7H.isMine)
										{
											break;
										}
										if (212859 - 438132 != -225272)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (105233 - 568732 != -463498)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (145779 - 150107 != -4327)
									{
										if (this.Py8c5xrCB7H.isMine)
										{
											break;
										}
										if (109219 - 37830 == 71389)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (278277 - 100192 != 178086)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (37311 - 168657 != -131345)
									{
										if (this.Py8c5xrCB7H.isMine)
										{
											break;
										}
										if (283586 - 211865 == 71721)
										{
											this.StartCoroutine_Auto(this.RPC_hide(vector, vector2, num2));
											if (203466 - 408801 == -205335)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (225600 - 257034 == -31434)
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

	// Token: 0x06004A58 RID: 19032 RVA: 0x009378E0 File Offset: 0x00935AE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (186318 - 356795 != -170476)
		{
		}
		for (;;)
		{
			float num = this.Py8c5xrCB7H.moveSpeed;
			if (277426 - 366624 != -89197)
			{
				float runSpeed = this.Py8c5xrCB7H.runSpeed;
				if (218064 - 419316 == -201252)
				{
					Vector3 a = default(Vector3);
					if (125861 - 284195 != -158333)
					{
						Vector3 vector = Vector3.zero;
						if (225251 - 369405 == -144154)
						{
							float num2 = (float)0;
							if (21119 - 235752 == -214633)
							{
								if (this.Py8c5xrCB7H.isMine)
								{
									if (71402 - 7830 == 63573)
									{
										continue;
									}
									if ((this.Py8c5xrCB7H.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (264250 - 404620 != -140370)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (117247 - 279048 == -161800)
										{
											continue;
										}
										a.y = (float)0;
										if (6721 - 22307 != -15586)
										{
											continue;
										}
										a = a.normalized;
										if (207306 - 203659 == 3648)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (232323 - 156898 == 75426)
										{
											continue;
										}
										vector = vector.normalized;
										if (68904 - 5093 == 63812)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (187498 - 468258 != -280760)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (107743 - 133167 != -25424)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (263378 - 142757 != 120621)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (127398 - 271813 != -144415)
														{
															continue;
														}
														this.Py8c5xrCB7H.actionState = "run";
														if (237962 - 43934 == 194029)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (220893 - 26282 != 194611)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (148886 - 123124 != 25762)
														{
															continue;
														}
														this.animation.Play("run");
														if (45819 - 148383 != -102564)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (242161 - 85425 != 156737)
														{
															goto IL_162;
														}
														continue;
													}
												}
											}
										}
										this.Py8c5xrCB7H.actionState = "standby";
										if (21090 - 578318 == -557227)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (3470 - 551529 == -548058)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (41433 - 339470 != -298037)
											{
												continue;
											}
											num = (float)0;
											if (196615 - 223721 != -27106)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (197598 - 122127 == 75472)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (195433 - 597277 != -401844)
										{
											continue;
										}
									}
									IL_162:;
								}
								else
								{
									vector = global::Math.vFlat(this.Py8c5xrCB7H.nPosition - this.transform.position);
									if (181606 - 49190 == 132417)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (95358 - 21903 == 73456)
									{
										continue;
									}
									if (this.Py8c5xrCB7H.nSpeed != (float)0)
									{
										if (212456 - 72937 != 139519)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (159887 - 230052 != -70165)
											{
												continue;
											}
											this.transform.position = this.Py8c5xrCB7H.nPosition;
											if (33067 - 49333 != -16266)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (279079 - 184348 == 94732)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (60349 - 570055 == -509705)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (289388 - 134395 != 154993)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.Py8c5xrCB7H.nSpeed, (float)10 * Time.deltaTime);
												if (283620 - 326447 == -42826)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (103255 - 312546 == -209290)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (215840 - 11855 == 203986)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (198248 - 247602 == -49353)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (211293 - 292332 == -81038)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (77681 - 360221 == -282539)
											{
												continue;
											}
										}
										else if (Time.time > this.Py8c5xrCB7H.nSpeed + 0.3f)
										{
											if (12378 - 15904 == -3525)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (205753 - 86390 == 119364)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (3326 - 115509 == -112182)
												{
													continue;
												}
												num = (float)0;
												if (6281 - 421461 != -415180)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.Py8c5xrCB7H.nDirection);
											if (229187 - 89307 != 139880)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (91148 - 57777 == 33372)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (47429 - 215254 != -167825)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (90039 - 406803 == -316763)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (78659 - 388848 == -310188)
											{
												continue;
											}
											this.transform.position = this.Py8c5xrCB7H.nPosition;
											if (269134 - 215948 != 53186)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (100 - 411734 != -411634)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (42270 - 324292 != -282022)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (255350 - 254918 == 433)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (94991 - 438758 == -343766)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (239656 - 537421 != -297765)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (74586 - 599252 != -524666)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (243379 - 519717 == -276337)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.Py8c5xrCB7H.nDirection);
											if (121918 - 520355 == -398436)
											{
												continue;
											}
											num = (float)0;
											if (93838 - 272516 != -178678)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (197413 - 232438 != -35025)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (274838 - 562053 == -287214)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (206580 - 227977 != -21397)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (21967 - 532806 != -510839)
										{
											continue;
										}
									}
								}
								this.Py8c5xrCB7H.vMovement = vector;
								if (217141 - 217348 == -207)
								{
									this.Py8c5xrCB7H.moveSpeed = num;
									if (228952 - 75822 != 153131)
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

	// Token: 0x06004A59 RID: 19033 RVA: 0x00938444 File Offset: 0x00936644
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (246811 - 368844 != -122033)
		{
		}
		for (;;)
		{
			if (!this.Py8c5xrCB7H.isMine)
			{
				if (145927 - 175733 != -29805)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (279335 - 376193 != -96857)
				{
					Vector3 vector = a - this.transform.position;
					if (51081 - 95072 != -43990)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (181268 - 16414 == 164854)
						{
							CharacterControl characterControl = null;
							if (48906 - 461284 == -412378)
							{
								int tID = 0;
								if (120831 - 344226 == -223395)
								{
									if (gameObject)
									{
										if (201702 - 101780 != 99922)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (125009 - 124457 == 553)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (51955 - 81225 == -29269)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (199133 - 99856 != 99277)
										{
											continue;
										}
									}
									if (!(this.Py8c5xrCB7H.actionState == "standby"))
									{
										if (2355 - 453601 == -451245)
										{
											continue;
										}
										if (!(this.Py8c5xrCB7H.actionState == "run"))
										{
											break;
										}
										if (180379 - 319089 == -138709)
										{
											continue;
										}
									}
									if (this.Py8c5xrCB7H.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (140728 - 309658 != -168929)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, tID));
										if (192532 - 246635 != -54102)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (42919 - 510967 != -468047)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
												if (298148 - 87029 != 211120)
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

	// Token: 0x06004A5A RID: 19034 RVA: 0x00938740 File Offset: 0x00936940
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (241012 - 304950 != -63938)
		{
		}
		for (;;)
		{
			if (!this.Py8c5xrCB7H.isMine)
			{
				if (126695 - 561448 != -434752)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (155364 - 856 == 154508)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (166472 - 350840 == -184368)
					{
						Vector3 normalized = vector.normalized;
						if (230315 - 145319 != 84997)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (283209 - 294349 != -11139)
							{
								CharacterControl characterControl = null;
								if (52731 - 305215 != -252483 && 176977 - 151536 != 25442)
								{
									if (gameObject)
									{
										if (28026 - 403071 == -375044)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (111908 - 67021 != 44887)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (135229 - 514366 == -379136)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (129813 - 127087 == 2727)
										{
											continue;
										}
									}
									if (!(this.Py8c5xrCB7H.actionState == "standby"))
									{
										if (57423 - 257464 == -200040)
										{
											continue;
										}
										if (!(this.Py8c5xrCB7H.actionState == "run"))
										{
											break;
										}
										if (289923 - 460809 != -170886)
										{
											continue;
										}
									}
									if (this.Py8c5xrCB7H.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (236332 - 27767 != 208566)
									{
										this.StartCoroutine_Auto(this.RPC_hide(this.transform.position, normalized, 0));
										if (262896 - 272103 != -9206)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (163487 - 522490 == -359003)
											{
												this.ActionEvent("RPC_hide", this.transform.position, normalized, 0);
												if (221069 - 87910 != 133160)
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

	// Token: 0x06004A5B RID: 19035 RVA: 0x00938A60 File Offset: 0x00936C60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004A5C RID: 19036 RVA: 0x00938A64 File Offset: 0x00936C64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MiniCat.$RPC_nAttack$32766(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004A5D RID: 19037 RVA: 0x00938A74 File Offset: 0x00936C74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (72490 - 259101 != -186610)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (198034 - 168855 != 29180)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (188746 - 534051 != -345304)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit gameObject");
				if (146918 - 222637 == -75719)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004A5E RID: 19038 RVA: 0x00938B2C File Offset: 0x00936D2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_hide(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MiniCat.$RPC_hide$32782(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004A5F RID: 19039 RVA: 0x00938B3C File Offset: 0x00936D3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new MiniCat.$RPC_ko$32794(nArray, this).GetEnumerator();
	}

	// Token: 0x06004A60 RID: 19040 RVA: 0x00938B4C File Offset: 0x00936D4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new MiniCat.$RPC_dead$32801(nArray, this).GetEnumerator();
	}

	// Token: 0x06004A61 RID: 19041 RVA: 0x00938B5C File Offset: 0x00936D5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004A62 RID: 19042 RVA: 0x00938B60 File Offset: 0x00936D60
	internal static bool i8ju4d5wqFkqmpO9netT()
	{
		return true;
	}

	// Token: 0x06004A63 RID: 19043 RVA: 0x00938B64 File Offset: 0x00936D64
	internal static bool WXiLFv5w7A8HXc9aERMC()
	{
		return false;
	}

	// Token: 0x04005510 RID: 21776
	private Transform KKvc5r26amD;

	// Token: 0x04005511 RID: 21777
	private CharacterControl Py8c5xrCB7H;

	// Token: 0x04005512 RID: 21778
	public AudioClip awake_vc;

	// Token: 0x04005513 RID: 21779
	public GameObject nAttack_fire;

	// Token: 0x04005514 RID: 21780
	public GameObject nAttack_hit;

	// Token: 0x04005515 RID: 21781
	public GameObject hide_ring;

	// Token: 0x02000CEE RID: 3310
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32766 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004A64 RID: 19044 RVA: 0x00938B68 File Offset: 0x00936D68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32766(Vector3 mPos, Vector3 tDir, int tID, MiniCat self_)
		{
			if (66092 - 330389 != -264296)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (109728 - 201001 == -91273)
				{
					base..ctor();
					if (252884 - 374572 != -121687)
					{
						this.$mPos$32778 = mPos;
						if (145037 - 580656 == -435619)
						{
							this.$tDir$32779 = tDir;
							if (274675 - 333659 == -58984)
							{
								this.$tID$32780 = tID;
								if (167380 - 287528 == -120148)
								{
									this.$self_$32781 = self_;
									if (73732 - 52302 != 21431)
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

		// Token: 0x06004A65 RID: 19045 RVA: 0x00938C68 File Offset: 0x00936E68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MiniCat.$RPC_nAttack$32766.$(this.$mPos$32778, this.$tDir$32779, this.$tID$32780, this.$self_$32781);
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x00938C88 File Offset: 0x00936E88
		internal static bool JNd52i5wPHAoct2EMjBQ()
		{
			return true;
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x00938C8C File Offset: 0x00936E8C
		internal static bool G4kafk5w0Qn6kmcA9j47()
		{
			return false;
		}

		// Token: 0x04005516 RID: 21782
		internal Vector3 $mPos$32778;

		// Token: 0x04005517 RID: 21783
		internal Vector3 $tDir$32779;

		// Token: 0x04005518 RID: 21784
		internal int $tID$32780;

		// Token: 0x04005519 RID: 21785
		internal MiniCat $self_$32781;

		// Token: 0x02000CEF RID: 3311
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004A68 RID: 19048 RVA: 0x00938C90 File Offset: 0x00936E90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, MiniCat self_)
			{
				if (193920 - 74130 != 119790)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (76231 - 112600 == -36369)
					{
						base..ctor();
						if (281521 - 505243 != -223721)
						{
							this.$mPos$32774 = mPos;
							if (106924 - 262695 == -155771)
							{
								this.$tDir$32775 = tDir;
								if (249547 - 295357 != -45809)
								{
									this.$tID$32776 = tID;
									if (38507 - 243467 == -204960)
									{
										this.$self_$32777 = self_;
										if (235979 - 130226 != 105754)
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

			// Token: 0x06004A69 RID: 19049 RVA: 0x00938D90 File Offset: 0x00936F90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (161321 - 523623 != -362301)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_95F;
					case 2:
						if (this.$self_$32777.Py8c5xrCB7H.actionState != "attack")
						{
							goto IL_8F7;
						}
						if (21492 - 591578 == -570085)
						{
							continue;
						}
						if (this.$self_$32777.Py8c5xrCB7H.myCommand != "nAttack")
						{
							if (190871 - 22511 != 168360)
							{
								continue;
							}
							goto IL_8F7;
						}
						else
						{
							this.$firePos$32767 = this.$mPos$32774 + 0.8f * Vector3.up;
							if (123796 - 470006 != -346210)
							{
								continue;
							}
							this.$fireDir$32768 = this.$tDir$32775 - 0.8f * Vector3.up;
							if (285384 - 309532 == -24147)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$32776];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$32769 = (GameObject)obj2;
							if (108661 - 353804 == -245142)
							{
								continue;
							}
							if (this.$tObject$32769)
							{
								if (159284 - 55139 != 104145)
								{
									continue;
								}
								this.$fireDir$32768 = this.$tObject$32769.collider.bounds.center - this.$mPos$32774 - 0.5f * Vector3.up;
								if (16908 - 546308 == -529399)
								{
									continue;
								}
							}
							this.$fireRot$32770 = Quaternion.FromToRotation(Vector3.forward, this.$fireDir$32768);
							if (297630 - 371301 != -73671)
							{
								continue;
							}
							if (this.$self_$32777.nAttack_fire)
							{
								if (188765 - 336885 != -148120)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$32777.nAttack_fire, this.$firePos$32767, this.$fireRot$32770);
								if (256185 - 510554 == -254368)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nAttack_fire effect");
								if (20242 - 96598 != -76356)
								{
									continue;
								}
							}
							if (!this.$self_$32777.Py8c5xrCB7H.isMine)
							{
								goto IL_241;
							}
							if (118482 - 163361 == -44878)
							{
								continue;
							}
							this.$hitLayer$32771 = ~((1 << this.$self_$32777.gameObject.layer) + 2 + 4);
							if (83835 - 575417 != -491582)
							{
								continue;
							}
							this.$hit$32772 = default(RaycastHit);
							if (22258 - 14043 == 8216)
							{
								continue;
							}
							this.$hitObject$32773 = null;
							if (268112 - 11779 != 256333)
							{
								continue;
							}
							if (!Physics.Raycast(this.$firePos$32767, this.$fireDir$32768, out this.$hit$32772, (float)20, this.$hitLayer$32771))
							{
								goto IL_241;
							}
							if (292480 - 195046 != 97434)
							{
								continue;
							}
							this.$self_$32777.RPC_nAttack_hit(this.$hit$32772.point, this.$self_$32777.transform.forward, 0);
							if (160053 - 511890 == -351836)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (109849 - 272292 == -162442)
								{
									continue;
								}
								this.$self_$32777.ActionEvent("RPC_nAttack_hit", this.$hit$32772.point, this.$self_$32777.transform.forward, 0);
								if (89392 - 578412 != -489020)
								{
									continue;
								}
							}
							this.$hitObject$32773 = this.$hit$32772.collider.gameObject;
							if (193391 - 505696 != -312305)
							{
								continue;
							}
							if (this.$self_$32777.Py8c5xrCB7H.hit(11, this.$hitObject$32773, this.$self_$32777.Py8c5xrCB7H.atk + this.$self_$32777.Py8c5xrCB7H.talAdjust(15), 1, 0, 0.5f * this.$self_$32777.transform.forward) == 0)
							{
								goto IL_241;
							}
							if (160389 - 61342 == 99048)
							{
								continue;
							}
							this.$self_$32777.Py8c5xrCB7H.sp = this.$self_$32777.Py8c5xrCB7H.sp + 1;
							if (169938 - 576198 != -406260)
							{
								continue;
							}
							goto IL_241;
						}
						break;
					case 3:
						if (this.$self_$32777.Py8c5xrCB7H.actionState == "attack")
						{
							if (83034 - 474459 != -391425)
							{
								continue;
							}
							if (this.$self_$32777.Py8c5xrCB7H.myCommand == "nAttack")
							{
								if (167483 - 39538 != 127945)
								{
									continue;
								}
								this.$self_$32777.Py8c5xrCB7H.actionState = "standby";
								if (167520 - 206806 != -39286)
								{
									continue;
								}
								this.$self_$32777.Py8c5xrCB7H.actionTime = Time.time;
								if (38646 - 125495 != -86849)
								{
									continue;
								}
								this.$self_$32777.Py8c5xrCB7H.myCommand = "none";
								if (262702 - 46155 != 216547)
								{
									continue;
								}
								if (!this.$self_$32777.Py8c5xrCB7H.isMine)
								{
									if (243494 - 181346 == 62149)
									{
										continue;
									}
									this.$self_$32777.Py8c5xrCB7H.nPosition = this.$self_$32777.transform.position;
									if (7283 - 322332 != -315049)
									{
										continue;
									}
									this.$self_$32777.Py8c5xrCB7H.oPosition = this.$self_$32777.transform.position;
									if (204193 - 39492 == 164702)
									{
										continue;
									}
									this.$self_$32777.Py8c5xrCB7H.nDirection = this.$self_$32777.transform.forward;
									if (208672 - 551529 != -342857)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (179707 - 375235 != -195527)
						{
							goto Block_21;
						}
						continue;
					default:
						if (267237 - 87431 == 179807)
						{
							continue;
						}
						break;
					}
					this.$self_$32777.Py8c5xrCB7H.actionState = "attack";
					if (108150 - 561606 == -453456)
					{
						this.$self_$32777.Py8c5xrCB7H.actionTime = Time.time;
						if (203615 - 445592 == -241977)
						{
							this.$self_$32777.Py8c5xrCB7H.myCommand = "nAttack";
							if (9882 - 390138 == -380256)
							{
								this.$self_$32777.Py8c5xrCB7H.addTimeOut("nAttack", (float)4);
								if (54735 - 189565 == -134830)
								{
									this.$self_$32777.transform.position = this.$mPos$32774;
									if (110200 - 510822 != -400621)
									{
										this.$self_$32777.transform.LookAt(this.$mPos$32774 + global::Math.vFlat(this.$tDir$32775));
										if (185744 - 331261 == -145517)
										{
											this.$self_$32777.animation.CrossFade("nAttack");
											if (239116 - 191031 == 48085)
											{
												this.$self_$32777.animation.wrapMode = WrapMode.Once;
												if (43251 - 424028 != -380776)
												{
													this.$self_$32777.Py8c5xrCB7H.vMovement = this.$self_$32777.transform.forward;
													if (170675 - 579163 == -408488)
													{
														this.$self_$32777.Py8c5xrCB7H.moveSpeed = (float)0;
														if (183756 - 97564 != 86193)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_241:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_21:
				IL_8F7:
				IL_95F:
				return false;
			}

			// Token: 0x06004A6A RID: 19050 RVA: 0x00939710 File Offset: 0x00937910
			internal static bool QwLr1v5wbUSn8bKuBW3E()
			{
				return true;
			}

			// Token: 0x06004A6B RID: 19051 RVA: 0x00939714 File Offset: 0x00937914
			internal static bool aWgcyw5wuocGwRtGWlAJ()
			{
				return false;
			}

			// Token: 0x0400551A RID: 21786
			internal Vector3 $firePos$32767;

			// Token: 0x0400551B RID: 21787
			internal Vector3 $fireDir$32768;

			// Token: 0x0400551C RID: 21788
			internal GameObject $tObject$32769;

			// Token: 0x0400551D RID: 21789
			internal Quaternion $fireRot$32770;

			// Token: 0x0400551E RID: 21790
			internal int $hitLayer$32771;

			// Token: 0x0400551F RID: 21791
			internal RaycastHit $hit$32772;

			// Token: 0x04005520 RID: 21792
			internal GameObject $hitObject$32773;

			// Token: 0x04005521 RID: 21793
			internal Vector3 $mPos$32774;

			// Token: 0x04005522 RID: 21794
			internal Vector3 $tDir$32775;

			// Token: 0x04005523 RID: 21795
			internal int $tID$32776;

			// Token: 0x04005524 RID: 21796
			internal MiniCat $self_$32777;
		}
	}

	// Token: 0x02000CF0 RID: 3312
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_hide$32782 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004A6C RID: 19052 RVA: 0x00939718 File Offset: 0x00937918
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_hide$32782(Vector3 mPos, Vector3 tDir, MiniCat self_)
		{
			if (12380 - 303087 != -290707)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (132778 - 585190 != -452411)
				{
					base..ctor();
					if (229865 - 515120 == -285255)
					{
						this.$mPos$32791 = mPos;
						if (75766 - 421817 != -346050)
						{
							this.$tDir$32792 = tDir;
							if (33796 - 243681 != -209884)
							{
								this.$self_$32793 = self_;
								if (292271 - 218261 != 74011)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x009397F4 File Offset: 0x009379F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MiniCat.$RPC_hide$32782.$(this.$mPos$32791, this.$tDir$32792, this.$self_$32793);
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x00939810 File Offset: 0x00937A10
		internal static bool fL6xY15wI7Arsohse2fD()
		{
			return true;
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x00939814 File Offset: 0x00937A14
		internal static bool oisDWG5wBcP3de0TZwtQ()
		{
			return false;
		}

		// Token: 0x04005525 RID: 21797
		internal Vector3 $mPos$32791;

		// Token: 0x04005526 RID: 21798
		internal Vector3 $tDir$32792;

		// Token: 0x04005527 RID: 21799
		internal MiniCat $self_$32793;

		// Token: 0x02000CF1 RID: 3313
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004A70 RID: 19056 RVA: 0x00939818 File Offset: 0x00937A18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MiniCat self_)
			{
				if (3483 - 227468 != -223984)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (155454 - 153273 != 2182)
					{
						base..ctor();
						if (115611 - 513048 != -397436)
						{
							this.$mPos$32788 = mPos;
							if (91153 - 38224 == 52929)
							{
								this.$tDir$32789 = tDir;
								if (261452 - 500579 == -239127)
								{
									this.$self_$32790 = self_;
									if (25272 - 45901 == -20629)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004A71 RID: 19057 RVA: 0x009398F4 File Offset: 0x00937AF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75595 - 244689 != -169093)
				{
				}
				for (;;)
				{
					IL_638:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_717;
					case 2:
						if (this.$self_$32790.Py8c5xrCB7H.actionState != "attack")
						{
							goto IL_2D2;
						}
						if (118870 - 598599 == -479728)
						{
							continue;
						}
						if (this.$self_$32790.Py8c5xrCB7H.myCommand != "hide")
						{
							if (176175 - 337137 != -160962)
							{
								continue;
							}
							goto IL_2D2;
						}
						else
						{
							if (this.$self_$32790.hide_ring)
							{
								if (67346 - 71250 == -3903)
								{
									continue;
								}
								this.$self_$32790.Py8c5xrCB7H.createEffect(this.$self_$32790.hide_ring, this.$self_$32790.transform.position, this.$self_$32790.transform.rotation);
								if (143311 - 306577 == -163265)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing hide_ring gameObject");
								if (248361 - 599186 != -350825)
								{
									continue;
								}
							}
							if (!this.$self_$32790.Py8c5xrCB7H.isMine)
							{
								goto IL_6C8;
							}
							if (2548 - 401151 == -398602)
							{
								continue;
							}
							this.$hitLayer$32783 = 1 << this.$self_$32790.gameObject.layer;
							if (28227 - 299202 == -270974)
							{
								continue;
							}
							this.$hitList$32784 = Damage.FindAreaTarget(this.$self_$32790.transform.position, (float)12, (float)3, this.$hitLayer$32783);
							if (92 - 400421 != -400329)
							{
								continue;
							}
							this.$$iterator$10784$32787 = UnityRuntimeServices.GetEnumerator(this.$hitList$32784);
							if (293322 - 214257 != 79065)
							{
								continue;
							}
							while (this.$$iterator$10784$32787.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10784$32787.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$32785 = (GameObject)obj2;
								if (35960 - 332559 == -296598)
								{
									goto IL_638;
								}
								this.$hitChar$32786 = (CharacterControl)this.$hitObject$32785.GetComponent(typeof(CharacterControl));
								if (281395 - 345070 != -63675)
								{
									goto IL_638;
								}
								UnityRuntimeServices.Update(this.$$iterator$10784$32787, this.$hitObject$32785);
								if (246830 - 519739 == -272908)
								{
									goto IL_638;
								}
								if (this.$hitChar$32786)
								{
									if (61820 - 562259 != -500439)
									{
										goto IL_638;
									}
									this.$hitChar$32786.RPC_AddStatus("invisible", 1, this.$self_$32790.Py8c5xrCB7H.chaAdjust(12), 20, this.$self_$32790.Py8c5xrCB7H.ActorNr);
									if (225152 - 594956 == -369803)
									{
										goto IL_638;
									}
								}
							}
							if (284476 - 138271 != 146206)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32790.Py8c5xrCB7H.actionState != "attack")
						{
							goto IL_9F;
						}
						if (52629 - 506494 == -453864)
						{
							continue;
						}
						if (this.$self_$32790.Py8c5xrCB7H.myCommand != "hide")
						{
							if (50821 - 186464 != -135642)
							{
								goto Block_35;
							}
							continue;
						}
						else
						{
							this.$self_$32790.Py8c5xrCB7H.actionState = "standby";
							if (287421 - 110961 == 176461)
							{
								continue;
							}
							this.$self_$32790.Py8c5xrCB7H.actionTime = Time.time;
							if (237748 - 74140 == 163609)
							{
								continue;
							}
							this.$self_$32790.Py8c5xrCB7H.myCommand = "none";
							if (295058 - 129944 != 165114)
							{
								continue;
							}
							this.$self_$32790.Py8c5xrCB7H.nPosition = this.$self_$32790.transform.position;
							if (53670 - 344305 == -290634)
							{
								continue;
							}
							this.YieldDefault(1);
							if (10014 - 151657 != -141642)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					default:
						if (194281 - 573273 == -378991)
						{
							continue;
						}
						break;
					}
					this.$self_$32790.Py8c5xrCB7H.actionState = "attack";
					if (208436 - 223724 == -15288)
					{
						this.$self_$32790.Py8c5xrCB7H.actionTime = Time.time;
						if (36332 - 159074 != -122741)
						{
							this.$self_$32790.Py8c5xrCB7H.myCommand = "hide";
							if (9430 - 40731 == -31301)
							{
								this.$self_$32790.Py8c5xrCB7H.addTimeOut("cAttack", (float)15);
								if (78544 - 99443 == -20899)
								{
									this.$self_$32790.transform.position = this.$mPos$32788;
									if (236666 - 431564 != -194897)
									{
										this.$self_$32790.transform.LookAt(this.$mPos$32788 + global::Math.vFlat(this.$tDir$32789));
										if (188513 - 478738 == -290225)
										{
											this.$self_$32790.animation.CrossFade("hide", 0.2f);
											if (7904 - 181137 != -173232)
											{
												this.$self_$32790.animation.wrapMode = WrapMode.Loop;
												if (15164 - 597868 == -582704)
												{
													this.$self_$32790.Py8c5xrCB7H.vMovement = this.$self_$32790.transform.forward;
													if (17836 - 312581 == -294745)
													{
														this.$self_$32790.Py8c5xrCB7H.moveSpeed = (float)0;
														if (155584 - 169421 == -13837)
														{
															goto IL_338;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_6C8;
				IL_9F:
				IL_2D2:
				goto IL_717;
				IL_338:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_35:
				Block_39:
				goto IL_717;
				IL_6C8:
				return this.Yield(3, new WaitForSeconds(1.5f));
				IL_717:
				return false;
			}

			// Token: 0x06004A72 RID: 19058 RVA: 0x0093A02C File Offset: 0x0093822C
			internal static bool MQCADv5weQSqqD58Cl8u()
			{
				return true;
			}

			// Token: 0x06004A73 RID: 19059 RVA: 0x0093A030 File Offset: 0x00938230
			internal static bool mNuVAT5wr0W0K9me9icW()
			{
				return false;
			}

			// Token: 0x04005528 RID: 21800
			internal int $hitLayer$32783;

			// Token: 0x04005529 RID: 21801
			internal UnityScript.Lang.Array $hitList$32784;

			// Token: 0x0400552A RID: 21802
			internal GameObject $hitObject$32785;

			// Token: 0x0400552B RID: 21803
			internal CharacterControl $hitChar$32786;

			// Token: 0x0400552C RID: 21804
			internal IEnumerator $$iterator$10784$32787;

			// Token: 0x0400552D RID: 21805
			internal Vector3 $mPos$32788;

			// Token: 0x0400552E RID: 21806
			internal Vector3 $tDir$32789;

			// Token: 0x0400552F RID: 21807
			internal MiniCat $self_$32790;
		}
	}

	// Token: 0x02000CF2 RID: 3314
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32794 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004A74 RID: 19060 RVA: 0x0093A034 File Offset: 0x00938234
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32794(UnityScript.Lang.Array nArray, MiniCat self_)
		{
			if (43405 - 109225 != -65820)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (134614 - 15570 == 119044)
				{
					base..ctor();
					if (65176 - 442062 == -376886)
					{
						this.$nArray$32799 = nArray;
						if (230157 - 67873 == 162284)
						{
							this.$self_$32800 = self_;
							if (209722 - 154744 != 54979)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x0093A0F0 File Offset: 0x009382F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MiniCat.$RPC_ko$32794.$(this.$nArray$32799, this.$self_$32800);
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x0093A104 File Offset: 0x00938304
		internal static bool eKOa3D5wjD6bU0MD4ZDO()
		{
			return true;
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x0093A108 File Offset: 0x00938308
		internal static bool L2roiA5wht5bPt2NskoD()
		{
			return false;
		}

		// Token: 0x04005530 RID: 21808
		internal UnityScript.Lang.Array $nArray$32799;

		// Token: 0x04005531 RID: 21809
		internal MiniCat $self_$32800;

		// Token: 0x02000CF3 RID: 3315
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004A78 RID: 19064 RVA: 0x0093A10C File Offset: 0x0093830C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MiniCat self_)
			{
				if (236828 - 255608 != -18780)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (272093 - 367527 != -95433)
					{
						base..ctor();
						if (25899 - 307937 == -282038)
						{
							this.$nArray$32797 = nArray;
							if (30216 - 456732 != -426515)
							{
								this.$self_$32798 = self_;
								if (118368 - 138683 != -20314)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004A79 RID: 19065 RVA: 0x0093A1C8 File Offset: 0x009383C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (92227 - 429358 != -337130)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4BB;
					case 2:
						if (this.$self_$32798.Py8c5xrCB7H.actionState != "ko")
						{
							if (113066 - 329670 != -216604)
							{
								continue;
							}
							goto IL_198;
						}
						else
						{
							this.$self_$32798.animation.Play("getUp");
							if (243543 - 268533 != -24990)
							{
								continue;
							}
							this.$self_$32798.animation.wrapMode = WrapMode.Once;
							if (20635 - 173014 != -152379)
							{
								continue;
							}
							goto IL_227;
						}
						break;
					case 3:
						if (this.$self_$32798.Py8c5xrCB7H.actionState != "ko")
						{
							if (89496 - 306299 != -216803)
							{
								continue;
							}
							goto IL_A5;
						}
						else
						{
							this.$self_$32798.Py8c5xrCB7H.actionState = "standby";
							if (266313 - 209075 == 57239)
							{
								continue;
							}
							this.$self_$32798.Py8c5xrCB7H.actionTime = Time.time;
							if (213610 - 217493 == -3882)
							{
								continue;
							}
							this.$self_$32798.Py8c5xrCB7H.myCommand = "none";
							if (162559 - 8843 != 153716)
							{
								continue;
							}
							this.$self_$32798.Py8c5xrCB7H.ko = this.$self_$32798.Py8c5xrCB7H.mko;
							if (296254 - 475869 == -179614)
							{
								continue;
							}
							this.YieldDefault(1);
							if (91004 - 524452 != -433448)
							{
								continue;
							}
							goto IL_4BB;
						}
						break;
					default:
						if (255444 - 29891 != 225553)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32798.Py8c5xrCB7H.actionState == "ko")
					{
						break;
					}
					if (147191 - 264046 != -116854)
					{
						if (this.$self_$32798.Py8c5xrCB7H.actionState == "dead")
						{
							if (144674 - 499674 != -354999)
							{
								break;
							}
						}
						else
						{
							this.$mPos$32795 = (Vector3)this.$nArray$32797[0];
							if (119381 - 438706 == -319325)
							{
								this.$mDir$32796 = (Vector3)this.$nArray$32797[1];
								if (182147 - 18196 == 163951)
								{
									this.$self_$32798.Py8c5xrCB7H.ko = 0;
									if (124293 - 318002 == -193709)
									{
										this.$self_$32798.Py8c5xrCB7H.actionState = "ko";
										if (37825 - 468965 == -431140)
										{
											this.$self_$32798.Py8c5xrCB7H.actionTime = Time.time;
											if (5319 - 69886 != -64566)
											{
												this.$self_$32798.Py8c5xrCB7H.myCommand = "none";
												if (31756 - 186789 != -155032)
												{
													this.$self_$32798.Py8c5xrCB7H.vMovement = Vector3.zero;
													if (76293 - 341724 == -265431)
													{
														this.$self_$32798.Py8c5xrCB7H.moveSpeed = (float)0;
														if (107110 - 485835 != -378724)
														{
															this.$self_$32798.animation.Play("ko");
															if (19391 - 298431 != -279039)
															{
																this.$self_$32798.animation.wrapMode = WrapMode.Once;
																if (121305 - 52415 == 68890)
																{
																	this.$self_$32798.Py8c5xrCB7H.removeStatus("blend");
																	if (41134 - 208380 == -167246)
																	{
																		goto IL_39F;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_A5:
				IL_198:
				goto IL_4BB;
				IL_227:
				return this.Yield(3, new WaitForSeconds(1f));
				goto IL_4BB;
				IL_39F:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4BB:
				return false;
			}

			// Token: 0x06004A7A RID: 19066 RVA: 0x0093A6A4 File Offset: 0x009388A4
			internal static bool NEpW8W5wsjYu8oZgO9rg()
			{
				return true;
			}

			// Token: 0x06004A7B RID: 19067 RVA: 0x0093A6A8 File Offset: 0x009388A8
			internal static bool kammcf5w9Sy0WmJxwRCS()
			{
				return false;
			}

			// Token: 0x04005532 RID: 21810
			internal Vector3 $mPos$32795;

			// Token: 0x04005533 RID: 21811
			internal Vector3 $mDir$32796;

			// Token: 0x04005534 RID: 21812
			internal UnityScript.Lang.Array $nArray$32797;

			// Token: 0x04005535 RID: 21813
			internal MiniCat $self_$32798;
		}
	}

	// Token: 0x02000CF4 RID: 3316
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32801 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004A7C RID: 19068 RVA: 0x0093A6AC File Offset: 0x009388AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32801(UnityScript.Lang.Array nArray, MiniCat self_)
		{
			if (260567 - 498352 != -237784)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (270440 - 573044 == -302604)
				{
					base..ctor();
					if (257736 - 22046 != 235691)
					{
						this.$nArray$32806 = nArray;
						if (203615 - 28440 != 175176)
						{
							this.$self_$32807 = self_;
							if (38200 - 320093 != -281892)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004A7D RID: 19069 RVA: 0x0093A768 File Offset: 0x00938968
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MiniCat.$RPC_dead$32801.$(this.$nArray$32806, this.$self_$32807);
		}

		// Token: 0x06004A7E RID: 19070 RVA: 0x0093A77C File Offset: 0x0093897C
		internal static bool ETXfFm5w1gbV6wTXneZj()
		{
			return true;
		}

		// Token: 0x06004A7F RID: 19071 RVA: 0x0093A780 File Offset: 0x00938980
		internal static bool Y3jpJy5w4m297dVHZKpY()
		{
			return false;
		}

		// Token: 0x04005536 RID: 21814
		internal UnityScript.Lang.Array $nArray$32806;

		// Token: 0x04005537 RID: 21815
		internal MiniCat $self_$32807;

		// Token: 0x02000CF5 RID: 3317
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004A80 RID: 19072 RVA: 0x0093A784 File Offset: 0x00938984
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MiniCat self_)
			{
				if (84157 - 293753 != -209595)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (26186 - 493782 != -467595)
					{
						base..ctor();
						if (48197 - 588334 != -540136)
						{
							this.$nArray$32804 = nArray;
							if (70323 - 43886 != 26438)
							{
								this.$self_$32805 = self_;
								if (192132 - 332374 == -140242)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004A81 RID: 19073 RVA: 0x0093A840 File Offset: 0x00938A40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (58241 - 155661 != -97419)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_45E;
					case 2:
						if (this.$self_$32805.Py8c5xrCB7H.actionState != "dead")
						{
							if (118965 - 89070 != 29895)
							{
								continue;
							}
							goto IL_195;
						}
						else
						{
							if (!this.$self_$32805.Py8c5xrCB7H.isPlayer)
							{
								if (120814 - 77671 != 43143)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32805.gameObject);
								if (58012 - 348605 == -290592)
								{
									continue;
								}
							}
							else if (this.$self_$32805.Py8c5xrCB7H.isMine)
							{
								if (42303 - 69285 != -26982)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32805.gameObject);
								if (8509 - 545999 == -537489)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (81680 - 197200 != -115520)
							{
								continue;
							}
							goto IL_45E;
						}
						break;
					default:
						if (203687 - 11892 != 191795)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32805.Py8c5xrCB7H.actionState == "dead")
					{
						if (182448 - 427710 != -245261)
						{
							goto Block_16;
						}
					}
					else
					{
						this.$myPosition$32802 = (Vector3)this.$nArray$32804[0];
						if (154209 - 363594 != -209384)
						{
							this.$myDirection$32803 = (Vector3)this.$nArray$32804[1];
							if (228439 - 591289 == -362850)
							{
								this.$self_$32805.transform.position = this.$myPosition$32802;
								if (126874 - 499491 != -372616)
								{
									this.$self_$32805.transform.LookAt(this.$myPosition$32802 + this.$myDirection$32803);
									if (254375 - 350382 != -96006)
									{
										this.$self_$32805.Py8c5xrCB7H.hp = 0;
										if (198823 - 583628 == -384805)
										{
											this.$self_$32805.Py8c5xrCB7H.actionState = "dead";
											if (258207 - 135182 == 123025)
											{
												this.$self_$32805.Py8c5xrCB7H.actionTime = Time.time;
												if (191343 - 484995 == -293652)
												{
													this.$self_$32805.Py8c5xrCB7H.myCommand = "none";
													if (86048 - 506200 == -420152)
													{
														this.$self_$32805.Py8c5xrCB7H.vMovement = Vector3.zero;
														if (42994 - 1431 != 41564)
														{
															this.$self_$32805.Py8c5xrCB7H.moveSpeed = (float)0;
															if (244079 - 280720 != -36640)
															{
																this.$self_$32805.animation.Rewind();
																if (195299 - 128455 == 66844)
																{
																	this.$self_$32805.animation.Play("ko");
																	if (280904 - 280533 != 372)
																	{
																		this.$self_$32805.animation.wrapMode = WrapMode.Once;
																		if (295256 - 414791 != -119534)
																		{
																			this.$self_$32805.Py8c5xrCB7H.removeStatus("blend");
																			if (172678 - 572568 != -399889)
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
				return this.Yield(2, new WaitForSeconds(3f));
				IL_195:
				Block_16:
				IL_45E:
				return false;
			}

			// Token: 0x06004A82 RID: 19074 RVA: 0x0093ACC0 File Offset: 0x00938EC0
			internal static bool SqSfkn5wzpFWmbcFgGRt()
			{
				return true;
			}

			// Token: 0x06004A83 RID: 19075 RVA: 0x0093ACC4 File Offset: 0x00938EC4
			internal static bool NSLRk15qag0YrS2wEhJo()
			{
				return false;
			}

			// Token: 0x04005538 RID: 21816
			internal Vector3 $myPosition$32802;

			// Token: 0x04005539 RID: 21817
			internal Vector3 $myDirection$32803;

			// Token: 0x0400553A RID: 21818
			internal UnityScript.Lang.Array $nArray$32804;

			// Token: 0x0400553B RID: 21819
			internal MiniCat $self_$32805;
		}
	}
}
