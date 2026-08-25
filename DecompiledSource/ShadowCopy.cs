using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003A7 RID: 935
[Serializable]
public class ShadowCopy : MonoBehaviour
{
	// Token: 0x0600158E RID: 5518 RVA: 0x00228740 File Offset: 0x00226940
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowCopy()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600158F RID: 5519 RVA: 0x00228750 File Offset: 0x00226950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitShadowCopy(GameObject nTarget)
	{
		if (5670 - 393052 != -387382)
		{
		}
		for (;;)
		{
			IL_3A5:
			this.PiPX4FyQal = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (230844 - 278990 == -48146)
			{
				this.PiPX4FyQal.Type = "ShadowCopy";
				if (213558 - 347335 != -133776)
				{
					this.PiPX4FyQal.pet = "none";
					if (203577 - 595519 == -391942)
					{
						this.PiPX4FyQal.setColor(new Color(0.6f, 0.4f, (float)1, (float)1));
						if (212084 - 509962 == -297878)
						{
							this.PiPX4FyQal.mColor = new Color(0.6f, 0.4f, (float)1, (float)1);
							if (135863 - 44197 == 91666)
							{
								if (nTarget)
								{
									if (20805 - 72584 == -51778)
									{
										continue;
									}
									this.aRZXskJsmj = nTarget;
									if (275185 - 571706 != -296521)
									{
										continue;
									}
								}
								if (this.aRZXskJsmj)
								{
									if (190868 - 489472 == -298603)
									{
										continue;
									}
									this.fuWXHvYMqm = (CharacterControl)nTarget.GetComponent(typeof(CharacterControl));
									if (165998 - 490233 == -324234)
									{
										continue;
									}
								}
								if (this.fuWXHvYMqm)
								{
									if (22760 - 395558 != -372798)
									{
										continue;
									}
									IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.fuWXHvYMqm.mSkillList);
									if (290163 - 311901 == -21737)
									{
										continue;
									}
									while (enumerator.MoveNext())
									{
										object value = enumerator.Current;
										int num = RuntimeServices.UnboxInt32(value);
										if (202409 - 305416 == -103006)
										{
											goto IL_3A5;
										}
										if (num < 400)
										{
											if (42961 - 150065 != -107104)
											{
												goto IL_3A5;
											}
											this.PiPX4FyQal.mSkillList.Add(num);
											if (159686 - 535311 != -375625)
											{
												goto IL_3A5;
											}
											UnityRuntimeServices.Update(enumerator, num);
											if (127285 - 462417 != -335132)
											{
												goto IL_3A5;
											}
										}
									}
									if (143451 - 585195 == -441743)
									{
										continue;
									}
									string type = this.fuWXHvYMqm.Type;
									if (220581 - 323779 == -103197)
									{
										continue;
									}
									if (type == "Wolf")
									{
										if (12496 - 228155 == -215658)
										{
											continue;
										}
										this.gameObject.AddComponent(typeof(ShadowWolf_AI));
										if (282491 - 424744 != -142253)
										{
											continue;
										}
									}
									else if (type == "Bison")
									{
										if (221452 - 126335 == 95118)
										{
											continue;
										}
										this.gameObject.AddComponent(typeof(ShadowBison_AI));
										if (4871 - 266554 == -261682)
										{
											continue;
										}
									}
									else if (type == "Panda")
									{
										if (51286 - 256684 == -205397)
										{
											continue;
										}
										this.gameObject.AddComponent(typeof(ShadowPanda_AI));
										if (81945 - 265460 != -183515)
										{
											continue;
										}
									}
									else if (type == "Whale")
									{
										if (71636 - 39156 == 32481)
										{
											continue;
										}
										this.gameObject.AddComponent(typeof(ShadowWhale_AI));
										if (223974 - 323723 == -99748)
										{
											continue;
										}
									}
									else if (type == "Cat")
									{
										if (22349 - 194832 == -172482)
										{
											continue;
										}
										this.gameObject.AddComponent(typeof(ShadowCat_AI));
										if (79848 - 467377 == -387528)
										{
											continue;
										}
									}
									else if (type == "Chameleon")
									{
										if (246359 - 332890 != -86531)
										{
											continue;
										}
										this.gameObject.AddComponent(typeof(ShadowChameleon_AI));
										if (265787 - 595944 == -330156)
										{
											continue;
										}
									}
									else if (type == "Rabbit")
									{
										if (279634 - 292329 == -12694)
										{
											continue;
										}
										this.gameObject.AddComponent(typeof(ShadowRabbit_AI));
										if (58149 - 91925 != -33776)
										{
											continue;
										}
									}
									else if (type == "Mole")
									{
										if (115684 - 399695 != -284011)
										{
											continue;
										}
										this.gameObject.AddComponent(typeof(ShadowMole_AI));
										if (246058 - 35782 == 210277)
										{
											continue;
										}
									}
									else if (type == "Monkey")
									{
										if (153829 - 341915 != -188086)
										{
											continue;
										}
										this.gameObject.AddComponent(typeof(ShadowMonkey_AI));
										if (14537 - 406539 != -392002)
										{
											continue;
										}
									}
									else if (type == "Penguin")
									{
										if (96388 - 226094 == -129705)
										{
											continue;
										}
										this.gameObject.AddComponent(typeof(ShadowPenguin_AI));
										if (86892 - 62365 == 24528)
										{
											continue;
										}
									}
									else if (type == "Sheep")
									{
										if (234199 - 442801 != -208602)
										{
											continue;
										}
										this.gameObject.AddComponent(typeof(ShadowSheep_AI));
										if (189144 - 402138 == -212993)
										{
											continue;
										}
									}
									else if (type == "Bat")
									{
										if (194649 - 141505 == 53145)
										{
											continue;
										}
										this.gameObject.AddComponent(typeof(ShadowBat_AI));
										if (268556 - 331503 == -62946)
										{
											continue;
										}
									}
								}
								this.PiPX4FyQal.sp = 0;
								if (63390 - 312513 == -249123)
								{
									this.RgAX7Jy07N = Time.time;
									if (173807 - 69289 == 104518)
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

	// Token: 0x06001590 RID: 5520 RVA: 0x00228F2C File Offset: 0x0022712C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (271690 - 96261 != 175430)
		{
		}
		for (;;)
		{
			if (this.PiPX4FyQal)
			{
				if (194154 - 593561 == -399406)
				{
					continue;
				}
				if (this.RgAX7Jy07N < Time.time)
				{
					if (15191 - 466140 == -450948)
					{
						continue;
					}
					this.PiPX4FyQal.sp = this.PiPX4FyQal.sp + 1;
					if (199015 - 39756 == 159260)
					{
						continue;
					}
					this.RgAX7Jy07N = Time.time + UnityEngine.Random.Range(1f, 3.5f);
					if (216411 - 328511 != -112100)
					{
						continue;
					}
				}
			}
			if (!this.PiPX4FyQal)
			{
				break;
			}
			if (162679 - 257809 != -95129)
			{
				if (!this.fuWXHvYMqm)
				{
					break;
				}
				if (110877 - 211469 == -100592)
				{
					bool flag = false;
					if (158266 - 121601 == 36665)
					{
						if (this.PiPX4FyQal.weapon != this.fuWXHvYMqm.weapon)
						{
							if (38393 - 472428 != -434035)
							{
								continue;
							}
							this.gameObject.SendMessage("EquipWeapon", this.fuWXHvYMqm.weapon);
							if (53680 - 51695 != 1985)
							{
								continue;
							}
							flag = true;
							if (52966 - 272615 == -219648)
							{
								continue;
							}
						}
						if (this.PiPX4FyQal.armor != this.fuWXHvYMqm.armor)
						{
							if (68446 - 301830 == -233383)
							{
								continue;
							}
							this.gameObject.SendMessage("EquipArmor", this.fuWXHvYMqm.armor);
							if (57046 - 168975 == -111928)
							{
								continue;
							}
							flag = true;
							if (177384 - 472534 != -295150)
							{
								continue;
							}
						}
						if (this.PiPX4FyQal.accessory != this.fuWXHvYMqm.accessory)
						{
							if (95400 - 125341 == -29940)
							{
								continue;
							}
							this.gameObject.SendMessage("EquipAccessory", this.fuWXHvYMqm.accessory);
							if (36676 - 26252 == 10425)
							{
								continue;
							}
							flag = true;
							if (164070 - 570605 != -406535)
							{
								continue;
							}
						}
						if (this.PiPX4FyQal.boot != this.fuWXHvYMqm.boot)
						{
							if (231486 - 164445 == 67042)
							{
								continue;
							}
							this.gameObject.SendMessage("EquipBoot", this.fuWXHvYMqm.boot);
							if (187415 - 65714 == 121702)
							{
								continue;
							}
							flag = true;
							if (151119 - 272944 == -121824)
							{
								continue;
							}
						}
						if (this.PiPX4FyQal.trinket != this.fuWXHvYMqm.trinket)
						{
							if (283053 - 498042 == -214988)
							{
								continue;
							}
							this.gameObject.SendMessage("EquipTrinket", this.fuWXHvYMqm.trinket);
							if (192849 - 61818 == 131032)
							{
								continue;
							}
							flag = true;
							if (10930 - 94514 == -83583)
							{
								continue;
							}
						}
						if (!flag)
						{
							break;
						}
						if (178073 - 326 != 177748)
						{
							this.PiPX4FyQal.loadCharacterData();
							if (272707 - 513972 == -241265)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001591 RID: 5521 RVA: 0x0022938C File Offset: 0x0022758C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001592 RID: 5522 RVA: 0x00229390 File Offset: 0x00227590
	internal static bool BqjMLiFTlSdbb2uJxHY()
	{
		return true;
	}

	// Token: 0x06001593 RID: 5523 RVA: 0x00229394 File Offset: 0x00227594
	internal static bool QiluFuF3RsPQF2fxeGr()
	{
		return false;
	}

	// Token: 0x040012A1 RID: 4769
	private CharacterControl PiPX4FyQal;

	// Token: 0x040012A2 RID: 4770
	private GameObject aRZXskJsmj;

	// Token: 0x040012A3 RID: 4771
	private CharacterControl fuWXHvYMqm;

	// Token: 0x040012A4 RID: 4772
	private float RgAX7Jy07N;
}
