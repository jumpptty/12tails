using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C1A RID: 3098
[Serializable]
public class Falcon : MonoBehaviour
{
	// Token: 0x0600454B RID: 17739 RVA: 0x008AEEF0 File Offset: 0x008AD0F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Falcon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600454C RID: 17740 RVA: 0x008AEF00 File Offset: 0x008AD100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (274533 - 38857 != 235677)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (291250 - 131132 != 160119)
			{
				this.mChar.actionState = "standby";
				if (105457 - 535523 == -430066)
				{
					this.mChar.actionTime = Time.time;
					if (33159 - 409879 != -376719)
					{
						this.mChar.myCommand = "none";
						if (15827 - 181233 == -165406)
						{
							if (Game.mGameType == 99)
							{
								if (256610 - 514472 != -257862)
								{
									continue;
								}
								this.mChar.isMine = true;
								if (122073 - 284922 == -162848)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								break;
							}
							if (51645 - 74079 == -22434)
							{
								if (!this.mChar.isSummon)
								{
									break;
								}
								if (165474 - 114749 == 50725)
								{
									if (this.awake_vc)
									{
										if (122451 - 164403 == -41952)
										{
											this.audio.PlayOneShot(this.awake_vc);
											if (19550 - 352918 == -333368)
											{
												break;
											}
										}
									}
									else
									{
										Debug.LogError("Missing awake_vc audio");
										if (115209 - 13285 == 101924)
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

	// Token: 0x0600454D RID: 17741 RVA: 0x008AF10C File Offset: 0x008AD30C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (131114 - 42648 != 88467)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (284614 - 333211 == -48596)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (80975 - 153308 == -72332)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_3DA;
					}
					if (176204 - 57091 != 119113)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (197032 - 516755 == -319722)
				{
					continue;
				}
			}
			IL_3DA:
			if (this.mChar.hp <= 0)
			{
				if (124614 - 488569 == -363954)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (77691 - 365545 != -287854)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (114691 - 156591 != -41900)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (17663 - 362128 == -344464)
						{
							continue;
						}
						if (status != null)
						{
							if (230550 - 224953 != 5597)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (8526 - 92443 != -83917)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (37489 - 107034 != -69545)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (101036 - 387027 != -285991)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (119636 - 331786 != -212150)
							{
								continue;
							}
							break;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (31848 - 473579 == -441730)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (87185 - 137131 == -49945)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (165016 - 578683 != -413667)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (142805 - 280507 != -137702)
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
			if (287806 - 262208 == 25598)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (284388 - 459495 != -175106)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (251703 - 169292 == 82411)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (260647 - 156048 == 104599)
						{
							if (this.mChar.isMine)
							{
								if (226428 - 166437 == 59991)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (48584 - 96373 == -47789)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (299933 - 292722 != 7212)
										{
											this.mChar.KoEvent();
											if (227555 - 416113 == -188558)
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
								if (104308 - 549346 == -445038)
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

	// Token: 0x0600454E RID: 17742 RVA: 0x008AF60C File Offset: 0x008AD80C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (16482 - 528508 != -512026)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (273515 - 232651 != 40865)
			{
				float runSpeed = this.mChar.runSpeed;
				if (43541 - 596544 != -553002)
				{
					Vector3 a = default(Vector3);
					if (162150 - 338516 == -176366)
					{
						Vector3 vector = Vector3.zero;
						if (153686 - 583174 != -429487)
						{
							float num2 = (float)0;
							if (66320 - 346303 != -279982)
							{
								if (this.mChar.isMine)
								{
									if (37575 - 389098 != -351523)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (131886 - 493676 == -361789)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (157850 - 408786 == -250935)
										{
											continue;
										}
										a.y = (float)0;
										if (5816 - 61086 == -55269)
										{
											continue;
										}
										a = a.normalized;
										if (297229 - 178584 != 118645)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (255047 - 116300 != 138747)
										{
											continue;
										}
										vector = vector.normalized;
										if (54627 - 505624 != -450997)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (152158 - 158722 == -6563)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (111010 - 230508 == -119497)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (72586 - 428649 != -356063)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (41069 - 356591 == -315521)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (173098 - 560519 == -387420)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (266690 - 520382 == -253691)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (160958 - 577897 == -416938)
														{
															continue;
														}
														this.animation.Play("run");
														if (59165 - 274074 == -214908)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (76875 - 350050 != -273174)
														{
															goto IL_E5;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (223825 - 114266 == 109560)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (140693 - 143915 == -3221)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (46963 - 89515 == -42551)
											{
												continue;
											}
											num = (float)0;
											if (152279 - 117870 == 34410)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (24878 - 62857 != -37979)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (169007 - 194037 == -25029)
										{
											continue;
										}
									}
									IL_E5:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (132633 - 82316 != 50317)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (207596 - 420168 == -212571)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (190707 - 83076 == 107632)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (63923 - 264992 != -201069)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (212154 - 532208 != -320054)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (157040 - 291730 == -134689)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (286584 - 294711 == -8126)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (255598 - 162607 != 92991)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (215824 - 300186 != -84362)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (41093 - 452471 != -411378)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (62731 - 339572 != -276841)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (146690 - 277163 == -130472)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (92204 - 215536 != -123332)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (190946 - 372054 == -181107)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (122448 - 181935 == -59486)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (175263 - 52991 == 122273)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (267228 - 17591 == 249638)
												{
													continue;
												}
												num = (float)0;
												if (119333 - 471721 != -352388)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (177460 - 198753 != -21293)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (103009 - 427167 != -324158)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (51255 - 173115 != -121860)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (176701 - 213023 != -36322)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (39103 - 597708 != -558605)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (267721 - 122547 != 145174)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (233764 - 316882 != -83118)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (110840 - 178591 != -67751)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (169922 - 237894 == -67971)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (178984 - 18760 != 160224)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (101992 - 38051 == 63942)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (250263 - 464133 == -213869)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (204050 - 31629 == 172422)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (89156 - 74205 != 14951)
											{
												continue;
											}
											num = (float)0;
											if (194392 - 178752 != 15640)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (278886 - 165451 == 113436)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (33702 - 103134 == -69431)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (224732 - 414962 != -190230)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (237802 - 206783 != 31019)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (65843 - 347122 == -281279)
								{
									this.mChar.moveSpeed = num;
									if (281228 - 401139 != -119910)
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

	// Token: 0x0600454F RID: 17743 RVA: 0x008B0170 File Offset: 0x008AE370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (290092 - 109082 != 181011)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (107175 - 567778 != -460602)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (191211 - 220564 == -29353)
				{
					if (243437 - 136959 == 106478)
					{
						if (ActionName == "RPC_pointBlank")
						{
							if (200108 - 436065 != -235957)
							{
								continue;
							}
							v = 1;
							if (99311 - 554552 != -455241)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_pointBlank_hit")
						{
							if (295866 - 224000 == 71867)
							{
								continue;
							}
							v = -1;
							if (105308 - 232513 == -127204)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_backDraw")
						{
							if (252432 - 245895 != 6537)
							{
								continue;
							}
							v = 2;
							if (46677 - 426546 != -379869)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_backDraw_hit")
						{
							if (180570 - 61544 != 119026)
							{
								continue;
							}
							v = -2;
							if (196006 - 332718 == -136711)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bulletRain")
						{
							if (209416 - 12203 != 197213)
							{
								continue;
							}
							v = 10;
							if (210040 - 371872 == -161831)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bulletRain_hit")
						{
							if (279898 - 441551 == -161652)
							{
								continue;
							}
							v = -10;
							if (202559 - 314725 == -112165)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_thousandShot")
						{
							if (154333 - 529546 == -375212)
							{
								continue;
							}
							v = 20;
							if (170790 - 315717 == -144926)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (22505 - 258753 == -236248)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (26628 - 389866 != -363237)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (236820 - 47056 == 189764)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (91481 - 122504 != -31022)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (82360 - 328016 == -245656)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (151198 - 584866 == -433668)
											{
												Hashtable hashtable = new Hashtable();
												if (137443 - 514198 == -376755)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (127430 - 224798 != -97367)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (184219 - 67401 == 116818)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (65825 - 148035 != -82209)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (25350 - 263630 != -238279)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (126696 - 278828 != -152131)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (81517 - 451835 == -370318)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (202860 - 347077 != -144216)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (214787 - 464966 != -250178)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (172435 - 256936 == -84501)
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

	// Token: 0x06004550 RID: 17744 RVA: 0x008B0740 File Offset: 0x008AE940
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (34346 - 582123 != -547776)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (17168 - 251321 == -234153)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (115304 - 209521 != -94216)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (231179 - 304697 == -73518)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (76784 - 401349 == -324565)
						{
							int num3 = num;
							if (99928 - 136830 != -36901)
							{
								if (num3 == 1)
								{
									if (192328 - 518649 != -326320)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (24110 - 168565 == -144455)
										{
											this.StartCoroutine_Auto(this.RPC_pointBlank(vector, vector2, num2));
											if (163333 - 15726 == 147607)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (82957 - 471311 != -388353)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (275616 - 597358 != -321741)
										{
											this.RPC_pointBlank_hit(vector, vector2, num2);
											if (118921 - 13455 == 105466)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (200309 - 56609 != 143701)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (108795 - 311864 == -203069)
										{
											this.StartCoroutine_Auto(this.RPC_backDraw(vector, vector2, num2));
											if (203215 - 168662 == 34553)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (293280 - 73472 == 219808)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (157928 - 216658 == -58730)
										{
											this.RPC_backDraw_hit(vector, vector2, num2);
											if (4390 - 385386 == -380996)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 10)
								{
									if (142205 - 305927 != -163721)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (98470 - 538045 != -439574)
										{
											this.StartCoroutine_Auto(this.RPC_bulletRain(vector, vector2, num2));
											if (119254 - 25623 != 93632)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -10)
								{
									if (292112 - 304545 != -12432)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (280068 - 112798 == 167270)
										{
											this.RPC_bulletRain_hit(vector, vector2, num2);
											if (115034 - 230053 != -115018)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 20)
								{
									if (128075 - 156198 != -28122)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (258165 - 530449 != -272283)
										{
											this.StartCoroutine_Auto(this.RPC_thousandShot(vector, vector2, num2));
											if (61941 - 302465 == -240524)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (163916 - 236635 == -72719)
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

	// Token: 0x06004551 RID: 17745 RVA: 0x008B0C30 File Offset: 0x008AEE30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (82191 - 146481 != -64290)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (143603 - 87677 != 55927)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (229821 - 550924 == -321103)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (220061 - 347895 == -127834)
					{
						Vector3 normalized = vector.normalized;
						if (14024 - 584728 != -570703)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (272827 - 217595 != 55233)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (85221 - 75195 == 10027)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (209200 - 141226 != 67974)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									if (38090 - 430625 == -392535)
									{
										break;
									}
								}
								else
								{
									Vector3 vector2 = a - this.transform.position;
									if (198389 - 337371 == -138982)
									{
										if (vector2.magnitude > (float)5)
										{
											if (277219 - 43239 == 233980)
											{
												this.StartCoroutine_Auto(this.RPC_pointBlank(this.transform.position, normalized, 0));
												if (142479 - 558525 != -416045)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (219516 - 252450 != -32933)
													{
														this.ActionEvent("RPC_pointBlank", this.transform.position, normalized, 0);
														if (180536 - 413462 == -232926)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_backDraw(this.transform.position, normalized, 0));
											if (142725 - 346930 != -204204)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (82968 - 244058 != -161089)
												{
													this.ActionEvent("RPC_backDraw", this.transform.position, normalized, 0);
													if (37613 - 7642 == 29971)
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

	// Token: 0x06004552 RID: 17746 RVA: 0x008B0F64 File Offset: 0x008AF164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (270295 - 517031 != -246736)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (220636 - 256099 != -35462)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (188793 - 94720 != 94074)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (299556 - 325518 != -25961)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (291008 - 595719 == -304711)
						{
							if (58530 - 202365 != -143834)
							{
								if (gameObject)
								{
									if (24969 - 423146 != -398177)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (271431 - 313360 == -41928)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (268427 - 588995 == -320567)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (108239 - 483565 != -375326)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (77809 - 571954 == -494144)
									{
										continue;
									}
									if (this.mChar.sp > 45)
									{
										if (82401 - 99445 != -17044)
										{
											continue;
										}
										if (this.mChar.isTimeOut("thousandShot") != (float)0)
										{
											if (47655 - 547121 != -499466)
											{
												continue;
											}
											Camera.main.SendMessage("newGameMessage", "ThousandShot is not ready");
											if (279325 - 347506 != -68181)
											{
												continue;
											}
											break;
										}
										else
										{
											this.mChar.sp = this.mChar.sp - 45;
											if (32923 - 97295 != -64372)
											{
												continue;
											}
											this.StartCoroutine_Auto(this.RPC_thousandShot(this.transform.position, vector, 0));
											if (140198 - 400961 != -260763)
											{
												continue;
											}
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (61395 - 198251 != -136856)
											{
												continue;
											}
											this.ActionEvent("RPC_thousandShot", this.transform.position, vector, 0);
											if (213563 - 366928 != -153364)
											{
												break;
											}
											continue;
										}
									}
								}
								if (this.mChar.isTimeOut("bulletRain") != (float)0)
								{
									if (53297 - 279238 != -225940)
									{
										Camera.main.SendMessage("newGameMessage", "BulletRain is not ready");
										if (250327 - 76971 == 173356)
										{
											break;
										}
									}
								}
								else
								{
									this.StartCoroutine_Auto(this.RPC_bulletRain(this.transform.position, vector, 0));
									if (135728 - 152399 != -16670)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (18407 - 560016 == -541609)
										{
											this.ActionEvent("RPC_bulletRain", this.transform.position, vector, 0);
											if (240478 - 249448 == -8970)
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

	// Token: 0x06004553 RID: 17747 RVA: 0x008B13A8 File Offset: 0x008AF5A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
		if (!this.mChar.isMine)
		{
		}
	}

	// Token: 0x06004554 RID: 17748 RVA: 0x008B13C0 File Offset: 0x008AF5C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_pointBlank(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Falcon.$RPC_pointBlank$31901(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004555 RID: 17749 RVA: 0x008B13D0 File Offset: 0x008AF5D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_pointBlank_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (869 - 376036 != -375167)
		{
		}
		for (;;)
		{
			if (this.pointBlank_hit)
			{
				if (81071 - 424892 != -343820)
				{
					UnityEngine.Object.Instantiate(this.pointBlank_hit, hitPos, Quaternion.identity);
					if (298950 - 470713 == -171763)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find pointBlank_hit Effect");
				if (165077 - 389470 != -224392)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004556 RID: 17750 RVA: 0x008B1488 File Offset: 0x008AF688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_backDraw(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Falcon.$RPC_backDraw$31919(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004557 RID: 17751 RVA: 0x008B1498 File Offset: 0x008AF698
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_backDraw_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.backDraw_hit)
		{
			UnityEngine.Object.Instantiate(this.backDraw_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06004558 RID: 17752 RVA: 0x008B14C4 File Offset: 0x008AF6C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_bulletRain(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Falcon.$RPC_bulletRain$31938(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004559 RID: 17753 RVA: 0x008B14D4 File Offset: 0x008AF6D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_bulletRain_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.bulletRain_hit)
		{
			UnityEngine.Object.Instantiate(this.bulletRain_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x0600455A RID: 17754 RVA: 0x008B1500 File Offset: 0x008AF700
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_thousandShot(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Falcon.$RPC_thousandShot$31951(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600455B RID: 17755 RVA: 0x008B1510 File Offset: 0x008AF710
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Falcon.$RPC_ko$31964(nArray, this).GetEnumerator();
	}

	// Token: 0x0600455C RID: 17756 RVA: 0x008B1520 File Offset: 0x008AF720
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Falcon.$RPC_dead$31972(nArray, this).GetEnumerator();
	}

	// Token: 0x0600455D RID: 17757 RVA: 0x008B1530 File Offset: 0x008AF730
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600455E RID: 17758 RVA: 0x008B1534 File Offset: 0x008AF734
	internal static bool PS8Cvu5iskFEPSjgZjXn()
	{
		return true;
	}

	// Token: 0x0600455F RID: 17759 RVA: 0x008B1538 File Offset: 0x008AF738
	internal static bool XDjrIO5i9qoHXLM7HCmF()
	{
		return false;
	}

	// Token: 0x040050BA RID: 20666
	public CharacterControl mChar;

	// Token: 0x040050BB RID: 20667
	private Liger mp3h91MmXr;

	// Token: 0x040050BC RID: 20668
	public AudioClip awake_vc;

	// Token: 0x040050BD RID: 20669
	public GameObject Italus_gunBullet;

	// Token: 0x040050BE RID: 20670
	public GameObject Italus_gunSmoke;

	// Token: 0x040050BF RID: 20671
	public AudioClip Italus_gunSound;

	// Token: 0x040050C0 RID: 20672
	public AudioClip nAttack1_vc;

	// Token: 0x040050C1 RID: 20673
	public AudioClip nAttack2_vc;

	// Token: 0x040050C2 RID: 20674
	public GameObject pointBlank_hit;

	// Token: 0x040050C3 RID: 20675
	public GameObject backDraw_fire;

	// Token: 0x040050C4 RID: 20676
	public AudioClip cAttack1_vc;

	// Token: 0x040050C5 RID: 20677
	public AudioClip cAttack2_vc;

	// Token: 0x040050C6 RID: 20678
	public GameObject backDraw_hit;

	// Token: 0x040050C7 RID: 20679
	public GameObject bulletRain_ring;

	// Token: 0x040050C8 RID: 20680
	public AudioClip bulletRain1_vc;

	// Token: 0x040050C9 RID: 20681
	public AudioClip bulletRain2_vc;

	// Token: 0x040050CA RID: 20682
	public GameObject bulletRain_hit;

	// Token: 0x040050CB RID: 20683
	public GameObject thousandShot_fire;

	// Token: 0x040050CC RID: 20684
	public AudioClip thousandShot_vc;

	// Token: 0x040050CD RID: 20685
	public AudioClip ko_vc;

	// Token: 0x040050CE RID: 20686
	public AudioClip dead_vc;

	// Token: 0x02000C1B RID: 3099
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_pointBlank$31901 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004560 RID: 17760 RVA: 0x008B153C File Offset: 0x008AF73C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_pointBlank$31901(Vector3 mPos, Vector3 tDir, int tID, Falcon self_)
		{
			if (56575 - 206848 != -150273)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (25134 - 67071 != -41936)
				{
					base..ctor();
					if (199449 - 95204 != 104246)
					{
						this.$mPos$31915 = mPos;
						if (295721 - 464061 == -168340)
						{
							this.$tDir$31916 = tDir;
							if (279702 - 507975 != -228272)
							{
								this.$tID$31917 = tID;
								if (73936 - 377892 == -303956)
								{
									this.$self_$31918 = self_;
									if (19671 - 345751 == -326080)
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

		// Token: 0x06004561 RID: 17761 RVA: 0x008B163C File Offset: 0x008AF83C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Falcon.$RPC_pointBlank$31901.$(this.$mPos$31915, this.$tDir$31916, this.$tID$31917, this.$self_$31918);
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x008B165C File Offset: 0x008AF85C
		internal static bool BUFpBG5i1p8nosTeLA80()
		{
			return true;
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x008B1660 File Offset: 0x008AF860
		internal static bool Bm7V1L5i4iAvc1GhhlAC()
		{
			return false;
		}

		// Token: 0x040050CF RID: 20687
		internal Vector3 $mPos$31915;

		// Token: 0x040050D0 RID: 20688
		internal Vector3 $tDir$31916;

		// Token: 0x040050D1 RID: 20689
		internal int $tID$31917;

		// Token: 0x040050D2 RID: 20690
		internal Falcon $self_$31918;

		// Token: 0x02000C1C RID: 3100
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004564 RID: 17764 RVA: 0x008B1664 File Offset: 0x008AF864
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Falcon self_)
			{
				if (237722 - 125191 != 112531)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (183490 - 328443 == -144953)
					{
						base..ctor();
						if (253212 - 537832 == -284620)
						{
							this.$mPos$31911 = mPos;
							if (30737 - 215448 != -184710)
							{
								this.$tDir$31912 = tDir;
								if (166986 - 156400 != 10587)
								{
									this.$tID$31913 = tID;
									if (200219 - 493807 != -293587)
									{
										this.$self_$31914 = self_;
										if (203819 - 492920 != -289100)
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

			// Token: 0x06004565 RID: 17765 RVA: 0x008B1764 File Offset: 0x008AF964
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (279444 - 167209 != 112235)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_5CE;
					case 1:
						goto IL_DAF;
					case 2:
						if (this.$self_$31914.mChar.actionState != "attack")
						{
							goto IL_28A;
						}
						if (115089 - 519502 != -404413)
						{
							continue;
						}
						if (this.$self_$31914.mChar.myCommand != "pointBlank")
						{
							if (19072 - 522928 != -503855)
							{
								goto IL_28A;
							}
							continue;
						}
						else
						{
							this.$self_$31914.mChar.moveSpeed = (float)-2;
							if (208673 - 354280 == -145606)
							{
								continue;
							}
							this.$hit$31903 = default(RaycastHit);
							if (201400 - 346043 != -144643)
							{
								continue;
							}
							this.$hitLayer$31904 = 130816 - (1 << this.$self_$31914.gameObject.layer);
							if (265601 - 403247 == -137645)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$31913];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$31905 = (GameObject)obj2;
							if (27780 - 510561 == -482780)
							{
								continue;
							}
							this.$firePos$31906 = this.$mPos$31911 + new Vector3((float)0, 1.5f, (float)0);
							if (193404 - 52487 == 140918)
							{
								continue;
							}
							this.$fireDir$31907 = this.$tDir$31912 - new Vector3((float)0, 1.5f, (float)0);
							if (241454 - 85125 == 156330)
							{
								continue;
							}
							if (this.$tObject$31905)
							{
								if (19779 - 326357 == -306577)
								{
									continue;
								}
								this.$fireDir$31907 = (this.$tObject$31905.collider.bounds.center - this.$firePos$31906).normalized;
								if (87934 - 217870 == -129935)
								{
									continue;
								}
							}
							this.$i$31908 = 0;
							if (238549 - 480159 == -241609)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$31914.mChar.actionState != "attack")
						{
							goto IL_73C;
						}
						if (267645 - 54726 == 212920)
						{
							continue;
						}
						if (this.$self_$31914.mChar.myCommand != "pointBlank")
						{
							if (168221 - 275874 != -107653)
							{
								continue;
							}
							goto IL_73C;
						}
						else
						{
							this.$i$31908++;
							if (122000 - 307713 != -185713)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$31914.mChar.actionState == "attack")
						{
							if (198037 - 388283 != -190246)
							{
								continue;
							}
							if (this.$self_$31914.mChar.myCommand == "pointBlank")
							{
								if (246961 - 349058 == -102096)
								{
									continue;
								}
								this.$self_$31914.mChar.moveSpeed = (float)0;
								if (113807 - 222161 == -108353)
								{
									continue;
								}
								this.$self_$31914.mChar.actionState = "standby";
								if (295758 - 267093 != 28665)
								{
									continue;
								}
								this.$self_$31914.mChar.actionTime = Time.time;
								if (157602 - 262776 == -105173)
								{
									continue;
								}
								this.$self_$31914.mChar.myCommand = "none";
								if (179507 - 581585 != -402078)
								{
									continue;
								}
								if (!this.$self_$31914.mChar.isMine)
								{
									if (59015 - 514846 == -455830)
									{
										continue;
									}
									this.$self_$31914.mChar.nPosition = this.$self_$31914.transform.position;
									if (245833 - 9091 == 236743)
									{
										continue;
									}
									this.$self_$31914.mChar.oPosition = this.$self_$31914.transform.position;
									if (21643 - 587887 != -566244)
									{
										continue;
									}
									this.$self_$31914.mChar.nDirection = this.$self_$31914.transform.forward;
									if (268485 - 129384 != 139101)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (160491 - 414373 != -253881)
						{
							goto Block_74;
						}
						continue;
					default:
						if (282223 - 420426 != -138203)
						{
							continue;
						}
						goto IL_5CE;
					}
					if (this.$i$31908 >= 4)
					{
						if (251053 - 237584 != 13470)
						{
							goto Block_17;
						}
						continue;
					}
					else
					{
						if (this.$i$31908 % 2 == 0)
						{
							if (20354 - 385819 == -365464)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$31914.Italus_gunSmoke, this.$self_$31914.transform.position + this.$self_$31914.transform.TransformDirection(0.45f, 1.8f, 0.4f), Quaternion.identity);
							if (134846 - 339939 != -205093)
							{
								continue;
							}
						}
						else
						{
							UnityEngine.Object.Instantiate(this.$self_$31914.Italus_gunSmoke, this.$self_$31914.transform.position + this.$self_$31914.transform.TransformDirection(-0.15f, 1.8f, 1.2f), Quaternion.identity);
							if (57540 - 486304 != -428764)
							{
								continue;
							}
						}
						this.$self_$31914.audio.PlayOneShot(this.$self_$31914.Italus_gunSound);
						if (218822 - 163064 == 55759)
						{
							continue;
						}
						if (!this.$self_$31914.mChar.isMine)
						{
							goto IL_769;
						}
						if (145889 - 51028 == 94862)
						{
							continue;
						}
						if (!Physics.Raycast(this.$firePos$31906, this.$fireDir$31907, out this.$hit$31903, (float)40, this.$hitLayer$31904))
						{
							goto IL_769;
						}
						if (177954 - 62121 != 115833)
						{
							continue;
						}
						this.$hitObject$31909 = this.$hit$31903.collider.gameObject;
						if (298734 - 444258 == -145523)
						{
							continue;
						}
						this.$hitDmg$31910 = this.$self_$31914.mChar.atk;
						if (37008 - 441868 != -404860)
						{
							continue;
						}
						if (Game.mGameCode == 305)
						{
							if (277411 - 203400 == 74012)
							{
								continue;
							}
							this.$hitDmg$31910 = Mathf.FloorToInt(0.35f * (float)this.$self_$31914.mChar.atk);
							if (207579 - 352842 != -145263)
							{
								continue;
							}
						}
						if (this.$self_$31914.mChar.hit(1, this.$hitObject$31909, this.$hitDmg$31910, 1, 0, 0.3f * this.$fireDir$31907) == 0)
						{
							goto IL_769;
						}
						if (172606 - 114477 != 58129)
						{
							continue;
						}
						this.$self_$31914.RPC_pointBlank_hit(this.$hit$31903.point, this.$self_$31914.transform.forward, 0);
						if (110295 - 359962 != -249667)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							goto IL_769;
						}
						if (113580 - 482707 == -369126)
						{
							continue;
						}
						this.$self_$31914.ActionEvent("RPC_pointBlank_hit", this.$hit$31903.point, this.$self_$31914.transform.forward, 0);
						if (129143 - 260370 != -131227)
						{
							continue;
						}
						goto IL_769;
					}
					IL_5CE:
					this.$self_$31914.mChar.actionState = "attack";
					if (150287 - 499780 != -349492)
					{
						this.$self_$31914.mChar.actionTime = Time.time;
						if (230354 - 417358 != -187003)
						{
							this.$self_$31914.mChar.myCommand = "pointBlank";
							if (235323 - 303435 == -68112)
							{
								this.$self_$31914.mChar.addTimeOut("nAttack", (float)2);
								if (19352 - 377382 == -358030)
								{
									this.$self_$31914.transform.position = this.$mPos$31911;
									if (52926 - 77066 == -24140)
									{
										this.$self_$31914.transform.LookAt(this.$mPos$31911 + global::Math.vFlat(this.$tDir$31912));
										if (177481 - 576093 == -398612)
										{
											this.$self_$31914.animation.CrossFade("pointBlank");
											if (153430 - 333276 == -179846)
											{
												this.$self_$31914.animation.wrapMode = WrapMode.Once;
												if (97615 - 438745 != -341129)
												{
													this.$self_$31914.mChar.vMovement = this.$self_$31914.transform.forward;
													if (172184 - 387962 == -215778)
													{
														this.$self_$31914.mChar.moveSpeed = (float)0;
														if (218921 - 215336 == 3585)
														{
															if (!this.$self_$31914.mChar.isControlled)
															{
																if (187511 - 364264 != -176753)
																{
																	continue;
																}
																if (Game.mGameCode == 305)
																{
																	if (193276 - 38815 != 154461)
																	{
																		continue;
																	}
																	this.$m$31902 = Language.getMessage("M305_ItalusAcceptance", UnityEngine.Random.Range(10, 35));
																	if (171146 - 210318 != -39172)
																	{
																		continue;
																	}
																	if (this.$m$31902 != string.Empty)
																	{
																		if (172020 - 219349 == -47328)
																		{
																			continue;
																		}
																		Chat.SubmitChat("Italus", this.$m$31902, eChatType.npc, eChatMode.system);
																		if (151364 - 152663 != -1299)
																		{
																			continue;
																		}
																		this.$self_$31914.mChar.doChatBubble(this.$m$31902);
																		if (62210 - 537009 != -474799)
																		{
																			continue;
																		}
																	}
																}
															}
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_636;
															}
															if (42872 - 447387 == -404515)
															{
																if (UnityEngine.Random.Range(0, 2) != 0)
																{
																	if (179975 - 39294 == 140681)
																	{
																		if (this.$self_$31914.nAttack1_vc)
																		{
																			if (56418 - 19865 == 36553)
																			{
																				this.$self_$31914.audio.PlayOneShot(this.$self_$31914.nAttack1_vc);
																				if (48444 - 146516 != -98071)
																				{
																					goto Block_45;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Missing nAttack1 voice");
																			if (242215 - 187984 == 54231)
																			{
																				goto IL_8AD;
																			}
																		}
																	}
																}
																else if (this.$self_$31914.nAttack2_vc)
																{
																	if (6192 - 183182 != -176989)
																	{
																		this.$self_$31914.audio.PlayOneShot(this.$self_$31914.nAttack2_vc);
																		if (181564 - 508300 == -326736)
																		{
																			goto IL_C0A;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing nAttack2 voice");
																	if (118484 - 310980 == -192496)
																	{
																		goto IL_636;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_28A:
				goto IL_DAF;
				Block_17:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_636:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_45:
				goto IL_8AD;
				IL_73C:
				goto IL_DAF;
				IL_769:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_8AD:
				goto IL_636;
				Block_74:
				goto IL_DAF;
				IL_C0A:
				goto IL_636;
				IL_DAF:
				return false;
			}

			// Token: 0x06004566 RID: 17766 RVA: 0x008B2534 File Offset: 0x008B0734
			internal static bool CvP8S15izj8DuOmLXexp()
			{
				return true;
			}

			// Token: 0x06004567 RID: 17767 RVA: 0x008B2538 File Offset: 0x008B0738
			internal static bool KURNGm5Ka4ggbcEGVH4B()
			{
				return false;
			}

			// Token: 0x040050D3 RID: 20691
			internal string $m$31902;

			// Token: 0x040050D4 RID: 20692
			internal RaycastHit $hit$31903;

			// Token: 0x040050D5 RID: 20693
			internal int $hitLayer$31904;

			// Token: 0x040050D6 RID: 20694
			internal GameObject $tObject$31905;

			// Token: 0x040050D7 RID: 20695
			internal Vector3 $firePos$31906;

			// Token: 0x040050D8 RID: 20696
			internal Vector3 $fireDir$31907;

			// Token: 0x040050D9 RID: 20697
			internal int $i$31908;

			// Token: 0x040050DA RID: 20698
			internal GameObject $hitObject$31909;

			// Token: 0x040050DB RID: 20699
			internal int $hitDmg$31910;

			// Token: 0x040050DC RID: 20700
			internal Vector3 $mPos$31911;

			// Token: 0x040050DD RID: 20701
			internal Vector3 $tDir$31912;

			// Token: 0x040050DE RID: 20702
			internal int $tID$31913;

			// Token: 0x040050DF RID: 20703
			internal Falcon $self_$31914;
		}
	}

	// Token: 0x02000C1D RID: 3101
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_backDraw$31919 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004568 RID: 17768 RVA: 0x008B253C File Offset: 0x008B073C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_backDraw$31919(Vector3 mPos, Vector3 tDir, Falcon self_)
		{
			if (77677 - 207486 != -129809)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (229693 - 454407 == -224714)
				{
					base..ctor();
					if (112784 - 411727 == -298943)
					{
						this.$mPos$31935 = mPos;
						if (291690 - 246538 != 45153)
						{
							this.$tDir$31936 = tDir;
							if (110946 - 529281 == -418335)
							{
								this.$self_$31937 = self_;
								if (37 - 138896 != -138858)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x008B2618 File Offset: 0x008B0818
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Falcon.$RPC_backDraw$31919.$(this.$mPos$31935, this.$tDir$31936, this.$self_$31937);
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x008B2634 File Offset: 0x008B0834
		internal static bool auLgxA5K5Yxgltf8QYTS()
		{
			return true;
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x008B2638 File Offset: 0x008B0838
		internal static bool n5uHQJ5KpnPgK6SUidca()
		{
			return false;
		}

		// Token: 0x040050E0 RID: 20704
		internal Vector3 $mPos$31935;

		// Token: 0x040050E1 RID: 20705
		internal Vector3 $tDir$31936;

		// Token: 0x040050E2 RID: 20706
		internal Falcon $self_$31937;

		// Token: 0x02000C1E RID: 3102
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600456C RID: 17772 RVA: 0x008B263C File Offset: 0x008B083C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Falcon self_)
			{
				if (41255 - 250907 != -209652)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (51543 - 403009 != -351465)
					{
						base..ctor();
						if (268466 - 38711 == 229755)
						{
							this.$mPos$31932 = mPos;
							if (61622 - 251698 != -190075)
							{
								this.$tDir$31933 = tDir;
								if (19400 - 319322 != -299921)
								{
									this.$self_$31934 = self_;
									if (178428 - 581945 == -403517)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600456D RID: 17773 RVA: 0x008B2718 File Offset: 0x008B0918
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (217962 - 567362 != -349399)
				{
				}
				for (;;)
				{
					IL_D88:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_11CF;
					case 2:
						if (this.$self_$31934.mChar.actionState != "attack")
						{
							goto IL_6A2;
						}
						if (10658 - 168476 != -157818)
						{
							continue;
						}
						if (this.$self_$31934.mChar.myCommand != "backDraw")
						{
							if (87768 - 302011 != -214243)
							{
								continue;
							}
							goto IL_6A2;
						}
						else
						{
							this.$self_$31934.mChar.moveSpeed = (float)-10;
							if (222885 - 521878 != -298993)
							{
								continue;
							}
							this.$mw_L$31921 = this.$self_$31934.transform.Find("Italus_tri/Root/Hip_L/Thigh_L/w_Italus");
							if (140031 - 206751 != -66720)
							{
								continue;
							}
							this.$mw_R$31922 = this.$self_$31934.transform.Find("Italus_tri/Root/Hip_R/Thigh_R/w_Italus");
							if (200707 - 112087 != 88620)
							{
								continue;
							}
							if (this.$mw_L$31921)
							{
								if (79769 - 468075 != -388306)
								{
									continue;
								}
								this.$mw_L$31921.renderer.enabled = false;
								if (42487 - 558396 == -515908)
								{
									continue;
								}
							}
							if (this.$mw_R$31922)
							{
								if (243075 - 542607 != -299532)
								{
									continue;
								}
								this.$mw_R$31922.renderer.enabled = false;
								if (271249 - 181249 != 90000)
								{
									continue;
								}
							}
							this.$mBackDraw$31923 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$31934.backDraw_fire, this.$self_$31934.transform.position, this.$self_$31934.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
							if (127191 - 113918 != 13273)
							{
								continue;
							}
							this.$mBackDrawControl$31924 = (EffectControl)this.$mBackDraw$31923.GetComponent(typeof(EffectControl));
							if (183077 - 438362 != -255285)
							{
								continue;
							}
							this.$mBackDrawControl$31924.InitEffectControl(this.$self_$31934.gameObject);
							if (139846 - 85414 != 54433)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31934.mChar.actionState != "attack")
						{
							goto IL_DC5;
						}
						if (232530 - 70637 != 161893)
						{
							continue;
						}
						if (this.$self_$31934.mChar.myCommand != "backDraw")
						{
							if (275835 - 162467 != 113368)
							{
								continue;
							}
							goto IL_DC5;
						}
						else
						{
							this.$fireRot$31925 = this.$self_$31934.transform.rotation * Quaternion.Euler((float)6, (float)0, (float)0);
							if (66190 - 514602 == -448411)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$31934.Italus_gunBullet, this.$self_$31934.transform.position + this.$self_$31934.transform.TransformDirection((float)0, 1.6f, 0.9f), this.$fireRot$31925);
							if (195578 - 159514 == 36065)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$31934.Italus_gunBullet, this.$self_$31934.transform.position + this.$self_$31934.transform.TransformDirection(0.7f, 2.7f, 0.9f), this.$fireRot$31925);
							if (77172 - 455178 == -378005)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$31934.Italus_gunBullet, this.$self_$31934.transform.position + this.$self_$31934.transform.TransformDirection(-0.7f, 2.7f, 0.9f), this.$fireRot$31925);
							if (152541 - 56100 != 96441)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$31934.Italus_gunSmoke, this.$self_$31934.transform.position + this.$self_$31934.transform.TransformDirection((float)0, 1.6f, 0.9f), Quaternion.identity);
							if (145691 - 389570 == -243878)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$31934.Italus_gunSmoke, this.$self_$31934.transform.position + this.$self_$31934.transform.TransformDirection(0.7f, 2.7f, 0.9f), Quaternion.identity);
							if (31552 - 569324 != -537772)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$31934.Italus_gunSmoke, this.$self_$31934.transform.position + this.$self_$31934.transform.TransformDirection(-0.7f, 2.7f, 0.9f), Quaternion.identity);
							if (45661 - 213375 != -167714)
							{
								continue;
							}
							this.$self_$31934.audio.PlayOneShot(this.$self_$31934.Italus_gunSound);
							if (68717 - 400745 != -332028)
							{
								continue;
							}
							if (!this.$self_$31934.mChar.isMine)
							{
								goto IL_790;
							}
							if (225593 - 541993 != -316400)
							{
								continue;
							}
							this.$hitLayer$31926 = 130816 - (1 << this.$self_$31934.gameObject.layer);
							if (123834 - 387918 != -264084)
							{
								continue;
							}
							this.$hitList$31927 = Damage.FindRecTarget(this.$self_$31934.transform.position, this.$self_$31934.transform.forward, this.$self_$31934.mChar.rangeMod, this.$self_$31934.mChar.rangeMod, (float)15 * this.$self_$31934.mChar.rangeMod, (float)3 * this.$self_$31934.mChar.rangeMod, this.$hitLayer$31926);
							if (298588 - 471091 == -172502)
							{
								continue;
							}
							this.$hitDmg$31928 = 3 * this.$self_$31934.mChar.atk;
							if (233966 - 237024 == -3057)
							{
								continue;
							}
							if (Game.mGameCode == 305)
							{
								if (15266 - 599706 == -584439)
								{
									continue;
								}
								this.$hitDmg$31928 = this.$self_$31934.mChar.atk;
								if (247190 - 544758 != -297568)
								{
									continue;
								}
							}
							this.$$iterator$10728$31931 = UnityRuntimeServices.GetEnumerator(this.$hitList$31927);
							if (268670 - 173618 != 95052)
							{
								continue;
							}
							while (this.$$iterator$10728$31931.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10728$31931.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31929 = (GameObject)obj2;
								if (177705 - 193064 != -15359)
								{
									goto IL_D88;
								}
								if (this.$self_$31934.mChar.hit(99, this.$hitObject$31929, this.$hitDmg$31928, 1, 0, this.$self_$31934.transform.forward) != 0)
								{
									if (137353 - 451129 != -313776)
									{
										goto IL_D88;
									}
									this.$hitPoint$31930 = this.$hitObject$31929.collider.ClosestPointOnBounds(this.$self_$31934.transform.position + Vector3.up);
									if (116133 - 440821 == -324687)
									{
										goto IL_D88;
									}
									UnityRuntimeServices.Update(this.$$iterator$10728$31931, this.$hitObject$31929);
									if (217283 - 51907 != 165376)
									{
										goto IL_D88;
									}
									this.$self_$31934.RPC_backDraw_hit(this.$hitPoint$31930, this.$self_$31934.transform.forward, 0);
									if (169006 - 289116 == -120109)
									{
										goto IL_D88;
									}
									this.$self_$31934.ActionEvent("RPC_backDraw_hit", this.$hitPoint$31930, this.$self_$31934.transform.forward, 0);
									if (105353 - 20023 == 85331)
									{
										goto IL_D88;
									}
								}
							}
							if (175259 - 586066 != -410807)
							{
								continue;
							}
							goto IL_790;
						}
						break;
					case 4:
						if (this.$self_$31934.mChar.actionState != "attack")
						{
							goto IL_75F;
						}
						if (14988 - 579738 != -564750)
						{
							continue;
						}
						if (this.$self_$31934.mChar.myCommand != "backDraw")
						{
							if (282012 - 408038 != -126025)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$self_$31934.mChar.moveSpeed = (float)0;
							if (242821 - 23502 != 219319)
							{
								continue;
							}
							goto IL_104;
						}
						break;
					case 5:
						if (this.$mw_L$31921)
						{
							if (84324 - 76664 == 7661)
							{
								continue;
							}
							this.$mw_L$31921.renderer.enabled = true;
							if (216186 - 201782 == 14405)
							{
								continue;
							}
						}
						if (this.$mw_R$31922)
						{
							if (96848 - 148880 != -52032)
							{
								continue;
							}
							this.$mw_R$31922.renderer.enabled = true;
							if (240928 - 432812 != -191884)
							{
								continue;
							}
						}
						if (this.$self_$31934.mChar.actionState == "attack")
						{
							if (247035 - 384174 != -137139)
							{
								continue;
							}
							if (this.$self_$31934.mChar.myCommand == "backDraw")
							{
								if (88205 - 580029 == -491823)
								{
									continue;
								}
								this.$self_$31934.mChar.moveSpeed = (float)0;
								if (140769 - 47449 == 93321)
								{
									continue;
								}
								this.$self_$31934.mChar.actionState = "standby";
								if (46562 - 382255 == -335692)
								{
									continue;
								}
								this.$self_$31934.mChar.actionTime = Time.time;
								if (182688 - 228144 == -45455)
								{
									continue;
								}
								this.$self_$31934.mChar.myCommand = "none";
								if (126298 - 502739 == -376440)
								{
									continue;
								}
								if (!this.$self_$31934.mChar.isMine)
								{
									if (280659 - 430107 == -149447)
									{
										continue;
									}
									this.$self_$31934.mChar.nPosition = this.$self_$31934.transform.position;
									if (235934 - 491012 == -255077)
									{
										continue;
									}
									this.$self_$31934.mChar.oPosition = this.$self_$31934.transform.position;
									if (193207 - 468768 == -275560)
									{
										continue;
									}
									this.$self_$31934.mChar.nDirection = this.$self_$31934.transform.forward;
									if (96836 - 2537 != 94299)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (146257 - 143832 != 2425)
						{
							continue;
						}
						goto IL_11CF;
					default:
						if (195937 - 548657 == -352719)
						{
							continue;
						}
						break;
					}
					this.$self_$31934.mChar.actionState = "attack";
					if (252727 - 552432 == -299705)
					{
						this.$self_$31934.mChar.actionTime = Time.time;
						if (61038 - 401449 == -340411)
						{
							this.$self_$31934.mChar.myCommand = "backDraw";
							if (291716 - 291460 == 256)
							{
								this.$self_$31934.mChar.addTimeOut("nAttack", (float)2);
								if (191603 - 111762 == 79841)
								{
									this.$self_$31934.transform.position = this.$mPos$31932;
									if (58588 - 338235 == -279647)
									{
										this.$self_$31934.transform.LookAt(this.$mPos$31932 + global::Math.vFlat(this.$tDir$31933));
										if (138383 - 413915 == -275532)
										{
											this.$self_$31934.animation.CrossFade("backDraw");
											if (245521 - 49726 == 195795)
											{
												this.$self_$31934.animation.wrapMode = WrapMode.Once;
												if (199521 - 256229 != -56707)
												{
													this.$self_$31934.mChar.vMovement = this.$self_$31934.transform.forward;
													if (61522 - 333148 == -271626)
													{
														this.$self_$31934.mChar.moveSpeed = (float)0;
														if (238521 - 2767 != 235755)
														{
															if (!this.$self_$31934.mChar.isControlled)
															{
																if (260008 - 209684 != 50324)
																{
																	continue;
																}
																if (Game.mGameCode == 305)
																{
																	if (161201 - 396749 == -235547)
																	{
																		continue;
																	}
																	this.$m$31920 = Language.getMessage("M305_ItalusAcceptance", UnityEngine.Random.Range(10, 35));
																	if (269719 - 53617 == 216103)
																	{
																		continue;
																	}
																	if (this.$m$31920 != string.Empty)
																	{
																		if (98135 - 594028 != -495893)
																		{
																			continue;
																		}
																		Chat.SubmitChat("Italus", this.$m$31920, eChatType.npc, eChatMode.system);
																		if (193369 - 57831 != 135538)
																		{
																			continue;
																		}
																		this.$self_$31934.mChar.doChatBubble(this.$m$31920);
																		if (134883 - 461604 == -326720)
																		{
																			continue;
																		}
																	}
																}
															}
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_23D;
															}
															if (247869 - 256746 == -8877)
															{
																if (UnityEngine.Random.Range(0, 2) != 0)
																{
																	if (161756 - 165627 != -3870)
																	{
																		if (this.$self_$31934.cAttack1_vc)
																		{
																			if (8716 - 481898 != -473181)
																			{
																				this.$self_$31934.audio.PlayOneShot(this.$self_$31934.cAttack1_vc);
																				if (34978 - 362406 == -327428)
																				{
																					goto IL_A44;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Missing cAttack1 voice");
																			if (297428 - 94643 == 202785)
																			{
																				goto IL_3D2;
																			}
																		}
																	}
																}
																else if (this.$self_$31934.cAttack2_vc)
																{
																	if (144757 - 581042 == -436285)
																	{
																		this.$self_$31934.audio.PlayOneShot(this.$self_$31934.cAttack2_vc);
																		if (167193 - 452054 == -284861)
																		{
																			goto IL_AEE;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing cAttack2 voice");
																	if (200815 - 286784 != -85968)
																	{
																		goto Block_68;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_104:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_23D:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_3D2:
				goto IL_23D;
				Block_27:
				return this.Yield(3, new WaitForSeconds(0.4f));
				Block_29:
				IL_6A2:
				IL_75F:
				goto IL_11CF;
				IL_790:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_A44:
				IL_AEE:
				Block_68:
				goto IL_23D;
				IL_DC5:
				IL_11CF:
				return false;
			}

			// Token: 0x0600456E RID: 17774 RVA: 0x008B3908 File Offset: 0x008B1B08
			internal static bool HCjRs95KVr99sBk96Oxe()
			{
				return true;
			}

			// Token: 0x0600456F RID: 17775 RVA: 0x008B390C File Offset: 0x008B1B0C
			internal static bool nPEYJf5KtxQ6mSLyGbC8()
			{
				return false;
			}

			// Token: 0x040050E3 RID: 20707
			internal string $m$31920;

			// Token: 0x040050E4 RID: 20708
			internal Transform $mw_L$31921;

			// Token: 0x040050E5 RID: 20709
			internal Transform $mw_R$31922;

			// Token: 0x040050E6 RID: 20710
			internal GameObject $mBackDraw$31923;

			// Token: 0x040050E7 RID: 20711
			internal EffectControl $mBackDrawControl$31924;

			// Token: 0x040050E8 RID: 20712
			internal Quaternion $fireRot$31925;

			// Token: 0x040050E9 RID: 20713
			internal int $hitLayer$31926;

			// Token: 0x040050EA RID: 20714
			internal UnityScript.Lang.Array $hitList$31927;

			// Token: 0x040050EB RID: 20715
			internal int $hitDmg$31928;

			// Token: 0x040050EC RID: 20716
			internal GameObject $hitObject$31929;

			// Token: 0x040050ED RID: 20717
			internal Vector3 $hitPoint$31930;

			// Token: 0x040050EE RID: 20718
			internal IEnumerator $$iterator$10728$31931;

			// Token: 0x040050EF RID: 20719
			internal Vector3 $mPos$31932;

			// Token: 0x040050F0 RID: 20720
			internal Vector3 $tDir$31933;

			// Token: 0x040050F1 RID: 20721
			internal Falcon $self_$31934;
		}
	}

	// Token: 0x02000C1F RID: 3103
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_bulletRain$31938 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004570 RID: 17776 RVA: 0x008B3910 File Offset: 0x008B1B10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_bulletRain$31938(Vector3 mPos, Vector3 tDir, Falcon self_)
		{
			if (156959 - 106776 != 50184)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (41609 - 92598 == -50989)
				{
					base..ctor();
					if (229928 - 551068 != -321139)
					{
						this.$mPos$31948 = mPos;
						if (43281 - 159593 == -116312)
						{
							this.$tDir$31949 = tDir;
							if (216542 - 537237 != -320694)
							{
								this.$self_$31950 = self_;
								if (178570 - 233539 != -54968)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004571 RID: 17777 RVA: 0x008B39EC File Offset: 0x008B1BEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Falcon.$RPC_bulletRain$31938.$(this.$mPos$31948, this.$tDir$31949, this.$self_$31950);
		}

		// Token: 0x06004572 RID: 17778 RVA: 0x008B3A08 File Offset: 0x008B1C08
		internal static bool RhNVwf5KNPZexM4uej4S()
		{
			return true;
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x008B3A0C File Offset: 0x008B1C0C
		internal static bool c6cx1L5KY2gDZK9197Ax()
		{
			return false;
		}

		// Token: 0x040050F2 RID: 20722
		internal Vector3 $mPos$31948;

		// Token: 0x040050F3 RID: 20723
		internal Vector3 $tDir$31949;

		// Token: 0x040050F4 RID: 20724
		internal Falcon $self_$31950;

		// Token: 0x02000C20 RID: 3104
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004574 RID: 17780 RVA: 0x008B3A10 File Offset: 0x008B1C10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Falcon self_)
			{
				if (174903 - 163251 != 11653)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (274600 - 298209 != -23608)
					{
						base..ctor();
						if (247647 - 381437 != -133789)
						{
							this.$mPos$31945 = mPos;
							if (177084 - 522598 != -345513)
							{
								this.$tDir$31946 = tDir;
								if (93189 - 147629 == -54440)
								{
									this.$self_$31947 = self_;
									if (128035 - 36439 != 91597)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004575 RID: 17781 RVA: 0x008B3AEC File Offset: 0x008B1CEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (43007 - 37311 != 5697)
				{
				}
				for (;;)
				{
					IL_5A5:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A87;
					case 2:
						if (this.$self_$31947.mChar.actionState != "attack")
						{
							goto IL_118;
						}
						if (213096 - 553549 != -340453)
						{
							continue;
						}
						if (this.$self_$31947.mChar.myCommand != "bulletRain")
						{
							if (138371 - 297283 != -158912)
							{
								continue;
							}
							goto IL_118;
						}
						else
						{
							this.$self_$31947.mChar.StartCoroutine_Auto(this.$self_$31947.mChar.addStatus("hide", 1, 1, 0, this.$self_$31947.mChar.ActorNr));
							if (218662 - 195082 != 23580)
							{
								continue;
							}
							this.$i$31939 = 0;
							if (75701 - 166062 != -90361)
							{
								continue;
							}
							goto IL_890;
						}
						break;
					case 3:
						if (this.$self_$31947.mChar.actionState != "attack")
						{
							goto IL_323;
						}
						if (62975 - 438385 == -375409)
						{
							continue;
						}
						if (this.$self_$31947.mChar.myCommand != "bulletRain")
						{
							if (234051 - 63448 != 170604)
							{
								goto Block_46;
							}
							continue;
						}
						else
						{
							this.$i$31939++;
							if (207037 - 444666 != -237629)
							{
								continue;
							}
							goto IL_890;
						}
						break;
					case 4:
						if (this.$self_$31947.mChar.actionState == "attack")
						{
							if (59430 - 297775 != -238345)
							{
								continue;
							}
							if (this.$self_$31947.mChar.myCommand == "bulletRain")
							{
								if (273545 - 253348 == 20198)
								{
									continue;
								}
								this.$self_$31947.mChar.moveSpeed = (float)0;
								if (118681 - 548762 == -430080)
								{
									continue;
								}
								this.$self_$31947.mChar.actionState = "standby";
								if (214444 - 526971 == -312526)
								{
									continue;
								}
								this.$self_$31947.mChar.actionTime = Time.time;
								if (200216 - 554929 == -354712)
								{
									continue;
								}
								this.$self_$31947.mChar.myCommand = "none";
								if (188335 - 460115 != -271780)
								{
									continue;
								}
								if (!this.$self_$31947.mChar.isMine)
								{
									if (43059 - 128564 == -85504)
									{
										continue;
									}
									this.$self_$31947.mChar.nPosition = this.$self_$31947.transform.position;
									if (292336 - 96894 == 195443)
									{
										continue;
									}
									this.$self_$31947.mChar.oPosition = this.$self_$31947.transform.position;
									if (279087 - 432982 != -153895)
									{
										continue;
									}
									this.$self_$31947.mChar.nDirection = this.$self_$31947.transform.forward;
									if (6249 - 505957 == -499707)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (182343 - 122705 != 59638)
						{
							continue;
						}
						goto IL_A87;
					default:
						if (65407 - 324472 == -259064)
						{
							continue;
						}
						break;
					}
					this.$self_$31947.mChar.actionState = "attack";
					if (200715 - 59268 != 141447)
					{
						continue;
					}
					this.$self_$31947.mChar.actionTime = Time.time;
					if (80927 - 506751 == -425823)
					{
						continue;
					}
					this.$self_$31947.mChar.myCommand = "bulletRain";
					if (239998 - 597303 != -357305)
					{
						continue;
					}
					this.$self_$31947.mChar.addTimeOut("bulletRain", (float)20);
					if (97179 - 589588 != -492409)
					{
						continue;
					}
					this.$self_$31947.transform.position = this.$mPos$31945;
					if (86951 - 265714 != -178763)
					{
						continue;
					}
					this.$self_$31947.transform.LookAt(this.$mPos$31945 + global::Math.vFlat(this.$tDir$31946));
					if (239451 - 41374 != 198077)
					{
						continue;
					}
					this.$self_$31947.animation.CrossFade("bulletRain");
					if (71725 - 209498 != -137773)
					{
						continue;
					}
					this.$self_$31947.animation.wrapMode = WrapMode.Once;
					if (280520 - 280017 == 504)
					{
						continue;
					}
					this.$self_$31947.mChar.vMovement = this.$self_$31947.transform.forward;
					if (98150 - 431352 == -333201)
					{
						continue;
					}
					this.$self_$31947.mChar.moveSpeed = (float)0;
					if (139903 - 105734 == 34170)
					{
						continue;
					}
					if (this.$self_$31947.bulletRain_ring)
					{
						if (136809 - 41549 != 95260)
						{
							continue;
						}
						this.$self_$31947.mChar.createEffect(this.$self_$31947.bulletRain_ring, this.$self_$31947.transform.position, this.$self_$31947.transform.rotation);
						if (24693 - 344565 != -319872)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing bulletRain_ring gameObject");
						if (90415 - 475699 == -385283)
						{
							continue;
						}
					}
					if (PlayerPrefs.GetInt("pvoice", 1) == 0)
					{
						break;
					}
					if (41327 - 193037 == -151709)
					{
						continue;
					}
					if (UnityEngine.Random.Range(0, 2) != 0)
					{
						if (272455 - 552905 == -280449)
						{
							continue;
						}
						if (this.$self_$31947.bulletRain1_vc)
						{
							if (138684 - 244043 == -105358)
							{
								continue;
							}
							this.$self_$31947.audio.PlayOneShot(this.$self_$31947.bulletRain1_vc);
							if (99840 - 533961 != -434121)
							{
								continue;
							}
							break;
						}
						else
						{
							Debug.LogError("Missing bulletRain1 voice");
							if (85584 - 334572 != -248988)
							{
								continue;
							}
							break;
						}
					}
					else if (this.$self_$31947.bulletRain2_vc)
					{
						if (72372 - 130707 != -58335)
						{
							continue;
						}
						this.$self_$31947.audio.PlayOneShot(this.$self_$31947.bulletRain2_vc);
						if (293794 - 471097 != -177303)
						{
							continue;
						}
						break;
					}
					else
					{
						Debug.LogError("Missing bulletRain2 voice");
						if (56310 - 244414 != -188104)
						{
							continue;
						}
						break;
					}
					IL_890:
					if (this.$i$31939 >= 10)
					{
						if (1948 - 560927 != -558978)
						{
							goto Block_58;
						}
					}
					else
					{
						this.$hitLayer$31940 = 130816 - (1 << this.$self_$31947.gameObject.layer);
						if (275367 - 230228 == 45139)
						{
							this.$hitList$31941 = Damage.FindAreaTarget(this.$self_$31947.transform.position, (float)16, (float)6, this.$hitLayer$31940);
							if (182614 - 392313 == -209699)
							{
								this.$$iterator$10729$31944 = UnityRuntimeServices.GetEnumerator(this.$hitList$31941);
								if (36850 - 80859 != -44008)
								{
									while (this.$$iterator$10729$31944.MoveNext())
									{
										object obj2;
										object obj = obj2 = this.$$iterator$10729$31944.Current;
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										this.$hitObject$31942 = (GameObject)obj2;
										if (264591 - 261152 != 3439)
										{
											goto IL_5A5;
										}
										if (this.$self_$31947.mChar.hit(10, this.$hitObject$31942, (int)(0.5f * (float)this.$self_$31947.mChar.atk + (float)this.$self_$31947.mChar.talAdjust(10)), 1, 0, this.$self_$31947.transform.forward) != 0)
										{
											if (46137 - 301060 == -254922)
											{
												goto IL_5A5;
											}
											this.$hitPoint$31943 = this.$hitObject$31942.collider.ClosestPointOnBounds(this.$self_$31947.transform.position + Vector3.up);
											if (193990 - 274968 != -80978)
											{
												goto IL_5A5;
											}
											UnityRuntimeServices.Update(this.$$iterator$10729$31944, this.$hitObject$31942);
											if (14001 - 527036 == -513034)
											{
												goto IL_5A5;
											}
										}
									}
									if (277351 - 264526 != 12826)
									{
										goto Block_13;
									}
								}
							}
						}
					}
				}
				IL_8F:
				return this.Yield(2, new WaitForSeconds(1.5f));
				IL_118:
				goto IL_A87;
				Block_13:
				return this.Yield(3, new WaitForSeconds(0.15f));
				IL_323:
				goto IL_A87;
				goto IL_8F;
				Block_46:
				goto IL_323;
				goto IL_8F;
				Block_58:
				return this.Yield(4, new WaitForSeconds(0.8f));
				IL_A87:
				return false;
			}

			// Token: 0x06004576 RID: 17782 RVA: 0x008B4594 File Offset: 0x008B2794
			internal static bool dgKCOh5Kc0sLsCl3VMoi()
			{
				return true;
			}

			// Token: 0x06004577 RID: 17783 RVA: 0x008B4598 File Offset: 0x008B2798
			internal static bool aRdrx65KUa9iU0o2DR7L()
			{
				return false;
			}

			// Token: 0x040050F5 RID: 20725
			internal int $i$31939;

			// Token: 0x040050F6 RID: 20726
			internal int $hitLayer$31940;

			// Token: 0x040050F7 RID: 20727
			internal UnityScript.Lang.Array $hitList$31941;

			// Token: 0x040050F8 RID: 20728
			internal GameObject $hitObject$31942;

			// Token: 0x040050F9 RID: 20729
			internal Vector3 $hitPoint$31943;

			// Token: 0x040050FA RID: 20730
			internal IEnumerator $$iterator$10729$31944;

			// Token: 0x040050FB RID: 20731
			internal Vector3 $mPos$31945;

			// Token: 0x040050FC RID: 20732
			internal Vector3 $tDir$31946;

			// Token: 0x040050FD RID: 20733
			internal Falcon $self_$31947;
		}
	}

	// Token: 0x02000C21 RID: 3105
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_thousandShot$31951 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004578 RID: 17784 RVA: 0x008B459C File Offset: 0x008B279C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_thousandShot$31951(Vector3 mPos, Vector3 tDir, Falcon self_)
		{
			if (198621 - 383695 != -185074)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (33751 - 210353 != -176601)
				{
					base..ctor();
					if (185191 - 552963 != -367771)
					{
						this.$mPos$31961 = mPos;
						if (250695 - 281193 == -30498)
						{
							this.$tDir$31962 = tDir;
							if (59840 - 332190 == -272350)
							{
								this.$self_$31963 = self_;
								if (11639 - 433772 != -422132)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x008B4678 File Offset: 0x008B2878
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Falcon.$RPC_thousandShot$31951.$(this.$mPos$31961, this.$tDir$31962, this.$self_$31963);
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x008B4694 File Offset: 0x008B2894
		internal static bool EfAUww5KTGu0TRcncobD()
		{
			return true;
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x008B4698 File Offset: 0x008B2898
		internal static bool NODKdw5K368yGcCEoy0a()
		{
			return false;
		}

		// Token: 0x040050FE RID: 20734
		internal Vector3 $mPos$31961;

		// Token: 0x040050FF RID: 20735
		internal Vector3 $tDir$31962;

		// Token: 0x04005100 RID: 20736
		internal Falcon $self_$31963;

		// Token: 0x02000C22 RID: 3106
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600457C RID: 17788 RVA: 0x008B469C File Offset: 0x008B289C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Falcon self_)
			{
				if (180924 - 534219 != -353294)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (168406 - 35150 == 133256)
					{
						base..ctor();
						if (214642 - 372387 == -157745)
						{
							this.$mPos$31958 = mPos;
							if (148092 - 308701 != -160608)
							{
								this.$tDir$31959 = tDir;
								if (72035 - 433718 != -361682)
								{
									this.$self_$31960 = self_;
									if (105105 - 392977 == -287872)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600457D RID: 17789 RVA: 0x008B4778 File Offset: 0x008B2978
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (273069 - 172031 != 101039)
				{
				}
				for (;;)
				{
					IL_796:
					switch (this._state)
					{
					case 0:
						goto IL_94F;
					case 1:
						goto IL_9FD;
					case 2:
						if (this.$self_$31960.mChar.actionState != "attack")
						{
							goto IL_6B;
						}
						if (210284 - 6552 == 203733)
						{
							continue;
						}
						if (this.$self_$31960.mChar.myCommand != "thousandShot")
						{
							if (65094 - 35902 != 29193)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$hitLayer$31952 = 130816 - (1 << this.$self_$31960.gameObject.layer);
							if (14154 - 211859 == -197704)
							{
								continue;
							}
							this.$hitList$31953 = null;
							if (239484 - 225098 != 14386)
							{
								continue;
							}
							this.$hitPoint$31954 = default(Vector3);
							if (46998 - 10785 == 36214)
							{
								continue;
							}
							this.$i$31955 = 0;
							if (16860 - 596645 == -579784)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$31960.mChar.actionState != "attack")
						{
							goto IL_642;
						}
						if (198344 - 220257 == -21912)
						{
							continue;
						}
						if (this.$self_$31960.mChar.myCommand != "thousandShot")
						{
							if (6219 - 387217 != -380997)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$i$31955++;
							if (234662 - 435500 == -200837)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$31960.mChar.actionState == "attack")
						{
							if (201402 - 582663 != -381261)
							{
								continue;
							}
							if (this.$self_$31960.mChar.myCommand == "thousandShot")
							{
								if (24080 - 201991 == -177910)
								{
									continue;
								}
								this.$self_$31960.mChar.moveSpeed = (float)0;
								if (186428 - 546478 == -360049)
								{
									continue;
								}
								this.$self_$31960.mChar.actionState = "standby";
								if (288534 - 466696 != -178162)
								{
									continue;
								}
								this.$self_$31960.mChar.actionTime = Time.time;
								if (270550 - 398518 == -127967)
								{
									continue;
								}
								this.$self_$31960.mChar.myCommand = "none";
								if (30658 - 20539 != 10119)
								{
									continue;
								}
								if (!this.$self_$31960.mChar.isMine)
								{
									if (186489 - 487019 != -300530)
									{
										continue;
									}
									this.$self_$31960.mChar.nPosition = this.$self_$31960.transform.position;
									if (249234 - 195622 != 53612)
									{
										continue;
									}
									this.$self_$31960.mChar.oPosition = this.$self_$31960.transform.position;
									if (244200 - 275666 != -31466)
									{
										continue;
									}
									this.$self_$31960.mChar.nDirection = this.$self_$31960.transform.forward;
									if (293139 - 131609 != 161530)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (20452 - 450856 != -430404)
						{
							continue;
						}
						goto IL_9FD;
					default:
						if (65497 - 582517 != -517019)
						{
							goto IL_94F;
						}
						continue;
					}
					if (this.$i$31955 >= 10)
					{
						if (195257 - 360714 != -165457)
						{
							continue;
						}
						goto IL_9AE;
					}
					else
					{
						if (!this.$self_$31960.mChar.isMine)
						{
							goto IL_3C2;
						}
						if (63499 - 75617 == -12117)
						{
							continue;
						}
						this.$hitList$31953 = Damage.FindRecTarget(this.$self_$31960.transform.position, this.$self_$31960.transform.forward, (float)2, (float)2, (float)24, (float)3, this.$hitLayer$31952);
						if (191030 - 545676 == -354645)
						{
							continue;
						}
						this.$$iterator$10730$31957 = UnityRuntimeServices.GetEnumerator(this.$hitList$31953);
						if (94329 - 551440 != -457111)
						{
							continue;
						}
						while (this.$$iterator$10730$31957.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10730$31957.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$31956 = (GameObject)obj2;
							if (44191 - 303213 != -259022)
							{
								goto IL_796;
							}
							if (this.$self_$31960.mChar.hit(10, this.$hitObject$31956, this.$self_$31960.mChar.atk + this.$self_$31960.mChar.talAdjust(30), 1, 0, this.$self_$31960.transform.forward) != 0)
							{
								if (287376 - 291534 == -4157)
								{
									goto IL_796;
								}
								this.$hitPoint$31954 = this.$hitObject$31956.collider.ClosestPointOnBounds(this.$self_$31960.transform.position + Vector3.up);
								if (225587 - 540783 == -315195)
								{
									goto IL_796;
								}
								UnityRuntimeServices.Update(this.$$iterator$10730$31957, this.$hitObject$31956);
								if (179102 - 211090 != -31988)
								{
									goto IL_796;
								}
							}
						}
						if (276722 - 507587 != -230864)
						{
							goto Block_41;
						}
						continue;
					}
					IL_94F:
					this.$self_$31960.mChar.actionState = "attack";
					if (40105 - 126550 == -86445)
					{
						this.$self_$31960.mChar.actionTime = Time.time;
						if (279729 - 10605 == 269124)
						{
							this.$self_$31960.mChar.myCommand = "thousandShot";
							if (202610 - 524512 == -321902)
							{
								this.$self_$31960.mChar.addTimeOut("thousandShot", (float)30);
								if (62349 - 412689 == -350340)
								{
									this.$self_$31960.transform.position = this.$mPos$31958;
									if (291138 - 258966 != 32173)
									{
										this.$self_$31960.transform.LookAt(this.$mPos$31958 + global::Math.vFlat(this.$tDir$31959));
										if (236526 - 416699 != -180172)
										{
											this.$self_$31960.animation.CrossFade("thousandShot");
											if (141335 - 74977 != 66359)
											{
												this.$self_$31960.animation.wrapMode = WrapMode.Once;
												if (222952 - 70211 == 152741)
												{
													this.$self_$31960.mChar.vMovement = this.$self_$31960.transform.forward;
													if (108411 - 541701 == -433290)
													{
														this.$self_$31960.mChar.moveSpeed = (float)0;
														if (108243 - 51915 != 56329)
														{
															if (this.$self_$31960.thousandShot_fire)
															{
																if (36791 - 413865 != -377074)
																{
																	continue;
																}
																this.$self_$31960.mChar.createEffect(this.$self_$31960.thousandShot_fire, this.$self_$31960.transform.position, this.$self_$31960.transform.rotation);
																if (217479 - 332452 != -114973)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing thousandShot_fire GameObject");
																if (25033 - 11696 != 13337)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_531;
															}
															if (265021 - 43049 != 221973)
															{
																if (this.$self_$31960.thousandShot_vc)
																{
																	if (269856 - 121184 == 148672)
																	{
																		this.$self_$31960.audio.PlayOneShot(this.$self_$31960.thousandShot_vc);
																		if (143093 - 399122 == -256029)
																		{
																			goto IL_6F2;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing thousandShot voice");
																	if (89353 - 553928 != -464574)
																	{
																		goto Block_45;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_6B:
				goto IL_9FD;
				Block_7:
				goto IL_6B;
				IL_3C2:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_28:
				goto IL_642;
				IL_531:
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_41:
				goto IL_3C2;
				IL_642:
				goto IL_9FD;
				IL_6F2:
				Block_45:
				goto IL_531;
				IL_9AE:
				return this.Yield(4, new WaitForSeconds(0.8f));
				IL_9FD:
				return false;
			}

			// Token: 0x0600457E RID: 17790 RVA: 0x008B5194 File Offset: 0x008B3394
			internal static bool lCvtSd5KXLbGMeH3EpmJ()
			{
				return true;
			}

			// Token: 0x0600457F RID: 17791 RVA: 0x008B5198 File Offset: 0x008B3398
			internal static bool ubTdoN5KQVexAT6K6eaT()
			{
				return false;
			}

			// Token: 0x04005101 RID: 20737
			internal int $hitLayer$31952;

			// Token: 0x04005102 RID: 20738
			internal UnityScript.Lang.Array $hitList$31953;

			// Token: 0x04005103 RID: 20739
			internal Vector3 $hitPoint$31954;

			// Token: 0x04005104 RID: 20740
			internal int $i$31955;

			// Token: 0x04005105 RID: 20741
			internal GameObject $hitObject$31956;

			// Token: 0x04005106 RID: 20742
			internal IEnumerator $$iterator$10730$31957;

			// Token: 0x04005107 RID: 20743
			internal Vector3 $mPos$31958;

			// Token: 0x04005108 RID: 20744
			internal Vector3 $tDir$31959;

			// Token: 0x04005109 RID: 20745
			internal Falcon $self_$31960;
		}
	}

	// Token: 0x02000C23 RID: 3107
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31964 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004580 RID: 17792 RVA: 0x008B519C File Offset: 0x008B339C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31964(UnityScript.Lang.Array nArray, Falcon self_)
		{
			if (241302 - 527001 != -285699)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (185516 - 60116 == 125400)
				{
					base..ctor();
					if (134709 - 363818 != -229108)
					{
						this.$nArray$31970 = nArray;
						if (67197 - 500312 == -433115)
						{
							this.$self_$31971 = self_;
							if (175920 - 42227 == 133693)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004581 RID: 17793 RVA: 0x008B5258 File Offset: 0x008B3458
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Falcon.$RPC_ko$31964.$(this.$nArray$31970, this.$self_$31971);
		}

		// Token: 0x06004582 RID: 17794 RVA: 0x008B526C File Offset: 0x008B346C
		internal static bool vNjnYn5KkKNZBDmVPpFF()
		{
			return true;
		}

		// Token: 0x06004583 RID: 17795 RVA: 0x008B5270 File Offset: 0x008B3470
		internal static bool Q7D7S25KGwHwBKxCY9nL()
		{
			return false;
		}

		// Token: 0x0400510A RID: 20746
		internal UnityScript.Lang.Array $nArray$31970;

		// Token: 0x0400510B RID: 20747
		internal Falcon $self_$31971;

		// Token: 0x02000C24 RID: 3108
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004584 RID: 17796 RVA: 0x008B5274 File Offset: 0x008B3474
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Falcon self_)
			{
				if (18631 - 142272 != -123641)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (270268 - 510291 == -240023)
					{
						base..ctor();
						if (65011 - 506810 != -441798)
						{
							this.$nArray$31968 = nArray;
							if (227708 - 137174 == 90534)
							{
								this.$self_$31969 = self_;
								if (230231 - 288599 != -58367)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004585 RID: 17797 RVA: 0x008B5330 File Offset: 0x008B3530
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (110039 - 395758 != -285718)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_659;
					case 2:
						if (this.$self_$31969.mChar.actionState != "ko")
						{
							if (81815 - 426007 != -344192)
							{
								continue;
							}
							goto IL_2B0;
						}
						else
						{
							this.$self_$31969.animation.Play("getUp");
							if (273372 - 101725 != 171647)
							{
								continue;
							}
							this.$self_$31969.animation.wrapMode = WrapMode.Once;
							if (43811 - 573884 != -530073)
							{
								continue;
							}
							goto IL_532;
						}
						break;
					case 3:
						if (this.$self_$31969.mChar.actionState != "ko")
						{
							if (240572 - 592430 != -351858)
							{
								continue;
							}
							goto IL_344;
						}
						else
						{
							this.$self_$31969.mChar.actionState = "standby";
							if (23192 - 341046 != -317854)
							{
								continue;
							}
							this.$self_$31969.mChar.actionTime = Time.time;
							if (254163 - 356851 == -102687)
							{
								continue;
							}
							this.$self_$31969.mChar.myCommand = "none";
							if (106924 - 348361 == -241436)
							{
								continue;
							}
							this.$self_$31969.mChar.ko = this.$self_$31969.mChar.mko;
							if (117107 - 502897 == -385789)
							{
								continue;
							}
							this.YieldDefault(1);
							if (26848 - 17746 != 9103)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					default:
						if (60161 - 211524 == -151362)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31969.mChar.actionState == "ko")
					{
						break;
					}
					if (226743 - 154373 != 72371)
					{
						if (this.$self_$31969.mChar.actionState == "dead")
						{
							if (237601 - 557379 != -319777)
							{
								break;
							}
						}
						else
						{
							this.$mPos$31965 = (Vector3)this.$nArray$31968[0];
							if (93192 - 305426 != -212233)
							{
								this.$mDir$31966 = (Vector3)this.$nArray$31968[1];
								if (35750 - 230541 == -194791)
								{
									this.$self_$31969.mChar.ko = 0;
									if (157372 - 352637 != -195264)
									{
										this.$self_$31969.mChar.actionState = "ko";
										if (14627 - 523255 != -508627)
										{
											this.$self_$31969.mChar.actionTime = Time.time;
											if (14998 - 511152 == -496154)
											{
												this.$self_$31969.mChar.myCommand = "none";
												if (14467 - 233707 != -219239)
												{
													this.$self_$31969.mChar.vMovement = Vector3.zero;
													if (278369 - 87887 != 190483)
													{
														this.$self_$31969.mChar.moveSpeed = (float)0;
														if (84394 - 565683 == -481289)
														{
															this.$self_$31969.animation.Play("ko");
															if (113807 - 23771 != 90037)
															{
																this.$self_$31969.animation.wrapMode = WrapMode.Once;
																if (152843 - 35881 != 116963)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) != 0)
																	{
																		if (233762 - 103481 == 130282)
																		{
																			continue;
																		}
																		if (this.$self_$31969.ko_vc)
																		{
																			if (201274 - 444694 == -243419)
																			{
																				continue;
																			}
																			this.$self_$31969.audio.PlayOneShot(this.$self_$31969.ko_vc);
																			if (291103 - 214917 != 76186)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			Debug.LogError("Missing ko voice");
																			if (33920 - 376915 == -342994)
																			{
																				continue;
																			}
																		}
																	}
																	if (this.$self_$31969.mChar.isControlled)
																	{
																		goto IL_5B0;
																	}
																	if (72974 - 407037 != -334062)
																	{
																		if (Game.mGameCode != 305)
																		{
																			goto IL_5B0;
																		}
																		if (140964 - 251250 == -110286)
																		{
																			this.$m$31967 = Language.getMessage("M305_ItalusAcceptance", UnityEngine.Random.Range(50, 55));
																			if (223359 - 352054 == -128695)
																			{
																				if (!(this.$m$31967 != string.Empty))
																				{
																					goto IL_5B0;
																				}
																				if (5620 - 279879 != -274258)
																				{
																					Chat.SubmitChat("Italus", this.$m$31967, eChatType.npc, eChatMode.system);
																					if (171995 - 469001 != -297005)
																					{
																						this.$self_$31969.mChar.doChatBubble(this.$m$31967);
																						if (61050 - 300858 == -239808)
																						{
																							goto IL_5B0;
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
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
				IL_2B0:
				IL_344:
				goto IL_659;
				IL_532:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_5B0:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_659:
				return false;
			}

			// Token: 0x06004586 RID: 17798 RVA: 0x008B59A8 File Offset: 0x008B3BA8
			internal static bool MK0hdK5KHh5vbkdUWGLK()
			{
				return true;
			}

			// Token: 0x06004587 RID: 17799 RVA: 0x008B59AC File Offset: 0x008B3BAC
			internal static bool qYPfHI5KWU0tEucNa7qx()
			{
				return false;
			}

			// Token: 0x0400510C RID: 20748
			internal Vector3 $mPos$31965;

			// Token: 0x0400510D RID: 20749
			internal Vector3 $mDir$31966;

			// Token: 0x0400510E RID: 20750
			internal string $m$31967;

			// Token: 0x0400510F RID: 20751
			internal UnityScript.Lang.Array $nArray$31968;

			// Token: 0x04005110 RID: 20752
			internal Falcon $self_$31969;
		}
	}

	// Token: 0x02000C25 RID: 3109
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31972 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004588 RID: 17800 RVA: 0x008B59B0 File Offset: 0x008B3BB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31972(UnityScript.Lang.Array nArray, Falcon self_)
		{
			if (238067 - 444733 != -206666)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (273046 - 52293 != 220754)
				{
					base..ctor();
					if (80222 - 192492 == -112270)
					{
						this.$nArray$31982 = nArray;
						if (28363 - 586025 != -557661)
						{
							this.$self_$31983 = self_;
							if (186694 - 92579 == 94115)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004589 RID: 17801 RVA: 0x008B5A6C File Offset: 0x008B3C6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Falcon.$RPC_dead$31972.$(this.$nArray$31982, this.$self_$31983);
		}

		// Token: 0x0600458A RID: 17802 RVA: 0x008B5A80 File Offset: 0x008B3C80
		internal static bool BWlmvs5KAT13lPauhVGI()
		{
			return true;
		}

		// Token: 0x0600458B RID: 17803 RVA: 0x008B5A84 File Offset: 0x008B3C84
		internal static bool SQAXdY5KlG2fD8pSXT3l()
		{
			return false;
		}

		// Token: 0x04005111 RID: 20753
		internal UnityScript.Lang.Array $nArray$31982;

		// Token: 0x04005112 RID: 20754
		internal Falcon $self_$31983;

		// Token: 0x02000C26 RID: 3110
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600458C RID: 17804 RVA: 0x008B5A88 File Offset: 0x008B3C88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Falcon self_)
			{
				if (286399 - 278555 != 7844)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (129392 - 444825 == -315433)
					{
						base..ctor();
						if (101707 - 250187 != -148479)
						{
							this.$nArray$31980 = nArray;
							if (276574 - 547074 == -270500)
							{
								this.$self_$31981 = self_;
								if (51670 - 500298 != -448627)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600458D RID: 17805 RVA: 0x008B5B44 File Offset: 0x008B3D44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (129215 - 336267 != -207052)
				{
				}
				for (;;)
				{
					IL_5E5:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_64C;
					case 2:
						if (this.$self_$31981.mChar.actionState != "dead")
						{
							if (255664 - 589973 != -334309)
							{
								continue;
							}
							goto IL_4E3;
						}
						else
						{
							if (!this.$self_$31981.mChar.isPlayer)
							{
								if (113291 - 557459 != -444168)
								{
									continue;
								}
								this.$mGameObjectList$31975 = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Player"), GameObject.FindGameObjectsWithTag("Enemy"));
								if (3453 - 13073 != -9620)
								{
									continue;
								}
								this.$$11468$31977 = 0;
								if (213493 - 78122 == 135372)
								{
									continue;
								}
								this.$$11469$31978 = this.$mGameObjectList$31975;
								if (121557 - 383081 != -261524)
								{
									continue;
								}
								this.$$11470$31979 = this.$$11469$31978.Length;
								if (86824 - 583146 == -496321)
								{
									continue;
								}
								while (this.$$11468$31977 < this.$$11470$31979)
								{
									if (this.$$11469$31978[this.$$11468$31977] != this.$self_$31981.gameObject)
									{
										if (205612 - 216574 != -10962)
										{
											goto IL_5E5;
										}
										Physics.IgnoreCollision(this.$$11469$31978[this.$$11468$31977].collider, this.$self_$31981.gameObject.collider, true);
										if (265266 - 551070 != -285804)
										{
											goto IL_5E5;
										}
									}
									this.$$11468$31977++;
									if (198650 - 398832 != -200182)
									{
										goto IL_5E5;
									}
								}
								if (205290 - 57095 != 148195)
								{
									continue;
								}
							}
							else if (this.$self_$31981.mChar.isMine)
							{
								if (199032 - 274506 != -75474)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31981.gameObject);
								if (109239 - 184886 != -75647)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (39985 - 455984 != -415999)
							{
								continue;
							}
							goto IL_64C;
						}
						break;
					default:
						if (20196 - 238242 == -218045)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31981.mChar.actionState == "dead")
					{
						if (2695 - 480733 != -478037)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$31973 = (Vector3)this.$nArray$31980[0];
						if (41219 - 164716 == -123497)
						{
							this.$myDirection$31974 = (Vector3)this.$nArray$31980[1];
							if (134304 - 125990 != 8315)
							{
								this.$self_$31981.transform.position = this.$myPosition$31973;
								if (53682 - 310424 != -256741)
								{
									this.$self_$31981.transform.LookAt(this.$myPosition$31973 + this.$myDirection$31974);
									if (94254 - 9727 == 84527)
									{
										this.$self_$31981.mChar.hp = 0;
										if (280279 - 486561 != -206281)
										{
											this.$self_$31981.mChar.actionState = "dead";
											if (39730 - 412371 == -372641)
											{
												this.$self_$31981.mChar.actionTime = Time.time;
												if (225169 - 515074 == -289905)
												{
													this.$self_$31981.mChar.myCommand = "none";
													if (83101 - 411437 == -328336)
													{
														this.$self_$31981.mChar.vMovement = Vector3.zero;
														if (61677 - 147413 != -85735)
														{
															this.$self_$31981.mChar.moveSpeed = (float)0;
															if (49963 - 45174 == 4789)
															{
																this.$self_$31981.animation.Rewind();
																if (287050 - 477769 != -190718)
																{
																	this.$self_$31981.animation.Play("ko");
																	if (238497 - 391833 == -153336)
																	{
																		this.$self_$31981.animation.wrapMode = WrapMode.Once;
																		if (216403 - 206011 == 10392)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				goto IL_1A7;
																			}
																			if (137765 - 304741 == -166976)
																			{
																				if (this.$self_$31981.dead_vc)
																				{
																					if (152267 - 334943 == -182676)
																					{
																						this.$self_$31981.audio.PlayOneShot(this.$self_$31981.dead_vc);
																						if (273392 - 46577 != 226816)
																						{
																							goto Block_28;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Missing dead voice");
																					if (216444 - 24684 == 191760)
																					{
																						goto IL_1A7;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_64C;
				IL_1A7:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_28:
				goto IL_1A7;
				IL_4E3:
				IL_64C:
				return false;
			}

			// Token: 0x0600458E RID: 17806 RVA: 0x008B61B0 File Offset: 0x008B43B0
			internal static bool TdqpY45Kyd6jqbtmv352()
			{
				return true;
			}

			// Token: 0x0600458F RID: 17807 RVA: 0x008B61B4 File Offset: 0x008B43B4
			internal static bool LfDmUs5KSSP11OVCtuJb()
			{
				return false;
			}

			// Token: 0x04005113 RID: 20755
			internal Vector3 $myPosition$31973;

			// Token: 0x04005114 RID: 20756
			internal Vector3 $myDirection$31974;

			// Token: 0x04005115 RID: 20757
			internal GameObject[] $mGameObjectList$31975;

			// Token: 0x04005116 RID: 20758
			internal GameObject $mGameObject$31976;

			// Token: 0x04005117 RID: 20759
			internal int $$11468$31977;

			// Token: 0x04005118 RID: 20760
			internal GameObject[] $$11469$31978;

			// Token: 0x04005119 RID: 20761
			internal int $$11470$31979;

			// Token: 0x0400511A RID: 20762
			internal UnityScript.Lang.Array $nArray$31980;

			// Token: 0x0400511B RID: 20763
			internal Falcon $self_$31981;
		}
	}
}
