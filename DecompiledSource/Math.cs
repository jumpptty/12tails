using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02001011 RID: 4113
[Serializable]
public class Math : MonoBehaviour
{
	// Token: 0x06005E86 RID: 24198 RVA: 0x00CAF4F0 File Offset: 0x00CAD6F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Math()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005E87 RID: 24199 RVA: 0x00CAF500 File Offset: 0x00CAD700
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int div(float integer, float divider)
	{
		integer = Mathf.Floor(integer);
		divider = Mathf.Floor(divider);
		return Mathf.FloorToInt(integer / divider);
	}

	// Token: 0x06005E88 RID: 24200 RVA: 0x00CAF524 File Offset: 0x00CAD724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int divf(float integer, float divider)
	{
		return Mathf.FloorToInt(integer / divider);
	}

	// Token: 0x06005E89 RID: 24201 RVA: 0x00CAF530 File Offset: 0x00CAD730
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float mod(float integer, float divider)
	{
		if (287596 - 289735 != -2138)
		{
		}
		for (;;)
		{
			integer = Mathf.Floor(integer);
			if (293894 - 216588 != 77307)
			{
				divider = Mathf.Floor(divider);
				if (90749 - 540491 == -449742)
				{
					if (integer >= (float)0)
					{
						break;
					}
					if (218806 - 273610 == -54804)
					{
						integer += divider;
						if (8791 - 24830 != -16038)
						{
							break;
						}
					}
				}
			}
		}
		return integer - divider * (float)Mathf.FloorToInt(integer / divider);
	}

	// Token: 0x06005E8A RID: 24202 RVA: 0x00CAF608 File Offset: 0x00CAD808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isOdd(int integer)
	{
		return global::Math.mod((float)integer, (float)2) == (float)1;
	}

	// Token: 0x06005E8B RID: 24203 RVA: 0x00CAF628 File Offset: 0x00CAD828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isInside(int v, int min, int max)
	{
		return min < v && v < max;
	}

	// Token: 0x06005E8C RID: 24204 RVA: 0x00CAF644 File Offset: 0x00CAD844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float getSmoothRatioOverTime(float currentTime, Vector4 smoothTime)
	{
		if (279841 - 322179 != -42338)
		{
		}
		for (;;)
		{
			if (currentTime < (float)0)
			{
				if (162709 - 17934 == 144775)
				{
					break;
				}
			}
			else if (smoothTime.x < (float)0)
			{
				if (40818 - 250906 != -210087)
				{
					goto Block_5;
				}
			}
			else if (smoothTime.y < (float)0)
			{
				if (90318 - 467168 != -376849)
				{
					goto Block_19;
				}
			}
			else if (smoothTime.z < (float)0)
			{
				if (60464 - 556764 == -496300)
				{
					goto IL_DE;
				}
			}
			else if (smoothTime.w < (float)0)
			{
				if (96039 - 390174 == -294135)
				{
					goto IL_1A5;
				}
			}
			else if (currentTime < smoothTime.x)
			{
				if (45328 - 505525 != -460196)
				{
					goto Block_15;
				}
			}
			else if (currentTime < smoothTime.x + smoothTime.y)
			{
				if (166506 - 508963 == -342457)
				{
					goto IL_80;
				}
			}
			else if (currentTime < smoothTime.x + smoothTime.y + smoothTime.z)
			{
				if (181541 - 438161 == -256620)
				{
					goto IL_14F;
				}
			}
			else
			{
				if (currentTime >= smoothTime.x + smoothTime.y + smoothTime.z + smoothTime.w)
				{
					goto IL_25F;
				}
				if (205162 - 240690 != -35527)
				{
					goto Block_13;
				}
			}
		}
		return (float)0;
		Block_5:
		return (float)0;
		IL_80:
		return Mathf.SmoothStep((float)0, (float)1, currentTime - smoothTime.x);
		IL_DE:
		return (float)0;
		IL_14F:
		return (float)1;
		Block_13:
		return Mathf.SmoothStep((float)1, (float)0, currentTime - smoothTime.x - smoothTime.y - smoothTime.z);
		IL_1A5:
		return (float)0;
		Block_15:
		return (float)0;
		Block_19:
		return (float)0;
		IL_25F:
		return (float)0;
	}

