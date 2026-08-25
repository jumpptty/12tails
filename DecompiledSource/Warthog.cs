using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DD9 RID: 3545
[Serializable]
public class Warthog : MonoBehaviour
{
	// Token: 0x06005011 RID: 20497 RVA: 0x009D1E60 File Offset: 0x009D0060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Warthog()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005012 RID: 20498 RVA: 0x009D1E70 File Offset: 0x009D0070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (70812 - 541092 != -470280)
		{
		}
		for (;;)
		{
			this.JILcQXf2Pm1 = this.transform;
			if (104475 - 29164 == 75311)
			{
				this.fQecQODBdCb = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (254959 - 427105 != -172145)
				{
					this.fQecQODBdCb.actionState = "standby";
					if (58842 - 253668 != -194825)
					{
						this.fQecQODBdCb.actionTime = Time.time;
						if (94319 - 489674 != -395354)
						{
							this.fQecQODBdCb.myCommand = "none";
							if (182069 - 95342 != 86728)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (255458 - 410219 == -154761)
								{
									this.fQecQODBdCb.isMine = true;
									if (266191 - 497687 == -231496)
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

	// Token: 0x06005013 RID: 20499 RVA: 0x009D1FD0 File Offset: 0x009D01D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (138607 - 486740 != -348133)
		{
		}
		for (;;)
		{
			if (this.fQecQODBdCb.isControlled)
			{
				if (100453 - 58757 == 41697)
				{
					continue;
				}
				if (!(this.fQecQODBdCb.actionState == "standby"))
				{
					if (288841 - 229218 != 59623)
					{
						continue;
					}
					if (!(this.fQecQODBdCb.actionState == "run"))
					{
						goto IL_1F4;
					}
					if (191333 - 317746 != -126413)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (10973 - 303200 != -292227)
				{
					continue;
				}
			}
			IL_1F4:
			if (this.fQecQODBdCb.hp <= 0)
			{
				if (242826 - 112403 != 130423)
				{
					continue;
				}
				if (this.fQecQODBdCb.actionState != "dead")
				{
					if (167289 - 570254 == -402964)
					{
						continue;
					}
					if (this.fQecQODBdCb.isMine)
					{
						if (161524 - 3141 == 158384)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (117707 - 151725 != -34018)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (131052 - 317906 != -186854)
						{
							continue;
						}
						this.fQecQODBdCb.DeadEvent();
						if (22825 - 510983 != -488157)
						{
							break;
						}
						continue;
					}
					else
					{
						this.fQecQODBdCb.hp = 1;
						if (64624 - 580792 != -516167)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.fQecQODBdCb.hp <= 0)
			{
				break;
			}
			if (80208 - 222783 != -142574)
			{
				if (this.fQecQODBdCb.ko > 0)
				{
					break;
				}
				if (207346 - 284926 == -77580)
				{
					if (!(this.fQecQODBdCb.actionState != "ko"))
					{
						break;
					}
					if (128626 - 377382 != -248755)
					{
						if (!(this.fQecQODBdCb.actionState != "dead"))
						{
							break;
						}
						if (222656 - 464268 != -241611)
						{
							if (this.fQecQODBdCb.isMine)
							{
								if (126048 - 95763 != 30286)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (296491 - 551583 != -255091)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (122432 - 359649 != -237216)
										{
											this.fQecQODBdCb.KoEvent();
											if (282366 - 201973 == 80393)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.fQecQODBdCb.ko = 1;
								if (101212 - 135112 != -33899)
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

	// Token: 0x06005014 RID: 20500 RVA: 0x009D23C8 File Offset: 0x009D05C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (289371 - 432342 != -142971)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (33786 - 362041 == -328255)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (119043 - 523576 == -404533)
				{
					if (13608 - 459099 == -445491)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (79965 - 395576 == -315610)
							{
								continue;
							}
							v = 1;
							if (202437 - 31384 == 171054)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (156204 - 490579 != -334375)
							{
								continue;
							}
							v = -1;
							if (33404 - 455856 != -422452)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (273209 - 591611 != -318402)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (249488 - 90334 == 159154)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (127090 - 349896 == -222806)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (100299 - 383980 == -283681)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (13197 - 552124 != -538926)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (17944 - 43997 == -26053)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (12712 - 312832 != -300119)
											{
												Hashtable hashtable = new Hashtable();
												if (218619 - 284720 == -66101)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (6165 - 483595 != -477429)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (74526 - 106256 != -31729)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (202043 - 205203 != -3159)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (276447 - 36142 == 240305)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (274232 - 127767 != 146466)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (18546 - 592771 != -574224)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (202431 - 146643 == 55788)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (190704 - 526261 == -335557)
																				{
																					PhotonClient.SendEvent(this.fQecQODBdCb.ActorNr, 74, hashtable, true, true);
																					if (290791 - 438048 != -147256)
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

	// Token: 0x06005015 RID: 20501 RVA: 0x009D2848 File Offset: 0x009D0A48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (166424 - 225578 != -59154)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (85403 - 540186 != -454782)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (85630 - 9697 != 75934)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (103345 - 303311 != -199965)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (249717 - 31777 == 217940)
						{
							int num3 = num;
							if (168459 - 543600 == -375141)
							{
								if (num3 == 1)
								{
									if (183310 - 39090 == 144220)
									{
										if (this.fQecQODBdCb.isMine)
										{
											break;
										}
										if (117273 - 366163 == -248890)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (255598 - 96679 == 158919)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (270579 - 524683 != -254103)
									{
										if (this.fQecQODBdCb.isMine)
										{
											break;
										}
										if (221020 - 293709 != -72688)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (175215 - 591490 != -416274)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (86539 - 595901 != -509361)
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

	// Token: 0x06005016 RID: 20502 RVA: 0x009D2ADC File Offset: 0x009D0CDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (226245 - 168103 != 58142)
		{
		}
		for (;;)
		{
			float num = this.fQecQODBdCb.moveSpeed;
			if (7207 - 166541 != -159333)
			{
				float runSpeed = this.fQecQODBdCb.runSpeed;
				if (83819 - 275910 == -192091)
				{
					Vector3 a = default(Vector3);
					if (168380 - 592709 != -424328)
					{
						Vector3 vector = Vector3.zero;
						if (262006 - 100196 != 161811)
						{
							float num2 = (float)0;
							if (149524 - 4389 == 145135)
							{
								if (this.fQecQODBdCb.isMine)
								{
									if (150140 - 148763 == 1378)
									{
										continue;
									}
									if ((this.fQecQODBdCb.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (225483 - 425254 != -199771)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (196004 - 101161 == 94844)
										{
											continue;
										}
										a.y = (float)0;
										if (122044 - 450416 == -328371)
										{
											continue;
										}
										a = a.normalized;
										if (35282 - 224725 != -189443)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (70532 - 581551 != -511019)
										{
											continue;
										}
										vector = vector.normalized;
										if (206905 - 28697 != 178208)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (57852 - 585816 != -527964)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (228103 - 5439 == 222665)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (181447 - 277187 == -95739)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (88836 - 295679 != -206843)
														{
															continue;
														}
														this.fQecQODBdCb.actionState = "run";
														if (161226 - 430915 == -269688)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (135071 - 210568 != -75497)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (261028 - 438730 == -177701)
														{
															continue;
														}
														this.animation.Play("run");
														if (173348 - 434640 == -261291)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (212386 - 160787 != 51599)
														{
															continue;
														}
														goto IL_855;
													}
												}
											}
										}
										this.fQecQODBdCb.actionState = "standby";
										if (31120 - 181024 == -149903)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (258201 - 423713 != -165512)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (114448 - 63087 == 51362)
											{
												continue;
											}
											num = (float)0;
											if (262095 - 569726 != -307631)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (294519 - 60563 != 233956)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (204706 - 455577 == -250870)
										{
											continue;
										}
									}
									IL_855:;
								}
								else
								{
									vector = global::Math.vFlat(this.fQecQODBdCb.nPosition - this.transform.position);
									if (44108 - 590807 == -546698)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (32824 - 87129 == -54304)
									{
										continue;
									}
									if (this.fQecQODBdCb.nSpeed != (float)0)
									{
										if (272381 - 528045 == -255663)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (213730 - 100940 != 112790)
											{
												continue;
											}
											this.transform.position = this.fQecQODBdCb.nPosition;
											if (226523 - 242687 != -16164)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (124581 - 482106 != -357525)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (272216 - 585280 != -313064)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (278009 - 204397 != 73612)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.fQecQODBdCb.nSpeed, (float)10 * Time.deltaTime);
												if (66405 - 123204 == -56798)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (81609 - 94339 != -12730)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (254962 - 306580 != -51618)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (9391 - 212487 != -203096)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (261605 - 475225 != -213620)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (64380 - 28126 != 36254)
											{
												continue;
											}
										}
										else if (Time.time > this.fQecQODBdCb.nSpeed + 0.3f)
										{
											if (183258 - 102150 != 81108)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (199625 - 142596 == 57030)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (73927 - 195131 != -121204)
												{
													continue;
												}
												num = (float)0;
												if (98230 - 450701 != -352471)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.fQecQODBdCb.nDirection);
											if (132409 - 425973 != -293564)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (40726 - 432828 == -392101)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (212626 - 341241 != -128615)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (226602 - 570742 == -344139)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (56104 - 74688 != -18584)
											{
												continue;
											}
											this.transform.position = this.fQecQODBdCb.nPosition;
											if (13575 - 86423 != -72848)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (50751 - 330539 != -279788)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (190411 - 598192 == -407780)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (200671 - 544713 == -344041)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (127841 - 105508 != 22333)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (150061 - 201740 != -51679)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (108807 - 412590 == -303782)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (177706 - 1994 == 175713)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.fQecQODBdCb.nDirection);
											if (77449 - 565791 != -488342)
											{
												continue;
											}
											num = (float)0;
											if (117311 - 371562 == -254250)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (94772 - 533423 == -438650)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (148871 - 500087 == -351215)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (60796 - 14526 != 46270)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (68440 - 479 == 67962)
										{
											continue;
										}
									}
								}
								this.fQecQODBdCb.vMovement = vector;
								if (81430 - 167518 == -86088)
								{
									this.fQecQODBdCb.moveSpeed = num;
									if (191387 - 2962 == 188425)
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

	// Token: 0x06005017 RID: 20503 RVA: 0x009D3640 File Offset: 0x009D1840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (63301 - 81738 != -18436)
		{
		}
		for (;;)
		{
			if (!this.fQecQODBdCb.isMine)
			{
				if (124343 - 297515 == -173172)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (218321 - 20422 != 197900)
				{
					Vector3 vector = a - this.transform.position;
					if (255737 - 20280 == 235457)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (37509 - 105696 == -68187)
						{
							CharacterControl characterControl = null;
							if (206005 - 300196 != -94190 && 96176 - 394297 != -298120)
							{
								if (gameObject)
								{
									if (121802 - 387612 != -265810)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (86151 - 410544 != -324393)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (46899 - 297988 == -251088)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (268531 - 539692 != -271161)
									{
										continue;
									}
								}
								if (!(this.fQecQODBdCb.actionState == "standby"))
								{
									if (77342 - 321974 != -244632)
									{
										continue;
									}
									if (!(this.fQecQODBdCb.actionState == "run"))
									{
										break;
									}
									if (37255 - 382925 == -345669)
									{
										continue;
									}
								}
								if (this.fQecQODBdCb.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (3699 - 170333 != -166633)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector.normalized, 0));
									if (190624 - 525634 == -335010)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (114975 - 347098 == -232123)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, vector.normalized, 0);
											if (57050 - 421892 != -364841)
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

	// Token: 0x06005018 RID: 20504 RVA: 0x009D3944 File Offset: 0x009D1B44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (160392 - 578223 != -417830)
		{
		}
		for (;;)
		{
			if (!this.fQecQODBdCb.isMine)
			{
				if (227271 - 434844 != -207572)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (203195 - 561479 == -358284)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (160495 - 162 != 160334)
					{
						Vector3 normalized = vector.normalized;
						if (273126 - 459657 != -186530)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (154603 - 525709 != -371105)
							{
								CharacterControl characterControl = null;
								if (114211 - 336880 == -222669 && 20293 - 523858 != -503564)
								{
									if (gameObject)
									{
										if (60491 - 399882 != -339391)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (297752 - 134306 == 163447)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (87061 - 43217 == 43845)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (188036 - 443724 == -255687)
										{
											continue;
										}
									}
									if (!(this.fQecQODBdCb.actionState == "standby"))
									{
										if (249833 - 523240 == -273406)
										{
											continue;
										}
										if (!(this.fQecQODBdCb.actionState == "run"))
										{
											break;
										}
										if (249018 - 318213 != -69195)
										{
											continue;
										}
									}
									if (this.fQecQODBdCb.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (225591 - 532050 == -306459)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
										if (171925 - 211679 != -39753)
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

	// Token: 0x06005019 RID: 20505 RVA: 0x009D3C10 File Offset: 0x009D1E10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600501A RID: 20506 RVA: 0x009D3C14 File Offset: 0x009D1E14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Warthog.$RPC_nAttack$33677(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600501B RID: 20507 RVA: 0x009D3C24 File Offset: 0x009D1E24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (182349 - 124286 != 58064)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (153293 - 482989 == -329695)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (138390 - 319790 != -181400)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (163217 - 157382 != 5835)
				{
					continue;
				}
			}
			if (Time.time <= this.lapcQ27x0Bo)
			{
				break;
			}
			if (232173 - 280283 != -48109)
			{
				this.lapcQ27x0Bo = Time.time + 0.1f;
				if (34042 - 107580 != -73537)
				{
					if (this.nAttack_hitFX)
					{
						if (184840 - 541059 == -356219)
						{
							Audiof.PlayClipAt(this.nAttack_hitFX, hitPos);
							if (74141 - 289912 == -215771)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find nAttack_hit soound");
						if (12817 - 52727 != -39909)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600501C RID: 20508 RVA: 0x009D3DAC File Offset: 0x009D1FAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Warthog.$RPC_ko$33691(nArray, this).GetEnumerator();
	}

	// Token: 0x0600501D RID: 20509 RVA: 0x009D3DBC File Offset: 0x009D1FBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Warthog.$RPC_dead$33698(nArray, this).GetEnumerator();
	}

	// Token: 0x0600501E RID: 20510 RVA: 0x009D3DCC File Offset: 0x009D1FCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600501F RID: 20511 RVA: 0x009D3DD0 File Offset: 0x009D1FD0
	internal static bool I2sfWq5BofFpjEZYQRjS()
	{
		return true;
	}

	// Token: 0x06005020 RID: 20512 RVA: 0x009D3DD4 File Offset: 0x009D1FD4
	internal static bool VoYV1t5BEmqPBNgsrmQF()
	{
		return false;
	}

	// Token: 0x040059A9 RID: 22953
	private Transform JILcQXf2Pm1;

	// Token: 0x040059AA RID: 22954
	private CharacterControl fQecQODBdCb;

	// Token: 0x040059AB RID: 22955
	public GameObject nAttack_ring;

	// Token: 0x040059AC RID: 22956
	public AudioClip nAttack_vc;

	// Token: 0x040059AD RID: 22957
	public GameObject nAttack_hit;

	// Token: 0x040059AE RID: 22958
	public AudioClip nAttack_hitFX;

	// Token: 0x040059AF RID: 22959
	private float lapcQ27x0Bo;

	// Token: 0x040059B0 RID: 22960
	public AudioClip ko_vc;

	// Token: 0x02000DDA RID: 3546
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33677 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005021 RID: 20513 RVA: 0x009D3DD8 File Offset: 0x009D1FD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33677(Vector3 mPos, Vector3 tDir, Warthog self_)
		{
			if (283828 - 351590 != -67762)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (188499 - 470859 != -282359)
				{
					base..ctor();
					if (205550 - 519218 != -313667)
					{
						this.$mPos$33688 = mPos;
						if (26622 - 301310 != -274687)
						{
							this.$tDir$33689 = tDir;
							if (157543 - 111571 != 45973)
							{
								this.$self_$33690 = self_;
								if (63720 - 485813 == -422093)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005022 RID: 20514 RVA: 0x009D3EB4 File Offset: 0x009D20B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Warthog.$RPC_nAttack$33677.$(this.$mPos$33688, this.$tDir$33689, this.$self_$33690);
		}

		// Token: 0x06005023 RID: 20515 RVA: 0x009D3ED0 File Offset: 0x009D20D0
		internal static bool gafUxx5B2uYnBSe0ZjxB()
		{
			return true;
		}

		// Token: 0x06005024 RID: 20516 RVA: 0x009D3ED4 File Offset: 0x009D20D4
		internal static bool eyNBJa5B8qhNvdxM7UOp()
		{
			return false;
		}

		// Token: 0x040059B1 RID: 22961
		internal Vector3 $mPos$33688;

		// Token: 0x040059B2 RID: 22962
		internal Vector3 $tDir$33689;

		// Token: 0x040059B3 RID: 22963
		internal Warthog $self_$33690;

		// Token: 0x02000DDB RID: 3547
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005025 RID: 20517 RVA: 0x009D3ED8 File Offset: 0x009D20D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Warthog self_)
			{
				if (208380 - 228721 != -20341)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (98437 - 247165 != -148727)
					{
						base..ctor();
						if (82936 - 551951 == -469015)
						{
							this.$mPos$33685 = mPos;
							if (1835 - 247257 != -245421)
							{
								this.$tDir$33686 = tDir;
								if (229010 - 160673 != 68338)
								{
									this.$self_$33687 = self_;
									if (277986 - 186277 == 91709)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005026 RID: 20518 RVA: 0x009D3FB4 File Offset: 0x009D21B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194674 - 42072 != 152603)
				{
				}
				for (;;)
				{
					IL_4D4:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_D22;
					case 2:
						if (this.$self_$33687.fQecQODBdCb.actionState != "attack")
						{
							goto IL_50D;
						}
						if (283914 - 466912 == -182997)
						{
							continue;
						}
						if (this.$self_$33687.fQecQODBdCb.myCommand != "nAttack")
						{
							if (256802 - 60013 != 196789)
							{
								continue;
							}
							goto IL_50D;
						}
						else
						{
							this.$self_$33687.fQecQODBdCb.moveSpeed = (float)3;
							if (232714 - 14775 != 217940)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33687.fQecQODBdCb.actionState != "attack")
						{
							goto IL_53E;
						}
						if (295940 - 346099 != -50159)
						{
							continue;
						}
						if (this.$self_$33687.fQecQODBdCb.myCommand != "nAttack")
						{
							if (275681 - 224935 != 50746)
							{
								continue;
							}
							goto IL_53E;
						}
						else
						{
							this.$self_$33687.fQecQODBdCb.moveSpeed = (float)0;
							if (14516 - 67441 != -52925)
							{
								continue;
							}
							this.$hitLayer$33678 = 130816 - (1 << this.$self_$33687.gameObject.layer);
							if (135326 - 239203 != -103877)
							{
								continue;
							}
							this.$hitList$33679 = null;
							if (247454 - 274952 == -27497)
							{
								continue;
							}
							this.$hitPos$33680 = default(Vector3);
							if (86180 - 496066 == -409885)
							{
								continue;
							}
							if (!this.$self_$33687.fQecQODBdCb.isMine)
							{
								goto IL_7EA;
							}
							if (260408 - 462277 == -201868)
							{
								continue;
							}
							this.$hitList$33679 = Damage.FindRecTarget(this.$self_$33687.transform.position, this.$self_$33687.transform.forward, 0.5f, 0.5f, (float)2, (float)2, this.$hitLayer$33678);
							if (270245 - 301114 == -30868)
							{
								continue;
							}
							this.$$iterator$10841$33682 = UnityRuntimeServices.GetEnumerator(this.$hitList$33679);
							if (176869 - 340550 != -163681)
							{
								continue;
							}
							while (this.$$iterator$10841$33682.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10841$33682.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33681 = (GameObject)obj2;
								if (223714 - 159406 != 64308)
								{
									goto IL_4D4;
								}
								if (this.$self_$33687.fQecQODBdCb.hit(1, this.$hitObject$33681, this.$self_$33687.fQecQODBdCb.atk, 5, 0, 0.5f * this.$self_$33687.transform.forward) != 0)
								{
									if (52762 - 398548 != -345786)
									{
										goto IL_4D4;
									}
									this.$hitPos$33680 = this.$hitObject$33681.collider.ClosestPointOnBounds(this.$self_$33687.transform.position + Vector3.up);
									if (154420 - 371959 != -217539)
									{
										goto IL_4D4;
									}
									UnityRuntimeServices.Update(this.$$iterator$10841$33682, this.$hitObject$33681);
									if (242434 - 228840 == 13595)
									{
										goto IL_4D4;
									}
									this.$self_$33687.RPC_nAttack_hit(this.$hitPos$33680, this.$self_$33687.transform.forward, 0);
									if (206153 - 238007 == -31853)
									{
										goto IL_4D4;
									}
									this.$self_$33687.ActionEvent("RPC_nAttack_hit", this.$hitPos$33680, this.$self_$33687.transform.forward, 0);
									if (3312 - 586486 == -583173)
									{
										goto IL_4D4;
									}
								}
							}
							if (97452 - 481010 != -383558)
							{
								continue;
							}
							goto IL_7EA;
						}
						break;
					case 4:
						if (this.$self_$33687.fQecQODBdCb.actionState != "attack")
						{
							goto IL_949;
						}
						if (112878 - 272431 != -159553)
						{
							continue;
						}
						if (this.$self_$33687.fQecQODBdCb.myCommand != "nAttack")
						{
							if (284900 - 17644 != 267257)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							if (this.$self_$33687.fQecQODBdCb.isMine)
							{
								if (150477 - 357440 != -206963)
								{
									continue;
								}
								this.$hitList$33679 = Damage.FindRecTarget(this.$self_$33687.transform.position, this.$self_$33687.transform.forward, 0.5f, 0.5f, (float)2, (float)2, this.$hitLayer$33678);
								if (163672 - 175715 != -12043)
								{
									continue;
								}
								this.$$iterator$10842$33684 = UnityRuntimeServices.GetEnumerator(this.$hitList$33679);
								if (133050 - 403897 != -270847)
								{
									continue;
								}
								while (this.$$iterator$10842$33684.MoveNext())
								{
									object obj4;
									object obj3 = obj4 = this.$$iterator$10842$33684.Current;
									if (!(obj3 is GameObject))
									{
										obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
									}
									this.$hitObject$33683 = (GameObject)obj4;
									if (43200 - 74615 == -31414)
									{
										goto IL_4D4;
									}
									if (this.$self_$33687.fQecQODBdCb.hit(2, this.$hitObject$33683, this.$self_$33687.fQecQODBdCb.atk, 5, 0, 0.5f * this.$self_$33687.transform.forward) != 0)
									{
										if (10403 - 461930 == -451526)
										{
											goto IL_4D4;
										}
										this.$hitPos$33680 = this.$hitObject$33683.collider.ClosestPointOnBounds(this.$self_$33687.transform.position + Vector3.up);
										if (21263 - 73049 == -51785)
										{
											goto IL_4D4;
										}
										UnityRuntimeServices.Update(this.$$iterator$10842$33684, this.$hitObject$33683);
										if (209449 - 322751 == -113301)
										{
											goto IL_4D4;
										}
										this.$self_$33687.RPC_nAttack_hit(this.$hitPos$33680, this.$self_$33687.transform.forward, 0);
										if (119320 - 4250 != 115070)
										{
											goto IL_4D4;
										}
										this.$self_$33687.ActionEvent("RPC_nAttack_hit", this.$hitPos$33680, this.$self_$33687.transform.forward, 0);
										if (266240 - 54877 == 211364)
										{
											goto IL_4D4;
										}
									}
								}
								if (30257 - 269124 != -238867)
								{
									continue;
								}
							}
							if (this.$self_$33687.fQecQODBdCb.actionState == "attack")
							{
								if (160003 - 72990 == 87014)
								{
									continue;
								}
								if (this.$self_$33687.fQecQODBdCb.myCommand == "nAttack")
								{
									if (198063 - 251747 != -53684)
									{
										continue;
									}
									this.$self_$33687.fQecQODBdCb.actionState = "standby";
									if (137500 - 453698 == -316197)
									{
										continue;
									}
									this.$self_$33687.fQecQODBdCb.actionTime = Time.time;
									if (196311 - 283392 != -87081)
									{
										continue;
									}
									this.$self_$33687.fQecQODBdCb.myCommand = "none";
									if (159947 - 23079 == 136869)
									{
										continue;
									}
									if (!this.$self_$33687.fQecQODBdCb.isMine)
									{
										if (155593 - 535052 == -379458)
										{
											continue;
										}
										this.$self_$33687.fQecQODBdCb.nPosition = this.$self_$33687.transform.position;
										if (256564 - 262647 == -6082)
										{
											continue;
										}
										this.$self_$33687.fQecQODBdCb.oPosition = this.$self_$33687.transform.position;
										if (210786 - 44015 != 166771)
										{
											continue;
										}
										this.$self_$33687.fQecQODBdCb.nDirection = this.$self_$33687.transform.forward;
										if (207586 - 574859 != -367273)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (189568 - 34192 != 155376)
							{
								continue;
							}
							goto IL_D22;
						}
						break;
					default:
						if (170188 - 480918 != -310730)
						{
							continue;
						}
						break;
					}
					this.$self_$33687.fQecQODBdCb.actionState = "attack";
					if (144772 - 137691 != 7082)
					{
						this.$self_$33687.fQecQODBdCb.actionTime = Time.time;
						if (110531 - 275678 != -165146)
						{
							this.$self_$33687.fQecQODBdCb.myCommand = "nAttack";
							if (296137 - 117324 == 178813)
							{
								this.$self_$33687.fQecQODBdCb.addTimeOut("nAttack", (float)2);
								if (157553 - 506472 == -348919)
								{
									this.$self_$33687.JILcQXf2Pm1.position = this.$mPos$33685;
									if (256354 - 478866 == -222512)
									{
										this.$self_$33687.JILcQXf2Pm1.LookAt(this.$mPos$33685 + global::Math.vFlat(this.$tDir$33686));
										if (68760 - 552152 == -483392)
										{
											this.$self_$33687.animation.CrossFade("nAttack");
											if (113755 - 144542 == -30787)
											{
												this.$self_$33687.animation.wrapMode = WrapMode.Once;
												if (94568 - 381304 != -286735)
												{
													this.$self_$33687.fQecQODBdCb.vMovement = this.$self_$33687.transform.forward;
													if (160203 - 184186 == -23983)
													{
														this.$self_$33687.fQecQODBdCb.moveSpeed = (float)0;
														if (46914 - 15324 != 31591)
														{
															if (this.$self_$33687.nAttack_ring)
															{
																if (255195 - 422985 != -167790)
																{
																	continue;
																}
																this.$self_$33687.fQecQODBdCb.createEffect(this.$self_$33687.nAttack_ring, this.$self_$33687.transform.position, this.$self_$33687.transform.rotation);
																if (48191 - 496284 != -448093)
																{
																	continue;
																}
															}
															else
															{
																Debug.Log("Missing nAttack_ring effect");
																if (139226 - 383154 != -243928)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																break;
															}
															if (54655 - 99945 == -45290)
															{
																if (this.$self_$33687.nAttack_vc)
																{
																	if (29610 - 95679 != -66068)
																	{
																		this.$self_$33687.audio.PlayOneShot(this.$self_$33687.nAttack_vc);
																		if (60000 - 34121 != 25880)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find nAttack voice");
																	if (297625 - 197882 == 99743)
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
				goto IL_713;
				Block_23:
				IL_50D:
				goto IL_D22;
				Block_36:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_53E:
				goto IL_D22;
				IL_713:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_7EA:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_949:
				IL_D22:
				return false;
			}

			// Token: 0x06005027 RID: 20519 RVA: 0x009D4CF8 File Offset: 0x009D2EF8
			internal static bool BrZQ6o5BZnCoZbQmUqth()
			{
				return true;
			}

			// Token: 0x06005028 RID: 20520 RVA: 0x009D4CFC File Offset: 0x009D2EFC
			internal static bool BBSDbj5BCI6vXUaYUMM1()
			{
				return false;
			}

			// Token: 0x040059B4 RID: 22964
			internal int $hitLayer$33678;

			// Token: 0x040059B5 RID: 22965
			internal UnityScript.Lang.Array $hitList$33679;

			// Token: 0x040059B6 RID: 22966
			internal Vector3 $hitPos$33680;

			// Token: 0x040059B7 RID: 22967
			internal GameObject $hitObject$33681;

			// Token: 0x040059B8 RID: 22968
			internal IEnumerator $$iterator$10841$33682;

			// Token: 0x040059B9 RID: 22969
			internal GameObject $hitObject$33683;

			// Token: 0x040059BA RID: 22970
			internal IEnumerator $$iterator$10842$33684;

			// Token: 0x040059BB RID: 22971
			internal Vector3 $mPos$33685;

			// Token: 0x040059BC RID: 22972
			internal Vector3 $tDir$33686;

			// Token: 0x040059BD RID: 22973
			internal Warthog $self_$33687;
		}
	}

	// Token: 0x02000DDC RID: 3548
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33691 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005029 RID: 20521 RVA: 0x009D4D00 File Offset: 0x009D2F00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33691(UnityScript.Lang.Array nArray, Warthog self_)
		{
			if (49288 - 466935 != -417646)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (224012 - 561156 != -337143)
				{
					base..ctor();
					if (51123 - 504490 == -453367)
					{
						this.$nArray$33696 = nArray;
						if (160110 - 379798 != -219687)
						{
							this.$self_$33697 = self_;
							if (105021 - 498362 == -393341)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x009D4DBC File Offset: 0x009D2FBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Warthog.$RPC_ko$33691.$(this.$nArray$33696, this.$self_$33697);
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x009D4DD0 File Offset: 0x009D2FD0
		internal static bool yWN0vR5BLguSeX99EP5y()
		{
			return true;
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x009D4DD4 File Offset: 0x009D2FD4
		internal static bool pl8cGj5BOaDD0vLAhscY()
		{
			return false;
		}

		// Token: 0x040059BE RID: 22974
		internal UnityScript.Lang.Array $nArray$33696;

		// Token: 0x040059BF RID: 22975
		internal Warthog $self_$33697;

		// Token: 0x02000DDD RID: 3549
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600502D RID: 20525 RVA: 0x009D4DD8 File Offset: 0x009D2FD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Warthog self_)
			{
				if (69582 - 404983 != -335401)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (297315 - 455071 == -157756)
					{
						base..ctor();
						if (66842 - 248264 != -181421)
						{
							this.$nArray$33694 = nArray;
							if (81138 - 106428 == -25290)
							{
								this.$self_$33695 = self_;
								if (185473 - 140924 != 44550)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600502E RID: 20526 RVA: 0x009D4E94 File Offset: 0x009D3094
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (53408 - 121094 != -67686)
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
						if (this.$self_$33695.fQecQODBdCb.actionState != "ko")
						{
							if (197836 - 195208 != 2628)
							{
								continue;
							}
							goto IL_EE;
						}
						else
						{
							this.$self_$33695.animation.Play("getUp");
							if (211217 - 328628 != -117411)
							{
								continue;
							}
							this.$self_$33695.animation.wrapMode = WrapMode.Once;
							if (210807 - 557908 != -347101)
							{
								continue;
							}
							goto IL_4D2;
						}
						break;
					case 3:
						if (this.$self_$33695.fQecQODBdCb.actionState != "ko")
						{
							if (95138 - 599939 != -504801)
							{
								continue;
							}
							goto IL_43A;
						}
						else
						{
							this.$self_$33695.fQecQODBdCb.actionState = "standby";
							if (220914 - 355697 == -134782)
							{
								continue;
							}
							this.$self_$33695.fQecQODBdCb.actionTime = Time.time;
							if (241824 - 244206 != -2382)
							{
								continue;
							}
							this.$self_$33695.fQecQODBdCb.myCommand = "none";
							if (26339 - 4979 != 21360)
							{
								continue;
							}
							this.$self_$33695.fQecQODBdCb.ko = this.$self_$33695.fQecQODBdCb.mko;
							if (173936 - 193365 != -19429)
							{
								continue;
							}
							this.YieldDefault(1);
							if (2971 - 563530 != -560559)
							{
								continue;
							}
							goto IL_543;
						}
						break;
					default:
						if (112964 - 504836 == -391871)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33695.fQecQODBdCb.actionState == "ko")
					{
						goto IL_3A7;
					}
					if (145415 - 113393 == 32022)
					{
						if (this.$self_$33695.fQecQODBdCb.actionState == "dead")
						{
							if (158405 - 168955 == -10550)
							{
								goto IL_3A7;
							}
						}
						else
						{
							this.$mPos$33692 = (Vector3)this.$nArray$33694[0];
							if (140118 - 339664 != -199545)
							{
								this.$mDir$33693 = (Vector3)this.$nArray$33694[1];
								if (222232 - 152932 != 69301)
								{
									this.$self_$33695.fQecQODBdCb.ko = 0;
									if (46425 - 303025 == -256600)
									{
										this.$self_$33695.fQecQODBdCb.actionState = "ko";
										if (23991 - 519719 == -495728)
										{
											this.$self_$33695.fQecQODBdCb.actionTime = Time.time;
											if (1027 - 517913 != -516885)
											{
												this.$self_$33695.fQecQODBdCb.myCommand = "none";
												if (151730 - 305989 == -154259)
												{
													this.$self_$33695.fQecQODBdCb.vMovement = Vector3.zero;
													if (136888 - 139638 == -2750)
													{
														this.$self_$33695.fQecQODBdCb.moveSpeed = (float)0;
														if (142433 - 271409 == -128976)
														{
															this.$self_$33695.animation.Play("ko");
															if (204382 - 336006 == -131624)
															{
																this.$self_$33695.animation.wrapMode = WrapMode.Once;
																if (226079 - 191978 == 34101)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		break;
																	}
																	if (207407 - 109110 != 98298)
																	{
																		if (this.$self_$33695.ko_vc)
																		{
																			if (58368 - 239472 != -181103)
																			{
																				this.$self_$33695.audio.PlayOneShot(this.$self_$33695.ko_vc);
																				if (187684 - 539458 != -351773)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (258713 - 146737 == 111976)
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
				IL_9F:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_EE:
				goto IL_543;
				goto IL_9F;
				IL_3A7:
				IL_43A:
				goto IL_543;
				IL_4D2:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_543:
				return false;
			}

			// Token: 0x0600502F RID: 20527 RVA: 0x009D53F8 File Offset: 0x009D35F8
			internal static bool kMWS4t5Bmh35ofRmTUVq()
			{
				return true;
			}

			// Token: 0x06005030 RID: 20528 RVA: 0x009D53FC File Offset: 0x009D35FC
			internal static bool TZgdfs5BFG1JM2c6xrq5()
			{
				return false;
			}

			// Token: 0x040059C0 RID: 22976
			internal Vector3 $mPos$33692;

			// Token: 0x040059C1 RID: 22977
			internal Vector3 $mDir$33693;

			// Token: 0x040059C2 RID: 22978
			internal UnityScript.Lang.Array $nArray$33694;

			// Token: 0x040059C3 RID: 22979
			internal Warthog $self_$33695;
		}
	}

	// Token: 0x02000DDE RID: 3550
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33698 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005031 RID: 20529 RVA: 0x009D5400 File Offset: 0x009D3600
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33698(UnityScript.Lang.Array nArray, Warthog self_)
		{
			if (230467 - 294847 != -64380)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (68868 - 405719 == -336851)
				{
					base..ctor();
					if (242870 - 489656 == -246786)
					{
						this.$nArray$33703 = nArray;
						if (265624 - 494865 == -229241)
						{
							this.$self_$33704 = self_;
							if (35007 - 402876 != -367868)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x009D54BC File Offset: 0x009D36BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Warthog.$RPC_dead$33698.$(this.$nArray$33703, this.$self_$33704);
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x009D54D0 File Offset: 0x009D36D0
		internal static bool CbZLqc5BMjxO1akBfNBr()
		{
			return true;
		}

		// Token: 0x06005034 RID: 20532 RVA: 0x009D54D4 File Offset: 0x009D36D4
		internal static bool z1qEND5BxKfJn28ui3rA()
		{
			return false;
		}

		// Token: 0x040059C4 RID: 22980
		internal UnityScript.Lang.Array $nArray$33703;

		// Token: 0x040059C5 RID: 22981
		internal Warthog $self_$33704;

		// Token: 0x02000DDF RID: 3551
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005035 RID: 20533 RVA: 0x009D54D8 File Offset: 0x009D36D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Warthog self_)
			{
				if (51416 - 96202 != -44786)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (94843 - 289383 == -194540)
					{
						base..ctor();
						if (177061 - 412847 != -235785)
						{
							this.$nArray$33701 = nArray;
							if (9274 - 109946 != -100671)
							{
								this.$self_$33702 = self_;
								if (128770 - 136400 == -7630)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005036 RID: 20534 RVA: 0x009D5594 File Offset: 0x009D3794
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7481 - 408537 != -401056)
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
						if (this.$self_$33702.fQecQODBdCb.actionState != "dead")
						{
							if (108673 - 130192 != -21518)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33702.fQecQODBdCb.isPlayer)
							{
								if (196512 - 62705 == 133808)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$33702.gameObject);
								if (198378 - 321471 == -123092)
								{
									continue;
								}
							}
							else if (this.$self_$33702.fQecQODBdCb.isMine)
							{
								if (1920 - 550825 != -548905)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33702.gameObject);
								if (109997 - 168173 == -58175)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (50416 - 366542 != -316126)
							{
								continue;
							}
							goto IL_4E6;
						}
						break;
					default:
						if (130983 - 288550 == -157566)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33702.fQecQODBdCb.actionState == "dead")
					{
						if (228377 - 306314 == -77937)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$33699 = (Vector3)this.$nArray$33701[0];
						if (208289 - 292856 != -84566)
						{
							this.$myDirection$33700 = (Vector3)this.$nArray$33701[1];
							if (134628 - 96004 != 38625)
							{
								this.$self_$33702.transform.position = this.$myPosition$33699;
								if (40161 - 150884 == -110723)
								{
									this.$self_$33702.transform.LookAt(this.$myPosition$33699 + this.$myDirection$33700);
									if (191809 - 399352 == -207543)
									{
										this.$self_$33702.fQecQODBdCb.hp = 0;
										if (293102 - 118656 == 174446)
										{
											this.$self_$33702.fQecQODBdCb.actionState = "dead";
											if (181350 - 327335 == -145985)
											{
												this.$self_$33702.fQecQODBdCb.actionTime = Time.time;
												if (250566 - 176400 == 74166)
												{
													this.$self_$33702.fQecQODBdCb.myCommand = "none";
													if (183850 - 451470 == -267620)
													{
														this.$self_$33702.fQecQODBdCb.vMovement = Vector3.zero;
														if (211456 - 144935 == 66521)
														{
															this.$self_$33702.fQecQODBdCb.moveSpeed = (float)0;
															if (19823 - 111374 == -91551)
															{
																this.$self_$33702.animation.Rewind();
																if (292065 - 441221 == -149156)
																{
																	this.$self_$33702.animation.Play("ko");
																	if (224862 - 342638 == -117776)
																	{
																		this.$self_$33702.animation.wrapMode = WrapMode.Once;
																		if (170178 - 148223 != 21956)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				goto IL_45E;
																			}
																			if (155000 - 400492 != -245491)
																			{
																				if (this.$self_$33702.ko_vc)
																				{
																					if (208228 - 53238 != 154991)
																					{
																						this.$self_$33702.audio.PlayOneShot(this.$self_$33702.ko_vc);
																						if (170102 - 380971 == -210869)
																						{
																							goto IL_B9;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find ko voice");
																					if (5337 - 394579 != -389241)
																					{
																						goto Block_5;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_4E6;
				IL_B9:
				Block_5:
				IL_45E:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_31:
				IL_4E6:
				return false;
			}

			// Token: 0x06005037 RID: 20535 RVA: 0x009D5A9C File Offset: 0x009D3C9C
			internal static bool xlWT2u5Bgh2NNFWEBDUy()
			{
				return true;
			}

			// Token: 0x06005038 RID: 20536 RVA: 0x009D5AA0 File Offset: 0x009D3CA0
			internal static bool VQYM3i5BfOWL0j2wusLU()
			{
				return false;
			}

			// Token: 0x040059C6 RID: 22982
			internal Vector3 $myPosition$33699;

			// Token: 0x040059C7 RID: 22983
			internal Vector3 $myDirection$33700;

			// Token: 0x040059C8 RID: 22984
			internal UnityScript.Lang.Array $nArray$33701;

			// Token: 0x040059C9 RID: 22985
			internal Warthog $self_$33702;
		}
	}
}
