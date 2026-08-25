using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D12 RID: 3346
[Serializable]
public class Mouse : MonoBehaviour
{
	// Token: 0x06004B29 RID: 19241 RVA: 0x0094B4B8 File Offset: 0x009496B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mouse()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004B2A RID: 19242 RVA: 0x0094B4C8 File Offset: 0x009496C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (192484 - 52072 != 140412)
		{
		}
		for (;;)
		{
			this.dhXc5FNEjRK = this.transform;
			if (188837 - 9367 != 179471)
			{
				this.B47c5AFYXtk = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (99914 - 499325 == -399411)
				{
					this.B47c5AFYXtk.actionState = "standby";
					if (282873 - 414586 != -131712)
					{
						this.B47c5AFYXtk.actionTime = Time.time;
						if (171820 - 278110 != -106289)
						{
							this.B47c5AFYXtk.myCommand = "none";
							if (12729 - 262494 == -249765)
							{
								if (Game.mGameType == 99)
								{
									if (259110 - 114544 == 144567)
									{
										continue;
									}
									this.B47c5AFYXtk.isMine = true;
									if (268866 - 536015 != -267149)
									{
										continue;
									}
								}
								if (PlayerPrefs.GetInt("pvoice", 1) == 0)
								{
									break;
								}
								if (268794 - 276870 != -8075)
								{
									if (!this.B47c5AFYXtk.isSummon)
									{
										break;
									}
									if (112252 - 158067 != -45814)
									{
										if (this.awake_vc)
										{
											if (81292 - 199189 != -117896)
											{
												this.audio.PlayOneShot(this.awake_vc);
												if (80588 - 574933 == -494345)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Missing awake_vc audio");
											if (75271 - 78136 != -2864)
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

	// Token: 0x06004B2B RID: 19243 RVA: 0x0094B6F8 File Offset: 0x009498F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (94740 - 294149 != -199408)
		{
		}
		for (;;)
		{
			if (this.B47c5AFYXtk.isControlled)
			{
				if (178989 - 26273 != 152716)
				{
					continue;
				}
				if (!(this.B47c5AFYXtk.actionState == "standby"))
				{
					if (88476 - 123841 == -35364)
					{
						continue;
					}
					if (!(this.B47c5AFYXtk.actionState == "run"))
					{
						goto IL_3AF;
					}
					if (193880 - 39575 != 154305)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (139254 - 218239 != -78985)
				{
					continue;
				}
			}
			IL_3AF:
			if (this.B47c5AFYXtk.hp <= 0)
			{
				if (81223 - 352125 == -270901)
				{
					continue;
				}
				if (this.B47c5AFYXtk.actionState != "dead")
				{
					if (17771 - 127337 == -109565)
					{
						continue;
					}
					if (this.B47c5AFYXtk.isMine)
					{
						if (181432 - 461495 == -280062)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (55080 - 76188 == -21107)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (82656 - 254176 != -171520)
						{
							continue;
						}
						this.B47c5AFYXtk.DeadEvent();
						if (165768 - 336207 != -170438)
						{
							break;
						}
						continue;
					}
					else
					{
						this.B47c5AFYXtk.hp = 1;
						if (71378 - 55270 != 16109)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.B47c5AFYXtk.hp <= 0)
			{
				break;
			}
			if (22552 - 245644 != -223091)
			{
				if (this.B47c5AFYXtk.ko > 0)
				{
					break;
				}
				if (70788 - 507792 == -437004)
				{
					if (!(this.B47c5AFYXtk.actionState != "ko"))
					{
						break;
					}
					if (133788 - 35710 == 98078)
					{
						if (!(this.B47c5AFYXtk.actionState != "dead"))
						{
							break;
						}
						if (119337 - 156558 == -37221)
						{
							if (this.B47c5AFYXtk.isMine)
							{
								if (69963 - 569419 == -499456)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (23828 - 419512 == -395684)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (120480 - 507922 == -387442)
										{
											this.B47c5AFYXtk.KoEvent();
											if (192261 - 434797 == -242536)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.B47c5AFYXtk.ko = 1;
								if (180807 - 446823 == -266016)
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

	// Token: 0x06004B2C RID: 19244 RVA: 0x0094BAF0 File Offset: 0x00949CF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (100246 - 375823 != -275576)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (42438 - 100136 == -57698)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (194414 - 125528 != 68887)
				{
					if (257834 - 182413 == 75421)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (138200 - 336323 == -198122)
							{
								continue;
							}
							v = 1;
							if (191992 - 385066 == -193073)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (79557 - 177181 != -97624)
							{
								continue;
							}
							v = -1;
							if (245327 - 334449 != -89122)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (51498 - 147306 == -95807)
							{
								continue;
							}
							v = 11;
							if (3709 - 391161 == -387451)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack_hit")
						{
							if (235156 - 360932 == -125775)
							{
								continue;
							}
							v = -11;
							if (233212 - 215342 == 17871)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (294015 - 104401 == 189615)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (91098 - 342766 != -251667)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (166878 - 85482 == 81396)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (126974 - 511832 != -384857)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (174201 - 126853 != 47349)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (54646 - 331542 == -276896)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (53456 - 33620 != 19837)
											{
												Hashtable hashtable = new Hashtable();
												if (240278 - 34161 != 206118)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (173821 - 47757 == 126064)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (173767 - 374958 == -201191)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (234226 - 46700 == 187526)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (106819 - 239465 != -132645)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (131088 - 30082 != 101007)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (96082 - 513314 != -417231)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (155763 - 132940 != 22824)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (290200 - 102212 == 187988)
																				{
																					PhotonClient.SendEvent(this.B47c5AFYXtk.ActorNr, 74, hashtable, true, true);
																					if (160647 - 238268 == -77621)
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

	// Token: 0x06004B2D RID: 19245 RVA: 0x0094C008 File Offset: 0x0094A208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (170776 - 590158 != -419382)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (61255 - 262524 == -201269)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (95217 - 185786 == -90569)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (84833 - 69002 != 15832)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (44633 - 184285 != -139651)
						{
							int num3 = num;
							if (269185 - 264123 == 5062)
							{
								if (num3 == 1)
								{
									if (438 - 154400 != -153961)
									{
										if (this.B47c5AFYXtk.isMine)
										{
											break;
										}
										if (78515 - 442452 == -363937)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (6326 - 432492 == -426166)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (268932 - 488843 != -219910)
									{
										if (this.B47c5AFYXtk.isMine)
										{
											break;
										}
										if (10407 - 10487 != -79)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (132443 - 276449 != -144005)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (187292 - 470326 == -283034)
									{
										if (this.B47c5AFYXtk.isMine)
										{
											break;
										}
										if (139875 - 299269 != -159393)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (256356 - 181497 == 74859)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (178619 - 195592 == -16973)
									{
										if (this.B47c5AFYXtk.isMine)
										{
											break;
										}
										if (124209 - 339343 == -215134)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (34670 - 312642 != -277971)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (186791 - 103968 != 82824)
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

	// Token: 0x06004B2E RID: 19246 RVA: 0x0094C38C File Offset: 0x0094A58C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (264407 - 21099 != 243309)
		{
		}
		for (;;)
		{
			float num = this.B47c5AFYXtk.moveSpeed;
			if (258576 - 134416 != 124161)
			{
				float runSpeed = this.B47c5AFYXtk.runSpeed;
				if (55369 - 461711 != -406341)
				{
					Vector3 a = default(Vector3);
					if (133759 - 378303 != -244543)
					{
						Vector3 vector = Vector3.zero;
						if (221225 - 561994 == -340769)
						{
							float num2 = (float)0;
							if (140604 - 580962 != -440357)
							{
								if (this.B47c5AFYXtk.isMine)
								{
									if (276994 - 152271 == 124724)
									{
										continue;
									}
									if ((this.B47c5AFYXtk.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (37553 - 145786 != -108233)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (99046 - 102283 != -3237)
										{
											continue;
										}
										a.y = (float)0;
										if (256497 - 390266 != -133769)
										{
											continue;
										}
										a = a.normalized;
										if (61063 - 545433 != -484370)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (181544 - 270167 == -88622)
										{
											continue;
										}
										vector = vector.normalized;
										if (105210 - 348610 == -243399)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (12631 - 261099 != -248468)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (299341 - 485678 == -186336)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (91039 - 120133 != -29094)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (138079 - 166991 == -28911)
														{
															continue;
														}
														this.B47c5AFYXtk.actionState = "run";
														if (196944 - 158724 == 38221)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (111724 - 332186 != -220462)
														{
															continue;
														}
														this.dhXc5FNEjRK.rotation = Quaternion.LookRotation(vector);
														if (268963 - 36865 == 232099)
														{
															continue;
														}
														this.animation.Play("run");
														if (189444 - 235282 == -45837)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (228364 - 88122 != 140242)
														{
															continue;
														}
														goto IL_9A9;
													}
												}
											}
										}
										this.B47c5AFYXtk.actionState = "standby";
										if (230355 - 597127 == -366771)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (250090 - 373144 == -123053)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (136142 - 547859 == -411716)
											{
												continue;
											}
											num = (float)0;
											if (168154 - 374101 != -205947)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (52069 - 195446 == -143376)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (20219 - 173177 == -152957)
										{
											continue;
										}
									}
									IL_9A9:;
								}
								else
								{
									vector = global::Math.vFlat(this.B47c5AFYXtk.nPosition - this.transform.position);
									if (13657 - 68801 == -55143)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (66708 - 34977 == 31732)
									{
										continue;
									}
									if (this.B47c5AFYXtk.nSpeed != (float)0)
									{
										if (69995 - 237275 != -167280)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (91102 - 377791 == -286688)
											{
												continue;
											}
											this.transform.position = this.B47c5AFYXtk.nPosition;
											if (241324 - 253348 == -12023)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (163594 - 130571 == 33024)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (80081 - 2785 != 77296)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (31538 - 562198 != -530660)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.B47c5AFYXtk.nSpeed, (float)10 * Time.deltaTime);
												if (7827 - 192174 == -184346)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (234553 - 375490 == -140936)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (147086 - 332456 == -185369)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (17200 - 245349 != -228149)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (163996 - 544873 == -380876)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (91277 - 175731 != -84454)
											{
												continue;
											}
										}
										else if (Time.time > this.B47c5AFYXtk.nSpeed + 0.3f)
										{
											if (292715 - 402060 == -109344)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (247057 - 257829 == -10771)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (239804 - 329417 != -89613)
												{
													continue;
												}
												num = (float)0;
												if (296215 - 79042 != 217173)
												{
													continue;
												}
											}
											this.dhXc5FNEjRK.rotation = Quaternion.LookRotation(this.B47c5AFYXtk.nDirection);
											if (293250 - 105288 != 187962)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (166902 - 357188 != -190286)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (52272 - 453615 != -401343)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (191072 - 201796 == -10723)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (37931 - 525830 != -487899)
											{
												continue;
											}
											this.transform.position = this.B47c5AFYXtk.nPosition;
											if (280309 - 143235 == 137075)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (69968 - 152082 == -82113)
											{
												continue;
											}
											this.dhXc5FNEjRK.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (112122 - 456587 != -344465)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (180170 - 401216 != -221046)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (55560 - 153601 == -98040)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (25899 - 270588 != -244689)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (188256 - 284455 == -96198)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (13995 - 302404 != -288409)
											{
												continue;
											}
										}
										else
										{
											this.dhXc5FNEjRK.rotation = Quaternion.LookRotation(this.B47c5AFYXtk.nDirection);
											if (77103 - 454072 == -376968)
											{
												continue;
											}
											num = (float)0;
											if (147874 - 235564 == -87689)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (162773 - 321660 == -158886)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (115264 - 514964 != -399700)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (114716 - 529870 != -415154)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (4419 - 153512 != -149093)
										{
											continue;
										}
									}
								}
								this.B47c5AFYXtk.vMovement = vector;
								if (199220 - 313185 != -113964)
								{
									this.B47c5AFYXtk.moveSpeed = num;
									if (100314 - 591360 != -491045)
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

	// Token: 0x06004B2F RID: 19247 RVA: 0x0094CEF0 File Offset: 0x0094B0F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (64951 - 420345 != -355394)
		{
		}
		for (;;)
		{
			if (!this.B47c5AFYXtk.isMine)
			{
				if (266218 - 420639 == -154421)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (267263 - 236130 == 31133)
				{
					Vector3 vector = a - this.transform.position;
					if (145239 - 62568 != 82672)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (125337 - 341185 == -215848)
						{
							CharacterControl characterControl = null;
							if (106053 - 345149 != -239095)
							{
								if (147345 - 511227 == -363882)
								{
									if (gameObject)
									{
										if (2568 - 371508 == -368939)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (15106 - 318441 != -303335)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (275846 - 466307 == -190460)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (48850 - 524308 != -475458)
										{
											continue;
										}
									}
									if (!(this.B47c5AFYXtk.actionState == "standby"))
									{
										if (95512 - 6042 != 89470)
										{
											continue;
										}
										if (!(this.B47c5AFYXtk.actionState == "run"))
										{
											break;
										}
										if (269842 - 448377 == -178534)
										{
											continue;
										}
									}
									if (this.B47c5AFYXtk.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (157731 - 296082 != -138350)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (256536 - 361055 == -104519)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (103073 - 464246 != -361172)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (93965 - 380489 != -286523)
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

	// Token: 0x06004B30 RID: 19248 RVA: 0x0094D1E8 File Offset: 0x0094B3E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (266190 - 403671 != -137481)
		{
		}
		for (;;)
		{
			if (!this.B47c5AFYXtk.isMine)
			{
				if (288615 - 87769 == 200846)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (248148 - 233336 != 14813)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (71615 - 545277 == -473662)
					{
						Vector3 normalized = vector.normalized;
						if (18967 - 468828 == -449861)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (198448 - 464014 != -265565)
							{
								CharacterControl characterControl = null;
								if (245380 - 461668 != -216287)
								{
									if (74787 - 487497 == -412710)
									{
										if (gameObject)
										{
											if (38518 - 344459 != -305941)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (266351 - 114069 != 152282)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (248774 - 294117 == -45342)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (108596 - 463436 == -354839)
											{
												continue;
											}
										}
										if (!(this.B47c5AFYXtk.actionState == "standby"))
										{
											if (53550 - 102173 == -48622)
											{
												continue;
											}
											if (!(this.B47c5AFYXtk.actionState == "run"))
											{
												break;
											}
											if (223343 - 3859 == 219485)
											{
												continue;
											}
										}
										if (this.B47c5AFYXtk.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (232555 - 471125 == -238570)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
											if (12036 - 208422 == -196386)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (139930 - 205946 == -66016)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, normalized, 0);
													if (262015 - 550502 != -288486)
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

	// Token: 0x06004B31 RID: 19249 RVA: 0x0094D508 File Offset: 0x0094B708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004B32 RID: 19250 RVA: 0x0094D50C File Offset: 0x0094B70C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Mouse.$RPC_nAttack$32892(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004B33 RID: 19251 RVA: 0x0094D51C File Offset: 0x0094B71C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
		}
	}

	// Token: 0x06004B34 RID: 19252 RVA: 0x0094D544 File Offset: 0x0094B744
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Mouse.$RPC_cAttack$32907(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004B35 RID: 19253 RVA: 0x0094D554 File Offset: 0x0094B754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.cAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
		}
	}

	// Token: 0x06004B36 RID: 19254 RVA: 0x0094D57C File Offset: 0x0094B77C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Mouse.$RPC_ko$32923(nArray, this).GetEnumerator();
	}

	// Token: 0x06004B37 RID: 19255 RVA: 0x0094D58C File Offset: 0x0094B78C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Mouse.$RPC_dead$32930(nArray, this).GetEnumerator();
	}

	// Token: 0x06004B38 RID: 19256 RVA: 0x0094D59C File Offset: 0x0094B79C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004B39 RID: 19257 RVA: 0x0094D5A0 File Offset: 0x0094B7A0
	internal static bool ey1WdV5qsVTCNEXBX5UC()
	{
		return true;
	}

	// Token: 0x06004B3A RID: 19258 RVA: 0x0094D5A4 File Offset: 0x0094B7A4
	internal static bool L4CujC5q9TscgIvrnu8v()
	{
		return false;
	}

	// Token: 0x040055BA RID: 21946
	private Transform dhXc5FNEjRK;

	// Token: 0x040055BB RID: 21947
	private CharacterControl B47c5AFYXtk;

	// Token: 0x040055BC RID: 21948
	public AudioClip awake_vc;

	// Token: 0x040055BD RID: 21949
	public GameObject nAttack_ring;

	// Token: 0x040055BE RID: 21950
	public AudioClip nAttack_vc;

	// Token: 0x040055BF RID: 21951
	public GameObject nAttack_hit;

	// Token: 0x040055C0 RID: 21952
	public GameObject cAttack_fire;

	// Token: 0x040055C1 RID: 21953
	public AudioClip cAttack1_vc;

	// Token: 0x040055C2 RID: 21954
	public AudioClip cAttack2_vc;

	// Token: 0x040055C3 RID: 21955
	public GameObject cAttack_hit;

	// Token: 0x02000D13 RID: 3347
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32892 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004B3B RID: 19259 RVA: 0x0094D5A8 File Offset: 0x0094B7A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32892(Vector3 mPos, Vector3 tDir, Mouse self_)
		{
			if (183150 - 513478 != -330328)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (147668 - 407051 != -259382)
				{
					base..ctor();
					if (210132 - 506833 == -296701)
					{
						this.$mPos$32904 = mPos;
						if (2041 - 118188 != -116146)
						{
							this.$tDir$32905 = tDir;
							if (199574 - 213387 != -13812)
							{
								this.$self_$32906 = self_;
								if (204743 - 243954 != -39210)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x0094D684 File Offset: 0x0094B884
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mouse.$RPC_nAttack$32892.$(this.$mPos$32904, this.$tDir$32905, this.$self_$32906);
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x0094D6A0 File Offset: 0x0094B8A0
		internal static bool QMqZJS5q1iI4yDSoaALm()
		{
			return true;
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x0094D6A4 File Offset: 0x0094B8A4
		internal static bool HBudLk5q4W4IcKYLDESm()
		{
			return false;
		}

		// Token: 0x040055C4 RID: 21956
		internal Vector3 $mPos$32904;

		// Token: 0x040055C5 RID: 21957
		internal Vector3 $tDir$32905;

		// Token: 0x040055C6 RID: 21958
		internal Mouse $self_$32906;

		// Token: 0x02000D14 RID: 3348
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004B3F RID: 19263 RVA: 0x0094D6A8 File Offset: 0x0094B8A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Mouse self_)
			{
				if (289557 - 140503 != 149054)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (101609 - 47970 == 53639)
					{
						base..ctor();
						if (47674 - 508032 == -460358)
						{
							this.$mPos$32901 = mPos;
							if (9186 - 214682 != -205495)
							{
								this.$tDir$32902 = tDir;
								if (59123 - 307590 == -248467)
								{
									this.$self_$32903 = self_;
									if (210686 - 66714 != 143973)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004B40 RID: 19264 RVA: 0x0094D784 File Offset: 0x0094B984
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284609 - 43470 != 241139)
				{
				}
				for (;;)
				{
					IL_854:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_121E;
					case 2:
						if (this.$self_$32903.B47c5AFYXtk.actionState != "attack")
						{
							goto IL_47A;
						}
						if (20171 - 545134 != -524963)
						{
							continue;
						}
						if (this.$self_$32903.B47c5AFYXtk.myCommand != "nAttack")
						{
							if (14679 - 396233 != -381553)
							{
								goto Block_75;
							}
							continue;
						}
						else
						{
							this.$self_$32903.B47c5AFYXtk.moveSpeed = (float)3;
							if (211166 - 334079 != -122913)
							{
								continue;
							}
							goto IL_3BD;
						}
						break;
					case 3:
						if (this.$self_$32903.B47c5AFYXtk.actionState != "attack")
						{
							goto IL_E87;
						}
						if (261476 - 538249 == -276772)
						{
							continue;
						}
						if (this.$self_$32903.B47c5AFYXtk.myCommand != "nAttack")
						{
							if (72804 - 530487 != -457682)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$self_$32903.B47c5AFYXtk.moveSpeed = (float)5;
							if (65448 - 25147 == 40302)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_BB2;
							}
							if (281956 - 31903 == 250054)
							{
								continue;
							}
							if (this.$self_$32903.nAttack_vc)
							{
								if (177589 - 422407 != -244818)
								{
									continue;
								}
								this.$self_$32903.audio.PlayOneShot(this.$self_$32903.nAttack_vc);
								if (288198 - 137130 != 151069)
								{
									goto Block_87;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find nAttack voice");
								if (51466 - 412602 != -361135)
								{
									goto Block_79;
								}
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$32903.B47c5AFYXtk.actionState != "attack")
						{
							goto IL_731;
						}
						if (130821 - 68778 != 62043)
						{
							continue;
						}
						if (this.$self_$32903.B47c5AFYXtk.myCommand != "nAttack")
						{
							if (40035 - 223570 != -183535)
							{
								continue;
							}
							goto IL_731;
						}
						else
						{
							this.$self_$32903.B47c5AFYXtk.moveSpeed = (float)7;
							if (165495 - 527589 != -362094)
							{
								continue;
							}
							goto IL_A78;
						}
						break;
					case 5:
						if (this.$self_$32903.B47c5AFYXtk.actionState != "attack")
						{
							goto IL_CA9;
						}
						if (197356 - 553189 != -355833)
						{
							continue;
						}
						if (this.$self_$32903.B47c5AFYXtk.myCommand != "nAttack")
						{
							if (297693 - 71361 != 226332)
							{
								continue;
							}
							goto IL_CA9;
						}
						else
						{
							this.$self_$32903.B47c5AFYXtk.moveSpeed = (float)0;
							if (51215 - 350645 != -299430)
							{
								continue;
							}
							this.$hitLayer$32894 = 130816 - (1 << this.$self_$32903.gameObject.layer);
							if (21856 - 359188 == -337331)
							{
								continue;
							}
							this.$hitList$32895 = null;
							if (210878 - 350896 != -140018)
							{
								continue;
							}
							this.$hitPos$32896 = default(Vector3);
							if (19842 - 138246 == -118403)
							{
								continue;
							}
							if (!this.$self_$32903.B47c5AFYXtk.isMine)
							{
								goto IL_D67;
							}
							if (127557 - 23187 == 104371)
							{
								continue;
							}
							this.$hitList$32895 = Damage.FindAreaTarget(this.$self_$32903.transform.position + this.$self_$32903.transform.forward, (float)2, (float)3, this.$hitLayer$32894);
							if (240329 - 249006 != -8677)
							{
								continue;
							}
							this.$$iterator$10794$32898 = UnityRuntimeServices.GetEnumerator(this.$hitList$32895);
							if (157694 - 558595 == -400900)
							{
								continue;
							}
							while (this.$$iterator$10794$32898.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10794$32898.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$32897 = (GameObject)obj2;
								if (182493 - 364740 == -182246)
								{
									goto IL_854;
								}
								if (this.$self_$32903.B47c5AFYXtk.hit(1, this.$hitObject$32897, this.$self_$32903.B47c5AFYXtk.atk + this.$self_$32903.B47c5AFYXtk.talAdjust(20), 1, 0, this.$self_$32903.transform.forward) != 0)
								{
									if (123750 - 78132 != 45618)
									{
										goto IL_854;
									}
									this.$hitPos$32896 = this.$hitObject$32897.collider.ClosestPointOnBounds(this.$self_$32903.transform.position + 1.5f * Vector3.up);
									if (290082 - 189734 == 100349)
									{
										goto IL_854;
									}
									UnityRuntimeServices.Update(this.$$iterator$10794$32898, this.$hitObject$32897);
									if (30186 - 386826 != -356640)
									{
										goto IL_854;
									}
									this.$self_$32903.RPC_nAttack_hit(this.$hitPos$32896, this.$self_$32903.transform.forward, 0);
									if (48703 - 82113 == -33409)
									{
										goto IL_854;
									}
									this.$self_$32903.ActionEvent("RPC_nAttack_hit", this.$hitPos$32896, this.$self_$32903.transform.forward, 0);
									if (29131 - 175459 != -146328)
									{
										goto IL_854;
									}
								}
							}
							if (20712 - 504200 != -483487)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					case 6:
						if (this.$self_$32903.B47c5AFYXtk.actionState != "attack")
						{
							goto IL_99;
						}
						if (139187 - 7157 == 132031)
						{
							continue;
						}
						if (this.$self_$32903.B47c5AFYXtk.myCommand != "nAttack")
						{
							if (272915 - 415550 != -142635)
							{
								continue;
							}
							goto IL_99;
						}
						else
						{
							this.$self_$32903.B47c5AFYXtk.moveSpeed = (float)4;
							if (198415 - 211070 != -12655)
							{
								continue;
							}
							goto IL_99D;
						}
						break;
					case 7:
						if (this.$self_$32903.B47c5AFYXtk.actionState != "attack")
						{
							goto IL_F40;
						}
						if (207266 - 367962 != -160696)
						{
							continue;
						}
						if (this.$self_$32903.B47c5AFYXtk.myCommand != "nAttack")
						{
							if (192992 - 534389 != -341397)
							{
								continue;
							}
							goto IL_F40;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_FA5;
							}
							if (67830 - 533488 != -465658)
							{
								continue;
							}
							if (this.$self_$32903.nAttack_vc)
							{
								if (210607 - 312342 == -101734)
								{
									continue;
								}
								this.$self_$32903.audio.PlayOneShot(this.$self_$32903.nAttack_vc);
								if (59619 - 145575 != -85956)
								{
									continue;
								}
								goto IL_35B;
							}
							else
							{
								Debug.LogError("Cannot find nAttack voice");
								if (201960 - 371262 != -169302)
								{
									continue;
								}
								goto IL_FA5;
							}
						}
						break;
					case 8:
						if (this.$self_$32903.B47c5AFYXtk.actionState != "attack")
						{
							goto IL_588;
						}
						if (281473 - 537608 == -256134)
						{
							continue;
						}
						if (this.$self_$32903.B47c5AFYXtk.myCommand != "nAttack")
						{
							if (195995 - 488760 != -292764)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$self_$32903.B47c5AFYXtk.moveSpeed = (float)0;
							if (21786 - 175313 == -153526)
							{
								continue;
							}
							if (!this.$self_$32903.B47c5AFYXtk.isMine)
							{
								goto IL_49;
							}
							if (59301 - 362328 != -303027)
							{
								continue;
							}
							this.$hitList$32895 = Damage.FindAreaTarget(this.$self_$32903.transform.position + this.$self_$32903.transform.forward, (float)3, (float)3, this.$hitLayer$32894);
							if (256321 - 143458 != 112863)
							{
								continue;
							}
							this.$$iterator$10795$32900 = UnityRuntimeServices.GetEnumerator(this.$hitList$32895);
							if (96741 - 211519 == -114777)
							{
								continue;
							}
							while (this.$$iterator$10795$32900.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10795$32900.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$32899 = (GameObject)obj4;
								if (80540 - 286526 != -205986)
								{
									goto IL_854;
								}
								if (this.$self_$32903.B47c5AFYXtk.hit(2, this.$hitObject$32899, this.$self_$32903.B47c5AFYXtk.atk + this.$self_$32903.B47c5AFYXtk.talAdjust(30), 1, 0, this.$self_$32903.transform.forward) != 0)
								{
									if (280775 - 285446 != -4671)
									{
										goto IL_854;
									}
									this.$hitPos$32896 = this.$hitObject$32899.collider.ClosestPointOnBounds(this.$self_$32903.transform.position + 1.5f * Vector3.up);
									if (53597 - 1438 == 52160)
									{
										goto IL_854;
									}
									UnityRuntimeServices.Update(this.$$iterator$10795$32900, this.$hitObject$32899);
									if (23296 - 512527 == -489230)
									{
										goto IL_854;
									}
									this.$self_$32903.RPC_nAttack_hit(this.$hitPos$32896, this.$self_$32903.transform.forward, 0);
									if (198323 - 420629 == -222305)
									{
										goto IL_854;
									}
									this.$self_$32903.ActionEvent("RPC_nAttack_hit", this.$hitPos$32896, this.$self_$32903.transform.forward, 0);
									if (255987 - 341914 == -85926)
									{
										goto IL_854;
									}
								}
							}
							if (28423 - 170267 != -141844)
							{
								continue;
							}
							goto IL_49;
						}
						break;
					case 9:
						if (this.$self_$32903.B47c5AFYXtk.actionState == "attack")
						{
							if (59578 - 78734 != -19156)
							{
								continue;
							}
							if (this.$self_$32903.B47c5AFYXtk.myCommand == "nAttack")
							{
								if (89330 - 464792 == -375461)
								{
									continue;
								}
								this.$self_$32903.B47c5AFYXtk.actionState = "standby";
								if (237161 - 199546 == 37616)
								{
									continue;
								}
								this.$self_$32903.B47c5AFYXtk.actionTime = Time.time;
								if (117784 - 402750 != -284966)
								{
									continue;
								}
								this.$self_$32903.B47c5AFYXtk.myCommand = "none";
								if (116702 - 51319 != 65383)
								{
									continue;
								}
								if (!this.$self_$32903.B47c5AFYXtk.isMine)
								{
									if (151410 - 179846 == -28435)
									{
										continue;
									}
									this.$self_$32903.B47c5AFYXtk.nPosition = this.$self_$32903.transform.position;
									if (104179 - 284369 == -180189)
									{
										continue;
									}
									this.$self_$32903.B47c5AFYXtk.oPosition = this.$self_$32903.transform.position;
									if (236202 - 380492 != -144290)
									{
										continue;
									}
									this.$self_$32903.B47c5AFYXtk.nDirection = this.$self_$32903.transform.forward;
									if (54437 - 374368 == -319930)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (159039 - 22160 != 136879)
						{
							continue;
						}
						goto IL_121E;
					default:
						if (151841 - 369950 == -218108)
						{
							continue;
						}
						break;
					}
					this.$self_$32903.B47c5AFYXtk.actionState = "attack";
					if (155946 - 355563 == -199617)
					{
						this.$self_$32903.B47c5AFYXtk.actionTime = Time.time;
						if (12567 - 54408 == -41841)
						{
							this.$self_$32903.B47c5AFYXtk.myCommand = "nAttack";
							if (238525 - 24040 != 214486)
							{
								this.$self_$32903.B47c5AFYXtk.addTimeOut("nAttack", (float)2);
								if (21821 - 332632 == -310811)
								{
									this.$self_$32903.dhXc5FNEjRK.position = this.$mPos$32901;
									if (251740 - 143514 == 108226)
									{
										this.$self_$32903.dhXc5FNEjRK.LookAt(this.$mPos$32901 + global::Math.vFlat(this.$tDir$32902));
										if (148674 - 88363 == 60311)
										{
											this.$self_$32903.animation.CrossFade("nAttack");
											if (267866 - 245087 == 22779)
											{
												this.$self_$32903.animation.wrapMode = WrapMode.Once;
												if (46936 - 261537 == -214601)
												{
													this.$self_$32903.B47c5AFYXtk.vMovement = this.$self_$32903.transform.forward;
													if (22897 - 188792 == -165895)
													{
														this.$self_$32903.B47c5AFYXtk.moveSpeed = (float)0;
														if (229379 - 304268 == -74889)
														{
															if (Game.mGameCode == 916)
															{
																if (73619 - 57874 != 15745)
																{
																	continue;
																}
																if (UnityEngine.Random.Range(0, 100) < 30)
																{
																	if (141149 - 496880 == -355730)
																	{
																		continue;
																	}
																	this.$m$32893 = Language.getMessage("M916_CityUnderSiege", UnityEngine.Random.Range(11, 20));
																	if (111100 - 420590 == -309489)
																	{
																		continue;
																	}
																	if (this.$m$32893 != string.Empty)
																	{
																		if (69177 - 50487 == 18691)
																		{
																			continue;
																		}
																		Chat.SubmitChat("Abbete", "Abbete: " + this.$m$32893, eChatType.npc, eChatMode.system);
																		if (9656 - 268764 == -259107)
																		{
																			continue;
																		}
																		this.$self_$32903.B47c5AFYXtk.doChatBubble(this.$m$32893);
																		if (133873 - 340056 == -206182)
																		{
																			continue;
																		}
																	}
																}
															}
															if (this.$self_$32903.nAttack_ring)
															{
																if (32087 - 300186 == -268099)
																{
																	this.$self_$32903.B47c5AFYXtk.createEffect(this.$self_$32903.nAttack_ring, this.$self_$32903.transform.position, this.$self_$32903.transform.rotation);
																	if (68187 - 107420 == -39233)
																	{
																		goto IL_AC7;
																	}
																}
															}
															else
															{
																Debug.Log("Missing nAttack_ring effect");
																if (44072 - 229938 != -185865)
																{
																	goto Block_70;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_49:
				return this.Yield(9, new WaitForSeconds(0.1f));
				IL_99:
				goto IL_121E;
				Block_13:
				goto IL_D67;
				IL_35B:
				goto IL_FA5;
				Block_27:
				goto IL_E87;
				IL_3BD:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_32:
				IL_47A:
				IL_588:
				IL_731:
				goto IL_121E;
				IL_99D:
				return this.Yield(7, new WaitForSeconds(0.1f));
				IL_A78:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_AC7:
				Block_70:
				goto IL_10B7;
				Block_75:
				goto IL_47A;
				IL_BB2:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_79:
				goto IL_BB2;
				IL_CA9:
				goto IL_121E;
				IL_D67:
				return this.Yield(6, new WaitForSeconds(0.1f));
				Block_87:
				goto IL_BB2;
				IL_E87:
				IL_F40:
				goto IL_121E;
				IL_FA5:
				return this.Yield(8, new WaitForSeconds(0.2f));
				IL_10B7:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_121E:
				return false;
			}

			// Token: 0x06004B41 RID: 19265 RVA: 0x0094E9C4 File Offset: 0x0094CBC4
			internal static bool VXPqVS5qz6jPNo3i0M0E()
			{
				return true;
			}

			// Token: 0x06004B42 RID: 19266 RVA: 0x0094E9C8 File Offset: 0x0094CBC8
			internal static bool iOvWVv57aBfvce8bVUcF()
			{
				return false;
			}

			// Token: 0x040055C7 RID: 21959
			internal string $m$32893;

			// Token: 0x040055C8 RID: 21960
			internal int $hitLayer$32894;

			// Token: 0x040055C9 RID: 21961
			internal UnityScript.Lang.Array $hitList$32895;

			// Token: 0x040055CA RID: 21962
			internal Vector3 $hitPos$32896;

			// Token: 0x040055CB RID: 21963
			internal GameObject $hitObject$32897;

			// Token: 0x040055CC RID: 21964
			internal IEnumerator $$iterator$10794$32898;

			// Token: 0x040055CD RID: 21965
			internal GameObject $hitObject$32899;

			// Token: 0x040055CE RID: 21966
			internal IEnumerator $$iterator$10795$32900;

			// Token: 0x040055CF RID: 21967
			internal Vector3 $mPos$32901;

			// Token: 0x040055D0 RID: 21968
			internal Vector3 $tDir$32902;

			// Token: 0x040055D1 RID: 21969
			internal Mouse $self_$32903;
		}
	}

	// Token: 0x02000D15 RID: 3349
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$32907 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004B43 RID: 19267 RVA: 0x0094E9CC File Offset: 0x0094CBCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$32907(Vector3 mPos, Vector3 tDir, int tID, Mouse self_)
		{
			if (117552 - 352726 != -235174)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (95998 - 172120 != -76121)
				{
					base..ctor();
					if (158493 - 334531 != -176037)
					{
						this.$mPos$32919 = mPos;
						if (175747 - 545072 != -369324)
						{
							this.$tDir$32920 = tDir;
							if (183029 - 481009 == -297980)
							{
								this.$tID$32921 = tID;
								if (175696 - 267368 == -91672)
								{
									this.$self_$32922 = self_;
									if (269049 - 61819 != 207231)
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

		// Token: 0x06004B44 RID: 19268 RVA: 0x0094EACC File Offset: 0x0094CCCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mouse.$RPC_cAttack$32907.$(this.$mPos$32919, this.$tDir$32920, this.$tID$32921, this.$self_$32922);
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x0094EAEC File Offset: 0x0094CCEC
		internal static bool lMAhVm575nkjyy6vtRTg()
		{
			return true;
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x0094EAF0 File Offset: 0x0094CCF0
		internal static bool KfnHSV57pB4wKtvSJuMV()
		{
			return false;
		}

		// Token: 0x040055D2 RID: 21970
		internal Vector3 $mPos$32919;

		// Token: 0x040055D3 RID: 21971
		internal Vector3 $tDir$32920;

		// Token: 0x040055D4 RID: 21972
		internal int $tID$32921;

		// Token: 0x040055D5 RID: 21973
		internal Mouse $self_$32922;

		// Token: 0x02000D16 RID: 3350
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004B47 RID: 19271 RVA: 0x0094EAF4 File Offset: 0x0094CCF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Mouse self_)
			{
				if (199811 - 247189 != -47377)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (45299 - 317413 != -272113)
					{
						base..ctor();
						if (130632 - 280728 != -150095)
						{
							this.$mPos$32915 = mPos;
							if (255571 - 291333 == -35762)
							{
								this.$tDir$32916 = tDir;
								if (22187 - 290138 != -267950)
								{
									this.$tID$32917 = tID;
									if (152986 - 544030 != -391043)
									{
										this.$self_$32918 = self_;
										if (72148 - 516216 == -444068)
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

			// Token: 0x06004B48 RID: 19272 RVA: 0x0094EBF4 File Offset: 0x0094CDF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (48297 - 354811 != -306514)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_ACE;
					case 2:
						if (this.$self_$32918.B47c5AFYXtk.actionState != "attack")
						{
							goto IL_8E4;
						}
						if (236942 - 179717 == 57226)
						{
							continue;
						}
						if (this.$self_$32918.B47c5AFYXtk.myCommand != "cAttack")
						{
							if (253875 - 346914 != -93038)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							this.$firePos$32908 = this.$mPos$32915 + 0.8f * Vector3.up;
							if (171922 - 197439 != -25517)
							{
								continue;
							}
							this.$fireDir$32909 = this.$tDir$32916 - 0.8f * Vector3.up;
							if (243884 - 536777 != -292893)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$32917];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$32910 = (GameObject)obj2;
							if (128207 - 206107 == -77899)
							{
								continue;
							}
							if (this.$tObject$32910)
							{
								if (42634 - 270226 != -227592)
								{
									continue;
								}
								this.$fireDir$32909 = this.$tObject$32910.collider.bounds.center - this.$mPos$32915 - 0.8f * Vector3.up;
								if (140238 - 223734 != -83496)
								{
									continue;
								}
							}
							this.$fireRot$32911 = Quaternion.FromToRotation(Vector3.forward, this.$fireDir$32909);
							if (292170 - 496580 == -204409)
							{
								continue;
							}
							if (this.$self_$32918.cAttack_fire)
							{
								if (226370 - 426298 == -199927)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$32918.cAttack_fire, this.$firePos$32908, this.$fireRot$32911);
								if (208362 - 100222 != 108140)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing cAttack_fire effect");
								if (136827 - 408129 != -271302)
								{
									continue;
								}
							}
							if (!this.$self_$32918.B47c5AFYXtk.isMine)
							{
								goto IL_20A;
							}
							if (169986 - 580531 != -410545)
							{
								continue;
							}
							this.$hitLayer$32912 = ~((1 << this.$self_$32918.gameObject.layer) + 2 + 4);
							if (296723 - 65822 == 230902)
							{
								continue;
							}
							this.$hit$32913 = default(RaycastHit);
							if (23563 - 170138 == -146574)
							{
								continue;
							}
							this.$hitObject$32914 = null;
							if (99494 - 367841 != -268347)
							{
								continue;
							}
							if (!Physics.Raycast(this.$firePos$32908, this.$fireDir$32909, out this.$hit$32913, (float)20, this.$hitLayer$32912))
							{
								goto IL_20A;
							}
							if (269136 - 315067 == -45930)
							{
								continue;
							}
							this.$self_$32918.RPC_cAttack_hit(this.$hit$32913.point, this.$self_$32918.dhXc5FNEjRK.forward, 0);
							if (266962 - 174159 != 92803)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (43177 - 414175 != -370998)
								{
									continue;
								}
								this.$self_$32918.ActionEvent("RPC_cAttack_hit", this.$hit$32913.point, this.$self_$32918.dhXc5FNEjRK.forward, 0);
								if (204869 - 174365 != 30504)
								{
									continue;
								}
							}
							this.$hitObject$32914 = this.$hit$32913.collider.gameObject;
							if (98370 - 258575 == -160204)
							{
								continue;
							}
							if (this.$self_$32918.B47c5AFYXtk.hit(11, this.$hitObject$32914, (int)(0.5f * (float)this.$self_$32918.B47c5AFYXtk.atk + (float)this.$self_$32918.B47c5AFYXtk.talAdjust(30)), 1, 0, this.$self_$32918.dhXc5FNEjRK.forward) == 0)
							{
								goto IL_20A;
							}
							if (210449 - 252592 == -42142)
							{
								continue;
							}
							this.$self_$32918.B47c5AFYXtk.sp = this.$self_$32918.B47c5AFYXtk.sp + 1;
							if (285127 - 550872 != -265745)
							{
								continue;
							}
							goto IL_20A;
						}
						break;
					case 3:
						if (this.$self_$32918.B47c5AFYXtk.actionState == "attack")
						{
							if (294262 - 263907 != 30355)
							{
								continue;
							}
							if (this.$self_$32918.B47c5AFYXtk.myCommand == "cAttack")
							{
								if (62249 - 63880 != -1631)
								{
									continue;
								}
								this.$self_$32918.B47c5AFYXtk.actionState = "standby";
								if (165957 - 180293 != -14336)
								{
									continue;
								}
								this.$self_$32918.B47c5AFYXtk.actionTime = Time.time;
								if (52275 - 184184 == -131908)
								{
									continue;
								}
								this.$self_$32918.B47c5AFYXtk.myCommand = "none";
								if (148944 - 332029 == -183084)
								{
									continue;
								}
								if (!this.$self_$32918.B47c5AFYXtk.isMine)
								{
									if (49038 - 363903 == -314864)
									{
										continue;
									}
									this.$self_$32918.B47c5AFYXtk.nPosition = this.$self_$32918.transform.position;
									if (224817 - 195443 == 29375)
									{
										continue;
									}
									this.$self_$32918.B47c5AFYXtk.oPosition = this.$self_$32918.transform.position;
									if (278482 - 345366 != -66884)
									{
										continue;
									}
									this.$self_$32918.B47c5AFYXtk.nDirection = this.$self_$32918.transform.forward;
									if (158715 - 266097 != -107382)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (168769 - 248057 != -79287)
						{
							goto Block_64;
						}
						continue;
					default:
						if (195044 - 140570 == 54475)
						{
							continue;
						}
						break;
					}
					this.$self_$32918.B47c5AFYXtk.actionState = "attack";
					if (188214 - 317464 == -129250)
					{
						this.$self_$32918.B47c5AFYXtk.actionTime = Time.time;
						if (31242 - 215426 != -184183)
						{
							this.$self_$32918.B47c5AFYXtk.myCommand = "cAttack";
							if (84140 - 47275 != 36866)
							{
								this.$self_$32918.B47c5AFYXtk.addTimeOut("cAttack", (float)4);
								if (44944 - 16101 != 28844)
								{
									this.$self_$32918.dhXc5FNEjRK.position = this.$mPos$32915;
									if (13969 - 598043 != -584073)
									{
										this.$self_$32918.dhXc5FNEjRK.LookAt(this.$mPos$32915 + global::Math.vFlat(this.$tDir$32916));
										if (85303 - 65954 != 19350)
										{
											this.$self_$32918.animation.CrossFade("cAttack");
											if (248448 - 473817 == -225369)
											{
												this.$self_$32918.animation.wrapMode = WrapMode.Once;
												if (177475 - 190099 == -12624)
												{
													this.$self_$32918.B47c5AFYXtk.vMovement = this.$self_$32918.transform.forward;
													if (86814 - 178864 == -92050)
													{
														this.$self_$32918.B47c5AFYXtk.moveSpeed = (float)0;
														if (289623 - 63836 == 225787)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																break;
															}
															if (296012 - 78128 == 217884)
															{
																if (UnityEngine.Random.Range(0, 2) == 1)
																{
																	if (73572 - 13157 == 60415)
																	{
																		if (this.$self_$32918.cAttack1_vc)
																		{
																			if (220242 - 460586 == -240344)
																			{
																				this.$self_$32918.audio.PlayOneShot(this.$self_$32918.cAttack1_vc);
																				if (116252 - 215642 != -99389)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find cAttack1 voice");
																			if (211172 - 175150 == 36022)
																			{
																				break;
																			}
																		}
																	}
																}
																else if (this.$self_$32918.cAttack2_vc)
																{
																	if (126933 - 151414 != -24480)
																	{
																		this.$self_$32918.audio.PlayOneShot(this.$self_$32918.cAttack2_vc);
																		if (7953 - 530089 == -522136)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find cAttack2 voice");
																	if (160262 - 457789 != -297526)
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
				goto IL_702;
				IL_20A:
				return this.Yield(3, new WaitForSeconds(0.4f));
				goto IL_81C;
				Block_39:
				goto IL_8E4;
				IL_702:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_81C:
				goto IL_702;
				IL_8E4:
				Block_64:
				IL_ACE:
				return false;
			}

			// Token: 0x06004B49 RID: 19273 RVA: 0x0094F6E4 File Offset: 0x0094D8E4
			internal static bool KwGMUf57VETSO8Z6b6Sd()
			{
				return true;
			}

			// Token: 0x06004B4A RID: 19274 RVA: 0x0094F6E8 File Offset: 0x0094D8E8
			internal static bool Sk7KaN57tcBfswVAT3pK()
			{
				return false;
			}

			// Token: 0x040055D6 RID: 21974
			internal Vector3 $firePos$32908;

			// Token: 0x040055D7 RID: 21975
			internal Vector3 $fireDir$32909;

			// Token: 0x040055D8 RID: 21976
			internal GameObject $tObject$32910;

			// Token: 0x040055D9 RID: 21977
			internal Quaternion $fireRot$32911;

			// Token: 0x040055DA RID: 21978
			internal int $hitLayer$32912;

			// Token: 0x040055DB RID: 21979
			internal RaycastHit $hit$32913;

			// Token: 0x040055DC RID: 21980
			internal GameObject $hitObject$32914;

			// Token: 0x040055DD RID: 21981
			internal Vector3 $mPos$32915;

			// Token: 0x040055DE RID: 21982
			internal Vector3 $tDir$32916;

			// Token: 0x040055DF RID: 21983
			internal int $tID$32917;

			// Token: 0x040055E0 RID: 21984
			internal Mouse $self_$32918;
		}
	}

	// Token: 0x02000D17 RID: 3351
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32923 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004B4B RID: 19275 RVA: 0x0094F6EC File Offset: 0x0094D8EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32923(UnityScript.Lang.Array nArray, Mouse self_)
		{
			if (20400 - 311962 != -291562)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (192582 - 566075 == -373493)
				{
					base..ctor();
					if (243282 - 506512 == -263230)
					{
						this.$nArray$32928 = nArray;
						if (181003 - 364333 != -183329)
						{
							this.$self_$32929 = self_;
							if (146486 - 159351 == -12865)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x0094F7A8 File Offset: 0x0094D9A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mouse.$RPC_ko$32923.$(this.$nArray$32928, this.$self_$32929);
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x0094F7BC File Offset: 0x0094D9BC
		internal static bool wmJxxy57NJEQGxP3O3vR()
		{
			return true;
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x0094F7C0 File Offset: 0x0094D9C0
		internal static bool iQqRb257YcFk8LLwxlWs()
		{
			return false;
		}

		// Token: 0x040055E1 RID: 21985
		internal UnityScript.Lang.Array $nArray$32928;

		// Token: 0x040055E2 RID: 21986
		internal Mouse $self_$32929;

		// Token: 0x02000D18 RID: 3352
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004B4F RID: 19279 RVA: 0x0094F7C4 File Offset: 0x0094D9C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Mouse self_)
			{
				if (257452 - 408252 != -150800)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109125 - 29470 != 79656)
					{
						base..ctor();
						if (92383 - 534661 != -442277)
						{
							this.$nArray$32926 = nArray;
							if (79481 - 376162 != -296680)
							{
								this.$self_$32927 = self_;
								if (142167 - 380632 == -238465)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004B50 RID: 19280 RVA: 0x0094F880 File Offset: 0x0094DA80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (64436 - 542403 != -477967)
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
						if (this.$self_$32927.B47c5AFYXtk.actionState != "ko")
						{
							if (201509 - 104330 != 97180)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$self_$32927.animation.Play("getUp");
							if (166999 - 314723 == -147723)
							{
								continue;
							}
							this.$self_$32927.animation.wrapMode = WrapMode.Once;
							if (269058 - 240822 != 28236)
							{
								continue;
							}
							goto IL_171;
						}
						break;
					case 3:
						if (this.$self_$32927.B47c5AFYXtk.actionState != "ko")
						{
							if (95860 - 264662 != -168802)
							{
								continue;
							}
							goto IL_B0;
						}
						else
						{
							this.$self_$32927.B47c5AFYXtk.actionState = "standby";
							if (179875 - 408943 == -229067)
							{
								continue;
							}
							this.$self_$32927.B47c5AFYXtk.actionTime = Time.time;
							if (106580 - 117112 != -10532)
							{
								continue;
							}
							this.$self_$32927.B47c5AFYXtk.myCommand = "none";
							if (83477 - 326329 == -242851)
							{
								continue;
							}
							this.$self_$32927.B47c5AFYXtk.ko = this.$self_$32927.B47c5AFYXtk.mko;
							if (296343 - 234566 == 61778)
							{
								continue;
							}
							this.YieldDefault(1);
							if (98528 - 383054 != -284525)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					default:
						if (8371 - 493208 != -484837)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32927.B47c5AFYXtk.actionState == "ko")
					{
						break;
					}
					if (277745 - 483777 != -206031)
					{
						if (this.$self_$32927.B47c5AFYXtk.actionState == "dead")
						{
							if (281080 - 42051 != 239030)
							{
								break;
							}
						}
						else
						{
							this.$mPos$32924 = (Vector3)this.$nArray$32926[0];
							if (105605 - 257499 == -151894)
							{
								this.$mDir$32925 = (Vector3)this.$nArray$32926[1];
								if (113151 - 497388 == -384237)
								{
									this.$self_$32927.B47c5AFYXtk.ko = 0;
									if (259494 - 484903 != -225408)
									{
										this.$self_$32927.B47c5AFYXtk.actionState = "ko";
										if (2291 - 389519 == -387228)
										{
											this.$self_$32927.B47c5AFYXtk.actionTime = Time.time;
											if (84236 - 530938 != -446701)
											{
												this.$self_$32927.B47c5AFYXtk.myCommand = "none";
												if (24759 - 221835 == -197076)
												{
													this.$self_$32927.B47c5AFYXtk.vMovement = Vector3.zero;
													if (262170 - 478661 == -216491)
													{
														this.$self_$32927.B47c5AFYXtk.moveSpeed = (float)0;
														if (292221 - 540039 == -247818)
														{
															this.$self_$32927.animation.Play("ko");
															if (163358 - 349067 == -185709)
															{
																this.$self_$32927.animation.wrapMode = WrapMode.Once;
																if (55614 - 347087 != -291472)
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
				IL_B0:
				goto IL_48C;
				IL_171:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_19:
				goto IL_48C;
				Block_22:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_27:
				IL_48C:
				return false;
			}

			// Token: 0x06004B51 RID: 19281 RVA: 0x0094FD2C File Offset: 0x0094DF2C
			internal static bool UbBNll57ccyC9jP5Vnt7()
			{
				return true;
			}

			// Token: 0x06004B52 RID: 19282 RVA: 0x0094FD30 File Offset: 0x0094DF30
			internal static bool MUKYNW57U3s5Y6DeRxfM()
			{
				return false;
			}

			// Token: 0x040055E3 RID: 21987
			internal Vector3 $mPos$32924;

			// Token: 0x040055E4 RID: 21988
			internal Vector3 $mDir$32925;

			// Token: 0x040055E5 RID: 21989
			internal UnityScript.Lang.Array $nArray$32926;

			// Token: 0x040055E6 RID: 21990
			internal Mouse $self_$32927;
		}
	}

	// Token: 0x02000D19 RID: 3353
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32930 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004B53 RID: 19283 RVA: 0x0094FD34 File Offset: 0x0094DF34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32930(UnityScript.Lang.Array nArray, Mouse self_)
		{
			if (19878 - 62643 != -42765)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (171856 - 115879 == 55977)
				{
					base..ctor();
					if (71399 - 365186 == -293787)
					{
						this.$nArray$32935 = nArray;
						if (143103 - 106712 != 36392)
						{
							this.$self_$32936 = self_;
							if (156079 - 46136 != 109944)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x0094FDF0 File Offset: 0x0094DFF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mouse.$RPC_dead$32930.$(this.$nArray$32935, this.$self_$32936);
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x0094FE04 File Offset: 0x0094E004
		internal static bool CdyZ5u57TYGZyNaA6vFr()
		{
			return true;
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x0094FE08 File Offset: 0x0094E008
		internal static bool Y5jOEg573nnaC5Fiki5Q()
		{
			return false;
		}

		// Token: 0x040055E7 RID: 21991
		internal UnityScript.Lang.Array $nArray$32935;

		// Token: 0x040055E8 RID: 21992
		internal Mouse $self_$32936;

		// Token: 0x02000D1A RID: 3354
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004B57 RID: 19287 RVA: 0x0094FE0C File Offset: 0x0094E00C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Mouse self_)
			{
				if (271809 - 418614 != -146804)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (88458 - 81702 != 6757)
					{
						base..ctor();
						if (271271 - 268244 != 3028)
						{
							this.$nArray$32933 = nArray;
							if (248618 - 496457 == -247839)
							{
								this.$self_$32934 = self_;
								if (240126 - 87089 != 153038)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004B58 RID: 19288 RVA: 0x0094FEC8 File Offset: 0x0094E0C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (249347 - 331110 != -81763)
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
						if (this.$self_$32934.B47c5AFYXtk.actionState != "dead")
						{
							if (201406 - 90483 != 110923)
							{
								continue;
							}
							goto IL_49;
						}
						else
						{
							if (!this.$self_$32934.B47c5AFYXtk.isPlayer)
							{
								if (242084 - 323734 != -81650)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32934.gameObject);
								if (96840 - 143663 == -46822)
								{
									continue;
								}
							}
							else if (this.$self_$32934.B47c5AFYXtk.isMine)
							{
								if (120290 - 104345 != 15945)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32934.gameObject);
								if (75967 - 18835 == 57133)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (219125 - 228362 != -9236)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					default:
						if (240117 - 103608 != 136509)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32934.B47c5AFYXtk.actionState == "dead")
					{
						if (44493 - 512192 == -467699)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$32931 = (Vector3)this.$nArray$32933[0];
						if (75651 - 512445 != -436793)
						{
							this.$myDirection$32932 = (Vector3)this.$nArray$32933[1];
							if (217492 - 328046 != -110553)
							{
								this.$self_$32934.dhXc5FNEjRK.position = this.$myPosition$32931;
								if (212940 - 482267 != -269326)
								{
									this.$self_$32934.dhXc5FNEjRK.LookAt(this.$myPosition$32931 + this.$myDirection$32932);
									if (20588 - 19609 == 979)
									{
										this.$self_$32934.B47c5AFYXtk.hp = 0;
										if (171536 - 33048 == 138488)
										{
											this.$self_$32934.B47c5AFYXtk.actionState = "dead";
											if (199398 - 142624 == 56774)
											{
												this.$self_$32934.B47c5AFYXtk.actionTime = Time.time;
												if (80561 - 504542 == -423981)
												{
													this.$self_$32934.B47c5AFYXtk.myCommand = "none";
													if (257678 - 247220 != 10459)
													{
														this.$self_$32934.B47c5AFYXtk.vMovement = Vector3.zero;
														if (247307 - 67927 == 179380)
														{
															this.$self_$32934.B47c5AFYXtk.moveSpeed = (float)0;
															if (274282 - 266371 == 7911)
															{
																this.$self_$32934.animation.Rewind();
																if (221833 - 90939 == 130894)
																{
																	this.$self_$32934.animation.Play("ko");
																	if (191912 - 292664 != -100751)
																	{
																		this.$self_$32934.animation.wrapMode = WrapMode.Once;
																		if (195581 - 63515 != 132067)
																		{
																			goto Block_26;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_49:
				Block_5:
				goto IL_42F;
				Block_26:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06004B59 RID: 19289 RVA: 0x00950318 File Offset: 0x0094E518
			internal static bool ucWX7457X8AB7KCqt4UX()
			{
				return true;
			}

			// Token: 0x06004B5A RID: 19290 RVA: 0x0095031C File Offset: 0x0094E51C
			internal static bool A38OsO57Qsv7u5NR9t4e()
			{
				return false;
			}

			// Token: 0x040055E9 RID: 21993
			internal Vector3 $myPosition$32931;

			// Token: 0x040055EA RID: 21994
			internal Vector3 $myDirection$32932;

			// Token: 0x040055EB RID: 21995
			internal UnityScript.Lang.Array $nArray$32933;

			// Token: 0x040055EC RID: 21996
			internal Mouse $self_$32934;
		}
	}
}
