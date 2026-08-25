using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D2B RID: 3371
[Serializable]
public class Owl2_AI : MonoBehaviour
{
	// Token: 0x06004BCB RID: 19403 RVA: 0x0095D7BC File Offset: 0x0095B9BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Owl2_AI()
	{
		if (88131 - 596984 != -508852)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (18214 - 529490 == -511276)
			{
				base..ctor();
				if (269052 - 421037 == -151985)
				{
					this.AI_state = "none";
					if (247426 - 330753 != -83326)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004BCC RID: 19404 RVA: 0x0095D858 File Offset: 0x0095BA58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.BTSccO5h7nf = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.VyPcc2Ju2ax = (Owl2)this.GetComponent(typeof(Owl2));
	}

	// Token: 0x06004BCD RID: 19405 RVA: 0x0095D890 File Offset: 0x0095BA90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (15709 - 393323 != -377613)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (44199 - 47136 != -2937)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (62105 - 406385 == -344279)
				{
					continue;
				}
			}
			if (this.BTSccO5h7nf.isControlled)
			{
				break;
			}
			if (280967 - 82773 != 198195)
			{
				this.AIControl();
				if (70756 - 451647 == -380891)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004BCE RID: 19406 RVA: 0x0095D95C File Offset: 0x0095BB5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (286919 - 569844 != -282924)
		{
		}
		for (;;)
		{
			this.w89cclxqsV8 = (float)0;
			if (207075 - 566030 != -358954)
			{
				if (this.BTSccO5h7nf.isMine)
				{
					if (204286 - 444921 != -240634)
					{
						if (this.BTSccO5h7nf.actionState != "standby")
						{
							if (126644 - 215217 == -88572)
							{
								continue;
							}
							if (this.BTSccO5h7nf.actionState != "run")
							{
								if (222704 - 218532 != 4173)
								{
									break;
								}
								continue;
							}
						}
						if (!this.BTSccO5h7nf.isAlert)
						{
							if (120157 - 329034 == -208877)
							{
								if (!this.BTSccO5h7nf.isSummon)
								{
									goto IL_65C;
								}
								if (210270 - 343180 == -132909)
								{
									continue;
								}
								if (!(this.BTSccO5h7nf.mSummoner != null))
								{
									goto IL_65C;
								}
								if (213663 - 280331 == -66667)
								{
									continue;
								}
								this.AI_idle(3f, 1f);
								if (98870 - 298254 != -199384)
								{
									continue;
								}
								this.AI_resetTimer();
								if (36722 - 447078 != -410356)
								{
									continue;
								}
								this.AI_visionCheck();
								if (115424 - 480218 != -364794)
								{
									continue;
								}
								IL_596:
								if (!this.BTSccO5h7nf.myAttackTarget)
								{
									break;
								}
								if (137751 - 181428 != -43677)
								{
									continue;
								}
								this.BTSccO5h7nf.isAlert = true;
								if (250423 - 456363 == -205939)
								{
									continue;
								}
								this.olDccvvNVwi = Time.time;
								if (143358 - 76469 != 66889)
								{
									continue;
								}
								break;
								IL_65C:
								this.AI_idle(3f, 1f);
								if (224062 - 100139 != 123924)
								{
									this.AI_patrol(1f, 0.25f);
									if (92558 - 250346 == -157788)
									{
										this.AI_resetTimer();
										if (298039 - 253145 == 44894)
										{
											this.AI_visionCheck();
											if (253115 - 424180 == -171065)
											{
												goto IL_596;
											}
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (125189 - 435900 != -310710)
							{
								this.AI_idle(3f, 1f);
								if (124508 - 378265 == -253757)
								{
									this.AI_attack(10f, (float)0);
									if (14473 - 366892 == -352419)
									{
										this.AI_resetTimer();
										if (49076 - 551682 != -502605)
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
					if (this.BTSccO5h7nf.actionState != "standby")
					{
						if (190716 - 328896 == -138179)
						{
							continue;
						}
						if (this.BTSccO5h7nf.actionState != "run")
						{
							if (255833 - 331609 != -75775)
							{
								break;
							}
							continue;
						}
					}
					float num = this.BTSccO5h7nf.moveSpeed;
					if (73628 - 361249 == -287621)
					{
						float runSpeed = this.BTSccO5h7nf.runSpeed;
						if (153623 - 73847 == 79776)
						{
							Vector3 vector = default(Vector3);
							if (74612 - 2957 == 71655)
							{
								Vector3 vector2 = Vector3.zero;
								if (222846 - 515236 != -292389)
								{
									if ((this.BTSccO5h7nf.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (47028 - 511420 != -464392)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.BTSccO5h7nf.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (178828 - 436933 != -258105)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (188489 - 572981 != -384492)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (171730 - 570807 == -399076)
											{
												continue;
											}
											num = (float)0;
											if (28075 - 517760 != -489685)
											{
												continue;
											}
											this.transform.position = this.BTSccO5h7nf.nPosition;
											if (100740 - 548898 == -448157)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (190054 - 151933 == 38122)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (204367 - 291315 == -86947)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (134177 - 586087 != -451910)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (137631 - 590747 != -453116)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (25223 - 562751 != -537528)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (283232 - 500710 == -217477)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (163960 - 567219 != -403259)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (50499 - 555839 == -505339)
											{
												continue;
											}
										}
									}
									this.BTSccO5h7nf.vMovement = vector2;
									if (168086 - 63245 != 104842)
									{
										this.BTSccO5h7nf.moveSpeed = num;
										if (210783 - 163954 == 46829)
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

	// Token: 0x06004BCF RID: 19407 RVA: 0x0095E09C File Offset: 0x0095C29C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (281161 - 409346 != -128185)
		{
		}
		do
		{
			if (Time.time - this.olDccvvNVwi >= this.w89cclxqsV8)
			{
				if (256496 - 191477 != 65019)
				{
					continue;
				}
				if (Time.time - this.olDccvvNVwi < this.w89cclxqsV8 + mTime)
				{
					if (191066 - 293565 != -102499)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (249771 - 108925 != 140846)
						{
							continue;
						}
						this.AI_state = "idle";
						if (218725 - 276361 == -57635)
						{
							continue;
						}
						this.olDccvvNVwi -= UnityEngine.Random.Range((float)0, rTimer);
						if (117923 - 574440 != -456517)
						{
							continue;
						}
						this.BTSccO5h7nf.vDirection = Vector3.zero;
						if (62698 - 204723 != -142025)
						{
							continue;
						}
						this.BTSccO5h7nf.vMovement = this.transform.forward;
						if (180365 - 398685 == -218319)
						{
							continue;
						}
						this.BTSccO5h7nf.actionState = "standby";
						if (104816 - 327183 == -222366)
						{
							continue;
						}
					}
					this.BTSccO5h7nf.moveSpeed = Mathf.Lerp(this.BTSccO5h7nf.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (236720 - 58585 != 178135)
					{
						continue;
					}
					if (this.BTSccO5h7nf.moveSpeed < 0.1f * this.BTSccO5h7nf.runSpeed)
					{
						if (24588 - 519526 == -494937)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (54762 - 540272 == -485509)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (255625 - 106472 == 149154)
						{
							continue;
						}
						this.BTSccO5h7nf.moveSpeed = (float)0;
						if (175520 - 218042 != -42522)
						{
							continue;
						}
					}
				}
			}
			this.w89cclxqsV8 += mTime;
		}
		while (147790 - 495479 == -347688);
	}

	// Token: 0x06004BD0 RID: 19408 RVA: 0x0095E360 File Offset: 0x0095C560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (21396 - 44308 != -22911)
		{
		}
		for (;;)
		{
			this.BTSccO5h7nf.vDirection = followObject.transform.position;
			if (91983 - 179344 == -87361)
			{
				this.BTSccO5h7nf.vDirection.y = this.transform.position.y;
				if (86026 - 576972 != -490945)
				{
					this.BTSccO5h7nf.vMovement = (this.BTSccO5h7nf.vDirection - this.transform.position).normalized;
					if (177519 - 360314 == -182795)
					{
						this.transform.rotation = Quaternion.LookRotation(this.BTSccO5h7nf.vMovement);
						if (88358 - 3863 != 84496)
						{
							this.BTSccO5h7nf.actionState = "run";
							if (196362 - 518095 != -321732)
							{
								this.animation.Play("run");
								if (207411 - 352284 == -144873)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (144458 - 86501 != 57958)
									{
										this.BTSccO5h7nf.moveSpeed = Mathf.Lerp(this.BTSccO5h7nf.moveSpeed, this.BTSccO5h7nf.runSpeed, (float)4 * Time.deltaTime);
										if (213150 - 539054 == -325904)
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

	// Token: 0x06004BD1 RID: 19409 RVA: 0x0095E548 File Offset: 0x0095C748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (151133 - 205719 != -54585)
		{
		}
		do
		{
			if (Time.time - this.olDccvvNVwi >= this.w89cclxqsV8)
			{
				if (84571 - 273192 != -188621)
				{
					continue;
				}
				if (Time.time - this.olDccvvNVwi < this.w89cclxqsV8 + mTime)
				{
					if (94065 - 186699 == -92633)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (18924 - 240914 == -221989)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (251183 - 576983 == -325799)
						{
							continue;
						}
						this.olDccvvNVwi -= UnityEngine.Random.Range((float)0, rTimer);
						if (290302 - 372940 != -82638)
						{
							continue;
						}
						this.BTSccO5h7nf.vDirection = this.BTSccO5h7nf.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (68681 - 3705 == 64977)
						{
							continue;
						}
						this.BTSccO5h7nf.vDirection.y = this.transform.position.y;
						if (65516 - 496105 == -430588)
						{
							continue;
						}
						this.BTSccO5h7nf.vMovement = (this.BTSccO5h7nf.vDirection - this.transform.position).normalized;
						if (217425 - 481787 == -264361)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.BTSccO5h7nf.vMovement);
						if (190332 - 196646 == -6313)
						{
							continue;
						}
						this.BTSccO5h7nf.actionState = "run";
						if (105326 - 404284 == -298957)
						{
							continue;
						}
						this.animation.Play("run");
						if (109944 - 9101 != 100843)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (249564 - 10065 == 239500)
						{
							continue;
						}
					}
					this.BTSccO5h7nf.moveSpeed = Mathf.Lerp(this.BTSccO5h7nf.moveSpeed, this.BTSccO5h7nf.runSpeed, (float)4 * Time.deltaTime);
					if (93715 - 94587 == -871)
					{
						continue;
					}
				}
			}
			this.w89cclxqsV8 += mTime;
		}
		while (273240 - 230654 == 42587);
	}

	// Token: 0x06004BD2 RID: 19410 RVA: 0x0095E850 File Offset: 0x0095CA50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (95780 - 417185 != -321405)
		{
		}
		do
		{
			if (Time.time - this.olDccvvNVwi >= this.w89cclxqsV8)
			{
				if (259709 - 190096 != 69613)
				{
					continue;
				}
				if (Time.time - this.olDccvvNVwi < this.w89cclxqsV8 + mTime)
				{
					if (249961 - 586909 == -336947)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (62393 - 316812 == -254418)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (79837 - 300958 == -221120)
						{
							continue;
						}
						this.olDccvvNVwi = Time.time - mTime - this.w89cclxqsV8;
						if (53159 - 262332 == -209172)
						{
							continue;
						}
						this.BTSccO5h7nf.vDirection = Vector3.zero;
						if (265940 - 96462 != 169478)
						{
							continue;
						}
						this.BTSccO5h7nf.vMovement = this.transform.forward;
						if (244347 - 187091 == 57257)
						{
							continue;
						}
						this.BTSccO5h7nf.actionState = "standby";
						if (196893 - 255661 == -58767)
						{
							continue;
						}
						this.BTSccO5h7nf.myAttackTarget = this.BTSccO5h7nf.getHateTarget(5, 50);
						if (285534 - 289440 != -3906)
						{
							continue;
						}
						if (!this.BTSccO5h7nf.myAttackTarget)
						{
							if (129955 - 517203 != -387248)
							{
								continue;
							}
							this.BTSccO5h7nf.isAlert = false;
							if (234280 - 302695 == -68414)
							{
								continue;
							}
							this.olDccvvNVwi = Time.time;
							if (278300 - 263466 == 14835)
							{
								continue;
							}
							this.BTSccO5h7nf.myAttackTarget = null;
							if (114517 - 191230 != -76713)
							{
								continue;
							}
							this.BTSccO5h7nf.mOriginalPosition = this.transform.position;
							if (163277 - 111774 != 51504)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.BTSccO5h7nf.myAttackTarget;
							if (144059 - 201426 != -57367)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (93330 - 163202 != -69872)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (246727 - 448455 != -201728)
								{
									continue;
								}
								this.BTSccO5h7nf.isAlert = false;
								if (276609 - 249113 != 27496)
								{
									continue;
								}
								this.olDccvvNVwi = Time.time;
								if (33961 - 376682 == -342720)
								{
									continue;
								}
								this.BTSccO5h7nf.myAttackTarget = null;
								if (118530 - 409409 != -290879)
								{
									continue;
								}
							}
							else
							{
								this.BTSccO5h7nf.vDirection = myAttackTarget.transform.position;
								if (128189 - 83856 != 44333)
								{
									continue;
								}
								this.BTSccO5h7nf.vDirection.y = this.transform.position.y;
								if (200577 - 518794 != -318217)
								{
									continue;
								}
								this.BTSccO5h7nf.vMovement = (this.BTSccO5h7nf.vDirection - this.transform.position).normalized;
								if (12009 - 540438 != -528429)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.BTSccO5h7nf.vMovement);
								if (247587 - 85128 != 162459)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.w89cclxqsV8 += mTime;
		}
		while (190475 - 157494 == 32982);
	}

	// Token: 0x06004BD3 RID: 19411 RVA: 0x0095ED00 File Offset: 0x0095CF00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (98107 - 248315 != -150207)
		{
		}
		do
		{
			IL_214:
			if (Time.time - this.olDccvvNVwi >= this.w89cclxqsV8)
			{
				if (171213 - 460 != 170753)
				{
					continue;
				}
				if (Time.time - this.olDccvvNVwi < this.w89cclxqsV8 + mTime)
				{
					if (291942 - 440202 != -148260)
					{
						continue;
					}
					if (!this.BTSccO5h7nf.myAttackTarget)
					{
						if (124517 - 259380 == -134862)
						{
							continue;
						}
						this.olDccvvNVwi = Time.time - mTime - this.w89cclxqsV8;
						if (66438 - 206701 != -140262)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.BTSccO5h7nf.myAttackTarget;
						if (153694 - 127767 == 25928)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (172081 - 98392 != 73689)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (40326 - 31498 == 8829)
						{
							continue;
						}
						if (180505 - 568029 != -387524)
						{
							continue;
						}
						if (characterControl)
						{
							if (150166 - 86838 == 63329)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (48603 - 325830 == -277226)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (62797 - 488298 != -425501)
						{
							continue;
						}
						if (this.BTSccO5h7nf.isTimeOut("potion") == (float)0)
						{
							if (55353 - 397861 == -342507)
							{
								continue;
							}
							UnityScript.Lang.Array obj = Hate.findFriends(this.transform.position, (float)24, this.gameObject.layer);
							if (253837 - 52822 != 201015)
							{
								continue;
							}
							GameObject gameObject = this.gameObject;
							if (290883 - 594312 != -303429)
							{
								continue;
							}
							CharacterControl characterControl2 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
							if (259332 - 540742 != -281410)
							{
								continue;
							}
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (142515 - 461476 != -318961)
							{
								continue;
							}
							while (enumerator.MoveNext())
							{
								object obj2 = enumerator.Current;
								object obj4;
								object obj3 = obj4 = obj2;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj4;
								if (8582 - 359158 != -350576)
								{
									goto IL_214;
								}
								CharacterControl characterControl3 = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
								if (178885 - 20874 == 158012)
								{
									goto IL_214;
								}
								UnityRuntimeServices.Update(enumerator, gameObject2);
								if (76547 - 544611 == -468063)
								{
									goto IL_214;
								}
								if (characterControl3.hp / characterControl3.mhp < characterControl2.hp / characterControl2.mhp)
								{
									if (151527 - 187593 != -36066)
									{
										goto IL_214;
									}
									gameObject = gameObject2;
									if (108178 - 412604 == -304425)
									{
										goto IL_214;
									}
									UnityRuntimeServices.Update(enumerator, gameObject2);
									if (225364 - 531877 != -306513)
									{
										goto IL_214;
									}
									characterControl2 = characterControl3;
									if (60175 - 333696 == -273520)
									{
										goto IL_214;
									}
								}
							}
							if (160352 - 266055 == -105702)
							{
								continue;
							}
							if (gameObject)
							{
								if (299089 - 513306 != -214217)
								{
									continue;
								}
								if (characterControl2)
								{
									if (100508 - 255932 != -155424)
									{
										continue;
									}
									if (characterControl2.hp < characterControl2.mhp)
									{
										if (77868 - 125230 != -47362)
										{
											continue;
										}
										this.olDccvvNVwi = Time.time - mTime - this.w89cclxqsV8;
										if (22744 - 460030 != -437286)
										{
											continue;
										}
										Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.transform.position);
										if (162959 - 519444 != -356485)
										{
											continue;
										}
										vector = vector2.normalized;
										if (85823 - 422571 == -336747)
										{
											continue;
										}
										this.VyPcc2Ju2ax.StartCoroutine_Auto(this.VyPcc2Ju2ax.RPC_potion(this.transform.position, vector, characterControl2.ActorNr));
										if (229772 - 258890 == -29117)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (258134 - 325043 != -66909)
											{
												continue;
											}
											this.VyPcc2Ju2ax.ActionEvent("RPC_potion", this.transform.position, vector, characterControl2.ActorNr);
											if (142584 - 355134 == -212549)
											{
												continue;
											}
										}
									}
									else
									{
										this.BTSccO5h7nf.addTimeOut("potion", (float)6);
										if (121167 - 297986 == -176818)
										{
											continue;
										}
									}
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (81527 - 21453 != 60074)
							{
								continue;
							}
							if (num < (float)12)
							{
								if (195604 - 254291 == -58686)
								{
									continue;
								}
								this.BTSccO5h7nf.vDirection = myAttackTarget.transform.position;
								if (161340 - 287868 == -126527)
								{
									continue;
								}
								this.BTSccO5h7nf.vDirection.y = this.transform.position.y;
								if (251970 - 124785 != 127185)
								{
									continue;
								}
								this.BTSccO5h7nf.vMovement = (this.transform.position - this.BTSccO5h7nf.vDirection).normalized;
								if (68557 - 564608 != -496051)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.BTSccO5h7nf.vMovement);
								if (102448 - 248191 == -145742)
								{
									continue;
								}
								this.BTSccO5h7nf.actionState = "run";
								if (263651 - 498529 != -234878)
								{
									continue;
								}
								this.animation.Play("run");
								if (65825 - 10069 != 55756)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (53845 - 172145 == -118299)
								{
									continue;
								}
								this.BTSccO5h7nf.moveSpeed = Mathf.Lerp(this.BTSccO5h7nf.moveSpeed, this.BTSccO5h7nf.runSpeed, (float)4 * Time.deltaTime);
								if (8545 - 447027 == -438481)
								{
									continue;
								}
								this.VyPcc2Ju2ax.helpEvent();
								if (278828 - 444885 == -166056)
								{
									continue;
								}
							}
							else
							{
								this.BTSccO5h7nf.vDirection = myAttackTarget.transform.position;
								if (206105 - 139525 != 66580)
								{
									continue;
								}
								this.BTSccO5h7nf.vDirection.y = this.transform.position.y;
								if (33557 - 416724 == -383166)
								{
									continue;
								}
								this.BTSccO5h7nf.vMovement = (this.transform.position - this.BTSccO5h7nf.vDirection).normalized;
								if (182891 - 352938 != -170047)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.BTSccO5h7nf.vMovement);
								if (182839 - 321538 == -138698)
								{
									continue;
								}
								this.BTSccO5h7nf.actionState = "standby";
								if (218248 - 19670 != 198578)
								{
									continue;
								}
								this.animation.CrossFade("root");
								if (251796 - 310561 == -58764)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (124029 - 193462 != -69433)
								{
									continue;
								}
								this.BTSccO5h7nf.moveSpeed = Mathf.Lerp(this.BTSccO5h7nf.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (181677 - 161963 != 19714)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.w89cclxqsV8 += mTime;
		}
		while (293010 - 75692 == 217319);
	}

	// Token: 0x06004BD4 RID: 19412 RVA: 0x0095F73C File Offset: 0x0095D93C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (85868 - 550834 != -464965)
		{
		}
		while (Time.time - this.olDccvvNVwi > this.w89cclxqsV8)
		{
			if (105256 - 78682 != 26575)
			{
				this.AI_state = "none";
				if (131073 - 436751 == -305678)
				{
					this.olDccvvNVwi = Time.time;
					if (248239 - 278465 != -30225)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004BD5 RID: 19413 RVA: 0x0095F7F0 File Offset: 0x0095D9F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (122132 - 512574 != -390442)
		{
		}
		for (;;)
		{
			IL_516:
			if (this.dtfccGjAauE > Time.time)
			{
				if (16290 - 384427 != -368136)
				{
					break;
				}
			}
			else
			{
				this.dtfccGjAauE = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (180779 - 380129 == -199350)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (324 - 309383 != -309058)
					{
						if (114744 - 205015 == -90271)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (213643 - 309851 == -96208)
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
									if (222623 - 269361 == -46737)
									{
										goto IL_516;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (281137 - 350564 == -69426)
									{
										goto IL_516;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (53283 - 585114 != -531831)
									{
										goto IL_516;
									}
									bool flag = true;
									if (112687 - 567643 != -454956)
									{
										goto IL_516;
									}
									eRace race = this.BTSccO5h7nf.Race;
									if (10888 - 110190 == -99301)
									{
										goto IL_516;
									}
									if (race == eRace.Tails)
									{
										if (56392 - 255173 == -198780)
										{
											goto IL_516;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_40;
										}
										if (13649 - 457120 == -443470)
										{
											goto IL_516;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (50906 - 36434 != 14473)
											{
												goto IL_40;
											}
											goto IL_516;
										}
										goto IL_65C;
										IL_40:
										flag = false;
										if (17131 - 375485 != -358354)
										{
											goto IL_516;
										}
									}
									else if (race == eRace.Plants)
									{
										if (92407 - 419378 != -326971)
										{
											goto IL_516;
										}
										flag = false;
										if (217235 - 78251 != 138984)
										{
											goto IL_516;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (292551 - 447597 != -155046)
										{
											goto IL_516;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_14D;
										}
										if (125318 - 423497 != -298179)
										{
											goto IL_516;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (107442 - 414591 != -307149)
											{
												goto IL_516;
											}
											goto IL_14D;
										}
										goto IL_65C;
										IL_14D:
										flag = false;
										if (134438 - 195112 != -60674)
										{
											goto IL_516;
										}
									}
									else if (race == eRace.Robots)
									{
										if (191986 - 43024 != 148962)
										{
											goto IL_516;
										}
										flag = true;
										if (9127 - 10488 != -1361)
										{
											goto IL_516;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (106725 - 30026 != 76699)
										{
											goto IL_516;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5B7;
										}
										if (228346 - 30901 != 197445)
										{
											goto IL_516;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_5B7;
										}
										if (25914 - 32476 == -6561)
										{
											goto IL_516;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (224514 - 151763 != 72752)
											{
												goto IL_5B7;
											}
											goto IL_516;
										}
										goto IL_65C;
										IL_5B7:
										flag = false;
										if (13213 - 61483 != -48270)
										{
											goto IL_516;
										}
									}
									else if (race == eRace.Structure)
									{
										if (206970 - 337074 == -130103)
										{
											goto IL_516;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (260927 - 310869 == -49941)
											{
												goto IL_516;
											}
											flag = false;
											if (163694 - 54612 != 109082)
											{
												goto IL_516;
											}
										}
									}
									IL_65C:
									if (flag)
									{
										if (53341 - 514062 != -460721)
										{
											goto IL_516;
										}
										if (characterControl.hp > 0)
										{
											if (175890 - 374491 != -198601)
											{
												goto IL_516;
											}
											if (characterControl.recieveTarget)
											{
												if (46497 - 34404 != 12093)
												{
													goto IL_516;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (100113 - 70498 != 29615)
													{
														goto IL_516;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (43027 - 1906 == 41122)
														{
															goto IL_516;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (135268 - 554914 != -419646)
														{
															goto IL_516;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (125631 - 277328 == -151696)
															{
																goto IL_516;
															}
															this.BTSccO5h7nf.myAttackTarget = gameObject;
															if (240204 - 6644 != 233560)
															{
																goto IL_516;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (54310 - 98298 != -43988)
															{
																goto IL_516;
															}
															this.BTSccO5h7nf.addHate(characterControl.ActorNr, 5);
															if (243127 - 83309 != 159818)
															{
																goto IL_516;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (283659 - 593660 != -310001)
															{
																goto IL_516;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (175643 - 50027 != 125616)
															{
																goto IL_516;
															}
															if (num < (float)60)
															{
																if (219530 - 77900 != 141630)
																{
																	goto IL_516;
																}
																if (characterControl.hp > 0)
																{
																	if (226066 - 496770 != -270704)
																	{
																		goto IL_516;
																	}
																	this.BTSccO5h7nf.myAttackTarget = gameObject;
																	if (255108 - 224404 == 30705)
																	{
																		goto IL_516;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (30973 - 172289 == -141315)
																	{
																		goto IL_516;
																	}
																	this.BTSccO5h7nf.addHate(characterControl.ActorNr, 5);
																	if (114401 - 22756 != 91645)
																	{
																		goto IL_516;
																	}
																}
															}
														}
														if (this.BTSccO5h7nf.myAttackTarget)
														{
															if (192188 - 148738 == 43451)
															{
																goto IL_516;
															}
															this.BTSccO5h7nf.isAlert = true;
															if (226295 - 241383 != -15088)
															{
																goto IL_516;
															}
															this.olDccvvNVwi = Time.time;
															if (36764 - 16641 != 20123)
															{
																goto IL_516;
															}
														}
													}
												}
											}
										}
									}
								}
								if (175185 - 270006 == -94821)
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

	// Token: 0x06004BD6 RID: 19414 RVA: 0x00960008 File Offset: 0x0095E208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004BD7 RID: 19415 RVA: 0x0096000C File Offset: 0x0095E20C
	internal static bool FX4NHO57q1a3uNxv4dYv()
	{
		return true;
	}

	// Token: 0x06004BD8 RID: 19416 RVA: 0x00960010 File Offset: 0x0095E210
	internal static bool EJr6ac577nMQKb8J1IsQ()
	{
		return false;
	}

	// Token: 0x04005639 RID: 22073
	private CharacterControl BTSccO5h7nf;

	// Token: 0x0400563A RID: 22074
	private Owl2 VyPcc2Ju2ax;

	// Token: 0x0400563B RID: 22075
	public string AI_state;

	// Token: 0x0400563C RID: 22076
	private float olDccvvNVwi;

	// Token: 0x0400563D RID: 22077
	private float w89cclxqsV8;

	// Token: 0x0400563E RID: 22078
	private float dtfccGjAauE;
}
