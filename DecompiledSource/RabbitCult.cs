using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D7C RID: 3452
[Serializable]
public class RabbitCult : MonoBehaviour
{
	// Token: 0x06004DBC RID: 19900 RVA: 0x0099170C File Offset: 0x0098F90C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RabbitCult()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004DBD RID: 19901 RVA: 0x0099171C File Offset: 0x0098F91C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (212845 - 90148 != 122697)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (206276 - 5207 == 201069)
			{
				this.mChar.actionState = "standby";
				if (162434 - 50693 == 111741)
				{
					this.mChar.actionTime = Time.time;
					if (181949 - 569883 == -387934)
					{
						this.mChar.myCommand = "none";
						if (282042 - 281086 == 956)
						{
							this.mChar.hp = (this.mChar.mhp = 1050);
							if (187302 - 17293 == 170009)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004DBE RID: 19902 RVA: 0x00991840 File Offset: 0x0098FA40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (141793 - 431174 != -289381)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (82682 - 467753 == -385070)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (182126 - 411241 != -229115)
				{
					continue;
				}
			}
			if (Game.mGameCode != 934)
			{
				break;
			}
			if (111425 - 349606 == -238181)
			{
				if (this.mChar.ActorNr == 0)
				{
					break;
				}
				if (156355 - 271688 == -115333)
				{
					this.mChar.StartCoroutine_Auto(this.mChar.addStatus("darkRitual", 1, 999, 0, this.mChar.ActorNr));
					if (69053 - 517307 == -448254)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004DBF RID: 19903 RVA: 0x00991960 File Offset: 0x0098FB60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (194362 - 465543 != -271181)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (220468 - 450147 == -229678)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (193004 - 20949 == 172056)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_C2;
					}
					if (155029 - 426486 == -271456)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (230758 - 48336 == 182423)
				{
					continue;
				}
			}
			IL_C2:
			if (this.mChar.hp <= 0)
			{
				if (144804 - 559232 == -414427)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (246379 - 111553 == 134827)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (229298 - 530745 == -301446)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (93709 - 514160 == -420450)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (285866 - 11009 != 274857)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (275878 - 369569 != -93690)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (160920 - 130401 != 30520)
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
			if (7079 - 6874 == 205)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (76385 - 51061 != 25325)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (244937 - 538989 != -294051)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (124420 - 378742 == -254322)
						{
							if (this.mChar.isMine)
							{
								if (31420 - 37733 == -6313)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (30979 - 296304 != -265324)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (146894 - 67768 == 79126)
										{
											this.mChar.KoEvent();
											if (252912 - 241953 != 10960)
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
								if (19489 - 182728 != -163238)
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

	// Token: 0x06004DC0 RID: 19904 RVA: 0x00991D58 File Offset: 0x0098FF58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (142950 - 186569 != -43618)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (17187 - 352357 == -335170)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (168427 - 499118 != -330690)
				{
					if (201636 - 561334 == -359698)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (126003 - 166634 != -40631)
							{
								continue;
							}
							v = 1;
							if (24495 - 188354 != -163859)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (15590 - 79646 != -64056)
							{
								continue;
							}
							v = -1;
							if (151422 - 529194 != -377772)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_maimShot")
						{
							if (111195 - 245048 == -133852)
							{
								continue;
							}
							v = 11;
							if (93144 - 17259 != 75885)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_maimShot_hit")
						{
							if (162281 - 59653 == 102629)
							{
								continue;
							}
							v = -11;
							if (214795 - 551670 != -336875)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (132228 - 346775 == -214546)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (124565 - 431233 != -306667)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (120847 - 194243 == -73396)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (199195 - 118120 != 81076)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (44510 - 213117 != -168606)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (201047 - 197429 != 3619)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (178623 - 186314 != -7690)
											{
												Hashtable hashtable = new Hashtable();
												if (257927 - 82215 == 175712)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (36195 - 24519 == 11676)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (175721 - 345238 == -169517)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (153813 - 302453 != -148639)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (179529 - 46458 != 133072)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (188471 - 408940 == -220469)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (38179 - 79637 != -41457)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (154955 - 17112 != 137844)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (133777 - 88637 == 45140)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (175210 - 389442 != -214231)
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

	// Token: 0x06004DC1 RID: 19905 RVA: 0x00992270 File Offset: 0x00990470
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (60444 - 53908 != 6536)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (138073 - 535224 != -397150)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (253007 - 129605 == 123402)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (171105 - 279039 != -107933)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (114217 - 542939 != -428721)
						{
							int num3 = num;
							if (190129 - 288429 == -98300)
							{
								if (num3 == 1)
								{
									if (130521 - 147011 == -16490)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (31318 - 270716 == -239398)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (249607 - 5271 == 244336)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (248899 - 590798 != -341898)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (12678 - 582077 != -569398)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (97243 - 499565 == -402322)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (205749 - 84674 == 121075)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (104252 - 234187 == -129935)
										{
											this.StartCoroutine_Auto(this.RPC_maimShot(vector, vector2, num2));
											if (225828 - 101006 != 124823)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (238230 - 406084 != -167853)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (46006 - 442995 != -396988)
										{
											this.RPC_maimShot_hit(vector, vector2, num2);
											if (61263 - 5341 != 55923)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (181777 - 349662 == -167885)
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

	// Token: 0x06004DC2 RID: 19906 RVA: 0x009925F4 File Offset: 0x009907F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (21719 - 273999 != -252280)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (271175 - 412574 != -141398)
			{
				float runSpeed = this.mChar.runSpeed;
				if (228367 - 68522 == 159845)
				{
					Vector3 a = default(Vector3);
					if (282163 - 484261 == -202098)
					{
						Vector3 vector = Vector3.zero;
						if (173445 - 208431 != -34985)
						{
							float num2 = (float)0;
							if (234865 - 191653 != 43213)
							{
								if (this.mChar.isMine)
								{
									if (224882 - 111935 == 112948)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (269714 - 249420 == 20295)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (73697 - 360502 == -286804)
										{
											continue;
										}
										a.y = (float)0;
										if (71559 - 72614 != -1055)
										{
											continue;
										}
										a = a.normalized;
										if (153526 - 142404 == 11123)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (112932 - 565967 != -453035)
										{
											continue;
										}
										vector = vector.normalized;
										if (143664 - 545444 != -401780)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (196255 - 232657 != -36402)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (77260 - 79686 == -2425)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (51145 - 10218 == 40928)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (44232 - 95900 != -51668)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (194407 - 273898 != -79491)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (296540 - 262689 == 33852)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (172827 - 28486 != 144341)
														{
															continue;
														}
														this.animation.Play("run");
														if (213201 - 562770 != -349569)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (122090 - 394106 != -272016)
														{
															continue;
														}
														goto IL_A8F;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (2277 - 38218 != -35941)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (103829 - 501290 != -397461)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (215228 - 79192 != 136036)
											{
												continue;
											}
											num = (float)0;
											if (237645 - 129283 != 108362)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (159178 - 71254 == 87925)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (277041 - 454935 == -177893)
										{
											continue;
										}
									}
									IL_A8F:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (57254 - 357928 != -300674)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (2735 - 546056 != -543321)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (161335 - 92976 != 68359)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (159840 - 230693 == -70852)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (144177 - 521165 == -376987)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (201525 - 342003 != -140478)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (280941 - 586105 != -305164)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (190900 - 394501 == -203600)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (154373 - 51828 != 102545)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (70188 - 234112 == -163923)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (142885 - 237833 != -94948)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (161087 - 368882 == -207794)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (33604 - 88161 == -54556)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (200680 - 487995 != -287315)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (284666 - 375794 == -91127)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (74781 - 372828 != -298047)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (289509 - 174969 != 114540)
												{
													continue;
												}
												num = (float)0;
												if (180319 - 30675 == 149645)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (193965 - 466537 == -272571)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (154864 - 7897 == 146968)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (94113 - 531940 != -437827)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (298057 - 499913 == -201855)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (33732 - 223136 != -189404)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (260192 - 325822 != -65630)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (198401 - 173190 == 25212)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (19039 - 493002 != -473963)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (177455 - 294360 != -116905)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (14812 - 574883 == -560070)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (3812 - 38814 == -35001)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (68041 - 146176 != -78135)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (212147 - 562735 == -350587)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (276307 - 66481 == 209827)
											{
												continue;
											}
											num = (float)0;
											if (251493 - 296212 == -44718)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (116707 - 246323 != -129616)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (246956 - 22158 == 224799)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (212840 - 307976 != -95136)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (82588 - 36373 == 46216)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (235171 - 154816 == 80355)
								{
									this.mChar.moveSpeed = num;
									if (269168 - 155625 != 113544)
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

	// Token: 0x06004DC3 RID: 19907 RVA: 0x00993158 File Offset: 0x00991358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (249849 - 231687 != 18162)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (224694 - 484400 == -259706)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (101204 - 6023 != 95182)
				{
					Vector3 vector = a - this.transform.position;
					if (96135 - 543351 == -447216)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (47261 - 119468 != -72206)
						{
							CharacterControl characterControl = null;
							if (115882 - 545738 != -429855 && 273763 - 368027 != -94263)
							{
								if (gameObject)
								{
									if (27278 - 64010 != -36732)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (217971 - 350584 != -132613)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (106044 - 537557 != -431513)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (67665 - 336637 != -268972)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (159620 - 223065 != -63445)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (292645 - 519090 != -226445)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (105535 - 246725 == -141190)
								{
									if (!gameObject)
									{
										if (24479 - 141056 == -116576)
										{
											continue;
										}
										if (gameObject != this.gameObject)
										{
											if (148577 - 277340 == -128762)
											{
												continue;
											}
											Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
											if (249785 - 526418 == -276632)
											{
												continue;
											}
											if (vector2.sqrMagnitude < (float)4)
											{
												if (268852 - 6752 == 262101)
												{
													continue;
												}
												vector = (float)3 * global::Math.vFlat(vector).normalized + Vector3.up;
												if (283998 - 170699 == 113300)
												{
													continue;
												}
											}
										}
									}
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
									if (267136 - 495342 != -228205)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (58603 - 277873 != -219269)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
											if (292335 - 515262 != -222926)
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

	// Token: 0x06004DC4 RID: 19908 RVA: 0x00993538 File Offset: 0x00991738
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (236816 - 542839 != -306023)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (289328 - 351575 != -62246)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (134454 - 375646 == -241192)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (182150 - 21950 != 160201)
					{
						Vector3 normalized = vector.normalized;
						if (142458 - 358651 == -216193)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (268859 - 60392 != 208468)
							{
								CharacterControl characterControl = null;
								if (245720 - 222971 == 22749)
								{
									if (31521 - 449377 != -417855)
									{
										if (gameObject)
										{
											if (21035 - 87351 != -66316)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (153203 - 22765 == 130439)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (71269 - 234282 == -163012)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (233618 - 268002 != -34384)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (168640 - 366496 != -197856)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (191242 - 256884 == -65641)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (283662 - 517549 != -233886)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (279826 - 237284 != 42543)
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

	// Token: 0x06004DC5 RID: 19909 RVA: 0x00993804 File Offset: 0x00991A04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004DC6 RID: 19910 RVA: 0x00993808 File Offset: 0x00991A08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RabbitCult.$RPC_nAttack$33321(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004DC7 RID: 19911 RVA: 0x00993818 File Offset: 0x00991A18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (266570 - 397661 != -131091)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (176354 - 444137 != -267782)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (259176 - 384157 != -124980)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit Effect");
				if (103708 - 476670 == -372962)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004DC8 RID: 19912 RVA: 0x009938D8 File Offset: 0x00991AD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_maimShot(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RabbitCult.$RPC_maimShot$33336(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004DC9 RID: 19913 RVA: 0x009938E8 File Offset: 0x00991AE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_maimShot_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (155715 - 144436 != 11279)
		{
		}
		for (;;)
		{
			if (this.maimShot_hit)
			{
				if (251652 - 203070 == 48582)
				{
					UnityEngine.Object.Instantiate(this.maimShot_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (195267 - 305239 != -109971)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find maimShot_hit Effect");
				if (240470 - 253478 == -13008)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004DCA RID: 19914 RVA: 0x009939A0 File Offset: 0x00991BA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new RabbitCult.$RPC_ko$33354(nArray, this).GetEnumerator();
	}

	// Token: 0x06004DCB RID: 19915 RVA: 0x009939B0 File Offset: 0x00991BB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new RabbitCult.$RPC_dead$33361(nArray, this).GetEnumerator();
	}

	// Token: 0x06004DCC RID: 19916 RVA: 0x009939C0 File Offset: 0x00991BC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004DCD RID: 19917 RVA: 0x009939C4 File Offset: 0x00991BC4
	internal static bool svcOM55boVm49hDkdm6G()
	{
		return true;
	}

	// Token: 0x06004DCE RID: 19918 RVA: 0x009939C8 File Offset: 0x00991BC8
	internal static bool zPZOrO5bEYglVXpHq8ns()
	{
		return false;
	}

	// Token: 0x040057DB RID: 22491
	public CharacterControl mChar;

	// Token: 0x040057DC RID: 22492
	public GameObject nAttack_fire;

	// Token: 0x040057DD RID: 22493
	public GameObject nAttack_hit;

	// Token: 0x040057DE RID: 22494
	public GameObject maimShot_fire;

	// Token: 0x040057DF RID: 22495
	public GameObject maimShot_hit;

	// Token: 0x02000D7D RID: 3453
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33321 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004DCF RID: 19919 RVA: 0x009939CC File Offset: 0x00991BCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33321(Vector3 mPos, Vector3 tDir, RabbitCult self_)
		{
			if (296859 - 427747 != -130887)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (272831 - 362426 != -89594)
				{
					base..ctor();
					if (54781 - 185326 != -130544)
					{
						this.$mPos$33333 = mPos;
						if (47934 - 599644 == -551710)
						{
							this.$tDir$33334 = tDir;
							if (105212 - 175266 != -70053)
							{
								this.$self_$33335 = self_;
								if (205052 - 429416 != -224363)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004DD0 RID: 19920 RVA: 0x00993AA8 File Offset: 0x00991CA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RabbitCult.$RPC_nAttack$33321.$(this.$mPos$33333, this.$tDir$33334, this.$self_$33335);
		}

		// Token: 0x06004DD1 RID: 19921 RVA: 0x00993AC4 File Offset: 0x00991CC4
		internal static bool gsCtax5b2bUEBBE016Z8()
		{
			return true;
		}

		// Token: 0x06004DD2 RID: 19922 RVA: 0x00993AC8 File Offset: 0x00991CC8
		internal static bool linQRk5b8q0so39sgsNH()
		{
			return false;
		}

		// Token: 0x040057E0 RID: 22496
		internal Vector3 $mPos$33333;

		// Token: 0x040057E1 RID: 22497
		internal Vector3 $tDir$33334;

		// Token: 0x040057E2 RID: 22498
		internal RabbitCult $self_$33335;

		// Token: 0x02000D7E RID: 3454
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004DD3 RID: 19923 RVA: 0x00993ACC File Offset: 0x00991CCC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RabbitCult self_)
			{
				if (55027 - 442354 != -387326)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (100497 - 494264 == -393767)
					{
						base..ctor();
						if (56797 - 249770 == -192973)
						{
							this.$mPos$33330 = mPos;
							if (264459 - 257362 == 7097)
							{
								this.$tDir$33331 = tDir;
								if (66684 - 432736 == -366052)
								{
									this.$self_$33332 = self_;
									if (124139 - 254058 == -129919)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004DD4 RID: 19924 RVA: 0x00993BA8 File Offset: 0x00991DA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (54950 - 515866 != -460916)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A01;
					case 2:
						if (this.$self_$33332.mChar.actionState != "attack")
						{
							goto IL_67B;
						}
						if (134791 - 263223 != -128432)
						{
							continue;
						}
						if (this.$self_$33332.mChar.myCommand != "nAttack")
						{
							if (260388 - 303832 != -43444)
							{
								continue;
							}
							goto IL_67B;
						}
						else
						{
							this.$firePos$33322 = this.$mPos$33330 + Vector3.up + this.$self_$33332.transform.forward;
							if (161535 - 452317 != -290782)
							{
								continue;
							}
							this.$fireDir$33323 = this.$tDir$33331 - Vector3.up;
							if (8718 - 113390 == -104671)
							{
								continue;
							}
							this.$fireRot$33324 = Quaternion.LookRotation(this.$fireDir$33323);
							if (254473 - 214611 == 39863)
							{
								continue;
							}
							if (this.$self_$33332.nAttack_fire)
							{
								if (68642 - 501925 == -433282)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$33332.nAttack_fire, this.$firePos$33322, this.$fireRot$33324);
								if (111100 - 592048 == -480947)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find nAttack_fire Effect");
								if (78910 - 259437 == -180526)
								{
									continue;
								}
							}
							if (!this.$self_$33332.mChar.isMine)
							{
								goto IL_1A;
							}
							if (246319 - 75157 == 171163)
							{
								continue;
							}
							this.$hitLayer$33325 = ~((1 << this.$self_$33332.gameObject.layer) + 2 + 4);
							if (194979 - 595903 != -400924)
							{
								continue;
							}
							this.$hit$33326 = default(RaycastHit);
							if (549 - 394154 == -393604)
							{
								continue;
							}
							if (!Physics.Raycast(this.$firePos$33322, this.$fireDir$33323, out this.$hit$33326, (float)32, this.$hitLayer$33325))
							{
								goto IL_1A;
							}
							if (175853 - 204161 == -28307)
							{
								continue;
							}
							this.$self_$33332.RPC_nAttack_hit(this.$hit$33326.point, this.$self_$33332.transform.forward, 0);
							if (194118 - 182079 != 12039)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (22996 - 360201 != -337205)
								{
									continue;
								}
								this.$self_$33332.ActionEvent("RPC_nAttack_hit", this.$hit$33326.point, this.$self_$33332.transform.forward, 0);
								if (18417 - 525314 != -506897)
								{
									continue;
								}
							}
							this.$hitObject$33327 = this.$hit$33326.collider.gameObject;
							if (68590 - 335428 == -266837)
							{
								continue;
							}
							if (!this.$hitObject$33327)
							{
								goto IL_1A;
							}
							if (171661 - 353701 == -182039)
							{
								continue;
							}
							this.$mDistance$33328 = Mathf.FloorToInt(global::Math.vFlat(this.$self_$33332.transform.position - this.$hit$33326.point).magnitude);
							if (270541 - 400818 != -130277)
							{
								continue;
							}
							this.$mHyperShotDmg$33329 = 0;
							if (144837 - 282218 == -137380)
							{
								continue;
							}
							if (this.$mDistance$33328 > 16)
							{
								if (265386 - 209912 != 55474)
								{
									continue;
								}
								this.$mHyperShotDmg$33329 = Mathf.FloorToInt((float)((this.$mDistance$33328 - 16) * 2));
								if (248666 - 307769 == -59102)
								{
									continue;
								}
							}
							if (this.$self_$33332.mChar.hit(1, this.$hitObject$33327, this.$self_$33332.mChar.atk + this.$mHyperShotDmg$33329, 1, 0, global::Math.vFlat(this.$fireDir$33323.normalized)) == 0)
							{
								goto IL_1A;
							}
							if (92958 - 47507 == 45452)
							{
								continue;
							}
							this.$self_$33332.mChar.sp = this.$self_$33332.mChar.sp + 1;
							if (160105 - 189799 != -29693)
							{
								goto Block_50;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33332.mChar.actionState != "attack")
						{
							goto IL_2A5;
						}
						if (137713 - 2115 == 135599)
						{
							continue;
						}
						if (this.$self_$33332.mChar.myCommand != "nAttack")
						{
							if (74507 - 198011 != -123504)
							{
								continue;
							}
							goto IL_2A5;
						}
						else
						{
							this.$self_$33332.mChar.moveSpeed = (float)0;
							if (16172 - 338353 != -322180)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$33332.mChar.actionState == "attack")
						{
							if (224023 - 500012 == -275988)
							{
								continue;
							}
							if (this.$self_$33332.mChar.myCommand == "nAttack")
							{
								if (192904 - 187472 != 5432)
								{
									continue;
								}
								this.$self_$33332.mChar.actionState = "standby";
								if (110330 - 71214 == 39117)
								{
									continue;
								}
								this.$self_$33332.mChar.actionTime = Time.time;
								if (130637 - 1240 != 129397)
								{
									continue;
								}
								this.$self_$33332.mChar.myCommand = "none";
								if (100603 - 550792 == -450188)
								{
									continue;
								}
								if (!this.$self_$33332.mChar.isMine)
								{
									if (95572 - 487146 != -391574)
									{
										continue;
									}
									this.$self_$33332.mChar.nPosition = this.$self_$33332.transform.position;
									if (254215 - 584049 == -329833)
									{
										continue;
									}
									this.$self_$33332.mChar.oPosition = this.$self_$33332.transform.position;
									if (86628 - 528397 != -441769)
									{
										continue;
									}
									this.$self_$33332.mChar.nDirection = this.$self_$33332.transform.forward;
									if (189806 - 325098 != -135292)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (235372 - 503141 != -267769)
						{
							continue;
						}
						goto IL_A01;
					default:
						if (227292 - 485473 == -258180)
						{
							continue;
						}
						break;
					}
					this.$self_$33332.mChar.actionState = "attack";
					if (36664 - 285828 == -249164)
					{
						this.$self_$33332.mChar.actionTime = Time.time;
						if (77731 - 53244 == 24487)
						{
							this.$self_$33332.mChar.myCommand = "nAttack";
							if (282682 - 48478 == 234204)
							{
								this.$self_$33332.mChar.addTimeOut("nAttack", (float)4);
								if (137141 - 156328 == -19187)
								{
									this.$self_$33332.transform.position = this.$mPos$33330;
									if (49023 - 236706 != -187682)
									{
										this.$self_$33332.transform.LookAt(this.$mPos$33330 + global::Math.vFlat(this.$tDir$33331));
										if (172837 - 37895 == 134942)
										{
											this.$self_$33332.mChar.vMovement = this.$self_$33332.transform.forward;
											if (93915 - 85366 == 8549)
											{
												this.$self_$33332.mChar.moveSpeed = (float)0;
												if (45127 - 204664 != -159536)
												{
													this.$self_$33332.animation.Play("nAttack");
													if (168832 - 385650 != -216817)
													{
														this.$self_$33332.animation.wrapMode = WrapMode.Once;
														if (8791 - 18723 != -9931)
														{
															goto Block_8;
														}
													}
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
				return this.Yield(3, new WaitForSeconds(0.15f));
				Block_8:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_2A5:
				goto IL_A01;
				Block_16:
				return this.Yield(4, new WaitForSeconds(0.34f));
				IL_67B:
				goto IL_A01;
				Block_50:
				goto IL_1A;
				IL_A01:
				return false;
			}

			// Token: 0x06004DD5 RID: 19925 RVA: 0x009945C8 File Offset: 0x009927C8
			internal static bool kieKW35bZmcGDtByTnma()
			{
				return true;
			}

			// Token: 0x06004DD6 RID: 19926 RVA: 0x009945CC File Offset: 0x009927CC
			internal static bool EZm8805bCJSkLJoSRZBs()
			{
				return false;
			}

			// Token: 0x040057E3 RID: 22499
			internal Vector3 $firePos$33322;

			// Token: 0x040057E4 RID: 22500
			internal Vector3 $fireDir$33323;

			// Token: 0x040057E5 RID: 22501
			internal Quaternion $fireRot$33324;

			// Token: 0x040057E6 RID: 22502
			internal int $hitLayer$33325;

			// Token: 0x040057E7 RID: 22503
			internal RaycastHit $hit$33326;

			// Token: 0x040057E8 RID: 22504
			internal GameObject $hitObject$33327;

			// Token: 0x040057E9 RID: 22505
			internal int $mDistance$33328;

			// Token: 0x040057EA RID: 22506
			internal int $mHyperShotDmg$33329;

			// Token: 0x040057EB RID: 22507
			internal Vector3 $mPos$33330;

			// Token: 0x040057EC RID: 22508
			internal Vector3 $tDir$33331;

			// Token: 0x040057ED RID: 22509
			internal RabbitCult $self_$33332;
		}
	}

	// Token: 0x02000D7F RID: 3455
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_maimShot$33336 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004DD7 RID: 19927 RVA: 0x009945D0 File Offset: 0x009927D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_maimShot$33336(Vector3 mPos, Vector3 tDir, int tID, RabbitCult self_)
		{
			if (140527 - 56874 != 83654)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (46349 - 14016 == 32333)
				{
					base..ctor();
					if (165151 - 453451 != -288299)
					{
						this.$mPos$33350 = mPos;
						if (297005 - 74502 != 222504)
						{
							this.$tDir$33351 = tDir;
							if (179754 - 550911 != -371156)
							{
								this.$tID$33352 = tID;
								if (97112 - 498757 == -401645)
								{
									this.$self_$33353 = self_;
									if (220271 - 69979 != 150293)
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

		// Token: 0x06004DD8 RID: 19928 RVA: 0x009946D0 File Offset: 0x009928D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RabbitCult.$RPC_maimShot$33336.$(this.$mPos$33350, this.$tDir$33351, this.$tID$33352, this.$self_$33353);
		}

		// Token: 0x06004DD9 RID: 19929 RVA: 0x009946F0 File Offset: 0x009928F0
		internal static bool DklJYm5bLAjDS5c48DVg()
		{
			return true;
		}

		// Token: 0x06004DDA RID: 19930 RVA: 0x009946F4 File Offset: 0x009928F4
		internal static bool dX03fh5bOOQ4LkZ0MGHS()
		{
			return false;
		}

		// Token: 0x040057EE RID: 22510
		internal Vector3 $mPos$33350;

		// Token: 0x040057EF RID: 22511
		internal Vector3 $tDir$33351;

		// Token: 0x040057F0 RID: 22512
		internal int $tID$33352;

		// Token: 0x040057F1 RID: 22513
		internal RabbitCult $self_$33353;

		// Token: 0x02000D80 RID: 3456
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004DDB RID: 19931 RVA: 0x009946F8 File Offset: 0x009928F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, RabbitCult self_)
			{
				if (106844 - 150538 != -43694)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (90862 - 270382 == -179520)
					{
						base..ctor();
						if (58496 - 126037 == -67541)
						{
							this.$mPos$33346 = mPos;
							if (92264 - 99485 == -7221)
							{
								this.$tDir$33347 = tDir;
								if (45404 - 425610 != -380205)
								{
									this.$tID$33348 = tID;
									if (73813 - 561338 != -487524)
									{
										this.$self_$33349 = self_;
										if (24675 - 486954 == -462279)
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

			// Token: 0x06004DDC RID: 19932 RVA: 0x009947F8 File Offset: 0x009929F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (59495 - 475683 != -416188)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C61;
					case 2:
						if (this.$self_$33349.mChar.actionState != "attack")
						{
							goto IL_719;
						}
						if (54743 - 199752 != -145009)
						{
							continue;
						}
						if (this.$self_$33349.mChar.myCommand != "maimShot")
						{
							if (127826 - 573689 != -445862)
							{
								goto Block_47;
							}
							continue;
						}
						else
						{
							this.$self_$33349.mChar.moveSpeed = (float)-1;
							if (262193 - 44440 == 217754)
							{
								continue;
							}
							this.$firePos$33338 = this.$mPos$33346 + Vector3.up;
							if (103129 - 261653 != -158524)
							{
								continue;
							}
							this.$fireDir$33339 = this.$tDir$33347 - Vector3.up;
							if (133443 - 77292 != 56151)
							{
								continue;
							}
							if (this.$tObject$33337)
							{
								if (265385 - 243761 == 21625)
								{
									continue;
								}
								this.$fireDir$33339 = this.$tObject$33337.collider.bounds.center - this.$mPos$33346 - Vector3.up;
								if (221024 - 556518 != -335494)
								{
									continue;
								}
							}
							this.$fireRot$33340 = Quaternion.FromToRotation(Vector3.forward, this.$fireDir$33339);
							if (70898 - 211671 != -140773)
							{
								continue;
							}
							if (this.$self_$33349.maimShot_fire)
							{
								if (125019 - 396531 == -271511)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$33349.maimShot_fire, this.$firePos$33338, this.$fireRot$33340);
								if (245832 - 478490 != -232657)
								{
									goto Block_38;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find maimShot_fire Effect");
								if (289478 - 41216 != 248263)
								{
									goto Block_10;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$33349.mChar.actionState != "attack")
						{
							goto IL_1B3;
						}
						if (215968 - 231674 != -15706)
						{
							continue;
						}
						if (this.$self_$33349.mChar.myCommand != "maimShot")
						{
							if (181008 - 272342 != -91334)
							{
								continue;
							}
							goto IL_1B3;
						}
						else
						{
							if (!this.$self_$33349.mChar.isMine)
							{
								goto IL_CB;
							}
							if (10793 - 143937 != -133144)
							{
								continue;
							}
							this.$hitLayer$33341 = ~((1 << this.$self_$33349.gameObject.layer) + 2 + 4);
							if (171005 - 127246 != 43759)
							{
								continue;
							}
							this.$hit$33342 = default(RaycastHit);
							if (111478 - 394815 == -283336)
							{
								continue;
							}
							if (!Physics.Raycast(this.$firePos$33338, this.$fireDir$33339, out this.$hit$33342, (float)32, this.$hitLayer$33341))
							{
								goto IL_CB;
							}
							if (100431 - 30990 != 69441)
							{
								continue;
							}
							this.$self_$33349.RPC_nAttack_hit(this.$hit$33342.point, this.$self_$33349.transform.forward, 0);
							if (40752 - 551301 == -510548)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (236251 - 524783 == -288531)
								{
									continue;
								}
								this.$self_$33349.ActionEvent("RPC_nAttack_hit", this.$hit$33342.point, this.$self_$33349.transform.forward, 0);
								if (58515 - 127998 != -69483)
								{
									continue;
								}
							}
							this.$hitObject$33343 = this.$hit$33342.collider.gameObject;
							if (35244 - 208042 != -172798)
							{
								continue;
							}
							if (this.$self_$33349.mChar.hit(11, this.$hitObject$33343, (int)(0.5f * (float)this.$self_$33349.mChar.atk + (float)this.$self_$33349.mChar.talAdjust(20)), 1, 0, global::Math.vFlat(this.$fireDir$33339.normalized)) == 0)
							{
								goto IL_CB;
							}
							if (210325 - 128405 != 81920)
							{
								continue;
							}
							this.$self_$33349.RPC_maimShot_hit(this.$hit$33342.point, this.$self_$33349.transform.forward, 0);
							if (296545 - 368552 == -72006)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (39711 - 426698 != -386987)
								{
									continue;
								}
								this.$self_$33349.ActionEvent("RPC_maimShot_hit", this.$hit$33342.point, this.$self_$33349.transform.forward, 0);
								if (97540 - 249004 != -151464)
								{
									continue;
								}
							}
							this.$tChar$33344 = (CharacterControl)this.$hitObject$33343.GetComponent(typeof(CharacterControl));
							if (90438 - 599531 != -509093)
							{
								continue;
							}
							this.$mDuration$33345 = Damage.getDebuff((float)3, this.$self_$33349.mChar.cha, this.$tChar$33344.cha);
							if (159004 - 409343 == -250338)
							{
								continue;
							}
							if (!this.$tChar$33344)
							{
								goto IL_CB;
							}
							if (268714 - 65519 == 203196)
							{
								continue;
							}
							this.$tChar$33344.RPC_AddStatus("maim", 4, this.$mDuration$33345, 0, this.$self_$33349.mChar.ActorNr);
							if (170351 - 57087 != 113264)
							{
								continue;
							}
							goto IL_CB;
						}
						break;
					case 4:
						if (this.$self_$33349.mChar.actionState != "attack")
						{
							goto IL_B16;
						}
						if (33802 - 230382 != -196580)
						{
							continue;
						}
						if (this.$self_$33349.mChar.myCommand != "maimShot")
						{
							if (119394 - 434019 != -314625)
							{
								continue;
							}
							goto IL_B16;
						}
						else
						{
							this.$self_$33349.mChar.moveSpeed = (float)0;
							if (123084 - 67335 != 55749)
							{
								continue;
							}
							goto IL_335;
						}
						break;
					case 5:
						if (this.$self_$33349.mChar.actionState == "attack")
						{
							if (211115 - 367824 != -156709)
							{
								continue;
							}
							if (this.$self_$33349.mChar.myCommand == "maimShot")
							{
								if (123247 - 552381 == -429133)
								{
									continue;
								}
								this.$self_$33349.mChar.moveSpeed = (float)0;
								if (213667 - 306209 != -92542)
								{
									continue;
								}
								this.$self_$33349.mChar.actionState = "standby";
								if (45512 - 119462 == -73949)
								{
									continue;
								}
								this.$self_$33349.mChar.actionTime = Time.time;
								if (157310 - 44353 != 112957)
								{
									continue;
								}
								this.$self_$33349.mChar.myCommand = "none";
								if (7602 - 244354 != -236752)
								{
									continue;
								}
								if (!this.$self_$33349.mChar.isMine)
								{
									if (225136 - 82230 == 142907)
									{
										continue;
									}
									this.$self_$33349.mChar.nPosition = this.$self_$33349.transform.position;
									if (42342 - 20763 == 21580)
									{
										continue;
									}
									this.$self_$33349.mChar.oPosition = this.$self_$33349.transform.position;
									if (123066 - 157732 != -34666)
									{
										continue;
									}
									this.$self_$33349.mChar.nDirection = this.$self_$33349.transform.forward;
									if (11401 - 156851 != -145450)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (124562 - 430854 != -306291)
						{
							goto Block_15;
						}
						continue;
					default:
						if (158704 - 369921 != -211217)
						{
							continue;
						}
						break;
					}
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$33348];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$33337 = (GameObject)obj2;
					if (271067 - 32141 == 238926)
					{
						if (!this.$tObject$33337)
						{
							if (126973 - 580692 != -453718)
							{
								goto Block_75;
							}
						}
						else
						{
							this.$self_$33349.mChar.actionState = "attack";
							if (214014 - 51441 != 162574)
							{
								this.$self_$33349.mChar.actionTime = Time.time;
								if (264795 - 204015 == 60780)
								{
									this.$self_$33349.mChar.myCommand = "maimShot";
									if (299011 - 425694 == -126683)
									{
										this.$self_$33349.mChar.addTimeOut("maimShot", this.$self_$33349.mChar.agiAdjust((float)30));
										if (14172 - 480568 == -466396)
										{
											this.$self_$33349.transform.position = this.$mPos$33346;
											if (53281 - 528501 != -475219)
											{
												this.$self_$33349.transform.LookAt(this.$mPos$33346 + global::Math.vFlat(this.$tDir$33347));
												if (56202 - 449086 != -392883)
												{
													this.$self_$33349.animation.CrossFade("maim", 0.2f);
													if (16585 - 328588 == -312003)
													{
														this.$self_$33349.animation.wrapMode = WrapMode.Once;
														if (93620 - 281529 == -187909)
														{
															this.$self_$33349.mChar.vMovement = this.$self_$33349.transform.forward;
															if (59759 - 227494 != -167734)
															{
																this.$self_$33349.mChar.moveSpeed = (float)0;
																if (278406 - 101196 == 177210)
																{
																	goto IL_5B4;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_CB:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_10:
				goto IL_4E8;
				IL_1B3:
				Block_15:
				goto IL_C61;
				IL_335:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_4E8:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_38:
				goto IL_4E8;
				IL_5B4:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_47:
				IL_719:
				IL_B16:
				Block_75:
				IL_C61:
				return false;
			}

			// Token: 0x06004DDD RID: 19933 RVA: 0x00995478 File Offset: 0x00993678
			internal static bool MslxBF5bmHBe3TivdCDA()
			{
				return true;
			}

			// Token: 0x06004DDE RID: 19934 RVA: 0x0099547C File Offset: 0x0099367C
			internal static bool yQe5st5bFqccjsymb5aI()
			{
				return false;
			}

			// Token: 0x040057F2 RID: 22514
			internal GameObject $tObject$33337;

			// Token: 0x040057F3 RID: 22515
			internal Vector3 $firePos$33338;

			// Token: 0x040057F4 RID: 22516
			internal Vector3 $fireDir$33339;

			// Token: 0x040057F5 RID: 22517
			internal Quaternion $fireRot$33340;

			// Token: 0x040057F6 RID: 22518
			internal int $hitLayer$33341;

			// Token: 0x040057F7 RID: 22519
			internal RaycastHit $hit$33342;

			// Token: 0x040057F8 RID: 22520
			internal GameObject $hitObject$33343;

			// Token: 0x040057F9 RID: 22521
			internal CharacterControl $tChar$33344;

			// Token: 0x040057FA RID: 22522
			internal int $mDuration$33345;

			// Token: 0x040057FB RID: 22523
			internal Vector3 $mPos$33346;

			// Token: 0x040057FC RID: 22524
			internal Vector3 $tDir$33347;

			// Token: 0x040057FD RID: 22525
			internal int $tID$33348;

			// Token: 0x040057FE RID: 22526
			internal RabbitCult $self_$33349;
		}
	}

	// Token: 0x02000D81 RID: 3457
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33354 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004DDF RID: 19935 RVA: 0x00995480 File Offset: 0x00993680
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33354(UnityScript.Lang.Array nArray, RabbitCult self_)
		{
			if (160480 - 478870 != -318389)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (270599 - 535994 == -265395)
				{
					base..ctor();
					if (265112 - 182834 == 82278)
					{
						this.$nArray$33359 = nArray;
						if (46921 - 72151 != -25229)
						{
							this.$self_$33360 = self_;
							if (262086 - 392767 != -130680)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004DE0 RID: 19936 RVA: 0x0099553C File Offset: 0x0099373C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RabbitCult.$RPC_ko$33354.$(this.$nArray$33359, this.$self_$33360);
		}

		// Token: 0x06004DE1 RID: 19937 RVA: 0x00995550 File Offset: 0x00993750
		internal static bool S0e1yw5bMTHY108a8u2T()
		{
			return true;
		}

		// Token: 0x06004DE2 RID: 19938 RVA: 0x00995554 File Offset: 0x00993754
		internal static bool c0x9GV5bxdEyUSvBfjRQ()
		{
			return false;
		}

		// Token: 0x040057FF RID: 22527
		internal UnityScript.Lang.Array $nArray$33359;

		// Token: 0x04005800 RID: 22528
		internal RabbitCult $self_$33360;

		// Token: 0x02000D82 RID: 3458
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004DE3 RID: 19939 RVA: 0x00995558 File Offset: 0x00993758
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, RabbitCult self_)
			{
				if (228504 - 347357 != -118852)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (129130 - 153990 != -24859)
					{
						base..ctor();
						if (138120 - 342355 != -204234)
						{
							this.$nArray$33357 = nArray;
							if (226665 - 196637 != 30029)
							{
								this.$self_$33358 = self_;
								if (166041 - 42581 != 123461)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004DE4 RID: 19940 RVA: 0x00995614 File Offset: 0x00993814
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (4218 - 177559 != -173340)
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
						if (this.$self_$33358.mChar.actionState != "ko")
						{
							if (204842 - 346525 != -141682)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$self_$33358.animation.Play("getUp");
							if (169705 - 213877 == -44171)
							{
								continue;
							}
							this.$self_$33358.animation.wrapMode = WrapMode.Once;
							if (82677 - 190997 != -108319)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33358.mChar.actionState != "ko")
						{
							if (216319 - 347275 != -130955)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							this.$self_$33358.mChar.actionState = "standby";
							if (50591 - 106812 == -56220)
							{
								continue;
							}
							this.$self_$33358.mChar.actionTime = Time.time;
							if (128839 - 56700 != 72139)
							{
								continue;
							}
							this.$self_$33358.mChar.myCommand = "none";
							if (176836 - 264785 != -87949)
							{
								continue;
							}
							this.$self_$33358.mChar.ko = this.$self_$33358.mChar.mko;
							if (161939 - 95866 != 66073)
							{
								continue;
							}
							this.YieldDefault(1);
							if (24224 - 70709 != -46485)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (231962 - 26070 == 205893)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33358.mChar.actionState == "ko")
					{
						goto IL_22A;
					}
					if (162424 - 464240 != -301815)
					{
						if (this.$self_$33358.mChar.actionState == "dead")
						{
							if (287181 - 408126 != -120944)
							{
								goto Block_17;
							}
						}
						else
						{
							this.$mPos$33355 = (Vector3)this.$nArray$33357[0];
							if (57152 - 434757 == -377605)
							{
								this.$mDir$33356 = (Vector3)this.$nArray$33357[1];
								if (48237 - 116361 != -68123)
								{
									this.$self_$33358.mChar.ko = 0;
									if (288112 - 339064 != -50951)
									{
										this.$self_$33358.mChar.actionState = "ko";
										if (77827 - 260911 == -183084)
										{
											this.$self_$33358.mChar.actionTime = Time.time;
											if (281861 - 598208 == -316347)
											{
												this.$self_$33358.mChar.myCommand = "none";
												if (6176 - 509556 != -503379)
												{
													this.$self_$33358.mChar.vMovement = Vector3.zero;
													if (55813 - 3574 == 52239)
													{
														this.$self_$33358.mChar.moveSpeed = (float)0;
														if (34608 - 129246 == -94638)
														{
															this.$self_$33358.animation.Play("ko");
															if (276904 - 419058 != -142153)
															{
																this.$self_$33358.animation.wrapMode = WrapMode.Once;
																if (148719 - 459753 == -311034)
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
				Block_4:
				IL_22A:
				goto IL_48C;
				Block_17:
				goto IL_22A;
				Block_19:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_26:
				IL_48C:
				return false;
			}

			// Token: 0x06004DE5 RID: 19941 RVA: 0x00995AC0 File Offset: 0x00993CC0
			internal static bool wX3blF5bggUGTRGpkx6U()
			{
				return true;
			}

			// Token: 0x06004DE6 RID: 19942 RVA: 0x00995AC4 File Offset: 0x00993CC4
			internal static bool OSHCRU5bfOI148sDL96F()
			{
				return false;
			}

			// Token: 0x04005801 RID: 22529
			internal Vector3 $mPos$33355;

			// Token: 0x04005802 RID: 22530
			internal Vector3 $mDir$33356;

			// Token: 0x04005803 RID: 22531
			internal UnityScript.Lang.Array $nArray$33357;

			// Token: 0x04005804 RID: 22532
			internal RabbitCult $self_$33358;
		}
	}

	// Token: 0x02000D83 RID: 3459
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33361 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004DE7 RID: 19943 RVA: 0x00995AC8 File Offset: 0x00993CC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33361(UnityScript.Lang.Array nArray, RabbitCult self_)
		{
			if (41035 - 568384 != -527349)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (149930 - 296752 != -146821)
				{
					base..ctor();
					if (197792 - 192519 == 5273)
					{
						this.$nArray$33366 = nArray;
						if (174007 - 297921 == -123914)
						{
							this.$self_$33367 = self_;
							if (93706 - 148409 != -54702)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004DE8 RID: 19944 RVA: 0x00995B84 File Offset: 0x00993D84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RabbitCult.$RPC_dead$33361.$(this.$nArray$33366, this.$self_$33367);
		}

		// Token: 0x06004DE9 RID: 19945 RVA: 0x00995B98 File Offset: 0x00993D98
		internal static bool PVfNA05bnh2k2uD3WTu7()
		{
			return true;
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x00995B9C File Offset: 0x00993D9C
		internal static bool NkAT3m5b6QVwJZeqoU5c()
		{
			return false;
		}

		// Token: 0x04005805 RID: 22533
		internal UnityScript.Lang.Array $nArray$33366;

		// Token: 0x04005806 RID: 22534
		internal RabbitCult $self_$33367;

		// Token: 0x02000D84 RID: 3460
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004DEB RID: 19947 RVA: 0x00995BA0 File Offset: 0x00993DA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, RabbitCult self_)
			{
				if (116339 - 541081 != -424742)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (219175 - 556100 == -336925)
					{
						base..ctor();
						if (245441 - 205867 == 39574)
						{
							this.$nArray$33364 = nArray;
							if (272395 - 424743 == -152348)
							{
								this.$self_$33365 = self_;
								if (56245 - 172464 != -116218)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004DEC RID: 19948 RVA: 0x00995C5C File Offset: 0x00993E5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (259915 - 328938 != -69022)
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
						if (this.$self_$33365.mChar.actionState != "dead")
						{
							if (80950 - 124472 != -43521)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33365.mChar.isPlayer)
							{
								if (252362 - 30449 != 221913)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$33365.gameObject);
								if (204824 - 420019 != -215195)
								{
									continue;
								}
							}
							else if (this.$self_$33365.mChar.isMine)
							{
								if (36212 - 572137 == -535924)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33365.gameObject);
								if (12612 - 80362 != -67750)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (114581 - 267862 != -153280)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					default:
						if (26502 - 337631 != -311129)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33365.mChar.actionState == "dead")
					{
						if (125327 - 338727 == -213400)
						{
							goto IL_1B4;
						}
					}
					else
					{
						this.$myPosition$33362 = (Vector3)this.$nArray$33364[0];
						if (198143 - 194603 != 3541)
						{
							this.$myDirection$33363 = (Vector3)this.$nArray$33364[1];
							if (148309 - 296695 == -148386)
							{
								this.$self_$33365.transform.position = this.$myPosition$33362;
								if (99913 - 222757 != -122843)
								{
									this.$self_$33365.transform.LookAt(this.$myPosition$33362 + this.$myDirection$33363);
									if (260819 - 357864 == -97045)
									{
										this.$self_$33365.mChar.hp = 0;
										if (6219 - 217279 == -211060)
										{
											this.$self_$33365.mChar.actionState = "dead";
											if (22388 - 232112 != -209723)
											{
												this.$self_$33365.mChar.actionTime = Time.time;
												if (247518 - 55599 == 191919)
												{
													this.$self_$33365.mChar.myCommand = "none";
													if (216972 - 494164 != -277191)
													{
														this.$self_$33365.mChar.vMovement = Vector3.zero;
														if (139925 - 595049 != -455123)
														{
															this.$self_$33365.mChar.moveSpeed = (float)0;
															if (211569 - 589347 == -377778)
															{
																this.$self_$33365.animation.Rewind();
																if (130331 - 325698 != -195366)
																{
																	this.$self_$33365.animation.Play("ko");
																	if (254068 - 32202 == 221866)
																	{
																		this.$self_$33365.animation.wrapMode = WrapMode.Once;
																		if (130681 - 465242 != -334560)
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
				return this.Yield(2, new WaitForSeconds(3f));
				IL_1B4:
				Block_15:
				Block_19:
				IL_42F:
				return false;
			}

			// Token: 0x06004DED RID: 19949 RVA: 0x009960AC File Offset: 0x009942AC
			internal static bool AQhsin5biCEkacKZVr8x()
			{
				return true;
			}

			// Token: 0x06004DEE RID: 19950 RVA: 0x009960B0 File Offset: 0x009942B0
			internal static bool W1x8595bKbKAPE27OGJn()
			{
				return false;
			}

			// Token: 0x04005807 RID: 22535
			internal Vector3 $myPosition$33362;

			// Token: 0x04005808 RID: 22536
			internal Vector3 $myDirection$33363;

			// Token: 0x04005809 RID: 22537
			internal UnityScript.Lang.Array $nArray$33364;

			// Token: 0x0400580A RID: 22538
			internal RabbitCult $self_$33365;
		}
	}
}
