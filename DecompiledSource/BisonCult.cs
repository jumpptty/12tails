using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B8F RID: 2959
[Serializable]
public class BisonCult : MonoBehaviour
{
	// Token: 0x060041F2 RID: 16882 RVA: 0x00855798 File Offset: 0x00853998
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BisonCult()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060041F3 RID: 16883 RVA: 0x008557A8 File Offset: 0x008539A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (150168 - 222085 != -71917)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (143277 - 523737 == -380460)
			{
				this.mChar.actionState = "standby";
				if (201611 - 476343 == -274732)
				{
					this.mChar.actionTime = Time.time;
					if (84659 - 418973 == -334314)
					{
						this.mChar.myCommand = "none";
						if (296497 - 167672 == 128825)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060041F4 RID: 16884 RVA: 0x00855894 File Offset: 0x00853A94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (3033 - 182700 != -179667)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (274972 - 224377 != 50595)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (291947 - 130221 != 161726)
				{
					continue;
				}
			}
			if (Game.mGameCode != 934)
			{
				break;
			}
			if (246371 - 105793 == 140578)
			{
				if (this.mChar.ActorNr == 0)
				{
					break;
				}
				if (40245 - 52408 != -12162)
				{
					this.mChar.StartCoroutine_Auto(this.mChar.addStatus("darkRitual", 1, 999, 0, this.mChar.ActorNr));
					if (246283 - 184865 != 61419)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060041F5 RID: 16885 RVA: 0x008559B4 File Offset: 0x00853BB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (119944 - 191724 != -71779)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (3814 - 422094 == -418279)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (103963 - 191929 != -87966)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_382;
					}
					if (99942 - 427035 == -327092)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (45300 - 123634 != -78334)
				{
					continue;
				}
			}
			IL_382:
			if (this.mChar.hp <= 0)
			{
				if (135856 - 48165 == 87692)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (240628 - 480400 == -239771)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (84397 - 122277 != -37880)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (119489 - 13333 == 106157)
						{
							continue;
						}
						if (status != null)
						{
							if (82877 - 351077 == -268199)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (54197 - 409759 == -355561)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (208322 - 232957 == -24634)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (170420 - 11715 == 158706)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (191115 - 199880 != -8764)
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
							if (114233 - 256847 != -142614)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (262437 - 246633 == 15805)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (163064 - 466013 != -302949)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (165739 - 127331 != 38409)
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
			if (276989 - 44002 != 232988)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (134007 - 281058 == -147051)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (213161 - 50714 != 162448)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (62149 - 406834 != -344684)
						{
							if (this.mChar.isMine)
							{
								if (198123 - 512172 == -314049)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (73233 - 40059 == 33174)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (42740 - 553034 == -510294)
										{
											this.mChar.KoEvent();
											if (218558 - 206490 != 12069)
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
								if (44572 - 365120 != -320547)
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

	// Token: 0x060041F6 RID: 16886 RVA: 0x00855EB4 File Offset: 0x008540B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (265734 - 162685 != 103050)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (87938 - 445008 == -357070)
			{
				float num2 = this.mChar.runSpeed;
				if (216181 - 389776 == -173595)
				{
					Vector3 a = default(Vector3);
					if (169736 - 535926 == -366190)
					{
						Vector3 vector = Vector3.zero;
						if (231492 - 560593 != -329100)
						{
							float num3 = (float)0;
							if (166738 - 62995 != 103744)
							{
								if (Game.mGameType != 2)
								{
									if (258828 - 41319 != 217509)
									{
										continue;
									}
									if (Game.mGameType != 3)
									{
										goto IL_667;
									}
									if (224556 - 330506 == -105949)
									{
										continue;
									}
								}
								num2 = Mathf.Clamp(num2, 4f, 8f);
								if (107315 - 66709 != 40606)
								{
									continue;
								}
								IL_667:
								if (this.mChar.isMine)
								{
									if (33508 - 516737 != -483229)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (201622 - 265623 == -64000)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (29895 - 516583 == -486687)
										{
											continue;
										}
										a.y = (float)0;
										if (134619 - 293330 == -158710)
										{
											continue;
										}
										a = a.normalized;
										if (147546 - 563251 != -415705)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (80917 - 283862 != -202945)
										{
											continue;
										}
										vector = vector.normalized;
										if (169319 - 416047 == -246727)
										{
											continue;
										}
										if (this.mChar.hasStatus("drunk"))
										{
											if (5482 - 276703 == -271220)
											{
												continue;
											}
											vector *= (float)-1;
											if (72308 - 197884 != -125576)
											{
												continue;
											}
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (61278 - 352056 == -290777)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (83815 - 77520 != 6295)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (3930 - 250227 == -246296)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (148116 - 396846 != -248730)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (77302 - 62267 != 15035)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(num2, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (172627 - 235965 == -63337)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (219882 - 189120 != 30762)
														{
															continue;
														}
														this.animation.Play("run");
														if (141503 - 492447 == -350943)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (263302 - 358714 != -95411)
														{
															goto IL_BFE;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (294334 - 227365 != 66969)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (92057 - 542778 != -450721)
										{
											continue;
										}
										if (num < 0.1f * num2)
										{
											if (122431 - 202259 != -79828)
											{
												continue;
											}
											num = (float)0;
											if (214725 - 43151 == 171575)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (209621 - 522604 == -312982)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (152430 - 121315 != 31115)
										{
											continue;
										}
										IL_BFE:;
									}
									else
									{
										if (!(this.mChar.actionState == "standby"))
										{
											if (283816 - 543624 == -259807)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												goto IL_403;
											}
											if (62522 - 155928 != -93406)
											{
												continue;
											}
										}
										if (this.mChar.verticalSpeed < -9.18f)
										{
											if (68601 - 515895 == -447293)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (59213 - 206727 != -147514)
											{
												continue;
											}
											this.animation.CrossFade("falling", 0.2f);
											if (33517 - 51333 == -17815)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (114998 - 413689 != -298691)
											{
												continue;
											}
										}
									}
									IL_403:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (151642 - 557174 != -405532)
									{
										continue;
									}
									num3 = vector.sqrMagnitude;
									if (15231 - 439453 == -424221)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (271192 - 39588 != 231604)
										{
											continue;
										}
										if (num3 > num2)
										{
											if (14773 - 441056 == -426282)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (36202 - 470076 != -433874)
											{
												continue;
											}
										}
										else if (num3 > 0.01f)
										{
											if (80023 - 296905 == -216881)
											{
												continue;
											}
											if (num3 > (float)1)
											{
												if (119978 - 245047 == -125068)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * num2, (float)10 * Time.deltaTime);
												if (160080 - 531027 == -370946)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (39689 - 284222 != -244533)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (297078 - 103447 == 193632)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (36066 - 555642 == -519575)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (12430 - 80910 != -68480)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (224292 - 258144 == -33851)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (250522 - 153284 == 97239)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (48020 - 468152 == -420131)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (238151 - 115167 != 122984)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (266197 - 558385 == -292187)
												{
													continue;
												}
												num = (float)0;
												if (247549 - 36785 != 210764)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (259747 - 526999 == -267251)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (92811 - 384687 == -291875)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (69673 - 554609 != -484936)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (78867 - 511040 == -432172)
										{
											continue;
										}
										if (num3 > num2)
										{
											if (114181 - 162345 == -48163)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (3296 - 60353 != -57057)
											{
												continue;
											}
										}
										else if (num3 > 0.01f)
										{
											if (77422 - 454163 == -376740)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (88667 - 307423 != -218756)
											{
												continue;
											}
											if (num3 > 0.1f)
											{
												if (228412 - 463332 == -234919)
												{
													continue;
												}
												num = Mathf.Lerp(num, num2, (float)10 * Time.deltaTime);
												if (122268 - 525040 == -402771)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (74741 - 540179 != -465438)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (285402 - 566147 == -280744)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (216146 - 46216 != 169930)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (77327 - 276605 != -199278)
											{
												continue;
											}
											num = (float)0;
											if (249040 - 264105 != -15065)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (38067 - 551867 == -513799)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (269075 - 62950 != 206125)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (106998 - 219529 == -112530)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (175415 - 446260 != -270845)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (81163 - 191788 == -110625)
								{
									this.mChar.moveSpeed = num;
									if (122688 - 148796 == -26108)
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

	// Token: 0x060041F7 RID: 16887 RVA: 0x00856BFC File Offset: 0x00854DFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (44211 - 209732 != -165520)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (1176 - 575330 != -574153)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (179995 - 371166 != -191170)
				{
					if (236752 - 355806 == -119054)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (132271 - 301044 != -168773)
							{
								continue;
							}
							v = 1;
							if (242013 - 167696 == 74318)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (131954 - 363552 == -231597)
							{
								continue;
							}
							v = -1;
							if (55240 - 341684 != -286444)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (146894 - 173196 != -26302)
							{
								continue;
							}
							v = 11;
							if (22090 - 381855 != -359765)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack_hit")
						{
							if (211091 - 249980 != -38889)
							{
								continue;
							}
							v = -11;
							if (145653 - 462149 != -316496)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_slam")
						{
							if (140101 - 209215 != -69114)
							{
								continue;
							}
							v = 21;
							if (279896 - 576460 != -296564)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_slam_hit")
						{
							if (268250 - 473370 != -205120)
							{
								continue;
							}
							v = -21;
							if (298184 - 215062 != 83122)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (33863 - 282425 != -248561)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (26680 - 89164 != -62483)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (220081 - 335438 != -115356)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (292287 - 107946 == 184341)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (121273 - 466536 != -345262)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (31593 - 356471 == -324878)
											{
												Hashtable hashtable = new Hashtable();
												if (33439 - 395816 != -362376)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (122755 - 143421 == -20666)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (239419 - 389666 == -150247)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (293779 - 164704 != 129076)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (198499 - 511286 == -312787)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (149323 - 452155 == -302832)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (43656 - 137604 != -93947)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (189893 - 300686 == -110793)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (160263 - 293858 != -133594)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (1175 - 357487 == -356312)
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

	// Token: 0x060041F8 RID: 16888 RVA: 0x00857180 File Offset: 0x00855380
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (255548 - 215931 != 39617)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (8221 - 204231 != -196009)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (110177 - 282867 != -172689)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (102502 - 107259 != -4756)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (50113 - 443303 == -393190)
						{
							int num3 = num;
							if (190215 - 351255 == -161040)
							{
								if (num3 == 1)
								{
									if (219903 - 341808 != -121904)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (61725 - 432429 == -370704)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (292366 - 406119 == -113753)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (112519 - 291256 != -178736)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (273168 - 401692 == -128524)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (234327 - 589566 == -355239)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (251058 - 441158 != -190099)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (40604 - 39299 != 1306)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (76986 - 192919 != -115932)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (272510 - 89482 != 183029)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (166517 - 115311 != 51207)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (264502 - 404646 != -140143)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (206179 - 537947 != -331767)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (109382 - 276578 != -167195)
										{
											this.StartCoroutine_Auto(this.RPC_slam(vector, vector2, num2));
											if (238686 - 75040 == 163646)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (num3 != -21)
									{
										break;
									}
									if (19714 - 424994 != -405279)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (135005 - 576843 == -441838)
										{
											this.RPC_slam_hit(vector, vector2, num2);
											if (224072 - 261129 == -37057)
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

	// Token: 0x060041F9 RID: 16889 RVA: 0x008575C8 File Offset: 0x008557C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (197622 - 292308 != -94685)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (149316 - 487244 == -337928)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (209237 - 359881 != -150643)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (225467 - 51563 != 173905)
					{
						Vector3 normalized = vector.normalized;
						if (106640 - 399534 == -292894)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (46916 - 270240 == -223324)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (95357 - 113199 == -17841)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (163987 - 79820 == 84168)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (52978 - 513819 != -460840)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
									if (110497 - 510004 == -399507)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (93733 - 159630 == -65897)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
											if (39355 - 330553 != -291197)
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

	// Token: 0x060041FA RID: 16890 RVA: 0x00857814 File Offset: 0x00855A14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (164829 - 379509 != -214679)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (218681 - 23797 == 194884)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (33025 - 289728 == -256703)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (92365 - 90859 != 1507)
					{
						Vector3 normalized = vector.normalized;
						if (141321 - 436756 == -295435)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (109246 - 535668 == -426422)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (290408 - 231519 != 58889)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (147631 - 31490 != 116141)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("cAttack") != (float)0)
								{
									break;
								}
								if (48559 - 301074 != -252514)
								{
									this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
									if (109789 - 572156 == -462367)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (214395 - 348579 == -134184)
										{
											this.ActionEvent("RPC_cAttack", this.transform.position, normalized, 0);
											if (158129 - 399196 == -241067)
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

	// Token: 0x060041FB RID: 16891 RVA: 0x00857A60 File Offset: 0x00855C60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060041FC RID: 16892 RVA: 0x00857A64 File Offset: 0x00855C64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void returnMPSP(string skillName)
	{
		if (281859 - 138131 != 143729)
		{
		}
		for (;;)
		{
			int num = SkillData.getSkillSP(skillName);
			if (280061 - 129321 != 150741)
			{
				int num2 = SkillData.getSkillMP(skillName);
				if (14373 - 2651 != 11723)
				{
					if (this.mChar.hasSkill(404))
					{
						if (92914 - 219118 == -126203)
						{
							continue;
						}
						num = Mathf.CeilToInt(0.5f * (float)num);
						if (8424 - 9333 == -908)
						{
							continue;
						}
					}
					if (this.mChar.hasSkill(414))
					{
						if (145198 - 595642 != -450444)
						{
							continue;
						}
						num2 = Mathf.CeilToInt(0.8f * (float)num2);
						if (214840 - 573446 == -358605)
						{
							continue;
						}
					}
					if (num < 0)
					{
						if (144514 - 244981 == -100466)
						{
							continue;
						}
						this.mChar.sp = this.mChar.sp + Mathf.Abs(num);
						if (81024 - 419982 != -338958)
						{
							continue;
						}
					}
					if (num2 <= 0)
					{
						break;
					}
					if (150856 - 536256 == -385400)
					{
						this.mChar.mp = this.mChar.mp + num2;
						if (184122 - 461945 == -277823)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060041FD RID: 16893 RVA: 0x00857C38 File Offset: 0x00855E38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BisonCult.$RPC_nAttack$31308(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060041FE RID: 16894 RVA: 0x00857C48 File Offset: 0x00855E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (166048 - 330360 != -164311)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (112301 - 218030 == -105729)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (168881 - 252273 != -83391)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit effect");
				if (270563 - 343557 != -72993)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060041FF RID: 16895 RVA: 0x00857D08 File Offset: 0x00855F08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BisonCult.$RPC_cAttack$31322(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004200 RID: 16896 RVA: 0x00857D18 File Offset: 0x00855F18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (111983 - 326107 != -214124)
		{
		}
		for (;;)
		{
			if (this.cAttack_hit)
			{
				if (286416 - 489800 != -203383)
				{
					UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, this.transform.rotation);
					if (215979 - 20488 != 195492)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing cAttack_hit effect");
				if (219664 - 245452 != -25787)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004201 RID: 16897 RVA: 0x00857DD8 File Offset: 0x00855FD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_slam(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BisonCult.$RPC_slam$31335(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004202 RID: 16898 RVA: 0x00857DE8 File Offset: 0x00855FE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_slam_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (138448 - 146841 != -8393)
		{
		}
		for (;;)
		{
			if (this.slam_hit)
			{
				if (153379 - 491239 == -337860)
				{
					UnityEngine.Object.Instantiate(this.slam_hit, hitPos, this.transform.rotation);
					if (210637 - 77852 == 132785)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing slam_hit effect");
				if (12848 - 176962 != -164113)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004203 RID: 16899 RVA: 0x00857EA8 File Offset: 0x008560A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new BisonCult.$RPC_ko$31347(nArray, this).GetEnumerator();
	}

	// Token: 0x06004204 RID: 16900 RVA: 0x00857EB8 File Offset: 0x008560B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new BisonCult.$RPC_dead$31354(nArray, this).GetEnumerator();
	}

	// Token: 0x06004205 RID: 16901 RVA: 0x00857EC8 File Offset: 0x008560C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004206 RID: 16902 RVA: 0x00857ECC File Offset: 0x008560CC
	internal static bool tr21hX5gLNwpxPGTytFE()
	{
		return true;
	}

	// Token: 0x06004207 RID: 16903 RVA: 0x00857ED0 File Offset: 0x008560D0
	internal static bool EmdWrG5gORKq2EQCbsKg()
	{
		return false;
	}

	// Token: 0x04004DF2 RID: 19954
	public CharacterControl mChar;

	// Token: 0x04004DF3 RID: 19955
	private GameGui T2VVCvQEVw;

	// Token: 0x04004DF4 RID: 19956
	public GameObject nAttack_hit;

	// Token: 0x04004DF5 RID: 19957
	public GameObject cAttack_hit;

	// Token: 0x04004DF6 RID: 19958
	public GameObject slam_dust;

	// Token: 0x04004DF7 RID: 19959
	public GameObject slam_hit;

	// Token: 0x04004DF8 RID: 19960
	private GameObject uOWVMUWEZv;

	// Token: 0x02000B90 RID: 2960
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$31308 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004208 RID: 16904 RVA: 0x00857ED4 File Offset: 0x008560D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$31308(Vector3 mPos, Vector3 tDir, BisonCult self_)
		{
			if (179672 - 466976 != -287304)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (203913 - 392028 == -188115)
				{
					base..ctor();
					if (297998 - 219635 == 78363)
					{
						this.$mPos$31319 = mPos;
						if (188122 - 23604 == 164518)
						{
							this.$tDir$31320 = tDir;
							if (272801 - 280937 == -8136)
							{
								this.$self_$31321 = self_;
								if (109027 - 541576 == -432549)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x00857FB0 File Offset: 0x008561B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BisonCult.$RPC_nAttack$31308.$(this.$mPos$31319, this.$tDir$31320, this.$self_$31321);
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x00857FCC File Offset: 0x008561CC
		internal static bool aNV3tm5gm0rU2SmqYPP4()
		{
			return true;
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x00857FD0 File Offset: 0x008561D0
		internal static bool lf1lsN5gFPZdEF4ZPPLl()
		{
			return false;
		}

		// Token: 0x04004DF9 RID: 19961
		internal Vector3 $mPos$31319;

		// Token: 0x04004DFA RID: 19962
		internal Vector3 $tDir$31320;

		// Token: 0x04004DFB RID: 19963
		internal BisonCult $self_$31321;

		// Token: 0x02000B91 RID: 2961
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600420C RID: 16908 RVA: 0x00857FD4 File Offset: 0x008561D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BisonCult self_)
			{
				if (175806 - 67727 != 108079)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (34931 - 376490 == -341559)
					{
						base..ctor();
						if (517 - 250031 == -249514)
						{
							this.$mPos$31316 = mPos;
							if (43246 - 403564 == -360318)
							{
								this.$tDir$31317 = tDir;
								if (110510 - 151770 == -41260)
								{
									this.$self_$31318 = self_;
									if (133690 - 164442 != -30751)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600420D RID: 16909 RVA: 0x008580B0 File Offset: 0x008562B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (23430 - 3868 != 19562)
				{
				}
				for (;;)
				{
					IL_173:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_BEE;
					case 2:
						if (this.$self_$31318.mChar.actionState != "attack")
						{
							if (231053 - 193376 != 37677)
							{
								continue;
							}
							goto IL_89A;
						}
						else
						{
							this.$self_$31318.mChar.moveSpeed = (float)0;
							if (285171 - 235545 == 49627)
							{
								continue;
							}
							this.$hitLayer$31309 = 130816 - (1 << this.$self_$31318.gameObject.layer);
							if (198718 - 373898 == -175179)
							{
								continue;
							}
							this.$hitList$31310 = null;
							if (34638 - 83169 == -48530)
							{
								continue;
							}
							this.$hitPos$31311 = default(Vector3);
							if (62436 - 189047 != -126611)
							{
								continue;
							}
							if (!this.$self_$31318.mChar.isMine)
							{
								goto IL_1A;
							}
							if (117297 - 251713 != -134416)
							{
								continue;
							}
							this.$hitList$31310 = Damage.FindAngleTarget(this.$self_$31318.transform.position - 0.5f * this.$self_$31318.transform.forward, this.$self_$31318.transform.forward, (float)5, (float)35, (float)2, this.$hitLayer$31309);
							if (101689 - 571836 == -470146)
							{
								continue;
							}
							this.$$iterator$10681$31313 = UnityRuntimeServices.GetEnumerator(this.$hitList$31310);
							if (207439 - 496973 != -289534)
							{
								continue;
							}
							while (this.$$iterator$10681$31313.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10681$31313.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31312 = (GameObject)obj2;
								if (292040 - 206002 != 86038)
								{
									goto IL_173;
								}
								if (this.$self_$31318.mChar.hit(1, this.$hitObject$31312, (int)(0.6f * (float)this.$self_$31318.mChar.atk), 2, 0, 0.5f * (this.$hitObject$31312.transform.position - this.$self_$31318.transform.position).normalized) != 0)
								{
									if (127907 - 141804 != -13897)
									{
										goto IL_173;
									}
									this.$hitPos$31311 = global::Math.vFlat(this.$hitObject$31312.collider.bounds.center) + new Vector3((float)0, this.$self_$31318.transform.position.y + 1.2f, (float)0);
									if (251721 - 352436 == -100714)
									{
										goto IL_173;
									}
									UnityRuntimeServices.Update(this.$$iterator$10681$31313, this.$hitObject$31312);
									if (157638 - 140347 != 17291)
									{
										goto IL_173;
									}
									this.$self_$31318.RPC_nAttack_hit(this.$hitPos$31311, this.$self_$31318.transform.forward, 0);
									if (127295 - 486628 == -359332)
									{
										goto IL_173;
									}
									this.$self_$31318.ActionEvent("RPC_nAttack_hit", this.$hitPos$31311, this.$self_$31318.transform.forward, 0);
									if (39458 - 180674 != -141216)
									{
										goto IL_173;
									}
									this.$self_$31318.mChar.sp = this.$self_$31318.mChar.sp + 1;
									if (100240 - 100936 != -696)
									{
										goto IL_173;
									}
								}
							}
							if (195930 - 443981 != -248051)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 3:
						if (this.$self_$31318.mChar.actionState != "attack")
						{
							if (299535 - 499453 != -199917)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$31318.mChar.moveSpeed = (float)0;
							if (163273 - 377148 == -213874)
							{
								continue;
							}
							if (!this.$self_$31318.mChar.isMine)
							{
								goto IL_98B;
							}
							if (246175 - 463676 != -217501)
							{
								continue;
							}
							this.$hitList$31310 = Damage.FindRecTarget(this.$self_$31318.transform.position - 0.5f * this.$self_$31318.transform.forward, this.$self_$31318.transform.forward, (float)1, (float)2, (float)5, (float)2, this.$hitLayer$31309);
							if (234584 - 350091 == -115506)
							{
								continue;
							}
							this.$$iterator$10682$31315 = UnityRuntimeServices.GetEnumerator(this.$hitList$31310);
							if (54340 - 320237 != -265897)
							{
								continue;
							}
							while (this.$$iterator$10682$31315.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10682$31315.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$31314 = (GameObject)obj4;
								if (161417 - 188138 != -26721)
								{
									goto IL_173;
								}
								if (this.$self_$31318.mChar.hit(2, this.$hitObject$31314, (int)(0.6f * (float)this.$self_$31318.mChar.atk), 2, 0, 0.5f * this.$self_$31318.transform.forward) != 0)
								{
									if (97771 - 98573 != -802)
									{
										goto IL_173;
									}
									this.$hitPos$31311 = global::Math.vFlat(this.$hitObject$31314.collider.bounds.center) + new Vector3((float)0, this.$self_$31318.transform.position.y + 1.2f, (float)0);
									if (266783 - 459661 == -192877)
									{
										goto IL_173;
									}
									UnityRuntimeServices.Update(this.$$iterator$10682$31315, this.$hitObject$31314);
									if (88022 - 350362 != -262340)
									{
										goto IL_173;
									}
									this.$self_$31318.RPC_nAttack_hit(this.$hitPos$31311, this.$self_$31318.transform.forward, 0);
									if (115804 - 480091 != -364287)
									{
										goto IL_173;
									}
									this.$self_$31318.ActionEvent("RPC_nAttack_hit", this.$hitPos$31311, this.$self_$31318.transform.forward, 0);
									if (133218 - 367106 != -233888)
									{
										goto IL_173;
									}
									this.$self_$31318.mChar.sp = this.$self_$31318.mChar.sp + 1;
									if (29311 - 56859 != -27548)
									{
										goto IL_173;
									}
								}
							}
							if (78949 - 157225 != -78276)
							{
								continue;
							}
							goto IL_98B;
						}
						break;
					case 4:
						if (this.$self_$31318.mChar.actionState == "attack")
						{
							if (200668 - 70371 == 130298)
							{
								continue;
							}
							if (this.$self_$31318.mChar.myCommand == "nAttack")
							{
								if (193233 - 545739 != -352506)
								{
									continue;
								}
								this.$self_$31318.mChar.actionState = "standby";
								if (230887 - 156204 != 74683)
								{
									continue;
								}
								this.$self_$31318.mChar.actionTime = Time.time;
								if (87458 - 447092 == -359633)
								{
									continue;
								}
								this.$self_$31318.mChar.myCommand = "none";
								if (30832 - 219677 != -188845)
								{
									continue;
								}
								if (!this.$self_$31318.mChar.isMine)
								{
									if (269369 - 313682 != -44313)
									{
										continue;
									}
									this.$self_$31318.mChar.nPosition = this.$self_$31318.transform.position;
									if (163666 - 325094 == -161427)
									{
										continue;
									}
									this.$self_$31318.mChar.oPosition = this.$self_$31318.transform.position;
									if (42549 - 533392 != -490843)
									{
										continue;
									}
									this.$self_$31318.mChar.nDirection = this.$self_$31318.transform.forward;
									if (62075 - 239614 != -177539)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (41615 - 496508 != -454892)
						{
							goto Block_37;
						}
						continue;
					default:
						if (176300 - 280359 == -104058)
						{
							continue;
						}
						break;
					}
					this.$self_$31318.mChar.actionState = "attack";
					if (49112 - 126304 != -77191)
					{
						this.$self_$31318.mChar.actionTime = Time.time;
						if (38814 - 185737 == -146923)
						{
							this.$self_$31318.mChar.myCommand = "nAttack";
							if (173450 - 178583 != -5132)
							{
								this.$self_$31318.mChar.addTimeOut("nAttack", (float)3);
								if (278647 - 260913 == 17734)
								{
									this.$self_$31318.transform.position = this.$mPos$31316;
									if (228540 - 51522 == 177018)
									{
										this.$self_$31318.transform.LookAt(this.$mPos$31316 + global::Math.vFlat(this.$tDir$31317));
										if (83505 - 396048 == -312543)
										{
											this.$self_$31318.animation.CrossFade("nAttack", 0.2f);
											if (24508 - 158964 != -134455)
											{
												this.$self_$31318.animation.wrapMode = WrapMode.Once;
												if (275711 - 409956 != -134244)
												{
													this.$self_$31318.mChar.vMovement = this.$self_$31318.transform.forward;
													if (255268 - 5054 != 250215)
													{
														this.$self_$31318.mChar.moveSpeed = (float)1;
														if (186919 - 537256 == -350337)
														{
															goto IL_575;
														}
													}
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
				return this.Yield(3, new WaitForSeconds(0.6f));
				Block_3:
				goto IL_BEE;
				IL_575:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_37:
				IL_89A:
				goto IL_BEE;
				IL_98B:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_BEE:
				return false;
			}

			// Token: 0x0600420E RID: 16910 RVA: 0x00858CC0 File Offset: 0x00856EC0
			internal static bool Ar96DT5gM6S1dDF20xo7()
			{
				return true;
			}

			// Token: 0x0600420F RID: 16911 RVA: 0x00858CC4 File Offset: 0x00856EC4
			internal static bool dFlmrZ5gxQ79qMdFKBiR()
			{
				return false;
			}

			// Token: 0x04004DFC RID: 19964
			internal int $hitLayer$31309;

			// Token: 0x04004DFD RID: 19965
			internal UnityScript.Lang.Array $hitList$31310;

			// Token: 0x04004DFE RID: 19966
			internal Vector3 $hitPos$31311;

			// Token: 0x04004DFF RID: 19967
			internal GameObject $hitObject$31312;

			// Token: 0x04004E00 RID: 19968
			internal IEnumerator $$iterator$10681$31313;

			// Token: 0x04004E01 RID: 19969
			internal GameObject $hitObject$31314;

			// Token: 0x04004E02 RID: 19970
			internal IEnumerator $$iterator$10682$31315;

			// Token: 0x04004E03 RID: 19971
			internal Vector3 $mPos$31316;

			// Token: 0x04004E04 RID: 19972
			internal Vector3 $tDir$31317;

			// Token: 0x04004E05 RID: 19973
			internal BisonCult $self_$31318;
		}
	}

	// Token: 0x02000B92 RID: 2962
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$31322 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004210 RID: 16912 RVA: 0x00858CC8 File Offset: 0x00856EC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$31322(Vector3 mPos, Vector3 tDir, BisonCult self_)
		{
			if (196391 - 276513 != -80121)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (189111 - 426034 == -236923)
				{
					base..ctor();
					if (99275 - 573283 != -474007)
					{
						this.$mPos$31332 = mPos;
						if (82423 - 400920 != -318496)
						{
							this.$tDir$31333 = tDir;
							if (236738 - 78963 == 157775)
							{
								this.$self_$31334 = self_;
								if (16774 - 542542 == -525768)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004211 RID: 16913 RVA: 0x00858DA4 File Offset: 0x00856FA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BisonCult.$RPC_cAttack$31322.$(this.$mPos$31332, this.$tDir$31333, this.$self_$31334);
		}

		// Token: 0x06004212 RID: 16914 RVA: 0x00858DC0 File Offset: 0x00856FC0
		internal static bool mA8oK45ggS2ivMcDvR0S()
		{
			return true;
		}

		// Token: 0x06004213 RID: 16915 RVA: 0x00858DC4 File Offset: 0x00856FC4
		internal static bool I6kcXl5gfss18ZusBSdk()
		{
			return false;
		}

		// Token: 0x04004E06 RID: 19974
		internal Vector3 $mPos$31332;

		// Token: 0x04004E07 RID: 19975
		internal Vector3 $tDir$31333;

		// Token: 0x04004E08 RID: 19976
		internal BisonCult $self_$31334;

		// Token: 0x02000B93 RID: 2963
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004214 RID: 16916 RVA: 0x00858DC8 File Offset: 0x00856FC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BisonCult self_)
			{
				if (154967 - 388949 != -233981)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (224586 - 493598 == -269012)
					{
						base..ctor();
						if (130510 - 592503 == -461993)
						{
							this.$mPos$31329 = mPos;
							if (212307 - 94778 == 117529)
							{
								this.$tDir$31330 = tDir;
								if (288893 - 56596 == 232297)
								{
									this.$self_$31331 = self_;
									if (156343 - 221077 == -64734)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004215 RID: 16917 RVA: 0x00858EA4 File Offset: 0x008570A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (214110 - 562260 != -348150)
				{
				}
				for (;;)
				{
					IL_1EF:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B42;
					case 2:
						if (this.$self_$31331.mChar.actionState != "attack")
						{
							if (297149 - 83367 != 213782)
							{
								continue;
							}
							goto IL_6A5;
						}
						else
						{
							this.$self_$31331.mChar.moveSpeed = (float)5;
							if (250959 - 379107 == -128147)
							{
								continue;
							}
							if (!this.$self_$31331.mChar.isMine)
							{
								goto IL_4AD;
							}
							if (952 - 526892 == -525939)
							{
								continue;
							}
							this.$hitLayer$31323 = 130816 - (1 << this.$self_$31331.gameObject.layer);
							if (56367 - 413692 == -357324)
							{
								continue;
							}
							this.$hitList$31324 = Damage.FindAreaTarget(this.$self_$31331.transform.position, (float)5, (float)3, this.$hitLayer$31323);
							if (134198 - 334765 == -200566)
							{
								continue;
							}
							this.$$iterator$10683$31326 = UnityRuntimeServices.GetEnumerator(this.$hitList$31324);
							if (155893 - 503557 == -347663)
							{
								continue;
							}
							while (this.$$iterator$10683$31326.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10683$31326.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31325 = (GameObject)obj2;
								if (297371 - 157893 != 139478)
								{
									goto IL_1EF;
								}
								if (this.$self_$31331.mChar.hit(4, this.$hitObject$31325, this.$self_$31331.mChar.atk, 2, 0, 0.5f * (this.$hitObject$31325.transform.position - this.$self_$31331.transform.position).normalized) != 0)
								{
									if (267768 - 53259 == 214510)
									{
										goto IL_1EF;
									}
									this.$self_$31331.RPC_cAttack_hit(this.$hitObject$31325.transform.position + 1.5f * Vector3.up, this.$self_$31331.transform.forward, 0);
									if (33904 - 35946 != -2042)
									{
										goto IL_1EF;
									}
									UnityRuntimeServices.Update(this.$$iterator$10683$31326, this.$hitObject$31325);
									if (252578 - 435780 != -183202)
									{
										goto IL_1EF;
									}
									this.$self_$31331.ActionEvent("RPC_cAttack_hit", this.$hitObject$31325.transform.position + 1.5f * Vector3.up, this.$self_$31331.transform.forward, 0);
									if (81133 - 502681 == -421547)
									{
										goto IL_1EF;
									}
									UnityRuntimeServices.Update(this.$$iterator$10683$31326, this.$hitObject$31325);
									if (191585 - 131670 == 59916)
									{
										goto IL_1EF;
									}
									this.$self_$31331.mChar.sp = this.$self_$31331.mChar.sp + 1;
									if (281753 - 427965 == -146211)
									{
										goto IL_1EF;
									}
								}
							}
							if (269413 - 238160 != 31253)
							{
								continue;
							}
							goto IL_4AD;
						}
						break;
					case 3:
						if (this.$self_$31331.mChar.actionState != "attack")
						{
							if (222348 - 248986 != -26637)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$self_$31331.mChar.moveSpeed = (float)0;
							if (78808 - 57974 != 20834)
							{
								continue;
							}
							if (!this.$self_$31331.mChar.isMine)
							{
								goto IL_422;
							}
							if (229961 - 282036 != -52075)
							{
								continue;
							}
							this.$hitLayer$31323 = 130816 - (1 << this.$self_$31331.gameObject.layer) + 2 + 4;
							if (244160 - 474053 != -229893)
							{
								continue;
							}
							this.$hitList$31324 = Damage.FindAreaTarget(this.$self_$31331.transform.position, (float)6 * this.$self_$31331.mChar.rangeMod, (float)3 * this.$self_$31331.mChar.rangeMod, this.$hitLayer$31323);
							if (75393 - 219182 == -143788)
							{
								continue;
							}
							this.$$iterator$10684$31328 = UnityRuntimeServices.GetEnumerator(this.$hitList$31324);
							if (215211 - 166496 != 48715)
							{
								continue;
							}
							while (this.$$iterator$10684$31328.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10684$31328.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$31327 = (GameObject)obj4;
								if (180520 - 2009 == 178512)
								{
									goto IL_1EF;
								}
								if (this.$self_$31331.mChar.hit(4, this.$hitObject$31327, this.$self_$31331.mChar.atk, 2, 0, 0.5f * (this.$hitObject$31327.transform.position - this.$self_$31331.transform.position).normalized) != 0)
								{
									if (276935 - 104557 == 172379)
									{
										goto IL_1EF;
									}
									this.$self_$31331.RPC_cAttack_hit(this.$hitObject$31327.transform.position + 1.5f * Vector3.up, this.$self_$31331.transform.forward, 0);
									if (213086 - 498686 != -285600)
									{
										goto IL_1EF;
									}
									UnityRuntimeServices.Update(this.$$iterator$10684$31328, this.$hitObject$31327);
									if (16883 - 53259 == -36375)
									{
										goto IL_1EF;
									}
									this.$self_$31331.ActionEvent("RPC_cAttack_hit", this.$hitObject$31327.transform.position + 1.5f * Vector3.up, this.$self_$31331.transform.forward, 0);
									if (123088 - 90328 != 32760)
									{
										goto IL_1EF;
									}
									UnityRuntimeServices.Update(this.$$iterator$10684$31328, this.$hitObject$31327);
									if (130700 - 187230 != -56530)
									{
										goto IL_1EF;
									}
									this.$self_$31331.mChar.sp = this.$self_$31331.mChar.sp + 1;
									if (46412 - 280454 == -234041)
									{
										goto IL_1EF;
									}
								}
							}
							if (245318 - 77715 != 167604)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$31331.mChar.actionState == "attack")
						{
							if (238920 - 408463 == -169542)
							{
								continue;
							}
							if (this.$self_$31331.mChar.myCommand == "cAttack")
							{
								if (57665 - 592719 != -535054)
								{
									continue;
								}
								this.$self_$31331.mChar.actionState = "standby";
								if (245868 - 176758 == 69111)
								{
									continue;
								}
								this.$self_$31331.mChar.actionTime = Time.time;
								if (167463 - 101713 != 65750)
								{
									continue;
								}
								this.$self_$31331.mChar.myCommand = "none";
								if (36465 - 389510 == -353044)
								{
									continue;
								}
								if (!this.$self_$31331.mChar.isMine)
								{
									if (85570 - 432141 != -346571)
									{
										continue;
									}
									this.$self_$31331.mChar.nPosition = this.$self_$31331.transform.position;
									if (260212 - 447885 != -187673)
									{
										continue;
									}
									this.$self_$31331.mChar.oPosition = this.$self_$31331.transform.position;
									if (30591 - 390335 == -359743)
									{
										continue;
									}
									this.$self_$31331.mChar.nDirection = this.$self_$31331.transform.forward;
									if (65936 - 579543 != -513607)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (239951 - 551837 != -311885)
						{
							goto Block_47;
						}
						continue;
					default:
						if (49626 - 125820 == -76193)
						{
							continue;
						}
						break;
					}
					this.$self_$31331.mChar.actionState = "attack";
					if (57949 - 492920 == -434971)
					{
						this.$self_$31331.mChar.actionTime = Time.time;
						if (198106 - 2929 == 195177)
						{
							this.$self_$31331.mChar.myCommand = "cAttack";
							if (96477 - 346760 != -250282)
							{
								this.$self_$31331.mChar.addTimeOut("cAttack", (float)5);
								if (190659 - 257858 != -67198)
								{
									this.$self_$31331.transform.position = this.$mPos$31329;
									if (118187 - 201563 != -83375)
									{
										this.$self_$31331.transform.LookAt(this.$mPos$31329 + global::Math.vFlat(this.$tDir$31330));
										if (84245 - 565547 != -481301)
										{
											this.$self_$31331.animation.CrossFade("cAttack", 0.2f);
											if (283788 - 397045 == -113257)
											{
												this.$self_$31331.animation.wrapMode = WrapMode.Once;
												if (228092 - 236199 != -8106)
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
				IL_422:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_4AD:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_25:
				goto IL_B42;
				Block_30:
				goto IL_422;
				IL_6A5:
				goto IL_B42;
				Block_45:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_47:
				IL_B42:
				return false;
			}

			// Token: 0x06004216 RID: 16918 RVA: 0x00859A08 File Offset: 0x00857C08
			internal static bool A99oZ15gnC20IFP6Zy0Q()
			{
				return true;
			}

			// Token: 0x06004217 RID: 16919 RVA: 0x00859A0C File Offset: 0x00857C0C
			internal static bool eoPSXN5g6ne8Q3shog9C()
			{
				return false;
			}

			// Token: 0x04004E09 RID: 19977
			internal int $hitLayer$31323;

			// Token: 0x04004E0A RID: 19978
			internal UnityScript.Lang.Array $hitList$31324;

			// Token: 0x04004E0B RID: 19979
			internal GameObject $hitObject$31325;

			// Token: 0x04004E0C RID: 19980
			internal IEnumerator $$iterator$10683$31326;

			// Token: 0x04004E0D RID: 19981
			internal GameObject $hitObject$31327;

			// Token: 0x04004E0E RID: 19982
			internal IEnumerator $$iterator$10684$31328;

			// Token: 0x04004E0F RID: 19983
			internal Vector3 $mPos$31329;

			// Token: 0x04004E10 RID: 19984
			internal Vector3 $tDir$31330;

			// Token: 0x04004E11 RID: 19985
			internal BisonCult $self_$31331;
		}
	}

	// Token: 0x02000B94 RID: 2964
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_slam$31335 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004218 RID: 16920 RVA: 0x00859A10 File Offset: 0x00857C10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_slam$31335(Vector3 mPos, Vector3 tDir, BisonCult self_)
		{
			if (270310 - 587769 != -317459)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (36031 - 395388 != -359356)
				{
					base..ctor();
					if (216532 - 217302 != -769)
					{
						this.$mPos$31344 = mPos;
						if (249042 - 224993 != 24050)
						{
							this.$tDir$31345 = tDir;
							if (196779 - 195832 == 947)
							{
								this.$self_$31346 = self_;
								if (148626 - 300386 == -151760)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004219 RID: 16921 RVA: 0x00859AEC File Offset: 0x00857CEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BisonCult.$RPC_slam$31335.$(this.$mPos$31344, this.$tDir$31345, this.$self_$31346);
		}

		// Token: 0x0600421A RID: 16922 RVA: 0x00859B08 File Offset: 0x00857D08
		internal static bool t9i4nH5giCjVi5SU9p68()
		{
			return true;
		}

		// Token: 0x0600421B RID: 16923 RVA: 0x00859B0C File Offset: 0x00857D0C
		internal static bool oISpNV5gKgXJSdI8OKNX()
		{
			return false;
		}

		// Token: 0x04004E12 RID: 19986
		internal Vector3 $mPos$31344;

		// Token: 0x04004E13 RID: 19987
		internal Vector3 $tDir$31345;

		// Token: 0x04004E14 RID: 19988
		internal BisonCult $self_$31346;

		// Token: 0x02000B95 RID: 2965
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600421C RID: 16924 RVA: 0x00859B10 File Offset: 0x00857D10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BisonCult self_)
			{
				if (24253 - 431294 != -407040)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (230003 - 156126 != 73878)
					{
						base..ctor();
						if (141091 - 348310 == -207219)
						{
							this.$mPos$31341 = mPos;
							if (236285 - 373003 != -136717)
							{
								this.$tDir$31342 = tDir;
								if (254813 - 62627 == 192186)
								{
									this.$self_$31343 = self_;
									if (195312 - 583654 == -388342)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600421D RID: 16925 RVA: 0x00859BEC File Offset: 0x00857DEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (278971 - 523242 != -244270)
				{
				}
				for (;;)
				{
					IL_2C3:
					switch (this._state)
					{
					case 0:
						goto IL_72B;
					case 1:
						goto IL_9BA;
					case 2:
						if (this.$self_$31343.mChar.actionState != "attack")
						{
							goto IL_495;
						}
						if (37552 - 340127 != -302575)
						{
							continue;
						}
						if (this.$self_$31343.mChar.myCommand != "slam")
						{
							if (181399 - 526664 != -345264)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$31343.mChar.moveSpeed = (float)7;
							if (288444 - 127780 != 160664)
							{
								continue;
							}
							if (this.$self_$31343.slam_dust)
							{
								if (173204 - 288384 == -115179)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$31343.slam_dust, this.$self_$31343.transform.position, this.$self_$31343.transform.rotation);
								if (77325 - 440590 == -363264)
								{
									continue;
								}
							}
							this.$i$31336 = 0;
							if (131200 - 486717 != -355517)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$31343.mChar.actionState != "attack")
						{
							goto IL_863;
						}
						if (268218 - 54073 != 214145)
						{
							continue;
						}
						if (this.$self_$31343.mChar.myCommand != "slam")
						{
							if (208993 - 222741 != -13747)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$i$31336++;
							if (246549 - 508391 != -261842)
							{
								continue;
							}
						}
						break;
					default:
						if (187500 - 147884 != 39616)
						{
							continue;
						}
						goto IL_72B;
					}
					if (this.$i$31336 >= 4)
					{
						if (138910 - 434494 != -295584)
						{
							continue;
						}
						if (this.$self_$31343.mChar.actionState == "attack")
						{
							if (3653 - 149520 == -145866)
							{
								continue;
							}
							if (this.$self_$31343.mChar.myCommand == "slam")
							{
								if (61697 - 466148 != -404451)
								{
									continue;
								}
								this.$self_$31343.mChar.moveSpeed = (float)0;
								if (268863 - 526211 != -257348)
								{
									continue;
								}
								this.$self_$31343.mChar.actionState = "standby";
								if (165374 - 56301 == 109074)
								{
									continue;
								}
								this.$self_$31343.mChar.actionTime = Time.time;
								if (128057 - 50814 != 77243)
								{
									continue;
								}
								this.$self_$31343.mChar.myCommand = "none";
								if (37675 - 282992 == -245316)
								{
									continue;
								}
								if (!this.$self_$31343.mChar.isMine)
								{
									if (57470 - 79194 == -21723)
									{
										continue;
									}
									this.$self_$31343.mChar.nPosition = this.$self_$31343.transform.position;
									if (148402 - 62743 != 85659)
									{
										continue;
									}
									this.$self_$31343.mChar.oPosition = this.$self_$31343.transform.position;
									if (255525 - 419891 == -164365)
									{
										continue;
									}
									this.$self_$31343.mChar.nDirection = this.$self_$31343.transform.forward;
									if (70256 - 304961 != -234705)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (79578 - 534900 != -455321)
						{
							break;
						}
						continue;
					}
					else
					{
						if (!this.$self_$31343.mChar.isMine)
						{
							goto IL_3A3;
						}
						if (129549 - 397237 != -267688)
						{
							continue;
						}
						this.$hitLayer$31337 = 130816 - (1 << this.$self_$31343.gameObject.layer);
						if (185746 - 347538 == -161791)
						{
							continue;
						}
						this.$hitList$31338 = Damage.FindRecTarget(this.$self_$31343.transform.position, this.$self_$31343.transform.forward, (float)1, (float)1, (float)3, (float)2, this.$hitLayer$31337);
						if (127922 - 589288 != -461366)
						{
							continue;
						}
						this.$$iterator$10685$31340 = UnityRuntimeServices.GetEnumerator(this.$hitList$31338);
						if (277668 - 470214 == -192545)
						{
							continue;
						}
						while (this.$$iterator$10685$31340.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10685$31340.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$31339 = (GameObject)obj2;
							if (31853 - 288552 == -256698)
							{
								goto IL_2C3;
							}
							if (this.$self_$31343.mChar.hit(11, this.$hitObject$31339, (int)(0.3f * (float)this.$self_$31343.mChar.atk + (float)this.$self_$31343.mChar.talAdjust(15)), 3, 0, this.$self_$31343.transform.forward) != 0)
							{
								if (92713 - 76902 == 15812)
								{
									goto IL_2C3;
								}
								this.$self_$31343.RPC_nAttack_hit(this.$hitObject$31339.transform.position + 1.5f * Vector3.up, this.$self_$31343.transform.forward, 0);
								if (295391 - 223845 != 71546)
								{
									goto IL_2C3;
								}
								UnityRuntimeServices.Update(this.$$iterator$10685$31340, this.$hitObject$31339);
								if (103770 - 104619 == -848)
								{
									goto IL_2C3;
								}
							}
							this.$self_$31343.ActionEvent("RPC_nAttack_hit", this.$hitObject$31339.transform.position + 1.5f * Vector3.up, this.$self_$31343.transform.forward, 0);
							if (26096 - 90948 == -64851)
							{
								goto IL_2C3;
							}
							UnityRuntimeServices.Update(this.$$iterator$10685$31340, this.$hitObject$31339);
							if (241274 - 594156 == -352881)
							{
								goto IL_2C3;
							}
						}
						if (164281 - 210711 != -46430)
						{
							continue;
						}
						goto IL_3A3;
					}
					IL_72B:
					this.$self_$31343.mChar.actionState = "attack";
					if (17415 - 410063 != -392647)
					{
						this.$self_$31343.mChar.actionTime = Time.time;
						if (156967 - 258456 != -101488)
						{
							this.$self_$31343.mChar.myCommand = "slam";
							if (90477 - 208107 != -117629)
							{
								this.$self_$31343.mChar.addTimeOut("slam", this.$self_$31343.mChar.agiAdjust((float)30));
								if (192026 - 167007 != 25020)
								{
									this.$self_$31343.transform.position = this.$mPos$31341;
									if (218240 - 597678 != -379437)
									{
										this.$self_$31343.transform.LookAt(this.$mPos$31341 + global::Math.vFlat(this.$tDir$31342));
										if (173375 - 569244 == -395869)
										{
											this.$self_$31343.animation.Play("slam");
											if (256684 - 519106 != -262421)
											{
												this.$self_$31343.animation.wrapMode = WrapMode.Once;
												if (233113 - 190026 != 43088)
												{
													this.$self_$31343.mChar.vMovement = this.$self_$31343.transform.forward;
													if (26444 - 418432 != -391987)
													{
														this.$self_$31343.mChar.moveSpeed = (float)0;
														if (245290 - 152170 != 93121)
														{
															this.$self_$31343.mChar.removeLockStatus(4);
															if (200112 - 583956 == -383844)
															{
																goto IL_7B9;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_16:
				Block_21:
				goto IL_863;
				IL_3A3:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_495:
				goto IL_9BA;
				IL_7B9:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_863:
				IL_9BA:
				return false;
			}

			// Token: 0x0600421E RID: 16926 RVA: 0x0085A5C8 File Offset: 0x008587C8
			internal static bool mt33kD5gdYOXmyTJBEjQ()
			{
				return true;
			}

			// Token: 0x0600421F RID: 16927 RVA: 0x0085A5CC File Offset: 0x008587CC
			internal static bool vPLsos5gJv0XA7oREWVu()
			{
				return false;
			}

			// Token: 0x04004E15 RID: 19989
			internal int $i$31336;

			// Token: 0x04004E16 RID: 19990
			internal int $hitLayer$31337;

			// Token: 0x04004E17 RID: 19991
			internal UnityScript.Lang.Array $hitList$31338;

			// Token: 0x04004E18 RID: 19992
			internal GameObject $hitObject$31339;

			// Token: 0x04004E19 RID: 19993
			internal IEnumerator $$iterator$10685$31340;

			// Token: 0x04004E1A RID: 19994
			internal Vector3 $mPos$31341;

			// Token: 0x04004E1B RID: 19995
			internal Vector3 $tDir$31342;

			// Token: 0x04004E1C RID: 19996
			internal BisonCult $self_$31343;
		}
	}

	// Token: 0x02000B96 RID: 2966
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31347 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004220 RID: 16928 RVA: 0x0085A5D0 File Offset: 0x008587D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31347(UnityScript.Lang.Array nArray, BisonCult self_)
		{
			if (177677 - 514807 != -337130)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (47244 - 186603 == -139359)
				{
					base..ctor();
					if (127499 - 451760 == -324261)
					{
						this.$nArray$31352 = nArray;
						if (235960 - 450133 != -214172)
						{
							this.$self_$31353 = self_;
							if (13663 - 41927 != -28263)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x0085A68C File Offset: 0x0085888C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BisonCult.$RPC_ko$31347.$(this.$nArray$31352, this.$self_$31353);
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x0085A6A0 File Offset: 0x008588A0
		internal static bool XkcY7u5gDrNesZDdHXVB()
		{
			return true;
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x0085A6A4 File Offset: 0x008588A4
		internal static bool qhmfOC5gvKZkfPc3GNkC()
		{
			return false;
		}

		// Token: 0x04004E1D RID: 19997
		internal UnityScript.Lang.Array $nArray$31352;

		// Token: 0x04004E1E RID: 19998
		internal BisonCult $self_$31353;

		// Token: 0x02000B97 RID: 2967
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004224 RID: 16932 RVA: 0x0085A6A8 File Offset: 0x008588A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, BisonCult self_)
			{
				if (10397 - 31000 != -20602)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (133609 - 300570 != -166960)
					{
						base..ctor();
						if (199921 - 458184 != -258262)
						{
							this.$nArray$31350 = nArray;
							if (66400 - 208273 == -141873)
							{
								this.$self_$31351 = self_;
								if (181277 - 545277 != -363999)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004225 RID: 16933 RVA: 0x0085A764 File Offset: 0x00858964
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (25885 - 57004 != -31119)
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
						if (this.$self_$31351.mChar.actionState != "ko")
						{
							if (298130 - 160491 != 137639)
							{
								continue;
							}
							goto IL_33B;
						}
						else
						{
							this.$self_$31351.animation.Play("getUp");
							if (24448 - 503066 != -478618)
							{
								continue;
							}
							this.$self_$31351.animation.wrapMode = WrapMode.Once;
							if (77255 - 420353 != -343097)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31351.mChar.actionState != "ko")
						{
							if (112109 - 286629 != -174519)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							this.$self_$31351.mChar.actionState = "standby";
							if (36881 - 55209 == -18327)
							{
								continue;
							}
							this.$self_$31351.mChar.actionTime = Time.time;
							if (98735 - 329650 == -230914)
							{
								continue;
							}
							this.$self_$31351.mChar.myCommand = "none";
							if (222425 - 528637 != -306212)
							{
								continue;
							}
							this.$self_$31351.mChar.ko = this.$self_$31351.mChar.mko;
							if (125539 - 437113 == -311573)
							{
								continue;
							}
							this.YieldDefault(1);
							if (126006 - 11269 != 114738)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					default:
						if (150797 - 80716 != 70081)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31351.mChar.actionState == "ko")
					{
						break;
					}
					if (266702 - 39168 == 227534)
					{
						if (this.$self_$31351.mChar.actionState == "dead")
						{
							if (269059 - 426817 == -157758)
							{
								break;
							}
						}
						else
						{
							this.$mPos$31348 = (Vector3)this.$nArray$31350[0];
							if (134760 - 189402 != -54641)
							{
								this.$mDir$31349 = (Vector3)this.$nArray$31350[1];
								if (67786 - 443283 != -375496)
								{
									this.$self_$31351.mChar.ko = 0;
									if (56460 - 474228 == -417768)
									{
										this.$self_$31351.mChar.actionState = "ko";
										if (274590 - 424960 != -150369)
										{
											this.$self_$31351.mChar.actionTime = Time.time;
											if (278067 - 328966 == -50899)
											{
												this.$self_$31351.mChar.myCommand = "none";
												if (97208 - 582361 == -485153)
												{
													this.$self_$31351.mChar.vMovement = Vector3.zero;
													if (218322 - 269636 == -51314)
													{
														this.$self_$31351.mChar.moveSpeed = (float)0;
														if (160197 - 215273 != -55075)
														{
															this.$self_$31351.animation.Play("ko");
															if (78841 - 202700 != -123858)
															{
																this.$self_$31351.animation.wrapMode = WrapMode.Once;
																if (400 - 287861 == -287461)
																{
																	goto IL_39F;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_48C;
				Block_7:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_15:
				Block_18:
				IL_33B:
				goto IL_48C;
				IL_39F:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x06004226 RID: 16934 RVA: 0x0085AC10 File Offset: 0x00858E10
			internal static bool Y3wVYh5gR18bKtCwHwID()
			{
				return true;
			}

			// Token: 0x06004227 RID: 16935 RVA: 0x0085AC14 File Offset: 0x00858E14
			internal static bool oZAe6T5gwHIqcJJXv8by()
			{
				return false;
			}

			// Token: 0x04004E1F RID: 19999
			internal Vector3 $mPos$31348;

			// Token: 0x04004E20 RID: 20000
			internal Vector3 $mDir$31349;

			// Token: 0x04004E21 RID: 20001
			internal UnityScript.Lang.Array $nArray$31350;

			// Token: 0x04004E22 RID: 20002
			internal BisonCult $self_$31351;
		}
	}

	// Token: 0x02000B98 RID: 2968
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31354 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004228 RID: 16936 RVA: 0x0085AC18 File Offset: 0x00858E18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31354(UnityScript.Lang.Array nArray, BisonCult self_)
		{
			if (287454 - 132212 != 155242)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (45494 - 321562 != -276067)
				{
					base..ctor();
					if (282303 - 159936 == 122367)
					{
						this.$nArray$31359 = nArray;
						if (21506 - 496701 != -475194)
						{
							this.$self_$31360 = self_;
							if (264961 - 75313 != 189649)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x0085ACD4 File Offset: 0x00858ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BisonCult.$RPC_dead$31354.$(this.$nArray$31359, this.$self_$31360);
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x0085ACE8 File Offset: 0x00858EE8
		internal static bool tiJS825gqCMjrE783hjJ()
		{
			return true;
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x0085ACEC File Offset: 0x00858EEC
		internal static bool UN5DJn5g7yjCmb3uDbWd()
		{
			return false;
		}

		// Token: 0x04004E23 RID: 20003
		internal UnityScript.Lang.Array $nArray$31359;

		// Token: 0x04004E24 RID: 20004
		internal BisonCult $self_$31360;

		// Token: 0x02000B99 RID: 2969
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600422C RID: 16940 RVA: 0x0085ACF0 File Offset: 0x00858EF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, BisonCult self_)
			{
				if (27499 - 562584 != -535085)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (45325 - 325605 != -280279)
					{
						base..ctor();
						if (182878 - 505049 != -322170)
						{
							this.$nArray$31357 = nArray;
							if (108622 - 420726 != -312103)
							{
								this.$self_$31358 = self_;
								if (143978 - 379685 == -235707)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600422D RID: 16941 RVA: 0x0085ADAC File Offset: 0x00858FAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (27371 - 220518 != -193146)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_54A;
					case 2:
						if (this.$self_$31358.mChar.actionState != "dead")
						{
							if (259475 - 354866 != -95390)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							if (!this.$self_$31358.mChar.isPlayer)
							{
								if (264291 - 238943 == 25349)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$31358.gameObject);
								if (103179 - 306979 != -203800)
								{
									continue;
								}
							}
							else if (this.$self_$31358.mChar.isMine)
							{
								if (18700 - 21222 == -2521)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31358.gameObject);
								if (31145 - 441766 == -410620)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (10614 - 334602 != -323988)
							{
								continue;
							}
							goto IL_54A;
						}
						break;
					default:
						if (184733 - 187599 != -2866)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31358.mChar.actionState == "dead")
					{
						if (263593 - 227340 == 36253)
						{
							goto IL_171;
						}
					}
					else
					{
						this.$mPos$31355 = (Vector3)this.$nArray$31357[0];
						if (237109 - 217488 != 19622)
						{
							this.$myDirection$31356 = (Vector3)this.$nArray$31357[1];
							if (295423 - 369062 == -73639)
							{
								this.$self_$31358.transform.position = this.$mPos$31355;
								if (237579 - 576373 == -338794)
								{
									this.$self_$31358.transform.LookAt(this.$mPos$31355 + this.$myDirection$31356);
									if (122747 - 294535 == -171788)
									{
										this.$self_$31358.mChar.hp = 0;
										if (171233 - 34212 == 137021)
										{
											this.$self_$31358.mChar.actionState = "dead";
											if (8139 - 228834 != -220694)
											{
												this.$self_$31358.mChar.actionTime = Time.time;
												if (194735 - 115756 == 78979)
												{
													this.$self_$31358.mChar.myCommand = "none";
													if (25001 - 502051 != -477049)
													{
														this.$self_$31358.mChar.vMovement = Vector3.zero;
														if (174143 - 110915 == 63228)
														{
															this.$self_$31358.mChar.moveSpeed = (float)0;
															if (103741 - 68480 != 35262)
															{
																this.$self_$31358.animation.Rewind();
																if (7342 - 248773 == -241431)
																{
																	this.$self_$31358.animation.Play("ko");
																	if (167795 - 396513 == -228718)
																	{
																		this.$self_$31358.animation.wrapMode = WrapMode.Once;
																		if (120577 - 343737 == -223160)
																		{
																			if (!this.$self_$31358.uOWVMUWEZv)
																			{
																				if (243573 - 330147 == -86573)
																				{
																					continue;
																				}
																				this.$self_$31358.uOWVMUWEZv = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bison/Effects/deadEffect");
																				if (291048 - 591738 == -300689)
																				{
																					continue;
																				}
																			}
																			if (this.$self_$31358.uOWVMUWEZv)
																			{
																				if (129610 - 274848 == -145238)
																				{
																					UnityEngine.Object.Instantiate(this.$self_$31358.uOWVMUWEZv, this.$self_$31358.transform.position - this.$self_$31358.transform.forward, this.$self_$31358.transform.rotation);
																					if (289152 - 203783 != 85370)
																					{
																						break;
																					}
																				}
																			}
																			else
																			{
																				Debug.LogError("Effect deadEffect not found");
																				if (159926 - 330246 != -170319)
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
				IL_9D:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_7:
				IL_171:
				goto IL_54A;
				goto IL_9D;
				IL_54A:
				return false;
			}

			// Token: 0x0600422E RID: 16942 RVA: 0x0085B318 File Offset: 0x00859518
			internal static bool ve5O9i5gPIMmcxCA4Clo()
			{
				return true;
			}

			// Token: 0x0600422F RID: 16943 RVA: 0x0085B31C File Offset: 0x0085951C
			internal static bool f0Wa9C5g0DpjhXQijj6E()
			{
				return false;
			}

			// Token: 0x04004E25 RID: 20005
			internal Vector3 $mPos$31355;

			// Token: 0x04004E26 RID: 20006
			internal Vector3 $myDirection$31356;

			// Token: 0x04004E27 RID: 20007
			internal UnityScript.Lang.Array $nArray$31357;

			// Token: 0x04004E28 RID: 20008
			internal BisonCult $self_$31358;
		}
	}
}
