using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A88 RID: 2696
[Serializable]
public class Pumpkon : MonoBehaviour
{
	// Token: 0x06003B5E RID: 15198 RVA: 0x007B73BC File Offset: 0x007B55BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Pumpkon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003B5F RID: 15199 RVA: 0x007B73CC File Offset: 0x007B55CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (74474 - 145756 != -71282)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (188808 - 576735 != -387926)
			{
				this.mChar.actionState = "standby";
				if (74695 - 266320 != -191624)
				{
					this.mChar.actionTime = Time.time;
					if (85593 - 365162 != -279568)
					{
						this.mChar.myCommand = "none";
						if (276727 - 573190 == -296463)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (142872 - 424001 != -281128)
							{
								this.mChar.isMine = true;
								if (145683 - 194466 != -48782)
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

	// Token: 0x06003B60 RID: 15200 RVA: 0x007B7504 File Offset: 0x007B5704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (168380 - 568104 != -399723)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (13278 - 594891 != -581613)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (97983 - 597215 == -499231)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_272;
					}
					if (241183 - 288792 != -47609)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (63238 - 306511 != -243273)
				{
					continue;
				}
			}
			IL_272:
			if (this.mChar.hp > 0)
			{
				if (156383 - 14220 == 142164)
				{
					continue;
				}
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (111367 - 187038 != -75671)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (182614 - 304394 == -121780)
			{
				if (this.mChar.isMine)
				{
					if (76618 - 299475 == -222857)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (24112 - 209691 != -185578)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (8963 - 322671 != -313707)
							{
								this.mChar.DeadEvent();
								if (270106 - 488069 != -217962)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.mChar.hp <= 0)
				{
					if (202105 - 389748 != -187642)
					{
						this.mChar.hp = 1;
						if (31556 - 6319 == 25237)
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
					if (20095 - 242732 == -222637)
					{
						this.mChar.ko = 1;
						if (51929 - 44251 == 7678)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003B61 RID: 15201 RVA: 0x007B77F0 File Offset: 0x007B59F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (12819 - 24852 != -12032)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (260653 - 202214 != 58440)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (258023 - 239071 == 18952)
				{
					if (259846 - 265575 != -5728)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (134856 - 183982 == -49125)
							{
								continue;
							}
							v = 1;
							if (172855 - 299508 == -126652)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (245788 - 160936 != 84852)
							{
								continue;
							}
							v = -1;
							if (242197 - 572805 == -330607)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (8815 - 409411 == -400596)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (25143 - 145396 != -120252)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (171138 - 80091 == 91047)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (41525 - 595833 != -554307)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (221695 - 535448 == -313753)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (88696 - 314309 == -225613)
											{
												Hashtable hashtable = new Hashtable();
												if (32885 - 503400 == -470515)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (106393 - 134895 == -28502)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (38448 - 124073 == -85625)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (63889 - 256401 != -192511)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (213425 - 389859 == -176434)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (28592 - 194767 == -166175)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (72979 - 53018 != 19962)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (144622 - 264809 == -120187)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (187053 - 403453 == -216400)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (22586 - 295316 != -272729)
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

	// Token: 0x06003B62 RID: 15202 RVA: 0x007B7C44 File Offset: 0x007B5E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (255007 - 496405 != -241398)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (198209 - 394885 == -196676)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (4780 - 428821 != -424040)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (82212 - 526682 == -444470)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (72351 - 165161 == -92810)
						{
							int num3 = num;
							if (120666 - 415863 != -295196)
							{
								if (num3 == 1)
								{
									if (186278 - 164926 != 21353)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (57577 - 18153 == 39424)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (184329 - 384027 == -199698)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (282596 - 127535 != 155062)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (159319 - 168004 != -8684)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (23840 - 30704 != -6863)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (284274 - 89102 != 195173)
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

	// Token: 0x06003B63 RID: 15203 RVA: 0x007B7ED8 File Offset: 0x007B60D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (228563 - 586874 != -358310)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState != "standby")
			{
				if (67541 - 395594 != -328053)
				{
					continue;
				}
				if (this.mChar.actionState != "run")
				{
					if (221307 - 339267 != -117959)
					{
						break;
					}
					continue;
				}
			}
			float num = this.mChar.moveSpeed;
			if (59499 - 163532 != -104032)
			{
				float runSpeed = this.mChar.runSpeed;
				if (242250 - 492423 == -250173)
				{
					Vector3 a = default(Vector3);
					if (279321 - 532703 == -253382)
					{
						Vector3 vector = Vector3.zero;
						if (104849 - 231801 == -126952)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (257811 - 168594 == 89217)
							{
								if (this.mChar.isMine)
								{
									if (192189 - 304382 == -112192)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (197897 - 21487 != 176410)
									{
										continue;
									}
									a.y = (float)0;
									if (219454 - 547143 == -327688)
									{
										continue;
									}
									a = a.normalized;
									if (248449 - 179116 != 69333)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (285174 - 119429 == 165746)
									{
										continue;
									}
									vector = vector.normalized;
									if (243367 - 578341 == -334973)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (1663 - 406986 == -405322)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (249055 - 335831 == -86775)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (284202 - 41512 == 242691)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (186935 - 174979 != 11956)
										{
											continue;
										}
										this.animation.Play("run");
										if (88445 - 563707 != -475262)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (114828 - 531558 != -416730)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (172684 - 53307 == 119378)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (185950 - 504884 != -318934)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (34216 - 559730 == -525513)
											{
												continue;
											}
											num = (float)0;
											if (95705 - 512324 == -416618)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (77472 - 175756 != -98284)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (241259 - 262413 == -21153)
										{
											continue;
										}
									}
								}
								else if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (296648 - 115672 != 180976)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (99962 - 430270 != -330308)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (157672 - 439197 == -281524)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (31820 - 594077 != -562257)
										{
											continue;
										}
										num = (float)0;
										if (183615 - 446319 == -262703)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (291997 - 71078 != 220919)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (46562 - 300225 != -253663)
										{
											continue;
										}
										vector = lhs.normalized;
										if (294025 - 6679 == 287347)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (232129 - 24866 == 207264)
										{
											continue;
										}
										this.animation.CrossFade("run", 0.2f);
										if (23058 - 295442 != -272384)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (162522 - 570223 != -407701)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (109538 - 401247 != -291709)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (237535 - 220322 == 17214)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (282553 - 396727 == -114173)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (144482 - 254011 == -109529)
								{
									this.mChar.moveSpeed = num;
									if (51493 - 12648 == 38845)
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

	// Token: 0x06003B64 RID: 15204 RVA: 0x007B85F8 File Offset: 0x007B67F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (292927 - 57244 != 235684)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (70489 - 270337 == -199848)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (114222 - 251543 != -137320)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (181828 - 131882 == 49946)
					{
						Vector3 normalized = vector.normalized;
						if (13397 - 502401 == -489004)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (289714 - 318832 == -29118)
							{
								if (254958 - 541453 == -286495)
								{
									if (gameObject)
									{
										if (87364 - 55657 == 31708)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (54698 - 9020 != 45678)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (292641 - 447780 != -155139)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (145132 - 151632 == -6499)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (124918 - 499699 == -374781)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
										if (89516 - 525309 != -435792)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (259963 - 319350 == -59387)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
												if (284343 - 302645 != -18301)
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

	// Token: 0x06003B65 RID: 15205 RVA: 0x007B88B4 File Offset: 0x007B6AB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charge attack");
	}

	// Token: 0x06003B66 RID: 15206 RVA: 0x007B88CC File Offset: 0x007B6ACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003B67 RID: 15207 RVA: 0x007B88D0 File Offset: 0x007B6AD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Pumpkon.$RPC_nAttack$30336(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003B68 RID: 15208 RVA: 0x007B88E0 File Offset: 0x007B6AE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06003B69 RID: 15209 RVA: 0x007B890C File Offset: 0x007B6B0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Pumpkon.$RPC_dead$30349(nArray, this).GetEnumerator();
	}

	// Token: 0x06003B6A RID: 15210 RVA: 0x007B891C File Offset: 0x007B6B1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003B6B RID: 15211 RVA: 0x007B8920 File Offset: 0x007B6B20
	internal static bool kr3tEJ581VQeelr7mlvh()
	{
		return true;
	}

	// Token: 0x06003B6C RID: 15212 RVA: 0x007B8924 File Offset: 0x007B6B24
	internal static bool uyBOni584YZg4fX1Yat9()
	{
		return false;
	}

	// Token: 0x04004924 RID: 18724
	public CharacterControl mChar;

	// Token: 0x04004925 RID: 18725
	public GameObject nAttack_hit;

	// Token: 0x04004926 RID: 18726
	private GameObject sj9WE694Sw;

	// Token: 0x02000A89 RID: 2697
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30336 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003B6D RID: 15213 RVA: 0x007B8928 File Offset: 0x007B6B28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30336(Vector3 mPos, Vector3 tDir, Pumpkon self_)
		{
			if (1262 - 157357 != -156094)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (223754 - 78186 != 145569)
				{
					base..ctor();
					if (37583 - 526894 != -489310)
					{
						this.$mPos$30346 = mPos;
						if (109804 - 555827 != -446022)
						{
							this.$tDir$30347 = tDir;
							if (38767 - 542472 != -503704)
							{
								this.$self_$30348 = self_;
								if (277646 - 251255 != 26392)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003B6E RID: 15214 RVA: 0x007B8A04 File Offset: 0x007B6C04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Pumpkon.$RPC_nAttack$30336.$(this.$mPos$30346, this.$tDir$30347, this.$self_$30348);
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x007B8A20 File Offset: 0x007B6C20
		internal static bool uodoM458zqy32ups7OCj()
		{
			return true;
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x007B8A24 File Offset: 0x007B6C24
		internal static bool PZJ94K5ZaiUtWTddPdd1()
		{
			return false;
		}

		// Token: 0x04004927 RID: 18727
		internal Vector3 $mPos$30346;

		// Token: 0x04004928 RID: 18728
		internal Vector3 $tDir$30347;

		// Token: 0x04004929 RID: 18729
		internal Pumpkon $self_$30348;

		// Token: 0x02000A8A RID: 2698
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003B71 RID: 15217 RVA: 0x007B8A28 File Offset: 0x007B6C28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Pumpkon self_)
			{
				if (258291 - 47138 != 211154)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (122489 - 562730 == -440241)
					{
						base..ctor();
						if (163810 - 491432 != -327621)
						{
							this.$mPos$30343 = mPos;
							if (299199 - 119659 == 179540)
							{
								this.$tDir$30344 = tDir;
								if (44598 - 187647 == -143049)
								{
									this.$self_$30345 = self_;
									if (281707 - 382241 != -100533)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003B72 RID: 15218 RVA: 0x007B8B04 File Offset: 0x007B6D04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (292608 - 290848 != 1761)
				{
				}
				for (;;)
				{
					IL_44:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_98F;
					case 2:
						if (this.$self_$30345.mChar.actionState != "attack")
						{
							goto IL_81;
						}
						if (237901 - 387241 == -149339)
						{
							continue;
						}
						if (this.$self_$30345.mChar.myCommand != "nAttack")
						{
							if (206743 - 247162 != -40418)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$i$30337 = 0;
							if (239754 - 77180 != 162575)
							{
								goto IL_6EF;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30345.mChar.actionState != "attack")
						{
							goto IL_95B;
						}
						if (55514 - 211182 != -155668)
						{
							continue;
						}
						if (this.$self_$30345.mChar.myCommand != "nAttack")
						{
							if (222258 - 245750 != -23491)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							if (this.$self_$30345.mChar.isMine)
							{
								if (85421 - 441578 != -356157)
								{
									continue;
								}
								this.$hitLayer$30338 = 130816 - (1 << this.$self_$30345.gameObject.layer);
								if (129459 - 7473 == 121987)
								{
									continue;
								}
								this.$hitList$30339 = Damage.FindAreaTarget(this.$self_$30345.transform.position, (float)2 * this.$self_$30345.mChar.rangeMod, (float)1 * this.$self_$30345.mChar.rangeMod, this.$hitLayer$30338);
								if (188148 - 20598 != 167550)
								{
									continue;
								}
								this.$hitPos$30340 = default(Vector3);
								if (269278 - 95594 != 173684)
								{
									continue;
								}
								this.$$iterator$10614$30342 = UnityRuntimeServices.GetEnumerator(this.$hitList$30339);
								if (174006 - 130214 == 43793)
								{
									continue;
								}
								while (this.$$iterator$10614$30342.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10614$30342.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$30341 = (GameObject)obj2;
									if (240619 - 436235 == -195615)
									{
										goto IL_44;
									}
									if (this.$self_$30345.mChar.hit(1, this.$hitObject$30341, (int)(0.5f * (float)this.$self_$30345.mChar.atk), 10, 0, this.$self_$30345.transform.forward) != 0)
									{
										if (145617 - 41866 != 103751)
										{
											goto IL_44;
										}
										this.$hitPos$30340 = this.$hitObject$30341.collider.ClosestPointOnBounds(this.$self_$30345.transform.position + 1.5f * Vector3.up);
										if (230197 - 406567 != -176370)
										{
											goto IL_44;
										}
										UnityRuntimeServices.Update(this.$$iterator$10614$30342, this.$hitObject$30341);
										if (278585 - 192912 == 85674)
										{
											goto IL_44;
										}
										this.$self_$30345.RPC_nAttack_hit(this.$hitPos$30340, this.$self_$30345.transform.forward, 0);
										if (113139 - 155536 == -42396)
										{
											goto IL_44;
										}
										this.$self_$30345.ActionEvent("RPC_nAttack_hit", this.$hitPos$30340, this.$self_$30345.transform.forward, 0);
										if (211652 - 320074 == -108421)
										{
											goto IL_44;
										}
									}
								}
								if (251081 - 303912 == -52830)
								{
									continue;
								}
							}
							this.$i$30337++;
							if (73081 - 535832 != -462751)
							{
								continue;
							}
							goto IL_6EF;
						}
						break;
					case 4:
						if (this.$self_$30345.mChar.actionState != "attack")
						{
							goto IL_CD;
						}
						if (264198 - 522472 != -258274)
						{
							continue;
						}
						if (this.$self_$30345.mChar.myCommand != "nAttack")
						{
							if (210064 - 476560 != -266495)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							this.$self_$30345.mChar.moveSpeed = (float)0;
							if (266989 - 214640 != 52350)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$30345.mChar.actionState == "attack")
						{
							if (202418 - 544389 == -341970)
							{
								continue;
							}
							if (this.$self_$30345.mChar.myCommand == "nAttack")
							{
								if (245902 - 403047 == -157144)
								{
									continue;
								}
								this.$self_$30345.mChar.actionState = "standby";
								if (228282 - 383853 == -155570)
								{
									continue;
								}
								this.$self_$30345.mChar.actionTime = Time.time;
								if (240362 - 243099 != -2737)
								{
									continue;
								}
								this.$self_$30345.mChar.myCommand = "none";
								if (191517 - 337057 != -145540)
								{
									continue;
								}
								if (!this.$self_$30345.mChar.isMine)
								{
									if (166182 - 158669 == 7514)
									{
										continue;
									}
									this.$self_$30345.mChar.nPosition = this.$self_$30345.transform.position;
									if (142984 - 336759 != -193775)
									{
										continue;
									}
									this.$self_$30345.mChar.oPosition = this.$self_$30345.transform.position;
									if (16650 - 258473 == -241822)
									{
										continue;
									}
									this.$self_$30345.mChar.nDirection = this.$self_$30345.transform.forward;
									if (136918 - 491729 != -354811)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (74095 - 584158 != -510063)
						{
							continue;
						}
						goto IL_98F;
					default:
						if (207660 - 455109 == -247448)
						{
							continue;
						}
						break;
					}
					this.$self_$30345.mChar.actionState = "attack";
					if (29309 - 20171 == 9139)
					{
						continue;
					}
					this.$self_$30345.mChar.actionTime = Time.time;
					if (273888 - 540253 != -266365)
					{
						continue;
					}
					this.$self_$30345.mChar.myCommand = "nAttack";
					if (92218 - 57009 == 35210)
					{
						continue;
					}
					this.$self_$30345.mChar.addTimeOut("nAttack", (float)3);
					if (130926 - 405155 != -274229)
					{
						continue;
					}
					this.$self_$30345.transform.position = this.$mPos$30343;
					if (247240 - 271919 == -24678)
					{
						continue;
					}
					this.$self_$30345.transform.LookAt(this.$mPos$30343 + global::Math.vFlat(this.$tDir$30344));
					if (284209 - 571204 == -286994)
					{
						continue;
					}
					this.$self_$30345.animation.CrossFade("nAttack");
					if (28756 - 524294 != -495538)
					{
						continue;
					}
					this.$self_$30345.animation.wrapMode = WrapMode.Once;
					if (241831 - 359382 != -117551)
					{
						continue;
					}
					this.$self_$30345.mChar.vMovement = this.$self_$30345.transform.forward;
					if (2405 - 99740 != -97335)
					{
						continue;
					}
					this.$self_$30345.mChar.moveSpeed = (float)0;
					if (136978 - 68484 != 68495)
					{
						goto Block_24;
					}
					continue;
					IL_6EF:
					if (this.$i$30337 < 2)
					{
						goto IL_31D;
					}
					if (18045 - 510716 != -492670)
					{
						goto Block_44;
					}
				}
				IL_81:
				IL_CD:
				goto IL_98F;
				Block_8:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_10:
				goto IL_81;
				IL_31D:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_24:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_27:
				goto IL_95B;
				Block_44:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_49:
				IL_95B:
				IL_98F:
				return false;
			}

			// Token: 0x06003B73 RID: 15219 RVA: 0x007B94B4 File Offset: 0x007B76B4
			internal static bool TPFDF05Z5smc8bcUR129()
			{
				return true;
			}

			// Token: 0x06003B74 RID: 15220 RVA: 0x007B94B8 File Offset: 0x007B76B8
			internal static bool Ov9jCN5ZpCj9m0DsDvMP()
			{
				return false;
			}

			// Token: 0x0400492A RID: 18730
			internal int $i$30337;

			// Token: 0x0400492B RID: 18731
			internal int $hitLayer$30338;

			// Token: 0x0400492C RID: 18732
			internal UnityScript.Lang.Array $hitList$30339;

			// Token: 0x0400492D RID: 18733
			internal Vector3 $hitPos$30340;

			// Token: 0x0400492E RID: 18734
			internal GameObject $hitObject$30341;

			// Token: 0x0400492F RID: 18735
			internal IEnumerator $$iterator$10614$30342;

			// Token: 0x04004930 RID: 18736
			internal Vector3 $mPos$30343;

			// Token: 0x04004931 RID: 18737
			internal Vector3 $tDir$30344;

			// Token: 0x04004932 RID: 18738
			internal Pumpkon $self_$30345;
		}
	}

	// Token: 0x02000A8B RID: 2699
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30349 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003B75 RID: 15221 RVA: 0x007B94BC File Offset: 0x007B76BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30349(UnityScript.Lang.Array nArray, Pumpkon self_)
		{
			if (138603 - 356716 != -218113)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (18682 - 174007 != -155324)
				{
					base..ctor();
					if (145991 - 588613 != -442621)
					{
						this.$nArray$30354 = nArray;
						if (155433 - 211987 != -56553)
						{
							this.$self_$30355 = self_;
							if (6344 - 354265 == -347921)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x007B9578 File Offset: 0x007B7778
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Pumpkon.$RPC_dead$30349.$(this.$nArray$30354, this.$self_$30355);
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x007B958C File Offset: 0x007B778C
		internal static bool Fh95BR5ZVYDGjoA2jFSq()
		{
			return true;
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x007B9590 File Offset: 0x007B7790
		internal static bool wN0ADs5Ztgk90KONSHVR()
		{
			return false;
		}

		// Token: 0x04004933 RID: 18739
		internal UnityScript.Lang.Array $nArray$30354;

		// Token: 0x04004934 RID: 18740
		internal Pumpkon $self_$30355;

		// Token: 0x02000A8C RID: 2700
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003B79 RID: 15225 RVA: 0x007B9594 File Offset: 0x007B7794
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Pumpkon self_)
			{
				if (64939 - 260911 != -195971)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (34374 - 287495 == -253121)
					{
						base..ctor();
						if (123533 - 519148 == -395615)
						{
							this.$nArray$30352 = nArray;
							if (253480 - 533157 == -279677)
							{
								this.$self_$30353 = self_;
								if (163262 - 145709 != 17554)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003B7A RID: 15226 RVA: 0x007B9650 File Offset: 0x007B7850
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (68697 - 403865 != -335167)
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
						if (this.$self_$30353.mChar.actionState != "dead")
						{
							if (220025 - 173823 != 46202)
							{
								continue;
							}
							goto IL_AB;
						}
						else
						{
							if (!this.$self_$30353.mChar.isPlayer)
							{
								if (8508 - 431095 == -422586)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$30353.gameObject);
								if (171602 - 302855 != -131253)
								{
									continue;
								}
							}
							else if (this.$self_$30353.mChar.isMine)
							{
								if (233139 - 106224 == 126916)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30353.gameObject);
								if (101711 - 4253 == 97459)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (50051 - 85866 != -35815)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (253718 - 62728 == 190991)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30353.mChar.actionState == "dead")
					{
						if (34941 - 470727 != -435785)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30350 = (Vector3)this.$nArray$30352[0];
						if (267527 - 297560 == -30033)
						{
							this.$myDirection$30351 = (Vector3)this.$nArray$30352[1];
							if (276276 - 218398 != 57879)
							{
								this.$self_$30353.transform.position = this.$myPosition$30350;
								if (67732 - 524347 == -456615)
								{
									this.$self_$30353.transform.LookAt(this.$myPosition$30350 + this.$myDirection$30351);
									if (104326 - 4940 == 99386)
									{
										this.$self_$30353.mChar.hp = 0;
										if (36586 - 272984 != -236397)
										{
											this.$self_$30353.mChar.actionState = "dead";
											if (187594 - 293099 == -105505)
											{
												this.$self_$30353.mChar.actionTime = Time.time;
												if (172392 - 353648 == -181256)
												{
													this.$self_$30353.mChar.myCommand = "none";
													if (223866 - 570224 == -346358)
													{
														this.$self_$30353.mChar.vMovement = Vector3.zero;
														if (154882 - 282010 != -127127)
														{
															this.$self_$30353.mChar.moveSpeed = (float)0;
															if (273054 - 132447 == 140607)
															{
																this.$self_$30353.animation.Rewind();
																if (66527 - 517725 == -451198)
																{
																	this.$self_$30353.animation.Play("ko");
																	if (45182 - 127089 == -81907)
																	{
																		this.$self_$30353.animation.wrapMode = WrapMode.Once;
																		if (97358 - 10959 == 86399)
																		{
																			goto IL_381;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_AB:
				goto IL_42F;
				IL_381:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06003B7B RID: 15227 RVA: 0x007B9AA0 File Offset: 0x007B7CA0
			internal static bool qHR7hX5ZNGobdoNDL6Ir()
			{
				return true;
			}

			// Token: 0x06003B7C RID: 15228 RVA: 0x007B9AA4 File Offset: 0x007B7CA4
			internal static bool yscyrm5ZYNjNh1Eaf13A()
			{
				return false;
			}

			// Token: 0x04004935 RID: 18741
			internal Vector3 $myPosition$30350;

			// Token: 0x04004936 RID: 18742
			internal Vector3 $myDirection$30351;

			// Token: 0x04004937 RID: 18743
			internal UnityScript.Lang.Array $nArray$30352;

			// Token: 0x04004938 RID: 18744
			internal Pumpkon $self_$30353;
		}
	}
}