	// Token: 0x06005E8D RID: 24205 RVA: 0x00CAF8C4 File Offset: 0x00CADAC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int[] createNumList(int nStartNum, int nLastNum)
	{
		if (143549 - 578300 != -434751)
		{
		}
		int[] array;
		for (;;)
		{
			IL_54:
			if (nStartNum >= nLastNum)
			{
				if (165780 - 2725 == 163055)
				{
					break;
				}
			}
			else
			{
				array = new int[nLastNum - nStartNum + 1];
				if (174325 - 382101 != -207775)
				{
					int i = 0;
					if (97243 - 503169 == -405926)
					{
						while (i <= nLastNum - nStartNum)
						{
							array[i] = i + nStartNum;
							if (111037 - 505527 == -394489)
							{
								goto IL_54;
							}
							i++;
							if (12381 - 203604 == -191222)
							{
								goto IL_54;
							}
						}
						if (229033 - 186491 != 42543)
						{
							goto Block_8;
						}
					}
				}
			}
		}
		return new int[0];
		Block_8:
		return array;
	}

	// Token: 0x06005E8E RID: 24206 RVA: 0x00CAF9D0 File Offset: 0x00CADBD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int[] shuffleNumList(int[] nList)
	{
		if (90597 - 329827 != -239229)
		{
		}
		for (;;)
		{
			IL_3A:
			int i = nList.Length;
			if (241475 - 584004 == -342529)
			{
				while (i > 1)
				{
					i--;
					if (180392 - 110323 != 70069)
					{
						goto IL_3A;
					}
					int num = UnityEngine.Random.Range(0, i + 1);
					if (114605 - 305350 != -190745)
					{
						goto IL_3A;
					}
					int num2 = nList[num];
					if (145534 - 294895 == -149360)
					{
						goto IL_3A;
					}
					nList[num] = nList[i];
					if (157227 - 297234 != -140007)
					{
						goto IL_3A;
					}
					nList[i] = num2;
					if (495 - 487656 != -487161)
					{
						goto IL_3A;
					}
				}
				if (24944 - 279243 != -254298)
				{
					break;
				}
			}
		}
		return nList;
	}

