using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000397 RID: 919
[Serializable]
public class Shade5 : MonoBehaviour
{
	// Token: 0x06001510 RID: 5392 RVA: 0x002152AC File Offset: 0x002134AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Shade5()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001511 RID: 5393 RVA: 0x002152BC File Offset: 0x002134BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (235466 - 361372 != -125906)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (16206 - 429393 == -413187)
			{
				this.mChar.actionState = "standby";
				if (118135 - 475917 != -357781)
				{
					this.mChar.actionTime = Time.time;
					if (131421 - 253700 == -122279)
					{
						this.mChar.myCommand = "none";
						if (283824 - 393852 == -110028)
						{
							this.mChar.mImmuneList = new UnityScript.Lang.Array("phantomBane");
							if (170536 - 563321 != -392784)
							{
								this.mChar.hp = (this.mChar.mhp = 760);
								if (105581 - 581957 != -476375)
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

	// Token: 0x06001512 RID: 5394 RVA: 0x00215410 File Offset: 0x00213610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06001513 RID: 5395 RVA: 0x0021542C File Offset: 0x0021362C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (28263 - 441615 != -413351)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (188940 - 173299 == 15642)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (175833 - 531346 != -355513)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_1F6;
					}
					if (120089 - 402151 == -282061)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (52088 - 312257 != -260169)
				{
					continue;
				}
			}
			IL_1F6:
			if (this.mChar.hp > 0)
			{
				break;
			}
			if (212094 - 34062 == 178032)
			{
				if (!(this.mChar.actionState != "dead"))
				{
					break;
				}
				if (117402 - 123475 != -6072)
				{
					if (this.mChar.isMine)
					{
						if (35775 - 31260 != 4516)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (231137 - 532098 != -300960)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (181881 - 431760 != -249878)
								{
									this.mChar.DeadEvent();
									if (188610 - 373183 != -184572)
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
						if (166143 - 434051 == -267908)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001514 RID: 5396 RVA: 0x0021566C File Offset: 0x0021386C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (183116 - 283607 != -100490)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (131514 - 596076 != -464561)
			{
				float runSpeed = this.mChar.runSpeed;
				if (229568 - 293895 == -64327)
				{
					Vector3 a = default(Vector3);
					if (200035 - 167594 != 32442)
					{
						Vector3 vector = Vector3.zero;
						if (9977 - 113844 != -103866)
						{
							float num2 = (float)0;
							if (279594 - 590079 != -310484)
							{
								if (this.mChar.isMine)
								{
									if (146666 - 78535 == 68132)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (163290 - 474760 != -311470)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (75810 - 265577 != -189767)
										{
											continue;
										}
										a.y = (float)0;
										if (96770 - 365296 == -268525)
										{
											continue;
										}
										a = a.normalized;
										if (175529 - 209811 == -34281)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (37218 - 480260 == -443041)
										{
											continue;
										}
										vector = vector.normalized;
										if (279749 - 531785 != -252036)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (175036 - 439003 == -263966)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (261243 - 376854 == -115610)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (153826 - 115561 == 38266)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (127505 - 485629 != -358124)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (281148 - 553162 != -272014)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (156554 - 88988 != 67566)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (167255 - 425361 != -258106)
														{
															continue;
														}
														this.animation.Play("run");
														if (175453 - 503571 == -328117)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (145660 - 102328 != 43332)
														{
															continue;
														}
														goto IL_926;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (95636 - 181423 == -85786)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (166929 - 147771 == 19159)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (144684 - 238758 == -94073)
											{
												continue;
											}
											num = (float)0;
											if (79032 - 334931 == -255898)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (72440 - 582070 == -509629)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (136624 - 486208 == -349583)
										{
											continue;
										}
									}
									IL_926:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (236692 - 32324 != 204368)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (125941 - 263467 == -137525)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (108775 - 575022 == -466246)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (273841 - 92816 != 181025)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (148721 - 586014 == -437292)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (42927 - 72104 == -29176)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (232165 - 558551 != -326386)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (161181 - 386839 != -225658)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (146661 - 376563 != -229902)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (248441 - 369242 == -120800)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (210673 - 228738 == -18064)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (119055 - 535570 != -416515)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (67733 - 369240 == -301506)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (171546 - 485583 == -314036)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (59456 - 428443 == -368986)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (118202 - 426159 == -307956)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (59882 - 431382 == -371499)
												{
													continue;
												}
												num = (float)0;
												if (279611 - 53868 != 225743)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (70623 - 9356 != 61267)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (32834 - 146120 != -113286)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (187365 - 386730 != -199365)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (139015 - 593907 == -454891)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (64417 - 156033 == -91615)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (208115 - 163842 != 44273)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (274839 - 526422 != -251583)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (58126 - 543540 != -485414)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (125165 - 347683 != -222518)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (89603 - 191728 == -102124)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (24926 - 546786 == -521859)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (54419 - 45606 != 8813)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (45299 - 321361 != -276062)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (138747 - 259346 == -120598)
											{
												continue;
											}
											num = (float)0;
											if (112035 - 15699 == 96337)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (87708 - 450550 == -362841)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (48094 - 383869 == -335774)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (175481 - 561611 != -386130)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (155890 - 532128 == -376237)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (98449 - 540676 == -442227)
								{
									this.mChar.moveSpeed = num;
									if (293035 - 439625 != -146589)
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

	// Token: 0x06001515 RID: 5397 RVA: 0x002161D0 File Offset: 0x002143D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (121355 - 471504 != -350148)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (76300 - 195045 != -118744)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (47090 - 320487 == -273397)
				{
					if (207056 - 527234 != -320177)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (101198 - 242977 != -141779)
							{
								continue;
							}
							v = 1;
							if (235871 - 165705 == 70167)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (136091 - 324533 == -188441)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (109876 - 84854 != 25023)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (9256 - 181976 != -172719)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (298018 - 469141 == -171123)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (255950 - 217355 == 38595)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (209860 - 81831 == 128029)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (18090 - 63684 == -45594)
											{
												Hashtable hashtable = new Hashtable();
												if (52823 - 215930 != -163106)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (233566 - 280941 != -47374)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (43430 - 358171 != -314740)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (77574 - 64321 != 13254)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (150723 - 188321 != -37597)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (35948 - 259288 == -223340)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (280895 - 355422 == -74527)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (222061 - 468020 == -245959)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (2016 - 182746 != -180729)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (225294 - 12399 != 212896)
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

	// Token: 0x06001516 RID: 5398 RVA: 0x00216604 File Offset: 0x00214804
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (55791 - 339775 != -283984)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (3219 - 571436 == -568217)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (187255 - 237332 == -50077)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (160450 - 158615 != 1836)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (252603 - 20186 != 232418)
						{
							int num2 = num;
							if (182768 - 143548 != 39221)
							{
								if (num2 == 1)
								{
									if (144446 - 196292 == -51846)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (267275 - 323265 == -55990)
										{
											this.RPC_nAttack(mPos, tDir, tID);
											if (54196 - 190936 == -136740)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (209436 - 242542 == -33106)
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

	// Token: 0x06001517 RID: 5399 RVA: 0x0021681C File Offset: 0x00214A1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
	}

	// Token: 0x06001518 RID: 5400 RVA: 0x00216834 File Offset: 0x00214A34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06001519 RID: 5401 RVA: 0x0021684C File Offset: 0x00214A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600151A RID: 5402 RVA: 0x00216850 File Offset: 0x00214A50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (211616 - 53186 != 158430)
		{
		}
		for (;;)
		{
			IL_188:
			this.mChar.addTimeOut("nAttack", (float)7);
			if (77244 - 198455 != -121210)
			{
				if (!this.mChar.isMine)
				{
					break;
				}
				if (150237 - 346031 == -195794)
				{
					int layerMask = 130816 - (1 << this.gameObject.layer);
					if (205844 - 413803 == -207959)
					{
						UnityScript.Lang.Array obj = Damage.FindAreaTarget(mPos, (float)45, (float)3 * this.mChar.rangeMod, layerMask);
						if (281534 - 232362 != 49173)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (35581 - 71037 == -35456)
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
									if (54721 - 503010 == -448288)
									{
										goto IL_188;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (101022 - 546195 != -445173)
									{
										goto IL_188;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (189463 - 187651 != 1812)
									{
										goto IL_188;
									}
									if (characterControl)
									{
										if (37916 - 546260 != -508344)
										{
											goto IL_188;
										}
										characterControl.RPC_AddEffectDamage(11, 33, 0, 0, Vector3.zero, characterControl.ActorNr);
										if (135669 - 323810 == -188140)
										{
											goto IL_188;
										}
									}
								}
								if (202661 - 572969 == -370308)
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

	// Token: 0x0600151B RID: 5403 RVA: 0x00216A78 File Offset: 0x00214C78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Shade5.$RPC_dead$18905(nArray, this).GetEnumerator();
	}

	// Token: 0x0600151C RID: 5404 RVA: 0x00216A88 File Offset: 0x00214C88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600151D RID: 5405 RVA: 0x00216A8C File Offset: 0x00214C8C
	internal static bool opaly0mdjqi0DQGNi7f()
	{
		return true;
	}

	// Token: 0x0600151E RID: 5406 RVA: 0x00216A90 File Offset: 0x00214C90
	internal static bool fWQuhGmJ2GHAtIN0ATP()
	{
		return false;
	}

	// Token: 0x04001254 RID: 4692
	public CharacterControl mChar;

	// Token: 0x02000398 RID: 920
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18905 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600151F RID: 5407 RVA: 0x00216A94 File Offset: 0x00214C94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18905(UnityScript.Lang.Array nArray, Shade5 self_)
		{
			if (2750 - 427135 != -424384)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (150197 - 163020 != -12822)
				{
					base..ctor();
					if (109564 - 312681 != -203116)
					{
						this.$nArray$18910 = nArray;
						if (89110 - 542820 == -453710)
						{
							this.$self_$18911 = self_;
							if (282088 - 545134 != -263045)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00216B50 File Offset: 0x00214D50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Shade5.$RPC_dead$18905.$(this.$nArray$18910, this.$self_$18911);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00216B64 File Offset: 0x00214D64
		internal static bool dmDEjJmDs0KiacBbvL3()
		{
			return true;
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00216B68 File Offset: 0x00214D68
		internal static bool h4PjIgmvHKmaSkQlbSq()
		{
			return false;
		}

		// Token: 0x04001255 RID: 4693
		internal UnityScript.Lang.Array $nArray$18910;

		// Token: 0x04001256 RID: 4694
		internal Shade5 $self_$18911;

		// Token: 0x02000399 RID: 921
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001523 RID: 5411 RVA: 0x00216B6C File Offset: 0x00214D6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Shade5 self_)
			{
				if (203690 - 377946 != -174255)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (111816 - 276029 == -164213)
					{
						base..ctor();
						if (170878 - 363146 == -192268)
						{
							this.$nArray$18908 = nArray;
							if (103983 - 186767 == -82784)
							{
								this.$self_$18909 = self_;
								if (167228 - 26222 != 141007)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001524 RID: 5412 RVA: 0x00216C28 File Offset: 0x00214E28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (13303 - 535874 != -522570)
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
						if (this.$self_$18909.mChar.actionState != "dead")
						{
							if (81957 - 239791 != -157833)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18909.mChar.isPlayer)
							{
								if (217044 - 308663 == -91618)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$18909.gameObject);
								if (77941 - 175144 != -97203)
								{
									continue;
								}
							}
							else if (this.$self_$18909.mChar.isMine)
							{
								if (66954 - 260139 == -193184)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18909.gameObject);
								if (203388 - 317109 != -113721)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (111721 - 313306 != -201584)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					default:
						if (58829 - 547654 != -488825)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18909.mChar.actionState == "dead")
					{
						if (103068 - 585402 != -482333)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$18906 = (Vector3)this.$nArray$18908[0];
						if (71901 - 576702 != -504800)
						{
							this.$myDirection$18907 = (Vector3)this.$nArray$18908[1];
							if (51031 - 484559 != -433527)
							{
								this.$self_$18909.transform.position = this.$myPosition$18906;
								if (69296 - 265315 != -196018)
								{
									this.$self_$18909.transform.LookAt(this.$myPosition$18906 + this.$myDirection$18907);
									if (222176 - 319195 != -97018)
									{
										this.$self_$18909.mChar.hp = 0;
										if (174887 - 341135 != -166247)
										{
											this.$self_$18909.mChar.actionState = "dead";
											if (43775 - 205324 == -161549)
											{
												this.$self_$18909.mChar.actionTime = Time.time;
												if (35538 - 555046 == -519508)
												{
													this.$self_$18909.mChar.myCommand = "none";
													if (53677 - 398343 != -344665)
													{
														this.$self_$18909.mChar.vMovement = Vector3.zero;
														if (26988 - 173529 == -146541)
														{
															this.$self_$18909.mChar.moveSpeed = (float)0;
															if (79607 - 250031 != -170423)
															{
																this.$self_$18909.animation.Rewind();
																if (177187 - 378279 != -201091)
																{
																	this.$self_$18909.animation.Play("ko");
																	if (38477 - 111632 == -73155)
																	{
																		this.$self_$18909.animation.wrapMode = WrapMode.Once;
																		if (268326 - 244104 == 24222)
																		{
																			goto IL_130;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_42F;
				IL_130:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_9:
				IL_42F:
				return false;
			}

			// Token: 0x06001525 RID: 5413 RVA: 0x00217078 File Offset: 0x00215278
			internal static bool aaKHFcmRsuqfoCbM1es()
			{
				return true;
			}

			// Token: 0x06001526 RID: 5414 RVA: 0x0021707C File Offset: 0x0021527C
			internal static bool DWakaKmwa1dGI6tG5uF()
			{
				return false;
			}

			// Token: 0x04001257 RID: 4695
			internal Vector3 $myPosition$18906;

			// Token: 0x04001258 RID: 4696
			internal Vector3 $myDirection$18907;

			// Token: 0x04001259 RID: 4697
			internal UnityScript.Lang.Array $nArray$18908;

			// Token: 0x0400125A RID: 4698
			internal Shade5 $self_$18909;
		}
	}
}
