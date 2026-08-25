using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200010D RID: 269
[Serializable]
public class NemesisBug : MonoBehaviour
{
	// Token: 0x060005F9 RID: 1529 RVA: 0x0009E31C File Offset: 0x0009C51C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NemesisBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x0009E32C File Offset: 0x0009C52C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (289776 - 109745 != 180031)
		{
		}
		for (;;)
		{
			this.jkJnG4aliW = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (7940 - 464008 == -456068)
			{
				this.jkJnG4aliW.actionState = "standby";
				if (140105 - 160599 != -20493)
				{
					this.jkJnG4aliW.actionTime = Time.time;
					if (54638 - 103066 != -48427)
					{
						this.jkJnG4aliW.myCommand = "none";
						if (170367 - 448939 != -278571)
						{
							GameObject gameObject = global::Math.findChildObject(this.transform, "head").gameObject;
							if (33942 - 317498 != -283555)
							{
								if (gameObject)
								{
									if (30507 - 415496 == -384988)
									{
										continue;
									}
									this.VXCn1n4dvB = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (109847 - 11725 != 98122)
									{
										continue;
									}
								}
								GameObject gameObject2 = global::Math.findChildObject(this.transform, "bodyArmor").gameObject;
								if (54683 - 355639 == -300956)
								{
									if (!gameObject2)
									{
										break;
									}
									if (121470 - 15418 == 106052)
									{
										this.mHvnq6bNSL = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
										if (62139 - 262313 != -200173)
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

	// Token: 0x060005FB RID: 1531 RVA: 0x0009E52C File Offset: 0x0009C72C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (278353 - 542225 != -263871)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (232490 - 38167 == 194324)
				{
					continue;
				}
				this.jkJnG4aliW.isMine = true;
				if (113771 - 313041 == -199269)
				{
					continue;
				}
			}
			this.mNetworkRotation = this.transform.forward;
			if (193616 - 253044 == -59428)
			{
				if (this.jkJnG4aliW.ActorNr != 0)
				{
					if (278919 - 327472 == -48552)
					{
						continue;
					}
					if (this.VXCn1n4dvB)
					{
						if (152875 - 290195 == -137319)
						{
							continue;
						}
						this.VXCn1n4dvB.ActorNr = this.jkJnG4aliW.ActorNr + 1;
						if (70596 - 74013 == -3416)
						{
							continue;
						}
						this.VXCn1n4dvB.ownerID = this.jkJnG4aliW.ownerID;
						if (216485 - 252790 != -36305)
						{
							continue;
						}
						this.VXCn1n4dvB.gameObject.layer = this.gameObject.layer;
						if (165882 - 552281 != -386399)
						{
							continue;
						}
						this.VXCn1n4dvB.isPlayer = false;
						if (291439 - 59594 == 231846)
						{
							continue;
						}
						this.VXCn1n4dvB.isControlled = false;
						if (37320 - 245113 != -207793)
						{
							continue;
						}
						if (this.jkJnG4aliW.ownerID == PlayerData.UID)
						{
							if (27001 - 484620 == -457618)
							{
								continue;
							}
							this.VXCn1n4dvB.isMine = true;
							if (59025 - 265678 == -206652)
							{
								continue;
							}
						}
						else
						{
							this.VXCn1n4dvB.isMine = false;
							if (143544 - 439269 != -295725)
							{
								continue;
							}
						}
						if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.VXCn1n4dvB.ActorNr], null))
						{
							if (92915 - 506537 == -413621)
							{
								continue;
							}
							Debug.LogError("ActorNr: " + this.VXCn1n4dvB.ActorNr + " already existed");
							if (262202 - 519786 == -257583)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.VXCn1n4dvB.ActorNr];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject obj3 = (GameObject)obj2;
							if (185526 - 429572 != -244046)
							{
								continue;
							}
							UnityEngine.Object.Destroy(obj3);
							if (65112 - 110781 == -45668)
							{
								continue;
							}
						}
						PhotonClient.ActorNrList.Add(this.VXCn1n4dvB.ActorNr, this.VXCn1n4dvB.gameObject);
						if (55661 - 359453 != -303792)
						{
							continue;
						}
					}
					if (this.mHvnq6bNSL)
					{
						if (242219 - 64156 != 178063)
						{
							continue;
						}
						this.mHvnq6bNSL.ActorNr = this.jkJnG4aliW.ActorNr + 2;
						if (12792 - 172368 == -159575)
						{
							continue;
						}
						this.mHvnq6bNSL.ownerID = this.jkJnG4aliW.ownerID;
						if (24005 - 181536 != -157531)
						{
							continue;
						}
						this.mHvnq6bNSL.gameObject.layer = this.gameObject.layer;
						if (51414 - 524083 == -472668)
						{
							continue;
						}
						this.mHvnq6bNSL.isPlayer = false;
						if (254595 - 37254 == 217342)
						{
							continue;
						}
						this.mHvnq6bNSL.isControlled = false;
						if (125994 - 439751 == -313756)
						{
							continue;
						}
						if (this.jkJnG4aliW.ownerID == PlayerData.UID)
						{
							if (9018 - 269432 != -260414)
							{
								continue;
							}
							this.mHvnq6bNSL.isMine = true;
							if (201685 - 139279 != 62406)
							{
								continue;
							}
						}
						else
						{
							this.mHvnq6bNSL.isMine = false;
							if (244066 - 402680 != -158614)
							{
								continue;
							}
						}
						if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[this.mHvnq6bNSL.ActorNr], null))
						{
							if (201383 - 194804 != 6579)
							{
								continue;
							}
							Debug.LogError("ActorNr: " + this.mHvnq6bNSL.ActorNr + " already existed");
							if (96991 - 145501 != -48510)
							{
								continue;
							}
							object obj5;
							object obj4 = obj5 = PhotonClient.ActorNrList[this.mHvnq6bNSL.ActorNr];
							if (!(obj4 is GameObject))
							{
								obj5 = RuntimeServices.Coerce(obj4, typeof(GameObject));
							}
							GameObject obj6 = (GameObject)obj5;
							if (49260 - 209788 != -160528)
							{
								continue;
							}
							UnityEngine.Object.Destroy(obj6);
							if (98192 - 115825 != -17633)
							{
								continue;
							}
						}
						PhotonClient.ActorNrList.Add(this.mHvnq6bNSL.ActorNr, this.mHvnq6bNSL.gameObject);
						if (168737 - 335324 == -166586)
						{
							continue;
						}
					}
				}
				this.jkJnG4aliW.addTimeOut("nAttack", (float)6);
				if (76692 - 84414 == -7722)
				{
					this.jkJnG4aliW.addTimeOut("cAttack", (float)12);
					if (95776 - 370918 != -275141)
					{
						this.jkJnG4aliW.addTimeOut("genesisSeed", (float)30);
						if (61052 - 414591 == -353539)
						{
							if (!this.jkJnG4aliW)
							{
								break;
							}
							if (260493 - 82136 != 178358)
							{
								this.jkJnG4aliW.mImmuneList = new UnityScript.Lang.Array(new object[]
								{
									"artCancel",
									"swallow",
									"paralysis",
									"needlePrison",
									"invisible",
									"petrify",
									"snowMan",
									"snowBall",
									"sleep",
									"charm",
									"mindControl",
									"nemesisLarva",
									"coma"
								});
								if (155859 - 56201 == 99658)
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

	// Token: 0x060005FC RID: 1532 RVA: 0x0009ECD8 File Offset: 0x0009CED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (1621 - 152103 != -150482)
		{
		}
		for (;;)
		{
			if (this.jkJnG4aliW.isControlled)
			{
				if (71738 - 110860 != -39122)
				{
					continue;
				}
				if (!(this.jkJnG4aliW.actionState == "standby"))
				{
					if (212133 - 120097 == 92037)
					{
						continue;
					}
					if (!(this.jkJnG4aliW.actionState == "run"))
					{
						goto IL_429;
					}
					if (96807 - 478891 == -382083)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (114700 - 494530 == -379829)
				{
					continue;
				}
			}
			IL_429:
			if (this.VXCn1n4dvB.hp + this.mHvnq6bNSL.hp > 0)
			{
				goto IL_32A;
			}
			if (233071 - 381023 != -147952)
			{
				continue;
			}
			if (!(this.jkJnG4aliW.actionState != "dead"))
			{
				goto IL_32A;
			}
			if (117329 - 431289 != -313960)
			{
				continue;
			}
			if (this.jkJnG4aliW.isMine)
			{
				if (79339 - 522773 != -443434)
				{
					continue;
				}
				this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
				{
					this.transform.position,
					this.transform.forward
				})));
				if (23186 - 564742 == -541555)
				{
					continue;
				}
				if (PhotonClient.IsInitialized())
				{
					if (190983 - 582624 == -391640)
					{
						continue;
					}
					this.jkJnG4aliW.DeadEvent();
					if (89807 - 93816 != -4009)
					{
						continue;
					}
				}
			}
			IL_E8:
			if (this.VXCn1n4dvB.hp < 0)
			{
				if (155335 - 114600 == 40736)
				{
					continue;
				}
				this.VXCn1n4dvB.hp = 0;
				if (226161 - 108863 == 117299)
				{
					continue;
				}
			}
			if (this.mHvnq6bNSL.hp >= 0)
			{
				break;
			}
			if (22281 - 142096 == -119814)
			{
				continue;
			}
			this.mHvnq6bNSL.hp = 0;
			if (157859 - 335991 != -178132)
			{
				continue;
			}
			break;
			IL_32A:
			if (this.VXCn1n4dvB.hp > 0)
			{
				if (233454 - 372237 == -138782)
				{
					continue;
				}
				if (this.VXCn1n4dvB.ko <= 0)
				{
					if (54065 - 221975 != -167910)
					{
						continue;
					}
					if (this.jkJnG4aliW.actionState != "ko")
					{
						if (216955 - 306007 == -89051)
						{
							continue;
						}
						if (this.jkJnG4aliW.actionState != "dead")
						{
							if (141180 - 497068 != -355887)
							{
								if (this.jkJnG4aliW.isMine)
								{
									if (82839 - 577800 != -494961)
									{
										continue;
									}
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (204325 - 256478 != -52153)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (5176 - 278831 != -273655)
										{
											continue;
										}
										this.jkJnG4aliW.KoEvent();
										if (158675 - 499197 == -340521)
										{
											continue;
										}
									}
								}
								else
								{
									this.VXCn1n4dvB.ko = 1;
									if (112506 - 519827 == -407320)
									{
										continue;
									}
								}
								goto IL_E8;
							}
							continue;
						}
					}
				}
			}
			if (this.mHvnq6bNSL.hp <= 0)
			{
				goto IL_E8;
			}
			if (155457 - 561101 == -405644)
			{
				if (this.mHvnq6bNSL.ko > 0)
				{
					goto IL_E8;
				}
				if (97313 - 351588 != -254274)
				{
					if (!(this.jkJnG4aliW.actionState != "ko"))
					{
						goto IL_E8;
					}
					if (8749 - 3466 != 5284)
					{
						if (!(this.jkJnG4aliW.actionState != "dead"))
						{
							goto IL_E8;
						}
						if (111487 - 532134 == -420647)
						{
							if (this.jkJnG4aliW.isMine)
							{
								if (200438 - 529016 != -328577)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (261920 - 77918 != 184003)
									{
										if (PhotonClient.IsInitialized())
										{
											if (103853 - 328521 == -224667)
											{
												continue;
											}
											this.jkJnG4aliW.KoEvent();
											if (254430 - 284599 == -30168)
											{
												continue;
											}
										}
										goto IL_E8;
									}
								}
							}
							else
							{
								this.mHvnq6bNSL.ko = 1;
								if (140004 - 165055 == -25051)
								{
									goto IL_E8;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x0009F30C File Offset: 0x0009D50C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (252958 - 578887 != -325928)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (205385 - 388566 != -183180)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (5768 - 421704 == -415936)
				{
					if (253680 - 441045 != -187364)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (35804 - 31799 == 4006)
							{
								continue;
							}
							v = 1;
							if (270147 - 348992 != -78845)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (13898 - 508304 == -494405)
							{
								continue;
							}
							v = -1;
							if (278157 - 18532 == 259626)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (255637 - 498248 != -242611)
							{
								continue;
							}
							v = 2;
							if (68753 - 467648 != -398895)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack_hit")
						{
							if (13523 - 253744 != -240221)
							{
								continue;
							}
							v = -2;
							if (285014 - 396944 != -111930)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_genesisSeed")
						{
							if (251228 - 355711 != -104483)
							{
								continue;
							}
							v = 11;
							if (21274 - 474767 != -453493)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nemesisLarva")
						{
							if (276162 - 455670 == -179507)
							{
								continue;
							}
							v = 21;
							if (215732 - 54705 != 161027)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_chaosRay")
						{
							if (229102 - 464087 != -234985)
							{
								continue;
							}
							v = 31;
							if (77589 - 307285 == -229695)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_turn")
						{
							if (7496 - 553052 == -545555)
							{
								continue;
							}
							v = 91;
							if (233663 - 553458 != -319795)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (58267 - 492832 != -434565)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (141867 - 330693 != -188825)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (138967 - 272532 != -133564)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (88495 - 342305 != -253809)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (143755 - 39041 == 104714)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (117394 - 150132 == -32738)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (4366 - 36346 != -31979)
											{
												Hashtable hashtable = new Hashtable();
												if (114229 - 404214 != -289984)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (136414 - 513005 == -376591)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (165457 - 438375 == -272918)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (33965 - 51228 != -17262)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (296692 - 146487 == 150205)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (141023 - 547207 == -406184)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (54863 - 527145 == -472282)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (12811 - 403737 == -390926)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (184535 - 529854 != -345318)
																				{
																					PhotonClient.SendEvent(this.jkJnG4aliW.ActorNr, 74, hashtable, true, true);
																					if (899 - 224015 != -223115)
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

	// Token: 0x060005FE RID: 1534 RVA: 0x0009F950 File Offset: 0x0009DB50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (123342 - 510209 != -386867)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (53019 - 150535 == -97516)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (46073 - 586524 != -540450)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (252374 - 278417 != -26042)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (28904 - 108632 == -79728)
						{
							int num3 = num;
							if (186599 - 497708 != -311108)
							{
								if (num3 == 1)
								{
									if (107374 - 74909 != 32466)
									{
										if (this.jkJnG4aliW.isMine)
										{
											break;
										}
										if (42078 - 290023 != -247944)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (274930 - 322226 == -47296)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (261980 - 560647 != -298666)
									{
										if (this.jkJnG4aliW.isMine)
										{
											break;
										}
										if (63060 - 359195 == -296135)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (191539 - 552131 == -360592)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (172464 - 381292 != -208827)
									{
										if (this.jkJnG4aliW.isMine)
										{
											break;
										}
										if (279054 - 91631 == 187423)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (72264 - 491783 == -419519)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (267912 - 326491 != -58578)
									{
										if (this.jkJnG4aliW.isMine)
										{
											break;
										}
										if (219818 - 403446 == -183628)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (291215 - 532616 != -241400)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (114699 - 337909 != -223209)
									{
										if (this.jkJnG4aliW.isMine)
										{
											break;
										}
										if (104027 - 136106 == -32079)
										{
											this.StartCoroutine_Auto(this.RPC_genesisSeed(vector, vector2, num2));
											if (229532 - 417368 == -187836)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (281468 - 457104 != -175635)
									{
										if (this.jkJnG4aliW.isMine)
										{
											break;
										}
										if (118257 - 547993 == -429736)
										{
											this.StartCoroutine_Auto(this.RPC_nemesisLarva(vector, vector2, num2));
											if (171677 - 431486 != -259808)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (242068 - 375815 != -133746)
									{
										if (this.jkJnG4aliW.isMine)
										{
											break;
										}
										if (65625 - 271544 == -205919)
										{
											this.StartCoroutine_Auto(this.RPC_chaosRay(vector, vector2, num2));
											if (12136 - 121264 != -109127)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 91)
								{
									if (187871 - 268401 == -80530)
									{
										if (this.jkJnG4aliW.isMine)
										{
											break;
										}
										if (83242 - 259507 == -176265)
										{
											this.RPC_turn(vector, vector2, num2);
											if (149672 - 294195 != -144522)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (213660 - 25733 == 187927)
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

	// Token: 0x060005FF RID: 1535 RVA: 0x0009FEBC File Offset: 0x0009E0BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_turn(Vector3 mPos, Vector3 tDir, int tID)
	{
		Debug.Log("Turn@" + tDir);
		this.mNetworkRotation = tDir;
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x0009FEDC File Offset: 0x0009E0DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (270556 - 59026 != 211530)
		{
		}
		for (;;)
		{
			this.jkJnG4aliW.actionState = "standby";
			if (19000 - 19754 == -754)
			{
				this.jkJnG4aliW.moveSpeed = (float)0;
				if (13263 - 407227 != -393963)
				{
					this.animation.CrossFade("root", 0.2f);
					if (187941 - 77006 == 110935)
					{
						this.animation.wrapMode = WrapMode.Loop;
						if (263914 - 158567 == 105347)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x0009FFBC File Offset: 0x0009E1BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (52078 - 545424 != -493346)
		{
		}
		for (;;)
		{
			if (!this.jkJnG4aliW.isMine)
			{
				if (35877 - 430776 != -394898)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (203931 - 212442 == -8511)
				{
					Vector3 vector = a - this.transform.position;
					if (193185 - 93114 == 100071)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (299429 - 350735 != -51305)
						{
							CharacterControl characterControl = null;
							if (68458 - 523364 != -454905)
							{
								int tID = 0;
								if (199200 - 475381 != -276180)
								{
									if (gameObject)
									{
										if (194429 - 557303 == -362873)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (278245 - 16429 != 261816)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (273612 - 285632 != -12020)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (42072 - 53183 == -11110)
										{
											continue;
										}
									}
									if (!(this.jkJnG4aliW.actionState == "standby"))
									{
										if (279993 - 589493 != -309500)
										{
											continue;
										}
										if (!(this.jkJnG4aliW.actionState == "run"))
										{
											break;
										}
										if (283223 - 268374 == 14850)
										{
											continue;
										}
									}
									if (this.jkJnG4aliW.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (131515 - 581555 == -450040)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, tID));
										if (4765 - 388734 == -383969)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (85942 - 475970 != -390027)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
												if (156465 - 297585 == -141120)
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

	// Token: 0x06000602 RID: 1538 RVA: 0x000A02B8 File Offset: 0x0009E4B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (222888 - 65155 != 157734)
		{
		}
		for (;;)
		{
			if (!this.jkJnG4aliW.isMine)
			{
				if (26978 - 145232 != -118253)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (271953 - 494994 != -223040)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (231107 - 387116 != -156008)
					{
						Vector3 normalized = vector.normalized;
						if (270913 - 345317 == -74404)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (256039 - 196495 != 59545)
							{
								CharacterControl characterControl = null;
								if (260871 - 529343 != -268471)
								{
									int tID = 0;
									if (2632 - 148189 != -145556)
									{
										if (gameObject)
										{
											if (112154 - 387432 == -275277)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (147340 - 318609 == -171268)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (109006 - 577801 == -468794)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (270234 - 372827 != -102593)
											{
												continue;
											}
										}
										if (!(this.jkJnG4aliW.actionState == "standby"))
										{
											if (116022 - 170556 == -54533)
											{
												continue;
											}
											if (!(this.jkJnG4aliW.actionState == "run"))
											{
												break;
											}
											if (130956 - 2070 == 128887)
											{
												continue;
											}
										}
										if (this.jkJnG4aliW.isTimeOut("chaosRay") == (float)0)
										{
											if (14567 - 369309 != -354741)
											{
												this.StartCoroutine_Auto(this.RPC_chaosRay(this.transform.position, this.transform.forward, 0));
												if (72392 - 157710 == -85318)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (7909 - 23272 != -15362)
													{
														this.ActionEvent("RPC_chaosRay", this.transform.position, this.transform.forward, 0);
														if (204841 - 203854 != 988)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											if (this.jkJnG4aliW.isTimeOut("cAttack") != (float)0)
											{
												break;
											}
											if (289066 - 138843 != 150224)
											{
												this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, tID));
												if (61762 - 374805 == -313043)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (34607 - 319871 != -285263)
													{
														this.ActionEvent("RPC_cAttack", this.transform.position, normalized, tID);
														if (119947 - 140400 != -20452)
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

	// Token: 0x06000603 RID: 1539 RVA: 0x000A06B0 File Offset: 0x0009E8B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x000A06B4 File Offset: 0x0009E8B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NemesisBug.$RPC_nAttack$16268(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x000A06C4 File Offset: 0x0009E8C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (90153 - 382034 != -291880)
		{
		}
		for (;;)
		{
			IL_86:
			if (this.nAttack_hit)
			{
				if (183790 - 384361 == -200570)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
				if (245942 - 532585 == -286642)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing nAttack hit effect ");
				if (105025 - 262659 != -157634)
				{
					continue;
				}
			}
			if (!this.jkJnG4aliW.isMine)
			{
				break;
			}
			if (39318 - 302801 != -263482)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (121028 - 109752 != 11277)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)8, (float)3, layerMask);
					if (134887 - 106456 != 28432)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (118944 - 456180 == -337236)
						{
							while (enumerator.MoveNext())
							{
								object obj2 = enumerator.Current;
								object obj4;
								object obj3 = obj4 = obj2;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj4;
								if (174990 - 33065 != 141925)
								{
									goto IL_86;
								}
								hitDir = global::Math.vFlat(gameObject.transform.position - hitPos);
								if (207592 - 446945 != -239353)
								{
									goto IL_86;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (15569 - 350066 == -334496)
								{
									goto IL_86;
								}
								float num = (float)1 - 0.1f * hitDir.magnitude;
								if (108267 - 60180 != 48087)
								{
									goto IL_86;
								}
								this.jkJnG4aliW.hit(1, gameObject, (int)(num * (float)this.jkJnG4aliW.atk), 1, 0, 0.5f * hitDir);
								if (114746 - 89067 == 25680)
								{
									goto IL_86;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (87650 - 293370 == -205719)
								{
									goto IL_86;
								}
							}
							if (256318 - 480138 != -223819)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x000A097C File Offset: 0x0009EB7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NemesisBug.$RPC_cAttack$16275(mPos, this).GetEnumerator();
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x000A098C File Offset: 0x0009EB8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (115058 - 553967 != -438909)
		{
		}
		for (;;)
		{
			IL_178:
			if (this.cAttack_hit)
			{
				if (232330 - 516487 != -284157)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, this.transform.rotation);
				if (231822 - 19071 != 212751)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing cAttack hit effect ");
				if (179600 - 485808 == -306207)
				{
					continue;
				}
			}
			if (!this.jkJnG4aliW.isMine)
			{
				break;
			}
			if (194524 - 110581 == 83943)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (146818 - 101789 == 45029)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)5, (float)3, layerMask);
					if (183020 - 396641 != -213620)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (46699 - 489148 == -442449)
						{
							while (enumerator.MoveNext())
							{
								object obj2 = enumerator.Current;
								object obj4;
								object obj3 = obj4 = obj2;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj4;
								if (219878 - 187599 != 32279)
								{
									goto IL_178;
								}
								hitDir = global::Math.vFlat(gameObject.transform.position - hitPos);
								if (205494 - 66252 == 139243)
								{
									goto IL_178;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (233951 - 413896 == -179944)
								{
									goto IL_178;
								}
								float num = (float)1 - 0.1f * hitDir.magnitude;
								if (225271 - 62929 != 162342)
								{
									goto IL_178;
								}
								this.jkJnG4aliW.hit(1, gameObject, (int)(num * (float)this.jkJnG4aliW.atk), 1, 0, 0.5f * hitDir);
								if (50888 - 114188 == -63299)
								{
									goto IL_178;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (112622 - 107044 != 5578)
								{
									goto IL_178;
								}
							}
							if (156981 - 119686 == 37295)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x000A0C44 File Offset: 0x0009EE44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_genesisSeed(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NemesisBug.$RPC_genesisSeed$16285(mPos, this).GetEnumerator();
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x000A0C54 File Offset: 0x0009EE54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nemesisLarva(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NemesisBug.$RPC_nemesisLarva$16292(mPos, this).GetEnumerator();
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x000A0C64 File Offset: 0x0009EE64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_chaosRay(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NemesisBug.$RPC_chaosRay$16301(mPos, this).GetEnumerator();
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x000A0C74 File Offset: 0x0009EE74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new NemesisBug.$RPC_ko$16326(nArray, this).GetEnumerator();
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x000A0C84 File Offset: 0x0009EE84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new NemesisBug.$RPC_dead$16333(nArray, this).GetEnumerator();
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x000A0C94 File Offset: 0x0009EE94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x000A0C98 File Offset: 0x0009EE98
	internal static bool HGbRFRUD0asrCNxRMwB()
	{
		return true;
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x000A0C9C File Offset: 0x0009EE9C
	internal static bool pp7cKJUvI59s8wcnx2x()
	{
		return false;
	}

	// Token: 0x04000582 RID: 1410
	private CharacterControl jkJnG4aliW;

	// Token: 0x04000583 RID: 1411
	private CharacterControl VXCn1n4dvB;

	// Token: 0x04000584 RID: 1412
	private CharacterControl mHvnq6bNSL;

	// Token: 0x04000585 RID: 1413
	public Vector3 mNetworkRotation;

	// Token: 0x04000586 RID: 1414
	public GameObject nAttack_ring;

	// Token: 0x04000587 RID: 1415
	public GameObject nAttack_hit;

	// Token: 0x04000588 RID: 1416
	public GameObject cAttack_ring;

	// Token: 0x04000589 RID: 1417
	public GameObject cAttack_hit;

	// Token: 0x0400058A RID: 1418
	public GameObject genesisSeed_ring;

	// Token: 0x0400058B RID: 1419
	public GameObject nemesisLarva_ring;

	// Token: 0x0400058C RID: 1420
	public GameObject chaosRay;

	// Token: 0x0400058D RID: 1421
	public GameObject chaosRay_hit;

	// Token: 0x0400058E RID: 1422
	public GameObject chaosRay_ring;

	// Token: 0x0400058F RID: 1423
	public AudioClip nemesis_cry;

	// Token: 0x04000590 RID: 1424
	public GameObject deadEffect;

	// Token: 0x0200010E RID: 270
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$16268 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000610 RID: 1552 RVA: 0x000A0CA0 File Offset: 0x0009EEA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$16268(Vector3 mPos, Vector3 tDir, NemesisBug self_)
		{
			if (34383 - 467280 != -432897)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (281380 - 199765 == 81615)
				{
					base..ctor();
					if (214015 - 381837 != -167821)
					{
						this.$mPos$16272 = mPos;
						if (262533 - 198588 != 63946)
						{
							this.$tDir$16273 = tDir;
							if (247138 - 22294 == 224844)
							{
								this.$self_$16274 = self_;
								if (99750 - 392746 == -292996)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x000A0D7C File Offset: 0x0009EF7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NemesisBug.$RPC_nAttack$16268.$(this.$mPos$16272, this.$tDir$16273, this.$self_$16274);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x000A0D98 File Offset: 0x0009EF98
		internal static bool vZv4fVURjuxeXgosdy4()
		{
			return true;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x000A0D9C File Offset: 0x0009EF9C
		internal static bool NUsdrlUwTEi1qcPrFPo()
		{
			return false;
		}

		// Token: 0x04000591 RID: 1425
		internal Vector3 $mPos$16272;

		// Token: 0x04000592 RID: 1426
		internal Vector3 $tDir$16273;

		// Token: 0x04000593 RID: 1427
		internal NemesisBug $self_$16274;

		// Token: 0x0200010F RID: 271
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000614 RID: 1556 RVA: 0x000A0DA0 File Offset: 0x0009EFA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, NemesisBug self_)
			{
				if (101128 - 171386 != -70258)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (228791 - 474177 != -245385)
					{
						base..ctor();
						if (143597 - 212620 != -69022)
						{
							this.$mPos$16269 = mPos;
							if (163293 - 438916 != -275622)
							{
								this.$tDir$16270 = tDir;
								if (31249 - 108392 != -77142)
								{
									this.$self_$16271 = self_;
									if (52873 - 229933 == -177060)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000615 RID: 1557 RVA: 0x000A0E7C File Offset: 0x0009F07C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (131515 - 476062 != -344547)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5A8;
					case 2:
						if (this.$self_$16271.jkJnG4aliW.actionState != "attack")
						{
							goto IL_574;
						}
						if (47960 - 131694 == -83733)
						{
							continue;
						}
						if (this.$self_$16271.jkJnG4aliW.myCommand != "nAttack")
						{
							if (2534 - 157689 != -155154)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							if (!this.$self_$16271.jkJnG4aliW.isMine)
							{
								goto IL_168;
							}
							if (140207 - 134762 != 5445)
							{
								continue;
							}
							this.$self_$16271.RPC_nAttack_hit(this.$mPos$16269 + this.$tDir$16270, this.$self_$16271.transform.forward, 0);
							if (292864 - 399637 == -106772)
							{
								continue;
							}
							this.$self_$16271.ActionEvent("RPC_nAttack_hit", this.$mPos$16269 + this.$tDir$16270, this.$self_$16271.transform.forward, 0);
							if (63990 - 315548 != -251557)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16271.jkJnG4aliW.actionState == "attack")
						{
							if (82443 - 393050 == -310606)
							{
								continue;
							}
							if (this.$self_$16271.jkJnG4aliW.myCommand == "nAttack")
							{
								if (207569 - 91192 == 116378)
								{
									continue;
								}
								this.$self_$16271.jkJnG4aliW.actionState = "standby";
								if (43709 - 348158 == -304448)
								{
									continue;
								}
								this.$self_$16271.jkJnG4aliW.actionTime = Time.time;
								if (75940 - 18170 != 57770)
								{
									continue;
								}
								this.$self_$16271.jkJnG4aliW.myCommand = "none";
								if (187681 - 326868 != -139187)
								{
									continue;
								}
								if (!this.$self_$16271.jkJnG4aliW.isMine)
								{
									if (42000 - 446328 != -404328)
									{
										continue;
									}
									this.$self_$16271.jkJnG4aliW.nPosition = this.$self_$16271.transform.position;
									if (236384 - 193222 != 43162)
									{
										continue;
									}
									this.$self_$16271.jkJnG4aliW.oPosition = this.$self_$16271.transform.position;
									if (28498 - 240418 != -211920)
									{
										continue;
									}
									this.$self_$16271.jkJnG4aliW.nDirection = this.$self_$16271.transform.forward;
									if (288753 - 231981 != 56772)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (287375 - 138353 != 149022)
						{
							continue;
						}
						goto IL_5A8;
					default:
						if (217644 - 56489 == 161156)
						{
							continue;
						}
						break;
					}
					this.$self_$16271.jkJnG4aliW.actionState = "attack";
					if (10625 - 284450 != -273824)
					{
						this.$self_$16271.jkJnG4aliW.actionTime = Time.time;
						if (289100 - 279673 == 9427)
						{
							this.$self_$16271.jkJnG4aliW.myCommand = "nAttack";
							if (242565 - 378808 == -136243)
							{
								this.$self_$16271.jkJnG4aliW.addTimeOut("nAttack", (float)4);
								if (299603 - 509864 != -210260)
								{
									this.$self_$16271.transform.LookAt(this.$mPos$16269);
									if (288511 - 155555 != 132957)
									{
										this.$self_$16271.animation.CrossFade("nAttack");
										if (168948 - 575613 == -406665)
										{
											this.$self_$16271.animation.wrapMode = WrapMode.Once;
											if (239258 - 14921 != 224338)
											{
												if (this.$self_$16271.nAttack_ring)
												{
													if (268731 - 295426 != -26694)
													{
														this.$self_$16271.jkJnG4aliW.createEffect(this.$self_$16271.nAttack_ring, this.$self_$16271.transform.position, this.$self_$16271.transform.rotation);
														if (244539 - 440927 == -196388)
														{
															break;
														}
													}
												}
												else
												{
													Debug.LogError("Missing nAttack_ring effect ");
													if (49545 - 356695 == -307150)
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
				goto IL_250;
				IL_168:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_13:
				goto IL_574;
				IL_250:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_30:
				goto IL_168;
				IL_574:
				IL_5A8:
				return false;
			}

			// Token: 0x06000616 RID: 1558 RVA: 0x000A1444 File Offset: 0x0009F644
			internal static bool nKyXnGUq4U0BXWLE2ia()
			{
				return true;
			}

			// Token: 0x06000617 RID: 1559 RVA: 0x000A1448 File Offset: 0x0009F648
			internal static bool viR9bIU7AZEBoWLP8d9()
			{
				return false;
			}

			// Token: 0x04000594 RID: 1428
			internal Vector3 $mPos$16269;

			// Token: 0x04000595 RID: 1429
			internal Vector3 $tDir$16270;

			// Token: 0x04000596 RID: 1430
			internal NemesisBug $self_$16271;
		}
	}

	// Token: 0x02000110 RID: 272
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$16275 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000618 RID: 1560 RVA: 0x000A144C File Offset: 0x0009F64C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$16275(Vector3 mPos, NemesisBug self_)
		{
			if (92828 - 186588 != -93759)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (33174 - 540226 == -507052)
				{
					base..ctor();
					if (84277 - 83486 != 792)
					{
						this.$mPos$16283 = mPos;
						if (264259 - 568181 != -303921)
						{
							this.$self_$16284 = self_;
							if (275724 - 19058 != 256667)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000A1508 File Offset: 0x0009F708
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NemesisBug.$RPC_cAttack$16275.$(this.$mPos$16283, this.$self_$16284);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000A151C File Offset: 0x0009F71C
		internal static bool YcdNlQUPp8BlBgGKmwx()
		{
			return true;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000A1520 File Offset: 0x0009F720
		internal static bool pGb0xNU0OBOfHSwis7U()
		{
			return false;
		}

		// Token: 0x04000597 RID: 1431
		internal Vector3 $mPos$16283;

		// Token: 0x04000598 RID: 1432
		internal NemesisBug $self_$16284;

		// Token: 0x02000111 RID: 273
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600061C RID: 1564 RVA: 0x000A1524 File Offset: 0x0009F724
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, NemesisBug self_)
			{
				if (204748 - 451916 != -247168)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (262783 - 336389 != -73605)
					{
						base..ctor();
						if (286062 - 587285 == -301223)
						{
							this.$mPos$16281 = mPos;
							if (264954 - 487377 != -222422)
							{
								this.$self_$16282 = self_;
								if (82462 - 241884 == -159422)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600061D RID: 1565 RVA: 0x000A15E0 File Offset: 0x0009F7E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (278333 - 133047 != 145286)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_816;
					case 2:
						if (this.$self_$16282.jkJnG4aliW.actionState != "attack")
						{
							goto IL_1E5;
						}
						if (284143 - 265220 == 18924)
						{
							continue;
						}
						if (this.$self_$16282.jkJnG4aliW.myCommand != "cAttack")
						{
							if (219922 - 320752 != -100830)
							{
								continue;
							}
							goto IL_1E5;
						}
						else
						{
							this.$i$16276 = 0;
							if (250557 - 132234 != 118323)
							{
								continue;
							}
							goto IL_5FD;
						}
						break;
					case 3:
						if (this.$self_$16282.jkJnG4aliW.actionState != "attack")
						{
							goto IL_28A;
						}
						if (60477 - 237519 == -177041)
						{
							continue;
						}
						if (this.$self_$16282.jkJnG4aliW.myCommand != "cAttack")
						{
							if (63376 - 508019 != -444643)
							{
								continue;
							}
							goto IL_28A;
						}
						else
						{
							this.$i$16276++;
							if (280494 - 297856 != -17361)
							{
								goto IL_5FD;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$16282.jkJnG4aliW.actionState == "attack")
						{
							if (150365 - 154794 == -4428)
							{
								continue;
							}
							if (this.$self_$16282.jkJnG4aliW.myCommand == "cAttack")
							{
								if (23544 - 549657 != -526113)
								{
									continue;
								}
								this.$self_$16282.jkJnG4aliW.actionState = "standby";
								if (210024 - 65637 != 144387)
								{
									continue;
								}
								this.$self_$16282.jkJnG4aliW.actionTime = Time.time;
								if (82736 - 115465 != -32729)
								{
									continue;
								}
								this.$self_$16282.jkJnG4aliW.myCommand = "none";
								if (72494 - 402352 == -329857)
								{
									continue;
								}
								if (!this.$self_$16282.jkJnG4aliW.isMine)
								{
									if (286099 - 105441 != 180658)
									{
										continue;
									}
									this.$self_$16282.jkJnG4aliW.nPosition = this.$self_$16282.transform.position;
									if (189135 - 183863 != 5272)
									{
										continue;
									}
									this.$self_$16282.jkJnG4aliW.oPosition = this.$self_$16282.transform.position;
									if (235847 - 152611 != 83236)
									{
										continue;
									}
									this.$self_$16282.jkJnG4aliW.nDirection = this.$self_$16282.transform.forward;
									if (147702 - 439725 != -292023)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (49701 - 10067 != 39635)
						{
							goto Block_9;
						}
						continue;
					default:
						if (165356 - 280263 != -114907)
						{
							continue;
						}
						break;
					}
					this.$self_$16282.jkJnG4aliW.actionState = "attack";
					if (275960 - 421318 == -145357)
					{
						continue;
					}
					this.$self_$16282.jkJnG4aliW.actionTime = Time.time;
					if (59343 - 144722 == -85378)
					{
						continue;
					}
					this.$self_$16282.jkJnG4aliW.myCommand = "cAttack";
					if (211768 - 356760 != -144992)
					{
						continue;
					}
					this.$self_$16282.jkJnG4aliW.addTimeOut("cAttack", (float)16);
					if (41714 - 137488 == -95773)
					{
						continue;
					}
					this.$self_$16282.transform.LookAt(this.$mPos$16281);
					if (99614 - 418219 == -318604)
					{
						continue;
					}
					this.$self_$16282.animation.CrossFade("cAttack");
					if (167357 - 495830 != -328473)
					{
						continue;
					}
					this.$self_$16282.animation.wrapMode = WrapMode.Once;
					if (174708 - 235400 != -60692)
					{
						continue;
					}
					if (this.$self_$16282.cAttack_ring)
					{
						if (167498 - 429520 != -262022)
						{
							continue;
						}
						this.$self_$16282.jkJnG4aliW.createEffect(this.$self_$16282.cAttack_ring, this.$self_$16282.transform.position, this.$self_$16282.transform.rotation);
						if (105225 - 380681 != -275455)
						{
							break;
						}
						continue;
					}
					else
					{
						Debug.LogError("Missing cAttack_ring effect ");
						if (246726 - 516572 != -269845)
						{
							break;
						}
						continue;
					}
					IL_5FD:
					if (this.$i$16276 >= 6)
					{
						if (224339 - 322003 == -97664)
						{
							goto IL_57C;
						}
					}
					else
					{
						if (!this.$self_$16282.jkJnG4aliW.isMine)
						{
							goto IL_47F;
						}
						if (224481 - 43635 != 180847)
						{
							this.$hitLayer$16277 = 130816 - (1 << this.$self_$16282.gameObject.layer);
							if (200467 - 229437 != -28969)
							{
								this.$hitList$16278 = Damage.RemoveDeadChar(Damage.FindAreaTarget(this.$self_$16282.transform.position, (float)80, (float)12, this.$hitLayer$16277));
								if (50096 - 9442 == 40654)
								{
									if (this.$hitList$16278.length <= 0)
									{
										goto IL_47F;
									}
									if (203175 - 285020 != -81844)
									{
										object obj2;
										object obj = obj2 = this.$hitList$16278[UnityEngine.Random.Range(0, this.$hitList$16278.length)];
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										this.$hitObject$16279 = (GameObject)obj2;
										if (105319 - 578918 != -473598)
										{
											if (!this.$hitObject$16279)
											{
												goto IL_47F;
											}
											if (123077 - 474780 != -351702)
											{
												this.$hitPos$16280 = this.$hitObject$16279.transform.position + new Vector3((float)(UnityEngine.Random.Range(0, 5) - 2), (float)0, (float)(UnityEngine.Random.Range(0, 5) - 2));
												if (1484 - 219045 != -217560)
												{
													this.$self_$16282.RPC_cAttack_hit(this.$hitPos$16280, this.$self_$16282.transform.forward, 0);
													if (27328 - 124264 != -96935)
													{
														this.$self_$16282.ActionEvent("RPC_cAttack_hit", this.$hitPos$16280, this.$self_$16282.transform.forward, 0);
														if (249244 - 196517 == 52727)
														{
															goto IL_47F;
														}
													}
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
				return this.Yield(2, new WaitForSeconds(1f));
				Block_9:
				IL_1E5:
				goto IL_816;
				goto IL_1A;
				IL_28A:
				goto IL_816;
				IL_47F:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_57C:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_816:
				return false;
			}

			// Token: 0x0600061E RID: 1566 RVA: 0x000A1E18 File Offset: 0x000A0018
			internal static bool KAjvCeUblSqgeCaR3pH()
			{
				return true;
			}

			// Token: 0x0600061F RID: 1567 RVA: 0x000A1E1C File Offset: 0x000A001C
			internal static bool NYnMINUuhbcQ7YWqSjm()
			{
				return false;
			}

			// Token: 0x04000599 RID: 1433
			internal int $i$16276;

			// Token: 0x0400059A RID: 1434
			internal int $hitLayer$16277;

			// Token: 0x0400059B RID: 1435
			internal UnityScript.Lang.Array $hitList$16278;

			// Token: 0x0400059C RID: 1436
			internal GameObject $hitObject$16279;

			// Token: 0x0400059D RID: 1437
			internal Vector3 $hitPos$16280;

			// Token: 0x0400059E RID: 1438
			internal Vector3 $mPos$16281;

			// Token: 0x0400059F RID: 1439
			internal NemesisBug $self_$16282;
		}
	}

	// Token: 0x02000112 RID: 274
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_genesisSeed$16285 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000620 RID: 1568 RVA: 0x000A1E20 File Offset: 0x000A0020
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_genesisSeed$16285(Vector3 mPos, NemesisBug self_)
		{
			if (170424 - 353094 != -182669)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (38708 - 518681 == -479973)
				{
					base..ctor();
					if (18429 - 258871 != -240441)
					{
						this.$mPos$16290 = mPos;
						if (155195 - 161760 == -6565)
						{
							this.$self_$16291 = self_;
							if (272723 - 62894 == 209829)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x000A1EDC File Offset: 0x000A00DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NemesisBug.$RPC_genesisSeed$16285.$(this.$mPos$16290, this.$self_$16291);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x000A1EF0 File Offset: 0x000A00F0
		internal static bool KS4AthUIskijZfwN0mh()
		{
			return true;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000A1EF4 File Offset: 0x000A00F4
		internal static bool WX4rYbUBjkOhBBJiKA1()
		{
			return false;
		}

		// Token: 0x040005A0 RID: 1440
		internal Vector3 $mPos$16290;

		// Token: 0x040005A1 RID: 1441
		internal NemesisBug $self_$16291;

		// Token: 0x02000113 RID: 275
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000624 RID: 1572 RVA: 0x000A1EF8 File Offset: 0x000A00F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, NemesisBug self_)
			{
				if (220193 - 474872 != -254678)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (134636 - 540654 != -406017)
					{
						base..ctor();
						if (111355 - 119535 == -8180)
						{
							this.$mPos$16288 = mPos;
							if (268359 - 350312 == -81953)
							{
								this.$self_$16289 = self_;
								if (207590 - 199042 == 8548)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000625 RID: 1573 RVA: 0x000A1FB4 File Offset: 0x000A01B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (178334 - 402763 != -224429)
				{
				}
				for (;;)
				{
					IL_5F2:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_677;
					case 2:
						if (this.$self_$16289.jkJnG4aliW.actionState != "attack")
						{
							goto IL_4CB;
						}
						if (294433 - 262725 != 31708)
						{
							continue;
						}
						if (this.$self_$16289.jkJnG4aliW.myCommand != "genesisSeed")
						{
							if (135438 - 322643 != -187205)
							{
								continue;
							}
							goto IL_4CB;
						}
						else
						{
							if (!this.$self_$16289.jkJnG4aliW.isMine)
							{
								goto IL_2F2;
							}
							if (136162 - 337612 == -201449)
							{
								continue;
							}
							this.$i$16286 = 0;
							if (159631 - 275326 == -115694)
							{
								continue;
							}
							while (this.$i$16286 < 6)
							{
								this.$spawnPos$16287 = global::Math.getSpawnPos(this.$self_$16289.transform.position + global::Math.rotateH((float)30 * this.$self_$16289.transform.forward, (float)(this.$i$16286 * 60)));
								if (74837 - 279522 != -204685)
								{
									goto IL_5F2;
								}
								if (this.$spawnPos$16287 != Vector3.zero)
								{
									if (163719 - 188686 != -24967)
									{
										goto IL_5F2;
									}
									Camera.main.SendMessage("onGenesisSeed", this.$spawnPos$16287);
									if (289919 - 498744 == -208824)
									{
										goto IL_5F2;
									}
								}
								else
								{
									Debug.LogError("Warning Cannot find spawnPos for genesisSeed");
									if (24843 - 480612 != -455769)
									{
										goto IL_5F2;
									}
								}
								this.$i$16286++;
								if (187195 - 44517 == 142679)
								{
									goto IL_5F2;
								}
							}
							if (286909 - 315637 != -28728)
							{
								continue;
							}
							goto IL_2F2;
						}
						break;
					case 3:
						if (this.$self_$16289.jkJnG4aliW.actionState == "attack")
						{
							if (187138 - 477914 == -290775)
							{
								continue;
							}
							if (this.$self_$16289.jkJnG4aliW.myCommand == "genesisSeed")
							{
								if (231036 - 496773 == -265736)
								{
									continue;
								}
								this.$self_$16289.jkJnG4aliW.actionState = "standby";
								if (83634 - 430044 == -346409)
								{
									continue;
								}
								this.$self_$16289.jkJnG4aliW.actionTime = Time.time;
								if (214871 - 8367 != 206504)
								{
									continue;
								}
								this.$self_$16289.jkJnG4aliW.myCommand = "none";
								if (57378 - 217007 == -159628)
								{
									continue;
								}
								if (!this.$self_$16289.jkJnG4aliW.isMine)
								{
									if (125736 - 544473 != -418737)
									{
										continue;
									}
									this.$self_$16289.jkJnG4aliW.nPosition = this.$self_$16289.transform.position;
									if (148710 - 173431 == -24720)
									{
										continue;
									}
									this.$self_$16289.jkJnG4aliW.oPosition = this.$self_$16289.transform.position;
									if (259991 - 346236 != -86245)
									{
										continue;
									}
									this.$self_$16289.jkJnG4aliW.nDirection = this.$self_$16289.transform.forward;
									if (236434 - 474757 == -238322)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (24513 - 493393 != -468880)
						{
							continue;
						}
						goto IL_677;
					default:
						if (2392 - 576586 == -574193)
						{
							continue;
						}
						break;
					}
					this.$self_$16289.jkJnG4aliW.actionState = "attack";
					if (107230 - 31578 == 75652)
					{
						this.$self_$16289.jkJnG4aliW.actionTime = Time.time;
						if (143063 - 91424 == 51639)
						{
							this.$self_$16289.jkJnG4aliW.myCommand = "genesisSeed";
							if (8298 - 506756 == -498458)
							{
								this.$self_$16289.jkJnG4aliW.addTimeOut("genesisSeed", (float)45);
								if (162049 - 99094 == 62955)
								{
									this.$self_$16289.transform.LookAt(this.$mPos$16288);
									if (165399 - 164315 != 1085)
									{
										this.$self_$16289.animation.CrossFade("genesis");
										if (149517 - 492969 != -343451)
										{
											this.$self_$16289.animation.wrapMode = WrapMode.Once;
											if (202098 - 241699 != -39600)
											{
												if (this.$self_$16289.genesisSeed_ring)
												{
													if (72126 - 134941 != -62814)
													{
														this.$self_$16289.jkJnG4aliW.createEffect(this.$self_$16289.genesisSeed_ring, this.$self_$16289.transform.position, this.$self_$16289.transform.rotation);
														if (186792 - 454486 == -267694)
														{
															break;
														}
													}
												}
												else
												{
													Debug.LogError("Missing genesisSeed_ring effect ");
													if (261962 - 249798 != 12165)
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
				return this.Yield(2, new WaitForSeconds(1.5f));
				IL_2F2:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_4CB:
				IL_677:
				return false;
			}

			// Token: 0x06000626 RID: 1574 RVA: 0x000A264C File Offset: 0x000A084C
			internal static bool FQvQceUemsZArp9Krpu()
			{
				return true;
			}

			// Token: 0x06000627 RID: 1575 RVA: 0x000A2650 File Offset: 0x000A0850
			internal static bool qdotPKUr5jtlSeFumk8()
			{
				return false;
			}

			// Token: 0x040005A2 RID: 1442
			internal int $i$16286;

			// Token: 0x040005A3 RID: 1443
			internal Vector3 $spawnPos$16287;

			// Token: 0x040005A4 RID: 1444
			internal Vector3 $mPos$16288;

			// Token: 0x040005A5 RID: 1445
			internal NemesisBug $self_$16289;
		}
	}

	// Token: 0x02000114 RID: 276
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nemesisLarva$16292 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000628 RID: 1576 RVA: 0x000A2654 File Offset: 0x000A0854
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nemesisLarva$16292(Vector3 mPos, NemesisBug self_)
		{
			if (67773 - 124354 != -56581)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (92082 - 520252 == -428170)
				{
					base..ctor();
					if (80905 - 352341 == -271436)
					{
						this.$mPos$16299 = mPos;
						if (39973 - 131033 == -91060)
						{
							this.$self_$16300 = self_;
							if (299654 - 145652 != 154003)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000A2710 File Offset: 0x000A0910
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NemesisBug.$RPC_nemesisLarva$16292.$(this.$mPos$16299, this.$self_$16300);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x000A2724 File Offset: 0x000A0924
		internal static bool toViCZUjLYvmBP141pr()
		{
			return true;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x000A2728 File Offset: 0x000A0928
		internal static bool hvO0jDUh8wb5vcFX1pw()
		{
			return false;
		}

		// Token: 0x040005A6 RID: 1446
		internal Vector3 $mPos$16299;

		// Token: 0x040005A7 RID: 1447
		internal NemesisBug $self_$16300;

		// Token: 0x02000115 RID: 277
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600062C RID: 1580 RVA: 0x000A272C File Offset: 0x000A092C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, NemesisBug self_)
			{
				if (288035 - 567438 != -279403)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (154663 - 89627 != 65037)
					{
						base..ctor();
						if (163951 - 522107 != -358155)
						{
							this.$mPos$16297 = mPos;
							if (248080 - 242554 != 5527)
							{
								this.$self_$16298 = self_;
								if (267494 - 390407 == -122913)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600062D RID: 1581 RVA: 0x000A27E8 File Offset: 0x000A09E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (245582 - 146547 != 99035)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6ED;
					case 2:
						if (this.$self_$16298.jkJnG4aliW.actionState != "attack")
						{
							goto IL_645;
						}
						if (180248 - 491349 == -311100)
						{
							continue;
						}
						if (this.$self_$16298.jkJnG4aliW.myCommand != "nemesisLarva")
						{
							if (5536 - 531278 != -525742)
							{
								continue;
							}
							goto IL_645;
						}
						else
						{
							if (!this.$self_$16298.jkJnG4aliW.isMine)
							{
								goto IL_3BF;
							}
							if (96831 - 368652 == -271820)
							{
								continue;
							}
							this.$hitLayer$16293 = 130816 - (1 << this.$self_$16298.gameObject.layer);
							if (281956 - 398510 == -116553)
							{
								continue;
							}
							this.$hitList$16294 = Damage.RemoveDeadChar(Damage.FindAreaTarget(this.$self_$16298.transform.position, (float)50, (float)12, this.$hitLayer$16293));
							if (257066 - 582484 == -325417)
							{
								continue;
							}
							if (this.$hitList$16294.length <= 0)
							{
								goto IL_3BF;
							}
							if (56397 - 5016 == 51382)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = this.$hitList$16294[UnityEngine.Random.Range(0, this.$hitList$16294.length)];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$16295 = (GameObject)obj2;
							if (89074 - 298814 != -209740)
							{
								continue;
							}
							if (!this.$hitObject$16295)
							{
								goto IL_3BF;
							}
							if (34035 - 160358 == -126322)
							{
								continue;
							}
							this.$hitChar$16296 = (CharacterControl)this.$hitObject$16295.GetComponent(typeof(CharacterControl));
							if (25044 - 192418 != -167374)
							{
								continue;
							}
							if (!this.$hitChar$16296)
							{
								goto IL_3BF;
							}
							if (50370 - 465045 == -414674)
							{
								continue;
							}
							this.$hitChar$16296.RPC_AddStatus("nemesisLarva", 1, 600, 600, this.$self_$16298.jkJnG4aliW.ActorNr);
							if (18948 - 543310 != -524361)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16298.jkJnG4aliW.actionState == "attack")
						{
							if (226548 - 325782 == -99233)
							{
								continue;
							}
							if (this.$self_$16298.jkJnG4aliW.myCommand == "nemesisLarva")
							{
								if (60841 - 227309 != -166468)
								{
									continue;
								}
								this.$self_$16298.jkJnG4aliW.actionState = "standby";
								if (89761 - 92557 != -2796)
								{
									continue;
								}
								this.$self_$16298.jkJnG4aliW.actionTime = Time.time;
								if (234143 - 186797 != 47346)
								{
									continue;
								}
								this.$self_$16298.jkJnG4aliW.myCommand = "none";
								if (57281 - 365061 != -307780)
								{
									continue;
								}
								if (!this.$self_$16298.jkJnG4aliW.isMine)
								{
									if (133189 - 173961 == -40771)
									{
										continue;
									}
									this.$self_$16298.jkJnG4aliW.nPosition = this.$self_$16298.transform.position;
									if (12596 - 164104 != -151508)
									{
										continue;
									}
									this.$self_$16298.jkJnG4aliW.oPosition = this.$self_$16298.transform.position;
									if (74164 - 473540 != -399376)
									{
										continue;
									}
									this.$self_$16298.jkJnG4aliW.nDirection = this.$self_$16298.transform.forward;
									if (289358 - 313101 != -23743)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (192551 - 19748 != 172804)
						{
							goto Block_29;
						}
						continue;
					default:
						if (262931 - 421593 != -158662)
						{
							continue;
						}
						break;
					}
					this.$self_$16298.jkJnG4aliW.actionState = "attack";
					if (155986 - 348563 == -192577)
					{
						this.$self_$16298.jkJnG4aliW.actionTime = Time.time;
						if (31948 - 156860 != -124911)
						{
							this.$self_$16298.jkJnG4aliW.myCommand = "nemesisLarva";
							if (179056 - 363313 != -184256)
							{
								this.$self_$16298.jkJnG4aliW.addTimeOut("nemesisLarva", (float)45);
								if (9101 - 461847 == -452746)
								{
									this.$self_$16298.transform.LookAt(this.$mPos$16297);
									if (171939 - 426613 != -254673)
									{
										this.$self_$16298.animation.CrossFade("genesis");
										if (12283 - 221892 != -209608)
										{
											this.$self_$16298.animation.wrapMode = WrapMode.Once;
											if (188939 - 263114 == -74175)
											{
												if (this.$self_$16298.nemesisLarva_ring)
												{
													if (150353 - 567512 != -417158)
													{
														this.$self_$16298.jkJnG4aliW.createEffect(this.$self_$16298.nemesisLarva_ring, this.$self_$16298.transform.position, this.$self_$16298.transform.rotation);
														if (212314 - 221522 == -9208)
														{
															goto IL_4D0;
														}
													}
												}
												else
												{
													Debug.LogError("Missing nemesisLarva_ring effect ");
													if (219719 - 251377 == -31658)
													{
														goto IL_5C7;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_11:
				IL_3BF:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_29:
				goto IL_6ED;
				IL_4D0:
				IL_5C7:
				return this.Yield(2, new WaitForSeconds(1.5f));
				IL_645:
				IL_6ED:
				return false;
			}

			// Token: 0x0600062E RID: 1582 RVA: 0x000A2EF4 File Offset: 0x000A10F4
			internal static bool vKZwJIUskN3ruaDPL8I()
			{
				return true;
			}

			// Token: 0x0600062F RID: 1583 RVA: 0x000A2EF8 File Offset: 0x000A10F8
			internal static bool ojpTbQU97Z5bDhKV8Va()
			{
				return false;
			}

			// Token: 0x040005A8 RID: 1448
			internal int $hitLayer$16293;

			// Token: 0x040005A9 RID: 1449
			internal UnityScript.Lang.Array $hitList$16294;

			// Token: 0x040005AA RID: 1450
			internal GameObject $hitObject$16295;

			// Token: 0x040005AB RID: 1451
			internal CharacterControl $hitChar$16296;

			// Token: 0x040005AC RID: 1452
			internal Vector3 $mPos$16297;

			// Token: 0x040005AD RID: 1453
			internal NemesisBug $self_$16298;
		}
	}

	// Token: 0x02000116 RID: 278
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_chaosRay$16301 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x06000630 RID: 1584 RVA: 0x000A2EFC File Offset: 0x000A10FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_chaosRay$16301(Vector3 mPos, NemesisBug self_)
		{
			if (59033 - 567252 != -508218)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (234728 - 590262 == -355534)
				{
					base..ctor();
					if (236126 - 246168 != -10041)
					{
						this.$mPos$16324 = mPos;
						if (148450 - 158676 != -10225)
						{
							this.$self_$16325 = self_;
							if (41308 - 128925 != -87616)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x000A2FB8 File Offset: 0x000A11B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new NemesisBug.$RPC_chaosRay$16301.$(this.$mPos$16324, this.$self_$16325);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x000A2FCC File Offset: 0x000A11CC
		internal static bool Iqjxi6U1xj8qscpmRsX()
		{
			return true;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000A2FD0 File Offset: 0x000A11D0
		internal static bool m7mGwJU4H87WnvDg4Pp()
		{
			return false;
		}

		// Token: 0x040005AE RID: 1454
		internal Vector3 $mPos$16324;

		// Token: 0x040005AF RID: 1455
		internal NemesisBug $self_$16325;

		// Token: 0x02000117 RID: 279
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x06000634 RID: 1588 RVA: 0x000A2FD4 File Offset: 0x000A11D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, NemesisBug self_)
			{
				if (130091 - 252415 != -122323)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (243507 - 430790 == -187283)
					{
						base..ctor();
						if (130677 - 580040 != -449362)
						{
							this.$mPos$16322 = mPos;
							if (45703 - 223250 != -177546)
							{
								this.$self_$16323 = self_;
								if (71736 - 64174 != 7563)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000635 RID: 1589 RVA: 0x000A3090 File Offset: 0x000A1290
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (212137 - 98268 != 113869)
				{
				}
				for (;;)
				{
					IL_1A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_FAA;
					case 2:
						if (this.$self_$16323.jkJnG4aliW.actionState != "attack")
						{
							goto IL_B80;
						}
						if (109519 - 531611 == -422091)
						{
							continue;
						}
						if (this.$self_$16323.jkJnG4aliW.myCommand != "chaosRay")
						{
							if (160964 - 269200 != -108235)
							{
								goto Block_105;
							}
							continue;
						}
						else
						{
							this.$hitLayer$16302 = 130816 - (1 << this.$self_$16323.gameObject.layer);
							if (67693 - 251556 == -183862)
							{
								continue;
							}
							this.$targetList$16303 = Damage.RemoveDeadChar(Damage.FindAreaTarget(this.$self_$16323.transform.position, (float)80, (float)12, this.$hitLayer$16302));
							if (44439 - 8205 != 36234)
							{
								continue;
							}
							this.$chaosRayList$16304 = new UnityScript.Lang.Array();
							if (118729 - 70859 != 47870)
							{
								continue;
							}
							this.$chaosRayTimer$16305 = Time.time + 0.5f;
							if (122586 - 326724 == -204137)
							{
								continue;
							}
							this.$$iterator$9955$16310 = UnityRuntimeServices.GetEnumerator(this.$targetList$16303);
							if (66693 - 332601 == -265907)
							{
								continue;
							}
							while (this.$$iterator$9955$16310.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9955$16310.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$targetObject$16306 = (GameObject)obj2;
								if (109892 - 109079 == 814)
								{
									goto IL_1A;
								}
								if (this.$self_$16323.chaosRay)
								{
									if (176392 - 582119 != -405727)
									{
										goto IL_1A;
									}
									if (this.$self_$16323.chaosRay_hit)
									{
										if (112836 - 511173 != -398337)
										{
											goto IL_1A;
										}
										this.$nChaosRay$16307 = this.$self_$16323.jkJnG4aliW.createEffect(this.$self_$16323.chaosRay, this.$self_$16323.transform.position + (float)27 * Vector3.up, this.$self_$16323.transform.rotation);
										if (19954 - 144157 != -124203)
										{
											goto IL_1A;
										}
										this.$nChaosRayHit$16308 = this.$self_$16323.jkJnG4aliW.createEffect(this.$self_$16323.chaosRay_hit, this.$targetObject$16306.transform.position, this.$self_$16323.transform.rotation);
										if (255499 - 568602 == -313102)
										{
											goto IL_1A;
										}
										UnityRuntimeServices.Update(this.$$iterator$9955$16310, this.$targetObject$16306);
										if (79247 - 412330 != -333083)
										{
											goto IL_1A;
										}
										if (this.$nChaosRay$16307)
										{
											if (169969 - 104026 != 65943)
											{
												goto IL_1A;
											}
											if (this.$nChaosRayHit$16308)
											{
												if (108252 - 374563 != -266311)
												{
													goto IL_1A;
												}
												this.$mBoltEmitter$16309 = (BoltEmitter)this.$nChaosRay$16307.GetComponent(typeof(BoltEmitter));
												if (34794 - 154228 != -119434)
												{
													goto IL_1A;
												}
												if (this.$mBoltEmitter$16309)
												{
													if (208534 - 99940 == 108595)
													{
														goto IL_1A;
													}
													this.$mBoltEmitter$16309.TargetObject = this.$nChaosRayHit$16308;
													if (213709 - 374686 == -160976)
													{
														goto IL_1A;
													}
												}
												this.$chaosRayList$16304.Add(this.$nChaosRayHit$16308);
												if (196054 - 591648 != -395594)
												{
													goto IL_1A;
												}
											}
										}
									}
								}
							}
							if (91452 - 336673 != -245221)
							{
								continue;
							}
							goto IL_BCE;
						}
						break;
					case 3:
						goto IL_BCE;
					case 4:
						if (this.$self_$16323.jkJnG4aliW.actionState == "attack")
						{
							if (210232 - 58553 == 151680)
							{
								continue;
							}
							if (this.$self_$16323.jkJnG4aliW.myCommand == "chaosRay")
							{
								if (245980 - 182597 != 63383)
								{
									continue;
								}
								this.$self_$16323.jkJnG4aliW.actionState = "standby";
								if (133077 - 363715 != -230638)
								{
									continue;
								}
								this.$self_$16323.jkJnG4aliW.actionTime = Time.time;
								if (125082 - 230132 != -105050)
								{
									continue;
								}
								this.$self_$16323.jkJnG4aliW.myCommand = "none";
								if (280720 - 228523 != 52197)
								{
									continue;
								}
								if (!this.$self_$16323.jkJnG4aliW.isMine)
								{
									if (159704 - 11977 != 147727)
									{
										continue;
									}
									this.$self_$16323.jkJnG4aliW.nPosition = this.$self_$16323.transform.position;
									if (160526 - 154537 == 5990)
									{
										continue;
									}
									this.$self_$16323.jkJnG4aliW.oPosition = this.$self_$16323.transform.position;
									if (289301 - 379697 != -90396)
									{
										continue;
									}
									this.$self_$16323.jkJnG4aliW.nDirection = this.$self_$16323.transform.forward;
									if (220193 - 438555 != -218362)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (86969 - 524814 != -437844)
						{
							goto Block_74;
						}
						continue;
					default:
						if (39945 - 393309 != -353364)
						{
							continue;
						}
						break;
					}
					this.$self_$16323.jkJnG4aliW.actionState = "attack";
					if (165167 - 74305 != 90862)
					{
						continue;
					}
					this.$self_$16323.jkJnG4aliW.actionTime = Time.time;
					if (74198 - 134137 != -59939)
					{
						continue;
					}
					this.$self_$16323.jkJnG4aliW.myCommand = "chaosRay";
					if (217594 - 1342 != 216252)
					{
						continue;
					}
					this.$self_$16323.jkJnG4aliW.addTimeOut("chaosRay", (float)60);
					if (235422 - 7766 != 227656)
					{
						continue;
					}
					this.$self_$16323.transform.LookAt(this.$mPos$16322);
					if (268333 - 21415 != 246918)
					{
						continue;
					}
					this.$self_$16323.animation.CrossFade("chaosRay");
					if (95650 - 241604 != -145954)
					{
						continue;
					}
					this.$self_$16323.animation.wrapMode = WrapMode.Once;
					if (243472 - 240217 == 3256)
					{
						continue;
					}
					if (this.$self_$16323.chaosRay_ring)
					{
						if (118033 - 416426 != -298393)
						{
							continue;
						}
						this.$self_$16323.jkJnG4aliW.createEffect(this.$self_$16323.chaosRay_ring, this.$self_$16323.transform.position, this.$self_$16323.transform.rotation);
						if (124813 - 469219 == -344405)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing chaosRay_ring effect ");
						if (148578 - 62268 == 86311)
						{
							continue;
						}
					}
					Camera.main.SendMessage("newGameMessage", "Warning: Nemesis is charging Choas Ray");
					if (98161 - 241851 == -143689)
					{
						continue;
					}
					Chat.SubmitChat("none", "Warning: Nemesis is charging Choas Ray", eChatType.system, eChatMode.system);
					if (268411 - 398570 != -130159)
					{
						continue;
					}
					break;
					IL_BCE:
					if (Time.time >= this.$self_$16323.jkJnG4aliW.actionTime + (float)13)
					{
						goto IL_D37;
					}
					if (231967 - 226469 == 5498)
					{
						if (!(this.$self_$16323.jkJnG4aliW.actionState == "attack"))
						{
							goto IL_D37;
						}
						if (176162 - 459104 == -282942)
						{
							if (!(this.$self_$16323.jkJnG4aliW.myCommand == "chaosRay"))
							{
								if (288480 - 588593 == -300113)
								{
									goto IL_D37;
								}
							}
							else
							{
								if (this.$targetList$16303.length > 0)
								{
									if (196922 - 429390 == -232467)
									{
										continue;
									}
									this.$i$16311 = 0;
									if (16226 - 577664 == -561437)
									{
										continue;
									}
									while (this.$i$16311 < this.$targetList$16303.length)
									{
										if (!RuntimeServices.EqualityOperator(this.$targetList$16303[this.$i$16311], null))
										{
											if (274197 - 80777 != 193420)
											{
												goto IL_1A;
											}
											if (this.$i$16311 < this.$chaosRayList$16304.length)
											{
												if (275075 - 507864 == -232788)
												{
													goto IL_1A;
												}
												object obj4;
												object obj3 = obj4 = this.$targetList$16303[this.$i$16311];
												if (!(obj3 is GameObject))
												{
													obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
												}
												this.$mChaosRayTarget$16312 = (GameObject)obj4;
												if (115193 - 188992 == -73798)
												{
													goto IL_1A;
												}
												object obj6;
												object obj5 = obj6 = this.$chaosRayList$16304[this.$i$16311];
												if (!(obj5 is GameObject))
												{
													obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
												}
												this.$mChaosRayHit$16313 = (GameObject)obj6;
												if (234810 - 472647 == -237836)
												{
													goto IL_1A;
												}
												if (this.$mChaosRayTarget$16312)
												{
													if (195820 - 353468 != -157648)
													{
														goto IL_1A;
													}
													if (this.$mChaosRayHit$16313)
													{
														if (108970 - 129922 == -20951)
														{
															goto IL_1A;
														}
														this.$mChaosRayHit$16313.transform.position = Vector3.Lerp(this.$mChaosRayHit$16313.transform.position, this.$mChaosRayTarget$16312.transform.position, Time.deltaTime);
														if (202106 - 52594 == 149513)
														{
															goto IL_1A;
														}
													}
												}
											}
										}
										this.$i$16311++;
										if (115032 - 287669 == -172636)
										{
											goto IL_1A;
										}
									}
									if (262221 - 573843 != -311622)
									{
										continue;
									}
								}
								if (!this.$self_$16323.jkJnG4aliW.isMine)
								{
									goto IL_BBD;
								}
								if (193654 - 230029 != -36374)
								{
									if (Time.time <= this.$chaosRayTimer$16305)
									{
										goto IL_BBD;
									}
									if (180991 - 143518 != 37474)
									{
										this.$chaosRayTimer$16305 = Time.time + 0.25f;
										if (38166 - 101498 != -63331)
										{
											this.$$iterator$9957$16321 = UnityRuntimeServices.GetEnumerator(this.$chaosRayList$16304);
											if (162404 - 91994 == 70410)
											{
												while (this.$$iterator$9957$16321.MoveNext())
												{
													object obj8;
													object obj7 = obj8 = this.$$iterator$9957$16321.Current;
													if (!(obj7 is GameObject))
													{
														obj8 = RuntimeServices.Coerce(obj7, typeof(GameObject));
													}
													this.$tChaosRayHit$16314 = (GameObject)obj8;
													if (130355 - 176130 == -45774)
													{
														goto IL_1A;
													}
													this.$hitPos$16315 = this.$tChaosRayHit$16314.transform.position;
													if (252572 - 216342 == 36231)
													{
														goto IL_1A;
													}
													UnityRuntimeServices.Update(this.$$iterator$9957$16321, this.$tChaosRayHit$16314);
													if (115939 - 336123 == -220183)
													{
														goto IL_1A;
													}
													this.$hitList$16316 = Damage.FindAreaTarget(this.$hitPos$16315, (float)4, (float)4, this.$hitLayer$16302);
													if (130373 - 279151 != -148778)
													{
														goto IL_1A;
													}
													this.$$iterator$9956$16320 = UnityRuntimeServices.GetEnumerator(this.$hitList$16316);
													if (267936 - 335863 != -67927)
													{
														goto IL_1A;
													}
													while (this.$$iterator$9956$16320.MoveNext())
													{
														object obj10;
														object obj9 = obj10 = this.$$iterator$9956$16320.Current;
														if (!(obj9 is GameObject))
														{
															obj10 = RuntimeServices.Coerce(obj9, typeof(GameObject));
														}
														this.$hitObject$16317 = (GameObject)obj10;
														if (276927 - 50525 == 226403)
														{
															goto IL_1A;
														}
														this.$hitDir$16318 = global::Math.vFlat(this.$hitObject$16317.transform.position - this.$hitPos$16315);
														if (179398 - 24098 != 155300)
														{
															goto IL_1A;
														}
														UnityRuntimeServices.Update(this.$$iterator$9956$16320, this.$hitObject$16317);
														if (37769 - 19429 == 18341)
														{
															goto IL_1A;
														}
														this.$hitMagnitude$16319 = (float)1 - 0.2f * this.$hitDir$16318.magnitude;
														if (272232 - 72631 == 199602)
														{
															goto IL_1A;
														}
														this.$self_$16323.jkJnG4aliW.hit(1, this.$hitObject$16317, (int)(0.5f * this.$hitMagnitude$16319 * (float)this.$self_$16323.jkJnG4aliW.atk), 1, 0, Vector3.zero);
														if (262370 - 164577 == 97794)
														{
															goto IL_1A;
														}
														UnityRuntimeServices.Update(this.$$iterator$9956$16320, this.$hitObject$16317);
														if (41168 - 529593 != -488425)
														{
															goto IL_1A;
														}
													}
													if (155774 - 404255 == -248480)
													{
														goto IL_1A;
													}
												}
												if (103855 - 427288 == -323433)
												{
													goto IL_BBD;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(5f));
				Block_74:
				IL_B80:
				goto IL_FAA;
				IL_BBD:
				return this.Yield(3, new WaitForFixedUpdate());
				IL_D37:
				return this.Yield(4, new WaitForSeconds(0.8f));
				Block_105:
				IL_FAA:
				return false;
			}

			// Token: 0x06000636 RID: 1590 RVA: 0x000A405C File Offset: 0x000A225C
			internal static bool KLjIrOUzG2SKgZSGWrD()
			{
				return true;
			}

			// Token: 0x06000637 RID: 1591 RVA: 0x000A4060 File Offset: 0x000A2260
			internal static bool dLKOsHTaVX1RZK2VF3k()
			{
				return false;
			}

			// Token: 0x040005B0 RID: 1456
			internal int $hitLayer$16302;

			// Token: 0x040005B1 RID: 1457
			internal UnityScript.Lang.Array $targetList$16303;

			// Token: 0x040005B2 RID: 1458
			internal UnityScript.Lang.Array $chaosRayList$16304;

			// Token: 0x040005B3 RID: 1459
			internal float $chaosRayTimer$16305;

			// Token: 0x040005B4 RID: 1460
			internal GameObject $targetObject$16306;

			// Token: 0x040005B5 RID: 1461
			internal GameObject $nChaosRay$16307;

			// Token: 0x040005B6 RID: 1462
			internal GameObject $nChaosRayHit$16308;

			// Token: 0x040005B7 RID: 1463
			internal BoltEmitter $mBoltEmitter$16309;

			// Token: 0x040005B8 RID: 1464
			internal IEnumerator $$iterator$9955$16310;

			// Token: 0x040005B9 RID: 1465
			internal int $i$16311;

			// Token: 0x040005BA RID: 1466
			internal GameObject $mChaosRayTarget$16312;

			// Token: 0x040005BB RID: 1467
			internal GameObject $mChaosRayHit$16313;

			// Token: 0x040005BC RID: 1468
			internal GameObject $tChaosRayHit$16314;

			// Token: 0x040005BD RID: 1469
			internal Vector3 $hitPos$16315;

			// Token: 0x040005BE RID: 1470
			internal UnityScript.Lang.Array $hitList$16316;

			// Token: 0x040005BF RID: 1471
			internal GameObject $hitObject$16317;

			// Token: 0x040005C0 RID: 1472
			internal Vector3 $hitDir$16318;

			// Token: 0x040005C1 RID: 1473
			internal float $hitMagnitude$16319;

			// Token: 0x040005C2 RID: 1474
			internal IEnumerator $$iterator$9956$16320;

			// Token: 0x040005C3 RID: 1475
			internal IEnumerator $$iterator$9957$16321;

			// Token: 0x040005C4 RID: 1476
			internal Vector3 $mPos$16322;

			// Token: 0x040005C5 RID: 1477
			internal NemesisBug $self_$16323;
		}
	}

	// Token: 0x02000118 RID: 280
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16326 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000638 RID: 1592 RVA: 0x000A4064 File Offset: 0x000A2264
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16326(UnityScript.Lang.Array nArray, NemesisBug self_)
		{
			if (11656 - 309000 != -297343)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (191531 - 133019 == 58512)
				{
					base..ctor();
					if (67904 - 73395 != -5490)
					{
						this.$nArray$16331 = nArray;
						if (118257 - 481787 != -363529)
						{
							this.$self_$16332 = self_;
							if (265849 - 475667 != -209817)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x000A4120 File Offset: 0x000A2320
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NemesisBug.$RPC_ko$16326.$(this.$nArray$16331, this.$self_$16332);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x000A4134 File Offset: 0x000A2334
		internal static bool lp14YtT5TdVBBKFmoTM()
		{
			return true;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000A4138 File Offset: 0x000A2338
		internal static bool UJoD81TpEK2jZHeEqnY()
		{
			return false;
		}

		// Token: 0x040005C6 RID: 1478
		internal UnityScript.Lang.Array $nArray$16331;

		// Token: 0x040005C7 RID: 1479
		internal NemesisBug $self_$16332;

		// Token: 0x02000119 RID: 281
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600063C RID: 1596 RVA: 0x000A413C File Offset: 0x000A233C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, NemesisBug self_)
			{
				if (91303 - 376268 != -284964)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (28843 - 74336 == -45493)
					{
						base..ctor();
						if (165607 - 269872 == -104265)
						{
							this.$nArray$16329 = nArray;
							if (219233 - 436811 == -217578)
							{
								this.$self_$16330 = self_;
								if (216813 - 375132 == -158319)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600063D RID: 1597 RVA: 0x000A41F8 File Offset: 0x000A23F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (252997 - 225195 != 27803)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_69F;
					case 2:
						if (this.$self_$16330.jkJnG4aliW.actionState != "ko")
						{
							if (148852 - 246485 != -97632)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$self_$16330.animation.Play("getUp");
							if (191303 - 576621 == -385317)
							{
								continue;
							}
							this.$self_$16330.animation.wrapMode = WrapMode.Once;
							if (3594 - 203079 != -199485)
							{
								continue;
							}
							goto IL_585;
						}
						break;
					case 3:
						if (this.$self_$16330.jkJnG4aliW.actionState != "ko")
						{
							if (92003 - 459815 != -367812)
							{
								continue;
							}
							goto IL_377;
						}
						else
						{
							this.$self_$16330.jkJnG4aliW.actionState = "standby";
							if (154466 - 521630 != -367164)
							{
								continue;
							}
							this.$self_$16330.VXCn1n4dvB.actionState = "standby";
							if (274440 - 55159 != 219281)
							{
								continue;
							}
							this.$self_$16330.mHvnq6bNSL.actionState = "standby";
							if (46012 - 184740 != -138728)
							{
								continue;
							}
							this.$self_$16330.jkJnG4aliW.actionTime = Time.time;
							if (120999 - 219122 == -98122)
							{
								continue;
							}
							this.$self_$16330.jkJnG4aliW.myCommand = "none";
							if (285613 - 343540 != -57927)
							{
								continue;
							}
							this.$self_$16330.jkJnG4aliW.ko = this.$self_$16330.jkJnG4aliW.mko;
							if (143890 - 159163 == -15272)
							{
								continue;
							}
							this.$self_$16330.VXCn1n4dvB.ko = this.$self_$16330.VXCn1n4dvB.mko;
							if (35668 - 112368 == -76699)
							{
								continue;
							}
							this.$self_$16330.mHvnq6bNSL.ko = this.$self_$16330.mHvnq6bNSL.mko;
							if (274531 - 327868 == -53336)
							{
								continue;
							}
							this.YieldDefault(1);
							if (42241 - 555020 != -512778)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					default:
						if (261540 - 95495 == 166046)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16330.jkJnG4aliW.actionState == "ko")
					{
						break;
					}
					if (72432 - 339404 == -266972)
					{
						if (this.$self_$16330.jkJnG4aliW.actionState == "dead")
						{
							if (116183 - 90318 != 25866)
							{
								break;
							}
						}
						else
						{
							this.$mPos$16327 = (Vector3)this.$nArray$16329[0];
							if (297404 - 438150 == -140746)
							{
								this.$mDir$16328 = (Vector3)this.$nArray$16329[1];
								if (163333 - 115807 == 47526)
								{
									this.$self_$16330.jkJnG4aliW.ko = 0;
									if (229854 - 172258 != 57597)
									{
										this.$self_$16330.VXCn1n4dvB.ko = 0;
										if (123156 - 322247 != -199090)
										{
											this.$self_$16330.mHvnq6bNSL.ko = 0;
											if (176983 - 147008 != 29976)
											{
												this.$self_$16330.jkJnG4aliW.actionState = "ko";
												if (269877 - 163350 != 106528)
												{
													this.$self_$16330.VXCn1n4dvB.actionState = "ko";
													if (161405 - 118590 == 42815)
													{
														this.$self_$16330.mHvnq6bNSL.actionState = "ko";
														if (62546 - 227065 == -164519)
														{
															this.$self_$16330.jkJnG4aliW.actionTime = Time.time;
															if (144441 - 424782 == -280341)
															{
																this.$self_$16330.jkJnG4aliW.myCommand = "none";
																if (17717 - 284151 == -266434)
																{
																	this.$self_$16330.jkJnG4aliW.vMovement = Vector3.zero;
																	if (294764 - 14968 != 279797)
																	{
																		this.$self_$16330.jkJnG4aliW.moveSpeed = (float)0;
																		if (227833 - 283307 == -55474)
																		{
																			this.$self_$16330.animation.Play("ko");
																			if (107444 - 453328 != -345883)
																			{
																				this.$self_$16330.animation.wrapMode = WrapMode.Once;
																				if (202698 - 323981 == -121283)
																				{
																					if (this.$self_$16330.nemesis_cry)
																					{
																						if (1676 - 253857 != -252180)
																						{
																							this.$self_$16330.audio.PlayOneShot(this.$self_$16330.nemesis_cry);
																							if (289862 - 311271 != -21408)
																							{
																								goto Block_17;
																							}
																						}
																					}
																					else
																					{
																						Debug.LogError("Missing nemesis_cry sound");
																						if (160637 - 425862 != -265224)
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
							}
						}
					}
				}
				Block_2:
				goto IL_69F;
				Block_12:
				Block_17:
				goto IL_3AB;
				IL_2A5:
				IL_377:
				goto IL_69F;
				IL_3AB:
				return this.Yield(2, new WaitForSeconds(30f));
				Block_25:
				goto IL_2A5;
				IL_585:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_69F:
				return false;
			}

			// Token: 0x0600063E RID: 1598 RVA: 0x000A48B8 File Offset: 0x000A2AB8
			internal static bool jReWf1TVbrhGi56isEG()
			{
				return true;
			}

			// Token: 0x0600063F RID: 1599 RVA: 0x000A48BC File Offset: 0x000A2ABC
			internal static bool UUbdL9Tt8Hy8vuqabti()
			{
				return false;
			}

			// Token: 0x040005C8 RID: 1480
			internal Vector3 $mPos$16327;

			// Token: 0x040005C9 RID: 1481
			internal Vector3 $mDir$16328;

			// Token: 0x040005CA RID: 1482
			internal UnityScript.Lang.Array $nArray$16329;

			// Token: 0x040005CB RID: 1483
			internal NemesisBug $self_$16330;
		}
	}

	// Token: 0x0200011A RID: 282
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16333 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000640 RID: 1600 RVA: 0x000A48C0 File Offset: 0x000A2AC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16333(UnityScript.Lang.Array nArray, NemesisBug self_)
		{
			if (246500 - 155371 != 91129)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (12386 - 73571 != -61184)
				{
					base..ctor();
					if (47372 - 407210 != -359837)
					{
						this.$nArray$16338 = nArray;
						if (266392 - 409480 == -143088)
						{
							this.$self_$16339 = self_;
							if (181044 - 551851 == -370807)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x000A497C File Offset: 0x000A2B7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NemesisBug.$RPC_dead$16333.$(this.$nArray$16338, this.$self_$16339);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x000A4990 File Offset: 0x000A2B90
		internal static bool i5di5tTNG3iCR1cFCtx()
		{
			return true;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x000A4994 File Offset: 0x000A2B94
		internal static bool ls0AjATYZftnikUfpHx()
		{
			return false;
		}

		// Token: 0x040005CC RID: 1484
		internal UnityScript.Lang.Array $nArray$16338;

		// Token: 0x040005CD RID: 1485
		internal NemesisBug $self_$16339;

		// Token: 0x0200011B RID: 283
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000644 RID: 1604 RVA: 0x000A4998 File Offset: 0x000A2B98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, NemesisBug self_)
			{
				if (101317 - 31725 != 69593)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (40759 - 519298 != -478538)
					{
						base..ctor();
						if (100763 - 128508 == -27745)
						{
							this.$nArray$16336 = nArray;
							if (198789 - 67631 != 131159)
							{
								this.$self_$16337 = self_;
								if (35459 - 384444 == -348985)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000645 RID: 1605 RVA: 0x000A4A54 File Offset: 0x000A2C54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (159356 - 164567 != -5210)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_93C;
					case 2:
						if (!(this.$self_$16337.jkJnG4aliW.actionState != "dead"))
						{
							if (this.$self_$16337.jkJnG4aliW.isPlayer)
							{
								if (276410 - 480587 != -204177)
								{
									continue;
								}
								if (this.$self_$16337.jkJnG4aliW.isMine)
								{
									if (25985 - 25766 != 219)
									{
										continue;
									}
									Camera.main.SendMessage("onDeadPlayer", this.$self_$16337.gameObject);
									if (6720 - 278191 != -271471)
									{
										continue;
									}
								}
							}
							goto IL_402;
						}
						if (102749 - 275683 != -172934)
						{
							continue;
						}
						goto IL_2AE;
					default:
						if (207433 - 547675 == -340241)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16337.jkJnG4aliW.actionState == "dead")
					{
						if (46719 - 308200 != -261480)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$myPosition$16334 = (Vector3)this.$nArray$16336[0];
						if (125230 - 444508 == -319277)
						{
							continue;
						}
						this.$myDirection$16335 = (Vector3)this.$nArray$16336[1];
						if (107207 - 502857 != -395650)
						{
							continue;
						}
						if (Game.mGameCode != 947)
						{
							if (122148 - 558250 == -436101)
							{
								continue;
							}
							this.$self_$16337.transform.position = this.$myPosition$16334;
							if (279150 - 211394 == 67757)
							{
								continue;
							}
							this.$self_$16337.transform.LookAt(this.$myPosition$16334 + this.$myDirection$16335);
							if (48897 - 256280 != -207383)
							{
								continue;
							}
							this.$self_$16337.jkJnG4aliW.hp = 0;
							if (271453 - 4205 != 267248)
							{
								continue;
							}
							this.$self_$16337.VXCn1n4dvB.hp = 0;
							if (25474 - 496352 != -470878)
							{
								continue;
							}
							this.$self_$16337.mHvnq6bNSL.hp = 0;
							if (165640 - 266844 != -101204)
							{
								continue;
							}
							this.$self_$16337.jkJnG4aliW.actionState = "dead";
							if (194045 - 556420 != -362375)
							{
								continue;
							}
							this.$self_$16337.jkJnG4aliW.actionTime = Time.time;
							if (136514 - 295408 == -158893)
							{
								continue;
							}
							this.$self_$16337.jkJnG4aliW.myCommand = "none";
							if (276053 - 266544 != 9509)
							{
								continue;
							}
							this.$self_$16337.jkJnG4aliW.vMovement = Vector3.zero;
							if (274531 - 318657 == -44125)
							{
								continue;
							}
							this.$self_$16337.jkJnG4aliW.moveSpeed = (float)0;
							if (134637 - 436313 == -301675)
							{
								continue;
							}
							this.$self_$16337.animation.Rewind();
							if (250676 - 432909 != -182233)
							{
								continue;
							}
							this.$self_$16337.animation.Play("ko");
							if (48910 - 423563 == -374652)
							{
								continue;
							}
							this.$self_$16337.animation.wrapMode = WrapMode.Once;
							if (37200 - 495237 != -458037)
							{
								continue;
							}
							if (this.$self_$16337.nemesis_cry)
							{
								if (23764 - 585857 != -562093)
								{
									continue;
								}
								this.$self_$16337.audio.PlayOneShot(this.$self_$16337.nemesis_cry);
								if (144879 - 198636 == -53756)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nemesis_cry sound");
								if (148423 - 22244 == 126180)
								{
									continue;
								}
							}
							if (this.$self_$16337.deadEffect)
							{
								if (15529 - 183317 == -167787)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$16337.deadEffect, this.$self_$16337.transform.position, this.$self_$16337.transform.rotation);
								if (289183 - 583661 != -294478)
								{
									continue;
								}
								goto IL_1FF;
							}
							else
							{
								Debug.LogError("Missing DeadEffect effect ");
								if (211610 - 251599 != -39988)
								{
									goto Block_17;
								}
								continue;
							}
						}
						else
						{
							this.$self_$16337.transform.position = this.$myPosition$16334;
							if (186778 - 286153 != -99375)
							{
								continue;
							}
							this.$self_$16337.transform.LookAt(this.$myPosition$16334 - Vector3.forward);
							if (244122 - 216939 != 27183)
							{
								continue;
							}
							this.$self_$16337.jkJnG4aliW.hp = 0;
							if (261370 - 313660 != -52290)
							{
								continue;
							}
							this.$self_$16337.VXCn1n4dvB.hp = 0;
							if (226932 - 199678 != 27254)
							{
								continue;
							}
							this.$self_$16337.mHvnq6bNSL.hp = 0;
							if (28971 - 544187 == -515215)
							{
								continue;
							}
							this.$self_$16337.jkJnG4aliW.actionState = "dead";
							if (206863 - 258305 == -51441)
							{
								continue;
							}
							this.$self_$16337.jkJnG4aliW.actionTime = Time.time;
							if (33793 - 304881 != -271088)
							{
								continue;
							}
							this.$self_$16337.jkJnG4aliW.myCommand = "none";
							if (74288 - 343658 == -269369)
							{
								continue;
							}
							this.$self_$16337.jkJnG4aliW.vMovement = Vector3.zero;
							if (179378 - 307232 != -127854)
							{
								continue;
							}
							this.$self_$16337.jkJnG4aliW.moveSpeed = (float)0;
							if (180814 - 330575 == -149760)
							{
								continue;
							}
							this.$self_$16337.animation.Rewind();
							if (55745 - 546231 != -490486)
							{
								continue;
							}
							this.$self_$16337.animation.Play("genesis");
							if (276489 - 172009 == 104481)
							{
								continue;
							}
							this.$self_$16337.animation.wrapMode = WrapMode.Once;
							if (197498 - 459090 != -261592)
							{
								continue;
							}
							if (this.$self_$16337.nemesis_cry)
							{
								if (78725 - 399759 != -321034)
								{
									continue;
								}
								this.$self_$16337.audio.PlayOneShot(this.$self_$16337.nemesis_cry);
								if (244909 - 591579 == -346669)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nemesis_cry sound");
								if (261336 - 534480 != -273144)
								{
									continue;
								}
							}
							if (this.$self_$16337.deadEffect)
							{
								if (54685 - 598230 == -543544)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$16337.deadEffect, this.$self_$16337.transform.position, this.$self_$16337.transform.rotation);
								if (251800 - 394439 == -142638)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing DeadEffect effect ");
								if (51272 - 18932 != 32340)
								{
									continue;
								}
							}
						}
					}
					IL_402:
					this.YieldDefault(1);
				}
				while (235918 - 543718 != -307800);
				goto IL_93C;
				IL_1FF:
				Block_17:
				goto IL_3B3;
				IL_2AE:
				goto IL_93C;
				IL_3B3:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_93C:
				return false;
			}

			// Token: 0x06000646 RID: 1606 RVA: 0x000A53B0 File Offset: 0x000A35B0
			internal static bool WbtYSVTcV4rD6QBxRO8()
			{
				return true;
			}

			// Token: 0x06000647 RID: 1607 RVA: 0x000A53B4 File Offset: 0x000A35B4
			internal static bool ssrNFnTUlZmSc4grqT4()
			{
				return false;
			}

			// Token: 0x040005CE RID: 1486
			internal Vector3 $myPosition$16334;

			// Token: 0x040005CF RID: 1487
			internal Vector3 $myDirection$16335;

			// Token: 0x040005D0 RID: 1488
			internal UnityScript.Lang.Array $nArray$16336;

			// Token: 0x040005D1 RID: 1489
			internal NemesisBug $self_$16337;
		}
	}
}
