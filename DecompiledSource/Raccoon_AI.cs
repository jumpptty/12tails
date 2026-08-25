using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D8D RID: 3469
[Serializable]
public class Raccoon_AI : MonoBehaviour
{
	// Token: 0x06004E23 RID: 20003 RVA: 0x0099BC5C File Offset: 0x00999E5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Raccoon_AI()
	{
		if (191428 - 576196 != -384767)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (187843 - 496231 != -308387)
			{
				base..ctor();
				if (106195 - 382674 == -276479)
				{
					this.AI_state = "none";
					if (215482 - 62457 == 153025)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004E24 RID: 20004 RVA: 0x0099BCF8 File Offset: 0x00999EF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.xMwcnOfv0WQ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.vfYcn2QFlZV = (Raccoon)this.GetComponent(typeof(Raccoon));
	}

	// Token: 0x06004E25 RID: 20005 RVA: 0x0099BD30 File Offset: 0x00999F30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (201174 - 524815 != -323641)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (268715 - 55129 == 213587)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (199126 - 79969 != 119157)
				{
					continue;
				}
			}
			if (this.xMwcnOfv0WQ.isControlled)
			{
				break;
			}
			if (73720 - 473381 != -399660)
			{
				this.AIControl();
				if (205718 - 500775 != -295056)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004E26 RID: 20006 RVA: 0x0099BDFC File Offset: 0x00999FFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (8908 - 361346 != -352437)
		{
		}
		for (;;)
		{
			this.WMhcnlckTRn = (float)0;
			if (146353 - 424992 == -278639)
			{
				if (this.xMwcnOfv0WQ.isMine)
				{
					if (250810 - 416972 != -166161)
					{
						if (this.xMwcnOfv0WQ.actionState != "standby")
						{
							if (72128 - 510783 != -438655)
							{
								continue;
							}
							if (this.xMwcnOfv0WQ.actionState != "run")
							{
								if (165820 - 501149 != -335328)
								{
									break;
								}
								continue;
							}
						}
						if (!this.xMwcnOfv0WQ.isAlert)
						{
							if (132781 - 590911 != -458129)
							{
								if (this.xMwcnOfv0WQ.isSummon)
								{
									if (58757 - 114484 != -55727)
									{
										continue;
									}
									if (this.xMwcnOfv0WQ.mSummoner != null)
									{
										if (287551 - 509666 == -222114)
										{
											continue;
										}
										Vector3 vector = this.xMwcnOfv0WQ.mSummoner.transform.position - this.transform.position;
										if (296433 - 25096 != 271338)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (1303 - 211806 == -210502)
												{
													continue;
												}
												this.AI_follow(this.xMwcnOfv0WQ.mSummoner);
												if (170128 - 275585 != -105457)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (165110 - 272974 != -107864)
												{
													continue;
												}
												this.AI_resetTimer();
												if (69978 - 341159 != -271181)
												{
													continue;
												}
												this.AI_visionCheck();
												if (246149 - 189645 == 56505)
												{
													continue;
												}
											}
											goto IL_328;
										}
										continue;
									}
								}
								this.AI_idle(3f, 1f);
								if (146657 - 485902 != -339245)
								{
									continue;
								}
								this.AI_patrol(1f, 0.25f);
								if (4605 - 189157 != -184552)
								{
									continue;
								}
								this.AI_resetTimer();
								if (12915 - 282985 == -270069)
								{
									continue;
								}
								this.AI_visionCheck();
								if (249789 - 570035 != -320246)
								{
									continue;
								}
								IL_328:
								if (!this.xMwcnOfv0WQ.myAttackTarget)
								{
									break;
								}
								if (60044 - 520264 != -460219)
								{
									this.xMwcnOfv0WQ.isAlert = true;
									if (31144 - 485535 == -454391)
									{
										this.c8ccnvHFYKv = Time.time;
										if (291929 - 298453 == -6524)
										{
											break;
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (166561 - 373772 == -207211)
							{
								this.AI_idle(3f, 1f);
								if (118420 - 535238 != -416817)
								{
									this.AI_attack(10f, (float)0);
									if (93352 - 151669 == -58317)
									{
										this.AI_resetTimer();
										if (83984 - 151114 != -67129)
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
					if (this.xMwcnOfv0WQ.actionState != "standby")
					{
						if (215997 - 400467 != -184470)
						{
							continue;
						}
						if (this.xMwcnOfv0WQ.actionState != "run")
						{
							if (95762 - 233221 != -137458)
							{
								break;
							}
							continue;
						}
					}
					float num = this.xMwcnOfv0WQ.moveSpeed;
					if (3803 - 561880 != -558076)
					{
						float runSpeed = this.xMwcnOfv0WQ.runSpeed;
						if (67057 - 481042 == -413985)
						{
							Vector3 vector2 = default(Vector3);
							if (131016 - 338508 == -207492)
							{
								Vector3 vector3 = Vector3.zero;
								if (26904 - 74957 == -48053)
								{
									if ((this.xMwcnOfv0WQ.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (146578 - 454540 != -307962)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.xMwcnOfv0WQ.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (144239 - 380959 == -236719)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (127845 - 440197 == -312351)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (201468 - 10865 == 190604)
											{
												continue;
											}
											num = (float)0;
											if (169626 - 227922 == -58295)
											{
												continue;
											}
											this.transform.position = this.xMwcnOfv0WQ.nPosition;
											if (106509 - 115716 == -9206)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (80324 - 11751 != 68573)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (221844 - 375126 != -153282)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (289492 - 145712 != 143780)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (58333 - 307413 != -249080)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (288204 - 597995 != -309791)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (35832 - 344118 == -308285)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (26862 - 355365 == -328502)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (50478 - 216624 != -166146)
											{
												continue;
											}
										}
									}
									this.xMwcnOfv0WQ.vMovement = vector3;
									if (131867 - 456329 != -324461)
									{
										this.xMwcnOfv0WQ.moveSpeed = num;
										if (93259 - 21549 == 71710)
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

	// Token: 0x06004E27 RID: 20007 RVA: 0x0099C5D8 File Offset: 0x0099A7D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (24701 - 145382 != -120680)
		{
		}
		do
		{
			if (Time.time - this.c8ccnvHFYKv >= this.WMhcnlckTRn)
			{
				if (124178 - 519182 != -395004)
				{
					continue;
				}
				if (Time.time - this.c8ccnvHFYKv < this.WMhcnlckTRn + mTime)
				{
					if (1637 - 495000 != -493363)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (183352 - 412945 == -229592)
						{
							continue;
						}
						this.AI_state = "idle";
						if (130874 - 215659 != -84785)
						{
							continue;
						}
						this.c8ccnvHFYKv -= UnityEngine.Random.Range((float)0, rTimer);
						if (123977 - 244337 == -120359)
						{
							continue;
						}
						this.xMwcnOfv0WQ.vDirection = Vector3.zero;
						if (288285 - 464584 == -176298)
						{
							continue;
						}
						this.xMwcnOfv0WQ.vMovement = this.transform.forward;
						if (273469 - 56677 != 216792)
						{
							continue;
						}
						this.xMwcnOfv0WQ.actionState = "standby";
						if (216072 - 419975 == -203902)
						{
							continue;
						}
					}
					this.xMwcnOfv0WQ.moveSpeed = Mathf.Lerp(this.xMwcnOfv0WQ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (235106 - 292571 != -57465)
					{
						continue;
					}
					if (this.xMwcnOfv0WQ.moveSpeed < 0.1f * this.xMwcnOfv0WQ.runSpeed)
					{
						if (209940 - 313241 == -103300)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (33313 - 372866 == -339552)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (133027 - 3594 == 129434)
						{
							continue;
						}
						this.xMwcnOfv0WQ.moveSpeed = (float)0;
						if (274856 - 434548 == -159691)
						{
							continue;
						}
					}
				}
			}
			this.WMhcnlckTRn += mTime;
		}
		while (186013 - 103879 != 82134);
	}

	// Token: 0x06004E28 RID: 20008 RVA: 0x0099C89C File Offset: 0x0099AA9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (218869 - 470657 != -251788)
		{
		}
		for (;;)
		{
			this.xMwcnOfv0WQ.vDirection = followObject.transform.position;
			if (272860 - 279855 != -6994)
			{
				this.xMwcnOfv0WQ.vDirection.y = this.transform.position.y;
				if (121722 - 130269 != -8546)
				{
					this.xMwcnOfv0WQ.vMovement = (this.xMwcnOfv0WQ.vDirection - this.transform.position).normalized;
					if (234814 - 213409 != 21406)
					{
						this.transform.rotation = Quaternion.LookRotation(this.xMwcnOfv0WQ.vMovement);
						if (264317 - 96082 == 168235)
						{
							this.xMwcnOfv0WQ.actionState = "run";
							if (10815 - 334191 != -323375)
							{
								this.animation.Play("run");
								if (62016 - 545961 != -483944)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (138758 - 74402 == 64356)
									{
										this.xMwcnOfv0WQ.moveSpeed = Mathf.Lerp(this.xMwcnOfv0WQ.moveSpeed, this.xMwcnOfv0WQ.runSpeed, (float)4 * Time.deltaTime);
										if (109706 - 243828 != -134121)
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

	// Token: 0x06004E29 RID: 20009 RVA: 0x0099CA84 File Offset: 0x0099AC84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (81872 - 392686 != -310813)
		{
		}
		do
		{
			if (Time.time - this.c8ccnvHFYKv >= this.WMhcnlckTRn)
			{
				if (31415 - 424825 == -393409)
				{
					continue;
				}
				if (Time.time - this.c8ccnvHFYKv < this.WMhcnlckTRn + mTime)
				{
					if (179494 - 579354 == -399859)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (208915 - 271303 == -62387)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (284530 - 271287 == 13244)
						{
							continue;
						}
						this.c8ccnvHFYKv -= UnityEngine.Random.Range((float)0, rTimer);
						if (97825 - 463574 == -365748)
						{
							continue;
						}
						this.xMwcnOfv0WQ.vDirection = this.xMwcnOfv0WQ.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (291215 - 290267 == 949)
						{
							continue;
						}
						this.xMwcnOfv0WQ.vDirection.y = this.transform.position.y;
						if (264600 - 39211 != 225389)
						{
							continue;
						}
						this.xMwcnOfv0WQ.vMovement = (this.xMwcnOfv0WQ.vDirection - this.transform.position).normalized;
						if (73884 - 320348 != -246464)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.xMwcnOfv0WQ.vMovement);
						if (24048 - 172236 == -148187)
						{
							continue;
						}
						this.xMwcnOfv0WQ.actionState = "run";
						if (213807 - 336418 != -122611)
						{
							continue;
						}
						this.animation.Play("run");
						if (252012 - 578388 == -326375)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (44279 - 350778 == -306498)
						{
							continue;
						}
					}
					this.xMwcnOfv0WQ.moveSpeed = Mathf.Lerp(this.xMwcnOfv0WQ.moveSpeed, this.xMwcnOfv0WQ.runSpeed, (float)4 * Time.deltaTime);
					if (192035 - 483466 == -291430)
					{
						continue;
					}
				}
			}
			this.WMhcnlckTRn += mTime;
		}
		while (87880 - 69177 == 18704);
	}

	// Token: 0x06004E2A RID: 20010 RVA: 0x0099CD8C File Offset: 0x0099AF8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (29636 - 211538 != -181902)
		{
		}
		do
		{
			if (Time.time - this.c8ccnvHFYKv >= this.WMhcnlckTRn)
			{
				if (12396 - 156505 != -144109)
				{
					continue;
				}
				if (Time.time - this.c8ccnvHFYKv < this.WMhcnlckTRn + mTime)
				{
					if (65088 - 366800 == -301711)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (124466 - 26288 != 98178)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (38518 - 586163 != -547645)
						{
							continue;
						}
						this.c8ccnvHFYKv = Time.time - mTime - this.WMhcnlckTRn;
						if (251221 - 13027 == 238195)
						{
							continue;
						}
						this.xMwcnOfv0WQ.vDirection = Vector3.zero;
						if (248745 - 5419 == 243327)
						{
							continue;
						}
						this.xMwcnOfv0WQ.vMovement = this.transform.forward;
						if (145524 - 412809 == -267284)
						{
							continue;
						}
						this.xMwcnOfv0WQ.actionState = "standby";
						if (50090 - 84600 != -34510)
						{
							continue;
						}
						this.xMwcnOfv0WQ.myAttackTarget = this.xMwcnOfv0WQ.getHateTarget(5, 50);
						if (131892 - 394443 != -262551)
						{
							continue;
						}
						if (!this.xMwcnOfv0WQ.myAttackTarget)
						{
							if (203603 - 447866 == -244262)
							{
								continue;
							}
							this.xMwcnOfv0WQ.isAlert = false;
							if (279116 - 405989 == -126872)
							{
								continue;
							}
							this.c8ccnvHFYKv = Time.time;
							if (73235 - 446743 != -373508)
							{
								continue;
							}
							this.xMwcnOfv0WQ.myAttackTarget = null;
							if (210220 - 283469 != -73249)
							{
								continue;
							}
							this.xMwcnOfv0WQ.mOriginalPosition = this.transform.position;
							if (86915 - 532087 != -445171)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.xMwcnOfv0WQ.myAttackTarget;
							if (297679 - 530476 == -232796)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (174721 - 158607 == 16115)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (42605 - 275480 == -232874)
								{
									continue;
								}
								this.xMwcnOfv0WQ.isAlert = false;
								if (131267 - 333215 == -201947)
								{
									continue;
								}
								this.c8ccnvHFYKv = Time.time;
								if (125266 - 17508 != 107758)
								{
									continue;
								}
								this.xMwcnOfv0WQ.myAttackTarget = null;
								if (294314 - 429022 != -134708)
								{
									continue;
								}
							}
							else
							{
								this.xMwcnOfv0WQ.vDirection = myAttackTarget.transform.position;
								if (122663 - 382448 == -259784)
								{
									continue;
								}
								this.xMwcnOfv0WQ.vDirection.y = this.transform.position.y;
								if (14963 - 18305 == -3341)
								{
									continue;
								}
								this.xMwcnOfv0WQ.vMovement = (this.xMwcnOfv0WQ.vDirection - this.transform.position).normalized;
								if (56784 - 64227 != -7443)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.xMwcnOfv0WQ.vMovement);
								if (49448 - 443832 == -394383)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.WMhcnlckTRn += mTime;
		}
		while (253637 - 229164 != 24473);
	}

	// Token: 0x06004E2B RID: 20011 RVA: 0x0099D23C File Offset: 0x0099B43C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (66641 - 52160 != 14481)
		{
		}
		do
		{
			if (Time.time - this.c8ccnvHFYKv >= this.WMhcnlckTRn)
			{
				if (165164 - 213297 != -48133)
				{
					continue;
				}
				if (Time.time - this.c8ccnvHFYKv < this.WMhcnlckTRn + mTime)
				{
					if (64985 - 145019 == -80033)
					{
						continue;
					}
					if (!this.xMwcnOfv0WQ.myAttackTarget)
					{
						if (157789 - 39388 == 118402)
						{
							continue;
						}
						this.c8ccnvHFYKv = Time.time - mTime - this.WMhcnlckTRn;
						if (95940 - 588721 != -492781)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.xMwcnOfv0WQ.myAttackTarget;
						if (294063 - 222140 != 71923)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (117060 - 529598 == -412537)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (200717 - 544754 != -344037)
						{
							continue;
						}
						if (97652 - 455462 != -357810)
						{
							continue;
						}
						if (characterControl)
						{
							if (88276 - 440815 == -352538)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (250880 - 145807 != 105073)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (187383 - 536856 == -349472)
						{
							continue;
						}
						if (this.xMwcnOfv0WQ.isTimeOut("nAttack") == (float)0)
						{
							if (296430 - 201785 == 94646)
							{
								continue;
							}
							this.c8ccnvHFYKv = Time.time - mTime - this.WMhcnlckTRn;
							if (286222 - 395635 != -109413)
							{
								continue;
							}
							UnityScript.Lang.Array array = global::Math.removeObject(Hate.findFriends(this.transform.position, (float)40, this.gameObject.layer), this.gameObject);
							if (280046 - 545866 == -265819)
							{
								continue;
							}
							if (array.length > 0)
							{
								if (272458 - 485318 == -212859)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = array[UnityEngine.Random.Range(0, array.length)];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj2;
								if (177014 - 306910 == -129895)
								{
									continue;
								}
								if (gameObject)
								{
									if (42554 - 507170 != -464616)
									{
										continue;
									}
									Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.transform.position);
									if (134763 - 503787 != -369024)
									{
										continue;
									}
									vector = vector2.normalized;
									if (25187 - 361346 == -336158)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (148238 - 363855 != -215617)
									{
										continue;
									}
									if (characterControl)
									{
										if (135515 - 573847 == -438331)
										{
											continue;
										}
										this.vfYcn2QFlZV.StartCoroutine_Auto(this.vfYcn2QFlZV.RPC_cheer(this.transform.position, vector, characterControl.ActorNr));
										if (191715 - 479601 != -287886)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (49948 - 185440 != -135492)
											{
												continue;
											}
											this.vfYcn2QFlZV.ActionEvent("RPC_cheer", this.transform.position, vector, characterControl.ActorNr);
											if (98429 - 305101 != -206672)
											{
												continue;
											}
										}
									}
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (250741 - 274458 == -23716)
							{
								continue;
							}
							if (num < (float)6)
							{
								if (283289 - 371234 != -87945)
								{
									continue;
								}
								this.xMwcnOfv0WQ.vDirection = myAttackTarget.transform.position;
								if (140507 - 250949 == -110441)
								{
									continue;
								}
								this.xMwcnOfv0WQ.vDirection.y = this.transform.position.y;
								if (13113 - 185093 != -171980)
								{
									continue;
								}
								this.xMwcnOfv0WQ.vMovement = (this.transform.position - this.xMwcnOfv0WQ.vDirection).normalized;
								if (163691 - 14159 != 149532)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.xMwcnOfv0WQ.vMovement);
								if (181746 - 240541 != -58795)
								{
									continue;
								}
								this.xMwcnOfv0WQ.actionState = "run";
								if (225444 - 532134 == -306689)
								{
									continue;
								}
								this.animation.Play("run");
								if (175721 - 217414 != -41693)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (255866 - 508757 != -252891)
								{
									continue;
								}
								this.xMwcnOfv0WQ.moveSpeed = Mathf.Lerp(this.xMwcnOfv0WQ.moveSpeed, this.xMwcnOfv0WQ.runSpeed, (float)4 * Time.deltaTime);
								if (227407 - 411954 != -184547)
								{
									continue;
								}
							}
							else
							{
								this.xMwcnOfv0WQ.actionState = "standby";
								if (3970 - 410114 != -406144)
								{
									continue;
								}
								this.animation.CrossFade("root", (float)1);
								if (54440 - 129703 == -75262)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (292798 - 265805 == 26994)
								{
									continue;
								}
								this.xMwcnOfv0WQ.moveSpeed = Mathf.Lerp(this.xMwcnOfv0WQ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (55727 - 6629 != 49098)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.WMhcnlckTRn += mTime;
		}
		while (73312 - 297988 == -224675);
	}

	// Token: 0x06004E2C RID: 20012 RVA: 0x0099D9E8 File Offset: 0x0099BBE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (182453 - 499297 != -316843)
		{
		}
		while (Time.time - this.c8ccnvHFYKv > this.WMhcnlckTRn)
		{
			if (216933 - 412404 == -195471)
			{
				this.AI_state = "none";
				if (90698 - 65167 != 25532)
				{
					this.c8ccnvHFYKv = Time.time;
					if (298147 - 359521 != -61373)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004E2D RID: 20013 RVA: 0x0099DA9C File Offset: 0x0099BC9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (110337 - 498845 != -388507)
		{
		}
		for (;;)
		{
			IL_694:
			if (this.K9JcnGX2imX > Time.time)
			{
				if (3792 - 225854 == -222062)
				{
					break;
				}
			}
			else
			{
				this.K9JcnGX2imX = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (33840 - 593893 != -560052)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (3201 - 65373 != -62171)
					{
						if (33495 - 462387 == -428892)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (284636 - 167133 == 117503)
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
									if (179394 - 275699 != -96305)
									{
										goto IL_694;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (269238 - 505663 == -236424)
									{
										goto IL_694;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (71939 - 507399 != -435460)
									{
										goto IL_694;
									}
									bool flag = true;
									if (177354 - 414728 != -237374)
									{
										goto IL_694;
									}
									eRace race = this.xMwcnOfv0WQ.Race;
									if (74812 - 47075 != 27737)
									{
										goto IL_694;
									}
									if (race == eRace.Tails)
									{
										if (258395 - 200977 == 57419)
										{
											goto IL_694;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_354;
										}
										if (126522 - 182584 != -56062)
										{
											goto IL_694;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (222062 - 262335 != -40272)
											{
												goto IL_354;
											}
											goto IL_694;
										}
										goto IL_116;
										IL_354:
										flag = false;
										if (273968 - 390540 == -116571)
										{
											goto IL_694;
										}
									}
									else if (race == eRace.Plants)
									{
										if (43377 - 314367 != -270990)
										{
											goto IL_694;
										}
										flag = false;
										if (17482 - 123053 == -105570)
										{
											goto IL_694;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (296253 - 398449 != -102196)
										{
											goto IL_694;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_F5;
										}
										if (298171 - 260001 != 38170)
										{
											goto IL_694;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (242364 - 422870 != -180506)
											{
												goto IL_694;
											}
											goto IL_F5;
										}
										goto IL_116;
										IL_F5:
										flag = false;
										if (285947 - 414130 != -128183)
										{
											goto IL_694;
										}
									}
									else if (race == eRace.Robots)
									{
										if (261736 - 136266 == 125471)
										{
											goto IL_694;
										}
										flag = true;
										if (53851 - 137480 == -83628)
										{
											goto IL_694;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (252696 - 237444 == 15253)
										{
											goto IL_694;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_257;
										}
										if (101364 - 345545 == -244180)
										{
											goto IL_694;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_257;
										}
										if (209571 - 74339 != 135232)
										{
											goto IL_694;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (56318 - 109095 != -52777)
											{
												goto IL_694;
											}
											goto IL_257;
										}
										goto IL_116;
										IL_257:
										flag = false;
										if (962 - 164770 != -163808)
										{
											goto IL_694;
										}
									}
									else if (race == eRace.Structure)
									{
										if (271712 - 272388 == -675)
										{
											goto IL_694;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (10547 - 27488 == -16940)
											{
												goto IL_694;
											}
											flag = false;
											if (158664 - 336844 != -178180)
											{
												goto IL_694;
											}
										}
									}
									IL_116:
									if (flag)
									{
										if (256211 - 282903 == -26691)
										{
											goto IL_694;
										}
										if (characterControl.hp > 0)
										{
											if (14366 - 465123 == -450756)
											{
												goto IL_694;
											}
											if (characterControl.recieveTarget)
											{
												if (72453 - 82510 == -10056)
												{
													goto IL_694;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (52316 - 334898 == -282581)
													{
														goto IL_694;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (123577 - 227465 == -103887)
														{
															goto IL_694;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (169613 - 208683 != -39070)
														{
															goto IL_694;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (14115 - 283411 == -269295)
															{
																goto IL_694;
															}
															this.xMwcnOfv0WQ.myAttackTarget = gameObject;
															if (273513 - 431437 == -157923)
															{
																goto IL_694;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (275235 - 105682 != 169553)
															{
																goto IL_694;
															}
															this.xMwcnOfv0WQ.addHate(characterControl.ActorNr, 5);
															if (99080 - 184969 == -85888)
															{
																goto IL_694;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (79334 - 272726 != -193392)
															{
																goto IL_694;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (55953 - 586809 == -530855)
															{
																goto IL_694;
															}
															if (num < (float)60)
															{
																if (111115 - 323134 == -212018)
																{
																	goto IL_694;
																}
																if (characterControl.hp > 0)
																{
																	if (177065 - 159749 != 17316)
																	{
																		goto IL_694;
																	}
																	this.xMwcnOfv0WQ.myAttackTarget = gameObject;
																	if (183262 - 483770 == -300507)
																	{
																		goto IL_694;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (157652 - 20764 != 136888)
																	{
																		goto IL_694;
																	}
																	this.xMwcnOfv0WQ.addHate(characterControl.ActorNr, 5);
																	if (172416 - 97965 != 74451)
																	{
																		goto IL_694;
																	}
																}
															}
														}
														if (this.xMwcnOfv0WQ.myAttackTarget)
														{
															if (225548 - 200415 != 25133)
															{
																goto IL_694;
															}
															this.xMwcnOfv0WQ.isAlert = true;
															if (78749 - 147433 == -68683)
															{
																goto IL_694;
															}
															this.c8ccnvHFYKv = Time.time;
															if (192374 - 295893 == -103518)
															{
																goto IL_694;
															}
														}
													}
												}
											}
										}
									}
								}
								if (154711 - 242316 != -87604)
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

	// Token: 0x06004E2E RID: 20014 RVA: 0x0099E2B4 File Offset: 0x0099C4B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004E2F RID: 20015 RVA: 0x0099E2B8 File Offset: 0x0099C4B8
	internal static bool pxed5l5bjwHeuvRC5Bsx()
	{
		return true;
	}

	// Token: 0x06004E30 RID: 20016 RVA: 0x0099E2BC File Offset: 0x0099C4BC
	internal static bool WnUAPP5bhxVxtuNXyxBI()
	{
		return false;
	}

	// Token: 0x0400582B RID: 22571
	private CharacterControl xMwcnOfv0WQ;

	// Token: 0x0400582C RID: 22572
	private Raccoon vfYcn2QFlZV;

	// Token: 0x0400582D RID: 22573
	public string AI_state;

	// Token: 0x0400582E RID: 22574
	private float c8ccnvHFYKv;

	// Token: 0x0400582F RID: 22575
	private float WMhcnlckTRn;

	// Token: 0x04005830 RID: 22576
	private float K9JcnGX2imX;
}
