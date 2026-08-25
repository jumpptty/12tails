using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D72 RID: 3442
[Serializable]
public class PirateFish : MonoBehaviour
{
	// Token: 0x06004D7C RID: 19836 RVA: 0x0098A9D8 File Offset: 0x00988BD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PirateFish()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004D7D RID: 19837 RVA: 0x0098A9E8 File Offset: 0x00988BE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (160362 - 316363 != -156001)
		{
		}
		for (;;)
		{
			this.tRDccVibpEh = this.transform;
			if (76766 - 275471 != -198704)
			{
				this.PhWcch37FpQ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (198740 - 540611 != -341870)
				{
					this.PhWcch37FpQ.actionState = "standby";
					if (237040 - 524369 == -287329)
					{
						this.PhWcch37FpQ.actionTime = Time.time;
						if (268126 - 66435 != 201692)
						{
							this.PhWcch37FpQ.myCommand = "none";
							if (160340 - 11143 != 149198)
							{
								this.PhWcch37FpQ.hp = (this.PhWcch37FpQ.mhp = 1350);
								if (70149 - 87077 == -16928)
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

	// Token: 0x06004D7E RID: 19838 RVA: 0x0098AB34 File Offset: 0x00988D34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.PhWcch37FpQ.isMine = true;
		}
	}

	// Token: 0x06004D7F RID: 19839 RVA: 0x0098AB50 File Offset: 0x00988D50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (270236 - 320591 != -50355)
		{
		}
		for (;;)
		{
			if (this.PhWcch37FpQ.isControlled)
			{
				if (113000 - 203487 != -90487)
				{
					continue;
				}
				if (!(this.PhWcch37FpQ.actionState == "standby"))
				{
					if (149491 - 273409 != -123918)
					{
						continue;
					}
					if (!(this.PhWcch37FpQ.actionState == "run"))
					{
						goto IL_210;
					}
					if (140291 - 336423 != -196132)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (163517 - 161083 != 2434)
				{
					continue;
				}
			}
			IL_210:
			if (this.PhWcch37FpQ.hp <= 0)
			{
				if (220691 - 263242 != -42551)
				{
					continue;
				}
				if (this.PhWcch37FpQ.actionState != "dead")
				{
					if (57989 - 60641 != -2652)
					{
						continue;
					}
					if (this.PhWcch37FpQ.isMine)
					{
						if (230375 - 50231 != 180144)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (127019 - 61907 != 65112)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (81474 - 130982 == -49507)
						{
							continue;
						}
						this.PhWcch37FpQ.DeadEvent();
						if (161250 - 599996 != -438745)
						{
							break;
						}
						continue;
					}
					else
					{
						this.PhWcch37FpQ.hp = 1;
						if (226822 - 311272 != -84450)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.PhWcch37FpQ.hp <= 0)
			{
				break;
			}
			if (124641 - 515307 == -390666)
			{
				if (this.PhWcch37FpQ.ko > 0)
				{
					break;
				}
				if (45929 - 411043 != -365113)
				{
					if (!(this.PhWcch37FpQ.actionState != "ko"))
					{
						break;
					}
					if (183404 - 114522 == 68882)
					{
						if (!(this.PhWcch37FpQ.actionState != "dead"))
						{
							break;
						}
						if (201743 - 136166 == 65577)
						{
							if (this.PhWcch37FpQ.isMine)
							{
								if (177608 - 3627 == 173981)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (67210 - 505293 == -438083)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (219582 - 190865 == 28717)
										{
											this.PhWcch37FpQ.KoEvent();
											if (71729 - 312691 != -240961)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.PhWcch37FpQ.ko = 1;
								if (277669 - 293807 == -16138)
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

	// Token: 0x06004D80 RID: 19840 RVA: 0x0098AF48 File Offset: 0x00989148
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (160586 - 483693 != -323106)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (984 - 482974 == -481990)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (231033 - 291881 != -60847 && 101786 - 383719 != -281932)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (34907 - 354091 != -319184)
						{
							continue;
						}
						v = 1;
						if (50492 - 288383 != -237891)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (23064 - 326034 == -302969)
						{
							continue;
						}
						v = -1;
						if (289289 - 338560 != -49271)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack")
					{
						if (26810 - 7658 != 19152)
						{
							continue;
						}
						v = 11;
						if (76753 - 187557 == -110803)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack_hit")
					{
						if (85572 - 567009 == -481436)
						{
							continue;
						}
						v = -11;
						if (118075 - 2695 != 115380)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (149141 - 46931 != 102210)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (110482 - 7982 != 102501)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (316 - 235432 != -235115)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (135781 - 211319 != -75537)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (23788 - 322431 == -298643)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (288836 - 315394 == -26558)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (276642 - 487824 == -211182)
										{
											Hashtable hashtable = new Hashtable();
											if (186258 - 599098 == -412840)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (252583 - 483232 != -230648)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (235156 - 195839 == 39317)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (25494 - 322791 == -297297)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (30234 - 15478 == 14756)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (93430 - 115585 != -22154)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (83168 - 510608 == -427440)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (13378 - 337083 != -323704)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (277646 - 420056 == -142410)
																			{
																				PhotonClient.SendEvent(this.PhWcch37FpQ.ActorNr, 74, hashtable, true, true);
																				if (14828 - 312527 == -297699)
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

	// Token: 0x06004D81 RID: 19841 RVA: 0x0098B460 File Offset: 0x00989660
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (260573 - 45011 != 215563)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (278238 - 552347 != -274108)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (111253 - 455172 != -343918)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (153992 - 378700 != -224707)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (165102 - 185523 == -20421)
						{
							int num3 = num;
							if (106749 - 479245 != -372495)
							{
								if (num3 == 1)
								{
									if (13041 - 560666 == -547625)
									{
										if (this.PhWcch37FpQ.isMine)
										{
											break;
										}
										if (40593 - 111779 == -71186)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (283963 - 483069 != -199105)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (186399 - 548518 != -362118)
									{
										if (this.PhWcch37FpQ.isMine)
										{
											break;
										}
										if (71922 - 524829 == -452907)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (100705 - 348157 != -247451)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (227622 - 555931 != -328308)
									{
										if (this.PhWcch37FpQ.isMine)
										{
											break;
										}
										if (93607 - 250095 != -156487)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (172223 - 515216 != -342992)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (189576 - 315279 != -125702)
									{
										if (this.PhWcch37FpQ.isMine)
										{
											break;
										}
										if (194507 - 95089 == 99418)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (195422 - 499005 == -303583)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (111664 - 557328 != -445663)
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

	// Token: 0x06004D82 RID: 19842 RVA: 0x0098B7E4 File Offset: 0x009899E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (173248 - 486649 != -313401)
		{
		}
		for (;;)
		{
			float num = this.PhWcch37FpQ.moveSpeed;
			if (6323 - 79515 == -73192)
			{
				float runSpeed = this.PhWcch37FpQ.runSpeed;
				if (195280 - 323158 == -127878)
				{
					Vector3 a = default(Vector3);
					if (153928 - 135930 == 17998)
					{
						Vector3 vector = Vector3.zero;
						if (178535 - 477355 == -298820)
						{
							float num2 = (float)0;
							if (273501 - 443772 != -170270)
							{
								if (this.PhWcch37FpQ.isMine)
								{
									if (54933 - 517385 == -462451)
									{
										continue;
									}
									if ((this.PhWcch37FpQ.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (98369 - 297117 != -198748)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (204251 - 274685 != -70434)
										{
											continue;
										}
										a.y = (float)0;
										if (186207 - 250011 == -63803)
										{
											continue;
										}
										a = a.normalized;
										if (121454 - 498050 != -376596)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (106866 - 66233 != 40633)
										{
											continue;
										}
										vector = vector.normalized;
										if (163000 - 215586 != -52586)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (195536 - 343986 == -148449)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (225154 - 436013 == -210858)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (35505 - 495260 == -459754)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (191274 - 524491 == -333216)
														{
															continue;
														}
														this.PhWcch37FpQ.actionState = "run";
														if (61901 - 192657 == -130755)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (282216 - 188765 != 93451)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (183335 - 574770 != -391435)
														{
															continue;
														}
														this.animation.Play("run");
														if (147189 - 264215 != -117026)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (53077 - 301878 != -248800)
														{
															goto IL_28B;
														}
														continue;
													}
												}
											}
										}
										this.PhWcch37FpQ.actionState = "standby";
										if (187774 - 513916 == -326141)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (143704 - 139497 == 4208)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (268180 - 365086 != -96906)
											{
												continue;
											}
											num = (float)0;
											if (170185 - 419050 != -248865)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (128607 - 129341 == -733)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (274578 - 265119 != 9459)
										{
											continue;
										}
									}
									IL_28B:;
								}
								else
								{
									vector = global::Math.vFlat(this.PhWcch37FpQ.nPosition - this.transform.position);
									if (192388 - 139903 == 52486)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (273276 - 44621 != 228655)
									{
										continue;
									}
									if (this.PhWcch37FpQ.nSpeed != (float)0)
									{
										if (28328 - 232737 != -204409)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (245486 - 400682 == -155195)
											{
												continue;
											}
											this.transform.position = this.PhWcch37FpQ.nPosition;
											if (31639 - 45445 != -13806)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (289847 - 37682 == 252166)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (264173 - 391015 == -126841)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (204807 - 88986 == 115822)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.PhWcch37FpQ.nSpeed, (float)10 * Time.deltaTime);
												if (230560 - 178511 == 52050)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (180753 - 401230 != -220477)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (53667 - 167814 != -114147)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (52692 - 217127 == -164434)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (152674 - 57168 != 95506)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (110052 - 373002 == -262949)
											{
												continue;
											}
										}
										else if (Time.time > this.PhWcch37FpQ.nSpeed + 0.3f)
										{
											if (216748 - 409817 != -193069)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (281793 - 533450 == -251656)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (93294 - 23969 != 69325)
												{
													continue;
												}
												num = (float)0;
												if (104631 - 568969 == -464337)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.PhWcch37FpQ.nDirection);
											if (44012 - 123527 == -79514)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (3146 - 194116 != -190970)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (154826 - 591256 != -436430)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (201737 - 513272 == -311534)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (197352 - 124328 == 73025)
											{
												continue;
											}
											this.transform.position = this.PhWcch37FpQ.nPosition;
											if (135701 - 357989 == -222287)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (204958 - 449647 != -244689)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (124690 - 552191 != -427501)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (8945 - 197928 != -188983)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (240097 - 514076 == -273978)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (97529 - 333999 == -236469)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (88832 - 501418 != -412586)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (187815 - 314391 == -126575)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.PhWcch37FpQ.nDirection);
											if (72536 - 437790 != -365254)
											{
												continue;
											}
											num = (float)0;
											if (191149 - 412618 == -221468)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (206079 - 539592 == -333512)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (203334 - 504718 == -301383)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (272521 - 217939 != 54582)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (94166 - 490819 == -396652)
										{
											continue;
										}
									}
								}
								this.PhWcch37FpQ.vMovement = vector;
								if (98403 - 501261 != -402857)
								{
									this.PhWcch37FpQ.moveSpeed = num;
									if (236891 - 218288 != 18604)
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

	// Token: 0x06004D83 RID: 19843 RVA: 0x0098C348 File Offset: 0x0098A548
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (284929 - 284618 != 312)
		{
		}
		for (;;)
		{
			if (!this.PhWcch37FpQ.isMine)
			{
				if (171747 - 296705 != -124957)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (151214 - 240644 != -89429)
				{
					Vector3 vector = a - this.transform.position;
					if (196930 - 233954 == -37024)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (17424 - 464652 != -447227)
						{
							CharacterControl characterControl = null;
							if (169374 - 257721 != -88346)
							{
								if (265427 - 114666 == 150761)
								{
									if (gameObject)
									{
										if (87209 - 198063 != -110854)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (6630 - 51625 == -44994)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (259651 - 365801 == -106149)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (201935 - 596949 != -395014)
										{
											continue;
										}
									}
									if (!(this.PhWcch37FpQ.actionState == "standby"))
									{
										if (104508 - 298766 != -194258)
										{
											continue;
										}
										if (!(this.PhWcch37FpQ.actionState == "run"))
										{
											break;
										}
										if (206991 - 358824 == -151832)
										{
											continue;
										}
									}
									if (this.PhWcch37FpQ.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (92671 - 565122 != -472450)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (25536 - 584585 == -559049)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (43367 - 235098 == -191731)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (239320 - 541729 == -302409)
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

	// Token: 0x06004D84 RID: 19844 RVA: 0x0098C640 File Offset: 0x0098A840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (255394 - 454666 != -199272)
		{
		}
		for (;;)
		{
			if (!this.PhWcch37FpQ.isMine)
			{
				if (178154 - 149477 == 28677)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (251672 - 285946 != -34273)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (42922 - 541302 != -498379)
					{
						Vector3 normalized = vector.normalized;
						if (175254 - 419191 == -243937)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (287311 - 19673 == 267638)
							{
								CharacterControl characterControl = null;
								if (44805 - 418090 != -373284)
								{
									if (269666 - 79521 == 190145)
									{
										if (gameObject)
										{
											if (101663 - 211796 != -110133)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (102125 - 15352 == 86774)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (296208 - 316959 != -20751)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (78255 - 381431 != -303176)
											{
												continue;
											}
										}
										if (!(this.PhWcch37FpQ.actionState == "standby"))
										{
											if (211194 - 479390 != -268196)
											{
												continue;
											}
											if (!(this.PhWcch37FpQ.actionState == "run"))
											{
												break;
											}
											if (16648 - 286421 != -269773)
											{
												continue;
											}
										}
										if (this.PhWcch37FpQ.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (254062 - 265564 == -11502)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
											if (85891 - 579842 == -493951)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (185472 - 331391 == -145919)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, normalized, 0);
													if (236689 - 296353 != -59663)
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

	// Token: 0x06004D85 RID: 19845 RVA: 0x0098C960 File Offset: 0x0098AB60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004D86 RID: 19846 RVA: 0x0098C964 File Offset: 0x0098AB64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PirateFish.$RPC_nAttack$33281(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004D87 RID: 19847 RVA: 0x0098C974 File Offset: 0x0098AB74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (286706 - 162195 != 124511)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (76130 - 574085 != -497954)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (66226 - 485516 != -419289)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (273400 - 474519 == -201119)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004D88 RID: 19848 RVA: 0x0098CA2C File Offset: 0x0098AC2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PirateFish.$RPC_cAttack$33295(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004D89 RID: 19849 RVA: 0x0098CA3C File Offset: 0x0098AC3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (163734 - 442054 != -278320)
		{
		}
		for (;;)
		{
			if (this.cAttack_hit)
			{
				if (184952 - 505829 == -320877)
				{
					UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (230770 - 456261 == -225491)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find cAttack_hit effect");
				if (274283 - 176592 == 97691)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004D8A RID: 19850 RVA: 0x0098CAF4 File Offset: 0x0098ACF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new PirateFish.$RPC_ko$33307(nArray, this).GetEnumerator();
	}

	// Token: 0x06004D8B RID: 19851 RVA: 0x0098CB04 File Offset: 0x0098AD04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new PirateFish.$RPC_dead$33314(nArray, this).GetEnumerator();
	}

	// Token: 0x06004D8C RID: 19852 RVA: 0x0098CB14 File Offset: 0x0098AD14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004D8D RID: 19853 RVA: 0x0098CB18 File Offset: 0x0098AD18
	internal static bool gQTX7B5b55o5Y7LWVfYW()
	{
		return true;
	}

	// Token: 0x06004D8E RID: 19854 RVA: 0x0098CB1C File Offset: 0x0098AD1C
	internal static bool os93JZ5bpDo0TDkY490m()
	{
		return false;
	}

	// Token: 0x040057AA RID: 22442
	private Transform tRDccVibpEh;

	// Token: 0x040057AB RID: 22443
	private CharacterControl PhWcch37FpQ;

	// Token: 0x040057AC RID: 22444
	public GameObject nAttack_ring;

	// Token: 0x040057AD RID: 22445
	public GameObject nAttack_hit;

	// Token: 0x040057AE RID: 22446
	public GameObject cAttack_ring;

	// Token: 0x040057AF RID: 22447
	public GameObject cAttack_hit;

	// Token: 0x040057B0 RID: 22448
	public GameObject deadEffect;

	// Token: 0x02000D73 RID: 3443
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33281 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004D8F RID: 19855 RVA: 0x0098CB20 File Offset: 0x0098AD20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33281(Vector3 mPos, Vector3 tDir, PirateFish self_)
		{
			if (132534 - 373321 != -240787)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (96729 - 540728 == -443999)
				{
					base..ctor();
					if (144651 - 296605 != -151953)
					{
						this.$mPos$33292 = mPos;
						if (193885 - 380815 != -186929)
						{
							this.$tDir$33293 = tDir;
							if (237295 - 585581 == -348286)
							{
								this.$self_$33294 = self_;
								if (36092 - 87394 == -51302)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x0098CBFC File Offset: 0x0098ADFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PirateFish.$RPC_nAttack$33281.$(this.$mPos$33292, this.$tDir$33293, this.$self_$33294);
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x0098CC18 File Offset: 0x0098AE18
		internal static bool Bc3G8U5bV6lvM8Elr3ZW()
		{
			return true;
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x0098CC1C File Offset: 0x0098AE1C
		internal static bool K2DQFQ5btKgi1TWsdCPG()
		{
			return false;
		}

		// Token: 0x040057B1 RID: 22449
		internal Vector3 $mPos$33292;

		// Token: 0x040057B2 RID: 22450
		internal Vector3 $tDir$33293;

		// Token: 0x040057B3 RID: 22451
		internal PirateFish $self_$33294;

		// Token: 0x02000D74 RID: 3444
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004D93 RID: 19859 RVA: 0x0098CC20 File Offset: 0x0098AE20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PirateFish self_)
			{
				if (67820 - 357305 != -289484)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (63716 - 568725 != -505008)
					{
						base..ctor();
						if (110225 - 338740 == -228515)
						{
							this.$mPos$33289 = mPos;
							if (210432 - 347986 != -137553)
							{
								this.$tDir$33290 = tDir;
								if (131063 - 191327 != -60263)
								{
									this.$self_$33291 = self_;
									if (54882 - 582621 != -527738)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004D94 RID: 19860 RVA: 0x0098CCFC File Offset: 0x0098AEFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194145 - 299108 != -104963)
				{
				}
				for (;;)
				{
					IL_C9B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_D97;
					case 2:
						if (this.$self_$33291.PhWcch37FpQ.actionState != "attack")
						{
							goto IL_A8A;
						}
						if (87632 - 212343 == -124710)
						{
							continue;
						}
						if (this.$self_$33291.PhWcch37FpQ.myCommand != "nAttack")
						{
							if (74298 - 172244 != -97945)
							{
								goto Block_79;
							}
							continue;
						}
						else
						{
							this.$self_$33291.PhWcch37FpQ.moveSpeed = (float)6;
							if (254532 - 494578 != -240046)
							{
								continue;
							}
							if (this.$self_$33291.nAttack_ring)
							{
								if (193233 - 543393 == -350159)
								{
									continue;
								}
								this.$self_$33291.PhWcch37FpQ.createEffect(this.$self_$33291.nAttack_ring, this.$self_$33291.transform.position, this.$self_$33291.transform.rotation);
								if (279273 - 247399 != 31875)
								{
									goto Block_40;
								}
								continue;
							}
							else
							{
								Debug.LogError("Missing nAttack_ring Effect");
								if (14928 - 225338 != -210409)
								{
									goto Block_45;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$33291.PhWcch37FpQ.actionState != "attack")
						{
							goto IL_B6C;
						}
						if (185080 - 281402 == -96321)
						{
							continue;
						}
						if (this.$self_$33291.PhWcch37FpQ.myCommand != "nAttack")
						{
							if (54033 - 483842 != -429808)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$self_$33291.PhWcch37FpQ.moveSpeed = (float)0;
							if (197537 - 206681 == -9143)
							{
								continue;
							}
							this.$hitLayer$33282 = 130816 - (1 << this.$self_$33291.gameObject.layer);
							if (284313 - 523627 == -239313)
							{
								continue;
							}
							this.$hitList$33283 = null;
							if (18381 - 55357 != -36976)
							{
								continue;
							}
							this.$hitPos$33284 = default(Vector3);
							if (8661 - 271898 != -263237)
							{
								continue;
							}
							if (!this.$self_$33291.PhWcch37FpQ.isMine)
							{
								goto IL_673;
							}
							if (22293 - 122949 != -100656)
							{
								continue;
							}
							this.$hitList$33283 = Damage.FindRecTarget(this.$self_$33291.transform.position, this.$self_$33291.transform.forward, (float)1, (float)1, (float)2, (float)3, this.$hitLayer$33282);
							if (140043 - 197223 == -57179)
							{
								continue;
							}
							this.$$iterator$10820$33286 = UnityRuntimeServices.GetEnumerator(this.$hitList$33283);
							if (54586 - 224411 != -169825)
							{
								continue;
							}
							while (this.$$iterator$10820$33286.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10820$33286.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33285 = (GameObject)obj2;
								if (247159 - 210101 == 37059)
								{
									goto IL_C9B;
								}
								if (this.$self_$33291.PhWcch37FpQ.hit(1, this.$hitObject$33285, this.$self_$33291.PhWcch37FpQ.atk, 4, 0, this.$self_$33291.transform.forward) != 0)
								{
									if (4650 - 356187 != -351537)
									{
										goto IL_C9B;
									}
									this.$hitPos$33284 = this.$hitObject$33285.collider.ClosestPointOnBounds(this.$self_$33291.transform.position + Vector3.up);
									if (56895 - 568726 != -511831)
									{
										goto IL_C9B;
									}
									UnityRuntimeServices.Update(this.$$iterator$10820$33286, this.$hitObject$33285);
									if (7589 - 190291 != -182702)
									{
										goto IL_C9B;
									}
									this.$self_$33291.RPC_nAttack_hit(this.$hitPos$33284, this.$self_$33291.transform.forward, 0);
									if (95866 - 357920 != -262054)
									{
										goto IL_C9B;
									}
									if (PhotonClient.IsInitialized())
									{
										if (244715 - 571355 == -326639)
										{
											goto IL_C9B;
										}
										this.$self_$33291.ActionEvent("RPC_nAttack_hit", this.$hitPos$33284, this.$self_$33291.transform.forward, 0);
										if (136942 - 121095 != 15847)
										{
											goto IL_C9B;
										}
									}
								}
							}
							if (250434 - 293185 != -42751)
							{
								continue;
							}
							goto IL_673;
						}
						break;
					case 4:
						if (this.$self_$33291.PhWcch37FpQ.actionState != "attack")
						{
							goto IL_9DB;
						}
						if (11345 - 290819 == -279473)
						{
							continue;
						}
						if (this.$self_$33291.PhWcch37FpQ.myCommand != "nAttack")
						{
							if (207312 - 477336 != -270024)
							{
								continue;
							}
							goto IL_9DB;
						}
						else
						{
							this.$self_$33291.PhWcch37FpQ.moveSpeed = (float)6;
							if (190751 - 195710 != -4958)
							{
								goto Block_62;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$33291.PhWcch37FpQ.actionState != "attack")
						{
							goto IL_3AE;
						}
						if (111833 - 485193 != -373360)
						{
							continue;
						}
						if (this.$self_$33291.PhWcch37FpQ.myCommand != "nAttack")
						{
							if (12724 - 92123 != -79399)
							{
								continue;
							}
							goto IL_3AE;
						}
						else
						{
							this.$self_$33291.PhWcch37FpQ.moveSpeed = (float)0;
							if (95725 - 313640 != -217915)
							{
								continue;
							}
							if (!this.$self_$33291.PhWcch37FpQ.isMine)
							{
								goto IL_7D0;
							}
							if (63337 - 64572 != -1235)
							{
								continue;
							}
							this.$hitList$33283 = Damage.FindRecTarget(this.$self_$33291.transform.position, this.$self_$33291.transform.forward, (float)1, (float)1, (float)2, (float)3, this.$hitLayer$33282);
							if (223146 - 551962 == -328815)
							{
								continue;
							}
							this.$$iterator$10821$33288 = UnityRuntimeServices.GetEnumerator(this.$hitList$33283);
							if (185295 - 282126 != -96831)
							{
								continue;
							}
							while (this.$$iterator$10821$33288.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10821$33288.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$33287 = (GameObject)obj4;
								if (286119 - 357442 != -71323)
								{
									goto IL_C9B;
								}
								if (this.$self_$33291.PhWcch37FpQ.hit(1, this.$hitObject$33287, this.$self_$33291.PhWcch37FpQ.atk, 4, 0, this.$self_$33291.transform.forward) != 0)
								{
									if (240116 - 14222 == 225895)
									{
										goto IL_C9B;
									}
									this.$hitPos$33284 = this.$hitObject$33287.collider.ClosestPointOnBounds(this.$self_$33291.transform.position + Vector3.up);
									if (206216 - 192041 != 14175)
									{
										goto IL_C9B;
									}
									UnityRuntimeServices.Update(this.$$iterator$10821$33288, this.$hitObject$33287);
									if (13180 - 226493 != -213313)
									{
										goto IL_C9B;
									}
									this.$self_$33291.RPC_nAttack_hit(this.$hitPos$33284, this.$self_$33291.transform.forward, 0);
									if (133243 - 306350 != -173107)
									{
										goto IL_C9B;
									}
									if (PhotonClient.IsInitialized())
									{
										if (76382 - 402901 != -326519)
										{
											goto IL_C9B;
										}
										this.$self_$33291.ActionEvent("RPC_nAttack_hit", this.$hitPos$33284, this.$self_$33291.transform.forward, 0);
										if (242029 - 597304 != -355275)
										{
											goto IL_C9B;
										}
									}
								}
							}
							if (94627 - 522365 != -427737)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$33291.PhWcch37FpQ.actionState == "attack")
						{
							if (255832 - 277760 != -21928)
							{
								continue;
							}
							if (this.$self_$33291.PhWcch37FpQ.myCommand == "nAttack")
							{
								if (262597 - 153763 != 108834)
								{
									continue;
								}
								this.$self_$33291.PhWcch37FpQ.actionState = "standby";
								if (233101 - 332085 == -98983)
								{
									continue;
								}
								this.$self_$33291.PhWcch37FpQ.actionTime = Time.time;
								if (199757 - 81437 == 118321)
								{
									continue;
								}
								this.$self_$33291.PhWcch37FpQ.myCommand = "none";
								if (87192 - 179301 == -92108)
								{
									continue;
								}
								if (!this.$self_$33291.PhWcch37FpQ.isMine)
								{
									if (15645 - 287234 != -271589)
									{
										continue;
									}
									this.$self_$33291.PhWcch37FpQ.nPosition = this.$self_$33291.transform.position;
									if (174790 - 200145 == -25354)
									{
										continue;
									}
									this.$self_$33291.PhWcch37FpQ.oPosition = this.$self_$33291.transform.position;
									if (207255 - 71666 == 135590)
									{
										continue;
									}
									this.$self_$33291.PhWcch37FpQ.nDirection = this.$self_$33291.transform.forward;
									if (278261 - 302518 == -24256)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (283682 - 317297 != -33614)
						{
							goto Block_83;
						}
						continue;
					default:
						if (78171 - 440263 == -362091)
						{
							continue;
						}
						break;
					}
					this.$self_$33291.PhWcch37FpQ.actionState = "attack";
					if (203575 - 170045 != 33531)
					{
						this.$self_$33291.PhWcch37FpQ.actionTime = Time.time;
						if (191592 - 420623 != -229030)
						{
							this.$self_$33291.PhWcch37FpQ.myCommand = "nAttack";
							if (144841 - 94458 == 50383)
							{
								this.$self_$33291.PhWcch37FpQ.addTimeOut("nAttack", (float)2);
								if (224315 - 31261 != 193055)
								{
									this.$self_$33291.transform.position = this.$mPos$33289;
									if (12634 - 540032 != -527397)
									{
										this.$self_$33291.transform.LookAt(this.$mPos$33289 + global::Math.vFlat(this.$tDir$33290));
										if (167814 - 438432 != -270617)
										{
											this.$self_$33291.animation.Play("nAttack");
											if (274700 - 583794 != -309093)
											{
												this.$self_$33291.animation.wrapMode = WrapMode.Once;
												if (96140 - 562827 == -466687)
												{
													this.$self_$33291.PhWcch37FpQ.vMovement = this.$self_$33291.transform.forward;
													if (45353 - 90474 == -45121)
													{
														this.$self_$33291.PhWcch37FpQ.moveSpeed = (float)0;
														if (120477 - 518419 == -397942)
														{
															goto IL_27E;
														}
													}
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
				goto IL_B6C;
				Block_12:
				goto IL_7D0;
				IL_22F:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_27E:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_3AE:
				goto IL_D97;
				Block_40:
				goto IL_22F;
				IL_673:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_45:
				goto IL_22F;
				IL_7D0:
				return this.Yield(6, new WaitForSeconds(0.1f));
				IL_9DB:
				goto IL_D97;
				Block_62:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_A8A:
				IL_B6C:
				Block_79:
				Block_83:
				IL_D97:
				return false;
			}

			// Token: 0x06004D95 RID: 19861 RVA: 0x0098DAB4 File Offset: 0x0098BCB4
			internal static bool TaKrgq5bNfGFjCCqoA58()
			{
				return true;
			}

			// Token: 0x06004D96 RID: 19862 RVA: 0x0098DAB8 File Offset: 0x0098BCB8
			internal static bool HTkBoa5bYTqYTKn7OZSH()
			{
				return false;
			}

			// Token: 0x040057B4 RID: 22452
			internal int $hitLayer$33282;

			// Token: 0x040057B5 RID: 22453
			internal UnityScript.Lang.Array $hitList$33283;

			// Token: 0x040057B6 RID: 22454
			internal Vector3 $hitPos$33284;

			// Token: 0x040057B7 RID: 22455
			internal GameObject $hitObject$33285;

			// Token: 0x040057B8 RID: 22456
			internal IEnumerator $$iterator$10820$33286;

			// Token: 0x040057B9 RID: 22457
			internal GameObject $hitObject$33287;

			// Token: 0x040057BA RID: 22458
			internal IEnumerator $$iterator$10821$33288;

			// Token: 0x040057BB RID: 22459
			internal Vector3 $mPos$33289;

			// Token: 0x040057BC RID: 22460
			internal Vector3 $tDir$33290;

			// Token: 0x040057BD RID: 22461
			internal PirateFish $self_$33291;
		}
	}

	// Token: 0x02000D75 RID: 3445
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$33295 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004D97 RID: 19863 RVA: 0x0098DABC File Offset: 0x0098BCBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$33295(Vector3 mPos, Vector3 tDir, PirateFish self_)
		{
			if (23069 - 261495 != -238425)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (229540 - 403795 == -174255)
				{
					base..ctor();
					if (237114 - 581124 != -344009)
					{
						this.$mPos$33304 = mPos;
						if (44704 - 224443 != -179738)
						{
							this.$tDir$33305 = tDir;
							if (77116 - 173319 != -96202)
							{
								this.$self_$33306 = self_;
								if (187427 - 406235 != -218807)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004D98 RID: 19864 RVA: 0x0098DB98 File Offset: 0x0098BD98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PirateFish.$RPC_cAttack$33295.$(this.$mPos$33304, this.$tDir$33305, this.$self_$33306);
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x0098DBB4 File Offset: 0x0098BDB4
		internal static bool A1GZUX5bckY0qC7j5Y9D()
		{
			return true;
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x0098DBB8 File Offset: 0x0098BDB8
		internal static bool Jvj6XP5bUbiE99j7RBEh()
		{
			return false;
		}

		// Token: 0x040057BE RID: 22462
		internal Vector3 $mPos$33304;

		// Token: 0x040057BF RID: 22463
		internal Vector3 $tDir$33305;

		// Token: 0x040057C0 RID: 22464
		internal PirateFish $self_$33306;

		// Token: 0x02000D76 RID: 3446
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004D9B RID: 19867 RVA: 0x0098DBBC File Offset: 0x0098BDBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PirateFish self_)
			{
				if (70553 - 363405 != -292851)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (196977 - 114892 == 82085)
					{
						base..ctor();
						if (16347 - 54039 == -37692)
						{
							this.$mPos$33301 = mPos;
							if (96729 - 468054 != -371324)
							{
								this.$tDir$33302 = tDir;
								if (223791 - 440402 == -216611)
								{
									this.$self_$33303 = self_;
									if (70549 - 158627 == -88078)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004D9C RID: 19868 RVA: 0x0098DC98 File Offset: 0x0098BE98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (181986 - 228473 != -46487)
				{
				}
				for (;;)
				{
					IL_357:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_98A;
					case 2:
						if (this.$self_$33303.PhWcch37FpQ.actionState != "attack")
						{
							goto IL_792;
						}
						if (83777 - 295071 == -211293)
						{
							continue;
						}
						if (this.$self_$33303.PhWcch37FpQ.myCommand != "cAttack")
						{
							if (175563 - 132151 != 43413)
							{
								goto Block_57;
							}
							continue;
						}
						else
						{
							this.$self_$33303.PhWcch37FpQ.moveSpeed = (float)9;
							if (274822 - 592055 == -317232)
							{
								continue;
							}
							if (this.$self_$33303.cAttack_ring)
							{
								if (109867 - 393794 != -283927)
								{
									continue;
								}
								this.$self_$33303.PhWcch37FpQ.createEffect(this.$self_$33303.cAttack_ring, this.$self_$33303.transform.position, this.$self_$33303.transform.rotation);
								if (73549 - 238688 != -165139)
								{
									continue;
								}
								goto IL_14C;
							}
							else
							{
								Debug.LogError("Missing cAttack_ring Effect");
								if (79139 - 235205 != -156066)
								{
									continue;
								}
								goto IL_390;
							}
						}
						break;
					case 3:
						if (this.$self_$33303.PhWcch37FpQ.actionState != "attack")
						{
							goto IL_8A2;
						}
						if (285705 - 567861 != -282156)
						{
							continue;
						}
						if (this.$self_$33303.PhWcch37FpQ.myCommand != "cAttack")
						{
							if (170595 - 26205 != 144391)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$self_$33303.PhWcch37FpQ.moveSpeed = (float)0;
							if (52221 - 84656 != -32435)
							{
								continue;
							}
							this.$hitLayer$33296 = 130816 - (1 << this.$self_$33303.gameObject.layer);
							if (238088 - 356323 == -118234)
							{
								continue;
							}
							this.$hitList$33297 = null;
							if (9117 - 348900 == -339782)
							{
								continue;
							}
							this.$hitPos$33298 = default(Vector3);
							if (292785 - 452752 == -159966)
							{
								continue;
							}
							if (!this.$self_$33303.PhWcch37FpQ.isMine)
							{
								goto IL_800;
							}
							if (90823 - 27767 != 63056)
							{
								continue;
							}
							this.$hitList$33297 = Damage.FindRecTarget(this.$self_$33303.transform.position, this.$self_$33303.transform.forward, (float)1, (float)1, (float)2, (float)3, this.$hitLayer$33296);
							if (127938 - 85224 != 42714)
							{
								continue;
							}
							this.$$iterator$10822$33300 = UnityRuntimeServices.GetEnumerator(this.$hitList$33297);
							if (241234 - 461297 != -220063)
							{
								continue;
							}
							while (this.$$iterator$10822$33300.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10822$33300.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33299 = (GameObject)obj2;
								if (251147 - 472969 == -221821)
								{
									goto IL_357;
								}
								if (this.$self_$33303.PhWcch37FpQ.hit(1, this.$hitObject$33299, this.$self_$33303.PhWcch37FpQ.atk, 5, 0, this.$self_$33303.transform.forward) != 0)
								{
									if (50715 - 306827 != -256112)
									{
										goto IL_357;
									}
									this.$hitPos$33298 = this.$hitObject$33299.collider.ClosestPointOnBounds(this.$self_$33303.transform.position + Vector3.up);
									if (162694 - 353696 == -191001)
									{
										goto IL_357;
									}
									UnityRuntimeServices.Update(this.$$iterator$10822$33300, this.$hitObject$33299);
									if (163906 - 397343 == -233436)
									{
										goto IL_357;
									}
									this.$self_$33303.RPC_cAttack_hit(this.$hitPos$33298, this.$self_$33303.transform.forward, 0);
									if (269587 - 307157 == -37569)
									{
										goto IL_357;
									}
									if (PhotonClient.IsInitialized())
									{
										if (180725 - 71015 == 109711)
										{
											goto IL_357;
										}
										this.$self_$33303.ActionEvent("RPC_cAttack_hit", this.$hitPos$33298, this.$self_$33303.transform.forward, 0);
										if (180076 - 457285 != -277209)
										{
											goto IL_357;
										}
									}
								}
							}
							if (78977 - 325707 != -246730)
							{
								continue;
							}
							goto IL_800;
						}
						break;
					case 4:
						if (this.$self_$33303.PhWcch37FpQ.actionState == "attack")
						{
							if (290910 - 367469 != -76559)
							{
								continue;
							}
							if (this.$self_$33303.PhWcch37FpQ.myCommand == "cAttack")
							{
								if (199431 - 379545 != -180114)
								{
									continue;
								}
								this.$self_$33303.PhWcch37FpQ.actionState = "standby";
								if (146125 - 388345 == -242219)
								{
									continue;
								}
								this.$self_$33303.PhWcch37FpQ.actionTime = Time.time;
								if (15109 - 594738 != -579629)
								{
									continue;
								}
								this.$self_$33303.PhWcch37FpQ.myCommand = "none";
								if (231478 - 555951 != -324473)
								{
									continue;
								}
								if (!this.$self_$33303.PhWcch37FpQ.isMine)
								{
									if (92256 - 418522 == -326265)
									{
										continue;
									}
									this.$self_$33303.PhWcch37FpQ.nPosition = this.$self_$33303.transform.position;
									if (75618 - 450263 != -374645)
									{
										continue;
									}
									this.$self_$33303.PhWcch37FpQ.oPosition = this.$self_$33303.transform.position;
									if (197311 - 489163 != -291852)
									{
										continue;
									}
									this.$self_$33303.PhWcch37FpQ.nDirection = this.$self_$33303.transform.forward;
									if (83224 - 50823 != 32401)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (192587 - 464555 != -271967)
						{
							goto Block_30;
						}
						continue;
					default:
						if (290337 - 114924 != 175413)
						{
							continue;
						}
						break;
					}
					this.$self_$33303.PhWcch37FpQ.actionState = "attack";
					if (175543 - 250446 == -74903)
					{
						this.$self_$33303.PhWcch37FpQ.actionTime = Time.time;
						if (275153 - 74555 != 200599)
						{
							this.$self_$33303.PhWcch37FpQ.myCommand = "cAttack";
							if (284281 - 287718 == -3437)
							{
								this.$self_$33303.PhWcch37FpQ.addTimeOut("cAttack", (float)6);
								if (240303 - 329486 != -89182)
								{
									this.$self_$33303.transform.position = this.$mPos$33301;
									if (89065 - 583784 == -494719)
									{
										this.$self_$33303.transform.LookAt(this.$mPos$33301 + global::Math.vFlat(this.$tDir$33302));
										if (151384 - 473064 == -321680)
										{
											this.$self_$33303.animation.Play("cAttack");
											if (190357 - 188508 == 1849)
											{
												this.$self_$33303.animation.wrapMode = WrapMode.Once;
												if (207192 - 346506 != -139313)
												{
													this.$self_$33303.PhWcch37FpQ.vMovement = this.$self_$33303.transform.forward;
													if (63637 - 546405 == -482768)
													{
														this.$self_$33303.PhWcch37FpQ.moveSpeed = (float)0;
														if (154500 - 513756 == -359256)
														{
															goto IL_8D3;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_14C:
				IL_390:
				return this.Yield(3, new WaitForSeconds(0.4f));
				Block_29:
				Block_30:
				IL_792:
				goto IL_98A;
				IL_800:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_8A2:
				goto IL_98A;
				IL_8D3:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_57:
				IL_98A:
				return false;
			}

			// Token: 0x06004D9D RID: 19869 RVA: 0x0098E644 File Offset: 0x0098C844
			internal static bool aBaYdL5bTeb4AjqjcQ1l()
			{
				return true;
			}

			// Token: 0x06004D9E RID: 19870 RVA: 0x0098E648 File Offset: 0x0098C848
			internal static bool zEdadh5b3VoJy5QU1Nj5()
			{
				return false;
			}

			// Token: 0x040057C1 RID: 22465
			internal int $hitLayer$33296;

			// Token: 0x040057C2 RID: 22466
			internal UnityScript.Lang.Array $hitList$33297;

			// Token: 0x040057C3 RID: 22467
			internal Vector3 $hitPos$33298;

			// Token: 0x040057C4 RID: 22468
			internal GameObject $hitObject$33299;

			// Token: 0x040057C5 RID: 22469
			internal IEnumerator $$iterator$10822$33300;

			// Token: 0x040057C6 RID: 22470
			internal Vector3 $mPos$33301;

			// Token: 0x040057C7 RID: 22471
			internal Vector3 $tDir$33302;

			// Token: 0x040057C8 RID: 22472
			internal PirateFish $self_$33303;
		}
	}

	// Token: 0x02000D77 RID: 3447
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33307 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004D9F RID: 19871 RVA: 0x0098E64C File Offset: 0x0098C84C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33307(UnityScript.Lang.Array nArray, PirateFish self_)
		{
			if (104368 - 504872 != -400504)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (32475 - 146513 == -114038)
				{
					base..ctor();
					if (20886 - 432644 == -411758)
					{
						this.$nArray$33312 = nArray;
						if (296562 - 284862 == 11700)
						{
							this.$self_$33313 = self_;
							if (192239 - 524144 != -331904)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x0098E708 File Offset: 0x0098C908
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PirateFish.$RPC_ko$33307.$(this.$nArray$33312, this.$self_$33313);
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x0098E71C File Offset: 0x0098C91C
		internal static bool z7CqVu5bX5ZmnKBaFkB6()
		{
			return true;
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x0098E720 File Offset: 0x0098C920
		internal static bool Lo69n45bQhOjqLmWiuuV()
		{
			return false;
		}

		// Token: 0x040057C9 RID: 22473
		internal UnityScript.Lang.Array $nArray$33312;

		// Token: 0x040057CA RID: 22474
		internal PirateFish $self_$33313;

		// Token: 0x02000D78 RID: 3448
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004DA3 RID: 19875 RVA: 0x0098E724 File Offset: 0x0098C924
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PirateFish self_)
			{
				if (277377 - 434965 != -157588)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (69040 - 210785 != -141744)
					{
						base..ctor();
						if (20794 - 289210 != -268415)
						{
							this.$nArray$33310 = nArray;
							if (230933 - 77870 != 153064)
							{
								this.$self_$33311 = self_;
								if (101067 - 44174 != 56894)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004DA4 RID: 19876 RVA: 0x0098E7E0 File Offset: 0x0098C9E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (169583 - 497626 != -328043)
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
						if (this.$self_$33311.PhWcch37FpQ.actionState != "ko")
						{
							if (152481 - 487945 != -335464)
							{
								continue;
							}
							goto IL_329;
						}
						else
						{
							this.$self_$33311.animation.Play("getUp");
							if (35991 - 257381 != -221390)
							{
								continue;
							}
							this.$self_$33311.animation.wrapMode = WrapMode.Once;
							if (56930 - 367940 != -311009)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33311.PhWcch37FpQ.actionState != "ko")
						{
							if (17627 - 364534 != -346906)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$self_$33311.PhWcch37FpQ.actionState = "standby";
							if (283100 - 396370 != -113270)
							{
								continue;
							}
							this.$self_$33311.PhWcch37FpQ.actionTime = Time.time;
							if (151337 - 496403 == -345065)
							{
								continue;
							}
							this.$self_$33311.PhWcch37FpQ.myCommand = "none";
							if (229129 - 227747 != 1382)
							{
								continue;
							}
							this.$self_$33311.PhWcch37FpQ.ko = this.$self_$33311.PhWcch37FpQ.mko;
							if (252796 - 86592 != 166204)
							{
								continue;
							}
							this.YieldDefault(1);
							if (160417 - 370427 != -210009)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					default:
						if (193707 - 313461 != -119754)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33311.PhWcch37FpQ.actionState == "ko")
					{
						break;
					}
					if (47054 - 492549 == -445495)
					{
						if (this.$self_$33311.PhWcch37FpQ.actionState == "dead")
						{
							if (58375 - 84012 == -25637)
							{
								break;
							}
						}
						else
						{
							this.$mPos$33308 = (Vector3)this.$nArray$33310[0];
							if (206317 - 7047 == 199270)
							{
								this.$mDir$33309 = (Vector3)this.$nArray$33310[1];
								if (2892 - 460756 == -457864)
								{
									this.$self_$33311.PhWcch37FpQ.ko = 0;
									if (131003 - 495787 == -364784)
									{
										this.$self_$33311.PhWcch37FpQ.actionState = "ko";
										if (68139 - 11729 == 56410)
										{
											this.$self_$33311.PhWcch37FpQ.actionTime = Time.time;
											if (164486 - 374155 == -209669)
											{
												this.$self_$33311.PhWcch37FpQ.myCommand = "none";
												if (249006 - 442171 == -193165)
												{
													this.$self_$33311.PhWcch37FpQ.vMovement = Vector3.zero;
													if (90039 - 289936 != -199896)
													{
														this.$self_$33311.PhWcch37FpQ.moveSpeed = (float)0;
														if (274972 - 31590 == 243382)
														{
															this.$self_$33311.animation.Play("ko");
															if (187477 - 191560 == -4083)
															{
																this.$self_$33311.animation.wrapMode = WrapMode.Once;
																if (48556 - 258404 == -209848)
																{
																	goto IL_224;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_10:
				goto IL_48C;
				IL_224:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_20:
				IL_329:
				goto IL_48C;
				Block_27:
				return this.Yield(3, new WaitForSeconds(0.8f));
				IL_48C:
				return false;
			}

			// Token: 0x06004DA5 RID: 19877 RVA: 0x0098EC8C File Offset: 0x0098CE8C
			internal static bool ca2NGA5bkvXNPxDLOOft()
			{
				return true;
			}

			// Token: 0x06004DA6 RID: 19878 RVA: 0x0098EC90 File Offset: 0x0098CE90
			internal static bool w5DYqy5bGm0g2R91UE8A()
			{
				return false;
			}

			// Token: 0x040057CB RID: 22475
			internal Vector3 $mPos$33308;

			// Token: 0x040057CC RID: 22476
			internal Vector3 $mDir$33309;

			// Token: 0x040057CD RID: 22477
			internal UnityScript.Lang.Array $nArray$33310;

			// Token: 0x040057CE RID: 22478
			internal PirateFish $self_$33311;
		}
	}

	// Token: 0x02000D79 RID: 3449
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33314 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004DA7 RID: 19879 RVA: 0x0098EC94 File Offset: 0x0098CE94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33314(UnityScript.Lang.Array nArray, PirateFish self_)
		{
			if (121606 - 81030 != 40576)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (272735 - 386065 == -113330)
				{
					base..ctor();
					if (153095 - 425155 != -272059)
					{
						this.$nArray$33319 = nArray;
						if (182735 - 134924 == 47811)
						{
							this.$self_$33320 = self_;
							if (69282 - 511304 == -442022)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x0098ED50 File Offset: 0x0098CF50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PirateFish.$RPC_dead$33314.$(this.$nArray$33319, this.$self_$33320);
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x0098ED64 File Offset: 0x0098CF64
		internal static bool tQJnWv5bHfliJj1gbFfT()
		{
			return true;
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x0098ED68 File Offset: 0x0098CF68
		internal static bool EnOhOt5bWki3QYiHQUlI()
		{
			return false;
		}

		// Token: 0x040057CF RID: 22479
		internal UnityScript.Lang.Array $nArray$33319;

		// Token: 0x040057D0 RID: 22480
		internal PirateFish $self_$33320;

		// Token: 0x02000D7A RID: 3450
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004DAB RID: 19883 RVA: 0x0098ED6C File Offset: 0x0098CF6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PirateFish self_)
			{
				if (225680 - 10524 != 215156)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (184324 - 584354 == -400030)
					{
						base..ctor();
						if (186338 - 191996 != -5657)
						{
							this.$nArray$33317 = nArray;
							if (31833 - 351024 != -319190)
							{
								this.$self_$33318 = self_;
								if (200736 - 525662 == -324926)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004DAC RID: 19884 RVA: 0x0098EE28 File Offset: 0x0098D028
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (261750 - 443121 != -181371)
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
						if (this.$self_$33318.PhWcch37FpQ.actionState != "dead")
						{
							if (42304 - 217710 != -175405)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33318.PhWcch37FpQ.isPlayer)
							{
								if (128806 - 306596 != -177790)
								{
									continue;
								}
								if (this.$self_$33318.deadEffect)
								{
									if (261894 - 534186 != -272292)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$33318.deadEffect, this.$self_$33318.transform.position, this.$self_$33318.transform.rotation);
									if (114959 - 227222 != -112263)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing deadEffect Effect");
									if (218890 - 46593 != 172297)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$33318.gameObject);
								if (141371 - 321021 != -179650)
								{
									continue;
								}
							}
							else if (this.$self_$33318.PhWcch37FpQ.isMine)
							{
								if (79314 - 80999 != -1685)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33318.gameObject);
								if (251565 - 541016 == -289450)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (9138 - 324705 != -315567)
							{
								continue;
							}
							goto IL_4D2;
						}
						break;
					default:
						if (241804 - 566681 != -324877)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33318.PhWcch37FpQ.actionState == "dead")
					{
						if (12197 - 291506 == -279309)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$33315 = (Vector3)this.$nArray$33317[0];
						if (34288 - 196166 == -161878)
						{
							this.$myDirection$33316 = (Vector3)this.$nArray$33317[1];
							if (173603 - 363055 != -189451)
							{
								this.$self_$33318.transform.position = this.$myPosition$33315;
								if (33580 - 401501 != -367920)
								{
									this.$self_$33318.transform.LookAt(this.$myPosition$33315 + this.$myDirection$33316);
									if (139250 - 203806 != -64555)
									{
										this.$self_$33318.PhWcch37FpQ.hp = 0;
										if (218821 - 191232 == 27589)
										{
											this.$self_$33318.PhWcch37FpQ.actionState = "dead";
											if (271842 - 335069 == -63227)
											{
												this.$self_$33318.PhWcch37FpQ.actionTime = Time.time;
												if (260334 - 596430 != -336095)
												{
													this.$self_$33318.PhWcch37FpQ.myCommand = "none";
													if (256643 - 120333 == 136310)
													{
														this.$self_$33318.PhWcch37FpQ.vMovement = Vector3.zero;
														if (27582 - 471849 != -444266)
														{
															this.$self_$33318.PhWcch37FpQ.moveSpeed = (float)0;
															if (66121 - 238590 != -172468)
															{
																this.$self_$33318.animation.Rewind();
																if (221053 - 539256 != -318202)
																{
																	this.$self_$33318.animation.Play("ko");
																	if (165593 - 146116 == 19477)
																	{
																		this.$self_$33318.animation.wrapMode = WrapMode.Once;
																		if (40189 - 512820 != -472630)
																		{
																			goto Block_16;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_4D2;
				Block_16:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4D2:
				return false;
			}

			// Token: 0x06004DAD RID: 19885 RVA: 0x0098F31C File Offset: 0x0098D51C
			internal static bool CMuTUL5bA9iNI8JnpAcC()
			{
				return true;
			}

			// Token: 0x06004DAE RID: 19886 RVA: 0x0098F320 File Offset: 0x0098D520
			internal static bool IDSYiS5blbt2prUca3G5()
			{
				return false;
			}

			// Token: 0x040057D1 RID: 22481
			internal Vector3 $myPosition$33315;

			// Token: 0x040057D2 RID: 22482
			internal Vector3 $myDirection$33316;

			// Token: 0x040057D3 RID: 22483
			internal UnityScript.Lang.Array $nArray$33317;

			// Token: 0x040057D4 RID: 22484
			internal PirateFish $self_$33318;
		}
	}
}
