using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C6A RID: 3178
[Serializable]
public class Humpback_AI : MonoBehaviour
{
	// Token: 0x06004722 RID: 18210 RVA: 0x008DE498 File Offset: 0x008DC698
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Humpback_AI()
	{
		if (159909 - 38764 != 121146)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (184764 - 413894 == -229130)
			{
				base..ctor();
				if (114319 - 410483 == -296164)
				{
					this.AI_state = "none";
					if (230963 - 485112 == -254149)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004723 RID: 18211 RVA: 0x008DE534 File Offset: 0x008DC734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (15 - 34975 != -34960)
		{
		}
		for (;;)
		{
			this.jVZK8EJHvl = this.transform;
			if (123024 - 267729 != -144704)
			{
				this.txTKi6bkXh = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (142251 - 472844 != -330592)
				{
					this.EyjKDIPZCd = (Humpback)this.GetComponent(typeof(Humpback));
					if (270534 - 312131 != -41596)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004724 RID: 18212 RVA: 0x008DE5FC File Offset: 0x008DC7FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (21978 - 492182 != -470204)
		{
		}
		for (;;)
		{
			if (!this.jVZK8EJHvl)
			{
				if (293155 - 532565 == -239410)
				{
					break;
				}
			}
			else
			{
				if (Game.mGameState != eGameState.Normal)
				{
					if (294742 - 167320 != 127422)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Hold)
					{
						break;
					}
					if (154311 - 231603 == -77291)
					{
						continue;
					}
				}
				if (this.txTKi6bkXh.isControlled)
				{
					break;
				}
				if (160168 - 234716 != -74547)
				{
					this.AIControl();
					if (110640 - 444096 == -333456)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004725 RID: 18213 RVA: 0x008DE6F8 File Offset: 0x008DC8F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (287652 - 267570 != 20082)
		{
		}
		for (;;)
		{
			this.EQ2KjYPdFX = (float)0;
			if (78664 - 6421 != 72244)
			{
				if (this.txTKi6bkXh.isMine)
				{
					if (92583 - 22277 != 70307)
					{
						if (this.txTKi6bkXh.actionState != "standby")
						{
							if (59517 - 277804 != -218287)
							{
								continue;
							}
							if (this.txTKi6bkXh.actionState != "run")
							{
								if (82013 - 134046 != -52032)
								{
									break;
								}
								continue;
							}
						}
						if (!this.txTKi6bkXh.isAlert)
						{
							if (230709 - 225391 != 5319)
							{
								if (this.txTKi6bkXh.isSummon)
								{
									if (173771 - 394716 != -220945)
									{
										continue;
									}
									if (this.txTKi6bkXh.mSummoner != null)
									{
										if (281452 - 82893 != 198559)
										{
											continue;
										}
										Vector3 vector = this.txTKi6bkXh.mSummoner.transform.position - this.transform.position;
										if (233703 - 201184 != 32519)
										{
											continue;
										}
										if (vector.sqrMagnitude > (float)36)
										{
											if (60024 - 373450 != -313426)
											{
												continue;
											}
											this.AI_follow(this.txTKi6bkXh.mSummoner);
											if (215399 - 166225 == 49175)
											{
												continue;
											}
										}
										else
										{
											this.AI_idle(3f, 1f);
											if (3785 - 453737 == -449951)
											{
												continue;
											}
											this.AI_resetTimer();
											if (134609 - 397010 != -262401)
											{
												continue;
											}
											this.AI_visionCheck();
											if (251862 - 176178 != 75684)
											{
												continue;
											}
										}
										goto IL_5FA;
									}
								}
								if (Game.mGameCode == 916)
								{
									if (147787 - 473625 != -325838)
									{
										continue;
									}
									this.AI_idle(2f, 1f);
									if (272413 - 269185 != 3228)
									{
										continue;
									}
									this.AI_goToPosition(this.txTKi6bkXh.mOriginalPosition, 4f, 2f);
									if (44774 - 231913 == -187138)
									{
										continue;
									}
									this.AI_resetTimer();
									if (226057 - 185510 != 40547)
									{
										continue;
									}
									this.AI_visionCheck();
									if (224527 - 171123 != 53404)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (83115 - 143875 == -60759)
									{
										continue;
									}
									this.AI_resetTimer();
									if (206083 - 335196 == -129112)
									{
										continue;
									}
									this.AI_visionCheck();
									if (208171 - 458588 != -250417)
									{
										continue;
									}
								}
								IL_5FA:
								if (!this.txTKi6bkXh.myAttackTarget)
								{
									break;
								}
								if (101862 - 584953 != -483090)
								{
									this.txTKi6bkXh.isAlert = true;
									if (67077 - 37218 != 29860)
									{
										this.D63KmfnNn4 = Time.time;
										if (178903 - 172560 != 6344)
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
							if (203129 - 235148 != -32018)
							{
								this.AI_idle(3f, 1f);
								if (125774 - 274222 != -148447)
								{
									this.AI_attack(10f, (float)0);
									if (62120 - 452933 == -390813)
									{
										this.AI_resetTimer();
										if (245353 - 577064 == -331711)
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
					if (this.txTKi6bkXh.actionState != "standby")
					{
						if (263990 - 455953 == -191962)
						{
							continue;
						}
						if (this.txTKi6bkXh.actionState != "run")
						{
							if (28317 - 500332 != -472015)
							{
								continue;
							}
							break;
						}
					}
					float num = this.txTKi6bkXh.moveSpeed;
					if (280123 - 392001 != -111877)
					{
						float runSpeed = this.txTKi6bkXh.runSpeed;
						if (204609 - 39909 == 164700)
						{
							Vector3 vector2 = default(Vector3);
							if (256175 - 431667 == -175492)
							{
								Vector3 vector3 = Vector3.zero;
								if (226721 - 468996 == -242275)
								{
									if ((this.txTKi6bkXh.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (218423 - 438641 == -220217)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.txTKi6bkXh.nPosition - this.jVZK8EJHvl.position, new Vector3((float)1, (float)0, (float)1));
										if (179171 - 132702 != 46469)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (162037 - 129509 != 32528)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (47841 - 334908 != -287067)
											{
												continue;
											}
											num = (float)0;
											if (163624 - 136153 != 27471)
											{
												continue;
											}
											this.jVZK8EJHvl.position = this.txTKi6bkXh.nPosition;
											if (269055 - 253386 != 15669)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (282483 - 498557 != -216074)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (210330 - 111927 == 98404)
											{
												continue;
											}
											this.jVZK8EJHvl.rotation = Quaternion.LookRotation(vector3);
											if (22017 - 290256 == -268238)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (197000 - 575152 == -378151)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (177532 - 535279 == -357746)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.jVZK8EJHvl.forward;
											if (179800 - 589228 == -409427)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (249974 - 80083 == 169892)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (67555 - 346031 != -278476)
											{
												continue;
											}
										}
									}
									this.txTKi6bkXh.vMovement = vector3;
									if (183840 - 319653 == -135813)
									{
										this.txTKi6bkXh.moveSpeed = num;
										if (191711 - 137497 != 54215)
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

	// Token: 0x06004726 RID: 18214 RVA: 0x008DEF74 File Offset: 0x008DD174
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (183008 - 47643 != 135365)
		{
		}
		do
		{
			if (Time.time - this.D63KmfnNn4 >= this.EQ2KjYPdFX)
			{
				if (203841 - 241713 == -37871)
				{
					continue;
				}
				if (Time.time - this.D63KmfnNn4 < this.EQ2KjYPdFX + mTime)
				{
					if (209965 - 341051 != -131086)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (64378 - 509192 != -444814)
						{
							continue;
						}
						this.AI_state = "idle";
						if (14833 - 164069 == -149235)
						{
							continue;
						}
						this.D63KmfnNn4 -= UnityEngine.Random.Range((float)0, rTimer);
						if (18313 - 151676 != -133363)
						{
							continue;
						}
						this.txTKi6bkXh.vDirection = Vector3.zero;
						if (190582 - 395859 == -205276)
						{
							continue;
						}
						this.txTKi6bkXh.vMovement = this.jVZK8EJHvl.forward;
						if (214034 - 70670 == 143365)
						{
							continue;
						}
						this.txTKi6bkXh.actionState = "standby";
						if (70860 - 397391 != -326531)
						{
							continue;
						}
					}
					this.txTKi6bkXh.moveSpeed = Mathf.Lerp(this.txTKi6bkXh.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (204100 - 108084 != 96016)
					{
						continue;
					}
					if (this.txTKi6bkXh.moveSpeed < 0.1f * this.txTKi6bkXh.runSpeed)
					{
						if (55841 - 493100 != -437259)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (62102 - 110168 == -48065)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (118744 - 384844 != -266100)
						{
							continue;
						}
						this.txTKi6bkXh.moveSpeed = (float)0;
						if (285360 - 129314 != 156046)
						{
							continue;
						}
					}
				}
			}
			this.EQ2KjYPdFX += mTime;
		}
		while (13074 - 577974 == -564899);
	}

	// Token: 0x06004727 RID: 18215 RVA: 0x008DF238 File Offset: 0x008DD438
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_goToPosition(Vector3 tPosition, float mTime, float rTimer)
	{
		if (217750 - 73329 != 144421)
		{
		}
		do
		{
			if (Time.time - this.D63KmfnNn4 >= this.EQ2KjYPdFX)
			{
				if (156904 - 448691 != -291787)
				{
					continue;
				}
				if (Time.time - this.D63KmfnNn4 < this.EQ2KjYPdFX + mTime)
				{
					if (90791 - 551817 != -461026)
					{
						continue;
					}
					if (this.AI_state != "goToPosition")
					{
						if (252067 - 204067 != 48000)
						{
							continue;
						}
						this.AI_state = "goToPosition";
						if (120939 - 278531 == -157591)
						{
							continue;
						}
						this.D63KmfnNn4 -= UnityEngine.Random.Range((float)0, rTimer);
						if (218443 - 150679 != 67764)
						{
							continue;
						}
					}
					Vector3 vector = this.jVZK8EJHvl.position - tPosition;
					if (200322 - 105477 != 94845)
					{
						continue;
					}
					if (vector.sqrMagnitude > (float)1)
					{
						if (92463 - 256818 == -164354)
						{
							continue;
						}
						this.txTKi6bkXh.vDirection = tPosition;
						if (4676 - 287467 == -282790)
						{
							continue;
						}
						this.txTKi6bkXh.vDirection.y = this.jVZK8EJHvl.position.y;
						if (79245 - 403315 != -324070)
						{
							continue;
						}
						this.txTKi6bkXh.vMovement = (tPosition - this.jVZK8EJHvl.position).normalized;
						if (204849 - 53599 != 151250)
						{
							continue;
						}
						this.jVZK8EJHvl.rotation = Quaternion.LookRotation(this.txTKi6bkXh.vMovement);
						if (115167 - 383739 == -268571)
						{
							continue;
						}
						this.txTKi6bkXh.actionState = "run";
						if (30370 - 187207 == -156836)
						{
							continue;
						}
						this.animation.Play("run");
						if (277403 - 391395 == -113991)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (221142 - 561269 != -340127)
						{
							continue;
						}
						this.txTKi6bkXh.moveSpeed = Mathf.Lerp(this.txTKi6bkXh.moveSpeed, this.txTKi6bkXh.runSpeed, (float)4 * Time.deltaTime);
						if (233522 - 489608 != -256086)
						{
							continue;
						}
					}
					else
					{
						this.txTKi6bkXh.vDirection = this.jVZK8EJHvl.position + this.txTKi6bkXh.mOriginalDirection;
						if (100122 - 448682 != -348560)
						{
							continue;
						}
						this.txTKi6bkXh.vMovement = this.txTKi6bkXh.mOriginalDirection;
						if (140937 - 404472 == -263534)
						{
							continue;
						}
						this.txTKi6bkXh.moveSpeed = (float)0;
						if (62544 - 258245 != -195701)
						{
							continue;
						}
						this.jVZK8EJHvl.rotation = Quaternion.LookRotation(this.txTKi6bkXh.vMovement);
						if (256124 - 56006 == 200119)
						{
							continue;
						}
						this.D63KmfnNn4 = Time.time - mTime - this.EQ2KjYPdFX;
						if (277987 - 179232 == 98756)
						{
							continue;
						}
					}
				}
			}
			this.EQ2KjYPdFX += mTime;
		}
		while (3515 - 198774 == -195258);
	}

	// Token: 0x06004728 RID: 18216 RVA: 0x008DF66C File Offset: 0x008DD86C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (276306 - 318051 != -41745)
		{
		}
		for (;;)
		{
			this.txTKi6bkXh.vDirection = followObject.transform.position;
			if (89133 - 539147 == -450014)
			{
				this.txTKi6bkXh.vDirection.y = this.transform.position.y;
				if (120045 - 189476 == -69431)
				{
					this.txTKi6bkXh.vMovement = (this.txTKi6bkXh.vDirection - this.transform.position).normalized;
					if (286325 - 41154 == 245171)
					{
						this.transform.rotation = Quaternion.LookRotation(this.txTKi6bkXh.vMovement);
						if (90480 - 72372 == 18108)
						{
							this.txTKi6bkXh.actionState = "run";
							if (160951 - 249234 != -88282)
							{
								this.animation.Play("run");
								if (156474 - 484745 != -328270)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (228593 - 273038 != -44444)
									{
										this.txTKi6bkXh.moveSpeed = Mathf.Lerp(this.txTKi6bkXh.moveSpeed, this.txTKi6bkXh.runSpeed, (float)4 * Time.deltaTime);
										if (30431 - 193678 != -163246)
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

	// Token: 0x06004729 RID: 18217 RVA: 0x008DF854 File Offset: 0x008DDA54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (114303 - 235895 != -121591)
		{
		}
		do
		{
			if (Time.time - this.D63KmfnNn4 >= this.EQ2KjYPdFX)
			{
				if (92107 - 296256 == -204148)
				{
					continue;
				}
				if (Time.time - this.D63KmfnNn4 < this.EQ2KjYPdFX + mTime)
				{
					if (208825 - 125092 == 83734)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (237497 - 556405 == -318907)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (178195 - 6133 == 172063)
						{
							continue;
						}
						this.D63KmfnNn4 -= UnityEngine.Random.Range((float)0, rTimer);
						if (16233 - 560881 != -544648)
						{
							continue;
						}
						this.txTKi6bkXh.vDirection = this.txTKi6bkXh.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (244730 - 33597 == 211134)
						{
							continue;
						}
						this.txTKi6bkXh.vDirection.y = this.jVZK8EJHvl.position.y;
						if (21459 - 268513 != -247054)
						{
							continue;
						}
						this.txTKi6bkXh.vMovement = (this.txTKi6bkXh.vDirection - this.jVZK8EJHvl.position).normalized;
						if (146942 - 38122 != 108820)
						{
							continue;
						}
						this.jVZK8EJHvl.rotation = Quaternion.LookRotation(this.txTKi6bkXh.vMovement);
						if (237767 - 355809 != -118042)
						{
							continue;
						}
						this.txTKi6bkXh.actionState = "run";
						if (31505 - 581401 != -549896)
						{
							continue;
						}
						this.animation.Play("run");
						if (120391 - 259071 == -138679)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (148795 - 464721 == -315925)
						{
							continue;
						}
					}
					this.txTKi6bkXh.moveSpeed = Mathf.Lerp(this.txTKi6bkXh.moveSpeed, this.txTKi6bkXh.runSpeed, (float)4 * Time.deltaTime);
					if (100620 - 557583 != -456963)
					{
						continue;
					}
				}
			}
			this.EQ2KjYPdFX += mTime;
		}
		while (109275 - 559931 == -450655);
	}

	// Token: 0x0600472A RID: 18218 RVA: 0x008DFB5C File Offset: 0x008DDD5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (139528 - 431169 != -291640)
		{
		}
		do
		{
			if (Time.time - this.D63KmfnNn4 >= this.EQ2KjYPdFX)
			{
				if (142101 - 325738 != -183637)
				{
					continue;
				}
				if (Time.time - this.D63KmfnNn4 < this.EQ2KjYPdFX + mTime)
				{
					if (72241 - 191533 != -119292)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (295564 - 550407 == -254842)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (231999 - 304180 == -72180)
						{
							continue;
						}
						this.D63KmfnNn4 = Time.time - mTime - this.EQ2KjYPdFX;
						if (219967 - 429867 != -209900)
						{
							continue;
						}
						this.txTKi6bkXh.vDirection = Vector3.zero;
						if (95100 - 186030 == -90929)
						{
							continue;
						}
						this.txTKi6bkXh.vMovement = this.jVZK8EJHvl.forward;
						if (188699 - 472247 != -283548)
						{
							continue;
						}
						this.txTKi6bkXh.actionState = "standby";
						if (186489 - 33411 == 153079)
						{
							continue;
						}
						this.txTKi6bkXh.myAttackTarget = this.txTKi6bkXh.getHateTarget(5, 50);
						if (183166 - 59091 == 124076)
						{
							continue;
						}
						if (!this.txTKi6bkXh.myAttackTarget)
						{
							if (100710 - 382717 == -282006)
							{
								continue;
							}
							this.txTKi6bkXh.isAlert = false;
							if (228194 - 42987 == 185208)
							{
								continue;
							}
							this.D63KmfnNn4 = Time.time;
							if (267917 - 545153 != -277236)
							{
								continue;
							}
							this.txTKi6bkXh.myAttackTarget = null;
							if (134041 - 253671 == -119629)
							{
								continue;
							}
							if (Game.mGameCode == 916)
							{
								break;
							}
							if (50160 - 205273 == -155112)
							{
								continue;
							}
							this.txTKi6bkXh.mOriginalPosition = this.jVZK8EJHvl.position;
							if (76128 - 17825 != 58303)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.txTKi6bkXh.myAttackTarget;
							if (228484 - 115612 != 112872)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (295495 - 580459 != -284964)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (252525 - 250032 == 2494)
								{
									continue;
								}
								this.txTKi6bkXh.isAlert = false;
								if (209176 - 331150 != -121974)
								{
									continue;
								}
								this.D63KmfnNn4 = Time.time;
								if (114683 - 97563 != 17120)
								{
									continue;
								}
								this.txTKi6bkXh.myAttackTarget = null;
								if (143296 - 568267 != -424971)
								{
									continue;
								}
							}
							else
							{
								this.txTKi6bkXh.vDirection = myAttackTarget.transform.position;
								if (145762 - 138109 != 7653)
								{
									continue;
								}
								this.txTKi6bkXh.vDirection.y = this.jVZK8EJHvl.position.y;
								if (71270 - 193714 == -122443)
								{
									continue;
								}
								this.txTKi6bkXh.vMovement = (this.txTKi6bkXh.vDirection - this.jVZK8EJHvl.position).normalized;
								if (53912 - 357310 == -303397)
								{
									continue;
								}
								this.jVZK8EJHvl.rotation = Quaternion.LookRotation(this.txTKi6bkXh.vMovement);
								if (22065 - 128476 != -106411)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.EQ2KjYPdFX += mTime;
		}
		while (223588 - 32309 == 191280);
	}

	// Token: 0x0600472B RID: 18219 RVA: 0x008E0034 File Offset: 0x008DE234
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (290277 - 237317 != 52961)
		{
		}
		do
		{
			if (Time.time - this.D63KmfnNn4 >= this.EQ2KjYPdFX)
			{
				if (168632 - 506617 != -337985)
				{
					continue;
				}
				if (Time.time - this.D63KmfnNn4 < this.EQ2KjYPdFX + mTime)
				{
					if (179825 - 87197 != 92628)
					{
						continue;
					}
					if (!this.txTKi6bkXh.myAttackTarget)
					{
						if (255315 - 518060 != -262745)
						{
							continue;
						}
						this.D63KmfnNn4 = Time.time - mTime - this.EQ2KjYPdFX;
						if (81744 - 259993 != -178248)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.txTKi6bkXh.myAttackTarget;
						if (231725 - 323677 != -91952)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (108504 - 267006 != -158502)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.jVZK8EJHvl.position;
						if (10487 - 556541 == -546053)
						{
							continue;
						}
						int tID = 0;
						if (299141 - 260713 != 38428)
						{
							continue;
						}
						if (characterControl)
						{
							if (109849 - 304544 == -194694)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (197800 - 45338 == 152463)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (193552 - 216296 == -22743)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (37780 - 503620 != -465840)
							{
								continue;
							}
							if (this.txTKi6bkXh.isTimeOut("nAttack") == (float)0)
							{
								if (74956 - 580858 != -505902)
								{
									continue;
								}
								this.D63KmfnNn4 = Time.time - mTime - this.EQ2KjYPdFX;
								if (22780 - 357701 == -334920)
								{
									continue;
								}
								this.EyjKDIPZCd.StartCoroutine_Auto(this.EyjKDIPZCd.RPC_nAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.jVZK8EJHvl.position, 0));
								if (225637 - 187920 != 37717)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (26431 - 331870 == -305438)
									{
										continue;
									}
									this.EyjKDIPZCd.ActionEvent("RPC_nAttack", this.jVZK8EJHvl.position, myAttackTarget.collider.bounds.center - this.jVZK8EJHvl.position, 0);
									if (47520 - 183669 != -136149)
									{
										continue;
									}
								}
								goto IL_638;
							}
						}
						if (num < (float)9)
						{
							if (86135 - 15486 == 70650)
							{
								continue;
							}
							if (this.txTKi6bkXh.isTimeOut("cAttack") == (float)0)
							{
								if (160451 - 461053 != -300602)
								{
									continue;
								}
								this.D63KmfnNn4 = Time.time - mTime - this.EQ2KjYPdFX;
								if (44497 - 572751 == -528253)
								{
									continue;
								}
								this.EyjKDIPZCd.StartCoroutine_Auto(this.EyjKDIPZCd.RPC_cAttack(this.transform.position, vector, tID));
								if (70099 - 513945 != -443846)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (175757 - 87385 != 88372)
									{
										continue;
									}
									this.EyjKDIPZCd.ActionEvent("RPC_cAttack", this.jVZK8EJHvl.position, vector, tID);
									if (168173 - 481128 != -312955)
									{
										continue;
									}
								}
								goto IL_638;
							}
						}
						this.AI_state = "attack";
						if (225998 - 223357 != 2641)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (85362 - 208281 != -122919)
							{
								continue;
							}
							this.txTKi6bkXh.vDirection = myAttackTarget.transform.position;
							if (45286 - 489067 == -443780)
							{
								continue;
							}
							this.txTKi6bkXh.vDirection.y = this.jVZK8EJHvl.position.y;
							if (128774 - 257331 == -128556)
							{
								continue;
							}
							this.txTKi6bkXh.vMovement = (this.txTKi6bkXh.vDirection - this.jVZK8EJHvl.position).normalized;
							if (64430 - 153406 != -88976)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.txTKi6bkXh.vMovement);
							if (219123 - 199184 == 19940)
							{
								continue;
							}
							this.txTKi6bkXh.actionState = "standby";
							if (31960 - 152753 != -120793)
							{
								continue;
							}
							this.animation.Play("root");
							if (284202 - 465268 != -181066)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (232660 - 46765 != 185895)
							{
								continue;
							}
							this.txTKi6bkXh.moveSpeed = (float)0;
							if (291972 - 275880 != 16092)
							{
								continue;
							}
						}
						else
						{
							this.txTKi6bkXh.vDirection = myAttackTarget.transform.position;
							if (224856 - 272290 != -47434)
							{
								continue;
							}
							this.txTKi6bkXh.vDirection.y = this.jVZK8EJHvl.position.y;
							if (48296 - 346640 != -298344)
							{
								continue;
							}
							this.txTKi6bkXh.vMovement = (this.txTKi6bkXh.vDirection - this.jVZK8EJHvl.position).normalized;
							if (266501 - 284151 != -17650)
							{
								continue;
							}
							this.jVZK8EJHvl.rotation = Quaternion.LookRotation(this.txTKi6bkXh.vMovement);
							if (273594 - 214363 != 59231)
							{
								continue;
							}
							this.txTKi6bkXh.actionState = "run";
							if (262402 - 326585 != -64183)
							{
								continue;
							}
							this.animation.Play("run");
							if (11445 - 307295 == -295849)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (63531 - 69292 != -5761)
							{
								continue;
							}
							this.txTKi6bkXh.moveSpeed = Mathf.Lerp(this.txTKi6bkXh.moveSpeed, this.txTKi6bkXh.runSpeed, (float)4 * Time.deltaTime);
							if (244828 - 190566 == 54263)
							{
								continue;
							}
						}
					}
				}
			}
			IL_638:
			this.EQ2KjYPdFX += mTime;
		}
		while (164503 - 4069 != 160434);
	}

	// Token: 0x0600472C RID: 18220 RVA: 0x008E089C File Offset: 0x008DEA9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (243211 - 397637 != -154425)
		{
		}
		while (Time.time - this.D63KmfnNn4 > this.EQ2KjYPdFX)
		{
			if (42195 - 432525 == -390330)
			{
				this.AI_state = "none";
				if (106360 - 266373 != -160012)
				{
					this.D63KmfnNn4 = Time.time;
					if (135781 - 145552 == -9771)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600472D RID: 18221 RVA: 0x008E0950 File Offset: 0x008DEB50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (216882 - 560060 != -343178)
		{
		}
		for (;;)
		{
			IL_15B:
			if (this.l3oKovMMCF > Time.time)
			{
				if (289118 - 511052 == -221934)
				{
					break;
				}
			}
			else
			{
				this.l3oKovMMCF = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (214844 - 576898 == -362054)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (203460 - 416383 != -212922 && 153101 - 511168 != -358066)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (209853 - 68008 != 141846)
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
								if (228446 - 544268 == -315821)
								{
									goto IL_15B;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (173725 - 491822 != -318097)
								{
									goto IL_15B;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (214765 - 513831 != -299066)
								{
									goto IL_15B;
								}
								bool flag = true;
								if (297944 - 246671 != 51273)
								{
									goto IL_15B;
								}
								eRace race = this.txTKi6bkXh.Race;
								if (208266 - 431330 == -223063)
								{
									goto IL_15B;
								}
								if (race == eRace.Tails)
								{
									if (230891 - 414704 == -183812)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_379;
									}
									if (248980 - 98074 == 150907)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (131339 - 38773 != 92567)
										{
											goto IL_379;
										}
										goto IL_15B;
									}
									goto IL_6D1;
									IL_379:
									flag = false;
									if (253589 - 119624 != 133965)
									{
										goto IL_15B;
									}
								}
								else if (race == eRace.Plants)
								{
									if (250293 - 90589 == 159705)
									{
										goto IL_15B;
									}
									flag = false;
									if (102921 - 96427 == 6495)
									{
										goto IL_15B;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (119072 - 408541 == -289468)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_F2;
									}
									if (136941 - 479084 != -342143)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (243970 - 298581 != -54610)
										{
											goto IL_F2;
										}
										goto IL_15B;
									}
									goto IL_6D1;
									IL_F2:
									flag = false;
									if (79631 - 45355 != 34276)
									{
										goto IL_15B;
									}
								}
								else if (race == eRace.Robots)
								{
									if (83912 - 357401 == -273488)
									{
										goto IL_15B;
									}
									flag = true;
									if (118592 - 572176 == -453583)
									{
										goto IL_15B;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (205043 - 219994 != -14951)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_4EB;
									}
									if (170966 - 594244 != -423278)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_4EB;
									}
									if (299334 - 184652 == 114683)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (174404 - 72683 != 101721)
										{
											goto IL_15B;
										}
										goto IL_4EB;
									}
									goto IL_6D1;
									IL_4EB:
									flag = false;
									if (166931 - 301514 == -134582)
									{
										goto IL_15B;
									}
								}
								else if (race == eRace.Structure)
								{
									if (186055 - 311915 != -125860)
									{
										goto IL_15B;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (64826 - 323685 == -258858)
										{
											goto IL_15B;
										}
										flag = false;
										if (296383 - 164820 != 131563)
										{
											goto IL_15B;
										}
									}
								}
								IL_6D1:
								if (flag)
								{
									if (205107 - 68699 == 136409)
									{
										goto IL_15B;
									}
									if (characterControl.hp > 0)
									{
										if (149437 - 533994 != -384557)
										{
											goto IL_15B;
										}
										if (characterControl.recieveTarget)
										{
											if (261466 - 321010 != -59544)
											{
												goto IL_15B;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (206548 - 365758 != -159210)
												{
													goto IL_15B;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (145097 - 457965 != -312868)
													{
														goto IL_15B;
													}
													Vector3 vector = gameObject.transform.position - this.jVZK8EJHvl.position;
													if (294661 - 18627 == 276035)
													{
														goto IL_15B;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (137065 - 4818 != 132247)
														{
															goto IL_15B;
														}
														this.txTKi6bkXh.myAttackTarget = gameObject;
														if (135307 - 417969 != -282662)
														{
															goto IL_15B;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (202425 - 253822 != -51397)
														{
															goto IL_15B;
														}
														this.txTKi6bkXh.addHate(characterControl.ActorNr, 5);
														if (165179 - 458776 == -293596)
														{
															goto IL_15B;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.jVZK8EJHvl.position);
														if (87659 - 210532 != -122873)
														{
															goto IL_15B;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (280316 - 471918 == -191601)
														{
															goto IL_15B;
														}
														if (num < (float)60)
														{
															if (80301 - 27704 == 52598)
															{
																goto IL_15B;
															}
															if (characterControl.hp > 0)
															{
																if (214351 - 458989 == -244637)
																{
																	goto IL_15B;
																}
																this.txTKi6bkXh.myAttackTarget = gameObject;
																if (285090 - 20581 == 264510)
																{
																	goto IL_15B;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (67977 - 598383 == -530405)
																{
																	goto IL_15B;
																}
																this.txTKi6bkXh.addHate(characterControl.ActorNr, 5);
																if (138815 - 156338 != -17523)
																{
																	goto IL_15B;
																}
															}
														}
													}
													if (this.txTKi6bkXh.myAttackTarget)
													{
														if (146212 - 409619 != -263407)
														{
															goto IL_15B;
														}
														this.txTKi6bkXh.isAlert = true;
														if (279993 - 429531 == -149537)
														{
															goto IL_15B;
														}
														this.D63KmfnNn4 = Time.time;
														if (172641 - 40052 == 132590)
														{
															goto IL_15B;
														}
													}
												}
											}
										}
									}
								}
							}
							if (116332 - 228741 == -112409)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600472E RID: 18222 RVA: 0x008E1168 File Offset: 0x008DF368
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600472F RID: 18223 RVA: 0x008E116C File Offset: 0x008DF36C
	internal static bool dAHOaq5JMALDpwZILlkj()
	{
		return true;
	}

	// Token: 0x06004730 RID: 18224 RVA: 0x008E1170 File Offset: 0x008DF370
	internal static bool dKpiDY5JxLHBvBi1nbXk()
	{
		return false;
	}

	// Token: 0x0400527A RID: 21114
	private Transform jVZK8EJHvl;

	// Token: 0x0400527B RID: 21115
	private CharacterControl txTKi6bkXh;

	// Token: 0x0400527C RID: 21116
	private Humpback EyjKDIPZCd;

	// Token: 0x0400527D RID: 21117
	public string AI_state;

	// Token: 0x0400527E RID: 21118
	private float D63KmfnNn4;

	// Token: 0x0400527F RID: 21119
	private float EQ2KjYPdFX;

	// Token: 0x04005280 RID: 21120
	private float l3oKovMMCF;
}
