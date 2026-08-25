using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A82 RID: 2690
[Serializable]
public class Pumpkin : MonoBehaviour
{
	// Token: 0x06003B30 RID: 15152 RVA: 0x007B2780 File Offset: 0x007B0980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Pumpkin()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003B31 RID: 15153 RVA: 0x007B2790 File Offset: 0x007B0990
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (5575 - 304974 != -299398)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (189695 - 422373 != -232677)
			{
				this.mChar.actionState = "standby";
				if (238071 - 353932 == -115861)
				{
					this.mChar.actionTime = Time.time;
					if (283450 - 3687 == 279763)
					{
						this.mChar.myCommand = "none";
						if (18205 - 589347 == -571142)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003B32 RID: 15154 RVA: 0x007B287C File Offset: 0x007B0A7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (232533 - 143750 != 88783)
		{
		}
		for (;;)
		{
			if (Game.mGameState == eGameState.Init)
			{
				if (119683 - 481424 != -361741)
				{
					continue;
				}
				if (UnityEngine.Random.Range(0, 100) < 66)
				{
					if (294387 - 355609 == -61221)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (133674 - 93324 == 40351)
					{
						continue;
					}
				}
			}
			if (Game.mGameType != 99)
			{
				break;
			}
			if (147445 - 307674 != -160228)
			{
				this.mChar.isMine = true;
				if (40884 - 490593 != -449708)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003B33 RID: 15155 RVA: 0x007B2974 File Offset: 0x007B0B74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (158977 - 498401 != -339423)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (83524 - 321092 != -237568)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (201115 - 517094 == -315978)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_CE;
					}
					if (159501 - 489596 != -330095)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (287649 - 379643 == -91993)
				{
					continue;
				}
			}
			IL_CE:
			if (this.mChar.hp > 0)
			{
				if (145832 - 90138 == 55695)
				{
					continue;
				}
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (143009 - 329165 == -186155)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (253035 - 550885 != -297849)
			{
				if (this.mChar.isMine)
				{
					if (132581 - 462702 == -330121)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (76733 - 93644 != -16910)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (96919 - 465936 == -369017)
							{
								this.mChar.DeadEvent();
								if (297605 - 30671 != 266935)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.mChar.hp <= 0)
				{
					if (197488 - 567197 == -369709)
					{
						this.mChar.hp = 1;
						if (60178 - 424739 != -364560)
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
					if (129726 - 332880 != -203153)
					{
						this.mChar.ko = 1;
						if (68456 - 482110 == -413654)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003B34 RID: 15156 RVA: 0x007B2C60 File Offset: 0x007B0E60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (192920 - 248518 != -55597)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (148308 - 511803 == -363495)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (291055 - 570296 == -279241)
				{
					if (298725 - 544573 == -245848)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (32292 - 398070 != -365778)
							{
								continue;
							}
							v = 1;
							if (137783 - 67534 != 70249)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (1877 - 562280 == -560402)
							{
								continue;
							}
							v = -1;
							if (225712 - 38469 == 187244)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (239160 - 490551 == -251391)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (173186 - 573718 == -400532)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (222709 - 235346 != -12636)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (140087 - 349684 == -209597)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (156887 - 392356 == -235469)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (89337 - 477416 == -388079)
											{
												Hashtable hashtable = new Hashtable();
												if (243423 - 230653 != 12771)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (103188 - 194691 != -91502)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (124479 - 219480 != -95000)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (28636 - 425181 == -396545)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (18008 - 247240 == -229232)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (286275 - 24997 == 261278)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (165559 - 127093 == 38466)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (62442 - 304047 != -241604)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (194406 - 498030 != -303623)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (60300 - 418038 == -357738)
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

	// Token: 0x06003B35 RID: 15157 RVA: 0x007B30B4 File Offset: 0x007B12B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (159912 - 467352 != -307439)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (269265 - 464181 == -194916)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (30994 - 489026 != -458031)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (49683 - 392840 != -343156)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (176725 - 352226 != -175500)
						{
							int num3 = num;
							if (229092 - 86642 == 142450)
							{
								if (num3 == 1)
								{
									if (152245 - 405486 == -253241)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (257522 - 21901 != 235622)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (137446 - 399778 == -262332)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (19992 - 98248 != -78255)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (47887 - 159149 != -111261)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (131341 - 417055 != -285713)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (190209 - 268603 == -78394)
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

	// Token: 0x06003B36 RID: 15158 RVA: 0x007B3348 File Offset: 0x007B1548
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (244961 - 540969 != -296007)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState != "standby")
			{
				if (171121 - 14187 == 156935)
				{
					continue;
				}
				if (this.mChar.actionState != "run")
				{
					if (193633 - 15993 != 177641)
					{
						break;
					}
					continue;
				}
			}
			float num = this.mChar.moveSpeed;
			if (205940 - 497939 != -291998)
			{
				float runSpeed = this.mChar.runSpeed;
				if (14244 - 151488 != -137243)
				{
					Vector3 a = default(Vector3);
					if (30080 - 101781 != -71700)
					{
						Vector3 vector = Vector3.zero;
						if (70848 - 290940 != -220091)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (273091 - 292671 != -19579)
							{
								if (this.mChar.isMine)
								{
									if (226501 - 235508 == -9006)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (407 - 598057 != -597650)
									{
										continue;
									}
									a.y = (float)0;
									if (124402 - 384040 == -259637)
									{
										continue;
									}
									a = a.normalized;
									if (278371 - 468451 == -190079)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (115248 - 503260 != -388012)
									{
										continue;
									}
									vector = vector.normalized;
									if (170341 - 113031 != 57310)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (298040 - 419165 == -121124)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (295336 - 380558 == -85221)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (30852 - 486222 != -455370)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (139002 - 569750 != -430748)
										{
											continue;
										}
										this.animation.Play("run");
										if (95887 - 477846 != -381959)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (147074 - 425966 != -278892)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (78523 - 132186 == -53662)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (151777 - 484645 == -332867)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (223635 - 68375 != 155260)
											{
												continue;
											}
											num = (float)0;
											if (278131 - 592609 != -314478)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (57935 - 244949 != -187014)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (120911 - 501545 == -380633)
										{
											continue;
										}
									}
								}
								else if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (253829 - 495706 != -241877)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (39070 - 126769 != -87699)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (219280 - 82530 != 136750)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (184006 - 498102 != -314096)
										{
											continue;
										}
										num = (float)0;
										if (76364 - 588458 == -512093)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (139803 - 242909 == -103105)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (129459 - 294434 == -164974)
										{
											continue;
										}
										vector = lhs.normalized;
										if (245311 - 282542 == -37230)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (121745 - 72235 == 49511)
										{
											continue;
										}
										this.animation.CrossFade("run", 0.2f);
										if (90739 - 125847 == -35107)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (216394 - 316238 != -99844)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (58592 - 470881 == -412288)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (77390 - 331802 == -254411)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (284670 - 527790 == -243119)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (75745 - 550735 == -474990)
								{
									this.mChar.moveSpeed = num;
									if (11784 - 216700 == -204916)
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

	// Token: 0x06003B37 RID: 15159 RVA: 0x007B3A68 File Offset: 0x007B1C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (218644 - 383371 != -164726)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (120801 - 151008 == -30207)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (31135 - 503731 != -472595)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (131509 - 541421 == -409912)
					{
						Vector3 normalized = vector.normalized;
						if (5501 - 413843 != -408341)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (182899 - 54968 != 127932 && 8284 - 5160 != 3125)
							{
								if (gameObject)
								{
									if (186465 - 52997 != 133468)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (54273 - 220908 != -166635)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (125509 - 460031 != -334522)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (161850 - 110361 != 51489)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (16000 - 225232 == -209232)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
									if (271552 - 491557 == -220005)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (10149 - 80271 != -70121)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
											if (38876 - 227707 != -188830)
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

	// Token: 0x06003B38 RID: 15160 RVA: 0x007B3D24 File Offset: 0x007B1F24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charge attack");
	}

	// Token: 0x06003B39 RID: 15161 RVA: 0x007B3D3C File Offset: 0x007B1F3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003B3A RID: 15162 RVA: 0x007B3D40 File Offset: 0x007B1F40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Pumpkin.$RPC_nAttack$30316(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003B3B RID: 15163 RVA: 0x007B3D50 File Offset: 0x007B1F50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06003B3C RID: 15164 RVA: 0x007B3D7C File Offset: 0x007B1F7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Pumpkin.$RPC_dead$30329(nArray, this).GetEnumerator();
	}

	// Token: 0x06003B3D RID: 15165 RVA: 0x007B3D8C File Offset: 0x007B1F8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003B3E RID: 15166 RVA: 0x007B3D90 File Offset: 0x007B1F90
	internal static bool irgXXm58P0eebOalBD04()
	{
		return true;
	}

	// Token: 0x06003B3F RID: 15167 RVA: 0x007B3D94 File Offset: 0x007B1F94
	internal static bool IojDwV580lIuYN29AFsm()
	{
		return false;
	}

	// Token: 0x04004909 RID: 18697
	public CharacterControl mChar;

	// Token: 0x0400490A RID: 18698
	public GameObject nAttack_hit;

	// Token: 0x0400490B RID: 18699
	private GameObject BQHWMFOyj7;

	// Token: 0x02000A83 RID: 2691
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30316 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003B40 RID: 15168 RVA: 0x007B3D98 File Offset: 0x007B1F98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30316(Vector3 mPos, Vector3 tDir, Pumpkin self_)
		{
			if (57291 - 62690 != -5398)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (47441 - 7064 != 40378)
				{
					base..ctor();
					if (250158 - 76497 == 173661)
					{
						this.$mPos$30326 = mPos;
						if (249701 - 449573 != -199871)
						{
							this.$tDir$30327 = tDir;
							if (158206 - 568030 == -409824)
							{
								this.$self_$30328 = self_;
								if (248030 - 188039 == 59991)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x007B3E74 File Offset: 0x007B2074
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Pumpkin.$RPC_nAttack$30316.$(this.$mPos$30326, this.$tDir$30327, this.$self_$30328);
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x007B3E90 File Offset: 0x007B2090
		internal static bool dbMdyH58bsRWZ4L6eDck()
		{
			return true;
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x007B3E94 File Offset: 0x007B2094
		internal static bool SDLKcI58ucLPSNxab0y0()
		{
			return false;
		}

		// Token: 0x0400490C RID: 18700
		internal Vector3 $mPos$30326;

		// Token: 0x0400490D RID: 18701
		internal Vector3 $tDir$30327;

		// Token: 0x0400490E RID: 18702
		internal Pumpkin $self_$30328;

		// Token: 0x02000A84 RID: 2692
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003B44 RID: 15172 RVA: 0x007B3E98 File Offset: 0x007B2098
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Pumpkin self_)
			{
				if (104398 - 399136 != -294738)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (162088 - 228566 != -66477)
					{
						base..ctor();
						if (173730 - 364624 == -190894)
						{
							this.$mPos$30323 = mPos;
							if (288817 - 231569 == 57248)
							{
								this.$tDir$30324 = tDir;
								if (176044 - 472689 != -296644)
								{
									this.$self_$30325 = self_;
									if (252750 - 329511 == -76761)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003B45 RID: 15173 RVA: 0x007B3F74 File Offset: 0x007B2174
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (256664 - 195964 != 60701)
				{
				}
				for (;;)
				{
					IL_11B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_98F;
					case 2:
						if (this.$self_$30325.mChar.actionState != "attack")
						{
							goto IL_2D6;
						}
						if (209942 - 198003 == 11940)
						{
							continue;
						}
						if (this.$self_$30325.mChar.myCommand != "nAttack")
						{
							if (46427 - 375834 != -329407)
							{
								continue;
							}
							goto IL_2D6;
						}
						else
						{
							this.$i$30317 = 0;
							if (10259 - 515681 != -505421)
							{
								goto IL_6D9;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30325.mChar.actionState != "attack")
						{
							goto IL_55B;
						}
						if (13711 - 24355 != -10644)
						{
							continue;
						}
						if (this.$self_$30325.mChar.myCommand != "nAttack")
						{
							if (185924 - 34700 != 151224)
							{
								continue;
							}
							goto IL_55B;
						}
						else
						{
							if (this.$self_$30325.mChar.isMine)
							{
								if (192387 - 13374 == 179014)
								{
									continue;
								}
								this.$hitLayer$30318 = 130816 - (1 << this.$self_$30325.gameObject.layer);
								if (78654 - 438722 == -360067)
								{
									continue;
								}
								this.$hitList$30319 = Damage.FindAreaTarget(this.$self_$30325.transform.position, (float)2 * this.$self_$30325.mChar.rangeMod, (float)1 * this.$self_$30325.mChar.rangeMod, this.$hitLayer$30318);
								if (46293 - 353402 == -307108)
								{
									continue;
								}
								this.$hitPos$30320 = default(Vector3);
								if (101805 - 277206 != -175401)
								{
									continue;
								}
								this.$$iterator$10612$30322 = UnityRuntimeServices.GetEnumerator(this.$hitList$30319);
								if (138537 - 519216 != -380679)
								{
									continue;
								}
								while (this.$$iterator$10612$30322.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10612$30322.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$30321 = (GameObject)obj2;
									if (142090 - 416219 != -274129)
									{
										goto IL_11B;
									}
									if (this.$self_$30325.mChar.hit(1, this.$hitObject$30321, (int)(0.5f * (float)this.$self_$30325.mChar.atk), 10, 0, this.$self_$30325.transform.forward) != 0)
									{
										if (175379 - 555018 == -379638)
										{
											goto IL_11B;
										}
										this.$hitPos$30320 = this.$hitObject$30321.collider.ClosestPointOnBounds(this.$self_$30325.transform.position + 1.5f * Vector3.up);
										if (89698 - 356695 != -266997)
										{
											goto IL_11B;
										}
										UnityRuntimeServices.Update(this.$$iterator$10612$30322, this.$hitObject$30321);
										if (180220 - 307757 == -127536)
										{
											goto IL_11B;
										}
										this.$self_$30325.RPC_nAttack_hit(this.$hitPos$30320, this.$self_$30325.transform.forward, 0);
										if (121056 - 421744 != -300688)
										{
											goto IL_11B;
										}
										this.$self_$30325.ActionEvent("RPC_nAttack_hit", this.$hitPos$30320, this.$self_$30325.transform.forward, 0);
										if (200579 - 388546 == -187966)
										{
											goto IL_11B;
										}
									}
								}
								if (234915 - 94727 != 140188)
								{
									continue;
								}
							}
							this.$i$30317++;
							if (12678 - 270677 != -257999)
							{
								continue;
							}
							goto IL_6D9;
						}
						break;
					case 4:
						if (this.$self_$30325.mChar.actionState != "attack")
						{
							goto IL_817;
						}
						if (115571 - 145062 != -29491)
						{
							continue;
						}
						if (this.$self_$30325.mChar.myCommand != "nAttack")
						{
							if (33175 - 319093 != -285918)
							{
								continue;
							}
							goto IL_817;
						}
						else
						{
							this.$self_$30325.mChar.moveSpeed = (float)0;
							if (156438 - 527247 != -370809)
							{
								continue;
							}
							goto IL_8A3;
						}
						break;
					case 5:
						if (this.$self_$30325.mChar.actionState == "attack")
						{
							if (196129 - 490134 == -294004)
							{
								continue;
							}
							if (this.$self_$30325.mChar.myCommand == "nAttack")
							{
								if (91387 - 9119 != 82268)
								{
									continue;
								}
								this.$self_$30325.mChar.actionState = "standby";
								if (147835 - 557385 == -409549)
								{
									continue;
								}
								this.$self_$30325.mChar.actionTime = Time.time;
								if (149077 - 136653 != 12424)
								{
									continue;
								}
								this.$self_$30325.mChar.myCommand = "none";
								if (210180 - 283467 == -73286)
								{
									continue;
								}
								if (!this.$self_$30325.mChar.isMine)
								{
									if (50012 - 181091 == -131078)
									{
										continue;
									}
									this.$self_$30325.mChar.nPosition = this.$self_$30325.transform.position;
									if (167788 - 486707 != -318919)
									{
										continue;
									}
									this.$self_$30325.mChar.oPosition = this.$self_$30325.transform.position;
									if (196712 - 168091 != 28621)
									{
										continue;
									}
									this.$self_$30325.mChar.nDirection = this.$self_$30325.transform.forward;
									if (104444 - 66246 != 38198)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (175831 - 487115 != -311284)
						{
							continue;
						}
						goto IL_98F;
					default:
						if (219332 - 172738 != 46594)
						{
							continue;
						}
						break;
					}
					this.$self_$30325.mChar.actionState = "attack";
					if (269310 - 35427 != 233883)
					{
						continue;
					}
					this.$self_$30325.mChar.actionTime = Time.time;
					if (216173 - 83397 != 132776)
					{
						continue;
					}
					this.$self_$30325.mChar.myCommand = "nAttack";
					if (14703 - 27713 != -13010)
					{
						continue;
					}
					this.$self_$30325.mChar.addTimeOut("nAttack", (float)2);
					if (83190 - 102940 != -19750)
					{
						continue;
					}
					this.$self_$30325.transform.position = this.$mPos$30323;
					if (60527 - 374749 != -314222)
					{
						continue;
					}
					this.$self_$30325.transform.LookAt(this.$mPos$30323 + global::Math.vFlat(this.$tDir$30324));
					if (221520 - 441353 != -219833)
					{
						continue;
					}
					this.$self_$30325.animation.CrossFade("nAttack");
					if (176470 - 48736 == 127735)
					{
						continue;
					}
					this.$self_$30325.animation.wrapMode = WrapMode.Once;
					if (193690 - 316507 != -122817)
					{
						continue;
					}
					this.$self_$30325.mChar.vMovement = this.$self_$30325.transform.forward;
					if (118733 - 307507 != -188774)
					{
						continue;
					}
					this.$self_$30325.mChar.moveSpeed = (float)0;
					if (190468 - 176542 != 13927)
					{
						goto Block_34;
					}
					continue;
					IL_6D9:
					if (this.$i$30317 < 2)
					{
						break;
					}
					if (150420 - 15147 != 135274)
					{
						goto Block_42;
					}
				}
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_2D6:
				IL_55B:
				goto IL_98F;
				Block_34:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_42:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_817:
				goto IL_98F;
				IL_8A3:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_98F:
				return false;
			}

			// Token: 0x06003B46 RID: 15174 RVA: 0x007B4924 File Offset: 0x007B2B24
			internal static bool OmZB4l58IF7tPRCuwpeq()
			{
				return true;
			}

			// Token: 0x06003B47 RID: 15175 RVA: 0x007B4928 File Offset: 0x007B2B28
			internal static bool kxjqBL58BkMyOouC6MB7()
			{
				return false;
			}

			// Token: 0x0400490F RID: 18703
			internal int $i$30317;

			// Token: 0x04004910 RID: 18704
			internal int $hitLayer$30318;

			// Token: 0x04004911 RID: 18705
			internal UnityScript.Lang.Array $hitList$30319;

			// Token: 0x04004912 RID: 18706
			internal Vector3 $hitPos$30320;

			// Token: 0x04004913 RID: 18707
			internal GameObject $hitObject$30321;

			// Token: 0x04004914 RID: 18708
			internal IEnumerator $$iterator$10612$30322;

			// Token: 0x04004915 RID: 18709
			internal Vector3 $mPos$30323;

			// Token: 0x04004916 RID: 18710
			internal Vector3 $tDir$30324;

			// Token: 0x04004917 RID: 18711
			internal Pumpkin $self_$30325;
		}
	}

	// Token: 0x02000A85 RID: 2693
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30329 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003B48 RID: 15176 RVA: 0x007B492C File Offset: 0x007B2B2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30329(UnityScript.Lang.Array nArray, Pumpkin self_)
		{
			if (10231 - 266063 != -255832)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (72712 - 561157 != -488444)
				{
					base..ctor();
					if (140940 - 87007 == 53933)
					{
						this.$nArray$30334 = nArray;
						if (69396 - 248656 == -179260)
						{
							this.$self_$30335 = self_;
							if (142316 - 592236 == -449920)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x007B49E8 File Offset: 0x007B2BE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Pumpkin.$RPC_dead$30329.$(this.$nArray$30334, this.$self_$30335);
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x007B49FC File Offset: 0x007B2BFC
		internal static bool E6CYhM58emEFRwsjubhe()
		{
			return true;
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x007B4A00 File Offset: 0x007B2C00
		internal static bool DaNZ4D58rwCJQPP4Ylm8()
		{
			return false;
		}

		// Token: 0x04004918 RID: 18712
		internal UnityScript.Lang.Array $nArray$30334;

		// Token: 0x04004919 RID: 18713
		internal Pumpkin $self_$30335;

		// Token: 0x02000A86 RID: 2694
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003B4C RID: 15180 RVA: 0x007B4A04 File Offset: 0x007B2C04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Pumpkin self_)
			{
				if (259053 - 531527 != -272474)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (288311 - 196139 != 92173)
					{
						base..ctor();
						if (243089 - 30725 == 212364)
						{
							this.$nArray$30332 = nArray;
							if (258770 - 254289 != 4482)
							{
								this.$self_$30333 = self_;
								if (99210 - 4862 == 94348)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003B4D RID: 15181 RVA: 0x007B4AC0 File Offset: 0x007B2CC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (174883 - 560111 != -385228)
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
						if (this.$self_$30333.mChar.actionState != "dead")
						{
							if (72641 - 104768 != -32127)
							{
								continue;
							}
							goto IL_2FD;
						}
						else
						{
							if (!this.$self_$30333.mChar.isPlayer)
							{
								if (171066 - 170446 != 620)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$30333.gameObject);
								if (34227 - 218240 != -184013)
								{
									continue;
								}
							}
							else if (this.$self_$30333.mChar.isMine)
							{
								if (77181 - 576130 != -498949)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30333.gameObject);
								if (136103 - 488577 == -352473)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (115553 - 124516 != -8963)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (169950 - 511496 != -341546)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30333.mChar.actionState == "dead")
					{
						if (230389 - 235245 == -4856)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30330 = (Vector3)this.$nArray$30332[0];
						if (7393 - 21013 != -13619)
						{
							this.$myDirection$30331 = (Vector3)this.$nArray$30332[1];
							if (156715 - 590123 == -433408)
							{
								this.$self_$30333.transform.position = this.$myPosition$30330;
								if (198016 - 573379 != -375362)
								{
									this.$self_$30333.transform.LookAt(this.$myPosition$30330 + this.$myDirection$30331);
									if (151907 - 533468 != -381560)
									{
										this.$self_$30333.mChar.hp = 0;
										if (122105 - 554267 != -432161)
										{
											this.$self_$30333.mChar.actionState = "dead";
											if (16459 - 574945 == -558486)
											{
												this.$self_$30333.mChar.actionTime = Time.time;
												if (250060 - 316627 == -66567)
												{
													this.$self_$30333.mChar.myCommand = "none";
													if (256939 - 65603 != 191337)
													{
														this.$self_$30333.mChar.vMovement = Vector3.zero;
														if (13220 - 514378 != -501157)
														{
															this.$self_$30333.mChar.moveSpeed = (float)0;
															if (87618 - 3750 != 83869)
															{
																this.$self_$30333.animation.Rewind();
																if (178768 - 579052 != -400283)
																{
																	this.$self_$30333.animation.Play("ko");
																	if (111075 - 383523 != -272447)
																	{
																		this.$self_$30333.animation.wrapMode = WrapMode.Once;
																		if (95692 - 171004 == -75312)
																		{
																			goto IL_225;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_42F;
				IL_225:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_2FD:
				IL_42F:
				return false;
			}

			// Token: 0x06003B4E RID: 15182 RVA: 0x007B4F10 File Offset: 0x007B3110
			internal static bool exlpF258jBwJ7252q22F()
			{
				return true;
			}

			// Token: 0x06003B4F RID: 15183 RVA: 0x007B4F14 File Offset: 0x007B3114
			internal static bool NM9FIR58hlQ3TdwEoHc4()
			{
				return false;
			}

			// Token: 0x0400491A RID: 18714
			internal Vector3 $myPosition$30330;

			// Token: 0x0400491B RID: 18715
			internal Vector3 $myDirection$30331;

			// Token: 0x0400491C RID: 18716
			internal UnityScript.Lang.Array $nArray$30332;

			// Token: 0x0400491D RID: 18717
			internal Pumpkin $self_$30333;
		}
	}
}
