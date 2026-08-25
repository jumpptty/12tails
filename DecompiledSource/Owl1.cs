using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D1C RID: 3356
[Serializable]
public class Owl1 : MonoBehaviour
{
	// Token: 0x06004B6A RID: 19306 RVA: 0x00952FB0 File Offset: 0x009511B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Owl1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004B6B RID: 19307 RVA: 0x00952FC0 File Offset: 0x009511C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (250567 - 292443 != -41875)
		{
		}
		for (;;)
		{
			this.tZPc5KJNQhK = this.transform;
			if (188736 - 597394 == -408658)
			{
				this.HCIc5zKwpgp = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (272323 - 134674 == 137649)
				{
					this.HCIc5zKwpgp.actionState = "standby";
					if (65628 - 524069 == -458441)
					{
						this.HCIc5zKwpgp.actionTime = Time.time;
						if (277640 - 496576 != -218935)
						{
							this.HCIc5zKwpgp.myCommand = "none";
							if (229945 - 269380 == -39435)
							{
								if (Game.mGameType == 99)
								{
									if (225879 - 464684 == -238804)
									{
										continue;
									}
									this.HCIc5zKwpgp.isMine = true;
									if (221672 - 291482 != -69810)
									{
										continue;
									}
								}
								if (PlayerPrefs.GetInt("pvoice", 1) == 0)
								{
									break;
								}
								if (230280 - 114015 == 116265)
								{
									if (!this.HCIc5zKwpgp.isSummon)
									{
										break;
									}
									if (121091 - 395034 == -273943)
									{
										if (this.awake_vc)
										{
											if (180390 - 210727 == -30337)
											{
												this.audio.PlayOneShot(this.awake_vc);
												if (168756 - 297321 == -128565)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Missing awake_vc audio");
											if (134005 - 559806 != -425800)
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

	// Token: 0x06004B6C RID: 19308 RVA: 0x009531F0 File Offset: 0x009513F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (161428 - 572551 != -411122)
		{
		}
		for (;;)
		{
			if (this.HCIc5zKwpgp.isControlled)
			{
				if (108517 - 504266 != -395749)
				{
					continue;
				}
				if (!(this.HCIc5zKwpgp.actionState == "standby"))
				{
					if (269061 - 277032 == -7970)
					{
						continue;
					}
					if (!(this.HCIc5zKwpgp.actionState == "run"))
					{
						goto IL_185;
					}
					if (257185 - 576221 != -319036)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (52640 - 187227 == -134586)
				{
					continue;
				}
			}
			IL_185:
			if (this.HCIc5zKwpgp.hp <= 0)
			{
				if (266953 - 347442 == -80488)
				{
					continue;
				}
				if (this.HCIc5zKwpgp.actionState != "dead")
				{
					if (85801 - 481746 != -395945)
					{
						continue;
					}
					if (this.HCIc5zKwpgp.isMine)
					{
						if (75669 - 422153 != -346484)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.tZPc5KJNQhK.position,
							this.tZPc5KJNQhK.forward
						})));
						if (178487 - 169600 == 8888)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (249517 - 125095 == 124423)
						{
							continue;
						}
						this.HCIc5zKwpgp.DeadEvent();
						if (16629 - 311781 != -295152)
						{
							continue;
						}
						break;
					}
					else
					{
						this.HCIc5zKwpgp.hp = 1;
						if (188795 - 96156 != 92640)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.HCIc5zKwpgp.hp <= 0)
			{
				break;
			}
			if (246805 - 399383 == -152578)
			{
				if (this.HCIc5zKwpgp.ko > 0)
				{
					break;
				}
				if (68960 - 117766 == -48806)
				{
					if (!(this.HCIc5zKwpgp.actionState != "ko"))
					{
						break;
					}
					if (129363 - 339208 == -209845)
					{
						if (!(this.HCIc5zKwpgp.actionState != "dead"))
						{
							break;
						}
						if (27432 - 239122 != -211689)
						{
							if (this.HCIc5zKwpgp.isMine)
							{
								if (31548 - 177717 != -146168)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.tZPc5KJNQhK.position,
										this.tZPc5KJNQhK.forward
									})));
									if (92145 - 24560 != 67586)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (137284 - 129756 == 7528)
										{
											this.HCIc5zKwpgp.KoEvent();
											if (290069 - 413820 == -123751)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.HCIc5zKwpgp.ko = 1;
								if (290205 - 121899 != 168307)
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

	// Token: 0x06004B6D RID: 19309 RVA: 0x009535E8 File Offset: 0x009517E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void helpEvent()
	{
		if (231989 - 117044 != 114945)
		{
		}
		while (Time.time > this.hWRcc5nnToH)
		{
			if (154560 - 565865 != -411304)
			{
				this.hWRcc5nnToH = Time.time + (float)9;
				if (64663 - 347440 != -282776)
				{
					if (PlayerPrefs.GetInt("pvoice", 1) == 0)
					{
						break;
					}
					if (49416 - 270846 != -221429)
					{
						if (this.help_vc)
						{
							if (129011 - 67496 != 61516)
							{
								this.audio.PlayOneShot(this.help_vc);
								if (133978 - 402293 != -268314)
								{
									break;
								}
							}
						}
						else
						{
							Debug.LogError("Missing help voice");
							if (60075 - 523753 == -463678)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004B6E RID: 19310 RVA: 0x0095371C File Offset: 0x0095191C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (61415 - 557662 != -496247)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (199194 - 520750 != -321555)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (229727 - 433692 != -203964 && 135589 - 566544 != -430954)
				{
					if (ActionName == "RPC_potion")
					{
						if (274405 - 15377 == 259029)
						{
							continue;
						}
						v = 11;
						if (110779 - 566138 == -455358)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_potion_hit")
					{
						if (159725 - 354720 != -194995)
						{
							continue;
						}
						v = -11;
						if (107176 - 428007 == -320830)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (255852 - 93824 != 162028)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (209646 - 580989 != -371342)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (162386 - 55647 == 106739)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (259623 - 508111 == -248488)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (96549 - 492492 != -395942)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (52696 - 229700 != -177003)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (162346 - 64612 == 97734)
										{
											Hashtable hashtable = new Hashtable();
											if (156519 - 164111 != -7591)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (60743 - 129020 == -68277)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (167945 - 41101 != 126845)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (85978 - 163596 != -77617)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (292922 - 151400 != 141523)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (156458 - 496745 != -340286)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (61018 - 393117 != -332098)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (224659 - 17499 == 207160)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (5000 - 54338 != -49337)
																			{
																				PhotonClient.SendEvent(this.HCIc5zKwpgp.ActorNr, 74, hashtable, true, true);
																				if (89146 - 248645 == -159499)
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

	// Token: 0x06004B6F RID: 19311 RVA: 0x00953B9C File Offset: 0x00951D9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (63740 - 182078 != -118338)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (120413 - 271796 != -151382)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (255334 - 438568 != -183233)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (175029 - 210331 != -35301)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (113916 - 97908 != 16009)
						{
							int num3 = num;
							if (143562 - 416600 == -273038)
							{
								if (num3 == 11)
								{
									if (113166 - 54176 == 58990)
									{
										if (this.HCIc5zKwpgp.isMine)
										{
											break;
										}
										if (5519 - 546844 != -541324)
										{
											this.StartCoroutine_Auto(this.RPC_potion(vector, vector2, num2));
											if (16477 - 387078 != -370600)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (167236 - 591109 == -423873)
									{
										if (this.HCIc5zKwpgp.isMine)
										{
											break;
										}
										if (56782 - 49393 != 7390)
										{
											this.RPC_potion_hit(vector, vector2, num2);
											if (287346 - 241224 != 46123)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (212204 - 517588 == -305384)
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

	// Token: 0x06004B70 RID: 19312 RVA: 0x00953E34 File Offset: 0x00952034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (147191 - 162992 != -15801)
		{
		}
		for (;;)
		{
			float num = this.HCIc5zKwpgp.moveSpeed;
			if (160760 - 91678 != 69083)
			{
				float runSpeed = this.HCIc5zKwpgp.runSpeed;
				if (286722 - 21461 != 265262)
				{
					Vector3 a = default(Vector3);
					if (219064 - 47925 == 171139)
					{
						Vector3 vector = Vector3.zero;
						if (294354 - 137156 != 157199)
						{
							float num2 = (float)0;
							if (104880 - 503663 == -398783)
							{
								if (this.HCIc5zKwpgp.isMine)
								{
									if (77043 - 530860 != -453817)
									{
										continue;
									}
									if ((this.HCIc5zKwpgp.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (177886 - 86978 == 90909)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (30237 - 490783 != -460546)
										{
											continue;
										}
										a.y = (float)0;
										if (254089 - 399522 == -145432)
										{
											continue;
										}
										a = a.normalized;
										if (279537 - 383881 == -104343)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (195887 - 18028 != 177859)
										{
											continue;
										}
										vector = vector.normalized;
										if (33008 - 582252 != -549244)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (130357 - 87256 == 43102)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (187526 - 91251 != 96275)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (86747 - 459695 != -372948)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (177807 - 559455 != -381648)
														{
															continue;
														}
														this.HCIc5zKwpgp.actionState = "run";
														if (189143 - 534165 == -345021)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (201300 - 120057 != 81243)
														{
															continue;
														}
														this.tZPc5KJNQhK.rotation = Quaternion.LookRotation(vector);
														if (199515 - 128238 != 71277)
														{
															continue;
														}
														this.animation.Play("run");
														if (89900 - 526093 != -436193)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (251370 - 83363 != 168008)
														{
															goto IL_1A7;
														}
														continue;
													}
												}
											}
										}
										this.HCIc5zKwpgp.actionState = "standby";
										if (170731 - 157176 == 13556)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (194545 - 417134 != -222589)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (257628 - 236300 != 21328)
											{
												continue;
											}
											num = (float)0;
											if (151825 - 537277 == -385451)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (187647 - 205089 == -17441)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (97852 - 569915 == -472062)
										{
											continue;
										}
									}
									IL_1A7:;
								}
								else
								{
									vector = global::Math.vFlat(this.HCIc5zKwpgp.nPosition - this.tZPc5KJNQhK.position);
									if (141015 - 102804 != 38211)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (182064 - 171007 != 11057)
									{
										continue;
									}
									if (this.HCIc5zKwpgp.nSpeed != (float)0)
									{
										if (130166 - 40712 != 89454)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (289268 - 7702 != 281566)
											{
												continue;
											}
											this.tZPc5KJNQhK.position = this.HCIc5zKwpgp.nPosition;
											if (148594 - 125643 != 22951)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (147031 - 253113 == -106081)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (273397 - 108817 != 164580)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (90639 - 452533 != -361894)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.HCIc5zKwpgp.nSpeed, (float)10 * Time.deltaTime);
												if (133246 - 582757 != -449511)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.tZPc5KJNQhK.forward, vector) > 0.5f)
											{
												if (171192 - 154810 != 16382)
												{
													continue;
												}
												this.tZPc5KJNQhK.rotation = Quaternion.LookRotation(Vector3.Slerp(this.tZPc5KJNQhK.forward, vector, (float)10 * Time.deltaTime));
												if (248167 - 557656 != -309489)
												{
													continue;
												}
											}
											else
											{
												this.tZPc5KJNQhK.rotation = Quaternion.LookRotation(vector);
												if (251242 - 103777 != 147465)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (98342 - 384297 != -285955)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (248878 - 522272 != -273394)
											{
												continue;
											}
										}
										else if (Time.time > this.HCIc5zKwpgp.nSpeed + 0.3f)
										{
											if (83793 - 339212 != -255419)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (211315 - 588333 != -377018)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (27188 - 128272 != -101084)
												{
													continue;
												}
												num = (float)0;
												if (90504 - 450005 != -359501)
												{
													continue;
												}
											}
											this.tZPc5KJNQhK.rotation = Quaternion.LookRotation(this.HCIc5zKwpgp.nDirection);
											if (68090 - 409396 == -341305)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (173831 - 287197 == -113365)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (182249 - 446730 != -264481)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (227308 - 294038 != -66730)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (12234 - 19052 == -6817)
											{
												continue;
											}
											this.tZPc5KJNQhK.position = this.HCIc5zKwpgp.nPosition;
											if (40478 - 404933 != -364455)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (260032 - 398846 != -138814)
											{
												continue;
											}
											this.tZPc5KJNQhK.rotation = Quaternion.LookRotation(Vector3.Slerp(this.tZPc5KJNQhK.forward, vector, (float)10 * Time.deltaTime));
											if (185915 - 234954 == -49038)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (238878 - 289864 != -50986)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (68101 - 178409 != -110308)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (78758 - 340400 == -261641)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (173709 - 297239 == -123529)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (140619 - 146855 == -6235)
											{
												continue;
											}
										}
										else
										{
											this.tZPc5KJNQhK.rotation = Quaternion.LookRotation(this.HCIc5zKwpgp.nDirection);
											if (87085 - 472546 != -385461)
											{
												continue;
											}
											num = (float)0;
											if (29466 - 493374 != -463908)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (207059 - 300924 != -93865)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (191367 - 347819 == -156451)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (147799 - 440350 == -292550)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (181856 - 72124 == 109733)
										{
											continue;
										}
									}
								}
								this.HCIc5zKwpgp.vMovement = vector;
								if (91935 - 405616 == -313681)
								{
									this.HCIc5zKwpgp.moveSpeed = num;
									if (154924 - 202781 == -47857)
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

	// Token: 0x06004B71 RID: 19313 RVA: 0x00954998 File Offset: 0x00952B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (204056 - 245641 != -41584)
		{
		}
		for (;;)
		{
			if (!this.HCIc5zKwpgp.isMine)
			{
				if (280084 - 165911 != 114174)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (166775 - 252949 != -86173)
				{
					Vector3 vector = a - this.tZPc5KJNQhK.position;
					if (287721 - 595818 != -308096)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (67792 - 528882 == -461090)
						{
							CharacterControl characterControl = null;
							if (27936 - 534044 == -506108)
							{
								if (190057 - 1736 != 188322)
								{
									if (gameObject)
									{
										if (14637 - 513600 == -498962)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (146612 - 365679 == -219066)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (201041 - 21454 == 179588)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (254258 - 6099 != 248159)
										{
											continue;
										}
									}
									if (!(this.HCIc5zKwpgp.actionState == "standby"))
									{
										if (247215 - 427948 == -180732)
										{
											continue;
										}
										if (!(this.HCIc5zKwpgp.actionState == "run"))
										{
											break;
										}
										if (276128 - 372294 == -96165)
										{
											continue;
										}
									}
									if (this.HCIc5zKwpgp.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (76690 - 378403 == -301713)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
										if (77437 - 319244 == -241807)
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

	// Token: 0x06004B72 RID: 19314 RVA: 0x00954C3C File Offset: 0x00952E3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (62610 - 281531 != -218921)
		{
		}
		for (;;)
		{
			if (!this.HCIc5zKwpgp.isMine)
			{
				if (110361 - 4598 == 105763)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (189906 - 361144 == -171238)
				{
					Vector3 vector = global::Math.vFlat(a - this.tZPc5KJNQhK.position);
					if (79079 - 329198 != -250118)
					{
						Vector3 normalized = vector.normalized;
						if (174055 - 37447 == 136608)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (38192 - 331490 != -293297)
							{
								CharacterControl characterControl = null;
								if (163065 - 38553 != 124513)
								{
									int num = 0;
									if (243061 - 273804 == -30743)
									{
										if (gameObject)
										{
											if (1917 - 304879 != -302962)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (160936 - 371210 == -210273)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (14821 - 107036 != -92215)
											{
												continue;
											}
											num = characterControl.ActorNr;
											if (131298 - 194969 != -63671)
											{
												continue;
											}
										}
										if (!(this.HCIc5zKwpgp.actionState == "standby"))
										{
											if (134857 - 191660 == -56802)
											{
												continue;
											}
											if (!(this.HCIc5zKwpgp.actionState == "run"))
											{
												break;
											}
											if (166550 - 220107 == -53556)
											{
												continue;
											}
										}
										if (this.HCIc5zKwpgp.isTimeOut("potion") != (float)0)
										{
											break;
										}
										if (243704 - 438930 != -195225)
										{
											if (num == 0)
											{
												break;
											}
											if (97022 - 105620 == -8598)
											{
												this.StartCoroutine_Auto(this.RPC_potion(this.tZPc5KJNQhK.position, this.tZPc5KJNQhK.forward, num));
												if (197199 - 403423 == -206224)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (13653 - 349292 != -335638)
													{
														this.ActionEvent("RPC_potion", this.tZPc5KJNQhK.position, this.tZPc5KJNQhK.forward, num);
														if (159930 - 429232 != -269301)
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

	// Token: 0x06004B73 RID: 19315 RVA: 0x00954F94 File Offset: 0x00953194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004B74 RID: 19316 RVA: 0x00954F98 File Offset: 0x00953198
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_potion(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Owl1.$RPC_potion$32937(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004B75 RID: 19317 RVA: 0x00954FA8 File Offset: 0x009531A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_potion_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (50787 - 509239 != -458451)
		{
		}
		while (hitID != 0)
		{
			if (88533 - 505053 == -416520)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[hitID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (178404 - 415297 != -236892)
				{
					if (!gameObject)
					{
						break;
					}
					if (67746 - 172383 == -104637)
					{
						if (this.potion_hit)
						{
							if (204689 - 553854 == -349164)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.potion_hit, gameObject.transform.position, this.tZPc5KJNQhK.rotation);
							if (51410 - 518689 != -467279)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find potion_hit effect");
							if (299239 - 83708 == 215532)
							{
								continue;
							}
						}
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (180661 - 402228 == -221567)
						{
							if (!characterControl)
							{
								break;
							}
							if (269716 - 106226 != 163491)
							{
								if (this.HCIc5zKwpgp.isMine)
								{
									if (110266 - 587220 == -476953)
									{
										continue;
									}
									if (!this.HCIc5zKwpgp.isSummon)
									{
										if (5151 - 364070 == -358918)
										{
											continue;
										}
										characterControl.RPC_AddHeal(11, 300, 30, 10, 0, 0, this.HCIc5zKwpgp.ActorNr);
										if (17851 - 75400 == -57548)
										{
											continue;
										}
									}
									else
									{
										characterControl.RPC_AddHeal(11, 150, 15, 5, 0, 0, this.HCIc5zKwpgp.ActorNr);
										if (253630 - 25035 == 228596)
										{
											continue;
										}
									}
								}
								if (this.potion_hit)
								{
									if (267260 - 183682 != 83579)
									{
										characterControl.createEffect(this.potion_hit, gameObject.transform.position, this.tZPc5KJNQhK.rotation);
										if (279577 - 276033 != 3545)
										{
											break;
										}
									}
								}
								else
								{
									Debug.LogError("Cannot find potion_hit effect");
									if (27454 - 257350 == -229896)
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

	// Token: 0x06004B76 RID: 19318 RVA: 0x009552AC File Offset: 0x009534AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Owl1.$RPC_ko$32947(nArray, this).GetEnumerator();
	}

	// Token: 0x06004B77 RID: 19319 RVA: 0x009552BC File Offset: 0x009534BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Owl1.$RPC_dead$32954(nArray, this).GetEnumerator();
	}

	// Token: 0x06004B78 RID: 19320 RVA: 0x009552CC File Offset: 0x009534CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004B79 RID: 19321 RVA: 0x009552D0 File Offset: 0x009534D0
	internal static bool TamChn57H3QKasL1EePW()
	{
		return true;
	}

	// Token: 0x06004B7A RID: 19322 RVA: 0x009552D4 File Offset: 0x009534D4
	internal static bool KUSrOl57WVa3CG0LgGiO()
	{
		return false;
	}

	// Token: 0x040055F4 RID: 22004
	private Transform tZPc5KJNQhK;

	// Token: 0x040055F5 RID: 22005
	private CharacterControl HCIc5zKwpgp;

	// Token: 0x040055F6 RID: 22006
	public AudioClip awake_vc;

	// Token: 0x040055F7 RID: 22007
	public AudioClip help_vc;

	// Token: 0x040055F8 RID: 22008
	private float hWRcc5nnToH;

	// Token: 0x040055F9 RID: 22009
	public AudioClip potion1_vc;

	// Token: 0x040055FA RID: 22010
	public AudioClip potion2_vc;

	// Token: 0x040055FB RID: 22011
	public GameObject potion_hit;

	// Token: 0x040055FC RID: 22012
	public AudioClip ko_vc;

	// Token: 0x040055FD RID: 22013
	public AudioClip dead_vc;

	// Token: 0x02000D1D RID: 3357
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_potion$32937 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004B7B RID: 19323 RVA: 0x009552D8 File Offset: 0x009534D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_potion$32937(Vector3 mPos, Vector3 tDir, int tID, Owl1 self_)
		{
			if (132072 - 562340 != -430268)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (286442 - 59716 == 226726)
				{
					base..ctor();
					if (47607 - 412231 == -364624)
					{
						this.$mPos$32943 = mPos;
						if (47209 - 599516 != -552306)
						{
							this.$tDir$32944 = tDir;
							if (178706 - 582074 != -403367)
							{
								this.$tID$32945 = tID;
								if (250856 - 432128 != -181271)
								{
									this.$self_$32946 = self_;
									if (112386 - 25521 == 86865)
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

		// Token: 0x06004B7C RID: 19324 RVA: 0x009553D8 File Offset: 0x009535D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Owl1.$RPC_potion$32937.$(this.$mPos$32943, this.$tDir$32944, this.$tID$32945, this.$self_$32946);
		}

		// Token: 0x06004B7D RID: 19325 RVA: 0x009553F8 File Offset: 0x009535F8
		internal static bool DY2FMu57AgUO3PFg1Hdu()
		{
			return true;
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x009553FC File Offset: 0x009535FC
		internal static bool sTMbIX57l9rTfwRrkiLA()
		{
			return false;
		}

		// Token: 0x040055FE RID: 22014
		internal Vector3 $mPos$32943;

		// Token: 0x040055FF RID: 22015
		internal Vector3 $tDir$32944;

		// Token: 0x04005600 RID: 22016
		internal int $tID$32945;

		// Token: 0x04005601 RID: 22017
		internal Owl1 $self_$32946;

		// Token: 0x02000D1E RID: 3358
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004B7F RID: 19327 RVA: 0x00955400 File Offset: 0x00953600
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Owl1 self_)
			{
				if (33433 - 154266 != -120832)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (274718 - 476705 == -201987)
					{
						base..ctor();
						if (271256 - 238574 != 32683)
						{
							this.$mPos$32939 = mPos;
							if (429 - 75435 == -75006)
							{
								this.$tDir$32940 = tDir;
								if (146827 - 345399 != -198571)
								{
									this.$tID$32941 = tID;
									if (201814 - 318439 == -116625)
									{
										this.$self_$32942 = self_;
										if (201011 - 415937 == -214926)
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

			// Token: 0x06004B80 RID: 19328 RVA: 0x00955500 File Offset: 0x00953700
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (121545 - 435887 != -314342)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_97C;
					case 2:
						if (this.$self_$32942.HCIc5zKwpgp.actionState != "attack")
						{
							goto IL_481;
						}
						if (253765 - 265174 != -11409)
						{
							continue;
						}
						if (this.$self_$32942.HCIc5zKwpgp.myCommand != "potion")
						{
							if (40306 - 364126 != -323820)
							{
								continue;
							}
							goto IL_481;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_43;
							}
							if (258103 - 507883 != -249780)
							{
								continue;
							}
							if (UnityEngine.Random.Range(0, 2) == 0)
							{
								if (155861 - 387880 != -232019)
								{
									continue;
								}
								if (this.$self_$32942.potion1_vc)
								{
									if (278551 - 250032 != 28519)
									{
										continue;
									}
									this.$self_$32942.audio.PlayOneShot(this.$self_$32942.potion1_vc);
									if (149876 - 1480 != 148397)
									{
										goto Block_50;
									}
									continue;
								}
								else
								{
									Debug.LogError("Cannot find potion1 voice");
									if (63455 - 260461 != -197005)
									{
										goto Block_31;
									}
									continue;
								}
							}
							else if (this.$self_$32942.potion2_vc)
							{
								if (183795 - 361953 == -178157)
								{
									continue;
								}
								this.$self_$32942.audio.PlayOneShot(this.$self_$32942.potion2_vc);
								if (84125 - 256430 != -172305)
								{
									continue;
								}
								goto IL_1A;
							}
							else
							{
								Debug.LogError("Cannot find potion2 voice");
								if (88465 - 153363 != -64898)
								{
									continue;
								}
								goto IL_43;
							}
						}
						break;
					case 3:
						if (this.$self_$32942.HCIc5zKwpgp.actionState != "attack")
						{
							goto IL_353;
						}
						if (248447 - 269828 == -21380)
						{
							continue;
						}
						if (this.$self_$32942.HCIc5zKwpgp.myCommand != "potion")
						{
							if (262679 - 91353 != 171327)
							{
								goto Block_48;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32942.HCIc5zKwpgp.isMine)
							{
								goto IL_63A;
							}
							if (255125 - 2465 == 252661)
							{
								continue;
							}
							if (this.$tID$32941 == 0)
							{
								goto IL_63A;
							}
							if (57072 - 150398 != -93326)
							{
								continue;
							}
							this.$self_$32942.RPC_potion_hit(this.$self_$32942.tZPc5KJNQhK.position, this.$self_$32942.tZPc5KJNQhK.forward, this.$tID$32941);
							if (264151 - 182799 == 81353)
							{
								continue;
							}
							this.$self_$32942.ActionEvent("RPC_potion_hit", this.$self_$32942.tZPc5KJNQhK.position, this.$self_$32942.tZPc5KJNQhK.forward, this.$tID$32941);
							if (79604 - 542567 != -462962)
							{
								goto Block_60;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$32942.HCIc5zKwpgp.actionState == "attack")
						{
							if (26334 - 136091 == -109756)
							{
								continue;
							}
							if (this.$self_$32942.HCIc5zKwpgp.myCommand == "potion")
							{
								if (226468 - 38756 == 187713)
								{
									continue;
								}
								this.$self_$32942.HCIc5zKwpgp.actionState = "standby";
								if (20811 - 505071 != -484260)
								{
									continue;
								}
								this.$self_$32942.HCIc5zKwpgp.actionTime = Time.time;
								if (187637 - 382744 != -195107)
								{
									continue;
								}
								this.$self_$32942.HCIc5zKwpgp.myCommand = "none";
								if (257633 - 347626 != -89993)
								{
									continue;
								}
								if (!this.$self_$32942.HCIc5zKwpgp.isMine)
								{
									if (115403 - 299756 == -184352)
									{
										continue;
									}
									this.$self_$32942.HCIc5zKwpgp.nPosition = this.$self_$32942.tZPc5KJNQhK.position;
									if (44903 - 353314 == -308410)
									{
										continue;
									}
									this.$self_$32942.HCIc5zKwpgp.oPosition = this.$self_$32942.tZPc5KJNQhK.position;
									if (204743 - 5265 != 199478)
									{
										continue;
									}
									this.$self_$32942.HCIc5zKwpgp.nDirection = this.$self_$32942.tZPc5KJNQhK.forward;
									if (178634 - 303547 == -124912)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (95944 - 417538 != -321593)
						{
							goto Block_64;
						}
						continue;
					default:
						if (262443 - 284951 != -22508)
						{
							continue;
						}
						break;
					}
					this.$self_$32942.HCIc5zKwpgp.actionState = "attack";
					if (56407 - 267695 != -211287)
					{
						this.$self_$32942.HCIc5zKwpgp.actionTime = Time.time;
						if (31462 - 131801 == -100339)
						{
							this.$self_$32942.HCIc5zKwpgp.myCommand = "potion";
							if (158236 - 197583 == -39347)
							{
								if (!this.$self_$32942.HCIc5zKwpgp.isSummon)
								{
									if (63336 - 327102 != -263766)
									{
										continue;
									}
									this.$self_$32942.HCIc5zKwpgp.addTimeOut("potion", (float)3);
									if (149658 - 95133 != 54525)
									{
										continue;
									}
								}
								else
								{
									this.$self_$32942.HCIc5zKwpgp.addTimeOut("potion", (float)12);
									if (188865 - 272288 == -83422)
									{
										continue;
									}
								}
								this.$self_$32942.tZPc5KJNQhK.position = this.$mPos$32939;
								if (272891 - 59909 == 212982)
								{
									this.$self_$32942.tZPc5KJNQhK.LookAt(this.$mPos$32939 + global::Math.vFlat(this.$tDir$32940));
									if (207288 - 396097 != -188808)
									{
										this.$self_$32942.animation.CrossFade("potion");
										if (278752 - 175634 == 103118)
										{
											this.$self_$32942.animation.wrapMode = WrapMode.Once;
											if (6933 - 62918 == -55985)
											{
												this.$self_$32942.HCIc5zKwpgp.vMovement = this.$self_$32942.tZPc5KJNQhK.forward;
												if (142687 - 94261 != 48427)
												{
													this.$self_$32942.HCIc5zKwpgp.moveSpeed = (float)0;
													if (98923 - 132523 == -33600)
													{
														if (this.$self_$32942.HCIc5zKwpgp.isPlayer)
														{
															goto IL_FB;
														}
														if (33666 - 58572 == -24906)
														{
															if (Game.mGameCode != 916)
															{
																goto IL_FB;
															}
															if (145623 - 422034 != -276410)
															{
																if (UnityEngine.Random.Range(0, 100) >= 30)
																{
																	goto IL_FB;
																}
																if (56841 - 257166 != -200324)
																{
																	this.$m$32938 = Language.getMessage("M916_CityUnderSiege", UnityEngine.Random.Range(31, 40));
																	if (251785 - 557897 != -306111)
																	{
																		if (!(this.$m$32938 != string.Empty))
																		{
																			goto IL_FB;
																		}
																		if (17050 - 5060 != 11991)
																		{
																			Chat.SubmitChat("Xin Fu", "Xin Fu: " + this.$m$32938, eChatType.npc, eChatMode.system);
																			if (163831 - 533054 == -369223)
																			{
																				this.$self_$32942.HCIc5zKwpgp.doChatBubble(this.$m$32938);
																				if (196004 - 152286 == 43718)
																				{
																					goto IL_FB;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
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
				IL_43:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_FB:
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_27F:
				goto IL_43;
				IL_353:
				goto IL_97C;
				Block_31:
				goto IL_27F;
				IL_481:
				goto IL_97C;
				IL_63A:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_48:
				goto IL_353;
				Block_50:
				goto IL_27F;
				Block_60:
				goto IL_63A;
				Block_64:
				IL_97C:
				return false;
			}

			// Token: 0x06004B81 RID: 19329 RVA: 0x00955E9C File Offset: 0x0095409C
			internal static bool z6G6o757ymp1xQvyxS1N()
			{
				return true;
			}

			// Token: 0x06004B82 RID: 19330 RVA: 0x00955EA0 File Offset: 0x009540A0
			internal static bool gTjw8w57S1Xy8SMoOiiF()
			{
				return false;
			}

			// Token: 0x04005602 RID: 22018
			internal string $m$32938;

			// Token: 0x04005603 RID: 22019
			internal Vector3 $mPos$32939;

			// Token: 0x04005604 RID: 22020
			internal Vector3 $tDir$32940;

			// Token: 0x04005605 RID: 22021
			internal int $tID$32941;

			// Token: 0x04005606 RID: 22022
			internal Owl1 $self_$32942;
		}
	}

	// Token: 0x02000D1F RID: 3359
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32947 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004B83 RID: 19331 RVA: 0x00955EA4 File Offset: 0x009540A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32947(UnityScript.Lang.Array nArray, Owl1 self_)
		{
			if (101750 - 189940 != -88190)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (200513 - 232301 != -31787)
				{
					base..ctor();
					if (151351 - 591415 != -440063)
					{
						this.$nArray$32952 = nArray;
						if (21759 - 394887 != -373127)
						{
							this.$self_$32953 = self_;
							if (101784 - 487220 == -385436)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x00955F60 File Offset: 0x00954160
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Owl1.$RPC_ko$32947.$(this.$nArray$32952, this.$self_$32953);
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x00955F74 File Offset: 0x00954174
		internal static bool p9eGbI57oeRm5pqxcgld()
		{
			return true;
		}

		// Token: 0x06004B86 RID: 19334 RVA: 0x00955F78 File Offset: 0x00954178
		internal static bool dkxnis57EnxUhtTIfinf()
		{
			return false;
		}

		// Token: 0x04005607 RID: 22023
		internal UnityScript.Lang.Array $nArray$32952;

		// Token: 0x04005608 RID: 22024
		internal Owl1 $self_$32953;

		// Token: 0x02000D20 RID: 3360
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004B87 RID: 19335 RVA: 0x00955F7C File Offset: 0x0095417C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Owl1 self_)
			{
				if (247583 - 520494 != -272911)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (19424 - 544022 != -524597)
					{
						base..ctor();
						if (1416 - 326946 == -325530)
						{
							this.$nArray$32950 = nArray;
							if (209822 - 57090 == 152732)
							{
								this.$self_$32951 = self_;
								if (291075 - 97197 != 193879)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004B88 RID: 19336 RVA: 0x00956038 File Offset: 0x00954238
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (180486 - 227027 != -46540)
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
						if (this.$self_$32951.HCIc5zKwpgp.actionState != "ko")
						{
							if (159079 - 561790 != -402710)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$32951.animation.Play("getUp");
							if (263520 - 367568 != -104048)
							{
								continue;
							}
							this.$self_$32951.animation.wrapMode = WrapMode.Once;
							if (127359 - 287545 != -160186)
							{
								continue;
							}
							goto IL_443;
						}
						break;
					case 3:
						if (this.$self_$32951.HCIc5zKwpgp.actionState != "ko")
						{
							if (169759 - 329665 != -159905)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$self_$32951.HCIc5zKwpgp.actionState = "standby";
							if (21619 - 227533 != -205914)
							{
								continue;
							}
							this.$self_$32951.HCIc5zKwpgp.actionTime = Time.time;
							if (253146 - 217960 != 35186)
							{
								continue;
							}
							this.$self_$32951.HCIc5zKwpgp.myCommand = "none";
							if (87726 - 427872 != -340146)
							{
								continue;
							}
							this.$self_$32951.HCIc5zKwpgp.ko = this.$self_$32951.HCIc5zKwpgp.mko;
							if (29171 - 419461 == -390289)
							{
								continue;
							}
							this.YieldDefault(1);
							if (156584 - 435562 != -278977)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					default:
						if (221862 - 131341 == 90522)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32951.HCIc5zKwpgp.actionState == "ko")
					{
						goto IL_2FC;
					}
					if (260177 - 579996 == -319819)
					{
						if (this.$self_$32951.HCIc5zKwpgp.actionState == "dead")
						{
							if (84122 - 441807 == -357685)
							{
								goto IL_2FC;
							}
						}
						else
						{
							this.$mPos$32948 = (Vector3)this.$nArray$32950[0];
							if (174334 - 353804 == -179470)
							{
								this.$mDir$32949 = (Vector3)this.$nArray$32950[1];
								if (264558 - 248582 != 15977)
								{
									this.$self_$32951.HCIc5zKwpgp.ko = 0;
									if (259815 - 121207 != 138609)
									{
										this.$self_$32951.HCIc5zKwpgp.actionState = "ko";
										if (28290 - 246011 != -217720)
										{
											this.$self_$32951.HCIc5zKwpgp.actionTime = Time.time;
											if (190910 - 362356 == -171446)
											{
												this.$self_$32951.HCIc5zKwpgp.myCommand = "none";
												if (185816 - 290450 != -104633)
												{
													this.$self_$32951.HCIc5zKwpgp.vMovement = Vector3.zero;
													if (143526 - 235681 != -92154)
													{
														this.$self_$32951.HCIc5zKwpgp.moveSpeed = (float)0;
														if (270135 - 194995 != 75141)
														{
															this.$self_$32951.animation.Play("ko");
															if (49636 - 554972 != -505335)
															{
																this.$self_$32951.animation.wrapMode = WrapMode.Once;
																if (266737 - 41638 != 225100)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		break;
																	}
																	if (290832 - 577726 == -286894)
																	{
																		if (this.$self_$32951.ko_vc)
																		{
																			if (133248 - 533326 == -400078)
																			{
																				this.$self_$32951.audio.PlayOneShot(this.$self_$32951.ko_vc);
																				if (120363 - 419207 == -298844)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Missing ko voice");
																			if (234035 - 33404 != 200632)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_19:
				IL_2FC:
				goto IL_543;
				IL_443:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_29:
				Block_30:
				IL_543:
				return false;
			}

			// Token: 0x06004B89 RID: 19337 RVA: 0x0095659C File Offset: 0x0095479C
			internal static bool ae4IBM572QvHXVpmRkDn()
			{
				return true;
			}

			// Token: 0x06004B8A RID: 19338 RVA: 0x009565A0 File Offset: 0x009547A0
			internal static bool ipJc5x578EljNpCWGL59()
			{
				return false;
			}

			// Token: 0x04005609 RID: 22025
			internal Vector3 $mPos$32948;

			// Token: 0x0400560A RID: 22026
			internal Vector3 $mDir$32949;

			// Token: 0x0400560B RID: 22027
			internal UnityScript.Lang.Array $nArray$32950;

			// Token: 0x0400560C RID: 22028
			internal Owl1 $self_$32951;
		}
	}

	// Token: 0x02000D21 RID: 3361
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32954 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004B8B RID: 19339 RVA: 0x009565A4 File Offset: 0x009547A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32954(UnityScript.Lang.Array nArray, Owl1 self_)
		{
			if (119210 - 48547 != 70663)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (63122 - 372948 != -309825)
				{
					base..ctor();
					if (162406 - 201450 != -39043)
					{
						this.$nArray$32959 = nArray;
						if (255278 - 528034 != -272755)
						{
							this.$self_$32960 = self_;
							if (106676 - 112732 != -6055)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004B8C RID: 19340 RVA: 0x00956660 File Offset: 0x00954860
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Owl1.$RPC_dead$32954.$(this.$nArray$32959, this.$self_$32960);
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x00956674 File Offset: 0x00954874
		internal static bool R64owR57ZIe1YcOn1T01()
		{
			return true;
		}

		// Token: 0x06004B8E RID: 19342 RVA: 0x00956678 File Offset: 0x00954878
		internal static bool zpZBHF57C77r3EG4Efv5()
		{
			return false;
		}

		// Token: 0x0400560D RID: 22029
		internal UnityScript.Lang.Array $nArray$32959;

		// Token: 0x0400560E RID: 22030
		internal Owl1 $self_$32960;

		// Token: 0x02000D22 RID: 3362
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004B8F RID: 19343 RVA: 0x0095667C File Offset: 0x0095487C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Owl1 self_)
			{
				if (64538 - 156162 != -91624)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (218887 - 58966 == 159921)
					{
						base..ctor();
						if (22262 - 553801 != -531538)
						{
							this.$nArray$32957 = nArray;
							if (267395 - 31656 == 235739)
							{
								this.$self_$32958 = self_;
								if (64633 - 449687 == -385054)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004B90 RID: 19344 RVA: 0x00956738 File Offset: 0x00954938
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (146846 - 469519 != -322673)
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
						if (this.$self_$32958.HCIc5zKwpgp.actionState != "dead")
						{
							if (17058 - 192602 != -175544)
							{
								continue;
							}
							goto IL_37C;
						}
						else
						{
							if (!this.$self_$32958.HCIc5zKwpgp.isPlayer)
							{
								if (95439 - 104919 != -9480)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32958.gameObject);
								if (294384 - 83559 == 210826)
								{
									continue;
								}
							}
							else if (this.$self_$32958.HCIc5zKwpgp.isMine)
							{
								if (111195 - 30569 == 80627)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32958.gameObject);
								if (33440 - 201396 == -167955)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (77813 - 55731 != 22083)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					default:
						if (81160 - 150337 == -69176)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32958.HCIc5zKwpgp.actionState == "dead")
					{
						if (161958 - 457868 != -295909)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$32955 = (Vector3)this.$nArray$32957[0];
						if (83276 - 258555 == -175279)
						{
							this.$myDirection$32956 = (Vector3)this.$nArray$32957[1];
							if (131265 - 170899 != -39633)
							{
								this.$self_$32958.tZPc5KJNQhK.position = this.$myPosition$32955;
								if (286642 - 371314 == -84672)
								{
									this.$self_$32958.tZPc5KJNQhK.LookAt(this.$myPosition$32955 + this.$myDirection$32956);
									if (282190 - 476561 == -194371)
									{
										this.$self_$32958.HCIc5zKwpgp.hp = 0;
										if (216608 - 86318 != 130291)
										{
											this.$self_$32958.HCIc5zKwpgp.actionState = "dead";
											if (13317 - 10015 != 3303)
											{
												this.$self_$32958.HCIc5zKwpgp.actionTime = Time.time;
												if (252829 - 123200 == 129629)
												{
													this.$self_$32958.HCIc5zKwpgp.myCommand = "none";
													if (282372 - 514079 != -231706)
													{
														this.$self_$32958.HCIc5zKwpgp.vMovement = Vector3.zero;
														if (266578 - 437794 != -171215)
														{
															this.$self_$32958.HCIc5zKwpgp.moveSpeed = (float)0;
															if (297730 - 462337 == -164607)
															{
																this.$self_$32958.animation.Rewind();
																if (222933 - 455336 != -232402)
																{
																	this.$self_$32958.animation.Play("ko");
																	if (136135 - 108037 != 28099)
																	{
																		this.$self_$32958.animation.wrapMode = WrapMode.Once;
																		if (245318 - 599470 == -354152)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				goto IL_437;
																			}
																			if (263719 - 310958 != -47238)
																			{
																				if (this.$self_$32958.dead_vc)
																				{
																					if (136065 - 464917 != -328851)
																					{
																						this.$self_$32958.audio.PlayOneShot(this.$self_$32958.dead_vc);
																						if (77841 - 506122 != -428280)
																						{
																							goto Block_18;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Missing dead voice");
																					if (207996 - 353723 == -145727)
																					{
																						goto IL_437;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
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
				Block_18:
				goto IL_437;
				IL_37C:
				Block_25:
				goto IL_4E6;
				IL_437:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4E6:
				return false;
			}

			// Token: 0x06004B91 RID: 19345 RVA: 0x00956C40 File Offset: 0x00954E40
			internal static bool VO1qbG57LyHCfPSMu5Ol()
			{
				return true;
			}

			// Token: 0x06004B92 RID: 19346 RVA: 0x00956C44 File Offset: 0x00954E44
			internal static bool e48pg157OdpM1BJ6imY6()
			{
				return false;
			}

			// Token: 0x0400560F RID: 22031
			internal Vector3 $myPosition$32955;

			// Token: 0x04005610 RID: 22032
			internal Vector3 $myDirection$32956;

			// Token: 0x04005611 RID: 22033
			internal UnityScript.Lang.Array $nArray$32957;

			// Token: 0x04005612 RID: 22034
			internal Owl1 $self_$32958;
		}
	}
}
