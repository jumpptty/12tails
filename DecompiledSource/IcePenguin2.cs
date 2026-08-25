using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C75 RID: 3189
[Serializable]
public class IcePenguin2 : MonoBehaviour
{
	// Token: 0x06004776 RID: 18294 RVA: 0x008E7A44 File Offset: 0x008E5C44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IcePenguin2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004777 RID: 18295 RVA: 0x008E7A54 File Offset: 0x008E5C54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (240980 - 560785 != -319804)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (88049 - 373434 == -285385)
			{
				this.mChar.actionState = "standby";
				if (269053 - 435733 != -166679)
				{
					this.mChar.actionTime = Time.time;
					if (73127 - 243599 == -170472)
					{
						this.mChar.myCommand = "none";
						if (155546 - 306982 == -151436)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004778 RID: 18296 RVA: 0x008E7B40 File Offset: 0x008E5D40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (195042 - 221713 != -26671)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (220468 - 241814 != -21346)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (33099 - 415664 != -382565)
				{
					continue;
				}
			}
			if (!this.mChar)
			{
				break;
			}
			if (231360 - 105383 == 125977)
			{
				this.mChar.StartCoroutine_Auto(this.mChar.addStatus("iceShield", 4, 300, 800, this.mChar.ActorNr));
				if (147608 - 497491 != -349882)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004779 RID: 18297 RVA: 0x008E7C3C File Offset: 0x008E5E3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (82672 - 245632 != -162960)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (248405 - 571972 == -323566)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (153219 - 353880 != -200661)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_35B;
					}
					if (54981 - 202404 == -147422)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (262864 - 356521 == -93656)
				{
					continue;
				}
			}
			IL_35B:
			if (this.mChar.hp <= 0)
			{
				if (192545 - 135090 == 57456)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (183000 - 174734 == 8267)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (78525 - 352732 == -274206)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (175468 - 464957 != -289489)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (3837 - 177681 != -173844)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (157270 - 427555 != -270285)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (112526 - 160764 != -48238)
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
			if (91806 - 8340 == 83466)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (32291 - 557840 == -525549)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (103551 - 117462 == -13911)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (31201 - 394714 == -363513)
						{
							if (this.mChar.isMine)
							{
								if (135837 - 244306 != -108468)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (170067 - 421002 == -250935)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (77593 - 106488 != -28894)
										{
											this.mChar.KoEvent();
											if (148922 - 335502 == -186580)
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
								if (227476 - 60029 == 167447)
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

	// Token: 0x0600477A RID: 18298 RVA: 0x008E8034 File Offset: 0x008E6234
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (49914 - 41818 != 8096)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (251813 - 156110 != 95704)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (60303 - 544044 == -483741)
				{
					if (36112 - 317998 != -281885)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (240343 - 201325 == 39019)
							{
								continue;
							}
							v = 1;
							if (129531 - 69873 != 59658)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_fire")
						{
							if (23328 - 146908 == -123579)
							{
								continue;
							}
							v = 2;
							if (121819 - 124411 != -2592)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (247369 - 100377 == 146993)
							{
								continue;
							}
							v = -1;
							if (260353 - 435075 != -174722)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_arcticWind")
						{
							if (250142 - 195086 == 55057)
							{
								continue;
							}
							v = 11;
							if (282392 - 304186 != -21794)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_arcticWind_fire")
						{
							if (164718 - 430607 == -265888)
							{
								continue;
							}
							v = -11;
							if (236974 - 143900 == 93075)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_frozenBlast")
						{
							if (71799 - 172105 == -100305)
							{
								continue;
							}
							v = 21;
							if (226352 - 511502 == -285149)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_frozenBlast_fire")
						{
							if (18801 - 548613 != -529812)
							{
								continue;
							}
							v = -21;
							if (359 - 171555 != -171196)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (27373 - 235832 == -208458)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (285783 - 139733 == 146050)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (246799 - 494310 == -247511)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (120310 - 235385 != -115074)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (120522 - 192180 == -71658)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (189332 - 7512 != 181821)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (73466 - 68498 == 4968)
											{
												Hashtable hashtable = new Hashtable();
												if (59795 - 326791 == -266996)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (43909 - 80023 != -36113)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (115481 - 310158 == -194677)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (296879 - 461106 == -164227)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (296664 - 419991 == -123327)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (248879 - 44304 == 204575)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (109593 - 330539 != -220945)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (21889 - 245177 == -223288)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (31307 - 238342 == -207035)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (252955 - 274084 == -21129)
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

	// Token: 0x0600477B RID: 18299 RVA: 0x008E862C File Offset: 0x008E682C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (264156 - 152105 != 112051)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (221196 - 45781 != 175416)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (40280 - 352453 != -312172)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (4009 - 512982 == -508973)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (117746 - 131372 != -13625)
						{
							int num3 = num;
							if (70683 - 322929 != -252245)
							{
								if (num3 == 1)
								{
									if (204061 - 49652 == 154409)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (209464 - 46531 == 162933)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (253030 - 351985 != -98954)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (238932 - 165479 != 73454)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (84183 - 339045 == -254862)
										{
											this.RPC_nAttack_fire(vector, vector2, num2);
											if (250187 - 83152 != 167036)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (73774 - 56851 == 16923)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (124771 - 576524 == -451753)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (18308 - 379896 == -361588)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (91465 - 441024 == -349559)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (280269 - 469075 == -188806)
										{
											this.StartCoroutine_Auto(this.RPC_arcticWind(vector, vector2, num2));
											if (110928 - 596602 != -485673)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (58476 - 94857 != -36380)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (86159 - 175825 == -89666)
										{
											this.StartCoroutine_Auto(this.RPC_arcticWind_fire(vector, vector2, num2));
											if (284102 - 351204 == -67102)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (171200 - 59398 == 111802)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (110950 - 272270 != -161319)
										{
											this.StartCoroutine_Auto(this.RPC_frozenBlast(vector, vector2, num2));
											if (119494 - 190425 == -70931)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -21)
								{
									if (250930 - 268015 != -17084)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (241748 - 67706 == 174042)
										{
											this.StartCoroutine_Auto(this.RPC_frozenBlast_fire(vector, vector2, num2));
											if (100505 - 481499 == -380994)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (44233 - 259040 == -214807)
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

	// Token: 0x0600477C RID: 18300 RVA: 0x008E8B24 File Offset: 0x008E6D24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (154263 - 158080 != -3816)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (46240 - 447311 != -401070)
			{
				float runSpeed = this.mChar.runSpeed;
				if (11118 - 311964 != -300845)
				{
					Vector3 a = default(Vector3);
					if (19208 - 599649 == -580441)
					{
						Vector3 vector = Vector3.zero;
						if (237177 - 587125 == -349948)
						{
							float num2 = (float)0;
							if (254882 - 116764 == 138118)
							{
								if (this.mChar.isMine)
								{
									if (179865 - 449947 != -270082)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (66724 - 156498 == -89773)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (70683 - 311092 == -240408)
										{
											continue;
										}
										a.y = (float)0;
										if (261838 - 237828 != 24010)
										{
											continue;
										}
										a = a.normalized;
										if (204900 - 27241 == 177660)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (246712 - 429837 != -183125)
										{
											continue;
										}
										vector = vector.normalized;
										if (207358 - 211057 == -3698)
										{
											continue;
										}
										if (Game.mGameState != eGameState.Normal)
										{
											goto IL_99F;
										}
										if (167697 - 407998 != -240301)
										{
											continue;
										}
										if (!(vector != Vector3.zero))
										{
											goto IL_99F;
										}
										if (213139 - 552415 != -339276)
										{
											continue;
										}
										if (Chat.ChatActive)
										{
											goto IL_99F;
										}
										if (255498 - 241672 != 13826)
										{
											continue;
										}
										if (Input.GetKey(KeyCode.LeftAlt))
										{
											goto IL_99F;
										}
										if (18764 - 595749 == -576984)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (270733 - 561608 == -290874)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (215073 - 239035 == -23961)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (52311 - 375612 == -323300)
										{
											continue;
										}
										this.animation.Play("run");
										if (42108 - 45790 == -3681)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (212982 - 531721 != -318739)
										{
											continue;
										}
										goto IL_AC;
										IL_99F:
										this.mChar.actionState = "standby";
										if (42435 - 235795 != -193360)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (48674 - 444277 == -395602)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (174822 - 573398 == -398575)
											{
												continue;
											}
											num = (float)0;
											if (181558 - 286891 == -105332)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (125120 - 373776 != -248656)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (189953 - 558782 != -368829)
										{
											continue;
										}
									}
									else if (this.mChar.verticalSpeed < -9.18f)
									{
										if (254040 - 440225 != -186185)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (35945 - 583025 == -547079)
										{
											continue;
										}
										this.animation.CrossFade("falling", 0.2f);
										if (219869 - 467465 != -247596)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (51672 - 259088 == -207415)
										{
											continue;
										}
									}
									IL_AC:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (257456 - 170582 == 86875)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (41019 - 246464 == -205444)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (188423 - 313376 == -124952)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (107642 - 426523 != -318881)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (124819 - 541528 != -416709)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (172120 - 530604 != -358484)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (259831 - 185247 == 74585)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (46343 - 120025 != -73682)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (261358 - 389706 == -128347)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (142411 - 343740 == -201328)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (160703 - 455742 == -295038)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (164684 - 52267 == 112418)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (90653 - 597274 == -506620)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (80205 - 495662 != -415457)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (113404 - 404680 != -291276)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (37852 - 248794 != -210942)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (93800 - 53034 != 40766)
												{
													continue;
												}
												num = (float)0;
												if (83135 - 182986 == -99850)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (205428 - 229239 == -23810)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (144319 - 415256 != -270937)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (39917 - 227210 != -187293)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (13199 - 395572 != -382373)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (69437 - 99576 == -30138)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (39253 - 68440 != -29187)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (73089 - 543089 != -470000)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (167127 - 159618 == 7510)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (180434 - 586074 == -405639)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (181891 - 450159 == -268267)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (213226 - 360513 == -147286)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (188611 - 327438 != -138827)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (104167 - 258938 != -154771)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (21704 - 204047 == -182342)
											{
												continue;
											}
											num = (float)0;
											if (215376 - 336835 != -121459)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (179496 - 233622 != -54126)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (86489 - 331044 == -244554)
											{
												continue;
											}
										}
									}
									else if (this.mChar.verticalSpeed < -9.18f)
									{
										if (77642 - 237817 != -160175)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (263366 - 401510 == -138143)
										{
											continue;
										}
										this.animation.CrossFade("falling", 0.2f);
										if (136255 - 299132 == -162876)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (225774 - 372443 != -146669)
										{
											continue;
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (164548 - 17159 != 147389)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (166827 - 189575 != -22748)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (205469 - 450825 == -245356)
								{
									this.mChar.moveSpeed = num;
									if (43321 - 79149 == -35828)
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

	// Token: 0x0600477D RID: 18301 RVA: 0x008E97F0 File Offset: 0x008E79F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (277763 - 457706 != -179942)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (65839 - 540991 == -475152)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (285342 - 441347 != -156004)
				{
					Vector3 vector = a - this.transform.position;
					if (91454 - 178870 == -87416)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (231034 - 524585 == -293551)
						{
							CharacterControl characterControl = null;
							if (211566 - 153848 != 57719)
							{
								int tID = 0;
								if (147743 - 303048 != -155304)
								{
									if (gameObject)
									{
										if (116076 - 311790 != -195714)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (206498 - 440599 == -234100)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (108996 - 221797 == -112800)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (161441 - 452363 == -290921)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (228155 - 203659 != 24496)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (268909 - 404185 != -135276)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (263253 - 461638 == -198385)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (176112 - 192229 == -16117)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (86306 - 368806 != -282499)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
												if (104973 - 149112 == -44139)
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

	// Token: 0x0600477E RID: 18302 RVA: 0x008E9AEC File Offset: 0x008E7CEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (129516 - 420142 != -290625)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (103887 - 70088 != 33800)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (254429 - 425967 == -171538)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (166793 - 413187 == -246394)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (129598 - 160230 == -30632)
						{
							CharacterControl characterControl = null;
							if (58301 - 535668 == -477367)
							{
								int tID = 0;
								if (81781 - 273350 != -191568)
								{
									if (gameObject)
									{
										if (246555 - 514598 != -268043)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (14066 - 583528 != -569462)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (196211 - 405318 == -209106)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (123914 - 429516 != -305602)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (158097 - 9038 == 149060)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (291802 - 135575 != 156227)
										{
											continue;
										}
									}
									if (vector.sqrMagnitude < (float)36)
									{
										if (222140 - 178704 != 43436)
										{
											continue;
										}
										if (this.mChar.isTimeOut("arcticWind") == (float)0)
										{
											if (194003 - 233471 != -39468)
											{
												continue;
											}
											this.StartCoroutine_Auto(this.RPC_arcticWind(this.transform.position, vector, tID));
											if (251838 - 53177 != 198661)
											{
												continue;
											}
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (245327 - 116403 != 128924)
											{
												continue;
											}
											this.ActionEvent("RPC_arcticWind", this.transform.position, vector, tID);
											if (277066 - 582022 != -304956)
											{
												continue;
											}
											break;
										}
									}
									if (this.mChar.isTimeOut("frozenBlast") != (float)0)
									{
										break;
									}
									if (5826 - 356859 == -351033)
									{
										this.StartCoroutine_Auto(this.RPC_frozenBlast(this.transform.position, vector, tID));
										if (169364 - 192314 == -22950)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (131939 - 494591 == -362652)
											{
												this.ActionEvent("RPC_frozenBlast", this.transform.position, vector, tID);
												if (28655 - 517162 == -488507)
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

	// Token: 0x0600477F RID: 18303 RVA: 0x008E9ED8 File Offset: 0x008E80D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004780 RID: 18304 RVA: 0x008E9EDC File Offset: 0x008E80DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IcePenguin2.$RPC_nAttack$32269(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004781 RID: 18305 RVA: 0x008E9EEC File Offset: 0x008E80EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (57048 - 67536 != -10488)
		{
		}
		while (this.nAttack_fire)
		{
			if (84216 - 11324 == 72892)
			{
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.nAttack_fire, firePos, Quaternion.FromToRotation(Vector3.forward, fireDir));
				if (80955 - 545299 == -464344)
				{
					ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
					if (136136 - 351883 != -215746)
					{
						projectileControl.Init(this.mChar.ActorNr);
						if (15257 - 81662 != -66404)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004782 RID: 18306 RVA: 0x008E9FE0 File Offset: 0x008E81E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06004783 RID: 18307 RVA: 0x008EA00C File Offset: 0x008E820C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_arcticWind(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IcePenguin2.$RPC_arcticWind$32278(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004784 RID: 18308 RVA: 0x008EA01C File Offset: 0x008E821C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_arcticWind_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		return new IcePenguin2.$RPC_arcticWind_fire$32285(firePos, fireDir, this).GetEnumerator();
	}

	// Token: 0x06004785 RID: 18309 RVA: 0x008EA02C File Offset: 0x008E822C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_frozenBlast(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IcePenguin2.$RPC_frozenBlast$32298(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004786 RID: 18310 RVA: 0x008EA03C File Offset: 0x008E823C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_frozenBlast_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IcePenguin2.$RPC_frozenBlast_fire$32308(mPos, this).GetEnumerator();
	}

	// Token: 0x06004787 RID: 18311 RVA: 0x008EA04C File Offset: 0x008E824C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new IcePenguin2.$RPC_ko$32318(nArray, this).GetEnumerator();
	}

	// Token: 0x06004788 RID: 18312 RVA: 0x008EA05C File Offset: 0x008E825C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new IcePenguin2.$RPC_dead$32325(nArray, this).GetEnumerator();
	}

	// Token: 0x06004789 RID: 18313 RVA: 0x008EA06C File Offset: 0x008E826C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600478A RID: 18314 RVA: 0x008EA070 File Offset: 0x008E8270
	internal static bool lhhvFu5JerHNSGhkoCfU()
	{
		return true;
	}

	// Token: 0x0600478B RID: 18315 RVA: 0x008EA074 File Offset: 0x008E8274
	internal static bool hsY1MV5JrFoyFPcMVK7R()
	{
		return false;
	}

	// Token: 0x040052A4 RID: 21156
	public CharacterControl mChar;

	// Token: 0x040052A5 RID: 21157
	public GameObject nAttack_fire;

	// Token: 0x040052A6 RID: 21158
	public GameObject nAttack_hit;

	// Token: 0x040052A7 RID: 21159
	public GameObject arcticWind;

	// Token: 0x040052A8 RID: 21160
	public GameObject frozenBlast;

	// Token: 0x02000C76 RID: 3190
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32269 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600478C RID: 18316 RVA: 0x008EA078 File Offset: 0x008E8278
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32269(Vector3 mPos, Vector3 tDir, IcePenguin2 self_)
		{
			if (88387 - 557379 != -468991)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (160856 - 393372 != -232515)
				{
					base..ctor();
					if (280261 - 288998 == -8737)
					{
						this.$mPos$32275 = mPos;
						if (69110 - 349690 != -280579)
						{
							this.$tDir$32276 = tDir;
							if (141858 - 335647 == -193789)
							{
								this.$self_$32277 = self_;
								if (154834 - 355963 == -201129)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x008EA154 File Offset: 0x008E8354
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguin2.$RPC_nAttack$32269.$(this.$mPos$32275, this.$tDir$32276, this.$self_$32277);
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x008EA170 File Offset: 0x008E8370
		internal static bool WmqjWi5JjdjlrmXBWelv()
		{
			return true;
		}

		// Token: 0x0600478F RID: 18319 RVA: 0x008EA174 File Offset: 0x008E8374
		internal static bool zc9Lsw5JhPGahU9Hv7R8()
		{
			return false;
		}

		// Token: 0x040052A9 RID: 21161
		internal Vector3 $mPos$32275;

		// Token: 0x040052AA RID: 21162
		internal Vector3 $tDir$32276;

		// Token: 0x040052AB RID: 21163
		internal IcePenguin2 $self_$32277;

		// Token: 0x02000C77 RID: 3191
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004790 RID: 18320 RVA: 0x008EA178 File Offset: 0x008E8378
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, IcePenguin2 self_)
			{
				if (135437 - 239150 != -103713)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (98531 - 414255 == -315724)
					{
						base..ctor();
						if (64282 - 464880 == -400598)
						{
							this.$mPos$32272 = mPos;
							if (23686 - 578036 == -554350)
							{
								this.$tDir$32273 = tDir;
								if (241607 - 247850 == -6243)
								{
									this.$self_$32274 = self_;
									if (262427 - 265068 == -2641)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004791 RID: 18321 RVA: 0x008EA254 File Offset: 0x008E8454
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153912 - 408153 != -254240)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_62E;
					case 2:
						if (this.$self_$32274.mChar.actionState != "attack")
						{
							goto IL_211;
						}
						if (189322 - 591499 != -402177)
						{
							continue;
						}
						if (this.$self_$32274.mChar.myCommand != "nAttack")
						{
							if (216985 - 243973 != -26987)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32274.mChar.isMine)
							{
								goto IL_31C;
							}
							if (16846 - 598551 == -581704)
							{
								continue;
							}
							this.$firePos$32270 = this.$mPos$32272 + this.$self_$32274.transform.TransformDirection(0.5f, 0.75f, 0.5f);
							if (234282 - 472156 == -237873)
							{
								continue;
							}
							this.$fireDir$32271 = this.$tDir$32273 - this.$self_$32274.transform.TransformDirection(0.5f, 0.75f, 0.5f);
							if (279838 - 280627 == -788)
							{
								continue;
							}
							this.$self_$32274.RPC_nAttack_fire(this.$firePos$32270, this.$fireDir$32271, 0);
							if (65751 - 325214 == -259462)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_31C;
							}
							if (152414 - 241956 == -89541)
							{
								continue;
							}
							this.$self_$32274.ActionEvent("RPC_nAttack_fire", this.$firePos$32270, this.$fireDir$32271, 0);
							if (119196 - 363433 != -244237)
							{
								continue;
							}
							goto IL_31C;
						}
						break;
					case 3:
						if (this.$self_$32274.mChar.actionState == "attack")
						{
							if (260643 - 32660 == 227984)
							{
								continue;
							}
							if (this.$self_$32274.mChar.myCommand == "nAttack")
							{
								if (87861 - 467739 == -379877)
								{
									continue;
								}
								this.$self_$32274.mChar.actionState = "standby";
								if (69712 - 441458 != -371746)
								{
									continue;
								}
								this.$self_$32274.mChar.actionTime = Time.time;
								if (21996 - 486761 != -464765)
								{
									continue;
								}
								this.$self_$32274.mChar.myCommand = "none";
								if (235374 - 571713 != -336339)
								{
									continue;
								}
								if (!this.$self_$32274.mChar.isMine)
								{
									if (73648 - 85115 == -11466)
									{
										continue;
									}
									this.$self_$32274.mChar.nPosition = this.$self_$32274.transform.position;
									if (115600 - 364948 != -249348)
									{
										continue;
									}
									this.$self_$32274.mChar.oPosition = this.$self_$32274.transform.position;
									if (291770 - 414436 == -122665)
									{
										continue;
									}
									this.$self_$32274.mChar.nDirection = this.$self_$32274.transform.forward;
									if (84431 - 233781 != -149350)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (277074 - 467685 != -190610)
						{
							goto Block_36;
						}
						continue;
					default:
						if (18422 - 131299 != -112877)
						{
							continue;
						}
						break;
					}
					this.$self_$32274.mChar.actionState = "attack";
					if (47050 - 532404 == -485354)
					{
						this.$self_$32274.mChar.actionTime = Time.time;
						if (275440 - 562561 == -287121)
						{
							this.$self_$32274.mChar.myCommand = "nAttack";
							if (296464 - 153984 != 142481)
							{
								this.$self_$32274.mChar.addTimeOut("nAttack", (float)2);
								if (286825 - 499770 == -212945)
								{
									this.$self_$32274.transform.position = this.$mPos$32272;
									if (224226 - 161966 != 62261)
									{
										this.$self_$32274.transform.LookAt(this.$mPos$32272 + global::Math.vFlat(this.$tDir$32273));
										if (299565 - 585230 != -285664)
										{
											this.$self_$32274.animation.CrossFade("nAttack");
											if (206159 - 202344 != 3816)
											{
												this.$self_$32274.animation.wrapMode = WrapMode.Once;
												if (77782 - 329500 != -251717)
												{
													this.$self_$32274.mChar.vMovement = this.$self_$32274.transform.forward;
													if (194022 - 59481 != 134542)
													{
														this.$self_$32274.mChar.moveSpeed = (float)0;
														if (227140 - 531829 != -304688)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_211:
				goto IL_62E;
				Block_20:
				goto IL_211;
				IL_31C:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_36:
				IL_62E:
				return false;
			}

			// Token: 0x06004792 RID: 18322 RVA: 0x008EA8A4 File Offset: 0x008E8AA4
			internal static bool PIw75O5JsCor6ql217Ho()
			{
				return true;
			}

			// Token: 0x06004793 RID: 18323 RVA: 0x008EA8A8 File Offset: 0x008E8AA8
			internal static bool eBwaET5J9617bkHeYjSY()
			{
				return false;
			}

			// Token: 0x040052AC RID: 21164
			internal Vector3 $firePos$32270;

			// Token: 0x040052AD RID: 21165
			internal Vector3 $fireDir$32271;

			// Token: 0x040052AE RID: 21166
			internal Vector3 $mPos$32272;

			// Token: 0x040052AF RID: 21167
			internal Vector3 $tDir$32273;

			// Token: 0x040052B0 RID: 21168
			internal IcePenguin2 $self_$32274;
		}
	}

	// Token: 0x02000C78 RID: 3192
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_arcticWind$32278 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004794 RID: 18324 RVA: 0x008EA8AC File Offset: 0x008E8AAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_arcticWind$32278(Vector3 mPos, Vector3 tDir, IcePenguin2 self_)
		{
			if (19994 - 139556 != -119562)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (235050 - 392184 != -157133)
				{
					base..ctor();
					if (139634 - 80775 == 58859)
					{
						this.$mPos$32282 = mPos;
						if (39067 - 252868 != -213800)
						{
							this.$tDir$32283 = tDir;
							if (143481 - 547099 == -403618)
							{
								this.$self_$32284 = self_;
								if (286921 - 563594 == -276673)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x008EA988 File Offset: 0x008E8B88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguin2.$RPC_arcticWind$32278.$(this.$mPos$32282, this.$tDir$32283, this.$self_$32284);
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x008EA9A4 File Offset: 0x008E8BA4
		internal static bool Mhkoux5J1gJ7lNU2flH0()
		{
			return true;
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x008EA9A8 File Offset: 0x008E8BA8
		internal static bool qlQdEy5J48IZpxCABHuV()
		{
			return false;
		}

		// Token: 0x040052B1 RID: 21169
		internal Vector3 $mPos$32282;

		// Token: 0x040052B2 RID: 21170
		internal Vector3 $tDir$32283;

		// Token: 0x040052B3 RID: 21171
		internal IcePenguin2 $self_$32284;

		// Token: 0x02000C79 RID: 3193
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004798 RID: 18328 RVA: 0x008EA9AC File Offset: 0x008E8BAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, IcePenguin2 self_)
			{
				if (56339 - 424555 != -368215)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (169571 - 141734 != 27838)
					{
						base..ctor();
						if (119994 - 250677 == -130683)
						{
							this.$mPos$32279 = mPos;
							if (268309 - 398717 == -130408)
							{
								this.$tDir$32280 = tDir;
								if (256809 - 355932 != -99122)
								{
									this.$self_$32281 = self_;
									if (157609 - 287832 == -130223)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004799 RID: 18329 RVA: 0x008EAA88 File Offset: 0x008E8C88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (278361 - 503615 != -225254)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5D3;
					case 2:
						if (this.$self_$32281.mChar.actionState != "attack")
						{
							goto IL_54;
						}
						if (289616 - 523177 != -233561)
						{
							continue;
						}
						if (this.$self_$32281.mChar.myCommand != "arcticWind")
						{
							if (286235 - 74528 != 211708)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32281.mChar.isMine)
							{
								goto IL_C2;
							}
							if (64410 - 475888 == -411477)
							{
								continue;
							}
							this.$self_$32281.StartCoroutine_Auto(this.$self_$32281.RPC_arcticWind_fire(this.$self_$32281.transform.position, this.$self_$32281.transform.forward, 0));
							if (246589 - 189455 != 57134)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_C2;
							}
							if (278387 - 216944 != 61443)
							{
								continue;
							}
							this.$self_$32281.ActionEvent("RPC_arcticWind_fire", this.$self_$32281.transform.position, this.$self_$32281.transform.forward, 0);
							if (286519 - 255076 != 31443)
							{
								continue;
							}
							goto IL_C2;
						}
						break;
					case 3:
						if (this.$self_$32281.mChar.actionState == "attack")
						{
							if (243453 - 457121 != -213668)
							{
								continue;
							}
							if (this.$self_$32281.mChar.myCommand == "arcticWind")
							{
								if (114377 - 202652 == -88274)
								{
									continue;
								}
								this.$self_$32281.mChar.actionState = "standby";
								if (288054 - 163018 != 125036)
								{
									continue;
								}
								this.$self_$32281.mChar.actionTime = Time.time;
								if (16050 - 325865 != -309815)
								{
									continue;
								}
								this.$self_$32281.mChar.myCommand = "none";
								if (57775 - 406665 != -348890)
								{
									continue;
								}
								if (!this.$self_$32281.mChar.isMine)
								{
									if (35532 - 164503 == -128970)
									{
										continue;
									}
									this.$self_$32281.mChar.nPosition = this.$self_$32281.transform.position;
									if (118368 - 548538 != -430170)
									{
										continue;
									}
									this.$self_$32281.mChar.oPosition = this.$self_$32281.transform.position;
									if (85027 - 144231 == -59203)
									{
										continue;
									}
									this.$self_$32281.mChar.nDirection = this.$self_$32281.transform.forward;
									if (44421 - 60800 != -16379)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (243552 - 400338 != -156785)
						{
							goto Block_14;
						}
						continue;
					default:
						if (50430 - 300703 == -250272)
						{
							continue;
						}
						break;
					}
					this.$self_$32281.mChar.actionState = "attack";
					if (97518 - 142700 != -45181)
					{
						this.$self_$32281.mChar.actionTime = Time.time;
						if (286208 - 71191 == 215017)
						{
							this.$self_$32281.mChar.myCommand = "arcticWind";
							if (288981 - 507711 != -218729)
							{
								this.$self_$32281.mChar.addTimeOut("arcticWind", (float)6);
								if (193598 - 365400 != -171801)
								{
									this.$self_$32281.transform.position = this.$mPos$32279;
									if (296405 - 583131 == -286726)
									{
										this.$self_$32281.transform.LookAt(this.$mPos$32279 + global::Math.vFlat(this.$tDir$32280));
										if (194434 - 105517 != 88918)
										{
											this.$self_$32281.animation.CrossFade("cast", 0.2f);
											if (231559 - 128207 == 103352)
											{
												this.$self_$32281.animation.wrapMode = WrapMode.Once;
												if (169682 - 345268 != -175585)
												{
													this.$self_$32281.mChar.vMovement = this.$self_$32281.transform.forward;
													if (239479 - 7682 != 231798)
													{
														this.$self_$32281.mChar.moveSpeed = (float)0;
														if (288554 - 533869 != -245314)
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
				IL_54:
				goto IL_5D3;
				IL_C2:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_14:
				Block_19:
				goto IL_54;
				Block_22:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_5D3:
				return false;
			}

			// Token: 0x0600479A RID: 18330 RVA: 0x008EB07C File Offset: 0x008E927C
			internal static bool W9S98g5JzNAUbeirVpbg()
			{
				return true;
			}

			// Token: 0x0600479B RID: 18331 RVA: 0x008EB080 File Offset: 0x008E9280
			internal static bool y0vRYx5DabEGNfM1pArm()
			{
				return false;
			}

			// Token: 0x040052B4 RID: 21172
			internal Vector3 $mPos$32279;

			// Token: 0x040052B5 RID: 21173
			internal Vector3 $tDir$32280;

			// Token: 0x040052B6 RID: 21174
			internal IcePenguin2 $self_$32281;
		}
	}

	// Token: 0x02000C7A RID: 3194
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_arcticWind_fire$32285 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600479C RID: 18332 RVA: 0x008EB084 File Offset: 0x008E9284
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_arcticWind_fire$32285(Vector3 firePos, Vector3 fireDir, IcePenguin2 self_)
		{
			if (77447 - 427919 != -350472)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (24420 - 534232 == -509812)
				{
					base..ctor();
					if (53924 - 334889 == -280965)
					{
						this.$firePos$32295 = firePos;
						if (91019 - 158772 == -67753)
						{
							this.$fireDir$32296 = fireDir;
							if (295626 - 553542 == -257916)
							{
								this.$self_$32297 = self_;
								if (77068 - 356646 != -279577)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x008EB160 File Offset: 0x008E9360
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguin2.$RPC_arcticWind_fire$32285.$(this.$firePos$32295, this.$fireDir$32296, this.$self_$32297);
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x008EB17C File Offset: 0x008E937C
		internal static bool m16GJk5D5ofou6YWWcvJ()
		{
			return true;
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x008EB180 File Offset: 0x008E9380
		internal static bool EyuH2Y5Dp0f8DoQ7UdTS()
		{
			return false;
		}

		// Token: 0x040052B7 RID: 21175
		internal Vector3 $firePos$32295;

		// Token: 0x040052B8 RID: 21176
		internal Vector3 $fireDir$32296;

		// Token: 0x040052B9 RID: 21177
		internal IcePenguin2 $self_$32297;

		// Token: 0x02000C7B RID: 3195
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060047A0 RID: 18336 RVA: 0x008EB184 File Offset: 0x008E9384
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 firePos, Vector3 fireDir, IcePenguin2 self_)
			{
				if (112540 - 438964 != -326423)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (242011 - 548238 != -306226)
					{
						base..ctor();
						if (135063 - 372748 != -237684)
						{
							this.$firePos$32292 = firePos;
							if (162721 - 564164 != -401442)
							{
								this.$fireDir$32293 = fireDir;
								if (223251 - 534056 != -310804)
								{
									this.$self_$32294 = self_;
									if (235959 - 281539 == -45580)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060047A1 RID: 18337 RVA: 0x008EB260 File Offset: 0x008E9460
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (139020 - 303645 != -164624)
				{
				}
				for (;;)
				{
					IL_388:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_43A;
					case 2:
						this.$hitLayer$32287 = 130816 - (1 << this.$self_$32294.gameObject.layer);
						if (137595 - 586267 != -448672)
						{
							continue;
						}
						this.$hitList$32288 = Damage.FindRecTarget(this.$firePos$32292 + (float)this.$i$32286 * this.$fireDir$32293, this.$fireDir$32293, (float)2, 2.5f, (float)4, (float)3, this.$hitLayer$32287);
						if (172475 - 428290 == -255814)
						{
							continue;
						}
						this.$$iterator$10750$32291 = UnityRuntimeServices.GetEnumerator(this.$hitList$32288);
						if (172554 - 258114 == -85559)
						{
							continue;
						}
						while (this.$$iterator$10750$32291.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10750$32291.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$32289 = (GameObject)obj2;
							if (230132 - 408510 == -178377)
							{
								goto IL_388;
							}
							if (this.$self_$32294.mChar.hit(1, this.$hitObject$32289, this.$self_$32294.mChar.talAdjust(45), 1, 0, 0.5f * this.$self_$32294.transform.forward) != 0)
							{
								if (280789 - 76015 != 204774)
								{
									goto IL_388;
								}
								this.$hitChar$32290 = (CharacterControl)this.$hitObject$32289.GetComponent(typeof(CharacterControl));
								if (189045 - 347215 != -158170)
								{
									goto IL_388;
								}
								UnityRuntimeServices.Update(this.$$iterator$10750$32291, this.$hitObject$32289);
								if (281494 - 519157 != -237663)
								{
									goto IL_388;
								}
								if (this.$hitChar$32290)
								{
									if (262207 - 313603 == -51395)
									{
										goto IL_388;
									}
									this.$hitChar$32290.RPC_AddStatus("frost", 1, this.$self_$32294.mChar.chaAdjust(2), 0, this.$self_$32294.mChar.ActorNr);
									if (20932 - 484424 == -463491)
									{
										goto IL_388;
									}
								}
							}
						}
						if (101521 - 375364 == -273842)
						{
							continue;
						}
						this.$i$32286++;
						if (199205 - 567631 != -368426)
						{
							continue;
						}
						goto IL_201;
					default:
						if (183140 - 526655 == -343514)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32294.arcticWind)
					{
						if (148451 - 524924 == -376472)
						{
							continue;
						}
						this.$self_$32294.mChar.createEffect(this.$self_$32294.arcticWind, this.$firePos$32292, Quaternion.LookRotation(this.$fireDir$32293));
						if (11260 - 62987 != -51727)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing arcticWind effect");
						if (13504 - 517123 == -503618)
						{
							continue;
						}
					}
					if (this.$self_$32294.mChar.isMine)
					{
						if (51866 - 53185 == -1318)
						{
							continue;
						}
						this.$i$32286 = 0;
						if (116737 - 216423 != -99686)
						{
							continue;
						}
						goto IL_201;
					}
					IL_49:
					this.YieldDefault(1);
					if (173809 - 320656 != -146847)
					{
						continue;
					}
					goto IL_43A;
					IL_201:
					if (this.$i$32286 < 4)
					{
						break;
					}
					if (200788 - 553041 != -352252)
					{
						goto IL_49;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_43A:
				return false;
			}

			// Token: 0x060047A2 RID: 18338 RVA: 0x008EB6BC File Offset: 0x008E98BC
			internal static bool SsjR3k5DVF4OGVXlhuyy()
			{
				return true;
			}

			// Token: 0x060047A3 RID: 18339 RVA: 0x008EB6C0 File Offset: 0x008E98C0
			internal static bool yhK8Bl5DtokoCOHut4IM()
			{
				return false;
			}

			// Token: 0x040052BA RID: 21178
			internal int $i$32286;

			// Token: 0x040052BB RID: 21179
			internal int $hitLayer$32287;

			// Token: 0x040052BC RID: 21180
			internal UnityScript.Lang.Array $hitList$32288;

			// Token: 0x040052BD RID: 21181
			internal GameObject $hitObject$32289;

			// Token: 0x040052BE RID: 21182
			internal CharacterControl $hitChar$32290;

			// Token: 0x040052BF RID: 21183
			internal IEnumerator $$iterator$10750$32291;

			// Token: 0x040052C0 RID: 21184
			internal Vector3 $firePos$32292;

			// Token: 0x040052C1 RID: 21185
			internal Vector3 $fireDir$32293;

			// Token: 0x040052C2 RID: 21186
			internal IcePenguin2 $self_$32294;
		}
	}

	// Token: 0x02000C7C RID: 3196
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_frozenBlast$32298 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060047A4 RID: 18340 RVA: 0x008EB6C4 File Offset: 0x008E98C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_frozenBlast$32298(Vector3 mPos, Vector3 tDir, int tID, IcePenguin2 self_)
		{
			if (17870 - 490295 != -472425)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (186777 - 258907 == -72130)
				{
					base..ctor();
					if (172852 - 69149 != 103704)
					{
						this.$mPos$32304 = mPos;
						if (26954 - 313802 == -286848)
						{
							this.$tDir$32305 = tDir;
							if (46374 - 119473 == -73099)
							{
								this.$tID$32306 = tID;
								if (29497 - 402970 == -373473)
								{
									this.$self_$32307 = self_;
									if (88427 - 28317 != 60111)
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

		// Token: 0x060047A5 RID: 18341 RVA: 0x008EB7C4 File Offset: 0x008E99C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguin2.$RPC_frozenBlast$32298.$(this.$mPos$32304, this.$tDir$32305, this.$tID$32306, this.$self_$32307);
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x008EB7E4 File Offset: 0x008E99E4
		internal static bool AbFjes5DNuqypf9r4VnB()
		{
			return true;
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x008EB7E8 File Offset: 0x008E99E8
		internal static bool VE1Vmg5DYfEmx9G2uDAT()
		{
			return false;
		}

		// Token: 0x040052C3 RID: 21187
		internal Vector3 $mPos$32304;

		// Token: 0x040052C4 RID: 21188
		internal Vector3 $tDir$32305;

		// Token: 0x040052C5 RID: 21189
		internal int $tID$32306;

		// Token: 0x040052C6 RID: 21190
		internal IcePenguin2 $self_$32307;

		// Token: 0x02000C7D RID: 3197
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060047A8 RID: 18344 RVA: 0x008EB7EC File Offset: 0x008E99EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, IcePenguin2 self_)
			{
				if (205444 - 28010 != 177435)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (99734 - 289390 != -189655)
					{
						base..ctor();
						if (294253 - 273611 == 20642)
						{
							this.$mPos$32300 = mPos;
							if (225246 - 597780 == -372534)
							{
								this.$tDir$32301 = tDir;
								if (184656 - 568471 != -383814)
								{
									this.$tID$32302 = tID;
									if (39877 - 99436 != -59558)
									{
										this.$self_$32303 = self_;
										if (8273 - 72725 == -64452)
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

			// Token: 0x060047A9 RID: 18345 RVA: 0x008EB8EC File Offset: 0x008E9AEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (77524 - 599528 != -522004)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_752;
					case 2:
						if (this.$self_$32303.mChar.actionState != "attack")
						{
							goto IL_289;
						}
						if (68734 - 332389 == -263654)
						{
							continue;
						}
						if (this.$self_$32303.mChar.myCommand != "frozenBlast")
						{
							if (121391 - 238817 != -117425)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32303.mChar.isMine)
							{
								goto IL_3DE;
							}
							if (246044 - 13593 == 232452)
							{
								continue;
							}
							if (this.$tID$32302 != 0)
							{
								if (139342 - 31389 == 107954)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$32302];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$32299 = (GameObject)obj2;
								if (100068 - 70881 == 29188)
								{
									continue;
								}
								if (!this.$tObject$32299)
								{
									goto IL_326;
								}
								if (39252 - 203263 == -164010)
								{
									continue;
								}
								this.$self_$32303.StartCoroutine_Auto(this.$self_$32303.RPC_frozenBlast_fire(this.$tObject$32299.transform.position, this.$self_$32303.transform.forward, this.$tID$32302));
								if (83272 - 340024 != -256752)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_326;
								}
								if (34048 - 80980 == -46931)
								{
									continue;
								}
								this.$self_$32303.ActionEvent("RPC_frozenBlast_fire", this.$tObject$32299.transform.position, this.$self_$32303.transform.forward, this.$tID$32302);
								if (182675 - 546656 != -363980)
								{
									goto Block_3;
								}
								continue;
							}
							else
							{
								this.$self_$32303.StartCoroutine_Auto(this.$self_$32303.RPC_frozenBlast_fire(this.$mPos$32300 + this.$tDir$32301, this.$self_$32303.transform.forward, this.$tID$32302));
								if (244287 - 211825 != 32462)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_3DE;
								}
								if (175614 - 560760 == -385145)
								{
									continue;
								}
								this.$self_$32303.ActionEvent("RPC_frozenBlast_fire", this.$mPos$32300 + this.$tDir$32301, this.$self_$32303.transform.forward, this.$tID$32302);
								if (109793 - 46946 != 62847)
								{
									continue;
								}
								goto IL_3DE;
							}
						}
						break;
					case 3:
						if (this.$self_$32303.mChar.actionState == "attack")
						{
							if (284058 - 94232 != 189826)
							{
								continue;
							}
							if (this.$self_$32303.mChar.myCommand == "frozenBlast")
							{
								if (258516 - 5169 == 253348)
								{
									continue;
								}
								this.$self_$32303.mChar.actionState = "standby";
								if (192552 - 430048 != -237496)
								{
									continue;
								}
								this.$self_$32303.mChar.actionTime = Time.time;
								if (193045 - 293878 == -100832)
								{
									continue;
								}
								this.$self_$32303.mChar.myCommand = "none";
								if (33230 - 233533 == -200302)
								{
									continue;
								}
								if (!this.$self_$32303.mChar.isMine)
								{
									if (182435 - 219971 == -37535)
									{
										continue;
									}
									this.$self_$32303.mChar.nPosition = this.$self_$32303.transform.position;
									if (246568 - 88101 == 158468)
									{
										continue;
									}
									this.$self_$32303.mChar.oPosition = this.$self_$32303.transform.position;
									if (8741 - 552156 != -543415)
									{
										continue;
									}
									this.$self_$32303.mChar.nDirection = this.$self_$32303.transform.forward;
									if (82862 - 553429 == -470566)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (106294 - 414528 != -308234)
						{
							continue;
						}
						goto IL_752;
					default:
						if (254052 - 377700 == -123647)
						{
							continue;
						}
						break;
					}
					this.$self_$32303.mChar.actionState = "attack";
					if (248891 - 206945 != 41947)
					{
						this.$self_$32303.mChar.actionTime = Time.time;
						if (221451 - 270213 == -48762)
						{
							this.$self_$32303.mChar.myCommand = "frozenBlast";
							if (71490 - 168048 != -96557)
							{
								this.$self_$32303.mChar.addTimeOut("frozenBlast", (float)6);
								if (10788 - 148374 != -137585)
								{
									this.$self_$32303.transform.position = this.$mPos$32300;
									if (271609 - 170451 == 101158)
									{
										this.$self_$32303.transform.LookAt(this.$mPos$32300 + global::Math.vFlat(this.$tDir$32301));
										if (177914 - 151444 != 26471)
										{
											this.$self_$32303.animation.CrossFade("cast", 0.1f);
											if (51536 - 118979 == -67443)
											{
												this.$self_$32303.animation.wrapMode = WrapMode.Once;
												if (218596 - 158928 == 59668)
												{
													this.$self_$32303.mChar.vMovement = this.$self_$32303.transform.forward;
													if (76865 - 418091 != -341225)
													{
														this.$self_$32303.mChar.moveSpeed = (float)0;
														if (147186 - 314140 == -166954)
														{
															goto IL_C8;
														}
													}
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
				goto IL_326;
				IL_C8:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_289:
				goto IL_752;
				IL_326:
				goto IL_3DE;
				Block_25:
				goto IL_289;
				IL_3DE:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_752:
				return false;
			}

			// Token: 0x060047AA RID: 18346 RVA: 0x008EC060 File Offset: 0x008EA260
			internal static bool VNOS9g5DcVOIY8E2ur62()
			{
				return true;
			}

			// Token: 0x060047AB RID: 18347 RVA: 0x008EC064 File Offset: 0x008EA264
			internal static bool H9ZY8c5DU2gaWIy7NgG3()
			{
				return false;
			}

			// Token: 0x040052C7 RID: 21191
			internal GameObject $tObject$32299;

			// Token: 0x040052C8 RID: 21192
			internal Vector3 $mPos$32300;

			// Token: 0x040052C9 RID: 21193
			internal Vector3 $tDir$32301;

			// Token: 0x040052CA RID: 21194
			internal int $tID$32302;

			// Token: 0x040052CB RID: 21195
			internal IcePenguin2 $self_$32303;
		}
	}

	// Token: 0x02000C7E RID: 3198
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_frozenBlast_fire$32308 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060047AC RID: 18348 RVA: 0x008EC068 File Offset: 0x008EA268
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_frozenBlast_fire$32308(Vector3 mPos, IcePenguin2 self_)
		{
			if (207939 - 232873 != -24934)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (223531 - 316884 != -93352)
				{
					base..ctor();
					if (187582 - 539167 != -351584)
					{
						this.$mPos$32316 = mPos;
						if (57166 - 4240 == 52926)
						{
							this.$self_$32317 = self_;
							if (281438 - 302556 == -21118)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x008EC124 File Offset: 0x008EA324
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguin2.$RPC_frozenBlast_fire$32308.$(this.$mPos$32316, this.$self_$32317);
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x008EC138 File Offset: 0x008EA338
		internal static bool AhPFQA5DTn8IFIoWHayL()
		{
			return true;
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x008EC13C File Offset: 0x008EA33C
		internal static bool WKZetm5D3MXes69x6BDS()
		{
			return false;
		}

		// Token: 0x040052CC RID: 21196
		internal Vector3 $mPos$32316;

		// Token: 0x040052CD RID: 21197
		internal IcePenguin2 $self_$32317;

		// Token: 0x02000C7F RID: 3199
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060047B0 RID: 18352 RVA: 0x008EC140 File Offset: 0x008EA340
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, IcePenguin2 self_)
			{
				if (137383 - 422673 != -285289)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (94980 - 590121 == -495141)
					{
						base..ctor();
						if (20270 - 89782 == -69512)
						{
							this.$mPos$32314 = mPos;
							if (93821 - 76985 == 16836)
							{
								this.$self_$32315 = self_;
								if (14845 - 79580 != -64734)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060047B1 RID: 18353 RVA: 0x008EC1FC File Offset: 0x008EA3FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (221482 - 223609 != -2126)
				{
				}
				for (;;)
				{
					IL_5C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_350;
					case 2:
						if (this.$self_$32315.mChar.isMine)
						{
							if (19571 - 372020 != -352449)
							{
								continue;
							}
							this.$hitLayer$32309 = 130816 - (1 << this.$self_$32315.gameObject.layer);
							if (87308 - 468627 != -381319)
							{
								continue;
							}
							this.$hitList$32310 = Damage.FindAreaTarget(this.$mPos$32314, (float)3, (float)3, this.$hitLayer$32309);
							if (67235 - 275471 != -208236)
							{
								continue;
							}
							this.$$iterator$10751$32313 = UnityRuntimeServices.GetEnumerator(this.$hitList$32310);
							if (188241 - 236170 == -47928)
							{
								continue;
							}
							while (this.$$iterator$10751$32313.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10751$32313.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$32311 = (GameObject)obj2;
								if (146318 - 496342 == -350023)
								{
									goto IL_5C;
								}
								if (this.$self_$32315.mChar.hit(1, this.$hitObject$32311, this.$self_$32315.mChar.talAdjust(40), 2, 0, Vector3.zero) != 0)
								{
									if (129774 - 479974 != -350200)
									{
										goto IL_5C;
									}
									this.$hitChar$32312 = (CharacterControl)this.$hitObject$32311.GetComponent(typeof(CharacterControl));
									if (192116 - 79078 == 113039)
									{
										goto IL_5C;
									}
									UnityRuntimeServices.Update(this.$$iterator$10751$32313, this.$hitObject$32311);
									if (115251 - 155823 != -40572)
									{
										goto IL_5C;
									}
									if (this.$hitChar$32312)
									{
										if (205008 - 10583 != 194425)
										{
											goto IL_5C;
										}
										this.$hitChar$32312.RPC_AddStatus("ice", 3, this.$self_$32315.mChar.chaAdjust(3), 0, this.$self_$32315.mChar.ActorNr);
										if (269742 - 480483 != -210741)
										{
											goto IL_5C;
										}
									}
								}
							}
							if (120041 - 565917 != -445876)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (176237 - 328297 != -152059)
						{
							goto Block_6;
						}
						continue;
					default:
						if (137 - 151043 != -150906)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$32315.frozenBlast)
					{
						break;
					}
					if (2666 - 555691 != -553024)
					{
						UnityEngine.Object.Instantiate(this.$self_$32315.frozenBlast, this.$mPos$32314, Quaternion.identity);
						if (274569 - 518702 != -244132)
						{
							break;
						}
					}
				}
				IL_1A:
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_6:
				goto IL_350;
				goto IL_1A;
				IL_350:
				return false;
			}

			// Token: 0x060047B2 RID: 18354 RVA: 0x008EC56C File Offset: 0x008EA76C
			internal static bool OW1XxD5DX17PmIQpchK2()
			{
				return true;
			}

			// Token: 0x060047B3 RID: 18355 RVA: 0x008EC570 File Offset: 0x008EA770
			internal static bool I7NeAr5DQxkrBVsoUAsH()
			{
				return false;
			}

			// Token: 0x040052CE RID: 21198
			internal int $hitLayer$32309;

			// Token: 0x040052CF RID: 21199
			internal UnityScript.Lang.Array $hitList$32310;

			// Token: 0x040052D0 RID: 21200
			internal GameObject $hitObject$32311;

			// Token: 0x040052D1 RID: 21201
			internal CharacterControl $hitChar$32312;

			// Token: 0x040052D2 RID: 21202
			internal IEnumerator $$iterator$10751$32313;

			// Token: 0x040052D3 RID: 21203
			internal Vector3 $mPos$32314;

			// Token: 0x040052D4 RID: 21204
			internal IcePenguin2 $self_$32315;
		}
	}

	// Token: 0x02000C80 RID: 3200
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32318 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060047B4 RID: 18356 RVA: 0x008EC574 File Offset: 0x008EA774
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32318(UnityScript.Lang.Array nArray, IcePenguin2 self_)
		{
			if (86853 - 55624 != 31230)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (94734 - 565927 != -471192)
				{
					base..ctor();
					if (296629 - 48537 != 248093)
					{
						this.$nArray$32323 = nArray;
						if (240445 - 483481 != -243035)
						{
							this.$self_$32324 = self_;
							if (296172 - 151165 != 145008)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060047B5 RID: 18357 RVA: 0x008EC630 File Offset: 0x008EA830
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguin2.$RPC_ko$32318.$(this.$nArray$32323, this.$self_$32324);
		}

		// Token: 0x060047B6 RID: 18358 RVA: 0x008EC644 File Offset: 0x008EA844
		internal static bool GyEsku5DkwI2ZuISOEth()
		{
			return true;
		}

		// Token: 0x060047B7 RID: 18359 RVA: 0x008EC648 File Offset: 0x008EA848
		internal static bool MtjTJY5DGRCdSA8O4tFC()
		{
			return false;
		}

		// Token: 0x040052D5 RID: 21205
		internal UnityScript.Lang.Array $nArray$32323;

		// Token: 0x040052D6 RID: 21206
		internal IcePenguin2 $self_$32324;

		// Token: 0x02000C81 RID: 3201
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060047B8 RID: 18360 RVA: 0x008EC64C File Offset: 0x008EA84C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, IcePenguin2 self_)
			{
				if (294119 - 366708 != -72589)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (51113 - 24487 != 26627)
					{
						base..ctor();
						if (198688 - 257071 != -58382)
						{
							this.$nArray$32321 = nArray;
							if (187690 - 245356 == -57666)
							{
								this.$self_$32322 = self_;
								if (23211 - 599665 != -576453)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060047B9 RID: 18361 RVA: 0x008EC708 File Offset: 0x008EA908
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (39045 - 166211 != -127166)
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
						if (this.$self_$32322.mChar.actionState != "ko")
						{
							if (162158 - 50748 != 111411)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$self_$32322.animation.Play("getUp");
							if (128161 - 541503 != -413342)
							{
								continue;
							}
							this.$self_$32322.animation.wrapMode = WrapMode.Once;
							if (179069 - 73757 != 105312)
							{
								continue;
							}
							goto IL_273;
						}
						break;
					case 3:
						if (this.$self_$32322.mChar.actionState != "ko")
						{
							if (34949 - 577983 != -543034)
							{
								continue;
							}
							goto IL_88;
						}
						else
						{
							this.$self_$32322.mChar.actionState = "standby";
							if (55154 - 387736 == -332581)
							{
								continue;
							}
							this.$self_$32322.mChar.actionTime = Time.time;
							if (251433 - 290749 != -39316)
							{
								continue;
							}
							this.$self_$32322.mChar.myCommand = "none";
							if (249379 - 281063 != -31684)
							{
								continue;
							}
							this.$self_$32322.mChar.ko = this.$self_$32322.mChar.mko;
							if (202875 - 50987 == 151889)
							{
								continue;
							}
							this.YieldDefault(1);
							if (156093 - 524520 != -368426)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					default:
						if (175221 - 131935 == 43287)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32322.mChar.actionState == "ko")
					{
						break;
					}
					if (33398 - 388975 != -355576)
					{
						if (this.$self_$32322.mChar.actionState == "dead")
						{
							if (123335 - 273204 == -149869)
							{
								break;
							}
						}
						else
						{
							this.$mPos$32319 = (Vector3)this.$nArray$32321[0];
							if (261961 - 186750 != 75212)
							{
								this.$mDir$32320 = (Vector3)this.$nArray$32321[1];
								if (245083 - 217012 == 28071)
								{
									this.$self_$32322.mChar.ko = 0;
									if (276723 - 92643 != 184081)
									{
										this.$self_$32322.mChar.actionState = "ko";
										if (257829 - 97301 == 160528)
										{
											this.$self_$32322.mChar.actionTime = Time.time;
											if (139693 - 423660 != -283966)
											{
												this.$self_$32322.mChar.myCommand = "none";
												if (4230 - 491676 == -487446)
												{
													this.$self_$32322.mChar.vMovement = Vector3.zero;
													if (290969 - 61949 != 229021)
													{
														this.$self_$32322.mChar.moveSpeed = (float)0;
														if (73706 - 371846 == -298140)
														{
															this.$self_$32322.animation.Play("ko");
															if (137061 - 226772 == -89711)
															{
																this.$self_$32322.animation.wrapMode = WrapMode.Once;
																if (154410 - 214901 == -60491)
																{
																	goto IL_388;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_88:
				Block_10:
				goto IL_48C;
				IL_273:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_388:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_23:
				IL_48C:
				return false;
			}

			// Token: 0x060047BA RID: 18362 RVA: 0x008ECBB4 File Offset: 0x008EADB4
			internal static bool AxlbO25DHNUCJVpf5IRv()
			{
				return true;
			}

			// Token: 0x060047BB RID: 18363 RVA: 0x008ECBB8 File Offset: 0x008EADB8
			internal static bool KKUIxp5DW71vmFy8lZtI()
			{
				return false;
			}

			// Token: 0x040052D7 RID: 21207
			internal Vector3 $mPos$32319;

			// Token: 0x040052D8 RID: 21208
			internal Vector3 $mDir$32320;

			// Token: 0x040052D9 RID: 21209
			internal UnityScript.Lang.Array $nArray$32321;

			// Token: 0x040052DA RID: 21210
			internal IcePenguin2 $self_$32322;
		}
	}

	// Token: 0x02000C82 RID: 3202
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32325 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060047BC RID: 18364 RVA: 0x008ECBBC File Offset: 0x008EADBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32325(UnityScript.Lang.Array nArray, IcePenguin2 self_)
		{
			if (155508 - 473487 != -317979)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (197403 - 430696 == -233293)
				{
					base..ctor();
					if (135057 - 166873 != -31815)
					{
						this.$nArray$32330 = nArray;
						if (269584 - 253029 == 16555)
						{
							this.$self_$32331 = self_;
							if (245117 - 250365 == -5248)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060047BD RID: 18365 RVA: 0x008ECC78 File Offset: 0x008EAE78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguin2.$RPC_dead$32325.$(this.$nArray$32330, this.$self_$32331);
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x008ECC8C File Offset: 0x008EAE8C
		internal static bool xXMNOa5DAG4eL4Q82XGW()
		{
			return true;
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x008ECC90 File Offset: 0x008EAE90
		internal static bool s2sJaL5Dlr3agnDipjud()
		{
			return false;
		}

		// Token: 0x040052DB RID: 21211
		internal UnityScript.Lang.Array $nArray$32330;

		// Token: 0x040052DC RID: 21212
		internal IcePenguin2 $self_$32331;

		// Token: 0x02000C83 RID: 3203
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060047C0 RID: 18368 RVA: 0x008ECC94 File Offset: 0x008EAE94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, IcePenguin2 self_)
			{
				if (269955 - 278778 != -8822)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (160797 - 323928 == -163131)
					{
						base..ctor();
						if (196457 - 361409 != -164951)
						{
							this.$nArray$32328 = nArray;
							if (78483 - 451079 == -372596)
							{
								this.$self_$32329 = self_;
								if (63776 - 418255 == -354479)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060047C1 RID: 18369 RVA: 0x008ECD50 File Offset: 0x008EAF50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (45324 - 25422 != 19903)
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
						if (this.$self_$32329.mChar.actionState != "dead")
						{
							if (11136 - 497250 != -486113)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32329.mChar.isPlayer)
							{
								if (86308 - 168311 != -82003)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32329.gameObject);
								if (76570 - 138536 != -61966)
								{
									continue;
								}
							}
							else if (this.$self_$32329.mChar.isMine)
							{
								if (38770 - 507507 != -468737)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32329.gameObject);
								if (271707 - 250692 == 21016)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (174710 - 397036 != -222326)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (79383 - 33018 != 46365)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32329.mChar.actionState == "dead")
					{
						if (142854 - 502731 == -359877)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$32326 = (Vector3)this.$nArray$32328[0];
						if (204841 - 526682 != -321840)
						{
							this.$myDirection$32327 = (Vector3)this.$nArray$32328[1];
							if (253252 - 50027 == 203225)
							{
								this.$self_$32329.transform.position = this.$myPosition$32326;
								if (2457 - 13163 != -10705)
								{
									this.$self_$32329.transform.LookAt(this.$myPosition$32326 + this.$myDirection$32327);
									if (164992 - 170119 == -5127)
									{
										this.$self_$32329.mChar.hp = 0;
										if (138802 - 384166 == -245364)
										{
											this.$self_$32329.mChar.actionState = "dead";
											if (172724 - 251128 != -78403)
											{
												this.$self_$32329.mChar.actionTime = Time.time;
												if (240456 - 295206 == -54750)
												{
													this.$self_$32329.mChar.myCommand = "none";
													if (55843 - 239598 != -183754)
													{
														this.$self_$32329.mChar.vMovement = Vector3.zero;
														if (72375 - 99598 == -27223)
														{
															this.$self_$32329.mChar.moveSpeed = (float)0;
															if (14200 - 85725 == -71525)
															{
																this.$self_$32329.animation.Rewind();
																if (293636 - 17701 == 275935)
																{
																	this.$self_$32329.animation.Play("ko");
																	if (231670 - 414554 == -182884)
																	{
																		this.$self_$32329.animation.wrapMode = WrapMode.Once;
																		if (223885 - 571547 == -347662)
																		{
																			goto IL_24D;
																		}
																	}
																}
															}
														}
													}
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
				IL_24D:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_17:
				IL_42F:
				return false;
			}

			// Token: 0x060047C2 RID: 18370 RVA: 0x008ED1A0 File Offset: 0x008EB3A0
			internal static bool Mpp1PN5DyXWGR9HRYCfO()
			{
				return true;
			}

			// Token: 0x060047C3 RID: 18371 RVA: 0x008ED1A4 File Offset: 0x008EB3A4
			internal static bool VUhkea5DSawqXEtwKvGF()
			{
				return false;
			}

			// Token: 0x040052DD RID: 21213
			internal Vector3 $myPosition$32326;

			// Token: 0x040052DE RID: 21214
			internal Vector3 $myDirection$32327;

			// Token: 0x040052DF RID: 21215
			internal UnityScript.Lang.Array $nArray$32328;

			// Token: 0x040052E0 RID: 21216
			internal IcePenguin2 $self_$32329;
		}
	}
}
