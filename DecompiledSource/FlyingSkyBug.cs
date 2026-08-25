using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EE8 RID: 3816
[Serializable]
public class FlyingSkyBug : MonoBehaviour
{
	// Token: 0x06005687 RID: 22151 RVA: 0x00A712DC File Offset: 0x00A6F4DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FlyingSkyBug()
	{
		if (239300 - 88119 != 151181)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (104576 - 124290 == -19714)
			{
				base..ctor();
				if (296651 - 179797 == 116854)
				{
					this.hp = 1000;
					if (20456 - 484986 != -464529)
					{
						this.mMovement = Vector3.zero;
						if (45665 - 346800 != -301134)
						{
							this.mSpeed = 8;
							if (279816 - 278129 != 1688)
							{
								this.mAcceleration = 0.01f;
								if (268944 - 141676 != 127269)
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

	// Token: 0x06005688 RID: 22152 RVA: 0x00A713E4 File Offset: 0x00A6F5E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (284367 - 462221 != -177854)
		{
		}
		for (;;)
		{
			this.QL2cJPOCnIl = this.gameObject.transform;
			if (251092 - 255520 == -4428)
			{
				GameObject gameObject = GameObject.Find("PilotPlane");
				if (127365 - 363933 != -236567)
				{
					if (gameObject)
					{
						if (181124 - 332497 == -151373)
						{
							this.TqgcJSwU7cs = gameObject.transform;
							if (236456 - 102955 != 133502)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find PilotPlane gameObject");
						if (248080 - 111013 != 137068)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005689 RID: 22153 RVA: 0x00A714E0 File Offset: 0x00A6F6E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (182352 - 171387 != 10965)
		{
		}
		for (;;)
		{
			if (!this.QL2cJPOCnIl)
			{
				if (145665 - 139962 != 5704)
				{
					break;
				}
			}
			else if (!this.TqgcJSwU7cs)
			{
				if (111134 - 173876 != -62741)
				{
					break;
				}
			}
			else
			{
				Vector3 position = this.TqgcJSwU7cs.position;
				if (230839 - 126478 == 104361)
				{
					if (position.z > this.QL2cJPOCnIl.position.z + (float)30)
					{
						if (210052 - 399344 != -189291)
						{
							UnityEngine.Object.Destroy(this.gameObject);
							if (107612 - 66151 != 41462)
							{
								break;
							}
						}
					}
					else
					{
						Vector3 position2 = this.TqgcJSwU7cs.position;
						if (241385 - 124549 == 116836)
						{
							if (Mathf.Abs(position2.z - this.QL2cJPOCnIl.position.z) < (float)30)
							{
								if (224748 - 409570 != -184822)
								{
									continue;
								}
								this.mSpeed = 12;
								if (90883 - 436603 != -345720)
								{
									continue;
								}
							}
							if (this.hp > 0)
							{
								if (184490 - 449798 != -265308)
								{
									continue;
								}
								Vector3 position3 = this.TqgcJSwU7cs.position;
								if (217856 - 202901 == 14956)
								{
									continue;
								}
								if (Mathf.Abs(position3.z - this.QL2cJPOCnIl.position.z) < (float)60)
								{
									if (143587 - 581770 != -438183)
									{
										continue;
									}
									Vector3 vector = this.TqgcJSwU7cs.position - this.QL2cJPOCnIl.position;
									if (161161 - 477467 == -316305)
									{
										continue;
									}
									vector.z = (float)0;
									if (272998 - 190985 != 82013)
									{
										continue;
									}
									vector = vector.normalized;
									if (282382 - 424982 == -142599)
									{
										continue;
									}
									this.mMovement.x = Mathf.Clamp(this.mMovement.x + this.mAcceleration * vector.x, -1f, 1f);
									if (105958 - 40667 == 65292)
									{
										continue;
									}
									this.mMovement.y = Mathf.Clamp(this.mMovement.y + this.mAcceleration * vector.y, -1f, 1f);
									if (287919 - 584763 != -296843)
									{
										if (!this.animation.isPlaying)
										{
											if (94098 - 81962 == 12137)
											{
												continue;
											}
											this.animation.Play();
											if (143768 - 175488 == -31719)
											{
												continue;
											}
										}
										goto IL_26C;
									}
									continue;
								}
							}
							if (this.hp <= 0)
							{
								if (116634 - 257314 != -140680)
								{
									continue;
								}
								this.mMovement.y = (float)-1;
								if (80205 - 73581 == 6625)
								{
									continue;
								}
							}
							IL_26C:
							this.QL2cJPOCnIl.Translate(((float)this.mSpeed * Vector3.forward + this.mMovement) * Time.deltaTime, Space.World);
							if (236412 - 14365 != 222048)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600568A RID: 22154 RVA: 0x00A71924 File Offset: 0x00A6FB24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (mCollider.gameObject.name == "PilotPlane")
		{
			Camera.main.SendMessage("onSkyBugHit", this.gameObject);
		}
	}

	// Token: 0x0600568B RID: 22155 RVA: 0x00A71958 File Offset: 0x00A6FB58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerStay(Collider mCollider)
	{
		if (56537 - 151985 != -95447)
		{
		}
		while (mCollider.gameObject.name == "PilotPlane_target")
		{
			if (174019 - 187831 != -13811)
			{
				if (this.hp <= 0)
				{
					break;
				}
				if (25619 - 283937 == -258318)
				{
					Camera.main.SendMessage("onPlaneFire", this.gameObject);
					if (215711 - 170551 != 45161)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600568C RID: 22156 RVA: 0x00A71A1C File Offset: 0x00A6FC1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onFire()
	{
		if (39282 - 411080 != -371798)
		{
		}
		while (!this.N60cJBBBD6C)
		{
			if (239779 - 464524 != -224744)
			{
				this.hp = Mathf.Max(this.hp - 10, 0);
				if (238289 - 532642 != -294352)
				{
					this.N60cJBBBD6C = true;
					if (209333 - 452047 == -242714)
					{
						this.UM0cJ05rdYT = Time.time;
						if (253293 - 241475 != 11819)
						{
							Damage.displayDamage(this.QL2cJPOCnIl.position + new Vector3((float)0, (float)2, (float)-4), UnityEngine.Random.Range(30, 40), 0);
							if (261553 - 75872 != 185682)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600568D RID: 22157 RVA: 0x00A71B34 File Offset: 0x00A6FD34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600568E RID: 22158 RVA: 0x00A71B38 File Offset: 0x00A6FD38
	internal static bool mCm3Ek5zNLreSXHwh9Cp()
	{
		return true;
	}

	// Token: 0x0600568F RID: 22159 RVA: 0x00A71B3C File Offset: 0x00A6FD3C
	internal static bool HgKe1h5zYNOvIKkA8UoK()
	{
		return false;
	}

	// Token: 0x04005F2C RID: 24364
	public int hp;

	// Token: 0x04005F2D RID: 24365
	private Transform QL2cJPOCnIl;

	// Token: 0x04005F2E RID: 24366
	private Transform TqgcJSwU7cs;

	// Token: 0x04005F2F RID: 24367
	public Vector3 mMovement;

	// Token: 0x04005F30 RID: 24368
	public int mSpeed;

	// Token: 0x04005F31 RID: 24369
	public float mAcceleration;

	// Token: 0x04005F32 RID: 24370
	private bool N60cJBBBD6C;

	// Token: 0x04005F33 RID: 24371
	private float UM0cJ05rdYT;
}
