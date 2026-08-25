using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B0C RID: 2828
[Serializable]
public class SiegeBot : MonoBehaviour
{
	// Token: 0x06003E98 RID: 16024 RVA: 0x0080BBCC File Offset: 0x00809DCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SiegeBot()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003E99 RID: 16025 RVA: 0x0080BBDC File Offset: 0x00809DDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (264143 - 192468 != 71675)
		{
		}
		for (;;)
		{
			this.yBOyXAo2Qk = this.transform;
			if (211805 - 257652 != -45846)
			{
				if (this.audio)
				{
					if (180631 - 455336 != -274705)
					{
						continue;
					}
					this.yq0y2QjEoZ = this.audio;
					if (70358 - 439670 != -369312)
					{
						continue;
					}
				}
				this.L5UyOt4csu = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (147590 - 41066 != 106525)
				{
					this.L5UyOt4csu.actionState = "standby";
					if (61953 - 461111 != -399157)
					{
						this.L5UyOt4csu.actionTime = Time.time;
						if (109021 - 316790 == -207769)
						{
							this.L5UyOt4csu.myCommand = "none";
							if (11161 - 48635 == -37474)
							{
								this.L5UyOt4csu.hp = (this.L5UyOt4csu.mhp = 5000);
								if (60589 - 19954 == 40635)
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

	// Token: 0x06003E9A RID: 16026 RVA: 0x0080BD78 File Offset: 0x00809F78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.L5UyOt4csu.isMine = true;
		}
	}

	// Token: 0x06003E9B RID: 16027 RVA: 0x0080BD94 File Offset: 0x00809F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (74639 - 309186 != -234547)
		{
		}
		for (;;)
		{
			if (this.L5UyOt4csu.isControlled)
			{
				if (175781 - 75986 == 99796)
				{
					continue;
				}
				if (!(this.L5UyOt4csu.actionState == "standby"))
				{
					if (65868 - 195168 != -129300)
					{
						continue;
					}
					if (!(this.L5UyOt4csu.actionState == "run"))
					{
						goto IL_4B0;
					}
					if (924 - 340059 == -339134)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (8048 - 201609 != -193561)
				{
					continue;
				}
			}
			IL_4B0:
			if (this.L5UyOt4csu.hp <= 0)
			{
				if (147861 - 323292 == -175430)
				{
					continue;
				}
				if (this.L5UyOt4csu.actionState != "dead")
				{
					if (155106 - 368920 != -213814)
					{
						continue;
					}
					if (this.L5UyOt4csu.isMine)
					{
						if (77432 - 65112 != 12320)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.yBOyXAo2Qk.position,
							this.yBOyXAo2Qk.forward
						})));
						if (77261 - 357884 != -280623)
						{
							continue;
						}
						if (PhotonClient.IsInitialized())
						{
							if (199413 - 363410 != -163997)
							{
								continue;
							}
							this.L5UyOt4csu.DeadEvent();
							if (221415 - 155345 != 66070)
							{
								continue;
							}
						}
					}
					else
					{
						this.L5UyOt4csu.hp = 1;
						if (172898 - 397956 != -225058)
						{
							continue;
						}
					}
					goto IL_4A;
				}
			}
			if (this.L5UyOt4csu.hp > 0)
			{
				if (171506 - 192612 != -21106)
				{
					continue;
				}
				if (this.L5UyOt4csu.ko <= 0)
				{
					if (6052 - 168127 != -162075)
					{
						continue;
					}
					if (this.L5UyOt4csu.actionState != "ko")
					{
						if (251006 - 300802 == -49795)
						{
							continue;
						}
						if (this.L5UyOt4csu.actionState != "dead")
						{
							if (211171 - 550725 == -339553)
							{
								continue;
							}
							if (this.L5UyOt4csu.isMine)
							{
								if (64424 - 61970 != 2454)
								{
									continue;
								}
								this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
								{
									this.yBOyXAo2Qk.position,
									this.yBOyXAo2Qk.forward
								})));
								if (98042 - 398843 == -300800)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (15693 - 39688 == -23994)
									{
										continue;
									}
									this.L5UyOt4csu.KoEvent();
									if (196083 - 321991 != -125908)
									{
										continue;
									}
								}
							}
							else
							{
								this.L5UyOt4csu.ko = 1;
								if (97953 - 257771 != -159818)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_4A:
			if (!this.yq0y2QjEoZ)
			{
				break;
			}
			if (240058 - 112107 == 127951)
			{
				if (this.L5UyOt4csu.actionState == "run")
				{
					if (10040 - 18771 == -8731)
					{
						if (this.yq0y2QjEoZ.isPlaying)
						{
							break;
						}
						if (83024 - 463727 == -380703)
						{
							this.yq0y2QjEoZ.Play();
							if (215263 - 127540 == 87723)
							{
								break;
							}
						}
					}
				}
				else
				{
					if (!this.yq0y2QjEoZ.isPlaying)
					{
						break;
					}
					if (250171 - 552529 != -302357)
					{
						this.yq0y2QjEoZ.Stop();
						if (131431 - 264419 == -132988)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003E9C RID: 16028 RVA: 0x0080C290 File Offset: 0x0080A490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (169494 - 31520 != 137974)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (19529 - 350139 != -330609)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (259008 - 374302 != -115293 && 270146 - 43646 != 226501)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (255947 - 36612 == 219336)
						{
							continue;
						}
						v = 1;
						if (231671 - 214206 != 17465)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (38359 - 246863 != -208504)
						{
							continue;
						}
						v = -1;
						if (256837 - 85653 == 171185)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack")
					{
						if (170052 - 44946 != 125106)
						{
							continue;
						}
						v = 11;
						if (70393 - 172080 == -101686)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (46566 - 355275 == -308708)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (4328 - 451678 == -447350)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (178628 - 54405 == 124223)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (226443 - 97538 != 128906)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (244252 - 475541 == -231289)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (194977 - 63483 != 131495)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (287073 - 223545 == 63528)
										{
											Hashtable hashtable = new Hashtable();
											if (220601 - 323322 == -102721)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (234275 - 306118 == -71843)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (172002 - 15929 == 156073)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (290254 - 189581 != 100674)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (249592 - 199412 != 50181)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (227660 - 575490 != -347829)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (240680 - 91951 != 148730)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (128582 - 403710 == -275128)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (252577 - 263896 != -11318)
																			{
																				PhotonClient.SendEvent(this.L5UyOt4csu.ActorNr, 74, hashtable, true, true);
																				if (104087 - 479833 != -375745)
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

	// Token: 0x06003E9D RID: 16029 RVA: 0x0080C75C File Offset: 0x0080A95C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (293656 - 288687 != 4970)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (28372 - 194015 == -165643)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (268721 - 178880 != 89842)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (122966 - 574326 != -451359)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (268287 - 598016 != -329728)
						{
							int num3 = num;
							if (217956 - 517904 != -299947)
							{
								if (num3 == 1)
								{
									if (275192 - 434487 != -159294)
									{
										if (this.L5UyOt4csu.isMine)
										{
											break;
										}
										if (292047 - 427802 == -135755)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (25323 - 209544 != -184220)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (124355 - 373270 == -248915)
									{
										if (this.L5UyOt4csu.isMine)
										{
											break;
										}
										if (97805 - 502178 == -404373)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (131291 - 331180 != -199888)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (124102 - 223621 != -99518)
									{
										if (this.L5UyOt4csu.isMine)
										{
											break;
										}
										if (269243 - 432763 == -163520)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (123844 - 310569 == -186725)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (103062 - 178795 != -75732)
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

	// Token: 0x06003E9E RID: 16030 RVA: 0x0080CA6C File Offset: 0x0080AC6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (154495 - 477328 != -322832)
		{
		}
		for (;;)
		{
			float num = this.L5UyOt4csu.moveSpeed;
			if (283578 - 517107 != -233528)
			{
				float runSpeed = this.L5UyOt4csu.runSpeed;
				if (256790 - 487044 != -230253)
				{
					Vector3 a = default(Vector3);
					if (231264 - 56401 != 174864)
					{
						Vector3 vector = Vector3.zero;
						if (156909 - 314023 == -157114)
						{
							float num2 = (float)0;
							if (138001 - 513681 != -375679)
							{
								if (this.L5UyOt4csu.isMine)
								{
									if (282274 - 346232 != -63958)
									{
										continue;
									}
									if ((this.L5UyOt4csu.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (49634 - 86195 == -36560)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (163877 - 276814 == -112936)
										{
											continue;
										}
										a.y = (float)0;
										if (253033 - 526224 == -273190)
										{
											continue;
										}
										a = a.normalized;
										if (174219 - 84053 == 90167)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (80607 - 315875 != -235268)
										{
											continue;
										}
										vector = vector.normalized;
										if (123677 - 252971 == -129293)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (269024 - 459256 != -190232)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (166306 - 526645 != -360339)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (59238 - 557712 != -498474)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (239930 - 358923 != -118993)
														{
															continue;
														}
														this.L5UyOt4csu.actionState = "run";
														if (232695 - 539911 != -307216)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (92097 - 2437 == 89661)
														{
															continue;
														}
														this.yBOyXAo2Qk.rotation = Quaternion.LookRotation(vector);
														if (275984 - 42543 == 233442)
														{
															continue;
														}
														this.animation.Play("run");
														if (103680 - 448974 == -345293)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (257886 - 186853 != 71033)
														{
															continue;
														}
														goto IL_594;
													}
												}
											}
										}
										this.L5UyOt4csu.actionState = "standby";
										if (124858 - 130001 != -5143)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (285604 - 461418 != -175814)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (83745 - 36161 == 47585)
											{
												continue;
											}
											num = (float)0;
											if (144197 - 318891 == -174693)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (149048 - 241218 != -92170)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (237897 - 124936 != 112961)
										{
											continue;
										}
									}
									IL_594:;
								}
								else
								{
									vector = global::Math.vFlat(this.L5UyOt4csu.nPosition - this.yBOyXAo2Qk.position);
									if (161418 - 183804 == -22385)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (268176 - 358843 == -90666)
									{
										continue;
									}
									if (this.L5UyOt4csu.nSpeed != (float)0)
									{
										if (136136 - 190409 != -54273)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (274437 - 457188 == -182750)
											{
												continue;
											}
											this.yBOyXAo2Qk.position = this.L5UyOt4csu.nPosition;
											if (151593 - 48127 == 103467)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (69191 - 214020 == -144828)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (206272 - 493065 == -286792)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (68665 - 406634 == -337968)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.L5UyOt4csu.nSpeed, (float)10 * Time.deltaTime);
												if (258501 - 85767 != 172734)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.yBOyXAo2Qk.forward, vector) > 0.5f)
											{
												if (39259 - 172557 == -133297)
												{
													continue;
												}
												this.yBOyXAo2Qk.rotation = Quaternion.LookRotation(Vector3.Slerp(this.yBOyXAo2Qk.forward, vector, (float)10 * Time.deltaTime));
												if (11695 - 101623 != -89928)
												{
													continue;
												}
											}
											else
											{
												this.yBOyXAo2Qk.rotation = Quaternion.LookRotation(vector);
												if (48829 - 578023 != -529194)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (244466 - 410246 == -165779)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (42157 - 52456 != -10299)
											{
												continue;
											}
										}
										else if (Time.time > this.L5UyOt4csu.nSpeed + 0.3f)
										{
											if (179302 - 266864 != -87562)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (68904 - 396434 == -327529)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (164569 - 500269 == -335699)
												{
													continue;
												}
												num = (float)0;
												if (7204 - 591582 == -584377)
												{
													continue;
												}
											}
											this.yBOyXAo2Qk.rotation = Quaternion.LookRotation(this.L5UyOt4csu.nDirection);
											if (180016 - 414983 != -234967)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (230878 - 431197 == -200318)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (143419 - 373178 == -229758)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (120531 - 36949 != 83582)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (174667 - 90060 == 84608)
											{
												continue;
											}
											this.yBOyXAo2Qk.position = this.L5UyOt4csu.nPosition;
											if (117072 - 345372 == -228299)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (282091 - 385902 != -103811)
											{
												continue;
											}
											this.yBOyXAo2Qk.rotation = Quaternion.LookRotation(Vector3.Slerp(this.yBOyXAo2Qk.forward, vector, (float)10 * Time.deltaTime));
											if (239449 - 300838 != -61389)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (49532 - 156032 == -106499)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (83370 - 171831 == -88460)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (44129 - 152761 != -108632)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (272897 - 333594 != -60697)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (267977 - 579574 != -311597)
											{
												continue;
											}
										}
										else
										{
											this.yBOyXAo2Qk.rotation = Quaternion.LookRotation(this.L5UyOt4csu.nDirection);
											if (222690 - 147804 != 74886)
											{
												continue;
											}
											num = (float)0;
											if (238015 - 170881 != 67134)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (123759 - 290514 != -166755)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (190838 - 56045 == 134794)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (197525 - 451060 != -253535)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (190075 - 290550 != -100475)
										{
											continue;
										}
									}
								}
								this.L5UyOt4csu.vMovement = vector;
								if (42820 - 44326 != -1505)
								{
									this.L5UyOt4csu.moveSpeed = num;
									if (163571 - 591481 == -427910)
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

	// Token: 0x06003E9F RID: 16031 RVA: 0x0080D5D0 File Offset: 0x0080B7D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (239747 - 91419 != 148328)
		{
		}
		for (;;)
		{
			if (!this.L5UyOt4csu.isMine)
			{
				if (25609 - 272684 == -247075)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (196506 - 225787 != -29280)
				{
					Vector3 vector = a - this.yBOyXAo2Qk.position;
					if (170832 - 173512 == -2680)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (11199 - 408212 == -397013)
						{
							CharacterControl characterControl = null;
							if (125050 - 52292 == 72758)
							{
								if (1988 - 465429 == -463441)
								{
									if (gameObject)
									{
										if (96330 - 453689 != -357359)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (248166 - 69524 != 178642)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (49926 - 516495 == -466568)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (129052 - 339895 != -210843)
										{
											continue;
										}
									}
									if (!(this.L5UyOt4csu.actionState == "standby"))
									{
										if (15677 - 370208 != -354531)
										{
											continue;
										}
										if (!(this.L5UyOt4csu.actionState == "run"))
										{
											break;
										}
										if (168860 - 363542 == -194681)
										{
											continue;
										}
									}
									if (this.L5UyOt4csu.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (248899 - 311538 == -62639)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (85287 - 437566 == -352279)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (227136 - 418068 != -190931)
											{
												this.ActionEvent("RPC_nAttack", this.yBOyXAo2Qk.position, vector, 0);
												if (217402 - 554526 == -337124)
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

	// Token: 0x06003EA0 RID: 16032 RVA: 0x0080D8C8 File Offset: 0x0080BAC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (252409 - 229573 != 22836)
		{
		}
		for (;;)
		{
			if (!this.L5UyOt4csu.isMine)
			{
				if (232999 - 30027 == 202972)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (168942 - 480121 == -311179)
				{
					Vector3 vector = global::Math.vFlat(a - this.yBOyXAo2Qk.position);
					if (225537 - 70915 == 154622)
					{
						Vector3 normalized = vector.normalized;
						if (52536 - 164500 != -111963)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (151225 - 23201 != 128025)
							{
								CharacterControl characterControl = null;
								if (145785 - 378980 != -233194)
								{
									if (262314 - 357196 == -94882)
									{
										if (gameObject)
										{
											if (291082 - 368902 != -77820)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (181582 - 293078 == -111495)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (172130 - 343657 != -171527)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (223455 - 146249 != 77206)
											{
												continue;
											}
										}
										if (!(this.L5UyOt4csu.actionState == "standby"))
										{
											if (56916 - 587599 != -530683)
											{
												continue;
											}
											if (!(this.L5UyOt4csu.actionState == "run"))
											{
												break;
											}
											if (59885 - 336357 != -276472)
											{
												continue;
											}
										}
										if (this.L5UyOt4csu.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (37453 - 594737 == -557284)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
											if (121062 - 504088 != -383025)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (288695 - 535573 != -246877)
												{
													this.ActionEvent("RPC_cAttack", this.yBOyXAo2Qk.position, normalized, 0);
													if (55318 - 25711 == 29607)
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

	// Token: 0x06003EA1 RID: 16033 RVA: 0x0080DBE8 File Offset: 0x0080BDE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003EA2 RID: 16034 RVA: 0x0080DBEC File Offset: 0x0080BDEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SiegeBot.$RPC_nAttack$30878(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003EA3 RID: 16035 RVA: 0x0080DBFC File Offset: 0x0080BDFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (161973 - 260467 != -98493)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (283212 - 467817 != -184604)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (101440 - 452869 == -351429)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit effect");
				if (40599 - 24661 == 15938)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003EA4 RID: 16036 RVA: 0x0080DCB4 File Offset: 0x0080BEB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SiegeBot.$RPC_cAttack$30890(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003EA5 RID: 16037 RVA: 0x0080DCC4 File Offset: 0x0080BEC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new SiegeBot.$RPC_ko$30903(nArray, this).GetEnumerator();
	}

	// Token: 0x06003EA6 RID: 16038 RVA: 0x0080DCD4 File Offset: 0x0080BED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new SiegeBot.$RPC_dead$30910(nArray, this).GetEnumerator();
	}

	// Token: 0x06003EA7 RID: 16039 RVA: 0x0080DCE4 File Offset: 0x0080BEE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003EA8 RID: 16040 RVA: 0x0080DCE8 File Offset: 0x0080BEE8
	internal static bool iN3Lhg5mkRbrCQtZSOgp()
	{
		return true;
	}

	// Token: 0x06003EA9 RID: 16041 RVA: 0x0080DCEC File Offset: 0x0080BEEC
	internal static bool riU7505mGYcWTfJ7WOxN()
	{
		return false;
	}

	// Token: 0x04004BC0 RID: 19392
	private Transform yBOyXAo2Qk;

	// Token: 0x04004BC1 RID: 19393
	private CharacterControl L5UyOt4csu;

	// Token: 0x04004BC2 RID: 19394
	private AudioSource yq0y2QjEoZ;

	// Token: 0x04004BC3 RID: 19395
	public GameObject nAttack_ring;

	// Token: 0x04004BC4 RID: 19396
	public GameObject nAttack_hit;

	// Token: 0x04004BC5 RID: 19397
	public GameObject cAttack_ring;

	// Token: 0x04004BC6 RID: 19398
	public GameObject cAttack_fire;

	// Token: 0x04004BC7 RID: 19399
	public GameObject deadEffect;

	// Token: 0x02000B0D RID: 2829
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30878 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003EAA RID: 16042 RVA: 0x0080DCF0 File Offset: 0x0080BEF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30878(Vector3 mPos, Vector3 tDir, SiegeBot self_)
		{
			if (31230 - 559706 != -528476)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (129476 - 165201 != -35724)
				{
					base..ctor();
					if (122600 - 535963 == -413363)
					{
						this.$mPos$30887 = mPos;
						if (282901 - 253487 != 29415)
						{
							this.$tDir$30888 = tDir;
							if (28229 - 403593 == -375364)
							{
								this.$self_$30889 = self_;
								if (172516 - 144238 == 28278)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x0080DDCC File Offset: 0x0080BFCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SiegeBot.$RPC_nAttack$30878.$(this.$mPos$30887, this.$tDir$30888, this.$self_$30889);
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x0080DDE8 File Offset: 0x0080BFE8
		internal static bool mNbk695mHWWwXVHwQQvB()
		{
			return true;
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x0080DDEC File Offset: 0x0080BFEC
		internal static bool ThAClU5mWrHekW1yXwfM()
		{
			return false;
		}

		// Token: 0x04004BC8 RID: 19400
		internal Vector3 $mPos$30887;

		// Token: 0x04004BC9 RID: 19401
		internal Vector3 $tDir$30888;

		// Token: 0x04004BCA RID: 19402
		internal SiegeBot $self_$30889;

		// Token: 0x02000B0E RID: 2830
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003EAE RID: 16046 RVA: 0x0080DDF0 File Offset: 0x0080BFF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SiegeBot self_)
			{
				if (163472 - 373270 != -209798)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (176306 - 535082 == -358776)
					{
						base..ctor();
						if (194499 - 387118 != -192618)
						{
							this.$mPos$30884 = mPos;
							if (254522 - 436699 != -182176)
							{
								this.$tDir$30885 = tDir;
								if (142142 - 98530 != 43613)
								{
									this.$self_$30886 = self_;
									if (86526 - 250584 != -164057)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003EAF RID: 16047 RVA: 0x0080DECC File Offset: 0x0080C0CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (152458 - 439351 != -286893)
				{
				}
				for (;;)
				{
					IL_590:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8B6;
					case 2:
						if (this.$self_$30886.L5UyOt4csu.actionState != "attack")
						{
							goto IL_139;
						}
						if (234944 - 445705 == -210760)
						{
							continue;
						}
						if (this.$self_$30886.L5UyOt4csu.myCommand != "nAttack")
						{
							if (140675 - 199876 != -59200)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							this.$self_$30886.L5UyOt4csu.moveSpeed = (float)0;
							if (214457 - 356199 != -141742)
							{
								continue;
							}
							if (!this.$self_$30886.L5UyOt4csu.isMine)
							{
								goto IL_EA;
							}
							if (242342 - 264974 != -22632)
							{
								continue;
							}
							this.$hitLayer$30879 = 130816 - (1 << this.$self_$30886.gameObject.layer);
							if (281836 - 216867 == 64970)
							{
								continue;
							}
							this.$hitList$30880 = Damage.FindAreaTarget(this.$self_$30886.transform.position, (float)2, (float)3, this.$hitLayer$30879);
							if (259065 - 107776 == 151290)
							{
								continue;
							}
							this.$$iterator$10655$30883 = UnityRuntimeServices.GetEnumerator(this.$hitList$30880);
							if (216463 - 549548 == -333084)
							{
								continue;
							}
							while (this.$$iterator$10655$30883.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10655$30883.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30881 = (GameObject)obj2;
								if (116426 - 232534 == -116107)
								{
									goto IL_590;
								}
								if (this.$self_$30886.L5UyOt4csu.hit(1, this.$hitObject$30881, this.$self_$30886.L5UyOt4csu.atk, 3, 0, 0.5f * (this.$hitObject$30881.transform.position - this.$self_$30886.yBOyXAo2Qk.position).normalized) != 0)
								{
									if (69499 - 349596 == -280096)
									{
										goto IL_590;
									}
									this.$hitPos$30882 = this.$hitObject$30881.collider.ClosestPointOnBounds(this.$self_$30886.transform.position + (float)2 * Vector3.up);
									if (118037 - 104254 == 13784)
									{
										goto IL_590;
									}
									UnityRuntimeServices.Update(this.$$iterator$10655$30883, this.$hitObject$30881);
									if (143531 - 496002 != -352471)
									{
										goto IL_590;
									}
									this.$self_$30886.RPC_nAttack_hit(this.$hitPos$30882, this.$self_$30886.yBOyXAo2Qk.forward, 0);
									if (218394 - 52051 == 166344)
									{
										goto IL_590;
									}
									this.$self_$30886.ActionEvent("RPC_nAttack_hit", this.$hitPos$30882, this.$self_$30886.yBOyXAo2Qk.forward, 0);
									if (91600 - 66052 != 25548)
									{
										goto IL_590;
									}
									this.$self_$30886.L5UyOt4csu.sp = this.$self_$30886.L5UyOt4csu.sp + 1;
									if (231634 - 524152 != -292518)
									{
										goto IL_590;
									}
								}
							}
							if (140488 - 583513 != -443025)
							{
								continue;
							}
							goto IL_EA;
						}
						break;
					case 3:
						if (this.$self_$30886.L5UyOt4csu.actionState == "attack")
						{
							if (230043 - 377156 == -147112)
							{
								continue;
							}
							if (this.$self_$30886.L5UyOt4csu.myCommand == "nAttack")
							{
								if (61612 - 367275 != -305663)
								{
									continue;
								}
								this.$self_$30886.L5UyOt4csu.actionState = "standby";
								if (207317 - 73921 == 133397)
								{
									continue;
								}
								this.$self_$30886.L5UyOt4csu.actionTime = Time.time;
								if (184716 - 243402 == -58685)
								{
									continue;
								}
								this.$self_$30886.L5UyOt4csu.myCommand = "none";
								if (270830 - 311759 == -40928)
								{
									continue;
								}
								if (!this.$self_$30886.L5UyOt4csu.isMine)
								{
									if (4225 - 140035 == -135809)
									{
										continue;
									}
									this.$self_$30886.L5UyOt4csu.nPosition = this.$self_$30886.yBOyXAo2Qk.position;
									if (134023 - 393870 != -259847)
									{
										continue;
									}
									this.$self_$30886.L5UyOt4csu.oPosition = this.$self_$30886.yBOyXAo2Qk.position;
									if (64458 - 400392 == -335933)
									{
										continue;
									}
									this.$self_$30886.L5UyOt4csu.nDirection = this.$self_$30886.yBOyXAo2Qk.forward;
									if (131214 - 196621 == -65406)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (169696 - 142278 != 27419)
						{
							goto Block_24;
						}
						continue;
					default:
						if (24214 - 187713 == -163498)
						{
							continue;
						}
						break;
					}
					this.$self_$30886.L5UyOt4csu.actionState = "attack";
					if (111663 - 14845 != 96819)
					{
						this.$self_$30886.L5UyOt4csu.actionTime = Time.time;
						if (85041 - 220476 == -135435)
						{
							this.$self_$30886.L5UyOt4csu.myCommand = "nAttack";
							if (93542 - 326605 == -233063)
							{
								this.$self_$30886.L5UyOt4csu.addTimeOut("nAttack", (float)3);
								if (231453 - 71913 != 159541)
								{
									this.$self_$30886.transform.position = this.$mPos$30884;
									if (39543 - 550753 != -511209)
									{
										this.$self_$30886.transform.LookAt(this.$mPos$30884 + global::Math.vFlat(this.$tDir$30885));
										if (42629 - 577642 == -535013)
										{
											this.$self_$30886.animation.CrossFade("nAttack");
											if (158726 - 377003 == -218277)
											{
												this.$self_$30886.animation.wrapMode = WrapMode.Once;
												if (271557 - 562675 == -291118)
												{
													this.$self_$30886.L5UyOt4csu.vMovement = this.$self_$30886.yBOyXAo2Qk.forward;
													if (235585 - 588170 == -352585)
													{
														this.$self_$30886.L5UyOt4csu.moveSpeed = (float)-1;
														if (35652 - 347215 == -311563)
														{
															if (this.$self_$30886.nAttack_ring)
															{
																if (52738 - 204176 == -151438)
																{
																	this.$self_$30886.L5UyOt4csu.createEffect(this.$self_$30886.nAttack_ring, this.$self_$30886.yBOyXAo2Qk.position, this.$self_$30886.yBOyXAo2Qk.rotation);
																	if (101174 - 292920 == -191746)
																	{
																		goto IL_538;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_ring effect");
																if (130532 - 352187 == -221655)
																{
																	goto IL_766;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_EA:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_139:
				Block_20:
				Block_24:
				goto IL_8B6;
				IL_538:
				IL_766:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_8B6:
				return false;
			}

			// Token: 0x06003EB0 RID: 16048 RVA: 0x0080E7A4 File Offset: 0x0080C9A4
			internal static bool lyBTde5mAB0hqT1E7CQo()
			{
				return true;
			}

			// Token: 0x06003EB1 RID: 16049 RVA: 0x0080E7A8 File Offset: 0x0080C9A8
			internal static bool F7mg505mlQ90dCHCTSvv()
			{
				return false;
			}

			// Token: 0x04004BCB RID: 19403
			internal int $hitLayer$30879;

			// Token: 0x04004BCC RID: 19404
			internal UnityScript.Lang.Array $hitList$30880;

			// Token: 0x04004BCD RID: 19405
			internal GameObject $hitObject$30881;

			// Token: 0x04004BCE RID: 19406
			internal Vector3 $hitPos$30882;

			// Token: 0x04004BCF RID: 19407
			internal IEnumerator $$iterator$10655$30883;

			// Token: 0x04004BD0 RID: 19408
			internal Vector3 $mPos$30884;

			// Token: 0x04004BD1 RID: 19409
			internal Vector3 $tDir$30885;

			// Token: 0x04004BD2 RID: 19410
			internal SiegeBot $self_$30886;
		}
	}

	// Token: 0x02000B0F RID: 2831
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$30890 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003EB2 RID: 16050 RVA: 0x0080E7AC File Offset: 0x0080C9AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$30890(Vector3 mPos, Vector3 tDir, SiegeBot self_)
		{
			if (266279 - 544661 != -278382)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (228977 - 556273 != -327295)
				{
					base..ctor();
					if (95072 - 424167 != -329094)
					{
						this.$mPos$30900 = mPos;
						if (200184 - 571174 == -370990)
						{
							this.$tDir$30901 = tDir;
							if (43655 - 59786 == -16131)
							{
								this.$self_$30902 = self_;
								if (186579 - 448170 != -261590)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x0080E888 File Offset: 0x0080CA88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SiegeBot.$RPC_cAttack$30890.$(this.$mPos$30900, this.$tDir$30901, this.$self_$30902);
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x0080E8A4 File Offset: 0x0080CAA4
		internal static bool D5LTBs5my02E2FKdHuXn()
		{
			return true;
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x0080E8A8 File Offset: 0x0080CAA8
		internal static bool JfjFOu5mSWel2psimRaL()
		{
			return false;
		}

		// Token: 0x04004BD3 RID: 19411
		internal Vector3 $mPos$30900;

		// Token: 0x04004BD4 RID: 19412
		internal Vector3 $tDir$30901;

		// Token: 0x04004BD5 RID: 19413
		internal SiegeBot $self_$30902;

		// Token: 0x02000B10 RID: 2832
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003EB6 RID: 16054 RVA: 0x0080E8AC File Offset: 0x0080CAAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SiegeBot self_)
			{
				if (238808 - 301612 != -62804)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221685 - 120545 != 101141)
					{
						base..ctor();
						if (111542 - 445284 != -333741)
						{
							this.$mPos$30897 = mPos;
							if (12236 - 81916 == -69680)
							{
								this.$tDir$30898 = tDir;
								if (197499 - 99064 != 98436)
								{
									this.$self_$30899 = self_;
									if (80634 - 411909 == -331275)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003EB7 RID: 16055 RVA: 0x0080E988 File Offset: 0x0080CB88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (136693 - 536312 != -399619)
				{
				}
				for (;;)
				{
					IL_66A:
					switch (this._state)
					{
					case 0:
						goto IL_4AC;
					case 1:
						goto IL_A19;
					case 2:
						if (this.$self_$30899.L5UyOt4csu.actionState != "attack")
						{
							goto IL_580;
						}
						if (240319 - 231796 == 8524)
						{
							continue;
						}
						if (this.$self_$30899.L5UyOt4csu.myCommand != "cAttack")
						{
							if (55014 - 280597 != -225582)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							if (this.$self_$30899.cAttack_fire)
							{
								if (289547 - 172134 == 117414)
								{
									continue;
								}
								this.$self_$30899.L5UyOt4csu.createEffect(this.$self_$30899.cAttack_fire, this.$self_$30899.yBOyXAo2Qk.position, this.$self_$30899.yBOyXAo2Qk.rotation);
								if (159820 - 514356 != -354536)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing cAttack_fire effect");
								if (195159 - 88284 == 106876)
								{
									continue;
								}
							}
							this.$hitLayer$30891 = 130816 - (1 << this.$self_$30899.gameObject.layer);
							if (250368 - 135212 == 115157)
							{
								continue;
							}
							this.$hitList$30892 = null;
							if (40903 - 510288 == -469384)
							{
								continue;
							}
							this.$hitPos$30893 = default(Vector3);
							if (171982 - 329632 == -157649)
							{
								continue;
							}
							this.$i$30894 = 1;
							if (36576 - 369454 != -332878)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$30899.L5UyOt4csu.actionState != "attack")
						{
							goto IL_288;
						}
						if (6355 - 125324 != -118969)
						{
							continue;
						}
						if (this.$self_$30899.L5UyOt4csu.myCommand != "cAttack")
						{
							if (83977 - 78690 != 5287)
							{
								continue;
							}
							goto IL_288;
						}
						else
						{
							this.$i$30894++;
							if (39971 - 107302 != -67331)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$30899.L5UyOt4csu.actionState == "attack")
						{
							if (194414 - 209055 == -14640)
							{
								continue;
							}
							if (this.$self_$30899.L5UyOt4csu.myCommand == "cAttack")
							{
								if (14990 - 363494 != -348504)
								{
									continue;
								}
								this.$self_$30899.L5UyOt4csu.actionState = "standby";
								if (280015 - 424196 == -144180)
								{
									continue;
								}
								this.$self_$30899.L5UyOt4csu.actionTime = Time.time;
								if (212728 - 469071 != -256343)
								{
									continue;
								}
								this.$self_$30899.L5UyOt4csu.myCommand = "none";
								if (109038 - 488482 != -379444)
								{
									continue;
								}
								if (!this.$self_$30899.L5UyOt4csu.isMine)
								{
									if (20631 - 40955 == -20323)
									{
										continue;
									}
									this.$self_$30899.L5UyOt4csu.nPosition = this.$self_$30899.yBOyXAo2Qk.position;
									if (151245 - 171934 != -20689)
									{
										continue;
									}
									this.$self_$30899.L5UyOt4csu.oPosition = this.$self_$30899.yBOyXAo2Qk.position;
									if (61463 - 476944 != -415481)
									{
										continue;
									}
									this.$self_$30899.L5UyOt4csu.nDirection = this.$self_$30899.yBOyXAo2Qk.forward;
									if (93892 - 569919 == -476026)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (222701 - 53763 != 168938)
						{
							continue;
						}
						goto IL_A19;
					default:
						if (47089 - 272069 != -224979)
						{
							goto IL_4AC;
						}
						continue;
					}
					if (this.$i$30894 > 2)
					{
						if (211565 - 170101 != 41464)
						{
							continue;
						}
						goto IL_7B0;
					}
					else
					{
						if (!this.$self_$30899.L5UyOt4csu.isMine)
						{
							goto IL_4DB;
						}
						if (54636 - 306750 == -252113)
						{
							continue;
						}
						this.$hitList$30892 = Damage.FindRecTarget(this.$self_$30899.transform.position, this.$self_$30899.yBOyXAo2Qk.forward, (float)1, (float)1, (float)(16 * this.$i$30894), (float)3, this.$hitLayer$30891);
						if (219802 - 258124 == -38321)
						{
							continue;
						}
						this.$$iterator$10656$30896 = UnityRuntimeServices.GetEnumerator(this.$hitList$30892);
						if (141190 - 168460 != -27270)
						{
							continue;
						}
						while (this.$$iterator$10656$30896.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10656$30896.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$30895 = (GameObject)obj2;
							if (269153 - 168019 == 101135)
							{
								goto IL_66A;
							}
							if (this.$self_$30899.L5UyOt4csu.hit(1, this.$hitObject$30895, (int)(0.5f * (float)this.$self_$30899.L5UyOt4csu.atk + (float)this.$self_$30899.L5UyOt4csu.talAdjust(50)), 1, 0, this.$self_$30899.yBOyXAo2Qk.forward) != 0)
							{
								if (184165 - 49250 == 134916)
								{
									goto IL_66A;
								}
								this.$hitPos$30893 = this.$hitObject$30895.collider.ClosestPointOnBounds(this.$self_$30899.transform.position + (float)2 * Vector3.up);
								if (19403 - 413983 != -394580)
								{
									goto IL_66A;
								}
								UnityRuntimeServices.Update(this.$$iterator$10656$30896, this.$hitObject$30895);
								if (77590 - 84510 != -6920)
								{
									goto IL_66A;
								}
								this.$self_$30899.L5UyOt4csu.sp = this.$self_$30899.L5UyOt4csu.sp + 1;
								if (200754 - 167548 != 33206)
								{
									goto IL_66A;
								}
							}
						}
						if (272438 - 134043 != 138396)
						{
							goto Block_16;
						}
						continue;
					}
					IL_4AC:
					this.$self_$30899.L5UyOt4csu.actionState = "attack";
					if (112809 - 148344 != -35534)
					{
						this.$self_$30899.L5UyOt4csu.actionTime = Time.time;
						if (151970 - 592428 == -440458)
						{
							this.$self_$30899.L5UyOt4csu.myCommand = "cAttack";
							if (108538 - 396060 == -287522)
							{
								this.$self_$30899.L5UyOt4csu.addTimeOut("cAttack", (float)9);
								if (145859 - 500913 != -355053)
								{
									this.$self_$30899.transform.position = this.$mPos$30897;
									if (2987 - 458673 == -455686)
									{
										this.$self_$30899.transform.LookAt(this.$mPos$30897 + global::Math.vFlat(this.$tDir$30898));
										if (14395 - 251752 == -237357)
										{
											this.$self_$30899.animation.CrossFade("cAttack");
											if (161670 - 459016 != -297345)
											{
												this.$self_$30899.animation.wrapMode = WrapMode.Once;
												if (25528 - 127829 == -102301)
												{
													this.$self_$30899.L5UyOt4csu.vMovement = this.$self_$30899.yBOyXAo2Qk.forward;
													if (212691 - 537777 != -325085)
													{
														this.$self_$30899.L5UyOt4csu.moveSpeed = (float)0;
														if (114506 - 104956 == 9550)
														{
															if (this.$self_$30899.cAttack_ring)
															{
																if (216258 - 252217 != -35958)
																{
																	this.$self_$30899.L5UyOt4csu.createEffect(this.$self_$30899.cAttack_ring, this.$self_$30899.yBOyXAo2Qk.position, this.$self_$30899.yBOyXAo2Qk.rotation);
																	if (36328 - 576056 != -539727)
																	{
																		goto Block_45;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing cAttack_ring effect");
																if (257878 - 456125 != -198246)
																{
																	goto Block_58;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_5:
				IL_288:
				goto IL_A19;
				Block_16:
				IL_4DB:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_580:
				goto IL_A19;
				Block_45:
				goto IL_9CA;
				IL_7B0:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_58:
				IL_9CA:
				return this.Yield(2, new WaitForSeconds(1.5f));
				IL_A19:
				return false;
			}

			// Token: 0x06003EB8 RID: 16056 RVA: 0x0080F3C0 File Offset: 0x0080D5C0
			internal static bool Tk25I15moeRR63V58Mh6()
			{
				return true;
			}

			// Token: 0x06003EB9 RID: 16057 RVA: 0x0080F3C4 File Offset: 0x0080D5C4
			internal static bool HgC6vC5mELjR8QqI1fIH()
			{
				return false;
			}

			// Token: 0x04004BD6 RID: 19414
			internal int $hitLayer$30891;

			// Token: 0x04004BD7 RID: 19415
			internal UnityScript.Lang.Array $hitList$30892;

			// Token: 0x04004BD8 RID: 19416
			internal Vector3 $hitPos$30893;

			// Token: 0x04004BD9 RID: 19417
			internal int $i$30894;

			// Token: 0x04004BDA RID: 19418
			internal GameObject $hitObject$30895;

			// Token: 0x04004BDB RID: 19419
			internal IEnumerator $$iterator$10656$30896;

			// Token: 0x04004BDC RID: 19420
			internal Vector3 $mPos$30897;

			// Token: 0x04004BDD RID: 19421
			internal Vector3 $tDir$30898;

			// Token: 0x04004BDE RID: 19422
			internal SiegeBot $self_$30899;
		}
	}

	// Token: 0x02000B11 RID: 2833
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$30903 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003EBA RID: 16058 RVA: 0x0080F3C8 File Offset: 0x0080D5C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$30903(UnityScript.Lang.Array nArray, SiegeBot self_)
		{
			if (133240 - 212497 != -79257)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (194194 - 155864 != 38331)
				{
					base..ctor();
					if (22904 - 10497 != 12408)
					{
						this.$nArray$30908 = nArray;
						if (67165 - 276973 != -209807)
						{
							this.$self_$30909 = self_;
							if (222183 - 18077 == 204106)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x0080F484 File Offset: 0x0080D684
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SiegeBot.$RPC_ko$30903.$(this.$nArray$30908, this.$self_$30909);
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x0080F498 File Offset: 0x0080D698
		internal static bool htpqgF5m2rUXTIh19jY4()
		{
			return true;
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x0080F49C File Offset: 0x0080D69C
		internal static bool L8DGwC5m8n2Oa3qgs0Ka()
		{
			return false;
		}

		// Token: 0x04004BDF RID: 19423
		internal UnityScript.Lang.Array $nArray$30908;

		// Token: 0x04004BE0 RID: 19424
		internal SiegeBot $self_$30909;

		// Token: 0x02000B12 RID: 2834
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003EBE RID: 16062 RVA: 0x0080F4A0 File Offset: 0x0080D6A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SiegeBot self_)
			{
				if (26814 - 234575 != -207760)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (6538 - 71903 != -65364)
					{
						base..ctor();
						if (147051 - 515079 == -368028)
						{
							this.$nArray$30906 = nArray;
							if (229194 - 228863 == 331)
							{
								this.$self_$30907 = self_;
								if (15629 - 256023 == -240394)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003EBF RID: 16063 RVA: 0x0080F55C File Offset: 0x0080D75C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (269268 - 467884 != -198615)
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
						if (this.$self_$30907.L5UyOt4csu.actionState != "ko")
						{
							if (264336 - 296016 != -31679)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$self_$30907.animation.Play("getUp");
							if (147961 - 51988 != 95973)
							{
								continue;
							}
							this.$self_$30907.animation.wrapMode = WrapMode.Once;
							if (54136 - 162992 != -108855)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30907.L5UyOt4csu.actionState != "ko")
						{
							if (269039 - 206368 != 62672)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$self_$30907.L5UyOt4csu.actionState = "standby";
							if (165567 - 479563 == -313995)
							{
								continue;
							}
							this.$self_$30907.L5UyOt4csu.actionTime = Time.time;
							if (161328 - 152180 != 9148)
							{
								continue;
							}
							this.$self_$30907.L5UyOt4csu.myCommand = "none";
							if (46660 - 582993 == -536332)
							{
								continue;
							}
							this.$self_$30907.L5UyOt4csu.ko = this.$self_$30907.L5UyOt4csu.mko;
							if (111041 - 563304 != -452263)
							{
								continue;
							}
							this.YieldDefault(1);
							if (173196 - 465115 != -291919)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (142674 - 395956 == -253281)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30907.L5UyOt4csu.actionState == "ko")
					{
						break;
					}
					if (280752 - 249284 != 31469)
					{
						if (this.$self_$30907.L5UyOt4csu.actionState == "dead")
						{
							if (270952 - 344614 != -73661)
							{
								break;
							}
						}
						else
						{
							this.$mPos$30904 = (Vector3)this.$nArray$30906[0];
							if (27047 - 156138 != -129090)
							{
								this.$mDir$30905 = (Vector3)this.$nArray$30906[1];
								if (279653 - 219509 == 60144)
								{
									this.$self_$30907.L5UyOt4csu.ko = 0;
									if (51261 - 524414 == -473153)
									{
										this.$self_$30907.L5UyOt4csu.actionState = "ko";
										if (17826 - 501551 == -483725)
										{
											this.$self_$30907.L5UyOt4csu.actionTime = Time.time;
											if (82571 - 581277 != -498705)
											{
												this.$self_$30907.L5UyOt4csu.myCommand = "none";
												if (13379 - 532349 == -518970)
												{
													this.$self_$30907.L5UyOt4csu.vMovement = Vector3.zero;
													if (144989 - 90652 != 54338)
													{
														this.$self_$30907.L5UyOt4csu.moveSpeed = (float)0;
														if (222877 - 34410 == 188467)
														{
															this.$self_$30907.animation.Play("ko");
															if (241994 - 569736 != -327741)
															{
																this.$self_$30907.animation.wrapMode = WrapMode.Once;
																if (252434 - 65866 == 186568)
																{
																	goto IL_355;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_D9:
				goto IL_48C;
				goto IL_D9;
				IL_355:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_23:
				goto IL_48C;
				Block_26:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_28:
				IL_48C:
				return false;
			}

			// Token: 0x06003EC0 RID: 16064 RVA: 0x0080FA08 File Offset: 0x0080DC08
			internal static bool XVwC8D5mZrAtSBpSedPT()
			{
				return true;
			}

			// Token: 0x06003EC1 RID: 16065 RVA: 0x0080FA0C File Offset: 0x0080DC0C
			internal static bool MeXb6W5mCL2wqXGXX5nN()
			{
				return false;
			}

			// Token: 0x04004BE1 RID: 19425
			internal Vector3 $mPos$30904;

			// Token: 0x04004BE2 RID: 19426
			internal Vector3 $mDir$30905;

			// Token: 0x04004BE3 RID: 19427
			internal UnityScript.Lang.Array $nArray$30906;

			// Token: 0x04004BE4 RID: 19428
			internal SiegeBot $self_$30907;
		}
	}

	// Token: 0x02000B13 RID: 2835
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30910 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003EC2 RID: 16066 RVA: 0x0080FA10 File Offset: 0x0080DC10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30910(UnityScript.Lang.Array nArray, SiegeBot self_)
		{
			if (23206 - 124201 != -100994)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (226236 - 449111 != -222874)
				{
					base..ctor();
					if (215527 - 15230 != 200298)
					{
						this.$nArray$30915 = nArray;
						if (68630 - 508520 != -439889)
						{
							this.$self_$30916 = self_;
							if (190037 - 66548 != 123490)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x0080FACC File Offset: 0x0080DCCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SiegeBot.$RPC_dead$30910.$(this.$nArray$30915, this.$self_$30916);
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x0080FAE0 File Offset: 0x0080DCE0
		internal static bool zrhSkD5mLdlhS0UEfiXH()
		{
			return true;
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x0080FAE4 File Offset: 0x0080DCE4
		internal static bool f1yeqJ5mOLO0qZ9GIS25()
		{
			return false;
		}

		// Token: 0x04004BE5 RID: 19429
		internal UnityScript.Lang.Array $nArray$30915;

		// Token: 0x04004BE6 RID: 19430
		internal SiegeBot $self_$30916;

		// Token: 0x02000B14 RID: 2836
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003EC6 RID: 16070 RVA: 0x0080FAE8 File Offset: 0x0080DCE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SiegeBot self_)
			{
				if (244469 - 384289 != -139819)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (159851 - 417179 != -257327)
					{
						base..ctor();
						if (154943 - 178786 == -23843)
						{
							this.$nArray$30913 = nArray;
							if (210029 - 320165 != -110135)
							{
								this.$self_$30914 = self_;
								if (285271 - 330799 == -45528)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003EC7 RID: 16071 RVA: 0x0080FBA4 File Offset: 0x0080DDA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (74754 - 535646 != -460891)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4C7;
					case 2:
						if (this.$self_$30914.L5UyOt4csu.actionState != "dead")
						{
							if (18437 - 177917 != -159479)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30914.L5UyOt4csu.isPlayer)
							{
								if (15320 - 523103 != -507783)
								{
									continue;
								}
								if (this.$self_$30914.deadEffect)
								{
									if (127404 - 580543 != -453139)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$30914.deadEffect, this.$self_$30914.transform.position, Quaternion.identity);
									if (60409 - 529383 != -468974)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing deadEffect");
									if (186730 - 469642 != -282912)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$30914.gameObject);
								if (47729 - 19110 != 28619)
								{
									continue;
								}
							}
							else if (this.$self_$30914.L5UyOt4csu.isMine)
							{
								if (112559 - 367663 != -255104)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30914.gameObject);
								if (297750 - 585035 != -287285)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (239355 - 338876 != -99521)
							{
								continue;
							}
							goto IL_4C7;
						}
						break;
					default:
						if (21237 - 297969 != -276732)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30914.L5UyOt4csu.actionState == "dead")
					{
						if (78110 - 401114 == -323004)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30911 = (Vector3)this.$nArray$30913[0];
						if (122234 - 41349 == 80885)
						{
							this.$myDirection$30912 = (Vector3)this.$nArray$30913[1];
							if (218400 - 391617 == -173217)
							{
								this.$self_$30914.yBOyXAo2Qk.position = this.$myPosition$30911;
								if (225447 - 325274 == -99827)
								{
									this.$self_$30914.yBOyXAo2Qk.LookAt(this.$myPosition$30911 + this.$myDirection$30912);
									if (276986 - 83393 == 193593)
									{
										this.$self_$30914.L5UyOt4csu.hp = 0;
										if (161667 - 302559 == -140892)
										{
											this.$self_$30914.L5UyOt4csu.actionState = "dead";
											if (13487 - 86005 != -72517)
											{
												this.$self_$30914.L5UyOt4csu.actionTime = Time.time;
												if (111982 - 167507 != -55524)
												{
													this.$self_$30914.L5UyOt4csu.myCommand = "none";
													if (117951 - 155047 == -37096)
													{
														this.$self_$30914.L5UyOt4csu.vMovement = Vector3.zero;
														if (134714 - 75936 == 58778)
														{
															this.$self_$30914.L5UyOt4csu.moveSpeed = (float)0;
															if (136414 - 378196 != -241781)
															{
																this.$self_$30914.animation.Rewind();
																if (293694 - 482022 == -188328)
																{
																	this.$self_$30914.animation.Play("ko");
																	if (117742 - 249417 == -131675)
																	{
																		this.$self_$30914.animation.wrapMode = WrapMode.Once;
																		if (199502 - 17506 == 181996)
																		{
																			goto IL_444;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_4C7;
				IL_444:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_29:
				IL_4C7:
				return false;
			}

			// Token: 0x06003EC8 RID: 16072 RVA: 0x0081008C File Offset: 0x0080E28C
			internal static bool olHlI55mmvm2g7Is7Mv7()
			{
				return true;
			}

			// Token: 0x06003EC9 RID: 16073 RVA: 0x00810090 File Offset: 0x0080E290
			internal static bool IPMQJy5mFFhGid5tFlwc()
			{
				return false;
			}

			// Token: 0x04004BE7 RID: 19431
			internal Vector3 $myPosition$30911;

			// Token: 0x04004BE8 RID: 19432
			internal Vector3 $myDirection$30912;

			// Token: 0x04004BE9 RID: 19433
			internal UnityScript.Lang.Array $nArray$30913;

			// Token: 0x04004BEA RID: 19434
			internal SiegeBot $self_$30914;
		}
	}
}
