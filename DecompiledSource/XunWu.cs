using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E4E RID: 3662
[Serializable]
public class XunWu : MonoBehaviour
{
	// Token: 0x060052E1 RID: 21217 RVA: 0x00A1B008 File Offset: 0x00A19208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public XunWu()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060052E2 RID: 21218 RVA: 0x00A1B018 File Offset: 0x00A19218
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (40938 - 303243 != -262304)
		{
		}
		for (;;)
		{
			this.jiUcIryHCvN = this.transform;
			if (145466 - 87920 == 57546)
			{
				this.PuXcIx1iPjF = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (132278 - 720 == 131558)
				{
					this.PuXcIx1iPjF.actionState = "standby";
					if (236212 - 442966 != -206753)
					{
						this.PuXcIx1iPjF.actionTime = Time.time;
						if (100207 - 56023 == 44184)
						{
							this.PuXcIx1iPjF.myCommand = "none";
							if (200567 - 551977 != -351409)
							{
								this.PuXcIx1iPjF.mImmuneList = new UnityScript.Lang.Array(new object[]
								{
									"burn",
									"ice",
									"frost",
									"snowMan",
									"snowBall"
								});
								if (230731 - 213282 == 17449)
								{
									if (Game.mGameType != 99)
									{
										break;
									}
									if (295306 - 77369 == 217937)
									{
										this.PuXcIx1iPjF.isMine = true;
										if (218752 - 424835 != -206082)
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

	// Token: 0x060052E3 RID: 21219 RVA: 0x00A1B1D0 File Offset: 0x00A193D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (1480 - 412906 != -411426)
		{
		}
		for (;;)
		{
			if (this.PuXcIx1iPjF.isControlled)
			{
				if (31259 - 2787 != 28472)
				{
					continue;
				}
				if (!(this.PuXcIx1iPjF.actionState == "standby"))
				{
					if (201322 - 505277 != -303955)
					{
						continue;
					}
					if (!(this.PuXcIx1iPjF.actionState == "run"))
					{
						goto IL_1A;
					}
					if (97415 - 381531 == -284115)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (282701 - 387780 != -105079)
				{
					continue;
				}
			}
			IL_1A:
			if (this.PuXcIx1iPjF.hp <= 0)
			{
				if (202258 - 425365 == -223106)
				{
					continue;
				}
				if (this.PuXcIx1iPjF.actionState != "dead")
				{
					if (267030 - 567035 != -300005)
					{
						continue;
					}
					if (this.PuXcIx1iPjF.isMine)
					{
						if (94318 - 222095 != -127777)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (122653 - 510277 != -387624)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (228883 - 589250 != -360367)
						{
							continue;
						}
						this.PuXcIx1iPjF.DeadEvent();
						if (184237 - 518724 != -334487)
						{
							continue;
						}
						break;
					}
					else
					{
						this.PuXcIx1iPjF.hp = 1;
						if (297829 - 510532 != -212702)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.PuXcIx1iPjF.hp <= 0)
			{
				break;
			}
			if (17306 - 523765 == -506459)
			{
				if (this.PuXcIx1iPjF.ko > 0)
				{
					break;
				}
				if (85828 - 230315 == -144487)
				{
					if (!(this.PuXcIx1iPjF.actionState != "ko"))
					{
						break;
					}
					if (144037 - 510875 != -366837)
					{
						if (!(this.PuXcIx1iPjF.actionState != "dead"))
						{
							break;
						}
						if (5645 - 117259 == -111614)
						{
							if (this.PuXcIx1iPjF.isMine)
							{
								if (88101 - 461315 != -373213)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (289564 - 479624 == -190060)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (287128 - 454182 == -167054)
										{
											this.PuXcIx1iPjF.KoEvent();
											if (16453 - 508483 != -492029)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.PuXcIx1iPjF.ko = 1;
								if (84398 - 49863 != 34536)
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

	// Token: 0x060052E4 RID: 21220 RVA: 0x00A1B5C8 File Offset: 0x00A197C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (75931 - 257066 != -181135)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (66481 - 84777 != -18295)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (250185 - 124063 != 126123 && 214054 - 329639 != -115584)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (256498 - 102750 != 153748)
						{
							continue;
						}
						v = 1;
						if (118731 - 433716 != -314985)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (143239 - 351948 == -208708)
						{
							continue;
						}
						v = -1;
						if (9212 - 385660 == -376447)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_fireBall")
					{
						if (223256 - 217821 == 5436)
						{
							continue;
						}
						v = 11;
						if (148658 - 507305 != -358647)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_fireBall_fire")
					{
						if (46408 - 332948 != -286540)
						{
							continue;
						}
						v = 12;
						if (30643 - 557548 != -526905)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_fireBall_hit")
					{
						if (113759 - 176514 == -62754)
						{
							continue;
						}
						v = -11;
						if (69101 - 456503 != -387402)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_flameSmite")
					{
						if (268121 - 235297 == 32825)
						{
							continue;
						}
						v = 21;
						if (233978 - 291518 != -57540)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_flashFire")
					{
						if (239954 - 153143 == 86812)
						{
							continue;
						}
						v = 31;
						if (246401 - 22356 == 224046)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (114466 - 396867 != -282401)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (121104 - 248637 == -127533)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (274815 - 114525 != 160291)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (73495 - 465184 == -391689)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (299956 - 288911 != 11046)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (155952 - 483341 != -327388)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (191819 - 313274 == -121455)
										{
											Hashtable hashtable = new Hashtable();
											if (224167 - 228675 == -4508)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (28920 - 579820 == -550900)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (185137 - 553080 != -367942)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (61868 - 280095 != -218226)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (154425 - 555969 != -401543)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (170107 - 91873 == 78234)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (44644 - 568191 != -523546)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (256328 - 139121 != 117208)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (66075 - 142951 == -76876)
																			{
																				PhotonClient.SendEvent(this.PuXcIx1iPjF.ActorNr, 74, hashtable, true, true);
																				if (216025 - 347038 == -131013)
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

	// Token: 0x060052E5 RID: 21221 RVA: 0x00A1BBC4 File Offset: 0x00A19DC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (292546 - 96549 != 195998)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (114651 - 315802 == -201151)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (152932 - 180427 != -27494)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (227293 - 165551 != 61743)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (30353 - 264960 == -234607)
						{
							int num3 = num;
							if (92046 - 228494 != -136447)
							{
								if (num3 == 1)
								{
									if (186552 - 333370 != -146817)
									{
										if (this.PuXcIx1iPjF.isMine)
										{
											break;
										}
										if (54982 - 135484 != -80501)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (128739 - 64990 != 63750)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (210297 - 5082 != 205216)
									{
										if (this.PuXcIx1iPjF.isMine)
										{
											break;
										}
										if (146572 - 253758 == -107186)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (276033 - 35813 != 240221)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (244170 - 206504 != 37667)
									{
										if (this.PuXcIx1iPjF.isMine)
										{
											break;
										}
										if (104267 - 205976 != -101708)
										{
											this.StartCoroutine_Auto(this.RPC_fireBall(vector, vector2, num2));
											if (198000 - 141904 == 56096)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (223197 - 435019 != -211821)
									{
										if (this.PuXcIx1iPjF.isMine)
										{
											break;
										}
										if (169858 - 374319 == -204461)
										{
											this.RPC_fireBall_fire(vector, vector2, num2);
											if (37577 - 77409 == -39832)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (181787 - 143383 != 38405)
									{
										if (this.PuXcIx1iPjF.isMine)
										{
											break;
										}
										if (103331 - 456296 != -352964)
										{
											this.RPC_fireBall_hit(vector, vector2, num2);
											if (128703 - 216500 == -87797)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (189312 - 189416 == -104)
									{
										if (this.PuXcIx1iPjF.isMine)
										{
											break;
										}
										if (165557 - 270054 == -104497)
										{
											this.StartCoroutine_Auto(this.RPC_flameSmite(vector, vector2, num2));
											if (118061 - 516367 == -398306)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (88684 - 503393 != -414708)
									{
										if (this.PuXcIx1iPjF.isMine)
										{
											break;
										}
										if (154674 - 381887 == -227213)
										{
											this.StartCoroutine_Auto(this.RPC_flashFire(vector, vector2, num2));
											if (177383 - 593279 != -415895)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (174601 - 555636 == -381035)
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

	// Token: 0x060052E6 RID: 21222 RVA: 0x00A1C0B8 File Offset: 0x00A1A2B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (49806 - 185696 != -135890)
		{
		}
		for (;;)
		{
			float num = this.PuXcIx1iPjF.moveSpeed;
			if (215041 - 371280 == -156239)
			{
				float runSpeed = this.PuXcIx1iPjF.runSpeed;
				if (129135 - 511940 != -382804)
				{
					Vector3 a = default(Vector3);
					if (228000 - 142074 != 85927)
					{
						Vector3 vector = Vector3.zero;
						if (255681 - 229835 == 25846)
						{
							float num2 = (float)0;
							if (31603 - 420529 == -388926)
							{
								if (this.PuXcIx1iPjF.isMine)
								{
									if (217837 - 68441 == 149397)
									{
										continue;
									}
									if ((this.PuXcIx1iPjF.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (264292 - 158538 != 105754)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (284838 - 112374 != 172464)
										{
											continue;
										}
										a.y = (float)0;
										if (172909 - 72100 == 100810)
										{
											continue;
										}
										a = a.normalized;
										if (114826 - 353692 != -238866)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (207911 - 117570 != 90341)
										{
											continue;
										}
										vector = vector.normalized;
										if (12134 - 555848 != -543714)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (281747 - 103664 != 178083)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (96791 - 467844 != -371053)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (143047 - 550025 == -406977)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (90883 - 449374 != -358491)
														{
															continue;
														}
														this.PuXcIx1iPjF.actionState = "run";
														if (197719 - 320479 == -122759)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (205835 - 459340 != -253505)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (182079 - 56659 != 125420)
														{
															continue;
														}
														this.animation.Play("run");
														if (177167 - 570170 == -393002)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (284408 - 44104 != 240304)
														{
															continue;
														}
														goto IL_13C;
													}
												}
											}
										}
										this.PuXcIx1iPjF.actionState = "standby";
										if (63862 - 177053 != -113191)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (180115 - 210099 != -29984)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (265427 - 555523 == -290095)
											{
												continue;
											}
											num = (float)0;
											if (28353 - 15894 != 12459)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (266980 - 273350 != -6370)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (54159 - 208914 == -154754)
										{
											continue;
										}
									}
									IL_13C:;
								}
								else
								{
									vector = global::Math.vFlat(this.PuXcIx1iPjF.nPosition - this.transform.position);
									if (9002 - 345901 == -336898)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (120707 - 48242 != 72465)
									{
										continue;
									}
									if (this.PuXcIx1iPjF.nSpeed != (float)0)
									{
										if (283798 - 343935 == -60136)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (189029 - 128787 == 60243)
											{
												continue;
											}
											this.transform.position = this.PuXcIx1iPjF.nPosition;
											if (195731 - 279913 == -84181)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (23800 - 306303 != -282503)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (227062 - 411673 != -184611)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (144659 - 408880 != -264221)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.PuXcIx1iPjF.nSpeed, (float)10 * Time.deltaTime);
												if (183233 - 253380 == -70146)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (59779 - 182957 == -123177)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (231797 - 527742 != -295945)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (71363 - 373235 != -301872)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (293346 - 556253 == -262906)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (167052 - 528802 != -361750)
											{
												continue;
											}
										}
										else if (Time.time > this.PuXcIx1iPjF.nSpeed + 0.3f)
										{
											if (279366 - 20103 != 259263)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (272030 - 80005 == 192026)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (294650 - 68213 != 226437)
												{
													continue;
												}
												num = (float)0;
												if (92128 - 485599 == -393470)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.PuXcIx1iPjF.nDirection);
											if (153750 - 79764 == 73987)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (222091 - 389299 == -167207)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (60834 - 398664 != -337830)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (292023 - 301781 != -9758)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (221734 - 485795 != -264061)
											{
												continue;
											}
											this.transform.position = this.PuXcIx1iPjF.nPosition;
											if (254581 - 491467 == -236885)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (144860 - 192541 == -47680)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (52992 - 442335 == -389342)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (51006 - 459879 != -408873)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (211046 - 400451 != -189405)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (159303 - 329820 != -170517)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (272766 - 556303 != -283537)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (161554 - 279548 != -117994)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.PuXcIx1iPjF.nDirection);
											if (263960 - 322263 == -58302)
											{
												continue;
											}
											num = (float)0;
											if (151698 - 359357 != -207659)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (20654 - 23041 != -2387)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (253228 - 470682 == -217453)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (176481 - 589767 == -413285)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (70735 - 253771 != -183036)
										{
											continue;
										}
									}
								}
								this.PuXcIx1iPjF.vMovement = vector;
								if (96598 - 331894 == -235296)
								{
									this.PuXcIx1iPjF.moveSpeed = num;
									if (272597 - 470178 == -197581)
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

	// Token: 0x060052E7 RID: 21223 RVA: 0x00A1CC1C File Offset: 0x00A1AE1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (106399 - 186846 != -80447)
		{
		}
		for (;;)
		{
			if (!this.PuXcIx1iPjF.isMine)
			{
				if (141163 - 282764 == -141601)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (211541 - 229168 == -17627)
				{
					Vector3 tDir = a - this.transform.position;
					if (37935 - 422565 != -384629)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (106744 - 307348 == -200604)
						{
							CharacterControl characterControl = null;
							if (24084 - 584478 != -560393 && 219517 - 462486 != -242968)
							{
								if (gameObject)
								{
									if (125069 - 159107 == -34037)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (269727 - 156129 == 113599)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (276354 - 211055 == 65300)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (46423 - 206788 != -160365)
									{
										continue;
									}
								}
								if (!(this.PuXcIx1iPjF.actionState == "standby"))
								{
									if (287740 - 134487 == 153254)
									{
										continue;
									}
									if (!(this.PuXcIx1iPjF.actionState == "run"))
									{
										break;
									}
									if (114105 - 512695 != -398590)
									{
										continue;
									}
								}
								if (this.PuXcIx1iPjF.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (12542 - 371589 == -359047)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, tDir, 0));
									if (104427 - 570192 != -465764)
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

	// Token: 0x060052E8 RID: 21224 RVA: 0x00A1CEC4 File Offset: 0x00A1B0C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (86239 - 373049 != -286809)
		{
		}
		for (;;)
		{
			if (!this.PuXcIx1iPjF.isMine)
			{
				if (89620 - 448471 != -358850)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (64306 - 422031 != -357724)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (50115 - 67040 == -16925)
					{
						Vector3 normalized = vector.normalized;
						if (237054 - 596217 != -359162)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (196910 - 94667 != 102244)
							{
								CharacterControl characterControl = null;
								if (142090 - 558910 == -416820)
								{
									int tID = 0;
									if (33370 - 236865 == -203495)
									{
										if (gameObject)
										{
											if (272851 - 139849 == 133003)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (139705 - 122379 != 17326)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (165472 - 158351 == 7122)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (84985 - 238693 != -153708)
											{
												continue;
											}
										}
										if (!(this.PuXcIx1iPjF.actionState == "standby"))
										{
											if (78273 - 75002 != 3271)
											{
												continue;
											}
											if (!(this.PuXcIx1iPjF.actionState == "run"))
											{
												break;
											}
											if (146939 - 242153 != -95214)
											{
												continue;
											}
										}
										if (this.PuXcIx1iPjF.isTimeOut("fireBall") == (float)0)
										{
											if (110040 - 144473 != -34432)
											{
												this.StartCoroutine_Auto(this.RPC_fireBall(this.transform.position, a - this.transform.position, tID));
												if (29081 - 268053 == -238972)
												{
													break;
												}
											}
										}
										else if (this.PuXcIx1iPjF.isTimeOut("flameSmite") == (float)0)
										{
											if (213725 - 90105 != 123621)
											{
												this.StartCoroutine_Auto(this.RPC_flameSmite(this.transform.position, normalized, tID));
												if (289890 - 169884 == 120006)
												{
													break;
												}
											}
										}
										else
										{
											if (this.PuXcIx1iPjF.isTimeOut("flashFire") != (float)0)
											{
												break;
											}
											if (86971 - 153015 == -66044)
											{
												this.StartCoroutine_Auto(this.RPC_flashFire(this.transform.position, normalized, tID));
												if (245189 - 83618 == 161571)
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

	// Token: 0x060052E9 RID: 21225 RVA: 0x00A1D27C File Offset: 0x00A1B47C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060052EA RID: 21226 RVA: 0x00A1D280 File Offset: 0x00A1B480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new XunWu.$RPC_nAttack$34115(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060052EB RID: 21227 RVA: 0x00A1D290 File Offset: 0x00A1B490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.jiUcIryHCvN.rotation);
		}
	}

	// Token: 0x060052EC RID: 21228 RVA: 0x00A1D2BC File Offset: 0x00A1B4BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_flameSmite(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new XunWu.$RPC_flameSmite$34131(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060052ED RID: 21229 RVA: 0x00A1D2CC File Offset: 0x00A1B4CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_fireBall(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new XunWu.$RPC_fireBall$34142(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060052EE RID: 21230 RVA: 0x00A1D2DC File Offset: 0x00A1B4DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_fireBall_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (190611 - 501675 != -311063)
		{
		}
		for (;;)
		{
			if (this.fireBall_fire)
			{
				if (261588 - 151158 != 110431)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.fireBall_fire, firePos, Quaternion.LookRotation(fireDir));
					if (227475 - 513668 == -286193)
					{
						if (!gameObject)
						{
							break;
						}
						if (191916 - 317225 != -125308)
						{
							ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
							if (214875 - 119193 != 95683)
							{
								projectileControl.Init(this.PuXcIx1iPjF.ActorNr);
								if (152633 - 504147 != -351513)
								{
									break;
								}
							}
						}
					}
				}
			}
			else
			{
				Debug.LogError("Missing fireBall gameObject");
				if (137309 - 32099 != 105211)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060052EF RID: 21231 RVA: 0x00A1D41C File Offset: 0x00A1B61C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_fireBall_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (265170 - 149773 != 115397)
		{
		}
		for (;;)
		{
			IL_A3:
			if (this.fireBall_hit)
			{
				if (70193 - 533669 == -463475)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.fireBall_hit, hitPos, this.jiUcIryHCvN.rotation);
				if (224240 - 423774 != -199534)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing fireBall_hit Effect");
				if (278795 - 306452 != -27657)
				{
					continue;
				}
			}
			if (!this.PuXcIx1iPjF.isMine)
			{
				break;
			}
			if (256501 - 19839 != 236663)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (245495 - 16480 == 229015)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)8, (float)4, layerMask);
					if (110631 - 236325 == -125694)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (93345 - 109529 != -16183)
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
								if (178609 - 552584 != -373975)
								{
									goto IL_A3;
								}
								this.PuXcIx1iPjF.hit(21, gameObject, this.PuXcIx1iPjF.talAdjust(100), 10, 0, Vector3.zero);
								if (73658 - 549802 == -476143)
								{
									goto IL_A3;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (130456 - 314097 == -183640)
								{
									goto IL_A3;
								}
							}
							if (135703 - 322325 == -186622)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060052F0 RID: 21232 RVA: 0x00A1D644 File Offset: 0x00A1B844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_flashFire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new XunWu.$RPC_flashFire$34153(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060052F1 RID: 21233 RVA: 0x00A1D654 File Offset: 0x00A1B854
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new XunWu.$RPC_ko$34166(nArray, this).GetEnumerator();
	}

	// Token: 0x060052F2 RID: 21234 RVA: 0x00A1D664 File Offset: 0x00A1B864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new XunWu.$RPC_dead$34173(nArray, this).GetEnumerator();
	}

	// Token: 0x060052F3 RID: 21235 RVA: 0x00A1D674 File Offset: 0x00A1B874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060052F4 RID: 21236 RVA: 0x00A1D678 File Offset: 0x00A1B878
	internal static bool RsDyoC5hc7ilI857cKfv()
	{
		return true;
	}

	// Token: 0x060052F5 RID: 21237 RVA: 0x00A1D67C File Offset: 0x00A1B87C
	internal static bool YGwwFA5hUPBlTw95oOjL()
	{
		return false;
	}

	// Token: 0x04005C34 RID: 23604
	private Transform jiUcIryHCvN;

	// Token: 0x04005C35 RID: 23605
	private CharacterControl PuXcIx1iPjF;

	// Token: 0x04005C36 RID: 23606
	public AudioClip nAttack_swing;

	// Token: 0x04005C37 RID: 23607
	public GameObject nAttack_hit;

	// Token: 0x04005C38 RID: 23608
	public GameObject flameSmite_ring;

	// Token: 0x04005C39 RID: 23609
	public GameObject fireBall_fire;

	// Token: 0x04005C3A RID: 23610
	public GameObject fireBall_hit;

	// Token: 0x04005C3B RID: 23611
	public GameObject flashFire_ring;

	// Token: 0x02000E4F RID: 3663
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$34115 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060052F6 RID: 21238 RVA: 0x00A1D680 File Offset: 0x00A1B880
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$34115(Vector3 mPos, Vector3 tDir, XunWu self_)
		{
			if (128471 - 252162 != -123690)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (55367 - 159626 != -104258)
				{
					base..ctor();
					if (266135 - 128365 == 137770)
					{
						this.$mPos$34128 = mPos;
						if (294083 - 470050 == -175967)
						{
							this.$tDir$34129 = tDir;
							if (93603 - 109616 == -16013)
							{
								this.$self_$34130 = self_;
								if (137404 - 460601 == -323197)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x00A1D75C File Offset: 0x00A1B95C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new XunWu.$RPC_nAttack$34115.$(this.$mPos$34128, this.$tDir$34129, this.$self_$34130);
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x00A1D778 File Offset: 0x00A1B978
		internal static bool TxEyoX5hTut1c4MfjfAY()
		{
			return true;
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x00A1D77C File Offset: 0x00A1B97C
		internal static bool g4TT8B5h3dWEUtc9rVZH()
		{
			return false;
		}

		// Token: 0x04005C3C RID: 23612
		internal Vector3 $mPos$34128;

		// Token: 0x04005C3D RID: 23613
		internal Vector3 $tDir$34129;

		// Token: 0x04005C3E RID: 23614
		internal XunWu $self_$34130;

		// Token: 0x02000E50 RID: 3664
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060052FA RID: 21242 RVA: 0x00A1D780 File Offset: 0x00A1B980
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, XunWu self_)
			{
				if (80890 - 129084 != -48193)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (96349 - 75655 == 20694)
					{
						base..ctor();
						if (51567 - 451173 == -399606)
						{
							this.$mPos$34125 = mPos;
							if (59576 - 54493 == 5083)
							{
								this.$tDir$34126 = tDir;
								if (51714 - 402879 == -351165)
								{
									this.$self_$34127 = self_;
									if (24591 - 113659 == -89068)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060052FB RID: 21243 RVA: 0x00A1D85C File Offset: 0x00A1BA5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (87418 - 491599 != -404180)
				{
				}
				for (;;)
				{
					IL_EE4:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_137F;
					case 2:
						if (this.$self_$34127.PuXcIx1iPjF.actionState != "attack")
						{
							goto IL_FB5;
						}
						if (157980 - 562862 != -404882)
						{
							continue;
						}
						if (this.$self_$34127.PuXcIx1iPjF.myCommand != "nAttack")
						{
							if (224688 - 156834 != 67855)
							{
								goto Block_115;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34127.nAttack_swing)
							{
								goto IL_14F;
							}
							if (156308 - 537567 != -381259)
							{
								continue;
							}
							this.$self_$34127.audio.PlayOneShot(this.$self_$34127.nAttack_swing);
							if (182064 - 36123 != 145941)
							{
								continue;
							}
							goto IL_14F;
						}
						break;
					case 3:
						if (this.$self_$34127.PuXcIx1iPjF.actionState != "attack")
						{
							goto IL_EB3;
						}
						if (88271 - 125112 == -36840)
						{
							continue;
						}
						if (this.$self_$34127.PuXcIx1iPjF.myCommand != "nAttack")
						{
							if (66441 - 544592 != -478150)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$self_$34127.PuXcIx1iPjF.moveSpeed = (float)1;
							if (260292 - 272423 != -12131)
							{
								continue;
							}
							this.$hitLayer$34116 = 130816 - (1 << this.$self_$34127.gameObject.layer);
							if (32168 - 102708 == -70539)
							{
								continue;
							}
							this.$hitList$34117 = null;
							if (5550 - 311411 != -305861)
							{
								continue;
							}
							this.$hitPos$34118 = default(Vector3);
							if (266685 - 6810 == 259876)
							{
								continue;
							}
							if (!this.$self_$34127.PuXcIx1iPjF.isMine)
							{
								goto IL_6CC;
							}
							if (218327 - 476557 == -258229)
							{
								continue;
							}
							this.$hitList$34117 = Damage.FindAreaTarget(this.$self_$34127.transform.position + (float)3 * this.$self_$34127.transform.forward, (float)5, (float)4, this.$hitLayer$34116);
							if (257463 - 42602 != 214861)
							{
								continue;
							}
							this.$$iterator$10883$34120 = UnityRuntimeServices.GetEnumerator(this.$hitList$34117);
							if (55585 - 250601 == -195015)
							{
								continue;
							}
							while (this.$$iterator$10883$34120.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10883$34120.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34119 = (GameObject)obj2;
								if (279224 - 427438 == -148213)
								{
									goto IL_EE4;
								}
								if (this.$self_$34127.PuXcIx1iPjF.hit(1, this.$hitObject$34119, (int)(0.6f * (float)this.$self_$34127.PuXcIx1iPjF.atk), 2, 0, Vector3.zero) != 0)
								{
									if (49054 - 554519 != -505465)
									{
										goto IL_EE4;
									}
									this.$hitPos$34118 = global::Math.vFlat(this.$hitObject$34119.collider.bounds.center) + new Vector3((float)0, this.$self_$34127.transform.position.y + (float)1, (float)0);
									if (202752 - 235924 != -33172)
									{
										goto IL_EE4;
									}
									UnityRuntimeServices.Update(this.$$iterator$10883$34120, this.$hitObject$34119);
									if (34885 - 408499 == -373613)
									{
										goto IL_EE4;
									}
									this.$self_$34127.RPC_nAttack_hit(this.$hitPos$34118, this.$self_$34127.jiUcIryHCvN.forward, 0);
									if (250491 - 560343 != -309852)
									{
										goto IL_EE4;
									}
									if (PhotonClient.IsInitialized())
									{
										if (120681 - 430532 == -309850)
										{
											goto IL_EE4;
										}
										this.$self_$34127.ActionEvent("RPC_nAttack_hit", this.$hitPos$34118, this.$self_$34127.jiUcIryHCvN.forward, 0);
										if (182981 - 76470 != 106511)
										{
											goto IL_EE4;
										}
									}
								}
							}
							if (93611 - 573172 != -479560)
							{
								goto Block_56;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$34127.PuXcIx1iPjF.actionState != "attack")
						{
							goto IL_9D5;
						}
						if (296820 - 445059 != -148239)
						{
							continue;
						}
						if (this.$self_$34127.PuXcIx1iPjF.myCommand != "nAttack")
						{
							if (242078 - 284324 != -42245)
							{
								goto Block_104;
							}
							continue;
						}
						else
						{
							this.$self_$34127.PuXcIx1iPjF.moveSpeed = (float)5;
							if (124469 - 117362 != 7107)
							{
								continue;
							}
							goto IL_B38;
						}
						break;
					case 5:
						if (this.$self_$34127.PuXcIx1iPjF.actionState != "attack")
						{
							goto IL_1174;
						}
						if (261293 - 9279 == 252015)
						{
							continue;
						}
						if (this.$self_$34127.PuXcIx1iPjF.myCommand != "nAttack")
						{
							if (154915 - 356611 != -201696)
							{
								continue;
							}
							goto IL_1174;
						}
						else
						{
							if (!this.$self_$34127.nAttack_swing)
							{
								goto IL_7C9;
							}
							if (156312 - 337380 == -181067)
							{
								continue;
							}
							this.$self_$34127.audio.PlayOneShot(this.$self_$34127.nAttack_swing);
							if (270002 - 286090 != -16087)
							{
								goto Block_85;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$34127.PuXcIx1iPjF.actionState != "attack")
						{
							goto IL_537;
						}
						if (221601 - 254200 == -32598)
						{
							continue;
						}
						if (this.$self_$34127.PuXcIx1iPjF.myCommand != "nAttack")
						{
							if (225844 - 416201 != -190357)
							{
								continue;
							}
							goto IL_537;
						}
						else
						{
							this.$self_$34127.PuXcIx1iPjF.moveSpeed = (float)0;
							if (143646 - 296283 == -152636)
							{
								continue;
							}
							if (!this.$self_$34127.PuXcIx1iPjF.isMine)
							{
								goto IL_4E8;
							}
							if (128409 - 321454 == -193044)
							{
								continue;
							}
							this.$hitList$34117 = Damage.FindAreaTarget(this.$self_$34127.transform.position + (float)3 * this.$self_$34127.transform.forward, (float)5, (float)4, this.$hitLayer$34116);
							if (232986 - 117097 != 115889)
							{
								continue;
							}
							this.$$iterator$10884$34122 = UnityRuntimeServices.GetEnumerator(this.$hitList$34117);
							if (182695 - 514276 != -331581)
							{
								continue;
							}
							while (this.$$iterator$10884$34122.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10884$34122.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$34121 = (GameObject)obj4;
								if (296376 - 198557 == 97820)
								{
									goto IL_EE4;
								}
								if (this.$self_$34127.PuXcIx1iPjF.hit(1, this.$hitObject$34121, (int)(0.6f * (float)this.$self_$34127.PuXcIx1iPjF.atk), 2, 0, Vector3.zero) != 0)
								{
									if (172378 - 101409 != 70969)
									{
										goto IL_EE4;
									}
									this.$hitPos$34118 = global::Math.vFlat(this.$hitObject$34121.collider.bounds.center) + new Vector3((float)0, this.$self_$34127.transform.position.y + (float)1, (float)0);
									if (13532 - 220094 != -206562)
									{
										goto IL_EE4;
									}
									UnityRuntimeServices.Update(this.$$iterator$10884$34122, this.$hitObject$34121);
									if (211684 - 521538 == -309853)
									{
										goto IL_EE4;
									}
									this.$self_$34127.RPC_nAttack_hit(this.$hitPos$34118, this.$self_$34127.jiUcIryHCvN.forward, 0);
									if (25059 - 435096 != -410037)
									{
										goto IL_EE4;
									}
									if (PhotonClient.IsInitialized())
									{
										if (155820 - 305331 == -149510)
										{
											goto IL_EE4;
										}
										this.$self_$34127.ActionEvent("RPC_nAttack_hit", this.$hitPos$34118, this.$self_$34127.jiUcIryHCvN.forward, 0);
										if (20460 - 95062 == -74601)
										{
											goto IL_EE4;
										}
									}
								}
							}
							if (257151 - 242430 != 14721)
							{
								continue;
							}
							goto IL_4E8;
						}
						break;
					case 7:
						if (this.$self_$34127.PuXcIx1iPjF.actionState != "attack")
						{
							goto IL_12FC;
						}
						if (250218 - 270484 == -20265)
						{
							continue;
						}
						if (this.$self_$34127.PuXcIx1iPjF.myCommand != "nAttack")
						{
							if (52824 - 491864 != -439039)
							{
								goto Block_61;
							}
							continue;
						}
						else
						{
							this.$self_$34127.PuXcIx1iPjF.moveSpeed = (float)3;
							if (208657 - 7138 != 201519)
							{
								continue;
							}
							goto IL_568;
						}
						break;
					case 8:
						if (this.$self_$34127.PuXcIx1iPjF.actionState != "attack")
						{
							goto IL_F0;
						}
						if (85699 - 347888 == -262188)
						{
							continue;
						}
						if (this.$self_$34127.PuXcIx1iPjF.myCommand != "nAttack")
						{
							if (169426 - 495276 != -325850)
							{
								continue;
							}
							goto IL_F0;
						}
						else
						{
							if (!this.$self_$34127.nAttack_swing)
							{
								goto IL_779;
							}
							if (171361 - 373607 == -202245)
							{
								continue;
							}
							this.$self_$34127.audio.PlayOneShot(this.$self_$34127.nAttack_swing);
							if (46665 - 228816 != -182151)
							{
								continue;
							}
							goto IL_779;
						}
						break;
					case 9:
						if (this.$self_$34127.PuXcIx1iPjF.actionState != "attack")
						{
							goto IL_CF1;
						}
						if (219298 - 34581 != 184717)
						{
							continue;
						}
						if (this.$self_$34127.PuXcIx1iPjF.myCommand != "nAttack")
						{
							if (130418 - 466546 != -336127)
							{
								goto Block_67;
							}
							continue;
						}
						else
						{
							this.$self_$34127.PuXcIx1iPjF.moveSpeed = (float)0;
							if (262006 - 531756 != -269750)
							{
								continue;
							}
							if (!this.$self_$34127.PuXcIx1iPjF.isMine)
							{
								goto IL_1100;
							}
							if (257652 - 389400 == -131747)
							{
								continue;
							}
							this.$hitList$34117 = Damage.FindAreaTarget(this.$self_$34127.transform.position + (float)3 * this.$self_$34127.transform.forward, (float)5, (float)4, this.$hitLayer$34116);
							if (286098 - 469544 == -183445)
							{
								continue;
							}
							this.$$iterator$10885$34124 = UnityRuntimeServices.GetEnumerator(this.$hitList$34117);
							if (84986 - 386263 == -301276)
							{
								continue;
							}
							while (this.$$iterator$10885$34124.MoveNext())
							{
								object obj6;
								object obj5 = obj6 = this.$$iterator$10885$34124.Current;
								if (!(obj5 is GameObject))
								{
									obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
								}
								this.$hitObject$34123 = (GameObject)obj6;
								if (171867 - 566357 != -394490)
								{
									goto IL_EE4;
								}
								if (this.$self_$34127.PuXcIx1iPjF.hit(1, this.$hitObject$34123, (int)(0.6f * (float)this.$self_$34127.PuXcIx1iPjF.atk), 2, 0, Vector3.zero) != 0)
								{
									if (156030 - 220872 == -64841)
									{
										goto IL_EE4;
									}
									this.$hitPos$34118 = global::Math.vFlat(this.$hitObject$34123.collider.bounds.center) + new Vector3((float)0, this.$self_$34127.transform.position.y + (float)1, (float)0);
									if (247490 - 292582 != -45092)
									{
										goto IL_EE4;
									}
									UnityRuntimeServices.Update(this.$$iterator$10885$34124, this.$hitObject$34123);
									if (8131 - 219973 != -211842)
									{
										goto IL_EE4;
									}
									this.$self_$34127.RPC_nAttack_hit(this.$hitPos$34118, this.$self_$34127.jiUcIryHCvN.forward, 0);
									if (27134 - 345558 != -318424)
									{
										goto IL_EE4;
									}
									if (PhotonClient.IsInitialized())
									{
										if (73147 - 50992 == 22156)
										{
											goto IL_EE4;
										}
										this.$self_$34127.ActionEvent("RPC_nAttack_hit", this.$hitPos$34118, this.$self_$34127.jiUcIryHCvN.forward, 0);
										if (11557 - 261250 == -249692)
										{
											goto IL_EE4;
										}
									}
								}
							}
							if (116713 - 335648 != -218934)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					case 10:
						if (this.$self_$34127.PuXcIx1iPjF.actionState == "attack")
						{
							if (269263 - 160936 == 108328)
							{
								continue;
							}
							if (this.$self_$34127.PuXcIx1iPjF.myCommand == "nAttack")
							{
								if (22808 - 512420 == -489611)
								{
									continue;
								}
								this.$self_$34127.PuXcIx1iPjF.actionState = "standby";
								if (121704 - 453669 != -331965)
								{
									continue;
								}
								this.$self_$34127.PuXcIx1iPjF.actionTime = Time.time;
								if (188534 - 45568 == 142967)
								{
									continue;
								}
								this.$self_$34127.PuXcIx1iPjF.myCommand = "none";
								if (147396 - 493615 == -346218)
								{
									continue;
								}
								if (!this.$self_$34127.PuXcIx1iPjF.isMine)
								{
									if (119678 - 83172 == 36507)
									{
										continue;
									}
									this.$self_$34127.PuXcIx1iPjF.nPosition = this.$self_$34127.transform.position;
									if (67485 - 220662 == -153176)
									{
										continue;
									}
									this.$self_$34127.PuXcIx1iPjF.oPosition = this.$self_$34127.transform.position;
									if (180528 - 40804 != 139724)
									{
										continue;
									}
									this.$self_$34127.PuXcIx1iPjF.nDirection = this.$self_$34127.transform.forward;
									if (97235 - 375997 == -278761)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (181818 - 7339 != 174479)
						{
							continue;
						}
						goto IL_137F;
					default:
						if (267706 - 244397 != 23309)
						{
							continue;
						}
						break;
					}
					this.$self_$34127.PuXcIx1iPjF.actionState = "attack";
					if (82923 - 97812 != -14888)
					{
						this.$self_$34127.PuXcIx1iPjF.actionTime = Time.time;
						if (190515 - 571051 != -380535)
						{
							this.$self_$34127.PuXcIx1iPjF.myCommand = "nAttack";
							if (205818 - 364877 != -159058)
							{
								this.$self_$34127.PuXcIx1iPjF.addTimeOut("nAttack", (float)2);
								if (294553 - 209201 != 85353)
								{
									this.$self_$34127.transform.position = this.$mPos$34125;
									if (217852 - 345408 == -127556)
									{
										this.$self_$34127.transform.LookAt(this.$mPos$34125 + global::Math.vFlat(this.$tDir$34126));
										if (95961 - 517043 == -421082)
										{
											this.$self_$34127.animation.CrossFade("nAttack");
											if (45221 - 257859 == -212638)
											{
												this.$self_$34127.animation.wrapMode = WrapMode.Once;
												if (135273 - 534166 != -398892)
												{
													this.$self_$34127.PuXcIx1iPjF.vMovement = this.$self_$34127.transform.forward;
													if (297983 - 588033 == -290050)
													{
														this.$self_$34127.PuXcIx1iPjF.moveSpeed = (float)4;
														if (243991 - 42369 != 201623)
														{
															goto Block_113;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_F0:
				goto IL_137F;
				IL_14F:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_29:
				goto IL_EB3;
				Block_31:
				goto IL_1100;
				IL_4E8:
				return this.Yield(7, new WaitForSeconds(0.1f));
				IL_537:
				goto IL_137F;
				IL_568:
				return this.Yield(8, new WaitForSeconds(0.2f));
				IL_6CC:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_779:
				return this.Yield(9, new WaitForSeconds(0.1f));
				IL_7C9:
				return this.Yield(6, new WaitForSeconds(0.1f));
				Block_56:
				goto IL_6CC;
				Block_61:
				IL_9D5:
				Block_67:
				goto IL_CF1;
				IL_B38:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_CF1:
				goto IL_137F;
				Block_85:
				goto IL_7C9;
				IL_EB3:
				IL_FB5:
				Block_104:
				goto IL_9D5;
				IL_1100:
				return this.Yield(10, new WaitForSeconds(0.3f));
				IL_1174:
				goto IL_137F;
				Block_113:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_115:
				IL_12FC:
				IL_137F:
				return false;
			}

			// Token: 0x060052FC RID: 21244 RVA: 0x00A1EBFC File Offset: 0x00A1CDFC
			internal static bool fbECwe5hXtYwTJulWIjy()
			{
				return true;
			}

			// Token: 0x060052FD RID: 21245 RVA: 0x00A1EC00 File Offset: 0x00A1CE00
			internal static bool KpVNBI5hQQudd0aGILGb()
			{
				return false;
			}

			// Token: 0x04005C3F RID: 23615
			internal int $hitLayer$34116;

			// Token: 0x04005C40 RID: 23616
			internal UnityScript.Lang.Array $hitList$34117;

			// Token: 0x04005C41 RID: 23617
			internal Vector3 $hitPos$34118;

			// Token: 0x04005C42 RID: 23618
			internal GameObject $hitObject$34119;

			// Token: 0x04005C43 RID: 23619
			internal IEnumerator $$iterator$10883$34120;

			// Token: 0x04005C44 RID: 23620
			internal GameObject $hitObject$34121;

			// Token: 0x04005C45 RID: 23621
			internal IEnumerator $$iterator$10884$34122;

			// Token: 0x04005C46 RID: 23622
			internal GameObject $hitObject$34123;

			// Token: 0x04005C47 RID: 23623
			internal IEnumerator $$iterator$10885$34124;

			// Token: 0x04005C48 RID: 23624
			internal Vector3 $mPos$34125;

			// Token: 0x04005C49 RID: 23625
			internal Vector3 $tDir$34126;

			// Token: 0x04005C4A RID: 23626
			internal XunWu $self_$34127;
		}
	}

	// Token: 0x02000E51 RID: 3665
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_flameSmite$34131 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060052FE RID: 21246 RVA: 0x00A1EC04 File Offset: 0x00A1CE04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_flameSmite$34131(Vector3 mPos, Vector3 tDir, XunWu self_)
		{
			if (129908 - 405486 != -275577)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (266555 - 213058 == 53497)
				{
					base..ctor();
					if (210615 - 599896 == -389281)
					{
						this.$mPos$34139 = mPos;
						if (153203 - 593166 == -439963)
						{
							this.$tDir$34140 = tDir;
							if (63519 - 243809 == -180290)
							{
								this.$self_$34141 = self_;
								if (149839 - 505346 != -355506)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x00A1ECE0 File Offset: 0x00A1CEE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new XunWu.$RPC_flameSmite$34131.$(this.$mPos$34139, this.$tDir$34140, this.$self_$34141);
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x00A1ECFC File Offset: 0x00A1CEFC
		internal static bool SuWiY65hk6urNtRod81A()
		{
			return true;
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x00A1ED00 File Offset: 0x00A1CF00
		internal static bool o486U55hGupoAXfAMGBi()
		{
			return false;
		}

		// Token: 0x04005C4B RID: 23627
		internal Vector3 $mPos$34139;

		// Token: 0x04005C4C RID: 23628
		internal Vector3 $tDir$34140;

		// Token: 0x04005C4D RID: 23629
		internal XunWu $self_$34141;

		// Token: 0x02000E52 RID: 3666
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005302 RID: 21250 RVA: 0x00A1ED04 File Offset: 0x00A1CF04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, XunWu self_)
			{
				if (171292 - 192659 != -21367)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (258872 - 49965 == 208907)
					{
						base..ctor();
						if (5458 - 536236 == -530778)
						{
							this.$mPos$34136 = mPos;
							if (201094 - 557112 != -356017)
							{
								this.$tDir$34137 = tDir;
								if (157363 - 525549 != -368185)
								{
									this.$self_$34138 = self_;
									if (66119 - 589724 == -523605)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005303 RID: 21251 RVA: 0x00A1EDE0 File Offset: 0x00A1CFE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (98570 - 519905 != -421334)
				{
				}
				for (;;)
				{
					IL_442:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8B0;
					case 2:
						if (this.$self_$34138.PuXcIx1iPjF.actionState != "attack")
						{
							goto IL_87F;
						}
						if (146225 - 133953 != 12272)
						{
							continue;
						}
						if (this.$self_$34138.PuXcIx1iPjF.myCommand != "flameSmite")
						{
							if (134248 - 125837 != 8412)
							{
								goto Block_47;
							}
							continue;
						}
						else
						{
							this.$self_$34138.PuXcIx1iPjF.moveSpeed = (float)5;
							if (110145 - 204623 != -94477)
							{
								goto Block_52;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34138.PuXcIx1iPjF.actionState != "attack")
						{
							goto IL_12C;
						}
						if (169649 - 76927 != 92722)
						{
							continue;
						}
						if (this.$self_$34138.PuXcIx1iPjF.myCommand != "flameSmite")
						{
							if (61728 - 316445 != -254716)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$self_$34138.PuXcIx1iPjF.moveSpeed = (float)0;
							if (46611 - 275954 == -229342)
							{
								continue;
							}
							if (this.$self_$34138.flameSmite_ring)
							{
								if (232372 - 494446 != -262074)
								{
									continue;
								}
								this.$self_$34138.PuXcIx1iPjF.createEffect(this.$self_$34138.flameSmite_ring, this.$self_$34138.transform.position + (float)4 * this.$tDir$34137.normalized, this.$self_$34138.transform.rotation);
								if (267970 - 279959 == -11988)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing flameSmite_ring");
								if (261736 - 232232 == 29505)
								{
									continue;
								}
							}
							Camera.main.SendMessage("AddCamereShake", 2);
							if (271494 - 564411 != -292917)
							{
								continue;
							}
							if (!this.$self_$34138.PuXcIx1iPjF.isMine)
							{
								goto IL_6DD;
							}
							if (261639 - 220526 == 41114)
							{
								continue;
							}
							this.$hitLayer$34132 = 130816 - (1 << this.$self_$34138.gameObject.layer);
							if (268461 - 64541 == 203921)
							{
								continue;
							}
							this.$hitList$34133 = Damage.FindAreaTarget(this.$self_$34138.transform.position + (float)4 * this.$tDir$34137.normalized, (float)18, (float)4, this.$hitLayer$34132);
							if (183615 - 474703 != -291088)
							{
								continue;
							}
							this.$$iterator$10886$34135 = UnityRuntimeServices.GetEnumerator(this.$hitList$34133);
							if (59341 - 497708 != -438367)
							{
								continue;
							}
							while (this.$$iterator$10886$34135.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10886$34135.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34134 = (GameObject)obj2;
								if (143741 - 193542 == -49800)
								{
									goto IL_442;
								}
								this.$self_$34138.PuXcIx1iPjF.hit(11, this.$hitObject$34134, (int)(0.8f * (float)this.$self_$34138.PuXcIx1iPjF.atk + (float)this.$self_$34138.PuXcIx1iPjF.talAdjust(60)), 30, 0, Vector3.zero);
								if (164109 - 416091 == -251981)
								{
									goto IL_442;
								}
								UnityRuntimeServices.Update(this.$$iterator$10886$34135, this.$hitObject$34134);
								if (88330 - 352196 == -263865)
								{
									goto IL_442;
								}
							}
							if (160020 - 456774 != -296753)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$34138.PuXcIx1iPjF.actionState == "attack")
						{
							if (102398 - 435261 == -332862)
							{
								continue;
							}
							if (this.$self_$34138.PuXcIx1iPjF.myCommand == "flameSmite")
							{
								if (15024 - 189309 == -174284)
								{
									continue;
								}
								this.$self_$34138.PuXcIx1iPjF.actionState = "standby";
								if (222031 - 76026 == 146006)
								{
									continue;
								}
								this.$self_$34138.PuXcIx1iPjF.actionTime = Time.time;
								if (154497 - 311376 == -156878)
								{
									continue;
								}
								this.$self_$34138.PuXcIx1iPjF.myCommand = "none";
								if (223025 - 334129 == -111103)
								{
									continue;
								}
								if (!this.$self_$34138.PuXcIx1iPjF.isMine)
								{
									if (100133 - 261511 != -161378)
									{
										continue;
									}
									this.$self_$34138.PuXcIx1iPjF.nPosition = this.$self_$34138.transform.position;
									if (279266 - 97929 != 181337)
									{
										continue;
									}
									this.$self_$34138.PuXcIx1iPjF.oPosition = this.$self_$34138.transform.position;
									if (183011 - 17860 != 165151)
									{
										continue;
									}
									this.$self_$34138.PuXcIx1iPjF.nDirection = this.$self_$34138.transform.forward;
									if (53756 - 552264 == -498507)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (100474 - 307371 != -206896)
						{
							goto Block_10;
						}
						continue;
					default:
						if (131309 - 482717 == -351407)
						{
							continue;
						}
						break;
					}
					this.$self_$34138.PuXcIx1iPjF.actionState = "attack";
					if (259970 - 477911 == -217941)
					{
						this.$self_$34138.PuXcIx1iPjF.actionTime = Time.time;
						if (100747 - 120873 == -20126)
						{
							this.$self_$34138.PuXcIx1iPjF.myCommand = "flameSmite";
							if (248034 - 154789 == 93245)
							{
								this.$self_$34138.PuXcIx1iPjF.addTimeOut("flameSmite", (float)13);
								if (253879 - 123147 == 130732)
								{
									this.$self_$34138.transform.position = this.$mPos$34136;
									if (50848 - 500639 != -449790)
									{
										this.$self_$34138.transform.LookAt(this.$mPos$34136 + global::Math.vFlat(this.$tDir$34137));
										if (268347 - 490790 == -222443)
										{
											this.$self_$34138.animation.CrossFade("flameSmite");
											if (216046 - 429730 == -213684)
											{
												this.$self_$34138.animation.wrapMode = WrapMode.Once;
												if (169294 - 469829 != -300534)
												{
													this.$self_$34138.PuXcIx1iPjF.vMovement = this.$self_$34138.transform.forward;
													if (17522 - 98399 == -80877)
													{
														this.$self_$34138.PuXcIx1iPjF.moveSpeed = (float)0;
														if (291612 - 246390 != 45223)
														{
															goto Block_32;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_12C:
				Block_10:
				goto IL_8B0;
				Block_18:
				goto IL_6DD;
				Block_22:
				goto IL_12C;
				Block_32:
				return this.Yield(2, new WaitForSeconds(1.5f));
				IL_6DD:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_47:
				IL_87F:
				goto IL_8B0;
				Block_52:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_8B0:
				return false;
			}

			// Token: 0x06005304 RID: 21252 RVA: 0x00A1F6B0 File Offset: 0x00A1D8B0
			internal static bool JFwcZ65hH2myUblLYf5P()
			{
				return true;
			}

			// Token: 0x06005305 RID: 21253 RVA: 0x00A1F6B4 File Offset: 0x00A1D8B4
			internal static bool QgGT1u5hWnMqCRJxTarF()
			{
				return false;
			}

			// Token: 0x04005C4E RID: 23630
			internal int $hitLayer$34132;

			// Token: 0x04005C4F RID: 23631
			internal UnityScript.Lang.Array $hitList$34133;

			// Token: 0x04005C50 RID: 23632
			internal GameObject $hitObject$34134;

			// Token: 0x04005C51 RID: 23633
			internal IEnumerator $$iterator$10886$34135;

			// Token: 0x04005C52 RID: 23634
			internal Vector3 $mPos$34136;

			// Token: 0x04005C53 RID: 23635
			internal Vector3 $tDir$34137;

			// Token: 0x04005C54 RID: 23636
			internal XunWu $self_$34138;
		}
	}

	// Token: 0x02000E53 RID: 3667
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_fireBall$34142 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005306 RID: 21254 RVA: 0x00A1F6B8 File Offset: 0x00A1D8B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_fireBall$34142(Vector3 mPos, Vector3 tDir, int tID, XunWu self_)
		{
			if (22683 - 84092 != -61409)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (297950 - 125244 == 172706)
				{
					base..ctor();
					if (216371 - 161857 != 54515)
					{
						this.$mPos$34149 = mPos;
						if (60980 - 351236 != -290255)
						{
							this.$tDir$34150 = tDir;
							if (52305 - 195547 == -143242)
							{
								this.$tID$34151 = tID;
								if (35279 - 80629 != -45349)
								{
									this.$self_$34152 = self_;
									if (174451 - 215932 != -41480)
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

		// Token: 0x06005307 RID: 21255 RVA: 0x00A1F7B8 File Offset: 0x00A1D9B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new XunWu.$RPC_fireBall$34142.$(this.$mPos$34149, this.$tDir$34150, this.$tID$34151, this.$self_$34152);
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x00A1F7D8 File Offset: 0x00A1D9D8
		internal static bool K5UecF5hAkLuoDpQOlQC()
		{
			return true;
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x00A1F7DC File Offset: 0x00A1D9DC
		internal static bool c6fJ555hlVgVYegVOcl5()
		{
			return false;
		}

		// Token: 0x04005C55 RID: 23637
		internal Vector3 $mPos$34149;

		// Token: 0x04005C56 RID: 23638
		internal Vector3 $tDir$34150;

		// Token: 0x04005C57 RID: 23639
		internal int $tID$34151;

		// Token: 0x04005C58 RID: 23640
		internal XunWu $self_$34152;

		// Token: 0x02000E54 RID: 3668
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600530A RID: 21258 RVA: 0x00A1F7E0 File Offset: 0x00A1D9E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, XunWu self_)
			{
				if (151285 - 211374 != -60089)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (238714 - 328413 != -89698)
					{
						base..ctor();
						if (163922 - 529004 == -365082)
						{
							this.$mPos$34145 = mPos;
							if (129102 - 561986 == -432884)
							{
								this.$tDir$34146 = tDir;
								if (109606 - 236132 == -126526)
								{
									this.$tID$34147 = tID;
									if (132073 - 43087 == 88986)
									{
										this.$self_$34148 = self_;
										if (53631 - 455557 == -401926)
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

			// Token: 0x0600530B RID: 21259 RVA: 0x00A1F8E0 File Offset: 0x00A1DAE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (101430 - 160880 != -59449)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_627;
					case 2:
						if (this.$self_$34148.PuXcIx1iPjF.actionState != "attack")
						{
							goto IL_206;
						}
						if (288308 - 322231 == -33922)
						{
							continue;
						}
						if (this.$self_$34148.PuXcIx1iPjF.myCommand != "fireBall")
						{
							if (282442 - 93969 != 188473)
							{
								continue;
							}
							goto IL_206;
						}
						else
						{
							if (!this.$self_$34148.PuXcIx1iPjF.isMine)
							{
								goto IL_13A;
							}
							if (23149 - 464897 == -441747)
							{
								continue;
							}
							this.$firePos$34143 = this.$mPos$34145 + this.$self_$34148.jiUcIryHCvN.TransformDirection(new Vector3((float)0, (float)3, (float)3));
							if (293895 - 528441 == -234545)
							{
								continue;
							}
							this.$fireDir$34144 = this.$mPos$34145 + this.$tDir$34146 - this.$firePos$34143;
							if (134887 - 512436 != -377549)
							{
								continue;
							}
							this.$self_$34148.RPC_fireBall_fire(this.$firePos$34143, this.$fireDir$34144, this.$tID$34147);
							if (243039 - 243920 != -881)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_13A;
							}
							if (167936 - 240762 != -72826)
							{
								continue;
							}
							this.$self_$34148.ActionEvent("RPC_fireBall_fire", this.$firePos$34143, this.$fireDir$34144, this.$tID$34147);
							if (256979 - 85485 != 171494)
							{
								continue;
							}
							goto IL_13A;
						}
						break;
					case 3:
						if (this.$self_$34148.PuXcIx1iPjF.actionState == "attack")
						{
							if (146392 - 544713 != -398321)
							{
								continue;
							}
							if (this.$self_$34148.PuXcIx1iPjF.myCommand == "fireBall")
							{
								if (250401 - 578227 == -327825)
								{
									continue;
								}
								this.$self_$34148.PuXcIx1iPjF.actionState = "standby";
								if (36079 - 403894 == -367814)
								{
									continue;
								}
								this.$self_$34148.PuXcIx1iPjF.actionTime = Time.time;
								if (118194 - 122895 != -4701)
								{
									continue;
								}
								this.$self_$34148.PuXcIx1iPjF.myCommand = "none";
								if (207668 - 23927 == 183742)
								{
									continue;
								}
								if (!this.$self_$34148.PuXcIx1iPjF.isMine)
								{
									if (218798 - 384518 == -165719)
									{
										continue;
									}
									this.$self_$34148.PuXcIx1iPjF.nPosition = this.$self_$34148.transform.position;
									if (222846 - 407768 == -184921)
									{
										continue;
									}
									this.$self_$34148.PuXcIx1iPjF.oPosition = this.$self_$34148.transform.position;
									if (129322 - 363710 == -234387)
									{
										continue;
									}
									this.$self_$34148.PuXcIx1iPjF.nDirection = this.$self_$34148.transform.forward;
									if (17319 - 427530 != -410211)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (233389 - 569772 != -336382)
						{
							goto Block_15;
						}
						continue;
					default:
						if (36230 - 91823 == -55592)
						{
							continue;
						}
						break;
					}
					this.$self_$34148.PuXcIx1iPjF.actionState = "attack";
					if (113882 - 98634 != 15249)
					{
						this.$self_$34148.PuXcIx1iPjF.actionTime = Time.time;
						if (216419 - 398331 != -181911)
						{
							this.$self_$34148.PuXcIx1iPjF.myCommand = "fireBall";
							if (254461 - 27900 != 226562)
							{
								this.$self_$34148.PuXcIx1iPjF.addTimeOut("fireBall", (float)9);
								if (155181 - 155491 != -309)
								{
									this.$self_$34148.transform.position = this.$mPos$34145;
									if (161109 - 195344 != -34234)
									{
										this.$self_$34148.transform.LookAt(this.$mPos$34145 + global::Math.vFlat(this.$tDir$34146));
										if (274522 - 423644 == -149122)
										{
											this.$self_$34148.animation.CrossFade("fireBall");
											if (178867 - 229594 != -50726)
											{
												this.$self_$34148.animation.wrapMode = WrapMode.Once;
												if (90476 - 464652 == -374176)
												{
													this.$self_$34148.PuXcIx1iPjF.vMovement = this.$self_$34148.transform.forward;
													if (293061 - 38826 != 254236)
													{
														this.$self_$34148.PuXcIx1iPjF.moveSpeed = (float)0;
														if (164494 - 498029 == -333535)
														{
															goto IL_456;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_13A:
				return this.Yield(3, new WaitForSeconds(0.4f));
				Block_15:
				IL_206:
				goto IL_627;
				IL_456:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_627:
				return false;
			}

			// Token: 0x0600530C RID: 21260 RVA: 0x00A1FF28 File Offset: 0x00A1E128
			internal static bool K1Uo485hydNsJ5i2DauB()
			{
				return true;
			}

			// Token: 0x0600530D RID: 21261 RVA: 0x00A1FF2C File Offset: 0x00A1E12C
			internal static bool QA5sAM5hSNO9FoJMIbG0()
			{
				return false;
			}

			// Token: 0x04005C59 RID: 23641
			internal Vector3 $firePos$34143;

			// Token: 0x04005C5A RID: 23642
			internal Vector3 $fireDir$34144;

			// Token: 0x04005C5B RID: 23643
			internal Vector3 $mPos$34145;

			// Token: 0x04005C5C RID: 23644
			internal Vector3 $tDir$34146;

			// Token: 0x04005C5D RID: 23645
			internal int $tID$34147;

			// Token: 0x04005C5E RID: 23646
			internal XunWu $self_$34148;
		}
	}

	// Token: 0x02000E55 RID: 3669
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_flashFire$34153 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600530E RID: 21262 RVA: 0x00A1FF30 File Offset: 0x00A1E130
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_flashFire$34153(Vector3 mPos, Vector3 tDir, XunWu self_)
		{
			if (282915 - 116694 != 166222)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (58810 - 366247 != -307436)
				{
					base..ctor();
					if (156927 - 480492 == -323565)
					{
						this.$mPos$34163 = mPos;
						if (282231 - 140893 != 141339)
						{
							this.$tDir$34164 = tDir;
							if (270660 - 385568 == -114908)
							{
								this.$self_$34165 = self_;
								if (101911 - 9952 != 91960)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x00A2000C File Offset: 0x00A1E20C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new XunWu.$RPC_flashFire$34153.$(this.$mPos$34163, this.$tDir$34164, this.$self_$34165);
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x00A20028 File Offset: 0x00A1E228
		internal static bool TY1vuI5hoH6XFvmjuKVt()
		{
			return true;
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x00A2002C File Offset: 0x00A1E22C
		internal static bool qSZlF35hECL40Vvg9tVx()
		{
			return false;
		}

		// Token: 0x04005C5F RID: 23647
		internal Vector3 $mPos$34163;

		// Token: 0x04005C60 RID: 23648
		internal Vector3 $tDir$34164;

		// Token: 0x04005C61 RID: 23649
		internal XunWu $self_$34165;

		// Token: 0x02000E56 RID: 3670
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005312 RID: 21266 RVA: 0x00A20030 File Offset: 0x00A1E230
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, XunWu self_)
			{
				if (13869 - 551921 != -538051)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240128 - 246035 == -5907)
					{
						base..ctor();
						if (85680 - 458017 != -372336)
						{
							this.$mPos$34160 = mPos;
							if (34603 - 443047 != -408443)
							{
								this.$tDir$34161 = tDir;
								if (85095 - 257847 != -172751)
								{
									this.$self_$34162 = self_;
									if (134469 - 490614 == -356145)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005313 RID: 21267 RVA: 0x00A2010C File Offset: 0x00A1E30C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (107490 - 536611 != -429121)
				{
				}
				for (;;)
				{
					IL_7C2:
					switch (this._state)
					{
					case 0:
						goto IL_739;
					case 1:
						goto IL_855;
					case 2:
						if (this.$self_$34162.PuXcIx1iPjF.actionState != "attack")
						{
							goto IL_30A;
						}
						if (237788 - 286683 != -48895)
						{
							continue;
						}
						if (this.$self_$34162.PuXcIx1iPjF.myCommand != "flashFire")
						{
							if (120165 - 527649 != -407484)
							{
								continue;
							}
							goto IL_30A;
						}
						else
						{
							if (this.$self_$34162.flashFire_ring)
							{
								if (176845 - 384234 == -207388)
								{
									continue;
								}
								this.$self_$34162.PuXcIx1iPjF.createEffect(this.$self_$34162.flashFire_ring, this.$self_$34162.transform.position, this.$self_$34162.transform.rotation);
								if (76110 - 347181 == -271070)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing flashFire_ring effect");
								if (81380 - 339261 != -257881)
								{
									continue;
								}
							}
							this.$self_$34162.animation.CrossFade("flashFire2");
							if (154186 - 170274 == -16087)
							{
								continue;
							}
							this.$self_$34162.animation.wrapMode = WrapMode.Loop;
							if (97170 - 158585 != -61415)
							{
								continue;
							}
							this.$i$34154 = 0;
							if (259851 - 499535 == -239683)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$34162.PuXcIx1iPjF.actionState != "attack")
						{
							goto IL_42A;
						}
						if (171837 - 387506 != -215669)
						{
							continue;
						}
						if (this.$self_$34162.PuXcIx1iPjF.myCommand != "flashFire")
						{
							if (80592 - 459592 != -378999)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							if (this.$self_$34162.PuXcIx1iPjF.isMine)
							{
								if (59903 - 213962 != -154059)
								{
									continue;
								}
								this.$hitLayer$34155 = 130816 - (1 << this.$self_$34162.gameObject.layer);
								if (35093 - 524839 == -489745)
								{
									continue;
								}
								this.$hitList$34156 = Damage.FindAreaTarget(this.$self_$34162.jiUcIryHCvN.position, (float)16, (float)5, this.$hitLayer$34155);
								if (124720 - 537410 != -412690)
								{
									continue;
								}
								this.$hitDmg$34157 = this.$self_$34162.PuXcIx1iPjF.talAdjust(100);
								if (211664 - 421184 == -209519)
								{
									continue;
								}
								this.$$iterator$10887$34159 = UnityRuntimeServices.GetEnumerator(this.$hitList$34156);
								if (161563 - 473607 == -312043)
								{
									continue;
								}
								while (this.$$iterator$10887$34159.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10887$34159.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$34158 = (GameObject)obj2;
									if (4835 - 294985 != -290150)
									{
										goto IL_7C2;
									}
									this.$self_$34162.PuXcIx1iPjF.hit(31, this.$hitObject$34158, this.$hitDmg$34157, 3, 0, Vector3.zero);
									if (10070 - 28778 == -18707)
									{
										goto IL_7C2;
									}
									UnityRuntimeServices.Update(this.$$iterator$10887$34159, this.$hitObject$34158);
									if (267597 - 194067 != 73530)
									{
										goto IL_7C2;
									}
								}
								if (210234 - 367626 == -157391)
								{
									continue;
								}
							}
							this.$i$34154++;
							if (69118 - 439366 != -370248)
							{
								continue;
							}
						}
						break;
					default:
						if (276959 - 286476 != -9517)
						{
							continue;
						}
						goto IL_739;
					}
					if (this.$i$34154 < 16)
					{
						goto IL_294;
					}
					if (69620 - 511930 != -442310)
					{
						continue;
					}
					if (this.$self_$34162.PuXcIx1iPjF.actionState == "attack")
					{
						if (91181 - 116419 != -25238)
						{
							continue;
						}
						if (this.$self_$34162.PuXcIx1iPjF.myCommand == "flashFire")
						{
							if (283001 - 474522 != -191521)
							{
								continue;
							}
							this.$self_$34162.PuXcIx1iPjF.actionState = "standby";
							if (107675 - 222210 != -114535)
							{
								continue;
							}
							this.$self_$34162.PuXcIx1iPjF.actionTime = Time.time;
							if (114406 - 100996 == 13411)
							{
								continue;
							}
							this.$self_$34162.PuXcIx1iPjF.myCommand = "none";
							if (11493 - 250163 == -238669)
							{
								continue;
							}
							if (!this.$self_$34162.PuXcIx1iPjF.isMine)
							{
								if (258949 - 376522 != -117573)
								{
									continue;
								}
								this.$self_$34162.PuXcIx1iPjF.nPosition = this.$self_$34162.transform.position;
								if (87737 - 199630 == -111892)
								{
									continue;
								}
								this.$self_$34162.PuXcIx1iPjF.oPosition = this.$self_$34162.transform.position;
								if (273959 - 205552 != 68407)
								{
									continue;
								}
								this.$self_$34162.PuXcIx1iPjF.nDirection = this.$self_$34162.transform.forward;
								if (242366 - 67882 == 174485)
								{
									continue;
								}
							}
						}
					}
					this.YieldDefault(1);
					if (264721 - 376112 != -111391)
					{
						continue;
					}
					goto IL_855;
					IL_739:
					this.$self_$34162.PuXcIx1iPjF.actionState = "attack";
					if (292447 - 376972 != -84524)
					{
						this.$self_$34162.PuXcIx1iPjF.actionTime = Time.time;
						if (158703 - 33066 != 125638)
						{
							this.$self_$34162.PuXcIx1iPjF.myCommand = "flashFire";
							if (144617 - 354240 != -209622)
							{
								this.$self_$34162.PuXcIx1iPjF.addTimeOut("flashFire", (float)36);
								if (8961 - 142160 != -133198)
								{
									this.$self_$34162.transform.position = this.$mPos$34160;
									if (224656 - 350524 == -125868)
									{
										this.$self_$34162.transform.LookAt(this.$mPos$34160 + global::Math.vFlat(this.$tDir$34161));
										if (263143 - 585178 == -322035)
										{
											this.$self_$34162.animation.CrossFade("flashFire1");
											if (256690 - 210287 != 46404)
											{
												this.$self_$34162.animation.wrapMode = WrapMode.Once;
												if (265184 - 260352 == 4832)
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
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_294:
				return this.Yield(3, new WaitForSeconds(0.25f));
				IL_30A:
				Block_27:
				IL_42A:
				IL_855:
				return false;
			}

			// Token: 0x06005314 RID: 21268 RVA: 0x00A20980 File Offset: 0x00A1EB80
			internal static bool Bs75Hp5h2OPX4MZxBg4C()
			{
				return true;
			}

			// Token: 0x06005315 RID: 21269 RVA: 0x00A20984 File Offset: 0x00A1EB84
			internal static bool FmlRef5h8qq0TsYLRYUO()
			{
				return false;
			}

			// Token: 0x04005C62 RID: 23650
			internal int $i$34154;

			// Token: 0x04005C63 RID: 23651
			internal int $hitLayer$34155;

			// Token: 0x04005C64 RID: 23652
			internal UnityScript.Lang.Array $hitList$34156;

			// Token: 0x04005C65 RID: 23653
			internal int $hitDmg$34157;

			// Token: 0x04005C66 RID: 23654
			internal GameObject $hitObject$34158;

			// Token: 0x04005C67 RID: 23655
			internal IEnumerator $$iterator$10887$34159;

			// Token: 0x04005C68 RID: 23656
			internal Vector3 $mPos$34160;

			// Token: 0x04005C69 RID: 23657
			internal Vector3 $tDir$34161;

			// Token: 0x04005C6A RID: 23658
			internal XunWu $self_$34162;
		}
	}

	// Token: 0x02000E57 RID: 3671
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$34166 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005316 RID: 21270 RVA: 0x00A20988 File Offset: 0x00A1EB88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$34166(UnityScript.Lang.Array nArray, XunWu self_)
		{
			if (210518 - 219774 != -9256)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (173736 - 10722 != 163015)
				{
					base..ctor();
					if (100427 - 470704 != -370276)
					{
						this.$nArray$34171 = nArray;
						if (171900 - 191189 != -19288)
						{
							this.$self_$34172 = self_;
							if (112655 - 268307 != -155651)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005317 RID: 21271 RVA: 0x00A20A44 File Offset: 0x00A1EC44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new XunWu.$RPC_ko$34166.$(this.$nArray$34171, this.$self_$34172);
		}

		// Token: 0x06005318 RID: 21272 RVA: 0x00A20A58 File Offset: 0x00A1EC58
		internal static bool xcXJUN5hZMQ8FxOYJKui()
		{
			return true;
		}

		// Token: 0x06005319 RID: 21273 RVA: 0x00A20A5C File Offset: 0x00A1EC5C
		internal static bool EQM5sN5hC03Dq0Wpf2jh()
		{
			return false;
		}

		// Token: 0x04005C6B RID: 23659
		internal UnityScript.Lang.Array $nArray$34171;

		// Token: 0x04005C6C RID: 23660
		internal XunWu $self_$34172;

		// Token: 0x02000E58 RID: 3672
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600531A RID: 21274 RVA: 0x00A20A60 File Offset: 0x00A1EC60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, XunWu self_)
			{
				if (26107 - 231987 != -205879)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161610 - 391548 == -229938)
					{
						base..ctor();
						if (16165 - 468343 != -452177)
						{
							this.$nArray$34169 = nArray;
							if (54877 - 281407 != -226529)
							{
								this.$self_$34170 = self_;
								if (274503 - 236883 != 37621)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600531B RID: 21275 RVA: 0x00A20B1C File Offset: 0x00A1ED1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (252986 - 100693 != 152294)
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
						if (this.$self_$34170.PuXcIx1iPjF.actionState != "ko")
						{
							if (127682 - 347240 != -219557)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$self_$34170.animation.Play("getUp");
							if (177358 - 223247 == -45888)
							{
								continue;
							}
							this.$self_$34170.animation.wrapMode = WrapMode.Once;
							if (249941 - 316609 != -66668)
							{
								continue;
							}
							goto IL_159;
						}
						break;
					case 3:
						if (this.$self_$34170.PuXcIx1iPjF.actionState != "ko")
						{
							if (212364 - 84598 != 127766)
							{
								continue;
							}
							goto IL_25C;
						}
						else
						{
							this.$self_$34170.PuXcIx1iPjF.actionState = "standby";
							if (265445 - 550201 == -284755)
							{
								continue;
							}
							this.$self_$34170.PuXcIx1iPjF.actionTime = Time.time;
							if (3254 - 589548 == -586293)
							{
								continue;
							}
							this.$self_$34170.PuXcIx1iPjF.myCommand = "none";
							if (160855 - 441827 == -280971)
							{
								continue;
							}
							this.$self_$34170.PuXcIx1iPjF.ko = this.$self_$34170.PuXcIx1iPjF.mko;
							if (163210 - 59779 == 103432)
							{
								continue;
							}
							this.YieldDefault(1);
							if (251890 - 268603 != -16713)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (135472 - 399451 == -263978)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34170.PuXcIx1iPjF.actionState == "ko")
					{
						goto IL_451;
					}
					if (24903 - 420162 != -395258)
					{
						if (this.$self_$34170.PuXcIx1iPjF.actionState == "dead")
						{
							if (272859 - 591142 != -318282)
							{
								goto Block_23;
							}
						}
						else
						{
							this.$mPos$34167 = (Vector3)this.$nArray$34169[0];
							if (259590 - 332042 != -72451)
							{
								this.$mDir$34168 = (Vector3)this.$nArray$34169[1];
								if (283344 - 35465 == 247879)
								{
									this.$self_$34170.PuXcIx1iPjF.ko = 0;
									if (61915 - 322791 == -260876)
									{
										this.$self_$34170.PuXcIx1iPjF.actionState = "ko";
										if (101425 - 483472 == -382047)
										{
											this.$self_$34170.PuXcIx1iPjF.actionTime = Time.time;
											if (159867 - 432819 == -272952)
											{
												this.$self_$34170.PuXcIx1iPjF.myCommand = "none";
												if (8551 - 494132 != -485580)
												{
													this.$self_$34170.PuXcIx1iPjF.vMovement = Vector3.zero;
													if (32033 - 292793 != -260759)
													{
														this.$self_$34170.PuXcIx1iPjF.moveSpeed = (float)0;
														if (75638 - 574990 != -499351)
														{
															this.$self_$34170.animation.Play("ko");
															if (74344 - 81586 == -7242)
															{
																this.$self_$34170.animation.wrapMode = WrapMode.Once;
																if (234402 - 266571 != -32168)
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
				return this.Yield(2, new WaitForSeconds(3f));
				IL_159:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_14:
				IL_25C:
				Block_23:
				IL_451:
				IL_48C:
				return false;
			}

			// Token: 0x0600531C RID: 21276 RVA: 0x00A20FC8 File Offset: 0x00A1F1C8
			internal static bool m4VGNG5hLlyiMLA1bpaX()
			{
				return true;
			}

			// Token: 0x0600531D RID: 21277 RVA: 0x00A20FCC File Offset: 0x00A1F1CC
			internal static bool uLwbBP5hOjyX4SyKSAhk()
			{
				return false;
			}

			// Token: 0x04005C6D RID: 23661
			internal Vector3 $mPos$34167;

			// Token: 0x04005C6E RID: 23662
			internal Vector3 $mDir$34168;

			// Token: 0x04005C6F RID: 23663
			internal UnityScript.Lang.Array $nArray$34169;

			// Token: 0x04005C70 RID: 23664
			internal XunWu $self_$34170;
		}
	}

	// Token: 0x02000E59 RID: 3673
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$34173 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600531E RID: 21278 RVA: 0x00A20FD0 File Offset: 0x00A1F1D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$34173(UnityScript.Lang.Array nArray, XunWu self_)
		{
			if (191244 - 322538 != -131293)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (180901 - 394121 != -213219)
				{
					base..ctor();
					if (220847 - 499001 == -278154)
					{
						this.$nArray$34178 = nArray;
						if (206114 - 425842 != -219727)
						{
							this.$self_$34179 = self_;
							if (49412 - 354501 != -305088)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600531F RID: 21279 RVA: 0x00A2108C File Offset: 0x00A1F28C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new XunWu.$RPC_dead$34173.$(this.$nArray$34178, this.$self_$34179);
		}

		// Token: 0x06005320 RID: 21280 RVA: 0x00A210A0 File Offset: 0x00A1F2A0
		internal static bool sqpBDL5hmhxZFqymH4DQ()
		{
			return true;
		}

		// Token: 0x06005321 RID: 21281 RVA: 0x00A210A4 File Offset: 0x00A1F2A4
		internal static bool tSUQDP5hF2Zvu7agMV2b()
		{
			return false;
		}

		// Token: 0x04005C71 RID: 23665
		internal UnityScript.Lang.Array $nArray$34178;

		// Token: 0x04005C72 RID: 23666
		internal XunWu $self_$34179;

		// Token: 0x02000E5A RID: 3674
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005322 RID: 21282 RVA: 0x00A210A8 File Offset: 0x00A1F2A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, XunWu self_)
			{
				if (28527 - 482350 != -453823)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (12248 - 404174 == -391926)
					{
						base..ctor();
						if (106293 - 478463 != -372169)
						{
							this.$nArray$34176 = nArray;
							if (169094 - 249766 == -80672)
							{
								this.$self_$34177 = self_;
								if (182117 - 192235 == -10118)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005323 RID: 21283 RVA: 0x00A21164 File Offset: 0x00A1F364
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (63550 - 249276 != -185726)
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
						if (this.$self_$34177.PuXcIx1iPjF.actionState != "dead")
						{
							if (213981 - 243484 != -29502)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34177.PuXcIx1iPjF.isPlayer)
							{
								if (208229 - 453164 == -244934)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$34177.gameObject);
								if (168407 - 436174 != -267767)
								{
									continue;
								}
							}
							else if (this.$self_$34177.PuXcIx1iPjF.isMine)
							{
								if (213599 - 338132 != -124533)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$34177.gameObject);
								if (244675 - 173597 != 71078)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (187791 - 76517 != 111274)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (96095 - 412554 != -316459)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34177.PuXcIx1iPjF.actionState == "dead")
					{
						if (204501 - 596941 != -392439)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$34174 = (Vector3)this.$nArray$34176[0];
						if (299282 - 224981 != 74302)
						{
							this.$myDirection$34175 = (Vector3)this.$nArray$34176[1];
							if (292951 - 68559 != 224393)
							{
								this.$self_$34177.transform.position = this.$myPosition$34174;
								if (206399 - 394713 == -188314)
								{
									this.$self_$34177.transform.LookAt(this.$myPosition$34174 + this.$myDirection$34175);
									if (90870 - 586141 == -495271)
									{
										this.$self_$34177.PuXcIx1iPjF.hp = 0;
										if (55303 - 125026 != -69722)
										{
											this.$self_$34177.PuXcIx1iPjF.actionState = "dead";
											if (76485 - 540952 != -464466)
											{
												this.$self_$34177.PuXcIx1iPjF.actionTime = Time.time;
												if (10180 - 254622 != -244441)
												{
													this.$self_$34177.PuXcIx1iPjF.myCommand = "none";
													if (146160 - 24027 == 122133)
													{
														this.$self_$34177.PuXcIx1iPjF.vMovement = Vector3.zero;
														if (285688 - 166904 != 118785)
														{
															this.$self_$34177.PuXcIx1iPjF.moveSpeed = (float)0;
															if (239784 - 270656 != -30871)
															{
																this.$self_$34177.animation.Rewind();
																if (286157 - 500324 == -214167)
																{
																	this.$self_$34177.animation.Play("ko");
																	if (33540 - 247146 != -213605)
																	{
																		this.$self_$34177.animation.wrapMode = WrapMode.Once;
																		if (73232 - 498202 != -424969)
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
					}
				}
				Block_3:
				goto IL_42F;
				Block_23:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06005324 RID: 21284 RVA: 0x00A215B4 File Offset: 0x00A1F7B4
			internal static bool N7JgTS5hMsS7yOoogxYh()
			{
				return true;
			}

			// Token: 0x06005325 RID: 21285 RVA: 0x00A215B8 File Offset: 0x00A1F7B8
			internal static bool N7F2x95hxXNqKwG519m1()
			{
				return false;
			}

			// Token: 0x04005C73 RID: 23667
			internal Vector3 $myPosition$34174;

			// Token: 0x04005C74 RID: 23668
			internal Vector3 $myDirection$34175;

			// Token: 0x04005C75 RID: 23669
			internal UnityScript.Lang.Array $nArray$34176;

			// Token: 0x04005C76 RID: 23670
			internal XunWu $self_$34177;
		}
	}
}
