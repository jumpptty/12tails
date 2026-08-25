using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000255 RID: 597
[Serializable]
public class XmasBug : MonoBehaviour
{
	// Token: 0x06000D9A RID: 3482 RVA: 0x0015A928 File Offset: 0x00158B28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public XmasBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000D9B RID: 3483 RVA: 0x0015A938 File Offset: 0x00158B38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (73985 - 167628 != -93643)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (63125 - 56335 == 6790)
			{
				this.mChar.actionState = "standby";
				if (185080 - 167330 != 17751)
				{
					this.mChar.actionTime = Time.time;
					if (156028 - 231425 != -75396)
					{
						this.mChar.myCommand = "none";
						if (270591 - 161628 != 108964)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x0015AA24 File Offset: 0x00158C24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x0015AA40 File Offset: 0x00158C40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (214802 - 496250 != -281448)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (278361 - 132953 == 145409)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (75305 - 539036 == -463730)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_2EF;
					}
					if (39335 - 275861 == -236525)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (26580 - 415953 == -389372)
				{
					continue;
				}
			}
			IL_2EF:
			if (this.mChar.hp <= 0)
			{
				if (189953 - 464485 == -274531)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (251787 - 475495 != -223708)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (259007 - 499102 == -240094)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (162504 - 264709 == -102204)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (79970 - 345820 == -265849)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (15205 - 388302 != -373096)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (15965 - 484067 != -468101)
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
			if (135406 - 301689 != -166282)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (5618 - 97830 != -92211)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (49248 - 274897 != -225648)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (36628 - 2122 == 34506)
						{
							if (this.mChar.isMine)
							{
								if (241468 - 518337 != -276868)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (84095 - 539055 == -454960)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (183067 - 458934 != -275866)
										{
											this.mChar.KoEvent();
											if (579 - 80378 == -79799)
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
								if (82670 - 417736 == -335066)
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

	// Token: 0x06000D9E RID: 3486 RVA: 0x0015AE38 File Offset: 0x00159038
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (6809 - 479835 != -473026)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (189427 - 507621 == -318194)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (102660 - 487526 == -384866)
				{
					if (225226 - 156599 == 68627)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (248015 - 373520 != -125505)
							{
								continue;
							}
							v = 1;
							if (84566 - 310337 == -225770)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (191620 - 384524 != -192904)
							{
								continue;
							}
							v = -1;
							if (297851 - 292589 == 5263)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_xmasSmash")
						{
							if (125373 - 455696 == -330322)
							{
								continue;
							}
							v = 2;
							if (287355 - 294758 == -7402)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_xmasShot")
						{
							if (51084 - 263238 != -212154)
							{
								continue;
							}
							v = 3;
							if (140463 - 541790 == -401326)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (263857 - 268894 == -5036)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (68143 - 371686 == -303543)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (210985 - 445953 != -234967)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (299811 - 57819 == 241992)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (161066 - 452280 == -291214)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (279303 - 554057 == -274754)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (205750 - 579446 == -373696)
											{
												Hashtable hashtable = new Hashtable();
												if (203240 - 350655 != -147414)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (125501 - 419355 == -293854)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (298502 - 197593 == 100909)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (87847 - 267357 == -179510)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (74476 - 451041 != -376564)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (112864 - 119484 != -6619)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (256188 - 466721 != -210532)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (267856 - 504095 != -236238)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (26977 - 229748 != -202770)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (15050 - 116379 != -101328)
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

	// Token: 0x06000D9F RID: 3487 RVA: 0x0015B34C File Offset: 0x0015954C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (16408 - 359596 != -343187)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (208592 - 442345 != -233752)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (103027 - 57337 != 45691)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (219792 - 431307 != -211514)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (274478 - 84045 != 190434)
						{
							int num3 = num;
							if (141652 - 202096 == -60444)
							{
								if (num3 == 1)
								{
									if (251729 - 407151 == -155422)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (185891 - 114972 != 70920)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (157886 - 68115 != 89772)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (77971 - 45468 != 32504)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (76735 - 177218 == -100483)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (103652 - 452096 != -348443)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (143288 - 435669 != -292380)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (30906 - 187474 != -156567)
										{
											this.StartCoroutine_Auto(this.RPC_xmasSmash(vector, vector2, num2));
											if (230388 - 83997 == 146391)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (93304 - 158418 == -65114)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (106628 - 525336 == -418708)
										{
											this.StartCoroutine_Auto(this.RPC_xmasShot(vector, vector2, num2));
											if (79690 - 574261 != -494570)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (141864 - 132206 != 9659)
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

	// Token: 0x06000DA0 RID: 3488 RVA: 0x0015B6D8 File Offset: 0x001598D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (254375 - 95776 != 158600)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (277521 - 446521 != -168999)
			{
				float runSpeed = this.mChar.runSpeed;
				if (174711 - 569515 != -394803)
				{
					Vector3 a = default(Vector3);
					if (143031 - 219054 != -76022)
					{
						Vector3 vector = Vector3.zero;
						if (192140 - 425207 != -233066)
						{
							float num2 = (float)0;
							if (200741 - 385433 != -184691)
							{
								if (this.mChar.isMine)
								{
									if (1135 - 484629 == -483493)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (75431 - 300701 != -225270)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (68799 - 319782 == -250982)
										{
											continue;
										}
										a.y = (float)0;
										if (61970 - 384686 == -322715)
										{
											continue;
										}
										a = a.normalized;
										if (184873 - 386386 != -201513)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (13926 - 311141 == -297214)
										{
											continue;
										}
										vector = vector.normalized;
										if (201443 - 419569 != -218126)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (67458 - 380471 == -313012)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (182504 - 90696 == 91809)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (266033 - 371582 == -105548)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (236721 - 126653 == 110069)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (287182 - 139882 != 147300)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (71837 - 428764 == -356926)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (212146 - 526872 != -314726)
														{
															continue;
														}
														this.animation.Play("run");
														if (148529 - 325242 != -176713)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (160254 - 2568 != 157687)
														{
															goto IL_416;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (282401 - 281871 != 530)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (229808 - 544508 != -314700)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (77467 - 199311 != -121844)
											{
												continue;
											}
											num = (float)0;
											if (290161 - 233516 == 56646)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (141015 - 208257 == -67241)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (170641 - 151806 == 18836)
										{
											continue;
										}
									}
									IL_416:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (78158 - 136901 != -58743)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (14624 - 520869 == -506244)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (51056 - 566321 != -515265)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (126649 - 481060 != -354411)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (53636 - 504178 == -450541)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (150149 - 312602 == -162452)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (106885 - 520790 != -413905)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (254171 - 97094 == 157078)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (250602 - 95125 == 155478)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (187985 - 418835 == -230849)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (299909 - 33322 == 266588)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (286848 - 247650 == 39199)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (272451 - 100772 != 171679)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (80540 - 158824 == -78283)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (243102 - 206430 != 36672)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (278062 - 416936 == -138873)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (287213 - 87322 == 199892)
												{
													continue;
												}
												num = (float)0;
												if (279857 - 408797 != -128940)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (88486 - 513857 != -425371)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (55688 - 273957 == -218268)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (186631 - 363014 == -176382)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (189037 - 104719 != 84318)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (205860 - 264005 != -58145)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (92598 - 428461 == -335862)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (250136 - 433166 != -183030)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (9225 - 173676 == -164450)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (293586 - 17731 == 275856)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (189370 - 253437 != -64067)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (163950 - 559678 != -395728)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (192944 - 46806 != 146138)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (123413 - 542303 != -418890)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (149120 - 353810 == -204689)
											{
												continue;
											}
											num = (float)0;
											if (44346 - 388639 == -344292)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (261778 - 168040 != 93738)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (68196 - 579863 == -511666)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (205227 - 63561 == 141667)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (109883 - 577899 != -468016)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (34561 - 229739 != -195177)
								{
									this.mChar.moveSpeed = num;
									if (266682 - 42102 != 224581)
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

	// Token: 0x06000DA1 RID: 3489 RVA: 0x0015C23C File Offset: 0x0015A43C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (235787 - 475119 != -239332)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (288778 - 363447 == -74669)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (104175 - 473556 == -369381)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (75118 - 117849 == -42731)
					{
						Vector3 vector2 = vector.normalized;
						if (40154 - 404861 == -364707)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (298150 - 457620 == -159470)
							{
								if (191184 - 144897 == 46287)
								{
									if (gameObject)
									{
										if (21847 - 351611 != -329764)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (77907 - 272403 == -194495)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (66476 - 383820 != -317344)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (215426 - 152904 == 62523)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (243121 - 517431 == -274310)
									{
										Vector3 vector3 = a - this.transform.position;
										if (154124 - 584481 != -430356)
										{
											if (vector3.sqrMagnitude < (float)25)
											{
												if (142206 - 519397 != -377190)
												{
													if (gameObject == this.gameObject)
													{
														if (144803 - 468857 == -324053)
														{
															continue;
														}
														vector2 = this.transform.forward;
														if (24930 - 546486 != -521556)
														{
															continue;
														}
													}
													this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector2, 0));
													if (287795 - 489825 != -202029)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (206481 - 550821 != -344339)
														{
															this.ActionEvent("RPC_nAttack", this.transform.position, vector2, 0);
															if (15283 - 95511 == -80228)
															{
																break;
															}
														}
													}
												}
											}
											else
											{
												this.StartCoroutine_Auto(this.RPC_xmasShot(this.transform.position, vector2, 0));
												if (73615 - 242515 == -168900)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (13584 - 434632 != -421047)
													{
														this.ActionEvent("RPC_xmasShot", this.transform.position, vector2, 0);
														if (28765 - 409908 != -381142)
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

	// Token: 0x06000DA2 RID: 3490 RVA: 0x0015C630 File Offset: 0x0015A830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (115859 - 145268 != -29409)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (73665 - 419523 == -345858)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (197719 - 271455 != -73735)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (103383 - 118310 != -14926)
					{
						Vector3 normalized = vector.normalized;
						if (109181 - 466162 == -356981)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (61600 - 113893 != -52292)
							{
								if (127285 - 524377 == -397092)
								{
									if (gameObject)
									{
										if (164704 - 33740 == 130965)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (141988 - 350358 == -208369)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (251117 - 527842 != -276725)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (67822 - 382479 != -314657)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("xmasSmash") != (float)0)
									{
										if (271987 - 490849 == -218862)
										{
											Camera.main.SendMessage("newGameMessage", "xmasSmash is not ready");
											if (53807 - 751 == 53056)
											{
												break;
											}
										}
									}
									else if (this.mChar.sp < 40)
									{
										if (172951 - 554782 == -381831)
										{
											Camera.main.SendMessage("newGameMessage", "Not enough sp : 30 sp required");
											if (164827 - 412829 != -248001)
											{
												break;
											}
										}
									}
									else
									{
										this.mChar.sp = this.mChar.sp - 40;
										if (188218 - 49126 == 139092)
										{
											this.StartCoroutine_Auto(this.RPC_xmasSmash(this.transform.position, this.transform.forward, 0));
											if (27353 - 189805 == -162452)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (47218 - 312413 == -265195)
												{
													this.ActionEvent("RPC_xmasSmash", this.transform.position, this.transform.forward, 0);
													if (93986 - 112341 != -18354)
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

	// Token: 0x06000DA3 RID: 3491 RVA: 0x0015C9C8 File Offset: 0x0015ABC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000DA4 RID: 3492 RVA: 0x0015C9CC File Offset: 0x0015ABCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new XmasBug.$RPC_nAttack$17592(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000DA5 RID: 3493 RVA: 0x0015C9DC File Offset: 0x0015ABDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x0015CA08 File Offset: 0x0015AC08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_xmasSmash(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new XmasBug.$RPC_xmasSmash$17604(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x0015CA18 File Offset: 0x0015AC18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_xmasShot(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new XmasBug.$RPC_xmasShot$17616(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x0015CA28 File Offset: 0x0015AC28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_xmasShot_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.xmasShot_hit)
		{
			UnityEngine.Object.Instantiate(this.xmasShot_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x0015CA54 File Offset: 0x0015AC54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new XmasBug.$RPC_ko$17631(nArray, this).GetEnumerator();
	}

	// Token: 0x06000DAA RID: 3498 RVA: 0x0015CA64 File Offset: 0x0015AC64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new XmasBug.$RPC_dead$17638(nArray, this).GetEnumerator();
	}

	// Token: 0x06000DAB RID: 3499 RVA: 0x0015CA74 File Offset: 0x0015AC74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000DAC RID: 3500 RVA: 0x0015CA78 File Offset: 0x0015AC78
	internal static bool H55CXEyHFAt0SmiYHiM()
	{
		return true;
	}

	// Token: 0x06000DAD RID: 3501 RVA: 0x0015CA7C File Offset: 0x0015AC7C
	internal static bool Yh3UtwyWPr0YvR5WBWU()
	{
		return false;
	}

	// Token: 0x04000BD3 RID: 3027
	public CharacterControl mChar;

	// Token: 0x04000BD4 RID: 3028
	public AudioClip nAttackFx;

	// Token: 0x04000BD5 RID: 3029
	public GameObject nAttack_hit;

	// Token: 0x04000BD6 RID: 3030
	public GameObject xmasSmash;

	// Token: 0x04000BD7 RID: 3031
	public AudioClip xmasSmashFx;

	// Token: 0x04000BD8 RID: 3032
	public GameObject xmasShot;

	// Token: 0x04000BD9 RID: 3033
	public AudioClip xmasShotFx;

	// Token: 0x04000BDA RID: 3034
	public GameObject xmasShot_hit;

	// Token: 0x02000256 RID: 598
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$17592 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000DAE RID: 3502 RVA: 0x0015CA80 File Offset: 0x0015AC80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$17592(Vector3 mPos, Vector3 tDir, XmasBug self_)
		{
			if (193921 - 221773 != -27852)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (116703 - 39747 != 76957)
				{
					base..ctor();
					if (291296 - 102454 == 188842)
					{
						this.$mPos$17601 = mPos;
						if (245715 - 446461 == -200746)
						{
							this.$tDir$17602 = tDir;
							if (40410 - 359080 != -318669)
							{
								this.$self_$17603 = self_;
								if (89447 - 414783 == -325336)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0015CB5C File Offset: 0x0015AD5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new XmasBug.$RPC_nAttack$17592.$(this.$mPos$17601, this.$tDir$17602, this.$self_$17603);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0015CB78 File Offset: 0x0015AD78
		internal static bool yVKE3RyAHeImsUQMTaG()
		{
			return true;
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0015CB7C File Offset: 0x0015AD7C
		internal static bool GiZPTNylk8B3vn3Avha()
		{
			return false;
		}

		// Token: 0x04000BDB RID: 3035
		internal Vector3 $mPos$17601;

		// Token: 0x04000BDC RID: 3036
		internal Vector3 $tDir$17602;

		// Token: 0x04000BDD RID: 3037
		internal XmasBug $self_$17603;

		// Token: 0x02000257 RID: 599
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000DB2 RID: 3506 RVA: 0x0015CB80 File Offset: 0x0015AD80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, XmasBug self_)
			{
				if (74516 - 306809 != -232293)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (125567 - 539096 == -413529)
					{
						base..ctor();
						if (207692 - 559303 != -351610)
						{
							this.$mPos$17598 = mPos;
							if (184865 - 573941 != -389075)
							{
								this.$tDir$17599 = tDir;
								if (82430 - 507549 != -425118)
								{
									this.$self_$17600 = self_;
									if (44069 - 515150 != -471080)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000DB3 RID: 3507 RVA: 0x0015CC5C File Offset: 0x0015AE5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (166380 - 576590 != -410209)
				{
				}
				for (;;)
				{
					IL_3CC:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_948;
					case 2:
						if (this.$self_$17600.mChar.actionState != "attack")
						{
							goto IL_5A5;
						}
						if (209321 - 111750 != 97571)
						{
							continue;
						}
						if (this.$self_$17600.mChar.myCommand != "nAttack")
						{
							if (109742 - 58936 != 50807)
							{
								goto Block_48;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17600.nAttackFx)
							{
								goto IL_344;
							}
							if (143176 - 27427 == 115750)
							{
								continue;
							}
							this.$self_$17600.audio.PlayOneShot(this.$self_$17600.nAttackFx);
							if (203254 - 443086 != -239831)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17600.mChar.actionState != "attack")
						{
							goto IL_78B;
						}
						if (28363 - 135496 == -107132)
						{
							continue;
						}
						if (this.$self_$17600.mChar.myCommand != "nAttack")
						{
							if (150483 - 132011 != 18472)
							{
								continue;
							}
							goto IL_78B;
						}
						else
						{
							this.$hitLayer$17593 = 130816 - (1 << this.$self_$17600.gameObject.layer);
							if (40117 - 558621 == -518503)
							{
								continue;
							}
							this.$hitList$17594 = null;
							if (8290 - 590385 == -582094)
							{
								continue;
							}
							this.$hitPos$17595 = default(Vector3);
							if (230646 - 213799 != 16847)
							{
								continue;
							}
							if (!this.$self_$17600.mChar.isMine)
							{
								goto IL_201;
							}
							if (282934 - 446514 != -163580)
							{
								continue;
							}
							this.$hitList$17594 = Damage.FindRecTarget(this.$self_$17600.transform.position, this.$self_$17600.transform.forward, (float)4, (float)4 * this.$self_$17600.mChar.rangeMod, (float)5 * this.$self_$17600.mChar.rangeMod, (float)3 * this.$self_$17600.mChar.rangeMod, this.$hitLayer$17593);
							if (232137 - 427976 == -195838)
							{
								continue;
							}
							this.$$iterator$10047$17597 = UnityRuntimeServices.GetEnumerator(this.$hitList$17594);
							if (247152 - 403953 == -156800)
							{
								continue;
							}
							while (this.$$iterator$10047$17597.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10047$17597.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17596 = (GameObject)obj2;
								if (160299 - 227621 != -67322)
								{
									goto IL_3CC;
								}
								if (this.$self_$17600.mChar.hit(1, this.$hitObject$17596, this.$self_$17600.mChar.atk, 1, 0, this.$self_$17600.transform.forward) != 0)
								{
									if (47473 - 561241 == -513767)
									{
										goto IL_3CC;
									}
									this.$hitPos$17595 = this.$hitObject$17596.collider.ClosestPointOnBounds(this.$self_$17600.transform.position + this.$self_$17600.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (206309 - 332644 == -126334)
									{
										goto IL_3CC;
									}
									UnityRuntimeServices.Update(this.$$iterator$10047$17597, this.$hitObject$17596);
									if (233806 - 41580 != 192226)
									{
										goto IL_3CC;
									}
									this.$self_$17600.mChar.sp = this.$self_$17600.mChar.sp + 1;
									if (150133 - 212465 != -62332)
									{
										goto IL_3CC;
									}
									this.$self_$17600.RPC_nAttack_hit(this.$hitPos$17595, this.$self_$17600.transform.forward, 0);
									if (193153 - 478827 != -285674)
									{
										goto IL_3CC;
									}
									this.$self_$17600.ActionEvent("RPC_nAttack_hit", this.$hitPos$17595, this.$self_$17600.transform.forward, 0);
									if (84135 - 290402 != -206267)
									{
										goto IL_3CC;
									}
								}
							}
							if (117634 - 298256 != -180622)
							{
								continue;
							}
							goto IL_201;
						}
						break;
					case 4:
						if (this.$self_$17600.mChar.actionState == "attack")
						{
							if (12568 - 233128 == -220559)
							{
								continue;
							}
							if (this.$self_$17600.mChar.myCommand == "nAttack")
							{
								if (165653 - 174204 == -8550)
								{
									continue;
								}
								this.$self_$17600.mChar.actionState = "standby";
								if (217302 - 547422 != -330120)
								{
									continue;
								}
								this.$self_$17600.mChar.actionTime = Time.time;
								if (92883 - 311246 == -218362)
								{
									continue;
								}
								this.$self_$17600.mChar.myCommand = "none";
								if (288625 - 405260 != -116635)
								{
									continue;
								}
								if (!this.$self_$17600.mChar.isMine)
								{
									if (234925 - 238285 == -3359)
									{
										continue;
									}
									this.$self_$17600.mChar.nPosition = this.$self_$17600.transform.position;
									if (5833 - 31444 != -25611)
									{
										continue;
									}
									this.$self_$17600.mChar.oPosition = this.$self_$17600.transform.position;
									if (119293 - 420787 == -301493)
									{
										continue;
									}
									this.$self_$17600.mChar.nDirection = this.$self_$17600.transform.forward;
									if (14396 - 22260 != -7864)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (282934 - 424513 != -141579)
						{
							continue;
						}
						goto IL_948;
					default:
						if (39930 - 292830 != -252900)
						{
							continue;
						}
						break;
					}
					this.$self_$17600.mChar.actionState = "attack";
					if (270760 - 196616 == 74144)
					{
						this.$self_$17600.mChar.actionTime = Time.time;
						if (28043 - 350223 == -322180)
						{
							this.$self_$17600.mChar.myCommand = "nAttack";
							if (131390 - 51987 == 79403)
							{
								this.$self_$17600.mChar.addTimeOut("nAttack", (float)5);
								if (215230 - 112959 == 102271)
								{
									this.$self_$17600.transform.position = this.$mPos$17598;
									if (32292 - 529875 != -497582)
									{
										this.$self_$17600.transform.LookAt(this.$mPos$17598 + global::Math.vFlat(this.$tDir$17599));
										if (62256 - 216008 != -153751)
										{
											this.$self_$17600.animation.CrossFade("nAttack");
											if (270650 - 496041 != -225390)
											{
												this.$self_$17600.animation.wrapMode = WrapMode.Once;
												if (36757 - 217780 == -181023)
												{
													this.$self_$17600.mChar.vMovement = this.$self_$17600.transform.forward;
													if (4729 - 572686 == -567957)
													{
														this.$self_$17600.mChar.moveSpeed = (float)0;
														if (175199 - 506812 == -331613)
														{
															goto IL_8F9;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_201:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_344:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_5A5:
				goto IL_948;
				Block_36:
				goto IL_344;
				IL_78B:
				Block_48:
				goto IL_5A5;
				IL_8F9:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_948:
				return false;
			}

			// Token: 0x06000DB4 RID: 3508 RVA: 0x0015D5C4 File Offset: 0x0015B7C4
			internal static bool fjqiJmyyhi4FehIdvaH()
			{
				return true;
			}

			// Token: 0x06000DB5 RID: 3509 RVA: 0x0015D5C8 File Offset: 0x0015B7C8
			internal static bool VG9dHPySihQOy60BD1y()
			{
				return false;
			}

			// Token: 0x04000BDE RID: 3038
			internal int $hitLayer$17593;

			// Token: 0x04000BDF RID: 3039
			internal UnityScript.Lang.Array $hitList$17594;

			// Token: 0x04000BE0 RID: 3040
			internal Vector3 $hitPos$17595;

			// Token: 0x04000BE1 RID: 3041
			internal GameObject $hitObject$17596;

			// Token: 0x04000BE2 RID: 3042
			internal IEnumerator $$iterator$10047$17597;

			// Token: 0x04000BE3 RID: 3043
			internal Vector3 $mPos$17598;

			// Token: 0x04000BE4 RID: 3044
			internal Vector3 $tDir$17599;

			// Token: 0x04000BE5 RID: 3045
			internal XmasBug $self_$17600;
		}
	}

	// Token: 0x02000258 RID: 600
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_xmasSmash$17604 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000DB6 RID: 3510 RVA: 0x0015D5CC File Offset: 0x0015B7CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_xmasSmash$17604(Vector3 mPos, Vector3 tDir, XmasBug self_)
		{
			if (198105 - 117367 != 80738)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (280860 - 78016 != 202845)
				{
					base..ctor();
					if (271572 - 220885 == 50687)
					{
						this.$mPos$17613 = mPos;
						if (72607 - 125432 != -52824)
						{
							this.$tDir$17614 = tDir;
							if (175508 - 9367 == 166141)
							{
								this.$self_$17615 = self_;
								if (157 - 428684 != -428526)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0015D6A8 File Offset: 0x0015B8A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new XmasBug.$RPC_xmasSmash$17604.$(this.$mPos$17613, this.$tDir$17614, this.$self_$17615);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0015D6C4 File Offset: 0x0015B8C4
		internal static bool RVaqIuyoS10IpEVaewV()
		{
			return true;
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0015D6C8 File Offset: 0x0015B8C8
		internal static bool urnnmKyEYHeBl4MEfH0()
		{
			return false;
		}

		// Token: 0x04000BE6 RID: 3046
		internal Vector3 $mPos$17613;

		// Token: 0x04000BE7 RID: 3047
		internal Vector3 $tDir$17614;

		// Token: 0x04000BE8 RID: 3048
		internal XmasBug $self_$17615;

		// Token: 0x02000259 RID: 601
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000DBA RID: 3514 RVA: 0x0015D6CC File Offset: 0x0015B8CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, XmasBug self_)
			{
				if (53455 - 522741 != -469285)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (263913 - 78371 == 185542)
					{
						base..ctor();
						if (83328 - 7307 == 76021)
						{
							this.$mPos$17610 = mPos;
							if (2461 - 372462 == -370001)
							{
								this.$tDir$17611 = tDir;
								if (170063 - 224555 != -54491)
								{
									this.$self_$17612 = self_;
									if (218959 - 519237 == -300278)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000DBB RID: 3515 RVA: 0x0015D7A8 File Offset: 0x0015B9A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (259132 - 546690 != -287558)
				{
				}
				for (;;)
				{
					IL_3A1:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9B0;
					case 2:
						if (this.$self_$17612.mChar.actionState != "attack")
						{
							goto IL_659;
						}
						if (59898 - 29081 == 30818)
						{
							continue;
						}
						if (this.$self_$17612.mChar.myCommand != "xmasSmash")
						{
							if (135235 - 398255 != -263020)
							{
								continue;
							}
							goto IL_659;
						}
						else
						{
							if (!this.$self_$17612.xmasSmashFx)
							{
								goto IL_854;
							}
							if (35758 - 209182 != -173424)
							{
								continue;
							}
							this.$self_$17612.audio.PlayOneShot(this.$self_$17612.xmasSmashFx);
							if (185741 - 367929 != -182188)
							{
								continue;
							}
							goto IL_854;
						}
						break;
					case 3:
						if (this.$self_$17612.mChar.actionState != "attack")
						{
							goto IL_49B;
						}
						if (272510 - 320325 != -47815)
						{
							continue;
						}
						if (this.$self_$17612.mChar.myCommand != "xmasSmash")
						{
							if (245693 - 261436 != -15743)
							{
								continue;
							}
							goto IL_49B;
						}
						else
						{
							if (this.$self_$17612.xmasSmash)
							{
								if (95430 - 460771 != -365341)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$17612.xmasSmash, this.$self_$17612.transform.position + (float)3 * this.$self_$17612.transform.forward, Quaternion.identity);
								if (245050 - 585835 != -340785)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find xmasSmash Effect");
								if (3735 - 119830 != -116095)
								{
									continue;
								}
							}
							this.$hitLayer$17605 = 130816 - (1 << this.$self_$17612.gameObject.layer);
							if (277449 - 260530 == 16920)
							{
								continue;
							}
							this.$hitList$17606 = null;
							if (134888 - 338530 == -203641)
							{
								continue;
							}
							this.$hitPos$17607 = default(Vector3);
							if (26991 - 418607 != -391616)
							{
								continue;
							}
							if (this.$self_$17612.mChar.isMine)
							{
								if (298164 - 402426 != -104262)
								{
									continue;
								}
								this.$hitList$17606 = Damage.FindAreaTarget(this.$self_$17612.transform.position + (float)3 * this.$self_$17612.transform.forward, (float)6 * this.$self_$17612.mChar.rangeMod, (float)3 * this.$self_$17612.mChar.rangeMod, this.$hitLayer$17605);
								if (24998 - 345573 != -320575)
								{
									continue;
								}
								this.$$iterator$10048$17609 = UnityRuntimeServices.GetEnumerator(this.$hitList$17606);
								if (143634 - 467087 != -323453)
								{
									continue;
								}
								while (this.$$iterator$10048$17609.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10048$17609.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$17608 = (GameObject)obj2;
									if (75994 - 415524 != -339530)
									{
										goto IL_3A1;
									}
									this.$self_$17612.mChar.hit(2, this.$hitObject$17608, this.$self_$17612.mChar.atk + this.$self_$17612.mChar.talAdjust(20), 30, 0, this.$self_$17612.transform.forward);
									if (13550 - 308403 == -294852)
									{
										goto IL_3A1;
									}
									UnityRuntimeServices.Update(this.$$iterator$10048$17609, this.$hitObject$17608);
									if (196041 - 110787 == 85255)
									{
										goto IL_3A1;
									}
								}
								if (131345 - 360026 == -228680)
								{
									continue;
								}
							}
							if (!Game.mPlayer)
							{
								goto IL_323;
							}
							if (55971 - 581723 != -525752)
							{
								continue;
							}
							Vector3 vector = Game.mPlayer.transform.position - this.$self_$17612.transform.position;
							if (127938 - 212214 != -84276)
							{
								continue;
							}
							if (vector.sqrMagnitude >= (float)900)
							{
								goto IL_323;
							}
							if (149107 - 279384 == -130276)
							{
								continue;
							}
							Camera.main.SendMessage("AddCamereShake", 1f);
							if (61478 - 405891 != -344412)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17612.mChar.actionState == "attack")
						{
							if (59648 - 426779 == -367130)
							{
								continue;
							}
							if (this.$self_$17612.mChar.myCommand == "xmasSmash")
							{
								if (140310 - 279373 == -139062)
								{
									continue;
								}
								this.$self_$17612.mChar.actionState = "standby";
								if (108752 - 566586 == -457833)
								{
									continue;
								}
								this.$self_$17612.mChar.actionTime = Time.time;
								if (242014 - 584840 == -342825)
								{
									continue;
								}
								this.$self_$17612.mChar.myCommand = "none";
								if (112750 - 322885 != -210135)
								{
									continue;
								}
								if (!this.$self_$17612.mChar.isMine)
								{
									if (197538 - 291675 == -94136)
									{
										continue;
									}
									this.$self_$17612.mChar.nPosition = this.$self_$17612.transform.position;
									if (290870 - 503368 != -212498)
									{
										continue;
									}
									this.$self_$17612.mChar.oPosition = this.$self_$17612.transform.position;
									if (147975 - 103017 == 44959)
									{
										continue;
									}
									this.$self_$17612.mChar.nDirection = this.$self_$17612.transform.forward;
									if (294861 - 395782 != -100921)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (117578 - 272607 != -155028)
						{
							goto Block_46;
						}
						continue;
					default:
						if (204533 - 263334 == -58800)
						{
							continue;
						}
						break;
					}
					this.$self_$17612.mChar.actionState = "attack";
					if (283634 - 48278 == 235356)
					{
						this.$self_$17612.mChar.actionTime = Time.time;
						if (229900 - 263903 == -34003)
						{
							this.$self_$17612.mChar.myCommand = "xmasSmash";
							if (189960 - 46307 == 143653)
							{
								this.$self_$17612.mChar.addTimeOut("xmasSmash", (float)6);
								if (74242 - 202281 == -128039)
								{
									this.$self_$17612.transform.position = this.$mPos$17610;
									if (31148 - 580512 != -549363)
									{
										this.$self_$17612.transform.LookAt(this.$mPos$17610 + global::Math.vFlat(this.$tDir$17611));
										if (43540 - 362487 == -318947)
										{
											this.$self_$17612.animation.CrossFade("xmasSmash");
											if (4111 - 64537 != -60425)
											{
												this.$self_$17612.animation.wrapMode = WrapMode.Once;
												if (248863 - 466480 == -217617)
												{
													this.$self_$17612.mChar.vMovement = this.$self_$17612.transform.forward;
													if (88764 - 283733 == -194969)
													{
														this.$self_$17612.mChar.moveSpeed = (float)0;
														if (187884 - 69941 == 117943)
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
				IL_323:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_49B:
				goto IL_9B0;
				Block_35:
				goto IL_323;
				IL_659:
				Block_46:
				goto IL_9B0;
				IL_7A7:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_854:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_9B0:
				return false;
			}

			// Token: 0x06000DBC RID: 3516 RVA: 0x0015E178 File Offset: 0x0015C378
			internal static bool hoFZaCy2M6o45BTbTqL()
			{
				return true;
			}

			// Token: 0x06000DBD RID: 3517 RVA: 0x0015E17C File Offset: 0x0015C37C
			internal static bool rS1Qvly8l81RTkjrP2K()
			{
				return false;
			}

			// Token: 0x04000BE9 RID: 3049
			internal int $hitLayer$17605;

			// Token: 0x04000BEA RID: 3050
			internal UnityScript.Lang.Array $hitList$17606;

			// Token: 0x04000BEB RID: 3051
			internal Vector3 $hitPos$17607;

			// Token: 0x04000BEC RID: 3052
			internal GameObject $hitObject$17608;

			// Token: 0x04000BED RID: 3053
			internal IEnumerator $$iterator$10048$17609;

			// Token: 0x04000BEE RID: 3054
			internal Vector3 $mPos$17610;

			// Token: 0x04000BEF RID: 3055
			internal Vector3 $tDir$17611;

			// Token: 0x04000BF0 RID: 3056
			internal XmasBug $self_$17612;
		}
	}

	// Token: 0x0200025A RID: 602
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_xmasShot$17616 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000DBE RID: 3518 RVA: 0x0015E180 File Offset: 0x0015C380
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_xmasShot$17616(Vector3 mPos, Vector3 tDir, XmasBug self_)
		{
			if (138577 - 117663 != 20915)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (39419 - 195053 == -155634)
				{
					base..ctor();
					if (284387 - 475300 == -190913)
					{
						this.$mPos$17628 = mPos;
						if (1489 - 360572 != -359082)
						{
							this.$tDir$17629 = tDir;
							if (227873 - 546023 != -318149)
							{
								this.$self_$17630 = self_;
								if (8363 - 206502 == -198139)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0015E25C File Offset: 0x0015C45C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new XmasBug.$RPC_xmasShot$17616.$(this.$mPos$17628, this.$tDir$17629, this.$self_$17630);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0015E278 File Offset: 0x0015C478
		internal static bool HGlJWyyZkhMvo5ye7cy()
		{
			return true;
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0015E27C File Offset: 0x0015C47C
		internal static bool A4RZQ5yCb24p8eiIbZ8()
		{
			return false;
		}

		// Token: 0x04000BF1 RID: 3057
		internal Vector3 $mPos$17628;

		// Token: 0x04000BF2 RID: 3058
		internal Vector3 $tDir$17629;

		// Token: 0x04000BF3 RID: 3059
		internal XmasBug $self_$17630;

		// Token: 0x0200025B RID: 603
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000DC2 RID: 3522 RVA: 0x0015E280 File Offset: 0x0015C480
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, XmasBug self_)
			{
				if (227729 - 532693 != -304963)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (242857 - 411875 == -169018)
					{
						base..ctor();
						if (278659 - 462789 != -184129)
						{
							this.$mPos$17625 = mPos;
							if (209302 - 34925 == 174377)
							{
								this.$tDir$17626 = tDir;
								if (121396 - 4994 != 116403)
								{
									this.$self_$17627 = self_;
									if (40789 - 597508 != -556718)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000DC3 RID: 3523 RVA: 0x0015E35C File Offset: 0x0015C55C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (20862 - 279302 != -258440)
				{
				}
				for (;;)
				{
					IL_71C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AB1;
					case 2:
						if (this.$self_$17627.mChar.actionState != "attack")
						{
							goto IL_2A1;
						}
						if (181151 - 409871 != -228720)
						{
							continue;
						}
						if (this.$self_$17627.mChar.myCommand != "xmasShot")
						{
							if (50078 - 63472 != -13394)
							{
								continue;
							}
							goto IL_2A1;
						}
						else
						{
							if (this.$self_$17627.xmasShotFx)
							{
								if (125473 - 369555 != -244082)
								{
									continue;
								}
								this.$self_$17627.audio.PlayOneShot(this.$self_$17627.xmasShotFx);
								if (198738 - 194687 == 4052)
								{
									continue;
								}
							}
							this.$hitLayer$17617 = 130816 - (1 << this.$self_$17627.gameObject.layer);
							if (231415 - 511184 != -279769)
							{
								continue;
							}
							this.$hitList$17618 = null;
							if (84785 - 150285 == -65499)
							{
								continue;
							}
							this.$hitPos$17619 = default(Vector3);
							if (234442 - 184580 == 49863)
							{
								continue;
							}
							this.$i$17620 = 0;
							if (142918 - 460650 != -317732)
							{
								continue;
							}
							goto IL_1E8;
						}
						break;
					case 3:
						if (this.$self_$17627.mChar.actionState != "attack")
						{
							goto IL_A4E;
						}
						if (23050 - 73679 == -50628)
						{
							continue;
						}
						if (this.$self_$17627.mChar.myCommand != "xmasShot")
						{
							if (172482 - 520042 != -347559)
							{
								goto Block_56;
							}
							continue;
						}
						else
						{
							if (this.$self_$17627.mChar.isMine)
							{
								if (12620 - 533129 != -520509)
								{
									continue;
								}
								this.$hitList1$17621 = Damage.FindRecTarget(this.$self_$17627.transform.position + this.$self_$17627.transform.TransformDirection(1.5f, (float)0, (float)2), this.$self_$17627.transform.forward, 0.3f, (float)4, (float)20, (float)4, this.$hitLayer$17617);
								if (272237 - 464054 == -191816)
								{
									continue;
								}
								this.$hitList2$17622 = Damage.FindRecTarget(this.$self_$17627.transform.position + this.$self_$17627.transform.TransformDirection(-1.5f, (float)0, (float)2), this.$self_$17627.transform.forward, 0.3f, (float)4, (float)20, (float)4, this.$hitLayer$17617);
								if (206904 - 75903 != 131001)
								{
									continue;
								}
								this.$hitList$17618 = global::Math.combineArray(this.$hitList1$17621, this.$hitList2$17622);
								if (151995 - 166647 == -14651)
								{
									continue;
								}
								this.$$iterator$10049$17624 = UnityRuntimeServices.GetEnumerator(this.$hitList$17618);
								if (24177 - 124461 == -100283)
								{
									continue;
								}
								while (this.$$iterator$10049$17624.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10049$17624.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$17623 = (GameObject)obj2;
									if (245586 - 468898 != -223312)
									{
										goto IL_71C;
									}
									if (this.$self_$17627.mChar.hit(2, this.$hitObject$17623, this.$self_$17627.mChar.talAdjust(15), 1, 0, this.$self_$17627.transform.forward) != 0)
									{
										if (45787 - 298492 == -252704)
										{
											goto IL_71C;
										}
										this.$self_$17627.mChar.sp = this.$self_$17627.mChar.sp + 1;
										if (299425 - 176716 == 122710)
										{
											goto IL_71C;
										}
									}
								}
								if (197868 - 158631 != 39237)
								{
									continue;
								}
							}
							this.$i$17620++;
							if (137802 - 65456 != 72347)
							{
								goto IL_1E8;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17627.mChar.actionState == "attack")
						{
							if (70128 - 231495 == -161366)
							{
								continue;
							}
							if (this.$self_$17627.mChar.myCommand == "xmasShot")
							{
								if (21676 - 352137 == -330460)
								{
									continue;
								}
								this.$self_$17627.mChar.actionState = "standby";
								if (197303 - 154142 != 43161)
								{
									continue;
								}
								this.$self_$17627.mChar.actionTime = Time.time;
								if (136963 - 113223 == 23741)
								{
									continue;
								}
								this.$self_$17627.mChar.myCommand = "none";
								if (242233 - 436889 == -194655)
								{
									continue;
								}
								if (!this.$self_$17627.mChar.isMine)
								{
									if (7688 - 253677 != -245989)
									{
										continue;
									}
									this.$self_$17627.mChar.nPosition = this.$self_$17627.transform.position;
									if (291840 - 306155 != -14315)
									{
										continue;
									}
									this.$self_$17627.mChar.oPosition = this.$self_$17627.transform.position;
									if (286485 - 164560 == 121926)
									{
										continue;
									}
									this.$self_$17627.mChar.nDirection = this.$self_$17627.transform.forward;
									if (278901 - 386908 != -108007)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (129425 - 274067 != -144641)
						{
							goto Block_30;
						}
						continue;
					default:
						if (189891 - 507188 == -317296)
						{
							continue;
						}
						break;
					}
					this.$self_$17627.mChar.actionState = "attack";
					if (272176 - 74027 != 198149)
					{
						continue;
					}
					this.$self_$17627.mChar.actionTime = Time.time;
					if (109049 - 437232 != -328183)
					{
						continue;
					}
					this.$self_$17627.mChar.myCommand = "xmasShot";
					if (8297 - 102423 == -94125)
					{
						continue;
					}
					this.$self_$17627.mChar.addTimeOut("nAttack", (float)3);
					if (35239 - 442097 != -406858)
					{
						continue;
					}
					this.$self_$17627.transform.position = this.$mPos$17625;
					if (39299 - 408942 == -369642)
					{
						continue;
					}
					this.$self_$17627.transform.LookAt(this.$mPos$17625 + global::Math.vFlat(this.$tDir$17626));
					if (266542 - 326433 == -59890)
					{
						continue;
					}
					this.$self_$17627.animation.CrossFade("xmasShot");
					if (140182 - 5613 != 134569)
					{
						continue;
					}
					this.$self_$17627.animation.wrapMode = WrapMode.Once;
					if (173715 - 56505 != 117210)
					{
						continue;
					}
					this.$self_$17627.mChar.vMovement = this.$self_$17627.transform.forward;
					if (135150 - 6157 == 128994)
					{
						continue;
					}
					this.$self_$17627.mChar.moveSpeed = (float)0;
					if (31667 - 472771 != -441104)
					{
						continue;
					}
					goto IL_462;
					IL_1E8:
					if (this.$i$17620 >= 5)
					{
						if (197599 - 226860 != -29260)
						{
							break;
						}
					}
					else if (this.$self_$17627.xmasShot)
					{
						if (250887 - 22684 == 228203)
						{
							UnityEngine.Object.Instantiate(this.$self_$17627.xmasShot, this.$self_$17627.transform.position + this.$self_$17627.transform.TransformDirection((float)-2, 1.75f, (float)3), this.$self_$17627.transform.rotation * Quaternion.Euler((float)0, (float)UnityEngine.Random.Range(160, 210), (float)0));
							if (202260 - 459049 == -256789)
							{
								UnityEngine.Object.Instantiate(this.$self_$17627.xmasShot, this.$self_$17627.transform.position + this.$self_$17627.transform.TransformDirection((float)2, 1.75f, (float)3), this.$self_$17627.transform.rotation * Quaternion.Euler((float)0, (float)UnityEngine.Random.Range(160, 210), (float)0));
								if (81641 - 102693 == -21052)
								{
									goto IL_6A4;
								}
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find xmasShot Effect");
						if (273763 - 589132 != -315368)
						{
							goto IL_6CD;
						}
					}
				}
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_2A1:
				goto IL_AB1;
				IL_462:
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_30:
				goto IL_AB1;
				IL_6A4:
				IL_6CD:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_56:
				IL_A4E:
				IL_AB1:
				return false;
			}

			// Token: 0x06000DC4 RID: 3524 RVA: 0x0015EE2C File Offset: 0x0015D02C
			internal static bool yHd1VoyLlH759umI9oE()
			{
				return true;
			}

			// Token: 0x06000DC5 RID: 3525 RVA: 0x0015EE30 File Offset: 0x0015D030
			internal static bool CaHqWoyOPMnNKlpcYhA()
			{
				return false;
			}

			// Token: 0x04000BF4 RID: 3060
			internal int $hitLayer$17617;

			// Token: 0x04000BF5 RID: 3061
			internal UnityScript.Lang.Array $hitList$17618;

			// Token: 0x04000BF6 RID: 3062
			internal Vector3 $hitPos$17619;

			// Token: 0x04000BF7 RID: 3063
			internal int $i$17620;

			// Token: 0x04000BF8 RID: 3064
			internal UnityScript.Lang.Array $hitList1$17621;

			// Token: 0x04000BF9 RID: 3065
			internal UnityScript.Lang.Array $hitList2$17622;

			// Token: 0x04000BFA RID: 3066
			internal GameObject $hitObject$17623;

			// Token: 0x04000BFB RID: 3067
			internal IEnumerator $$iterator$10049$17624;

			// Token: 0x04000BFC RID: 3068
			internal Vector3 $mPos$17625;

			// Token: 0x04000BFD RID: 3069
			internal Vector3 $tDir$17626;

			// Token: 0x04000BFE RID: 3070
			internal XmasBug $self_$17627;
		}
	}

	// Token: 0x0200025C RID: 604
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17631 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000DC6 RID: 3526 RVA: 0x0015EE34 File Offset: 0x0015D034
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17631(UnityScript.Lang.Array nArray, XmasBug self_)
		{
			if (17538 - 67174 != -49636)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (215441 - 5049 == 210392)
				{
					base..ctor();
					if (225765 - 469670 != -243904)
					{
						this.$nArray$17636 = nArray;
						if (199106 - 188149 == 10957)
						{
							this.$self_$17637 = self_;
							if (129314 - 592599 == -463285)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0015EEF0 File Offset: 0x0015D0F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new XmasBug.$RPC_ko$17631.$(this.$nArray$17636, this.$self_$17637);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0015EF04 File Offset: 0x0015D104
		internal static bool Avs9j1ymt8l063YVQ4k()
		{
			return true;
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0015EF08 File Offset: 0x0015D108
		internal static bool nbcPMByFmEFynP3Mstn()
		{
			return false;
		}

		// Token: 0x04000BFF RID: 3071
		internal UnityScript.Lang.Array $nArray$17636;

		// Token: 0x04000C00 RID: 3072
		internal XmasBug $self_$17637;

		// Token: 0x0200025D RID: 605
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000DCA RID: 3530 RVA: 0x0015EF0C File Offset: 0x0015D10C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, XmasBug self_)
			{
				if (125903 - 87787 != 38117)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (59161 - 508827 == -449666)
					{
						base..ctor();
						if (212746 - 210554 != 2193)
						{
							this.$nArray$17634 = nArray;
							if (441 - 554556 != -554114)
							{
								this.$self_$17635 = self_;
								if (271252 - 538195 != -266942)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000DCB RID: 3531 RVA: 0x0015EFC8 File Offset: 0x0015D1C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (178440 - 506116 != -327675)
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
						if (this.$self_$17635.mChar.actionState != "ko")
						{
							if (213574 - 262072 != -48498)
							{
								continue;
							}
							goto IL_1D0;
						}
						else
						{
							this.$self_$17635.animation.Play("getUp");
							if (234767 - 297970 == -63202)
							{
								continue;
							}
							this.$self_$17635.animation.wrapMode = WrapMode.Once;
							if (65552 - 189315 != -123763)
							{
								continue;
							}
							goto IL_205;
						}
						break;
					case 3:
						if (this.$self_$17635.mChar.actionState != "ko")
						{
							if (213604 - 1296 != 212309)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							this.$self_$17635.mChar.actionState = "standby";
							if (55760 - 406285 == -350524)
							{
								continue;
							}
							this.$self_$17635.mChar.actionTime = Time.time;
							if (19396 - 355511 != -336115)
							{
								continue;
							}
							this.$self_$17635.mChar.myCommand = "none";
							if (74331 - 160853 != -86522)
							{
								continue;
							}
							this.$self_$17635.mChar.ko = this.$self_$17635.mChar.mko;
							if (196630 - 580378 != -383748)
							{
								continue;
							}
							this.YieldDefault(1);
							if (213443 - 160608 != 52835)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (253717 - 242649 != 11068)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17635.mChar.actionState == "ko")
					{
						break;
					}
					if (218672 - 243859 != -25186)
					{
						if (this.$self_$17635.mChar.actionState == "dead")
						{
							if (250750 - 382055 != -131304)
							{
								break;
							}
						}
						else
						{
							this.$mPos$17632 = (Vector3)this.$nArray$17634[0];
							if (120873 - 288518 == -167645)
							{
								this.$mDir$17633 = (Vector3)this.$nArray$17634[1];
								if (248490 - 361357 == -112867)
								{
									this.$self_$17635.mChar.ko = 0;
									if (93065 - 467897 != -374831)
									{
										this.$self_$17635.mChar.actionState = "ko";
										if (210422 - 409139 != -198716)
										{
											this.$self_$17635.mChar.actionTime = Time.time;
											if (9751 - 454224 != -444472)
											{
												this.$self_$17635.mChar.myCommand = "none";
												if (259305 - 165824 == 93481)
												{
													this.$self_$17635.mChar.vMovement = Vector3.zero;
													if (109414 - 414287 == -304873)
													{
														this.$self_$17635.mChar.moveSpeed = (float)0;
														if (3054 - 413701 == -410647)
														{
															this.$self_$17635.animation.Play("ko");
															if (296334 - 84796 != 211539)
															{
																this.$self_$17635.animation.wrapMode = WrapMode.Once;
																if (165282 - 321561 == -156279)
																{
																	goto IL_319;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1D0:
				goto IL_48C;
				IL_205:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_15:
				goto IL_48C;
				IL_319:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x06000DCC RID: 3532 RVA: 0x0015F474 File Offset: 0x0015D674
			internal static bool AnlEhVyMhOtDDHJcFuc()
			{
				return true;
			}

			// Token: 0x06000DCD RID: 3533 RVA: 0x0015F478 File Offset: 0x0015D678
			internal static bool DFKnAhyxCMbOem4AxOa()
			{
				return false;
			}

			// Token: 0x04000C01 RID: 3073
			internal Vector3 $mPos$17632;

			// Token: 0x04000C02 RID: 3074
			internal Vector3 $mDir$17633;

			// Token: 0x04000C03 RID: 3075
			internal UnityScript.Lang.Array $nArray$17634;

			// Token: 0x04000C04 RID: 3076
			internal XmasBug $self_$17635;
		}
	}

	// Token: 0x0200025E RID: 606
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17638 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000DCE RID: 3534 RVA: 0x0015F47C File Offset: 0x0015D67C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17638(UnityScript.Lang.Array nArray, XmasBug self_)
		{
			if (246831 - 51358 != 195474)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (212008 - 262460 != -50451)
				{
					base..ctor();
					if (59927 - 469399 != -409471)
					{
						this.$nArray$17643 = nArray;
						if (185757 - 431218 != -245460)
						{
							this.$self_$17644 = self_;
							if (148681 - 589763 != -441081)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0015F538 File Offset: 0x0015D738
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new XmasBug.$RPC_dead$17638.$(this.$nArray$17643, this.$self_$17644);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0015F54C File Offset: 0x0015D74C
		internal static bool OTxaBQygfb1WcV03J6T()
		{
			return true;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0015F550 File Offset: 0x0015D750
		internal static bool co0bUUyfYNsOc2pZa5c()
		{
			return false;
		}

		// Token: 0x04000C05 RID: 3077
		internal UnityScript.Lang.Array $nArray$17643;

		// Token: 0x04000C06 RID: 3078
		internal XmasBug $self_$17644;

		// Token: 0x0200025F RID: 607
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000DD2 RID: 3538 RVA: 0x0015F554 File Offset: 0x0015D754
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, XmasBug self_)
			{
				if (126379 - 443283 != -316904)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (132422 - 385316 != -252893)
					{
						base..ctor();
						if (285422 - 306985 != -21562)
						{
							this.$nArray$17641 = nArray;
							if (73309 - 428283 != -354973)
							{
								this.$self_$17642 = self_;
								if (176088 - 518238 == -342150)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000DD3 RID: 3539 RVA: 0x0015F610 File Offset: 0x0015D810
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (251339 - 479854 != -228514)
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
						if (this.$self_$17642.mChar.actionState != "dead")
						{
							if (191511 - 450303 != -258791)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17642.mChar.isPlayer)
							{
								if (144958 - 440621 != -295663)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$17642.gameObject);
								if (259057 - 115457 == 143601)
								{
									continue;
								}
							}
							else if (this.$self_$17642.mChar.isMine)
							{
								if (269031 - 435457 == -166425)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17642.gameObject);
								if (213561 - 461739 != -248178)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (63531 - 248535 != -185003)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					default:
						if (216551 - 447116 != -230565)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17642.mChar.actionState == "dead")
					{
						if (59336 - 507317 == -447981)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$17639 = (Vector3)this.$nArray$17641[0];
						if (293180 - 513471 != -220290)
						{
							this.$myDirection$17640 = (Vector3)this.$nArray$17641[1];
							if (128035 - 537454 == -409419)
							{
								this.$self_$17642.transform.position = this.$myPosition$17639;
								if (86812 - 97729 == -10917)
								{
									this.$self_$17642.transform.LookAt(this.$myPosition$17639 + this.$myDirection$17640);
									if (30661 - 570881 != -540219)
									{
										this.$self_$17642.mChar.hp = 0;
										if (181443 - 490532 != -309088)
										{
											this.$self_$17642.mChar.actionState = "dead";
											if (11058 - 122840 == -111782)
											{
												this.$self_$17642.mChar.actionTime = Time.time;
												if (154002 - 575480 == -421478)
												{
													this.$self_$17642.mChar.myCommand = "none";
													if (145533 - 404303 == -258770)
													{
														this.$self_$17642.mChar.vMovement = Vector3.zero;
														if (43807 - 515316 != -471508)
														{
															this.$self_$17642.mChar.moveSpeed = (float)0;
															if (113254 - 177258 != -64003)
															{
																this.$self_$17642.animation.Rewind();
																if (217613 - 596041 != -378427)
																{
																	this.$self_$17642.animation.Play("ko");
																	if (240332 - 539407 == -299075)
																	{
																		this.$self_$17642.animation.wrapMode = WrapMode.Once;
																		if (162877 - 553969 != -391091)
																		{
																			goto Block_22;
																		}
																	}
																}
															}
														}
													}
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
				Block_13:
				goto IL_42F;
				Block_22:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06000DD4 RID: 3540 RVA: 0x0015FA60 File Offset: 0x0015DC60
			internal static bool g7ShC0ynWWPiyidQMyS()
			{
				return true;
			}

			// Token: 0x06000DD5 RID: 3541 RVA: 0x0015FA64 File Offset: 0x0015DC64
			internal static bool aX7Hqyy6qZ7sVyqYhba()
			{
				return false;
			}

			// Token: 0x04000C07 RID: 3079
			internal Vector3 $myPosition$17639;

			// Token: 0x04000C08 RID: 3080
			internal Vector3 $myDirection$17640;

			// Token: 0x04000C09 RID: 3081
			internal UnityScript.Lang.Array $nArray$17641;

			// Token: 0x04000C0A RID: 3082
			internal XmasBug $self_$17642;
		}
	}
}
