using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200042B RID: 1067
[Serializable]
public class FireGod_gm : MonoBehaviour
{
	// Token: 0x060018E7 RID: 6375 RVA: 0x0028B5B0 File Offset: 0x002897B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FireGod_gm()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060018E8 RID: 6376 RVA: 0x0028B5C0 File Offset: 0x002897C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (84362 - 477375 != -393012)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (264269 - 180078 != 84192)
			{
				this.mChar.actionState = "standby";
				if (46355 - 499270 == -452915)
				{
					this.mChar.actionTime = Time.time;
					if (200677 - 595558 != -394880)
					{
						this.mChar.myCommand = "none";
						if (174783 - 477117 != -302333)
						{
							this.mChar.mImmuneList = new UnityScript.Lang.Array(new object[]
							{
								"burn",
								"ignite",
								"dissolute",
								"inferno"
							});
							if (205851 - 24123 == 181728)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060018E9 RID: 6377 RVA: 0x0028B6FC File Offset: 0x002898FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x060018EA RID: 6378 RVA: 0x0028B718 File Offset: 0x00289918
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (184056 - 510716 != -326659)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (44121 - 466012 == -421890)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (110920 - 169240 == -58319)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_1B3;
					}
					if (102165 - 147703 == -45537)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (147161 - 210529 != -63368)
				{
					continue;
				}
			}
			IL_1B3:
			if (this.mChar.hp <= 0)
			{
				if (162287 - 245731 == -83443)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (278576 - 317583 != -39007)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (276174 - 433602 == -157427)
						{
							continue;
						}
						if (Game.mGameCode == 992)
						{
							if (223256 - 29223 == 194034)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (152144 - 92288 != 59856)
							{
								continue;
							}
							this.mChar.actionState = "dead";
							if (114723 - 156806 != -42083)
							{
								continue;
							}
							Game.sendMissionEvent(9923, 1);
							if (117985 - 101184 != 16802)
							{
								break;
							}
							continue;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (225764 - 505420 == -279655)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (248034 - 101444 != 146590)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (162816 - 240416 != -77600)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (22244 - 539605 != -517360)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (232418 - 33160 != 199259)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (206926 - 494581 != -287654)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (166792 - 380777 == -213985)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (287180 - 506786 != -219605)
						{
							if (this.mChar.isMine)
							{
								if (279951 - 228635 == 51316)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (138212 - 438696 != -300483)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (220396 - 152855 == 67541)
										{
											this.mChar.KoEvent();
											if (25535 - 137393 == -111858)
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
								if (160541 - 486903 == -326362)
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

	// Token: 0x060018EB RID: 6379 RVA: 0x0028BBB4 File Offset: 0x00289DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (214303 - 136859 != 77445)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (211015 - 582853 == -371838)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (133147 - 180563 == -47416)
				{
					if (54383 - 399044 == -344661)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (277937 - 306637 != -28700)
							{
								continue;
							}
							v = 1;
							if (274827 - 235178 == 39650)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (282810 - 143339 == 139472)
							{
								continue;
							}
							v = -1;
							if (79321 - 50652 != 28669)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_phoenixStrike")
						{
							if (154954 - 166500 == -11545)
							{
								continue;
							}
							v = 11;
							if (172834 - 461367 != -288533)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_phoenixStrike_fire")
						{
							if (178183 - 547065 != -368882)
							{
								continue;
							}
							v = 12;
							if (165878 - 266251 != -100373)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_fireStorm")
						{
							if (224301 - 202118 != 22183)
							{
								continue;
							}
							v = 21;
							if (52028 - 398224 != -346196)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_inferno")
						{
							if (216044 - 437687 == -221642)
							{
								continue;
							}
							v = 31;
							if (245160 - 423490 == -178329)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_fieldOfFire")
						{
							if (122594 - 57650 != 64944)
							{
								continue;
							}
							v = 41;
							if (46942 - 396210 == -349267)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_fieldOfFire_fire")
						{
							if (180014 - 468143 == -288128)
							{
								continue;
							}
							v = 42;
							if (218504 - 461933 == -243428)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_fieldOfFire_hit")
						{
							if (240504 - 524420 != -283916)
							{
								continue;
							}
							v = -41;
							if (232571 - 517090 != -284519)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (164771 - 535232 == -370460)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (267286 - 446525 != -179238)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (9527 - 152643 == -143116)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (128953 - 256557 == -127604)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (207894 - 330491 != -122596)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (245991 - 207007 != 38985)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (17556 - 342239 == -324683)
											{
												Hashtable hashtable = new Hashtable();
												if (35933 - 473965 != -438031)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (76274 - 42897 != 33378)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (88450 - 433637 != -345186)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (93841 - 470635 == -376794)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (231784 - 25648 != 206137)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (50117 - 449776 == -399659)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (243309 - 466736 != -223426)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (33850 - 103840 != -69989)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (110706 - 199839 == -89133)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (264199 - 297192 != -32992)
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

	// Token: 0x060018EC RID: 6380 RVA: 0x0028C248 File Offset: 0x0028A448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (30534 - 369075 != -338540)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (222851 - 505075 != -282223)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (251871 - 141447 == 110424)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (41795 - 310277 != -268481)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (246635 - 382363 != -135727)
						{
							int num3 = num;
							if (115344 - 8917 != 106428)
							{
								if (num3 == 1)
								{
									if (283645 - 589845 == -306200)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (280783 - 167708 == 113075)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (198198 - 353745 == -155547)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (15713 - 405200 == -389487)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (265760 - 398793 != -133032)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (65388 - 351484 != -286095)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (73187 - 252151 != -178963)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (19691 - 333475 != -313783)
										{
											this.StartCoroutine_Auto(this.RPC_phoenixStrike(vector, vector2, num2));
											if (215792 - 462782 != -246989)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (256491 - 167408 != 89084)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (190493 - 305357 != -114863)
										{
											this.StartCoroutine_Auto(this.RPC_phoenixStrike_fire(vector, vector2, num2));
											if (245345 - 66932 == 178413)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (191873 - 337621 == -145748)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (99643 - 107534 == -7891)
										{
											this.StartCoroutine_Auto(this.RPC_fireStorm(vector, vector2, num2));
											if (108589 - 117791 == -9202)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (192416 - 427818 != -235401)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (152755 - 427352 == -274597)
										{
											this.StartCoroutine_Auto(this.RPC_inferno(vector, vector2, num2));
											if (43693 - 247411 != -203717)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 41)
								{
									if (41375 - 152118 != -110742)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (288277 - 379691 != -91413)
										{
											this.StartCoroutine_Auto(this.RPC_fieldOfFire(vector, vector2, num2));
											if (65030 - 132571 == -67541)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 42)
								{
									if (111965 - 358653 == -246688)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (140261 - 262671 != -122409)
										{
											this.StartCoroutine_Auto(this.RPC_fieldOfFire_fire(vector, vector2, num2));
											if (27299 - 537546 == -510247)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -41)
								{
									if (236452 - 307496 != -71043)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (193307 - 157032 == 36275)
										{
											this.StartCoroutine_Auto(this.RPC_fieldOfFire_hit(vector, vector2, num2));
											if (91307 - 180693 != -89385)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (81178 - 211625 != -130446)
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

	// Token: 0x060018ED RID: 6381 RVA: 0x0028C840 File Offset: 0x0028AA40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (192983 - 402803 != -209819)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (223767 - 274999 == -51232)
			{
				float runSpeed = this.mChar.runSpeed;
				if (175636 - 446947 != -271310)
				{
					Vector3 a = default(Vector3);
					if (156440 - 43539 != 112902)
					{
						Vector3 vector = Vector3.zero;
						if (107242 - 90499 != 16744)
						{
							float num2 = (float)0;
							if (152243 - 450813 == -298570)
							{
								if (this.mChar.isMine)
								{
									if (90907 - 365763 == -274855)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (223659 - 248733 != -25074)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (190272 - 468516 != -278244)
										{
											continue;
										}
										a.y = (float)0;
										if (178891 - 498341 != -319450)
										{
											continue;
										}
										a = a.normalized;
										if (82642 - 534544 == -451901)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (256648 - 414694 == -158045)
										{
											continue;
										}
										vector = vector.normalized;
										if (267776 - 113398 != 154378)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (292379 - 58526 != 233853)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (254071 - 513504 == -259432)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (191495 - 29390 == 162106)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (210067 - 204558 == 5510)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (185291 - 142460 == 42832)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (221478 - 485422 == -263943)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (203378 - 542157 != -338779)
														{
															continue;
														}
														this.animation.Play("run");
														if (220403 - 274802 != -54399)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (17552 - 104315 != -86762)
														{
															goto IL_742;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (11260 - 498903 != -487643)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (48679 - 598321 != -549642)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (168127 - 577620 != -409493)
											{
												continue;
											}
											num = (float)0;
											if (128406 - 80656 == 47751)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.4f);
										if (258452 - 92682 == 165771)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (194001 - 92566 == 101436)
										{
											continue;
										}
									}
									IL_742:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (9180 - 454639 == -445458)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (280307 - 159904 == 120404)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (13557 - 273932 == -260374)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (173886 - 45840 != 128046)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (42292 - 377382 == -335089)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (208451 - 83474 != 124977)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (127815 - 513944 != -386129)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (188578 - 150819 == 37760)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (153983 - 296198 != -142215)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (192374 - 52609 != 139765)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (58834 - 491467 == -432632)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (5400 - 343795 == -338394)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (171275 - 175599 != -4324)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (292474 - 205935 != 86539)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (225313 - 357438 == -132124)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (297543 - 72362 == 225182)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (152677 - 163946 != -11269)
												{
													continue;
												}
												num = (float)0;
												if (261170 - 47703 != 213467)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (23795 - 77444 != -53649)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.4f);
											if (59857 - 203611 != -143754)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (182352 - 20399 == 161954)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (72504 - 292268 != -219764)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (119707 - 404171 != -284464)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (288228 - 390344 == -102115)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (258504 - 328887 != -70383)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (106015 - 148670 == -42654)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (231270 - 86799 == 144472)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (259903 - 503281 == -243377)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (124488 - 566708 != -442220)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (298302 - 156067 != 142235)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (66327 - 410859 != -344532)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (34746 - 557841 == -523094)
											{
												continue;
											}
											num = (float)0;
											if (220324 - 346127 == -125802)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.4f);
											if (10874 - 376939 == -366064)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (230846 - 562501 == -331654)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.4f);
										if (230324 - 547900 != -317576)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (124301 - 577885 == -453583)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (32744 - 527240 != -494495)
								{
									this.mChar.moveSpeed = num;
									if (190277 - 113949 == 76328)
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

	// Token: 0x060018EE RID: 6382 RVA: 0x0028D3A4 File Offset: 0x0028B5A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (267639 - 562912 != -295272)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (94682 - 381583 == -286901)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (175187 - 363122 != -187934)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (298412 - 362021 != -63608)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (268934 - 115504 != 153431)
						{
							CharacterControl characterControl = null;
							if (20269 - 57388 != -37118)
							{
								int tID = 0;
								if (216209 - 469863 != -253653)
								{
									if (gameObject)
									{
										if (11886 - 184895 == -173008)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (192193 - 325862 == -133668)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (92679 - 526629 != -433950)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (142153 - 314937 == -172783)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (220731 - 398735 != -178004)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (264150 - 316141 != -51991)
										{
											continue;
										}
									}
									if (characterControl != null)
									{
										if (196009 - 7153 == 188857)
										{
											continue;
										}
										if (this.gameObject != gameObject)
										{
											if (265252 - 192950 != 72302)
											{
												continue;
											}
											if (this.mChar.isTimeOut("inferno") == (float)0)
											{
												if (186623 - 426502 == -239878)
												{
													continue;
												}
												if (characterControl.hasStatus("inferno"))
												{
													if (163945 - 53238 == 110708)
													{
														continue;
													}
													Camera.main.SendMessage("newGameMessage", "Target already has inferno.");
													if (148347 - 465290 != -316942)
													{
														break;
													}
													continue;
												}
												else
												{
													this.StartCoroutine_Auto(this.RPC_inferno(this.transform.position, vector, tID));
													if (263804 - 92664 == 171141)
													{
														continue;
													}
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (130705 - 242740 != -112035)
													{
														continue;
													}
													this.ActionEvent("RPC_inferno", this.transform.position, vector, tID);
													if (253181 - 597293 != -344111)
													{
														break;
													}
													continue;
												}
											}
										}
									}
									if (vector.magnitude > (float)6)
									{
										if (142758 - 457912 == -315153)
										{
											continue;
										}
										if (this.mChar.isTimeOut("phoenixStrike") == (float)0)
										{
											if (105186 - 413950 != -308764)
											{
												continue;
											}
											this.StartCoroutine_Auto(this.RPC_phoenixStrike(this.transform.position, vector, 0));
											if (118266 - 110388 == 7879)
											{
												continue;
											}
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (46582 - 74468 == -27885)
											{
												continue;
											}
											this.ActionEvent("RPC_phoenixStrike", this.transform.position, vector, 0);
											if (286428 - 496587 != -210159)
											{
												continue;
											}
											break;
										}
									}
									if (vector.magnitude >= (float)6)
									{
										break;
									}
									if (163821 - 86274 == 77547)
									{
										if (this.mChar.isTimeOut("nAttack") != (float)0)
										{
											break;
										}
										if (119958 - 429762 == -309804)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
											if (82192 - 475719 == -393527)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (70288 - 243436 == -173148)
												{
													this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
													if (218186 - 204405 != 13782)
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

	// Token: 0x060018EF RID: 6383 RVA: 0x0028D924 File Offset: 0x0028BB24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (12995 - 306110 != -293114)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (81995 - 583021 != -501025)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (225180 - 160786 == 64394)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (233442 - 144013 == 89429)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (259355 - 437336 == -177981)
						{
							CharacterControl characterControl = null;
							if (182304 - 485063 != -302758)
							{
								if (235984 - 513550 == -277566)
								{
									if (gameObject)
									{
										if (117397 - 189195 != -71798)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (141907 - 270435 == -128527)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (287842 - 180696 != 107146)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (215153 - 155513 == 59641)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (257530 - 401850 != -144320)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (103641 - 339970 == -236328)
										{
											continue;
										}
									}
									if (this.gameObject == gameObject)
									{
										if (16259 - 491484 == -475225)
										{
											if ((float)this.mChar.hp > 0.5f * (float)this.mChar.mhp)
											{
												if (23139 - 73435 != -50295)
												{
													Camera.main.SendMessage("newGameMessage", "FieldOfFire needs hp to be below 50%");
													if (161677 - 257413 != -95735)
													{
														break;
													}
												}
											}
											else if (this.mChar.isTimeOut("fieldOfFire") != (float)0)
											{
												if (295572 - 458156 == -162584)
												{
													Camera.main.SendMessage("newGameMessage", "FieldOfFire timeout: " + this.mChar.getTimeOut("fieldOfFire"));
													if (165228 - 429876 != -264647)
													{
														break;
													}
												}
											}
											else
											{
												this.StartCoroutine_Auto(this.RPC_fieldOfFire(this.transform.position, this.transform.forward, 0));
												if (199848 - 496676 == -296828)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (193362 - 155079 != 38284)
													{
														this.ActionEvent("RPC_fieldOfFire", this.transform.position, this.transform.forward, 0);
														if (212878 - 48430 == 164448)
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
										if (this.mChar.isTimeOut("fireStorm") != (float)0)
										{
											break;
										}
										if (55727 - 513631 != -457903)
										{
											this.StartCoroutine_Auto(this.RPC_fireStorm(this.transform.position, this.transform.forward, 0));
											if (34242 - 218786 == -184544)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (181587 - 163617 == 17970)
												{
													this.ActionEvent("RPC_fireStorm", this.transform.position, this.transform.forward, 0);
													if (234951 - 562703 == -327752)
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

	// Token: 0x060018F0 RID: 6384 RVA: 0x0028DDF4 File Offset: 0x0028BFF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060018F1 RID: 6385 RVA: 0x0028DDF8 File Offset: 0x0028BFF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FireGod_gm.$RPC_nAttack$19509(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060018F2 RID: 6386 RVA: 0x0028DE08 File Offset: 0x0028C008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x060018F3 RID: 6387 RVA: 0x0028DE34 File Offset: 0x0028C034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_phoenixStrike(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FireGod_gm.$RPC_phoenixStrike$19522(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060018F4 RID: 6388 RVA: 0x0028DE44 File Offset: 0x0028C044
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_phoenixStrike_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FireGod_gm.$RPC_phoenixStrike_fire$19529(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060018F5 RID: 6389 RVA: 0x0028DE54 File Offset: 0x0028C054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_fireStorm(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FireGod_gm.$RPC_fireStorm$19543(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060018F6 RID: 6390 RVA: 0x0028DE64 File Offset: 0x0028C064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_inferno(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FireGod_gm.$RPC_inferno$19556(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060018F7 RID: 6391 RVA: 0x0028DE74 File Offset: 0x0028C074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_fieldOfFire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FireGod_gm.$RPC_fieldOfFire$19568(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060018F8 RID: 6392 RVA: 0x0028DE84 File Offset: 0x0028C084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_fieldOfFire_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FireGod_gm.$RPC_fieldOfFire_fire$19575(tDir, this).GetEnumerator();
	}

	// Token: 0x060018F9 RID: 6393 RVA: 0x0028DE94 File Offset: 0x0028C094
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_fieldOfFire_hit(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FireGod_gm.$RPC_fieldOfFire_hit$19582(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060018FA RID: 6394 RVA: 0x0028DEA4 File Offset: 0x0028C0A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new FireGod_gm.$RPC_ko$19595(nArray, this).GetEnumerator();
	}

	// Token: 0x060018FB RID: 6395 RVA: 0x0028DEB4 File Offset: 0x0028C0B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new FireGod_gm.$RPC_dead$19602(nArray, this).GetEnumerator();
	}

	// Token: 0x060018FC RID: 6396 RVA: 0x0028DEC4 File Offset: 0x0028C0C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060018FD RID: 6397 RVA: 0x0028DEC8 File Offset: 0x0028C0C8
	internal static bool hNeHwhfZnlCoLlNtc3c()
	{
		return true;
	}

	// Token: 0x060018FE RID: 6398 RVA: 0x0028DECC File Offset: 0x0028C0CC
	internal static bool olfGXxfC6ZtuYK275TA()
	{
		return false;
	}

	// Token: 0x0400155B RID: 5467
	public CharacterControl mChar;

	// Token: 0x0400155C RID: 5468
	public AudioClip nAttack_vc;

	// Token: 0x0400155D RID: 5469
	public GameObject nAttack_hit;

	// Token: 0x0400155E RID: 5470
	public GameObject phoenixStrike_ring;

	// Token: 0x0400155F RID: 5471
	public AudioClip phoenixStrike_vc;

	// Token: 0x04001560 RID: 5472
	public GameObject phoenixStrike_fire;

	// Token: 0x04001561 RID: 5473
	public GameObject fireStorm_ring;

	// Token: 0x04001562 RID: 5474
	public AudioClip fireStorm_vc;

	// Token: 0x04001563 RID: 5475
	public GameObject inferno_ring;

	// Token: 0x04001564 RID: 5476
	public AudioClip inferno_vc;

	// Token: 0x04001565 RID: 5477
	public GameObject fieldOfFire_ring;

	// Token: 0x04001566 RID: 5478
	public AudioClip fieldOfFire_vc;

	// Token: 0x04001567 RID: 5479
	public GameObject fieldOfFire_hit;

	// Token: 0x04001568 RID: 5480
	public AudioClip ko_vc;

	// Token: 0x04001569 RID: 5481
	public AudioClip dead_vc;

	// Token: 0x0200042C RID: 1068
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$19509 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060018FF RID: 6399 RVA: 0x0028DED0 File Offset: 0x0028C0D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$19509(Vector3 mPos, Vector3 tDir, FireGod_gm self_)
		{
			if (12097 - 595559 != -583462)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (173967 - 23942 == 150025)
				{
					base..ctor();
					if (268 - 19981 != -19712)
					{
						this.$mPos$19519 = mPos;
						if (210175 - 242879 == -32704)
						{
							this.$tDir$19520 = tDir;
							if (295931 - 309253 != -13321)
							{
								this.$self_$19521 = self_;
								if (165180 - 177581 == -12401)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0028DFAC File Offset: 0x0028C1AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireGod_gm.$RPC_nAttack$19509.$(this.$mPos$19519, this.$tDir$19520, this.$self_$19521);
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0028DFC8 File Offset: 0x0028C1C8
		internal static bool VXT0WxfLgXNEReLc3q0()
		{
			return true;
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x0028DFCC File Offset: 0x0028C1CC
		internal static bool oSsrsNfO8homSWSadtR()
		{
			return false;
		}

		// Token: 0x0400156A RID: 5482
		internal Vector3 $mPos$19519;

		// Token: 0x0400156B RID: 5483
		internal Vector3 $tDir$19520;

		// Token: 0x0400156C RID: 5484
		internal FireGod_gm $self_$19521;

		// Token: 0x0200042D RID: 1069
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001903 RID: 6403 RVA: 0x0028DFD0 File Offset: 0x0028C1D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FireGod_gm self_)
			{
				if (50302 - 155687 != -105385)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (198829 - 541995 != -343165)
					{
						base..ctor();
						if (166032 - 267747 == -101715)
						{
							this.$mPos$19516 = mPos;
							if (134664 - 328281 == -193617)
							{
								this.$tDir$19517 = tDir;
								if (71542 - 3865 != 67678)
								{
									this.$self_$19518 = self_;
									if (299192 - 392480 != -93287)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001904 RID: 6404 RVA: 0x0028E0AC File Offset: 0x0028C2AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (24415 - 337104 != -312688)
				{
				}
				for (;;)
				{
					IL_961:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A0D;
					case 2:
						if (this.$self_$19518.mChar.actionState != "attack")
						{
							goto IL_85A;
						}
						if (43591 - 118674 == -75082)
						{
							continue;
						}
						if (this.$self_$19518.mChar.myCommand != "nAttack")
						{
							if (129429 - 522531 != -393101)
							{
								goto Block_35;
							}
							continue;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_22F;
							}
							if (97787 - 408744 != -310957)
							{
								continue;
							}
							if (this.$self_$19518.nAttack_vc)
							{
								if (198732 - 251399 != -52667)
								{
									continue;
								}
								this.$self_$19518.audio.PlayOneShot(this.$self_$19518.nAttack_vc);
								if (137106 - 263826 != -126720)
								{
									continue;
								}
								goto IL_206;
							}
							else
							{
								Debug.LogError("Cannot find nAttack voice");
								if (147798 - 566130 != -418331)
								{
									goto IL_22F;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$19518.mChar.actionState != "attack")
						{
							goto IL_15E;
						}
						if (272462 - 258432 == 14031)
						{
							continue;
						}
						if (this.$self_$19518.mChar.myCommand != "nAttack")
						{
							if (27680 - 592379 != -564699)
							{
								continue;
							}
							goto IL_15E;
						}
						else
						{
							if (!this.$self_$19518.mChar.isMine)
							{
								goto IL_430;
							}
							if (288210 - 47132 != 241078)
							{
								continue;
							}
							this.$hitLayer$19510 = 130816 - (1 << this.$self_$19518.gameObject.layer);
							if (87571 - 138550 == -50978)
							{
								continue;
							}
							this.$hitList$19511 = Damage.FindAreaTarget(this.$self_$19518.transform.position, (float)6, (float)5, this.$hitLayer$19510);
							if (99296 - 486082 != -386786)
							{
								continue;
							}
							this.$$iterator$10536$19515 = UnityRuntimeServices.GetEnumerator(this.$hitList$19511);
							if (96579 - 511366 == -414786)
							{
								continue;
							}
							while (this.$$iterator$10536$19515.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10536$19515.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19512 = (GameObject)obj2;
								if (31610 - 58460 == -26849)
								{
									goto IL_961;
								}
								this.$hitChar$19513 = (CharacterControl)this.$hitObject$19512.GetComponent(typeof(CharacterControl));
								if (144725 - 399297 != -254572)
								{
									goto IL_961;
								}
								UnityRuntimeServices.Update(this.$$iterator$10536$19515, this.$hitObject$19512);
								if (147140 - 582566 == -435425)
								{
									goto IL_961;
								}
								if (this.$hitChar$19513)
								{
									if (138644 - 263151 != -124507)
									{
										goto IL_961;
									}
									this.$hitChar$19513.RPC_AddStatus("armorBreak", 5, Damage.getDebuff((float)8, this.$self_$19518.mChar.cha, this.$hitChar$19513.cha), Mathf.Clamp(Mathf.FloorToInt(0.1f * (float)this.$hitChar$19513.def), 0, 15), this.$self_$19518.mChar.ActorNr);
									if (95254 - 215875 != -120621)
									{
										goto IL_961;
									}
								}
								if (this.$self_$19518.mChar.hit(1, this.$hitObject$19512, (int)(0.75f * (float)this.$self_$19518.mChar.atk), 10, 0, Vector3.zero) != 0)
								{
									if (268140 - 565507 == -297366)
									{
										goto IL_961;
									}
									this.$hitPoint$19514 = this.$hitObject$19512.collider.ClosestPointOnBounds(this.$self_$19518.transform.position + (float)3 * Vector3.up);
									if (55194 - 175350 == -120155)
									{
										goto IL_961;
									}
									UnityRuntimeServices.Update(this.$$iterator$10536$19515, this.$hitObject$19512);
									if (277791 - 20328 != 257463)
									{
										goto IL_961;
									}
									this.$self_$19518.RPC_nAttack_hit(this.$hitPoint$19514, 0.25f * this.$self_$19518.transform.forward, 0);
									if (223267 - 130274 != 92993)
									{
										goto IL_961;
									}
									this.$self_$19518.ActionEvent("RPC_nAttack_hit", this.$hitPoint$19514, 0.25f * this.$self_$19518.transform.forward, 0);
									if (117337 - 566819 == -449481)
									{
										goto IL_961;
									}
								}
							}
							if (196367 - 459666 != -263298)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$19518.mChar.actionState == "attack")
						{
							if (18930 - 147800 != -128870)
							{
								continue;
							}
							if (this.$self_$19518.mChar.myCommand == "nAttack")
							{
								if (96541 - 284117 == -187575)
								{
									continue;
								}
								this.$self_$19518.mChar.actionState = "standby";
								if (160315 - 498006 == -337690)
								{
									continue;
								}
								this.$self_$19518.mChar.actionTime = Time.time;
								if (168779 - 275239 == -106459)
								{
									continue;
								}
								this.$self_$19518.mChar.myCommand = "none";
								if (9495 - 400332 == -390836)
								{
									continue;
								}
								if (!this.$self_$19518.mChar.isMine)
								{
									if (176985 - 182401 != -5416)
									{
										continue;
									}
									this.$self_$19518.mChar.nPosition = this.$self_$19518.transform.position;
									if (50844 - 313309 != -262465)
									{
										continue;
									}
									this.$self_$19518.mChar.oPosition = this.$self_$19518.transform.position;
									if (106968 - 243923 == -136954)
									{
										continue;
									}
									this.$self_$19518.mChar.nDirection = this.$self_$19518.transform.forward;
									if (38535 - 165275 != -126740)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (292525 - 473288 != -180763)
						{
							continue;
						}
						goto IL_A0D;
					default:
						if (57421 - 320256 == -262834)
						{
							continue;
						}
						break;
					}
					this.$self_$19518.mChar.actionState = "attack";
					if (244101 - 74717 == 169384)
					{
						this.$self_$19518.mChar.actionTime = Time.time;
						if (293482 - 178553 == 114929)
						{
							this.$self_$19518.mChar.myCommand = "nAttack";
							if (254230 - 379147 != -124916)
							{
								this.$self_$19518.mChar.addTimeOut("nAttack", (float)2);
								if (269959 - 424970 == -155011)
								{
									this.$self_$19518.transform.position = this.$mPos$19516;
									if (38712 - 100580 != -61867)
									{
										this.$self_$19518.transform.LookAt(this.$mPos$19516 + global::Math.vFlat(this.$tDir$19517));
										if (166205 - 551078 != -384872)
										{
											this.$self_$19518.animation.Rewind();
											if (220293 - 355816 == -135523)
											{
												this.$self_$19518.animation.CrossFade("nAttack1", 0.2f);
												if (20531 - 275454 != -254922)
												{
													this.$self_$19518.animation.wrapMode = WrapMode.Once;
													if (16346 - 124215 != -107868)
													{
														this.$self_$19518.mChar.vMovement = this.$self_$19518.transform.forward;
														if (6218 - 340534 != -334315)
														{
															this.$self_$19518.mChar.moveSpeed = (float)0;
															if (216310 - 486596 != -270285)
															{
																goto Block_17;
															}
														}
													}
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
				goto IL_430;
				IL_15E:
				goto IL_A0D;
				IL_206:
				IL_22F:
				return this.Yield(3, new WaitForSeconds(1.2f));
				Block_17:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_430:
				return this.Yield(4, new WaitForSeconds(0.4f));
				Block_35:
				IL_85A:
				IL_A0D:
				return false;
			}

			// Token: 0x06001905 RID: 6405 RVA: 0x0028EAD8 File Offset: 0x0028CCD8
			internal static bool sMdAgWfm1yuySMY5gcN()
			{
				return true;
			}

			// Token: 0x06001906 RID: 6406 RVA: 0x0028EADC File Offset: 0x0028CCDC
			internal static bool FMSZsUfFtCyWbNQAPnk()
			{
				return false;
			}

			// Token: 0x0400156D RID: 5485
			internal int $hitLayer$19510;

			// Token: 0x0400156E RID: 5486
			internal UnityScript.Lang.Array $hitList$19511;

			// Token: 0x0400156F RID: 5487
			internal GameObject $hitObject$19512;

			// Token: 0x04001570 RID: 5488
			internal CharacterControl $hitChar$19513;

			// Token: 0x04001571 RID: 5489
			internal Vector3 $hitPoint$19514;

			// Token: 0x04001572 RID: 5490
			internal IEnumerator $$iterator$10536$19515;

			// Token: 0x04001573 RID: 5491
			internal Vector3 $mPos$19516;

			// Token: 0x04001574 RID: 5492
			internal Vector3 $tDir$19517;

			// Token: 0x04001575 RID: 5493
			internal FireGod_gm $self_$19518;
		}
	}

	// Token: 0x0200042E RID: 1070
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_phoenixStrike$19522 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001907 RID: 6407 RVA: 0x0028EAE0 File Offset: 0x0028CCE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_phoenixStrike$19522(Vector3 mPos, Vector3 tDir, FireGod_gm self_)
		{
			if (290436 - 561837 != -271401)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (293463 - 437262 == -143799)
				{
					base..ctor();
					if (62540 - 409298 == -346758)
					{
						this.$mPos$19526 = mPos;
						if (34226 - 509759 == -475533)
						{
							this.$tDir$19527 = tDir;
							if (3803 - 433346 != -429542)
							{
								this.$self_$19528 = self_;
								if (7587 - 570636 == -563049)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x0028EBBC File Offset: 0x0028CDBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireGod_gm.$RPC_phoenixStrike$19522.$(this.$mPos$19526, this.$tDir$19527, this.$self_$19528);
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x0028EBD8 File Offset: 0x0028CDD8
		internal static bool DpR6lpfMfAyDZTNZXcl()
		{
			return true;
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x0028EBDC File Offset: 0x0028CDDC
		internal static bool EwqaSAfx6oGlNkbkb4I()
		{
			return false;
		}

		// Token: 0x04001576 RID: 5494
		internal Vector3 $mPos$19526;

		// Token: 0x04001577 RID: 5495
		internal Vector3 $tDir$19527;

		// Token: 0x04001578 RID: 5496
		internal FireGod_gm $self_$19528;

		// Token: 0x0200042F RID: 1071
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600190B RID: 6411 RVA: 0x0028EBE0 File Offset: 0x0028CDE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FireGod_gm self_)
			{
				if (198740 - 81299 != 117441)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (40382 - 113286 != -72903)
					{
						base..ctor();
						if (48835 - 390738 == -341903)
						{
							this.$mPos$19523 = mPos;
							if (265009 - 398301 != -133291)
							{
								this.$tDir$19524 = tDir;
								if (226737 - 8819 == 217918)
								{
									this.$self_$19525 = self_;
									if (222283 - 389975 != -167691)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600190C RID: 6412 RVA: 0x0028ECBC File Offset: 0x0028CEBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (73067 - 39429 != 33639)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7CF;
					case 2:
						if (this.$self_$19525.mChar.actionState != "attack")
						{
							goto IL_581;
						}
						if (177867 - 559441 == -381573)
						{
							continue;
						}
						if (this.$self_$19525.mChar.myCommand != "phoenixStrike")
						{
							if (242320 - 237281 != 5039)
							{
								continue;
							}
							goto IL_581;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (37828 - 490069 == -452240)
								{
									continue;
								}
								if (this.$self_$19525.phoenixStrike_vc)
								{
									if (136251 - 251367 == -115115)
									{
										continue;
									}
									this.$self_$19525.audio.PlayOneShot(this.$self_$19525.phoenixStrike_vc);
									if (227753 - 346724 == -118970)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find phoenixStrike voice");
									if (210056 - 439735 != -229679)
									{
										continue;
									}
								}
							}
							if (!this.$self_$19525.mChar.isMine)
							{
								goto IL_426;
							}
							if (149510 - 112995 == 36516)
							{
								continue;
							}
							this.$self_$19525.StartCoroutine_Auto(this.$self_$19525.RPC_phoenixStrike_fire(this.$self_$19525.transform.position, this.$self_$19525.transform.forward, 0));
							if (261443 - 21466 == 239978)
							{
								continue;
							}
							this.$self_$19525.ActionEvent("RPC_phoenixStrike_fire", this.$self_$19525.transform.position, this.$self_$19525.transform.forward, 0);
							if (112982 - 279982 != -167000)
							{
								continue;
							}
							goto IL_426;
						}
						break;
					case 3:
						if (this.$self_$19525.mChar.actionState != "attack")
						{
							goto IL_306;
						}
						if (160906 - 380664 == -219757)
						{
							continue;
						}
						if (!(this.$self_$19525.mChar.myCommand != "phoenixStrike"))
						{
							goto IL_30B;
						}
						if (188453 - 214538 != -26084)
						{
							goto Block_25;
						}
						continue;
					case 4:
						if (this.$self_$19525.mChar.actionState == "attack")
						{
							if (268960 - 467113 != -198153)
							{
								continue;
							}
							if (this.$self_$19525.mChar.myCommand == "phoenixStrike")
							{
								if (149140 - 300800 != -151660)
								{
									continue;
								}
								this.$self_$19525.mChar.actionState = "standby";
								if (61613 - 247553 == -185939)
								{
									continue;
								}
								this.$self_$19525.mChar.actionTime = Time.time;
								if (89239 - 536286 == -447046)
								{
									continue;
								}
								this.$self_$19525.mChar.myCommand = "none";
								if (196526 - 520173 == -323646)
								{
									continue;
								}
								if (!this.$self_$19525.mChar.isMine)
								{
									if (55215 - 53383 != 1832)
									{
										continue;
									}
									this.$self_$19525.mChar.nPosition = this.$self_$19525.transform.position;
									if (160394 - 169367 == -8972)
									{
										continue;
									}
									this.$self_$19525.mChar.oPosition = this.$self_$19525.transform.position;
									if (76737 - 143667 == -66929)
									{
										continue;
									}
									this.$self_$19525.mChar.nDirection = this.$self_$19525.transform.forward;
									if (126914 - 563815 == -436900)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (199124 - 380366 != -181242)
						{
							continue;
						}
						goto IL_7CF;
					default:
						if (227652 - 119478 != 108174)
						{
							continue;
						}
						break;
					}
					this.$self_$19525.mChar.actionState = "attack";
					if (181717 - 157585 == 24132)
					{
						this.$self_$19525.mChar.actionTime = Time.time;
						if (17473 - 42454 == -24981)
						{
							this.$self_$19525.mChar.myCommand = "phoenixStrike";
							if (28871 - 224968 == -196097)
							{
								this.$self_$19525.mChar.addTimeOut("nAttack", (float)2);
								if (265234 - 531331 == -266097)
								{
									this.$self_$19525.transform.position = this.$mPos$19523;
									if (130276 - 92472 != 37805)
									{
										this.$self_$19525.transform.LookAt(this.$mPos$19523 + global::Math.vFlat(this.$tDir$19524));
										if (265075 - 504701 != -239625)
										{
											this.$self_$19525.animation.Rewind();
											if (52392 - 215244 != -162851)
											{
												this.$self_$19525.animation.CrossFade("nAttack2", 0.2f);
												if (50783 - 409132 != -358348)
												{
													this.$self_$19525.animation.wrapMode = WrapMode.Once;
													if (155361 - 1261 != 154101)
													{
														this.$self_$19525.mChar.vMovement = this.$self_$19525.transform.forward;
														if (208229 - 410504 != -202274)
														{
															this.$self_$19525.mChar.moveSpeed = (float)0;
															if (294481 - 470810 == -176329)
															{
																if (this.$self_$19525.phoenixStrike_ring)
																{
																	if (245155 - 296620 != -51464)
																	{
																		this.$self_$19525.mChar.createEffect(this.$self_$19525.phoenixStrike_ring, this.$self_$19525.transform.position, this.$self_$19525.transform.rotation);
																		if (15945 - 159992 == -144047)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find phoenixStrike_ring Effect");
																	if (182649 - 179890 != 2760)
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
				goto IL_69A;
				IL_306:
				goto IL_7CF;
				IL_30B:
				return this.Yield(4, new WaitForSeconds(1.2f));
				Block_25:
				goto IL_306;
				IL_426:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_581:
				goto IL_7CF;
				IL_69A:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_7CF:
				return false;
			}

			// Token: 0x0600190D RID: 6413 RVA: 0x0028F4AC File Offset: 0x0028D6AC
			internal static bool dTJyZpfgZv7E6EfdVfU()
			{
				return true;
			}

			// Token: 0x0600190E RID: 6414 RVA: 0x0028F4B0 File Offset: 0x0028D6B0
			internal static bool tXiK6OffcNtwnmBD5FI()
			{
				return false;
			}

			// Token: 0x04001579 RID: 5497
			internal Vector3 $mPos$19523;

			// Token: 0x0400157A RID: 5498
			internal Vector3 $tDir$19524;

			// Token: 0x0400157B RID: 5499
			internal FireGod_gm $self_$19525;
		}
	}

	// Token: 0x02000430 RID: 1072
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_phoenixStrike_fire$19529 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600190F RID: 6415 RVA: 0x0028F4B4 File Offset: 0x0028D6B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_phoenixStrike_fire$19529(Vector3 mPos, Vector3 tDir, FireGod_gm self_)
		{
			if (246446 - 120636 != 125810)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (286263 - 183679 == 102584)
				{
					base..ctor();
					if (113836 - 403902 == -290066)
					{
						this.$mPos$19540 = mPos;
						if (228330 - 441381 != -213050)
						{
							this.$tDir$19541 = tDir;
							if (261315 - 375407 == -114092)
							{
								this.$self_$19542 = self_;
								if (253270 - 555097 == -301827)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x0028F590 File Offset: 0x0028D790
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireGod_gm.$RPC_phoenixStrike_fire$19529.$(this.$mPos$19540, this.$tDir$19541, this.$self_$19542);
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x0028F5AC File Offset: 0x0028D7AC
		internal static bool p6VvVMfn5SkAUnW9cIe()
		{
			return true;
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x0028F5B0 File Offset: 0x0028D7B0
		internal static bool FOYDZJf61Y7iZhB7WXM()
		{
			return false;
		}

		// Token: 0x0400157C RID: 5500
		internal Vector3 $mPos$19540;

		// Token: 0x0400157D RID: 5501
		internal Vector3 $tDir$19541;

		// Token: 0x0400157E RID: 5502
		internal FireGod_gm $self_$19542;

		// Token: 0x02000431 RID: 1073
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001913 RID: 6419 RVA: 0x0028F5B4 File Offset: 0x0028D7B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FireGod_gm self_)
			{
				if (289252 - 417257 != -128004)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (8526 - 189185 != -180658)
					{
						base..ctor();
						if (134233 - 151691 == -17458)
						{
							this.$mPos$19537 = mPos;
							if (215145 - 363973 == -148828)
							{
								this.$tDir$19538 = tDir;
								if (262722 - 558482 != -295759)
								{
									this.$self_$19539 = self_;
									if (204914 - 475675 != -270760)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001914 RID: 6420 RVA: 0x0028F690 File Offset: 0x0028D890
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (157940 - 237613 != -79673)
				{
				}
				for (;;)
				{
					IL_3CB:
					switch (this._state)
					{
					case 0:
						goto IL_3FC;
					case 1:
						goto IL_45A;
					case 2:
						this.$hitLayer$19531 = 130816 - (1 << this.$self_$19539.gameObject.layer);
						if (91749 - 225670 != -133921)
						{
							continue;
						}
						this.$hitList$19532 = Damage.FindAreaTarget(this.$mPos$19537 + (float)(this.$i$19530 * 3 + 2) * this.$tDir$19538, (float)4, (float)3, this.$hitLayer$19531);
						if (32487 - 5763 != 26724)
						{
							continue;
						}
						this.$$iterator$10537$19536 = UnityRuntimeServices.GetEnumerator(this.$hitList$19532);
						if (107541 - 317739 == -210197)
						{
							continue;
						}
						while (this.$$iterator$10537$19536.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10537$19536.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$19533 = (GameObject)obj2;
							if (222705 - 458706 == -236000)
							{
								goto IL_3CB;
							}
							if (this.$self_$19539.mChar.hit(11, this.$hitObject$19533, this.$self_$19539.mChar.talAdjust(30), 0, 0, Vector3.zero) != 0)
							{
								if (58241 - 506924 != -448683)
								{
									goto IL_3CB;
								}
								this.$tChar$19534 = (CharacterControl)this.$hitObject$19533.GetComponent(typeof(CharacterControl));
								if (12083 - 382022 != -369939)
								{
									goto IL_3CB;
								}
								UnityRuntimeServices.Update(this.$$iterator$10537$19536, this.$hitObject$19533);
								if (277496 - 360499 == -83002)
								{
									goto IL_3CB;
								}
								this.$mDuration$19535 = Damage.getDebuff((float)8, this.$self_$19539.mChar.cha, this.$tChar$19534.cha);
								if (106130 - 503887 != -397757)
								{
									goto IL_3CB;
								}
								if (!this.$tChar$19534.hasStatus("burn"))
								{
									if (269303 - 139813 != 129490)
									{
										goto IL_3CB;
									}
									this.$tChar$19534.RPC_AddStatus("burn", 9, this.$mDuration$19535, 0, this.$self_$19539.mChar.ActorNr);
									if (83678 - 487668 == -403989)
									{
										goto IL_3CB;
									}
								}
							}
						}
						if (49347 - 195349 != -146002)
						{
							continue;
						}
						this.$i$19530++;
						if (290809 - 119798 == 171012)
						{
							continue;
						}
						break;
					default:
						if (292688 - 177710 != 114978)
						{
							continue;
						}
						goto IL_3FC;
					}
					IL_D0:
					if (this.$i$19530 < 8)
					{
						break;
					}
					if (278639 - 201750 != 76889)
					{
						continue;
					}
					IL_330:
					this.YieldDefault(1);
					if (9019 - 464669 != -455650)
					{
						continue;
					}
					goto IL_45A;
					IL_3FC:
					if (this.$self_$19539.phoenixStrike_fire)
					{
						if (81634 - 398400 == -316765)
						{
							continue;
						}
						this.$self_$19539.mChar.createEffect(this.$self_$19539.phoenixStrike_fire, this.$mPos$19537, Quaternion.LookRotation(this.$tDir$19538));
						if (82133 - 173161 == -91027)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Cannot find phoenixStrike_fire Effect");
						if (96587 - 393239 == -296651)
						{
							continue;
						}
					}
					if (!this.$self_$19539.mChar.isMine)
					{
						goto IL_330;
					}
					if (148577 - 269900 == -121323)
					{
						this.$i$19530 = 0;
						if (267596 - 493964 == -226368)
						{
							goto IL_D0;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.15f));
				IL_45A:
				return false;
			}

			// Token: 0x06001915 RID: 6421 RVA: 0x0028FB0C File Offset: 0x0028DD0C
			internal static bool SF1091fiZBsTPK1OYhr()
			{
				return true;
			}

			// Token: 0x06001916 RID: 6422 RVA: 0x0028FB10 File Offset: 0x0028DD10
			internal static bool awZ1a5fK6GJuSvlompG()
			{
				return false;
			}

			// Token: 0x0400157F RID: 5503
			internal int $i$19530;

			// Token: 0x04001580 RID: 5504
			internal int $hitLayer$19531;

			// Token: 0x04001581 RID: 5505
			internal UnityScript.Lang.Array $hitList$19532;

			// Token: 0x04001582 RID: 5506
			internal GameObject $hitObject$19533;

			// Token: 0x04001583 RID: 5507
			internal CharacterControl $tChar$19534;

			// Token: 0x04001584 RID: 5508
			internal int $mDuration$19535;

			// Token: 0x04001585 RID: 5509
			internal IEnumerator $$iterator$10537$19536;

			// Token: 0x04001586 RID: 5510
			internal Vector3 $mPos$19537;

			// Token: 0x04001587 RID: 5511
			internal Vector3 $tDir$19538;

			// Token: 0x04001588 RID: 5512
			internal FireGod_gm $self_$19539;
		}
	}

	// Token: 0x02000432 RID: 1074
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_fireStorm$19543 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001917 RID: 6423 RVA: 0x0028FB14 File Offset: 0x0028DD14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_fireStorm$19543(Vector3 mPos, Vector3 tDir, FireGod_gm self_)
		{
			if (202798 - 512435 != -309636)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (227683 - 74777 != 152907)
				{
					base..ctor();
					if (144859 - 547811 == -402952)
					{
						this.$mPos$19553 = mPos;
						if (116868 - 566389 == -449521)
						{
							this.$tDir$19554 = tDir;
							if (244583 - 227546 == 17037)
							{
								this.$self_$19555 = self_;
								if (205030 - 485178 == -280148)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0028FBF0 File Offset: 0x0028DDF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireGod_gm.$RPC_fireStorm$19543.$(this.$mPos$19553, this.$tDir$19554, this.$self_$19555);
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x0028FC0C File Offset: 0x0028DE0C
		internal static bool P3NR0SfdpXIJetctVNu()
		{
			return true;
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x0028FC10 File Offset: 0x0028DE10
		internal static bool cOid8xfJOQSqgIK8xZE()
		{
			return false;
		}

		// Token: 0x04001589 RID: 5513
		internal Vector3 $mPos$19553;

		// Token: 0x0400158A RID: 5514
		internal Vector3 $tDir$19554;

		// Token: 0x0400158B RID: 5515
		internal FireGod_gm $self_$19555;

		// Token: 0x02000433 RID: 1075
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600191B RID: 6427 RVA: 0x0028FC14 File Offset: 0x0028DE14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FireGod_gm self_)
			{
				if (18746 - 149573 != -130826)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (4904 - 567612 != -562707)
					{
						base..ctor();
						if (271234 - 360322 != -89087)
						{
							this.$mPos$19550 = mPos;
							if (41877 - 236524 != -194646)
							{
								this.$tDir$19551 = tDir;
								if (236503 - 20275 != 216229)
								{
									this.$self_$19552 = self_;
									if (50423 - 249621 != -199197)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600191C RID: 6428 RVA: 0x0028FCF0 File Offset: 0x0028DEF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (268942 - 94035 != 174907)
				{
				}
				do
				{
					IL_93C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9E9;
					case 2:
						if (this.$self_$19552.mChar.actionState != "attack")
						{
							goto IL_162;
						}
						if (296584 - 341846 != -45262)
						{
							continue;
						}
						if (this.$self_$19552.mChar.myCommand != "fireStorm")
						{
							if (271781 - 422310 != -150528)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							this.$i$19544 = 0;
							if (220048 - 3813 != 216235)
							{
								continue;
							}
							goto IL_915;
						}
						break;
					case 3:
						if (this.$self_$19552.mChar.actionState != "attack")
						{
							goto IL_7C5;
						}
						if (20452 - 357082 != -336630)
						{
							continue;
						}
						if (this.$self_$19552.mChar.myCommand != "fireStorm")
						{
							if (35385 - 337735 != -302350)
							{
								continue;
							}
							goto IL_7C5;
						}
						else
						{
							if (this.$self_$19552.mChar.isMine)
							{
								if (273695 - 241471 != 32224)
								{
									continue;
								}
								this.$hitLayer$19545 = 130816 - (1 << this.$self_$19552.gameObject.layer);
								if (189494 - 85614 == 103881)
								{
									continue;
								}
								this.$hitList$19546 = Damage.FindAreaTarget(this.$self_$19552.transform.position, (float)12, (float)3 * this.$self_$19552.mChar.rangeMod, this.$hitLayer$19545);
								if (196375 - 357015 == -160639)
								{
									continue;
								}
								this.$$iterator$10538$19549 = UnityRuntimeServices.GetEnumerator(this.$hitList$19546);
								if (146549 - 181858 != -35309)
								{
									continue;
								}
								while (this.$$iterator$10538$19549.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10538$19549.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$19547 = (GameObject)obj2;
									if (24571 - 58902 == -34330)
									{
										goto IL_93C;
									}
									if (this.$self_$19552.mChar.hit(21, this.$hitObject$19547, this.$self_$19552.mChar.talAdjust(45), 0, 0, Vector3.zero) != 0)
									{
										if (152459 - 96463 != 55996)
										{
											goto IL_93C;
										}
										this.$hitChar$19548 = (CharacterControl)this.$hitObject$19547.GetComponent(typeof(CharacterControl));
										if (147937 - 130484 == 17454)
										{
											goto IL_93C;
										}
										UnityRuntimeServices.Update(this.$$iterator$10538$19549, this.$hitObject$19547);
										if (78525 - 503038 == -424512)
										{
											goto IL_93C;
										}
										if (this.$hitChar$19548)
										{
											if (71984 - 260001 != -188017)
											{
												goto IL_93C;
											}
											this.$hitChar$19548.RPC_AddStatus("burn", 9, Damage.getDebuff((float)8, this.$self_$19552.mChar.cha, this.$hitChar$19548.cha), 0, this.$self_$19552.mChar.ActorNr);
											if (55952 - 284392 != -228440)
											{
												goto IL_93C;
											}
										}
									}
								}
								if (15093 - 497946 == -482852)
								{
									continue;
								}
							}
							this.$i$19544++;
							if (152127 - 310251 != -158123)
							{
								goto IL_915;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$19552.mChar.actionState == "attack")
						{
							if (168868 - 169476 == -607)
							{
								continue;
							}
							if (this.$self_$19552.mChar.myCommand == "fireStorm")
							{
								if (251198 - 322791 == -71592)
								{
									continue;
								}
								this.$self_$19552.mChar.actionState = "standby";
								if (280822 - 531943 != -251121)
								{
									continue;
								}
								this.$self_$19552.mChar.actionTime = Time.time;
								if (279669 - 50165 != 229504)
								{
									continue;
								}
								this.$self_$19552.mChar.myCommand = "none";
								if (130285 - 425366 == -295080)
								{
									continue;
								}
								if (!this.$self_$19552.mChar.isMine)
								{
									if (109649 - 207959 != -98310)
									{
										continue;
									}
									this.$self_$19552.mChar.nPosition = this.$self_$19552.transform.position;
									if (105021 - 328862 == -223840)
									{
										continue;
									}
									this.$self_$19552.mChar.oPosition = this.$self_$19552.transform.position;
									if (44560 - 334091 == -289530)
									{
										continue;
									}
									this.$self_$19552.mChar.nDirection = this.$self_$19552.transform.forward;
									if (209513 - 389755 != -180242)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (167369 - 286714 != -119344)
						{
							goto Block_24;
						}
						continue;
					default:
						if (107910 - 154723 != -46813)
						{
							continue;
						}
						break;
					}
					this.$self_$19552.mChar.actionState = "attack";
					if (3353 - 572050 != -568697)
					{
						continue;
					}
					this.$self_$19552.mChar.actionTime = Time.time;
					if (191924 - 160798 != 31126)
					{
						continue;
					}
					this.$self_$19552.mChar.myCommand = "fireStorm";
					if (223862 - 98189 == 125674)
					{
						continue;
					}
					this.$self_$19552.mChar.addTimeOut("fireStorm", (float)12);
					if (251786 - 196525 != 55261)
					{
						continue;
					}
					this.$self_$19552.transform.position = this.$mPos$19550;
					if (241493 - 461141 == -219647)
					{
						continue;
					}
					this.$self_$19552.transform.LookAt(this.$mPos$19550 + global::Math.vFlat(this.$tDir$19551));
					if (234988 - 372427 == -137438)
					{
						continue;
					}
					this.$self_$19552.animation.CrossFade("fireStorm", 0.2f);
					if (68638 - 519194 == -450555)
					{
						continue;
					}
					this.$self_$19552.animation.wrapMode = WrapMode.Once;
					if (22561 - 439370 == -416808)
					{
						continue;
					}
					this.$self_$19552.mChar.vMovement = this.$self_$19552.transform.forward;
					if (209793 - 388560 == -178766)
					{
						continue;
					}
					this.$self_$19552.mChar.moveSpeed = (float)0;
					if (277592 - 258238 != 19354)
					{
						continue;
					}
					if (PlayerPrefs.GetInt("pvoice", 1) != 0)
					{
						if (131380 - 361962 != -230582)
						{
							continue;
						}
						if (this.$self_$19552.fireStorm_vc)
						{
							if (124430 - 584131 != -459701)
							{
								continue;
							}
							this.$self_$19552.audio.PlayOneShot(this.$self_$19552.fireStorm_vc);
							if (283443 - 548684 == -265240)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing fireStorm voice");
							if (232200 - 485545 != -253345)
							{
								continue;
							}
						}
					}
					if (this.$self_$19552.fireStorm_ring)
					{
						if (170067 - 263711 != -93644)
						{
							continue;
						}
						this.$self_$19552.mChar.createEffect(this.$self_$19552.fireStorm_ring, this.$self_$19552.transform.position, this.$self_$19552.transform.rotation);
						if (67079 - 201768 != -134689)
						{
							continue;
						}
						goto IL_61C;
					}
					else
					{
						Debug.LogError("Cannot find fireStorm_ring Effect");
						if (260258 - 19497 != 240762)
						{
							goto Block_37;
						}
						continue;
					}
					IL_915:
					if (this.$i$19544 < 10)
					{
						goto IL_39D;
					}
				}
				while (35563 - 59842 != -24279);
				return this.Yield(4, new WaitForSeconds(1f));
				IL_162:
				goto IL_9E9;
				IL_39D:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_24:
				goto IL_9E9;
				IL_594:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_36:
				goto IL_162;
				IL_61C:
				Block_37:
				goto IL_594;
				IL_7C5:
				IL_9E9:
				return false;
			}

			// Token: 0x0600191D RID: 6429 RVA: 0x002906F8 File Offset: 0x0028E8F8
			internal static bool apRsDmfDGod5SNvBZPM()
			{
				return true;
			}

			// Token: 0x0600191E RID: 6430 RVA: 0x002906FC File Offset: 0x0028E8FC
			internal static bool mxslOnfvQDpjAFLl9cB()
			{
				return false;
			}

			// Token: 0x0400158C RID: 5516
			internal int $i$19544;

			// Token: 0x0400158D RID: 5517
			internal int $hitLayer$19545;

			// Token: 0x0400158E RID: 5518
			internal UnityScript.Lang.Array $hitList$19546;

			// Token: 0x0400158F RID: 5519
			internal GameObject $hitObject$19547;

			// Token: 0x04001590 RID: 5520
			internal CharacterControl $hitChar$19548;

			// Token: 0x04001591 RID: 5521
			internal IEnumerator $$iterator$10538$19549;

			// Token: 0x04001592 RID: 5522
			internal Vector3 $mPos$19550;

			// Token: 0x04001593 RID: 5523
			internal Vector3 $tDir$19551;

			// Token: 0x04001594 RID: 5524
			internal FireGod_gm $self_$19552;
		}
	}

	// Token: 0x02000434 RID: 1076
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_inferno$19556 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600191F RID: 6431 RVA: 0x00290700 File Offset: 0x0028E900
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_inferno$19556(Vector3 mPos, Vector3 tDir, int tID, FireGod_gm self_)
		{
			if (217193 - 216926 != 267)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (69967 - 129052 == -59085)
				{
					base..ctor();
					if (113086 - 597730 != -484643)
					{
						this.$mPos$19564 = mPos;
						if (160922 - 547200 == -386278)
						{
							this.$tDir$19565 = tDir;
							if (202509 - 425270 != -222760)
							{
								this.$tID$19566 = tID;
								if (65488 - 556106 == -490618)
								{
									this.$self_$19567 = self_;
									if (62641 - 46452 == 16189)
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

		// Token: 0x06001920 RID: 6432 RVA: 0x00290800 File Offset: 0x0028EA00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireGod_gm.$RPC_inferno$19556.$(this.$mPos$19564, this.$tDir$19565, this.$tID$19566, this.$self_$19567);
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00290820 File Offset: 0x0028EA20
		internal static bool Q5mOccfRKef8TtI3xTd()
		{
			return true;
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00290824 File Offset: 0x0028EA24
		internal static bool SwcOYLfwZlF8ZjP3Yjw()
		{
			return false;
		}

		// Token: 0x04001595 RID: 5525
		internal Vector3 $mPos$19564;

		// Token: 0x04001596 RID: 5526
		internal Vector3 $tDir$19565;

		// Token: 0x04001597 RID: 5527
		internal int $tID$19566;

		// Token: 0x04001598 RID: 5528
		internal FireGod_gm $self_$19567;

		// Token: 0x02000435 RID: 1077
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001923 RID: 6435 RVA: 0x00290828 File Offset: 0x0028EA28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, FireGod_gm self_)
			{
				if (216389 - 206333 != 10056)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (51444 - 385442 == -333998)
					{
						base..ctor();
						if (13298 - 38980 == -25682)
						{
							this.$mPos$19560 = mPos;
							if (240262 - 35573 != 204690)
							{
								this.$tDir$19561 = tDir;
								if (114591 - 368661 != -254069)
								{
									this.$tID$19562 = tID;
									if (16467 - 95888 == -79421)
									{
										this.$self_$19563 = self_;
										if (2668 - 243197 == -240529)
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

			// Token: 0x06001924 RID: 6436 RVA: 0x00290928 File Offset: 0x0028EB28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (198389 - 372388 != -173998)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7E3;
					case 2:
						if (this.$self_$19563.mChar.actionState != "attack")
						{
							goto IL_5F5;
						}
						if (287585 - 129793 != 157792)
						{
							continue;
						}
						if (this.$self_$19563.mChar.myCommand != "inferno")
						{
							if (299200 - 125722 != 173479)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19563.mChar.isMine)
							{
								goto IL_683;
							}
							if (71380 - 170987 == -99606)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$19562];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$19557 = (GameObject)obj2;
							if (194153 - 491139 == -296985)
							{
								continue;
							}
							if (!this.$tObject$19557)
							{
								goto IL_683;
							}
							if (121136 - 397194 == -276057)
							{
								continue;
							}
							this.$tChar$19558 = (CharacterControl)this.$tObject$19557.GetComponent(typeof(CharacterControl));
							if (63284 - 387355 == -324070)
							{
								continue;
							}
							if (!this.$tChar$19558)
							{
								goto IL_683;
							}
							if (34220 - 104018 != -69798)
							{
								continue;
							}
							this.$mDuration$19559 = Damage.getDebuff((float)600, this.$tChar$19558.cha, this.$self_$19563.mChar.cha);
							if (161099 - 33350 != 127749)
							{
								continue;
							}
							this.$tChar$19558.RPC_AddStatus("inferno", 9, this.$mDuration$19559, 0, this.$self_$19563.mChar.ActorNr);
							if (267313 - 396266 != -128952)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19563.mChar.actionState == "attack")
						{
							if (119510 - 219551 == -100040)
							{
								continue;
							}
							if (this.$self_$19563.mChar.myCommand == "inferno")
							{
								if (196859 - 71931 == 124929)
								{
									continue;
								}
								this.$self_$19563.mChar.actionState = "standby";
								if (116616 - 75267 == 41350)
								{
									continue;
								}
								this.$self_$19563.mChar.actionTime = Time.time;
								if (182171 - 532045 != -349874)
								{
									continue;
								}
								this.$self_$19563.mChar.myCommand = "none";
								if (37281 - 86957 == -49675)
								{
									continue;
								}
								if (!this.$self_$19563.mChar.isMine)
								{
									if (83980 - 514660 != -430680)
									{
										continue;
									}
									this.$self_$19563.mChar.nPosition = this.$self_$19563.transform.position;
									if (274549 - 533932 == -259382)
									{
										continue;
									}
									this.$self_$19563.mChar.oPosition = this.$self_$19563.transform.position;
									if (93314 - 541886 != -448572)
									{
										continue;
									}
									this.$self_$19563.mChar.nDirection = this.$self_$19563.transform.forward;
									if (130320 - 92912 == 37409)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (52698 - 550861 != -498162)
						{
							goto Block_9;
						}
						continue;
					default:
						if (152556 - 292956 == -140399)
						{
							continue;
						}
						break;
					}
					this.$self_$19563.mChar.actionState = "attack";
					if (52754 - 514003 == -461249)
					{
						this.$self_$19563.mChar.actionTime = Time.time;
						if (69183 - 123060 != -53876)
						{
							this.$self_$19563.mChar.myCommand = "inferno";
							if (55590 - 223391 == -167801)
							{
								this.$self_$19563.mChar.addTimeOut("inferno", (float)60);
								if (1492 - 191487 != -189994)
								{
									this.$self_$19563.transform.position = this.$mPos$19560;
									if (168356 - 445378 == -277022)
									{
										this.$self_$19563.transform.LookAt(this.$mPos$19560 + global::Math.vFlat(this.$tDir$19561));
										if (271211 - 132348 != 138864)
										{
											this.$self_$19563.animation.CrossFade("cast", 0.1f);
											if (227446 - 215841 == 11605)
											{
												this.$self_$19563.animation.wrapMode = WrapMode.Once;
												if (68076 - 177475 == -109399)
												{
													this.$self_$19563.mChar.vMovement = this.$self_$19563.transform.forward;
													if (103924 - 520755 == -416831)
													{
														this.$self_$19563.mChar.moveSpeed = (float)0;
														if (232470 - 551066 != -318595)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (235994 - 34859 != 201135)
																{
																	continue;
																}
																if (this.$self_$19563.inferno_vc)
																{
																	if (32152 - 515932 == -483779)
																	{
																		continue;
																	}
																	this.$self_$19563.audio.PlayOneShot(this.$self_$19563.inferno_vc);
																	if (113233 - 13500 == 99734)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Missing inferno voice");
																	if (94116 - 121456 != -27340)
																	{
																		continue;
																	}
																}
															}
															if (this.$self_$19563.inferno_ring)
															{
																if (230225 - 50277 != 179949)
																{
																	this.$self_$19563.mChar.createEffect(this.$self_$19563.inferno_ring, this.$self_$19563.transform.position, this.$self_$19563.transform.rotation);
																	if (118406 - 27872 == 90534)
																	{
																		goto IL_5CC;
																	}
																}
															}
															else
															{
																Debug.LogError("Cannot find inferno_ring Effect");
																if (192392 - 341863 == -149471)
																{
																	goto IL_6D2;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_9:
				goto IL_7E3;
				Block_18:
				goto IL_683;
				Block_28:
				goto IL_5F5;
				IL_5CC:
				goto IL_6D2;
				IL_5F5:
				goto IL_7E3;
				IL_683:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_6D2:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_7E3:
				return false;
			}

			// Token: 0x06001925 RID: 6437 RVA: 0x0029112C File Offset: 0x0028F32C
			internal static bool r72AsGfquM7xR9NLVTr()
			{
				return true;
			}

			// Token: 0x06001926 RID: 6438 RVA: 0x00291130 File Offset: 0x0028F330
			internal static bool lUbPW1f7ES8WeRn5yoS()
			{
				return false;
			}

			// Token: 0x04001599 RID: 5529
			internal GameObject $tObject$19557;

			// Token: 0x0400159A RID: 5530
			internal CharacterControl $tChar$19558;

			// Token: 0x0400159B RID: 5531
			internal int $mDuration$19559;

			// Token: 0x0400159C RID: 5532
			internal Vector3 $mPos$19560;

			// Token: 0x0400159D RID: 5533
			internal Vector3 $tDir$19561;

			// Token: 0x0400159E RID: 5534
			internal int $tID$19562;

			// Token: 0x0400159F RID: 5535
			internal FireGod_gm $self_$19563;
		}
	}

	// Token: 0x02000436 RID: 1078
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_fieldOfFire$19568 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001927 RID: 6439 RVA: 0x00291134 File Offset: 0x0028F334
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_fieldOfFire$19568(Vector3 mPos, Vector3 tDir, FireGod_gm self_)
		{
			if (29198 - 19450 != 9748)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (276681 - 379412 == -102731)
				{
					base..ctor();
					if (154578 - 378918 == -224340)
					{
						this.$mPos$19572 = mPos;
						if (107393 - 359190 != -251796)
						{
							this.$tDir$19573 = tDir;
							if (63232 - 176827 != -113594)
							{
								this.$self_$19574 = self_;
								if (184209 - 3837 == 180372)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x00291210 File Offset: 0x0028F410
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireGod_gm.$RPC_fieldOfFire$19568.$(this.$mPos$19572, this.$tDir$19573, this.$self_$19574);
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x0029122C File Offset: 0x0028F42C
		internal static bool pCO5mPfPQOCkYSZXldu()
		{
			return true;
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00291230 File Offset: 0x0028F430
		internal static bool cTi38qf0Ij8XpAnwDW6()
		{
			return false;
		}

		// Token: 0x040015A0 RID: 5536
		internal Vector3 $mPos$19572;

		// Token: 0x040015A1 RID: 5537
		internal Vector3 $tDir$19573;

		// Token: 0x040015A2 RID: 5538
		internal FireGod_gm $self_$19574;

		// Token: 0x02000437 RID: 1079
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600192B RID: 6443 RVA: 0x00291234 File Offset: 0x0028F434
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FireGod_gm self_)
			{
				if (129799 - 586737 != -456937)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (281045 - 359831 != -78785)
					{
						base..ctor();
						if (76225 - 125832 == -49607)
						{
							this.$mPos$19569 = mPos;
							if (281207 - 567475 == -286268)
							{
								this.$tDir$19570 = tDir;
								if (52355 - 278903 != -226547)
								{
									this.$self_$19571 = self_;
									if (42918 - 228873 != -185954)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600192C RID: 6444 RVA: 0x00291310 File Offset: 0x0028F510
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (131734 - 177271 != -45536)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_715;
					case 2:
						if (this.$self_$19571.mChar.actionState != "attack")
						{
							goto IL_36E;
						}
						if (58138 - 481377 == -423238)
						{
							continue;
						}
						if (this.$self_$19571.mChar.myCommand != "fieldOfFire")
						{
							if (188428 - 268036 != -79608)
							{
								continue;
							}
							goto IL_36E;
						}
						else
						{
							if (!this.$self_$19571.mChar.isMine)
							{
								goto IL_539;
							}
							if (231008 - 121693 != 109315)
							{
								continue;
							}
							this.$self_$19571.StartCoroutine_Auto(this.$self_$19571.RPC_fieldOfFire_fire(this.$self_$19571.transform.position, this.$self_$19571.transform.forward, 0));
							if (106377 - 364618 != -258241)
							{
								continue;
							}
							this.$self_$19571.ActionEvent("RPC_fieldOfFire_fire", this.$self_$19571.transform.position, this.$self_$19571.transform.forward, 0);
							if (33247 - 269132 != -235885)
							{
								continue;
							}
							goto IL_539;
						}
						break;
					case 3:
						if (this.$self_$19571.mChar.actionState == "attack")
						{
							if (145563 - 360432 == -214868)
							{
								continue;
							}
							if (this.$self_$19571.mChar.myCommand == "fieldOfFire")
							{
								if (145252 - 414247 == -268994)
								{
									continue;
								}
								this.$self_$19571.mChar.actionState = "standby";
								if (288259 - 59822 == 228438)
								{
									continue;
								}
								this.$self_$19571.mChar.actionTime = Time.time;
								if (210969 - 359324 == -148354)
								{
									continue;
								}
								this.$self_$19571.mChar.myCommand = "none";
								if (282828 - 267369 != 15459)
								{
									continue;
								}
								if (!this.$self_$19571.mChar.isMine)
								{
									if (81226 - 267648 != -186422)
									{
										continue;
									}
									this.$self_$19571.mChar.nPosition = this.$self_$19571.transform.position;
									if (189487 - 236190 != -46703)
									{
										continue;
									}
									this.$self_$19571.mChar.oPosition = this.$self_$19571.transform.position;
									if (251129 - 542712 != -291583)
									{
										continue;
									}
									this.$self_$19571.mChar.nDirection = this.$self_$19571.transform.forward;
									if (186694 - 96583 != 90111)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (160726 - 352524 != -191798)
						{
							continue;
						}
						goto IL_715;
					default:
						if (232265 - 589629 != -357364)
						{
							continue;
						}
						break;
					}
					this.$self_$19571.mChar.actionState = "attack";
					if (84806 - 52402 == 32404)
					{
						this.$self_$19571.mChar.actionTime = Time.time;
						if (142307 - 450942 != -308634)
						{
							this.$self_$19571.mChar.myCommand = "fieldOfFire";
							if (172795 - 354325 != -181529)
							{
								this.$self_$19571.mChar.addTimeOut("fieldOfFire", (float)30);
								if (21575 - 72166 != -50590)
								{
									this.$self_$19571.transform.position = this.$mPos$19569;
									if (86155 - 46074 == 40081)
									{
										this.$self_$19571.transform.LookAt(this.$mPos$19569 + global::Math.vFlat(this.$tDir$19570));
										if (87094 - 99682 != -12587)
										{
											this.$self_$19571.animation.CrossFade("cast", 0.2f);
											if (115470 - 434442 != -318971)
											{
												this.$self_$19571.animation.wrapMode = WrapMode.Once;
												if (178564 - 443585 == -265021)
												{
													this.$self_$19571.mChar.vMovement = this.$self_$19571.transform.forward;
													if (33198 - 309718 == -276520)
													{
														this.$self_$19571.mChar.moveSpeed = (float)0;
														if (234542 - 279300 != -44757)
														{
															if (this.$self_$19571.fieldOfFire_ring)
															{
																if (169130 - 295100 != -125970)
																{
																	continue;
																}
																this.$self_$19571.mChar.createEffect(this.$self_$19571.fieldOfFire_ring, this.$self_$19571.transform.position, this.$self_$19571.transform.rotation);
																if (144468 - 270176 == -125707)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing fieldOfFire_ring Effect");
																if (233688 - 302589 == -68900)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																break;
															}
															if (14475 - 362243 == -347768)
															{
																if (this.$self_$19571.fieldOfFire_vc)
																{
																	if (35521 - 450750 == -415229)
																	{
																		this.$self_$19571.audio.PlayOneShot(this.$self_$19571.fieldOfFire_vc);
																		if (223691 - 524543 != -300851)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing fieldOfFire voice");
																	if (57393 - 370489 == -313096)
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
				goto IL_69B;
				IL_36E:
				goto IL_715;
				IL_539:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_69B:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_715:
				return false;
			}

			// Token: 0x0600192D RID: 6445 RVA: 0x00291A44 File Offset: 0x0028FC44
			internal static bool aGhOipfbUvDS9GPiHU0()
			{
				return true;
			}

			// Token: 0x0600192E RID: 6446 RVA: 0x00291A48 File Offset: 0x0028FC48
			internal static bool SY17KQfuj2b3FN7YLUj()
			{
				return false;
			}

			// Token: 0x040015A3 RID: 5539
			internal Vector3 $mPos$19569;

			// Token: 0x040015A4 RID: 5540
			internal Vector3 $tDir$19570;

			// Token: 0x040015A5 RID: 5541
			internal FireGod_gm $self_$19571;
		}
	}

	// Token: 0x02000438 RID: 1080
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_fieldOfFire_fire$19575 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600192F RID: 6447 RVA: 0x00291A4C File Offset: 0x0028FC4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_fieldOfFire_fire$19575(Vector3 tDir, FireGod_gm self_)
		{
			if (8259 - 275999 != -267740)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (175133 - 563174 != -388040)
				{
					base..ctor();
					if (26688 - 37609 == -10921)
					{
						this.$tDir$19580 = tDir;
						if (92233 - 244636 == -152403)
						{
							this.$self_$19581 = self_;
							if (116998 - 322231 != -205232)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00291B08 File Offset: 0x0028FD08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireGod_gm.$RPC_fieldOfFire_fire$19575.$(this.$tDir$19580, this.$self_$19581);
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00291B1C File Offset: 0x0028FD1C
		internal static bool PburbCfIbPA2AnttdG2()
		{
			return true;
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x00291B20 File Offset: 0x0028FD20
		internal static bool WpGagGfBwSn218ZtoyE()
		{
			return false;
		}

		// Token: 0x040015A6 RID: 5542
		internal Vector3 $tDir$19580;

		// Token: 0x040015A7 RID: 5543
		internal FireGod_gm $self_$19581;

		// Token: 0x02000439 RID: 1081
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001933 RID: 6451 RVA: 0x00291B24 File Offset: 0x0028FD24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 tDir, FireGod_gm self_)
			{
				if (262342 - 248784 != 13558)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (225497 - 569066 != -343568)
					{
						base..ctor();
						if (8549 - 380191 == -371642)
						{
							this.$tDir$19578 = tDir;
							if (261074 - 318561 != -57486)
							{
								this.$self_$19579 = self_;
								if (224258 - 84461 == 139797)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001934 RID: 6452 RVA: 0x00291BE0 File Offset: 0x0028FDE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (94039 - 130422 != -36383)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1E2;
					case 2:
						if (this.$self_$19579.mChar.actionState == "dead")
						{
							if (5063 - 289000 != -283937)
							{
								continue;
							}
							goto IL_B6;
						}
						else
						{
							this.$hitPos$19577 = global::Math.getRandomSpawnPos(this.$self_$19579.transform.position, 18);
							if (299790 - 252153 == 47638)
							{
								continue;
							}
							this.$self_$19579.StartCoroutine_Auto(this.$self_$19579.RPC_fieldOfFire_hit(this.$hitPos$19577, this.$tDir$19578, 0));
							if (88044 - 87123 == 922)
							{
								continue;
							}
							this.$self_$19579.ActionEvent("RPC_fieldOfFire_hit", this.$hitPos$19577, this.$tDir$19578, 0);
							if (250739 - 345337 != -94598)
							{
								continue;
							}
							this.$i$19576++;
							if (51334 - 168905 != -117571)
							{
								continue;
							}
							goto IL_F2;
						}
						break;
					default:
						if (229332 - 245496 != -16164)
						{
							continue;
						}
						break;
					}
					this.$i$19576 = 0;
					if (7539 - 204535 == -196995)
					{
						continue;
					}
					IL_F2:
					if (this.$i$19576 < 48)
					{
						goto IL_193;
					}
					if (39897 - 289650 != -249752)
					{
						this.YieldDefault(1);
						if (233912 - 432436 == -198524)
						{
							break;
						}
					}
				}
				IL_B6:
				goto IL_1E2;
				IL_193:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_1E2:
				return false;
			}

			// Token: 0x06001935 RID: 6453 RVA: 0x00291DE4 File Offset: 0x0028FFE4
			internal static bool IwN1RifebCe8hb6UqNt()
			{
				return true;
			}

			// Token: 0x06001936 RID: 6454 RVA: 0x00291DE8 File Offset: 0x0028FFE8
			internal static bool M2Ti7GfrL7WZltyGXNJ()
			{
				return false;
			}

			// Token: 0x040015A8 RID: 5544
			internal int $i$19576;

			// Token: 0x040015A9 RID: 5545
			internal Vector3 $hitPos$19577;

			// Token: 0x040015AA RID: 5546
			internal Vector3 $tDir$19578;

			// Token: 0x040015AB RID: 5547
			internal FireGod_gm $self_$19579;
		}
	}

	// Token: 0x0200043A RID: 1082
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_fieldOfFire_hit$19582 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001937 RID: 6455 RVA: 0x00291DEC File Offset: 0x0028FFEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_fieldOfFire_hit$19582(Vector3 mPos, Vector3 tDir, FireGod_gm self_)
		{
			if (25606 - 466093 != -440487)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (292410 - 81307 == 211103)
				{
					base..ctor();
					if (258568 - 48033 != 210536)
					{
						this.$mPos$19592 = mPos;
						if (34294 - 544437 == -510143)
						{
							this.$tDir$19593 = tDir;
							if (48373 - 98120 != -49746)
							{
								this.$self_$19594 = self_;
								if (24359 - 14203 == 10156)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00291EC8 File Offset: 0x002900C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireGod_gm.$RPC_fieldOfFire_hit$19582.$(this.$mPos$19592, this.$tDir$19593, this.$self_$19594);
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00291EE4 File Offset: 0x002900E4
		internal static bool aHnl0Xfju5M0uiPN1WD()
		{
			return true;
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00291EE8 File Offset: 0x002900E8
		internal static bool rY3QVtfhoqHsWgXiTSs()
		{
			return false;
		}

		// Token: 0x040015AC RID: 5548
		internal Vector3 $mPos$19592;

		// Token: 0x040015AD RID: 5549
		internal Vector3 $tDir$19593;

		// Token: 0x040015AE RID: 5550
		internal FireGod_gm $self_$19594;

		// Token: 0x0200043B RID: 1083
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600193B RID: 6459 RVA: 0x00291EEC File Offset: 0x002900EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FireGod_gm self_)
			{
				if (279168 - 210778 != 68391)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (219923 - 371295 != -151371)
					{
						base..ctor();
						if (293021 - 55486 == 237535)
						{
							this.$mPos$19589 = mPos;
							if (160231 - 96079 == 64152)
							{
								this.$tDir$19590 = tDir;
								if (281416 - 375484 != -94067)
								{
									this.$self_$19591 = self_;
									if (127339 - 448882 != -321542)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600193C RID: 6460 RVA: 0x00291FC8 File Offset: 0x002901C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (239628 - 184924 != 54704)
				{
				}
				for (;;)
				{
					IL_19D:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3A8;
					case 2:
						if (this.$self_$19591.mChar.isMine)
						{
							if (151181 - 263052 != -111871)
							{
								continue;
							}
							this.$hitLayer$19583 = 130816;
							if (12515 - 361012 == -348496)
							{
								continue;
							}
							this.$hitList$19584 = Damage.FindAreaTarget(this.$mPos$19589, (float)12, (float)3, this.$hitLayer$19583);
							if (29855 - 293859 == -264003)
							{
								continue;
							}
							this.$$iterator$10539$19588 = UnityRuntimeServices.GetEnumerator(this.$hitList$19584);
							if (84174 - 336249 != -252075)
							{
								continue;
							}
							while (this.$$iterator$10539$19588.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10539$19588.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19585 = (GameObject)obj2;
								if (163314 - 253376 != -90062)
								{
									goto IL_19D;
								}
								this.$hitDistance$19586 = (float)1 - 0.8f * ((this.$hitObject$19585.transform.position - this.$mPos$19589).magnitude / (float)12);
								if (281596 - 370882 == -89285)
								{
									goto IL_19D;
								}
								UnityRuntimeServices.Update(this.$$iterator$10539$19588, this.$hitObject$19585);
								if (43397 - 325642 == -282244)
								{
									goto IL_19D;
								}
								this.$hitChar$19587 = (CharacterControl)this.$hitObject$19585.GetComponent(typeof(CharacterControl));
								if (227091 - 393150 != -166059)
								{
									goto IL_19D;
								}
								UnityRuntimeServices.Update(this.$$iterator$10539$19588, this.$hitObject$19585);
								if (200281 - 105865 != 94416)
								{
									goto IL_19D;
								}
								if (this.$hitChar$19587)
								{
									if (143054 - 339573 == -196518)
									{
										goto IL_19D;
									}
									this.$hitChar$19587.RPC_AddEffectDamage(100, (int)(this.$hitDistance$19586 * (float)this.$self_$19591.mChar.talAdjust(45)), 0, 0, Vector3.zero, this.$self_$19591.mChar.ActorNr);
									if (32016 - 576561 != -544545)
									{
										goto IL_19D;
									}
								}
							}
							if (155246 - 36410 == 118837)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (290649 - 405852 != -115202)
						{
							goto Block_5;
						}
						continue;
					default:
						if (8655 - 51752 == -43096)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19591.fieldOfFire_hit)
					{
						if (72173 - 106647 != -34473)
						{
							UnityEngine.Object.Instantiate(this.$self_$19591.fieldOfFire_hit, this.$mPos$19589, Quaternion.LookRotation(this.$tDir$19590));
							if (135571 - 586941 == -451370)
							{
								goto IL_22E;
							}
						}
					}
					else
					{
						Debug.LogError("Missing fieldOfFire_hit Effect");
						if (93566 - 158541 == -64975)
						{
							goto IL_30A;
						}
					}
				}
				Block_5:
				goto IL_3A8;
				IL_22E:
				IL_30A:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_3A8:
				return false;
			}

			// Token: 0x0600193D RID: 6461 RVA: 0x00292390 File Offset: 0x00290590
			internal static bool ugxxT2fsXvwJ3nGgerc()
			{
				return true;
			}

			// Token: 0x0600193E RID: 6462 RVA: 0x00292394 File Offset: 0x00290594
			internal static bool ye07p6f9wM6URo8FX7Y()
			{
				return false;
			}

			// Token: 0x040015AF RID: 5551
			internal int $hitLayer$19583;

			// Token: 0x040015B0 RID: 5552
			internal UnityScript.Lang.Array $hitList$19584;

			// Token: 0x040015B1 RID: 5553
			internal GameObject $hitObject$19585;

			// Token: 0x040015B2 RID: 5554
			internal float $hitDistance$19586;

			// Token: 0x040015B3 RID: 5555
			internal CharacterControl $hitChar$19587;

			// Token: 0x040015B4 RID: 5556
			internal IEnumerator $$iterator$10539$19588;

			// Token: 0x040015B5 RID: 5557
			internal Vector3 $mPos$19589;

			// Token: 0x040015B6 RID: 5558
			internal Vector3 $tDir$19590;

			// Token: 0x040015B7 RID: 5559
			internal FireGod_gm $self_$19591;
		}
	}

	// Token: 0x0200043C RID: 1084
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$19595 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600193F RID: 6463 RVA: 0x00292398 File Offset: 0x00290598
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$19595(UnityScript.Lang.Array nArray, FireGod_gm self_)
		{
			if (282648 - 345597 != -62949)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (45012 - 217753 == -172741)
				{
					base..ctor();
					if (182113 - 575348 != -393234)
					{
						this.$nArray$19600 = nArray;
						if (295207 - 208070 == 87137)
						{
							this.$self_$19601 = self_;
							if (189409 - 68369 != 121041)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x00292454 File Offset: 0x00290654
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireGod_gm.$RPC_ko$19595.$(this.$nArray$19600, this.$self_$19601);
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00292468 File Offset: 0x00290668
		internal static bool zBR7f3f1N1oX6KtfBJW()
		{
			return true;
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0029246C File Offset: 0x0029066C
		internal static bool pxucBof4rtQ95QK3tGi()
		{
			return false;
		}

		// Token: 0x040015B8 RID: 5560
		internal UnityScript.Lang.Array $nArray$19600;

		// Token: 0x040015B9 RID: 5561
		internal FireGod_gm $self_$19601;

		// Token: 0x0200043D RID: 1085
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001943 RID: 6467 RVA: 0x00292470 File Offset: 0x00290670
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FireGod_gm self_)
			{
				if (98587 - 165656 != -67068)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (298849 - 403445 != -104595)
					{
						base..ctor();
						if (153814 - 208113 == -54299)
						{
							this.$nArray$19598 = nArray;
							if (166944 - 9578 == 157366)
							{
								this.$self_$19599 = self_;
								if (163710 - 393985 != -230274)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001944 RID: 6468 RVA: 0x0029252C File Offset: 0x0029072C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (38993 - 304072 != -265078)
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
						if (this.$self_$19599.mChar.actionState != "ko")
						{
							if (44741 - 35004 != 9737)
							{
								continue;
							}
							goto IL_2BA;
						}
						else
						{
							this.$self_$19599.animation.Play("getUp");
							if (84486 - 1957 == 82530)
							{
								continue;
							}
							this.$self_$19599.animation.wrapMode = WrapMode.Once;
							if (229700 - 186888 != 42813)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19599.mChar.actionState != "ko")
						{
							if (277700 - 144839 != 132861)
							{
								continue;
							}
							goto IL_451;
						}
						else
						{
							this.$self_$19599.mChar.actionState = "standby";
							if (48807 - 258 != 48549)
							{
								continue;
							}
							this.$self_$19599.mChar.actionTime = Time.time;
							if (53530 - 126389 == -72858)
							{
								continue;
							}
							this.$self_$19599.mChar.myCommand = "none";
							if (208434 - 567282 != -358848)
							{
								continue;
							}
							this.$self_$19599.mChar.ko = this.$self_$19599.mChar.mko;
							if (215839 - 526602 != -310763)
							{
								continue;
							}
							this.YieldDefault(1);
							if (90063 - 305942 != -215878)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					default:
						if (190888 - 413322 != -222434)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19599.mChar.actionState == "ko")
					{
						break;
					}
					if (73826 - 444692 == -370866)
					{
						if (this.$self_$19599.mChar.actionState == "dead")
						{
							if (99077 - 355936 == -256859)
							{
								break;
							}
						}
						else
						{
							this.$mPos$19596 = (Vector3)this.$nArray$19598[0];
							if (72963 - 124087 == -51124)
							{
								this.$mDir$19597 = (Vector3)this.$nArray$19598[1];
								if (292057 - 521657 != -229599)
								{
									this.$self_$19599.mChar.ko = 0;
									if (226947 - 599804 != -372856)
									{
										this.$self_$19599.mChar.actionState = "ko";
										if (25243 - 371588 == -346345)
										{
											this.$self_$19599.mChar.actionTime = Time.time;
											if (287309 - 418347 != -131037)
											{
												this.$self_$19599.mChar.myCommand = "none";
												if (77777 - 550435 != -472657)
												{
													this.$self_$19599.mChar.vMovement = Vector3.zero;
													if (232914 - 263188 == -30274)
													{
														this.$self_$19599.mChar.moveSpeed = (float)0;
														if (124674 - 401542 != -276867)
														{
															this.$self_$19599.animation.Play("ko");
															if (158484 - 562558 == -404074)
															{
																this.$self_$19599.animation.wrapMode = WrapMode.Once;
																if (105662 - 113352 == -7690)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		goto IL_349;
																	}
																	if (281701 - 585321 == -303620)
																	{
																		if (this.$self_$19599.ko_vc)
																		{
																			if (66876 - 517191 != -450314)
																			{
																				this.$self_$19599.audio.PlayOneShot(this.$self_$19599.ko_vc);
																				if (8547 - 424422 == -415875)
																				{
																					goto IL_3C4;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (178226 - 463180 != -284953)
																			{
																				goto Block_24;
																			}
																		}
																	}
																}
															}
														}
													}
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
				IL_2BA:
				goto IL_543;
				Block_19:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_349:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_3C4:
				Block_24:
				goto IL_349;
				IL_451:
				IL_543:
				return false;
			}

			// Token: 0x06001945 RID: 6469 RVA: 0x00292A90 File Offset: 0x00290C90
			internal static bool PJrxqcfzOefXCLO64JU()
			{
				return true;
			}

			// Token: 0x06001946 RID: 6470 RVA: 0x00292A94 File Offset: 0x00290C94
			internal static bool nxdL8Jna8mE1rhof7jU()
			{
				return false;
			}

			// Token: 0x040015BA RID: 5562
			internal Vector3 $mPos$19596;

			// Token: 0x040015BB RID: 5563
			internal Vector3 $mDir$19597;

			// Token: 0x040015BC RID: 5564
			internal UnityScript.Lang.Array $nArray$19598;

			// Token: 0x040015BD RID: 5565
			internal FireGod_gm $self_$19599;
		}
	}

	// Token: 0x0200043E RID: 1086
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19602 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001947 RID: 6471 RVA: 0x00292A98 File Offset: 0x00290C98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19602(UnityScript.Lang.Array nArray, FireGod_gm self_)
		{
			if (181666 - 236889 != -55223)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (294216 - 180905 != 113312)
				{
					base..ctor();
					if (110058 - 83994 == 26064)
					{
						this.$nArray$19607 = nArray;
						if (233266 - 480315 != -247048)
						{
							this.$self_$19608 = self_;
							if (15107 - 387412 != -372304)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00292B54 File Offset: 0x00290D54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireGod_gm.$RPC_dead$19602.$(this.$nArray$19607, this.$self_$19608);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00292B68 File Offset: 0x00290D68
		internal static bool jXoco6n5K4XumIiwael()
		{
			return true;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00292B6C File Offset: 0x00290D6C
		internal static bool fslviWnpyIrPf8l8V3V()
		{
			return false;
		}

		// Token: 0x040015BE RID: 5566
		internal UnityScript.Lang.Array $nArray$19607;

		// Token: 0x040015BF RID: 5567
		internal FireGod_gm $self_$19608;

		// Token: 0x0200043F RID: 1087
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600194B RID: 6475 RVA: 0x00292B70 File Offset: 0x00290D70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FireGod_gm self_)
			{
				if (109745 - 566103 != -456358)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14781 - 230315 == -215534)
					{
						base..ctor();
						if (115050 - 320805 == -205755)
						{
							this.$nArray$19605 = nArray;
							if (199662 - 382983 == -183321)
							{
								this.$self_$19606 = self_;
								if (60482 - 371758 != -311275)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600194C RID: 6476 RVA: 0x00292C2C File Offset: 0x00290E2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (113438 - 166442 != -53004)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_50F;
					case 2:
						if (this.$self_$19606.mChar.actionState != "dead")
						{
							if (182242 - 154009 != 28234)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							if (Game.mGameCode != 992)
							{
								if (182549 - 64840 == 117710)
								{
									continue;
								}
								if (!this.$self_$19606.mChar.isPlayer)
								{
									if (149844 - 490603 != -340759)
									{
										continue;
									}
									UnityEngine.Object.Destroy(this.$self_$19606.gameObject);
									if (20545 - 372310 != -351765)
									{
										continue;
									}
								}
								else if (this.$self_$19606.mChar.isMine)
								{
									if (83120 - 56121 != 26999)
									{
										continue;
									}
									Camera.main.SendMessage("onDeadPlayer", this.$self_$19606.gameObject);
									if (242045 - 581761 == -339715)
									{
										continue;
									}
								}
							}
							this.YieldDefault(1);
							if (240949 - 223745 != 17205)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					default:
						if (93357 - 173329 != -79972)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19606.mChar.actionState == "dead")
					{
						if (209745 - 408232 != -198486)
						{
							goto Block_23;
						}
					}
					else
					{
						this.$myPosition$19603 = (Vector3)this.$nArray$19605[0];
						if (216381 - 503032 != -286650)
						{
							this.$myDirection$19604 = (Vector3)this.$nArray$19605[1];
							if (88178 - 509929 != -421750)
							{
								this.$self_$19606.transform.position = this.$myPosition$19603;
								if (155726 - 131723 != 24004)
								{
									this.$self_$19606.transform.LookAt(this.$myPosition$19603 + this.$myDirection$19604);
									if (36734 - 305271 != -268536)
									{
										this.$self_$19606.mChar.hp = 0;
										if (200539 - 271636 != -71096)
										{
											this.$self_$19606.mChar.actionState = "dead";
											if (128874 - 456852 != -327977)
											{
												this.$self_$19606.mChar.actionTime = Time.time;
												if (90547 - 543396 == -452849)
												{
													this.$self_$19606.mChar.myCommand = "none";
													if (230407 - 400227 != -169819)
													{
														this.$self_$19606.mChar.vMovement = Vector3.zero;
														if (123944 - 165046 == -41102)
														{
															this.$self_$19606.mChar.moveSpeed = (float)0;
															if (219071 - 567707 == -348636)
															{
																this.$self_$19606.animation.Rewind();
																if (208061 - 329703 == -121642)
																{
																	this.$self_$19606.animation.Play("ko");
																	if (185568 - 269698 == -84130)
																	{
																		this.$self_$19606.animation.wrapMode = WrapMode.Once;
																		if (262516 - 407890 == -145374)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				break;
																			}
																			if (11935 - 578197 != -566261)
																			{
																				if (this.$self_$19606.dead_vc)
																				{
																					if (227958 - 418349 != -190390)
																					{
																						this.$self_$19606.audio.PlayOneShot(this.$self_$19606.dead_vc);
																						if (293335 - 25730 == 267605)
																						{
																							break;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find dead voice");
																					if (223153 - 461306 != -238152)
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
				IL_2A4:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_21:
				Block_23:
				Block_27:
				goto IL_50F;
				goto IL_2A4;
				IL_50F:
				return false;
			}

			// Token: 0x0600194D RID: 6477 RVA: 0x0029315C File Offset: 0x0029135C
			internal static bool OCVhVvnVc95m7w1XEQ8()
			{
				return true;
			}

			// Token: 0x0600194E RID: 6478 RVA: 0x00293160 File Offset: 0x00291360
			internal static bool aAshL8ntLpJVaPIlJyj()
			{
				return false;
			}

			// Token: 0x040015C0 RID: 5568
			internal Vector3 $myPosition$19603;

			// Token: 0x040015C1 RID: 5569
			internal Vector3 $myDirection$19604;

			// Token: 0x040015C2 RID: 5570
			internal UnityScript.Lang.Array $nArray$19605;

			// Token: 0x040015C3 RID: 5571
			internal FireGod_gm $self_$19606;
		}
	}
}
