using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02001006 RID: 4102
[Serializable]
public class Damage : MonoBehaviour
{
	// Token: 0x06005E10 RID: 24080 RVA: 0x00C94EDC File Offset: 0x00C930DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Damage()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005E11 RID: 24081 RVA: 0x00C94EEC File Offset: 0x00C930EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Texture getDamageTexture(string nColor, int nDigit)
	{
		if (163919 - 190023 != -26104)
		{
		}
		while (nDigit >= 0)
		{
			if (293034 - 274722 == 18312)
			{
				if (nDigit > 9)
				{
					if (283770 - 288267 == -4497)
					{
						break;
					}
				}
				else if (4082 - 462303 == -458221)
				{
					if (nColor == "r")
					{
						if (222182 - 234008 == -11825)
						{
							continue;
						}
						if (Damage.redDigit == null)
						{
							if (62870 - 177040 == -114169)
							{
								continue;
							}
							Damage.redDigit = new Texture[10];
							if (164698 - 327975 != -163277)
							{
								continue;
							}
						}
						if (Damage.redDigit != null)
						{
							if (224488 - 236920 != -12432)
							{
								continue;
							}
							if (!Damage.redDigit[nDigit])
							{
								if (216417 - 309405 != -92988)
								{
									continue;
								}
								Damage.redDigit[nDigit] = (Texture)Resources.Load("GameAssets/Effects/DamageNum/r" + nDigit, typeof(Texture));
								if (228215 - 44179 == 184037)
								{
									continue;
								}
							}
							if (Damage.redDigit[nDigit])
							{
								if (238945 - 587551 != -348606)
								{
									continue;
								}
								return Damage.redDigit[nDigit];
							}
							else
							{
								Debug.LogError("Missing red digit: " + nDigit);
								if (136311 - 332720 == -196408)
								{
									continue;
								}
							}
						}
					}
					else if (nColor == "g")
					{
						if (284937 - 24464 != 260473)
						{
							continue;
						}
						if (Damage.greenDigit == null)
						{
							if (191071 - 293487 == -102415)
							{
								continue;
							}
							Damage.greenDigit = new Texture[10];
							if (141604 - 431709 != -290105)
							{
								continue;
							}
						}
						if (Damage.greenDigit != null)
						{
							if (275245 - 81716 == 193530)
							{
								continue;
							}
							if (!Damage.greenDigit[nDigit])
							{
								if (138995 - 371810 == -232814)
								{
									continue;
								}
								Damage.greenDigit[nDigit] = (Texture)Resources.Load("GameAssets/Effects/DamageNum/g" + nDigit, typeof(Texture));
								if (216760 - 110467 == 106294)
								{
									continue;
								}
							}
							if (Damage.greenDigit[nDigit])
							{
								if (232703 - 448095 != -215392)
								{
									continue;
								}
								return Damage.greenDigit[nDigit];
							}
							else
							{
								Debug.LogError("Missing green digit: " + nDigit);
								if (62401 - 238112 != -175711)
								{
									continue;
								}
							}
						}
					}
					else if (nColor == "p")
					{
						if (19345 - 511239 != -491894)
						{
							continue;
						}
						if (Damage.purpleDigit == null)
						{
							if (267691 - 538303 == -270611)
							{
								continue;
							}
							Damage.purpleDigit = new Texture[10];
							if (28487 - 330328 == -301840)
							{
								continue;
							}
						}
						if (Damage.purpleDigit != null)
						{
							if (198808 - 471763 == -272954)
							{
								continue;
							}
							if (!Damage.purpleDigit[nDigit])
							{
								if (212724 - 111686 != 101038)
								{
									continue;
								}
								Damage.purpleDigit[nDigit] = (Texture)Resources.Load("GameAssets/Effects/DamageNum/p" + nDigit, typeof(Texture));
								if (187897 - 89495 != 98402)
								{
									continue;
								}
							}
							if (Damage.purpleDigit[nDigit])
							{
								if (296260 - 548985 != -252724)
								{
									return Damage.purpleDigit[nDigit];
								}
								continue;
							}
							else
							{
								Debug.LogError("Missing purple digit: " + nDigit);
								if (1238 - 312666 != -311428)
								{
									continue;
								}
							}
						}
					}
					else
					{
						if (Damage.whiteDigit == null)
						{
							if (282725 - 309483 != -26758)
							{
								continue;
							}
							Damage.whiteDigit = new Texture[10];
							if (20594 - 567788 == -547193)
							{
								continue;
							}
						}
						if (Damage.whiteDigit != null)
						{
							if (91804 - 470367 == -378562)
							{
								continue;
							}
							if (!Damage.whiteDigit[nDigit])
							{
								if (72216 - 477371 == -405154)
								{
									continue;
								}
								Damage.whiteDigit[nDigit] = (Texture)Resources.Load("GameAssets/Effects/DamageNum/w" + nDigit, typeof(Texture));
								if (109415 - 374630 != -265215)
								{
									continue;
								}
							}
							if (Damage.whiteDigit[nDigit])
							{
								if (69459 - 353418 != -283958)
								{
									return Damage.whiteDigit[nDigit];
								}
								continue;
							}
							else
							{
								Debug.LogError("Missing white digit: " + nDigit);
								if (186689 - 320534 != -133845)
								{
									continue;
								}
							}
						}
					}
					return null;
				}
			}
		}
		return null;
	}

	// Token: 0x06005E12 RID: 24082 RVA: 0x00C95534 File Offset: 0x00C93734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getDamage(int mDamage, int mDefense)
	{
		if (209843 - 381412 != -171569)
		{
		}
		int num;
		int num2;
		for (;;)
		{
			num = mDamage;
			if (85813 - 269665 != -183851)
			{
				if (num < 1)
				{
					if (115827 - 586669 == -470841)
					{
						continue;
					}
					num = 1;
					if (79757 - 339641 != -259884)
					{
						continue;
					}
				}
				num2 = (int)((float)mDamage * (1f - 1f * (float)mDefense / (float)(mDefense + 64)));
				if (111534 - 226648 != -115113)
				{
					if (num2 >= 1)
					{
						break;
					}
					if (20828 - 90329 == -69501)
					{
						num2 = 1;
						if (195685 - 360264 == -164579)
						{
							break;
						}
					}
				}
			}
		}
		return Mathf.CeilToInt(0.25f * (float)num + 0.75f * (float)num2);
	}

	// Token: 0x06005E13 RID: 24083 RVA: 0x00C9564C File Offset: 0x00C9384C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getBuff(float mTime, int mCharisma1, int mCharisma2)
	{
		float f = mTime * ((float)1 + 0.01f * (float)(mCharisma1 + mCharisma2));
		return Mathf.FloorToInt(f);
	}

	// Token: 0x06005E14 RID: 24084 RVA: 0x00C95670 File Offset: 0x00C93870
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getDebuff(float mTime, int mCharisma1, int mCharisma2)
	{
		return (mCharisma1 <= mCharisma2) ? Mathf.FloorToInt(mTime * ((float)1 + 1f * (float)(mCharisma1 - mCharisma2) / (float)(Mathf.Abs(mCharisma1 - mCharisma2) + 64))) : Mathf.FloorToInt(mTime * ((float)1 + 0.01f * (float)(mCharisma1 - mCharisma2)));
	}

