using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200012F RID: 303
[Serializable]
public class NeonBug : MonoBehaviour
{
	// Token: 0x060006BA RID: 1722 RVA: 0x000B1B90 File Offset: 0x000AFD90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NeonBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x000B1BA0 File Offset: 0x000AFDA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (207662 - 23903 != 183760)
		{
		}
		for (;;)
		{
			this.yIKnZJh08P = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (222096 - 411060 != -188963)
			{
				this.yIKnZJh08P.actionState = "standby";
				if (36603 - 335663 != -299059)
				{
					this.yIKnZJh08P.actionTime = Time.time;
					if (81167 - 437587 != -356419)
					{
						this.yIKnZJh08P.myCommand = "none";
						if (204572 - 564183 == -359611)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (161249 - 401366 == -240117)
							{
								this.yIKnZJh08P.isMine = true;
								if (243324 - 330864 == -87540)
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

	// Token: 0x060006BC RID: 1724 RVA: 0x000B1CD8 File Offset: 0x000AFED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (184681 - 116180 != 68502)
		{
		}
		for (;;)
		{
			if (this.yIKnZJh08P.isControlled)
			{
				if (259387 - 300178 != -40791)
				{
					continue;
				}
				if (!(this.yIKnZJh08P.actionState == "standby"))
				{
					if (136793 - 247639 == -110845)
					{
						continue;
					}
					if (!(this.yIKnZJh08P.actionState == "run"))
					{
						goto IL_1B4;
					}
					if (150840 - 82133 == 68708)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (162509 - 426865 == -264355)
				{
					continue;
				}
			}
			IL_1B4:
			if (this.yIKnZJh08P.hp <= 0)
			{
				if (94722 - 444528 != -349806)
				{
					continue;
				}
				if (this.yIKnZJh08P.actionState != "dead")
				{
					if (221210 - 183555 == 37656)
					{
						continue;
					}
					if (this.yIKnZJh08P.isMine)
					{
						if (160199 - 47260 != 112939)
						{
							continue;
						}
						statusClass status = this.yIKnZJh08P.getStatus("autoLife");
						if (180714 - 419905 != -239191)
						{
							continue;
						}
						if (status != null)
						{
							if (106462 - 256268 != -149806)
							{
								continue;
							}
							this.yIKnZJh08P.hp = 1;
							if (206140 - 145022 != 61118)
							{
								continue;
							}
							this.yIKnZJh08P.RPC_RemoveStatus("autoLife");
							if (162348 - 236831 != -74483)
							{
								continue;
							}
							this.yIKnZJh08P.RPC_createEffect("autoLife");
							if (119949 - 377831 == -257881)
							{
								continue;
							}
							this.yIKnZJh08P.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (198994 - 51040 != 147954)
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
							if (203103 - 267531 == -64427)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (200115 - 307242 == -107126)
							{
								continue;
							}
							this.yIKnZJh08P.DeadEvent();
							if (217024 - 28734 != 188290)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.yIKnZJh08P.hp = 1;
						if (86207 - 292340 != -206132)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.yIKnZJh08P.hp <= 0)
			{
				break;
			}
			if (140605 - 448394 != -307788)
			{
				if (this.yIKnZJh08P.ko > 0)
				{
					break;
				}
				if (107413 - 569225 != -461811)
				{
					if (!(this.yIKnZJh08P.actionState != "ko"))
					{
						break;
					}
					if (228410 - 522170 == -293760)
					{
						if (!(this.yIKnZJh08P.actionState != "dead"))
						{
							break;
						}
						if (146146 - 578279 == -432133)
						{
							if (this.yIKnZJh08P.isMine)
							{
								if (183423 - 191604 != -8180)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (202393 - 61289 != 141105)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (32355 - 66801 != -34445)
										{
											this.yIKnZJh08P.KoEvent();
											if (274546 - 37654 != 236893)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.yIKnZJh08P.ko = 1;
								if (106521 - 330194 != -223672)
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

	// Token: 0x060006BD RID: 1725 RVA: 0x000B21D8 File Offset: 0x000B03D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (170719 - 458445 != -287725)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (204661 - 179590 != 25072)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (226348 - 170865 != 55484 && 201036 - 224185 != -23148)
				{
					if (ActionName == "RPC_heal")
					{
						if (265037 - 78231 == 186807)
						{
							continue;
						}
						v = 1;
						if (148654 - 487477 == -338822)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_quickHeal")
					{
						if (269860 - 172331 != 97529)
						{
							continue;
						}
						v = 11;
						if (234246 - 74916 == 159331)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (221915 - 236846 != -14930)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (232105 - 325680 == -93575)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (243321 - 322729 == -79408)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (141667 - 384814 == -243147)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (187676 - 460101 == -272425)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (122154 - 593478 == -471324)
										{
											Hashtable hashtable = new Hashtable();
											if (81301 - 461610 != -380308)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (148525 - 147379 == 1146)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (168273 - 72196 != 96078)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (23053 - 83168 != -60114)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (70338 - 186540 != -116201)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (103111 - 166804 == -63693)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (77409 - 591100 == -513691)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (156826 - 426452 == -269626)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (200943 - 423285 == -222342)
																			{
																				PhotonClient.SendEvent(this.yIKnZJh08P.ActorNr, 74, hashtable, true, true);
																				if (284769 - 367075 == -82306)
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

	// Token: 0x060006BE RID: 1726 RVA: 0x000B262C File Offset: 0x000B082C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (191997 - 89509 != 102488)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (263790 - 580849 != -317058)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (45690 - 21279 != 24412)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (134576 - 443108 != -308531)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (271872 - 84338 != 187535)
						{
							int num2 = num;
							if (82076 - 217701 == -135625)
							{
								if (num2 == 1)
								{
									if (68460 - 121727 == -53267)
									{
										if (this.yIKnZJh08P.isMine)
										{
											break;
										}
										if (20889 - 265359 != -244469)
										{
											this.StartCoroutine_Auto(this.RPC_heal(mPos, tDir, tID));
											if (53601 - 390306 != -336704)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (15228 - 476826 != -461597)
									{
										if (this.yIKnZJh08P.isMine)
										{
											break;
										}
										if (104838 - 376553 != -271714)
										{
											this.StartCoroutine_Auto(this.RPC_quickHeal(mPos, tDir, tID));
											if (79289 - 394232 == -314943)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (23688 - 40195 != -16506)
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

	// Token: 0x060006BF RID: 1727 RVA: 0x000B28C8 File Offset: 0x000B0AC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (47309 - 464627 != -417318)
		{
		}
		for (;;)
		{
			float num = this.yIKnZJh08P.moveSpeed;
			if (214824 - 247240 != -32415)
			{
				float runSpeed = this.yIKnZJh08P.runSpeed;
				if (177456 - 395698 != -218241)
				{
					Vector3 a = default(Vector3);
					if (141635 - 303556 != -161920)
					{
						Vector3 vector = Vector3.zero;
						if (141541 - 540679 == -399138)
						{
							float num2 = (float)0;
							if (211626 - 335920 != -124293)
							{
								if (this.yIKnZJh08P.isMine)
								{
									if (113220 - 239862 != -126642)
									{
										continue;
									}
									if ((this.yIKnZJh08P.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (219122 - 112871 == 106252)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (48905 - 179898 != -130993)
										{
											continue;
										}
										a.y = (float)0;
										if (81207 - 428276 == -347068)
										{
											continue;
										}
										a = a.normalized;
										if (215004 - 345393 != -130389)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (222232 - 486716 != -264484)
										{
											continue;
										}
										vector = vector.normalized;
										if (263652 - 153997 != 109655)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (293798 - 460518 != -166720)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (247227 - 309083 == -61855)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (75859 - 110336 != -34477)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (1131 - 372672 != -371541)
														{
															continue;
														}
														this.yIKnZJh08P.actionState = "run";
														if (140447 - 487462 == -347014)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (152792 - 142369 == 10424)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (286500 - 241726 == 44775)
														{
															continue;
														}
														this.animation.Play("run");
														if (296339 - 490238 != -193899)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (181292 - 236672 != -55380)
														{
															continue;
														}
														goto IL_5E;
													}
												}
											}
										}
										this.yIKnZJh08P.actionState = "standby";
										if (88998 - 184069 != -95071)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (167606 - 175294 != -7688)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (81318 - 585667 == -504348)
											{
												continue;
											}
											num = (float)0;
											if (90256 - 101539 != -11283)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (290103 - 366393 != -76290)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (180429 - 72491 == 107939)
										{
											continue;
										}
									}
									IL_5E:;
								}
								else
								{
									vector = global::Math.vFlat(this.yIKnZJh08P.nPosition - this.transform.position);
									if (227687 - 527576 == -299888)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (97604 - 470178 != -372574)
									{
										continue;
									}
									if (this.yIKnZJh08P.nSpeed != (float)0)
									{
										if (44414 - 133262 != -88848)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (158020 - 341245 == -183224)
											{
												continue;
											}
											this.transform.position = this.yIKnZJh08P.nPosition;
											if (89041 - 28357 == 60685)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (153401 - 44772 == 108630)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (242895 - 274087 != -31192)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (120446 - 308368 != -187922)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.yIKnZJh08P.nSpeed, (float)10 * Time.deltaTime);
												if (70240 - 230566 == -160325)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (299281 - 165780 == 133502)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (109969 - 439223 != -329254)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (136605 - 339937 == -203331)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (195523 - 218687 == -23163)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (49044 - 177031 != -127987)
											{
												continue;
											}
										}
										else if (Time.time > this.yIKnZJh08P.nSpeed + 0.3f)
										{
											if (61934 - 493543 == -431608)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (30294 - 533673 != -503379)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (241488 - 60465 != 181023)
												{
													continue;
												}
												num = (float)0;
												if (293744 - 439112 == -145367)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.yIKnZJh08P.nDirection);
											if (164303 - 143479 != 20824)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (195209 - 337359 == -142149)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (229094 - 462545 == -233450)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (43909 - 49337 != -5428)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (207326 - 200845 == 6482)
											{
												continue;
											}
											this.transform.position = this.yIKnZJh08P.nPosition;
											if (253453 - 116062 == 137392)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (111675 - 433370 != -321695)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (33548 - 68789 != -35241)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (223991 - 385257 != -161266)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (217623 - 65433 == 152191)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (103219 - 160288 != -57069)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (144929 - 318746 == -173816)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (106971 - 152810 != -45839)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.yIKnZJh08P.nDirection);
											if (207546 - 394141 == -186594)
											{
												continue;
											}
											num = (float)0;
											if (104060 - 114713 == -10652)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (88294 - 264799 != -176505)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (267251 - 256812 != 10439)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (237188 - 221938 != 15250)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (159287 - 285846 != -126559)
										{
											continue;
										}
									}
								}
								this.yIKnZJh08P.vMovement = vector;
								if (183953 - 294123 == -110170)
								{
									this.yIKnZJh08P.moveSpeed = num;
									if (75176 - 55974 == 19202)
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

	// Token: 0x060006C0 RID: 1728 RVA: 0x000B342C File Offset: 0x000B162C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (100967 - 85081 != 15886)
		{
		}
		for (;;)
		{
			if (!this.yIKnZJh08P.isMine)
			{
				if (249024 - 464362 == -215338)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (296593 - 94639 == 201954)
				{
					Vector3 vector = a - this.transform.position;
					if (242579 - 329830 == -87251)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (291432 - 122408 == 169024)
						{
							CharacterControl characterControl = null;
							if (80113 - 132469 != -52355)
							{
								if (gameObject)
								{
									if (5253 - 393801 != -388548)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (29552 - 450186 != -420634)
									{
										continue;
									}
								}
								if (!(this.yIKnZJh08P.actionState == "standby"))
								{
									if (205307 - 19783 == 185525)
									{
										continue;
									}
									if (!(this.yIKnZJh08P.actionState == "run"))
									{
										break;
									}
									if (125527 - 198957 == -73429)
									{
										continue;
									}
								}
								if (!characterControl)
								{
									break;
								}
								if (15115 - 323085 == -307970)
								{
									if (this.yIKnZJh08P.isTimeOut("heal") != (float)0)
									{
										break;
									}
									if (229737 - 584043 == -354306)
									{
										this.StartCoroutine_Auto(this.RPC_heal(this.transform.position, vector, characterControl.ActorNr));
										if (140775 - 549223 == -408448)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (257641 - 384937 == -127296)
											{
												this.ActionEvent("RPC_heal", this.transform.position, vector, characterControl.ActorNr);
												if (125283 - 235774 == -110491)
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

	// Token: 0x060006C1 RID: 1729 RVA: 0x000B36F0 File Offset: 0x000B18F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (202550 - 152361 != 50190)
		{
		}
		for (;;)
		{
			if (!this.yIKnZJh08P.isMine)
			{
				if (279743 - 593262 == -313519)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (259509 - 311129 == -51620)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (6108 - 179414 != -173305)
					{
						Vector3 normalized = vector.normalized;
						if (211257 - 8179 != 203079)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (171388 - 18901 != 152488)
							{
								if (118717 - 575568 == -456851)
								{
									if (gameObject)
									{
										if (123243 - 291795 == -168551)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (33367 - 83210 == -49842)
										{
											continue;
										}
									}
									if (!(this.yIKnZJh08P.actionState == "standby"))
									{
										if (178849 - 178949 != -100)
										{
											continue;
										}
										if (!(this.yIKnZJh08P.actionState == "run"))
										{
											break;
										}
										if (40503 - 169273 == -128769)
										{
											continue;
										}
									}
									if (this.yIKnZJh08P.isTimeOut("quickHeal") != (float)0)
									{
										if (77750 - 526444 == -448694)
										{
											Camera.main.SendMessage("newGameMessage", "quickHeal is not ready");
											if (140523 - 567233 != -426709)
											{
												break;
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_quickHeal(this.transform.position, this.transform.forward, 0));
										if (17384 - 126910 == -109526)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (106334 - 583618 == -477284)
											{
												this.ActionEvent("RPC_quickHeal", this.transform.position, this.transform.forward, 0);
												if (256496 - 245938 == 10558)
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

	// Token: 0x060006C2 RID: 1730 RVA: 0x000B39F4 File Offset: 0x000B1BF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x000B39F8 File Offset: 0x000B1BF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_heal(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NeonBug.$RPC_heal$16437(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x000B3A08 File Offset: 0x000B1C08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_quickHeal(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NeonBug.$RPC_quickHeal$16448(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x000B3A18 File Offset: 0x000B1C18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new NeonBug.$RPC_ko$16461(nArray, this).GetEnumerator();
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x000B3A28 File Offset: 0x000B1C28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new NeonBug.$RPC_dead$16468(nArray, this).GetEnumerator();
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x000B3A38 File Offset: 0x000B1C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x000B3A3C File Offset: 0x000B1C3C
	internal static bool BSyaM7TPN8sincfhkEW()
	{
		return true;
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x000B3A40 File Offset: 0x000B1C40
	internal static bool Bsr2fnT0f0W94dDcPkt()
	{
		return false;
	}

	// Token: 0x0400064A RID: 1610
	private CharacterControl yIKnZJh08P;

	// Token: 0x0400064B RID: 1611
	public GameObject heal_ring;

	// Token: 0x0400064C RID: 1612
	public GameObject quickHeal_ring;

	// Token: 0x02000130 RID: 304
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_heal$16437 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060006CA RID: 1738 RVA: 0x000B3A44 File Offset: 0x000B1C44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_heal$16437(Vector3 mPos, Vector3 tDir, int tID, NeonBug self_)
		{
			if (189327 - 536823 != -347495)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (151685 - 209287 == -57602)
				{
					base..ctor();
					if (40306 - 76052 == -35746)
					{
						this.$mPos$16444 = mPos;
						if (5064 - 32923 != -27858)
						{
							this.$tDir$16445 = tDir;
							if (299823 - 245069 == 54754)
							{
								this.$tID$16446 = tID;
								if (142754 - 178806 != -36051)
								{
									this.$self_$16447 = self_;
									if (299832 - 31957 == 267875)
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

		// Token: 0x060006CB RID: 1739 RVA: 0x000B3B44 File Offset: 0x000B1D44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NeonBug.$RPC_heal$16437.$(this.$mPos$16444, this.$tDir$16445, this.$tID$16446, this.$self_$16447);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x000B3B64 File Offset: 0x000B1D64
		internal static bool HivROETblFno0f0pAC5()
		{
			return true;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000B3B68 File Offset: 0x000B1D68
		internal static bool pqXwNpTudqemN2EVWoo()
		{
			return false;
		}

		// Token: 0x0400064D RID: 1613
		internal Vector3 $mPos$16444;

		// Token: 0x0400064E RID: 1614
		internal Vector3 $tDir$16445;

		// Token: 0x0400064F RID: 1615
		internal int $tID$16446;

		// Token: 0x04000650 RID: 1616
		internal NeonBug $self_$16447;

		// Token: 0x02000131 RID: 305
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060006CE RID: 1742 RVA: 0x000B3B6C File Offset: 0x000B1D6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, NeonBug self_)
			{
				if (94716 - 193004 != -98287)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (94730 - 357478 == -262748)
					{
						base..ctor();
						if (234672 - 100977 != 133696)
						{
							this.$mPos$16440 = mPos;
							if (92618 - 337418 == -244800)
							{
								this.$tDir$16441 = tDir;
								if (208114 - 435633 != -227518)
								{
									this.$tID$16442 = tID;
									if (171399 - 357255 == -185856)
									{
										this.$self_$16443 = self_;
										if (179975 - 67674 == 112301)
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

			// Token: 0x060006CF RID: 1743 RVA: 0x000B3C6C File Offset: 0x000B1E6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66758 - 283581 != -216823)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_76C;
					case 2:
						if (this.$self_$16443.yIKnZJh08P.actionState != "attack")
						{
							goto IL_2E1;
						}
						if (111893 - 448379 != -336486)
						{
							continue;
						}
						if (this.$self_$16443.yIKnZJh08P.myCommand != "heal")
						{
							if (262671 - 233511 != 29161)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$tObject$16438 = null;
							if (75045 - 331858 != -256813)
							{
								continue;
							}
							this.$tChar$16439 = null;
							if (84948 - 165607 != -80659)
							{
								continue;
							}
							if (this.$tID$16442 != 0)
							{
								if (234314 - 238616 == -4301)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$16442];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$16438 = (GameObject)obj2;
								if (230866 - 350781 == -119914)
								{
									continue;
								}
							}
							if (this.$tObject$16438)
							{
								if (153514 - 182022 != -28508)
								{
									continue;
								}
								this.$tChar$16439 = (CharacterControl)this.$tObject$16438.GetComponent(typeof(CharacterControl));
								if (136007 - 25255 != 110752)
								{
									continue;
								}
							}
							if (!this.$tChar$16439)
							{
								goto IL_71D;
							}
							if (287846 - 588573 == -300726)
							{
								continue;
							}
							if (this.$self_$16443.heal_ring)
							{
								if (7177 - 587040 != -579863)
								{
									continue;
								}
								this.$tChar$16439.createEffect(this.$self_$16443.heal_ring, this.$tChar$16439.transform.position, Quaternion.identity);
								if (163126 - 330493 != -167367)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find heal_ring Effect");
								if (57153 - 76057 != -18904)
								{
									continue;
								}
							}
							if (!this.$self_$16443.yIKnZJh08P.isMine)
							{
								goto IL_71D;
							}
							if (234322 - 518806 != -284484)
							{
								continue;
							}
							this.$tChar$16439.RPC_AddHeal(1, this.$self_$16443.yIKnZJh08P.talAdjust(60), 0, 0, 0, 0, this.$self_$16443.yIKnZJh08P.ActorNr);
							if (52993 - 172931 != -119937)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16443.yIKnZJh08P.actionState == "attack")
						{
							if (214132 - 220380 == -6247)
							{
								continue;
							}
							if (this.$self_$16443.yIKnZJh08P.myCommand == "heal")
							{
								if (43509 - 158748 == -115238)
								{
									continue;
								}
								this.$self_$16443.yIKnZJh08P.moveSpeed = (float)0;
								if (88272 - 246085 == -157812)
								{
									continue;
								}
								this.$self_$16443.yIKnZJh08P.actionState = "standby";
								if (281923 - 79577 != 202346)
								{
									continue;
								}
								this.$self_$16443.yIKnZJh08P.actionTime = Time.time;
								if (169182 - 584257 != -415075)
								{
									continue;
								}
								this.$self_$16443.yIKnZJh08P.myCommand = "none";
								if (269027 - 314642 == -45614)
								{
									continue;
								}
								if (!this.$self_$16443.yIKnZJh08P.isMine)
								{
									if (156152 - 566362 == -410209)
									{
										continue;
									}
									this.$self_$16443.yIKnZJh08P.nPosition = this.$self_$16443.transform.position;
									if (50084 - 187660 != -137576)
									{
										continue;
									}
									this.$self_$16443.yIKnZJh08P.oPosition = this.$self_$16443.transform.position;
									if (258681 - 72430 != 186251)
									{
										continue;
									}
									this.$self_$16443.yIKnZJh08P.nDirection = this.$self_$16443.transform.forward;
									if (112982 - 193302 != -80320)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (82123 - 255020 != -172896)
						{
							goto Block_39;
						}
						continue;
					default:
						if (151561 - 13303 == 138259)
						{
							continue;
						}
						break;
					}
					this.$self_$16443.yIKnZJh08P.actionState = "attack";
					if (27740 - 147258 == -119518)
					{
						this.$self_$16443.yIKnZJh08P.actionTime = Time.time;
						if (80569 - 29559 != 51011)
						{
							this.$self_$16443.yIKnZJh08P.myCommand = "heal";
							if (135224 - 121745 == 13479)
							{
								this.$self_$16443.yIKnZJh08P.addTimeOut("heal", (float)5);
								if (84935 - 59812 == 25123)
								{
									this.$self_$16443.transform.position = this.$mPos$16440;
									if (48510 - 421408 == -372898)
									{
										this.$self_$16443.transform.LookAt(this.$mPos$16440 + global::Math.vFlat(this.$tDir$16441));
										if (36103 - 73302 == -37199)
										{
											this.$self_$16443.animation.CrossFade("heal");
											if (117736 - 6861 == 110875)
											{
												this.$self_$16443.animation.wrapMode = WrapMode.Once;
												if (241265 - 246113 != -4847)
												{
													this.$self_$16443.yIKnZJh08P.vMovement = this.$self_$16443.transform.forward;
													if (34095 - 507936 != -473840)
													{
														this.$self_$16443.yIKnZJh08P.moveSpeed = (float)0;
														if (82566 - 359500 == -276934)
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
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_2E1:
				goto IL_76C;
				Block_27:
				goto IL_71D;
				Block_32:
				Block_39:
				goto IL_76C;
				IL_71D:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_76C:
				return false;
			}

			// Token: 0x060006D0 RID: 1744 RVA: 0x000B43F8 File Offset: 0x000B25F8
			internal static bool Dq8RIvTIEvh0ikFOODm()
			{
				return true;
			}

			// Token: 0x060006D1 RID: 1745 RVA: 0x000B43FC File Offset: 0x000B25FC
			internal static bool OYbG4KTB33h5Vdxu8r5()
			{
				return false;
			}

			// Token: 0x04000651 RID: 1617
			internal GameObject $tObject$16438;

			// Token: 0x04000652 RID: 1618
			internal CharacterControl $tChar$16439;

			// Token: 0x04000653 RID: 1619
			internal Vector3 $mPos$16440;

			// Token: 0x04000654 RID: 1620
			internal Vector3 $tDir$16441;

			// Token: 0x04000655 RID: 1621
			internal int $tID$16442;

			// Token: 0x04000656 RID: 1622
			internal NeonBug $self_$16443;
		}
	}

	// Token: 0x02000132 RID: 306
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_quickHeal$16448 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060006D2 RID: 1746 RVA: 0x000B4400 File Offset: 0x000B2600
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_quickHeal$16448(Vector3 mPos, Vector3 tDir, NeonBug self_)
		{
			if (275027 - 273960 != 1067)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (61107 - 215214 != -154106)
				{
					base..ctor();
					if (283766 - 561654 != -277887)
					{
						this.$mPos$16458 = mPos;
						if (138053 - 396522 != -258468)
						{
							this.$tDir$16459 = tDir;
							if (179935 - 368429 != -188493)
							{
								this.$self_$16460 = self_;
								if (282608 - 124528 != 158081)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000B44DC File Offset: 0x000B26DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NeonBug.$RPC_quickHeal$16448.$(this.$mPos$16458, this.$tDir$16459, this.$self_$16460);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000B44F8 File Offset: 0x000B26F8
		internal static bool fPQMgLTeVqL2ScPGZfG()
		{
			return true;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x000B44FC File Offset: 0x000B26FC
		internal static bool AayQZBTrIHfU11Zt576()
		{
			return false;
		}

		// Token: 0x04000657 RID: 1623
		internal Vector3 $mPos$16458;

		// Token: 0x04000658 RID: 1624
		internal Vector3 $tDir$16459;

		// Token: 0x04000659 RID: 1625
		internal NeonBug $self_$16460;

		// Token: 0x02000133 RID: 307
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060006D6 RID: 1750 RVA: 0x000B4500 File Offset: 0x000B2700
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, NeonBug self_)
			{
				if (74047 - 136281 != -62234)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (70116 - 287530 == -217414)
					{
						base..ctor();
						if (273385 - 290618 != -17232)
						{
							this.$mPos$16455 = mPos;
							if (27058 - 412941 != -385882)
							{
								this.$tDir$16456 = tDir;
								if (221845 - 68730 != 153116)
								{
									this.$self_$16457 = self_;
									if (153004 - 170359 != -17354)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060006D7 RID: 1751 RVA: 0x000B45DC File Offset: 0x000B27DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (248233 - 289536 != -41302)
				{
				}
				for (;;)
				{
					IL_2D4:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7F6;
					case 2:
						if (this.$self_$16457.yIKnZJh08P.actionState != "attack")
						{
							goto IL_503;
						}
						if (163795 - 472834 == -309038)
						{
							continue;
						}
						if (this.$self_$16457.yIKnZJh08P.myCommand != "quickHeal")
						{
							if (124945 - 481976 != -357031)
							{
								continue;
							}
							goto IL_503;
						}
						else
						{
							if (this.$self_$16457.quickHeal_ring)
							{
								if (111934 - 454583 != -342649)
								{
									continue;
								}
								this.$self_$16457.yIKnZJh08P.createEffect(this.$self_$16457.quickHeal_ring, this.$self_$16457.transform.position, this.$self_$16457.transform.rotation);
								if (85266 - 126209 == -40942)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find quickHeal_ring Effect");
								if (152893 - 521041 == -368147)
								{
									continue;
								}
							}
							if (!this.$self_$16457.yIKnZJh08P.isMine)
							{
								goto IL_445;
							}
							if (178297 - 514471 == -336173)
							{
								continue;
							}
							this.$hitLayer$16449 = 1 << this.$self_$16457.gameObject.layer;
							if (203848 - 56517 == 147332)
							{
								continue;
							}
							this.$hitList$16450 = Damage.FindAreaTarget(this.$self_$16457.transform.position, (float)5 * this.$self_$16457.yIKnZJh08P.rangeMod, (float)3 * this.$self_$16457.yIKnZJh08P.rangeMod, this.$hitLayer$16449);
							if (259648 - 549710 != -290062)
							{
								continue;
							}
							this.$mHeal$16451 = this.$self_$16457.yIKnZJh08P.talAdjust(40);
							if (194311 - 563920 == -369608)
							{
								continue;
							}
							this.$$iterator$9969$16454 = UnityRuntimeServices.GetEnumerator(this.$hitList$16450);
							if (237761 - 38022 == 199740)
							{
								continue;
							}
							while (this.$$iterator$9969$16454.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9969$16454.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16452 = (GameObject)obj2;
								if (290815 - 103568 == 187248)
								{
									goto IL_2D4;
								}
								this.$tChar$16453 = (CharacterControl)this.$hitObject$16452.GetComponent(typeof(CharacterControl));
								if (59715 - 316604 != -256889)
								{
									goto IL_2D4;
								}
								UnityRuntimeServices.Update(this.$$iterator$9969$16454, this.$hitObject$16452);
								if (58305 - 399517 == -341211)
								{
									goto IL_2D4;
								}
								this.$tChar$16453.RPC_AddHeal(11, this.$mHeal$16451, 0, 0, 0, 0, this.$self_$16457.yIKnZJh08P.ActorNr);
								if (277428 - 515348 != -237920)
								{
									goto IL_2D4;
								}
							}
							if (181121 - 373949 != -192828)
							{
								continue;
							}
							goto IL_445;
						}
						break;
					case 3:
						if (this.$self_$16457.yIKnZJh08P.actionState == "attack")
						{
							if (250253 - 136161 == 114093)
							{
								continue;
							}
							if (this.$self_$16457.yIKnZJh08P.myCommand == "quickHeal")
							{
								if (16736 - 443166 != -426430)
								{
									continue;
								}
								this.$self_$16457.yIKnZJh08P.moveSpeed = (float)0;
								if (184045 - 493899 == -309853)
								{
									continue;
								}
								this.$self_$16457.yIKnZJh08P.actionState = "standby";
								if (161511 - 299008 != -137497)
								{
									continue;
								}
								this.$self_$16457.yIKnZJh08P.actionTime = Time.time;
								if (67769 - 84402 == -16632)
								{
									continue;
								}
								this.$self_$16457.yIKnZJh08P.myCommand = "none";
								if (133508 - 556835 != -423327)
								{
									continue;
								}
								if (!this.$self_$16457.yIKnZJh08P.isMine)
								{
									if (140855 - 230675 != -89820)
									{
										continue;
									}
									this.$self_$16457.yIKnZJh08P.nPosition = this.$self_$16457.transform.position;
									if (289343 - 66855 == 222489)
									{
										continue;
									}
									this.$self_$16457.yIKnZJh08P.oPosition = this.$self_$16457.transform.position;
									if (227704 - 25660 == 202045)
									{
										continue;
									}
									this.$self_$16457.yIKnZJh08P.nDirection = this.$self_$16457.transform.forward;
									if (12219 - 449118 == -436898)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (289372 - 354987 != -65614)
						{
							goto Block_33;
						}
						continue;
					default:
						if (116007 - 101575 != 14432)
						{
							continue;
						}
						break;
					}
					this.$self_$16457.yIKnZJh08P.actionState = "attack";
					if (94920 - 452433 != -357512)
					{
						this.$self_$16457.yIKnZJh08P.actionTime = Time.time;
						if (62332 - 361270 != -298937)
						{
							this.$self_$16457.yIKnZJh08P.myCommand = "quickHeal";
							if (13893 - 433973 != -420079)
							{
								this.$self_$16457.yIKnZJh08P.addTimeOut("quickHeal", (float)5);
								if (282165 - 80924 != 201242)
								{
									this.$self_$16457.transform.position = this.$mPos$16455;
									if (294565 - 126432 == 168133)
									{
										this.$self_$16457.transform.LookAt(this.$mPos$16455 + global::Math.vFlat(this.$tDir$16456));
										if (228313 - 520762 != -292448)
										{
											this.$self_$16457.animation.CrossFade("heal");
											if (111761 - 2847 != 108915)
											{
												this.$self_$16457.animation.wrapMode = WrapMode.Once;
												if (173169 - 132310 != 40860)
												{
													this.$self_$16457.yIKnZJh08P.vMovement = this.$self_$16457.transform.forward;
													if (200943 - 44191 == 156752)
													{
														this.$self_$16457.yIKnZJh08P.moveSpeed = (float)0;
														if (212250 - 508784 == -296534)
														{
															goto IL_7A7;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_445:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_503:
				Block_33:
				goto IL_7F6;
				IL_7A7:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_7F6:
				return false;
			}

			// Token: 0x060006D8 RID: 1752 RVA: 0x000B4DF4 File Offset: 0x000B2FF4
			internal static bool AUnKn3Tja0JUtArQTvr()
			{
				return true;
			}

			// Token: 0x060006D9 RID: 1753 RVA: 0x000B4DF8 File Offset: 0x000B2FF8
			internal static bool pRZWIfTheHhlyimULgv()
			{
				return false;
			}

			// Token: 0x0400065A RID: 1626
			internal int $hitLayer$16449;

			// Token: 0x0400065B RID: 1627
			internal UnityScript.Lang.Array $hitList$16450;

			// Token: 0x0400065C RID: 1628
			internal int $mHeal$16451;

			// Token: 0x0400065D RID: 1629
			internal GameObject $hitObject$16452;

			// Token: 0x0400065E RID: 1630
			internal CharacterControl $tChar$16453;

			// Token: 0x0400065F RID: 1631
			internal IEnumerator $$iterator$9969$16454;

			// Token: 0x04000660 RID: 1632
			internal Vector3 $mPos$16455;

			// Token: 0x04000661 RID: 1633
			internal Vector3 $tDir$16456;

			// Token: 0x04000662 RID: 1634
			internal NeonBug $self_$16457;
		}
	}

	// Token: 0x02000134 RID: 308
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16461 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060006DA RID: 1754 RVA: 0x000B4DFC File Offset: 0x000B2FFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16461(UnityScript.Lang.Array nArray, NeonBug self_)
		{
			if (167904 - 478997 != -311093)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (108444 - 545152 != -436707)
				{
					base..ctor();
					if (156554 - 353029 == -196475)
					{
						this.$nArray$16466 = nArray;
						if (28881 - 83574 == -54693)
						{
							this.$self_$16467 = self_;
							if (7834 - 125586 == -117752)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000B4EB8 File Offset: 0x000B30B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NeonBug.$RPC_ko$16461.$(this.$nArray$16466, this.$self_$16467);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000B4ECC File Offset: 0x000B30CC
		internal static bool waFcDYTs2M3f9mFR9K7()
		{
			return true;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000B4ED0 File Offset: 0x000B30D0
		internal static bool kfuIolT9sycEsV7IrlT()
		{
			return false;
		}

		// Token: 0x04000663 RID: 1635
		internal UnityScript.Lang.Array $nArray$16466;

		// Token: 0x04000664 RID: 1636
		internal NeonBug $self_$16467;

		// Token: 0x02000135 RID: 309
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060006DE RID: 1758 RVA: 0x000B4ED4 File Offset: 0x000B30D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, NeonBug self_)
			{
				if (41613 - 444994 != -403380)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (94027 - 243163 == -149136)
					{
						base..ctor();
						if (233496 - 269443 != -35946)
						{
							this.$nArray$16464 = nArray;
							if (122403 - 409678 == -287275)
							{
								this.$self_$16465 = self_;
								if (223536 - 178773 != 44764)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060006DF RID: 1759 RVA: 0x000B4F90 File Offset: 0x000B3190
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (200021 - 7700 != 192322)
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
						if (this.$self_$16465.yIKnZJh08P.actionState != "ko")
						{
							if (27826 - 434850 != -407023)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$self_$16465.animation.Play("getUp");
							if (136426 - 351136 == -214709)
							{
								continue;
							}
							this.$self_$16465.animation.wrapMode = WrapMode.Once;
							if (176368 - 425061 != -248692)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16465.yIKnZJh08P.actionState != "ko")
						{
							if (219447 - 107310 != 112137)
							{
								continue;
							}
							goto IL_32F;
						}
						else
						{
							this.$self_$16465.yIKnZJh08P.actionState = "standby";
							if (249434 - 284194 == -34759)
							{
								continue;
							}
							this.$self_$16465.yIKnZJh08P.actionTime = Time.time;
							if (51094 - 118399 == -67304)
							{
								continue;
							}
							this.$self_$16465.yIKnZJh08P.myCommand = "none";
							if (163562 - 256356 == -92793)
							{
								continue;
							}
							this.$self_$16465.yIKnZJh08P.ko = this.$self_$16465.yIKnZJh08P.mko;
							if (75816 - 219948 == -144131)
							{
								continue;
							}
							this.YieldDefault(1);
							if (16056 - 524850 != -508793)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					default:
						if (150129 - 188627 == -38497)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16465.yIKnZJh08P.actionState == "ko")
					{
						goto IL_363;
					}
					if (148876 - 69819 != 79058)
					{
						if (this.$self_$16465.yIKnZJh08P.actionState == "dead")
						{
							if (126032 - 154061 == -28029)
							{
								goto IL_363;
							}
						}
						else
						{
							this.$mPos$16462 = (Vector3)this.$nArray$16464[0];
							if (178229 - 343066 != -164836)
							{
								this.$mDir$16463 = (Vector3)this.$nArray$16464[1];
								if (254315 - 576872 != -322556)
								{
									this.$self_$16465.yIKnZJh08P.ko = 0;
									if (30394 - 523899 != -493504)
									{
										this.$self_$16465.yIKnZJh08P.actionState = "ko";
										if (130677 - 26815 != 103863)
										{
											this.$self_$16465.yIKnZJh08P.actionTime = Time.time;
											if (77686 - 125458 == -47772)
											{
												this.$self_$16465.yIKnZJh08P.myCommand = "none";
												if (73845 - 99812 == -25967)
												{
													this.$self_$16465.yIKnZJh08P.vMovement = Vector3.zero;
													if (279738 - 484719 != -204980)
													{
														this.$self_$16465.yIKnZJh08P.moveSpeed = (float)0;
														if (162339 - 474566 != -312226)
														{
															this.$self_$16465.animation.Play("ko");
															if (218553 - 32224 == 186329)
															{
																this.$self_$16465.animation.wrapMode = WrapMode.Once;
																if (180791 - 522210 != -341418)
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
				Block_3:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_9:
				Block_12:
				IL_32F:
				IL_363:
				goto IL_48C;
				Block_23:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x060006E0 RID: 1760 RVA: 0x000B543C File Offset: 0x000B363C
			internal static bool NkEaRoT1stHN33V4lGb()
			{
				return true;
			}

			// Token: 0x060006E1 RID: 1761 RVA: 0x000B5440 File Offset: 0x000B3640
			internal static bool aF2xQhT4DxEfwm9rEwk()
			{
				return false;
			}

			// Token: 0x04000665 RID: 1637
			internal Vector3 $mPos$16462;

			// Token: 0x04000666 RID: 1638
			internal Vector3 $mDir$16463;

			// Token: 0x04000667 RID: 1639
			internal UnityScript.Lang.Array $nArray$16464;

			// Token: 0x04000668 RID: 1640
			internal NeonBug $self_$16465;
		}
	}

	// Token: 0x02000136 RID: 310
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16468 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060006E2 RID: 1762 RVA: 0x000B5444 File Offset: 0x000B3644
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16468(UnityScript.Lang.Array nArray, NeonBug self_)
		{
			if (286037 - 410844 != -124806)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (187899 - 587545 != -399645)
				{
					base..ctor();
					if (202978 - 426819 != -223840)
					{
						this.$nArray$16473 = nArray;
						if (171815 - 350430 != -178614)
						{
							this.$self_$16474 = self_;
							if (96311 - 109904 == -13593)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x000B5500 File Offset: 0x000B3700
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NeonBug.$RPC_dead$16468.$(this.$nArray$16473, this.$self_$16474);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000B5514 File Offset: 0x000B3714
		internal static bool hkTpouTz55ih3JlKfVc()
		{
			return true;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000B5518 File Offset: 0x000B3718
		internal static bool a6digX3a5uwyMFjHEUo()
		{
			return false;
		}

		// Token: 0x04000669 RID: 1641
		internal UnityScript.Lang.Array $nArray$16473;

		// Token: 0x0400066A RID: 1642
		internal NeonBug $self_$16474;

		// Token: 0x02000137 RID: 311
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060006E6 RID: 1766 RVA: 0x000B551C File Offset: 0x000B371C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, NeonBug self_)
			{
				if (100949 - 79930 != 21020)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (149848 - 34977 == 114871)
					{
						base..ctor();
						if (156850 - 28540 == 128310)
						{
							this.$nArray$16471 = nArray;
							if (289500 - 429325 != -139824)
							{
								this.$self_$16472 = self_;
								if (210472 - 54347 == 156125)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060006E7 RID: 1767 RVA: 0x000B55D8 File Offset: 0x000B37D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194011 - 45275 != 148736)
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
						if (this.$self_$16472.yIKnZJh08P.actionState != "dead")
						{
							if (77019 - 197411 != -120391)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							if (!this.$self_$16472.yIKnZJh08P.isPlayer)
							{
								if (98523 - 516310 == -417786)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$16472.gameObject);
								if (214416 - 276019 == -61602)
								{
									continue;
								}
							}
							else if (this.$self_$16472.yIKnZJh08P.isMine)
							{
								if (253875 - 410496 != -156621)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16472.gameObject);
								if (173209 - 250683 != -77474)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (194645 - 159644 != 35001)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (174851 - 159077 == 15775)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16472.yIKnZJh08P.actionState == "dead")
					{
						if (114624 - 196257 == -81633)
						{
							break;
						}
					}
					else
					{
						this.$mPos$16469 = (Vector3)this.$nArray$16471[0];
						if (84235 - 392885 == -308650)
						{
							this.$myDirection$16470 = (Vector3)this.$nArray$16471[1];
							if (50183 - 227858 != -177674)
							{
								this.$self_$16472.transform.position = this.$mPos$16469;
								if (200536 - 49087 == 151449)
								{
									this.$self_$16472.transform.LookAt(this.$mPos$16469 + this.$myDirection$16470);
									if (67868 - 254078 == -186210)
									{
										this.$self_$16472.yIKnZJh08P.hp = 0;
										if (18487 - 241402 == -222915)
										{
											this.$self_$16472.yIKnZJh08P.actionState = "dead";
											if (297813 - 460308 != -162494)
											{
												this.$self_$16472.yIKnZJh08P.actionTime = Time.time;
												if (45716 - 474664 != -428947)
												{
													this.$self_$16472.yIKnZJh08P.myCommand = "none";
													if (24466 - 86011 != -61544)
													{
														this.$self_$16472.yIKnZJh08P.vMovement = Vector3.zero;
														if (200124 - 432484 == -232360)
														{
															this.$self_$16472.yIKnZJh08P.moveSpeed = (float)0;
															if (283071 - 273379 != 9693)
															{
																this.$self_$16472.animation.Rewind();
																if (147236 - 529927 == -382691)
																{
																	this.$self_$16472.animation.Play("ko");
																	if (273770 - 429206 == -155436)
																	{
																		this.$self_$16472.animation.wrapMode = WrapMode.Once;
																		if (180843 - 306057 == -125214)
																		{
																			goto IL_33F;
																		}
																	}
																}
															}
														}
													}
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
				IL_33F:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_20:
				IL_42F:
				return false;
			}

			// Token: 0x060006E8 RID: 1768 RVA: 0x000B5A28 File Offset: 0x000B3C28
			internal static bool whOjl735FU5nGYN7hfn()
			{
				return true;
			}

			// Token: 0x060006E9 RID: 1769 RVA: 0x000B5A2C File Offset: 0x000B3C2C
			internal static bool latr5q3pGtWkLlQUI70()
			{
				return false;
			}

			// Token: 0x0400066B RID: 1643
			internal Vector3 $mPos$16469;

			// Token: 0x0400066C RID: 1644
			internal Vector3 $myDirection$16470;

			// Token: 0x0400066D RID: 1645
			internal UnityScript.Lang.Array $nArray$16471;

			// Token: 0x0400066E RID: 1646
			internal NeonBug $self_$16472;
		}
	}
}
