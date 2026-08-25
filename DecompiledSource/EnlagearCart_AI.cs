using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A3A RID: 2618
[Serializable]
public class EnlagearCart_AI : MonoBehaviour
{
	// Token: 0x06003946 RID: 14662 RVA: 0x007817E8 File Offset: 0x0077F9E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnlagearCart_AI()
	{
		if (126323 - 167150 != -40827)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (285320 - 466191 != -180870)
			{
				base..ctor();
				if (204549 - 348962 != -144412)
				{
					this.BaQ9wxOjfh = "none";
					if (13013 - 450302 != -437288)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003947 RID: 14663 RVA: 0x00781884 File Offset: 0x0077FA84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.Xu19Ls7haT = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06003948 RID: 14664 RVA: 0x007818A4 File Offset: 0x0077FAA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (221593 - 597350 != -375757)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (90616 - 185395 != -94779)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (83327 - 340056 == -256728)
				{
					continue;
				}
			}
			if (this.Xu19Ls7haT.isControlled)
			{
				break;
			}
			if (90625 - 494706 != -404080)
			{
				this.AIControl();
				if (38573 - 466547 == -427974)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003949 RID: 14665 RVA: 0x00781970 File Offset: 0x0077FB70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (13960 - 356663 != -342703)
		{
		}
		for (;;)
		{
			if (this.Xu19Ls7haT.actionState != "standby")
			{
				if (281793 - 426474 == -144680)
				{
					continue;
				}
				if (this.Xu19Ls7haT.actionState != "run")
				{
					if (52315 - 246575 != -194259)
					{
						break;
					}
					continue;
				}
			}
			this.GVw9N0LZJs = (float)0;
			if (34745 - 46460 != -11714)
			{
				if (this.Xu19Ls7haT.isMine)
				{
					if (42154 - 34658 == 7496)
					{
						if (Game.mGameCode != 911)
						{
							break;
						}
						if (225587 - 91559 == 134028)
						{
							this.AI_wayPoint(3f, 1f);
							if (58593 - 571735 != -513141)
							{
								this.AI_resetTimer();
								if (26384 - 507424 != -481039)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					float num = this.Xu19Ls7haT.moveSpeed;
					if (101323 - 216006 == -114683)
					{
						float runSpeed = this.Xu19Ls7haT.runSpeed;
						if (9003 - 531791 == -522788)
						{
							Vector3 vector = default(Vector3);
							if (57924 - 153516 == -95592)
							{
								Vector3 vector2 = Vector3.zero;
								if (140918 - 89609 == 51309)
								{
									if ((this.Xu19Ls7haT.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (55653 - 204664 == -149010)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.Xu19Ls7haT.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (104868 - 363335 != -258467)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (145500 - 458399 == -312898)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (270483 - 493140 == -222656)
											{
												continue;
											}
											num = (float)0;
											if (9447 - 259025 != -249578)
											{
												continue;
											}
											this.transform.position = this.Xu19Ls7haT.nPosition;
											if (83234 - 115634 != -32400)
											{
												continue;
											}
										}
										else if (lhs.magnitude > num * (float)2)
										{
											if (192510 - 497887 == -305376)
											{
												continue;
											}
											this.transform.position = this.Xu19Ls7haT.nPosition - 0.2f * runSpeed * lhs.normalized;
											if (117994 - 573932 == -455937)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (291139 - 70816 == 220324)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (72269 - 168428 != -96159)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (190645 - 458719 != -268074)
											{
												continue;
											}
											this.animation.CrossFade("walk", 0.2f);
											if (73224 - 535755 == -462530)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (29945 - 467944 != -437999)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (153500 - 581126 != -427626)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (224661 - 507875 == -283213)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (160125 - 314887 != -154762)
											{
												continue;
											}
										}
									}
									this.Xu19Ls7haT.vMovement = vector2;
									if (288076 - 232328 == 55748)
									{
										this.Xu19Ls7haT.moveSpeed = num;
										if (64676 - 207237 != -142560)
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

	// Token: 0x0600394A RID: 14666 RVA: 0x00781E90 File Offset: 0x00780090
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_wayPoint(float mTime, float rTimer)
	{
		if (283335 - 394241 != -110906)
		{
		}
		do
		{
			if (Time.time - this.a0B9UvxWxB >= this.GVw9N0LZJs)
			{
				if (54260 - 530062 == -475801)
				{
					continue;
				}
				if (Time.time - this.a0B9UvxWxB < this.GVw9N0LZJs + mTime)
				{
					if (219728 - 599973 != -380245)
					{
						continue;
					}
					if (!this.hm79PhbO3W)
					{
						if (162923 - 121926 == 40998)
						{
							continue;
						}
						if (this.RJr9Esdem2 < 20)
						{
							if (111877 - 553145 == -441267)
							{
								continue;
							}
							this.RJr9Esdem2++;
							if (29815 - 318267 != -288452)
							{
								continue;
							}
							this.hm79PhbO3W = GameObject.Find("WayPoint" + this.RJr9Esdem2);
							if (295781 - 258859 == 36923)
							{
								continue;
							}
						}
					}
					if (this.hm79PhbO3W)
					{
						if (137232 - 444662 != -307430)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(this.hm79PhbO3W.transform.position - this.transform.position);
						if (9900 - 402412 == -392511)
						{
							continue;
						}
						float sqrMagnitude = vector.sqrMagnitude;
						if (240930 - 192959 != 47971)
						{
							continue;
						}
						if (sqrMagnitude < (float)3)
						{
							if (192872 - 505492 == -312619)
							{
								continue;
							}
							this.hm79PhbO3W = null;
							if (281371 - 584671 == -303299)
							{
								continue;
							}
						}
						else
						{
							this.BaQ9wxOjfh = "waypoint";
							if (188632 - 313399 == -124766)
							{
								continue;
							}
							this.Xu19Ls7haT.vMovement = vector.normalized;
							if (82092 - 216628 != -134536)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.Xu19Ls7haT.vMovement);
							if (137958 - 206852 == -68893)
							{
								continue;
							}
							this.Xu19Ls7haT.actionState = "run";
							if (188545 - 59531 == 129015)
							{
								continue;
							}
							this.animation.Play("walk");
							if (221905 - 147124 == 74782)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (161327 - 552071 == -390743)
							{
								continue;
							}
							this.Xu19Ls7haT.moveSpeed = Mathf.Lerp(this.Xu19Ls7haT.moveSpeed, this.Xu19Ls7haT.runSpeed, (float)4 * Time.deltaTime);
							if (221500 - 241229 != -19729)
							{
								continue;
							}
						}
					}
				}
			}
			this.GVw9N0LZJs += mTime;
		}
		while (91157 - 552087 != -460930);
	}

	// Token: 0x0600394B RID: 14667 RVA: 0x00782224 File Offset: 0x00780424
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (78948 - 532185 != -453237)
		{
		}
		for (;;)
		{
			IL_52D:
			if (this.ltk9SVdop6 > Time.time)
			{
				if (197669 - 70360 == 127309)
				{
					break;
				}
			}
			else
			{
				this.ltk9SVdop6 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (10068 - 473593 != -463524)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (194823 - 48077 == 146746)
					{
						if (45644 - 293969 != -248324)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (38646 - 372337 != -333690)
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
									if (49596 - 523406 != -473810)
									{
										goto IL_52D;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (240368 - 270047 != -29679)
									{
										goto IL_52D;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (125978 - 181265 == -55286)
									{
										goto IL_52D;
									}
									bool flag = true;
									if (150513 - 544820 != -394307)
									{
										goto IL_52D;
									}
									eRace race = this.Xu19Ls7haT.Race;
									if (220960 - 443592 == -222631)
									{
										goto IL_52D;
									}
									if (race == eRace.Tails)
									{
										if (48263 - 599486 != -551223)
										{
											goto IL_52D;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_664;
										}
										if (195047 - 578889 == -383841)
										{
											goto IL_52D;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (64622 - 54917 != 9706)
											{
												goto IL_664;
											}
											goto IL_52D;
										}
										goto IL_4E7;
										IL_664:
										flag = false;
										if (88883 - 198034 == -109150)
										{
											goto IL_52D;
										}
									}
									else if (race == eRace.Plants)
									{
										if (144327 - 578249 == -433921)
										{
											goto IL_52D;
										}
										flag = false;
										if (166000 - 414843 == -248842)
										{
											goto IL_52D;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (9368 - 415917 != -406549)
										{
											goto IL_52D;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_680;
										}
										if (111145 - 406854 != -295709)
										{
											goto IL_52D;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (227510 - 218818 != 8692)
											{
												goto IL_52D;
											}
											goto IL_680;
										}
										goto IL_4E7;
										IL_680:
										flag = false;
										if (218969 - 215023 == 3947)
										{
											goto IL_52D;
										}
									}
									else if (race == eRace.Robots)
									{
										if (112859 - 34535 != 78324)
										{
											goto IL_52D;
										}
										flag = true;
										if (217837 - 404688 != -186851)
										{
											goto IL_52D;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (91798 - 557268 == -465469)
										{
											goto IL_52D;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_425;
										}
										if (64650 - 500250 == -435599)
										{
											goto IL_52D;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_425;
										}
										if (17460 - 226513 == -209052)
										{
											goto IL_52D;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (262466 - 532269 != -269802)
											{
												goto IL_425;
											}
											goto IL_52D;
										}
										goto IL_4E7;
										IL_425:
										flag = false;
										if (102600 - 182773 != -80173)
										{
											goto IL_52D;
										}
									}
									else if (race == eRace.Structure)
									{
										if (221409 - 302496 == -81086)
										{
											goto IL_52D;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (282860 - 115717 == 167144)
											{
												goto IL_52D;
											}
											flag = false;
											if (207588 - 449515 == -241926)
											{
												goto IL_52D;
											}
										}
									}
									IL_4E7:
									if (flag)
									{
										if (18518 - 369610 == -351091)
										{
											goto IL_52D;
										}
										if (characterControl.hp > 0)
										{
											if (199233 - 486308 == -287074)
											{
												goto IL_52D;
											}
											if (characterControl.recieveTarget)
											{
												if (105576 - 547135 != -441559)
												{
													goto IL_52D;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (208828 - 195376 != 13452)
													{
														goto IL_52D;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (71197 - 48882 == 22316)
														{
															goto IL_52D;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (56556 - 15827 != 40729)
														{
															goto IL_52D;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (55085 - 23367 != 31718)
															{
																goto IL_52D;
															}
															this.Xu19Ls7haT.myAttackTarget = gameObject;
															if (281017 - 479965 == -198947)
															{
																goto IL_52D;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (52851 - 402453 == -349601)
															{
																goto IL_52D;
															}
															this.Xu19Ls7haT.addHate(characterControl.ActorNr, 5);
															if (245941 - 114777 == 131165)
															{
																goto IL_52D;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (131509 - 205790 == -74280)
															{
																goto IL_52D;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (288564 - 157734 != 130830)
															{
																goto IL_52D;
															}
															if (num < (float)60)
															{
																if (51948 - 124789 == -72840)
																{
																	goto IL_52D;
																}
																if (characterControl.hp > 0)
																{
																	if (6442 - 323562 == -317119)
																	{
																		goto IL_52D;
																	}
																	this.Xu19Ls7haT.myAttackTarget = gameObject;
																	if (207240 - 184484 == 22757)
																	{
																		goto IL_52D;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (168423 - 591603 != -423180)
																	{
																		goto IL_52D;
																	}
																	this.Xu19Ls7haT.addHate(characterControl.ActorNr, 5);
																	if (111424 - 47360 == 64065)
																	{
																		goto IL_52D;
																	}
																}
															}
														}
														if (this.Xu19Ls7haT.myAttackTarget)
														{
															if (204650 - 209583 != -4933)
															{
																goto IL_52D;
															}
															this.Xu19Ls7haT.isAlert = true;
															if (278069 - 204208 != 73861)
															{
																goto IL_52D;
															}
															this.a0B9UvxWxB = Time.time;
															if (139250 - 496412 == -357161)
															{
																goto IL_52D;
															}
														}
													}
												}
											}
										}
									}
								}
								if (220558 - 202659 == 17899)
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

	// Token: 0x0600394C RID: 14668 RVA: 0x00782A3C File Offset: 0x00780C3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (37614 - 323057 != -285442)
		{
		}
		while (Time.time - this.a0B9UvxWxB > this.GVw9N0LZJs)
		{
			if (140826 - 371049 == -230223)
			{
				this.BaQ9wxOjfh = "none";
				if (197602 - 332973 == -135371)
				{
					this.a0B9UvxWxB = Time.time;
					if (13515 - 197434 == -183919)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600394D RID: 14669 RVA: 0x00782AF0 File Offset: 0x00780CF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600394E RID: 14670 RVA: 0x00782AF4 File Offset: 0x00780CF4
	internal static bool alq2DH5ELxK3xJShuuuD()
	{
		return true;
	}

	// Token: 0x0600394F RID: 14671 RVA: 0x00782AF8 File Offset: 0x00780CF8
	internal static bool dcfffH5EOYOX6xUWq48P()
	{
		return false;
	}

	// Token: 0x040047A2 RID: 18338
	private CharacterControl Xu19Ls7haT;

	// Token: 0x040047A3 RID: 18339
	private string BaQ9wxOjfh;

	// Token: 0x040047A4 RID: 18340
	private float a0B9UvxWxB;

	// Token: 0x040047A5 RID: 18341
	private float GVw9N0LZJs;

	// Token: 0x040047A6 RID: 18342
	private int RJr9Esdem2;

	// Token: 0x040047A7 RID: 18343
	private GameObject hm79PhbO3W;

	// Token: 0x040047A8 RID: 18344
	private float ltk9SVdop6;
}