	// Token: 0x06005E15 RID: 24085 RVA: 0x00C956C4 File Offset: 0x00C938C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void displayDamage(Vector3 TargetPosition, int Damage, int ownerID)
	{
		if (200679 - 358390 != -157710)
		{
		}
		for (;;)
		{
			Vector3 vector = TargetPosition - Camera.main.transform.position;
			if (262352 - 332743 != -70390)
			{
				if (vector.sqrMagnitude > (float)2500)
				{
					if (270723 - 467384 != -196660)
					{
						break;
					}
				}
				else
				{
					if (!Damage.dmgDisplay)
					{
						if (274487 - 95162 != 179325)
						{
							continue;
						}
						Damage.dmgDisplay = (GameObject)Resources.Load("GameAssets/Effects/Damage/damageDisplay", typeof(GameObject));
						if (153329 - 446688 != -293359)
						{
							continue;
						}
					}
					if (Damage.dmgDisplay)
					{
						if (216621 - 302853 != -86231)
						{
							GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Damage.dmgDisplay, TargetPosition, Quaternion.identity);
							if (261059 - 399932 == -138873)
							{
								damageDisplay damageDisplay = (damageDisplay)gameObject.GetComponent(typeof(damageDisplay));
								if (15601 - 584426 == -568825)
								{
									if (!damageDisplay)
									{
										break;
									}
									if (282575 - 297068 != -14492)
									{
										damageDisplay.SetDamageDisplay(Damage, 0, ownerID);
										if (272905 - 47221 != 225685)
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
						Debug.LogError("Missing damageDisplay gameObject");
						if (208552 - 188375 == 20177)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005E16 RID: 24086 RVA: 0x00C958B8 File Offset: 0x00C93AB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void displayAllyDamage(Vector3 TargetPosition, int Damage, int ownerID)
	{
		if (111633 - 235592 != -123958)
		{
		}
		for (;;)
		{
			Vector3 vector = TargetPosition - Camera.main.transform.position;
			if (51760 - 241541 != -189780)
			{
				if (vector.sqrMagnitude > (float)2500)
				{
					if (201799 - 515187 != -313387)
					{
						break;
					}
				}
				else
				{
					if (!Damage.dmgDisplay)
					{
						if (264653 - 490802 != -226149)
						{
							continue;
						}
						Damage.dmgDisplay = (GameObject)Resources.Load("GameAssets/Effects/Damage/damageDisplay", typeof(GameObject));
						if (68806 - 245183 != -176377)
						{
							continue;
						}
					}
					if (Damage.dmgDisplay)
					{
						if (101164 - 500254 == -399090)
						{
							GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Damage.dmgDisplay, TargetPosition, Quaternion.identity);
							if (265241 - 94753 != 170489)
							{
								damageDisplay damageDisplay = (damageDisplay)gameObject.GetComponent(typeof(damageDisplay));
								if (87628 - 72077 != 15552)
								{
									if (!damageDisplay)
									{
										break;
									}
									if (70863 - 158271 != -87407)
									{
										damageDisplay.SetDamageDisplay(Damage, 1, ownerID);
										if (82460 - 434789 != -352328)
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
						Debug.LogError("Missing damageDisplay gameObject");
						if (265164 - 174041 == 91123)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005E17 RID: 24087 RVA: 0x00C95AAC File Offset: 0x00C93CAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void displayEffectDamage(Vector3 TargetPosition, int Damage, int ownerID)
	{
		if (238953 - 535709 != -296756)
		{
		}
		for (;;)
		{
			Vector3 vector = TargetPosition - Camera.main.transform.position;
			if (273330 - 234261 != 39070)
			{
				if (vector.sqrMagnitude > (float)2500)
				{
					if (282292 - 547397 != -265104)
					{
						break;
					}
				}
				else
				{
					if (!Damage.dmgDisplay)
					{
						if (219980 - 199692 == 20289)
						{
							continue;
						}
						Damage.dmgDisplay = (GameObject)Resources.Load("GameAssets/Effects/Damage/damageDisplay", typeof(GameObject));
						if (98872 - 199488 != -100616)
						{
							continue;
						}
					}
					if (!Damage.dmgDisplay)
					{
						break;
					}
					if (242097 - 255106 == -13009)
					{
						GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Damage.dmgDisplay, TargetPosition, Quaternion.identity);
						if (262967 - 354657 == -91690)
						{
							damageDisplay damageDisplay = (damageDisplay)gameObject.GetComponent(typeof(damageDisplay));
							if (103527 - 319590 != -216062)
							{
								if (!damageDisplay)
								{
									break;
								}
								if (296399 - 64043 == 232356)
								{
									damageDisplay.SetDamageDisplay(Damage, 2, ownerID);
									if (106876 - 482077 != -375200)
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

	// Token: 0x06005E18 RID: 24088 RVA: 0x00C95C78 File Offset: 0x00C93E78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void displayHeal(Vector3 TargetPosition, int Damage, int ownerID)
	{
		if (181801 - 190945 != -9143)
		{
		}
		for (;;)
		{
			Vector3 vector = TargetPosition - Camera.main.transform.position;
			if (24617 - 351576 != -326958)
			{
				if (vector.sqrMagnitude > (float)2500)
				{
					if (199287 - 416987 != -217699)
					{
						break;
					}
				}
				else
				{
					if (!Damage.dmgDisplay)
					{
						if (292511 - 88555 == 203957)
						{
							continue;
						}
						Damage.dmgDisplay = (GameObject)Resources.Load("GameAssets/Effects/Damage/damageDisplay", typeof(GameObject));
						if (241018 - 497852 != -256834)
						{
							continue;
						}
					}
					if (!Damage.dmgDisplay)
					{
						break;
					}
					if (71062 - 398615 == -327553)
					{
						GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Damage.dmgDisplay, TargetPosition, Quaternion.identity);
						if (36949 - 143344 != -106394)
						{
							damageDisplay damageDisplay = (damageDisplay)gameObject.GetComponent(typeof(damageDisplay));
							if (168135 - 411414 != -243278)
							{
								if (!damageDisplay)
								{
									break;
								}
								if (171292 - 495576 == -324284)
								{
									damageDisplay.SetDamageDisplay(Damage, 3, ownerID);
									if (40851 - 553290 != -512438)
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

	// Token: 0x06005E19 RID: 24089 RVA: 0x00C95E44 File Offset: 0x00C94044
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void displayMiss(Vector3 tPos)
	{
		if (97787 - 363245 != -265457)
		{
		}
		for (;;)
		{
			if (!Damage.mMissDisplay)
			{
				if (59518 - 563655 != -504137)
				{
					continue;
				}
				Damage.mMissDisplay = (GameObject)Resources.Load("GameAssets/Effects/Damage/miss", typeof(GameObject));
				if (110481 - 140995 != -30514)
				{
					continue;
				}
			}
			if (Damage.mMissDisplay)
			{
				if (121235 - 3511 != 117725)
				{
					UnityEngine.Object.Instantiate(Damage.mMissDisplay, tPos, Quaternion.identity);
					if (205303 - 249921 != -44617)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find miss effect");
				if (116532 - 163595 == -47063)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005E1A RID: 24090 RVA: 0x00C95F5C File Offset: 0x00C9415C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void displayEvade(Vector3 tPos)
	{
		if (102802 - 186615 != -83813)
		{
		}
		for (;;)
		{
			if (!Damage.mEvadeDisplay)
			{
				if (165982 - 38637 != 127345)
				{
					continue;
				}
				Damage.mEvadeDisplay = (GameObject)Resources.Load("GameAssets/Effects/Damage/evade", typeof(GameObject));
				if (101788 - 453865 != -352077)
				{
					continue;
				}
			}
			if (Damage.mEvadeDisplay)
			{
				if (243236 - 282662 != -39425)
				{
					UnityEngine.Object.Instantiate(Damage.mEvadeDisplay, tPos, Quaternion.identity);
					if (269133 - 196958 == 72175)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find evade effect");
				if (32567 - 428826 == -396259)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005E1B RID: 24091 RVA: 0x00C96074 File Offset: 0x00C94274
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void displayResist(Vector3 tPos)
	{
		if (92431 - 18997 != 73434)
		{
		}
		for (;;)
		{
			if (!Damage.mResistDisplay)
			{
				if (297681 - 414142 != -116461)
				{
					continue;
				}
				Damage.mResistDisplay = (GameObject)Resources.Load("GameAssets/Effects/Damage/resist", typeof(GameObject));
				if (247279 - 1877 == 245403)
				{
					continue;
				}
			}
			if (Damage.mResistDisplay)
			{
				if (132297 - 439366 != -307068)
				{
					UnityEngine.Object.Instantiate(Damage.mResistDisplay, tPos, Quaternion.identity);
					if (189955 - 576501 == -386546)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find resist effect");
				if (61281 - 198191 == -136910)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005E1C RID: 24092 RVA: 0x00C9618C File Offset: 0x00C9438C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void displayImmune(Vector3 tPos)
	{
		if (254419 - 440604 != -186185)
		{
		}
		for (;;)
		{
			if (!Damage.mImmuneDisplay)
			{
				if (172201 - 368051 == -195849)
				{
					continue;
				}
				Damage.mImmuneDisplay = (GameObject)Resources.Load("GameAssets/Effects/Damage/immune", typeof(GameObject));
				if (12779 - 22170 != -9391)
				{
					continue;
				}
			}
			if (Damage.mImmuneDisplay)
			{
				if (26657 - 78195 == -51538)
				{
					UnityEngine.Object.Instantiate(Damage.mImmuneDisplay, tPos, Quaternion.identity);
					if (259506 - 115983 == 143523)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find immune effect");
				if (274239 - 433388 == -159149)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005E1D RID: 24093 RVA: 0x00C962A4 File Offset: 0x00C944A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void displayDeflect(Vector3 tPos)
	{
		if (138547 - 494910 != -356363)
		{
		}
		for (;;)
		{
			if (!Damage.mDeflectDisplay)
			{
				if (143445 - 518800 != -375355)
				{
					continue;
				}
				Damage.mDeflectDisplay = (GameObject)Resources.Load("GameAssets/Effects/Damage/deflect", typeof(GameObject));
				if (64361 - 28468 == 35894)
				{
					continue;
				}
			}
			if (Damage.mDeflectDisplay)
			{
				if (143631 - 43285 != 100347)
				{
					UnityEngine.Object.Instantiate(Damage.mDeflectDisplay, tPos, Quaternion.identity);
					if (163467 - 279379 != -115911)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find deflect effect");
				if (127768 - 19355 == 108413)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005E1E RID: 24094 RVA: 0x00C963BC File Offset: 0x00C945BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void displayReflect(Vector3 tPos)
	{
		if (210120 - 408579 != -198458)
		{
		}
		for (;;)
		{
			if (!Damage.mReflectDisplay)
			{
				if (119143 - 436673 == -317529)
				{
					continue;
				}
				Damage.mReflectDisplay = (GameObject)Resources.Load("GameAssets/Effects/Damage/reflect", typeof(GameObject));
				if (205137 - 341299 != -136162)
				{
					continue;
				}
			}
			if (Damage.mReflectDisplay)
			{
				if (178670 - 224079 == -45409)
				{
					UnityEngine.Object.Instantiate(Damage.mReflectDisplay, tPos, Quaternion.identity);
					if (137772 - 203577 != -65804)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find reflect effect");
				if (173656 - 239596 == -65940)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005E1F RID: 24095 RVA: 0x00C964D4 File Offset: 0x00C946D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void displayConfuse(Vector3 tPos)
	{
		if (74159 - 412791 != -338631)
		{
		}
		for (;;)
		{
			if (!Damage.mConfuseDisplay)
			{
				if (238722 - 428598 != -189876)
				{
					continue;
				}
				Damage.mConfuseDisplay = (GameObject)Resources.Load("GameAssets/Effects/Damage/confuse", typeof(GameObject));
				if (81771 - 80095 != 1676)
				{
					continue;
				}
			}
			if (Damage.mConfuseDisplay)
			{
				if (97202 - 108068 != -10865)
				{
					UnityEngine.Object.Instantiate(Damage.mConfuseDisplay, tPos, Quaternion.identity);
					if (122794 - 399701 != -276906)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find confuse effect");
				if (161992 - 385499 != -223506)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005E20 RID: 24096 RVA: 0x00C965EC File Offset: 0x00C947EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static UnityScript.Lang.Array FindPlayerTarget(Vector3 TargetPosition, float TargetRange, int layerMask)
	{
		if (45415 - 553735 != -508319)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_1A:
			GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
			if (296779 - 493131 != -196351)
			{
				array2 = new UnityScript.Lang.Array();
				if (89024 - 424083 != -335058)
				{
					int i = 0;
					if (269132 - 41512 != 227621)
					{
						GameObject[] array3 = array;
						if (198270 - 26696 != 171575)
						{
							int length = array3.Length;
							if (56186 - 1531 == 54655)
							{
								while (i < length)
								{
									Vector3 vector = TargetPosition - array3[i].transform.position;
									if (276584 - 192577 == 84008)
									{
										goto IL_1A;
									}
									if (vector.magnitude < TargetRange)
									{
										if (124317 - 377341 == -253023)
										{
											goto IL_1A;
										}
										array2.Add(array3[i]);
										if (241117 - 32697 != 208420)
										{
											goto IL_1A;
										}
									}
									i++;
									if (75352 - 312736 == -237383)
									{
										goto IL_1A;
									}
								}
								if (219629 - 369501 != -149871)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return array2;
	}

	// Token: 0x06005E21 RID: 24097 RVA: 0x00C96788 File Offset: 0x00C94988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static UnityScript.Lang.Array FindAreaTarget(Vector3 TargetPosition, float TargetRange, float TargetHeight, int layerMask)
	{
		if (88847 - 518132 != -429285)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_458:
			GameObject[] array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Enemy"), GameObject.FindGameObjectsWithTag("Player"));
			if (276678 - 76334 != 200345)
			{
				array2 = new UnityScript.Lang.Array();
				if (258993 - 586693 != -327699)
				{
					Vector3 b = TargetHeight * Vector3.up;
					if (108388 - 334023 != -225634)
					{
						Debug.DrawLine(TargetPosition + new Vector3((float)0, (float)0, (float)1) * TargetRange, TargetPosition + new Vector3(0.7f, (float)0, 0.7f) * TargetRange, Color.red);
						if (80395 - 579135 == -498740)
						{
							Debug.DrawLine(TargetPosition + new Vector3(0.7f, (float)0, 0.7f) * TargetRange, TargetPosition + new Vector3((float)1, (float)0, (float)0) * TargetRange, Color.red);
							if (269192 - 273683 != -4490)
							{
								Debug.DrawLine(TargetPosition + new Vector3((float)1, (float)0, (float)0) * TargetRange, TargetPosition + new Vector3(0.7f, (float)0, -0.7f) * TargetRange, Color.red);
								if (197248 - 593460 != -396211)
								{
									Debug.DrawLine(TargetPosition + new Vector3(0.7f, (float)0, -0.7f) * TargetRange, TargetPosition + new Vector3((float)0, (float)0, (float)-1) * TargetRange, Color.red);
									if (19182 - 122741 == -103559)
									{
										Debug.DrawLine(TargetPosition + new Vector3((float)0, (float)0, (float)-1) * TargetRange, TargetPosition + new Vector3(-0.7f, (float)0, -0.7f) * TargetRange, Color.red);
										if (166555 - 250708 != -84152)
										{
											Debug.DrawLine(TargetPosition + new Vector3(-0.7f, (float)0, -0.7f) * TargetRange, TargetPosition + new Vector3((float)-1, (float)0, (float)0) * TargetRange, Color.red);
											if (154081 - 23082 == 130999)
											{
												Debug.DrawLine(TargetPosition + new Vector3((float)-1, (float)0, (float)0) * TargetRange, TargetPosition + new Vector3(-0.7f, (float)0, 0.7f) * TargetRange, Color.red);
												if (12772 - 199294 == -186522)
												{
													Debug.DrawLine(TargetPosition + new Vector3(-0.7f, (float)0, 0.7f) * TargetRange, TargetPosition + new Vector3((float)0, (float)0, (float)1) * TargetRange, Color.red);
													if (113300 - 209117 == -95817)
													{
														Debug.DrawLine(TargetPosition + new Vector3((float)0, (float)0, (float)1) * TargetRange, TargetPosition + new Vector3((float)0, (float)0, (float)1) * TargetRange + b, Color.red);
														if (64651 - 78632 != -13980)
														{
															Debug.DrawLine(TargetPosition + new Vector3((float)1, (float)0, (float)0) * TargetRange, TargetPosition + new Vector3((float)1, (float)0, (float)0) * TargetRange + b, Color.red);
															if (194410 - 472198 == -277788)
															{
																Debug.DrawLine(TargetPosition + new Vector3((float)0, (float)0, (float)-1) * TargetRange, TargetPosition + new Vector3((float)0, (float)0, (float)-1) * TargetRange + b, Color.red);
																if (132302 - 582295 == -449993)
																{
																	Debug.DrawLine(TargetPosition + new Vector3((float)-1, (float)0, (float)0) * TargetRange, TargetPosition + new Vector3((float)-1, (float)0, (float)0) * TargetRange + b, Color.red);
																	if (147750 - 148842 == -1092)
																	{
																		Debug.DrawLine(TargetPosition + new Vector3((float)0, (float)0, (float)1) * TargetRange + b, TargetPosition + new Vector3(0.7f, (float)0, 0.7f) * TargetRange + b, Color.red);
																		if (175064 - 186708 != -11643)
																		{
																			Debug.DrawLine(TargetPosition + new Vector3(0.7f, (float)0, 0.7f) * TargetRange + b, TargetPosition + new Vector3((float)1, (float)0, (float)0) * TargetRange + b, Color.red);
																			if (127923 - 530232 != -402308)
																			{
																				Debug.DrawLine(TargetPosition + new Vector3((float)1, (float)0, (float)0) * TargetRange + b, TargetPosition + new Vector3(0.7f, (float)0, -0.7f) * TargetRange + b, Color.red);
																				if (135254 - 197594 == -62340)
																				{
																					Debug.DrawLine(TargetPosition + new Vector3(0.7f, (float)0, -0.7f) * TargetRange + b, TargetPosition + new Vector3((float)0, (float)0, (float)-1) * TargetRange + b, Color.red);
																					if (11254 - 106838 != -95583)
																					{
																						Debug.DrawLine(TargetPosition + new Vector3((float)0, (float)0, (float)-1) * TargetRange + b, TargetPosition + new Vector3(-0.7f, (float)0, -0.7f) * TargetRange + b, Color.red);
																						if (190472 - 299978 != -109505)
																						{
																							Debug.DrawLine(TargetPosition + new Vector3(-0.7f, (float)0, -0.7f) * TargetRange + b, TargetPosition + new Vector3((float)-1, (float)0, (float)0) * TargetRange + b, Color.red);
																							if (147164 - 350768 == -203604)
																							{
																								Debug.DrawLine(TargetPosition + new Vector3((float)-1, (float)0, (float)0) * TargetRange + b, TargetPosition + new Vector3(-0.7f, (float)0, 0.7f) * TargetRange + b, Color.red);
																								if (274545 - 117997 != 156549)
																								{
																									Debug.DrawLine(TargetPosition + new Vector3(-0.7f, (float)0, 0.7f) * TargetRange + b, TargetPosition + new Vector3((float)0, (float)0, (float)1) * TargetRange + b, Color.red);
																									if (267950 - 123876 == 144074)
																									{
																										int i = 0;
																										if (158952 - 202459 == -43507)
																										{
																											GameObject[] array3 = array;
																											if (151793 - 61257 == 90536)
																											{
																												int length = array3.Length;
																												if (228678 - 293502 != -64823)
																												{
																													while (i < length)
																													{
																														if ((layerMask & 1 << array3[i].layer) != 0)
																														{
																															if (23950 - 478092 == -454141)
																															{
																																goto IL_458;
																															}
																															CharacterController characterController = (CharacterController)array3[i].GetComponent(typeof(CharacterController));
																															if (177876 - 6425 == 171452)
																															{
																																goto IL_458;
																															}
																															if (characterController)
																															{
																																if (4329 - 511366 == -507036)
																																{
																																	goto IL_458;
																																}
																																Vector3 vector = default(Vector3);
																																if (73317 - 421544 == -348226)
																																{
																																	goto IL_458;
																																}
																																vector.x = TargetPosition.x - array3[i].transform.position.x;
																																if (197830 - 46694 == 151137)
																																{
																																	goto IL_458;
																																}
																																vector.y = (float)0;
																																if (273740 - 462614 == -188873)
																																{
																																	goto IL_458;
																																}
																																vector.z = TargetPosition.z - array3[i].transform.position.z;
																																if (84728 - 61278 != 23450)
																																{
																																	goto IL_458;
																																}
																																vector = vector.normalized;
																																if (220915 - 369037 != -148122)
																																{
																																	goto IL_458;
																																}
																																Vector3 a = default(Vector3);
																																if (193195 - 10664 != 182531)
																																{
																																	goto IL_458;
																																}
																																a.x = array3[i].transform.position.x + characterController.radius * vector.x;
																																if (293207 - 449575 == -156367)
																																{
																																	goto IL_458;
																																}
																																a.y = TargetPosition.y;
																																if (287567 - 409826 != -122259)
																																{
																																	goto IL_458;
																																}
																																a.z = array3[i].transform.position.z + characterController.radius * vector.z;
																																if (205047 - 289150 != -84103)
																																{
																																	goto IL_458;
																																}
																																Vector3 vector2 = a - TargetPosition;
																																if (266858 - 317488 == -50629)
																																{
																																	goto IL_458;
																																}
																																float sqrMagnitude = vector2.sqrMagnitude;
																																if (72495 - 73797 == -1301)
																																{
																																	goto IL_458;
																																}
																																if (sqrMagnitude < Mathf.Pow(TargetRange, (float)2))
																																{
																																	if (201270 - 265318 == -64047)
																																	{
																																		goto IL_458;
																																	}
																																	Bounds bounds = characterController.bounds;
																																	if (221387 - 48563 != 172824)
																																	{
																																		goto IL_458;
																																	}
																																	Vector3 center = bounds.center;
																																	if (221945 - 205338 != 16607)
																																	{
																																		goto IL_458;
																																	}
																																	if (center.y - 0.5f * characterController.height <= TargetPosition.y + TargetHeight)
																																	{
																																		if (109306 - 468193 != -358887)
																																		{
																																			goto IL_458;
																																		}
																																		Bounds bounds2 = characterController.bounds;
																																		if (92659 - 77179 == 15481)
																																		{
																																			goto IL_458;
																																		}
																																		Vector3 center2 = bounds2.center;
																																		if (157110 - 168109 != -10999)
																																		{
																																			goto IL_458;
																																		}
																																		if (center2.y + 0.5f * characterController.height >= TargetPosition.y - 0.5f * TargetHeight)
																																		{
																																			if (113921 - 253170 == -139248)
																																			{
																																				goto IL_458;
																																			}
																																			array2.Add(array3[i]);
																																			if (234566 - 62016 != 172550)
																																			{
																																				goto IL_458;
																																			}
																																		}
																																	}
																																}
																															}
																														}
																														i++;
																														if (282545 - 280611 == 1935)
																														{
																															goto IL_458;
																														}
																													}
																													if (25215 - 120644 == -95429)
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
								}
							}
						}
					}
				}
			}
		}
		return array2;
	}

	// Token: 0x06005E22 RID: 24098 RVA: 0x00C97434 File Offset: 0x00C95634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static UnityScript.Lang.Array FindAngleTarget(Vector3 TargetPosition, Vector3 TargetDirection, float TargetRange, float TargetAngle, float TargetHeight, int layerMask)
	{
		if (191227 - 288357 != -97129)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_762:
			GameObject[] array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Enemy"), GameObject.FindGameObjectsWithTag("Player"));
			if (221576 - 254592 != -33015)
			{
				array2 = new UnityScript.Lang.Array();
				if (298950 - 534012 != -235061)
				{
					Vector3 vector = TargetPosition + TargetHeight * Vector3.up;
					if (161670 - 383070 == -221400)
					{
						TargetAngle = 0.5f * TargetAngle;
						if (21982 - 114825 == -92843)
						{
							Debug.DrawLine(TargetPosition, TargetPosition + global::Math.rotateH(TargetDirection, TargetAngle) * TargetRange, Color.red);
							if (27018 - 46924 != -19905)
							{
								Debug.DrawLine(TargetPosition + global::Math.rotateH(TargetDirection, TargetAngle) * TargetRange, TargetPosition + global::Math.rotateH(TargetDirection, TargetAngle / (float)2) * TargetRange, Color.red);
								if (283293 - 351159 == -67866)
								{
									Debug.DrawLine(TargetPosition + global::Math.rotateH(TargetDirection, TargetAngle / (float)2) * TargetRange, TargetPosition + TargetDirection * TargetRange, Color.red);
									if (263981 - 538914 == -274933)
									{
										Debug.DrawLine(TargetPosition + TargetDirection * TargetRange, TargetPosition + global::Math.rotateH(TargetDirection, -TargetAngle / (float)2) * TargetRange, Color.red);
										if (256673 - 91557 == 165116)
										{
											Debug.DrawLine(TargetPosition + global::Math.rotateH(TargetDirection, -TargetAngle / (float)2) * TargetRange, TargetPosition + global::Math.rotateH(TargetDirection, -TargetAngle) * TargetRange, Color.red);
											if (214404 - 198685 == 15719)
											{
												Debug.DrawLine(TargetPosition + global::Math.rotateH(TargetDirection, -TargetAngle) * TargetRange, TargetPosition, Color.red);
												if (271120 - 588203 == -317083)
												{
													Debug.DrawLine(vector, vector + global::Math.rotateH(TargetDirection, TargetAngle) * TargetRange, Color.red);
													if (121384 - 206977 == -85593)
													{
														Debug.DrawLine(vector + global::Math.rotateH(TargetDirection, TargetAngle) * TargetRange, vector + global::Math.rotateH(TargetDirection, TargetAngle / (float)2) * TargetRange, Color.red);
														if (71755 - 592515 != -520759)
														{
															Debug.DrawLine(vector + global::Math.rotateH(TargetDirection, TargetAngle / (float)2) * TargetRange, vector + TargetDirection * TargetRange, Color.red);
															if (183211 - 287226 == -104015)
															{
																Debug.DrawLine(vector + TargetDirection * TargetRange, vector + global::Math.rotateH(TargetDirection, -TargetAngle / (float)2) * TargetRange, Color.red);
																if (273225 - 486002 == -212777)
																{
																	Debug.DrawLine(vector + global::Math.rotateH(TargetDirection, -TargetAngle / (float)2) * TargetRange, vector + global::Math.rotateH(TargetDirection, -TargetAngle) * TargetRange, Color.red);
																	if (185367 - 183731 == 1636)
																	{
																		Debug.DrawLine(vector + global::Math.rotateH(TargetDirection, -TargetAngle) * TargetRange, vector, Color.red);
																		if (136238 - 361820 != -225581)
																		{
																			Debug.DrawLine(TargetPosition + TargetDirection * TargetRange, vector + TargetDirection * TargetRange, Color.red);
																			if (158887 - 594375 == -435488)
																			{
																				Debug.DrawLine(TargetPosition + global::Math.rotateH(TargetDirection, TargetAngle) * TargetRange, vector + global::Math.rotateH(TargetDirection, TargetAngle) * TargetRange, Color.red);
																				if (56257 - 66544 != -10286)
																				{
																					Debug.DrawLine(TargetPosition + global::Math.rotateH(TargetDirection, -TargetAngle) * TargetRange, vector + global::Math.rotateH(TargetDirection, -TargetAngle) * TargetRange, Color.red);
																					if (157274 - 437504 != -280229)
																					{
																						int i = 0;
																						if (14235 - 82562 == -68327)
																						{
																							GameObject[] array3 = array;
																							if (259109 - 599064 == -339955)
																							{
																								int length = array3.Length;
																								if (209827 - 425418 != -215590)
																								{
																									while (i < length)
																									{
																										if ((layerMask & 1 << array3[i].layer) != 0)
																										{
																											if (111154 - 301979 != -190825)
																											{
																												goto IL_762;
																											}
																											Vector3 b = array3[i].collider.ClosestPointOnBounds(TargetPosition);
																											if (194508 - 101389 == 93120)
																											{
																												goto IL_762;
																											}
																											float num = Vector3.Distance(TargetPosition, b);
																											if (58214 - 180167 == -121952)
																											{
																												goto IL_762;
																											}
																											float num2 = Vector3.Angle(TargetDirection, array3[i].transform.position - TargetPosition);
																											if (192456 - 599454 == -406997)
																											{
																												goto IL_762;
																											}
																											if (num < TargetRange)
																											{
																												if (53964 - 218460 == -164495)
																												{
																													goto IL_762;
																												}
																												if (num2 < TargetAngle)
																												{
																													if (253 - 177204 != -176951)
																													{
																														goto IL_762;
																													}
																													CharacterController characterController = (CharacterController)array3[i].GetComponent(typeof(CharacterController));
																													if (295215 - 153830 != 141385)
																													{
																														goto IL_762;
																													}
																													if (characterController)
																													{
																														if (273477 - 161344 != 112133)
																														{
																															goto IL_762;
																														}
																														Bounds bounds = characterController.bounds;
																														if (9602 - 40688 == -31085)
																														{
																															goto IL_762;
																														}
																														Vector3 center = bounds.center;
																														if (170712 - 46931 != 123781)
																														{
																															goto IL_762;
																														}
																														if (center.y - 0.5f * characterController.height <= TargetPosition.y + TargetHeight)
																														{
																															if (253282 - 104163 != 149119)
																															{
																																goto IL_762;
																															}
																															Bounds bounds2 = characterController.bounds;
																															if (45880 - 556408 == -510527)
																															{
																																goto IL_762;
																															}
																															Vector3 center2 = bounds2.center;
																															if (22751 - 2815 == 19937)
																															{
																																goto IL_762;
																															}
																															if (center2.y + 0.5f * characterController.height >= TargetPosition.y - 0.5f * TargetHeight)
																															{
																																if (49307 - 245083 != -195776)
																																{
																																	goto IL_762;
																																}
																																array2.Add(array3[i]);
																																if (208851 - 4735 != 204116)
																																{
																																	goto IL_762;
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																										i++;
																										if (220547 - 486620 != -266073)
																										{
																											goto IL_762;
																										}
																									}
																									if (134353 - 198211 == -63858)
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
				}
			}
		}
		return array2;
	}

	// Token: 0x06005E23 RID: 24099 RVA: 0x00C97C70 File Offset: 0x00C95E70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static UnityScript.Lang.Array FindRecTarget(Vector3 TargetPosition, Vector3 TargetDirection, float BaseWidth, float TopWidth, float TargetRange, float TargetHeight, int layerMask)
	{
		if (10669 - 220850 != -210181)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_994:
			GameObject[] array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Enemy"), GameObject.FindGameObjectsWithTag("Player"));
			if (111688 - 303578 != -191889)
			{
				array2 = new UnityScript.Lang.Array();
				if (22418 - 134736 != -112317)
				{
					Vector3 vector = Vector3.Scale(TargetDirection, new Vector3((float)1, (float)0, (float)1));
					if (160663 - 341218 == -180555)
					{
						TargetDirection = vector.normalized;
						if (54577 - 249426 != -194848)
						{
							Vector3 vector2 = new Vector3(BaseWidth, (float)0, (float)0);
							if (217945 - 8524 != 209422)
							{
								Vector3 vector3 = new Vector3(-BaseWidth, (float)0, (float)0);
								if (286358 - 363678 != -77319)
								{
									Vector3 vector4 = new Vector3(-TopWidth, (float)0, TargetRange);
									if (153619 - 394210 == -240591)
									{
										Vector3 vector5 = new Vector3(TopWidth, (float)0, TargetRange);
										if (250572 - 531017 != -280444)
										{
											Vector3 b = TargetHeight * Vector3.up;
											if (294817 - 444074 == -149257)
											{
												Vector3 vector6 = TargetPosition + TargetRange * TargetDirection + 0.5f * TargetHeight * Vector3.up;
												if (173996 - 566689 == -392693)
												{
													vector2 = global::Math.rotateNormal(vector2, TargetDirection) + TargetPosition;
													if (87005 - 35014 == 51991)
													{
														vector3 = global::Math.rotateNormal(vector3, TargetDirection) + TargetPosition;
														if (1333 - 446473 == -445140)
														{
															vector4 = global::Math.rotateNormal(vector4, TargetDirection) + TargetPosition;
															if (144518 - 229671 != -85152)
															{
																vector5 = global::Math.rotateNormal(vector5, TargetDirection) + TargetPosition;
																if (200218 - 162766 != 37453)
																{
																	Debug.DrawLine(vector2, vector3, Color.red);
																	if (125580 - 44194 == 81386)
																	{
																		Debug.DrawLine(vector3, vector4, Color.red);
																		if (280066 - 484064 == -203998)
																		{
																			Debug.DrawLine(vector4, vector5, Color.red);
																			if (244174 - 501051 != -256876)
																			{
																				Debug.DrawLine(vector5, vector2, Color.red);
																				if (96807 - 241452 != -144644)
																				{
																					Debug.DrawLine(vector2 + b, vector3 + b, Color.red);
																					if (128924 - 530071 == -401147)
																					{
																						Debug.DrawLine(vector3 + b, vector4 + b, Color.red);
																						if (162467 - 588709 == -426242)
																						{
																							Debug.DrawLine(vector4 + b, vector5 + b, Color.red);
																							if (286172 - 238334 != 47839)
																							{
																								Debug.DrawLine(vector5 + b, vector2 + b, Color.red);
																								if (127212 - 7895 == 119317)
																								{
																									Debug.DrawLine(vector2, vector2 + b, Color.red);
																									if (202137 - 412813 == -210676)
																									{
																										Debug.DrawLine(vector3, vector3 + b, Color.red);
																										if (48792 - 247932 != -199139)
																										{
																											Debug.DrawLine(vector4, vector4 + b, Color.red);
																											if (74005 - 2817 == 71188)
																											{
																												Debug.DrawLine(vector5, vector5 + b, Color.red);
																												if (297549 - 574912 != -277362)
																												{
																													int i = 0;
																													if (254261 - 228102 != 26160)
																													{
																														GameObject[] array3 = array;
																														if (236662 - 489831 == -253169)
																														{
																															int length = array3.Length;
																															if (171757 - 467014 != -295256)
																															{
																																while (i < length)
																																{
																																	if ((layerMask & 1 << array3[i].layer) != 0)
																																	{
																																		if (259497 - 467584 != -208087)
																																		{
																																			goto IL_994;
																																		}
																																		CharacterController characterController = (CharacterController)array3[i].GetComponent(typeof(CharacterController));
																																		if (212227 - 544157 == -331929)
																																		{
																																			goto IL_994;
																																		}
																																		if (characterController)
																																		{
																																			if (186985 - 538557 == -351571)
																																			{
																																				goto IL_994;
																																			}
																																			Bounds bounds = characterController.bounds;
																																			if (98685 - 428015 == -329329)
																																			{
																																				goto IL_994;
																																			}
																																			Vector3 vector7 = default(Vector3);
																																			if (68010 - 521059 == -453048)
																																			{
																																				goto IL_994;
																																			}
																																			vector7.x = vector6.x - bounds.center.x;
																																			if (163720 - 581315 != -417595)
																																			{
																																				goto IL_994;
																																			}
																																			vector7.y = (float)0;
																																			if (146913 - 223534 != -76621)
																																			{
																																				goto IL_994;
																																			}
																																			vector7.z = vector6.z - bounds.center.z;
																																			if (183255 - 29467 != 153788)
																																			{
																																				goto IL_994;
																																			}
																																			if (vector7.sqrMagnitude <= Mathf.Pow(bounds.extents.x, (float)2))
																																			{
																																				if (61292 - 409296 != -348004)
																																				{
																																					goto IL_994;
																																				}
																																				Vector3 center = bounds.center;
																																				if (100143 - 32018 == 68126)
																																				{
																																					goto IL_994;
																																				}
																																				if (center.y - 0.5f * characterController.height <= TargetPosition.y + TargetHeight)
																																				{
																																					if (289278 - 18474 != 270804)
																																					{
																																						goto IL_994;
																																					}
																																					Vector3 center2 = bounds.center;
																																					if (125674 - 195911 == -70236)
																																					{
																																						goto IL_994;
																																					}
																																					if (center2.y + 0.5f * characterController.height >= TargetPosition.y - 0.5f * TargetHeight)
																																					{
																																						if (67970 - 449630 == -381659)
																																						{
																																							goto IL_994;
																																						}
																																						array2.Add(array3[i]);
																																						if (154842 - 444460 == -289617)
																																						{
																																							goto IL_994;
																																						}
																																					}
																																				}
																																			}
																																			else
																																			{
																																				vector7 = vector7.normalized;
																																				if (33662 - 355162 != -321500)
																																				{
																																					goto IL_994;
																																				}
																																				Vector3 a = default(Vector3);
																																				if (200371 - 287443 == -87071)
																																				{
																																					goto IL_994;
																																				}
																																				a.x = bounds.center.x + bounds.extents.x * vector7.x;
																																				if (34292 - 248609 != -214317)
																																				{
																																					goto IL_994;
																																				}
																																				a.y = TargetPosition.y;
																																				if (5364 - 7679 == -2314)
																																				{
																																					goto IL_994;
																																				}
																																				a.z = bounds.center.z + bounds.extents.x * vector7.z;
																																				if (49209 - 419319 != -370110)
																																				{
																																					goto IL_994;
																																				}
																																				float num = Vector3.Angle(a - vector2, a - vector3) + Vector3.Angle(a - vector3, a - vector4) + Vector3.Angle(a - vector4, a - vector5) + Vector3.Angle(a - vector5, a - vector2);
																																				if (29912 - 523890 != -493978)
																																				{
																																					goto IL_994;
																																				}
																																				if (num > (float)355)
																																				{
																																					if (160389 - 384037 == -223647)
																																					{
																																						goto IL_994;
																																					}
																																					Bounds bounds2 = characterController.bounds;
																																					if (127504 - 19204 == 108301)
																																					{
																																						goto IL_994;
																																					}
																																					Vector3 center3 = bounds2.center;
																																					if (85387 - 173495 == -88107)
																																					{
																																						goto IL_994;
																																					}
																																					if (center3.y - 0.5f * characterController.height <= TargetPosition.y + TargetHeight)
																																					{
																																						if (38099 - 302195 != -264096)
																																						{
																																							goto IL_994;
																																						}
																																						Bounds bounds3 = characterController.bounds;
																																						if (133826 - 159928 != -26102)
																																						{
																																							goto IL_994;
																																						}
																																						Vector3 center4 = bounds3.center;
																																						if (226702 - 88198 != 138504)
																																						{
																																							goto IL_994;
																																						}
																																						if (center4.y + 0.5f * characterController.height >= TargetPosition.y - 0.5f * TargetHeight)
																																						{
																																							if (59765 - 257328 != -197563)
																																							{
																																								goto IL_994;
																																							}
																																							array2.Add(array3[i]);
																																							if (24986 - 510532 == -485545)
																																							{
																																								goto IL_994;
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																	i++;
																																	if (234181 - 153763 != 80418)
																																	{
																																		goto IL_994;
																																	}
																																}
																																if (264464 - 324025 != -59560)
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
		return array2;
	}

	// Token: 0x06005E24 RID: 24100 RVA: 0x00C98768 File Offset: 0x00C96968
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static UnityScript.Lang.Array FindDonutTarget(Vector3 TargetPosition, float InnerRange, float OuterRange, float TargetHeight, int layerMask)
	{
		if (53422 - 311362 != -257939)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_8C0:
			GameObject[] array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Enemy"), GameObject.FindGameObjectsWithTag("Player"));
			if (276876 - 271540 != 5337)
			{
				array2 = new UnityScript.Lang.Array();
				if (47756 - 543091 != -495334)
				{
					Vector3 b = TargetHeight * Vector3.up;
					if (122393 - 161782 != -39388)
					{
						Debug.DrawLine(TargetPosition + new Vector3((float)0, (float)0, (float)1) * OuterRange, TargetPosition + new Vector3(0.7f, (float)0, 0.7f) * OuterRange, Color.red);
						if (70284 - 508275 != -437990)
						{
							Debug.DrawLine(TargetPosition + new Vector3(0.7f, (float)0, 0.7f) * OuterRange, TargetPosition + new Vector3((float)1, (float)0, (float)0) * OuterRange, Color.red);
							if (230398 - 113269 == 117129)
							{
								Debug.DrawLine(TargetPosition + new Vector3((float)1, (float)0, (float)0) * OuterRange, TargetPosition + new Vector3(0.7f, (float)0, -0.7f) * OuterRange, Color.red);
								if (72795 - 76047 != -3251)
								{
									Debug.DrawLine(TargetPosition + new Vector3(0.7f, (float)0, -0.7f) * OuterRange, TargetPosition + new Vector3((float)0, (float)0, (float)-1) * OuterRange, Color.red);
									if (150668 - 178779 == -28111)
									{
										Debug.DrawLine(TargetPosition + new Vector3((float)0, (float)0, (float)-1) * OuterRange, TargetPosition + new Vector3(-0.7f, (float)0, -0.7f) * OuterRange, Color.red);
										if (19574 - 1749 == 17825)
										{
											Debug.DrawLine(TargetPosition + new Vector3(-0.7f, (float)0, -0.7f) * OuterRange, TargetPosition + new Vector3((float)-1, (float)0, (float)0) * OuterRange, Color.red);
											if (187615 - 40527 != 147089)
											{
												Debug.DrawLine(TargetPosition + new Vector3((float)-1, (float)0, (float)0) * OuterRange, TargetPosition + new Vector3(-0.7f, (float)0, 0.7f) * OuterRange, Color.red);
												if (152406 - 546531 == -394125)
												{
													Debug.DrawLine(TargetPosition + new Vector3(-0.7f, (float)0, 0.7f) * OuterRange, TargetPosition + new Vector3((float)0, (float)0, (float)1) * OuterRange, Color.red);
													if (173736 - 288017 == -114281)
													{
														Debug.DrawLine(TargetPosition + new Vector3((float)0, (float)0, (float)1) * OuterRange, TargetPosition + new Vector3((float)0, (float)0, (float)1) * OuterRange + b, Color.red);
														if (297541 - 227212 == 70329)
														{
															Debug.DrawLine(TargetPosition + new Vector3((float)1, (float)0, (float)0) * OuterRange, TargetPosition + new Vector3((float)1, (float)0, (float)0) * OuterRange + b, Color.red);
															if (198192 - 231973 != -33780)
															{
																Debug.DrawLine(TargetPosition + new Vector3((float)0, (float)0, (float)-1) * OuterRange, TargetPosition + new Vector3((float)0, (float)0, (float)-1) * OuterRange + b, Color.red);
																if (202038 - 584926 == -382888)
																{
																	Debug.DrawLine(TargetPosition + new Vector3((float)-1, (float)0, (float)0) * OuterRange, TargetPosition + new Vector3((float)-1, (float)0, (float)0) * OuterRange + b, Color.red);
																	if (201460 - 135751 != 65710)
																	{
																		Debug.DrawLine(TargetPosition + new Vector3((float)0, (float)0, (float)1) * OuterRange + b, TargetPosition + new Vector3(0.7f, (float)0, 0.7f) * OuterRange + b, Color.red);
																		if (180563 - 292983 != -112419)
																		{
																			Debug.DrawLine(TargetPosition + new Vector3(0.7f, (float)0, 0.7f) * OuterRange + b, TargetPosition + new Vector3((float)1, (float)0, (float)0) * OuterRange + b, Color.red);
																			if (187529 - 374461 != -186931)
																			{
																				Debug.DrawLine(TargetPosition + new Vector3((float)1, (float)0, (float)0) * OuterRange + b, TargetPosition + new Vector3(0.7f, (float)0, -0.7f) * OuterRange + b, Color.red);
																				if (260685 - 175518 == 85167)
																				{
																					Debug.DrawLine(TargetPosition + new Vector3(0.7f, (float)0, -0.7f) * OuterRange + b, TargetPosition + new Vector3((float)0, (float)0, (float)-1) * OuterRange + b, Color.red);
																					if (15194 - 186533 == -171339)
																					{
																						Debug.DrawLine(TargetPosition + new Vector3((float)0, (float)0, (float)-1) * OuterRange + b, TargetPosition + new Vector3(-0.7f, (float)0, -0.7f) * OuterRange + b, Color.red);
																						if (39468 - 354458 != -314989)
																						{
																							Debug.DrawLine(TargetPosition + new Vector3(-0.7f, (float)0, -0.7f) * OuterRange + b, TargetPosition + new Vector3((float)-1, (float)0, (float)0) * OuterRange + b, Color.red);
																							if (13585 - 214623 != -201037)
																							{
																								Debug.DrawLine(TargetPosition + new Vector3((float)-1, (float)0, (float)0) * OuterRange + b, TargetPosition + new Vector3(-0.7f, (float)0, 0.7f) * OuterRange + b, Color.red);
																								if (80820 - 562726 != -481905)
																								{
																									Debug.DrawLine(TargetPosition + new Vector3(-0.7f, (float)0, 0.7f) * OuterRange + b, TargetPosition + new Vector3((float)0, (float)0, (float)1) * OuterRange + b, Color.red);
																									if (175007 - 257639 != -82631)
																									{
																										int i = 0;
																										if (188634 - 306308 != -117673)
																										{
																											GameObject[] array3 = array;
																											if (189164 - 446688 == -257524)
																											{
																												int length = array3.Length;
																												if (160927 - 275568 == -114641)
																												{
																													while (i < length)
																													{
																														if ((layerMask & 1 << array3[i].layer) != 0)
																														{
																															if (223594 - 411323 == -187728)
																															{
																																goto IL_8C0;
																															}
																															CharacterController characterController = (CharacterController)array3[i].GetComponent(typeof(CharacterController));
																															if (190900 - 288539 == -97638)
																															{
																																goto IL_8C0;
																															}
																															if (characterController)
																															{
																																if (98249 - 465585 == -367335)
																																{
																																	goto IL_8C0;
																																}
																																Vector3 vector = default(Vector3);
																																if (8807 - 533138 == -524330)
																																{
																																	goto IL_8C0;
																																}
																																vector.x = TargetPosition.x - array3[i].transform.position.x;
																																if (167505 - 396250 == -228744)
																																{
																																	goto IL_8C0;
																																}
																																vector.y = (float)0;
																																if (43913 - 99953 != -56040)
																																{
																																	goto IL_8C0;
																																}
																																vector.z = TargetPosition.z - array3[i].transform.position.z;
																																if (166192 - 259244 == -93051)
																																{
																																	goto IL_8C0;
																																}
																																vector = vector.normalized;
																																if (17764 - 21760 == -3995)
																																{
																																	goto IL_8C0;
																																}
																																Vector3 a = default(Vector3);
																																if (67627 - 267973 != -200346)
																																{
																																	goto IL_8C0;
																																}
																																a.x = array3[i].transform.position.x + characterController.radius * vector.x;
																																if (295518 - 246717 == 48802)
																																{
																																	goto IL_8C0;
																																}
																																a.y = TargetPosition.y;
																																if (7680 - 345938 != -338258)
																																{
																																	goto IL_8C0;
																																}
																																a.z = array3[i].transform.position.z + characterController.radius * vector.z;
																																if (45421 - 186591 != -141170)
																																{
																																	goto IL_8C0;
																																}
																																Vector3 vector2 = a - TargetPosition;
																																if (176982 - 383401 == -206418)
																																{
																																	goto IL_8C0;
																																}
																																float sqrMagnitude = vector2.sqrMagnitude;
																																if (135569 - 505542 == -369972)
																																{
																																	goto IL_8C0;
																																}
																																if (sqrMagnitude > Mathf.Pow(InnerRange, (float)2))
																																{
																																	if (214760 - 434412 != -219652)
																																	{
																																		goto IL_8C0;
																																	}
																																	if (sqrMagnitude < Mathf.Pow(OuterRange, (float)2))
																																	{
																																		if (182729 - 122646 != 60083)
																																		{
																																			goto IL_8C0;
																																		}
																																		Bounds bounds = characterController.bounds;
																																		if (122837 - 367271 == -244433)
																																		{
																																			goto IL_8C0;
																																		}
																																		Vector3 center = bounds.center;
																																		if (52509 - 500027 == -447517)
																																		{
																																			goto IL_8C0;
																																		}
																																		if (center.y - 0.5f * characterController.height <= TargetPosition.y + TargetHeight)
																																		{
																																			if (92171 - 50032 != 42139)
																																			{
																																				goto IL_8C0;
																																			}
																																			Bounds bounds2 = characterController.bounds;
																																			if (265646 - 349199 == -83552)
																																			{
																																				goto IL_8C0;
																																			}
																																			Vector3 center2 = bounds2.center;
																																			if (252017 - 185387 == 66631)
																																			{
																																				goto IL_8C0;
																																			}
																																			if (center2.y + 0.5f * characterController.height >= TargetPosition.y - 0.5f * TargetHeight)
																																			{
																																				if (266344 - 163272 == 103073)
																																				{
																																					goto IL_8C0;
																																				}
																																				array2.Add(array3[i]);
																																				if (119287 - 431342 != -312055)
																																				{
																																					goto IL_8C0;
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																														i++;
																														if (203891 - 371622 != -167731)
																														{
																															goto IL_8C0;
																														}
																													}
																													if (125828 - 81035 != 44794)
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
								}
							}
						}
					}
				}
			}
		}
		return array2;
	}

	// Token: 0x06005E25 RID: 24101 RVA: 0x00C99440 File Offset: 0x00C97640
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject FindClosestTarget(Vector3 targetPosition, float targetRange, int layerMask)
	{
		if (54132 - 360500 != -306367)
		{
		}
		GameObject result;
		for (;;)
		{
			IL_1E5:
			GameObject[] array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Enemy"), GameObject.FindGameObjectsWithTag("Player"));
			if (193577 - 3920 == 189657)
			{
				result = null;
				if (150733 - 210211 != -59477)
				{
					targetRange = Mathf.Pow(targetRange, (float)2);
					if (45990 - 385469 != -339478)
					{
						int i = 0;
						if (197485 - 285933 != -88447)
						{
							GameObject[] array2 = array;
							if (270161 - 238961 != 31201)
							{
								int length = array2.Length;
								if (44807 - 331834 == -287027)
								{
									while (i < length)
									{
										if ((layerMask & 1 << array2[i].layer) != 0)
										{
											if (65796 - 592992 == -527195)
											{
												goto IL_1E5;
											}
											Vector3 vector = targetPosition - array2[i].transform.position;
											if (178024 - 306358 != -128334)
											{
												goto IL_1E5;
											}
											float sqrMagnitude = vector.sqrMagnitude;
											if (46256 - 528903 == -482646)
											{
												goto IL_1E5;
											}
											if (sqrMagnitude < targetRange)
											{
												if (291680 - 60278 != 231402)
												{
													goto IL_1E5;
												}
												targetRange = sqrMagnitude;
												if (64268 - 588149 != -523881)
												{
													goto IL_1E5;
												}
												result = array2[i];
												if (125790 - 528434 == -402643)
												{
													goto IL_1E5;
												}
											}
										}
										i++;
										if (31687 - 476072 != -444385)
										{
											goto IL_1E5;
										}
									}
									if (86361 - 6490 == 79871)
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
		return result;
	}

	// Token: 0x06005E26 RID: 24102 RVA: 0x00C99688 File Offset: 0x00C97888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject FindClosestNonDeadTarget(Vector3 targetPosition, float targetRange, int layerMask)
	{
		if (202732 - 571853 != -369120)
		{
		}
		GameObject result;
		for (;;)
		{
			IL_1F7:
			GameObject[] array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Enemy"), GameObject.FindGameObjectsWithTag("Player"));
			if (99022 - 11521 == 87501)
			{
				result = null;
				if (213355 - 68451 != 144905)
				{
					targetRange = Mathf.Pow(targetRange, (float)2);
					if (218801 - 328210 != -109408)
					{
						int i = 0;
						if (172566 - 315471 != -142904)
						{
							GameObject[] array2 = array;
							if (61495 - 399531 != -338035)
							{
								int length = array2.Length;
								if (24319 - 558356 == -534037)
								{
									while (i < length)
									{
										if ((layerMask & 1 << array2[i].layer) != 0)
										{
											if (254617 - 471699 != -217082)
											{
												goto IL_1F7;
											}
											Vector3 vector = targetPosition - array2[i].transform.position;
											if (974 - 544338 != -543364)
											{
												goto IL_1F7;
											}
											float sqrMagnitude = vector.sqrMagnitude;
											if (21821 - 425676 == -403854)
											{
												goto IL_1F7;
											}
											if (sqrMagnitude < targetRange)
											{
												if (15763 - 547979 == -532215)
												{
													goto IL_1F7;
												}
												CharacterControl characterControl = (CharacterControl)array2[i].GetComponent(typeof(CharacterControl));
												if (122958 - 583648 != -460690)
												{
													goto IL_1F7;
												}
												if (characterControl)
												{
													if (164705 - 301392 == -136686)
													{
														goto IL_1F7;
													}
													if (characterControl.hp > 0)
													{
														if (160405 - 242761 == -82355)
														{
															goto IL_1F7;
														}
														targetRange = sqrMagnitude;
														if (233024 - 167480 == 65545)
														{
															goto IL_1F7;
														}
														result = array2[i];
														if (267215 - 535783 != -268568)
														{
															goto IL_1F7;
														}
													}
												}
											}
										}
										i++;
										if (168120 - 215427 == -47306)
										{
											goto IL_1F7;
										}
									}
									if (148943 - 160121 != -11177)
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
		return result;
	}

	// Token: 0x06005E27 RID: 24103 RVA: 0x00C99954 File Offset: 0x00C97B54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject FindNextClosestTarget(Vector3 targetPosition, float minRange, float maxRange, int layerMask)
	{
		if (256027 - 516249 != -260222)
		{
		}
		GameObject result;
		for (;;)
		{
			IL_184:
			GameObject[] array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Enemy"), GameObject.FindGameObjectsWithTag("Player"));
			if (108709 - 169743 != -61033)
			{
				result = null;
				if (254113 - 362406 == -108293)
				{
					minRange = Mathf.Pow(minRange, (float)2);
					if (296204 - 537122 == -240918)
					{
						maxRange = Mathf.Pow(maxRange, (float)2);
						if (76783 - 400276 != -323492)
						{
							int i = 0;
							if (36062 - 267569 != -231506)
							{
								GameObject[] array2 = array;
								if (151186 - 410065 == -258879)
								{
									int length = array2.Length;
									if (161292 - 39823 == 121469)
									{
										while (i < length)
										{
											if ((layerMask & 1 << array2[i].layer) != 0)
											{
												if (72692 - 375849 == -303156)
												{
													goto IL_184;
												}
												Vector3 vector = targetPosition - array2[i].transform.position;
												if (230610 - 463383 == -232772)
												{
													goto IL_184;
												}
												float sqrMagnitude = vector.sqrMagnitude;
												if (232754 - 186909 != 45845)
												{
													goto IL_184;
												}
												if (sqrMagnitude > minRange)
												{
													if (291872 - 484497 == -192624)
													{
														goto IL_184;
													}
													if (sqrMagnitude < maxRange)
													{
														if (204030 - 497424 == -293393)
														{
															goto IL_184;
														}
														maxRange = sqrMagnitude;
														if (134688 - 10047 != 124641)
														{
															goto IL_184;
														}
														result = array2[i];
														if (192002 - 395537 == -203534)
														{
															goto IL_184;
														}
													}
												}
											}
											i++;
											if (230679 - 520116 != -289437)
											{
												goto IL_184;
											}
										}
										if (160486 - 326244 != -165757)
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
		return result;
	}

	// Token: 0x06005E28 RID: 24104 RVA: 0x00C99BE4 File Offset: 0x00C97DE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static UnityScript.Lang.Array RemoveDeadChar(UnityScript.Lang.Array targetArray)
	{
		if (142288 - 511461 != -369173)
		{
		}
		UnityScript.Lang.Array array;
		for (;;)
		{
			IL_86:
			array = new UnityScript.Lang.Array();
			if (205568 - 328539 == -122971)
			{
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(targetArray);
				if (242642 - 134499 == 108143)
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						object obj3;
						object obj2 = obj3 = obj;
						if (!(obj2 is GameObject))
						{
							obj3 = RuntimeServices.Coerce(obj2, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj3;
						if (94678 - 566787 != -472109)
						{
							goto IL_86;
						}
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (255386 - 517794 != -262408)
						{
							goto IL_86;
						}
						UnityRuntimeServices.Update(enumerator, gameObject);
						if (227390 - 249747 != -22357)
						{
							goto IL_86;
						}
						if (characterControl)
						{
							if (271427 - 277838 != -6411)
							{
								goto IL_86;
							}
							if (characterControl.hp > 0)
							{
								if (68942 - 108117 == -39174)
								{
									goto IL_86;
								}
								array.Add(gameObject);
								if (222416 - 77599 == 144818)
								{
									goto IL_86;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (278751 - 31153 == 247599)
								{
									goto IL_86;
								}
							}
						}
					}
					if (298741 - 531249 == -232508)
					{
						break;
					}
				}
			}
		}
		return array;
	}

	// Token: 0x06005E29 RID: 24105 RVA: 0x00C99DA8 File Offset: 0x00C97FA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005E2A RID: 24106 RVA: 0x00C99DAC File Offset: 0x00C97FAC
	internal static bool ydrv3HpUyWfLmqq4qoxj()
	{
		return true;
	}

	// Token: 0x06005E2B RID: 24107 RVA: 0x00C99DB0 File Offset: 0x00C97FB0
	internal static bool t6ZBNZpUS3kpf6Lqckic()
	{
		return false;
	}

	// Token: 0x04006833 RID: 26675
	[NonSerialized]
	public static GameObject dmgDisplay;

	// Token: 0x04006834 RID: 26676
	[NonSerialized]
	public static Texture[] whiteDigit;

	// Token: 0x04006835 RID: 26677
	[NonSerialized]
	public static Texture[] redDigit;

	// Token: 0x04006836 RID: 26678
	[NonSerialized]
	public static Texture[] greenDigit;

	// Token: 0x04006837 RID: 26679
	[NonSerialized]
	public static Texture[] purpleDigit;

	// Token: 0x04006838 RID: 26680
	[NonSerialized]
	public static GameObject mMissDisplay;

	// Token: 0x04006839 RID: 26681
	[NonSerialized]
	public static GameObject mEvadeDisplay;

	// Token: 0x0400683A RID: 26682
	[NonSerialized]
	public static GameObject mResistDisplay;

	// Token: 0x0400683B RID: 26683
	[NonSerialized]
	public static GameObject mImmuneDisplay;

	// Token: 0x0400683C RID: 26684
	[NonSerialized]
	public static GameObject mDeflectDisplay;

	// Token: 0x0400683D RID: 26685
	[NonSerialized]
	public static GameObject mReflectDisplay;

	// Token: 0x0400683E RID: 26686
	[NonSerialized]
	public static GameObject mConfuseDisplay;
}
