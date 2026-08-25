using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D1B RID: 3355
[Serializable]
public class Mouse_AI : MonoBehaviour
{
	// Token: 0x06004B5B RID: 19291 RVA: 0x00950320 File Offset: 0x0094E520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mouse_AI()
	{
		if (269606 - 364555 != -94949)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (158377 - 533362 == -374985)
			{
				base..ctor();
				if (149479 - 472415 != -322935)
				{
					this.AI_state = "none";
					if (176286 - 357118 == -180832)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004B5C RID: 19292 RVA: 0x009503BC File Offset: 0x0094E5BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (119298 - 53041 != 66257)
		{
		}
		for (;;)
		{
			this.iScc59jS2KP = this.transform;
			if (271003 - 545043 != -274039)
			{
				this.tGyc5WZ2S9a = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (262846 - 27164 == 235682)
				{
					this.lGyc5u1ft7N = (Mouse)this.GetComponent(typeof(Mouse));
					if (141862 - 462172 == -320310)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004B5D RID: 19293 RVA: 0x00950484 File Offset: 0x0094E684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (280253 - 409816 != -129562)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (129160 - 418558 == -289397)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (178260 - 179297 != -1037)
				{
					continue;
				}
			}
			if (this.tGyc5WZ2S9a.isControlled)
			{
				break;
			}
			if (260351 - 400307 != -139955)
			{
				this.AIControl();
				if (86633 - 458475 == -371842)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004B5E RID: 19294 RVA: 0x00950550 File Offset: 0x0094E750
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (184361 - 59931 != 124431)
		{
		}
		for (;;)
		{
			this.UxJc5VEEKhU = (float)0;
			if (25289 - 63274 != -37984)
			{
				if (this.tGyc5WZ2S9a.isMine)
				{
					if (98857 - 537585 == -438728)
					{
						if (this.tGyc5WZ2S9a.actionState != "standby")
						{
							if (168307 - 9652 == 158656)
							{
								continue;
							}
							if (this.tGyc5WZ2S9a.actionState != "run")
							{
								if (116746 - 56176 != 60571)
								{
									break;
								}
								continue;
							}
						}
						if (!this.tGyc5WZ2S9a.isAlert)
						{
							if (125561 - 573786 == -448225)
							{
								if (this.tGyc5WZ2S9a.isSummon)
								{
									if (35655 - 222908 == -187252)
									{
										continue;
									}
									if (this.tGyc5WZ2S9a.mSummoner != null)
									{
										if (158394 - 566523 == -408128)
										{
											continue;
										}
										Vector3 vector = this.tGyc5WZ2S9a.mSummoner.transform.position - this.transform.position;
										if (17200 - 467762 != -450561)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (56136 - 178184 != -122048)
												{
													continue;
												}
												this.AI_follow(this.tGyc5WZ2S9a.mSummoner);
												if (55258 - 132543 == -77284)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (23891 - 4234 == 19658)
												{
													continue;
												}
												this.AI_resetTimer();
												if (176432 - 364012 == -187579)
												{
													continue;
												}
												this.AI_visionCheck();
												if (78910 - 385112 != -306202)
												{
													continue;
												}
											}
											goto IL_7DF;
										}
										continue;
									}
								}
								if (Game.mGameCode == 916)
								{
									if (122647 - 364146 == -241498)
									{
										continue;
									}
									this.AI_idle(5f, 1f);
									if (169442 - 444730 != -275288)
									{
										continue;
									}
									this.AI_goToPosition(this.tGyc5WZ2S9a.mOriginalPosition, 6f, 2f);
									if (212746 - 373990 != -161244)
									{
										continue;
									}
									this.AI_resetTimer();
									if (74662 - 493004 == -418341)
									{
										continue;
									}
									this.AI_visionCheck();
									if (39771 - 409348 != -369577)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (95402 - 567554 != -472152)
									{
										continue;
									}
									this.AI_patrol(2f, 1f);
									if (298255 - 544532 == -246276)
									{
										continue;
									}
									this.AI_resetTimer();
									if (134187 - 362327 == -228139)
									{
										continue;
									}
									this.AI_visionCheck();
									if (127464 - 46161 != 81303)
									{
										continue;
									}
								}
								IL_7DF:
								if (!this.tGyc5WZ2S9a.myAttackTarget)
								{
									break;
								}
								if (264689 - 385677 != -120987)
								{
									this.tGyc5WZ2S9a.isAlert = true;
									if (151355 - 344272 != -192916)
									{
										this.Bmnc5y5kpJM = Time.time;
										if (56736 - 566706 != -509969)
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
							if (98893 - 124232 != -25338)
							{
								this.AI_idle(1f, 0.5f);
								if (214348 - 599941 == -385593)
								{
									this.AI_attack(10f, (float)0);
									if (245985 - 111476 == 134509)
									{
										this.AI_resetTimer();
										if (45824 - 426074 != -380249)
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
					if (this.tGyc5WZ2S9a.actionState != "standby")
					{
						if (298294 - 28843 == 269452)
						{
							continue;
						}
						if (this.tGyc5WZ2S9a.actionState != "run")
						{
							if (81568 - 526353 != -444785)
							{
								continue;
							}
							break;
						}
					}
					float num = this.tGyc5WZ2S9a.moveSpeed;
					if (150985 - 44704 == 106281)
					{
						float runSpeed = this.tGyc5WZ2S9a.runSpeed;
						if (233184 - 594604 != -361419)
						{
							Vector3 vector2 = default(Vector3);
							if (220632 - 364760 != -144127)
							{
								Vector3 vector3 = Vector3.zero;
								if (54975 - 443856 == -388881)
								{
									if ((this.tGyc5WZ2S9a.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (272530 - 327992 == -55461)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.tGyc5WZ2S9a.nPosition - this.iScc59jS2KP.position, new Vector3((float)1, (float)0, (float)1));
										if (262879 - 267794 == -4914)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (275362 - 368874 == -93511)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (181497 - 444766 != -263269)
											{
												continue;
											}
											num = (float)0;
											if (250335 - 177922 == 72414)
											{
												continue;
											}
											this.transform.position = this.tGyc5WZ2S9a.nPosition;
											if (179181 - 432134 != -252953)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (79190 - 557707 != -478517)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (152997 - 212289 == -59291)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (242524 - 139911 == 102614)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (9160 - 251389 != -242229)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (40214 - 403829 != -363615)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.iScc59jS2KP.forward;
											if (291557 - 192650 != 98907)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (118487 - 455393 != -336906)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (291264 - 159055 == 132210)
											{
												continue;
											}
										}
									}
									this.tGyc5WZ2S9a.vMovement = vector3;
									if (266137 - 159849 == 106288)
									{
										this.tGyc5WZ2S9a.moveSpeed = num;
										if (173926 - 381987 == -208061)
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

	// Token: 0x06004B5F RID: 19295 RVA: 0x00950DF8 File Offset: 0x0094EFF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (202542 - 376285 != -173743)
		{
		}
		do
		{
			if (Time.time - this.Bmnc5y5kpJM >= this.UxJc5VEEKhU)
			{
				if (35286 - 9198 == 26089)
				{
					continue;
				}
				if (Time.time - this.Bmnc5y5kpJM < this.UxJc5VEEKhU + mTime)
				{
					if (19519 - 555197 != -535678)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (264202 - 414486 != -150284)
						{
							continue;
						}
						this.AI_state = "idle";
						if (214932 - 469271 == -254338)
						{
							continue;
						}
						this.Bmnc5y5kpJM -= UnityEngine.Random.Range((float)0, rTimer);
						if (117309 - 355402 != -238093)
						{
							continue;
						}
						this.tGyc5WZ2S9a.vDirection = Vector3.zero;
						if (23977 - 388316 != -364339)
						{
							continue;
						}
						this.tGyc5WZ2S9a.vMovement = this.iScc59jS2KP.forward;
						if (232019 - 295858 == -63838)
						{
							continue;
						}
						this.tGyc5WZ2S9a.actionState = "standby";
						if (259397 - 575554 != -316157)
						{
							continue;
						}
					}
					this.tGyc5WZ2S9a.moveSpeed = Mathf.Lerp(this.tGyc5WZ2S9a.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (144656 - 277340 == -132683)
					{
						continue;
					}
					if (this.tGyc5WZ2S9a.moveSpeed < 0.1f * this.tGyc5WZ2S9a.runSpeed)
					{
						if (251969 - 100435 == 151535)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (9871 - 457330 != -447459)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (260523 - 423893 == -163369)
						{
							continue;
						}
						this.tGyc5WZ2S9a.moveSpeed = (float)0;
						if (107825 - 8969 == 98857)
						{
							continue;
						}
					}
				}
			}
			this.UxJc5VEEKhU += mTime;
		}
		while (36270 - 199908 == -163637);
	}

	// Token: 0x06004B60 RID: 19296 RVA: 0x009510BC File Offset: 0x0094F2BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_goToPosition(Vector3 tPosition, float mTime, float rTimer)
	{
		if (247567 - 40266 != 207302)
		{
		}
		do
		{
			if (Time.time - this.Bmnc5y5kpJM >= this.UxJc5VEEKhU)
			{
				if (70262 - 542916 == -472653)
				{
					continue;
				}
				if (Time.time - this.Bmnc5y5kpJM < this.UxJc5VEEKhU + mTime)
				{
					if (76507 - 493344 != -416837)
					{
						continue;
					}
					if (this.AI_state != "goToPosition")
					{
						if (221732 - 425664 == -203931)
						{
							continue;
						}
						this.AI_state = "goToPosition";
						if (134094 - 290836 != -156742)
						{
							continue;
						}
						this.Bmnc5y5kpJM -= UnityEngine.Random.Range((float)0, rTimer);
						if (5663 - 66059 == -60395)
						{
							continue;
						}
					}
					Vector3 vector = this.iScc59jS2KP.position - tPosition;
					if (28244 - 426083 != -397839)
					{
						continue;
					}
					if (vector.sqrMagnitude > (float)1)
					{
						if (110029 - 348538 != -238509)
						{
							continue;
						}
						this.tGyc5WZ2S9a.vDirection = tPosition;
						if (12387 - 274230 == -261842)
						{
							continue;
						}
						this.tGyc5WZ2S9a.vDirection.y = this.iScc59jS2KP.position.y;
						if (39381 - 439168 == -399786)
						{
							continue;
						}
						this.tGyc5WZ2S9a.vMovement = (tPosition - this.iScc59jS2KP.position).normalized;
						if (81340 - 420504 != -339164)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.tGyc5WZ2S9a.vMovement);
						if (256244 - 504671 == -248426)
						{
							continue;
						}
						this.tGyc5WZ2S9a.actionState = "run";
						if (133460 - 527070 == -393609)
						{
							continue;
						}
						this.animation.Play("run");
						if (182032 - 592333 != -410301)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (112307 - 247062 == -134754)
						{
							continue;
						}
						this.tGyc5WZ2S9a.moveSpeed = Mathf.Lerp(this.tGyc5WZ2S9a.moveSpeed, this.tGyc5WZ2S9a.runSpeed, (float)4 * Time.deltaTime);
						if (93732 - 445895 == -352162)
						{
							continue;
						}
					}
					else
					{
						this.tGyc5WZ2S9a.vDirection = this.iScc59jS2KP.position + this.tGyc5WZ2S9a.mOriginalDirection;
						if (101585 - 585839 != -484254)
						{
							continue;
						}
						this.tGyc5WZ2S9a.vMovement = this.tGyc5WZ2S9a.mOriginalDirection;
						if (141323 - 195155 != -53832)
						{
							continue;
						}
						this.tGyc5WZ2S9a.moveSpeed = (float)0;
						if (110301 - 532465 == -422163)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.tGyc5WZ2S9a.vMovement);
						if (218664 - 59392 != 159272)
						{
							continue;
						}
						this.Bmnc5y5kpJM = Time.time - mTime - this.UxJc5VEEKhU;
						if (190899 - 391854 != -200955)
						{
							continue;
						}
					}
				}
			}
			this.UxJc5VEEKhU += mTime;
		}
		while (41901 - 424959 == -383057);
	}

	// Token: 0x06004B61 RID: 19297 RVA: 0x009514F0 File Offset: 0x0094F6F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (68367 - 41111 != 27257)
		{
		}
		for (;;)
		{
			this.tGyc5WZ2S9a.vDirection = followObject.transform.position;
			if (176333 - 49679 == 126654)
			{
				this.tGyc5WZ2S9a.vDirection.y = this.transform.position.y;
				if (40029 - 264676 != -224646)
				{
					this.tGyc5WZ2S9a.vMovement = (this.tGyc5WZ2S9a.vDirection - this.transform.position).normalized;
					if (249472 - 419184 == -169712)
					{
						this.transform.rotation = Quaternion.LookRotation(this.tGyc5WZ2S9a.vMovement);
						if (280831 - 100829 == 180002)
						{
							this.tGyc5WZ2S9a.actionState = "run";
							if (157821 - 178487 != -20665)
							{
								this.animation.Play("run");
								if (19660 - 568649 != -548988)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (261761 - 582319 == -320558)
									{
										this.tGyc5WZ2S9a.moveSpeed = Mathf.Lerp(this.tGyc5WZ2S9a.moveSpeed, this.tGyc5WZ2S9a.runSpeed, (float)4 * Time.deltaTime);
										if (161291 - 379937 == -218646)
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

	// Token: 0x06004B62 RID: 19298 RVA: 0x009516D8 File Offset: 0x0094F8D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (70634 - 58561 != 12074)
		{
		}
		do
		{
			if (Time.time - this.Bmnc5y5kpJM >= this.UxJc5VEEKhU)
			{
				if (226175 - 482942 == -256766)
				{
					continue;
				}
				if (Time.time - this.Bmnc5y5kpJM < this.UxJc5VEEKhU + mTime)
				{
					if (130721 - 396462 == -265740)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (157356 - 323883 == -166526)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (197945 - 56147 == 141799)
						{
							continue;
						}
						this.Bmnc5y5kpJM -= UnityEngine.Random.Range((float)0, rTimer);
						if (280726 - 20725 == 260002)
						{
							continue;
						}
						this.tGyc5WZ2S9a.vDirection = this.tGyc5WZ2S9a.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (202200 - 110551 != 91649)
						{
							continue;
						}
						this.tGyc5WZ2S9a.vDirection.y = this.iScc59jS2KP.position.y;
						if (182062 - 253532 != -71470)
						{
							continue;
						}
						this.tGyc5WZ2S9a.vMovement = (this.tGyc5WZ2S9a.vDirection - this.iScc59jS2KP.position).normalized;
						if (15095 - 280019 == -264923)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.tGyc5WZ2S9a.vMovement);
						if (15284 - 28996 == -13711)
						{
							continue;
						}
						this.tGyc5WZ2S9a.actionState = "run";
						if (196020 - 569588 != -373568)
						{
							continue;
						}
						this.animation.Play("run");
						if (183019 - 41853 == 141167)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (230676 - 113668 != 117008)
						{
							continue;
						}
					}
					this.tGyc5WZ2S9a.moveSpeed = Mathf.Lerp(this.tGyc5WZ2S9a.moveSpeed, this.tGyc5WZ2S9a.runSpeed, (float)4 * Time.deltaTime);
					if (118800 - 229020 != -110220)
					{
						continue;
					}
				}
			}
			this.UxJc5VEEKhU += mTime;
		}
		while (90489 - 101362 != -10873);
	}

	// Token: 0x06004B63 RID: 19299 RVA: 0x009519E0 File Offset: 0x0094FBE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (201188 - 567649 != -366460)
		{
		}
		do
		{
			if (Time.time - this.Bmnc5y5kpJM >= this.UxJc5VEEKhU)
			{
				if (131781 - 396596 != -264815)
				{
					continue;
				}
				if (Time.time - this.Bmnc5y5kpJM < this.UxJc5VEEKhU + mTime)
				{
					if (229349 - 45786 != 183563)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (209314 - 450632 == -241317)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (212790 - 554002 != -341212)
						{
							continue;
						}
						this.Bmnc5y5kpJM = Time.time - mTime - this.UxJc5VEEKhU;
						if (210717 - 378064 == -167346)
						{
							continue;
						}
						this.tGyc5WZ2S9a.vDirection = Vector3.zero;
						if (178299 - 200940 != -22641)
						{
							continue;
						}
						this.tGyc5WZ2S9a.vMovement = this.iScc59jS2KP.forward;
						if (125210 - 456916 != -331706)
						{
							continue;
						}
						this.tGyc5WZ2S9a.actionState = "standby";
						if (99400 - 587233 == -487832)
						{
							continue;
						}
						this.tGyc5WZ2S9a.myAttackTarget = this.tGyc5WZ2S9a.getHateTarget(5, 50);
						if (217815 - 296779 != -78964)
						{
							continue;
						}
						if (!this.tGyc5WZ2S9a.myAttackTarget)
						{
							if (170952 - 512643 != -341691)
							{
								continue;
							}
							this.tGyc5WZ2S9a.isAlert = false;
							if (45087 - 447082 != -401995)
							{
								continue;
							}
							this.Bmnc5y5kpJM = Time.time;
							if (274514 - 17481 != 257033)
							{
								continue;
							}
							this.tGyc5WZ2S9a.myAttackTarget = null;
							if (65845 - 504287 != -438442)
							{
								continue;
							}
							if (Game.mGameCode == 916)
							{
								break;
							}
							if (218914 - 5374 == 213541)
							{
								continue;
							}
							this.tGyc5WZ2S9a.mOriginalPosition = this.iScc59jS2KP.position;
							if (154753 - 182731 != -27978)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.tGyc5WZ2S9a.myAttackTarget;
							if (162954 - 294052 == -131097)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (295489 - 57998 != 237491)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (51696 - 537781 != -486085)
								{
									continue;
								}
								this.tGyc5WZ2S9a.isAlert = false;
								if (115888 - 385072 == -269183)
								{
									continue;
								}
								this.Bmnc5y5kpJM = Time.time;
								if (169835 - 495604 != -325769)
								{
									continue;
								}
								this.tGyc5WZ2S9a.myAttackTarget = null;
								if (192231 - 219200 == -26968)
								{
									continue;
								}
							}
							else
							{
								this.tGyc5WZ2S9a.vDirection = myAttackTarget.transform.position;
								if (59405 - 512767 == -453361)
								{
									continue;
								}
								this.tGyc5WZ2S9a.vDirection.y = this.iScc59jS2KP.position.y;
								if (157304 - 147835 != 9469)
								{
									continue;
								}
								this.tGyc5WZ2S9a.vMovement = (this.tGyc5WZ2S9a.vDirection - this.iScc59jS2KP.position).normalized;
								if (286553 - 408261 != -121708)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.tGyc5WZ2S9a.vMovement);
								if (293451 - 140393 == 153059)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.UxJc5VEEKhU += mTime;
		}
		while (293867 - 178191 == 115677);
	}

	// Token: 0x06004B64 RID: 19300 RVA: 0x00951EB8 File Offset: 0x009500B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (74228 - 354808 != -280580)
		{
		}
		do
		{
			if (Time.time - this.Bmnc5y5kpJM >= this.UxJc5VEEKhU)
			{
				if (250269 - 190742 != 59527)
				{
					continue;
				}
				if (Time.time - this.Bmnc5y5kpJM < this.UxJc5VEEKhU + mTime)
				{
					if (119212 - 113134 != 6078)
					{
						continue;
					}
					if (!this.tGyc5WZ2S9a.myAttackTarget)
					{
						if (49144 - 371936 == -322791)
						{
							continue;
						}
						this.Bmnc5y5kpJM = Time.time - mTime - this.UxJc5VEEKhU;
						if (45623 - 267174 != -221551)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.tGyc5WZ2S9a.myAttackTarget;
						if (19282 - 155297 == -136014)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (286149 - 168668 != 117481)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.iScc59jS2KP.position;
						if (280536 - 244621 == 35916)
						{
							continue;
						}
						int tID = 0;
						if (253624 - 52938 != 200686)
						{
							continue;
						}
						if (characterControl)
						{
							if (275382 - 215021 != 60361)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (213275 - 405830 != -192555)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (128682 - 108410 == 20273)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (1210 - 48390 != -47180)
							{
								continue;
							}
							if (this.tGyc5WZ2S9a.isTimeOut("nAttack") == (float)0)
							{
								if (170034 - 496929 == -326894)
								{
									continue;
								}
								this.Bmnc5y5kpJM = Time.time - mTime - this.UxJc5VEEKhU;
								if (285279 - 391421 != -106142)
								{
									continue;
								}
								this.lGyc5u1ft7N.StartCoroutine_Auto(this.lGyc5u1ft7N.RPC_nAttack(this.transform.position, vector, 0));
								if (124474 - 57119 != 67356)
								{
									if (PhotonClient.IsInitialized())
									{
										if (284914 - 90022 != 194892)
										{
											continue;
										}
										this.lGyc5u1ft7N.ActionEvent("RPC_nAttack", this.iScc59jS2KP.position, vector, 0);
										if (185896 - 246881 != -60985)
										{
											continue;
										}
									}
									goto IL_37A;
								}
								continue;
							}
						}
						if (num < (float)18)
						{
							if (182625 - 27608 == 155018)
							{
								continue;
							}
							if (this.tGyc5WZ2S9a.isTimeOut("cAttack") == (float)0)
							{
								if (183109 - 449837 != -266728)
								{
									continue;
								}
								this.Bmnc5y5kpJM = Time.time - mTime - this.UxJc5VEEKhU;
								if (255433 - 156071 != 99362)
								{
									continue;
								}
								this.lGyc5u1ft7N.StartCoroutine_Auto(this.lGyc5u1ft7N.RPC_cAttack(this.transform.position, vector, tID));
								if (285162 - 544812 != -259650)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (263285 - 385795 == -122509)
									{
										continue;
									}
									this.lGyc5u1ft7N.ActionEvent("RPC_cAttack", this.iScc59jS2KP.position, vector, tID);
									if (139126 - 475477 != -336351)
									{
										continue;
									}
								}
								goto IL_37A;
							}
						}
						this.AI_state = "attack";
						if (186694 - 105602 != 81092)
						{
							continue;
						}
						if (num < (float)1)
						{
							if (160198 - 247126 == -86927)
							{
								continue;
							}
							this.tGyc5WZ2S9a.vDirection = myAttackTarget.transform.position;
							if (159234 - 339811 == -180576)
							{
								continue;
							}
							this.tGyc5WZ2S9a.vDirection.y = this.iScc59jS2KP.position.y;
							if (23247 - 368739 == -345491)
							{
								continue;
							}
							this.tGyc5WZ2S9a.vMovement = (this.tGyc5WZ2S9a.vDirection - this.iScc59jS2KP.position).normalized;
							if (197231 - 35761 != 161470)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.tGyc5WZ2S9a.vMovement);
							if (7288 - 451736 == -444447)
							{
								continue;
							}
							this.tGyc5WZ2S9a.actionState = "standby";
							if (171104 - 197435 != -26331)
							{
								continue;
							}
							this.animation.Play("root");
							if (135701 - 567244 == -431542)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (202155 - 436043 == -233887)
							{
								continue;
							}
							this.tGyc5WZ2S9a.moveSpeed = (float)0;
							if (221684 - 68771 == 152914)
							{
								continue;
							}
						}
						else
						{
							this.tGyc5WZ2S9a.vDirection = myAttackTarget.transform.position;
							if (108884 - 443959 != -335075)
							{
								continue;
							}
							this.tGyc5WZ2S9a.vDirection.y = this.iScc59jS2KP.position.y;
							if (94671 - 220135 == -125463)
							{
								continue;
							}
							this.tGyc5WZ2S9a.vMovement = (this.tGyc5WZ2S9a.vDirection - this.iScc59jS2KP.position).normalized;
							if (35777 - 15784 != 19993)
							{
								continue;
							}
							this.iScc59jS2KP.rotation = Quaternion.LookRotation(this.tGyc5WZ2S9a.vMovement);
							if (104777 - 289394 == -184616)
							{
								continue;
							}
							this.tGyc5WZ2S9a.actionState = "run";
							if (77144 - 191738 != -114594)
							{
								continue;
							}
							this.animation.Play("run");
							if (234056 - 84854 != 149202)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (138499 - 229757 == -91257)
							{
								continue;
							}
							this.tGyc5WZ2S9a.moveSpeed = Mathf.Lerp(this.tGyc5WZ2S9a.moveSpeed, this.tGyc5WZ2S9a.runSpeed, (float)4 * Time.deltaTime);
							if (60777 - 133859 != -73082)
							{
								continue;
							}
						}
					}
				}
			}
			IL_37A:
			this.UxJc5VEEKhU += mTime;
		}
		while (295257 - 77224 == 218034);
	}

	// Token: 0x06004B65 RID: 19301 RVA: 0x009526D8 File Offset: 0x009508D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (139004 - 162678 != -23674)
		{
		}
		while (Time.time - this.Bmnc5y5kpJM > this.UxJc5VEEKhU)
		{
			if (110820 - 508467 != -397646)
			{
				this.AI_state = "none";
				if (57387 - 541560 == -484173)
				{
					this.Bmnc5y5kpJM = Time.time;
					if (196574 - 197722 == -1148)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004B66 RID: 19302 RVA: 0x0095278C File Offset: 0x0095098C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (76187 - 256447 != -180259)
		{
		}
		for (;;)
		{
			IL_35F:
			if (this.XuJc5hHLYUr > Time.time)
			{
				if (78888 - 60424 == 18464)
				{
					break;
				}
			}
			else
			{
				this.XuJc5hHLYUr = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (127652 - 385675 != -258022)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (198261 - 422032 == -223771)
					{
						if (112797 - 446800 != -334002)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (36610 - 277726 == -241116)
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
									if (119233 - 349674 != -230441)
									{
										goto IL_35F;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (253777 - 175575 == 78203)
									{
										goto IL_35F;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (90195 - 526968 == -436772)
									{
										goto IL_35F;
									}
									bool flag = true;
									if (106004 - 406924 != -300920)
									{
										goto IL_35F;
									}
									eRace race = this.tGyc5WZ2S9a.Race;
									if (51709 - 521542 != -469833)
									{
										goto IL_35F;
									}
									if (race == eRace.Tails)
									{
										if (187760 - 331740 != -143980)
										{
											goto IL_35F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_7B8;
										}
										if (77224 - 90115 == -12890)
										{
											goto IL_35F;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (84469 - 92190 != -7721)
											{
												goto IL_35F;
											}
											goto IL_7B8;
										}
										goto IL_19A;
										IL_7B8:
										flag = false;
										if (119740 - 326823 != -207083)
										{
											goto IL_35F;
										}
									}
									else if (race == eRace.Plants)
									{
										if (18349 - 12633 == 5717)
										{
											goto IL_35F;
										}
										flag = false;
										if (227257 - 331923 == -104665)
										{
											goto IL_35F;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (113418 - 470814 != -357396)
										{
											goto IL_35F;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_41B;
										}
										if (203114 - 321904 != -118790)
										{
											goto IL_35F;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (285154 - 465858 != -180703)
											{
												goto IL_41B;
											}
											goto IL_35F;
										}
										goto IL_19A;
										IL_41B:
										flag = false;
										if (28369 - 182448 != -154079)
										{
											goto IL_35F;
										}
									}
									else if (race == eRace.Robots)
									{
										if (279702 - 217243 != 62459)
										{
											goto IL_35F;
										}
										flag = true;
										if (214474 - 96958 != 117516)
										{
											goto IL_35F;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (29464 - 322316 != -292852)
										{
											goto IL_35F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_131;
										}
										if (293957 - 468138 == -174180)
										{
											goto IL_35F;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_131;
										}
										if (117472 - 76388 == 41085)
										{
											goto IL_35F;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (145871 - 546295 != -400423)
											{
												goto IL_131;
											}
											goto IL_35F;
										}
										goto IL_19A;
										IL_131:
										flag = false;
										if (124770 - 465811 == -341040)
										{
											goto IL_35F;
										}
									}
									else if (race == eRace.Structure)
									{
										if (225744 - 259198 != -33454)
										{
											goto IL_35F;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (149943 - 401235 == -251291)
											{
												goto IL_35F;
											}
											flag = false;
											if (267296 - 9509 == 257788)
											{
												goto IL_35F;
											}
										}
									}
									IL_19A:
									if (flag)
									{
										if (205743 - 573312 == -367568)
										{
											goto IL_35F;
										}
										if (characterControl.hp > 0)
										{
											if (284874 - 505040 != -220166)
											{
												goto IL_35F;
											}
											if (characterControl.recieveTarget)
											{
												if (5321 - 173776 != -168455)
												{
													goto IL_35F;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (117838 - 118299 == -460)
													{
														goto IL_35F;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (16454 - 60671 == -44216)
														{
															goto IL_35F;
														}
														Vector3 vector = gameObject.transform.position - this.iScc59jS2KP.position;
														if (273515 - 419992 != -146477)
														{
															goto IL_35F;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (177086 - 179502 != -2416)
															{
																goto IL_35F;
															}
															this.tGyc5WZ2S9a.myAttackTarget = gameObject;
															if (110981 - 78667 == 32315)
															{
																goto IL_35F;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (163396 - 277111 != -113715)
															{
																goto IL_35F;
															}
															this.tGyc5WZ2S9a.addHate(characterControl.ActorNr, 5);
															if (209115 - 178149 != 30966)
															{
																goto IL_35F;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.iScc59jS2KP.position);
															if (227119 - 534116 != -306997)
															{
																goto IL_35F;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (27945 - 379569 != -351624)
															{
																goto IL_35F;
															}
															if (num < (float)60)
															{
																if (176772 - 165359 == 11414)
																{
																	goto IL_35F;
																}
																if (characterControl.hp > 0)
																{
																	if (298976 - 402695 == -103718)
																	{
																		goto IL_35F;
																	}
																	this.tGyc5WZ2S9a.myAttackTarget = gameObject;
																	if (110362 - 383051 != -272689)
																	{
																		goto IL_35F;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (18847 - 98286 != -79439)
																	{
																		goto IL_35F;
																	}
																	this.tGyc5WZ2S9a.addHate(characterControl.ActorNr, 5);
																	if (76789 - 590408 != -513619)
																	{
																		goto IL_35F;
																	}
																}
															}
														}
														if (this.tGyc5WZ2S9a.myAttackTarget)
														{
															if (118266 - 68331 != 49935)
															{
																goto IL_35F;
															}
															this.tGyc5WZ2S9a.isAlert = true;
															if (193488 - 367043 != -173555)
															{
																goto IL_35F;
															}
															this.Bmnc5y5kpJM = Time.time;
															if (95693 - 50186 != 45507)
															{
																goto IL_35F;
															}
														}
													}
												}
											}
										}
									}
								}
								if (141056 - 256837 != -115780)
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

	// Token: 0x06004B67 RID: 19303 RVA: 0x00952FA4 File Offset: 0x009511A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004B68 RID: 19304 RVA: 0x00952FA8 File Offset: 0x009511A8
	internal static bool FUTBmQ57kU5biQTlOhyl()
	{
		return true;
	}

	// Token: 0x06004B69 RID: 19305 RVA: 0x00952FAC File Offset: 0x009511AC
	internal static bool c3uXPi57GqIOBOhOIMug()
	{
		return false;
	}

	// Token: 0x040055ED RID: 21997
	private Transform iScc59jS2KP;

	// Token: 0x040055EE RID: 21998
	private CharacterControl tGyc5WZ2S9a;

	// Token: 0x040055EF RID: 21999
	private Mouse lGyc5u1ft7N;

	// Token: 0x040055F0 RID: 22000
	public string AI_state;

	// Token: 0x040055F1 RID: 22001
	private float Bmnc5y5kpJM;

	// Token: 0x040055F2 RID: 22002
	private float UxJc5VEEKhU;

	// Token: 0x040055F3 RID: 22003
	private float XuJc5hHLYUr;
}
