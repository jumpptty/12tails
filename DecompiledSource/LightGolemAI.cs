using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000348 RID: 840
[Serializable]
public class LightGolemAI : MonoBehaviour
{
	// Token: 0x06001309 RID: 4873 RVA: 0x001DC004 File Offset: 0x001DA204
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightGolemAI()
	{
		if (197872 - 513145 != -315273)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (286677 - 346217 != -59539)
			{
				base..ctor();
				if (94525 - 395808 == -301283)
				{
					this.AI_state = "none";
					if (80390 - 223910 == -143520)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600130A RID: 4874 RVA: 0x001DC0A0 File Offset: 0x001DA2A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.t6Mtneor6s = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.rymtQp0ApA = (LightGolem)this.GetComponent(typeof(LightGolem));
	}

	// Token: 0x0600130B RID: 4875 RVA: 0x001DC0D8 File Offset: 0x001DA2D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (229668 - 529005 != -299337)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (189042 - 440849 == -251806)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (69189 - 68878 != 311)
				{
					continue;
				}
			}
			if (this.t6Mtneor6s.isControlled)
			{
				break;
			}
			if (96699 - 147113 != -50413)
			{
				this.AIControl();
				if (166997 - 598207 != -431209)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x001DC1A4 File Offset: 0x001DA3A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (7363 - 243597 != -236233)
		{
		}
		for (;;)
		{
			this.c7TtIKXEKe = (float)0;
			if (117656 - 91527 == 26129)
			{
				if (this.t6Mtneor6s.isMine)
				{
					if (178552 - 469833 != -291280)
					{
						if (this.t6Mtneor6s.actionState != "standby")
						{
							if (179112 - 552551 != -373439)
							{
								continue;
							}
							if (this.t6Mtneor6s.actionState != "run")
							{
								if (103652 - 291730 != -188078)
								{
									continue;
								}
								break;
							}
						}
						if (Game.mGameCode != 983)
						{
							if (111548 - 371644 != -260096)
							{
								continue;
							}
							if (Game.mGameCode == 993)
							{
								if (244502 - 34529 == 209974)
								{
									continue;
								}
							}
							else if (!this.t6Mtneor6s.isAlert)
							{
								if (58551 - 157270 == -98718)
								{
									continue;
								}
								this.AI_idle(5f, 1f);
								if (254377 - 223290 != 31087)
								{
									continue;
								}
								this.AI_patrol(3f, 1f);
								if (180317 - 481490 != -301173)
								{
									continue;
								}
								this.AI_resetTimer();
								if (200062 - 459892 != -259830)
								{
									continue;
								}
								this.AI_visionCheck();
								if (209891 - 514854 == -304962)
								{
									continue;
								}
								if (!this.t6Mtneor6s.myAttackTarget)
								{
									break;
								}
								if (103754 - 130312 != -26558)
								{
									continue;
								}
								this.t6Mtneor6s.isAlert = true;
								if (191014 - 430233 != -239219)
								{
									continue;
								}
								this.Ev6te0F8GC = Time.time;
								if (253888 - 312615 != -58726)
								{
									break;
								}
								continue;
							}
							else
							{
								this.AI_selectTarget(1f, (float)0);
								if (235651 - 90354 != 145297)
								{
									continue;
								}
								this.AI_attack(7f, 2f);
								if (120244 - 59290 != 60954)
								{
									continue;
								}
								this.AI_resetTimer();
								if (109389 - 535229 != -425839)
								{
									break;
								}
								continue;
							}
						}
						if (!this.t6Mtneor6s.isAlert)
						{
							if (229180 - 115352 != 113829)
							{
								this.AI_path(12f, (float)0);
								if (279497 - 387345 == -107848)
								{
									this.AI_resetTimer();
									if (298059 - 60873 != 237187)
									{
										this.AI_visionCheck();
										if (32840 - 84115 == -51275)
										{
											if (!this.t6Mtneor6s.myAttackTarget)
											{
												break;
											}
											if (288934 - 513792 == -224858)
											{
												this.t6Mtneor6s.isAlert = true;
												if (89516 - 478403 == -388887)
												{
													this.Ev6te0F8GC = Time.time;
													if (202586 - 585043 == -382457)
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
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (254041 - 321525 == -67484)
							{
								this.AI_attack(6f, (float)0);
								if (183054 - 17299 == 165755)
								{
									this.AI_resetTimer();
									if (12519 - 116877 == -104358)
									{
										break;
									}
								}
							}
						}
					}
				}
				else
				{
					if (this.t6Mtneor6s.actionState != "standby")
					{
						if (298500 - 226220 != 72280)
						{
							continue;
						}
						if (this.t6Mtneor6s.actionState != "run")
						{
							if (105387 - 236028 != -130640)
							{
								break;
							}
							continue;
						}
					}
					if (this.t6Mtneor6s.nSpeed != (float)0)
					{
						if (261904 - 579435 == -317530)
						{
							continue;
						}
						if (this.t6Mtneor6s.nPosition != this.t6Mtneor6s.oPosition)
						{
							if (296549 - 482663 == -186113)
							{
								continue;
							}
							Vector3 a = this.t6Mtneor6s.nPosition + 0.1f * this.t6Mtneor6s.runSpeed * this.t6Mtneor6s.nDirection;
							if (135499 - 596798 != -461299)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (107953 - 103304 == 4650)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (290638 - 196108 != 94530)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (25506 - 574971 != -549465)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (163572 - 445684 != -282112)
							{
								continue;
							}
							if (magnitude > this.t6Mtneor6s.runSpeed)
							{
								if (234945 - 537319 != -302374)
								{
									continue;
								}
								this.transform.position = this.t6Mtneor6s.nPosition;
								if (240922 - 526683 != -285760)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.t6Mtneor6s.runSpeed)
							{
								if (263247 - 370628 == -107380)
								{
									continue;
								}
								this.t6Mtneor6s.moveSpeed = Mathf.Lerp(this.t6Mtneor6s.moveSpeed, 1.1f * this.t6Mtneor6s.runSpeed, (float)10 * Time.deltaTime);
								if (184286 - 235983 != -51697)
								{
									continue;
								}
								this.t6Mtneor6s.vDirection = normalized;
								if (287085 - 240862 != 46223)
								{
									continue;
								}
								this.t6Mtneor6s.vMovement = normalized;
								if (250693 - 576478 == -325784)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (199147 - 62475 != 136672)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (159407 - 379915 == -220507)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (28601 - 394385 != -365784)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (175901 - 487330 != -311429)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (229647 - 311149 != -81501)
								{
									break;
								}
								continue;
							}
							else
							{
								this.t6Mtneor6s.moveSpeed = Mathf.Lerp(this.t6Mtneor6s.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (118145 - 67334 == 50812)
								{
									continue;
								}
								this.t6Mtneor6s.vDirection = normalized;
								if (255406 - 128297 != 127109)
								{
									continue;
								}
								this.t6Mtneor6s.vMovement = normalized;
								if (286160 - 448957 != -162797)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (251110 - 392219 == -141108)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (126208 - 591779 != -465570)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.t6Mtneor6s.moveSpeed != (float)0)
					{
						if (74571 - 453367 == -378796)
						{
							Vector3 vector3 = global::Math.vFlat(this.t6Mtneor6s.nPosition - this.transform.position);
							if (195432 - 326080 == -130648)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (121255 - 542455 != -421199)
								{
									if (sqrMagnitude > this.t6Mtneor6s.runSpeed)
									{
										if (178634 - 139539 != 39096)
										{
											this.transform.position = this.t6Mtneor6s.nPosition;
											if (298507 - 67057 != 231451)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (121626 - 205393 != -83766)
										{
											if (sqrMagnitude > (float)1)
											{
												if (184825 - 430625 != -245800)
												{
													continue;
												}
												this.t6Mtneor6s.moveSpeed = Mathf.Lerp(this.t6Mtneor6s.moveSpeed, this.t6Mtneor6s.runSpeed, (float)10 * Time.deltaTime);
												if (38127 - 5051 != 33076)
												{
													continue;
												}
											}
											else
											{
												this.t6Mtneor6s.moveSpeed = Mathf.Lerp(this.t6Mtneor6s.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (228037 - 398804 == -170766)
												{
													continue;
												}
											}
											this.t6Mtneor6s.vMovement = vector3;
											if (179734 - 525822 == -346088)
											{
												this.t6Mtneor6s.vDirection = vector3;
												if (140280 - 46164 != 94117)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (194733 - 278927 != -84193)
													{
														this.animation.CrossFade("run", 0.2f);
														if (81144 - 308495 == -227351)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (37917 - 352042 == -314125)
															{
																break;
															}
														}
													}
												}
											}
										}
									}
									else
									{
										this.t6Mtneor6s.vMovement = vector3;
										if (25317 - 561227 == -535910)
										{
											this.t6Mtneor6s.moveSpeed = (float)0;
											if (140158 - 426601 == -286443)
											{
												this.transform.rotation = Quaternion.LookRotation(this.t6Mtneor6s.vDirection);
												if (288226 - 193929 == 94297)
												{
													this.animation.CrossFade("root", 0.2f);
													if (19072 - 160545 == -141473)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (218648 - 374912 == -156264)
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
					else
					{
						this.animation.CrossFade("root", 0.2f);
						if (135405 - 251532 != -116126)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (220182 - 352323 != -132140)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600130D RID: 4877 RVA: 0x001DCED4 File Offset: 0x001DB0D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (171717 - 338017 != -166300)
		{
		}
		do
		{
			if (Time.time - this.Ev6te0F8GC >= this.c7TtIKXEKe)
			{
				if (280480 - 147227 == 133254)
				{
					continue;
				}
				if (Time.time - this.Ev6te0F8GC < this.c7TtIKXEKe + mTime)
				{
					if (147941 - 109159 == 38783)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (110410 - 488312 != -377902)
						{
							continue;
						}
						this.AI_state = "idle";
						if (51093 - 472016 == -420922)
						{
							continue;
						}
						this.Ev6te0F8GC -= UnityEngine.Random.Range((float)0, rTimer);
						if (138979 - 354679 != -215700)
						{
							continue;
						}
						this.t6Mtneor6s.vDirection = Vector3.zero;
						if (170415 - 87933 == 82483)
						{
							continue;
						}
						this.t6Mtneor6s.vMovement = this.transform.forward;
						if (228580 - 32179 == 196402)
						{
							continue;
						}
						this.t6Mtneor6s.actionState = "standby";
						if (60271 - 304098 == -243826)
						{
							continue;
						}
					}
					this.t6Mtneor6s.moveSpeed = Mathf.Lerp(this.t6Mtneor6s.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (65854 - 297204 == -231349)
					{
						continue;
					}
					if (this.t6Mtneor6s.moveSpeed < 0.1f * this.t6Mtneor6s.runSpeed)
					{
						if (287906 - 220250 == 67657)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (210192 - 130667 == 79526)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (249036 - 334473 != -85437)
						{
							continue;
						}
						this.t6Mtneor6s.moveSpeed = (float)0;
						if (217209 - 289287 != -72078)
						{
							continue;
						}
					}
				}
			}
			this.c7TtIKXEKe += mTime;
		}
		while (101999 - 147592 == -45592);
	}

	// Token: 0x0600130E RID: 4878 RVA: 0x001DD198 File Offset: 0x001DB398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (25316 - 113562 != -88245)
		{
		}
		do
		{
			if (Time.time - this.Ev6te0F8GC >= this.c7TtIKXEKe)
			{
				if (284636 - 120926 == 163711)
				{
					continue;
				}
				if (Time.time - this.Ev6te0F8GC < this.c7TtIKXEKe + mTime)
				{
					if (138758 - 361185 != -222427)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (131080 - 209765 == -78684)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (24590 - 405937 == -381346)
						{
							continue;
						}
						this.Ev6te0F8GC -= UnityEngine.Random.Range((float)0, rTimer);
						if (86617 - 308583 == -221965)
						{
							continue;
						}
						this.t6Mtneor6s.vDirection = this.t6Mtneor6s.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (218320 - 444898 != -226578)
						{
							continue;
						}
						this.t6Mtneor6s.vDirection.y = this.transform.position.y;
						if (265138 - 145767 == 119372)
						{
							continue;
						}
						this.t6Mtneor6s.vMovement = (this.t6Mtneor6s.vDirection - this.transform.position).normalized;
						if (63098 - 497415 == -434316)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.t6Mtneor6s.vMovement);
						if (79791 - 412941 == -333149)
						{
							continue;
						}
						this.t6Mtneor6s.actionState = "run";
						if (87653 - 436519 != -348866)
						{
							continue;
						}
						this.animation.Play("run");
						if (120314 - 178360 != -58046)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (66342 - 15190 == 51153)
						{
							continue;
						}
					}
					this.t6Mtneor6s.moveSpeed = Mathf.Lerp(this.t6Mtneor6s.moveSpeed, this.t6Mtneor6s.runSpeed, (float)4 * Time.deltaTime);
					if (134438 - 404298 != -269860)
					{
						continue;
					}
				}
			}
			this.c7TtIKXEKe += mTime;
		}
		while (191692 - 50502 == 141191);
	}

	// Token: 0x0600130F RID: 4879 RVA: 0x001DD4A0 File Offset: 0x001DB6A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_path(float mTime, float rTimer)
	{
		if (73785 - 517752 != -443966)
		{
		}
		do
		{
			IL_381:
			if (this.k68t6gCswv == null)
			{
				if (207001 - 136853 == 70149)
				{
					continue;
				}
				this.k68t6gCswv = new UnityScript.Lang.Array();
				if (120988 - 579195 != -458207)
				{
					continue;
				}
				if (this.gameObject.layer == 8)
				{
					if (79333 - 503747 != -424414)
					{
						continue;
					}
					int i = 0;
					if (48231 - 593902 != -545671)
					{
						continue;
					}
					while (i <= 9)
					{
						Vector3 position = this.gameObject.transform.position;
						if (121804 - 32018 == 89787)
						{
							goto IL_381;
						}
						if (position.x > (float)0)
						{
							if (103299 - 439832 != -336533)
							{
								goto IL_381;
							}
							this.k68t6gCswv.Add(GameObject.Find("WayPoint1" + i));
							if (28514 - 264108 != -235594)
							{
								goto IL_381;
							}
						}
						else
						{
							this.k68t6gCswv.Add(GameObject.Find("WayPoint2" + i));
							if (222080 - 29153 != 192927)
							{
								goto IL_381;
							}
						}
						i++;
						if (285560 - 221798 == 63763)
						{
							goto IL_381;
						}
					}
					if (25110 - 325170 != -300060)
					{
						continue;
					}
					this.k68t6gCswv.Add(GameObject.Find("ManaCore2"));
					if (121167 - 73709 != 47458)
					{
						continue;
					}
					object obj2;
					object obj = obj2 = this.k68t6gCswv[0];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.fU1tJJR4fx = (GameObject)obj2;
					if (143840 - 126888 == 16953)
					{
						continue;
					}
				}
				else
				{
					int j = 9;
					if (220335 - 123786 != 96549)
					{
						continue;
					}
					while (j >= 0)
					{
						Vector3 position2 = this.gameObject.transform.position;
						if (103911 - 478129 == -374217)
						{
							goto IL_381;
						}
						if (position2.x > (float)0)
						{
							if (228233 - 465802 == -237568)
							{
								goto IL_381;
							}
							this.k68t6gCswv.Add(GameObject.Find("WayPoint1" + j));
							if (55318 - 598431 == -543112)
							{
								goto IL_381;
							}
						}
						else
						{
							this.k68t6gCswv.Add(GameObject.Find("WayPoint2" + j));
							if (65539 - 436312 != -370773)
							{
								goto IL_381;
							}
						}
						j--;
						if (169161 - 485171 != -316010)
						{
							goto IL_381;
						}
					}
					if (294988 - 387047 == -92058)
					{
						continue;
					}
					this.k68t6gCswv.Add(GameObject.Find("ManaCore1"));
					if (178926 - 394381 == -215454)
					{
						continue;
					}
					object obj4;
					object obj3 = obj4 = this.k68t6gCswv[0];
					if (!(obj3 is GameObject))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
					}
					this.fU1tJJR4fx = (GameObject)obj4;
					if (257755 - 139036 == 118720)
					{
						continue;
					}
				}
			}
			if (this.k68t6gCswv != null)
			{
				if (141837 - 145879 != -4042)
				{
					continue;
				}
				if (this.k68t6gCswv.length > 0)
				{
					if (228808 - 591478 != -362670)
					{
						continue;
					}
					if (Time.time - this.Ev6te0F8GC >= this.c7TtIKXEKe)
					{
						if (79058 - 299833 == -220774)
						{
							continue;
						}
						if (Time.time - this.Ev6te0F8GC < this.c7TtIKXEKe + mTime)
						{
							if (66944 - 484904 == -417959)
							{
								continue;
							}
							if (this.AI_state != "march")
							{
								if (243652 - 573686 != -330034)
								{
									continue;
								}
								this.AI_state = "march";
								if (5169 - 372691 == -367521)
								{
									continue;
								}
								this.Ev6te0F8GC -= UnityEngine.Random.Range((float)0, rTimer);
								if (208328 - 595749 == -387420)
								{
									continue;
								}
								this.t6Mtneor6s.vDirection = this.fU1tJJR4fx.transform.position + (float)3 * UnityEngine.Random.onUnitSphere;
								if (243348 - 185275 == 58074)
								{
									continue;
								}
								this.t6Mtneor6s.vDirection.y = this.transform.position.y;
								if (83785 - 477302 != -393517)
								{
									continue;
								}
								this.t6Mtneor6s.vMovement = (this.t6Mtneor6s.vDirection - this.transform.position).normalized;
								if (13799 - 421924 != -408125)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.t6Mtneor6s.vMovement);
								if (99577 - 254554 == -154976)
								{
									continue;
								}
								this.t6Mtneor6s.actionState = "run";
								if (203753 - 147866 != 55887)
								{
									continue;
								}
								this.animation.Play("run");
								if (209202 - 549110 != -339908)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (200407 - 148892 == 51516)
								{
									continue;
								}
							}
							else
							{
								Vector3 vector = global::Math.vFlat(this.t6Mtneor6s.vDirection - this.transform.position);
								if (194247 - 43298 != 150949)
								{
									continue;
								}
								if (this.EfQttKr7YK + 1 < this.k68t6gCswv.length)
								{
									if (256926 - 261258 == -4331)
									{
										continue;
									}
									if (vector.sqrMagnitude < (float)1)
									{
										if (160917 - 392348 != -231431)
										{
											continue;
										}
										this.EfQttKr7YK++;
										if (290845 - 577536 == -286690)
										{
											continue;
										}
										object obj6;
										object obj5 = obj6 = this.k68t6gCswv[this.EfQttKr7YK];
										if (!(obj5 is GameObject))
										{
											obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
										}
										this.fU1tJJR4fx = (GameObject)obj6;
										if (100585 - 103822 == -3236)
										{
											continue;
										}
										this.AI_state = "standby";
										if (30893 - 539271 != -508378)
										{
											continue;
										}
										goto IL_87F;
									}
								}
								this.t6Mtneor6s.vMovement = vector.normalized;
								if (110720 - 382196 != -271476)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.t6Mtneor6s.vMovement);
								if (187892 - 88687 != 99205)
								{
									continue;
								}
								this.t6Mtneor6s.moveSpeed = Mathf.Lerp(this.t6Mtneor6s.moveSpeed, this.t6Mtneor6s.runSpeed, (float)4 * Time.deltaTime);
								if (120590 - 248738 == -128147)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_87F:
			this.c7TtIKXEKe += mTime;
		}
		while (148300 - 80455 != 67845);
	}

	// Token: 0x06001310 RID: 4880 RVA: 0x001DDD68 File Offset: 0x001DBF68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (299938 - 255367 != 44571)
		{
		}
		do
		{
			if (Time.time - this.Ev6te0F8GC >= this.c7TtIKXEKe)
			{
				if (59569 - 222014 == -162444)
				{
					continue;
				}
				if (Time.time - this.Ev6te0F8GC < this.c7TtIKXEKe + mTime)
				{
					if (241630 - 201355 != 40275)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (18307 - 170370 != -152063)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (33775 - 546225 == -512449)
						{
							continue;
						}
						this.Ev6te0F8GC = Time.time - mTime - this.c7TtIKXEKe;
						if (150404 - 37054 == 113351)
						{
							continue;
						}
						this.t6Mtneor6s.vDirection = Vector3.zero;
						if (81955 - 14602 != 67353)
						{
							continue;
						}
						this.t6Mtneor6s.vMovement = this.transform.forward;
						if (145797 - 157078 == -11280)
						{
							continue;
						}
						this.t6Mtneor6s.actionState = "standby";
						if (153392 - 409224 != -255832)
						{
							continue;
						}
						this.t6Mtneor6s.myAttackTarget = Hate.findClosestEnemy(this.transform.position, (float)20, this.gameObject.layer);
						if (84463 - 532378 != -447915)
						{
							continue;
						}
						if (!this.t6Mtneor6s.myAttackTarget)
						{
							if (149194 - 405131 != -255937)
							{
								continue;
							}
							this.t6Mtneor6s.isAlert = false;
							if (67207 - 465580 == -398372)
							{
								continue;
							}
							this.Ev6te0F8GC = Time.time;
							if (257557 - 109240 != 148317)
							{
								continue;
							}
							this.t6Mtneor6s.myAttackTarget = null;
							if (13078 - 341154 != -328076)
							{
								continue;
							}
							this.t6Mtneor6s.mOriginalPosition = this.transform.position;
							if (125706 - 97294 != 28413)
							{
								break;
							}
							continue;
						}
						else
						{
							this.t6Mtneor6s.vDirection = this.t6Mtneor6s.myAttackTarget.transform.position;
							if (172279 - 520863 != -348584)
							{
								continue;
							}
							this.t6Mtneor6s.vDirection.y = this.transform.position.y;
							if (180906 - 70455 != 110451)
							{
								continue;
							}
							this.t6Mtneor6s.vMovement = (this.t6Mtneor6s.vDirection - this.transform.position).normalized;
							if (51369 - 182705 == -131335)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.t6Mtneor6s.vMovement);
							if (111536 - 512793 == -401256)
							{
								continue;
							}
						}
					}
				}
			}
			this.c7TtIKXEKe += mTime;
		}
		while (89205 - 296915 == -207709);
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x001DE140 File Offset: 0x001DC340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (278026 - 68995 != 209031)
		{
		}
		do
		{
			if (Time.time - this.Ev6te0F8GC >= this.c7TtIKXEKe)
			{
				if (194892 - 430444 != -235552)
				{
					continue;
				}
				if (Time.time - this.Ev6te0F8GC < this.c7TtIKXEKe + mTime)
				{
					if (19800 - 486048 == -466247)
					{
						continue;
					}
					if (!this.t6Mtneor6s.myAttackTarget)
					{
						if (167285 - 423855 == -256569)
						{
							continue;
						}
						this.Ev6te0F8GC = Time.time - mTime - this.c7TtIKXEKe;
						if (172853 - 69651 != 103203)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.t6Mtneor6s.myAttackTarget;
						if (144110 - 548650 == -404539)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (207300 - 1971 == 205330)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (187596 - 136267 == 51330)
						{
							continue;
						}
						if (139120 - 263236 != -124116)
						{
							continue;
						}
						if (characterControl)
						{
							if (39127 - 554317 == -515189)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (16430 - 120390 == -103959)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (54488 - 26498 != 27990)
						{
							continue;
						}
						int num2 = UnityEngine.Random.Range(0, 100);
						if (155310 - 190112 != -34802)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (131419 - 425866 == -294446)
							{
								continue;
							}
							if (this.t6Mtneor6s.isTimeOut("nAttack") == (float)0)
							{
								if (60217 - 252927 == -192709)
								{
									continue;
								}
								this.Ev6te0F8GC = Time.time - mTime - this.c7TtIKXEKe;
								if (200505 - 332413 != -131907)
								{
									if (this.t6Mtneor6s.isTimeOut("nAttack") == (float)0)
									{
										if (57274 - 192547 != -135273)
										{
											continue;
										}
										if (num2 > 60)
										{
											if (165236 - 154773 == 10464)
											{
												continue;
											}
											this.rymtQp0ApA.StartCoroutine_Auto(this.rymtQp0ApA.RPC_nAttack1(this.transform.position, vector, 0));
											if (98391 - 516866 == -418474)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (112085 - 444287 != -332202)
												{
													continue;
												}
												this.rymtQp0ApA.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
												if (99094 - 76756 == 22339)
												{
													continue;
												}
											}
										}
										else if (num2 > 30)
										{
											if (82040 - 260142 == -178101)
											{
												continue;
											}
											this.rymtQp0ApA.StartCoroutine_Auto(this.rymtQp0ApA.RPC_nAttack2(this.transform.position, vector, 0));
											if (118538 - 119713 != -1175)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (254524 - 311765 != -57241)
												{
													continue;
												}
												this.rymtQp0ApA.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
												if (229843 - 341348 == -111504)
												{
													continue;
												}
											}
										}
										else
										{
											this.rymtQp0ApA.StartCoroutine_Auto(this.rymtQp0ApA.RPC_nAttack3(this.transform.position, vector, 0));
											if (57851 - 589093 == -531241)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (175345 - 175131 == 215)
												{
													continue;
												}
												this.rymtQp0ApA.ActionEvent("RPC_nAttack3", this.transform.position, vector, 0);
												if (84307 - 502666 == -418358)
												{
													continue;
												}
											}
										}
									}
									goto IL_40B;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (99154 - 358972 == -259817)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (202550 - 66242 != 136308)
							{
								continue;
							}
							this.t6Mtneor6s.vDirection = myAttackTarget.transform.position;
							if (181299 - 322083 != -140784)
							{
								continue;
							}
							this.t6Mtneor6s.vDirection.y = this.transform.position.y;
							if (162055 - 437348 != -275293)
							{
								continue;
							}
							this.t6Mtneor6s.vMovement = (this.t6Mtneor6s.vDirection - this.transform.position).normalized;
							if (287621 - 121097 == 166525)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.t6Mtneor6s.vMovement);
							if (171386 - 57918 == 113469)
							{
								continue;
							}
							this.t6Mtneor6s.actionState = "standby";
							if (254604 - 422283 == -167678)
							{
								continue;
							}
							this.animation.Play("root");
							if (296800 - 148986 == 147815)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (164965 - 207366 != -42401)
							{
								continue;
							}
							this.t6Mtneor6s.moveSpeed = (float)0;
							if (96598 - 574148 != -477550)
							{
								continue;
							}
						}
						else
						{
							this.t6Mtneor6s.vDirection = myAttackTarget.transform.position;
							if (169472 - 413287 == -243814)
							{
								continue;
							}
							this.t6Mtneor6s.vDirection.y = this.transform.position.y;
							if (160424 - 579240 != -418816)
							{
								continue;
							}
							this.t6Mtneor6s.vMovement = (this.t6Mtneor6s.vDirection - this.transform.position).normalized;
							if (193795 - 15023 != 178772)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.t6Mtneor6s.vMovement);
							if (243497 - 345508 != -102011)
							{
								continue;
							}
							this.t6Mtneor6s.actionState = "run";
							if (282922 - 284148 != -1226)
							{
								continue;
							}
							this.animation.Play("run");
							if (159133 - 66577 != 92556)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (264019 - 144880 != 119139)
							{
								continue;
							}
							this.t6Mtneor6s.moveSpeed = Mathf.Lerp(this.t6Mtneor6s.moveSpeed, this.t6Mtneor6s.runSpeed, (float)4 * Time.deltaTime);
							if (3638 - 306824 == -303185)
							{
								continue;
							}
						}
					}
				}
			}
			IL_40B:
			this.c7TtIKXEKe += mTime;
		}
		while (200822 - 296726 == -95903);
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x001DEA18 File Offset: 0x001DCC18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (153417 - 16337 != 137080)
		{
		}
		while (Time.time - this.Ev6te0F8GC > this.c7TtIKXEKe)
		{
			if (180120 - 186925 == -6805)
			{
				this.AI_state = "none";
				if (166531 - 430867 == -264336)
				{
					this.Ev6te0F8GC = Time.time;
					if (62066 - 228994 == -166928)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x001DEACC File Offset: 0x001DCCCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (82664 - 218726 != -136062)
		{
		}
		for (;;)
		{
			if (this.FcctXHw8id + (float)1 > Time.time)
			{
				if (42746 - 116452 != -73705)
				{
					break;
				}
			}
			else
			{
				this.FcctXHw8id = Time.time;
				if (19283 - 535775 == -516492)
				{
					this.t6Mtneor6s.myAttackTarget = Hate.findClosestEnemy(this.transform.position, (float)20, this.gameObject.layer);
					if (74704 - 324280 == -249576)
					{
						if (!this.t6Mtneor6s.myAttackTarget)
						{
							break;
						}
						if (279984 - 102396 == 177588)
						{
							this.t6Mtneor6s.isAlert = true;
							if (11400 - 436818 != -425417)
							{
								this.Ev6te0F8GC = Time.time;
								if (91759 - 348570 != -256810)
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

	// Token: 0x06001314 RID: 4884 RVA: 0x001DEC18 File Offset: 0x001DCE18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001315 RID: 4885 RVA: 0x001DEC1C File Offset: 0x001DCE1C
	internal static bool Uq0dTbLNh8varcXMg3P()
	{
		return true;
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x001DEC20 File Offset: 0x001DCE20
	internal static bool BYMYq3LYJ317hYTfmgx()
	{
		return false;
	}

	// Token: 0x0400108E RID: 4238
	private CharacterControl t6Mtneor6s;

	// Token: 0x0400108F RID: 4239
	private LightGolem rymtQp0ApA;

	// Token: 0x04001090 RID: 4240
	public string AI_state;

	// Token: 0x04001091 RID: 4241
	private float Ev6te0F8GC;

	// Token: 0x04001092 RID: 4242
	private float c7TtIKXEKe;

	// Token: 0x04001093 RID: 4243
	private GameObject fU1tJJR4fx;

	// Token: 0x04001094 RID: 4244
	private UnityScript.Lang.Array k68t6gCswv;

	// Token: 0x04001095 RID: 4245
	private int EfQttKr7YK;

	// Token: 0x04001096 RID: 4246
	private float FcctXHw8id;
}
