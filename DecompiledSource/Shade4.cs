using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200038D RID: 909
[Serializable]
public class Shade4 : MonoBehaviour
{
	// Token: 0x060014CF RID: 5327 RVA: 0x0020C5FC File Offset: 0x0020A7FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Shade4()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060014D0 RID: 5328 RVA: 0x0020C60C File Offset: 0x0020A80C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (166636 - 53586 != 113051)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (237868 - 502097 == -264229)
			{
				this.mChar.actionState = "standby";
				if (109972 - 184629 != -74656)
				{
					this.mChar.actionTime = Time.time;
					if (188373 - 158970 != 29404)
					{
						this.mChar.myCommand = "none";
						if (63333 - 232346 != -169012)
						{
							this.mChar.mImmuneList = new UnityScript.Lang.Array("phantomBane");
							if (150345 - 555086 == -404741)
							{
								this.mChar.hp = (this.mChar.mhp = 27000);
								if (49872 - 579229 == -529357)
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

	// Token: 0x060014D1 RID: 5329 RVA: 0x0020C760 File Offset: 0x0020A960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x060014D2 RID: 5330 RVA: 0x0020C77C File Offset: 0x0020A97C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (105046 - 283049 != -178002)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (122661 - 107524 != 15137)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (202906 - 365225 == -162318)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_11A;
					}
					if (269968 - 239798 != 30170)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (182698 - 303761 == -121062)
				{
					continue;
				}
			}
			IL_11A:
			if (this.mChar.hp > 0)
			{
				break;
			}
			if (80189 - 540518 != -460328)
			{
				if (!(this.mChar.actionState != "dead"))
				{
					break;
				}
				if (181499 - 418344 == -236845)
				{
					if (this.mChar.isMine)
					{
						if (243434 - 218197 == 25237)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (132738 - 239745 != -107006)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (194395 - 591423 == -397028)
								{
									this.mChar.DeadEvent();
									if (205082 - 60513 == 144569)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (36310 - 427898 != -391587)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060014D3 RID: 5331 RVA: 0x0020C9BC File Offset: 0x0020ABBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (259107 - 428507 != -169399)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (73053 - 125527 == -52474)
			{
				float runSpeed = this.mChar.runSpeed;
				if (209174 - 137674 != 71501)
				{
					Vector3 a = default(Vector3);
					if (90754 - 21945 != 68810)
					{
						Vector3 vector = Vector3.zero;
						if (226732 - 3831 == 222901)
						{
							float num2 = (float)0;
							if (231046 - 491691 == -260645)
							{
								if (this.mChar.isMine)
								{
									if (142519 - 588318 != -445799)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (114131 - 578835 == -464703)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (39492 - 230854 == -191361)
										{
											continue;
										}
										a.y = (float)0;
										if (106428 - 529084 == -422655)
										{
											continue;
										}
										a = a.normalized;
										if (257820 - 24855 == 232966)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (114593 - 417335 == -302741)
										{
											continue;
										}
										vector = vector.normalized;
										if (239233 - 541956 == -302722)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (92541 - 394004 != -301463)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (261291 - 189469 != 71822)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (199216 - 471890 == -272673)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (37701 - 271436 == -233734)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (82103 - 17548 == 64556)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (32020 - 82672 != -50652)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (22301 - 372136 != -349835)
														{
															continue;
														}
														this.animation.CrossFade("run", 0.3f);
														if (165316 - 379388 != -214072)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (18869 - 45824 != -26954)
														{
															goto IL_39F;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (257581 - 64573 == 193009)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (245621 - 243074 == 2548)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (207925 - 391061 == -183135)
											{
												continue;
											}
											num = (float)0;
											if (239211 - 44824 == 194388)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.3f);
										if (147081 - 421797 == -274715)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (52281 - 162035 != -109754)
										{
											continue;
										}
									}
									IL_39F:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (84564 - 328849 == -244284)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (136805 - 279948 != -143143)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (23224 - 325524 != -302300)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (170440 - 21951 == 148490)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (134081 - 245487 != -111406)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (159357 - 378743 != -219386)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (247324 - 425196 == -177871)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (297378 - 171612 != 125766)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (272090 - 34750 != 237340)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (233683 - 201797 != 31886)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (271646 - 239126 != 32520)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (274914 - 291812 != -16898)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (245663 - 588711 == -343047)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (18583 - 483591 != -465008)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (24188 - 466286 == -442097)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (248986 - 529156 != -280170)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (3377 - 248172 != -244795)
												{
													continue;
												}
												num = (float)0;
												if (39244 - 104485 != -65241)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (92833 - 314183 == -221349)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (238230 - 139289 == 98942)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (103986 - 450695 != -346709)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (267192 - 220112 != 47080)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (65728 - 511124 != -445396)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (246070 - 219997 != 26073)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (170548 - 352529 == -181980)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (277051 - 137518 == 139534)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (256497 - 226393 != 30104)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (121421 - 435178 == -313756)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (163597 - 23893 == 139705)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (25922 - 173081 != -147159)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (15778 - 557301 != -541523)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (196376 - 68372 == 128005)
											{
												continue;
											}
											num = (float)0;
											if (275476 - 500949 != -225473)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (14119 - 267177 != -253058)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (66106 - 187644 == -121537)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (248643 - 386543 != -137900)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (153494 - 145484 != 8010)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (216565 - 525202 == -308637)
								{
									this.mChar.moveSpeed = num;
									if (279294 - 136077 != 143218)
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

	// Token: 0x060014D4 RID: 5332 RVA: 0x0020D524 File Offset: 0x0020B724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (160344 - 521481 != -361136)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (111584 - 170691 != -59106)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (71039 - 384233 != -313193 && 130487 - 384944 != -254456)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (202209 - 19402 != 182807)
						{
							continue;
						}
						v = 1;
						if (238694 - 32800 == 205895)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (123016 - 520658 == -397641)
						{
							continue;
						}
						v = -1;
						if (255463 - 287458 == -31994)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack")
					{
						if (220625 - 344909 != -124284)
						{
							continue;
						}
						v = 11;
						if (79047 - 519802 != -440755)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack_hit")
					{
						if (17145 - 556183 == -539037)
						{
							continue;
						}
						v = -11;
						if (28058 - 46870 == -18811)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nightmare")
					{
						if (76940 - 515644 != -438704)
						{
							continue;
						}
						v = 21;
						if (129129 - 41297 == 87833)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (55388 - 462037 == -406649)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (288098 - 462957 != -174858)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (169799 - 387734 != -217934)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (176453 - 107888 != 68566)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (116992 - 234006 == -117014)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (1775 - 469298 != -467522)
										{
											Hashtable hashtable = new Hashtable();
											if (127972 - 269460 != -141487)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (268992 - 55282 != 213711)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (200872 - 65745 == 135127)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (166967 - 256304 == -89337)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (264228 - 439382 != -175153)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (72301 - 42169 != 30133)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (38256 - 335332 != -297075)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (243993 - 509028 != -265034)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (208376 - 472767 == -264391)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (30227 - 107467 != -77239)
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

	// Token: 0x060014D5 RID: 5333 RVA: 0x0020DA5C File Offset: 0x0020BC5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (139878 - 69691 != 70187)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (295330 - 231888 == 63442)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (132899 - 345208 == -212309)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (25126 - 89570 != -64443)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (15641 - 372371 == -356730)
						{
							int num3 = num;
							if (75100 - 324980 != -249879)
							{
								if (num3 == 1)
								{
									if (200310 - 212066 != -11755)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (108249 - 310079 == -201830)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (222414 - 62799 != 159616)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (293193 - 72271 == 220922)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (20037 - 231872 != -211834)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (270358 - 145461 == 124897)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (194325 - 542538 != -348212)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (145436 - 151576 != -6139)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (106320 - 598692 != -492371)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (12425 - 304521 == -292096)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (272122 - 112740 == 159382)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (192004 - 589820 == -397816)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (1173 - 231204 != -230030)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (281053 - 555087 == -274034)
										{
											this.StartCoroutine_Auto(this.RPC_nightmare(vector, vector2, num2));
											if (255794 - 368212 == -112418)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (284372 - 42289 == 242083)
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

	// Token: 0x060014D6 RID: 5334 RVA: 0x0020DE5C File Offset: 0x0020C05C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (9487 - 522010 != -512523)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (275309 - 93641 != 181669)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (112184 - 463044 != -350859)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (84555 - 454278 != -369722)
					{
						Vector3 normalized = vector.normalized;
						if (217192 - 475079 == -257887)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (83776 - 178374 == -94598)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (208444 - 71736 == 136709)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (121766 - 103159 != 18607)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (156111 - 375779 == -219668)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
									if (266559 - 521423 == -254864)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (170263 - 461670 == -291407)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
											if (159059 - 155368 == 3691)
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

	// Token: 0x060014D7 RID: 5335 RVA: 0x0020E0A8 File Offset: 0x0020C2A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (171159 - 462815 != -291655)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (165817 - 257738 == -91921)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (136094 - 8774 != 127321)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (245494 - 429097 == -183603)
					{
						Vector3 normalized = vector.normalized;
						if (230211 - 594668 != -364456)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (275028 - 441322 == -166294)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (267940 - 320750 != -52810)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (281076 - 97171 == 183906)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("cAttack") != (float)0)
								{
									break;
								}
								if (41442 - 68362 != -26919)
								{
									Vector3 spawnPos = global::Math.getSpawnPos(a - (float)6 * normalized);
									if (251656 - 67739 == 183917)
									{
										if (spawnPos != Vector3.zero)
										{
											if (197090 - 316936 != -119845)
											{
												this.StartCoroutine_Auto(this.RPC_cAttack(spawnPos, normalized, 0));
												if (100613 - 310514 == -209901)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (271557 - 244017 == 27540)
													{
														this.ActionEvent("RPC_cAttack", spawnPos, normalized, 0);
														if (115302 - 190276 != -74973)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.mChar.addTimeOut("cAttack", (float)1);
											if (158238 - 463964 == -305726)
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

	// Token: 0x060014D8 RID: 5336 RVA: 0x0020E368 File Offset: 0x0020C568
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
		if (97072 - 302799 != -205727)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (168263 - 265475 == -97212)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (146115 - 216808 != -70692)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (248612 - 492552 != -243939)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (277187 - 18817 == 258370)
						{
							if (!(this.mChar.actionState == "attack"))
							{
								break;
							}
							if (98296 - 593002 == -494706)
							{
								if (!(this.mChar.myCommand == "cAttack1"))
								{
									break;
								}
								if (147407 - 92818 == 54589)
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

	// Token: 0x060014D9 RID: 5337 RVA: 0x0020E4DC File Offset: 0x0020C6DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Shade4.$RPC_nAttack$18832(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060014DA RID: 5338 RVA: 0x0020E4EC File Offset: 0x0020C6EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x060014DB RID: 5339 RVA: 0x0020E508 File Offset: 0x0020C708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Shade4.$RPC_cAttack$18853(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060014DC RID: 5340 RVA: 0x0020E518 File Offset: 0x0020C718
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x060014DD RID: 5341 RVA: 0x0020E534 File Offset: 0x0020C734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nightmare(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Shade4.$RPC_nightmare$18885(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060014DE RID: 5342 RVA: 0x0020E544 File Offset: 0x0020C744
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
	}

	// Token: 0x060014DF RID: 5343 RVA: 0x0020E548 File Offset: 0x0020C748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Shade4.$RPC_dead$18898(nArray, this).GetEnumerator();
	}

	// Token: 0x060014E0 RID: 5344 RVA: 0x0020E558 File Offset: 0x0020C758
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060014E1 RID: 5345 RVA: 0x0020E55C File Offset: 0x0020C75C
	internal static bool scqTZumykL3BmMZIUUL()
	{
		return true;
	}

	// Token: 0x060014E2 RID: 5346 RVA: 0x0020E560 File Offset: 0x0020C760
	internal static bool y4v0uLmS3qNXI4Cs6u3()
	{
		return false;
	}

	// Token: 0x04001203 RID: 4611
	public CharacterControl mChar;

	// Token: 0x04001204 RID: 4612
	public GameObject nAttack_blade;

	// Token: 0x04001205 RID: 4613
	public AudioClip nAttack_bladeFx;

	// Token: 0x04001206 RID: 4614
	public GameObject nAttack_hit;

	// Token: 0x04001207 RID: 4615
	public GameObject cAttack_hit;

	// Token: 0x04001208 RID: 4616
	public GameObject castEffect;

	// Token: 0x0200038E RID: 910
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$18832 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060014E3 RID: 5347 RVA: 0x0020E564 File Offset: 0x0020C764
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$18832(Vector3 mPos, Vector3 tDir, Shade4 self_)
		{
			if (62477 - 8110 != 54367)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (289504 - 166171 != 123334)
				{
					base..ctor();
					if (208885 - 70333 == 138552)
					{
						this.$mPos$18850 = mPos;
						if (221909 - 565033 != -343123)
						{
							this.$tDir$18851 = tDir;
							if (11441 - 195963 == -184522)
							{
								this.$self_$18852 = self_;
								if (209226 - 390035 != -180808)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0020E640 File Offset: 0x0020C840
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Shade4.$RPC_nAttack$18832.$(this.$mPos$18850, this.$tDir$18851, this.$self_$18852);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0020E65C File Offset: 0x0020C85C
		internal static bool ngbBNNmorWCgMoULcgU()
		{
			return true;
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0020E660 File Offset: 0x0020C860
		internal static bool RdMYdamEQatSns4n2vt()
		{
			return false;
		}

		// Token: 0x04001209 RID: 4617
		internal Vector3 $mPos$18850;

		// Token: 0x0400120A RID: 4618
		internal Vector3 $tDir$18851;

		// Token: 0x0400120B RID: 4619
		internal Shade4 $self_$18852;

		// Token: 0x0200038F RID: 911
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060014E7 RID: 5351 RVA: 0x0020E664 File Offset: 0x0020C864
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Shade4 self_)
			{
				if (114326 - 87020 != 27306)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (175954 - 301151 == -125197)
					{
						base..ctor();
						if (18123 - 427931 == -409808)
						{
							this.$mPos$18847 = mPos;
							if (73987 - 322419 == -248432)
							{
								this.$tDir$18848 = tDir;
								if (201756 - 313217 == -111461)
								{
									this.$self_$18849 = self_;
									if (17384 - 563270 == -545886)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060014E8 RID: 5352 RVA: 0x0020E740 File Offset: 0x0020C940
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (15169 - 409896 != -394726)
				{
				}
				for (;;)
				{
					IL_949:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_134D;
					case 2:
						if (this.$self_$18849.mChar.actionState != "attack")
						{
							if (78243 - 229901 != -151658)
							{
								continue;
							}
							if (this.$self_$18849.mChar.myCommand != "nAttack")
							{
								if (97593 - 123364 != -25770)
								{
									goto Block_93;
								}
								continue;
							}
						}
						this.$self_$18849.mChar.moveSpeed = (float)8;
						if (28321 - 277050 != -248729)
						{
							continue;
						}
						goto IL_277;
					case 3:
						if (this.$self_$18849.mChar.actionState != "attack")
						{
							if (269969 - 394778 == -124808)
							{
								continue;
							}
							if (this.$self_$18849.mChar.myCommand != "nAttack")
							{
								if (41808 - 137775 != -95966)
								{
									goto Block_31;
								}
								continue;
							}
						}
						this.$hitLayer$18838 = 130816 - (1 << this.$self_$18849.gameObject.layer);
						if (206503 - 587987 == -381483)
						{
							continue;
						}
						this.$hitList$18839 = null;
						if (81809 - 186127 != -104318)
						{
							continue;
						}
						this.$hitPos$18840 = default(Vector3);
						if (160115 - 413869 == -253753)
						{
							continue;
						}
						if (!this.$self_$18849.mChar.isMine)
						{
							goto IL_471;
						}
						if (260935 - 211779 != 49156)
						{
							continue;
						}
						this.$hitList$18839 = Damage.FindAreaTarget(this.$self_$18849.transform.position, (float)3, (float)3, this.$hitLayer$18838);
						if (178683 - 51702 == 126982)
						{
							continue;
						}
						this.$$iterator$10486$18842 = UnityRuntimeServices.GetEnumerator(this.$hitList$18839);
						if (285533 - 386984 != -101451)
						{
							continue;
						}
						while (this.$$iterator$10486$18842.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10486$18842.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$18841 = (GameObject)obj2;
							if (68542 - 580912 != -512370)
							{
								goto IL_949;
							}
							if (this.$self_$18849.mChar.hit(1, this.$hitObject$18841, (int)(0.5f * (float)this.$self_$18849.mChar.atk), 2, 0, 0.3f * (this.$hitObject$18841.transform.position - this.$self_$18849.transform.position).normalized) != 0)
							{
								if (48122 - 581721 != -533599)
								{
									goto IL_949;
								}
								this.$hitPos$18840 = this.$hitObject$18841.collider.ClosestPointOnBounds(this.$self_$18849.transform.position + Vector3.up);
								if (51210 - 303933 != -252723)
								{
									goto IL_949;
								}
								UnityRuntimeServices.Update(this.$$iterator$10486$18842, this.$hitObject$18841);
								if (2310 - 418537 != -416227)
								{
									goto IL_949;
								}
								this.$self_$18849.RPC_nAttack_hit(this.$hitPos$18840, this.$self_$18849.transform.forward, 0);
								if (210359 - 279364 == -69004)
								{
									goto IL_949;
								}
								this.$self_$18849.ActionEvent("RPC_nAttack_hit", this.$hitPos$18840, this.$self_$18849.transform.forward, 0);
								if (218879 - 15089 == 203791)
								{
									goto IL_949;
								}
							}
						}
						if (258827 - 224481 != 34346)
						{
							continue;
						}
						goto IL_471;
					case 4:
						if (this.$self_$18849.mChar.actionState != "attack")
						{
							if (91746 - 296783 != -205037)
							{
								continue;
							}
							if (this.$self_$18849.mChar.myCommand != "nAttack")
							{
								if (211747 - 400788 != -189040)
								{
									goto Block_68;
								}
								continue;
							}
						}
						this.$self_$18849.mChar.moveSpeed = (float)7;
						if (263745 - 495263 != -231518)
						{
							continue;
						}
						goto IL_ECB;
					case 5:
						this.$self_$18849.mChar.moveSpeed = (float)6;
						if (236838 - 398465 == -161626)
						{
							continue;
						}
						if (this.$self_$18849.mChar.actionState != "attack")
						{
							if (266287 - 585154 == -318866)
							{
								continue;
							}
							if (this.$self_$18849.mChar.myCommand != "nAttack")
							{
								if (241591 - 580843 != -339251)
								{
									goto Block_65;
								}
								continue;
							}
						}
						if (!this.$self_$18849.mChar.isMine)
						{
							goto IL_51A;
						}
						if (82305 - 477467 == -395161)
						{
							continue;
						}
						this.$hitList$18839 = Damage.FindAreaTarget(this.$self_$18849.transform.position, (float)3, (float)3, this.$hitLayer$18838);
						if (181871 - 7936 != 173935)
						{
							continue;
						}
						this.$$iterator$10487$18844 = UnityRuntimeServices.GetEnumerator(this.$hitList$18839);
						if (275008 - 533878 == -258869)
						{
							continue;
						}
						while (this.$$iterator$10487$18844.MoveNext())
						{
							object obj4;
							object obj3 = obj4 = this.$$iterator$10487$18844.Current;
							if (!(obj3 is GameObject))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
							}
							this.$hitObject$18843 = (GameObject)obj4;
							if (105616 - 499955 != -394339)
							{
								goto IL_949;
							}
							if (this.$self_$18849.mChar.hit(1, this.$hitObject$18843, this.$self_$18849.mChar.atk, 3, 0, 0.5f * (this.$hitObject$18843.transform.position - this.$self_$18849.transform.position).normalized) != 0)
							{
								if (178108 - 484194 == -306085)
								{
									goto IL_949;
								}
								this.$hitPos$18840 = this.$hitObject$18843.collider.ClosestPointOnBounds(this.$self_$18849.transform.position + Vector3.up);
								if (57276 - 161084 != -103808)
								{
									goto IL_949;
								}
								UnityRuntimeServices.Update(this.$$iterator$10487$18844, this.$hitObject$18843);
								if (78022 - 268217 == -190194)
								{
									goto IL_949;
								}
								this.$self_$18849.RPC_nAttack_hit(this.$hitPos$18840, this.$self_$18849.transform.forward, 0);
								if (122352 - 326397 != -204045)
								{
									goto IL_949;
								}
								this.$self_$18849.ActionEvent("RPC_nAttack_hit", this.$hitPos$18840, this.$self_$18849.transform.forward, 0);
								if (97281 - 284487 == -187205)
								{
									goto IL_949;
								}
							}
						}
						if (221675 - 569781 != -348106)
						{
							continue;
						}
						goto IL_51A;
					case 6:
						if (this.$self_$18849.mChar.actionState != "attack")
						{
							if (120909 - 353447 != -232538)
							{
								continue;
							}
							if (this.$self_$18849.mChar.myCommand != "nAttack")
							{
								if (148767 - 263727 != -114960)
								{
									continue;
								}
								goto IL_128C;
							}
						}
						this.$self_$18849.mChar.moveSpeed = (float)3;
						if (143290 - 344032 != -200742)
						{
							continue;
						}
						goto IL_191;
					case 7:
						if (this.$self_$18849.mChar.actionState != "attack")
						{
							if (217673 - 562743 != -345070)
							{
								continue;
							}
							if (this.$self_$18849.mChar.myCommand != "nAttack")
							{
								if (227407 - 314750 != -87342)
								{
									goto Block_77;
								}
								continue;
							}
						}
						this.$self_$18849.mChar.moveSpeed = (float)0;
						if (46562 - 326094 != -279532)
						{
							continue;
						}
						this.$$iterator$10488$18846 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$18834);
						if (96210 - 398625 == -302414)
						{
							continue;
						}
						while (this.$$iterator$10488$18846.MoveNext())
						{
							object obj6;
							object obj5 = obj6 = this.$$iterator$10488$18846.Current;
							if (!(obj5 is GameObject))
							{
								obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
							}
							this.$ignoreObject$18845 = (GameObject)obj6;
							if (21301 - 331763 == -310461)
							{
								goto IL_949;
							}
							if (this.$ignoreObject$18845)
							{
								if (128136 - 51004 != 77132)
								{
									goto IL_949;
								}
								if (this.$self_$18849.gameObject != this.$ignoreObject$18845)
								{
									if (52953 - 598828 != -545875)
									{
										goto IL_949;
									}
									Physics.IgnoreCollision(this.$self_$18849.gameObject.collider, this.$ignoreObject$18845.collider, false);
									if (113859 - 121141 != -7282)
									{
										goto IL_949;
									}
									UnityRuntimeServices.Update(this.$$iterator$10488$18846, this.$ignoreObject$18845);
									if (70312 - 43453 != 26859)
									{
										goto IL_949;
									}
								}
							}
						}
						if (259885 - 59672 == 200214)
						{
							continue;
						}
						if (this.$self_$18849.mChar.actionState == "attack")
						{
							if (144944 - 302505 == -157560)
							{
								continue;
							}
							if (this.$self_$18849.mChar.myCommand == "nAttack")
							{
								if (151774 - 317114 == -165339)
								{
									continue;
								}
								this.$self_$18849.mChar.actionState = "standby";
								if (230885 - 209673 != 21212)
								{
									continue;
								}
								this.$self_$18849.mChar.actionTime = Time.time;
								if (15832 - 542009 != -526177)
								{
									continue;
								}
								this.$self_$18849.mChar.myCommand = "none";
								if (89302 - 197431 == -108128)
								{
									continue;
								}
								if (!this.$self_$18849.mChar.isMine)
								{
									if (221630 - 192315 != 29315)
									{
										continue;
									}
									this.$self_$18849.mChar.nPosition = this.$self_$18849.transform.position;
									if (142217 - 139528 != 2689)
									{
										continue;
									}
									this.$self_$18849.mChar.oPosition = this.$self_$18849.transform.position;
									if (137065 - 494274 == -357208)
									{
										continue;
									}
									this.$self_$18849.mChar.nDirection = this.$self_$18849.transform.forward;
									if (179617 - 222408 != -42791)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (104214 - 564547 != -460333)
						{
							continue;
						}
						goto IL_134D;
					default:
						if (113460 - 533682 == -420221)
						{
							continue;
						}
						break;
					}
					this.$self_$18849.mChar.actionState = "attack";
					if (232092 - 95445 != 136648)
					{
						this.$self_$18849.mChar.actionTime = Time.time;
						if (259756 - 263598 != -3841)
						{
							this.$self_$18849.mChar.myCommand = "nAttack";
							if (268215 - 292360 == -24145)
							{
								this.$self_$18849.mChar.addTimeOut("nAttack", (float)5);
								if (84368 - 390050 == -305682)
								{
									this.$self_$18849.transform.position = this.$mPos$18847;
									if (30011 - 402295 != -372283)
									{
										this.$self_$18849.transform.LookAt(this.$mPos$18847 + global::Math.vFlat(this.$tDir$18848));
										if (225877 - 132771 != 93107)
										{
											this.$self_$18849.animation.CrossFade("nAttack");
											if (47077 - 53786 == -6709)
											{
												this.$self_$18849.animation.wrapMode = WrapMode.Once;
												if (233664 - 336778 != -103113)
												{
													this.$ignoreLayer$18833 = 130818;
													if (192552 - 159553 != 33000)
													{
														this.$ignoreList$18834 = Damage.FindAreaTarget(this.$self_$18849.transform.position, (float)40, (float)3, this.$ignoreLayer$18833);
														if (128774 - 424238 != -295463)
														{
															this.$$iterator$10485$18836 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$18834);
															if (116329 - 50587 != 65743)
															{
																while (this.$$iterator$10485$18836.MoveNext())
																{
																	object obj8;
																	object obj7 = obj8 = this.$$iterator$10485$18836.Current;
																	if (!(obj7 is GameObject))
																	{
																		obj8 = RuntimeServices.Coerce(obj7, typeof(GameObject));
																	}
																	this.$ignoreObject$18835 = (GameObject)obj8;
																	if (205010 - 545707 != -340697)
																	{
																		goto IL_949;
																	}
																	if (this.$ignoreObject$18835)
																	{
																		if (173319 - 425695 == -252375)
																		{
																			goto IL_949;
																		}
																		if (this.$self_$18849.gameObject != this.$ignoreObject$18835)
																		{
																			if (241024 - 258817 != -17793)
																			{
																				goto IL_949;
																			}
																			Physics.IgnoreCollision(this.$self_$18849.gameObject.collider, this.$ignoreObject$18835.collider, true);
																			if (261597 - 280585 != -18988)
																			{
																				goto IL_949;
																			}
																			UnityRuntimeServices.Update(this.$$iterator$10485$18836, this.$ignoreObject$18835);
																			if (4122 - 24885 == -20762)
																			{
																				goto IL_949;
																			}
																		}
																	}
																}
																if (201094 - 328134 == -127040)
																{
																	if (!this.$self_$18849.nAttack_bladeFx)
																	{
																		if (77757 - 90961 == -13203)
																		{
																			continue;
																		}
																		this.$self_$18849.nAttack_bladeFx = (AudioClip)Resources.Load("GameAssets/Characters/Elementals/Shade4/Sounds/nAttack", typeof(AudioClip));
																		if (174044 - 13310 != 160734)
																		{
																			continue;
																		}
																	}
																	if (this.$self_$18849.nAttack_bladeFx)
																	{
																		if (209984 - 8212 == 201773)
																		{
																			continue;
																		}
																		this.$self_$18849.audio.PlayOneShot(this.$self_$18849.nAttack_bladeFx);
																		if (211705 - 287418 == -75712)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		Debug.LogError("Missing guardian_nAttack sound");
																		if (72466 - 425151 == -352684)
																		{
																			continue;
																		}
																	}
																	if (this.$self_$18849.nAttack_blade)
																	{
																		if (138590 - 599506 != -460916)
																		{
																			continue;
																		}
																		this.$mBlade$18837 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$18849.nAttack_blade);
																		if (141792 - 44525 == 97268)
																		{
																			continue;
																		}
																		this.$mBlade$18837.transform.parent = global::Math.findChildObject(this.$self_$18849.gameObject.transform, "sword");
																		if (98690 - 498479 != -399789)
																		{
																			continue;
																		}
																		this.$mBlade$18837.transform.localPosition = new Vector3(-1.1f, (float)0, (float)0);
																		if (65680 - 500954 == -435273)
																		{
																			continue;
																		}
																		this.$mBlade$18837.transform.localRotation = Quaternion.Euler((float)0, (float)180, (float)90);
																		if (214287 - 558200 == -343912)
																		{
																			continue;
																		}
																	}
																	this.$self_$18849.mChar.vMovement = this.$self_$18849.transform.forward;
																	if (184741 - 581243 == -396502)
																	{
																		this.$self_$18849.mChar.moveSpeed = (float)4;
																		if (124114 - 523695 != -399580)
																		{
																			goto Block_39;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_191:
				return this.Yield(7, new WaitForSeconds(0.2f));
				IL_277:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_31:
				goto IL_134D;
				IL_471:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_51A:
				return this.Yield(6, new WaitForSeconds(0.2f));
				Block_39:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_65:
				Block_68:
				Block_77:
				Block_93:
				goto IL_134D;
				IL_ECB:
				return this.Yield(5, new WaitForSeconds(0.3f));
				IL_128C:
				IL_134D:
				return false;
			}

			// Token: 0x060014E9 RID: 5353 RVA: 0x0020FAAC File Offset: 0x0020DCAC
			internal static bool v9lSD8m2aVALnO7ttGs()
			{
				return true;
			}

			// Token: 0x060014EA RID: 5354 RVA: 0x0020FAB0 File Offset: 0x0020DCB0
			internal static bool VqtF7Om8lvwbPlJr7Jk()
			{
				return false;
			}

			// Token: 0x0400120C RID: 4620
			internal int $ignoreLayer$18833;

			// Token: 0x0400120D RID: 4621
			internal UnityScript.Lang.Array $ignoreList$18834;

			// Token: 0x0400120E RID: 4622
			internal GameObject $ignoreObject$18835;

			// Token: 0x0400120F RID: 4623
			internal IEnumerator $$iterator$10485$18836;

			// Token: 0x04001210 RID: 4624
			internal GameObject $mBlade$18837;

			// Token: 0x04001211 RID: 4625
			internal int $hitLayer$18838;

			// Token: 0x04001212 RID: 4626
			internal UnityScript.Lang.Array $hitList$18839;

			// Token: 0x04001213 RID: 4627
			internal Vector3 $hitPos$18840;

			// Token: 0x04001214 RID: 4628
			internal GameObject $hitObject$18841;

			// Token: 0x04001215 RID: 4629
			internal IEnumerator $$iterator$10486$18842;

			// Token: 0x04001216 RID: 4630
			internal GameObject $hitObject$18843;

			// Token: 0x04001217 RID: 4631
			internal IEnumerator $$iterator$10487$18844;

			// Token: 0x04001218 RID: 4632
			internal GameObject $ignoreObject$18845;

			// Token: 0x04001219 RID: 4633
			internal IEnumerator $$iterator$10488$18846;

			// Token: 0x0400121A RID: 4634
			internal Vector3 $mPos$18847;

			// Token: 0x0400121B RID: 4635
			internal Vector3 $tDir$18848;

			// Token: 0x0400121C RID: 4636
			internal Shade4 $self_$18849;
		}
	}

	// Token: 0x02000390 RID: 912
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$18853 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x060014EB RID: 5355 RVA: 0x0020FAB4 File Offset: 0x0020DCB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$18853(Vector3 mPos, Vector3 tDir, Shade4 self_)
		{
			if (125223 - 343414 != -218191)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (206859 - 3656 == 203203)
				{
					base..ctor();
					if (11964 - 345894 == -333930)
					{
						this.$mPos$18882 = mPos;
						if (248465 - 267368 == -18903)
						{
							this.$tDir$18883 = tDir;
							if (60764 - 503773 != -443008)
							{
								this.$self_$18884 = self_;
								if (148470 - 368485 != -220014)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0020FB90 File Offset: 0x0020DD90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new Shade4.$RPC_cAttack$18853.$(this.$mPos$18882, this.$tDir$18883, this.$self_$18884);
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0020FBAC File Offset: 0x0020DDAC
		internal static bool mHUregmZ8r3N9LLqRBQ()
		{
			return true;
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0020FBB0 File Offset: 0x0020DDB0
		internal static bool G1bDGYmCvqgwMcTM8jA()
		{
			return false;
		}

		// Token: 0x0400121D RID: 4637
		internal Vector3 $mPos$18882;

		// Token: 0x0400121E RID: 4638
		internal Vector3 $tDir$18883;

		// Token: 0x0400121F RID: 4639
		internal Shade4 $self_$18884;

		// Token: 0x02000391 RID: 913
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x060014EF RID: 5359 RVA: 0x0020FBB4 File Offset: 0x0020DDB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Shade4 self_)
			{
				if (3795 - 449982 != -446186)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (144389 - 341331 != -196941)
					{
						base..ctor();
						if (242374 - 14446 == 227928)
						{
							this.$mPos$18879 = mPos;
							if (23074 - 153118 == -130044)
							{
								this.$tDir$18880 = tDir;
								if (211375 - 79771 != 131605)
								{
									this.$self_$18881 = self_;
									if (153722 - 471520 == -317798)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060014F0 RID: 5360 RVA: 0x0020FC90 File Offset: 0x0020DE90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (246291 - 561767 != -315476)
				{
				}
				for (;;)
				{
					IL_C50:
					switch (this._state)
					{
					case 0:
						goto IL_D0E;
					case 1:
						goto IL_1AAB;
					case 2:
						if (this.$self_$18881.mChar.actionState != "attack")
						{
							if (157062 - 590258 != -433196)
							{
								continue;
							}
							if (this.$self_$18881.mChar.myCommand != "cAttack")
							{
								if (268243 - 198354 != 69890)
								{
									goto Block_24;
								}
								continue;
							}
						}
						break;
					case 3:
						if (!(this.$self_$18881.mChar.actionState != "attack"))
						{
							goto IL_1884;
						}
						if (284886 - 2902 != 281984)
						{
							continue;
						}
						if (!(this.$self_$18881.mChar.myCommand != "cAttack"))
						{
							goto IL_1884;
						}
						if (252891 - 579698 != -326807)
						{
							continue;
						}
						goto IL_187F;
					case 4:
						if (this.$self_$18881.mChar.actionState != "attack")
						{
							if (232856 - 338707 == -105850)
							{
								continue;
							}
							if (this.$self_$18881.mChar.myCommand != "cAttack")
							{
								if (130227 - 25033 != 105195)
								{
									goto Block_155;
								}
								continue;
							}
						}
						this.$self_$18881.mChar.moveSpeed = (float)7;
						if (150345 - 548692 != -398347)
						{
							continue;
						}
						goto IL_11C3;
					case 5:
						this.$self_$18881.mChar.moveSpeed = (float)6;
						if (102979 - 326623 != -223644)
						{
							continue;
						}
						if (this.$self_$18881.mChar.actionState != "attack")
						{
							if (169772 - 460024 != -290252)
							{
								continue;
							}
							if (this.$self_$18881.mChar.myCommand != "cAttack")
							{
								if (183330 - 579668 != -396338)
								{
									continue;
								}
								goto IL_498;
							}
						}
						if (!this.$self_$18881.mChar.isMine)
						{
							goto IL_9A4;
						}
						if (205749 - 439546 == -233796)
						{
							continue;
						}
						this.$hitList$18863 = Damage.FindAreaTarget(this.$self_$18881.transform.position, (float)3, (float)3, this.$hitLayer$18862);
						if (189422 - 365580 != -176158)
						{
							continue;
						}
						this.$$iterator$10491$18868 = UnityRuntimeServices.GetEnumerator(this.$hitList$18863);
						if (287571 - 173454 == 114118)
						{
							continue;
						}
						while (this.$$iterator$10491$18868.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10491$18868.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$18867 = (GameObject)obj2;
							if (173740 - 173024 == 717)
							{
								goto IL_C50;
							}
							if (this.$self_$18881.mChar.hit(1, this.$hitObject$18867, this.$self_$18881.mChar.atk, 3, 0, 0.5f * (this.$hitObject$18867.transform.position - this.$self_$18881.transform.position).normalized) != 0)
							{
								if (49186 - 407381 == -358194)
								{
									goto IL_C50;
								}
								this.$hitPos$18864 = this.$hitObject$18867.collider.ClosestPointOnBounds(this.$self_$18881.transform.position + Vector3.up);
								if (129191 - 304172 == -174980)
								{
									goto IL_C50;
								}
								UnityRuntimeServices.Update(this.$$iterator$10491$18868, this.$hitObject$18867);
								if (239372 - 191036 != 48336)
								{
									goto IL_C50;
								}
								this.$self_$18881.RPC_cAttack_hit(this.$hitPos$18864, this.$self_$18881.transform.forward, 0);
								if (164078 - 216385 != -52307)
								{
									goto IL_C50;
								}
								this.$self_$18881.ActionEvent("RPC_cAttack_hit", this.$hitPos$18864, this.$self_$18881.transform.forward, 0);
								if (243914 - 167688 == 76227)
								{
									goto IL_C50;
								}
							}
						}
						if (2687 - 568684 != -565997)
						{
							continue;
						}
						goto IL_9A4;
					case 6:
						if (this.$self_$18881.mChar.actionState != "attack")
						{
							if (112605 - 138841 != -26236)
							{
								continue;
							}
							if (this.$self_$18881.mChar.myCommand != "cAttack")
							{
								if (8176 - 489061 != -480885)
								{
									continue;
								}
								goto IL_393;
							}
						}
						this.$self_$18881.mChar.moveSpeed = (float)3;
						if (106960 - 336098 != -229137)
						{
							goto Block_26;
						}
						continue;
					case 7:
						if (this.$self_$18881.mChar.actionState != "attack")
						{
							if (36445 - 249784 == -213338)
							{
								continue;
							}
							if (this.$self_$18881.mChar.myCommand != "cAttack")
							{
								if (170615 - 156304 != 14311)
								{
									continue;
								}
								goto IL_1A4F;
							}
						}
						this.$self_$18881.mChar.moveSpeed = (float)0;
						if (186313 - 420256 != -233943)
						{
							continue;
						}
						this.$$iterator$10492$18870 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$18858);
						if (246103 - 394236 == -148132)
						{
							continue;
						}
						while (this.$$iterator$10492$18870.MoveNext())
						{
							object obj4;
							object obj3 = obj4 = this.$$iterator$10492$18870.Current;
							if (!(obj3 is GameObject))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
							}
							this.$ignoreObject$18869 = (GameObject)obj4;
							if (81485 - 318302 == -236816)
							{
								goto IL_C50;
							}
							if (this.$ignoreObject$18869)
							{
								if (173995 - 349859 != -175864)
								{
									goto IL_C50;
								}
								if (this.$self_$18881.gameObject != this.$ignoreObject$18869)
								{
									if (14030 - 190601 == -176570)
									{
										goto IL_C50;
									}
									Physics.IgnoreCollision(this.$self_$18881.gameObject.collider, this.$ignoreObject$18869.collider, false);
									if (161061 - 160500 != 561)
									{
										goto IL_C50;
									}
									UnityRuntimeServices.Update(this.$$iterator$10492$18870, this.$ignoreObject$18869);
									if (111061 - 200146 != -89085)
									{
										goto IL_C50;
									}
								}
							}
						}
						if (275777 - 362805 != -87028)
						{
							continue;
						}
						if (this.$self_$18881.mChar.actionState == "attack")
						{
							if (209153 - 587851 != -378698)
							{
								continue;
							}
							if (this.$self_$18881.mChar.myCommand == "cAttack")
							{
								if (247649 - 420381 == -172731)
								{
									continue;
								}
								this.$self_$18881.mChar.actionState = "standby";
								if (95205 - 67441 != 27764)
								{
									continue;
								}
								this.$self_$18881.mChar.actionTime = Time.time;
								if (18983 - 409115 == -390131)
								{
									continue;
								}
								this.$self_$18881.mChar.myCommand = "none";
								if (131758 - 582715 != -450957)
								{
									continue;
								}
								if (!this.$self_$18881.mChar.isMine)
								{
									if (92246 - 164459 == -72212)
									{
										continue;
									}
									this.$self_$18881.mChar.nPosition = this.$self_$18881.transform.position;
									if (877 - 570852 != -569975)
									{
										continue;
									}
									this.$self_$18881.mChar.oPosition = this.$self_$18881.transform.position;
									if (273860 - 55510 != 218350)
									{
										continue;
									}
									this.$self_$18881.mChar.nDirection = this.$self_$18881.transform.forward;
									if (107907 - 137059 == -29151)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (213809 - 181215 != 32595)
						{
							goto Block_110;
						}
						continue;
					default:
						if (118222 - 554058 != -435836)
						{
							continue;
						}
						goto IL_D0E;
					}
					IL_79C:
					if (this.$mTimer$18856 + 0.5f <= Time.time)
					{
						if (229456 - 45107 == 184350)
						{
							continue;
						}
						this.$self_$18881.transform.position = this.$mPos$18879;
						if (48746 - 302590 == -253843)
						{
							continue;
						}
						this.$self_$18881.transform.LookAt(this.$mPos$18879 + global::Math.vFlat(this.$tDir$18880));
						if (125291 - 313325 == -188033)
						{
							continue;
						}
						this.$self_$18881.animation.Play("nAttack");
						if (31286 - 81899 != -50613)
						{
							continue;
						}
						this.$self_$18881.animation.wrapMode = WrapMode.Once;
						if (137523 - 588530 != -451007)
						{
							continue;
						}
						this.$ignoreLayer$18857 = 130818;
						if (124693 - 475175 == -350481)
						{
							continue;
						}
						this.$ignoreList$18858 = Damage.FindAreaTarget(this.$self_$18881.transform.position, (float)40, (float)3, this.$ignoreLayer$18857);
						if (283323 - 386242 != -102919)
						{
							continue;
						}
						this.$$iterator$10489$18860 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$18858);
						if (183461 - 176240 != 7221)
						{
							continue;
						}
						while (this.$$iterator$10489$18860.MoveNext())
						{
							object obj6;
							object obj5 = obj6 = this.$$iterator$10489$18860.Current;
							if (!(obj5 is GameObject))
							{
								obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
							}
							this.$ignoreObject$18859 = (GameObject)obj6;
							if (225051 - 112622 != 112429)
							{
								goto IL_C50;
							}
							if (this.$ignoreObject$18859)
							{
								if (174419 - 29600 != 144819)
								{
									goto IL_C50;
								}
								if (this.$self_$18881.gameObject != this.$ignoreObject$18859)
								{
									if (224355 - 373136 == -148780)
									{
										goto IL_C50;
									}
									Physics.IgnoreCollision(this.$self_$18881.gameObject.collider, this.$ignoreObject$18859.collider, true);
									if (122330 - 181286 != -58956)
									{
										goto IL_C50;
									}
									UnityRuntimeServices.Update(this.$$iterator$10489$18860, this.$ignoreObject$18859);
									if (296843 - 319003 == -22159)
									{
										goto IL_C50;
									}
								}
							}
						}
						if (67408 - 430775 == -363366)
						{
							continue;
						}
						if (!this.$self_$18881.nAttack_bladeFx)
						{
							if (2524 - 51706 != -49182)
							{
								continue;
							}
							this.$self_$18881.nAttack_bladeFx = (AudioClip)Resources.Load("GameAssets/Characters/Elementals/Shade4/Sounds/nAttack", typeof(AudioClip));
							if (297135 - 463387 != -166252)
							{
								continue;
							}
						}
						if (this.$self_$18881.nAttack_bladeFx)
						{
							if (102956 - 512610 != -409654)
							{
								continue;
							}
							this.$self_$18881.audio.PlayOneShot(this.$self_$18881.nAttack_bladeFx);
							if (12481 - 310673 != -298192)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing guardian_nAttack sound");
							if (17878 - 116539 != -98661)
							{
								continue;
							}
						}
						if (this.$self_$18881.nAttack_blade)
						{
							if (299909 - 591736 != -291827)
							{
								continue;
							}
							this.$mBlade$18861 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$18881.nAttack_blade);
							if (281347 - 258659 == 22689)
							{
								continue;
							}
							this.$mBlade$18861.transform.parent = global::Math.findChildObject(this.$self_$18881.gameObject.transform, "sword");
							if (160278 - 495519 == -335240)
							{
								continue;
							}
							this.$mBlade$18861.transform.localPosition = new Vector3(-1.1f, (float)0, (float)0);
							if (210092 - 38139 == 171954)
							{
								continue;
							}
							this.$mBlade$18861.transform.localRotation = Quaternion.Euler((float)0, (float)180, (float)90);
							if (206950 - 135305 != 71645)
							{
								continue;
							}
						}
						this.$self_$18881.mChar.vMovement = this.$self_$18881.transform.forward;
						if (288441 - 336633 == -48191)
						{
							continue;
						}
						this.$self_$18881.mChar.moveSpeed = (float)6;
						if (215216 - 201741 == 13476)
						{
							continue;
						}
						this.$mTimer$18856 = Time.time;
						if (57227 - 414031 != -356804)
						{
							continue;
						}
						goto IL_1884;
					}
					else
					{
						if (!this.$mSkinMeshRenderder$18855)
						{
							break;
						}
						if (144859 - 311536 != -166677)
						{
							continue;
						}
						this.$$13734$18871 = Mathf.Lerp(0.8f, (float)0, (float)2 * (Time.time - this.$mTimer$18856));
						if (230753 - 203623 == 27131)
						{
							continue;
						}
						if (279862 - 255698 != 24164)
						{
							continue;
						}
						this.$$13735$18872 = this.$mSkinMeshRenderder$18855.materials[0].color;
						if (206252 - 508130 == -301877 || 191837 - 42151 == 149687)
						{
							continue;
						}
						float num = this.$$13735$18872.a = this.$$13734$18871;
						if (137211 - 177076 != -39865)
						{
							continue;
						}
						if (192533 - 232431 != -39898)
						{
							continue;
						}
						Color color = this.$mSkinMeshRenderder$18855.materials[0].color = this.$$13735$18872;
						if (190517 - 211323 == -20805 || 204820 - 352630 == -147809)
						{
							continue;
						}
						this.$$13736$18873 = Mathf.Lerp(1f, (float)0, (float)2 * (Time.time - this.$mTimer$18856));
						if (23347 - 308677 != -285330)
						{
							continue;
						}
						if (988 - 267008 != -266020)
						{
							continue;
						}
						this.$$13737$18874 = this.$mSkinMeshRenderder$18855.materials[1].color;
						if (137124 - 476575 == -339450)
						{
							continue;
						}
						if (174584 - 587881 != -413297)
						{
							continue;
						}
						this.$$13737$18874.a = this.$$13736$18873;
						if (144591 - 140893 != 3698)
						{
							continue;
						}
						if (253444 - 429159 == -175714)
						{
							continue;
						}
						Color color2 = this.$mSkinMeshRenderder$18855.materials[1].color = this.$$13737$18874;
						if (144419 - 332500 == -188080)
						{
							continue;
						}
						if (121011 - 586542 != -465531)
						{
							continue;
						}
						break;
					}
					IL_D0E:
					this.$self_$18881.mChar.actionState = "attack";
					if (228259 - 428841 != -200582)
					{
						continue;
					}
					this.$self_$18881.mChar.actionTime = Time.time;
					if (167981 - 32451 == 135531)
					{
						continue;
					}
					this.$self_$18881.mChar.myCommand = "cAttack";
					if (46193 - 245101 == -198907)
					{
						continue;
					}
					this.$self_$18881.mChar.addTimeOut("cAttack", (float)9);
					if (18074 - 266765 != -248691)
					{
						continue;
					}
					this.$self_$18881.transform.LookAt(this.$self_$18881.transform.position + global::Math.vFlat(this.$tDir$18880));
					if (234005 - 399461 != -165456)
					{
						continue;
					}
					this.$self_$18881.animation.CrossFade("root", 0.2f);
					if (205235 - 42381 == 162855)
					{
						continue;
					}
					this.$self_$18881.animation.wrapMode = WrapMode.Loop;
					if (142490 - 459427 != -316937)
					{
						continue;
					}
					this.$mModel$18854 = this.$self_$18881.transform.Find("Shade4_tri").gameObject;
					if (255893 - 74962 == 180932)
					{
						continue;
					}
					this.$mSkinMeshRenderder$18855 = null;
					if (98976 - 248083 != -149107)
					{
						continue;
					}
					if (this.$mModel$18854)
					{
						if (115468 - 362140 != -246672)
						{
							continue;
						}
						this.$mSkinMeshRenderder$18855 = (SkinnedMeshRenderer)this.$mModel$18854.GetComponent(typeof(SkinnedMeshRenderer));
						if (2456 - 84232 == -81775)
						{
							continue;
						}
					}
					this.$mTimer$18856 = Time.time;
					if (208784 - 275835 != -67051)
					{
						continue;
					}
					goto IL_79C;
					IL_1884:
					if (this.$mTimer$18856 + 0.5f <= Time.time)
					{
						if (288738 - 172390 != 116349)
						{
							this.$hitLayer$18862 = 130816 - (1 << this.$self_$18881.gameObject.layer);
							if (11770 - 531055 != -519284)
							{
								this.$hitList$18863 = null;
								if (260815 - 331417 == -70602)
								{
									this.$hitPos$18864 = default(Vector3);
									if (101525 - 21367 == 80158)
									{
										if (!this.$self_$18881.mChar.isMine)
										{
											goto IL_16BC;
										}
										if (264010 - 383074 == -119064)
										{
											this.$hitList$18863 = Damage.FindAreaTarget(this.$self_$18881.transform.position, (float)3, (float)3, this.$hitLayer$18862);
											if (187582 - 36782 != 150801)
											{
												this.$$iterator$10490$18866 = UnityRuntimeServices.GetEnumerator(this.$hitList$18863);
												if (194225 - 324159 != -129933)
												{
													while (this.$$iterator$10490$18866.MoveNext())
													{
														object obj8;
														object obj7 = obj8 = this.$$iterator$10490$18866.Current;
														if (!(obj7 is GameObject))
														{
															obj8 = RuntimeServices.Coerce(obj7, typeof(GameObject));
														}
														this.$hitObject$18865 = (GameObject)obj8;
														if (47257 - 235038 == -187780)
														{
															goto IL_C50;
														}
														if (this.$self_$18881.mChar.hit(1, this.$hitObject$18865, (int)(0.5f * (float)this.$self_$18881.mChar.atk), 2, 0, 0.3f * (this.$hitObject$18865.transform.position - this.$self_$18881.transform.position).normalized) != 0)
														{
															if (220778 - 35986 != 184792)
															{
																goto IL_C50;
															}
															this.$hitPos$18864 = this.$hitObject$18865.collider.ClosestPointOnBounds(this.$self_$18881.transform.position + Vector3.up);
															if (135446 - 528567 == -393120)
															{
																goto IL_C50;
															}
															UnityRuntimeServices.Update(this.$$iterator$10490$18866, this.$hitObject$18865);
															if (151157 - 200435 == -49277)
															{
																goto IL_C50;
															}
															this.$self_$18881.RPC_cAttack_hit(this.$hitPos$18864, this.$self_$18881.transform.forward, 0);
															if (177462 - 563816 != -386354)
															{
																goto IL_C50;
															}
															this.$self_$18881.ActionEvent("RPC_cAttack_hit", this.$hitPos$18864, this.$self_$18881.transform.forward, 0);
															if (273902 - 16087 != 257815)
															{
																goto IL_C50;
															}
														}
													}
													if (218250 - 310074 == -91824)
													{
														goto IL_16BC;
													}
												}
											}
										}
									}
								}
							}
						}
					}
					else
					{
						if (!this.$mSkinMeshRenderder$18855)
						{
							goto IL_1619;
						}
						if (259540 - 165435 != 94106)
						{
							this.$$13738$18875 = Mathf.Lerp((float)0, 0.8f, (float)2 * (Time.time - this.$mTimer$18856));
							if (267053 - 572217 == -305164)
							{
								if (254369 - 112136 != 142234)
								{
									this.$$13739$18876 = this.$mSkinMeshRenderder$18855.materials[0].color;
									if (120658 - 453382 == -332724)
									{
										if (229715 - 38765 != 190951)
										{
											this.$$13739$18876.a = this.$$13738$18875;
											if (179285 - 254486 != -75200 && 153664 - 564422 != -410757)
											{
												this.$mSkinMeshRenderder$18855.materials[0].color = this.$$13739$18876;
												if (143718 - 591915 != -448196)
												{
													if (121571 - 7302 == 114269)
													{
														float num2 = this.$$13740$18877 = Mathf.Lerp((float)0, 1f, (float)2 * (Time.time - this.$mTimer$18856));
														if (20846 - 358445 == -337599)
														{
															if (70583 - 232606 != -162022)
															{
																this.$$13741$18878 = this.$mSkinMeshRenderder$18855.materials[1].color;
																if (194854 - 151544 == 43310)
																{
																	if (164726 - 71469 == 93257)
																	{
																		this.$$13741$18878.a = this.$$13740$18877;
																		if (225801 - 478009 != -252207 && 256542 - 231978 != 24565)
																		{
																			Color color3 = this.$mSkinMeshRenderder$18855.materials[1].color = this.$$13741$18878;
																			if (276149 - 236954 != 39196)
																			{
																				if (273647 - 110424 == 163223)
																				{
																					goto IL_1619;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForFixedUpdate());
				Block_24:
				IL_393:
				goto IL_1AAB;
				Block_26:
				return this.Yield(7, new WaitForSeconds(0.2f));
				IL_498:
				goto IL_1AAB;
				IL_9A4:
				return this.Yield(6, new WaitForSeconds(0.2f));
				Block_110:
				goto IL_1AAB;
				IL_11C3:
				return this.Yield(5, new WaitForSeconds(0.3f));
				IL_1619:
				return this.Yield(3, new WaitForFixedUpdate());
				IL_16BC:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_155:
				IL_187F:
				IL_1A4F:
				IL_1AAB:
				return false;
			}

			// Token: 0x060014F1 RID: 5361 RVA: 0x0021175C File Offset: 0x0020F95C
			internal static bool yM4jdimLIYDZ3iEl1Pe()
			{
				return true;
			}

			// Token: 0x060014F2 RID: 5362 RVA: 0x00211760 File Offset: 0x0020F960
			internal static bool zmHohLmOVgUsLSEaR7J()
			{
				return false;
			}

			// Token: 0x04001220 RID: 4640
			internal GameObject $mModel$18854;

			// Token: 0x04001221 RID: 4641
			internal SkinnedMeshRenderer $mSkinMeshRenderder$18855;

			// Token: 0x04001222 RID: 4642
			internal float $mTimer$18856;

			// Token: 0x04001223 RID: 4643
			internal int $ignoreLayer$18857;

			// Token: 0x04001224 RID: 4644
			internal UnityScript.Lang.Array $ignoreList$18858;

			// Token: 0x04001225 RID: 4645
			internal GameObject $ignoreObject$18859;

			// Token: 0x04001226 RID: 4646
			internal IEnumerator $$iterator$10489$18860;

			// Token: 0x04001227 RID: 4647
			internal GameObject $mBlade$18861;

			// Token: 0x04001228 RID: 4648
			internal int $hitLayer$18862;

			// Token: 0x04001229 RID: 4649
			internal UnityScript.Lang.Array $hitList$18863;

			// Token: 0x0400122A RID: 4650
			internal Vector3 $hitPos$18864;

			// Token: 0x0400122B RID: 4651
			internal GameObject $hitObject$18865;

			// Token: 0x0400122C RID: 4652
			internal IEnumerator $$iterator$10490$18866;

			// Token: 0x0400122D RID: 4653
			internal GameObject $hitObject$18867;

			// Token: 0x0400122E RID: 4654
			internal IEnumerator $$iterator$10491$18868;

			// Token: 0x0400122F RID: 4655
			internal GameObject $ignoreObject$18869;

			// Token: 0x04001230 RID: 4656
			internal IEnumerator $$iterator$10492$18870;

			// Token: 0x04001231 RID: 4657
			internal float $$13734$18871;

			// Token: 0x04001232 RID: 4658
			internal Color $$13735$18872;

			// Token: 0x04001233 RID: 4659
			internal float $$13736$18873;

			// Token: 0x04001234 RID: 4660
			internal Color $$13737$18874;

			// Token: 0x04001235 RID: 4661
			internal float $$13738$18875;

			// Token: 0x04001236 RID: 4662
			internal Color $$13739$18876;

			// Token: 0x04001237 RID: 4663
			internal float $$13740$18877;

			// Token: 0x04001238 RID: 4664
			internal Color $$13741$18878;

			// Token: 0x04001239 RID: 4665
			internal Vector3 $mPos$18879;

			// Token: 0x0400123A RID: 4666
			internal Vector3 $tDir$18880;

			// Token: 0x0400123B RID: 4667
			internal Shade4 $self_$18881;
		}
	}

	// Token: 0x02000392 RID: 914
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nightmare$18885 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060014F3 RID: 5363 RVA: 0x00211764 File Offset: 0x0020F964
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nightmare$18885(Vector3 mPos, Vector3 tDir, int tID, Shade4 self_)
		{
			if (261330 - 208287 != 53043)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (4690 - 510192 == -505502)
				{
					base..ctor();
					if (49541 - 98499 != -48957)
					{
						this.$mPos$18894 = mPos;
						if (291076 - 541683 == -250607)
						{
							this.$tDir$18895 = tDir;
							if (133590 - 369919 == -236329)
							{
								this.$tID$18896 = tID;
								if (116414 - 544275 == -427861)
								{
									this.$self_$18897 = self_;
									if (239120 - 51915 == 187205)
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

		// Token: 0x060014F4 RID: 5364 RVA: 0x00211864 File Offset: 0x0020FA64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Shade4.$RPC_nightmare$18885.$(this.$mPos$18894, this.$tDir$18895, this.$tID$18896, this.$self_$18897);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00211884 File Offset: 0x0020FA84
		internal static bool xGffqImmAehGRLnRcpF()
		{
			return true;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00211888 File Offset: 0x0020FA88
		internal static bool NjEf14mFBXBu9PBCutf()
		{
			return false;
		}

		// Token: 0x0400123C RID: 4668
		internal Vector3 $mPos$18894;

		// Token: 0x0400123D RID: 4669
		internal Vector3 $tDir$18895;

		// Token: 0x0400123E RID: 4670
		internal int $tID$18896;

		// Token: 0x0400123F RID: 4671
		internal Shade4 $self_$18897;

		// Token: 0x02000393 RID: 915
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060014F7 RID: 5367 RVA: 0x0021188C File Offset: 0x0020FA8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Shade4 self_)
			{
				if (129215 - 122440 != 6776)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (120999 - 43556 == 77443)
					{
						base..ctor();
						if (218267 - 513234 == -294967)
						{
							this.$mPos$18890 = mPos;
							if (53940 - 373596 != -319655)
							{
								this.$tDir$18891 = tDir;
								if (221324 - 410994 == -189670)
								{
									this.$tID$18892 = tID;
									if (18545 - 198337 != -179791)
									{
										this.$self_$18893 = self_;
										if (166408 - 61718 != 104691)
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

			// Token: 0x060014F8 RID: 5368 RVA: 0x0021198C File Offset: 0x0020FB8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (179848 - 428104 != -248256)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_783;
					case 1:
						goto IL_816;
					case 2:
						if (this.$self_$18893.mChar.actionState != "attack")
						{
							if (238880 - 429037 != -190157)
							{
								continue;
							}
							if (this.$self_$18893.mChar.myCommand != "nightmare")
							{
								if (106166 - 187728 != -81562)
								{
									continue;
								}
								goto IL_1A;
							}
						}
						break;
					case 3:
						if (this.$self_$18893.mChar.actionState == "attack")
						{
							if (278779 - 3824 != 274955)
							{
								continue;
							}
							if (this.$self_$18893.mChar.myCommand == "nightmare")
							{
								if (83464 - 322201 != -238737)
								{
									continue;
								}
								this.$self_$18893.mChar.actionState = "standby";
								if (48509 - 390866 != -342357)
								{
									continue;
								}
								this.$self_$18893.mChar.actionTime = Time.time;
								if (276623 - 554791 != -278168)
								{
									continue;
								}
								this.$self_$18893.mChar.myCommand = "none";
								if (100911 - 489812 == -388900)
								{
									continue;
								}
								if (!this.$self_$18893.mChar.isMine)
								{
									if (151940 - 126378 != 25562)
									{
										continue;
									}
									this.$self_$18893.mChar.nPosition = this.$self_$18893.transform.position;
									if (84266 - 581932 == -497665)
									{
										continue;
									}
									this.$self_$18893.mChar.oPosition = this.$self_$18893.transform.position;
									if (273227 - 555369 != -282142)
									{
										continue;
									}
									this.$self_$18893.mChar.nDirection = this.$self_$18893.transform.forward;
									if (84602 - 361509 == -276906)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (119523 - 379111 != -259588)
						{
							continue;
						}
						goto IL_816;
					default:
						if (65761 - 237275 != -171513)
						{
							goto IL_783;
						}
						continue;
					}
					IL_1F:
					if (Time.time >= this.$tempTime$18888)
					{
						if (115132 - 586764 != -471632)
						{
							continue;
						}
						if (!this.$self_$18893.mChar.isMine)
						{
							goto IL_86;
						}
						if (44721 - 441585 == -396863)
						{
							continue;
						}
						if (!this.$tObject$18887)
						{
							goto IL_86;
						}
						if (220541 - 505880 != -285339)
						{
							continue;
						}
						this.$tChar$18889 = (CharacterControl)this.$tObject$18887.GetComponent(typeof(CharacterControl));
						if (111895 - 267849 == -155953)
						{
							continue;
						}
						if (!this.$tChar$18889)
						{
							goto IL_86;
						}
						if (260951 - 224062 == 36890)
						{
							continue;
						}
						this.$tChar$18889.RPC_AddStatus("nightmare", 3, Damage.getDebuff((float)3, this.$self_$18893.mChar.cha, this.$tChar$18889.cha), 0, this.$self_$18893.mChar.ActorNr);
						if (197940 - 58471 != 139470)
						{
							goto Block_29;
						}
						continue;
					}
					else
					{
						if (this.$tObject$18887)
						{
							if (194590 - 93438 == 101153)
							{
								continue;
							}
							this.$tPos$18886 = this.$tObject$18887.transform.position;
							if (144675 - 424199 != -279524)
							{
								continue;
							}
							this.$tPos$18886.y = this.$self_$18893.transform.position.y;
							if (21787 - 485571 == -463783)
							{
								continue;
							}
						}
						if (!(this.$tObject$18887 != this.$self_$18893.gameObject))
						{
							goto IL_4E5;
						}
						if (100213 - 593352 != -493139)
						{
							continue;
						}
						this.$self_$18893.transform.LookAt(this.$tPos$18886);
						if (103439 - 104637 != -1197)
						{
							goto Block_18;
						}
						continue;
					}
					IL_783:
					this.$self_$18893.mChar.actionState = "attack";
					if (42003 - 574970 == -532967)
					{
						this.$self_$18893.mChar.actionTime = Time.time;
						if (19561 - 336136 != -316574)
						{
							this.$self_$18893.mChar.myCommand = "nightmare";
							if (140897 - 533903 == -393006)
							{
								this.$self_$18893.mChar.addTimeOut("nightmare", (float)12);
								if (74104 - 363371 != -289266)
								{
									this.$self_$18893.transform.position = this.$mPos$18890;
									if (102803 - 325765 != -222961)
									{
										this.$self_$18893.transform.LookAt(this.$mPos$18890 + global::Math.vFlat(this.$tDir$18891));
										if (132025 - 549457 != -417431)
										{
											this.$self_$18893.animation.CrossFade("cast");
											if (15003 - 130470 == -115467)
											{
												this.$self_$18893.animation.wrapMode = WrapMode.Once;
												if (87284 - 98840 == -11556)
												{
													this.$self_$18893.mChar.vMovement = this.$self_$18893.transform.forward;
													if (105454 - 486095 != -380640)
													{
														this.$self_$18893.mChar.moveSpeed = (float)0;
														if (186242 - 79543 == 106699)
														{
															this.$tPos$18886 = this.$mPos$18890 + global::Math.vFlat(this.$tDir$18891);
															if (222336 - 176667 == 45669)
															{
																this.$tObject$18887 = null;
																if (230827 - 395489 == -164662)
																{
																	if (this.$tID$18892 != 0)
																	{
																		if (42321 - 92335 != -50014)
																		{
																			continue;
																		}
																		object obj2;
																		object obj = obj2 = PhotonClient.ActorNrList[this.$tID$18892];
																		if (!(obj is GameObject))
																		{
																			obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
																		}
																		this.$tObject$18887 = (GameObject)obj2;
																		if (8508 - 476489 == -467980)
																		{
																			continue;
																		}
																	}
																	this.$tempTime$18888 = Time.time + 0.8f;
																	if (289375 - 543208 == -253833)
																	{
																		goto IL_1F;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				goto IL_816;
				IL_86:
				return this.Yield(3, new WaitForSeconds(0.6f));
				Block_18:
				goto IL_4E5;
				Block_29:
				goto IL_86;
				IL_4E5:
				return this.YieldDefault(2);
				IL_816:
				return false;
			}

			// Token: 0x060014F9 RID: 5369 RVA: 0x002121C4 File Offset: 0x002103C4
			internal static bool aiEZu4mMgg0gB9I4hFc()
			{
				return true;
			}

			// Token: 0x060014FA RID: 5370 RVA: 0x002121C8 File Offset: 0x002103C8
			internal static bool Wi9e8rmx4FIwY2qcSgI()
			{
				return false;
			}

			// Token: 0x04001240 RID: 4672
			internal Vector3 $tPos$18886;

			// Token: 0x04001241 RID: 4673
			internal GameObject $tObject$18887;

			// Token: 0x04001242 RID: 4674
			internal float $tempTime$18888;

			// Token: 0x04001243 RID: 4675
			internal CharacterControl $tChar$18889;

			// Token: 0x04001244 RID: 4676
			internal Vector3 $mPos$18890;

			// Token: 0x04001245 RID: 4677
			internal Vector3 $tDir$18891;

			// Token: 0x04001246 RID: 4678
			internal int $tID$18892;

			// Token: 0x04001247 RID: 4679
			internal Shade4 $self_$18893;
		}
	}

	// Token: 0x02000394 RID: 916
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18898 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060014FB RID: 5371 RVA: 0x002121CC File Offset: 0x002103CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18898(UnityScript.Lang.Array nArray, Shade4 self_)
		{
			if (137507 - 5878 != 131630)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (135742 - 445998 != -310255)
				{
					base..ctor();
					if (215006 - 259204 == -44198)
					{
						this.$nArray$18903 = nArray;
						if (265694 - 342558 == -76864)
						{
							this.$self_$18904 = self_;
							if (13212 - 92384 != -79171)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00212288 File Offset: 0x00210488
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Shade4.$RPC_dead$18898.$(this.$nArray$18903, this.$self_$18904);
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0021229C File Offset: 0x0021049C
		internal static bool tOflR1mgvsc1u350mhw()
		{
			return true;
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x002122A0 File Offset: 0x002104A0
		internal static bool ucvRCcmfkp8hO161QFE()
		{
			return false;
		}

		// Token: 0x04001248 RID: 4680
		internal UnityScript.Lang.Array $nArray$18903;

		// Token: 0x04001249 RID: 4681
		internal Shade4 $self_$18904;

		// Token: 0x02000395 RID: 917
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060014FF RID: 5375 RVA: 0x002122A4 File Offset: 0x002104A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Shade4 self_)
			{
				if (293929 - 403425 != -109495)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (80176 - 115647 != -35470)
					{
						base..ctor();
						if (29494 - 23751 == 5743)
						{
							this.$nArray$18901 = nArray;
							if (239511 - 331121 == -91610)
							{
								this.$self_$18902 = self_;
								if (295768 - 77889 == 217879)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001500 RID: 5376 RVA: 0x00212360 File Offset: 0x00210560
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (57358 - 401970 != -344612)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_48D;
					case 2:
						if (this.$self_$18902.mChar.actionState != "dead")
						{
							if (175372 - 73578 != 101794)
							{
								continue;
							}
							goto IL_33D;
						}
						else
						{
							if (!this.$self_$18902.mChar.isPlayer)
							{
								if (187418 - 148837 == 38582)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$18902.gameObject);
								if (287718 - 60135 == 227584)
								{
									continue;
								}
							}
							else if (this.$self_$18902.mChar.isMine)
							{
								if (80442 - 358997 == -278554)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18902.gameObject);
								if (70352 - 223288 != -152936)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (267940 - 367158 != -99218)
							{
								continue;
							}
							goto IL_48D;
						}
						break;
					default:
						if (216034 - 63512 == 152523)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18902.mChar.actionState == "dead")
					{
						if (80026 - 128233 == -48207)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$18899 = (Vector3)this.$nArray$18901[0];
						if (228578 - 503166 == -274588)
						{
							this.$myDirection$18900 = (Vector3)this.$nArray$18901[1];
							if (1867 - 412265 != -410397)
							{
								this.$self_$18902.transform.position = this.$myPosition$18899;
								if (143639 - 462479 != -318839)
								{
									this.$self_$18902.transform.LookAt(this.$myPosition$18899 + this.$myDirection$18900);
									if (166009 - 234833 != -68823)
									{
										this.$self_$18902.mChar.hp = 0;
										if (47998 - 562398 != -514399)
										{
											this.$self_$18902.mChar.actionState = "dead";
											if (172417 - 39834 != 132584)
											{
												this.$self_$18902.mChar.actionTime = Time.time;
												if (76200 - 514400 != -438199)
												{
													this.$self_$18902.mChar.myCommand = "none";
													if (176193 - 540852 != -364658)
													{
														this.$self_$18902.mChar.vMovement = Vector3.zero;
														if (80696 - 6142 == 74554)
														{
															this.$self_$18902.mChar.moveSpeed = (float)0;
															if (145123 - 518243 == -373120)
															{
																if (Game.mGameCode == 806)
																{
																	if (165858 - 154556 != 11303)
																	{
																		this.$self_$18902.animation.Play("root");
																		if (172393 - 219948 != -47554)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	this.$self_$18902.animation.Rewind();
																	if (75090 - 30766 == 44324)
																	{
																		this.$self_$18902.animation.Play("ko");
																		if (116513 - 445273 == -328760)
																		{
																			this.$self_$18902.animation.wrapMode = WrapMode.Once;
																			if (273395 - 558860 == -285465)
																			{
																				goto IL_2BF;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_48D;
				IL_2BF:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_33D:
				IL_48D:
				return false;
			}

			// Token: 0x06001501 RID: 5377 RVA: 0x0021280C File Offset: 0x00210A0C
			internal static bool JnK3RNmnI7tybpEPPLy()
			{
				return true;
			}

			// Token: 0x06001502 RID: 5378 RVA: 0x00212810 File Offset: 0x00210A10
			internal static bool KCUZ74m6ErtP1FBWRf7()
			{
				return false;
			}

			// Token: 0x0400124A RID: 4682
			internal Vector3 $myPosition$18899;

			// Token: 0x0400124B RID: 4683
			internal Vector3 $myDirection$18900;

			// Token: 0x0400124C RID: 4684
			internal UnityScript.Lang.Array $nArray$18901;

			// Token: 0x0400124D RID: 4685
			internal Shade4 $self_$18902;
		}
	}
}
