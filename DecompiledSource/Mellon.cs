using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A72 RID: 2674
[Serializable]
public class Mellon : MonoBehaviour
{
	// Token: 0x06003ABB RID: 15035 RVA: 0x007A9940 File Offset: 0x007A7B40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mellon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003ABC RID: 15036 RVA: 0x007A9950 File Offset: 0x007A7B50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (284190 - 67212 != 216978)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (86087 - 398100 == -312013)
			{
				this.mChar.actionState = "standby";
				if (108156 - 388920 == -280764)
				{
					this.mChar.actionTime = Time.time;
					if (173780 - 341451 == -167671)
					{
						this.mChar.myCommand = "none";
						if (145699 - 447996 == -302297)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (211470 - 254963 != -43492)
							{
								this.mChar.isMine = true;
								if (162589 - 369323 == -206734)
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

	// Token: 0x06003ABD RID: 15037 RVA: 0x007A9A88 File Offset: 0x007A7C88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (280929 - 565940 != -285011)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (41445 - 69790 != -28345)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (298394 - 118781 == 179614)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_E2;
					}
					if (90509 - 434404 == -343894)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (238471 - 243496 != -5025)
				{
					continue;
				}
			}
			IL_E2:
			if (this.mChar.hp > 0)
			{
				if (125837 - 203923 == -78085)
				{
					continue;
				}
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (221301 - 514687 == -293385)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (121884 - 251858 == -129974)
			{
				if (this.mChar.isMine)
				{
					if (291656 - 304155 != -12498)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (79756 - 427014 != -347257)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (147007 - 150079 != -3071)
							{
								this.mChar.DeadEvent();
								if (243814 - 148221 != 95594)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.mChar.hp <= 0)
				{
					if (1364 - 379017 != -377652)
					{
						this.mChar.hp = 1;
						if (285558 - 384025 != -98466)
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
					if (131599 - 551651 == -420052)
					{
						this.mChar.ko = 1;
						if (47395 - 139373 == -91978)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003ABE RID: 15038 RVA: 0x007A9D74 File Offset: 0x007A7F74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (196019 - 432206 != -236187)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState != "standby")
			{
				if (144761 - 574067 == -429305)
				{
					continue;
				}
				if (this.mChar.actionState != "run")
				{
					if (95682 - 53326 != 42357)
					{
						break;
					}
					continue;
				}
			}
			float num = this.mChar.moveSpeed;
			if (72088 - 219966 == -147878)
			{
				float runSpeed = this.mChar.runSpeed;
				if (266489 - 599912 != -333422)
				{
					Vector3 a = default(Vector3);
					if (53279 - 567700 != -514420)
					{
						Vector3 vector = Vector3.zero;
						if (113076 - 572162 == -459086)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (186323 - 39731 == 146592)
							{
								if (this.mChar.isMine)
								{
									if (154304 - 552425 == -398120)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (83523 - 392658 == -309134)
									{
										continue;
									}
									a.y = (float)0;
									if (44521 - 178970 != -134449)
									{
										continue;
									}
									a = a.normalized;
									if (274735 - 78097 != 196638)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (256761 - 429434 != -172673)
									{
										continue;
									}
									vector = vector.normalized;
									if (61768 - 141645 == -79876)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (185859 - 2677 == 183183)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (190956 - 564001 == -373044)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (108947 - 241960 != -133013)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (126861 - 333312 != -206451)
										{
											continue;
										}
										this.animation.Play("run");
										if (94851 - 129936 == -35084)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (163893 - 223308 == -59414)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (103849 - 26820 != 77029)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (129227 - 460420 == -331192)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (31735 - 161157 == -129421)
											{
												continue;
											}
											num = (float)0;
											if (260685 - 231541 == 29145)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (205451 - 554144 == -348692)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (66034 - 63353 != 2681)
										{
											continue;
										}
									}
								}
								else if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (238079 - 134098 != 103981)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (128281 - 555747 == -427465)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (274876 - 139372 == 135505)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (173649 - 5391 == 168259)
										{
											continue;
										}
										num = (float)0;
										if (155390 - 234114 != -78724)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (110746 - 52342 == 58405)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (163860 - 496658 == -332797)
										{
											continue;
										}
										vector = lhs.normalized;
										if (292237 - 555705 == -263467)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (169218 - 251867 == -82648)
										{
											continue;
										}
										this.animation.CrossFade("run", 0.2f);
										if (142358 - 512432 == -370073)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (139219 - 514899 == -375679)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (220173 - 388335 == -168161)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (201313 - 68669 != 132644)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (170755 - 280963 == -110207)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (111073 - 296746 != -185672)
								{
									this.mChar.moveSpeed = num;
									if (44422 - 134554 != -90131)
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

	// Token: 0x06003ABF RID: 15039 RVA: 0x007AA494 File Offset: 0x007A8694
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x06003AC0 RID: 15040 RVA: 0x007AA4AC File Offset: 0x007A86AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x06003AC1 RID: 15041 RVA: 0x007AA4C4 File Offset: 0x007A86C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003AC2 RID: 15042 RVA: 0x007AA4C8 File Offset: 0x007A86C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Mellon.$RPC_dead$30288(nArray, this).GetEnumerator();
	}

	// Token: 0x06003AC3 RID: 15043 RVA: 0x007AA4D8 File Offset: 0x007A86D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003AC4 RID: 15044 RVA: 0x007AA4DC File Offset: 0x007A86DC
	internal static bool dNtFIx58Hun3L17QNUB7()
	{
		return true;
	}

	// Token: 0x06003AC5 RID: 15045 RVA: 0x007AA4E0 File Offset: 0x007A86E0
	internal static bool cpswrd58WrXIPXBFfG7T()
	{
		return false;
	}

	// Token: 0x040048D8 RID: 18648
	public CharacterControl mChar;

	// Token: 0x040048D9 RID: 18649
	public AudioClip mellon_cry;

	// Token: 0x040048DA RID: 18650
	public GameObject dead_ring;

	// Token: 0x040048DB RID: 18651
	public GameObject deadEffect;

	// Token: 0x02000A73 RID: 2675
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30288 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003AC6 RID: 15046 RVA: 0x007AA4E4 File Offset: 0x007A86E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30288(UnityScript.Lang.Array nArray, Mellon self_)
		{
			if (119502 - 324778 != -205276)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (182802 - 119551 != 63252)
				{
					base..ctor();
					if (173182 - 543466 != -370283)
					{
						this.$nArray$30293 = nArray;
						if (73290 - 555964 == -482674)
						{
							this.$self_$30294 = self_;
							if (166728 - 535840 != -369111)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x007AA5A0 File Offset: 0x007A87A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mellon.$RPC_dead$30288.$(this.$nArray$30293, this.$self_$30294);
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x007AA5B4 File Offset: 0x007A87B4
		internal static bool S5gEDx58AUAfQUNbo0S8()
		{
			return true;
		}

		// Token: 0x06003AC9 RID: 15049 RVA: 0x007AA5B8 File Offset: 0x007A87B8
		internal static bool QP5Jhf58lBjXH5YtH91e()
		{
			return false;
		}

		// Token: 0x040048DC RID: 18652
		internal UnityScript.Lang.Array $nArray$30293;

		// Token: 0x040048DD RID: 18653
		internal Mellon $self_$30294;

		// Token: 0x02000A74 RID: 2676
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003ACA RID: 15050 RVA: 0x007AA5BC File Offset: 0x007A87BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Mellon self_)
			{
				if (64322 - 227847 != -163524)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (118076 - 170191 == -52115)
					{
						base..ctor();
						if (137065 - 7716 == 129349)
						{
							this.$nArray$30291 = nArray;
							if (290612 - 116068 == 174544)
							{
								this.$self_$30292 = self_;
								if (23464 - 25125 != -1660)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003ACB RID: 15051 RVA: 0x007AA678 File Offset: 0x007A8878
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (187510 - 350696 != -163186)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_631;
					case 2:
						if (this.$self_$30292.mChar.actionState != "dead")
						{
							if (185325 - 89504 != 95822)
							{
								goto Block_36;
							}
							continue;
						}
						else if (this.$self_$30292.dead_ring)
						{
							if (74055 - 316573 == -242517)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$30292.dead_ring, this.$self_$30292.transform.position, this.$self_$30292.transform.rotation);
							if (201545 - 61868 != 139678)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							Debug.LogError("Cannot find dead_ring effect");
							if (2257 - 174610 != -172352)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30292.mChar.actionState != "dead")
						{
							if (53606 - 161693 != -108086)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30292.mChar.isPlayer)
							{
								if (150476 - 210405 == -59928)
								{
									continue;
								}
								if (this.$self_$30292.deadEffect)
								{
									if (115270 - 381800 != -266530)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$30292.deadEffect, this.$self_$30292.transform.position, this.$self_$30292.transform.rotation);
									if (128520 - 540190 != -411670)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find deadEffect effect");
									if (270300 - 500087 == -229786)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$30292.gameObject);
								if (233171 - 225520 != 7651)
								{
									continue;
								}
							}
							else if (this.$self_$30292.mChar.isMine)
							{
								if (212028 - 439594 == -227565)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30292.gameObject);
								if (4249 - 462912 == -458662)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (168406 - 335971 != -167564)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					default:
						if (94433 - 529737 != -435304)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30292.mChar.actionState == "dead")
					{
						if (76390 - 436504 != -360113)
						{
							goto Block_16;
						}
					}
					else
					{
						this.$myPosition$30289 = (Vector3)this.$nArray$30291[0];
						if (65076 - 21421 != 43656)
						{
							this.$myDirection$30290 = (Vector3)this.$nArray$30291[1];
							if (84287 - 113760 != -29472)
							{
								this.$self_$30292.transform.position = this.$myPosition$30289;
								if (55187 - 36176 != 19012)
								{
									this.$self_$30292.transform.LookAt(this.$myPosition$30289 + this.$myDirection$30290);
									if (33694 - 331683 != -297988)
									{
										this.$self_$30292.mChar.hp = 0;
										if (168080 - 352736 == -184656)
										{
											this.$self_$30292.mChar.actionState = "dead";
											if (162606 - 245624 != -83017)
											{
												this.$self_$30292.mChar.actionTime = Time.time;
												if (240367 - 169618 == 70749)
												{
													this.$self_$30292.mChar.myCommand = "none";
													if (219210 - 341901 != -122690)
													{
														this.$self_$30292.mChar.vMovement = Vector3.zero;
														if (17054 - 482423 != -465368)
														{
															this.$self_$30292.mChar.moveSpeed = (float)0;
															if (30322 - 288751 != -258428)
															{
																this.$self_$30292.animation.Rewind();
																if (205824 - 427956 != -222131)
																{
																	this.$self_$30292.animation.Play("ko");
																	if (272147 - 191930 != 80218)
																	{
																		this.$self_$30292.animation.wrapMode = WrapMode.Once;
																		if (115322 - 203744 != -88421)
																		{
																			if (!this.$self_$30292.mellon_cry)
																			{
																				goto IL_583;
																			}
																			if (247992 - 573707 != -325714)
																			{
																				this.$self_$30292.audio.PlayOneShot(this.$self_$30292.mellon_cry);
																				if (225654 - 535801 == -310147)
																				{
																					goto IL_583;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_8:
				Block_12:
				goto IL_295;
				Block_16:
				goto IL_631;
				IL_295:
				return this.Yield(3, new WaitForSeconds(2.45f));
				Block_19:
				Block_30:
				goto IL_631;
				IL_583:
				return this.Yield(2, new WaitForSeconds(0.55f));
				Block_36:
				IL_631:
				return false;
			}

			// Token: 0x06003ACC RID: 15052 RVA: 0x007AACC8 File Offset: 0x007A8EC8
			internal static bool nR8pRS58yucZKsRvuf2G()
			{
				return true;
			}

			// Token: 0x06003ACD RID: 15053 RVA: 0x007AACCC File Offset: 0x007A8ECC
			internal static bool YnVWfJ58SSBBH5ETcdJ9()
			{
				return false;
			}

			// Token: 0x040048DE RID: 18654
			internal Vector3 $myPosition$30289;

			// Token: 0x040048DF RID: 18655
			internal Vector3 $myDirection$30290;

			// Token: 0x040048E0 RID: 18656
			internal UnityScript.Lang.Array $nArray$30291;

			// Token: 0x040048E1 RID: 18657
			internal Mellon $self_$30292;
		}
	}
}