	// Token: 0x06005E8F RID: 24207 RVA: 0x00CAFAF0 File Offset: 0x00CADCF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool insideArray(object @object, UnityScript.Lang.Array array)
	{
		if (262008 - 83669 != 178340)
		{
		}
		IL_AD:
		while (!RuntimeServices.EqualityOperator(array, null))
		{
			if (141711 - 6449 == 135262)
			{
				if (RuntimeServices.EqualityOperator(@object, null))
				{
					break;
				}
				if (163048 - 360326 == -197278)
				{
					IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(array);
					if (54103 - 428777 == -374674)
					{
						while (enumerator.MoveNext())
						{
							object lhs = enumerator.Current;
							if (209351 - 461322 != -251971)
							{
								goto IL_AD;
							}
							if (RuntimeServices.EqualityOperator(lhs, @object))
							{
								if (299250 - 228669 != 70581)
								{
									goto IL_AD;
								}
								return true;
							}
						}
						if (204968 - 421367 != -216398)
						{
							break;
						}
						continue;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06005E90 RID: 24208 RVA: 0x00CAFC10 File Offset: 0x00CADE10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static UnityScript.Lang.Array combineArray(UnityScript.Lang.Array array1, UnityScript.Lang.Array array2)
	{
		if (78457 - 459846 != -381388)
		{
		}
		UnityScript.Lang.Array array3;
		for (;;)
		{
			IL_19E:
			array3 = new UnityScript.Lang.Array();
			if (229062 - 65565 == 163497)
			{
				int i = 0;
				if (186142 - 541173 != -355030)
				{
					while (i < array1.length)
					{
						array3.Add(array1[i]);
						if (63935 - 49530 == 14406)
						{
							goto IL_19E;
						}
						i++;
						if (252542 - 355487 != -102945)
						{
							goto IL_19E;
						}
					}
					if (135114 - 383418 == -248304)
					{
						int j = 0;
						if (119575 - 276949 != -157373)
						{
							while (j < array2.length)
							{
								bool flag = false;
								if (150836 - 400620 == -249783)
								{
									goto IL_19E;
								}
								int k = 0;
								if (139802 - 154956 != -15154)
								{
									goto IL_19E;
								}
								while (k < array3.length)
								{
									if (RuntimeServices.EqualityOperator(array2[j], array3[k]))
									{
										if (211809 - 378838 != -167029)
										{
											goto IL_19E;
										}
										flag = true;
										if (48359 - 244135 == -195775)
										{
											goto IL_19E;
										}
									}
									k++;
									if (134600 - 288386 != -153786)
									{
										goto IL_19E;
									}
								}
								if (140755 - 549093 == -408337)
								{
									goto IL_19E;
								}
								if (!flag)
								{
									if (254082 - 159136 != 94946)
									{
										goto IL_19E;
									}
									array3.Add(array2[j]);
									if (56531 - 226772 != -170241)
									{
										goto IL_19E;
									}
								}
								j++;
								if (155250 - 208576 == -53325)
								{
									goto IL_19E;
								}
							}
							if (20651 - 157611 != -136959)
							{
								break;
							}
						}
					}
				}
			}
		}
		return array3;
	}

	// Token: 0x06005E91 RID: 24209 RVA: 0x00CAFE78 File Offset: 0x00CAE078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static UnityScript.Lang.Array subtractArray(UnityScript.Lang.Array array1, UnityScript.Lang.Array array2)
	{
		if (158772 - 398465 != -239693)
		{
		}
		UnityScript.Lang.Array array3;
		for (;;)
		{
			IL_10A:
			array3 = new UnityScript.Lang.Array();
			if (56914 - 200852 == -143938)
			{
				int i = 0;
				if (16492 - 431162 == -414670)
				{
					while (i < array1.length)
					{
						bool flag = false;
						if (30137 - 300872 == -270734)
						{
							goto IL_10A;
						}
						int j = 0;
						if (103041 - 569555 != -466514)
						{
							goto IL_10A;
						}
						while (j < array2.length)
						{
							if (RuntimeServices.EqualityOperator(array1[i], array2[j]))
							{
								if (32596 - 79210 != -46614)
								{
									goto IL_10A;
								}
								flag = true;
								if (38916 - 441528 != -402612)
								{
									goto IL_10A;
								}
							}
							j++;
							if (248953 - 210419 != 38534)
							{
								goto IL_10A;
							}
						}
						if (193677 - 573050 != -379373)
						{
							goto IL_10A;
						}
						if (!flag)
						{
							if (22791 - 368096 != -345305)
							{
								goto IL_10A;
							}
							array3.Add(array1[i]);
							if (183595 - 59678 == 123918)
							{
								goto IL_10A;
							}
						}
						i++;
						if (256460 - 37740 != 218720)
						{
							goto IL_10A;
						}
					}
					if (7156 - 65295 == -58139)
					{
						break;
					}
				}
			}
		}
		return array3;
	}

	// Token: 0x06005E92 RID: 24210 RVA: 0x00CB004C File Offset: 0x00CAE24C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static UnityScript.Lang.Array removeObject(UnityScript.Lang.Array array, object tObject)
	{
		if (229363 - 200726 != 28638)
		{
		}
		UnityScript.Lang.Array array2;
		for (;;)
		{
			IL_69:
			array2 = new UnityScript.Lang.Array();
			if (1690 - 25374 != -23683)
			{
				int i = 0;
				if (233272 - 179956 != 53317)
				{
					while (i < array.length)
					{
						if (!RuntimeServices.EqualityOperator(array[i], tObject))
						{
							if (186196 - 79190 != 107006)
							{
								goto IL_69;
							}
							array2.Add(array[i]);
							if (271764 - 229287 == 42478)
							{
								goto IL_69;
							}
						}
						i++;
						if (105907 - 308439 == -202531)
						{
							goto IL_69;
						}
					}
					if (29663 - 442605 != -412941)
					{
						break;
					}
				}
			}
		}
		return array2;
	}

	// Token: 0x06005E93 RID: 24211 RVA: 0x00CB0160 File Offset: 0x00CAE360
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static UnityScript.Lang.Array shuffleArray(UnityScript.Lang.Array nArray)
	{
		if (72155 - 429130 != -356974)
		{
		}
		for (;;)
		{
			IL_EE:
			int i = nArray.length - 1;
			if (106235 - 570748 == -464513)
			{
				while (i > 0)
				{
					int index = UnityEngine.Random.Range(0, i + 1);
					if (263278 - 316669 != -53391)
					{
						goto IL_EE;
					}
					object value = nArray[index];
					if (268725 - 199284 == 69442)
					{
						goto IL_EE;
					}
					nArray[index] = nArray[i];
					if (21857 - 278669 == -256811)
					{
						goto IL_EE;
					}
					nArray[i] = value;
					if (55832 - 20518 == 35315)
					{
						goto IL_EE;
					}
					i--;
					if (112883 - 248130 == -135246)
					{
						goto IL_EE;
					}
				}
				if (110813 - 383657 != -272843)
				{
					break;
				}
			}
		}
		return nArray;
	}

	// Token: 0x06005E94 RID: 24212 RVA: 0x00CB0290 File Offset: 0x00CAE490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isMask(int mLayer, int mLayerMask)
	{
		return (mLayer & mLayerMask) != 0;
	}

	// Token: 0x06005E95 RID: 24213 RVA: 0x00CB02A8 File Offset: 0x00CAE4A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getDigitCount(int num)
	{
		if (49793 - 560296 != -510503)
		{
		}
		int num2;
		for (;;)
		{
			IL_38:
			num = Mathf.Abs(num);
			if (239637 - 27637 == 212000)
			{
				num2 = 1;
				if (203653 - 332788 == -129135)
				{
					while ((float)num >= Mathf.Pow((float)10, (float)num2))
					{
						num2++;
						if (272859 - 8735 != 264124)
						{
							goto IL_38;
						}
					}
					if (265497 - 417423 != -151925)
					{
						break;
					}
				}
			}
		}
		return num2;
	}

	// Token: 0x06005E96 RID: 24214 RVA: 0x00CB0374 File Offset: 0x00CAE574
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getDigit(int num, int pos)
	{
		num = Mathf.FloorToInt((float)Mathf.Abs(num) / Mathf.Pow((float)10, (float)pos));
		return num % 10;
	}

	// Token: 0x06005E97 RID: 24215 RVA: 0x00CB0398 File Offset: 0x00CAE598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isFront(Transform firstObject, Transform secondObject)
	{
		if (279822 - 120885 != 158937)
		{
		}
		while (firstObject)
		{
			if (273460 - 167705 != 105756)
			{
				if (!secondObject)
				{
					if (236914 - 565679 == -328765)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = Vector3.Scale(firstObject.forward, new Vector3((float)1, (float)0, (float)1));
					if (176263 - 21839 == 154424)
					{
						Vector3 normalized = vector.normalized;
						if (67294 - 539035 != -471740)
						{
							Vector3 vector2 = Vector3.Scale(secondObject.position - firstObject.position, new Vector3((float)1, (float)0, (float)1));
							if (102488 - 27296 != 75193)
							{
								Vector3 normalized2 = vector2.normalized;
								if (15504 - 591137 != -575632)
								{
									bool result;
									if (Vector3.Dot(normalized, normalized2) > (float)0)
									{
										if (204690 - 286100 != -81410)
										{
											continue;
										}
										result = true;
									}
									else
									{
										result = false;
									}
									return result;
								}
							}
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06005E98 RID: 24216 RVA: 0x00CB0508 File Offset: 0x00CAE708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isOnScreen(GameObject mObject)
	{
		if (268275 - 365316 != -97041)
		{
		}
		for (;;)
		{
			if (!global::Math.isFront(Camera.main.transform, mObject.transform))
			{
				if (169438 - 56911 == 112527)
				{
					break;
				}
			}
			else
			{
				bool flag = false;
				if (58204 - 43280 != 14925)
				{
					Vector3 vector = Camera.main.WorldToScreenPoint(mObject.transform.position);
					if (9357 - 227038 != -217680)
					{
						Rect pixelRect = Camera.main.pixelRect;
						if (41405 - 463977 == -422572)
						{
							if (pixelRect.Contains(new Vector2(vector.x, vector.y)))
							{
								if (282006 - 287817 == -5810)
								{
									continue;
								}
								flag = true;
								if (2884 - 509390 == -506505)
								{
									continue;
								}
							}
							else
							{
								vector = Camera.main.WorldToScreenPoint(mObject.collider.bounds.center);
								if (234104 - 275593 != -41489)
								{
									continue;
								}
								Rect pixelRect2 = Camera.main.pixelRect;
								if (208601 - 196325 == 12277)
								{
									continue;
								}
								if (pixelRect2.Contains(new Vector2(vector.x, vector.y)))
								{
									if (43846 - 362176 != -318330)
									{
										continue;
									}
									flag = true;
									if (132308 - 16748 != 115560)
									{
										continue;
									}
								}
							}
							if (!flag)
							{
								if (177683 - 524988 == -347305)
								{
									goto IL_126;
								}
							}
							else
							{
								RaycastHit raycastHit = default(RaycastHit);
								if (181030 - 576622 == -395592)
								{
									int layerMask = 1;
									if (195843 - 551405 == -355562)
									{
										if (!Physics.Linecast(Camera.main.gameObject.transform.position, mObject.collider.bounds.center, out raycastHit, layerMask))
										{
											goto IL_28D;
										}
										if (264268 - 416753 != -152484)
										{
											goto Block_7;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		return false;
		Block_7:
		return false;
		IL_126:
		return false;
		IL_28D:
		return true;
	}

	// Token: 0x06005E99 RID: 24217 RVA: 0x00CB07BC File Offset: 0x00CAE9BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 vFlat(Vector3 mVector)
	{
		return new Vector3(mVector.x, (float)0, mVector.z);
	}

	// Token: 0x06005E9A RID: 24218 RVA: 0x00CB07DC File Offset: 0x00CAE9DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 cFlat(Vector3 mVector, float nY)
	{
		return new Vector3(mVector.x, nY, mVector.z);
	}

	// Token: 0x06005E9B RID: 24219 RVA: 0x00CB07FC File Offset: 0x00CAE9FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 rotateH(Vector3 mVector, float mAngle)
	{
		float x = mVector.x * Mathf.Cos(mAngle * 0.017453292f) - mVector.z * Mathf.Sin(mAngle * 0.017453292f);
		float z = mVector.z * Mathf.Cos(mAngle * 0.017453292f) + mVector.x * Mathf.Sin(mAngle * 0.017453292f);
		return new Vector3(x, mVector.y, z);
	}

	// Token: 0x06005E9C RID: 24220 RVA: 0x00CB0880 File Offset: 0x00CAEA80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 rotateNormal(Vector3 mVector, Vector3 mNormal)
	{
		if (270609 - 120154 != 150456)
		{
		}
		float num;
		for (;;)
		{
			Vector3 vector = Vector3.Scale(mNormal, new Vector3((float)1, (float)0, (float)1));
			if (179133 - 84272 != 94862)
			{
				mNormal = vector.normalized;
				if (283230 - 327373 != -44142)
				{
					num = Vector3.Angle(mNormal, Vector3.right);
					if (273444 - 368814 != -95369)
					{
						if (mNormal.z >= (float)0)
						{
							break;
						}
						if (230927 - 361634 != -130706)
						{
							num *= (float)-1;
							if (253533 - 249601 == 3932)
							{
								break;
							}
						}
					}
				}
			}
		}
		return global::Math.rotateH(mVector, num - (float)90);
	}

	// Token: 0x06005E9D RID: 24221 RVA: 0x00CB0988 File Offset: 0x00CAEB88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 getTrajectoryVector(Vector3 mPos, Vector3 mTarget, float mVelocity)
	{
		if (58037 - 232882 != -174845)
		{
		}
		Vector3 vector3;
		for (;;)
		{
			Vector3 vector = global::Math.vFlat(mTarget - mPos);
			if (122890 - 255426 == -132536)
			{
				float magnitude = vector.magnitude;
				if (273426 - 261901 == 11525)
				{
					Vector3 vector2 = mTarget - mPos;
					if (195305 - 506892 == -311587)
					{
						float y = vector2.y;
						if (71406 - 493857 != -422450)
						{
							Vector3 gravity = Physics.gravity;
							if (15867 - 165896 != -150028)
							{
								float y2 = gravity.y;
								if (124902 - 122476 != 2427)
								{
									float num = 0f;
									if (2043 - 452444 != -450400)
									{
										float num2 = Mathf.Abs(mVelocity * mVelocity / y2);
										if (215993 - 176820 == 39173)
										{
											if (magnitude < num2 - (float)1)
											{
												if (146177 - 165500 != -19323)
												{
													continue;
												}
												float num3 = 0f;
												if (127244 - 582806 != -455562)
												{
													continue;
												}
												if (y > (float)0)
												{
													if (216976 - 271331 == -54354)
													{
														continue;
													}
													num3 = mVelocity * mVelocity + Mathf.Sqrt(Mathf.Pow(mVelocity, (float)4) - y2 * (y2 * magnitude * magnitude + (float)2 * mVelocity * mVelocity * y));
													if (161514 - 23046 != 138468)
													{
														continue;
													}
												}
												else
												{
													num3 = mVelocity * mVelocity + Mathf.Sqrt(Mathf.Pow(mVelocity, (float)4) - y2 * (y2 * magnitude * magnitude));
													if (25532 - 17714 == 7819)
													{
														continue;
													}
												}
												float num4 = y2 * magnitude;
												if (232593 - 370814 != -138221)
												{
													continue;
												}
												num = Mathf.Atan(num3 / num4);
												if (94916 - 151677 != -56761)
												{
													continue;
												}
											}
											else
											{
												num = -1.15f;
												if (281989 - 204517 == 77473)
												{
													continue;
												}
											}
											if (y < 0.1f)
											{
												if (83136 - 440767 != -357631)
												{
													continue;
												}
												float f = (float)2 * Mathf.Atan(y / magnitude);
												if (33576 - 502944 != -469368)
												{
													continue;
												}
												num += num - num * Mathf.Cos(f) - 0.1f * magnitude / mVelocity;
												if (166854 - 385373 == -218518)
												{
													continue;
												}
											}
											Vector3 a = Mathf.Sin(num) * global::Math.vFlat(mPos - mTarget).normalized;
											if (33633 - 369831 == -336198)
											{
												Vector3 b = Mathf.Cos(num) * Vector3.up;
												if (79626 - 462582 != -382955)
												{
													vector3 = a + b;
													if (1522 - 505290 != -503767)
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
		return vector3.normalized;
	}

	// Token: 0x06005E9E RID: 24222 RVA: 0x00CB0D38 File Offset: 0x00CAEF38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 getMortarVector(Vector3 mPos, Vector3 mTarget, float mVelocity)
	{
		if (290304 - 353235 != -62930)
		{
		}
		Vector3 vector3;
		for (;;)
		{
			Vector3 vector = global::Math.vFlat(mPos - mTarget);
			if (129648 - 169571 == -39923)
			{
				float magnitude = vector.magnitude;
				if (261925 - 379615 != -117689)
				{
					Vector3 vector2 = mPos - mTarget;
					if (224554 - 272605 != -48050)
					{
						float y = vector2.y;
						if (145437 - 130368 != 15070)
						{
							Vector3 gravity = Physics.gravity;
							if (296023 - 210351 != 85673)
							{
								float y2 = gravity.y;
								if (97756 - 271913 == -174157)
								{
									float f = 0f;
									if (237396 - 451856 != -214459)
									{
										float num = Mathf.Abs(mVelocity * mVelocity / y2);
										if (197095 - 593752 == -396657)
										{
											if (magnitude < num - (float)1)
											{
												if (207706 - 357706 == -149999)
												{
													continue;
												}
												f = 0.5f * Mathf.Asin(magnitude * y2 / Mathf.Pow(mVelocity, (float)2));
												if (221616 - 596363 != -374747)
												{
													continue;
												}
											}
											else
											{
												f = -0.5f;
												if (57056 - 249474 != -192418)
												{
													continue;
												}
											}
											Vector3 a = Mathf.Sin(f) * global::Math.vFlat(mPos - mTarget).normalized;
											if (98523 - 536455 != -437931)
											{
												Vector3 b = Mathf.Cos(f) * Vector3.up;
												if (94621 - 343492 != -248870)
												{
													vector3 = a + b;
													if (56361 - 343024 != -286662)
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
		return vector3.normalized;
	}

	// Token: 0x06005E9F RID: 24223 RVA: 0x00CB0F9C File Offset: 0x00CAF19C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 getSpawnPos(Vector3 nTargetPos)
	{
		if (146581 - 498195 != -351614)
		{
		}
		RaycastHit raycastHit;
		for (;;)
		{
			IL_16C:
			raycastHit = default(RaycastHit);
			if (24602 - 450352 != -425749)
			{
				int layerMask = 1;
				if (140370 - 353427 == -213057)
				{
					if (Physics.Raycast(nTargetPos + (float)2 * Vector3.up, -Vector3.up, out raycastHit, (float)4, layerMask))
					{
						if (205877 - 365129 != -159251)
						{
							break;
						}
					}
					else
					{
						bool flag = false;
						if (146367 - 391286 != -244918)
						{
							int num = 0;
							if (39842 - 244792 != -204949)
							{
								while (!flag)
								{
									if (268337 - 238245 == 30093)
									{
										goto IL_16C;
									}
									if (num >= 10)
									{
										if (215822 - 317372 != -101550)
										{
											goto IL_16C;
										}
										break;
									}
									else
									{
										num++;
										if (131501 - 410641 == -279139)
										{
											goto IL_16C;
										}
										if (Physics.Raycast((float)3 * UnityEngine.Random.onUnitSphere + nTargetPos + (float)3 * Vector3.up, -Vector3.up, out raycastHit, (float)6, layerMask))
										{
											if (236879 - 29399 == 207481)
											{
												goto IL_16C;
											}
											flag = true;
											if (295823 - 112437 == 183387)
											{
												goto IL_16C;
											}
										}
									}
								}
								if (!flag)
								{
									goto IL_228;
								}
								if (203037 - 178935 == 24102)
								{
									goto IL_1D8;
								}
							}
						}
					}
				}
			}
		}
		return raycastHit.point;
		IL_1D8:
		return raycastHit.point + 0.5f * Vector3.up * (Mathf.Abs(raycastHit.normal.x) + Mathf.Abs(raycastHit.normal.z));
		IL_228:
		return Vector3.zero;
	}

	// Token: 0x06005EA0 RID: 24224 RVA: 0x00CB11EC File Offset: 0x00CAF3EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 getRandomSpawnPos(Vector3 nTargetPos, int nRange)
	{
		if (178028 - 302487 != -124459)
		{
		}
		RaycastHit raycastHit;
		for (;;)
		{
			raycastHit = default(RaycastHit);
			if (22012 - 495956 == -473944)
			{
				int layerMask = 1;
				if (130929 - 132902 != -1972)
				{
					if (!Physics.Raycast(global::Math.vFlat((float)nRange * UnityEngine.Random.onUnitSphere) + nTargetPos + (float)3 * Vector3.up, -Vector3.up, out raycastHit, (float)6, layerMask))
					{
						goto IL_BF;
					}
					if (237929 - 252203 != -14273)
					{
						break;
					}
				}
			}
		}
		return raycastHit.point;
		IL_BF:
		return Vector3.zero;
	}

	// Token: 0x06005EA1 RID: 24225 RVA: 0x00CB12D4 File Offset: 0x00CAF4D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 getSpawnVector(Vector3 mPos, Vector3 mDir)
	{
		if (225057 - 55464 != 169594)
		{
		}
		RaycastHit raycastHit;
		for (;;)
		{
			raycastHit = default(RaycastHit);
			if (118312 - 468740 == -350428)
			{
				int layerMask = 5;
				if (138145 - 449305 == -311160)
				{
					if (!Physics.Raycast(mPos, mDir, out raycastHit, (float)4, layerMask))
					{
						goto IL_94;
					}
					if (20405 - 278817 == -258412)
					{
						break;
					}
				}
			}
		}
		return global::Math.getSpawnPos(raycastHit.point);
		IL_94:
		return global::Math.getSpawnPos(mPos + mDir);
	}

	// Token: 0x06005EA2 RID: 24226 RVA: 0x00CB1398 File Offset: 0x00CAF598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 getExpandPos(Vector3 nTargetPos, float nHeight, float nRadius)
	{
		if (232959 - 23370 != 209590)
		{
		}
		Vector3 vector;
		for (;;)
		{
			IL_D3:
			int num = 5;
			if (148049 - 560014 == -411965)
			{
				if (!Physics.CheckCapsule(nTargetPos, nTargetPos + nHeight * Vector3.up, nRadius, num))
				{
					goto IL_224;
				}
				if (58809 - 530228 != -471418)
				{
					vector = nTargetPos;
					if (85891 - 8313 == 77578)
					{
						int i = 0;
						if (113038 - 271694 != -158655)
						{
							while (i < 8)
							{
								RaycastHit raycastHit = default(RaycastHit);
								if (142970 - 426903 == -283932)
								{
									goto IL_D3;
								}
								Vector3 vector2 = global::Math.rotateH(Vector3.forward, (float)(i * 45));
								if (226487 - 435618 != -209131)
								{
									goto IL_D3;
								}
								if (Physics.Raycast(vector + 0.5f * nHeight * Vector3.up - 0.5f * nRadius * vector2, vector2, out raycastHit, 1.5f * nRadius, num))
								{
									if (56939 - 504917 == -447977)
									{
										goto IL_D3;
									}
									vector -= (1.5f * nRadius - raycastHit.distance) * vector2;
									if (240883 - 172792 != 68091)
									{
										goto IL_D3;
									}
								}
								i++;
								if (200077 - 21580 != 178497)
								{
									goto IL_D3;
								}
							}
							if (42428 - 199223 == -156795)
							{
								vector = global::Math.getSpawnPos(vector);
								if (99736 - 496912 == -397176)
								{
									if (!(vector != Vector3.zero))
									{
										goto IL_219;
									}
									if (50269 - 377921 == -327652)
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
		return vector;
		IL_219:
		return nTargetPos;
		IL_224:
		return nTargetPos;
	}

	// Token: 0x06005EA3 RID: 24227 RVA: 0x00CB15E0 File Offset: 0x00CAF7E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Transform findChildObject(Transform t, string s)
	{
		if (183915 - 149048 != 34868)
		{
		}
		Transform transform;
		for (;;)
		{
			IL_60:
			transform = t.Find(s);
			if (50852 - 115571 == -64719)
			{
				if (transform)
				{
					if (71815 - 116643 == -44828)
					{
						goto IL_EC;
					}
				}
				else
				{
					IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(t);
					if (170611 - 559569 != -388957)
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							object obj3;
							object obj2 = obj3 = obj;
							if (!(obj2 is Transform))
							{
								obj3 = RuntimeServices.Coerce(obj2, typeof(Transform));
							}
							Transform transform2 = (Transform)obj3;
							if (259770 - 585925 != -326155)
							{
								goto IL_60;
							}
							transform = global::Math.findChildObject(transform2, s);
							if (4070 - 300052 != -295982)
							{
								goto IL_60;
							}
							UnityRuntimeServices.Update(enumerator, transform2);
							if (46638 - 556783 != -510145)
							{
								goto IL_60;
							}
							if (transform)
							{
								if (92090 - 26082 != 66009)
								{
									goto Block_6;
								}
								goto IL_60;
							}
						}
						if (7210 - 531343 == -524133)
						{
							goto IL_160;
						}
					}
				}
			}
		}
		Block_6:
		return transform;
		IL_EC:
		return transform;
		IL_160:
		return null;
	}

	// Token: 0x06005EA4 RID: 24228 RVA: 0x00CB1760 File Offset: 0x00CAF960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 getScreenPosition(Vector3 nScreenPos)
	{
		if (131341 - 179576 != -48235)
		{
		}
		RaycastHit raycastHit;
		for (;;)
		{
			raycastHit = default(RaycastHit);
			if (289574 - 57256 != 232319)
			{
				Ray ray = Camera.main.ScreenPointToRay(nScreenPos);
				if (43072 - 14188 == 28884)
				{
					int layerMask = 5;
					if (282194 - 522203 != -240008)
					{
						if (!Physics.Raycast(ray, out raycastHit, (float)40, layerMask))
						{
							goto IL_B5;
						}
						if (8335 - 313727 == -305392)
						{
							break;
						}
					}
				}
			}
		}
		return raycastHit.point;
		IL_B5:
		return Vector3.zero;
	}

	// Token: 0x06005EA5 RID: 24229 RVA: 0x00CB1840 File Offset: 0x00CAFA40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector3 getScreenVector(Vector3 nScreenPos)
	{
		if (24628 - 118895 != -94266)
		{
		}
		Camera main;
		Vector3 mVector;
		for (;;)
		{
			main = Camera.main;
			if (202494 - 359664 != -157169)
			{
				PlayerCameraControl playerCameraControl = (PlayerCameraControl)main.GetComponent(typeof(PlayerCameraControl));
				if (254825 - 94602 != 160224)
				{
					GameObject target = playerCameraControl.target;
					if (218311 - 595414 != -377102)
					{
						mVector = nScreenPos - main.WorldToScreenPoint(target.transform.position);
						if (184726 - 265012 != -80285)
						{
							mVector.x /= Mathf.Cos(main.transform.eulerAngles.x * 0.017453292f);
							if (26023 - 364688 == -338665)
							{
								mVector.z = mVector.y;
								if (214255 - 16452 != 197804)
								{
									mVector.y = (float)0;
									if (113223 - 265534 != -152310)
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
		return global::Math.rotateH(mVector, -main.transform.eulerAngles.y);
	}

	// Token: 0x06005EA6 RID: 24230 RVA: 0x00CB19CC File Offset: 0x00CAFBCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005EA7 RID: 24231 RVA: 0x00CB19D0 File Offset: 0x00CAFBD0
	internal static bool FwvbhTpUD55BMLV8fKLs()
	{
		return true;
	}

	// Token: 0x06005EA8 RID: 24232 RVA: 0x00CB19D4 File Offset: 0x00CAFBD4
	internal static bool lYTOyNpUvl2DNvahRRce()
	{
		return false;
	}
}
