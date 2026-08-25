using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B8E RID: 2958
[Serializable]
public class Bear_AI : MonoBehaviour
{
	// Token: 0x060041E4 RID: 16868 RVA: 0x00853008 File Offset: 0x00851208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bear_AI()
	{
		if (112206 - 371814 != -259607)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (92147 - 561243 != -469095)
			{
				base..ctor();
				if (202154 - 556659 != -354504)
				{
					this.AI_state = "none";
					if (122153 - 485393 == -363240)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060041E5 RID: 16869 RVA: 0x008530A4 File Offset: 0x008512A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.hdTV4eY5Ev = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.CCtVsr5dCe = (Bear)this.GetComponent(typeof(Bear));
	}

	// Token: 0x060041E6 RID: 16870 RVA: 0x008530DC File Offset: 0x008512DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (19547 - 187198 != -167651)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (223813 - 516510 != -292697)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (217333 - 532195 == -314861)
				{
					continue;
				}
			}
			if (this.hdTV4eY5Ev.isControlled)
			{
				break;
			}
			if (204677 - 448031 != -243353)
			{
				this.AIControl();
				if (146350 - 354489 == -208139)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060041E7 RID: 16871 RVA: 0x008531A8 File Offset: 0x008513A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (251618 - 446008 != -194389)
		{
		}
		for (;;)
		{
			this.QAYV74khj4 = (float)0;
			if (287866 - 350499 == -62633)
			{
				if (this.hdTV4eY5Ev.isMine)
				{
					if (32734 - 463779 != -431044)
					{
						if (this.hdTV4eY5Ev.actionState != "standby")
						{
							if (255120 - 439413 == -184292)
							{
								continue;
							}
							if (this.hdTV4eY5Ev.actionState != "run")
							{
								if (91268 - 26065 != 65204)
								{
									break;
								}
								continue;
							}
						}
						if (!this.hdTV4eY5Ev.isAlert)
						{
							if (229313 - 301781 != -72467)
							{
								if (!this.hdTV4eY5Ev.isSummon)
								{
									goto IL_2AC;
								}
								if (86749 - 588409 == -501659)
								{
									continue;
								}
								if (!(this.hdTV4eY5Ev.mSummoner != null))
								{
									goto IL_2AC;
								}
								if (56290 - 181192 == -124901)
								{
									continue;
								}
								Vector3 vector = this.hdTV4eY5Ev.mSummoner.transform.position - this.transform.position;
								if (34948 - 249838 != -214890)
								{
									continue;
								}
								if (vector.sqrMagnitude > (float)36)
								{
									if (154086 - 24045 == 130042)
									{
										continue;
									}
									this.AI_follow(this.hdTV4eY5Ev.mSummoner);
									if (245287 - 427878 != -182591)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (158834 - 94316 != 64518)
									{
										continue;
									}
									this.AI_resetTimer();
									if (243784 - 60149 != 183635)
									{
										continue;
									}
									this.AI_visionCheck();
									if (208394 - 216970 != -8576)
									{
										continue;
									}
								}
								IL_527:
								if (!this.hdTV4eY5Ev.myAttackTarget)
								{
									break;
								}
								if (129290 - 370128 != -240838)
								{
									continue;
								}
								this.hdTV4eY5Ev.isAlert = true;
								if (48156 - 540580 != -492424)
								{
									continue;
								}
								this.LeYVH5xcKo = Time.time;
								if (7206 - 339997 != -332790)
								{
									break;
								}
								continue;
								IL_2AC:
								this.AI_idle(3f, 1f);
								if (42250 - 117153 != -74902)
								{
									this.AI_patrol(1f, 0.25f);
									if (238166 - 301408 == -63242)
									{
										this.AI_resetTimer();
										if (98901 - 297228 != -198326)
										{
											this.AI_visionCheck();
											if (140261 - 19376 != 120886)
											{
												goto IL_527;
											}
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (274842 - 524200 != -249357)
							{
								this.AI_idle(3f, 1f);
								if (247099 - 285277 == -38178)
								{
									this.AI_attack(10f, (float)0);
									if (76469 - 186377 == -109908)
									{
										this.AI_resetTimer();
										if (255493 - 366997 == -111504)
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
					if (this.hdTV4eY5Ev.actionState != "standby")
					{
						if (107630 - 401385 != -293755)
						{
							continue;
						}
						if (this.hdTV4eY5Ev.actionState != "run")
						{
							if (118943 - 596048 != -477105)
							{
								continue;
							}
							break;
						}
					}
					float num = this.hdTV4eY5Ev.moveSpeed;
					if (135312 - 551337 != -416024)
					{
						float runSpeed = this.hdTV4eY5Ev.runSpeed;
						if (155693 - 178345 == -22652)
						{
							Vector3 vector2 = default(Vector3);
							if (43103 - 298201 != -255097)
							{
								Vector3 vector3 = Vector3.zero;
								if (141959 - 66874 == 75085)
								{
									if ((this.hdTV4eY5Ev.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (179942 - 588803 != -408861)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.hdTV4eY5Ev.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (95520 - 408756 != -313236)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (267672 - 375347 != -107675)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (246281 - 242592 == 3690)
											{
												continue;
											}
											num = (float)0;
											if (279479 - 286804 != -7325)
											{
												continue;
											}
											this.transform.position = this.hdTV4eY5Ev.nPosition;
											if (168617 - 323356 == -154738)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (60747 - 387951 == -327203)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (253341 - 207026 != 46315)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (217395 - 62689 != 154706)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (118822 - 470763 != -351941)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (177992 - 513881 == -335888)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (258640 - 193862 != 64778)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (118995 - 72670 != 46325)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (68176 - 18016 != 50160)
											{
												continue;
											}
										}
									}
									this.hdTV4eY5Ev.vMovement = vector3;
									if (200603 - 590486 != -389882)
									{
										this.hdTV4eY5Ev.moveSpeed = num;
										if (238985 - 50081 == 188904)
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

	// Token: 0x060041E8 RID: 16872 RVA: 0x00853984 File Offset: 0x00851B84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (227801 - 37663 != 190139)
		{
		}
		do
		{
			if (Time.time - this.LeYVH5xcKo >= this.QAYV74khj4)
			{
				if (82828 - 361389 == -278560)
				{
					continue;
				}
				if (Time.time - this.LeYVH5xcKo < this.QAYV74khj4 + mTime)
				{
					if (100626 - 231096 == -130469)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (185035 - 131520 == 53516)
						{
							continue;
						}
						this.AI_state = "idle";
						if (123389 - 507079 != -383690)
						{
							continue;
						}
						this.LeYVH5xcKo -= UnityEngine.Random.Range((float)0, rTimer);
						if (222176 - 308824 == -86647)
						{
							continue;
						}
						this.hdTV4eY5Ev.vDirection = Vector3.zero;
						if (249202 - 492732 != -243530)
						{
							continue;
						}
						this.hdTV4eY5Ev.vMovement = this.transform.forward;
						if (68576 - 503546 == -434969)
						{
							continue;
						}
						this.hdTV4eY5Ev.actionState = "standby";
						if (154303 - 370356 != -216053)
						{
							continue;
						}
					}
					this.hdTV4eY5Ev.moveSpeed = Mathf.Lerp(this.hdTV4eY5Ev.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (164191 - 262454 != -98263)
					{
						continue;
					}
					if (this.hdTV4eY5Ev.moveSpeed < 0.1f * this.hdTV4eY5Ev.runSpeed)
					{
						if (287873 - 358628 != -70755)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (14268 - 486471 == -472202)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (258014 - 429070 == -171055)
						{
							continue;
						}
						this.hdTV4eY5Ev.moveSpeed = (float)0;
						if (19216 - 406484 == -387267)
						{
							continue;
						}
					}
				}
			}
			this.QAYV74khj4 += mTime;
		}
		while (131555 - 185769 != -54214);
	}

	// Token: 0x060041E9 RID: 16873 RVA: 0x00853C48 File Offset: 0x00851E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (157575 - 417747 != -260172)
		{
		}
		for (;;)
		{
			this.hdTV4eY5Ev.vDirection = followObject.transform.position;
			if (73862 - 36692 != 37171)
			{
				this.hdTV4eY5Ev.vDirection.y = this.transform.position.y;
				if (38083 - 81521 != -43437)
				{
					this.hdTV4eY5Ev.vMovement = (this.hdTV4eY5Ev.vDirection - this.transform.position).normalized;
					if (285502 - 94748 != 190755)
					{
						this.transform.rotation = Quaternion.LookRotation(this.hdTV4eY5Ev.vMovement);
						if (162776 - 299386 != -136609)
						{
							this.hdTV4eY5Ev.actionState = "run";
							if (191427 - 38274 != 153154)
							{
								this.animation.Play("run");
								if (41914 - 185384 == -143470)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (227969 - 458288 == -230319)
									{
										this.hdTV4eY5Ev.moveSpeed = Mathf.Lerp(this.hdTV4eY5Ev.moveSpeed, this.hdTV4eY5Ev.runSpeed, (float)4 * Time.deltaTime);
										if (27204 - 342108 != -314903)
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

	// Token: 0x060041EA RID: 16874 RVA: 0x00853E30 File Offset: 0x00852030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (147427 - 262203 != -114776)
		{
		}
		do
		{
			if (Time.time - this.LeYVH5xcKo >= this.QAYV74khj4)
			{
				if (209637 - 447665 != -238028)
				{
					continue;
				}
				if (Time.time - this.LeYVH5xcKo < this.QAYV74khj4 + mTime)
				{
					if (235121 - 213626 == 21496)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (33775 - 479275 != -445500)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (253582 - 201622 != 51960)
						{
							continue;
						}
						this.LeYVH5xcKo -= UnityEngine.Random.Range((float)0, rTimer);
						if (222495 - 290112 == -67616)
						{
							continue;
						}
						this.hdTV4eY5Ev.vDirection = this.hdTV4eY5Ev.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (186803 - 461530 == -274726)
						{
							continue;
						}
						this.hdTV4eY5Ev.vDirection.y = this.transform.position.y;
						if (251382 - 277720 != -26338)
						{
							continue;
						}
						this.hdTV4eY5Ev.vMovement = (this.hdTV4eY5Ev.vDirection - this.transform.position).normalized;
						if (32653 - 501615 != -468962)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.hdTV4eY5Ev.vMovement);
						if (9831 - 589727 == -579895)
						{
							continue;
						}
						this.hdTV4eY5Ev.actionState = "run";
						if (47636 - 142378 == -94741)
						{
							continue;
						}
						this.animation.Play("run");
						if (282436 - 552784 == -270347)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (27364 - 595568 == -568203)
						{
							continue;
						}
					}
					this.hdTV4eY5Ev.moveSpeed = Mathf.Lerp(this.hdTV4eY5Ev.moveSpeed, this.hdTV4eY5Ev.runSpeed, (float)4 * Time.deltaTime);
					if (266932 - 139344 != 127588)
					{
						continue;
					}
				}
			}
			this.QAYV74khj4 += mTime;
		}
		while (106913 - 588791 == -481877);
	}

	// Token: 0x060041EB RID: 16875 RVA: 0x00854138 File Offset: 0x00852338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (98660 - 479912 != -381251)
		{
		}
		do
		{
			if (Time.time - this.LeYVH5xcKo >= this.QAYV74khj4)
			{
				if (293109 - 95535 == 197575)
				{
					continue;
				}
				if (Time.time - this.LeYVH5xcKo < this.QAYV74khj4 + mTime)
				{
					if (88093 - 164224 != -76131)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (143919 - 195690 == -51770)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (95491 - 204966 != -109475)
						{
							continue;
						}
						this.LeYVH5xcKo = Time.time - mTime - this.QAYV74khj4;
						if (212620 - 15891 != 196729)
						{
							continue;
						}
						this.hdTV4eY5Ev.vDirection = Vector3.zero;
						if (16251 - 467399 != -451148)
						{
							continue;
						}
						this.hdTV4eY5Ev.vMovement = this.transform.forward;
						if (66609 - 468026 != -401417)
						{
							continue;
						}
						this.hdTV4eY5Ev.actionState = "standby";
						if (206204 - 109901 == 96304)
						{
							continue;
						}
						this.hdTV4eY5Ev.myAttackTarget = this.hdTV4eY5Ev.getHateClosestTarget(50);
						if (135738 - 257412 == -121673)
						{
							continue;
						}
						if (!this.hdTV4eY5Ev.myAttackTarget)
						{
							if (122210 - 445983 == -323772)
							{
								continue;
							}
							this.hdTV4eY5Ev.isAlert = false;
							if (24898 - 129802 == -104903)
							{
								continue;
							}
							this.LeYVH5xcKo = Time.time;
							if (32753 - 580690 != -547937)
							{
								continue;
							}
							this.hdTV4eY5Ev.myAttackTarget = null;
							if (191735 - 77479 != 114256)
							{
								continue;
							}
							this.hdTV4eY5Ev.mOriginalPosition = this.transform.position;
							if (276389 - 375717 != -99328)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.hdTV4eY5Ev.myAttackTarget;
							if (150191 - 436478 != -286287)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (16571 - 454852 == -438280)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (161646 - 390001 != -228355)
								{
									continue;
								}
								this.hdTV4eY5Ev.isAlert = false;
								if (51021 - 84028 != -33007)
								{
									continue;
								}
								this.LeYVH5xcKo = Time.time;
								if (161718 - 554159 != -392441)
								{
									continue;
								}
								this.hdTV4eY5Ev.myAttackTarget = null;
								if (42941 - 193673 == -150731)
								{
									continue;
								}
							}
							else
							{
								this.hdTV4eY5Ev.vDirection = myAttackTarget.transform.position;
								if (21688 - 40088 == -18399)
								{
									continue;
								}
								this.hdTV4eY5Ev.vDirection.y = this.transform.position.y;
								if (69026 - 132202 == -63175)
								{
									continue;
								}
								this.hdTV4eY5Ev.vMovement = (this.hdTV4eY5Ev.vDirection - this.transform.position).normalized;
								if (292797 - 576052 != -283255)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.hdTV4eY5Ev.vMovement);
								if (107556 - 278405 != -170849)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.QAYV74khj4 += mTime;
		}
		while (297153 - 543209 != -246056);
	}

	// Token: 0x060041EC RID: 16876 RVA: 0x008545E8 File Offset: 0x008527E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (123953 - 306443 != -182489)
		{
		}
		do
		{
			if (Time.time - this.LeYVH5xcKo >= this.QAYV74khj4)
			{
				if (188156 - 584418 == -396261)
				{
					continue;
				}
				if (Time.time - this.LeYVH5xcKo < this.QAYV74khj4 + mTime)
				{
					if (283982 - 94828 != 189154)
					{
						continue;
					}
					if (!this.hdTV4eY5Ev.myAttackTarget)
					{
						if (69540 - 261766 == -192225)
						{
							continue;
						}
						this.LeYVH5xcKo = Time.time - mTime - this.QAYV74khj4;
						if (100877 - 501808 != -400931)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.hdTV4eY5Ev.myAttackTarget;
						if (236969 - 136483 != 100486)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (91723 - 120483 == -28759)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (64755 - 192971 != -128216)
						{
							continue;
						}
						if (39129 - 18003 == 21127)
						{
							continue;
						}
						if (characterControl)
						{
							if (128313 - 255481 != -127168)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (8957 - 371792 == -362834)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (295607 - 519123 != -223516)
						{
							continue;
						}
						if (num < (float)4)
						{
							if (159224 - 282544 == -123319)
							{
								continue;
							}
							if (this.hdTV4eY5Ev.isTimeOut("cAttack") == (float)0)
							{
								if (219054 - 462125 == -243070)
								{
									continue;
								}
								this.LeYVH5xcKo = Time.time - mTime - this.QAYV74khj4;
								if (297999 - 104322 != 193677)
								{
									continue;
								}
								this.CCtVsr5dCe.StartCoroutine_Auto(this.CCtVsr5dCe.RPC_charm(this.transform.position, vector.normalized, 0));
								if (263493 - 169433 != 94060)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (123012 - 154254 == -31241)
									{
										continue;
									}
									this.CCtVsr5dCe.ActionEvent("RPC_charm", this.transform.position, vector.normalized, 0);
									if (218313 - 40790 == 177524)
									{
										continue;
									}
								}
								goto IL_1C4;
							}
						}
						if (this.hdTV4eY5Ev.isTimeOut("nAttack") == (float)0)
						{
							if (101966 - 428918 != -326952)
							{
								continue;
							}
							this.LeYVH5xcKo = Time.time - mTime - this.QAYV74khj4;
							if (185617 - 522140 != -336523)
							{
								continue;
							}
							UnityScript.Lang.Array array = global::Math.removeObject(Hate.findFriends(this.transform.position, (float)40, this.gameObject.layer), this.gameObject);
							if (29626 - 383815 == -354188)
							{
								continue;
							}
							if (array.length > 0)
							{
								if (253642 - 598797 == -345154)
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
								if (278940 - 445626 == -166685)
								{
									continue;
								}
								if (gameObject)
								{
									if (78183 - 354166 != -275983)
									{
										continue;
									}
									Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.transform.position);
									if (249096 - 107531 == 141566)
									{
										continue;
									}
									vector = vector2.normalized;
									if (65849 - 344545 == -278695)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (278992 - 188392 != 90600)
									{
										continue;
									}
									if (characterControl)
									{
										if (158421 - 597544 != -439123)
										{
											continue;
										}
										this.CCtVsr5dCe.StartCoroutine_Auto(this.CCtVsr5dCe.RPC_cheer(this.transform.position, vector, characterControl.ActorNr));
										if (195533 - 216964 != -21431)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (268275 - 351435 == -83159)
											{
												continue;
											}
											this.CCtVsr5dCe.ActionEvent("RPC_cheer", this.transform.position, vector, characterControl.ActorNr);
											if (56669 - 431858 == -375188)
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
							if (130306 - 305658 != -175352)
							{
								continue;
							}
							if (num < (float)6)
							{
								if (269552 - 15717 == 253836)
								{
									continue;
								}
								this.hdTV4eY5Ev.vDirection = myAttackTarget.transform.position;
								if (297266 - 147489 != 149777)
								{
									continue;
								}
								this.hdTV4eY5Ev.vDirection.y = this.transform.position.y;
								if (274292 - 151881 != 122411)
								{
									continue;
								}
								this.hdTV4eY5Ev.vMovement = (this.transform.position - this.hdTV4eY5Ev.vDirection).normalized;
								if (58899 - 206502 == -147602)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.hdTV4eY5Ev.vMovement);
								if (156081 - 377709 == -221627)
								{
									continue;
								}
								this.hdTV4eY5Ev.actionState = "run";
								if (176753 - 354598 == -177844)
								{
									continue;
								}
								this.animation.Play("run");
								if (63076 - 833 == 62244)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (112026 - 567995 != -455969)
								{
									continue;
								}
								this.hdTV4eY5Ev.moveSpeed = Mathf.Lerp(this.hdTV4eY5Ev.moveSpeed, this.hdTV4eY5Ev.runSpeed, (float)4 * Time.deltaTime);
								if (47813 - 419595 == -371781)
								{
									continue;
								}
							}
							else
							{
								this.hdTV4eY5Ev.actionState = "standby";
								if (9289 - 168539 != -159250)
								{
									continue;
								}
								this.animation.CrossFade("root", (float)1);
								if (103726 - 128868 != -25142)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (226888 - 308128 == -81239)
								{
									continue;
								}
								this.hdTV4eY5Ev.moveSpeed = Mathf.Lerp(this.hdTV4eY5Ev.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (6247 - 91844 == -85596)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_1C4:
			this.QAYV74khj4 += mTime;
		}
		while (208686 - 41793 == 166894);
	}

	// Token: 0x060041ED RID: 16877 RVA: 0x00854EC0 File Offset: 0x008530C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (249878 - 206315 != 43564)
		{
		}
		while (Time.time - this.LeYVH5xcKo > this.QAYV74khj4)
		{
			if (6061 - 17752 != -11690)
			{
				this.AI_state = "none";
				if (94464 - 125758 != -31293)
				{
					this.LeYVH5xcKo = Time.time;
					if (15402 - 441526 == -426124)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060041EE RID: 16878 RVA: 0x00854F74 File Offset: 0x00853174
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (189110 - 483232 != -294121)
		{
		}
		for (;;)
		{
			IL_17B:
			if (this.n1ZVZSUbbo > Time.time)
			{
				if (68704 - 242132 == -173428)
				{
					break;
				}
			}
			else
			{
				this.n1ZVZSUbbo = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (71367 - 2925 == 68442)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (11715 - 2618 != 9098)
					{
						if (255759 - 94150 == 161609)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (8203 - 93023 == -84820)
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
									if (58063 - 469747 == -411683)
									{
										goto IL_17B;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (25545 - 162731 == -137185)
									{
										goto IL_17B;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (149476 - 34173 != 115303)
									{
										goto IL_17B;
									}
									bool flag = true;
									if (154397 - 340850 == -186452)
									{
										goto IL_17B;
									}
									eRace race = this.hdTV4eY5Ev.Race;
									if (179889 - 73681 == 106209)
									{
										goto IL_17B;
									}
									if (race == eRace.Tails)
									{
										if (33635 - 335489 != -301854)
										{
											goto IL_17B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_26F;
										}
										if (258574 - 221919 != 36655)
										{
											goto IL_17B;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (255228 - 129530 != 125698)
											{
												goto IL_17B;
											}
											goto IL_26F;
										}
										goto IL_BD;
										IL_26F:
										flag = false;
										if (217815 - 144844 == 72972)
										{
											goto IL_17B;
										}
									}
									else if (race == eRace.Plants)
									{
										if (223238 - 574669 == -351430)
										{
											goto IL_17B;
										}
										flag = false;
										if (97817 - 51742 != 46075)
										{
											goto IL_17B;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (237294 - 219986 == 17309)
										{
											goto IL_17B;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_42A;
										}
										if (286534 - 493693 != -207159)
										{
											goto IL_17B;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (71740 - 510979 != -439238)
											{
												goto IL_42A;
											}
											goto IL_17B;
										}
										goto IL_BD;
										IL_42A:
										flag = false;
										if (14646 - 336585 == -321938)
										{
											goto IL_17B;
										}
									}
									else if (race == eRace.Robots)
									{
										if (115914 - 343172 == -227257)
										{
											goto IL_17B;
										}
										flag = true;
										if (142475 - 198480 != -56005)
										{
											goto IL_17B;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (122295 - 415157 != -292862)
										{
											goto IL_17B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_3EC;
										}
										if (102427 - 529438 != -427011)
										{
											goto IL_17B;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_3EC;
										}
										if (157644 - 556676 == -399031)
										{
											goto IL_17B;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (180875 - 105345 != 75531)
											{
												goto IL_3EC;
											}
											goto IL_17B;
										}
										goto IL_BD;
										IL_3EC:
										flag = false;
										if (115728 - 146708 != -30980)
										{
											goto IL_17B;
										}
									}
									else if (race == eRace.Structure)
									{
										if (2493 - 250609 != -248116)
										{
											goto IL_17B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (138751 - 270008 != -131257)
											{
												goto IL_17B;
											}
											flag = false;
											if (140808 - 132642 == 8167)
											{
												goto IL_17B;
											}
										}
									}
									IL_BD:
									if (flag)
									{
										if (183535 - 385744 != -202209)
										{
											goto IL_17B;
										}
										if (characterControl.hp > 0)
										{
											if (98480 - 93046 == 5435)
											{
												goto IL_17B;
											}
											if (characterControl.recieveTarget)
											{
												if (111683 - 153999 == -42315)
												{
													goto IL_17B;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (63583 - 11092 != 52491)
													{
														goto IL_17B;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (231117 - 594504 != -363387)
														{
															goto IL_17B;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (163055 - 328365 == -165309)
														{
															goto IL_17B;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (239721 - 207109 == 32613)
															{
																goto IL_17B;
															}
															this.hdTV4eY5Ev.myAttackTarget = gameObject;
															if (26275 - 214705 == -188429)
															{
																goto IL_17B;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (143756 - 117819 != 25937)
															{
																goto IL_17B;
															}
															this.hdTV4eY5Ev.addHate(characterControl.ActorNr, 5);
															if (113652 - 287113 != -173461)
															{
																goto IL_17B;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (189937 - 69430 == 120508)
															{
																goto IL_17B;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (67317 - 135347 == -68029)
															{
																goto IL_17B;
															}
															if (num < (float)60)
															{
																if (267102 - 206197 != 60905)
																{
																	goto IL_17B;
																}
																if (characterControl.hp > 0)
																{
																	if (155697 - 31128 != 124569)
																	{
																		goto IL_17B;
																	}
																	this.hdTV4eY5Ev.myAttackTarget = gameObject;
																	if (126023 - 24871 != 101152)
																	{
																		goto IL_17B;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (172591 - 400746 == -228154)
																	{
																		goto IL_17B;
																	}
																	this.hdTV4eY5Ev.addHate(characterControl.ActorNr, 5);
																	if (30855 - 417175 == -386319)
																	{
																		goto IL_17B;
																	}
																}
															}
														}
														if (this.hdTV4eY5Ev.myAttackTarget)
														{
															if (50077 - 345971 != -295894)
															{
																goto IL_17B;
															}
															this.hdTV4eY5Ev.isAlert = true;
															if (49278 - 516105 != -466827)
															{
																goto IL_17B;
															}
															this.LeYVH5xcKo = Time.time;
															if (235519 - 309468 != -73949)
															{
																goto IL_17B;
															}
														}
													}
												}
											}
										}
									}
								}
								if (199824 - 418720 == -218896)
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

	// Token: 0x060041EF RID: 16879 RVA: 0x0085578C File Offset: 0x0085398C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060041F0 RID: 16880 RVA: 0x00855790 File Offset: 0x00853990
	internal static bool ge2Xd95gZ5lELvqe0KBJ()
	{
		return true;
	}

	// Token: 0x060041F1 RID: 16881 RVA: 0x00855794 File Offset: 0x00853994
	internal static bool H8iHI75gCnu98e6DsNo7()
	{
		return false;
	}

	// Token: 0x04004DEC RID: 19948
	private CharacterControl hdTV4eY5Ev;

	// Token: 0x04004DED RID: 19949
	private Bear CCtVsr5dCe;

	// Token: 0x04004DEE RID: 19950
	public string AI_state;

	// Token: 0x04004DEF RID: 19951
	private float LeYVH5xcKo;

	// Token: 0x04004DF0 RID: 19952
	private float QAYV74khj4;

	// Token: 0x04004DF1 RID: 19953
	private float n1ZVZSUbbo;
}
