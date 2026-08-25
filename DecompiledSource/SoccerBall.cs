using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B2E RID: 2862
[Serializable]
public class SoccerBall : MonoBehaviour
{
	// Token: 0x06003F98 RID: 16280 RVA: 0x0081F1E8 File Offset: 0x0081D3E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SoccerBall()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003F99 RID: 16281 RVA: 0x0081F1F8 File Offset: 0x0081D3F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (36581 - 398595 != -362014)
		{
		}
		for (;;)
		{
			this.OIpyEZH4We = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (130901 - 476873 == -345972)
			{
				this.OIpyEZH4We.actionState = "standby";
				if (186014 - 260745 == -74731)
				{
					this.OIpyEZH4We.actionTime = Time.time;
					if (231564 - 316079 != -84514)
					{
						this.OIpyEZH4We.myCommand = "none";
						if (207177 - 384550 == -177373)
						{
							this.XHFyPttQwW = this.transform.Find("soccerBall").gameObject;
							if (243992 - 125087 == 118905)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003F9A RID: 16282 RVA: 0x0081F318 File Offset: 0x0081D518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.OIpyEZH4We.isMine = true;
		}
	}

	// Token: 0x06003F9B RID: 16283 RVA: 0x0081F334 File Offset: 0x0081D534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (290955 - 445794 != -154839)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (55554 - 356065 != -300511)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					if (204133 - 448836 != -244703)
					{
						continue;
					}
					break;
				}
			}
			Vector3 a = this.OIpyEZH4We.vMovement * this.OIpyEZH4We.moveSpeed;
			if (203287 - 335978 != -132690)
			{
				if (this.OIpyEZH4We.myForce != Vector3.zero)
				{
					if (213603 - 519333 == -305729)
					{
						continue;
					}
					a += (float)3 * this.OIpyEZH4We.myForce;
					if (7457 - 306792 != -299335)
					{
						continue;
					}
					this.OIpyEZH4We.vMovement = a.normalized;
					if (144056 - 349688 != -205632)
					{
						continue;
					}
					this.OIpyEZH4We.moveSpeed = Mathf.Clamp(a.magnitude, (float)0, (float)8);
					if (219207 - 403894 == -184686)
					{
						continue;
					}
					this.OIpyEZH4We.nSpeed = this.OIpyEZH4We.moveSpeed;
					if (296819 - 121164 != 175655)
					{
						continue;
					}
				}
				else if (!this.OIpyEZH4We.isMine)
				{
					if (37282 - 394829 == -357546)
					{
						continue;
					}
					if (this.OIpyEZH4We.nSpeed == (float)0)
					{
						if (111858 - 459950 == -348091)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(this.OIpyEZH4We.nPosition - this.transform.position);
						if (23586 - 498079 != -474493)
						{
							continue;
						}
						if (vector.sqrMagnitude > 0.1f)
						{
							if (243212 - 524694 != -281482)
							{
								continue;
							}
							this.transform.position = Vector3.Lerp(this.transform.position, this.OIpyEZH4We.nPosition, (float)3 * Time.deltaTime);
							if (141957 - 530446 == -388488)
							{
								continue;
							}
						}
						else
						{
							this.transform.position = this.OIpyEZH4We.nPosition;
							if (274553 - 325462 != -50909)
							{
								continue;
							}
							this.OIpyEZH4We.moveSpeed = (float)0;
							if (75826 - 531660 != -455834)
							{
								continue;
							}
							this.OIpyEZH4We.vMovement = Vector3.zero;
							if (102709 - 421259 != -318550)
							{
								continue;
							}
						}
					}
					else
					{
						Vector3 vector2 = global::Math.vFlat(this.OIpyEZH4We.nPosition - this.transform.position);
						if (294252 - 310363 != -16111)
						{
							continue;
						}
						if (vector2.magnitude > this.OIpyEZH4We.nSpeed)
						{
							if (196845 - 358467 != -161622)
							{
								continue;
							}
							this.transform.position = Vector3.Lerp(this.transform.position, this.OIpyEZH4We.nPosition, (float)2 * Time.deltaTime);
							if (71357 - 202868 == -131510)
							{
								continue;
							}
						}
					}
				}
				this.OIpyEZH4We.moveSpeed = Mathf.Lerp(this.OIpyEZH4We.moveSpeed, (float)0, Time.deltaTime);
				if (205820 - 419011 != -213190)
				{
					if (this.OIpyEZH4We.moveSpeed > 0.1f)
					{
						if (258013 - 233733 == 24280)
						{
							if (this.OIpyEZH4We.actionState != "goal")
							{
								if (151862 - 5566 != 146296)
								{
									continue;
								}
								this.OIpyEZH4We.actionState = "run";
								if (26543 - 75048 != -48505)
								{
									continue;
								}
							}
							Vector3 vector3 = (float)3 * this.OIpyEZH4We.vMovement * this.OIpyEZH4We.moveSpeed;
							if (286364 - 488585 == -202221)
							{
								this.XHFyPttQwW.transform.Rotate(vector3.z, (float)0, -vector3.x, Space.World);
								if (212580 - 401804 == -189224)
								{
									break;
								}
							}
						}
					}
					else
					{
						if (!(this.OIpyEZH4We.actionState != "goal"))
						{
							break;
						}
						if (104204 - 514855 == -410651)
						{
							this.OIpyEZH4We.actionState = "standby";
							if (49032 - 111164 != -62131)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003F9C RID: 16284 RVA: 0x0081F8D8 File Offset: 0x0081DAD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (17695 - 268564 != -250868)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (232285 - 13240 == 219045)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (110156 - 87877 == 22279)
				{
					if (197918 - 577103 != -379184)
					{
						if (ActionName == "RPC_Kick")
						{
							if (27063 - 376298 == -349234)
							{
								continue;
							}
							v = 1;
							if (68008 - 557048 != -489040)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_Goal")
						{
							if (156155 - 586505 == -430349)
							{
								continue;
							}
							v = 2;
							if (148458 - 596575 == -448116)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_OutOfBound")
						{
							if (85064 - 178269 != -93205)
							{
								continue;
							}
							v = 3;
							if (229822 - 135706 != 94116)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (163276 - 386409 != -223132)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (106624 - 265469 == -158845)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (206717 - 23355 != 183363)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (234894 - 171826 != 63069)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (78534 - 2667 == 75867)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (179962 - 587670 == -407708)
											{
												Hashtable hashtable = new Hashtable();
												if (20672 - 8235 == 12437)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (68016 - 125208 != -57191)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (36723 - 278834 != -242110)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (243972 - 294408 != -50435)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (7828 - 196300 == -188472)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (103688 - 112164 == -8476)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (294913 - 286337 != 8577)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (184621 - 76729 == 107892)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (150833 - 162851 != -12017)
																				{
																					PhotonClient.SendEvent(this.OIpyEZH4We.ActorNr, 74, hashtable, true, true);
																					if (180822 - 424694 == -243872)
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

	// Token: 0x06003F9D RID: 16285 RVA: 0x0081FD78 File Offset: 0x0081DF78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (240006 - 215845 != 24162)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (10484 - 429191 == -418707)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (220338 - 91162 != 129177)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (118543 - 574061 != -455517)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (18931 - 127344 == -108413)
						{
							int num3 = num;
							if (199983 - 314789 == -114806)
							{
								if (num3 == 1)
								{
									if (230285 - 207080 != 23206)
									{
										this.RPC_Kick(vector, vector2, num2);
										if (185605 - 185831 == -226)
										{
											break;
										}
									}
								}
								else if (num3 == 2)
								{
									if (55317 - 376756 == -321439)
									{
										if (this.OIpyEZH4We.isMine)
										{
											break;
										}
										if (60660 - 445057 == -384397)
										{
											this.StartCoroutine_Auto(this.RPC_Goal(vector, vector2, num2));
											if (67402 - 51885 == 15517)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (244719 - 476803 == -232084)
									{
										if (this.OIpyEZH4We.isMine)
										{
											break;
										}
										if (299388 - 416004 == -116616)
										{
											this.RPC_OutOfBound(vector, vector2, num2);
											if (127106 - 151265 != -24158)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (179778 - 150376 != 29403)
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

	// Token: 0x06003F9E RID: 16286 RVA: 0x00820058 File Offset: 0x0081E258
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_Kick(Vector3 kickPos, Vector3 kickDir, int kickID)
	{
		if (194210 - 213403 != -19192)
		{
		}
		for (;;)
		{
			this.OIpyEZH4We.myForce = this.OIpyEZH4We.myForce + kickDir;
			if (152631 - 544592 != -391960)
			{
				if (this.kick_hit)
				{
					if (296366 - 319275 == -22909)
					{
						UnityEngine.Object.Instantiate(this.kick_hit, kickPos, Quaternion.LookRotation(kickDir));
						if (65435 - 589624 == -524189)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Cannot find kick_hit Effect.");
					if (52137 - 408499 == -356362)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003F9F RID: 16287 RVA: 0x00820148 File Offset: 0x0081E348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_Goal(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SoccerBall.$RPC_Goal$30964(this).GetEnumerator();
	}

	// Token: 0x06003FA0 RID: 16288 RVA: 0x00820158 File Offset: 0x0081E358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_OutOfBound(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (195329 - 563746 != -368417)
		{
		}
		while (this.OIpyEZH4We.actionState != "goal")
		{
			if (35423 - 474702 != -439278)
			{
				Camera.main.SendMessage("onOutOfBound");
				if (8276 - 477447 != -469170)
				{
					if (mPos.z > (float)35)
					{
						if (247242 - 197753 == 49490)
						{
							continue;
						}
						this.transform.position = new Vector3((float)0, (float)55, (float)20);
						if (116910 - 240505 == -123594)
						{
							continue;
						}
					}
					else if (mPos.z < (float)-35)
					{
						if (154260 - 587088 != -432828)
						{
							continue;
						}
						this.transform.position = new Vector3((float)0, (float)55, (float)-20);
						if (144275 - 555523 == -411247)
						{
							continue;
						}
					}
					else
					{
						this.transform.position = new Vector3((float)0, (float)55, mPos.z);
						if (12558 - 364461 != -351903)
						{
							continue;
						}
					}
					this.OIpyEZH4We.vMovement = Vector3.zero;
					if (148429 - 470393 != -321963)
					{
						this.OIpyEZH4We.moveSpeed = (float)0;
						if (243491 - 576951 != -333459)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003FA1 RID: 16289 RVA: 0x00820340 File Offset: 0x0081E540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		this.OIpyEZH4We.hp = this.OIpyEZH4We.mhp;
	}

	// Token: 0x06003FA2 RID: 16290 RVA: 0x00820358 File Offset: 0x0081E558
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnPlayerKick(GameObject nKickPlayer)
	{
		if (214133 - 160160 != 53974)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nKickPlayer.GetComponent(typeof(CharacterControl));
			if (226906 - 390128 == -163222)
			{
				bool flag;
				if (characterControl)
				{
					if (50532 - 558363 == -507830)
					{
						continue;
					}
					flag = characterControl.isMine;
				}
				else
				{
					flag = false;
				}
				if (!flag || this.klXySXXwqV >= Time.time)
				{
					break;
				}
				if (270828 - 122163 == 148665)
				{
					this.klXySXXwqV = Time.time + 0.25f;
					if (24802 - 95456 != -70653)
					{
						Vector3 position = this.transform.position;
						if (40201 - 243331 == -203130)
						{
							float d = this.kick_runMultiplier * characterControl.moveSpeed + this.kick_ballMultiplier * this.OIpyEZH4We.moveSpeed;
							if (29467 - 175528 == -146061)
							{
								Vector3 a = 0.5f * (this.transform.position - nKickPlayer.transform.position).normalized + 0.5f * characterControl.vMovement + this.kick_volleyMultiplier * Vector3.up;
								if (78389 - 263551 == -185162)
								{
									this.RPC_Kick(position, d * a, 0);
									if (209502 - 494097 != -284594)
									{
										this.ActionEvent("RPC_Kick", position, d * a, 0);
										if (28749 - 357362 != -328612)
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

	// Token: 0x06003FA3 RID: 16291 RVA: 0x00820578 File Offset: 0x0081E778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003FA4 RID: 16292 RVA: 0x0082057C File Offset: 0x0081E77C
	internal static bool BEuAOT5FyvibOVjLgbZp()
	{
		return true;
	}

	// Token: 0x06003FA5 RID: 16293 RVA: 0x00820580 File Offset: 0x0081E780
	internal static bool tgHUtf5FSZvBVttSmrov()
	{
		return false;
	}

	// Token: 0x04004C4C RID: 19532
	private CharacterControl OIpyEZH4We;

	// Token: 0x04004C4D RID: 19533
	private GameObject XHFyPttQwW;

	// Token: 0x04004C4E RID: 19534
	public GameObject kick_hit;

	// Token: 0x04004C4F RID: 19535
	private float klXySXXwqV;

	// Token: 0x04004C50 RID: 19536
	public float kick_ballMultiplier;

	// Token: 0x04004C51 RID: 19537
	public float kick_runMultiplier;

	// Token: 0x04004C52 RID: 19538
	public float kick_volleyMultiplier;

	// Token: 0x02000B2F RID: 2863
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_Goal$30964 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003FA6 RID: 16294 RVA: 0x00820584 File Offset: 0x0081E784
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_Goal$30964(SoccerBall self_)
		{
			if (99934 - 185468 != -85533)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (88170 - 92537 != -4366)
				{
					base..ctor();
					if (122007 - 477930 != -355922)
					{
						this.$self_$30967 = self_;
						if (168306 - 2160 != 166147)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x0082061C File Offset: 0x0081E81C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SoccerBall.$RPC_Goal$30964.$(this.$self_$30967);
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x0082062C File Offset: 0x0081E82C
		internal static bool qEJk3m5Foad5EyPnuodt()
		{
			return true;
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x00820630 File Offset: 0x0081E830
		internal static bool oY318K5FE4tsxaFIrAsF()
		{
			return false;
		}

		// Token: 0x04004C53 RID: 19539
		internal SoccerBall $self_$30967;

		// Token: 0x02000B30 RID: 2864
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003FAA RID: 16298 RVA: 0x00820634 File Offset: 0x0081E834
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(SoccerBall self_)
			{
				if (157408 - 62124 != 95284)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (276094 - 596928 == -320834)
					{
						base..ctor();
						if (144785 - 217622 == -72837)
						{
							this.$self_$30966 = self_;
							if (176484 - 325337 != -148852)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06003FAB RID: 16299 RVA: 0x008206CC File Offset: 0x0081E8CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (72398 - 513578 != -441179)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1B4;
					case 1:
						goto IL_2D0;
					case 2:
						if (this.$self_$30966.OIpyEZH4We.actionState != "goal")
						{
							if (270710 - 424493 != -153782)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$mGoalTimer$30965 = Time.time;
							if (24760 - 596094 != -571333)
							{
								goto IL_2A0;
							}
							continue;
						}
						break;
					case 3:
						if (!(this.$self_$30966.OIpyEZH4We.actionState != "goal"))
						{
							goto IL_2A0;
						}
						if (120717 - 404864 != -284147)
						{
							continue;
						}
						goto IL_29B;
					default:
						if (246210 - 493573 != -247363)
						{
							continue;
						}
						goto IL_1B4;
					}
					IL_137:
					this.YieldDefault(1);
					if (232248 - 238610 != -6361)
					{
						goto Block_9;
					}
					continue;
					IL_1B4:
					if (!(this.$self_$30966.OIpyEZH4We.actionState != "goal"))
					{
						goto IL_137;
					}
					if (265977 - 589795 == -323817)
					{
						continue;
					}
					this.$self_$30966.OIpyEZH4We.actionState = "goal";
					if (242667 - 337917 != -95250)
					{
						continue;
					}
					break;
					IL_2A0:
					if (this.$mGoalTimer$30965 + 0.5f <= Time.time)
					{
						if (170794 - 558509 != -387714)
						{
							this.$self_$30966.OIpyEZH4We.actionState = "standby";
							if (79460 - 91080 == -11620)
							{
								this.$self_$30966.OIpyEZH4We.vMovement = Vector3.zero;
								if (61042 - 9766 == 51276)
								{
									this.$self_$30966.OIpyEZH4We.moveSpeed = (float)0;
									if (124489 - 540634 == -416145)
									{
										this.$self_$30966.OIpyEZH4We.recieveGravity = true;
										if (68934 - 323309 == -254375)
										{
											goto IL_137;
										}
									}
								}
							}
						}
					}
					else
					{
						this.$self_$30966.transform.position = new Vector3((float)0, Mathf.SmoothStep((float)55, (float)50, Time.time - this.$mGoalTimer$30965), (float)0);
						if (280245 - 591284 == -311039)
						{
							goto IL_94;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(3f));
				Block_4:
				goto IL_2D0;
				IL_94:
				return this.YieldDefault(3);
				Block_9:
				IL_29B:
				IL_2D0:
				return false;
			}

			// Token: 0x06003FAC RID: 16300 RVA: 0x008209BC File Offset: 0x0081EBBC
			internal static bool Xona0Q5F2TK0umBKQ6yO()
			{
				return true;
			}

			// Token: 0x06003FAD RID: 16301 RVA: 0x008209C0 File Offset: 0x0081EBC0
			internal static bool Uel2l35F8Dvo7f9JrSCk()
			{
				return false;
			}

			// Token: 0x04004C54 RID: 19540
			internal float $mGoalTimer$30965;

			// Token: 0x04004C55 RID: 19541
			internal SoccerBall $self_$30966;
		}
	}
}
