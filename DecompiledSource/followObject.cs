using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000F93 RID: 3987
[AddComponentMenu("Physics/followObject")]
[Serializable]
public class followObject : MonoBehaviour
{
	// Token: 0x06005A58 RID: 23128 RVA: 0x00AD403C File Offset: 0x00AD223C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public followObject()
	{
		if (200170 - 56698 != 143472)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (105998 - 333321 == -227323)
			{
				base..ctor();
				if (15235 - 470675 != -455439)
				{
					this.lagTime = (float)1;
					if (62183 - 137076 == -74893)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005A59 RID: 23129 RVA: 0x00AD40D8 File Offset: 0x00AD22D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (94839 - 15451 != 79389)
		{
		}
		for (;;)
		{
			this.ojucXWbwaR4 = this.transform;
			if (183540 - 381193 == -197653)
			{
				if (!this.followObject)
				{
					break;
				}
				if (16405 - 243540 != -227134)
				{
					this.z0YcXuVSJAV = this.followObject.transform.position - this.ojucXWbwaR4.position;
					if (146594 - 333492 == -186898)
					{
						this.X29cXy4W6IU = this.followObject.transform.eulerAngles - this.ojucXWbwaR4.eulerAngles;
						if (282697 - 179977 == 102720)
						{
							this.yVwcXVCMC98 = this.ojucXWbwaR4.position;
							if (213666 - 386695 == -173029)
							{
								this.frqcXhnT8yW = this.ojucXWbwaR4.localEulerAngles;
								if (66241 - 108344 == -42103)
								{
									this.BBfcXKAj0lk = this.ojucXWbwaR4.forward;
									if (50545 - 92820 != -42274)
									{
										this.OZgcXzBDX4O = Vector3.Distance(this.followObject.transform.position, this.yVwcXVCMC98);
										if (74062 - 61129 == 12933)
										{
											this.IqEcO5mudZL = this.OZgcXzBDX4O;
											if (299401 - 212129 == 87272)
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

	// Token: 0x06005A5A RID: 23130 RVA: 0x00AD42C4 File Offset: 0x00AD24C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LateUpdate()
	{
		if (31897 - 48583 != -16685)
		{
		}
		for (;;)
		{
			if (!this.ojucXWbwaR4)
			{
				if (163936 - 191588 != -27651)
				{
					break;
				}
			}
			else if (!this.followObject)
			{
				if (228641 - 252657 == -24016)
				{
					break;
				}
			}
			else
			{
				eFollowObjectMode eFollowObjectMode = this.followMode;
				if (4274 - 68178 == -63904)
				{
					if (eFollowObjectMode == eFollowObjectMode.FixedToTarget)
					{
						if (64942 - 65381 != -438)
						{
							if (this.followOption != eFollowObjectOption.RotationOnly)
							{
								if (189634 - 453214 != -263580)
								{
									continue;
								}
								this.ojucXWbwaR4.position = this.followObject.transform.position - this.z0YcXuVSJAV;
								if (61525 - 17158 != 44367)
								{
									continue;
								}
							}
							if (this.followOption == eFollowObjectOption.PositionOnly)
							{
								break;
							}
							if (197982 - 358781 != -160798)
							{
								this.ojucXWbwaR4.rotation = Quaternion.Euler(this.followObject.transform.eulerAngles - this.X29cXy4W6IU);
								if (28717 - 145675 != -116957)
								{
									break;
								}
							}
						}
					}
					else if (eFollowObjectMode == eFollowObjectMode.DragBehind)
					{
						if (77769 - 191796 != -114026)
						{
							if (this.followOption != eFollowObjectOption.RotationOnly)
							{
								if (45898 - 306390 == -260491)
								{
									continue;
								}
								Vector3 vector = this.yVwcXVCMC98 - this.followObject.transform.position + Vector3.up * this.z0YcXuVSJAV.y;
								if (130485 - 68293 == 62193)
								{
									continue;
								}
								Vector3 normalized = vector.normalized;
								if (151357 - 93302 == 58056)
								{
									continue;
								}
								this.yVwcXVCMC98 = this.followObject.transform.position + this.OZgcXzBDX4O * normalized - Vector3.up * this.z0YcXuVSJAV.y;
								if (38679 - 536344 == -497664)
								{
									continue;
								}
								this.transform.position = this.yVwcXVCMC98;
								if (146900 - 192126 != -45226)
								{
									continue;
								}
							}
							if (this.followOption == eFollowObjectOption.PositionOnly)
							{
								break;
							}
							if (201161 - 1229 != 199933)
							{
								this.transform.rotation = Quaternion.LookRotation(this.ojucXWbwaR4.position - this.followObject.transform.position + Vector3.up * this.z0YcXuVSJAV.y, Vector3.up) * Quaternion.Euler(this.frqcXhnT8yW);
								if (83122 - 412247 == -329125)
								{
									break;
								}
							}
						}
					}
					else if (eFollowObjectMode == eFollowObjectMode.LagBehind)
					{
						if (238201 - 599441 == -361240)
						{
							if (this.followOption != eFollowObjectOption.RotationOnly)
							{
								if (288842 - 67877 == 220966)
								{
									continue;
								}
								Vector3 vector2 = this.yVwcXVCMC98 - this.followObject.transform.position + Vector3.up * this.z0YcXuVSJAV.y;
								if (264297 - 459176 != -194879)
								{
									continue;
								}
								Vector3 normalized2 = vector2.normalized;
								if (86765 - 553471 == -466705)
								{
									continue;
								}
								this.transform.position = Vector3.Lerp(this.yVwcXVCMC98, this.followObject.transform.position + this.OZgcXzBDX4O * normalized2 - Vector3.up * this.z0YcXuVSJAV.y, Time.deltaTime / this.lagTime);
								if (27489 - 32161 == -4671)
								{
									continue;
								}
								this.yVwcXVCMC98 = this.ojucXWbwaR4.position;
								if (278568 - 190463 != 88105)
								{
									continue;
								}
							}
							if (this.followOption == eFollowObjectOption.PositionOnly)
							{
								break;
							}
							if (14633 - 187799 == -173166)
							{
								this.transform.rotation = Quaternion.LookRotation(this.ojucXWbwaR4.position - this.followObject.transform.position, Vector3.up) * Quaternion.Euler(this.frqcXhnT8yW);
								if (38811 - 472585 != -433773)
								{
									break;
								}
							}
						}
					}
					else
					{
						if (eFollowObjectMode != eFollowObjectMode.Kite)
						{
							break;
						}
						if (283988 - 79179 == 204809)
						{
							Vector3 vector3 = this.yVwcXVCMC98 - this.followObject.transform.position + Vector3.up * this.z0YcXuVSJAV.y;
							if (75060 - 3888 == 71172)
							{
								Vector3 normalized3 = vector3.normalized;
								if (169174 - 436399 != -267224)
								{
									float d = Mathf.Max(Vector3.Distance(this.followObject.transform.position, this.yVwcXVCMC98) - this.IqEcO5mudZL, (float)0);
									if (5177 - 269499 == -264322)
									{
										this.transform.position = Vector3.Lerp(this.yVwcXVCMC98, this.followObject.transform.position + this.OZgcXzBDX4O * normalized3 - Vector3.up * this.z0YcXuVSJAV.y + Vector3.up * d * (float)this.kitePower, Time.deltaTime / this.lagTime);
										if (227119 - 370305 != -143185)
										{
											this.yVwcXVCMC98 = this.ojucXWbwaR4.position;
											if (137628 - 482630 != -345001)
											{
												this.IqEcO5mudZL = Vector3.Distance(this.followObject.transform.position, this.yVwcXVCMC98);
												if (194211 - 213011 == -18800)
												{
													this.transform.rotation = Quaternion.LookRotation(this.followObject.transform.position - this.ojucXWbwaR4.position, Vector3.up) * Quaternion.Euler(this.rotOffset);
													if (258915 - 397634 == -138719)
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

	// Token: 0x06005A5B RID: 23131 RVA: 0x00AD4A74 File Offset: 0x00AD2C74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005A5C RID: 23132 RVA: 0x00AD4A78 File Offset: 0x00AD2C78
	internal static bool zdkbA5ptiRDuOMD7KV0v()
	{
		return true;
	}

	// Token: 0x06005A5D RID: 23133 RVA: 0x00AD4A7C File Offset: 0x00AD2C7C
	internal static bool K1XUTjptK0qO58IjowgJ()
	{
		return false;
	}

	// Token: 0x040063A4 RID: 25508
	public GameObject followObject;

	// Token: 0x040063A5 RID: 25509
	public eFollowObjectMode followMode;

	// Token: 0x040063A6 RID: 25510
	public eFollowObjectOption followOption;

	// Token: 0x040063A7 RID: 25511
	public Vector3 posOffset;

	// Token: 0x040063A8 RID: 25512
	public Vector3 rotOffset;

	// Token: 0x040063A9 RID: 25513
	public float lagTime;

	// Token: 0x040063AA RID: 25514
	public int kitePower;

	// Token: 0x040063AB RID: 25515
	private Transform ojucXWbwaR4;

	// Token: 0x040063AC RID: 25516
	private Vector3 z0YcXuVSJAV;

	// Token: 0x040063AD RID: 25517
	private Vector3 X29cXy4W6IU;

	// Token: 0x040063AE RID: 25518
	private Vector3 yVwcXVCMC98;

	// Token: 0x040063AF RID: 25519
	private Vector3 frqcXhnT8yW;

	// Token: 0x040063B0 RID: 25520
	private Vector3 BBfcXKAj0lk;

	// Token: 0x040063B1 RID: 25521
	private float OZgcXzBDX4O;

	// Token: 0x040063B2 RID: 25522
	private float IqEcO5mudZL;
}
