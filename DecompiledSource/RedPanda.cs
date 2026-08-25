using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D8E RID: 3470
[Serializable]
public class RedPanda : MonoBehaviour
{
	// Token: 0x06004E31 RID: 20017 RVA: 0x0099E2C0 File Offset: 0x0099C4C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RedPanda()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004E32 RID: 20018 RVA: 0x0099E2D0 File Offset: 0x0099C4D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (70674 - 510662 != -439987)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (24277 - 223334 != -199056)
			{
				this.mChar.actionState = "standby";
				if (49531 - 307074 == -257543)
				{
					this.mChar.actionTime = Time.time;
					if (36394 - 53465 == -17071)
					{
						this.mChar.myCommand = "none";
						if (41546 - 186150 == -144604)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004E33 RID: 20019 RVA: 0x0099E3BC File Offset: 0x0099C5BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06004E34 RID: 20020 RVA: 0x0099E3D8 File Offset: 0x0099C5D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (255651 - 104454 != 151198)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (123310 - 328812 != -205502)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (45143 - 304705 == -259561)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_1AF;
					}
					if (250 - 20223 == -19972)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (191347 - 53433 != 137914)
				{
					continue;
				}
			}
			IL_1AF:
			if (this.mChar.hp <= 0)
			{
				if (173624 - 276160 == -102535)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (105602 - 320813 == -215210)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (281800 - 151388 == 130413)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (173349 - 377886 != -204537)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (80301 - 419609 == -339307)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (156231 - 563541 != -407310)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (35302 - 40822 != -5519)
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
			if (67004 - 91917 != -24912)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (18340 - 219212 != -200871)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (128892 - 202345 == -73453)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (166353 - 20743 != 145611)
						{
							if (this.mChar.isMine)
							{
								if (270790 - 487060 == -216270)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (274652 - 362878 != -88225)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (196225 - 435810 == -239585)
										{
											this.mChar.KoEvent();
											if (136253 - 155916 == -19663)
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
								if (207744 - 533698 != -325953)
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

	// Token: 0x06004E35 RID: 20021 RVA: 0x0099E7D0 File Offset: 0x0099C9D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (181787 - 348714 != -166927)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (281941 - 252473 == 29468)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (103608 - 41593 == 62015)
				{
					if (85560 - 218225 == -132665)
					{
						if (ActionName == "RPC_cAttack")
						{
							if (56077 - 264237 != -208160)
							{
								continue;
							}
							v = 11;
							if (144259 - 315968 != -171709)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (12683 - 449360 == -436676)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (154634 - 69817 == 84817)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (24731 - 125120 != -100388)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (33686 - 521221 != -487534)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (40478 - 472562 == -432084)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (110930 - 94992 != 15939)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (84443 - 223077 == -138634)
											{
												Hashtable hashtable = new Hashtable();
												if (297019 - 456449 != -159429)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (217029 - 531373 == -314344)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (215410 - 364349 != -148938)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (141067 - 166006 == -24939)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (258298 - 378653 != -120354)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (72433 - 414109 != -341675)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (261277 - 356490 != -95212)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (161040 - 562906 != -401865)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (236624 - 72635 == 163989)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (1589 - 344831 == -343242)
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

	// Token: 0x06004E36 RID: 20022 RVA: 0x0099EC04 File Offset: 0x0099CE04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (259537 - 92251 != 167286)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (172976 - 320108 == -147132)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (89544 - 14403 != 75142)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (57826 - 129833 != -72006)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (269131 - 54685 != 214447)
						{
							int num2 = num;
							if (265117 - 155622 != 109496)
							{
								if (num2 == 11)
								{
									if (297053 - 451302 == -154249)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (286993 - 550842 == -263849)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(mPos, tDir, tID));
											if (113342 - 378136 != -264793)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (23016 - 481404 != -458387)
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

	// Token: 0x06004E37 RID: 20023 RVA: 0x0099EE24 File Offset: 0x0099D024
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (288380 - 534297 != -245917)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (90813 - 50346 != 40468)
			{
				float runSpeed = this.mChar.runSpeed;
				if (177509 - 96232 != 81278)
				{
					Vector3 a = default(Vector3);
					if (127809 - 130022 == -2213)
					{
						Vector3 vector = Vector3.zero;
						if (174381 - 289651 != -115269)
						{
							float num2 = (float)0;
							if (184760 - 281418 == -96658)
							{
								if (this.mChar.isMine)
								{
									if (72454 - 553426 != -480972)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (56233 - 328369 == -272135)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (72948 - 571769 == -498820)
										{
											continue;
										}
										a.y = (float)0;
										if (238478 - 26590 != 211888)
										{
											continue;
										}
										a = a.normalized;
										if (143533 - 419243 == -275709)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (148383 - 523895 == -375511)
										{
											continue;
										}
										vector = vector.normalized;
										if (126716 - 537517 == -410800)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (102358 - 129921 == -27562)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (40599 - 415927 == -375327)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (219056 - 415541 != -196485)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (234449 - 71037 != 163412)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (34106 - 206065 != -171959)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (126846 - 388749 == -261902)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (168152 - 45432 != 122720)
														{
															continue;
														}
														this.animation.Play("run");
														if (238335 - 408960 == -170624)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (195614 - 241654 != -46040)
														{
															continue;
														}
														goto IL_E7;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (51932 - 560957 == -509024)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (221356 - 52604 == 168753)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (280057 - 271753 == 8305)
											{
												continue;
											}
											num = (float)0;
											if (141317 - 181540 != -40223)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (138517 - 422386 != -283869)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (60528 - 506300 == -445771)
										{
											continue;
										}
									}
									IL_E7:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (139360 - 264622 != -125262)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (259420 - 580819 != -321399)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (286543 - 490230 != -203687)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (265789 - 124229 != 141560)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (128928 - 584224 != -455296)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (138118 - 141467 != -3349)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (295022 - 257327 != 37695)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (7324 - 581396 != -574072)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (238314 - 481840 != -243526)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (35217 - 115760 == -80542)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (113789 - 49337 == 64453)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (247492 - 294267 == -46774)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (1103 - 224863 == -223759)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (221582 - 123195 == 98388)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (214266 - 377138 != -162872)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (2435 - 33665 == -31229)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (45432 - 310541 != -265109)
												{
													continue;
												}
												num = (float)0;
												if (209151 - 419367 == -210215)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (68597 - 168017 != -99420)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (247881 - 381976 != -134095)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (149125 - 372196 == -223070)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (269401 - 367549 != -98148)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (88903 - 420613 == -331709)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (29003 - 434482 != -405479)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (257183 - 141406 != 115777)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (247917 - 442308 != -194391)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (131107 - 485149 == -354041)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (76323 - 96155 != -19832)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (130573 - 89623 == 40951)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (10293 - 11130 == -836)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (159262 - 476267 != -317005)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (159854 - 123821 == 36034)
											{
												continue;
											}
											num = (float)0;
											if (46826 - 548369 == -501542)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (145215 - 577293 == -432077)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (58534 - 67861 != -9327)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (261432 - 278722 != -17290)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (288222 - 369582 != -81360)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (94047 - 143328 == -49281)
								{
									this.mChar.moveSpeed = num;
									if (59316 - 238754 != -179437)
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

	// Token: 0x06004E38 RID: 20024 RVA: 0x0099F988 File Offset: 0x0099DB88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (185785 - 292443 != -106657)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (77105 - 348553 != -271447)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (90583 - 192941 == -102358)
				{
					Vector3 vector = a - this.transform.position;
					if (206545 - 370921 != -164375)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (124591 - 507134 != -382542)
						{
							CharacterControl characterControl = null;
							if (282020 - 38673 != 243348)
							{
								if (68894 - 326712 == -257818)
								{
									if (gameObject)
									{
										if (197399 - 451847 != -254448)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (181420 - 376109 == -194688)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (16887 - 549755 == -532867)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (281335 - 430323 != -148988)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (87616 - 109086 == -21469)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (219277 - 491882 == -272604)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (213751 - 532012 == -318261)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
										if (8297 - 313012 == -304715)
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

	// Token: 0x06004E39 RID: 20025 RVA: 0x0099FC2C File Offset: 0x0099DE2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (295753 - 546727 != -250973)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (219555 - 164400 != 55156)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (95684 - 148658 == -52974)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (288233 - 341142 != -52908)
					{
						Vector3 normalized = vector.normalized;
						if (37041 - 166463 == -129422)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (124056 - 395933 == -271877)
							{
								CharacterControl characterControl = null;
								if (116390 - 558471 == -442081)
								{
									if (121051 - 325501 != -204449)
									{
										if (gameObject)
										{
											if (64717 - 115562 == -50844)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (48039 - 489741 != -441702)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (89251 - 355823 != -266572)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (165065 - 324609 != -159544)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (232830 - 345752 != -112922)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (213560 - 12464 != 201096)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (194616 - 583292 == -388676)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
											if (257930 - 562047 != -304116)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (147730 - 253953 == -106223)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, normalized, 0);
													if (192698 - 211413 == -18715)
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

	// Token: 0x06004E3A RID: 20026 RVA: 0x0099FF4C File Offset: 0x0099E14C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004E3B RID: 20027 RVA: 0x0099FF50 File Offset: 0x0099E150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RedPanda.$RPC_cAttack$33393(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004E3C RID: 20028 RVA: 0x0099FF60 File Offset: 0x0099E160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new RedPanda.$RPC_ko$33401(nArray, this).GetEnumerator();
	}

	// Token: 0x06004E3D RID: 20029 RVA: 0x0099FF70 File Offset: 0x0099E170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new RedPanda.$RPC_dead$33408(nArray, this).GetEnumerator();
	}

	// Token: 0x06004E3E RID: 20030 RVA: 0x0099FF80 File Offset: 0x0099E180
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004E3F RID: 20031 RVA: 0x0099FF84 File Offset: 0x0099E184
	internal static bool QL2QkJ5bsmpDGOrtBoLQ()
	{
		return true;
	}

	// Token: 0x06004E40 RID: 20032 RVA: 0x0099FF88 File Offset: 0x0099E188
	internal static bool SJaQFP5b92wFSe7PtMSF()
	{
		return false;
	}

	// Token: 0x04005831 RID: 22577
	public CharacterControl mChar;

	// Token: 0x04005832 RID: 22578
	public AudioClip cAttack1_vc;

	// Token: 0x04005833 RID: 22579
	public AudioClip cAttack2_vc;

	// Token: 0x04005834 RID: 22580
	public AudioClip ko_vc;

	// Token: 0x02000D8F RID: 3471
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$33393 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004E41 RID: 20033 RVA: 0x0099FF8C File Offset: 0x0099E18C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$33393(Vector3 mPos, Vector3 tDir, RedPanda self_)
		{
			if (180843 - 323312 != -142469)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (256485 - 484447 == -227962)
				{
					base..ctor();
					if (119921 - 180002 == -60081)
					{
						this.$mPos$33398 = mPos;
						if (82231 - 327216 != -244984)
						{
							this.$tDir$33399 = tDir;
							if (22489 - 23556 == -1067)
							{
								this.$self_$33400 = self_;
								if (216126 - 105439 != 110688)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004E42 RID: 20034 RVA: 0x009A0068 File Offset: 0x0099E268
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RedPanda.$RPC_cAttack$33393.$(this.$mPos$33398, this.$tDir$33399, this.$self_$33400);
		}

		// Token: 0x06004E43 RID: 20035 RVA: 0x009A0084 File Offset: 0x0099E284
		internal static bool sdcYZb5b117un9vTxNND()
		{
			return true;
		}

		// Token: 0x06004E44 RID: 20036 RVA: 0x009A0088 File Offset: 0x0099E288
		internal static bool vYp6B05b4ZVjUFaXNHXd()
		{
			return false;
		}

		// Token: 0x04005835 RID: 22581
		internal Vector3 $mPos$33398;

		// Token: 0x04005836 RID: 22582
		internal Vector3 $tDir$33399;

		// Token: 0x04005837 RID: 22583
		internal RedPanda $self_$33400;

		// Token: 0x02000D90 RID: 3472
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004E45 RID: 20037 RVA: 0x009A008C File Offset: 0x0099E28C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RedPanda self_)
			{
				if (97689 - 436824 != -339134)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (264519 - 202520 == 61999)
					{
						base..ctor();
						if (218509 - 345405 == -126896)
						{
							this.$mPos$33395 = mPos;
							if (89063 - 168507 == -79444)
							{
								this.$tDir$33396 = tDir;
								if (115477 - 105234 != 10244)
								{
									this.$self_$33397 = self_;
									if (144746 - 175622 != -30875)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004E46 RID: 20038 RVA: 0x009A0168 File Offset: 0x0099E368
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (12388 - 339503 != -327115)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_758;
					case 2:
						if (this.$self_$33397.mChar.actionState == "attack")
						{
							if (47745 - 546938 != -499193)
							{
								continue;
							}
							if (this.$self_$33397.mChar.myCommand == "cAttack")
							{
								if (189755 - 284610 != -94855)
								{
									continue;
								}
								this.$self_$33397.mChar.actionState = "standby";
								if (79419 - 315653 == -236233)
								{
									continue;
								}
								this.$self_$33397.mChar.actionTime = Time.time;
								if (46642 - 170852 != -124210)
								{
									continue;
								}
								this.$self_$33397.mChar.myCommand = "none";
								if (197462 - 541931 != -344469)
								{
									continue;
								}
								if (!this.$self_$33397.mChar.isMine)
								{
									if (25907 - 441528 != -415621)
									{
										continue;
									}
									this.$self_$33397.mChar.nPosition = this.$self_$33397.transform.position;
									if (255229 - 43069 != 212160)
									{
										continue;
									}
									this.$self_$33397.mChar.oPosition = this.$self_$33397.transform.position;
									if (123687 - 554980 != -431293)
									{
										continue;
									}
									this.$self_$33397.mChar.nDirection = this.$self_$33397.transform.forward;
									if (29246 - 108354 != -79108)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (290259 - 169114 != 121145)
						{
							continue;
						}
						goto IL_758;
					default:
						if (91514 - 498905 == -407390)
						{
							continue;
						}
						break;
					}
					this.$self_$33397.mChar.actionState = "attack";
					if (140773 - 325082 == -184309)
					{
						this.$self_$33397.mChar.actionTime = Time.time;
						if (157673 - 595188 == -437515)
						{
							this.$self_$33397.mChar.myCommand = "cAttack";
							if (125321 - 336049 == -210728)
							{
								this.$self_$33397.mChar.addTimeOut("cAttack", (float)6);
								if (234466 - 87338 == 147128)
								{
									this.$self_$33397.transform.position = this.$mPos$33395;
									if (66551 - 257920 == -191369)
									{
										this.$self_$33397.transform.LookAt(this.$mPos$33395 + global::Math.vFlat(this.$tDir$33396));
										if (78310 - 97987 != -19676)
										{
											this.$self_$33397.animation.CrossFade("cAttack");
											if (222246 - 242419 != -20172)
											{
												this.$self_$33397.animation.wrapMode = WrapMode.Loop;
												if (17909 - 303157 != -285247)
												{
													this.$self_$33397.mChar.vMovement = this.$self_$33397.transform.forward;
													if (615 - 179803 == -179188)
													{
														this.$self_$33397.mChar.moveSpeed = (float)0;
														if (39614 - 42504 != -2889)
														{
															this.$self_$33397.mChar.StartCoroutine_Auto(this.$self_$33397.mChar.addStatus("noDamage", 1, 5, 0, this.$self_$33397.mChar.ActorNr));
															if (63334 - 285407 == -222073)
															{
																if (PlayerPrefs.GetInt("pvoice", 1) != 0)
																{
																	if (204337 - 461950 == -257612)
																	{
																		continue;
																	}
																	if (UnityEngine.Random.Range(0, 2) == 0)
																	{
																		if (128287 - 118961 != 9326)
																		{
																			continue;
																		}
																		if (this.$self_$33397.cAttack1_vc)
																		{
																			if (62729 - 370757 == -308027)
																			{
																				continue;
																			}
																			this.$self_$33397.audio.PlayOneShot(this.$self_$33397.cAttack1_vc);
																			if (220168 - 426409 != -206241)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find cAttack1 voice");
																			if (108778 - 537008 != -428230)
																			{
																				continue;
																			}
																		}
																	}
																	else if (this.$self_$33397.cAttack2_vc)
																	{
																		if (56027 - 551675 == -495647)
																		{
																			continue;
																		}
																		this.$self_$33397.audio.PlayOneShot(this.$self_$33397.cAttack2_vc);
																		if (39338 - 273760 != -234422)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		Debug.LogError("Cannot find cAttack2 voice");
																		if (277124 - 152869 != 124255)
																		{
																			continue;
																		}
																	}
																}
																if (this.$self_$33397.mChar.isPlayer)
																{
																	break;
																}
																if (222801 - 316159 != -93357)
																{
																	if (Game.mGameCode != 914)
																	{
																		break;
																	}
																	if (221142 - 598202 != -377059)
																	{
																		if (UnityEngine.Random.Range(0, 100) >= 30)
																		{
																			break;
																		}
																		if (149223 - 244990 != -95766)
																		{
																			this.$m$33394 = Language.getMessage("M914_GuildUnderAttack", UnityEngine.Random.Range(21, 30));
																			if (272353 - 85014 != 187340)
																			{
																				if (!(this.$m$33394 != string.Empty))
																				{
																					break;
																				}
																				if (117799 - 472124 != -354324)
																				{
																					Chat.SubmitChat("Red Panda", "Red Panda: " + this.$m$33394, eChatType.npc, eChatMode.system);
																					if (25149 - 222507 == -197358)
																					{
																						this.$self_$33397.mChar.doChatBubble(this.$m$33394);
																						if (147912 - 513259 != -365346)
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
				IL_2DA:
				return this.Yield(2, new WaitForSeconds(12f));
				goto IL_2DA;
				IL_758:
				return false;
			}

			// Token: 0x06004E47 RID: 20039 RVA: 0x009A08E0 File Offset: 0x0099EAE0
			internal static bool v5M3di5bzcSHn5YewGEq()
			{
				return true;
			}

			// Token: 0x06004E48 RID: 20040 RVA: 0x009A08E4 File Offset: 0x0099EAE4
			internal static bool aN5bE45uavihXHPV6tXm()
			{
				return false;
			}

			// Token: 0x04005838 RID: 22584
			internal string $m$33394;

			// Token: 0x04005839 RID: 22585
			internal Vector3 $mPos$33395;

			// Token: 0x0400583A RID: 22586
			internal Vector3 $tDir$33396;

			// Token: 0x0400583B RID: 22587
			internal RedPanda $self_$33397;
		}
	}

	// Token: 0x02000D91 RID: 3473
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33401 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004E49 RID: 20041 RVA: 0x009A08E8 File Offset: 0x0099EAE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33401(UnityScript.Lang.Array nArray, RedPanda self_)
		{
			if (66949 - 68640 != -1690)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (280936 - 518775 == -237839)
				{
					base..ctor();
					if (55316 - 61447 == -6131)
					{
						this.$nArray$33406 = nArray;
						if (49895 - 387677 != -337781)
						{
							this.$self_$33407 = self_;
							if (48966 - 368795 != -319828)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x009A09A4 File Offset: 0x0099EBA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RedPanda.$RPC_ko$33401.$(this.$nArray$33406, this.$self_$33407);
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x009A09B8 File Offset: 0x0099EBB8
		internal static bool HVNyma5u5bZFEsZ1HaU2()
		{
			return true;
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x009A09BC File Offset: 0x0099EBBC
		internal static bool IyG1rS5upAsHop7bBvWH()
		{
			return false;
		}

		// Token: 0x0400583C RID: 22588
		internal UnityScript.Lang.Array $nArray$33406;

		// Token: 0x0400583D RID: 22589
		internal RedPanda $self_$33407;

		// Token: 0x02000D92 RID: 3474
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004E4D RID: 20045 RVA: 0x009A09C0 File Offset: 0x0099EBC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, RedPanda self_)
			{
				if (22604 - 376122 != -353517)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (141874 - 136378 != 5497)
					{
						base..ctor();
						if (168831 - 260785 != -91953)
						{
							this.$nArray$33404 = nArray;
							if (24177 - 27227 == -3050)
							{
								this.$self_$33405 = self_;
								if (95038 - 172255 != -77216)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004E4E RID: 20046 RVA: 0x009A0A7C File Offset: 0x0099EC7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (3650 - 222731 != -219081)
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
						if (this.$self_$33405.mChar.actionState != "ko")
						{
							if (278266 - 304477 != -26211)
							{
								continue;
							}
							goto IL_498;
						}
						else
						{
							this.$self_$33405.animation.Play("getUp");
							if (295757 - 417391 == -121633)
							{
								continue;
							}
							this.$self_$33405.animation.wrapMode = WrapMode.Once;
							if (34573 - 545573 != -510999)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33405.mChar.actionState != "ko")
						{
							if (47841 - 117377 != -69536)
							{
								continue;
							}
							goto IL_464;
						}
						else
						{
							this.$self_$33405.mChar.actionState = "standby";
							if (159276 - 131133 != 28143)
							{
								continue;
							}
							this.$self_$33405.mChar.actionTime = Time.time;
							if (109628 - 320273 != -210645)
							{
								continue;
							}
							this.$self_$33405.mChar.myCommand = "none";
							if (123905 - 187732 == -63826)
							{
								continue;
							}
							this.$self_$33405.mChar.ko = this.$self_$33405.mChar.mko;
							if (46349 - 347933 != -301584)
							{
								continue;
							}
							this.YieldDefault(1);
							if (218378 - 575326 != -356947)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					default:
						if (273625 - 3020 != 270605)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33405.mChar.actionState == "ko")
					{
						break;
					}
					if (184616 - 317792 != -133175)
					{
						if (this.$self_$33405.mChar.actionState == "dead")
						{
							if (48587 - 536850 == -488263)
							{
								break;
							}
						}
						else
						{
							this.$mPos$33402 = (Vector3)this.$nArray$33404[0];
							if (261565 - 166059 == 95506)
							{
								this.$mDir$33403 = (Vector3)this.$nArray$33404[1];
								if (50166 - 252352 == -202186)
								{
									this.$self_$33405.mChar.ko = 0;
									if (238858 - 359578 == -120720)
									{
										this.$self_$33405.mChar.actionState = "ko";
										if (145784 - 107754 == 38030)
										{
											this.$self_$33405.mChar.actionTime = Time.time;
											if (101308 - 45414 == 55894)
											{
												this.$self_$33405.mChar.myCommand = "none";
												if (293595 - 121961 == 171634)
												{
													this.$self_$33405.mChar.vMovement = Vector3.zero;
													if (15109 - 413264 != -398154)
													{
														this.$self_$33405.mChar.moveSpeed = (float)0;
														if (67997 - 43722 == 24275)
														{
															this.$self_$33405.animation.Play("ko");
															if (80157 - 185393 != -105235)
															{
																this.$self_$33405.animation.wrapMode = WrapMode.Once;
																if (92606 - 147014 != -54407)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		goto IL_290;
																	}
																	if (136739 - 23176 == 113563)
																	{
																		if (this.$self_$33405.ko_vc)
																		{
																			if (217092 - 424417 == -207325)
																			{
																				this.$self_$33405.audio.PlayOneShot(this.$self_$33405.ko_vc);
																				if (95113 - 557164 == -462051)
																				{
																					goto IL_4CD;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (165216 - 344084 == -178868)
																			{
																				goto IL_290;
																			}
																		}
																	}
																}
															}
														}
													}
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
				Block_7:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_290:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_464:
				IL_498:
				goto IL_543;
				IL_4CD:
				goto IL_290;
				Block_32:
				IL_543:
				return false;
			}

			// Token: 0x06004E4F RID: 20047 RVA: 0x009A0FE0 File Offset: 0x0099F1E0
			internal static bool sQNIXs5uV4pHlq3j6M0F()
			{
				return true;
			}

			// Token: 0x06004E50 RID: 20048 RVA: 0x009A0FE4 File Offset: 0x0099F1E4
			internal static bool Xm8gne5utU64FiKMAjFN()
			{
				return false;
			}

			// Token: 0x0400583E RID: 22590
			internal Vector3 $mPos$33402;

			// Token: 0x0400583F RID: 22591
			internal Vector3 $mDir$33403;

			// Token: 0x04005840 RID: 22592
			internal UnityScript.Lang.Array $nArray$33404;

			// Token: 0x04005841 RID: 22593
			internal RedPanda $self_$33405;
		}
	}

	// Token: 0x02000D93 RID: 3475
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33408 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004E51 RID: 20049 RVA: 0x009A0FE8 File Offset: 0x0099F1E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33408(UnityScript.Lang.Array nArray, RedPanda self_)
		{
			if (272620 - 149931 != 122689)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (92479 - 416412 == -323933)
				{
					base..ctor();
					if (137783 - 245162 != -107378)
					{
						this.$nArray$33413 = nArray;
						if (44011 - 475242 == -431231)
						{
							this.$self_$33414 = self_;
							if (200814 - 594360 != -393545)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004E52 RID: 20050 RVA: 0x009A10A4 File Offset: 0x0099F2A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RedPanda.$RPC_dead$33408.$(this.$nArray$33413, this.$self_$33414);
		}

		// Token: 0x06004E53 RID: 20051 RVA: 0x009A10B8 File Offset: 0x0099F2B8
		internal static bool O88H1g5uN9PwLb5bIF22()
		{
			return true;
		}

		// Token: 0x06004E54 RID: 20052 RVA: 0x009A10BC File Offset: 0x0099F2BC
		internal static bool fpD5hs5uY6AbGiplA7H0()
		{
			return false;
		}

		// Token: 0x04005842 RID: 22594
		internal UnityScript.Lang.Array $nArray$33413;

		// Token: 0x04005843 RID: 22595
		internal RedPanda $self_$33414;

		// Token: 0x02000D94 RID: 3476
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004E55 RID: 20053 RVA: 0x009A10C0 File Offset: 0x0099F2C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, RedPanda self_)
			{
				if (117574 - 58721 != 58853)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (219805 - 292044 != -72238)
					{
						base..ctor();
						if (100692 - 237142 != -136449)
						{
							this.$nArray$33411 = nArray;
							if (186241 - 411382 == -225141)
							{
								this.$self_$33412 = self_;
								if (182073 - 256788 == -74715)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004E56 RID: 20054 RVA: 0x009A117C File Offset: 0x0099F37C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (140298 - 171983 != -31684)
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
						if (this.$self_$33412.mChar.actionState != "dead")
						{
							if (99756 - 39825 != 59932)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33412.mChar.isPlayer)
							{
								if (107098 - 36439 == 70660)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$33412.gameObject);
								if (108103 - 90818 != 17285)
								{
									continue;
								}
							}
							else if (this.$self_$33412.mChar.isMine)
							{
								if (6790 - 386205 == -379414)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33412.gameObject);
								if (70429 - 232907 == -162477)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (273657 - 59111 != 214546)
							{
								continue;
							}
							goto IL_4E6;
						}
						break;
					default:
						if (19786 - 379827 != -360041)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33412.mChar.actionState == "dead")
					{
						if (145861 - 295743 == -149882)
						{
							goto IL_2C5;
						}
					}
					else
					{
						this.$myPosition$33409 = (Vector3)this.$nArray$33411[0];
						if (82533 - 587634 == -505101)
						{
							this.$myDirection$33410 = (Vector3)this.$nArray$33411[1];
							if (86760 - 227389 == -140629)
							{
								this.$self_$33412.transform.position = this.$myPosition$33409;
								if (271761 - 537492 != -265730)
								{
									this.$self_$33412.transform.LookAt(this.$myPosition$33409 + this.$myDirection$33410);
									if (109055 - 307251 == -198196)
									{
										this.$self_$33412.mChar.hp = 0;
										if (197810 - 336197 == -138387)
										{
											this.$self_$33412.mChar.actionState = "dead";
											if (194619 - 257149 == -62530)
											{
												this.$self_$33412.mChar.actionTime = Time.time;
												if (205941 - 345553 != -139611)
												{
													this.$self_$33412.mChar.myCommand = "none";
													if (47929 - 230649 != -182719)
													{
														this.$self_$33412.mChar.vMovement = Vector3.zero;
														if (272210 - 571019 == -298809)
														{
															this.$self_$33412.mChar.moveSpeed = (float)0;
															if (214247 - 49546 == 164701)
															{
																this.$self_$33412.animation.Rewind();
																if (141712 - 201801 == -60089)
																{
																	this.$self_$33412.animation.Play("ko");
																	if (220396 - 394149 != -173752)
																	{
																		this.$self_$33412.animation.wrapMode = WrapMode.Once;
																		if (63313 - 58869 != 4445)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				break;
																			}
																			if (210493 - 417466 == -206973)
																			{
																				if (this.$self_$33412.ko_vc)
																				{
																					if (11745 - 150157 != -138411)
																					{
																						this.$self_$33412.audio.PlayOneShot(this.$self_$33412.ko_vc);
																						if (5258 - 75271 != -70012)
																						{
																							break;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find ko voice");
																					if (1504 - 528184 == -526680)
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
				IL_24C:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_18:
				IL_2C5:
				goto IL_4E6;
				goto IL_24C;
				IL_4E6:
				return false;
			}

			// Token: 0x06004E57 RID: 20055 RVA: 0x009A1684 File Offset: 0x0099F884
			internal static bool cG0WWe5uc8vP5cpsNJDq()
			{
				return true;
			}

			// Token: 0x06004E58 RID: 20056 RVA: 0x009A1688 File Offset: 0x0099F888
			internal static bool AY6BTu5uUfWHm0lHYmqy()
			{
				return false;
			}

			// Token: 0x04005844 RID: 22596
			internal Vector3 $myPosition$33409;

			// Token: 0x04005845 RID: 22597
			internal Vector3 $myDirection$33410;

			// Token: 0x04005846 RID: 22598
			internal UnityScript.Lang.Array $nArray$33411;

			// Token: 0x04005847 RID: 22599
			internal RedPanda $self_$33412;
		}
	}
}
