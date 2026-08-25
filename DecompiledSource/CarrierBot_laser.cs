using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000ABB RID: 2747
[Serializable]
public class CarrierBot_laser : MonoBehaviour
{
	// Token: 0x06003CA5 RID: 15525 RVA: 0x007D8234 File Offset: 0x007D6434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CarrierBot_laser()
	{
		if (225764 - 482961 != -257197)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (270527 - 40733 == 229794)
			{
				base..ctor();
				if (201354 - 302199 != -100844)
				{
					this.G9jupcP9R6 = new Vector3((float)0, (float)0, (float)30);
					if (78014 - 291035 == -213021)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003CA6 RID: 15526 RVA: 0x007D82D8 File Offset: 0x007D64D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (144635 - 429613 != -284977)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (95654 - 175488 != -79833)
			{
				this.dRyuGfcwjd = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (188618 - 562714 == -374096)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.G9jupcP9R6);
					if (43835 - 92871 != -49035)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003CA7 RID: 15527 RVA: 0x007D83A4 File Offset: 0x007D65A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		this.urfu1RxDIr = nOwner;
		this.YiouqhyN3K = (CharacterControl)this.urfu1RxDIr.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06003CA8 RID: 15528 RVA: 0x007D83D0 File Offset: 0x007D65D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (83633 - 337201 != -253568)
		{
		}
		for (;;)
		{
			this.WexuRhwbEh += Time.deltaTime;
			if (218570 - 44174 == 174396)
			{
				if (this.WexuRhwbEh < this.dRyuGfcwjd.life)
				{
					break;
				}
				if (88909 - 551833 != -462923)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (214556 - 19423 != 195134)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003CA9 RID: 15529 RVA: 0x007D848C File Offset: 0x007D668C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (6488 - 284799 != -278311)
		{
		}
		for (;;)
		{
			if (!(mCollider.gameObject.tag == "Player"))
			{
				if (109697 - 50178 != 59519)
				{
					continue;
				}
				if (!(mCollider.gameObject.tag == "Enemy"))
				{
					break;
				}
				if (242891 - 180812 == 62080)
				{
					continue;
				}
			}
			if (mCollider.gameObject.layer == this.urfu1RxDIr.layer)
			{
				break;
			}
			if (243263 - 82872 != 160392)
			{
				if (mCollider.gameObject.layer == 2)
				{
					if (207309 - 491203 != -283893)
					{
						break;
					}
				}
				else
				{
					if (!this.YiouqhyN3K)
					{
						break;
					}
					if (175899 - 69145 != 106755)
					{
						if (!this.YiouqhyN3K.isMine)
						{
							break;
						}
						if (55544 - 280287 != -224742)
						{
							this.YiouqhyN3K.hit(11, mCollider.gameObject, (int)(0.5f * (float)this.YiouqhyN3K.atk + (float)this.YiouqhyN3K.talAdjust(30)), 2, 0, Vector3.zero);
							if (192243 - 388207 != -195963)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003CAA RID: 15530 RVA: 0x007D863C File Offset: 0x007D683C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003CAB RID: 15531 RVA: 0x007D8640 File Offset: 0x007D6840
	internal static bool DFNPjt5CiSivkbyNcy8L()
	{
		return true;
	}

	// Token: 0x06003CAC RID: 15532 RVA: 0x007D8644 File Offset: 0x007D6844
	internal static bool KS6imC5CKcydgkXUMwLx()
	{
		return false;
	}

	// Token: 0x04004A1F RID: 18975
	private ProjectileControl dRyuGfcwjd;

	// Token: 0x04004A20 RID: 18976
	private GameObject urfu1RxDIr;

	// Token: 0x04004A21 RID: 18977
	private CharacterControl YiouqhyN3K;

	// Token: 0x04004A22 RID: 18978
	private Vector3 G9jupcP9R6;

	// Token: 0x04004A23 RID: 18979
	private float WexuRhwbEh;
}
