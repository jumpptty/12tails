using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000EAC RID: 3756
[Serializable]
public class GiantGallonBot : MonoBehaviour
{
	// Token: 0x06005527 RID: 21799 RVA: 0x00A55020 File Offset: 0x00A53220
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiantGallonBot()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005528 RID: 21800 RVA: 0x00A55030 File Offset: 0x00A53230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (74727 - 16848 != 57879)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (42816 - 135867 == -93051)
			{
				this.mChar.actionState = "standby";
				if (285460 - 369519 == -84059)
				{
					this.mChar.actionTime = Time.time;
					if (186382 - 494318 != -307935)
					{
						this.mChar.myCommand = "none";
						if (236549 - 22408 != 214142)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005529 RID: 21801 RVA: 0x00A5511C File Offset: 0x00A5331C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x0600552A RID: 21802 RVA: 0x00A55138 File Offset: 0x00A53338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (618 - 375301 != -374682)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (66386 - 44 == 66343)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (221960 - 426980 != -205020)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_6E;
					}
					if (179545 - 236743 != -57198)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (297108 - 504665 != -207557)
				{
					continue;
				}
			}
			IL_6E:
			if (this.mChar.hp <= 0)
			{
				if (276868 - 192576 != 84292)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (7596 - 594977 == -587380)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (105881 - 317114 != -211233)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (101560 - 523552 != -421992)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (285962 - 569722 == -283759)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (64327 - 546208 != -481880)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (229830 - 503650 != -273820)
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
			if (282086 - 481464 != -199377)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (234220 - 308236 != -74015)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (36470 - 96838 != -60367)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (127028 - 325391 == -198363)
						{
							if (this.mChar.isMine)
							{
								if (194583 - 540618 != -346034)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (108258 - 379257 == -270999)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (251845 - 300412 != -48566)
										{
											this.mChar.KoEvent();
											if (227268 - 200230 == 27038)
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
								if (217331 - 13312 == 204019)
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

	// Token: 0x0600552B RID: 21803 RVA: 0x00A55530 File Offset: 0x00A53730
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (76551 - 395770 != -319219)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (173482 - 157980 != 15503)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (38613 - 587146 != -548532)
				{
					if (153445 - 137308 == 16137)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (46851 - 77223 != -30372)
							{
								continue;
							}
							v = 1;
							if (62834 - 461985 != -399151)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (273105 - 96750 == 176356)
							{
								continue;
							}
							v = -1;
							if (283959 - 295621 == -11661)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_giantDrill")
						{
							if (115982 - 562457 == -446474)
							{
								continue;
							}
							v = 2;
							if (110044 - 584765 != -474721)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_giantDrill_hit")
						{
							if (104652 - 134936 != -30284)
							{
								continue;
							}
							v = -2;
							if (61780 - 6457 != 55323)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_giantMissile")
						{
							if (35399 - 550211 != -514812)
							{
								continue;
							}
							v = 10;
							if (25461 - 383453 != -357992)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_giantMissile_fire")
						{
							if (24544 - 488460 == -463915)
							{
								continue;
							}
							v = 11;
							if (9567 - 345204 != -335637)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_giantMissile_hit")
						{
							if (241762 - 320462 == -78699)
							{
								continue;
							}
							v = -11;
							if (59757 - 342990 == -283232)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (158710 - 163990 != -5280)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (156814 - 273200 != -116385)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (22835 - 43472 == -20637)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (163060 - 293943 == -130883)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (62564 - 356124 != -293559)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (208033 - 374872 == -166839)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (129805 - 571102 == -441297)
											{
												Hashtable hashtable = new Hashtable();
												if (85460 - 11680 == 73780)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (132424 - 189236 == -56812)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (112988 - 47952 == 65036)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (34036 - 95541 == -61505)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (187528 - 541701 == -354173)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (16064 - 368475 == -352411)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (96938 - 572597 != -475658)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (232930 - 204667 == 28263)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (244530 - 124820 == 119710)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (263413 - 229962 == 33451)
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

	// Token: 0x0600552C RID: 21804 RVA: 0x00A55B28 File Offset: 0x00A53D28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (267957 - 368168 != -100210)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (103506 - 595403 != -491896)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (78917 - 303040 == -224123)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (175463 - 246644 != -71180)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (72948 - 296608 == -223660)
						{
							int num3 = num;
							if (179494 - 206825 == -27331)
							{
								if (num3 == 1)
								{
									if (89338 - 328287 != -238948)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (116406 - 480329 != -363922)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (18434 - 468121 == -449687)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (270069 - 115503 == 154566)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (81064 - 35192 != 45873)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (25670 - 122381 != -96710)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (21061 - 140167 != -119105)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (229711 - 42822 == 186889)
										{
											this.StartCoroutine_Auto(this.RPC_giantDrill(vector, vector2, num2));
											if (237566 - 84621 != 152946)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (8664 - 15967 != -7302)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (113039 - 152866 == -39827)
										{
											this.RPC_giantDrill_hit(vector, vector2, num2);
											if (291495 - 126988 == 164507)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 10)
								{
									if (13539 - 5470 == 8069)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (143681 - 74193 != 69489)
										{
											this.StartCoroutine_Auto(this.RPC_giantMissile(vector, vector2, num2));
											if (124330 - 481115 == -356785)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (104293 - 566781 == -462488)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (236979 - 245115 != -8135)
										{
											this.RPC_giantMissile_fire(vector, vector2, num2);
											if (163932 - 315005 != -151072)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (194819 - 112615 != 82205)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (292513 - 397439 == -104926)
										{
											this.RPC_giantMissile_hit(vector, vector2, num2);
											if (146830 - 227181 == -80351)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (239574 - 556857 != -317282)
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

	// Token: 0x0600552D RID: 21805 RVA: 0x00A56014 File Offset: 0x00A54214
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (120601 - 30318 != 90284)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (40231 - 26675 != 13557)
			{
				float runSpeed = this.mChar.runSpeed;
				if (198188 - 110802 != 87387)
				{
					Vector3 a = default(Vector3);
					if (232778 - 353465 != -120686)
					{
						Vector3 vector = Vector3.zero;
						if (9021 - 508895 == -499874)
						{
							float num2 = (float)0;
							if (224014 - 104628 != 119387)
							{
								if (this.mChar.isMine)
								{
									if (254825 - 82888 != 171937)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (112666 - 84775 == 27892)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (219453 - 582739 != -363286)
										{
											continue;
										}
										a.y = (float)0;
										if (66969 - 377208 != -310239)
										{
											continue;
										}
										a = a.normalized;
										if (41545 - 131154 == -89608)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (113811 - 515662 == -401850)
										{
											continue;
										}
										vector = vector.normalized;
										if (69774 - 396027 == -326252)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (294769 - 343623 == -48853)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (11530 - 431585 != -420055)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (276147 - 199981 != 76166)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (45515 - 537740 != -492225)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (256594 - 174103 == 82492)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (147098 - 23271 != 123827)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (296508 - 415318 == -118809)
														{
															continue;
														}
														this.animation.Play("run");
														if (225643 - 54134 != 171509)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (225528 - 238928 != -13399)
														{
															goto IL_964;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (116774 - 132029 != -15255)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (18355 - 156611 != -138256)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (92433 - 35046 != 57387)
											{
												continue;
											}
											num = (float)0;
											if (127064 - 75741 != 51323)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (133667 - 268828 != -135161)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (115920 - 338662 != -222742)
										{
											continue;
										}
									}
									IL_964:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (27677 - 108715 == -81037)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (283624 - 48173 == 235452)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (256192 - 68375 == 187818)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (189853 - 321596 == -131742)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (181599 - 95160 != 86439)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (239423 - 526794 == -287370)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (172472 - 95819 == 76654)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (151589 - 288715 != -137126)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (93455 - 49151 == 44305)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (215201 - 13053 == 202149)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (298459 - 197363 != 101096)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (147994 - 594127 != -446133)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (76625 - 264841 == -188215)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (30783 - 179307 == -148523)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (153810 - 449755 != -295945)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (65903 - 449929 != -384026)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (214357 - 246560 == -32202)
												{
													continue;
												}
												num = (float)0;
												if (232923 - 98181 == 134743)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (163620 - 213607 != -49987)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (77107 - 113316 == -36208)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (77550 - 228444 == -150893)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (252953 - 599841 != -346888)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (122579 - 257064 == -134484)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (241593 - 246676 != -5083)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (153411 - 24227 == 129185)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (74312 - 578820 != -504508)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (237752 - 431590 == -193837)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (276886 - 96271 != 180615)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (280433 - 123496 != 156937)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (210603 - 115058 != 95545)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (121505 - 256807 != -135302)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (36262 - 8176 != 28086)
											{
												continue;
											}
											num = (float)0;
											if (31447 - 321344 != -289897)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (107725 - 560426 == -452700)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (178373 - 402551 != -224178)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (222269 - 349237 != -126968)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (78731 - 387568 == -308836)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (22868 - 97144 != -74275)
								{
									this.mChar.moveSpeed = num;
									if (14031 - 10854 != 3178)
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

	// Token: 0x0600552E RID: 21806 RVA: 0x00A56B78 File Offset: 0x00A54D78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (190027 - 414137 != -224109)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (68424 - 510404 != -441979)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (270065 - 450450 == -180385)
				{
					Vector3 vector = a - this.transform.position;
					if (217880 - 586277 != -368396)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (120249 - 434060 == -313811)
						{
							if (89835 - 458652 != -368816)
							{
								if (gameObject)
								{
									if (272704 - 533971 != -261267)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (150953 - 453684 != -302731)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (172962 - 342045 != -169083)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (50420 - 290548 != -240128)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (152223 - 371674 != -219450)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
									if (165891 - 80429 != 85463)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (173442 - 237491 != -64048)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
											if (81038 - 508893 == -427855)
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

	// Token: 0x0600552F RID: 21807 RVA: 0x00A56E0C File Offset: 0x00A5500C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (120039 - 583254 != -463214)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (138155 - 252505 == -114350)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (217904 - 544784 != -326879)
				{
					Vector3 vector = a - this.transform.position;
					if (255163 - 565092 != -309928)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (52735 - 72600 == -19865)
						{
							if (250748 - 588310 != -337561)
							{
								if (gameObject)
								{
									if (46611 - 124671 == -78059)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (77576 - 204499 != -126923)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (97136 - 314036 != -216900)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (272368 - 384567 != -112199)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("drill") != (float)0)
								{
									if (134006 - 460529 == -326523)
									{
										Camera.main.SendMessage("newGameMessage", "GallonDrill is not ready");
										if (203633 - 36069 == 167564)
										{
											break;
										}
									}
								}
								else
								{
									this.StartCoroutine_Auto(this.RPC_giantDrill(this.transform.position, vector, 0));
									if (131458 - 584206 != -452747)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (171200 - 333079 == -161879)
										{
											this.ActionEvent("RPC_giantDrill", this.transform.position, vector, 0);
											if (168840 - 433908 != -265067)
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

	// Token: 0x06005530 RID: 21808 RVA: 0x00A570D4 File Offset: 0x00A552D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06005531 RID: 21809 RVA: 0x00A570D8 File Offset: 0x00A552D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GiantGallonBot.$RPC_nAttack$34524(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005532 RID: 21810 RVA: 0x00A570E8 File Offset: 0x00A552E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (7325 - 573664 != -566338)
		{
		}
		for (;;)
		{
			if (this.nAttack_giantHit)
			{
				if (118969 - 227721 == -108752)
				{
					UnityEngine.Object.Instantiate(this.nAttack_giantHit, hitPos, Quaternion.LookRotation(hitDir));
					if (46783 - 249787 == -203004)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_giantHit effect");
				if (159732 - 565138 != -405405)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005533 RID: 21811 RVA: 0x00A571A0 File Offset: 0x00A553A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_giantDrill(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GiantGallonBot.$RPC_giantDrill$34537(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005534 RID: 21812 RVA: 0x00A571B0 File Offset: 0x00A553B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_giantDrill_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (172255 - 441121 != -268865)
		{
		}
		for (;;)
		{
			if (this.giantDrill_hit)
			{
				if (66425 - 161367 == -94942)
				{
					UnityEngine.Object.Instantiate(this.giantDrill_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (44253 - 252389 != -208135)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find giantDrill_hit effect");
				if (292034 - 459639 == -167605)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005535 RID: 21813 RVA: 0x00A57268 File Offset: 0x00A55468
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_giantMissile(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GiantGallonBot.$RPC_giantMissile$34550(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005536 RID: 21814 RVA: 0x00A57278 File Offset: 0x00A55478
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_giantMissile_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (65701 - 27780 != 37921)
		{
		}
		for (;;)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.missile_fire, firePos, Quaternion.LookRotation(fireDir));
			if (299518 - 153081 != 146438)
			{
				ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
				if (9183 - 186181 == -176998)
				{
					projectileControl.Init(this.mChar.ActorNr);
					if (50674 - 367898 == -317224)
					{
						projectileControl.life = (float)5 * this.mChar.rangeMod;
						if (142126 - 383304 == -241178)
						{
							GameObject gameObject2 = null;
							if (111904 - 239703 == -127799)
							{
								if (tID != 0)
								{
									if (19262 - 378345 != -359083)
									{
										continue;
									}
									if (tID != this.mChar.ActorNr)
									{
										if (136369 - 62764 != 73605)
										{
											continue;
										}
										object obj2;
										object obj = obj2 = PhotonClient.ActorNrList[tID];
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										gameObject2 = (GameObject)obj2;
										if (198126 - 111804 != 86322)
										{
											continue;
										}
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (55750 - 31262 != 24489)
								{
									GallonBot_missile gallonBot_missile = (GallonBot_missile)gameObject.GetComponent(typeof(GallonBot_missile));
									if (46932 - 338237 == -291305)
									{
										gallonBot_missile.mTarget = gameObject2;
										if (17084 - 157148 != -140063)
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

	// Token: 0x06005537 RID: 21815 RVA: 0x00A57494 File Offset: 0x00A55694
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_giantMissile_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.missile_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06005538 RID: 21816 RVA: 0x00A574B0 File Offset: 0x00A556B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new GiantGallonBot.$RPC_ko$34565(nArray, this).GetEnumerator();
	}

	// Token: 0x06005539 RID: 21817 RVA: 0x00A574C0 File Offset: 0x00A556C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new GiantGallonBot.$RPC_dead$34572(nArray, this).GetEnumerator();
	}

	// Token: 0x0600553A RID: 21818 RVA: 0x00A574D0 File Offset: 0x00A556D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600553B RID: 21819 RVA: 0x00A574D4 File Offset: 0x00A556D4
	internal static bool p7NusO51TfEQtcWZtlKm()
	{
		return true;
	}

	// Token: 0x0600553C RID: 21820 RVA: 0x00A574D8 File Offset: 0x00A556D8
	internal static bool Fdaurv513oCOcFm8XHL3()
	{
		return false;
	}

	// Token: 0x04005E32 RID: 24114
	public CharacterControl mChar;

	// Token: 0x04005E33 RID: 24115
	public AudioClip nAttack_fx;

	// Token: 0x04005E34 RID: 24116
	public GameObject nAttack_giantHit;

	// Token: 0x04005E35 RID: 24117
	public GameObject giantDrill;

	// Token: 0x04005E36 RID: 24118
	public GameObject giantDrill_hit;

	// Token: 0x04005E37 RID: 24119
	public GameObject missile_fire;

	// Token: 0x04005E38 RID: 24120
	public GameObject missile_hit;

	// Token: 0x02000EAD RID: 3757
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$34524 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600553D RID: 21821 RVA: 0x00A574DC File Offset: 0x00A556DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$34524(Vector3 mPos, Vector3 tDir, GiantGallonBot self_)
		{
			if (121594 - 390804 != -269210)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (260112 - 411678 != -151565)
				{
					base..ctor();
					if (35857 - 264836 == -228979)
					{
						this.$mPos$34534 = mPos;
						if (143306 - 405350 == -262044)
						{
							this.$tDir$34535 = tDir;
							if (139214 - 156254 != -17039)
							{
								this.$self_$34536 = self_;
								if (180710 - 418892 != -238181)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600553E RID: 21822 RVA: 0x00A575B8 File Offset: 0x00A557B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GiantGallonBot.$RPC_nAttack$34524.$(this.$mPos$34534, this.$tDir$34535, this.$self_$34536);
		}

		// Token: 0x0600553F RID: 21823 RVA: 0x00A575D4 File Offset: 0x00A557D4
		internal static bool F87vnV51XuvqZVnwEYZ2()
		{
			return true;
		}

		// Token: 0x06005540 RID: 21824 RVA: 0x00A575D8 File Offset: 0x00A557D8
		internal static bool hSAmoB51Q0sSHyMiWl9V()
		{
			return false;
		}

		// Token: 0x04005E39 RID: 24121
		internal Vector3 $mPos$34534;

		// Token: 0x04005E3A RID: 24122
		internal Vector3 $tDir$34535;

		// Token: 0x04005E3B RID: 24123
		internal GiantGallonBot $self_$34536;

		// Token: 0x02000EAE RID: 3758
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005541 RID: 21825 RVA: 0x00A575DC File Offset: 0x00A557DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GiantGallonBot self_)
			{
				if (233676 - 519728 != -286051)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221729 - 151984 != 69746)
					{
						base..ctor();
						if (224957 - 409863 == -184906)
						{
							this.$mPos$34531 = mPos;
							if (48059 - 81451 != -33391)
							{
								this.$tDir$34532 = tDir;
								if (168305 - 415453 == -247148)
								{
									this.$self_$34533 = self_;
									if (31597 - 231518 == -199921)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005542 RID: 21826 RVA: 0x00A576B8 File Offset: 0x00A558B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (107336 - 453775 != -346438)
				{
				}
				for (;;)
				{
					IL_186:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A88;
					case 2:
						if (this.$self_$34533.mChar.actionState != "attack")
						{
							goto IL_51F;
						}
						if (173334 - 545075 != -371741)
						{
							continue;
						}
						if (this.$self_$34533.mChar.myCommand != "nAttack")
						{
							if (132760 - 396785 != -264024)
							{
								goto Block_10;
							}
							continue;
						}
						else if (this.$self_$34533.nAttack_fx)
						{
							if (134256 - 178278 != -44022)
							{
								continue;
							}
							this.$self_$34533.audio.PlayOneShot(this.$self_$34533.nAttack_fx);
							if (96400 - 388903 != -292503)
							{
								continue;
							}
							goto IL_88B;
						}
						else
						{
							Debug.LogError("Cannot find nAttack_fx effect");
							if (198343 - 553229 != -354885)
							{
								goto Block_55;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34533.mChar.actionState != "attack")
						{
							goto IL_43C;
						}
						if (143472 - 498377 == -354904)
						{
							continue;
						}
						if (this.$self_$34533.mChar.myCommand != "nAttack")
						{
							if (183552 - 353080 != -169527)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							this.$hitLayer$34525 = 130816 - (1 << this.$self_$34533.gameObject.layer);
							if (113391 - 565444 == -452052)
							{
								continue;
							}
							this.$hitList$34526 = null;
							if (51946 - 206723 == -154776)
							{
								continue;
							}
							this.$hitPos$34527 = default(Vector3);
							if (274378 - 208830 != 65548)
							{
								continue;
							}
							this.$i$34528 = 0;
							if (203183 - 189472 != 13711)
							{
								continue;
							}
							goto IL_416;
						}
						break;
					case 4:
						if (this.$self_$34533.mChar.actionState != "attack")
						{
							goto IL_640;
						}
						if (149469 - 456736 != -307267)
						{
							continue;
						}
						if (this.$self_$34533.mChar.myCommand != "nAttack")
						{
							if (185350 - 301210 != -115859)
							{
								goto Block_60;
							}
							continue;
						}
						else
						{
							if (this.$self_$34533.mChar.isMine)
							{
								if (178082 - 212650 != -34568)
								{
									continue;
								}
								this.$hitList$34526 = Damage.FindAreaTarget(this.$self_$34533.transform.position, 1.5f * this.$self_$34533.mChar.rangeMod, (float)3 * this.$self_$34533.mChar.rangeMod, this.$hitLayer$34525);
								if (229722 - 535816 != -306094)
								{
									continue;
								}
								this.$$iterator$10903$34530 = UnityRuntimeServices.GetEnumerator(this.$hitList$34526);
								if (97023 - 400827 == -303803)
								{
									continue;
								}
								while (this.$$iterator$10903$34530.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10903$34530.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$34529 = (GameObject)obj2;
									if (132189 - 289772 != -157583)
									{
										goto IL_186;
									}
									if (this.$self_$34533.mChar.hit(1, this.$hitObject$34529, (int)(0.5f * (float)this.$self_$34533.mChar.atk), 1, 0, (float)2 * this.$self_$34533.transform.forward) != 0)
									{
										if (295801 - 541522 != -245721)
										{
											goto IL_186;
										}
										this.$hitPos$34527 = this.$hitObject$34529.collider.ClosestPointOnBounds(this.$self_$34533.transform.position + this.$self_$34533.transform.TransformDirection((float)1, 1.5f, 2.5f));
										if (287795 - 221092 != 66703)
										{
											goto IL_186;
										}
										UnityRuntimeServices.Update(this.$$iterator$10903$34530, this.$hitObject$34529);
										if (15212 - 202386 != -187174)
										{
											goto IL_186;
										}
										this.$self_$34533.RPC_nAttack_hit(this.$hitPos$34527, this.$self_$34533.transform.forward, 0);
										if (228058 - 54883 != 173175)
										{
											goto IL_186;
										}
										if (PhotonClient.IsInitialized())
										{
											if (228904 - 528760 != -299856)
											{
												goto IL_186;
											}
											this.$self_$34533.ActionEvent("RPC_nAttack_hit", this.$hitPos$34527, this.$self_$34533.transform.forward, 0);
											if (270592 - 308184 != -37592)
											{
												goto IL_186;
											}
										}
										this.$self_$34533.mChar.sp = this.$self_$34533.mChar.sp + 1;
										if (73693 - 540161 != -466468)
										{
											goto IL_186;
										}
									}
								}
								if (5576 - 110887 != -105311)
								{
									continue;
								}
							}
							this.$i$34528++;
							if (72303 - 94930 != -22626)
							{
								goto IL_416;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$34533.mChar.actionState == "attack")
						{
							if (82879 - 472613 == -389733)
							{
								continue;
							}
							if (this.$self_$34533.mChar.myCommand == "nAttack")
							{
								if (276903 - 225492 == 51412)
								{
									continue;
								}
								this.$self_$34533.mChar.actionState = "standby";
								if (297043 - 162930 != 134113)
								{
									continue;
								}
								this.$self_$34533.mChar.actionTime = Time.time;
								if (215565 - 363199 != -147634)
								{
									continue;
								}
								this.$self_$34533.mChar.myCommand = "none";
								if (57379 - 73737 != -16358)
								{
									continue;
								}
								if (!this.$self_$34533.mChar.isMine)
								{
									if (286893 - 268464 == 18430)
									{
										continue;
									}
									this.$self_$34533.mChar.nPosition = this.$self_$34533.transform.position;
									if (64395 - 159590 != -95195)
									{
										continue;
									}
									this.$self_$34533.mChar.oPosition = this.$self_$34533.transform.position;
									if (237219 - 239349 == -2129)
									{
										continue;
									}
									this.$self_$34533.mChar.nDirection = this.$self_$34533.transform.forward;
									if (238602 - 248804 != -10202)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (172439 - 309417 != -136978)
						{
							continue;
						}
						goto IL_A88;
					default:
						if (95455 - 474596 != -379141)
						{
							continue;
						}
						break;
					}
					this.$self_$34533.mChar.actionState = "attack";
					if (143474 - 333091 != -189617)
					{
						continue;
					}
					this.$self_$34533.mChar.actionTime = Time.time;
					if (139299 - 295382 != -156083)
					{
						continue;
					}
					this.$self_$34533.mChar.myCommand = "nAttack";
					if (128912 - 554211 == -425298)
					{
						continue;
					}
					this.$self_$34533.mChar.addTimeOut("nAttack", (float)3);
					if (81180 - 77288 != 3892)
					{
						continue;
					}
					this.$self_$34533.transform.position = this.$mPos$34531;
					if (121333 - 43119 == 78215)
					{
						continue;
					}
					this.$self_$34533.transform.LookAt(this.$mPos$34531 + global::Math.vFlat(this.$tDir$34532));
					if (154091 - 397739 != -243648)
					{
						continue;
					}
					this.$self_$34533.animation.Play("nAttack");
					if (58756 - 224004 != -165248)
					{
						continue;
					}
					this.$self_$34533.animation.wrapMode = WrapMode.Once;
					if (57097 - 74324 == -17226)
					{
						continue;
					}
					this.$self_$34533.mChar.vMovement = this.$self_$34533.transform.forward;
					if (89523 - 423755 != -334232)
					{
						continue;
					}
					this.$self_$34533.mChar.moveSpeed = (float)0;
					if (4024 - 243985 != -239960)
					{
						goto Block_54;
					}
					continue;
					IL_416:
					if (this.$i$34528 < 2)
					{
						goto IL_810;
					}
					if (223124 - 51140 != 171985)
					{
						goto Block_28;
					}
				}
				Block_10:
				goto IL_51F;
				Block_28:
				return this.Yield(5, new WaitForSeconds(0.3f));
				IL_43C:
				goto IL_A88;
				IL_51F:
				IL_640:
				Block_43:
				goto IL_43C;
				IL_810:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_54:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_88B:
				Block_55:
				goto IL_9DF;
				Block_60:
				goto IL_640;
				IL_9DF:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_A88:
				return false;
			}

			// Token: 0x06005543 RID: 21827 RVA: 0x00A58160 File Offset: 0x00A56360
			internal static bool Y9cgsh51kLcJspASubPN()
			{
				return true;
			}

			// Token: 0x06005544 RID: 21828 RVA: 0x00A58164 File Offset: 0x00A56364
			internal static bool Fy3wOX51GOmKGMqpXDwO()
			{
				return false;
			}

			// Token: 0x04005E3C RID: 24124
			internal int $hitLayer$34525;

			// Token: 0x04005E3D RID: 24125
			internal UnityScript.Lang.Array $hitList$34526;

			// Token: 0x04005E3E RID: 24126
			internal Vector3 $hitPos$34527;

			// Token: 0x04005E3F RID: 24127
			internal int $i$34528;

			// Token: 0x04005E40 RID: 24128
			internal GameObject $hitObject$34529;

			// Token: 0x04005E41 RID: 24129
			internal IEnumerator $$iterator$10903$34530;

			// Token: 0x04005E42 RID: 24130
			internal Vector3 $mPos$34531;

			// Token: 0x04005E43 RID: 24131
			internal Vector3 $tDir$34532;

			// Token: 0x04005E44 RID: 24132
			internal GiantGallonBot $self_$34533;
		}
	}

	// Token: 0x02000EAF RID: 3759
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_giantDrill$34537 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005545 RID: 21829 RVA: 0x00A58168 File Offset: 0x00A56368
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_giantDrill$34537(Vector3 mPos, Vector3 tDir, GiantGallonBot self_)
		{
			if (180385 - 166278 != 14108)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (84732 - 447399 != -362666)
				{
					base..ctor();
					if (190197 - 313604 != -123406)
					{
						this.$mPos$34547 = mPos;
						if (72319 - 574177 != -501857)
						{
							this.$tDir$34548 = tDir;
							if (196368 - 109914 != 86455)
							{
								this.$self_$34549 = self_;
								if (61002 - 56573 != 4430)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x00A58244 File Offset: 0x00A56444
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GiantGallonBot.$RPC_giantDrill$34537.$(this.$mPos$34547, this.$tDir$34548, this.$self_$34549);
		}

		// Token: 0x06005547 RID: 21831 RVA: 0x00A58260 File Offset: 0x00A56460
		internal static bool nEI7Uc51HaNrnotU3G8N()
		{
			return true;
		}

		// Token: 0x06005548 RID: 21832 RVA: 0x00A58264 File Offset: 0x00A56464
		internal static bool kvyJXS51WaocxrMcX1im()
		{
			return false;
		}

		// Token: 0x04005E45 RID: 24133
		internal Vector3 $mPos$34547;

		// Token: 0x04005E46 RID: 24134
		internal Vector3 $tDir$34548;

		// Token: 0x04005E47 RID: 24135
		internal GiantGallonBot $self_$34549;

		// Token: 0x02000EB0 RID: 3760
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005549 RID: 21833 RVA: 0x00A58268 File Offset: 0x00A56468
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GiantGallonBot self_)
			{
				if (5218 - 6280 != -1061)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (164830 - 96561 != 68270)
					{
						base..ctor();
						if (131362 - 459105 != -327742)
						{
							this.$mPos$34544 = mPos;
							if (46933 - 366018 != -319084)
							{
								this.$tDir$34545 = tDir;
								if (70733 - 270132 != -199398)
								{
									this.$self_$34546 = self_;
									if (213903 - 200263 == 13640)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600554A RID: 21834 RVA: 0x00A58344 File Offset: 0x00A56544
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284394 - 192188 != 92207)
				{
				}
				for (;;)
				{
					IL_2ED:
					switch (this._state)
					{
					case 0:
						goto IL_A16;
					case 1:
						goto IL_A45;
					case 2:
						if (this.$self_$34546.mChar.actionState != "attack")
						{
							goto IL_67C;
						}
						if (224406 - 536903 != -312497)
						{
							continue;
						}
						if (this.$self_$34546.mChar.myCommand != "giantDrill")
						{
							if (287757 - 432569 != -144812)
							{
								continue;
							}
							goto IL_67C;
						}
						else
						{
							this.$self_$34546.mChar.moveSpeed = (float)0;
							if (238248 - 200888 != 37360)
							{
								continue;
							}
							this.$i$34538 = 0;
							if (254575 - 227253 == 27323)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$34546.mChar.actionState != "attack")
						{
							goto IL_897;
						}
						if (262443 - 526801 != -264358)
						{
							continue;
						}
						if (this.$self_$34546.mChar.myCommand != "giantDrill")
						{
							if (293144 - 431972 != -138827)
							{
								goto Block_50;
							}
							continue;
						}
						else
						{
							if (this.$self_$34546.mChar.isMine)
							{
								if (70706 - 575088 == -504381)
								{
									continue;
								}
								this.$hitLayer$34539 = 130816 - (1 << this.$self_$34546.gameObject.layer);
								if (198684 - 137277 == 61408)
								{
									continue;
								}
								this.$hitList$34540 = Damage.FindRecTarget(this.$self_$34546.transform.position, this.$self_$34546.transform.forward, (float)2 * this.$self_$34546.mChar.rangeMod, (float)2 * this.$self_$34546.mChar.rangeMod, (float)8 * this.$self_$34546.mChar.rangeMod, (float)4 * this.$self_$34546.mChar.rangeMod, this.$hitLayer$34539);
								if (49033 - 509200 == -460166)
								{
									continue;
								}
								this.$$iterator$10904$34543 = UnityRuntimeServices.GetEnumerator(this.$hitList$34540);
								if (282187 - 232589 == 49599)
								{
									continue;
								}
								while (this.$$iterator$10904$34543.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10904$34543.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$34541 = (GameObject)obj2;
									if (112740 - 577264 != -464524)
									{
										goto IL_2ED;
									}
									if (this.$self_$34546.mChar.hit(2, this.$hitObject$34541, (int)(0.5f * (float)this.$self_$34546.mChar.atk + (float)this.$self_$34546.mChar.talAdjust(15)), 2, 0, (float)2 * this.$self_$34546.transform.forward) != 0)
									{
										if (224606 - 294803 == -70196)
										{
											goto IL_2ED;
										}
										this.$hitPos$34542 = this.$hitObject$34541.collider.ClosestPointOnBounds(this.$self_$34546.transform.position + this.$self_$34546.transform.TransformDirection((float)1, 1.5f, 2.5f));
										if (170676 - 228066 != -57390)
										{
											goto IL_2ED;
										}
										UnityRuntimeServices.Update(this.$$iterator$10904$34543, this.$hitObject$34541);
										if (43817 - 342499 == -298681)
										{
											goto IL_2ED;
										}
										this.$self_$34546.RPC_giantDrill_hit(this.$hitPos$34542, this.$self_$34546.transform.forward, 0);
										if (86707 - 182644 != -95937)
										{
											goto IL_2ED;
										}
										if (PhotonClient.IsInitialized())
										{
											if (203332 - 35447 != 167885)
											{
												goto IL_2ED;
											}
											this.$self_$34546.ActionEvent("RPC_giantDrill_hit", this.$hitPos$34542, this.$self_$34546.transform.forward, 0);
											if (223122 - 15284 == 207839)
											{
												goto IL_2ED;
											}
										}
										this.$self_$34546.mChar.sp = this.$self_$34546.mChar.sp + 1;
										if (202067 - 142440 != 59627)
										{
											goto IL_2ED;
										}
									}
								}
								if (225372 - 73145 == 152228)
								{
									continue;
								}
							}
							this.$i$34538++;
							if (153964 - 469057 == -315092)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$34546.mChar.actionState == "attack")
						{
							if (530 - 302076 != -301546)
							{
								continue;
							}
							if (this.$self_$34546.mChar.myCommand == "giantDrill")
							{
								if (39382 - 448111 != -408729)
								{
									continue;
								}
								this.$self_$34546.mChar.actionState = "standby";
								if (157938 - 299790 == -141851)
								{
									continue;
								}
								this.$self_$34546.mChar.actionTime = Time.time;
								if (171098 - 86342 == 84757)
								{
									continue;
								}
								this.$self_$34546.mChar.myCommand = "none";
								if (145372 - 541304 == -395931)
								{
									continue;
								}
								if (!this.$self_$34546.mChar.isMine)
								{
									if (215098 - 380608 == -165509)
									{
										continue;
									}
									this.$self_$34546.mChar.nPosition = this.$self_$34546.transform.position;
									if (166721 - 221756 != -55035)
									{
										continue;
									}
									this.$self_$34546.mChar.oPosition = this.$self_$34546.transform.position;
									if (40187 - 323893 != -283706)
									{
										continue;
									}
									this.$self_$34546.mChar.nDirection = this.$self_$34546.transform.forward;
									if (38951 - 198934 == -159982)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (49718 - 531399 != -481680)
						{
							goto Block_15;
						}
						continue;
					default:
						if (248442 - 188787 != 59656)
						{
							goto IL_A16;
						}
						continue;
					}
					if (this.$i$34538 < 4)
					{
						goto IL_7A0;
					}
					if (278382 - 296874 != -18491)
					{
						goto Block_32;
					}
					continue;
					IL_A16:
					this.$self_$34546.mChar.actionState = "attack";
					if (133930 - 409233 != -275302)
					{
						this.$self_$34546.mChar.actionTime = Time.time;
						if (242395 - 564229 == -321834)
						{
							this.$self_$34546.mChar.myCommand = "giantDrill";
							if (158493 - 319507 == -161014)
							{
								this.$self_$34546.mChar.addTimeOut("drill", (float)15);
								if (81449 - 147302 == -65853)
								{
									this.$self_$34546.transform.position = this.$mPos$34544;
									if (263456 - 383551 != -120094)
									{
										this.$self_$34546.transform.LookAt(this.$mPos$34544 + global::Math.vFlat(this.$tDir$34545));
										if (25467 - 290884 != -265416)
										{
											this.$self_$34546.animation.Play("drill");
											if (73547 - 580456 == -506909)
											{
												this.$self_$34546.animation.wrapMode = WrapMode.Once;
												if (239151 - 538454 != -299302)
												{
													this.$self_$34546.mChar.vMovement = this.$self_$34546.transform.forward;
													if (58761 - 230554 != -171792)
													{
														this.$self_$34546.mChar.moveSpeed = (float)-1;
														if (265401 - 573479 != -308077)
														{
															if (this.$self_$34546.giantDrill)
															{
																if (137354 - 206549 != -69194)
																{
																	this.$self_$34546.mChar.createEffect(this.$self_$34546.giantDrill, this.$self_$34546.transform.position, this.$self_$34546.transform.rotation);
																	if (146731 - 383200 == -236469)
																	{
																		goto IL_326;
																	}
																}
															}
															else
															{
																Debug.LogError("Cannot find giantDrill effect");
																if (77212 - 343569 == -266357)
																{
																	goto IL_3C6;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_15:
				goto IL_A45;
				IL_326:
				IL_3C6:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_32:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_67C:
				goto IL_A45;
				IL_7A0:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_50:
				IL_897:
				IL_A45:
				return false;
			}

			// Token: 0x0600554B RID: 21835 RVA: 0x00A58DA8 File Offset: 0x00A56FA8
			internal static bool DmvLJO51A53JBP7sZNNo()
			{
				return true;
			}

			// Token: 0x0600554C RID: 21836 RVA: 0x00A58DAC File Offset: 0x00A56FAC
			internal static bool ajAK7251lhiPBbP5T6be()
			{
				return false;
			}

			// Token: 0x04005E48 RID: 24136
			internal int $i$34538;

			// Token: 0x04005E49 RID: 24137
			internal int $hitLayer$34539;

			// Token: 0x04005E4A RID: 24138
			internal UnityScript.Lang.Array $hitList$34540;

			// Token: 0x04005E4B RID: 24139
			internal GameObject $hitObject$34541;

			// Token: 0x04005E4C RID: 24140
			internal Vector3 $hitPos$34542;

			// Token: 0x04005E4D RID: 24141
			internal IEnumerator $$iterator$10904$34543;

			// Token: 0x04005E4E RID: 24142
			internal Vector3 $mPos$34544;

			// Token: 0x04005E4F RID: 24143
			internal Vector3 $tDir$34545;

			// Token: 0x04005E50 RID: 24144
			internal GiantGallonBot $self_$34546;
		}
	}

	// Token: 0x02000EB1 RID: 3761
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_giantMissile$34550 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600554D RID: 21837 RVA: 0x00A58DB0 File Offset: 0x00A56FB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_giantMissile$34550(Vector3 mPos, Vector3 tDir, GiantGallonBot self_)
		{
			if (261215 - 144079 != 117136)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (269786 - 8606 != 261181)
				{
					base..ctor();
					if (285092 - 396307 == -111215)
					{
						this.$mPos$34562 = mPos;
						if (248809 - 70155 == 178654)
						{
							this.$tDir$34563 = tDir;
							if (267130 - 444248 != -177117)
							{
								this.$self_$34564 = self_;
								if (209902 - 482034 == -272132)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600554E RID: 21838 RVA: 0x00A58E8C File Offset: 0x00A5708C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GiantGallonBot.$RPC_giantMissile$34550.$(this.$mPos$34562, this.$tDir$34563, this.$self_$34564);
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x00A58EA8 File Offset: 0x00A570A8
		internal static bool HXBm3O51yiJsTbdwycDY()
		{
			return true;
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x00A58EAC File Offset: 0x00A570AC
		internal static bool fPvxqY51SC3XjE3eMQFW()
		{
			return false;
		}

		// Token: 0x04005E51 RID: 24145
		internal Vector3 $mPos$34562;

		// Token: 0x04005E52 RID: 24146
		internal Vector3 $tDir$34563;

		// Token: 0x04005E53 RID: 24147
		internal GiantGallonBot $self_$34564;

		// Token: 0x02000EB2 RID: 3762
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005551 RID: 21841 RVA: 0x00A58EB0 File Offset: 0x00A570B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GiantGallonBot self_)
			{
				if (268593 - 46835 != 221758)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (136847 - 20547 != 116301)
					{
						base..ctor();
						if (267793 - 385651 == -117858)
						{
							this.$mPos$34559 = mPos;
							if (248479 - 45331 == 203148)
							{
								this.$tDir$34560 = tDir;
								if (39726 - 445046 == -405320)
								{
									this.$self_$34561 = self_;
									if (299448 - 555898 != -256449)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005552 RID: 21842 RVA: 0x00A58F8C File Offset: 0x00A5718C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (46494 - 178680 != -132186)
				{
				}
				for (;;)
				{
					IL_665:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_88D;
					case 2:
						if (this.$self_$34561.mChar.actionState != "attack")
						{
							goto IL_5F7;
						}
						if (134178 - 28746 == 105433)
						{
							continue;
						}
						if (this.$self_$34561.mChar.myCommand != "giantMissile")
						{
							if (48126 - 385986 != -337859)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34561.mChar.isMine)
							{
								goto IL_330;
							}
							if (59192 - 337770 != -278578)
							{
								continue;
							}
							this.$targetLayer$34551 = 130816 - (1 << this.$self_$34561.gameObject.layer);
							if (144004 - 221932 == -77927)
							{
								continue;
							}
							this.$targetList$34552 = Damage.RemoveDeadChar(Damage.FindAreaTarget(this.$self_$34561.transform.position, (float)24, (float)10, this.$targetLayer$34551));
							if (236520 - 380947 == -144426)
							{
								continue;
							}
							this.$i$34553 = 0;
							if (259768 - 417914 == -158145)
							{
								continue;
							}
							while (this.$i$34553 < 4)
							{
								this.$targetID$34554 = 0;
								if (101456 - 490570 == -389113)
								{
									goto IL_665;
								}
								if (this.$targetList$34552.length > 0)
								{
									if (160574 - 155626 == 4949)
									{
										goto IL_665;
									}
									object obj2;
									object obj = obj2 = this.$targetList$34552[UnityEngine.Random.Range(1, this.$targetList$34552.length) - 1];
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$tObject$34555 = (GameObject)obj2;
									if (236369 - 266113 != -29744)
									{
										goto IL_665;
									}
									if (this.$tObject$34555)
									{
										if (273459 - 441696 == -168236)
										{
											goto IL_665;
										}
										this.$tChar$34556 = (CharacterControl)this.$tObject$34555.GetComponent(typeof(CharacterControl));
										if (149203 - 165064 != -15861)
										{
											goto IL_665;
										}
									}
									if (this.$tChar$34556)
									{
										if (16380 - 531902 == -515521)
										{
											goto IL_665;
										}
										this.$targetID$34554 = this.$tChar$34556.ActorNr;
										if (226631 - 71304 != 155327)
										{
											goto IL_665;
										}
									}
								}
								this.$firePos$34557 = this.$self_$34561.transform.position + 1.5f * Vector3.up;
								if (92615 - 405158 == -312542)
								{
									goto IL_665;
								}
								this.$fireDir$34558 = global::Math.rotateH(this.$self_$34561.transform.forward, (float)(90 * this.$i$34553));
								if (159796 - 315915 != -156119)
								{
									goto IL_665;
								}
								this.$self_$34561.RPC_giantMissile_fire(this.$firePos$34557, this.$fireDir$34558, this.$targetID$34554);
								if (119972 - 114146 != 5826)
								{
									goto IL_665;
								}
								if (PhotonClient.IsInitialized())
								{
									if (58632 - 204819 != -146187)
									{
										goto IL_665;
									}
									this.$self_$34561.ActionEvent("RPC_giantMissile_fire", this.$firePos$34557, this.$fireDir$34558, this.$targetID$34554);
									if (299077 - 335732 != -36655)
									{
										goto IL_665;
									}
								}
								this.$i$34553++;
								if (135537 - 146675 != -11138)
								{
									goto IL_665;
								}
							}
							if (275593 - 518394 != -242800)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34561.mChar.actionState == "attack")
						{
							if (206156 - 92340 == 113817)
							{
								continue;
							}
							if (this.$self_$34561.mChar.myCommand == "giantMissile")
							{
								if (183322 - 261013 != -77691)
								{
									continue;
								}
								this.$self_$34561.mChar.actionState = "standby";
								if (59342 - 496998 == -437655)
								{
									continue;
								}
								this.$self_$34561.mChar.actionTime = Time.time;
								if (76443 - 261199 == -184755)
								{
									continue;
								}
								this.$self_$34561.mChar.myCommand = "none";
								if (252439 - 181799 != 70640)
								{
									continue;
								}
								if (!this.$self_$34561.mChar.isMine)
								{
									if (183462 - 62922 != 120540)
									{
										continue;
									}
									this.$self_$34561.mChar.nPosition = this.$self_$34561.transform.position;
									if (196752 - 176436 != 20316)
									{
										continue;
									}
									this.$self_$34561.mChar.oPosition = this.$self_$34561.transform.position;
									if (236098 - 161304 != 74794)
									{
										continue;
									}
									this.$self_$34561.mChar.nDirection = this.$self_$34561.transform.forward;
									if (166576 - 309126 == -142549)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (282252 - 201744 != 80509)
						{
							goto Block_47;
						}
						continue;
					default:
						if (28454 - 210903 == -182448)
						{
							continue;
						}
						break;
					}
					this.$self_$34561.mChar.actionState = "attack";
					if (29824 - 145394 == -115570)
					{
						this.$self_$34561.mChar.actionTime = Time.time;
						if (195876 - 90637 == 105239)
						{
							this.$self_$34561.mChar.myCommand = "giantMissile";
							if (259210 - 200437 != 58774)
							{
								this.$self_$34561.mChar.addTimeOut("giantMissile", this.$self_$34561.mChar.agiAdjust((float)60));
								if (92111 - 57714 != 34398)
								{
									this.$self_$34561.transform.position = this.$mPos$34559;
									if (111137 - 451322 != -340184)
									{
										this.$self_$34561.transform.LookAt(this.$mPos$34559 + global::Math.vFlat(this.$tDir$34560));
										if (105375 - 426014 != -320638)
										{
											this.$self_$34561.animation.Play("missile");
											if (85699 - 178493 == -92794)
											{
												this.$self_$34561.animation.wrapMode = WrapMode.Once;
												if (201666 - 559776 == -358110)
												{
													this.$self_$34561.mChar.vMovement = this.$self_$34561.transform.forward;
													if (144107 - 232514 == -88407)
													{
														this.$self_$34561.mChar.moveSpeed = (float)0;
														if (131258 - 481927 != -350668)
														{
															goto Block_52;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_330:
				return this.Yield(3, new WaitForSeconds(0.9f));
				Block_26:
				goto IL_330;
				IL_5F7:
				Block_44:
				Block_47:
				goto IL_88D;
				Block_52:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_88D:
				return false;
			}

			// Token: 0x06005553 RID: 21843 RVA: 0x00A59838 File Offset: 0x00A57A38
			internal static bool uBtvIF51oG9GYwAst9sH()
			{
				return true;
			}

			// Token: 0x06005554 RID: 21844 RVA: 0x00A5983C File Offset: 0x00A57A3C
			internal static bool G6jJm251EZBu9s8iCFRa()
			{
				return false;
			}

			// Token: 0x04005E54 RID: 24148
			internal int $targetLayer$34551;

			// Token: 0x04005E55 RID: 24149
			internal UnityScript.Lang.Array $targetList$34552;

			// Token: 0x04005E56 RID: 24150
			internal int $i$34553;

			// Token: 0x04005E57 RID: 24151
			internal int $targetID$34554;

			// Token: 0x04005E58 RID: 24152
			internal GameObject $tObject$34555;

			// Token: 0x04005E59 RID: 24153
			internal CharacterControl $tChar$34556;

			// Token: 0x04005E5A RID: 24154
			internal Vector3 $firePos$34557;

			// Token: 0x04005E5B RID: 24155
			internal Vector3 $fireDir$34558;

			// Token: 0x04005E5C RID: 24156
			internal Vector3 $mPos$34559;

			// Token: 0x04005E5D RID: 24157
			internal Vector3 $tDir$34560;

			// Token: 0x04005E5E RID: 24158
			internal GiantGallonBot $self_$34561;
		}
	}

	// Token: 0x02000EB3 RID: 3763
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$34565 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005555 RID: 21845 RVA: 0x00A59840 File Offset: 0x00A57A40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$34565(UnityScript.Lang.Array nArray, GiantGallonBot self_)
		{
			if (180749 - 317864 != -137114)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (149254 - 33904 != 115351)
				{
					base..ctor();
					if (242470 - 209609 != 32862)
					{
						this.$nArray$34570 = nArray;
						if (48149 - 385264 == -337115)
						{
							this.$self_$34571 = self_;
							if (125885 - 563421 == -437536)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005556 RID: 21846 RVA: 0x00A598FC File Offset: 0x00A57AFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GiantGallonBot.$RPC_ko$34565.$(this.$nArray$34570, this.$self_$34571);
		}

		// Token: 0x06005557 RID: 21847 RVA: 0x00A59910 File Offset: 0x00A57B10
		internal static bool ldQGa85122s4NG2af9MG()
		{
			return true;
		}

		// Token: 0x06005558 RID: 21848 RVA: 0x00A59914 File Offset: 0x00A57B14
		internal static bool PEXEwx518whCfqyp9Kcu()
		{
			return false;
		}

		// Token: 0x04005E5F RID: 24159
		internal UnityScript.Lang.Array $nArray$34570;

		// Token: 0x04005E60 RID: 24160
		internal GiantGallonBot $self_$34571;

		// Token: 0x02000EB4 RID: 3764
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005559 RID: 21849 RVA: 0x00A59918 File Offset: 0x00A57B18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, GiantGallonBot self_)
			{
				if (298491 - 183186 != 115306)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (78648 - 34503 == 44145)
					{
						base..ctor();
						if (298615 - 199877 != 98739)
						{
							this.$nArray$34568 = nArray;
							if (218738 - 471781 == -253043)
							{
								this.$self_$34569 = self_;
								if (113637 - 362173 == -248536)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600555A RID: 21850 RVA: 0x00A599D4 File Offset: 0x00A57BD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229620 - 165539 != 64081)
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
						if (this.$self_$34569.mChar.actionState != "ko")
						{
							if (103961 - 238913 != -134951)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$self_$34569.animation.Play("getUp");
							if (271990 - 10814 != 261176)
							{
								continue;
							}
							this.$self_$34569.animation.wrapMode = WrapMode.Once;
							if (252213 - 580697 != -328483)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34569.mChar.actionState != "ko")
						{
							if (65522 - 91475 != -25952)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$self_$34569.mChar.actionState = "standby";
							if (221599 - 468576 != -246977)
							{
								continue;
							}
							this.$self_$34569.mChar.actionTime = Time.time;
							if (99441 - 77040 != 22401)
							{
								continue;
							}
							this.$self_$34569.mChar.myCommand = "none";
							if (174317 - 61862 != 112455)
							{
								continue;
							}
							this.$self_$34569.mChar.ko = this.$self_$34569.mChar.mko;
							if (253512 - 179082 != 74430)
							{
								continue;
							}
							this.YieldDefault(1);
							if (158919 - 587937 != -429017)
							{
								goto IL_48C;
							}
							continue;
						}
						break;
					default:
						if (192604 - 554828 != -362224)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34569.mChar.actionState == "ko")
					{
						goto IL_354;
					}
					if (185112 - 529359 == -344247)
					{
						if (this.$self_$34569.mChar.actionState == "dead")
						{
							if (256569 - 567366 == -310797)
							{
								goto IL_354;
							}
						}
						else
						{
							this.$mPos$34566 = (Vector3)this.$nArray$34568[0];
							if (112119 - 16126 == 95993)
							{
								this.$mDir$34567 = (Vector3)this.$nArray$34568[1];
								if (137465 - 180997 != -43531)
								{
									this.$self_$34569.mChar.ko = 0;
									if (95928 - 178047 != -82118)
									{
										this.$self_$34569.mChar.actionState = "ko";
										if (184804 - 42786 == 142018)
										{
											this.$self_$34569.mChar.actionTime = Time.time;
											if (45895 - 80206 == -34311)
											{
												this.$self_$34569.mChar.myCommand = "none";
												if (122930 - 74157 != 48774)
												{
													this.$self_$34569.mChar.vMovement = Vector3.zero;
													if (72694 - 230958 == -158264)
													{
														this.$self_$34569.mChar.moveSpeed = (float)0;
														if (78592 - 149247 != -70654)
														{
															this.$self_$34569.animation.Play("ko");
															if (291133 - 144290 != 146844)
															{
																this.$self_$34569.animation.wrapMode = WrapMode.Once;
																if (18775 - 340242 != -321466)
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
				Block_13:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_18:
				goto IL_48C;
				Block_19:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_354:
				Block_25:
				IL_48C:
				return false;
			}

			// Token: 0x0600555B RID: 21851 RVA: 0x00A59E80 File Offset: 0x00A58080
			internal static bool SVvseD51ZZXbopyIZYSu()
			{
				return true;
			}

			// Token: 0x0600555C RID: 21852 RVA: 0x00A59E84 File Offset: 0x00A58084
			internal static bool tPwqYP51CqsSZRK3eSKu()
			{
				return false;
			}

			// Token: 0x04005E61 RID: 24161
			internal Vector3 $mPos$34566;

			// Token: 0x04005E62 RID: 24162
			internal Vector3 $mDir$34567;

			// Token: 0x04005E63 RID: 24163
			internal UnityScript.Lang.Array $nArray$34568;

			// Token: 0x04005E64 RID: 24164
			internal GiantGallonBot $self_$34569;
		}
	}

	// Token: 0x02000EB5 RID: 3765
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$34572 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600555D RID: 21853 RVA: 0x00A59E88 File Offset: 0x00A58088
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$34572(UnityScript.Lang.Array nArray, GiantGallonBot self_)
		{
			if (214920 - 482346 != -267426)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (165183 - 26626 != 138558)
				{
					base..ctor();
					if (78072 - 247413 == -169341)
					{
						this.$nArray$34577 = nArray;
						if (87874 - 568862 == -480988)
						{
							this.$self_$34578 = self_;
							if (211295 - 70036 != 141260)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600555E RID: 21854 RVA: 0x00A59F44 File Offset: 0x00A58144
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GiantGallonBot.$RPC_dead$34572.$(this.$nArray$34577, this.$self_$34578);
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x00A59F58 File Offset: 0x00A58158
		internal static bool aMSdRN51Lwg7vRpLwLFG()
		{
			return true;
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x00A59F5C File Offset: 0x00A5815C
		internal static bool Q3hy3D51O1NaBFg7VUvB()
		{
			return false;
		}

		// Token: 0x04005E65 RID: 24165
		internal UnityScript.Lang.Array $nArray$34577;

		// Token: 0x04005E66 RID: 24166
		internal GiantGallonBot $self_$34578;

		// Token: 0x02000EB6 RID: 3766
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005561 RID: 21857 RVA: 0x00A59F60 File Offset: 0x00A58160
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, GiantGallonBot self_)
			{
				if (286815 - 231854 != 54962)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221142 - 430693 == -209551)
					{
						base..ctor();
						if (72251 - 100243 == -27992)
						{
							this.$nArray$34575 = nArray;
							if (161302 - 335000 == -173698)
							{
								this.$self_$34576 = self_;
								if (216757 - 59498 == 157259)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005562 RID: 21858 RVA: 0x00A5A01C File Offset: 0x00A5821C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (60127 - 193218 != -133090)
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
						if (this.$self_$34576.mChar.actionState != "dead")
						{
							if (239472 - 97130 != 142342)
							{
								continue;
							}
							goto IL_3A0;
						}
						else
						{
							if (!this.$self_$34576.mChar.isPlayer)
							{
								if (173213 - 350071 == -176857)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$34576.gameObject);
								if (146434 - 355963 == -209528)
								{
									continue;
								}
							}
							else if (this.$self_$34576.mChar.isMine)
							{
								if (281384 - 86483 != 194901)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$34576.gameObject);
								if (85842 - 195764 != -109922)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (136314 - 135189 != 1126)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					default:
						if (129238 - 102878 != 26360)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34576.mChar.actionState == "dead")
					{
						if (222669 - 347037 == -124368)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$34573 = (Vector3)this.$nArray$34575[0];
						if (213800 - 70869 == 142931)
						{
							this.$myDirection$34574 = (Vector3)this.$nArray$34575[1];
							if (216585 - 310735 != -94149)
							{
								this.$self_$34576.transform.position = this.$myPosition$34573;
								if (158010 - 413284 != -255273)
								{
									this.$self_$34576.transform.LookAt(this.$myPosition$34573 + this.$myDirection$34574);
									if (299043 - 501611 == -202568)
									{
										this.$self_$34576.mChar.hp = 0;
										if (264991 - 248580 == 16411)
										{
											this.$self_$34576.mChar.actionState = "dead";
											if (134042 - 338015 == -203973)
											{
												this.$self_$34576.mChar.actionTime = Time.time;
												if (11421 - 252208 == -240787)
												{
													this.$self_$34576.mChar.myCommand = "none";
													if (265076 - 42792 != 222285)
													{
														this.$self_$34576.mChar.vMovement = Vector3.zero;
														if (35761 - 249067 == -213306)
														{
															this.$self_$34576.mChar.moveSpeed = (float)0;
															if (185633 - 375676 != -190042)
															{
																this.$self_$34576.animation.Rewind();
																if (117723 - 438226 == -320503)
																{
																	this.$self_$34576.animation.Play("ko");
																	if (222064 - 264660 != -42595)
																	{
																		this.$self_$34576.animation.wrapMode = WrapMode.Once;
																		if (262942 - 396029 != -133086)
																		{
																			goto Block_12;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_42F;
				Block_12:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_16:
				IL_3A0:
				IL_42F:
				return false;
			}

			// Token: 0x06005563 RID: 21859 RVA: 0x00A5A46C File Offset: 0x00A5866C
			internal static bool Qm56ix51mZdPvbVnFovS()
			{
				return true;
			}

			// Token: 0x06005564 RID: 21860 RVA: 0x00A5A470 File Offset: 0x00A58670
			internal static bool o270mm51FoNgwEYXq32R()
			{
				return false;
			}

			// Token: 0x04005E67 RID: 24167
			internal Vector3 $myPosition$34573;

			// Token: 0x04005E68 RID: 24168
			internal Vector3 $myDirection$34574;

			// Token: 0x04005E69 RID: 24169
			internal UnityScript.Lang.Array $nArray$34575;

			// Token: 0x04005E6A RID: 24170
			internal GiantGallonBot $self_$34576;
		}
	}
}
