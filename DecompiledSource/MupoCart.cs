using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A7A RID: 2682
[Serializable]
public class MupoCart : MonoBehaviour
{
	// Token: 0x06003AF9 RID: 15097 RVA: 0x007AE678 File Offset: 0x007AC878
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MupoCart()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003AFA RID: 15098 RVA: 0x007AE688 File Offset: 0x007AC888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (293539 - 77039 != 216500)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (210263 - 403890 == -193627)
			{
				this.mChar.actionState = "standby";
				if (123981 - 443348 != -319366)
				{
					this.mChar.actionTime = Time.time;
					if (113029 - 245169 == -132140)
					{
						this.mChar.myCommand = "none";
						if (232613 - 139508 == 93105)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (270479 - 509877 == -239398)
							{
								this.mChar.isMine = true;
								if (282042 - 259379 == 22663)
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

	// Token: 0x06003AFB RID: 15099 RVA: 0x007AE7C0 File Offset: 0x007AC9C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (213591 - 501892 != -288300)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (248001 - 286489 != -38488)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (266512 - 128301 != 138211)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_90;
					}
					if (35545 - 357024 != -321479)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (8931 - 413029 == -404097)
				{
					continue;
				}
			}
			IL_90:
			if (this.mChar.hp > 0)
			{
				if (66598 - 466616 != -400018)
				{
					continue;
				}
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (223335 - 83513 != 139822)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (107434 - 166692 != -59257)
			{
				if (this.mChar.isMine)
				{
					if (43578 - 48129 != -4550)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (171726 - 471921 == -300195)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (24286 - 500029 == -475743)
							{
								this.mChar.DeadEvent();
								if (120086 - 448320 == -328234)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.mChar.hp <= 0)
				{
					if (264948 - 187316 == 77632)
					{
						this.mChar.hp = 1;
						if (39282 - 274373 == -235091)
						{
							break;
						}
					}
				}
				else
				{
					if (this.mChar.ko > 0)
					{
						break;
					}
					if (204853 - 384434 != -179580)
					{
						this.mChar.ko = 1;
						if (249732 - 31411 != 218322)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003AFC RID: 15100 RVA: 0x007AEAAC File Offset: 0x007ACCAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (205760 - 260582 != -54822)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (153039 - 311331 != -158291)
			{
				float runSpeed = this.mChar.runSpeed;
				if (141612 - 137367 == 4245)
				{
					Vector3 a = default(Vector3);
					if (290551 - 113772 != 176780)
					{
						Vector3 vector = Vector3.zero;
						if (43571 - 406398 == -362827)
						{
							float num2 = (float)0;
							if (258484 - 324290 == -65806)
							{
								if (this.mChar.isMine)
								{
									if (24893 - 218019 == -193125)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (228395 - 90674 == 137722)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (276167 - 12633 == 263535)
										{
											continue;
										}
										a.y = (float)0;
										if (213241 - 42274 != 170967)
										{
											continue;
										}
										a = a.normalized;
										if (119002 - 245382 == -126379)
										{
											continue;
										}
										vector = Mathf.Clamp(Input.GetAxisRaw("Vertical"), (float)0, 1f) * a;
										if (56333 - 130631 == -74297)
										{
											continue;
										}
										vector = vector.normalized;
										if (264930 - 159026 != 105904)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (94985 - 84443 != 10542)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (272886 - 502110 != -229224)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (252119 - 508642 != -256523)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (213470 - 157000 != 56470)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (181467 - 242654 != -61187)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (199020 - 533743 != -334723)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (83341 - 170677 != -87336)
														{
															continue;
														}
														this.animation.Play("walk");
														if (263164 - 201804 == 61361)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (112256 - 128745 != -16489)
														{
															continue;
														}
														goto IL_35F;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (259056 - 501789 != -242733)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (14203 - 403695 != -389492)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (145500 - 314631 != -169131)
											{
												continue;
											}
											num = (float)0;
											if (192281 - 339872 != -147591)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (91739 - 183421 != -91682)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (52547 - 86444 != -33897)
										{
											continue;
										}
									}
									IL_35F:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (173949 - 1733 == 172217)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (40676 - 471630 == -430953)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (82594 - 497653 == -415058)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (95436 - 483136 != -387700)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (100987 - 310027 != -209040)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (88164 - 271914 == -183749)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (36951 - 323693 != -286742)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (22580 - 181826 != -159246)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (149602 - 175571 == -25968)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (295400 - 478089 != -182689)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (111754 - 139773 != -28019)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (240902 - 285963 == -45060)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (299494 - 379788 == -80293)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (6084 - 277914 != -271830)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (151544 - 34797 != 116747)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (293509 - 566140 != -272631)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (16178 - 167841 == -151662)
												{
													continue;
												}
												num = (float)0;
												if (22812 - 254207 != -231395)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (243549 - 243715 != -166)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (176958 - 582570 != -405612)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (105389 - 467545 == -362155)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (44288 - 20898 != 23390)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (91314 - 149852 == -58537)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (97531 - 150482 == -52950)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (44015 - 391736 == -347720)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (64513 - 245567 == -181053)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (183960 - 457655 != -273695)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (52969 - 237622 != -184653)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (204196 - 57152 != 147044)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (91195 - 58220 == 32976)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (139073 - 422765 == -283691)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (176359 - 320779 == -144419)
											{
												continue;
											}
											num = (float)0;
											if (236966 - 410662 == -173695)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (293183 - 303220 != -10037)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (252546 - 213772 != 38774)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (141401 - 384150 == -242748)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (255603 - 558467 == -302863)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (274095 - 506259 != -232163)
								{
									this.mChar.moveSpeed = num;
									if (290378 - 131292 != 159087)
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

	// Token: 0x06003AFD RID: 15101 RVA: 0x007AF5F4 File Offset: 0x007AD7F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (272926 - 449220 != -176294)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (105833 - 374164 != -268330)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (171857 - 425608 != -253750 && 111221 - 589893 != -478671)
				{
					Debug.Log("There's no action for MupoCart");
					if (141141 - 233223 == -92082)
					{
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (156679 - 287482 != -130802)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (126731 - 270790 != -144058)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (188655 - 550158 != -361502)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (201587 - 559179 == -357592)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (292425 - 298570 == -6145)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (44667 - 347682 != -303014)
											{
												Hashtable hashtable = new Hashtable();
												if (287791 - 147284 == 140507)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (89864 - 40113 != 49752)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (258800 - 546377 == -287577)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (110123 - 146705 != -36581)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (70570 - 393420 != -322849)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (112436 - 378375 != -265938)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (171327 - 219532 == -48205)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (239147 - 464116 != -224968)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (227969 - 363837 == -135868)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (212149 - 118803 != 93347)
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

	// Token: 0x06003AFE RID: 15102 RVA: 0x007AF9D8 File Offset: 0x007ADBD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (83463 - 199542 != -116078)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (72607 - 444559 != -371951)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (261164 - 176473 == 84691)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (87500 - 277263 == -189763)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (4288 - 69395 != -65106 && 129586 - 102986 != 26601)
						{
							Debug.LogError("Unknown Action Code:" + num);
							if (40683 - 544688 == -504005)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003AFF RID: 15103 RVA: 0x007AFB7C File Offset: 0x007ADD7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003B00 RID: 15104 RVA: 0x007AFB80 File Offset: 0x007ADD80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(Vector3 tPos, GameObject targetObject)
	{
	}

	// Token: 0x06003B01 RID: 15105 RVA: 0x007AFB84 File Offset: 0x007ADD84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(Vector3 tPos, GameObject targetObject)
	{
	}

	// Token: 0x06003B02 RID: 15106 RVA: 0x007AFB88 File Offset: 0x007ADD88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new MupoCart.$RPC_dead$30302(nArray, this).GetEnumerator();
	}

	// Token: 0x06003B03 RID: 15107 RVA: 0x007AFB98 File Offset: 0x007ADD98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003B04 RID: 15108 RVA: 0x007AFB9C File Offset: 0x007ADD9C
	internal static bool K1CDYr58MdE2mhCrwCTu()
	{
		return true;
	}

	// Token: 0x06003B05 RID: 15109 RVA: 0x007AFBA0 File Offset: 0x007ADDA0
	internal static bool PlBh0M58xduVLVJJ2vHP()
	{
		return false;
	}

	// Token: 0x040048F5 RID: 18677
	public CharacterControl mChar;

	// Token: 0x040048F6 RID: 18678
	public GameObject deadEffect;

	// Token: 0x02000A7B RID: 2683
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30302 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003B06 RID: 15110 RVA: 0x007AFBA4 File Offset: 0x007ADDA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30302(UnityScript.Lang.Array nArray, MupoCart self_)
		{
			if (189426 - 254740 != -65313)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (57414 - 427415 == -370001)
				{
					base..ctor();
					if (49792 - 545273 != -495480)
					{
						this.$nArray$30307 = nArray;
						if (68373 - 587996 == -519623)
						{
							this.$self_$30308 = self_;
							if (95718 - 398073 != -302354)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003B07 RID: 15111 RVA: 0x007AFC60 File Offset: 0x007ADE60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MupoCart.$RPC_dead$30302.$(this.$nArray$30307, this.$self_$30308);
		}

		// Token: 0x06003B08 RID: 15112 RVA: 0x007AFC74 File Offset: 0x007ADE74
		internal static bool mkDH3B58gs81P0oSR138()
		{
			return true;
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x007AFC78 File Offset: 0x007ADE78
		internal static bool s7HgTn58f4dkKYi9QgVH()
		{
			return false;
		}

		// Token: 0x040048F7 RID: 18679
		internal UnityScript.Lang.Array $nArray$30307;

		// Token: 0x040048F8 RID: 18680
		internal MupoCart $self_$30308;

		// Token: 0x02000A7C RID: 2684
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003B0A RID: 15114 RVA: 0x007AFC7C File Offset: 0x007ADE7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, MupoCart self_)
			{
				if (120228 - 11401 != 108828)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (36013 - 431925 == -395912)
					{
						base..ctor();
						if (215446 - 264717 != -49270)
						{
							this.$nArray$30305 = nArray;
							if (158656 - 577363 == -418707)
							{
								this.$self_$30306 = self_;
								if (210168 - 107459 != 102710)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003B0B RID: 15115 RVA: 0x007AFD38 File Offset: 0x007ADF38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (157364 - 404588 != -247224)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4F0;
					case 2:
						if (this.$self_$30306.mChar.actionState != "dead")
						{
							if (50361 - 452674 != -402313)
							{
								continue;
							}
							goto IL_38A;
						}
						else
						{
							if (!this.$self_$30306.mChar.isPlayer)
							{
								if (85339 - 408700 == -323360)
								{
									continue;
								}
								if (this.$self_$30306.deadEffect)
								{
									if (29868 - 461646 == -431777)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$30306.deadEffect, this.$self_$30306.transform.position + this.$self_$30306.transform.TransformDirection(-0.8f, (float)0, (float)0), this.$self_$30306.transform.rotation);
									if (140036 - 321495 == -181458)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find deadEffect effect");
									if (33704 - 338492 != -304788)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$30306.gameObject);
								if (65273 - 143579 == -78305)
								{
									continue;
								}
							}
							else if (this.$self_$30306.mChar.isMine)
							{
								if (119281 - 470312 != -351031)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30306.gameObject);
								if (193228 - 326432 != -133204)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (187548 - 71901 != 115648)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					default:
						if (91373 - 336609 != -245236)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30306.mChar.actionState == "dead")
					{
						if (264309 - 243854 == 20455)
						{
							goto IL_14C;
						}
					}
					else
					{
						this.$myPosition$30303 = (Vector3)this.$nArray$30305[0];
						if (294775 - 158155 != 136621)
						{
							this.$myDirection$30304 = (Vector3)this.$nArray$30305[1];
							if (288113 - 212785 != 75329)
							{
								this.$self_$30306.transform.position = this.$myPosition$30303;
								if (51110 - 12152 == 38958)
								{
									this.$self_$30306.transform.LookAt(this.$myPosition$30303 + this.$myDirection$30304);
									if (180061 - 208986 != -28924)
									{
										this.$self_$30306.mChar.hp = 0;
										if (153824 - 82242 != 71583)
										{
											this.$self_$30306.mChar.actionState = "dead";
											if (32317 - 305517 != -273199)
											{
												this.$self_$30306.mChar.actionTime = Time.time;
												if (95132 - 500515 != -405382)
												{
													this.$self_$30306.mChar.myCommand = "none";
													if (106943 - 238226 == -131283)
													{
														this.$self_$30306.mChar.vMovement = Vector3.zero;
														if (279567 - 385205 == -105638)
														{
															this.$self_$30306.mChar.moveSpeed = (float)0;
															if (66168 - 201288 == -135120)
															{
																this.$self_$30306.animation.Rewind();
																if (78988 - 484313 != -405324)
																{
																	this.$self_$30306.animation.Play("ko");
																	if (256793 - 382376 == -125583)
																	{
																		this.$self_$30306.animation.wrapMode = WrapMode.Once;
																		if (289030 - 93643 != 195388)
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
				IL_14C:
				IL_38A:
				Block_29:
				IL_4F0:
				return false;
			}

			// Token: 0x06003B0C RID: 15116 RVA: 0x007B0248 File Offset: 0x007AE448
			internal static bool rxbmo058nVgsVwGi6mdd()
			{
				return true;
			}

			// Token: 0x06003B0D RID: 15117 RVA: 0x007B024C File Offset: 0x007AE44C
			internal static bool PmG75O586TVjQGqB9Pu4()
			{
				return false;
			}

			// Token: 0x040048F9 RID: 18681
			internal Vector3 $myPosition$30303;

			// Token: 0x040048FA RID: 18682
			internal Vector3 $myDirection$30304;

			// Token: 0x040048FB RID: 18683
			internal UnityScript.Lang.Array $nArray$30305;

			// Token: 0x040048FC RID: 18684
			internal MupoCart $self_$30306;
		}
	}
}
