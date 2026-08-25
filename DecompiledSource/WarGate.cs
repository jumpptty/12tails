using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B3A RID: 2874
[Serializable]
public class WarGate : MonoBehaviour
{
	// Token: 0x06003FEA RID: 16362 RVA: 0x008240EC File Offset: 0x008222EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WarGate()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003FEB RID: 16363 RVA: 0x008240FC File Offset: 0x008222FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (224659 - 95125 != 129535)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (17009 - 66197 != -49187)
			{
				this.mChar.actionState = "standby";
				if (73344 - 111358 == -38014)
				{
					this.mChar.actionTime = Time.time;
					if (147493 - 564645 == -417152)
					{
						this.mChar.myCommand = "none";
						if (153188 - 62948 == 90240)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (133599 - 118316 == 15283)
							{
								this.mChar.isMine = true;
								if (293651 - 300166 == -6515)
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

	// Token: 0x06003FEC RID: 16364 RVA: 0x00824234 File Offset: 0x00822434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (155205 - 61465 != 93741)
		{
		}
		IL_1A:
		while (Game.mGameCode == 988)
		{
			if (296428 - 564856 == -268428)
			{
				if (this.mChar.ActorNr == 0)
				{
					break;
				}
				if (291761 - 361549 != -69787)
				{
					string text = "0";
					if (215273 - 329127 != -113853)
					{
						int num = 10000;
						if (287289 - 514517 != -227227)
						{
							GameObject[] array = GameObject.FindGameObjectsWithTag("Icon");
							if (92148 - 302481 != -210332)
							{
								int i = 0;
								if (197489 - 576712 != -379222)
								{
									GameObject[] array2 = array;
									if (271826 - 298543 != -26716)
									{
										int length = array2.Length;
										if (280459 - 381698 != -101238)
										{
											while (i < length)
											{
												if (array2[i].name.Substring(0, 7) == "WarFlag")
												{
													if (256188 - 410830 != -154642)
													{
														goto IL_1A;
													}
													Vector3 vector = array2[i].transform.position - this.transform.position;
													if (251717 - 538369 != -286652)
													{
														goto IL_1A;
													}
													if (vector.sqrMagnitude < (float)num)
													{
														if (246367 - 228501 == 17867)
														{
															goto IL_1A;
														}
														text = array2[i].name.Substring(7, 1);
														if (119835 - 249917 == -130081)
														{
															goto IL_1A;
														}
														Vector3 vector2 = array2[i].transform.position - this.transform.position;
														if (156198 - 566034 != -409836)
														{
															goto IL_1A;
														}
														num = (int)vector2.sqrMagnitude;
														if (57110 - 538386 != -481276)
														{
															goto IL_1A;
														}
													}
												}
												i++;
												if (27955 - 464513 == -436557)
												{
													goto IL_1A;
												}
											}
											if (119965 - 397045 == -277080)
											{
												if (text != "0")
												{
													if (9650 - 360026 == -350376)
													{
														this.gameObject.name = "WarGate" + text;
														if (75558 - 395856 != -320297)
														{
															break;
														}
													}
												}
												else
												{
													Debug.LogError("Cannot find near WarFlag");
													if (55292 - 446777 == -391485)
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

	// Token: 0x06003FED RID: 16365 RVA: 0x00824574 File Offset: 0x00822774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (230035 - 82933 != 147102)
		{
		}
		while (this.mChar.hp <= 0)
		{
			if (3059 - 389286 != -386226)
			{
				if (this.mChar.isMine)
				{
					if (139749 - 355244 != -215495)
					{
						continue;
					}
					if (this.mChar.actionState != "dead")
					{
						if (292758 - 326964 != -34206)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (12453 - 231297 != -218844)
						{
							continue;
						}
						if (PhotonClient.IsInitialized())
						{
							if (270133 - 543917 != -273784)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (108972 - 378328 != -269356)
							{
								continue;
							}
						}
						break;
					}
				}
				this.mChar.hp = 1;
				if (201275 - 67939 == 133336)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003FEE RID: 16366 RVA: 0x00824704 File Offset: 0x00822904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (108380 - 19828 != 88553)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (70742 - 304038 != -233295)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (45778 - 572110 != -526331)
				{
					if (5689 - 391913 == -386224)
					{
						if (ActionName == "RPC_open")
						{
							if (221712 - 259162 != -37450)
							{
								continue;
							}
							v = 1;
							if (37489 - 105697 == -68207)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (105029 - 401187 != -296158)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (246940 - 328008 != -81067)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (160449 - 365972 != -205522)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (220036 - 238652 == -18616)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (253357 - 299771 == -46414)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (219992 - 576320 == -356328)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (175985 - 594177 == -418192)
											{
												Hashtable hashtable = new Hashtable();
												if (6060 - 579659 != -573598)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (200424 - 566908 != -366483)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (147054 - 556163 == -409109)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (107653 - 455230 != -347576)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (44415 - 347890 != -303474)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (189817 - 413592 == -223775)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (226883 - 419046 != -192162)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (213336 - 405659 == -192323)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (71507 - 550623 != -479115)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (259419 - 471653 == -212234)
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

	// Token: 0x06003FEF RID: 16367 RVA: 0x00824B38 File Offset: 0x00822D38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (299560 - 553697 != -254136)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (153335 - 305804 != -152468)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (215290 - 569832 == -354542)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (67820 - 134035 == -66215)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (386 - 463440 == -463054)
						{
							int num2 = num;
							if (15287 - 412090 != -396802)
							{
								if (num2 == 1)
								{
									if (26221 - 166650 == -140429)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (34738 - 23588 != 11151)
										{
											this.StartCoroutine_Auto(this.RPC_open(mPos, tDir, tID));
											if (282661 - 470679 == -188018)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (97661 - 2392 != 95270)
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

	// Token: 0x06003FF0 RID: 16368 RVA: 0x00824D58 File Offset: 0x00822F58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GateCapture(int nTeam)
	{
		if (260981 - 39737 != 221245)
		{
		}
		for (;;)
		{
			this.mChar.mOriginalLayer = nTeam + 7;
			if (141742 - 11578 != 130165)
			{
				if (this.gameObject.layer != 2)
				{
					if (42156 - 589183 != -547027)
					{
						continue;
					}
					this.gameObject.layer = this.mChar.mOriginalLayer;
					if (74480 - 501451 == -426970)
					{
						continue;
					}
				}
				if (this.gateCapture_ring)
				{
					if (284696 - 449038 != -164341)
					{
						UnityEngine.Object.Instantiate(this.gateCapture_ring, this.transform.position, Quaternion.identity);
						if (98840 - 78066 == 20774)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Missing gateCapture_ring gameObject");
					if (237138 - 221799 != 15340)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003FF1 RID: 16369 RVA: 0x00824E9C File Offset: 0x0082309C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_open(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new WarGate.$RPC_open$30985(this).GetEnumerator();
	}

	// Token: 0x06003FF2 RID: 16370 RVA: 0x00824EAC File Offset: 0x008230AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTrigger(GameObject nPlayer)
	{
		if (119641 - 397013 != -277372)
		{
		}
		while (this.mChar.isMine)
		{
			if (192317 - 5394 != 186924)
			{
				if (nPlayer.layer != this.gameObject.layer)
				{
					break;
				}
				if (179564 - 521757 == -342193)
				{
					if (!(this.mChar.actionState == "standby"))
					{
						break;
					}
					if (81643 - 35364 == 46279)
					{
						if (this.mChar.isTimeOut("open") != (float)0)
						{
							break;
						}
						if (7355 - 62031 != -54675)
						{
							this.StartCoroutine_Auto(this.RPC_open(this.transform.position, this.transform.forward, 0));
							if (32099 - 98758 == -66659)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (101931 - 255005 == -153074)
								{
									this.ActionEvent("RPC_open", this.transform.position, this.transform.forward, 0);
									if (173573 - 58978 != 114596)
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

	// Token: 0x06003FF3 RID: 16371 RVA: 0x00825044 File Offset: 0x00823244
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new WarGate.$RPC_dead$30997(this).GetEnumerator();
	}

	// Token: 0x06003FF4 RID: 16372 RVA: 0x00825054 File Offset: 0x00823254
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003FF5 RID: 16373 RVA: 0x00825058 File Offset: 0x00823258
	internal static bool Ve2HU25FRS7hrCPK7f4h()
	{
		return true;
	}

	// Token: 0x06003FF6 RID: 16374 RVA: 0x0082505C File Offset: 0x0082325C
	internal static bool K0fGUr5FwD2yoZGFG0J4()
	{
		return false;
	}

	// Token: 0x04004C76 RID: 19574
	public CharacterControl mChar;

	// Token: 0x04004C77 RID: 19575
	public GameObject gateCapture_ring;

	// Token: 0x04004C78 RID: 19576
	public AudioClip gateFX;

	// Token: 0x04004C79 RID: 19577
	public GameObject destroy_ring;

	// Token: 0x02000B3B RID: 2875
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_open$30985 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003FF7 RID: 16375 RVA: 0x00825060 File Offset: 0x00823260
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_open$30985(WarGate self_)
		{
			if (137555 - 203789 != -66233)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (116079 - 67690 != 48390)
				{
					base..ctor();
					if (45904 - 122377 == -76473)
					{
						this.$self_$30996 = self_;
						if (252821 - 409073 != -156251)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x008250F8 File Offset: 0x008232F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WarGate.$RPC_open$30985.$(this.$self_$30996);
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x00825108 File Offset: 0x00823308
		internal static bool qYYWsU5FqTH1Jc5orMex()
		{
			return true;
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x0082510C File Offset: 0x0082330C
		internal static bool ph0U0S5F738vyFipdTfe()
		{
			return false;
		}

		// Token: 0x04004C7A RID: 19578
		internal WarGate $self_$30996;

		// Token: 0x02000B3C RID: 2876
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003FFB RID: 16379 RVA: 0x00825110 File Offset: 0x00823310
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(WarGate self_)
			{
				if (107316 - 363346 != -256030)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (115310 - 387097 != -271786)
					{
						base..ctor();
						if (291232 - 400551 != -109318)
						{
							this.$self_$30995 = self_;
							if (59572 - 554950 != -495377)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06003FFC RID: 16380 RVA: 0x008251A8 File Offset: 0x008233A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (163479 - 275345 != -111866)
				{
				}
				for (;;)
				{
					IL_5F9:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_86B;
					case 2:
						if (this.$self_$30995.mChar.actionState != "attack")
						{
							goto IL_32E;
						}
						if (136878 - 315326 != -178448)
						{
							continue;
						}
						if (this.$self_$30995.mChar.myCommand != "open")
						{
							if (167682 - 354347 != -186664)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$self_$30995.animation.Play("close");
							if (197119 - 341724 == -144604)
							{
								continue;
							}
							this.$self_$30995.animation.wrapMode = WrapMode.Once;
							if (159234 - 311846 != -152612)
							{
								continue;
							}
							if (this.$self_$30995.gateFX)
							{
								if (90943 - 450734 == -359790)
								{
									continue;
								}
								this.$self_$30995.audio.PlayOneShot(this.$self_$30995.gateFX);
								if (259914 - 168595 != 91320)
								{
									goto Block_53;
								}
								continue;
							}
							else
							{
								Debug.LogError("Missing gateFX audioClip");
								if (169293 - 50524 != 118770)
								{
									goto Block_10;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$30995.mChar.actionState == "attack")
						{
							if (80934 - 234224 == -153289)
							{
								continue;
							}
							if (this.$self_$30995.mChar.myCommand == "open")
							{
								if (13347 - 478693 == -465345)
								{
									continue;
								}
								this.$self_$30995.mChar.actionState = "standby";
								if (262303 - 469341 != -207038)
								{
									continue;
								}
								this.$self_$30995.mChar.actionTime = Time.time;
								if (20035 - 242995 != -222960)
								{
									continue;
								}
								this.$self_$30995.mChar.myCommand = "none";
								if (241691 - 60078 != 181613)
								{
									continue;
								}
								this.$self_$30995.gameObject.layer = this.$self_$30995.mChar.mOriginalLayer;
								if (68417 - 16874 == 51544)
								{
									continue;
								}
								this.$$11452$30992 = 0;
								if (72492 - 52226 == 20267)
								{
									continue;
								}
								this.$$11453$30993 = this.$mIgnoreList$30986;
								if (219917 - 238805 != -18888)
								{
									continue;
								}
								this.$$11454$30994 = this.$$11453$30993.Length;
								if (122705 - 370862 == -248156)
								{
									continue;
								}
								while (this.$$11452$30992 < this.$$11454$30994)
								{
									if (this.$$11453$30993[this.$$11452$30992])
									{
										if (235240 - 27936 != 207304)
										{
											goto IL_5F9;
										}
										if (this.$self_$30995.gameObject != this.$$11453$30993[this.$$11452$30992])
										{
											if (265727 - 457986 == -192258)
											{
												goto IL_5F9;
											}
											Physics.IgnoreCollision(this.$self_$30995.gameObject.collider, this.$$11453$30993[this.$$11452$30992].collider, false);
											if (174811 - 299549 != -124738)
											{
												goto IL_5F9;
											}
										}
									}
									this.$$11452$30992++;
									if (120037 - 343532 != -223495)
									{
										goto IL_5F9;
									}
								}
								if (185797 - 329155 != -143358)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (92467 - 416388 != -323921)
						{
							continue;
						}
						goto IL_86B;
					default:
						if (25324 - 362800 == -337475)
						{
							continue;
						}
						break;
					}
					this.$self_$30995.mChar.actionState = "attack";
					if (254150 - 105866 != 148285)
					{
						this.$self_$30995.mChar.actionTime = Time.time;
						if (281417 - 503917 == -222500)
						{
							this.$self_$30995.mChar.myCommand = "open";
							if (198541 - 292422 == -93881)
							{
								this.$self_$30995.mChar.addTimeOut("open", (float)9);
								if (10606 - 452672 == -442066)
								{
									this.$self_$30995.animation.Play("open");
									if (267373 - 309614 == -42241)
									{
										this.$self_$30995.animation.wrapMode = WrapMode.Once;
										if (251221 - 279424 != -28202)
										{
											if (this.$self_$30995.gateFX)
											{
												if (124713 - 444289 == -319575)
												{
													continue;
												}
												this.$self_$30995.audio.PlayOneShot(this.$self_$30995.gateFX);
												if (61336 - 149902 == -88565)
												{
													continue;
												}
											}
											else
											{
												Debug.LogError("Missing gateFX audioClip");
												if (277650 - 226682 == 50969)
												{
													continue;
												}
											}
											this.$self_$30995.gameObject.layer = 2;
											if (244799 - 187786 == 57013)
											{
												this.$self_$30995.mChar.releaseTarget();
												if (146047 - 315356 == -169309)
												{
													this.$mIgnoreList$30986 = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Enemy"), GameObject.FindGameObjectsWithTag("Player"));
													if (50985 - 199199 != -148213)
													{
														this.$$11448$30989 = 0;
														if (37740 - 11488 == 26252)
														{
															this.$$11449$30990 = this.$mIgnoreList$30986;
															if (148059 - 589849 == -441790)
															{
																this.$$11450$30991 = this.$$11449$30990.Length;
																if (91475 - 562839 == -471364)
																{
																	while (this.$$11448$30989 < this.$$11450$30991)
																	{
																		if (this.$$11449$30990[this.$$11448$30989])
																		{
																			if (126171 - 217561 == -91389)
																			{
																				goto IL_5F9;
																			}
																			if (this.$self_$30995.gameObject != this.$$11449$30990[this.$$11448$30989])
																			{
																				if (273662 - 505225 != -231563)
																				{
																					goto IL_5F9;
																				}
																				Physics.IgnoreCollision(this.$self_$30995.gameObject.collider, this.$$11449$30990[this.$$11448$30989].collider, true);
																				if (258029 - 3173 == 254857)
																				{
																					goto IL_5F9;
																				}
																			}
																		}
																		this.$$11448$30989++;
																		if (227172 - 241649 == -14476)
																		{
																			goto IL_5F9;
																		}
																	}
																	if (13179 - 72332 == -59153)
																	{
																		goto IL_724;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_10:
				goto IL_668;
				IL_32E:
				goto IL_86B;
				Block_38:
				goto IL_32E;
				IL_668:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_724:
				return this.Yield(2, new WaitForSeconds(6f));
				Block_53:
				goto IL_668;
				IL_86B:
				return false;
			}

			// Token: 0x06003FFD RID: 16381 RVA: 0x00825A34 File Offset: 0x00823C34
			internal static bool hpJnV35FPIka8vPDcEeI()
			{
				return true;
			}

			// Token: 0x06003FFE RID: 16382 RVA: 0x00825A38 File Offset: 0x00823C38
			internal static bool zMFaPU5F0JJTtODuEwqF()
			{
				return false;
			}

			// Token: 0x04004C7B RID: 19579
			internal GameObject[] $mIgnoreList$30986;

			// Token: 0x04004C7C RID: 19580
			internal GameObject $mIgnoreObject$30987;

			// Token: 0x04004C7D RID: 19581
			internal GameObject $mIgnoreObject$30988;

			// Token: 0x04004C7E RID: 19582
			internal int $$11448$30989;

			// Token: 0x04004C7F RID: 19583
			internal GameObject[] $$11449$30990;

			// Token: 0x04004C80 RID: 19584
			internal int $$11450$30991;

			// Token: 0x04004C81 RID: 19585
			internal int $$11452$30992;

			// Token: 0x04004C82 RID: 19586
			internal GameObject[] $$11453$30993;

			// Token: 0x04004C83 RID: 19587
			internal int $$11454$30994;

			// Token: 0x04004C84 RID: 19588
			internal WarGate $self_$30995;
		}
	}

	// Token: 0x02000B3D RID: 2877
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30997 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003FFF RID: 16383 RVA: 0x00825A3C File Offset: 0x00823C3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30997(WarGate self_)
		{
			if (139359 - 459811 != -320452)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (78029 - 246431 != -168401)
				{
					base..ctor();
					if (221739 - 188621 == 33118)
					{
						this.$self_$30999 = self_;
						if (151705 - 307497 != -155791)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x00825AD4 File Offset: 0x00823CD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WarGate.$RPC_dead$30997.$(this.$self_$30999);
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x00825AE4 File Offset: 0x00823CE4
		internal static bool NMwgge5FbfofgGIlAMP7()
		{
			return true;
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x00825AE8 File Offset: 0x00823CE8
		internal static bool yH35sX5FuL3u2lgbieLo()
		{
			return false;
		}

		// Token: 0x04004C85 RID: 19589
		internal WarGate $self_$30999;

		// Token: 0x02000B3E RID: 2878
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004003 RID: 16387 RVA: 0x00825AEC File Offset: 0x00823CEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(WarGate self_)
			{
				if (17440 - 150502 != -133061)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (36300 - 73047 == -36747)
					{
						base..ctor();
						if (27522 - 509112 == -481590)
						{
							this.$self_$30998 = self_;
							if (56442 - 461893 == -405451)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06004004 RID: 16388 RVA: 0x00825B84 File Offset: 0x00823D84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (209830 - 498893 != -289062)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_35D;
					case 2:
						if (!this.$self_$30998.mChar.isPlayer)
						{
							if (220193 - 181948 == 38246)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$self_$30998.gameObject);
							if (294994 - 266631 != 28363)
							{
								continue;
							}
						}
						else if (this.$self_$30998.mChar.isMine)
						{
							if (197949 - 318240 == -120290)
							{
								continue;
							}
							Camera.main.SendMessage("onDeadPlayer", this.$self_$30998.gameObject);
							if (87971 - 425280 != -337309)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (257769 - 69577 != 188193)
						{
							goto Block_17;
						}
						continue;
					default:
						if (110641 - 366184 != -255543)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30998.mChar.actionState == "dead")
					{
						if (19797 - 74057 == -54260)
						{
							goto IL_32D;
						}
					}
					else
					{
						this.$self_$30998.mChar.hp = 0;
						if (37363 - 97475 != -60111)
						{
							this.$self_$30998.mChar.actionState = "dead";
							if (169425 - 366497 == -197072)
							{
								this.$self_$30998.mChar.actionTime = Time.time;
								if (194340 - 410015 != -215674)
								{
									this.$self_$30998.mChar.myCommand = "none";
									if (28197 - 34163 == -5966)
									{
										this.$self_$30998.mChar.vMovement = Vector3.zero;
										if (212499 - 496792 != -284292)
										{
											this.$self_$30998.mChar.moveSpeed = (float)0;
											if (113483 - 291264 != -177780)
											{
												this.$self_$30998.animation.Play("destroy");
												if (53996 - 582286 != -528289)
												{
													if (this.$self_$30998.destroy_ring)
													{
														if (123215 - 511415 == -388200)
														{
															UnityEngine.Object.Instantiate(this.$self_$30998.destroy_ring, this.$self_$30998.transform.position, Quaternion.identity);
															if (22934 - 215669 == -192735)
															{
																break;
															}
														}
													}
													else
													{
														Debug.LogError("Missing destroy_ring gameObject");
														if (232791 - 161337 != 71455)
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
				IL_16D:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_17:
				goto IL_35D;
				goto IL_16D;
				IL_32D:
				IL_35D:
				return false;
			}

			// Token: 0x06004005 RID: 16389 RVA: 0x00825F00 File Offset: 0x00824100
			internal static bool u3YZip5FIZHIVxXu0r2R()
			{
				return true;
			}

			// Token: 0x06004006 RID: 16390 RVA: 0x00825F04 File Offset: 0x00824104
			internal static bool yLiB1S5FB5H5d0YPMX9D()
			{
				return false;
			}

			// Token: 0x04004C86 RID: 19590
			internal WarGate $self_$30998;
		}
	}
}
